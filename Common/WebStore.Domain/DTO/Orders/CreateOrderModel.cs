using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.DTO.Orders
{
    public class CreateOrderModel
    {
        public CreateOrderModel OrderViewModel { get; set; }

        public List<OrderItemDTO> OrderItems { get; set; }
    }
}
