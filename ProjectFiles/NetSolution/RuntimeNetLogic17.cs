#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.DataLogger;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using Store = FTOptix.Store;
using System.Text.RegularExpressions;
using FTOptix.SQLiteStore;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Reflection.Emit;
using FTOptix.MicroController;
using FTOptix.AuditSigning;
using FTOptix.Alarm;
#endregion

public class RuntimeNetLogic17 : BaseNetLogic
{
    public override void Start()
    {
        time = (MethodInvocation)LogicObject.Get("time");
        if (time == null)
            throw new CoreConfigurationException("Unable to find OnTimeout method invocation");
        // Initialize and start the monitoring thread with a 500ms interval
        periodicTask = new PeriodicTask(MonitorPowerValue, 60000, LogicObject);
        periodicTask.Start();
    }

    public override void Stop()

    {
        // Stop the monitoring thread
        periodicTask.Dispose();
        periodicTask = null;
    }

    private void MonitorPowerValue()
    {

        //var powerVariable = LogicObject.GetVariable("power");
        var alarm = Project.Current.GetVariable("Model/Alarms/PLC_Status/33KVPLCStatus").Value;
        if (alarm == false)
        {

            throw new Exception("33KV Jace Disconnected");
        }

        bool alarm1 = alarm;
        if (alarm1 == true)
        {
            time.Invoke();
        }
    }

    private MethodInvocation time;
    private PeriodicTask periodicTask;
}


