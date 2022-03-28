using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911065165_HoChiCong_BigSchool.Models
{
   
    public class Category
    {
        //sua doi lan 1
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}