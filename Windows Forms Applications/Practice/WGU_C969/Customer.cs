/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
    {
	    class Customer
	        {
                public string Name
                    {
                        get;
                        set;
                    }

                public string Address
                    {
                        get;
                        set;
                    }

                public string Address2
                    {
                        get;
                        set;
                    }

                public string City
                    {
                        get;
                        set;
                    }

                public string Country
                    {
                        get;
                        set;
                    }

                public string PostalCode
                    {
                        get;
                        set;
                    }

                public string Phone
                    {
                        get;
                        set;
                    }

                public int CountryId
                    {
                        get;
                        set;
                    }

                public int CityId
                    {
                        get;
                        set;
                    }

                public int AddressId
                    {
                        get;
                        set;
                    }

                public int CustomerId
                    {
                        get;
                        set;
                    }

                public string loggedInUser = LoginControl.GetUserName();
	        }
    }