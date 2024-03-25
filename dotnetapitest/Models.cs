using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class ItemsContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public string DbPath { get; }
    public ItemsContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "items.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        for (var i = 1; i <= 10; i++)
        {
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = i, SKU = 665544332, Description = "Dining Table"});
        }

        for (var i = 11; i <= 20; i++)
        {
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = i, SKU = 665544331, Description = "Dining Chair" });
        }

        for (var i = 21; i <= 30; i++)
        {
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = i, SKU = 665544333, Description = "Sofa" });
        }

        for (var i = 31; i <= 40; i++)
        {
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = i, SKU = 665544334, Description = "Loveseat" });
        }

        for (var i = 41; i <= 50; i++)
        {
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = i, SKU = 665544335, Description = "Chair" });
        }
    }
}

public class Item
{
    public int ItemId { get; set; }
    public int SKU { get; set; }
    public string Description { get; set; }
}