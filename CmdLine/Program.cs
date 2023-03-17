using System;
using CommandLine;

namespace CmdLine;

public class Program
{
    // [Verb( "env", HelpText = "Set output to verbose messages.")]
    // // [Verb( "env", Required = false, HelpText = "Set output to verbose messages.", Default = DEVELOPMENT)]
    // public class AppEnvironment
    // {
    //     public const string DEVELOPMENT = "dev";
    //     public const string QA = "qa";
    //     public const string PRODUCTION = "prod";
    //     
    //     public string Value { get; set; }
    // }
    public class AppEnvironment
    {
        public const string DEVELOPMENT = "dev";
        public const string QA = "qa";
        public const string PRODUCTION = "prod";
        
        [Option("env", Required = false, Default = AppEnvironment.DEVELOPMENT, HelpText = "Environment")]
        public string Value { get; set; }
    }
    
    
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<AppEnvironment>(args).WithParsed(o =>
        {
            Console.WriteLine($"Value {o.Value}");
        });

        // Parser.Default.ParseArguments<AppEnvironment>(args)
        //     .WithParsed<AppEnvironment>( appEnv =>
        //         {
        //             Console.WriteLine($"App env = {appEnv.Value}");
        //         })
        //     .WithNotParsed(err => 
        //         {
        //             Console.WriteLine($"{err.Count()}");
        //         }
        //     );


        // .WithParsed(o =>
        // {
        //     switch (o.Value)
        //     {
        //             case AppEnvironment.PRODUCTION:
        //             {
        //                 Console.WriteLine($"Production - no debug allowed!");
        //                 break;
        //             }   
        //             case AppEnvironment.QA:
        //             {
        //                 Console.WriteLine($"QA - go go testers!");
        //                 break;
        //             }   
        //             default:
        //             {
        //                 Console.WriteLine($"DEV - developers playground!");
        //                 break;
        //             }
        //     }
        // });
    }
}