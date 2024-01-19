using Ojave.Core.System;

namespace Ojave.Core.Data;

public interface IDbQuery<TResult>
{
    Task<Result<TResult>> GetAsync(CancellationToken cancellationToken);
}

public interface IDbQuery<TInput, TResult>
{
    Task<Result<TResult>> GetAsync(TInput input, CancellationToken cancellationToken);
}
