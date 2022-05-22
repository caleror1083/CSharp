class Program
	{
		static void Main()
			{
				KeyValue<string, string> superman = new KeyValue<string, string>("", "");
				superman.Key = "Superman";
				superman.Value = "Clark Kent";

				KeyValue<string, string> samsungTV = new KeyValue<string, string>("", "");
				samsungTV.Key = "M50";
				samsungTV.Value = "a 50 inch Samsung TV";

				superman.ShowData();
				samsungTV.ShowData();
			}
	}