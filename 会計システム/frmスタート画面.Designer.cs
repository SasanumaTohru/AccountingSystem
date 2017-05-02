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
            this.label1 = new System.Windows.Forms.Label();
            this.txt伝票番号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb借方勘定科目1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt借方金額1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt借方摘要1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt借方合計金額 = new System.Windows.Forms.TextBox();
            this.txt貸方合計金額 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt貸方摘要1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt貸方金額1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb貸方勘定科目1 = new System.Windows.Forms.ComboBox();
            this.txt貸方摘要2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt貸方金額2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb貸方勘定科目2 = new System.Windows.Forms.ComboBox();
            this.txt借方摘要2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt借方金額2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb借方勘定科目2 = new System.Windows.Forms.ComboBox();
            this.cmd伝票を登録する = new System.Windows.Forms.Button();
            this.dtp計上日 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmd取引勘定科目の一覧を表示する
            // 
            this.cmd取引勘定科目の一覧を表示する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd取引勘定科目の一覧を表示する.Location = new System.Drawing.Point(513, 68);
            this.cmd取引勘定科目の一覧を表示する.Name = "cmd取引勘定科目の一覧を表示する";
            this.cmd取引勘定科目の一覧を表示する.Size = new System.Drawing.Size(435, 75);
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
            this.lst一覧表示.Size = new System.Drawing.Size(450, 364);
            this.lst一覧表示.TabIndex = 1;
            // 
            // cmdすべての勘定科目の一覧を表示する
            // 
            this.cmdすべての勘定科目の一覧を表示する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdすべての勘定科目の一覧を表示する.Location = new System.Drawing.Point(513, 164);
            this.cmdすべての勘定科目の一覧を表示する.Name = "cmdすべての勘定科目の一覧を表示する";
            this.cmdすべての勘定科目の一覧を表示する.Size = new System.Drawing.Size(435, 75);
            this.cmdすべての勘定科目の一覧を表示する.TabIndex = 2;
            this.cmdすべての勘定科目の一覧を表示する.Text = "すべての勘定科目の一覧を表示する";
            this.cmdすべての勘定科目の一覧を表示する.UseVisualStyleBackColor = true;
            this.cmdすべての勘定科目の一覧を表示する.Click += new System.EventHandler(this.cmdすべての勘定科目の一覧を表示する_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(729, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "伝票番号:";
            // 
            // txt伝票番号
            // 
            this.txt伝票番号.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt伝票番号.Location = new System.Drawing.Point(856, 395);
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
            this.label2.Location = new System.Drawing.Point(1173, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "計上日:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(662, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "借方";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(1296, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "貸方";
            // 
            // cmb借方勘定科目1
            // 
            this.cmb借方勘定科目1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb借方勘定科目1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb借方勘定科目1.FormattingEnabled = true;
            this.cmb借方勘定科目1.Location = new System.Drawing.Point(825, 554);
            this.cmb借方勘定科目1.Name = "cmb借方勘定科目1";
            this.cmb借方勘定科目1.Size = new System.Drawing.Size(414, 44);
            this.cmb借方勘定科目1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(676, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "勘定科目:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(676, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "金額:";
            // 
            // txt借方金額1
            // 
            this.txt借方金額1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方金額1.Location = new System.Drawing.Point(825, 614);
            this.txt借方金額1.Name = "txt借方金額1";
            this.txt借方金額1.Size = new System.Drawing.Size(214, 43);
            this.txt借方金額1.TabIndex = 8;
            this.txt借方金額1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(676, 677);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "摘要:";
            // 
            // txt借方摘要1
            // 
            this.txt借方摘要1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方摘要1.Location = new System.Drawing.Point(825, 674);
            this.txt借方摘要1.Name = "txt借方摘要1";
            this.txt借方摘要1.Size = new System.Drawing.Size(414, 43);
            this.txt借方摘要1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(850, 1019);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "借方合計金額:";
            // 
            // txt借方合計金額
            // 
            this.txt借方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方合計金額.Location = new System.Drawing.Point(1025, 1016);
            this.txt借方合計金額.Name = "txt借方合計金額";
            this.txt借方合計金額.ReadOnly = true;
            this.txt借方合計金額.Size = new System.Drawing.Size(214, 43);
            this.txt借方合計金額.TabIndex = 31;
            this.txt借方合計金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt貸方合計金額
            // 
            this.txt貸方合計金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方合計金額.Location = new System.Drawing.Point(1659, 1012);
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
            this.label9.Location = new System.Drawing.Point(1484, 1015);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 36);
            this.label9.TabIndex = 32;
            this.label9.Text = "貸方合計金額:";
            // 
            // txt貸方摘要1
            // 
            this.txt貸方摘要1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方摘要1.Location = new System.Drawing.Point(1459, 674);
            this.txt貸方摘要1.Name = "txt貸方摘要1";
            this.txt貸方摘要1.Size = new System.Drawing.Size(414, 43);
            this.txt貸方摘要1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(1310, 677);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 36);
            this.label10.TabIndex = 16;
            this.label10.Text = "摘要:";
            // 
            // txt貸方金額1
            // 
            this.txt貸方金額1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方金額1.Location = new System.Drawing.Point(1459, 614);
            this.txt貸方金額1.Name = "txt貸方金額1";
            this.txt貸方金額1.Size = new System.Drawing.Size(214, 43);
            this.txt貸方金額1.TabIndex = 15;
            this.txt貸方金額1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(1310, 617);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 36);
            this.label11.TabIndex = 14;
            this.label11.Text = "金額:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(1310, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 36);
            this.label12.TabIndex = 12;
            this.label12.Text = "勘定科目:";
            // 
            // cmb貸方勘定科目1
            // 
            this.cmb貸方勘定科目1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb貸方勘定科目1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb貸方勘定科目1.FormattingEnabled = true;
            this.cmb貸方勘定科目1.Location = new System.Drawing.Point(1459, 554);
            this.cmb貸方勘定科目1.Name = "cmb貸方勘定科目1";
            this.cmb貸方勘定科目1.Size = new System.Drawing.Size(414, 44);
            this.cmb貸方勘定科目1.TabIndex = 13;
            // 
            // txt貸方摘要2
            // 
            this.txt貸方摘要2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方摘要2.Location = new System.Drawing.Point(1459, 902);
            this.txt貸方摘要2.Name = "txt貸方摘要2";
            this.txt貸方摘要2.Size = new System.Drawing.Size(414, 43);
            this.txt貸方摘要2.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(1310, 905);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 36);
            this.label13.TabIndex = 28;
            this.label13.Text = "摘要:";
            // 
            // txt貸方金額2
            // 
            this.txt貸方金額2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt貸方金額2.Location = new System.Drawing.Point(1459, 842);
            this.txt貸方金額2.Name = "txt貸方金額2";
            this.txt貸方金額2.Size = new System.Drawing.Size(214, 43);
            this.txt貸方金額2.TabIndex = 27;
            this.txt貸方金額2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(1310, 845);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 36);
            this.label14.TabIndex = 26;
            this.label14.Text = "金額:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(1310, 785);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 36);
            this.label15.TabIndex = 24;
            this.label15.Text = "勘定科目:";
            // 
            // cmb貸方勘定科目2
            // 
            this.cmb貸方勘定科目2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb貸方勘定科目2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb貸方勘定科目2.FormattingEnabled = true;
            this.cmb貸方勘定科目2.Location = new System.Drawing.Point(1459, 782);
            this.cmb貸方勘定科目2.Name = "cmb貸方勘定科目2";
            this.cmb貸方勘定科目2.Size = new System.Drawing.Size(414, 44);
            this.cmb貸方勘定科目2.TabIndex = 25;
            // 
            // txt借方摘要2
            // 
            this.txt借方摘要2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方摘要2.Location = new System.Drawing.Point(825, 902);
            this.txt借方摘要2.Name = "txt借方摘要2";
            this.txt借方摘要2.Size = new System.Drawing.Size(414, 43);
            this.txt借方摘要2.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(676, 905);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 36);
            this.label16.TabIndex = 22;
            this.label16.Text = "摘要:";
            // 
            // txt借方金額2
            // 
            this.txt借方金額2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt借方金額2.Location = new System.Drawing.Point(825, 842);
            this.txt借方金額2.Name = "txt借方金額2";
            this.txt借方金額2.Size = new System.Drawing.Size(214, 43);
            this.txt借方金額2.TabIndex = 21;
            this.txt借方金額2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(676, 845);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 36);
            this.label17.TabIndex = 20;
            this.label17.Text = "金額:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(676, 785);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 36);
            this.label18.TabIndex = 18;
            this.label18.Text = "勘定科目:";
            // 
            // cmb借方勘定科目2
            // 
            this.cmb借方勘定科目2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb借方勘定科目2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb借方勘定科目2.FormattingEnabled = true;
            this.cmb借方勘定科目2.Location = new System.Drawing.Point(825, 782);
            this.cmb借方勘定科目2.Name = "cmb借方勘定科目2";
            this.cmb借方勘定科目2.Size = new System.Drawing.Size(414, 44);
            this.cmb借方勘定科目2.TabIndex = 19;
            // 
            // cmd伝票を登録する
            // 
            this.cmd伝票を登録する.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd伝票を登録する.Location = new System.Drawing.Point(1564, 1134);
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
            this.dtp計上日.Location = new System.Drawing.Point(1298, 395);
            this.dtp計上日.Name = "dtp計上日";
            this.dtp計上日.Size = new System.Drawing.Size(301, 43);
            this.dtp計上日.TabIndex = 35;
            // 
            // frmスタート画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2321, 1550);
            this.Controls.Add(this.dtp計上日);
            this.Controls.Add(this.cmd伝票を登録する);
            this.Controls.Add(this.txt貸方摘要2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt貸方金額2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmb貸方勘定科目2);
            this.Controls.Add(this.txt借方摘要2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt借方金額2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmb借方勘定科目2);
            this.Controls.Add(this.txt貸方合計金額);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt貸方摘要1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt貸方金額1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb貸方勘定科目1);
            this.Controls.Add(this.txt借方合計金額);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt借方摘要1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt借方金額1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb借方勘定科目1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt伝票番号);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdすべての勘定科目の一覧を表示する);
            this.Controls.Add(this.lst一覧表示);
            this.Controls.Add(this.cmd取引勘定科目の一覧を表示する);
            this.Name = "frmスタート画面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "プロトタイプ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd取引勘定科目の一覧を表示する;
        private System.Windows.Forms.ListBox lst一覧表示;
        private System.Windows.Forms.Button cmdすべての勘定科目の一覧を表示する;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt伝票番号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb借方勘定科目1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt借方金額1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt借方摘要1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt借方合計金額;
        private System.Windows.Forms.TextBox txt貸方合計金額;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt貸方摘要1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt貸方金額1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb貸方勘定科目1;
        private System.Windows.Forms.TextBox txt貸方摘要2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt貸方金額2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb貸方勘定科目2;
        private System.Windows.Forms.TextBox txt借方摘要2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt借方金額2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb借方勘定科目2;
        private System.Windows.Forms.Button cmd伝票を登録する;
        private System.Windows.Forms.DateTimePicker dtp計上日;
    }
}

