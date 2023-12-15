namespace SalesAndInventory
{
    partial class purchases
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
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 661);
            panelMain.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(36, 347);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 6;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(panelMain);
            Name = "purchases";
            Text = "purchases";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Button button1;
    }
}