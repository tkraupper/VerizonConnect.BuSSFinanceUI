// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="CartBillableItems.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Cart Billable Items model class
    /// </summary>
    public class CartBillableItems
    {
        public CartBillableItems()
        {
            CancelPurchaseResponses = new HashSet<CancelPurchaseResponses>();
        }

        [DisplayName("Cart Billable Item ID")]
        public long CartBillableItemId { get; set; }

        [DisplayName("Cart Order ID")]
        public long CartOrderId { get; set; }

        [DisplayName("SCM Order ID")]
        public long? ScmorderId { get; set; }

        [DisplayName("IOT Order ID")]
        public long? IotorderId { get; set; }

        [DisplayName("EO Order ID")]
        public int? Eoorderid { get; set; }

        [DisplayName("Order Source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// This is the salesforce opportunity ID that represents anytime there is a possible sale
        /// </summary>
        [DisplayName("Salesforce Opportunity ID")]
        [Column("SfdcopportunityId")]
        public string SalesforceOpportunityId { get; set; }

        [DisplayName("Confirmation ID")]
        public string ConfirmationId { get; set; }

        [DisplayName("Verizon Wireless Order Number")]
        public string VzworderNumber { get; set; }

        [DisplayName("Verizon Wireless Location Code")]
        public string VzwlocationCode { get; set; }

        [DisplayName("Sequence Number")]
        public int SequenceNumber { get; set; }

        [DisplayName("Bill Start Date")]
        public DateTime? BillStartDate { get; set; }

        [DisplayName("Bill End Date")]
        public DateTime? BillEndDate { get; set; }

        [DisplayName("Customer PO Number")]
        public string Cstponbr { get; set; }

        [DisplayName("Line Item Sequence Number")]
        public int Lnitmseq { get; set; }

        [DisplayName("Item Number")]
        public string Itemnmbr { get; set; }

        [DisplayName("Unit Price")]
        public decimal Unitprce { get; set; }

        [DisplayName("Billing Address #1")]
        public string BillAddress1 { get; set; }

        [DisplayName("Billing Address #2")]
        public string BillAddress2 { get; set; }

        [DisplayName("City")]
        public string BillCity { get; set; }

        [DisplayName("State")]
        public string BillState { get; set; }

        [DisplayName("ZIP Code")]
        public string BillZipcode { get; set; }

        [DisplayName("Country")]
        public string BillCountry { get; set; }

        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }

        [DisplayName("Quantity to Inventory")]
        public decimal Qtytoinv { get; set; }

        //[DisplayName("????")]
        public string Itmclscd { get; set; }

        [DisplayName("Item Desctiption")]
        public string Itemdesc { get; set; }

        //[DisplayName("????")]
        public string ItmclscdlistDescription { get; set; }

        //[DisplayName("????")]
        public string Serltnum { get; set; }

        //[DisplayName("????")]
        public decimal? Serltqty { get; set; }

        [DisplayName("Tax Amount")]
        public decimal TaxAmt { get; set; }

        [DisplayName("Debit Amount")]
        public decimal? Debitamt { get; set; }

        [DisplayName("Line Item Tax Amount")]
        public decimal LineItemTax { get; set; }

        [DisplayName("Row Number")]
        public int RowNumber { get; set; }

        [DisplayName("Tax Address #1")]
        public string TaxAddress1 { get; set; }

        [DisplayName("Tax Address #2")]
        public string TaxAddress2 { get; set; }

        [DisplayName("City")]
        public string TaxCity { get; set; }

        [DisplayName("State")]
        public string TaxState { get; set; }

        [DisplayName("ZIP Code")]
        public string TaxZipcode { get; set; }

        [DisplayName("Country")]
        public string TaxCountry { get; set; }

        [DisplayName("State Tax")]
        public decimal StateTax { get; set; }

        [DisplayName("Federal Tax")]
        public decimal FederalTax { get; set; }

        [DisplayName("Verizon Wireless Multiline Sequence Number")]
        public string VzwmultilineSequenceNumber { get; set; }

        [DisplayName("Verizon Wireless Fullfillment ID")]
        public string VzwfulfillmentId { get; set; }

        [DisplayName("First Name")]
        public string VzwfirstName { get; set; }

        [DisplayName("Middle Name")]
        public string VzwmiddleName { get; set; }

        [DisplayName("Last Name")]
        public string VzwlastName { get; set; }

        [DisplayName("Phone Number")]
        public string Vzwphone { get; set; }

        [DisplayName("Email Address")]
        public string VzwemailAddress { get; set; }

        [DisplayName("Verizon Wireless Contact Type")]
        public string VzwcontactType { get; set; }

        [DisplayName("Device Type")]
        public string DeviceType { get; set; }

        [DisplayName("VIN Number")]
        public string Vin { get; set; }

        [DisplayName("Device Label")]
        public string DeviceLabel { get; set; }

        [DisplayName("Fleet Name")]
        public string FleetName { get; set; }

        [DisplayName("Vehicle Label")]
        public string VehicleLabel { get; set; }

        [DisplayName("User Defined Labels")]
        public string UserDefinedLabels { get; set; }

        [DisplayName("Seller Name")]
        [Column("Sllrname")]
        public string SellerName { get; set; }

        [DisplayName("Seller Key")]
        [Column("Sllrkey")]
        public decimal? SellerKey { get; set; }

        [DisplayName("Model Type")]
        public string ModelType { get; set; }

        [DisplayName("Purchase Item Name")]
        public string PurchaseItemName { get; set; }

        [DisplayName("Billable")]
        public string Billable { get; set; }

        [DisplayName("Billable PO Box")]
        public string BillToPo { get; set; }

        [DisplayName("Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [DisplayName("PPP Type")]
        public string Ppptype { get; set; }

        [DisplayName("Unit Type")]
        public string UnitType { get; set; }

        [DisplayName("Units")]
        public decimal Units { get; set; }

        [DisplayName("Action")]
        public string Action { get; set; }

        [DisplayName("Source")]
        public string Source { get; set; }

        //[DisplayName("????")]
        public long? Crdrid { get; set; }

        [DisplayName("Vehicle ID")]
        public decimal? Vehid { get; set; }

        [DisplayName("License Plate")]
        public string LicensePlate { get; set; }

        [DisplayName("Year")]
        public decimal? Year { get; set; }

        [DisplayName("Make")]
        public string Makename { get; set; }

        [DisplayName("Model")]
        public string Modelname { get; set; }

        [DisplayName("Is Deleted")]
        public bool IsDeleted { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Purchase Item Status")]
        public long? SubmitPurchaseItemStatusId { get; set; }

        public CartOrders CartOrder { get; set; }
        public Orders Scmorder { get; set; }
        public SubmitPurchaseItemStatuses SubmitPurchaseItemStatus { get; set; }
        public ICollection<CancelPurchaseResponses> CancelPurchaseResponses { get; set; }
    }
}
