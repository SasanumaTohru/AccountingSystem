using System.Collections.Generic;
using System.Windows.Forms;

namespace 会計システム
{
    public partial class frmスタート画面 : Form
    {
        public frmスタート画面()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd取引勘定科目の一覧を表示する_Click(object sender, System.EventArgs e)
        {
            ApplicationService.勘定科目提供サービス 科目一覧 = new ApplicationService.勘定科目提供サービス();
            リストの表示を更新する(科目一覧.取引科目リスト);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdすべての勘定科目の一覧を表示する_Click(object sender, System.EventArgs e)
        {
            ApplicationService.勘定科目提供サービス 科目一覧 = new ApplicationService.勘定科目提供サービス();
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

    }
}
