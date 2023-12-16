namespace SalesAndInventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_btn = new Button();
            un_tb = new TextBox();
            pw_tb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.DarkGray;
            login_btn.Location = new Point(513, 357);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(139, 32);
            login_btn.TabIndex = 0;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // un_tb
            // 
            un_tb.BackColor = Color.FromArgb(255, 192, 192);
            un_tb.Location = new Point(461, 246);
            un_tb.MaxLength = 30;
            un_tb.Name = "un_tb";
            un_tb.Size = new Size(236, 23);
            un_tb.TabIndex = 1;
            // 
            // pw_tb
            // 
            pw_tb.BackColor = Color.FromArgb(255, 192, 192);
            pw_tb.Location = new Point(461, 298);
            pw_tb.Name = "pw_tb";
            pw_tb.PasswordChar = '*';
            pw_tb.Size = new Size(236, 23);
            pw_tb.TabIndex = 2;
            pw_tb.TextChanged += pw_tb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(501, 163);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 3;
            label1.Text = "LOG IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 659);
            Controls.Add(label1);
            Controls.Add(pw_tb);
            Controls.Add(un_tb);
            Controls.Add(login_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private TextBox un_tb;
        private TextBox pw_tb;
        private Label label1;
    }
}