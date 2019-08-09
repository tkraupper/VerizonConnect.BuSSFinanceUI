// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalUnitData.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Unit Data model class
    /// </summary>
    public class HistoricalUnitData
    {
        public long HistoricalUnitDatumId { get; set; }
        public long UnitDatumId { get; set; }
        public long LineItemId { get; set; }
        public string UnitType { get; set; }
        public decimal? Units { get; set; }
        public string Action { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalUnitDataCreatedDate { get; set; }
    }
}
