using Microsoft.NAV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcportal.Services
{
    public class BCService
    {
        private string EndPointUri;
        private string AuthToken;

        public BCService()
        {
            EndPointUri = "http://bc172:7048/BC/api/bcportal/BCPortal/v1.0/companies(56a78109-3438-eb11-bc12-000d3a245f9d)";
            AuthToken = "Basic Your Token Here";
            
        }

        private NAV GetNavClient()
        {
            var nav = new NAV(new Uri(EndPointUri));
            nav.BuildingRequest += (sender, EventArgs) => EventArgs.Headers.Add("Authorization", AuthToken);
            return nav;
        }
        public Task<assemblyOrder[]> GetAssemblyOrders()
        {
            var nav = GetNavClient();
            var returnAssemblyOrders = new List<assemblyOrder>();
            foreach (var assemblyOrder in nav.assemblyOrders.Expand(nav => nav.assemblyOrderLines))
            {
                returnAssemblyOrders.Add(assemblyOrder);
            }

            return Task.FromResult(returnAssemblyOrders.ToArray());
        }

        public Task<int> GetAssemblyOrdersCount()
        {
            var nav = GetNavClient();
            var count = nav.assemblyOrders.Count();

            return Task.FromResult(count);
        }

        public Task<assemblyOrder> GetAssemblyOrder(string no)
        {
            var nav = GetNavClient();
            var assemblyOrder = nav.assemblyOrders
                .Expand(nav => nav.assemblyOrderLines)
                .Where(nav => nav.No == no && nav.DocumentType == "Order")
                .First();
            
            return Task.FromResult(assemblyOrder);
        }
            
        public Task<bool> UpdateQuantityToAssemble(string no, decimal? quantityToAssemble)
        {
            var nav = GetNavClient();
            var keys = new Dictionary<string, object>();
            keys.Add("No", no);
            keys.Add("DocumentType", "Order");
            var assemblyOrder = nav.assemblyOrders.ByKey(keys).GetValue();
            assemblyOrder.QuantityToAssemble = quantityToAssemble;
            nav.UpdateObject(assemblyOrder);
            nav.SaveChanges();

            return Task.FromResult(true);
        }

        public Task<bool> PostAssemblyOrder(string no)
        {
            var nav = GetNavClient();
            var keys = new Dictionary<string, object>();
            keys.Add("No", no);
            keys.Add("DocumentType", "Order");

            var assemblyOrder = nav.assemblyOrders.ByKey(keys).GetValue();
   
            assemblyOrder.postAssemblyOrder().Execute();

            return Task.FromResult(true);
        }

        public Task<bool> CreateAssemblyOrder()
        {
            var nav = GetNavClient();
            var assemblyOrder = new assemblyOrder();

            assemblyOrder.DueDate = DateTime.Today;
            assemblyOrder.EndingDate = DateTime.Today;
            assemblyOrder.ItemNo = "1000";
            assemblyOrder.DocumentType = "Order";
            assemblyOrder.No = "A12121";
            nav.AddObject("assemblyOrders",assemblyOrder);

            nav.SaveChanges();
            return Task.FromResult(true);
        }

        public itemStockState[] GetItemStock(string ItemNo, string LocationNo)
        {
            var nav = GetNavClient();
            var ItemStockStates = new List<itemStockState>();

            foreach (var itemStockSate in nav.itemStockStates
                .Where(x => x.itemNo == ItemNo && x.locationCode == LocationNo && x.remainingQuantity > 0))
            {
                ItemStockStates.Add(itemStockSate);
            }

            return ItemStockStates.ToArray();
        }

        public async Task<bool> UpdateOrderQuantityToAssemble(string orderNo, decimal? quantityToAssemble)
        {
            var nav = GetNavClient();

            var keys = new Dictionary<string, object>();
            keys.Add("No", orderNo);
            keys.Add("DocumentType", "Order");

            var assemblyOrder = nav.assemblyOrders.ByKey(keys).GetValue();

            assemblyOrder.QuantityToAssemble = quantityToAssemble;
            nav.UpdateObject(assemblyOrder);

            await nav.SaveChangesAsync();

            return true;
        }
        public Task<bool> AddItemTrackingForOutputItem(decimal quantity, string assemblyOrderNo, string itemNo, string locationCode, string lotNo)
        {
            var nav = GetNavClient();

            var itemTracking = new itemTracking();
            itemTracking.QuantityBase = quantity;
            itemTracking.SourceSubtype = "1";
            itemTracking.ItemNo = itemNo;
            itemTracking.LocationCode = locationCode;
            itemTracking.SourceID = assemblyOrderNo;
            itemTracking.LotNo = lotNo;
            itemTracking.QtyperUnitofMeasure = 1;
            itemTracking.SourceType = 900; //AssemblyHeader
            itemTracking.EntryNo = 1;
            itemTracking.ReservationStatus = "5";

            nav.AddObject("itemTrackings", itemTracking);
            nav.SaveChanges();

            return Task.FromResult(true);
        }
        public Task<bool> AddItemTrackingForComponent(decimal quantity, string assemblyOrderNo, string itemNo, string locationCode, string lotNo, int lineNo)
        {
            var nav = GetNavClient();

            var itemTracking = new itemTracking();
            itemTracking.QuantityBase = quantity;
            itemTracking.SourceSubtype = "1";
            itemTracking.ItemNo = itemNo;
            itemTracking.LocationCode = locationCode;
            itemTracking.SourceID = assemblyOrderNo;
            itemTracking.SourceRefNo = lineNo;
            itemTracking.LotNo = lotNo;
            itemTracking.QtyperUnitofMeasure = 1;
            itemTracking.SourceType = 901; //AssemblyLineTable
            itemTracking.EntryNo = 1;
            itemTracking.ReservationStatus = "5";

            nav.AddObject("itemTrackings", itemTracking);
            nav.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
