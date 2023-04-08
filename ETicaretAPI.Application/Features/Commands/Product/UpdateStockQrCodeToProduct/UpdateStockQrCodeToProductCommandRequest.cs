using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Product.UpdateStockQrCodeToProduct
{
    public class UpdateStockQrCodeToProductCommandRequest : IRequest<UpdateStockQrCodeToProductCommandResponse>
    {
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}