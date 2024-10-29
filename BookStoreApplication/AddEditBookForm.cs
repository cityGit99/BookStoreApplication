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
    public partial class AddEditBookForm : Form
    {

        private Book book;
        private BookStoreEntities dbContext;
        public AddEditBookForm(Book book = null)
        {
            InitializeComponent();
            dbContext = new BookStoreEntities();
            this.book = book;
        }

        private void AddEditBookForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            
            //Edit Mode
            if (book !=null)
            {
                txtBookName.Text = book.BookName;
                cmbAuthor.SelectedValue = book.AuthorID;
                cmbPublishingHouse.SelectedValue = book.PublishingHouseID;
                txtNumberOfPages.Text = book.NumberOfPages.ToString();
                cmbGenre.SelectedValue = book.GenreID;
                if (book.DateofPublishing.HasValue)
                {
                    dtpDateOfPublishing.Value = book.DateofPublishing.Value;
                }
                else
                {
                   dtpDateOfPublishing.Value = DateTime.Now; 
                }

                txtPrimceCost.Text = book.PrimeCost.ToString();
                txtSalePrice.Text = book.SalePrice.ToString();
                if (book.IsSequel.HasValue)
                {
                    chkIsSequel.Checked = book.IsSequel.Value;
                }
                else
                {
                    chkIsSequel.Checked = false; 
                }
                cmbStatus.SelectedItem = book.Status;
            }
           
        }

        private int GetNewBookId()
        {
            int BookID = 1;
            Book book = dbContext.Books
                .OrderByDescending(x => x.BookID)
                .FirstOrDefault();

            if ( book !=null)
            {
                return book.BookID + 1;
            }

            return 1;
        }

        private void LoadComboBoxes()
        {
            foreach ( Author a in dbContext.Authors)
            {
                cmbAuthor.Items.Add(a.AuthorFullName);
            }

            foreach (PublishingHouses ph in dbContext.PublishingHouses)
            {
                cmbPublishingHouse.Items.Add(ph.PublishingHouseName);
            }

            foreach (Genre g in dbContext.Genres)
            {
                cmbGenre.Items.Add(g.GenreName);
            }

            cmbStatus.Items.AddRange(new string[] { "Available", "Unsellable" });
        }

        private void ClearBoxes()
        {
            txtBookName.Text = "";
            txtNumberOfPages.Text = "";
            txtPrimceCost.Text = "";
            txtSalePrice.Text = "";
            cmbAuthor.Text = "";
            cmbGenre.Text = "";
            cmbPublishingHouse.Text = "";
            cmbStatus.Text = "";
            dtpDateOfPublishing.Text = "";
            chkIsSequel.Checked = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookID = GetNewBookId();
            book.BookName = txtBookName.Text;

            // will update
            string authorName = cmbAuthor.Text;
            var authorID = dbContext.Authors
                    .Where(x => x.AuthorFullName == authorName)
                    .FirstOrDefault().AuthorID;
            book.AuthorID = authorID;

            string publhouse = cmbPublishingHouse.Text;
            var publishingHouseId = dbContext.PublishingHouses
                    .Where(x => x.PublishingHouseName == publhouse)
                    .FirstOrDefault().PublishingHouseID;
            book.PublishingHouseID = publishingHouseId;

            book.NumberOfPages = int.Parse(txtNumberOfPages.Text);

            string gen = cmbGenre.Text;
            var genreId = dbContext.Genres
                .Where(x => x.GenreName == gen)
                .FirstOrDefault().GenreID;

            book.GenreID = genreId;

            book.DateofPublishing = dtpDateOfPublishing.Value;

            book.PrimeCost = decimal.Parse(txtPrimceCost.Text);
            book.SalePrice = decimal.Parse(txtSalePrice.Text);
            book.IsSequel = chkIsSequel.Checked;
            book.Status = cmbStatus.Text;


            if (chkIsSequel.Checked)
            {
                book.IsSequel = true;
            }
            else
            {
                chkIsSequel.Checked = false;
            }

            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("Add Successfully");
            ClearBoxes();

        }

        // Dialog Box Helper
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string newAuthor = HelperDialogBox.ShowDialog("Enter new author name:", "Add Author");
            if (!string.IsNullOrEmpty(newAuthor))
            {
                var author = new Author { AuthorFullName = newAuthor };
                dbContext.Authors.Add(author);
                dbContext.SaveChanges();
                LoadComboBoxes();
                cmbAuthor.SelectedValue = author.AuthorID;
            }

        }
        private void btnAddPublishingHouse_Click(object sender, EventArgs e)
        {
            string newPublishingHouse = HelperDialogBox.ShowDialog("Enter new publishing house name:", "Add Publishing House");
            if (!string.IsNullOrEmpty(newPublishingHouse))
            {
                var publishingHouse = new PublishingHouses { PublishingHouseName = newPublishingHouse };
                dbContext.PublishingHouses.Add(publishingHouse);
                dbContext.SaveChanges();
                LoadComboBoxes();
                cmbPublishingHouse.SelectedValue = publishingHouse.PublishingHouseID;
            }

        }
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string newGenre = HelperDialogBox.ShowDialog("Enter new genre name:", "Add Genre");
            if (!string.IsNullOrEmpty(newGenre))
            {
                var genre = new Genre { GenreName = newGenre };
                dbContext.Genres.Add(genre);
                dbContext.SaveChanges();
                LoadComboBoxes();
                cmbGenre.SelectedValue = genre.GenreID;
            }

        }

    }



}
