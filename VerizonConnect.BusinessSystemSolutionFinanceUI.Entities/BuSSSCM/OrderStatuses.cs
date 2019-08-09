// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="OrderStatuses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Order Statuses model class
    /// </summary>
    public class OrderStatuses
    {
        public long OrderStatusId { get; set; }
        public long OrderId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public long OrderStatusTypeValueId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAutoAccepted { get; set; }

        public Orders Order { get; set; }
    }
}
