﻿using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class LoginControl : UserControl
    {

        public LoginControl()
        {
            InitializeComponent();
        }

        public string RightUsername { get; set; }

        public string RightPassword { get; set; }

        public SuccessHandler SuccessHandlerEvent { get; set; }

        public delegate void SuccessHandler();

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == RightUsername && passwordTextBox.Text == RightPassword)
            {
                SuccessHandlerEvent.Invoke();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK);
            }
        }
    }
}
