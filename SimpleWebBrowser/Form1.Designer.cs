namespace SimpleWebBrowser
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.addressbar = new System.Windows.Forms.TextBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.forwardbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 54);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1215, 621);
            this.webBrowser.TabIndex = 0;
            // 
            // addressbar
            // 
            this.addressbar.Location = new System.Drawing.Point(13, 13);
            this.addressbar.Name = "addressbar";
            this.addressbar.Size = new System.Drawing.Size(476, 22);
            this.addressbar.TabIndex = 1;
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(496, 13);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(140, 23);
            this.loadbutton.TabIndex = 2;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(642, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(110, 24);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // forwardbutton
            // 
            this.forwardbutton.Location = new System.Drawing.Point(758, 12);
            this.forwardbutton.Name = "forwardbutton";
            this.forwardbutton.Size = new System.Drawing.Size(102, 24);
            this.forwardbutton.TabIndex = 4;
            this.forwardbutton.Text = "Forward";
            this.forwardbutton.UseVisualStyleBackColor = true;
            this.forwardbutton.Click += new System.EventHandler(this.forwardbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 687);
            this.Controls.Add(this.forwardbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.addressbar);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox addressbar;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button forwardbutton;
    }
}

