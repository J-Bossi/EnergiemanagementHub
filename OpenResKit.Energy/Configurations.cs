using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.DomainModel;

namespace OpenResKit.Measure
{
    [Export(typeof (IDomainEntityConfiguration))]
    public class MeasureConfigurations : EntityTypeConfiguration<Measure>, IDomainEntityConfiguration
    {
        public MeasureConfigurations()
        {
            HasMany(m => m.AttachedDocuments)
                .WithOptional()
                .WillCascadeOnDelete();
            HasOptional(m => m.MeasureImageSource)
                .WithOptionalPrincipal()
                .WillCascadeOnDelete(true);
        }

        public void AddConfigurationToModel(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class BuildingConfiguration : EntityTypeConfiguration<Building>, IDomainEntityConfiguration
        {
            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class CatalogConfiguration : EntityTypeConfiguration<Catalog>, IDomainEntityConfiguration
        {
            public CatalogConfiguration()
            {
                HasMany(s => s.Measures)
                    .WithOptional()
                    .WillCascadeOnDelete();
            }

            public void AddConfigurationToModel(ConfigurationRegistrar configurations)
            {
                configurations.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class ConsumerConfiguration : EntityTypeConfiguration<Consumer>, IDomainEntityConfiguration
        {
            public ConsumerConfiguration()
            {
                HasOptional(c => c.Room).WithMany().WillCascadeOnDelete(true);
                HasMany(c => c.Readings).WithOptional().WillCascadeOnDelete(true);
                HasOptional(c => c.Distributor).WithMany();
                HasOptional(c => c.ConsumerGroup).WithMany();
            }

            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class ConsumerGroupConfiguration : EntityTypeConfiguration<ConsumerGroup>, IDomainEntityConfiguration
        {
            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }


        [Export(typeof (IDomainEntityConfiguration))]
        public class DistributorConfiguration : EntityTypeConfiguration<Distributor>, IDomainEntityConfiguration
        {
            public DistributorConfiguration()
            {
                HasMany(d => d.Readings).WithOptional().WillCascadeOnDelete(true);
            }

            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class MeasureImageSourceConfigurations : EntityTypeConfiguration<MeasureImageSource>,
            IDomainEntityConfiguration
        {
            public void AddConfigurationToModel(ConfigurationRegistrar configurations)
            {
                configurations.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class ReadingConfiguration : EntityTypeConfiguration<Reading>, IDomainEntityConfiguration
        {
            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class RoomConfiguration : EntityTypeConfiguration<Room>, IDomainEntityConfiguration
        {
            public RoomConfiguration()
            {
                HasRequired(r => r.Building).WithMany().WillCascadeOnDelete(true);
            }

            public void AddConfigurationToModel(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }

        [Export(typeof (IDomainEntityConfiguration))]
        public class SubMeasureConfigurations : EntityTypeConfiguration<SubMeasure>, IDomainEntityConfiguration
        {
            public SubMeasureConfigurations()
            {
                HasOptional(s => s.ReleatedMeasure);
            }


            public void AddConfigurationToModel(ConfigurationRegistrar configurations)
            {
                configurations.Add(this);
            }
        }
    }
}