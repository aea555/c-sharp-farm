using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.Classes
{
    internal class Product : IProduct
    {
        public enum ProductType
        {
            CattleProduct,
            SmallCattleProduct,
            PoultryProduct
        }

        public int Price;

        public void Sell()
        {

        }
    }
}
