// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartOrders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Cart Orders model class
    /// </summary>
    public class CartOrders
    {
        public CartOrders()
        {
            CancelPurchaseResponses = new HashSet<CancelPurchaseResponses>();
            CartBillableItems = new HashSet<CartBillableItems>();
            CartOrderCreditsCartOrdersCartOrder = new HashSet<CartOrderCreditsCartOrders>();
            CartOrderCreditsCartOrdersCartOrderIdCreditNavigation = new HashSet<CartOrderCreditsCartOrders>();
            CreditMemos = new HashSet<CreditMemos>();
        }

        public long CartOrderId { get; set; }
        public DateTime CartTransactionDate { get; set; }

        [DisplayName("Customer Number")]
        public string Custnmbr { get; set; }

        [DisplayName("Customer Name")]
        public string Custname { get; set; }
        public string VzwcustomerNumber { get; set; }
        public string VzwaccountNumber { get; set; }
        public string Vzwecpdid { get; set; }
        public string AccountReference { get; set; }
        public string Ordocnum { get; set; }
        public short Soptype { get; set; }
        public DateTime Docdate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CancelPurchaseResponses> CancelPurchaseResponses { get; set; }
        public ICollection<CartBillableItems> CartBillableItems { get; set; }
        public ICollection<CartOrderCreditsCartOrders> CartOrderCreditsCartOrdersCartOrder { get; set; }
        public ICollection<CartOrderCreditsCartOrders> CartOrderCreditsCartOrdersCartOrderIdCreditNavigation { get; set; }
        public ICollection<CreditMemos> CreditMemos { get; set; }
    }
}
