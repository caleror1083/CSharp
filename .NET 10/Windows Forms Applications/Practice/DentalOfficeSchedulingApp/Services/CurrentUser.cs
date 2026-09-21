namespace DentalOfficeSchedulingApp.Services;

public static class CurrentUser
{
    public static int UserId { get; private set; }
    public static string UserName { get; private set; } = string.Empty;
    public static bool IsLoggedIn => UserId > 0;

    public static void Set(int userId, string userName)
    {
        UserId = userId;
        UserName = userName;
    }

    public static void Clear()
    {
        UserId = 0;
        UserName = string.Empty;
    }
}