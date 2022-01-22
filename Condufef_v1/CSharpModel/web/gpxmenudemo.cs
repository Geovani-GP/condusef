/*
               File: gpxMenuDemo
        Description: gpx Menu Demo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 12/30/2021 22:8:45.95
       Program type: Callable routine
          Main DBMS: sqlserver
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
   public class gpxmenudemo : GXProcedure
   {
      public gpxmenudemo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gpxmenudemo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( out IGxCollection aP0_Gxm2rootcol )
      {
         gpxmenudemo objgpxmenudemo;
         objgpxmenudemo = new gpxmenudemo();
         objgpxmenudemo.Gxm2rootcol = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs") ;
         objgpxmenudemo.context.SetSubmitInitialConfig(context);
         objgpxmenudemo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgpxmenudemo);
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gpxmenudemo)stateInfo).executePrivate();
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
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Inicio";
         Gxm1gpxmenuitems.gxTpr_Url = "http://www.gprojex.com";
         Gxm1gpxmenuitems.gxTpr_Description = "Making things happen!";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Cat�logos";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Catalogo De Cambs";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Cambs.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Documentation";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "http://open.genexus.com/wiki.aspx?SSID-32,Stone+Framework+by+GProjex,article";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Download";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "https://marketplace.genexus.com/viewproduct.aspx?597";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Reportes";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Home";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "http://www.genexus.com";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "GX Technical";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "http://www.gxtechnical.com";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Wiki";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "http://wiki.gxtechnical.com";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Marketplace";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "https://marketplace.genexus.com";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Submenu";
         Gxm4gpxmenuitems_subitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm3gpxmenuitems_subitems.gxTpr_Subitems.Add(Gxm4gpxmenuitems_subitems_subitems, 0);
         Gxm4gpxmenuitems_subitems_subitems.gxTpr_Title = "Home";
         Gxm4gpxmenuitems_subitems_subitems.gxTpr_Url = "http://www.gprojex.com";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Consultas";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Consultar Cambs";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "cambs.aspx";
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
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm4gpxmenuitems_subitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private IGxCollection aP0_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtgpxMenuItems_gpxMenuItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtgpxMenuItems_gpxMenuItem Gxm1gpxmenuitems ;
      private SdtgpxMenuItems_gpxMenuItem Gxm3gpxmenuitems_subitems ;
      private SdtgpxMenuItems_gpxMenuItem Gxm4gpxmenuitems_subitems_subitems ;
   }

}