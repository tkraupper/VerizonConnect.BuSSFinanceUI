// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartLineItemMessageStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cart Line Item Message Statuses model class
    /// </summary>
    public class CartLineItemMessageStatuses
    {
        public long CartLineItemMessageStatusId { get; set; }
        public long CartLineItemStatusId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartLineItemStatuses CartLineItemStatus { get; set; }
    }
}
