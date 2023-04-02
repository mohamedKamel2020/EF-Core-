using EF007.ConfigurationUsingGroupingConfiguration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF007.ConfigurationUsingGroupingConfiguration.Data.Config
{
    internal class TweetConfiguration : IEntityTypeConfiguration<Tweet>
    {
        void IEntityTypeConfiguration<Tweet>.Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.ToTable("tblTweets");
        }
    }
}
