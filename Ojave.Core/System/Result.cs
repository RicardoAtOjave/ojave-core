namespace Ojave.Core.System;

public struct Result<T, E> where E : class
{
    public Result()
    {
        Data = default;
        State = ResultState.Ok;
        Error = default;
    }

    private Result(T data)
    {
        Data = data;
        State = ResultState.Ok;
        Error = default;
    }

    private Result(E error)
    {
        Data = default;
        State = ResultState.Err;
        Error = error;
    }

    private readonly T Data;
    private readonly E Error;

    public ResultState State;

    /// <summary>
    /// Used to create a successful result and then combined with unwrap will allow for the data to be collected
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public Result<T, E> Ok(T data) => new(data);

    /// <summary>
    /// Used to create the error which occurred and then combined with the collect err the caller can collect the error.
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>
    public Result<T, E> Err(E error) => new(error);

    /// <summary>
    /// Warning: check the result state before unwrapping. Unwrap to collect the data
    /// </summary>
    /// <returns></returns>
    public T Unwrap() => Data;

    /// <summary>
    /// Warning: check the result state before unwrapping. Unwrap to collect the data
    /// </summary>
    /// <returns></returns>
    public void Unwrap(out T data) => data = Data;

    /// <summary>
    ///  Unwraps and returns the error
    /// </summary>
    /// <returns></returns>
    public E CollectErr() => Error;

    /// <summary>
    ///  Unwraps and returns the error
    /// </summary>
    /// <returns></returns>
    public void CollectErr(out E err) => err = Error;
}

public enum ResultState
{
    Ok,
    Err,
}

