namespace CalculatorMedie
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.btnIntroducere = new System.Windows.Forms.Button();
            this.btnReseteaza = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 38);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(179, 22);
            this.txtInput.TabIndex = 0;
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(58, 112);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(179, 181);
            this.rtxtOutput.TabIndex = 1;
            this.rtxtOutput.Text = "";
            this.rtxtOutput.TextChanged += new System.EventHandler(this.rtxtOutput_TextChanged);
            // 
            // btnIntroducere
            // 
            this.btnIntroducere.Location = new System.Drawing.Point(385, 38);
            this.btnIntroducere.Name = "btnIntroducere";
            this.btnIntroducere.Size = new System.Drawing.Size(91, 39);
            this.btnIntroducere.TabIndex = 2;
            this.btnIntroducere.Text = "Introducere";
            this.btnIntroducere.UseVisualStyleBackColor = true;
            this.btnIntroducere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.Location = new System.Drawing.Point(385, 254);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(91, 39);
            this.btnReseteaza.TabIndex = 3;
            this.btnReseteaza.Text = "button2";
            this.btnReseteaza.UseVisualStyleBackColor = true;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(385, 112);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(91, 39);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "button3";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 505);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnReseteaza);
            this.Controls.Add(this.btnIntroducere);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Button btnIntroducere;
        private System.Windows.Forms.Button btnReseteaza;
        private System.Windows.Forms.Button btnCalculeaza;
    }
}

