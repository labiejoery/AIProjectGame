using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Configurations
{
    internal class UserHighscoresPerLevelConfiguration : IEntityTypeConfiguration<UserHighscoresPerLevel>
    {
        public void Configure(EntityTypeBuilder<UserHighscoresPerLevel> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
