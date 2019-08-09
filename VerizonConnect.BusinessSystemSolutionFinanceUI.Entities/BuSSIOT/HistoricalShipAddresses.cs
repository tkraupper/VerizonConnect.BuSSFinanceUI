// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalShipAddresses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Ship Addresses model class
    /// </summary>
    public class HistoricalShipAddresses
    {
        public long HistoricalShipAddressId { get; set; }
        public long ShipAddressId { get; set; }
        public long LineItemId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirmName { get; set; }
        public string ApartmentNumber { get; set; }
        public string Attention { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
        public string AddressLine2 { get; set; }
        public string Pobox { get; set; }
        public string RuralRoute { get; set; }
        public string RuralDelivery { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipCode4 { get; set; }
        public string Country { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalShipAddressesCreatedDate { get; set; }
    }
}
