//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OfferManagement.DataModel
{
    //[JsonConverter(typeof(StringEnumConverter))]
    [DataContract]
    public enum ProviderType
    {
        [EnumMember]
        Earn = 0,

        [EnumMember]
        Burn = 1
    }
}