namespace Numerical_Methods_Task_9
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.textBox_alfa = new System.Windows.Forms.TextBox();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.textBox_x_0 = new System.Windows.Forms.TextBox();
            this.textBox_u_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_eps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_max_iter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_MetodInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MetodInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(361, 56);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1080, 533);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBox_alfa
            // 
            this.textBox_alfa.Location = new System.Drawing.Point(187, 100);
            this.textBox_alfa.Name = "textBox_alfa";
            this.textBox_alfa.Size = new System.Drawing.Size(100, 26);
            this.textBox_alfa.TabIndex = 1;
            this.textBox_alfa.Text = "30";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Location = new System.Drawing.Point(187, 132);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(100, 26);
            this.textBox_sigma.TabIndex = 2;
            this.textBox_sigma.Text = "1";
            // 
            // textBox_x_0
            // 
            this.textBox_x_0.Location = new System.Drawing.Point(187, 164);
            this.textBox_x_0.Name = "textBox_x_0";
            this.textBox_x_0.Size = new System.Drawing.Size(100, 26);
            this.textBox_x_0.TabIndex = 3;
            this.textBox_x_0.Text = "0";
            // 
            // textBox_u_0
            // 
            this.textBox_u_0.Location = new System.Drawing.Point(187, 197);
            this.textBox_u_0.Name = "textBox_u_0";
            this.textBox_u_0.Size = new System.Drawing.Size(100, 26);
            this.textBox_u_0.TabIndex = 4;
            this.textBox_u_0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "x_0 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "u_0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "alfa = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "sigma = ";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(43, 405);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(244, 67);
            this.richTextBox_log.TabIndex = 9;
            this.richTextBox_log.Text = "";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(117, 346);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(170, 53);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "h =";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(187, 229);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 26);
            this.textBox_h.TabIndex = 12;
            this.textBox_h.Text = "0,1";
            // 
            // textBox_eps
            // 
            this.textBox_eps.Location = new System.Drawing.Point(187, 261);
            this.textBox_eps.Name = "textBox_eps";
            this.textBox_eps.Size = new System.Drawing.Size(100, 26);
            this.textBox_eps.TabIndex = 14;
            this.textBox_eps.Text = "0,01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "eps =";
            // 
            // textBox_max_iter
            // 
            this.textBox_max_iter.Location = new System.Drawing.Point(187, 293);
            this.textBox_max_iter.Name = "textBox_max_iter";
            this.textBox_max_iter.Size = new System.Drawing.Size(100, 26);
            this.textBox_max_iter.TabIndex = 16;
            this.textBox_max_iter.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Макс шагов";
            // 
            // dataGridView_MetodInfo
            // 
            this.dataGridView_MetodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MetodInfo.Location = new System.Drawing.Point(74, 645);
            this.dataGridView_MetodInfo.Name = "dataGridView_MetodInfo";
            this.dataGridView_MetodInfo.RowTemplate.Height = 28;
            this.dataGridView_MetodInfo.Size = new System.Drawing.Size(1354, 421);
            this.dataGridView_MetodInfo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 1090);
            this.Controls.Add(this.dataGridView_MetodInfo);
            this.Controls.Add(this.textBox_max_iter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_eps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_u_0);
            this.Controls.Add(this.textBox_x_0);
            this.Controls.Add(this.textBox_sigma);
            this.Controls.Add(this.textBox_alfa);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MetodInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBox_alfa;
        private System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.TextBox textBox_x_0;
        private System.Windows.Forms.TextBox textBox_u_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_eps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_max_iter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_MetodInfo;
    }
}

