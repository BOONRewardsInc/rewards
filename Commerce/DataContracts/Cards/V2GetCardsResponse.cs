//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.DataContracts
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the response to a V2 Get Cards API invocation.
    /// </summary>
    [DataContract]
    public class V2GetCardsResponse : CommerceResponse
    {
        /// <summary>
        /// Gets or sets the Cards object.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "cards")]
        public IEnumerable<V2CardDataContract> Cards { get; set; }
    }
}