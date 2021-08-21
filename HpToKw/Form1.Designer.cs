
namespace HpToKw
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.chooseFromCb = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.valueTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseToCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(15, 182);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(266, 42);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // chooseFromCb
            // 
            this.chooseFromCb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFromCb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chooseFromCb.FormattingEnabled = true;
            this.chooseFromCb.Location = new System.Drawing.Point(330, 84);
            this.chooseFromCb.Name = "chooseFromCb";
            this.chooseFromCb.Size = new System.Drawing.Size(261, 38);
            this.chooseFromCb.TabIndex = 1;
            this.chooseFromCb.SelectedIndexChanged += new System.EventHandler(this.chooseCb_SelectedIndexChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(66, 308);
            this.resultLabel.MinimumSize = new System.Drawing.Size(500, 50);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(500, 50);
            this.resultLabel.TabIndex = 2;
            // 
            // valueTb
            // 
            this.valueTb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueTb.Location = new System.Drawing.Point(12, 86);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(269, 36);
            this.valueTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unit from:";
            // 
            // chooseToCb
            // 
            this.chooseToCb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseToCb.FormattingEnabled = true;
            this.chooseToCb.Location = new System.Drawing.Point(330, 187);
            this.chooseToCb.Name = "chooseToCb";
            this.chooseToCb.Size = new System.Drawing.Size(261, 38);
            this.chooseToCb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(330, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit to:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseToCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueTb);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.chooseFromCb);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.ComboBox chooseFromCb;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox valueTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseToCb;
        private System.Windows.Forms.Label label3;
    }
}

