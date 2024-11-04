namespace CodedVector.Response;

public class Response
{
  public bool Success { get; set; }
  public List<KeyCode> Errors { get; set; } = new();
}
