﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenioM
{
    public partial class _4205_Factura : Form
    {
        public _4205_Factura()
        {
            InitializeComponent();
        }

        private void navegador1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "factura.html");
        }
    }
}
