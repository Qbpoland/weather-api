namespace weather_api
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.get_data = new System.Windows.Forms.Button();
            this.wmo = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.wind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obecna temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prędkośc wiatru";
            this.label3.Click += new System.EventHandler(this.wind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aktualna pogoda";
            this.label2.Click += new System.EventHandler(this.wmo_Click);
            // 
            // get_data
            // 
            this.get_data.Location = new System.Drawing.Point(295, 72);
            this.get_data.Name = "get_data";
            this.get_data.Size = new System.Drawing.Size(131, 98);
            this.get_data.TabIndex = 3;
            this.get_data.Text = "pobierz";
            this.get_data.UseVisualStyleBackColor = true;
            this.get_data.Click += new System.EventHandler(this.get_data_Click);
            // 
            // wmo
            // 
            this.wmo.Location = new System.Drawing.Point(159, 108);
            this.wmo.Name = "wmo";
            this.wmo.ReadOnly = true;
            this.wmo.Size = new System.Drawing.Size(100, 23);
            this.wmo.TabIndex = 4;
            this.wmo.TextChanged += new System.EventHandler(this.wmo_TextChanged);
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(159, 72);
            this.temp.Name = "temp";
            this.temp.ReadOnly = true;
            this.temp.Size = new System.Drawing.Size(100, 23);
            this.temp.TabIndex = 5;
            this.temp.TextChanged += new System.EventHandler(this.temp_TextChanged);
            // 
            // wind
            // 
            this.wind.Location = new System.Drawing.Point(159, 147);
            this.wind.Name = "wind";
            this.wind.ReadOnly = true;
            this.wind.Size = new System.Drawing.Size(100, 23);
            this.wind.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data i godzina";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(295, 21);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(143, 23);
            this.date.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.wmo);
            this.Controls.Add(this.get_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button get_data;
        private TextBox wmo;
        private TextBox temp;
        private TextBox wind;
        private Label label4;
        private TextBox date;
    }
}