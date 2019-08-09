// ***********************************************************************
// Assembly : Verizonconnect.BusinessSystemSolutionFinanceUI
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="ErrorViewModel.cs" company="Verizon Connect">
// Verizon Connect
// </copyright>
//// ***********************************************************************

namespace VerizonConnect.BuSSFinanceUI.Models
{
    /// <summary>
    /// This is the Error View Model that is automatically generated and helps show error messages to users
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the Request ID
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Boolean variable to show if Request ID exists
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}