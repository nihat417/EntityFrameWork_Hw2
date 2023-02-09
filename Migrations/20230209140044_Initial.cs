using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWorkHw2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "FirstName"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "LastName")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmentss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmentss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facultiess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultiess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacherss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDep = table.Column<int>(name: "Id_Dep", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacherss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacherss_Departmentss_Id_Dep",
                        column: x => x.IdDep,
                        principalTable: "Departmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groupss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdFacultity = table.Column<int>(name: "Id_Facultity", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groupss_Facultiess_Id_Facultity",
                        column: x => x.IdFacultity,
                        principalTable: "Facultiess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    YearPress = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdThemes = table.Column<int>(name: "Id_Themes", type: "int", nullable: false),
                    IdCategory = table.Column<int>(name: "Id_Category", type: "int", nullable: false),
                    IdAuthor = table.Column<int>(name: "Id_Author", type: "int", nullable: false),
                    IdPress = table.Column<int>(name: "Id_Press", type: "int", nullable: false),
                    Commennt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookss_Authorss_Id_Author",
                        column: x => x.IdAuthor,
                        principalTable: "Authorss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Categorys_Id_Category",
                        column: x => x.IdCategory,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Presss_Id_Press",
                        column: x => x.IdPress,
                        principalTable: "Presss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Themess_Id_Themes",
                        column: x => x.IdThemes,
                        principalTable: "Themess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studentss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGroup = table.Column<int>(name: "Id_Group", type: "int", nullable: false),
                    Term = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studentss_Groupss_Id_Group",
                        column: x => x.IdGroup,
                        principalTable: "Groupss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Cardss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeacher = table.Column<int>(name: "Id_Teacher", type: "int", nullable: false),
                    IdBooks = table.Column<int>(name: "Id_Books", type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLib = table.Column<int>(name: "Id_Lib", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cardss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Cardss_Bookss_Id_Books",
                        column: x => x.IdBooks,
                        principalTable: "Bookss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cardss_Libss_Id_Lib",
                        column: x => x.IdLib,
                        principalTable: "Libss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cardss_Teacherss_Id_Teacher",
                        column: x => x.IdTeacher,
                        principalTable: "Teacherss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "S_Cardss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(name: "Id_Student", type: "int", nullable: false),
                    IdBooks = table.Column<int>(name: "Id_Books", type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLib = table.Column<int>(name: "Id_Lib", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Cardss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_S_Cardss_Bookss_Id_Books",
                        column: x => x.IdBooks,
                        principalTable: "Bookss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cardss_Libss_Id_Lib",
                        column: x => x.IdLib,
                        principalTable: "Libss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cardss_Studentss_Id_Student",
                        column: x => x.IdStudent,
                        principalTable: "Studentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Author",
                table: "Bookss",
                column: "Id_Author");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Category",
                table: "Bookss",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Press",
                table: "Bookss",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Themes",
                table: "Bookss",
                column: "Id_Themes");

            migrationBuilder.CreateIndex(
                name: "IX_Groupss_Id_Facultity",
                table: "Groupss",
                column: "Id_Facultity");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Books",
                table: "S_Cardss",
                column: "Id_Books");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Lib",
                table: "S_Cardss",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Student",
                table: "S_Cardss",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_Studentss_Id_Group",
                table: "Studentss",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Books",
                table: "T_Cardss",
                column: "Id_Books");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Lib",
                table: "T_Cardss",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Teacher",
                table: "T_Cardss",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teacherss_Id_Dep",
                table: "Teacherss",
                column: "Id_Dep");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Cardss");

            migrationBuilder.DropTable(
                name: "T_Cardss");

            migrationBuilder.DropTable(
                name: "Studentss");

            migrationBuilder.DropTable(
                name: "Bookss");

            migrationBuilder.DropTable(
                name: "Libss");

            migrationBuilder.DropTable(
                name: "Teacherss");

            migrationBuilder.DropTable(
                name: "Groupss");

            migrationBuilder.DropTable(
                name: "Authorss");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Presss");

            migrationBuilder.DropTable(
                name: "Themess");

            migrationBuilder.DropTable(
                name: "Departmentss");

            migrationBuilder.DropTable(
                name: "Facultiess");
        }
    }
}
