using System;
using System.Windows.Forms;

namespace AccountingSystem.UserInterface
{
    public partial class frmレポート : Form
    {
        public frmレポート()
        {
            InitializeComponent();
            cmb年度.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd合計残高試算表_Click(object sender, EventArgs e)
        {
            txtビュー.Text = string.Empty;
            var 合計残高試算表ビルダー = new ApplicationService.合計残高試算表構築サービス();
            var 会計年度 = new Domain.BusinessObject.会計年度(int.Parse(cmb年度.Text));
            Domain.BusinessObject.財務諸表.合計残高試算表 合計残高試算表 = 合計残高試算表ビルダー.合計残高試算表を取得する(会計年度);
            foreach(var p in 合計残高試算表.勘定科目別残高リスト)
            {
                txtビュー.Text = txtビュー.Text + p.勘定科目と金額 + Environment.NewLine;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
