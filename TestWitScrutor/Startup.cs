using ScrutorLib.Services;
using Utils;

namespace TestWitScrutor;

public static class Startup
{

    public static void Configure(IServiceCollection services, string environment)
    {
        services.Scan(scan => 
            scan.FromAssemblyOf<IServiceLib>()
                .AddClasses(classes => classes.WithAttribute<AppEnvironmentAttribute>(attribute => attribute.EnvironmentName == environment))
                .AsImplementedInterfaces()
                .WithScopedLifetime()
            );
    }
}