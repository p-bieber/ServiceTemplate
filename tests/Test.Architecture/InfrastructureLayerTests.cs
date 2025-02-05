using NetArchTest.Rules;
using Shouldly;

namespace Bieber.ServiceTemplate.Test.Architecture;

public class InfrastructureLayerTests : BaseTest
{
    [Fact]
    public void Infrastructure_Should_NotHaveDependencyOn_PresentationLayer()
    {
        TestResult result = Types.InAssembly(InfrastructureAssembly)
            .ShouldNot()
            .HaveDependencyOn(PresentationAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
    [Fact]
    public void Infrastructure_Should_NotHaveDependencyOn_ApiLayer()
    {
        TestResult result = Types.InAssembly(InfrastructureAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApiAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
}
