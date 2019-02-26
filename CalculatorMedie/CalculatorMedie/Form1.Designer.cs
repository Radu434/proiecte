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
            this.btnIntroducere = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cbTeza = new System.Windows.Forms.CheckBox();
            this.txtTeza = new System.Windows.Forms.TextBox();
            this.lblMedie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstNote = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 38);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(179, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnIntroducere
            // 
            this.btnIntroducere.Location = new System.Drawing.Point(360, 38);
            this.btnIntroducere.Name = "btnIntroducere";
            this.btnIntroducere.Size = new System.Drawing.Size(116, 51);
            this.btnIntroducere.TabIndex = 2;
            this.btnIntroducere.Text = "Adauga";
            this.btnIntroducere.UseVisualStyleBackColor = true;
            this.btnIntroducere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(360, 241);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 51);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reseteaza";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(360, 95);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(116, 51);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(360, 185);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(116, 51);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cbTeza
            // 
            this.cbTeza.AutoSize = true;
            this.cbTeza.Location = new System.Drawing.Point(58, 398);
            this.cbTeza.Name = "cbTeza";
            this.cbTeza.Size = new System.Drawing.Size(62, 21);
            this.cbTeza.TabIndex = 6;
            this.cbTeza.Text = "Teza";
            this.cbTeza.UseVisualStyleBackColor = true;
            this.cbTeza.CheckedChanged += new System.EventHandler(this.cbTeza_CheckedChanged);
            // 
            // txtTeza
            // 
            this.txtTeza.Location = new System.Drawing.Point(376, 396);
            this.txtTeza.Name = "txtTeza";
            this.txtTeza.Size = new System.Drawing.Size(100, 22);
            this.txtTeza.TabIndex = 7;
            this.txtTeza.TextChanged += new System.EventHandler(this.txtTeza_TextChanged);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.BackColor = System.Drawing.Color.Transparent;
            this.lblMedie.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedie.Location = new System.Drawing.Point(120, 456);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(0, 20);
            this.lblMedie.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Introducere note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nota Teza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Media:";
            // 
            // lstNote
            // 
            this.lstNote.FormattingEnabled = true;
            this.lstNote.ItemHeight = 16;
            this.lstNote.Location = new System.Drawing.Point(58, 112);
            this.lstNote.Name = "lstNote";
            this.lstNote.Size = new System.Drawing.Size(179, 180);
            this.lstNote.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 505);
            this.Controls.Add(this.lstNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.txtTeza);
            this.Controls.Add(this.cbTeza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIntroducere);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnIntroducere;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.CheckBox cbTeza;
        private System.Windows.Forms.TextBox txtTeza;
        private System.Windows.Forms.Label lblMedie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstNote;
    }
}

