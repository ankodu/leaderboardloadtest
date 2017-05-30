// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Azure.Documents.Client;



namespace TestClient
{
    class Program
    {

        //private static string DatabaseId;
        //private static string CollectionId;
        //private static string endpointUrl;
        //private static string authorizationKey;



        static void Main(string[] args)
        {
            SetupCultureInfo();
            Greet();
            Configure();
            //SetupPropertyCache();

            new MainMenu().Show();

            Console.WriteLine("Closing client");
         }

        private static void SetupCultureInfo()
        {
            // Create a unique culture for all threads 
            // in order to make sure input and output of serialization and de-
            // serialization all look according to expected.
            var netherCultureInfo = new CultureInfo("en-US");
            netherCultureInfo.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            netherCultureInfo.DateTimeFormat.LongTimePattern = "HH:mm:ss";

            CultureInfo.DefaultThreadCurrentCulture = netherCultureInfo;
        }

        private static void Greet()
        {
            Console.WriteLine();
            Console.WriteLine(@" _   _      _   _               ");
            Console.WriteLine(@"| \ | | ___| |_| |__   ___ _ __ ");
            Console.WriteLine(@"|  \| |/ _ \ __| '_ \ / _ \ '__|");
            Console.WriteLine(@"| |\  |  __/ |_| | | |  __/ |   ");
            Console.WriteLine(@"|_| \_|\___|\__|_| |_|\___|_|   ");
            Console.WriteLine(@"- Leaderboard Test Client -");
            Console.WriteLine();
        }

        private static void Configure()
        {
            // Set Configuration using Environment Variables
            // Example from Admin PowerShell:
            //   [Environment]::SetEnvironmentVariable("NETHER_INGEST_EVENTHUB_CONNECTIONSTRING", "Endpoint=sb://nether.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=xxxxx", "User")
            //   [Environment]::SetEnvironmentVariable("NETHER_INGEST_EVENTHUB_NAME", "ingest", "User")

            Console.WriteLine("Configuring");
            //var ingestEventHubConnectionString = Environment.GetEnvironmentVariable("NETHER_INGEST_EVENTHUB_CONNECTIONSTRING");
            //var ingestEventHubName = Environment.GetEnvironmentVariable("NETHER_INGEST_EVENTHUB_NAME");

            ConfigCache.DatabaseId = "nether";
            ConfigCache.CollectionId = "leaderboard";
            ConfigCache.endpointUrl = "https://netherleaderboard.documents.azure.com:443/";
            ConfigCache.authorizationKey = "0pInTrncWxOXA0Itx03RovRyPvElq8BPFAQk0flM1T0CFhxORW8UZzMdh11B7s9bYMSS6CEDo4ZDTM9NJP7clw==";


            SetupMenu.ShowCurrentConfig();
        }

    }
}