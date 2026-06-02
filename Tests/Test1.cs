namespace Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
          var client = new YouTubeClient("credentials.json");
          client.PlaylistItems.insert("snippet", default);
    }
}
