namespace Assignment
{
    partial class FormLanding
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
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnConv = new System.Windows.Forms.Button();
            this.btnDFT = new System.Windows.Forms.Button();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelXResult = new System.Windows.Forms.Label();
            this.labelHResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelYResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxConvResult = new System.Windows.Forms.TextBox();
            this.richTxtBoxDFTResult = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(221, 167);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 0;
            this.btnPlot.Text = "plot dft";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Visible = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(492, 219);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(91, 23);
            this.btnConv.TabIndex = 1;
            this.btnConv.Text = "convolve";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // btnDFT
            // 
            this.btnDFT.Location = new System.Drawing.Point(121, 167);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Size = new System.Drawing.Size(75, 23);
            this.btnDFT.TabIndex = 2;
            this.btnDFT.Text = "find dft";
            this.btnDFT.UseVisualStyleBackColor = true;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            // 
            // txtBoxH
            // 
            this.txtBoxH.Location = new System.Drawing.Point(492, 112);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(244, 20);
            this.txtBoxH.TabIndex = 3;
            this.txtBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxH_KeyPress);
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(492, 166);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(244, 20);
            this.txtBoxX.TabIndex = 4;
            this.txtBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "h[t] :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "x[t] :";
            // 
            // labelXResult
            // 
            this.labelXResult.AutoSize = true;
            this.labelXResult.Location = new System.Drawing.Point(489, 189);
            this.labelXResult.Name = "labelXResult";
            this.labelXResult.Size = new System.Drawing.Size(39, 13);
            this.labelXResult.TabIndex = 8;
            this.labelXResult.Text = "x_error";
            this.labelXResult.Visible = false;
            // 
            // labelHResult
            // 
            this.labelHResult.AutoSize = true;
            this.labelHResult.Location = new System.Drawing.Point(489, 135);
            this.labelHResult.Name = "labelHResult";
            this.labelHResult.Size = new System.Drawing.Size(40, 13);
            this.labelHResult.TabIndex = 9;
            this.labelHResult.Text = "h_error";
            this.labelHResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "y[t]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Convolution (y[t] = h[t] * x[t])";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Discrete Fourier Transform";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(121, 115);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(184, 20);
            this.txtBoxY.TabIndex = 13;
            this.txtBoxY.TextChanged += new System.EventHandler(this.txtBoxY_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "y[n] :";
            // 
            // labelYResult
            // 
            this.labelYResult.AutoSize = true;
            this.labelYResult.Location = new System.Drawing.Point(118, 138);
            this.labelYResult.Name = "labelYResult";
            this.labelYResult.Size = new System.Drawing.Size(39, 13);
            this.labelYResult.TabIndex = 15;
            this.labelYResult.Text = "y_error";
            this.labelYResult.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "DSP Center";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ans:";
            // 
            // txtBoxConvResult
            // 
            this.txtBoxConvResult.Location = new System.Drawing.Point(492, 270);
            this.txtBoxConvResult.Name = "txtBoxConvResult";
            this.txtBoxConvResult.Size = new System.Drawing.Size(244, 20);
            this.txtBoxConvResult.TabIndex = 19;
            this.txtBoxConvResult.Visible = false;
            // 
            // richTxtBoxDFTResult
            // 
            this.richTxtBoxDFTResult.Location = new System.Drawing.Point(121, 224);
            this.richTxtBoxDFTResult.Name = "richTxtBoxDFTResult";
            this.richTxtBoxDFTResult.Size = new System.Drawing.Size(241, 114);
            this.richTxtBoxDFTResult.TabIndex = 20;
            this.richTxtBoxDFTResult.Text = "";
            this.richTxtBoxDFTResult.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(118, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "NOTE: Please enter comma separated integers in the text boxes.";
            // 
            // FormLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 421);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTxtBoxDFTResult);
            this.Controls.Add(this.txtBoxConvResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelYResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHResult);
            this.Controls.Add(this.labelXResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxX);
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.btnDFT);
            this.Controls.Add(this.btnConv);
            this.Controls.Add(this.btnPlot);
            this.Name = "FormLanding";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelXResult;
        private System.Windows.Forms.Label labelHResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelYResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxConvResult;
        private System.Windows.Forms.RichTextBox richTxtBoxDFTResult;
        private System.Windows.Forms.Label label9;
    }
}

