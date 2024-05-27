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
public class EnergyPanelLogic : BaseNetLogic
{
    private IUAVariable buttonVariable;
    private IUAVariable meterVariable;
    private IUAVariable min1Variable;
    private IUAVariable min2Variable;
    private IUAVariable min3Variable;
    private IUAVariable min4Variable;
    private IUAVariable min5Variable;
    private IUAVariable min6Variable;
    private IUAVariable min7Variable;
    private IUAVariable min8Variable;
    private IUAVariable min9Variable;
    private IUAVariable min10Variable;
    private IUAVariable min11Variable;
    private IUAVariable min12Variable;
    private IUAVariable min13Variable;
    private IUAVariable min14Variable;
    private IUAVariable min15Variable;
    private IUAVariable min16Variable;
    private IUAVariable min17Variable;
    private IUAVariable min18Variable;
    private IUAVariable min19Variable;
    private IUAVariable min20Variable;
    private IUAVariable min21Variable;
    private IUAVariable min22Variable;
    private IUAVariable min23Variable;
    private IUAVariable min24Variable;
    private IUAVariable min25Variable;
    private IUAVariable min26Variable;
    private IUAVariable min27Variable;
    private IUAVariable min28Variable;
    private IUAVariable min29Variable;
    private IUAVariable min30Variable;
    private IUAVariable min31Variable;
    private IUAVariable min32Variable;
    private IUAVariable min33Variable;
    private IUAVariable min34Variable;
    private IUAVariable min35Variable;
    private IUAVariable min36Variable;
    private IUAVariable min37Variable;
    private IUAVariable min38Variable;
    private IUAVariable min39Variable;
    private IUAVariable min40Variable;
    private IUAVariable min41Variable;
    private IUAVariable min42Variable;
    private IUAVariable min43Variable;
    private IUAVariable min44Variable;
    private IUAVariable min45Variable;
    private IUAVariable min46Variable;
    private IUAVariable min47Variable;
    private IUAVariable min48Variable;
    private IUAVariable min49Variable;
    private IUAVariable min50Variable;
    private IUAVariable min51Variable;
    private IUAVariable min52Variable;
    private IUAVariable min53Variable;
    private IUAVariable min54Variable;
    private IUAVariable min55Variable;
    private IUAVariable min56Variable;
    private IUAVariable min57Variable;
    private IUAVariable min58Variable;
    private IUAVariable min59Variable;
    private IUAVariable min60Variable;
    private IUAVariable min61Variable;
    private IUAVariable min62Variable;
    private IUAVariable min63Variable;
    private IUAVariable min64Variable;
    private IUAVariable min65Variable;
    private IUAVariable min66Variable;
    private IUAVariable min67Variable;
    private IUAVariable min68Variable;
    private IUAVariable min69Variable;
    private IUAVariable min70Variable;
    private IUAVariable min71Variable;
    private IUAVariable min72Variable;
    private IUAVariable min73Variable;
    private IUAVariable min74Variable;
    private IUAVariable min75Variable;
    private IUAVariable min76Variable;
    private IUAVariable min77Variable;
    private IUAVariable min78Variable;
    private IUAVariable min79Variable;
    private IUAVariable min80Variable;
    private IUAVariable min81Variable;
    private IUAVariable min82Variable;
    private IUAVariable min83Variable;
    private IUAVariable min84Variable;
    private IUAVariable min85Variable;
    private IUAVariable min86Variable;
    private IUAVariable min87Variable;
    private IUAVariable min88Variable;
    private IUAVariable min89Variable;
    private IUAVariable min90Variable;
    private IUAVariable min91Variable;
    private IUAVariable min92Variable;
    private IUAVariable min93Variable;
    private IUAVariable min94Variable;
    private IUAVariable min95Variable;
    private IUAVariable min96Variable;
    private IUAVariable min97Variable;
    private IUAVariable min98Variable;
    private IUAVariable min99Variable;
    private IUAVariable min100Variable;
    private IUAVariable min101Variable;
    private IUAVariable min102Variable;
    private IUAVariable min103Variable;
    private IUAVariable min104Variable;
    private IUAVariable min105Variable;
    private IUAVariable min106Variable;
    private IUAVariable min107Variable;
    private IUAVariable min108Variable;
    private IUAVariable min109Variable;
    private IUAVariable min110Variable;
    private IUAVariable min111Variable;
    private IUAVariable min112Variable;
    private IUAVariable min113Variable;
    private IUAVariable min114Variable;
    private IUAVariable min115Variable;
    private IUAVariable min116Variable;
    private IUAVariable min117Variable;
    private IUAVariable min118Variable;
    private IUAVariable min119Variable;
    private IUAVariable min120Variable;
    private IUAVariable min121Variable;
    private IUAVariable min122Variable;
    private IUAVariable min123Variable;
    private IUAVariable min124Variable;
    private IUAVariable min125Variable;
    private IUAVariable min126Variable;
    private IUAVariable min127Variable;
    private IUAVariable min128Variable;
    private IUAVariable min129Variable;
    private IUAVariable min130Variable;
    private IUAVariable min131Variable;
    private IUAVariable min132Variable;
    private IUAVariable min133Variable;
    private IUAVariable min134Variable;
    private IUAVariable min135Variable;
    private IUAVariable min136Variable;
    private IUAVariable min137Variable;
    private IUAVariable min138Variable;
    private IUAVariable min139Variable;
    private IUAVariable min140Variable;
    private IUAVariable min141Variable;
    private IUAVariable min142Variable;
    private PeriodicTask periodicTask;
    private IUAVariable min143Variable;
    private IUAVariable min144Variable;

    public override void Start()
    {
        var owner = (EnergyPanelTags)LogicObject.Owner;
        buttonVariable = owner.ButtonVariable;
        meterVariable = owner.MeterVariable;
        min1Variable = owner.Min1Variable;
        min2Variable = owner.Min2Variable;
        min3Variable = owner.Min3Variable;
        min4Variable = owner.Min4Variable;
        min5Variable = owner.Min5Variable;
        min6Variable = owner.Min6Variable;
        min7Variable = owner.Min7Variable;
        min8Variable = owner.Min8Variable;
        min9Variable = owner.Min9Variable;
        min10Variable = owner.Min10Variable;
        min11Variable = owner.Min11Variable;
        min12Variable = owner.Min12Variable;
        min13Variable = owner.Min13Variable;
        min14Variable = owner.Min14Variable;
        min15Variable = owner.Min15Variable;
        min16Variable = owner.Min16Variable;
        min17Variable = owner.Min17Variable;
        min18Variable = owner.Min18Variable;
        min19Variable = owner.Min19Variable;
        min20Variable = owner.Min20Variable;
        min21Variable = owner.Min21Variable;
        min22Variable = owner.Min22Variable;
        min23Variable = owner.Min23Variable;
        min24Variable = owner.Min24Variable;
        min25Variable = owner.Min25Variable;
        min26Variable = owner.Min26Variable;
        min27Variable = owner.Min27Variable;
        min28Variable = owner.Min28Variable;
        min29Variable = owner.Min29Variable;
        min30Variable = owner.Min30Variable;
        min31Variable = owner.Min31Variable;
        min32Variable = owner.Min32Variable;
        min33Variable = owner.Min33Variable;
        min34Variable = owner.Min34Variable;
        min35Variable = owner.Min35Variable;
        min36Variable = owner.Min36Variable;
        min37Variable = owner.Min37Variable;
        min38Variable = owner.Min38Variable;
        min39Variable = owner.Min39Variable;
        min40Variable = owner.Min40Variable;
        min41Variable = owner.Min41Variable;
        min42Variable = owner.Min42Variable;
        min43Variable = owner.Min43Variable;
        min44Variable = owner.Min44Variable;
        min45Variable = owner.Min45Variable;
        min46Variable = owner.Min46Variable;
        min47Variable = owner.Min47Variable;
        min48Variable = owner.Min48Variable;
        min49Variable = owner.Min49Variable;
        min50Variable = owner.Min50Variable;
        min51Variable = owner.Min51Variable;
        min52Variable = owner.Min52Variable;
        min53Variable = owner.Min53Variable;
        min54Variable = owner.Min54Variable;
        min55Variable = owner.Min55Variable;
        min56Variable = owner.Min56Variable;
        min57Variable = owner.Min5Variable;
        min58Variable = owner.Min58Variable;
        min59Variable = owner.Min59Variable;
        min60Variable = owner.Min60Variable;
        min61Variable = owner.Min61Variable;
        min62Variable = owner.Min62Variable;
        min63Variable = owner.Min63Variable;
        min64Variable = owner.Min64Variable;
        min65Variable = owner.Min65Variable;
        min66Variable = owner.Min66Variable;
        min67Variable = owner.Min67Variable;
        min68Variable = owner.Min68Variable;
        min69Variable = owner.Min69Variable;
        min70Variable = owner.Min70Variable;
        min71Variable = owner.Min71Variable;
        min72Variable = owner.Min72Variable;
        min73Variable = owner.Min73Variable;
        min74Variable = owner.Min74Variable;
        min75Variable = owner.Min75Variable;
        min76Variable = owner.Min76Variable;
        min77Variable = owner.Min77Variable;
        min78Variable = owner.Min78Variable;
        min79Variable = owner.Min79Variable;
        min80Variable = owner.Min80Variable;
        min81Variable = owner.Min81Variable;
        min82Variable = owner.Min82Variable;
        min83Variable = owner.Min83Variable;
        min84Variable = owner.Min84Variable;
        min85Variable = owner.Min85Variable;
        min86Variable = owner.Min86Variable;
        min87Variable = owner.Min87Variable;
        min88Variable = owner.Min88Variable;
        min89Variable = owner.Min89Variable;
        min90Variable = owner.Min90Variable;
        min91Variable = owner.Min91Variable;
        min92Variable = owner.Min92Variable;
        min93Variable = owner.Min93Variable;
        min94Variable = owner.Min94Variable;
        min95Variable = owner.Min95Variable;
        min96Variable = owner.Min96Variable;
        min97Variable = owner.Min97Variable;
        min98Variable = owner.Min98Variable;
        min99Variable = owner.Min99Variable;
        min100Variable = owner.Min100Variable;
        min101Variable = owner.Min101Variable;
        min102Variable = owner.Min102Variable;
        min103Variable = owner.Min103Variable;
        min104Variable = owner.Min104Variable;
        min105Variable = owner.Min105Variable;
        min106Variable = owner.Min106Variable;
        min107Variable = owner.Min107Variable;
        min108Variable = owner.Min108Variable;
        min109Variable = owner.Min109Variable;
        min110Variable = owner.Min110Variable;
        min111Variable = owner.Min111Variable;
        min112Variable = owner.Min112Variable;
        min113Variable = owner.Min113Variable;
        min114Variable = owner.Min114Variable;
        min115Variable = owner.Min115Variable;
        min116Variable = owner.Min116Variable;
        min117Variable = owner.Min117Variable;
        min118Variable = owner.Min118Variable;
        min119Variable = owner.Min119Variable;
        min120Variable = owner.Min120Variable;
        min121Variable = owner.Min121Variable;
        min122Variable = owner.Min122Variable;
        min123Variable = owner.Min123Variable;
        min124Variable = owner.Min124Variable;
        min125Variable = owner.Min125Variable;
        min126Variable = owner.Min126Variable;
        min127Variable = owner.Min127Variable;
        min128Variable = owner.Min128Variable;
        min129Variable = owner.Min129Variable;
        min130Variable = owner.Min130Variable;
        min131Variable = owner.Min131Variable;
        min132Variable = owner.Min132Variable;
        min133Variable = owner.Min133Variable;
        min134Variable = owner.Min134Variable;
        min135Variable = owner.Min135Variable;
        min136Variable = owner.Min136Variable;
        min137Variable = owner.Min137Variable;
        min138Variable = owner.Min138Variable;
        min139Variable = owner.Min139Variable;
        min140Variable = owner.Min140Variable;
        min141Variable = owner.Min141Variable;
        min142Variable = owner.Min142Variable;
        min143Variable = owner.Min143Variable;
        min144Variable = owner.Min144Variable;


        periodicTask = new PeriodicTask(CurrentPanelTagsCalculation, 5000, LogicObject);
        periodicTask.Start();

        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        periodicTask.Dispose();
        periodicTask = null;// Insert code to be executed when the user-defined logic is stopped
    }
    public void CurrentPanelTagsCalculation()
    {

        string meter = meterVariable.Value;
        float min1 = min1Variable.Value;
        float min2 = min2Variable.Value;
        float min3 = min3Variable.Value;
        float min4 = min4Variable.Value;
        float min5 = min5Variable.Value;
        float min6 = min6Variable.Value;
        float min7 = min7Variable.Value;
        float min8 = min8Variable.Value;
        float min9 = min9Variable.Value;
        float min10 = min10Variable.Value;
        float min11 = min11Variable.Value;
        float min12 = min12Variable.Value;
        float min13 = min13Variable.Value;
        float min14 = min14Variable.Value;
        float min15 = min15Variable.Value;
        float min16 = min16Variable.Value;
        float min17 = min17Variable.Value;
        float min18 = min18Variable.Value;
        float min19 = min19Variable.Value;
        float min20 = min20Variable.Value;
        float min21 = min21Variable.Value;
        float min22 = min22Variable.Value;
        float min23 = min23Variable.Value;
        float min24 = min24Variable.Value;
        float min25 = min25Variable.Value;
        float min26 = min26Variable.Value;
        float min27 = min27Variable.Value;
        float min28 = min28Variable.Value;
        float min29 = min29Variable.Value;
        float min30 = min30Variable.Value;
        float min31 = min31Variable.Value;
        float min32 = min32Variable.Value;
        float min33 = min33Variable.Value;
        float min34 = min34Variable.Value;
        float min35 = min35Variable.Value;
        float min36 = min36Variable.Value;
        float min37 = min37Variable.Value;
        float min38 = min38Variable.Value;
        float min39 = min39Variable.Value;
        float min40 = min40Variable.Value;
        float min41 = min41Variable.Value;
        float min42 = min42Variable.Value;
        float min43 = min43Variable.Value;
        float min44 = min44Variable.Value;
        float min45 = min45Variable.Value;
        float min46 = min46Variable.Value;
        float min47 = min47Variable.Value;
        float min48 = min48Variable.Value;
        float min49 = min49Variable.Value;
        float min50 = min50Variable.Value;
        float min51 = min51Variable.Value;
        float min52 = min52Variable.Value;
        float min53 = min53Variable.Value;
        float min54 = min54Variable.Value;
        float min55 = min55Variable.Value;
        float min56 = min56Variable.Value;
        float min57 = min57Variable.Value;
        float min58 = min58Variable.Value;
        float min59 = min59Variable.Value;
        float min60 = min60Variable.Value;
        float min61 = min61Variable.Value;
        float min62 = min62Variable.Value;
        float min63 = min63Variable.Value;
        float min64 = min64Variable.Value;
        float min65 = min65Variable.Value;
        float min66 = min66Variable.Value;
        float min67 = min67Variable.Value;
        float min68 = min68Variable.Value;
        float min69 = min69Variable.Value;
        float min70 = min70Variable.Value;
        float min71 = min71Variable.Value;
        float min72 = min72Variable.Value;
        float min73 = min73Variable.Value;
        float min74 = min74Variable.Value;
        float min75 = min75Variable.Value;
        float min76 = min76Variable.Value;
        float min77 = min77Variable.Value;
        float min78 = min78Variable.Value;
        float min79 = min79Variable.Value;
        float min80 = min80Variable.Value;
        float min81 = min81Variable.Value;
        float min82 = min82Variable.Value;
        float min83 = min83Variable.Value;
        float min84 = min84Variable.Value;
        float min85 = min85Variable.Value;
        float min86 = min86Variable.Value;
        float min87 = min87Variable.Value;
        float min88 = min88Variable.Value;
        float min89 = min89Variable.Value;
        float min90 = min90Variable.Value;
        float min91 = min91Variable.Value;
        float min92 = min92Variable.Value;
        float min93 = min93Variable.Value;
        float min94 = min94Variable.Value;
        float min95 = min95Variable.Value;
        float min96 = min96Variable.Value;
        float min97 = min97Variable.Value;
        float min98 = min98Variable.Value;
        float min99 = min99Variable.Value;
        float min100 = min100Variable.Value;
        float min101 = min101Variable.Value;
        float min102 = min102Variable.Value;
        float min103 = min103Variable.Value;
        float min104 = min104Variable.Value;
        float min105 = min105Variable.Value;
        float min106 = min106Variable.Value;
        float min107 = min107Variable.Value;
        float min108 = min108Variable.Value;
        float min109 = min109Variable.Value;
        float min110 = min110Variable.Value;
        float min111 = min111Variable.Value;
        float min112 = min112Variable.Value;
        float min113 = min113Variable.Value;
        float min114 = min114Variable.Value;
        float min115 = min115Variable.Value;
        float min116 = min116Variable.Value;
        float min117 = min117Variable.Value;
        float min118 = min118Variable.Value;
        float min119 = min119Variable.Value;
        float min120 = min120Variable.Value;
        float min121 = min121Variable.Value;
        float min122 = min122Variable.Value;
        float min123 = min123Variable.Value;
        float min124 = min124Variable.Value;
        float min125 = min125Variable.Value;
        float min126 = min126Variable.Value;
        float min127 = min127Variable.Value;
        float min128 = min128Variable.Value;
        float min129 = min129Variable.Value;
        float min130 = min130Variable.Value;
        float min131 = min131Variable.Value;
        float min132 = min132Variable.Value;
        float min133 = min133Variable.Value;
        float min134 = min134Variable.Value;
        float min135 = min135Variable.Value;
        float min136 = min136Variable.Value;
        float min137 = min137Variable.Value;
        float min138 = min138Variable.Value;
        float min139 = min139Variable.Value;
        float min140 = min140Variable.Value;
        float min141 = min141Variable.Value;
        float min142 = min142Variable.Value;
        float min143 = min143Variable.Value;
        float min144 = min144Variable.Value;


        bool button = buttonVariable.Value;

        var project = FTOptix.HMIProject.Project.Current;
        var myStore1 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore2 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore3 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore4 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore5 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore6 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore7 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore8 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore9 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore10 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore11 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore12 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore13 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore14 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore15 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore16 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore17 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore18 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore19 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore20 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore21 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore22 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore23 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore24 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore25 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore26 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore27 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore28 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore29 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore30 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore31 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore32 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore33 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore34 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore35 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore36 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore37 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore38 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore39 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore40 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore41 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore42 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore43 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore44 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore45 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore46 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore47 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore48 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore49 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore50 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore51 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore52 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore53 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore54 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore55 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore56 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore57 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore58 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore59 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore60 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore61 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore62 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore63 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore64 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore65 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore66 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore67 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore68 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore69 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore70 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore71 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore72 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore73 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore74 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore75 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore76 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore77 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore78 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore79 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore80 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore81 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore82 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore83 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore84 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore85 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore86 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore87 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore88 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore89 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore90 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore91 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore92 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore93 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore94 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore95 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore96 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore97 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore98 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore99 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore100 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore101 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore102 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore103 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore104 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore105 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore106 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore107 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore108 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore109 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore110 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore111 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore112 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore113 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore114 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore115 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore116 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore117 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore118 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore119 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore120 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore121 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore122 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore123 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore124 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore125 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore126 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore127 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore128 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore129 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore130 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore131 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore132 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore133 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore134 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore135 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore136 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore137 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore138 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore139 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore140 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore141 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore142 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore143 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        var myStore144 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");
        // var myStore145 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase145");



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

        object[,] resultSet11;
        string[] header11;

        object[,] resultSet12;
        string[] header12;

        object[,] resultSet13;
        string[] header13;

        object[,] resultSet14;
        string[] header14;

        object[,] resultSet15;
        string[] header15;

        object[,] resultSet16;
        string[] header16;

        object[,] resultSet17;
        string[] header17;

        object[,] resultSet18;
        string[] header18;

        object[,] resultSet19;
        string[] header19;

        object[,] resultSet20;
        string[] header20;

        object[,] resultSet21;
        string[] header21;

        object[,] resultSet22;
        string[] header22;

        object[,] resultSet23;
        string[] header23;

        object[,] resultSet24;
        string[] header24;

        object[,] resultSet25;
        string[] header25;

        object[,] resultSet26;
        string[] header26;

        object[,] resultSet27;
        string[] header27;

        object[,] resultSet28;
        string[] header28;

        object[,] resultSet29;
        string[] header29;

        object[,] resultSet30;
        string[] header30;

        object[,] resultSet31;
        string[] header31;

        object[,] resultSet32;
        string[] header32;

        object[,] resultSet33;
        string[] header33;

        object[,] resultSet34;
        string[] header34;

        object[,] resultSet35;
        string[] header35;

        object[,] resultSet36;
        string[] header36;

        object[,] resultSet37;
        string[] header37;

        object[,] resultSet38;
        string[] header38;

        object[,] resultSet39;
        string[] header39;

        object[,] resultSet40;
        string[] header40;

        object[,] resultSet41;
        string[] header41;

        object[,] resultSet42;
        string[] header42;

        object[,] resultSet43;
        string[] header43;

        object[,] resultSet44;
        string[] header44;

        object[,] resultSet45;
        string[] header45;

        object[,] resultSet46;
        string[] header46;

        object[,] resultSet47;
        string[] header47;

        object[,] resultSet48;
        string[] header48;

        object[,] resultSet49;
        string[] header49;

        object[,] resultSet50;
        string[] header50;

        object[,] resultSet51;
        string[] header51;

        object[,] resultSet52;
        string[] header52;

        object[,] resultSet53;
        string[] header53;

        object[,] resultSet54;
        string[] header54;

        object[,] resultSet55;
        string[] header55;

        object[,] resultSet56;
        string[] header56;

        object[,] resultSet57;
        string[] header57;

        object[,] resultSet58;
        string[] header58;

        object[,] resultSet59;
        string[] header59;

        object[,] resultSet60;
        string[] header60;

        object[,] resultSet61;
        string[] header61;

        object[,] resultSet62;
        string[] header62;

        object[,] resultSet63;
        string[] header63;

        object[,] resultSet64;
        string[] header64;

        object[,] resultSet65;
        string[] header65;

        object[,] resultSet66;
        string[] header66;

        object[,] resultSet67;
        string[] header67;

        object[,] resultSet68;
        string[] header68;

        object[,] resultSet69;
        string[] header69;

        object[,] resultSet70;
        string[] header70;

        object[,] resultSet71;
        string[] header71;

        object[,] resultSet72;
        string[] header72;

        object[,] resultSet73;
        string[] header73;

        object[,] resultSet74;
        string[] header74;

        object[,] resultSet75;
        string[] header75;

        object[,] resultSet76;
        string[] header76;

        object[,] resultSet77;
        string[] header77;

        object[,] resultSet78;
        string[] header78;

        object[,] resultSet79;
        string[] header79;

        object[,] resultSet80;
        string[] header80;

        object[,] resultSet81;
        string[] header81;

        object[,] resultSet82;
        string[] header82;

        object[,] resultSet83;
        string[] header83;

        object[,] resultSet84;
        string[] header84;

        object[,] resultSet85;
        string[] header85;

        object[,] resultSet86;
        string[] header86;

        object[,] resultSet87;
        string[] header87;

        object[,] resultSet88;
        string[] header88;

        object[,] resultSet89;
        string[] header89;

        object[,] resultSet90;
        string[] header90;

        object[,] resultSet91;
        string[] header91;

        object[,] resultSet92;
        string[] header92;

        object[,] resultSet93;
        string[] header93;

        object[,] resultSet94;
        string[] header94;

        object[,] resultSet95;
        string[] header95;

        object[,] resultSet96;
        string[] header96;

        object[,] resultSet97;
        string[] header97;

        object[,] resultSet98;
        string[] header98;

        object[,] resultSet99;
        string[] header99;

        object[,] resultSet100;
        string[] header100;

        object[,] resultSet101;
        string[] header101;

        object[,] resultSet102;
        string[] header102;

        object[,] resultSet103;
        string[] header103;

        object[,] resultSet104;
        string[] header104;

        object[,] resultSet105;
        string[] header105;

        object[,] resultSet106;
        string[] header106;

        object[,] resultSet107;
        string[] header107;

        object[,] resultSet108;
        string[] header108;

        object[,] resultSet109;
        string[] header109;

        object[,] resultSet110;
        string[] header110;

        object[,] resultSet111;
        string[] header111;

        object[,] resultSet112;
        string[] header112;

        object[,] resultSet113;
        string[] header113;

        object[,] resultSet114;
        string[] header114;

        object[,] resultSet115;
        string[] header115;

        object[,] resultSet116;
        string[] header116;

        object[,] resultSet117;
        string[] header117;

        object[,] resultSet118;
        string[] header118;

        object[,] resultSet119;
        string[] header119;

        object[,] resultSet120;
        string[] header120;

        object[,] resultSet121;
        string[] header121;

        object[,] resultSet122;
        string[] header122;

        object[,] resultSet123;
        string[] header123;

        object[,] resultSet124;
        string[] header124;

        object[,] resultSet125;
        string[] header125;

        object[,] resultSet126;
        string[] header126;

        object[,] resultSet127;
        string[] header127;

        object[,] resultSet128;
        string[] header128;

        object[,] resultSet129;
        string[] header129;

        object[,] resultSet130;
        string[] header130;

        object[,] resultSet131;
        string[] header131;

        object[,] resultSet132;
        string[] header132;

        object[,] resultSet133;
        string[] header133;

        object[,] resultSet134;
        string[] header134;

        object[,] resultSet135;
        string[] header135;

        object[,] resultSet136;
        string[] header136;

        object[,] resultSet137;
        string[] header137;

        object[,] resultSet138;
        string[] header138;

        object[,] resultSet139;
        string[] header139;

        object[,] resultSet140;
        string[] header140;

        object[,] resultSet141;
        string[] header141;

        object[,] resultSet142;
        string[] header142;

        object[,] resultSet143;
        string[] header143;

        object[,] resultSet144;
        string[] header144;






        if (button == true)
        {
            DateTime currentTime = DateTime.Now;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            // Calculate start and end times for the current day
            DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
            DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 59, 59).AddDays(1);

            string new123 = startTime.ToString("yyyy-MM-dd");
            string new12 = startTime.ToString("yyyy-MM");
            string new1 = startTime.ToString("dd");
            string meter1 = meter.ToString();



            string query1 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:00:00' AND '" + currentDate + " 00:09:59' AND Meter = '" + meter1 + "' ";
            string query2 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:10:00' AND '" + currentDate + " 00:19:59' AND Meter = '" + meter1 + "' ";
            string query3 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:20:00' AND '" + currentDate + " 00:29:59' AND Meter = '" + meter1 + "' ";
            string query4 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:30:00' AND '" + currentDate + " 00:39:59' AND Meter = '" + meter1 + "' ";
            string query5 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:40:00' AND '" + currentDate + " 00:49:59' AND Meter = '" + meter1 + "' ";
            string query6 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 00:50:00' AND '" + currentDate + " 00:59:59' AND Meter = '" + meter1 + "' ";
            string query7 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:00:00' AND '" + currentDate + " 01:09:59' AND Meter = '" + meter1 + "' ";
            string query8 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:10:00' AND '" + currentDate + " 01:19:59' AND Meter = '" + meter1 + "' ";
            string query9 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:20:00' AND '" + currentDate + " 01:29:59' AND Meter = '" + meter1 + "' ";
            string query10 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:30:00' AND '" + currentDate + " 01:39:59' AND Meter = '" + meter1 + "' ";
            string query11 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:40:00' AND '" + currentDate + " 01:49:59' AND Meter = '" + meter1 + "' ";
            string query12 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 01:50:00' AND '" + currentDate + " 01:59:59' AND Meter = '" + meter1 + "' ";
            string query13 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:00:00' AND '" + currentDate + " 02:09:59' AND Meter = '" + meter1 + "' ";
            string query14 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:10:00' AND '" + currentDate + " 02:19:59' AND Meter = '" + meter1 + "' ";
            string query15 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:20:00' AND '" + currentDate + " 02:29:59' AND Meter = '" + meter1 + "' ";
            string query16 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:30:00' AND '" + currentDate + " 02:39:59' AND Meter = '" + meter1 + "' ";
            string query17 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:40:00' AND '" + currentDate + " 02:49:59' AND Meter = '" + meter1 + "' ";
            string query18 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 02:50:00' AND '" + currentDate + " 02:59:59' AND Meter = '" + meter1 + "' ";
            string query19 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:00:00' AND '" + currentDate + " 03:09:59' AND Meter = '" + meter1 + "' ";
            string query20 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:10:00' AND '" + currentDate + " 03:19:59' AND Meter = '" + meter1 + "' ";
            string query21 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:20:00' AND '" + currentDate + " 03:29:59' AND Meter = '" + meter1 + "' ";
            string query22 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:30:00' AND '" + currentDate + " 03:39:59' AND Meter = '" + meter1 + "' ";
            string query23 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:40:00' AND '" + currentDate + " 03:49:59' AND Meter = '" + meter1 + "' ";
            string query24 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 03:50:00' AND '" + currentDate + " 03:59:59' AND Meter = '" + meter1 + "' ";
            string query25 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:00:00' AND '" + currentDate + " 04:09:59' AND Meter = '" + meter1 + "' ";
            string query26 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:10:00' AND '" + currentDate + " 04:19:59' AND Meter = '" + meter1 + "' ";
            string query27 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:20:00' AND '" + currentDate + " 04:29:59' AND Meter = '" + meter1 + "' ";
            string query28 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:30:00' AND '" + currentDate + " 04:39:59' AND Meter = '" + meter1 + "' ";
            string query29 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:40:00' AND '" + currentDate + " 04:49:59' AND Meter = '" + meter1 + "' ";
            string query30 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 04:50:00' AND '" + currentDate + " 04:59:59' AND Meter = '" + meter1 + "' ";
            string query31 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:00:00' AND '" + currentDate + " 05:09:59' AND Meter = '" + meter1 + "' ";
            string query32 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:10:00' AND '" + currentDate + " 05:19:59' AND Meter = '" + meter1 + "' ";
            string query33 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:20:00' AND '" + currentDate + " 05:29:59' AND Meter = '" + meter1 + "' ";
            string query34 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:30:00' AND '" + currentDate + " 05:39:59' AND Meter = '" + meter1 + "' ";
            string query35 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:40:00' AND '" + currentDate + " 05:49:59' AND Meter = '" + meter1 + "' ";
            string query36 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 05:50:00' AND '" + currentDate + " 05:59:59' AND Meter = '" + meter1 + "' ";
            string query37 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:00:00' AND '" + currentDate + " 06:09:59' AND Meter = '" + meter1 + "' ";
            string query38 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:10:00' AND '" + currentDate + " 06:19:59' AND Meter = '" + meter1 + "' ";
            string query39 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:20:00' AND '" + currentDate + " 06:29:59' AND Meter = '" + meter1 + "' ";
            string query40 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:30:00' AND '" + currentDate + " 06:39:59' AND Meter = '" + meter1 + "' ";
            string query41 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:40:00' AND '" + currentDate + " 06:49:59' AND Meter = '" + meter1 + "' ";
            string query42 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 06:50:00' AND '" + currentDate + " 06:59:59' AND Meter = '" + meter1 + "' ";
            string query43 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:00:00' AND '" + currentDate + " 07:09:59' AND Meter = '" + meter1 + "' ";
            string query44 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:10:00' AND '" + currentDate + " 07:19:59' AND Meter = '" + meter1 + "' ";
            string query45 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:20:00' AND '" + currentDate + " 07:29:59' AND Meter = '" + meter1 + "' ";
            string query46 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:30:00' AND '" + currentDate + " 07:39:59' AND Meter = '" + meter1 + "' ";
            string query47 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:40:00' AND '" + currentDate + " 07:49:59' AND Meter = '" + meter1 + "' ";
            string query48 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 07:50:00' AND '" + currentDate + " 07:59:59' AND Meter = '" + meter1 + "' ";
            string query49 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:00:00' AND '" + currentDate + " 08:09:59' AND Meter = '" + meter1 + "' ";
            string query50 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:10:00' AND '" + currentDate + " 08:19:59' AND Meter = '" + meter1 + "' ";
            string query51 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:20:00' AND '" + currentDate + " 08:29:59' AND Meter = '" + meter1 + "' ";
            string query52 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:30:00' AND '" + currentDate + " 08:39:59' AND Meter = '" + meter1 + "' ";
            string query53 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:40:00' AND '" + currentDate + " 08:49:59' AND Meter = '" + meter1 + "' ";
            string query54 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 08:50:00' AND '" + currentDate + " 08:59:59' AND Meter = '" + meter1 + "' ";
            string query55 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:00:00' AND '" + currentDate + " 09:09:59' AND Meter = '" + meter1 + "' ";
            string query56 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:10:00' AND '" + currentDate + " 09:19:59' AND Meter = '" + meter1 + "' ";
            string query57 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:20:00' AND '" + currentDate + " 09:29:59' AND Meter = '" + meter1 + "' ";
            string query58 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:30:00' AND '" + currentDate + " 09:39:59' AND Meter = '" + meter1 + "' ";
            string query59 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:40:00' AND '" + currentDate + " 09:49:59' AND Meter = '" + meter1 + "' ";
            string query60 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 09:50:00' AND '" + currentDate + " 09:59:59' AND Meter = '" + meter1 + "' ";
            string query61 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:00:00' AND '" + currentDate + " 10:09:59' AND Meter = '" + meter1 + "' ";
            string query62 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:10:00' AND '" + currentDate + " 10:19:59' AND Meter = '" + meter1 + "' ";
            string query63 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:20:00' AND '" + currentDate + " 10:29:59' AND Meter = '" + meter1 + "' ";
            string query64 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:30:00' AND '" + currentDate + " 10:39:59' AND Meter = '" + meter1 + "' ";
            string query65 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:40:00' AND '" + currentDate + " 10:49:59' AND Meter = '" + meter1 + "' ";
            string query66 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 10:50:00' AND '" + currentDate + " 10:59:59' AND Meter = '" + meter1 + "' ";
            string query67 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:00:00' AND '" + currentDate + " 11:09:59' AND Meter = '" + meter1 + "' ";
            string query68 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:10:00' AND '" + currentDate + " 11:19:59' AND Meter = '" + meter1 + "' ";
            string query69 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:20:00' AND '" + currentDate + " 11:29:59' AND Meter = '" + meter1 + "' ";
            string query70 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:30:00' AND '" + currentDate + " 11:39:59' AND Meter = '" + meter1 + "' ";
            string query71 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:40:00' AND '" + currentDate + " 11:49:59' AND Meter = '" + meter1 + "' ";
            string query72 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 11:50:00' AND '" + currentDate + " 11:59:59' AND Meter = '" + meter1 + "' ";
            string query73 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:00:00' AND '" + currentDate + " 12:09:59' AND Meter = '" + meter1 + "' ";
            string query74 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:10:00' AND '" + currentDate + " 12:19:59' AND Meter = '" + meter1 + "' ";
            string query75 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:20:00' AND '" + currentDate + " 12:29:59' AND Meter = '" + meter1 + "' ";
            string query76 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:30:00' AND '" + currentDate + " 12:39:59' AND Meter = '" + meter1 + "' ";
            string query77 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:40:00' AND '" + currentDate + " 12:49:59' AND Meter = '" + meter1 + "' ";
            string query78 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 12:50:00' AND '" + currentDate + " 12:59:59' AND Meter = '" + meter1 + "' ";
            string query79 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:00:00' AND '" + currentDate + " 13:09:59' AND Meter = '" + meter1 + "' ";
            string query80 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:10:00' AND '" + currentDate + " 13:19:59' AND Meter = '" + meter1 + "' ";
            string query81 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:20:00' AND '" + currentDate + " 13:29:59' AND Meter = '" + meter1 + "' ";
            string query82 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:30:00' AND '" + currentDate + " 13:39:59' AND Meter = '" + meter1 + "' ";
            string query83 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:40:00' AND '" + currentDate + " 13:49:59' AND Meter = '" + meter1 + "' ";
            string query84 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 13:50:00' AND '" + currentDate + " 13:59:59' AND Meter = '" + meter1 + "' ";
            string query85 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:00:00' AND '" + currentDate + " 14:09:59' AND Meter = '" + meter1 + "' ";
            string query86 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:10:00' AND '" + currentDate + " 14:19:59' AND Meter = '" + meter1 + "' ";
            string query87 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:20:00' AND '" + currentDate + " 14:29:59' AND Meter = '" + meter1 + "' ";
            string query88 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:30:00' AND '" + currentDate + " 14:39:59' AND Meter = '" + meter1 + "' ";
            string query89 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:40:00' AND '" + currentDate + " 14:49:59' AND Meter = '" + meter1 + "' ";
            string query90 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 14:50:00' AND '" + currentDate + " 14:59:59' AND Meter = '" + meter1 + "' ";
            string query91 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:00:00' AND '" + currentDate + " 15:09:59' AND Meter = '" + meter1 + "' ";
            string query92 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:10:00' AND '" + currentDate + " 15:19:59' AND Meter = '" + meter1 + "' ";
            string query93 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:20:00' AND '" + currentDate + " 15:29:59' AND Meter = '" + meter1 + "' ";
            string query94 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:30:00' AND '" + currentDate + " 15:39:59' AND Meter = '" + meter1 + "' ";
            string query95 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:40:00' AND '" + currentDate + " 15:49:59' AND Meter = '" + meter1 + "' ";
            string query96 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 15:50:00' AND '" + currentDate + " 15:59:59' AND Meter = '" + meter1 + "' ";
            string query97 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:00:00' AND '" + currentDate + " 16:09:59' AND Meter = '" + meter1 + "' ";
            string query98 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:10:00' AND '" + currentDate + " 16:19:59' AND Meter = '" + meter1 + "' ";
            string query99 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:20:00' AND '" + currentDate + " 16:29:59' AND Meter = '" + meter1 + "' ";
            string query100 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:30:00' AND '" + currentDate + " 16:39:59' AND Meter = '" + meter1 + "' ";
            string query101 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:40:00' AND '" + currentDate + " 16:49:59' AND Meter = '" + meter1 + "' ";
            string query102 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 16:50:00' AND '" + currentDate + " 16:59:59' AND Meter = '" + meter1 + "' ";
            string query103 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:00:00' AND '" + currentDate + " 17:09:59' AND Meter = '" + meter1 + "' ";
            string query104 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:10:00' AND '" + currentDate + " 17:19:59' AND Meter = '" + meter1 + "' ";
            string query105 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:20:00' AND '" + currentDate + " 17:29:59' AND Meter = '" + meter1 + "' ";
            string query106 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:30:00' AND '" + currentDate + " 17:39:59' AND Meter = '" + meter1 + "' ";
            string query107 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:40:00' AND '" + currentDate + " 17:49:59' AND Meter = '" + meter1 + "' ";
            string query108 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 17:50:00' AND '" + currentDate + " 17:59:59' AND Meter = '" + meter1 + "' ";
            string query109 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:00:00' AND '" + currentDate + " 18:09:59' AND Meter = '" + meter1 + "' ";
            string query110 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:10:00' AND '" + currentDate + " 18:19:59' AND Meter = '" + meter1 + "' ";
            string query111 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:20:00' AND '" + currentDate + " 18:29:59' AND Meter = '" + meter1 + "' ";
            string query112 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:30:00' AND '" + currentDate + " 18:39:59' AND Meter = '" + meter1 + "' ";
            string query113 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:40:00' AND '" + currentDate + " 18:49:59' AND Meter = '" + meter1 + "' ";
            string query114 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 18:50:00' AND '" + currentDate + " 18:59:59' AND Meter = '" + meter1 + "' ";
            string query115 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:00:00' AND '" + currentDate + " 19:09:59' AND Meter = '" + meter1 + "' ";
            string query116 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:10:00' AND '" + currentDate + " 19:19:59' AND Meter = '" + meter1 + "' ";
            string query117 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:20:00' AND '" + currentDate + " 19:29:59' AND Meter = '" + meter1 + "' ";
            string query118 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:30:00' AND '" + currentDate + " 19:39:59' AND Meter = '" + meter1 + "' ";
            string query119 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:40:00' AND '" + currentDate + " 19:49:59' AND Meter = '" + meter1 + "' ";
            string query120 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 19:50:00' AND '" + currentDate + " 19:59:59' AND Meter = '" + meter1 + "' ";
            string query121 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:00:00' AND '" + currentDate + " 20:09:59' AND Meter = '" + meter1 + "' ";
            string query122 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:10:00' AND '" + currentDate + " 20:19:59' AND Meter = '" + meter1 + "' ";
            string query123 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:20:00' AND '" + currentDate + " 20:29:59' AND Meter = '" + meter1 + "' ";
            string query124 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:30:00' AND '" + currentDate + " 20:39:59' AND Meter = '" + meter1 + "' ";
            string query125 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:40:00' AND '" + currentDate + " 20:49:59' AND Meter = '" + meter1 + "' ";
            string query126 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 20:50:00' AND '" + currentDate + " 20:59:59' AND Meter = '" + meter1 + "' ";
            string query127 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:00:00' AND '" + currentDate + " 21:09:59' AND Meter = '" + meter1 + "' ";
            string query128 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:10:00' AND '" + currentDate + " 21:19:59' AND Meter = '" + meter1 + "' ";
            string query129 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:20:00' AND '" + currentDate + " 21:29:59' AND Meter = '" + meter1 + "' ";
            string query130 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:30:00' AND '" + currentDate + " 21:39:59' AND Meter = '" + meter1 + "' ";
            string query131 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:40:00' AND '" + currentDate + " 21:49:59' AND Meter = '" + meter1 + "' ";
            string query132 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 21:50:00' AND '" + currentDate + " 21:59:59' AND Meter = '" + meter1 + "' ";
            string query133 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:00:00' AND '" + currentDate + " 22:09:59' AND Meter = '" + meter1 + "' ";
            string query134 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:10:00' AND '" + currentDate + " 22:19:59' AND Meter = '" + meter1 + "' ";
            string query135 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:20:00' AND '" + currentDate + " 22:29:59' AND Meter = '" + meter1 + "' ";
            string query136 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:30:00' AND '" + currentDate + " 22:39:59' AND Meter = '" + meter1 + "' ";
            string query137 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:40:00' AND '" + currentDate + " 22:49:59' AND Meter = '" + meter1 + "' ";
            string query138 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 22:50:00' AND '" + currentDate + " 22:59:59' AND Meter = '" + meter1 + "' ";
            string query139 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:00:00' AND '" + currentDate + " 23:09:59' AND Meter = '" + meter1 + "' ";
            string query140 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:10:00' AND '" + currentDate + " 23:19:59' AND Meter = '" + meter1 + "' ";
            string query141 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:20:00' AND '" + currentDate + " 23:29:59' AND Meter = '" + meter1 + "' ";
            string query142 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:30:00' AND '" + currentDate + " 23:39:59' AND Meter = '" + meter1 + "' ";
            string query143 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:40:00' AND '" + currentDate + " 23:49:59' AND Meter = '" + meter1 + "' ";
            string query144 = $"SELECT AVG(Active_Energy_Total) FROM HomePage WHERE LocalTimestamp BETWEEN '" + currentDate + " 23:50:00' AND '" + currentDate + " 23:59:59' AND Meter = '" + meter1 + "' ";


            myStore1.Query(query1, out header1, out resultSet1);
            myStore2.Query(query2, out header2, out resultSet2);
            myStore3.Query(query3, out header3, out resultSet3);
            myStore4.Query(query4, out header4, out resultSet4);
            myStore5.Query(query5, out header5, out resultSet5);
            myStore6.Query(query6, out header6, out resultSet6);
            myStore7.Query(query7, out header7, out resultSet7);
            myStore8.Query(query8, out header8, out resultSet8);
            myStore9.Query(query9, out header9, out resultSet9);
            myStore10.Query(query10, out header10, out resultSet10);
            myStore11.Query(query11, out header11, out resultSet11);
            myStore12.Query(query12, out header12, out resultSet12);
            myStore13.Query(query13, out header13, out resultSet13);
            myStore14.Query(query14, out header14, out resultSet14);
            myStore15.Query(query15, out header15, out resultSet15);
            myStore16.Query(query16, out header16, out resultSet16);
            myStore17.Query(query17, out header17, out resultSet17);
            myStore18.Query(query18, out header18, out resultSet18);
            myStore19.Query(query19, out header19, out resultSet19);
            myStore20.Query(query20, out header20, out resultSet20);
            myStore21.Query(query21, out header21, out resultSet21);
            myStore22.Query(query22, out header22, out resultSet22);
            myStore23.Query(query23, out header23, out resultSet23);
            myStore24.Query(query24, out header24, out resultSet24);
            myStore25.Query(query25, out header25, out resultSet25);
            myStore26.Query(query26, out header26, out resultSet26);
            myStore27.Query(query27, out header27, out resultSet27);
            myStore28.Query(query28, out header28, out resultSet28);
            myStore29.Query(query29, out header29, out resultSet29);
            myStore30.Query(query30, out header30, out resultSet30);
            myStore31.Query(query31, out header31, out resultSet31);
            myStore32.Query(query32, out header32, out resultSet32);
            myStore33.Query(query33, out header33, out resultSet33);
            myStore34.Query(query34, out header34, out resultSet34);
            myStore35.Query(query35, out header35, out resultSet35);
            myStore36.Query(query36, out header36, out resultSet36);
            myStore37.Query(query37, out header37, out resultSet37);
            myStore38.Query(query38, out header38, out resultSet38);
            myStore39.Query(query39, out header39, out resultSet39);
            myStore40.Query(query40, out header40, out resultSet40);
            myStore41.Query(query41, out header41, out resultSet41);
            myStore42.Query(query42, out header42, out resultSet42);
            myStore43.Query(query43, out header43, out resultSet43);
            myStore44.Query(query44, out header44, out resultSet44);
            myStore45.Query(query45, out header45, out resultSet45);
            myStore46.Query(query46, out header46, out resultSet46);
            myStore47.Query(query47, out header47, out resultSet47);
            myStore48.Query(query48, out header48, out resultSet48);
            myStore49.Query(query49, out header49, out resultSet49);
            myStore50.Query(query50, out header50, out resultSet50);
            myStore51.Query(query51, out header51, out resultSet51);
            myStore52.Query(query52, out header52, out resultSet52);
            myStore53.Query(query53, out header53, out resultSet53);
            myStore54.Query(query54, out header54, out resultSet54);
            myStore55.Query(query55, out header55, out resultSet55);
            myStore56.Query(query56, out header56, out resultSet56);
            myStore57.Query(query57, out header57, out resultSet57);
            myStore58.Query(query58, out header58, out resultSet58);
            myStore59.Query(query59, out header59, out resultSet59);
            myStore60.Query(query60, out header60, out resultSet60);
            myStore61.Query(query61, out header61, out resultSet61);
            myStore62.Query(query62, out header62, out resultSet62);
            myStore63.Query(query63, out header63, out resultSet63);
            myStore64.Query(query64, out header64, out resultSet64);
            myStore65.Query(query65, out header65, out resultSet65);
            myStore66.Query(query66, out header66, out resultSet66);
            myStore67.Query(query67, out header67, out resultSet67);
            myStore68.Query(query68, out header68, out resultSet68);
            myStore69.Query(query69, out header69, out resultSet69);
            myStore70.Query(query70, out header70, out resultSet70);
            myStore71.Query(query71, out header71, out resultSet71);
            myStore72.Query(query72, out header72, out resultSet72);
            myStore73.Query(query73, out header73, out resultSet73);
            myStore74.Query(query74, out header74, out resultSet74);
            myStore75.Query(query75, out header75, out resultSet75);
            myStore76.Query(query76, out header76, out resultSet76);
            myStore77.Query(query77, out header77, out resultSet77);
            myStore78.Query(query78, out header78, out resultSet78);
            myStore79.Query(query79, out header79, out resultSet79);
            myStore80.Query(query80, out header80, out resultSet80);
            myStore81.Query(query81, out header81, out resultSet81);
            myStore82.Query(query82, out header82, out resultSet82);
            myStore83.Query(query83, out header83, out resultSet83);
            myStore84.Query(query84, out header84, out resultSet84);
            myStore85.Query(query85, out header85, out resultSet85);
            myStore86.Query(query86, out header86, out resultSet86);
            myStore87.Query(query87, out header87, out resultSet87);
            myStore88.Query(query88, out header88, out resultSet88);
            myStore89.Query(query89, out header89, out resultSet89);
            myStore90.Query(query90, out header90, out resultSet90);
            myStore91.Query(query91, out header91, out resultSet91);
            myStore92.Query(query92, out header92, out resultSet92);
            myStore93.Query(query93, out header93, out resultSet93);
            myStore94.Query(query94, out header94, out resultSet94);
            myStore95.Query(query95, out header95, out resultSet95);
            myStore96.Query(query96, out header96, out resultSet96);
            myStore97.Query(query97, out header97, out resultSet97);
            myStore98.Query(query98, out header98, out resultSet98);
            myStore99.Query(query99, out header99, out resultSet99);
            myStore100.Query(query100, out header100, out resultSet100);
            myStore101.Query(query101, out header101, out resultSet101);
            myStore102.Query(query102, out header102, out resultSet102);
            myStore103.Query(query103, out header103, out resultSet103);
            myStore104.Query(query104, out header104, out resultSet104);
            myStore105.Query(query105, out header105, out resultSet105);
            myStore106.Query(query106, out header106, out resultSet106);
            myStore107.Query(query107, out header107, out resultSet107);
            myStore108.Query(query108, out header108, out resultSet108);
            myStore109.Query(query109, out header109, out resultSet109);
            myStore110.Query(query110, out header110, out resultSet110);
            myStore111.Query(query111, out header111, out resultSet111);
            myStore112.Query(query112, out header112, out resultSet112);
            myStore113.Query(query113, out header113, out resultSet113);
            myStore114.Query(query114, out header114, out resultSet114);
            myStore115.Query(query115, out header115, out resultSet115);
            myStore116.Query(query116, out header116, out resultSet116);
            myStore117.Query(query117, out header117, out resultSet117);
            myStore118.Query(query118, out header118, out resultSet118);
            myStore119.Query(query119, out header119, out resultSet119);
            myStore120.Query(query120, out header120, out resultSet120);
            myStore121.Query(query121, out header121, out resultSet121);
            myStore122.Query(query122, out header122, out resultSet122);
            myStore123.Query(query123, out header123, out resultSet123);
            myStore124.Query(query124, out header124, out resultSet124);
            myStore125.Query(query125, out header125, out resultSet125);
            myStore126.Query(query126, out header126, out resultSet126);
            myStore127.Query(query127, out header127, out resultSet127);
            myStore128.Query(query128, out header128, out resultSet128);
            myStore129.Query(query129, out header129, out resultSet129);
            myStore130.Query(query130, out header130, out resultSet130);
            myStore131.Query(query131, out header131, out resultSet131);
            myStore132.Query(query132, out header132, out resultSet132);
            myStore133.Query(query133, out header133, out resultSet133);
            myStore134.Query(query134, out header134, out resultSet134);
            myStore135.Query(query135, out header135, out resultSet135);
            myStore136.Query(query136, out header136, out resultSet136);
            myStore137.Query(query137, out header137, out resultSet137);
            myStore138.Query(query138, out header138, out resultSet138);
            myStore139.Query(query139, out header139, out resultSet139);
            myStore140.Query(query140, out header140, out resultSet140);
            myStore141.Query(query141, out header141, out resultSet141);
            myStore142.Query(query142, out header142, out resultSet142);
            myStore143.Query(query143, out header143, out resultSet143);
            myStore144.Query(query144, out header144, out resultSet144);





            if (resultSet1 != null && resultSet1.GetLength(0) > 0 && header1 != null && header1.Length > 0)
            {
                float.TryParse(resultSet1[0, 0]?.ToString(), out min1);
            }


            if (resultSet2 != null && resultSet2.GetLength(0) > 0 && header2 != null && header2.Length > 0)
            {
                float.TryParse(resultSet2[0, 0]?.ToString(), out min2);
            }
            // Process resultSet3 (Frequency)
            if (resultSet3 != null && resultSet3.GetLength(0) > 0 && header3 != null && header3.Length > 0)
            {
                float.TryParse(resultSet3[0, 0]?.ToString(), out min3);
            }

            // Process resultSet4 (Avg_PF)
            if (resultSet4 != null && resultSet4.GetLength(0) > 0 && header4 != null && header4.Length > 0)
            {
                float.TryParse(resultSet4[0, 0]?.ToString(), out min4);
            }

            if (resultSet5 != null && resultSet5.GetLength(0) > 0 && header5 != null && header5.Length > 0)
            {
                float.TryParse(resultSet5[0, 0]?.ToString(), out min5);
            }

            if (resultSet6 != null && resultSet6.GetLength(0) > 0 && header6 != null && header6.Length > 0)
            {
                float.TryParse(resultSet6[0, 0]?.ToString(), out min6);
            }

            if (resultSet7 != null && resultSet7.GetLength(0) > 0 && header7 != null && header7.Length > 0)
            {
                float.TryParse(resultSet7[0, 0]?.ToString(), out min7);
            }
            if (resultSet8 != null && resultSet8.GetLength(0) > 0 && header8 != null && header8.Length > 0)
            {
                float.TryParse(resultSet8[0, 0]?.ToString(), out min8);
            }


            if (resultSet9 != null && resultSet9.GetLength(0) > 0 && header9 != null && header9.Length > 0)
            {
                float.TryParse(resultSet9[0, 0]?.ToString(), out min9);
            }
            if (resultSet10 != null && resultSet10.GetLength(0) > 0 && header10 != null && header10.Length > 0)
            {
                float.TryParse(resultSet10[0, 0]?.ToString(), out min10);
            }

            if (resultSet11 != null && resultSet11.GetLength(0) > 0 && header11 != null && header11.Length > 0)
            {
                float.TryParse(resultSet11[0, 0]?.ToString(), out min11);
            }
            if (resultSet12 != null && resultSet12.GetLength(0) > 0 && header12 != null && header12.Length > 0)
            {
                float.TryParse(resultSet12[0, 0]?.ToString(), out min12);
            }

            if (resultSet13 != null && resultSet13.GetLength(0) > 0 && header13 != null && header13.Length > 0)
            {
                float.TryParse(resultSet13[0, 0]?.ToString(), out min13);
            }
            if (resultSet14 != null && resultSet14.GetLength(0) > 0 && header14 != null && header14.Length > 0)
            {
                float.TryParse(resultSet14[0, 0]?.ToString(), out min14);
            }

            if (resultSet15 != null && resultSet15.GetLength(0) > 0 && header15 != null && header15.Length > 0)
            {
                float.TryParse(resultSet15[0, 0]?.ToString(), out min15);
            }
            if (resultSet16 != null && resultSet16.GetLength(0) > 0 && header16 != null && header16.Length > 0)
            {
                float.TryParse(resultSet16[0, 0]?.ToString(), out min16);
            }

            if (resultSet17 != null && resultSet17.GetLength(0) > 0 && header17 != null && header17.Length > 0)
            {
                float.TryParse(resultSet17[0, 0]?.ToString(), out min17);
            }
            if (resultSet18 != null && resultSet18.GetLength(0) > 0 && header18 != null && header18.Length > 0)
            {
                float.TryParse(resultSet18[0, 0]?.ToString(), out min18);
            }

            if (resultSet19 != null && resultSet19.GetLength(0) > 0 && header19 != null && header19.Length > 0)
            {
                float.TryParse(resultSet19[0, 0]?.ToString(), out min19);
            }
            if (resultSet20 != null && resultSet20.GetLength(0) > 0 && header20 != null && header20.Length > 0)
            {
                float.TryParse(resultSet20[0, 0]?.ToString(), out min20);
            }

            if (resultSet21 != null && resultSet21.GetLength(0) > 0 && header21 != null && header21.Length > 0)
            {
                float.TryParse(resultSet21[0, 0]?.ToString(), out min21);
            }
            if (resultSet22 != null && resultSet22.GetLength(0) > 0 && header22 != null && header22.Length > 0)
            {
                float.TryParse(resultSet22[0, 0]?.ToString(), out min22);
            }

            if (resultSet23 != null && resultSet23.GetLength(0) > 0 && header23 != null && header23.Length > 0)
            {
                float.TryParse(resultSet23[0, 0]?.ToString(), out min23);
            }
            if (resultSet24 != null && resultSet24.GetLength(0) > 0 && header24 != null && header24.Length > 0)
            {
                float.TryParse(resultSet24[0, 0]?.ToString(), out min24);
            }

            if (resultSet25 != null && resultSet25.GetLength(0) > 0 && header25 != null && header25.Length > 0)
            {
                float.TryParse(resultSet25[0, 0]?.ToString(), out min25);
            }
            if (resultSet26 != null && resultSet26.GetLength(0) > 0 && header26 != null && header26.Length > 0)
            {
                float.TryParse(resultSet26[0, 0]?.ToString(), out min26);
            }

            if (resultSet27 != null && resultSet27.GetLength(0) > 0 && header27 != null && header27.Length > 0)
            {
                float.TryParse(resultSet27[0, 0]?.ToString(), out min27);
            }
            if (resultSet28 != null && resultSet28.GetLength(0) > 0 && header28 != null && header28.Length > 0)
            {
                float.TryParse(resultSet28[0, 0]?.ToString(), out min28);
            }

            if (resultSet29 != null && resultSet29.GetLength(0) > 0 && header29 != null && header29.Length > 0)
            {
                float.TryParse(resultSet29[0, 0]?.ToString(), out min29);
            }
            if (resultSet30 != null && resultSet30.GetLength(0) > 0 && header30 != null && header30.Length > 0)
            {
                float.TryParse(resultSet30[0, 0]?.ToString(), out min30);
            }

            if (resultSet31 != null && resultSet31.GetLength(0) > 0 && header31 != null && header31.Length > 0)
            {
                float.TryParse(resultSet31[0, 0]?.ToString(), out min31);
            }
            if (resultSet32 != null && resultSet32.GetLength(0) > 0 && header32 != null && header32.Length > 0)
            {
                float.TryParse(resultSet32[0, 0]?.ToString(), out min32);
            }

            if (resultSet33 != null && resultSet33.GetLength(0) > 0 && header33 != null && header33.Length > 0)
            {
                float.TryParse(resultSet33[0, 0]?.ToString(), out min33);
            }
            if (resultSet34 != null && resultSet34.GetLength(0) > 0 && header34 != null && header34.Length > 0)
            {
                float.TryParse(resultSet34[0, 0]?.ToString(), out min34);
            }

            if (resultSet35 != null && resultSet35.GetLength(0) > 0 && header35 != null && header35.Length > 0)
            {
                float.TryParse(resultSet35[0, 0]?.ToString(), out min35);
            }
            if (resultSet36 != null && resultSet36.GetLength(0) > 0 && header36 != null && header36.Length > 0)
            {
                float.TryParse(resultSet36[0, 0]?.ToString(), out min36);
            }

            if (resultSet37 != null && resultSet37.GetLength(0) > 0 && header37 != null && header37.Length > 0)
            {
                float.TryParse(resultSet37[0, 0]?.ToString(), out min37);
            }

            if (resultSet38 != null && resultSet38.GetLength(0) > 0 && header38 != null && header38.Length > 0)
            {
                float.TryParse(resultSet38[0, 0]?.ToString(), out min38);
            }

            if (resultSet39 != null && resultSet39.GetLength(0) > 0 && header39 != null && header39.Length > 0)
            {
                float.TryParse(resultSet39[0, 0]?.ToString(), out min39);
            }
            if (resultSet40 != null && resultSet40.GetLength(0) > 0 && header40 != null && header40.Length > 0)
            {
                float.TryParse(resultSet40[0, 0]?.ToString(), out min40);
            }

            if (resultSet41 != null && resultSet41.GetLength(0) > 0 && header41 != null && header41.Length > 0)
            {
                float.TryParse(resultSet41[0, 0]?.ToString(), out min41);
            }
            if (resultSet42 != null && resultSet42.GetLength(0) > 0 && header42 != null && header42.Length > 0)
            {
                float.TryParse(resultSet42[0, 0]?.ToString(), out min42);
            }

            if (resultSet43 != null && resultSet43.GetLength(0) > 0 && header43 != null && header43.Length > 0)
            {
                float.TryParse(resultSet43[0, 0]?.ToString(), out min43);
            }
            if (resultSet44 != null && resultSet44.GetLength(0) > 0 && header44 != null && header44.Length > 0)
            {
                float.TryParse(resultSet44[0, 0]?.ToString(), out min44);
            }
            if (resultSet45 != null && resultSet45.GetLength(0) > 0 && header45 != null && header45.Length > 0)
            {
                float.TryParse(resultSet45[0, 0]?.ToString(), out min45);
            }
            if (resultSet46 != null && resultSet46.GetLength(0) > 0 && header46 != null && header46.Length > 0)
            {
                float.TryParse(resultSet46[0, 0]?.ToString(), out min46);
            }
            // Day 44
            if (resultSet47 != null && resultSet47.GetLength(0) > 0 && header47 != null && header47.Length > 0)
            {
                float.TryParse(resultSet47[0, 0]?.ToString(), out min47);
            }
            if (resultSet48 != null && resultSet48.GetLength(0) > 0 && header48 != null && header48.Length > 0)
            {
                float.TryParse(resultSet48[0, 0]?.ToString(), out min48);
            }

            if (resultSet49 != null && resultSet49.GetLength(0) > 0 && header49 != null && header49.Length > 0)
            {
                float.TryParse(resultSet49[0, 0]?.ToString(), out min49);
            }

            // Day 149
            if (resultSet50 != null && resultSet50.GetLength(0) > 0 && header50 != null && header50.Length > 0)
            {
                float.TryParse(resultSet50[0, 0]?.ToString(), out min50);
            }

            // Day 150
            if (resultSet51 != null && resultSet51.GetLength(0) > 0 && header51 != null && header51.Length > 0)
            {
                float.TryParse(resultSet51[0, 0]?.ToString(), out min51);
            }

            // Day 151
            if (resultSet52 != null && resultSet52.GetLength(0) > 0 && header52 != null && header52.Length > 0)
            {
                float.TryParse(resultSet52[0, 0]?.ToString(), out min52);
            }

            if (resultSet53 != null && resultSet53.GetLength(0) > 0 && header53 != null && header53.Length > 0)
            {
                float.TryParse(resultSet53[0, 0]?.ToString(), out min53);
            }

            // Day 53
            if (resultSet54 != null && resultSet54.GetLength(0) > 0 && header54 != null && header54.Length > 0)
            {
                float.TryParse(resultSet54[0, 0]?.ToString(), out min54);
            }

            // Day 54
            if (resultSet55 != null && resultSet55.GetLength(0) > 0 && header55 != null && header55.Length > 0)
            {
                float.TryParse(resultSet55[0, 0]?.ToString(), out min55);
            }

            // Day 55
            if (resultSet56 != null && resultSet56.GetLength(0) > 0 && header56 != null && header56.Length > 0)
            {
                float.TryParse(resultSet56[0, 0]?.ToString(), out min56);
            }

            // Day 56
            if (resultSet57 != null && resultSet57.GetLength(0) > 0 && header57 != null && header57.Length > 0)
            {
                float.TryParse(resultSet57[0, 0]?.ToString(), out min57);
            }

            // Day 57
            if (resultSet58 != null && resultSet58.GetLength(0) > 0 && header58 != null && header58.Length > 0)
            {
                float.TryParse(resultSet58[0, 0]?.ToString(), out min58);
            }

            // Day 58
            if (resultSet59 != null && resultSet59.GetLength(0) > 0 && header59 != null && header59.Length > 0)
            {
                float.TryParse(resultSet59[0, 0]?.ToString(), out min59);
            }

            // Day 59
            if (resultSet60 != null && resultSet60.GetLength(0) > 0 && header60 != null && header60.Length > 0)
            {
                float.TryParse(resultSet60[0, 0]?.ToString(), out min60);
            }
            // Day 61
            if (resultSet62 != null && resultSet62.GetLength(0) > 0 && header62 != null && header62.Length > 0)
            {
                float.TryParse(resultSet62[0, 0]?.ToString(), out min61);
            }

            // Day 62
            if (resultSet63 != null && resultSet63.GetLength(0) > 0 && header63 != null && header63.Length > 0)
            {
                float.TryParse(resultSet63[0, 0]?.ToString(), out min62);
            }

            // Day 63
            if (resultSet64 != null && resultSet64.GetLength(0) > 0 && header64 != null && header64.Length > 0)
            {
                float.TryParse(resultSet64[0, 0]?.ToString(), out min63);
            }

            // Day 64
            if (resultSet65 != null && resultSet65.GetLength(0) > 0 && header65 != null && header65.Length > 0)
            {
                float.TryParse(resultSet65[0, 0]?.ToString(), out min64);
            }

            // Day 65
            if (resultSet66 != null && resultSet66.GetLength(0) > 0 && header66 != null && header66.Length > 0)
            {
                float.TryParse(resultSet66[0, 0]?.ToString(), out min65);
            }


            if (resultSet66 != null && resultSet66.GetLength(0) > 0 && header66 != null && header66.Length > 0)
            {
                float.TryParse(resultSet66[0, 0]?.ToString(), out min66);
            }

            // Day 66
            if (resultSet67 != null && resultSet67.GetLength(0) > 0 && header67 != null && header67.Length > 0)
            {
                float.TryParse(resultSet67[0, 0]?.ToString(), out min67);
            }

            // Day 67
            if (resultSet68 != null && resultSet68.GetLength(0) > 0 && header68 != null && header68.Length > 0)
            {
                float.TryParse(resultSet68[0, 0]?.ToString(), out min68);
            }

            // Day 68
            if (resultSet69 != null && resultSet69.GetLength(0) > 0 && header69 != null && header69.Length > 0)
            {
                float.TryParse(resultSet69[0, 0]?.ToString(), out min69);
            }

            // Day 69
            if (resultSet70 != null && resultSet70.GetLength(0) > 0 && header70 != null && header70.Length > 0)
            {
                float.TryParse(resultSet70[0, 0]?.ToString(), out min70);
            }

            // Day 70
            if (resultSet71 != null && resultSet71.GetLength(0) > 0 && header71 != null && header71.Length > 0)
            {
                float.TryParse(resultSet71[0, 0]?.ToString(), out min71);
            }

            // Day 71
            if (resultSet72 != null && resultSet72.GetLength(0) > 0 && header72 != null && header72.Length > 0)
            {
                float.TryParse(resultSet72[0, 0]?.ToString(), out min72);
            }

            // Day 72
            if (resultSet73 != null && resultSet73.GetLength(0) > 0 && header73 != null && header73.Length > 0)
            {
                float.TryParse(resultSet73[0, 0]?.ToString(), out min73);
            }

            // Day 73
            if (resultSet74 != null && resultSet74.GetLength(0) > 0 && header74 != null && header74.Length > 0)
            {
                float.TryParse(resultSet74[0, 0]?.ToString(), out min74);
            }

            // Day 74
            if (resultSet75 != null && resultSet75.GetLength(0) > 0 && header75 != null && header75.Length > 0)
            {
                float.TryParse(resultSet75[0, 0]?.ToString(), out min75);
            }

            // Day 75
            if (resultSet76 != null && resultSet76.GetLength(0) > 0 && header76 != null && header76.Length > 0)
            {
                float.TryParse(resultSet76[0, 0]?.ToString(), out min76);
            }

            // Day 76
            if (resultSet77 != null && resultSet77.GetLength(0) > 0 && header77 != null && header77.Length > 0)
            {
                float.TryParse(resultSet77[0, 0]?.ToString(), out min77);
            }

            // Day 77
            if (resultSet78 != null && resultSet78.GetLength(0) > 0 && header78 != null && header78.Length > 0)
            {
                float.TryParse(resultSet78[0, 0]?.ToString(), out min78);
            }

            // Day 78
            if (resultSet79 != null && resultSet79.GetLength(0) > 0 && header79 != null && header79.Length > 0)
            {
                float.TryParse(resultSet79[0, 0]?.ToString(), out min79);
            }

            // Day 94
            if (resultSet95 != null && resultSet95.GetLength(0) > 0 && header95 != null && header95.Length > 0)
            {
                float.TryParse(resultSet95[0, 0]?.ToString(), out min95);
            }

            // Day 95
            if (resultSet96 != null && resultSet96.GetLength(0) > 0 && header96 != null && header96.Length > 0)
            {
                float.TryParse(resultSet96[0, 0]?.ToString(), out min96);
            }

            // Day 96
            if (resultSet97 != null && resultSet97.GetLength(0) > 0 && header97 != null && header97.Length > 0)
            {
                float.TryParse(resultSet97[0, 0]?.ToString(), out min97);
            }

            // Day 97
            if (resultSet98 != null && resultSet98.GetLength(0) > 0 && header98 != null && header98.Length > 0)
            {
                float.TryParse(resultSet98[0, 0]?.ToString(), out min98);
            }

            // Day 98
            if (resultSet99 != null && resultSet99.GetLength(0) > 0 && header99 != null && header99.Length > 0)
            {
                float.TryParse(resultSet99[0, 0]?.ToString(), out min99);
            }

            // Day 99
            if (resultSet100 != null && resultSet100.GetLength(0) > 0 && header100 != null && header100.Length > 0)
            {
                float.TryParse(resultSet100[0, 0]?.ToString(), out min100);
            }

            // Day 100
            if (resultSet101 != null && resultSet101.GetLength(0) > 0 && header101 != null && header101.Length > 0)
            {
                float.TryParse(resultSet101[0, 0]?.ToString(), out min101);
            }

            // Day 101
            if (resultSet102 != null && resultSet102.GetLength(0) > 0 && header102 != null && header102.Length > 0)
            {
                float.TryParse(resultSet102[0, 0]?.ToString(), out min102);
            }

            // Day 102
            if (resultSet103 != null && resultSet103.GetLength(0) > 0 && header103 != null && header103.Length > 0)
            {
                float.TryParse(resultSet103[0, 0]?.ToString(), out min103);
            }

            // Day 103
            if (resultSet104 != null && resultSet104.GetLength(0) > 0 && header104 != null && header104.Length > 0)
            {
                float.TryParse(resultSet104[0, 0]?.ToString(), out min104);
            }

            // Day 104
            if (resultSet105 != null && resultSet105.GetLength(0) > 0 && header105 != null && header105.Length > 0)
            {
                float.TryParse(resultSet105[0, 0]?.ToString(), out min105);
            }

            // Day 105
            if (resultSet106 != null && resultSet106.GetLength(0) > 0 && header106 != null && header106.Length > 0)
            {
                float.TryParse(resultSet106[0, 0]?.ToString(), out min106);
            }

            // Day 106
            if (resultSet107 != null && resultSet107.GetLength(0) > 0 && header107 != null && header107.Length > 0)
            {
                float.TryParse(resultSet107[0, 0]?.ToString(), out min107);
            }

            // Day 107
            if (resultSet108 != null && resultSet108.GetLength(0) > 0 && header108 != null && header108.Length > 0)
            {
                float.TryParse(resultSet108[0, 0]?.ToString(), out min108);
            }

            // Day 108
            if (resultSet109 != null && resultSet109.GetLength(0) > 0 && header109 != null && header109.Length > 0)
            {
                float.TryParse(resultSet109[0, 0]?.ToString(), out min109);
            }
            // Day 109
            if (resultSet110 != null && resultSet110.GetLength(0) > 0 && header110 != null && header110.Length > 0)
            {
                float.TryParse(resultSet110[0, 0]?.ToString(), out min110);
            }

            // Day 110
            if (resultSet111 != null && resultSet111.GetLength(0) > 0 && header111 != null && header111.Length > 0)
            {
                float.TryParse(resultSet111[0, 0]?.ToString(), out min111);
            }

            // Day 111
            if (resultSet112 != null && resultSet112.GetLength(0) > 0 && header112 != null && header112.Length > 0)
            {
                float.TryParse(resultSet112[0, 0]?.ToString(), out min112);
            }

            // Day 112
            if (resultSet113 != null && resultSet113.GetLength(0) > 0 && header113 != null && header113.Length > 0)
            {
                float.TryParse(resultSet113[0, 0]?.ToString(), out min113);
            }

            // Day 113
            if (resultSet114 != null && resultSet114.GetLength(0) > 0 && header114 != null && header114.Length > 0)
            {
                float.TryParse(resultSet114[0, 0]?.ToString(), out min114);
            }

            // Day 114
            if (resultSet115 != null && resultSet115.GetLength(0) > 0 && header115 != null && header115.Length > 0)
            {
                float.TryParse(resultSet115[0, 0]?.ToString(), out min115);
            }

            // Day 115
            if (resultSet116 != null && resultSet116.GetLength(0) > 0 && header116 != null && header116.Length > 0)
            {
                float.TryParse(resultSet116[0, 0]?.ToString(), out min116);
            }

            // Day 116
            if (resultSet117 != null && resultSet117.GetLength(0) > 0 && header117 != null && header117.Length > 0)
            {
                float.TryParse(resultSet117[0, 0]?.ToString(), out min117);
            }

            // Day 117
            if (resultSet118 != null && resultSet118.GetLength(0) > 0 && header118 != null && header118.Length > 0)
            {
                float.TryParse(resultSet118[0, 0]?.ToString(), out min118);
            }

            // Day 118
            if (resultSet119 != null && resultSet119.GetLength(0) > 0 && header119 != null && header119.Length > 0)
            {
                float.TryParse(resultSet119[0, 0]?.ToString(), out min119);
            }

            // Day 119
            if (resultSet120 != null && resultSet120.GetLength(0) > 0 && header120 != null && header120.Length > 0)
            {
                float.TryParse(resultSet120[0, 0]?.ToString(), out min120);
            }

            // Day 120
            if (resultSet121 != null && resultSet121.GetLength(0) > 0 && header121 != null && header121.Length > 0)
            {
                float.TryParse(resultSet121[0, 0]?.ToString(), out min121);
            }

            // Day 121
            if (resultSet122 != null && resultSet122.GetLength(0) > 0 && header122 != null && header122.Length > 0)
            {
                float.TryParse(resultSet122[0, 0]?.ToString(), out min122);
            }

            // Day 122
            if (resultSet123 != null && resultSet123.GetLength(0) > 0 && header123 != null && header123.Length > 0)
            {
                float.TryParse(resultSet123[0, 0]?.ToString(), out min123);
            }
            if (resultSet124 != null && resultSet124.GetLength(0) > 0 && header124 != null && header124.Length > 0)
            {
                float.TryParse(resultSet124[0, 0]?.ToString(), out min124);
            }

            // Day 124
            if (resultSet125 != null && resultSet125.GetLength(0) > 0 && header125 != null && header125.Length > 0)
            {
                float.TryParse(resultSet125[0, 0]?.ToString(), out min125);
            }

            // Day 125
            if (resultSet126 != null && resultSet126.GetLength(0) > 0 && header126 != null && header126.Length > 0)
            {
                float.TryParse(resultSet126[0, 0]?.ToString(), out min126);
            }

            // Day 126
            if (resultSet127 != null && resultSet127.GetLength(0) > 0 && header127 != null && header127.Length > 0)
            {
                float.TryParse(resultSet127[0, 0]?.ToString(), out min127);
            }

            // Day 127
            if (resultSet128 != null && resultSet128.GetLength(0) > 0 && header128 != null && header128.Length > 0)
            {
                float.TryParse(resultSet128[0, 0]?.ToString(), out min128);
            }

            // Day 128
            if (resultSet129 != null && resultSet129.GetLength(0) > 0 && header129 != null && header129.Length > 0)
            {
                float.TryParse(resultSet129[0, 0]?.ToString(), out min129);
            }

            // Day 129
            if (resultSet130 != null && resultSet130.GetLength(0) > 0 && header130 != null && header130.Length > 0)
            {
                float.TryParse(resultSet130[0, 0]?.ToString(), out min130);
            }

            // Day 130
            if (resultSet131 != null && resultSet131.GetLength(0) > 0 && header131 != null && header131.Length > 0)
            {
                float.TryParse(resultSet131[0, 0]?.ToString(), out min131);
            }

            // Day 131
            if (resultSet132 != null && resultSet132.GetLength(0) > 0 && header132 != null && header132.Length > 0)
            {
                float.TryParse(resultSet132[0, 0]?.ToString(), out min132);
            }

            // Day 132
            if (resultSet133 != null && resultSet133.GetLength(0) > 0 && header133 != null && header133.Length > 0)
            {
                float.TryParse(resultSet133[0, 0]?.ToString(), out min133);
            }

            // Day 133
            if (resultSet134 != null && resultSet134.GetLength(0) > 0 && header134 != null && header134.Length > 0)
            {
                float.TryParse(resultSet134[0, 0]?.ToString(), out min134);
            }

            // Day 134
            if (resultSet135 != null && resultSet135.GetLength(0) > 0 && header135 != null && header135.Length > 0)
            {
                float.TryParse(resultSet135[0, 0]?.ToString(), out min135);
            }

            // Day 135
            if (resultSet136 != null && resultSet136.GetLength(0) > 0 && header136 != null && header136.Length > 0)
            {
                float.TryParse(resultSet136[0, 0]?.ToString(), out min136);
            }

            if (resultSet137 != null && resultSet137.GetLength(0) > 0 && header137 != null && header137.Length > 0)
            {
                float.TryParse(resultSet137[0, 0]?.ToString(), out min137);
            }

            if (resultSet138 != null && resultSet138.GetLength(0) > 0 && header138 != null && header138.Length > 0)
            {
                float.TryParse(resultSet138[0, 0]?.ToString(), out min138);
            }

            // Day 138
            if (resultSet139 != null && resultSet139.GetLength(0) > 0 && header139 != null && header139.Length > 0)
            {
                float.TryParse(resultSet139[0, 0]?.ToString(), out min139);
            }

            // Day 139
            if (resultSet140 != null && resultSet140.GetLength(0) > 0 && header140 != null && header140.Length > 0)
            {
                float.TryParse(resultSet140[0, 0]?.ToString(), out min140);
            }

            // Day 140
            if (resultSet141 != null && resultSet141.GetLength(0) > 0 && header141 != null && header141.Length > 0)
            {
                float.TryParse(resultSet141[0, 0]?.ToString(), out min141);
            }

            // Day 141
            if (resultSet142 != null && resultSet142.GetLength(0) > 0 && header142 != null && header142.Length > 0)
            {
                float.TryParse(resultSet142[0, 0]?.ToString(), out min142);
            }

            // Day 142
            if (resultSet143 != null && resultSet143.GetLength(0) > 0 && header143 != null && header143.Length > 0)
            {
                float.TryParse(resultSet143[0, 0]?.ToString(), out min142);
            }

            // Day 143
            if (resultSet144 != null && resultSet144.GetLength(0) > 0 && header144 != null && header144.Length > 0)
            {
                float.TryParse(resultSet144[0, 0]?.ToString(), out min143);
            }





        }

        meterVariable.Value = meter;
        min1Variable.Value = min1;
        min2Variable.Value = min2;
        min3Variable.Value = min3;
        min4Variable.Value = min4;
        min5Variable.Value = min5;
        min6Variable.Value = min6;
        min7Variable.Value = min7;
        min8Variable.Value = min8;
        min9Variable.Value = min9;
        min10Variable.Value = min10;
        min11Variable.Value = min11;
        min12Variable.Value = min12;
        min13Variable.Value = min13;
        min14Variable.Value = min14;
        min15Variable.Value = min15;
        min16Variable.Value = min16;
        min17Variable.Value = min17;
        min18Variable.Value = min18;
        min19Variable.Value = min19;
        min20Variable.Value = min20;
        min21Variable.Value = min21;
        min22Variable.Value = min22;
        min23Variable.Value = min23;
        min24Variable.Value = min24;
        min25Variable.Value = min25;
        min26Variable.Value = min26;
        min27Variable.Value = min27;
        min28Variable.Value = min28;
        min29Variable.Value = min29;
        min30Variable.Value = min30;
        min31Variable.Value = min31;
        min32Variable.Value = min32;
        min33Variable.Value = min33;
        min34Variable.Value = min34;
        min35Variable.Value = min35;
        min36Variable.Value = min36;
        min37Variable.Value = min37;
        min38Variable.Value = min38;
        min39Variable.Value = min39;
        min40Variable.Value = min40;
        min41Variable.Value = min41;
        min42Variable.Value = min42;
        min43Variable.Value = min43;
        min44Variable.Value = min44;
        min45Variable.Value = min45;
        min46Variable.Value = min46;
        min47Variable.Value = min47;
        min48Variable.Value = min48;
        min49Variable.Value = min49;
        min50Variable.Value = min50;
        min51Variable.Value = min51;
        min52Variable.Value = min52;
        min53Variable.Value = min53;
        min54Variable.Value = min54;
        min55Variable.Value = min55;
        min56Variable.Value = min56;
        min57Variable.Value = min57;
        min58Variable.Value = min58;
        min59Variable.Value = min59;
        min60Variable.Value = min60;
        min61Variable.Value = min61;
        min62Variable.Value = min62;
        min63Variable.Value = min63;
        min64Variable.Value = min64;
        min65Variable.Value = min65;
        min66Variable.Value = min66;
        min67Variable.Value = min67;
        min68Variable.Value = min68;
        min69Variable.Value = min68;
        min70Variable.Value = min69;
        min71Variable.Value = min70;
        min72Variable.Value = min72;
        min73Variable.Value = min73;
        min74Variable.Value = min74;
        min75Variable.Value = min75;
        min76Variable.Value = min76;
        min77Variable.Value = min77;
        min78Variable.Value = min78;
        min79Variable.Value = min79;
        min80Variable.Value = min80;
        min81Variable.Value = min81;
        min82Variable.Value = min82;
        min83Variable.Value = min83;
        min84Variable.Value = min84;
        min85Variable.Value = min85;
        min86Variable.Value = min86;
        min87Variable.Value = min87;
        min88Variable.Value = min88;
        min89Variable.Value = min89;
        min90Variable.Value = min90;
        min91Variable.Value = min91;
        min92Variable.Value = min92;
        min92Variable.Value = min93;
        min93Variable.Value = min94;
        min94Variable.Value = min95;
        min95Variable.Value = min96;
        min96Variable.Value = min96;
        min97Variable.Value = min97;
        min98Variable.Value = min98;
        min99Variable.Value = min99;
        min100Variable.Value = min100;
        min101Variable.Value = min101;
        min102Variable.Value = min102;
        min103Variable.Value = min103;
        min104Variable.Value = min104;
        min105Variable.Value = min105;
        min106Variable.Value = min106;
        min107Variable.Value = min107;
        min108Variable.Value = min108;
        min109Variable.Value = min109;
        min110Variable.Value = min110;
        min111Variable.Value = min111;
        min112Variable.Value = min112;
        min113Variable.Value = min113;
        min114Variable.Value = min114;
        min115Variable.Value = min115;
        min116Variable.Value = min116;
        min117Variable.Value = min117;
        min118Variable.Value = min118;
        min119Variable.Value = min119;
        min120Variable.Value = min120;
        min121Variable.Value = min121;
        min122Variable.Value = min122;
        min123Variable.Value = min123;
        min124Variable.Value = min124;
        min125Variable.Value = min125;
        min126Variable.Value = min126;
        min127Variable.Value = min127;
        min128Variable.Value = min128;
        min129Variable.Value = min129;
        min130Variable.Value = min130;
        min131Variable.Value = min131;
        min132Variable.Value = min132;
        min133Variable.Value = min133;
        min134Variable.Value = min134;
        min135Variable.Value = min135;
        min136Variable.Value = min136;
        min137Variable.Value = min137;
        min138Variable.Value = min138;
        min139Variable.Value = min139;
        min140Variable.Value = min140;
        min141Variable.Value = min141;
        min142Variable.Value = min142;
        min143Variable.Value = min143;
        min144Variable.Value = min144;







    }
}



