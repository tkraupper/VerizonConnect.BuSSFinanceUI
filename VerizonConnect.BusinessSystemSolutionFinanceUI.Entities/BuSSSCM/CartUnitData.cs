// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartUnitData.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cart Unit Data model class
    /// </summary>
    public class CartUnitData
    {
        public long CartUnitDatumId { get; set; }
        public long CartLineItemId { get; set; }
        public string UnitType { get; set; }
        public decimal Units { get; set; }
        public string Action { get; set; }
        public long? UnitDatumId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartLineItems CartLineItem { get; set; }
        public UnitData UnitDatum { get; set; }
    }
}
