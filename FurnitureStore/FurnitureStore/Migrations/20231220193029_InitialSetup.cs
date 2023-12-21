using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Furnitures",
                columns: table => new
                {
                    FurnitureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FurnitureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FurnitureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FurniturePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FurnitureImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FurnImgThumbNailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clearance = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnitures", x => x.FurnitureID);
                    table.ForeignKey(
                        name: "FK_Furnitures_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDesc", "CategoryName" },
                values: new object[,]
                {
                    { 1, "", "Couches" },
                    { 2, "", "Accent Chairs" },
                    { 3, "", "Side Tables" },
                    { 4, "", "Consoles/Cabinets" },
                    { 5, "", "Dining Tables" },
                    { 6, "", "Dining Chairs" },
                    { 7, "", "Dining Benches" },
                    { 8, "", "Bedframes" },
                    { 9, "", "Dressers" },
                    { 10, "", "Nightstands" },
                    { 11, "", "Dining Sets" },
                    { 12, "", "Desks" },
                    { 13, "", "Office Chairs" }
                });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "FurnitureID", "CategoryID", "Clearance", "FurnImgThumbNailUrl", "FurnitureDescription", "FurnitureImgUrl", "FurnitureName", "FurniturePrice" },
                values: new object[,]
                {
                    { 1, 9, false, "", "A brown wood dresser perfect for your bedroom.", "/images/bedroom/BrownWoodDresser.jpg", "Brown Wood Dresser", 349.99m },
                    { 2, 9, false, "", "A grey wood dresser perfect for your bedroom.", "/images/bedroom/GreyWoodDresser.jpg", "Grey Wood Dresser", 349.99m },
                    { 3, 10, false, "", "A grey wood night stand to match your dresser.", "/images/bedroom/GreyWoodNightStand.jpg", "Grey Wood Nightstand", 249.99m },
                    { 4, 8, false, "", "A solid black metal frame for your bed (sold seperately).", "/images/bedroom/MetalBedFrame.jpg", "Metal Bedframe", 299.99m },
                    { 5, 8, false, "", "A cushioned frame for your bed (sold seperately).", "/images/bedroom/ModernBedFrame.jpg", "Modern Bedframe", 399.99m },
                    { 6, 10, false, "", "A rustic nighstand perfect for your bedroom.", "/images/bedroom/RusticNighStand.jpg", "Rustic Nightstand", 249.99m },
                    { 7, 9, false, "", "A white wooden dresser perfect for your bedroom.", "/images/bedroom/WhiteWoodDresser.jpg", "White Wood Dresser", 499.99m },
                    { 8, 8, false, "", "A grey wooden frame for your bed (sold seperately).", "/images/bedroom/WoodBedFrame.jpg", "Wood Bedframe", 399.99m },
                    { 9, 8, false, "", "A black wooden chair for your dining room.", "/images/bedroom/WoodBedFrame.jpg", "Black Wood Dining Chair", 199.99m },
                    { 10, 6, true, "", "A black wooden chair for your dining room.", "/images/bedroom/WoodBedFrame.jpg", "Black X Dining Chair", 199.99m },
                    { 11, 6, false, "", "A cream cushioned chair for your dining room.", "/images/bedroom/CreamDiningChair.jpg", "Cream Dining Chair", 249.99m },
                    { 12, 11, false, "", "A dark wood 3pc dining set, perfect for your dining room.", "/images/bedroom/DarkDiningSet.jpg", "Dark 3pc Dining Set", 599.99m },
                    { 13, 5, false, "", "A round, dark wood dining table.", "/images/bedroom/DarkRoundWoodDiningTable.jpg", "Dark Round Dining Table", 599.99m },
                    { 14, 6, false, "", "A denim cushioned dining chair, perfect for your dining table.", "/images/bedroom/DenimDiningChair.jpg", "Denim Cushioned Dining Chair", 249.99m },
                    { 15, 7, false, "", "A farmhouse style dining bench, perfect for your dining table.", "/images/bedroom/FarmhouseDiningBench.jpg", "Farmhouse Dining Bench", 349.99m },
                    { 16, 6, false, "", "A farmhouse style dining chair, perfect for your dining table.", "/images/bedroom/FarmhouseDiningChair.jpg", "Farmhouse Dining Chair", 199.99m },
                    { 17, 11, false, "", "A farmhouse style 3pc dining set, perfect for your dining room.", "/images/bedroom/FarmhouseDiningSet.jpg", "6pc Farmhouse Dining Set", 1099.99m },
                    { 18, 5, false, "", "A farmhouse style dining table, perfect for your dining room.", "/images/bedroom/FarmhouseDiningTable.jpg", "Farmhouse Dining Table", 699.99m },
                    { 19, 11, false, "", "A 6pc light wood dining set, perfect for your dining room.", "/images/bedroom/LightDiningSet.jpg", "6pc Light Wood Dining Set", 1099.99m },
                    { 20, 5, false, "", "A light wood round dining table, perfect for your dining room.", "/images/bedroom/LightRoundWoodDiningTable.jpg", "Light Round Dining Table", 599.99m },
                    { 21, 6, true, "", "A light wood dining chair, perfect for your dining table.", "/images/bedroom/LightXDiningChair.jpg", "Light X Dining Chair", 199.99m },
                    { 22, 7, true, "", "A rustic style dining bench, perfect for your dining table.", "/images/bedroom/RusticDiningBench.jpg", "Rustic Dining Bench", 349.99m },
                    { 23, 5, true, "", "A rustic style dining table, perfect for your dining room.", "/images/bedroom/RusticDiningTable.jpg", "Rustic Dining Table", 699.99m },
                    { 24, 3, false, "", "A wire basket side table to store blankets.", "/images/bedroom/BasketSideTable.jpg", "Basket Side Table", 199.99m },
                    { 25, 3, false, "", "A wire style coffee table for your living room.", "/images/bedroom/CageCoffeeTable.jpg", "Wire Coffee Table", 249.99m },
                    { 26, 2, false, "", "A cream colored accent chair, perfect for your living room.", "/images/bedroom/CreamChair.jpg", "Cream Accent Chair", 349.99m },
                    { 27, 4, false, "", "A wooden cream console table, perfect for your living room.", "/images/bedroom/CreamConsoleTable.jpg", "Cream Console Table", 349.99m },
                    { 28, 4, false, "", "A rustic style cabinet with sliding wooden door, perfect for your living room.", "/images/bedroom/DarkRusticCabinet.jpg", "Dark Rustic Cabinet", 399.99m },
                    { 29, 4, false, "", "A rustic style cabinet with glass doors, perfect for your living room.", "/images/bedroom/DarkWoodCabinet.jpg", "Dark Wood Cabinet", 499.99m },
                    { 30, 2, false, "", "A denim accent chair, perfect for your living room.", "/images/bedroom/DenimChair.jpg", "Denim Accent Chair", 349.99m },
                    { 31, 2, false, "", "A faux leather accent chair, perfect for your living room.", "/images/bedroom/FauxLeatherChair.jpg", "Faux Leather Accent Chair", 399.99m },
                    { 32, 1, false, "", "A faux leather couch, perfect for your living room.", "/images/bedroom/FauxLeatherCouch.jpg", "Faux Leather Couch", 799.99m },
                    { 33, 2, false, "", "A faux leather recliner, perfect for your living room.", "/images/bedroom/FauxLeatherRecliner.jpg", "Faux Leather Recliner", 599.99m },
                    { 34, 4, false, "", "A TV stand with a built in fireplace.", "/images/bedroom/FireplaceTVStand.jpg", "Fireplace TV Stand", 699.99m },
                    { 35, 3, true, "", "A hex shaped side table, perfect for your living room.", "/images/bedroom/HexSideTable.jpg", "Hex Side Table", 199.99m },
                    { 36, 4, false, "", "A light wood, rustic style cabinet, perfect for your living room.", "/images/bedroom/LightRusticCabinet.jpg", "Light Rustic Cabinet", 399.99m },
                    { 37, 4, false, "", "A light wood cabinet, perfect for your living room.", "/images/bedroom/LightWoodCabinet.jpg", "Light Wood Cabinet", 499.99m },
                    { 38, 3, false, "", "An industrial style coffee table perfect for your living room.", "/images/bedroom/RusticCoffeeTable.jpg", "Industrial Coffee Table", 399.99m },
                    { 39, 4, false, "", "A rustic style console table perfect for your living room.", "/images/bedroom/RusticConsoleTable.jpg", "Rustic Console Table", 299.99m },
                    { 40, 4, false, "", "A rustic style TV stand, perfect for your living room.", "/images/bedroom/RusticTVStand.jpg", "Rustic TV Stand", 299.99m },
                    { 41, 3, true, "", "A scalloped coffee table, perfect for your living room.", "/images/bedroom/ScallopCoffeeTable.jpg", "Scallop Coffee Table", 299.99m },
                    { 42, 3, false, "", "A scalloped side table, perfect for your living room.", "/images/bedroom/ScallopSideTable.jpg", "Scallop Side Table", 199.99m },
                    { 43, 1, true, "", "A shell shaped loveseat, perfect for your living room.", "/images/bedroom/ShellCouch.jpg", "Shell Loveseat", 599.99m },
                    { 44, 1, false, "", "A speckled cream loveseat, perfect for your living room.", "/images/bedroom/VanillaSpeckedLoveSeat.jpg", "Vanilla Speckled Loveseat", 599.99m },
                    { 45, 12, false, "", "A cream colored wooden desk for your office.", "/images/bedroom/CreamDesk.jpg", "Cream Desk", 349.99m },
                    { 46, 13, true, "", "A cream cushioned swivel chair for your office.", "/images/bedroom/CreamDeskChair.jpg", "Cream Office Chair", 199.99m },
                    { 47, 13, false, "", "A wood and cream cushioned swivel chair for your office.", "/images/bedroom/CreamWoodDeskChair.jpg", "Cream Wood Office Chair", 199.99m },
                    { 48, 12, false, "", "A dark wood desk for your office.", "/images/bedroom/DarkWoodDesk.jpg", "Dark Wood Desk", 299.99m },
                    { 49, 12, false, "", "A farmhouse style desk for your office.", "/images/bedroom/FarmhouseDesk.jpg", "Farmhouse Desk", 299.99m },
                    { 50, 13, false, "", "A faux leather swivel chair desk for your office.", "/images/bedroom/FauxLeatherDeskChair.jpg", "Faux Leather Office Chair", 199.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_CategoryID",
                table: "Furnitures",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
