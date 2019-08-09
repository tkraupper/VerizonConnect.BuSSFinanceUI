// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalOrders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Orders model class
    /// </summary>
    public class HistoricalOrders
    {
        public long HistoricalOrderId { get; set; }
        public long OrderId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ConfirmationId { get; set; }
        public string AccountReference { get; set; }
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalOrdersCreatedDate { get; set; }
    }
}
