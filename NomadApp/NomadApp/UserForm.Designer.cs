namespace NomadApp
{
    partial class UserForm
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
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.UnSubscribeButton = new System.Windows.Forms.Button();
            this.CommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(108, 210);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(100, 40);
            this.SubscribeButton.TabIndex = 0;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // UnSubscribeButton
            // 
            this.UnSubscribeButton.Location = new System.Drawing.Point(343, 210);
            this.UnSubscribeButton.Name = "UnSubscribeButton";
            this.UnSubscribeButton.Size = new System.Drawing.Size(100, 40);
            this.UnSubscribeButton.TabIndex = 1;
            this.UnSubscribeButton.Text = "UnSubscribe";
            this.UnSubscribeButton.UseVisualStyleBackColor = true;
            this.UnSubscribeButton.Click += new System.EventHandler(this.UnSubscribeButton_Click);
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(548, 208);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(100, 40);
            this.CommitButton.TabIndex = 2;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.UnSubscribeButton);
            this.Controls.Add(this.SubscribeButton);
            this.Name = "UserForm";
            this.Text = "UserWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Button UnSubscribeButton;
        private System.Windows.Forms.Button CommitButton;
    }
}