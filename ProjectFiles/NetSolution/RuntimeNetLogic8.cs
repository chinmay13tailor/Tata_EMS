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
public class RuntimeNetLogic8 : BaseNetLogic
{
    private IUAVariable targetVariable;

    public IUAVariable consumptionVariable;

    private IUAVariable avgpfVariable;
    private IUAVariable avgfrequencyVariable;
    private IUAVariable avgllVariable;
    private IUAVariable avglnVariable;
    private IUAVariable dateVariable;
    private IUAVariable pfVariable;
    private IUAVariable frequencyVariable;
    private IUAVariable todconsumptionVariable;
    private IUAVariable selectionVariable;
    private IUAVariable buttonVariable;
   
    private PeriodicTask periodicTask;
   
    public override void Start()
    {
        
        var owner = (HomePageNew)LogicObject.Owner;
        targetVariable = owner.TargetVariable;
        consumptionVariable = owner.ConsumptionVariable;
        avgpfVariable = owner.AvgPFVariable;
        avgfrequencyVariable = owner.AvgFrequencyVariable;
        avgllVariable = owner.AvgLLVariable;
        avglnVariable = owner.AvgLNVariable;
        dateVariable = owner.DateVariable;
        pfVariable = owner.PFVariable;
        frequencyVariable = owner.FrequencyVariable;
        todconsumptionVariable = owner.TODConsumptionVariable;
        selectionVariable = owner.SelectionVariable;
        buttonVariable  = owner.ButtonVariable;
       






        periodicTask = new PeriodicTask(HomePageCalculationTask, 1000, LogicObject);
        periodicTask.Start();

    }

    public override void Stop()
    {
        periodicTask.Dispose();
        periodicTask = null;
    }

    public void HomePageCalculationTask()
    {
        DateTime date = dateVariable.Value;
        float target = targetVariable.Value;
        float consumption = consumptionVariable.Value;
        float avgpf = avgpfVariable.Value;
        float avgfrequency = avgfrequencyVariable.Value;
        float avgll = avgllVariable.Value;
        float avgln = avglnVariable.Value;
        float pf = pfVariable.Value;
        float frequency = frequencyVariable.Value;
        float todconsumption = todconsumptionVariable.Value;
        string selection = selectionVariable.Value;
        bool button = buttonVariable.Value;
        

        var project = FTOptix.HMIProject.Project.Current;


        var myStore1 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore2 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore3 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
       // var myStore4 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
       // var myStore5 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");


        object[,] resultSet1;
        string[] header1;

        object[,] resultSet2;
        string[] header2;

        object[,] resultSet3;
        string[] header3;

        //object[,] resultSet4;
       // string[] header4;

       // object[,] resultSet5;
       // string[] header5;


      if(button == true)
      {

            
            

                DateTime currentTime = DateTime.Now;
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
               string jace1 = selection.ToString();
               // Calculate start and end times for the current day
                DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
                DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 59, 59).AddDays(1);

                string new123 = startTime.ToString("yyyy-MM-dd");
                

                string query1 = $"SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = '" + jace1 + "' ";
                string query2 = $"SELECT AVG_PF FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00' AND Jace = '" + jace1 + "' ";
                string query3 = $"SELECT Frequency FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00' AND Jace = '" + jace1 + "' ";
                //string query4 = $"SELECT Voltage_LL FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00' AND Jace = '" + jace1 + "' ";
                //string query5 = $"SELECT Voltage_LN FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00' AND Jace = '" + jace1 + "' ";


                 myStore1.Query(query1, out header1, out resultSet1);
                 myStore2.Query(query2, out header2, out resultSet2);
                 myStore3.Query(query3, out header3, out resultSet3);
                // myStore4.Query(query4, out header4, out resultSet4);
                 //myStore5.Query(query5, out header5, out resultSet5);


                if (resultSet1 != null && resultSet1.GetLength(0) > 0 && header1 != null && header1.Length > 0)
                {
                    float.TryParse(resultSet1[0, 0]?.ToString(), out consumption);
                }

                if (resultSet2 != null && resultSet2.GetLength(0) > 0 && header2 != null && header2.Length > 0)
                {
                    float.TryParse(resultSet2[0, 0]?.ToString(), out avgpf);
                }
                // Process resultSet3 (Frequency)
                if (resultSet3 != null && resultSet3.GetLength(0) > 0 && header3 != null && header3.Length > 0)
                {
                    float.TryParse(resultSet3[0, 0]?.ToString(), out frequency);
                }

            // Process resultSet4 (Avg_PF)

            /*
            if (resultSet4 != null && resultSet4.GetLength(0) > 0 && header4 != null && header4.Length > 0)
            {
                float.TryParse(resultSet4[0, 0]?.ToString(), out avgll);
            }

            if (resultSet5 != null && resultSet5.GetLength(0) > 0 && header5 != null && header5.Length > 0)
            {
                float.TryParse(resultSet5[0, 0]?.ToString(), out avgln);

            }
            */

           
                float tod = (consumption / target) * 100;
            todconsumption = tod;


        }

        targetVariable.Value = target;
        consumptionVariable.Value = consumption;
        avgpfVariable.Value = avgpf;
        avgfrequencyVariable.Value = avgfrequency;
        avgllVariable.Value = avgll;
        avglnVariable.Value = avgln;
        dateVariable.Value = date;
        pfVariable.Value = pf;
        frequencyVariable.Value = frequency;
        todconsumptionVariable.Value = todconsumption;
        selectionVariable.Value = selection;
        buttonVariable.Value = button;
       



    }
}
