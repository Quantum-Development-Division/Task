namespace _4thTask2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnSit = new System.Windows.Forms.Button();
            this.btnDance = new System.Windows.Forms.Button();
            this.btnGoExplan = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRePlain = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCategoryBack = new System.Windows.Forms.Button();
            this.btnCategoryNext = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.MenuStrip();
            this.tabBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicClassConcept = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicClassConstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicClassInstantiation = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicMethodConcept = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicMethodArgument = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBasicMethodReturnValue = new System.Windows.Forms.ToolStripMenuItem();
            this.メソッドToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUse = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(128, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Info;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(67, 423);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(365, 180);
            this.message.TabIndex = 1;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfo.Location = new System.Drawing.Point(128, 135);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(160, 26);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.Location = new System.Drawing.Point(305, 135);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(67, 25);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHi.Font = new System.Drawing.Font("メイリオ", 12F);
            this.btnHi.ForeColor = System.Drawing.Color.White;
            this.btnHi.Location = new System.Drawing.Point(67, 119);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(107, 41);
            this.btnHi.TabIndex = 4;
            this.btnHi.Text = "ハイ！";
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Visible = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnSit
            // 
            this.btnSit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSit.Font = new System.Drawing.Font("メイリオ", 12F);
            this.btnSit.ForeColor = System.Drawing.Color.White;
            this.btnSit.Location = new System.Drawing.Point(201, 119);
            this.btnSit.Name = "btnSit";
            this.btnSit.Size = new System.Drawing.Size(99, 41);
            this.btnSit.TabIndex = 5;
            this.btnSit.Text = "座る";
            this.btnSit.UseVisualStyleBackColor = false;
            this.btnSit.Visible = false;
            this.btnSit.Click += new System.EventHandler(this.btnSit_Click);
            // 
            // btnDance
            // 
            this.btnDance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDance.Font = new System.Drawing.Font("メイリオ", 12F);
            this.btnDance.ForeColor = System.Drawing.Color.White;
            this.btnDance.Location = new System.Drawing.Point(325, 119);
            this.btnDance.Name = "btnDance";
            this.btnDance.Size = new System.Drawing.Size(107, 41);
            this.btnDance.TabIndex = 6;
            this.btnDance.Text = "歩く";
            this.btnDance.UseVisualStyleBackColor = false;
            this.btnDance.Visible = false;
            this.btnDance.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // btnGoExplan
            // 
            this.btnGoExplan.BackColor = System.Drawing.Color.Olive;
            this.btnGoExplan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoExplan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoExplan.Location = new System.Drawing.Point(128, 59);
            this.btnGoExplan.Name = "btnGoExplan";
            this.btnGoExplan.Size = new System.Drawing.Size(244, 39);
            this.btnGoExplan.TabIndex = 7;
            this.btnGoExplan.Text = "説明に進む ⇒";
            this.btnGoExplan.UseVisualStyleBackColor = false;
            this.btnGoExplan.Click += new System.EventHandler(this.btnGoExplan_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("メイリオ", 15F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(67, 103);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 56);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "進む";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("メイリオ", 15F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(354, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 56);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRePlain
            // 
            this.btnRePlain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRePlain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRePlain.Font = new System.Drawing.Font("メイリオ", 13F);
            this.btnRePlain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRePlain.Location = new System.Drawing.Point(151, 43);
            this.btnRePlain.Name = "btnRePlain";
            this.btnRePlain.Size = new System.Drawing.Size(199, 56);
            this.btnRePlain.TabIndex = 10;
            this.btnRePlain.Tag = "もう一度説明を聞く";
            this.btnRePlain.Text = "もう一度説明を聞く";
            this.btnRePlain.UseVisualStyleBackColor = false;
            this.btnRePlain.Visible = false;
            this.btnRePlain.Click += new System.EventHandler(this.btnRePlain_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAll.Font = new System.Drawing.Font("メイリオ", 15F);
            this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAll.Location = new System.Drawing.Point(211, 104);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(77, 56);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "全て";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Visible = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCategoryBack
            // 
            this.btnCategoryBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCategoryBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoryBack.Font = new System.Drawing.Font("メイリオ", 15F);
            this.btnCategoryBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoryBack.Location = new System.Drawing.Point(354, 43);
            this.btnCategoryBack.Name = "btnCategoryBack";
            this.btnCategoryBack.Size = new System.Drawing.Size(78, 56);
            this.btnCategoryBack.TabIndex = 12;
            this.btnCategoryBack.Text = ">>";
            this.btnCategoryBack.UseVisualStyleBackColor = false;
            this.btnCategoryBack.Visible = false;
            this.btnCategoryBack.Click += new System.EventHandler(this.btnCategoryBack_Click);
            // 
            // btnCategoryNext
            // 
            this.btnCategoryNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCategoryNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoryNext.Font = new System.Drawing.Font("メイリオ", 15F);
            this.btnCategoryNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoryNext.Location = new System.Drawing.Point(66, 42);
            this.btnCategoryNext.Name = "btnCategoryNext";
            this.btnCategoryNext.Size = new System.Drawing.Size(78, 56);
            this.btnCategoryNext.TabIndex = 13;
            this.btnCategoryNext.Text = "<<";
            this.btnCategoryNext.UseVisualStyleBackColor = false;
            this.btnCategoryNext.Visible = false;
            this.btnCategoryNext.Click += new System.EventHandler(this.btnCategoryNext_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("メイリオ", 15F);
            this.lblTitle.Location = new System.Drawing.Point(151, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 56);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // tabs
            // 
            this.tabs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabBasic,
            this.tabUse});
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.tabs.Size = new System.Drawing.Size(506, 28);
            this.tabs.TabIndex = 15;
            this.tabs.Text = "menuStrip1";
            this.tabs.Visible = false;
            // 
            // tabBasic
            // 
            this.tabBasic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabBasicClass,
            this.tabBasicMethod,
            this.メソッドToolStripMenuItem1});
            this.tabBasic.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Size = new System.Drawing.Size(53, 24);
            this.tabBasic.Text = "基礎";
            // 
            // tabBasicClass
            // 
            this.tabBasicClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabBasicClassConcept,
            this.tabBasicClassConstructor,
            this.tabBasicClassInstantiation});
            this.tabBasicClass.Name = "tabBasicClass";
            this.tabBasicClass.Size = new System.Drawing.Size(137, 26);
            this.tabBasicClass.Text = "クラス";
            // 
            // tabBasicClassConcept
            // 
            this.tabBasicClassConcept.Name = "tabBasicClassConcept";
            this.tabBasicClassConcept.Size = new System.Drawing.Size(173, 26);
            this.tabBasicClassConcept.Text = "概念";
            this.tabBasicClassConcept.Click += new System.EventHandler(this.tab_Click);
            // 
            // tabBasicClassConstructor
            // 
            this.tabBasicClassConstructor.Name = "tabBasicClassConstructor";
            this.tabBasicClassConstructor.Size = new System.Drawing.Size(173, 26);
            this.tabBasicClassConstructor.Text = "コンストラクタ";
            this.tabBasicClassConstructor.Click += new System.EventHandler(this.tab_Click);
            // 
            // tabBasicClassInstantiation
            // 
            this.tabBasicClassInstantiation.Name = "tabBasicClassInstantiation";
            this.tabBasicClassInstantiation.Size = new System.Drawing.Size(173, 26);
            this.tabBasicClassInstantiation.Text = "インスタンス化";
            this.tabBasicClassInstantiation.Click += new System.EventHandler(this.tab_Click);
            // 
            // tabBasicMethod
            // 
            this.tabBasicMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabBasicMethodConcept,
            this.tabBasicMethodArgument,
            this.tabBasicMethodReturnValue});
            this.tabBasicMethod.Name = "tabBasicMethod";
            this.tabBasicMethod.Size = new System.Drawing.Size(224, 26);
            this.tabBasicMethod.Text = "メソッド";
            // 
            // tabBasicMethodConcept
            // 
            this.tabBasicMethodConcept.Name = "tabBasicMethodConcept";
            this.tabBasicMethodConcept.Size = new System.Drawing.Size(224, 26);
            this.tabBasicMethodConcept.Text = "概念";
            this.tabBasicMethodConcept.Click += new System.EventHandler(this.tab_Click);
            // 
            // tabBasicMethodArgument
            // 
            this.tabBasicMethodArgument.Name = "tabBasicMethodArgument";
            this.tabBasicMethodArgument.Size = new System.Drawing.Size(224, 26);
            this.tabBasicMethodArgument.Text = "引数";
            this.tabBasicMethodArgument.Click += new System.EventHandler(this.tab_Click);
            // 
            // tabBasicMethodReturnValue
            // 
            this.tabBasicMethodReturnValue.Name = "tabBasicMethodReturnValue";
            this.tabBasicMethodReturnValue.Size = new System.Drawing.Size(224, 26);
            this.tabBasicMethodReturnValue.Text = "戻り値";
            this.tabBasicMethodReturnValue.Click += new System.EventHandler(this.tab_Click);
            // 
            // メソッドToolStripMenuItem1
            // 
            this.メソッドToolStripMenuItem1.Name = "メソッドToolStripMenuItem1";
            this.メソッドToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.メソッドToolStripMenuItem1.Text = "各関数";
            // 
            // tabUse
            // 
            this.tabUse.Name = "tabUse";
            this.tabUse.Size = new System.Drawing.Size(53, 24);
            this.tabUse.Text = "応用";
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("メイリオ", 8F);
            this.lblPage.Location = new System.Drawing.Point(354, 603);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(78, 19);
            this.lblPage.TabIndex = 16;
            this.lblPage.Text = "2/15";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 642);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCategoryNext);
            this.Controls.Add(this.btnCategoryBack);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnRePlain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGoExplan);
            this.Controls.Add(this.btnDance);
            this.Controls.Add(this.btnSit);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.tabs;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnSit;
        private System.Windows.Forms.Button btnDance;
        private System.Windows.Forms.Button btnGoExplan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRePlain;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCategoryBack;
        private System.Windows.Forms.Button btnCategoryNext;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip tabs;
        private System.Windows.Forms.ToolStripMenuItem tabBasic;
        private System.Windows.Forms.ToolStripMenuItem tabBasicClass;
        private System.Windows.Forms.ToolStripMenuItem tabBasicMethod;
        private System.Windows.Forms.ToolStripMenuItem メソッドToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabBasicClassConcept;
        private System.Windows.Forms.ToolStripMenuItem tabBasicClassConstructor;
        private System.Windows.Forms.ToolStripMenuItem tabBasicClassInstantiation;
        private System.Windows.Forms.ToolStripMenuItem tabUse;
        private System.Windows.Forms.ToolStripMenuItem tabBasicMethodConcept;
        private System.Windows.Forms.ToolStripMenuItem tabBasicMethodArgument;
        private System.Windows.Forms.ToolStripMenuItem tabBasicMethodReturnValue;
        private System.Windows.Forms.Label lblPage;
    }
}

