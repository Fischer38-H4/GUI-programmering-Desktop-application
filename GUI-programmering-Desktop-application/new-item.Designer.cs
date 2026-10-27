using System.ComponentModel;

namespace WinFormsApp1;

partial class NewItem
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        nameTextBox = new System.Windows.Forms.TextBox();
        categoryComboBox = new System.Windows.Forms.ComboBox();
        serialNumberTextBox = new System.Windows.Forms.TextBox();
        statusComboBox = new System.Windows.Forms.ComboBox();
        nameLabel = new System.Windows.Forms.Label();
        categoryLabel = new System.Windows.Forms.Label();
        serialNumberLabel = new System.Windows.Forms.Label();
        statusLabel = new System.Windows.Forms.Label();
        titleLabel = new System.Windows.Forms.Label();
        subtitleLabel = new System.Windows.Forms.Label();
        saveButton = new System.Windows.Forms.Button();
        cancelButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new System.Drawing.Point(24, 108);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new System.Drawing.Size(392, 27);
        nameTextBox.BackColor = System.Drawing.Color.White;
        nameTextBox.PlaceholderText = "Indtast varens navn";
        nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                             System.Windows.Forms.AnchorStyles.Right;
        nameTextBox.TabIndex = 0;
        // 
        // categoryComboBox
        // 
        categoryComboBox.Location = new System.Drawing.Point(24, 160);
        categoryComboBox.Name = "categoryComboBox";
        categoryComboBox.Size = new System.Drawing.Size(392, 28);
        categoryComboBox.BackColor = System.Drawing.Color.White;
        categoryComboBox.TabIndex = 1;
        categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                                  System.Windows.Forms.AnchorStyles.Right;
        // 
        // serialNumberTextBox
        // 
        serialNumberTextBox.Location = new System.Drawing.Point(24, 212);
        serialNumberTextBox.Name = "serialNumberTextBox";
        serialNumberTextBox.Size = new System.Drawing.Size(392, 27);
        serialNumberTextBox.BackColor = System.Drawing.Color.White;
        serialNumberTextBox.PlaceholderText = "Indtast serienummer";
        serialNumberTextBox.TabIndex = 2;
        serialNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                                     System.Windows.Forms.AnchorStyles.Right;
        // 
        // statusComboBox
        // 
        statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        statusComboBox.Location = new System.Drawing.Point(24, 264);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new System.Drawing.Size(392, 28);
        statusComboBox.BackColor = System.Drawing.Color.White;
        statusComboBox.TabIndex = 3;
        statusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                                System.Windows.Forms.AnchorStyles.Right;
        // 
        // nameLabel
        // 
        nameLabel.Location = new System.Drawing.Point(24, 84);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new System.Drawing.Size(162, 20);
        nameLabel.ForeColor = System.Drawing.Color.FromArgb(55, 68, 83);
        nameLabel.TabIndex = 4;
        nameLabel.Text = "Navn";
        // 
        // categoryLabel
        // 
        categoryLabel.Location = new System.Drawing.Point(24, 136);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new System.Drawing.Size(162, 20);
        categoryLabel.ForeColor = System.Drawing.Color.FromArgb(55, 68, 83);
        categoryLabel.TabIndex = 5;
        categoryLabel.Text = "Kategori";
        // 
        // serialNumberLabel
        // 
        serialNumberLabel.Location = new System.Drawing.Point(24, 188);
        serialNumberLabel.Name = "serialNumberLabel";
        serialNumberLabel.Size = new System.Drawing.Size(162, 20);
        serialNumberLabel.ForeColor = System.Drawing.Color.FromArgb(55, 68, 83);
        serialNumberLabel.TabIndex = 6;
        serialNumberLabel.Text = "Serienummer";
        // 
        // statusLabel
        // 
        statusLabel.Location = new System.Drawing.Point(24, 240);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new System.Drawing.Size(162, 20);
        statusLabel.ForeColor = System.Drawing.Color.FromArgb(55, 68, 83);
        statusLabel.TabIndex = 7;
        statusLabel.Text = "Status";
        // 
        // saveButton
        // 
        // titleLabel
        //
        titleLabel.AutoSize = true;
        titleLabel.Location = new System.Drawing.Point(24, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new System.Drawing.Size(230, 32);
        titleLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
        titleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 44, 59);
        titleLabel.TabIndex = 10;
        titleLabel.Text = "Tilføj ny vare";
        //
        // subtitleLabel
        //
        subtitleLabel.AutoSize = true;
        subtitleLabel.Location = new System.Drawing.Point(27, 57);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new System.Drawing.Size(392, 20);
        subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(102, 116, 132);
        subtitleLabel.TabIndex = 11;
        subtitleLabel.Text = "Udfyld felterne for at tilføje varen.";
        //
        // saveButton
        //
        saveButton.Location = new System.Drawing.Point(24, 350);
        saveButton.Name = "saveButton";
        saveButton.Size = new System.Drawing.Size(392, 44);
        saveButton.TabIndex = 8;
        saveButton.Text = "Gem vare";
        saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        saveButton.FlatAppearance.BorderSize = 0;
        saveButton.BackColor = System.Drawing.Color.FromArgb(31, 132, 112);
        saveButton.ForeColor = System.Drawing.Color.White;
        saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
        saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left |
                            System.Windows.Forms.AnchorStyles.Right;
        saveButton.Click += SaveButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new System.Drawing.Point(24, 402);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(392, 44);
        cancelButton.TabIndex = 9;
        cancelButton.Text = "Annuller";
        cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        cancelButton.FlatAppearance.BorderSize = 0;
        cancelButton.BackColor = System.Drawing.Color.FromArgb(231, 237, 243);
        cancelButton.ForeColor = System.Drawing.Color.FromArgb(43, 55, 70);
        cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
        cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left |
                              System.Windows.Forms.AnchorStyles.Right;
        cancelButton.Click += CancelButton_Click;
        // 
        // NewItem
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(440, 480);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Font = new System.Drawing.Font("Segoe UI", 10F);
        AcceptButton = saveButton;
        CancelButton = cancelButton;
        Controls.Add(subtitleLabel);
        Controls.Add(titleLabel);
        Controls.Add(cancelButton);
        Controls.Add(saveButton);
        Controls.Add(statusLabel);
        Controls.Add(serialNumberLabel);
        Controls.Add(categoryLabel);
        Controls.Add(nameLabel);
        Controls.Add(statusComboBox);
        Controls.Add(serialNumberTextBox);
        Controls.Add(categoryComboBox);
        Controls.Add(nameTextBox);
        Text = "Tilføj vare";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.Label serialNumberLabel;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label subtitleLabel;
    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.TextBox serialNumberTextBox;
    private System.Windows.Forms.ComboBox categoryComboBox;
    private System.Windows.Forms.ComboBox statusComboBox;

    private System.Windows.Forms.TextBox nameTextBox;

    #endregion
}