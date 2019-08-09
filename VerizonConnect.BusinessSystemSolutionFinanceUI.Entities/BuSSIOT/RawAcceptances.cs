// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawAcceptances.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Acceptances model class
    /// </summary>
    public class RawAcceptances
    {
        public RawAcceptances()
        {
            RawAcceptanceResponses = new HashSet<RawAcceptanceResponses>();
        }

        public long RawAcceptanceId { get; set; }
        public string RawAcceptanceText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<RawAcceptanceResponses> RawAcceptanceResponses { get; set; }
    }
}
