using System.Reflection;

namespace Bieber.ServiceTemplate.Domain;
public static class DomainAssemblyInfo
{
    public static Assembly Assembly => typeof(DomainAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
