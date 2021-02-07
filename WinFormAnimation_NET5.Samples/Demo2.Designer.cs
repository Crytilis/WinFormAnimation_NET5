namespace WinFormAnimation_NET5.Samples
{
    partial class Demo2
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo2));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.cb_repeat = new System.Windows.Forms.CheckBox();
            this.cb_reverse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(39, 3);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(31, 28);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = ">";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.PlayButton);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stop.Location = new System.Drawing.Point(4, 3);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(31, 28);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "□";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.StopButton);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(4, 38);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(31, 28);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "| |";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.PauseButton);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(39, 38);
            this.btn_resume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(31, 28);
            this.btn_resume.TabIndex = 3;
            this.btn_resume.Text = ">";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.ResumeButton);
            // 
            // pb_image
            // 
            this.pb_image.Image = ((System.Drawing.Image)(resources.GetObject("pb_image.Image")));
            this.pb_image.Location = new System.Drawing.Point(81, 3);
            this.pb_image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(32, 32);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_image.TabIndex = 5;
            this.pb_image.TabStop = false;
            // 
            // cb_repeat
            // 
            this.cb_repeat.AutoSize = true;
            this.cb_repeat.Location = new System.Drawing.Point(4, 73);
            this.cb_repeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_repeat.Name = "cb_repeat";
            this.cb_repeat.Size = new System.Drawing.Size(62, 19);
            this.cb_repeat.TabIndex = 6;
            this.cb_repeat.Text = "Repeat";
            this.cb_repeat.UseVisualStyleBackColor = true;
            this.cb_repeat.CheckedChanged += new System.EventHandler(this.RepeatChecked);
            // 
            // cb_reverse
            // 
            this.cb_reverse.AutoSize = true;
            this.cb_reverse.Enabled = false;
            this.cb_reverse.Location = new System.Drawing.Point(4, 99);
            this.cb_reverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_reverse.Name = "cb_reverse";
            this.cb_reverse.Size = new System.Drawing.Size(66, 19);
            this.cb_reverse.TabIndex = 7;
            this.cb_reverse.Text = "Reverse";
            this.cb_reverse.UseVisualStyleBackColor = true;
            this.cb_reverse.CheckedChanged += new System.EventHandler(this.ReverseChecked);
            // 
            // Demo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_reverse);
            this.Controls.Add(this.cb_repeat);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_resume);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Demo2";
            this.Size = new System.Drawing.Size(422, 183);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.CheckBox cb_repeat;
        private System.Windows.Forms.CheckBox cb_reverse;
    }
}
