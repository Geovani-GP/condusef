/*
               File: status_BC
        Description: status
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:0:42.5
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
   public class status_bc : GXHttpHandler, IGxSilentTrn
   {
      public status_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public status_bc( IGxContext context )
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
         ReadRow0L21( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0L21( ) ;
         standaloneModal( ) ;
         AddRow0L21( ) ;
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
               Z1statusid = A1statusid;
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

      protected void CONFIRM_0L0( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0L21( ) ;
            }
            else
            {
               CheckExtendedTable0L21( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0L21( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0L21( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z73statusdsc = A73statusdsc;
            Z74statususotabla = A74statususotabla;
            Z75statusdesc = A75statusdesc;
            Z76statususuario = A76statususuario;
            Z77statusfecreg = A77statusfecreg;
            Z78statusfecultact = A78statusfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z1statusid = A1statusid;
            Z73statusdsc = A73statusdsc;
            Z74statususotabla = A74statususotabla;
            Z75statusdesc = A75statusdesc;
            Z76statususuario = A76statususuario;
            Z77statusfecreg = A77statusfecreg;
            Z78statusfecultact = A78statusfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0L21( )
      {
         /* Using cursor BC000L4 */
         pr_default.execute(2, new Object[] {A1statusid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound21 = 1;
            A73statusdsc = BC000L4_A73statusdsc[0];
            n73statusdsc = BC000L4_n73statusdsc[0];
            A74statususotabla = BC000L4_A74statususotabla[0];
            n74statususotabla = BC000L4_n74statususotabla[0];
            A75statusdesc = BC000L4_A75statusdesc[0];
            n75statusdesc = BC000L4_n75statusdesc[0];
            A76statususuario = BC000L4_A76statususuario[0];
            n76statususuario = BC000L4_n76statususuario[0];
            A77statusfecreg = BC000L4_A77statusfecreg[0];
            n77statusfecreg = BC000L4_n77statusfecreg[0];
            A78statusfecultact = BC000L4_A78statusfecultact[0];
            n78statusfecultact = BC000L4_n78statusfecultact[0];
            ZM0L21( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0L21( ) ;
      }

      protected void OnLoadActions0L21( )
      {
      }

      protected void CheckExtendedTable0L21( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0L21( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0L21( )
      {
         /* Using cursor BC000L5 */
         pr_default.execute(3, new Object[] {A1statusid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound21 = 1;
         }
         else
         {
            RcdFound21 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000L3 */
         pr_default.execute(1, new Object[] {A1statusid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0L21( 1) ;
            RcdFound21 = 1;
            A1statusid = BC000L3_A1statusid[0];
            A73statusdsc = BC000L3_A73statusdsc[0];
            n73statusdsc = BC000L3_n73statusdsc[0];
            A74statususotabla = BC000L3_A74statususotabla[0];
            n74statususotabla = BC000L3_n74statususotabla[0];
            A75statusdesc = BC000L3_A75statusdesc[0];
            n75statusdesc = BC000L3_n75statusdesc[0];
            A76statususuario = BC000L3_A76statususuario[0];
            n76statususuario = BC000L3_n76statususuario[0];
            A77statusfecreg = BC000L3_A77statusfecreg[0];
            n77statusfecreg = BC000L3_n77statusfecreg[0];
            A78statusfecultact = BC000L3_A78statusfecultact[0];
            n78statusfecultact = BC000L3_n78statusfecultact[0];
            Z1statusid = A1statusid;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0L21( ) ;
            if ( AnyError == 1 )
            {
               RcdFound21 = 0;
               InitializeNonKey0L21( ) ;
            }
            Gx_mode = sMode21;
         }
         else
         {
            RcdFound21 = 0;
            InitializeNonKey0L21( ) ;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode21;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0L21( ) ;
         if ( RcdFound21 == 0 )
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
         CONFIRM_0L0( ) ;
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

      protected void CheckOptimisticConcurrency0L21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000L2 */
            pr_default.execute(0, new Object[] {A1statusid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"STATUS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z73statusdsc, BC000L2_A73statusdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z74statususotabla, BC000L2_A74statususotabla[0]) != 0 ) || ( StringUtil.StrCmp(Z75statusdesc, BC000L2_A75statusdesc[0]) != 0 ) || ( StringUtil.StrCmp(Z76statususuario, BC000L2_A76statususuario[0]) != 0 ) || ( Z77statusfecreg != BC000L2_A77statusfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z78statusfecultact != BC000L2_A78statusfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"STATUS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0L21( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L21( 0) ;
            CheckOptimisticConcurrency0L21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000L6 */
                     pr_default.execute(4, new Object[] {A1statusid, n73statusdsc, A73statusdsc, n74statususotabla, A74statususotabla, n75statusdesc, A75statusdesc, n76statususuario, A76statususuario, n77statusfecreg, A77statusfecreg, n78statusfecultact, A78statusfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
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
               Load0L21( ) ;
            }
            EndLevel0L21( ) ;
         }
         CloseExtendedTableCursors0L21( ) ;
      }

      protected void Update0L21( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000L7 */
                     pr_default.execute(5, new Object[] {n73statusdsc, A73statusdsc, n74statususotabla, A74statususotabla, n75statusdesc, A75statusdesc, n76statususuario, A76statususuario, n77statusfecreg, A77statusfecreg, n78statusfecultact, A78statusfecultact, A1statusid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"STATUS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0L21( ) ;
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
            EndLevel0L21( ) ;
         }
         CloseExtendedTableCursors0L21( ) ;
      }

      protected void DeferredUpdate0L21( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L21( ) ;
            AfterConfirm0L21( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L21( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000L8 */
                  pr_default.execute(6, new Object[] {A1statusid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
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
         sMode21 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0L21( ) ;
         Gx_mode = sMode21;
      }

      protected void OnDeleteControls0L21( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0L21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0L21( ) ;
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

      public void ScanKeyStart0L21( )
      {
         /* Using cursor BC000L9 */
         pr_default.execute(7, new Object[] {A1statusid});
         RcdFound21 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound21 = 1;
            A1statusid = BC000L9_A1statusid[0];
            A73statusdsc = BC000L9_A73statusdsc[0];
            n73statusdsc = BC000L9_n73statusdsc[0];
            A74statususotabla = BC000L9_A74statususotabla[0];
            n74statususotabla = BC000L9_n74statususotabla[0];
            A75statusdesc = BC000L9_A75statusdesc[0];
            n75statusdesc = BC000L9_n75statusdesc[0];
            A76statususuario = BC000L9_A76statususuario[0];
            n76statususuario = BC000L9_n76statususuario[0];
            A77statusfecreg = BC000L9_A77statusfecreg[0];
            n77statusfecreg = BC000L9_n77statusfecreg[0];
            A78statusfecultact = BC000L9_A78statusfecultact[0];
            n78statusfecultact = BC000L9_n78statusfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0L21( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound21 = 0;
         ScanKeyLoad0L21( ) ;
      }

      protected void ScanKeyLoad0L21( )
      {
         sMode21 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound21 = 1;
            A1statusid = BC000L9_A1statusid[0];
            A73statusdsc = BC000L9_A73statusdsc[0];
            n73statusdsc = BC000L9_n73statusdsc[0];
            A74statususotabla = BC000L9_A74statususotabla[0];
            n74statususotabla = BC000L9_n74statususotabla[0];
            A75statusdesc = BC000L9_A75statusdesc[0];
            n75statusdesc = BC000L9_n75statusdesc[0];
            A76statususuario = BC000L9_A76statususuario[0];
            n76statususuario = BC000L9_n76statususuario[0];
            A77statusfecreg = BC000L9_A77statusfecreg[0];
            n77statusfecreg = BC000L9_n77statusfecreg[0];
            A78statusfecultact = BC000L9_A78statusfecultact[0];
            n78statusfecultact = BC000L9_n78statusfecultact[0];
         }
         Gx_mode = sMode21;
      }

      protected void ScanKeyEnd0L21( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0L21( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L21( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L21( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L21( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L21( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L21( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L21( )
      {
      }

      protected void AddRow0L21( )
      {
         VarsToRow21( bcstatus) ;
      }

      protected void ReadRow0L21( )
      {
         RowToVars21( bcstatus, 1) ;
      }

      protected void InitializeNonKey0L21( )
      {
         A73statusdsc = "";
         n73statusdsc = false;
         A74statususotabla = "";
         n74statususotabla = false;
         A75statusdesc = "";
         n75statusdesc = false;
         A76statususuario = "";
         n76statususuario = false;
         A77statusfecreg = (DateTime)(DateTime.MinValue);
         n77statusfecreg = false;
         A78statusfecultact = (DateTime)(DateTime.MinValue);
         n78statusfecultact = false;
         Z73statusdsc = "";
         Z74statususotabla = "";
         Z75statusdesc = "";
         Z76statususuario = "";
         Z77statusfecreg = (DateTime)(DateTime.MinValue);
         Z78statusfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0L21( )
      {
         A1statusid = 0;
         InitializeNonKey0L21( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow21( Sdtstatus obj21 )
      {
         obj21.gxTpr_Mode = Gx_mode;
         obj21.gxTpr_Statusdsc = A73statusdsc;
         obj21.gxTpr_Statususotabla = A74statususotabla;
         obj21.gxTpr_Statusdesc = A75statusdesc;
         obj21.gxTpr_Statususuario = A76statususuario;
         obj21.gxTpr_Statusfecreg = A77statusfecreg;
         obj21.gxTpr_Statusfecultact = A78statusfecultact;
         obj21.gxTpr_Statusid = A1statusid;
         obj21.gxTpr_Statusid_Z = Z1statusid;
         obj21.gxTpr_Statusdsc_Z = Z73statusdsc;
         obj21.gxTpr_Statususotabla_Z = Z74statususotabla;
         obj21.gxTpr_Statusdesc_Z = Z75statusdesc;
         obj21.gxTpr_Statususuario_Z = Z76statususuario;
         obj21.gxTpr_Statusfecreg_Z = Z77statusfecreg;
         obj21.gxTpr_Statusfecultact_Z = Z78statusfecultact;
         obj21.gxTpr_Statusdsc_N = (short)(Convert.ToInt16(n73statusdsc));
         obj21.gxTpr_Statususotabla_N = (short)(Convert.ToInt16(n74statususotabla));
         obj21.gxTpr_Statusdesc_N = (short)(Convert.ToInt16(n75statusdesc));
         obj21.gxTpr_Statususuario_N = (short)(Convert.ToInt16(n76statususuario));
         obj21.gxTpr_Statusfecreg_N = (short)(Convert.ToInt16(n77statusfecreg));
         obj21.gxTpr_Statusfecultact_N = (short)(Convert.ToInt16(n78statusfecultact));
         obj21.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow21( Sdtstatus obj21 )
      {
         obj21.gxTpr_Statusid = A1statusid;
         return  ;
      }

      public void RowToVars21( Sdtstatus obj21 ,
                               int forceLoad )
      {
         Gx_mode = obj21.gxTpr_Mode;
         A73statusdsc = obj21.gxTpr_Statusdsc;
         n73statusdsc = false;
         A74statususotabla = obj21.gxTpr_Statususotabla;
         n74statususotabla = false;
         A75statusdesc = obj21.gxTpr_Statusdesc;
         n75statusdesc = false;
         A76statususuario = obj21.gxTpr_Statususuario;
         n76statususuario = false;
         A77statusfecreg = obj21.gxTpr_Statusfecreg;
         n77statusfecreg = false;
         A78statusfecultact = obj21.gxTpr_Statusfecultact;
         n78statusfecultact = false;
         A1statusid = obj21.gxTpr_Statusid;
         Z1statusid = obj21.gxTpr_Statusid_Z;
         Z73statusdsc = obj21.gxTpr_Statusdsc_Z;
         Z74statususotabla = obj21.gxTpr_Statususotabla_Z;
         Z75statusdesc = obj21.gxTpr_Statusdesc_Z;
         Z76statususuario = obj21.gxTpr_Statususuario_Z;
         Z77statusfecreg = obj21.gxTpr_Statusfecreg_Z;
         Z78statusfecultact = obj21.gxTpr_Statusfecultact_Z;
         n73statusdsc = (bool)(Convert.ToBoolean(obj21.gxTpr_Statusdsc_N));
         n74statususotabla = (bool)(Convert.ToBoolean(obj21.gxTpr_Statususotabla_N));
         n75statusdesc = (bool)(Convert.ToBoolean(obj21.gxTpr_Statusdesc_N));
         n76statususuario = (bool)(Convert.ToBoolean(obj21.gxTpr_Statususuario_N));
         n77statusfecreg = (bool)(Convert.ToBoolean(obj21.gxTpr_Statusfecreg_N));
         n78statusfecultact = (bool)(Convert.ToBoolean(obj21.gxTpr_Statusfecultact_N));
         Gx_mode = obj21.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1statusid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0L21( ) ;
         ScanKeyStart0L21( ) ;
         if ( RcdFound21 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1statusid = A1statusid;
         }
         ZM0L21( -1) ;
         OnLoadActions0L21( ) ;
         AddRow0L21( ) ;
         ScanKeyEnd0L21( ) ;
         if ( RcdFound21 == 0 )
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
         RowToVars21( bcstatus, 0) ;
         ScanKeyStart0L21( ) ;
         if ( RcdFound21 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1statusid = A1statusid;
         }
         ZM0L21( -1) ;
         OnLoadActions0L21( ) ;
         AddRow0L21( ) ;
         ScanKeyEnd0L21( ) ;
         if ( RcdFound21 == 0 )
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
         RowToVars21( bcstatus, 0) ;
         nKeyPressed = 1;
         GetKey0L21( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0L21( ) ;
         }
         else
         {
            if ( RcdFound21 == 1 )
            {
               if ( A1statusid != Z1statusid )
               {
                  A1statusid = Z1statusid;
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
                  Update0L21( ) ;
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
                  if ( A1statusid != Z1statusid )
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
                        Insert0L21( ) ;
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
                        Insert0L21( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow21( bcstatus) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars21( bcstatus, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0L21( ) ;
         if ( RcdFound21 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A1statusid != Z1statusid )
            {
               A1statusid = Z1statusid;
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
            if ( A1statusid != Z1statusid )
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
         context.RollbackDataStores( "status_BC");
         VarsToRow21( bcstatus) ;
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
         Gx_mode = bcstatus.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcstatus.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcstatus )
         {
            bcstatus = (Sdtstatus)(sdt);
            if ( StringUtil.StrCmp(bcstatus.gxTpr_Mode, "") == 0 )
            {
               bcstatus.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow21( bcstatus) ;
            }
            else
            {
               RowToVars21( bcstatus, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcstatus.gxTpr_Mode, "") == 0 )
            {
               bcstatus.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars21( bcstatus, 1) ;
         return  ;
      }

      public Sdtstatus status_BC
      {
         get {
            return bcstatus ;
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
         Z73statusdsc = "";
         A73statusdsc = "";
         Z74statususotabla = "";
         A74statususotabla = "";
         Z75statusdesc = "";
         A75statusdesc = "";
         Z76statususuario = "";
         A76statususuario = "";
         Z77statusfecreg = (DateTime)(DateTime.MinValue);
         A77statusfecreg = (DateTime)(DateTime.MinValue);
         Z78statusfecultact = (DateTime)(DateTime.MinValue);
         A78statusfecultact = (DateTime)(DateTime.MinValue);
         BC000L4_A1statusid = new int[1] ;
         BC000L4_A73statusdsc = new String[] {""} ;
         BC000L4_n73statusdsc = new bool[] {false} ;
         BC000L4_A74statususotabla = new String[] {""} ;
         BC000L4_n74statususotabla = new bool[] {false} ;
         BC000L4_A75statusdesc = new String[] {""} ;
         BC000L4_n75statusdesc = new bool[] {false} ;
         BC000L4_A76statususuario = new String[] {""} ;
         BC000L4_n76statususuario = new bool[] {false} ;
         BC000L4_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000L4_n77statusfecreg = new bool[] {false} ;
         BC000L4_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000L4_n78statusfecultact = new bool[] {false} ;
         BC000L5_A1statusid = new int[1] ;
         BC000L3_A1statusid = new int[1] ;
         BC000L3_A73statusdsc = new String[] {""} ;
         BC000L3_n73statusdsc = new bool[] {false} ;
         BC000L3_A74statususotabla = new String[] {""} ;
         BC000L3_n74statususotabla = new bool[] {false} ;
         BC000L3_A75statusdesc = new String[] {""} ;
         BC000L3_n75statusdesc = new bool[] {false} ;
         BC000L3_A76statususuario = new String[] {""} ;
         BC000L3_n76statususuario = new bool[] {false} ;
         BC000L3_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000L3_n77statusfecreg = new bool[] {false} ;
         BC000L3_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000L3_n78statusfecultact = new bool[] {false} ;
         sMode21 = "";
         BC000L2_A1statusid = new int[1] ;
         BC000L2_A73statusdsc = new String[] {""} ;
         BC000L2_n73statusdsc = new bool[] {false} ;
         BC000L2_A74statususotabla = new String[] {""} ;
         BC000L2_n74statususotabla = new bool[] {false} ;
         BC000L2_A75statusdesc = new String[] {""} ;
         BC000L2_n75statusdesc = new bool[] {false} ;
         BC000L2_A76statususuario = new String[] {""} ;
         BC000L2_n76statususuario = new bool[] {false} ;
         BC000L2_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000L2_n77statusfecreg = new bool[] {false} ;
         BC000L2_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000L2_n78statusfecultact = new bool[] {false} ;
         BC000L9_A1statusid = new int[1] ;
         BC000L9_A73statusdsc = new String[] {""} ;
         BC000L9_n73statusdsc = new bool[] {false} ;
         BC000L9_A74statususotabla = new String[] {""} ;
         BC000L9_n74statususotabla = new bool[] {false} ;
         BC000L9_A75statusdesc = new String[] {""} ;
         BC000L9_n75statusdesc = new bool[] {false} ;
         BC000L9_A76statususuario = new String[] {""} ;
         BC000L9_n76statususuario = new bool[] {false} ;
         BC000L9_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000L9_n77statusfecreg = new bool[] {false} ;
         BC000L9_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000L9_n78statusfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.status_bc__default(),
            new Object[][] {
                new Object[] {
               BC000L2_A1statusid, BC000L2_A73statusdsc, BC000L2_n73statusdsc, BC000L2_A74statususotabla, BC000L2_n74statususotabla, BC000L2_A75statusdesc, BC000L2_n75statusdesc, BC000L2_A76statususuario, BC000L2_n76statususuario, BC000L2_A77statusfecreg,
               BC000L2_n77statusfecreg, BC000L2_A78statusfecultact, BC000L2_n78statusfecultact
               }
               , new Object[] {
               BC000L3_A1statusid, BC000L3_A73statusdsc, BC000L3_n73statusdsc, BC000L3_A74statususotabla, BC000L3_n74statususotabla, BC000L3_A75statusdesc, BC000L3_n75statusdesc, BC000L3_A76statususuario, BC000L3_n76statususuario, BC000L3_A77statusfecreg,
               BC000L3_n77statusfecreg, BC000L3_A78statusfecultact, BC000L3_n78statusfecultact
               }
               , new Object[] {
               BC000L4_A1statusid, BC000L4_A73statusdsc, BC000L4_n73statusdsc, BC000L4_A74statususotabla, BC000L4_n74statususotabla, BC000L4_A75statusdesc, BC000L4_n75statusdesc, BC000L4_A76statususuario, BC000L4_n76statususuario, BC000L4_A77statusfecreg,
               BC000L4_n77statusfecreg, BC000L4_A78statusfecultact, BC000L4_n78statusfecultact
               }
               , new Object[] {
               BC000L5_A1statusid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000L9_A1statusid, BC000L9_A73statusdsc, BC000L9_n73statusdsc, BC000L9_A74statususotabla, BC000L9_n74statususotabla, BC000L9_A75statusdesc, BC000L9_n75statusdesc, BC000L9_A76statususuario, BC000L9_n76statususuario, BC000L9_A77statusfecreg,
               BC000L9_n77statusfecreg, BC000L9_A78statusfecultact, BC000L9_n78statusfecultact
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
      private short RcdFound21 ;
      private int trnEnded ;
      private int Z1statusid ;
      private int A1statusid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode21 ;
      private DateTime Z77statusfecreg ;
      private DateTime A77statusfecreg ;
      private DateTime Z78statusfecultact ;
      private DateTime A78statusfecultact ;
      private bool n73statusdsc ;
      private bool n74statususotabla ;
      private bool n75statusdesc ;
      private bool n76statususuario ;
      private bool n77statusfecreg ;
      private bool n78statusfecultact ;
      private bool Gx_longc ;
      private String Z73statusdsc ;
      private String A73statusdsc ;
      private String Z74statususotabla ;
      private String A74statususotabla ;
      private String Z75statusdesc ;
      private String A75statusdesc ;
      private String Z76statususuario ;
      private String A76statususuario ;
      private Sdtstatus bcstatus ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000L4_A1statusid ;
      private String[] BC000L4_A73statusdsc ;
      private bool[] BC000L4_n73statusdsc ;
      private String[] BC000L4_A74statususotabla ;
      private bool[] BC000L4_n74statususotabla ;
      private String[] BC000L4_A75statusdesc ;
      private bool[] BC000L4_n75statusdesc ;
      private String[] BC000L4_A76statususuario ;
      private bool[] BC000L4_n76statususuario ;
      private DateTime[] BC000L4_A77statusfecreg ;
      private bool[] BC000L4_n77statusfecreg ;
      private DateTime[] BC000L4_A78statusfecultact ;
      private bool[] BC000L4_n78statusfecultact ;
      private int[] BC000L5_A1statusid ;
      private int[] BC000L3_A1statusid ;
      private String[] BC000L3_A73statusdsc ;
      private bool[] BC000L3_n73statusdsc ;
      private String[] BC000L3_A74statususotabla ;
      private bool[] BC000L3_n74statususotabla ;
      private String[] BC000L3_A75statusdesc ;
      private bool[] BC000L3_n75statusdesc ;
      private String[] BC000L3_A76statususuario ;
      private bool[] BC000L3_n76statususuario ;
      private DateTime[] BC000L3_A77statusfecreg ;
      private bool[] BC000L3_n77statusfecreg ;
      private DateTime[] BC000L3_A78statusfecultact ;
      private bool[] BC000L3_n78statusfecultact ;
      private int[] BC000L2_A1statusid ;
      private String[] BC000L2_A73statusdsc ;
      private bool[] BC000L2_n73statusdsc ;
      private String[] BC000L2_A74statususotabla ;
      private bool[] BC000L2_n74statususotabla ;
      private String[] BC000L2_A75statusdesc ;
      private bool[] BC000L2_n75statusdesc ;
      private String[] BC000L2_A76statususuario ;
      private bool[] BC000L2_n76statususuario ;
      private DateTime[] BC000L2_A77statusfecreg ;
      private bool[] BC000L2_n77statusfecreg ;
      private DateTime[] BC000L2_A78statusfecultact ;
      private bool[] BC000L2_n78statusfecultact ;
      private int[] BC000L9_A1statusid ;
      private String[] BC000L9_A73statusdsc ;
      private bool[] BC000L9_n73statusdsc ;
      private String[] BC000L9_A74statususotabla ;
      private bool[] BC000L9_n74statususotabla ;
      private String[] BC000L9_A75statusdesc ;
      private bool[] BC000L9_n75statusdesc ;
      private String[] BC000L9_A76statususuario ;
      private bool[] BC000L9_n76statususuario ;
      private DateTime[] BC000L9_A77statusfecreg ;
      private bool[] BC000L9_n77statusfecreg ;
      private DateTime[] BC000L9_A78statusfecultact ;
      private bool[] BC000L9_n78statusfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class status_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000L4 ;
          prmBC000L4 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L5 ;
          prmBC000L5 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L3 ;
          prmBC000L3 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L2 ;
          prmBC000L2 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L6 ;
          prmBC000L6 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"statusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"statusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000L7 ;
          prmBC000L7 = new Object[] {
          new Object[] {"statusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"statusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L8 ;
          prmBC000L8 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000L9 ;
          prmBC000L9 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000L2", "SELECT statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact FROM public.status WHERE statusid = :statusid  FOR UPDATE OF status",true, GxErrorMask.GX_NOMASK, false, this,prmBC000L2,1,0,true,false )
             ,new CursorDef("BC000L3", "SELECT statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact FROM public.status WHERE statusid = :statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000L3,1,0,true,false )
             ,new CursorDef("BC000L4", "SELECT TM1.statusid, TM1.statusdsc, TM1.statususotabla, TM1.statusdesc, TM1.statususuario, TM1.statusfecreg, TM1.statusfecultact FROM public.status TM1 WHERE TM1.statusid = :statusid ORDER BY TM1.statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000L4,100,0,true,false )
             ,new CursorDef("BC000L5", "SELECT statusid FROM public.status WHERE statusid = :statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000L5,1,0,true,false )
             ,new CursorDef("BC000L6", "SAVEPOINT gxupdate;INSERT INTO public.status(statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact) VALUES(:statusid, :statusdsc, :statususotabla, :statusdesc, :statususuario, :statusfecreg, :statusfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000L6)
             ,new CursorDef("BC000L7", "SAVEPOINT gxupdate;UPDATE public.status SET statusdsc=:statusdsc, statususotabla=:statususotabla, statusdesc=:statusdesc, statususuario=:statususuario, statusfecreg=:statusfecreg, statusfecultact=:statusfecultact  WHERE statusid = :statusid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000L7)
             ,new CursorDef("BC000L8", "SAVEPOINT gxupdate;DELETE FROM public.status  WHERE statusid = :statusid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000L8)
             ,new CursorDef("BC000L9", "SELECT TM1.statusid, TM1.statusdsc, TM1.statususotabla, TM1.statusdesc, TM1.statususuario, TM1.statusfecreg, TM1.statusfecultact FROM public.status TM1 WHERE TM1.statusid = :statusid ORDER BY TM1.statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000L9,100,0,true,false )
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
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[12]);
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[11]);
                }
                stmt.SetParameter(7, (int)parms[12]);
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
