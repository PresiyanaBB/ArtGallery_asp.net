﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Core.Models
{
    public class CartPaintingViewModel : PaintingViewModel
    {
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
    }
}
