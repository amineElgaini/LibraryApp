using System.Deployment.Internal;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserInfo : Form
    {
        public int userId { get; set; }

        public UserInfo(int id)
        {
            InitializeComponent();
            this.userId = id;
        }

        private void UserInfo_Load(object sender, System.EventArgs e)
        {
            //ctrUserInfo1.LoadUserInfo(userId);
            
        }

    }
}
