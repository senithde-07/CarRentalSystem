﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    class UC_Main_Conrol
    {
        public static void showControl(Control control, Control Content)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}