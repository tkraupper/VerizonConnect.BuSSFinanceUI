// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalLineItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Line Items model class
    /// </summary>
    public class HistoricalLineItems
    {
        public long HistoricalLineItemId { get; set; }
        public long LineItemId { get; set; }
        public long OrderId { get; set; }
        public string TransactionType { get; set; }
        public string FulfillmentId { get; set; }
        public string ParentFulfillmentId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? HistoricalLineItemsCreatedDate { get; set; }
    }
}
