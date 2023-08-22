using System;
using Reflex.Core;

namespace CodeBase.Infrastructure.DI.Extension
{
    public static class BindExtension
    {
        public static ContainerDescriptor Bind<TService, TRealisation>(this ContainerDescriptor diContainer)
            where TRealisation : TService
        {
            return diContainer.AddSingleton(typeof(TRealisation), typeof(TService));
        }
        public static ContainerDescriptor BindDisposable<TService, TRealisation>(this ContainerDescriptor diContainer)
            where TRealisation : TService
        {
            return diContainer.AddSingleton(typeof(TRealisation), typeof(TService), typeof(IDisposable));
        }
    }
}