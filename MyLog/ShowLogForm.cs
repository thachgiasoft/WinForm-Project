﻿using MyLog.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLog
{
    public partial class ShowLogForm : Form
    {
        public ShowLogForm()
        {
            InitializeComponent();
        }

        private void BT_NewEvent_Click(object sender, EventArgs e)
        {
            EventControl logEvent = new EventControl();
            logEvent.Width = FLP_Events.Width - 6;
            FLP_Events.Controls.Add(logEvent);
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
