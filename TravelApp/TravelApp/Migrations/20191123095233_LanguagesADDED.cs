using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApp.Migrations
{
    public partial class LanguagesADDED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    AboutId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutLanguages_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortDesc = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceLanguages_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SettingLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    SettingId = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    AboutUs = table.Column<string>(nullable: true),
                    ShowroomHours = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SettingLanguages_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestimonialId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestimonialLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestimonialLanguages_Testimonials_TestimonialId",
                        column: x => x.TestimonialId,
                        principalTable: "Testimonials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_AboutId",
                table: "AboutLanguages",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_LanguageId",
                table: "AboutLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLanguages_LanguageId",
                table: "ServiceLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLanguages_ServiceId",
                table: "ServiceLanguages",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingLanguages_LanguageId",
                table: "SettingLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingLanguages_SettingId",
                table: "SettingLanguages",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_TestimonialLanguages_LanguageId",
                table: "TestimonialLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_TestimonialLanguages_TestimonialId",
                table: "TestimonialLanguages",
                column: "TestimonialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutLanguages");

            migrationBuilder.DropTable(
                name: "ServiceLanguages");

            migrationBuilder.DropTable(
                name: "SettingLanguages");

            migrationBuilder.DropTable(
                name: "TestimonialLanguages");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
