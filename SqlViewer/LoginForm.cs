﻿using SqlViewer.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(
                        TbServer.Text.Trim(),
                        TbUserName.Text.Trim(),
                        TbPassword.Text.Trim());
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                LbError.Text = ex.Message;
            }
        }
    }
}
