/*
               File: marcas_BC
        Description: marcas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:37:32.13
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
   public class marcas_bc : GXHttpHandler, IGxSilentTrn
   {
      public marcas_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public marcas_bc( IGxContext context )
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
         ReadRow088( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey088( ) ;
         standaloneModal( ) ;
         AddRow088( ) ;
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
               Z24marcasid = A24marcasid;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls088( ) ;
            }
            else
            {
               CheckExtendedTable088( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors088( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM088( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z112marcasdsc = A112marcasdsc;
            Z113marcasusuario = A113marcasusuario;
            Z114marcasfecreg = A114marcasfecreg;
            Z115marcasfecultact = A115marcasfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z24marcasid = A24marcasid;
            Z112marcasdsc = A112marcasdsc;
            Z113marcasusuario = A113marcasusuario;
            Z114marcasfecreg = A114marcasfecreg;
            Z115marcasfecultact = A115marcasfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load088( )
      {
         /* Using cursor BC00084 */
         pr_default.execute(2, new Object[] {A24marcasid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound8 = 1;
            A112marcasdsc = BC00084_A112marcasdsc[0];
            n112marcasdsc = BC00084_n112marcasdsc[0];
            A113marcasusuario = BC00084_A113marcasusuario[0];
            n113marcasusuario = BC00084_n113marcasusuario[0];
            A114marcasfecreg = BC00084_A114marcasfecreg[0];
            n114marcasfecreg = BC00084_n114marcasfecreg[0];
            A115marcasfecultact = BC00084_A115marcasfecultact[0];
            n115marcasfecultact = BC00084_n115marcasfecultact[0];
            ZM088( -1) ;
         }
         pr_default.close(2);
         OnLoadActions088( ) ;
      }

      protected void OnLoadActions088( )
      {
      }

      protected void CheckExtendedTable088( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors088( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey088( )
      {
         /* Using cursor BC00085 */
         pr_default.execute(3, new Object[] {A24marcasid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00083 */
         pr_default.execute(1, new Object[] {A24marcasid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM088( 1) ;
            RcdFound8 = 1;
            A24marcasid = BC00083_A24marcasid[0];
            A112marcasdsc = BC00083_A112marcasdsc[0];
            n112marcasdsc = BC00083_n112marcasdsc[0];
            A113marcasusuario = BC00083_A113marcasusuario[0];
            n113marcasusuario = BC00083_n113marcasusuario[0];
            A114marcasfecreg = BC00083_A114marcasfecreg[0];
            n114marcasfecreg = BC00083_n114marcasfecreg[0];
            A115marcasfecultact = BC00083_A115marcasfecultact[0];
            n115marcasfecultact = BC00083_n115marcasfecultact[0];
            Z24marcasid = A24marcasid;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load088( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey088( ) ;
            }
            Gx_mode = sMode8;
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey088( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode8;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey088( ) ;
         if ( RcdFound8 == 0 )
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
         CONFIRM_080( ) ;
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

      protected void CheckOptimisticConcurrency088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00082 */
            pr_default.execute(0, new Object[] {A24marcasid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MARCAS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z112marcasdsc, BC00082_A112marcasdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z113marcasusuario, BC00082_A113marcasusuario[0]) != 0 ) || ( Z114marcasfecreg != BC00082_A114marcasfecreg[0] ) || ( Z115marcasfecultact != BC00082_A115marcasfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MARCAS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM088( 0) ;
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00086 */
                     pr_default.execute(4, new Object[] {A24marcasid, n112marcasdsc, A112marcasdsc, n113marcasusuario, A113marcasusuario, n114marcasfecreg, A114marcasfecreg, n115marcasfecultact, A115marcasfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("MARCAS") ;
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
               Load088( ) ;
            }
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void Update088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00087 */
                     pr_default.execute(5, new Object[] {n112marcasdsc, A112marcasdsc, n113marcasusuario, A113marcasusuario, n114marcasfecreg, A114marcasfecreg, n115marcasfecultact, A115marcasfecultact, A24marcasid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("MARCAS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MARCAS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate088( ) ;
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
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void DeferredUpdate088( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls088( ) ;
            AfterConfirm088( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete088( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00088 */
                  pr_default.execute(6, new Object[] {A24marcasid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("MARCAS") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel088( ) ;
         Gx_mode = sMode8;
      }

      protected void OnDeleteControls088( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete088( ) ;
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

      public void ScanKeyStart088( )
      {
         /* Using cursor BC00089 */
         pr_default.execute(7, new Object[] {A24marcasid});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
            A24marcasid = BC00089_A24marcasid[0];
            A112marcasdsc = BC00089_A112marcasdsc[0];
            n112marcasdsc = BC00089_n112marcasdsc[0];
            A113marcasusuario = BC00089_A113marcasusuario[0];
            n113marcasusuario = BC00089_n113marcasusuario[0];
            A114marcasfecreg = BC00089_A114marcasfecreg[0];
            n114marcasfecreg = BC00089_n114marcasfecreg[0];
            A115marcasfecultact = BC00089_A115marcasfecultact[0];
            n115marcasfecultact = BC00089_n115marcasfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext088( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound8 = 0;
         ScanKeyLoad088( ) ;
      }

      protected void ScanKeyLoad088( )
      {
         sMode8 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
            A24marcasid = BC00089_A24marcasid[0];
            A112marcasdsc = BC00089_A112marcasdsc[0];
            n112marcasdsc = BC00089_n112marcasdsc[0];
            A113marcasusuario = BC00089_A113marcasusuario[0];
            n113marcasusuario = BC00089_n113marcasusuario[0];
            A114marcasfecreg = BC00089_A114marcasfecreg[0];
            n114marcasfecreg = BC00089_n114marcasfecreg[0];
            A115marcasfecultact = BC00089_A115marcasfecultact[0];
            n115marcasfecultact = BC00089_n115marcasfecultact[0];
         }
         Gx_mode = sMode8;
      }

      protected void ScanKeyEnd088( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm088( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert088( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate088( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete088( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete088( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate088( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes088( )
      {
      }

      protected void AddRow088( )
      {
         VarsToRow8( bcmarcas) ;
      }

      protected void ReadRow088( )
      {
         RowToVars8( bcmarcas, 1) ;
      }

      protected void InitializeNonKey088( )
      {
         A112marcasdsc = "";
         n112marcasdsc = false;
         A113marcasusuario = "";
         n113marcasusuario = false;
         A114marcasfecreg = (DateTime)(DateTime.MinValue);
         n114marcasfecreg = false;
         A115marcasfecultact = (DateTime)(DateTime.MinValue);
         n115marcasfecultact = false;
         Z112marcasdsc = "";
         Z113marcasusuario = "";
         Z114marcasfecreg = (DateTime)(DateTime.MinValue);
         Z115marcasfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll088( )
      {
         A24marcasid = 0;
         InitializeNonKey088( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow8( Sdtmarcas obj8 )
      {
         obj8.gxTpr_Mode = Gx_mode;
         obj8.gxTpr_Marcasdsc = A112marcasdsc;
         obj8.gxTpr_Marcasusuario = A113marcasusuario;
         obj8.gxTpr_Marcasfecreg = A114marcasfecreg;
         obj8.gxTpr_Marcasfecultact = A115marcasfecultact;
         obj8.gxTpr_Marcasid = A24marcasid;
         obj8.gxTpr_Marcasid_Z = Z24marcasid;
         obj8.gxTpr_Marcasdsc_Z = Z112marcasdsc;
         obj8.gxTpr_Marcasusuario_Z = Z113marcasusuario;
         obj8.gxTpr_Marcasfecreg_Z = Z114marcasfecreg;
         obj8.gxTpr_Marcasfecultact_Z = Z115marcasfecultact;
         obj8.gxTpr_Marcasdsc_N = (short)(Convert.ToInt16(n112marcasdsc));
         obj8.gxTpr_Marcasusuario_N = (short)(Convert.ToInt16(n113marcasusuario));
         obj8.gxTpr_Marcasfecreg_N = (short)(Convert.ToInt16(n114marcasfecreg));
         obj8.gxTpr_Marcasfecultact_N = (short)(Convert.ToInt16(n115marcasfecultact));
         obj8.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow8( Sdtmarcas obj8 )
      {
         obj8.gxTpr_Marcasid = A24marcasid;
         return  ;
      }

      public void RowToVars8( Sdtmarcas obj8 ,
                              int forceLoad )
      {
         Gx_mode = obj8.gxTpr_Mode;
         A112marcasdsc = obj8.gxTpr_Marcasdsc;
         n112marcasdsc = false;
         A113marcasusuario = obj8.gxTpr_Marcasusuario;
         n113marcasusuario = false;
         A114marcasfecreg = obj8.gxTpr_Marcasfecreg;
         n114marcasfecreg = false;
         A115marcasfecultact = obj8.gxTpr_Marcasfecultact;
         n115marcasfecultact = false;
         A24marcasid = obj8.gxTpr_Marcasid;
         Z24marcasid = obj8.gxTpr_Marcasid_Z;
         Z112marcasdsc = obj8.gxTpr_Marcasdsc_Z;
         Z113marcasusuario = obj8.gxTpr_Marcasusuario_Z;
         Z114marcasfecreg = obj8.gxTpr_Marcasfecreg_Z;
         Z115marcasfecultact = obj8.gxTpr_Marcasfecultact_Z;
         n112marcasdsc = (bool)(Convert.ToBoolean(obj8.gxTpr_Marcasdsc_N));
         n113marcasusuario = (bool)(Convert.ToBoolean(obj8.gxTpr_Marcasusuario_N));
         n114marcasfecreg = (bool)(Convert.ToBoolean(obj8.gxTpr_Marcasfecreg_N));
         n115marcasfecultact = (bool)(Convert.ToBoolean(obj8.gxTpr_Marcasfecultact_N));
         Gx_mode = obj8.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A24marcasid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey088( ) ;
         ScanKeyStart088( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z24marcasid = A24marcasid;
         }
         ZM088( -1) ;
         OnLoadActions088( ) ;
         AddRow088( ) ;
         ScanKeyEnd088( ) ;
         if ( RcdFound8 == 0 )
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
         RowToVars8( bcmarcas, 0) ;
         ScanKeyStart088( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z24marcasid = A24marcasid;
         }
         ZM088( -1) ;
         OnLoadActions088( ) ;
         AddRow088( ) ;
         ScanKeyEnd088( ) ;
         if ( RcdFound8 == 0 )
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
         RowToVars8( bcmarcas, 0) ;
         nKeyPressed = 1;
         GetKey088( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert088( ) ;
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A24marcasid != Z24marcasid )
               {
                  A24marcasid = Z24marcasid;
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
                  Update088( ) ;
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
                  if ( A24marcasid != Z24marcasid )
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
                        Insert088( ) ;
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
                        Insert088( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow8( bcmarcas) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars8( bcmarcas, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey088( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A24marcasid != Z24marcasid )
            {
               A24marcasid = Z24marcasid;
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
            if ( A24marcasid != Z24marcasid )
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
         context.RollbackDataStores( "marcas_BC");
         VarsToRow8( bcmarcas) ;
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
         Gx_mode = bcmarcas.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcmarcas.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcmarcas )
         {
            bcmarcas = (Sdtmarcas)(sdt);
            if ( StringUtil.StrCmp(bcmarcas.gxTpr_Mode, "") == 0 )
            {
               bcmarcas.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow8( bcmarcas) ;
            }
            else
            {
               RowToVars8( bcmarcas, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcmarcas.gxTpr_Mode, "") == 0 )
            {
               bcmarcas.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars8( bcmarcas, 1) ;
         return  ;
      }

      public Sdtmarcas marcas_BC
      {
         get {
            return bcmarcas ;
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
         Z112marcasdsc = "";
         A112marcasdsc = "";
         Z113marcasusuario = "";
         A113marcasusuario = "";
         Z114marcasfecreg = (DateTime)(DateTime.MinValue);
         A114marcasfecreg = (DateTime)(DateTime.MinValue);
         Z115marcasfecultact = (DateTime)(DateTime.MinValue);
         A115marcasfecultact = (DateTime)(DateTime.MinValue);
         BC00084_A24marcasid = new int[1] ;
         BC00084_A112marcasdsc = new String[] {""} ;
         BC00084_n112marcasdsc = new bool[] {false} ;
         BC00084_A113marcasusuario = new String[] {""} ;
         BC00084_n113marcasusuario = new bool[] {false} ;
         BC00084_A114marcasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00084_n114marcasfecreg = new bool[] {false} ;
         BC00084_A115marcasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00084_n115marcasfecultact = new bool[] {false} ;
         BC00085_A24marcasid = new int[1] ;
         BC00083_A24marcasid = new int[1] ;
         BC00083_A112marcasdsc = new String[] {""} ;
         BC00083_n112marcasdsc = new bool[] {false} ;
         BC00083_A113marcasusuario = new String[] {""} ;
         BC00083_n113marcasusuario = new bool[] {false} ;
         BC00083_A114marcasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00083_n114marcasfecreg = new bool[] {false} ;
         BC00083_A115marcasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00083_n115marcasfecultact = new bool[] {false} ;
         sMode8 = "";
         BC00082_A24marcasid = new int[1] ;
         BC00082_A112marcasdsc = new String[] {""} ;
         BC00082_n112marcasdsc = new bool[] {false} ;
         BC00082_A113marcasusuario = new String[] {""} ;
         BC00082_n113marcasusuario = new bool[] {false} ;
         BC00082_A114marcasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00082_n114marcasfecreg = new bool[] {false} ;
         BC00082_A115marcasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00082_n115marcasfecultact = new bool[] {false} ;
         BC00089_A24marcasid = new int[1] ;
         BC00089_A112marcasdsc = new String[] {""} ;
         BC00089_n112marcasdsc = new bool[] {false} ;
         BC00089_A113marcasusuario = new String[] {""} ;
         BC00089_n113marcasusuario = new bool[] {false} ;
         BC00089_A114marcasfecreg = new DateTime[] {DateTime.MinValue} ;
         BC00089_n114marcasfecreg = new bool[] {false} ;
         BC00089_A115marcasfecultact = new DateTime[] {DateTime.MinValue} ;
         BC00089_n115marcasfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.marcas_bc__default(),
            new Object[][] {
                new Object[] {
               BC00082_A24marcasid, BC00082_A112marcasdsc, BC00082_n112marcasdsc, BC00082_A113marcasusuario, BC00082_n113marcasusuario, BC00082_A114marcasfecreg, BC00082_n114marcasfecreg, BC00082_A115marcasfecultact, BC00082_n115marcasfecultact
               }
               , new Object[] {
               BC00083_A24marcasid, BC00083_A112marcasdsc, BC00083_n112marcasdsc, BC00083_A113marcasusuario, BC00083_n113marcasusuario, BC00083_A114marcasfecreg, BC00083_n114marcasfecreg, BC00083_A115marcasfecultact, BC00083_n115marcasfecultact
               }
               , new Object[] {
               BC00084_A24marcasid, BC00084_A112marcasdsc, BC00084_n112marcasdsc, BC00084_A113marcasusuario, BC00084_n113marcasusuario, BC00084_A114marcasfecreg, BC00084_n114marcasfecreg, BC00084_A115marcasfecultact, BC00084_n115marcasfecultact
               }
               , new Object[] {
               BC00085_A24marcasid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00089_A24marcasid, BC00089_A112marcasdsc, BC00089_n112marcasdsc, BC00089_A113marcasusuario, BC00089_n113marcasusuario, BC00089_A114marcasfecreg, BC00089_n114marcasfecreg, BC00089_A115marcasfecultact, BC00089_n115marcasfecultact
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
      private short RcdFound8 ;
      private int trnEnded ;
      private int Z24marcasid ;
      private int A24marcasid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode8 ;
      private DateTime Z114marcasfecreg ;
      private DateTime A114marcasfecreg ;
      private DateTime Z115marcasfecultact ;
      private DateTime A115marcasfecultact ;
      private bool n112marcasdsc ;
      private bool n113marcasusuario ;
      private bool n114marcasfecreg ;
      private bool n115marcasfecultact ;
      private String Z112marcasdsc ;
      private String A112marcasdsc ;
      private String Z113marcasusuario ;
      private String A113marcasusuario ;
      private Sdtmarcas bcmarcas ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00084_A24marcasid ;
      private String[] BC00084_A112marcasdsc ;
      private bool[] BC00084_n112marcasdsc ;
      private String[] BC00084_A113marcasusuario ;
      private bool[] BC00084_n113marcasusuario ;
      private DateTime[] BC00084_A114marcasfecreg ;
      private bool[] BC00084_n114marcasfecreg ;
      private DateTime[] BC00084_A115marcasfecultact ;
      private bool[] BC00084_n115marcasfecultact ;
      private int[] BC00085_A24marcasid ;
      private int[] BC00083_A24marcasid ;
      private String[] BC00083_A112marcasdsc ;
      private bool[] BC00083_n112marcasdsc ;
      private String[] BC00083_A113marcasusuario ;
      private bool[] BC00083_n113marcasusuario ;
      private DateTime[] BC00083_A114marcasfecreg ;
      private bool[] BC00083_n114marcasfecreg ;
      private DateTime[] BC00083_A115marcasfecultact ;
      private bool[] BC00083_n115marcasfecultact ;
      private int[] BC00082_A24marcasid ;
      private String[] BC00082_A112marcasdsc ;
      private bool[] BC00082_n112marcasdsc ;
      private String[] BC00082_A113marcasusuario ;
      private bool[] BC00082_n113marcasusuario ;
      private DateTime[] BC00082_A114marcasfecreg ;
      private bool[] BC00082_n114marcasfecreg ;
      private DateTime[] BC00082_A115marcasfecultact ;
      private bool[] BC00082_n115marcasfecultact ;
      private int[] BC00089_A24marcasid ;
      private String[] BC00089_A112marcasdsc ;
      private bool[] BC00089_n112marcasdsc ;
      private String[] BC00089_A113marcasusuario ;
      private bool[] BC00089_n113marcasusuario ;
      private DateTime[] BC00089_A114marcasfecreg ;
      private bool[] BC00089_n114marcasfecreg ;
      private DateTime[] BC00089_A115marcasfecultact ;
      private bool[] BC00089_n115marcasfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class marcas_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00084 ;
          prmBC00084 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00085 ;
          prmBC00085 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00083 ;
          prmBC00083 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00082 ;
          prmBC00082 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00086 ;
          prmBC00086 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"marcasdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"marcasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"marcasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"marcasfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC00087 ;
          prmBC00087 = new Object[] {
          new Object[] {"marcasdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"marcasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"marcasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"marcasfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00088 ;
          prmBC00088 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00089 ;
          prmBC00089 = new Object[] {
          new Object[] {"marcasid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00082", "SELECT marcasid, marcasdsc, marcasusuario, marcasfecreg, marcasfecultact FROM public.marcas WHERE marcasid = :marcasid  FOR UPDATE OF marcas",true, GxErrorMask.GX_NOMASK, false, this,prmBC00082,1,0,true,false )
             ,new CursorDef("BC00083", "SELECT marcasid, marcasdsc, marcasusuario, marcasfecreg, marcasfecultact FROM public.marcas WHERE marcasid = :marcasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00083,1,0,true,false )
             ,new CursorDef("BC00084", "SELECT TM1.marcasid, TM1.marcasdsc, TM1.marcasusuario, TM1.marcasfecreg, TM1.marcasfecultact FROM public.marcas TM1 WHERE TM1.marcasid = :marcasid ORDER BY TM1.marcasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00084,100,0,true,false )
             ,new CursorDef("BC00085", "SELECT marcasid FROM public.marcas WHERE marcasid = :marcasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00085,1,0,true,false )
             ,new CursorDef("BC00086", "SAVEPOINT gxupdate;INSERT INTO public.marcas(marcasid, marcasdsc, marcasusuario, marcasfecreg, marcasfecultact) VALUES(:marcasid, :marcasdsc, :marcasusuario, :marcasfecreg, :marcasfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00086)
             ,new CursorDef("BC00087", "SAVEPOINT gxupdate;UPDATE public.marcas SET marcasdsc=:marcasdsc, marcasusuario=:marcasusuario, marcasfecreg=:marcasfecreg, marcasfecultact=:marcasfecultact  WHERE marcasid = :marcasid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00087)
             ,new CursorDef("BC00088", "SAVEPOINT gxupdate;DELETE FROM public.marcas  WHERE marcasid = :marcasid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00088)
             ,new CursorDef("BC00089", "SELECT TM1.marcasid, TM1.marcasdsc, TM1.marcasusuario, TM1.marcasfecreg, TM1.marcasfecultact FROM public.marcas TM1 WHERE TM1.marcasid = :marcasid ORDER BY TM1.marcasid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00089,100,0,true,false )
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
