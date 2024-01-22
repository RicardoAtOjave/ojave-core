using Ojave.Core.System;

namespace Ojave.Core.Data;

public interface IDbCommand<TInput, TResult>
{
    Task<Result<TResult>> ExecuteAsync(TInput input, CancellationToken cancellationToken);
}
