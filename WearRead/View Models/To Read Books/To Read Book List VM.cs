using System.Collections.ObjectModel;
using WearRead.Models.UI;
using WearRead.Views.To_Read_Books_List.Individual_Book;

namespace WearRead.View_Models.To_Read_Books;

public class ToReadBookListVM
{
    public ToReadBookListVM()
    {
        this.CommandLoadBooksToRead = new(LoadBooksToRead);
    }

    public void LoadBooksToRead()
    {
        // TODO
        if (this.BooksToRead.Count >= 50)
            return;

        int current_count = this.BooksToRead.Count;

        for (int i = 0; i < 10; i++)
            this.BooksToRead.Add(new() { Title = (current_count + i).ToString(), Cover = ImageSource.FromFile("mr_fluffy.jpg") });
    }

    private void AddNewBook()
    {
        Shell.Current.Navigation.PushAsync(new AddToReadBookView());
    }

    public Command CommandLoadBooksToRead { get; set; }
    public Command CommandAddNewBook { get; set; }

    public ObservableCollection<BookUI> BooksToRead { get; set; } = [];
}