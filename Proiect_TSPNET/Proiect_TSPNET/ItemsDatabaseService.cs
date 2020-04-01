using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TSPNET
{
    public class ItemsDatabaseService
    {
        public IItemsQueryService queryService;
        public IItemsEditAddRemoveService editService;
        public ItemsDatabaseService()
        {
            this.queryService = new ItemsQueryService();
            this.editService = new ItemsEditAddRemoveService();
        }
    }
}
