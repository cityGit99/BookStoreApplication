using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public partial class MainForm : Form
    {
        private BookStoreEntities dbContext;
        public MainForm()
        {
            InitializeComponent();
            dbContext = new BookStoreEntities();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = dbContext.Books.Select(b => new
            {
                b.BookID,
                b.BookName,
                Author = b.Author.AuthorFullName,
                PublishingHouses = b.PublishingHous.PublishingHouseName,
                b.NumberOfPages,
                Genre = b.Genre.GenreName,
                b.DateofPublishing,
                b.PrimeCost,
                b.SalePrice,
                b.IsSequel
            }).ToList();
            dataGridViewBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddEditBookForm addBookForm = new AddEditBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value;
                Book selectedBook = dbContext.Books.Find(bookId);
                AddEditBookForm editBookForm = new AddEditBookForm(selectedBook);

                if(editBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value;
                Book selectedBook = dbContext.Books.Find(bookId);
                dbContext.Books.Remove(selectedBook);
                dbContext.SaveChanges();
                LoadBooks();
            }
        }
    }
}
