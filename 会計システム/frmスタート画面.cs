using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

namespace 会計システム
{
    public partial class frmスタート画面 : Form
    {
        /// <summary>
        /// 
        /// </summary>
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
        private void cmd伝票を登録する_Click(object sender, EventArgs e)
        {
            try
            {
                ApplicationService.仕訳構築サービス 伝票仕訳 = 伝票仕訳を構築する();
                ApplicationService.会計伝票記帳サービス 登録した会計伝票 = new ApplicationService.会計伝票記帳サービス(dtp計上日.Value, 伝票仕訳.リスト);
                画面を更新する(登録した会計伝票);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                decimal 借方合計金額 = 0;
                decimal 貸方合計金額 = 0;
                ctrl仕訳 画面の仕訳要素 = new ctrl仕訳();
                foreach (var item in Controls)
                {
                    if (item is ctrl仕訳)
                    {
                        画面の仕訳要素 = (ctrl仕訳)item;
                        入力金額値の制御(画面の仕訳要素);
                        switch (画面の仕訳要素.貸借区分)
                        {
                            case ctrl仕訳.貸借.借方:
                                借方合計金額 = 借方合計金額 + int.Parse(画面の仕訳要素.txt金額.Text);
                                break;
                            case ctrl仕訳.貸借.貸方:
                                貸方合計金額 = 貸方合計金額 + int.Parse(画面の仕訳要素.txt金額.Text);
                                break;
                        }
                    }
                }
                txt借方合計金額.Text = new Domain.PrimitiveObject.金額(借方合計金額).桁区切り値;
                txt貸方合計金額.Text = new Domain.PrimitiveObject.金額(貸方合計金額).桁区切り値;
                txt貸借差額.Text = new Domain.PrimitiveObject.金額(借方合計金額 - 貸方合計金額).桁区切り値;
            }
        }

        private static void 入力金額値の制御(ctrl仕訳 画面の仕訳要素)
        {
            if (ApplicationService.入力検査.金額に変換できない(画面の仕訳要素.txt金額.Text))
            {
                画面の仕訳要素.txt金額.Text = "0";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ApplicationService.仕訳構築サービス 伝票仕訳を構築する()
        {
            ApplicationService.仕訳構築サービス 伝票仕訳 = new ApplicationService.仕訳構築サービス();

            ctrl仕訳 画面の仕訳要素 = new ctrl仕訳();
            foreach (var 仕訳コントロール in Controls)
            {
                if (仕訳コントロール is ctrl仕訳)
                {
                    画面の仕訳要素 = (ctrl仕訳)仕訳コントロール;
                    勘定科目のバリデーション(画面の仕訳要素);
                    金額のバリデーション(画面の仕訳要素);
                    伝票仕訳.追加する(
                        int.Parse(画面の仕訳要素.cmb勘定科目.Text.Substring(0, 6)),
                        decimal.Parse(画面の仕訳要素.txt金額.Text),
                        画面の仕訳要素.txt摘要.Text,
                        画面の仕訳要素.貸借区分番号);
                }
            }
            return 伝票仕訳;
        }

        private static void 金額のバリデーション(ctrl仕訳 画面の仕訳要素)
        {
            if (ApplicationService.入力検査.金額に変換できない(画面の仕訳要素.txt金額.Text))
            {
                throw new Exception("金額が正しく入力されていません。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="画面の仕訳要素"></param>
        private static void 勘定科目のバリデーション(ctrl仕訳 画面の仕訳要素)
        {
            if (string.IsNullOrWhiteSpace(画面の仕訳要素.cmb勘定科目.Text))
            {
                throw new Exception("勘定科目が選択されていません。");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="登録した会計伝票"></param>
        private void 画面を更新する(ApplicationService.会計伝票記帳サービス 登録した会計伝票)
        {
            txt伝票番号.Text = 登録した会計伝票.内容.番号.値;
            txt借方合計金額.Text = 登録した会計伝票.内容.借方.合計金額.桁区切り値;
            txt貸方合計金額.Text = 登録した会計伝票.内容.貸方.合計金額.桁区切り値;
            txt貸借差額.Text = 登録した会計伝票.内容.貸借金額差額.桁区切り値;
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
            ctrl仕訳 新しい仕訳 = new ctrl仕訳();
            借方仕訳コントロールの追加位置 = 借方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新しい仕訳.Location = new System.Drawing.Point(ctrl借方仕訳.Location.X, ctrl借方仕訳.Location.Y + 借方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新しい仕訳);
            新しい仕訳.貸借区分 = ctrl仕訳.貸借.借方;
            this.Controls.Add(新しい仕訳);
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
            ctrl仕訳 新しい仕訳 = new ctrl仕訳();
            貸方仕訳コントロールの追加位置 = 貸方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新しい仕訳.Location = new System.Drawing.Point(ctrl貸方仕訳.Location.X, ctrl貸方仕訳.Location.Y + 貸方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新しい仕訳);
            新しい仕訳.貸借区分 = ctrl仕訳.貸借.貸方;
            this.Controls.Add(新しい仕訳);
        }
    }
}
