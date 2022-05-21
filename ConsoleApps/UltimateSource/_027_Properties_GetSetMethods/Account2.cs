        class Account2                                                      // Account class with a balance and a Deposit method.
            {
               public string Name { get; set; }                             // auto-implemented property
               private decimal balance;                                     // instance variable

               public Account2(string accountName, decimal initialBalance)  // Account constructor that receives two parameters  
                   {
                      Name = accountName;
                      Balance = initialBalance;                             // Balance's set accessor validates
                   }

               public decimal Balance                                       // Balance property with validation
                   {
                      get
                          {
                              return balance;
                          }
                      private set                                           // can be used only within the class
                          {
                             // validate that the balance is greater than 0.0; if it's not,
                             // instance variable balance keeps its prior value
                             if (value > 0.0m) // m indicates that 0.0 is a decimal literal
                                 {
                                    balance = value;
                                 }
                          }
                   }

               public void Deposit(decimal depositAmount)                   // method that deposits (adds) only a valid amount to the balance
                   {
                      if (depositAmount > 0.0m)                             // if the depositAmount is valid
                          {
                             Balance += depositAmount;             // add it to the balance 
                          }
                   }
            }