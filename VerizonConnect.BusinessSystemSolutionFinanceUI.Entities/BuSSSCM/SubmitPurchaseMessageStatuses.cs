// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="SubmitPurchaseMessageStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Submit Purchase Message Statuses model class
    /// </summary>
    public class SubmitPurchaseMessageStatuses
    {
        public long SubmitPurchaseMessageStatusId { get; set; }
        public long SubmitPurchaseOrderStatusId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public SubmitPurchaseOrderStatuses SubmitPurchaseOrderStatus { get; set; }
    }
}
