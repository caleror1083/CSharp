/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace WGU_C968
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

				public int getPartID()
					{
						return partID;
					}
				public void setPartID(int value)
					{
						partID = value;
					}

				public string getName()
					{
						return name;
					}
				public void setName(string value)
					{
						name = value;
					}

				public decimal getPrice()
					{
						return price;
					}
				public void setPrice(decimal value)
					{
						price = value;
					}

				public int getInStock()
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