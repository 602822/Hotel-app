namespace Maintance_App
{
    public partial class HovedVindu : Form
    {
        public HovedVindu()
        {
            InitializeComponent();
        }

        private void HovedVindu_Load(object sender, EventArgs e)
        {

        }

        //Redirecter deg til AddandRemoveTask.cs n�r du trykker p� knappen
        private void addOrDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddandRemoveTask addorRemoveTask = new AddandRemoveTask();
            addorRemoveTask.Show();

        }

        //Redirecter deg til EditStatus.cs n�r du trykker p� knappen
        private void editStatusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStatus editStatus = new EditStatus();
            editStatus.Show();

        }
    }
}