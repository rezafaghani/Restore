using Microsoft.EntityFrameworkCore;

namespace Order.Api.Entities.OrderAggregate
{
    [Owned]
    public class ProductItemOrdered
    {
        public int ProductId { get; set; }       
        public string Name { get; set; }
        public string PictureUrl { get; set; }
    }
}