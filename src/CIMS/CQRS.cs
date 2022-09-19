namespace CIMS;

public interface IRequest : MediatR.IRequest<IResponse> { }

public interface IResponse { }

public interface IFailedResponse : IResponse { }

public interface IRequestHandler<TRequest> : MediatR.IRequestHandler<TRequest, IResponse> where TRequest : IRequest { }