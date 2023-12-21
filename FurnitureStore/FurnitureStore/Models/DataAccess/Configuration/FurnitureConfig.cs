using FurnitureStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace FurnitureStore.Models.DataAccess.Configuration
{
    internal class FurnitureConfig : IEntityTypeConfiguration<Furniture>
    {
        public void Configure(EntityTypeBuilder<Furniture> entity)
        {
            entity.HasData(
                new Furniture
                {
                    FurnitureID = 1,
                    FurnitureName = "Brown Wood Dresser",
                    FurnitureDescription = "A brown wood dresser perfect for your bedroom.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/BrownWoodDresser.jpg",
                    Clearance = false,
                    CategoryID = 9
                },
                new Furniture
                {
                    FurnitureID = 2,
                    FurnitureName = "Grey Wood Dresser",
                    FurnitureDescription = "A grey wood dresser perfect for your bedroom.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/GreyWoodDresser.jpg",
                    Clearance = false,
                    CategoryID = 9
                },
                new Furniture
                {
                    FurnitureID = 3,
                    FurnitureName = "Grey Wood Nightstand",
                    FurnitureDescription = "A grey wood night stand to match your dresser.",
                    FurniturePrice = 249.99m,
                    FurnitureImgUrl = "/images/bedroom/GreyWoodNightStand.jpg",
                    Clearance = false,
                    CategoryID = 10
                },
                new Furniture
                {
                    FurnitureID = 4,
                    FurnitureName = "Metal Bedframe",
                    FurnitureDescription = "A solid black metal frame for your bed (sold seperately).",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/MetalBedFrame.jpg",
                    Clearance = false,
                    CategoryID = 8
                },
                new Furniture
                {
                    FurnitureID = 5,
                    FurnitureName = "Modern Bedframe",
                    FurnitureDescription = "A cushioned frame for your bed (sold seperately).",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/ModernBedFrame.jpg",
                    Clearance = false,
                    CategoryID = 8
                },
                new Furniture
                {
                    FurnitureID = 6,
                    FurnitureName = "Rustic Nightstand",
                    FurnitureDescription = "A rustic nighstand perfect for your bedroom.",
                    FurniturePrice = 249.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticNighStand.jpg",
                    Clearance = false,
                    CategoryID = 10
                },
                new Furniture
                {
                    FurnitureID = 7,
                    FurnitureName = "White Wood Dresser",
                    FurnitureDescription = "A white wooden dresser perfect for your bedroom.",
                    FurniturePrice = 499.99m,
                    FurnitureImgUrl = "/images/bedroom/WhiteWoodDresser.jpg",
                    Clearance = false,
                    CategoryID = 9
                },
                new Furniture
                {
                    FurnitureID = 8,
                    FurnitureName = "Wood Bedframe",
                    FurnitureDescription = "A grey wooden frame for your bed (sold seperately).",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                    Clearance = false,
                    CategoryID = 8
                },
                new Furniture
                {
                    FurnitureID = 9,
                    FurnitureName = "Black Wood Dining Chair",
                    FurnitureDescription = "A black wooden chair for your dining room.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                    Clearance = false,
                    CategoryID = 8
                },
                new Furniture
                {
                    FurnitureID = 10,
                    FurnitureName = "Black X Dining Chair",
                    FurnitureDescription = "A black wooden chair for your dining room.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                    Clearance = true,
                    CategoryID = 6
                },
                new Furniture
                {
                    FurnitureID = 11,
                    FurnitureName = "Cream Dining Chair",
                    FurnitureDescription = "A cream cushioned chair for your dining room.",
                    FurniturePrice = 249.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamDiningChair.jpg",
                    Clearance = false,
                    CategoryID = 6
                },
                new Furniture
                {
                    FurnitureID = 12,
                    FurnitureName = "Dark 3pc Dining Set",
                    FurnitureDescription = "A dark wood 3pc dining set, perfect for your dining room.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/DarkDiningSet.jpg",
                    Clearance = false,
                    CategoryID = 11
                },
                new Furniture
                {
                    FurnitureID = 13,
                    FurnitureName = "Dark Round Dining Table",
                    FurnitureDescription = "A round, dark wood dining table.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/DarkRoundWoodDiningTable.jpg",
                    Clearance = false,
                    CategoryID = 5
                },
                new Furniture
                {
                    FurnitureID = 14,
                    FurnitureName = "Denim Cushioned Dining Chair",
                    FurnitureDescription = "A denim cushioned dining chair, perfect for your dining table.",
                    FurniturePrice = 249.99m,
                    FurnitureImgUrl = "/images/bedroom/DenimDiningChair.jpg",
                    Clearance = false,
                    CategoryID = 6
                },
                new Furniture
                {
                    FurnitureID = 15,
                    FurnitureName = "Farmhouse Dining Bench",
                    FurnitureDescription = "A farmhouse style dining bench, perfect for your dining table.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/FarmhouseDiningBench.jpg",
                    Clearance = false,
                    CategoryID = 7
                },
                new Furniture
                {
                    FurnitureID = 16,
                    FurnitureName = "Farmhouse Dining Chair",
                    FurnitureDescription = "A farmhouse style dining chair, perfect for your dining table.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/FarmhouseDiningChair.jpg",
                    Clearance = false,
                    CategoryID = 6
                },
                new Furniture
                {
                    FurnitureID = 17,
                    FurnitureName = "6pc Farmhouse Dining Set",
                    FurnitureDescription = "A farmhouse style 3pc dining set, perfect for your dining room.",
                    FurniturePrice = 1099.99m,
                    FurnitureImgUrl = "/images/bedroom/FarmhouseDiningSet.jpg",
                    Clearance = false,
                    CategoryID = 11
                },
                new Furniture
                {
                    FurnitureID = 18,
                    FurnitureName = "Farmhouse Dining Table",
                    FurnitureDescription = "A farmhouse style dining table, perfect for your dining room.",
                    FurniturePrice = 699.99m,
                    FurnitureImgUrl = "/images/bedroom/FarmhouseDiningTable.jpg",
                    Clearance = false,
                    CategoryID = 5
                },
                new Furniture
                {
                    FurnitureID = 19,
                    FurnitureName = "6pc Light Wood Dining Set",
                    FurnitureDescription = "A 6pc light wood dining set, perfect for your dining room.",
                    FurniturePrice = 1099.99m,
                    FurnitureImgUrl = "/images/bedroom/LightDiningSet.jpg",
                    Clearance = false,
                    CategoryID = 11
                },
                new Furniture
                {
                    FurnitureID = 20,
                    FurnitureName = "Light Round Dining Table",
                    FurnitureDescription = "A light wood round dining table, perfect for your dining room.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/LightRoundWoodDiningTable.jpg",
                    Clearance = false,
                    CategoryID = 5
                },
                new Furniture
                {
                    FurnitureID = 21,
                    FurnitureName = "Light X Dining Chair",
                    FurnitureDescription = "A light wood dining chair, perfect for your dining table.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/LightXDiningChair.jpg",
                    Clearance = true,
                    CategoryID = 6
                },
                new Furniture
                {
                    FurnitureID = 22,
                    FurnitureName = "Rustic Dining Bench",
                    FurnitureDescription = "A rustic style dining bench, perfect for your dining table.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticDiningBench.jpg",
                    Clearance = true,
                    CategoryID = 7
                },
                new Furniture
                {
                    FurnitureID = 23,
                    FurnitureName = "Rustic Dining Table",
                    FurnitureDescription = "A rustic style dining table, perfect for your dining room.",
                    FurniturePrice = 699.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticDiningTable.jpg",
                    Clearance = true,
                    CategoryID = 5
                },
                new Furniture
                {
                    FurnitureID = 24,
                    FurnitureName = "Basket Side Table",
                    FurnitureDescription = "A wire basket side table to store blankets.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/BasketSideTable.jpg",
                    Clearance = false,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 25,
                    FurnitureName = "Wire Coffee Table",
                    FurnitureDescription = "A wire style coffee table for your living room.",
                    FurniturePrice = 249.99m,
                    FurnitureImgUrl = "/images/bedroom/CageCoffeeTable.jpg",
                    Clearance = false,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 26,
                    FurnitureName = "Cream Accent Chair",
                    FurnitureDescription = "A cream colored accent chair, perfect for your living room.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamChair.jpg",
                    Clearance = false,
                    CategoryID = 2
                },
                new Furniture
                {
                    FurnitureID = 27,
                    FurnitureName = "Cream Console Table",
                    FurnitureDescription = "A wooden cream console table, perfect for your living room.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamConsoleTable.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 28,
                    FurnitureName = "Dark Rustic Cabinet",
                    FurnitureDescription = "A rustic style cabinet with sliding wooden door, perfect for your living room.",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/DarkRusticCabinet.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 29,
                    FurnitureName = "Dark Wood Cabinet",
                    FurnitureDescription = "A rustic style cabinet with glass doors, perfect for your living room.",
                    FurniturePrice = 499.99m,
                    FurnitureImgUrl = "/images/bedroom/DarkWoodCabinet.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 30,
                    FurnitureName = "Denim Accent Chair",
                    FurnitureDescription = "A denim accent chair, perfect for your living room.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/DenimChair.jpg",
                    Clearance = false,
                    CategoryID = 2
                },
                new Furniture
                {
                    FurnitureID = 31,
                    FurnitureName = "Faux Leather Accent Chair",
                    FurnitureDescription = "A faux leather accent chair, perfect for your living room.",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/FauxLeatherChair.jpg",
                    Clearance = false,
                    CategoryID = 2
                },
                new Furniture
                {
                    FurnitureID = 32,
                    FurnitureName = "Faux Leather Couch",
                    FurnitureDescription = "A faux leather couch, perfect for your living room.",
                    FurniturePrice = 799.99m,
                    FurnitureImgUrl = "/images/bedroom/FauxLeatherCouch.jpg",
                    Clearance = false,
                    CategoryID = 1
                },
                new Furniture
                {
                    FurnitureID = 33,
                    FurnitureName = "Faux Leather Recliner",
                    FurnitureDescription = "A faux leather recliner, perfect for your living room.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/FauxLeatherRecliner.jpg",
                    Clearance = false,
                    CategoryID = 2
                },
                new Furniture
                {
                    FurnitureID = 34,
                    FurnitureName = "Fireplace TV Stand",
                    FurnitureDescription = "A TV stand with a built in fireplace.",
                    FurniturePrice = 699.99m,
                    FurnitureImgUrl = "/images/bedroom/FireplaceTVStand.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 35,
                    FurnitureName = "Hex Side Table",
                    FurnitureDescription = "A hex shaped side table, perfect for your living room.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/HexSideTable.jpg",
                    Clearance = true,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 36,
                    FurnitureName = "Light Rustic Cabinet",
                    FurnitureDescription = "A light wood, rustic style cabinet, perfect for your living room.",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/LightRusticCabinet.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 37,
                    FurnitureName = "Light Wood Cabinet",
                    FurnitureDescription = "A light wood cabinet, perfect for your living room.",
                    FurniturePrice = 499.99m,
                    FurnitureImgUrl = "/images/bedroom/LightWoodCabinet.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 38,
                    FurnitureName = "Industrial Coffee Table",
                    FurnitureDescription = "An industrial style coffee table perfect for your living room.",
                    FurniturePrice = 399.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticCoffeeTable.jpg",
                    Clearance = false,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 39,
                    FurnitureName = "Rustic Console Table",
                    FurnitureDescription = "A rustic style console table perfect for your living room.",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticConsoleTable.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 40,
                    FurnitureName = "Rustic TV Stand",
                    FurnitureDescription = "A rustic style TV stand, perfect for your living room.",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/RusticTVStand.jpg",
                    Clearance = false,
                    CategoryID = 4
                },
                new Furniture
                {
                    FurnitureID = 41,
                    FurnitureName = "Scallop Coffee Table",
                    FurnitureDescription = "A scalloped coffee table, perfect for your living room.",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/ScallopCoffeeTable.jpg",
                    Clearance = true,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 42,
                    FurnitureName = "Scallop Side Table",
                    FurnitureDescription = "A scalloped side table, perfect for your living room.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/ScallopSideTable.jpg",
                    Clearance = false,
                    CategoryID = 3
                },
                new Furniture
                {
                    FurnitureID = 43,
                    FurnitureName = "Shell Loveseat",
                    FurnitureDescription = "A shell shaped loveseat, perfect for your living room.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/ShellCouch.jpg",
                    Clearance = true,
                    CategoryID = 1
                },
                new Furniture
                {
                    FurnitureID = 44,
                    FurnitureName = "Vanilla Speckled Loveseat",
                    FurnitureDescription = "A speckled cream loveseat, perfect for your living room.",
                    FurniturePrice = 599.99m,
                    FurnitureImgUrl = "/images/bedroom/VanillaSpeckedLoveSeat.jpg",
                    Clearance = false,
                    CategoryID = 1
                },
                new Furniture
                {
                    FurnitureID = 45,
                    FurnitureName = "Cream Desk",
                    FurnitureDescription = "A cream colored wooden desk for your office.",
                    FurniturePrice = 349.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamDesk.jpg",
                    Clearance = false,
                    CategoryID = 12
                },
                new Furniture
                {
                    FurnitureID = 46,
                    FurnitureName = "Cream Office Chair",
                    FurnitureDescription = "A cream cushioned swivel chair for your office.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamDeskChair.jpg",
                    Clearance = true,
                    CategoryID = 13
                },
                new Furniture
                {
                    FurnitureID = 47,
                    FurnitureName = "Cream Wood Office Chair",
                    FurnitureDescription = "A wood and cream cushioned swivel chair for your office.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/CreamWoodDeskChair.jpg",
                    Clearance = false,
                    CategoryID = 13
                },
                new Furniture
                {
                    FurnitureID = 48,
                    FurnitureName = "Dark Wood Desk",
                    FurnitureDescription = "A dark wood desk for your office.",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/DarkWoodDesk.jpg",
                    Clearance = false,
                    CategoryID = 12
                },
                new Furniture
                {
                    FurnitureID = 49,
                    FurnitureName = "Farmhouse Desk",
                    FurnitureDescription = "A farmhouse style desk for your office.",
                    FurniturePrice = 299.99m,
                    FurnitureImgUrl = "/images/bedroom/FarmhouseDesk.jpg",
                    Clearance = false,
                    CategoryID = 12
                },
                new Furniture
                {
                    FurnitureID = 50,
                    FurnitureName = "Faux Leather Office Chair",
                    FurnitureDescription = "A faux leather swivel chair desk for your office.",
                    FurniturePrice = 199.99m,
                    FurnitureImgUrl = "/images/bedroom/FauxLeatherDeskChair.jpg",
                    Clearance = false,
                    CategoryID = 13
                }
            );
        }
    }
}
