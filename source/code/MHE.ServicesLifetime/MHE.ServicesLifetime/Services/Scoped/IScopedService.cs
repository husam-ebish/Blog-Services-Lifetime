using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Scoped
{
    public interface IScopedService
    {
        ServiceLifetimeData PrintServiceLifetimeInformation();
    }
}
