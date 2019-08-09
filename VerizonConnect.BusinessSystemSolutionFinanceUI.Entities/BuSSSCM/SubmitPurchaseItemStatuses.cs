// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="SubmitPurchaseItemStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Submit Purchase Item Statuses model class
    /// </summary>
    public class SubmitPurchaseItemStatuses
    {
        public SubmitPurchaseItemStatuses()
        {
            CartBillableItems = new HashSet<CartBillableItems>();
        }

        public long SubmitPurchaseItemStatusId { get; set; }
        public long? SubmitPurchaseOrderStatusId { get; set; }
        public string TransactionId { get; set; }
        public int SequenceNumber { get; set; }
        public string ItemName { get; set; }
        public string McsitemId { get; set; }
        public string ContentType { get; set; }
        public string DownloadUrl { get; set; }
        public string LicenseUrl { get; set; }
        public string FulfillmentId { get; set; }
        public string ContentMimeType { get; set; }
        public string ContentSize { get; set; }
        public string CollectionType { get; set; }
        public string ContentId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CartLineItemId { get; set; }

        public SubmitPurchaseOrderStatuses SubmitPurchaseOrderStatus { get; set; }
        public ICollection<CartBillableItems> CartBillableItems { get; set; }
    }
}
