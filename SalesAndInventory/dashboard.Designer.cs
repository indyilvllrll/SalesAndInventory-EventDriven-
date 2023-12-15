namespace SalesAndInventory
{
    partial class dashboard
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            packed = new Label();
            shipped = new Label();
            completed = new Label();
            label11 = new Label();
            panel4 = new Panel();
            totalsales = new Label();
            label13 = new Label();
            panel5 = new Panel();
            inventory = new Label();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panelMain.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(36, 288);
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
            btnDashboard.BackColor = Color.Salmon;
            btnDashboard.Location = new Point(36, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(96, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(packed);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(249, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 141);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(shipped);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(463, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 141);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(completed);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(668, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 141);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 47);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 6;
            label1.Text = "Sales Activity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 95);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 7;
            label2.Text = "PACKED";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 95);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 8;
            label3.Text = "SHIPPED";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 95);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 9;
            label4.Text = "COMPLETED";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 63);
            label5.Name = "label5";
            label5.Size = new Size(47, 19);
            label5.TabIndex = 8;
            label5.Text = "orders";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 63);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 9;
            label6.Text = "orders";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 63);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 10;
            label7.Text = "orders";
            // 
            // packed
            // 
            packed.AutoSize = true;
            packed.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            packed.Location = new Point(57, 22);
            packed.Name = "packed";
            packed.Size = new Size(28, 35);
            packed.TabIndex = 9;
            packed.Text = "2";
            // 
            // shipped
            // 
            shipped.AutoSize = true;
            shipped.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            shipped.Location = new Point(61, 22);
            shipped.Name = "shipped";
            shipped.Size = new Size(28, 35);
            shipped.TabIndex = 10;
            shipped.Text = "2";
            // 
            // completed
            // 
            completed.AutoSize = true;
            completed.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            completed.Location = new Point(59, 21);
            completed.Name = "completed";
            completed.Size = new Size(28, 35);
            completed.TabIndex = 11;
            completed.Text = "2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(249, 323);
            label11.Name = "label11";
            label11.Size = new Size(108, 28);
            label11.TabIndex = 7;
            label11.Text = "Total Sales";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(totalsales);
            panel4.Location = new Point(249, 386);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 122);
            panel4.TabIndex = 10;
            // 
            // totalsales
            // 
            totalsales.AutoSize = true;
            totalsales.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            totalsales.Location = new Point(78, 41);
            totalsales.Name = "totalsales";
            totalsales.Size = new Size(28, 35);
            totalsales.TabIndex = 9;
            totalsales.Text = "2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(576, 323);
            label13.Name = "label13";
            label13.Size = new Size(190, 28);
            label13.TabIndex = 11;
            label13.Text = "Inventory Summary";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(inventory);
            panel5.Location = new Point(576, 386);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 122);
            panel5.TabIndex = 11;
            // 
            // inventory
            // 
            inventory.AutoSize = true;
            inventory.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inventory.Location = new Point(78, 41);
            inventory.Name = "inventory";
            inventory.Size = new Size(28, 35);
            inventory.TabIndex = 9;
            inventory.Text = "2";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(panel5);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            Name = "dashboard";
            Text = "dashboard";
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Button button1;
        private Panel panel1;
        private Label packed;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Label shipped;
        private Label label6;
        private Label label3;
        private Panel panel3;
        private Label completed;
        private Label label7;
        private Label label4;
        private Label label1;
        private Label label11;
        private Panel panel4;
        private Label totalsales;
        private Label label13;
        private Panel panel5;
        private Label inventory;
    }
}