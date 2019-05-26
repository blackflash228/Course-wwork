namespace Remont_App
{
    partial class StartScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.Manager = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Manager
            // 
            this.Manager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manager.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manager.Location = new System.Drawing.Point(203, 284);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(344, 89);
            this.Manager.TabIndex = 0;
            this.Manager.Text = "Перегляд БД клієнтів";
            this.Manager.UseVisualStyleBackColor = false;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client.Location = new System.Drawing.Point(203, 166);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(344, 89);
            this.Client.TabIndex = 1;
            this.Client.Text = "Додати клієнта до БД";
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::Remont_App.Properties.Resources.close;
            this.Exit.Location = new System.Drawing.Point(711, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 88;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Remont_App.Properties.Resources.LOGO_v2;
            this.Logo.Location = new System.Drawing.Point(177, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(408, 108);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 89;
            this.Logo.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Manager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABT ";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Logo;
    }
}

