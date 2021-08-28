using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Divan.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Sofas"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sectional Sofas"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Sleeper Sofas"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Ottoman Chairs"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Dining Tables"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Arm Chairs"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Console Tables"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Beds"
                },
                new Category
                {
                    CategoryID = 9,
                    CategoryName = "Nightstands"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Mirrors"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Desks"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Storage Cabinets"
                },
                new Category
                {
                    CategoryID = 13,
                    CategoryName = "Bookcases"
                }
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Extravagant Sofa",
                    //ManufacturerName = "Jasiway",
                    Description = "Cool extravagant sofa." + "For fruitful rest!",
                    ImagePath = "sofa-1.jpg",
                    UnitPrice = 249.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Family Sofa",
                    //ManufacturerName = "Jasiway",
                    Description = "A sofa for the whole family to enjoy.",
                    ImagePath="sofa-2.jpg",
                    UnitPrice = 379.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Low-priced Sofa",
                    //ManufacturerName = "Jasiway",
                    Description = "A sofa for the poor.",
                    ImagePath="sofa-3.jpg",
                    UnitPrice = 132.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Low-priced Sectional Sofa",
                    Description = "A sectional sofa for the poor and needy.",
                    ImagePath="sectional-sofa-1.jpg",
                    UnitPrice = 145.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Average-priced Sectional Sofa",
                    Description = "This sectional sofa is for your average Joe.",
                    ImagePath="sectional-sofa-2.jpg",
                    UnitPrice = 284.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Luxury Sectional Sofa",
                    Description = "Sectional Sofa for people with high budget.",
                    ImagePath="sectional-sofa-3.jpg",
                    UnitPrice = 399.95,
                    CategoryID = 2
                },
               new Product
               {
                    ProductID = 7,
                    ProductName = "Average Sleeper Sofa",
                    Description = "Sleeper Sofa for average people.",
                    ImagePath="sleeper-sofa-1.jpg",
                    UnitPrice = 194.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Low-Priced Sleeper Sofa",
                    Description = "Sleeper Sofa for people with low budget.",
                    ImagePath="sleeper-sofa-2.jpg",
                    UnitPrice = 124.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Expensive Sleeper Sofa",
                    Description = "Sleeper Sofa for people with high budget.",
                    ImagePath="sleeper-sofa-3.jpg",
                    UnitPrice = 304.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Stylish Chair Ottoman",
                    Description = "Stylish, but not too expensive Chair Ottoman.",
                    ImagePath="ottoman-chair-1.jpg",
                    UnitPrice = 65.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Low-priced Chair Ottoman",
                    Description = "Really cheap Chair Ottoman.",
                    ImagePath="ottoman-chair-2.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Extravagant Chair Ottoman",
                    Description = "Chair Ottoman for real Sultans.",
                    ImagePath="ottoman-chair-3.jpg",
                    UnitPrice = 125.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Average-priced Dining Table",
                    Description = "Dining Table for the Average family.",
                    ImagePath="dining-table-1.jpg",
                    UnitPrice = 75.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Design Dining Table",
                    Description = "Dining Table for the Not-So-Average family.",
                    ImagePath="dining-table-2.jpg",
                    UnitPrice = 205.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Low-priced Dining Table",
                    Description = "Dining Table for the poor.",
                    ImagePath="dining-table-3.jpg",
                    UnitPrice = 45.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Average Armchair",
                    Description = "Average Armcharir for the average person.",
                    ImagePath="armchair-1.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Luxurious Armchair",
                    Description = "Ergonomic and comfortable armchair.",
                    ImagePath="armchair-2.jpg",
                    UnitPrice = 195.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "Basic Armchair",
                    Description = "Armchair for the unpretentious.",
                    ImagePath="armchair-3.jpg",
                    UnitPrice = 55.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "Expensive Console Table",
                    Description = "Console Table for people with cash.",
                    ImagePath="console-table-1.jpg",
                    UnitPrice = 195.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Really Expensive Console Table",
                    Description = "Console Table for people with a lot of cash.",
                    ImagePath="console-table-2.jpg",
                    UnitPrice = 295.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Low-priced Console Table",
                    Description = "Low budget Console Table.",
                    ImagePath="console-table-3.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Low-priced Console Table",
                    Description = "Console Table for the poor.",
                    ImagePath="console-table-3.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 8
                },
            };
            return products;
        }
    }
}