namespace Core.Interface;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
