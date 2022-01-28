/*
               File: cambs_BC
        Description: cambs
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/28/2022 1:40:42.20
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
   public class cambs_bc : GXHttpHandler, IGxSilentTrn
   {
      public cambs_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public cambs_bc( IGxContext context )
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
         ReadRow0E14( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0E14( ) ;
         standaloneModal( ) ;
         AddRow0E14( ) ;
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
               Z25cambsid = A25cambsid;
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

      protected void CONFIRM_0E0( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0E14( ) ;
            }
            else
            {
               CheckExtendedTable0E14( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0E14( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0E14( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z83cambsdsc = A83cambsdsc;
            Z84cambsusuario = A84cambsusuario;
            Z85cambsfecreg = A85cambsfecreg;
            Z86cambsfecultact = A86cambsfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z25cambsid = A25cambsid;
            Z83cambsdsc = A83cambsdsc;
            Z84cambsusuario = A84cambsusuario;
            Z85cambsfecreg = A85cambsfecreg;
            Z86cambsfecultact = A86cambsfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0E14( )
      {
         /* Using cursor BC000E4 */
         pr_default.execute(2, new Object[] {A25cambsid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound14 = 1;
            A83cambsdsc = BC000E4_A83cambsdsc[0];
            n83cambsdsc = BC000E4_n83cambsdsc[0];
            A84cambsusuario = BC000E4_A84cambsusuario[0];
            n84cambsusuario = BC000E4_n84cambsusuario[0];
            A85cambsfecreg = BC000E4_A85cambsfecreg[0];
            n85cambsfecreg = BC000E4_n85cambsfecreg[0];
            A86cambsfecultact = BC000E4_A86cambsfecultact[0];
            n86cambsfecultact = BC000E4_n86cambsfecultact[0];
            ZM0E14( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0E14( ) ;
      }

      protected void OnLoadActions0E14( )
      {
      }

      protected void CheckExtendedTable0E14( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0E14( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0E14( )
      {
         /* Using cursor BC000E5 */
         pr_default.execute(3, new Object[] {A25cambsid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound14 = 1;
         }
         else
         {
            RcdFound14 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000E3 */
         pr_default.execute(1, new Object[] {A25cambsid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0E14( 1) ;
            RcdFound14 = 1;
            A25cambsid = BC000E3_A25cambsid[0];
            A83cambsdsc = BC000E3_A83cambsdsc[0];
            n83cambsdsc = BC000E3_n83cambsdsc[0];
            A84cambsusuario = BC000E3_A84cambsusuario[0];
            n84cambsusuario = BC000E3_n84cambsusuario[0];
            A85cambsfecreg = BC000E3_A85cambsfecreg[0];
            n85cambsfecreg = BC000E3_n85cambsfecreg[0];
            A86cambsfecultact = BC000E3_A86cambsfecultact[0];
            n86cambsfecultact = BC000E3_n86cambsfecultact[0];
            Z25cambsid = A25cambsid;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0E14( ) ;
            if ( AnyError == 1 )
            {
               RcdFound14 = 0;
               InitializeNonKey0E14( ) ;
            }
            Gx_mode = sMode14;
         }
         else
         {
            RcdFound14 = 0;
            InitializeNonKey0E14( ) ;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode14;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0E14( ) ;
         if ( RcdFound14 == 0 )
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
         CONFIRM_0E0( ) ;
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

      protected void CheckOptimisticConcurrency0E14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000E2 */
            pr_default.execute(0, new Object[] {A25cambsid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CAMBS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z83cambsdsc, BC000E2_A83cambsdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z84cambsusuario, BC000E2_A84cambsusuario[0]) != 0 ) || ( Z85cambsfecreg != BC000E2_A85cambsfecreg[0] ) || ( Z86cambsfecultact != BC000E2_A86cambsfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CAMBS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E14( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E14( 0) ;
            CheckOptimisticConcurrency0E14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000E6 */
                     pr_default.execute(4, new Object[] {A25cambsid, n83cambsdsc, A83cambsdsc, n84cambsusuario, A84cambsusuario, n85cambsfecreg, A85cambsfecreg, n86cambsfecultact, A86cambsfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
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
               Load0E14( ) ;
            }
            EndLevel0E14( ) ;
         }
         CloseExtendedTableCursors0E14( ) ;
      }

      protected void Update0E14( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000E7 */
                     pr_default.execute(5, new Object[] {n83cambsdsc, A83cambsdsc, n84cambsusuario, A84cambsusuario, n85cambsfecreg, A85cambsfecreg, n86cambsfecultact, A86cambsfecultact, A25cambsid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CAMBS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E14( ) ;
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
            EndLevel0E14( ) ;
         }
         CloseExtendedTableCursors0E14( ) ;
      }

      protected void DeferredUpdate0E14( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E14( ) ;
            AfterConfirm0E14( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E14( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000E8 */
                  pr_default.execute(6, new Object[] {A25cambsid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
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
         sMode14 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0E14( ) ;
         Gx_mode = sMode14;
      }

      protected void OnDeleteControls0E14( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000E9 */
            pr_default.execute(7, new Object[] {A25cambsid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"producto"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000E10 */
            pr_default.execute(8, new Object[] {A25cambsid});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
            /* Using cursor BC000E11 */
            pr_default.execute(9, new Object[] {A25cambsid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0E14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0E14( ) ;
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

      public void ScanKeyStart0E14( )
      {
         /* Using cursor BC000E12 */
         pr_default.execute(10, new Object[] {A25cambsid});
         RcdFound14 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound14 = 1;
            A25cambsid = BC000E12_A25cambsid[0];
            A83cambsdsc = BC000E12_A83cambsdsc[0];
            n83cambsdsc = BC000E12_n83cambsdsc[0];
            A84cambsusuario = BC000E12_A84cambsusuario[0];
            n84cambsusuario = BC000E12_n84cambsusuario[0];
            A85cambsfecreg = BC000E12_A85cambsfecreg[0];
            n85cambsfecreg = BC000E12_n85cambsfecreg[0];
            A86cambsfecultact = BC000E12_A86cambsfecultact[0];
            n86cambsfecultact = BC000E12_n86cambsfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0E14( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound14 = 0;
         ScanKeyLoad0E14( ) ;
      }

      protected void ScanKeyLoad0E14( )
      {
         sMode14 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound14 = 1;
            A25cambsid = BC000E12_A25cambsid[0];
            A83cambsdsc = BC000E12_A83cambsdsc[0];
            n83cambsdsc = BC000E12_n83cambsdsc[0];
            A84cambsusuario = BC000E12_A84cambsusuario[0];
            n84cambsusuario = BC000E12_n84cambsusuario[0];
            A85cambsfecreg = BC000E12_A85cambsfecreg[0];
            n85cambsfecreg = BC000E12_n85cambsfecreg[0];
            A86cambsfecultact = BC000E12_A86cambsfecultact[0];
            n86cambsfecultact = BC000E12_n86cambsfecultact[0];
         }
         Gx_mode = sMode14;
      }

      protected void ScanKeyEnd0E14( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0E14( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E14( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0E14( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0E14( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E14( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E14( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E14( )
      {
      }

      protected void AddRow0E14( )
      {
         VarsToRow14( bccambs) ;
      }

      protected void ReadRow0E14( )
      {
         RowToVars14( bccambs, 1) ;
      }

      protected void InitializeNonKey0E14( )
      {
         A83cambsdsc = "";
         n83cambsdsc = false;
         A84cambsusuario = "";
         n84cambsusuario = false;
         A85cambsfecreg = (DateTime)(DateTime.MinValue);
         n85cambsfecreg = false;
         A86cambsfecultact = (DateTime)(DateTime.MinValue);
         n86cambsfecultact = false;
         Z83cambsdsc = "";
         Z84cambsusuario = "";
         Z85cambsfecreg = (DateTime)(DateTime.MinValue);
         Z86cambsfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0E14( )
      {
         A25cambsid = 0;
         InitializeNonKey0E14( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow14( Sdtcambs obj14 )
      {
         obj14.gxTpr_Mode = Gx_mode;
         obj14.gxTpr_Cambsdsc = A83cambsdsc;
         obj14.gxTpr_Cambsusuario = A84cambsusuario;
         obj14.gxTpr_Cambsfecreg = A85cambsfecreg;
         obj14.gxTpr_Cambsfecultact = A86cambsfecultact;
         obj14.gxTpr_Cambsid = A25cambsid;
         obj14.gxTpr_Cambsid_Z = Z25cambsid;
         obj14.gxTpr_Cambsdsc_Z = Z83cambsdsc;
         obj14.gxTpr_Cambsusuario_Z = Z84cambsusuario;
         obj14.gxTpr_Cambsfecreg_Z = Z85cambsfecreg;
         obj14.gxTpr_Cambsfecultact_Z = Z86cambsfecultact;
         obj14.gxTpr_Cambsdsc_N = (short)(Convert.ToInt16(n83cambsdsc));
         obj14.gxTpr_Cambsusuario_N = (short)(Convert.ToInt16(n84cambsusuario));
         obj14.gxTpr_Cambsfecreg_N = (short)(Convert.ToInt16(n85cambsfecreg));
         obj14.gxTpr_Cambsfecultact_N = (short)(Convert.ToInt16(n86cambsfecultact));
         obj14.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow14( Sdtcambs obj14 )
      {
         obj14.gxTpr_Cambsid = A25cambsid;
         return  ;
      }

      public void RowToVars14( Sdtcambs obj14 ,
                               int forceLoad )
      {
         Gx_mode = obj14.gxTpr_Mode;
         A83cambsdsc = obj14.gxTpr_Cambsdsc;
         n83cambsdsc = false;
         A84cambsusuario = obj14.gxTpr_Cambsusuario;
         n84cambsusuario = false;
         A85cambsfecreg = obj14.gxTpr_Cambsfecreg;
         n85cambsfecreg = false;
         A86cambsfecultact = obj14.gxTpr_Cambsfecultact;
         n86cambsfecultact = false;
         A25cambsid = obj14.gxTpr_Cambsid;
         Z25cambsid = obj14.gxTpr_Cambsid_Z;
         Z83cambsdsc = obj14.gxTpr_Cambsdsc_Z;
         Z84cambsusuario = obj14.gxTpr_Cambsusuario_Z;
         Z85cambsfecreg = obj14.gxTpr_Cambsfecreg_Z;
         Z86cambsfecultact = obj14.gxTpr_Cambsfecultact_Z;
         n83cambsdsc = (bool)(Convert.ToBoolean(obj14.gxTpr_Cambsdsc_N));
         n84cambsusuario = (bool)(Convert.ToBoolean(obj14.gxTpr_Cambsusuario_N));
         n85cambsfecreg = (bool)(Convert.ToBoolean(obj14.gxTpr_Cambsfecreg_N));
         n86cambsfecultact = (bool)(Convert.ToBoolean(obj14.gxTpr_Cambsfecultact_N));
         Gx_mode = obj14.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A25cambsid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0E14( ) ;
         ScanKeyStart0E14( ) ;
         if ( RcdFound14 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z25cambsid = A25cambsid;
         }
         ZM0E14( -1) ;
         OnLoadActions0E14( ) ;
         AddRow0E14( ) ;
         ScanKeyEnd0E14( ) ;
         if ( RcdFound14 == 0 )
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
         RowToVars14( bccambs, 0) ;
         ScanKeyStart0E14( ) ;
         if ( RcdFound14 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z25cambsid = A25cambsid;
         }
         ZM0E14( -1) ;
         OnLoadActions0E14( ) ;
         AddRow0E14( ) ;
         ScanKeyEnd0E14( ) ;
         if ( RcdFound14 == 0 )
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
         RowToVars14( bccambs, 0) ;
         nKeyPressed = 1;
         GetKey0E14( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0E14( ) ;
         }
         else
         {
            if ( RcdFound14 == 1 )
            {
               if ( A25cambsid != Z25cambsid )
               {
                  A25cambsid = Z25cambsid;
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
                  Update0E14( ) ;
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
                  if ( A25cambsid != Z25cambsid )
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
                        Insert0E14( ) ;
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
                        Insert0E14( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow14( bccambs) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars14( bccambs, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0E14( ) ;
         if ( RcdFound14 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A25cambsid != Z25cambsid )
            {
               A25cambsid = Z25cambsid;
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
            if ( A25cambsid != Z25cambsid )
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
         context.RollbackDataStores( "cambs_BC");
         VarsToRow14( bccambs) ;
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
         Gx_mode = bccambs.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bccambs.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bccambs )
         {
            bccambs = (Sdtcambs)(sdt);
            if ( StringUtil.StrCmp(bccambs.gxTpr_Mode, "") == 0 )
            {
               bccambs.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow14( bccambs) ;
            }
            else
            {
               RowToVars14( bccambs, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bccambs.gxTpr_Mode, "") == 0 )
            {
               bccambs.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars14( bccambs, 1) ;
         return  ;
      }

      public Sdtcambs cambs_BC
      {
         get {
            return bccambs ;
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
         Z83cambsdsc = "";
         A83cambsdsc = "";
         Z84cambsusuario = "";
         A84cambsusuario = "";
         Z85cambsfecreg = (DateTime)(DateTime.MinValue);
         A85cambsfecreg = (DateTime)(DateTime.MinValue);
         Z86cambsfecultact = (DateTime)(DateTime.MinValue);
         A86cambsfecultact = (DateTime)(DateTime.MinValue);
         BC000E4_A25cambsid = new int[1] ;
         BC000E4_A83cambsdsc = new String[] {""} ;
         BC000E4_n83cambsdsc = new bool[] {false} ;
         BC000E4_A84cambsusuario = new String[] {""} ;
         BC000E4_n84cambsusuario = new bool[] {false} ;
         BC000E4_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000E4_n85cambsfecreg = new bool[] {false} ;
         BC000E4_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000E4_n86cambsfecultact = new bool[] {false} ;
         BC000E5_A25cambsid = new int[1] ;
         BC000E3_A25cambsid = new int[1] ;
         BC000E3_A83cambsdsc = new String[] {""} ;
         BC000E3_n83cambsdsc = new bool[] {false} ;
         BC000E3_A84cambsusuario = new String[] {""} ;
         BC000E3_n84cambsusuario = new bool[] {false} ;
         BC000E3_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n85cambsfecreg = new bool[] {false} ;
         BC000E3_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n86cambsfecultact = new bool[] {false} ;
         sMode14 = "";
         BC000E2_A25cambsid = new int[1] ;
         BC000E2_A83cambsdsc = new String[] {""} ;
         BC000E2_n83cambsdsc = new bool[] {false} ;
         BC000E2_A84cambsusuario = new String[] {""} ;
         BC000E2_n84cambsusuario = new bool[] {false} ;
         BC000E2_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n85cambsfecreg = new bool[] {false} ;
         BC000E2_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n86cambsfecultact = new bool[] {false} ;
         BC000E9_A175productoid = new short[1] ;
         BC000E9_A25cambsid = new int[1] ;
         BC000E10_A19almacenid = new long[1] ;
         BC000E10_A20articulosproductoid = new int[1] ;
         BC000E10_A21articuloscambsid = new int[1] ;
         BC000E11_A17etiquetasproductoid = new int[1] ;
         BC000E11_A18etiquetascambsid = new int[1] ;
         BC000E11_A19almacenid = new long[1] ;
         BC000E12_A25cambsid = new int[1] ;
         BC000E12_A83cambsdsc = new String[] {""} ;
         BC000E12_n83cambsdsc = new bool[] {false} ;
         BC000E12_A84cambsusuario = new String[] {""} ;
         BC000E12_n84cambsusuario = new bool[] {false} ;
         BC000E12_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000E12_n85cambsfecreg = new bool[] {false} ;
         BC000E12_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000E12_n86cambsfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cambs_bc__default(),
            new Object[][] {
                new Object[] {
               BC000E2_A25cambsid, BC000E2_A83cambsdsc, BC000E2_n83cambsdsc, BC000E2_A84cambsusuario, BC000E2_n84cambsusuario, BC000E2_A85cambsfecreg, BC000E2_n85cambsfecreg, BC000E2_A86cambsfecultact, BC000E2_n86cambsfecultact
               }
               , new Object[] {
               BC000E3_A25cambsid, BC000E3_A83cambsdsc, BC000E3_n83cambsdsc, BC000E3_A84cambsusuario, BC000E3_n84cambsusuario, BC000E3_A85cambsfecreg, BC000E3_n85cambsfecreg, BC000E3_A86cambsfecultact, BC000E3_n86cambsfecultact
               }
               , new Object[] {
               BC000E4_A25cambsid, BC000E4_A83cambsdsc, BC000E4_n83cambsdsc, BC000E4_A84cambsusuario, BC000E4_n84cambsusuario, BC000E4_A85cambsfecreg, BC000E4_n85cambsfecreg, BC000E4_A86cambsfecultact, BC000E4_n86cambsfecultact
               }
               , new Object[] {
               BC000E5_A25cambsid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000E9_A175productoid, BC000E9_A25cambsid
               }
               , new Object[] {
               BC000E10_A19almacenid, BC000E10_A20articulosproductoid, BC000E10_A21articuloscambsid
               }
               , new Object[] {
               BC000E11_A17etiquetasproductoid, BC000E11_A18etiquetascambsid, BC000E11_A19almacenid
               }
               , new Object[] {
               BC000E12_A25cambsid, BC000E12_A83cambsdsc, BC000E12_n83cambsdsc, BC000E12_A84cambsusuario, BC000E12_n84cambsusuario, BC000E12_A85cambsfecreg, BC000E12_n85cambsfecreg, BC000E12_A86cambsfecultact, BC000E12_n86cambsfecultact
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
      private short RcdFound14 ;
      private int trnEnded ;
      private int Z25cambsid ;
      private int A25cambsid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode14 ;
      private DateTime Z85cambsfecreg ;
      private DateTime A85cambsfecreg ;
      private DateTime Z86cambsfecultact ;
      private DateTime A86cambsfecultact ;
      private bool n83cambsdsc ;
      private bool n84cambsusuario ;
      private bool n85cambsfecreg ;
      private bool n86cambsfecultact ;
      private String Z83cambsdsc ;
      private String A83cambsdsc ;
      private String Z84cambsusuario ;
      private String A84cambsusuario ;
      private Sdtcambs bccambs ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000E4_A25cambsid ;
      private String[] BC000E4_A83cambsdsc ;
      private bool[] BC000E4_n83cambsdsc ;
      private String[] BC000E4_A84cambsusuario ;
      private bool[] BC000E4_n84cambsusuario ;
      private DateTime[] BC000E4_A85cambsfecreg ;
      private bool[] BC000E4_n85cambsfecreg ;
      private DateTime[] BC000E4_A86cambsfecultact ;
      private bool[] BC000E4_n86cambsfecultact ;
      private int[] BC000E5_A25cambsid ;
      private int[] BC000E3_A25cambsid ;
      private String[] BC000E3_A83cambsdsc ;
      private bool[] BC000E3_n83cambsdsc ;
      private String[] BC000E3_A84cambsusuario ;
      private bool[] BC000E3_n84cambsusuario ;
      private DateTime[] BC000E3_A85cambsfecreg ;
      private bool[] BC000E3_n85cambsfecreg ;
      private DateTime[] BC000E3_A86cambsfecultact ;
      private bool[] BC000E3_n86cambsfecultact ;
      private int[] BC000E2_A25cambsid ;
      private String[] BC000E2_A83cambsdsc ;
      private bool[] BC000E2_n83cambsdsc ;
      private String[] BC000E2_A84cambsusuario ;
      private bool[] BC000E2_n84cambsusuario ;
      private DateTime[] BC000E2_A85cambsfecreg ;
      private bool[] BC000E2_n85cambsfecreg ;
      private DateTime[] BC000E2_A86cambsfecultact ;
      private bool[] BC000E2_n86cambsfecultact ;
      private short[] BC000E9_A175productoid ;
      private int[] BC000E9_A25cambsid ;
      private long[] BC000E10_A19almacenid ;
      private int[] BC000E10_A20articulosproductoid ;
      private int[] BC000E10_A21articuloscambsid ;
      private int[] BC000E11_A17etiquetasproductoid ;
      private int[] BC000E11_A18etiquetascambsid ;
      private long[] BC000E11_A19almacenid ;
      private int[] BC000E12_A25cambsid ;
      private String[] BC000E12_A83cambsdsc ;
      private bool[] BC000E12_n83cambsdsc ;
      private String[] BC000E12_A84cambsusuario ;
      private bool[] BC000E12_n84cambsusuario ;
      private DateTime[] BC000E12_A85cambsfecreg ;
      private bool[] BC000E12_n85cambsfecreg ;
      private DateTime[] BC000E12_A86cambsfecultact ;
      private bool[] BC000E12_n86cambsfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class cambs_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000E4 ;
          prmBC000E4 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E5 ;
          prmBC000E5 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E3 ;
          prmBC000E3 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E2 ;
          prmBC000E2 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E6 ;
          prmBC000E6 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"cambsdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"cambsusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"cambsfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000E7 ;
          prmBC000E7 = new Object[] {
          new Object[] {"cambsdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"cambsusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"cambsfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E8 ;
          prmBC000E8 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E9 ;
          prmBC000E9 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E10 ;
          prmBC000E10 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E11 ;
          prmBC000E11 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000E12 ;
          prmBC000E12 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000E2", "SELECT cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact FROM public.cambs WHERE cambsid = :cambsid  FOR UPDATE OF cambs",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E2,1,0,true,false )
             ,new CursorDef("BC000E3", "SELECT cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact FROM public.cambs WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E3,1,0,true,false )
             ,new CursorDef("BC000E4", "SELECT TM1.cambsid, TM1.cambsdsc, TM1.cambsusuario, TM1.cambsfecreg, TM1.cambsfecultact FROM public.cambs TM1 WHERE TM1.cambsid = :cambsid ORDER BY TM1.cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E4,100,0,true,false )
             ,new CursorDef("BC000E5", "SELECT cambsid FROM public.cambs WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E5,1,0,true,false )
             ,new CursorDef("BC000E6", "SAVEPOINT gxupdate;INSERT INTO public.cambs(cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact) VALUES(:cambsid, :cambsdsc, :cambsusuario, :cambsfecreg, :cambsfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000E6)
             ,new CursorDef("BC000E7", "SAVEPOINT gxupdate;UPDATE public.cambs SET cambsdsc=:cambsdsc, cambsusuario=:cambsusuario, cambsfecreg=:cambsfecreg, cambsfecultact=:cambsfecultact  WHERE cambsid = :cambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000E7)
             ,new CursorDef("BC000E8", "SAVEPOINT gxupdate;DELETE FROM public.cambs  WHERE cambsid = :cambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000E8)
             ,new CursorDef("BC000E9", "SELECT productoid, cambsid FROM producto WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E9,1,0,true,true )
             ,new CursorDef("BC000E10", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E10,1,0,true,true )
             ,new CursorDef("BC000E11", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E11,1,0,true,true )
             ,new CursorDef("BC000E12", "SELECT TM1.cambsid, TM1.cambsdsc, TM1.cambsusuario, TM1.cambsfecreg, TM1.cambsfecultact FROM public.cambs TM1 WHERE TM1.cambsid = :cambsid ORDER BY TM1.cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E12,100,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 10 :
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
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
