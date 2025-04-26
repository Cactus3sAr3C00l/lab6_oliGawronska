namespace lab6_oliGawronska
{
    partial class Form3
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
            this.x_textBox = new System.Windows.Forms.RichTextBox();
            this.y_textBox = new System.Windows.Forms.RichTextBox();
            this.dyd_textBox = new System.Windows.Forms.RichTextBox();
            this.croc_textBox = new System.Windows.Forms.RichTextBox();
            this.plane = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.szop = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(192, 130);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(77, 48);
            this.x_textBox.TabIndex = 0;
            this.x_textBox.Text = "";
            this.x_textBox.TextChanged += new System.EventHandler(this.x_textBox_TextChanged);
            // 
            // y_textBox
            // 
            this.y_textBox.Location = new System.Drawing.Point(192, 208);
            this.y_textBox.Name = "y_textBox";
            this.y_textBox.Size = new System.Drawing.Size(77, 48);
            this.y_textBox.TabIndex = 1;
            this.y_textBox.Text = "";
            this.y_textBox.TextChanged += new System.EventHandler(this.y_textBox_TextChanged);
            // 
            // dyd_textBox
            // 
            this.dyd_textBox.Location = new System.Drawing.Point(387, 130);
            this.dyd_textBox.Name = "dyd_textBox";
            this.dyd_textBox.Size = new System.Drawing.Size(77, 48);
            this.dyd_textBox.TabIndex = 2;
            this.dyd_textBox.Text = "";
            this.dyd_textBox.TextChanged += new System.EventHandler(this.dyd_textBox_TextChanged);
            // 
            // croc_textBox
            // 
            this.croc_textBox.Location = new System.Drawing.Point(537, 130);
            this.croc_textBox.Name = "croc_textBox";
            this.croc_textBox.Size = new System.Drawing.Size(77, 48);
            this.croc_textBox.TabIndex = 3;
            this.croc_textBox.Text = "";
            this.croc_textBox.TextChanged += new System.EventHandler(this.croc_textBox_TextChanged);
            // 
            // plane
            // 
            this.plane.AutoSize = true;
            this.plane.Location = new System.Drawing.Point(204, 89);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(65, 20);
            this.plane.TabIndex = 5;
            this.plane.Text = "Plansza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dydlefy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Krokodyle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Czas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(192, 343);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(422, 56);
            this.saveSettings.TabIndex = 11;
            this.saveSettings.Text = "Zapisz";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(540, 257);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(77, 48);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // szop
            // 
            this.szop.Location = new System.Drawing.Point(387, 257);
            this.szop.Name = "szop";
            this.szop.Size = new System.Drawing.Size(77, 48);
            this.szop.TabIndex = 13;
            this.szop.Text = "";
            this.szop.TextChanged += new System.EventHandler(this.szop_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Szopy";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.szop);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.croc_textBox);
            this.Controls.Add(this.dyd_textBox);
            this.Controls.Add(this.y_textBox);
            this.Controls.Add(this.x_textBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox x_textBox;
        private System.Windows.Forms.RichTextBox y_textBox;
        private System.Windows.Forms.RichTextBox dyd_textBox;
        private System.Windows.Forms.RichTextBox croc_textBox;
        private System.Windows.Forms.Label plane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox szop;
        private System.Windows.Forms.Label label6;
    }
}