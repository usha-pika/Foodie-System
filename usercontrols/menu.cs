using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieSystem.usercontrols
{
    public partial class menu : UserControl
    {
        private OurMenu ourMenu;
        private orderpage orderPage;
        private Home homePage;
        public menu()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }

        private void order_Click(object sender, EventArgs e)
        {
            orderPage = new orderpage();
            addUserControl(orderPage);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Mennu_Click(object sender, EventArgs e)
        {
            ourMenu = new OurMenu();
            addUserControl(ourMenu);
        }

        private void aboutus_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            homePage = new Home();
            addUserControl(homePage);
        }
    }
}
