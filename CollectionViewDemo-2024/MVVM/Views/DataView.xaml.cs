using CollectionViewDemo_2024.MVVM.ViewModels;

namespace CollectionViewDemo_2024.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}
