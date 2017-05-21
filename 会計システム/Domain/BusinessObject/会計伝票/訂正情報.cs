using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Domain.BusinessObject.会計伝票
{
    public class 訂正情報
    {
        public bool 訂正の有無 { get; set; } = false;
        public bool 訂正伝票である { get; set; } = false;
    }
}
