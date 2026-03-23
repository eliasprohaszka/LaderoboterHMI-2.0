using Microsoft.Extensions.DependencyInjection;
using Laderoboter.UI.Services;

namespace Laderoboter.UI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLaderoboterUI(this IServiceCollection services)
    {
        services.AddSingleton<IAuthStateService, AuthStateService>();
        services.AddSingleton<IVirtualKeyboardService, VirtualKeyboardService>();

        return services;
    }
}
