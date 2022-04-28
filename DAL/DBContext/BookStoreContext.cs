using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressStatus> AddressStatus { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<BookCategory> BookCategory { get; set; }
        public virtual DbSet<BookLanguage> BookLanguage { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CustOrder> CustOrder { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<OrderHistory> OrderHistory { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=BookStore; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.StreetName)
                    .HasColumnName("street_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("street_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk_addr_ctry");
            });

            modelBuilder.Entity<AddressStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("pk_addr_status");

                entity.ToTable("address_status");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressStatus1)
                    .HasColumnName("address_status")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorName)
                    .HasColumnName("author_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Author)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("FK_author_utilisateur");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.BookId)
                    .HasColumnName("book_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Isbn13)
                    .HasColumnName("isbn13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.NumPages).HasColumnName("num_pages");

                entity.Property(e => e.Price).HasColumnName("Price").HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PublicationDate)
                    .HasColumnName("publication_date")
                    .HasColumnType("date");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_book_Cat");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("fk_book_lang");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("fk_book_pub");
            });

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.AuthorId })
                    .HasName("pk_bookauthor");

                entity.ToTable("book_author");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ba_author");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ba_book");
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("pk_book1");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BckgroundColor)
                    .HasColumnName("bckgroundColor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("pk_language");

                entity.ToTable("book_language");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .HasColumnName("language_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("pk_custorder");

                entity.ToTable("cust_order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DestAddressId).HasColumnName("dest_address_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShippingMethodId).HasColumnName("shipping_method_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_order_cust");

                entity.HasOne(d => d.DestAddress)
                    .WithMany(p => p.CustOrder)
                    .HasForeignKey(d => d.DestAddressId)
                    .HasConstraintName("fk_order_addr");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.CustOrder)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("fk_order_ship");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("FK_customer_utilisateur");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("pk_custaddr");

                entity.ToTable("customer_address");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ca_addr");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ca_cust");
            });

            modelBuilder.Entity<OrderHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("pk_orderhist");

                entity.ToTable("order_history");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderHistory)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_oh_order");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrderHistory)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("fk_oh_status");
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("pk_orderline");

                entity.ToTable("order_line");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("fk_ol_book");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_ol_order");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("pk_orderstatus");

                entity.ToTable("order_status");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusValue)
                    .HasColumnName("status_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("publisher");

                entity.Property(e => e.PublisherId)
                    .HasColumnName("publisher_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PublisherName)
                    .HasColumnName("publisher_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Publisher)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("FK_publisher_utilisateur");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.HasKey(e => e.MethodId)
                    .HasName("pk_shipmethod");

                entity.ToTable("shipping_method");

                entity.Property(e => e.MethodId)
                    .HasColumnName("method_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.MethodName)
                    .HasColumnName("method_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.MotPasse).HasMaxLength(250);

                entity.Property(e => e.Tel).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
