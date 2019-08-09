// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawCancels.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Cancels model class
    /// </summary>
    public class RawCancels
    {
        public RawCancels()
        {
            RawCancelResponses = new HashSet<RawCancelResponses>();
        }

        public long RawCancelId { get; set; }
        public string RawCancelText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawCancelResponses> RawCancelResponses { get; set; }
    }
}
