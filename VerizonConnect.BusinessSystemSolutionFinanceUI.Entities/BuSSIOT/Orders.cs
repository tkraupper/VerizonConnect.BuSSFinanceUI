// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Orders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Orders model class
    /// </summary>
    public class Orders
    {
        public Orders()
        {
            Customers = new HashSet<Customers>();
            HistoricalServiceHeaders = new HashSet<HistoricalServiceHeaders>();
            LineItems = new HashSet<LineItems>();
            ServiceHeaders = new HashSet<ServiceHeaders>();
        }

        public long OrderId { get; set; }
        public string LocationCode { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string AccountNumber { get; set; }
        public string SoftwareOrdered { get; set; }
        public string ExternalVendorReferenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Customers> Customers { get; set; }
        public ICollection<HistoricalServiceHeaders> HistoricalServiceHeaders { get; set; }
        public ICollection<LineItems> LineItems { get; set; }
        public ICollection<ServiceHeaders> ServiceHeaders { get; set; }
    }
}
