using System.Windows.Forms;

namespace MusicApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNextTrack = new System.Windows.Forms.Button();
            this.pbAlbumPicture = new System.Windows.Forms.PictureBox();
            this.btnPreviousTrack = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSbotify = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicBoxsidebar = new System.Windows.Forms.Panel();
            this.txtBoxUpdate = new MusicApp.TransparentTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ListBoxSearch = new MusicApp.TransparentListBox();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.listBoxAlbum = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnArtistList = new System.Windows.Forms.Button();
            this.btnAlbumList = new System.Windows.Forms.Button();
            this.btnSongList = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxSearchBar = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSongTimeLegnth = new System.Windows.Forms.Label();
            this.lblTimeGone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddSong = new System.Windows.Forms.Button();
            this.axWindowsMediaMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxAddSong2 = new MusicApp.TransparentListBox();
            this.transListbox = new MusicApp.TransparentListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PicBoxsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextTrack
            // 
            this.btnNextTrack.BackColor = System.Drawing.Color.Transparent;
            this.btnNextTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextTrack.FlatAppearance.BorderSize = 0;
            this.btnNextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTrack.Image = ((System.Drawing.Image)(resources.GetObject("btnNextTrack.Image")));
            this.btnNextTrack.Location = new System.Drawing.Point(422, 412);
            this.btnNextTrack.Name = "btnNextTrack";
            this.btnNextTrack.Size = new System.Drawing.Size(35, 35);
            this.btnNextTrack.TabIndex = 3;
            this.btnNextTrack.UseVisualStyleBackColor = false;
            this.btnNextTrack.Click += new System.EventHandler(this.btnNextTrack_Click);
            // 
            // pbAlbumPicture
            // 
            this.pbAlbumPicture.BackColor = System.Drawing.Color.Transparent;
            this.pbAlbumPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbAlbumPicture.Image")));
            this.pbAlbumPicture.Location = new System.Drawing.Point(246, 90);
            this.pbAlbumPicture.Name = "pbAlbumPicture";
            this.pbAlbumPicture.Size = new System.Drawing.Size(260, 245);
            this.pbAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbumPicture.TabIndex = 2;
            this.pbAlbumPicture.TabStop = false;
            // 
            // btnPreviousTrack
            // 
            this.btnPreviousTrack.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousTrack.FlatAppearance.BorderSize = 0;
            this.btnPreviousTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousTrack.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousTrack.Image")));
            this.btnPreviousTrack.Location = new System.Drawing.Point(301, 412);
            this.btnPreviousTrack.Name = "btnPreviousTrack";
            this.btnPreviousTrack.Size = new System.Drawing.Size(35, 35);
            this.btnPreviousTrack.TabIndex = 4;
            this.btnPreviousTrack.UseVisualStyleBackColor = false;
            this.btnPreviousTrack.Click += new System.EventHandler(this.btnPreviousTrack_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(358, 412);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(293, 348);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(164, 25);
            this.lblSongName.TabIndex = 6;
            this.lblSongName.Text = "SongNameHere";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(308, 373);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(129, 16);
            this.lblArtist.TabIndex = 7;
            this.lblArtist.Text = "Artists, Names, Here";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(246, 412);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(35, 35);
            this.btnFile.TabIndex = 9;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(340, 58);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(81, 16);
            this.lblAlbum.TabIndex = 10;
            this.lblAlbum.Text = "Album namn";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(797, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSbotify
            // 
            this.lblSbotify.AutoSize = true;
            this.lblSbotify.BackColor = System.Drawing.Color.Transparent;
            this.lblSbotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSbotify.Location = new System.Drawing.Point(343, 18);
            this.lblSbotify.Name = "lblSbotify";
            this.lblSbotify.Size = new System.Drawing.Size(78, 25);
            this.lblSbotify.TabIndex = 1;
            this.lblSbotify.Text = "Sbotify";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PicBoxsidebar
            // 
            this.PicBoxsidebar.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxsidebar.Controls.Add(this.txtBoxUpdate);
            this.PicBoxsidebar.Controls.Add(this.btnUpdate);
            this.PicBoxsidebar.Controls.Add(this.btnDelete);
            this.PicBoxsidebar.Controls.Add(this.ListBoxSearch);
            this.PicBoxsidebar.Controls.Add(this.listBoxArtist);
            this.PicBoxsidebar.Controls.Add(this.listBoxSongs);
            this.PicBoxsidebar.Controls.Add(this.btnBack2);
            this.PicBoxsidebar.Controls.Add(this.listBoxAlbum);
            this.PicBoxsidebar.Controls.Add(this.panel1);
            this.PicBoxsidebar.Controls.Add(this.btnSearch);
            this.PicBoxsidebar.Controls.Add(this.btnArtistList);
            this.PicBoxsidebar.Controls.Add(this.btnAlbumList);
            this.PicBoxsidebar.Controls.Add(this.btnSongList);
            this.PicBoxsidebar.Controls.Add(this.pictureBox2);
            this.PicBoxsidebar.Controls.Add(this.txtBoxSearchBar);
            this.PicBoxsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicBoxsidebar.Location = new System.Drawing.Point(0, 0);
            this.PicBoxsidebar.Name = "PicBoxsidebar";
            this.PicBoxsidebar.Size = new System.Drawing.Size(190, 509);
            this.PicBoxsidebar.TabIndex = 12;
            // 
            // txtBoxUpdate
            // 
            this.txtBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUpdate.Location = new System.Drawing.Point(12, 438);
            this.txtBoxUpdate.Name = "txtBoxUpdate";
            this.txtBoxUpdate.Size = new System.Drawing.Size(158, 20);
            this.txtBoxUpdate.TabIndex = 22;
            this.txtBoxUpdate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update Song";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Song";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ListBoxSearch
            // 
            this.ListBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListBoxSearch.FormattingEnabled = true;
            this.ListBoxSearch.Location = new System.Drawing.Point(12, 90);
            this.ListBoxSearch.Name = "ListBoxSearch";
            this.ListBoxSearch.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ListBoxSearch.Size = new System.Drawing.Size(158, 338);
            this.ListBoxSearch.TabIndex = 22;
            this.ListBoxSearch.Visible = false;
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.Location = new System.Drawing.Point(12, 90);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(158, 342);
            this.listBoxArtist.TabIndex = 23;
            this.listBoxArtist.Visible = false;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(12, 90);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(158, 342);
            this.listBoxSongs.TabIndex = 17;
            this.listBoxSongs.Visible = false;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Transparent;
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Image = ((System.Drawing.Image)(resources.GetObject("btnBack2.Image")));
            this.btnBack2.Location = new System.Drawing.Point(3, 49);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(35, 35);
            this.btnBack2.TabIndex = 16;
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Visible = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // listBoxAlbum
            // 
            this.listBoxAlbum.FormattingEnabled = true;
            this.listBoxAlbum.Location = new System.Drawing.Point(12, 90);
            this.listBoxAlbum.Name = "listBoxAlbum";
            this.listBoxAlbum.Size = new System.Drawing.Size(158, 342);
            this.listBoxAlbum.TabIndex = 15;
            this.listBoxAlbum.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 508);
            this.panel1.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImage")));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(154, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(16, 16);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnArtistList
            // 
            this.btnArtistList.BackColor = System.Drawing.Color.Transparent;
            this.btnArtistList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArtistList.FlatAppearance.BorderSize = 0;
            this.btnArtistList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtistList.Image = ((System.Drawing.Image)(resources.GetObject("btnArtistList.Image")));
            this.btnArtistList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtistList.Location = new System.Drawing.Point(45, 256);
            this.btnArtistList.Name = "btnArtistList";
            this.btnArtistList.Size = new System.Drawing.Size(103, 35);
            this.btnArtistList.TabIndex = 9;
            this.btnArtistList.Text = "Artist";
            this.btnArtistList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArtistList.UseVisualStyleBackColor = false;
            this.btnArtistList.Click += new System.EventHandler(this.btnArtistList_Click);
            // 
            // btnAlbumList
            // 
            this.btnAlbumList.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbumList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlbumList.FlatAppearance.BorderSize = 0;
            this.btnAlbumList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbumList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbumList.Image = ((System.Drawing.Image)(resources.GetObject("btnAlbumList.Image")));
            this.btnAlbumList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbumList.Location = new System.Drawing.Point(45, 197);
            this.btnAlbumList.Name = "btnAlbumList";
            this.btnAlbumList.Size = new System.Drawing.Size(103, 35);
            this.btnAlbumList.TabIndex = 8;
            this.btnAlbumList.Text = "Album";
            this.btnAlbumList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlbumList.UseVisualStyleBackColor = false;
            this.btnAlbumList.Click += new System.EventHandler(this.btnAlbumList_Click);
            // 
            // btnSongList
            // 
            this.btnSongList.BackColor = System.Drawing.Color.Transparent;
            this.btnSongList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSongList.FlatAppearance.BorderSize = 0;
            this.btnSongList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongList.Image = ((System.Drawing.Image)(resources.GetObject("btnSongList.Image")));
            this.btnSongList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongList.Location = new System.Drawing.Point(45, 135);
            this.btnSongList.Name = "btnSongList";
            this.btnSongList.Size = new System.Drawing.Size(103, 35);
            this.btnSongList.TabIndex = 7;
            this.btnSongList.Text = "Song";
            this.btnSongList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSongList.UseVisualStyleBackColor = false;
            this.btnSongList.Click += new System.EventHandler(this.btnSongList_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxSearchBar
            // 
            this.txtBoxSearchBar.BackColor = System.Drawing.Color.MediumPurple;
            this.txtBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxSearchBar.HideSelection = false;
            this.txtBoxSearchBar.Location = new System.Drawing.Point(40, 30);
            this.txtBoxSearchBar.Name = "txtBoxSearchBar";
            this.txtBoxSearchBar.Size = new System.Drawing.Size(110, 19);
            this.txtBoxSearchBar.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(269, 392);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(203, 10);
            this.progressBar.TabIndex = 13;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // lblSongTimeLegnth
            // 
            this.lblSongTimeLegnth.AutoSize = true;
            this.lblSongTimeLegnth.BackColor = System.Drawing.Color.Transparent;
            this.lblSongTimeLegnth.Location = new System.Drawing.Point(479, 388);
            this.lblSongTimeLegnth.Name = "lblSongTimeLegnth";
            this.lblSongTimeLegnth.Size = new System.Drawing.Size(34, 13);
            this.lblSongTimeLegnth.TabIndex = 14;
            this.lblSongTimeLegnth.Text = "05:00";
            // 
            // lblTimeGone
            // 
            this.lblTimeGone.AutoSize = true;
            this.lblTimeGone.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeGone.Location = new System.Drawing.Point(229, 388);
            this.lblTimeGone.Name = "lblTimeGone";
            this.lblTimeGone.Size = new System.Drawing.Size(34, 13);
            this.lblTimeGone.TabIndex = 15;
            this.lblTimeGone.Text = "00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(563, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 508);
            this.panel2.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(669, 453);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 20;
            this.btnAddSong.Text = "Add song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // axWindowsMediaMusic
            // 
            this.axWindowsMediaMusic.Enabled = true;
            this.axWindowsMediaMusic.Location = new System.Drawing.Point(256, 453);
            this.axWindowsMediaMusic.Name = "axWindowsMediaMusic";
            this.axWindowsMediaMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaMusic.OcxState")));
            this.axWindowsMediaMusic.Size = new System.Drawing.Size(226, 48);
            this.axWindowsMediaMusic.TabIndex = 18;
            this.axWindowsMediaMusic.Visible = false;
            this.axWindowsMediaMusic.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaMusic_PlayStateChange);
            // 
            // listBoxAddSong2
            // 
            this.listBoxAddSong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAddSong2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxAddSong2.FormattingEnabled = true;
            this.listBoxAddSong2.Location = new System.Drawing.Point(610, 64);
            this.listBoxAddSong2.Name = "listBoxAddSong2";
            this.listBoxAddSong2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.listBoxAddSong2.Size = new System.Drawing.Size(194, 351);
            this.listBoxAddSong2.TabIndex = 21;
            this.listBoxAddSong2.SelectedIndexChanged += new System.EventHandler(this.listBoxAddSong2_SelectedIndexChanged);
            // 
            // transListbox
            // 
            this.transListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.transListbox.Location = new System.Drawing.Point(0, 0);
            this.transListbox.Name = "transListbox";
            this.transListbox.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.transListbox.Size = new System.Drawing.Size(120, 95);
            this.transListbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 509);
            this.Controls.Add(this.listBoxAddSong2);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.axWindowsMediaMusic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTimeGone);
            this.Controls.Add(this.lblSongTimeLegnth);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.PicBoxsidebar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSbotify);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPreviousTrack);
            this.Controls.Add(this.btnNextTrack);
            this.Controls.Add(this.pbAlbumPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PicBoxsidebar.ResumeLayout(false);
            this.PicBoxsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbAlbumPicture;
        private System.Windows.Forms.Button btnNextTrack;
        private System.Windows.Forms.Button btnPreviousTrack;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSbotify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PicBoxsidebar;
        private System.Windows.Forms.Button btnArtistList;
        private System.Windows.Forms.Button btnAlbumList;
        private System.Windows.Forms.Button btnSongList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBoxSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSongTimeLegnth;
        private System.Windows.Forms.Label lblTimeGone;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaMusic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ListBox listBoxAlbum;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.ListBox listBoxSongs;
        private TransparentListBox transListbox;//<-------------------------------------------------------------------------
        private TransparentListBox listBoxAddSong2;
        private TransparentListBox ListBoxSearch;
        private ListBox listBoxArtist;
        private Button btnDelete;
        private Button btnUpdate;
        private TransparentTextBox txtBoxUpdate;
    }
}

