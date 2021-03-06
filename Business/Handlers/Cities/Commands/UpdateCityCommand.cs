using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using MediatR;

namespace Business.Handlers.Cities.Commands
{
    public class UpdateCityCommand : IRequest<IResult>
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, IResult>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public UpdateCityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<IResult> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
            {
                var mapper = _mapper.Map<City>(request);
                await _unitOfWork.CityRepository.UpdateAsync(mapper);
                await _unitOfWork.Commit();
                return new SuccessResult(Messages.CityUpdated);
            }
        }
    }
}