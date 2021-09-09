using System;
namespace BgFBG_MergeTool.Modules
{
    using Autofac;
    public class ConsoleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // To register dependencies
         //   builder.AddAutoMapper(x=>x.AddProfile<MyAutoMapperProfile>());
         }
    }
}
