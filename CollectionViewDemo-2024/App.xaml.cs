using CollectionViewDemo_2024.MVVM.Views;

namespace CollectionViewDemo_2024;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LayoutsPage();
	}
}

