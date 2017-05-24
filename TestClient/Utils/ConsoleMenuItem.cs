﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace TestClient.Utils
{
    public class ConsoleMenuItem
    {
        public ConsoleMenuItem(string text, Action menuAction)
        {
            Text = text;
            MenuAction = menuAction;
        }

        public string Text { get; }

        public Action MenuAction { get; }
    }
}
