//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.MasterCardClient
{
    using System;

    /// <summary>
    /// Represents a header record for a MasterCard transaction clearing file.
    /// </summary>
    public class ClearingHeader
    {
        /// <summary>
        /// Gets or sets the date and time at which the clearing file was created.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the member ICA for the intended file recipient.
        /// </summary>
        public string MemberIca { get; set; }
    }
}