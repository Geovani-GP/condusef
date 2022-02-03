using System;
using GeneXus.Builder;
using System.IO;
public class bldareport_categorias : GxBaseBuilder
{
   string cs_path = "." ;
   public bldareport_categorias( ) : base()
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
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldareport_categorias x = new bldareport_categorias() ;
      x.SetMainSourceFile( "areport_categorias.cs");
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
      sc.Add( @"areport_categorias", "dll");
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

