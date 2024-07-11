namespace ColorToHexToolApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtColorName = new TextBox();
            txtHexCode = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 28);
            label1.TabIndex = 5;
            label1.Text = "Convert Color To Hex Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "Color Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 169);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Hex Code:";
            // 
            // txtColorName
            // 
            txtColorName.Location = new Point(159, 86);
            txtColorName.Name = "txtColorName";
            txtColorName.Size = new Size(174, 27);
            txtColorName.TabIndex = 8;
            // 
            // txtHexCode
            // 
            txtHexCode.Enabled = false;
            txtHexCode.Location = new Point(159, 166);
            txtHexCode.Name = "txtHexCode";
            txtHexCode.Size = new Size(174, 27);
            txtHexCode.TabIndex = 9;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(365, 85);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 10;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 324);
            Controls.Add(btnConvert);
            Controls.Add(txtHexCode);
            Controls.Add(txtColorName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtColorName;
        private TextBox txtHexCode;
        private Button btnConvert;
    }
}
