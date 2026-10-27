using System.ComponentModel;

namespace WinFormsApp1;

partial class itemDetaljer
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
        titleLabel = new System.Windows.Forms.Label();
        categoryLabel = new System.Windows.Forms.Label();
        categoryValueLabel = new System.Windows.Forms.Label();
        serialNumberLabel = new System.Windows.Forms.Label();
        serialNumberValueLabel = new System.Windows.Forms.Label();
        statusLabel = new System.Windows.Forms.Label();
        statusValueLabel = new System.Windows.Forms.Label();
        noteLabel = new System.Windows.Forms.Label();
        noteTextBox = new System.Windows.Forms.TextBox();
        saveButton = new System.Windows.Forms.Button();
        cancelButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Location = new System.Drawing.Point(21, 16);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new System.Drawing.Size(740, 39);
        titleLabel.TabIndex = 0;
        titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        titleLabel.Text = "Varedetaljer";
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Location = new System.Drawing.Point(24, 78);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new System.Drawing.Size(69, 23);
        categoryLabel.TabIndex = 1;
        categoryLabel.Text = "Kategori";
        // 
        // categoryValueLabel
        // 
        categoryValueLabel.AutoSize = true;
        categoryValueLabel.Location = new System.Drawing.Point(150, 78);
        categoryValueLabel.Name = "categoryValueLabel";
        categoryValueLabel.Size = new System.Drawing.Size(0, 23);
        categoryValueLabel.TabIndex = 2;
        // 
        // serialNumberLabel
        // 
        serialNumberLabel.AutoSize = true;
        serialNumberLabel.Location = new System.Drawing.Point(24, 114);
        serialNumberLabel.Name = "serialNumberLabel";
        serialNumberLabel.Size = new System.Drawing.Size(95, 23);
        serialNumberLabel.TabIndex = 3;
        serialNumberLabel.Text = "Serienummer";
        // 
        // serialNumberValueLabel
        // 
        serialNumberValueLabel.AutoSize = true;
        serialNumberValueLabel.Location = new System.Drawing.Point(150, 114);
        serialNumberValueLabel.Name = "serialNumberValueLabel";
        serialNumberValueLabel.Size = new System.Drawing.Size(0, 23);
        serialNumberValueLabel.TabIndex = 4;
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Location = new System.Drawing.Point(24, 150);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new System.Drawing.Size(49, 23);
        statusLabel.TabIndex = 5;
        statusLabel.Text = "Status";
        // 
        // statusValueLabel
        // 
        statusValueLabel.AutoSize = true;
        statusValueLabel.Location = new System.Drawing.Point(150, 150);
        statusValueLabel.Name = "statusValueLabel";
        statusValueLabel.Size = new System.Drawing.Size(0, 23);
        statusValueLabel.TabIndex = 6;
        // 
        // noteLabel
        // 
        noteLabel.AutoSize = true;
        noteLabel.Location = new System.Drawing.Point(24, 194);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new System.Drawing.Size(45, 23);
        noteLabel.TabIndex = 7;
        noteLabel.Text = "Note";
        // 
        // noteTextBox
        // 
        noteTextBox.Location = new System.Drawing.Point(24, 222);
        noteTextBox.Multiline = true;
        noteTextBox.Name = "noteTextBox";
        noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        noteTextBox.Size = new System.Drawing.Size(754, 154);
        noteTextBox.TabIndex = 8;
        // 
        // saveButton
        // 
        saveButton.Location = new System.Drawing.Point(542, 397);
        saveButton.Name = "saveButton";
        saveButton.Size = new System.Drawing.Size(112, 40);
        saveButton.TabIndex = 9;
        saveButton.Text = "Gem note";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += SaveButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new System.Drawing.Point(666, 397);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(112, 40);
        cancelButton.TabIndex = 10;
        cancelButton.Text = "Annuller";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += CancelButton_Click;
        // 
        // itemDetaljer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(802, 458);
        MinimumSize = new System.Drawing.Size(700, 420);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Font = new System.Drawing.Font("Segoe UI", 10F);
        Controls.Add(cancelButton);
        Controls.Add(saveButton);
        Controls.Add(noteTextBox);
        Controls.Add(noteLabel);
        Controls.Add(statusValueLabel);
        Controls.Add(statusLabel);
        Controls.Add(serialNumberValueLabel);
        Controls.Add(serialNumberLabel);
        Controls.Add(categoryValueLabel);
        Controls.Add(categoryLabel);
        Controls.Add(titleLabel);
        Text = "Varedetaljer";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.Label categoryValueLabel;
    private System.Windows.Forms.Label serialNumberLabel;
    private System.Windows.Forms.Label serialNumberValueLabel;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.Label statusValueLabel;
    private System.Windows.Forms.Label noteLabel;
    private System.Windows.Forms.TextBox noteTextBox;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;

    #endregion
}