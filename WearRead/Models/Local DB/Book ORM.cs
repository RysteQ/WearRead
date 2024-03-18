namespace WearRead.Models.Local_DB;

public class BookORM : ORMObject
{
    public string Title { get; set; } = string.Empty;
    public byte[] Cover { get; set; } = [];
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}