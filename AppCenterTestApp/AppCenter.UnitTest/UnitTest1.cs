namespace AppCenter.UnitTest
{
  using System.Linq;

  using AppCenterTestApp.Models;
  using AppCenterTestApp.Services;

  using Xunit;

  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      var store = new MockDataStore();

      Item item = store.GetItemsAsync().Result.First();
      Assert.NotNull(item);
      // Assert.False(true);
    }
  }
}
