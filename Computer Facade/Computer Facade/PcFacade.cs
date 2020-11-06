using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Facade
{
    public class PcFacade
    {
        private PcPowerSupply power_supply { get; set; }
        private PcMotherboard Mother_board { get; set; }
        private PcSSD Ssd { get; set; }
        private PcGraphicCard graphic_card { get; set; }


        public PcFacade()
        {
            power_supply = new PcPowerSupply();
            Mother_board = new PcMotherboard();
            Ssd = new PcSSD();
            graphic_card = new PcGraphicCard();
            
        }
        public void Starting_Pc()
        {
            Console.WriteLine("Building new Computer............");
            power_supply.startPowerSupply();
            Mother_board.connectingElemetes();
            Ssd.startSSD();
            graphic_card.startGRaphicCard();
        }
    }
   
}
