using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager:IGameService
    {
        ICampaignManager _campaignManager;
        public OrderManager(ICampaignManager campaignManager) 
        {
            _campaignManager = campaignManager;

        }

        public void Buy(Game game,Gamer gamer)
        {
            if (_campaignManager != null)
            {
                _campaignManager.AddCampaign();
                Console.WriteLine("Oyun alındı.");
            }
            else
            {
                Console.WriteLine("Oyun alındı.");
            }

        }
    }
}
