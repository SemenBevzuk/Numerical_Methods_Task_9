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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.button_reset = new System.Windows.Forms.Button();
            this.button_trueSolution = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_TaskInfo = new System.Windows.Forms.DataGridView();
            this.comboBox_TaskSelector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_StepControl = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MetodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(422, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1457, 487);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBox_alfa
            // 
            this.textBox_alfa.Location = new System.Drawing.Point(316, 244);
            this.textBox_alfa.Name = "textBox_alfa";
            this.textBox_alfa.Size = new System.Drawing.Size(100, 26);
            this.textBox_alfa.TabIndex = 1;
            this.textBox_alfa.Text = "60";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Location = new System.Drawing.Point(315, 276);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(100, 26);
            this.textBox_sigma.TabIndex = 2;
            this.textBox_sigma.Text = "1";
            // 
            // textBox_x_0
            // 
            this.textBox_x_0.Location = new System.Drawing.Point(315, 311);
            this.textBox_x_0.Name = "textBox_x_0";
            this.textBox_x_0.Size = new System.Drawing.Size(100, 26);
            this.textBox_x_0.TabIndex = 3;
            this.textBox_x_0.Text = "0";
            // 
            // textBox_u_0
            // 
            this.textBox_u_0.Location = new System.Drawing.Point(315, 344);
            this.textBox_u_0.Name = "textBox_u_0";
            this.textBox_u_0.Size = new System.Drawing.Size(100, 26);
            this.textBox_u_0.TabIndex = 4;
            this.textBox_u_0.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "x_0 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "u_0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Угол разворота конуса (alfa):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Площадь отверстия (sigma):";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(1539, 505);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(340, 56);
            this.richTextBox_log.TabIndex = 9;
            this.richTextBox_log.Text = "";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(33, 508);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(383, 53);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Шаг интегрирования (h):";
            // 
            // textBox_h
            // 
            this.textBox_h.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_h.Location = new System.Drawing.Point(315, 376);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 26);
            this.textBox_h.TabIndex = 12;
            this.textBox_h.Text = "0,01";
            // 
            // textBox_eps
            // 
            this.textBox_eps.Location = new System.Drawing.Point(315, 408);
            this.textBox_eps.Name = "textBox_eps";
            this.textBox_eps.Size = new System.Drawing.Size(100, 26);
            this.textBox_eps.TabIndex = 14;
            this.textBox_eps.Text = "0,01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Контроль ЛП:";
            // 
            // textBox_max_iter
            // 
            this.textBox_max_iter.Location = new System.Drawing.Point(315, 440);
            this.textBox_max_iter.Name = "textBox_max_iter";
            this.textBox_max_iter.Size = new System.Drawing.Size(100, 26);
            this.textBox_max_iter.TabIndex = 16;
            this.textBox_max_iter.Text = "5000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Максимум итераций:";
            // 
            // dataGridView_MetodInfo
            // 
            this.dataGridView_MetodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MetodInfo.Location = new System.Drawing.Point(16, 694);
            this.dataGridView_MetodInfo.Name = "dataGridView_MetodInfo";
            this.dataGridView_MetodInfo.RowTemplate.Height = 28;
            this.dataGridView_MetodInfo.Size = new System.Drawing.Size(1863, 296);
            this.dataGridView_MetodInfo.TabIndex = 17;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(1227, 506);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(219, 55);
            this.button_reset.TabIndex = 20;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_trueSolution
            // 
            this.button_trueSolution.Location = new System.Drawing.Point(519, 508);
            this.button_trueSolution.Name = "button_trueSolution";
            this.button_trueSolution.Size = new System.Drawing.Size(243, 53);
            this.button_trueSolution.TabIndex = 21;
            this.button_trueSolution.Text = "Показать точное решение";
            this.button_trueSolution.UseVisualStyleBackColor = true;
            this.button_trueSolution.Click += new System.EventHandler(this.button_trueSolution_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 24;
            // 
            // dataGridView_TaskInfo
            // 
            this.dataGridView_TaskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaskInfo.Location = new System.Drawing.Point(16, 593);
            this.dataGridView_TaskInfo.Name = "dataGridView_TaskInfo";
            this.dataGridView_TaskInfo.RowTemplate.Height = 28;
            this.dataGridView_TaskInfo.Size = new System.Drawing.Size(1863, 83);
            this.dataGridView_TaskInfo.TabIndex = 25;
            // 
            // comboBox_TaskSelector
            // 
            this.comboBox_TaskSelector.FormattingEnabled = true;
            this.comboBox_TaskSelector.Location = new System.Drawing.Point(931, 529);
            this.comboBox_TaskSelector.Name = "comboBox_TaskSelector";
            this.comboBox_TaskSelector.Size = new System.Drawing.Size(147, 28);
            this.comboBox_TaskSelector.TabIndex = 26;
            this.comboBox_TaskSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskSelector_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(925, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "История испытаний";
            // 
            // checkBox_StepControl
            // 
            this.checkBox_StepControl.AutoSize = true;
            this.checkBox_StepControl.Checked = true;
            this.checkBox_StepControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StepControl.Location = new System.Drawing.Point(143, 475);
            this.checkBox_StepControl.Name = "checkBox_StepControl";
            this.checkBox_StepControl.Size = new System.Drawing.Size(158, 24);
            this.checkBox_StepControl.TabIndex = 28;
            this.checkBox_StepControl.Text = "Коррекция шага";
            this.checkBox_StepControl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1090);
            this.Controls.Add(this.checkBox_StepControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_TaskSelector);
            this.Controls.Add(this.dataGridView_TaskInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_trueSolution);
            this.Controls.Add(this.button_reset);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskInfo)).EndInit();
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
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_trueSolution;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_TaskInfo;
        private System.Windows.Forms.ComboBox comboBox_TaskSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_StepControl;
    }
}

