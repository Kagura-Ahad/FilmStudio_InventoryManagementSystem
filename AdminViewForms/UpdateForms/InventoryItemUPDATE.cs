﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmStudio_InventoryManagementSystem.AdminViewForms.UpdateForms
{
    public partial class InventoryItemUPDATE : Form
    {
        public InventoryItemUPDATE(string Name, string Description, string CategoryName, int QuantityinStock, int TotalQuantity)
        {
            InitializeComponent();

        }
    }
}
