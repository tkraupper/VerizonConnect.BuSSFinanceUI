// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalCustomers.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Customers model class
    /// </summary>
    public class HistoricalCustomers
    {
        public long HistoricalCustomerId { get; set; }
        public long CustomerId { get; set; }
        public long OrderId { get; set; }
        public string Ecpdid { get; set; }
        public string VzwcustomerId { get; set; }
        public string BusinessName { get; set; }
        public string ExternalVendorReferenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalCustomersCreatedDate { get; set; }
        public string VzwaccountNumber { get; set; }
    }
}
