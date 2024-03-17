namespace WearRead.Services.Database_Controller;

public static class DBController
{
    public static bool Create<T>(T to_create)
    {
        return true;
    }

    public static List<T> ReadAll<T>()
    {
        List<T> to_return = [];

        return to_return;
    }

    public static T Read<T>(Guid Key)
    {

    }

    public static bool Update<T>(T to_update)
    {
        return true;
    }

    public static bool Delete<T>(T to_update)
    {
        return true;
    }
}