// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="SubmitPurchaseOrderStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Submit Purchase Order Statuses model class
    /// </summary>
    public class SubmitPurchaseOrderStatuses
    {
        public SubmitPurchaseOrderStatuses()
        {
            SubmitPurchaseItemStatuses = new HashSet<SubmitPurchaseItemStatuses>();
            SubmitPurchaseMessageStatuses = new HashSet<SubmitPurchaseMessageStatuses>();
        }

        public long SubmitPurchaseOrderStatusId { get; set; }
        public long? SubmitPurchaseOrderId { get; set; }
        public string OrderId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? CartOrderStatusId { get; set; }

        public ICollection<SubmitPurchaseItemStatuses> SubmitPurchaseItemStatuses { get; set; }
        public ICollection<SubmitPurchaseMessageStatuses> SubmitPurchaseMessageStatuses { get; set; }
    }
}
