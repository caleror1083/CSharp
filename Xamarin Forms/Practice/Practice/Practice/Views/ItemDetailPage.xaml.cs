using Practice.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Practice.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}