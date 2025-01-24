dotnet publish -c Release -r win-x64 -p:SelfContained=true
copy PKHeX.WinForms\bin\Release\net9.0-windows\win-x64\publish\PKHeX.exe .\PKHeX.exe
