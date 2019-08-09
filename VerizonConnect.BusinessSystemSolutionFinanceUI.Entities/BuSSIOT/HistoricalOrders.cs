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

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Orders model class
    /// </summary>
    public class HistoricalOrders
    {
        public long HistoricalOrderId { get; set; }
        public long OrderId { get; set; }
        public string LocationCode { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string AccountNumber { get; set; }
        public string SoftwareOrdered { get; set; }
        public string ExternalVendorReferenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalOrdersCreatedDate { get; set; }
    }
}
