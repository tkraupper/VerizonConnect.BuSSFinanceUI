// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawCarts.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Carts model class
    /// </summary>
    public class RawCarts
    {
        public RawCarts()
        {
            RawCartResponses = new HashSet<RawCartResponses>();
        }

        public long RawCartId { get; set; }
        public string RawCartText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawCartResponses> RawCartResponses { get; set; }
    }
}
