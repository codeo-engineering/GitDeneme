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
            this.gulserButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gulserButton
            // 
            this.gulserButton.Location = new System.Drawing.Point(233, 31);
            this.gulserButton.Margin = new System.Windows.Forms.Padding(2);
            this.gulserButton.Name = "gulserButton";
            this.gulserButton.Size = new System.Drawing.Size(112, 70);
            this.gulserButton.TabIndex = 1;
            this.gulserButton.Text = "button2";
            this.gulserButton.UseVisualStyleBackColor = true;
            this.gulserButton.Click += new System.EventHandler(this.gulserButton_Click);
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "devrim btn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 288);
            this.Controls.Add(this.gulserButton);
            this.ClientSize = new System.Drawing.Size(342, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gulserButton;
        private System.Windows.Forms.Button button2;
    }
}

