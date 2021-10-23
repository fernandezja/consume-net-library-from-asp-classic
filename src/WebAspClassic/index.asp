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