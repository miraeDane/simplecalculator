namespace Calculator
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
            textBox1 = new TextBox();
            label1 = new Label();
            n0 = new Button();
            decimalPnt = new Button();
            clear = new Button();
            n1 = new Button();
            n4 = new Button();
            n5 = new Button();
            n3 = new Button();
            n2 = new Button();
            n8 = new Button();
            n9 = new Button();
            n7 = new Button();
            n6 = new Button();
            add = new Button();
            sub = new Button();
            mul = new Button();
            div = new Button();
            equals = new Button();
            backspace = new Button();
            total = new Label();
            parOpen = new Button();
            parClose = new Button();
            exponent = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(65, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(564, 125);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(561, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 1;
            // 
            // n0
            // 
            n0.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n0.Location = new Point(65, 198);
            n0.Name = "n0";
            n0.Size = new Size(106, 74);
            n0.TabIndex = 3;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            // 
            // decimalPnt
            // 
            decimalPnt.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            decimalPnt.Location = new Point(178, 198);
            decimalPnt.Name = "decimalPnt";
            decimalPnt.Size = new Size(106, 74);
            decimalPnt.TabIndex = 4;
            decimalPnt.Text = ".";
            decimalPnt.UseVisualStyleBackColor = true;
            decimalPnt.Click += decimalPnt_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.LightCoral;
            clear.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            clear.Location = new Point(523, 308);
            clear.Name = "clear";
            clear.Size = new Size(106, 74);
            clear.TabIndex = 5;
            clear.Text = "c";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // n1
            // 
            n1.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n1.Location = new Point(65, 308);
            n1.Name = "n1";
            n1.Size = new Size(106, 74);
            n1.TabIndex = 6;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // n4
            // 
            n4.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n4.Location = new Point(404, 308);
            n4.Name = "n4";
            n4.Size = new Size(106, 74);
            n4.TabIndex = 10;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n5.Location = new Point(65, 418);
            n5.Name = "n5";
            n5.Size = new Size(106, 74);
            n5.TabIndex = 9;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            // 
            // n3
            // 
            n3.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n3.Location = new Point(291, 308);
            n3.Name = "n3";
            n3.Size = new Size(106, 74);
            n3.TabIndex = 8;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // n2
            // 
            n2.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n2.Location = new Point(178, 308);
            n2.Name = "n2";
            n2.Size = new Size(106, 74);
            n2.TabIndex = 7;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n8
            // 
            n8.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n8.Location = new Point(404, 418);
            n8.Name = "n8";
            n8.Size = new Size(106, 74);
            n8.TabIndex = 14;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n9.Location = new Point(64, 523);
            n9.Name = "n9";
            n9.Size = new Size(106, 74);
            n9.TabIndex = 13;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n9_Click;
            // 
            // n7
            // 
            n7.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n7.Location = new Point(291, 418);
            n7.Name = "n7";
            n7.Size = new Size(106, 74);
            n7.TabIndex = 12;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n7_Click;
            // 
            // n6
            // 
            n6.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            n6.Location = new Point(178, 418);
            n6.Name = "n6";
            n6.Size = new Size(106, 74);
            n6.TabIndex = 11;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.GradientInactiveCaption;
            add.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            add.Location = new Point(523, 520);
            add.Name = "add";
            add.Size = new Size(106, 74);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.GradientInactiveCaption;
            sub.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            sub.Location = new Point(176, 520);
            sub.Name = "sub";
            sub.Size = new Size(106, 74);
            sub.TabIndex = 16;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += sub_Click;
            // 
            // mul
            // 
            mul.BackColor = SystemColors.GradientInactiveCaption;
            mul.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            mul.Location = new Point(405, 520);
            mul.Name = "mul";
            mul.Size = new Size(106, 74);
            mul.TabIndex = 17;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = false;
            mul.Click += mul_Click;
            // 
            // div
            // 
            div.BackColor = SystemColors.GradientInactiveCaption;
            div.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            div.Location = new Point(289, 520);
            div.Name = "div";
            div.Size = new Size(106, 74);
            div.TabIndex = 18;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // equals
            // 
            equals.BackColor = Color.FromArgb(255, 192, 128);
            equals.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            equals.Location = new Point(232, 614);
            equals.Name = "equals";
            equals.Size = new Size(393, 74);
            equals.TabIndex = 19;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            equals.Click += equals_Click;
            // 
            // backspace
            // 
            backspace.BackColor = SystemColors.ActiveBorder;
            backspace.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            backspace.Location = new Point(523, 418);
            backspace.Name = "backspace";
            backspace.Size = new Size(106, 74);
            backspace.TabIndex = 20;
            backspace.Text = "←";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += backspace_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = SystemColors.Window;
            total.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(92, 102);
            total.Name = "total";
            total.Size = new Size(33, 38);
            total.TabIndex = 2;
            total.Text = "0";
            total.Click += total_Click;
            // 
            // parOpen
            // 
            parOpen.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            parOpen.Location = new Point(291, 198);
            parOpen.Name = "parOpen";
            parOpen.Size = new Size(106, 74);
            parOpen.TabIndex = 21;
            parOpen.Text = "(";
            parOpen.UseVisualStyleBackColor = true;
            parOpen.Click += parOpen_Click;
            // 
            // parClose
            // 
            parClose.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            parClose.Location = new Point(407, 198);
            parClose.Name = "parClose";
            parClose.Size = new Size(106, 74);
            parClose.TabIndex = 22;
            parClose.Text = ")";
            parClose.UseVisualStyleBackColor = true;
            parClose.Click += parClose_Click;
            // 
            // exponent
            // 
            exponent.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Bold);
            exponent.Location = new Point(523, 198);
            exponent.Name = "exponent";
            exponent.Size = new Size(106, 74);
            exponent.TabIndex = 23;
            exponent.Text = "^";
            exponent.UseVisualStyleBackColor = true;
            exponent.Click += exponent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(707, 798);
            Controls.Add(exponent);
            Controls.Add(parClose);
            Controls.Add(parOpen);
            Controls.Add(backspace);
            Controls.Add(equals);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(sub);
            Controls.Add(add);
            Controls.Add(n8);
            Controls.Add(n9);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n4);
            Controls.Add(n5);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(clear);
            Controls.Add(decimalPnt);
            Controls.Add(n0);
            Controls.Add(total);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button n0;
        private Button decimalPnt;
        private Button clear;
        private Button n1;
        private Button n4;
        private Button n5;
        private Button n3;
        private Button n2;
        private Button n8;
        private Button n9;
        private Button n7;
        private Button n6;
        private Button add;
        private Button sub;
        private Button mul;
        private Button div;
        private Button equals;
        private Button backspace;
        private Label total;
        private Button parOpen;
        private Button parClose;
        private Button exponent;
    }
}
