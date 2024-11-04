namespace CodedVector.Response;

/// <summary>
/// KeyCode extensions
/// </summary>
public static class KeyCodeExtensions
{
  /// <summary>
  /// Creates a key code with a number prostfixed to the code
  /// </summary>
  /// <param name="key">The key</param>
  /// <param name="code">The code</param>
  /// <param name="number"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentException"></exception>
  public static KeyCode KeyCodeWithNumberDetail(string key, string code, int number)
  {
    if(code.Contains(':'))
    {
      throw new ArgumentException("Code cannot contain a colon");
    }
    return new KeyCode(key, $"{code}:{number}");
  }
}
