﻿using Cpnucleo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cpnucleo.Infra.Data.Mappings
{
    class TipoTarefaMap : IEntityTypeConfiguration<TipoTarefa>
    {
        public void Configure(EntityTypeBuilder<TipoTarefa> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("TIP_ID");

            builder.Property(c => c.Nome)
                .HasColumnName("TIP_NOME")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("TIP_DATA_INCLUSAO")
                .HasColumnType("datetime");

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("TIP_DATA_ALTERACAO")
                .HasColumnType("datetime");
        }
    }
}