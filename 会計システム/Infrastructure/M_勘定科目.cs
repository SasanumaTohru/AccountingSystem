//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSystem.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_勘定科目
    {
        public int 勘定科目コード { get; set; }
        public string 勘定科目名 { get; set; }
        public int 勘定区分 { get; set; }
        public int 流動損益区分 { get; set; }
        public int 集計区分 { get; set; }
        public int 管理番号 { get; set; }
        public bool 集計科目 { get; set; }
        public int 集計科目コード { get; set; }
    }
}
