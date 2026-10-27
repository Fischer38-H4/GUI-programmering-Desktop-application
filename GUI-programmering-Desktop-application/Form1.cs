namespace WinFormsApp1;

public partial class Form1 : Form
{
    private const string NameColumn = nameof(Equipment.Name);
    private const string CategoryColumn = nameof(Equipment.Category);
    private const string SerialNumberColumn = nameof(Equipment.SerialNumber);
    private const string StatusColumn = nameof(Equipment.Status);

    public Form1()
    {
        InitializeComponent();

        itemsGrid.Columns.Add(NameColumn, "Navn");
        itemsGrid.Columns.Add(CategoryColumn, "Kategori");
        itemsGrid.Columns.Add(SerialNumberColumn, "Serienummer");
        itemsGrid.Columns.Add(StatusColumn, "Status");
        itemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        itemsGrid.RowHeadersVisible = false;
        itemsGrid.AllowUserToAddRows = false;
        itemsGrid.AllowUserToDeleteRows = false;
        itemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        itemsGrid.MultiSelect = false;
        itemsGrid.KeyDown += ItemsGrid_KeyDown;
        itemsGrid.SelectionChanged += ItemsGrid_SelectionChanged;
        UpdateSelectionActions();

        categoryFilterComboBox.Items.Add("Alle");
        categoryFilterComboBox.SelectedIndex = 0;
        statusFilterComboBox.Items.AddRange(["Alle", "Ledig", "Udlånt"]);
        statusFilterComboBox.SelectedIndex = 0;

        nameSearchTextBox.TextChanged += FilterControls_Changed;
        serialSearchTextBox.TextChanged += FilterControls_Changed;
        categoryFilterComboBox.SelectedIndexChanged += FilterControls_Changed;
        statusFilterComboBox.SelectedIndexChanged += FilterControls_Changed;
    }

    private void EditSelectedItem_Click(object sender, EventArgs e)
    {
        if (GetSelectedRow() is not { } row)
        {
            MessageBox.Show("Vælg en vare, du vil redigere.", "Ingen vare valgt",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var form = new NewItem(CreateEquipmentFromRow(row), GetExistingCategories());
        if (form.ShowDialog(this) != DialogResult.OK || form.CreatedEquipment is not { } equipment)
        {
            return;
        }

        SetRowValues(row, equipment);
        UpdateCategoryFilter();
        ApplyFilters();
    }

    private void DeleteSelectedItem_Click(object sender, EventArgs e)
    {
        DeleteSelectedItem();
    }

    private void ShowSelectedItemDetails_Click(object sender, EventArgs e)
    {
        if (GetSelectedRow() is not { } row)
        {
            MessageBox.Show("Vælg en vare, du vil se detaljer for.", "Ingen vare valgt",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var equipment = CreateEquipmentFromRow(row);
        using var form = new itemDetaljer(equipment);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            SetRowValues(row, new Equipment(
                equipment.Name,
                equipment.Category,
                equipment.SerialNumber,
                equipment.Status,
                form.UpdatedNote));
        }
    }

    private void ItemsGrid_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Delete || itemsGrid.IsCurrentCellInEditMode)
        {
            return;
        }

        e.SuppressKeyPress = true;
        DeleteSelectedItem();
    }

    private void DeleteSelectedItem()
    {
        if (GetSelectedRow() is not { } row)
        {
            MessageBox.Show("Vælg en vare, du vil slette.", "Ingen vare valgt",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var name = Convert.ToString(row.Cells[NameColumn].Value) ?? "den valgte vare";
        var result = MessageBox.Show(
            $"Er du sikker på, at du vil slette \"{name}\"?",
            "Bekræft sletning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

        if (result == DialogResult.Yes)
        {
            itemsGrid.Rows.Remove(row);
            UpdateCategoryFilter();
            ApplyFilters();
        }
    }

    private DataGridViewRow? GetSelectedRow()
    {
        return itemsGrid.SelectedRows.Count > 0 ? itemsGrid.SelectedRows[0] : null;
    }

    private void ItemsGrid_SelectionChanged(object? sender, EventArgs e)
    {
        UpdateSelectionActions();
    }

    private void UpdateSelectionActions()
    {
        var hasSelection = GetSelectedRow() is not null;
        editButton.Enabled = hasSelection;
        deleteButton.Enabled = hasSelection;
        detailsButton.Enabled = hasSelection;
    }

    private IEnumerable<string> GetExistingCategories()
    {
        return itemsGrid.Rows
            .Cast<DataGridViewRow>()
            .Select(row => Convert.ToString(row.Cells[CategoryColumn].Value))
            .Where(category => !string.IsNullOrWhiteSpace(category))
            .Select(category => category!);
    }

    private void AddNewItem_Click(object sender, EventArgs e)
    {
        using var form = new NewItem(null, GetExistingCategories());
        if (form.ShowDialog(this) != DialogResult.OK || form.CreatedEquipment is not { } equipment)
        {
            return;
        }

        AddEquipmentRow(equipment);
        UpdateCategoryFilter();
        ApplyFilters();
    }

    private void FilterControls_Changed(object? sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void UpdateCategoryFilter()
    {
        var selectedCategory = Convert.ToString(categoryFilterComboBox.SelectedItem) ?? "Alle";
        var categories = GetExistingCategories()
            .Distinct(StringComparer.CurrentCultureIgnoreCase)
            .OrderBy(category => category, StringComparer.CurrentCultureIgnoreCase)
            .ToArray();

        categoryFilterComboBox.Items.Clear();
        categoryFilterComboBox.Items.Add("Alle");
        categoryFilterComboBox.Items.AddRange(categories.Cast<object>().ToArray());
        categoryFilterComboBox.SelectedItem = categories.FirstOrDefault(
            category => string.Equals(category, selectedCategory, StringComparison.CurrentCultureIgnoreCase))
            ?? "Alle";
    }

    private void ApplyFilters()
    {
        var nameSearch = nameSearchTextBox.Text.Trim();
        var serialSearch = serialSearchTextBox.Text.Trim();
        var categoryFilter = Convert.ToString(categoryFilterComboBox.SelectedItem);
        var statusFilter = Convert.ToString(statusFilterComboBox.SelectedItem);

        itemsGrid.CurrentCell = null;
        itemsGrid.ClearSelection();

        foreach (DataGridViewRow row in itemsGrid.Rows)
        {
            var name = Convert.ToString(row.Cells[NameColumn].Value) ?? string.Empty;
            var serialNumber = Convert.ToString(row.Cells[SerialNumberColumn].Value) ?? string.Empty;
            var category = Convert.ToString(row.Cells[CategoryColumn].Value) ?? string.Empty;
            var status = Convert.ToString(row.Cells[StatusColumn].Value) ?? string.Empty;

            row.Visible =
                name.Contains(nameSearch, StringComparison.CurrentCultureIgnoreCase) &&
                serialNumber.Contains(serialSearch, StringComparison.CurrentCultureIgnoreCase) &&
                (categoryFilter == "Alle" ||
                 string.Equals(category, categoryFilter, StringComparison.CurrentCultureIgnoreCase)) &&
                (statusFilter == "Alle" ||
                 string.Equals(status, statusFilter, StringComparison.CurrentCultureIgnoreCase));
        }
    }

    private static Equipment CreateEquipmentFromRow(DataGridViewRow row)
    {
        return new Equipment(
            Convert.ToString(row.Cells[NameColumn].Value) ?? string.Empty,
            Convert.ToString(row.Cells[CategoryColumn].Value) ?? string.Empty,
            Convert.ToString(row.Cells[SerialNumberColumn].Value) ?? string.Empty,
            Convert.ToString(row.Cells[StatusColumn].Value) ?? string.Empty,
            (row.Tag as Equipment)?.Note ?? string.Empty);
    }

    private static void SetRowValues(DataGridViewRow row, Equipment equipment)
    {
        row.Cells[NameColumn].Value = equipment.Name;
        row.Cells[CategoryColumn].Value = equipment.Category;
        row.Cells[SerialNumberColumn].Value = equipment.SerialNumber;
        row.Cells[StatusColumn].Value = equipment.Status;
        row.Tag = equipment;
    }

    private void AddEquipmentRow(Equipment equipment)
    {
        var rowIndex = itemsGrid.Rows.Add(equipment.Name, equipment.Category, equipment.SerialNumber, equipment.Status);
        itemsGrid.Rows[rowIndex].Tag = equipment;
    }
}
