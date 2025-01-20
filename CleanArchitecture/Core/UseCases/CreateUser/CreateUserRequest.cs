using MediatR;

namespace Core.UseCases.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;

