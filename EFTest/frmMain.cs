namespace EFTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new();
            frm.ShowDialog();
        }

        private void mnuFileCreateDatabase_Click(object sender, EventArgs e)
        {
            EFTestBR.Db.DbUtil.CreateDb();
        }

        private void mnuFileDeleteDatabase_Click(object sender, EventArgs e)
        {
            EFTestBR.Db.DbUtil.DeleteDb();
        }
    }
}
