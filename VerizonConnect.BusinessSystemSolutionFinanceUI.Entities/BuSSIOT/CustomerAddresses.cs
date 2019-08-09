// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CustomerAddresses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Customer Addresses model class
    /// </summary>
    public class CustomerAddresses
    {
        public long CustomerAddressId { get; set; }
        public long CustomerId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipCode4 { get; set; }
        public string Country { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public Customers Customer { get; set; }
    }
}
