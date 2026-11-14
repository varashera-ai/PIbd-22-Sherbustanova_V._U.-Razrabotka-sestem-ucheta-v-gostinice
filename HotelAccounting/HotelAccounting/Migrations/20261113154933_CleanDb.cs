using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HotelAccounting.Migrations
{
    /// <inheritdoc />
    public partial class CleanDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullname = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    passportnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    isregularclient = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    pricepernight = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    servicetype = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guestid = table.Column<int>(type: "integer", nullable: false),
                    roomid = table.Column<int>(type: "integer", nullable: false),
                    checkindate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    totalpaid = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guestid = table.Column<int>(type: "integer", nullable: false),
                    roomid = table.Column<int>(type: "integer", nullable: false),
                    checkindate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Guests_guestid",
                        column: x => x.guestid,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    roomnumber = table.Column<int>(type: "integer", nullable: false),
                    floor = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    categoryid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomCategories_categoryid",
                        column: x => x.categoryid,
                        principalTable: "RoomCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StayServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stayid = table.Column<int>(type: "integer", nullable: false),
                    serviceid = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StayServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StayServices_Services_serviceid",
                        column: x => x.serviceid,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StayServices_Stays_stayid",
                        column: x => x.stayid,
                        principalTable: "Stays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_guestid",
                table: "Bookings",
                column: "guestid");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_categoryid",
                table: "Rooms",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_StayServices_serviceid",
                table: "StayServices",
                column: "serviceid");

            migrationBuilder.CreateIndex(
                name: "IX_StayServices_stayid",
                table: "StayServices",
                column: "stayid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "StayServices");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "RoomCategories");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Stays");
        }
    }
}
