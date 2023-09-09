using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.ProductsStore;
using WindowsFormsApp1.Classes.Store;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Cattle cattle = new Cattle();
        SmallCattle smallCattle = new SmallCattle();
        Poultry poultry = new Poultry();
        AnimalStore animalStore = new AnimalStore();
        ProductStore productStore = new ProductStore();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            //--------------------------------------------
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
                    poultry.Produce(poultry_progress, poultry_production, productStore, Poultry.AnimalType);
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
                    smallCattle.Produce(smallcattle_progress, smallcattle_production, productStore, SmallCattle.AnimalType);
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
                    cattle.Produce(cattle_progress, cattle_production, productStore, Cattle.AnimalType);
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
                int saleAmount = productStore.SmallCattleProducts * 600;
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
                int saleAmount = productStore.CattleProducts * 2000;
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
                int saleAmount = productStore.PoultryProducts * 250;
                cash += saleAmount;
                cashReserve.Text = cash.ToString();
                productStore.PoultryProducts = 0;
                poultry_products_amount.Text = "0";
            }
        }

        private void buy_poultry_Click(object sender, EventArgs e)
        {
            if (cash >= 500)
            {
                cash -= 500;
                cashReserve.Text = cash.ToString();
                animalStore.PoultryStock++;
                poultry_amount.Text = animalStore.PoultryStock.ToString();

                Poultry poultry1 = new Poultry();

                PictureBox picture = new PictureBox()
                {
                    Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image"))),
                    Size = new System.Drawing.Size(90, 90),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabIndex = 15,
                };

                Label healthLabel = new Label()
                {
                    Text = "Health Level",
                    TabIndex = 10,
                };

                Label productionLabel = new Label()
                {
                    Text = "Production Progress"
                };

                ProgressBar healthbar = new ProgressBar()
                {
                    Maximum = Poultry.Lifespan,
                    TabIndex = 10,
                    Value = Poultry.Lifespan,
                };

                ProgressBar productionBar = new ProgressBar()
                {
                    Maximum = 100,
                    TabIndex = 10,
                    Value = 0,
                };

                System.Windows.Forms.Timer healthTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                System.Windows.Forms.Timer productionTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                void onHealthTick(Object myObject, EventArgs myEventArgs)
                {
                    if (healthbar.Value == 0)
                    {
                        poultry_flow.Controls.Remove(picture);
                        picture.Dispose();
                        poultry_flow.Controls.Remove(healthLabel);
                        healthLabel.Dispose();
                        poultry_flow.Controls.Remove(healthbar);
                        healthbar.Dispose();
                        poultry_flow.Controls.Remove(productionLabel);
                        productionLabel.Dispose();
                        poultry_flow.Controls.Remove(productionBar);
                        productionBar.Dispose();

                        animalStore.PoultryStock--;
                        poultry_amount.Text = animalStore.PoultryStock.ToString();
                    }
                    poultry1.SetHealth(healthbar, healthTimer);
                    
                }

                void onProductionTick(Object myObject, EventArgs myEventArgs)
                {
                    if (poultry1.isAlive)
                    {
                        if (productionBar.Value == 100)
                        {
                            poultry1.Produce(productionBar, productionTimer, productStore, Poultry.AnimalType);
                            poultry_products_amount.Text = productStore.PoultryProducts.ToString();

                        }
                        productionBar.Value += 50;
                    }
                    else
                    {
                        productionBar.Value = 0;
                        productionTimer.Stop();
                    }
                }

                healthTimer.Tick += new EventHandler(onHealthTick);
                productionTimer.Tick += new EventHandler(onProductionTick);

                poultry_flow.Controls.Add(picture);
                poultry_flow.Controls.Add(healthLabel);
                poultry_flow.Controls.Add(healthbar);
                poultry_flow.Controls.Add(productionLabel);
                poultry_flow.Controls.Add(productionBar);

                healthTimer.Start();
                productionTimer.Start();
            }
            
        }

        private void buy_smallcattle_Click(object sender, EventArgs e)
        {
            if (cash >= 1500)
            {
                cash -= 1500;
                cashReserve.Text = cash.ToString();

                animalStore.SmallCattleStock++;
                smallcattle_amount.Text = animalStore.SmallCattleStock.ToString();

                SmallCattle smallcattle1 = new SmallCattle();

                PictureBox picture = new PictureBox()
                {
                    Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image"))),
                    Size = new System.Drawing.Size(90, 90),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabIndex = 15,
                };

                Label healthLabel = new Label()
                {
                    Text = "Health Level",
                    TabIndex = 10,
                };

                Label productionLabel = new Label()
                {
                    Text = "Production Progress"
                };

                ProgressBar healthbar = new ProgressBar()
                {
                    Maximum = SmallCattle.Lifespan,
                    TabIndex = 10,
                    Value = SmallCattle.Lifespan,
                };

                ProgressBar productionBar = new ProgressBar()
                {
                    Maximum = 100,
                    TabIndex = 10,
                    Value = 0,
                };

                System.Windows.Forms.Timer healthTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                System.Windows.Forms.Timer productionTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                void onHealthTick(Object myObject, EventArgs myEventArgs)
                {
                    if (healthbar.Value == 0)
                    {
                        smallcattle_flow.Controls.Remove(picture);
                        picture.Dispose();
                        smallcattle_flow.Controls.Remove(healthLabel);
                        healthLabel.Dispose();
                        smallcattle_flow.Controls.Remove(healthbar);
                        healthbar.Dispose();
                        smallcattle_flow.Controls.Remove(productionLabel);
                        productionLabel.Dispose();
                        smallcattle_flow.Controls.Remove(productionBar);
                        productionBar.Dispose();

                        animalStore.SmallCattleStock--;
                        smallcattle_amount.Text = animalStore.SmallCattleStock.ToString();
                    }
                    smallcattle1.SetHealth(healthbar, healthTimer);

                }

                void onProductionTick(Object myObject, EventArgs myEventArgs)
                {
                    if (smallcattle1.isAlive)
                    {
                        if (productionBar.Value == 100)
                        {
                            smallcattle1.Produce(productionBar, productionTimer, productStore, SmallCattle.AnimalType);
                            small_cattle_products_amount.Text = productStore.SmallCattleProducts.ToString();

                        }
                        productionBar.Value += 25;
                    }
                    else
                    {
                        productionBar.Value = 0;
                        productionTimer.Stop();
                    }
                }

                healthTimer.Tick += new EventHandler(onHealthTick);
                productionTimer.Tick += new EventHandler(onProductionTick);

                smallcattle_flow.Controls.Add(picture);
                smallcattle_flow.Controls.Add(healthLabel);
                smallcattle_flow.Controls.Add(healthbar);
                smallcattle_flow.Controls.Add(productionLabel);
                smallcattle_flow.Controls.Add(productionBar);

                healthTimer.Start();
                productionTimer.Start();
            }
            
        }

        private void buy_cattle_Click(object sender, EventArgs e)
        {
            if (cash >= 4500)
            {
                cash -= 5500;
                cashReserve.Text = cash.ToString();

                animalStore.CattleStock++;
                cattle_amount.Text = animalStore.CattleStock.ToString();

                Cattle cattle1 = new Cattle();

                PictureBox picture = new PictureBox()
                {
                    Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image"))),
                    Size = new System.Drawing.Size(90, 90),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabIndex = 15,
                };

                Label healthLabel = new Label()
                {
                    Text = "Health Level",
                    TabIndex = 10,
                };

                Label productionLabel = new Label()
                {
                    Text = "Production Progress"
                };

                ProgressBar healthbar = new ProgressBar()
                {
                    Maximum = Cattle.Lifespan,
                    TabIndex = 10,
                    Value = Cattle.Lifespan,
                };

                ProgressBar productionBar = new ProgressBar()
                {
                    Maximum = 100,
                    TabIndex = 10,
                    Value = 0,
                };

                System.Windows.Forms.Timer healthTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                System.Windows.Forms.Timer productionTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 1000,
                };

                void onHealthTick(Object myObject, EventArgs myEventArgs)
                {
                    if (healthbar.Value == 0)
                    {
                        cattle_flow.Controls.Remove(picture);
                        picture.Dispose();
                        cattle_flow.Controls.Remove(healthLabel);
                        healthLabel.Dispose();
                        cattle_flow.Controls.Remove(healthbar);
                        healthbar.Dispose();
                        cattle_flow.Controls.Remove(productionLabel);
                        productionLabel.Dispose();
                        cattle_flow.Controls.Remove(productionBar);
                        productionBar.Dispose();

                        animalStore.CattleStock--;
                        cattle_amount.Text = animalStore.CattleStock.ToString();
                    }
                    cattle1.SetHealth(healthbar, healthTimer);

                }

                void onProductionTick(Object myObject, EventArgs myEventArgs)
                {
                    if (cattle1.isAlive)
                    {
                        if (productionBar.Value == 100)
                        {
                            cattle1.Produce(productionBar, productionTimer, productStore, Cattle.AnimalType);
                            cattle_products_amount.Text = productStore.CattleProducts.ToString();

                        }
                        productionBar.Value += 25;
                    }
                    else
                    {
                        productionBar.Value = 0;
                        productionTimer.Stop();
                    }
                }

                healthTimer.Tick += new EventHandler(onHealthTick);
                productionTimer.Tick += new EventHandler(onProductionTick);

                cattle_flow.Controls.Add(picture);
                cattle_flow.Controls.Add(healthLabel);
                cattle_flow.Controls.Add(healthbar);
                cattle_flow.Controls.Add(productionLabel);
                cattle_flow.Controls.Add(productionBar);

                healthTimer.Start();
                productionTimer.Start();
            }
            
        }

        private void poultry_health_Tick(object sender, EventArgs e)
        {
            if (poultry_health_level.Value == 0)
            {
                poultry_flow.Controls.Remove(pictureBox1);
                pictureBox1.Dispose();
                poultry_flow.Controls.Remove(label12);
                label12.Dispose();
                poultry_flow.Controls.Remove(poultry_health_level);
                poultry_health_level.Dispose();
                poultry_flow.Controls.Remove(label9);
                label9.Dispose();
                poultry_flow.Controls.Remove(poultry_progress);
                poultry_progress.Dispose();

                animalStore.PoultryStock--;
                poultry_amount.Text = animalStore.PoultryStock.ToString();
            }
            poultry.SetHealth(poultry_health_level, Poultry_health);
        }

        private void small_cattle_health_Tick(object sender, EventArgs e)
        {
            if (smallcattle_health_level.Value == 0)
            {
                smallcattle_flow.Controls.Remove(pictureBox3);
                pictureBox3.Dispose();
                smallcattle_flow.Controls.Remove(label13);
                label13.Dispose();
                smallcattle_flow.Controls.Remove(smallcattle_health_level);
                smallcattle_health_level.Dispose();
                smallcattle_flow.Controls.Remove(label10);
                label10.Dispose();
                smallcattle_flow.Controls.Remove(smallcattle_progress);
                smallcattle_progress.Dispose();

                animalStore.SmallCattleStock--;
                smallcattle_amount.Text = animalStore.SmallCattleStock.ToString();
            }
            smallCattle.SetHealth(smallcattle_health_level, smallcattle_health);
        }

        private void cattle_health_Tick(object sender, EventArgs e)
        {
            if (cattle_health_level.Value == 0)
            {
                cattle_flow.Controls.Remove(pictureBox2);
                pictureBox2.Dispose();
                cattle_flow.Controls.Remove(label14);
                label14.Dispose();
                cattle_flow.Controls.Remove(cattle_health_level);
                cattle_health_level.Dispose();
                cattle_flow.Controls.Remove(label11);
                label11.Dispose();
                cattle_flow.Controls.Remove(cattle_progress);
                cattle_progress.Dispose();

                animalStore.CattleStock--;
                cattle_amount.Text = animalStore.CattleStock.ToString();
            }
            cattle.SetHealth(cattle_health_level, cattle_health);
        }

    }
}
