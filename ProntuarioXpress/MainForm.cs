using UI.ViewItems;

namespace UI;

public partial class MainForm : Form, IMainForm
{
    public EventHandler? CreatePacientEvent { get; set; }
    public EventHandler<string>? RetrievePacientEvent { get; set; }
    public EventHandler<string>? DeletePacientEvent { get; set; }
    public EventHandler? MainFormLoadEvent { get; set; }

    public MainForm()
    {
        InitializeComponent();
    }

    public void SetEnabled(bool enabled)
    {
        Enabled = enabled;
    }

    public void LoadPacientList(ICollection<PacientListItemViewItem> pacients)
    {
        pacientListBox.DataSource = pacients.ToList();
        pacientListBox.SelectedIndex = -1;
        retrievePacientButton.Enabled = false;
        deletePacientButton.Enabled = false;
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
        MainFormLoadEvent?.Invoke(sender, EventArgs.Empty);
    }

    private void pacientListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        retrievePacientButton.Enabled = pacientListBox.SelectedItem is not null;
        deletePacientButton.Enabled = pacientListBox.SelectedItem is not null;
    }

    private void pacientListBox_DoubleClick(object sender, EventArgs e)
    {
        retrievePacientButton_Click(sender, e);
    }
}
