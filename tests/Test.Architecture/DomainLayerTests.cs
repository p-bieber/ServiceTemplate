using NetArchTest.Rules;
using Shouldly;

namespace Bieber.ServiceTemplate.Test.Architecture;

public class DomainLayerTests : BaseTest
{
    [Fact]
    public void Domain_Should_NotHaveDependencyOn_ApplicationLayer()
    {
        TestResult result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApplicationAssembly.GetName().Name)
            .GetResult();

        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void Domain_Should_NotHaveDependencyOn_InfrastructureLayer()
    {
        TestResult result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn(InfrastructureAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void Domain_Should_NotHaveDependencyOn_PresentationLayer()
    {
        TestResult result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn(PresentationAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void Domain_Should_NotHaveDependencyOn_ApiLayer()
    {
        TestResult result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApiAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
}
