#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.Report;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        String[] Parametros = { "%APPLICATIONDIR%/MyPdfFile.pdf", "" };
        Project.Current.GetObject("Reports/Reports1").ExecuteMethod("GeneratePdf", Parametros);
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
    
}

