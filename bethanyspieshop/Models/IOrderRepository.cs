﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bethanyspieshop.Models;

namespace bethanyspieshop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
     
    }
}
