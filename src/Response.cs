namespace CodedVector.Response;

/// <summary>
/// A basic response object.
/// </summary>
public class Response
{
  /// <summary>
  /// Success indicator
  /// </summary>
  public bool Success { get; set; }

  /// <summary>
  /// List of errors, should only be populated if Success is false.
  /// </summary>
  public List<KeyCode> Errors { get; set; } = new();
}
