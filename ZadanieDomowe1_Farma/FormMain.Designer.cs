
namespace ZadanieDomowe1_Farma
{
    partial class FormMain
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
            this.buttonSklep = new System.Windows.Forms.Button();
            this.buttonPole = new System.Windows.Forms.Button();
            this.labelPoziom = new System.Windows.Forms.Label();
            this.textBoxLvl = new System.Windows.Forms.TextBox();
            this.pictureBoxFormMainSign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormMainSign)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSklep
            // 
            this.buttonSklep.BackColor = System.Drawing.Color.Tomato;
            this.buttonSklep.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSklep.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSklep.Location = new System.Drawing.Point(981, 364);
            this.buttonSklep.Name = "buttonSklep";
            this.buttonSklep.Size = new System.Drawing.Size(121, 39);
            this.buttonSklep.TabIndex = 0;
            this.buttonSklep.Text = "SKLEP";
            this.buttonSklep.UseVisualStyleBackColor = false;
            this.buttonSklep.Click += new System.EventHandler(this.buttonSklep_Click);
            // 
            // buttonPole
            // 
            this.buttonPole.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonPole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPole.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPole.ForeColor = System.Drawing.Color.Black;
            this.buttonPole.Location = new System.Drawing.Point(392, 281);
            this.buttonPole.Name = "buttonPole";
            this.buttonPole.Size = new System.Drawing.Size(232, 66);
            this.buttonPole.TabIndex = 1;
            this.buttonPole.Text = "POLE";
            this.buttonPole.UseVisualStyleBackColor = false;
            this.buttonPole.Click += new System.EventHandler(this.buttonPole_Click);
            // 
            // labelPoziom
            // 
            this.labelPoziom.AutoSize = true;
            this.labelPoziom.Location = new System.Drawing.Point(1151, 24);
            this.labelPoziom.Name = "labelPoziom";
            this.labelPoziom.Size = new System.Drawing.Size(65, 20);
            this.labelPoziom.TabIndex = 2;
            this.labelPoziom.Text = "Poziom: ";
            // 
            // textBoxLvl
            // 
            this.textBoxLvl.Location = new System.Drawing.Point(1222, 21);
            this.textBoxLvl.Name = "textBoxLvl";
            this.textBoxLvl.Size = new System.Drawing.Size(125, 27);
            this.textBoxLvl.TabIndex = 3;
            this.textBoxLvl.Text = "0";
            // 
            // pictureBoxFormMainSign
            // 
            this.pictureBoxFormMainSign.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFormMainSign.Image = global::ZadanieDomowe1_Farma.Properties.Resources._47c0ae0a85636e9beb10eb2746111fbd;
            this.pictureBoxFormMainSign.Location = new System.Drawing.Point(416, 227);
            this.pictureBoxFormMainSign.Name = "pictureBoxFormMainSign";
            this.pictureBoxFormMainSign.Size = new System.Drawing.Size(208, 288);
            this.pictureBoxFormMainSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormMainSign.TabIndex = 4;
            this.pictureBoxFormMainSign.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZadanieDomowe1_Farma.Properties.Resources.rogue_dragon_studio_janesfarm_main;
            this.ClientSize = new System.Drawing.Size(1346, 717);
            this.Controls.Add(this.buttonPole);
            this.Controls.Add(this.pictureBoxFormMainSign);
            this.Controls.Add(this.textBoxLvl);
            this.Controls.Add(this.labelPoziom);
            this.Controls.Add(this.buttonSklep);
            this.Name = "FormMain";
            this.Text = "FarmaNaWypasie";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormMainSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSklep;
        private System.Windows.Forms.Button buttonPole;
        private System.Windows.Forms.Label labelPoziom;
        private System.Windows.Forms.TextBox textBoxLvl;
        private System.Windows.Forms.PictureBox pictureBoxFormMainSign;
    }
}

