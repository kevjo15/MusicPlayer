using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml.Serialization;
using WMPLib;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Collections.Immutable;
using System.Web;
using System.Xml.Linq;
using MySqlConnector;
using TagLib.Id3v1;
using System.Diagnostics.Eventing.Reader;
using TagLib.Mpeg;
using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        String[] paths, files;
        OpenFileDialog ofd = new OpenFileDialog();
        bool playing = false;
        string connectionString;


        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradientRectangle = new Rectangle(0, 0, 844, 509);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradientRectangle, Color.FromArgb(255, 255, 255), Color.FromArgb(51, 8, 95), -100f);
            //apply gradient         
            graphics.FillRectangle(b, gradientRectangle);
        }
        public Form1()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "music2";
            string user = "root";
            string password = "K12n081212";
            connectionString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            this.Paint += new PaintEventHandler(set_background);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true; //lets select multible songs

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array            
                paths = ofd.FileNames; //Save the patchs of the tracks in path array

                //display the music titels in list box
                for (int i = 0; i < files.Length; i++)
                {

                    listBoxAddSong2.Items.Add(files[i]); //display songs in list box

                    //lblSongName.Text = files[i]; // displays file name int lblSongName

                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //plays and pauses the music
            playing = !playing;
            if (!playing) { axWindowsMediaMusic.Ctlcontrols.play(); return; }
            axWindowsMediaMusic.Ctlcontrols.pause();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit button
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnNextTrack_Click(object sender, EventArgs e)
        {
            //Next song
            if ((listBoxAddSong2.SelectedIndex + 1) > listBoxAddSong2.Items.Count - 1) { return; }
            listBoxAddSong2.SelectedIndex++;
            axWindowsMediaMusic.Ctlcontrols.play();
        }

        private void btnPreviousTrack_Click(object sender, EventArgs e)
        {
            //previous song
            if ((listBoxAddSong2.SelectedIndex - 1) < 0) { return; }
            listBoxAddSong2.SelectedIndex--;
            axWindowsMediaMusic.Ctlcontrols.play();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            //axWindowsMediaMusic.Ctlcontrols.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if the Windows Media Player control named "axWindowsMediaMusic" is currently playing.
            if (axWindowsMediaMusic.playState == WMPPlayState.wmppsPlaying)
            {
                // Set the value of the progress bar control named "progressBar" to the current position of the 
                // Windows Media Player control. The current position is cast to an integer as the progress bar 
                // control expects an integer value.
                progressBar.Value = (int)axWindowsMediaMusic.Ctlcontrols.currentPosition;
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            PostData();
        }
        //Get data from database method
        public (MySql.Data.MySqlClient.MySqlDataReader, MySql.Data.MySqlClient.MySqlConnection) GetData(string table)
        {

            // Create a new MySql connection object and initialize it with the connection string
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            try
            {
                // Open the connection to the database
                conn.Open();

                // Create a SELECT statement to retrieve data from the specified table
                string sql = "SELECT * FROM " + table + "";

                // Create a new MySql command object with the SELECT statement and the connection object
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // Execute the SELECT statement and retrieve the result set
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();

                // Return the result set and the connection object
                return (rdr, conn);
            }
            catch (Exception ex)
            {
                // If an exception occurs, write the error message to the console and return null for the result set
                Console.WriteLine(ex.ToString());
                return (null, conn);
            }

        }
        //Post data to database method
        public void PostData()
        {
            // Create a new MySQL connection using the connection string
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            try
            {
                // Open the connection
                conn.Open();

                // Read the selected file's tags using TagLib library
                TagLib.File tagFile = TagLib.File.Create(paths[listBoxAddSong2.SelectedIndex]);
                string artist = tagFile.Tag.FirstAlbumArtist;
                string album = tagFile.Tag.Album;
                string song = tagFile.Tag.Title;

                // Check if the file has all required tags
                if (string.IsNullOrEmpty(artist) || string.IsNullOrEmpty(album) || string.IsNullOrEmpty(song))
                {
                    // Show error message if file is missing required tags
                    MessageBox.Show("You must import a mp3 file with all tags!");
                    return;
                }

                // Create the SQL command string
                string sql = $"CALL addDataToDB('{song}','{artist}','{album}')";

                // Create a new MySQL command using the SQL command string and the MySQL connection
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // Execute the command
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show(ex.Message);
            }

            // Close the MySQL connection
            conn.Close();
        }

        private void btnAlbumList_Click(object sender, EventArgs e)
        {
            listBoxAlbum.Items.Clear();
            listBoxAlbum.Visible = true;
            btnBack2.Visible = true;

            string albumName = "";
            string artistName = "";

            var albumRdr = GetData("album");
            var artistRdr = GetData("artist");

            //While loop för att spara datan lokalt i en lista
            while (albumRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(albumRdr.Item1["Album_id"]);
                albumName = albumRdr.Item1["Album_name"].ToString();


                //Skapa ett Person obejkt och spara i statisk lista
                Albums.albums.Add(new Albums(Id, albumName));

                listBoxAlbum.Items.Add($"Album ● {albumName}");

            }
            albumRdr.Item1.Close();
            albumRdr.Item2.Close();

            //While loop för att spara datan lokalt i en lista
            while (artistRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(artistRdr.Item1["Artist_id"]);
                artistName = artistRdr.Item1["Artist_name"].ToString();

                //Skapa ett Person obejkt och spara i statisk lista
                Artists.artist.Add(new Artists(Id, artistName));

            }
            artistRdr.Item1.Close();
            artistRdr.Item2.Close();

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            listBoxAlbum.Visible = false;
            listBoxSongs.Visible = false;
            listBoxArtist.Visible = false;
            btnBack2.Visible = false;
            ListBoxSearch.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            txtBoxUpdate.Visible = false;
        }

        private void btnSongList_Click(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
            listBoxSongs.Visible = true;
            btnBack2.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            txtBoxUpdate.Visible = true;

            string songName = "";
            string artistName = "";
            int artistId = 0;

            var songRdr = GetData("song");
            var artistRdr = GetData("artist");

            //While loop för att spara datan lokalt i en lista
            while (songRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(songRdr.Item1["Song_id"]);
                songName = songRdr.Item1["Song_name"].ToString();
                //artistId = Convert.ToInt32(songRdr.Item1["Artist_id"]);

                //Skapa ett Person obejkt och spara i statisk lista
                Songs.songs.Add(new Songs(Id, songName, artistId));

                listBoxSongs.Items.Add("Title ● " + songName);

            }
            songRdr.Item1.Close();
            songRdr.Item2.Close();

            //While loop för att spara datan lokalt i en lista
            while (artistRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(artistRdr.Item1["Artist_id"]);
                artistName = artistRdr.Item1["Artist_name"].ToString();

                //Skapa ett Person obejkt och spara i statisk lista
                Artists.artist.Add(new Artists(Id, artistName));

            }
            artistRdr.Item1.Close();
            artistRdr.Item2.Close();

        }

        private void btnArtistList_Click(object sender, EventArgs e)
        {
            listBoxArtist.Items.Clear();
            listBoxArtist.Visible = true;
            btnBack2.Visible = true;

            string albumName = "";
            string artistName = "";

            var albumRdr = GetData("album");
            var artistRdr = GetData("artist");

            //While loop för att spara datan lokalt i en lista
            while (albumRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(albumRdr.Item1["Album_id"]);
                albumName = albumRdr.Item1["Album_name"].ToString();


                //Skapa ett Person obejkt och spara i statisk lista
                Albums.albums.Add(new Albums(Id, albumName));
            }
            albumRdr.Item1.Close();
            albumRdr.Item2.Close();

            //While loop för att spara datan lokalt i en lista
            while (artistRdr.Item1.Read())
            {
                //Hämta och spara data till variabler
                int Id = Convert.ToInt32(artistRdr.Item1["Artist_id"]);
                artistName = artistRdr.Item1["Artist_name"].ToString();

                //Skapa ett Person obejkt och spara i statisk lista
                Artists.artist.Add(new Artists(Id, artistName));
                listBoxArtist.Items.Add("Artist ● " + artistName);
            }
            artistRdr.Item1.Close();
            artistRdr.Item2.Close();


        }

        private void listBoxAddSong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the patch file to a mp3 file
            axWindowsMediaMusic.URL = paths[listBoxAddSong2.SelectedIndex];
            //writes out name of the current playing song

            //hämtar taggarna på vald .mp3 fil och fördelar dem i olika stringar
            TagLib.File tagFile = TagLib.File.Create(paths[listBoxAddSong2.SelectedIndex]);
            string artist = tagFile.Tag.FirstAlbumArtist;
            string album = tagFile.Tag.Album;
            string title = tagFile.Tag.Title;

            //lägger in artis, album coh title värderna i respektive label
            lblArtist.Text = artist;
            lblAlbum.Text = album;
            lblSongName.Text = title;
        }

        private void SearchAll(string keyword = "")
        {
            ListBoxSearch.Items.Clear();
            ListBoxSearch.Visible = true;
            btnBack2.Visible = true;

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            //Skapa en SQL Querry
            string sql;

            if (keyword == "") sql = $"CALL searchAll();";
            else sql = $"CALL searchAll('{keyword}');";

            //Skapa ett MySQLCommand objekt
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            //Exekvera querry mot DB. Få data tillbaka
            try
            {
                //Öppnar koppling till DB
                conn.Open();

                //Exekvera cmd
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                ListBoxSearch.Items.Clear();

                //While loop för att spara datan lokalt i en lista
                while (reader.Read())
                {
                    //skriver ut din sökning i listBoxSearch
                    ListBoxSearch.Items.Add(reader[0].ToString());
                }

                reader.Close();
                //Stänga koppling till DB
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAll(txtBoxSearchBar.Text);
            //Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected index from the listbox.
            int songSelectedIndex = listBoxSongs.SelectedIndex;

            // Check if a song has been selected.
            if (songSelectedIndex != -1)
            {
                // Get the selected item from the listbox.
                string selectedItem = listBoxSongs.Items[songSelectedIndex].ToString();

                // Extract the song name from the selected item in the listbox.
                string songName = selectedItem.Remove(0, 8);

                // Create the DELETE query using the extracted song name.
                string deleteQuery = $"CALL deleteSong('{songName}');";

                // Connect to the database using the connection string.
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                conn.Open();

                try
                {
                    // Execute the DELETE query.
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(deleteQuery, conn);
                    cmd.ExecuteNonQuery();

                    // Remove the item from the listbox.
                    listBoxSongs.Items.RemoveAt(songSelectedIndex);
                }
                catch (Exception ex)
                {
                    // Show the error message if an exception occurs.
                    MessageBox.Show(ex.Message);
                }

                // Close the database connection.
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int songSelectedIndex = listBoxSongs.SelectedIndex;

            // Check if a song is selected
            if (songSelectedIndex != -1)
            {
                // Get the selected item from the listbox
                string selectedItem = listBoxSongs.Items[songSelectedIndex].ToString();

                // Extract the old song name from the selected item
                string oldSongName = selectedItem.Remove(0, 8);

                // Get the new song name from the textbox
                string newSongName = txtBoxUpdate.Text;

                // Create the update query
                string updateQuery = $"CALL updateSong('{newSongName}', '{oldSongName}');";

                // Open the database connection
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                conn.Open();

                try
                {
                    // Execute the update query
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(updateQuery, conn);
                    cmd.ExecuteNonQuery();

                    // Update the item in the listbox
                    listBoxSongs.Items[songSelectedIndex] = "Title ● " + newSongName;
                }
                catch (Exception ex)
                {
                    // Show the error message
                    MessageBox.Show(ex.Message);
                }

                // Close the database connection
                conn.Close();
            }
        }

        private void axWindowsMediaMusic_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Check the play state of the Windows Media Player
            if (axWindowsMediaMusic.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Set the maximum value of the progress bar to the duration of the current song
                progressBar.Maximum = (int)axWindowsMediaMusic.Ctlcontrols.currentItem.duration;

                // Start the timer
                timer1.Start();

                // Get the duration of the current song
                string songlength = axWindowsMediaMusic.Ctlcontrols.currentItem.durationString;

                // Display the duration of the current song
                lblSongTimeLegnth.Text = songlength;
            }
            else if (axWindowsMediaMusic.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                // Stop the timer
                timer1.Stop();
            }
            else if (axWindowsMediaMusic.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Stop the timer
                timer1.Stop();

                // Reset the progress bar value to 0
                progressBar.Value = 0;
            }
        }


    }
}
