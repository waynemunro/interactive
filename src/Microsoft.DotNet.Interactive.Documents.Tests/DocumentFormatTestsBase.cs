// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace Microsoft.DotNet.Interactive.Documents.Tests
{
    public abstract class DocumentFormatTestsBase
    {
        public Dictionary<string, string> KernelLanguageAliases { get; }

        protected DocumentFormatTestsBase()
        {
            KernelLanguageAliases = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
                ["fsharp"] = "fsharp",
                ["fs"] = "fsharp",
                ["f#"] = "fsharp",
                ["csharp"] = "csharp",
                ["cs"] = "csharp",
                ["c#"] = "csharp",
                ["powershell"] = "pwsh",
                ["pwsh"] = "pwsh",
                ["markdown"] = "markdown", 
                ["md"] = "markdown"

            };
        }
    }
}