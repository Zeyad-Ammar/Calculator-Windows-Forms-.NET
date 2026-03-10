namespace CalculatorProject
{
    partial class frmCalculator
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
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnSubstract = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDivison = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabCurOperation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum1
            // 
            this.TxtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum1.Location = new System.Drawing.Point(12, 94);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(219, 30);
            this.TxtNum1.TabIndex = 0;
            this.TxtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(66, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 56);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSubstract
            // 
            this.BtnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubstract.Location = new System.Drawing.Point(313, 150);
            this.BtnSubstract.Name = "BtnSubstract";
            this.BtnSubstract.Size = new System.Drawing.Size(165, 56);
            this.BtnSubstract.TabIndex = 3;
            this.BtnSubstract.Text = "-";
            this.BtnSubstract.UseVisualStyleBackColor = true;
            this.BtnSubstract.Click += new System.EventHandler(this.BtnSubstract_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(66, 229);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(165, 56);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDivison
            // 
            this.BtnDivison.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivison.Location = new System.Drawing.Point(313, 229);
            this.BtnDivison.Name = "BtnDivison";
            this.BtnDivison.Size = new System.Drawing.Size(165, 56);
            this.BtnDivison.TabIndex = 5;
            this.BtnDivison.Text = "/";
            this.BtnDivison.UseVisualStyleBackColor = true;
            this.BtnDivison.Click += new System.EventHandler(this.BtnDivison_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEqual.FlatAppearance.BorderSize = 5;
            this.BtnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.Location = new System.Drawing.Point(66, 309);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(165, 56);
            this.BtnEqual.TabIndex = 6;
            this.BtnEqual.TabStop = false;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(313, 309);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(165, 56);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtNum2
            // 
            this.TxtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum2.Location = new System.Drawing.Point(309, 94);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(219, 30);
            this.TxtNum2.TabIndex = 1;
            this.TxtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum2_KeyPress);
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TxtResult.Enabled = false;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(583, 94);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(218, 30);
            this.TxtResult.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "=";
            // 
            // LabCurOperation
            // 
            this.LabCurOperation.AutoSize = true;
            this.LabCurOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCurOperation.Location = new System.Drawing.Point(243, 93);
            this.LabCurOperation.Name = "LabCurOperation";
            this.LabCurOperation.Size = new System.Drawing.Size(54, 32);
            this.LabCurOperation.TabIndex = 12;
            this.LabCurOperation.Text = "Op";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(814, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabCurOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnDivison);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnSubstract;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDivison;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabCurOperation;
        private System.Windows.Forms.Button button1;
    }
}

