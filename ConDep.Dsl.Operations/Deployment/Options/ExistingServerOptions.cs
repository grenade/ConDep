﻿using ConDep.Dsl.Core;

namespace ConDep.Dsl.Operations.Deployment.Options
{
    public class ExistingServerOptions
    {
        private IProvideForExistingIisServer _providerCollection;
        private WebDeployDefinition _webDeployDefinition;

        public ExistingServerOptions(WebDeployDefinition webDeployDefinition)
		{
			_webDeployDefinition = webDeployDefinition;
		}

        public IProvideForExistingIisServer Using
        {
            get { return _providerCollection ?? (_providerCollection = new ProviderOptions(_webDeployDefinition.Providers)); }
        }
    }
}   