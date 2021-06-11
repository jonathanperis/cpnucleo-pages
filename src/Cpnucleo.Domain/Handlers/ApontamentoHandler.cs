using AutoMapper;
using Cpnucleo.Domain.Commands.Apontamento.Requests;
using Cpnucleo.Domain.Entities;
using Cpnucleo.Domain.UoW;
using Cpnucleo.Infra.CrossCutting.Util;
using Cpnucleo.Infra.CrossCutting.Util.Commands.Apontamento.CreateApontamento;
using Cpnucleo.Infra.CrossCutting.Util.Commands.Apontamento.RemoveApontamento;
using Cpnucleo.Infra.CrossCutting.Util.Commands.Apontamento.UpdateApontamento;
using Cpnucleo.Infra.CrossCutting.Util.Queries.Apontamento.GetApontamento;
using Cpnucleo.Infra.CrossCutting.Util.Queries.Apontamento.GetByRecurso;
using Cpnucleo.Infra.CrossCutting.Util.Queries.Apontamento.ListApontamento;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using FluentValidation.Results;
using MediatR;
using MessagePipe;
using NetDevPack.Messaging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cpnucleo.Application.Handlers
{
    public class ApontamentoHandler : CommandHandler,
        IRequestHandler<CreateApontamentoCommand, ValidationResult>,
        IRequestHandler<RemoveApontamentoCommand, ValidationResult>,
        IRequestHandler<UpdateApontamentoCommand, ValidationResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ApontamentoHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ValidationResult> Handle(CreateApontamentoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            Apontamento obj = await _unitOfWork.ApontamentoRepository.AddAsync(_mapper.Map<Apontamento>(request));
            result.Apontamento = _mapper.Map<ApontamentoViewModel>(obj);

            await _unitOfWork.SaveChangesAsync();

            result.Status = OperationResult.Success;

            return result;
        }

        public Task<ValidationResult> Handle(RemoveApontamentoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ValidationResult> Handle(UpdateApontamentoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async ValueTask<ValidationResult> InvokeAsync(CreateApontamentoCommand request, CancellationToken cancellationToken = default)
        {
            CreateApontamentoResponse result = new CreateApontamentoResponse
            {
                Status = OperationResult.Failed
            };

            Apontamento obj = await _unitOfWork.ApontamentoRepository.AddAsync(_mapper.Map<Apontamento>(request.Apontamento));
            result.Apontamento = _mapper.Map<ApontamentoViewModel>(obj);

            await _unitOfWork.SaveChangesAsync();

            result.Status = OperationResult.Success;

            return result;
        }

        public async ValueTask<ValidationResult> InvokeAsync(RemoveApontamentoCommand request, CancellationToken cancellationToken = default)
        {
            RemoveApontamentoResponse result = new RemoveApontamentoResponse
            {
                Status = OperationResult.Failed
            };

            Apontamento obj = await _unitOfWork.ApontamentoRepository.GetAsync(request.Id);

            if (obj == null)
            {
                result.Status = OperationResult.NotFound;

                return result;
            }

            await _unitOfWork.ApontamentoRepository.RemoveAsync(request.Id);

            bool success = await _unitOfWork.SaveChangesAsync();

            result.Status = success ? OperationResult.Success : OperationResult.Failed;

            return result;
        }

        public async ValueTask<ValidationResult> InvokeAsync(UpdateApontamentoCommand request, CancellationToken cancellationToken = default)
        {
            UpdateApontamentoResponse result = new UpdateApontamentoResponse
            {
                Status = OperationResult.Failed
            };

            _unitOfWork.ApontamentoRepository.Update(_mapper.Map<Apontamento>(request.Apontamento));

            bool success = await _unitOfWork.SaveChangesAsync();

            result.Status = success ? OperationResult.Success : OperationResult.Failed;

            return result;
        }


    }
}
