using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace vendinha.Desktop.Components
{
    public partial class LabelTitulo : Label
    {
        public LabelTitulo()
        {
            Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);


            InitializeComponent();
        }
    }
}
