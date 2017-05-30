// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using TestClient.Utils;

namespace TestClient
{
    public class SetupMenu : ConsoleMenu
    {
        public SetupMenu()
        {
            Title = "Nether Leaderboard Test Client - Setup Menu";

            MenuItems.Add('1', new ConsoleMenuItem($"Set DatabaseID", SetDatabaseID));
            MenuItems.Add('2', new ConsoleMenuItem($"Set EndpointUrl", SetEndpointUrl));
            MenuItems.Add('3', new ConsoleMenuItem($"Set CollectionId", SetCollectionId));

        }

        protected override void PrintFooter()
        {
            ShowCurrentConfig();
        }

        private void SetDatabaseID()
        {
            ConfigCache.DatabaseId = (string)EditProperty("Event Hub Connection String", ConfigCache.DatabaseId, typeof(string));
        }

        private void SetEndpointUrl()
        {
            ConfigCache.endpointUrl = (string)EditProperty("Event Hub Name", ConfigCache.endpointUrl, typeof(string));
        }

        private void SetCollectionId()
        {
            ConfigCache.CollectionId  = (string)EditProperty("Event Hub Name", ConfigCache.CollectionId, typeof(string));
        }

        public static void ShowCurrentConfig()
        {
            Console.WriteLine();
            Console.WriteLine("Using:");
            Console.WriteLine($"  DatabaseId: {ConfigCache.DatabaseId ?? "not specified"}");
            Console.WriteLine($"  Endpoint Url: {ConfigCache.endpointUrl?? "not specified"}");
            Console.WriteLine($"  CollectionId: {ConfigCache.CollectionId  ?? "not specified"}");
            Console.WriteLine();
        }
    }
}
