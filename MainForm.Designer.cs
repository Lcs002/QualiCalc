namespace QualiCalc
{
    partial class MainForm
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
            this.BtnPareto = new System.Windows.Forms.Button();
            this.BtnVCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPareto
            // 
            this.BtnPareto.Location = new System.Drawing.Point(12, 12);
            this.BtnPareto.Name = "BtnPareto";
            this.BtnPareto.Size = new System.Drawing.Size(66, 21);
            this.BtnPareto.TabIndex = 0;
            this.BtnPareto.Text = "Pareto";
            this.BtnPareto.UseVisualStyleBackColor = true;
            // 
            // BtnVCC
            // 
            this.BtnVCC.Location = new System.Drawing.Point(128, 12);
            this.BtnVCC.Name = "BtnVCC";
            this.BtnVCC.Size = new System.Drawing.Size(75, 23);
            this.BtnVCC.TabIndex = 1;
            this.BtnVCC.Text = "button1";
            this.BtnVCC.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 648);
            this.Controls.Add(this.BtnVCC);
            this.Controls.Add(this.BtnPareto);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnPareto;
        private Button BtnVCC;
    }
}