using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes.ProductsStore;

namespace WindowsFormsApp1.Interfaces
{
    internal interface IAnimal
    {
        void Produce(ProgressBar pb, Timer t, ProductStore ps, string type);
        void Kill();
        int SetHealth(ProgressBar pb, Timer t);
    }
}
