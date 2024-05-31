namespace UI
{
    public partial class AppointmentForm : Form, IAppointmentForm
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void ammountDueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
