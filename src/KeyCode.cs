namespace CodedVector.Response;

public record KeyCode(string Key, string Code)
{
  public override string ToString() => $"{Key}: {Code}";
}
