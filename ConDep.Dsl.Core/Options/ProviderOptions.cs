﻿using System.Collections.Generic;

namespace ConDep.Dsl.Core
{
    public class ProviderOptions : IProvideForExistingIisServer, IProvideForCustomIisDefinition, IProvideForInfrastructureIis
    {
        private readonly List<IProvide> _providers;
        private readonly DeploymentServer _server;

        public ProviderOptions(List<IProvide> providers)
        {
            _providers = providers;
        }

        public ProviderOptions(List<IProvide> providers, DeploymentServer server)
        {
            _providers = providers;
            _server = server;
        }

        public void AddProvider(IProvide provider)
        {
            _providers.Add(provider);

            if (provider is CompositeProvider)
            {
                ((CompositeProvider)provider).Configure(_server);
            }
        }
    }
}