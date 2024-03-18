namespace WearRead.Models.Local_DB;

public class ORMObject
{
    public Guid ID { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastDateModified { get; set; }
    public DateTime CompletionDate { get; set; }
    public long GCRecord { get; set; }
}