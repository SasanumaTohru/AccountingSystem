namespace AccountingSystem.UserInterface
{
    partial class frmレポート
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd合計残高試算表 = new System.Windows.Forms.Button();
            this.txtビュー = new System.Windows.Forms.TextBox();
            this.cmd閉じる = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd合計残高試算表
            // 
            this.cmd合計残高試算表.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd合計残高試算表.Location = new System.Drawing.Point(1140, 102);
            this.cmd合計残高試算表.Name = "cmd合計残高試算表";
            this.cmd合計残高試算表.Size = new System.Drawing.Size(266, 83);
            this.cmd合計残高試算表.TabIndex = 0;
            this.cmd合計残高試算表.Text = "合計残高試算表";
            this.cmd合計残高試算表.UseVisualStyleBackColor = true;
            this.cmd合計残高試算表.Click += new System.EventHandler(this.cmd合計残高試算表_Click);
            // 
            // txtビュー
            // 
            this.txtビュー.Font = new System.Drawing.Font("メイリオ", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtビュー.Location = new System.Drawing.Point(12, 12);
            this.txtビュー.Multiline = true;
            this.txtビュー.Name = "txtビュー";
            this.txtビュー.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtビュー.Size = new System.Drawing.Size(920, 1480);
            this.txtビュー.TabIndex = 1;
            // 
            // cmd閉じる
            // 
            this.cmd閉じる.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmd閉じる.Location = new System.Drawing.Point(1140, 241);
            this.cmd閉じる.Name = "cmd閉じる";
            this.cmd閉じる.Size = new System.Drawing.Size(266, 83);
            this.cmd閉じる.TabIndex = 2;
            this.cmd閉じる.Text = "閉じる";
            this.cmd閉じる.UseVisualStyleBackColor = true;
            this.cmd閉じる.Click += new System.EventHandler(this.cmd閉じる_Click);
            // 
            // frmレポート
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2193, 1504);
            this.Controls.Add(this.cmd閉じる);
            this.Controls.Add(this.txtビュー);
            this.Controls.Add(this.cmd合計残高試算表);
            this.Name = "frmレポート";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レポート画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd合計残高試算表;
        private System.Windows.Forms.TextBox txtビュー;
        private System.Windows.Forms.Button cmd閉じる;
    }
}