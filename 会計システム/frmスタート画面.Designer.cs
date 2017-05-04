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
            this.label1 = new System.Windows.Forms.Label();
            this.txt伝票番号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt借方合計金額 = new System.Windows.Forms.TextBox();
            this.txt貸方合計金額 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmd伝票を登録する = new System.Windows.Forms.Button();
            this.dtp計上日 = new System.Windows.Forms.DateTimePicker();
            this.ctrl借方仕訳 = new WindowsFormsControlLibrary.ctrl仕訳();
            this.ctrl貸方仕訳 = new WindowsFormsControlLibrary.ctrl仕訳();
            this.cmd借方仕訳要素追加 = new System.Windows.Forms.Button();
            this.cmd貸方仕訳要素追加 = new System.Windows.Forms.Button();
            this.txt貸借差額 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "伝票番号:";
            // 
            // txt伝票番号
            // 
            this.txt伝票番号.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt伝票番号.Location = new System.Drawing.Point(203, 62);
            this.txt伝票番号.Name = "txt伝票番号";
            this.txt伝票番号.ReadOnly = true;
            this.txt伝票番号.Size = new System.Drawing.Size(204, 43);
            this.txt伝票番号.TabIndex = 1;
            this.txt伝票番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(520, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "計上日:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(111, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "借方合計金額:";
            // 
            // txt借方合計金額
            // 
            this.txt借方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方合計金額.Location = new System.Drawing.Point(117, 222);
            this.txt借方合計金額.Name = "txt借方合計金額";
            this.txt借方合計金額.ReadOnly = true;
            this.txt借方合計金額.Size = new System.Drawing.Size(214, 43);
            this.txt借方合計金額.TabIndex = 31;
            this.txt借方合計金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt貸方合計金額
            // 
            this.txt貸方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方合計金額.Location = new System.Drawing.Point(760, 222);
            this.txt貸方合計金額.Name = "txt貸方合計金額";
            this.txt貸方合計金額.ReadOnly = true;
            this.txt貸方合計金額.Size = new System.Drawing.Size(214, 43);
            this.txt貸方合計金額.TabIndex = 33;
            this.txt貸方合計金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(754, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 36);
            this.label9.TabIndex = 32;
            this.label9.Text = "貸方合計金額:";
            // 
            // cmd伝票を登録する
            // 
            this.cmd伝票を登録する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd伝票を登録する.Location = new System.Drawing.Point(1007, 48);
            this.cmd伝票を登録する.Name = "cmd伝票を登録する";
            this.cmd伝票を登録する.Size = new System.Drawing.Size(287, 75);
            this.cmd伝票を登録する.TabIndex = 34;
            this.cmd伝票を登録する.Text = "伝票を登録する";
            this.cmd伝票を登録する.UseVisualStyleBackColor = true;
            this.cmd伝票を登録する.Click += new System.EventHandler(this.cmd伝票を登録する_Click);
            // 
            // dtp計上日
            // 
            this.dtp計上日.CalendarFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp計上日.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp計上日.Location = new System.Drawing.Point(645, 62);
            this.dtp計上日.Name = "dtp計上日";
            this.dtp計上日.Size = new System.Drawing.Size(301, 43);
            this.dtp計上日.TabIndex = 35;
            // 
            // ctrl借方仕訳
            // 
            this.ctrl借方仕訳.Location = new System.Drawing.Point(73, 271);
            this.ctrl借方仕訳.Name = "ctrl借方仕訳";
            this.ctrl借方仕訳.Size = new System.Drawing.Size(620, 210);
            this.ctrl借方仕訳.TabIndex = 36;
            // 
            // ctrl貸方仕訳
            // 
            this.ctrl貸方仕訳.Location = new System.Drawing.Point(715, 271);
            this.ctrl貸方仕訳.Name = "ctrl貸方仕訳";
            this.ctrl貸方仕訳.Size = new System.Drawing.Size(620, 210);
            this.ctrl貸方仕訳.TabIndex = 37;
            // 
            // cmd借方仕訳要素追加
            // 
            this.cmd借方仕訳要素追加.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd借方仕訳要素追加.Location = new System.Drawing.Point(350, 222);
            this.cmd借方仕訳要素追加.Name = "cmd借方仕訳要素追加";
            this.cmd借方仕訳要素追加.Size = new System.Drawing.Size(202, 43);
            this.cmd借方仕訳要素追加.TabIndex = 38;
            this.cmd借方仕訳要素追加.Text = "借方仕訳追加";
            this.cmd借方仕訳要素追加.UseVisualStyleBackColor = true;
            this.cmd借方仕訳要素追加.Click += new System.EventHandler(this.cmd借方仕訳要素追加_Click);
            // 
            // cmd貸方仕訳要素追加
            // 
            this.cmd貸方仕訳要素追加.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd貸方仕訳要素追加.Location = new System.Drawing.Point(992, 222);
            this.cmd貸方仕訳要素追加.Name = "cmd貸方仕訳要素追加";
            this.cmd貸方仕訳要素追加.Size = new System.Drawing.Size(202, 43);
            this.cmd貸方仕訳要素追加.TabIndex = 39;
            this.cmd貸方仕訳要素追加.Text = "貸方仕訳追加";
            this.cmd貸方仕訳要素追加.UseVisualStyleBackColor = true;
            this.cmd貸方仕訳要素追加.Click += new System.EventHandler(this.cmd貸方仕訳要素追加_Click);
            // 
            // txt貸借差額
            // 
            this.txt貸借差額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸借差額.ForeColor = System.Drawing.Color.Red;
            this.txt貸借差額.Location = new System.Drawing.Point(526, 141);
            this.txt貸借差額.Name = "txt貸借差額";
            this.txt貸借差額.ReadOnly = true;
            this.txt貸借差額.Size = new System.Drawing.Size(214, 43);
            this.txt貸借差額.TabIndex = 41;
            this.txt貸借差額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(399, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "貸借差額:";
            // 
            // frmスタート画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 1504);
            this.Controls.Add(this.txt貸借差額);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrl貸方仕訳);
            this.Controls.Add(this.ctrl借方仕訳);
            this.Controls.Add(this.cmd貸方仕訳要素追加);
            this.Controls.Add(this.cmd借方仕訳要素追加);
            this.Controls.Add(this.dtp計上日);
            this.Controls.Add(this.cmd伝票を登録する);
            this.Controls.Add(this.txt貸方合計金額);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt借方合計金額);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt伝票番号);
            this.Controls.Add(this.label1);
            this.Name = "frmスタート画面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "プロトタイプ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt伝票番号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt借方合計金額;
        private System.Windows.Forms.TextBox txt貸方合計金額;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmd伝票を登録する;
        private System.Windows.Forms.DateTimePicker dtp計上日;
        private WindowsFormsControlLibrary.ctrl仕訳 ctrl借方仕訳;
        private WindowsFormsControlLibrary.ctrl仕訳 ctrl貸方仕訳;
        private System.Windows.Forms.Button cmd借方仕訳要素追加;
        private System.Windows.Forms.Button cmd貸方仕訳要素追加;
        private System.Windows.Forms.TextBox txt貸借差額;
        private System.Windows.Forms.Label label3;
    }
}

