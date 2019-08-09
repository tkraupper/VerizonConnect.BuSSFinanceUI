// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="PricePlanPackages.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Price Plan Packages model class
    /// </summary>
    public class PricePlanPackages
    {
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

        public LineItems LineItem { get; set; }
    }
}
