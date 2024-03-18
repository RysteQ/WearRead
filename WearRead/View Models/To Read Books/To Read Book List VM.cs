using System.Collections.ObjectModel;
using WearRead.Models.UI;
using WearRead.Services.Error_Informer;
using WearRead.Views.To_Read_Books_List.Individual_Book;
using WearRead.Resources.Translations.View_Models.To_Read_Books.To_Read_Book_List;
using WearRead.Services.Database_Controller;
using WearRead.Models.Local_DB;
using WearRead.Services.Converters;

namespace WearRead.View_Models.To_Read_Books;

public class ToReadBookListVM
{
    public ToReadBookListVM()
    {
        this.CommandAddNewBook = new(AddNewBook);
    }

    public void LoadBooksToRead()
    {
        Task.Run(() =>
        {
            try
            {
                List<BookORM> books_in_local_db = DBController.ReadAll<BookORM>();

                foreach (BookORM book in books_in_local_db)
                    this.BooksToRead.Add(BookConverter.ConvertBookORMToBookUI(book));
            } catch (Exception ex) { ErrorInformer.InformAdvanced(Localisation.Erro_Loading_To_Read_Books_From_Local_DB, ex, nameof(ToReadBookListVM)); }
        });
    }

    private void AddNewBook()
    {
        Shell.Current.Navigation.PushAsync(new AddToReadBookView());
    }

    public Command CommandAddNewBook { get; set; }

    public ObservableCollection<BookUI> BooksToRead { get; set; } = [];
}