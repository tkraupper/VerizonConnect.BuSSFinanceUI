// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawNotifications.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Notifications model class
    /// </summary>
    public class RawNotifications
    {
        public RawNotifications()
        {
            RawNotificationResponses = new HashSet<RawNotificationResponses>();
        }

        public long RawNotificationId { get; set; }
        public string RawNotificationText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawNotificationResponses> RawNotificationResponses { get; set; }
    }
}
