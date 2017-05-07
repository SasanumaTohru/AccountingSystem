﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 会計システム.ApplicationService
{
    public class 動作記録サービス
    {
        public void 表示画面をファイルに保存する(Form 対象画面)
        {
            Bitmap 記録する画面 = new Bitmap(対象画面.Width, 対象画面.Height);
            対象画面.DrawToBitmap(記録する画面, new Rectangle(0, 0, 対象画面.Width, 対象画面.Height));
            string ファイル識別名 = new ApplicationService.識別子作成サービス().日時文字列;
            Infrastructure.画面画像保存サービス 画面保存サービス = new Infrastructure.画面画像保存サービス();
            画面保存サービス.保存する(記録する画面, ファイル識別名);
            記録する画面.Dispose();
        }

        
    }
}
