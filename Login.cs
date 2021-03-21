using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "") { passErrorLabell.Visible = true; }
            else { passErrorLabell.Visible = false; }
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Key obj = new Key();
            if (obj.CheckValidity("2MUCC5DCCP98AY8V84MM742FR", DateTime.Now))
            {
                //---User name---
                if (Usernametxt.Text == "") { UnameErrorLabel.Visible = true; }
                else { UnameErrorLabel.Visible = false; }
                //---password---
                if (Passwordtxt.Text == "") { passErrorLabell.Visible = true; }
                else { passErrorLabell.Visible = false; }

                if (UnameErrorLabel.Visible || passErrorLabell.Visible)
                {
                    MainClass.ShowMSG("Fields * are Mandatory", "Stop", "Unsuccessfully");
                }
                else
                {

                    if (retrival.getUserDetails(Usernametxt.Text, Passwordtxt.Text))
                    {
                        if (Usernametxt.Text == "Admin" || Usernametxt.Text == "admin")
                        {
                            HomeScreen hm = new HomeScreen();
                            MainClass.showWindows(hm, this, MDI.ActiveForm);
                        }
                        else 
                        {
                            HomeScreen1 hm1 = new HomeScreen1();
                            MainClass.showWindows(hm1, this, MDI.ActiveForm);
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("Software Key has been expired \nPlease Contact Software Developer", "Stop", "Unsuccessfully");
            }
        }

            private void Usernametxt_TextChanged(object sender, EventArgs e)
            {
                if (Usernametxt.Text == "") { UnameErrorLabel.Visible = true; }
                else { UnameErrorLabel.Visible = false; }
            }
    }
}
