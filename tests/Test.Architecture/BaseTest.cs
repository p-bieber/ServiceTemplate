using System.Reflection;
using Bieber.ServiceTemplate.API;
using Bieber.ServiceTemplate.Application;
using Bieber.ServiceTemplate.Domain;
using Bieber.ServiceTemplate.Infrastructure;
using Bieber.ServiceTemplate.Presentation;

namespace Bieber.ServiceTemplate.Test.Architecture;

public abstract class BaseTest
{
    protected static readonly Assembly DomainAssembly = DomainAssemblyInfo.Assembly;
    protected static readonly Assembly ApplicationAssembly = ApplicationAssemblyInfo.Assembly;
    protected static readonly Assembly InfrastructureAssembly = InfrastructureAssemblyInfo.Assembly;
    protected static readonly Assembly PresentationAssembly = PresentationAssemblyInfo.Assembly;
    protected static readonly Assembly ApiAssembly = ApiAssemblyInfo.Assembly;
}
