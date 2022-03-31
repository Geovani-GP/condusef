/*
               File: LoadEventsSampleProc
        Description: Stub for LoadEventsSampleProc
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:18:57.31
       Program type: Callable routine
          Main DBMS: postgresql
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using NpgsqlTypes;
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
   public class loadeventssampleproc : GXProcedure
   {
      public loadeventssampleproc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public loadeventssampleproc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_dateFrom ,
                           DateTime aP1_dateTo ,
                           out SdtSchedulerEvents aP2_events )
      {
         this.AV2dateFrom = aP0_dateFrom;
         this.AV3dateTo = aP1_dateTo;
         this.AV4events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP2_events=this.AV4events;
      }

      public SdtSchedulerEvents executeUdp( DateTime aP0_dateFrom ,
                                            DateTime aP1_dateTo )
      {
         this.AV2dateFrom = aP0_dateFrom;
         this.AV3dateTo = aP1_dateTo;
         this.AV4events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP2_events=this.AV4events;
         return AV4events ;
      }

      public void executeSubmit( DateTime aP0_dateFrom ,
                                 DateTime aP1_dateTo ,
                                 out SdtSchedulerEvents aP2_events )
      {
         loadeventssampleproc objloadeventssampleproc;
         objloadeventssampleproc = new loadeventssampleproc();
         objloadeventssampleproc.AV2dateFrom = aP0_dateFrom;
         objloadeventssampleproc.AV3dateTo = aP1_dateTo;
         objloadeventssampleproc.AV4events = new SdtSchedulerEvents(context) ;
         objloadeventssampleproc.context.SetSubmitInitialConfig(context);
         objloadeventssampleproc.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloadeventssampleproc);
         aP2_events=this.AV4events;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadeventssampleproc)stateInfo).executePrivate();
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
         args = new Object[] {(DateTime)AV2dateFrom,(DateTime)AV3dateTo,(SdtSchedulerEvents)AV4events} ;
         ClassLoader.Execute("aloadeventssampleproc","GeneXus.Programs.aloadeventssampleproc", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV4events = (SdtSchedulerEvents)(args[2]) ;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private DateTime AV2dateFrom ;
      private DateTime AV3dateTo ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
      private SdtSchedulerEvents aP2_events ;
      private SdtSchedulerEvents AV4events ;
   }

}
