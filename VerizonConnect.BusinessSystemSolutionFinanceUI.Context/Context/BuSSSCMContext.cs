// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="BuSSSCMContext.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSSCM
{
    using Microsoft.EntityFrameworkCore;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSSCM;

    /// <summary>
    /// Context class for the BuSSSCM Database
    /// </summary>
    public class BuSSSCMContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuSSSCMContext.cs" /> class.
        /// </summary>
        public BuSSSCMContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuSSSCMContext.cs" /> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public BuSSSCMContext(DbContextOptions<BuSSSCMContext> options)
            : base(options)
        {
        }

        // Setting all of the DbContext's for the different tables in the BuSSSCM Database
        public virtual DbSet<BuSSBillableItems> BuSSBillableItems { get; set; }
        public virtual DbSet<BuSSCustomers> BuSSCustomers { get; set; }
        public virtual DbSet<CancelPurchaseAdjustmentResponses> CancelPurchaseAdjustmentResponses { get; set; }
        public virtual DbSet<CancelPurchaseResponses> CancelPurchaseResponses { get; set; }
        public virtual DbSet<CartBillableItems> CartBillableItems { get; set; }
        public virtual DbSet<CartInformations> CartInformations { get; set; }
        public virtual DbSet<CartItems> CartItems { get; set; }
        public virtual DbSet<CartItemStatuses> CartItemStatuses { get; set; }
        public virtual DbSet<CartLineItemMessageStatuses> CartLineItemMessageStatuses { get; set; }
        public virtual DbSet<CartLineItems> CartLineItems { get; set; }
        public virtual DbSet<CartLineItemStatuses> CartLineItemStatuses { get; set; }
        public virtual DbSet<CartOrderCreditsCartOrders> CartOrderCreditsCartOrders { get; set; }
        public virtual DbSet<CartOrderMessageStatuses> CartOrderMessageStatuses { get; set; }
        public virtual DbSet<CartOrders> CartOrders { get; set; }
        public virtual DbSet<CartOrderStatuses> CartOrderStatuses { get; set; }
        public virtual DbSet<CartPricePlanPackages> CartPricePlanPackages { get; set; }
        public virtual DbSet<CartPricePlanPackageStatuses> CartPricePlanPackageStatuses { get; set; }
        public virtual DbSet<CartUnitData> CartUnitData { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<CreditMemos> CreditMemos { get; set; }
        public virtual DbSet<ErrorLogs> ErrorLogs { get; set; }
        public virtual DbSet<HistoricalAdjustments> HistoricalAdjustments { get; set; }
        public virtual DbSet<HistoricalCartBillableItems> HistoricalCartBillableItems { get; set; }
        public virtual DbSet<HistoricalCategories> HistoricalCategories { get; set; }
        public virtual DbSet<HistoricalContacts> HistoricalContacts { get; set; }
        public virtual DbSet<HistoricalInformations> HistoricalInformations { get; set; }
        public virtual DbSet<HistoricalItems> HistoricalItems { get; set; }
        public virtual DbSet<HistoricalLineItems> HistoricalLineItems { get; set; }
        public virtual DbSet<HistoricalOrders> HistoricalOrders { get; set; }
        public virtual DbSet<HistoricalPricePlanPackages> HistoricalPricePlanPackages { get; set; }
        public virtual DbSet<HistoricalServiceDeliveryAddresses> HistoricalServiceDeliveryAddresses { get; set; }
        public virtual DbSet<HistoricalUnitData> HistoricalUnitData { get; set; }
        public virtual DbSet<Informations> Informations { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<LineItems> LineItems { get; set; }
        public virtual DbSet<LineItemStatuses> LineItemStatuses { get; set; }
        public virtual DbSet<Lists> Lists { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersSerialNumbers> OrdersSerialNumbers { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<PricePlanPackages> PricePlanPackages { get; set; }
        public virtual DbSet<RawCancelResponses> RawCancelResponses { get; set; }
        public virtual DbSet<RawCancels> RawCancels { get; set; }
        public virtual DbSet<RawCartResponses> RawCartResponses { get; set; }
        public virtual DbSet<RawCarts> RawCarts { get; set; }
        public virtual DbSet<RawCreditResponses> RawCreditResponses { get; set; }
        public virtual DbSet<RawCredits> RawCredits { get; set; }
        public virtual DbSet<RawNotificationResponses> RawNotificationResponses { get; set; }
        public virtual DbSet<RawNotifications> RawNotifications { get; set; }
        public virtual DbSet<RawOrderResponses> RawOrderResponses { get; set; }
        public virtual DbSet<RawOrders> RawOrders { get; set; }
        public virtual DbSet<RawPurchaseResponses> RawPurchaseResponses { get; set; }
        public virtual DbSet<RawPurchases> RawPurchases { get; set; }
        public virtual DbSet<ServiceDeliveryAddresses> ServiceDeliveryAddresses { get; set; }
        public virtual DbSet<SubmitPurchaseItemStatuses> SubmitPurchaseItemStatuses { get; set; }
        public virtual DbSet<SubmitPurchaseMessageStatuses> SubmitPurchaseMessageStatuses { get; set; }
        public virtual DbSet<SubmitPurchaseOrders> SubmitPurchaseOrders { get; set; }
        public virtual DbSet<SubmitPurchaseOrderStatuses> SubmitPurchaseOrderStatuses { get; set; }
        public virtual DbSet<UnitData> UnitData { get; set; }

        /// <summary>
        /// VALIDATIONS FOR MODELS
        /// </summary>
        /// <param name="modelBuilder">Instantiates the ModelBuilder object that.... Helps build the models..</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuSSBillableItems>(entity =>
            {

            });

            modelBuilder.Entity<BuSSCustomers>(entity =>
            {

                entity.Property(e => e.CustomerNumber)
                    .IsRequired()
                    .HasColumnName("CUSTNMBR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.HasKey(e => e.CustomerNumber);

                entity.Property(e => e.CustomerNumber).ValueGeneratedOnAdd();

            });


            modelBuilder.Entity<CancelPurchaseAdjustmentResponses>(entity =>
            {
                entity.HasKey(e => e.CancelPurchaseAdjustmentResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.HasOne(d => d.CancelPurchaseResponse)
                    .WithMany(p => p.CancelPurchaseAdjustmentResponses)
                    .HasForeignKey(d => d.CancelPurchaseResponseId)
                    .HasConstraintName("FK_CancelPurchaseAdjustmentResponses_CancelPurchaseResponseId_CancelPurchaseReponses_CancelPurchaseResponseId");
            });

            modelBuilder.Entity<CancelPurchaseResponses>(entity =>
            {
                entity.HasKey(e => e.CancelPurchaseResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.HasOne(d => d.CartBillableItem)
                    .WithMany(p => p.CancelPurchaseResponses)
                    .HasForeignKey(d => d.CartBillableItemId)
                    .HasConstraintName("FK_CancelPurchaseResponses_CartBillableItemId_CartOrders_CartBillableItemId");

                entity.HasOne(d => d.CartOrder)
                    .WithMany(p => p.CancelPurchaseResponses)
                    .HasPrincipalKey(p => p.CartOrderId)
                    .HasForeignKey(d => d.CartOrderId)
                    .HasConstraintName("FK_CancelPurchaseResponses_CartOrderId_CartOrders_CartOrderId");
            });

            modelBuilder.Entity<CartBillableItems>(entity =>
            {
                entity.HasKey(e => e.CartBillableItemId);

                entity.HasIndex(e => e.Serltnum)
                    .HasName("idx_CartBillableItems_SERLTNUM");

                entity.Property(e => e.Action)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress1)
                    .IsRequired()
                    .HasColumnName("BillADDRESS1")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress2)
                    .HasColumnName("BillADDRESS2")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillCity)
                    .IsRequired()
                    .HasColumnName("BillCITY")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BillCountry)
                    .HasColumnName("BillCOUNTRY")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillEndDate).HasColumnType("datetime");

                entity.Property(e => e.BillStartDate).HasColumnType("datetime");

                entity.Property(e => e.BillState)
                    .IsRequired()
                    .HasColumnName("BillSTATE")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.BillToPo)
                    .IsRequired()
                    .HasColumnName("BillToPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BillZipcode)
                    .IsRequired()
                    .HasColumnName("BillZIPCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Billable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Crdrid).HasColumnName("CRDRID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cstponbr)
                    .HasColumnName("CSTPONBR")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Debitamt)
                    .HasColumnName("DEBITAMT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.DeviceLabel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Eoorderid).HasColumnName("EOORDERID");

                entity.Property(e => e.FederalTax)
                    .HasColumnType("decimal(19, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FleetName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IotorderId).HasColumnName("IOTOrderId");

                entity.Property(e => e.Itemdesc)
                    .HasColumnName("ITEMDESC")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Itemnmbr)
                    .IsRequired()
                    .HasColumnName("ITEMNMBR")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Itmclscd)
                    .IsRequired()
                    .HasColumnName("ITMCLSCD")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ItmclscdlistDescription)
                    .HasColumnName("ITMCLSCDListDescription")
                    .IsUnicode(false);

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("LICENSE_PLATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTax)
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Lnitmseq).HasColumnName("LNITMSEQ");

                entity.Property(e => e.Makename)
                    .HasColumnName("MAKENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelname)
                    .HasColumnName("MODELNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Ppptype)
                    .HasColumnName("PPPType")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseItemName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(19, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Qtytoinv)
                    .HasColumnName("QTYTOINV")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.ScmorderId).HasColumnName("SCMOrderId");

                entity.Property(e => e.Serltnum)
                    .HasColumnName("SERLTNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Serltqty)
                    .HasColumnName("SERLTQTY")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.SalesforceOpportunityId)
                    .HasColumnName("SFDCOpportunityId")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SellerKey)
                    .HasColumnName("SLLRKEY")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SellerName)
                    .HasColumnName("SLLRNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.StateTax)
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TaxAddress1)
                    .HasColumnName("TaxADDRESS1")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAddress2)
                    .HasColumnName("TaxADDRESS2")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("TAX_AMT")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TaxCity)
                    .HasColumnName("TaxCITY")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountry)
                    .HasColumnName("TaxCOUNTRY")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxState)
                    .HasColumnName("TaxSTATE")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.TaxZipcode)
                    .HasColumnName("TaxZIPCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Unitprce)
                    .HasColumnName("UNITPRCE")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Units)
                    .HasColumnType("decimal(19, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UserDefinedLabels)
                    .HasColumnName("USER_DEFINED_LABELS")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLabel)
                    .HasColumnName("VEHICLE_LABEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Vehid)
                    .HasColumnName("VEHID")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.VzwcontactType)
                    .HasColumnName("VZWContactType")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwemailAddress)
                    .HasColumnName("VZWEmailAddress")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.VzwfirstName)
                    .HasColumnName("VZWFirstName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwfulfillmentId)
                    .HasColumnName("VZWFulfillmentId")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwlastName)
                    .HasColumnName("VZWLastName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwlocationCode)
                    .HasColumnName("VZWLocationCode")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwmiddleName)
                    .HasColumnName("VZWMiddleName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwmultilineSequenceNumber)
                    .HasColumnName("VZWMultilineSequenceNumber")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzworderNumber)
                    .HasColumnName("VZWOrderNumber")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Vzwphone)
                    .HasColumnName("VZWPhone")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.CartOrder)
                    .WithMany(p => p.CartBillableItems)
                    .HasPrincipalKey(p => p.CartOrderId)
                    .HasForeignKey(d => d.CartOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartBillableItems_CartOrderId_CartOrders_CartOrderId");

                entity.HasOne(d => d.Scmorder)
                    .WithMany(p => p.CartBillableItems)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.ScmorderId)
                    .HasConstraintName("FK_CartBillableItems_SCMOrderId_Orders_OrderId");

                entity.HasOne(d => d.SubmitPurchaseItemStatus)
                    .WithMany(p => p.CartBillableItems)
                    .HasForeignKey(d => d.SubmitPurchaseItemStatusId)
                    .HasConstraintName("FK_CartBillableItems_SubmitPurchaseItemStatusId_SubmitPurchaseItemStatuses_SubmitPurchaseItemStatusId");
            });

            modelBuilder.Entity<CartInformations>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemId, e.Name });

                entity.HasIndex(e => e.CartInformationId)
                    .HasName("unq_CartInformations_CartInformationId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CartInformationId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StringValue)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.CartLineItem)
                    .WithMany(p => p.CartInformations)
                    .HasPrincipalKey(p => p.CartLineItemId)
                    .HasForeignKey(d => d.CartLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartInformations_CartLineItemId_CartLineItems_CartLineItemId");
            });

            modelBuilder.Entity<CartItems>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemId, e.ContentId, e.CartItemId });

                entity.HasIndex(e => e.CartItemId)
                    .HasName("unq_CartItems_CartItemId")
                    .IsUnique();

                entity.Property(e => e.ContentId)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CartItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContentType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CartItemStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemStatusId, e.CartItemStatusId });

                entity.HasIndex(e => e.CartItemStatusId)
                    .HasName("unq_CartItemStatuses_CartItemStatusId")
                    .IsUnique();

                entity.Property(e => e.CartItemStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.McsitemId)
                    .IsRequired()
                    .HasColumnName("MCSItemId")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.HasOne(d => d.CartLineItemStatus)
                    .WithMany(p => p.CartItemStatuses)
                    .HasPrincipalKey(p => p.CartLineItemStatusId)
                    .HasForeignKey(d => d.CartLineItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItemStatuses_CartLineItemStatusId_CartLineItemStatuses_CartLineItemStatusId");
            });

            modelBuilder.Entity<CartLineItemMessageStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemStatusId, e.CartLineItemMessageStatusId });

                entity.HasIndex(e => e.CartLineItemMessageStatusId)
                    .HasName("unq_CartLineItemMessageStatuses_CartLineMessageStatusId")
                    .IsUnique();

                entity.Property(e => e.CartLineItemMessageStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.HasOne(d => d.CartLineItemStatus)
                    .WithMany(p => p.CartLineItemMessageStatuses)
                    .HasPrincipalKey(p => p.CartLineItemStatusId)
                    .HasForeignKey(d => d.CartLineItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartLineItemMessageStatuses_CartLineItemStatusId_CartLineItemStatuses_CartLineItemStatusId");
            });

            modelBuilder.Entity<CartLineItems>(entity =>
            {
                entity.HasKey(e => new { e.CartOrderId, e.SequenceNumber });

                entity.HasIndex(e => e.CartLineItemId)
                    .HasName("unq_CartLineItems_CartLineItemId")
                    .IsUnique();

                entity.Property(e => e.CartLineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CartLineItemStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemId, e.CartOrderStatusId });

                entity.HasIndex(e => e.CartLineItemStatusId)
                    .HasName("unq_CartLineItemStatuses_CartLineItemStatusId")
                    .IsUnique();

                entity.Property(e => e.CartLineItemId)
                    .HasColumnName("CartLineItemID")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CartLineItemStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CheckoutPrice)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DestinationAccountReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CartOrderStatus)
                    .WithMany(p => p.CartLineItemStatuses)
                    .HasPrincipalKey(p => p.CartOrderStatusId)
                    .HasForeignKey(d => d.CartOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartLineItemStatuses_CartOrderStatusId_CartOrderStatuses_CartOrderStatusId");
            });

            modelBuilder.Entity<CartOrderCreditsCartOrders>(entity =>
            {
                entity.HasKey(e => new { e.CartOrderIdCredit, e.CartOrderId, e.CartOrderCreditCartOrderId });

                entity.HasIndex(e => e.CartOrderCreditCartOrderId)
                    .HasName("unq_CartOrderCreditsCartOrders_CartOrderCreditCartOrderId")
                    .IsUnique();

                entity.Property(e => e.CartOrderCreditCartOrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CartOrder)
                    .WithMany(p => p.CartOrderCreditsCartOrdersCartOrder)
                    .HasPrincipalKey(p => p.CartOrderId)
                    .HasForeignKey(d => d.CartOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartOrderCreditsCartOrders_CartOrderId_CartOrders_CartOrderId");

                entity.HasOne(d => d.CartOrderIdCreditNavigation)
                    .WithMany(p => p.CartOrderCreditsCartOrdersCartOrderIdCreditNavigation)
                    .HasPrincipalKey(p => p.CartOrderId)
                    .HasForeignKey(d => d.CartOrderIdCredit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartOrderCreditsCartOrders_CartOrderIdCredit_CartOrders_CartOrderId");
            });

            modelBuilder.Entity<CartOrderMessageStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartOrderStatusId, e.CartOrderMessageStatusId });

                entity.HasIndex(e => e.CartOrderMessageStatusId)
                    .HasName("unq_CartOrderMessageStatuses_CartOrderMessageStatusId")
                    .IsUnique();

                entity.Property(e => e.CartOrderMessageStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.HasOne(d => d.CartOrderStatus)
                    .WithMany(p => p.CartOrderMessageStatuses)
                    .HasPrincipalKey(p => p.CartOrderStatusId)
                    .HasForeignKey(d => d.CartOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartOrderMessageStatuses_CartOrderStatusId_CartOrderStatuses_CartOrderStatusId");
            });

            modelBuilder.Entity<CartOrders>(entity =>
            {
                entity.HasKey(e => new { e.Ordocnum, e.Soptype });

                entity.HasIndex(e => e.CartOrderId)
                    .HasName("unq_CartOrders_CartOrderId")
                    .IsUnique();

                entity.Property(e => e.Ordocnum)
                    .HasColumnName("ORDOCNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Soptype).HasColumnName("SOPTYPE");

                entity.Property(e => e.AccountReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CartOrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.CartTransactionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Custname)
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Custnmbr)
                    .IsRequired()
                    .HasColumnName("CUSTNMBR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Docdate)
                    .HasColumnName("DOCDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.VzwaccountNumber)
                    .HasColumnName("VZWAccountNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VzwcustomerNumber)
                    .IsRequired()
                    .HasColumnName("VZWCustomerNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vzwecpdid)
                    .HasColumnName("VZWECPDID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CartOrderStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartOrderId, e.CartOrderStatusId });

                entity.HasIndex(e => e.CartOrderStatusId)
                    .HasName("unq_CartOrderStatuses_CartOrderStatusId")
                    .IsUnique();

                entity.Property(e => e.CartOrderStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalCheckoutPrice).HasColumnType("decimal(19, 5)");
            });

            modelBuilder.Entity<CartPricePlanPackages>(entity =>
            {
                entity.HasKey(e => new { e.CartItemId, e.CartPricePlanPackageId });

                entity.HasIndex(e => e.CartPricePlanPackageId)
                    .HasName("unq_CartPricePlanPackages_CartPricePlanPackageId")
                    .IsUnique();

                entity.Property(e => e.CartPricePlanPackageId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ppptype)
                    .HasColumnName("PPPType")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.CartItem)
                    .WithMany(p => p.CartPricePlanPackages)
                    .HasPrincipalKey(p => p.CartItemId)
                    .HasForeignKey(d => d.CartItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartPricePlanPackages_CartItemId_CartItems_CartItemId");
            });

            modelBuilder.Entity<CartPricePlanPackageStatuses>(entity =>
            {
                entity.HasKey(e => new { e.CartItemStatusId, e.CartPricePlanPackageStatusId });

                entity.HasIndex(e => e.CartPricePlanPackageStatusId)
                    .HasName("unq_CartPricePlanPackageStatuses_CartPricePlanPackageStatusId")
                    .IsUnique();

                entity.Property(e => e.CartPricePlanPackageStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pppid)
                    .HasColumnName("PPPId")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.CartItemStatus)
                    .WithMany(p => p.CartPricePlanPackageStatuses)
                    .HasPrincipalKey(p => p.CartItemStatusId)
                    .HasForeignKey(d => d.CartItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartPricePlanPackageStatuses_CartItemStatusId_CartItemStatuses_CartItemStatusId");
            });

            modelBuilder.Entity<CartUnitData>(entity =>
            {
                entity.HasKey(e => new { e.CartLineItemId, e.CartUnitDatumId });

                entity.HasIndex(e => e.CartUnitDatumId)
                    .HasName("unq_CartUnitData_CartUnitDatumId")
                    .IsUnique();

                entity.Property(e => e.CartUnitDatumId).ValueGeneratedOnAdd();

                entity.Property(e => e.Action)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.CartLineItem)
                    .WithMany(p => p.CartUnitData)
                    .HasPrincipalKey(p => p.CartLineItemId)
                    .HasForeignKey(d => d.CartLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartUnitData_CartLineItemId_CartLineItems_CartLineItemId");

                entity.HasOne(d => d.UnitDatum)
                    .WithMany(p => p.CartUnitData)
                    .HasPrincipalKey(p => p.UnitDatumId)
                    .HasForeignKey(d => d.UnitDatumId)
                    .HasConstraintName("FK_CartUnitData_UnitDatumId_UnitData_UnitDatumId");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.McscategoryId, e.CategoryId });

                entity.HasIndex(e => e.CategoryId)
                    .HasName("unq_Categories_CategoryId")
                    .IsUnique();

                entity.Property(e => e.McscategoryId)
                    .HasColumnName("MCSCategoryId")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.BundleId)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Categories)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.LastName, e.ContactId });

                entity.HasIndex(e => e.ContactId)
                    .HasName("unq_Contacts_ContactId")
                    .IsUnique();

                entity.Property(e => e.LastName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContactType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Contacts)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacts_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<CreditMemos>(entity =>
            {
                entity.HasKey(e => new { e.Ordocnum, e.Soptype });

                entity.HasIndex(e => e.CreditMemoId)
                    .HasName("unq_CreditMemos_CreditMemoId")
                    .IsUnique();

                entity.Property(e => e.Ordocnum)
                    .HasColumnName("ORDOCNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Soptype).HasColumnName("SOPTYPE");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditMemoId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CartOrder)
                    .WithMany(p => p.CreditMemos)
                    .HasPrincipalKey(p => p.CartOrderId)
                    .HasForeignKey(d => d.CartOrderId)
                    .HasConstraintName("FK_CreditMemos_CartOrderId_CartOrders_CartOrderId");
            });

            modelBuilder.Entity<ErrorLogs>(entity =>
            {
                entity.HasKey(e => e.ErrorLogId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            });

            modelBuilder.Entity<HistoricalAdjustments>(entity =>
            {
                entity.HasKey(e => e.HistoricalAdjustmentId);

                entity.Property(e => e.Amount).HasColumnType("numeric(19, 5)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalTaxAmount).HasColumnType("numeric(19, 5)");
            });

            modelBuilder.Entity<HistoricalCartBillableItems>(entity =>
            {
                entity.HasKey(e => e.HistoricalCartBillableItemId);

                entity.Property(e => e.Action)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress1)
                    .IsRequired()
                    .HasColumnName("BillADDRESS1")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress2)
                    .HasColumnName("BillADDRESS2")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillCity)
                    .IsRequired()
                    .HasColumnName("BillCITY")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BillCountry)
                    .HasColumnName("BillCOUNTRY")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.BillEndDate).HasColumnType("datetime");

                entity.Property(e => e.BillStartDate).HasColumnType("datetime");

                entity.Property(e => e.BillState)
                    .IsRequired()
                    .HasColumnName("BillSTATE")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.BillToPo)
                    .IsRequired()
                    .HasColumnName("BillToPO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillZipcode)
                    .IsRequired()
                    .HasColumnName("BillZIPCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Billable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Crdrid).HasColumnName("CRDRID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Cstponbr)
                    .HasColumnName("CSTPONBR")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Debitamt)
                    .HasColumnName("DEBITAMT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.DeviceLabel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Eoorderid).HasColumnName("EOORDERID");

                entity.Property(e => e.FederalTax).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FleetName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IotorderId).HasColumnName("IOTOrderId");

                entity.Property(e => e.Itemdesc)
                    .HasColumnName("ITEMDESC")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Itemnmbr)
                    .IsRequired()
                    .HasColumnName("ITEMNMBR")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Itmclscd)
                    .IsRequired()
                    .HasColumnName("ITMCLSCD")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ItmclscdlistDescription)
                    .HasColumnName("ITMCLSCDListDescription")
                    .IsUnicode(false);

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("LICENSE_PLATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTax).HasColumnType("numeric(19, 5)");

                entity.Property(e => e.Lnitmseq).HasColumnName("LNITMSEQ");

                entity.Property(e => e.Makename)
                    .HasColumnName("MAKENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelType)
                    .HasColumnName("MODEL_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelname)
                    .HasColumnName("MODELNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Ppptype)
                    .HasColumnName("PPPType")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseItemName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Qtytoinv)
                    .HasColumnName("QTYTOINV")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.ScmorderId).HasColumnName("SCMOrderId");

                entity.Property(e => e.Serltnum)
                    .HasColumnName("SERLTNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Serltqty)
                    .HasColumnName("SERLTQTY")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.SfdcopportunityId)
                    .HasColumnName("SFDCOpportunityId")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Sllrkey)
                    .HasColumnName("SLLRKEY")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Sllrname)
                    .HasColumnName("SLLRNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.StateTax).HasColumnType("numeric(19, 5)");

                entity.Property(e => e.TaxAddress1)
                    .HasColumnName("TaxADDRESS1")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAddress2)
                    .HasColumnName("TaxADDRESS2")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("TAX_AMT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.TaxCity)
                    .HasColumnName("TaxCITY")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountry)
                    .HasColumnName("TaxCOUNTRY")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TaxState)
                    .HasColumnName("TaxSTATE")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.TaxZipcode)
                    .HasColumnName("TaxZIPCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Unitprce)
                    .HasColumnName("UNITPRCE")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.Units).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UserDefinedLabels)
                    .HasColumnName("USER_DEFINED_LABELS")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLabel)
                    .HasColumnName("VEHICLE_LABEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Vehid)
                    .HasColumnName("VEHID")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.VzwcontactType)
                    .HasColumnName("VZWContactType")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwemailAddress)
                    .HasColumnName("VZWEmailAddress")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.VzwfirstName)
                    .HasColumnName("VZWFirstName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwfulfillmentId)
                    .HasColumnName("VZWFulfillmentId")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwlastName)
                    .HasColumnName("VZWLastName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwlocationCode)
                    .HasColumnName("VZWLocationCode")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwmiddleName)
                    .HasColumnName("VZWMiddleName")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VzwmultilineSequenceNumber)
                    .HasColumnName("VZWMultilineSequenceNumber")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzworderNumber)
                    .HasColumnName("VZWOrderNumber")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Vzwphone)
                    .HasColumnName("VZWPhone")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<HistoricalCategories>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.McscategoryId, e.CategoryId, e.HistoricalCategoryId });

                entity.HasIndex(e => e.HistoricalCategoryId)
                    .HasName("unq_HistoricalCategories_HistoricalCategoryId")
                    .IsUnique();

                entity.Property(e => e.McscategoryId)
                    .HasColumnName("MCSCategoryId")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalCategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.BundleId)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalCategoriesCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HistoricalContacts>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.LastName, e.ContactId, e.HistoricalContactId });

                entity.HasIndex(e => e.HistoricalContactId)
                    .HasName("unq_HistoricalContacts_HistoricalContactId")
                    .IsUnique();

                entity.Property(e => e.LastName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalContactId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContactType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalContactsCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalInformations>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.Name, e.HistoricalInformationId });

                entity.HasIndex(e => e.HistoricalInformationId)
                    .HasName("unq_HistoricalInformations_HistoricalInformationId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalInformationId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalInformationsCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StringValue)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalItems>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ContentId, e.ItemId, e.HistoricalItemId });

                entity.HasIndex(e => e.HistoricalItemId)
                    .HasName("unq_HistoricalItems_HistoricalItemId")
                    .IsUnique();

                entity.Property(e => e.ContentId)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContentType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalItemsCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.McsitemId)
                    .HasColumnName("MCSItemId")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalLineItems>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.FulfillmentId, e.HistoricalLineItemId });

                entity.HasIndex(e => e.HistoricalLineItemId)
                    .HasName("PK_HistoricalLineItems_HistoricalLineItemId")
                    .IsUnique();

                entity.Property(e => e.FulfillmentId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalLineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalLineItemsCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentFulfillmentId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalOrders>(entity =>
            {
                entity.HasKey(e => new { e.ConfirmationId, e.HistoricalOrderId });

                entity.HasIndex(e => e.HistoricalOrderId)
                    .HasName("unq_HistoricalOrders_HistoricalOrderId")
                    .IsUnique();

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalOrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.AccountReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalOrdersCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HistoricalPricePlanPackages>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.Pppid, e.HistoricalPricePlanPackageId });

                entity.HasIndex(e => e.HistoricalPricePlanPackageId)
                    .HasName("unq_HistoricalPricePlanPackages_HistoricalPricePlanPackageId")
                    .IsUnique();

                entity.Property(e => e.Pppid)
                    .HasColumnName("PPPId")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalPricePlanPackageId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.HistoricalPricePlanPackagesCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ppptype)
                    .HasColumnName("PPPType")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("decimal(19, 5)");
            });

            modelBuilder.Entity<HistoricalServiceDeliveryAddresses>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ZipCode, e.Address1, e.HistoricalServiceDeliveryAddressId });

                entity.HasIndex(e => e.HistoricalServiceDeliveryAddressId)
                    .HasName("unq_HistoricalServiceDeliveryAddresses_HistoricalServiceDeliveryAddressId")
                    .IsUnique();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalServiceDeliveryAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalServiceDeliveryAddressesCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalUnitData>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.UnitDatumId, e.HistoricalUnitDatumId });

                entity.HasIndex(e => e.HistoricalUnitDatumId)
                    .HasName("unq_HistoricalUnitData_HistoricalUnitDatumId")
                    .IsUnique();

                entity.Property(e => e.HistoricalUnitDatumId).ValueGeneratedOnAdd();

                entity.Property(e => e.Action)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalUnitDataCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("decimal(19, 5)");
            });

            modelBuilder.Entity<Informations>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.Name });

                entity.HasIndex(e => e.InformationId)
                    .HasName("unq_Informations_InformationId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InformationId).ValueGeneratedOnAdd();

                entity.Property(e => e.StringValue)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Informations)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Informations_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ContentId, e.ItemId });

                entity.HasIndex(e => e.ItemId)
                    .HasName("unq_Items_ItemId")
                    .IsUnique();

                entity.Property(e => e.ContentId)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContentType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.McsitemId)
                    .HasColumnName("MCSItemId")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Items)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<LineItems>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.FulfillmentId });

                entity.HasIndex(e => e.FulfillmentId)
                    .HasName("unq_LineItems_FulfillmentId")
                    .IsUnique();

                entity.HasIndex(e => e.LineItemId)
                    .HasName("unq_LineItems_LineItemId")
                    .IsUnique();

                entity.Property(e => e.FulfillmentId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.ParentFulfillmentId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LineItems)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItems_OrderId_Orders_OrderId");

                entity.HasOne(d => d.ParentFulfillment)
                    .WithMany(p => p.InverseParentFulfillment)
                    .HasPrincipalKey(p => p.FulfillmentId)
                    .HasForeignKey(d => d.ParentFulfillmentId)
                    .HasConstraintName("FK_LineItems_ParentFulfillmentId_LineItems_FulfillmentId");
            });

            modelBuilder.Entity<LineItemStatuses>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.Code, e.CreatedDate });

                entity.HasIndex(e => e.LineItemStatusId)
                    .HasName("unq_LineItemStatuses_LineItemStatusId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemStatusTypeValueId).HasDefaultValueSql("((1))");

                entity.Property(e => e.LineItemStatusId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemStatuses)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItemStatuses_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<Lists>(entity =>
            {
                entity.HasKey(e => new { e.ListName, e.ListValue });

                entity.HasIndex(e => e.ListId)
                    .HasName("uidx_Lists_ListId")
                    .IsUnique();

                entity.Property(e => e.ListName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ListDescription)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ListId).ValueGeneratedOnAdd();

                entity.Property(e => e.ListText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ListParent)
                    .WithMany(p => p.InverseListParent)
                    .HasPrincipalKey(p => p.ListId)
                    .HasForeignKey(d => d.ListParentId)
                    .HasConstraintName("FK_Lists_ListParentId_Lists_ListId");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.ConfirmationId);

                entity.HasIndex(e => e.OrderId)
                    .HasName("unq_Orders_OrderId")
                    .IsUnique();

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.AccountReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrdersSerialNumbers>(entity =>
            {
                entity.HasKey(e => new { e.ConfirmationId, e.Serltnum });

                entity.HasIndex(e => e.OrderSerialNumberId)
                    .HasName("unq_OrdersSerialNumbers_OrderSerialNumberId")
                    .IsUnique();

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Serltnum)
                    .HasColumnName("SERLTNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerialNumberId).ValueGeneratedOnAdd();

                entity.Property(e => e.SfdcopportunityId)
                    .IsRequired()
                    .HasColumnName("SFDCOpportunityId")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.HasOne(d => d.Confirmation)
                    .WithMany(p => p.OrdersSerialNumbers)
                    .HasForeignKey(d => d.ConfirmationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersSerialNumbers_ConfirmationId_Orders_ConfirmationId");
            });

            modelBuilder.Entity<OrderStatuses>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.Code, e.CreatedDate });

                entity.HasIndex(e => e.OrderStatusId)
                    .HasName("unq_OrderStatuses_OrderStatusId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderStatusTypeValueId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderStatuses)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStatuses_OrderId_Orders_OrderId");
            });

            modelBuilder.Entity<PricePlanPackages>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.Pppid });

                entity.HasIndex(e => e.PricePlanPackageId)
                    .HasName("unq_PricePlanPackages_PricePlanPackageId")
                    .IsUnique();

                entity.Property(e => e.Pppid)
                    .HasColumnName("PPPId")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Ppptype)
                    .HasColumnName("PPPType")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PricePlanPackageId).ValueGeneratedOnAdd();

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PricePlanPackages)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricePlanPackages_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<RawCancelResponses>(entity =>
            {
                entity.HasKey(e => e.RawCancelResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCancelResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawCancel)
                    .WithMany(p => p.RawCancelResponses)
                    .HasForeignKey(d => d.RawCancelId)
                    .HasConstraintName("FK_RawCancelResponses_RawCancelId_RawCancels_RawCancelId");
            });

            modelBuilder.Entity<RawCancels>(entity =>
            {
                entity.HasKey(e => e.RawCancelId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCancelText).IsUnicode(false);
            });

            modelBuilder.Entity<RawCartResponses>(entity =>
            {
                entity.HasKey(e => e.RawCartResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCartResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawCart)
                    .WithMany(p => p.RawCartResponses)
                    .HasForeignKey(d => d.RawCartId)
                    .HasConstraintName("FK_RawCartResponses_RawCartId_RawCarts_RawCartId");
            });

            modelBuilder.Entity<RawCarts>(entity =>
            {
                entity.HasKey(e => e.RawCartId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCartText).IsUnicode(false);
            });

            modelBuilder.Entity<RawCreditResponses>(entity =>
            {
                entity.HasKey(e => e.RawCreditResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCreditResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawCredit)
                    .WithMany(p => p.RawCreditResponses)
                    .HasForeignKey(d => d.RawCreditId)
                    .HasConstraintName("FK_RawCreditResponses_RawCreditId_RawCredits_RawCreditId");
            });

            modelBuilder.Entity<RawCredits>(entity =>
            {
                entity.HasKey(e => e.RawCreditId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawCreditText).IsUnicode(false);
            });

            modelBuilder.Entity<RawNotificationResponses>(entity =>
            {
                entity.HasKey(e => e.RawNotificationResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawNotificationResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawNotification)
                    .WithMany(p => p.RawNotificationResponses)
                    .HasForeignKey(d => d.RawNotificationId)
                    .HasConstraintName("FK_RawNotificationResponses_RawNotificationId_RawNotifications_RawNotificationId");
            });

            modelBuilder.Entity<RawNotifications>(entity =>
            {
                entity.HasKey(e => e.RawNotificationId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawNotificationText).IsUnicode(false);
            });

            modelBuilder.Entity<RawOrderResponses>(entity =>
            {
                entity.HasKey(e => e.RawOrderResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawOrderResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawOrder)
                    .WithMany(p => p.RawOrderResponses)
                    .HasForeignKey(d => d.RawOrderId)
                    .HasConstraintName("FK_RawOrderResponses_RawOrderId_RawOrders_RawOrderId");
            });

            modelBuilder.Entity<RawOrders>(entity =>
            {
                entity.HasKey(e => e.RawOrderId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawOrderText).IsUnicode(false);
            });

            modelBuilder.Entity<RawPurchaseResponses>(entity =>
            {
                entity.HasKey(e => e.RawPurchaseResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawPurchaseResponseText).IsUnicode(false);

                entity.Property(e => e.RawPurchaseResponseXml)
                    .HasColumnName("RawPurchaseResponseXML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.RawPurchase)
                    .WithMany(p => p.RawPurchaseResponses)
                    .HasForeignKey(d => d.RawPurchaseId)
                    .HasConstraintName("FK_RawPurchaseResponses_RawPurchaseId_RawPurchases_RawPurchaseId");
            });

            modelBuilder.Entity<RawPurchases>(entity =>
            {
                entity.HasKey(e => e.RawPurchaseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawPurchaseText).IsUnicode(false);

                entity.Property(e => e.RawPurchaseXml)
                    .HasColumnName("RawPurchaseXML")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<ServiceDeliveryAddresses>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ZipCode, e.Address1 });

                entity.HasIndex(e => e.ServiceDeliveryAddressId)
                    .HasName("unq_ServiceDeliveryAddresses_ServiceDeliveryAddressId")
                    .IsUnique();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceDeliveryAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ServiceDeliveryAddresses)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceDeliveryAddresses_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<SubmitPurchaseItemStatuses>(entity =>
            {
                entity.HasKey(e => e.SubmitPurchaseItemStatusId);

                entity.HasIndex(e => e.SubmitPurchaseItemStatusId)
                    .HasName("unq_SubmitPurchaseItemStatuses_SubmitPurchaseItemStatusId")
                    .IsUnique();

                entity.Property(e => e.CartLineItemId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ContentId)
                    .IsRequired()
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ContentMimeType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ContentSize)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DownloadUrl)
                    .HasColumnName("DownloadURL")
                    .HasMaxLength(2083)
                    .IsUnicode(false);

                entity.Property(e => e.FulfillmentId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseUrl)
                    .HasColumnName("LicenseURL")
                    .HasMaxLength(2083)
                    .IsUnicode(false);

                entity.Property(e => e.McsitemId)
                    .HasColumnName("MCSItemId")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.SubmitPurchaseOrderStatus)
                    .WithMany(p => p.SubmitPurchaseItemStatuses)
                    .HasPrincipalKey(p => p.SubmitPurchaseOrderStatusId)
                    .HasForeignKey(d => d.SubmitPurchaseOrderStatusId)
                    .HasConstraintName("FK_SubmitPurchaseItemStatuses_SubmitPurchaseOrderStatusId_SubmitPurchaseOrderStatuses_SubmitPurchaseOrderStatusId");
            });

            modelBuilder.Entity<SubmitPurchaseMessageStatuses>(entity =>
            {
                entity.HasKey(e => new { e.SubmitPurchaseOrderStatusId, e.SubmitPurchaseMessageStatusId });

                entity.HasIndex(e => e.SubmitPurchaseMessageStatusId)
                    .HasName("unq_SubmitPurchaseMessageStatuses_SubmitPurchaseMessageStatusId")
                    .IsUnique();

                entity.Property(e => e.SubmitPurchaseMessageStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.HasOne(d => d.SubmitPurchaseOrderStatus)
                    .WithMany(p => p.SubmitPurchaseMessageStatuses)
                    .HasPrincipalKey(p => p.SubmitPurchaseOrderStatusId)
                    .HasForeignKey(d => d.SubmitPurchaseOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubmitPurchaseMessageStatuses_SubmitPurchaseOrderStatusId_SubmitPurchaseOrderStatuses_SubmitPurchaseOrderStatusId");
            });

            modelBuilder.Entity<SubmitPurchaseOrders>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.CustomerId, e.AccountNumber, e.ConfirmationId });

                entity.HasIndex(e => e.SubmitPurchaseOrderId)
                    .HasName("unq_SubmitPurchaseOrders_SubmitPurchaseOrderId")
                    .IsUnique();

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.AccountReference)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CallerVendorId)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelId)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubmitPurchaseOrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SubmitPurchaseOrderStatuses>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.SubmitPurchaseOrderStatusId });

                entity.HasIndex(e => e.SubmitPurchaseOrderStatusId)
                    .HasName("unq_SubmitPurchaseOrderStatuses_SubmitPurchaseOrderStatusId")
                    .IsUnique();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitPurchaseOrderStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UnitData>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.UnitDatumId });

                entity.HasIndex(e => e.UnitDatumId)
                    .HasName("unq_UnitData_UnitDatumId")
                    .IsUnique();

                entity.Property(e => e.UnitDatumId).ValueGeneratedOnAdd();

                entity.Property(e => e.Action)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.UnitData)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitData_LineItemId_LineItems_LineItemId");
            });
        }
    }
}
