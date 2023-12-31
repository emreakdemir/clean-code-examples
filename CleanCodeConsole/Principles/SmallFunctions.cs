namespace CleanCodeConsole.Principles;

public class SmallFunctions
{
    #region Validator-BadPractice
    public bool Validate(User user)
    {
        if (string.IsNullOrEmpty(user.Name))
        {
            return false;
        }

        if (user.Age is < 18 or > 99)
        {
            return false;
        }

        return true;
    }
    #endregion

    #region Validator-CleanCode
    public bool IsNameValid(string name)
    {
        return !string.IsNullOrEmpty(name);
    }

    public bool IsAgeValid(int age)
    {
        return age is >= 18 and <= 99;
    }

    public bool ValidateUser(User user)
    {
        return IsNameValid(user.Name) && IsAgeValid(user.Age);
    }
    #endregion
}

#region Nested
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}
#endregion