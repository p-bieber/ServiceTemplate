using System.Reflection;

namespace Bieber.ServiceTemplate.Application;
public static class ApplicationAssemblyInfo
{
    public static Assembly Assembly => typeof(ApplicationAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
