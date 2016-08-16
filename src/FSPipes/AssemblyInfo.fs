﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSPipes")>]
[<assembly: AssemblyProductAttribute("FSPipes")>]
[<assembly: AssemblyDescriptionAttribute("F# streaming IO library")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"