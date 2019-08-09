// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Orders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Orders model class
    /// </summary>
    public class Orders
    {
        public Orders()
        {
            CartBillableItems = new HashSet<CartBillableItems>();
            LineItems = new HashSet<LineItems>();
            OrderStatuses = new HashSet<OrderStatuses>();
            OrdersSerialNumbers = new HashSet<OrdersSerialNumbers>();
        }

        public long OrderId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ConfirmationId { get; set; }
        public string AccountReference { get; set; }
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CartBillableItems> CartBillableItems { get; set; }
        public ICollection<LineItems> LineItems { get; set; }
        public ICollection<OrderStatuses> OrderStatuses { get; set; }
        public ICollection<OrdersSerialNumbers> OrdersSerialNumbers { get; set; }
    }
}
