using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace vendinha.Desktop.Components
{
    public partial class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            BackColor = Color.Orange;
            Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Size = new Size(220, 60);
            ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            InitializeComponent();
        }
    }
}
