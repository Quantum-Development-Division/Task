namespace _4thTask2
{
    partial class ExplainAll
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
            this.lblExplainName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExplainName
            // 
            this.lblExplainName.Font = new System.Drawing.Font("メイリオ", 15F);
            this.lblExplainName.Location = new System.Drawing.Point(12, 9);
            this.lblExplainName.Name = "lblExplainName";
            this.lblExplainName.Size = new System.Drawing.Size(291, 37);
            this.lblExplainName.TabIndex = 0;
            this.lblExplainName.Text = "あああ";
            // 
            // ExplainAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.ClientSize = new System.Drawing.Size(635, 690);
            this.Controls.Add(this.lblExplainName);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ExplainAll";
            this.Text = "ExplainAll";
            this.Load += new System.EventHandler(this.ExplainAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExplainName;
    }
}