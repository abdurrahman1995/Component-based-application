﻿namespace ARFur
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_fifp = new System.Windows.Forms.Button();
            this.btn_senp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tenp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AirRealFur Furniture";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_fifp);
            this.groupBox1.Controls.Add(this.btn_senp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_tenp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_fifp
            // 
            this.btn_fifp.BackColor = System.Drawing.Color.LightGray;
            this.btn_fifp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_fifp.Location = new System.Drawing.Point(238, 122);
            this.btn_fifp.Name = "btn_fifp";
            this.btn_fifp.Size = new System.Drawing.Size(56, 38);
            this.btn_fifp.TabIndex = 7;
            this.btn_fifp.Text = "50%";
            this.btn_fifp.UseVisualStyleBackColor = false;
            this.btn_fifp.Click += new System.EventHandler(this.btn_fifp_Click);
            // 
            // btn_senp
            // 
            this.btn_senp.BackColor = System.Drawing.Color.LightGray;
            this.btn_senp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_senp.Location = new System.Drawing.Point(238, 166);
            this.btn_senp.Name = "btn_senp";
            this.btn_senp.Size = new System.Drawing.Size(56, 35);
            this.btn_senp.TabIndex = 6;
            this.btn_senp.Text = "70%";
            this.btn_senp.UseVisualStyleBackColor = false;
            this.btn_senp.Click += new System.EventHandler(this.btn_senp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Select Discount";
            // 
            // btn_tenp
            // 
            this.btn_tenp.BackColor = System.Drawing.Color.LightGray;
            this.btn_tenp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tenp.Location = new System.Drawing.Point(238, 32);
            this.btn_tenp.Name = "btn_tenp";
            this.btn_tenp.Size = new System.Drawing.Size(56, 40);
            this.btn_tenp.TabIndex = 4;
            this.btn_tenp.Text = "10%";
            this.btn_tenp.UseVisualStyleBackColor = false;
            this.btn_tenp.Click += new System.EventHandler(this.btn_tenp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select furniture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chair: Rs 25 000",
            "Arm chair: Rs 150 000",
            "Sofa: Rs 50 000",
            "Stand Fan: Rs 60 000",
            "Bed: Rs 70 000"});
            this.comboBox1.Location = new System.Drawing.Point(30, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(238, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "20%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(444, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fifp;
        private System.Windows.Forms.Button btn_senp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_tenp;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

