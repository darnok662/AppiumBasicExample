using NUnit.Framework;

namespace UITests;

public class ExampleTest : BaseTest
{
	[Test]
	public void SampleTest()
	{
		App.GetScreenshot().SaveAsFile($"{nameof(SampleTest)}.png");
	}
}