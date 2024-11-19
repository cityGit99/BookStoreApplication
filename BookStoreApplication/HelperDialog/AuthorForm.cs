using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStoreApplication.HelperDialog
{
    public partial class AuthorForm : Form
    {

        BookStoreEntities dbContext = new BookStoreEntities();
        public AuthorForm()
        {
            InitializeComponent();
        }

        void Clear()
        {

            tbauthorId.Text = GetNewAuthorId().ToString();
            tbauthorName.Text = "";
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = tbauthorName;
            LoadData();
        }

        private void btnauthorSave_Click(object sender, EventArgs e)
        {

            Author author = new Author();
            author.AuthorID = GetNewAuthorId();
            author.AuthorFullName = tbauthorName.Text;
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();
            Clear();
            LoadData();
            MessageBox.Show("Added new Author!");


        }
        private int GetNewAuthorId()
        {
            int authorId = 1;
            Author author = dbContext.Authors
                .OrderByDescending(x => x.AuthorID)
                .FirstOrDefault();

            if (author != null)
            {
                return author.AuthorID + 1;
            }

            return 1;
        }
        private void LoadData()
        {
            dgAuthor.Rows.Clear();
            foreach (Author author in dbContext.Authors)
            {
                dgAuthor.Rows.Add(author.AuthorID, author.AuthorFullName);
            }

        }

        private void btnauthorDelete_Click(object sender, EventArgs e)
        {
            if (dgAuthor.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this author?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int authorID = (int)dgAuthor.SelectedRows[0].Cells["AuthorID"].Value;
                    Author selectedAuthor = dbContext.Authors.Find(authorID);
                    dbContext.Authors.Remove(selectedAuthor);
                    dbContext.SaveChanges();
                    LoadData();
                    MessageBox.Show("Author has been successfully deleted.");
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
