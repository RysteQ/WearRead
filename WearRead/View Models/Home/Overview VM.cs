using WearRead.Models.UI;
using WearRead.Views.To_Read_Books;

namespace WearRead.View_Models.Home;

public class OverviewVM
{
    public OverviewVM()
    {
        this.CommandGoToToReadBooksList = new(GoToToReadBooksList);
    }

    public void LoadCurrentBook()
    {
        // DEMO
        this.CurrentBook.Title = "All The Light We Cannot See";
        this.CurrentBook.Cover = ImageSource.FromFile("mr_fluffy.jpg");
        this.CurrentBook.CurrentPage = 521;
        this.CurrentBook.TotalPages = 530;
    }

    private void GoToToReadBooksList()
    {
        Shell.Current.Navigation.PushAsync(new ToReadBooksListView());
    }

    public Command CommandGoToToReadBooksList { get; set; }

    public BookUI CurrentBook { get; set; } = new();
}