// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="ShipLineItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Ship Line Items model class
    /// </summary>
    public class ShipLineItems
    {
        public ShipLineItems()
        {
            ShipItemDetails = new HashSet<ShipItemDetails>();
        }

        public long ShipLineItemId { get; set; }
        public long LineItemId { get; set; }
        public string SalesId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipVendor { get; set; }
        public string ReturnVendor { get; set; }
        public string TrackingNumber { get; set; }
        public string ReturnTrackingNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public LineItems LineItem { get; set; }
        public ICollection<ShipItemDetails> ShipItemDetails { get; set; }
    }
}
