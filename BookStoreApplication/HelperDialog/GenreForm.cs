using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.HelperDialog
{
    public partial class GenreForm : Form
    {

        BookStoreEntities dbContext = new BookStoreEntities();
        public GenreForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            tbgenreID.Text = GetNewGenreId().ToString();
            tbgenreName.Text = "";
        }
        private int GetNewGenreId()
        {
            int genreId = 1;
            Genre genre = dbContext.Genres
                .OrderByDescending(x => x.GenreID)
                .FirstOrDefault();

            if (genre != null)
            {
                return genre.GenreID + 1;
            }

            return 1;
        }

        private void LoadData()
        {
            dgGenre.Rows.Clear();
            foreach (Genre genre in dbContext.Genres)
            {
                dgGenre.Rows.Add(genre.GenreID, genre.GenreName);
            }

        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = tbgenreName;
            LoadData();
        }

        private void btngenreSave_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.GenreID = GetNewGenreId();
            genre.GenreName = tbgenreName.Text;
            dbContext.Genres.Add(genre);
            dbContext.SaveChanges();
            Clear();
            LoadData();
            MessageBox.Show("Added new Genre!");
        }

        private void btngenreDelete_Click(object sender, EventArgs e)
        {
            if (dgGenre.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this genre?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int genreID = (int)dgGenre.SelectedRows[0].Cells["GenreID"].Value;
                    Genre selectedGenre = dbContext.Genres.Find(genreID);
                    dbContext.Genres.Remove(selectedGenre);
                    dbContext.SaveChanges();
                    LoadData();
                    MessageBox.Show("Genre has been successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("No row is selected!");
            }
        }
    }
}
