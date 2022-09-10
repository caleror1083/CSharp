/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace InventoryManagementSystem
	{
	    public abstract class Part
		    {
			    // Properties
				private int partID, inStock, min, max;
				private string name;
				private decimal price;

				private string type;		// Is part In-House or Outsourced
				private string typeInfo;	// Contains Machine ID or Company Name depending on type

				// Accessors and Modifiers
				public string getType()
					{
						return type;
					}
				public void setType(string value)
					{
						type = value;
					}

				public string getTypeInfo()
					{
						return typeInfo;
					}
				public void setTypeInfo(string value)
					{
						typeInfo = value;
					}

				public int GetPartID()
					{
						return partID;
					}
				public void SetPartID(int value)
					{
						partID = value;
					}

				public string GetName()
					{
						return name;
					}
				public void setName(string value)
					{
						name = value;
					}

				public decimal GetPrice()
					{
						return price;
					}
				public void setPrice(decimal value)
					{
						price = value;
					}

				public int GetInStock()
					{
						return inStock;
					}
				public void setInStock(int value)
					{
						inStock = value;
					}

				public int getMin()
					{
						return min;
					}
				public void setMin(int value)
					{
						min = value;
					}

				public int getMax()
					{
						return max;
					}
				public void setMax(int value)
					{
						max = value;
					}
			}
	}