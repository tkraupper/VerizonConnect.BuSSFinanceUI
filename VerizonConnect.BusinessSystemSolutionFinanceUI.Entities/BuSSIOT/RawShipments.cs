// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="RawShipments.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Raw Shipments model class
    /// </summary>
    public class RawShipments
    {
        public RawShipments()
        {
            RawShipmentResponses = new HashSet<RawShipmentResponses>();
        }

        public long RawShipmentId { get; set; }
        public string RawShipmentText { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<RawShipmentResponses> RawShipmentResponses { get; set; }
    }
}
