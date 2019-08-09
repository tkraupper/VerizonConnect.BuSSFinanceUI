// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="IBuSSFinanceRepository.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Repository
{
    using System;
    using System.Collections.Generic;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM;

    /// <summary>
    /// Declares the variables for the BuSSFinanceRepository 
    /// </summary>
    internal interface IBuSSFinanceRepository
    {
        /// <summary>
        /// Method for getting the list of customers from the stored procedure in the database
        /// </summary>
        /// <returns>List of customers</returns>
        List<BuSSCustomers> GetBuSSCustomers();

        /// <summary>
        /// This calls the stored procedure in the database collecting data from the search form and then displays the information in the index page
        /// </summary>
        /// <param name="cartBillableItemId">Cart billable item ID from search form</param>
        /// <param name="customerNumber">Customer number from search form</param>
        /// <param name="confirmationId">Confirmation ID from search form</param>
        /// <param name="startDate">Start Date from search form</param>
        /// <param name="endDate">End Date from search form</param>
        /// <returns>List of cart billable items matching the search criteria</returns>
        IEnumerable<BuSSBillableItems> SearchBillableItems(long cartBillableItemId, string customerNumber, string confirmationId, DateTime? startDate, DateTime? endDate);
    }
}
