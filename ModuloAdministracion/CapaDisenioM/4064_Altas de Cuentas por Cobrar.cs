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
    public partial class _4064_Altas_de_Cuentas_por_Cobrar : Form
    {
        public _4064_Altas_de_Cuentas_por_Cobrar()
        {
            InitializeComponent();
        }

        private void navegador1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/ayuda/ModuloAdmon.chm", "AltasCxC.html");
        }
    }
}
