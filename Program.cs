using System;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace BgFBG_MergeTool
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.BuildContainer();

            //TODO code
            var logger = serviceProvider.GetService<ILogger>();
            logger.Information("hello world");

            Console.WriteLine("to be continued...");
        }
    }
}
