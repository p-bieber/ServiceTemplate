using NetArchTest.Rules;
using Shouldly;

namespace Bieber.ServiceTemplate.Test.Architecture;
public class PresentationLayerTests : BaseTest
{
    [Fact]
    public void Presentation_Should_NotHaveDependencyOn_ApiLayer()
    {
        TestResult result = Types.InAssembly(PresentationAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApiAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
}
