namespace Utils;

[AttributeUsage(AttributeTargets.Class)]
public class AppEnvironmentAttribute : Attribute
{
    public string EnvironmentName { get; private set; }

    public AppEnvironmentAttribute(string environmentName = Environment.DEVELOPMENT)
    {
        this.EnvironmentName = !Environment.Environments.Contains(environmentName)
            ? Environment.DEVELOPMENT
            : environmentName;
    }
}

public static class Environment
{
    public const string PRODUCTION = "prod";
    public const string DEVELOPMENT = "dev";
    public const string QA = "qa";

    public static readonly IList<string> Environments = new List<string>(){ PRODUCTION, DEVELOPMENT};
}