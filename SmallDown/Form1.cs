using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace SmallDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_3hour_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 10800");
        }

        private void btn_2hour_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 7200");
        }

        private void btn_1hour_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 3600");
        }

        private void btn_30min_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 1800");
        }

        private void btn_own_set_Click(object sender, EventArgs e)
        {
            decimal time = 60 * num_minute.Value * num_hour.Value;

            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t "  + time);
        }
    }
}
