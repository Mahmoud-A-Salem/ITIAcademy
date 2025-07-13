using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITIAcademy.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Manager = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Degree = table.Column<int>(type: "INT", nullable: false),
                    MinDegree = table.Column<int>(type: "INT", nullable: false),
                    Hours = table.Column<int>(type: "INT", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Grade = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TraineeCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "INT", nullable: false),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TraineeCourses_Trainees_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Trainees",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Dr. Maha Ali", "Computer Science" },
                    { 2, "Dr. Ahmed Hassan", "Information Technology" },
                    { 3, "Dr. Sara Maged", "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DepartmentId", "Hours", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100, 1, 30, 50, "Introduction to Programming" },
                    { 2, 100, 2, 40, 50, "Database Management" },
                    { 3, 100, 3, 35, 50, "Web Development" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Address", "DepartmentId", "Grade", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "Cairo, Egypt", 1, "Level 1", "1.png", "Ahmed Ali" },
                    { 2, "Giza, Egypt", 2, "Level 2", "2.png", "Sara Mohamed" },
                    { 3, "Alexandria, Egypt", 3, "Level 3", "1.png", "Omar Hassan" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Address", "CourseId", "DepartmentId", "ImageURL", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo, Egypt", 1, 1, "1.png", "Mahmoud Ali", 5000 },
                    { 2, "New York, USA", 2, 2, "1.png", "Jane Smith", 4500 },
                    { 3, "Los Angeles, USA", 3, 3, "1.png", "Bob Johnson", 4700 },
                    { 4, "Miami, USA", 1, 1, "2.png", "Alice Brown", 4800 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructors",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeCourses_CourseId",
                table: "TraineeCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_DepartmentId",
                table: "Trainees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "TraineeCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
