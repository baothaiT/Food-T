﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food.Configurations
{
    public class WishlistsConfigurations : IEntityTypeConfiguration<Wishlists>
    {
        public void Configure(EntityTypeBuilder<Wishlists> builder)
        {
            builder.ToTable("Wishlists");
            builder.HasKey(t => new { t.wl_Id });
            builder.HasOne(t => t.UserW).WithMany(ur => ur.WishlistsU)
                .HasForeignKey(pc => pc.wl_UserId);

        }
    }
}
