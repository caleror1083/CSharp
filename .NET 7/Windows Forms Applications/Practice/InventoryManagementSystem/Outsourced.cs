namespace InventoryManagementSystem;

internal class Outsourced : Part
{
    private string _CompanyName;

    public Outsourced()
    {
        SetType("Outsourced");
    }

    public string GetCompanyName()
    {
        return _CompanyName;
    }

    public void SetCompanyName(string value)
    {
        _CompanyName = value;
        SetTypeInfo(value.ToString());
    }
}