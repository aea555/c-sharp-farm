using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.ProductsStore;
using WindowsFormsApp1.Classes.Store;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Cattle cattle = new Cattle();
        SmallCattle smallCattle = new SmallCattle();
        Poultry poultry = new Poultry();
        AnimalStore animalStore = new AnimalStore();
        ProductStore productStore = new ProductStore();
        int cash = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poultry_production.Start();
            smallcattle_production.Start();
            cattle_production.Start();
            Poultry_health.Start();
            smallcattle_health.Start();
            cattle_health.Start();
            cashReserve.Text = "0";
            poultry_amount.Text = "1";
            cattle_amount.Text = "1";
            smallcattle_amount.Text = "1";
            poultry_health_level.Maximum = Poultry.Lifespan;
            smallcattle_health_level.Maximum = SmallCattle.Lifespan;
            cattle_health_level.Maximum = Cattle.Lifespan;
            poultry_health_level.Value = Poultry.Lifespan;
            smallcattle_health_level.Value = SmallCattle.Lifespan;
            cattle_health_level.Value = Cattle.Lifespan;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void poultry_production_Tick_1(object sender, EventArgs e)
        {
            if (poultry.isAlive)
            {
                if (poultry_progress.Value == 100)
                {
                    poultry.Produce(poultry_progress, poultry_production, productStore, poultry.AnimalType);
                    poultry_products_amount.Text = productStore.PoultryProducts.ToString();

                }
                poultry_progress.Value += 50;
            }
            else
            {
                poultry_progress.Value = 0;
                poultry_production.Stop();
            }
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {

        }

        private void smallcattle_production_Tick(object sender, EventArgs e)
        {
            if (smallCattle.isAlive)
            {
                if (smallcattle_progress.Value == 100)
                {
                    smallCattle.Produce(smallcattle_progress, smallcattle_production, productStore, smallCattle.AnimalType);
                    small_cattle_products_amount.Text = productStore.SmallCattleProducts.ToString();

                }
                smallcattle_progress.Value += 25;
            }
            else
            {
                smallcattle_progress.Value = 0;
                smallcattle_production.Stop();
            }

        }

        private void cattle_production_Tick(object sender, EventArgs e)
        {
            if (cattle.isAlive)
            {
                if (cattle_progress.Value == 100)
                {
                    cattle.Produce(cattle_progress, cattle_production, productStore, cattle.AnimalType);
                    cattle_products_amount.Text = productStore.CattleProducts.ToString();

                }
                cattle_progress.Value += 10;
            } else
            {
                cattle_progress.Value = 0;
                cattle_production.Stop();
            }
            
        }

        private void smallcattle_sell_Click(object sender, EventArgs e)
        {
            if (productStore.SmallCattleProducts > 0)
            {
                int saleAmount = productStore.SmallCattleProducts * 250;
                cash+=saleAmount;
                cashReserve.Text = cash.ToString();
                productStore.SmallCattleProducts = 0;
                small_cattle_products_amount.Text = "0";
            }        
        }

        private void cattle_sell_Click(object sender, EventArgs e)
        {
            if (productStore.CattleProducts > 0)
            {
                int saleAmount = productStore.CattleProducts * 1000;
                cash += saleAmount;
                cashReserve.Text = cash.ToString();
                productStore.CattleProducts = 0;
                cattle_products_amount.Text = "0";
            }
        }

        private void poultry_sell_Click(object sender, EventArgs e)
        {
            if (productStore.PoultryProducts > 0)
            {
                int saleAmount = productStore.PoultryProducts * 100;
                cash += saleAmount;
                cashReserve.Text = cash.ToString();
                productStore.PoultryProducts = 0;
                poultry_products_amount.Text = "0";
            }
        }

        private void buy_poultry_Click(object sender, EventArgs e)
        {
            if (cash >= 1000)
            {
                cash -= 1000;
                cashReserve.Text = cash.ToString();
                animalStore.PoultryStock++;
                poultry_amount.Text = animalStore.PoultryStock.ToString();
            }
            
        }

        private void buy_smallcattle_Click(object sender, EventArgs e)
        {
            if (cash >= 2500)
            {
                cash -= 2500;
                cashReserve.Text = cash.ToString();

                animalStore.SmallCattleStock++;
                smallcattle_amount.Text = animalStore.SmallCattleStock.ToString();
            }
            
        }

        private void buy_cattle_Click(object sender, EventArgs e)
        {
            if (cash >= 7500)
            {
                cash -= 7500;
                cashReserve.Text = cash.ToString();

                animalStore.CattleStock++;
                cattle_amount.Text = animalStore.CattleStock.ToString();
            }
            
        }

        private void poultry_health_Tick(object sender, EventArgs e)
        {
            poultry.SetHealth(poultry_health_level, Poultry_health);
        }

        private void small_cattle_health_Tick(object sender, EventArgs e)
        {
            smallCattle.SetHealth(smallcattle_health_level, smallcattle_health);
        }

        private void cattle_health_Tick(object sender, EventArgs e)
        {
            cattle.SetHealth(cattle_health_level, cattle_health);
        }

        private void addElement_button_Click(object sender, EventArgs e)
        {

        }
    }
}
