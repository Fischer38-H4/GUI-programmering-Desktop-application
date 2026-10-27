namespace WinFormsApp1;

public sealed class Equipment
{
    public Equipment(string name, string category, string serialNumber, string status, string note = "")
    {
        Name = name;
        Category = category;
        SerialNumber = serialNumber;
        Status = status;
        Note = note;
    }

    public string Name { get; }
    public string Category { get; }
    public string SerialNumber { get; }
    public string Status { get; }
    public string Note { get; }
}
