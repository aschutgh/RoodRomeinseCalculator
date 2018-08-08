namespace RoodRomeinseCalculator
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.romeinsGetal1 = new System.Windows.Forms.TextBox();
            this.romeinsGetal2 = new System.Windows.Forms.TextBox();
            this.labelRomeinsgetal1 = new System.Windows.Forms.Label();
            this.labelRomeinsgetal2 = new System.Windows.Forms.Label();
            this.labelAntwoord = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(471, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 51);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(471, 102);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(90, 51);
            this.buttonSubtract.TabIndex = 1;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(471, 175);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(90, 51);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(471, 245);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(90, 51);
            this.buttonDivide.TabIndex = 3;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // romeinsGetal1
            // 
            this.romeinsGetal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romeinsGetal1.Location = new System.Drawing.Point(37, 80);
            this.romeinsGetal1.Name = "romeinsGetal1";
            this.romeinsGetal1.Size = new System.Drawing.Size(386, 29);
            this.romeinsGetal1.TabIndex = 4;
            this.romeinsGetal1.TextChanged += new System.EventHandler(this.romeinsGetal1_TextChanged);
            // 
            // romeinsGetal2
            // 
            this.romeinsGetal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romeinsGetal2.Location = new System.Drawing.Point(37, 169);
            this.romeinsGetal2.Name = "romeinsGetal2";
            this.romeinsGetal2.Size = new System.Drawing.Size(386, 29);
            this.romeinsGetal2.TabIndex = 5;
            this.romeinsGetal2.TextChanged += new System.EventHandler(this.romeinsGetal2_TextChanged);
            // 
            // labelRomeinsgetal1
            // 
            this.labelRomeinsgetal1.AutoSize = true;
            this.labelRomeinsgetal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRomeinsgetal1.Location = new System.Drawing.Point(34, 33);
            this.labelRomeinsgetal1.Name = "labelRomeinsgetal1";
            this.labelRomeinsgetal1.Size = new System.Drawing.Size(145, 24);
            this.labelRomeinsgetal1.TabIndex = 7;
            this.labelRomeinsgetal1.Text = "Romeins getal 1";
            // 
            // labelRomeinsgetal2
            // 
            this.labelRomeinsgetal2.AutoSize = true;
            this.labelRomeinsgetal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRomeinsgetal2.Location = new System.Drawing.Point(35, 129);
            this.labelRomeinsgetal2.Name = "labelRomeinsgetal2";
            this.labelRomeinsgetal2.Size = new System.Drawing.Size(145, 24);
            this.labelRomeinsgetal2.TabIndex = 8;
            this.labelRomeinsgetal2.Text = "Romeins getal 2";
            // 
            // labelAntwoord
            // 
            this.labelAntwoord.AutoSize = true;
            this.labelAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntwoord.Location = new System.Drawing.Point(36, 221);
            this.labelAntwoord.Name = "labelAntwoord";
            this.labelAntwoord.Size = new System.Drawing.Size(96, 24);
            this.labelAntwoord.TabIndex = 9;
            this.labelAntwoord.Text = "Antwoord:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(582, 25);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 51);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Leeg";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // labelResultaat
            // 
            this.labelResultaat.AutoSize = true;
            this.labelResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultaat.Location = new System.Drawing.Point(37, 255);
            this.labelResultaat.Name = "labelResultaat";
            this.labelResultaat.Size = new System.Drawing.Size(86, 24);
            this.labelResultaat.TabIndex = 11;
            this.labelResultaat.Text = "Resultaat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 333);
            this.Controls.Add(this.labelResultaat);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelAntwoord);
            this.Controls.Add(this.labelRomeinsgetal2);
            this.Controls.Add(this.labelRomeinsgetal1);
            this.Controls.Add(this.romeinsGetal2);
            this.Controls.Add(this.romeinsGetal1);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoodRomeinseCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.TextBox romeinsGetal1;
        private System.Windows.Forms.TextBox romeinsGetal2;
        private System.Windows.Forms.Label labelRomeinsgetal1;
        private System.Windows.Forms.Label labelRomeinsgetal2;
        private System.Windows.Forms.Label labelAntwoord;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelResultaat;
    }
}

