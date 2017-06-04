using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsControlLibrary;
using AccountingSystem.Domain.BusinessObject.会計伝票;
using AccountingSystem.Domain.PrimitiveObject;
using System.Diagnostics;

namespace AccountingSystem
{
    public partial class frmスタート画面 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmスタート画面()
        {
            InitializeComponent();

            勘定科目コンボボックスとデフォルト仕訳コントロールを設定する();
            伝票検索結果ビューを設定する();
        }

        /// <summary>
        /// 
        /// </summary>
        private struct 通知目的
        {
            public const string 確認 = "操作確認";
            public const string 結果 = "操作結果";
            public const string エラー = "エラー";
        }

        /// <summary>
        /// 
        /// </summary>
        private void 勘定科目コンボボックスとデフォルト仕訳コントロールを設定する()
        {
            var 科目一覧 = new ApplicationService.勘定科目情報サービス();
            foreach (var 取引科目 in 科目一覧.取引勘定科目リスト)
            {
                ctrl借方仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
                ctrl貸方仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
                cmb検索する勘定科目.Items.Add(取引科目.コードと名称.値);
            }
            cmb検索する勘定科目.SelectedIndex = 0;
            ctrl借方仕訳.貸借区分 = ctrl仕訳.貸借.借方;
            ctrl貸方仕訳.貸借区分 = ctrl仕訳.貸借.貸方;
        }

        /// <summary>
        /// 
        /// </summary>
        private void 伝票検索結果ビューを設定する()
        {
            var dgv列伝票番号 = new DataGridViewTextBoxColumn()
            {
                Name = "伝票番号",
                HeaderText = "伝票番号",
                Width = 110
            };
            dgv列伝票番号.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dgv列計上日 = new DataGridViewTextBoxColumn()
            {
                Name = "計上日",
                HeaderText = "計上日",
                Width = 130
            };
            dgv列計上日.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv伝票検索結果ビュー.Columns.Add(dgv列伝票番号);
            dgv伝票検索結果ビュー.Columns.Add(dgv列計上日);

            dgv伝票検索結果ビュー.Font = new Font("メイリオ", 9);
            dgv伝票検索結果ビュー.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd伝票を登録する_Click(object sender, EventArgs e)
        {
            画面に表示している伝票を登録する();
        }

        /// <summary>
        /// 
        /// </summary>
        private void 画面に表示している伝票を登録する()
        {
            try
            {
                画面ウェイト();
                ApplicationService.仕訳構築サービス 構築した仕訳 = 伝票仕訳を構築する();

                var 伝票構築サービス = new ApplicationService.会計伝票構築サービス();
                伝票 保存する伝票 = 伝票構築サービス.伝票を構築する(dtp計上日.Value.Date, 構築した仕訳);

                var 会計伝票記帳サービス = new ApplicationService.会計伝票記帳サービス();
                会計伝票記帳サービス.伝票を記帳する(保存する伝票);
                画面を更新する(保存する伝票);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 通知目的.エラー, MessageBoxButtons.OK, MessageBoxIcon.Error);
                decimal 借方合計金額 = 0;
                decimal 貸方合計金額 = 0;
                var 仕訳コントロール = new ctrl仕訳();
                foreach (var item in Controls)
                {
                    if (item is ctrl仕訳)
                    {
                        仕訳コントロール = (ctrl仕訳)item;
                        金額入力が不適切の場合は0円にする(仕訳コントロール);
                        switch (仕訳コントロール.貸借区分)
                        {
                            case ctrl仕訳.貸借.借方:
                                借方合計金額 = 借方合計金額 + ApplicationService.型変換サービス.文字列を金額に変換する(仕訳コントロール.txt金額.Text).金額;
                                break;
                            case ctrl仕訳.貸借.貸方:
                                貸方合計金額 = 貸方合計金額 + ApplicationService.型変換サービス.文字列を金額に変換する(仕訳コントロール.txt金額.Text).金額;
                                break;
                        }
                    }
                }
                txt借方合計金額.Text = new 金額(借方合計金額).桁区切り値;
                txt貸方合計金額.Text = new 金額(貸方合計金額).桁区切り値;
                txt貸借差額.Text = new 金額(借方合計金額 - 貸方合計金額).桁区切り絶対値;
            }
            finally
            {
                画面ウェイト終了();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="仕訳コントロール"></param>
        private static void 金額入力が不適切の場合は0円にする(ctrl仕訳 仕訳コントロール)
        {
            if (ApplicationService.型変換サービス.文字列を金額に変換する(仕訳コントロール.txt金額.Text).変換可能 == false)
            {
                仕訳コントロール.txt金額.Text = "0";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ApplicationService.仕訳構築サービス 伝票仕訳を構築する()
        {
            var 伝票仕訳 = new ApplicationService.仕訳構築サービス();

            var 仕訳コントロール = new ctrl仕訳();
            foreach (var item in Controls)
            {
                if (item is ctrl仕訳)
                {
                    仕訳コントロール = (ctrl仕訳)item;
                    int 勘定科目コード = ApplicationService.型変換サービス.コードと名称から勘定科目コードを抽出する(仕訳コントロール.cmb勘定科目.Text);
                    var 金額入力欄 = ApplicationService.型変換サービス.文字列を金額に変換する(仕訳コントロール.txt金額.Text);
                    if (金額入力欄.変換可能 == false)
                    {
                        throw new Exception("金額欄に不適切な文字が入力されています。");
                    }
                    伝票仕訳.追加する(勘定科目コード, 金額入力欄.金額, 仕訳コントロール.txt摘要.Text, 仕訳コントロール.貸借区分番号);
                }
            }
            return 伝票仕訳;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="登録した会計伝票"></param>
        private void 画面を更新する(Domain.BusinessObject.会計伝票.伝票 登録した会計伝票)
        {
            txt伝票番号.Text = 登録した会計伝票.番号.値;
            txt借方合計金額.Text = 登録した会計伝票.借方.合計金額.桁区切り値;
            txt貸方合計金額.Text = 登録した会計伝票.貸方.合計金額.桁区切り値;
            txt貸借差額.Text = 登録した会計伝票.貸借金額差額.桁区切り値;
        }

        private const int 仕訳コントロールの追加時位置補正 = 100;
        private static int 借方仕訳コントロールの追加位置 = 0;
        /// <summary>
        /// 借方の仕訳コントロールを追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd借方仕訳要素追加_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            借方仕訳要素を追加する();
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        private void 借方仕訳要素を追加する()
        {
            var 新しい仕訳コントロール = new ctrl仕訳();
            借方仕訳コントロールの追加位置 = 借方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新しい仕訳コントロール.Location = new Point(ctrl借方仕訳.Location.X, ctrl借方仕訳.Location.Y + 借方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新しい仕訳コントロール);
            新しい仕訳コントロール.貸借区分 = ctrl仕訳.貸借.借方;
            画面に追加する(新しい仕訳コントロール);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="新しい仕訳"></param>
        private void 画面に追加する(ctrl仕訳 新しい仕訳)
        {
            Controls.Add(新しい仕訳);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="新し仕訳"></param>
        private static void コンボボックスに勘定科目を設定する(ctrl仕訳 新し仕訳)
        {
            var 科目一覧 = new ApplicationService.勘定科目情報サービス();
            foreach (var 取引科目 in 科目一覧.取引勘定科目リスト)
            {
                新し仕訳.cmb勘定科目.Items.Add(取引科目.コードと名称.値);
            }
        }

        private static int 貸方仕訳コントロールの追加位置 = 0;
        /// <summary>
        /// 貸方の仕訳コントロールを追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd貸方仕訳要素追加_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            貸方仕訳要素を追加する();
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        private void 貸方仕訳要素を追加する()
        {
            var 新しい仕訳コントロール = new ctrl仕訳();
            貸方仕訳コントロールの追加位置 = 貸方仕訳コントロールの追加位置 + 仕訳コントロールの追加時位置補正;
            新しい仕訳コントロール.Location = new Point(ctrl貸方仕訳.Location.X, ctrl貸方仕訳.Location.Y + 貸方仕訳コントロールの追加位置);
            コンボボックスに勘定科目を設定する(新しい仕訳コントロール);
            新しい仕訳コントロール.貸借区分 = ctrl仕訳.貸借.貸方;
            画面に追加する(新しい仕訳コントロール);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd伝票番号検索_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            伝票番号で検索する();
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        private void 伝票番号で検索する()
        {
            if (txt伝票番号.Text == string.Empty)
            {
                MessageBox.Show("伝票番号が入力されていません。", 通知目的.エラー, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var 伝票検索 = new ApplicationService.会計伝票検索サービス();
                伝票 検索した伝票 = 伝票検索.伝票番号で検索する(txt伝票番号.Text);
                指定した伝票を画面に表示する(検索した伝票);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 通知目的.エラー, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd計上日検索_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            var 伝票検索 = new ApplicationService.会計伝票検索サービス();
            List<伝票> 伝票ヒットリスト = 伝票検索.計上日で検索する(dtp計上日.Value.Date);
            if (伝票ヒットリスト.Count() == 0)
            {
                MessageBox.Show("指定した日の会計伝票はありません。", 通知目的.結果, MessageBoxButtons.OK, MessageBoxIcon.Information);
                画面ウェイト終了();
                return;
            }
            検索結果を表示する(伝票ヒットリスト);
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="伝票ヒットリスト"></param>
        private void 検索結果を表示する(List<伝票> 伝票ヒットリスト)
        {
            dgv伝票検索結果ビュー.Rows.Clear();
            foreach (伝票 item in 伝票ヒットリスト)
            {
                dgv伝票検索結果ビュー.Rows.Add(item.番号.値, item.計上日.西暦年月日(日付.曜日表示.あり));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd勘定科目検索_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            if (cmb検索する勘定科目.Text == string.Empty)
            {
                MessageBox.Show("勘定科目が選択されていません。", 通知目的.エラー, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var 伝票検索 = new ApplicationService.会計伝票検索サービス();
            int 検索する勘定科目 = ApplicationService.型変換サービス.コードと名称から勘定科目コードを抽出する(cmb検索する勘定科目.Text);
            List<伝票> 伝票ヒットリスト = 伝票検索.勘定科目で検索する(検索する勘定科目);
            if (伝票ヒットリスト.Count() == 0)
            {
                MessageBox.Show("指定した勘定科目を持つ会計伝票はありません。", 通知目的.結果, MessageBoxButtons.OK, MessageBoxIcon.Information);
                画面ウェイト終了();
                return;
            }
            検索結果を表示する(伝票ヒットリスト);
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="表示する伝票"></param>
        private void 指定した伝票を画面に表示する(伝票 表示する伝票)
        {
            伝票のヘッダ部を入力する(表示する伝票);
            仕訳コントロールの2行目以降を削除する();
            仕訳コントロールを追加する(表示する伝票);
            仕訳を入力する(表示する伝票);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="表示する伝票"></param>
        private void 仕訳を入力する(伝票 表示する伝票)
        {
            int 借方仕訳のインデックス = 0;
            int 貸方仕訳のインデックス = 0;
            foreach (var 画面上のコントロール in Controls)
            {
                if (画面上のコントロール is ctrl仕訳 仕訳コントロール)
                {
                    switch (仕訳コントロール.貸借区分)
                    {
                        case ctrl仕訳.貸借.借方:
                            仕訳コントロール.cmb勘定科目.Text = 表示する伝票.借方.リスト[借方仕訳のインデックス].勘定科目.コードと名称.値;
                            仕訳コントロール.txt金額.Text = 表示する伝票.借方.リスト[借方仕訳のインデックス].金額.桁区切り値;
                            仕訳コントロール.txt摘要.Text = 表示する伝票.借方.リスト[借方仕訳のインデックス].摘要.値;
                            借方仕訳のインデックス++;
                            break;
                        case ctrl仕訳.貸借.貸方:
                            仕訳コントロール.cmb勘定科目.Text = 表示する伝票.貸方.リスト[貸方仕訳のインデックス].勘定科目.コードと名称.値;
                            仕訳コントロール.txt金額.Text = 表示する伝票.貸方.リスト[貸方仕訳のインデックス].金額.桁区切り値;
                            仕訳コントロール.txt摘要.Text = 表示する伝票.貸方.リスト[貸方仕訳のインデックス].摘要.値;
                            貸方仕訳のインデックス++;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="表示する伝票"></param>
        private void 伝票のヘッダ部を入力する(伝票 表示する伝票)
        {
            txt伝票番号.Text = 表示する伝票.番号.値;
            dtp計上日.Value = 表示する伝票.計上日.値;
            txt借方合計金額.Text = 表示する伝票.借方.合計金額.桁区切り値;
            txt貸方合計金額.Text = 表示する伝票.貸方.合計金額.桁区切り値;
            txt貸借差額.Text = 表示する伝票.貸借金額差額.桁区切り値;
            chk訂正伝票の有無.Checked = 表示する伝票.伝票情報.訂正伝票がある;
            chk訂正伝票.Checked = 表示する伝票.伝票情報.訂正伝票である;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="表示する伝票"></param>
        private void 仕訳コントロールを追加する(伝票 表示する伝票)
        {
            int 借方仕訳数 = 表示する伝票.借方.リスト.Count();
            for (int i = 1; i < 借方仕訳数; i++)
            {
                借方仕訳要素を追加する();
            }
            int 貸方仕訳数 = 表示する伝票.貸方.リスト.Count();
            for (int i = 1; i < 貸方仕訳数; i++)
            {
                貸方仕訳要素を追加する();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void 仕訳コントロールの2行目以降を削除する()
        {
            int コントロールIndexの最大値 = this.Controls.Count - 1;
            for (int コントロールIndex = コントロールIndexの最大値; コントロールIndex >= 0; コントロールIndex--)
            {
                Control カレントコントロール = this.Controls[コントロールIndex];
                if (カレントコントロール is ctrl仕訳)
                {
                    デフォルト仕訳コントロールでなければ削除する(カレントコントロール);
                }
            }
            借方仕訳コントロールの追加位置 = 0;
            貸方仕訳コントロールの追加位置 = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="カレントコントロール"></param>
        private static void デフォルト仕訳コントロールでなければ削除する(Control カレントコントロール)
        {
            var 仕訳コントロール = (ctrl仕訳)カレントコントロール;
            if ((仕訳コントロール.Name != "ctrl借方仕訳" && 仕訳コントロール.Name != "ctrl貸方仕訳"))
            {
                カレントコントロール.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv伝票検索結果ビュー_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            画面ウェイト();
            txt伝票番号.Text = dgv伝票検索結果ビュー.SelectedCells[0].Value.ToString();
            伝票番号で検索する();
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd画面キャプチャ_Click(object sender, EventArgs e)
        {
            画面ウェイト();
            var 記録 = new ApplicationService.動作記録サービス();
            記録.表示画面をファイルに保存する(this);
            画面ウェイト終了();
        }

        /// <summary>
        /// 
        /// </summary>
        private void 画面ウェイト終了()
        {
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// 
        /// </summary>
        private void 画面ウェイト()
        {
            Cursor = Cursors.WaitCursor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd伝票訂正_Click(object sender, EventArgs e)
        {
            if (txt伝票番号.Text == string.Empty)
            {
                const string EM1 = "訂正する伝票を表示してから操作してください。";
                MessageBox.Show(EM1, 通知目的.エラー, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            const string EM2 = "貸借を反転し訂正伝票を起票します。";
            var 操作を続行する = MessageBox.Show(EM2, 通知目的.確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (操作を続行する == DialogResult.No)
            {
                return;
            }

            画面ウェイト();

            var 伝票検索サービス = new ApplicationService.会計伝票検索サービス();
            伝票 訂正元伝票 = 伝票検索サービス.伝票番号で検索する(txt伝票番号.Text);
            伝票 訂正伝票 = 訂正元伝票.訂正伝票を用意する();
            var 伝票記帳サービス = new ApplicationService.会計伝票記帳サービス();
            伝票記帳サービス.伝票を記帳する(訂正伝票);
            指定した伝票を画面に表示する(訂正伝票);

            画面ウェイト終了();
        }
    }
}
