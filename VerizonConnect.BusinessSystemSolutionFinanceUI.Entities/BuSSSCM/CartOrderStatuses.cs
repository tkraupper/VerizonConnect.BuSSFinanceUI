// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartOrderStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cart Order Statuses model class
    /// </summary>
    public class CartOrderStatuses
    {
        public CartOrderStatuses()
        {
            CartLineItemStatuses = new HashSet<CartLineItemStatuses>();
            CartOrderMessageStatuses = new HashSet<CartOrderMessageStatuses>();
        }

        public long CartOrderStatusId { get; set; }
        public long CartOrderId { get; set; }
        public string ConfirmationId { get; set; }
        public decimal TotalCheckoutPrice { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SequenceNumber { get; set; }

        public ICollection<CartLineItemStatuses> CartLineItemStatuses { get; set; }
        public ICollection<CartOrderMessageStatuses> CartOrderMessageStatuses { get; set; }
    }
}
