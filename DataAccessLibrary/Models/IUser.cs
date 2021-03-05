namespace DataAccessLibrary
{
    interface IUser
    {
        string Email { get; set; }
        int Id { get; set; }
        string Password { get; set; }
    }
}