using WearRead.Models.UI;

namespace WearRead.View_Models.Home_Views;

public class OverviewVM
{
    public OverviewVM()
    {
    }

    public void LoadCurrentBook()
    {
        // DEMO
        this.CurrentBook.Title = "All The Light We Cannot See";
        this.CurrentBook.CurrentPage = 521;
        this.CurrentBook.TotalPages = 530;
    }

    public BookUI CurrentBook { get; set; } = new();
}