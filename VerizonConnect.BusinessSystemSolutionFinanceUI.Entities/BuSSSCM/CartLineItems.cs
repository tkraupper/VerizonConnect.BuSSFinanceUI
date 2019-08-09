// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartLineItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cart Line Items model class
    /// </summary>
    public class CartLineItems
    {
        public CartLineItems()
        {
            CartInformations = new HashSet<CartInformations>();
            CartUnitData = new HashSet<CartUnitData>();
        }

        public long CartLineItemId { get; set; }
        public long CartOrderId { get; set; }
        public int SequenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CartInformations> CartInformations { get; set; }
        public ICollection<CartUnitData> CartUnitData { get; set; }
    }
}
