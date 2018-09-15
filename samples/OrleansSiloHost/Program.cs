﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace OrleansSiloHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new SiloHostBuilder()
                .UseLocalhostClustering()
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "samples";
                    options.ServiceId = "OrleansSiloHost";
                })
                .AddDynamoDBGrainStorage()
                .AddMemoryGrainStorage("MemoryStore")
                .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
                .ConfigureLogging(logging => logging.AddConsole());
            
            var host = builder.Build();

            await host.StartAsync();

            Console.Read();
        }
    }
}
