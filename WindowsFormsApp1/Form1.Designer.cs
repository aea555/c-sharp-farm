namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cattle_products_amount = new System.Windows.Forms.TextBox();
            this.small_cattle_products_amount = new System.Windows.Forms.TextBox();
            this.poultry_products_amount = new System.Windows.Forms.TextBox();
            this.cashReserve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sell_cattle = new System.Windows.Forms.Button();
            this.smallcattle_sell = new System.Windows.Forms.Button();
            this.poultry_sell = new System.Windows.Forms.Button();
            this.buy_poultry = new System.Windows.Forms.Button();
            this.buy_smallcattle = new System.Windows.Forms.Button();
            this.buy_cattle = new System.Windows.Forms.Button();
            this.poultry_amount = new System.Windows.Forms.TextBox();
            this.smallcattle_amount = new System.Windows.Forms.TextBox();
            this.cattle_amount = new System.Windows.Forms.TextBox();
            this.poultry_production = new System.Windows.Forms.Timer(this.components);
            this.smallcattle_production = new System.Windows.Forms.Timer(this.components);
            this.cattle_production = new System.Windows.Forms.Timer(this.components);
            this.Poultry_health = new System.Windows.Forms.Timer(this.components);
            this.smallcattle_health = new System.Windows.Forms.Timer(this.components);
            this.cattle_health = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cattle_health_level = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.cattle_progress = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.smallcattle_health_level = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.smallcattle_progress = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.poultry_health_level = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.poultry_progress = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.poultry_page = new System.Windows.Forms.TabPage();
            this.smallcattle_page = new System.Windows.Forms.TabPage();
            this.cattle_page = new System.Windows.Forms.TabPage();
            this.cattle_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.smallcattle_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.poultry_flow = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.poultry_page.SuspendLayout();
            this.smallcattle_page.SuspendLayout();
            this.cattle_page.SuspendLayout();
            this.cattle_flow.SuspendLayout();
            this.smallcattle_flow.SuspendLayout();
            this.poultry_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products Stock";
            // 
            // cattle_products_amount
            // 
            this.cattle_products_amount.Location = new System.Drawing.Point(132, 51);
            this.cattle_products_amount.Name = "cattle_products_amount";
            this.cattle_products_amount.Size = new System.Drawing.Size(44, 20);
            this.cattle_products_amount.TabIndex = 3;
            // 
            // small_cattle_products_amount
            // 
            this.small_cattle_products_amount.Location = new System.Drawing.Point(132, 77);
            this.small_cattle_products_amount.Name = "small_cattle_products_amount";
            this.small_cattle_products_amount.Size = new System.Drawing.Size(44, 20);
            this.small_cattle_products_amount.TabIndex = 4;
            // 
            // poultry_products_amount
            // 
            this.poultry_products_amount.Location = new System.Drawing.Point(132, 106);
            this.poultry_products_amount.Name = "poultry_products_amount";
            this.poultry_products_amount.Size = new System.Drawing.Size(44, 20);
            this.poultry_products_amount.TabIndex = 5;
            // 
            // cashReserve
            // 
            this.cashReserve.Location = new System.Drawing.Point(17, 165);
            this.cashReserve.Name = "cashReserve";
            this.cashReserve.Size = new System.Drawing.Size(63, 20);
            this.cashReserve.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cattle Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "S && G Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poultry Products";
            // 
            // sell_cattle
            // 
            this.sell_cattle.Location = new System.Drawing.Point(182, 51);
            this.sell_cattle.Name = "sell_cattle";
            this.sell_cattle.Size = new System.Drawing.Size(78, 20);
            this.sell_cattle.TabIndex = 11;
            this.sell_cattle.Text = "Sell (2000)";
            this.sell_cattle.UseVisualStyleBackColor = true;
            this.sell_cattle.Click += new System.EventHandler(this.cattle_sell_Click);
            // 
            // smallcattle_sell
            // 
            this.smallcattle_sell.Location = new System.Drawing.Point(182, 77);
            this.smallcattle_sell.Name = "smallcattle_sell";
            this.smallcattle_sell.Size = new System.Drawing.Size(78, 20);
            this.smallcattle_sell.TabIndex = 12;
            this.smallcattle_sell.Text = "Sell (600)";
            this.smallcattle_sell.UseVisualStyleBackColor = true;
            this.smallcattle_sell.Click += new System.EventHandler(this.smallcattle_sell_Click);
            // 
            // poultry_sell
            // 
            this.poultry_sell.Location = new System.Drawing.Point(182, 105);
            this.poultry_sell.Name = "poultry_sell";
            this.poultry_sell.Size = new System.Drawing.Size(78, 21);
            this.poultry_sell.TabIndex = 13;
            this.poultry_sell.Text = "Sell (250)";
            this.poultry_sell.UseVisualStyleBackColor = true;
            this.poultry_sell.Click += new System.EventHandler(this.poultry_sell_Click);
            // 
            // buy_poultry
            // 
            this.buy_poultry.Location = new System.Drawing.Point(183, 257);
            this.buy_poultry.Name = "buy_poultry";
            this.buy_poultry.Size = new System.Drawing.Size(67, 20);
            this.buy_poultry.TabIndex = 21;
            this.buy_poultry.Text = "Buy (500)";
            this.buy_poultry.UseVisualStyleBackColor = true;
            this.buy_poultry.Click += new System.EventHandler(this.buy_poultry_Click);
            // 
            // buy_smallcattle
            // 
            this.buy_smallcattle.Location = new System.Drawing.Point(183, 283);
            this.buy_smallcattle.Name = "buy_smallcattle";
            this.buy_smallcattle.Size = new System.Drawing.Size(67, 20);
            this.buy_smallcattle.TabIndex = 24;
            this.buy_smallcattle.Text = "Buy (1500)";
            this.buy_smallcattle.UseVisualStyleBackColor = true;
            this.buy_smallcattle.Click += new System.EventHandler(this.buy_smallcattle_Click);
            // 
            // buy_cattle
            // 
            this.buy_cattle.Location = new System.Drawing.Point(182, 310);
            this.buy_cattle.Name = "buy_cattle";
            this.buy_cattle.Size = new System.Drawing.Size(68, 20);
            this.buy_cattle.TabIndex = 25;
            this.buy_cattle.Text = "Buy (4500)";
            this.buy_cattle.UseVisualStyleBackColor = true;
            this.buy_cattle.Click += new System.EventHandler(this.buy_cattle_Click);
            // 
            // poultry_amount
            // 
            this.poultry_amount.Location = new System.Drawing.Point(114, 258);
            this.poultry_amount.Name = "poultry_amount";
            this.poultry_amount.Size = new System.Drawing.Size(63, 20);
            this.poultry_amount.TabIndex = 26;
            // 
            // smallcattle_amount
            // 
            this.smallcattle_amount.Location = new System.Drawing.Point(114, 284);
            this.smallcattle_amount.Name = "smallcattle_amount";
            this.smallcattle_amount.Size = new System.Drawing.Size(63, 20);
            this.smallcattle_amount.TabIndex = 27;
            // 
            // cattle_amount
            // 
            this.cattle_amount.Location = new System.Drawing.Point(114, 310);
            this.cattle_amount.Name = "cattle_amount";
            this.cattle_amount.Size = new System.Drawing.Size(63, 20);
            this.cattle_amount.TabIndex = 28;
            this.cattle_amount.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // poultry_production
            // 
            this.poultry_production.Interval = 1000;
            this.poultry_production.Tick += new System.EventHandler(this.poultry_production_Tick_1);
            // 
            // smallcattle_production
            // 
            this.smallcattle_production.Interval = 1000;
            this.smallcattle_production.Tick += new System.EventHandler(this.smallcattle_production_Tick);
            // 
            // cattle_production
            // 
            this.cattle_production.Interval = 1000;
            this.cattle_production.Tick += new System.EventHandler(this.cattle_production_Tick);
            // 
            // Poultry_health
            // 
            this.Poultry_health.Interval = 1000;
            this.Poultry_health.Tick += new System.EventHandler(this.poultry_health_Tick);
            // 
            // smallcattle_health
            // 
            this.smallcattle_health.Interval = 1000;
            this.smallcattle_health.Tick += new System.EventHandler(this.small_cattle_health_Tick);
            // 
            // cattle_health
            // 
            this.cattle_health.Interval = 1000;
            this.cattle_health.Tick += new System.EventHandler(this.cattle_health_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Cattle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Sheep and Goats";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Poultry";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(13, 215);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5);
            this.label18.Size = new System.Drawing.Size(159, 35);
            this.label18.TabIndex = 41;
            this.label18.Text = "Animal Stock";
            // 
            // cattle_health_level
            // 
            this.cattle_health_level.Location = new System.Drawing.Point(3, 112);
            this.cattle_health_level.Maximum = 50000;
            this.cattle_health_level.Name = "cattle_health_level";
            this.cattle_health_level.Size = new System.Drawing.Size(90, 23);
            this.cattle_health_level.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Health Level";
            // 
            // cattle_progress
            // 
            this.cattle_progress.Location = new System.Drawing.Point(3, 154);
            this.cattle_progress.Name = "cattle_progress";
            this.cattle_progress.Size = new System.Drawing.Size(90, 23);
            this.cattle_progress.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Production Progress";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // smallcattle_health_level
            // 
            this.smallcattle_health_level.Location = new System.Drawing.Point(3, 112);
            this.smallcattle_health_level.Name = "smallcattle_health_level";
            this.smallcattle_health_level.Size = new System.Drawing.Size(90, 23);
            this.smallcattle_health_level.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Health Level";
            // 
            // smallcattle_progress
            // 
            this.smallcattle_progress.Location = new System.Drawing.Point(3, 154);
            this.smallcattle_progress.Name = "smallcattle_progress";
            this.smallcattle_progress.Size = new System.Drawing.Size(90, 23);
            this.smallcattle_progress.TabIndex = 0;
            this.smallcattle_progress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Production Progress";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // poultry_health_level
            // 
            this.poultry_health_level.Location = new System.Drawing.Point(3, 112);
            this.poultry_health_level.Name = "poultry_health_level";
            this.poultry_health_level.Size = new System.Drawing.Size(90, 23);
            this.poultry_health_level.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Health Level";
            // 
            // poultry_progress
            // 
            this.poultry_progress.Location = new System.Drawing.Point(3, 154);
            this.poultry_progress.Name = "poultry_progress";
            this.poultry_progress.Size = new System.Drawing.Size(90, 23);
            this.poultry_progress.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Production Progress";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.poultry_page);
            this.tabControl1.Controls.Add(this.smallcattle_page);
            this.tabControl1.Controls.Add(this.cattle_page);
            this.tabControl1.Location = new System.Drawing.Point(371, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 652);
            this.tabControl1.TabIndex = 48;
            // 
            // poultry_page
            // 
            this.poultry_page.AutoScroll = true;
            this.poultry_page.Controls.Add(this.poultry_flow);
            this.poultry_page.Location = new System.Drawing.Point(4, 22);
            this.poultry_page.Name = "poultry_page";
            this.poultry_page.Padding = new System.Windows.Forms.Padding(3);
            this.poultry_page.Size = new System.Drawing.Size(1128, 626);
            this.poultry_page.TabIndex = 0;
            this.poultry_page.Text = "Poultry";
            this.poultry_page.UseVisualStyleBackColor = true;
            // 
            // smallcattle_page
            // 
            this.smallcattle_page.AutoScroll = true;
            this.smallcattle_page.Controls.Add(this.smallcattle_flow);
            this.smallcattle_page.Location = new System.Drawing.Point(4, 22);
            this.smallcattle_page.Name = "smallcattle_page";
            this.smallcattle_page.Padding = new System.Windows.Forms.Padding(3);
            this.smallcattle_page.Size = new System.Drawing.Size(1128, 626);
            this.smallcattle_page.TabIndex = 1;
            this.smallcattle_page.Text = "Sheep and Goats";
            this.smallcattle_page.UseVisualStyleBackColor = true;
            // 
            // cattle_page
            // 
            this.cattle_page.AutoScroll = true;
            this.cattle_page.Controls.Add(this.cattle_flow);
            this.cattle_page.Location = new System.Drawing.Point(4, 22);
            this.cattle_page.Name = "cattle_page";
            this.cattle_page.Size = new System.Drawing.Size(1128, 626);
            this.cattle_page.TabIndex = 2;
            this.cattle_page.Text = "Cattle";
            this.cattle_page.UseVisualStyleBackColor = true;
            // 
            // cattle_flow
            // 
            this.cattle_flow.Controls.Add(this.pictureBox2);
            this.cattle_flow.Controls.Add(this.label14);
            this.cattle_flow.Controls.Add(this.cattle_health_level);
            this.cattle_flow.Controls.Add(this.label11);
            this.cattle_flow.Controls.Add(this.cattle_progress);
            this.cattle_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cattle_flow.Location = new System.Drawing.Point(3, 3);
            this.cattle_flow.Name = "cattle_flow";
            this.cattle_flow.Size = new System.Drawing.Size(1122, 627);
            this.cattle_flow.TabIndex = 40;
            // 
            // smallcattle_flow
            // 
            this.smallcattle_flow.Controls.Add(this.pictureBox3);
            this.smallcattle_flow.Controls.Add(this.label13);
            this.smallcattle_flow.Controls.Add(this.smallcattle_health_level);
            this.smallcattle_flow.Controls.Add(this.label10);
            this.smallcattle_flow.Controls.Add(this.smallcattle_progress);
            this.smallcattle_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.smallcattle_flow.Location = new System.Drawing.Point(0, 0);
            this.smallcattle_flow.Name = "smallcattle_flow";
            this.smallcattle_flow.Size = new System.Drawing.Size(1132, 630);
            this.smallcattle_flow.TabIndex = 39;
            // 
            // poultry_flow
            // 
            this.poultry_flow.AutoScroll = true;
            this.poultry_flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.poultry_flow.Controls.Add(this.pictureBox1);
            this.poultry_flow.Controls.Add(this.label12);
            this.poultry_flow.Controls.Add(this.poultry_health_level);
            this.poultry_flow.Controls.Add(this.label9);
            this.poultry_flow.Controls.Add(this.poultry_progress);
            this.poultry_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.poultry_flow.Location = new System.Drawing.Point(0, 0);
            this.poultry_flow.Name = "poultry_flow";
            this.poultry_flow.Size = new System.Drawing.Size(1129, 625);
            this.poultry_flow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 933);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cattle_amount);
            this.Controls.Add(this.smallcattle_amount);
            this.Controls.Add(this.poultry_amount);
            this.Controls.Add(this.buy_cattle);
            this.Controls.Add(this.buy_smallcattle);
            this.Controls.Add(this.buy_poultry);
            this.Controls.Add(this.poultry_sell);
            this.Controls.Add(this.smallcattle_sell);
            this.Controls.Add(this.sell_cattle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashReserve);
            this.Controls.Add(this.poultry_products_amount);
            this.Controls.Add(this.small_cattle_products_amount);
            this.Controls.Add(this.cattle_products_amount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.poultry_page.ResumeLayout(false);
            this.smallcattle_page.ResumeLayout(false);
            this.cattle_page.ResumeLayout(false);
            this.cattle_flow.ResumeLayout(false);
            this.cattle_flow.PerformLayout();
            this.smallcattle_flow.ResumeLayout(false);
            this.smallcattle_flow.PerformLayout();
            this.poultry_flow.ResumeLayout(false);
            this.poultry_flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cattle_products_amount;
        private System.Windows.Forms.TextBox small_cattle_products_amount;
        private System.Windows.Forms.TextBox poultry_products_amount;
        private System.Windows.Forms.TextBox cashReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sell_cattle;
        private System.Windows.Forms.Button smallcattle_sell;
        private System.Windows.Forms.Button poultry_sell;
        private System.Windows.Forms.Button buy_poultry;
        private System.Windows.Forms.Button buy_smallcattle;
        private System.Windows.Forms.Button buy_cattle;
        private System.Windows.Forms.TextBox poultry_amount;
        private System.Windows.Forms.TextBox smallcattle_amount;
        private System.Windows.Forms.TextBox cattle_amount;
        private System.Windows.Forms.Timer poultry_production;
        private System.Windows.Forms.Timer cattle_production;
        private System.Windows.Forms.Timer smallcattle_production;
        private System.Windows.Forms.Timer Poultry_health;
        private System.Windows.Forms.Timer smallcattle_health;
        private System.Windows.Forms.Timer cattle_health;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar cattle_health_level;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar cattle_progress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar smallcattle_health_level;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar smallcattle_progress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar poultry_health_level;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar poultry_progress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage poultry_page;
        private System.Windows.Forms.TabPage smallcattle_page;
        private System.Windows.Forms.TabPage cattle_page;
        private System.Windows.Forms.FlowLayoutPanel poultry_flow;
        private System.Windows.Forms.FlowLayoutPanel smallcattle_flow;
        private System.Windows.Forms.FlowLayoutPanel cattle_flow;
    }
}

