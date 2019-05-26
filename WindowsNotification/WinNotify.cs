using System.Drawing;
using System.Windows.Forms;
namespace WindowsNotification
{
    public class WinNotify
    {   /*Іконка в панелі сповіщення*/
        static private readonly string iconLocation = @"E:\COURSE WORK\Course Work\Pics\test lo.ico";
        public static void ShowWinNotify(string Title, string Text, int Duration)
        {
            Icon icon = new Icon(iconLocation);
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = icon;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = Title;
            notifyIcon.BalloonTipText = Text;
            notifyIcon.ShowBalloonTip(Duration);
        }
    }
}
