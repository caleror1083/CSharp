namespace _038_EqualsMethod
	{
		internal class ExamplesInfo
		{
			// Fields
			// Constructors
			// Properties
			public string FirstName { get; set; }
			public string LastName { get; set; }

			// Methods
			public override bool Equals(object obj)
					{
						if (obj == null)
							{
								return false;
							}
						
						if (!(obj is ExamplesInfo))
							{
								return false;
							}
						return FirstName == ((ExamplesInfo)obj).FirstName && LastName == ((ExamplesInfo)obj).LastName;
					}

			public override int GetHashCode()
				{
					return FirstName.GetHashCode() ^ LastName.GetHashCode();
				}
	}
	}