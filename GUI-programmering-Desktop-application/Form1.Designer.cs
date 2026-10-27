namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        editButton = new System.Windows.Forms.Button();
        addButton = new System.Windows.Forms.Button();
        deleteButton = new System.Windows.Forms.Button();
        detailsButton = new System.Windows.Forms.Button();
        nameSearchTextBox = new System.Windows.Forms.TextBox();
        serialSearchTextBox = new System.Windows.Forms.TextBox();
        categoryFilterComboBox = new System.Windows.Forms.ComboBox();
        statusFilterComboBox = new System.Windows.Forms.ComboBox();
        nameSearchLabel = new System.Windows.Forms.Label();
        serialSearchLabel = new System.Windows.Forms.Label();
        categoryFilterLabel = new System.Windows.Forms.Label();
        statusFilterLabel = new System.Windows.Forms.Label();
        titleLabel = new System.Windows.Forms.Label();
        subtitleLabel = new System.Windows.Forms.Label();
        searchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        itemsGrid = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)itemsGrid).BeginInit();
        SuspendLayout();
        // 
        // editButton
        // 
        editButton.Location = new System.Drawing.Point(734, 30);
        editButton.Name = "editButton";
        editButton.Size = new System.Drawing.Size(118, 40);
        editButton.TabIndex = 0;
        editButton.Text = "Rediger valgt";
        editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        editButton.FlatAppearance.BorderSize = 0;
        editButton.BackColor = System.Drawing.Color.FromArgb(231, 237, 243);
        editButton.ForeColor = System.Drawing.Color.FromArgb(43, 55, 70);
        editButton.Cursor = System.Windows.Forms.Cursors.Hand;
        editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        editButton.UseVisualStyleBackColor = false;
        editButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        editButton.Click += EditSelectedItem_Click;
        //
        // detailsButton
        //
        detailsButton.Location = new System.Drawing.Point(860, 30);
        detailsButton.Name = "detailsButton";
        detailsButton.Size = new System.Drawing.Size(108, 40);
        detailsButton.TabIndex = 1;
        detailsButton.Text = "Detaljer";
        detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        detailsButton.FlatAppearance.BorderSize = 0;
        detailsButton.BackColor = System.Drawing.Color.FromArgb(231, 237, 243);
        detailsButton.ForeColor = System.Drawing.Color.FromArgb(43, 55, 70);
        detailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
        detailsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        detailsButton.UseVisualStyleBackColor = false;
        detailsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        detailsButton.Click += ShowSelectedItemDetails_Click;
        // 
        // addButton
        // 
        addButton.Location = new System.Drawing.Point(620, 30);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(106, 40);
        addButton.TabIndex = 3;
        addButton.Text = "Tilføj vare";
        addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        addButton.FlatAppearance.BorderSize = 0;
        addButton.BackColor = System.Drawing.Color.FromArgb(31, 132, 112);
        addButton.ForeColor = System.Drawing.Color.White;
        addButton.Cursor = System.Windows.Forms.Cursors.Hand;
        addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        addButton.UseVisualStyleBackColor = false;
        addButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        addButton.Click += AddNewItem_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new System.Drawing.Point(976, 30);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(120, 40);
        deleteButton.TabIndex = 4;
        deleteButton.Text = "Slet valgt";
        deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        deleteButton.FlatAppearance.BorderSize = 0;
        deleteButton.BackColor = System.Drawing.Color.FromArgb(255, 239, 237);
        deleteButton.ForeColor = System.Drawing.Color.FromArgb(173, 57, 48);
        deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
        deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        deleteButton.UseVisualStyleBackColor = false;
        deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        deleteButton.Click += DeleteSelectedItem_Click;
        // 
        // nameSearchTextBox
        // 
        nameSearchTextBox.Name = "nameSearchTextBox";
        nameSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        nameSearchTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        nameSearchTextBox.PlaceholderText = "Søg efter navn...";
        nameSearchTextBox.TabIndex = 6;
        // 
        // serialSearchTextBox
        // 
        serialSearchTextBox.Name = "serialSearchTextBox";
        serialSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        serialSearchTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        serialSearchTextBox.PlaceholderText = "Søg efter serienummer...";
        serialSearchTextBox.TabIndex = 8;
        // 
        // categoryFilterComboBox
        // 
        categoryFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        categoryFilterComboBox.Name = "categoryFilterComboBox";
        categoryFilterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        categoryFilterComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        categoryFilterComboBox.TabIndex = 10;
        // 
        // statusFilterComboBox
        // 
        statusFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        statusFilterComboBox.Name = "statusFilterComboBox";
        statusFilterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        statusFilterComboBox.Margin = new System.Windows.Forms.Padding(0);
        statusFilterComboBox.TabIndex = 12;
        // 
        // nameSearchLabel
        // 
        nameSearchLabel.AutoSize = true;
        nameSearchLabel.Name = "nameSearchLabel";
        nameSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        nameSearchLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        nameSearchLabel.TabIndex = 5;
        nameSearchLabel.Text = "Navn";
        // 
        // serialSearchLabel
        // 
        serialSearchLabel.AutoSize = true;
        serialSearchLabel.Name = "serialSearchLabel";
        serialSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        serialSearchLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        serialSearchLabel.TabIndex = 7;
        serialSearchLabel.Text = "Serienummer";
        // 
        // categoryFilterLabel
        // 
        categoryFilterLabel.AutoSize = true;
        categoryFilterLabel.Name = "categoryFilterLabel";
        categoryFilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        categoryFilterLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
        categoryFilterLabel.TabIndex = 9;
        categoryFilterLabel.Text = "Kategori";
        // 
        // statusFilterLabel
        // 
        statusFilterLabel.AutoSize = true;
        statusFilterLabel.Name = "statusFilterLabel";
        statusFilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        statusFilterLabel.Margin = new System.Windows.Forms.Padding(0);
        statusFilterLabel.TabIndex = 11;
        statusFilterLabel.Text = "Status";
        // 
        // titleLabel
        //
        titleLabel.AutoSize = true;
        titleLabel.Location = new System.Drawing.Point(24, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new System.Drawing.Size(150, 32);
        titleLabel.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
        titleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 44, 59);
        titleLabel.TabIndex = 14;
        titleLabel.Text = "Varelager";
        //
        // subtitleLabel
        //
        subtitleLabel.AutoSize = true;
        subtitleLabel.Location = new System.Drawing.Point(27, 64);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new System.Drawing.Size(390, 20);
        subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(102, 116, 132);
        subtitleLabel.TabIndex = 15;
        subtitleLabel.Text = "Få overblik over udstyr, og find hurtigt det, du leder efter.";
        //
        // searchLayoutPanel
        //
        searchLayoutPanel.ColumnCount = 4;
        searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        searchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        searchLayoutPanel.RowCount = 2;
        searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
        searchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        searchLayoutPanel.Location = new System.Drawing.Point(24, 100);
        searchLayoutPanel.Name = "searchLayoutPanel";
        searchLayoutPanel.Size = new System.Drawing.Size(1072, 60);
        searchLayoutPanel.TabIndex = 16;
        searchLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                                   System.Windows.Forms.AnchorStyles.Right;
        searchLayoutPanel.Controls.Add(nameSearchLabel, 0, 0);
        searchLayoutPanel.Controls.Add(nameSearchTextBox, 0, 1);
        searchLayoutPanel.Controls.Add(serialSearchLabel, 1, 0);
        searchLayoutPanel.Controls.Add(serialSearchTextBox, 1, 1);
        searchLayoutPanel.Controls.Add(categoryFilterLabel, 2, 0);
        searchLayoutPanel.Controls.Add(categoryFilterComboBox, 2, 1);
        searchLayoutPanel.Controls.Add(statusFilterLabel, 3, 0);
        searchLayoutPanel.Controls.Add(statusFilterComboBox, 3, 1);
        //
        // itemsGrid
        // 
        itemsGrid.BackgroundColor = System.Drawing.Color.White;
        itemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
        itemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        itemsGrid.ColumnHeadersHeight = 42;
        itemsGrid.EnableHeadersVisualStyles = false;
        itemsGrid.GridColor = System.Drawing.Color.FromArgb(232, 237, 243);
        itemsGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 240, 246);
        itemsGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(43, 55, 70);
        itemsGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
        itemsGrid.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        itemsGrid.DefaultCellStyle.BackColor = System.Drawing.Color.White;
        itemsGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(43, 55, 70);
        itemsGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 239, 235);
        itemsGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 65, 60);
        itemsGrid.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        itemsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        itemsGrid.RowTemplate.Height = 38;
        itemsGrid.Location = new System.Drawing.Point(24, 180);
        itemsGrid.Name = "itemsGrid";
        itemsGrid.RowHeadersWidth = 51;
        itemsGrid.Size = new System.Drawing.Size(1072, 480);
        itemsGrid.TabIndex = 13;
        itemsGrid.Text = "itemsGrid";
        itemsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom |
                           System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1120, 690);
        MinimumSize = new System.Drawing.Size(1000, 560);
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Font = new System.Drawing.Font("Segoe UI", 10F);
        Controls.Add(itemsGrid);
        Controls.Add(subtitleLabel);
        Controls.Add(titleLabel);
        Controls.Add(searchLayoutPanel);
        Controls.Add(deleteButton);
        Controls.Add(detailsButton);
        Controls.Add(addButton);
        Controls.Add(editButton);
        Text = "Varelager";
        ((System.ComponentModel.ISupportInitialize)itemsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView itemsGrid;
    private System.Windows.Forms.TableLayoutPanel searchLayoutPanel;

    private System.Windows.Forms.TextBox nameSearchTextBox;
    private System.Windows.Forms.TextBox serialSearchTextBox;
    private System.Windows.Forms.ComboBox categoryFilterComboBox;
    private System.Windows.Forms.ComboBox statusFilterComboBox;
    private System.Windows.Forms.Label nameSearchLabel;
    private System.Windows.Forms.Label serialSearchLabel;
    private System.Windows.Forms.Label categoryFilterLabel;
    private System.Windows.Forms.Label statusFilterLabel;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label subtitleLabel;

    private System.Windows.Forms.Button deleteButton;

    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button editButton;
    private System.Windows.Forms.Button detailsButton;

    #endregion
}