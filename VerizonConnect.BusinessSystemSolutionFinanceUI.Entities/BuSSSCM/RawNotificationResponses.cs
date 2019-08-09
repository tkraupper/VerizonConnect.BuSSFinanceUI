// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawNotificationResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Raw Notification Responses model class
    /// </summary>
    public class RawNotificationResponses
    {
        public long RawNotificationResponseId { get; set; }
        public long? RawNotificationId { get; set; }
        public string RawNotificationResponseText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public RawNotifications RawNotification { get; set; }
    }
}
