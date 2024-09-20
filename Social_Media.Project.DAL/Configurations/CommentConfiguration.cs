using ClassLibrary.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Social_Media.Project.DAL.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<CommentClass>
{
    public void Configure(EntityTypeBuilder<CommentClass> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
