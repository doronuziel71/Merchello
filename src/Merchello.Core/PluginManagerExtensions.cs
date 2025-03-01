﻿namespace Merchello.Core
{
    using System;
    using System.Collections.Generic;
    using Gateways;

    using Merchello.Core.Chains.OfferConstraints;

    using Observation;
    using Umbraco.Core;

    /// <summary>
    /// Extension methods for the <see cref="PluginManager"/>
    /// </summary>
    internal static class PluginManagerExtensions
    {
        /// <summary>
        /// Returns all available GatewayProvider
        /// </summary>
        /// <param name="pluginManager">
        /// The plugin Manager.
        /// </param>
        /// <returns>
        /// The collection of gateway providers resolved
        /// </returns>
        internal static IEnumerable<Type> ResolveGatewayProviders(this PluginManager pluginManager)
        {
            return pluginManager.ResolveTypesWithAttribute<GatewayProviderBase, GatewayProviderActivationAttribute>();
        }

        /// <summary>
        /// Returns a collection of all <see cref="IMonitor"/> types decorated with the <see cref="MonitorForAttribute"/>
        /// </summary>
        /// <param name="pluginManager">
        /// The plugin Manager.
        /// </param>
        /// <returns>
        /// The collection of monitor types resolved
        /// </returns>
        internal static IEnumerable<Type> ResolveObserverMonitors(this PluginManager pluginManager)
        {
            return pluginManager.ResolveTypesWithAttribute<IMonitor, MonitorForAttribute>();
        }

        /// <summary>
        /// Returns a collection of all <see cref="ITrigger"/> types decorated with the <see cref="TriggerForAttribute"/>
        /// </summary>
        /// <param name="pluginManager">
        /// The plugin Manager.
        /// </param>
        /// <returns>
        /// The collection of trigger types resolved
        /// </returns>
        internal static IEnumerable<Type> ResolveObservableTriggers(this PluginManager pluginManager)
        {
            return pluginManager.ResolveTypesWithAttribute<ITrigger, TriggerForAttribute>();
        }

        /// <summary>
        /// The resolve offer constraint chains.
        /// </summary>
        /// <param name="pluginManager">
        /// The plugin manager.
        /// </param>
        /// <returns>
        /// The collection of <see cref="IOfferProcessor"/> types
        /// </returns>
        internal static IEnumerable<Type> ResolveOfferConstraintChains(this PluginManager pluginManager)
        {
            return pluginManager.ResolveTypesWithAttribute<IOfferProcessor, OfferConstraintChainForAttribute>();
        } 
    }
}