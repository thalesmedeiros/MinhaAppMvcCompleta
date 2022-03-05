﻿using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIo.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(p => p.Complemento)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Enderecos");
        }
    }
}
