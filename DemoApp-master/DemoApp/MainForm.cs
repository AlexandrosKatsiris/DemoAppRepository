using System.Windows.Forms;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        public static bool hasClickedActivityType = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(hasClickedActivityType == false)
            {
                ActivityForm activityTypeForm = new ActivityForm();
                activityTypeForm.MdiParent = this;
                activityTypeForm.Show();
                hasClickedActivityType = true;
            }
            
            
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            IsMdiContainer = true; 
        }

        public void setHasClickedActivityType() { hasClickedActivityType = true; }
    }
}