using System.Reflection;
using System;
// // Assembly assembly = Assembly.GetExecutingAssembly();
// // Console.WriteLine(assembly);

// class Program
// {
//  static void Main()
//     {
//     //  Type type = typeof(Employee); 
//     //  Console.WriteLine(type.Name);
//     //  MethodInfo method = type.GetMethod("Display");
//     //  method.Invoke(obj,null);
// // Properties......................................................................
//         Type t = typeof(Employee);
//         Console.WriteLine("Properties:");
//         PropertyInfo[] properties = t.GetProperties();
//         foreach (PropertyInfo p in properties)
//         {
//             Console.WriteLine(p.Name + " - " + p.PropertyType);
//         }
//        Console.WriteLine("Methods:");
//         MethodInfo[] methods = t.GetMethods(
//             BindingFlags.Public |
//             BindingFlags.Instance |
//             BindingFlags.DeclaredOnly
//         );
// // Methods.---------------------------------------------------------
//         foreach (MethodInfo m in methods)
//         {
//             Console.WriteLine(m.Name + " - Return Type: " + m.ReturnType);
//         }
//         foreach (MethodInfo method in t.GetMethods())
//         {
//             Console.WriteLine(method.Name);
//         }
// // Constructor-----------------------------------------------------
//       ConstructorInfo constructor = t.GetConstructor(new Type[] { typeof(int), typeof(string) });

// Console.WriteLine("Constructor Name: " + constructor.Name);

// // Parameter .......................................
// ParameterInfo[] parameters = constructor.GetParameters();

// foreach (ParameterInfo p in parameters)
// {
//     Console.WriteLine("Parameter Name: " + p.Name +", Type: " + p.ParameterType);
// }
// // Fields ------------------------------
// object objectInstance = Activator.CreateInstance(t);
// FieldInfo field = t.GetField("n",BindingFlags.Public | BindingFlags.Instance);
// Console.WriteLine(field.FieldType);
// Console.WriteLine("Field Value: " + field.GetValue(objectInstance));
// field.SetValue(objectInstance, "gghfh");
// Console.WriteLine("Field Value: " + field.GetValue(objectInstance));


// }
// }
using UltraEnterpriseSDLC;
using System.Linq;
    public class Program
    {
        public static void Main()
        {
            EnterpriseSDLCEngine engine = new EnterpriseSDLCEngine();

            engine.AddRequirement("Single Sign-On", RiskLevel.High);
            engine.AddRequirement("Fraud Detection", RiskLevel.Critical);

            WorkItem design = engine.CreateWorkItem("Design SSO", SDLCStage.Design);
            WorkItem development = engine.CreateWorkItem("Develop SSO", SDLCStage.Development);
            WorkItem testing = engine.CreateWorkItem("Test SSO", SDLCStage.Testing);

            engine.AddDependency(development.Id, design.Id);
            engine.AddDependency(testing.Id, development.Id);

            engine.RegisterTestSuite("SSO-Regression");
            engine.RegisterTestSuite("SSO-Security-Smoke");

            engine.PlanStage(SDLCStage.Design);

            engine.ExecuteNext();
            engine.ExecuteNext();

            engine.DeployRelease("v3.4.1");

            engine.RecordQualityMetric("Code Coverage", 91.7);
            engine.RecordQualityMetric("Security Score", 97.3);

            engine.RollbackRelease();

            engine.PrintAuditLedger();
            engine.PrintReleaseScoreboard();
        }
    }

