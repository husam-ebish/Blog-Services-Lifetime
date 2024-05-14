using MHE.ServicesLifetime.Models;

namespace MHE.ServicesLifetime.Services.Singleton
{
    internal class SingletonService : ISingletonService
    {
        private ServiceLifetimeData serviceLifetimeData;

        public SingletonService()
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
