//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>

namespace Earn.Dashboard.DAL.db.Commerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerUserID
    {
        public int UserId { get; set; }
        public int Partner { get; set; }
        public string PartnerUserID1 { get; set; }
        public bool Active { get; set; }
        public System.DateTime UtcAdded { get; set; }
        public System.DateTime UtcUpdated { get; set; }
    
        public virtual User User { get; set; }
    }
}