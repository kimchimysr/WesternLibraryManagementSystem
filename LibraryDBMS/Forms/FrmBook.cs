using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnAdd":
                    try
                    {
                        Form form = new DialogAddUpdateBook(this);
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                            $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;

                case "btnEdit":
                    try
                    {
                        string id = dgvBooks.SelectedRows[0].Cells["Column1"].Value.ToString();
                        Form frmAddEupdateBook =
                            new DialogAddUpdateBook(this, LibModule.GetSingleRecordDB("tblBook", "bookID", id));
                        frmAddEupdateBook.ShowDialog();
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}",ex.GetType()+"",MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;

                case "btnDelete":
                    string bookID = dgvBooks.SelectedRows[0].Cells["Column1"].Value.ToString();
                    //create dialog to check for delete confirmation from user
                    DialogResult result = MessageBox.Show($"Are your sure you want to Delete the Data From BookID: {bookID}",
                        "Confirmation Delection",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        LibModule.DeleteRecord("tblBook", "bookID", bookID, Utils.GetDataGridSelectedRowData(dgvBooks));
                        FrmBook_Load(sender, e);
                    }
                    else { FrmBook_Load(sender, e); }
                    break;

                case "btnSearch":
                    this.Search();
                    break ;

                case "btnRefresh":
                    FrmBook_Load(sender,e);
                    break;
            }
        }

        


        private void FrmBook_Load(object sender, EventArgs e)
        {

            this.cbbMeanOfSearch.Items.Clear();
            this.txtSearch.Clear();
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnAdd.Enabled = true;
            this.cbbMeanOfSearch.SelectedIndex = -1;
            this.PopulateDataGridView();
        }
        internal DataTable DataTableDataGridViewBook { get; set; }
        private void Search()
        {
            try
            {
                if (this.txtSearch.Text.Length > 0)
                {
                    try
                    {
                        string searchBy = cbbMeanOfSearch.SelectedItem.ToString();
                        string value = this.txtSearch.Text.Trim();
                        if (searchBy == "BookID")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "bookID", value, dgvBooks);
                        }
                        else if (searchBy == "ISBN")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "isbn", value, dgvBooks);
                        }
                        else if (searchBy == "DEWEY")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "dewey", value, dgvBooks);
                        }
                        else if (searchBy == "Title")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "title", value, dgvBooks);
                        }
                        else if (searchBy == "Author")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "author", value, dgvBooks);
                        }
                        else if (searchBy == "Publisher")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "publisher", value, dgvBooks);
                        }
                        else if (searchBy == "Publish Year")
                        {
                            LibModule.SearchAndFillDataGrid("tblBook", "publishYear", value, dgvBooks);
                        }
                        else
                        {
                            MessageBox.Show("Please Select something from the combobox", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                            $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                    $"{ex.GetType()}", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        internal void PopulateDataGridView()
        {

            Utils.FillComboBox(cbbMeanOfSearch, true, "BookID", "ISBN", "DEWEY", "Title", "Author", "Publisher",
                "Publish Year");
            LibModule.FillDataGrid("tblBook", dgvBooks, "bookID");
        }

        private void dgvBooks_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
        }

    }
}
