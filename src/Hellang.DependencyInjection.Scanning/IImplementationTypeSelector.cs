using System;
using Microsoft.Framework.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection.Scanning
{
    public interface IImplementationTypeSelector : IFluentInterface
    {
        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies that are annotated with
        /// the <see cref="ServiceDescriptorAttribute"/> to the <see cref="IServiceCollection"/>.
        /// </summary>
        void AddAttributes();

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies to the <see cref="IServiceCollection"/>.
        /// </summary>
        IServiceTypeSelector AddClasses();

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies that
        /// matches the requirements specified in the <paramref name="action"/>
        /// to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="action">The filtering action.</param>
        /// <exception cref="ArgumentNullException">If the <paramref name="action"/> argument is <c>null</c>.</exception>
        IServiceTypeSelector AddClasses(Action<IImplementationTypeFilter> action);
    }
}