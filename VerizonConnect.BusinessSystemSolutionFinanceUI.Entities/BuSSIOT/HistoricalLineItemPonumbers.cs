// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalLineItemPonumbers.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Line Item PO Numbers model class
    /// </summary>
    public class HistoricalLineItemPonumbers
    {
        public long HistoricalLineItemPonumberId { get; set; }
        public long LineItemPonumberId { get; set; }
        public long LineItemId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalLineItemPonumbersCreatedDate { get; set; }
    }
}
