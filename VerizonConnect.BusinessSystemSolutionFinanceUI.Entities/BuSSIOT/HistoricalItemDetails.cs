// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalItemDetails.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Item Details model class
    /// </summary>
    public class HistoricalItemDetails
    {
        public long HistoricalItemDetailId { get; set; }
        public long ItemDetailId { get; set; }
        public long LineItemId { get; set; }
        public int ItemSequenceNumber { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalItemDetails1 { get; set; }
    }
}
