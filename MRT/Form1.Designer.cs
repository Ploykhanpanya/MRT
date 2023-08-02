namespace MRT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startMRT = new System.Windows.Forms.ComboBox();
            this.endMRT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calMRT = new System.Windows.Forms.Button();
            this.clearMRT = new System.Windows.Forms.Button();
            this.priceMRT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeMRT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityMRT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityMRT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RSU", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "MRT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RSU", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "โปรแกรมคำนวณค่าโดยสาร MRTโปรแกรมคำนวณค่าโดยสาร MRT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "สถานีเริ่มต้น";
            // 
            // startMRT
            // 
            this.startMRT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startMRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMRT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMRT.FormattingEnabled = true;
            this.startMRT.Location = new System.Drawing.Point(189, 144);
            this.startMRT.Name = "startMRT";
            this.startMRT.Size = new System.Drawing.Size(206, 38);
            this.startMRT.TabIndex = 3;
            this.startMRT.SelectedIndexChanged += new System.EventHandler(this.startMRT_SelectedIndexChanged);
            // 
            // endMRT
            // 
            this.endMRT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.endMRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endMRT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMRT.FormattingEnabled = true;
            this.endMRT.Location = new System.Drawing.Point(189, 213);
            this.endMRT.Name = "endMRT";
            this.endMRT.Size = new System.Drawing.Size(206, 38);
            this.endMRT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "สถานีปลายทาง";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "จำนวนคน";
            // 
            // calMRT
            // 
            this.calMRT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calMRT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calMRT.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calMRT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.calMRT.Location = new System.Drawing.Point(140, 345);
            this.calMRT.Name = "calMRT";
            this.calMRT.Size = new System.Drawing.Size(106, 41);
            this.calMRT.TabIndex = 8;
            this.calMRT.Text = "คำนวณ";
            this.calMRT.UseVisualStyleBackColor = false;
            this.calMRT.Click += new System.EventHandler(this.calMRT_Click);
            // 
            // clearMRT
            // 
            this.clearMRT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearMRT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearMRT.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMRT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearMRT.Location = new System.Drawing.Point(340, 345);
            this.clearMRT.Name = "clearMRT";
            this.clearMRT.Size = new System.Drawing.Size(106, 41);
            this.clearMRT.TabIndex = 9;
            this.clearMRT.Text = "เคลียร์";
            this.clearMRT.UseVisualStyleBackColor = false;
            this.clearMRT.Click += new System.EventHandler(this.clearMRT_Click);
            // 
            // priceMRT
            // 
            this.priceMRT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceMRT.Location = new System.Drawing.Point(189, 428);
            this.priceMRT.Name = "priceMRT";
            this.priceMRT.ReadOnly = true;
            this.priceMRT.Size = new System.Drawing.Size(206, 36);
            this.priceMRT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "ราคา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "บาท";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 484);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "นาที";
            // 
            // timeMRT
            // 
            this.timeMRT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMRT.Location = new System.Drawing.Point(189, 484);
            this.timeMRT.Name = "timeMRT";
            this.timeMRT.ReadOnly = true;
            this.timeMRT.Size = new System.Drawing.Size(206, 36);
            this.timeMRT.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 484);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 35);
            this.label9.TabIndex = 13;
            this.label9.Text = "เวลาเดินทาง";
            // 
            // quantityMRT
            // 
            this.quantityMRT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quantityMRT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityMRT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityMRT.Location = new System.Drawing.Point(189, 292);
            this.quantityMRT.Name = "quantityMRT";
            this.quantityMRT.Size = new System.Drawing.Size(206, 32);
            this.quantityMRT.TabIndex = 17;
            this.quantityMRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityMRT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(600, 562);
            this.Controls.Add(this.quantityMRT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeMRT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceMRT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearMRT);
            this.Controls.Add(this.calMRT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endMRT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startMRT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("RSU", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "โปรแกรมคำนวณค่าโดยสาร MRT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityMRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox startMRT;
        private System.Windows.Forms.ComboBox endMRT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calMRT;
        private System.Windows.Forms.Button clearMRT;
        private System.Windows.Forms.TextBox priceMRT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeMRT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown quantityMRT;
    }
}

