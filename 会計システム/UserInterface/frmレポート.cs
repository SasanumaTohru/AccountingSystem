using System;
using System.Windows.Forms;

namespace AccountingSystem.UserInterface
{
    public partial class frmレポート : Form
    {
        public frmレポート()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd合計残高試算表_Click(object sender, EventArgs e)
        {
            var 合計残高試算表 = new ApplicationService.合計残高試算表参照サービス();
            Domain.BusinessObject.会計年度 会計年度 = new Domain.BusinessObject.会計年度(2017, 4);
            Domain.BusinessObject.財務諸表.合計残高試算表 勘定科目別残高 = 合計残高試算表.勘定科目別残高リスト(会計年度);
            foreach(var p in 勘定科目別残高.リスト)
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
