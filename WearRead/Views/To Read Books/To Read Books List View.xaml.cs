using WearRead.View_Models.To_Read_Books;

namespace WearRead.Views.To_Read_Books;

public partial class ToReadBooksListView : ContentPage
{
	public ToReadBooksListView()
	{
		InitializeComponent();

		this.view_model = new();
		BindingContext = this.view_model;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		this.view_model.LoadBooksToRead();
    }

    private ToReadBookListVM view_model;
}