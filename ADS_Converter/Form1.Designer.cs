namespace ADS_Converter
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
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.Convertbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.Evaluatebtn = new System.Windows.Forms.Button();
            this.Evaluatelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PostFixlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.Location = new System.Drawing.Point(195, 22);
            this.ExpressionTextBox.Multiline = true;
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.Size = new System.Drawing.Size(335, 44);
            this.ExpressionTextBox.TabIndex = 0;
            // 
            // Convertbtn
            // 
            this.Convertbtn.Location = new System.Drawing.Point(61, 92);
            this.Convertbtn.Name = "Convertbtn";
            this.Convertbtn.Size = new System.Drawing.Size(92, 55);
            this.Convertbtn.TabIndex = 1;
            this.Convertbtn.Text = "Convert To Fully Paranthises";
            this.Convertbtn.UseVisualStyleBackColor = true;
            this.Convertbtn.Click += new System.EventHandler(this.Convertbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Resultlbl.Location = new System.Drawing.Point(177, 92);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(339, 75);
            this.Resultlbl.TabIndex = 2;
            // 
            // Evaluatebtn
            // 
            this.Evaluatebtn.Location = new System.Drawing.Point(61, 287);
            this.Evaluatebtn.Name = "Evaluatebtn";
            this.Evaluatebtn.Size = new System.Drawing.Size(92, 31);
            this.Evaluatebtn.TabIndex = 3;
            this.Evaluatebtn.Text = "Evaluate";
            this.Evaluatebtn.UseVisualStyleBackColor = true;
            this.Evaluatebtn.Click += new System.EventHandler(this.Evaluatebtn_Click);
            // 
            // Evaluatelbl
            // 
            this.Evaluatelbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Evaluatelbl.Location = new System.Drawing.Point(177, 287);
            this.Evaluatelbl.Name = "Evaluatelbl";
            this.Evaluatelbl.Size = new System.Drawing.Size(339, 74);
            this.Evaluatelbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "InFix Expression :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert To PostFix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostFixlbl
            // 
            this.PostFixlbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.PostFixlbl.Location = new System.Drawing.Point(177, 175);
            this.PostFixlbl.Name = "PostFixlbl";
            this.PostFixlbl.Size = new System.Drawing.Size(339, 90);
            this.PostFixlbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 387);
            this.Controls.Add(this.PostFixlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Evaluatelbl);
            this.Controls.Add(this.Evaluatebtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Convertbtn);
            this.Controls.Add(this.ExpressionTextBox);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExpressionTextBox;
        private System.Windows.Forms.Button Convertbtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button Evaluatebtn;
        private System.Windows.Forms.Label Evaluatelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PostFixlbl;
    }
}

