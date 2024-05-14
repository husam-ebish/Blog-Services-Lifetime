using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Transient
{
    internal class TransientService : ITransientService
    {
        private ServiceLifetimeData serviceLifetimeData;

        public TransientService()
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
