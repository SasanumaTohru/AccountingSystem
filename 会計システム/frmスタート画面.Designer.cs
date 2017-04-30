namespace 会計システム
{
    partial class frmスタート画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.cmd取引勘定科目の一覧を表示する = new System.Windows.Forms.Button();
            this.lst一覧表示 = new System.Windows.Forms.ListBox();
            this.cmdすべての勘定科目の一覧を表示する = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd取引勘定科目の一覧を表示する
            // 
            this.cmd取引勘定科目の一覧を表示する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd取引勘定科目の一覧を表示する.Location = new System.Drawing.Point(917, 98);
            this.cmd取引勘定科目の一覧を表示する.Name = "cmd取引勘定科目の一覧を表示する";
            this.cmd取引勘定科目の一覧を表示する.Size = new System.Drawing.Size(435, 141);
            this.cmd取引勘定科目の一覧を表示する.TabIndex = 0;
            this.cmd取引勘定科目の一覧を表示する.Text = "取引勘定科目の一覧を表示する";
            this.cmd取引勘定科目の一覧を表示する.UseVisualStyleBackColor = true;
            this.cmd取引勘定科目の一覧を表示する.Click += new System.EventHandler(this.cmd取引勘定科目の一覧を表示する_Click);
            // 
            // lst一覧表示
            // 
            this.lst一覧表示.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lst一覧表示.FormattingEnabled = true;
            this.lst一覧表示.ItemHeight = 36;
            this.lst一覧表示.Location = new System.Drawing.Point(12, 12);
            this.lst一覧表示.Name = "lst一覧表示";
            this.lst一覧表示.Size = new System.Drawing.Size(726, 1012);
            this.lst一覧表示.TabIndex = 1;
            // 
            // cmdすべての勘定科目の一覧を表示する
            // 
            this.cmdすべての勘定科目の一覧を表示する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdすべての勘定科目の一覧を表示する.Location = new System.Drawing.Point(917, 310);
            this.cmdすべての勘定科目の一覧を表示する.Name = "cmdすべての勘定科目の一覧を表示する";
            this.cmdすべての勘定科目の一覧を表示する.Size = new System.Drawing.Size(435, 141);
            this.cmdすべての勘定科目の一覧を表示する.TabIndex = 2;
            this.cmdすべての勘定科目の一覧を表示する.Text = "すべての勘定科目の一覧を表示する";
            this.cmdすべての勘定科目の一覧を表示する.UseVisualStyleBackColor = true;
            this.cmdすべての勘定科目の一覧を表示する.Click += new System.EventHandler(this.cmdすべての勘定科目の一覧を表示する_Click);
            // 
            // frmスタート画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 1048);
            this.Controls.Add(this.cmdすべての勘定科目の一覧を表示する);
            this.Controls.Add(this.lst一覧表示);
            this.Controls.Add(this.cmd取引勘定科目の一覧を表示する);
            this.Name = "frmスタート画面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd取引勘定科目の一覧を表示する;
        private System.Windows.Forms.ListBox lst一覧表示;
        private System.Windows.Forms.Button cmdすべての勘定科目の一覧を表示する;
    }
}

