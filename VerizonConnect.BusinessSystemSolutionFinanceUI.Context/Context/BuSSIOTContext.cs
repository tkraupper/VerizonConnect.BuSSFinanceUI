// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="BuSSIOTContext.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSIOT
{
    using Microsoft.EntityFrameworkCore;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.BuSSIOT;

    /// <summary>
    /// The Context class for the BuSSIOT Database
    /// </summary>
    public class BuSSIOTContext : DbContext
    {
        public BuSSIOTContext()
        {
        }

        public BuSSIOTContext(DbContextOptions<BuSSIOTContext> options)
            : base(options)
        {
        }

        // Setting all of the DbContext's for the different tables in the BuSSIOT Database
        public virtual DbSet<BillingAddresses> BillingAddresses { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<ErrorLogs> ErrorLogs { get; set; }
        public virtual DbSet<HistoricalCustomerAddresses> HistoricalCustomerAddresses { get; set; }
        public virtual DbSet<HistoricalCustomers> HistoricalCustomers { get; set; }
        public virtual DbSet<HistoricalItemDetails> HistoricalItemDetails { get; set; }
        public virtual DbSet<HistoricalLineItemPonumbers> HistoricalLineItemPonumbers { get; set; }
        public virtual DbSet<HistoricalLineItems> HistoricalLineItems { get; set; }
        public virtual DbSet<HistoricalOrders> HistoricalOrders { get; set; }
        public virtual DbSet<HistoricalServiceHeaders> HistoricalServiceHeaders { get; set; }
        public virtual DbSet<HistoricalShipAddresses> HistoricalShipAddresses { get; set; }
        public virtual DbSet<ItemDetails> ItemDetails { get; set; }
        public virtual DbSet<LineItemPonumbers> LineItemPonumbers { get; set; }
        public virtual DbSet<LineItemRemarks> LineItemRemarks { get; set; }
        public virtual DbSet<LineItems> LineItems { get; set; }
        public virtual DbSet<LineItemStatuses> LineItemStatuses { get; set; }
        public virtual DbSet<Lists> Lists { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<RawAcceptanceResponses> RawAcceptanceResponses { get; set; }
        public virtual DbSet<RawAcceptances> RawAcceptances { get; set; }
        public virtual DbSet<RawOrderResponses> RawOrderResponses { get; set; }
        public virtual DbSet<RawOrders> RawOrders { get; set; }
        public virtual DbSet<RawShipmentResponses> RawShipmentResponses { get; set; }
        public virtual DbSet<RawShipments> RawShipments { get; set; }
        public virtual DbSet<ServiceHeaders> ServiceHeaders { get; set; }
        public virtual DbSet<ShipAddresses> ShipAddresses { get; set; }
        public virtual DbSet<ShipItemDetails> ShipItemDetails { get; set; }
        public virtual DbSet<ShipLineItems> ShipLineItems { get; set; }

        /// <summary>
        /// VALIDATIONS FOR MODELS
        /// </summary>
        /// <param name="modelBuilder">Instantiates the ModelBuilder object that.... Helps build the models..</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingAddresses>(entity =>
            {
                entity.Property(e => e.BillingAddressesId).HasColumnName("BillingAddressesID");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("accountNo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasColumnName("accountStatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveMtnQuantity)
                    .HasColumnName("activeMtnQuantity")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("addressLine1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BillAccountGroupId)
                    .HasColumnName("billAccountGroupId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BillingSys)
                    .IsRequired()
                    .HasColumnName("billingSys")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasColumnName("businessName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CicsErrorCode)
                    .HasColumnName("cicsErrorCode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("clientId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorrelationId)
                    .HasColumnName("correlationId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CourtesyTitleCode)
                    .HasColumnName("courtesyTitleCode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("errorCode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMsg)
                    .HasColumnName("errorMsg")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ListCount)
                    .HasColumnName("listCount")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleInitial)
                    .HasColumnName("middleInitial")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServerName)
                    .HasColumnName("serverName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasColumnName("serviceName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("statusCode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuffixName)
                    .HasColumnName("suffixName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarningMsg)
                    .HasColumnName("warningMsg")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerAddressId });

                entity.HasIndex(e => e.CustomerAddressId)
                    .HasName("unq_CustomerAddresses_CustomerAddressId")
                    .IsUnique();

                entity.Property(e => e.CustomerAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode4)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasPrincipalKey(p => p.CustomerId)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddresses_CustomerId_Customers_CustomerId");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.VzwcustomerId, e.Ecpdid });

                entity.HasIndex(e => e.CustomerId)
                    .HasName("unq_Customers_CustomerId")
                    .IsUnique();

                entity.Property(e => e.VzwcustomerId)
                    .HasColumnName("VZWCustomerId")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Ecpdid)
                    .HasColumnName("ECPDID")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();

                entity.Property(e => e.ExternalVendorReferenceNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VzwaccountNumber)
                    .HasColumnName("VZWAccountNumber")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Customers)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_OrderId_Orders_OrderId");
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

            modelBuilder.Entity<HistoricalCustomerAddresses>(entity =>
            {
                entity.HasKey(e => e.HistoricalCustomerAddressId);

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalCustomerAddressesCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode4)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalCustomers>(entity =>
            {
                entity.HasKey(e => e.HistoricalCustomerId);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ecpdid)
                    .IsRequired()
                    .HasColumnName("ECPDID")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalVendorReferenceNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalCustomersCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VzwaccountNumber)
                    .HasColumnName("VZWAccountNumber")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.VzwcustomerId)
                    .IsRequired()
                    .HasColumnName("VZWCustomerId")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalItemDetails>(entity =>
            {
                entity.HasKey(e => e.HistoricalItemDetailId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalItemDetails1)
                    .HasColumnName("HistoricalItemDetails")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(19, 5)");
            });

            modelBuilder.Entity<HistoricalLineItemPonumbers>(entity =>
            {
                entity.HasKey(e => e.HistoricalLineItemPonumberId);

                entity.ToTable("HistoricalLineItemPONumbers");

                entity.Property(e => e.HistoricalLineItemPonumberId).HasColumnName("HistoricalLineItemPONumberId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalLineItemPonumbersCreatedDate)
                    .HasColumnName("HistoricalLineItemPONumbersCreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineItemPonumberId).HasColumnName("LineItemPONumberId");

                entity.Property(e => e.PurchaseOrderNumber)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalLineItems>(entity =>
            {
                entity.HasKey(e => e.HistoricalLineItemId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalLineItemsCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethod)
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalOrders>(entity =>
            {
                entity.HasKey(e => e.HistoricalOrderId);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalVendorReferenceNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalOrdersCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareOrdered)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalServiceHeaders>(entity =>
            {
                entity.HasKey(e => e.HistoricalServiceHeaderId);

                entity.Property(e => e.ApplicationResponseClass)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseCode)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseDetails)
                    .HasMaxLength(2047)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApplicationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApplicationUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoricalServiceHeaderCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoggingId)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceAction)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.HistoricalServiceHeaders)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_HistoricalServiceHeaders_OrderId_Orders_OrderId");

                entity.HasOne(d => d.ServiceHeader)
                    .WithMany(p => p.HistoricalServiceHeaders)
                    .HasForeignKey(d => d.ServiceHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricalServiceHeaders_ServiceHeaderId_ServiceHeaders_ServiceHeaderId");
            });

            modelBuilder.Entity<HistoricalShipAddresses>(entity =>
            {
                entity.HasKey(e => e.HistoricalShipAddressId);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Attention)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FirmName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalShipAddressesCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.RuralDelivery)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.RuralRoute)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode4)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemDetails>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ItemSequenceNumber });

                entity.HasIndex(e => e.ItemDetailId)
                    .HasName("unq_ItemDetails_ItemDetailId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemPrice)
                    .HasColumnType("decimal(19, 5)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ItemDetails)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemDetails_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<LineItemPonumbers>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.LineItemPonumberId });

                entity.ToTable("LineItemPONumbers");

                entity.HasIndex(e => e.LineItemPonumberId)
                    .HasName("unq_LineItemPONumbers_LineItemPONumberId")
                    .IsUnique();

                entity.Property(e => e.LineItemPonumberId)
                    .HasColumnName("LineItemPONumberId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PurchaseOrderNumber)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemPonumbers)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItemPONumbers_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<LineItemRemarks>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.LineItemRemarkId });

                entity.HasIndex(e => e.LineItemRemarkId)
                    .HasName("unq_LineItemRemarks_LineItemRemarkId")
                    .IsUnique();

                entity.Property(e => e.LineItemRemarkId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Event)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(2047)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemRemarks)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItemRemarks_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<LineItems>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.MultiLineSequenceNumber });

                entity.HasIndex(e => e.LineItemId)
                    .HasName("unq_LineItems_LineItemId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethod)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LineItems)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItems_OrderId_Orders_OrderId");
            });

            modelBuilder.Entity<LineItemStatuses>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.LineItemStatusId });

                entity.HasIndex(e => e.LineItemStatusId)
                    .HasName("unq_LineItemStatuses_LineItemStatusId")
                    .IsUnique();

                entity.Property(e => e.LineItemStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StatusTypeValueId).HasDefaultValueSql("((1))");

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
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber });

                entity.HasIndex(e => e.OrderId)
                    .HasName("unq_Orders_OrderId")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalVendorReferenceNumber)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.SoftwareOrdered)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<RawAcceptanceResponses>(entity =>
            {
                entity.HasKey(e => e.RawAcceptanceResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawAcceptanceResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawAcceptance)
                    .WithMany(p => p.RawAcceptanceResponses)
                    .HasForeignKey(d => d.RawAcceptanceId)
                    .HasConstraintName("FK_RawAcceptanceResponses_RawAcceptanceId_RawAcceptances_RawAcceptanceId");
            });

            modelBuilder.Entity<RawAcceptances>(entity =>
            {
                entity.HasKey(e => e.RawAcceptanceId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawAcceptanceText).IsUnicode(false);
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

            modelBuilder.Entity<RawShipmentResponses>(entity =>
            {
                entity.HasKey(e => e.RawShipmentResponseId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawShipmentResponseText).IsUnicode(false);

                entity.HasOne(d => d.RawShipment)
                    .WithMany(p => p.RawShipmentResponses)
                    .HasForeignKey(d => d.RawShipmentId)
                    .HasConstraintName("FK_RawShipmentResponses_RawShipmentId_RawShipments_RawShipmentId");
            });

            modelBuilder.Entity<RawShipments>(entity =>
            {
                entity.HasKey(e => e.RawShipmentId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RawShipmentText).IsUnicode(false);
            });

            modelBuilder.Entity<ServiceHeaders>(entity =>
            {
                entity.HasKey(e => e.ServiceHeaderId);

                entity.Property(e => e.ApplicationResponseClass)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseCode)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseDetails)
                    .HasMaxLength(2047)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationResponseMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApplicationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApplicationUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoggingId)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceAction)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ServiceHeaders)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_ServiceHeaders_OrderId_Orders_OrderId");
            });

            modelBuilder.Entity<ShipAddresses>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ShipAddressId });

                entity.HasIndex(e => e.ShipAddressId)
                    .HasName("unq_ShipAddresses_ShipAddressId")
                    .IsUnique();

                entity.Property(e => e.ShipAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Attention)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direction)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FirmName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.RuralDelivery)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.RuralRoute)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode4)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ShipAddresses)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipAddresses_LineItemId_LineItems_LineItemId");
            });

            modelBuilder.Entity<ShipItemDetails>(entity =>
            {
                entity.HasKey(e => new { e.ItemDetailId, e.ShipLineItemId, e.ShipItemDetailId });

                entity.HasIndex(e => e.ShipItemDetailId)
                    .HasName("unq_ShipItemDetails_ShipItemDetailId")
                    .IsUnique();

                entity.Property(e => e.ShipItemDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Esn)
                    .HasColumnName("ESN")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iccid)
                    .HasColumnName("ICCID")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Meid)
                    .HasColumnName("MEID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SimItemCode)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.SimNumber)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemDetail)
                    .WithMany(p => p.ShipItemDetails)
                    .HasPrincipalKey(p => p.ItemDetailId)
                    .HasForeignKey(d => d.ItemDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipItemDetails_ItemDetailId_ItemDetails_ItemDetailId");

                entity.HasOne(d => d.ShipLineItem)
                    .WithMany(p => p.ShipItemDetails)
                    .HasPrincipalKey(p => p.ShipLineItemId)
                    .HasForeignKey(d => d.ShipLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipItemDetails_ShipLineItemId_ShipLineItems_ShipLineItemId");
            });

            modelBuilder.Entity<ShipLineItems>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.ShipLineItemId });

                entity.HasIndex(e => e.ShipLineItemId)
                    .HasName("unq_ShipLineItems_ShipLineItemId")
                    .IsUnique();

                entity.Property(e => e.ShipLineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnTrackingNumber)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnVendor)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.SalesId)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipVendor)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ShipLineItems)
                    .HasPrincipalKey(p => p.LineItemId)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipLineItems_LineItemId_LineItems_LineItemId");
            });
        }
    }
}
