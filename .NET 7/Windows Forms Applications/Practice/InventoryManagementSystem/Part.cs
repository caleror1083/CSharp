using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem;

public abstract class Part
{
    // Properties
    public int _PartID;
    public int _InStock;
    public int _Min;
    public int _Max;
    public string _Name;
    public decimal _Price;
    public string _Type;     // is part in-house or outsourced
    public string _TypeInfo; // contains machine ID or company name depending on type

    public int GetPartID()
    {
        return _PartID;
    }

    public int GetInStock()
    {
        return _InStock;
    }

    public int GetMin()
    {
        return _Min;
    }

    public int GetMax()
    {
        return _Max;
    }

    public string GetName()
    {
        return _Name;
    }

    public decimal GetPrice()
    {
        return _Price;
    }

    public string GetType()
    {
        return _Type;
    }

    public string GetTypeInfo()
    {
        return _TypeInfo;
    }

    public void SetPartID(int value)
    {
        _PartID = value;
    }

    public void SetInStock(int value)
    {
        _InStock = value;
    }

    public void SetMin(int value)
    {
        _Min = value;
    }

    public void SetMax(int value)
    {
        _Max = value;
    }

    public void SetName(string value)
    {
        _Name = value;
    }

    public void SetPrice(decimal value)
    {
        _Price = value;
    }

    public void SetType(string value)
    {
        _Type = value;
    }

    public void SetTypeInfo(string value)
    {
        _TypeInfo = value;
    }
}