// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalServiceHeaders.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Historical Service Headers model class
    /// </summary>
    public class HistoricalServiceHeaders
    {
        public long HistoricalServiceHeaderId { get; set; }
        public long ServiceHeaderId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ClientApplicationName { get; set; }
        public string ClientApplicationUserName { get; set; }
        public string ServiceName { get; set; }
        public string ServiceAction { get; set; }
        public string ApplicationResponseCode { get; set; }
        public string ApplicationResponseClass { get; set; }
        public string ApplicationResponseMessage { get; set; }
        public string ApplicationResponseDetails { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string LoggingId { get; set; }
        public long? OrderId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalServiceHeaderCreatedDate { get; set; }

        public Orders Order { get; set; }
        public ServiceHeaders ServiceHeader { get; set; }
    }
}
