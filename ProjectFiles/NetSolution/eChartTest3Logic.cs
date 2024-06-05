
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.MicroController;
using FTOptix.Retentivity;
using FTOptix.AuditSigning;
using FTOptix.Alarm;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using System.IO;
using FTOptix.OPCUAServer;
using System.Threading;
using System.Timers;

public class eChartTest3Logic : BaseNetLogic
{
    private System.Timers.Timer refreshTimer;
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        refreshTimer = new System.Timers.Timer(10000000); // 5000 milliseconds = 10 seconds

        refreshTimer.Elapsed += RefreshTimerElapsed; // Hook up the elapsed event
        refreshTimer.AutoReset = true; // Set the timer to repeat
        refreshTimer.Start();
        RefreshRadarGraph();

    }


    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        refreshTimer?.Stop();
    }

    // Method to handle refresh button click
    [ExportMethod]
    public void OnRefreshButtonClicked()
    {
        // Stop the timer if running
        Thread.Sleep(500);
        refreshTimer?.Stop();

        /* Start the timer for refresh
        refreshTimer.Interval = 1000; // 10 seconds
        refreshTimer.Elapsed += RefreshTimerElapsed; // Hook up the elapsed event
        refreshTimer.AutoReset = true; // Set the timer to repeat
        refreshTimer.Start();
        
        */ // Call RefreshRadarGraph immediately when button is clicked
        RefreshRadarGraph();
    }

    private void RefreshTimerElapsed(object sender, ElapsedEventArgs e)
    {
        // This method is called every 10 seconds by timer
        RefreshRadarGraph();
    }

    // Method to refresh radar graph
    private void RefreshRadarGraph()
    {
        Owner.Get<WebBrowser>("WebBrowser").Visible = false;
        Log.Debug("eCharts3", "Starting");
        String projectPath = (ResourceUri.FromProjectRelativePath("").Uri);
        String folderSeparator = Path.DirectorySeparatorChar.ToString();

        // Get template name and create destination path
        string templatePath = projectPath + folderSeparator + "eCharts3" + folderSeparator + "Template-data.js";
        string filePath = projectPath + folderSeparator + "eCharts3" + folderSeparator + "data.js";

        // Read template page content
        string text = File.ReadAllText(templatePath);

        // Insert values
        for (int i = 1; i < 32; i++)
        {
            text = text.Replace(i < 10 ? "$0" + i : "$" + i, (Project.Current.GetVariable("Model/eCharts/eCharts3/Day" + i).Value * 1.0).ToString("0.0"));
        }

        // Write to file
        File.WriteAllText(filePath, text);

        // Refresh WebBrowser page
        Owner.Get<WebBrowser>("WebBrowser").Refresh();
        Log.Debug("eCharts3", "Finished");
        Thread.Sleep(500);
        Owner.Get<WebBrowser>("WebBrowser").Visible = true;
    }
}
