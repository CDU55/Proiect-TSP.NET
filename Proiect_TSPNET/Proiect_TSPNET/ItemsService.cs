using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class ItemsService
    {
        public readonly ItemsDatabaseService dbService;
        public readonly ILocalItemsService localItems;
        public ItemsService()
        {
            dbService = new ItemsDatabaseService();
            localItems = new LocalItemsService();
        }

    }
}
