/*
               File: modelos_BC
        Description: modelos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:25.26
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
   public class modelos_bc : GXHttpHandler, IGxSilentTrn
   {
      public modelos_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public modelos_bc( IGxContext context )
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
         ReadRow0J19( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0J19( ) ;
         standaloneModal( ) ;
         AddRow0J19( ) ;
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
               Z15modelosid = A15modelosid;
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

      protected void CONFIRM_0J0( )
      {
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0J19( ) ;
            }
            else
            {
               CheckExtendedTable0J19( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0J19( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0J19( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z116modelosdsc = A116modelosdsc;
            Z117modelosusuario = A117modelosusuario;
            Z118modelosfecreg = A118modelosfecreg;
            Z119modelosfecultact = A119modelosfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z15modelosid = A15modelosid;
            Z116modelosdsc = A116modelosdsc;
            Z117modelosusuario = A117modelosusuario;
            Z118modelosfecreg = A118modelosfecreg;
            Z119modelosfecultact = A119modelosfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0J19( )
      {
         /* Using cursor BC000J4 */
         pr_default.execute(2, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound19 = 1;
            A116modelosdsc = BC000J4_A116modelosdsc[0];
            n116modelosdsc = BC000J4_n116modelosdsc[0];
            A117modelosusuario = BC000J4_A117modelosusuario[0];
            n117modelosusuario = BC000J4_n117modelosusuario[0];
            A118modelosfecreg = BC000J4_A118modelosfecreg[0];
            n118modelosfecreg = BC000J4_n118modelosfecreg[0];
            A119modelosfecultact = BC000J4_A119modelosfecultact[0];
            n119modelosfecultact = BC000J4_n119modelosfecultact[0];
            ZM0J19( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0J19( ) ;
      }

      protected void OnLoadActions0J19( )
      {
      }

      protected void CheckExtendedTable0J19( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0J19( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0J19( )
      {
         /* Using cursor BC000J5 */
         pr_default.execute(3, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound19 = 1;
         }
         else
         {
            RcdFound19 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000J3 */
         pr_default.execute(1, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0J19( 1) ;
            RcdFound19 = 1;
            A15modelosid = BC000J3_A15modelosid[0];
            A116modelosdsc = BC000J3_A116modelosdsc[0];
            n116modelosdsc = BC000J3_n116modelosdsc[0];
            A117modelosusuario = BC000J3_A117modelosusuario[0];
            n117modelosusuario = BC000J3_n117modelosusuario[0];
            A118modelosfecreg = BC000J3_A118modelosfecreg[0];
            n118modelosfecreg = BC000J3_n118modelosfecreg[0];
            A119modelosfecultact = BC000J3_A119modelosfecultact[0];
            n119modelosfecultact = BC000J3_n119modelosfecultact[0];
            Z15modelosid = A15modelosid;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0J19( ) ;
            if ( AnyError == 1 )
            {
               RcdFound19 = 0;
               InitializeNonKey0J19( ) ;
            }
            Gx_mode = sMode19;
         }
         else
         {
            RcdFound19 = 0;
            InitializeNonKey0J19( ) ;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode19;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0J19( ) ;
         if ( RcdFound19 == 0 )
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
         CONFIRM_0J0( ) ;
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

      protected void CheckOptimisticConcurrency0J19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000J2 */
            pr_default.execute(0, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MODELOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z116modelosdsc, BC000J2_A116modelosdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z117modelosusuario, BC000J2_A117modelosusuario[0]) != 0 ) || ( Z118modelosfecreg != BC000J2_A118modelosfecreg[0] ) || ( Z119modelosfecultact != BC000J2_A119modelosfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MODELOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0J19( )
      {
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J19( 0) ;
            CheckOptimisticConcurrency0J19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000J6 */
                     pr_default.execute(4, new Object[] {A15modelosid, n116modelosdsc, A116modelosdsc, n117modelosusuario, A117modelosusuario, n118modelosfecreg, A118modelosfecreg, n119modelosfecultact, A119modelosfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
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
               Load0J19( ) ;
            }
            EndLevel0J19( ) ;
         }
         CloseExtendedTableCursors0J19( ) ;
      }

      protected void Update0J19( )
      {
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000J7 */
                     pr_default.execute(5, new Object[] {n116modelosdsc, A116modelosdsc, n117modelosusuario, A117modelosusuario, n118modelosfecreg, A118modelosfecreg, n119modelosfecultact, A119modelosfecultact, A15modelosid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MODELOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0J19( ) ;
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
            EndLevel0J19( ) ;
         }
         CloseExtendedTableCursors0J19( ) ;
      }

      protected void DeferredUpdate0J19( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J19( ) ;
            AfterConfirm0J19( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J19( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000J8 */
                  pr_default.execute(6, new Object[] {A15modelosid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
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
         sMode19 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0J19( ) ;
         Gx_mode = sMode19;
      }

      protected void OnDeleteControls0J19( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000J9 */
            pr_default.execute(7, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000J10 */
            pr_default.execute(8, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel0J19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0J19( ) ;
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

      public void ScanKeyStart0J19( )
      {
         /* Using cursor BC000J11 */
         pr_default.execute(9, new Object[] {A15modelosid});
         RcdFound19 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound19 = 1;
            A15modelosid = BC000J11_A15modelosid[0];
            A116modelosdsc = BC000J11_A116modelosdsc[0];
            n116modelosdsc = BC000J11_n116modelosdsc[0];
            A117modelosusuario = BC000J11_A117modelosusuario[0];
            n117modelosusuario = BC000J11_n117modelosusuario[0];
            A118modelosfecreg = BC000J11_A118modelosfecreg[0];
            n118modelosfecreg = BC000J11_n118modelosfecreg[0];
            A119modelosfecultact = BC000J11_A119modelosfecultact[0];
            n119modelosfecultact = BC000J11_n119modelosfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0J19( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound19 = 0;
         ScanKeyLoad0J19( ) ;
      }

      protected void ScanKeyLoad0J19( )
      {
         sMode19 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound19 = 1;
            A15modelosid = BC000J11_A15modelosid[0];
            A116modelosdsc = BC000J11_A116modelosdsc[0];
            n116modelosdsc = BC000J11_n116modelosdsc[0];
            A117modelosusuario = BC000J11_A117modelosusuario[0];
            n117modelosusuario = BC000J11_n117modelosusuario[0];
            A118modelosfecreg = BC000J11_A118modelosfecreg[0];
            n118modelosfecreg = BC000J11_n118modelosfecreg[0];
            A119modelosfecultact = BC000J11_A119modelosfecultact[0];
            n119modelosfecultact = BC000J11_n119modelosfecultact[0];
         }
         Gx_mode = sMode19;
      }

      protected void ScanKeyEnd0J19( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0J19( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J19( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J19( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J19( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J19( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J19( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J19( )
      {
      }

      protected void AddRow0J19( )
      {
         VarsToRow19( bcmodelos) ;
      }

      protected void ReadRow0J19( )
      {
         RowToVars19( bcmodelos, 1) ;
      }

      protected void InitializeNonKey0J19( )
      {
         A116modelosdsc = "";
         n116modelosdsc = false;
         A117modelosusuario = "";
         n117modelosusuario = false;
         A118modelosfecreg = (DateTime)(DateTime.MinValue);
         n118modelosfecreg = false;
         A119modelosfecultact = (DateTime)(DateTime.MinValue);
         n119modelosfecultact = false;
         Z116modelosdsc = "";
         Z117modelosusuario = "";
         Z118modelosfecreg = (DateTime)(DateTime.MinValue);
         Z119modelosfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0J19( )
      {
         A15modelosid = 0;
         InitializeNonKey0J19( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow19( Sdtmodelos obj19 )
      {
         obj19.gxTpr_Mode = Gx_mode;
         obj19.gxTpr_Modelosdsc = A116modelosdsc;
         obj19.gxTpr_Modelosusuario = A117modelosusuario;
         obj19.gxTpr_Modelosfecreg = A118modelosfecreg;
         obj19.gxTpr_Modelosfecultact = A119modelosfecultact;
         obj19.gxTpr_Modelosid = A15modelosid;
         obj19.gxTpr_Modelosid_Z = Z15modelosid;
         obj19.gxTpr_Modelosdsc_Z = Z116modelosdsc;
         obj19.gxTpr_Modelosusuario_Z = Z117modelosusuario;
         obj19.gxTpr_Modelosfecreg_Z = Z118modelosfecreg;
         obj19.gxTpr_Modelosfecultact_Z = Z119modelosfecultact;
         obj19.gxTpr_Modelosdsc_N = (short)(Convert.ToInt16(n116modelosdsc));
         obj19.gxTpr_Modelosusuario_N = (short)(Convert.ToInt16(n117modelosusuario));
         obj19.gxTpr_Modelosfecreg_N = (short)(Convert.ToInt16(n118modelosfecreg));
         obj19.gxTpr_Modelosfecultact_N = (short)(Convert.ToInt16(n119modelosfecultact));
         obj19.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow19( Sdtmodelos obj19 )
      {
         obj19.gxTpr_Modelosid = A15modelosid;
         return  ;
      }

      public void RowToVars19( Sdtmodelos obj19 ,
                               int forceLoad )
      {
         Gx_mode = obj19.gxTpr_Mode;
         A116modelosdsc = obj19.gxTpr_Modelosdsc;
         n116modelosdsc = false;
         A117modelosusuario = obj19.gxTpr_Modelosusuario;
         n117modelosusuario = false;
         A118modelosfecreg = obj19.gxTpr_Modelosfecreg;
         n118modelosfecreg = false;
         A119modelosfecultact = obj19.gxTpr_Modelosfecultact;
         n119modelosfecultact = false;
         A15modelosid = obj19.gxTpr_Modelosid;
         Z15modelosid = obj19.gxTpr_Modelosid_Z;
         Z116modelosdsc = obj19.gxTpr_Modelosdsc_Z;
         Z117modelosusuario = obj19.gxTpr_Modelosusuario_Z;
         Z118modelosfecreg = obj19.gxTpr_Modelosfecreg_Z;
         Z119modelosfecultact = obj19.gxTpr_Modelosfecultact_Z;
         n116modelosdsc = (bool)(Convert.ToBoolean(obj19.gxTpr_Modelosdsc_N));
         n117modelosusuario = (bool)(Convert.ToBoolean(obj19.gxTpr_Modelosusuario_N));
         n118modelosfecreg = (bool)(Convert.ToBoolean(obj19.gxTpr_Modelosfecreg_N));
         n119modelosfecultact = (bool)(Convert.ToBoolean(obj19.gxTpr_Modelosfecultact_N));
         Gx_mode = obj19.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A15modelosid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0J19( ) ;
         ScanKeyStart0J19( ) ;
         if ( RcdFound19 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z15modelosid = A15modelosid;
         }
         ZM0J19( -1) ;
         OnLoadActions0J19( ) ;
         AddRow0J19( ) ;
         ScanKeyEnd0J19( ) ;
         if ( RcdFound19 == 0 )
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
         RowToVars19( bcmodelos, 0) ;
         ScanKeyStart0J19( ) ;
         if ( RcdFound19 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z15modelosid = A15modelosid;
         }
         ZM0J19( -1) ;
         OnLoadActions0J19( ) ;
         AddRow0J19( ) ;
         ScanKeyEnd0J19( ) ;
         if ( RcdFound19 == 0 )
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
         RowToVars19( bcmodelos, 0) ;
         nKeyPressed = 1;
         GetKey0J19( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0J19( ) ;
         }
         else
         {
            if ( RcdFound19 == 1 )
            {
               if ( A15modelosid != Z15modelosid )
               {
                  A15modelosid = Z15modelosid;
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
                  Update0J19( ) ;
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
                  if ( A15modelosid != Z15modelosid )
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
                        Insert0J19( ) ;
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
                        Insert0J19( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow19( bcmodelos) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars19( bcmodelos, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0J19( ) ;
         if ( RcdFound19 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A15modelosid != Z15modelosid )
            {
               A15modelosid = Z15modelosid;
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
            if ( A15modelosid != Z15modelosid )
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
         context.RollbackDataStores( "modelos_BC");
         VarsToRow19( bcmodelos) ;
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
         Gx_mode = bcmodelos.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcmodelos.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcmodelos )
         {
            bcmodelos = (Sdtmodelos)(sdt);
            if ( StringUtil.StrCmp(bcmodelos.gxTpr_Mode, "") == 0 )
            {
               bcmodelos.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow19( bcmodelos) ;
            }
            else
            {
               RowToVars19( bcmodelos, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcmodelos.gxTpr_Mode, "") == 0 )
            {
               bcmodelos.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars19( bcmodelos, 1) ;
         return  ;
      }

      public Sdtmodelos modelos_BC
      {
         get {
            return bcmodelos ;
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
         Z116modelosdsc = "";
         A116modelosdsc = "";
         Z117modelosusuario = "";
         A117modelosusuario = "";
         Z118modelosfecreg = (DateTime)(DateTime.MinValue);
         A118modelosfecreg = (DateTime)(DateTime.MinValue);
         Z119modelosfecultact = (DateTime)(DateTime.MinValue);
         A119modelosfecultact = (DateTime)(DateTime.MinValue);
         BC000J4_A15modelosid = new int[1] ;
         BC000J4_A116modelosdsc = new String[] {""} ;
         BC000J4_n116modelosdsc = new bool[] {false} ;
         BC000J4_A117modelosusuario = new String[] {""} ;
         BC000J4_n117modelosusuario = new bool[] {false} ;
         BC000J4_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000J4_n118modelosfecreg = new bool[] {false} ;
         BC000J4_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000J4_n119modelosfecultact = new bool[] {false} ;
         BC000J5_A15modelosid = new int[1] ;
         BC000J3_A15modelosid = new int[1] ;
         BC000J3_A116modelosdsc = new String[] {""} ;
         BC000J3_n116modelosdsc = new bool[] {false} ;
         BC000J3_A117modelosusuario = new String[] {""} ;
         BC000J3_n117modelosusuario = new bool[] {false} ;
         BC000J3_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000J3_n118modelosfecreg = new bool[] {false} ;
         BC000J3_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000J3_n119modelosfecultact = new bool[] {false} ;
         sMode19 = "";
         BC000J2_A15modelosid = new int[1] ;
         BC000J2_A116modelosdsc = new String[] {""} ;
         BC000J2_n116modelosdsc = new bool[] {false} ;
         BC000J2_A117modelosusuario = new String[] {""} ;
         BC000J2_n117modelosusuario = new bool[] {false} ;
         BC000J2_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000J2_n118modelosfecreg = new bool[] {false} ;
         BC000J2_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000J2_n119modelosfecultact = new bool[] {false} ;
         BC000J9_A19almacenid = new int[1] ;
         BC000J9_A20articulosproductoid = new int[1] ;
         BC000J9_A21articuloscambsid = new int[1] ;
         BC000J10_A17etiquetasproductoid = new int[1] ;
         BC000J10_A18etiquetascambsid = new int[1] ;
         BC000J10_A19almacenid = new int[1] ;
         BC000J11_A15modelosid = new int[1] ;
         BC000J11_A116modelosdsc = new String[] {""} ;
         BC000J11_n116modelosdsc = new bool[] {false} ;
         BC000J11_A117modelosusuario = new String[] {""} ;
         BC000J11_n117modelosusuario = new bool[] {false} ;
         BC000J11_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000J11_n118modelosfecreg = new bool[] {false} ;
         BC000J11_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000J11_n119modelosfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.modelos_bc__default(),
            new Object[][] {
                new Object[] {
               BC000J2_A15modelosid, BC000J2_A116modelosdsc, BC000J2_n116modelosdsc, BC000J2_A117modelosusuario, BC000J2_n117modelosusuario, BC000J2_A118modelosfecreg, BC000J2_n118modelosfecreg, BC000J2_A119modelosfecultact, BC000J2_n119modelosfecultact
               }
               , new Object[] {
               BC000J3_A15modelosid, BC000J3_A116modelosdsc, BC000J3_n116modelosdsc, BC000J3_A117modelosusuario, BC000J3_n117modelosusuario, BC000J3_A118modelosfecreg, BC000J3_n118modelosfecreg, BC000J3_A119modelosfecultact, BC000J3_n119modelosfecultact
               }
               , new Object[] {
               BC000J4_A15modelosid, BC000J4_A116modelosdsc, BC000J4_n116modelosdsc, BC000J4_A117modelosusuario, BC000J4_n117modelosusuario, BC000J4_A118modelosfecreg, BC000J4_n118modelosfecreg, BC000J4_A119modelosfecultact, BC000J4_n119modelosfecultact
               }
               , new Object[] {
               BC000J5_A15modelosid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000J9_A19almacenid, BC000J9_A20articulosproductoid, BC000J9_A21articuloscambsid
               }
               , new Object[] {
               BC000J10_A17etiquetasproductoid, BC000J10_A18etiquetascambsid, BC000J10_A19almacenid
               }
               , new Object[] {
               BC000J11_A15modelosid, BC000J11_A116modelosdsc, BC000J11_n116modelosdsc, BC000J11_A117modelosusuario, BC000J11_n117modelosusuario, BC000J11_A118modelosfecreg, BC000J11_n118modelosfecreg, BC000J11_A119modelosfecultact, BC000J11_n119modelosfecultact
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
      private short RcdFound19 ;
      private int trnEnded ;
      private int Z15modelosid ;
      private int A15modelosid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode19 ;
      private DateTime Z118modelosfecreg ;
      private DateTime A118modelosfecreg ;
      private DateTime Z119modelosfecultact ;
      private DateTime A119modelosfecultact ;
      private bool n116modelosdsc ;
      private bool n117modelosusuario ;
      private bool n118modelosfecreg ;
      private bool n119modelosfecultact ;
      private String Z116modelosdsc ;
      private String A116modelosdsc ;
      private String Z117modelosusuario ;
      private String A117modelosusuario ;
      private Sdtmodelos bcmodelos ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000J4_A15modelosid ;
      private String[] BC000J4_A116modelosdsc ;
      private bool[] BC000J4_n116modelosdsc ;
      private String[] BC000J4_A117modelosusuario ;
      private bool[] BC000J4_n117modelosusuario ;
      private DateTime[] BC000J4_A118modelosfecreg ;
      private bool[] BC000J4_n118modelosfecreg ;
      private DateTime[] BC000J4_A119modelosfecultact ;
      private bool[] BC000J4_n119modelosfecultact ;
      private int[] BC000J5_A15modelosid ;
      private int[] BC000J3_A15modelosid ;
      private String[] BC000J3_A116modelosdsc ;
      private bool[] BC000J3_n116modelosdsc ;
      private String[] BC000J3_A117modelosusuario ;
      private bool[] BC000J3_n117modelosusuario ;
      private DateTime[] BC000J3_A118modelosfecreg ;
      private bool[] BC000J3_n118modelosfecreg ;
      private DateTime[] BC000J3_A119modelosfecultact ;
      private bool[] BC000J3_n119modelosfecultact ;
      private int[] BC000J2_A15modelosid ;
      private String[] BC000J2_A116modelosdsc ;
      private bool[] BC000J2_n116modelosdsc ;
      private String[] BC000J2_A117modelosusuario ;
      private bool[] BC000J2_n117modelosusuario ;
      private DateTime[] BC000J2_A118modelosfecreg ;
      private bool[] BC000J2_n118modelosfecreg ;
      private DateTime[] BC000J2_A119modelosfecultact ;
      private bool[] BC000J2_n119modelosfecultact ;
      private int[] BC000J9_A19almacenid ;
      private int[] BC000J9_A20articulosproductoid ;
      private int[] BC000J9_A21articuloscambsid ;
      private int[] BC000J10_A17etiquetasproductoid ;
      private int[] BC000J10_A18etiquetascambsid ;
      private int[] BC000J10_A19almacenid ;
      private int[] BC000J11_A15modelosid ;
      private String[] BC000J11_A116modelosdsc ;
      private bool[] BC000J11_n116modelosdsc ;
      private String[] BC000J11_A117modelosusuario ;
      private bool[] BC000J11_n117modelosusuario ;
      private DateTime[] BC000J11_A118modelosfecreg ;
      private bool[] BC000J11_n118modelosfecreg ;
      private DateTime[] BC000J11_A119modelosfecultact ;
      private bool[] BC000J11_n119modelosfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class modelos_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000J4 ;
          prmBC000J4 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J5 ;
          prmBC000J5 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J3 ;
          prmBC000J3 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J2 ;
          prmBC000J2 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J6 ;
          prmBC000J6 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"modelosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modelosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"modelosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000J7 ;
          prmBC000J7 = new Object[] {
          new Object[] {"modelosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modelosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"modelosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J8 ;
          prmBC000J8 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J9 ;
          prmBC000J9 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J10 ;
          prmBC000J10 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000J11 ;
          prmBC000J11 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000J2", "SELECT modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact FROM public.modelos WHERE modelosid = :modelosid  FOR UPDATE OF modelos",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J2,1,0,true,false )
             ,new CursorDef("BC000J3", "SELECT modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact FROM public.modelos WHERE modelosid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J3,1,0,true,false )
             ,new CursorDef("BC000J4", "SELECT TM1.modelosid, TM1.modelosdsc, TM1.modelosusuario, TM1.modelosfecreg, TM1.modelosfecultact FROM public.modelos TM1 WHERE TM1.modelosid = :modelosid ORDER BY TM1.modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J4,100,0,true,false )
             ,new CursorDef("BC000J5", "SELECT modelosid FROM public.modelos WHERE modelosid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J5,1,0,true,false )
             ,new CursorDef("BC000J6", "SAVEPOINT gxupdate;INSERT INTO public.modelos(modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact) VALUES(:modelosid, :modelosdsc, :modelosusuario, :modelosfecreg, :modelosfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000J6)
             ,new CursorDef("BC000J7", "SAVEPOINT gxupdate;UPDATE public.modelos SET modelosdsc=:modelosdsc, modelosusuario=:modelosusuario, modelosfecreg=:modelosfecreg, modelosfecultact=:modelosfecultact  WHERE modelosid = :modelosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000J7)
             ,new CursorDef("BC000J8", "SAVEPOINT gxupdate;DELETE FROM public.modelos  WHERE modelosid = :modelosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000J8)
             ,new CursorDef("BC000J9", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE productoid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J9,1,0,true,true )
             ,new CursorDef("BC000J10", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE productoid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J10,1,0,true,true )
             ,new CursorDef("BC000J11", "SELECT TM1.modelosid, TM1.modelosdsc, TM1.modelosusuario, TM1.modelosfecreg, TM1.modelosfecultact FROM public.modelos TM1 WHERE TM1.modelosid = :modelosid ORDER BY TM1.modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J11,100,0,true,false )
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
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[8]);
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[7]);
                }
                stmt.SetParameter(5, (int)parms[8]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
