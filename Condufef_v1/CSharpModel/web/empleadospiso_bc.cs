/*
               File: empleadospiso_BC
        Description: empleadospiso
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:56.20
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
   public class empleadospiso_bc : GXHttpHandler, IGxSilentTrn
   {
      public empleadospiso_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public empleadospiso_bc( IGxContext context )
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
         ReadRow0O24( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0O24( ) ;
         standaloneModal( ) ;
         AddRow0O24( ) ;
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
               Z46empleadospisoextid = A46empleadospisoextid;
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

      protected void CONFIRM_0O0( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0O24( ) ;
            }
            else
            {
               CheckExtendedTable0O24( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0O24( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0O24( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z47empleadospisoextpiso = A47empleadospisoextpiso;
            Z48empleadospisoextext = A48empleadospisoextext;
            Z49empleadospisoextcorreo = A49empleadospisoextcorreo;
            Z50empleadopisoextprofesion = A50empleadopisoextprofesion;
            Z51empleadospisoextusuario = A51empleadospisoextusuario;
            Z52empleadospisoextfecgre = A52empleadospisoextfecgre;
            Z53empleadospisoextfeact = A53empleadospisoextfeact;
         }
         if ( GX_JID == -1 )
         {
            Z46empleadospisoextid = A46empleadospisoextid;
            Z47empleadospisoextpiso = A47empleadospisoextpiso;
            Z48empleadospisoextext = A48empleadospisoextext;
            Z49empleadospisoextcorreo = A49empleadospisoextcorreo;
            Z50empleadopisoextprofesion = A50empleadopisoextprofesion;
            Z51empleadospisoextusuario = A51empleadospisoextusuario;
            Z52empleadospisoextfecgre = A52empleadospisoextfecgre;
            Z53empleadospisoextfeact = A53empleadospisoextfeact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0O24( )
      {
         /* Using cursor BC000O4 */
         pr_default.execute(2, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound24 = 1;
            A47empleadospisoextpiso = BC000O4_A47empleadospisoextpiso[0];
            A48empleadospisoextext = BC000O4_A48empleadospisoextext[0];
            A49empleadospisoextcorreo = BC000O4_A49empleadospisoextcorreo[0];
            A50empleadopisoextprofesion = BC000O4_A50empleadopisoextprofesion[0];
            A51empleadospisoextusuario = BC000O4_A51empleadospisoextusuario[0];
            A52empleadospisoextfecgre = BC000O4_A52empleadospisoextfecgre[0];
            A53empleadospisoextfeact = BC000O4_A53empleadospisoextfeact[0];
            ZM0O24( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0O24( ) ;
      }

      protected void OnLoadActions0O24( )
      {
      }

      protected void CheckExtendedTable0O24( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0O24( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0O24( )
      {
         /* Using cursor BC000O5 */
         pr_default.execute(3, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound24 = 1;
         }
         else
         {
            RcdFound24 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000O3 */
         pr_default.execute(1, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O24( 1) ;
            RcdFound24 = 1;
            A46empleadospisoextid = BC000O3_A46empleadospisoextid[0];
            A47empleadospisoextpiso = BC000O3_A47empleadospisoextpiso[0];
            A48empleadospisoextext = BC000O3_A48empleadospisoextext[0];
            A49empleadospisoextcorreo = BC000O3_A49empleadospisoextcorreo[0];
            A50empleadopisoextprofesion = BC000O3_A50empleadopisoextprofesion[0];
            A51empleadospisoextusuario = BC000O3_A51empleadospisoextusuario[0];
            A52empleadospisoextfecgre = BC000O3_A52empleadospisoextfecgre[0];
            A53empleadospisoextfeact = BC000O3_A53empleadospisoextfeact[0];
            Z46empleadospisoextid = A46empleadospisoextid;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0O24( ) ;
            if ( AnyError == 1 )
            {
               RcdFound24 = 0;
               InitializeNonKey0O24( ) ;
            }
            Gx_mode = sMode24;
         }
         else
         {
            RcdFound24 = 0;
            InitializeNonKey0O24( ) ;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode24;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O24( ) ;
         if ( RcdFound24 == 0 )
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
         CONFIRM_0O0( ) ;
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

      protected void CheckOptimisticConcurrency0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000O2 */
            pr_default.execute(0, new Object[] {A46empleadospisoextid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"empleadospiso"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z47empleadospisoextpiso, BC000O2_A47empleadospisoextpiso[0]) != 0 ) || ( StringUtil.StrCmp(Z48empleadospisoextext, BC000O2_A48empleadospisoextext[0]) != 0 ) || ( StringUtil.StrCmp(Z49empleadospisoextcorreo, BC000O2_A49empleadospisoextcorreo[0]) != 0 ) || ( Z50empleadopisoextprofesion != BC000O2_A50empleadopisoextprofesion[0] ) || ( StringUtil.StrCmp(Z51empleadospisoextusuario, BC000O2_A51empleadospisoextusuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z52empleadospisoextfecgre != BC000O2_A52empleadospisoextfecgre[0] ) || ( Z53empleadospisoextfeact != BC000O2_A53empleadospisoextfeact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"empleadospiso"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O24( 0) ;
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000O6 */
                     pr_default.execute(4, new Object[] {A46empleadospisoextid, A47empleadospisoextpiso, A48empleadospisoextext, A49empleadospisoextcorreo, A50empleadopisoextprofesion, A51empleadospisoextusuario, A52empleadospisoextfecgre, A53empleadospisoextfeact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
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
               Load0O24( ) ;
            }
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void Update0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000O7 */
                     pr_default.execute(5, new Object[] {A47empleadospisoextpiso, A48empleadospisoextext, A49empleadospisoextcorreo, A50empleadopisoextprofesion, A51empleadospisoextusuario, A52empleadospisoextfecgre, A53empleadospisoextfeact, A46empleadospisoextid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"empleadospiso"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O24( ) ;
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
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void DeferredUpdate0O24( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O24( ) ;
            AfterConfirm0O24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000O8 */
                  pr_default.execute(6, new Object[] {A46empleadospisoextid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
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
         sMode24 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0O24( ) ;
         Gx_mode = sMode24;
      }

      protected void OnDeleteControls0O24( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O24( ) ;
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

      public void ScanKeyStart0O24( )
      {
         /* Using cursor BC000O9 */
         pr_default.execute(7, new Object[] {A46empleadospisoextid});
         RcdFound24 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound24 = 1;
            A46empleadospisoextid = BC000O9_A46empleadospisoextid[0];
            A47empleadospisoextpiso = BC000O9_A47empleadospisoextpiso[0];
            A48empleadospisoextext = BC000O9_A48empleadospisoextext[0];
            A49empleadospisoextcorreo = BC000O9_A49empleadospisoextcorreo[0];
            A50empleadopisoextprofesion = BC000O9_A50empleadopisoextprofesion[0];
            A51empleadospisoextusuario = BC000O9_A51empleadospisoextusuario[0];
            A52empleadospisoextfecgre = BC000O9_A52empleadospisoextfecgre[0];
            A53empleadospisoextfeact = BC000O9_A53empleadospisoextfeact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0O24( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound24 = 0;
         ScanKeyLoad0O24( ) ;
      }

      protected void ScanKeyLoad0O24( )
      {
         sMode24 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound24 = 1;
            A46empleadospisoextid = BC000O9_A46empleadospisoextid[0];
            A47empleadospisoextpiso = BC000O9_A47empleadospisoextpiso[0];
            A48empleadospisoextext = BC000O9_A48empleadospisoextext[0];
            A49empleadospisoextcorreo = BC000O9_A49empleadospisoextcorreo[0];
            A50empleadopisoextprofesion = BC000O9_A50empleadopisoextprofesion[0];
            A51empleadospisoextusuario = BC000O9_A51empleadospisoextusuario[0];
            A52empleadospisoextfecgre = BC000O9_A52empleadospisoextfecgre[0];
            A53empleadospisoextfeact = BC000O9_A53empleadospisoextfeact[0];
         }
         Gx_mode = sMode24;
      }

      protected void ScanKeyEnd0O24( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0O24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O24( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O24( )
      {
      }

      protected void AddRow0O24( )
      {
         VarsToRow24( bcempleadospiso) ;
      }

      protected void ReadRow0O24( )
      {
         RowToVars24( bcempleadospiso, 1) ;
      }

      protected void InitializeNonKey0O24( )
      {
         A47empleadospisoextpiso = "";
         A48empleadospisoextext = "";
         A49empleadospisoextcorreo = "";
         A50empleadopisoextprofesion = 0;
         A51empleadospisoextusuario = "";
         A52empleadospisoextfecgre = DateTime.MinValue;
         A53empleadospisoextfeact = DateTime.MinValue;
         Z47empleadospisoextpiso = "";
         Z48empleadospisoextext = "";
         Z49empleadospisoextcorreo = "";
         Z50empleadopisoextprofesion = 0;
         Z51empleadospisoextusuario = "";
         Z52empleadospisoextfecgre = DateTime.MinValue;
         Z53empleadospisoextfeact = DateTime.MinValue;
      }

      protected void InitAll0O24( )
      {
         A46empleadospisoextid = 0;
         InitializeNonKey0O24( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow24( Sdtempleadospiso obj24 )
      {
         obj24.gxTpr_Mode = Gx_mode;
         obj24.gxTpr_Empleadospisoextpiso = A47empleadospisoextpiso;
         obj24.gxTpr_Empleadospisoextext = A48empleadospisoextext;
         obj24.gxTpr_Empleadospisoextcorreo = A49empleadospisoextcorreo;
         obj24.gxTpr_Empleadopisoextprofesion = A50empleadopisoextprofesion;
         obj24.gxTpr_Empleadospisoextusuario = A51empleadospisoextusuario;
         obj24.gxTpr_Empleadospisoextfecgre = A52empleadospisoextfecgre;
         obj24.gxTpr_Empleadospisoextfeact = A53empleadospisoextfeact;
         obj24.gxTpr_Empleadospisoextid = A46empleadospisoextid;
         obj24.gxTpr_Empleadospisoextid_Z = Z46empleadospisoextid;
         obj24.gxTpr_Empleadospisoextpiso_Z = Z47empleadospisoextpiso;
         obj24.gxTpr_Empleadospisoextext_Z = Z48empleadospisoextext;
         obj24.gxTpr_Empleadospisoextcorreo_Z = Z49empleadospisoextcorreo;
         obj24.gxTpr_Empleadopisoextprofesion_Z = Z50empleadopisoextprofesion;
         obj24.gxTpr_Empleadospisoextusuario_Z = Z51empleadospisoextusuario;
         obj24.gxTpr_Empleadospisoextfecgre_Z = Z52empleadospisoextfecgre;
         obj24.gxTpr_Empleadospisoextfeact_Z = Z53empleadospisoextfeact;
         obj24.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow24( Sdtempleadospiso obj24 )
      {
         obj24.gxTpr_Empleadospisoextid = A46empleadospisoextid;
         return  ;
      }

      public void RowToVars24( Sdtempleadospiso obj24 ,
                               int forceLoad )
      {
         Gx_mode = obj24.gxTpr_Mode;
         A47empleadospisoextpiso = obj24.gxTpr_Empleadospisoextpiso;
         A48empleadospisoextext = obj24.gxTpr_Empleadospisoextext;
         A49empleadospisoextcorreo = obj24.gxTpr_Empleadospisoextcorreo;
         A50empleadopisoextprofesion = obj24.gxTpr_Empleadopisoextprofesion;
         A51empleadospisoextusuario = obj24.gxTpr_Empleadospisoextusuario;
         A52empleadospisoextfecgre = obj24.gxTpr_Empleadospisoextfecgre;
         A53empleadospisoextfeact = obj24.gxTpr_Empleadospisoextfeact;
         A46empleadospisoextid = obj24.gxTpr_Empleadospisoextid;
         Z46empleadospisoextid = obj24.gxTpr_Empleadospisoextid_Z;
         Z47empleadospisoextpiso = obj24.gxTpr_Empleadospisoextpiso_Z;
         Z48empleadospisoextext = obj24.gxTpr_Empleadospisoextext_Z;
         Z49empleadospisoextcorreo = obj24.gxTpr_Empleadospisoextcorreo_Z;
         Z50empleadopisoextprofesion = obj24.gxTpr_Empleadopisoextprofesion_Z;
         Z51empleadospisoextusuario = obj24.gxTpr_Empleadospisoextusuario_Z;
         Z52empleadospisoextfecgre = obj24.gxTpr_Empleadospisoextfecgre_Z;
         Z53empleadospisoextfeact = obj24.gxTpr_Empleadospisoextfeact_Z;
         Gx_mode = obj24.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A46empleadospisoextid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0O24( ) ;
         ScanKeyStart0O24( ) ;
         if ( RcdFound24 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z46empleadospisoextid = A46empleadospisoextid;
         }
         ZM0O24( -1) ;
         OnLoadActions0O24( ) ;
         AddRow0O24( ) ;
         ScanKeyEnd0O24( ) ;
         if ( RcdFound24 == 0 )
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
         RowToVars24( bcempleadospiso, 0) ;
         ScanKeyStart0O24( ) ;
         if ( RcdFound24 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z46empleadospisoextid = A46empleadospisoextid;
         }
         ZM0O24( -1) ;
         OnLoadActions0O24( ) ;
         AddRow0O24( ) ;
         ScanKeyEnd0O24( ) ;
         if ( RcdFound24 == 0 )
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
         RowToVars24( bcempleadospiso, 0) ;
         nKeyPressed = 1;
         GetKey0O24( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0O24( ) ;
         }
         else
         {
            if ( RcdFound24 == 1 )
            {
               if ( A46empleadospisoextid != Z46empleadospisoextid )
               {
                  A46empleadospisoextid = Z46empleadospisoextid;
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
                  Update0O24( ) ;
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
                  if ( A46empleadospisoextid != Z46empleadospisoextid )
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
                        Insert0O24( ) ;
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
                        Insert0O24( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow24( bcempleadospiso) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars24( bcempleadospiso, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0O24( ) ;
         if ( RcdFound24 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A46empleadospisoextid != Z46empleadospisoextid )
            {
               A46empleadospisoextid = Z46empleadospisoextid;
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
            if ( A46empleadospisoextid != Z46empleadospisoextid )
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
         context.RollbackDataStores( "empleadospiso_BC");
         VarsToRow24( bcempleadospiso) ;
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
         Gx_mode = bcempleadospiso.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcempleadospiso.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcempleadospiso )
         {
            bcempleadospiso = (Sdtempleadospiso)(sdt);
            if ( StringUtil.StrCmp(bcempleadospiso.gxTpr_Mode, "") == 0 )
            {
               bcempleadospiso.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow24( bcempleadospiso) ;
            }
            else
            {
               RowToVars24( bcempleadospiso, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcempleadospiso.gxTpr_Mode, "") == 0 )
            {
               bcempleadospiso.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars24( bcempleadospiso, 1) ;
         return  ;
      }

      public Sdtempleadospiso empleadospiso_BC
      {
         get {
            return bcempleadospiso ;
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
         Z47empleadospisoextpiso = "";
         A47empleadospisoextpiso = "";
         Z48empleadospisoextext = "";
         A48empleadospisoextext = "";
         Z49empleadospisoextcorreo = "";
         A49empleadospisoextcorreo = "";
         Z51empleadospisoextusuario = "";
         A51empleadospisoextusuario = "";
         Z52empleadospisoextfecgre = DateTime.MinValue;
         A52empleadospisoextfecgre = DateTime.MinValue;
         Z53empleadospisoextfeact = DateTime.MinValue;
         A53empleadospisoextfeact = DateTime.MinValue;
         BC000O4_A46empleadospisoextid = new int[1] ;
         BC000O4_A47empleadospisoextpiso = new String[] {""} ;
         BC000O4_A48empleadospisoextext = new String[] {""} ;
         BC000O4_A49empleadospisoextcorreo = new String[] {""} ;
         BC000O4_A50empleadopisoextprofesion = new long[1] ;
         BC000O4_A51empleadospisoextusuario = new String[] {""} ;
         BC000O4_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         BC000O4_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         BC000O5_A46empleadospisoextid = new int[1] ;
         BC000O3_A46empleadospisoextid = new int[1] ;
         BC000O3_A47empleadospisoextpiso = new String[] {""} ;
         BC000O3_A48empleadospisoextext = new String[] {""} ;
         BC000O3_A49empleadospisoextcorreo = new String[] {""} ;
         BC000O3_A50empleadopisoextprofesion = new long[1] ;
         BC000O3_A51empleadospisoextusuario = new String[] {""} ;
         BC000O3_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         BC000O3_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         sMode24 = "";
         BC000O2_A46empleadospisoextid = new int[1] ;
         BC000O2_A47empleadospisoextpiso = new String[] {""} ;
         BC000O2_A48empleadospisoextext = new String[] {""} ;
         BC000O2_A49empleadospisoextcorreo = new String[] {""} ;
         BC000O2_A50empleadopisoextprofesion = new long[1] ;
         BC000O2_A51empleadospisoextusuario = new String[] {""} ;
         BC000O2_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         BC000O2_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         BC000O9_A46empleadospisoextid = new int[1] ;
         BC000O9_A47empleadospisoextpiso = new String[] {""} ;
         BC000O9_A48empleadospisoextext = new String[] {""} ;
         BC000O9_A49empleadospisoextcorreo = new String[] {""} ;
         BC000O9_A50empleadopisoextprofesion = new long[1] ;
         BC000O9_A51empleadospisoextusuario = new String[] {""} ;
         BC000O9_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         BC000O9_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleadospiso_bc__default(),
            new Object[][] {
                new Object[] {
               BC000O2_A46empleadospisoextid, BC000O2_A47empleadospisoextpiso, BC000O2_A48empleadospisoextext, BC000O2_A49empleadospisoextcorreo, BC000O2_A50empleadopisoextprofesion, BC000O2_A51empleadospisoextusuario, BC000O2_A52empleadospisoextfecgre, BC000O2_A53empleadospisoextfeact
               }
               , new Object[] {
               BC000O3_A46empleadospisoextid, BC000O3_A47empleadospisoextpiso, BC000O3_A48empleadospisoextext, BC000O3_A49empleadospisoextcorreo, BC000O3_A50empleadopisoextprofesion, BC000O3_A51empleadospisoextusuario, BC000O3_A52empleadospisoextfecgre, BC000O3_A53empleadospisoextfeact
               }
               , new Object[] {
               BC000O4_A46empleadospisoextid, BC000O4_A47empleadospisoextpiso, BC000O4_A48empleadospisoextext, BC000O4_A49empleadospisoextcorreo, BC000O4_A50empleadopisoextprofesion, BC000O4_A51empleadospisoextusuario, BC000O4_A52empleadospisoextfecgre, BC000O4_A53empleadospisoextfeact
               }
               , new Object[] {
               BC000O5_A46empleadospisoextid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000O9_A46empleadospisoextid, BC000O9_A47empleadospisoextpiso, BC000O9_A48empleadospisoextext, BC000O9_A49empleadospisoextcorreo, BC000O9_A50empleadopisoextprofesion, BC000O9_A51empleadospisoextusuario, BC000O9_A52empleadospisoextfecgre, BC000O9_A53empleadospisoextfeact
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
      private short RcdFound24 ;
      private int trnEnded ;
      private int Z46empleadospisoextid ;
      private int A46empleadospisoextid ;
      private long Z50empleadopisoextprofesion ;
      private long A50empleadopisoextprofesion ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode24 ;
      private DateTime Z52empleadospisoextfecgre ;
      private DateTime A52empleadospisoextfecgre ;
      private DateTime Z53empleadospisoextfeact ;
      private DateTime A53empleadospisoextfeact ;
      private bool Gx_longc ;
      private String Z47empleadospisoextpiso ;
      private String A47empleadospisoextpiso ;
      private String Z48empleadospisoextext ;
      private String A48empleadospisoextext ;
      private String Z49empleadospisoextcorreo ;
      private String A49empleadospisoextcorreo ;
      private String Z51empleadospisoextusuario ;
      private String A51empleadospisoextusuario ;
      private Sdtempleadospiso bcempleadospiso ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000O4_A46empleadospisoextid ;
      private String[] BC000O4_A47empleadospisoextpiso ;
      private String[] BC000O4_A48empleadospisoextext ;
      private String[] BC000O4_A49empleadospisoextcorreo ;
      private long[] BC000O4_A50empleadopisoextprofesion ;
      private String[] BC000O4_A51empleadospisoextusuario ;
      private DateTime[] BC000O4_A52empleadospisoextfecgre ;
      private DateTime[] BC000O4_A53empleadospisoextfeact ;
      private int[] BC000O5_A46empleadospisoextid ;
      private int[] BC000O3_A46empleadospisoextid ;
      private String[] BC000O3_A47empleadospisoextpiso ;
      private String[] BC000O3_A48empleadospisoextext ;
      private String[] BC000O3_A49empleadospisoextcorreo ;
      private long[] BC000O3_A50empleadopisoextprofesion ;
      private String[] BC000O3_A51empleadospisoextusuario ;
      private DateTime[] BC000O3_A52empleadospisoextfecgre ;
      private DateTime[] BC000O3_A53empleadospisoextfeact ;
      private int[] BC000O2_A46empleadospisoextid ;
      private String[] BC000O2_A47empleadospisoextpiso ;
      private String[] BC000O2_A48empleadospisoextext ;
      private String[] BC000O2_A49empleadospisoextcorreo ;
      private long[] BC000O2_A50empleadopisoextprofesion ;
      private String[] BC000O2_A51empleadospisoextusuario ;
      private DateTime[] BC000O2_A52empleadospisoextfecgre ;
      private DateTime[] BC000O2_A53empleadospisoextfeact ;
      private int[] BC000O9_A46empleadospisoextid ;
      private String[] BC000O9_A47empleadospisoextpiso ;
      private String[] BC000O9_A48empleadospisoextext ;
      private String[] BC000O9_A49empleadospisoextcorreo ;
      private long[] BC000O9_A50empleadopisoextprofesion ;
      private String[] BC000O9_A51empleadospisoextusuario ;
      private DateTime[] BC000O9_A52empleadospisoextfecgre ;
      private DateTime[] BC000O9_A53empleadospisoextfeact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class empleadospiso_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000O4 ;
          prmBC000O4 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O5 ;
          prmBC000O5 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O3 ;
          prmBC000O3 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O2 ;
          prmBC000O2 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O6 ;
          prmBC000O6 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"empleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"empleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadospisoextfecgre",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextfeact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmBC000O7 ;
          prmBC000O7 = new Object[] {
          new Object[] {"empleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"empleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadospisoextfecgre",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextfeact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O8 ;
          prmBC000O8 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000O9 ;
          prmBC000O9 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000O2", "SELECT empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid  FOR UPDATE OF empleadospiso",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O2,1,0,true,false )
             ,new CursorDef("BC000O3", "SELECT empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O3,1,0,true,false )
             ,new CursorDef("BC000O4", "SELECT TM1.empleadospisoextid, TM1.empleadospisoextpiso, TM1.empleadospisoextext, TM1.empleadospisoextcorreo, TM1.empleadopisoextprofesion, TM1.empleadospisoextusuario, TM1.empleadospisoextfecgre, TM1.empleadospisoextfeact FROM empleadospiso TM1 WHERE TM1.empleadospisoextid = :empleadospisoextid ORDER BY TM1.empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O4,100,0,true,false )
             ,new CursorDef("BC000O5", "SELECT empleadospisoextid FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O5,1,0,true,false )
             ,new CursorDef("BC000O6", "SAVEPOINT gxupdate;INSERT INTO empleadospiso(empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact) VALUES(:empleadospisoextid, :empleadospisoextpiso, :empleadospisoextext, :empleadospisoextcorreo, :empleadopisoextprofesion, :empleadospisoextusuario, :empleadospisoextfecgre, :empleadospisoextfeact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000O6)
             ,new CursorDef("BC000O7", "SAVEPOINT gxupdate;UPDATE empleadospiso SET empleadospisoextpiso=:empleadospisoextpiso, empleadospisoextext=:empleadospisoextext, empleadospisoextcorreo=:empleadospisoextcorreo, empleadopisoextprofesion=:empleadopisoextprofesion, empleadospisoextusuario=:empleadospisoextusuario, empleadospisoextfecgre=:empleadospisoextfecgre, empleadospisoextfeact=:empleadospisoextfeact  WHERE empleadospisoextid = :empleadospisoextid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000O7)
             ,new CursorDef("BC000O8", "SAVEPOINT gxupdate;DELETE FROM empleadospiso  WHERE empleadospisoextid = :empleadospisoextid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000O8)
             ,new CursorDef("BC000O9", "SELECT TM1.empleadospisoextid, TM1.empleadospisoextpiso, TM1.empleadospisoextext, TM1.empleadospisoextcorreo, TM1.empleadopisoextprofesion, TM1.empleadospisoextusuario, TM1.empleadospisoextfecgre, TM1.empleadospisoextfeact FROM empleadospiso TM1 WHERE TM1.empleadospisoextid = :empleadospisoextid ORDER BY TM1.empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O9,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (long)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (int)parms[7]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
