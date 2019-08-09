// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawPurchases.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Purchases model class
    /// </summary>
    public class RawPurchases
    {
        public RawPurchases()
        {
            RawPurchaseResponses = new HashSet<RawPurchaseResponses>();
        }

        public long RawPurchaseId { get; set; }
        public string RawPurchaseText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RawPurchaseXml { get; set; }

        public ICollection<RawPurchaseResponses> RawPurchaseResponses { get; set; }
    }
}
