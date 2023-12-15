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
            label1 = new Label();
            brandcmb = new ComboBox();
            label2 = new Label();
            prn = new TextBox();
            basep = new TextBox();
            label3 = new Label();
            retailp = new TextBox();
            label4 = new Label();
            savebtn = new Button();
            dataGridView1 = new DataGridView();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 230);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "Brand";
            // 
            // brandcmb
            // 
            brandcmb.FormattingEnabled = true;
            brandcmb.Location = new Point(526, 227);
            brandcmb.Name = "brandcmb";
            brandcmb.Size = new Size(170, 23);
            brandcmb.TabIndex = 15;
            brandcmb.SelectedIndexChanged += brandcmb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 271);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 16;
            label2.Text = "Product Name";
            // 
            // prn
            // 
            prn.Location = new Point(526, 268);
            prn.Name = "prn";
            prn.Size = new Size(170, 23);
            prn.TabIndex = 17;
            // 
            // basep
            // 
            basep.Location = new Point(526, 300);
            basep.Name = "basep";
            basep.Size = new Size(170, 23);
            basep.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 303);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 18;
            label3.Text = "Base Price";
            // 
            // retailp
            // 
            retailp.Location = new Point(526, 329);
            retailp.Name = "retailp";
            retailp.Size = new Size(170, 23);
            retailp.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 332);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 20;
            label4.Text = "Retail Price";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(515, 406);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(121, 23);
            savebtn.TabIndex = 22;
            savebtn.Text = "ADD SHOES";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 458);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(489, 189);
            dataGridView1.TabIndex = 23;
            // 
            // productsshoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(dataGridView1);
            Controls.Add(savebtn);
            Controls.Add(retailp);
            Controls.Add(label4);
            Controls.Add(basep);
            Controls.Add(label3);
            Controls.Add(prn);
            Controls.Add(label2);
            Controls.Add(brandcmb);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(editexisting);
            Controls.Add(addshoes);
            Controls.Add(panelMain);
            Controls.Add(addcolorways);
            Name = "productsshoes";
            Text = "addnewshoes";
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private ComboBox brandcmb;
        private Label label2;
        private TextBox prn;
        private TextBox basep;
        private Label label3;
        private TextBox retailp;
        private Label label4;
        private Button savebtn;
        private DataGridView dataGridView1;
    }
}