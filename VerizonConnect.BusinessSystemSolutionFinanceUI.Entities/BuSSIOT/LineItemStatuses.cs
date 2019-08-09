// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="LineItemStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Line Item Statuses model class
    /// </summary>
    public class LineItemStatuses
    {
        public long LineItemStatusId { get; set; }
        public long LineItemId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public long StatusTypeValueId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public LineItems LineItem { get; set; }
    }
}
