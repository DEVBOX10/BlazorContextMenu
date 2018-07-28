﻿using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContextMenu.TestApp.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorContextMenu(options =>
            {
                options.ConfigureTemplate(defaultTemplate =>
                {
                    defaultTemplate.MenuCssClass = "my-menu";
                    defaultTemplate.MenuItemCssClass = "my-menu-item";
                    defaultTemplate.SeperatorCssClass = "my-menu-seperator";
                });

                options.ConfigureTemplate("testtemplate", template =>
                {
                    template.MenuCssClass = "my-menu-template";
                    template.MenuItemCssClass = "my-menu-item-template";
                    template.SeperatorCssClass = "my-menu-seperator-template";
                });

                options.CssOverrides(overrides =>
                {
                    overrides.MenuCssClass = "custom-menu";
                    overrides.MenuItemCssClass = "custom-menu-item";
                    overrides.MenuItemDisabledCssClass = "custom-menu-item--disabled";
                    //...
                });
            });
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
