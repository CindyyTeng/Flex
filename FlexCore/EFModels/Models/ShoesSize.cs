﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class ShoesSize
    {
        public ShoesSize()
        {
            ShoesGroups = new HashSet<ShoesGroup>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<ShoesGroup> ShoesGroups { get; set; }
    }
}