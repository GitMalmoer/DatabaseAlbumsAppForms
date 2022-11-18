using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAlbumsAppForms
{
    internal class AlbumDAO
    {

        string connectionstring = "datasource=localhost;port=3306;username=root;password=root;database=music";

        public List<Album> GetAllAlbums()
        {
            List<Album> returnThese = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM album ORDER BY YEAR ASC;",connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Album album = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumTitle = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };

                    album.Tracks = LoadTracks(album.Id);
                   
                    returnThese.Add(album);
                }
                connection.Close();
                return returnThese;
            }

        }

        public List<Album> SearchAlbum(string searchTerms)
        {
            List<Album> returnThese = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            string searchPhrase = ($"%{searchTerms}%");

            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("SELECT * FROM album WHERE ALBUM_TITLE LIKE @search ORDER BY YEAR ASC;");
            command.Parameters.AddWithValue("@search",searchPhrase);
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumTitle = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(album);
                }
                connection.Close();
                return returnThese;
            }

        }

        public int AddOneAlbum(Album album)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionstring);
            mySqlConnection.Open();

            MySqlCommand command = new MySqlCommand();
            //INSERT INTO `album`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES ('[value-2]','[value-3]','123','[value-5]','[value-6]');
            command.CommandText = ("INSERT INTO album(ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION) VALUES (@albumTitle,@artist,@year,@imageURL,@description)");
            command.Parameters.AddWithValue("@albumTitle",album.AlbumTitle);
            command.Parameters.AddWithValue("@artist",album.Artist);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL",album.ImageURL);
            command.Parameters.AddWithValue("@description",album.Description);
            command.Connection = mySqlConnection;

            int newRows = command.ExecuteNonQuery();
            mySqlConnection.Close();

            return newRows;
        }

        public List<Track> LoadTracks(int albumID)
        {
            List<Track> trackList = new List<Track>();

            MySqlConnection mySqlConnection =new MySqlConnection(connectionstring);
            mySqlConnection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand();

            mySqlCommand.CommandText = ("SELECT * FROM tracks where album_ID = @index");
            mySqlCommand.Parameters.AddWithValue("@index", albumID);
            mySqlCommand.Connection = mySqlConnection;

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while(reader.Read())
                {
                    Track track = new Track
                    {
                        Id = reader.GetInt32(0),
                        TrackTitle = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4)
                    };
                    trackList.Add(track);
                }
                return trackList;
            }
        }

        public List<JObject> LoadTracksUsingJoin(int albumID)
        {
            List<JObject> trackList = new List<JObject>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionstring);
            mySqlConnection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand();

            mySqlCommand.CommandText = ("SELECT tracks.Id as TrackId, album.ALBUM_TITLE, track_title, `video_url`, `Lyrics` FROM `tracks` join album on tracks.album_ID = album.ID WHERE album_ID = @index;");
            mySqlCommand.Parameters.AddWithValue("@index", albumID);
            mySqlCommand.Connection = mySqlConnection;

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newTrack = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    trackList.Add(newTrack);
                }
                return trackList;
            }
        }





    }
}
