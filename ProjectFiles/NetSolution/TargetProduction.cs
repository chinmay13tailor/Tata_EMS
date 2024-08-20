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

public class TargetProduction : BaseNetLogic
{
   
    
   
    private IUAVariable targetstampingVariable;
    private IUAVariable targettcfVariable; 
    private IUAVariable targetbodyshopVariable;
    private IUAVariable targetsppVariable;
    private IUAVariable targetengineshopVariable;
    private IUAVariable target33kvVariable;
    private IUAVariable targetpaintshopVariable;
    private IUAVariable targetVariable;
    private IUAVariable buttonVariable;
    private IUAVariable todayConsumptionVariable;
    private IUAVariable todayConsumptionCostVariable;
    private IUAVariable averageFrequencyVariable;
    private IUAVariable avgPowerfactorVariable;
    private IUAVariable monthConsumptionVariable;
    private IUAVariable monthConsumptionCostVariable;
    private IUAVariable productioncountVariable;
    private IUAVariable guageMaxVariable;
    private PeriodicTask periodicTask;

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        var owner = (Target_Production_Homepage)LogicObject.Owner;
        productioncountVariable = owner.ProductionCountVariable;     
        targetVariable = owner.TargetVariable;
        targetstampingVariable = owner.TargetStampingVariable;
        targettcfVariable = owner.TargetTcfVariable;
        targetbodyshopVariable = owner.TargetBodyshopVariable;
        targetengineshopVariable = owner.TargetEngineshopVariable;
        targetpaintshopVariable = owner.TargetPaintshopVariable;
        targetsppVariable = owner.TargetSppVariable;
        target33kvVariable = owner.Target33KVVariable;
        buttonVariable = owner.ButtonVariable;
        todayConsumptionVariable = owner.TodayConsumptionVariable;
        todayConsumptionCostVariable = owner.TodayConsumptionCostVariable;
        averageFrequencyVariable = owner.AverageFrequencyVariable;
        avgPowerfactorVariable = owner.AveragePowerFactorVariable;
        monthConsumptionVariable = owner.MonthConsumptionVariable;
        monthConsumptionCostVariable = owner.MonthConsumptionCostVariable;
        guageMaxVariable = owner.GuageMaxVariable;
        periodicTask = new PeriodicTask(IncrementDecrementTask, 2000, LogicObject);
        periodicTask.Start();


    }
    ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        periodicTask.Dispose();
        periodicTask = null;
    }

    public void IncrementDecrementTask()
    {
        
        bool button = buttonVariable.Value;
        float todayconsumption = todayConsumptionVariable.Value;
        float monthconsumption = monthConsumptionVariable.Value;
        float monthconsumptioncost = monthConsumptionCostVariable.Value;
        float todayconsumptioncost = todayConsumptionCostVariable.Value;
        float averageFrequency = averageFrequencyVariable.Value;
        float avgpowerfactor = avgPowerfactorVariable.Value;
        int target = targetVariable.Value;
        int targetstamping = targetstampingVariable.Value;
        int targettcf = targettcfVariable.Value;
        int targetbodyshop = targetbodyshopVariable.Value;
        int targetengineshop = targetengineshopVariable.Value;
        int targetpaintshop = targetpaintshopVariable.Value;
        int targetspp = targetsppVariable.Value;
        int target33kv = target33kvVariable.Value;
        //////////////Production Count/////////////////
        int productioncount = productioncountVariable.Value;
        int guagemax = guageMaxVariable.Value;
        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

        var project = FTOptix.HMIProject.Project.Current;
        // For Utility
        var myStore1 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore2 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore3 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore4 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore5 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        // For Stamping
        var myStore6 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore7 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore8 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore9 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore10 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");

        // For TCF
        var myStore11 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore12 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore13 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
       
        
                                                                                         //////////////////////////////////Production Count Update Update////////////////////////////////////////////////

        

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        // For Utility
        object[,] resultSet1;
        string[] header1;
        object[,] resultSet2;
        string[] header2;
        object[,] resultSet3;
        string[] header3;
        object[,] resultSet4;
        string[] header4;
        object[,] resultSet5;
        string[] header5;

        // For Stamping
        object[,] resultSet6;
        string[] header6;
        object[,] resultSet7;
        string[] header7;
        object[,] resultSet8;
        string[] header8;
        object[,] resultSet9;
        string[] header9;
        object[,] resultSet10;
        string[] header10;

        // For TCF
        object[,] resultSet11;
        string[] header11;
        object[,] resultSet12;
        string[] header12;
        object[,] resultSet13;
        string[] header13;
       

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        if (button == true)
        {

            DateTime currentTime = DateTime.Now;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            // Calculate start and end times for the current day
            DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
            DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddDays(-1);
            string old123 = endTime.ToString("yyyy-MM-dd");
            string new123 = startTime.ToString("yyyy-MM-dd");
            string new12 = startTime.ToString("yyyy-MM");
            float target33KV = target33kvVariable.Value;
            float targetstamping1 = targetstampingVariable.Value;
            float targettcf1 = targettcfVariable.Value;
            float targetbodyshop1 = targetbodyshopVariable.Value;
            float targetengineshop1 = targetengineshopVariable.Value;
            float targetpaintshop1 = targetpaintshopVariable.Value;
            float targetspp1 = targetsppVariable.Value;
            float targetutility1 = targetVariable.Value;
            float productioncount1 = productioncountVariable.Value;

    
            // For Utility
            string query1 = $" UPDATE HomePage SET Target = '" + target33KV + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = '33KV' ";
            string query2 = $" UPDATE HomePage SET Target = '" + targetutility1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'UTILITY' ";
            string query3 = $" UPDATE HomePage SET Target = '" + targetpaintshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'PAINTSHOP' ";
            string query4 = $" UPDATE HomePage SET Target = '" + targetspp1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'SPP' ";
            string query5 = $" UPDATE HomePage SET Target = '" + targetbodyshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'BODYSHOP' ";
            string query6 = $" UPDATE HomePage SET Target = '" + targetstamping1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'STAMPING' ";
            string query7 = $" UPDATE HomePage SET Target = '" + targetengineshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'ADMIN' ";
            string query8 = $" UPDATE HomePage SET Target = '" + targettcf1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'TCF' ";
            string query9 = $"SELECT Consumption FROM DailyJaceDataLogger WHERE LocalDate = '" + new123 + " 00:00:00' AND Jace = '33KV'";
            string query10 = $"SELECT Frequency FROM DailyJaceDataLogger WHERE LocalDate = '" + new123 + " 00:00:00' AND Jace = '33KV'";
            string query11 = $"SELECT Avg_PF FROM DailyJaceDataLogger WHERE LocalDate = '" + new123 + " 00:00:00' AND Jace = '33KV'";
            string query12 = $"SELECT SUM(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + new12 + "' AND Jace = '33KV'";
            string query13 = $" UPDATE HomePage SET Production = '" + productioncount1 + "' WHERE LocalTimestamp BETWEEN '" + old123 + " 0:00:00' AND '" + old123 + " 23:59:59' ";






            ////////////////////////////////*********************************************/////////////////////////////////////////////////////////////////////////// 
            // For Utility
            myStore1.Query(query1, out header1, out resultSet1);
            myStore2.Query(query2, out header2, out resultSet2);
            myStore3.Query(query3, out header3, out resultSet3);
            myStore4.Query(query4, out header4, out resultSet4);
            myStore5.Query(query5, out header5, out resultSet5);
            // For Stamping
            myStore6.Query(query6, out header6, out resultSet6);
            myStore7.Query(query7, out header7, out resultSet7);
            myStore8.Query(query8, out header8, out resultSet8);
            myStore9.Query(query9, out header9, out resultSet9);
            myStore10.Query(query10, out header10, out resultSet10);

            // For Tcf
             myStore11.Query(query11, out header11, out resultSet11);
            myStore12.Query(query12, out header12, out resultSet12);
            myStore13.Query(query13, out header13, out resultSet13);

            /////////////////For Production Count/////////////////////

            ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

            //For Utility

            var rowCount9 = resultSet9 != null ? resultSet9.GetLength(0) : 0;
             var columnCount9 = header9 != null ? header9.Length : 0;
             if (rowCount9 > 0 && columnCount9 > 0)
             {
                 var column9 = Convert.ToInt32(resultSet9[0, 0]);
                 var TodayConsumption = column9;
                todayconsumption = TodayConsumption;
             }

            var rowCount10 = resultSet10 != null ? resultSet10.GetLength(0) : 0;
            var columnCount10 = header10 != null ? header10.Length : 0;
            if (rowCount10 > 0 && columnCount10 > 0)
            {
                var column10 = Convert.ToInt32(resultSet10[0, 0]);
                var AverageFrequency = column10;
                averageFrequency = AverageFrequency;
            }

            var rowCount11 = resultSet11 != null ? resultSet11.GetLength(0) : 0;
            var columnCount11 = header11 != null ? header11.Length : 0;
            if (rowCount11 > 0 && columnCount11 > 0)
            {
                var column11 = Convert.ToInt32(resultSet11[0, 0]);
                var AvgPowerFactor = column11;
                avgpowerfactor = AvgPowerFactor;
            }

            var rowCount12 = resultSet12 != null ? resultSet12.GetLength(0) : 0;
            var columnCount12 = header12 != null ? header12.Length : 0;
            if (rowCount12 > 0 && columnCount12 > 0)
            {
                var column12 = Convert.ToInt32(resultSet12[0, 0]);
                var MonthConsumption = column12;
                monthconsumption = MonthConsumption;
            }


            todayconsumptioncost = todayconsumption * 752;
            todayconsumptioncost = todayconsumptioncost / 100 + 1608.4f;
            monthconsumptioncost = monthconsumption * 752;
            monthconsumptioncost = monthconsumptioncost / 100 + 1608.4f;




            if (monthconsumption < 99)
            {
                guagemax = 100;
            }
            else if (monthconsumption > 99 && monthconsumption < 999)
            {
                guagemax = 1000;
            }
            else if (monthconsumption > 999 && monthconsumption < 9999)
            {
                guagemax = 10000;
            }
            else if (monthconsumption > 9999 && monthconsumption < 99999)
            {
                guagemax = 100000;
            }
            else if (monthconsumption > 99999 && monthconsumption < 999999)
            {
                guagemax = 1000000;
            }
            else if (monthconsumption > 999999 && monthconsumption < 9999999)
            {
                guagemax = 1000000;
            }
            else if (monthconsumption > 9999999 && monthconsumption < 99999999)
            {
                guagemax = 100000000;
            }
        }
        buttonVariable.Value = button;
        todayConsumptionVariable.Value = todayconsumption;
        todayConsumptionCostVariable.Value = todayconsumptioncost;
        averageFrequencyVariable.Value = averageFrequency;
        avgPowerfactorVariable.Value = avgpowerfactor;
        monthConsumptionVariable.Value = monthconsumption;
        monthConsumptionCostVariable.Value = monthconsumptioncost;


    }


}
