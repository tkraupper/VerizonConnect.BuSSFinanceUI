// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartOrderCreditsCartOrders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Cart Order Credits Cart Orders model class
    /// </summary>
    public class CartOrderCreditsCartOrders
    {
        public long CartOrderCreditCartOrderId { get; set; }
        public long CartOrderIdCredit { get; set; }
        public long CartOrderId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public CartOrders CartOrder { get; set; }
        public CartOrders CartOrderIdCreditNavigation { get; set; }
    }
}
