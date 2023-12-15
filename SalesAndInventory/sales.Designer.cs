namespace SalesAndInventory
{
    partial class sales
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
            panelMain = new Panel();
            button1 = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            fname = new TextBox();
            lname = new TextBox();
            label2 = new Label();
            addr = new TextBox();
            label3 = new Label();
            cp = new TextBox();
            label4 = new Label();
            city = new TextBox();
            label5 = new Label();
            barangay = new TextBox();
            label6 = new Label();
            landmark = new TextBox();
            label7 = new Label();
            label8 = new Label();
            courier = new TextBox();
            label9 = new Label();
            payment = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            brandcmb = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            productcmb = new ComboBox();
            label16 = new Label();
            colorwaycmb = new ComboBox();
            label17 = new Label();
            addbtn = new Button();
            clearlist = new Button();
            dataGridView1 = new DataGridView();
            BrandColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            ColorwayColumn = new DataGridViewTextBoxColumn();
            SizesColumn = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            RetailPrice = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            applybtn = new Button();
            label20 = new Label();
            disc = new TextBox();
            label19 = new Label();
            subtotaltxtb = new TextBox();
            panel2 = new Panel();
            label21 = new Label();
            totaltxtb = new TextBox();
            sizescmb = new ComboBox();
            label18 = new Label();
            confirmbtn = new Button();
            label22 = new Label();
            customercmb = new ComboBox();
            cleartxtb = new Button();
            quantitycmb = new ComboBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(1, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 661);
            panelMain.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(36, 295);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 6;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Salmon;
            btnSales.Location = new Point(36, 227);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(96, 36);
            btnSales.TabIndex = 2;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.SandyBrown;
            btnInventory.Location = new Point(36, 165);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(96, 36);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SandyBrown;
            btnDashboard.Location = new Point(36, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(96, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Location = new Point(675, 42);
            button2.Name = "button2";
            button2.Size = new Size(144, 36);
            button2.TabIndex = 7;
            button2.Text = "Manage Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Location = new Point(464, 42);
            button3.Name = "button3";
            button3.Size = new Size(143, 36);
            button3.TabIndex = 7;
            button3.Text = "Create Sales Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 170);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // fname
            // 
            fname.Location = new Point(339, 167);
            fname.Name = "fname";
            fname.Size = new Size(149, 23);
            fname.TabIndex = 9;
            // 
            // lname
            // 
            lname.Location = new Point(339, 206);
            lname.Name = "lname";
            lname.Size = new Size(149, 23);
            lname.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 209);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // addr
            // 
            addr.Location = new Point(339, 253);
            addr.Name = "addr";
            addr.Size = new Size(149, 23);
            addr.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 256);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 12;
            label3.Text = "Street Address";
            // 
            // cp
            // 
            cp.Location = new Point(339, 297);
            cp.Name = "cp";
            cp.Size = new Size(149, 23);
            cp.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 300);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Contact Number";
            // 
            // city
            // 
            city.Location = new Point(339, 338);
            city.Name = "city";
            city.Size = new Size(149, 23);
            city.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 341);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 16;
            label5.Text = "City";
            // 
            // barangay
            // 
            barangay.Location = new Point(339, 378);
            barangay.Name = "barangay";
            barangay.Size = new Size(149, 23);
            barangay.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 381);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 18;
            label6.Text = "Barangay";
            // 
            // landmark
            // 
            landmark.Location = new Point(339, 420);
            landmark.Name = "landmark";
            landmark.Size = new Size(149, 23);
            landmark.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 423);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 20;
            label7.Text = "Landmark";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(232, 481);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 22;
            label8.Text = "Shipping Courier";
            // 
            // courier
            // 
            courier.Location = new Point(339, 522);
            courier.Name = "courier";
            courier.Size = new Size(149, 23);
            courier.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 525);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 23;
            label9.Text = "Courier";
            // 
            // payment
            // 
            payment.Location = new Point(339, 610);
            payment.Name = "payment";
            payment.Size = new Size(149, 23);
            payment.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(232, 613);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 26;
            label10.Text = "Payment Option";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(232, 569);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 25;
            label11.Text = "Payment Details";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(232, 69);
            label12.Name = "label12";
            label12.Size = new Size(125, 15);
            label12.TabIndex = 28;
            label12.Text = "Customer Information";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(589, 175);
            label13.Name = "label13";
            label13.Size = new Size(204, 15);
            label13.TabIndex = 29;
            label13.Text = "Shoes Details - Select And Add To List";
            // 
            // brandcmb
            // 
            brandcmb.FormattingEnabled = true;
            brandcmb.Location = new Point(698, 218);
            brandcmb.Name = "brandcmb";
            brandcmb.Size = new Size(121, 23);
            brandcmb.TabIndex = 30;
            brandcmb.SelectedIndexChanged += brandcmb_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(589, 221);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 31;
            label14.Text = "Brand";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(589, 259);
            label15.Name = "label15";
            label15.Size = new Size(84, 15);
            label15.TabIndex = 33;
            label15.Text = "Product Name";
            // 
            // productcmb
            // 
            productcmb.FormattingEnabled = true;
            productcmb.Location = new Point(698, 256);
            productcmb.Name = "productcmb";
            productcmb.Size = new Size(121, 23);
            productcmb.TabIndex = 32;
            productcmb.SelectedIndexChanged += productcmb_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(589, 300);
            label16.Name = "label16";
            label16.Size = new Size(57, 15);
            label16.TabIndex = 35;
            label16.Text = "Colorway";
            // 
            // colorwaycmb
            // 
            colorwaycmb.FormattingEnabled = true;
            colorwaycmb.Location = new Point(698, 297);
            colorwaycmb.Name = "colorwaycmb";
            colorwaycmb.Size = new Size(121, 23);
            colorwaycmb.TabIndex = 34;
            colorwaycmb.SelectedIndexChanged += colorwaycmb_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(589, 344);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 37;
            label17.Text = "Sizes";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(605, 434);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 38;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // clearlist
            // 
            clearlist.Location = new Point(718, 434);
            clearlist.Name = "clearlist";
            clearlist.Size = new Size(75, 23);
            clearlist.TabIndex = 39;
            clearlist.Text = "CLEAR";
            clearlist.UseVisualStyleBackColor = true;
            clearlist.Click += clearlist_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BrandColumn, ProductNameColumn, ColorwayColumn, SizesColumn, Quantity, RetailPrice });
            dataGridView1.Location = new Point(516, 481);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(403, 150);
            dataGridView1.TabIndex = 40;
            // 
            // BrandColumn
            // 
            BrandColumn.HeaderText = "Brand";
            BrandColumn.Name = "BrandColumn";
            BrandColumn.Width = 60;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Product Name";
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.Width = 60;
            // 
            // ColorwayColumn
            // 
            ColorwayColumn.HeaderText = "Colorway";
            ColorwayColumn.Name = "ColorwayColumn";
            ColorwayColumn.Width = 60;
            // 
            // SizesColumn
            // 
            SizesColumn.HeaderText = "Size";
            SizesColumn.Name = "SizesColumn";
            SizesColumn.Width = 60;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Width = 60;
            // 
            // RetailPrice
            // 
            RetailPrice.HeaderText = "Price";
            RetailPrice.Name = "RetailPrice";
            RetailPrice.Width = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(applybtn);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(disc);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(subtotaltxtb);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(917, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 241);
            panel1.TabIndex = 41;
            // 
            // applybtn
            // 
            applybtn.BackColor = Color.DarkSalmon;
            applybtn.Location = new Point(106, 133);
            applybtn.Name = "applybtn";
            applybtn.Size = new Size(79, 23);
            applybtn.TabIndex = 44;
            applybtn.Text = "APPLY";
            applybtn.UseVisualStyleBackColor = false;
            applybtn.Click += applybtn_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.FlatStyle = FlatStyle.System;
            label20.Location = new Point(23, 118);
            label20.Name = "label20";
            label20.Size = new Size(54, 15);
            label20.TabIndex = 46;
            label20.Text = "Discount";
            // 
            // disc
            // 
            disc.Location = new Point(106, 113);
            disc.Name = "disc";
            disc.Size = new Size(79, 23);
            disc.TabIndex = 47;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(23, 69);
            label19.Name = "label19";
            label19.Size = new Size(51, 15);
            label19.TabIndex = 44;
            label19.Text = "Subtotal";
            // 
            // subtotaltxtb
            // 
            subtotaltxtb.Location = new Point(106, 66);
            subtotaltxtb.Name = "subtotaltxtb";
            subtotaltxtb.ReadOnly = true;
            subtotaltxtb.Size = new Size(79, 23);
            subtotaltxtb.TabIndex = 45;
            subtotaltxtb.TextChanged += textBox11_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(label21);
            panel2.Controls.Add(totaltxtb);
            panel2.Location = new Point(0, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 68);
            panel2.TabIndex = 42;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(23, 25);
            label21.Name = "label21";
            label21.Size = new Size(32, 15);
            label21.TabIndex = 48;
            label21.Text = "Total";
            // 
            // totaltxtb
            // 
            totaltxtb.Location = new Point(106, 22);
            totaltxtb.Name = "totaltxtb";
            totaltxtb.ReadOnly = true;
            totaltxtb.Size = new Size(79, 23);
            totaltxtb.TabIndex = 49;
            // 
            // sizescmb
            // 
            sizescmb.FormattingEnabled = true;
            sizescmb.Location = new Point(698, 341);
            sizescmb.Name = "sizescmb";
            sizescmb.Size = new Size(121, 23);
            sizescmb.TabIndex = 36;
            sizescmb.SelectedIndexChanged += sizescmb_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(591, 384);
            label18.Name = "label18";
            label18.Size = new Size(53, 15);
            label18.TabIndex = 42;
            label18.Text = "Quantity";
            // 
            // confirmbtn
            // 
            confirmbtn.Location = new Point(965, 434);
            confirmbtn.Name = "confirmbtn";
            confirmbtn.Size = new Size(109, 23);
            confirmbtn.TabIndex = 44;
            confirmbtn.Text = "Confirm Order";
            confirmbtn.UseVisualStyleBackColor = true;
            confirmbtn.Click += confirmbtn_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(255, 99);
            label22.Name = "label22";
            label22.Size = new Size(206, 15);
            label22.TabIndex = 45;
            label22.Text = "Repeat Customer? Select Customer ID";
            // 
            // customercmb
            // 
            customercmb.FormattingEnabled = true;
            customercmb.Location = new Point(291, 125);
            customercmb.Name = "customercmb";
            customercmb.Size = new Size(81, 23);
            customercmb.TabIndex = 46;
            customercmb.SelectedIndexChanged += customercmb_SelectedIndexChanged;
            // 
            // cleartxtb
            // 
            cleartxtb.Location = new Point(386, 125);
            cleartxtb.Name = "cleartxtb";
            cleartxtb.Size = new Size(75, 23);
            cleartxtb.TabIndex = 47;
            cleartxtb.Text = "CLEAR";
            cleartxtb.UseVisualStyleBackColor = true;
            cleartxtb.Click += cleartxtb_Click;
            // 
            // quantitycmb
            // 
            quantitycmb.FormattingEnabled = true;
            quantitycmb.Location = new Point(698, 381);
            quantitycmb.Name = "quantitycmb";
            quantitycmb.Size = new Size(121, 23);
            quantitycmb.TabIndex = 48;
            quantitycmb.SelectedIndexChanged += quantitycmb_SelectedIndexChanged;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(quantitycmb);
            Controls.Add(cleartxtb);
            Controls.Add(customercmb);
            Controls.Add(label22);
            Controls.Add(confirmbtn);
            Controls.Add(label18);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(clearlist);
            Controls.Add(addbtn);
            Controls.Add(label17);
            Controls.Add(sizescmb);
            Controls.Add(label16);
            Controls.Add(colorwaycmb);
            Controls.Add(label15);
            Controls.Add(productcmb);
            Controls.Add(label14);
            Controls.Add(brandcmb);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(payment);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(courier);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(landmark);
            Controls.Add(label7);
            Controls.Add(barangay);
            Controls.Add(label6);
            Controls.Add(city);
            Controls.Add(label5);
            Controls.Add(cp);
            Controls.Add(label4);
            Controls.Add(addr);
            Controls.Add(label3);
            Controls.Add(lname);
            Controls.Add(label2);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panelMain);
            Name = "sales";
            Text = "sales";
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox fname;
        private TextBox lname;
        private Label label2;
        private TextBox addr;
        private Label label3;
        private TextBox cp;
        private Label label4;
        private TextBox city;
        private Label label5;
        private TextBox barangay;
        private Label label6;
        private TextBox landmark;
        private Label label7;
        private Label label8;
        private TextBox courier;
        private Label label9;
        private TextBox payment;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox brandcmb;
        private Label label14;
        private Label label15;
        private ComboBox productcmb;
        private Label label16;
        private ComboBox colorwaycmb;
        private Label label17;
        private Button addbtn;
        private Button clearlist;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label19;
        private TextBox subtotaltxtb;
        private Panel panel2;
        private ComboBox sizescmb;
        private Label label18;
        private Label label20;
        private TextBox disc;
        private Button applybtn;
        private Label label21;
        private TextBox totaltxtb;
        private Button confirmbtn;
        private Label label22;
        private ComboBox customercmb;
        private Button cleartxtb;
        private ComboBox quantitycmb;
        private DataGridViewTextBoxColumn BrandColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn ColorwayColumn;
        private DataGridViewTextBoxColumn SizesColumn;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn RetailPrice;
    }
}