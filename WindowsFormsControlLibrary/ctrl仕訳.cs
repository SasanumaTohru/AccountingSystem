using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class ctrl仕訳: UserControl
    {

        public enum 貸借
        {
            借方=1,
            貸方=2,
        }

        private 貸借 m_貸借;

        public ctrl仕訳()
        {
            InitializeComponent();
        }

        public 貸借 貸借区分
        {
            get => m_貸借;
            set => m_貸借 = value;
        }

        public int 貸借区分番号
        {
            get
            {
                int r =1;
                switch (m_貸借)
                {
                    case 貸借.借方:
                        r = 1;
                        break;
                    case 貸借.貸方:
                        r = 2;
                        break;
                }
                return r;
            }
        }
    }
}
