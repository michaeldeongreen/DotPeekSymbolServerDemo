using Peekaboo.Liabilities.Services;
using Peekaboo.Liabilities.Services.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CE.Web.Api.DependencyResolution
{
    public class NuGetRegistry : Registry
    {
        public NuGetRegistry()
        {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.AssemblyContainingType<LiabilityMatchService>();
                });
        }
    }
}