using CommandLine;

namespace Utils;

public class AppEnvironment
{
    [Option("env", Required = false, Default = Environment.DEVELOPMENT, HelpText = "Environment")]
    public string Value { get; set; }
}
