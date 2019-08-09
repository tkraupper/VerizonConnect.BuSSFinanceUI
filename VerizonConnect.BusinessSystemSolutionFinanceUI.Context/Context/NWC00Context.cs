// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI.Entities
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="NWC00Context.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BusinessSystemSolutionFinanceUI.Context.NWC00
{
    using Microsoft.EntityFrameworkCore;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Entities.NWC00;

    /// <summary>
    /// Context class for the NWC00 database
    /// </summary>
    public class NWC00Context : DbContext
    {
        public NWC00Context()
        {
        }

        public NWC00Context(DbContextOptions<NWC00Context> options)
            : base(options)
        {
        }

        // Setting all of the DbContext's for the different tables in the NWC00 Database
        public virtual DbSet<Ext01100> Ext01100 { get; set; }
        public virtual DbSet<Rm00101> Rm00101 { get; set; }

        /// <summary>
        /// VALIDATIONS FOR MODELS
        /// </summary>
        /// <param name="modelBuilder">Instantiates the ModelBuilder object that.... Helps build the models..</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ext01100>(entity =>
            {
                entity.HasKey(e => e.ExtenderRecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("EXT01100");

                entity.Property(e => e.ExtenderRecordId)
                    .HasColumnName("Extender_Record_ID")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Creatddt)
                    .HasColumnName("CREATDDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Crusrid)
                    .IsRequired()
                    .HasColumnName("CRUSRID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.DexRowId)
                    .HasColumnName("DEX_ROW_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExtenderKeyValues1)
                    .IsRequired()
                    .HasColumnName("Extender_Key_Values_1")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.ExtenderKeyValues2)
                    .IsRequired()
                    .HasColumnName("Extender_Key_Values_2")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.ExtenderKeyValues3)
                    .IsRequired()
                    .HasColumnName("Extender_Key_Values_3")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.ExtenderKeyValues4)
                    .IsRequired()
                    .HasColumnName("Extender_Key_Values_4")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.ExtenderKeyValues5)
                    .IsRequired()
                    .HasColumnName("Extender_Key_Values_5")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.ExtenderWindowId)
                    .IsRequired()
                    .HasColumnName("Extender_Window_ID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Mdfusrid)
                    .IsRequired()
                    .HasColumnName("MDFUSRID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Modifdt)
                    .HasColumnName("MODIFDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Noteindx)
                    .HasColumnName("NOTEINDX")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");
            });

            modelBuilder.Entity<Rm00101>(entity =>
            {
                entity.HasKey(e => e.Custnmbr)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RM00101");

                entity.HasIndex(e => new { e.Cprcstnm, e.Custnmbr })
                    .HasName("AK7RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Custclas, e.Custnmbr })
                    .HasName("AK3RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Custname, e.DexRowId })
                    .HasName("AK2RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Salsterr, e.Custnmbr })
                    .HasName("AK6RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Slprsnid, e.Custnmbr })
                    .HasName("AK5RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Txrgnnum, e.Custnmbr })
                    .HasName("AK8RM00101")
                    .IsUnique();

                entity.HasIndex(e => new { e.Userdef1, e.Custnmbr })
                    .HasName("AK4RM00101")
                    .IsUnique();

                entity.Property(e => e.Custnmbr)
                    .HasColumnName("CUSTNMBR")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasColumnName("ADDRESS3")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Adrscode)
                    .IsRequired()
                    .HasColumnName("ADRSCODE")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Balnctyp)
                    .HasColumnName("BALNCTYP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Bankname)
                    .IsRequired()
                    .HasColumnName("BANKNAME")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Bnkbrnch)
                    .IsRequired()
                    .HasColumnName("BNKBRNCH")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Cbvat)
                    .HasColumnName("CBVAT")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Ccode)
                    .IsRequired()
                    .HasColumnName("CCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Ccrdxpdt)
                    .HasColumnName("CCRDXPDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Chekbkid)
                    .IsRequired()
                    .HasColumnName("CHEKBKID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Cntcprsn)
                    .IsRequired()
                    .HasColumnName("CNTCPRSN")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Comment1)
                    .IsRequired()
                    .HasColumnName("COMMENT1")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Comment2)
                    .IsRequired()
                    .HasColumnName("COMMENT2")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Cprcstnm)
                    .IsRequired()
                    .HasColumnName("CPRCSTNM")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Crcardid)
                    .IsRequired()
                    .HasColumnName("CRCARDID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Crcrdnum)
                    .IsRequired()
                    .HasColumnName("CRCRDNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Creatddt)
                    .HasColumnName("CREATDDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Crlmtamt)
                    .HasColumnName("CRLMTAMT")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Crlmtpam)
                    .HasColumnName("CRLMTPAM")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Crlmtper)
                    .HasColumnName("CRLMTPER")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Crlmttyp)
                    .HasColumnName("CRLMTTYP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Curncyid)
                    .IsRequired()
                    .HasColumnName("CURNCYID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Custclas)
                    .IsRequired()
                    .HasColumnName("CUSTCLAS")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Custdisc)
                    .HasColumnName("CUSTDISC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Custname)
                    .IsRequired()
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Custpriority)
                    .HasColumnName("CUSTPRIORITY")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Declid)
                    .IsRequired()
                    .HasColumnName("DECLID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Defcacty)
                    .HasColumnName("DEFCACTY")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.DexRowId)
                    .HasColumnName("DEX_ROW_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DexRowTs)
                    .HasColumnName("DEX_ROW_TS")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Disgrper)
                    .HasColumnName("DISGRPER")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Docfmtid)
                    .IsRequired()
                    .HasColumnName("DOCFMTID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Duegrper)
                    .HasColumnName("DUEGRPER")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Finchdlr)
                    .HasColumnName("FINCHDLR")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Finchid)
                    .IsRequired()
                    .HasColumnName("FINCHID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Fnchatyp)
                    .HasColumnName("FNCHATYP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Fnchpcnt)
                    .HasColumnName("FNCHPCNT")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Frstindt)
                    .HasColumnName("FRSTINDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Govcrpid)
                    .IsRequired()
                    .HasColumnName("GOVCRPID")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Govindid)
                    .IsRequired()
                    .HasColumnName("GOVINDID")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Gpsfointegrationid)
                    .IsRequired()
                    .HasColumnName("GPSFOINTEGRATIONID")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Hold)
                    .HasColumnName("HOLD")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Inactive)
                    .HasColumnName("INACTIVE")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Includeindp)
                    .HasColumnName("INCLUDEINDP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Integrationid)
                    .IsRequired()
                    .HasColumnName("INTEGRATIONID")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Integrationsource)
                    .HasColumnName("INTEGRATIONSOURCE")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Kpcalhst)
                    .HasColumnName("KPCALHST")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Kpdsthst)
                    .HasColumnName("KPDSTHST")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Kperhist)
                    .HasColumnName("KPERHIST")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Kptrxhst)
                    .HasColumnName("KPTRXHST")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Minpydlr)
                    .HasColumnName("MINPYDLR")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Minpypct)
                    .HasColumnName("MINPYPCT")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Minpytyp)
                    .HasColumnName("MINPYTYP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Modifdt)
                    .HasColumnName("MODIFDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(" create default dbo.GPS_DATE AS '1/1/1900'    ");

                entity.Property(e => e.Mxwoftyp)
                    .HasColumnName("MXWOFTYP")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Mxwrofam)
                    .HasColumnName("MXWROFAM")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Noteindx)
                    .HasColumnName("NOTEINDX")
                    .HasColumnType("numeric(19, 5)")
                    .HasDefaultValueSql(" create default dbo.GPS_MONEY AS 0.00    ");

                entity.Property(e => e.Orderfulfilldefault)
                    .HasColumnName("ORDERFULFILLDEFAULT")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("PHONE1")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("PHONE2")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Phone3)
                    .IsRequired()
                    .HasColumnName("PHONE3")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.PostResultsTo)
                    .HasColumnName("Post_Results_To")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Prbtadcd)
                    .IsRequired()
                    .HasColumnName("PRBTADCD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Prclevel)
                    .IsRequired()
                    .HasColumnName("PRCLEVEL")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Prstadcd)
                    .IsRequired()
                    .HasColumnName("PRSTADCD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Pymtrmid)
                    .IsRequired()
                    .HasColumnName("PYMTRMID")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Ratetpid)
                    .IsRequired()
                    .HasColumnName("RATETPID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.RevalueCustomer)
                    .HasColumnName("Revalue_Customer")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmaracc)
                    .HasColumnName("RMARACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmavacc)
                    .HasColumnName("RMAVACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmcosacc)
                    .HasColumnName("RMCOSACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmcshacc)
                    .HasColumnName("RMCSHACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmfcgacc)
                    .HasColumnName("RMFCGACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmivacc)
                    .HasColumnName("RMIVACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.RmovrpymtWrtoffAcctIdx)
                    .HasColumnName("RMOvrpymtWrtoffAcctIdx")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmslsacc)
                    .HasColumnName("RMSLSACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmsoracc)
                    .HasColumnName("RMSORACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmtakacc)
                    .HasColumnName("RMTAKACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Rmwracc)
                    .HasColumnName("RMWRACC")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Salsterr)
                    .IsRequired()
                    .HasColumnName("SALSTERR")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.SendEmailStatements)
                    .HasColumnName("Send_Email_Statements")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Shipcomplete)
                    .HasColumnName("SHIPCOMPLETE")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Shipmthd)
                    .IsRequired()
                    .HasColumnName("SHIPMTHD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Shrtname)
                    .IsRequired()
                    .HasColumnName("SHRTNAME")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Slprsnid)
                    .IsRequired()
                    .HasColumnName("SLPRSNID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Staddrcd)
                    .IsRequired()
                    .HasColumnName("STADDRCD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Stmtcycl)
                    .HasColumnName("STMTCYCL")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Stmtname)
                    .IsRequired()
                    .HasColumnName("STMTNAME")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Taxexmt1)
                    .IsRequired()
                    .HasColumnName("TAXEXMT1")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Taxexmt2)
                    .IsRequired()
                    .HasColumnName("TAXEXMT2")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Taxschid)
                    .IsRequired()
                    .HasColumnName("TAXSCHID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Txrgnnum)
                    .IsRequired()
                    .HasColumnName("TXRGNNUM")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Upszone)
                    .IsRequired()
                    .HasColumnName("UPSZONE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Userdef1)
                    .IsRequired()
                    .HasColumnName("USERDEF1")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Userdef2)
                    .IsRequired()
                    .HasColumnName("USERDEF2")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");

                entity.Property(e => e.Userlang)
                    .HasColumnName("USERLANG")
                    .HasDefaultValueSql(" create default dbo.GPS_INT AS 0    ");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("ZIP")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql(" create default dbo.GPS_CHAR AS ''    ");
            });
        }
    }
}
