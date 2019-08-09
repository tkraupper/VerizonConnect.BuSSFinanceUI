// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartItemStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cart Item Statuses model class
    /// </summary>
    public class CartItemStatuses
    {
        public CartItemStatuses()
        {
            CartPricePlanPackageStatuses = new HashSet<CartPricePlanPackageStatuses>();
        }

        public long CartItemStatusId { get; set; }
        public long CartLineItemStatusId { get; set; }
        public string McsitemId { get; set; }
        public string ItemName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartLineItemStatuses CartLineItemStatus { get; set; }
        public ICollection<CartPricePlanPackageStatuses> CartPricePlanPackageStatuses { get; set; }
    }
}
