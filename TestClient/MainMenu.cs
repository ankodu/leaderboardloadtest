﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using TestClient.Utils;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;


namespace TestClient
{
    public class MainMenu : ConsoleMenu
    {
        public MainMenu()
        {
            Title = "Nether Leaderboard Test Client - Main Menu";

           // MenuItems.Add('1', new ConsoleMenuItem("Setup ...", Setup));
            MenuItems.Add('1', new ConsoleMenuItem("Setup ...", () => { new SetupMenu().Show(); }));
            //MenuItems.Add('2', new ConsoleMenuItem("Send Typed Game Events ...", () => { new SendTypedGameEventMenu().Show(); }));
            //MenuItems.Add('3', new ConsoleMenuItem("Send Custom Game Event", SendCustomGameEvent));
            //MenuItems.Add('4', new ConsoleMenuItem("Re-send Last Sent Message", ResendLastSentMessage));
            //MenuItems.Add('5', new ConsoleMenuItem("Simulate moving game client...", () => { new SimulateMovementMenu().Show(); }));
            //MenuItems.Add('6', new ConsoleMenuItem("USQL Script ...", () => new USQLJobMenu().Show()));
        }

        private void Setup()
        {
            Console.WriteLine("Setup...");
            //var msg = (string)EditProperty("Custom Message", $"This is a custom msg at {DateTime.UtcNow}", typeof(string));

            //EventHubManager.SendMessageToEventHub(msg).Wait();
        }

    }
}
