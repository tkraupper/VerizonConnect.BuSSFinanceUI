// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="LineItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Line items model class
    /// </summary>
    public class LineItems
    {
        public LineItems()
        {
            Categories = new HashSet<Categories>();
            Contacts = new HashSet<Contacts>();
            Informations = new HashSet<Informations>();
            InverseParentFulfillment = new HashSet<LineItems>();
            Items = new HashSet<Items>();
            LineItemStatuses = new HashSet<LineItemStatuses>();
            PricePlanPackages = new HashSet<PricePlanPackages>();
            ServiceDeliveryAddresses = new HashSet<ServiceDeliveryAddresses>();
            UnitData = new HashSet<UnitData>();
        }

        public long LineItemId { get; set; }
        public long OrderId { get; set; }
        public string TransactionType { get; set; }
        public string FulfillmentId { get; set; }
        public string ParentFulfillmentId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public Orders Order { get; set; }
        public LineItems ParentFulfillment { get; set; }
        public ICollection<Categories> Categories { get; set; }
        public ICollection<Contacts> Contacts { get; set; }
        public ICollection<Informations> Informations { get; set; }
        public ICollection<LineItems> InverseParentFulfillment { get; set; }
        public ICollection<Items> Items { get; set; }
        public ICollection<LineItemStatuses> LineItemStatuses { get; set; }
        public ICollection<PricePlanPackages> PricePlanPackages { get; set; }
        public ICollection<ServiceDeliveryAddresses> ServiceDeliveryAddresses { get; set; }
        public ICollection<UnitData> UnitData { get; set; }
    }
}
