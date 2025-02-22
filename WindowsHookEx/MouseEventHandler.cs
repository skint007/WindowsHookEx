﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace WindowsHookEx
{
    /// <summary>
    /// Represents the method that will handle the <see langword='MouseDown'/>,
    /// <see langword='MouseUp'/>, or <see langword='MouseMove '/>
    /// event of a form, control, or other component.
    /// </summary>
    public delegate void MouseEventHandler(object sender, MouseEventArgs e);
}
