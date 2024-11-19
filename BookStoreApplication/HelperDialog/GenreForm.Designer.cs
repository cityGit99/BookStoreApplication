namespace BookStoreApplication.HelperDialog
{
    partial class GenreForm
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
            this.tbgenreID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngenreDelete = new System.Windows.Forms.Button();
            this.btngenreSave = new System.Windows.Forms.Button();
            this.dgGenre = new System.Windows.Forms.DataGridView();
            this.tbgenreName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // tbgenreID
            // 
            this.tbgenreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgenreID.Location = new System.Drawing.Point(107, 118);
            this.tbgenreID.Name = "tbgenreID";
            this.tbgenreID.Size = new System.Drawing.Size(354, 28);
            this.tbgenreID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            // 
            // btngenreDelete
            // 
            this.btngenreDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngenreDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenreDelete.Location = new System.Drawing.Point(375, 206);
            this.btngenreDelete.Name = "btngenreDelete";
            this.btngenreDelete.Size = new System.Drawing.Size(86, 38);
            this.btngenreDelete.TabIndex = 13;
            this.btngenreDelete.Text = "Delete";
            this.btngenreDelete.UseVisualStyleBackColor = false;
            this.btngenreDelete.Click += new System.EventHandler(this.btngenreDelete_Click);
            // 
            // btngenreSave
            // 
            this.btngenreSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btngenreSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenreSave.Location = new System.Drawing.Point(269, 206);
            this.btngenreSave.Name = "btngenreSave";
            this.btngenreSave.Size = new System.Drawing.Size(86, 38);
            this.btngenreSave.TabIndex = 12;
            this.btngenreSave.Text = "Add";
            this.btngenreSave.UseVisualStyleBackColor = false;
            this.btngenreSave.Click += new System.EventHandler(this.btngenreSave_Click);
            // 
            // dgGenre
            // 
            this.dgGenre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenreID,
            this.GenreName});
            this.dgGenre.Location = new System.Drawing.Point(485, 67);
            this.dgGenre.Name = "dgGenre";
            this.dgGenre.ReadOnly = true;
            this.dgGenre.RowHeadersWidth = 51;
            this.dgGenre.RowTemplate.Height = 24;
            this.dgGenre.Size = new System.Drawing.Size(441, 316);
            this.dgGenre.TabIndex = 11;
            // 
            // tbgenreName
            // 
            this.tbgenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgenreName.Location = new System.Drawing.Point(107, 159);
            this.tbgenreName.Name = "tbgenreName";
            this.tbgenreName.Size = new System.Drawing.Size(354, 28);
            this.tbgenreName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Genre Information";
            // 
            // GenreID
            // 
            this.GenreID.HeaderText = "Genre ID";
            this.GenreID.MinimumWidth = 6;
            this.GenreID.Name = "GenreID";
            this.GenreID.ReadOnly = true;
            this.GenreID.Width = 125;
            // 
            // GenreName
            // 
            this.GenreName.HeaderText = "Genre Name";
            this.GenreName.MinimumWidth = 6;
            this.GenreName.Name = "GenreName";
            this.GenreName.ReadOnly = true;
            this.GenreName.Width = 250;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 411);
            this.Controls.Add(this.tbgenreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngenreDelete);
            this.Controls.Add(this.btngenreSave);
            this.Controls.Add(this.dgGenre);
            this.Controls.Add(this.tbgenreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenreForm";
            this.Text = "GenreForm";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbgenreID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenreDelete;
        private System.Windows.Forms.Button btngenreSave;
        private System.Windows.Forms.DataGridView dgGenre;
        private System.Windows.Forms.TextBox tbgenreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreName;
    }
}