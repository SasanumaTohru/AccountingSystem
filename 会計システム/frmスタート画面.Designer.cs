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
            this.dgv伝票検索結果ビュー = new System.Windows.Forms.DataGridView();
            this.cmd伝票番号検索 = new System.Windows.Forms.Button();
            this.cmd計上日検索 = new System.Windows.Forms.Button();
            this.cmd勘定科目検索 = new System.Windows.Forms.Button();
            this.cmb検索する勘定科目 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd画面キャプチャ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv伝票検索結果ビュー)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "伝票番号:";
            // 
            // txt伝票番号
            // 
            this.txt伝票番号.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt伝票番号.Location = new System.Drawing.Point(183, 64);
            this.txt伝票番号.Name = "txt伝票番号";
            this.txt伝票番号.Size = new System.Drawing.Size(204, 43);
            this.txt伝票番号.TabIndex = 1;
            this.txt伝票番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(500, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "計上日:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(65, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "借方合計金額:";
            // 
            // txt借方合計金額
            // 
            this.txt借方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方合計金額.Location = new System.Drawing.Point(71, 194);
            this.txt借方合計金額.Name = "txt借方合計金額";
            this.txt借方合計金額.ReadOnly = true;
            this.txt借方合計金額.Size = new System.Drawing.Size(214, 43);
            this.txt借方合計金額.TabIndex = 31;
            this.txt借方合計金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt貸方合計金額
            // 
            this.txt貸方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方合計金額.Location = new System.Drawing.Point(844, 194);
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
            this.label9.Location = new System.Drawing.Point(838, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 36);
            this.label9.TabIndex = 32;
            this.label9.Text = "貸方合計金額:";
            // 
            // cmd伝票を登録する
            // 
            this.cmd伝票を登録する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd伝票を登録する.Location = new System.Drawing.Point(987, 50);
            this.cmd伝票を登録する.Name = "cmd伝票を登録する";
            this.cmd伝票を登録する.Size = new System.Drawing.Size(287, 75);
            this.cmd伝票を登録する.TabIndex = 34;
            this.cmd伝票を登録する.Text = "伝票登録";
            this.cmd伝票を登録する.UseVisualStyleBackColor = true;
            this.cmd伝票を登録する.Click += new System.EventHandler(this.cmd伝票を登録する_Click);
            // 
            // dtp計上日
            // 
            this.dtp計上日.CalendarFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp計上日.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp計上日.Location = new System.Drawing.Point(625, 64);
            this.dtp計上日.Name = "dtp計上日";
            this.dtp計上日.Size = new System.Drawing.Size(301, 43);
            this.dtp計上日.TabIndex = 35;
            // 
            // ctrl借方仕訳
            // 
            this.ctrl借方仕訳.Location = new System.Drawing.Point(53, 273);
            this.ctrl借方仕訳.Name = "ctrl借方仕訳";
            this.ctrl借方仕訳.Size = new System.Drawing.Size(620, 210);
            this.ctrl借方仕訳.TabIndex = 36;
            // 
            // ctrl貸方仕訳
            // 
            this.ctrl貸方仕訳.Location = new System.Drawing.Point(695, 273);
            this.ctrl貸方仕訳.Name = "ctrl貸方仕訳";
            this.ctrl貸方仕訳.Size = new System.Drawing.Size(620, 210);
            this.ctrl貸方仕訳.TabIndex = 37;
            // 
            // cmd借方仕訳要素追加
            // 
            this.cmd借方仕訳要素追加.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd借方仕訳要素追加.Location = new System.Drawing.Point(302, 185);
            this.cmd借方仕訳要素追加.Name = "cmd借方仕訳要素追加";
            this.cmd借方仕訳要素追加.Size = new System.Drawing.Size(202, 55);
            this.cmd借方仕訳要素追加.TabIndex = 38;
            this.cmd借方仕訳要素追加.Text = "借方仕訳追加";
            this.cmd借方仕訳要素追加.UseVisualStyleBackColor = true;
            this.cmd借方仕訳要素追加.Click += new System.EventHandler(this.cmd借方仕訳要素追加_Click);
            // 
            // cmd貸方仕訳要素追加
            // 
            this.cmd貸方仕訳要素追加.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd貸方仕訳要素追加.Location = new System.Drawing.Point(1072, 182);
            this.cmd貸方仕訳要素追加.Name = "cmd貸方仕訳要素追加";
            this.cmd貸方仕訳要素追加.Size = new System.Drawing.Size(202, 55);
            this.cmd貸方仕訳要素追加.TabIndex = 39;
            this.cmd貸方仕訳要素追加.Text = "貸方仕訳追加";
            this.cmd貸方仕訳要素追加.UseVisualStyleBackColor = true;
            this.cmd貸方仕訳要素追加.Click += new System.EventHandler(this.cmd貸方仕訳要素追加_Click);
            // 
            // txt貸借差額
            // 
            this.txt貸借差額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸借差額.ForeColor = System.Drawing.Color.Red;
            this.txt貸借差額.Location = new System.Drawing.Point(564, 194);
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
            this.label3.Location = new System.Drawing.Point(558, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "貸借差額:";
            // 
            // dgv会計伝票
            // 
            this.dgv伝票検索結果ビュー.AllowUserToAddRows = false;
            this.dgv伝票検索結果ビュー.AllowUserToDeleteRows = false;
            this.dgv伝票検索結果ビュー.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv伝票検索結果ビュー.Location = new System.Drawing.Point(1373, 243);
            this.dgv伝票検索結果ビュー.Name = "dgv会計伝票";
            this.dgv伝票検索結果ビュー.ReadOnly = true;
            this.dgv伝票検索結果ビュー.RowTemplate.Height = 33;
            this.dgv伝票検索結果ビュー.Size = new System.Drawing.Size(786, 1165);
            this.dgv伝票検索結果ビュー.TabIndex = 44;
            this.dgv伝票検索結果ビュー.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv伝票検索結果ビュー_CellContentDoubleClick);
            // 
            // cmd伝票番号検索
            // 
            this.cmd伝票番号検索.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd伝票番号検索.Location = new System.Drawing.Point(1373, 48);
            this.cmd伝票番号検索.Name = "cmd伝票番号検索";
            this.cmd伝票番号検索.Size = new System.Drawing.Size(221, 75);
            this.cmd伝票番号検索.TabIndex = 45;
            this.cmd伝票番号検索.Text = "伝票番号検索";
            this.cmd伝票番号検索.UseVisualStyleBackColor = true;
            this.cmd伝票番号検索.Click += new System.EventHandler(this.cmd伝票番号検索_Click);
            // 
            // cmd計上日検索
            // 
            this.cmd計上日検索.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd計上日検索.Location = new System.Drawing.Point(1611, 48);
            this.cmd計上日検索.Name = "cmd計上日検索";
            this.cmd計上日検索.Size = new System.Drawing.Size(209, 75);
            this.cmd計上日検索.TabIndex = 46;
            this.cmd計上日検索.Text = "計上日検索";
            this.cmd計上日検索.UseVisualStyleBackColor = true;
            this.cmd計上日検索.Click += new System.EventHandler(this.cmd計上日検索_Click);
            // 
            // cmd勘定科目検索
            // 
            this.cmd勘定科目検索.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd勘定科目検索.Location = new System.Drawing.Point(1839, 48);
            this.cmd勘定科目検索.Name = "cmd勘定科目検索";
            this.cmd勘定科目検索.Size = new System.Drawing.Size(217, 75);
            this.cmd勘定科目検索.TabIndex = 47;
            this.cmd勘定科目検索.Text = "勘定科目検索";
            this.cmd勘定科目検索.UseVisualStyleBackColor = true;
            this.cmd勘定科目検索.Click += new System.EventHandler(this.cmd勘定科目検索_Click);
            // 
            // cmb検索する勘定科目
            // 
            this.cmb検索する勘定科目.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb検索する勘定科目.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb検索する勘定科目.FormattingEnabled = true;
            this.cmb検索する勘定科目.Location = new System.Drawing.Point(1666, 136);
            this.cmb検索する勘定科目.Name = "cmb検索する勘定科目";
            this.cmb検索する勘定科目.Size = new System.Drawing.Size(412, 44);
            this.cmb検索する勘定科目.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(1414, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "検索する勘定科目:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(1367, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "伝票検索結果:";
            // 
            // cmd画面キャプチャ
            // 
            this.cmd画面キャプチャ.BackColor = System.Drawing.Color.MistyRose;
            this.cmd画面キャプチャ.Font = new System.Drawing.Font("メイリオ", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd画面キャプチャ.Location = new System.Drawing.Point(1976, 1433);
            this.cmd画面キャプチャ.Name = "cmd画面キャプチャ";
            this.cmd画面キャプチャ.Size = new System.Drawing.Size(205, 59);
            this.cmd画面キャプチャ.TabIndex = 52;
            this.cmd画面キャプチャ.Text = "画面キャプチャ";
            this.cmd画面キャプチャ.UseVisualStyleBackColor = false;
            this.cmd画面キャプチャ.Click += new System.EventHandler(this.cmd画面キャプチャ_Click);
            // 
            // frmスタート画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2193, 1504);
            this.Controls.Add(this.cmd画面キャプチャ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb検索する勘定科目);
            this.Controls.Add(this.cmd勘定科目検索);
            this.Controls.Add(this.cmd計上日検索);
            this.Controls.Add(this.cmd伝票番号検索);
            this.Controls.Add(this.dgv伝票検索結果ビュー);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv伝票検索結果ビュー)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv伝票検索結果ビュー;
        private System.Windows.Forms.Button cmd伝票番号検索;
        private System.Windows.Forms.Button cmd計上日検索;
        private System.Windows.Forms.Button cmd勘定科目検索;
        private System.Windows.Forms.ComboBox cmb検索する勘定科目;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmd画面キャプチャ;
    }
}

