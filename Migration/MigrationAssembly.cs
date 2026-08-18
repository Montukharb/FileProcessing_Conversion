using System;
using System.Collections.Generic;
using System.Text;

namespace Migration
{
    public class MigrationAssembly
    {
        public static string AssemblyName => typeof(MigrationAssembly).Assembly.GetName().Name!;
    }
}
