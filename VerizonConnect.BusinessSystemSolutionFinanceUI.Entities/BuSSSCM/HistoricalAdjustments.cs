// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalAdjustments.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Adjustments model class
    /// </summary>
    public class HistoricalAdjustments
    {
        public long HistoricalAdjustmentId { get; set; }
        public long AdjustmentId { get; set; }
        public long CancelId { get; set; }
        public decimal Amount { get; set; }
        public int Reason { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime HistoricalCreatedDate { get; set; }
    }
}
