using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using MediatR;

namespace Business.Handlers.OrderDetails.Commands
{
    public class UpdateOrderDetailCommand : IRequest<IResult>
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Amount { get; set; }
        public int SalePrice { get; set; }

        public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand, IResult>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public UpdateOrderDetailCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
            {
                _mapper = mapper;
                _unitOfWork = unitOfWork;
            }

            public async Task<IResult> Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
            {
                var mapper = _mapper.Map<OrderDetail>(request);
                await _unitOfWork.OrderDetailRepository.UpdateAsync(mapper);
                await _unitOfWork.Commit();
                return new SuccessResult(Messages.CountryUpdated);
            }
        }
    }
}