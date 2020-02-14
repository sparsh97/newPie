using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bethanyspieshop.Models
{

    public interface IPieRepository
    {
        IEnumerable<pie> Pies { get; }
        IEnumerable<pie> PiesOfTheWeek { get; }
        pie GetPieById(int pieId);
       
    }

       
}
