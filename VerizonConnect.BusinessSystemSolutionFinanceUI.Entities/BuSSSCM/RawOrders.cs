// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawOrders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Orders model class
    /// </summary>
    public class RawOrders
    {
        public RawOrders()
        {
            RawOrderResponses = new HashSet<RawOrderResponses>();
        }

        public long RawOrderId { get; set; }
        public string RawOrderText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawOrderResponses> RawOrderResponses { get; set; }
    }
}
