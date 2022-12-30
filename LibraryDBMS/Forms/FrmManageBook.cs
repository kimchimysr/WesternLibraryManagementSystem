﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageBook : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string bookID) selected;


        public FrmManageBook(FrmMainMenu _frmMainMenu)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            frmMainMenu = _frmMainMenu;
            InitailizeValues();
        }

        private void InitailizeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvBookList);
            Utils.ClearSelectionAfterDataBindingDataGridView(dgvBookList);
            //Utils.EnableRightClickInCells(dgvBookList);
            Utils.FillComboBox(cbSearchBy, true, "Book ID", "ISBN", "DEWEY", "Title",
                "Author", "Publisher", "Publish Year");
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBookList);
            Utils.ToolTipOnControlMouseHover
                ("Shortcuts Combination Key:" +
                 "\n* Add Button (Alt + A)" +
                 "\n* Edit Button (Alt + E)" +
                 "\n* Delete Button (Alt + D)" +
                 "\n* View Information Button (Alt + V)", pShortcuts);
            PopulateDataGridView();
            btnPrint.Enabled = dgvBookList.Rows.Count > 0 ? true : false;
        }

        internal void PopulateDataGridView()
        {
            LibModule.FillDataGrid("viewBooks", dgvBookList, "bookID");
            lblBookCount.Text = "Total Books: " +
                    LibModule.ExecuteScalarQuery("SELECT SUM(qty) FROM tblBooks;");
            lblTitleCount.Text = "Total Titles: " +
                    LibModule.ExecuteScalarQuery("SELECT COUNT(bookID) FROM tblBooks;");
            lblRowsCount.Text = $"Display Result: {dgvBookList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            txtSearchValue.Clear();
            btnSearch.Enabled = false;
            btnFilter.Enabled = true;
            Utils.SetFromDateAYearFromNow(dtpFromDate,dtpToDate);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnPrint":
                    Utils.BlurEffect.Blur(frmMainMenu);
                    var parameters = new Dictionary<string, string>();
                    parameters.Add("username", frmMainMenu.user.Rows[0]["username"].ToString());
                    parameters.Add("totalBook", lblBookCount.Text.Substring(13));
                    var dialogReportViewer = new DialogReportViewer(dgvBookList,
                        "LibraryDBMS.Reports.RpBook.rdlc", "Book", parameters);
                    dialogReportViewer.ShowDialog();
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnSearch":
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Book ID")
                            LibModule.SearchAndFillDataGrid("viewBooks", "bookID", value, dgvBookList, false);
                        else if (searchBy == "ISBN")
                            LibModule.SearchAndFillDataGrid("viewBooks", "isbn", value, dgvBookList);
                        else if (searchBy == "DEWEY")
                            LibModule.SearchAndFillDataGrid("viewBooks", "dewey", value, dgvBookList);
                        else if (searchBy == "Title")
                            LibModule.SearchAndFillDataGrid("viewBooks", "title", value, dgvBookList);
                        else if (searchBy == "Author")
                            LibModule.SearchAndFillDataGrid("viewBooks", "author", value, dgvBookList);
                        else if (searchBy == "Publisher")
                            LibModule.SearchAndFillDataGrid("viewBooks", "publisher", value, dgvBookList);
                        else if (searchBy == "Publish Year")
                            LibModule.SearchAndFillDataGrid("viewBooks", "publishYear", value, dgvBookList, false);
                        lblRowsCount.Text = $"Display Result: {dgvBookList.Rows.Count}";
                    }
                    break;
                case "btnFilter":
                    if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                    {
                        if (dtpToDate.Value > DateTime.Now)
                            dtpToDate.Value = DateTime.Now;
                        string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                        string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                        LibModule.SearchBetweenDateAndFillDataGrid("viewBooks", dgvBookList, "dateAdded", fromDate, toDate);
                        lblRowsCount.Text = $"Display Result: {dgvBookList.Rows.Count}";
                    }
                    else
                    {
                        MessageBox.Show("(From Date) should not be more than (To Date)", "Warning Invalid Date Span",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpFromDate.Focus();
                    }
                    break;
                case "btnAdd":
                    var dialogAddEditBook = new DialogAddEditBook(this);
                    Utils.BlurEffect.ShowDialogWithBlurEffect(dialogAddEditBook, frmMainMenu);
                    break;
                case "btnEdit":
                    var frmAddEditBook =
                        new DialogAddEditBook(this, LibModule.GetSingleRecordFromDB("tblBooks", "bookID", selected.bookID));
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddEditBook, frmMainMenu);
                    break;
                case "btnDelete":
                    Utils.BlurEffect.Blur(frmMainMenu);
                    if (LibModule.DeleteRecord("tblBooks", "bookID", selected.bookID,
                        Utils.GetDataGridSelectedRowData(dgvBookList, selected.rowIndex)) == true)
                        PopulateDataGridView();
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnView":
                    var frmViewDetail = new DialogViewDetail(dgvBookList, selected.rowIndex, "Book");
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmViewDetail, frmMainMenu);
                    break;
                case "btnRefresh":
                    PopulateDataGridView();
                    break;
            }
            btnPrint.Enabled = dgvBookList.Rows.Count > 0 ? true : false;
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvBookList.Rows[e.RowIndex].Cells["bookID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnSearch);
            if (txtSearchValue.Text.Length == 0)
                btnRefresh.PerformClick();
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearchValue.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // disable beep sounde
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dtpFromAndToDate_ValueChanged(object sender,EventArgs e)
        {
            if(dtpFromDate.Value > dtpToDate.Value && dtpFromDate.Value < DateTime.Now)
            {
                btnFilter.Enabled = false;
                Utils.ToolTipOnControlMouseHover("The From Date Value is more" +
                    " than To Date Value", dtpFromDate);
            }
            else if(dtpFromDate.Value > DateTime.Now)
            {
                btnFilter.Enabled = false;
                Utils.ToolTipOnControlMouseHover("The From Date value should not" +
                    " set in the future", btnFilter);
            }
            else
                btnFilter.Enabled = true;
        }
    }
}