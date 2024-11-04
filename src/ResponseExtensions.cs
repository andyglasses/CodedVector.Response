namespace CodedVector.Response;

/// <summary>
/// Response extensions
/// </summary>
public static class ResponseExtensions
{
  /// <summary>
  /// Create a successful response
  /// </summary>
  /// <returns>Response</returns>
  public static Response Successful()
  {
    return new Response()
    {
      Success = true
    };
  }

  /// <summary>
  /// Create a failed response
  /// </summary>
  /// <param name="errors">Collection of errors</param>
  /// <returns>Response</returns>
  public static Response Failed(List<KeyCode> errors)
  {
    return new Response()
    {
      Success = false,
      Errors = errors
    };
  }

  /// <summary>
  /// Create a successful response with data
  /// </summary>
  /// <typeparam name="T">The payload type</typeparam>
  /// <param name="data">The payload data</param>
  /// <returns>Response</returns>
  public static Response<T> Successful<T>(T data)
  {
    return new Response<T>()
    {
      Success = true,
      Data = data
    };
  }

  /// <summary>
  /// Create a failed payload response with errors
  /// </summary>
  /// <typeparam name="T">The payload type</typeparam>
  /// <param name="errors">Collection of errors</param>
  /// <returns>Response</returns>
  public static Response<T> Failed<T>(List<KeyCode> errors)
  {
    return new Response<T>()
    {
      Success = false,
      Errors = errors
    };
  }
}
