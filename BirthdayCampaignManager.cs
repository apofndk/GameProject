using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class BirthdayCampaignManager : ICampaignManager
    {
        public void AddCampaign()
        {
            Console.WriteLine("Doğum günü kampanyası eklendi.");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Doğum günü kampanyası silindi.");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Doğum günü kampanyası güncellendi.");
        }
    }
}
