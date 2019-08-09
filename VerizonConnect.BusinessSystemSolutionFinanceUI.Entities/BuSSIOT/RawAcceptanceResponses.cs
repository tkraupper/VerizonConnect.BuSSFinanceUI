// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawAcceptanceResponses.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;

    /// <summary>
    /// Raw Acceptance Responses model class
    /// </summary>
    public class RawAcceptanceResponses
    {
        public long RawAcceptanceResponseId { get; set; }
        public long? RawAcceptanceId { get; set; }
        public string RawAcceptanceResponseText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public RawAcceptances RawAcceptance { get; set; }
    }
}
