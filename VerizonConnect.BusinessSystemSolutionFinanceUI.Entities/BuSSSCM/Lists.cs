// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Lists.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lists model class
    /// </summary>
    public class Lists
    {
        public Lists()
        {
            InverseListParent = new HashSet<Lists>();
        }

        public int ListId { get; set; }
        public string ListName { get; set; }
        public string ListText { get; set; }
        public long ListValue { get; set; }
        public string ListDescription { get; set; }
        public int? ListParentId { get; set; }
        public int ListOrder { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }

        public Lists ListParent { get; set; }
        public ICollection<Lists> InverseListParent { get; set; }
    }
}
