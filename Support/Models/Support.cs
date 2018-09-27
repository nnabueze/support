namespace Support.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class support : DbContext
    {
        public support()
            : base("name=support")
        {
        }

        public virtual DbSet<abuthpaymentitem> abuthpaymentitems { get; set; }
        public virtual DbSet<abuthpayment> abuthpayments { get; set; }
        public virtual DbSet<agent> agents { get; set; }
        public virtual DbSet<aspnetrole> aspnetroles { get; set; }
        public virtual DbSet<aspnetuserclaim> aspnetuserclaims { get; set; }
        public virtual DbSet<aspnetuser> aspnetusers { get; set; }
        public virtual DbSet<assessmenttable> assessmenttables { get; set; }
        public virtual DbSet<asset> assets { get; set; }
        public virtual DbSet<bank> banks { get; set; }
        public virtual DbSet<beneficiary> beneficiaries { get; set; }
        public virtual DbSet<buypowernotification> buypowernotifications { get; set; }
        public virtual DbSet<colortab> colortabs { get; set; }
        public virtual DbSet<conlog> conlogs { get; set; }
        public virtual DbSet<enumeration> enumerations { get; set; }
        public virtual DbSet<fundsweep> fundsweeps { get; set; }
        public virtual DbSet<igr> igrs { get; set; }
        public virtual DbSet<igr_categories> igr_categories { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<isnotification> isnotifications { get; set; }
        public virtual DbSet<jambpayment> jambpayments { get; set; }
        public virtual DbSet<jigawalog> jigawalogs { get; set; }
        public virtual DbSet<kedcopayment> kedcopayments { get; set; }
        public virtual DbSet<kingscare> kingscares { get; set; }
        public virtual DbSet<mda> mdas { get; set; }
        public virtual DbSet<mda_category> mda_category { get; set; }
        public virtual DbSet<mda_stations> mda_stations { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<oneclickpayment> oneclickpayments { get; set; }
        public virtual DbSet<payertype> payertypes { get; set; }
        public virtual DbSet<paymentnotification> paymentnotifications { get; set; }
        public virtual DbSet<pos> pos { get; set; }
        public virtual DbSet<pos_collection> pos_collection { get; set; }
        public virtual DbSet<power> powers { get; set; }
        public virtual DbSet<remittance> remittances { get; set; }
        public virtual DbSet<reportslisting> reportslistings { get; set; }
        public virtual DbSet<reportsparameter> reportsparameters { get; set; }
        public virtual DbSet<revenuehead> revenueheads { get; set; }
        public virtual DbSet<richfield> richfields { get; set; }
        public virtual DbSet<rserver> rservers { get; set; }
        public virtual DbSet<rssh_upload> rssh_upload { get; set; }
        public virtual DbSet<schoolclass> schoolclasses { get; set; }
        public virtual DbSet<schooldetail> schooldetails { get; set; }
        public virtual DbSet<schoolnotification> schoolnotifications { get; set; }
        public virtual DbSet<schoolsession> schoolsessions { get; set; }
        public virtual DbSet<schoolterm> schoolterms { get; set; }
        public virtual DbSet<student_information> student_information { get; set; }
        public virtual DbSet<subhead> subheads { get; set; }
        public virtual DbSet<taxpayer> taxpayers { get; set; }
        public virtual DbSet<tin> tins { get; set; }
        public virtual DbSet<valueswitchpayment> valueswitchpayments { get; set; }
        public virtual DbSet<web_collection> web_collection { get; set; }
        public virtual DbSet<aspnetuserlogin> aspnetuserlogins { get; set; }
        public virtual DbSet<pos_test_najib> pos_test_najib { get; set; }
        public virtual DbSet<igr_users> igr_users { get; set; }
        public virtual DbSet<vw_collections> vw_collections { get; set; }
        public virtual DbSet<vw_remittances> vw_remittances { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.TransId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.ServiceId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpaymentitem>()
                .Property(e => e.offlineTransId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.TransId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.PosId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.PatientName)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.RemittanceId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<abuthpayment>()
                .Property(e => e.offlineTransId)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.Agent_ID)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.AgentName)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.IsConsultant)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetrole>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetrole>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetrole>()
                .Property(e => e.Priviledges)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetrole>()
                .HasMany(e => e.aspnetusers)
                .WithMany(e => e.aspnetroles)
                .Map(m => m.ToTable("aspnetuserroles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnetuserclaim>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserclaim>()
                .Property(e => e.ClaimType)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserclaim>()
                .Property(e => e.ClaimValue)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.SecurityStamp)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.IGRCode)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.MDACode)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuser>()
                .Property(e => e.Pin)
                .IsUnicode(false);

            modelBuilder.Entity<assessmenttable>()
                .Property(e => e.AssessmentType)
                .IsUnicode(false);

            modelBuilder.Entity<assessmenttable>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<assessmenttable>()
                .Property(e => e.LGA)
                .IsUnicode(false);

            modelBuilder.Entity<assessmenttable>()
                .Property(e => e.AssessmentItem)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.AssetName)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.ImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.AssetType)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.LGA)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.IGR_Id)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .HasMany(e => e.assessmenttables)
                .WithOptional(e => e.asset1)
                .HasForeignKey(e => e.Asset);

            modelBuilder.Entity<bank>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<bank>()
                .Property(e => e.Bank_Code)
                .IsUnicode(false);

            modelBuilder.Entity<bank>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<bank>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<bank>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.Benefuciary_ID)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.Account_Number)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.BankID)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.Narration)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<beneficiary>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.BillerID)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.BillerName)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.SourceBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.DestinationBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.meterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.discoCode)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<buypowernotification>()
                .Property(e => e.vendRef)
                .IsUnicode(false);

            modelBuilder.Entity<colortab>()
                .Property(e => e.ColourName)
                .IsUnicode(false);

            modelBuilder.Entity<colortab>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<colortab>()
                .Property(e => e.AscentColour)
                .IsUnicode(false);

            modelBuilder.Entity<conlog>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Serial)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Enumerator)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.FeederName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.TransformerName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.TransfermerCode)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.PoleServiceWireRemark)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.PoleType)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.PoleCondition)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.WireType)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.WireCondition)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.PropertyType)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterTariff)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CspName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.ServiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustomerTitle)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustomerFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustomerLastName)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.HouseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.LandMark)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Village)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustomerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.FileMeterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Lga)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.CustormerRemark)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.AccountStatus)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.BookCode)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.AmountBilled)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterType)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterModel)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterStatus)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterPhase)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.MeterRemark)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.ImageId)
                .IsUnicode(false);

            modelBuilder.Entity<enumeration>()
                .Property(e => e.UniqueID)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Coll)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.SerialNo)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.SortCode)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Payee)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Payer)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Narration)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Agency)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.UploadId)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.BillerID)
                .IsUnicode(false);

            modelBuilder.Entity<fundsweep>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.IGR_Name)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.Dashboard)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.IS_IGRCode)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .Property(e => e.CategoryUrl)
                .IsUnicode(false);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.assessmenttables)
                .WithOptional(e => e.igr)
                .HasForeignKey(e => e.State);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.assets)
                .WithOptional(e => e.igr)
                .HasForeignKey(e => e.IGR_Id);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.taxpayers)
                .WithOptional(e => e.igr)
                .HasForeignKey(e => e.IGR_ID);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.reportslistings)
                .WithOptional(e => e.igr)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.mdas)
                .WithRequired(e => e.igr)
                .HasForeignKey(e => e.IGR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<igr>()
                .HasMany(e => e.revenueheads)
                .WithRequired(e => e.igr)
                .HasForeignKey(e => e.Biller_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<igr_categories>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.invoice_id)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<invoice>()
                .Property(e => e.Invoice_Status)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ServiceUrl)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ServiceUsername)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ServicePassword)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.FTPUrl)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.FTPUsername)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.FTPPassword)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ProductGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.PaymentLogId)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CustReference)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.AlternateCustReference)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.PaymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.PaymentReference)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ChannelName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.InstitutionId)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.InstitutionName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.FeeName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.OtherCustomerInfo)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ReceiptNo)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CollectionsAccount)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ThirdPartyCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.LeadBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.LeadBankCbnCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.LeadBankName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.ItemQuantity)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CustomerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.DepositorName)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.DepositorSlipNumber)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.PaymentCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.OriginalPaymentLogId)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.OriginalPaymentReference)
                .IsUnicode(false);

            modelBuilder.Entity<isnotification>()
                .Property(e => e.Teller)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.GSMNo)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<jambpayment>()
                .Property(e => e.Pin)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ServiceUrl)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ServiceUsername)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ServicePassword)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.FTPUrl)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.FTPUsername)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.FTPPassword)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ProductGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.PaymentLogId)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CustReference)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.AlternateCustReference)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.PaymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.PaymentReference)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ChannelName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.InstitutionId)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.InstitutionName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.FeeName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.OtherCustomerInfo)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CollectionsAccount)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ThirdPartyCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.LeadBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.LeadBankCbnCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.LeadBankName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.ItemQuantity)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CustomerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.DepositorName)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.DepositorSlipNumber)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.PaymentCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.OriginalPaymentLogId)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.OriginalPaymentReference)
                .IsUnicode(false);

            modelBuilder.Entity<jigawalog>()
                .Property(e => e.Teller)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.TransactionId)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.PosId)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.MeterType)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.TranactionDate)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.TransactionReference)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.LastTransactionDate)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.StationId)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.CustomerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.ReceiptNumber)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.TransactionType)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.CustomerArears)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.RemittanceId)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<kedcopayment>()
                .Property(e => e.tariffCode)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.TransactionDate)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.SourceBankName)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.DestinationBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.PupilsName)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.PayersName)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<kingscare>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.IGR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.MDA_Category)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.MDA_DetailedCategory)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.MDA_Name)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda>()
                .HasMany(e => e.assessmenttables)
                .WithOptional(e => e.mda)
                .HasForeignKey(e => e.LGA);

            modelBuilder.Entity<mda>()
                .HasMany(e => e.assets)
                .WithOptional(e => e.mda)
                .HasForeignKey(e => e.LGA);

            modelBuilder.Entity<mda>()
                .HasMany(e => e.taxpayers)
                .WithOptional(e => e.mda)
                .HasForeignKey(e => e.LocalGovernment);

            modelBuilder.Entity<mda>()
                .HasMany(e => e.mda_stations)
                .WithRequired(e => e.mda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mda>()
                .HasMany(e => e.revenueheads)
                .WithRequired(e => e.mda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mda_category>()
                .Property(e => e.Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mda_category>()
                .Property(e => e.Category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<mda_category>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda_category>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda_category>()
                .HasMany(e => e.mdas)
                .WithRequired(e => e.mda_category1)
                .HasForeignKey(e => e.MDA_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mda_stations>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mda_stations>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mda_stations>()
                .Property(e => e.MDAStation_Name)
                .IsUnicode(false);

            modelBuilder.Entity<mda_stations>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda_stations>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<mda_stations>()
                .HasMany(e => e.pos)
                .WithOptional(e => e.mda_stations)
                .HasForeignKey(e => e.Station_ID);

            modelBuilder.Entity<notification>()
                .Property(e => e.sessionID)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.SourceBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.DestinationBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.SourceBankName)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.payerid)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.tin)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.invoice_id)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.refcode)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.productType)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.PayerName)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.Disco)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.SourceBank)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.DestinationBank)
                .IsUnicode(false);

            modelBuilder.Entity<oneclickpayment>()
                .Property(e => e.MeterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<payertype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<payertype>()
                .HasMany(e => e.taxpayers)
                .WithOptional(e => e.payertype1)
                .HasForeignKey(e => e.PayerType);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.RequestorID)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.PayerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.PayerName)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.MerchantCode)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.MerchantName)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.MerchantPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.ReferenceCode)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.TransactionDate)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.ResponseCode)
                .IsUnicode(false);

            modelBuilder.Entity<paymentnotification>()
                .Property(e => e.sent_status)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.POS_imei)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.POS_Name)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.ActivationCode)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.Station_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pos>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.COLLECTION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.IGR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_collection>()
                .Property(e => e.PosCollectionId)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.SourceBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.SourceBankName)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.InstitutionCode)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.CustomerAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.BillerID)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.BillerName)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<power>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<remittance>()
                .Property(e => e.IGR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.ReportServerURL)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.MenuUrl)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .Property(e => e.RCredentials)
                .IsUnicode(false);

            modelBuilder.Entity<reportslisting>()
                .HasMany(e => e.igrs)
                .WithOptional(e => e.reportslisting)
                .HasForeignKey(e => e.Dashboard);

            modelBuilder.Entity<reportslisting>()
                .HasMany(e => e.reportsparameters)
                .WithRequired(e => e.reportslisting)
                .HasForeignKey(e => e.ReportID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<reportsparameter>()
                .Property(e => e.ReportID)
                .IsUnicode(false);

            modelBuilder.Entity<reportsparameter>()
                .Property(e => e.ReportParameterName)
                .IsUnicode(false);

            modelBuilder.Entity<reportsparameter>()
                .Property(e => e.DefaultValue)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.RevenueCode)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.Biller_ID)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.RevenueName)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.Taxable)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.AssmentItem)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .Property(e => e.IsPOS)
                .IsUnicode(false);

            modelBuilder.Entity<revenuehead>()
                .HasMany(e => e.subheads)
                .WithRequired(e => e.revenuehead)
                .HasForeignKey(e => e.RevHead_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.VehicleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.VehicleType)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.amount)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.DestinationBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.SourceBankName)
                .IsUnicode(false);

            modelBuilder.Entity<richfield>()
                .Property(e => e.TransactionDate)
                .IsUnicode(false);

            modelBuilder.Entity<rserver>()
                .Property(e => e.Rserver_ID)
                .IsUnicode(false);

            modelBuilder.Entity<rserver>()
                .Property(e => e.RServerName)
                .IsUnicode(false);

            modelBuilder.Entity<rserver>()
                .Property(e => e.RServerPwd)
                .IsUnicode(false);

            modelBuilder.Entity<rserver>()
                .Property(e => e.RserverDomain)
                .IsUnicode(false);

            modelBuilder.Entity<rserver>()
                .HasMany(e => e.reportslistings)
                .WithOptional(e => e.rserver)
                .HasForeignKey(e => e.RCredentials);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.Teller)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.InvoiceDate)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.UploadedBy)
                .IsUnicode(false);

            modelBuilder.Entity<rssh_upload>()
                .Property(e => e.UploadID)
                .IsUnicode(false);

            modelBuilder.Entity<schoolclass>()
                .Property(e => e.ClassId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolclass>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<schoolclass>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.AdmissionNo)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.Session)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.D_B)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.Rebait)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.BillerId)
                .IsUnicode(false);

            modelBuilder.Entity<schooldetail>()
                .Property(e => e.uploadId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.BillerId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.SourceBank)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.DestinationBank)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.PayerName)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.PayerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.AdmissionNo)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<schoolnotification>()
                .Property(e => e.Session)
                .IsUnicode(false);

            modelBuilder.Entity<schoolsession>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolsession>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<schoolsession>()
                .Property(e => e.SessionName)
                .IsUnicode(false);

            modelBuilder.Entity<schoolterm>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<schoolterm>()
                .Property(e => e.TermId)
                .IsUnicode(false);

            modelBuilder.Entity<schoolterm>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.AdmissionNo)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.ClassId)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.TermId)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.StudentType)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.Rebate)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<student_information>()
                .Property(e => e.uploadId)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.SubHead_Code)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.RevHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.SubHead_Name)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<subhead>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.TIN)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.OtherNames)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.BVN)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.IGR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.LocalGovernment)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<taxpayer>()
                .HasMany(e => e.assessmenttables)
                .WithOptional(e => e.taxpayer1)
                .HasForeignKey(e => e.TaxPayer);

            modelBuilder.Entity<taxpayer>()
                .HasMany(e => e.assets)
                .WithOptional(e => e.taxpayer1)
                .HasForeignKey(e => e.CompanyName);

            modelBuilder.Entity<taxpayer>()
                .HasMany(e => e.assets1)
                .WithOptional(e => e.taxpayer2)
                .HasForeignKey(e => e.TaxPayer);

            modelBuilder.Entity<tin>()
                .Property(e => e.tin_id)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.IGR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.tin_no)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.temporary_tin)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.identification)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.bussiness_type)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.bussinesss_name)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.bussiness_address)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.bussiness_no)
                .IsUnicode(false);

            modelBuilder.Entity<tin>()
                .Property(e => e.reg_bus_name)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.SourceBank)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.DestinationBank)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.BillerID)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.BillerName)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.CollectRef)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.Narration)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.CollectionTitle)
                .IsUnicode(false);

            modelBuilder.Entity<valueswitchpayment>()
                .Property(e => e.CollectionType)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.COLLECTION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<web_collection>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogin>()
                .Property(e => e.LoginProvider)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogin>()
                .Property(e => e.ProviderKey)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogin>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.COLLECTION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.SubHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.POS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<pos_test_najib>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.Priviledges)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.IGRCode)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.IGR_Name)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.MDACode)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.MDA_Name)
                .IsUnicode(false);

            modelBuilder.Entity<igr_users>()
                .Property(e => e.MDAStation_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.Collection_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.subhead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.MDAStation_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.pos_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.SubHead_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.SubHead_Code)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.RevenueCode)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.RevenueName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.Biller_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.RevenueHead_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.Remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.MDA_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_collections>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.Remittance_id)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.MDAStation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.MDAStation_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.pos_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.MDA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.MDA_Name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.Biller_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.remittance_status)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_remittances>()
                .Property(e => e.channel)
                .IsUnicode(false);
        }
    }
}
