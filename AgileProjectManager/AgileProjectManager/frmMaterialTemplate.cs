﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace AgileProjectManager
{
    public partial class frmMaterialTemplate : MaterialSkin.Controls.MaterialForm
    {
        public frmMaterialTemplate()
        {
            InitializeComponent();

            //create a new instance of the theme manager to save the colour scheme and other settings
            //changing colours in the native property tab in the designer will CORRUPT THE FORM.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
    }
}
