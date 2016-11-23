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
    
    public partial class Authorization
    {
        public System.Guid Id { get; set; }
        public int PartnerId { get; set; }
        public string TransactionId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int TransactionAmount { get; set; }
        public long ClaimedDealId { get; set; }
        public int DiscountAmount { get; set; }
        public string PartnerData { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string TransactionScopeId { get; set; }
        public bool PermaPending { get; set; }
        public int ReviewStatusId { get; set; }
        public int MerchantNameId { get; set; }
    
        public virtual TransactionLink TransactionLink { get; set; }
        public virtual MerchantName MerchantName { get; set; }
        public virtual Partner Partner { get; set; }
    }
}