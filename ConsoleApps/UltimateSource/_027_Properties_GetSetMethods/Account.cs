class Account                                   // A simple Account class that contains a private instance variable name and public methods to Set and Get name's value.
    {
        private string name;                     // instance variable
        private string name2;                    // instance variable

        public void SetName(string accountName)  // method that sets the account name in the object
            {
                name = accountName;               // store the account name
            }

        public string GetName()                  // method that retrieves the account name from the object
            {
                return name;                      // returns name's value to this method's caller
            }

                      
        public string Name2                      // property to get and set the name instance variable
            {
                get                               // returns the corresponding instance variable's value
                    {
                        return name2;              // returns the value of name to the client code
                    }
                set                               // assigns a new value to the corresponding instance variable
                    {
                        name2 = value;             // value is implicitly declared and initialized
                    }
            }
    }