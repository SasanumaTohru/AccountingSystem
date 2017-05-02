using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using 会計システム.Domain.BusinessObject.会計伝票;


namespace 会計システム
{
    public partial class frmスタート画面 : Form
    {
        public frmスタート画面()
        {
            InitializeComponent();
            ApplicationService.勘定科目情報サービス 科目一覧 = new ApplicationService.勘定科目情報サービス();
            foreach (Domain.BusinessObject.勘定科目.科目 取引科目 in 科目一覧.取引科目リスト)
            {
                cmb借方勘定科目1.Items.Add(取引科目.コードと名称.値);
                cmb借方勘定科目2.Items.Add(取引科目.コードと名称.値);
                cmb貸方勘定科目1.Items.Add(取引科目.コードと名称.値);
                cmb貸方勘定科目2.Items.Add(取引科目.コードと名称.値);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd取引勘定科目の一覧を表示する_Click(object sender, System.EventArgs e)
        {
            ApplicationService.勘定科目情報サービス 科目一覧 = new ApplicationService.勘定科目情報サービス();
            リストの表示を更新する(科目一覧.取引科目リスト);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdすべての勘定科目の一覧を表示する_Click(object sender, System.EventArgs e)
        {
            ApplicationService.勘定科目情報サービス 科目一覧 = new ApplicationService.勘定科目情報サービス();
            リストの表示を更新する(科目一覧.すべての勘定科目リスト);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="科目一覧"></param>
        private void リストの表示を更新する(List<Domain.BusinessObject.勘定科目.科目> 科目一覧)
        {
            lst一覧表示.Items.Clear();
            foreach (Domain.BusinessObject.勘定科目.科目 取引科目 in 科目一覧)
            {
                lst一覧表示.Items.Add(取引科目.コードと名称.値);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd伝票を登録する_Click(object sender, System.EventArgs e)
        {
            /*
             * 前提条件
             * UIはプロトタイプのため、本来、変動要素である仕訳要素数は4に固定している。
             * 
             */

            ApplicationService.仕訳構築サービス 伝票仕訳 = new ApplicationService.仕訳構築サービス();
            
            //借方仕訳要素1
            伝票仕訳.追加する(int.Parse(cmb借方勘定科目1.Text.Substring(0, 6)), decimal.Parse(txt借方金額1.Text), txt借方摘要1.Text, 仕訳.貸借区分.借方);
            //借方仕訳要素2
            伝票仕訳.追加する(int.Parse(cmb借方勘定科目2.Text.Substring(0, 6)), decimal.Parse(txt借方金額2.Text), txt借方摘要2.Text, 仕訳.貸借区分.借方);
            //貸方仕訳要素1
            伝票仕訳.追加する(int.Parse(cmb貸方勘定科目1.Text.Substring(0, 6)), decimal.Parse(txt貸方金額1.Text), txt貸方摘要1.Text, 仕訳.貸借区分.貸方);
            //貸方仕訳要素2
            伝票仕訳.追加する(int.Parse(cmb貸方勘定科目2.Text.Substring(0, 6)), decimal.Parse(txt貸方金額2.Text), txt貸方摘要2.Text, 仕訳.貸借区分.貸方);
            
            //会計伝票を作成する
            ApplicationService.会計伝票作成サービス 会計伝票 = new ApplicationService.会計伝票作成サービス(dtp計上日.Value, 伝票仕訳.リスト);
            
            //画面に追加情報を表示する
            txt伝票番号.Text = 会計伝票.内容.番号.値;
            txt借方金額1.Text = 会計伝票.内容.借方.リスト[0].金額.桁区切り値;
            txt借方金額2.Text = 会計伝票.内容.借方.リスト[1].金額.桁区切り値;
            txt貸方金額1.Text = 会計伝票.内容.貸方.リスト[0].金額.桁区切り値;
            txt貸方金額2.Text = 会計伝票.内容.貸方.リスト[1].金額.桁区切り値;
            txt借方合計金額.Text = 会計伝票.内容.借方.合計金額.桁区切り値;
            txt貸方合計金額.Text = 会計伝票.内容.貸方.合計金額.桁区切り値;
          
        }

       

       
    }
}
