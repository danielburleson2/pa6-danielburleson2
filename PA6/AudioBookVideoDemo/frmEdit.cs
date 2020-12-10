using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioBookVideoDemo
{
    public partial class frmEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;
        public frmEdit(Object tempBook, string tempMode, string tempCwid)
        {
            this.myBook = (Book)tempBook;
            this.mode = tempMode;
            this.cwid = tempCwid;
            InitializeComponent();
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(mode =="edit")
            {
                this.txtTitleData.Text = myBook.title;
                this.txtAuthorData.Text = myBook.author;
                this.txtGenreData.Text = myBook.genre;
                this.txtIsbnData.Text = myBook.isbn;
                this.txtCopiesData.Text = myBook.copies.ToString();
                this.txtLengthData.Text = myBook.length.ToString();
                this.txtCoverData.Text = myBook.cover;
                pbCover.Load(myBook.cover);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myBook.title = this.txtTitleData.Text;
            myBook.author = this.txtAuthorData.Text;
            myBook.genre = this.txtGenreData.Text;
            myBook.isbn = this.txtIsbnData.Text;
            myBook.copies = int.Parse(this.txtCopiesData.Text);
            myBook.length =int.Parse(this.txtLengthData.Text);
            myBook.cover = this.txtCoverData.Text;
            myBook.cwid = cwid;
            BookFile.SaveBook(myBook, cwid, mode);
            MessageBox.Show("Content was saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
