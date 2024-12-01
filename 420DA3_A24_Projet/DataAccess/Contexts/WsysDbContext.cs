using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Utilities.Enums;
using System.Configuration;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<ShippingOrderProduct> ShippingOrderProducts { get; set; }
    public DbSet<Adresse> Adresses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Shipment> Shipments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase"].ConnectionString;
        _ = optionsBuilder
            .UseSqlServer(connString)
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        #region USER

        _ = modelBuilder.Entity<User>()
            .ToTable(nameof(this.Users))
            .HasKey(user => user.Id);

        _ = modelBuilder.Entity<User>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Id)
            .HasColumnName(nameof(User.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName(nameof(User.Username))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .HasMaxLength(User.USERNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName(nameof(User.PasswordHash))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .HasMaxLength(User.PASSWORDHASH_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName(nameof(User.EmployeeWarehouseId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName(nameof(User.DateCreated))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName(nameof(User.DateModified))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName(nameof(User.DateDeleted))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName(nameof(User.RowVersion))
            .HasColumnOrder(7)
            .IsRowVersion();


        _ = modelBuilder.Entity<User>()
            .HasOne(user => user.EmployeeWarehouse)
            .WithMany(warehouse => warehouse.WarehouseEmployees)
            .HasForeignKey(user => user.EmployeeWarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.CreatedShippingOrders)
            .WithOne(order => order.CreatorEmployee)
            .HasForeignKey(order => order.CreatorEmployeeId)
            .HasPrincipalKey(user => user.Id)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.FulfilledShippingOrders)
            .WithOne(order => order.FulfillerEmployee)
            .HasForeignKey(order => order.FulfillerEmployeeId)
            .HasPrincipalKey(user => user.Id)
            .IsRequired(false);

        #endregion

        #region ROLE

        _ = modelBuilder.Entity<Role>()
            .ToTable(nameof(this.Roles))
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .HasIndex(role => role.Name)
            .IsUnique(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName(nameof(Role.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Name)
            .HasColumnName(nameof(Role.Name))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.NAME_MAX_LENGTH})")
            .HasMaxLength(Role.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Description)
            .HasColumnName(nameof(Role.Description))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.DESCRIPTION_MAX_LENGTH})")
            .HasMaxLength(Role.DESCRIPTION_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName(nameof(Role.DateCreated))
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName(nameof(Role.DateModified))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName(nameof(Role.DateDeleted))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName(nameof(Role.RowVersion))
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion

        #region WAREHOUSE

        _ = modelBuilder.Entity<Warehouse>()
            .ToTable(nameof(this.Warehouses))
            .HasKey(warehouse => warehouse.Id);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.Id)
            .HasColumnName(nameof(Warehouse.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.Name)
            .HasColumnName(nameof(Warehouse.Name))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Warehouse.NameMaxLength})")
            .HasMaxLength(Warehouse.NameMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.AddressId)
            .HasColumnName(nameof(Warehouse.AddressId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateCreated)
            .HasColumnName(nameof(Warehouse.DateCreated))
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd()
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateModified)
            .HasColumnName(nameof(Warehouse.DateModified))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateDeleted)
            .HasColumnName(nameof(Warehouse.DateDeleted))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.RowVersion)
            .HasColumnName(nameof(Warehouse.RowVersion))
            .HasColumnOrder(6)
            .IsRowVersion();

        #endregion


        #region SHIPMENT

        _ = modelBuilder.Entity<Shipment>()
            .ToTable(nameof(this.Warehouses))
            .HasKey(warehouse => warehouse.Id);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.Id)
            .HasColumnName(nameof(Shipment.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingProvider)
            .HasColumnName(nameof(Shipment.ShippingProvider))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(32)")
            .HasConversion<string>()
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.TrackingNumber)
            .HasColumnName(nameof(Shipment.TrackingNumber))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Shipment.TrackingNumberMaxLength})")
            .HasMaxLength(Shipment.TrackingNumberMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingOrderId)
            .HasColumnName(nameof(Shipment.ShippingOrderId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateCreated)
            .HasColumnName(nameof(Shipment.DateCreated))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd()
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateModified)
            .HasColumnName(nameof(Shipment.DateModified))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateDeleted)
            .HasColumnName(nameof(Shipment.DateDeleted))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.RowVersion)
            .HasColumnName(nameof(Shipment.RowVersion))
            .HasColumnOrder(7)
            .IsRowVersion();


        #endregion

        #region SHIPPING_ORDER

        EnumToStringConverter<ShippingOrderStatusEnum> ShippingOrderStatusConverter = new EnumToStringConverter<ShippingOrderStatusEnum>();

        _ = modelBuilder.Entity<ShippingOrder>()
            .ToTable(nameof(this.ShippingOrders))
            .HasKey(so => so.Id);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.Id)
            .HasColumnName(nameof(ShippingOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.Status)
            .HasColumnName(nameof(ShippingOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(24)")
            .HasConversion(ShippingOrderStatusConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.SourceClientId)
            .HasColumnName(nameof(ShippingOrder.SourceClientId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.CreatorEmployeeId)
            .HasColumnName(nameof(ShippingOrder.CreatorEmployeeId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DestinationAddressId)
            .HasColumnName(nameof(ShippingOrder.DestinationAddressId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.FulfillerEmployeeId)
            .HasColumnName(nameof(ShippingOrder.FulfillerEmployeeId))
            .HasColumnOrder(5)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.ShippingDate)
            .HasColumnName(nameof(ShippingOrder.ShippingDate))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateCreated)
            .HasColumnName(nameof(ShippingOrder.DateCreated))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateModified)
            .HasColumnName(nameof(ShippingOrder.DateModified))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateDeleted)
            .HasColumnName(nameof(ShippingOrder.DateDeleted))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.RowVersion)
            .HasColumnName(nameof(ShippingOrder.RowVersion))
            .HasColumnOrder(10)
            .IsRowVersion();

        // TODO: @PROF Faire config des relations de ShippingOrder

        #endregion

        #region PURCHASE_ORDER

        EnumToStringConverter<PurchaseOrderStatusEnum> PurchaseOrderStatusConverter = new EnumToStringConverter<PurchaseOrderStatusEnum>();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .ToTable(nameof(this.PurchaseOrders))
            .HasKey(po => po.Id);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Id)
            .HasColumnName(nameof(PurchaseOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Status)
            .HasColumnName(nameof(PurchaseOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(24)")
            .HasConversion(PurchaseOrderStatusConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Quantity)
            .HasColumnName(nameof(PurchaseOrder.Quantity))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.OrderedProductId)
            .HasColumnName(nameof(PurchaseOrder.OrderedProductId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DestinationWarehouseId)
            .HasColumnName(nameof(PurchaseOrder.DestinationWarehouseId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.CompletionDate)
            .HasColumnName(nameof(PurchaseOrder.CompletionDate))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCreated)
            .HasColumnName(nameof(PurchaseOrder.DateCreated))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateModified)
            .HasColumnName(nameof(PurchaseOrder.DateModified))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateDeleted)
            .HasColumnName(nameof(PurchaseOrder.DateDeleted))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.RowVersion)
            .HasColumnName(nameof(PurchaseOrder.RowVersion))
            .HasColumnOrder(9)
            .IsRowVersion();

        // TODO: @PROF Faire config des relations de PurchaseOrder

        #endregion

        #region PIVOT - SHIPPING_ORDER_PRODUCTS (PIVOT)

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .ToTable(nameof(this.ShippingOrderProducts))
            .HasKey(sop => new { sop.ShippingOderId, sop.ProductId });

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.ShippingOderId)
            .HasColumnName(nameof(ShippingOrderProduct.ShippingOderId))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.ProductId)
            .HasColumnName(nameof(ShippingOrderProduct.ProductId))
            .HasColumnOrder(1)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.Quantity)
            .HasColumnName(nameof(ShippingOrderProduct.Quantity))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.RowVersion)
            .HasColumnName(nameof(ShippingOrderProduct.RowVersion))
            .HasColumnOrder(3)
            .IsRowVersion();


        // Relations un-à-plusieurs pour ShippingOrder à ShippingOrderProduct
        // et pour Product à ShippingOrderProduct

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .HasOne(sop => sop.ShippingOrder)
            .WithMany(so => so.ShippingOrderProducts)
            .HasForeignKey(sop => sop.ShippingOderId)
            .HasPrincipalKey(so => so.Id)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .HasOne(sop => sop.Product)
            .WithMany(product => product.ShippingOrderProducts)
            .HasForeignKey(sop => sop.ProductId)
            .HasPrincipalKey(p => p.Id)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion


        // TODO: @WHOLE_TEAM configurez vos entités ici

       // CLASSE ADRESSE
        _ = modelBuilder.Entity<Adresse>()
            .ToTable(nameof(this.Adresses))
            .HasKey(ad => ad.Id);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.Id)
            .HasColumnName(nameof(Adresse.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.Addressee)
            .HasColumnName(nameof(Adresse.Addressee))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Adresse.AdresseeMaxLength})")
            .HasMaxLength(Adresse.AdresseeMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.CivicNumber)
            .HasColumnName(nameof(Adresse.CivicNumber))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Adresse.CivicNumberMaxLength})")
            .HasMaxLength(Adresse.CivicNumberMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.Street)
            .HasColumnName(nameof(Adresse.Street))
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Adresse.StreetMaxLength})")
            .HasMaxLength(Adresse.StreetMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.City)
            .HasColumnName(nameof(Adresse.City))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Adresse.CityMaxLength})")
            .HasMaxLength(Adresse.CityMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.State)
            .HasColumnName(nameof(Adresse.State))
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Adresse.StateMaxLength})")
            .HasMaxLength(Adresse.StateMaxLength)
            .IsRequired(false);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.Country)
            .HasColumnName(nameof(Adresse.Country))
            .HasColumnOrder(6)
            .HasColumnType($"nvarchar({Adresse.CountryMaxLength})")
            .HasMaxLength(Adresse.CountryMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.PostalCode)
            .HasColumnName(nameof(Adresse.PostalCode))
            .HasColumnOrder(7)
            .HasColumnType($"nvarchar({Adresse.PostalCodeMaxLength})")
            .HasMaxLength(Adresse.PostalCodeMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.AddressType)
            .HasColumnName(nameof(Adresse.AddressType))
            .HasColumnOrder(8)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.DateCreated)
            .HasColumnName(nameof(Adresse.DateCreated))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.DateModified)
            .HasColumnName(nameof(Adresse.DateModified))
            .HasColumnOrder(10)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.DateDeleted)
            .HasColumnName(nameof(Adresse.DateDeleted))
            .HasColumnOrder(11)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Adresse>()
            .Property(ad => ad.RowVersion)
            .HasColumnName(nameof(Adresse.RowVersion))
            .HasColumnOrder(12)
            .IsRowVersion();

        _ = modelBuilder.Entity<Adresse>()
            .HasOne(ad => ad.OwnerWarehouse)
            .WithMany(warehouse => warehouse.Addresses)
            .HasForeignKey(ad => ad.OwnerWarehouse.Id)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<Adresse>()
            .HasOne(ad => ad.OwnerShipOrder)
            .WithMany(order => order.DestinationAddresses)
            .HasForeignKey(ad => ad.OwnerShipOrder.Id)
            .HasPrincipalKey(order => order.Id)
            .OnDelete(DeleteBehavior.Restrict);


          // CLASSE CLIENT

        _ = modelBuilder.Entity<Client>()
            .ToTable(nameof(this.Clients))
            .HasKey(client => client.Id);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.Id)
            .HasColumnName(nameof(Client.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ClientName)
            .HasColumnName(nameof(Client.ClientName))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Client.ClientNameMaxLength})")
            .HasMaxLength(Client.ClientNameMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactFirstName)
            .HasColumnName(nameof(Client.ContactFirstName))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Client.ContactFirstNameMaxLength})")
            .HasMaxLength(Client.ContactFirstNameMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactLastName)
            .HasColumnName(nameof(Client.ContactLastName))
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Client.ContactLastNameMaxLength})")
            .HasMaxLength(Client.ContactLastNameMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactEmail)
            .HasColumnName(nameof(Client.ContactEmail))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Client.ContactEmailMaxLength})")
            .HasMaxLength(Client.ContactEmailMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.ContactTelephone)
            .HasColumnName(nameof(Client.ContactTelephone))
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Client.ContactTelephoneMaxLength})")
            .HasMaxLength(Client.ContactTelephoneMaxLength)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.WarehouseId)
            .HasColumnName(nameof(Client.WarehouseId))
            .HasColumnOrder(6)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateCreated)
            .HasColumnName(nameof(Client.DateCreated))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateModified)
            .HasColumnName(nameof(Client.DateModified))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateDeleted)
            .HasColumnName(nameof(Client.DateDeleted))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .HasOne(client => client.AssignedWarehouse)
            .WithMany(warehouse => warehouse.Clients)
            .HasForeignKey(client => client.WarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.Restrict);

        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.Products)
            .WithOne(product => product.OwnerClient)
            .HasForeignKey(product => product.ClientId)
            .HasPrincipalKey(client => client.Id)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.ShippingOrders)
            .WithOne(order => order.SourceClient)
            .HasForeignKey(order => order.SourceClientId)
            .HasPrincipalKey(client => client.Id)
            .OnDelete(DeleteBehavior.Cascade);

      











        #region RELATIONS ET DONNÉES DE TEST

        // Warehouse ici


        // NOTE: le mot de passe des user est "testpasswd".
        User user1 = new User("UserAdmin", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 1
        };
        User user2 = new User("UserOffice", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 2
        };
        // TODO: @PROF assigner une warehouse à user3 quand une warehouse sera ajoutée.
        User user3 = new User("UserWarehouse", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 3
        };
        _ = modelBuilder.Entity<User>().HasData(user1, user2, user3);


        Role adminRole = new Role("Administrateurs",
            "Administrateurs tout-puissants."
        ) {
            Id = Role.ADMIN_ROLE_ID
        };
        Role officeEmployeesRole = new Role("Employés de bureau",
            "Employés travaillant dans les bureaux de WSYS Inc."
        ) {
            Id = Role.OFFICE_EMPLOYEE_ROLE_ID
        };
        Role whEmployeeRole = new Role("Employés d'entrepôt",
            "Employés travaillant dans les entrepôts de WSYS Inc."
        ) {
            Id = Role.WAREHOUSE_EMPLOYEE_ROLE_ID
        };
        _ = modelBuilder.Entity<Role>()
            .HasData(adminRole, officeEmployeesRole, whEmployeeRole);


        // NOTE: doit être placé après l'insertion de données pour User et pour Role
        // (besoin des IDs pour les associations)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.Users)
            .UsingEntity("UserRoles",
                rightRelation => {
                    return rightRelation
                    .HasOne(typeof(Role))
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .HasPrincipalKey(nameof(Role.Id))
                    .IsRequired(true)
                    .OnDelete(DeleteBehavior.Cascade);
                },
                leftRelation => {
                    return leftRelation
                    .HasOne(typeof(User))
                    .WithMany()
                    .HasForeignKey("UserId")
                    .HasPrincipalKey(nameof(User.Id))
                    .IsRequired(true)
                    .OnDelete(DeleteBehavior.Cascade);
                },
                shadowEntityConfig => {
                    _ = shadowEntityConfig.HasKey("UserId", "RoleId");
                    _ = shadowEntityConfig.HasData(
                    new { UserId = 1, RoleId = 1 },
                    new { UserId = 2, RoleId = 2 },
                    new { UserId = 3, RoleId = 3 });
                }
            );
        // Possiblement pas besoin de la relation inversion
        /*
        _ = modelBuilder.Entity<Role>()
            .HasMany(role => role.Users)
            .WithMany(user => user.Roles);
        */

        _ = modelBuilder.Entity<Warehouse>()
            .HasOne(warehouse => warehouse.Address)
            .WithOne(addr => addr.OwnerWarehouse)
            .HasForeignKey<Warehouse>(warehouse => warehouse.AddressId)
            .HasPrincipalKey<Adresse>(addr => addr.Id)
            .OnDelete(DeleteBehavior.Restrict);

        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.WarehouseEmployees)
            .WithOne(user => user.EmployeeWarehouse)
            .HasForeignKey(user => user.EmployeeWarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.WarehouseClients)
            .WithOne(client => client.Warehouse)
            .HasForeignKey(client => client.WarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id);

        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.RestockOrders)
            .WithOne(order => order.DestinationWarehouse)
            .HasForeignKey(order => order.DestinationWarehouseId)
            .HasPrincipalKey(warehouse => warehouse.Id);



        _ = modelBuilder.Entity<Shipment>()
            .HasOne(shipment => shipment.ShippingOrder)
            .WithOne(order => order.Shipment)
            .HasForeignKey<Shipment>(shipment => shipment.ShippingOrderId)
            .HasPrincipalKey<ShippingOrder>(order => order.Shipment)
            .OnDelete(DeleteBehavior.Restrict);


        #endregion

    }

}
