﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form2 : Form
    {
        // Form2 f2;
        Form3 f3;
        public Form2()
        {
            InitializeComponent();
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //f2 = new Form2();
            //f2.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.Owner = this.Owner;
                f3.Show();
            }
            

        }
    }
}