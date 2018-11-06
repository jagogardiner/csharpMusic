namespace musicPlayer
{
    partial class mainForm
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
            this._miniply = new System.Windows.Forms.Button();
            this._play = new System.Windows.Forms.Button();
            this._pause = new System.Windows.Forms.Button();
            this._stop = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._selfile = new System.Windows.Forms.OpenFileDialog();
            this._choose = new System.Windows.Forms.Button();
            this._currenttrack = new System.Windows.Forms.Label();
            this._albumart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._albumart)).BeginInit();
            this.SuspendLayout();
            // 
            // _miniply
            // 
            this._miniply.Location = new System.Drawing.Point(12, 236);
            this._miniply.Name = "_miniply";
            this._miniply.Size = new System.Drawing.Size(127, 50);
            this._miniply.TabIndex = 0;
            this._miniply.Text = "Mini Player";
            this._miniply.UseVisualStyleBackColor = true;
            // 
            // _play
            // 
            this._play.Location = new System.Drawing.Point(12, 12);
            this._play.Name = "_play";
            this._play.Size = new System.Drawing.Size(127, 50);
            this._play.TabIndex = 1;
            this._play.Text = "Play";
            this._play.UseVisualStyleBackColor = true;
            this._play.Click += new System.EventHandler(this._play_Click);
            // 
            // _pause
            // 
            this._pause.Location = new System.Drawing.Point(12, 68);
            this._pause.Name = "_pause";
            this._pause.Size = new System.Drawing.Size(127, 50);
            this._pause.TabIndex = 2;
            this._pause.Text = "Pause";
            this._pause.UseVisualStyleBackColor = true;
            this._pause.Click += new System.EventHandler(this._pause_Click);
            // 
            // _stop
            // 
            this._stop.Location = new System.Drawing.Point(12, 124);
            this._stop.Name = "_stop";
            this._stop.Size = new System.Drawing.Size(127, 50);
            this._stop.TabIndex = 3;
            this._stop.Text = "Stop";
            this._stop.UseVisualStyleBackColor = true;
            this._stop.Click += new System.EventHandler(this._stop_Click);
            // 
            // _next
            // 
            this._next.Location = new System.Drawing.Point(12, 180);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(127, 50);
            this._next.TabIndex = 4;
            this._next.Text = "Next";
            this._next.UseVisualStyleBackColor = true;
            // 
            // _selfile
            // 
            this._selfile.Filter = "\"Music (.mp3)|*.mp3|ALL Files (*.*)|*.*\"";
            this._selfile.Title = "Pick song...";
            this._selfile.FileOk += new System.ComponentModel.CancelEventHandler(this._selfile_FileOk);
            // 
            // _choose
            // 
            this._choose.Location = new System.Drawing.Point(245, 263);
            this._choose.Name = "_choose";
            this._choose.Size = new System.Drawing.Size(100, 23);
            this._choose.TabIndex = 5;
            this._choose.Text = "Choose song...";
            this._choose.UseVisualStyleBackColor = true;
            this._choose.Click += new System.EventHandler(this._choose_Click);
            // 
            // _currenttrack
            // 
            this._currenttrack.AutoSize = true;
            this._currenttrack.Location = new System.Drawing.Point(145, 219);
            this._currenttrack.Name = "_currenttrack";
            this._currenttrack.Size = new System.Drawing.Size(131, 13);
            this._currenttrack.TabIndex = 7;
            this._currenttrack.Text = "Currently playing: (nothing)";
            // 
            // _albumart
            // 
            this._albumart.Image = global::musicPlayer.Properties.Resources._5206_200;
            this._albumart.Location = new System.Drawing.Point(145, 12);
            this._albumart.Name = "_albumart";
            this._albumart.Size = new System.Drawing.Size(200, 200);
            this._albumart.TabIndex = 6;
            this._albumart.TabStop = false;
            this._albumart.Click += new System.EventHandler(this._albumart_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 298);
            this.Controls.Add(this._currenttrack);
            this.Controls.Add(this._albumart);
            this.Controls.Add(this._choose);
            this.Controls.Add(this._next);
            this.Controls.Add(this._stop);
            this.Controls.Add(this._pause);
            this.Controls.Add(this._play);
            this.Controls.Add(this._miniply);
            this.Name = "mainForm";
            this.Text = "Music Player v0.0.1 Alpha";
            ((System.ComponentModel.ISupportInitialize)(this._albumart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _miniply;
        private System.Windows.Forms.Button _play;
        private System.Windows.Forms.Button _pause;
        private System.Windows.Forms.Button _stop;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.OpenFileDialog _selfile;
        private System.Windows.Forms.Button _choose;
        private System.Windows.Forms.PictureBox _albumart;
        private System.Windows.Forms.Label _currenttrack;
    }
}

