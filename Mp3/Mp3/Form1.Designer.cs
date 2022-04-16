
namespace Mp3
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
            this.button_Preview = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.trackList = new System.Windows.Forms.ListBox();
            this.picsArt = new System.Windows.Forms.PictureBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_volume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_track_start = new System.Windows.Forms.Label();
            this.label_track_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picsArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Preview
            // 
            this.button_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Preview.Location = new System.Drawing.Point(2, 445);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(119, 37);
            this.button_Preview.TabIndex = 0;
            this.button_Preview.Text = "Preview";
            this.button_Preview.UseVisualStyleBackColor = false;
            this.button_Preview.Click += new System.EventHandler(this.button_Preview_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Location = new System.Drawing.Point(127, 445);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(119, 37);
            this.button_Next.TabIndex = 1;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.Location = new System.Drawing.Point(252, 445);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(119, 37);
            this.button_Play.TabIndex = 2;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pause.Location = new System.Drawing.Point(377, 445);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(119, 37);
            this.button_Pause.TabIndex = 3;
            this.button_Pause.Text = "Pause";
            this.button_Pause.UseVisualStyleBackColor = false;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stop.Location = new System.Drawing.Point(502, 445);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(119, 37);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Open
            // 
            this.button_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Open.Location = new System.Drawing.Point(627, 445);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(127, 37);
            this.button_Open.TabIndex = 5;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = false;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(2, 409);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(752, 23);
            this.pBar.TabIndex = 6;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.Black;
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 16;
            this.trackList.Location = new System.Drawing.Point(230, 19);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(433, 256);
            this.trackList.TabIndex = 7;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // picsArt
            // 
            this.picsArt.Image = ((System.Drawing.Image)(resources.GetObject("picsArt.Image")));
            this.picsArt.Location = new System.Drawing.Point(3, 16);
            this.picsArt.Name = "picsArt";
            this.picsArt.Size = new System.Drawing.Size(221, 254);
            this.picsArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsArt.TabIndex = 9;
            this.picsArt.TabStop = false;
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.Black;
            this.trackVolume.Location = new System.Drawing.Point(672, 41);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(56, 224);
            this.trackVolume.TabIndex = 11;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(2, -13);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(928, 115);
            this.Player.TabIndex = 12;
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_volume.ForeColor = System.Drawing.Color.Black;
            this.label_volume.Location = new System.Drawing.Point(669, 14);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(44, 17);
            this.label_volume.TabIndex = 13;
            this.label_volume.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(669, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Volume";
            // 
            // label_track_start
            // 
            this.label_track_start.AutoSize = true;
            this.label_track_start.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_track_start.ForeColor = System.Drawing.Color.Lime;
            this.label_track_start.Location = new System.Drawing.Point(-5, 5);
            this.label_track_start.Name = "label_track_start";
            this.label_track_start.Size = new System.Drawing.Size(229, 97);
            this.label_track_start.TabIndex = 15;
            this.label_track_start.Text = "00:00";
            // 
            // label_track_end
            // 
            this.label_track_end.AutoSize = true;
            this.label_track_end.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_track_end.ForeColor = System.Drawing.Color.Lime;
            this.label_track_end.Location = new System.Drawing.Point(525, 5);
            this.label_track_end.Name = "label_track_end";
            this.label_track_end.Size = new System.Drawing.Size(229, 97);
            this.label_track_end.TabIndex = 16;
            this.label_track_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.trackVolume);
            this.panel1.Controls.Add(this.label_volume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picsArt);
            this.panel1.Controls.Add(this.trackList);
            this.panel1.Location = new System.Drawing.Point(2, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 292);
            this.panel1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(757, 504);
            this.Controls.Add(this.label_track_end);
            this.Controls.Add(this.label_track_start);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Pause);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Preview);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picsArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Preview;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.PictureBox picsArt;
        private System.Windows.Forms.TrackBar trackVolume;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_track_start;
        private System.Windows.Forms.Label label_track_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

