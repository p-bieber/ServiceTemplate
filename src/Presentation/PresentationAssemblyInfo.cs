using System.Reflection;

namespace Bieber.ServiceTemplate.Presentation;
public static class PresentationAssemblyInfo
{
    public static Assembly Assembly => typeof(PresentationAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
