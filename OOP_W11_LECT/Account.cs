using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W11_LECT
{
    internal class Account
    {
        List<Payable> payables = new List<Payable>();

        public void Add(Payable payable)
        {
            payables.Add(payable);
        }

        public float Total()
        {
            float total = 0;
            foreach (Payable payable in payables)
            {
                total += payable.CalcCost();
            }
            return total;
        }

    }
}
