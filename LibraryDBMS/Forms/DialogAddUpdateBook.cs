using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;
namespace LibraryDBMS.Forms
{
    public partial class DialogAddUpdateBook : Form
    {
        #region Global variable
        private FrmBook frmBook;
        private DataTable dataTable;
        private bool isEditMode;
        private bool isNumberOrBackSpace;
        private int cateIDFromDEWEYCode { get; set; }
        private string DEWEYCode { get; set; }
        private int firstThreeDigitsOfDEWEYCode { get; set; }


        //validate year 
        
        Regex validateYear = new Regex("^[0-2]{1}[0-9]{3}$");
        #endregion
        public DialogAddUpdateBook()
        {
            InitializeComponent();
        }
        #region Method We write
        public DialogAddUpdateBook(FrmBook formOpenFromFrmBook,DataTable dataTableUser = null)
        {
            InitializeComponent();
            isEditMode = dataTableUser == null ? false : true;
            frmBook = formOpenFromFrmBook; 
            dataTable = dataTableUser;
            if (!isEditMode)
            {
                this.btnGetCategoryID.Enabled = false;
                this.Text = "Adding New Book Data";
                this.lblBook.Text = "Add New Book Data";
                this.txtBookID.Text = LibModule.GetAutoID("tblBook","bookID");
                this.btnOperation.Text = "Add";
                this.btnClear.Enabled = true;
            }
            else
            {
                this.btnGetCategoryID.Enabled = false;
                this.Text = " Editing Book Data";
                this.lblBook.Text = "Edit Book Data";
                this.btnOperation.Text = "Edit";
                this.PopulateFields();
                this.btnClear.Enabled = false;
            }
        }
        private void PopulateFields()
        {
            this.txtBookID.Text = dataTable.Rows[0]["bookID"].ToString();
            this.txtISBN.Text = dataTable.Rows[0]["isbn"].ToString();
            this.txtDEWEYCode.Text = dataTable.Rows[0]["dewey"].ToString();
            this.txtTitle.Text = dataTable.Rows[0]["title"].ToString();
            this.txtAuthor.Text = dataTable.Rows[0]["author"].ToString();
            this.txtPublisher.Text = dataTable.Rows[0]["publisher"].ToString();
            this.txtYear.Text= dataTable.Rows[0]["publishYear"].ToString();
            this.txtPages.Text = dataTable.Rows[0]["pages"].ToString();
            this.txtOthers.Text = dataTable.Rows[0]["other"].ToString();
            this.txtQuantity.Text = dataTable.Rows[0]["qty"].ToString();
            this.txtCategoryID.Text = dataTable.Rows[0]["cateID"].ToString();
            this.dtpDateAdded.Value = Convert.ToDateTime(dataTable.Rows[0]["dateAdded"]);
        }
        

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnOperation":
                    if (!Utils.IsEmptyControl(this) && validateYear.IsMatch(this.txtYear.Text))
                    {
                        try
                        {
                            string BookID = txtBookID.Text.Trim();
                            string ISBN = txtISBN.Text.Trim();
                            string DEWEYCode = txtDEWEYCode.Text.Trim();
                            string Title = txtTitle.Text.Trim();
                            string Author = txtAuthor.Text.Trim();
                            string Publisher = txtPublisher.Text.Trim();
                            string PublishYear =  txtYear.Text.Trim();
                            string Pages = txtPages.Text.Trim();
                            string Other = txtOthers.Text.Trim();
                            string Quantity = txtQuantity.Text.Trim();
                            string CategoryID = txtCategoryID.Text.Trim();
                            string DateAdded = DateTime.Now.ToString("dd-MM-yyyy");
                            List<string> book = new List<string>
                            {
                                BookID,
                                ISBN,
                                DEWEYCode,
                                Title,
                                Author,
                                Publisher,
                                PublishYear,
                                Pages,
                                Other,
                                Quantity,
                                CategoryID,
                                DateAdded
                            };
                            if (!isEditMode)
                            {
                                LibModule.InsertRecord("tblBook",LibModule.GetTableField("tblBook"),book);

                            }
                            else
                            {
                                LibModule.UpdateRecord("tblBook", LibModule.GetTableField("tblBook"),"bookID",BookID , book,true);
                            }
                            frmBook.PopulateDataGridView();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                                $"{ex.GetType()}", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else if (!validateYear.IsMatch(this.txtYear.Text) && !Utils.IsEmptyControl(this))
                    {
                        MessageBox.Show("Wrong year format", "Validation warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        this.txtYear.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Fill in info, Do not leave them hanging", " Lack Info ", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                        break;
                case "btnCategory":
                    Form formViewBookCategory = new FrmViewBookCategory();
                    formViewBookCategory.ShowDialog();
                    break ;
                case "btnClear":
                    this.txtISBN.Clear();
                    this.txtDEWEYCode.Clear();
                    this.txtTitle.Clear();
                    this.txtAuthor.Clear();
                    this.txtPublisher.Clear();
                    this.txtYear.Clear();
                    this.txtPages.Clear();
                    this.txtOthers.Clear();
                    this.txtQuantity.Clear();
                    this.txtCategoryID.Clear();
                    this.dtpDateAdded.Value = DateTime.Now;
                    break;
                case "btnGetCategoryID":
                    calculateCategoryID();
                    break;


            }
        }
        private void numberOnlyKeyPress(object sender,KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if ((char.IsNumber(e.KeyChar) || e.KeyChar == 8))
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;

            }
        }
        private int calculateCategoryIDFromDEWEYCode(int DEWEYCode)
        {
            if (DEWEYCode > 0 && DEWEYCode <= 100) { return 1; }
            else if (DEWEYCode > 100 && DEWEYCode <= 200) { return 2; }
            else if (DEWEYCode > 200 && DEWEYCode <= 300) { return 3; }
            else if (DEWEYCode > 300 && DEWEYCode <= 400) { return 4; }
            else if (DEWEYCode > 400 && DEWEYCode <= 500) { return 5; }
            else if (DEWEYCode > 500 && DEWEYCode <= 600) { return 6; }
            else if (DEWEYCode > 600 && DEWEYCode <= 700) { return 7; }
            else if (DEWEYCode > 700 && DEWEYCode <= 800) { return 8; }
            else if (DEWEYCode > 800 && DEWEYCode <= 900) { return 9; }
            else if (DEWEYCode > 900 && DEWEYCode <= 1000) { return 10; }
            else { return 0; }
        }
        private void calculateCategoryID()
        {
            try
            {
                DEWEYCode = this.txtDEWEYCode.Text;
                firstThreeDigitsOfDEWEYCode = Convert.ToInt32(DEWEYCode.Substring(0, 3));
                cateIDFromDEWEYCode = calculateCategoryIDFromDEWEYCode(firstThreeDigitsOfDEWEYCode);
                this.txtCategoryID.Text = cateIDFromDEWEYCode.ToString();
            }
            catch(FormatException fmex)
            {
                MessageBox.Show("Wrong Format","Format Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(ArgumentOutOfRangeException aoorex)
            {
                MessageBox.Show("Missing string from DEWEY Code", "Argument Out Of Range Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDEWEYCode_TextChanged(object sender, EventArgs e)
        {
            string deweyCodeAfterTrim = this.txtDEWEYCode.Text.Trim();
            int  length = deweyCodeAfterTrim.Length;
            if (length >= 3)
            {
                this.btnGetCategoryID.Enabled = true;
            }
            else this.btnGetCategoryID.Enabled = false;
        }
    }
}
