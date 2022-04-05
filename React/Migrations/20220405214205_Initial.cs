using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace React.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Api",
                columns: table => new
                {
                    ApiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Api", x => x.ApiId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IntroductionId = table.Column<int>(type: "int", nullable: false),
                    FundamentalsOneId = table.Column<int>(type: "int", nullable: false),
                    FundamentalsTwoId = table.Column<int>(type: "int", nullable: false),
                    ReduxId = table.Column<int>(type: "int", nullable: false),
                    NoSQLId = table.Column<int>(type: "int", nullable: false),
                    ApiId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundamentalsOne",
                columns: table => new
                {
                    FundamentalsOneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundamentalsOne", x => x.FundamentalsOneId);
                });

            migrationBuilder.CreateTable(
                name: "FundamentalsTwo",
                columns: table => new
                {
                    FundamentalsTwoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundamentalsTwo", x => x.FundamentalsTwoId);
                });

            migrationBuilder.CreateTable(
                name: "Introduction",
                columns: table => new
                {
                    IntroductionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Introduction", x => x.IntroductionId);
                });

            migrationBuilder.CreateTable(
                name: "NoSQL",
                columns: table => new
                {
                    NoSQLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoSQL", x => x.NoSQLId);
                });

            migrationBuilder.CreateTable(
                name: "Redux",
                columns: table => new
                {
                    ReduxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redux", x => x.ReduxId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
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
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
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
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
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
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Value = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Api");

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
                name: "FundamentalsOne");

            migrationBuilder.DropTable(
                name: "FundamentalsTwo");

            migrationBuilder.DropTable(
                name: "Introduction");

            migrationBuilder.DropTable(
                name: "NoSQL");

            migrationBuilder.DropTable(
                name: "Redux");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
