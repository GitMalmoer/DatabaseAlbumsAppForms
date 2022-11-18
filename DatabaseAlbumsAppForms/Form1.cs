namespace DatabaseAlbumsAppForms
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadAlbums_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();

            albums = albumDAO.GetAllAlbums();

            albumBindingSource.DataSource = albums;
            dataGridAlbums.DataSource = albumBindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();
            albumBindingSource.DataSource = albumDAO.SearchAlbum(txtSearch.Text);
            dataGridAlbums.DataSource=albumBindingSource;
        }


        private void dataGridAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            

            

            //get the row number
            int rowClicked = dataGridView.CurrentRow.Index;

            string ImageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            pctrImage.Load(ImageURL);

            int rowID = int.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());

            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridTracks.DataSource = tracksBindingSource;



        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumTitle = txtName.Text,
                Artist = txtArtist.Text,
                Year = int.Parse(txtYear.Text),
                ImageURL = txtImageUrl.Text,
                Description = txtDescription.Text,
            };

            AlbumDAO albumDAO = new AlbumDAO();
            int result = albumDAO.AddOneAlbum(album);

            MessageBox.Show("The number of rows inserted: " + result);
        }
    }
}