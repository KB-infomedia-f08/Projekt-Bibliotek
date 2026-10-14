namespace Projekt_Bibliotek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dvgMedia = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colCopies = new DataGridViewTextBoxColumn();
            btnDetails = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgMedia).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(371, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(79, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Media";
            // 
            // dvgMedia
            // 
            dvgMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMedia.Columns.AddRange(new DataGridViewColumn[] { colTitle, colType, colCopies });
            dvgMedia.Location = new Point(12, 66);
            dvgMedia.Name = "dvgMedia";
            dvgMedia.Size = new Size(800, 300);
            dvgMedia.TabIndex = 1;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            // 
            // colType
            // 
            colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colType.HeaderText = "Type";
            colType.Name = "colType";
            // 
            // colCopies
            // 
            colCopies.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCopies.HeaderText = "Copies";
            colCopies.Name = "colCopies";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(66, 403);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(112, 23);
            btnDetails.TabIndex = 2;
            btnDetails.Text = "View Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(268, 403);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Media";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(479, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Media";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(671, 403);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove Media";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(884, 461);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDetails);
            Controls.Add(dvgMedia);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = " ";
            Text = "Library";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dvgMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dvgMedia;
        private Button btnDetails;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colCopies;
    }
}
