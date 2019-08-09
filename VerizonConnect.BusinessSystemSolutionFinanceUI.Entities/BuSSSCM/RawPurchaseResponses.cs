// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawPurchaseResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Raw Purchase Responses model class
    /// </summary>
    public class RawPurchaseResponses
    {
        public long RawPurchaseResponseId { get; set; }
        public long? RawPurchaseId { get; set; }
        public string RawPurchaseResponseText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RawPurchaseResponseXml { get; set; }

        public RawPurchases RawPurchase { get; set; }
    }
}
