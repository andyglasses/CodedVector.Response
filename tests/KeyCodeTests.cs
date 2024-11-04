using FluentAssertions;

namespace CodedVector.Response.Tests;

public class KeyCodeTests
{
  [Test]
  public void ToString_ShouldReturnKeyAndCode()
  {
    // Arrange
    var keyCode = new KeyCode("key", "code");

    // Act
    var result = keyCode.ToString();

    // Assert
    result.Should().Be("key: code");

  }
}
