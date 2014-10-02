namespace Task1
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SetColor = new System.Windows.Forms.Button();
            this.Y_INP_START = new System.Windows.Forms.TextBox();
            this.X_INP_START = new System.Windows.Forms.TextBox();
            this.X_INP_END = new System.Windows.Forms.TextBox();
            this.Y_INP_END = new System.Windows.Forms.TextBox();
            this.Draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LineStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetColor
            // 
            this.SetColor.Location = new System.Drawing.Point(69, 144);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(128, 25);
            this.SetColor.TabIndex = 4;
            this.SetColor.Text = "Задать цвет";
            this.SetColor.UseVisualStyleBackColor = true;
            this.SetColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Y_INP_START
            // 
            this.Y_INP_START.Location = new System.Drawing.Point(122, 29);
            this.Y_INP_START.Name = "Y_INP_START";
            this.Y_INP_START.Size = new System.Drawing.Size(75, 20);
            this.Y_INP_START.TabIndex = 1;
            // 
            // X_INP_START
            // 
            this.X_INP_START.Location = new System.Drawing.Point(122, 3);
            this.X_INP_START.Name = "X_INP_START";
            this.X_INP_START.Size = new System.Drawing.Size(75, 20);
            this.X_INP_START.TabIndex = 0;
            // 
            // X_INP_END
            // 
            this.X_INP_END.Location = new System.Drawing.Point(122, 65);
            this.X_INP_END.Name = "X_INP_END";
            this.X_INP_END.Size = new System.Drawing.Size(75, 20);
            this.X_INP_END.TabIndex = 2;
            // 
            // Y_INP_END
            // 
            this.Y_INP_END.Location = new System.Drawing.Point(122, 91);
            this.Y_INP_END.Name = "Y_INP_END";
            this.Y_INP_END.Size = new System.Drawing.Size(75, 20);
            this.Y_INP_END.TabIndex = 3;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(69, 212);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(128, 23);
            this.Draw.TabIndex = 5;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X начала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X конца:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y конца:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LineStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SetColor);
            this.panel1.Controls.Add(this.Y_INP_END);
            this.panel1.Controls.Add(this.X_INP_START);
            this.panel1.Controls.Add(this.X_INP_END);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Y_INP_START);
            this.panel1.Location = new System.Drawing.Point(501, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 265);
            this.panel1.TabIndex = 10;
            // 
            // LineStyle
            // 
            this.LineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineStyle.FormattingEnabled = true;
            this.LineStyle.Items.AddRange(new object[] {
            "normal",
            "dash",
            "dash-dot"});
            this.LineStyle.Location = new System.Drawing.Point(76, 117);
            this.LineStyle.Name = "LineStyle";
            this.LineStyle.Size = new System.Drawing.Size(121, 21);
            this.LineStyle.TabIndex = 11;
            this.LineStyle.SelectedIndexChanged += new System.EventHandler(this.LineStyle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Шаблон:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button SetColor;
        private System.Windows.Forms.TextBox Y_INP_START;
        private System.Windows.Forms.TextBox X_INP_START;
        private System.Windows.Forms.TextBox X_INP_END;
        private System.Windows.Forms.TextBox Y_INP_END;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox LineStyle;
        private System.Windows.Forms.Label label5;
    }
}

