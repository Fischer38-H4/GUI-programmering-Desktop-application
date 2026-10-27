namespace WinFormsApp1;

public partial class NewItem : Form
{
    private readonly Equipment? existingEquipment;

    public NewItem()
        : this(null)
    {
    }

    public NewItem(Equipment? equipment, IEnumerable<string>? existingCategories = null)
    {
        InitializeComponent();
        existingEquipment = equipment;

        categoryComboBox.Items.AddRange((existingCategories ?? [])
            .Where(category => !string.IsNullOrWhiteSpace(category))
            .Distinct(StringComparer.CurrentCultureIgnoreCase)
            .Cast<object>()
            .ToArray());
        categoryComboBox.AutoCompleteCustomSource.AddRange(
            categoryComboBox.Items.Cast<string>().ToArray());
        categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        categoryComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

        statusComboBox.Items.AddRange(["Ledig", "Udlånt"]);
        statusComboBox.SelectedIndex = 0;

        if (equipment is null)
        {
            return;
        }

        nameTextBox.Text = equipment.Name;
        categoryComboBox.Text = equipment.Category;
        serialNumberTextBox.Text = equipment.SerialNumber;
        statusComboBox.SelectedItem = equipment.Status;
        Text = "Rediger vare";
        titleLabel.Text = "Rediger vare";
        subtitleLabel.Text = "Ret oplysningerne, og gem ændringerne.";
        saveButton.Text = "Gem ændringer";
    }

    public Equipment? CreatedEquipment { get; private set; }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var name = nameTextBox.Text.Trim();
        var category = categoryComboBox.Text.Trim();
        var serialNumber = serialNumberTextBox.Text.Trim();
        var status = statusComboBox.Text;

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) ||
            string.IsNullOrWhiteSpace(serialNumber) || string.IsNullOrWhiteSpace(status))
        {
            MessageBox.Show("Udfyld alle felter.", "Manglende oplysninger",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        CreatedEquipment = new Equipment(
            name, category, serialNumber, status, existingEquipment?.Note ?? string.Empty);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}