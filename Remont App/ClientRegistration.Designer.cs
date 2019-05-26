namespace Remont_App
{
    partial class ClientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegistration));
            this.Engine = new System.Windows.Forms.Label();
            this.Diesel = new System.Windows.Forms.RadioButton();
            this.Petrol = new System.Windows.Forms.RadioButton();
            this.labelinfo3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.labelinfo5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelinfo1 = new System.Windows.Forms.Label();
            this.PickerDate = new System.Windows.Forms.DateTimePicker();
            this.Enter = new System.Windows.Forms.Button();
            this.Clientphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Labelinfo = new System.Windows.Forms.Label();
            this.labelmulfunction = new System.Windows.Forms.Label();
            this.mulfunctionbox = new System.Windows.Forms.TextBox();
            this.labelyearauto = new System.Windows.Forms.Label();
            this.labelauto = new System.Windows.Forms.Label();
            this.Labelgret = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.labelmodel = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Enginevalue = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Leftback = new System.Windows.Forms.PictureBox();
            this.Min = new System.Windows.Forms.ComboBox();
            this.Hours = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).BeginInit();
            this.SuspendLayout();
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.BackColor = System.Drawing.Color.Transparent;
            this.Engine.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Engine.Location = new System.Drawing.Point(29, 424);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(111, 18);
            this.Engine.TabIndex = 78;
            this.Engine.Text = "Об\'єм двигуна";
            // 
            // Diesel
            // 
            this.Diesel.AutoSize = true;
            this.Diesel.BackColor = System.Drawing.Color.Transparent;
            this.Diesel.Location = new System.Drawing.Point(103, 479);
            this.Diesel.Name = "Diesel";
            this.Diesel.Size = new System.Drawing.Size(64, 17);
            this.Diesel.TabIndex = 77;
            this.Diesel.Text = "Дизель";
            this.Diesel.UseVisualStyleBackColor = false;
            // 
            // Petrol
            // 
            this.Petrol.AutoSize = true;
            this.Petrol.BackColor = System.Drawing.Color.Transparent;
            this.Petrol.Checked = true;
            this.Petrol.Location = new System.Drawing.Point(35, 479);
            this.Petrol.Name = "Petrol";
            this.Petrol.Size = new System.Drawing.Size(62, 17);
            this.Petrol.TabIndex = 76;
            this.Petrol.TabStop = true;
            this.Petrol.Text = "Бензин";
            this.Petrol.UseVisualStyleBackColor = false;
            // 
            // labelinfo3
            // 
            this.labelinfo3.AutoSize = true;
            this.labelinfo3.BackColor = System.Drawing.Color.Transparent;
            this.labelinfo3.Font = new System.Drawing.Font("SF UI Display", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo3.Location = new System.Drawing.Point(200, 257);
            this.labelinfo3.Name = "labelinfo3";
            this.labelinfo3.Size = new System.Drawing.Size(278, 24);
            this.labelinfo3.TabIndex = 75;
            this.labelinfo3.Text = "Інформація про автомобіль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Ім\'я";
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("SF UI Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname.Location = new System.Drawing.Point(32, 166);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(223, 28);
            this.firstname.TabIndex = 72;
            this.firstname.Leave += new System.EventHandler(this.Firstname_Leave);
            // 
            // labelinfo5
            // 
            this.labelinfo5.AutoSize = true;
            this.labelinfo5.BackColor = System.Drawing.Color.Transparent;
            this.labelinfo5.Font = new System.Drawing.Font("SF UI Display", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo5.Location = new System.Drawing.Point(220, 121);
            this.labelinfo5.Name = "labelinfo5";
            this.labelinfo5.Size = new System.Drawing.Size(229, 24);
            this.labelinfo5.TabIndex = 70;
            this.labelinfo5.Text = "Контактна інформація";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(297, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 37);
            this.label4.TabIndex = 68;
            this.label4.Text = ":";
            // 
            // labelinfo1
            // 
            this.labelinfo1.AutoSize = true;
            this.labelinfo1.BackColor = System.Drawing.Color.Transparent;
            this.labelinfo1.Font = new System.Drawing.Font("SF UI Display", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo1.Location = new System.Drawing.Point(189, 522);
            this.labelinfo1.Name = "labelinfo1";
            this.labelinfo1.Size = new System.Drawing.Size(301, 24);
            this.labelinfo1.TabIndex = 66;
            this.labelinfo1.Text = "Ми працюємо з 8:00 до 20:00";
            // 
            // PickerDate
            // 
            this.PickerDate.CalendarFont = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickerDate.Location = new System.Drawing.Point(243, 549);
            this.PickerDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.PickerDate.MinDate = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.PickerDate.Name = "PickerDate";
            this.PickerDate.Size = new System.Drawing.Size(130, 20);
            this.PickerDate.TabIndex = 65;
            this.PickerDate.Value = new System.DateTime(2019, 5, 25, 0, 0, 0, 0);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(505, 592);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(164, 35);
            this.Enter.TabIndex = 64;
            this.Enter.Text = "Записатися на СТО";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Clientphone
            // 
            this.Clientphone.Font = new System.Drawing.Font("SF UI Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clientphone.Location = new System.Drawing.Point(354, 166);
            this.Clientphone.Name = "Clientphone";
            this.Clientphone.Size = new System.Drawing.Size(223, 28);
            this.Clientphone.TabIndex = 63;
            this.Clientphone.Leave += new System.EventHandler(this.Clientphone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF UI Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Номер телефону";
            // 
            // Labelinfo
            // 
            this.Labelinfo.AutoSize = true;
            this.Labelinfo.BackColor = System.Drawing.Color.Transparent;
            this.Labelinfo.Font = new System.Drawing.Font("SF UI Display", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labelinfo.Location = new System.Drawing.Point(212, 501);
            this.Labelinfo.Name = "Labelinfo";
            this.Labelinfo.Size = new System.Drawing.Size(266, 24);
            this.Labelinfo.TabIndex = 61;
            this.Labelinfo.Text = "Бажаний час відвідування";
            // 
            // labelmulfunction
            // 
            this.labelmulfunction.AutoSize = true;
            this.labelmulfunction.BackColor = System.Drawing.Color.Transparent;
            this.labelmulfunction.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmulfunction.Location = new System.Drawing.Point(350, 280);
            this.labelmulfunction.Name = "labelmulfunction";
            this.labelmulfunction.Size = new System.Drawing.Size(248, 18);
            this.labelmulfunction.TabIndex = 60;
            this.labelmulfunction.Text = "Опишіть коротко про несправність";
            // 
            // mulfunctionbox
            // 
            this.mulfunctionbox.Font = new System.Drawing.Font("SF UI Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulfunctionbox.Location = new System.Drawing.Point(353, 301);
            this.mulfunctionbox.Multiline = true;
            this.mulfunctionbox.Name = "mulfunctionbox";
            this.mulfunctionbox.Size = new System.Drawing.Size(298, 109);
            this.mulfunctionbox.TabIndex = 59;
            // 
            // labelyearauto
            // 
            this.labelyearauto.AutoSize = true;
            this.labelyearauto.BackColor = System.Drawing.Color.Transparent;
            this.labelyearauto.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelyearauto.Location = new System.Drawing.Point(29, 373);
            this.labelyearauto.Name = "labelyearauto";
            this.labelyearauto.Size = new System.Drawing.Size(89, 18);
            this.labelyearauto.TabIndex = 57;
            this.labelyearauto.Text = "Рік випуску";
            // 
            // labelauto
            // 
            this.labelauto.AutoSize = true;
            this.labelauto.BackColor = System.Drawing.Color.Transparent;
            this.labelauto.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelauto.Location = new System.Drawing.Point(32, 271);
            this.labelauto.Name = "labelauto";
            this.labelauto.Size = new System.Drawing.Size(58, 18);
            this.labelauto.TabIndex = 55;
            this.labelauto.Text = "Марка:";
            // 
            // Labelgret
            // 
            this.Labelgret.AutoSize = true;
            this.Labelgret.Font = new System.Drawing.Font("SF UI Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labelgret.Location = new System.Drawing.Point(229, -29);
            this.Labelgret.Name = "Labelgret";
            this.Labelgret.Size = new System.Drawing.Size(337, 29);
            this.Labelgret.TabIndex = 54;
            this.Labelgret.Text = "Заявка на ремонт автомобіля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF UI Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Прізвище";
            // 
            // Brand
            // 
            this.Brand.DropDownHeight = 290;
            this.Brand.DropDownWidth = 150;
            this.Brand.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.FormattingEnabled = true;
            this.Brand.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Brand.IntegralHeight = false;
            this.Brand.Items.AddRange(new object[] {
            "Abarth",
            "Acura",
            "Adler",
            "Aero",
            "Aixam",
            "Alfa Romeo",
            "Alpine",
            "Altamarea",
            "AMC",
            "Anaig",
            "Armstrong Siddeley",
            "Aro",
            "Artega",
            "Asia",
            "AsiaStar",
            "Aston Martin",
            "Audi",
            "Austin",
            "Bentley",
            "BMW",
            "BMW-Alpina",
            "Bugatti",
            "Buick",
            "Cadillac",
            "Chery",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "Ferrari",
            "Fiat",
            "Ford",
            "Geely",
            "GMC",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lada",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Maybach",
            "Mazda",
            "McLaren",
            "Mercedes-Benz",
            "MINI",
            "Mitsubishi",
            "Nissan",
            "Opel",
            "Porsche",
            "Renault",
            "Rolls-Royce",
            "Saab",
            "SEAT",
            "Skoda",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo",
            "ЗАЗ",
            "ЗІЛ",
            "ЗІМ",
            "ЗІС",
            "ІЖ",
            "ЛуАЗ",
            "Москвич / АЗЛК",
            "Причіп",
            "Ретро автомобіль",
            "УАЗ"});
            this.Brand.Location = new System.Drawing.Point(32, 291);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(170, 27);
            this.Brand.Sorted = true;
            this.Brand.TabIndex = 79;
            this.Brand.SelectedIndexChanged += new System.EventHandler(this.Marka_SelectedIndexChanged);
            // 
            // labelmodel
            // 
            this.labelmodel.AutoSize = true;
            this.labelmodel.BackColor = System.Drawing.Color.Transparent;
            this.labelmodel.Font = new System.Drawing.Font("SF UI Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmodel.Location = new System.Drawing.Point(32, 322);
            this.labelmodel.Name = "labelmodel";
            this.labelmodel.Size = new System.Drawing.Size(61, 18);
            this.labelmodel.TabIndex = 81;
            this.labelmodel.Text = "Модель";
            // 
            // Year
            // 
            this.Year.DropDownHeight = 250;
            this.Year.DropDownWidth = 150;
            this.Year.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.FormattingEnabled = true;
            this.Year.IntegralHeight = false;
            this.Year.Items.AddRange(new object[] {
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.Year.Location = new System.Drawing.Point(32, 394);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(89, 27);
            this.Year.Sorted = true;
            this.Year.TabIndex = 82;
            // 
            // Enginevalue
            // 
            this.Enginevalue.DropDownHeight = 250;
            this.Enginevalue.DropDownWidth = 150;
            this.Enginevalue.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enginevalue.FormattingEnabled = true;
            this.Enginevalue.IntegralHeight = false;
            this.Enginevalue.Items.AddRange(new object[] {
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2.0",
            "2.1",
            "2.2",
            "2.3",
            "2.4",
            "2.5",
            "2.6",
            "2.7",
            "2.8",
            "2.9",
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5",
            "4.6",
            "4.7",
            "4.8",
            "4.9",
            "5.0",
            "5.1",
            "5.2",
            "5.3",
            "5.4",
            "5.5",
            "5.6",
            "5.7",
            "5.8",
            "5.9",
            "6.0",
            "6.1",
            "6.2",
            "6.3",
            "6.4",
            "6.5"});
            this.Enginevalue.Location = new System.Drawing.Point(31, 446);
            this.Enginevalue.Name = "Enginevalue";
            this.Enginevalue.Size = new System.Drawing.Size(89, 27);
            this.Enginevalue.Sorted = true;
            this.Enginevalue.TabIndex = 83;
            // 
            // Logo
            // 
            this.Logo.Image = global::Remont_App.Properties.Resources.LOGO_v2;
            this.Logo.Location = new System.Drawing.Point(224, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 90);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 88;
            this.Logo.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::Remont_App.Properties.Resources.close;
            this.Exit.Location = new System.Drawing.Point(647, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 87;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Leftback
            // 
            this.Leftback.BackColor = System.Drawing.Color.Transparent;
            this.Leftback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Leftback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Leftback.Image = global::Remont_App.Properties.Resources.Back;
            this.Leftback.Location = new System.Drawing.Point(-1, 1);
            this.Leftback.Name = "Leftback";
            this.Leftback.Size = new System.Drawing.Size(41, 34);
            this.Leftback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Leftback.TabIndex = 86;
            this.Leftback.TabStop = false;
            this.Leftback.Click += new System.EventHandler(this.Leftback_Click);
            // 
            // Min
            // 
            this.Min.DropDownWidth = 89;
            this.Min.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.FormattingEnabled = true;
            this.Min.IntegralHeight = false;
            this.Min.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.Min.Location = new System.Drawing.Point(313, 575);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(54, 27);
            this.Min.Sorted = true;
            this.Min.TabIndex = 89;
            // 
            // Hours
            // 
            this.Hours.DropDownWidth = 89;
            this.Hours.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.FormattingEnabled = true;
            this.Hours.IntegralHeight = false;
            this.Hours.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.Hours.Location = new System.Drawing.Point(253, 575);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(54, 27);
            this.Hours.Sorted = true;
            this.Hours.TabIndex = 90;
            // 
            // Model
            // 
            this.Model.DropDownHeight = 290;
            this.Model.DropDownWidth = 150;
            this.Model.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.FormattingEnabled = true;
            this.Model.IntegralHeight = false;
            this.Model.Location = new System.Drawing.Point(32, 342);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(171, 27);
            this.Model.Sorted = true;
            this.Model.TabIndex = 80;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("SF UI Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(32, 217);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(223, 28);
            this.Name.TabIndex = 73;
            this.Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // ClientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(681, 639);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Leftback);
            this.Controls.Add(this.Enginevalue);
            this.Controls.Add(this.labelmodel);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Engine);
            this.Controls.Add(this.Diesel);
            this.Controls.Add(this.Petrol);
            this.Controls.Add(this.labelinfo3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.labelinfo5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelinfo1);
            this.Controls.Add(this.PickerDate);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Clientphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Labelinfo);
            this.Controls.Add(this.labelmulfunction);
            this.Controls.Add(this.mulfunctionbox);
            this.Controls.Add(this.labelyearauto);
            this.Controls.Add(this.labelauto);
            this.Controls.Add(this.Labelgret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Year);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegFORM";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Engine;
        private System.Windows.Forms.RadioButton Diesel;
        private System.Windows.Forms.RadioButton Petrol;
        private System.Windows.Forms.Label labelinfo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label labelinfo5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelinfo1;
        public System.Windows.Forms.DateTimePicker PickerDate;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox Clientphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Labelinfo;
        private System.Windows.Forms.Label labelmulfunction;
        private System.Windows.Forms.TextBox mulfunctionbox;
        private System.Windows.Forms.Label labelyearauto;
        private System.Windows.Forms.Label labelauto;
        private System.Windows.Forms.Label Labelgret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.Label labelmodel;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Enginevalue;
        private System.Windows.Forms.PictureBox Leftback;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ComboBox Min;
        private System.Windows.Forms.ComboBox Hours;
        private System.Windows.Forms.ComboBox Model;
        private System.Windows.Forms.TextBox Name;
    }
}