﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Mvc.Razor;
using Microsoft.Framework.DependencyInjection;

namespace RazorCompilerCacheWebSite
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            var configuration = app.GetTestConfiguration();

            app.UseServices(services =>
            {
                services.AddMvc();
                services.AddSingleton<ICompilerCache, CustomCompilerCache>();
                services.AddSingleton<CompilerCacheInitialiedService>();
            });

            app.UseMvc();
        }
    }
}
