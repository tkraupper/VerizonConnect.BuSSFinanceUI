// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="BuSSCustomers.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This is the custom class to fit the data returned from the query for the customers that will populate the dropdown list
    /// </summary>
    public class BuSSCustomers
    {
        /// <summary>
        /// This is the unique identifier for the customer
        /// </summary>
        [DisplayName("Customer Number")]
        [Column("Custnmbr")]
        [Key]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Customer name text displayed in the dropdown list
        /// </summary>
        [DisplayName("Customer Name")]
        [Column("Custname")]
        public string CustomerName { get; set; }
    }
}
