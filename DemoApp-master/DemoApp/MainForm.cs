using System.Windows.Forms;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        private bool hasClickedActivityType = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.hasClickedActivityType == false)
            {
                Form1 activityTypeForm = new Form1();
                activityTypeForm.MdiParent = this;
                activityTypeForm.Show();
                this.hasClickedActivityType = true;
            }
            
            
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            IsMdiContainer = true; 
        }

        public void setHasClickedActivityType() { hasClickedActivityType = true; }
    }
}