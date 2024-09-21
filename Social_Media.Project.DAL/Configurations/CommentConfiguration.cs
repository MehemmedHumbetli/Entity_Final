using ClassLibrary.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Social_Media.Project.DAL.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<CommentClass>
{
    public void Configure(EntityTypeBuilder<CommentClass> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Text).HasMaxLength(20);
        builder.Property(x => x.Comment).HasMaxLength(250);
        builder
            .HasMany(x => x.Posts)
            .WithMany(x => x.Comments);
    }
}
