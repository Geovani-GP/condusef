/*
               File: estados_BC
        Description: estados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:30.18
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
   public class estados_bc : GXHttpHandler, IGxSilentTrn
   {
      public estados_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public estados_bc( IGxContext context )
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
         ReadRow0P25( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0P25( ) ;
         standaloneModal( ) ;
         AddRow0P25( ) ;
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
               Z177estadoid = A177estadoid;
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

      protected void CONFIRM_0P0( )
      {
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0P25( ) ;
            }
            else
            {
               CheckExtendedTable0P25( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0P25( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0P25( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z178estado = A178estado;
         }
         if ( GX_JID == -1 )
         {
            Z177estadoid = A177estadoid;
            Z178estado = A178estado;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0P25( )
      {
         /* Using cursor BC000P4 */
         pr_default.execute(2, new Object[] {A177estadoid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound25 = 1;
            A178estado = BC000P4_A178estado[0];
            ZM0P25( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0P25( ) ;
      }

      protected void OnLoadActions0P25( )
      {
      }

      protected void CheckExtendedTable0P25( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0P25( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0P25( )
      {
         /* Using cursor BC000P5 */
         pr_default.execute(3, new Object[] {A177estadoid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound25 = 1;
         }
         else
         {
            RcdFound25 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000P3 */
         pr_default.execute(1, new Object[] {A177estadoid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0P25( 1) ;
            RcdFound25 = 1;
            A177estadoid = BC000P3_A177estadoid[0];
            A178estado = BC000P3_A178estado[0];
            Z177estadoid = A177estadoid;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0P25( ) ;
            if ( AnyError == 1 )
            {
               RcdFound25 = 0;
               InitializeNonKey0P25( ) ;
            }
            Gx_mode = sMode25;
         }
         else
         {
            RcdFound25 = 0;
            InitializeNonKey0P25( ) ;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode25;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0P25( ) ;
         if ( RcdFound25 == 0 )
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
         CONFIRM_0P0( ) ;
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

      protected void CheckOptimisticConcurrency0P25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000P2 */
            pr_default.execute(0, new Object[] {A177estadoid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"estados"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z178estado, BC000P2_A178estado[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"estados"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0P25( )
      {
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P25( 0) ;
            CheckOptimisticConcurrency0P25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000P6 */
                     pr_default.execute(4, new Object[] {A177estadoid, A178estado});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("estados") ;
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
               Load0P25( ) ;
            }
            EndLevel0P25( ) ;
         }
         CloseExtendedTableCursors0P25( ) ;
      }

      protected void Update0P25( )
      {
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000P7 */
                     pr_default.execute(5, new Object[] {A178estado, A177estadoid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("estados") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"estados"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0P25( ) ;
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
            EndLevel0P25( ) ;
         }
         CloseExtendedTableCursors0P25( ) ;
      }

      protected void DeferredUpdate0P25( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P25( ) ;
            AfterConfirm0P25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P25( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000P8 */
                  pr_default.execute(6, new Object[] {A177estadoid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("estados") ;
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
         sMode25 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0P25( ) ;
         Gx_mode = sMode25;
      }

      protected void OnDeleteControls0P25( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0P25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0P25( ) ;
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

      public void ScanKeyStart0P25( )
      {
         /* Using cursor BC000P9 */
         pr_default.execute(7, new Object[] {A177estadoid});
         RcdFound25 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound25 = 1;
            A177estadoid = BC000P9_A177estadoid[0];
            A178estado = BC000P9_A178estado[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0P25( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound25 = 0;
         ScanKeyLoad0P25( ) ;
      }

      protected void ScanKeyLoad0P25( )
      {
         sMode25 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound25 = 1;
            A177estadoid = BC000P9_A177estadoid[0];
            A178estado = BC000P9_A178estado[0];
         }
         Gx_mode = sMode25;
      }

      protected void ScanKeyEnd0P25( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0P25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P25( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0P25( )
      {
      }

      protected void AddRow0P25( )
      {
         VarsToRow25( bcestados) ;
      }

      protected void ReadRow0P25( )
      {
         RowToVars25( bcestados, 1) ;
      }

      protected void InitializeNonKey0P25( )
      {
         A178estado = "";
         Z178estado = "";
      }

      protected void InitAll0P25( )
      {
         A177estadoid = 0;
         InitializeNonKey0P25( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow25( Sdtestados obj25 )
      {
         obj25.gxTpr_Mode = Gx_mode;
         obj25.gxTpr_Estado = A178estado;
         obj25.gxTpr_Estadoid = A177estadoid;
         obj25.gxTpr_Estadoid_Z = Z177estadoid;
         obj25.gxTpr_Estado_Z = Z178estado;
         obj25.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow25( Sdtestados obj25 )
      {
         obj25.gxTpr_Estadoid = A177estadoid;
         return  ;
      }

      public void RowToVars25( Sdtestados obj25 ,
                               int forceLoad )
      {
         Gx_mode = obj25.gxTpr_Mode;
         A178estado = obj25.gxTpr_Estado;
         A177estadoid = obj25.gxTpr_Estadoid;
         Z177estadoid = obj25.gxTpr_Estadoid_Z;
         Z178estado = obj25.gxTpr_Estado_Z;
         Gx_mode = obj25.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A177estadoid = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0P25( ) ;
         ScanKeyStart0P25( ) ;
         if ( RcdFound25 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z177estadoid = A177estadoid;
         }
         ZM0P25( -1) ;
         OnLoadActions0P25( ) ;
         AddRow0P25( ) ;
         ScanKeyEnd0P25( ) ;
         if ( RcdFound25 == 0 )
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
         RowToVars25( bcestados, 0) ;
         ScanKeyStart0P25( ) ;
         if ( RcdFound25 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z177estadoid = A177estadoid;
         }
         ZM0P25( -1) ;
         OnLoadActions0P25( ) ;
         AddRow0P25( ) ;
         ScanKeyEnd0P25( ) ;
         if ( RcdFound25 == 0 )
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
         RowToVars25( bcestados, 0) ;
         nKeyPressed = 1;
         GetKey0P25( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0P25( ) ;
         }
         else
         {
            if ( RcdFound25 == 1 )
            {
               if ( A177estadoid != Z177estadoid )
               {
                  A177estadoid = Z177estadoid;
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
                  Update0P25( ) ;
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
                  if ( A177estadoid != Z177estadoid )
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
                        Insert0P25( ) ;
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
                        Insert0P25( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow25( bcestados) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars25( bcestados, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0P25( ) ;
         if ( RcdFound25 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A177estadoid != Z177estadoid )
            {
               A177estadoid = Z177estadoid;
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
            if ( A177estadoid != Z177estadoid )
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
         context.RollbackDataStores( "estados_BC");
         VarsToRow25( bcestados) ;
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
         Gx_mode = bcestados.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcestados.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcestados )
         {
            bcestados = (Sdtestados)(sdt);
            if ( StringUtil.StrCmp(bcestados.gxTpr_Mode, "") == 0 )
            {
               bcestados.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow25( bcestados) ;
            }
            else
            {
               RowToVars25( bcestados, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcestados.gxTpr_Mode, "") == 0 )
            {
               bcestados.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars25( bcestados, 1) ;
         return  ;
      }

      public Sdtestados estados_BC
      {
         get {
            return bcestados ;
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
         Z178estado = "";
         A178estado = "";
         BC000P4_A177estadoid = new short[1] ;
         BC000P4_A178estado = new String[] {""} ;
         BC000P5_A177estadoid = new short[1] ;
         BC000P3_A177estadoid = new short[1] ;
         BC000P3_A178estado = new String[] {""} ;
         sMode25 = "";
         BC000P2_A177estadoid = new short[1] ;
         BC000P2_A178estado = new String[] {""} ;
         BC000P9_A177estadoid = new short[1] ;
         BC000P9_A178estado = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estados_bc__default(),
            new Object[][] {
                new Object[] {
               BC000P2_A177estadoid, BC000P2_A178estado
               }
               , new Object[] {
               BC000P3_A177estadoid, BC000P3_A178estado
               }
               , new Object[] {
               BC000P4_A177estadoid, BC000P4_A178estado
               }
               , new Object[] {
               BC000P5_A177estadoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000P9_A177estadoid, BC000P9_A178estado
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
      private short Z177estadoid ;
      private short A177estadoid ;
      private short GX_JID ;
      private short RcdFound25 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode25 ;
      private String Z178estado ;
      private String A178estado ;
      private Sdtestados bcestados ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC000P4_A177estadoid ;
      private String[] BC000P4_A178estado ;
      private short[] BC000P5_A177estadoid ;
      private short[] BC000P3_A177estadoid ;
      private String[] BC000P3_A178estado ;
      private short[] BC000P2_A177estadoid ;
      private String[] BC000P2_A178estado ;
      private short[] BC000P9_A177estadoid ;
      private String[] BC000P9_A178estado ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class estados_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000P4 ;
          prmBC000P4 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P5 ;
          prmBC000P5 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P3 ;
          prmBC000P3 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P2 ;
          prmBC000P2 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P6 ;
          prmBC000P6 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"estado",NpgsqlDbType.Varchar,100,0}
          } ;
          Object[] prmBC000P7 ;
          prmBC000P7 = new Object[] {
          new Object[] {"estado",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P8 ;
          prmBC000P8 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC000P9 ;
          prmBC000P9 = new Object[] {
          new Object[] {"estadoid",NpgsqlDbType.Smallint,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000P2", "SELECT estadoid, estado FROM estados WHERE estadoid = :estadoid  FOR UPDATE OF estados",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P2,1,0,true,false )
             ,new CursorDef("BC000P3", "SELECT estadoid, estado FROM estados WHERE estadoid = :estadoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P3,1,0,true,false )
             ,new CursorDef("BC000P4", "SELECT TM1.estadoid, TM1.estado FROM estados TM1 WHERE TM1.estadoid = :estadoid ORDER BY TM1.estadoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P4,100,0,true,false )
             ,new CursorDef("BC000P5", "SELECT estadoid FROM estados WHERE estadoid = :estadoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P5,1,0,true,false )
             ,new CursorDef("BC000P6", "SAVEPOINT gxupdate;INSERT INTO estados(estadoid, estado) VALUES(:estadoid, :estado);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000P6)
             ,new CursorDef("BC000P7", "SAVEPOINT gxupdate;UPDATE estados SET estado=:estado  WHERE estadoid = :estadoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000P7)
             ,new CursorDef("BC000P8", "SAVEPOINT gxupdate;DELETE FROM estados  WHERE estadoid = :estadoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000P8)
             ,new CursorDef("BC000P9", "SELECT TM1.estadoid, TM1.estado FROM estados TM1 WHERE TM1.estadoid = :estadoid ORDER BY TM1.estadoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P9,100,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
