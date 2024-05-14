using MHE.ServicesLifetime.Models;
using MHE.ServicesLifetime.Services.Scoped;
using MHE.ServicesLifetime.Services.Singleton;
using MHE.ServicesLifetime.Services.Transient;
using Microsoft.AspNetCore.Components;

namespace MHE.ServicesLifetime.Components.Pages
{
    public partial class Home
    {
        private ServiceLifetimeData? singeltonAlphaServiceLifetimeData;
        private ServiceLifetimeData? singeltonBetaServiceLifetimeData;
        private ServiceLifetimeData? scopedAlphaServiceLifetimeData;
        private ServiceLifetimeData? scopedBetaServiceLifetimeData;
        private ServiceLifetimeData? transientAlphaServiceLifetimeData;
        private ServiceLifetimeData? transientBetaServiceLifetimeData;

        [Inject]
        private ISingletonService SingletonAlphaService { get; set; }

        [Inject]
        private ISingletonService SingletonBetaService { get; set; }

        [Inject]
        private IScopedService ScopedAlphaService { get; set; }

        [Inject]
        private IScopedService ScopedBetaService { get; set; }

        [Inject]
        private ITransientService TransientAlphaService { get; set; }

        [Inject]
        private ITransientService TransientBetaService { get; set; }

        protected override void OnInitialized()
        {
            this.CallSingeltonService();

            this.CallScopedService();

            this.CallTransientService();
        }

        private void CallSingeltonService()
        {
            this.singeltonAlphaServiceLifetimeData = this.SingletonAlphaService.PrintServiceLifetimeInformation();
            this.singeltonBetaServiceLifetimeData = this.SingletonBetaService.PrintServiceLifetimeInformation();
        }

        private void CallScopedService()
        {
            this.scopedAlphaServiceLifetimeData = this.ScopedAlphaService.PrintServiceLifetimeInformation();

            this.scopedBetaServiceLifetimeData = this.ScopedBetaService.PrintServiceLifetimeInformation();
        }

        private void CallTransientService()
        {
            this.transientAlphaServiceLifetimeData = this.TransientAlphaService.PrintServiceLifetimeInformation();

            this.transientBetaServiceLifetimeData = this.TransientBetaService.PrintServiceLifetimeInformation();
        }
    }
}
