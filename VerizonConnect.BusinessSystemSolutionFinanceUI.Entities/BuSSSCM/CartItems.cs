// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cart Items model class
    /// </summary>
    public class CartItems
    {
        public CartItems()
        {
            CartPricePlanPackages = new HashSet<CartPricePlanPackages>();
        }

        public long CartItemId { get; set; }
        public long CartLineItemId { get; set; }
        public string VendorId { get; set; }
        public string ContentId { get; set; }
        public string ContentType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CartPricePlanPackages> CartPricePlanPackages { get; set; }
    }
}
