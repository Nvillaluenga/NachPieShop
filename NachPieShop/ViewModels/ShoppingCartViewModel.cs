﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NachPieShop.Models;

namespace NachPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
