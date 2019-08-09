// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CancelPurchaseResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cancel Purchase Responses model class
    /// </summary>
    public class CancelPurchaseResponses
    {
        public CancelPurchaseResponses()
        {
            CancelPurchaseAdjustmentResponses = new HashSet<CancelPurchaseAdjustmentResponses>();
        }

        public long CancelPurchaseResponseId { get; set; }
        public long? CartOrderId { get; set; }
        public long? CartBillableItemId { get; set; }
        public int RecordId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartBillableItems CartBillableItem { get; set; }
        public CartOrders CartOrder { get; set; }
        public ICollection<CancelPurchaseAdjustmentResponses> CancelPurchaseAdjustmentResponses { get; set; }
    }
}
