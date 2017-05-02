namespace WindowsFormsControlLibrary
{
    partial class ctrl仕訳
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt摘要 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt金額 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb勘定科目 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt摘要
            // 
            this.txt摘要.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt摘要.Location = new System.Drawing.Point(167, 140);
            this.txt摘要.Name = "txt摘要";
            this.txt摘要.Size = new System.Drawing.Size(414, 43);
            this.txt摘要.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "摘要:";
            // 
            // txt金額
            // 
            this.txt金額.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt金額.Location = new System.Drawing.Point(167, 80);
            this.txt金額.Name = "txt金額";
            this.txt金額.Size = new System.Drawing.Size(214, 43);
            this.txt金額.TabIndex = 14;
            this.txt金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "金額:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "勘定科目:";
            // 
            // cmb勘定科目
            // 
            this.cmb勘定科目.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb勘定科目.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb勘定科目.FormattingEnabled = true;
            this.cmb勘定科目.Location = new System.Drawing.Point(167, 20);
            this.cmb勘定科目.Name = "cmb勘定科目";
            this.cmb勘定科目.Size = new System.Drawing.Size(414, 44);
            this.cmb勘定科目.TabIndex = 12;
            // 
            // ctrl仕訳
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt摘要);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt金額);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb勘定科目);
            this.Name = "ctrl仕訳";
            this.Size = new System.Drawing.Size(620, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox txt摘要;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt金額;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmb勘定科目;
    }
}
