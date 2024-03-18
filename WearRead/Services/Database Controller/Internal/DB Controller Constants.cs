using SQLite;

namespace WearRead.Services.Database_Controller.Internal;

public static class DBControllerConstants
{
    public static string DATABASE_PATH { get => Path.Combine(FileSystem.AppDataDirectory, DATABASE_NAME); }
    public static readonly string DATABASE_NAME = "local_db.db3";
    public static readonly SQLiteOpenFlags DATABASE_FLAGS = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
}