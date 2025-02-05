using System.Reflection;

namespace Bieber.ServiceTemplate.API;
public static class ApiAssemblyInfo
{
    public static Assembly Assembly => typeof(ApiAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
