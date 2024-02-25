using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Website
{
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "Sahil";
            string password = "Sahil456";

            if(txtUserName.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Login Authication Sucessful", "Tech Spectrum 🖐", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmHomePage homepage = new frmHomePage();
                homepage.ShowDialog();
            }
            else if(txtUserName.Text != username && txtPassword.Text != password)
            {
                MessageBox.Show("UserName and Password is incorrect"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtUserName.Text != username)
            {
                MessageBox.Show("UserName is incorrect"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password is incorrect"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
