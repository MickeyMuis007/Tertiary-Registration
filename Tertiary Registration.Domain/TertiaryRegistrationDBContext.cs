using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Applicants;
using Tertiary_Registration.Domain.Entities.Courses;
using Tertiary_Registration.Domain.Entities.Courses.Modules;
using Tertiary_Registration.Domain.Entities.Enrollments;
using Tertiary_Registration.Domain.Entities.Facilties;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Addresses;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Disabilities;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Genders;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Languages;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Nationalities;
using Tertiary_Registration.Domain.Entities.GeneralInformation.PopulationGroups;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Registrations;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Titles;
using Tertiary_Registration.Domain.Entities.Qualifications;

namespace Tertiary_Registration.Domain
{
    public class TertiaryRegistrationDBContext : DbContext
    {
        public TertiaryRegistrationDBContext ()
        {

        }

        public TertiaryRegistrationDBContext(DbContextOptions<TertiaryRegistrationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<ApplicantAddress> ApplicantAddresses { get; set; }
        public virtual DbSet<ApplicantContact> ApplicantContacts { get; set; }
        public virtual DbSet<ApplicantDisabilityStatus> ApplicantDisabilityStatuses { get; set; }
        public virtual DbSet<ApplicantLanguage> ApplicantLanguages { get; set; }
        public virtual DbSet<ApplicantNationality> ApplicantNationalities { get; set; }
        public virtual DbSet<ApplicantPersonalInfo> ApplicantPersonalInfos { get; set; }
        public virtual DbSet<ApplicantPopulationGroup> ApplicantPopulationGroups { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleLevel> ModuleLevels { get; set; }
        public virtual DbSet<CourseModule> CourseModules { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Facilty> Facilties { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<DisabilityType> Disabilities { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LanguageType> LanguageTypes { get; set; }
        public virtual DbSet<Nationality> Nationalties { get; set; }
        public virtual DbSet<PopulationGroup> PopulationGroups { get; set; }
        public virtual DbSet<RegistrationRegion> RegistrationRegions { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplicantBuilder(modelBuilder);
            ApplicantAddressBuilder(modelBuilder);
            ApplicantContactBuilder(modelBuilder);
            ApplicantDisabilityStatusBuilder(modelBuilder);
            ApplicantLanguageBuilder(modelBuilder);
            ApplicantNationalityBuilder(modelBuilder);
            ApplicantPersonalInfoBuilder(modelBuilder);
            ApplicantPopulationGroupBuilder(modelBuilder);
            ModuleBuilder(modelBuilder);
            ModuleLevelBuilder(modelBuilder);
            CourseBuilder(modelBuilder);
            CourseModuleBuilder(modelBuilder);
            EnrollmentBuilder(modelBuilder);
            FacilityBuilder(modelBuilder);
            AddressTypeBuilder(modelBuilder);
            DisabilityTypeBuilder(modelBuilder);
            GenderBuilder(modelBuilder);
            LanguageBuilder(modelBuilder);
            LanguageTypeBuilder(modelBuilder);
            NationalityBuilder(modelBuilder);
            PopulationGroupBuilder(modelBuilder);
            RegistrationRegionBuilder(modelBuilder);
            TitleBuilder(modelBuilder);
            QualificationBuilder(modelBuilder);
        }

        private void ApplicantBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.ToTable("Applicant");

                /* Property Settings */
                entity.Property(a => a.Id).ValueGeneratedOnAdd();

                /* Unique Constraints */
                entity.HasAlternateKey(a => a.StudentNo).HasName("UQ_Applicant_StudentNo");

                /* FK Relationships */
                entity.HasOne(a => a.ApplicantPersonalInfo)
                    .WithOne(a => a.Applicant);
                entity.HasOne(a => a.RegistrationRegion)
                    .WithMany(a => a.Applicants)
                    .HasForeignKey(a => a.RegistrationRegionId)
                    .HasConstraintName("FK_Applicant_RegistrationRegion");
            });
        }
        private void ApplicantAddressBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantAddress>(entity =>
            {
                entity.ToTable("ApplicantAddress");

                /* Properties Settings */
                entity.Property(a => a.Id).ValueGeneratedOnAdd();
                entity.Property(a => a.ApplicantPersonalInfoId).IsRequired();
                entity.Property(a => a.AddressTypeId).IsRequired();
                entity.Property(a => a.Street).HasMaxLength(100).IsRequired();
                entity.Property(a => a.Line1).HasMaxLength(500);
                entity.Property(a => a.Line2).HasMaxLength(500);
                entity.Property(a => a.PostalCode).HasMaxLength(4).IsRequired();
                entity.Property(a => a.City).HasMaxLength(100).IsRequired();

                /* Foreign Key Relationships */
                entity.HasOne(a => a.ApplicantPersonalInfo)
                    .WithMany(a => a.ApplicantAddresses)
                    .HasForeignKey(a => a.ApplicantPersonalInfoId)
                    .HasConstraintName("FK_ApplicantAddress_ApplicationPersonalInfo");
                entity.HasOne(a => a.AddressType)
                    .WithMany(a => a.ApplicantAddresses)
                    .HasForeignKey(a => a.AddressTypeId)
                    .HasConstraintName("FK_ApplicationAddress_AddressType");
                
            });
        }
        private void ApplicantContactBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantContact>(entity =>
            {
                entity.ToTable("ApplicantContact");

                /* Properties Settings */
                entity.Property(a => a.Id).ValueGeneratedOnAdd();
                entity.Property(a => a.ApplicantPersonalInfoId).IsRequired();
                entity.Property(a => a.HomeNo).HasMaxLength(15);
                entity.Property(a => a.WorkNo).HasMaxLength(15);
                entity.Property(a => a.CellNo).HasMaxLength(15);
                entity.Property(a => a.FaxNo).HasMaxLength(15);
                entity.Property(a => a.Email).HasMaxLength(254);

                /* Foreign Key Relationships */
                entity.HasOne(a => a.ApplicantPersonalInfo)
                    .WithMany(a => a.ApplicantContacts)
                    .HasForeignKey(a => a.ApplicantPersonalInfoId)
                    .HasConstraintName("FK_ApplicantContact_ApplicantPersonalInfo");
            });
        }
        private void ApplicantDisabilityStatusBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ApplicantLanguageBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ApplicantNationalityBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ApplicantPersonalInfoBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ApplicantPopulationGroupBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ModuleBuilder(ModelBuilder modelBuilder)
        {

        }
        private void ModuleLevelBuilder(ModelBuilder modelBuilder)
        {

        }
        private void CourseBuilder(ModelBuilder modelBuilder)
        {

        }
        private void CourseModuleBuilder(ModelBuilder modelBuilder)
        {

        }
        private void EnrollmentBuilder(ModelBuilder modelBuilder)
        {

        }
        private void FacilityBuilder(ModelBuilder modelBuilder)
        {

        }
        private void AddressTypeBuilder(ModelBuilder modelBuilder)
        {

        }
        private void DisabilityTypeBuilder(ModelBuilder modelBuilder)
        {

        }
        private void GenderBuilder(ModelBuilder modelBuilder)
        {

        }
        private void LanguageBuilder(ModelBuilder modelBuilder)
        {

        }
        private void LanguageTypeBuilder(ModelBuilder modelBuilder)
        {

        }
        private void NationalityBuilder(ModelBuilder modelBuilder)
        {

        }
        private void PopulationGroupBuilder(ModelBuilder modelBuilder)
        {

        }
        private void RegistrationRegionBuilder(ModelBuilder modelBuilder)
        {

        }
        private void TitleBuilder(ModelBuilder modelBuilder)
        {

        }
        private void QualificationBuilder(ModelBuilder modelBuilder)
        {

        }
    }
}
