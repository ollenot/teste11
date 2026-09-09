public class ValidateUser
{
    public bool Validate(string username, string password)
    {
        // Implement your user validation logic here
        // For example, check against a database or an in-memory list
        return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
    }
}