// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Items model class
    /// </summary>
    public class HistoricalItems
    {
        public long HistoricalItemId { get; set; }
        public long ItemId { get; set; }
        public long LineItemId { get; set; }
        public string VendorId { get; set; }
        public string ContentId { get; set; }
        public string ContentType { get; set; }
        public string ItemName { get; set; }
        public string McsitemId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? HistoricalItemsCreatedDate { get; set; }
    }
}
