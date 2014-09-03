namespace DecimalToBinary
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.DTB = new System.Windows.Forms.RadioButton();
            this.BTD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(12, 68);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 22);
            this.Number.TabIndex = 2;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(147, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(12, 93);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 12);
            this.Answer.TabIndex = 5;
            // 
            // DTB
            // 
            this.DTB.AutoSize = true;
            this.DTB.Checked = true;
            this.DTB.Location = new System.Drawing.Point(12, 12);
            this.DTB.Name = "DTB";
            this.DTB.Size = new System.Drawing.Size(112, 16);
            this.DTB.TabIndex = 7;
            this.DTB.TabStop = true;
            this.DTB.Text = "Decimal To Binary";
            this.DTB.UseVisualStyleBackColor = true;
            // 
            // BTD
            // 
            this.BTD.AutoSize = true;
            this.BTD.Location = new System.Drawing.Point(12, 34);
            this.BTD.Name = "BTD";
            this.BTD.Size = new System.Drawing.Size(112, 16);
            this.BTD.TabIndex = 8;
            this.BTD.Text = "Binary To Decimal";
            this.BTD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTD);
            this.Controls.Add(this.DTB);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Number);
            this.Name = "Form1";
            this.Text = "DecimalToBinary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.RadioButton DTB;
        private System.Windows.Forms.RadioButton BTD;
        private System.Windows.Forms.Label label1;
    }
}

