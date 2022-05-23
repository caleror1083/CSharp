/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InventoryManagementSystem
	{
		public class Product
		    {
				// Fields
				private List<Part> associatedParts = new List<Part>();
				private int productID, inStock, min, max;
				private string name;
				private decimal price;
				private DataTable associatedPartsDT = new DataTable();

				// Accessors and Modifiers
				public bool associatedPartsEmpty()
					{
						if (!associatedParts.Any())
							{
								return true;
							}
						else
							{
								return false;	
							}
					}

				public DataTable getAssociatedPartsDT()
					{
						// If column does not exist, add column
						if (!associatedPartsDT.Columns.Contains("Part ID"))
							{
								associatedPartsDT.Columns.Add("Part ID", typeof(int));
							}
						if (!associatedPartsDT.Columns.Contains("Name"))
							{
								associatedPartsDT.Columns.Add("Name", typeof(string));
							}
						if (!associatedPartsDT.Columns.Contains("Price"))
							{
								associatedPartsDT.Columns.Add("Price", typeof(decimal));
							}
						if (!associatedPartsDT.Columns.Contains("In Stock"))
							{
								associatedPartsDT.Columns.Add("In Stock", typeof(int));
							}
						return associatedPartsDT;
					}

				public int GetProductID()
					{
						return productID;
					}
				public void setProductID(int value)
					{
						productID = value;
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

				public void addAssociatedPart(Part part)
					{
						associatedPartsDT.Rows.Add(part.GetPartID(), part.getName(), part.getPrice(), part.getInStock());
						associatedParts.Add(part);
					}

				// Remove part based on PartID
				public bool removeAssociatedPart(int searchPartID)
					{
						for (int x = 0; x < associatedPartsDT.Rows.Count; x++)
							{
								if (associatedPartsDT.Rows[x][0].ToString() == searchPartID.ToString())
									{
										associatedPartsDT.Rows[x].Delete();
									}
							}
						for (int x = 0; x < associatedParts.Count(); x++)
							{
								if (associatedParts[x].GetPartID() == searchPartID)
									{
										associatedParts.Remove(associatedParts[x]);
									}
							}
						return false;
					}

				// Searches Parts list based on PartID
				public Part lookupAssociatedPart(int searchPartID)
					{
						for (int x = 0; x < associatedParts.Count(); x++)
							{
								if (associatedParts[x].GetPartID() == searchPartID)
									{
										return associatedParts[x];
									}
							}
						return null;	// If part not found
					}
			}
	}