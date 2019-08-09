// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-24-2019
// ***********************************************************************
// <copyright file="BuSSFinanceRepository.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSSCM;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM;

    /// <summary>
    /// This is the repository that inherits from IBuss and makes the calls to the database stored procedures
    /// </summary>
    internal class BuSSFinanceRepository : IBuSSFinanceRepository
    {
        /// <summary>
        /// gives access to the context custom models for BuSSSCM
        /// </summary>
        private BuSSSCMContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuSSFinanceRepository" /> class.
        /// </summary>
        /// <param name="context">the context object</param>
        public BuSSFinanceRepository(BuSSSCMContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Grabs an exception if the stored procedure doesn't work properly
        /// </summary>
        /// <returns>exception for BuSSCustomers</returns>
        List<BuSSCustomers> IBuSSFinanceRepository.GetBuSSCustomers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs an exception if the stored procedure doesn't work properly
        /// </summary>
        /// <param name="cartBillableItemId">Cart billable item ID from search form</param>
        /// <param name="customerNumber">Customer number from search form</param>
        /// <param name="confirmationId">Confirmation ID from search form</param>
        /// <param name="startDate">Start Date from search form</param>
        /// <param name="endDate">End Date from search form</param>
        /// <returns>exception for BuSSBillableItems</returns>
        IEnumerable<BuSSBillableItems> IBuSSFinanceRepository.SearchBillableItems(long cartBillableItemId, string customerNumber, string confirmationId, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// calls stored procedure to get customer list and populate the dropdown list in the search form
        /// </summary>
        /// <returns>List of customers</returns>
        internal List<BuSSCustomers> GetBuSSCustomers()
        {
            var buSSCustomers = this._context.BuSSCustomers.FromSql("execute GetBuSSCustomers").OrderBy(name => name.CustomerName).ToList();
            return buSSCustomers;
        }

        /// <summary>
        /// This grabs parameters from the search form and then returns the data to display in the index page
        /// </summary>
        /// <param name="cartBillableItemId">Cart billable item ID from search form</param>
        /// <param name="customerNumber">Customer number from search form</param>
        /// <param name="confirmationId">Confirmation ID from search form</param>
        /// <param name="startDate">Start Date from search form</param>
        /// <param name="endDate">End Date from search form</param>
        /// <returns>based on the search parameters returns the cart billable items that fit the criteria</returns>
        internal IEnumerable<BuSSBillableItems> SearchBillableItems(long cartBillableItemId, string customerNumber, string confirmationId, DateTime? startDate, DateTime? endDate)
        {
            var buSSBillableItems = this._context.BuSSBillableItems.FromSql("execute spCartBillableItems_FilterCartItems @p0, @p1, @p2, @p3, @p4", cartBillableItemId, customerNumber, confirmationId, startDate, endDate).ToList();
            return buSSBillableItems;
        }
    }
}
