using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class CandidateConfig : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidates");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.Client)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Recrutier)
                .IsRequired()
                .HasMaxLength(120);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.Location)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.EducationLevel)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.CurrentPosition)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.SalaryExpectations)
                .IsRequired()
                .HasMaxLength(7);

            builder.Property(x => x.CurrentSalaryGross)
                .IsRequired()
                .HasMaxLength(7);

            builder.Property(x => x.Skills)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.Experience)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Q1)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Q2)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Q3)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Q3)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Notes)
                .HasMaxLength(150);

            //builder.Property(x => x.Languages)
            //    .IsRequired();

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(60);

            builder.Property(x => x.LastModifiedBy)
                .HasMaxLength(60);
        }
    }
}
