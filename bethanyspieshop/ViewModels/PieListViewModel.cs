using bethanyspieshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bethanyspieshop.ViewModels
{
    public class PieListViewModel
    {
        public pie pie = new pie();
        public IEnumerable<pie> Pies { get; set; }
        public string CurrentCategory { get; set; }

    }
}
