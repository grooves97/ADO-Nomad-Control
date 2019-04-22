namespace NomadApp
{
    partial class AddComicsForm
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
            this.AddComicsButton = new System.Windows.Forms.Button();
            this.NameComicsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddComicsButton
            // 
            this.AddComicsButton.Location = new System.Drawing.Point(246, 194);
            this.AddComicsButton.Name = "AddComicsButton";
            this.AddComicsButton.Size = new System.Drawing.Size(109, 44);
            this.AddComicsButton.TabIndex = 0;
            this.AddComicsButton.Text = "AddComics";
            this.AddComicsButton.UseVisualStyleBackColor = true;
            this.AddComicsButton.Click += new System.EventHandler(this.AddComicsButton_Click);
            // 
            // NameComicsBox
            // 
            this.NameComicsBox.Location = new System.Drawing.Point(246, 121);
            this.NameComicsBox.Name = "NameComicsBox";
            this.NameComicsBox.Size = new System.Drawing.Size(109, 20);
            this.NameComicsBox.TabIndex = 1;
            // 
            // AddComicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameComicsBox);
            this.Controls.Add(this.AddComicsButton);
            this.Name = "AddComicsForm";
            this.Text = "AddComicsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddComicsButton;
        private System.Windows.Forms.TextBox NameComicsBox;
    }
}