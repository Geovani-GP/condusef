/*
               File: gpxMenuDemo
        Description: gpx Menu Demo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/21/2022 20:54:44.97
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
         Gxm1gpxmenuitems.gxTpr_Url = "MenuPrincipal.aspx";
         Gxm1gpxmenuitems.gxTpr_Description = "Menú Principal";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Catálogos";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Almacén";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Almacen.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Area";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Area.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Cambs";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Cambs.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Categoria";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Categorias.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Empleados";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Empleados.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Empleado Piso EXT";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Empleados_Piso.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Entidad Federativa";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Entidad_Federativa.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Estatus";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Status.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "EstatusArticulo";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Articulo.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Marca";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Marcas.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Meses";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Modelo";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Modelo.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Origen";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Origen.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Productos";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Productos.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Proveedor";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Proveedor.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "TipoBien";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_TipoBien.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "TipoDocumento";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "Catalog_De_Tipo_Doc.aspx";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Consultas";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Consultar Cambs";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "DetallesCambs.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Consultar Marcas";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "DetallesMarcas.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Consultar Modelos";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "DetalleModelos.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Consultar Proveedores";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "DetallesProveedores.aspx";
         Gxm1gpxmenuitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm2rootcol.Add(Gxm1gpxmenuitems, 0);
         Gxm1gpxmenuitems.gxTpr_Title = "Reportes";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Reporte de Cambs";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "apdf_cambs.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Reporte de Marcas";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "apdf_marcas.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Reporte de Modelos";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "apdf_Modelos.aspx";
         Gxm3gpxmenuitems_subitems = new SdtgpxMenuItems_gpxMenuItem(context);
         Gxm1gpxmenuitems.gxTpr_Subitems.Add(Gxm3gpxmenuitems_subitems, 0);
         Gxm3gpxmenuitems_subitems.gxTpr_Title = "Reporte de Proveedores";
         Gxm3gpxmenuitems_subitems.gxTpr_Url = "apdf_proveedores.aspx";
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private IGxCollection aP0_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtgpxMenuItems_gpxMenuItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtgpxMenuItems_gpxMenuItem Gxm1gpxmenuitems ;
      private SdtgpxMenuItems_gpxMenuItem Gxm3gpxmenuitems_subitems ;
   }

}
