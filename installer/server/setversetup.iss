; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "展開くんサーバ"
#define MyAppVersion "0.1"
#define MyAppPublisher "ぐだ鯖プログラミング部"
#define MyAppURL "https://git.gdgd.jp.net/"
#define MyAppExeName "TenkaiServer.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{7095F0CD-8AF0-46F4-B965-A756C1E0B60C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\gdgdapp\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=serversetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Input\www\index.html"; DestDir: "{app}\www"; Flags: ignoreversion
Source: "Input\LiteDB.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\LiteDB.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.FileSystems.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.FileSystems.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.Host.HttpListener.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.Host.HttpListener.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.Hosting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.Hosting.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.StaticFiles.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.StaticFiles.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Microsoft.Owin.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Nlog.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\NLog.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\NLog.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\Owin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Net.Http.Formatting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Net.Http.Formatting.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.Owin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.Owin.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.SelfHost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.SelfHost.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\System.Web.Http.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\TenkaiLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\TenkaiLib.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\TenkaiServer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\TenkaiServer.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\TenkaiServer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\YamlDotNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Input\YamlDotNet.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

