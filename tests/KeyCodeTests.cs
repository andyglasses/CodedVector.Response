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

  [Test]
  public void KeyCodeWithNumberDetail_ShouldReturnKeyCodeWithNumber()
  {
    // Arrange
    var key = "key";
    var code = "code";
    var number = 1;

    // Act
    var result = KeyCodeExtensions.KeyCodeWithNumberDetail(key, code, number);

    // Assert
    result.Key.Should().Be(key);
    result.Code.Should().Be($"{code}:{number}");
  }

  [Test]
  public void KeyCodeWithNumberDetail_ShouldThrowArgumentException_WhenCodeContainsColon()
  {
    // Arrange
    var key = "key"; 
    var code = "cod:e";
    var number = 1;

    // Act
    var act = () => KeyCodeExtensions.KeyCodeWithNumberDetail(key, code, number);

    // Assert
    act.Should().Throw<ArgumentException>().WithMessage("Code cannot contain a colon");
  }
}
