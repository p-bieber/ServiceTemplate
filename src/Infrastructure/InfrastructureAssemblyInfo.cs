using System.Reflection;

namespace Bieber.ServiceTemplate.Infrastructure;
public static class InfrastructureAssemblyInfo
{
    public static Assembly Assembly => typeof(InfrastructureAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
