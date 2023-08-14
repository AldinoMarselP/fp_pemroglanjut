[Setup]
AppName=Rental Motor AMIKOM
AppVerName=Rental Motor AMIKOM Versi 1.0.0
AppPublisher=Mahendra Bayu Prayoga
AppCopyright=Copyright © 2023. Mahendra
DefaultDirName={pf}\Rental Motor
DefaultGroupName=Rental Motor
OutputDir=file setup
OutputBaseFilename=Setup Rental Motor
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\motor.ico
UninstallDisplayName=Rental Motor AMIKOM
VersionInfoVersion=1.0.0.0
SetupIconFile=motor.ico


[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\PerpustakaanAppMVC.exe"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\PerpustakaanAppMVC.exe.config"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\Database\DbPerpustakaan.db"; DestDir: {app}\Database; Flags: ignoreversion

; file-file pendukung
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\System.Data.SQLite.dll"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\x64\SQLite.Interop.dll"; DestDir: {app}\x64; Flags: ignoreversion
Source: "D:\SEMESTER 3\Pemrograman Lanjut\Praktikum 13\Module 01\Module 01\PerpustakaanAppMVC\PerpustakaanAppMVC\bin\Debug\x86\SQLite.Interop.dll"; DestDir: {app}\x86; Flags: ignoreversion

Source: motor.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\Rental Motor AMIKOM; Filename: {app}\PerpustakaanAppMVC.exe; WorkingDir: {app}; IconFilename: {app}\motor.ico
Name: {userdesktop}\Rental Motor AMIKOM; Filename: {app}\PerpustakaanAppMVC.exe; WorkingDir: {app}; IconFilename: {app}\motor.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Rental Motor AMIKOM"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue