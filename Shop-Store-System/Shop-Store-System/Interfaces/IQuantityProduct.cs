﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface IQuantityProduct
    {
        decimal GetProductQty(int productID);

        bool UpdateQuantity(int productID, decimal quantity);

        bool IncreaseProduct(int productID, decimal increaseQty);

        bool DecreaseProduct(int productID, decimal decreaseQty);
    }
}
