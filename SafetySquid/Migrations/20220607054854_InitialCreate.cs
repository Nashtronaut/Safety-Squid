using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafetySquid.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmergContacts",
                columns: table => new
                {
                    EmergContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Cell = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergContacts", x => x.EmergContactId);
                });

            migrationBuilder.CreateTable(
                name: "FuelCards",
                columns: table => new
                {
                    FuelCardId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCards", x => x.FuelCardId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Client = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ForemanId = table.Column<int>(type: "INTEGER", nullable: false),
                    SafetyId = table.Column<int>(type: "INTEGER", nullable: false),
                    StraitForemanId = table.Column<int>(type: "INTEGER", nullable: true),
                    StraitSafetyId = table.Column<int>(type: "INTEGER", nullable: true),
                    QualityControlId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ValidityLength = table.Column<TimeSpan>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 7, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 9, nullable: true),
                    Cell = table.Column<string>(type: "TEXT", maxLength: 9, nullable: true),
                    Wage = table.Column<double>(type: "REAL", nullable: false),
                    LivingAllowance = table.Column<bool>(type: "INTEGER", nullable: false),
                    TruckPayment = table.Column<bool>(type: "INTEGER", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    JobId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmergContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitId = table.Column<int>(type: "INTEGER", nullable: true),
                    FuelCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_EmergContacts_EmergContactId",
                        column: x => x.EmergContactId,
                        principalTable: "EmergContacts",
                        principalColumn: "EmergContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_FuelCards_FuelCardId",
                        column: x => x.FuelCardId,
                        principalTable: "FuelCards",
                        principalColumn: "FuelCardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTicket",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTicket", x => new { x.EmployeesEmployeeId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_EmployeeTicket_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTicket_Tickets_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketsRecieved",
                columns: table => new
                {
                    TicketRecievedId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateRecieved = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: true),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketsRecieved", x => x.TicketRecievedId);
                    table.ForeignKey(
                        name: "FK_TicketsRecieved_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketsRecieved_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmergContactId",
                table: "Employees",
                column: "EmergContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FuelCardId",
                table: "Employees",
                column: "FuelCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                table: "Employees",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UnitId",
                table: "Employees",
                column: "UnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTicket_TicketsTicketId",
                table: "EmployeeTicket",
                column: "TicketsTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketsRecieved_EmployeeId",
                table: "TicketsRecieved",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketsRecieved_TicketId",
                table: "TicketsRecieved",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTicket");

            migrationBuilder.DropTable(
                name: "TicketsRecieved");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "EmergContacts");

            migrationBuilder.DropTable(
                name: "FuelCards");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
