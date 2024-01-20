using CollectionViewDemo_2024.MVVM.ViewModels;

namespace CollectionViewDemo_2024.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}
