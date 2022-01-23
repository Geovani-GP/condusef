/*
               File: categorias_BC
        Description: categorias
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:48:56.68
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
   public class categorias_bc : GXHttpHandler, IGxSilentTrn
   {
      public categorias_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public categorias_bc( IGxContext context )
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
         ReadRow055( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey055( ) ;
         standaloneModal( ) ;
         AddRow055( ) ;
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
               Z14categoriasid = A14categoriasid;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls055( ) ;
            }
            else
            {
               CheckExtendedTable055( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors055( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM055( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z94categoriasdsc = A94categoriasdsc;
            Z95categoriasusuario = A95categoriasusuario;
            Z96categoriasfecreg = A96categoriasfecreg;
            Z97categoriasfecultact = A97categoriasfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z14categoriasid = A14categoriasid;
            Z94categoriasdsc = A94categoriasdsc;
            Z95categoriasusuario = A95categoriasusuario;
            Z96categoriasfecreg = A96categoriasfecreg;
            Z97categoriasfecultact = A97categoriasfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load055( )
      {
         /* Using cursor BC00054 */
         pr_default.execute(2, new Object[] {A14categoriasid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound5 = 1;
            A94categoriasdsc = BC00054_A94categoriasdsc[0];
            n94categoriasdsc = BC00054_n94categoriasdsc[0];
            A95categoriasusuario = BC00054_A95categoriasusuario[0];
            n95categoriasusuario = BC00054_n95categoriasusuario[0];
            A96categoriasfecreg = BC00054_A96categoriasfecreg[0];
            n96categoriasfecreg = BC00054_n96categoriasfecreg[0];
            A97categoriasfecultact = BC00054_A97categoriasfecultact[0];
            n97categoriasfecultact = BC00054_n97categoriasfecultact[0];
            ZM055( -1) ;
         }
         pr_default.close(2);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
      }

      protected void CheckExtendedTable055( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors055( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey055( )
      {
         /* Using cursor BC00055 */
         pr_default.execute(3, new Object[] {A14categoriasid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00053 */
         pr_default.execute(1, new Object[] {A14categoriasid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM055( 1) ;
            RcdFound5 = 1;
            A14categoriasid = BC00053_A14categoriasid[0];
            A94categoriasdsc = BC00053_A94categoriasdsc[0];
            n94categoriasdsc = BC00053_n94categoriasdsc[0];
            A95categoriasusuario = BC00053_A95categoriasusuario[0];
            n95categoriasusuario = BC00053_n95categoriasusuario[0];
            A96categoriasfecreg = BC00053_A96categoriasfecreg[0];
            n96categoriasfecreg = BC00053_n96categoriasfecreg[0];
            A97categoriasfecultact = BC00053_A97categoriasfecultact[0];
            n97categoriasfecultact = BC00053_n97categoriasfecultact[0];
            Z14categoriasid = A14categoriasid;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load055( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey055( ) ;
            }
            Gx_mode = sMode5;
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey055( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode5;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey055( ) ;
         if ( RcdFound5 == 0 )
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
         CONFIRM_050( ) ;
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

      protected void CheckOptimisticConcurrency055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00052 */
            pr_default.execute(0, new Object[] {A14categoriasid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CATEGORIAS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z94categoriasdsc, BC00052_A94categoriasdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z95categoriasusuario, BC00052_A95categoriasusuario[0]) != 0 ) || ( Z96categoriasfecreg != BC00052_A96categoriasfecreg[0] ) || ( Z97categoriasfecultact != BC00052_A97categoriasfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CATEGORIAS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM055( 0) ;
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00056 */
                     pr_default.execute(4, new Object[] {A14categoriasid, n94categoriasdsc, A94categoriasdsc, n95categoriasusuario, A95categoriasusuario, n96categoriasfecreg, A96categoriasfecreg, n97categoriasfecultact, A97categoriasfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("CATEGORIAS") ;
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00057 */
                     pr_default.execute(5, new Object[] {n94categoriasdsc, A94categoriasdsc, n95categoriasusuario, A95categoriasusuario, n96categoriasfecreg, A96categoriasfecreg, n97categoriasfecultact, A97categoriasfecultact, A14categoriasid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("CATEGORIAS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CATEGORIAS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate055( ) ;
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
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls055( ) ;
            AfterConfirm055( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete055( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00058 */
                  pr_default.execute(6, new Object[] {A14categoriasid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("CATEGORIAS") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel055( ) ;
         Gx_mode = sMode5;
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete055( ) ;
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

      public void ScanKeyStart055( )
      {
         /* Using cursor BC00059 */
         pr_default.execute(7, new Object[] {A14categoriasid});
         RcdFound5 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
            A14categoriasid = BC00059_A14categoriasid[0];
            A94categoriasdsc = BC00059_A94categoriasdsc[0];
            n94categoriasdsc = BC00059_n94categoriasdsc[0];
            A95categoriasusuario = BC00059_A95categoriasusuario[0];
            n95categoriasusuario = BC00059_n95categoriasusuario[0];
            A96categoriasfecreg = BC00059_A96categoriasfecreg[0];
            n96categoriasfecreg = BC00059_n96categoriasfecreg[0];
            A97categoriasfecultact = BC00059_A97categoriasfecultact[0];
            n97categoriasfecultact = BC00059_n97categoriasfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext055( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound5 = 0;
         ScanKeyLoad055( ) ;
      }

      protected void ScanKeyLoad055( )
      {
         sMode5 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
            A14categoriasid = BC00059_A14categoriasid[0];
            A94categoriasdsc = BC00059_A94categoriasdsc[0];
            n94categoriasdsc = BC00059_n94categoriasdsc[0];
            A95categoriasusuario = BC00059_A95categoriasusuario[0];
            n95categoriasusuario = BC00059_n95categoriasusuario[0];
            A96categoriasfecreg = BC00059_A96categoriasfecreg[0];
            n96categoriasfecreg = BC00059_n96categoriasfecreg[0];
            A97categoriasfecultact = BC00059_A97categoriasfecultact[0];
            n97categoriasfecultact = BC00059_n97categoriasfecultact[0];
         }
         Gx_mode = sMode5;
      }

      protected void ScanKeyEnd055( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes055( )
      {
      }

      protected void AddRow055( )
      {
         VarsToRow5( bccategorias) ;
      }

      protected void ReadRow055( )
      {
         RowToVars5( bccategorias, 1) ;
      }

      protected void InitializeNonKey055( )
      {
         A94categoriasdsc = "";
         n94categoriasdsc = false;
         A95categoriasusuario = "";
         n95categoriasusuario = false;
         A96categoriasfecreg = (DateTime)(DateTime.MinValue);
         n96categoriasfecreg = false;
         A97categoriasfecultact = (DateTime)(DateTime.MinValue);
         n97categoriasfecultact = false;
         Z94categoriasdsc = "";
         Z95categoriasusuario = "";
         Z96categoriasfecreg = (DateTime)(DateTime.MinValue);
         Z97categoriasfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll055( )
      {
         A14categoriasid = 0;
         InitializeNonKey055( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow5( Sdtcategorias obj5 )
      {
         obj5.gxTpr_Mode = Gx_mode;
         obj5.gxTpr_Categoriasdsc = A94categoriasdsc;
         obj5.gxTpr_Categoriasusuario = A95categoriasusuario;
         obj5.gxTpr_Categoriasfecreg = A96categoriasfecreg;
         obj5.gxTpr_Categoriasfecultact = A97categoriasfecultact;
         obj5.gxTpr_Categoriasid = A14categoriasid;
         obj5.gxTpr_Categoriasid_Z = Z14categoriasid;
         obj5.gxTpr_Categoriasdsc_Z = Z94categoriasdsc;
         obj5.gxTpr_Categoriasusuario_Z = Z95categoriasusuario;
         obj5.gxTpr_Categoriasfecreg_Z = Z96categoriasfecreg;
         obj5.gxTpr_Categoriasfecultact_Z = Z97categoriasfecultact;
         obj5.gxTpr_Categoriasdsc_N = (short)(Convert.ToInt16(n94categoriasdsc));
         obj5.gxTpr_Categoriasusuario_N = (short)(Convert.ToInt16(n95categoriasusuario));
         obj5.gxTpr_Categoriasfecreg_N = (short)(Convert.ToInt16(n96categoriasfecreg));
         obj5.gxTpr_Categoriasfecultact_N = (short)(Convert.ToInt16(n97categoriasfecultact));
         obj5.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow5( Sdtcategorias obj5 )
      {
         obj5.gxTpr_Categoriasid = A14categoriasid;
         return  ;
      }

      public void RowToVars5( Sdtcategorias obj5 ,
                              int forceLoad )
      {
         Gx_mode = obj5.gxTpr_Mode;
         A94categoriasdsc = obj5.gxTpr_Categoriasdsc;
         n94categoriasdsc = false;
         A95categoriasusuario = obj5.gxTpr_Categoriasusuario;
         n95categoriasusuario = false;
         A96categoriasfecreg = obj5.gxTpr_Categoriasfecreg;
         n96categoriasfecreg = false;
         A97categoriasfecultact = obj5.gxTpr_Categoriasfecultact;
         n97categoriasfecultact = false;
         A14categoriasid = obj5.gxTpr_Categoriasid;
         Z14categoriasid = obj5.gxTpr_Categoriasid_Z;
         Z94categoriasdsc = obj5.gxTpr_Categoriasdsc_Z;
         Z95categoriasusuario = obj5.gxTpr_Categoriasusuario_Z;
         Z96categoriasfecreg = obj5.gxTpr_Categoriasfecreg_Z;
         Z97categoriasfecultact = obj5.gxTpr_Categoriasfecultact_Z;
         n94categoriasdsc = (bool)(Convert.ToBoolean(obj5.gxTpr_Categoriasdsc_N));
         n95categoriasusuario = (bool)(Convert.ToBoolean(obj5.gxTpr_Categoriasusuario_N));
         n96categoriasfecreg = (bool)(Convert.ToBoolean(obj5.gxTpr_Categoriasfecreg_N));
         n97categoriasfecultact = (bool)(Convert.ToBoolean(obj5.gxTpr_Categoriasfecultact_N));
         Gx_mode = obj5.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A14categoriasid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey055( ) ;
         ScanKeyStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z14categoriasid = A14categoriasid;
         }
         ZM055( -1) ;
         OnLoadActions055( ) ;
         AddRow055( ) ;
         ScanKeyEnd055( ) ;
         if ( RcdFound5 == 0 )
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
         RowToVars5( bccategorias, 0) ;
         ScanKeyStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z14categoriasid = A14categoriasid;
         }
         ZM055( -1) ;
         OnLoadActions055( ) ;
         AddRow055( ) ;
         ScanKeyEnd055( ) ;
         if ( RcdFound5 == 0 )
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
         RowToVars5( bccategorias, 0) ;
         nKeyPressed = 1;
         GetKey055( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert055( ) ;
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A14categoriasid != Z14categoriasid )
               {
                  A14categoriasid = Z14categoriasid;
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
                  Update055( ) ;
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
                  if ( A14categoriasid != Z14categoriasid )
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
                        Insert055( ) ;
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
                        Insert055( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow5( bccategorias) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars5( bccategorias, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey055( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A14categoriasid != Z14categoriasid )
            {
               A14categoriasid = Z14categoriasid;
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
            if ( A14categoriasid != Z14categoriasid )
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
         context.RollbackDataStores( "categorias_BC");
         VarsToRow5( bccategorias) ;
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
         Gx_mode = bccategorias.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bccategorias.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bccategorias )
         {
            bccategorias = (Sdtcategorias)(sdt);
            if ( StringUtil.StrCmp(bccategorias.gxTpr_Mode, "") == 0 )
            {
               bccategorias.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow5( bccategorias) ;
            }
            else
            {
               RowToVars5( bccategorias, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bccategorias.gxTpr_Mode, "") == 0 )
            {
               bccategorias.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars5( bccategorias, 1) ;
         return  ;
      }

      public Sdtcategorias categorias_BC
      {
         get {
            return bccategorias ;
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
         Z94categoriasdsc = "";
         A94categoriasdsc = "";
         Z95categoriasusuario = "";
         A95categoriasusuario = "";
         Z96categoriasfecreg = (DateTime)(DateTime.MinValue);
         A96categoriasfecreg = (DateTime)(DateTime.MinValue);
         Z97categoriasfecultact = (DateTime)(DateTime.MinValue);
         A97categoriasfecultact = (DateTime)(DateTime.MinValue);
         BC00054_A14categoriasid = new int[1] ;
         BC00054_A94categoriasdsc = new String[] {""} ;
         BC00054_n94categoriasdsc = new bool[] {false} ;
         BC00054_A95categoriasusuario = new String[] {""} ;
         BC00054_n95categoriasusuario = new bool[] {false} ;
         BC00054_A96categoriasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00054_n96categoriasfecreg = new bool[] {false} ;
         BC00054_A97categoriasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00054_n97categoriasfecultact = new bool[] {false} ;
         BC00055_A14categoriasid = new int[1] ;
         BC00053_A14categoriasid = new int[1] ;
         BC00053_A94categoriasdsc = new String[] {""} ;
         BC00053_n94categoriasdsc = new bool[] {false} ;
         BC00053_A95categoriasusuario = new String[] {""} ;
         BC00053_n95categoriasusuario = new bool[] {false} ;
         BC00053_A96categoriasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00053_n96categoriasfecreg = new bool[] {false} ;
         BC00053_A97categoriasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00053_n97categoriasfecultact = new bool[] {false} ;
         sMode5 = "";
         BC00052_A14categoriasid = new int[1] ;
         BC00052_A94categoriasdsc = new String[] {""} ;
         BC00052_n94categoriasdsc = new bool[] {false} ;
         BC00052_A95categoriasusuario = new String[] {""} ;
         BC00052_n95categoriasusuario = new bool[] {false} ;
         BC00052_A96categoriasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00052_n96categoriasfecreg = new bool[] {false} ;
         BC00052_A97categoriasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00052_n97categoriasfecultact = new bool[] {false} ;
         BC00059_A14categoriasid = new int[1] ;
         BC00059_A94categoriasdsc = new String[] {""} ;
         BC00059_n94categoriasdsc = new bool[] {false} ;
         BC00059_A95categoriasusuario = new String[] {""} ;
         BC00059_n95categoriasusuario = new bool[] {false} ;
         BC00059_A96categoriasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00059_n96categoriasfecreg = new bool[] {false} ;
         BC00059_A97categoriasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00059_n97categoriasfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.categorias_bc__default(),
            new Object[][] {
                new Object[] {
               BC00052_A14categoriasid, BC00052_A94categoriasdsc, BC00052_n94categoriasdsc, BC00052_A95categoriasusuario, BC00052_n95categoriasusuario, BC00052_A96categoriasfecreg, BC00052_n96categoriasfecreg, BC00052_A97categoriasfecultact, BC00052_n97categoriasfecultact
               }
               , new Object[] {
               BC00053_A14categoriasid, BC00053_A94categoriasdsc, BC00053_n94categoriasdsc, BC00053_A95categoriasusuario, BC00053_n95categoriasusuario, BC00053_A96categoriasfecreg, BC00053_n96categoriasfecreg, BC00053_A97categoriasfecultact, BC00053_n97categoriasfecultact
               }
               , new Object[] {
               BC00054_A14categoriasid, BC00054_A94categoriasdsc, BC00054_n94categoriasdsc, BC00054_A95categoriasusuario, BC00054_n95categoriasusuario, BC00054_A96categoriasfecreg, BC00054_n96categoriasfecreg, BC00054_A97categoriasfecultact, BC00054_n97categoriasfecultact
               }
               , new Object[] {
               BC00055_A14categoriasid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00059_A14categoriasid, BC00059_A94categoriasdsc, BC00059_n94categoriasdsc, BC00059_A95categoriasusuario, BC00059_n95categoriasusuario, BC00059_A96categoriasfecreg, BC00059_n96categoriasfecreg, BC00059_A97categoriasfecultact, BC00059_n97categoriasfecultact
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
      private short RcdFound5 ;
      private int trnEnded ;
      private int Z14categoriasid ;
      private int A14categoriasid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode5 ;
      private DateTime Z96categoriasfecreg ;
      private DateTime A96categoriasfecreg ;
      private DateTime Z97categoriasfecultact ;
      private DateTime A97categoriasfecultact ;
      private bool n94categoriasdsc ;
      private bool n95categoriasusuario ;
      private bool n96categoriasfecreg ;
      private bool n97categoriasfecultact ;
      private String Z94categoriasdsc ;
      private String A94categoriasdsc ;
      private String Z95categoriasusuario ;
      private String A95categoriasusuario ;
      private Sdtcategorias bccategorias ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00054_A14categoriasid ;
      private String[] BC00054_A94categoriasdsc ;
      private bool[] BC00054_n94categoriasdsc ;
      private String[] BC00054_A95categoriasusuario ;
      private bool[] BC00054_n95categoriasusuario ;
      private DateTime[] BC00054_A96categoriasfecreg ;
      private bool[] BC00054_n96categoriasfecreg ;
      private DateTime[] BC00054_A97categoriasfecultact ;
      private bool[] BC00054_n97categoriasfecultact ;
      private int[] BC00055_A14categoriasid ;
      private int[] BC00053_A14categoriasid ;
      private String[] BC00053_A94categoriasdsc ;
      private bool[] BC00053_n94categoriasdsc ;
      private String[] BC00053_A95categoriasusuario ;
      private bool[] BC00053_n95categoriasusuario ;
      private DateTime[] BC00053_A96categoriasfecreg ;
      private bool[] BC00053_n96categoriasfecreg ;
      private DateTime[] BC00053_A97categoriasfecultact ;
      private bool[] BC00053_n97categoriasfecultact ;
      private int[] BC00052_A14categoriasid ;
      private String[] BC00052_A94categoriasdsc ;
      private bool[] BC00052_n94categoriasdsc ;
      private String[] BC00052_A95categoriasusuario ;
      private bool[] BC00052_n95categoriasusuario ;
      private DateTime[] BC00052_A96categoriasfecreg ;
      private bool[] BC00052_n96categoriasfecreg ;
      private DateTime[] BC00052_A97categoriasfecultact ;
      private bool[] BC00052_n97categoriasfecultact ;
      private int[] BC00059_A14categoriasid ;
      private String[] BC00059_A94categoriasdsc ;
      private bool[] BC00059_n94categoriasdsc ;
      private String[] BC00059_A95categoriasusuario ;
      private bool[] BC00059_n95categoriasusuario ;
      private DateTime[] BC00059_A96categoriasfecreg ;
      private bool[] BC00059_n96categoriasfecreg ;
      private DateTime[] BC00059_A97categoriasfecultact ;
      private bool[] BC00059_n97categoriasfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class categorias_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00054 ;
          prmBC00054 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00055 ;
          prmBC00055 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00053 ;
          prmBC00053 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00052 ;
          prmBC00052 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00056 ;
          prmBC00056 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"categoriasdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"categoriasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"categoriasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"categoriasfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC00057 ;
          prmBC00057 = new Object[] {
          new Object[] {"categoriasdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"categoriasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"categoriasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"categoriasfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00058 ;
          prmBC00058 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00059 ;
          prmBC00059 = new Object[] {
          new Object[] {"categoriasid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00052", "SELECT categoriasid, categoriasdsc, categoriasusuario, categoriasfecreg, categoriasfecultact FROM public.categorias WHERE categoriasid = :categoriasid  FOR UPDATE OF categorias",true, GxErrorMask.GX_NOMASK, false, this,prmBC00052,1,0,true,false )
             ,new CursorDef("BC00053", "SELECT categoriasid, categoriasdsc, categoriasusuario, categoriasfecreg, categoriasfecultact FROM public.categorias WHERE categoriasid = :categoriasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00053,1,0,true,false )
             ,new CursorDef("BC00054", "SELECT TM1.categoriasid, TM1.categoriasdsc, TM1.categoriasusuario, TM1.categoriasfecreg, TM1.categoriasfecultact FROM public.categorias TM1 WHERE TM1.categoriasid = :categoriasid ORDER BY TM1.categoriasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00054,100,0,true,false )
             ,new CursorDef("BC00055", "SELECT categoriasid FROM public.categorias WHERE categoriasid = :categoriasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00055,1,0,true,false )
             ,new CursorDef("BC00056", "SAVEPOINT gxupdate;INSERT INTO public.categorias(categoriasid, categoriasdsc, categoriasusuario, categoriasfecreg, categoriasfecultact) VALUES(:categoriasid, :categoriasdsc, :categoriasusuario, :categoriasfecreg, :categoriasfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00056)
             ,new CursorDef("BC00057", "SAVEPOINT gxupdate;UPDATE public.categorias SET categoriasdsc=:categoriasdsc, categoriasusuario=:categoriasusuario, categoriasfecreg=:categoriasfecreg, categoriasfecultact=:categoriasfecultact  WHERE categoriasid = :categoriasid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00057)
             ,new CursorDef("BC00058", "SAVEPOINT gxupdate;DELETE FROM public.categorias  WHERE categoriasid = :categoriasid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00058)
             ,new CursorDef("BC00059", "SELECT TM1.categoriasid, TM1.categoriasdsc, TM1.categoriasusuario, TM1.categoriasfecreg, TM1.categoriasfecultact FROM public.categorias TM1 WHERE TM1.categoriasid = :categoriasid ORDER BY TM1.categoriasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00059,100,0,true,false )
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
