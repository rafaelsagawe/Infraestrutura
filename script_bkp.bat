mkdir bkp-desktop bkp-documentos

xcopy %userprofile%\Desktop\*.* bkp-desktop /w /s /y

xcopy %userprofile%\Documents\*.* bkp-documentos /s /y