using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DITestApp.Models;


namespace DITestApp

{
    /// <summary>
    /// A static class for retrieving API keys and other application settings.
    /// </summary>
    public static class ApplicationEngine
    {
        public static string ShopifySecretKey { get; } =
            Startup.StaticConfig.GetSection("Shopify")["Shopify_Secret_Key"];
        public static string ShopifyApiKey { get; } =
            Startup.StaticConfig.GetSection("Shopify")["Shopify_API_Key"];
    }
}
