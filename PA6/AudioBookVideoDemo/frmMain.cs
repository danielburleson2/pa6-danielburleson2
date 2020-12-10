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
    public partial class frmMain : Form
    {
        string cwid;
        List<Book> myBooks;
        public frmMain(string tempCwid)
        {
            this.cwid = tempCwid;
            InitializeComponent();
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }
        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            lstBooks.DataSource = myBooks;
        }
        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)lstBooks.SelectedItem;
            txtTitleData.Text = myBook.title;
            txtAuthorData.Text = myBook.author;
            txtGenreData.Text = myBook.genre;
            txtIsbnData.Text = myBook.isbn;
            txtCopiesData.Text = myBook.copies.ToString();
            txtLengthData.Text = myBook.length.ToString();

            try
            {
                pbCover.Load(myBook.cover);
            }
            catch
            {

            }

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Book mybook = (Book)lstBooks.SelectedItem;

            mybook.copies--;
            BookFile.SaveBook(mybook, cwid, "edit");
            this.LoadList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Book mybook = (Book)lstBooks.SelectedItem;

            mybook.copies++;
            BookFile.SaveBook(mybook, cwid, "edit");
            this.LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book mybook = (Book)lstBooks.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BookFile.DeleteBook(mybook, cwid);
                this.LoadList();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Book mybook = (Book)lstBooks.SelectedItem;
            frmEdit myForm = new frmEdit(mybook, "edit", cwid);
            if(myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.LoadList();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Book mybook = new Book();
            frmEdit myForm = new frmEdit(mybook, "new", cwid);
            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.LoadList();
            }
        }
    }
}
