/*
               File: usuarios_BC
        Description: usuarios
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:4.94
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
   public class usuarios_bc : GXHttpHandler, IGxSilentTrn
   {
      public usuarios_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public usuarios_bc( IGxContext context )
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
         ReadRow0F15( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0F15( ) ;
         standaloneModal( ) ;
         AddRow0F15( ) ;
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
               Z9idusuario = A9idusuario;
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

      protected void CONFIRM_0F0( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0F15( ) ;
            }
            else
            {
               CheckExtendedTable0F15( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0F15( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0F15( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z173usuario = A173usuario;
            Z174contrasena = A174contrasena;
         }
         if ( GX_JID == -1 )
         {
            Z9idusuario = A9idusuario;
            Z173usuario = A173usuario;
            Z174contrasena = A174contrasena;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0F15( )
      {
         /* Using cursor BC000F4 */
         pr_default.execute(2, new Object[] {A9idusuario});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound15 = 1;
            A173usuario = BC000F4_A173usuario[0];
            n173usuario = BC000F4_n173usuario[0];
            A174contrasena = BC000F4_A174contrasena[0];
            n174contrasena = BC000F4_n174contrasena[0];
            ZM0F15( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0F15( ) ;
      }

      protected void OnLoadActions0F15( )
      {
      }

      protected void CheckExtendedTable0F15( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0F15( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0F15( )
      {
         /* Using cursor BC000F5 */
         pr_default.execute(3, new Object[] {A9idusuario});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000F3 */
         pr_default.execute(1, new Object[] {A9idusuario});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0F15( 1) ;
            RcdFound15 = 1;
            A9idusuario = BC000F3_A9idusuario[0];
            A173usuario = BC000F3_A173usuario[0];
            n173usuario = BC000F3_n173usuario[0];
            A174contrasena = BC000F3_A174contrasena[0];
            n174contrasena = BC000F3_n174contrasena[0];
            Z9idusuario = A9idusuario;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0F15( ) ;
            if ( AnyError == 1 )
            {
               RcdFound15 = 0;
               InitializeNonKey0F15( ) ;
            }
            Gx_mode = sMode15;
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0F15( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode15;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0F15( ) ;
         if ( RcdFound15 == 0 )
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
         CONFIRM_0F0( ) ;
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

      protected void CheckOptimisticConcurrency0F15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000F2 */
            pr_default.execute(0, new Object[] {A9idusuario});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"USUARIOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z173usuario, BC000F2_A173usuario[0]) != 0 ) || ( StringUtil.StrCmp(Z174contrasena, BC000F2_A174contrasena[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"USUARIOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0F15( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F15( 0) ;
            CheckOptimisticConcurrency0F15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000F6 */
                     pr_default.execute(4, new Object[] {A9idusuario, n173usuario, A173usuario, n174contrasena, A174contrasena});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("USUARIOS") ;
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
               Load0F15( ) ;
            }
            EndLevel0F15( ) ;
         }
         CloseExtendedTableCursors0F15( ) ;
      }

      protected void Update0F15( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000F7 */
                     pr_default.execute(5, new Object[] {n173usuario, A173usuario, n174contrasena, A174contrasena, A9idusuario});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("USUARIOS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"USUARIOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0F15( ) ;
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
            EndLevel0F15( ) ;
         }
         CloseExtendedTableCursors0F15( ) ;
      }

      protected void DeferredUpdate0F15( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F15( ) ;
            AfterConfirm0F15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000F8 */
                  pr_default.execute(6, new Object[] {A9idusuario});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("USUARIOS") ;
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
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0F15( ) ;
         Gx_mode = sMode15;
      }

      protected void OnDeleteControls0F15( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0F15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0F15( ) ;
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

      public void ScanKeyStart0F15( )
      {
         /* Using cursor BC000F9 */
         pr_default.execute(7, new Object[] {A9idusuario});
         RcdFound15 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound15 = 1;
            A9idusuario = BC000F9_A9idusuario[0];
            A173usuario = BC000F9_A173usuario[0];
            n173usuario = BC000F9_n173usuario[0];
            A174contrasena = BC000F9_A174contrasena[0];
            n174contrasena = BC000F9_n174contrasena[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0F15( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound15 = 0;
         ScanKeyLoad0F15( ) ;
      }

      protected void ScanKeyLoad0F15( )
      {
         sMode15 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound15 = 1;
            A9idusuario = BC000F9_A9idusuario[0];
            A173usuario = BC000F9_A173usuario[0];
            n173usuario = BC000F9_n173usuario[0];
            A174contrasena = BC000F9_A174contrasena[0];
            n174contrasena = BC000F9_n174contrasena[0];
         }
         Gx_mode = sMode15;
      }

      protected void ScanKeyEnd0F15( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0F15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F15( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F15( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F15( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F15( )
      {
      }

      protected void AddRow0F15( )
      {
         VarsToRow15( bcusuarios) ;
      }

      protected void ReadRow0F15( )
      {
         RowToVars15( bcusuarios, 1) ;
      }

      protected void InitializeNonKey0F15( )
      {
         A173usuario = "";
         n173usuario = false;
         A174contrasena = "";
         n174contrasena = false;
         Z173usuario = "";
         Z174contrasena = "";
      }

      protected void InitAll0F15( )
      {
         A9idusuario = 0;
         InitializeNonKey0F15( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow15( Sdtusuarios obj15 )
      {
         obj15.gxTpr_Mode = Gx_mode;
         obj15.gxTpr_Usuario = A173usuario;
         obj15.gxTpr_Contrasena = A174contrasena;
         obj15.gxTpr_Idusuario = A9idusuario;
         obj15.gxTpr_Idusuario_Z = Z9idusuario;
         obj15.gxTpr_Usuario_Z = Z173usuario;
         obj15.gxTpr_Contrasena_Z = Z174contrasena;
         obj15.gxTpr_Usuario_N = (short)(Convert.ToInt16(n173usuario));
         obj15.gxTpr_Contrasena_N = (short)(Convert.ToInt16(n174contrasena));
         obj15.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow15( Sdtusuarios obj15 )
      {
         obj15.gxTpr_Idusuario = A9idusuario;
         return  ;
      }

      public void RowToVars15( Sdtusuarios obj15 ,
                               int forceLoad )
      {
         Gx_mode = obj15.gxTpr_Mode;
         A173usuario = obj15.gxTpr_Usuario;
         n173usuario = false;
         A174contrasena = obj15.gxTpr_Contrasena;
         n174contrasena = false;
         A9idusuario = obj15.gxTpr_Idusuario;
         Z9idusuario = obj15.gxTpr_Idusuario_Z;
         Z173usuario = obj15.gxTpr_Usuario_Z;
         Z174contrasena = obj15.gxTpr_Contrasena_Z;
         n173usuario = (bool)(Convert.ToBoolean(obj15.gxTpr_Usuario_N));
         n174contrasena = (bool)(Convert.ToBoolean(obj15.gxTpr_Contrasena_N));
         Gx_mode = obj15.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A9idusuario = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0F15( ) ;
         ScanKeyStart0F15( ) ;
         if ( RcdFound15 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z9idusuario = A9idusuario;
         }
         ZM0F15( -1) ;
         OnLoadActions0F15( ) ;
         AddRow0F15( ) ;
         ScanKeyEnd0F15( ) ;
         if ( RcdFound15 == 0 )
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
         RowToVars15( bcusuarios, 0) ;
         ScanKeyStart0F15( ) ;
         if ( RcdFound15 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z9idusuario = A9idusuario;
         }
         ZM0F15( -1) ;
         OnLoadActions0F15( ) ;
         AddRow0F15( ) ;
         ScanKeyEnd0F15( ) ;
         if ( RcdFound15 == 0 )
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
         RowToVars15( bcusuarios, 0) ;
         nKeyPressed = 1;
         GetKey0F15( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0F15( ) ;
         }
         else
         {
            if ( RcdFound15 == 1 )
            {
               if ( A9idusuario != Z9idusuario )
               {
                  A9idusuario = Z9idusuario;
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
                  Update0F15( ) ;
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
                  if ( A9idusuario != Z9idusuario )
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
                        Insert0F15( ) ;
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
                        Insert0F15( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow15( bcusuarios) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars15( bcusuarios, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0F15( ) ;
         if ( RcdFound15 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A9idusuario != Z9idusuario )
            {
               A9idusuario = Z9idusuario;
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
            if ( A9idusuario != Z9idusuario )
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
         context.RollbackDataStores( "usuarios_BC");
         VarsToRow15( bcusuarios) ;
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
         Gx_mode = bcusuarios.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcusuarios.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcusuarios )
         {
            bcusuarios = (Sdtusuarios)(sdt);
            if ( StringUtil.StrCmp(bcusuarios.gxTpr_Mode, "") == 0 )
            {
               bcusuarios.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow15( bcusuarios) ;
            }
            else
            {
               RowToVars15( bcusuarios, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcusuarios.gxTpr_Mode, "") == 0 )
            {
               bcusuarios.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars15( bcusuarios, 1) ;
         return  ;
      }

      public Sdtusuarios usuarios_BC
      {
         get {
            return bcusuarios ;
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
         Z173usuario = "";
         A173usuario = "";
         Z174contrasena = "";
         A174contrasena = "";
         BC000F4_A9idusuario = new int[1] ;
         BC000F4_A173usuario = new String[] {""} ;
         BC000F4_n173usuario = new bool[] {false} ;
         BC000F4_A174contrasena = new String[] {""} ;
         BC000F4_n174contrasena = new bool[] {false} ;
         BC000F5_A9idusuario = new int[1] ;
         BC000F3_A9idusuario = new int[1] ;
         BC000F3_A173usuario = new String[] {""} ;
         BC000F3_n173usuario = new bool[] {false} ;
         BC000F3_A174contrasena = new String[] {""} ;
         BC000F3_n174contrasena = new bool[] {false} ;
         sMode15 = "";
         BC000F2_A9idusuario = new int[1] ;
         BC000F2_A173usuario = new String[] {""} ;
         BC000F2_n173usuario = new bool[] {false} ;
         BC000F2_A174contrasena = new String[] {""} ;
         BC000F2_n174contrasena = new bool[] {false} ;
         BC000F9_A9idusuario = new int[1] ;
         BC000F9_A173usuario = new String[] {""} ;
         BC000F9_n173usuario = new bool[] {false} ;
         BC000F9_A174contrasena = new String[] {""} ;
         BC000F9_n174contrasena = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarios_bc__default(),
            new Object[][] {
                new Object[] {
               BC000F2_A9idusuario, BC000F2_A173usuario, BC000F2_n173usuario, BC000F2_A174contrasena, BC000F2_n174contrasena
               }
               , new Object[] {
               BC000F3_A9idusuario, BC000F3_A173usuario, BC000F3_n173usuario, BC000F3_A174contrasena, BC000F3_n174contrasena
               }
               , new Object[] {
               BC000F4_A9idusuario, BC000F4_A173usuario, BC000F4_n173usuario, BC000F4_A174contrasena, BC000F4_n174contrasena
               }
               , new Object[] {
               BC000F5_A9idusuario
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000F9_A9idusuario, BC000F9_A173usuario, BC000F9_n173usuario, BC000F9_A174contrasena, BC000F9_n174contrasena
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
      private short RcdFound15 ;
      private int trnEnded ;
      private int Z9idusuario ;
      private int A9idusuario ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode15 ;
      private bool n173usuario ;
      private bool n174contrasena ;
      private String Z173usuario ;
      private String A173usuario ;
      private String Z174contrasena ;
      private String A174contrasena ;
      private Sdtusuarios bcusuarios ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000F4_A9idusuario ;
      private String[] BC000F4_A173usuario ;
      private bool[] BC000F4_n173usuario ;
      private String[] BC000F4_A174contrasena ;
      private bool[] BC000F4_n174contrasena ;
      private int[] BC000F5_A9idusuario ;
      private int[] BC000F3_A9idusuario ;
      private String[] BC000F3_A173usuario ;
      private bool[] BC000F3_n173usuario ;
      private String[] BC000F3_A174contrasena ;
      private bool[] BC000F3_n174contrasena ;
      private int[] BC000F2_A9idusuario ;
      private String[] BC000F2_A173usuario ;
      private bool[] BC000F2_n173usuario ;
      private String[] BC000F2_A174contrasena ;
      private bool[] BC000F2_n174contrasena ;
      private int[] BC000F9_A9idusuario ;
      private String[] BC000F9_A173usuario ;
      private bool[] BC000F9_n173usuario ;
      private String[] BC000F9_A174contrasena ;
      private bool[] BC000F9_n174contrasena ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class usuarios_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000F4 ;
          prmBC000F4 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F5 ;
          prmBC000F5 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F3 ;
          prmBC000F3 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F2 ;
          prmBC000F2 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F6 ;
          prmBC000F6 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"usuario",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"contrasena",NpgsqlDbType.Varchar,10,0}
          } ;
          Object[] prmBC000F7 ;
          prmBC000F7 = new Object[] {
          new Object[] {"usuario",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"contrasena",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F8 ;
          prmBC000F8 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000F9 ;
          prmBC000F9 = new Object[] {
          new Object[] {"idusuario",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000F2", "SELECT idusuario, usuario, contrasena FROM public.usuarios WHERE idusuario = :idusuario  FOR UPDATE OF usuarios",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F2,1,0,true,false )
             ,new CursorDef("BC000F3", "SELECT idusuario, usuario, contrasena FROM public.usuarios WHERE idusuario = :idusuario ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F3,1,0,true,false )
             ,new CursorDef("BC000F4", "SELECT TM1.idusuario, TM1.usuario, TM1.contrasena FROM public.usuarios TM1 WHERE TM1.idusuario = :idusuario ORDER BY TM1.idusuario ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F4,100,0,true,false )
             ,new CursorDef("BC000F5", "SELECT idusuario FROM public.usuarios WHERE idusuario = :idusuario ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F5,1,0,true,false )
             ,new CursorDef("BC000F6", "SAVEPOINT gxupdate;INSERT INTO public.usuarios(idusuario, usuario, contrasena) VALUES(:idusuario, :usuario, :contrasena);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000F6)
             ,new CursorDef("BC000F7", "SAVEPOINT gxupdate;UPDATE public.usuarios SET usuario=:usuario, contrasena=:contrasena  WHERE idusuario = :idusuario;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000F7)
             ,new CursorDef("BC000F8", "SAVEPOINT gxupdate;DELETE FROM public.usuarios  WHERE idusuario = :idusuario;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000F8)
             ,new CursorDef("BC000F9", "SELECT TM1.idusuario, TM1.usuario, TM1.contrasena FROM public.usuarios TM1 WHERE TM1.idusuario = :idusuario ORDER BY TM1.idusuario ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F9,100,0,true,false )
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
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                stmt.SetParameter(3, (int)parms[4]);
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
