namespace CodedVector.Response;

public class Response<T> : Response
{
  public T? Data { get; set; }
}
