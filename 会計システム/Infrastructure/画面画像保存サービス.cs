using System.Drawing;

namespace AccountingSystem.Infrastructure
{
    public class 画面画像保存サービス
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="記録する画面"></param>
        /// <param name="ファイル識別名"></param>
        public void 保存する(Bitmap 記録する画面, string ファイル識別名)
        {
            記録する画面.Save(@"C:\会計システムキャプチャ画像\伝票画面" + ファイル識別名 + ".jpg");
        }
    }
}
