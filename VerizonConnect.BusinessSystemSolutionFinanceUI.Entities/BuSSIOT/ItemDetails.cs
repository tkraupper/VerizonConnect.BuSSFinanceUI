// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="ItemDetails.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Item Details model class
    /// </summary>
    public class ItemDetails
    {
        public ItemDetails()
        {
            ShipItemDetails = new HashSet<ShipItemDetails>();
        }

        public long ItemDetailId { get; set; }
        public long LineItemId { get; set; }
        public int ItemSequenceNumber { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public LineItems LineItem { get; set; }
        public ICollection<ShipItemDetails> ShipItemDetails { get; set; }
    }
}
