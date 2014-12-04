using System.Collections.Generic;

namespace OpenResKit.Measure
{
    public class Consumer : IMeasurable
    {
        public virtual int Id { get; set; }

        public virtual int Localid { get; set; } //"GER_ID"

        public virtual int LocalGr { get; set; } //"GER_NR"

        public virtual string LocalGnr { get; set; } //"GER_GNR

        public virtual string InventoryNr { get; set; } //"GER_INV

        public virtual string LocalSerialNr { get; set; } //"GER_SNR

        public virtual string Manufacturer { get; set; } //GER_HST

        public virtual string Identifier { get; set; } //GER_BEZ

        public virtual string Comment { get; set; } //GER_BEM

        public int? Year { get; set; } //GER_BAUJ

        public virtual long? PowerOutput { get; set; } //GERAETE_EIG_KW

        public virtual long? PowerCurrent { get; set; } //GERAETE_EIG_AMPERE

        public virtual ICollection<Reading> Readings { get; set; }

        public virtual Room Room { get; set; }

        public virtual Distributor Distributor { get; set; }

        public virtual ConsumerGroup ConsumerGroup { get; set; }

        public string Name { get; set; }
        public ICollection<Measure> Measures { get; set; }
    }
}