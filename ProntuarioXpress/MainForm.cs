using UI.ViewItem;

namespace UI
{
    public partial class MainForm : Form
    {
        public EventHandler? CreatePacientEvent;
        public EventHandler<string>? RetrievePacientEvent;
        public EventHandler<string>? DeletePacientEvent;
        public EventHandler? MainFormLoadEvent;

        private ICollection<PacientListItemViewItem> pacients = [];

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadPacientList(ICollection<PacientListItemViewItem> pacients)
        {
            this.pacients = pacients;
            pacientListBox.BeginUpdate();
            pacientListBox.Items.Clear();

            foreach (var item in this.pacients)
            {
                pacientListBox.Items.Add(item);
            }

            pacientListBox.SelectedItem = null;
            pacientListBox.EndUpdate();
            retrievePacientButton.Enabled = false;
        }

        private void createPacientButton_Click(object sender, EventArgs e)
        {
            CreatePacientEvent?.Invoke(sender, EventArgs.Empty);
        }

        private void retrievePacientButton_Click(object sender, EventArgs e)
        {
            var id = (pacientListBox.SelectedItem as PacientListItemViewItem)?.Id;
            if (id is not null)
            {
                RetrievePacientEvent?.Invoke(sender, id);
            }
        }

        private void deletePacientButton_Click(object sender, EventArgs e)
        {
            var id = (pacientListBox.SelectedItem as PacientListItemViewItem)?.Id;
            if (id is not null)
            {
                DeletePacientEvent?.Invoke(sender, id);
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por Rafael", "Sobre...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pacientListBox.SelectionMode = SelectionMode.One;
            MainFormLoadEvent?.Invoke(sender, EventArgs.Empty);
        }

        private void pacientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            retrievePacientButton.Enabled = pacientListBox.SelectedItem is not null;
        }
    }
}
