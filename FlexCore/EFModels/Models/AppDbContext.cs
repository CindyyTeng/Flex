﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFModels.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityCategory> ActivityCategories { get; set; }
        public virtual DbSet<ActivityImg> ActivityImgs { get; set; }
        public virtual DbSet<ActivityStatus> ActivityStatuses { get; set; }
        public virtual DbSet<AlternateAddress> AlternateAddresses { get; set; }
        public virtual DbSet<BlackList> BlackLists { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<ColorCategory> ColorCategories { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponCategory> CouponCategories { get; set; }
        public virtual DbSet<CouponSending> CouponSendings { get; set; }
        public virtual DbSet<CustomizedOrder> CustomizedOrders { get; set; }
        public virtual DbSet<CustomizedShoesPo> CustomizedShoesPos { get; set; }
        public virtual DbSet<Customized_material> Customized_materials { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<JobTitle> JobTitles { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberPoint> MemberPoints { get; set; }
        public virtual DbSet<MembershipLevel> MembershipLevels { get; set; }
        public virtual DbSet<OneToOneReservation> OneToOneReservations { get; set; }
        public virtual DbSet<PointHistory> PointHistories { get; set; }
        public virtual DbSet<PointManage> PointManages { get; set; }
        public virtual DbSet<PointTradeIn> PointTradeIns { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductImg> ProductImgs { get; set; }
        public virtual DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public virtual DbSet<ProjectTag> ProjectTags { get; set; }
        public virtual DbSet<ProjectTagItem> ProjectTagItems { get; set; }
        public virtual DbSet<ReservationImg> ReservationImgs { get; set; }
        public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<ReturnReson> ReturnResons { get; set; }
        public virtual DbSet<SalesCategory> SalesCategories { get; set; }
        public virtual DbSet<ShoesCategory> ShoesCategories { get; set; }
        public virtual DbSet<ShoesChoose> ShoesChooses { get; set; }
        public virtual DbSet<ShoesColorCategory> ShoesColorCategories { get; set; }
        public virtual DbSet<ShoesGroup> ShoesGroups { get; set; }
        public virtual DbSet<ShoesOrder> ShoesOrders { get; set; }
        public virtual DbSet<ShoesPicture> ShoesPictures { get; set; }
        public virtual DbSet<ShoesSize> ShoesSizes { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<SizeCategory> SizeCategories { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<SpeakerField> SpeakerFields { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StaffPermission> StaffPermissions { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<logistics_company> logistics_companies { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<orderItem> orderItems { get; set; }
        public virtual DbSet<order_status> order_statuses { get; set; }
        public virtual DbSet<pay_method> pay_methods { get; set; }
        public virtual DbSet<pay_status> pay_statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Flex;Persist Security Info=True;User ID=sa5;Password=sa5");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.fk_ActivityStatusId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.fk_ActivityCategory)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.fk_ActivityCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Activitie__fk_Ac__3D2915A8");

                entity.HasOne(d => d.fk_ActivityStatus)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.fk_ActivityStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Activitie__fk_Ac__3E1D39E1");

                entity.HasOne(d => d.fk_Speaker)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.fk_SpeakerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Activitie__fk_Sp__3F115E1A");
            });

            modelBuilder.Entity<ActivityImg>(entity =>
            {
                entity.HasOne(d => d.fk_Activity)
                    .WithMany(p => p.ActivityImgs)
                    .HasForeignKey(d => d.fk_ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ActivityI__fk_Ac__4F47C5E3");
            });

            modelBuilder.Entity<AlternateAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__Alternat__091C2AFBD3B2ED1E");

                entity.HasOne(d => d.fk_Member)
                    .WithOne(p => p.AlternateAddress)
                    .HasForeignKey<AlternateAddress>(d => d.fk_MemberId)
                    .HasConstraintName("FK__Alternate__fk_Me__3D2915A8");
            });

            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasOne(d => d.fk_Card)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.fk_CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItem_CartItem");

                entity.HasOne(d => d.fk_Product)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.fk_ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItems_ProductGroups");
            });

            modelBuilder.Entity<ColorCategory>(entity =>
            {
                entity.HasKey(e => e.ColorId)
                    .HasName("PK_ColorCategory");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.fk_CouponCategory)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.fk_CouponCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_CouponCategory");

                entity.HasOne(d => d.fk_RequiredProjectTag)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.fk_RequiredProjectTagID)
                    .HasConstraintName("FK_Coupon_ProjectTag");
            });

            modelBuilder.Entity<CouponCategory>(entity =>
            {
                entity.Property(e => e.CouponCategoryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CouponSending>(entity =>
            {
                entity.HasKey(e => e.SendingId)
                    .HasName("PK_CouponSending");

                entity.HasOne(d => d.fk_Coupon)
                    .WithMany(p => p.CouponSendings)
                    .HasForeignKey(d => d.fk_CouponId)
                    .HasConstraintName("FK_CouponSending_Coupon");

                entity.HasOne(d => d.fk_Member)
                    .WithMany(p => p.CouponSendings)
                    .HasForeignKey(d => d.fk_MemberId)
                    .HasConstraintName("FK_CouponSendings_Members");
            });

            modelBuilder.Entity<CustomizedOrder>(entity =>
            {
                entity.HasKey(e => e.Customized_Id)
                    .HasName("PK__Customiz__AFADABDDD46DF52E");

                entity.HasOne(d => d.Customized_EdgeProtectionNavigation)
                    .WithMany(p => p.CustomizedOrderCustomized_EdgeProtectionNavigations)
                    .HasForeignKey(d => d.Customized_EdgeProtection)
                    .HasConstraintName("FK__Customize__Custo__58D1301D");

                entity.HasOne(d => d.Customized_EyeletNavigation)
                    .WithMany(p => p.CustomizedOrderCustomized_EyeletNavigations)
                    .HasForeignKey(d => d.Customized_Eyelet)
                    .HasConstraintName("FK__Customize__Custo__57DD0BE4");

                entity.HasOne(d => d.Customized_RearNavigation)
                    .WithMany(p => p.CustomizedOrderCustomized_RearNavigations)
                    .HasForeignKey(d => d.Customized_Rear)
                    .HasConstraintName("FK__Customize__Custo__59C55456");

                entity.HasOne(d => d.Customized_Shoes)
                    .WithMany(p => p.CustomizedOrders)
                    .HasForeignKey(d => d.Customized_Shoes_Id)
                    .HasConstraintName("FK__Customize__Custo__46B27FE2");

                entity.HasOne(d => d.Customized_ToeNavigation)
                    .WithMany(p => p.CustomizedOrderCustomized_ToeNavigations)
                    .HasForeignKey(d => d.Customized_Toe)
                    .HasConstraintName("FK__Customize__Custo__5BAD9CC8");

                entity.HasOne(d => d.Customized_TongueNavigation)
                    .WithMany(p => p.CustomizedOrderCustomized_TongueNavigations)
                    .HasForeignKey(d => d.Customized_Tongue)
                    .HasConstraintName("FK__Customize__Custo__5AB9788F");

                entity.HasOne(d => d.Fk_ForMemberCustomized)
                    .WithMany(p => p.CustomizedOrders)
                    .HasForeignKey(d => d.Fk_ForMemberCustomized_Id)
                    .HasConstraintName("FK_CustomizedOrders_Members");
            });

            modelBuilder.Entity<CustomizedShoesPo>(entity =>
            {
                entity.HasKey(e => e.ShoesProductId)
                    .HasName("PK__Customiz__D7D2FD91792B994F");

                entity.Property(e => e.DataCreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataEditTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("('false')");

                entity.HasOne(d => d.fk_ShoesCategory)
                    .WithMany(p => p.CustomizedShoesPos)
                    .HasForeignKey(d => d.fk_ShoesCategoryId)
                    .HasConstraintName("FK__Customize__fk_Sh__44CA3770");

                entity.HasOne(d => d.fk_ShoesColor)
                    .WithMany(p => p.CustomizedShoesPos)
                    .HasForeignKey(d => d.fk_ShoesColorId)
                    .HasConstraintName("FK__Customize__fk_Sh__45BE5BA9");
            });

            modelBuilder.Entity<Customized_material>(entity =>
            {
                entity.HasKey(e => e.Shoesmaterial_Id)
                    .HasName("PK__Customiz__06EFE12D08FD4BDD");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.fk_ProjectTag)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.fk_ProjectTagId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Discount_DiscountGroup");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .HasName("PK__JobTitle__75758986DFA010AD");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Registration).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.fk_BlackList)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.fk_BlackListId)
                    .HasConstraintName("FK__Members__fk_Blac__503BEA1C");

                entity.HasOne(d => d.fk_Level)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.fk_LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Members__fk_Leve__00DF2177");
            });

            modelBuilder.Entity<MemberPoint>(entity =>
            {
                entity.HasKey(e => e.MemberPointsId)
                    .HasName("PK__MemberPo__8D672C97D8EFE351");

                entity.HasOne(d => d.fk_Member)
                    .WithOne(p => p.MemberPoint)
                    .HasForeignKey<MemberPoint>(d => d.fk_MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MemberPoi__fk_Me__4E53A1AA");
            });

            modelBuilder.Entity<MembershipLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .HasName("PK__Membersh__09F03C26F7CA5148");

                entity.HasMany(d => d.fk_Privileges)
                    .WithMany(p => p.fk_Levels)
                    .UsingEntity<Dictionary<string, object>>(
                        "MembershipLevelPrivilege",
                        l => l.HasOne<Privilege>().WithMany().HasForeignKey("fk_PrivilegeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Membershi__fk_Pr__531856C7"),
                        r => r.HasOne<MembershipLevel>().WithMany().HasForeignKey("fk_LevelId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Membershi__fk_Le__01D345B0"),
                        j =>
                        {
                            j.HasKey("fk_LevelId", "fk_PrivilegeId").HasName("PK__Membersh__580C8EAA7D40AD22");

                            j.ToTable("MembershipLevelPrivileges");
                        });
            });

            modelBuilder.Entity<OneToOneReservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__OneToOne__B7EE5F2435594BE1");

                entity.Property(e => e.ReservationCreatedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.fk_Booker)
                    .WithMany(p => p.OneToOneReservations)
                    .HasForeignKey(d => d.fk_BookerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OneToOneReservations_Members");

                entity.HasOne(d => d.fk_Branch)
                    .WithMany(p => p.OneToOneReservations)
                    .HasForeignKey(d => d.fk_BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OneToOneR__fk_Br__65370702");

                entity.HasOne(d => d.fk_ReservationSpeaker)
                    .WithMany(p => p.OneToOneReservations)
                    .HasForeignKey(d => d.fk_ReservationSpeakerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OneToOneR__fk_Re__662B2B3B");

                entity.HasOne(d => d.fk_ReservationStatus)
                    .WithMany(p => p.OneToOneReservations)
                    .HasForeignKey(d => d.fk_ReservationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OneToOneR__fk_Re__671F4F74");
            });

            modelBuilder.Entity<PointHistory>(entity =>
            {
                entity.Property(e => e.EffectiveDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.fk_Member)
                    .WithMany(p => p.PointHistories)
                    .HasForeignKey(d => d.fk_MemberId)
                    .HasConstraintName("FK__PointHist__fk_Me__03BB8E22");

                entity.HasOne(d => d.fk_MemberPoints)
                    .WithMany(p => p.PointHistories)
                    .HasForeignKey(d => d.fk_MemberPointsId)
                    .HasConstraintName("FK_PointHistories_MemberPoints");

                entity.HasOne(d => d.fk_Order)
                    .WithMany(p => p.PointHistories)
                    .HasForeignKey(d => d.fk_OrderId)
                    .HasConstraintName("FK_PointHistories_orders");

                entity.HasOne(d => d.fk_Type)
                    .WithMany(p => p.PointHistories)
                    .HasForeignKey(d => d.fk_TypeId)
                    .HasConstraintName("FK_PointHistories_Type");
            });

            modelBuilder.Entity<PointManage>(entity =>
            {
                entity.HasOne(d => d.fk_Type)
                    .WithMany(p => p.PointManages)
                    .HasForeignKey(d => d.fk_TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PointManage_Type");
            });

            modelBuilder.Entity<PointTradeIn>(entity =>
            {
                entity.Property(e => e.EffectiveDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.fk_Member)
                    .WithMany(p => p.PointTradeIns)
                    .HasForeignKey(d => d.fk_MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PointTradeIn_Members");

                entity.HasOne(d => d.fk_Order)
                    .WithMany(p => p.PointTradeIns)
                    .HasForeignKey(d => d.fk_OrderId)
                    .HasConstraintName("FK_PointTradeIn_orders");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasDefaultValueSql("('unique')");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("('false')");

                entity.HasOne(d => d.fk_ProductSubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.fk_ProductSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductSubCategory");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasOne(d => d.fk_SalesCategory)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.fk_SalesCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_SalesCategories");
            });

            modelBuilder.Entity<ProductComment>(entity =>
            {
                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.fk_Member)
                    .WithMany()
                    .HasForeignKey(d => d.fk_MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComment_Members");

                entity.HasOne(d => d.fk_ProductGroup)
                    .WithMany()
                    .HasForeignKey(d => d.fk_ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComment_ProductGroups");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasOne(d => d.fk_Color)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.fk_ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroups_ColorCategories");

                entity.HasOne(d => d.fk_Product)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.fk_ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroups_Products");

                entity.HasOne(d => d.fk_Size)
                    .WithMany(p => p.ProductGroups)
                    .HasForeignKey(d => d.fk_SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroups_SizeCategories");
            });

            modelBuilder.Entity<ProductImg>(entity =>
            {
                entity.HasOne(d => d.fk_Color)
                    .WithMany(p => p.ProductImgs)
                    .HasForeignKey(d => d.fk_ColorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ProductImgs_ColorCategories");

                entity.HasOne(d => d.fk_Product)
                    .WithMany(p => p.ProductImgs)
                    .HasForeignKey(d => d.fk_ProductId)
                    .HasConstraintName("FK_ProductImgs_Products");
            });

            modelBuilder.Entity<ProductSubCategory>(entity =>
            {
                entity.HasOne(d => d.fk_ProductCategory)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.fk_ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategories_ProductCategories");
            });

            modelBuilder.Entity<ProjectTag>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProjectTagItem>(entity =>
            {
                entity.HasKey(e => new { e.fk_ProjectTagId, e.fk_ProductId })
                    .HasName("PK_discount_group_item");

                entity.HasOne(d => d.fk_Product)
                    .WithMany(p => p.ProjectTagItems)
                    .HasForeignKey(d => d.fk_ProductId)
                    .HasConstraintName("FK_discount_group_item_discount_group");
            });

            modelBuilder.Entity<ReservationStatus>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__Reservat__B7EE5F24CB6ABED3");

                entity.Property(e => e.ReservationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.HasOne(d => d.fk訂單Navigation)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.fk訂單)
                    .HasConstraintName("FK_Returns_orders");

                entity.HasOne(d => d.退貨理由Navigation)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.退貨理由)
                    .HasConstraintName("FK_Returns_ReturnResons");
            });

            modelBuilder.Entity<ReturnReson>(entity =>
            {
                entity.Property(e => e.退貨理由).IsFixedLength();
            });

            modelBuilder.Entity<ShoesColorCategory>(entity =>
            {
                entity.HasKey(e => e.ShoesColorId)
                    .HasName("PK__ShoesCol__BB1469D459E0152F");
            });

            modelBuilder.Entity<ShoesGroup>(entity =>
            {
                entity.HasOne(d => d.fk_CustomerOrder)
                    .WithMany(p => p.ShoesGroups)
                    .HasForeignKey(d => d.fk_CustomerOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoesGroups_ShoesOrders");

                entity.HasOne(d => d.fk_Material)
                    .WithMany(p => p.ShoesGroups)
                    .HasForeignKey(d => d.fk_MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoesGroups_Customized_materials");

                entity.HasOne(d => d.fk_Option)
                    .WithMany(p => p.ShoesGroups)
                    .HasForeignKey(d => d.fk_OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoesGroups_ShoesChooses");

                entity.HasOne(d => d.fk_ShoesColor)
                    .WithMany(p => p.ShoesGroups)
                    .HasForeignKey(d => d.fk_ShoesColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoesGroups_ShoesColorCategories");

                entity.HasOne(d => d.fk_ShoesMain)
                    .WithMany(p => p.ShoesGroups)
                    .HasForeignKey(d => d.fk_ShoesMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoesGroups_CustomizedShoesPo");
            });

            modelBuilder.Entity<ShoesOrder>(entity =>
            {
                entity.HasOne(d => d.fk_ShoesSize)
                    .WithMany(p => p.ShoesOrders)
                    .HasForeignKey(d => d.fk_ShoesSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShoesOrde__fk_Sh__0C50D423");
            });

            modelBuilder.Entity<ShoesPicture>(entity =>
            {
                entity.HasKey(e => e.ShoesPicture_Id)
                    .HasName("PK__ShoesPic__DF35EBA4A34BE74D");

                entity.HasOne(d => d.fk_ShoesPictureProduct)
                    .WithMany(p => p.ShoesPictures)
                    .HasForeignKey(d => d.fk_ShoesPictureProduct_Id)
                    .HasConstraintName("FK__ShoesPict__fk_Sh__70A8B9AE");
            });

            modelBuilder.Entity<ShoesSize>(entity =>
            {
                entity.HasKey(e => e.SizeId)
                    .HasName("PK__ShoesSiz__83BD097A657225D0");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK_ShoppingCart");

                entity.HasOne(d => d.fk_Member)
                    .WithMany(p => p.ShoppingCarts)
                    .HasForeignKey(d => d.fk_MemberID)
                    .HasConstraintName("FK_ShoppingCarts_Members");
            });

            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.HasOne(d => d.fk_SpeakerBranch)
                    .WithMany(p => p.Speakers)
                    .HasForeignKey(d => d.fk_SpeakerBranchId)
                    .HasConstraintName("FK__Speakers__fk_Spe__0F2D40CE");

                entity.HasOne(d => d.fk_SpeakerField)
                    .WithMany(p => p.Speakers)
                    .HasForeignKey(d => d.fk_SpeakerFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Speakers__fk_Spe__10216507");
            });

            modelBuilder.Entity<SpeakerField>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PK__SpeakerF__C8B6FF0730B2B9D7");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.DueDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.fk_Department)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.fk_DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staffs__fk_Depar__74794A92");

                entity.HasOne(d => d.fk_Permissions)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.fk_PermissionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staffs__fk_Permi__756D6ECB");

                entity.HasOne(d => d.fk_Title)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.fk_TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staffs__fk_Title__76619304");
            });

            modelBuilder.Entity<StaffPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionsId)
                    .HasName("PK__StaffPer__1EDAF9A81349059A");
            });

            modelBuilder.Entity<order>(entity =>
            {
                entity.HasOne(d => d.fk_member)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.fk_member_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__fk_membe__5BAD9CC8");

                entity.HasOne(d => d.fk_type)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.fk_typeId)
                    .HasConstraintName("FK_orders_Type");

                entity.HasOne(d => d.logistics_company)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.logistics_company_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__logistic__5BAD9CC8");

                entity.HasOne(d => d.order_status)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.order_status_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__order_st__5CA1C101");

                entity.HasOne(d => d.pay_method)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.pay_method_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__pay_meth__5D95E53A");

                entity.HasOne(d => d.pay_status)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.pay_status_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__pay_stat__5E8A0973");
            });

            modelBuilder.Entity<orderItem>(entity =>
            {
                entity.HasOne(d => d.fk_type)
                    .WithMany(p => p.orderItems)
                    .HasForeignKey(d => d.fk_typeId)
                    .HasConstraintName("FK_orderItems_Type");

                entity.HasOne(d => d.order)
                    .WithMany(p => p.orderItems)
                    .HasForeignKey(d => d.order_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orderItem__order__1B9317B3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}