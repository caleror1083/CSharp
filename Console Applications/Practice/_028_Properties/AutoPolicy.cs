using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _028_Properties
    {
        // Classes
	    internal class AutoPolicy
	        {
                // Properties
		        public int AccountNumber { get; set; }      // policy account number
                public string MakeAndModel { get; set; }    // car that policy applies to
                public string State { get; set; }           // two-letter state abbreviation
                public bool IsNoFaultState                  // returns whether the state has no-fault insurance
                    {
                        get
                            {
                                bool noFaultState;

                                // determine whether state has no-fault auto insurance           
                                switch (State)              // get AutoPolicy object's state abbreviation
                                    {
                                        case "MA": case "NJ": case "NY": case "PA":
                                            noFaultState = true;
                                            break;
                                        default:
                                            noFaultState = false;
                                            break;
                                    }
                                return noFaultState;
                            }
                    }

                // Constructors(Parameters)
                public AutoPolicy(int accountNumber, string makeAndModel, string state)
                    {
                        AccountNumber = accountNumber;
                        MakeAndModel = makeAndModel;
                        State = state;
                    }
	        }
    }