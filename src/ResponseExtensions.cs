namespace CodedVector.Response;

public static class ResponseExtensions
{
  public static Response Successful()
  {
    return new Response()
    {
      Success = true
    };
  }

  public static Response Failed(List<KeyCode> errors)
  {
    return new Response()
    {
      Success = false,
      Errors = errors
    };
  }

  public static Response<T> Successful<T>(T data)
  {
    return new Response<T>()
    {
      Success = true,
      Data = data
    };
  }

  public static Response<T> Failed<T>(List<KeyCode> errors)
  {
    return new Response<T>()
    {
      Success = false,
      Errors = errors
    };
  }
}
