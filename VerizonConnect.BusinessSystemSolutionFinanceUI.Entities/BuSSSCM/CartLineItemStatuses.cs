// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartLineItemStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cart Line Item Statuses model class
    /// </summary>
    public class CartLineItemStatuses
    {
        public CartLineItemStatuses()
        {
            CartItemStatuses = new HashSet<CartItemStatuses>();
            CartLineItemMessageStatuses = new HashSet<CartLineItemMessageStatuses>();
        }

        public long CartLineItemStatusId { get; set; }
        public int? SequenceNumber { get; set; }
        public long CartOrderStatusId { get; set; }
        public string CartLineItemId { get; set; }
        public decimal CheckoutPrice { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DestinationAccountReference { get; set; }

        public CartOrderStatuses CartOrderStatus { get; set; }
        public ICollection<CartItemStatuses> CartItemStatuses { get; set; }
        public ICollection<CartLineItemMessageStatuses> CartLineItemMessageStatuses { get; set; }
    }
}
