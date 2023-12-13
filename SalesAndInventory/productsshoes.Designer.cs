namespace SalesAndInventory
{
    partial class productsshoes
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
            back = new Button();
            editexisting = new Button();
            addshoes = new Button();
            panelMain = new Panel();
            button1 = new Button();
            btnPurchases = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            addcolorways = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.MistyRose;
            back.Location = new Point(215, 80);
            back.Name = "back";
            back.Size = new Size(54, 20);
            back.TabIndex = 13;
            back.Text = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // editexisting
            // 
            editexisting.BackColor = Color.SandyBrown;
            editexisting.Location = new Point(768, 73);
            editexisting.Name = "editexisting";
            editexisting.Size = new Size(115, 36);
            editexisting.TabIndex = 12;
            editexisting.Text = "Edit Existing Shoes";
            editexisting.UseVisualStyleBackColor = false;
            editexisting.Click += editexisting_Click;
            // 
            // addshoes
            // 
            addshoes.BackColor = Color.Salmon;
            addshoes.Location = new Point(368, 72);
            addshoes.Name = "addshoes";
            addshoes.Size = new Size(121, 36);
            addshoes.TabIndex = 11;
            addshoes.Text = "Add New Shoes";
            addshoes.UseVisualStyleBackColor = false;
            addshoes.Click += addshoes_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(btnPurchases);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(3, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 661);
            panelMain.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(36, 349);
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
            // addcolorways
            // 
            addcolorways.BackColor = Color.SandyBrown;
            addcolorways.Location = new Point(568, 73);
            addcolorways.Name = "addcolorways";
            addcolorways.Size = new Size(128, 36);
            addcolorways.TabIndex = 10;
            addcolorways.Text = "Add New Colorways";
            addcolorways.UseVisualStyleBackColor = false;
            addcolorways.Click += addcolorways_Click;
            // 
            // productsshoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(back);
            Controls.Add(editexisting);
            Controls.Add(addshoes);
            Controls.Add(panelMain);
            Controls.Add(addcolorways);
            Name = "productsshoes";
            Text = "addnewshoes";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button editexisting;
        private Button addshoes;
        private Panel panelMain;
        private Button button1;
        private Button btnPurchases;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Button addcolorways;
    }
}