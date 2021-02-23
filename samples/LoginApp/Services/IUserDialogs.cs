// Copyright (c) 2021 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace LoginApp.Services
{
    /// <summary>
    /// This interface defines a platform-specific notification manager.
    /// </summary>
    public interface IUserDialogs
    {
        /// <summary>
        /// Displays a platform-specific notification containing a message.
        /// </summary>
        /// <param name="message">The message to show.</param>
        void ShowDialog(string message);
    }
}
