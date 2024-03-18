using SQLite;
using WearRead.Models.Local_DB;
using WearRead.Services.Database_Controller.Internal;

namespace WearRead.Services.Database_Controller;

public static class DBController
{
    public static void Init(Type[] types)
    {
        if (initialized)
            throw new Exception("The Init method can only be called once");

        local_database = new(DBControllerConstants.DATABASE_PATH, DBControllerConstants.DATABASE_FLAGS);
    
        foreach (Type type in types)
            local_database.CreateTable(type);
        
        initialized = true;
    }

    public static void Create<T>(T to_create)
    {
        CheckInitialization();

        local_database.Insert(to_create);
    }

    public static List<T> ReadAll<T>() where T : new()
    {
        CheckInitialization();

        return local_database.Table<T>().ToList();
    }

    public static T Read<T>(Guid key) where T : new()
    {
        CheckInitialization();

        return local_database.Table<T>().Where(selected_item => (selected_item as ORMObject).ID == key).First();
    }

    public static void Update<T>(T to_update)
    {
        CheckInitialization();

        local_database.Update(to_update);
    }

    public static void Delete<T>(T to_update)
    {
        CheckInitialization();

        (to_update as ORMObject).GCRecord = new Random().Next();
        local_database.Update(to_update);
    }
    
    private static void CheckInitialization()
    {
        if (initialized == false)
            throw new Exception("Call the Init method first");
    }

    private static bool initialized = false;
    private static SQLiteConnection local_database;
}