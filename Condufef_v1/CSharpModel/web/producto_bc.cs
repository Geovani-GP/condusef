/*
               File: producto_BC
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:52.39
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
            Z179pcambsid = A179pcambsid;
            Z87productodsc = A87productodsc;
            Z180pmodeloid = A180pmodeloid;
            Z181pmarcaid = A181pmarcaid;
            Z182pcategoriaid = A182pcategoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z183ptipobienid = A183ptipobienid;
         }
         if ( GX_JID == -1 )
         {
            Z175productoid = A175productoid;
            Z179pcambsid = A179pcambsid;
            Z87productodsc = A87productodsc;
            Z180pmodeloid = A180pmodeloid;
            Z181pmarcaid = A181pmarcaid;
            Z182pcategoriaid = A182pcategoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z183ptipobienid = A183ptipobienid;
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
         /* Using cursor BC00094 */
         pr_default.execute(2, new Object[] {A175productoid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound23 = 1;
            A179pcambsid = BC00094_A179pcambsid[0];
            n179pcambsid = BC00094_n179pcambsid[0];
            A87productodsc = BC00094_A87productodsc[0];
            n87productodsc = BC00094_n87productodsc[0];
            A180pmodeloid = BC00094_A180pmodeloid[0];
            n180pmodeloid = BC00094_n180pmodeloid[0];
            A181pmarcaid = BC00094_A181pmarcaid[0];
            n181pmarcaid = BC00094_n181pmarcaid[0];
            A182pcategoriaid = BC00094_A182pcategoriaid[0];
            n182pcategoriaid = BC00094_n182pcategoriaid[0];
            A91productousuario = BC00094_A91productousuario[0];
            n91productousuario = BC00094_n91productousuario[0];
            A92productofecreg = BC00094_A92productofecreg[0];
            n92productofecreg = BC00094_n92productofecreg[0];
            A93productofecultact = BC00094_A93productofecultact[0];
            n93productofecultact = BC00094_n93productofecultact[0];
            A183ptipobienid = BC00094_A183ptipobienid[0];
            n183ptipobienid = BC00094_n183ptipobienid[0];
            ZM0923( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0923( ) ;
      }

      protected void OnLoadActions0923( )
      {
      }

      protected void CheckExtendedTable0923( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0923( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0923( )
      {
         /* Using cursor BC00095 */
         pr_default.execute(3, new Object[] {A175productoid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(3);
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
            A179pcambsid = BC00093_A179pcambsid[0];
            n179pcambsid = BC00093_n179pcambsid[0];
            A87productodsc = BC00093_A87productodsc[0];
            n87productodsc = BC00093_n87productodsc[0];
            A180pmodeloid = BC00093_A180pmodeloid[0];
            n180pmodeloid = BC00093_n180pmodeloid[0];
            A181pmarcaid = BC00093_A181pmarcaid[0];
            n181pmarcaid = BC00093_n181pmarcaid[0];
            A182pcategoriaid = BC00093_A182pcategoriaid[0];
            n182pcategoriaid = BC00093_n182pcategoriaid[0];
            A91productousuario = BC00093_A91productousuario[0];
            n91productousuario = BC00093_n91productousuario[0];
            A92productofecreg = BC00093_A92productofecreg[0];
            n92productofecreg = BC00093_n92productofecreg[0];
            A93productofecultact = BC00093_A93productofecultact[0];
            n93productofecultact = BC00093_n93productofecultact[0];
            A183ptipobienid = BC00093_A183ptipobienid[0];
            n183ptipobienid = BC00093_n183ptipobienid[0];
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
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PRODUCTO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z179pcambsid != BC00092_A179pcambsid[0] ) || ( StringUtil.StrCmp(Z87productodsc, BC00092_A87productodsc[0]) != 0 ) || ( Z180pmodeloid != BC00092_A180pmodeloid[0] ) || ( Z181pmarcaid != BC00092_A181pmarcaid[0] ) || ( Z182pcategoriaid != BC00092_A182pcategoriaid[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z91productousuario, BC00092_A91productousuario[0]) != 0 ) || ( Z92productofecreg != BC00092_A92productofecreg[0] ) || ( Z93productofecultact != BC00092_A93productofecultact[0] ) || ( Z183ptipobienid != BC00092_A183ptipobienid[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PRODUCTO"}), "RecordWasChanged", 1, "");
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
                     /* Using cursor BC00096 */
                     pr_default.execute(4, new Object[] {A175productoid, n179pcambsid, A179pcambsid, n87productodsc, A87productodsc, n180pmodeloid, A180pmodeloid, n181pmarcaid, A181pmarcaid, n182pcategoriaid, A182pcategoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n183ptipobienid, A183ptipobienid});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
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
                     /* Using cursor BC00097 */
                     pr_default.execute(5, new Object[] {n179pcambsid, A179pcambsid, n87productodsc, A87productodsc, n180pmodeloid, A180pmodeloid, n181pmarcaid, A181pmarcaid, n182pcategoriaid, A182pcategoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n183ptipobienid, A183ptipobienid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PRODUCTO"}), "RecordIsLocked", 1, "");
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
                  /* Using cursor BC00098 */
                  pr_default.execute(6);
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
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
         /* Using cursor BC00099 */
         pr_default.execute(7, new Object[] {A175productoid});
         RcdFound23 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = BC00099_A175productoid[0];
            A179pcambsid = BC00099_A179pcambsid[0];
            n179pcambsid = BC00099_n179pcambsid[0];
            A87productodsc = BC00099_A87productodsc[0];
            n87productodsc = BC00099_n87productodsc[0];
            A180pmodeloid = BC00099_A180pmodeloid[0];
            n180pmodeloid = BC00099_n180pmodeloid[0];
            A181pmarcaid = BC00099_A181pmarcaid[0];
            n181pmarcaid = BC00099_n181pmarcaid[0];
            A182pcategoriaid = BC00099_A182pcategoriaid[0];
            n182pcategoriaid = BC00099_n182pcategoriaid[0];
            A91productousuario = BC00099_A91productousuario[0];
            n91productousuario = BC00099_n91productousuario[0];
            A92productofecreg = BC00099_A92productofecreg[0];
            n92productofecreg = BC00099_n92productofecreg[0];
            A93productofecultact = BC00099_A93productofecultact[0];
            n93productofecultact = BC00099_n93productofecultact[0];
            A183ptipobienid = BC00099_A183ptipobienid[0];
            n183ptipobienid = BC00099_n183ptipobienid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0923( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound23 = 0;
         ScanKeyLoad0923( ) ;
      }

      protected void ScanKeyLoad0923( )
      {
         sMode23 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = BC00099_A175productoid[0];
            A179pcambsid = BC00099_A179pcambsid[0];
            n179pcambsid = BC00099_n179pcambsid[0];
            A87productodsc = BC00099_A87productodsc[0];
            n87productodsc = BC00099_n87productodsc[0];
            A180pmodeloid = BC00099_A180pmodeloid[0];
            n180pmodeloid = BC00099_n180pmodeloid[0];
            A181pmarcaid = BC00099_A181pmarcaid[0];
            n181pmarcaid = BC00099_n181pmarcaid[0];
            A182pcategoriaid = BC00099_A182pcategoriaid[0];
            n182pcategoriaid = BC00099_n182pcategoriaid[0];
            A91productousuario = BC00099_A91productousuario[0];
            n91productousuario = BC00099_n91productousuario[0];
            A92productofecreg = BC00099_A92productofecreg[0];
            n92productofecreg = BC00099_n92productofecreg[0];
            A93productofecultact = BC00099_A93productofecultact[0];
            n93productofecultact = BC00099_n93productofecultact[0];
            A183ptipobienid = BC00099_A183ptipobienid[0];
            n183ptipobienid = BC00099_n183ptipobienid[0];
         }
         Gx_mode = sMode23;
      }

      protected void ScanKeyEnd0923( )
      {
         pr_default.close(7);
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
         A179pcambsid = 0;
         n179pcambsid = false;
         A87productodsc = "";
         n87productodsc = false;
         A180pmodeloid = 0;
         n180pmodeloid = false;
         A181pmarcaid = 0;
         n181pmarcaid = false;
         A182pcategoriaid = 0;
         n182pcategoriaid = false;
         A91productousuario = "";
         n91productousuario = false;
         A92productofecreg = DateTime.MinValue;
         n92productofecreg = false;
         A93productofecultact = DateTime.MinValue;
         n93productofecultact = false;
         A183ptipobienid = 0;
         n183ptipobienid = false;
         Z179pcambsid = 0;
         Z87productodsc = "";
         Z180pmodeloid = 0;
         Z181pmarcaid = 0;
         Z182pcategoriaid = 0;
         Z91productousuario = "";
         Z92productofecreg = DateTime.MinValue;
         Z93productofecultact = DateTime.MinValue;
         Z183ptipobienid = 0;
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
         obj23.gxTpr_Pcambsid = A179pcambsid;
         obj23.gxTpr_Productodsc = A87productodsc;
         obj23.gxTpr_Pmodeloid = A180pmodeloid;
         obj23.gxTpr_Pmarcaid = A181pmarcaid;
         obj23.gxTpr_Pcategoriaid = A182pcategoriaid;
         obj23.gxTpr_Productousuario = A91productousuario;
         obj23.gxTpr_Productofecreg = A92productofecreg;
         obj23.gxTpr_Productofecultact = A93productofecultact;
         obj23.gxTpr_Ptipobienid = A183ptipobienid;
         obj23.gxTpr_Productoid = A175productoid;
         obj23.gxTpr_Productoid_Z = Z175productoid;
         obj23.gxTpr_Pcambsid_Z = Z179pcambsid;
         obj23.gxTpr_Productodsc_Z = Z87productodsc;
         obj23.gxTpr_Pmodeloid_Z = Z180pmodeloid;
         obj23.gxTpr_Pmarcaid_Z = Z181pmarcaid;
         obj23.gxTpr_Pcategoriaid_Z = Z182pcategoriaid;
         obj23.gxTpr_Productousuario_Z = Z91productousuario;
         obj23.gxTpr_Productofecreg_Z = Z92productofecreg;
         obj23.gxTpr_Productofecultact_Z = Z93productofecultact;
         obj23.gxTpr_Ptipobienid_Z = Z183ptipobienid;
         obj23.gxTpr_Pcambsid_N = (short)(Convert.ToInt16(n179pcambsid));
         obj23.gxTpr_Productodsc_N = (short)(Convert.ToInt16(n87productodsc));
         obj23.gxTpr_Pmodeloid_N = (short)(Convert.ToInt16(n180pmodeloid));
         obj23.gxTpr_Pmarcaid_N = (short)(Convert.ToInt16(n181pmarcaid));
         obj23.gxTpr_Pcategoriaid_N = (short)(Convert.ToInt16(n182pcategoriaid));
         obj23.gxTpr_Productousuario_N = (short)(Convert.ToInt16(n91productousuario));
         obj23.gxTpr_Productofecreg_N = (short)(Convert.ToInt16(n92productofecreg));
         obj23.gxTpr_Productofecultact_N = (short)(Convert.ToInt16(n93productofecultact));
         obj23.gxTpr_Ptipobienid_N = (short)(Convert.ToInt16(n183ptipobienid));
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
         A179pcambsid = obj23.gxTpr_Pcambsid;
         n179pcambsid = false;
         A87productodsc = obj23.gxTpr_Productodsc;
         n87productodsc = false;
         A180pmodeloid = obj23.gxTpr_Pmodeloid;
         n180pmodeloid = false;
         A181pmarcaid = obj23.gxTpr_Pmarcaid;
         n181pmarcaid = false;
         A182pcategoriaid = obj23.gxTpr_Pcategoriaid;
         n182pcategoriaid = false;
         A91productousuario = obj23.gxTpr_Productousuario;
         n91productousuario = false;
         A92productofecreg = obj23.gxTpr_Productofecreg;
         n92productofecreg = false;
         A93productofecultact = obj23.gxTpr_Productofecultact;
         n93productofecultact = false;
         A183ptipobienid = obj23.gxTpr_Ptipobienid;
         n183ptipobienid = false;
         A175productoid = obj23.gxTpr_Productoid;
         Z175productoid = obj23.gxTpr_Productoid_Z;
         Z179pcambsid = obj23.gxTpr_Pcambsid_Z;
         Z87productodsc = obj23.gxTpr_Productodsc_Z;
         Z180pmodeloid = obj23.gxTpr_Pmodeloid_Z;
         Z181pmarcaid = obj23.gxTpr_Pmarcaid_Z;
         Z182pcategoriaid = obj23.gxTpr_Pcategoriaid_Z;
         Z91productousuario = obj23.gxTpr_Productousuario_Z;
         Z92productofecreg = obj23.gxTpr_Productofecreg_Z;
         Z93productofecultact = obj23.gxTpr_Productofecultact_Z;
         Z183ptipobienid = obj23.gxTpr_Ptipobienid_Z;
         n179pcambsid = (bool)(Convert.ToBoolean(obj23.gxTpr_Pcambsid_N));
         n87productodsc = (bool)(Convert.ToBoolean(obj23.gxTpr_Productodsc_N));
         n180pmodeloid = (bool)(Convert.ToBoolean(obj23.gxTpr_Pmodeloid_N));
         n181pmarcaid = (bool)(Convert.ToBoolean(obj23.gxTpr_Pmarcaid_N));
         n182pcategoriaid = (bool)(Convert.ToBoolean(obj23.gxTpr_Pcategoriaid_N));
         n91productousuario = (bool)(Convert.ToBoolean(obj23.gxTpr_Productousuario_N));
         n92productofecreg = (bool)(Convert.ToBoolean(obj23.gxTpr_Productofecreg_N));
         n93productofecultact = (bool)(Convert.ToBoolean(obj23.gxTpr_Productofecultact_N));
         n183ptipobienid = (bool)(Convert.ToBoolean(obj23.gxTpr_Ptipobienid_N));
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
         Z92productofecreg = DateTime.MinValue;
         A92productofecreg = DateTime.MinValue;
         Z93productofecultact = DateTime.MinValue;
         A93productofecultact = DateTime.MinValue;
         BC00094_A175productoid = new int[1] ;
         BC00094_A179pcambsid = new short[1] ;
         BC00094_n179pcambsid = new bool[] {false} ;
         BC00094_A87productodsc = new String[] {""} ;
         BC00094_n87productodsc = new bool[] {false} ;
         BC00094_A180pmodeloid = new short[1] ;
         BC00094_n180pmodeloid = new bool[] {false} ;
         BC00094_A181pmarcaid = new short[1] ;
         BC00094_n181pmarcaid = new bool[] {false} ;
         BC00094_A182pcategoriaid = new short[1] ;
         BC00094_n182pcategoriaid = new bool[] {false} ;
         BC00094_A91productousuario = new String[] {""} ;
         BC00094_n91productousuario = new bool[] {false} ;
         BC00094_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00094_n92productofecreg = new bool[] {false} ;
         BC00094_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00094_n93productofecultact = new bool[] {false} ;
         BC00094_A183ptipobienid = new short[1] ;
         BC00094_n183ptipobienid = new bool[] {false} ;
         BC00095_A175productoid = new int[1] ;
         BC00093_A175productoid = new int[1] ;
         BC00093_A179pcambsid = new short[1] ;
         BC00093_n179pcambsid = new bool[] {false} ;
         BC00093_A87productodsc = new String[] {""} ;
         BC00093_n87productodsc = new bool[] {false} ;
         BC00093_A180pmodeloid = new short[1] ;
         BC00093_n180pmodeloid = new bool[] {false} ;
         BC00093_A181pmarcaid = new short[1] ;
         BC00093_n181pmarcaid = new bool[] {false} ;
         BC00093_A182pcategoriaid = new short[1] ;
         BC00093_n182pcategoriaid = new bool[] {false} ;
         BC00093_A91productousuario = new String[] {""} ;
         BC00093_n91productousuario = new bool[] {false} ;
         BC00093_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00093_n92productofecreg = new bool[] {false} ;
         BC00093_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00093_n93productofecultact = new bool[] {false} ;
         BC00093_A183ptipobienid = new short[1] ;
         BC00093_n183ptipobienid = new bool[] {false} ;
         sMode23 = "";
         BC00092_A175productoid = new int[1] ;
         BC00092_A179pcambsid = new short[1] ;
         BC00092_n179pcambsid = new bool[] {false} ;
         BC00092_A87productodsc = new String[] {""} ;
         BC00092_n87productodsc = new bool[] {false} ;
         BC00092_A180pmodeloid = new short[1] ;
         BC00092_n180pmodeloid = new bool[] {false} ;
         BC00092_A181pmarcaid = new short[1] ;
         BC00092_n181pmarcaid = new bool[] {false} ;
         BC00092_A182pcategoriaid = new short[1] ;
         BC00092_n182pcategoriaid = new bool[] {false} ;
         BC00092_A91productousuario = new String[] {""} ;
         BC00092_n91productousuario = new bool[] {false} ;
         BC00092_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00092_n92productofecreg = new bool[] {false} ;
         BC00092_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00092_n93productofecultact = new bool[] {false} ;
         BC00092_A183ptipobienid = new short[1] ;
         BC00092_n183ptipobienid = new bool[] {false} ;
         BC00099_A175productoid = new int[1] ;
         BC00099_A179pcambsid = new short[1] ;
         BC00099_n179pcambsid = new bool[] {false} ;
         BC00099_A87productodsc = new String[] {""} ;
         BC00099_n87productodsc = new bool[] {false} ;
         BC00099_A180pmodeloid = new short[1] ;
         BC00099_n180pmodeloid = new bool[] {false} ;
         BC00099_A181pmarcaid = new short[1] ;
         BC00099_n181pmarcaid = new bool[] {false} ;
         BC00099_A182pcategoriaid = new short[1] ;
         BC00099_n182pcategoriaid = new bool[] {false} ;
         BC00099_A91productousuario = new String[] {""} ;
         BC00099_n91productousuario = new bool[] {false} ;
         BC00099_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         BC00099_n92productofecreg = new bool[] {false} ;
         BC00099_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         BC00099_n93productofecultact = new bool[] {false} ;
         BC00099_A183ptipobienid = new short[1] ;
         BC00099_n183ptipobienid = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producto_bc__default(),
            new Object[][] {
                new Object[] {
               BC00092_A175productoid, BC00092_A179pcambsid, BC00092_n179pcambsid, BC00092_A87productodsc, BC00092_n87productodsc, BC00092_A180pmodeloid, BC00092_n180pmodeloid, BC00092_A181pmarcaid, BC00092_n181pmarcaid, BC00092_A182pcategoriaid,
               BC00092_n182pcategoriaid, BC00092_A91productousuario, BC00092_n91productousuario, BC00092_A92productofecreg, BC00092_n92productofecreg, BC00092_A93productofecultact, BC00092_n93productofecultact, BC00092_A183ptipobienid, BC00092_n183ptipobienid
               }
               , new Object[] {
               BC00093_A175productoid, BC00093_A179pcambsid, BC00093_n179pcambsid, BC00093_A87productodsc, BC00093_n87productodsc, BC00093_A180pmodeloid, BC00093_n180pmodeloid, BC00093_A181pmarcaid, BC00093_n181pmarcaid, BC00093_A182pcategoriaid,
               BC00093_n182pcategoriaid, BC00093_A91productousuario, BC00093_n91productousuario, BC00093_A92productofecreg, BC00093_n92productofecreg, BC00093_A93productofecultact, BC00093_n93productofecultact, BC00093_A183ptipobienid, BC00093_n183ptipobienid
               }
               , new Object[] {
               BC00094_A175productoid, BC00094_A179pcambsid, BC00094_n179pcambsid, BC00094_A87productodsc, BC00094_n87productodsc, BC00094_A180pmodeloid, BC00094_n180pmodeloid, BC00094_A181pmarcaid, BC00094_n181pmarcaid, BC00094_A182pcategoriaid,
               BC00094_n182pcategoriaid, BC00094_A91productousuario, BC00094_n91productousuario, BC00094_A92productofecreg, BC00094_n92productofecreg, BC00094_A93productofecultact, BC00094_n93productofecultact, BC00094_A183ptipobienid, BC00094_n183ptipobienid
               }
               , new Object[] {
               BC00095_A175productoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00099_A175productoid, BC00099_A179pcambsid, BC00099_n179pcambsid, BC00099_A87productodsc, BC00099_n87productodsc, BC00099_A180pmodeloid, BC00099_n180pmodeloid, BC00099_A181pmarcaid, BC00099_n181pmarcaid, BC00099_A182pcategoriaid,
               BC00099_n182pcategoriaid, BC00099_A91productousuario, BC00099_n91productousuario, BC00099_A92productofecreg, BC00099_n92productofecreg, BC00099_A93productofecultact, BC00099_n93productofecultact, BC00099_A183ptipobienid, BC00099_n183ptipobienid
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
      private short Z179pcambsid ;
      private short A179pcambsid ;
      private short Z180pmodeloid ;
      private short A180pmodeloid ;
      private short Z181pmarcaid ;
      private short A181pmarcaid ;
      private short Z182pcategoriaid ;
      private short A182pcategoriaid ;
      private short Z183ptipobienid ;
      private short A183ptipobienid ;
      private short RcdFound23 ;
      private int trnEnded ;
      private int Z175productoid ;
      private int A175productoid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode23 ;
      private DateTime Z92productofecreg ;
      private DateTime A92productofecreg ;
      private DateTime Z93productofecultact ;
      private DateTime A93productofecultact ;
      private bool n179pcambsid ;
      private bool n87productodsc ;
      private bool n180pmodeloid ;
      private bool n181pmarcaid ;
      private bool n182pcategoriaid ;
      private bool n91productousuario ;
      private bool n92productofecreg ;
      private bool n93productofecultact ;
      private bool n183ptipobienid ;
      private bool Gx_longc ;
      private String Z87productodsc ;
      private String A87productodsc ;
      private String Z91productousuario ;
      private String A91productousuario ;
      private Sdtproducto bcproducto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00094_A175productoid ;
      private short[] BC00094_A179pcambsid ;
      private bool[] BC00094_n179pcambsid ;
      private String[] BC00094_A87productodsc ;
      private bool[] BC00094_n87productodsc ;
      private short[] BC00094_A180pmodeloid ;
      private bool[] BC00094_n180pmodeloid ;
      private short[] BC00094_A181pmarcaid ;
      private bool[] BC00094_n181pmarcaid ;
      private short[] BC00094_A182pcategoriaid ;
      private bool[] BC00094_n182pcategoriaid ;
      private String[] BC00094_A91productousuario ;
      private bool[] BC00094_n91productousuario ;
      private DateTime[] BC00094_A92productofecreg ;
      private bool[] BC00094_n92productofecreg ;
      private DateTime[] BC00094_A93productofecultact ;
      private bool[] BC00094_n93productofecultact ;
      private short[] BC00094_A183ptipobienid ;
      private bool[] BC00094_n183ptipobienid ;
      private int[] BC00095_A175productoid ;
      private int[] BC00093_A175productoid ;
      private short[] BC00093_A179pcambsid ;
      private bool[] BC00093_n179pcambsid ;
      private String[] BC00093_A87productodsc ;
      private bool[] BC00093_n87productodsc ;
      private short[] BC00093_A180pmodeloid ;
      private bool[] BC00093_n180pmodeloid ;
      private short[] BC00093_A181pmarcaid ;
      private bool[] BC00093_n181pmarcaid ;
      private short[] BC00093_A182pcategoriaid ;
      private bool[] BC00093_n182pcategoriaid ;
      private String[] BC00093_A91productousuario ;
      private bool[] BC00093_n91productousuario ;
      private DateTime[] BC00093_A92productofecreg ;
      private bool[] BC00093_n92productofecreg ;
      private DateTime[] BC00093_A93productofecultact ;
      private bool[] BC00093_n93productofecultact ;
      private short[] BC00093_A183ptipobienid ;
      private bool[] BC00093_n183ptipobienid ;
      private int[] BC00092_A175productoid ;
      private short[] BC00092_A179pcambsid ;
      private bool[] BC00092_n179pcambsid ;
      private String[] BC00092_A87productodsc ;
      private bool[] BC00092_n87productodsc ;
      private short[] BC00092_A180pmodeloid ;
      private bool[] BC00092_n180pmodeloid ;
      private short[] BC00092_A181pmarcaid ;
      private bool[] BC00092_n181pmarcaid ;
      private short[] BC00092_A182pcategoriaid ;
      private bool[] BC00092_n182pcategoriaid ;
      private String[] BC00092_A91productousuario ;
      private bool[] BC00092_n91productousuario ;
      private DateTime[] BC00092_A92productofecreg ;
      private bool[] BC00092_n92productofecreg ;
      private DateTime[] BC00092_A93productofecultact ;
      private bool[] BC00092_n93productofecultact ;
      private short[] BC00092_A183ptipobienid ;
      private bool[] BC00092_n183ptipobienid ;
      private int[] BC00099_A175productoid ;
      private short[] BC00099_A179pcambsid ;
      private bool[] BC00099_n179pcambsid ;
      private String[] BC00099_A87productodsc ;
      private bool[] BC00099_n87productodsc ;
      private short[] BC00099_A180pmodeloid ;
      private bool[] BC00099_n180pmodeloid ;
      private short[] BC00099_A181pmarcaid ;
      private bool[] BC00099_n181pmarcaid ;
      private short[] BC00099_A182pcategoriaid ;
      private bool[] BC00099_n182pcategoriaid ;
      private String[] BC00099_A91productousuario ;
      private bool[] BC00099_n91productousuario ;
      private DateTime[] BC00099_A92productofecreg ;
      private bool[] BC00099_n92productofecreg ;
      private DateTime[] BC00099_A93productofecultact ;
      private bool[] BC00099_n93productofecultact ;
      private short[] BC00099_A183ptipobienid ;
      private bool[] BC00099_n183ptipobienid ;
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
          Object[] prmBC00094 ;
          prmBC00094 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC00095 ;
          prmBC00095 = new Object[] {
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
          Object[] prmBC00096 ;
          prmBC00096 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"pcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"pmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pmarcaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pcategoriaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"productofecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"ptipobienid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC00097 ;
          prmBC00097 = new Object[] {
          new Object[] {"pcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"pmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pmarcaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pcategoriaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"productofecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"ptipobienid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmBC00098 ;
          prmBC00098 = new Object[] {
          } ;
          Object[] prmBC00099 ;
          prmBC00099 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00092", "SELECT productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid FROM public.producto WHERE productoid = :productoid  FOR UPDATE OF producto",true, GxErrorMask.GX_NOMASK, false, this,prmBC00092,1,0,true,false )
             ,new CursorDef("BC00093", "SELECT productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid FROM public.producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00093,1,0,true,false )
             ,new CursorDef("BC00094", "SELECT TM1.productoid, TM1.pcambsid, TM1.productodsc, TM1.pmodeloid, TM1.pmarcaid, TM1.pcategoriaid, TM1.productousuario, TM1.productofecreg, TM1.productofecultact, TM1.ptipobienid FROM public.producto TM1 WHERE TM1.productoid = :productoid ORDER BY TM1.productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00094,100,0,true,false )
             ,new CursorDef("BC00095", "SELECT productoid FROM public.producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00095,1,0,true,false )
             ,new CursorDef("BC00096", "SAVEPOINT gxupdate;INSERT INTO public.producto(productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid) VALUES(:productoid, :pcambsid, :productodsc, :pmodeloid, :pmarcaid, :pcategoriaid, :productousuario, :productofecreg, :productofecultact, :ptipobienid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC00096)
             ,new CursorDef("BC00097", "SAVEPOINT gxupdate;UPDATE public.producto SET pcambsid=:pcambsid, productodsc=:productodsc, pmodeloid=:pmodeloid, pmarcaid=:pmarcaid, pcategoriaid=:pcategoriaid, productousuario=:productousuario, productofecreg=:productofecreg, productofecultact=:productofecultact, ptipobienid=:ptipobienid ;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00097)
             ,new CursorDef("BC00098", "SAVEPOINT gxupdate;DELETE FROM public.producto ;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC00098)
             ,new CursorDef("BC00099", "SELECT TM1.productoid, TM1.pcambsid, TM1.productodsc, TM1.pmodeloid, TM1.pmarcaid, TM1.pcategoriaid, TM1.productousuario, TM1.productofecreg, TM1.productofecultact, TM1.ptipobienid FROM public.producto TM1 WHERE TM1.productoid = :productoid ORDER BY TM1.productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00099,100,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
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
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[18]);
                }
                return;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[17]);
                }
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
