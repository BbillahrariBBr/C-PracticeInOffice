namespace WinFormApp
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
            this.elementUC = new System.Windows.Forms.Integration.ElementHost();
            this.user1 = new Uc.user();
            this.btnWinform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elementUC
            // 
            this.elementUC.Location = new System.Drawing.Point(12, 12);
            this.elementUC.Name = "elementUC";
            this.elementUC.Size = new System.Drawing.Size(342, 174);
            this.elementUC.TabIndex = 0;
            this.elementUC.Text = "UC WPF";
            this.elementUC.Child = this.user1;
            // 
            // btnWinform
            // 
            this.btnWinform.Location = new System.Drawing.Point(508, 44);
            this.btnWinform.Name = "btnWinform";
            this.btnWinform.Size = new System.Drawing.Size(140, 52);
            this.btnWinform.TabIndex = 1;
            this.btnWinform.Text = "Win Form Button";
            this.btnWinform.UseVisualStyleBackColor = true;
            this.btnWinform.Click += new System.EventHandler(this.btnWinform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWinform);
            this.Controls.Add(this.elementUC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementUC;
        private Uc.user user1;
        private System.Windows.Forms.Button btnWinform;
    }
}

