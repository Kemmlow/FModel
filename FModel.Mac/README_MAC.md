# FModel MacOS Intel Port

## Requirements
- .NET 8.0 SDK
- MacOS 10.15+ (Intel)
- Oodle binaries (liboo2coremac64.dylib) placed in Native/Mac/

## Building
Run `dotnet build FModel.Mac.csproj`

## Features Ported
- 1:1 UI Layout using Avalonia UI
- Archive Browsing (CUE4Parse)
- AES Key Management
- Settings Persistence (~/Library/Application Support/FModel)
- Infrastructure for 3D Preview (OpenTK.Avalonia)
- Infrastructure for Audio Playback (LibVLCSharp)
