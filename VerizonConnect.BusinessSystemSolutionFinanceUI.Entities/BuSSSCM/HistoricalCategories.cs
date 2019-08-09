// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalCategories.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Categories model class
    /// </summary>
    public class HistoricalCategories
    {
        public long HistoricalCategoryId { get; set; }
        public long CategoryId { get; set; }
        public long LineItemId { get; set; }
        public string McscategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BundleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalCategoriesCreatedDate { get; set; }
    }
}
