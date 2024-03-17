using WearRead.Models.Local_DB;
using WearRead.Models.UI;

namespace WearRead.Services.Converters;

public static class BookConverter
{
    public static BookUI ConvertBookORMToBookUI(BookORM to_convert)
    {
        return new()
        {
            ID = to_convert.ID,
            Title = to_convert.Title,
            Cover = ImageSource.FromStream(() => new MemoryStream(to_convert.Cover)),
            CurrentPage = to_convert.CurrentPage,
            TotalPages = to_convert.TotalPages
        };
    }
}