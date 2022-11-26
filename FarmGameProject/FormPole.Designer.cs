
namespace FarmGame
{
    partial class FormPole
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
            this.labelPoleCarots = new System.Windows.Forms.Label();
            this.timerCarots = new System.Windows.Forms.Timer(this.components);
            this.timerPotatoes = new System.Windows.Forms.Timer(this.components);
            this.buttonPoleColectCarots = new System.Windows.Forms.Button();
            this.buttonPoleCollectPotatoes = new System.Windows.Forms.Button();
            this.progressBarCarots = new System.Windows.Forms.ProgressBar();
            this.progressBarPotatoes = new System.Windows.Forms.ProgressBar();
            this.buttonPoleCollectStrawberiess = new System.Windows.Forms.Button();
            this.labelPoleStrawberies = new System.Windows.Forms.Label();
            this.progressBarStrawberies = new System.Windows.Forms.ProgressBar();
            this.timerStrawberies = new System.Windows.Forms.Timer(this.components);
            this.pictureboxPoleCarots = new System.Windows.Forms.PictureBox();
            this.pictureBoxPolePotatoes = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoleStrawberies = new System.Windows.Forms.PictureBox();
            this.labelPolePotatoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPoleCarots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolePotatoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoleStrawberies)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPoleCarots
            // 
            this.labelPoleCarots.AutoSize = true;
            this.labelPoleCarots.BackColor = System.Drawing.Color.DarkOrange;
            this.labelPoleCarots.Location = new System.Drawing.Point(445, 240);
            this.labelPoleCarots.Name = "labelPoleCarots";
            this.labelPoleCarots.Size = new System.Drawing.Size(80, 20);
            this.labelPoleCarots.TabIndex = 1;
            this.labelPoleCarots.Text = "Marchewki";
            this.labelPoleCarots.Click += new System.EventHandler(this.labelPoleCarots_Click);
            // 
            // timerCarots
            // 
            this.timerCarots.Tick += new System.EventHandler(this.timerMarchewki_Tick);
            // 
            // timerPotatoes
            // 
            this.timerPotatoes.Tick += new System.EventHandler(this.timerZiemniaki_Tick);
            // 
            // buttonPoleColectCarots
            // 
            this.buttonPoleColectCarots.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPoleColectCarots.Location = new System.Drawing.Point(417, 263);
            this.buttonPoleColectCarots.Name = "buttonPoleColectCarots";
            this.buttonPoleColectCarots.Size = new System.Drawing.Size(125, 32);
            this.buttonPoleColectCarots.TabIndex = 8;
            this.buttonPoleColectCarots.Text = "zbierz";
            this.buttonPoleColectCarots.UseVisualStyleBackColor = false;
            this.buttonPoleColectCarots.Click += new System.EventHandler(this.buttonPoleZbierzMarchewki_Click);
            // 
            // buttonPoleCollectPotatoes
            // 
            this.buttonPoleCollectPotatoes.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPoleCollectPotatoes.Location = new System.Drawing.Point(18, 290);
            this.buttonPoleCollectPotatoes.Name = "buttonPoleCollectPotatoes";
            this.buttonPoleCollectPotatoes.Size = new System.Drawing.Size(125, 31);
            this.buttonPoleCollectPotatoes.TabIndex = 9;
            this.buttonPoleCollectPotatoes.Text = "Zbierz";
            this.buttonPoleCollectPotatoes.UseVisualStyleBackColor = false;
            this.buttonPoleCollectPotatoes.Click += new System.EventHandler(this.buttonPoleZbierzZiemniaki_Click);
            // 
            // progressBarCarots
            // 
            this.progressBarCarots.Location = new System.Drawing.Point(417, 362);
            this.progressBarCarots.Maximum = 60;
            this.progressBarCarots.Name = "progressBarCarots";
            this.progressBarCarots.Size = new System.Drawing.Size(125, 23);
            this.progressBarCarots.TabIndex = 10;
            // 
            // progressBarPotatoes
            // 
            this.progressBarPotatoes.Location = new System.Drawing.Point(19, 395);
            this.progressBarPotatoes.Maximum = 300;
            this.progressBarPotatoes.Name = "progressBarPotatoes";
            this.progressBarPotatoes.Size = new System.Drawing.Size(124, 20);
            this.progressBarPotatoes.TabIndex = 11;
            // 
            // buttonPoleCollectStrawberiess
            // 
            this.buttonPoleCollectStrawberiess.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPoleCollectStrawberiess.Location = new System.Drawing.Point(215, 232);
            this.buttonPoleCollectStrawberiess.Name = "buttonPoleCollectStrawberiess";
            this.buttonPoleCollectStrawberiess.Size = new System.Drawing.Size(125, 27);
            this.buttonPoleCollectStrawberiess.TabIndex = 12;
            this.buttonPoleCollectStrawberiess.Text = "Zbierz";
            this.buttonPoleCollectStrawberiess.UseVisualStyleBackColor = false;
            this.buttonPoleCollectStrawberiess.Click += new System.EventHandler(this.buttonPoleZbierzTruskawki_Click);
            // 
            // labelPoleStrawberies
            // 
            this.labelPoleStrawberies.AutoSize = true;
            this.labelPoleStrawberies.BackColor = System.Drawing.Color.Tomato;
            this.labelPoleStrawberies.Location = new System.Drawing.Point(240, 209);
            this.labelPoleStrawberies.Name = "labelPoleStrawberies";
            this.labelPoleStrawberies.Size = new System.Drawing.Size(72, 20);
            this.labelPoleStrawberies.TabIndex = 13;
            this.labelPoleStrawberies.Text = "Truskawki";
            this.labelPoleStrawberies.Click += new System.EventHandler(this.labelPoleStrawberies_Click);
            // 
            // progressBarStrawberies
            // 
            this.progressBarStrawberies.Location = new System.Drawing.Point(215, 333);
            this.progressBarStrawberies.Maximum = 3600;
            this.progressBarStrawberies.Name = "progressBarStrawberies";
            this.progressBarStrawberies.Size = new System.Drawing.Size(125, 23);
            this.progressBarStrawberies.TabIndex = 14;
            // 
            // pictureboxPoleCarots
            // 
            this.pictureboxPoleCarots.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxPoleCarots.Image = global::FarmGame.Properties.Resources.carrot_PNG4984;
            this.pictureboxPoleCarots.Location = new System.Drawing.Point(417, 294);
            this.pictureboxPoleCarots.Name = "pictureboxPoleCarots";
            this.pictureboxPoleCarots.Size = new System.Drawing.Size(125, 69);
            this.pictureboxPoleCarots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxPoleCarots.TabIndex = 15;
            this.pictureboxPoleCarots.TabStop = false;
            // 
            // pictureBoxPolePotatoes
            // 
            this.pictureBoxPolePotatoes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPolePotatoes.Image = global::FarmGame.Properties.Resources._11_potato_png_images_pictures_download;
            this.pictureBoxPolePotatoes.Location = new System.Drawing.Point(18, 327);
            this.pictureBoxPolePotatoes.Name = "pictureBoxPolePotatoes";
            this.pictureBoxPolePotatoes.Size = new System.Drawing.Size(125, 62);
            this.pictureBoxPolePotatoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPolePotatoes.TabIndex = 16;
            this.pictureBoxPolePotatoes.TabStop = false;
            // 
            // pictureBoxPoleStrawberies
            // 
            this.pictureBoxPoleStrawberies.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoleStrawberies.Image = global::FarmGame.Properties.Resources.strawberry_clip_art_17;
            this.pictureBoxPoleStrawberies.Location = new System.Drawing.Point(215, 265);
            this.pictureBoxPoleStrawberies.Name = "pictureBoxPoleStrawberies";
            this.pictureBoxPoleStrawberies.Size = new System.Drawing.Size(125, 62);
            this.pictureBoxPoleStrawberies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoleStrawberies.TabIndex = 16;
            this.pictureBoxPoleStrawberies.TabStop = false;
            // 
            // labelPolePotatoes
            // 
            this.labelPolePotatoes.AutoSize = true;
            this.labelPolePotatoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPolePotatoes.Location = new System.Drawing.Point(40, 267);
            this.labelPolePotatoes.Name = "labelPolePotatoes";
            this.labelPolePotatoes.Size = new System.Drawing.Size(74, 20);
            this.labelPolePotatoes.TabIndex = 17;
            this.labelPolePotatoes.Text = "Ziemniaki";
            this.labelPolePotatoes.Click += new System.EventHandler(this.labelPolePotatoes_Click_1);
            // 
            // FormPole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmGame.Properties.Resources._59372765_farm_tractor_with_sheaf_harvest_farm_landscape_illustration_field_wheat_background_farm_sunrise_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPolePotatoes);
            this.Controls.Add(this.pictureBoxPoleStrawberies);
            this.Controls.Add(this.pictureBoxPolePotatoes);
            this.Controls.Add(this.pictureboxPoleCarots);
            this.Controls.Add(this.progressBarStrawberies);
            this.Controls.Add(this.labelPoleStrawberies);
            this.Controls.Add(this.buttonPoleCollectStrawberiess);
            this.Controls.Add(this.progressBarPotatoes);
            this.Controls.Add(this.progressBarCarots);
            this.Controls.Add(this.buttonPoleCollectPotatoes);
            this.Controls.Add(this.buttonPoleColectCarots);
            this.Controls.Add(this.labelPoleCarots);
            this.Name = "FormPole";
            this.Text = " POLE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPoleCarots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolePotatoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoleStrawberies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label labelPoleCarots;
        private System.Windows.Forms.Timer timerCarots;
       
     
        private System.Windows.Forms.Timer timerPotatoes;
        private System.Windows.Forms.Button buttonPoleColectCarots;
        private System.Windows.Forms.Button buttonPoleCollectPotatoes;
        private System.Windows.Forms.ProgressBar progressBarCarots;
        private System.Windows.Forms.ProgressBar progressBarPotatoes;
        private System.Windows.Forms.Button buttonPoleCollectStrawberiess;
        private System.Windows.Forms.Label labelPoleStrawberies;
        private System.Windows.Forms.ProgressBar progressBarStrawberies;
        private System.Windows.Forms.Timer timerStrawberies;
        private System.Windows.Forms.PictureBox pictureboxPoleCarots;
        private System.Windows.Forms.PictureBox pictureBoxPolePotatoes;
        private System.Windows.Forms.PictureBox pictureBoxPoleStrawberies;
        private System.Windows.Forms.Label labelPolePotatoes;
    }
}