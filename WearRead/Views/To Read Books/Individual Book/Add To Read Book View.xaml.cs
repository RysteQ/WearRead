using WearRead.View_Models.To_Read_Books.Individual_Book;

namespace WearRead.Views.To_Read_Books_List.Individual_Book;

public partial class AddToReadBookView : ContentPage
{
	public AddToReadBookView()
	{
		InitializeComponent();

		this.view_model = new();
		BindingContext = this.view_model;
	}

	private AddToReadBookVM view_model;
}