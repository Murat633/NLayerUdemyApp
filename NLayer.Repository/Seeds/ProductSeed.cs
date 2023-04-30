using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Kitap",
                        CategoryId = 1,
                        Stock = 20,
                        Price = 100,
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Kalem",
                        CategoryId = 2,
                        Stock = 20,
                        Price = 300,
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Kitap",
                        CategoryId = 2,
                        Stock = 20,
                        Price = 300,
                        CreatedDate = DateTime.Now
                    }
                   );
        }
    }
}
