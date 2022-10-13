namespace LibraryDBMS.Forms
{
    partial class DialogAddUpdateBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDEWEYCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetCategoryID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(133, 113);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(131, 26);
            this.txtBookID.TabIndex = 1;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(133, 158);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(131, 26);
            this.txtISBN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // txtDEWEYCode
            // 
            this.txtDEWEYCode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDEWEYCode.Location = new System.Drawing.Point(133, 207);
            this.txtDEWEYCode.Name = "txtDEWEYCode";
            this.txtDEWEYCode.Size = new System.Drawing.Size(131, 26);
            this.txtDEWEYCode.TabIndex = 5;
            this.txtDEWEYCode.TextChanged += new System.EventHandler(this.txtDEWEYCode_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEWEY Code:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(133, 259);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(131, 26);
            this.txtTitle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(133, 316);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(131, 26);
            this.txtAuthor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Author:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(133, 367);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(131, 26);
            this.txtPublisher.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Publisher:";
            // 
            // txtPages
            // 
            this.txtPages.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPages.Location = new System.Drawing.Point(454, 113);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(131, 26);
            this.txtPages.TabIndex = 15;
            this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyKeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pages";
            // 
            // txtOthers
            // 
            this.txtOthers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthers.Location = new System.Drawing.Point(454, 166);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(131, 81);
            this.txtOthers.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Other:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(454, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 26);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyKeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantity:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.Location = new System.Drawing.Point(454, 324);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(131, 26);
            this.txtCategoryID.TabIndex = 21;
            this.txtCategoryID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyKeyPress);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(328, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Category ID:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(328, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Date Added:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Publish Year:";
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnOperation.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOperation.Location = new System.Drawing.Point(12, 476);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(96, 56);
            this.btnOperation.TabIndex = 27;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.Button_Click);
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.CustomFormat = "dd-MM-yyyy";
            this.dtpDateAdded.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAdded.Location = new System.Drawing.Point(454, 417);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(131, 26);
            this.dtpDateAdded.TabIndex = 29;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(133, 422);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(131, 26);
            this.txtYear.TabIndex = 31;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyKeyPress);
            // 
            // lblBook
            // 
            this.lblBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblBook.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBook.Location = new System.Drawing.Point(5, 9);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(590, 45);
            this.lblBook.TabIndex = 24;
            this.lblBook.Text = "Book";
            this.lblBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::LibraryDBMS.Properties.Resources.close_16px;
            this.btnClose.Location = new System.Drawing.Point(520, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(404, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 56);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGetCategoryID
            // 
            this.btnGetCategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnGetCategoryID.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCategoryID.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetCategoryID.Location = new System.Drawing.Point(332, 364);
            this.btnGetCategoryID.Name = "btnGetCategoryID";
            this.btnGetCategoryID.Size = new System.Drawing.Size(253, 44);
            this.btnGetCategoryID.TabIndex = 34;
            this.btnGetCategoryID.Text = "Category ID From DEWEY Code";
            this.btnGetCategoryID.UseVisualStyleBackColor = false;
            this.btnGetCategoryID.Click += new System.EventHandler(this.Button_Click);
            // 
            // DialogAddUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 544);
            this.Controls.Add(this.btnGetCategoryID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDEWEYCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogAddUpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDEWEYCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetCategoryID;
    }
}