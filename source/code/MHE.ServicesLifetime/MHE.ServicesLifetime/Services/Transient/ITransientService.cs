using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Transient
{
    public interface ITransientService
    {
        ServiceLifetimeData PrintServiceLifetimeInformation();
    }
}
