using _1911065165_HoChiCong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911065165_HoChiCong_BigSchool.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}