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
				public static List<Product> products = new List<Product>();
				public static List<Part>  allParts = new List<Part>();

				// Parts count
				public static int partCount = 0;
				public static int productCount = 0;
				private static DataTable allPartsDT = new DataTable();
				private static DataTable productsDT = new DataTable();

				public static DataTable getAllPartsDT()
					{
						// If column does not exist, add column
						if (!allPartsDT.Columns.Contains("Part ID"))
							{
								allPartsDT.Columns.Add("Part ID", typeof(int));
							}
						if (!allPartsDT.Columns.Contains("Name"))
							{
								allPartsDT.Columns.Add("Name", typeof(string));
							}
						if (!allPartsDT.Columns.Contains("Price"))
							{
								allPartsDT.Columns.Add("Price", typeof(decimal));
							}
						if (!allPartsDT.Columns.Contains("In Stock"))
							{
								allPartsDT.Columns.Add("In Stock", typeof(int));
							}
						return allPartsDT;
					}

				public static DataTable getProductsDT()
					{
						// If column does not exist, add column
						if (!productsDT.Columns.Contains("Part ID"))
							{
								productsDT.Columns.Add("Part ID", typeof(int));
							}
						if (!productsDT.Columns.Contains("Name"))
							{
								productsDT.Columns.Add("Name", typeof(string));
							}
						if (!productsDT.Columns.Contains("Price"))
							{
								productsDT.Columns.Add("Price", typeof(decimal));
							}
						if (!productsDT.Columns.Contains("In Stock"))
							{
								productsDT.Columns.Add("In Stock", typeof(int));
							}
						return productsDT;
					}

				// Adds products
				public static void addProduct(Product product)
					{
						product.setProductID(productCount);
						products.Add(product);
						productsDT.Rows.Add(product.getProductID(), product.getName(), product.getPrice(), product.getInStock());
						productCount++;
					}

				// Removes product
				public static bool removeProduct(int searchProductID)
					{
						for (int x = 0; x < products.Count(); x++)
							{
								if (products[x].getProductID() == searchProductID)
									{
										productsDT.Rows[products[x].getProductID()].Delete();
										products.Remove(products[x]);
										return true;
									}
							}
						return false;
					}

				// Returns product being searched based on ProductID
				public static Product lookupProduct(int productID)
					{
						for (int x = 0; x < products.Count(); x++)
							{
								if (products[x].getProductID() == productID)
									{
										return products[x];
									}
							}
						return null;		// If product not found
					}

				// Update product
				public static void updateProduct(int index, Product product)
					{
						productsDT.Rows[index][0] = product.getProductID();
						productsDT.Rows[index][1] = product.getName();
						productsDT.Rows[index][2] = product.getPrice();
						productsDT.Rows[index][3] = product.getInStock();
						products[index] = product;
					}

				// Add parts
				public static void addPart(Part part)
					{
						part.setPartID(partCount);
						allParts.Add(part);
						allPartsDT.Rows.Add(part.getPartID(), part.getName(), part.getPrice(), part.getInStock());
						partCount++;
					}

				// Delete parts
				public static bool deletePart(Part part)
					{
						if (allParts.Contains(part) == false)
							{
								return false;
							}
						else
							{
								for (int x = 0; x < allPartsDT.Rows.Count; x++)
									{
										if (allPartsDT.Rows[x][0].ToString() == part.getPartID().ToString())
											{
												allPartsDT.Rows[x].Delete();
											}
									}
								allParts.Remove(part);
								return true;
							}
					}

				// Returns part
				public static Part lookupPart(int searchPartID)
					{
						for (int x = 0; x < allParts.Count(); x++)
							{
								if (allParts[x].getPartID() == searchPartID)
									{
										return allParts[x];
									}
							}
						return null;		// If part not found
					}

				// Update Parts
				public static void updatePart(int index, Part part)
					{
						allPartsDT.Rows[index][0] = part.getPartID();
						allPartsDT.Rows[index][1] = part.getName();
						allPartsDT.Rows[index][2] = part.getPrice();
						allPartsDT.Rows[index][3] = part.getInStock();
						allParts[index] = part;
					}
			}
	}