namespace JAYRAJ_RUBRIC_TASK_2
{
    partial class ISSUEBOOKINFO
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.label2.Location = new System.Drawing.Point(219, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "   BOOK ISSUE BY STUDENT  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.label1.Location = new System.Drawing.Point(214, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "     SELECT STUDENT NAME    ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(206, 400);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 132);
            this.listBox1.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(387, 34);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a111111;
            this.button1.Location = new System.Drawing.Point(197, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 51);
            this.button1.TabIndex = 46;
            this.button1.Text = "ISSUE BOOK INFORMATION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ISSUEBOOKINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::JAYRAJ_RUBRIC_TASK_2.Properties.Resources.a1111;
            this.ClientSize = new System.Drawing.Size(760, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ISSUEBOOKINFO";
            this.Text = "ISSUEBOOKINFO";
            this.Load += new System.EventHandler(this.ISSUEBOOKINFO_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}