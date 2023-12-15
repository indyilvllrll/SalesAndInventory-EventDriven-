namespace SalesAndInventory
{
    partial class productsedit
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
            addcolorways = new Button();
            panelMain = new Panel();
            button2 = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            savebtn = new Button();
            editbtn = new Button();
            prn = new TextBox();
            label8 = new Label();
            retailp = new TextBox();
            label9 = new Label();
            basep = new TextBox();
            label10 = new Label();
            colorwaytxtb = new TextBox();
            label11 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.MistyRose;
            back.Location = new Point(275, 57);
            back.Name = "back";
            back.Size = new Size(54, 20);
            back.TabIndex = 23;
            back.Text = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // editexisting
            // 
            editexisting.BackColor = Color.Salmon;
            editexisting.Location = new Point(828, 50);
            editexisting.Name = "editexisting";
            editexisting.Size = new Size(115, 36);
            editexisting.TabIndex = 22;
            editexisting.Text = "Edit Existing Shoes";
            editexisting.UseVisualStyleBackColor = false;
            editexisting.Click += editexisting_Click;
            // 
            // addshoes
            // 
            addshoes.BackColor = Color.SandyBrown;
            addshoes.Location = new Point(428, 49);
            addshoes.Name = "addshoes";
            addshoes.Size = new Size(121, 36);
            addshoes.TabIndex = 21;
            addshoes.Text = "Add New Shoes";
            addshoes.UseVisualStyleBackColor = false;
            addshoes.Click += addshoes_Click;
            // 
            // addcolorways
            // 
            addcolorways.BackColor = Color.SandyBrown;
            addcolorways.Location = new Point(628, 50);
            addcolorways.Name = "addcolorways";
            addcolorways.Size = new Size(128, 36);
            addcolorways.TabIndex = 20;
            addcolorways.Text = "Add New Colorways";
            addcolorways.UseVisualStyleBackColor = false;
            addcolorways.Click += addcolorways_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Sienna;
            panelMain.Controls.Add(button2);
            panelMain.Controls.Add(btnSales);
            panelMain.Controls.Add(btnInventory);
            panelMain.Controls.Add(btnDashboard);
            panelMain.Location = new Point(3, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(169, 661);
            panelMain.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(36, 288);
            button2.Name = "button2";
            button2.Size = new Size(96, 36);
            button2.TabIndex = 14;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(825, 155);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 29;
            label3.Text = "COLORWAYS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 142);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 28;
            label2.Text = "SHOES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 155);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 27;
            label1.Text = "BRAND";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(833, 199);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 154);
            listBox3.TabIndex = 26;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(535, 199);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 154);
            listBox2.TabIndex = 25;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(280, 199);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 24;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(628, 567);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(121, 23);
            savebtn.TabIndex = 38;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(476, 567);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(121, 23);
            editbtn.TabIndex = 41;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // prn
            // 
            prn.Location = new Point(572, 407);
            prn.Name = "prn";
            prn.Size = new Size(170, 23);
            prn.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 410);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 48;
            label8.Text = "Product Name";
            // 
            // retailp
            // 
            retailp.Location = new Point(572, 497);
            retailp.Name = "retailp";
            retailp.Size = new Size(170, 23);
            retailp.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 500);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 46;
            label9.Text = "Retail Price";
            // 
            // basep
            // 
            basep.Location = new Point(572, 468);
            basep.Name = "basep";
            basep.Size = new Size(170, 23);
            basep.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(480, 471);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 44;
            label10.Text = "Base Price";
            // 
            // colorwaytxtb
            // 
            colorwaytxtb.Location = new Point(572, 436);
            colorwaytxtb.Name = "colorwaytxtb";
            colorwaytxtb.Size = new Size(170, 23);
            colorwaytxtb.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(480, 439);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 42;
            label11.Text = "Colorway";
            // 
            // productsedit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(prn);
            Controls.Add(label8);
            Controls.Add(retailp);
            Controls.Add(label9);
            Controls.Add(basep);
            Controls.Add(label10);
            Controls.Add(colorwaytxtb);
            Controls.Add(label11);
            Controls.Add(editbtn);
            Controls.Add(savebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(back);
            Controls.Add(editexisting);
            Controls.Add(addshoes);
            Controls.Add(addcolorways);
            Controls.Add(panelMain);
            Name = "productsedit";
            Text = "editexisting";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button editexisting;
        private Button addshoes;
        private Button addcolorways;
        private Panel panelMain;
        private Button button2;
        private Button btnSales;
        private Button btnInventory;
        private Button btnDashboard;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button savebtn;
        private Button editbtn;
        private TextBox prn;
        private Label label8;
        private TextBox retailp;
        private Label label9;
        private TextBox basep;
        private Label label10;
        private TextBox colorwaytxtb;
        private Label label11;
    }
}