// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="BillingAddresses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Billing Addresses model class
    /// </summary>
    public class BillingAddresses
    {
        public long BillingAddressesId { get; set; }
        public string AccountNo { get; set; }
        public string AccountStatus { get; set; }
        public string ListCount { get; set; }
        public string BillAccountGroupId { get; set; }
        public string ActiveMtnQuantity { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string SuffixName { get; set; }
        public string CourtesyTitleCode { get; set; }
        public string BusinessName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string BillingSys { get; set; }
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ServiceName { get; set; }
        public string StatusCode { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public string WarningMsg { get; set; }
        public string CicsErrorCode { get; set; }
        public string ServerName { get; set; }
        public string CorrelationId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
