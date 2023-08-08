using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem;

internal class Inventory
{
    public static List<Part> _Parts = new();
    public static int _PartCount = 0;
    private static readonly DataTable _PartsDataTable = new();

    public static DataTable GetPartsDataTable()
    {
        // If column does not exist, add column
        if (!_PartsDataTable.Columns.Contains("PartID"))
        {
            _PartsDataTable.Columns.Add("Part ID", typeof(int));
        }
        if (!_PartsDataTable.Columns.Contains("Name"))
        {
            _PartsDataTable.Columns.Add("Name", typeof(string));
        }
        if (!_PartsDataTable.Columns.Contains("Price"))
        {
            _PartsDataTable.Columns.Add("Price", typeof(decimal));
        }
        if (!_PartsDataTable.Columns.Contains("In Stock"))
        {
            _PartsDataTable.Columns.Add("In Stock", typeof(int));
        }
        return _PartsDataTable;
    }

    // Lookup part
    public static Part LookupPart(int partID)
    {
        foreach (Part part in _Parts)
        {
            if (part.GetPartID() == partID)
            {
                return part;
            }
        }
        return null;
    }   

    // Add part to list
    public static void AddPart(Part part)
    {
        part.SetPartID(_PartCount);
        _Parts.Add(part);
        _PartsDataTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetPrice(), part.GetInStock());
        _PartCount++;
    }

    // Delete part from list
    public static bool DeletePart(Part part)
    {
        if (_Parts.Contains(part) == false)
        {
            return false;
        }
        else
        {
            for (int x = 0; x < _PartsDataTable.Rows.Count; x++)
            {
                if (_PartsDataTable.Rows[x][0].ToString() == part.GetPartID().ToString())
                {
                    _PartsDataTable.Rows[x].Delete();
                }
            }
            _Parts.Remove(part);
            return true;
        }
    }

    // Update part in list
    public static void UpdatePart(int index, Part part)
    {
        _Parts[index] = part;
        _PartsDataTable.Rows[index][0] = part.GetPartID();
        _PartsDataTable.Rows[index][1] = part.GetName();
        _PartsDataTable.Rows[index][2] = part.GetPrice();
        _PartsDataTable.Rows[index][3] = part.GetInStock();
    }
}