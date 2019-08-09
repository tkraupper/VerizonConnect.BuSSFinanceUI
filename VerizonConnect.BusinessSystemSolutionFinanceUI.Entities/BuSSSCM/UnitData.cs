// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="UnitData.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Unit Data model class
    /// </summary>
    public class UnitData
    {
        public UnitData()
        {
            CartUnitData = new HashSet<CartUnitData>();
        }

        public long UnitDatumId { get; set; }
        public long LineItemId { get; set; }
        public string UnitType { get; set; }
        public decimal? Units { get; set; }
        public string Action { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public LineItems LineItem { get; set; }
        public ICollection<CartUnitData> CartUnitData { get; set; }
    }
}
