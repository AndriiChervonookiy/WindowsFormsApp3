﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button = new Button();
            button.Click += Button_Click;
            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
