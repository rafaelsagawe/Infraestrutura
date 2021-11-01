mkdir \\172.15.0.6\Desktop\Usuarios\%username%\bkp-desktop

mkdir \\172.15.0.6\Desktop\Usuarios\%username%\bkp-documentos

xcopy %userprofile%\Desktop\*.* \\172.15.0.6\Desktop\Usuarios\%username%\bkp-desktop /s /y

xcopy %userprofile%\Documents\*.* \\172.15.0.6\Desktop\Usuarios\%username%\bkp-documentos /s /y