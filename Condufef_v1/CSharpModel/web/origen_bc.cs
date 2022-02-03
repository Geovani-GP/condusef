/*
               File: origen_BC
        Description: origen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:45.10
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
   public class origen_bc : GXHttpHandler, IGxSilentTrn
   {
      public origen_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public origen_bc( IGxContext context )
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
         ReadRow0G16( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0G16( ) ;
         standaloneModal( ) ;
         AddRow0G16( ) ;
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
               Z10origenid = A10origenid;
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G16( ) ;
            }
            else
            {
               CheckExtendedTable0G16( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0G16( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0G16( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z120origendscorta = A120origendscorta;
            Z121origendsclarga = A121origendsclarga;
            Z122origenusuario = A122origenusuario;
            Z123origentotal = A123origentotal;
            Z124origenfecreg = A124origenfecreg;
            Z125origenfecultact = A125origenfecultact;
         }
         if ( GX_JID == -1 )
         {
            Z10origenid = A10origenid;
            Z120origendscorta = A120origendscorta;
            Z121origendsclarga = A121origendsclarga;
            Z122origenusuario = A122origenusuario;
            Z123origentotal = A123origentotal;
            Z124origenfecreg = A124origenfecreg;
            Z125origenfecultact = A125origenfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0G16( )
      {
         /* Using cursor BC000G4 */
         pr_default.execute(2, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound16 = 1;
            A120origendscorta = BC000G4_A120origendscorta[0];
            n120origendscorta = BC000G4_n120origendscorta[0];
            A121origendsclarga = BC000G4_A121origendsclarga[0];
            n121origendsclarga = BC000G4_n121origendsclarga[0];
            A122origenusuario = BC000G4_A122origenusuario[0];
            n122origenusuario = BC000G4_n122origenusuario[0];
            A123origentotal = BC000G4_A123origentotal[0];
            n123origentotal = BC000G4_n123origentotal[0];
            A124origenfecreg = BC000G4_A124origenfecreg[0];
            n124origenfecreg = BC000G4_n124origenfecreg[0];
            A125origenfecultact = BC000G4_A125origenfecultact[0];
            n125origenfecultact = BC000G4_n125origenfecultact[0];
            ZM0G16( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0G16( ) ;
      }

      protected void OnLoadActions0G16( )
      {
      }

      protected void CheckExtendedTable0G16( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0G16( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0G16( )
      {
         /* Using cursor BC000G5 */
         pr_default.execute(3, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound16 = 1;
         }
         else
         {
            RcdFound16 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000G3 */
         pr_default.execute(1, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G16( 1) ;
            RcdFound16 = 1;
            A10origenid = BC000G3_A10origenid[0];
            n10origenid = BC000G3_n10origenid[0];
            A120origendscorta = BC000G3_A120origendscorta[0];
            n120origendscorta = BC000G3_n120origendscorta[0];
            A121origendsclarga = BC000G3_A121origendsclarga[0];
            n121origendsclarga = BC000G3_n121origendsclarga[0];
            A122origenusuario = BC000G3_A122origenusuario[0];
            n122origenusuario = BC000G3_n122origenusuario[0];
            A123origentotal = BC000G3_A123origentotal[0];
            n123origentotal = BC000G3_n123origentotal[0];
            A124origenfecreg = BC000G3_A124origenfecreg[0];
            n124origenfecreg = BC000G3_n124origenfecreg[0];
            A125origenfecultact = BC000G3_A125origenfecultact[0];
            n125origenfecultact = BC000G3_n125origenfecultact[0];
            Z10origenid = A10origenid;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0G16( ) ;
            if ( AnyError == 1 )
            {
               RcdFound16 = 0;
               InitializeNonKey0G16( ) ;
            }
            Gx_mode = sMode16;
         }
         else
         {
            RcdFound16 = 0;
            InitializeNonKey0G16( ) ;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode16;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G16( ) ;
         if ( RcdFound16 == 0 )
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
         CONFIRM_0G0( ) ;
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

      protected void CheckOptimisticConcurrency0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000G2 */
            pr_default.execute(0, new Object[] {n10origenid, A10origenid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ORIGEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z120origendscorta, BC000G2_A120origendscorta[0]) != 0 ) || ( StringUtil.StrCmp(Z121origendsclarga, BC000G2_A121origendsclarga[0]) != 0 ) || ( StringUtil.StrCmp(Z122origenusuario, BC000G2_A122origenusuario[0]) != 0 ) || ( StringUtil.StrCmp(Z123origentotal, BC000G2_A123origentotal[0]) != 0 ) || ( Z124origenfecreg != BC000G2_A124origenfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z125origenfecultact != BC000G2_A125origenfecultact[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ORIGEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G16( 0) ;
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000G6 */
                     pr_default.execute(4, new Object[] {n10origenid, A10origenid, n120origendscorta, A120origendscorta, n121origendsclarga, A121origendsclarga, n122origenusuario, A122origenusuario, n123origentotal, A123origentotal, n124origenfecreg, A124origenfecreg, n125origenfecultact, A125origenfecultact});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
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
               Load0G16( ) ;
            }
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void Update0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000G7 */
                     pr_default.execute(5, new Object[] {n120origendscorta, A120origendscorta, n121origendsclarga, A121origendsclarga, n122origenusuario, A122origenusuario, n123origentotal, A123origentotal, n124origenfecreg, A124origenfecreg, n125origenfecultact, A125origenfecultact, n10origenid, A10origenid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ORIGEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0G16( ) ;
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
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void DeferredUpdate0G16( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G16( ) ;
            AfterConfirm0G16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G16( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000G8 */
                  pr_default.execute(6, new Object[] {n10origenid, A10origenid});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
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
         sMode16 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0G16( ) ;
         Gx_mode = sMode16;
      }

      protected void OnDeleteControls0G16( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000G9 */
            pr_default.execute(7, new Object[] {n10origenid, A10origenid});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G16( ) ;
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

      public void ScanKeyStart0G16( )
      {
         /* Using cursor BC000G10 */
         pr_default.execute(8, new Object[] {n10origenid, A10origenid});
         RcdFound16 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound16 = 1;
            A10origenid = BC000G10_A10origenid[0];
            n10origenid = BC000G10_n10origenid[0];
            A120origendscorta = BC000G10_A120origendscorta[0];
            n120origendscorta = BC000G10_n120origendscorta[0];
            A121origendsclarga = BC000G10_A121origendsclarga[0];
            n121origendsclarga = BC000G10_n121origendsclarga[0];
            A122origenusuario = BC000G10_A122origenusuario[0];
            n122origenusuario = BC000G10_n122origenusuario[0];
            A123origentotal = BC000G10_A123origentotal[0];
            n123origentotal = BC000G10_n123origentotal[0];
            A124origenfecreg = BC000G10_A124origenfecreg[0];
            n124origenfecreg = BC000G10_n124origenfecreg[0];
            A125origenfecultact = BC000G10_A125origenfecultact[0];
            n125origenfecultact = BC000G10_n125origenfecultact[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0G16( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound16 = 0;
         ScanKeyLoad0G16( ) ;
      }

      protected void ScanKeyLoad0G16( )
      {
         sMode16 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound16 = 1;
            A10origenid = BC000G10_A10origenid[0];
            n10origenid = BC000G10_n10origenid[0];
            A120origendscorta = BC000G10_A120origendscorta[0];
            n120origendscorta = BC000G10_n120origendscorta[0];
            A121origendsclarga = BC000G10_A121origendsclarga[0];
            n121origendsclarga = BC000G10_n121origendsclarga[0];
            A122origenusuario = BC000G10_A122origenusuario[0];
            n122origenusuario = BC000G10_n122origenusuario[0];
            A123origentotal = BC000G10_A123origentotal[0];
            n123origentotal = BC000G10_n123origentotal[0];
            A124origenfecreg = BC000G10_A124origenfecreg[0];
            n124origenfecreg = BC000G10_n124origenfecreg[0];
            A125origenfecultact = BC000G10_A125origenfecultact[0];
            n125origenfecultact = BC000G10_n125origenfecultact[0];
         }
         Gx_mode = sMode16;
      }

      protected void ScanKeyEnd0G16( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0G16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0G16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0G16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G16( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0G16( )
      {
      }

      protected void AddRow0G16( )
      {
         VarsToRow16( bcorigen) ;
      }

      protected void ReadRow0G16( )
      {
         RowToVars16( bcorigen, 1) ;
      }

      protected void InitializeNonKey0G16( )
      {
         A120origendscorta = "";
         n120origendscorta = false;
         A121origendsclarga = "";
         n121origendsclarga = false;
         A122origenusuario = "";
         n122origenusuario = false;
         A123origentotal = "";
         n123origentotal = false;
         A124origenfecreg = (DateTime)(DateTime.MinValue);
         n124origenfecreg = false;
         A125origenfecultact = (DateTime)(DateTime.MinValue);
         n125origenfecultact = false;
         Z120origendscorta = "";
         Z121origendsclarga = "";
         Z122origenusuario = "";
         Z123origentotal = "";
         Z124origenfecreg = (DateTime)(DateTime.MinValue);
         Z125origenfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0G16( )
      {
         A10origenid = 0;
         n10origenid = false;
         InitializeNonKey0G16( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow16( Sdtorigen obj16 )
      {
         obj16.gxTpr_Mode = Gx_mode;
         obj16.gxTpr_Origendscorta = A120origendscorta;
         obj16.gxTpr_Origendsclarga = A121origendsclarga;
         obj16.gxTpr_Origenusuario = A122origenusuario;
         obj16.gxTpr_Origentotal = A123origentotal;
         obj16.gxTpr_Origenfecreg = A124origenfecreg;
         obj16.gxTpr_Origenfecultact = A125origenfecultact;
         obj16.gxTpr_Origenid = A10origenid;
         obj16.gxTpr_Origenid_Z = Z10origenid;
         obj16.gxTpr_Origendscorta_Z = Z120origendscorta;
         obj16.gxTpr_Origendsclarga_Z = Z121origendsclarga;
         obj16.gxTpr_Origenusuario_Z = Z122origenusuario;
         obj16.gxTpr_Origentotal_Z = Z123origentotal;
         obj16.gxTpr_Origenfecreg_Z = Z124origenfecreg;
         obj16.gxTpr_Origenfecultact_Z = Z125origenfecultact;
         obj16.gxTpr_Origenid_N = (short)(Convert.ToInt16(n10origenid));
         obj16.gxTpr_Origendscorta_N = (short)(Convert.ToInt16(n120origendscorta));
         obj16.gxTpr_Origendsclarga_N = (short)(Convert.ToInt16(n121origendsclarga));
         obj16.gxTpr_Origenusuario_N = (short)(Convert.ToInt16(n122origenusuario));
         obj16.gxTpr_Origentotal_N = (short)(Convert.ToInt16(n123origentotal));
         obj16.gxTpr_Origenfecreg_N = (short)(Convert.ToInt16(n124origenfecreg));
         obj16.gxTpr_Origenfecultact_N = (short)(Convert.ToInt16(n125origenfecultact));
         obj16.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow16( Sdtorigen obj16 )
      {
         obj16.gxTpr_Origenid = A10origenid;
         return  ;
      }

      public void RowToVars16( Sdtorigen obj16 ,
                               int forceLoad )
      {
         Gx_mode = obj16.gxTpr_Mode;
         A120origendscorta = obj16.gxTpr_Origendscorta;
         n120origendscorta = false;
         A121origendsclarga = obj16.gxTpr_Origendsclarga;
         n121origendsclarga = false;
         A122origenusuario = obj16.gxTpr_Origenusuario;
         n122origenusuario = false;
         A123origentotal = obj16.gxTpr_Origentotal;
         n123origentotal = false;
         A124origenfecreg = obj16.gxTpr_Origenfecreg;
         n124origenfecreg = false;
         A125origenfecultact = obj16.gxTpr_Origenfecultact;
         n125origenfecultact = false;
         A10origenid = obj16.gxTpr_Origenid;
         n10origenid = false;
         Z10origenid = obj16.gxTpr_Origenid_Z;
         Z120origendscorta = obj16.gxTpr_Origendscorta_Z;
         Z121origendsclarga = obj16.gxTpr_Origendsclarga_Z;
         Z122origenusuario = obj16.gxTpr_Origenusuario_Z;
         Z123origentotal = obj16.gxTpr_Origentotal_Z;
         Z124origenfecreg = obj16.gxTpr_Origenfecreg_Z;
         Z125origenfecultact = obj16.gxTpr_Origenfecultact_Z;
         n10origenid = (bool)(Convert.ToBoolean(obj16.gxTpr_Origenid_N));
         n120origendscorta = (bool)(Convert.ToBoolean(obj16.gxTpr_Origendscorta_N));
         n121origendsclarga = (bool)(Convert.ToBoolean(obj16.gxTpr_Origendsclarga_N));
         n122origenusuario = (bool)(Convert.ToBoolean(obj16.gxTpr_Origenusuario_N));
         n123origentotal = (bool)(Convert.ToBoolean(obj16.gxTpr_Origentotal_N));
         n124origenfecreg = (bool)(Convert.ToBoolean(obj16.gxTpr_Origenfecreg_N));
         n125origenfecultact = (bool)(Convert.ToBoolean(obj16.gxTpr_Origenfecultact_N));
         Gx_mode = obj16.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A10origenid = (long)getParm(obj,0);
         n10origenid = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0G16( ) ;
         ScanKeyStart0G16( ) ;
         if ( RcdFound16 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z10origenid = A10origenid;
         }
         ZM0G16( -1) ;
         OnLoadActions0G16( ) ;
         AddRow0G16( ) ;
         ScanKeyEnd0G16( ) ;
         if ( RcdFound16 == 0 )
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
         RowToVars16( bcorigen, 0) ;
         ScanKeyStart0G16( ) ;
         if ( RcdFound16 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z10origenid = A10origenid;
         }
         ZM0G16( -1) ;
         OnLoadActions0G16( ) ;
         AddRow0G16( ) ;
         ScanKeyEnd0G16( ) ;
         if ( RcdFound16 == 0 )
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
         RowToVars16( bcorigen, 0) ;
         nKeyPressed = 1;
         GetKey0G16( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0G16( ) ;
         }
         else
         {
            if ( RcdFound16 == 1 )
            {
               if ( A10origenid != Z10origenid )
               {
                  A10origenid = Z10origenid;
                  n10origenid = false;
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
                  Update0G16( ) ;
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
                  if ( A10origenid != Z10origenid )
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
                        Insert0G16( ) ;
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
                        Insert0G16( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow16( bcorigen) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars16( bcorigen, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0G16( ) ;
         if ( RcdFound16 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A10origenid != Z10origenid )
            {
               A10origenid = Z10origenid;
               n10origenid = false;
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
            if ( A10origenid != Z10origenid )
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
         context.RollbackDataStores( "origen_BC");
         VarsToRow16( bcorigen) ;
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
         Gx_mode = bcorigen.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcorigen.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcorigen )
         {
            bcorigen = (Sdtorigen)(sdt);
            if ( StringUtil.StrCmp(bcorigen.gxTpr_Mode, "") == 0 )
            {
               bcorigen.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow16( bcorigen) ;
            }
            else
            {
               RowToVars16( bcorigen, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcorigen.gxTpr_Mode, "") == 0 )
            {
               bcorigen.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars16( bcorigen, 1) ;
         return  ;
      }

      public Sdtorigen origen_BC
      {
         get {
            return bcorigen ;
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
         Z120origendscorta = "";
         A120origendscorta = "";
         Z121origendsclarga = "";
         A121origendsclarga = "";
         Z122origenusuario = "";
         A122origenusuario = "";
         Z123origentotal = "";
         A123origentotal = "";
         Z124origenfecreg = (DateTime)(DateTime.MinValue);
         A124origenfecreg = (DateTime)(DateTime.MinValue);
         Z125origenfecultact = (DateTime)(DateTime.MinValue);
         A125origenfecultact = (DateTime)(DateTime.MinValue);
         BC000G4_A10origenid = new long[1] ;
         BC000G4_n10origenid = new bool[] {false} ;
         BC000G4_A120origendscorta = new String[] {""} ;
         BC000G4_n120origendscorta = new bool[] {false} ;
         BC000G4_A121origendsclarga = new String[] {""} ;
         BC000G4_n121origendsclarga = new bool[] {false} ;
         BC000G4_A122origenusuario = new String[] {""} ;
         BC000G4_n122origenusuario = new bool[] {false} ;
         BC000G4_A123origentotal = new String[] {""} ;
         BC000G4_n123origentotal = new bool[] {false} ;
         BC000G4_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000G4_n124origenfecreg = new bool[] {false} ;
         BC000G4_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000G4_n125origenfecultact = new bool[] {false} ;
         BC000G5_A10origenid = new long[1] ;
         BC000G5_n10origenid = new bool[] {false} ;
         BC000G3_A10origenid = new long[1] ;
         BC000G3_n10origenid = new bool[] {false} ;
         BC000G3_A120origendscorta = new String[] {""} ;
         BC000G3_n120origendscorta = new bool[] {false} ;
         BC000G3_A121origendsclarga = new String[] {""} ;
         BC000G3_n121origendsclarga = new bool[] {false} ;
         BC000G3_A122origenusuario = new String[] {""} ;
         BC000G3_n122origenusuario = new bool[] {false} ;
         BC000G3_A123origentotal = new String[] {""} ;
         BC000G3_n123origentotal = new bool[] {false} ;
         BC000G3_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000G3_n124origenfecreg = new bool[] {false} ;
         BC000G3_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000G3_n125origenfecultact = new bool[] {false} ;
         sMode16 = "";
         BC000G2_A10origenid = new long[1] ;
         BC000G2_n10origenid = new bool[] {false} ;
         BC000G2_A120origendscorta = new String[] {""} ;
         BC000G2_n120origendscorta = new bool[] {false} ;
         BC000G2_A121origendsclarga = new String[] {""} ;
         BC000G2_n121origendsclarga = new bool[] {false} ;
         BC000G2_A122origenusuario = new String[] {""} ;
         BC000G2_n122origenusuario = new bool[] {false} ;
         BC000G2_A123origentotal = new String[] {""} ;
         BC000G2_n123origentotal = new bool[] {false} ;
         BC000G2_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000G2_n124origenfecreg = new bool[] {false} ;
         BC000G2_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000G2_n125origenfecultact = new bool[] {false} ;
         BC000G9_A19almacenid = new int[1] ;
         BC000G9_A20articulosproductoid = new int[1] ;
         BC000G9_A21articuloscambsid = new int[1] ;
         BC000G10_A10origenid = new long[1] ;
         BC000G10_n10origenid = new bool[] {false} ;
         BC000G10_A120origendscorta = new String[] {""} ;
         BC000G10_n120origendscorta = new bool[] {false} ;
         BC000G10_A121origendsclarga = new String[] {""} ;
         BC000G10_n121origendsclarga = new bool[] {false} ;
         BC000G10_A122origenusuario = new String[] {""} ;
         BC000G10_n122origenusuario = new bool[] {false} ;
         BC000G10_A123origentotal = new String[] {""} ;
         BC000G10_n123origentotal = new bool[] {false} ;
         BC000G10_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000G10_n124origenfecreg = new bool[] {false} ;
         BC000G10_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000G10_n125origenfecultact = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.origen_bc__default(),
            new Object[][] {
                new Object[] {
               BC000G2_A10origenid, BC000G2_A120origendscorta, BC000G2_n120origendscorta, BC000G2_A121origendsclarga, BC000G2_n121origendsclarga, BC000G2_A122origenusuario, BC000G2_n122origenusuario, BC000G2_A123origentotal, BC000G2_n123origentotal, BC000G2_A124origenfecreg,
               BC000G2_n124origenfecreg, BC000G2_A125origenfecultact, BC000G2_n125origenfecultact
               }
               , new Object[] {
               BC000G3_A10origenid, BC000G3_A120origendscorta, BC000G3_n120origendscorta, BC000G3_A121origendsclarga, BC000G3_n121origendsclarga, BC000G3_A122origenusuario, BC000G3_n122origenusuario, BC000G3_A123origentotal, BC000G3_n123origentotal, BC000G3_A124origenfecreg,
               BC000G3_n124origenfecreg, BC000G3_A125origenfecultact, BC000G3_n125origenfecultact
               }
               , new Object[] {
               BC000G4_A10origenid, BC000G4_A120origendscorta, BC000G4_n120origendscorta, BC000G4_A121origendsclarga, BC000G4_n121origendsclarga, BC000G4_A122origenusuario, BC000G4_n122origenusuario, BC000G4_A123origentotal, BC000G4_n123origentotal, BC000G4_A124origenfecreg,
               BC000G4_n124origenfecreg, BC000G4_A125origenfecultact, BC000G4_n125origenfecultact
               }
               , new Object[] {
               BC000G5_A10origenid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000G9_A19almacenid, BC000G9_A20articulosproductoid, BC000G9_A21articuloscambsid
               }
               , new Object[] {
               BC000G10_A10origenid, BC000G10_A120origendscorta, BC000G10_n120origendscorta, BC000G10_A121origendsclarga, BC000G10_n121origendsclarga, BC000G10_A122origenusuario, BC000G10_n122origenusuario, BC000G10_A123origentotal, BC000G10_n123origentotal, BC000G10_A124origenfecreg,
               BC000G10_n124origenfecreg, BC000G10_A125origenfecultact, BC000G10_n125origenfecultact
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
      private short RcdFound16 ;
      private int trnEnded ;
      private long Z10origenid ;
      private long A10origenid ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode16 ;
      private DateTime Z124origenfecreg ;
      private DateTime A124origenfecreg ;
      private DateTime Z125origenfecultact ;
      private DateTime A125origenfecultact ;
      private bool n10origenid ;
      private bool n120origendscorta ;
      private bool n121origendsclarga ;
      private bool n122origenusuario ;
      private bool n123origentotal ;
      private bool n124origenfecreg ;
      private bool n125origenfecultact ;
      private bool Gx_longc ;
      private String Z120origendscorta ;
      private String A120origendscorta ;
      private String Z121origendsclarga ;
      private String A121origendsclarga ;
      private String Z122origenusuario ;
      private String A122origenusuario ;
      private String Z123origentotal ;
      private String A123origentotal ;
      private Sdtorigen bcorigen ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000G4_A10origenid ;
      private bool[] BC000G4_n10origenid ;
      private String[] BC000G4_A120origendscorta ;
      private bool[] BC000G4_n120origendscorta ;
      private String[] BC000G4_A121origendsclarga ;
      private bool[] BC000G4_n121origendsclarga ;
      private String[] BC000G4_A122origenusuario ;
      private bool[] BC000G4_n122origenusuario ;
      private String[] BC000G4_A123origentotal ;
      private bool[] BC000G4_n123origentotal ;
      private DateTime[] BC000G4_A124origenfecreg ;
      private bool[] BC000G4_n124origenfecreg ;
      private DateTime[] BC000G4_A125origenfecultact ;
      private bool[] BC000G4_n125origenfecultact ;
      private long[] BC000G5_A10origenid ;
      private bool[] BC000G5_n10origenid ;
      private long[] BC000G3_A10origenid ;
      private bool[] BC000G3_n10origenid ;
      private String[] BC000G3_A120origendscorta ;
      private bool[] BC000G3_n120origendscorta ;
      private String[] BC000G3_A121origendsclarga ;
      private bool[] BC000G3_n121origendsclarga ;
      private String[] BC000G3_A122origenusuario ;
      private bool[] BC000G3_n122origenusuario ;
      private String[] BC000G3_A123origentotal ;
      private bool[] BC000G3_n123origentotal ;
      private DateTime[] BC000G3_A124origenfecreg ;
      private bool[] BC000G3_n124origenfecreg ;
      private DateTime[] BC000G3_A125origenfecultact ;
      private bool[] BC000G3_n125origenfecultact ;
      private long[] BC000G2_A10origenid ;
      private bool[] BC000G2_n10origenid ;
      private String[] BC000G2_A120origendscorta ;
      private bool[] BC000G2_n120origendscorta ;
      private String[] BC000G2_A121origendsclarga ;
      private bool[] BC000G2_n121origendsclarga ;
      private String[] BC000G2_A122origenusuario ;
      private bool[] BC000G2_n122origenusuario ;
      private String[] BC000G2_A123origentotal ;
      private bool[] BC000G2_n123origentotal ;
      private DateTime[] BC000G2_A124origenfecreg ;
      private bool[] BC000G2_n124origenfecreg ;
      private DateTime[] BC000G2_A125origenfecultact ;
      private bool[] BC000G2_n125origenfecultact ;
      private int[] BC000G9_A19almacenid ;
      private int[] BC000G9_A20articulosproductoid ;
      private int[] BC000G9_A21articuloscambsid ;
      private long[] BC000G10_A10origenid ;
      private bool[] BC000G10_n10origenid ;
      private String[] BC000G10_A120origendscorta ;
      private bool[] BC000G10_n120origendscorta ;
      private String[] BC000G10_A121origendsclarga ;
      private bool[] BC000G10_n121origendsclarga ;
      private String[] BC000G10_A122origenusuario ;
      private bool[] BC000G10_n122origenusuario ;
      private String[] BC000G10_A123origentotal ;
      private bool[] BC000G10_n123origentotal ;
      private DateTime[] BC000G10_A124origenfecreg ;
      private bool[] BC000G10_n124origenfecreg ;
      private DateTime[] BC000G10_A125origenfecultact ;
      private bool[] BC000G10_n125origenfecultact ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class origen_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC000G4 ;
          prmBC000G4 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G5 ;
          prmBC000G5 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G3 ;
          prmBC000G3 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G2 ;
          prmBC000G2 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G6 ;
          prmBC000G6 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"origendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"origenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"origentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmBC000G7 ;
          prmBC000G7 = new Object[] {
          new Object[] {"origendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"origenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"origentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G8 ;
          prmBC000G8 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G9 ;
          prmBC000G9 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmBC000G10 ;
          prmBC000G10 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000G2", "SELECT origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact FROM public.origen WHERE origenid = :origenid  FOR UPDATE OF origen",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G2,1,0,true,false )
             ,new CursorDef("BC000G3", "SELECT origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G3,1,0,true,false )
             ,new CursorDef("BC000G4", "SELECT TM1.origenid, TM1.origendscorta, TM1.origendsclarga, TM1.origenusuario, TM1.origentotal, TM1.origenfecreg, TM1.origenfecultact FROM public.origen TM1 WHERE TM1.origenid = :origenid ORDER BY TM1.origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G4,100,0,true,false )
             ,new CursorDef("BC000G5", "SELECT origenid FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G5,1,0,true,false )
             ,new CursorDef("BC000G6", "SAVEPOINT gxupdate;INSERT INTO public.origen(origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact) VALUES(:origenid, :origendscorta, :origendsclarga, :origenusuario, :origentotal, :origenfecreg, :origenfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmBC000G6)
             ,new CursorDef("BC000G7", "SAVEPOINT gxupdate;UPDATE public.origen SET origendscorta=:origendscorta, origendsclarga=:origendsclarga, origenusuario=:origenusuario, origentotal=:origentotal, origenfecreg=:origenfecreg, origenfecultact=:origenfecultact  WHERE origenid = :origenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000G7)
             ,new CursorDef("BC000G8", "SAVEPOINT gxupdate;DELETE FROM public.origen  WHERE origenid = :origenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000G8)
             ,new CursorDef("BC000G9", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G9,1,0,true,true )
             ,new CursorDef("BC000G10", "SELECT TM1.origenid, TM1.origendscorta, TM1.origendsclarga, TM1.origenusuario, TM1.origentotal, TM1.origenfecreg, TM1.origenfecultact FROM public.origen TM1 WHERE TM1.origenid = :origenid ORDER BY TM1.origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G10,100,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[13]);
                }
                return;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
       }
    }

 }

}
