/*
               File: LoadEventsSampleProc
        Description: Load Events Sample Proc
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:7:12.39
       Program type: Main program
          Main DBMS: postgresql
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class aloadeventssampleproc : GXProcedure
   {
      public aloadeventssampleproc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public aloadeventssampleproc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_dateFrom ,
                           DateTime aP1_dateTo ,
                           out SdtSchedulerEvents aP2_events )
      {
         this.AV10dateFrom = aP0_dateFrom;
         this.AV11dateTo = aP1_dateTo;
         this.AV9events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP2_events=this.AV9events;
      }

      public SdtSchedulerEvents executeUdp( DateTime aP0_dateFrom ,
                                            DateTime aP1_dateTo )
      {
         this.AV10dateFrom = aP0_dateFrom;
         this.AV11dateTo = aP1_dateTo;
         this.AV9events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP2_events=this.AV9events;
         return AV9events ;
      }

      public void executeSubmit( DateTime aP0_dateFrom ,
                                 DateTime aP1_dateTo ,
                                 out SdtSchedulerEvents aP2_events )
      {
         aloadeventssampleproc objaloadeventssampleproc;
         objaloadeventssampleproc = new aloadeventssampleproc();
         objaloadeventssampleproc.AV10dateFrom = aP0_dateFrom;
         objaloadeventssampleproc.AV11dateTo = aP1_dateTo;
         objaloadeventssampleproc.AV9events = new SdtSchedulerEvents(context) ;
         objaloadeventssampleproc.context.SetSubmitInitialConfig(context);
         objaloadeventssampleproc.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objaloadeventssampleproc);
         aP2_events=this.AV9events;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aloadeventssampleproc)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV8event.gxTpr_Id = "Sample1";
         AV8event.gxTpr_Name = "Wimbledon Match";
         AV8event.gxTpr_Notes = "Wimbledon Match";
         AV8event.gxTpr_Link = "http://www.genexus.com";
         AV8event.gxTpr_Starttime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)), 15, 30, 0);
         AV8event.gxTpr_Endtime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)), 17, 30, 0);
         AV8event.gxTpr_Additionalinformation = "";
         AV9events.gxTpr_Items.Add(AV8event, 0);
         AV8event = new SdtSchedulerEvents_event(context);
         AV8event.gxTpr_Id = "Sample2";
         AV8event.gxTpr_Name = "NBA Finals";
         AV8event.gxTpr_Notes = "NBA Finals";
         AV8event.gxTpr_Link = "http://www.gxtechnical.com";
         AV8event.gxTpr_Starttime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)), 21, 0, 0);
         AV8event.gxTpr_Endtime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)), 22, 45, 0);
         AV8event.gxTpr_Additionalinformation = "";
         AV9events.gxTpr_Items.Add(AV8event, 0);
         AV8event = new SdtSchedulerEvents_event(context);
         AV8event.gxTpr_Id = "Sample3";
         AV8event.gxTpr_Name = "Meeting with clients";
         AV8event.gxTpr_Notes = "Meeting with clients";
         AV8event.gxTpr_Link = "http://www.gxtechnical.com/gxsearch";
         AV8event.gxTpr_Starttime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)+1), 8, 30, 0);
         AV8event.gxTpr_Endtime = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( Gx_date)), (short)(DateTimeUtil.Month( Gx_date)), (short)(DateTimeUtil.Day( Gx_date)+1), 11, 30, 0);
         AV8event.gxTpr_Additionalinformation = "";
         AV9events.gxTpr_Items.Add(AV8event, 0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV8event = new SdtSchedulerEvents_event(context);
         Gx_date = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private DateTime AV10dateFrom ;
      private DateTime AV11dateTo ;
      private DateTime Gx_date ;
      private SdtSchedulerEvents aP2_events ;
      private SdtSchedulerEvents AV9events ;
      private SdtSchedulerEvents_event AV8event ;
   }

}
