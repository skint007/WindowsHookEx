﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace WindowsHookEx
{
    /// <summary>
    /// Represents a method that will handle the <see cref='System.Windows.Forms.Control.KeyUp'/>
    /// or <see cref='System.Windows.Forms.Control.KeyDown'/> event of a
    /// <see cref='System.Windows.Forms.Control'/>.
    /// </summary>
    public delegate void KeyEventHandler(object sender, KeyEventArgs e);
}
