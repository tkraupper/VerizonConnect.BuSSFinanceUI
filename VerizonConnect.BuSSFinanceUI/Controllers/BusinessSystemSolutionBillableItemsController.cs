// ***********************************************************************
// Assembly : VerizonConnect.BuSSFinanceUI
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-22-2019
// ***********************************************************************
// <copyright file="BusinessSystemSolutionBillableItemsController.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BussinessSystemSolutionFinanceUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSSCM;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Repository;

    /// <summary>
    /// This is the principal controller that handles pretty much everything with the logic in the project dealing with the app other than interactions in the Database which are handled in
    /// the repository and the context and entities projects
    /// </summary>
    public class BusinessSystemSolutionBillableItemsController : Controller
    {
        /// <summary>
        /// variable that instantiates all of the entity framework models
        /// </summary>
        private readonly BuSSSCMContext _context;

        /// <summary>
        /// Gives access to call functions in the repository (mainly calls to the database)
        /// </summary>
        private BuSSFinanceRepository _buSSFinanceRepository;

        /// <summary>
        /// Customer list that populates the dropdown on the search form
        /// </summary>
        private List<SelectListItem> _customerList = new List<SelectListItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessSystemSolutionBillableItemsController" /> class
        /// </summary>
        /// <param name="context">Context variable giving access to the models using Entity Framework Core</param>
        public BusinessSystemSolutionBillableItemsController(BuSSSCMContext context)
        {
            this._context = context;
            this._buSSFinanceRepository = new BuSSFinanceRepository(this._context);
        }

        /// <summary>
        /// Search method that either generates the search form or processes it
        /// </summary>
        /// <param name="cartBillableItemID">ID in search form</param>
        /// <param name="customerNumber">Dropdown list in search form</param>
        /// <param name="confirmationId">ID for an order</param>
        /// <param name="startDate">Start range of date wanting to be searched</param>
        /// <param name="endDate">End range of date wanting to be searched</param>
        /// <returns>either the form view of the index view with the resulting data</returns>
        public IActionResult Search(long cartBillableItemID, string customerNumber, string confirmationId, DateTime? startDate, DateTime? endDate)
        {
            startDate = startDate ?? new DateTime(2018, 10, 31);
            endDate = endDate ?? DateTime.Now;

            if (cartBillableItemID != 0 || !string.IsNullOrEmpty(customerNumber) || !string.IsNullOrEmpty(confirmationId))
            {
                this.TempData[nameof(cartBillableItemID)] = cartBillableItemID;
                this.TempData[nameof(customerNumber)] = customerNumber;
                this.TempData[nameof(confirmationId)] = confirmationId;
                this.TempData[nameof(startDate)] = startDate;
                this.TempData[nameof(endDate)] = endDate;

                // CALL TO STORED PROCEDURE TO RETRIEVE DATA FOR LIST
                var bussBillableItems = this._buSSFinanceRepository.SearchBillableItems(Convert.ToInt64(cartBillableItemID), customerNumber, confirmationId, startDate, endDate);

                return this.View(nameof(this.Index), bussBillableItems);
            }

            // Generate customer list. Add null for first value and generate select list with text and value behind the text
            var customers = this._buSSFinanceRepository.GetBuSSCustomers();
            this._customerList.Add(new SelectListItem() { Value = null, Text = "Select One" });

            for (int i = 0; i < customers.Count(); i++)
            {
                this._customerList.Add(new SelectListItem(customers[i].CustomerName, customers[i].CustomerNumber));
            }

            ViewBag.customerList = this._customerList;

            return this.View(nameof(this.Search));
        }

        /// <summary>
        /// This method is the method that will take all the resulting data and print it out into a list
        /// </summary>
        /// <param name="cartBillableItemID">ID in search form</param>
        /// <param name="customerNumber">Dropdown list in search form</param>
        /// <param name="confirmationId">ID for an order</param>
        /// <param name="startDate">Start range of date wanting to be searched</param>
        /// <param name="endDate">End range of date wanting to be searched</param>
        /// <returns>Index view with the list of items</returns>
        public IActionResult Index(long cartBillableItemID, string customerNumber, string confirmationId, DateTime? startDate, DateTime? endDate)
        {
            cartBillableItemID = Convert.ToInt64(this.TempData[nameof(cartBillableItemID)]);
            customerNumber = this.TempData[nameof(customerNumber)].ToString();
            if (confirmationId != null)
            {
                confirmationId = this.TempData[nameof(confirmationId)].ToString();
            }
            startDate = Convert.ToDateTime(this.TempData[nameof(startDate)]);
            endDate = Convert.ToDateTime(this.TempData[nameof(endDate)]);

            // Rerun query to show index page with same results
            var bussBillableItems = this._buSSFinanceRepository.SearchBillableItems(Convert.ToInt64(cartBillableItemID), customerNumber, confirmationId, startDate, endDate);

            return this.View(nameof(this.Index), bussBillableItems);
        }

        /// <summary>
        /// This method receives an ID 
        /// </summary>
        /// <param name="id">The unique identifier for the item</param>
        /// <returns>Details view with the specific item with all of the details on that item</returns>
        public async Task<IActionResult> DetailsAsync(long? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var cartBillableItems = await this._context.CartBillableItems
                .Include(c => c.CartOrder)
                .Include(c => c.Scmorder)
                .Include(c => c.SubmitPurchaseItemStatus)
                .FirstOrDefaultAsync(m => m.CartBillableItemId == id);
            if (cartBillableItems == null)
            {
                return this.NotFound();
            }

            return this.View("Details", cartBillableItems);
        }

        /// <summary>
        /// This method can create new cart billable items (Not sure yet if this functionality is required or not but the button)
        /// </summary>
        /// <returns>Creates an object and returns the view</returns>
        public IActionResult Create()
        {
            this.ViewData["CartOrderId"] = new SelectList(this._context.CartOrders, "CartOrderId", "Ordocnum");
            this.ViewData["ScmorderId"] = new SelectList(this._context.Orders, "OrderId", "ConfirmationId");
            this.ViewData["SubmitPurchaseItemStatusId"] = new SelectList(this._context.SubmitPurchaseItemStatuses, "SubmitPurchaseItemStatusId", "ContentId");
            return this.View();
        }

        /// <summary>
        /// This method can create new cart billable items (Not sure yet if this functionality is required or not but the button)
        /// </summary>
        /// <param name="cartBillableItems">The Cart Billable Item that is created</param>
        /// <returns>The view with the details of the new created item</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync([Bind("CartBillableItemId,CartOrderId,ScmorderId,IotorderId,Eoorderid,OrderSource,SfdcopportunityId,ConfirmationId,VzworderNumber,VzwlocationCode,SequenceNumber,BillStartDate,BillEndDate,Cstponbr,Lnitmseq,Itemnmbr,Unitprce,BillAddress1,BillAddress2,BillCity,BillState,BillZipcode,BillCountry,Quantity,Qtytoinv,Itmclscd,Itemdesc,ItmclscdlistDescription,Serltnum,Serltqty,TaxAmt,Debitamt,LineItemTax,RowNumber,TaxAddress1,TaxAddress2,TaxCity,TaxState,TaxZipcode,TaxCountry,StateTax,FederalTax,VzwmultilineSequenceNumber,VzwfulfillmentId,VzwfirstName,VzwmiddleName,VzwlastName,Vzwphone,VzwemailAddress,VzwcontactType,DeviceType,Vin,DeviceLabel,FleetName,VehicleLabel,UserDefinedLabels,Sllrname,Sllrkey,ModelType,PurchaseItemName,Billable,BillToPo,PurchasePrice,Ppptype,UnitType,Units,Action,Source,Crdrid,Vehid,LicensePlate,Year,Makename,Modelname,IsDeleted,CreatedDate,SubmitPurchaseItemStatusId")] CartBillableItems cartBillableItems)
        {
            if (ModelState.IsValid)
            {
                this._context.Add(cartBillableItems);
                await this._context.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            this.ViewData["CartOrderId"] = new SelectList(this._context.CartOrders, "CartOrderId", "Ordocnum", cartBillableItems.CartOrderId);
            this.ViewData["ScmorderId"] = new SelectList(this._context.Orders, "OrderId", "ConfirmationId", cartBillableItems.ScmorderId);
            this.ViewData["SubmitPurchaseItemStatusId"] = new SelectList(this._context.SubmitPurchaseItemStatuses, "SubmitPurchaseItemStatusId", "ContentId", cartBillableItems.SubmitPurchaseItemStatusId);
            return this.View(cartBillableItems);
        }

        /// <summary>
        /// Async method to make it faster and edit a Cart Billable Item
        /// </summary>
        /// <param name="id">The PK to identify the cart billable item and perform edits on that specific item</param>
        /// <returns>Edit view with the item</returns>
        public async Task<IActionResult> EditAsync(long? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var cartBillableItems = await this._context.CartBillableItems.FindAsync(id);
            if (cartBillableItems == null)
            {
                return this.NotFound();
            }

            this.ViewData["CartOrderId"] = new SelectList(this._context.CartOrders, "CartOrderId", "Ordocnum", cartBillableItems.CartOrderId);
            this.ViewData["ScmorderId"] = new SelectList(this._context.Orders, "OrderId", "ConfirmationId", cartBillableItems.ScmorderId);
            this.ViewData["SubmitPurchaseItemStatusId"] = new SelectList(this._context.SubmitPurchaseItemStatuses, "SubmitPurchaseItemStatusId", "ContentId", cartBillableItems.SubmitPurchaseItemStatusId);
            return this.View("Edit", cartBillableItems);
        }

        /// <summary>
        /// The post portion of the Edit method that saves info to the database through entity framework
        /// </summary>
        /// <param name="id">The PK to identify the cart billable item and perform edits on that specific item</param>
        /// <param name="cartBillableItems">The Cart Billable Item that was edited</param>
        /// <returns>Edit view with the newly edited item</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(long id, [Bind("CartBillableItemId,CartOrderId,ScmorderId,IotorderId,Eoorderid,OrderSource,SfdcopportunityId,ConfirmationId,VzworderNumber,VzwlocationCode,SequenceNumber,BillStartDate,BillEndDate,Cstponbr,Lnitmseq,Itemnmbr,Unitprce,BillAddress1,BillAddress2,BillCity,BillState,BillZipcode,BillCountry,Quantity,Qtytoinv,Itmclscd,Itemdesc,ItmclscdlistDescription,Serltnum,Serltqty,TaxAmt,Debitamt,LineItemTax,RowNumber,TaxAddress1,TaxAddress2,TaxCity,TaxState,TaxZipcode,TaxCountry,StateTax,FederalTax,VzwmultilineSequenceNumber,VzwfulfillmentId,VzwfirstName,VzwmiddleName,VzwlastName,Vzwphone,VzwemailAddress,VzwcontactType,DeviceType,Vin,DeviceLabel,FleetName,VehicleLabel,UserDefinedLabels,Sllrname,Sllrkey,ModelType,PurchaseItemName,Billable,BillToPo,PurchasePrice,Ppptype,UnitType,Units,Action,Source,Crdrid,Vehid,LicensePlate,Year,Makename,Modelname,IsDeleted,CreatedDate,SubmitPurchaseItemStatusId")] CartBillableItems cartBillableItems)
        {
            if (id != cartBillableItems.CartBillableItemId)
            {
                return this.NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._context.Update(cartBillableItems);
                    await this._context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.CartBillableItemsExists(cartBillableItems.CartBillableItemId))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                var bussBillableItems = this._buSSFinanceRepository.SearchBillableItems(Convert.ToInt64(cartBillableItems.CartBillableItemId), TempData["customerNumber"].ToString(), cartBillableItems.ConfirmationId, cartBillableItems.BillStartDate, cartBillableItems.BillEndDate);

                return this.View(nameof(this.Index), bussBillableItems);
            }

            this.ViewData["CartOrderId"] = new SelectList(this._context.CartOrders, "CartOrderId", "Ordocnum", cartBillableItems.CartOrderId);
            this.ViewData["ScmorderId"] = new SelectList(this._context.Orders, "OrderId", "ConfirmationId", cartBillableItems.ScmorderId);
            this.ViewData["SubmitPurchaseItemStatusId"] = new SelectList(this._context.SubmitPurchaseItemStatuses, "SubmitPurchaseItemStatusId", "ContentId", cartBillableItems.SubmitPurchaseItemStatusId);
            return this.View("Edit", cartBillableItems);
        }

        /// <summary>
        /// deletes an item (I'm also not sure if this functionality will be implemented)
        /// </summary>
        /// <param name="id">unique identifier for the item</param>
        /// <returns>the delete confirmed view</returns>
        public async Task<IActionResult> DeleteAsync(long? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var cartBillableItems = await this._context.CartBillableItems
                .Include(c => c.CartOrder)
                .Include(c => c.Scmorder)
                .Include(c => c.SubmitPurchaseItemStatus)
                .FirstOrDefaultAsync(m => m.CartBillableItemId == id);
            if (cartBillableItems == null)
            {
                return this.NotFound();
            }

            return this.View(cartBillableItems);
        }

        /// <summary>
        /// confirm that you want to delete the item and then make the changes in the database
        /// </summary>
        /// <param name="id">unique identifier for the item</param>
        /// <returns>Index view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(long id)
        {
            var cartBillableItems = await this._context.CartBillableItems.FindAsync(id);
            this._context.CartBillableItems.Remove(cartBillableItems);
            await this._context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        /// <summary>
        /// Makes sure the item is in the database
        /// </summary>
        /// <param name="id">unique identifier for the item</param>
        /// <returns>true/false value</returns>
        private bool CartBillableItemsExists(long id)
        {
            return this._context.CartBillableItems.Any(e => e.CartBillableItemId == id);
        }
    }
}
