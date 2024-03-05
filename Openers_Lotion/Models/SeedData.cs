using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using Openers_Lotion.Data;
using System;
using System.Linq;

namespace Openers_Lotion.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new Openers_LotionContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Openers_LotionContext>>());
        protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Lotion",
            maxLength: 500, // or whatever length you need
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);
    }

        // Look for any movies.
        if (context.Lotion.Any())
        {
            return;   // DB has been seeded
        }
        context.Lotion.AddRange(
            new Lotion
            {
                ProductName = "Biotique Winter Cherry Body Lotion - Winter Cherry",
                ItemForm = "Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 4,
                Description = "This nourishing lotion is a blend of pure winter cherry, sunflower, safflower, musk root and almond oil, to supply moisture and nutrients crucial to body health and vitality",
                Price = 29.66M,
                Review = 3.5M
            },
            new Lotion
            {
                ProductName = "Love Beauty and Planet Argan Oil & Lavender Body Lotion",
                ItemForm = "Body Lotion",
                SkinType = "Oil Skin",
                Quantity = 300,
                Description = "24 HOUR MOISTURIZER: Our Love Beauty and Planet body lotion provides 24 hours moisturization",
                Price = 32.79M,
                Review = 4
            },
            new Lotion
            {
                ProductName = "The Body Shop Coconut Body Butter",
                ItemForm = "Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 400,
                Description = "Give extra pampering to those small nooks and drier areas, such as knees, elbows and feet",
                Price = 36,
                Review = 4
            },
            new Lotion
            {
                ProductName = "Molton Brown Jasmine",
                ItemForm = "Moisturizing Body Lotion",
                SkinType = "Oil Skin",
                Quantity = 300,
                Description = "The dimethicone skin protectant with a soothing triple oat and hydrating shea butter formula, which includes oat flour, oat extract and oat oil, that provides soothing relief for itchy, dry skin and locks in long-lasting moisture",
                Price = 22.99M,
                Review = 4.6M
            },
            new Lotion
            {
                ProductName = "Olay Daily Recovery and Hydration",
                ItemForm = "Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 502,
                Description = "CRAFTED WITH VITAMIN B3 COMPLEX AND SHEA BUTTER.Penetrates skin’s surface up to 10 layers deep to deliver instant hydration",
                Price = 9.97M,
                Review = 4
            },
            new Lotion
            {
                ProductName = "Dove Body Love",
                ItemForm = "Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 400,
                Description = "Dove Body Love Intense Care Body Lotion provides long-lasting care for soft, smooth, and radiant skin",
                Price = 7.99M,
                Review = 4.5M
            },
            new Lotion
            {
                ProductName = "NIVEA Essentially Enriched",
                ItemForm = "Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 500,
                Description = "This NIVEA body lotion for dry skin and very dry skin provides 48 hours of deep nourishing moisture",
                Price = 10.98M,
                Review = 4.5M
            },
            new Lotion
            {
                ProductName = "Aveeno",
                ItemForm = "Moisturizing Body Lotion",
                SkinType = "Dry Skin",
                Quantity = 532,
                Description = "Aveeno Daily Moisturizing Body Lotion with Prebiotic Oat intensely nourishes dry skin with clinically proven moisturization that lasts for 24 hours. To use, apply daily as often as needed",
                Price = 21.57M,
                Review = 4.7M
            },
            new Lotion
            {
                ProductName = "Victoria's secret",
                ItemForm = "Fragrance Lotion",
                SkinType = "All Skin",
                Quantity = 236,
                Description = "An olfactive discovery of high-desert florals, hot sands and canyon blooms. Inspired by notes from a road trip through the desert. Escape with matching Fragrance Mist",
                Price = 5.99M,
                Review = 4.8M
            },
            new Lotion
            {
                ProductName = "Lavender Lemongrass Shea",
                ItemForm = "Butter Lotion",
                SkinType = "All Skin",
                Quantity = 236,
                Description = "Lavender Lemongrass shea butter hand and body lotion lightly scented with 100% natural, pure lemongrass and lavender essential oils",
                Price = 17,
                Review = 5
            }
        );
        context.SaveChanges();
    }
}