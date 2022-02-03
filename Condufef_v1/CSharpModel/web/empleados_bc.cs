/*
               File: empleados_BC
        Description: empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:17.90
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
   public class empleados_bc : GXHttpHandler, IGxSilentTrn
   {
      public empleados_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public empleados_bc( IGxContext context )
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
         ReadRow066( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey066( ) ;
         standaloneModal( ) ;
         AddRow066( ) ;
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
               Z13empleadosid = A13empleadosid;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls066( ) ;
            }
            else
            {
               CheckExtendedTable066( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors066( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM066( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z176areaid = A176areaid;
            Z99empleadosnomemple = A99empleadosnomemple;
            Z100empleadosappaterno = A100empleadosappaterno;
            Z101empleadosapmaterno = A101empleadosapmaterno;
            Z102empleadosstatus = A102empleadosstatus;
            Z103empleadosusuario = A103empleadosusuario;
            Z106empleadoscorreo = A106empleadoscorreo;
            Z107empleadosext = A107empleadosext;
            Z104empleadosfecreg = A104empleadosfecreg;
            Z105empleadosfecultact = A105empleadosfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z13empleadosid = A13empleadosid;
            Z176areaid = A176areaid;
            Z99empleadosnomemple = A99empleadosnomemple;
            Z100empleadosappaterno = A100empleadosappaterno;
            Z101empleadosapmaterno = A101empleadosapmaterno;
            Z102empleadosstatus = A102empleadosstatus;
            Z103empleadosusuario = A103empleadosusuario;
            Z106empleadoscorreo = A106empleadoscorreo;
            Z107empleadosext = A107empleadosext;
            Z104empleadosfecreg = A104empleadosfecreg;
            Z105empleadosfecultact = A105empleadosfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load066( )
      {
         /* Using cursor BC00064 */
         pr_default.execute(2, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1;
            A176areaid = BC00064_A176areaid[0];
            n176areaid = BC00064_n176areaid[0];
            A99empleadosnomemple = BC00064_A99empleadosnomemple[0];
            n99empleadosnomemple = BC00064_n99empleadosnomemple[0];
            A100empleadosappaterno = BC00064_A100empleadosappaterno[0];
            n100empleadosappaterno = BC00064_n100empleadosappaterno[0];
            A101empleadosapmaterno = BC00064_A101empleadosapmaterno[0];
            n101empleadosapmaterno = BC00064_n101empleadosapmaterno[0];
            A102empleadosstatus = BC00064_A102empleadosstatus[0];
            n102empleadosstatus = BC00064_n102empleadosstatus[0];
            A103empleadosusuario = BC00064_A103empleadosusuario[0];
            n103empleadosusuario = BC00064_n103empleadosusuario[0];
            A106empleadoscorreo = BC00064_A106empleadoscorreo[0];
            n106empleadoscorreo = BC00064_n106empleadoscorreo[0];
            A107empleadosext = BC00064_A107empleadosext[0];
            n107empleadosext = BC00064_n107empleadosext[0];
            A104empleadosfecreg = BC00064_A104empleadosfecreg[0];
            n104empleadosfecreg = BC00064_n104empleadosfecreg[0];
            A105empleadosfecultact = BC00064_A105empleadosfecultact[0];
            ZM066( -1) ;
         }
         pr_default.close(2);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
      }

      protected void CheckExtendedTable066( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors066( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey066( )
      {
         /* Using cursor BC00065 */
         pr_default.execute(3, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00063 */
         pr_default.execute(1, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM066( 1) ;
            RcdFound6 = 1;
            A13empleadosid = BC00063_A13empleadosid[0];
            n13empleadosid = BC00063_n13empleadosid[0];
            A176areaid = BC00063_A176areaid[0];
            n176areaid = BC00063_n176areaid[0];
            A99empleadosnomemple = BC00063_A99empleadosnomemple[0];
            n99empleadosnomemple = BC00063_n99empleadosnomemple[0];
            A100empleadosappaterno = BC00063_A100empleadosappaterno[0];
            n100empleadosappaterno = BC00063_n100empleadosappaterno[0];
            A101empleadosapmaterno = BC00063_A101empleadosapmaterno[0];
            n101empleadosapmaterno = BC00063_n101empleadosapmaterno[0];
            A102empleadosstatus = BC00063_A102empleadosstatus[0];
            n102empleadosstatus = BC00063_n102empleadosstatus[0];
            A103empleadosusuario = BC00063_A103empleadosusuario[0];
            n103empleadosusuario = BC00063_n103empleadosusuario[0];
            A106empleadoscorreo = BC00063_A106empleadoscorreo[0];
            n106empleadoscorreo = BC00063_n106empleadoscorreo[0];
            A107empleadosext = BC00063_A107empleadosext[0];
            n107empleadosext = BC00063_n107empleadosext[0];
            A104empleadosfecreg = BC00063_A104empleadosfecreg[0];
            n104empleadosfecreg = BC00063_n104empleadosfecreg[0];
            A105empleadosfecultact = BC00063_A105empleadosfecultact[0];
            Z13empleadosid = A13empleadosid;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load066( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey066( ) ;
            }
            Gx_mode = sMode6;
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode6;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( RcdFound6 == 0 )
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
         CONFIRM_060( ) ;
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

      protected void CheckOptimisticConcurrency066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00062 */
            pr_default.execute(0, new Object[] {n13empleadosid, A13empleadosid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPLEADOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z176areaid != BC00062_A176areaid[0] ) || ( StringUtil.StrCmp(Z99empleadosnomemple, BC00062_A99empleadosnomemple[0]) != 0 ) || ( StringUtil.StrCmp(Z100empleadosappaterno, BC00062_A100empleadosappaterno[0]) != 0 ) || ( StringUtil.StrCmp(Z101empleadosapmaterno, BC00062_A101empleadosapmaterno[0]) != 0 ) || ( StringUtil.StrCmp(Z102empleadosstatus, BC00062_A102empleadosstatus[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z103empleadosusuario, BC00062_A103empleadosusuario[0]) != 0 ) || ( StringUtil.StrCmp(Z106empleadoscorreo, BC00062_A106empleadoscorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z107empleadosext, BC00062_A107empleadosext[0]) != 0 ) || ( Z104empleadosfecreg != BC00062_A104empleadosfecreg[0] ) || ( Z105empleadosfecultact != BC00062_A105empleadosfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EMPLEADOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM066( 0) ;
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00066 */
                     pr_default.execute(4, new Object[] {n13empleadosid, A13empleadosid, n176areaid, A176areaid, n99empleadosnomemple, A99empleadosnomemple, n100empleadosappaterno, A100empleadosappaterno, n101empleadosapmaterno, A101empleadosapmaterno, n102empleadosstatus, A102empleadosstatus, n103empleadosusuario, A103empleadosusuario, n106empleadoscorreo, A106empleadoscorreo, n107empleadosext, A107empleadosext, n104empleadosfecreg, A104empleadosfecreg, A105empleadosfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00067 */
                     pr_default.execute(5, new Object[] {n176areaid, A176areaid, n99empleadosnomemple, A99empleadosnomemple, n100empleadosappaterno, A100empleadosappaterno, n101empleadosapmaterno, A101empleadosapmaterno, n102empleadosstatus, A102empleadosstatus, n103empleadosusuario, A103empleadosusuario, n106empleadoscorreo, A106empleadoscorreo, n107empleadosext, A107empleadosext, n104empleadosfecreg, A104empleadosfecreg, A105empleadosfecultact, n13empleadosid, A13empleadosid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPLEADOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate066( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls066( ) ;
            AfterConfirm066( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete066( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00068 */
                  pr_default.execute(6, new Object[] {n13empleadosid, A13empleadosid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel066( ) ;
         Gx_mode = sMode6;
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC00069 */
            pr_default.execute(7, new Object[] {n13empleadosid, A13empleadosid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"almacen"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete066( ) ;
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

      public void ScanKeyStart066( )
      {
         /* Using cursor BC000610 */
         pr_default.execute(8, new Object[] {n13empleadosid, A13empleadosid});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound6 = 1;
            A13empleadosid = BC000610_A13empleadosid[0];
            n13empleadosid = BC000610_n13empleadosid[0];
            A176areaid = BC000610_A176areaid[0];
            n176areaid = BC000610_n176areaid[0];
            A99empleadosnomemple = BC000610_A99empleadosnomemple[0];
            n99empleadosnomemple = BC000610_n99empleadosnomemple[0];
            A100empleadosappaterno = BC000610_A100empleadosappaterno[0];
            n100empleadosappaterno = BC000610_n100empleadosappaterno[0];
            A101empleadosapmaterno = BC000610_A101empleadosapmaterno[0];
            n101empleadosapmaterno = BC000610_n101empleadosapmaterno[0];
            A102empleadosstatus = BC000610_A102empleadosstatus[0];
            n102empleadosstatus = BC000610_n102empleadosstatus[0];
            A103empleadosusuario = BC000610_A103empleadosusuario[0];
            n103empleadosusuario = BC000610_n103empleadosusuario[0];
            A106empleadoscorreo = BC000610_A106empleadoscorreo[0];
            n106empleadoscorreo = BC000610_n106empleadoscorreo[0];
            A107empleadosext = BC000610_A107empleadosext[0];
            n107empleadosext = BC000610_n107empleadosext[0];
            A104empleadosfecreg = BC000610_A104empleadosfecreg[0];
            n104empleadosfecreg = BC000610_n104empleadosfecreg[0];
            A105empleadosfecultact = BC000610_A105empleadosfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext066( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound6 = 0;
         ScanKeyLoad066( ) ;
      }

      protected void ScanKeyLoad066( )
      {
         sMode6 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound6 = 1;
            A13empleadosid = BC000610_A13empleadosid[0];
            n13empleadosid = BC000610_n13empleadosid[0];
            A176areaid = BC000610_A176areaid[0];
            n176areaid = BC000610_n176areaid[0];
            A99empleadosnomemple = BC000610_A99empleadosnomemple[0];
            n99empleadosnomemple = BC000610_n99empleadosnomemple[0];
            A100empleadosappaterno = BC000610_A100empleadosappaterno[0];
            n100empleadosappaterno = BC000610_n100empleadosappaterno[0];
            A101empleadosapmaterno = BC000610_A101empleadosapmaterno[0];
            n101empleadosapmaterno = BC000610_n101empleadosapmaterno[0];
            A102empleadosstatus = BC000610_A102empleadosstatus[0];
            n102empleadosstatus = BC000610_n102empleadosstatus[0];
            A103empleadosusuario = BC000610_A103empleadosusuario[0];
            n103empleadosusuario = BC000610_n103empleadosusuario[0];
            A106empleadoscorreo = BC000610_A106empleadoscorreo[0];
            n106empleadoscorreo = BC000610_n106empleadoscorreo[0];
            A107empleadosext = BC000610_A107empleadosext[0];
            n107empleadosext = BC000610_n107empleadosext[0];
            A104empleadosfecreg = BC000610_A104empleadosfecreg[0];
            n104empleadosfecreg = BC000610_n104empleadosfecreg[0];
            A105empleadosfecultact = BC000610_A105empleadosfecultact[0];
         }
         Gx_mode = sMode6;
      }

      protected void ScanKeyEnd066( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes066( )
      {
      }

      protected void AddRow066( )
      {
         VarsToRow6( bcempleados) ;
      }

      protected void ReadRow066( )
      {
         RowToVars6( bcempleados, 1) ;
      }

      protected void InitializeNonKey066( )
      {
         A176areaid = 0;
         n176areaid = false;
         A99empleadosnomemple = "";
         n99empleadosnomemple = false;
         A100empleadosappaterno = "";
         n100empleadosappaterno = false;
         A101empleadosapmaterno = "";
         n101empleadosapmaterno = false;
         A102empleadosstatus = "";
         n102empleadosstatus = false;
         A103empleadosusuario = "";
         n103empleadosusuario = false;
         A106empleadoscorreo = "";
         n106empleadoscorreo = false;
         A107empleadosext = "";
         n107empleadosext = false;
         A104empleadosfecreg = DateTime.MinValue;
         n104empleadosfecreg = false;
         A105empleadosfecultact = DateTime.MinValue;
         Z176areaid = 0;
         Z99empleadosnomemple = "";
         Z100empleadosappaterno = "";
         Z101empleadosapmaterno = "";
         Z102empleadosstatus = "";
         Z103empleadosusuario = "";
         Z106empleadoscorreo = "";
         Z107empleadosext = "";
         Z104empleadosfecreg = DateTime.MinValue;
         Z105empleadosfecultact = DateTime.MinValue;
      }

      protected void InitAll066( )
      {
         A13empleadosid = 0;
         n13empleadosid = false;
         InitializeNonKey066( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow6( Sdtempleados obj6 )
      {
         obj6.gxTpr_Mode = Gx_mode;
         obj6.gxTpr_Areaid = A176areaid;
         obj6.gxTpr_Empleadosnomemple = A99empleadosnomemple;
         obj6.gxTpr_Empleadosappaterno = A100empleadosappaterno;
         obj6.gxTpr_Empleadosapmaterno = A101empleadosapmaterno;
         obj6.gxTpr_Empleadosstatus = A102empleadosstatus;
         obj6.gxTpr_Empleadosusuario = A103empleadosusuario;
         obj6.gxTpr_Empleadoscorreo = A106empleadoscorreo;
         obj6.gxTpr_Empleadosext = A107empleadosext;
         obj6.gxTpr_Empleadosfecreg = A104empleadosfecreg;
         obj6.gxTpr_Empleadosfecultact = A105empleadosfecultact;
         obj6.gxTpr_Empleadosid = A13empleadosid;
         obj6.gxTpr_Empleadosid_Z = Z13empleadosid;
         obj6.gxTpr_Areaid_Z = Z176areaid;
         obj6.gxTpr_Empleadosnomemple_Z = Z99empleadosnomemple;
         obj6.gxTpr_Empleadosappaterno_Z = Z100empleadosappaterno;
         obj6.gxTpr_Empleadosapmaterno_Z = Z101empleadosapmaterno;
         obj6.gxTpr_Empleadosstatus_Z = Z102empleadosstatus;
         obj6.gxTpr_Empleadosusuario_Z = Z103empleadosusuario;
         obj6.gxTpr_Empleadoscorreo_Z = Z106empleadoscorreo;
         obj6.gxTpr_Empleadosext_Z = Z107empleadosext;
         obj6.gxTpr_Empleadosfecreg_Z = Z104empleadosfecreg;
         obj6.gxTpr_Empleadosfecultact_Z = Z105empleadosfecultact;
         obj6.gxTpr_Empleadosid_N = (short)(Convert.ToInt16(n13empleadosid));
         obj6.gxTpr_Areaid_N = (short)(Convert.ToInt16(n176areaid));
         obj6.gxTpr_Empleadosnomemple_N = (short)(Convert.ToInt16(n99empleadosnomemple));
         obj6.gxTpr_Empleadosappaterno_N = (short)(Convert.ToInt16(n100empleadosappaterno));
         obj6.gxTpr_Empleadosapmaterno_N = (short)(Convert.ToInt16(n101empleadosapmaterno));
         obj6.gxTpr_Empleadosstatus_N = (short)(Convert.ToInt16(n102empleadosstatus));
         obj6.gxTpr_Empleadosusuario_N = (short)(Convert.ToInt16(n103empleadosusuario));
         obj6.gxTpr_Empleadoscorreo_N = (short)(Convert.ToInt16(n106empleadoscorreo));
         obj6.gxTpr_Empleadosext_N = (short)(Convert.ToInt16(n107empleadosext));
         obj6.gxTpr_Empleadosfecreg_N = (short)(Convert.ToInt16(n104empleadosfecreg));
         obj6.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow6( Sdtempleados obj6 )
      {
         obj6.gxTpr_Empleadosid = A13empleadosid;
         return  ;
      }

      public void RowToVars6( Sdtempleados obj6 ,
                              int forceLoad )
      {
         Gx_mode = obj6.gxTpr_Mode;
         A176areaid = obj6.gxTpr_Areaid;
         n176areaid = false;
         A99empleadosnomemple = obj6.gxTpr_Empleadosnomemple;
         n99empleadosnomemple = false;
         A100empleadosappaterno = obj6.gxTpr_Empleadosappaterno;
         n100empleadosappaterno = false;
         A101empleadosapmaterno = obj6.gxTpr_Empleadosapmaterno;
         n101empleadosapmaterno = false;
         A102empleadosstatus = obj6.gxTpr_Empleadosstatus;
         n102empleadosstatus = false;
         A103empleadosusuario = obj6.gxTpr_Empleadosusuario;
         n103empleadosusuario = false;
         A106empleadoscorreo = obj6.gxTpr_Empleadoscorreo;
         n106empleadoscorreo = false;
         A107empleadosext = obj6.gxTpr_Empleadosext;
         n107empleadosext = false;
         A104empleadosfecreg = obj6.gxTpr_Empleadosfecreg;
         n104empleadosfecreg = false;
         A105empleadosfecultact = obj6.gxTpr_Empleadosfecultact;
         A13empleadosid = obj6.gxTpr_Empleadosid;
         n13empleadosid = false;
         Z13empleadosid = obj6.gxTpr_Empleadosid_Z;
         Z176areaid = obj6.gxTpr_Areaid_Z;
         Z99empleadosnomemple = obj6.gxTpr_Empleadosnomemple_Z;
         Z100empleadosappaterno = obj6.gxTpr_Empleadosappaterno_Z;
         Z101empleadosapmaterno = obj6.gxTpr_Empleadosapmaterno_Z;
         Z102empleadosstatus = obj6.gxTpr_Empleadosstatus_Z;
         Z103empleadosusuario = obj6.gxTpr_Empleadosusuario_Z;
         Z106empleadoscorreo = obj6.gxTpr_Empleadoscorreo_Z;
         Z107empleadosext = obj6.gxTpr_Empleadosext_Z;
         Z104empleadosfecreg = obj6.gxTpr_Empleadosfecreg_Z;
         Z105empleadosfecultact = obj6.gxTpr_Empleadosfecultact_Z;
         n13empleadosid = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosid_N));
         n176areaid = (bool)(Convert.ToBoolean(obj6.gxTpr_Areaid_N));
         n99empleadosnomemple = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosnomemple_N));
         n100empleadosappaterno = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosappaterno_N));
         n101empleadosapmaterno = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosapmaterno_N));
         n102empleadosstatus = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosstatus_N));
         n103empleadosusuario = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosusuario_N));
         n106empleadoscorreo = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadoscorreo_N));
         n107empleadosext = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosext_N));
         n104empleadosfecreg = (bool)(Convert.ToBoolean(obj6.gxTpr_Empleadosfecreg_N));
         Gx_mode = obj6.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A13empleadosid = (int)getParm(obj,0);
         n13empleadosid = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey066( ) ;
         ScanKeyStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z13empleadosid = A13empleadosid;
         }
         ZM066( -1) ;
         OnLoadActions066( ) ;
         AddRow066( ) ;
         ScanKeyEnd066( ) ;
         if ( RcdFound6 == 0 )
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
         RowToVars6( bcempleados, 0) ;
         ScanKeyStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z13empleadosid = A13empleadosid;
         }
         ZM066( -1) ;
         OnLoadActions066( ) ;
         AddRow066( ) ;
         ScanKeyEnd066( ) ;
         if ( RcdFound6 == 0 )
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
         RowToVars6( bcempleados, 0) ;
         nKeyPressed = 1;
         GetKey066( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert066( ) ;
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A13empleadosid != Z13empleadosid )
               {
                  A13empleadosid = Z13empleadosid;
                  n13empleadosid = false;
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
                  Update066( ) ;
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
                  if ( A13empleadosid != Z13empleadosid )
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
                        Insert066( ) ;
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
                        Insert066( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow6( bcempleados) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars6( bcempleados, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey066( ) ;
         if ( RcdFound6 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A13empleadosid != Z13empleadosid )
            {
               A13empleadosid = Z13empleadosid;
               n13empleadosid = false;
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
            if ( A13empleadosid != Z13empleadosid )
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
         context.RollbackDataStores( "empleados_BC");
         VarsToRow6( bcempleados) ;
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
         Gx_mode = bcempleados.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcempleados.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcempleados )
         {
            bcempleados = (Sdtempleados)(sdt);
            if ( StringUtil.StrCmp(bcempleados.gxTpr_Mode, "") == 0 )
            {
               bcempleados.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow6( bcempleados) ;
            }
            else
            {
               RowToVars6( bcempleados, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcempleados.gxTpr_Mode, "") == 0 )
            {
               bcempleados.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars6( bcempleados, 1) ;
         return  ;
      }

      public Sdtempleados empleados_BC
      {
         get {
            return bcempleados ;
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
         Z99empleadosnomemple = "";
         A99empleadosnomemple = "";
         Z100empleadosappaterno = "";
         A100empleadosappaterno = "";
         Z101empleadosapmaterno = "";
         A101empleadosapmaterno = "";
         Z102empleadosstatus = "";
         A102empleadosstatus = "";
         Z103empleadosusuario = "";
         A103empleadosusuario = "";
         Z106empleadoscorreo = "";
         A106empleadoscorreo = "";
         Z107empleadosext = "";
         A107empleadosext = "";
         Z104empleadosfecreg = DateTime.MinValue;
         A104empleadosfecreg = DateTime.MinValue;
         Z105empleadosfecultact = DateTime.MinValue;
         A105empleadosfecultact = DateTime.MinValue;
         BC00064_A13empleadosid = new int[1] ;
         BC00064_n13empleadosid = new bool[] {false} ;
         BC00064_A176areaid = new int[1] ;
         BC00064_n176areaid = new bool[] {false} ;
         BC00064_A99empleadosnomemple = new String[] {""} ;
         BC00064_n99empleadosnomemple = new bool[] {false} ;
         BC00064_A100empleadosappaterno = new String[] {""} ;
         BC00064_n100empleadosappaterno = new bool[] {false} ;
         BC00064_A101empleadosapmaterno = new String[] {""} ;
         BC00064_n101empleadosapmaterno = new bool[] {false} ;
         BC00064_A102empleadosstatus = new String[] {""} ;
         BC00064_n102empleadosstatus = new bool[] {false} ;
         BC00064_A103empleadosusuario = new String[] {""} ;
         BC00064_n103empleadosusuario = new bool[] {false} ;
         BC00064_A106empleadoscorreo = new String[] {""} ;
         BC00064_n106empleadoscorreo = new bool[] {false} ;
         BC00064_A107empleadosext = new String[] {""} ;
         BC00064_n107empleadosext = new bool[] {false} ;
         BC00064_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00064_n104empleadosfecreg = new bool[] {false} ;
         BC00064_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00065_A13empleadosid = new int[1] ;
         BC00065_n13empleadosid = new bool[] {false} ;
         BC00063_A13empleadosid = new int[1] ;
         BC00063_n13empleadosid = new bool[] {false} ;
         BC00063_A176areaid = new int[1] ;
         BC00063_n176areaid = new bool[] {false} ;
         BC00063_A99empleadosnomemple = new String[] {""} ;
         BC00063_n99empleadosnomemple = new bool[] {false} ;
         BC00063_A100empleadosappaterno = new String[] {""} ;
         BC00063_n100empleadosappaterno = new bool[] {false} ;
         BC00063_A101empleadosapmaterno = new String[] {""} ;
         BC00063_n101empleadosapmaterno = new bool[] {false} ;
         BC00063_A102empleadosstatus = new String[] {""} ;
         BC00063_n102empleadosstatus = new bool[] {false} ;
         BC00063_A103empleadosusuario = new String[] {""} ;
         BC00063_n103empleadosusuario = new bool[] {false} ;
         BC00063_A106empleadoscorreo = new String[] {""} ;
         BC00063_n106empleadoscorreo = new bool[] {false} ;
         BC00063_A107empleadosext = new String[] {""} ;
         BC00063_n107empleadosext = new bool[] {false} ;
         BC00063_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00063_n104empleadosfecreg = new bool[] {false} ;
         BC00063_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         sMode6 = "";
         BC00062_A13empleadosid = new int[1] ;
         BC00062_n13empleadosid = new bool[] {false} ;
         BC00062_A176areaid = new int[1] ;
         BC00062_n176areaid = new bool[] {false} ;
         BC00062_A99empleadosnomemple = new String[] {""} ;
         BC00062_n99empleadosnomemple = new bool[] {false} ;
         BC00062_A100empleadosappaterno = new String[] {""} ;
         BC00062_n100empleadosappaterno = new bool[] {false} ;
         BC00062_A101empleadosapmaterno = new String[] {""} ;
         BC00062_n101empleadosapmaterno = new bool[] {false} ;
         BC00062_A102empleadosstatus = new String[] {""} ;
         BC00062_n102empleadosstatus = new bool[] {false} ;
         BC00062_A103empleadosusuario = new String[] {""} ;
         BC00062_n103empleadosusuario = new bool[] {false} ;
         BC00062_A106empleadoscorreo = new String[] {""} ;
         BC00062_n106empleadoscorreo = new bool[] {false} ;
         BC00062_A107empleadosext = new String[] {""} ;
         BC00062_n107empleadosext = new bool[] {false} ;
         BC00062_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00062_n104empleadosfecreg = new bool[] {false} ;
         BC00062_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00069_A19almacenid = new int[1] ;
         BC000610_A13empleadosid = new int[1] ;
         BC000610_n13empleadosid = new bool[] {false} ;
         BC000610_A176areaid = new int[1] ;
         BC000610_n176areaid = new bool[] {false} ;
         BC000610_A99empleadosnomemple = new String[] {""} ;
         BC000610_n99empleadosnomemple = new bool[] {false} ;
         BC000610_A100empleadosappaterno = new String[] {""} ;
         BC000610_n100empleadosappaterno = new bool[] {false} ;
         BC000610_A101empleadosapmaterno = new String[] {""} ;
         BC000610_n101empleadosapmaterno = new bool[] {false} ;
         BC000610_A102empleadosstatus = new String[] {""} ;
         BC000610_n102empleadosstatus = new bool[] {false} ;
         BC000610_A103empleadosusuario = new String[] {""} ;
         BC000610_n103empleadosusuario = new bool[] {false} ;
         BC000610_A106empleadoscorreo = new String[] {""} ;
         BC000610_n106empleadoscorreo = new bool[] {false} ;
         BC000610_A107empleadosext = new String[] {""} ;
         BC000610_n107empleadosext = new bool[] {false} ;
         BC000610_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000610_n104empleadosfecreg = new bool[] {false} ;
         BC000610_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleados_bc__default(),
            new Object[][] {
                new Object[] {
               BC00062_A13empleadosid, BC00062_A176areaid, BC00062_n176areaid, BC00062_A99empleadosnomemple, BC00062_n99empleadosnomemple, BC00062_A100empleadosappaterno, BC00062_n100empleadosappaterno, BC00062_A101empleadosapmaterno, BC00062_n101empleadosapmaterno, BC00062_A102empleadosstatus,
               BC00062_n102empleadosstatus, BC00062_A103empleadosusuario, BC00062_n103empleadosusuario, BC00062_A106empleadoscorreo, BC00062_n106empleadoscorreo, BC00062_A107empleadosext, BC00062_n107empleadosext, BC00062_A104empleadosfecreg, BC00062_n104empleadosfecreg, BC00062_A105empleadosfecultact
               }
               , new Object[] {
               BC00063_A13empleadosid, BC00063_A176areaid, BC00063_n176areaid, BC00063_A99empleadosnomemple, BC00063_n99empleadosnomemple, BC00063_A100empleadosappaterno, BC00063_n100empleadosappaterno, BC00063_A101empleadosapmaterno, BC00063_n101empleadosapmaterno, BC00063_A102empleadosstatus,
               BC00063_n102empleadosstatus, BC00063_A103empleadosusuario, BC00063_n103empleadosusuario, BC00063_A106empleadoscorreo, BC00063_n106empleadoscorreo, BC00063_A107empleadosext, BC00063_n107empleadosext, BC00063_A104empleadosfecreg, BC00063_n104empleadosfecreg, BC00063_A105empleadosfecultact
               }
               , new Object[] {
               BC00064_A13empleadosid, BC00064_A176areaid, BC00064_n176areaid, BC00064_A99empleadosnomemple, BC00064_n99empleadosnomemple, BC00064_A100empleadosappaterno, BC00064_n100empleadosappaterno, BC00064_A101empleadosapmaterno, BC00064_n101empleadosapmaterno, BC00064_A102empleadosstatus,
               BC00064_n102empleadosstatus, BC00064_A103empleadosusuario, BC00064_n103empleadosusuario, BC00064_A106empleadoscorreo, BC00064_n106empleadoscorreo, BC00064_A107empleadosext, BC00064_n107empleadosext, BC00064_A104empleadosfecreg, BC00064_n104empleadosfecreg, BC00064_A105empleadosfecultact
               }
               , new Object[] {
               BC00065_A13empleadosid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00069_A19almacenid
               }
               , new Object[] {
               BC000610_A13empleadosid, BC000610_A176areaid, BC000610_n176areaid, BC000610_A99empleadosnomemple, BC000610_n99empleadosnomemple, BC000610_A100empleadosappaterno, BC000610_n100empleadosappaterno, BC000610_A101empleadosapmaterno, BC000610_n101empleadosapmaterno, BC000610_A102empleadosstatus,
               BC000610_n102empleadosstatus, BC000610_A103empleadosusuario, BC000610_n103empleadosusuario, BC000610_A106empleadoscorreo, BC000610_n106empleadoscorreo, BC000610_A107empleadosext, BC000610_n107empleadosext, BC000610_A104empleadosfecreg, BC000610_n104empleadosfecreg, BC000610_A105empleadosfecultact
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
      private short RcdFound6 ;
      private int trnEnded ;
      private int Z13empleadosid ;
      private int A13empleadosid ;
      private int Z176areaid ;
      private int A176areaid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode6 ;
      private DateTime Z104empleadosfecreg ;
      private DateTime A104empleadosfecreg ;
      private DateTime Z105empleadosfecultact ;
      private DateTime A105empleadosfecultact ;
      private bool n13empleadosid ;
      private bool n176areaid ;
      private bool n99empleadosnomemple ;
      private bool n100empleadosappaterno ;
      private bool n101empleadosapmaterno ;
      private bool n102empleadosstatus ;
      private bool n103empleadosusuario ;
      private bool n106empleadoscorreo ;
      private bool n107empleadosext ;
      private bool n104empleadosfecreg ;
      private bool Gx_longc ;
      private String Z99empleadosnomemple ;
      private String A99empleadosnomemple ;
      private String Z100empleadosappaterno ;
      private String A100empleadosappaterno ;
      private String Z101empleadosapmaterno ;
      private String A101empleadosapmaterno ;
      private String Z102empleadosstatus ;
      private String A102empleadosstatus ;
      private String Z103empleadosusuario ;
      private String A103empleadosusuario ;
      private String Z106empleadoscorreo ;
      private String A106empleadoscorreo ;
      private String Z107empleadosext ;
      private String A107empleadosext ;
      private Sdtempleados bcempleados ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00064_A13empleadosid ;
      private bool[] BC00064_n13empleadosid ;
      private int[] BC00064_A176areaid ;
      private bool[] BC00064_n176areaid ;
      private String[] BC00064_A99empleadosnomemple ;
      private bool[] BC00064_n99empleadosnomemple ;
      private String[] BC00064_A100empleadosappaterno ;
      private bool[] BC00064_n100empleadosappaterno ;
      private String[] BC00064_A101empleadosapmaterno ;
      private bool[] BC00064_n101empleadosapmaterno ;
      private String[] BC00064_A102empleadosstatus ;
      private bool[] BC00064_n102empleadosstatus ;
      private String[] BC00064_A103empleadosusuario ;
      private bool[] BC00064_n103empleadosusuario ;
      private String[] BC00064_A106empleadoscorreo ;
      private bool[] BC00064_n106empleadoscorreo ;
      private String[] BC00064_A107empleadosext ;
      private bool[] BC00064_n107empleadosext ;
      private DateTime[] BC00064_A104empleadosfecreg ;
      private bool[] BC00064_n104empleadosfecreg ;
      private DateTime[] BC00064_A105empleadosfecultact ;
      private int[] BC00065_A13empleadosid ;
      private bool[] BC00065_n13empleadosid ;
      private int[] BC00063_A13empleadosid ;
      private bool[] BC00063_n13empleadosid ;
      private int[] BC00063_A176areaid ;
      private bool[] BC00063_n176areaid ;
      private String[] BC00063_A99empleadosnomemple ;
      private bool[] BC00063_n99empleadosnomemple ;
      private String[] BC00063_A100empleadosappaterno ;
      private bool[] BC00063_n100empleadosappaterno ;
      private String[] BC00063_A101empleadosapmaterno ;
      private bool[] BC00063_n101empleadosapmaterno ;
      private String[] BC00063_A102empleadosstatus ;
      private bool[] BC00063_n102empleadosstatus ;
      private String[] BC00063_A103empleadosusuario ;
      private bool[] BC00063_n103empleadosusuario ;
      private String[] BC00063_A106empleadoscorreo ;
      private bool[] BC00063_n106empleadoscorreo ;
      private String[] BC00063_A107empleadosext ;
      private bool[] BC00063_n107empleadosext ;
      private DateTime[] BC00063_A104empleadosfecreg ;
      private bool[] BC00063_n104empleadosfecreg ;
      private DateTime[] BC00063_A105empleadosfecultact ;
      private int[] BC00062_A13empleadosid ;
      private bool[] BC00062_n13empleadosid ;
      private int[] BC00062_A176areaid ;
      private bool[] BC00062_n176areaid ;
      private String[] BC00062_A99empleadosnomemple ;
      private bool[] BC00062_n99empleadosnomemple ;
      private String[] BC00062_A100empleadosappaterno ;
      private bool[] BC00062_n100empleadosappaterno ;
      private String[] BC00062_A101empleadosapmaterno ;
      private bool[] BC00062_n101empleadosapmaterno ;
      private String[] BC00062_A102empleadosstatus ;
      private bool[] BC00062_n102empleadosstatus ;
      private String[] BC00062_A103empleadosusuario ;
      private bool[] BC00062_n103empleadosusuario ;
      private String[] BC00062_A106empleadoscorreo ;
      private bool[] BC00062_n106empleadoscorreo ;
      private String[] BC00062_A107empleadosext ;
      private bool[] BC00062_n107empleadosext ;
      private DateTime[] BC00062_A104empleadosfecreg ;
      private bool[] BC00062_n104empleadosfecreg ;
      private DateTime[] BC00062_A105empleadosfecultact ;
      private int[] BC00069_A19almacenid ;
      private int[] BC000610_A13empleadosid ;
      private bool[] BC000610_n13empleadosid ;
      private int[] BC000610_A176areaid ;
      private bool[] BC000610_n176areaid ;
      private String[] BC000610_A99empleadosnomemple ;
      private bool[] BC000610_n99empleadosnomemple ;
      private String[] BC000610_A100empleadosappaterno ;
      private bool[] BC000610_n100empleadosappaterno ;
      private String[] BC000610_A101empleadosapmaterno ;
      private bool[] BC000610_n101empleadosapmaterno ;
      private String[] BC000610_A102empleadosstatus ;
      private bool[] BC000610_n102empleadosstatus ;
      private String[] BC000610_A103empleadosusuario ;
      private bool[] BC000610_n103empleadosusuario ;
      private String[] BC000610_A106empleadoscorreo ;
      private bool[] BC000610_n106empleadoscorreo ;
      private String[] BC000610_A107empleadosext ;
      private bool[] BC000610_n107empleadosext ;
      private DateTime[] BC000610_A104empleadosfecreg ;
      private bool[] BC000610_n104empleadosfecreg ;
      private DateTime[] BC000610_A105empleadosfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class empleados_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00064 ;
          prmBC00064 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00065 ;
          prmBC00065 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00063 ;
          prmBC00063 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00062 ;
          prmBC00062 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00066 ;
          prmBC00066 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"areaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"empleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"empleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadoscorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadosext",NpgsqlDbType.Varchar,4,0} ,
          new Object[] {"empleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosfecultact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmBC00067 ;
          prmBC00067 = new Object[] {
          new Object[] {"areaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"empleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"empleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadoscorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadosext",NpgsqlDbType.Varchar,4,0} ,
          new Object[] {"empleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00068 ;
          prmBC00068 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00069 ;
          prmBC00069 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000610 ;
          prmBC000610 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00062", "SELECT empleadosid, areaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact FROM public.empleados WHERE empleadosid = :empleadosid  FOR UPDATE OF empleados",true, GxErrorMask.GX_NOMASK, false, this,prmBC00062,1,0,true,false )
             ,new CursorDef("BC00063", "SELECT empleadosid, areaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00063,1,0,true,false )
             ,new CursorDef("BC00064", "SELECT TM1.empleadosid, TM1.areaid, TM1.empleadosnomemple, TM1.empleadosappaterno, TM1.empleadosapmaterno, TM1.empleadosstatus, TM1.empleadosusuario, TM1.empleadoscorreo, TM1.empleadosext, TM1.empleadosfecreg, TM1.empleadosfecultact FROM public.empleados TM1 WHERE TM1.empleadosid = :empleadosid ORDER BY TM1.empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00064,100,0,true,false )
             ,new CursorDef("BC00065", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00065,1,0,true,false )
             ,new CursorDef("BC00066", "SAVEPOINT gxupdate;INSERT INTO public.empleados(empleadosid, areaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact) VALUES(:empleadosid, :areaid, :empleadosnomemple, :empleadosappaterno, :empleadosapmaterno, :empleadosstatus, :empleadosusuario, :empleadoscorreo, :empleadosext, :empleadosfecreg, :empleadosfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00066)
             ,new CursorDef("BC00067", "SAVEPOINT gxupdate;UPDATE public.empleados SET areaid=:areaid, empleadosnomemple=:empleadosnomemple, empleadosappaterno=:empleadosappaterno, empleadosapmaterno=:empleadosapmaterno, empleadosstatus=:empleadosstatus, empleadosusuario=:empleadosusuario, empleadoscorreo=:empleadoscorreo, empleadosext=:empleadosext, empleadosfecreg=:empleadosfecreg, empleadosfecultact=:empleadosfecultact  WHERE empleadosid = :empleadosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00067)
             ,new CursorDef("BC00068", "SAVEPOINT gxupdate;DELETE FROM public.empleados  WHERE empleadosid = :empleadosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00068)
             ,new CursorDef("BC00069", "SELECT almacenid FROM public.almacen WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00069,1,0,true,true )
             ,new CursorDef("BC000610", "SELECT TM1.empleadosid, TM1.areaid, TM1.empleadosnomemple, TM1.empleadosappaterno, TM1.empleadosapmaterno, TM1.empleadosstatus, TM1.empleadosusuario, TM1.empleadoscorreo, TM1.empleadosext, TM1.empleadosfecreg, TM1.empleadosfecultact FROM public.empleados TM1 WHERE TM1.empleadosid = :empleadosid ORDER BY TM1.empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000610,100,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
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
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
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
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
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
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(10, (DateTime)parms[19]);
                }
                stmt.SetParameter(11, (DateTime)parms[20]);
                return;
             case 5 :
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
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[17]);
                }
                stmt.SetParameter(10, (DateTime)parms[18]);
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[20]);
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
