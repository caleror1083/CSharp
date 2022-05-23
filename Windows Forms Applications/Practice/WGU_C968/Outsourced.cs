/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace InventoryManagementSystem
	{
		class Outsourced : Part
			{
			    // Property
                private string companyName;
                
                public Outsourced()
                    {
                        this.setType("outsourced");
                    }

				// Accessors and Modifiers
                public string setCompanyName()
                    {
                        return companyName;
                    }

                public void setCompanyName(string value)
                    {
                        companyName = value;
                        this.setTypeInfo(value.ToString());
                    }
			}
	}