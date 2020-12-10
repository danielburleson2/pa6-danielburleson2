
namespace AudioBookVideoDemo
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.lblCopiesData = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.lblGenreData = new System.Windows.Forms.Label();
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtIsbnData = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(280, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(285, 40);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(211, 34);
            this.txtTitleData.TabIndex = 1;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(285, 112);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(211, 34);
            this.txtAuthorData.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(280, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 29);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(285, 250);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(211, 34);
            this.txtCopiesData.TabIndex = 7;
            // 
            // lblCopiesData
            // 
            this.lblCopiesData.AutoSize = true;
            this.lblCopiesData.Location = new System.Drawing.Point(280, 218);
            this.lblCopiesData.Name = "lblCopiesData";
            this.lblCopiesData.Size = new System.Drawing.Size(194, 29);
            this.lblCopiesData.TabIndex = 6;
            this.lblCopiesData.Text = "Copies Available";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(285, 181);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(211, 34);
            this.txtGenreData.TabIndex = 5;
            // 
            // lblGenreData
            // 
            this.lblGenreData.AutoSize = true;
            this.lblGenreData.Location = new System.Drawing.Point(280, 149);
            this.lblGenreData.Name = "lblGenreData";
            this.lblGenreData.Size = new System.Drawing.Size(80, 29);
            this.lblGenreData.TabIndex = 4;
            this.lblGenreData.Text = "Genre";
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(285, 388);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(211, 34);
            this.txtLengthData.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(280, 356);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(86, 29);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            // 
            // txtIsbnData
            // 
            this.txtIsbnData.Location = new System.Drawing.Point(285, 319);
            this.txtIsbnData.Name = "txtIsbnData";
            this.txtIsbnData.Size = new System.Drawing.Size(211, 34);
            this.txtIsbnData.TabIndex = 9;
            this.txtIsbnData.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(280, 287);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(69, 29);
            this.lblIsbn.TabIndex = 8;
            this.lblIsbn.Text = "ISBN";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 29;
            this.lstBooks.Location = new System.Drawing.Point(26, 12);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(232, 352);
            this.lstBooks.TabIndex = 12;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(526, 40);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(237, 313);
            this.pbCover.TabIndex = 13;
            this.pbCover.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(526, 376);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(105, 36);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(656, 376);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(107, 36);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(285, 453);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 36);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(526, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(404, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 36);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(645, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 36);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 504);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtIsbnData);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.lblCopiesData);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.lblGenreData);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.Label lblCopiesData;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.Label lblGenreData;
        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtIsbnData;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
    }
}