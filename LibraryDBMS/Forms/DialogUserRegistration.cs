﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogUserRegistration : Form
    {
        private UserValidator uv;

        public DialogUserRegistration()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FillComboBox(cbRole, true, "Librarian");
            txtUserID.Text = LibModule.GetAutoID("tblUser", "userID");
            uv = new UserValidator(txtUsername, txtFirstName, txtLastName, txtAddress, cbRole, txtTelephone, txtEmail);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnRegister":
                    if (this.ValidateChildren())
                    {
                        string userID = txtUserID.Text.Trim();
                        string username = txtUsername.Text.Trim();
                        string roleName = cbRole.Text.Trim();
                        string firstName = txtFirstName.Text.Trim();
                        string lastName = txtLastName.Text.Trim();
                        string gender = rbMale.Checked == true ? "M" : "F";
                        string dob = dtpDOB.Text.Trim();
                        string address = txtAddress.Text.Trim();
                        string telephone = txtTelephone.Text.Trim();
                        string email = txtEmail.Text.Trim();
                        string dateAdded = DateTime.Now.ToString("yyyy-MM-dd");

                        List<string> user = new List<string>
                            {
                                userID,
                                username,
                                roleName,
                                firstName,
                                lastName,
                                gender,
                                dob,
                                address,
                                telephone,
                                email,
                                dateAdded
                            };

                        LibModule.InsertRecord("tblUser", LibModule.GetTableField(DBTable.tblUser), user, false);
                        this.Close();
                    }
                    else MessageBox.Show("Please enter valid data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, false, true, false, false, false);
                    break;
                case "btnCancel":
                case "btnClose":
                    Application.Exit();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
