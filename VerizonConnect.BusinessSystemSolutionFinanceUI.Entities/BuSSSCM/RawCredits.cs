// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawCredits.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Credits model class
    /// </summary>
    public class RawCredits
    {
        public RawCredits()
        {
            RawCreditResponses = new HashSet<RawCreditResponses>();
        }

        public long RawCreditId { get; set; }
        public string RawCreditText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawCreditResponses> RawCreditResponses { get; set; }
    }
}
