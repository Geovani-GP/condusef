/*
               File: tipobien_BC
        Description: tipobien
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 1:0:43.35
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
   public class tipobien_bc : GXHttpHandler, IGxSilentTrn
   {
      public tipobien_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public tipobien_bc( IGxContext context )
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
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
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
               Z23tipobienid = A23tipobienid;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z139tipobiendsc = A139tipobiendsc;
            Z140tipobienusuario = A140tipobienusuario;
            Z141tipobienfecreg = A141tipobienfecreg;
            Z142tipobienfecultact = A142tipobienfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z23tipobienid = A23tipobienid;
            Z139tipobiendsc = A139tipobiendsc;
            Z140tipobienusuario = A140tipobienusuario;
            Z141tipobienfecreg = A141tipobienfecreg;
            Z142tipobienfecultact = A142tipobienfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load011( )
      {
         /* Using cursor BC00014 */
         pr_default.execute(2, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound1 = 1;
            A139tipobiendsc = BC00014_A139tipobiendsc[0];
            n139tipobiendsc = BC00014_n139tipobiendsc[0];
            A140tipobienusuario = BC00014_A140tipobienusuario[0];
            n140tipobienusuario = BC00014_n140tipobienusuario[0];
            A141tipobienfecreg = BC00014_A141tipobienfecreg[0];
            n141tipobienfecreg = BC00014_n141tipobienfecreg[0];
            A142tipobienfecultact = BC00014_A142tipobienfecultact[0];
            n142tipobienfecultact = BC00014_n142tipobienfecultact[0];
            ZM011( -1) ;
         }
         pr_default.close(2);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00015 */
         pr_default.execute(3, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 1) ;
            RcdFound1 = 1;
            A23tipobienid = BC00013_A23tipobienid[0];
            n23tipobienid = BC00013_n23tipobienid[0];
            A139tipobiendsc = BC00013_A139tipobiendsc[0];
            n139tipobiendsc = BC00013_n139tipobiendsc[0];
            A140tipobienusuario = BC00013_A140tipobienusuario[0];
            n140tipobienusuario = BC00013_n140tipobienusuario[0];
            A141tipobienfecreg = BC00013_A141tipobienfecreg[0];
            n141tipobienfecreg = BC00013_n141tipobienfecreg[0];
            A142tipobienfecultact = BC00013_A142tipobienfecultact[0];
            n142tipobienfecultact = BC00013_n142tipobienfecultact[0];
            Z23tipobienid = A23tipobienid;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         CONFIRM_010( ) ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {n23tipobienid, A23tipobienid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPOBIEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z139tipobiendsc, BC00012_A139tipobiendsc[0]) != 0 ) || ( StringUtil.StrCmp(Z140tipobienusuario, BC00012_A140tipobienusuario[0]) != 0 ) || ( Z141tipobienfecreg != BC00012_A141tipobienfecreg[0] ) || ( Z142tipobienfecultact != BC00012_A142tipobienfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TIPOBIEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00016 */
                     pr_default.execute(4, new Object[] {n23tipobienid, A23tipobienid, n139tipobiendsc, A139tipobiendsc, n140tipobienusuario, A140tipobienusuario, n141tipobienfecreg, A141tipobienfecreg, n142tipobienfecultact, A142tipobienfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00017 */
                     pr_default.execute(5, new Object[] {n139tipobiendsc, A139tipobiendsc, n140tipobienusuario, A140tipobienusuario, n141tipobienfecreg, A141tipobienfecreg, n142tipobienfecultact, A142tipobienfecultact, n23tipobienid, A23tipobienid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPOBIEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00018 */
                  pr_default.execute(6, new Object[] {n23tipobienid, A23tipobienid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC00019 */
            pr_default.execute(7, new Object[] {n23tipobienid, A23tipobienid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"producto"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000110 */
            pr_default.execute(8, new Object[] {n23tipobienid, A23tipobienid});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
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

      public void ScanKeyStart011( )
      {
         /* Using cursor BC000111 */
         pr_default.execute(9, new Object[] {n23tipobienid, A23tipobienid});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound1 = 1;
            A23tipobienid = BC000111_A23tipobienid[0];
            n23tipobienid = BC000111_n23tipobienid[0];
            A139tipobiendsc = BC000111_A139tipobiendsc[0];
            n139tipobiendsc = BC000111_n139tipobiendsc[0];
            A140tipobienusuario = BC000111_A140tipobienusuario[0];
            n140tipobienusuario = BC000111_n140tipobienusuario[0];
            A141tipobienfecreg = BC000111_A141tipobienfecreg[0];
            n141tipobienfecreg = BC000111_n141tipobienfecreg[0];
            A142tipobienfecultact = BC000111_A142tipobienfecultact[0];
            n142tipobienfecultact = BC000111_n142tipobienfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound1 = 1;
            A23tipobienid = BC000111_A23tipobienid[0];
            n23tipobienid = BC000111_n23tipobienid[0];
            A139tipobiendsc = BC000111_A139tipobiendsc[0];
            n139tipobiendsc = BC000111_n139tipobiendsc[0];
            A140tipobienusuario = BC000111_A140tipobienusuario[0];
            n140tipobienusuario = BC000111_n140tipobienusuario[0];
            A141tipobienfecreg = BC000111_A141tipobienfecreg[0];
            n141tipobienfecreg = BC000111_n141tipobienfecreg[0];
            A142tipobienfecultact = BC000111_A142tipobienfecultact[0];
            n142tipobienfecultact = BC000111_n142tipobienfecultact[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bctipobien) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bctipobien, 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A139tipobiendsc = "";
         n139tipobiendsc = false;
         A140tipobienusuario = "";
         n140tipobienusuario = false;
         A141tipobienfecreg = DateTime.MinValue;
         n141tipobienfecreg = false;
         A142tipobienfecultact = DateTime.MinValue;
         n142tipobienfecultact = false;
         Z139tipobiendsc = "";
         Z140tipobienusuario = "";
         Z141tipobienfecreg = DateTime.MinValue;
         Z142tipobienfecultact = DateTime.MinValue;
      }

      protected void InitAll011( )
      {
         A23tipobienid = 0;
         n23tipobienid = false;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow1( Sdttipobien obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Tipobiendsc = A139tipobiendsc;
         obj1.gxTpr_Tipobienusuario = A140tipobienusuario;
         obj1.gxTpr_Tipobienfecreg = A141tipobienfecreg;
         obj1.gxTpr_Tipobienfecultact = A142tipobienfecultact;
         obj1.gxTpr_Tipobienid = A23tipobienid;
         obj1.gxTpr_Tipobienid_Z = Z23tipobienid;
         obj1.gxTpr_Tipobiendsc_Z = Z139tipobiendsc;
         obj1.gxTpr_Tipobienusuario_Z = Z140tipobienusuario;
         obj1.gxTpr_Tipobienfecreg_Z = Z141tipobienfecreg;
         obj1.gxTpr_Tipobienfecultact_Z = Z142tipobienfecultact;
         obj1.gxTpr_Tipobienid_N = (short)(Convert.ToInt16(n23tipobienid));
         obj1.gxTpr_Tipobiendsc_N = (short)(Convert.ToInt16(n139tipobiendsc));
         obj1.gxTpr_Tipobienusuario_N = (short)(Convert.ToInt16(n140tipobienusuario));
         obj1.gxTpr_Tipobienfecreg_N = (short)(Convert.ToInt16(n141tipobienfecreg));
         obj1.gxTpr_Tipobienfecultact_N = (short)(Convert.ToInt16(n142tipobienfecultact));
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( Sdttipobien obj1 )
      {
         obj1.gxTpr_Tipobienid = A23tipobienid;
         return  ;
      }

      public void RowToVars1( Sdttipobien obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         A139tipobiendsc = obj1.gxTpr_Tipobiendsc;
         n139tipobiendsc = false;
         A140tipobienusuario = obj1.gxTpr_Tipobienusuario;
         n140tipobienusuario = false;
         A141tipobienfecreg = obj1.gxTpr_Tipobienfecreg;
         n141tipobienfecreg = false;
         A142tipobienfecultact = obj1.gxTpr_Tipobienfecultact;
         n142tipobienfecultact = false;
         A23tipobienid = obj1.gxTpr_Tipobienid;
         n23tipobienid = false;
         Z23tipobienid = obj1.gxTpr_Tipobienid_Z;
         Z139tipobiendsc = obj1.gxTpr_Tipobiendsc_Z;
         Z140tipobienusuario = obj1.gxTpr_Tipobienusuario_Z;
         Z141tipobienfecreg = obj1.gxTpr_Tipobienfecreg_Z;
         Z142tipobienfecultact = obj1.gxTpr_Tipobienfecultact_Z;
         n23tipobienid = (bool)(Convert.ToBoolean(obj1.gxTpr_Tipobienid_N));
         n139tipobiendsc = (bool)(Convert.ToBoolean(obj1.gxTpr_Tipobiendsc_N));
         n140tipobienusuario = (bool)(Convert.ToBoolean(obj1.gxTpr_Tipobienusuario_N));
         n141tipobienfecreg = (bool)(Convert.ToBoolean(obj1.gxTpr_Tipobienfecreg_N));
         n142tipobienfecultact = (bool)(Convert.ToBoolean(obj1.gxTpr_Tipobienfecultact_N));
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A23tipobienid = (int)getParm(obj,0);
         n23tipobienid = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z23tipobienid = A23tipobienid;
         }
         ZM011( -1) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bctipobien, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z23tipobienid = A23tipobienid;
         }
         ZM011( -1) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bctipobien, 0) ;
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A23tipobienid != Z23tipobienid )
               {
                  A23tipobienid = Z23tipobienid;
                  n23tipobienid = false;
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
                  Update011( ) ;
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
                  if ( A23tipobienid != Z23tipobienid )
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
                        Insert011( ) ;
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
                        Insert011( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow1( bctipobien) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bctipobien, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A23tipobienid != Z23tipobienid )
            {
               A23tipobienid = Z23tipobienid;
               n23tipobienid = false;
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
            if ( A23tipobienid != Z23tipobienid )
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
         context.RollbackDataStores( "tipobien_BC");
         VarsToRow1( bctipobien) ;
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
         Gx_mode = bctipobien.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bctipobien.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bctipobien )
         {
            bctipobien = (Sdttipobien)(sdt);
            if ( StringUtil.StrCmp(bctipobien.gxTpr_Mode, "") == 0 )
            {
               bctipobien.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bctipobien) ;
            }
            else
            {
               RowToVars1( bctipobien, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bctipobien.gxTpr_Mode, "") == 0 )
            {
               bctipobien.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bctipobien, 1) ;
         return  ;
      }

      public Sdttipobien tipobien_BC
      {
         get {
            return bctipobien ;
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
         Z139tipobiendsc = "";
         A139tipobiendsc = "";
         Z140tipobienusuario = "";
         A140tipobienusuario = "";
         Z141tipobienfecreg = DateTime.MinValue;
         A141tipobienfecreg = DateTime.MinValue;
         Z142tipobienfecultact = DateTime.MinValue;
         A142tipobienfecultact = DateTime.MinValue;
         BC00014_A23tipobienid = new int[1] ;
         BC00014_n23tipobienid = new bool[] {false} ;
         BC00014_A139tipobiendsc = new String[] {""} ;
         BC00014_n139tipobiendsc = new bool[] {false} ;
         BC00014_A140tipobienusuario = new String[] {""} ;
         BC00014_n140tipobienusuario = new bool[] {false} ;
         BC00014_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00014_n141tipobienfecreg = new bool[] {false} ;
         BC00014_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00014_n142tipobienfecultact = new bool[] {false} ;
         BC00015_A23tipobienid = new int[1] ;
         BC00015_n23tipobienid = new bool[] {false} ;
         BC00013_A23tipobienid = new int[1] ;
         BC00013_n23tipobienid = new bool[] {false} ;
         BC00013_A139tipobiendsc = new String[] {""} ;
         BC00013_n139tipobiendsc = new bool[] {false} ;
         BC00013_A140tipobienusuario = new String[] {""} ;
         BC00013_n140tipobienusuario = new bool[] {false} ;
         BC00013_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00013_n141tipobienfecreg = new bool[] {false} ;
         BC00013_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00013_n142tipobienfecultact = new bool[] {false} ;
         sMode1 = "";
         BC00012_A23tipobienid = new int[1] ;
         BC00012_n23tipobienid = new bool[] {false} ;
         BC00012_A139tipobiendsc = new String[] {""} ;
         BC00012_n139tipobiendsc = new bool[] {false} ;
         BC00012_A140tipobienusuario = new String[] {""} ;
         BC00012_n140tipobienusuario = new bool[] {false} ;
         BC00012_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00012_n141tipobienfecreg = new bool[] {false} ;
         BC00012_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00012_n142tipobienfecultact = new bool[] {false} ;
         BC00019_A175productoid = new int[1] ;
         BC000110_A19almacenid = new long[1] ;
         BC000110_A20articulosproductoid = new int[1] ;
         BC000110_A21articuloscambsid = new int[1] ;
         BC000111_A23tipobienid = new int[1] ;
         BC000111_n23tipobienid = new bool[] {false} ;
         BC000111_A139tipobiendsc = new String[] {""} ;
         BC000111_n139tipobiendsc = new bool[] {false} ;
         BC000111_A140tipobienusuario = new String[] {""} ;
         BC000111_n140tipobienusuario = new bool[] {false} ;
         BC000111_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000111_n141tipobienfecreg = new bool[] {false} ;
         BC000111_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000111_n142tipobienfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipobien_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A23tipobienid, BC00012_A139tipobiendsc, BC00012_n139tipobiendsc, BC00012_A140tipobienusuario, BC00012_n140tipobienusuario, BC00012_A141tipobienfecreg, BC00012_n141tipobienfecreg, BC00012_A142tipobienfecultact, BC00012_n142tipobienfecultact
               }
               , new Object[] {
               BC00013_A23tipobienid, BC00013_A139tipobiendsc, BC00013_n139tipobiendsc, BC00013_A140tipobienusuario, BC00013_n140tipobienusuario, BC00013_A141tipobienfecreg, BC00013_n141tipobienfecreg, BC00013_A142tipobienfecultact, BC00013_n142tipobienfecultact
               }
               , new Object[] {
               BC00014_A23tipobienid, BC00014_A139tipobiendsc, BC00014_n139tipobiendsc, BC00014_A140tipobienusuario, BC00014_n140tipobienusuario, BC00014_A141tipobienfecreg, BC00014_n141tipobienfecreg, BC00014_A142tipobienfecultact, BC00014_n142tipobienfecultact
               }
               , new Object[] {
               BC00015_A23tipobienid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00019_A175productoid
               }
               , new Object[] {
               BC000110_A19almacenid, BC000110_A20articulosproductoid, BC000110_A21articuloscambsid
               }
               , new Object[] {
               BC000111_A23tipobienid, BC000111_A139tipobiendsc, BC000111_n139tipobiendsc, BC000111_A140tipobienusuario, BC000111_n140tipobienusuario, BC000111_A141tipobienfecreg, BC000111_n141tipobienfecreg, BC000111_A142tipobienfecultact, BC000111_n142tipobienfecultact
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
      private short RcdFound1 ;
      private int trnEnded ;
      private int Z23tipobienid ;
      private int A23tipobienid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode1 ;
      private DateTime Z141tipobienfecreg ;
      private DateTime A141tipobienfecreg ;
      private DateTime Z142tipobienfecultact ;
      private DateTime A142tipobienfecultact ;
      private bool n23tipobienid ;
      private bool n139tipobiendsc ;
      private bool n140tipobienusuario ;
      private bool n141tipobienfecreg ;
      private bool n142tipobienfecultact ;
      private String Z139tipobiendsc ;
      private String A139tipobiendsc ;
      private String Z140tipobienusuario ;
      private String A140tipobienusuario ;
      private Sdttipobien bctipobien ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00014_A23tipobienid ;
      private bool[] BC00014_n23tipobienid ;
      private String[] BC00014_A139tipobiendsc ;
      private bool[] BC00014_n139tipobiendsc ;
      private String[] BC00014_A140tipobienusuario ;
      private bool[] BC00014_n140tipobienusuario ;
      private DateTime[] BC00014_A141tipobienfecreg ;
      private bool[] BC00014_n141tipobienfecreg ;
      private DateTime[] BC00014_A142tipobienfecultact ;
      private bool[] BC00014_n142tipobienfecultact ;
      private int[] BC00015_A23tipobienid ;
      private bool[] BC00015_n23tipobienid ;
      private int[] BC00013_A23tipobienid ;
      private bool[] BC00013_n23tipobienid ;
      private String[] BC00013_A139tipobiendsc ;
      private bool[] BC00013_n139tipobiendsc ;
      private String[] BC00013_A140tipobienusuario ;
      private bool[] BC00013_n140tipobienusuario ;
      private DateTime[] BC00013_A141tipobienfecreg ;
      private bool[] BC00013_n141tipobienfecreg ;
      private DateTime[] BC00013_A142tipobienfecultact ;
      private bool[] BC00013_n142tipobienfecultact ;
      private int[] BC00012_A23tipobienid ;
      private bool[] BC00012_n23tipobienid ;
      private String[] BC00012_A139tipobiendsc ;
      private bool[] BC00012_n139tipobiendsc ;
      private String[] BC00012_A140tipobienusuario ;
      private bool[] BC00012_n140tipobienusuario ;
      private DateTime[] BC00012_A141tipobienfecreg ;
      private bool[] BC00012_n141tipobienfecreg ;
      private DateTime[] BC00012_A142tipobienfecultact ;
      private bool[] BC00012_n142tipobienfecultact ;
      private int[] BC00019_A175productoid ;
      private long[] BC000110_A19almacenid ;
      private int[] BC000110_A20articulosproductoid ;
      private int[] BC000110_A21articuloscambsid ;
      private int[] BC000111_A23tipobienid ;
      private bool[] BC000111_n23tipobienid ;
      private String[] BC000111_A139tipobiendsc ;
      private bool[] BC000111_n139tipobiendsc ;
      private String[] BC000111_A140tipobienusuario ;
      private bool[] BC000111_n140tipobienusuario ;
      private DateTime[] BC000111_A141tipobienfecreg ;
      private bool[] BC000111_n141tipobienfecreg ;
      private DateTime[] BC000111_A142tipobienfecultact ;
      private bool[] BC000111_n142tipobienfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class tipobien_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00014 ;
          prmBC00014 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00015 ;
          prmBC00015 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00013 ;
          prmBC00013 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00012 ;
          prmBC00012 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00016 ;
          prmBC00016 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipobiendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienfecultact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmBC00017 ;
          prmBC00017 = new Object[] {
          new Object[] {"tipobiendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00018 ;
          prmBC00018 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00019 ;
          prmBC00019 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000110 ;
          prmBC000110 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000111 ;
          prmBC000111 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00012", "SELECT tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact FROM public.tipobien WHERE tipobienid = :tipobienid  FOR UPDATE OF tipobien",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1,0,true,false )
             ,new CursorDef("BC00013", "SELECT tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1,0,true,false )
             ,new CursorDef("BC00014", "SELECT TM1.tipobienid, TM1.tipobiendsc, TM1.tipobienusuario, TM1.tipobienfecreg, TM1.tipobienfecultact FROM public.tipobien TM1 WHERE TM1.tipobienid = :tipobienid ORDER BY TM1.tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,100,0,true,false )
             ,new CursorDef("BC00015", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,1,0,true,false )
             ,new CursorDef("BC00016", "SAVEPOINT gxupdate;INSERT INTO public.tipobien(tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact) VALUES(:tipobienid, :tipobiendsc, :tipobienusuario, :tipobienfecreg, :tipobienfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00016)
             ,new CursorDef("BC00017", "SAVEPOINT gxupdate;UPDATE public.tipobien SET tipobiendsc=:tipobiendsc, tipobienusuario=:tipobienusuario, tipobienfecreg=:tipobienfecreg, tipobienfecultact=:tipobienfecultact  WHERE tipobienid = :tipobienid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00017)
             ,new CursorDef("BC00018", "SAVEPOINT gxupdate;DELETE FROM public.tipobien  WHERE tipobienid = :tipobienid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00018)
             ,new CursorDef("BC00019", "SELECT productoid FROM producto WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00019,1,0,true,true )
             ,new CursorDef("BC000110", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE tipodocid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000110,1,0,true,true )
             ,new CursorDef("BC000111", "SELECT TM1.tipobienid, TM1.tipobiendsc, TM1.tipobienusuario, TM1.tipobienfecreg, TM1.tipobienfecultact FROM public.tipobien TM1 WHERE TM1.tipobienid = :tipobienid ORDER BY TM1.tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000111,100,0,true,false )
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
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[9]);
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
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[9]);
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
             case 9 :
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
