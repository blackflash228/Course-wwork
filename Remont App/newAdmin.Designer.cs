namespace Remont_App
{
    partial class newAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newAdmin));
            this.Add = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Pos = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Leftback = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.PinVisible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(265, 292);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(142, 37);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("SF UI Display", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(185, 80);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(307, 29);
            this.Login.TabIndex = 1;
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(185, 138);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(307, 29);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Додавання нового користувача для доступу до черги клієнтів";
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.Location = new System.Drawing.Point(298, 54);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(57, 23);
            this.Log.TabIndex = 4;
            this.Log.Text = "Логін";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(298, 112);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(74, 23);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Пароль";
            // 
            // Pos
            // 
            this.Pos.AutoSize = true;
            this.Pos.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pos.Location = new System.Drawing.Point(298, 231);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(75, 23);
            this.Pos.TabIndex = 7;
            this.Pos.Text = "Посада";
            // 
            // Position
            // 
            this.Position.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Position.Location = new System.Drawing.Point(185, 257);
            this.Position.Multiline = true;
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(307, 29);
            this.Position.TabIndex = 6;
            this.Position.Leave += new System.EventHandler(this.Position_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(298, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-mail";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(185, 199);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(307, 29);
            this.Email.TabIndex = 8;
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::Remont_App.Properties.Resources.close;
            this.Exit.Location = new System.Drawing.Point(625, -2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 96;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Leftback
            // 
            this.Leftback.BackColor = System.Drawing.Color.Transparent;
            this.Leftback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Leftback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Leftback.Image = global::Remont_App.Properties.Resources.Back;
            this.Leftback.Location = new System.Drawing.Point(-125, -1);
            this.Leftback.Name = "Leftback";
            this.Leftback.Size = new System.Drawing.Size(41, 34);
            this.Leftback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Leftback.TabIndex = 95;
            this.Leftback.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::Remont_App.Properties.Resources.Back;
            this.Back.Location = new System.Drawing.Point(0, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(41, 34);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 97;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PinVisible
            // 
            this.PinVisible.BackColor = System.Drawing.Color.Transparent;
            this.PinVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PinVisible.Image = global::Remont_App.Properties.Resources.closedEye;
            this.PinVisible.Location = new System.Drawing.Point(498, 138);
            this.PinVisible.Name = "PinVisible";
            this.PinVisible.Size = new System.Drawing.Size(37, 29);
            this.PinVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PinVisible.TabIndex = 98;
            this.PinVisible.TabStop = false;
            this.PinVisible.Click += new System.EventHandler(this.PinVisible_Click);
            // 
            // newAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 345);
            this.Controls.Add(this.PinVisible);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Leftback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 345);
            this.MinimumSize = new System.Drawing.Size(658, 345);
            this.Name = "newAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Pos;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Leftback;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox PinVisible;
    }
}