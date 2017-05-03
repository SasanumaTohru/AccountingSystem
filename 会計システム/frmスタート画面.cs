using System.Windows.Forms;
using WindowsFormsControlLibrary;

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
                ctrl借方仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
                ctrl借方仕訳.貸借区分 = ctrl仕訳.貸借.借方;
                ctrl貸方仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
                ctrl貸方仕訳.貸借区分 = ctrl仕訳.貸借.貸方;
            }  
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd伝票を登録する_Click(object sender, System.EventArgs e)
        {
            ApplicationService.仕訳構築サービス 伝票仕訳 = 伝票仕訳を構築する();
            ApplicationService.会計伝票記帳サービス 会計伝票 = new ApplicationService.会計伝票記帳サービス(dtp計上日.Value, 伝票仕訳.リスト);
            画面を更新する(会計伝票);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ApplicationService.仕訳構築サービス 伝票仕訳を構築する()
        {
            ApplicationService.仕訳構築サービス 伝票仕訳 = new ApplicationService.仕訳構築サービス();

            ctrl仕訳 画面の仕訳要素 = new ctrl仕訳();
            foreach (var item in Controls)
            {
                if (item is ctrl仕訳)
                {
                    画面の仕訳要素 = (ctrl仕訳)item;
                    伝票仕訳.追加する(
                        int.Parse(画面の仕訳要素.cmb勘定科目.Text.Substring(0, 6)),
                        decimal.Parse(画面の仕訳要素.txt金額.Text),
                        画面の仕訳要素.txt摘要.Text,
                        画面の仕訳要素.貸借区分番号);
                }
            }
            return 伝票仕訳;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="会計伝票"></param>
        private void 画面を更新する(ApplicationService.会計伝票記帳サービス 会計伝票)
        {
            txt伝票番号.Text = 会計伝票.内容.番号.値;
            txt借方合計金額.Text = 会計伝票.内容.借方.合計金額.桁区切り値;
            txt貸方合計金額.Text = 会計伝票.内容.貸方.合計金額.桁区切り値;
            txt貸借差額.Text = 会計伝票.内容.貸借金額差額.桁区切り値;
            if (会計伝票.内容.貸借金額差額.値 != 0)
            {
                MessageBox.Show("貸借の合計金額が不一致しています。");
            }
        }

        private const int 仕訳コントロールの追加時位置補正 = 100;
        private static int 借方仕訳コントロールの追加位置 = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd借方仕訳要素追加_Click(object sender, System.EventArgs e)
        {
            ctrl仕訳 新し仕訳 = new ctrl仕訳();
            借方仕訳コントロールの追加位置 = 借方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新し仕訳.Location = new System.Drawing.Point(ctrl借方仕訳.Location.X, ctrl借方仕訳.Location.Y + 借方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新し仕訳);
            新し仕訳.貸借区分 = ctrl仕訳.貸借.借方;
            this.Controls.Add(新し仕訳);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="新し仕訳"></param>
        private static void コンボボックスに勘定科目を設定する(ctrl仕訳 新し仕訳)
        {
            ApplicationService.勘定科目情報サービス 科目一覧 = new ApplicationService.勘定科目情報サービス();
            foreach (Domain.BusinessObject.勘定科目.科目 取引科目 in 科目一覧.取引科目リスト)
            {
                新し仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
            }
        }

        private static int 貸方仕訳コントロールの追加位置 = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd貸方仕訳要素追加_Click(object sender, System.EventArgs e)
        {
            ctrl仕訳 新し仕訳 = new ctrl仕訳();
            貸方仕訳コントロールの追加位置 = 貸方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新し仕訳.Location = new System.Drawing.Point(ctrl貸方仕訳.Location.X, ctrl貸方仕訳.Location.Y + 貸方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新し仕訳);
            新し仕訳.貸借区分 = ctrl仕訳.貸借.貸方;
            this.Controls.Add(新し仕訳);
        }
    }
}
