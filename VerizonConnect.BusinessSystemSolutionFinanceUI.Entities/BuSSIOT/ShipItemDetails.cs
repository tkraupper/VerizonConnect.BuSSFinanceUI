// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="ShipItemDetails.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Ship Item Details model class
    /// </summary>
    public class ShipItemDetails
    {
        public long ShipItemDetailId { get; set; }
        public long ShipLineItemId { get; set; }
        public long ItemDetailId { get; set; }
        public int ItemSequenceNumber { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public decimal Quantity { get; set; }
        public string SimItemCode { get; set; }
        public string Esn { get; set; }
        public string Meid { get; set; }
        public string Imei { get; set; }
        public string Iccid { get; set; }
        public string SimNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ItemDetails ItemDetail { get; set; }
        public ShipLineItems ShipLineItem { get; set; }
    }
}
