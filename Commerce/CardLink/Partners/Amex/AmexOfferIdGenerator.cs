//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.CardLink
{
    using System;
    using Lomo.Commerce.Context;
    using Lomo.Commerce.DataAccess;
    using Lomo.Commerce.Logic;
    using Lomo.Commerce.Utilities;

    /// <summary>
    /// Generator for Amex Offer Ids
    /// </summary>
    public static class AmexOfferIdGenerator
    {
        /// <summary>
        /// Create a new offer Id for registering a deal with Amex
        /// </summary>
        /// <param name="context">
        /// Incoming Commerce Context
        /// </param>
        /// <returns>
        /// The Id of the new offer
        /// </returns>
        public static int GenerateNewOfferId(CommerceContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context", "Parameter context cannot be null.");
            }

            context[Key.SequenceName] = "AmexOfferIdSequence";
            SharedSequenceLogic sharedSequenceLogic = new SharedSequenceLogic(context, CommerceOperationsFactory.SequenceOperations(context));
            return sharedSequenceLogic.RetrieveNextValueInSequence();
        }
    }
}