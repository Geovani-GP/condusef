/*
               File: estatusarticulo_BC
        Description: estatusarticulo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:20.25
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
   public class estatusarticulo_bc : GXHttpHandler, IGxSilentTrn
   {
      public estatusarticulo_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public estatusarticulo_bc( IGxContext context )
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
         ReadRow077( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey077( ) ;
         standaloneModal( ) ;
         AddRow077( ) ;
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
               Z12estatusarticuloid = A12estatusarticuloid;
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

      protected void CONFIRM_070( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls077( ) ;
            }
            else
            {
               CheckExtendedTable077( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors077( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z54estatusarticulodsc = A54estatusarticulodsc;
            Z55estatusarticulodescuso = A55estatusarticulodescuso;
            Z56estatusarticuloaplicamov = A56estatusarticuloaplicamov;
            Z57estatusarticulousotabla = A57estatusarticulousotabla;
            Z58estatusarticulousuario = A58estatusarticulousuario;
            Z59estatusarticulofecreg = A59estatusarticulofecreg;
            Z60estatusarticulofecultact = A60estatusarticulofecultact;
         }
         if ( GX_JID == -1 )
         {
            Z12estatusarticuloid = A12estatusarticuloid;
            Z54estatusarticulodsc = A54estatusarticulodsc;
            Z55estatusarticulodescuso = A55estatusarticulodescuso;
            Z56estatusarticuloaplicamov = A56estatusarticuloaplicamov;
            Z57estatusarticulousotabla = A57estatusarticulousotabla;
            Z58estatusarticulousuario = A58estatusarticulousuario;
            Z59estatusarticulofecreg = A59estatusarticulofecreg;
            Z60estatusarticulofecultact = A60estatusarticulofecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load077( )
      {
         /* Using cursor BC00074 */
         pr_default.execute(2, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound7 = 1;
            A54estatusarticulodsc = BC00074_A54estatusarticulodsc[0];
            n54estatusarticulodsc = BC00074_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = BC00074_A55estatusarticulodescuso[0];
            n55estatusarticulodescuso = BC00074_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = BC00074_A56estatusarticuloaplicamov[0];
            n56estatusarticuloaplicamov = BC00074_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = BC00074_A57estatusarticulousotabla[0];
            n57estatusarticulousotabla = BC00074_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = BC00074_A58estatusarticulousuario[0];
            n58estatusarticulousuario = BC00074_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = BC00074_A59estatusarticulofecreg[0];
            n59estatusarticulofecreg = BC00074_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = BC00074_A60estatusarticulofecultact[0];
            n60estatusarticulofecultact = BC00074_n60estatusarticulofecultact[0];
            ZM077( -1) ;
         }
         pr_default.close(2);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
      }

      protected void CheckExtendedTable077( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors077( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey077( )
      {
         /* Using cursor BC00075 */
         pr_default.execute(3, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00073 */
         pr_default.execute(1, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM077( 1) ;
            RcdFound7 = 1;
            A12estatusarticuloid = BC00073_A12estatusarticuloid[0];
            A54estatusarticulodsc = BC00073_A54estatusarticulodsc[0];
            n54estatusarticulodsc = BC00073_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = BC00073_A55estatusarticulodescuso[0];
            n55estatusarticulodescuso = BC00073_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = BC00073_A56estatusarticuloaplicamov[0];
            n56estatusarticuloaplicamov = BC00073_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = BC00073_A57estatusarticulousotabla[0];
            n57estatusarticulousotabla = BC00073_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = BC00073_A58estatusarticulousuario[0];
            n58estatusarticulousuario = BC00073_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = BC00073_A59estatusarticulofecreg[0];
            n59estatusarticulofecreg = BC00073_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = BC00073_A60estatusarticulofecultact[0];
            n60estatusarticulofecultact = BC00073_n60estatusarticulofecultact[0];
            Z12estatusarticuloid = A12estatusarticuloid;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode7;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
         if ( RcdFound7 == 0 )
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
         CONFIRM_070( ) ;
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

      protected void CheckOptimisticConcurrency077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00072 */
            pr_default.execute(0, new Object[] {A12estatusarticuloid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ESTATUSARTICULO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z54estatusarticulodsc, BC00072_A54estatusarticulodsc[0]) != 0 ) || ( StringUtil.StrCmp(Z55estatusarticulodescuso, BC00072_A55estatusarticulodescuso[0]) != 0 ) || ( Z56estatusarticuloaplicamov != BC00072_A56estatusarticuloaplicamov[0] ) || ( StringUtil.StrCmp(Z57estatusarticulousotabla, BC00072_A57estatusarticulousotabla[0]) != 0 ) || ( StringUtil.StrCmp(Z58estatusarticulousuario, BC00072_A58estatusarticulousuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z59estatusarticulofecreg != BC00072_A59estatusarticulofecreg[0] ) || ( Z60estatusarticulofecultact != BC00072_A60estatusarticulofecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ESTATUSARTICULO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM077( 0) ;
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00076 */
                     pr_default.execute(4, new Object[] {A12estatusarticuloid, n54estatusarticulodsc, A54estatusarticulodsc, n55estatusarticulodescuso, A55estatusarticulodescuso, n56estatusarticuloaplicamov, A56estatusarticuloaplicamov, n57estatusarticulousotabla, A57estatusarticulousotabla, n58estatusarticulousuario, A58estatusarticulousuario, n59estatusarticulofecreg, A59estatusarticulofecreg, n60estatusarticulofecultact, A60estatusarticulofecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
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
               Load077( ) ;
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void Update077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00077 */
                     pr_default.execute(5, new Object[] {n54estatusarticulodsc, A54estatusarticulodsc, n55estatusarticulodescuso, A55estatusarticulodescuso, n56estatusarticuloaplicamov, A56estatusarticuloaplicamov, n57estatusarticulousotabla, A57estatusarticulousotabla, n58estatusarticulousuario, A58estatusarticulousuario, n59estatusarticulofecreg, A59estatusarticulofecreg, n60estatusarticulofecultact, A60estatusarticulofecultact, A12estatusarticuloid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ESTATUSARTICULO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate077( ) ;
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
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls077( ) ;
            AfterConfirm077( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete077( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00078 */
                  pr_default.execute(6, new Object[] {A12estatusarticuloid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel077( ) ;
         Gx_mode = sMode7;
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete077( ) ;
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

      public void ScanKeyStart077( )
      {
         /* Using cursor BC00079 */
         pr_default.execute(7, new Object[] {A12estatusarticuloid});
         RcdFound7 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound7 = 1;
            A12estatusarticuloid = BC00079_A12estatusarticuloid[0];
            A54estatusarticulodsc = BC00079_A54estatusarticulodsc[0];
            n54estatusarticulodsc = BC00079_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = BC00079_A55estatusarticulodescuso[0];
            n55estatusarticulodescuso = BC00079_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = BC00079_A56estatusarticuloaplicamov[0];
            n56estatusarticuloaplicamov = BC00079_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = BC00079_A57estatusarticulousotabla[0];
            n57estatusarticulousotabla = BC00079_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = BC00079_A58estatusarticulousuario[0];
            n58estatusarticulousuario = BC00079_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = BC00079_A59estatusarticulofecreg[0];
            n59estatusarticulofecreg = BC00079_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = BC00079_A60estatusarticulofecultact[0];
            n60estatusarticulofecultact = BC00079_n60estatusarticulofecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext077( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound7 = 0;
         ScanKeyLoad077( ) ;
      }

      protected void ScanKeyLoad077( )
      {
         sMode7 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound7 = 1;
            A12estatusarticuloid = BC00079_A12estatusarticuloid[0];
            A54estatusarticulodsc = BC00079_A54estatusarticulodsc[0];
            n54estatusarticulodsc = BC00079_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = BC00079_A55estatusarticulodescuso[0];
            n55estatusarticulodescuso = BC00079_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = BC00079_A56estatusarticuloaplicamov[0];
            n56estatusarticuloaplicamov = BC00079_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = BC00079_A57estatusarticulousotabla[0];
            n57estatusarticulousotabla = BC00079_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = BC00079_A58estatusarticulousuario[0];
            n58estatusarticulousuario = BC00079_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = BC00079_A59estatusarticulofecreg[0];
            n59estatusarticulofecreg = BC00079_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = BC00079_A60estatusarticulofecultact[0];
            n60estatusarticulofecultact = BC00079_n60estatusarticulofecultact[0];
         }
         Gx_mode = sMode7;
      }

      protected void ScanKeyEnd077( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm077( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert077( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate077( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete077( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete077( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate077( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes077( )
      {
      }

      protected void AddRow077( )
      {
         VarsToRow7( bcestatusarticulo) ;
      }

      protected void ReadRow077( )
      {
         RowToVars7( bcestatusarticulo, 1) ;
      }

      protected void InitializeNonKey077( )
      {
         A54estatusarticulodsc = "";
         n54estatusarticulodsc = false;
         A55estatusarticulodescuso = "";
         n55estatusarticulodescuso = false;
         A56estatusarticuloaplicamov = 0;
         n56estatusarticuloaplicamov = false;
         A57estatusarticulousotabla = "";
         n57estatusarticulousotabla = false;
         A58estatusarticulousuario = "";
         n58estatusarticulousuario = false;
         A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         n59estatusarticulofecreg = false;
         A60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         n60estatusarticulofecultact = false;
         Z54estatusarticulodsc = "";
         Z55estatusarticulodescuso = "";
         Z56estatusarticuloaplicamov = 0;
         Z57estatusarticulousotabla = "";
         Z58estatusarticulousuario = "";
         Z59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         Z60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll077( )
      {
         A12estatusarticuloid = 0;
         InitializeNonKey077( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow7( Sdtestatusarticulo obj7 )
      {
         obj7.gxTpr_Mode = Gx_mode;
         obj7.gxTpr_Estatusarticulodsc = A54estatusarticulodsc;
         obj7.gxTpr_Estatusarticulodescuso = A55estatusarticulodescuso;
         obj7.gxTpr_Estatusarticuloaplicamov = A56estatusarticuloaplicamov;
         obj7.gxTpr_Estatusarticulousotabla = A57estatusarticulousotabla;
         obj7.gxTpr_Estatusarticulousuario = A58estatusarticulousuario;
         obj7.gxTpr_Estatusarticulofecreg = A59estatusarticulofecreg;
         obj7.gxTpr_Estatusarticulofecultact = A60estatusarticulofecultact;
         obj7.gxTpr_Estatusarticuloid = A12estatusarticuloid;
         obj7.gxTpr_Estatusarticuloid_Z = Z12estatusarticuloid;
         obj7.gxTpr_Estatusarticulodsc_Z = Z54estatusarticulodsc;
         obj7.gxTpr_Estatusarticulodescuso_Z = Z55estatusarticulodescuso;
         obj7.gxTpr_Estatusarticuloaplicamov_Z = Z56estatusarticuloaplicamov;
         obj7.gxTpr_Estatusarticulousotabla_Z = Z57estatusarticulousotabla;
         obj7.gxTpr_Estatusarticulousuario_Z = Z58estatusarticulousuario;
         obj7.gxTpr_Estatusarticulofecreg_Z = Z59estatusarticulofecreg;
         obj7.gxTpr_Estatusarticulofecultact_Z = Z60estatusarticulofecultact;
         obj7.gxTpr_Estatusarticulodsc_N = (short)(Convert.ToInt16(n54estatusarticulodsc));
         obj7.gxTpr_Estatusarticulodescuso_N = (short)(Convert.ToInt16(n55estatusarticulodescuso));
         obj7.gxTpr_Estatusarticuloaplicamov_N = (short)(Convert.ToInt16(n56estatusarticuloaplicamov));
         obj7.gxTpr_Estatusarticulousotabla_N = (short)(Convert.ToInt16(n57estatusarticulousotabla));
         obj7.gxTpr_Estatusarticulousuario_N = (short)(Convert.ToInt16(n58estatusarticulousuario));
         obj7.gxTpr_Estatusarticulofecreg_N = (short)(Convert.ToInt16(n59estatusarticulofecreg));
         obj7.gxTpr_Estatusarticulofecultact_N = (short)(Convert.ToInt16(n60estatusarticulofecultact));
         obj7.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow7( Sdtestatusarticulo obj7 )
      {
         obj7.gxTpr_Estatusarticuloid = A12estatusarticuloid;
         return  ;
      }

      public void RowToVars7( Sdtestatusarticulo obj7 ,
                              int forceLoad )
      {
         Gx_mode = obj7.gxTpr_Mode;
         A54estatusarticulodsc = obj7.gxTpr_Estatusarticulodsc;
         n54estatusarticulodsc = false;
         A55estatusarticulodescuso = obj7.gxTpr_Estatusarticulodescuso;
         n55estatusarticulodescuso = false;
         A56estatusarticuloaplicamov = obj7.gxTpr_Estatusarticuloaplicamov;
         n56estatusarticuloaplicamov = false;
         A57estatusarticulousotabla = obj7.gxTpr_Estatusarticulousotabla;
         n57estatusarticulousotabla = false;
         A58estatusarticulousuario = obj7.gxTpr_Estatusarticulousuario;
         n58estatusarticulousuario = false;
         A59estatusarticulofecreg = obj7.gxTpr_Estatusarticulofecreg;
         n59estatusarticulofecreg = false;
         A60estatusarticulofecultact = obj7.gxTpr_Estatusarticulofecultact;
         n60estatusarticulofecultact = false;
         A12estatusarticuloid = obj7.gxTpr_Estatusarticuloid;
         Z12estatusarticuloid = obj7.gxTpr_Estatusarticuloid_Z;
         Z54estatusarticulodsc = obj7.gxTpr_Estatusarticulodsc_Z;
         Z55estatusarticulodescuso = obj7.gxTpr_Estatusarticulodescuso_Z;
         Z56estatusarticuloaplicamov = obj7.gxTpr_Estatusarticuloaplicamov_Z;
         Z57estatusarticulousotabla = obj7.gxTpr_Estatusarticulousotabla_Z;
         Z58estatusarticulousuario = obj7.gxTpr_Estatusarticulousuario_Z;
         Z59estatusarticulofecreg = obj7.gxTpr_Estatusarticulofecreg_Z;
         Z60estatusarticulofecultact = obj7.gxTpr_Estatusarticulofecultact_Z;
         n54estatusarticulodsc = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulodsc_N));
         n55estatusarticulodescuso = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulodescuso_N));
         n56estatusarticuloaplicamov = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticuloaplicamov_N));
         n57estatusarticulousotabla = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulousotabla_N));
         n58estatusarticulousuario = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulousuario_N));
         n59estatusarticulofecreg = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulofecreg_N));
         n60estatusarticulofecultact = (bool)(Convert.ToBoolean(obj7.gxTpr_Estatusarticulofecultact_N));
         Gx_mode = obj7.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A12estatusarticuloid = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey077( ) ;
         ScanKeyStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z12estatusarticuloid = A12estatusarticuloid;
         }
         ZM077( -1) ;
         OnLoadActions077( ) ;
         AddRow077( ) ;
         ScanKeyEnd077( ) ;
         if ( RcdFound7 == 0 )
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
         RowToVars7( bcestatusarticulo, 0) ;
         ScanKeyStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z12estatusarticuloid = A12estatusarticuloid;
         }
         ZM077( -1) ;
         OnLoadActions077( ) ;
         AddRow077( ) ;
         ScanKeyEnd077( ) ;
         if ( RcdFound7 == 0 )
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
         RowToVars7( bcestatusarticulo, 0) ;
         nKeyPressed = 1;
         GetKey077( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert077( ) ;
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A12estatusarticuloid != Z12estatusarticuloid )
               {
                  A12estatusarticuloid = Z12estatusarticuloid;
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
                  Update077( ) ;
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
                  if ( A12estatusarticuloid != Z12estatusarticuloid )
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
                        Insert077( ) ;
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
                        Insert077( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow7( bcestatusarticulo) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars7( bcestatusarticulo, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey077( ) ;
         if ( RcdFound7 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A12estatusarticuloid != Z12estatusarticuloid )
            {
               A12estatusarticuloid = Z12estatusarticuloid;
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
            if ( A12estatusarticuloid != Z12estatusarticuloid )
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
         context.RollbackDataStores( "estatusarticulo_BC");
         VarsToRow7( bcestatusarticulo) ;
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
         Gx_mode = bcestatusarticulo.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcestatusarticulo.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcestatusarticulo )
         {
            bcestatusarticulo = (Sdtestatusarticulo)(sdt);
            if ( StringUtil.StrCmp(bcestatusarticulo.gxTpr_Mode, "") == 0 )
            {
               bcestatusarticulo.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow7( bcestatusarticulo) ;
            }
            else
            {
               RowToVars7( bcestatusarticulo, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcestatusarticulo.gxTpr_Mode, "") == 0 )
            {
               bcestatusarticulo.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars7( bcestatusarticulo, 1) ;
         return  ;
      }

      public Sdtestatusarticulo estatusarticulo_BC
      {
         get {
            return bcestatusarticulo ;
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
         Z54estatusarticulodsc = "";
         A54estatusarticulodsc = "";
         Z55estatusarticulodescuso = "";
         A55estatusarticulodescuso = "";
         Z57estatusarticulousotabla = "";
         A57estatusarticulousotabla = "";
         Z58estatusarticulousuario = "";
         A58estatusarticulousuario = "";
         Z59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         Z60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         A60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         BC00074_A12estatusarticuloid = new long[1] ;
         BC00074_A54estatusarticulodsc = new String[] {""} ;
         BC00074_n54estatusarticulodsc = new bool[] {false} ;
         BC00074_A55estatusarticulodescuso = new String[] {""} ;
         BC00074_n55estatusarticulodescuso = new bool[] {false} ;
         BC00074_A56estatusarticuloaplicamov = new int[1] ;
         BC00074_n56estatusarticuloaplicamov = new bool[] {false} ;
         BC00074_A57estatusarticulousotabla = new String[] {""} ;
         BC00074_n57estatusarticulousotabla = new bool[] {false} ;
         BC00074_A58estatusarticulousuario = new String[] {""} ;
         BC00074_n58estatusarticulousuario = new bool[] {false} ;
         BC00074_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00074_n59estatusarticulofecreg = new bool[] {false} ;
         BC00074_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00074_n60estatusarticulofecultact = new bool[] {false} ;
         BC00075_A12estatusarticuloid = new long[1] ;
         BC00073_A12estatusarticuloid = new long[1] ;
         BC00073_A54estatusarticulodsc = new String[] {""} ;
         BC00073_n54estatusarticulodsc = new bool[] {false} ;
         BC00073_A55estatusarticulodescuso = new String[] {""} ;
         BC00073_n55estatusarticulodescuso = new bool[] {false} ;
         BC00073_A56estatusarticuloaplicamov = new int[1] ;
         BC00073_n56estatusarticuloaplicamov = new bool[] {false} ;
         BC00073_A57estatusarticulousotabla = new String[] {""} ;
         BC00073_n57estatusarticulousotabla = new bool[] {false} ;
         BC00073_A58estatusarticulousuario = new String[] {""} ;
         BC00073_n58estatusarticulousuario = new bool[] {false} ;
         BC00073_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00073_n59estatusarticulofecreg = new bool[] {false} ;
         BC00073_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00073_n60estatusarticulofecultact = new bool[] {false} ;
         sMode7 = "";
         BC00072_A12estatusarticuloid = new long[1] ;
         BC00072_A54estatusarticulodsc = new String[] {""} ;
         BC00072_n54estatusarticulodsc = new bool[] {false} ;
         BC00072_A55estatusarticulodescuso = new String[] {""} ;
         BC00072_n55estatusarticulodescuso = new bool[] {false} ;
         BC00072_A56estatusarticuloaplicamov = new int[1] ;
         BC00072_n56estatusarticuloaplicamov = new bool[] {false} ;
         BC00072_A57estatusarticulousotabla = new String[] {""} ;
         BC00072_n57estatusarticulousotabla = new bool[] {false} ;
         BC00072_A58estatusarticulousuario = new String[] {""} ;
         BC00072_n58estatusarticulousuario = new bool[] {false} ;
         BC00072_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00072_n59estatusarticulofecreg = new bool[] {false} ;
         BC00072_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00072_n60estatusarticulofecultact = new bool[] {false} ;
         BC00079_A12estatusarticuloid = new long[1] ;
         BC00079_A54estatusarticulodsc = new String[] {""} ;
         BC00079_n54estatusarticulodsc = new bool[] {false} ;
         BC00079_A55estatusarticulodescuso = new String[] {""} ;
         BC00079_n55estatusarticulodescuso = new bool[] {false} ;
         BC00079_A56estatusarticuloaplicamov = new int[1] ;
         BC00079_n56estatusarticuloaplicamov = new bool[] {false} ;
         BC00079_A57estatusarticulousotabla = new String[] {""} ;
         BC00079_n57estatusarticulousotabla = new bool[] {false} ;
         BC00079_A58estatusarticulousuario = new String[] {""} ;
         BC00079_n58estatusarticulousuario = new bool[] {false} ;
         BC00079_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00079_n59estatusarticulofecreg = new bool[] {false} ;
         BC00079_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00079_n60estatusarticulofecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estatusarticulo_bc__default(),
            new Object[][] {
                new Object[] {
               BC00072_A12estatusarticuloid, BC00072_A54estatusarticulodsc, BC00072_n54estatusarticulodsc, BC00072_A55estatusarticulodescuso, BC00072_n55estatusarticulodescuso, BC00072_A56estatusarticuloaplicamov, BC00072_n56estatusarticuloaplicamov, BC00072_A57estatusarticulousotabla, BC00072_n57estatusarticulousotabla, BC00072_A58estatusarticulousuario,
               BC00072_n58estatusarticulousuario, BC00072_A59estatusarticulofecreg, BC00072_n59estatusarticulofecreg, BC00072_A60estatusarticulofecultact, BC00072_n60estatusarticulofecultact
               }
               , new Object[] {
               BC00073_A12estatusarticuloid, BC00073_A54estatusarticulodsc, BC00073_n54estatusarticulodsc, BC00073_A55estatusarticulodescuso, BC00073_n55estatusarticulodescuso, BC00073_A56estatusarticuloaplicamov, BC00073_n56estatusarticuloaplicamov, BC00073_A57estatusarticulousotabla, BC00073_n57estatusarticulousotabla, BC00073_A58estatusarticulousuario,
               BC00073_n58estatusarticulousuario, BC00073_A59estatusarticulofecreg, BC00073_n59estatusarticulofecreg, BC00073_A60estatusarticulofecultact, BC00073_n60estatusarticulofecultact
               }
               , new Object[] {
               BC00074_A12estatusarticuloid, BC00074_A54estatusarticulodsc, BC00074_n54estatusarticulodsc, BC00074_A55estatusarticulodescuso, BC00074_n55estatusarticulodescuso, BC00074_A56estatusarticuloaplicamov, BC00074_n56estatusarticuloaplicamov, BC00074_A57estatusarticulousotabla, BC00074_n57estatusarticulousotabla, BC00074_A58estatusarticulousuario,
               BC00074_n58estatusarticulousuario, BC00074_A59estatusarticulofecreg, BC00074_n59estatusarticulofecreg, BC00074_A60estatusarticulofecultact, BC00074_n60estatusarticulofecultact
               }
               , new Object[] {
               BC00075_A12estatusarticuloid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00079_A12estatusarticuloid, BC00079_A54estatusarticulodsc, BC00079_n54estatusarticulodsc, BC00079_A55estatusarticulodescuso, BC00079_n55estatusarticulodescuso, BC00079_A56estatusarticuloaplicamov, BC00079_n56estatusarticuloaplicamov, BC00079_A57estatusarticulousotabla, BC00079_n57estatusarticulousotabla, BC00079_A58estatusarticulousuario,
               BC00079_n58estatusarticulousuario, BC00079_A59estatusarticulofecreg, BC00079_n59estatusarticulofecreg, BC00079_A60estatusarticulofecultact, BC00079_n60estatusarticulofecultact
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
      private short RcdFound7 ;
      private int trnEnded ;
      private int Z56estatusarticuloaplicamov ;
      private int A56estatusarticuloaplicamov ;
      private long Z12estatusarticuloid ;
      private long A12estatusarticuloid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode7 ;
      private DateTime Z59estatusarticulofecreg ;
      private DateTime A59estatusarticulofecreg ;
      private DateTime Z60estatusarticulofecultact ;
      private DateTime A60estatusarticulofecultact ;
      private bool n54estatusarticulodsc ;
      private bool n55estatusarticulodescuso ;
      private bool n56estatusarticuloaplicamov ;
      private bool n57estatusarticulousotabla ;
      private bool n58estatusarticulousuario ;
      private bool n59estatusarticulofecreg ;
      private bool n60estatusarticulofecultact ;
      private bool Gx_longc ;
      private String Z54estatusarticulodsc ;
      private String A54estatusarticulodsc ;
      private String Z55estatusarticulodescuso ;
      private String A55estatusarticulodescuso ;
      private String Z57estatusarticulousotabla ;
      private String A57estatusarticulousotabla ;
      private String Z58estatusarticulousuario ;
      private String A58estatusarticulousuario ;
      private Sdtestatusarticulo bcestatusarticulo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00074_A12estatusarticuloid ;
      private String[] BC00074_A54estatusarticulodsc ;
      private bool[] BC00074_n54estatusarticulodsc ;
      private String[] BC00074_A55estatusarticulodescuso ;
      private bool[] BC00074_n55estatusarticulodescuso ;
      private int[] BC00074_A56estatusarticuloaplicamov ;
      private bool[] BC00074_n56estatusarticuloaplicamov ;
      private String[] BC00074_A57estatusarticulousotabla ;
      private bool[] BC00074_n57estatusarticulousotabla ;
      private String[] BC00074_A58estatusarticulousuario ;
      private bool[] BC00074_n58estatusarticulousuario ;
      private DateTime[] BC00074_A59estatusarticulofecreg ;
      private bool[] BC00074_n59estatusarticulofecreg ;
      private DateTime[] BC00074_A60estatusarticulofecultact ;
      private bool[] BC00074_n60estatusarticulofecultact ;
      private long[] BC00075_A12estatusarticuloid ;
      private long[] BC00073_A12estatusarticuloid ;
      private String[] BC00073_A54estatusarticulodsc ;
      private bool[] BC00073_n54estatusarticulodsc ;
      private String[] BC00073_A55estatusarticulodescuso ;
      private bool[] BC00073_n55estatusarticulodescuso ;
      private int[] BC00073_A56estatusarticuloaplicamov ;
      private bool[] BC00073_n56estatusarticuloaplicamov ;
      private String[] BC00073_A57estatusarticulousotabla ;
      private bool[] BC00073_n57estatusarticulousotabla ;
      private String[] BC00073_A58estatusarticulousuario ;
      private bool[] BC00073_n58estatusarticulousuario ;
      private DateTime[] BC00073_A59estatusarticulofecreg ;
      private bool[] BC00073_n59estatusarticulofecreg ;
      private DateTime[] BC00073_A60estatusarticulofecultact ;
      private bool[] BC00073_n60estatusarticulofecultact ;
      private long[] BC00072_A12estatusarticuloid ;
      private String[] BC00072_A54estatusarticulodsc ;
      private bool[] BC00072_n54estatusarticulodsc ;
      private String[] BC00072_A55estatusarticulodescuso ;
      private bool[] BC00072_n55estatusarticulodescuso ;
      private int[] BC00072_A56estatusarticuloaplicamov ;
      private bool[] BC00072_n56estatusarticuloaplicamov ;
      private String[] BC00072_A57estatusarticulousotabla ;
      private bool[] BC00072_n57estatusarticulousotabla ;
      private String[] BC00072_A58estatusarticulousuario ;
      private bool[] BC00072_n58estatusarticulousuario ;
      private DateTime[] BC00072_A59estatusarticulofecreg ;
      private bool[] BC00072_n59estatusarticulofecreg ;
      private DateTime[] BC00072_A60estatusarticulofecultact ;
      private bool[] BC00072_n60estatusarticulofecultact ;
      private long[] BC00079_A12estatusarticuloid ;
      private String[] BC00079_A54estatusarticulodsc ;
      private bool[] BC00079_n54estatusarticulodsc ;
      private String[] BC00079_A55estatusarticulodescuso ;
      private bool[] BC00079_n55estatusarticulodescuso ;
      private int[] BC00079_A56estatusarticuloaplicamov ;
      private bool[] BC00079_n56estatusarticuloaplicamov ;
      private String[] BC00079_A57estatusarticulousotabla ;
      private bool[] BC00079_n57estatusarticulousotabla ;
      private String[] BC00079_A58estatusarticulousuario ;
      private bool[] BC00079_n58estatusarticulousuario ;
      private DateTime[] BC00079_A59estatusarticulofecreg ;
      private bool[] BC00079_n59estatusarticulofecreg ;
      private DateTime[] BC00079_A60estatusarticulofecultact ;
      private bool[] BC00079_n60estatusarticulofecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class estatusarticulo_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00074 ;
          prmBC00074 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00075 ;
          prmBC00075 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00073 ;
          prmBC00073 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00072 ;
          prmBC00072 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00076 ;
          prmBC00076 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"estatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"estatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"estatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"estatusarticulofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticulofecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC00077 ;
          prmBC00077 = new Object[] {
          new Object[] {"estatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"estatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"estatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"estatusarticulofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticulofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00078 ;
          prmBC00078 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC00079 ;
          prmBC00079 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00072", "SELECT estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid  FOR UPDATE OF estatusarticulo",true, GxErrorMask.GX_NOMASK, false, this,prmBC00072,1,0,true,false )
             ,new CursorDef("BC00073", "SELECT estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00073,1,0,true,false )
             ,new CursorDef("BC00074", "SELECT TM1.estatusarticuloid, TM1.estatusarticulodsc, TM1.estatusarticulodescuso, TM1.estatusarticuloaplicamov, TM1.estatusarticulousotabla, TM1.estatusarticulousuario, TM1.estatusarticulofecreg, TM1.estatusarticulofecultact FROM public.estatusarticulo TM1 WHERE TM1.estatusarticuloid = :estatusarticuloid ORDER BY TM1.estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00074,100,0,true,false )
             ,new CursorDef("BC00075", "SELECT estatusarticuloid FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00075,1,0,true,false )
             ,new CursorDef("BC00076", "SAVEPOINT gxupdate;INSERT INTO public.estatusarticulo(estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact) VALUES(:estatusarticuloid, :estatusarticulodsc, :estatusarticulodescuso, :estatusarticuloaplicamov, :estatusarticulousotabla, :estatusarticulousuario, :estatusarticulofecreg, :estatusarticulofecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00076)
             ,new CursorDef("BC00077", "SAVEPOINT gxupdate;UPDATE public.estatusarticulo SET estatusarticulodsc=:estatusarticulodsc, estatusarticulodescuso=:estatusarticulodescuso, estatusarticuloaplicamov=:estatusarticuloaplicamov, estatusarticulousotabla=:estatusarticulousotabla, estatusarticulousuario=:estatusarticulousuario, estatusarticulofecreg=:estatusarticulofecreg, estatusarticulofecultact=:estatusarticulofecultact  WHERE estatusarticuloid = :estatusarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00077)
             ,new CursorDef("BC00078", "SAVEPOINT gxupdate;DELETE FROM public.estatusarticulo  WHERE estatusarticuloid = :estatusarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00078)
             ,new CursorDef("BC00079", "SELECT TM1.estatusarticuloid, TM1.estatusarticulodsc, TM1.estatusarticulodescuso, TM1.estatusarticuloaplicamov, TM1.estatusarticulousotabla, TM1.estatusarticulousuario, TM1.estatusarticulofecreg, TM1.estatusarticulofecultact FROM public.estatusarticulo TM1 WHERE TM1.estatusarticuloid = :estatusarticuloid ORDER BY TM1.estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00079,100,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
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
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[14]);
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
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
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
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[13]);
                }
                stmt.SetParameter(8, (long)parms[14]);
                return;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
