namespace InventoryManagementSystem;

internal class InHouse : Part
{
    private int _MachineID;

    public InHouse()
    {
        SetType("In-House");
    }

    public int GetMachineID()
    {
        return _MachineID;
    }

    public void SetMachineID(int value)
    {
        _MachineID = value;
        SetTypeInfo(value.ToString());
    }
}