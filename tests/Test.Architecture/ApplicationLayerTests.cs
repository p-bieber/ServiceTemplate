using NetArchTest.Rules;
using Shouldly;

namespace Bieber.ServiceTemplate.Test.Architecture;

public class ApplicationLayerTests : BaseTest
{
    [Fact]
    public void Application_Should_NotHaveDependencyOn_InfrastructureLayer()
    {
        TestResult result = Types.InAssembly(ApplicationAssembly)
            .ShouldNot()
            .HaveDependencyOn(InfrastructureAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void Application_Should_NotHaveDependencyOn_PresentationLayer()
    {
        TestResult result = Types.InAssembly(ApplicationAssembly)
            .ShouldNot()
            .HaveDependencyOn(PresentationAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void Application_Should_NotHaveDependencyOn_ApiLayer()
    {
        TestResult result = Types.InAssembly(ApplicationAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApiAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
}
