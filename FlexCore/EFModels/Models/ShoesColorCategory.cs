﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class ShoesColorCategory
    {
        public ShoesColorCategory()
        {
            CustomizedShoesPos = new HashSet<CustomizedShoesPo>();
            ShoesGroups = new HashSet<ShoesGroup>();
        }

        public int ShoesColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<CustomizedShoesPo> CustomizedShoesPos { get; set; }
        public virtual ICollection<ShoesGroup> ShoesGroups { get; set; }
    }
}