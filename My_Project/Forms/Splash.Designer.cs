namespace My_Project
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lblBookMain = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.MyProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.Percentagelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookMain
            // 
            this.lblBookMain.AutoSize = true;
            this.lblBookMain.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMain.ForeColor = System.Drawing.Color.White;
            this.lblBookMain.Location = new System.Drawing.Point(50, 27);
            this.lblBookMain.Name = "lblBookMain";
            this.lblBookMain.Size = new System.Drawing.Size(389, 30);
            this.lblBookMain.TabIndex = 0;
            this.lblBookMain.Text = "Book Shop Management System";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(158, 84);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(191, 137);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // MyProgressBar
            // 
            this.MyProgressBar.Location = new System.Drawing.Point(12, 281);
            this.MyProgressBar.Name = "MyProgressBar";
            this.MyProgressBar.Size = new System.Drawing.Size(468, 28);
            this.MyProgressBar.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.LimeGreen;
            this.lblLoading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(12, 259);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(89, 19);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading....";
            // 
            // Percentagelbl
            // 
            this.Percentagelbl.AutoSize = true;
            this.Percentagelbl.BackColor = System.Drawing.Color.LimeGreen;
            this.Percentagelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentagelbl.ForeColor = System.Drawing.Color.White;
            this.Percentagelbl.Location = new System.Drawing.Point(107, 259);
            this.Percentagelbl.Name = "Percentagelbl";
            this.Percentagelbl.Size = new System.Drawing.Size(23, 19);
            this.Percentagelbl.TabIndex = 4;
            this.Percentagelbl.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(this.Percentagelbl);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.MyProgressBar);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblBookMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookMain;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ProgressBar MyProgressBar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label Percentagelbl;
        private System.Windows.Forms.Timer timer1;
    }
}

