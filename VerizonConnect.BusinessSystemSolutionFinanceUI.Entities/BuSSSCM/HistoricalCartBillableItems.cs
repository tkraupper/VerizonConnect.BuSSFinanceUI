// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="HistoricalCartBillableItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;

    /// <summary>
    /// Historical Cart Billable Items model class
    /// </summary>
    public class HistoricalCartBillableItems
    {
        public long HistoricalCartBillableItemId { get; set; }
        public long? CartBillableItemId { get; set; }
        public long CartOrderId { get; set; }
        public long? ScmorderId { get; set; }
        public long? IotorderId { get; set; }
        public int? Eoorderid { get; set; }
        public string OrderSource { get; set; }
        public string SfdcopportunityId { get; set; }
        public string ConfirmationId { get; set; }
        public string VzworderNumber { get; set; }
        public string VzwlocationCode { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime? BillStartDate { get; set; }
        public DateTime? BillEndDate { get; set; }
        public string Cstponbr { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; }
        public decimal Unitprce { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillZipcode { get; set; }
        public string BillCountry { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtytoinv { get; set; }
        public string Itmclscd { get; set; }
        public string Itemdesc { get; set; }
        public string ItmclscdlistDescription { get; set; }
        public string Serltnum { get; set; }
        public decimal? Serltqty { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal? Debitamt { get; set; }
        public decimal LineItemTax { get; set; }
        public int RowNumber { get; set; }
        public string TaxAddress1 { get; set; }
        public string TaxAddress2 { get; set; }
        public string TaxCity { get; set; }
        public string TaxState { get; set; }
        public string TaxZipcode { get; set; }
        public string TaxCountry { get; set; }
        public decimal StateTax { get; set; }
        public decimal FederalTax { get; set; }
        public string VzwmultilineSequenceNumber { get; set; }
        public string VzwfulfillmentId { get; set; }
        public string VzwfirstName { get; set; }
        public string VzwmiddleName { get; set; }
        public string VzwlastName { get; set; }
        public string Vzwphone { get; set; }
        public string VzwemailAddress { get; set; }
        public string VzwcontactType { get; set; }
        public string DeviceType { get; set; }
        public string Vin { get; set; }
        public string DeviceLabel { get; set; }
        public string FleetName { get; set; }
        public string VehicleLabel { get; set; }
        public string UserDefinedLabels { get; set; }
        public string Sllrname { get; set; }
        public decimal? Sllrkey { get; set; }
        public string ModelType { get; set; }
        public string PurchaseItemName { get; set; }
        public string Billable { get; set; }
        public string BillToPo { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Ppptype { get; set; }
        public string UnitType { get; set; }
        public decimal Units { get; set; }
        public string Action { get; set; }
        public string Source { get; set; }
        public long? Crdrid { get; set; }
        public decimal? Vehid { get; set; }
        public string LicensePlate { get; set; }
        public decimal? Year { get; set; }
        public string Makename { get; set; }
        public string Modelname { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime HistoricalCreatedDate { get; set; }
    }
}
