// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="OrdersSerialNumbers.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Orders Serial Numbers model class
    /// </summary>
    public class OrdersSerialNumbers
    {
        public long OrderSerialNumberId { get; set; }
        public string ConfirmationId { get; set; }
        public string OrderNumber { get; set; }
        public string LocationCode { get; set; }
        public string SfdcopportunityId { get; set; }
        public string Serltnum { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public Orders Confirmation { get; set; }
    }
}
