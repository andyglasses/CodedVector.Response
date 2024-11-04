namespace CodedVector.Response;

/// <summary>
/// Payload response
/// </summary>
/// <typeparam name="T"></typeparam>
public class Response<T> : Response
{
  /// <summary>
  /// The data payload
  /// </summary>
  public T? Data { get; set; }
}
