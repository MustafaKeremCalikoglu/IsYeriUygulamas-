﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AlisFatura:IEntity
    {
        [Key]
        public int FaturaNo { get; set; }
        public DateTime AlisTarih { get; set; }
    }
}
