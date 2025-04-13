# Qubic Live Screensaver

Creates a screensaver for Windows that displays the website [live.qubic.org](https://live.qubic.org).

## Features

- Displays the live website `live.qubic.org` as a screensaver.
- Lightweight and easy to install.
- Compatible with Windows operating systems.

## Development

### Run
```
dotnet run
```

### Publish
```
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./publish
```

### Important
In the /publish directory the .exe file must be renamed to .scr. 


## Qubic Screensaver Installation Guide

Follow these steps to install and set up the Qubic Screensaver on your system:

### 1. Create a Directory

Create a directory at the following path:
```
C:\qubic-screensaver
```

### 2. Copy the Program Files to the Directory

Copy the following files to the directory:
- `qubic-live-screensaver.scr`
- `WebView2Loader.dll`

These files are included in the `qubic-live-screensaver.zip` package.

### 3. Add the Registry Entry

1. Open a Command Prompt with Administrator rights (Right-click on "Command Prompt" and select "Run as Administrator").
2. Run the following command:
```
reg add "HKCU\Control Panel\Desktop" /v SCRNSAVE.EXE /t REG_SZ /d "C:\qubic-screensaver\qubic-live-screensaver.scr" /f
```

This will register the screensaver in the system registry.

### 4. Select the Screensaver in Windows Settings

1. Open the Windows screensaver settings.
2. Select **Qubic Live Screensaver** from the list.

You are now all set to use the Qubic Screensaver on your system!

### License
This project is licensed under the MIT License.

### Author
AndyQus