// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalPricePlanPackages.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Price Plan Packages model class
    /// </summary>
    public class HistoricalPricePlanPackages
    {
        public long HistoricalPricePlanPackageId { get; set; }
        public long PricePlanPackageId { get; set; }
        public long LineItemId { get; set; }
        public string Pppid { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string Ppptype { get; set; }
        public string UnitType { get; set; }
        public decimal Units { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? HistoricalPricePlanPackagesCreatedDate { get; set; }
    }
}
