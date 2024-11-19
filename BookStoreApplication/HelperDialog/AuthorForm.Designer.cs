namespace BookStoreApplication.HelperDialog
{
    partial class AuthorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbauthorName = new System.Windows.Forms.TextBox();
            this.dgAuthor = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnauthorSave = new System.Windows.Forms.Button();
            this.btnauthorDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbauthorId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbauthorName
            // 
            this.tbauthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbauthorName.Location = new System.Drawing.Point(93, 112);
            this.tbauthorName.Name = "tbauthorName";
            this.tbauthorName.Size = new System.Drawing.Size(372, 28);
            this.tbauthorName.TabIndex = 2;
            // 
            // dgAuthor
            // 
            this.dgAuthor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.AuthorName});
            this.dgAuthor.Location = new System.Drawing.Point(489, 20);
            this.dgAuthor.Name = "dgAuthor";
            this.dgAuthor.ReadOnly = true;
            this.dgAuthor.RowHeadersWidth = 51;
            this.dgAuthor.RowTemplate.Height = 24;
            this.dgAuthor.Size = new System.Drawing.Size(446, 316);
            this.dgAuthor.TabIndex = 3;
            // 
            // AuthorID
            // 
            this.AuthorID.HeaderText = "Author ID";
            this.AuthorID.MinimumWidth = 6;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Width = 125;
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.MinimumWidth = 6;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 250;
            // 
            // btnauthorSave
            // 
            this.btnauthorSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnauthorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauthorSave.Location = new System.Drawing.Point(273, 159);
            this.btnauthorSave.Name = "btnauthorSave";
            this.btnauthorSave.Size = new System.Drawing.Size(86, 36);
            this.btnauthorSave.TabIndex = 4;
            this.btnauthorSave.Text = "Add";
            this.btnauthorSave.UseVisualStyleBackColor = false;
            this.btnauthorSave.Click += new System.EventHandler(this.btnauthorSave_Click);
            // 
            // btnauthorDelete
            // 
            this.btnauthorDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnauthorDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauthorDelete.Location = new System.Drawing.Point(379, 159);
            this.btnauthorDelete.Name = "btnauthorDelete";
            this.btnauthorDelete.Size = new System.Drawing.Size(86, 36);
            this.btnauthorDelete.TabIndex = 5;
            this.btnauthorDelete.Text = "Delete";
            this.btnauthorDelete.UseVisualStyleBackColor = false;
            this.btnauthorDelete.Click += new System.EventHandler(this.btnauthorDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // tbauthorId
            // 
            this.tbauthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbauthorId.Location = new System.Drawing.Point(93, 71);
            this.tbauthorId.Name = "tbauthorId";
            this.tbauthorId.Size = new System.Drawing.Size(372, 28);
            this.tbauthorId.TabIndex = 7;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 354);
            this.Controls.Add(this.tbauthorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnauthorDelete);
            this.Controls.Add(this.btnauthorSave);
            this.Controls.Add(this.dgAuthor);
            this.Controls.Add(this.tbauthorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorForm";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbauthorName;
        private System.Windows.Forms.DataGridView dgAuthor;
        private System.Windows.Forms.Button btnauthorSave;
        private System.Windows.Forms.Button btnauthorDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbauthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
    }
}