using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Scoped
{
    internal class ScopedService : IScopedService
    {
        private ServiceLifetimeData serviceLifetimeData;

        public ScopedService()
        {
            this.serviceLifetimeData = new ServiceLifetimeData
            {
                InstanceInformation = $"{Guid.NewGuid()}"
            };
        }

        public ServiceLifetimeData PrintServiceLifetimeInformation()
        {
            return this.serviceLifetimeData;
        }
    }
}
