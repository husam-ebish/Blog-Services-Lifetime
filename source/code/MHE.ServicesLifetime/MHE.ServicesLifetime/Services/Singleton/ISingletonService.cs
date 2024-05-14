using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Singleton
{
    public interface ISingletonService
    {
        ServiceLifetimeData PrintServiceLifetimeInformation();
    }
}
