# consume-net-library-from-asp-classic
Consume a NET library from ASP Classic (or VB6 via Visible COM)

<br /><br />

## Steps
<br />

### Step 1: Create NET Library

 - Create project NET Library
 - Install nuget component [System.Runtime.InteropServices](https://www.nuget.org/packages/System.Runtime.InteropServices/)
 - Decorate class with InteropServices attributes > 
  [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.guidattribute?view=net-5.0), [ComVisible](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.comvisibleattribute?view=net-5.0), [ProgId](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.progidattribute?view=net-5.0). More info [Interoperating with unmanaged code](https://docs.microsoft.com/en-us/dotnet/framework/interop/)

![Alt text](/assets/image-01-interopservices-attributes.png?raw=true "Decorate class with InteropServices attributes")

 - Compile release mode.
  
<br /><br />

### Step 2: You Must Register assembly (DLL) with Regasm.exe to use them
 - With [Regasm.exe (Assembly Registration Tool)](https://docs.microsoft.com/en-us/dotnet/framework/tools/regasm-exe-assembly-registration-tool)
 - Into 64bits OS 
```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319
```
 - Into 32bits OS 
```
C:\Windows\Microsoft.NET\Framework\v4.0.30319
```

 - Code example
```
.\RegAsm.exe "D:\dev\dll-com-visible\StarwarsCharacters.NET48.dll" /codebase
```
(NOTA: /codebase)
'''
	Creates a Codebase entry in the registry. The Codebase entry specifies the file path for an assembly that's not installed in the global assembly cache. Don't specify this option if you will subsequently install the assembly that you're registering into the global assembly cache. The assemblyFile argument that you specify with the /codebase option must be a strong-named assembly. [(more info)](https://docs.microsoft.com/en-us/dotnet/framework/tools/regasm-exe-assembly-registration-tool)
'''
<br /><br />
### Step 3: Use (example ASP Classic)
```
 <% 
       
Dim managerNET48
Set managerNET48 = server.CreateObject("StarwarsCharacters.NET48.StarwarsCharactersManager")

Dim jediNET48
Set jediNET48 = managerNET48.GetRandom()

%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Starwars</title>
</head>
<body>
     <h1>Starwars</h1>

    <h2>Component NET Framework 4.8</h2>
    <ul>
        <li>
             Jedi Random <strong><% response.Write(jediNET48.Name) %> (Id=<% response.Write(jediNET48.Id) %>)</strong>
        </li>
        <li>
            Component info: <strong><% response.Write(managerNET48.GetInfo()) %></strong>
        </li>
    </ul>
   
</body>
</html>
```

<br /><br />
## Links
  - Install ASP Classic on Windows Server/10/11 > [Classic ASP Not Installed by Default on IIS 7.0 and above](https://docs.microsoft.com/en-us/iis/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/classic-asp-not-installed-by-default-on-iis)
  - [Regasm.exe (Assembly Registration Tool)](https://docs.microsoft.com/en-us/dotnet/framework/tools/regasm-exe-assembly-registration-tool)
  - [Interoperating with unmanaged code](https://docs.microsoft.com/en-us/dotnet/framework/interop/)