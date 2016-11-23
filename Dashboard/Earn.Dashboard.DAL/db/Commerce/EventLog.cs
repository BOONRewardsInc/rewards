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
    
    public partial class EventLog
    {
        public long EventID { get; set; }
        public Nullable<System.DateTime> LocalDate { get; set; }
        public string Process { get; set; }
        public string Status { get; set; }
        public string Mode { get; set; }
        public string Action { get; set; }
        public string Target { get; set; }
        public Nullable<long> Rows { get; set; }
        public Nullable<int> Milliseconds { get; set; }
        public string EventText { get; set; }
        public System.DateTime EventDate { get; set; }
        public Nullable<long> ParentEventID { get; set; }
        public short SPID { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
    }
}