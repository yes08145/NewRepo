﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Register 존재해야 하는가
namespace LoginWinfrom1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
