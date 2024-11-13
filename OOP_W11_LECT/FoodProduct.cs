using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W11_LECT
{
    internal class FoodProduct : Payable
    {
        public float UnitAmount { get; set; }
        public float UnitPrice { get; set; }

        public float CalcCost()
        {
            return UnitPrice*UnitAmount;
        }
    }
}
