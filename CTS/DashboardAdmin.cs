using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS
{
    public partial class UI_Admin : Form
    {
        static UI_Admin _obj;
        #region Create click down move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region Create bound block
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion
        public UI_Admin()
        {
            InitializeComponent();
            //this.btnLogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogout.Width, btnLogout.Height, 15, 15));
        }
        #region Instance
        public static UI_Admin Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UI_Admin();
                }
                return _obj;
            }
        }
        public Panel ContainerMain
        {
            get { return panel_main; }
            set { panel_main = value; }
        }
        #endregion

        private void btnMininize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UI_Admin_Load(object sender, EventArgs e)
        {
            _obj = this;
            choose_Statisic.Visible = true;
            UIControl.frmStatistical frmStatistical = new UIControl.frmStatistical();
            frmStatistical.Dock = DockStyle.Fill;
            ContainerMain.Controls.Add(frmStatistical);
            panel_alert.AutoScroll = true;
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #region Status select button
        public void select()
        {
            choose_mission.Visible = false;
            choose_Statisic.Visible = false;
            chosse_account.Visible = false;
        }
        #endregion

        private void btnMission_Click(object sender, EventArgs e)
        {
            select();
            choose_mission.Visible = true;
            if (!UI_Admin.Instance.ContainerMain.Controls.ContainsKey("frmMission"))
            {
                UIControl.frmMission uc = new UIControl.frmMission();
                uc.Dock = DockStyle.Fill;
                UI_Admin.Instance.ContainerMain.Controls.Add(uc);
            }
            UI_Admin.Instance.ContainerMain.Controls["frmMission"].BringToFront();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            select();
            choose_Statisic.Visible = true;
            UI_Admin.Instance.ContainerMain.Controls["frmStatistical"].BringToFront();
            UIControl.ui_alert ui_Alert = new UIControl.ui_alert();
            ui_Alert.Dock = DockStyle.Top;
            panel_alert.Controls.Add(ui_Alert);
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            UI_Admin.Instance.ContainerMain.Controls["panel_alert"].BringToFront();
            panel_alert.Visible = !panel_alert.Visible;
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            select();
            chosse_account.Visible = true;
            if (!UI_Admin.Instance.ContainerMain.Controls.ContainsKey("frmAccount"))
            {
                UIControl.frmAccount uc = new UIControl.frmAccount();
                uc.Dock = DockStyle.Fill;
                UI_Admin.Instance.ContainerMain.Controls.Add(uc);
            }
            UI_Admin.Instance.ContainerMain.Controls["frmAccount"].BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
