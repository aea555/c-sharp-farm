using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes.Store;
using WindowsFormsApp1.Classes.ProductsStore;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.Classes
{
    internal class Animal : IAnimal
    {
        public double age = 0;
        public bool isAlive = true;
        public string gender;
        public enum Gender
        {
            Male,
            Female
        }
        public enum Type
        {
            Cattle,
            SmallCattle,
            Poultry
        }
        public Animal()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(2);
            switch (rndNumber)
            {
                case 0:
                    gender = Gender.Male.ToString();
                    break;
                case 1:
                    gender = Gender.Female.ToString();
                    break;
                default:
                    break;
            }
        }
        public void Produce(ProgressBar prodProgress, Timer timer, ProductStore ps, string type)
        {
            timer.Stop();
            prodProgress.Value = 0;
            switch (type)
            {
                case "Cattle":
                    ps.CattleProducts++;
                    break;
                case "SmallCattle":
                    ps.SmallCattleProducts++;
                    break;
                case "Poultry":
                    ps.PoultryProducts++;
                    break;
            }
            timer.Start();
        }
        public void Kill()
        {
            this.isAlive = false;
        }
        public void SetHealth(ProgressBar pb, Timer t)
        {
            if (pb.Value == 0)
            {
                t.Stop();
                Kill();
            } else
            {
                pb.Value -= 1000;
                age += 0.2;
            }
        }
    }
}
