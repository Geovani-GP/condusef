/*
               File: tipodocumento_BC
        Description: tipodocumento
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:7:43.66
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
   public class tipodocumento_bc : GXHttpHandler, IGxSilentTrn
   {
      public tipodocumento_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public tipodocumento_bc( IGxContext context )
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
         ReadRow0K20( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0K20( ) ;
         standaloneModal( ) ;
         AddRow0K20( ) ;
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
               Z26tipodocumentoid = A26tipodocumentoid;
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

      protected void CONFIRM_0K0( )
      {
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0K20( ) ;
            }
            else
            {
               CheckExtendedTable0K20( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0K20( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0K20( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z79tipodocumentodsc = A79tipodocumentodsc;
            Z80tipodocumentousuario = A80tipodocumentousuario;
            Z81tipodocumentofecreg = A81tipodocumentofecreg;
            Z82tipodocumentofecultact = A82tipodocumentofecultact;
         }
         if ( GX_JID == -1 )
         {
            Z26tipodocumentoid = A26tipodocumentoid;
            Z79tipodocumentodsc = A79tipodocumentodsc;
            Z80tipodocumentousuario = A80tipodocumentousuario;
            Z81tipodocumentofecreg = A81tipodocumentofecreg;
            Z82tipodocumentofecultact = A82tipodocumentofecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0K20( )
      {
         /* Using cursor BC000K4 */
         pr_default.execute(2, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound20 = 1;
            A79tipodocumentodsc = BC000K4_A79tipodocumentodsc[0];
            n79tipodocumentodsc = BC000K4_n79tipodocumentodsc[0];
            A80tipodocumentousuario = BC000K4_A80tipodocumentousuario[0];
            n80tipodocumentousuario = BC000K4_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = BC000K4_A81tipodocumentofecreg[0];
            n81tipodocumentofecreg = BC000K4_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = BC000K4_A82tipodocumentofecultact[0];
            n82tipodocumentofecultact = BC000K4_n82tipodocumentofecultact[0];
            ZM0K20( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0K20( ) ;
      }

      protected void OnLoadActions0K20( )
      {
      }

      protected void CheckExtendedTable0K20( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0K20( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0K20( )
      {
         /* Using cursor BC000K5 */
         pr_default.execute(3, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound20 = 1;
         }
         else
         {
            RcdFound20 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000K3 */
         pr_default.execute(1, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0K20( 1) ;
            RcdFound20 = 1;
            A26tipodocumentoid = BC000K3_A26tipodocumentoid[0];
            A79tipodocumentodsc = BC000K3_A79tipodocumentodsc[0];
            n79tipodocumentodsc = BC000K3_n79tipodocumentodsc[0];
            A80tipodocumentousuario = BC000K3_A80tipodocumentousuario[0];
            n80tipodocumentousuario = BC000K3_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = BC000K3_A81tipodocumentofecreg[0];
            n81tipodocumentofecreg = BC000K3_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = BC000K3_A82tipodocumentofecultact[0];
            n82tipodocumentofecultact = BC000K3_n82tipodocumentofecultact[0];
            Z26tipodocumentoid = A26tipodocumentoid;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0K20( ) ;
            if ( AnyError == 1 )
            {
               RcdFound20 = 0;
               InitializeNonKey0K20( ) ;
            }
            Gx_mode = sMode20;
         }
         else
         {
            RcdFound20 = 0;
            InitializeNonKey0K20( ) ;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode20;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0K20( ) ;
         if ( RcdFound20 == 0 )
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
         CONFIRM_0K0( ) ;
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

      protected void CheckOptimisticConcurrency0K20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000K2 */
            pr_default.execute(0, new Object[] {A26tipodocumentoid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPODOCUMENTO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z79tipodocumentodsc, BC000K2_A79tipodocumentodsc[0]) != 0 ) || ( StringUtil.StrCmp(Z80tipodocumentousuario, BC000K2_A80tipodocumentousuario[0]) != 0 ) || ( Z81tipodocumentofecreg != BC000K2_A81tipodocumentofecreg[0] ) || ( Z82tipodocumentofecultact != BC000K2_A82tipodocumentofecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TIPODOCUMENTO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0K20( )
      {
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0K20( 0) ;
            CheckOptimisticConcurrency0K20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0K20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000K6 */
                     pr_default.execute(4, new Object[] {A26tipodocumentoid, n79tipodocumentodsc, A79tipodocumentodsc, n80tipodocumentousuario, A80tipodocumentousuario, n81tipodocumentofecreg, A81tipodocumentofecreg, n82tipodocumentofecultact, A82tipodocumentofecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
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
               Load0K20( ) ;
            }
            EndLevel0K20( ) ;
         }
         CloseExtendedTableCursors0K20( ) ;
      }

      protected void Update0K20( )
      {
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0K20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000K7 */
                     pr_default.execute(5, new Object[] {n79tipodocumentodsc, A79tipodocumentodsc, n80tipodocumentousuario, A80tipodocumentousuario, n81tipodocumentofecreg, A81tipodocumentofecreg, n82tipodocumentofecultact, A82tipodocumentofecultact, A26tipodocumentoid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPODOCUMENTO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0K20( ) ;
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
            EndLevel0K20( ) ;
         }
         CloseExtendedTableCursors0K20( ) ;
      }

      protected void DeferredUpdate0K20( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0K20( ) ;
            AfterConfirm0K20( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0K20( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000K8 */
                  pr_default.execute(6, new Object[] {A26tipodocumentoid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
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
         sMode20 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0K20( ) ;
         Gx_mode = sMode20;
      }

      protected void OnDeleteControls0K20( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0K20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0K20( ) ;
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

      public void ScanKeyStart0K20( )
      {
         /* Using cursor BC000K9 */
         pr_default.execute(7, new Object[] {A26tipodocumentoid});
         RcdFound20 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound20 = 1;
            A26tipodocumentoid = BC000K9_A26tipodocumentoid[0];
            A79tipodocumentodsc = BC000K9_A79tipodocumentodsc[0];
            n79tipodocumentodsc = BC000K9_n79tipodocumentodsc[0];
            A80tipodocumentousuario = BC000K9_A80tipodocumentousuario[0];
            n80tipodocumentousuario = BC000K9_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = BC000K9_A81tipodocumentofecreg[0];
            n81tipodocumentofecreg = BC000K9_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = BC000K9_A82tipodocumentofecultact[0];
            n82tipodocumentofecultact = BC000K9_n82tipodocumentofecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0K20( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound20 = 0;
         ScanKeyLoad0K20( ) ;
      }

      protected void ScanKeyLoad0K20( )
      {
         sMode20 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound20 = 1;
            A26tipodocumentoid = BC000K9_A26tipodocumentoid[0];
            A79tipodocumentodsc = BC000K9_A79tipodocumentodsc[0];
            n79tipodocumentodsc = BC000K9_n79tipodocumentodsc[0];
            A80tipodocumentousuario = BC000K9_A80tipodocumentousuario[0];
            n80tipodocumentousuario = BC000K9_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = BC000K9_A81tipodocumentofecreg[0];
            n81tipodocumentofecreg = BC000K9_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = BC000K9_A82tipodocumentofecultact[0];
            n82tipodocumentofecultact = BC000K9_n82tipodocumentofecultact[0];
         }
         Gx_mode = sMode20;
      }

      protected void ScanKeyEnd0K20( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0K20( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0K20( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0K20( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0K20( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0K20( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0K20( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0K20( )
      {
      }

      protected void AddRow0K20( )
      {
         VarsToRow20( bctipodocumento) ;
      }

      protected void ReadRow0K20( )
      {
         RowToVars20( bctipodocumento, 1) ;
      }

      protected void InitializeNonKey0K20( )
      {
         A79tipodocumentodsc = "";
         n79tipodocumentodsc = false;
         A80tipodocumentousuario = "";
         n80tipodocumentousuario = false;
         A81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         n81tipodocumentofecreg = false;
         A82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         n82tipodocumentofecultact = false;
         Z79tipodocumentodsc = "";
         Z80tipodocumentousuario = "";
         Z81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         Z82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0K20( )
      {
         A26tipodocumentoid = 0;
         InitializeNonKey0K20( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow20( Sdttipodocumento obj20 )
      {
         obj20.gxTpr_Mode = Gx_mode;
         obj20.gxTpr_Tipodocumentodsc = A79tipodocumentodsc;
         obj20.gxTpr_Tipodocumentousuario = A80tipodocumentousuario;
         obj20.gxTpr_Tipodocumentofecreg = A81tipodocumentofecreg;
         obj20.gxTpr_Tipodocumentofecultact = A82tipodocumentofecultact;
         obj20.gxTpr_Tipodocumentoid = A26tipodocumentoid;
         obj20.gxTpr_Tipodocumentoid_Z = Z26tipodocumentoid;
         obj20.gxTpr_Tipodocumentodsc_Z = Z79tipodocumentodsc;
         obj20.gxTpr_Tipodocumentousuario_Z = Z80tipodocumentousuario;
         obj20.gxTpr_Tipodocumentofecreg_Z = Z81tipodocumentofecreg;
         obj20.gxTpr_Tipodocumentofecultact_Z = Z82tipodocumentofecultact;
         obj20.gxTpr_Tipodocumentodsc_N = (short)(Convert.ToInt16(n79tipodocumentodsc));
         obj20.gxTpr_Tipodocumentousuario_N = (short)(Convert.ToInt16(n80tipodocumentousuario));
         obj20.gxTpr_Tipodocumentofecreg_N = (short)(Convert.ToInt16(n81tipodocumentofecreg));
         obj20.gxTpr_Tipodocumentofecultact_N = (short)(Convert.ToInt16(n82tipodocumentofecultact));
         obj20.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow20( Sdttipodocumento obj20 )
      {
         obj20.gxTpr_Tipodocumentoid = A26tipodocumentoid;
         return  ;
      }

      public void RowToVars20( Sdttipodocumento obj20 ,
                               int forceLoad )
      {
         Gx_mode = obj20.gxTpr_Mode;
         A79tipodocumentodsc = obj20.gxTpr_Tipodocumentodsc;
         n79tipodocumentodsc = false;
         A80tipodocumentousuario = obj20.gxTpr_Tipodocumentousuario;
         n80tipodocumentousuario = false;
         A81tipodocumentofecreg = obj20.gxTpr_Tipodocumentofecreg;
         n81tipodocumentofecreg = false;
         A82tipodocumentofecultact = obj20.gxTpr_Tipodocumentofecultact;
         n82tipodocumentofecultact = false;
         A26tipodocumentoid = obj20.gxTpr_Tipodocumentoid;
         Z26tipodocumentoid = obj20.gxTpr_Tipodocumentoid_Z;
         Z79tipodocumentodsc = obj20.gxTpr_Tipodocumentodsc_Z;
         Z80tipodocumentousuario = obj20.gxTpr_Tipodocumentousuario_Z;
         Z81tipodocumentofecreg = obj20.gxTpr_Tipodocumentofecreg_Z;
         Z82tipodocumentofecultact = obj20.gxTpr_Tipodocumentofecultact_Z;
         n79tipodocumentodsc = (bool)(Convert.ToBoolean(obj20.gxTpr_Tipodocumentodsc_N));
         n80tipodocumentousuario = (bool)(Convert.ToBoolean(obj20.gxTpr_Tipodocumentousuario_N));
         n81tipodocumentofecreg = (bool)(Convert.ToBoolean(obj20.gxTpr_Tipodocumentofecreg_N));
         n82tipodocumentofecultact = (bool)(Convert.ToBoolean(obj20.gxTpr_Tipodocumentofecultact_N));
         Gx_mode = obj20.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A26tipodocumentoid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0K20( ) ;
         ScanKeyStart0K20( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z26tipodocumentoid = A26tipodocumentoid;
         }
         ZM0K20( -1) ;
         OnLoadActions0K20( ) ;
         AddRow0K20( ) ;
         ScanKeyEnd0K20( ) ;
         if ( RcdFound20 == 0 )
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
         RowToVars20( bctipodocumento, 0) ;
         ScanKeyStart0K20( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z26tipodocumentoid = A26tipodocumentoid;
         }
         ZM0K20( -1) ;
         OnLoadActions0K20( ) ;
         AddRow0K20( ) ;
         ScanKeyEnd0K20( ) ;
         if ( RcdFound20 == 0 )
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
         RowToVars20( bctipodocumento, 0) ;
         nKeyPressed = 1;
         GetKey0K20( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0K20( ) ;
         }
         else
         {
            if ( RcdFound20 == 1 )
            {
               if ( A26tipodocumentoid != Z26tipodocumentoid )
               {
                  A26tipodocumentoid = Z26tipodocumentoid;
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
                  Update0K20( ) ;
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
                  if ( A26tipodocumentoid != Z26tipodocumentoid )
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
                        Insert0K20( ) ;
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
                        Insert0K20( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow20( bctipodocumento) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars20( bctipodocumento, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0K20( ) ;
         if ( RcdFound20 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A26tipodocumentoid != Z26tipodocumentoid )
            {
               A26tipodocumentoid = Z26tipodocumentoid;
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
            if ( A26tipodocumentoid != Z26tipodocumentoid )
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
         context.RollbackDataStores( "tipodocumento_BC");
         VarsToRow20( bctipodocumento) ;
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
         Gx_mode = bctipodocumento.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bctipodocumento.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bctipodocumento )
         {
            bctipodocumento = (Sdttipodocumento)(sdt);
            if ( StringUtil.StrCmp(bctipodocumento.gxTpr_Mode, "") == 0 )
            {
               bctipodocumento.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow20( bctipodocumento) ;
            }
            else
            {
               RowToVars20( bctipodocumento, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bctipodocumento.gxTpr_Mode, "") == 0 )
            {
               bctipodocumento.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars20( bctipodocumento, 1) ;
         return  ;
      }

      public Sdttipodocumento tipodocumento_BC
      {
         get {
            return bctipodocumento ;
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
         Z79tipodocumentodsc = "";
         A79tipodocumentodsc = "";
         Z80tipodocumentousuario = "";
         A80tipodocumentousuario = "";
         Z81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         A81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         Z82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         A82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         BC000K4_A26tipodocumentoid = new int[1] ;
         BC000K4_A79tipodocumentodsc = new String[] {""} ;
         BC000K4_n79tipodocumentodsc = new bool[] {false} ;
         BC000K4_A80tipodocumentousuario = new String[] {""} ;
         BC000K4_n80tipodocumentousuario = new bool[] {false} ;
         BC000K4_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         BC000K4_n81tipodocumentofecreg = new bool[] {false} ;
         BC000K4_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         BC000K4_n82tipodocumentofecultact = new bool[] {false} ;
         BC000K5_A26tipodocumentoid = new int[1] ;
         BC000K3_A26tipodocumentoid = new int[1] ;
         BC000K3_A79tipodocumentodsc = new String[] {""} ;
         BC000K3_n79tipodocumentodsc = new bool[] {false} ;
         BC000K3_A80tipodocumentousuario = new String[] {""} ;
         BC000K3_n80tipodocumentousuario = new bool[] {false} ;
         BC000K3_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         BC000K3_n81tipodocumentofecreg = new bool[] {false} ;
         BC000K3_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         BC000K3_n82tipodocumentofecultact = new bool[] {false} ;
         sMode20 = "";
         BC000K2_A26tipodocumentoid = new int[1] ;
         BC000K2_A79tipodocumentodsc = new String[] {""} ;
         BC000K2_n79tipodocumentodsc = new bool[] {false} ;
         BC000K2_A80tipodocumentousuario = new String[] {""} ;
         BC000K2_n80tipodocumentousuario = new bool[] {false} ;
         BC000K2_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         BC000K2_n81tipodocumentofecreg = new bool[] {false} ;
         BC000K2_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         BC000K2_n82tipodocumentofecultact = new bool[] {false} ;
         BC000K9_A26tipodocumentoid = new int[1] ;
         BC000K9_A79tipodocumentodsc = new String[] {""} ;
         BC000K9_n79tipodocumentodsc = new bool[] {false} ;
         BC000K9_A80tipodocumentousuario = new String[] {""} ;
         BC000K9_n80tipodocumentousuario = new bool[] {false} ;
         BC000K9_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         BC000K9_n81tipodocumentofecreg = new bool[] {false} ;
         BC000K9_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         BC000K9_n82tipodocumentofecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipodocumento_bc__default(),
            new Object[][] {
                new Object[] {
               BC000K2_A26tipodocumentoid, BC000K2_A79tipodocumentodsc, BC000K2_n79tipodocumentodsc, BC000K2_A80tipodocumentousuario, BC000K2_n80tipodocumentousuario, BC000K2_A81tipodocumentofecreg, BC000K2_n81tipodocumentofecreg, BC000K2_A82tipodocumentofecultact, BC000K2_n82tipodocumentofecultact
               }
               , new Object[] {
               BC000K3_A26tipodocumentoid, BC000K3_A79tipodocumentodsc, BC000K3_n79tipodocumentodsc, BC000K3_A80tipodocumentousuario, BC000K3_n80tipodocumentousuario, BC000K3_A81tipodocumentofecreg, BC000K3_n81tipodocumentofecreg, BC000K3_A82tipodocumentofecultact, BC000K3_n82tipodocumentofecultact
               }
               , new Object[] {
               BC000K4_A26tipodocumentoid, BC000K4_A79tipodocumentodsc, BC000K4_n79tipodocumentodsc, BC000K4_A80tipodocumentousuario, BC000K4_n80tipodocumentousuario, BC000K4_A81tipodocumentofecreg, BC000K4_n81tipodocumentofecreg, BC000K4_A82tipodocumentofecultact, BC000K4_n82tipodocumentofecultact
               }
               , new Object[] {
               BC000K5_A26tipodocumentoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000K9_A26tipodocumentoid, BC000K9_A79tipodocumentodsc, BC000K9_n79tipodocumentodsc, BC000K9_A80tipodocumentousuario, BC000K9_n80tipodocumentousuario, BC000K9_A81tipodocumentofecreg, BC000K9_n81tipodocumentofecreg, BC000K9_A82tipodocumentofecultact, BC000K9_n82tipodocumentofecultact
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
      private short RcdFound20 ;
      private int trnEnded ;
      private int Z26tipodocumentoid ;
      private int A26tipodocumentoid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode20 ;
      private DateTime Z81tipodocumentofecreg ;
      private DateTime A81tipodocumentofecreg ;
      private DateTime Z82tipodocumentofecultact ;
      private DateTime A82tipodocumentofecultact ;
      private bool n79tipodocumentodsc ;
      private bool n80tipodocumentousuario ;
      private bool n81tipodocumentofecreg ;
      private bool n82tipodocumentofecultact ;
      private String Z79tipodocumentodsc ;
      private String A79tipodocumentodsc ;
      private String Z80tipodocumentousuario ;
      private String A80tipodocumentousuario ;
      private Sdttipodocumento bctipodocumento ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000K4_A26tipodocumentoid ;
      private String[] BC000K4_A79tipodocumentodsc ;
      private bool[] BC000K4_n79tipodocumentodsc ;
      private String[] BC000K4_A80tipodocumentousuario ;
      private bool[] BC000K4_n80tipodocumentousuario ;
      private DateTime[] BC000K4_A81tipodocumentofecreg ;
      private bool[] BC000K4_n81tipodocumentofecreg ;
      private DateTime[] BC000K4_A82tipodocumentofecultact ;
      private bool[] BC000K4_n82tipodocumentofecultact ;
      private int[] BC000K5_A26tipodocumentoid ;
      private int[] BC000K3_A26tipodocumentoid ;
      private String[] BC000K3_A79tipodocumentodsc ;
      private bool[] BC000K3_n79tipodocumentodsc ;
      private String[] BC000K3_A80tipodocumentousuario ;
      private bool[] BC000K3_n80tipodocumentousuario ;
      private DateTime[] BC000K3_A81tipodocumentofecreg ;
      private bool[] BC000K3_n81tipodocumentofecreg ;
      private DateTime[] BC000K3_A82tipodocumentofecultact ;
      private bool[] BC000K3_n82tipodocumentofecultact ;
      private int[] BC000K2_A26tipodocumentoid ;
      private String[] BC000K2_A79tipodocumentodsc ;
      private bool[] BC000K2_n79tipodocumentodsc ;
      private String[] BC000K2_A80tipodocumentousuario ;
      private bool[] BC000K2_n80tipodocumentousuario ;
      private DateTime[] BC000K2_A81tipodocumentofecreg ;
      private bool[] BC000K2_n81tipodocumentofecreg ;
      private DateTime[] BC000K2_A82tipodocumentofecultact ;
      private bool[] BC000K2_n82tipodocumentofecultact ;
      private int[] BC000K9_A26tipodocumentoid ;
      private String[] BC000K9_A79tipodocumentodsc ;
      private bool[] BC000K9_n79tipodocumentodsc ;
      private String[] BC000K9_A80tipodocumentousuario ;
      private bool[] BC000K9_n80tipodocumentousuario ;
      private DateTime[] BC000K9_A81tipodocumentofecreg ;
      private bool[] BC000K9_n81tipodocumentofecreg ;
      private DateTime[] BC000K9_A82tipodocumentofecultact ;
      private bool[] BC000K9_n82tipodocumentofecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class tipodocumento_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000K4 ;
          prmBC000K4 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K5 ;
          prmBC000K5 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K3 ;
          prmBC000K3 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K2 ;
          prmBC000K2 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K6 ;
          prmBC000K6 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipodocumentodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipodocumentousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipodocumentofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentofecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000K7 ;
          prmBC000K7 = new Object[] {
          new Object[] {"tipodocumentodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipodocumentousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipodocumentofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K8 ;
          prmBC000K8 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000K9 ;
          prmBC000K9 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000K2", "SELECT tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid  FOR UPDATE OF tipodocumento",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K2,1,0,true,false )
             ,new CursorDef("BC000K3", "SELECT tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K3,1,0,true,false )
             ,new CursorDef("BC000K4", "SELECT TM1.tipodocumentoid, TM1.tipodocumentodsc, TM1.tipodocumentousuario, TM1.tipodocumentofecreg, TM1.tipodocumentofecultact FROM public.tipodocumento TM1 WHERE TM1.tipodocumentoid = :tipodocumentoid ORDER BY TM1.tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K4,100,0,true,false )
             ,new CursorDef("BC000K5", "SELECT tipodocumentoid FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K5,1,0,true,false )
             ,new CursorDef("BC000K6", "SAVEPOINT gxupdate;INSERT INTO public.tipodocumento(tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact) VALUES(:tipodocumentoid, :tipodocumentodsc, :tipodocumentousuario, :tipodocumentofecreg, :tipodocumentofecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000K6)
             ,new CursorDef("BC000K7", "SAVEPOINT gxupdate;UPDATE public.tipodocumento SET tipodocumentodsc=:tipodocumentodsc, tipodocumentousuario=:tipodocumentousuario, tipodocumentofecreg=:tipodocumentofecreg, tipodocumentofecultact=:tipodocumentofecultact  WHERE tipodocumentoid = :tipodocumentoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000K7)
             ,new CursorDef("BC000K8", "SAVEPOINT gxupdate;DELETE FROM public.tipodocumento  WHERE tipodocumentoid = :tipodocumentoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000K8)
             ,new CursorDef("BC000K9", "SELECT TM1.tipodocumentoid, TM1.tipodocumentodsc, TM1.tipodocumentousuario, TM1.tipodocumentofecreg, TM1.tipodocumentofecultact FROM public.tipodocumento TM1 WHERE TM1.tipodocumentoid = :tipodocumentoid ORDER BY TM1.tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K9,100,0,true,false )
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
       }
    }

 }

}
