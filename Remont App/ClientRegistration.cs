using AuthorizedClass;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsNotification;
namespace Remont_App
{
    public partial class ClientRegistration : Form
    {
        public ClientRegistration()
        {
            InitializeComponent();
            Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Enginevalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PickerDate.MinDate = DateTime.Today;
        }
        #region Змінні
        int logChanged;
        int logCount = 0;
        int logBoxClicked = 0;
        int FNchanged;
        int FNCount = 0;
        int logFNBoxClicked = 0;
        int namelogChanged;
        int nameCount = 0;
        int logNameBoxClicked;
        string Ftype = "";
        newClient newclient = new newClient();
        newClient exitClient = new newClient();
        #endregion Змінні;
        private void Leftback_Click(object sender, EventArgs e)
        {
            Hide();
            StartScreen stscreen = new StartScreen();
            stscreen.ShowDialog();
            Close();
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            string Time = PickerDate.Text + " " + Hours.Text + ":" + Min.Text;
            exitClient.ClientExist(firstname.Text, Name.Text, Model.Text);
            if (firstname.Text == "" || Name.Text == "" || Brand.Text == "" || Model.Text == "" || Year.Text == "" || Engine.Text == "" || Clientphone.Text == "" || Hours.Text == "" || Min.Text == "")
            {
                MessageBox.Show("Одне із полів не було заповнене!\nПеревірте будь ласка!!!", "Помилка аут-ції", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Petrol.Checked)
                    Ftype = "Бензин";
                else if (Diesel.Checked)
                    Ftype = "Дизель";
                if (exitClient.counter != 0)
                {
                    newclient.nEWClient(firstname.Text, Name.Text, Clientphone.Text, Brand.Text, Model.Text, mulfunctionbox.Text, Year.Text, Enginevalue.Text, Ftype, Time);
                    WinNotify.ShowWinNotify("Результат", "Клієнта було додано до бази даних!", 10000);
                    Hide();
                    StartScreen stscreen = new StartScreen();
                    stscreen.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вабачте, але такий клієнт наявний в базі!", "Помилка аут-ції", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void Clientphone_Leave(object sender, EventArgs e)
        {
            logChanged = 0;
            if (Clientphone.Text == "")
            {
                firstname.ForeColor = Color.Black;
                logChanged++;
            }
            string phonePattern = @"^\+380(3|[5-6]|9)[0-9]\d{3}\d{2}\d{2}$";
            string value = Clientphone.Text;
            Regex phoneValid = new Regex(phonePattern);
            if (!Regex.IsMatch(value, phonePattern, RegexOptions.Compiled) && logCount <= 3)
            {
                logBoxClicked--;
                logCount++;
                Clientphone.Clear();
                firstname.ForeColor = Color.Black;

                MessageBox.Show("Вибачте, ви невірно ввели номер телефон!\nСпробуйте знову!", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           else if (!Regex.IsMatch(value, phonePattern, RegexOptions.Compiled) && logCount > 3)
            {
                logBoxClicked--;
                logCount++;
                Clientphone.Clear();
                firstname.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення телефона", "Ви вводите невірний формат телефону.\nФормат телефону складає 13 символів: +380673456789", 10000);
                return;
            }
        }
        private void Firstname_Leave(object sender, EventArgs e)
        {

            if (firstname.Text == "")
            {
                firstname.ForeColor = Color.Black;
                logChanged++;
            }
            string firstnamePattern = @"^[А-ЯІ][а-яі]+(\-[А-ЯІ][а-яі]+)?$";
            string value = firstname.Text;
            Regex firstnameValid = new Regex(firstnamePattern);
            if (!Regex.IsMatch(value, firstnamePattern, RegexOptions.Compiled) && FNCount <= 3)
            {
                logFNBoxClicked--;
                FNCount++;
                firstname.Clear();
                firstname.ForeColor = Color.Black;
                MessageBox.Show("Вибачте, ви невірно ввели прізвище!\nСпробуйте знову!", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (FNCount > 3)
            {
                logFNBoxClicked--;
                FNCount++;
                firstname.Clear();
                firstname.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення прізвища", "Ви вводите невірно прізвище.\nФормат: Іванов - вірно\nіВАНОВ/іВанов/ІВАнов - невірно", 10000);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Name_Leave(object sender, EventArgs e)
        {
            namelogChanged = 0;
            if (Name.Text == "")
            {
                Name.ForeColor = Color.Black;
                namelogChanged++;
            }
            string namePattern = @"^[А-ЯІ][а-яі]+(\-[А-Я][а-я]+)?$";
            string value = Name.Text;
            Regex nameValid = new Regex(namePattern);
            if (!Regex.IsMatch(value, namePattern, RegexOptions.Compiled) && nameCount <= 3)
            {
                logFNBoxClicked--;
                nameCount++;
                Name.Clear();
                Name.ForeColor = Color.Black;
                MessageBox.Show("Вибачте, ви невірно ввели ім'я!\nСпробуйте знову!", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nameCount > 3)
            {
                logNameBoxClicked--;
                nameCount++;
                Name.Clear();
                Name.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення імені", "Ви вводите невірно ім'я.\nФормат: Іван - вірно\nіВАН/іВан/ІВАН - невірно", 5000);
            }
        }
        private void Marka_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedState = Brand.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Abarth":
                    Model.Visible = true;
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Fiat 500", "Fiat 595" });
                    break;
                case "Acura":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "CL", "EL", "ILX", "Integra", "Legend", "MDX", "NSX", "RDX", "RL", "RLX", "RSX", "SLX", "TL", "TLX", "TSX", "Vigo", "ZDX" });
                    break;
                case "Adler":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Stromform", "Trumpf" });
                    break;

                case "Aero":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("30");
                    break;
                case "Aixam":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "400", "500", "City", "Scouty" });
                    break;
                case "Alfa Romeo":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "1333", "145", "146", "147", "149", "155", "156", "159", "164", "166", "169", "2600", "33", "4C", "6(119)", "75", "90", "Alfasud", "Alfetta", "AR", "Arna",
                    "Brera", "Crosswagen", "Das", "Giulia", "Giulietta", "Gold Cloverleaf", "GT", "GTA", "GTV", "Imola", "Junior", "Mito","Montreal", "Spider", "Sprint", "Stelvio", "SZ"});
                    break;
                case "Alpine":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "A110", "A310", "A610" });
                    break;
                case "Altamarea":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("2E");
                    break;
                case "AMC":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("Matador");
                    break;
                case "Anaig":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("Quick 2000");
                    break;
                case "Armstrong Siddeley":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("Sapphire");
                    break;
                case "Aro":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "10", "104", "24", "240", "243", "244", "245", "246", "461", "Spartana" });
                    break;
                case "Artega":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.Add("GT");
                    break;
                case "Asia":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Cosmos", "Rocsta", "Topic", "Towner" });
                    break;
                case "AsiaStar":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "YBL5040XXY", "YBL6531QP", "YBL6531QP1" });
                    break;
                case "Aston Martin":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "DB11", "DB2", "DB2/4", "DB4", "DB5", "DB6", "DB7", "DB9", "DBS", "Virage", "Cygnet", "Lagonda",
                        "Lagonda", "One-77", "Rapide", "V12 Vanquish", "V12 Vantage", "V12 Zagato", "V8 Vantage", "Vanquish", "Vantage"});
                    break;
                case "Audi":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "100", "200", "50", "80", "90", "A1", "A2", "A3", "A3 Sportback E-tron", "A4", "A4 Allroad", "A5",
                        "A6", "A6 Allroad", "A7", "A8", "Coupe", "DKW", "E-TRON", "Q2", "Q3", "Q5", "Q7", "Q7 E-Tron", "Q8", "R8", "RS 4 Avant", "RS Q3", "RS2", "RS3", "RS4", "RS5", "RS6", "RS7", "S2", "S3", "S4", "S5", "S6", "S7 Sportback",
                    "S8", "SQ", "SQ2", "SQ5", "SQ7", "TT", "TT RS", "TTS", "V8"});
                    break;
                case "Austin":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Allegro", "Ambassador", "FX", "Maestro", "Maxi", "Maxi 2", "Metro", "Mini", "Mini", "Mini Classic", "Cygnet", "Mini MK",
                        "Montego", "Montego Kombi", "Princess", "Princess 2", "Rover"});
                    break;
                case "Bentley":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Arnage", "Azure", "Bentayga", "Brooklands", "Continental", "Continental GT", "Continental GT V8", "Continental GT V8 S",
                        "Continental Supersports", "Corniche", "Eight", "Flying Spur",
                        "Flying Spur V8", "Mark VI", "Mulsanne", "S 1", "S 2", "Series II", "Speed 8", "T 1", "T 2", "Turbo R", "Turbo RT"});
                    break;
                case "BMW":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "1 Series", "1 Series M", "114", "116", "118", "120", "123", "125",
                        "128", "130", "135", "1602",
                        "2 series", "2000", "2002", "214", "216", "218", "220", "225", "228", "230", "235", "240", "3 Series", "3 Series GT", "315", "316", "318", "320", "321", "323", "324",
                        "325", "326", "328", "330", "335", "340", "4 Series", "4 Series Gran Coupe", "418",
                    "420", "425", "428", "430", "435", "440", "5 Series", "5 Series GT", "518", "520", "523", "524", "525", "525", "530", "535", "540", "545", "550", "6 Series", "6 Series GT", "628", "630",
                        "633", "635", "640","645", "650", "7 Series", "725", "728", "730", "735", "740", "750", "760", "8 Series", "840", "850", "Active Hybrid 3", "Active Hybrid 5", "Active Hybrid 7", "Alpina", "Dixi",
                        "E", "F10", "I3", "I8", "Isetta", "M1", "M2", "M3", "M4", "M5",
                        "M6", "X4", "X4M", "X5", "X5M", "X6", "X6M", "X7", "Z1","Z3", "Z4", "Z8"});
                    break;
                case "BMW-Alpina":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "B3", "B4", "B5", "B7" });
                    break;
                case "Bugatti":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Chiron", "EB 110", "EB 112", "Galibier", "Veyron" });
                    break;
                case "Buick":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Cascada", "Century", "Eight", "Electra", "Enclave", "Enclave USA", "Encore", "Envision",
                        "GL 8", "LaCrosse", "LaCrosse USA", "LE Sabre",
                        "Limitet", "LuCerne", "Park Avenue", "Rainer", "Reatta", "Regal", "Regal GS", "Rendezvous", "Riviera", "Roadmaster", "Skyhawk",
                        "Skylark", "Special", "Super", "Verano", "Wildcat"});
                    break;
                case "Cadillac":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Allante", "ATS", "BLS", "Brougham", "Calais", "Catera", "Cimarron", "Convertible",
                        "CT6", "CTS", "CTS-V Coupe", "DE Ville",
                        "DTS", "Eldorado", "ELR", "Escalade", "Eureka", "Evoq", "Fleetwood", "LSE", "Seville", "SRX", "STS",
                        "Vizon", "XLR", "XT4", "XT5", "XTS"});
                    break;
                case "Chery":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "A13", "A15", "Amulet", "Arrizo 3", "Arrizo 7", "B11", "Beat", "CrossEastar",
                        "E 5", "Eastar", "Elara", "Flagcloud",
                        "Fora", "Jaggi", "Karry", "Kimo", "M", "M11", "Oriental Son", "QQ", "Riich", "SQR", "Tiggo",
                        "Tiggo 2", "Tiggo 3", "Tiggo 4", "Tiggo 5", "Tiggo 7"});
                    break;
                case "Chevrolet":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Alero", "Astra", "Astro", "Avalanche", "Aveo", "Beauville", "Bel Air", "Beretta",
                        "Blazer", "Bolt EV", "C/K", "Camaro", "Camaro Convertible", "Caprice", "Captiva", "Cavalier", "Celebrity", "Celta", "Chance",
                        "Chery", "Chevelle", "Chevy", "Citation", "City Express", "Classic", "Cobalt", "Colorado", "Convertible", "Corsa", "Corsica", "Corvette", "Cruze", "DeLuxe", "El Camino",
                        "Epica", "Equinox", "Explorer", "Express", "Geo Metro",
                        "Geo Storm", "HHR", "Impala", "Kalos", "Lacetti", "Lanos", "Lumina", "Malibu", "Master", "Master De luxe", "Matiz", "Metro", "Monte Carlo", "Monza", "Niva",
                    "Nova", "Nubira", "Omega", "Opala", "Orlando", "Prizm", "R3500", "Rezzo", "S-10", "Silverado", "Sonic", "Sonama", "Spark", "Spectrum", "SS", "SSR", "Suburban",
                    "Tacuma", "Tahoe", "Tracker", "TrailBlazer", "Trans Sport", "Traverse", "Trax", "Uplander", "Van G-20", "Vandura", "Ventura", "Volt", "Taxo"});
                    break;
                case "Chrysler":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "160", "180", "200", "300", "300 C", "300 M", "300 S", "Aspen",
                        "Avenger", "Cirrus", "Concorde", "Crossfire",
                        "Daytona Shelby", "De Soto", "Dynasty", "ES", "Grand Voyager", "HHR", "Imperial", "Intrepid", "Laser", "LE Baron", "LHS",
                        "Neon", "New Yorker", "Pacifica", "Phantom", "Prowler", "PT Cruise", "Phantom", "Prowler", "PT Cruise", "Reliant", "Royal", "Saratoga", "Sebring","Simca","Stratus",
                        "Sumbeam", "Tolbot", "Town & Country", "Viper", "Vision", "Voyager"});
                    break;
                case "Citroen":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "2CV", "Acadiane", "AMI", "Athena", "AX", "Axel", "Berlingo", "BX",
                        "C-Crosser", "C-Elysee", "C-Zero", "C1",
                        "C15", "C2", "C25", "C3", "C3 Aircross", "C3 Picasso", "C4", "C4 Aircross", "C4 Cactus", "C4 Picasso", "C5",
                        "C5 Aircross", "C6", "C8", "CQ", "CX", "DS3", "DS4", "DS5", "Dyane", "e-Berlingo Multispace", "Evasion", "Grand C4 Picasso","GS","GSA","ID",
                        "Jumper", "LNA", "Nemo", "Oltcit", "Reflex", "Rosalie", "Saxo", "Space Tourer", "Synergie", "Traction Avant", "Visa", "Xantia", "XM", "Xsara",
                        "Xsara Picasso", "ZX"});
                    break;
                case "Dacia":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "1300", "1304", "1310", "1325", "1410", "Clima", "Denem", "Dokker",
                        "Duster", "Express", "Lodgy", "Logan",
                        "Logan MCV", "Locan Pick-up", "Nova", "Rapsodie", "Sandero", "Sandero StepWay", "Solenza", "SuperNova"});
                    break;
                case "Daewoo":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Arcadia", "Brougham", "BV", "Charman", "Cielo", "Damas", "Espero", "Evanda",
                        "Gentra", "Kalos", "Korando", "Lacetti",
                        "Lanos", "LE Mans", "Leganza", "Lulbin", "Magnus", "Matiz", "Musso", "Nexia", "Nubira", "Nubira SX", "Polonez", "Prince", "Racer", "Rezzo", "Royale", "Sens",
                    "Super Salon", "Tacuma", "Tico", "Tosca"});
                    break;
                case "Ferrari":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "208", "308", "250 GTO", "328", "348", "360", "400", "412",
                        "456", "456M", "458", "458 Italia",
                        "488 GTB", "488 Pista", "488 Spider", "512", "550", "575M", "599", "599 GTO", "612 Scaglietti", "812 Superfast", "857 S ", "Barchetta", "California",
                        "Dino", "Enzo", "F12", "F355", "F40", "F430", "F50", "F512", "FF", "Fiorano", "GTC4 Lusso", "LaFerrari", "Maranello California", "Maranello California USA",
                    "Modena Spider", "Mondial", "Scuderia Spider 16M Convertible", "Testarossa"});
                    break;
                case "Fiat":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "1100B", "124", "125", "126", "127", "128", "129", "130",
                        "131", "132", "133", "138",
                        "1500", "2300", "238", "242", "500", "500 C", "500 L ", "500 X ", "500 T", "508", "600",
                        "850", "900", "Abarth", "Albea", "Argenta", "Barchetta", "Brava", "Bravo", "Campagnola", "Cinquecento", "Cordoba", "Coupe","Croga","Doblo","Ducato",
                        "Duna", "Elba", "Florino", "Freemont", "FSO Polonez", "Fullback", "Grande Punto", "Ibiza", "Idea", "Leon", "Linea", "Lusso Familiare", "Marea", "Mirofiori",
                        "Multipla", "Palio", "Panda", "Punto", "Qubo", "Regata", "Ritmo", "Scudo", "Sedici", "Seicento", "Siena", "Simca", "Stilo", "Strada", "Talento", "Tempra", "Tipo",
                    "Topolino", "Torino", "Ulysse", "Uno", "Yugo"});
                    break;
                case "Ford":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] {"Aerostar", "Antara", "Aspire", "Auborn", "B-Max", "C-Max", "C-Max Energi",
                        "Cabster", "Canyon", "Capri", "Cobra",
                        "Consul", "Cortina", "Cougar", "Courier", "Diamant", "Eafil", "Econoline", "EcoSport", "Escape", "Escort", "Excursion",
                        "Explorer", "F-150", "F-250", "F-350", "F-450", "F-550", "F-650", "F-Series", "Fairlane", "Fairmont", "Falcon", "Festiva","Fiesta","Fireline","Focus",
                        "Focus Electric", "Freestar", "Fusion", "Futura", "Galaxie", "Gran Torino", "Grand C-Max", "GT", "Kuga", "Mondeo", "Mustang", "Mustang GT", "Mustang Shelby",
                        "Orion",  "Probe", "Puma", "Ranger", "Raptor", "Sierra", "Taurus", "Telstar", "Tempo", "Tourneo Connect", "Transit", "Transit Connect",
                        "Transit Courier", "Windstar"});
                    break;
                case "Geely":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "BO", "CK", "CK-2", "CK1", "Emgrand 7 (EC7)", "Emgrand 8", "Emgrand FE-1", "Emgrangd X7",
                        "Emgrand X9", "FC", "FS", "GC2",
                        "GS 5", "GC 6", "GC 7", "GX 2", "HA", "HS", "JL", "Maple ", "MK", "MK Cross", "MK-2",
                        "MR", "Panda", "Safe", "SC", "SL", "SMA", "UL", "Vision"});
                    break;
                case "GMC":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "100", "Acadia", "Acadia USA", "C", "Canyon", "Delorean", "Envoy", "Jimmy",
                        "Safari", "Savana", "Sierra", "Sonoma",
                        "Suburban", "T6500", "Terrain", "Vandura", "Yukon"});
                    break;
                case "Honda":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Accord", "Acty", "Aerodeck", "Avancier", "Ballade", "Beat", "Capa", "City",
                        "Civic", "Clarity", "Converto", "CR-V",
                        "CR-Z", "Crosstour", "CRX", "Domani", "Element", "Elysion", "Eve", "F-mx ", "FIT", "Fit Aria", "FR-V",
                        "HR-V", "Insight", "Inspire", "Integra", "Jazz", "Lagreat", "Legend", "NSX", "Pilot", "S2000 ", "Saber", "Torneo", "Vamos",
                        "Vigor", "VLX"});
                    break;
                case "Hummer":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "H1", "H2", "H3", "H3X", "H4", "Hummer" });
                    break;
                case "Hyundai":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Accent", "Amica", "Atos", "Avante", "Azera", "Centennial", "Country", "Coupe",
                        "Creta", "Dynasty", "Elantra", "Excel", "Galloper", "Genesis", "Getz", "GLS", "Santa Fe", "GX", "H100", "H200", "H300", "H350", "H1",
                        "i10", "i20", "i30", "i40", "Loniq", "LX 20", "LX 35", "Kona", "Lantra", "Marcia", "Matrix", "Nexo", "Pony",
                        "S-Coupe", "Solaris", "Sonata", "Starex", "Stelar", "Terracan", "Tiburon", "Trajet", "Tucson", "Veloster", "Venue",
                        "Verna", "XG"});
                    break;
                case "Infiniti":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "EX", "EX 25", "EX 30", "EX 35", "EX 37", "FX", "FX 30", "FX 35",
                        "FX 37", "FX 45", "FX 50", "G",
                        "G20", "G25", "G35", "G37", "J 30", "JX", "M", "M25 ", "M30", "M35", "M37",
                        "M45", "Q30", "Q40", "Q45", "Q50", "Q60", "Q70", "QX", "QX30", "QX4 ", "QX50", "QX60", "QX70",
                        "QX80"});
                    break;
                case "Jaguar":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "4000", "Daimler", "DS", "DS", "E-Pace", "E-Type", "F-Type", "I-Pace",
                        "Mark", "S-Type", "SL", "Sovereign",
                        "Vanden", "X-Type", "XE", "XF", "XFR", "XJ", "XJ6", "XJ8 ", "XJL", "XJR", "XJS",
                        "XK", "XKR"});
                    break;
                case "Jeep":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Cherokee", "CJ", "Comanche", "Commander", "Compass", "Gladiator", "Grand Cherokee", "Liberty",
                        "Patriot", "Renegade", "Willys", "Wrangler"});
                    break;
                case "Kia":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Avella", "Besta", "Borrego", "Cadenza", "Capital", "Carens", "Carnival", "Carstar",
                        "Ceed", "Cerato", "Clarus", "Concord",
                        "Credos", "Forte", "Grand Sportage", "Joice", "Jumbo Titan", "K5", "Kosmos", "Koup ", "Magentis", "Mentor", "Niro",
                        "Opirus", "Optima", "Picanto", "Pregio", "Pro Ceed", "Quoris", "Ray", "Rio", "Roadster ", "Sephia", "Shuma", "Sportage",
                        "Stinger", "Visto"});
                    break;
                case "Lada":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "4x4", "Granta", "Kalina", "Largus", "Vesta", "X-Ray" });
                    break;
                case "Lamborghini":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "400 GT", "Aventador", "Diablo", "Espada", "Gallardo", "Huracan", "Jalpa", "Jarama", "Murcielago", "Reventon", "Urus" });
                    break;
                case "Land Rover":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Defender", "Discovery", "Discovery Sport", "Range Rover", "Range Rover Evoque", "Range Rover Sport", "Range Rover Velar" });
                    break;
                case "Lexus":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "CT", "CT 200H", "ES", "ES 200", "ES 250", "ES 300", "ES 330", "ES 350",
                        "GS", "GS 200", "GS 250", "GS 300",
                        "GS 350", "GS 400", "GS 430", "GS 450", "GS 460", "GS F", "GX", "GX 460", "GX 470", "HS", "IS",
                        "IS 200", "IS 220", "IS 250", "IS 300", "IS 350", "IS-C", "IS-F", "LC", "LM", "LS 400", "LS 430", "LS 460",
                        "LS 500", "LS 600", "LX", "LX 450", "LX 470", "LX 570", "NX", "NX200", "NX200T", "NX 300", "RC", "RH",
                        "RX", "RX 200", "RX 270", "RX 300", "RX 330", "RX 350", "RX 400", "RX 450", "SC 300", "SC 400", "SC 430", "UX", "UX 200",
                        "UX 250H"});
                    break;
                case "Lincoln":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Aviator", "Blackwood", "Cartier", "Continental", "Excalibur", "LS", "Mark" , "Mercury", "MKC", "MKS", "MKT", "MKX",
                        "MKZ", "Nautilus", "Navigator", "Zephyr"});
                    break;
                case "Maybach":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "52", "57", "62", "DS 8 Zeppelin", "Exelero", "S500", "S600" });
                    break;
                case "Mazda":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "121", "2", "3", "3 MPS", "323", "323F", "5", "6",
                        "626", "929", "Atenza", "Bongo",
                        "Capella", "Carol", "Clef", "Cosmos", "Cronos", "CX-3", "CX-5", "CX-7", "CX-9", "Demio",
                        "E-Series", "Eunos 500", "Familia", "Lantis", "Luce", "Millenia", "MPV", "MS-6", "MS-8", "MS-9", "MX-3", "MX-5",
                        "MX-6", "Persona", "Premacy", "Proceed", "Protege", "RX-7", "RX-8", "Sentia", "Speed", "Tribute", "Xedos", "Xedos 6",
                        "Xedox 9"});
                    break;
                case "McLaren":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "570 GT", "650 S", "675LT", "F1", "MP4", "P1" });
                    break;
                case "Mercedes-Benz":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "1628", "170", "190", "200", "206", "210", "220", "230",
                        "240", "250", "260", "280",
                        "290", "300", "308", "310", "320", "400", "420", "450", "500", "540", "560",
                        "600", "A 140", "A 150", "A 160", "A 170", "A 180", "A 190", "A 200", "A 210", "A 220", "A 250", "A45 AMG",
                        "AMG GT", "B 150", "B 160", "B 170", "B 180", "B 200", "B 220", "B 250", "C 160", "C 180", "C 200", "C 200",
                        "C230", "C 240", "C 250", "C 270", "C 280", "C 30 AMG", "C 300", "C 32 AMG", "C 320", "C 350", "C 36 AMG", "C 43 AMG", "C 55 AMG",
                        "C 63 AMG", "CL 160", "CL 180", "CL 200", "CL 220", "CL 230", "CL 320", "CL 420", "CL 500", "CL 55 AMG", "CL 550", "CL 600",
                        "CL 63 AMG", "CL 65 AMG", "CL-Class", "CLA 180", "CLA 200", "CLA 220", "CLA 250", "CLA 45 AMG", "CLC 160", "CLC 180", "CLC 200", "CLC 220", "CLC230",
                        "CLC 250" , "CLC 350", "CLK 200", "CLK 220", "CLK 230", "CLK 240", "CLK 270", "CLK 280", "CLK 320", "CLK 350", "CLK 430", "CLK 500", "CLK 55 AMG",
                        "CLK 63 AMG", "CLK - Class", "CLS 250", "CLS 280", "CLS 300", "CLS320", "CLS 250", "CLS 350", "CLS 400", "CLS 450", "CLS 500", "CLS 53 AMG",
                        "CLS 550 AMG", "CL 63 AMG", "E 200", "E 220", "E 230", "E 240", "E 250", "E 260", "E 270", "E 280", "E 290", "E 300", "E 300D",
                        "E 320" , "E 350", "E 36 AMG", "E 400", "E 420", "E 430", "E 450", "E 50", "E 500", "E 53", "E 55 AM G", "E 60 AMG",
                        "A 63 AMG", "E - Class", "E 43 AMG", "G 230", "G 240", "G 250", "G 270", "G 280", "G 290", "G 300", "G 320", "G 350",
                        "G 400", "G 500", "G 55 AMG", "G 550", "G 63 AMG", "G 65 AMG", "G-Class", "GL 320", "GL 350", "GL 400", "GL 420", "GL 450", "GL 55 AMG",
                        "GL 550", "GL 63 AMG", "GLC  Coupe", "GLC - Class", "GLK 200", "GLK 220", "GLK 250", "GLK 280", "GLK 300", "GLK 320", "GLK 350",
                        "GLS 350" , "GLS 400", "GLS 450", "GLS 500", "GLS 550", "GLS 63", "M-Class", "Maybach", "ML 230", "ML 250", "ML 270", "ML 300", "ML 400",
                        "ML 55 AMG", "ML 550", "ML 63 AMG", "S 220", "S 300", "S 350", "S 400", "S 450", "S 500", "S 55 AMG", "S 550", "S 63 AMG",
                        "S 65 AMG", "S 67", "S-Class", "SL 280", "SL 300", "SL 320", "SL 350", "SL 380", "SL 400", "SL 420", "SL 450", "SL 500", "SL 55 AMG",
                        "SL 70 AMG" , "SL 73 AMG", "SLK 200", "SLK 230", "SLK 250", "SLK 300", "SLK 350", "Sprinter", "Viano", "Vito", "X-Class"});
                    break;
                case "Volkswagen":
                    Model.Text = "";
                    Model.Items.Clear();
                    Model.Items.AddRange(new string[] { "Caddy ", "Caravel", "Crafter", "C", "T4", "T5", "T6", "Golf GTI",
                        "Tiguan", "Touareg", "Scirocco"});
                    break;
            }
        }
    }
}

