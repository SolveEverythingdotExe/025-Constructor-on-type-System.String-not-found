namespace MainApplication
{
    partial class ChildForm
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
            this.SuspendLayout();
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(321, 259);
            this.Name = "ChildForm";
            this.StringItems.Add("the");
            this.StringItems.Add("quick");
            this.StringItems.Add("brown");
            this.StringItems.Add("fox");
            this.StringItems.Add("jumps");
            this.StringItems.Add("over");
            this.StringItems.Add("the");
            this.StringItems.Add("lazy");
            this.StringItems.Add("dog");
            this.ResumeLayout(false);

        }

        #endregion
    }
}
