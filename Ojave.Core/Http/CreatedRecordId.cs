namespace Ojave.Core.Http;

/// <summary>
/// This is to be used in the serialized response of the HttpCoreResponse to note the new record id inserted into the database
/// as opposed to simply returning an integer, string or Guid
/// </summary>
/// <typeparam name="T"></typeparam>
public class CreatedRecordResponse<T>
{
    public T CreatedRecordId { get; set; }
}
