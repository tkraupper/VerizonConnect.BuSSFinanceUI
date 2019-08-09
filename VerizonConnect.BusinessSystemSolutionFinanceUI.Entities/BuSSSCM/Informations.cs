// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Informations.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Informations model class
    /// </summary>
    public class Informations
    {
        public long InformationId { get; set; }
        public long LineItemId { get; set; }
        public string Name { get; set; }
        public string StringValue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public LineItems LineItem { get; set; }
    }
}
