namespace Remont_App
{
    partial class LoadingProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingProgramm));
            this.LoadPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadPicture
            // 
            this.LoadPicture.Image = global::Remont_App.Properties.Resources.LoadScreen1;
            this.LoadPicture.Location = new System.Drawing.Point(-2, -49);
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.Size = new System.Drawing.Size(806, 446);
            this.LoadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadPicture.TabIndex = 0;
            this.LoadPicture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LoadingProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.LoadPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingProgramm";
            ((System.ComponentModel.ISupportInitialize)(this.LoadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadPicture;
        private System.Windows.Forms.Timer timer1;
    }
}