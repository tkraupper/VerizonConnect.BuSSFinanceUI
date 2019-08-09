// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CancelPurchaseAdjustmentResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cancel Purchase Adjustment Responses model class
    /// </summary>
    public class CancelPurchaseAdjustmentResponses
    {
        public long CancelPurchaseAdjustmentResponseId { get; set; }
        public long? CancelPurchaseResponseId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CancelPurchaseResponses CancelPurchaseResponse { get; set; }
    }
}
