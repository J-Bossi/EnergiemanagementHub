using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Energy.Factory
{
    public class ConsumerFactory
    {

        internal static Consumer CreateMachine(System.Data.DataRow myRow)
        {
            var machine = new Consumer();
            machine.Localid = (int)myRow["GER_ID"];

            machine.LocalGr = (int) myRow["GER_NR"];
            machine.LocalGnr = myRow["GER_GNR"] == DBNull.Value ? "" : (string) myRow["GER_GNR"];
            machine.InventoryNr = myRow["GER_INV"] == DBNull.Value ? "" : (string) myRow["GER_INV"];
            machine.LocalSerialNr = myRow["GER_SNR"] == DBNull.Value ? "" : (string) myRow["GER_SNR"];
            machine.Manufacturer = myRow["GER_HST"] == DBNull.Value ? "" : (string) myRow["GER_HST"];
            machine.Identifier = myRow["GER_BEZ"] == DBNull.Value ? "" : (string) myRow["GER_BEZ"];
            machine.Comment = myRow["GER_BEM"] == DBNull.Value ? "" : (string) myRow["GER_BEM"];
            machine.Year = (int) myRow["GER_BAUJ"];
            






       //GERAETE_EIG_KW   PowerOutput 

        //GERAETE_EIG_AMPERE   PowerCurrent 

            return machine;
        }
    }
}
