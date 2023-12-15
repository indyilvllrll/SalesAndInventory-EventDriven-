namespace SalesAndInventory
{
    partial class inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panelMain = new Panel();
            button1 = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            btnUpdateStocks = new Button();
            label2 = new Label();
            label1 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            brandcmb = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(527, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(12, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 662);
            panelMain.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(36, 289);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 5;
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
            btnInventory.BackColor = Color.Salmon;
            btnInventory.Enabled = false;
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
            // btnUpdateStocks
            // 
            btnUpdateStocks.BackColor = Color.PeachPuff;
            btnUpdateStocks.Location = new Point(900, 92);
            btnUpdateStocks.Name = "btnUpdateStocks";
            btnUpdateStocks.Size = new Size(171, 36);
            btnUpdateStocks.TabIndex = 4;
            btnUpdateStocks.Text = "UPDATE STOCKS";
            btnUpdateStocks.UseVisualStyleBackColor = false;
            btnUpdateStocks.Click += btnUpdateStocks_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 187);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 13;
            label2.Text = "SHOES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 122);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 12;
            label1.Text = "BRAND";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(353, 212);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(138, 214);
            listBox2.TabIndex = 11;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(215, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 214);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // brandcmb
            // 
            brandcmb.FormattingEnabled = true;
            brandcmb.Location = new Point(215, 151);
            brandcmb.Name = "brandcmb";
            brandcmb.Size = new Size(132, 23);
            brandcmb.TabIndex = 14;
            brandcmb.SelectedIndexChanged += brandcmb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 187);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 15;
            label3.Text = "COLORWAY";
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(label3);
            Controls.Add(brandcmb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnUpdateStocks);
            Controls.Add(panelMain);
            Controls.Add(dataGridView1);
            Name = "inventory";
            Text = "INVENTORY";
            Load += inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panelMain;
        private Button btnInventory;
        private Button btnDashboard;
        private Button btnSales;
        private Button btnUpdateStocks;
        private Button button1;
        private Label label2;
        private Label label1;
        private ListBox listBox2;
        private ListBox listBox1;
        private ComboBox brandcmb;
        private Label label3;
    }
}