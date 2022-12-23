﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WULibraryManagementSystem.Libs;

namespace WesternLibraryManagement.Forms
{
    public partial class FormViewBookCategory : Form
    {
        public FormViewBookCategory()
        {
            InitializeComponent();
        }

        private void FormViewBookCategory_Load(object sender, EventArgs e)
        {
            LibModule.FillDataGridView("tblBookCategory",dgvBookCategories);
        }
    }
}
