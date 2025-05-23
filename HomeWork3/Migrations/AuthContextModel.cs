﻿using System;
using System.Reflection.Emit;
using ControllerFirst.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControllerFirst.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControllerFirst.Data.Models.Role", b =>
            {
                b.Property<string>("RoleName")
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("roleName");

                b.HasKey("RoleName")
                    .HasName("PK__Roles__B19478603A776CCC");

                b.ToTable("Roles");
            });

            modelBuilder.Entity("ControllerFirst.Data.Models.User", b =>
            {
                b.Property<string>("UserName")
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("userName");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("email");

                b.Property<bool>("IsEmailConfirmed")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValue(false)
                    .HasColumnName("isEmailConfirmed");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("password");

                b.Property<Guid>("RefreshToken")
                    .HasColumnType("uniqueidentifier")
                    .HasColumnName("refreshToken");

                b.Property<DateTime>("RefreshTokenExpiration")
                    .HasColumnType("datetime2")
                    .HasColumnName("refreshTokenExpiration");

                b.HasKey("UserName")
                    .HasName("PK__Users__66DCF95D7E0943AE");

                b.HasIndex("RefreshToken")
                    .IsUnique()
                    .HasDatabaseName("UQ_RefreshToken");

                b.HasIndex(new[] { "Email" }, "UQ__Users__AB6E61646FB653B8")
                    .IsUnique();

                b.ToTable("Users");
            });

            modelBuilder.Entity("ControllerFirst.Data.Models.UserRole", b =>
            {
                b.Property<Guid>("UserRoleId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier")
                    .HasColumnName("userRoleId");

                b.Property<string>("RoleNameRef")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("roleNameRef");

                b.Property<string>("UserNameRef")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("userNameRef");

                b.HasKey("UserRoleId")
                    .HasName("PK__UserRole__CD3149CCDE4D7241");

                b.HasIndex("RoleNameRef");

                b.HasIndex("UserNameRef");

                b.ToTable("UserRoles");
            });

            modelBuilder.Entity("ControllerFirst.Data.Models.UserRole", b =>
            {
                b.HasOne("ControllerFirst.Data.Models.Role", "RoleNameRefNavigation")
                    .WithMany("UserRoles")
                    .HasForeignKey("RoleNameRef")
                    .IsRequired()
                    .HasConstraintName("FK__UserRoles__roleN__2B3F6F97");

                b.HasOne("ControllerFirst.Data.Models.User", "UserNameRefNavigation")
                    .WithMany("UserRoles")
                    .HasForeignKey("UserNameRef")
                    .IsRequired()
                    .HasConstraintName("FK__UserRoles__userN__2A4B4B5E");

                b.Navigation("RoleNameRefNavigation");

                b.Navigation("UserNameRefNavigation");
            });

            modelBuilder.Entity("ControllerFirst.Data.Models.Role", b =>
            {
                b.Navigation("UserRoles");
            });

            modelBuilder.Entity("ControllerFirst.Data.Models.User", b =>
            {
                b.Navigation("UserRoles");
            });
#pragma warning restore 612, 618
        }
    }
}
