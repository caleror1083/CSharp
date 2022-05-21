/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace WGU_C968
	{
		class Inhouse : Part
			{
			    // Property
                private int machineID;
                
                public Inhouse()
                    {
                        this.setType("inhouse");
                    }

				// Accessors and Modifiers
                public int setMachineID()
                    {
                        return machineID;
                    }

                public void setMachineID(int value)
                    {
                        machineID = value;
                        this.setTypeInfo(value.ToString());
                    }
			}
	}