using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bethanyspieshop.Models;

namespace bethanyspieshop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<pie> PiesOfTheWeek { get; set; }
    }
}
