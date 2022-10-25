namespace Ojave.Core.Http;

public sealed class HttpFileResult
{
    public HttpFileResult()
    {

    }
    public HttpFileResult(byte[] bytes, string contentType)
    {
        FileContents = bytes;
        ContentType = contentType;
        FileDownloadName = string.Empty;
    }

    public HttpFileResult(byte[] bytes, string contentType, string downloadName)
    {
        FileContents = bytes;
        ContentType = contentType;
        FileDownloadName = downloadName;
    }

    public byte[] FileContents { get; init; }
    public string ContentType { get; init; }
    public string FileDownloadName { get; init; }
}
