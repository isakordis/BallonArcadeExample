namespace BalloonArcade
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
            this.txtScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yesil = new System.Windows.Forms.PictureBox();
            this.sari = new System.Windows.Forms.PictureBox();
            this.cocuk = new System.Windows.Forms.PictureBox();
            this.yukari = new System.Windows.Forms.PictureBox();
            this.asagi = new System.Windows.Forms.PictureBox();
            this.kirmizi = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asagi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(564, 38);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(47, 13);
            this.txtScore.TabIndex = 6;
            this.txtScore.Tag = "score";
            this.txtScore.Text = "Score=0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.MakeEventTime);
            // 
            // yesil
            // 
            this.yesil.Image = global::BalloonArcade.Properties.Resources.yesil_58x58;
            this.yesil.Location = new System.Drawing.Point(320, 200);
            this.yesil.Name = "yesil";
            this.yesil.Size = new System.Drawing.Size(54, 53);
            this.yesil.TabIndex = 7;
            this.yesil.TabStop = false;
            this.yesil.Tag = "yesil_balloon";
            this.yesil.Click += new System.EventHandler(this.PopBalloon);
            // 
            // sari
            // 
            this.sari.Image = global::BalloonArcade.Properties.Resources.sarı_58x58;
            this.sari.Location = new System.Drawing.Point(320, 141);
            this.sari.Name = "sari";
            this.sari.Size = new System.Drawing.Size(54, 53);
            this.sari.TabIndex = 8;
            this.sari.TabStop = false;
            this.sari.Tag = "balloon";
            this.sari.Click += new System.EventHandler(this.PopBalloon);
            // 
            // cocuk
            // 
            this.cocuk.Image = global::BalloonArcade.Properties.Resources.cocuk_58x58;
            this.cocuk.Location = new System.Drawing.Point(50, 71);
            this.cocuk.Name = "cocuk";
            this.cocuk.Size = new System.Drawing.Size(58, 52);
            this.cocuk.TabIndex = 9;
            this.cocuk.TabStop = false;
            // 
            // yukari
            // 
            this.yukari.Image = global::BalloonArcade.Properties.Resources.ok_58x58;
            this.yukari.Location = new System.Drawing.Point(50, 0);
            this.yukari.Name = "yukari";
            this.yukari.Size = new System.Drawing.Size(58, 53);
            this.yukari.TabIndex = 10;
            this.yukari.TabStop = false;
            // 
            // asagi
            // 
            this.asagi.Image = global::BalloonArcade.Properties.Resources.asagi1;
            this.asagi.Location = new System.Drawing.Point(50, 138);
            this.asagi.Name = "asagi";
            this.asagi.Size = new System.Drawing.Size(58, 60);
            this.asagi.TabIndex = 11;
            this.asagi.TabStop = false;
            // 
            // kirmizi
            // 
            this.kirmizi.Image = global::BalloonArcade.Properties.Resources.kırmızı_58x58;
            this.kirmizi.Location = new System.Drawing.Point(320, 82);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(54, 53);
            this.kirmizi.TabIndex = 12;
            this.kirmizi.TabStop = false;
            this.kirmizi.Tag = "balloon";
            this.kirmizi.Click += new System.EventHandler(this.PopBalloon);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yukari);
            this.panel1.Controls.Add(this.cocuk);
            this.panel1.Controls.Add(this.asagi);
            this.panel1.Location = new System.Drawing.Point(32, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 201);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.kirmizi);
            this.Controls.Add(this.yesil);
            this.Controls.Add(this.sari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asagi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox yesil;
        private System.Windows.Forms.PictureBox sari;
        private System.Windows.Forms.PictureBox cocuk;
        private System.Windows.Forms.PictureBox yukari;
        private System.Windows.Forms.PictureBox asagi;
        private System.Windows.Forms.PictureBox kirmizi;
        private System.Windows.Forms.Panel panel1;
    }
}

