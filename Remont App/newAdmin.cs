using AuthorizedClass;
using MailNotification;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsNotification;
namespace Remont_App
{
    public partial class newAdmin : Form
    {
        #region 
        AdminNEW adminexist = new AdminNEW();
        AdminNEW newadm = new AdminNEW();
        int logChanged = 0;
        int logCount = 0;
        int logBoxClicked = 0;
        int visCounter = 1;
        int passBoxClicked = 0;
        int passChanged = 0;
        int passboxClicked = 0;
        int passCount = 0;
        int mailChanged;
        int mailCount = 0;
        #endregion
        public newAdmin()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            BaseFORM BD = new BaseFORM();
            BD.ShowDialog();
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            adminexist.AdminExist(Login.Text, Password.Text, Email.Text, Position.Text);
            if (adminexist.counter != 0)
            {
                newadm.addAdmin(Login.Text, Password.Text, Email.Text, Position.Text);
                WinNotify.ShowWinNotify("Результат реєстрації", "Було додано нового менеджера", 10000);
                MailDeliveri.NotifyNewAdmin(Login.Text, Password.Text, Email.Text);
                Hide();
                StartScreen stscreen = new StartScreen();
                stscreen.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Цей менеджер має акаунт. Якщо він забули пароль, нехай натисне на відновити пароль в меню входу!!!");
            }
        }
        private void Login_Leave(object sender, EventArgs e)
        {
            logChanged = 0;
            if (Login.Text == "")
            {
                Login.ForeColor = Color.Black;
                logChanged++;
            }
            string loginpattern = @"^[a-zA-Z](.[a-zA-Z0-9_-]*)$";
            string value = Login.Text;
            Regex loginvalid = new Regex(loginpattern);
            if (!Regex.IsMatch(value, loginpattern, RegexOptions.Compiled) && logCount <= 3)
            {
                logBoxClicked--;
                logCount++;
                Login.Clear();
                Login.ForeColor = Color.Black;
                MessageBox.Show("Ви невірно ввели Логін!\nСпробуйте знову!", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(value, loginpattern, RegexOptions.Compiled) && logCount > 3)
            {
                logBoxClicked--;
                logCount++;
                Login.Clear();
                Login.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення логінy", "Ви вводите невірний формат для логіну.\nФормат складає: admin, ADMIN, admin111 ", 10000);
                return;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
             passChanged = 0;
            if (Password.Text == "")
            {
                Password.ForeColor = Color.Black;
                passChanged++;
            }
            string passpattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-ZА-ЯЬЄЇ])(?=.*[a-zа-яьїє]).*$";
            string value = Password.Text;
            Regex passvalid = new Regex(passpattern);
            if (!Regex.IsMatch(value, passpattern, RegexOptions.Compiled) && passCount <= 3)
            {
                passCount++;
                Password.Clear();
                Password.ForeColor = Color.Black;
                MessageBox.Show("Використовуйте комбінацію з 8 або більше літер, цифр, символів і однією або більше великою літерою", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(value, passpattern, RegexOptions.Compiled) && passCount > 3)
            {
                passCount++;
                Password.Clear();
                Password.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення паролю", "Ви вводите невірний формат паролю.\nФормат складає 8 і більш літер, цифр, символів і однієї або більше великою літерою.\nПриклад: qweRty11, Admin77, аДмін777", 10000);
                return;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
           
            if (Email.Text == "")
            {
                Email.ForeColor = Color.Black;
                mailChanged++;
            }
            string mailspattern = @"^[A-Za-z]+[\.A-Za-z\d_-]*[A-Za-z\d]+@[A-Za-z]+\.[A-Za-z]{2,6}";
            string value = Email.Text;
            Regex mailvalid = new Regex(mailspattern);
            if (!Regex.IsMatch(value, mailspattern, RegexOptions.Compiled) && mailCount <= 3)
            {

                mailCount++;
                Email.Clear();
                Email.ForeColor = Color.Black;
                MessageBox.Show("Використовуйте комбінацію з 8 або більше літер, цифр, символів і однією або більше великою літерою", "Помилка аутентифікації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(value, mailspattern, RegexOptions.Compiled) && mailCount > 3)
            {
                logCount++;
                Email.Clear();
                Email.ForeColor = Color.Black;
                WinNotify.ShowWinNotify("Помилка введення паролю", "Ви вводите невірний формат паролю.\nФормат складає 8 і більш літер, цифр, символів і однієї або більше великою літерою.\nПриклад: qweRty11, Admin77, аДмін777", 10000);
                return;
            }
        }

        private void Position_Leave(object sender, EventArgs e)
        {

        }

        private void PinVisible_Click(object sender, EventArgs e)
        {
            if (visCounter % 2 == 1)
            {
                PinVisible.Load(@"E:\COURSE WORK\Course Work\Pics\openedEye.png");
                Password.UseSystemPasswordChar = true;
                visCounter++;
            }

            else if (visCounter % 2 == 0)
            {
                PinVisible.Load(@"E:\COURSE WORK\Course Work\Pics\closedEye.png");
                Password.UseSystemPasswordChar = true;
                visCounter--;
            }
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != null && passBoxClicked == 0)
            {
                Password.Clear();
                Password.UseSystemPasswordChar = true;
                Password.ForeColor = Color.Black;
                passBoxClicked++;
            }

            else if (Password.Text != null && passChanged != 0)
            {
                Password.Clear();
                Password.UseSystemPasswordChar = true;
                Password.ForeColor = Color.Black;
            }
        }
    }
}
