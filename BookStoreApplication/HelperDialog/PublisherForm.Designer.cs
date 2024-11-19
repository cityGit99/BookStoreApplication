namespace BookStoreApplication.HelperDialog
{
    partial class PublisherForm
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgenreID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngenreDelete = new System.Windows.Forms.Button();
            this.btngenreSave = new System.Windows.Forms.Button();
            this.dgGenre = new System.Windows.Forms.DataGridView();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbgenreName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(90, 213);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(354, 83);
            this.tbAddress.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(89, 169);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(354, 28);
            this.tbContact.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contact";
            // 
            // tbgenreID
            // 
            this.tbgenreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgenreID.Location = new System.Drawing.Point(89, 81);
            this.tbgenreID.Name = "tbgenreID";
            this.tbgenreID.Size = new System.Drawing.Size(354, 28);
            this.tbgenreID.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID";
            // 
            // btngenreDelete
            // 
            this.btngenreDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngenreDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenreDelete.Location = new System.Drawing.Point(357, 310);
            this.btngenreDelete.Name = "btngenreDelete";
            this.btngenreDelete.Size = new System.Drawing.Size(86, 36);
            this.btngenreDelete.TabIndex = 25;
            this.btngenreDelete.Text = "Delete";
            this.btngenreDelete.UseVisualStyleBackColor = false;
            // 
            // btngenreSave
            // 
            this.btngenreSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btngenreSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenreSave.Location = new System.Drawing.Point(251, 310);
            this.btngenreSave.Name = "btngenreSave";
            this.btngenreSave.Size = new System.Drawing.Size(86, 36);
            this.btngenreSave.TabIndex = 24;
            this.btngenreSave.Text = "Add";
            this.btngenreSave.UseVisualStyleBackColor = false;
            // 
            // dgGenre
            // 
            this.dgGenre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenreID,
            this.GenreName,
            this.Contact,
            this.Address});
            this.dgGenre.Location = new System.Drawing.Point(467, 30);
            this.dgGenre.Name = "dgGenre";
            this.dgGenre.ReadOnly = true;
            this.dgGenre.RowHeadersWidth = 51;
            this.dgGenre.RowTemplate.Height = 24;
            this.dgGenre.Size = new System.Drawing.Size(646, 316);
            this.dgGenre.TabIndex = 23;
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
            this.GenreName.Width = 175;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.MinimumWidth = 6;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // tbgenreName
            // 
            this.tbgenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgenreName.Location = new System.Drawing.Point(89, 122);
            this.tbgenreName.Name = "tbgenreName";
            this.tbgenreName.Size = new System.Drawing.Size(354, 28);
            this.tbgenreName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Genre Information";
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 391);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbgenreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngenreDelete);
            this.Controls.Add(this.btngenreSave);
            this.Controls.Add(this.dgGenre);
            this.Controls.Add(this.tbgenreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublisherForm";
            this.Text = "PublisherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbgenreID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenreDelete;
        private System.Windows.Forms.Button btngenreSave;
        private System.Windows.Forms.DataGridView dgGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox tbgenreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}