namespace SmallDown
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_30min = new System.Windows.Forms.Button();
            this.btn_1hour = new System.Windows.Forms.Button();
            this.btn_2hour = new System.Windows.Forms.Button();
            this.btn_3hour = new System.Windows.Forms.Button();
            this.num_minute = new System.Windows.Forms.NumericUpDown();
            this.num_hour = new System.Windows.Forms.NumericUpDown();
            this.lb_minute = new System.Windows.Forms.Label();
            this.lb_hour = new System.Windows.Forms.Label();
            this.btn_own_set = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_3hour);
            this.groupBox1.Controls.Add(this.btn_2hour);
            this.groupBox1.Controls.Add(this.btn_1hour);
            this.groupBox1.Controls.Add(this.btn_30min);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Shutdown";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_own_set);
            this.groupBox2.Controls.Add(this.lb_hour);
            this.groupBox2.Controls.Add(this.lb_minute);
            this.groupBox2.Controls.Add(this.num_hour);
            this.groupBox2.Controls.Add(this.num_minute);
            this.groupBox2.Location = new System.Drawing.Point(189, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Own Shutdown";
            // 
            // btn_30min
            // 
            this.btn_30min.Location = new System.Drawing.Point(7, 20);
            this.btn_30min.Name = "btn_30min";
            this.btn_30min.Size = new System.Drawing.Size(157, 23);
            this.btn_30min.TabIndex = 0;
            this.btn_30min.Text = "30 Minutes";
            this.btn_30min.UseVisualStyleBackColor = true;
            this.btn_30min.Click += new System.EventHandler(this.btn_30min_Click);
            // 
            // btn_1hour
            // 
            this.btn_1hour.Location = new System.Drawing.Point(6, 49);
            this.btn_1hour.Name = "btn_1hour";
            this.btn_1hour.Size = new System.Drawing.Size(157, 23);
            this.btn_1hour.TabIndex = 1;
            this.btn_1hour.Text = "1 Hour";
            this.btn_1hour.UseVisualStyleBackColor = true;
            this.btn_1hour.Click += new System.EventHandler(this.btn_1hour_Click);
            // 
            // btn_2hour
            // 
            this.btn_2hour.Location = new System.Drawing.Point(7, 78);
            this.btn_2hour.Name = "btn_2hour";
            this.btn_2hour.Size = new System.Drawing.Size(157, 23);
            this.btn_2hour.TabIndex = 2;
            this.btn_2hour.Text = "2 Hour";
            this.btn_2hour.UseVisualStyleBackColor = true;
            this.btn_2hour.Click += new System.EventHandler(this.btn_2hour_Click);
            // 
            // btn_3hour
            // 
            this.btn_3hour.Location = new System.Drawing.Point(7, 107);
            this.btn_3hour.Name = "btn_3hour";
            this.btn_3hour.Size = new System.Drawing.Size(157, 23);
            this.btn_3hour.TabIndex = 3;
            this.btn_3hour.Text = "3 Hour";
            this.btn_3hour.UseVisualStyleBackColor = true;
            this.btn_3hour.Click += new System.EventHandler(this.btn_3hour_Click);
            // 
            // num_minute
            // 
            this.num_minute.Location = new System.Drawing.Point(51, 21);
            this.num_minute.Name = "num_minute";
            this.num_minute.Size = new System.Drawing.Size(57, 20);
            this.num_minute.TabIndex = 0;
            // 
            // num_hour
            // 
            this.num_hour.Location = new System.Drawing.Point(51, 49);
            this.num_hour.Name = "num_hour";
            this.num_hour.Size = new System.Drawing.Size(57, 20);
            this.num_hour.TabIndex = 1;
            // 
            // lb_minute
            // 
            this.lb_minute.AutoSize = true;
            this.lb_minute.Location = new System.Drawing.Point(6, 24);
            this.lb_minute.Name = "lb_minute";
            this.lb_minute.Size = new System.Drawing.Size(39, 13);
            this.lb_minute.TabIndex = 2;
            this.lb_minute.Text = "Minute";
            // 
            // lb_hour
            // 
            this.lb_hour.AutoSize = true;
            this.lb_hour.Location = new System.Drawing.Point(9, 51);
            this.lb_hour.Name = "lb_hour";
            this.lb_hour.Size = new System.Drawing.Size(30, 13);
            this.lb_hour.TabIndex = 3;
            this.lb_hour.Text = "Hour";
            // 
            // btn_own_set
            // 
            this.btn_own_set.Location = new System.Drawing.Point(7, 106);
            this.btn_own_set.Name = "btn_own_set";
            this.btn_own_set.Size = new System.Drawing.Size(105, 23);
            this.btn_own_set.TabIndex = 4;
            this.btn_own_set.Text = "Set";
            this.btn_own_set.UseVisualStyleBackColor = true;
            this.btn_own_set.Click += new System.EventHandler(this.btn_own_set_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 160);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "SmallDown";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_3hour;
        private System.Windows.Forms.Button btn_2hour;
        private System.Windows.Forms.Button btn_1hour;
        private System.Windows.Forms.Button btn_30min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_own_set;
        private System.Windows.Forms.Label lb_hour;
        private System.Windows.Forms.Label lb_minute;
        private System.Windows.Forms.NumericUpDown num_hour;
        private System.Windows.Forms.NumericUpDown num_minute;
    }
}

