using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.HopThoai
{
    public class Hopthoai
    {
        public DialogResult XacNhan(Form parent, string tieude, string noidung)
        {
            Guna.UI2.WinForms.Guna2MessageDialog messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog
            {
                Parent = (Form)parent.TopLevelControl,
                Caption = tieude,
                Text = noidung,
                Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo,
                Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
            };
            return messageDialog.Show();
        }
        public void ThongBao(Form parent, string tieude, string noidung, Guna.UI2.WinForms.MessageDialogIcon icon)
        {
            Guna.UI2.WinForms.Guna2MessageDialog messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog
            {
                Parent = (Form)parent.TopLevelControl,
                Caption = tieude,
                Text = noidung,
                Icon = icon,
                Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            };
            messageDialog.Show();
        }

        // phủ overlay 
        public void BlurBackground(Form model)
        {
            Form Background = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.6d, // Độ mờ của form nền
                BackColor = Color.Black,
                Size = Screen.PrimaryScreen.Bounds.Size,
                Location = Screen.PrimaryScreen.Bounds.Location,
                ShowInTaskbar = false,
                TopMost = true
            };

            Background.Show();
            model.Owner = Background;
            model.ShowDialog(Background);
            Background.Dispose();
        }

    }
}
