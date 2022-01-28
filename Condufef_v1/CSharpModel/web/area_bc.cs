/*
               File: area_BC
        Description: area
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/28/2022 13:13:22.22
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
   public class area_bc : GXHttpHandler, IGxSilentTrn
   {
      public area_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public area_bc( IGxContext context )
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
         ReadRow0H17( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0H17( ) ;
         standaloneModal( ) ;
         AddRow0H17( ) ;
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
               Z22areaareaid = A22areaareaid;
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H17( ) ;
            }
            else
            {
               CheckExtendedTable0H17( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0H17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0H17( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z27areadsc = A27areadsc;
            Z28areastatusadsc = A28areastatusadsc;
            Z29areausuario = A29areausuario;
            Z30areafecreg = A30areafecreg;
            Z31areafecultact = A31areafecultact;
         }
         if ( GX_JID == -1 )
         {
            Z22areaareaid = A22areaareaid;
            Z27areadsc = A27areadsc;
            Z28areastatusadsc = A28areastatusadsc;
            Z29areausuario = A29areausuario;
            Z30areafecreg = A30areafecreg;
            Z31areafecultact = A31areafecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0H17( )
      {
         /* Using cursor BC000H4 */
         pr_default.execute(2, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound17 = 1;
            A27areadsc = BC000H4_A27areadsc[0];
            n27areadsc = BC000H4_n27areadsc[0];
            A28areastatusadsc = BC000H4_A28areastatusadsc[0];
            n28areastatusadsc = BC000H4_n28areastatusadsc[0];
            A29areausuario = BC000H4_A29areausuario[0];
            n29areausuario = BC000H4_n29areausuario[0];
            A30areafecreg = BC000H4_A30areafecreg[0];
            n30areafecreg = BC000H4_n30areafecreg[0];
            A31areafecultact = BC000H4_A31areafecultact[0];
            n31areafecultact = BC000H4_n31areafecultact[0];
            ZM0H17( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0H17( ) ;
      }

      protected void OnLoadActions0H17( )
      {
      }

      protected void CheckExtendedTable0H17( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0H17( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0H17( )
      {
         /* Using cursor BC000H5 */
         pr_default.execute(3, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000H3 */
         pr_default.execute(1, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H17( 1) ;
            RcdFound17 = 1;
            A22areaareaid = BC000H3_A22areaareaid[0];
            A27areadsc = BC000H3_A27areadsc[0];
            n27areadsc = BC000H3_n27areadsc[0];
            A28areastatusadsc = BC000H3_A28areastatusadsc[0];
            n28areastatusadsc = BC000H3_n28areastatusadsc[0];
            A29areausuario = BC000H3_A29areausuario[0];
            n29areausuario = BC000H3_n29areausuario[0];
            A30areafecreg = BC000H3_A30areafecreg[0];
            n30areafecreg = BC000H3_n30areafecreg[0];
            A31areafecultact = BC000H3_A31areafecultact[0];
            n31areafecultact = BC000H3_n31areafecultact[0];
            Z22areaareaid = A22areaareaid;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0H17( ) ;
            if ( AnyError == 1 )
            {
               RcdFound17 = 0;
               InitializeNonKey0H17( ) ;
            }
            Gx_mode = sMode17;
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0H17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode17;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H17( ) ;
         if ( RcdFound17 == 0 )
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
         CONFIRM_0H0( ) ;
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

      protected void CheckOptimisticConcurrency0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000H2 */
            pr_default.execute(0, new Object[] {A22areaareaid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AREA"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z27areadsc, BC000H2_A27areadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z28areastatusadsc, BC000H2_A28areastatusadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z29areausuario, BC000H2_A29areausuario[0]) != 0 ) || ( Z30areafecreg != BC000H2_A30areafecreg[0] ) || ( Z31areafecultact != BC000H2_A31areafecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AREA"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H17( 0) ;
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000H6 */
                     pr_default.execute(4, new Object[] {A22areaareaid, n27areadsc, A27areadsc, n28areastatusadsc, A28areastatusadsc, n29areausuario, A29areausuario, n30areafecreg, A30areafecreg, n31areafecultact, A31areafecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
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
               Load0H17( ) ;
            }
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void Update0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000H7 */
                     pr_default.execute(5, new Object[] {n27areadsc, A27areadsc, n28areastatusadsc, A28areastatusadsc, n29areausuario, A29areausuario, n30areafecreg, A30areafecreg, n31areafecultact, A31areafecultact, A22areaareaid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AREA"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H17( ) ;
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
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void DeferredUpdate0H17( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H17( ) ;
            AfterConfirm0H17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000H8 */
                  pr_default.execute(6, new Object[] {A22areaareaid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0H17( ) ;
         Gx_mode = sMode17;
      }

      protected void OnDeleteControls0H17( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0H17( ) ;
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

      public void ScanKeyStart0H17( )
      {
         /* Using cursor BC000H9 */
         pr_default.execute(7, new Object[] {A22areaareaid});
         RcdFound17 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound17 = 1;
            A22areaareaid = BC000H9_A22areaareaid[0];
            A27areadsc = BC000H9_A27areadsc[0];
            n27areadsc = BC000H9_n27areadsc[0];
            A28areastatusadsc = BC000H9_A28areastatusadsc[0];
            n28areastatusadsc = BC000H9_n28areastatusadsc[0];
            A29areausuario = BC000H9_A29areausuario[0];
            n29areausuario = BC000H9_n29areausuario[0];
            A30areafecreg = BC000H9_A30areafecreg[0];
            n30areafecreg = BC000H9_n30areafecreg[0];
            A31areafecultact = BC000H9_A31areafecultact[0];
            n31areafecultact = BC000H9_n31areafecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0H17( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound17 = 0;
         ScanKeyLoad0H17( ) ;
      }

      protected void ScanKeyLoad0H17( )
      {
         sMode17 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound17 = 1;
            A22areaareaid = BC000H9_A22areaareaid[0];
            A27areadsc = BC000H9_A27areadsc[0];
            n27areadsc = BC000H9_n27areadsc[0];
            A28areastatusadsc = BC000H9_A28areastatusadsc[0];
            n28areastatusadsc = BC000H9_n28areastatusadsc[0];
            A29areausuario = BC000H9_A29areausuario[0];
            n29areausuario = BC000H9_n29areausuario[0];
            A30areafecreg = BC000H9_A30areafecreg[0];
            n30areafecreg = BC000H9_n30areafecreg[0];
            A31areafecultact = BC000H9_A31areafecultact[0];
            n31areafecultact = BC000H9_n31areafecultact[0];
         }
         Gx_mode = sMode17;
      }

      protected void ScanKeyEnd0H17( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0H17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H17( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H17( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H17( )
      {
      }

      protected void AddRow0H17( )
      {
         VarsToRow17( bcarea) ;
      }

      protected void ReadRow0H17( )
      {
         RowToVars17( bcarea, 1) ;
      }

      protected void InitializeNonKey0H17( )
      {
         A27areadsc = "";
         n27areadsc = false;
         A28areastatusadsc = "";
         n28areastatusadsc = false;
         A29areausuario = "";
         n29areausuario = false;
         A30areafecreg = (DateTime)(DateTime.MinValue);
         n30areafecreg = false;
         A31areafecultact = (DateTime)(DateTime.MinValue);
         n31areafecultact = false;
         Z27areadsc = "";
         Z28areastatusadsc = "";
         Z29areausuario = "";
         Z30areafecreg = (DateTime)(DateTime.MinValue);
         Z31areafecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0H17( )
      {
         A22areaareaid = 0;
         InitializeNonKey0H17( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow17( Sdtarea obj17 )
      {
         obj17.gxTpr_Mode = Gx_mode;
         obj17.gxTpr_Areadsc = A27areadsc;
         obj17.gxTpr_Areastatusadsc = A28areastatusadsc;
         obj17.gxTpr_Areausuario = A29areausuario;
         obj17.gxTpr_Areafecreg = A30areafecreg;
         obj17.gxTpr_Areafecultact = A31areafecultact;
         obj17.gxTpr_Areaareaid = A22areaareaid;
         obj17.gxTpr_Areaareaid_Z = Z22areaareaid;
         obj17.gxTpr_Areadsc_Z = Z27areadsc;
         obj17.gxTpr_Areastatusadsc_Z = Z28areastatusadsc;
         obj17.gxTpr_Areausuario_Z = Z29areausuario;
         obj17.gxTpr_Areafecreg_Z = Z30areafecreg;
         obj17.gxTpr_Areafecultact_Z = Z31areafecultact;
         obj17.gxTpr_Areadsc_N = (short)(Convert.ToInt16(n27areadsc));
         obj17.gxTpr_Areastatusadsc_N = (short)(Convert.ToInt16(n28areastatusadsc));
         obj17.gxTpr_Areausuario_N = (short)(Convert.ToInt16(n29areausuario));
         obj17.gxTpr_Areafecreg_N = (short)(Convert.ToInt16(n30areafecreg));
         obj17.gxTpr_Areafecultact_N = (short)(Convert.ToInt16(n31areafecultact));
         obj17.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow17( Sdtarea obj17 )
      {
         obj17.gxTpr_Areaareaid = A22areaareaid;
         return  ;
      }

      public void RowToVars17( Sdtarea obj17 ,
                               int forceLoad )
      {
         Gx_mode = obj17.gxTpr_Mode;
         A27areadsc = obj17.gxTpr_Areadsc;
         n27areadsc = false;
         A28areastatusadsc = obj17.gxTpr_Areastatusadsc;
         n28areastatusadsc = false;
         A29areausuario = obj17.gxTpr_Areausuario;
         n29areausuario = false;
         A30areafecreg = obj17.gxTpr_Areafecreg;
         n30areafecreg = false;
         A31areafecultact = obj17.gxTpr_Areafecultact;
         n31areafecultact = false;
         A22areaareaid = obj17.gxTpr_Areaareaid;
         Z22areaareaid = obj17.gxTpr_Areaareaid_Z;
         Z27areadsc = obj17.gxTpr_Areadsc_Z;
         Z28areastatusadsc = obj17.gxTpr_Areastatusadsc_Z;
         Z29areausuario = obj17.gxTpr_Areausuario_Z;
         Z30areafecreg = obj17.gxTpr_Areafecreg_Z;
         Z31areafecultact = obj17.gxTpr_Areafecultact_Z;
         n27areadsc = (bool)(Convert.ToBoolean(obj17.gxTpr_Areadsc_N));
         n28areastatusadsc = (bool)(Convert.ToBoolean(obj17.gxTpr_Areastatusadsc_N));
         n29areausuario = (bool)(Convert.ToBoolean(obj17.gxTpr_Areausuario_N));
         n30areafecreg = (bool)(Convert.ToBoolean(obj17.gxTpr_Areafecreg_N));
         n31areafecultact = (bool)(Convert.ToBoolean(obj17.gxTpr_Areafecultact_N));
         Gx_mode = obj17.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A22areaareaid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0H17( ) ;
         ScanKeyStart0H17( ) ;
         if ( RcdFound17 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z22areaareaid = A22areaareaid;
         }
         ZM0H17( -1) ;
         OnLoadActions0H17( ) ;
         AddRow0H17( ) ;
         ScanKeyEnd0H17( ) ;
         if ( RcdFound17 == 0 )
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
         RowToVars17( bcarea, 0) ;
         ScanKeyStart0H17( ) ;
         if ( RcdFound17 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z22areaareaid = A22areaareaid;
         }
         ZM0H17( -1) ;
         OnLoadActions0H17( ) ;
         AddRow0H17( ) ;
         ScanKeyEnd0H17( ) ;
         if ( RcdFound17 == 0 )
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
         RowToVars17( bcarea, 0) ;
         nKeyPressed = 1;
         GetKey0H17( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0H17( ) ;
         }
         else
         {
            if ( RcdFound17 == 1 )
            {
               if ( A22areaareaid != Z22areaareaid )
               {
                  A22areaareaid = Z22areaareaid;
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
                  Update0H17( ) ;
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
                  if ( A22areaareaid != Z22areaareaid )
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
                        Insert0H17( ) ;
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
                        Insert0H17( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow17( bcarea) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars17( bcarea, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0H17( ) ;
         if ( RcdFound17 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A22areaareaid != Z22areaareaid )
            {
               A22areaareaid = Z22areaareaid;
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
            if ( A22areaareaid != Z22areaareaid )
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
         context.RollbackDataStores( "area_BC");
         VarsToRow17( bcarea) ;
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
         Gx_mode = bcarea.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcarea.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcarea )
         {
            bcarea = (Sdtarea)(sdt);
            if ( StringUtil.StrCmp(bcarea.gxTpr_Mode, "") == 0 )
            {
               bcarea.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow17( bcarea) ;
            }
            else
            {
               RowToVars17( bcarea, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcarea.gxTpr_Mode, "") == 0 )
            {
               bcarea.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars17( bcarea, 1) ;
         return  ;
      }

      public Sdtarea area_BC
      {
         get {
            return bcarea ;
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
         Z27areadsc = "";
         A27areadsc = "";
         Z28areastatusadsc = "";
         A28areastatusadsc = "";
         Z29areausuario = "";
         A29areausuario = "";
         Z30areafecreg = (DateTime)(DateTime.MinValue);
         A30areafecreg = (DateTime)(DateTime.MinValue);
         Z31areafecultact = (DateTime)(DateTime.MinValue);
         A31areafecultact = (DateTime)(DateTime.MinValue);
         BC000H4_A22areaareaid = new int[1] ;
         BC000H4_A27areadsc = new String[] {""} ;
         BC000H4_n27areadsc = new bool[] {false} ;
         BC000H4_A28areastatusadsc = new String[] {""} ;
         BC000H4_n28areastatusadsc = new bool[] {false} ;
         BC000H4_A29areausuario = new String[] {""} ;
         BC000H4_n29areausuario = new bool[] {false} ;
         BC000H4_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         BC000H4_n30areafecreg = new bool[] {false} ;
         BC000H4_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         BC000H4_n31areafecultact = new bool[] {false} ;
         BC000H5_A22areaareaid = new int[1] ;
         BC000H3_A22areaareaid = new int[1] ;
         BC000H3_A27areadsc = new String[] {""} ;
         BC000H3_n27areadsc = new bool[] {false} ;
         BC000H3_A28areastatusadsc = new String[] {""} ;
         BC000H3_n28areastatusadsc = new bool[] {false} ;
         BC000H3_A29areausuario = new String[] {""} ;
         BC000H3_n29areausuario = new bool[] {false} ;
         BC000H3_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         BC000H3_n30areafecreg = new bool[] {false} ;
         BC000H3_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         BC000H3_n31areafecultact = new bool[] {false} ;
         sMode17 = "";
         BC000H2_A22areaareaid = new int[1] ;
         BC000H2_A27areadsc = new String[] {""} ;
         BC000H2_n27areadsc = new bool[] {false} ;
         BC000H2_A28areastatusadsc = new String[] {""} ;
         BC000H2_n28areastatusadsc = new bool[] {false} ;
         BC000H2_A29areausuario = new String[] {""} ;
         BC000H2_n29areausuario = new bool[] {false} ;
         BC000H2_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         BC000H2_n30areafecreg = new bool[] {false} ;
         BC000H2_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         BC000H2_n31areafecultact = new bool[] {false} ;
         BC000H9_A22areaareaid = new int[1] ;
         BC000H9_A27areadsc = new String[] {""} ;
         BC000H9_n27areadsc = new bool[] {false} ;
         BC000H9_A28areastatusadsc = new String[] {""} ;
         BC000H9_n28areastatusadsc = new bool[] {false} ;
         BC000H9_A29areausuario = new String[] {""} ;
         BC000H9_n29areausuario = new bool[] {false} ;
         BC000H9_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         BC000H9_n30areafecreg = new bool[] {false} ;
         BC000H9_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         BC000H9_n31areafecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.area_bc__default(),
            new Object[][] {
                new Object[] {
               BC000H2_A22areaareaid, BC000H2_A27areadsc, BC000H2_n27areadsc, BC000H2_A28areastatusadsc, BC000H2_n28areastatusadsc, BC000H2_A29areausuario, BC000H2_n29areausuario, BC000H2_A30areafecreg, BC000H2_n30areafecreg, BC000H2_A31areafecultact,
               BC000H2_n31areafecultact
               }
               , new Object[] {
               BC000H3_A22areaareaid, BC000H3_A27areadsc, BC000H3_n27areadsc, BC000H3_A28areastatusadsc, BC000H3_n28areastatusadsc, BC000H3_A29areausuario, BC000H3_n29areausuario, BC000H3_A30areafecreg, BC000H3_n30areafecreg, BC000H3_A31areafecultact,
               BC000H3_n31areafecultact
               }
               , new Object[] {
               BC000H4_A22areaareaid, BC000H4_A27areadsc, BC000H4_n27areadsc, BC000H4_A28areastatusadsc, BC000H4_n28areastatusadsc, BC000H4_A29areausuario, BC000H4_n29areausuario, BC000H4_A30areafecreg, BC000H4_n30areafecreg, BC000H4_A31areafecultact,
               BC000H4_n31areafecultact
               }
               , new Object[] {
               BC000H5_A22areaareaid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000H9_A22areaareaid, BC000H9_A27areadsc, BC000H9_n27areadsc, BC000H9_A28areastatusadsc, BC000H9_n28areastatusadsc, BC000H9_A29areausuario, BC000H9_n29areausuario, BC000H9_A30areafecreg, BC000H9_n30areafecreg, BC000H9_A31areafecultact,
               BC000H9_n31areafecultact
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
      private short RcdFound17 ;
      private int trnEnded ;
      private int Z22areaareaid ;
      private int A22areaareaid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode17 ;
      private DateTime Z30areafecreg ;
      private DateTime A30areafecreg ;
      private DateTime Z31areafecultact ;
      private DateTime A31areafecultact ;
      private bool n27areadsc ;
      private bool n28areastatusadsc ;
      private bool n29areausuario ;
      private bool n30areafecreg ;
      private bool n31areafecultact ;
      private String Z27areadsc ;
      private String A27areadsc ;
      private String Z28areastatusadsc ;
      private String A28areastatusadsc ;
      private String Z29areausuario ;
      private String A29areausuario ;
      private Sdtarea bcarea ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000H4_A22areaareaid ;
      private String[] BC000H4_A27areadsc ;
      private bool[] BC000H4_n27areadsc ;
      private String[] BC000H4_A28areastatusadsc ;
      private bool[] BC000H4_n28areastatusadsc ;
      private String[] BC000H4_A29areausuario ;
      private bool[] BC000H4_n29areausuario ;
      private DateTime[] BC000H4_A30areafecreg ;
      private bool[] BC000H4_n30areafecreg ;
      private DateTime[] BC000H4_A31areafecultact ;
      private bool[] BC000H4_n31areafecultact ;
      private int[] BC000H5_A22areaareaid ;
      private int[] BC000H3_A22areaareaid ;
      private String[] BC000H3_A27areadsc ;
      private bool[] BC000H3_n27areadsc ;
      private String[] BC000H3_A28areastatusadsc ;
      private bool[] BC000H3_n28areastatusadsc ;
      private String[] BC000H3_A29areausuario ;
      private bool[] BC000H3_n29areausuario ;
      private DateTime[] BC000H3_A30areafecreg ;
      private bool[] BC000H3_n30areafecreg ;
      private DateTime[] BC000H3_A31areafecultact ;
      private bool[] BC000H3_n31areafecultact ;
      private int[] BC000H2_A22areaareaid ;
      private String[] BC000H2_A27areadsc ;
      private bool[] BC000H2_n27areadsc ;
      private String[] BC000H2_A28areastatusadsc ;
      private bool[] BC000H2_n28areastatusadsc ;
      private String[] BC000H2_A29areausuario ;
      private bool[] BC000H2_n29areausuario ;
      private DateTime[] BC000H2_A30areafecreg ;
      private bool[] BC000H2_n30areafecreg ;
      private DateTime[] BC000H2_A31areafecultact ;
      private bool[] BC000H2_n31areafecultact ;
      private int[] BC000H9_A22areaareaid ;
      private String[] BC000H9_A27areadsc ;
      private bool[] BC000H9_n27areadsc ;
      private String[] BC000H9_A28areastatusadsc ;
      private bool[] BC000H9_n28areastatusadsc ;
      private String[] BC000H9_A29areausuario ;
      private bool[] BC000H9_n29areausuario ;
      private DateTime[] BC000H9_A30areafecreg ;
      private bool[] BC000H9_n30areafecreg ;
      private DateTime[] BC000H9_A31areafecultact ;
      private bool[] BC000H9_n31areafecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class area_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000H4 ;
          prmBC000H4 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H5 ;
          prmBC000H5 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H3 ;
          prmBC000H3 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H2 ;
          prmBC000H2 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H6 ;
          prmBC000H6 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"areadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"areafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areafecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000H7 ;
          prmBC000H7 = new Object[] {
          new Object[] {"areadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"areafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areafecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H8 ;
          prmBC000H8 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000H9 ;
          prmBC000H9 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000H2", "SELECT areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact FROM public.area WHERE areaid = :areaareaid  FOR UPDATE OF area",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H2,1,0,true,false )
             ,new CursorDef("BC000H3", "SELECT areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact FROM public.area WHERE areaid = :areaareaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H3,1,0,true,false )
             ,new CursorDef("BC000H4", "SELECT TM1.areaid, TM1.areadsc, TM1.areastatusadsc, TM1.areausuario, TM1.areafecreg, TM1.areafecultact FROM public.area TM1 WHERE TM1.areaid = :areaareaid ORDER BY TM1.areaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H4,100,0,true,false )
             ,new CursorDef("BC000H5", "SELECT areaid FROM public.area WHERE areaid = :areaareaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H5,1,0,true,false )
             ,new CursorDef("BC000H6", "SAVEPOINT gxupdate;INSERT INTO public.area(areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact) VALUES(:areaareaid, :areadsc, :areastatusadsc, :areausuario, :areafecreg, :areafecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000H6)
             ,new CursorDef("BC000H7", "SAVEPOINT gxupdate;UPDATE public.area SET areadsc=:areadsc, areastatusadsc=:areastatusadsc, areausuario=:areausuario, areafecreg=:areafecreg, areafecultact=:areafecultact  WHERE areaid = :areaareaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000H7)
             ,new CursorDef("BC000H8", "SAVEPOINT gxupdate;DELETE FROM public.area  WHERE areaid = :areaareaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000H8)
             ,new CursorDef("BC000H9", "SELECT TM1.areaid, TM1.areadsc, TM1.areastatusadsc, TM1.areausuario, TM1.areafecreg, TM1.areafecultact FROM public.area TM1 WHERE TM1.areaid = :areaareaid ORDER BY TM1.areaid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H9,100,0,true,false )
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
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[10]);
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
                stmt.SetParameter(6, (int)parms[10]);
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
