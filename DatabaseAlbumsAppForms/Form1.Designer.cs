namespace DatabaseAlbumsAppForms
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
            this.btnLoadAlbums = new System.Windows.Forms.Button();
            this.dataGridAlbums = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pctrImage = new System.Windows.Forms.PictureBox();
            this.grpAddAlbum = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.dataGridTracks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrImage)).BeginInit();
            this.grpAddAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadAlbums
            // 
            this.btnLoadAlbums.Location = new System.Drawing.Point(277, 12);
            this.btnLoadAlbums.Name = "btnLoadAlbums";
            this.btnLoadAlbums.Size = new System.Drawing.Size(138, 29);
            this.btnLoadAlbums.TabIndex = 0;
            this.btnLoadAlbums.Text = "Load Albums";
            this.btnLoadAlbums.UseVisualStyleBackColor = true;
            this.btnLoadAlbums.Click += new System.EventHandler(this.btnLoadAlbums_Click);
            // 
            // dataGridAlbums
            // 
            this.dataGridAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlbums.Location = new System.Drawing.Point(277, 47);
            this.dataGridAlbums.Name = "dataGridAlbums";
            this.dataGridAlbums.RowHeadersWidth = 51;
            this.dataGridAlbums.RowTemplate.Height = 29;
            this.dataGridAlbums.Size = new System.Drawing.Size(719, 199);
            this.dataGridAlbums.TabIndex = 1;
            this.dataGridAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAlbums_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(421, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(540, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // pctrImage
            // 
            this.pctrImage.Location = new System.Drawing.Point(1016, 12);
            this.pctrImage.Name = "pctrImage";
            this.pctrImage.Size = new System.Drawing.Size(181, 171);
            this.pctrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrImage.TabIndex = 4;
            this.pctrImage.TabStop = false;
            // 
            // grpAddAlbum
            // 
            this.grpAddAlbum.Controls.Add(this.txtDescription);
            this.grpAddAlbum.Controls.Add(this.txtImageUrl);
            this.grpAddAlbum.Controls.Add(this.txtYear);
            this.grpAddAlbum.Controls.Add(this.txtArtist);
            this.grpAddAlbum.Controls.Add(this.txtName);
            this.grpAddAlbum.Controls.Add(this.label5);
            this.grpAddAlbum.Controls.Add(this.label4);
            this.grpAddAlbum.Controls.Add(this.label3);
            this.grpAddAlbum.Controls.Add(this.label2);
            this.grpAddAlbum.Controls.Add(this.label1);
            this.grpAddAlbum.Controls.Add(this.btnAddAlbum);
            this.grpAddAlbum.Location = new System.Drawing.Point(12, 12);
            this.grpAddAlbum.Name = "grpAddAlbum";
            this.grpAddAlbum.Size = new System.Drawing.Size(245, 234);
            this.grpAddAlbum.TabIndex = 5;
            this.grpAddAlbum.TabStop = false;
            this.grpAddAlbum.Text = "Add Album";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 154);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(125, 27);
            this.txtDescription.TabIndex = 10;
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(89, 121);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(125, 27);
            this.txtImageUrl.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(89, 88);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 27);
            this.txtYear.TabIndex = 8;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(89, 56);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(125, 27);
            this.txtArtist.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ImageURL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(6, 196);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(94, 29);
            this.btnAddAlbum.TabIndex = 0;
            this.btnAddAlbum.Text = "Add album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // dataGridTracks
            // 
            this.dataGridTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTracks.Location = new System.Drawing.Point(277, 263);
            this.dataGridTracks.Name = "dataGridTracks";
            this.dataGridTracks.RowHeadersWidth = 51;
            this.dataGridTracks.RowTemplate.Height = 29;
            this.dataGridTracks.Size = new System.Drawing.Size(719, 188);
            this.dataGridTracks.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 524);
            this.Controls.Add(this.dataGridTracks);
            this.Controls.Add(this.grpAddAlbum);
            this.Controls.Add(this.pctrImage);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridAlbums);
            this.Controls.Add(this.btnLoadAlbums);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrImage)).EndInit();
            this.grpAddAlbum.ResumeLayout(false);
            this.grpAddAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTracks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadAlbums;
        private DataGridView dataGridAlbums;
        private Button btnSearch;
        private TextBox txtSearch;
        private PictureBox pctrImage;
        private GroupBox grpAddAlbum;
        private TextBox txtDescription;
        private TextBox txtImageUrl;
        private TextBox txtYear;
        private TextBox txtArtist;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddAlbum;
        private DataGridView dataGridTracks;
    }
}