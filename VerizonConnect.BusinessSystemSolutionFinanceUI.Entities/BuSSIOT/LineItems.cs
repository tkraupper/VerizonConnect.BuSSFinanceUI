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

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Line Items model class
    /// </summary>
    public class LineItems
    {
        public LineItems()
        {
            this.ItemDetails = new HashSet<ItemDetails>();
            this.LineItemPonumbers = new HashSet<LineItemPonumbers>();
            this.LineItemRemarks = new HashSet<LineItemRemarks>();
            this.LineItemStatuses = new HashSet<LineItemStatuses>();
            this.ShipAddresses = new HashSet<ShipAddresses>();
            this.ShipLineItems = new HashSet<ShipLineItems>();
        }

        public long LineItemId { get; set; }
        public long OrderId { get; set; }
        public int MultiLineSequenceNumber { get; set; }
        public int? WarehouseSequence { get; set; }
        public string MobileNumber { get; set; }
        public string ShipMethod { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public Orders Order { get; set; }
        public ICollection<ItemDetails> ItemDetails { get; set; }
        public ICollection<LineItemPonumbers> LineItemPonumbers { get; set; }
        public ICollection<LineItemRemarks> LineItemRemarks { get; set; }
        public ICollection<LineItemStatuses> LineItemStatuses { get; set; }
        public ICollection<ShipAddresses> ShipAddresses { get; set; }
        public ICollection<ShipLineItems> ShipLineItems { get; set; }
    }
}
