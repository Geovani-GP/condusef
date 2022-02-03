using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"aloadeventssampleproc", "dll");
      sc.Add( @"aschedulerrequesthandler", "dll");
      sc.Add( @"areport_categorias", "dll");
      sc.Add( @"acategorias_reporte", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"login", "dll");
      sc.Add( @"menuprincipal", "dll");
      sc.Add( @"catalog_de_cambs", "dll");
      sc.Add( @"catalog_de_marcas", "dll");
      sc.Add( @"catalog_de_modelo", "dll");
      sc.Add( @"catalog_de_tipo_doc", "dll");
      sc.Add( @"catalog_de_articulo", "dll");
      sc.Add( @"catalog_de_status", "dll");
      sc.Add( @"catalog_de_entidad_federativa", "dll");
      sc.Add( @"catalog_de_area", "dll");
      sc.Add( @"catalog_de_categorias", "dll");
      sc.Add( @"catalog_de_origen", "dll");
      sc.Add( @"gx0010", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"gx0060", "dll");
      sc.Add( @"gx0070", "dll");
      sc.Add( @"gx0080", "dll");
      sc.Add( @"gx00j0", "dll");
      sc.Add( @"gx00a0", "dll");
      sc.Add( @"gx00b0", "dll");
      sc.Add( @"gx00e0", "dll");
      sc.Add( @"gx00g0", "dll");
      sc.Add( @"gx00i0", "dll");
      sc.Add( @"gx00c0", "dll");
      sc.Add( @"gx00d0", "dll");
      sc.Add( @"gx00f0", "dll");
      sc.Add( @"gx00h0", "dll");
      sc.Add( @"gx00k0", "dll");
      sc.Add( @"gx00l0", "dll");
      sc.Add( @"schedulerdetailsform", "dll");
      sc.Add( @"sidebar", "dll");
      sc.Add( @"detallescambs", "dll");
      sc.Add( @"detallesmarcas", "dll");
      sc.Add( @"detallemodelos", "dll");
      sc.Add( @"detallecategorias", "dll");
      sc.Add( @"detallesorigen", "dll");
      sc.Add( @"catalog_de_productos", "dll");
      sc.Add( @"catalog_de_proveedor", "dll");
      sc.Add( @"catalog_de_almacen", "dll");
      sc.Add( @"catalog_de_tipobien", "dll");
      sc.Add( @"catalog_de_empleados", "dll");
      sc.Add( @"catalog_de_empleados_piso", "dll");
      sc.Add( @"detalletipodocumento", "dll");
      sc.Add( @"detallearticulo", "dll");
      sc.Add( @"detallesestatus", "dll");
      sc.Add( @"detallesentidadfederativa", "dll");
      sc.Add( @"detallesarea", "dll");
      sc.Add( @"gx00n0", "dll");
      sc.Add( @"alerts", "dll");
      sc.Add( @"gx00o0", "dll");
      sc.Add( @"tipobien", "dll");
      sc.Add( @"parametros", "dll");
      sc.Add( @"meses", "dll");
      sc.Add( @"entidadfederativa", "dll");
      sc.Add( @"categorias", "dll");
      sc.Add( @"empleados", "dll");
      sc.Add( @"estatusarticulo", "dll");
      sc.Add( @"marcas", "dll");
      sc.Add( @"producto", "dll");
      sc.Add( @"proveedores", "dll");
      sc.Add( @"articulos", "dll");
      sc.Add( @"etiquetas", "dll");
      sc.Add( @"articulosmov", "dll");
      sc.Add( @"cambs", "dll");
      sc.Add( @"usuarios", "dll");
      sc.Add( @"origen", "dll");
      sc.Add( @"area", "dll");
      sc.Add( @"almacen", "dll");
      sc.Add( @"modelos", "dll");
      sc.Add( @"tipodocumento", "dll");
      sc.Add( @"status", "dll");
      sc.Add( @"empleadospiso", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_Day.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_event.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabsMenuData_TabsMenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabsMenuData_TabsMenuDataItem_SectionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtgpxMenuItems_gpxMenuItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMessages_Message.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtempleadospiso.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtstatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdttipodocumento.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtmodelos.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtalmacen.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtarea.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtorigen.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtcambs.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtproveedores.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtproducto.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtmarcas.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtestatusarticulo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtempleados.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtcategorias.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtentidadfederativa.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdttipobien.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoSignAlgorithm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINAPIAuthorizationStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINProgressIndicatorType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCallTargetSize.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGoogleTableFormatter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINEncoding.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTimezones.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINEffect.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCallType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoEncryptAlgorithm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoHashAlgorithm.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

