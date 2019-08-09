// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawOrderResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Raw Order Responses model class
    /// </summary>
    public class RawOrderResponses
    {
        public long RawOrderResponseId { get; set; }
        public long? RawOrderId { get; set; }
        public string RawOrderResponseText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public RawOrders RawOrder { get; set; }
    }
}
