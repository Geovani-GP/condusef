/*
               File: producto_BC
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:56:23.3
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
   public class producto_bc : GXHttpHandler, IGxSilentTrn
   {
      public producto_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public producto_bc( IGxContext context )
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
         ReadRow0923( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0923( ) ;
         standaloneModal( ) ;
         AddRow0923( ) ;
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
               Z175productoid = A175productoid;
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

      protected void CONFIRM_090( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0923( ) ;
            }
            else
            {
               CheckExtendedTable0923( ) ;
               if ( AnyError == 0 )
               {
                  ZM0923( 2) ;
                  ZM0923( 3) ;
               }
               CloseExtendedTableCursors0923( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0923( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z87productodsc = A87productodsc;
            Z88modeloid = A88modeloid;
            Z89marcaid = A89marcaid;
            Z90categoriaid = A90categoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z25cambsid = A25cambsid;
            Z23tipobienid = A23tipobienid;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z175productoid = A175productoid;
            Z87productodsc = A87productodsc;
            Z88modeloid = A88modeloid;
            Z89marcaid = A89marcaid;
            Z90categoriaid = A90categoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z25cambsid = A25cambsid;
            Z23tipobienid = A23tipobienid;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0923( )
      {
         /* Using cursor BC00096 */
         pr_default.execute(4, new Object[] {A175productoid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound23 = 1;
            A87productodsc = BC00096_A87productodsc[0];
            n87productodsc = BC00096_n87productodsc[0];
            A88modeloid = BC00096_A88modeloid[0];
            n88modeloid = BC00096_n88modeloid[0];
            A89marcaid = BC00096_A89marcaid[0];
            n89marcaid = BC00096_n89marcaid[0];
            A90categoriaid = BC00096_A90categoriaid[0];
            n90categoriaid = BC00096_n90categoriaid[0];
            A91productousuario = BC00096_A91productousuario[0];
            n91productousuario = BC00096_n91productousuario[0];
            A92productofecreg = BC00096_A92productofecreg[0];
            n92productofecreg = BC00096_n92productofecreg[0];
            A93productofecultact = BC00096_A93productofecultact[0];
            n93productofecultact = BC00096_n93productofecultact[0];
            A25cambsid = BC00096_A25cambsid[0];
            n25cambsid = BC00096_n25cambsid[0];
            A23tipobienid = BC00096_A23tipobienid[0];
            n23tipobienid = BC00096_n23tipobienid[0];
            ZM0923( -1) ;
         }
         pr_default.close(4);
         OnLoadActions0923( ) ;
      }

      protected void OnLoadActions0923( )
      {
      }

      protected void CheckExtendedTable0923( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00094 */
         pr_default.execute(2, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A25cambsid) ) )
            {
               GX_msglist.addItem("No existe 'cambs'.", "ForeignKeyNotFound", 1, "CAMBSID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
         /* Using cursor BC00095 */
         pr_default.execute(3, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A23tipobienid) ) )
            {
               GX_msglist.addItem("No existe 'tipobien'.", "ForeignKeyNotFound", 1, "TIPOBIENID");
               AnyError = 1;
            }
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0923( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0923( )
      {
         /* Using cursor BC00097 */
         pr_default.execute(5, new Object[] {A175productoid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00093 */
         pr_default.execute(1, new Object[] {A175productoid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0923( 1) ;
            RcdFound23 = 1;
            A175productoid = BC00093_A175productoid[0];
            A87productodsc = BC00093_A87productodsc[0];
            n87productodsc = BC00093_n87productodsc[0];
            A88modeloid = BC00093_A88modeloid[0];
            n88modeloid = BC00093_n88modeloid[0];
            A89marcaid = BC00093_A89marcaid[0];
            n89marcaid = BC00093_n89marcaid[0];
            A90categoriaid = BC00093_A90categoriaid[0];
            n90categoriaid = BC00093_n90categoriaid[0];
            A91productousuario = BC00093_A91productousuario[0];
            n91productousuario = BC00093_n91productousuario[0];
            A92productofecreg = BC00093_A92productofecreg[0];
            n92productofecreg = BC00093_n92productofecreg[0];
            A93productofecultact = BC00093_A93productofecultact[0];
            n93productofecultact = BC00093_n93productofecultact[0];
            A25cambsid = BC00093_A25cambsid[0];
            n25cambsid = BC00093_n25cambsid[0];
            A23tipobienid = BC00093_A23tipobienid[0];
            n23tipobienid = BC00093_n23tipobienid[0];
            Z175productoid = A175productoid;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0923( ) ;
            if ( AnyError == 1 )
            {
               RcdFound23 = 0;
               InitializeNonKey0923( ) ;
            }
            Gx_mode = sMode23;
         }
         else
         {
            RcdFound23 = 0;
            InitializeNonKey0923( ) ;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode23;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0923( ) ;
         if ( RcdFound23 == 0 )
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
         CONFIRM_090( ) ;
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

      protected void CheckOptimisticConcurrency0923( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00092 */
            pr_default.execute(0, new Object[] {A175productoid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"producto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z87productodsc, BC00092_A87productodsc[0]) != 0 ) || ( Z88modeloid != BC00092_A88modeloid[0] ) || ( Z89marcaid != BC00092_A89marcaid[0] ) || ( Z90categoriaid != BC00092_A90categoriaid[0] ) || ( StringUtil.StrCmp(Z91productousuario, BC00092_A91productousuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z92productofecreg != BC00092_A92productofecreg[0] ) || ( Z93productofecultact != BC00092_A93productofecultact[0] ) || ( Z25cambsid != BC00092_A25cambsid[0] ) || ( Z23tipobienid != BC00092_A23tipobienid[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"producto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0923( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0923( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0923( 0) ;
            CheckOptimisticConcurrency0923( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0923( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0923( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00098 */
                     pr_default.execute(6, new Object[] {A175productoid, n87productodsc, A87productodsc, n88modeloid, A88modeloid, n89marcaid, A89marcaid, n90categoriaid, A90categoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n25cambsid, A25cambsid, n23tipobienid, A23tipobienid});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("producto") ;
                     if ( (pr_default.getStatus(6) == 1) )
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
               Load0923( ) ;
            }
            EndLevel0923( ) ;
         }
         CloseExtendedTableCursors0923( ) ;
      }

      protected void Update0923( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0923( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0923( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0923( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0923( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00099 */
                     pr_default.execute(7, new Object[] {n87productodsc, A87productodsc, n88modeloid, A88modeloid, n89marcaid, A89marcaid, n90categoriaid, A90categoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n25cambsid, A25cambsid, n23tipobienid, A23tipobienid, A175productoid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("producto") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"producto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0923( ) ;
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
            EndLevel0923( ) ;
         }
         CloseExtendedTableCursors0923( ) ;
      }

      protected void DeferredUpdate0923( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0923( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0923( ) ;
            AfterConfirm0923( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0923( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000910 */
                  pr_default.execute(8, new Object[] {A175productoid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("producto") ;
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
         sMode23 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0923( ) ;
         Gx_mode = sMode23;
      }

      protected void OnDeleteControls0923( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0923( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0923( ) ;
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

      public void ScanKeyStart0923( )
      {
         /* Using cursor BC000911 */
         pr_default.execute(9, new Object[] {A175productoid});
         RcdFound23 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = BC000911_A175productoid[0];
            A87productodsc = BC000911_A87productodsc[0];
            n87productodsc = BC000911_n87productodsc[0];
            A88modeloid = BC000911_A88modeloid[0];
            n88modeloid = BC000911_n88modeloid[0];
            A89marcaid = BC000911_A89marcaid[0];
            n89marcaid = BC000911_n89marcaid[0];
            A90categoriaid = BC000911_A90categoriaid[0];
            n90categoriaid = BC000911_n90categoriaid[0];
            A91productousuario = BC000911_A91productousuario[0];
            n91productousuario = BC000911_n91productousuario[0];
            A92productofecreg = BC000911_A92productofecreg[0];
            n92productofecreg = BC000911_n92productofecreg[0];
            A93productofecultact = BC000911_A93productofecultact[0];
            n93productofecultact = BC000911_n93productofecultact[0];
            A25cambsid = BC000911_A25cambsid[0];
            n25cambsid = BC000911_n25cambsid[0];
            A23tipobienid = BC000911_A23tipobienid[0];
            n23tipobienid = BC000911_n23tipobienid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0923( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound23 = 0;
         ScanKeyLoad0923( ) ;
      }

      protected void ScanKeyLoad0923( )
      {
         sMode23 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = BC000911_A175productoid[0];
            A87productodsc = BC000911_A87productodsc[0];
            n87productodsc = BC000911_n87productodsc[0];
            A88modeloid = BC000911_A88modeloid[0];
            n88modeloid = BC000911_n88modeloid[0];
            A89marcaid = BC000911_A89marcaid[0];
            n89marcaid = BC000911_n89marcaid[0];
            A90categoriaid = BC000911_A90categoriaid[0];
            n90categoriaid = BC000911_n90categoriaid[0];
            A91productousuario = BC000911_A91productousuario[0];
            n91productousuario = BC000911_n91productousuario[0];
            A92productofecreg = BC000911_A92productofecreg[0];
            n92productofecreg = BC000911_n92productofecreg[0];
            A93productofecultact = BC000911_A93productofecultact[0];
            n93productofecultact = BC000911_n93productofecultact[0];
            A25cambsid = BC000911_A25cambsid[0];
            n25cambsid = BC000911_n25cambsid[0];
            A23tipobienid = BC000911_A23tipobienid[0];
            n23tipobienid = BC000911_n23tipobienid[0];
         }
         Gx_mode = sMode23;
      }

      protected void ScanKeyEnd0923( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0923( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0923( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0923( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0923( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0923( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0923( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0923( )
      {
      }

      protected void AddRow0923( )
      {
         VarsToRow23( bcproducto) ;
      }

      protected void ReadRow0923( )
      {
         RowToVars23( bcproducto, 1) ;
      }

      protected void InitializeNonKey0923( )
      {
         A25cambsid = 0;
         n25cambsid = false;
         A87productodsc = "";
         n87productodsc = false;
         A88modeloid = 0;
         n88modeloid = false;
         A89marcaid = 0;
         n89marcaid = false;
         A90categoriaid = 0;
         n90categoriaid = false;
         A91productousuario = "";
         n91productousuario = false;
         A92productofecreg = (DateTime)(DateTime.MinValue);
         n92productofecreg = false;
         A93productofecultact = (DateTime)(DateTime.MinValue);
         n93productofecultact = false;
         A23tipobienid = 0;
         n23tipobienid = false;
         Z87productodsc = "";
         Z88modeloid = 0;
         Z89marcaid = 0;
         Z90categoriaid = 0;
         Z91productousuario = "";
         Z92productofecreg = (DateTime)(DateTime.MinValue);
         Z93productofecultact = (DateTime)(DateTime.MinValue);
         Z25cambsid = 0;
         Z23tipobienid = 0;
      }

      protected void InitAll0923( )
      {
         A175productoid = 0;
         InitializeNonKey0923( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow23( Sdtproducto obj23 )
      {
         obj23.gxTpr_Mode = Gx_mode;
         obj23.gxTpr_Cambsid = A25cambsid;
         obj23.gxTpr_Productodsc = A87productodsc;
         obj23.gxTpr_Modeloid = A88modeloid;
         obj23.gxTpr_Marcaid = A89marcaid;
         obj23.gxTpr_Categoriaid = A90categoriaid;
         obj23.gxTpr_Productousuario = A91productousuario;
         obj23.gxTpr_Productofecreg = A92productofecreg;
         obj23.gxTpr_Productofecultact = A93productofecultact;
         obj23.gxTpr_Tipobienid = A23tipobienid;
         obj23.gxTpr_Productoid = A175productoid;
         obj23.gxTpr_Productoid_Z = Z175productoid;
         obj23.gxTpr_Cambsid_Z = Z25cambsid;
         obj23.gxTpr_Productodsc_Z = Z87productodsc;
         obj23.gxTpr_Modeloid_Z = Z88modeloid;
         obj23.gxTpr_Marcaid_Z = Z89marcaid;
         obj23.gxTpr_Categoriaid_Z = Z90categoriaid;
         obj23.gxTpr_Productousuario_Z = Z91productousuario;
         obj23.gxTpr_Productofecreg_Z = Z92productofecreg;
         obj23.gxTpr_Productofecultact_Z = Z93productofecultact;
         obj23.gxTpr_Tipobienid_Z = Z23tipobienid;
         obj23.gxTpr_Cambsid_N = (short)(Convert.ToInt16(n25cambsid));
         obj23.gxTpr_Productodsc_N = (short)(Convert.ToInt16(n87productodsc));
         obj23.gxTpr_Modeloid_N = (short)(Convert.ToInt16(n88modeloid));
         obj23.gxTpr_Marcaid_N = (short)(Convert.ToInt16(n89marcaid));
         obj23.gxTpr_Categoriaid_N = (short)(Convert.ToInt16(n90categoriaid));
         obj23.gxTpr_Productousuario_N = (short)(Convert.ToInt16(n91productousuario));
         obj23.gxTpr_Productofecreg_N = (short)(Convert.ToInt16(n92productofecreg));
         obj23.gxTpr_Productofecultact_N = (short)(Convert.ToInt16(n93productofecultact));
         obj23.gxTpr_Tipobienid_N = (short)(Convert.ToInt16(n23tipobienid));
         obj23.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow23( Sdtproducto obj23 )
      {
         obj23.gxTpr_Productoid = A175productoid;
         return  ;
      }

      public void RowToVars23( Sdtproducto obj23 ,
                               int forceLoad )
      {
         Gx_mode = obj23.gxTpr_Mode;
         A25cambsid = obj23.gxTpr_Cambsid;
         n25cambsid = false;
         A87productodsc = obj23.gxTpr_Productodsc;
         n87productodsc = false;
         A88modeloid = obj23.gxTpr_Modeloid;
         n88modeloid = false;
         A89marcaid = obj23.gxTpr_Marcaid;
         n89marcaid = false;
         A90categoriaid = obj23.gxTpr_Categoriaid;
         n90categoriaid = false;
         A91productousuario = obj23.gxTpr_Productousuario;
         n91productousuario = false;
         A92productofecreg = obj23.gxTpr_Productofecreg;
         n92productofecreg = false;
         A93productofecultact = obj23.gxTpr_Productofecultact;
         n93productofecultact = false;
         A23tipobienid = obj23.gxTpr_Tipobienid;
         n23tipobienid = false;
         A175productoid = obj23.gxTpr_Productoid;
         Z175productoid = obj23.gxTpr_Productoid_Z;
         Z25cambsid = obj23.gxTpr_Cambsid_Z;
         Z87productodsc = obj23.gxTpr_Productodsc_Z;
         Z88modeloid = obj23.gxTpr_Modeloid_Z;
         Z89marcaid = obj23.gxTpr_Marcaid_Z;
         Z90categoriaid = obj23.gxTpr_Categoriaid_Z;
         Z91productousuario = obj23.gxTpr_Productousuario_Z;
         Z92productofecreg = obj23.gxTpr_Productofecreg_Z;
         Z93productofecultact = obj23.gxTpr_Productofecultact_Z;
         Z23tipobienid = obj23.gxTpr_Tipobienid_Z;
         n25cambsid = (bool)(Convert.ToBoolean(obj23.gxTpr_Cambsid_N));
         n87productodsc = (bool)(Convert.ToBoolean(obj23.gxTpr_Productodsc_N));
         n88modeloid = (bool)(Convert.ToBoolean(obj23.gxTpr_Modeloid_N));
         n89marcaid = (bool)(Convert.ToBoolean(obj23.gxTpr_Marcaid_N));
         n90categoriaid = (bool)(Convert.ToBoolean(obj23.gxTpr_Categoriaid_N));
         n91productousuario = (bool)(Convert.ToBoolean(obj23.gxTpr_Productousuario_N));
         n92productofecreg = (bool)(Convert.ToBoolean(obj23.gxTpr_Productofecreg_N));
         n93productofecultact = (bool)(Convert.ToBoolean(obj23.gxTpr_Productofecultact_N));
         n23tipobienid = (bool)(Convert.ToBoolean(obj23.gxTpr_Tipobienid_N));
         Gx_mode = obj23.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A175productoid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0923( ) ;
         ScanKeyStart0923( ) ;
         if ( RcdFound23 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z175productoid = A175productoid;
         }
         ZM0923( -1) ;
         OnLoadActions0923( ) ;
         AddRow0923( ) ;
         ScanKeyEnd0923( ) ;
         if ( RcdFound23 == 0 )
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
         RowToVars23( bcproducto, 0) ;
         ScanKeyStart0923( ) ;
         if ( RcdFound23 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z175productoid = A175productoid;
         }
         ZM0923( -1) ;
         OnLoadActions0923( ) ;
         AddRow0923( ) ;
         ScanKeyEnd0923( ) ;
         if ( RcdFound23 == 0 )
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
         RowToVars23( bcproducto, 0) ;
         nKeyPressed = 1;
         GetKey0923( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0923( ) ;
         }
         else
         {
            if ( RcdFound23 == 1 )
            {
               if ( A175productoid != Z175productoid )
               {
                  A175productoid = Z175productoid;
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
                  Update0923( ) ;
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
                  if ( A175productoid != Z175productoid )
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
                        Insert0923( ) ;
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
                        Insert0923( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow23( bcproducto) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars23( bcproducto, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0923( ) ;
         if ( RcdFound23 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A175productoid != Z175productoid )
            {
               A175productoid = Z175productoid;
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
            if ( A175productoid != Z175productoid )
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
         context.RollbackDataStores( "producto_BC");
         VarsToRow23( bcproducto) ;
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
         Gx_mode = bcproducto.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcproducto.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcproducto )
         {
            bcproducto = (Sdtproducto)(sdt);
            if ( StringUtil.StrCmp(bcproducto.gxTpr_Mode, "") == 0 )
            {
               bcproducto.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow23( bcproducto) ;
            }
            else
            {
               RowToVars23( bcproducto, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcproducto.gxTpr_Mode, "") == 0 )
            {
               bcproducto.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars23( bcproducto, 1) ;
         return  ;
      }

      public Sdtproducto producto_BC
      {
         get {
            return bcproducto ;
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
         Z87productodsc = "";
         A87productodsc = "";
         Z91productousuario = "";
         A91productousuario = "";
         Z92productofecreg = (DateTime)(DateTime.MinValue);
         A92productofecreg = (DateTime)(DateTime.MinValue);
         Z93productofecultact = (DateTime)(DateTime.MinValue);
         A93productofecultact = (DateTime)(DateTime.MinValue);
         BC00096_A175productoid = new int[1] ;
         BC00096_A87productodsc = new String[] {""} ;
         BC00096_n87productodsc = new bool[] {false} ;
         BC00096_A88modeloid = new long[1] ;
         BC00096_n88modeloid = new bool[] {false} ;
         BC00096_A89marcaid = new long[1] ;
         BC00096_n89marcaid = new bool[] {false} ;
         BC00096_A90categoriaid = new long[1] ;
         BC00096_n90categoriaid = new bool[] {false} ;
         BC00096_A91productousuario = new String[] {""} ;
         BC00096_n91productousuario = new bool[] {false} ;
         BC00096_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00096_n92productofecreg = new bool[] {false} ;
         BC00096_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00096_n93productofecultact = new bool[] {false} ;
         BC00096_A25cambsid = new int[1] ;
         BC00096_n25cambsid = new bool[] {false} ;
         BC00096_A23tipobienid = new int[1] ;
         BC00096_n23tipobienid = new bool[] {false} ;
         BC00094_A25cambsid = new int[1] ;
         BC00094_n25cambsid = new bool[] {false} ;
         BC00095_A23tipobienid = new int[1] ;
         BC00095_n23tipobienid = new bool[] {false} ;
         BC00097_A175productoid = new int[1] ;
         BC00093_A175productoid = new int[1] ;
         BC00093_A87productodsc = new String[] {""} ;
         BC00093_n87productodsc = new bool[] {false} ;
         BC00093_A88modeloid = new long[1] ;
         BC00093_n88modeloid = new bool[] {false} ;
         BC00093_A89marcaid = new long[1] ;
         BC00093_n89marcaid = new bool[] {false} ;
         BC00093_A90categoriaid = new long[1] ;
         BC00093_n90categoriaid = new bool[] {false} ;
         BC00093_A91productousuario = new String[] {""} ;
         BC00093_n91productousuario = new bool[] {false} ;
         BC00093_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00093_n92productofecreg = new bool[] {false} ;
         BC00093_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00093_n93productofecultact = new bool[] {false} ;
         BC00093_A25cambsid = new int[1] ;
         BC00093_n25cambsid = new bool[] {false} ;
         BC00093_A23tipobienid = new int[1] ;
         BC00093_n23tipobienid = new bool[] {false} ;
         sMode23 = "";
         BC00092_A175productoid = new int[1] ;
         BC00092_A87productodsc = new String[] {""} ;
         BC00092_n87productodsc = new bool[] {false} ;
         BC00092_A88modeloid = new long[1] ;
         BC00092_n88modeloid = new bool[] {false} ;
         BC00092_A89marcaid = new long[1] ;
         BC00092_n89marcaid = new bool[] {false} ;
         BC00092_A90categoriaid = new long[1] ;
         BC00092_n90categoriaid = new bool[] {false} ;
         BC00092_A91productousuario = new String[] {""} ;
         BC00092_n91productousuario = new bool[] {false} ;
         BC00092_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00092_n92productofecreg = new bool[] {false} ;
         BC00092_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00092_n93productofecultact = new bool[] {false} ;
         BC00092_A25cambsid = new int[1] ;
         BC00092_n25cambsid = new bool[] {false} ;
         BC00092_A23tipobienid = new int[1] ;
         BC00092_n23tipobienid = new bool[] {false} ;
         BC000911_A175productoid = new int[1] ;
         BC000911_A87productodsc = new String[] {""} ;
         BC000911_n87productodsc = new bool[] {false} ;
         BC000911_A88modeloid = new long[1] ;
         BC000911_n88modeloid = new bool[] {false} ;
         BC000911_A89marcaid = new long[1] ;
         BC000911_n89marcaid = new bool[] {false} ;
         BC000911_A90categoriaid = new long[1] ;
         BC000911_n90categoriaid = new bool[] {false} ;
         BC000911_A91productousuario = new String[] {""} ;
         BC000911_n91productousuario = new bool[] {false} ;
         BC000911_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC000911_n92productofecreg = new bool[] {false} ;
         BC000911_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC000911_n93productofecultact = new bool[] {false} ;
         BC000911_A25cambsid = new int[1] ;
         BC000911_n25cambsid = new bool[] {false} ;
         BC000911_A23tipobienid = new int[1] ;
         BC000911_n23tipobienid = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producto_bc__default(),
            new Object[][] {
                new Object[] {
               BC00092_A175productoid, BC00092_A87productodsc, BC00092_n87productodsc, BC00092_A88modeloid, BC00092_n88modeloid, BC00092_A89marcaid, BC00092_n89marcaid, BC00092_A90categoriaid, BC00092_n90categoriaid, BC00092_A91productousuario,
               BC00092_n91productousuario, BC00092_A92productofecreg, BC00092_n92productofecreg, BC00092_A93productofecultact, BC00092_n93productofecultact, BC00092_A25cambsid, BC00092_n25cambsid, BC00092_A23tipobienid, BC00092_n23tipobienid
               }
               , new Object[] {
               BC00093_A175productoid, BC00093_A87productodsc, BC00093_n87productodsc, BC00093_A88modeloid, BC00093_n88modeloid, BC00093_A89marcaid, BC00093_n89marcaid, BC00093_A90categoriaid, BC00093_n90categoriaid, BC00093_A91productousuario,
               BC00093_n91productousuario, BC00093_A92productofecreg, BC00093_n92productofecreg, BC00093_A93productofecultact, BC00093_n93productofecultact, BC00093_A25cambsid, BC00093_n25cambsid, BC00093_A23tipobienid, BC00093_n23tipobienid
               }
               , new Object[] {
               BC00094_A25cambsid
               }
               , new Object[] {
               BC00095_A23tipobienid
               }
               , new Object[] {
               BC00096_A175productoid, BC00096_A87productodsc, BC00096_n87productodsc, BC00096_A88modeloid, BC00096_n88modeloid, BC00096_A89marcaid, BC00096_n89marcaid, BC00096_A90categoriaid, BC00096_n90categoriaid, BC00096_A91productousuario,
               BC00096_n91productousuario, BC00096_A92productofecreg, BC00096_n92productofecreg, BC00096_A93productofecultact, BC00096_n93productofecultact, BC00096_A25cambsid, BC00096_n25cambsid, BC00096_A23tipobienid, BC00096_n23tipobienid
               }
               , new Object[] {
               BC00097_A175productoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000911_A175productoid, BC000911_A87productodsc, BC000911_n87productodsc, BC000911_A88modeloid, BC000911_n88modeloid, BC000911_A89marcaid, BC000911_n89marcaid, BC000911_A90categoriaid, BC000911_n90categoriaid, BC000911_A91productousuario,
               BC000911_n91productousuario, BC000911_A92productofecreg, BC000911_n92productofecreg, BC000911_A93productofecultact, BC000911_n93productofecultact, BC000911_A25cambsid, BC000911_n25cambsid, BC000911_A23tipobienid, BC000911_n23tipobienid
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
      private short RcdFound23 ;
      private int trnEnded ;
      private int Z175productoid ;
      private int A175productoid ;
      private int Z25cambsid ;
      private int A25cambsid ;
      private int Z23tipobienid ;
      private int A23tipobienid ;
      private long Z88modeloid ;
      private long A88modeloid ;
      private long Z89marcaid ;
      private long A89marcaid ;
      private long Z90categoriaid ;
      private long A90categoriaid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode23 ;
      private DateTime Z92productofecreg ;
      private DateTime A92productofecreg ;
      private DateTime Z93productofecultact ;
      private DateTime A93productofecultact ;
      private bool n87productodsc ;
      private bool n88modeloid ;
      private bool n89marcaid ;
      private bool n90categoriaid ;
      private bool n91productousuario ;
      private bool n92productofecreg ;
      private bool n93productofecultact ;
      private bool n25cambsid ;
      private bool n23tipobienid ;
      private bool Gx_longc ;
      private String Z87productodsc ;
      private String A87productodsc ;
      private String Z91productousuario ;
      private String A91productousuario ;
      private Sdtproducto bcproducto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00096_A175productoid ;
      private String[] BC00096_A87productodsc ;
      private bool[] BC00096_n87productodsc ;
      private long[] BC00096_A88modeloid ;
      private bool[] BC00096_n88modeloid ;
      private long[] BC00096_A89marcaid ;
      private bool[] BC00096_n89marcaid ;
      private long[] BC00096_A90categoriaid ;
      private bool[] BC00096_n90categoriaid ;
      private String[] BC00096_A91productousuario ;
      private bool[] BC00096_n91productousuario ;
      private DateTime[] BC00096_A92productofecreg ;
      private bool[] BC00096_n92productofecreg ;
      private DateTime[] BC00096_A93productofecultact ;
      private bool[] BC00096_n93productofecultact ;
      private int[] BC00096_A25cambsid ;
      private bool[] BC00096_n25cambsid ;
      private int[] BC00096_A23tipobienid ;
      private bool[] BC00096_n23tipobienid ;
      private int[] BC00094_A25cambsid ;
      private bool[] BC00094_n25cambsid ;
      private int[] BC00095_A23tipobienid ;
      private bool[] BC00095_n23tipobienid ;
      private int[] BC00097_A175productoid ;
      private int[] BC00093_A175productoid ;
      private String[] BC00093_A87productodsc ;
      private bool[] BC00093_n87productodsc ;
      private long[] BC00093_A88modeloid ;
      private bool[] BC00093_n88modeloid ;
      private long[] BC00093_A89marcaid ;
      private bool[] BC00093_n89marcaid ;
      private long[] BC00093_A90categoriaid ;
      private bool[] BC00093_n90categoriaid ;
      private String[] BC00093_A91productousuario ;
      private bool[] BC00093_n91productousuario ;
      private DateTime[] BC00093_A92productofecreg ;
      private bool[] BC00093_n92productofecreg ;
      private DateTime[] BC00093_A93productofecultact ;
      private bool[] BC00093_n93productofecultact ;
      private int[] BC00093_A25cambsid ;
      private bool[] BC00093_n25cambsid ;
      private int[] BC00093_A23tipobienid ;
      private bool[] BC00093_n23tipobienid ;
      private int[] BC00092_A175productoid ;
      private String[] BC00092_A87productodsc ;
      private bool[] BC00092_n87productodsc ;
      private long[] BC00092_A88modeloid ;
      private bool[] BC00092_n88modeloid ;
      private long[] BC00092_A89marcaid ;
      private bool[] BC00092_n89marcaid ;
      private long[] BC00092_A90categoriaid ;
      private bool[] BC00092_n90categoriaid ;
      private String[] BC00092_A91productousuario ;
      private bool[] BC00092_n91productousuario ;
      private DateTime[] BC00092_A92productofecreg ;
      private bool[] BC00092_n92productofecreg ;
      private DateTime[] BC00092_A93productofecultact ;
      private bool[] BC00092_n93productofecultact ;
      private int[] BC00092_A25cambsid ;
      private bool[] BC00092_n25cambsid ;
      private int[] BC00092_A23tipobienid ;
      private bool[] BC00092_n23tipobienid ;
      private int[] BC000911_A175productoid ;
      private String[] BC000911_A87productodsc ;
      private bool[] BC000911_n87productodsc ;
      private long[] BC000911_A88modeloid ;
      private bool[] BC000911_n88modeloid ;
      private long[] BC000911_A89marcaid ;
      private bool[] BC000911_n89marcaid ;
      private long[] BC000911_A90categoriaid ;
      private bool[] BC000911_n90categoriaid ;
      private String[] BC000911_A91productousuario ;
      private bool[] BC000911_n91productousuario ;
      private DateTime[] BC000911_A92productofecreg ;
      private bool[] BC000911_n92productofecreg ;
      private DateTime[] BC000911_A93productofecultact ;
      private bool[] BC000911_n93productofecultact ;
      private int[] BC000911_A25cambsid ;
      private bool[] BC000911_n25cambsid ;
      private int[] BC000911_A23tipobienid ;
      private bool[] BC000911_n23tipobienid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class producto_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00096 ;
          prmBC00096 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00094 ;
          prmBC00094 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00095 ;
          prmBC00095 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00097 ;
          prmBC00097 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00093 ;
          prmBC00093 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00092 ;
          prmBC00092 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00098 ;
          prmBC00098 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"marcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"categoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"productofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00099 ;
          prmBC00099 = new Object[] {
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"marcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"categoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"productofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000910 ;
          prmBC000910 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000911 ;
          prmBC000911 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00092", "SELECT productoid, productodsc, modeloid, marcaid, categoriaid, productousuario, productofecreg, productofecultact, cambsid, tipobienid FROM producto WHERE productoid = :productoid  FOR UPDATE OF producto",true, GxErrorMask.GX_NOMASK, false, this,prmBC00092,1,0,true,false )
             ,new CursorDef("BC00093", "SELECT productoid, productodsc, modeloid, marcaid, categoriaid, productousuario, productofecreg, productofecultact, cambsid, tipobienid FROM producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00093,1,0,true,false )
             ,new CursorDef("BC00094", "SELECT cambsid FROM public.cambs WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00094,1,0,true,false )
             ,new CursorDef("BC00095", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00095,1,0,true,false )
             ,new CursorDef("BC00096", "SELECT TM1.productoid, TM1.productodsc, TM1.modeloid, TM1.marcaid, TM1.categoriaid, TM1.productousuario, TM1.productofecreg, TM1.productofecultact, TM1.cambsid, TM1.tipobienid FROM producto TM1 WHERE TM1.productoid = :productoid ORDER BY TM1.productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00096,100,0,true,false )
             ,new CursorDef("BC00097", "SELECT productoid FROM producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00097,1,0,true,false )
             ,new CursorDef("BC00098", "SAVEPOINT gxupdate;INSERT INTO producto(productoid, productodsc, modeloid, marcaid, categoriaid, productousuario, productofecreg, productofecultact, cambsid, tipobienid) VALUES(:productoid, :productodsc, :modeloid, :marcaid, :categoriaid, :productousuario, :productofecreg, :productofecultact, :cambsid, :tipobienid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00098)
             ,new CursorDef("BC00099", "SAVEPOINT gxupdate;UPDATE producto SET productodsc=:productodsc, modeloid=:modeloid, marcaid=:marcaid, categoriaid=:categoriaid, productousuario=:productousuario, productofecreg=:productofecreg, productofecultact=:productofecultact, cambsid=:cambsid, tipobienid=:tipobienid  WHERE productoid = :productoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00099)
             ,new CursorDef("BC000910", "SAVEPOINT gxupdate;DELETE FROM producto  WHERE productoid = :productoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000910)
             ,new CursorDef("BC000911", "SELECT TM1.productoid, TM1.productodsc, TM1.modeloid, TM1.marcaid, TM1.categoriaid, TM1.productousuario, TM1.productofecreg, TM1.productofecultact, TM1.cambsid, TM1.tipobienid FROM producto TM1 WHERE TM1.productoid = :productoid ORDER BY TM1.productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000911,100,0,true,false )
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
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((int[]) buf[17])[0] = rslt.getInt(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((int[]) buf[17])[0] = rslt.getInt(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((int[]) buf[17])[0] = rslt.getInt(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((int[]) buf[17])[0] = rslt.getInt(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 6 :
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
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (long)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[8]);
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
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(9, (int)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[18]);
                }
                return;
             case 7 :
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (long)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (long)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[7]);
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
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(9, (int)parms[17]);
                }
                stmt.SetParameter(10, (int)parms[18]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
