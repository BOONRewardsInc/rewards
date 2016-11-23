//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.VisaWorker
{
    using System;
    using System.Collections.Generic;
    using Lomo.AssemblyUtils;
    using Lomo.Commerce.Configuration;
    using Lomo.Commerce.Logging;

    /// <summary>
    /// Factory to create Visa blob store clients
    /// </summary>
    public static class VisaBlobClientFactory
    {
        /// <summary>
        ///  Gets the Visa Pts Blob Client
        /// </summary>
        /// <param name="connectionString">
        /// Storage connection string
        /// </param>
        /// <param name="log">
        /// Commerce Logger
        /// </param>
        /// <returns>
        /// Instace of Visa Pts Blob Client
        /// </returns>
        public static VisaPtsBlobClient VisaPtsBlobClient(string connectionString, CommerceLog log)
        {
            VisaPtsBlobClient result = null;
            if (CommerceWorkerConfig.Instance.UseMockPartnerDependencies == true)
            {
                result = LateBinding.BuildObjectFromLateBoundAssembly<VisaPtsBlobClient>("MockVisaPtsBlobClient",
                                                                                                LateBoundMocksAssemblyTypes);
            }
            else
            {
                result = new VisaPtsBlobClient(connectionString, log);
            }

            return result;
        }

        /// <summary>
        /// Gets the Types that exist within the specified mocks assembly.
        /// </summary>
        private static IEnumerable<Type> LateBoundMocksAssemblyTypes
        {
            get
            {
                if (lateBoundMocksAssemblyTypes == null)
                {
                    lateBoundMocksAssemblyTypes = LateBinding.GetLateBoundAssemblyTypes(MocksAssemblyName);
                }

                return lateBoundMocksAssemblyTypes;
            }
        }

        private static IEnumerable<Type> lateBoundMocksAssemblyTypes;

        /// <summary>
        /// The fully qualified name of the mocks assembly.
        /// </summary>
        private const string MocksAssemblyName = "Lomo.Commerce.Test.Mocks.dll";
    }
}