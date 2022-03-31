/*
               File: proveedores_BC
        Description: proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:9.91
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class proveedores_bc : GXHttpHandler, IGxSilentTrn
   {
      public proveedores_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public proveedores_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow0A10( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0A10( ) ;
         standaloneModal( ) ;
         AddRow0A10( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z2proveedoresid = A2proveedoresid;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_0A0( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0A10( ) ;
            }
            else
            {
               CheckExtendedTable0A10( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0A10( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0A10( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z126proveedoresnombre = A126proveedoresnombre;
            Z127proveedoresdireccion = A127proveedoresdireccion;
            Z128proveedorescolonia = A128proveedorescolonia;
            Z129proveedorescodigopostal = A129proveedorescodigopostal;
            Z130proveedoresmunicipio = A130proveedoresmunicipio;
            Z131proveedorestado = A131proveedorestado;
            Z132proveedorestelefono1 = A132proveedorestelefono1;
            Z133proveedorestelefono2 = A133proveedorestelefono2;
            Z134proveedoresfax = A134proveedoresfax;
            Z135proveedoresrfc = A135proveedoresrfc;
            Z136proveedoresusuario = A136proveedoresusuario;
            Z137proveedoresfecreg = A137proveedoresfecreg;
            Z138proveedoresfecultact = A138proveedoresfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z2proveedoresid = A2proveedoresid;
            Z126proveedoresnombre = A126proveedoresnombre;
            Z127proveedoresdireccion = A127proveedoresdireccion;
            Z128proveedorescolonia = A128proveedorescolonia;
            Z129proveedorescodigopostal = A129proveedorescodigopostal;
            Z130proveedoresmunicipio = A130proveedoresmunicipio;
            Z131proveedorestado = A131proveedorestado;
            Z132proveedorestelefono1 = A132proveedorestelefono1;
            Z133proveedorestelefono2 = A133proveedorestelefono2;
            Z134proveedoresfax = A134proveedoresfax;
            Z135proveedoresrfc = A135proveedoresrfc;
            Z136proveedoresusuario = A136proveedoresusuario;
            Z137proveedoresfecreg = A137proveedoresfecreg;
            Z138proveedoresfecultact = A138proveedoresfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0A10( )
      {
         /* Using cursor BC000A4 */
         pr_default.execute(2, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1;
            A126proveedoresnombre = BC000A4_A126proveedoresnombre[0];
            n126proveedoresnombre = BC000A4_n126proveedoresnombre[0];
            A127proveedoresdireccion = BC000A4_A127proveedoresdireccion[0];
            n127proveedoresdireccion = BC000A4_n127proveedoresdireccion[0];
            A128proveedorescolonia = BC000A4_A128proveedorescolonia[0];
            n128proveedorescolonia = BC000A4_n128proveedorescolonia[0];
            A129proveedorescodigopostal = BC000A4_A129proveedorescodigopostal[0];
            n129proveedorescodigopostal = BC000A4_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = BC000A4_A130proveedoresmunicipio[0];
            n130proveedoresmunicipio = BC000A4_n130proveedoresmunicipio[0];
            A131proveedorestado = BC000A4_A131proveedorestado[0];
            n131proveedorestado = BC000A4_n131proveedorestado[0];
            A132proveedorestelefono1 = BC000A4_A132proveedorestelefono1[0];
            n132proveedorestelefono1 = BC000A4_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = BC000A4_A133proveedorestelefono2[0];
            n133proveedorestelefono2 = BC000A4_n133proveedorestelefono2[0];
            A134proveedoresfax = BC000A4_A134proveedoresfax[0];
            n134proveedoresfax = BC000A4_n134proveedoresfax[0];
            A135proveedoresrfc = BC000A4_A135proveedoresrfc[0];
            n135proveedoresrfc = BC000A4_n135proveedoresrfc[0];
            A136proveedoresusuario = BC000A4_A136proveedoresusuario[0];
            n136proveedoresusuario = BC000A4_n136proveedoresusuario[0];
            A137proveedoresfecreg = BC000A4_A137proveedoresfecreg[0];
            n137proveedoresfecreg = BC000A4_n137proveedoresfecreg[0];
            A138proveedoresfecultact = BC000A4_A138proveedoresfecultact[0];
            n138proveedoresfecultact = BC000A4_n138proveedoresfecultact[0];
            ZM0A10( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0A10( ) ;
      }

      protected void OnLoadActions0A10( )
      {
      }

      protected void CheckExtendedTable0A10( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0A10( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0A10( )
      {
         /* Using cursor BC000A5 */
         pr_default.execute(3, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000A3 */
         pr_default.execute(1, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A10( 1) ;
            RcdFound10 = 1;
            A2proveedoresid = BC000A3_A2proveedoresid[0];
            n2proveedoresid = BC000A3_n2proveedoresid[0];
            A126proveedoresnombre = BC000A3_A126proveedoresnombre[0];
            n126proveedoresnombre = BC000A3_n126proveedoresnombre[0];
            A127proveedoresdireccion = BC000A3_A127proveedoresdireccion[0];
            n127proveedoresdireccion = BC000A3_n127proveedoresdireccion[0];
            A128proveedorescolonia = BC000A3_A128proveedorescolonia[0];
            n128proveedorescolonia = BC000A3_n128proveedorescolonia[0];
            A129proveedorescodigopostal = BC000A3_A129proveedorescodigopostal[0];
            n129proveedorescodigopostal = BC000A3_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = BC000A3_A130proveedoresmunicipio[0];
            n130proveedoresmunicipio = BC000A3_n130proveedoresmunicipio[0];
            A131proveedorestado = BC000A3_A131proveedorestado[0];
            n131proveedorestado = BC000A3_n131proveedorestado[0];
            A132proveedorestelefono1 = BC000A3_A132proveedorestelefono1[0];
            n132proveedorestelefono1 = BC000A3_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = BC000A3_A133proveedorestelefono2[0];
            n133proveedorestelefono2 = BC000A3_n133proveedorestelefono2[0];
            A134proveedoresfax = BC000A3_A134proveedoresfax[0];
            n134proveedoresfax = BC000A3_n134proveedoresfax[0];
            A135proveedoresrfc = BC000A3_A135proveedoresrfc[0];
            n135proveedoresrfc = BC000A3_n135proveedoresrfc[0];
            A136proveedoresusuario = BC000A3_A136proveedoresusuario[0];
            n136proveedoresusuario = BC000A3_n136proveedoresusuario[0];
            A137proveedoresfecreg = BC000A3_A137proveedoresfecreg[0];
            n137proveedoresfecreg = BC000A3_n137proveedoresfecreg[0];
            A138proveedoresfecultact = BC000A3_A138proveedoresfecultact[0];
            n138proveedoresfecultact = BC000A3_n138proveedoresfecultact[0];
            Z2proveedoresid = A2proveedoresid;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0A10( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0A10( ) ;
            }
            Gx_mode = sMode10;
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0A10( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode10;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_0A0( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000A2 */
            pr_default.execute(0, new Object[] {n2proveedoresid, A2proveedoresid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PROVEEDORES"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z126proveedoresnombre, BC000A2_A126proveedoresnombre[0]) != 0 ) || ( StringUtil.StrCmp(Z127proveedoresdireccion, BC000A2_A127proveedoresdireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z128proveedorescolonia, BC000A2_A128proveedorescolonia[0]) != 0 ) || ( StringUtil.StrCmp(Z129proveedorescodigopostal, BC000A2_A129proveedorescodigopostal[0]) != 0 ) || ( StringUtil.StrCmp(Z130proveedoresmunicipio, BC000A2_A130proveedoresmunicipio[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z131proveedorestado, BC000A2_A131proveedorestado[0]) != 0 ) || ( Z132proveedorestelefono1 != BC000A2_A132proveedorestelefono1[0] ) || ( Z133proveedorestelefono2 != BC000A2_A133proveedorestelefono2[0] ) || ( StringUtil.StrCmp(Z134proveedoresfax, BC000A2_A134proveedoresfax[0]) != 0 ) || ( StringUtil.StrCmp(Z135proveedoresrfc, BC000A2_A135proveedoresrfc[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z136proveedoresusuario, BC000A2_A136proveedoresusuario[0]) != 0 ) || ( Z137proveedoresfecreg != BC000A2_A137proveedoresfecreg[0] ) || ( Z138proveedoresfecultact != BC000A2_A138proveedoresfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PROVEEDORES"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A10( 0) ;
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000A6 */
                     pr_default.execute(4, new Object[] {n2proveedoresid, A2proveedoresid, n126proveedoresnombre, A126proveedoresnombre, n127proveedoresdireccion, A127proveedoresdireccion, n128proveedorescolonia, A128proveedorescolonia, n129proveedorescodigopostal, A129proveedorescodigopostal, n130proveedoresmunicipio, A130proveedoresmunicipio, n131proveedorestado, A131proveedorestado, n132proveedorestelefono1, A132proveedorestelefono1, n133proveedorestelefono2, A133proveedorestelefono2, n134proveedoresfax, A134proveedoresfax, n135proveedoresrfc, A135proveedoresrfc, n136proveedoresusuario, A136proveedoresusuario, n137proveedoresfecreg, A137proveedoresfecreg, n138proveedoresfecultact, A138proveedoresfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
                     if ( (pr_default.getStatus(4) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0A10( ) ;
            }
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void Update0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000A7 */
                     pr_default.execute(5, new Object[] {n126proveedoresnombre, A126proveedoresnombre, n127proveedoresdireccion, A127proveedoresdireccion, n128proveedorescolonia, A128proveedorescolonia, n129proveedorescodigopostal, A129proveedorescodigopostal, n130proveedoresmunicipio, A130proveedoresmunicipio, n131proveedorestado, A131proveedorestado, n132proveedorestelefono1, A132proveedorestelefono1, n133proveedorestelefono2, A133proveedorestelefono2, n134proveedoresfax, A134proveedoresfax, n135proveedoresrfc, A135proveedoresrfc, n136proveedoresusuario, A136proveedoresusuario, n137proveedoresfecreg, A137proveedoresfecreg, n138proveedoresfecultact, A138proveedoresfecultact, n2proveedoresid, A2proveedoresid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PROVEEDORES"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A10( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void DeferredUpdate0A10( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A10( ) ;
            AfterConfirm0A10( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A10( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000A8 */
                  pr_default.execute(6, new Object[] {n2proveedoresid, A2proveedoresid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0A10( ) ;
         Gx_mode = sMode10;
      }

      protected void OnDeleteControls0A10( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000A9 */
            pr_default.execute(7, new Object[] {n2proveedoresid, A2proveedoresid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart0A10( )
      {
         /* Using cursor BC000A10 */
         pr_default.execute(8, new Object[] {n2proveedoresid, A2proveedoresid});
         RcdFound10 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound10 = 1;
            A2proveedoresid = BC000A10_A2proveedoresid[0];
            n2proveedoresid = BC000A10_n2proveedoresid[0];
            A126proveedoresnombre = BC000A10_A126proveedoresnombre[0];
            n126proveedoresnombre = BC000A10_n126proveedoresnombre[0];
            A127proveedoresdireccion = BC000A10_A127proveedoresdireccion[0];
            n127proveedoresdireccion = BC000A10_n127proveedoresdireccion[0];
            A128proveedorescolonia = BC000A10_A128proveedorescolonia[0];
            n128proveedorescolonia = BC000A10_n128proveedorescolonia[0];
            A129proveedorescodigopostal = BC000A10_A129proveedorescodigopostal[0];
            n129proveedorescodigopostal = BC000A10_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = BC000A10_A130proveedoresmunicipio[0];
            n130proveedoresmunicipio = BC000A10_n130proveedoresmunicipio[0];
            A131proveedorestado = BC000A10_A131proveedorestado[0];
            n131proveedorestado = BC000A10_n131proveedorestado[0];
            A132proveedorestelefono1 = BC000A10_A132proveedorestelefono1[0];
            n132proveedorestelefono1 = BC000A10_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = BC000A10_A133proveedorestelefono2[0];
            n133proveedorestelefono2 = BC000A10_n133proveedorestelefono2[0];
            A134proveedoresfax = BC000A10_A134proveedoresfax[0];
            n134proveedoresfax = BC000A10_n134proveedoresfax[0];
            A135proveedoresrfc = BC000A10_A135proveedoresrfc[0];
            n135proveedoresrfc = BC000A10_n135proveedoresrfc[0];
            A136proveedoresusuario = BC000A10_A136proveedoresusuario[0];
            n136proveedoresusuario = BC000A10_n136proveedoresusuario[0];
            A137proveedoresfecreg = BC000A10_A137proveedoresfecreg[0];
            n137proveedoresfecreg = BC000A10_n137proveedoresfecreg[0];
            A138proveedoresfecultact = BC000A10_A138proveedoresfecultact[0];
            n138proveedoresfecultact = BC000A10_n138proveedoresfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0A10( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound10 = 0;
         ScanKeyLoad0A10( ) ;
      }

      protected void ScanKeyLoad0A10( )
      {
         sMode10 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound10 = 1;
            A2proveedoresid = BC000A10_A2proveedoresid[0];
            n2proveedoresid = BC000A10_n2proveedoresid[0];
            A126proveedoresnombre = BC000A10_A126proveedoresnombre[0];
            n126proveedoresnombre = BC000A10_n126proveedoresnombre[0];
            A127proveedoresdireccion = BC000A10_A127proveedoresdireccion[0];
            n127proveedoresdireccion = BC000A10_n127proveedoresdireccion[0];
            A128proveedorescolonia = BC000A10_A128proveedorescolonia[0];
            n128proveedorescolonia = BC000A10_n128proveedorescolonia[0];
            A129proveedorescodigopostal = BC000A10_A129proveedorescodigopostal[0];
            n129proveedorescodigopostal = BC000A10_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = BC000A10_A130proveedoresmunicipio[0];
            n130proveedoresmunicipio = BC000A10_n130proveedoresmunicipio[0];
            A131proveedorestado = BC000A10_A131proveedorestado[0];
            n131proveedorestado = BC000A10_n131proveedorestado[0];
            A132proveedorestelefono1 = BC000A10_A132proveedorestelefono1[0];
            n132proveedorestelefono1 = BC000A10_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = BC000A10_A133proveedorestelefono2[0];
            n133proveedorestelefono2 = BC000A10_n133proveedorestelefono2[0];
            A134proveedoresfax = BC000A10_A134proveedoresfax[0];
            n134proveedoresfax = BC000A10_n134proveedoresfax[0];
            A135proveedoresrfc = BC000A10_A135proveedoresrfc[0];
            n135proveedoresrfc = BC000A10_n135proveedoresrfc[0];
            A136proveedoresusuario = BC000A10_A136proveedoresusuario[0];
            n136proveedoresusuario = BC000A10_n136proveedoresusuario[0];
            A137proveedoresfecreg = BC000A10_A137proveedoresfecreg[0];
            n137proveedoresfecreg = BC000A10_n137proveedoresfecreg[0];
            A138proveedoresfecultact = BC000A10_A138proveedoresfecultact[0];
            n138proveedoresfecultact = BC000A10_n138proveedoresfecultact[0];
         }
         Gx_mode = sMode10;
      }

      protected void ScanKeyEnd0A10( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0A10( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A10( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A10( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A10( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A10( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A10( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A10( )
      {
      }

      protected void AddRow0A10( )
      {
         VarsToRow10( bcproveedores) ;
      }

      protected void ReadRow0A10( )
      {
         RowToVars10( bcproveedores, 1) ;
      }

      protected void InitializeNonKey0A10( )
      {
         A126proveedoresnombre = "";
         n126proveedoresnombre = false;
         A127proveedoresdireccion = "";
         n127proveedoresdireccion = false;
         A128proveedorescolonia = "";
         n128proveedorescolonia = false;
         A129proveedorescodigopostal = "";
         n129proveedorescodigopostal = false;
         A130proveedoresmunicipio = "";
         n130proveedoresmunicipio = false;
         A131proveedorestado = "";
         n131proveedorestado = false;
         A132proveedorestelefono1 = 0;
         n132proveedorestelefono1 = false;
         A133proveedorestelefono2 = 0;
         n133proveedorestelefono2 = false;
         A134proveedoresfax = "";
         n134proveedoresfax = false;
         A135proveedoresrfc = "";
         n135proveedoresrfc = false;
         A136proveedoresusuario = "";
         n136proveedoresusuario = false;
         A137proveedoresfecreg = DateTime.MinValue;
         n137proveedoresfecreg = false;
         A138proveedoresfecultact = DateTime.MinValue;
         n138proveedoresfecultact = false;
         Z126proveedoresnombre = "";
         Z127proveedoresdireccion = "";
         Z128proveedorescolonia = "";
         Z129proveedorescodigopostal = "";
         Z130proveedoresmunicipio = "";
         Z131proveedorestado = "";
         Z132proveedorestelefono1 = 0;
         Z133proveedorestelefono2 = 0;
         Z134proveedoresfax = "";
         Z135proveedoresrfc = "";
         Z136proveedoresusuario = "";
         Z137proveedoresfecreg = DateTime.MinValue;
         Z138proveedoresfecultact = DateTime.MinValue;
      }

      protected void InitAll0A10( )
      {
         A2proveedoresid = 0;
         n2proveedoresid = false;
         InitializeNonKey0A10( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow10( Sdtproveedores obj10 )
      {
         obj10.gxTpr_Mode = Gx_mode;
         obj10.gxTpr_Proveedoresnombre = A126proveedoresnombre;
         obj10.gxTpr_Proveedoresdireccion = A127proveedoresdireccion;
         obj10.gxTpr_Proveedorescolonia = A128proveedorescolonia;
         obj10.gxTpr_Proveedorescodigopostal = A129proveedorescodigopostal;
         obj10.gxTpr_Proveedoresmunicipio = A130proveedoresmunicipio;
         obj10.gxTpr_Proveedorestado = A131proveedorestado;
         obj10.gxTpr_Proveedorestelefono1 = A132proveedorestelefono1;
         obj10.gxTpr_Proveedorestelefono2 = A133proveedorestelefono2;
         obj10.gxTpr_Proveedoresfax = A134proveedoresfax;
         obj10.gxTpr_Proveedoresrfc = A135proveedoresrfc;
         obj10.gxTpr_Proveedoresusuario = A136proveedoresusuario;
         obj10.gxTpr_Proveedoresfecreg = A137proveedoresfecreg;
         obj10.gxTpr_Proveedoresfecultact = A138proveedoresfecultact;
         obj10.gxTpr_Proveedoresid = A2proveedoresid;
         obj10.gxTpr_Proveedoresid_Z = Z2proveedoresid;
         obj10.gxTpr_Proveedoresnombre_Z = Z126proveedoresnombre;
         obj10.gxTpr_Proveedoresdireccion_Z = Z127proveedoresdireccion;
         obj10.gxTpr_Proveedorescolonia_Z = Z128proveedorescolonia;
         obj10.gxTpr_Proveedorescodigopostal_Z = Z129proveedorescodigopostal;
         obj10.gxTpr_Proveedoresmunicipio_Z = Z130proveedoresmunicipio;
         obj10.gxTpr_Proveedorestado_Z = Z131proveedorestado;
         obj10.gxTpr_Proveedorestelefono1_Z = Z132proveedorestelefono1;
         obj10.gxTpr_Proveedorestelefono2_Z = Z133proveedorestelefono2;
         obj10.gxTpr_Proveedoresfax_Z = Z134proveedoresfax;
         obj10.gxTpr_Proveedoresrfc_Z = Z135proveedoresrfc;
         obj10.gxTpr_Proveedoresusuario_Z = Z136proveedoresusuario;
         obj10.gxTpr_Proveedoresfecreg_Z = Z137proveedoresfecreg;
         obj10.gxTpr_Proveedoresfecultact_Z = Z138proveedoresfecultact;
         obj10.gxTpr_Proveedoresid_N = (short)(Convert.ToInt16(n2proveedoresid));
         obj10.gxTpr_Proveedoresnombre_N = (short)(Convert.ToInt16(n126proveedoresnombre));
         obj10.gxTpr_Proveedoresdireccion_N = (short)(Convert.ToInt16(n127proveedoresdireccion));
         obj10.gxTpr_Proveedorescolonia_N = (short)(Convert.ToInt16(n128proveedorescolonia));
         obj10.gxTpr_Proveedorescodigopostal_N = (short)(Convert.ToInt16(n129proveedorescodigopostal));
         obj10.gxTpr_Proveedoresmunicipio_N = (short)(Convert.ToInt16(n130proveedoresmunicipio));
         obj10.gxTpr_Proveedorestado_N = (short)(Convert.ToInt16(n131proveedorestado));
         obj10.gxTpr_Proveedorestelefono1_N = (short)(Convert.ToInt16(n132proveedorestelefono1));
         obj10.gxTpr_Proveedorestelefono2_N = (short)(Convert.ToInt16(n133proveedorestelefono2));
         obj10.gxTpr_Proveedoresfax_N = (short)(Convert.ToInt16(n134proveedoresfax));
         obj10.gxTpr_Proveedoresrfc_N = (short)(Convert.ToInt16(n135proveedoresrfc));
         obj10.gxTpr_Proveedoresusuario_N = (short)(Convert.ToInt16(n136proveedoresusuario));
         obj10.gxTpr_Proveedoresfecreg_N = (short)(Convert.ToInt16(n137proveedoresfecreg));
         obj10.gxTpr_Proveedoresfecultact_N = (short)(Convert.ToInt16(n138proveedoresfecultact));
         obj10.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow10( Sdtproveedores obj10 )
      {
         obj10.gxTpr_Proveedoresid = A2proveedoresid;
         return  ;
      }

      public void RowToVars10( Sdtproveedores obj10 ,
                               int forceLoad )
      {
         Gx_mode = obj10.gxTpr_Mode;
         A126proveedoresnombre = obj10.gxTpr_Proveedoresnombre;
         n126proveedoresnombre = false;
         A127proveedoresdireccion = obj10.gxTpr_Proveedoresdireccion;
         n127proveedoresdireccion = false;
         A128proveedorescolonia = obj10.gxTpr_Proveedorescolonia;
         n128proveedorescolonia = false;
         A129proveedorescodigopostal = obj10.gxTpr_Proveedorescodigopostal;
         n129proveedorescodigopostal = false;
         A130proveedoresmunicipio = obj10.gxTpr_Proveedoresmunicipio;
         n130proveedoresmunicipio = false;
         A131proveedorestado = obj10.gxTpr_Proveedorestado;
         n131proveedorestado = false;
         A132proveedorestelefono1 = obj10.gxTpr_Proveedorestelefono1;
         n132proveedorestelefono1 = false;
         A133proveedorestelefono2 = obj10.gxTpr_Proveedorestelefono2;
         n133proveedorestelefono2 = false;
         A134proveedoresfax = obj10.gxTpr_Proveedoresfax;
         n134proveedoresfax = false;
         A135proveedoresrfc = obj10.gxTpr_Proveedoresrfc;
         n135proveedoresrfc = false;
         A136proveedoresusuario = obj10.gxTpr_Proveedoresusuario;
         n136proveedoresusuario = false;
         A137proveedoresfecreg = obj10.gxTpr_Proveedoresfecreg;
         n137proveedoresfecreg = false;
         A138proveedoresfecultact = obj10.gxTpr_Proveedoresfecultact;
         n138proveedoresfecultact = false;
         A2proveedoresid = obj10.gxTpr_Proveedoresid;
         n2proveedoresid = false;
         Z2proveedoresid = obj10.gxTpr_Proveedoresid_Z;
         Z126proveedoresnombre = obj10.gxTpr_Proveedoresnombre_Z;
         Z127proveedoresdireccion = obj10.gxTpr_Proveedoresdireccion_Z;
         Z128proveedorescolonia = obj10.gxTpr_Proveedorescolonia_Z;
         Z129proveedorescodigopostal = obj10.gxTpr_Proveedorescodigopostal_Z;
         Z130proveedoresmunicipio = obj10.gxTpr_Proveedoresmunicipio_Z;
         Z131proveedorestado = obj10.gxTpr_Proveedorestado_Z;
         Z132proveedorestelefono1 = obj10.gxTpr_Proveedorestelefono1_Z;
         Z133proveedorestelefono2 = obj10.gxTpr_Proveedorestelefono2_Z;
         Z134proveedoresfax = obj10.gxTpr_Proveedoresfax_Z;
         Z135proveedoresrfc = obj10.gxTpr_Proveedoresrfc_Z;
         Z136proveedoresusuario = obj10.gxTpr_Proveedoresusuario_Z;
         Z137proveedoresfecreg = obj10.gxTpr_Proveedoresfecreg_Z;
         Z138proveedoresfecultact = obj10.gxTpr_Proveedoresfecultact_Z;
         n2proveedoresid = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresid_N));
         n126proveedoresnombre = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresnombre_N));
         n127proveedoresdireccion = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresdireccion_N));
         n128proveedorescolonia = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedorescolonia_N));
         n129proveedorescodigopostal = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedorescodigopostal_N));
         n130proveedoresmunicipio = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresmunicipio_N));
         n131proveedorestado = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedorestado_N));
         n132proveedorestelefono1 = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedorestelefono1_N));
         n133proveedorestelefono2 = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedorestelefono2_N));
         n134proveedoresfax = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresfax_N));
         n135proveedoresrfc = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresrfc_N));
         n136proveedoresusuario = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresusuario_N));
         n137proveedoresfecreg = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresfecreg_N));
         n138proveedoresfecultact = (bool)(Convert.ToBoolean(obj10.gxTpr_Proveedoresfecultact_N));
         Gx_mode = obj10.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A2proveedoresid = (int)getParm(obj,0);
         n2proveedoresid = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0A10( ) ;
         ScanKeyStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2proveedoresid = A2proveedoresid;
         }
         ZM0A10( -1) ;
         OnLoadActions0A10( ) ;
         AddRow0A10( ) ;
         ScanKeyEnd0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars10( bcproveedores, 0) ;
         ScanKeyStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2proveedoresid = A2proveedoresid;
         }
         ZM0A10( -1) ;
         OnLoadActions0A10( ) ;
         AddRow0A10( ) ;
         ScanKeyEnd0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars10( bcproveedores, 0) ;
         nKeyPressed = 1;
         GetKey0A10( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0A10( ) ;
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A2proveedoresid != Z2proveedoresid )
               {
                  A2proveedoresid = Z2proveedoresid;
                  n2proveedoresid = false;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update0A10( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A2proveedoresid != Z2proveedoresid )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0A10( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0A10( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow10( bcproveedores) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars10( bcproveedores, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0A10( ) ;
         if ( RcdFound10 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A2proveedoresid != Z2proveedoresid )
            {
               A2proveedoresid = Z2proveedoresid;
               n2proveedoresid = false;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A2proveedoresid != Z2proveedoresid )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         context.RollbackDataStores( "proveedores_BC");
         VarsToRow10( bcproveedores) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcproveedores.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcproveedores.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcproveedores )
         {
            bcproveedores = (Sdtproveedores)(sdt);
            if ( StringUtil.StrCmp(bcproveedores.gxTpr_Mode, "") == 0 )
            {
               bcproveedores.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow10( bcproveedores) ;
            }
            else
            {
               RowToVars10( bcproveedores, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcproveedores.gxTpr_Mode, "") == 0 )
            {
               bcproveedores.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars10( bcproveedores, 1) ;
         return  ;
      }

      public Sdtproveedores proveedores_BC
      {
         get {
            return bcproveedores ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z126proveedoresnombre = "";
         A126proveedoresnombre = "";
         Z127proveedoresdireccion = "";
         A127proveedoresdireccion = "";
         Z128proveedorescolonia = "";
         A128proveedorescolonia = "";
         Z129proveedorescodigopostal = "";
         A129proveedorescodigopostal = "";
         Z130proveedoresmunicipio = "";
         A130proveedoresmunicipio = "";
         Z131proveedorestado = "";
         A131proveedorestado = "";
         Z134proveedoresfax = "";
         A134proveedoresfax = "";
         Z135proveedoresrfc = "";
         A135proveedoresrfc = "";
         Z136proveedoresusuario = "";
         A136proveedoresusuario = "";
         Z137proveedoresfecreg = DateTime.MinValue;
         A137proveedoresfecreg = DateTime.MinValue;
         Z138proveedoresfecultact = DateTime.MinValue;
         A138proveedoresfecultact = DateTime.MinValue;
         BC000A4_A2proveedoresid = new int[1] ;
         BC000A4_n2proveedoresid = new bool[] {false} ;
         BC000A4_A126proveedoresnombre = new String[] {""} ;
         BC000A4_n126proveedoresnombre = new bool[] {false} ;
         BC000A4_A127proveedoresdireccion = new String[] {""} ;
         BC000A4_n127proveedoresdireccion = new bool[] {false} ;
         BC000A4_A128proveedorescolonia = new String[] {""} ;
         BC000A4_n128proveedorescolonia = new bool[] {false} ;
         BC000A4_A129proveedorescodigopostal = new String[] {""} ;
         BC000A4_n129proveedorescodigopostal = new bool[] {false} ;
         BC000A4_A130proveedoresmunicipio = new String[] {""} ;
         BC000A4_n130proveedoresmunicipio = new bool[] {false} ;
         BC000A4_A131proveedorestado = new String[] {""} ;
         BC000A4_n131proveedorestado = new bool[] {false} ;
         BC000A4_A132proveedorestelefono1 = new long[1] ;
         BC000A4_n132proveedorestelefono1 = new bool[] {false} ;
         BC000A4_A133proveedorestelefono2 = new long[1] ;
         BC000A4_n133proveedorestelefono2 = new bool[] {false} ;
         BC000A4_A134proveedoresfax = new String[] {""} ;
         BC000A4_n134proveedoresfax = new bool[] {false} ;
         BC000A4_A135proveedoresrfc = new String[] {""} ;
         BC000A4_n135proveedoresrfc = new bool[] {false} ;
         BC000A4_A136proveedoresusuario = new String[] {""} ;
         BC000A4_n136proveedoresusuario = new bool[] {false} ;
         BC000A4_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000A4_n137proveedoresfecreg = new bool[] {false} ;
         BC000A4_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000A4_n138proveedoresfecultact = new bool[] {false} ;
         BC000A5_A2proveedoresid = new int[1] ;
         BC000A5_n2proveedoresid = new bool[] {false} ;
         BC000A3_A2proveedoresid = new int[1] ;
         BC000A3_n2proveedoresid = new bool[] {false} ;
         BC000A3_A126proveedoresnombre = new String[] {""} ;
         BC000A3_n126proveedoresnombre = new bool[] {false} ;
         BC000A3_A127proveedoresdireccion = new String[] {""} ;
         BC000A3_n127proveedoresdireccion = new bool[] {false} ;
         BC000A3_A128proveedorescolonia = new String[] {""} ;
         BC000A3_n128proveedorescolonia = new bool[] {false} ;
         BC000A3_A129proveedorescodigopostal = new String[] {""} ;
         BC000A3_n129proveedorescodigopostal = new bool[] {false} ;
         BC000A3_A130proveedoresmunicipio = new String[] {""} ;
         BC000A3_n130proveedoresmunicipio = new bool[] {false} ;
         BC000A3_A131proveedorestado = new String[] {""} ;
         BC000A3_n131proveedorestado = new bool[] {false} ;
         BC000A3_A132proveedorestelefono1 = new long[1] ;
         BC000A3_n132proveedorestelefono1 = new bool[] {false} ;
         BC000A3_A133proveedorestelefono2 = new long[1] ;
         BC000A3_n133proveedorestelefono2 = new bool[] {false} ;
         BC000A3_A134proveedoresfax = new String[] {""} ;
         BC000A3_n134proveedoresfax = new bool[] {false} ;
         BC000A3_A135proveedoresrfc = new String[] {""} ;
         BC000A3_n135proveedoresrfc = new bool[] {false} ;
         BC000A3_A136proveedoresusuario = new String[] {""} ;
         BC000A3_n136proveedoresusuario = new bool[] {false} ;
         BC000A3_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000A3_n137proveedoresfecreg = new bool[] {false} ;
         BC000A3_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000A3_n138proveedoresfecultact = new bool[] {false} ;
         sMode10 = "";
         BC000A2_A2proveedoresid = new int[1] ;
         BC000A2_n2proveedoresid = new bool[] {false} ;
         BC000A2_A126proveedoresnombre = new String[] {""} ;
         BC000A2_n126proveedoresnombre = new bool[] {false} ;
         BC000A2_A127proveedoresdireccion = new String[] {""} ;
         BC000A2_n127proveedoresdireccion = new bool[] {false} ;
         BC000A2_A128proveedorescolonia = new String[] {""} ;
         BC000A2_n128proveedorescolonia = new bool[] {false} ;
         BC000A2_A129proveedorescodigopostal = new String[] {""} ;
         BC000A2_n129proveedorescodigopostal = new bool[] {false} ;
         BC000A2_A130proveedoresmunicipio = new String[] {""} ;
         BC000A2_n130proveedoresmunicipio = new bool[] {false} ;
         BC000A2_A131proveedorestado = new String[] {""} ;
         BC000A2_n131proveedorestado = new bool[] {false} ;
         BC000A2_A132proveedorestelefono1 = new long[1] ;
         BC000A2_n132proveedorestelefono1 = new bool[] {false} ;
         BC000A2_A133proveedorestelefono2 = new long[1] ;
         BC000A2_n133proveedorestelefono2 = new bool[] {false} ;
         BC000A2_A134proveedoresfax = new String[] {""} ;
         BC000A2_n134proveedoresfax = new bool[] {false} ;
         BC000A2_A135proveedoresrfc = new String[] {""} ;
         BC000A2_n135proveedoresrfc = new bool[] {false} ;
         BC000A2_A136proveedoresusuario = new String[] {""} ;
         BC000A2_n136proveedoresusuario = new bool[] {false} ;
         BC000A2_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000A2_n137proveedoresfecreg = new bool[] {false} ;
         BC000A2_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000A2_n138proveedoresfecultact = new bool[] {false} ;
         BC000A9_A19almacenid = new int[1] ;
         BC000A9_A20articulosproductoid = new int[1] ;
         BC000A9_A21articuloscambsid = new int[1] ;
         BC000A10_A2proveedoresid = new int[1] ;
         BC000A10_n2proveedoresid = new bool[] {false} ;
         BC000A10_A126proveedoresnombre = new String[] {""} ;
         BC000A10_n126proveedoresnombre = new bool[] {false} ;
         BC000A10_A127proveedoresdireccion = new String[] {""} ;
         BC000A10_n127proveedoresdireccion = new bool[] {false} ;
         BC000A10_A128proveedorescolonia = new String[] {""} ;
         BC000A10_n128proveedorescolonia = new bool[] {false} ;
         BC000A10_A129proveedorescodigopostal = new String[] {""} ;
         BC000A10_n129proveedorescodigopostal = new bool[] {false} ;
         BC000A10_A130proveedoresmunicipio = new String[] {""} ;
         BC000A10_n130proveedoresmunicipio = new bool[] {false} ;
         BC000A10_A131proveedorestado = new String[] {""} ;
         BC000A10_n131proveedorestado = new bool[] {false} ;
         BC000A10_A132proveedorestelefono1 = new long[1] ;
         BC000A10_n132proveedorestelefono1 = new bool[] {false} ;
         BC000A10_A133proveedorestelefono2 = new long[1] ;
         BC000A10_n133proveedorestelefono2 = new bool[] {false} ;
         BC000A10_A134proveedoresfax = new String[] {""} ;
         BC000A10_n134proveedoresfax = new bool[] {false} ;
         BC000A10_A135proveedoresrfc = new String[] {""} ;
         BC000A10_n135proveedoresrfc = new bool[] {false} ;
         BC000A10_A136proveedoresusuario = new String[] {""} ;
         BC000A10_n136proveedoresusuario = new bool[] {false} ;
         BC000A10_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000A10_n137proveedoresfecreg = new bool[] {false} ;
         BC000A10_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000A10_n138proveedoresfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proveedores_bc__default(),
            new Object[][] {
                new Object[] {
               BC000A2_A2proveedoresid, BC000A2_A126proveedoresnombre, BC000A2_n126proveedoresnombre, BC000A2_A127proveedoresdireccion, BC000A2_n127proveedoresdireccion, BC000A2_A128proveedorescolonia, BC000A2_n128proveedorescolonia, BC000A2_A129proveedorescodigopostal, BC000A2_n129proveedorescodigopostal, BC000A2_A130proveedoresmunicipio,
               BC000A2_n130proveedoresmunicipio, BC000A2_A131proveedorestado, BC000A2_n131proveedorestado, BC000A2_A132proveedorestelefono1, BC000A2_n132proveedorestelefono1, BC000A2_A133proveedorestelefono2, BC000A2_n133proveedorestelefono2, BC000A2_A134proveedoresfax, BC000A2_n134proveedoresfax, BC000A2_A135proveedoresrfc,
               BC000A2_n135proveedoresrfc, BC000A2_A136proveedoresusuario, BC000A2_n136proveedoresusuario, BC000A2_A137proveedoresfecreg, BC000A2_n137proveedoresfecreg, BC000A2_A138proveedoresfecultact, BC000A2_n138proveedoresfecultact
               }
               , new Object[] {
               BC000A3_A2proveedoresid, BC000A3_A126proveedoresnombre, BC000A3_n126proveedoresnombre, BC000A3_A127proveedoresdireccion, BC000A3_n127proveedoresdireccion, BC000A3_A128proveedorescolonia, BC000A3_n128proveedorescolonia, BC000A3_A129proveedorescodigopostal, BC000A3_n129proveedorescodigopostal, BC000A3_A130proveedoresmunicipio,
               BC000A3_n130proveedoresmunicipio, BC000A3_A131proveedorestado, BC000A3_n131proveedorestado, BC000A3_A132proveedorestelefono1, BC000A3_n132proveedorestelefono1, BC000A3_A133proveedorestelefono2, BC000A3_n133proveedorestelefono2, BC000A3_A134proveedoresfax, BC000A3_n134proveedoresfax, BC000A3_A135proveedoresrfc,
               BC000A3_n135proveedoresrfc, BC000A3_A136proveedoresusuario, BC000A3_n136proveedoresusuario, BC000A3_A137proveedoresfecreg, BC000A3_n137proveedoresfecreg, BC000A3_A138proveedoresfecultact, BC000A3_n138proveedoresfecultact
               }
               , new Object[] {
               BC000A4_A2proveedoresid, BC000A4_A126proveedoresnombre, BC000A4_n126proveedoresnombre, BC000A4_A127proveedoresdireccion, BC000A4_n127proveedoresdireccion, BC000A4_A128proveedorescolonia, BC000A4_n128proveedorescolonia, BC000A4_A129proveedorescodigopostal, BC000A4_n129proveedorescodigopostal, BC000A4_A130proveedoresmunicipio,
               BC000A4_n130proveedoresmunicipio, BC000A4_A131proveedorestado, BC000A4_n131proveedorestado, BC000A4_A132proveedorestelefono1, BC000A4_n132proveedorestelefono1, BC000A4_A133proveedorestelefono2, BC000A4_n133proveedorestelefono2, BC000A4_A134proveedoresfax, BC000A4_n134proveedoresfax, BC000A4_A135proveedoresrfc,
               BC000A4_n135proveedoresrfc, BC000A4_A136proveedoresusuario, BC000A4_n136proveedoresusuario, BC000A4_A137proveedoresfecreg, BC000A4_n137proveedoresfecreg, BC000A4_A138proveedoresfecultact, BC000A4_n138proveedoresfecultact
               }
               , new Object[] {
               BC000A5_A2proveedoresid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000A9_A19almacenid, BC000A9_A20articulosproductoid, BC000A9_A21articuloscambsid
               }
               , new Object[] {
               BC000A10_A2proveedoresid, BC000A10_A126proveedoresnombre, BC000A10_n126proveedoresnombre, BC000A10_A127proveedoresdireccion, BC000A10_n127proveedoresdireccion, BC000A10_A128proveedorescolonia, BC000A10_n128proveedorescolonia, BC000A10_A129proveedorescodigopostal, BC000A10_n129proveedorescodigopostal, BC000A10_A130proveedoresmunicipio,
               BC000A10_n130proveedoresmunicipio, BC000A10_A131proveedorestado, BC000A10_n131proveedorestado, BC000A10_A132proveedorestelefono1, BC000A10_n132proveedorestelefono1, BC000A10_A133proveedorestelefono2, BC000A10_n133proveedorestelefono2, BC000A10_A134proveedoresfax, BC000A10_n134proveedoresfax, BC000A10_A135proveedoresrfc,
               BC000A10_n135proveedoresrfc, BC000A10_A136proveedoresusuario, BC000A10_n136proveedoresusuario, BC000A10_A137proveedoresfecreg, BC000A10_n137proveedoresfecreg, BC000A10_A138proveedoresfecultact, BC000A10_n138proveedoresfecultact
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound10 ;
      private int trnEnded ;
      private int Z2proveedoresid ;
      private int A2proveedoresid ;
      private long Z132proveedorestelefono1 ;
      private long A132proveedorestelefono1 ;
      private long Z133proveedorestelefono2 ;
      private long A133proveedorestelefono2 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode10 ;
      private DateTime Z137proveedoresfecreg ;
      private DateTime A137proveedoresfecreg ;
      private DateTime Z138proveedoresfecultact ;
      private DateTime A138proveedoresfecultact ;
      private bool n2proveedoresid ;
      private bool n126proveedoresnombre ;
      private bool n127proveedoresdireccion ;
      private bool n128proveedorescolonia ;
      private bool n129proveedorescodigopostal ;
      private bool n130proveedoresmunicipio ;
      private bool n131proveedorestado ;
      private bool n132proveedorestelefono1 ;
      private bool n133proveedorestelefono2 ;
      private bool n134proveedoresfax ;
      private bool n135proveedoresrfc ;
      private bool n136proveedoresusuario ;
      private bool n137proveedoresfecreg ;
      private bool n138proveedoresfecultact ;
      private bool Gx_longc ;
      private String Z126proveedoresnombre ;
      private String A126proveedoresnombre ;
      private String Z127proveedoresdireccion ;
      private String A127proveedoresdireccion ;
      private String Z128proveedorescolonia ;
      private String A128proveedorescolonia ;
      private String Z129proveedorescodigopostal ;
      private String A129proveedorescodigopostal ;
      private String Z130proveedoresmunicipio ;
      private String A130proveedoresmunicipio ;
      private String Z131proveedorestado ;
      private String A131proveedorestado ;
      private String Z134proveedoresfax ;
      private String A134proveedoresfax ;
      private String Z135proveedoresrfc ;
      private String A135proveedoresrfc ;
      private String Z136proveedoresusuario ;
      private String A136proveedoresusuario ;
      private Sdtproveedores bcproveedores ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000A4_A2proveedoresid ;
      private bool[] BC000A4_n2proveedoresid ;
      private String[] BC000A4_A126proveedoresnombre ;
      private bool[] BC000A4_n126proveedoresnombre ;
      private String[] BC000A4_A127proveedoresdireccion ;
      private bool[] BC000A4_n127proveedoresdireccion ;
      private String[] BC000A4_A128proveedorescolonia ;
      private bool[] BC000A4_n128proveedorescolonia ;
      private String[] BC000A4_A129proveedorescodigopostal ;
      private bool[] BC000A4_n129proveedorescodigopostal ;
      private String[] BC000A4_A130proveedoresmunicipio ;
      private bool[] BC000A4_n130proveedoresmunicipio ;
      private String[] BC000A4_A131proveedorestado ;
      private bool[] BC000A4_n131proveedorestado ;
      private long[] BC000A4_A132proveedorestelefono1 ;
      private bool[] BC000A4_n132proveedorestelefono1 ;
      private long[] BC000A4_A133proveedorestelefono2 ;
      private bool[] BC000A4_n133proveedorestelefono2 ;
      private String[] BC000A4_A134proveedoresfax ;
      private bool[] BC000A4_n134proveedoresfax ;
      private String[] BC000A4_A135proveedoresrfc ;
      private bool[] BC000A4_n135proveedoresrfc ;
      private String[] BC000A4_A136proveedoresusuario ;
      private bool[] BC000A4_n136proveedoresusuario ;
      private DateTime[] BC000A4_A137proveedoresfecreg ;
      private bool[] BC000A4_n137proveedoresfecreg ;
      private DateTime[] BC000A4_A138proveedoresfecultact ;
      private bool[] BC000A4_n138proveedoresfecultact ;
      private int[] BC000A5_A2proveedoresid ;
      private bool[] BC000A5_n2proveedoresid ;
      private int[] BC000A3_A2proveedoresid ;
      private bool[] BC000A3_n2proveedoresid ;
      private String[] BC000A3_A126proveedoresnombre ;
      private bool[] BC000A3_n126proveedoresnombre ;
      private String[] BC000A3_A127proveedoresdireccion ;
      private bool[] BC000A3_n127proveedoresdireccion ;
      private String[] BC000A3_A128proveedorescolonia ;
      private bool[] BC000A3_n128proveedorescolonia ;
      private String[] BC000A3_A129proveedorescodigopostal ;
      private bool[] BC000A3_n129proveedorescodigopostal ;
      private String[] BC000A3_A130proveedoresmunicipio ;
      private bool[] BC000A3_n130proveedoresmunicipio ;
      private String[] BC000A3_A131proveedorestado ;
      private bool[] BC000A3_n131proveedorestado ;
      private long[] BC000A3_A132proveedorestelefono1 ;
      private bool[] BC000A3_n132proveedorestelefono1 ;
      private long[] BC000A3_A133proveedorestelefono2 ;
      private bool[] BC000A3_n133proveedorestelefono2 ;
      private String[] BC000A3_A134proveedoresfax ;
      private bool[] BC000A3_n134proveedoresfax ;
      private String[] BC000A3_A135proveedoresrfc ;
      private bool[] BC000A3_n135proveedoresrfc ;
      private String[] BC000A3_A136proveedoresusuario ;
      private bool[] BC000A3_n136proveedoresusuario ;
      private DateTime[] BC000A3_A137proveedoresfecreg ;
      private bool[] BC000A3_n137proveedoresfecreg ;
      private DateTime[] BC000A3_A138proveedoresfecultact ;
      private bool[] BC000A3_n138proveedoresfecultact ;
      private int[] BC000A2_A2proveedoresid ;
      private bool[] BC000A2_n2proveedoresid ;
      private String[] BC000A2_A126proveedoresnombre ;
      private bool[] BC000A2_n126proveedoresnombre ;
      private String[] BC000A2_A127proveedoresdireccion ;
      private bool[] BC000A2_n127proveedoresdireccion ;
      private String[] BC000A2_A128proveedorescolonia ;
      private bool[] BC000A2_n128proveedorescolonia ;
      private String[] BC000A2_A129proveedorescodigopostal ;
      private bool[] BC000A2_n129proveedorescodigopostal ;
      private String[] BC000A2_A130proveedoresmunicipio ;
      private bool[] BC000A2_n130proveedoresmunicipio ;
      private String[] BC000A2_A131proveedorestado ;
      private bool[] BC000A2_n131proveedorestado ;
      private long[] BC000A2_A132proveedorestelefono1 ;
      private bool[] BC000A2_n132proveedorestelefono1 ;
      private long[] BC000A2_A133proveedorestelefono2 ;
      private bool[] BC000A2_n133proveedorestelefono2 ;
      private String[] BC000A2_A134proveedoresfax ;
      private bool[] BC000A2_n134proveedoresfax ;
      private String[] BC000A2_A135proveedoresrfc ;
      private bool[] BC000A2_n135proveedoresrfc ;
      private String[] BC000A2_A136proveedoresusuario ;
      private bool[] BC000A2_n136proveedoresusuario ;
      private DateTime[] BC000A2_A137proveedoresfecreg ;
      private bool[] BC000A2_n137proveedoresfecreg ;
      private DateTime[] BC000A2_A138proveedoresfecultact ;
      private bool[] BC000A2_n138proveedoresfecultact ;
      private int[] BC000A9_A19almacenid ;
      private int[] BC000A9_A20articulosproductoid ;
      private int[] BC000A9_A21articuloscambsid ;
      private int[] BC000A10_A2proveedoresid ;
      private bool[] BC000A10_n2proveedoresid ;
      private String[] BC000A10_A126proveedoresnombre ;
      private bool[] BC000A10_n126proveedoresnombre ;
      private String[] BC000A10_A127proveedoresdireccion ;
      private bool[] BC000A10_n127proveedoresdireccion ;
      private String[] BC000A10_A128proveedorescolonia ;
      private bool[] BC000A10_n128proveedorescolonia ;
      private String[] BC000A10_A129proveedorescodigopostal ;
      private bool[] BC000A10_n129proveedorescodigopostal ;
      private String[] BC000A10_A130proveedoresmunicipio ;
      private bool[] BC000A10_n130proveedoresmunicipio ;
      private String[] BC000A10_A131proveedorestado ;
      private bool[] BC000A10_n131proveedorestado ;
      private long[] BC000A10_A132proveedorestelefono1 ;
      private bool[] BC000A10_n132proveedorestelefono1 ;
      private long[] BC000A10_A133proveedorestelefono2 ;
      private bool[] BC000A10_n133proveedorestelefono2 ;
      private String[] BC000A10_A134proveedoresfax ;
      private bool[] BC000A10_n134proveedoresfax ;
      private String[] BC000A10_A135proveedoresrfc ;
      private bool[] BC000A10_n135proveedoresrfc ;
      private String[] BC000A10_A136proveedoresusuario ;
      private bool[] BC000A10_n136proveedoresusuario ;
      private DateTime[] BC000A10_A137proveedoresfecreg ;
      private bool[] BC000A10_n137proveedoresfecreg ;
      private DateTime[] BC000A10_A138proveedoresfecultact ;
      private bool[] BC000A10_n138proveedoresfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class proveedores_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000A4 ;
          prmBC000A4 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A5 ;
          prmBC000A5 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A3 ;
          prmBC000A3 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A2 ;
          prmBC000A2 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A6 ;
          prmBC000A6 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"proveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"proveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"proveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"proveedoresmunicipio",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestelefono1",NpgsqlDbType.Real,10,0} ,
          new Object[] {"proveedorestelefono2",NpgsqlDbType.Real,10,0} ,
          new Object[] {"proveedoresfax",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresrfc",NpgsqlDbType.Varchar,13,0} ,
          new Object[] {"proveedoresusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"proveedoresfecultact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmBC000A7 ;
          prmBC000A7 = new Object[] {
          new Object[] {"proveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"proveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"proveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"proveedoresmunicipio",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestelefono1",NpgsqlDbType.Real,10,0} ,
          new Object[] {"proveedorestelefono2",NpgsqlDbType.Real,10,0} ,
          new Object[] {"proveedoresfax",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresrfc",NpgsqlDbType.Varchar,13,0} ,
          new Object[] {"proveedoresusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"proveedoresfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A8 ;
          prmBC000A8 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A9 ;
          prmBC000A9 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000A10 ;
          prmBC000A10 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000A2", "SELECT proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact FROM public.proveedores WHERE proveedoresid = :proveedoresid  FOR UPDATE OF proveedores",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A2,1,0,true,false )
             ,new CursorDef("BC000A3", "SELECT proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A3,1,0,true,false )
             ,new CursorDef("BC000A4", "SELECT TM1.proveedoresid, TM1.proveedoresnombre, TM1.proveedoresdireccion, TM1.proveedorescolonia, TM1.proveedorescodigopostal, TM1.proveedoresmunicipio, TM1.proveedorestado, TM1.proveedorestelefono1, TM1.proveedorestelefono2, TM1.proveedoresfax, TM1.proveedoresrfc, TM1.proveedoresusuario, TM1.proveedoresfecreg, TM1.proveedoresfecultact FROM public.proveedores TM1 WHERE TM1.proveedoresid = :proveedoresid ORDER BY TM1.proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A4,100,0,true,false )
             ,new CursorDef("BC000A5", "SELECT proveedoresid FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A5,1,0,true,false )
             ,new CursorDef("BC000A6", "SAVEPOINT gxupdate;INSERT INTO public.proveedores(proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact) VALUES(:proveedoresid, :proveedoresnombre, :proveedoresdireccion, :proveedorescolonia, :proveedorescodigopostal, :proveedoresmunicipio, :proveedorestado, :proveedorestelefono1, :proveedorestelefono2, :proveedoresfax, :proveedoresrfc, :proveedoresusuario, :proveedoresfecreg, :proveedoresfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000A6)
             ,new CursorDef("BC000A7", "SAVEPOINT gxupdate;UPDATE public.proveedores SET proveedoresnombre=:proveedoresnombre, proveedoresdireccion=:proveedoresdireccion, proveedorescolonia=:proveedorescolonia, proveedorescodigopostal=:proveedorescodigopostal, proveedoresmunicipio=:proveedoresmunicipio, proveedorestado=:proveedorestado, proveedorestelefono1=:proveedorestelefono1, proveedorestelefono2=:proveedorestelefono2, proveedoresfax=:proveedoresfax, proveedoresrfc=:proveedoresrfc, proveedoresusuario=:proveedoresusuario, proveedoresfecreg=:proveedoresfecreg, proveedoresfecultact=:proveedoresfecultact  WHERE proveedoresid = :proveedoresid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000A7)
             ,new CursorDef("BC000A8", "SAVEPOINT gxupdate;DELETE FROM public.proveedores  WHERE proveedoresid = :proveedoresid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000A8)
             ,new CursorDef("BC000A9", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE proveedorid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A9,1,0,true,true )
             ,new CursorDef("BC000A10", "SELECT TM1.proveedoresid, TM1.proveedoresnombre, TM1.proveedoresdireccion, TM1.proveedorescolonia, TM1.proveedorescodigopostal, TM1.proveedoresmunicipio, TM1.proveedorestado, TM1.proveedorestelefono1, TM1.proveedorestelefono2, TM1.proveedoresfax, TM1.proveedoresrfc, TM1.proveedoresusuario, TM1.proveedoresfecreg, TM1.proveedoresfecultact FROM public.proveedores TM1 WHERE TM1.proveedoresid = :proveedoresid ORDER BY TM1.proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A10,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (long)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (long)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(14, (DateTime)parms[27]);
                }
                return;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (long)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(12, (DateTime)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(14, (int)parms[27]);
                }
                return;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
       }
    }

 }

}
