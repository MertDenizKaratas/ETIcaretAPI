﻿using MediatR;

namespace ETicaretAPI.Application.Features.Queries.Order.GetOrderById
{
    public class GetOrderByIdQueryRequest : IRequest<GetOrderByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}