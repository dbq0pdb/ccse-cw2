using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ccsecw1.Migrations
{
    /// <inheritdoc />
    public partial class main : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassPortNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SingleRoomPrice = table.Column<int>(type: "int", nullable: false),
                    DoubleRoomPrice = table.Column<int>(type: "int", nullable: false),
                    FamilyRoomPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTourPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSpaces = table.Column<int>(type: "int", nullable: false),
                    TakenSpaces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(128)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    RoomBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TourBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourCheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TourCheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    Fulfilled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_CustomerNumber",
                        column: x => x.CustomerNumber,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourBookings",
                columns: table => new
                {
                    TourBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourBookings", x => x.TourBookingId);
                    table.ForeignKey(
                        name: "FK_TourBookings_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBookings",
                columns: table => new
                {
                    RoomBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookings", x => x.RoomBookingId);
                    table.ForeignKey(
                        name: "FK_RoomBookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e49fd25-2b62-4012-8aeb-25bd8db88f86", null, "admin", "admin" },
                    { "7d7d3e39-9bd9-4c0b-a28c-7b4ddeda381f", null, "customer", "customer" },
                    { "a5b44c47-8eff-4d64-9cd1-f71d7750f4c0", null, "manager", "manager" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CustomerNumber", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassPortNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08023cab-cf6e-49ef-b09c-b6ae5e825726", 0, "123 High St, Manchester, England, M1 4RF", "1a95f923-2742-4e17-8f8c-2b20588a56d4", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(5847), new Guid("324d18a6-3823-4d70-8ce7-01bf86511773"), "user3@example.com", false, "Emma", "Wilson", true, null, null, null, "P790714", "f5f7f40d-1634-4cbf-aacc-961eb40710c4", "07790138482", false, "f66501c2-ba18-4847-8124-01f10b55fa09", false, null },
                    { "6f1355e9-8b11-4a18-9536-7c7f5d89f9c5", 0, "789 South Ave, Birmingham, England B2 4BB", "9277ab04-86c4-40be-88f6-000bcc85b7e9", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(5235), new Guid("0a2bdc5c-dd01-465c-aa52-aac99de692bc"), "user0@example.com", true, "Alice", "Miller", true, null, null, null, "P948586", "92573f81-2416-46ca-9d52-d928efd9a980", "07793331242", true, "a512bc10-9572-4669-933e-c9d8855d0b31", true, null },
                    { "8310725b-1e67-420d-8d01-4f780f487f27", 0, "456 Park Ln, Liverpool, England L8 3TW", "521cd5bf-49ee-47a5-9700-9f3bf42400fa", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(6314), new Guid("36a292d5-acc1-4e3d-943a-c04ff363f746"), "user7@example.com", false, "James", "Moore", true, null, null, null, "P662776", "292976cd-7e7a-4802-8ff7-ead011829274", "07794881064", true, "99a5f340-5bb8-477c-b0c0-844afe787714", false, null },
                    { "8dbd75a7-8f33-4b01-b4ec-3c56a85de2b0", 0, "123 High St, Manchester, England, M1 4RF", "a65cd3ba-ec3f-426c-9be8-5a870acd26fd", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(6113), new Guid("f5f91a16-dec4-4ec3-90e8-4e69058a005c"), "user5@example.com", false, "Alice", "Johnson", false, null, null, null, "P875282", "776f56ac-c273-49a6-bfbe-3b80509292c8", "07712685300", false, "34a20f21-2324-4fff-88dd-86e71a85470f", false, null },
                    { "a553363b-a14b-4f5e-90f3-7e7bb723010f", 0, "123 High St, Manchester, England, M1 4RF", "c11fb865-f66d-4c2e-883f-8535d0a3a6c5", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(6760), new Guid("c978c4a1-8860-421c-9d3e-768e848873ce"), "user9@example.com", false, "Alice", "Jones", false, null, null, null, "P413711", "de0ef30b-dab0-4c9a-b1d5-f0b66e6fd1c1", "07787734491", true, "bab637e9-c636-4efc-a5e0-2da6a6d8b598", false, null },
                    { "ab1a1a44-38de-4b8d-bf8e-93d5c8f19ac1", 0, "789 South Ave, Birmingham, England B2 4BB", "1dcfb651-3c3b-45c9-96c0-6951348f9e57", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(6476), new Guid("05811743-91bf-46e1-86ea-cea722f4a100"), "user8@example.com", true, "Emma", "Smith", false, null, null, null, "P903696", "22c88e95-5bc3-4bb0-9a7b-335f45d0b0c2", "07755378839", true, "01a69488-54f6-4b7e-b028-bbdf6383e26b", true, null },
                    { "c3a68331-b0ea-47f0-b8a5-8a491002a063", 0, "135 New North Road, London, England N1 7AA", "44ebbeba-d198-4b5e-8596-13b51cc8bc45", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(5947), new Guid("2f8258c2-869e-493d-a789-cfa6d114aa24"), "user4@example.com", true, "Alice", "Williams", false, null, null, null, "P338385", "201a5d72-1c25-4edc-957d-3046344b53a8", "07726313155", true, "d915fd17-18a9-441e-a4a4-c56314feee2c", true, null },
                    { "f3e7d21f-a639-49fc-9dd2-0bf26c1fad12", 0, "135 New North Road, London, England N1 7AA", "d44b133e-08f1-4be3-b088-94f46b1839cc", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(5522), new Guid("cc1674b6-832b-4628-8bb4-85af4f70683f"), "user1@example.com", true, "James", "Wilson", false, null, null, null, "P914380", "58c020ce-0297-4bb6-9f1c-efe577100e2d", "07799322568", false, "58279924-d029-4c4f-8f35-44cf61e0469a", true, null },
                    { "f4dd44e2-71f5-46d8-a83c-17a4fe21794d", 0, "135 New North Road, London, England N1 7AA", "983a3990-5518-46b9-89ee-59f9afbd2ada", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(5743), new Guid("dfd36b91-7510-4b30-acf5-b6a7ed3a0337"), "user2@example.com", true, "John", "Brown", true, null, null, null, "P733827", "fb9ba527-a875-46d7-84b3-f02d0666871f", "07768488478", true, "fcce0992-168e-423b-b864-e4021a41434f", true, null },
                    { "fd2518f7-93bc-4d18-a3b1-1925a6672729", 0, "456 Park Ln, Liverpool, England L8 3TW", "27c85b7e-a720-4ac4-be8d-25c3d50362c0", new DateTime(2024, 1, 24, 5, 4, 52, 748, DateTimeKind.Local).AddTicks(6212), new Guid("290feebc-02a9-49cf-bc74-6c8d1a89bd4b"), "user6@example.com", false, "Emily", "Davis", false, null, null, null, "P473433", "656648ed-c65c-47a4-bbce-b7b58b7f5b56", "07720003630", false, "5807817b-2ff4-4d57-a712-b2d0f1c94b7f", true, null }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "Brand", "Description", "DoubleRoomPrice", "FamilyRoomPrice", "Location", "Name", "Rating", "SingleRoomPrice" },
                values: new object[,]
                {
                    { new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "123 High St, Manchester, England, M1 4RF", "Journey", "Discover the world with us", 350, 300, "Manchester", "Riverside Inn", 4, 300 },
                    { new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "456 Park Ln, Liverpool, England L8 3TW", "Journey", "Discover the world with us", 350, 350, "Newcastle", "Riverside Inn", 5, 300 },
                    { new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "123 High St, Manchester, England, M1 4RF", "Excursion", "Your gateway to amazing destinations", 250, 300, "Newcastle", "Grand Hotel", 3, 100 },
                    { new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "789 South Ave, Birmingham, England B2 4BB", "Voyage", "Unforgettable travel experiences await you", 300, 450, "Bristol", "Palm Tree Resort", 5, 100 },
                    { new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "789 South Ave, Birmingham, England B2 4BB", "Odyssey", "Discover the world with us", 300, 450, "London", "Lakeside Manor", 5, 250 },
                    { new Guid("9515b505-7761-4b87-bb40-21da06551406"), "123 High St, Manchester, England, M1 4RF", "Safari", "Explore new cultures and traditions", 300, 300, "Manchester", "Palm Tree Resort", 1, 150 },
                    { new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "456 Park Ln, Liverpool, England L8 3TW", "Odyssey", "Exciting adventure tours for everyone", 200, 300, "Manchester", "Lakeside Manor", 5, 300 },
                    { new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "123 High St, Manchester, England, M1 4RF", "Journey", "Your gateway to amazing destinations", 350, 300, "Bristol", "Riverside Inn", 4, 150 },
                    { new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "456 Park Ln, Liverpool, England L8 3TW", "Odyssey", "Exciting adventure tours for everyone", 400, 400, "Manchester", "Golden Sands Hotel", 2, 200 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "RoomTypeId", "HotelId", "Type" },
                values: new object[,]
                {
                    { new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Double" },
                    { new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4"), new Guid("00000000-0000-0000-0000-000000000000"), "Family" },
                    { new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a"), new Guid("00000000-0000-0000-0000-000000000000"), "Single" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "Address", "Brand", "Description", "DurationDays", "Location", "Name", "PricePerDay", "Rating", "TakenSpaces", "TotalSpaces", "TotalTourPrice" },
                values: new object[,]
                {
                    { new Guid("249a1d08-990c-4515-87a0-cdf933060442"), "123 High St, Manchester, England, M1 4RF", "Roamer", "Exciting adventure tours for everyone", 7, "Leicester", "Adventure Expedition", 50m, 3, 0, 22, 380m },
                    { new Guid("50041c0c-5b82-43fd-b4b4-e4d9010918b3"), "135 New North Road, London, England N1 7AA", "Wanderlust", "Unforgettable travel experiences await you", 7, "Birmingham", "Nature Discovery Tour", 20m, 3, 0, 11, 170m },
                    { new Guid("51205879-08b4-4494-ad59-a7ced4d10b8e"), "123 High St, Manchester, England, M1 4RF", "Venture", "Exciting adventure tours for everyone", 19, "Liverpool", "Mountain Trekking Experience", 40m, 5, 0, 14, 750m },
                    { new Guid("56f5a491-de08-4e9c-8ca8-50a14a55061d"), "789 South Ave, Birmingham, England B2 4BB", "Voyage", "Discover the world with us", 10, "Nottingham", "Relaxing Beach Retreat", 10m, 1, 0, 14, 420m },
                    { new Guid("5ea8c8d5-ce38-4136-9ee3-f1b186ac1a65"), "123 High St, Manchester, England, M1 4RF", "Quest", "Discover the world with us", 18, "Manchester", "Coastal Exploration Trip", 10m, 5, 0, 25, 210m },
                    { new Guid("6c7bfd9b-c82d-4b41-acf9-0d6746a6e95c"), "456 Park Ln, Liverpool, England L8 3TW", "Excursion", "Explore new cultures and traditions", 13, "Liverpool", "Cultural Heritage Journey", 20m, 3, 0, 9, 800m },
                    { new Guid("acfda68d-41e2-4c2f-9bd9-4fe7e7ed2427"), "789 South Ave, Birmingham, England B2 4BB", "Venture", "Your gateway to amazing destinations", 11, "Leicester", "Cultural Heritage Journey", 20m, 3, 0, 23, 400m },
                    { new Guid("ce69ff36-eb52-4f7e-8475-d01a3e3b340f"), "456 Park Ln, Liverpool, England L8 3TW", "Wanderlust", "Exciting adventure tours for everyone", 12, "Nottingham", "Adventure Expedition", 40m, 4, 0, 8, 500m },
                    { new Guid("def5dd6c-79c1-4729-b01c-f58a3d213729"), "123 High St, Manchester, England, M1 4RF", "Excursion", "Explore new cultures and traditions", 13, "Manchester", "Relaxing Beach Retreat", 20m, 4, 0, 15, 160m }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "HotelId", "RoomNumber", "RoomPrice", "RoomTypeId" },
                values: new object[,]
                {
                    { new Guid("00364112-5cc4-4634-8c48-1e2fa43e6f02"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F14", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("00c6ecf5-bd67-41eb-a55a-feb2e865344c"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S2", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("01462a8d-d8a7-4154-8e9c-c805f040a604"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D13", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0169dbd2-f2b6-48ef-8406-1e37a1242867"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D2", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0192a65f-ca02-4f59-867f-ba92451eaea1"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S11", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("02139a90-adcc-42b1-94f5-f173a73b6efe"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D18", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("02f8d953-a23c-4082-8b36-0258f54be704"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D10", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("039f9c98-2b6f-4ca6-84b9-c885032da34d"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D8", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("047afa61-c7e2-4c15-9e3a-fd7c1e6c2f4d"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D11", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("04d45fd4-8b19-407e-a8fc-8864cca65906"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S16", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("056396b4-23e8-4154-8c47-2a755155ec0b"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D19", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("06ba1cd4-65a4-4234-87f6-381aefb19724"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S10", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0716be29-8d5d-4de5-a43a-f556b8e9e954"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D15", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0721658d-ad42-46e0-8bc1-2e8bb1276b0b"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S8", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("07287163-a361-4736-8cdf-56d49ed65eab"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S3", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("074cf04e-b2f1-4ff3-b2f4-1c5154135aa1"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D3", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("07d530dc-5d85-4cea-b9f8-62edfb04a9d2"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F9", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("09c52f35-c383-45c4-833d-e96d9528d501"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D12", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("09cd196e-981d-4088-9870-4cffd069be1f"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S3", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0a258357-a394-49ad-8045-e08f414199c6"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S12", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0aae5a52-4cb0-470d-a2f5-793eeb0dd59d"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F6", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("0b27bb4e-efb4-4f15-a59e-7749b1ef0d2a"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F6", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("0bba8b96-494c-490d-87e2-a41c3a635483"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S18", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0bedcb10-b443-4ae6-9948-4cc4f5dd23da"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D8", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0c0c9872-021c-4cb1-912a-15d9b8b06070"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D1", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0c575990-475f-4b2e-bf45-0b00408d4137"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F5", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("0c89b518-6e54-454b-8d53-a830e2658a0e"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S2", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0cb07658-b536-40b5-9592-0e33e4be25f1"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S3", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0cea736b-6fd7-4b36-9883-d030afc6151e"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F8", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("0cf25699-c102-4022-b775-0892f235cc12"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F12", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("0d210f96-1129-4456-8296-f049ea1f2336"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S10", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0d6564cc-d799-4cbd-b55f-1f5eee9db41d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S16", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0e926902-f7aa-49fc-8f7d-ff3247a9790b"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D17", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("0eb45780-d222-486a-9201-d00f662f0dd3"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S3", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0f85bde4-61b6-4b1b-8566-a4067dad6c51"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S16", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("0ff3612f-a31c-4197-b9ef-f16d3e3fb3a6"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S19", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("102ca5f9-87fd-4a4d-9f4a-9df8a623919a"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F11", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("109fad53-bc76-4234-8d85-7bf2b3773226"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D13", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("112cfa11-4f28-40ff-9b12-1ed4a6a0057d"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F14", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("115505f6-57aa-48a2-bf4b-1abbe373041c"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F5", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("1167e8da-073a-4155-a539-697796b855cd"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D2", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("12b33a82-f932-486c-bf77-6efdada3c99e"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D16", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("138fbe73-f8f6-4fcf-a320-0feea2b5172a"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F12", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("14006f21-6b1c-448f-8ccf-059406770072"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D4", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1482cc26-c0df-423c-93db-c98e13fd1605"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D12", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("154b86d5-fdd5-40ec-a6db-346e2c485cc7"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S3", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("1551999c-4043-48e8-ba2a-85cab9406b86"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D11", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("15711bbf-6301-4374-9e2f-bfa39f4d3f0d"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F19", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("15d10fe2-be09-4359-83c9-2bc094efcea0"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S7", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("1660aefc-d506-4e98-949f-8622fdfad345"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S15", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("17cd3689-808c-4c3d-829d-2c86ec3d725c"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D14", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("18610165-1e5b-45fc-96db-7dd066b015c0"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S4", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("18717786-52c6-4812-9324-e1383a3ae740"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F17", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("192c899f-04d8-4a40-ad48-3f7fd068348e"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F8", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("194e67df-0c43-4cd4-800b-db975b122782"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S14", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("19bae9ac-69fc-4f07-b61b-1b8b0ceab6fd"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D6", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1a06eccc-d2f7-41ab-bcbb-fccc6c416e27"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S6", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("1aa093b6-e419-47cb-a8f0-4ef03121dde6"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D14", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1b707305-99cb-40ff-bce7-2f922b7142da"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D18", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1b954d9a-3adf-41de-b2ce-1d5b9d283b44"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D1", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1c0acc5a-b17c-437a-9b9b-9123b51edcf8"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S14", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("1c1d8149-acb8-41ad-addc-551f0cdcf39e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S9", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("1d64dd9e-181f-4927-8505-162f3030d48d"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D20", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("1f810d94-4518-4c3a-860e-f40ba26838b3"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F4", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("1fe2b546-2a7e-474c-a055-4de2fd2a5d1b"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F13", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("20127353-6cc4-4277-9cb4-7fa94281f2b8"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F15", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("20b22de2-8476-43ea-b443-89e15e1057f7"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S15", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("20de7771-59a1-4ec1-b1eb-365a7722e38c"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S8", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("215351fb-3459-4901-876d-7f690a8da72d"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D9", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("21d04215-931d-4d9d-a9af-2eed11e063bb"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S19", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2208decb-14b5-4b42-a6e8-b5e45008fbcb"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S19", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("221176e8-1ddb-4723-9b22-75b8774ed138"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D18", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("22f05afc-d27e-41ec-b4c4-9c175a75648f"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S5", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("236974f8-e713-416c-b4ba-ef53177fa88f"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S17", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("23b2fce6-2be9-41a9-a567-99d5dde68ae2"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S3", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2427c4c9-5199-49fd-b76b-9ef1c27b62d5"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S6", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("250d14f7-04e7-4079-9ad1-9ef93d3bda50"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S12", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("25ced199-056b-4540-a162-584e91743717"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F11", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("25fde0e6-c618-4ea4-bb4d-bc9dbeab6ed8"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S11", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("26244184-b564-4463-b528-5052d7bc8afb"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F7", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("26d8ddb6-c77a-4dce-931a-77ba88ec3ea0"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F10", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("270df596-13fb-446a-a083-2e65e3eec318"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D9", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("27fa10da-988d-4639-ba18-0fcb1b5c247b"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D11", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("293dafc5-1f92-4259-b77d-18ae72806652"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F8", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2988d0a6-ee3e-488d-a256-a9e7b4be805b"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D15", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("2a6e701a-4d9f-4a0d-831e-fb11e1ca9787"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D3", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("2aaf94b4-3df7-4cb3-b8bf-500047fe982a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S7", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2adad911-3b4d-4a2b-b5c3-66374738bcca"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S11", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2af0119c-d955-4724-8b89-203c23fc281d"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D7", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("2b364de9-0226-4298-9d40-1d4307490b80"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S8", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2bc1ab82-b497-4509-bb03-919fde8c20cd"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F20", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2c0ea986-c0ae-46a1-b80e-c3090920ff40"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F16", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2d59aa20-b9b9-41a5-8270-d1b25b2dc9a8"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F7", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2d9bbd18-c28b-406b-933c-e3cae9d055fb"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F18", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2dfb0b41-9b86-4715-b683-40cf1a0bbceb"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S10", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("2e7efeb3-1cc1-455d-919a-4efdfccb9300"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F2", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2f8ee142-615b-4ae1-8eff-583d0291af9c"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F5", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2fa083d9-0dc8-4695-918c-d1a7628d7943"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F4", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2fa37cf1-6627-46a4-8553-267e6fb45c47"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F13", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2fd390f4-ee3e-4ee3-a916-b53bed45ab90"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F10", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("2fd7dedb-9023-47a1-9700-7c2814a1a91d"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F12", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("30b26baa-56ad-41bb-8d2b-09dea662572a"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F2", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("315a2ead-9c50-4450-a21b-2cdfef15eb0a"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D18", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3179e68c-2f45-4a9a-9614-9366b1d8228b"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D4", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("317d045a-df70-435d-93b2-869bfdbea898"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D17", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("323e5977-c6c4-4a89-903b-3c32db6db37c"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D16", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("328c9098-bf5f-4be5-8219-e911a61b3f76"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S20", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("32d45c4f-3fe2-4a24-b80c-15d749d13708"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D8", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("32e1a469-039a-447c-970b-594b788b4a1d"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F2", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("3345bf23-fa38-4610-9dce-5a535d31b2b3"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D10", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3408120d-c6aa-40f1-9abd-fba50741ee3b"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S1", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("34158c12-06b4-4ab8-9a5d-063c86d59b2b"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D5", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("343faf61-eb25-42a1-9aa5-01dbec2c8519"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S20", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("34506a3c-b414-4af8-89b7-ec82e5aab9b7"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S5", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("34747ac1-af26-4ad6-8f52-bbc42e51b6ef"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S20", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("353b89c0-fa36-45d6-b907-35bb34b17342"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D14", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("36399871-7d28-400c-9487-c744579615fa"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D4", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3710f610-78c5-48eb-9bbf-3093321628d1"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S3", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3790444d-e0f7-4446-8f2a-4717e9297e60"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S2", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("37b723d2-7dec-49c8-b03f-561ad5a3dc1f"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D20", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("38a0d878-4b31-4cdd-8f1e-97855a7cd32c"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F9", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("390a07d8-8407-4aa2-b6d2-1fa842f68b3b"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F13", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("39545860-bc36-4891-88e2-097badd44b06"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F1", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("3a2b93a1-48f7-4b4c-8f30-b202b1024c82"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D19", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3a675ef1-5241-457b-8117-18cd7d3db452"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S13", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3c0cdf79-cd9f-46c9-9463-1c5c2d5ec282"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S15", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3c3e7023-ea5e-4576-91ce-78176c6d7fc9"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F16", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("3d43a48d-db2c-4ae0-aca2-f91b53ba91cb"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S8", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3d8dc258-ca28-4527-ba3c-c413527af231"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S7", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3e5ab750-3411-4470-8f9a-44dfb88afbc1"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S5", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("3ebc4bdc-009c-405a-927f-75e43f41fc40"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D6", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3f04a991-a184-43a7-88ee-33568f02259a"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D10", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("3fb3e0ca-55ae-4e6e-80ec-2f166c3a2b86"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S12", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4016297a-dde6-4cf6-8b01-b647dc167bf3"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S9", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("404fbd15-1099-4fb1-bf31-32af3097d140"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F6", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("40cc8124-25e7-4368-ac60-c8bf1b70b6c7"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F3", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("416c5536-294b-41b8-a699-411b4ba19a18"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F19", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("41ca1a8e-0463-45a2-adf6-eb3c57d414a6"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D10", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("41ce0240-ca30-4b06-aba9-6e7bd4a1985c"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D10", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("41dc4cc6-a377-4f6e-b3b8-fa3e2ace5e63"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F1", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("437c0d34-37e4-4722-98b0-84c0eeb30be3"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D8", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("43d7d44c-5120-41ba-8cd5-ea47a655534f"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D16", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("4414898d-964a-43ba-bf86-0acf5b871d8f"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F1", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("44568523-0d18-4ec9-a6b4-aedad4408abf"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D16", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("449b6c58-4462-4b0f-b230-5d855d850291"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F7", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("45459487-c42e-4da1-b66f-8b8ec5dc292e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D9", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("45cf0307-4714-42c0-a516-ba87a56316b8"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S6", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("45e07cd6-ef27-4abb-8dfb-1e255de23f08"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F14", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("46b294f1-38e4-4cec-a798-67a996fa2587"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D19", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("46bbd61a-1900-40f9-a961-d55304ecbead"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D3", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("46eac882-3cab-49f1-8136-f0546550d8fc"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S17", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4723e711-f25d-4154-8beb-fb54087e6dc3"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D17", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("479ed255-5903-4f55-9fd7-decc60187a5a"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F10", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("47f48674-a15a-4886-962f-7c02099c248d"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F4", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("4814ecec-c87e-4ed1-a189-dd154137985b"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D20", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("49fff250-f45a-450a-b465-eaa7c90857d5"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S6", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4a14cee9-6e49-4ff8-bba3-c15997f4507e"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D8", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("4a182d6d-b1cc-466c-9fc6-5436038ef4d4"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S13", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4af2a8e2-6964-4216-8f9b-948d4582ac28"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S10", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4c351d6b-de7b-49b2-8a8b-260a3e503ab0"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S17", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4e41efd0-0265-48de-8c5a-d22d4082e46f"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F15", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("4f0312b0-5254-4e41-8bd9-e6cd0d9660da"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F18", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("4f9c691c-2851-4983-913d-806623086ecf"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S13", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("4febcdcd-7e6d-43af-9e29-d08b504de001"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F20", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("501eec3d-611d-4cf6-8321-b31b6c7ff668"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S4", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5053347a-413a-4f38-a806-3dcceac6f763"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D5", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("50cb5236-2b3f-449e-90b2-ffa755fed27c"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D15", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("51353fcc-96e0-4cf0-9008-6445d534031a"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F8", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5149a136-966e-46d0-bb39-d5d6813b63dc"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D15", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("514e6f9a-77ee-4eeb-8c6e-98ba1779a9f7"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S9", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("51e4f408-a09b-4a9e-a801-cd3956cab5bb"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D16", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("51f09d38-4510-475c-8992-3e8fc083138b"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S20", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("522d5e3a-2be7-44c0-8c51-fab62f22d40d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S14", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("52a37343-9834-4699-9501-e77fb1d8f90b"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F11", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("52c88047-f147-43a9-ba37-7730738b5a77"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D17", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5352afb0-39b5-43b0-b467-2e48414d94fc"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F2", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("535a0510-8c27-4c8f-a5c3-06f5fa939932"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F16", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("53ab41b4-8d9c-4167-a2d1-b0846226bf40"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D11", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("53e11601-54a8-4f03-8066-2cffb80bc480"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D14", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("542dba06-4d6c-4ddd-824b-6de35f56cccd"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D11", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5455fbba-acf5-4902-b2f1-e7333a647865"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F3", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5487dd00-3c25-4175-8d93-c4ceeb98550a"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F1", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("54984b0c-55f8-4751-916f-f478b620ff5b"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S13", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("55109dbf-8c8d-40c1-9efe-7632608e7211"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S14", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5550a200-79af-4771-8a64-2bd537f89338"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D2", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("55d3617a-1af3-41cb-b394-32d003077201"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F17", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("56252b86-f96d-480e-8e41-239117cc1e27"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D7", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5648dcc5-e6cb-4493-93d6-a561e4350e6e"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D4", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5664e491-f694-4466-9afa-5d03ef0d93e0"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D14", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("56b296dc-9ba2-4f72-98de-763c2b307d2b"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F8", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5777e82e-bc8c-42e3-a828-c2e47710a027"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D17", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("57c758c6-bb30-4c99-8085-e5127593f739"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S15", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("59626c8d-a114-4065-aba7-40b9c9e3ceba"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F2", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5af2bfca-6b2e-4e98-8deb-4c91749d3283"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D8", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5afa78af-9690-44e0-9421-65be48e5cb6b"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F17", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5b184847-a0af-4ad1-b48d-9112e27ac0ed"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D8", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5b813fe0-188b-4e2f-92e1-5db6417adfd0"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F10", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5c02ae29-1927-41dd-a29a-7adbdefe8070"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S11", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5c135c8b-64bc-48a7-94bc-7adf0dd6c060"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S17", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5c515aa5-88e0-4be7-bdf8-4645d84e44ec"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D9", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5ce743da-db0f-413d-baa7-c105e0817b80"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S5", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5cfaebf4-b921-477e-9293-f87c3a074e6b"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D12", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("5d21a8ba-3702-4a31-acf5-4c97be2f13d0"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F9", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5dbbfcbc-3032-4fd6-a995-271a355e0536"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F6", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("5e8d050f-dc75-49fe-a450-ced1b072096c"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S9", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("5f60417e-e30d-46be-9ed2-5ff20ea840ef"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F8", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("6166b244-c660-4d41-a1fb-fc51e5fd4525"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S4", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("61d606be-d094-482a-a449-a851a20371b9"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D6", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("630f193f-7ce7-4bb3-97d6-6ea1a2983a9a"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D3", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("63860ca0-6990-4175-9f80-e39a6917dba7"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F1", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("63bc278a-7b42-4271-a675-8a9026a00396"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D9", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("65d8f024-4a28-4508-937f-9a5e38cc64a8"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S2", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("65dffd2a-05c6-47dd-887d-5ee9108baf6c"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S11", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("66ea09b0-1dff-492f-8a27-87ffd282a41e"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S18", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("67bd3465-0cbc-4158-a66c-d5315a15a3b2"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F15", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("67bd64a8-0a82-4b53-b8c8-e5f116cf69dd"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S14", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("69230ac9-a78c-43bc-80e5-fae5263c54c2"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D19", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("692c47a5-34bd-4560-854e-0a1644b85b36"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S20", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("695c9ccb-1460-4d80-83b3-e914544c704b"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F2", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("6973638b-b1c7-45c6-872d-141c493c8e00"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D13", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("69ec23e7-a641-4e9b-9ff9-d55dd1775329"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S13", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6a7d4561-6eff-4bb8-8a4e-f962fbb675bf"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D1", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6a9b0816-7609-4545-94a7-e1b7b1285fe3"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S17", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6ad212e9-8215-4717-8349-9a8cd469bfb8"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D15", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6ae240e4-e23e-44ac-b6c9-500eaa0b4f38"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F12", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("6b270436-ae22-4255-929e-4a0ba45f302d"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S1", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6c0d34b9-bbff-4b6a-9b55-0ccaacc413e3"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D5", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6de079c4-b1b6-42ae-9345-3f99da079c0b"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S19", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6e14b151-272b-46bf-8720-7a8533c9696c"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D20", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6e7ea7d0-5591-4dfd-9a33-564ba0029560"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D19", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6eca6ade-c24f-445e-adda-478188c22733"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S20", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6eca95fb-5cc7-4ccc-8261-05b22bcb44d1"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D16", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("6ed73f1d-8f27-4dc8-9790-59ebc9fcd3ac"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F5", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("6eddfa1f-052f-4b45-85e1-821baffd2bb5"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S1", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("6f1ade6b-d214-4ae8-bea7-8dd6e74f5a83"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F5", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("6f6821cf-944e-4da1-958c-c58e9823a712"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F14", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7072fb0f-f2b1-4cd1-a21c-38531448638a"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S9", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("70861445-4b69-4178-b307-6b84cf10914b"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S20", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("709c0487-7aa9-440c-9ca1-785a72199617"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S17", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("70db6a6f-ee4f-4dcd-aad2-eabf0e25b4ba"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F10", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("71a8deac-30c4-4dca-a7ad-2bff844ba307"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F1", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("72c6effd-75c3-4a0c-86eb-15f657795df3"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F11", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("73c8753f-21eb-4f66-b286-47b21a675a1c"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S8", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("74b91c76-ad41-4f88-bdc5-78bdeab077da"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S20", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("74de4afe-1be4-45a3-a5cc-d715532bdef4"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D7", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7528a978-4782-47a5-ab8f-1aea3d5b388d"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S2", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("75492b1b-3d66-41ff-932c-6b71650bb29c"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S1", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("7650f89d-ffa0-4ec2-af6f-75286d5478d5"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F5", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("772e1358-7b87-4a30-bb7b-5918fc8dde24"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S10", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("778553a6-b81e-45f9-8809-168161033d35"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S17", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("77859043-eb7d-48bd-984d-38c281fb92bd"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D5", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("77932f4f-c208-439f-b6f8-1d1e942c687d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D17", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("77e69dd8-f216-4964-bccb-33a4f5d6b905"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S12", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("7803c732-00f5-4718-9fcf-36841e0b8c75"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D2", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7818705c-ecb4-46bb-8f75-ebe385326fb4"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S1", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("795c75d6-0346-4204-bcf8-00e894a80ecb"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F16", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("797e847c-d449-4799-80d1-7bc479ff8233"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D4", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("79c0c5ef-a12c-4d52-84c5-1123400bdc43"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S1", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("79c77f13-45d5-4c41-b414-120b213108e2"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F17", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7aded3bd-26db-4a83-9967-3b521182d3b5"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F20", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7af18614-fe25-4903-a353-8960da2b2edd"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F18", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7b3fbf16-cd49-4970-94c1-0e36120ce60a"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D7", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7c14b9b1-669e-479c-9c4d-74c6727809e8"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D6", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7cf37e59-af65-416e-ad90-9e7258a272c9"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F5", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7d43ac2a-e31e-42c1-a1ce-3a16b28a097d"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F10", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7d4a46d3-58cf-41c1-9cf1-274c21f6d744"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D14", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7d68801c-d561-4085-9616-3e60f277f22b"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F12", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7e18c182-4fbb-4e5d-9cda-20139ad15ec2"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S10", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("7e7b63f5-f7d1-400a-b4b8-f3b32d1b8ca7"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F11", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7e9ac5dd-eb30-4804-bc66-76350ff2cfc9"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D4", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("7ec6309b-27ff-4943-afa1-37b34d1703b5"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F17", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("7ff5ead0-2958-4585-8e0f-6a8eac09cb65"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D4", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("803fe061-0e71-4cbe-b954-cec4fb3ba365"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D15", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("805bdbf0-8411-4fd4-b036-170e835d3e63"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F14", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("80a553a6-2c26-4d79-95f1-6a0c4c230f2a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D6", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("81454e42-35a2-4b47-b853-050ff6219cc0"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F6", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("84414ebb-a539-46e5-adea-855f8c897d7d"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F18", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("84e5e229-1e90-409b-9917-b1276e9e0620"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F8", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("84ec7014-d314-491b-b3b9-8a48cb3fbca4"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F19", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("85a23d7b-36a9-46f1-a681-b8f8d3f0bf2e"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F14", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("86c19b45-5464-4e2c-a554-df9c1ed2a5a5"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D2", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("87d3e03f-39a5-4b8b-b1ea-a9179f06163d"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D13", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("881fed0a-b32e-4d88-940f-75c3519749b4"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F4", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("883bccdf-77b1-4b44-91c8-d20d162c9813"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F19", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("8961490b-21a1-485e-b1f2-0d4f0042af04"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F18", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("897cf431-7630-4218-8e68-c86f02269970"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S18", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("8a0a639b-61b3-4b1c-9cf1-e4377ac5f146"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D19", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8adf80fe-d12a-41f0-888d-9c9e0b3924f9"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S1", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("8b7ac794-3575-470b-99e9-74d0342b4de1"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F13", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("8bb8a254-8c15-4f9d-a47e-3cfb37620487"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S11", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("8c1d43b2-196c-4ff4-b0b4-55e960f38387"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D1", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8c2a186e-99c4-4159-805c-8c09eb589296"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D13", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8c4a8eaa-8b72-40c7-8668-ce6fdb527c81"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S19", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("8cc7592c-c6b1-4c68-9770-16876bff2a55"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F20", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("8dcfa179-9d5d-42e9-be48-a780107f384c"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D6", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8decc082-57fc-4c9d-addb-09a825113490"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D3", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8e4d459a-2e4c-4bd7-bc84-18797ab3dfc7"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D12", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("8f0f3889-d055-4d1e-8a77-f929975691a3"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F9", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("8f3ef2ae-b79a-42a5-aa6b-2a61a8ee0d1b"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F7", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("8f5f7294-51c9-4107-8542-33ce1a096231"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S16", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("906cb68c-d96e-4e08-b79e-8759b4814e2c"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S19", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("90c95bc5-0e2c-4b5f-9b6b-99caf715d518"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D3", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("91e5c1de-ba60-4c27-aeaf-ed7e0f44aee0"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F4", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("924bf2f9-06ff-46a4-b515-9c013c00421a"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D12", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("92e751be-6854-48c8-946a-2b526ff13d84"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S16", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("92e9a22f-f89a-44e0-bf12-5bf829136435"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D18", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("9342a002-6074-4c2b-a807-e38f0a75e71d"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S15", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("940f896c-0859-433e-8919-ee2b5708c9f3"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S12", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("9441fec5-8a3a-49cd-a480-c9ca7c7ae247"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D20", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("94d99af2-ffa7-4e7a-89b0-17d6df995390"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S14", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("952dc783-b79c-489e-bcdf-010ddc553aa1"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D16", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("9555e3e7-23cd-4bf0-9569-2d953ba08e40"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F19", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("957552fd-9709-42a8-93c4-0e0af8fbefba"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F13", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("95b460a9-cf7e-41c6-a0bb-e065863dc0e9"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D13", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("966d03fa-d648-4c1b-85f8-ece5d2e0da9a"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S10", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("96c1f490-16b6-4591-9927-cd59460b5684"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D1", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("96d9d4ea-2b8f-4e77-8d20-14cc25fec98a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F12", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("96f626f9-c295-470b-99e5-5061c069eea5"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S6", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("9781cc87-cf47-4573-8c92-2e50d0837bb7"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F4", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("97c05674-b510-44b4-8342-376046c3ee64"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D19", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("97d718fb-7ace-47c6-b13b-aa0d8a362a13"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S7", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("98002b3d-9efa-41e0-985f-b2e1b474247e"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D9", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("98303cb5-e87b-4116-a52a-e2c689d5a90e"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F7", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("98971814-9e76-4ade-baaf-4e77446e0e85"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S2", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("98a113f1-56fc-4e2a-8d83-9f45286c94c0"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D3", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("98a36065-0fb4-4e61-8a91-e75668c58a9e"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S10", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("998aaf67-df38-43d1-bc8b-3b83b2410a28"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F14", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("9a78d78b-4e7c-4c3d-ac98-f6bf64024eeb"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S1", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("9a9a5a4f-d937-4a49-bba5-dec6f9b1423c"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F7", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("9adfa35f-1597-4097-993b-0818e9f92538"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S4", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("9b5019b8-930f-4fd3-b733-1eda95c30b27"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D6", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("9bcebf82-050c-463a-867f-7174e96f7f53"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F5", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("9be29387-48d8-4bb1-b44c-15418280b896"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S11", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("9e4c887d-d6e4-4d4e-9107-39690abca61b"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D3", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("9e60f773-a5ce-4b00-a9fc-4be466d92645"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D10", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("9e9fc02b-55fc-4f92-b75e-eb65d01195e5"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F12", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("9ffeaf0e-7f51-4c0e-bb1c-fdae2f0db00a"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S13", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a034a18c-b7e7-4b57-8dcb-d696c5f43eb6"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D7", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a04160a6-d3aa-437e-bf81-a40b7911209e"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F6", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a15609df-9f89-493e-8ad4-90de7d33f2a0"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S15", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a1a99de9-5a29-4ddf-b29d-be9a7727c0d2"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S19", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a1dccb34-4ee4-4fcc-8f1d-a0efe3f78f1d"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S8", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a2276b49-2055-4cc6-942e-509b0744b832"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D20", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a2a3e9fb-1f5b-449b-bbef-d0975f7f5266"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S6", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a3b61a25-8a02-4a89-9ce6-4641f2ee5eb1"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D18", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a3e06549-8afb-452d-a22f-0992ff6964e2"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D14", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a3fb7c2d-4648-4e94-adbf-b445c34a4ce7"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F12", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a42a40f6-e40a-42ec-8b76-e9ed17d2f3a5"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S16", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a5c939ad-440d-4898-9105-ef330b6e4c88"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F11", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a6e2c03d-f27a-4248-a0cf-e48d218b752a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F14", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a72624f6-f24c-4799-b6a8-07e7f80827ad"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S19", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a74631a7-da16-4795-9aa4-10b5a1484c03"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D1", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a75d6ed2-1e32-478d-bf76-56b407b03513"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S2", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a773ac90-002b-4d77-bf8d-9ed3020b076c"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D12", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("a79b12b2-6af4-473c-825c-7e4b54dda3a0"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F1", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a8081086-b5e5-4c0f-8553-3fef3b086871"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F16", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("a8c0f77a-3c75-4b37-ba3d-bf10c7220fc8"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S7", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("a957731a-afb5-44b7-b628-a7cb6cb2f9cf"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F3", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("aa053996-24ff-4f94-bc6c-0805993f5725"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D2", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("aa09a794-6f29-4357-b543-3339c2c0295e"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D8", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("aad0fce1-3b8e-4ce4-beae-bdcbf22db34c"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D5", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ab463c71-a92a-4506-b621-97e8f4f3a459"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S7", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ab7055d9-f293-4639-81eb-8aa7c5eab270"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S7", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("abd0d1b9-9e60-4cfd-8263-e2ec06f84495"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F17", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("abfd39d7-6770-4406-8b2b-cb0e3dae3b39"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D3", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ad078be4-2979-40ac-8607-fd10fd3a898d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F19", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("adfa58f5-4ecf-474c-b2a0-d5215b782de4"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F15", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ae2c4597-46e8-4cc3-a1e8-feff71d83535"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D1", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ae341c3a-66ab-41c9-af09-9ea73bc97bc1"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F7", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("aec7e9a7-dca4-48fd-9122-953afc22cb47"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D11", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("afd5231d-e41c-429e-a203-72312460b339"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F3", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("afedfc85-89bb-4fbe-9102-dddcd11d5b09"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D5", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b081c353-ca58-4d67-b8d4-b50c391063c6"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S6", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("b0b5f826-2b3b-4cf1-8ea0-92a6efb0798b"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D10", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b0d7c5b5-5059-4243-b8b7-7bf7e4b59c30"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D2", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b1145628-1a85-4287-9192-6c6287adb28a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F13", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b11dcded-2164-41a1-a248-1c56c6a10a64"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F20", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b195b8a4-8d4f-48a6-a9b6-4361de939d7c"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S14", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("b1d4ea52-9440-43ff-8a3f-9a3bbdda4e2f"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F15", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b22388c8-eff3-42d9-b290-a5eb9ba9468a"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F4", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b232d809-2b84-4250-8b6c-74bbc9683807"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F1", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b254faef-6d32-41b5-b33d-2285a47fdf4e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F18", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b32d690c-c235-4cfb-8ef8-18c2fb1e0158"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D20", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b3c5f5b5-59ef-4d4e-96dc-85fe2736fcc9"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F9", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b3eb1b4f-efc9-40ca-a3fb-55f7fdde0f5e"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D15", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b4771fb7-bd41-460a-9c29-d4af089a4582"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F10", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b52278b4-493d-4e93-8122-d37d729923e5"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D6", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b6d35e3e-2de9-4fc0-a8cc-ea30230c7d76"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F9", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b7149a55-4909-48d0-ba89-a303c27789ee"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S12", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("b7360254-bd86-48fe-8fc7-6fdba4a267be"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S3", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("b76e049b-1fa3-4761-94f5-6b7bd3e977ca"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F12", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("b811af8f-76a5-4c2a-82ce-9c851fd7098a"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D2", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b815701a-2cb7-4345-814f-1c1e89dd6772"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D10", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("b8be8618-0e30-4ede-9ac2-f05813cf53b6"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D20", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ba1d247e-9363-481a-9486-fca700faa06e"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S1", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("bb0f7228-6438-46c3-b388-f6e63214ec17"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F9", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("bb386a56-0ead-4b69-84e6-1829cb0d901e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S6", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("bb932ba1-480b-402a-817e-e626feb92831"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S5", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("bc31c719-4874-4e1e-ab38-8a0fbc170801"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F16", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("bc4ca2e7-6891-43c6-ad97-c0618f032fa4"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D16", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("bc534d0c-a199-4033-9416-fcc7947a0991"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F13", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("bcb9dffe-e57b-402e-aaaf-ad55826a9d02"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D15", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("bf20793b-9002-4ebe-a8c8-ad04d7b7638e"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S18", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("bfd988e7-fe3c-4b4a-ba60-aff50dbc231f"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D7", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c1095d6a-af2e-4e02-88d6-8b94a08ea17e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D17", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c19fb779-a331-48ac-b4e7-1f7122006607"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F16", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("c1af204e-ae49-4547-b201-4353ef2cd335"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D14", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c213650d-36bf-4645-a990-0c17ebb6555b"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S16", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c28aa5d0-15ee-4a90-b8c8-c2d63e337a8a"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D12", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c2d83c37-385d-42d6-ab9a-f2cd1b6fcca5"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S12", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c3c4e26e-5cee-428b-8d53-366fe2552a64"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S9", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c4321c8d-1d11-4a6c-9ec0-bb20bc528def"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D17", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c43c3df2-1f7d-4cbb-939b-7c71a0bb754e"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S5", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c4c2de23-46d0-4aab-a412-6d14dcb9bc0c"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D13", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c5011c5f-dc3b-493a-a9b1-fb1b3c5b0a8c"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S9", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c5ae65c0-1656-4b15-8bb4-c24114509653"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F6", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("c681a84e-b644-48a9-9fb8-bc90f526ac2b"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F19", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("c69e7842-aff3-401a-971d-785912261db0"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S20", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c6b74f44-75e7-49fe-95d5-ad6fd7c14ea0"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D11", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c7eb285b-d174-46c3-b16d-9e784ddde72a"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D13", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("c7ed4b20-d3ad-4dbf-9caa-0b9242bf3094"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S19", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c930b847-098b-49a3-bb61-f2f3ac1df4ca"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S13", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("c955aa66-0f3f-4787-951d-82a528650a1d"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S9", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ca614b3c-53bb-4fca-b5ed-af7550a0b215"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S11", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ca718f57-9429-4b2d-8627-b80391e5f1dc"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F6", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("caab6314-2d68-43ef-9339-73148738b557"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F3", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("caba4197-0324-4e20-815e-f8d760d7fb89"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D5", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("cad547f3-9949-4b73-947e-4d2dcffc65d3"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S8", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("cb00bac6-d05e-4163-8b8d-ba843e984892"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F4", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("cb90c734-ccee-4f35-bcc2-d2f7d0a2f11f"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F17", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("cbbbd42b-93b5-423b-96c5-7f0a44e95642"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D15", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ccc53ffb-3d50-42cf-9b56-0f6e59f97355"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S16", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ccfbaac5-5120-469e-b664-6dffdba6b2c0"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S11", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("cd795411-bd7a-4975-9b21-43e80e5ec897"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D7", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("cd950ece-0aba-4b8d-bfae-4cdf8fbb5ead"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F13", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ce9a2584-d7ad-4e23-aa00-a4c9f5ce2c22"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F11", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("cf375d17-cb21-41d0-89e1-cbe6139dcaa0"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S12", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d1dd2e20-ccde-4b58-8feb-87496bd0801b"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S6", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d23e76e3-d245-4d23-bade-d4ab7935e1a8"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F3", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d27c3e5f-666c-4b78-83b3-7068cb850a37"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S18", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d366b1c1-3a62-4ebc-b093-dff4e52ec470"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F2", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d3d5e680-be89-4e8b-88dc-727bfb396a9a"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D7", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("d47ec2b4-4526-4ee8-9287-b2402eb68e99"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F15", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d48488d4-4944-4514-9222-d90fc4994fce"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D11", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("d5788ad5-cec0-46f1-97dd-41db8bc0b390"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S8", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d59f2dab-c5e3-4396-a626-4b2481a47774"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F10", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d6460e14-96d0-4322-ad90-064867de8ade"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S13", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d71038cd-f6c6-41dd-8c56-7474fb7351c5"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F15", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d7732fa6-5884-4054-875b-3f2cb34f1311"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S13", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d7c713a1-2dcf-4d37-aaa4-a5564be4dec0"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D20", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("d940b495-9759-4ec7-87db-437239f08195"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S2", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("d95cf7cd-3c7c-4e77-a05c-7d79b1ed4ea3"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F20", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("d9d585f9-d679-4115-ae41-f00cd45ea40d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D5", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("dacf846e-d615-42f6-86db-b9309279b054"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F11", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("db036f81-6a7f-4836-b866-4e1be7b4adb4"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D1", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("db592e68-01ba-497e-adaf-e5d2e5a1641a"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D19", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("dc477993-dc3a-4f74-8135-203d1f3b8bca"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F18", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("dc62d94f-4aec-4db0-97c7-4486846f5ff8"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S14", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("dc9f8f2f-45f8-44cf-bb32-be98fd1f182f"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D19", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("dd7c858f-185f-4420-af0b-92fe4869728e"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F10", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("dd8d0cc6-90cc-4277-9b2f-3ddbb8ffcc12"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S7", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ddd23b73-923c-48c1-9c66-7d7dc1e257dc"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S4", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("de3d9de8-49d2-4be0-8a47-d132fe29fecb"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "D9", 250m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("de6c8e50-c5cc-4207-904d-3e83d8c908a6"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F17", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("df140951-54d8-4e2e-82e0-ffebd34e4900"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S4", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("df414d09-a022-4f70-9a66-169937ed7462"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S5", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("df7cdb76-2371-462c-8c78-e4635e5ca40b"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S15", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("dfa50d6b-ca68-4af8-a96f-e72f0b340c1f"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S12", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("dfa627cf-f073-4c42-9491-062191759480"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F7", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("dff0bb36-0672-4fcd-acad-349242b1434f"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D17", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e025a644-5b74-4a69-9441-e09b59a60e4e"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D2", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e0a437fb-2dbf-48c0-a77b-f58075343262"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D10", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e0de4347-60f9-441c-b636-89ec2b0e9479"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S18", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e0df0168-18f5-4cf3-8094-d0b3ae0683d2"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "D18", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e10f50df-d1ab-4be7-8633-c40d9b1862ec"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F7", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("e138d22b-8aa6-408d-be68-b63a1b37d8c6"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D12", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e263487d-6a3a-48f0-b800-0c25f7fb42a3"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F1", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("e2b43dc0-7567-42e6-976b-d0d86adf7ffb"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S16", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e34112b8-d7f4-4044-b5b4-f446c11fc34b"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S14", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e3a9c552-a926-4e25-833b-67c54d767997"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D1", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("e4fcf9b7-3b65-4a18-81b4-e48dd8fab817"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F3", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("e51255dc-b2aa-47cc-bc9b-d02859e6d472"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "S4", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e5cb185c-b11a-41f3-93cc-d86cc1b8b983"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S5", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e64acf8f-ca2e-4b7f-9a25-5457b7cd3218"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F17", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("e7a25e50-215f-4cba-9bf9-5af180c15e65"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "S9", 200m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("e80035c6-b4da-45fc-92fc-7b72a4373e45"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S17", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ea826203-86ae-45a9-b434-21e422d418d2"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S4", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ea84ef01-1ca5-48fa-8913-29d2d514c571"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D8", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ebedc6ec-46f3-4a9c-9f6d-e5c19ca17a77"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S10", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ecc4916a-95e4-4600-b026-da7731b6a187"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S5", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ed5339f8-5e5f-442a-8438-f1de0282d1c1"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F19", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("edb8af16-29ab-4ac8-9f3b-76c360b6ed91"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D11", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("edfc0d4f-fc15-4e8e-bb7c-2a2897a72c92"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S4", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("ee3c1d8d-6e19-41ce-9b76-648c3c936365"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D9", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ee66de2e-de78-4767-9683-41ae4a44871b"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F20", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ef780f3e-0252-4cd2-b27e-23a7609acaab"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "S15", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("efce35e2-b342-4ea0-ba3e-e79ffc279809"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "D9", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f0a3fc5d-a32d-46c2-91e3-1c85746e361a"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "S2", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f0b4ea56-ad59-4601-bb03-e68c5d1d5aca"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D7", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f13b90bf-23d7-4cf0-bb7f-c7e98bbcc6a6"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S8", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f183e07c-89cd-4dfc-82ed-b7b992cc15d5"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F6", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f19d68d4-686e-4dc8-844b-6c3a40a6df06"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "F9", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f25a062a-1bb6-4612-83c5-8b1a4b26dde1"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F3", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f2e9c3d7-e600-48c4-9a12-584c2699c8da"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F8", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f32fb353-841c-4de4-9c08-9f6a1c19e77d"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S15", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f34aa1e6-d6e8-4594-8550-4cc1992a7a3b"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "D12", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f37fd8ca-e716-468f-9a0d-63a3c378b35c"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S7", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f3e09d99-0b0c-495d-8f4b-18727eaeb573"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F19", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f424c8d6-0df4-439e-a7f5-48f0edf9dd6d"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "S18", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f45f08cc-0035-4840-9446-99a22cbb853c"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "S18", 300m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f48ea4b6-86be-4b83-b583-2e9812d32710"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "D4", 200m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f4a0cefb-249d-4020-a98a-42fe5ef6f0e0"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F2", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f5ac5810-9c0f-4a8f-8afd-9d1578f6e92a"), new Guid("7aa35052-a547-4424-b418-e2fe83c6ed0c"), "F2", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f6291224-609e-4b1e-bc96-ed877d3fd5f7"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F20", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f6abcb40-0a28-48fd-b7a3-afcb547debdb"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F16", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f6d12e54-01aa-494e-b6c0-37a7ae494711"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F4", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f75cac82-d5ed-4a07-894f-4934d27e9273"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F3", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f88139d2-13b6-4489-9b3f-5934b082f5e2"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D16", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f89331ce-02ba-42f7-8745-b519c4542b5a"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "D18", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("f8b1cba5-9a9f-45f3-8ef8-17e03bbf2388"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "S18", 250m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("f92ca9e6-5b67-491a-b6ed-8e15f26b60a2"), new Guid("9565a792-78d9-42c8-8874-53a2b350ff9d"), "F18", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("f94b669a-02fc-4b78-af4f-05ff2c00d5fe"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F15", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fa6ac545-92af-4391-84c1-54a3c052ebad"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "S17", 100m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("faf7b730-e716-4903-bb34-ae2f1ade9b34"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F5", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fb67eb98-465d-43c9-8ecc-ff27af73d209"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F16", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fb6ac890-a2b5-46a3-a23f-36819f845288"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "S3", 150m, new Guid("6f1bcb97-d827-4144-bb18-84ca9146b82a") },
                    { new Guid("fb81311e-e42a-490f-9e0c-c89224359e12"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D6", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("fbb554e5-a56d-4cb3-bf97-d92c6a0e6630"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D18", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("fd10728a-95fd-46b1-a5ae-7db9ad5c281b"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F8", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fd1ef203-aea2-4682-b172-9f8af0f09e81"), new Guid("7ccb3ba5-11a7-40e9-ade9-861a12fade99"), "F11", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fd6f1bf0-98ea-4a14-91f2-7b6b66b89b51"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D14", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("fdad8624-62af-4395-adf5-575f189d2e38"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F20", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fe30dda0-49e6-4792-8b73-3ec068c1281f"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "F18", 400m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("fe6bd5ed-0e79-4321-b6f9-9cc5fc59efc3"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "D13", 300m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("fe6ea632-857a-4881-aa7b-bdce375ed894"), new Guid("974175b6-ccec-468f-b93d-e52ed020b082"), "D4", 350m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("feaef243-83ba-4e82-bacc-15afbb4fdbc6"), new Guid("0a397ba5-646e-4993-a7c6-63cefccf3c86"), "F13", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ff1ac77d-03bd-4c2f-968b-d417b8239eba"), new Guid("51f0027c-d669-4799-868e-b59ce0b8595c"), "F15", 350m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ff21f37d-9324-4dcf-b180-496679a092f6"), new Guid("a05218c6-1f5d-4c7c-a3c9-6c17525fbdc1"), "D5", 400m, new Guid("1b4f89e1-074b-4676-b2f5-b5120b1411d0") },
                    { new Guid("ff241e1a-62d2-4f06-a103-687b9f6cdd32"), new Guid("81437b19-72c3-46fb-975e-9805e2110327"), "F9", 450m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") },
                    { new Guid("ff676a9b-ca31-4638-938d-f57737a95284"), new Guid("9515b505-7761-4b87-bb40-21da06551406"), "F14", 300m, new Guid("569e0916-d83e-40fb-a3f7-d6d0a9df68e4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerNumber",
                table: "Bookings",
                column: "CustomerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookings_RoomId",
                table: "RoomBookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_TourBookings_TourId",
                table: "TourBookings",
                column: "TourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "RoomBookings");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "TourBookings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
