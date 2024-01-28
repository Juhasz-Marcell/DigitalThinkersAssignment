﻿
namespace DigitalThinkersAssignment.Services
{
    public interface IStockService
    {
        public void UpdateStock(Dictionary<string, int> currencies);
        public Dictionary<string,int> GetCurrentStock();
        public Dictionary<string, int> Checkout(Dictionary<string, int> currencies);
    }
}
