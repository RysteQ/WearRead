namespace WearRead.Models.Local_DB;

public class BookORM
{
    public Guid ID { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastDateModified { get; set; }
    public DateTime CompletionDate { get; set; }
    public string Title { get; set; } = string.Empty;
    public byte[] Cover { get; set; } = [];
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}