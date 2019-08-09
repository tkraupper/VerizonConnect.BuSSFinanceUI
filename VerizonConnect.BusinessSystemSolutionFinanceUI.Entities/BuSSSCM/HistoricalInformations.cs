// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalInformations.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Information model class
    /// </summary>
    public class HistoricalInformations
    {
        public long HistoricalInformationId { get; set; }
        public long InformationId { get; set; }
        public long LineItemId { get; set; }
        public string Name { get; set; }
        public string StringValue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalInformationsCreatedDate { get; set; }
    }
}
