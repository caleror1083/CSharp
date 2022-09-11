/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InventoryManagementSystem
	{
		class Inventory
			{
				// Inventory is products and parts array lists
				public static List<Product> _Products = new List<Product>();
				public static List<Part> _AllParts = new List<Part>();

				// Parts count
				public static int _PartCount = 0;
				public static int _ProductCount = 0;
				private static readonly DataTable _AllPartsDT = new DataTable();
				private static readonly DataTable _ProductsDT = new DataTable();

				public static DataTable GetAllPartsDT()
					{
						// If column does not exist, add column
						if (!_AllPartsDT.Columns.Contains("Part ID"))
							{
								_AllPartsDT.Columns.Add("Part ID", typeof(int));
							}
						if (!_AllPartsDT.Columns.Contains("Name"))
							{
								_AllPartsDT.Columns.Add("Name", typeof(string));
							}
						if (!_AllPartsDT.Columns.Contains("Price"))
							{
								_AllPartsDT.Columns.Add("Price", typeof(decimal));
							}
						if (!_AllPartsDT.Columns.Contains("In Stock"))
							{
								_AllPartsDT.Columns.Add("In Stock", typeof(int));
							}
						return _AllPartsDT;
					}

				public static DataTable GetProductsDT()
					{
						// If column does not exist, add column
						if (!_ProductsDT.Columns.Contains("Part ID"))
							{
								_ProductsDT.Columns.Add("Part ID", typeof(int));
							}
						if (!_ProductsDT.Columns.Contains("Name"))
							{
								_ProductsDT.Columns.Add("Name", typeof(string));
							}
						if (!_ProductsDT.Columns.Contains("Price"))
							{
								_ProductsDT.Columns.Add("Price", typeof(decimal));
							}
						if (!_ProductsDT.Columns.Contains("In Stock"))
							{
								_ProductsDT.Columns.Add("In Stock", typeof(int));
							}
						return _ProductsDT;
					}

				// Adds products
				public static void AddProduct(Product product)
					{
						product.SetProductID(_ProductCount);
						_Products.Add(product);
						_ProductsDT.Rows.Add(product.GetProductID(), product.GetName(), product.GetPrice(), product.GetInStock());
						_ProductCount++;
					}

				// Removes product
				public static bool RemoveProduct(int searchProductID)
					{
						for (int x = 0; x < _Products.Count(); x++)
							{
								if (_Products[x].GetProductID() == searchProductID)
									{
										_ProductsDT.Rows[_Products[x].GetProductID()].Delete();
										_Products.Remove(_Products[x]);
										return true;
									}
							}
						return false;
					}

				// Returns product being searched based on ProductID
				public static Product LookupProduct(int productID)
					{
						for (int x = 0; x < _Products.Count(); x++)
							{
								if (_Products[x].GetProductID() == productID)
									{
										return _Products[x];
									}
							}
						return null;		// If product not found
					}

				// Update product
				public static void UpdateProduct(int index, Product product)
					{
						_ProductsDT.Rows[index][0] = product.GetProductID();
						_ProductsDT.Rows[index][1] = product.GetName();
						_ProductsDT.Rows[index][2] = product.GetPrice();
						_ProductsDT.Rows[index][3] = product.GetInStock();
						_Products[index] = product;
					}

				// Add parts
				public static void AddPart(Part part)
					{
						part.SetPartID(_PartCount);
						_AllParts.Add(part);
						_AllPartsDT.Rows.Add(part.GetPartID(), part.GetName(), part.GetPrice(), part.GetInStock());
						_PartCount++;
					}

				// Delete parts
				public static bool DeletePart(Part part)
					{
						if (_AllParts.Contains(part) == false)
							{
								return false;
							}
						else
							{
								for (int x = 0; x < _AllPartsDT.Rows.Count; x++)
									{
										if (_AllPartsDT.Rows[x][0].ToString() == part.GetPartID().ToString())
											{
												_AllPartsDT.Rows[x].Delete();
											}
									}
								_AllParts.Remove(part);
								return true;
							}
					}

				// Returns part
				public static Part LookupPart(int searchPartID)
					{
						for (int x = 0; x < _AllParts.Count(); x++)
							{
								if (_AllParts[x].GetPartID() == searchPartID)
									{
										return _AllParts[x];
									}
							}
						return null;		// If part not found
					}

				// Update Parts
				public static void UpdatePart(int index, Part part)
					{
						_AllPartsDT.Rows[index][0] = part.GetPartID();
						_AllPartsDT.Rows[index][1] = part.GetName();
						_AllPartsDT.Rows[index][2] = part.GetPrice();
						_AllPartsDT.Rows[index][3] = part.GetInStock();
						_AllParts[index] = part;
					}
			}
	}