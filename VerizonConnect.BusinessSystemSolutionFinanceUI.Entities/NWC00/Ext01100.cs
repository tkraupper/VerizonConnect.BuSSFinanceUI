// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Ext01100.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.NWC00
{
    using System;

    /// <summary>
    /// Ext01100 model class
    /// </summary>
    public class Ext01100
    {
        public int ExtenderRecordId { get; set; }
        public string ExtenderWindowId { get; set; }
        public string ExtenderKeyValues1 { get; set; }
        public string ExtenderKeyValues2 { get; set; }
        public string ExtenderKeyValues3 { get; set; }
        public string ExtenderKeyValues4 { get; set; }
        public string ExtenderKeyValues5 { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; }
        public int DexRowId { get; set; }
    }
}
