// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="BuSSBillableItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This is the class that matches the data returned by the search form for BuSSBillableItems
    /// </summary>
    public class BuSSBillableItems
    {
        /// <summary>
        /// Unique identifier for Cart Billable Item
        /// </summary>
        [DisplayName("Cart Item ID")]
        [Key]
        public Int64 CartBillableItemId { get; set; }

        /// <summary>
        /// Unique identifier for the customer
        /// </summary>
        [DisplayName("Customer Number")]
        [Column("Custnmbr")]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// The customer name
        /// </summary>
        [DisplayName("Customer Name")]
        [Column("Custname")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Confirmation ID associated with an order
        /// </summary>
        [DisplayName("Confirmation ID")]
        public string ConfirmationId { get; set; }

        /// <summary>
        /// Start date of billing
        /// </summary>
        [DisplayName("Billing Start Date")]
        public DateTime? BillStartDate { get; set; }

        /// <summary>
        /// End date of billing
        /// </summary>
        [DisplayName("Billing End Date")]
        public DateTime? BillEndDate { get; set; }
    }
}
