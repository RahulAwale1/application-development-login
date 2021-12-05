using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, password, confirmPassword;
            email = txtEmail.Text;
            password = txtPassword.Text;
            confirmPassword = txtConfirmPassword.Text;

            String admin = ("admin@admin.com");
            String adminPassword = ("admin");

            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(email);


            if (match.Success)
            {
                if (password == confirmPassword)
                {
                    if (email == admin && password == adminPassword)
                    {
                        MessageBox.Show("You are successfully logged in !!!");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect login credentials !!!");
                    }
                }
                else {
                    MessageBox.Show("Password doesnot match with confirm password !!!");
                }
            }
            else {
                MessageBox.Show("Invalid Email !!!");
            }
        }
    }
}

