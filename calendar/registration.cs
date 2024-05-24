using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();

            userFeld.Text = "Введите имя";
            userFeld.ForeColor = Color.Green;

            emailForm.Text = "Введите почту";
            emailForm.ForeColor = Color.Green;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void Clik_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void обои_authorization_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userFeld_Enter(object sender, EventArgs e)
        {
            if(userFeld.Text== "Введите имя" ) { userFeld.Text = "";
                userFeld.ForeColor = Color.White;
            }
            
        } 
        private void userFeld_Leave(object sender, EventArgs e)
        {
            if (userFeld.Text == "")
            {
                userFeld.Text = "Введите имя";
                userFeld.ForeColor = Color.Green;
            }
        }

        private void emailForm_Enter(object sender, EventArgs e)
        {
            if (emailForm.Text == "Введите почту")
            {
                emailForm.Text = "";
                emailForm.ForeColor = Color.White;
            }
        }

        private void emailForm_Leave(object sender, EventArgs e)
        {
            if (emailForm.Text == "")
            {
                emailForm.Text = "Введите почту";
                emailForm.ForeColor = Color.Green;
            }
        }
    }
}
