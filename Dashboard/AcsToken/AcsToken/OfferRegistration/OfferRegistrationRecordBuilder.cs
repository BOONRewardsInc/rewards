//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace AcsToken
{
    using System;
    using Lomo.Commerce.AmexClient;

    /// <summary>
    /// Builder for Offer Registration Record for Amex
    /// </summary>
    public static class OfferRegistrationRecordBuilder
    {
        /// <summary>
        /// Create a string representation of a record to add a new Amex Offer
        /// </summary>
        /// <param name="merchantId">
        /// Merchant Id : Dashboard registered Id
        /// </param>
        /// <param name="offerName">
        /// Offer Name: Description of the offer
        /// </param>
        /// <param name="startDateTime">
        /// Offer start date
        /// </param>
        /// <param name="endDateTime">
        /// Offer end date
        /// </param>
        /// <param name="merchantNumber">
        /// AMEX Merchant SE Number
        /// </param>
        /// <param name="merchantName">
        /// Name of the merchant
        /// </param>
        /// <returns>
        /// String representation of the record
        /// </returns>
        public static string BuildAddOffer(string merchantId, string offerName, DateTime startDateTime, DateTime endDateTime, string merchantNumber, string merchantName)
        {
            return new OfferRegistrationDetail()
            {
                ActionCode = OfferRegistrationActionCodeType.Add,
                MerchantName = merchantName,
                MerchantNumber = merchantNumber,
                MerchantEndDate = endDateTime,
                MerchantId = merchantId,
                OfferName = offerName,
                MerchantStartDate = startDateTime
            }.BuildFileDetailRecord();
        }

        /// <summary>
        /// Create a string representation of a record to update an new Amex Offer
        /// </summary>
        /// <param name="merchantId">
        /// Merchant Id : Dashboard registered Id
        /// </param>
        /// <param name="offerName">
        /// Offer Name: Description of the offer
        /// </param>
        /// <param name="startDateTime">
        /// Offer start date
        /// </param>
        /// <param name="endDateTime">
        /// Offer end date
        /// </param>
        /// <param name="merchantNumber">
        /// AMEX Merchant SE Number
        /// </param>
        /// <param name="merchantName">
        /// Name of the merchant
        /// </param>
        /// <returns>
        /// String representation of the record
        /// </returns>
        public static string BuildUpdateOffer(string merchantId, string offerName, DateTime startDateTime, DateTime endDateTime, string merchantNumber, string merchantName)
        {
            return new OfferRegistrationDetail()
            {
                ActionCode = OfferRegistrationActionCodeType.Update,
                MerchantName = merchantName,
                MerchantNumber = merchantNumber,
                MerchantEndDate = endDateTime,
                MerchantId = merchantId,
                OfferName = offerName,
                MerchantStartDate = startDateTime
            }.BuildFileDetailRecord();
        }
    }
}