namespace Git_Deneme
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
            this.button1 = new System.Windows.Forms.Button();
            this.devrimButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // devrimButton
            // 
            this.devrimButton.Location = new System.Drawing.Point(257, 38);
            this.devrimButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devrimButton.Name = "devrimButton";
            this.devrimButton.Size = new System.Drawing.Size(149, 86);
            this.devrimButton.TabIndex = 1;
            this.devrimButton.Text = "button2";
            this.devrimButton.UseVisualStyleBackColor = true;
            this.devrimButton.Click += new System.EventHandler(this.devrimButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(374, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.devrimButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button devrimButton;
        private System.Windows.Forms.Button button2;
    }
}

