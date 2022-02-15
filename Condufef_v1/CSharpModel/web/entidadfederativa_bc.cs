/*
               File: entidadfederativa_BC
        Description: entidadfederativa
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:44.8
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
   public class entidadfederativa_bc : GXHttpHandler, IGxSilentTrn
   {
      public entidadfederativa_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public entidadfederativa_bc( IGxContext context )
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
         ReadRow044( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey044( ) ;
         standaloneModal( ) ;
         AddRow044( ) ;
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
               Z7entidafederativaid = A7entidafederativaid;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls044( ) ;
            }
            else
            {
               CheckExtendedTable044( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors044( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z108entidadfederativadsc = A108entidadfederativadsc;
            Z109entidadfederativausuario = A109entidadfederativausuario;
            Z110entidadfederativafecreg = A110entidadfederativafecreg;
            Z111entidadfederativafecultact = A111entidadfederativafecultact;
         }
         if ( GX_JID == -1 )
         {
            Z7entidafederativaid = A7entidafederativaid;
            Z108entidadfederativadsc = A108entidadfederativadsc;
            Z109entidadfederativausuario = A109entidadfederativausuario;
            Z110entidadfederativafecreg = A110entidadfederativafecreg;
            Z111entidadfederativafecultact = A111entidadfederativafecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load044( )
      {
         /* Using cursor BC00044 */
         pr_default.execute(2, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound4 = 1;
            A108entidadfederativadsc = BC00044_A108entidadfederativadsc[0];
            n108entidadfederativadsc = BC00044_n108entidadfederativadsc[0];
            A109entidadfederativausuario = BC00044_A109entidadfederativausuario[0];
            n109entidadfederativausuario = BC00044_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = BC00044_A110entidadfederativafecreg[0];
            n110entidadfederativafecreg = BC00044_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = BC00044_A111entidadfederativafecultact[0];
            n111entidadfederativafecultact = BC00044_n111entidadfederativafecultact[0];
            ZM044( -1) ;
         }
         pr_default.close(2);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
      }

      protected void CheckExtendedTable044( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors044( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey044( )
      {
         /* Using cursor BC00045 */
         pr_default.execute(3, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00043 */
         pr_default.execute(1, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM044( 1) ;
            RcdFound4 = 1;
            A7entidafederativaid = BC00043_A7entidafederativaid[0];
            n7entidafederativaid = BC00043_n7entidafederativaid[0];
            A108entidadfederativadsc = BC00043_A108entidadfederativadsc[0];
            n108entidadfederativadsc = BC00043_n108entidadfederativadsc[0];
            A109entidadfederativausuario = BC00043_A109entidadfederativausuario[0];
            n109entidadfederativausuario = BC00043_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = BC00043_A110entidadfederativafecreg[0];
            n110entidadfederativafecreg = BC00043_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = BC00043_A111entidadfederativafecultact[0];
            n111entidadfederativafecultact = BC00043_n111entidadfederativafecultact[0];
            Z7entidafederativaid = A7entidafederativaid;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load044( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey044( ) ;
            }
            Gx_mode = sMode4;
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode4;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
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
         CONFIRM_040( ) ;
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

      protected void CheckOptimisticConcurrency044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00042 */
            pr_default.execute(0, new Object[] {n7entidafederativaid, A7entidafederativaid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z108entidadfederativadsc, BC00042_A108entidadfederativadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z109entidadfederativausuario, BC00042_A109entidadfederativausuario[0]) != 0 ) || ( Z110entidadfederativafecreg != BC00042_A110entidadfederativafecreg[0] ) || ( Z111entidadfederativafecultact != BC00042_A111entidadfederativafecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00046 */
                     pr_default.execute(4, new Object[] {n7entidafederativaid, A7entidafederativaid, n108entidadfederativadsc, A108entidadfederativadsc, n109entidadfederativausuario, A109entidadfederativausuario, n110entidadfederativafecreg, A110entidadfederativafecreg, n111entidadfederativafecultact, A111entidadfederativafecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
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
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00047 */
                     pr_default.execute(5, new Object[] {n108entidadfederativadsc, A108entidadfederativadsc, n109entidadfederativausuario, A109entidadfederativausuario, n110entidadfederativafecreg, A110entidadfederativafecreg, n111entidadfederativafecultact, A111entidadfederativafecultact, n7entidafederativaid, A7entidafederativaid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate044( ) ;
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
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00048 */
                  pr_default.execute(6, new Object[] {n7entidafederativaid, A7entidafederativaid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel044( ) ;
         Gx_mode = sMode4;
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC00049 */
            pr_default.execute(7, new Object[] {n7entidafederativaid, A7entidafederativaid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
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

      public void ScanKeyStart044( )
      {
         /* Using cursor BC000410 */
         pr_default.execute(8, new Object[] {n7entidafederativaid, A7entidafederativaid});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound4 = 1;
            A7entidafederativaid = BC000410_A7entidafederativaid[0];
            n7entidafederativaid = BC000410_n7entidafederativaid[0];
            A108entidadfederativadsc = BC000410_A108entidadfederativadsc[0];
            n108entidadfederativadsc = BC000410_n108entidadfederativadsc[0];
            A109entidadfederativausuario = BC000410_A109entidadfederativausuario[0];
            n109entidadfederativausuario = BC000410_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = BC000410_A110entidadfederativafecreg[0];
            n110entidadfederativafecreg = BC000410_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = BC000410_A111entidadfederativafecultact[0];
            n111entidadfederativafecultact = BC000410_n111entidadfederativafecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext044( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound4 = 0;
         ScanKeyLoad044( ) ;
      }

      protected void ScanKeyLoad044( )
      {
         sMode4 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound4 = 1;
            A7entidafederativaid = BC000410_A7entidafederativaid[0];
            n7entidafederativaid = BC000410_n7entidafederativaid[0];
            A108entidadfederativadsc = BC000410_A108entidadfederativadsc[0];
            n108entidadfederativadsc = BC000410_n108entidadfederativadsc[0];
            A109entidadfederativausuario = BC000410_A109entidadfederativausuario[0];
            n109entidadfederativausuario = BC000410_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = BC000410_A110entidadfederativafecreg[0];
            n110entidadfederativafecreg = BC000410_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = BC000410_A111entidadfederativafecultact[0];
            n111entidadfederativafecultact = BC000410_n111entidadfederativafecultact[0];
         }
         Gx_mode = sMode4;
      }

      protected void ScanKeyEnd044( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
      }

      protected void AddRow044( )
      {
         VarsToRow4( bcentidadfederativa) ;
      }

      protected void ReadRow044( )
      {
         RowToVars4( bcentidadfederativa, 1) ;
      }

      protected void InitializeNonKey044( )
      {
         A108entidadfederativadsc = "";
         n108entidadfederativadsc = false;
         A109entidadfederativausuario = "";
         n109entidadfederativausuario = false;
         A110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         n110entidadfederativafecreg = false;
         A111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         n111entidadfederativafecultact = false;
         Z108entidadfederativadsc = "";
         Z109entidadfederativausuario = "";
         Z110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         Z111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll044( )
      {
         A7entidafederativaid = 0;
         n7entidafederativaid = false;
         InitializeNonKey044( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow4( Sdtentidadfederativa obj4 )
      {
         obj4.gxTpr_Mode = Gx_mode;
         obj4.gxTpr_Entidadfederativadsc = A108entidadfederativadsc;
         obj4.gxTpr_Entidadfederativausuario = A109entidadfederativausuario;
         obj4.gxTpr_Entidadfederativafecreg = A110entidadfederativafecreg;
         obj4.gxTpr_Entidadfederativafecultact = A111entidadfederativafecultact;
         obj4.gxTpr_Entidafederativaid = A7entidafederativaid;
         obj4.gxTpr_Entidafederativaid_Z = Z7entidafederativaid;
         obj4.gxTpr_Entidadfederativadsc_Z = Z108entidadfederativadsc;
         obj4.gxTpr_Entidadfederativausuario_Z = Z109entidadfederativausuario;
         obj4.gxTpr_Entidadfederativafecreg_Z = Z110entidadfederativafecreg;
         obj4.gxTpr_Entidadfederativafecultact_Z = Z111entidadfederativafecultact;
         obj4.gxTpr_Entidafederativaid_N = (short)(Convert.ToInt16(n7entidafederativaid));
         obj4.gxTpr_Entidadfederativadsc_N = (short)(Convert.ToInt16(n108entidadfederativadsc));
         obj4.gxTpr_Entidadfederativausuario_N = (short)(Convert.ToInt16(n109entidadfederativausuario));
         obj4.gxTpr_Entidadfederativafecreg_N = (short)(Convert.ToInt16(n110entidadfederativafecreg));
         obj4.gxTpr_Entidadfederativafecultact_N = (short)(Convert.ToInt16(n111entidadfederativafecultact));
         obj4.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow4( Sdtentidadfederativa obj4 )
      {
         obj4.gxTpr_Entidafederativaid = A7entidafederativaid;
         return  ;
      }

      public void RowToVars4( Sdtentidadfederativa obj4 ,
                              int forceLoad )
      {
         Gx_mode = obj4.gxTpr_Mode;
         A108entidadfederativadsc = obj4.gxTpr_Entidadfederativadsc;
         n108entidadfederativadsc = false;
         A109entidadfederativausuario = obj4.gxTpr_Entidadfederativausuario;
         n109entidadfederativausuario = false;
         A110entidadfederativafecreg = obj4.gxTpr_Entidadfederativafecreg;
         n110entidadfederativafecreg = false;
         A111entidadfederativafecultact = obj4.gxTpr_Entidadfederativafecultact;
         n111entidadfederativafecultact = false;
         A7entidafederativaid = obj4.gxTpr_Entidafederativaid;
         n7entidafederativaid = false;
         Z7entidafederativaid = obj4.gxTpr_Entidafederativaid_Z;
         Z108entidadfederativadsc = obj4.gxTpr_Entidadfederativadsc_Z;
         Z109entidadfederativausuario = obj4.gxTpr_Entidadfederativausuario_Z;
         Z110entidadfederativafecreg = obj4.gxTpr_Entidadfederativafecreg_Z;
         Z111entidadfederativafecultact = obj4.gxTpr_Entidadfederativafecultact_Z;
         n7entidafederativaid = (bool)(Convert.ToBoolean(obj4.gxTpr_Entidafederativaid_N));
         n108entidadfederativadsc = (bool)(Convert.ToBoolean(obj4.gxTpr_Entidadfederativadsc_N));
         n109entidadfederativausuario = (bool)(Convert.ToBoolean(obj4.gxTpr_Entidadfederativausuario_N));
         n110entidadfederativafecreg = (bool)(Convert.ToBoolean(obj4.gxTpr_Entidadfederativafecreg_N));
         n111entidadfederativafecultact = (bool)(Convert.ToBoolean(obj4.gxTpr_Entidadfederativafecultact_N));
         Gx_mode = obj4.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A7entidafederativaid = (int)getParm(obj,0);
         n7entidafederativaid = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey044( ) ;
         ScanKeyStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z7entidafederativaid = A7entidafederativaid;
         }
         ZM044( -1) ;
         OnLoadActions044( ) ;
         AddRow044( ) ;
         ScanKeyEnd044( ) ;
         if ( RcdFound4 == 0 )
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
         RowToVars4( bcentidadfederativa, 0) ;
         ScanKeyStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z7entidafederativaid = A7entidafederativaid;
         }
         ZM044( -1) ;
         OnLoadActions044( ) ;
         AddRow044( ) ;
         ScanKeyEnd044( ) ;
         if ( RcdFound4 == 0 )
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
         RowToVars4( bcentidadfederativa, 0) ;
         nKeyPressed = 1;
         GetKey044( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert044( ) ;
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A7entidafederativaid != Z7entidafederativaid )
               {
                  A7entidafederativaid = Z7entidafederativaid;
                  n7entidafederativaid = false;
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
                  Update044( ) ;
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
                  if ( A7entidafederativaid != Z7entidafederativaid )
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
                        Insert044( ) ;
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
                        Insert044( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow4( bcentidadfederativa) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars4( bcentidadfederativa, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey044( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A7entidafederativaid != Z7entidafederativaid )
            {
               A7entidafederativaid = Z7entidafederativaid;
               n7entidafederativaid = false;
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
            if ( A7entidafederativaid != Z7entidafederativaid )
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
         context.RollbackDataStores( "entidadfederativa_BC");
         VarsToRow4( bcentidadfederativa) ;
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
         Gx_mode = bcentidadfederativa.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcentidadfederativa.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcentidadfederativa )
         {
            bcentidadfederativa = (Sdtentidadfederativa)(sdt);
            if ( StringUtil.StrCmp(bcentidadfederativa.gxTpr_Mode, "") == 0 )
            {
               bcentidadfederativa.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow4( bcentidadfederativa) ;
            }
            else
            {
               RowToVars4( bcentidadfederativa, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcentidadfederativa.gxTpr_Mode, "") == 0 )
            {
               bcentidadfederativa.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars4( bcentidadfederativa, 1) ;
         return  ;
      }

      public Sdtentidadfederativa entidadfederativa_BC
      {
         get {
            return bcentidadfederativa ;
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
         Z108entidadfederativadsc = "";
         A108entidadfederativadsc = "";
         Z109entidadfederativausuario = "";
         A109entidadfederativausuario = "";
         Z110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         A110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         Z111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         A111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         BC00044_A7entidafederativaid = new int[1] ;
         BC00044_n7entidafederativaid = new bool[] {false} ;
         BC00044_A108entidadfederativadsc = new String[] {""} ;
         BC00044_n108entidadfederativadsc = new bool[] {false} ;
         BC00044_A109entidadfederativausuario = new String[] {""} ;
         BC00044_n109entidadfederativausuario = new bool[] {false} ;
         BC00044_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         BC00044_n110entidadfederativafecreg = new bool[] {false} ;
         BC00044_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         BC00044_n111entidadfederativafecultact = new bool[] {false} ;
         BC00045_A7entidafederativaid = new int[1] ;
         BC00045_n7entidafederativaid = new bool[] {false} ;
         BC00043_A7entidafederativaid = new int[1] ;
         BC00043_n7entidafederativaid = new bool[] {false} ;
         BC00043_A108entidadfederativadsc = new String[] {""} ;
         BC00043_n108entidadfederativadsc = new bool[] {false} ;
         BC00043_A109entidadfederativausuario = new String[] {""} ;
         BC00043_n109entidadfederativausuario = new bool[] {false} ;
         BC00043_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         BC00043_n110entidadfederativafecreg = new bool[] {false} ;
         BC00043_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         BC00043_n111entidadfederativafecultact = new bool[] {false} ;
         sMode4 = "";
         BC00042_A7entidafederativaid = new int[1] ;
         BC00042_n7entidafederativaid = new bool[] {false} ;
         BC00042_A108entidadfederativadsc = new String[] {""} ;
         BC00042_n108entidadfederativadsc = new bool[] {false} ;
         BC00042_A109entidadfederativausuario = new String[] {""} ;
         BC00042_n109entidadfederativausuario = new bool[] {false} ;
         BC00042_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         BC00042_n110entidadfederativafecreg = new bool[] {false} ;
         BC00042_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         BC00042_n111entidadfederativafecultact = new bool[] {false} ;
         BC00049_A19almacenid = new int[1] ;
         BC00049_A20articulosproductoid = new int[1] ;
         BC00049_A21articuloscambsid = new int[1] ;
         BC000410_A7entidafederativaid = new int[1] ;
         BC000410_n7entidafederativaid = new bool[] {false} ;
         BC000410_A108entidadfederativadsc = new String[] {""} ;
         BC000410_n108entidadfederativadsc = new bool[] {false} ;
         BC000410_A109entidadfederativausuario = new String[] {""} ;
         BC000410_n109entidadfederativausuario = new bool[] {false} ;
         BC000410_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         BC000410_n110entidadfederativafecreg = new bool[] {false} ;
         BC000410_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         BC000410_n111entidadfederativafecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.entidadfederativa_bc__default(),
            new Object[][] {
                new Object[] {
               BC00042_A7entidafederativaid, BC00042_A108entidadfederativadsc, BC00042_n108entidadfederativadsc, BC00042_A109entidadfederativausuario, BC00042_n109entidadfederativausuario, BC00042_A110entidadfederativafecreg, BC00042_n110entidadfederativafecreg, BC00042_A111entidadfederativafecultact, BC00042_n111entidadfederativafecultact
               }
               , new Object[] {
               BC00043_A7entidafederativaid, BC00043_A108entidadfederativadsc, BC00043_n108entidadfederativadsc, BC00043_A109entidadfederativausuario, BC00043_n109entidadfederativausuario, BC00043_A110entidadfederativafecreg, BC00043_n110entidadfederativafecreg, BC00043_A111entidadfederativafecultact, BC00043_n111entidadfederativafecultact
               }
               , new Object[] {
               BC00044_A7entidafederativaid, BC00044_A108entidadfederativadsc, BC00044_n108entidadfederativadsc, BC00044_A109entidadfederativausuario, BC00044_n109entidadfederativausuario, BC00044_A110entidadfederativafecreg, BC00044_n110entidadfederativafecreg, BC00044_A111entidadfederativafecultact, BC00044_n111entidadfederativafecultact
               }
               , new Object[] {
               BC00045_A7entidafederativaid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00049_A19almacenid, BC00049_A20articulosproductoid, BC00049_A21articuloscambsid
               }
               , new Object[] {
               BC000410_A7entidafederativaid, BC000410_A108entidadfederativadsc, BC000410_n108entidadfederativadsc, BC000410_A109entidadfederativausuario, BC000410_n109entidadfederativausuario, BC000410_A110entidadfederativafecreg, BC000410_n110entidadfederativafecreg, BC000410_A111entidadfederativafecultact, BC000410_n111entidadfederativafecultact
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
      private short RcdFound4 ;
      private int trnEnded ;
      private int Z7entidafederativaid ;
      private int A7entidafederativaid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode4 ;
      private DateTime Z110entidadfederativafecreg ;
      private DateTime A110entidadfederativafecreg ;
      private DateTime Z111entidadfederativafecultact ;
      private DateTime A111entidadfederativafecultact ;
      private bool n7entidafederativaid ;
      private bool n108entidadfederativadsc ;
      private bool n109entidadfederativausuario ;
      private bool n110entidadfederativafecreg ;
      private bool n111entidadfederativafecultact ;
      private String Z108entidadfederativadsc ;
      private String A108entidadfederativadsc ;
      private String Z109entidadfederativausuario ;
      private String A109entidadfederativausuario ;
      private Sdtentidadfederativa bcentidadfederativa ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00044_A7entidafederativaid ;
      private bool[] BC00044_n7entidafederativaid ;
      private String[] BC00044_A108entidadfederativadsc ;
      private bool[] BC00044_n108entidadfederativadsc ;
      private String[] BC00044_A109entidadfederativausuario ;
      private bool[] BC00044_n109entidadfederativausuario ;
      private DateTime[] BC00044_A110entidadfederativafecreg ;
      private bool[] BC00044_n110entidadfederativafecreg ;
      private DateTime[] BC00044_A111entidadfederativafecultact ;
      private bool[] BC00044_n111entidadfederativafecultact ;
      private int[] BC00045_A7entidafederativaid ;
      private bool[] BC00045_n7entidafederativaid ;
      private int[] BC00043_A7entidafederativaid ;
      private bool[] BC00043_n7entidafederativaid ;
      private String[] BC00043_A108entidadfederativadsc ;
      private bool[] BC00043_n108entidadfederativadsc ;
      private String[] BC00043_A109entidadfederativausuario ;
      private bool[] BC00043_n109entidadfederativausuario ;
      private DateTime[] BC00043_A110entidadfederativafecreg ;
      private bool[] BC00043_n110entidadfederativafecreg ;
      private DateTime[] BC00043_A111entidadfederativafecultact ;
      private bool[] BC00043_n111entidadfederativafecultact ;
      private int[] BC00042_A7entidafederativaid ;
      private bool[] BC00042_n7entidafederativaid ;
      private String[] BC00042_A108entidadfederativadsc ;
      private bool[] BC00042_n108entidadfederativadsc ;
      private String[] BC00042_A109entidadfederativausuario ;
      private bool[] BC00042_n109entidadfederativausuario ;
      private DateTime[] BC00042_A110entidadfederativafecreg ;
      private bool[] BC00042_n110entidadfederativafecreg ;
      private DateTime[] BC00042_A111entidadfederativafecultact ;
      private bool[] BC00042_n111entidadfederativafecultact ;
      private int[] BC00049_A19almacenid ;
      private int[] BC00049_A20articulosproductoid ;
      private int[] BC00049_A21articuloscambsid ;
      private int[] BC000410_A7entidafederativaid ;
      private bool[] BC000410_n7entidafederativaid ;
      private String[] BC000410_A108entidadfederativadsc ;
      private bool[] BC000410_n108entidadfederativadsc ;
      private String[] BC000410_A109entidadfederativausuario ;
      private bool[] BC000410_n109entidadfederativausuario ;
      private DateTime[] BC000410_A110entidadfederativafecreg ;
      private bool[] BC000410_n110entidadfederativafecreg ;
      private DateTime[] BC000410_A111entidadfederativafecultact ;
      private bool[] BC000410_n111entidadfederativafecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class entidadfederativa_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00044 ;
          prmBC00044 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00045 ;
          prmBC00045 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00043 ;
          prmBC00043 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00042 ;
          prmBC00042 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00046 ;
          prmBC00046 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"entidadfederativadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"entidadfederativausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"entidadfederativafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidadfederativafecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC00047 ;
          prmBC00047 = new Object[] {
          new Object[] {"entidadfederativadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"entidadfederativausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"entidadfederativafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidadfederativafecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00048 ;
          prmBC00048 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00049 ;
          prmBC00049 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000410 ;
          prmBC000410 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00042", "SELECT entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid  FOR UPDATE OF entidadfederativa",true, GxErrorMask.GX_NOMASK, false, this,prmBC00042,1,0,true,false )
             ,new CursorDef("BC00043", "SELECT entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00043,1,0,true,false )
             ,new CursorDef("BC00044", "SELECT TM1.entidafederativaid, TM1.entidadfederativadsc, TM1.entidadfederativausuario, TM1.entidadfederativafecreg, TM1.entidadfederativafecultact FROM public.entidadfederativa TM1 WHERE TM1.entidafederativaid = :entidafederativaid ORDER BY TM1.entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00044,100,0,true,false )
             ,new CursorDef("BC00045", "SELECT entidafederativaid FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00045,1,0,true,false )
             ,new CursorDef("BC00046", "SAVEPOINT gxupdate;INSERT INTO public.entidadfederativa(entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact) VALUES(:entidafederativaid, :entidadfederativadsc, :entidadfederativausuario, :entidadfederativafecreg, :entidadfederativafecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00046)
             ,new CursorDef("BC00047", "SAVEPOINT gxupdate;UPDATE public.entidadfederativa SET entidadfederativadsc=:entidadfederativadsc, entidadfederativausuario=:entidadfederativausuario, entidadfederativafecreg=:entidadfederativafecreg, entidadfederativafecultact=:entidadfederativafecultact  WHERE entidafederativaid = :entidafederativaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00047)
             ,new CursorDef("BC00048", "SAVEPOINT gxupdate;DELETE FROM public.entidadfederativa  WHERE entidafederativaid = :entidafederativaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00048)
             ,new CursorDef("BC00049", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE entidadid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00049,1,0,true,true )
             ,new CursorDef("BC000410", "SELECT TM1.entidafederativaid, TM1.entidadfederativadsc, TM1.entidadfederativausuario, TM1.entidadfederativafecreg, TM1.entidadfederativafecultact FROM public.entidadfederativa TM1 WHERE TM1.entidafederativaid = :entidafederativaid ORDER BY TM1.entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000410,100,0,true,false )
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
                   stmt.SetParameterDatetime(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
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
       }
    }

 }

}
