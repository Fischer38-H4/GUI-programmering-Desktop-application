namespace WinFormsApp1;

public partial class itemDetaljer : Form
{
    public itemDetaljer(Equipment equipment)
    {
        InitializeComponent();

        Text = $"Detaljer - {equipment.Name}";
        titleLabel.Text = equipment.Name;
        categoryValueLabel.Text = equipment.Category;
        serialNumberValueLabel.Text = equipment.SerialNumber;
        statusValueLabel.Text = equipment.Status;
        noteTextBox.Text = equipment.Note;
    }

    public string UpdatedNote => noteTextBox.Text.Trim();

    private void SaveButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}