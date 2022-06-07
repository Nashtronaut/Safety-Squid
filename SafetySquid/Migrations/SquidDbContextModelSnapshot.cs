﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafetySquid._data._entities;

namespace SafetySquid.Migrations
{
    [DbContext(typeof(SquidDbContext))]
    partial class SquidDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EmployeeTicket", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketsTicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeesEmployeeId", "TicketsTicketId");

                    b.HasIndex("TicketsTicketId");

                    b.ToTable("EmployeeTicket");
                });

            modelBuilder.Entity("SafetySquid._data.EmergContact", b =>
                {
                    b.Property<int>("EmergContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("EmergContactId");

                    b.ToTable("EmergContacts");
                });

            modelBuilder.Entity("SafetySquid._data.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cell")
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("EmergContactId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int?>("FuelCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("JobId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LivingAllowance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("TruckPayment")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UnitId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Wage")
                        .HasColumnType("REAL");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmergContactId");

                    b.HasIndex("FuelCardId")
                        .IsUnique();

                    b.HasIndex("JobId");

                    b.HasIndex("UnitId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SafetySquid._data.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("ForemanId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QualityControlId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SafetyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StraitForemanId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StraitSafetyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("SafetySquid._data.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("ValidityLength")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("SafetySquid._data._entities.FuelCard", b =>
                {
                    b.Property<int>("FuelCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("FuelCardId");

                    b.ToTable("FuelCards");
                });

            modelBuilder.Entity("SafetySquid._data._entities.TicketRecieved", b =>
                {
                    b.Property<int>("TicketRecievedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateRecieved")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TicketId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Valid")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketRecievedId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketsRecieved");
                });

            modelBuilder.Entity("SafetySquid._data._entities.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("EmployeeTicket", b =>
                {
                    b.HasOne("SafetySquid._data.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetySquid._data.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SafetySquid._data.Employee", b =>
                {
                    b.HasOne("SafetySquid._data.EmergContact", "EmergContact")
                        .WithMany("Employees")
                        .HasForeignKey("EmergContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetySquid._data._entities.FuelCard", "FuelCard")
                        .WithOne("Employee")
                        .HasForeignKey("SafetySquid._data.Employee", "FuelCardId");

                    b.HasOne("SafetySquid._data.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId");

                    b.HasOne("SafetySquid._data._entities.Unit", "Unit")
                        .WithOne("Employee")
                        .HasForeignKey("SafetySquid._data.Employee", "UnitId");

                    b.Navigation("EmergContact");

                    b.Navigation("FuelCard");

                    b.Navigation("Job");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("SafetySquid._data._entities.TicketRecieved", b =>
                {
                    b.HasOne("SafetySquid._data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("SafetySquid._data.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");

                    b.Navigation("Employee");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("SafetySquid._data.EmergContact", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SafetySquid._data.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SafetySquid._data._entities.FuelCard", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SafetySquid._data._entities.Unit", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
