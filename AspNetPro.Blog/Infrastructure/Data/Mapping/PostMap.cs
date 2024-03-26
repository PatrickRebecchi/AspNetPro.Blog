using AspNetPro.Blog.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetPro.Blog.Infrastructure.Data.Mapping;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Posts");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.titulo)
            .HasMaxLength(70)
            .IsRequired();

        builder.Property(x => x.resumo)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(x => x.conteudo)
            .HasColumnType("NVARCHAR(MAX)");
    }
}
