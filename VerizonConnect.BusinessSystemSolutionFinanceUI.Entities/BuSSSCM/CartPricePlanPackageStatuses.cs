// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartPriceplanPackageStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cart Price Plan Package Statuses model class
    /// </summary>
    public class CartPricePlanPackageStatuses
    {
        public long CartPricePlanPackageStatusId { get; set; }
        public long CartItemStatusId { get; set; }
        public string Pppid { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartItemStatuses CartItemStatus { get; set; }
    }
}
