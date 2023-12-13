namespace SalesAndInventory
{
    partial class inventorysub
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
            btnPurchases = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            btnBack = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            colorwaycmb = new ComboBox();
            shoeslabel = new Label();
            colorway = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnUpdateStocks = new Button();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(btnPurchases);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(1, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 660);
            panelMain.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(36, 348);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 4;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPurchases
            // 
            btnPurchases.BackColor = Color.SandyBrown;
            btnPurchases.Location = new Point(36, 287);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(96, 36);
            btnPurchases.TabIndex = 3;
            btnPurchases.Text = "Purchases";
            btnPurchases.UseVisualStyleBackColor = false;
            btnPurchases.Click += btnPurchases_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.SandyBrown;
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
            btnInventory.BackColor = Color.Salmon;
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
            // btnBack
            // 
            btnBack.BackColor = Color.PeachPuff;
            btnBack.Location = new Point(186, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(96, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 96);
            label1.Name = "label1";
            label1.Size = new Size(136, 47);
            label1.TabIndex = 6;
            label1.Text = "BRAND";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(228, 214);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(136, 213);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // colorwaycmb
            // 
            colorwaycmb.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            colorwaycmb.FormattingEnabled = true;
            colorwaycmb.Location = new Point(586, 131);
            colorwaycmb.Name = "colorwaycmb";
            colorwaycmb.Size = new Size(187, 31);
            colorwaycmb.TabIndex = 8;
            // 
            // shoeslabel
            // 
            shoeslabel.AutoSize = true;
            shoeslabel.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            shoeslabel.Location = new Point(616, 72);
            shoeslabel.Name = "shoeslabel";
            shoeslabel.Size = new Size(129, 47);
            shoeslabel.TabIndex = 9;
            shoeslabel.Text = "SHOES";
            // 
            // colorway
            // 
            colorway.AutoSize = true;
            colorway.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            colorway.Location = new Point(494, 134);
            colorway.Name = "colorway";
            colorway.Size = new Size(78, 23);
            colorway.TabIndex = 10;
            colorway.Text = "colorway";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(418, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 215);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(37, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 24);
            textBox1.TabIndex = 0;
            // 
            // btnUpdateStocks
            // 
            btnUpdateStocks.BackColor = Color.Coral;
            btnUpdateStocks.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateStocks.Location = new Point(597, 472);
            btnUpdateStocks.Name = "btnUpdateStocks";
            btnUpdateStocks.Size = new Size(162, 36);
            btnUpdateStocks.TabIndex = 12;
            btnUpdateStocks.Text = "UPDATE STOCKS";
            btnUpdateStocks.UseVisualStyleBackColor = false;
            btnUpdateStocks.Click += btnUpdateStocks_Click;
            // 
            // inventorysub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(btnUpdateStocks);
            Controls.Add(panel1);
            Controls.Add(colorway);
            Controls.Add(shoeslabel);
            Controls.Add(colorwaycmb);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnBack);
            Controls.Add(panelMain);
            Name = "inventorysub";
            Text = "inventorysub";
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private Button btnPurchases;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Button btnBack;
        private ComboBox comboBox1;
        private Label label1;
        private ListBox listBox1;
        private ComboBox colorwaycmb;
        private Label shoeslabel;
        private Label colorway;
        private Panel panel1;
        private Button btnUpdateStocks;
        private TextBox textBox1;
        private Button button1;
    }
}