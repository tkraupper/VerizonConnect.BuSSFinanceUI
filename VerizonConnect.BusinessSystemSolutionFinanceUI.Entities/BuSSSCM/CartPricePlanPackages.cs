// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartPricePlanPackages.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cart Price Plan Packages model class
    /// </summary>
    public class CartPricePlanPackages
    {
        public long CartPricePlanPackageId { get; set; }
        public long CartItemId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string Ppptype { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartItems CartItem { get; set; }
    }
}
