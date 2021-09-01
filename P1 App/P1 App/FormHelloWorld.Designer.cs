
namespace P1_App
{
    partial class FormHelloWorld
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
            this.LabelHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelHelloWorld
            // 
            this.LabelHelloWorld.AutoSize = true;
            this.LabelHelloWorld.Location = new System.Drawing.Point(12, 9);
            this.LabelHelloWorld.Name = "LabelHelloWorld";
            this.LabelHelloWorld.Size = new System.Drawing.Size(88, 17);
            this.LabelHelloWorld.TabIndex = 0;
            this.LabelHelloWorld.Text = "Hello, World!";
            // 
            // FormHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.LabelHelloWorld);
            this.Name = "FormHelloWorld";
            this.Text = "CSC 470 - P1";
            this.Load += new System.EventHandler(this.FormHelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHelloWorld;
    }
}

