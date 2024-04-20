using OLX_MVC.Data;
using OLX_MVC.Extentions;

namespace OLX_MVC.Services
{
    public interface ICartService
    {
        int GetCount();
        void Append(int id, int count = 1);
    }

    public class CartService : ICartService
    {
        private readonly HttpContext httpContext;
        private readonly ShopDbContext context;

        public CartService(ShopDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.httpContext = httpContextAccessor.HttpContext;
            this.context = context;
        }

        public void Append(int id, int count = 1)
        {
            var items = httpContext.Session.Get<Dictionary<int, int>>(WebConstants.CART_KEY);
            if (items == null) items = new Dictionary<int, int>();

            var product = context.Products.Find(id);

            if (items.ContainsKey(id)) items[id] += count;

            else items.Add(id, count);

            httpContext.Session.Set(WebConstants.CART_KEY, items);
        }

        public int GetCount()
        {
            var items = httpContext.Session.Get<Dictionary<int, int>>(WebConstants.CART_KEY);

            if (items == null) return 0;

            return items.Count;
        }
    }
}
