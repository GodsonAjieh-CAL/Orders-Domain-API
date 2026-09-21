namespace ETF_Orders_Domain_API
{
    public interface IOrderService
    {
        public Task<string> GetOrders(string name);

        public Task<string> AddOrders(string name);
        public Task<string> UpdateOrders(int id, string name);
        public Task<string> DeleteOrders(int id);

    }
}
