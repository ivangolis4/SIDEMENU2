namespace OwnApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            PANELCATEGORIES.Visible = false;
            PANELORDER.Visible = false;
            PANELSALES.Visible = false;
        }

        private void hidesidemenu()
        {
            if (PANELCATEGORIES.Visible == true)
            {
                PANELCATEGORIES.Visible = false;
            }
            if (PANELORDER.Visible == true)
            {
                PANELORDER.Visible = false;
            }
            if (PANELSALES.Visible == true)
            {
                PANELSALES.Visible = false;
            }
        }

        private void showsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesidemenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void PANELCATEGORIES_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNDASHBOAD_MouseEnter(object sender, EventArgs e)
        {
            BTNDASHBOAD.BackColor = Color.Azure;
        }

        private void BTNDASHBOAD_MouseLeave(object sender, EventArgs e)
        {
            BTNDASHBOAD.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void BTNCATEGORIES_MouseEnter(object sender, EventArgs e)
        {
            BTNCATEGORIES.BackColor = Color.Azure;
        }

        private void BTNCATEGORIES_MouseLeave(object sender, EventArgs e)
        {
            BTNCATEGORIES.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void BTNORDER_MouseEnter(object sender, EventArgs e)
        {
            BTNORDER.BackColor = Color.Azure;
        }

        private void BTNORDER_MouseLeave(object sender, EventArgs e)
        {
            BTNORDER.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void BTNSALES_MouseEnter(object sender, EventArgs e)
        {
            BTNSALES.BackColor = Color.Azure;
        }

        private void BTNSALES_MouseLeave(object sender, EventArgs e)
        {
            BTNSALES.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void BTNLOGOUT_MouseEnter(object sender, EventArgs e)
        {
            BTNLOGOUT.BackColor = Color.Azure;
        }

        private void BTNLOGOUT_MouseLeave(object sender, EventArgs e)
        {
            BTNLOGOUT.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void BTNCATEGORIES_Click(object sender, EventArgs e)
        {
            showsubmenu(PANELCATEGORIES);
        }

        private void BTNDASHBOAD_Click(object sender, EventArgs e)
        {
            hidesidemenu();
        }

        private void BTNORDER_Click(object sender, EventArgs e)
        {
            showsubmenu(PANELORDER);
        }

        private void BTNSALES_Click(object sender, EventArgs e)
        {
            showsubmenu(PANELSALES);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
