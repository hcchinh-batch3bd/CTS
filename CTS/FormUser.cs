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
    public partial class FormUser : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;


        

        public FormUser()
        {
            InitializeComponent();
            random = new Random();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.Region = Region.FromHrgn(Setting.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void FormUser_Load(object sender, EventArgs e)
        {   
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender) {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
            
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
