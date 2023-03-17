using CommandLine;
using ScrutorLib.Services;
using ScrutorLib.Services.Domain;
using Utils;
using Environment = Utils.Environment;

namespace TestWitScrutor;

public class Program
{
    public static async Task Main(string[] args)
    {
        IHost host = CreateHostBuilder(args);

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var srv = services.GetRequiredService<IRepository<User>>();

            var result = await srv.GetData();
            result.ToList().ForEach(usr => Console.WriteLine($"{usr.Id} - {usr.Value} - {usr.Name}"));
        }
    }

    private static IHost CreateHostBuilder(string[] args)
    {
        string environment = Environment.DEVELOPMENT;
        Parser.Default.ParseArguments<AppEnvironment>(args).WithParsed(o =>
        {
            Console.WriteLine($"Creating context for environment \"{o.Value}\"");
            environment = o.Value;
        });
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => Startup.Configure(services, environment))
            .Build();
    }

}
