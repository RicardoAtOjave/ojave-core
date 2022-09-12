namespace Ojave.Core.Http;

public sealed class HttpCoreResponse<T>
{
    public HttpCoreResponse(int statusCode, string message, T data)
    {
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
}
