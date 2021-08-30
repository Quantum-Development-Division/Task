using _4thTask2.Identifiers;
using _4thTask2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4thTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Humanクラスをインスタンス化
            this.model = new Human();
        }

        /// <summary>
        /// メンバ変数
        /// </summary>
        private Human model;

        /// <summary>
        /// 一文字の待機時間
        /// </summary>
        int waitTimeChar = 1;

        /// <summary>
        /// 行間の待機時間
        /// </summary>
        int waitTimeLine = 300;

        bool isFixedMessage = false;

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// 画面各モジュールに情報を設定
        /// </summary>
        async void Set()
        {
            lblTitle.Text = Resource_JP.ResourceManager.GetString(this.model.CurrentExplain.Name.ToString());
            lblTitle.Visible = this.model.CurrentExplain.IsDisplayedBtn ? false : this.model.IsExplainPage;
            pictureBox1.ImageLocation = this.model.GetImageLocation();
            lblPage.Text = this.model.PageText;
            message.ForeColor = this.model.ForeColor;
            await this.OutputMessage();
            await Task.Delay(waitTimeLine);
        }

        /// <summary>
        /// GOボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (this.model.Step)
            {
                case 1:
                    this.model.StepName(txtInfo.Text);
                    break;
                case 2:
                    bool result = this.model.StepAge(txtInfo.Text);
                    if (!result) break;

                    txtInfo.Visible = false;
                    btnGo.Visible = false;
                    btnHi.Visible = true;
                    btnSit.Visible = true;
                    btnDance.Visible = true;
                    btnGoExplan.Visible = true;
                    break;
            }

            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// ハイボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnHi_Click(object sender, EventArgs e)
        {
            this.model.Hi();
            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// 座るボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnSit_Click(object sender, EventArgs e)
        {
            this.model.Sit();
            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// 歩くボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnWalk_Click(object sender, EventArgs e)
        {
            this.model.Walk();
            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// 生成したメッセージを画面に出力
        /// </summary>
        /// <returns>タスク</returns>
        async Task OutputMessage()
        {
            message.Text = string.Empty;

            // 生成した文字列を一文字づつ出力していく
            foreach (char c in this.model.Message)
            {
                message.Text += c.ToString();

                // 文字出力の時間制御
                if (!string.IsNullOrEmpty(c.ToString()))
                {
                    await Task.Delay(waitTimeChar);
                }
            }

            btnNext.Visible = this.model.VisiblityNext;
            btnBack.Visible = this.model.VisiblityBack;
            btnRePlain.Visible = this.model.CurrentExplain.IsDisplayedBtn;
            btnAll.Visible = this.model.CurrentExplain.IsDisplayedBtn;
            btnCategoryNext.Visible = this.model.IsLatestExplain;
            btnCategoryBack.Visible = !this.model.IsFirstExplain;
            isFixedMessage = true;
        }

        /// <summary>
        /// 説明へ進むボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnGoExplan_Click(object sender, EventArgs e)
        {
            if (!isFixedMessage) return;

            txtInfo.Visible = false;
            btnGo.Visible = false;
            btnHi.Visible = false;
            btnSit.Visible = false;
            btnDance.Visible = false;
            btnGoExplan.Visible = false;
            tabs.Visible = true;
            lblPage.Visible = true;

            this.model.VisiblityNext = true;
            this.DoExplain(ButtonStatuses.GoExplain);
        }

        /// <summary>
        /// 次へボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.DoExplain(ButtonStatuses.Next);
        }

        /// <summary>
        /// 前へボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DoExplain(ButtonStatuses.Back);
        }

        /// <summary>
        /// もう一度説明を読む押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnRePlain_Click(object sender, EventArgs e)
        {
            this.DoExplain(ButtonStatuses.RePlain);
            btnRePlain.Visible = false;
            btnAll.Visible = false;
        }

        /// <summary>
        /// 全てボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            new ExplainAll(this.model).ShowDialog();
        }

        /// <summary>
        /// <<ボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnCategoryNext_Click(object sender, EventArgs e)
        {
            this.DoExplain(ButtonStatuses.CategoryNext);
        }

        /// <summary>
        /// >>ボタン押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void btnCategoryBack_Click(object sender, EventArgs e)
        {
            this.DoExplain(ButtonStatuses.CategoryBack);
        }

        private void DoExplain(ButtonStatuses status = ButtonStatuses.Next)
        {
            if (!isFixedMessage) return;
            this.model.SetExplain(status);
            this.Set();
            isFixedMessage = false;
        }

        /// <summary>
        /// 説明タブ押下イベント
        /// </summary>
        /// <param name="sender">フォーム情報</param>
        /// <param name="e">イベント情報</param>
        private void tab_Click(object sender, EventArgs e)
        {
            // 押下されたタブのプロパティ名を取得
            var name = ((ToolStripMenuItem)sender).Name;
            this.model.TabStatus = (TabStatuses)Enum.Parse(typeof(TabStatuses), name);
            this.DoExplain(ButtonStatuses.Tab);
        }
    }
}
