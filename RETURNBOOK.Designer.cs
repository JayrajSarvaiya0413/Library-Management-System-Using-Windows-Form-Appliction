﻿namespace JAYRAJ_RUBRIC_TASK_2
{
    partial class RETURNBOOK
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.button1.Location = new System.Drawing.Point(292, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 50);
            this.button1.TabIndex = 39;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox3.Location = new System.Drawing.Point(426, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 33);
            this.textBox3.TabIndex = 38;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox2.Location = new System.Drawing.Point(426, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 33);
            this.textBox2.TabIndex = 37;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.label2.Location = new System.Drawing.Point(160, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "       BOOK ID       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.label1.Location = new System.Drawing.Point(160, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "   STUDENT ID     ";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(228, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 51);
            this.button2.TabIndex = 40;
            this.button2.Text = "RETURN  BOOK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RETURNBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a1111;
            this.ClientSize = new System.Drawing.Size(753, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RETURNBOOK";
            this.Text = "RETURNBOOK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}