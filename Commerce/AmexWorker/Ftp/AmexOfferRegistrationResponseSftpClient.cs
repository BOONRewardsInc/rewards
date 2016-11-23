//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.AmexWorker
{
    using Lomo.Commerce.Logging;

    /// <summary>
    /// Amex Offer Registration Response Sftp handling.
    /// </summary>
    public class AmexOfferRegistrationResponseSftpClient : AmexSftpClientBase
    {
        public AmexOfferRegistrationResponseSftpClient(CommerceLog log) 
            : base(UserName, Password, log)
        {
        }

        /// <summary>
        /// Username
        /// </summary>
        private static string UserName = GetPropertyValue(AmexSftpConstants.AmexOfferRegResponseSftpUserNamePropertyName);

        /// <summary>
        /// Password
        /// </summary>
        private static string Password = GetPropertyValue(AmexSftpConstants.AmexOfferRegResponseSftpPasswordPropertyName);
    }
}