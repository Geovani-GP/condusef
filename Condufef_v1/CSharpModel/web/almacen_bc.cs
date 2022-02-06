/*
               File: almacen_BC
        Description: almacen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/5/2022 15:59:33.59
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
   public class almacen_bc : GXHttpHandler, IGxSilentTrn
   {
      public almacen_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public almacen_bc( IGxContext context )
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
         ReadRow0I18( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0I18( ) ;
         standaloneModal( ) ;
         AddRow0I18( ) ;
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
               Z19almacenid = A19almacenid;
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

      protected void CONFIRM_0I0( )
      {
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0I18( ) ;
            }
            else
            {
               CheckExtendedTable0I18( ) ;
               if ( AnyError == 0 )
               {
                  ZM0I18( 2) ;
               }
               CloseExtendedTableCursors0I18( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0I18( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z143almacendsc = A143almacendsc;
            Z144almacendireccion = A144almacendireccion;
            Z145almacencolonia = A145almacencolonia;
            Z146almacenmunicipio = A146almacenmunicipio;
            Z147alamcenestado = A147alamcenestado;
            Z148alamcencodigopostal = A148alamcencodigopostal;
            Z149almacentelefono = A149almacentelefono;
            Z150alamcenobservaciones = A150alamcenobservaciones;
            Z151alamcenusuario = A151alamcenusuario;
            Z152almacenfecreg = A152almacenfecreg;
            Z153almacenfecultact = A153almacenfecultact;
            Z13empleadosid = A13empleadosid;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z19almacenid = A19almacenid;
            Z143almacendsc = A143almacendsc;
            Z144almacendireccion = A144almacendireccion;
            Z145almacencolonia = A145almacencolonia;
            Z146almacenmunicipio = A146almacenmunicipio;
            Z147alamcenestado = A147alamcenestado;
            Z148alamcencodigopostal = A148alamcencodigopostal;
            Z149almacentelefono = A149almacentelefono;
            Z150alamcenobservaciones = A150alamcenobservaciones;
            Z151alamcenusuario = A151alamcenusuario;
            Z152almacenfecreg = A152almacenfecreg;
            Z153almacenfecultact = A153almacenfecultact;
            Z13empleadosid = A13empleadosid;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0I18( )
      {
         /* Using cursor BC000I5 */
         pr_default.execute(3, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound18 = 1;
            A143almacendsc = BC000I5_A143almacendsc[0];
            n143almacendsc = BC000I5_n143almacendsc[0];
            A144almacendireccion = BC000I5_A144almacendireccion[0];
            n144almacendireccion = BC000I5_n144almacendireccion[0];
            A145almacencolonia = BC000I5_A145almacencolonia[0];
            n145almacencolonia = BC000I5_n145almacencolonia[0];
            A146almacenmunicipio = BC000I5_A146almacenmunicipio[0];
            n146almacenmunicipio = BC000I5_n146almacenmunicipio[0];
            A147alamcenestado = BC000I5_A147alamcenestado[0];
            n147alamcenestado = BC000I5_n147alamcenestado[0];
            A148alamcencodigopostal = BC000I5_A148alamcencodigopostal[0];
            n148alamcencodigopostal = BC000I5_n148alamcencodigopostal[0];
            A149almacentelefono = BC000I5_A149almacentelefono[0];
            n149almacentelefono = BC000I5_n149almacentelefono[0];
            A150alamcenobservaciones = BC000I5_A150alamcenobservaciones[0];
            n150alamcenobservaciones = BC000I5_n150alamcenobservaciones[0];
            A151alamcenusuario = BC000I5_A151alamcenusuario[0];
            n151alamcenusuario = BC000I5_n151alamcenusuario[0];
            A152almacenfecreg = BC000I5_A152almacenfecreg[0];
            n152almacenfecreg = BC000I5_n152almacenfecreg[0];
            A153almacenfecultact = BC000I5_A153almacenfecultact[0];
            n153almacenfecultact = BC000I5_n153almacenfecultact[0];
            A13empleadosid = BC000I5_A13empleadosid[0];
            n13empleadosid = BC000I5_n13empleadosid[0];
            ZM0I18( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0I18( ) ;
      }

      protected void OnLoadActions0I18( )
      {
      }

      protected void CheckExtendedTable0I18( )
      {
         standaloneModal( ) ;
         /* Using cursor BC000I4 */
         pr_default.execute(2, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A13empleadosid) ) )
            {
               GX_msglist.addItem("No existe 'empleados'.", "ForeignKeyNotFound", 1, "EMPLEADOSID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0I18( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0I18( )
      {
         /* Using cursor BC000I6 */
         pr_default.execute(4, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound18 = 1;
         }
         else
         {
            RcdFound18 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000I3 */
         pr_default.execute(1, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0I18( 1) ;
            RcdFound18 = 1;
            A19almacenid = BC000I3_A19almacenid[0];
            A143almacendsc = BC000I3_A143almacendsc[0];
            n143almacendsc = BC000I3_n143almacendsc[0];
            A144almacendireccion = BC000I3_A144almacendireccion[0];
            n144almacendireccion = BC000I3_n144almacendireccion[0];
            A145almacencolonia = BC000I3_A145almacencolonia[0];
            n145almacencolonia = BC000I3_n145almacencolonia[0];
            A146almacenmunicipio = BC000I3_A146almacenmunicipio[0];
            n146almacenmunicipio = BC000I3_n146almacenmunicipio[0];
            A147alamcenestado = BC000I3_A147alamcenestado[0];
            n147alamcenestado = BC000I3_n147alamcenestado[0];
            A148alamcencodigopostal = BC000I3_A148alamcencodigopostal[0];
            n148alamcencodigopostal = BC000I3_n148alamcencodigopostal[0];
            A149almacentelefono = BC000I3_A149almacentelefono[0];
            n149almacentelefono = BC000I3_n149almacentelefono[0];
            A150alamcenobservaciones = BC000I3_A150alamcenobservaciones[0];
            n150alamcenobservaciones = BC000I3_n150alamcenobservaciones[0];
            A151alamcenusuario = BC000I3_A151alamcenusuario[0];
            n151alamcenusuario = BC000I3_n151alamcenusuario[0];
            A152almacenfecreg = BC000I3_A152almacenfecreg[0];
            n152almacenfecreg = BC000I3_n152almacenfecreg[0];
            A153almacenfecultact = BC000I3_A153almacenfecultact[0];
            n153almacenfecultact = BC000I3_n153almacenfecultact[0];
            A13empleadosid = BC000I3_A13empleadosid[0];
            n13empleadosid = BC000I3_n13empleadosid[0];
            Z19almacenid = A19almacenid;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0I18( ) ;
            if ( AnyError == 1 )
            {
               RcdFound18 = 0;
               InitializeNonKey0I18( ) ;
            }
            Gx_mode = sMode18;
         }
         else
         {
            RcdFound18 = 0;
            InitializeNonKey0I18( ) ;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode18;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I18( ) ;
         if ( RcdFound18 == 0 )
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
         CONFIRM_0I0( ) ;
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

      protected void CheckOptimisticConcurrency0I18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000I2 */
            pr_default.execute(0, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ALMACEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z143almacendsc, BC000I2_A143almacendsc[0]) != 0 ) || ( StringUtil.StrCmp(Z144almacendireccion, BC000I2_A144almacendireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z145almacencolonia, BC000I2_A145almacencolonia[0]) != 0 ) || ( StringUtil.StrCmp(Z146almacenmunicipio, BC000I2_A146almacenmunicipio[0]) != 0 ) || ( StringUtil.StrCmp(Z147alamcenestado, BC000I2_A147alamcenestado[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z148alamcencodigopostal, BC000I2_A148alamcencodigopostal[0]) != 0 ) || ( Z149almacentelefono != BC000I2_A149almacentelefono[0] ) || ( StringUtil.StrCmp(Z150alamcenobservaciones, BC000I2_A150alamcenobservaciones[0]) != 0 ) || ( StringUtil.StrCmp(Z151alamcenusuario, BC000I2_A151alamcenusuario[0]) != 0 ) || ( Z152almacenfecreg != BC000I2_A152almacenfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z153almacenfecultact != BC000I2_A153almacenfecultact[0] ) || ( Z13empleadosid != BC000I2_A13empleadosid[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ALMACEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0I18( )
      {
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I18( 0) ;
            CheckOptimisticConcurrency0I18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000I7 */
                     pr_default.execute(5, new Object[] {A19almacenid, n143almacendsc, A143almacendsc, n144almacendireccion, A144almacendireccion, n145almacencolonia, A145almacencolonia, n146almacenmunicipio, A146almacenmunicipio, n147alamcenestado, A147alamcenestado, n148alamcencodigopostal, A148alamcencodigopostal, n149almacentelefono, A149almacentelefono, n150alamcenobservaciones, A150alamcenobservaciones, n151alamcenusuario, A151alamcenusuario, n152almacenfecreg, A152almacenfecreg, n153almacenfecultact, A153almacenfecultact, n13empleadosid, A13empleadosid});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load0I18( ) ;
            }
            EndLevel0I18( ) ;
         }
         CloseExtendedTableCursors0I18( ) ;
      }

      protected void Update0I18( )
      {
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000I8 */
                     pr_default.execute(6, new Object[] {n143almacendsc, A143almacendsc, n144almacendireccion, A144almacendireccion, n145almacencolonia, A145almacencolonia, n146almacenmunicipio, A146almacenmunicipio, n147alamcenestado, A147alamcenestado, n148alamcencodigopostal, A148alamcencodigopostal, n149almacentelefono, A149almacentelefono, n150alamcenobservaciones, A150alamcenobservaciones, n151alamcenusuario, A151alamcenusuario, n152almacenfecreg, A152almacenfecreg, n153almacenfecultact, A153almacenfecultact, n13empleadosid, A13empleadosid, A19almacenid});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ALMACEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0I18( ) ;
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
            EndLevel0I18( ) ;
         }
         CloseExtendedTableCursors0I18( ) ;
      }

      protected void DeferredUpdate0I18( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I18( ) ;
            AfterConfirm0I18( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I18( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000I9 */
                  pr_default.execute(7, new Object[] {A19almacenid});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
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
         sMode18 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0I18( ) ;
         Gx_mode = sMode18;
      }

      protected void OnDeleteControls0I18( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000I10 */
            pr_default.execute(8, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
            /* Using cursor BC000I11 */
            pr_default.execute(9, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0I18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I18( ) ;
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

      public void ScanKeyStart0I18( )
      {
         /* Using cursor BC000I12 */
         pr_default.execute(10, new Object[] {A19almacenid});
         RcdFound18 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound18 = 1;
            A19almacenid = BC000I12_A19almacenid[0];
            A143almacendsc = BC000I12_A143almacendsc[0];
            n143almacendsc = BC000I12_n143almacendsc[0];
            A144almacendireccion = BC000I12_A144almacendireccion[0];
            n144almacendireccion = BC000I12_n144almacendireccion[0];
            A145almacencolonia = BC000I12_A145almacencolonia[0];
            n145almacencolonia = BC000I12_n145almacencolonia[0];
            A146almacenmunicipio = BC000I12_A146almacenmunicipio[0];
            n146almacenmunicipio = BC000I12_n146almacenmunicipio[0];
            A147alamcenestado = BC000I12_A147alamcenestado[0];
            n147alamcenestado = BC000I12_n147alamcenestado[0];
            A148alamcencodigopostal = BC000I12_A148alamcencodigopostal[0];
            n148alamcencodigopostal = BC000I12_n148alamcencodigopostal[0];
            A149almacentelefono = BC000I12_A149almacentelefono[0];
            n149almacentelefono = BC000I12_n149almacentelefono[0];
            A150alamcenobservaciones = BC000I12_A150alamcenobservaciones[0];
            n150alamcenobservaciones = BC000I12_n150alamcenobservaciones[0];
            A151alamcenusuario = BC000I12_A151alamcenusuario[0];
            n151alamcenusuario = BC000I12_n151alamcenusuario[0];
            A152almacenfecreg = BC000I12_A152almacenfecreg[0];
            n152almacenfecreg = BC000I12_n152almacenfecreg[0];
            A153almacenfecultact = BC000I12_A153almacenfecultact[0];
            n153almacenfecultact = BC000I12_n153almacenfecultact[0];
            A13empleadosid = BC000I12_A13empleadosid[0];
            n13empleadosid = BC000I12_n13empleadosid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0I18( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound18 = 0;
         ScanKeyLoad0I18( ) ;
      }

      protected void ScanKeyLoad0I18( )
      {
         sMode18 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound18 = 1;
            A19almacenid = BC000I12_A19almacenid[0];
            A143almacendsc = BC000I12_A143almacendsc[0];
            n143almacendsc = BC000I12_n143almacendsc[0];
            A144almacendireccion = BC000I12_A144almacendireccion[0];
            n144almacendireccion = BC000I12_n144almacendireccion[0];
            A145almacencolonia = BC000I12_A145almacencolonia[0];
            n145almacencolonia = BC000I12_n145almacencolonia[0];
            A146almacenmunicipio = BC000I12_A146almacenmunicipio[0];
            n146almacenmunicipio = BC000I12_n146almacenmunicipio[0];
            A147alamcenestado = BC000I12_A147alamcenestado[0];
            n147alamcenestado = BC000I12_n147alamcenestado[0];
            A148alamcencodigopostal = BC000I12_A148alamcencodigopostal[0];
            n148alamcencodigopostal = BC000I12_n148alamcencodigopostal[0];
            A149almacentelefono = BC000I12_A149almacentelefono[0];
            n149almacentelefono = BC000I12_n149almacentelefono[0];
            A150alamcenobservaciones = BC000I12_A150alamcenobservaciones[0];
            n150alamcenobservaciones = BC000I12_n150alamcenobservaciones[0];
            A151alamcenusuario = BC000I12_A151alamcenusuario[0];
            n151alamcenusuario = BC000I12_n151alamcenusuario[0];
            A152almacenfecreg = BC000I12_A152almacenfecreg[0];
            n152almacenfecreg = BC000I12_n152almacenfecreg[0];
            A153almacenfecultact = BC000I12_A153almacenfecultact[0];
            n153almacenfecultact = BC000I12_n153almacenfecultact[0];
            A13empleadosid = BC000I12_A13empleadosid[0];
            n13empleadosid = BC000I12_n13empleadosid[0];
         }
         Gx_mode = sMode18;
      }

      protected void ScanKeyEnd0I18( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0I18( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I18( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0I18( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0I18( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I18( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I18( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0I18( )
      {
      }

      protected void AddRow0I18( )
      {
         VarsToRow18( bcalmacen) ;
      }

      protected void ReadRow0I18( )
      {
         RowToVars18( bcalmacen, 1) ;
      }

      protected void InitializeNonKey0I18( )
      {
         A13empleadosid = 0;
         n13empleadosid = false;
         A143almacendsc = "";
         n143almacendsc = false;
         A144almacendireccion = "";
         n144almacendireccion = false;
         A145almacencolonia = "";
         n145almacencolonia = false;
         A146almacenmunicipio = "";
         n146almacenmunicipio = false;
         A147alamcenestado = "";
         n147alamcenestado = false;
         A148alamcencodigopostal = "";
         n148alamcencodigopostal = false;
         A149almacentelefono = 0;
         n149almacentelefono = false;
         A150alamcenobservaciones = "";
         n150alamcenobservaciones = false;
         A151alamcenusuario = "";
         n151alamcenusuario = false;
         A152almacenfecreg = DateTime.MinValue;
         n152almacenfecreg = false;
         A153almacenfecultact = DateTime.MinValue;
         n153almacenfecultact = false;
         Z143almacendsc = "";
         Z144almacendireccion = "";
         Z145almacencolonia = "";
         Z146almacenmunicipio = "";
         Z147alamcenestado = "";
         Z148alamcencodigopostal = "";
         Z149almacentelefono = 0;
         Z150alamcenobservaciones = "";
         Z151alamcenusuario = "";
         Z152almacenfecreg = DateTime.MinValue;
         Z153almacenfecultact = DateTime.MinValue;
         Z13empleadosid = 0;
      }

      protected void InitAll0I18( )
      {
         A19almacenid = 0;
         InitializeNonKey0I18( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow18( Sdtalmacen obj18 )
      {
         obj18.gxTpr_Mode = Gx_mode;
         obj18.gxTpr_Empleadosid = A13empleadosid;
         obj18.gxTpr_Almacendsc = A143almacendsc;
         obj18.gxTpr_Almacendireccion = A144almacendireccion;
         obj18.gxTpr_Almacencolonia = A145almacencolonia;
         obj18.gxTpr_Almacenmunicipio = A146almacenmunicipio;
         obj18.gxTpr_Alamcenestado = A147alamcenestado;
         obj18.gxTpr_Alamcencodigopostal = A148alamcencodigopostal;
         obj18.gxTpr_Almacentelefono = A149almacentelefono;
         obj18.gxTpr_Alamcenobservaciones = A150alamcenobservaciones;
         obj18.gxTpr_Alamcenusuario = A151alamcenusuario;
         obj18.gxTpr_Almacenfecreg = A152almacenfecreg;
         obj18.gxTpr_Almacenfecultact = A153almacenfecultact;
         obj18.gxTpr_Almacenid = A19almacenid;
         obj18.gxTpr_Almacenid_Z = Z19almacenid;
         obj18.gxTpr_Empleadosid_Z = Z13empleadosid;
         obj18.gxTpr_Almacendsc_Z = Z143almacendsc;
         obj18.gxTpr_Almacendireccion_Z = Z144almacendireccion;
         obj18.gxTpr_Almacencolonia_Z = Z145almacencolonia;
         obj18.gxTpr_Almacenmunicipio_Z = Z146almacenmunicipio;
         obj18.gxTpr_Alamcenestado_Z = Z147alamcenestado;
         obj18.gxTpr_Alamcencodigopostal_Z = Z148alamcencodigopostal;
         obj18.gxTpr_Almacentelefono_Z = Z149almacentelefono;
         obj18.gxTpr_Alamcenobservaciones_Z = Z150alamcenobservaciones;
         obj18.gxTpr_Alamcenusuario_Z = Z151alamcenusuario;
         obj18.gxTpr_Almacenfecreg_Z = Z152almacenfecreg;
         obj18.gxTpr_Almacenfecultact_Z = Z153almacenfecultact;
         obj18.gxTpr_Empleadosid_N = (short)(Convert.ToInt16(n13empleadosid));
         obj18.gxTpr_Almacendsc_N = (short)(Convert.ToInt16(n143almacendsc));
         obj18.gxTpr_Almacendireccion_N = (short)(Convert.ToInt16(n144almacendireccion));
         obj18.gxTpr_Almacencolonia_N = (short)(Convert.ToInt16(n145almacencolonia));
         obj18.gxTpr_Almacenmunicipio_N = (short)(Convert.ToInt16(n146almacenmunicipio));
         obj18.gxTpr_Alamcenestado_N = (short)(Convert.ToInt16(n147alamcenestado));
         obj18.gxTpr_Alamcencodigopostal_N = (short)(Convert.ToInt16(n148alamcencodigopostal));
         obj18.gxTpr_Almacentelefono_N = (short)(Convert.ToInt16(n149almacentelefono));
         obj18.gxTpr_Alamcenobservaciones_N = (short)(Convert.ToInt16(n150alamcenobservaciones));
         obj18.gxTpr_Alamcenusuario_N = (short)(Convert.ToInt16(n151alamcenusuario));
         obj18.gxTpr_Almacenfecreg_N = (short)(Convert.ToInt16(n152almacenfecreg));
         obj18.gxTpr_Almacenfecultact_N = (short)(Convert.ToInt16(n153almacenfecultact));
         obj18.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow18( Sdtalmacen obj18 )
      {
         obj18.gxTpr_Almacenid = A19almacenid;
         return  ;
      }

      public void RowToVars18( Sdtalmacen obj18 ,
                               int forceLoad )
      {
         Gx_mode = obj18.gxTpr_Mode;
         A13empleadosid = obj18.gxTpr_Empleadosid;
         n13empleadosid = false;
         A143almacendsc = obj18.gxTpr_Almacendsc;
         n143almacendsc = false;
         A144almacendireccion = obj18.gxTpr_Almacendireccion;
         n144almacendireccion = false;
         A145almacencolonia = obj18.gxTpr_Almacencolonia;
         n145almacencolonia = false;
         A146almacenmunicipio = obj18.gxTpr_Almacenmunicipio;
         n146almacenmunicipio = false;
         A147alamcenestado = obj18.gxTpr_Alamcenestado;
         n147alamcenestado = false;
         A148alamcencodigopostal = obj18.gxTpr_Alamcencodigopostal;
         n148alamcencodigopostal = false;
         A149almacentelefono = obj18.gxTpr_Almacentelefono;
         n149almacentelefono = false;
         A150alamcenobservaciones = obj18.gxTpr_Alamcenobservaciones;
         n150alamcenobservaciones = false;
         A151alamcenusuario = obj18.gxTpr_Alamcenusuario;
         n151alamcenusuario = false;
         A152almacenfecreg = obj18.gxTpr_Almacenfecreg;
         n152almacenfecreg = false;
         A153almacenfecultact = obj18.gxTpr_Almacenfecultact;
         n153almacenfecultact = false;
         A19almacenid = obj18.gxTpr_Almacenid;
         Z19almacenid = obj18.gxTpr_Almacenid_Z;
         Z13empleadosid = obj18.gxTpr_Empleadosid_Z;
         Z143almacendsc = obj18.gxTpr_Almacendsc_Z;
         Z144almacendireccion = obj18.gxTpr_Almacendireccion_Z;
         Z145almacencolonia = obj18.gxTpr_Almacencolonia_Z;
         Z146almacenmunicipio = obj18.gxTpr_Almacenmunicipio_Z;
         Z147alamcenestado = obj18.gxTpr_Alamcenestado_Z;
         Z148alamcencodigopostal = obj18.gxTpr_Alamcencodigopostal_Z;
         Z149almacentelefono = obj18.gxTpr_Almacentelefono_Z;
         Z150alamcenobservaciones = obj18.gxTpr_Alamcenobservaciones_Z;
         Z151alamcenusuario = obj18.gxTpr_Alamcenusuario_Z;
         Z152almacenfecreg = obj18.gxTpr_Almacenfecreg_Z;
         Z153almacenfecultact = obj18.gxTpr_Almacenfecultact_Z;
         n13empleadosid = (bool)(Convert.ToBoolean(obj18.gxTpr_Empleadosid_N));
         n143almacendsc = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacendsc_N));
         n144almacendireccion = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacendireccion_N));
         n145almacencolonia = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacencolonia_N));
         n146almacenmunicipio = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacenmunicipio_N));
         n147alamcenestado = (bool)(Convert.ToBoolean(obj18.gxTpr_Alamcenestado_N));
         n148alamcencodigopostal = (bool)(Convert.ToBoolean(obj18.gxTpr_Alamcencodigopostal_N));
         n149almacentelefono = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacentelefono_N));
         n150alamcenobservaciones = (bool)(Convert.ToBoolean(obj18.gxTpr_Alamcenobservaciones_N));
         n151alamcenusuario = (bool)(Convert.ToBoolean(obj18.gxTpr_Alamcenusuario_N));
         n152almacenfecreg = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacenfecreg_N));
         n153almacenfecultact = (bool)(Convert.ToBoolean(obj18.gxTpr_Almacenfecultact_N));
         Gx_mode = obj18.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A19almacenid = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0I18( ) ;
         ScanKeyStart0I18( ) ;
         if ( RcdFound18 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z19almacenid = A19almacenid;
         }
         ZM0I18( -1) ;
         OnLoadActions0I18( ) ;
         AddRow0I18( ) ;
         ScanKeyEnd0I18( ) ;
         if ( RcdFound18 == 0 )
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
         RowToVars18( bcalmacen, 0) ;
         ScanKeyStart0I18( ) ;
         if ( RcdFound18 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z19almacenid = A19almacenid;
         }
         ZM0I18( -1) ;
         OnLoadActions0I18( ) ;
         AddRow0I18( ) ;
         ScanKeyEnd0I18( ) ;
         if ( RcdFound18 == 0 )
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
         RowToVars18( bcalmacen, 0) ;
         nKeyPressed = 1;
         GetKey0I18( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0I18( ) ;
         }
         else
         {
            if ( RcdFound18 == 1 )
            {
               if ( A19almacenid != Z19almacenid )
               {
                  A19almacenid = Z19almacenid;
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
                  Update0I18( ) ;
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
                  if ( A19almacenid != Z19almacenid )
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
                        Insert0I18( ) ;
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
                        Insert0I18( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow18( bcalmacen) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars18( bcalmacen, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0I18( ) ;
         if ( RcdFound18 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A19almacenid != Z19almacenid )
            {
               A19almacenid = Z19almacenid;
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
            if ( A19almacenid != Z19almacenid )
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
         context.RollbackDataStores( "almacen_BC");
         VarsToRow18( bcalmacen) ;
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
         Gx_mode = bcalmacen.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcalmacen.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcalmacen )
         {
            bcalmacen = (Sdtalmacen)(sdt);
            if ( StringUtil.StrCmp(bcalmacen.gxTpr_Mode, "") == 0 )
            {
               bcalmacen.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow18( bcalmacen) ;
            }
            else
            {
               RowToVars18( bcalmacen, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcalmacen.gxTpr_Mode, "") == 0 )
            {
               bcalmacen.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars18( bcalmacen, 1) ;
         return  ;
      }

      public Sdtalmacen almacen_BC
      {
         get {
            return bcalmacen ;
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
         Z143almacendsc = "";
         A143almacendsc = "";
         Z144almacendireccion = "";
         A144almacendireccion = "";
         Z145almacencolonia = "";
         A145almacencolonia = "";
         Z146almacenmunicipio = "";
         A146almacenmunicipio = "";
         Z147alamcenestado = "";
         A147alamcenestado = "";
         Z148alamcencodigopostal = "";
         A148alamcencodigopostal = "";
         Z150alamcenobservaciones = "";
         A150alamcenobservaciones = "";
         Z151alamcenusuario = "";
         A151alamcenusuario = "";
         Z152almacenfecreg = DateTime.MinValue;
         A152almacenfecreg = DateTime.MinValue;
         Z153almacenfecultact = DateTime.MinValue;
         A153almacenfecultact = DateTime.MinValue;
         BC000I5_A19almacenid = new int[1] ;
         BC000I5_A143almacendsc = new String[] {""} ;
         BC000I5_n143almacendsc = new bool[] {false} ;
         BC000I5_A144almacendireccion = new String[] {""} ;
         BC000I5_n144almacendireccion = new bool[] {false} ;
         BC000I5_A145almacencolonia = new String[] {""} ;
         BC000I5_n145almacencolonia = new bool[] {false} ;
         BC000I5_A146almacenmunicipio = new String[] {""} ;
         BC000I5_n146almacenmunicipio = new bool[] {false} ;
         BC000I5_A147alamcenestado = new String[] {""} ;
         BC000I5_n147alamcenestado = new bool[] {false} ;
         BC000I5_A148alamcencodigopostal = new String[] {""} ;
         BC000I5_n148alamcencodigopostal = new bool[] {false} ;
         BC000I5_A149almacentelefono = new long[1] ;
         BC000I5_n149almacentelefono = new bool[] {false} ;
         BC000I5_A150alamcenobservaciones = new String[] {""} ;
         BC000I5_n150alamcenobservaciones = new bool[] {false} ;
         BC000I5_A151alamcenusuario = new String[] {""} ;
         BC000I5_n151alamcenusuario = new bool[] {false} ;
         BC000I5_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000I5_n152almacenfecreg = new bool[] {false} ;
         BC000I5_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000I5_n153almacenfecultact = new bool[] {false} ;
         BC000I5_A13empleadosid = new int[1] ;
         BC000I5_n13empleadosid = new bool[] {false} ;
         BC000I4_A13empleadosid = new int[1] ;
         BC000I4_n13empleadosid = new bool[] {false} ;
         BC000I6_A19almacenid = new int[1] ;
         BC000I3_A19almacenid = new int[1] ;
         BC000I3_A143almacendsc = new String[] {""} ;
         BC000I3_n143almacendsc = new bool[] {false} ;
         BC000I3_A144almacendireccion = new String[] {""} ;
         BC000I3_n144almacendireccion = new bool[] {false} ;
         BC000I3_A145almacencolonia = new String[] {""} ;
         BC000I3_n145almacencolonia = new bool[] {false} ;
         BC000I3_A146almacenmunicipio = new String[] {""} ;
         BC000I3_n146almacenmunicipio = new bool[] {false} ;
         BC000I3_A147alamcenestado = new String[] {""} ;
         BC000I3_n147alamcenestado = new bool[] {false} ;
         BC000I3_A148alamcencodigopostal = new String[] {""} ;
         BC000I3_n148alamcencodigopostal = new bool[] {false} ;
         BC000I3_A149almacentelefono = new long[1] ;
         BC000I3_n149almacentelefono = new bool[] {false} ;
         BC000I3_A150alamcenobservaciones = new String[] {""} ;
         BC000I3_n150alamcenobservaciones = new bool[] {false} ;
         BC000I3_A151alamcenusuario = new String[] {""} ;
         BC000I3_n151alamcenusuario = new bool[] {false} ;
         BC000I3_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000I3_n152almacenfecreg = new bool[] {false} ;
         BC000I3_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000I3_n153almacenfecultact = new bool[] {false} ;
         BC000I3_A13empleadosid = new int[1] ;
         BC000I3_n13empleadosid = new bool[] {false} ;
         sMode18 = "";
         BC000I2_A19almacenid = new int[1] ;
         BC000I2_A143almacendsc = new String[] {""} ;
         BC000I2_n143almacendsc = new bool[] {false} ;
         BC000I2_A144almacendireccion = new String[] {""} ;
         BC000I2_n144almacendireccion = new bool[] {false} ;
         BC000I2_A145almacencolonia = new String[] {""} ;
         BC000I2_n145almacencolonia = new bool[] {false} ;
         BC000I2_A146almacenmunicipio = new String[] {""} ;
         BC000I2_n146almacenmunicipio = new bool[] {false} ;
         BC000I2_A147alamcenestado = new String[] {""} ;
         BC000I2_n147alamcenestado = new bool[] {false} ;
         BC000I2_A148alamcencodigopostal = new String[] {""} ;
         BC000I2_n148alamcencodigopostal = new bool[] {false} ;
         BC000I2_A149almacentelefono = new long[1] ;
         BC000I2_n149almacentelefono = new bool[] {false} ;
         BC000I2_A150alamcenobservaciones = new String[] {""} ;
         BC000I2_n150alamcenobservaciones = new bool[] {false} ;
         BC000I2_A151alamcenusuario = new String[] {""} ;
         BC000I2_n151alamcenusuario = new bool[] {false} ;
         BC000I2_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000I2_n152almacenfecreg = new bool[] {false} ;
         BC000I2_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000I2_n153almacenfecultact = new bool[] {false} ;
         BC000I2_A13empleadosid = new int[1] ;
         BC000I2_n13empleadosid = new bool[] {false} ;
         BC000I10_A17etiquetasproductoid = new int[1] ;
         BC000I10_A18etiquetascambsid = new int[1] ;
         BC000I10_A19almacenid = new int[1] ;
         BC000I11_A19almacenid = new int[1] ;
         BC000I11_A20articulosproductoid = new int[1] ;
         BC000I11_A21articuloscambsid = new int[1] ;
         BC000I12_A19almacenid = new int[1] ;
         BC000I12_A143almacendsc = new String[] {""} ;
         BC000I12_n143almacendsc = new bool[] {false} ;
         BC000I12_A144almacendireccion = new String[] {""} ;
         BC000I12_n144almacendireccion = new bool[] {false} ;
         BC000I12_A145almacencolonia = new String[] {""} ;
         BC000I12_n145almacencolonia = new bool[] {false} ;
         BC000I12_A146almacenmunicipio = new String[] {""} ;
         BC000I12_n146almacenmunicipio = new bool[] {false} ;
         BC000I12_A147alamcenestado = new String[] {""} ;
         BC000I12_n147alamcenestado = new bool[] {false} ;
         BC000I12_A148alamcencodigopostal = new String[] {""} ;
         BC000I12_n148alamcencodigopostal = new bool[] {false} ;
         BC000I12_A149almacentelefono = new long[1] ;
         BC000I12_n149almacentelefono = new bool[] {false} ;
         BC000I12_A150alamcenobservaciones = new String[] {""} ;
         BC000I12_n150alamcenobservaciones = new bool[] {false} ;
         BC000I12_A151alamcenusuario = new String[] {""} ;
         BC000I12_n151alamcenusuario = new bool[] {false} ;
         BC000I12_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         BC000I12_n152almacenfecreg = new bool[] {false} ;
         BC000I12_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         BC000I12_n153almacenfecultact = new bool[] {false} ;
         BC000I12_A13empleadosid = new int[1] ;
         BC000I12_n13empleadosid = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.almacen_bc__default(),
            new Object[][] {
                new Object[] {
               BC000I2_A19almacenid, BC000I2_A143almacendsc, BC000I2_n143almacendsc, BC000I2_A144almacendireccion, BC000I2_n144almacendireccion, BC000I2_A145almacencolonia, BC000I2_n145almacencolonia, BC000I2_A146almacenmunicipio, BC000I2_n146almacenmunicipio, BC000I2_A147alamcenestado,
               BC000I2_n147alamcenestado, BC000I2_A148alamcencodigopostal, BC000I2_n148alamcencodigopostal, BC000I2_A149almacentelefono, BC000I2_n149almacentelefono, BC000I2_A150alamcenobservaciones, BC000I2_n150alamcenobservaciones, BC000I2_A151alamcenusuario, BC000I2_n151alamcenusuario, BC000I2_A152almacenfecreg,
               BC000I2_n152almacenfecreg, BC000I2_A153almacenfecultact, BC000I2_n153almacenfecultact, BC000I2_A13empleadosid, BC000I2_n13empleadosid
               }
               , new Object[] {
               BC000I3_A19almacenid, BC000I3_A143almacendsc, BC000I3_n143almacendsc, BC000I3_A144almacendireccion, BC000I3_n144almacendireccion, BC000I3_A145almacencolonia, BC000I3_n145almacencolonia, BC000I3_A146almacenmunicipio, BC000I3_n146almacenmunicipio, BC000I3_A147alamcenestado,
               BC000I3_n147alamcenestado, BC000I3_A148alamcencodigopostal, BC000I3_n148alamcencodigopostal, BC000I3_A149almacentelefono, BC000I3_n149almacentelefono, BC000I3_A150alamcenobservaciones, BC000I3_n150alamcenobservaciones, BC000I3_A151alamcenusuario, BC000I3_n151alamcenusuario, BC000I3_A152almacenfecreg,
               BC000I3_n152almacenfecreg, BC000I3_A153almacenfecultact, BC000I3_n153almacenfecultact, BC000I3_A13empleadosid, BC000I3_n13empleadosid
               }
               , new Object[] {
               BC000I4_A13empleadosid
               }
               , new Object[] {
               BC000I5_A19almacenid, BC000I5_A143almacendsc, BC000I5_n143almacendsc, BC000I5_A144almacendireccion, BC000I5_n144almacendireccion, BC000I5_A145almacencolonia, BC000I5_n145almacencolonia, BC000I5_A146almacenmunicipio, BC000I5_n146almacenmunicipio, BC000I5_A147alamcenestado,
               BC000I5_n147alamcenestado, BC000I5_A148alamcencodigopostal, BC000I5_n148alamcencodigopostal, BC000I5_A149almacentelefono, BC000I5_n149almacentelefono, BC000I5_A150alamcenobservaciones, BC000I5_n150alamcenobservaciones, BC000I5_A151alamcenusuario, BC000I5_n151alamcenusuario, BC000I5_A152almacenfecreg,
               BC000I5_n152almacenfecreg, BC000I5_A153almacenfecultact, BC000I5_n153almacenfecultact, BC000I5_A13empleadosid, BC000I5_n13empleadosid
               }
               , new Object[] {
               BC000I6_A19almacenid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000I10_A17etiquetasproductoid, BC000I10_A18etiquetascambsid, BC000I10_A19almacenid
               }
               , new Object[] {
               BC000I11_A19almacenid, BC000I11_A20articulosproductoid, BC000I11_A21articuloscambsid
               }
               , new Object[] {
               BC000I12_A19almacenid, BC000I12_A143almacendsc, BC000I12_n143almacendsc, BC000I12_A144almacendireccion, BC000I12_n144almacendireccion, BC000I12_A145almacencolonia, BC000I12_n145almacencolonia, BC000I12_A146almacenmunicipio, BC000I12_n146almacenmunicipio, BC000I12_A147alamcenestado,
               BC000I12_n147alamcenestado, BC000I12_A148alamcencodigopostal, BC000I12_n148alamcencodigopostal, BC000I12_A149almacentelefono, BC000I12_n149almacentelefono, BC000I12_A150alamcenobservaciones, BC000I12_n150alamcenobservaciones, BC000I12_A151alamcenusuario, BC000I12_n151alamcenusuario, BC000I12_A152almacenfecreg,
               BC000I12_n152almacenfecreg, BC000I12_A153almacenfecultact, BC000I12_n153almacenfecultact, BC000I12_A13empleadosid, BC000I12_n13empleadosid
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
      private short RcdFound18 ;
      private int trnEnded ;
      private int Z19almacenid ;
      private int A19almacenid ;
      private int Z13empleadosid ;
      private int A13empleadosid ;
      private long Z149almacentelefono ;
      private long A149almacentelefono ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode18 ;
      private DateTime Z152almacenfecreg ;
      private DateTime A152almacenfecreg ;
      private DateTime Z153almacenfecultact ;
      private DateTime A153almacenfecultact ;
      private bool n143almacendsc ;
      private bool n144almacendireccion ;
      private bool n145almacencolonia ;
      private bool n146almacenmunicipio ;
      private bool n147alamcenestado ;
      private bool n148alamcencodigopostal ;
      private bool n149almacentelefono ;
      private bool n150alamcenobservaciones ;
      private bool n151alamcenusuario ;
      private bool n152almacenfecreg ;
      private bool n153almacenfecultact ;
      private bool n13empleadosid ;
      private bool Gx_longc ;
      private String Z143almacendsc ;
      private String A143almacendsc ;
      private String Z144almacendireccion ;
      private String A144almacendireccion ;
      private String Z145almacencolonia ;
      private String A145almacencolonia ;
      private String Z146almacenmunicipio ;
      private String A146almacenmunicipio ;
      private String Z147alamcenestado ;
      private String A147alamcenestado ;
      private String Z148alamcencodigopostal ;
      private String A148alamcencodigopostal ;
      private String Z150alamcenobservaciones ;
      private String A150alamcenobservaciones ;
      private String Z151alamcenusuario ;
      private String A151alamcenusuario ;
      private Sdtalmacen bcalmacen ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC000I5_A19almacenid ;
      private String[] BC000I5_A143almacendsc ;
      private bool[] BC000I5_n143almacendsc ;
      private String[] BC000I5_A144almacendireccion ;
      private bool[] BC000I5_n144almacendireccion ;
      private String[] BC000I5_A145almacencolonia ;
      private bool[] BC000I5_n145almacencolonia ;
      private String[] BC000I5_A146almacenmunicipio ;
      private bool[] BC000I5_n146almacenmunicipio ;
      private String[] BC000I5_A147alamcenestado ;
      private bool[] BC000I5_n147alamcenestado ;
      private String[] BC000I5_A148alamcencodigopostal ;
      private bool[] BC000I5_n148alamcencodigopostal ;
      private long[] BC000I5_A149almacentelefono ;
      private bool[] BC000I5_n149almacentelefono ;
      private String[] BC000I5_A150alamcenobservaciones ;
      private bool[] BC000I5_n150alamcenobservaciones ;
      private String[] BC000I5_A151alamcenusuario ;
      private bool[] BC000I5_n151alamcenusuario ;
      private DateTime[] BC000I5_A152almacenfecreg ;
      private bool[] BC000I5_n152almacenfecreg ;
      private DateTime[] BC000I5_A153almacenfecultact ;
      private bool[] BC000I5_n153almacenfecultact ;
      private int[] BC000I5_A13empleadosid ;
      private bool[] BC000I5_n13empleadosid ;
      private int[] BC000I4_A13empleadosid ;
      private bool[] BC000I4_n13empleadosid ;
      private int[] BC000I6_A19almacenid ;
      private int[] BC000I3_A19almacenid ;
      private String[] BC000I3_A143almacendsc ;
      private bool[] BC000I3_n143almacendsc ;
      private String[] BC000I3_A144almacendireccion ;
      private bool[] BC000I3_n144almacendireccion ;
      private String[] BC000I3_A145almacencolonia ;
      private bool[] BC000I3_n145almacencolonia ;
      private String[] BC000I3_A146almacenmunicipio ;
      private bool[] BC000I3_n146almacenmunicipio ;
      private String[] BC000I3_A147alamcenestado ;
      private bool[] BC000I3_n147alamcenestado ;
      private String[] BC000I3_A148alamcencodigopostal ;
      private bool[] BC000I3_n148alamcencodigopostal ;
      private long[] BC000I3_A149almacentelefono ;
      private bool[] BC000I3_n149almacentelefono ;
      private String[] BC000I3_A150alamcenobservaciones ;
      private bool[] BC000I3_n150alamcenobservaciones ;
      private String[] BC000I3_A151alamcenusuario ;
      private bool[] BC000I3_n151alamcenusuario ;
      private DateTime[] BC000I3_A152almacenfecreg ;
      private bool[] BC000I3_n152almacenfecreg ;
      private DateTime[] BC000I3_A153almacenfecultact ;
      private bool[] BC000I3_n153almacenfecultact ;
      private int[] BC000I3_A13empleadosid ;
      private bool[] BC000I3_n13empleadosid ;
      private int[] BC000I2_A19almacenid ;
      private String[] BC000I2_A143almacendsc ;
      private bool[] BC000I2_n143almacendsc ;
      private String[] BC000I2_A144almacendireccion ;
      private bool[] BC000I2_n144almacendireccion ;
      private String[] BC000I2_A145almacencolonia ;
      private bool[] BC000I2_n145almacencolonia ;
      private String[] BC000I2_A146almacenmunicipio ;
      private bool[] BC000I2_n146almacenmunicipio ;
      private String[] BC000I2_A147alamcenestado ;
      private bool[] BC000I2_n147alamcenestado ;
      private String[] BC000I2_A148alamcencodigopostal ;
      private bool[] BC000I2_n148alamcencodigopostal ;
      private long[] BC000I2_A149almacentelefono ;
      private bool[] BC000I2_n149almacentelefono ;
      private String[] BC000I2_A150alamcenobservaciones ;
      private bool[] BC000I2_n150alamcenobservaciones ;
      private String[] BC000I2_A151alamcenusuario ;
      private bool[] BC000I2_n151alamcenusuario ;
      private DateTime[] BC000I2_A152almacenfecreg ;
      private bool[] BC000I2_n152almacenfecreg ;
      private DateTime[] BC000I2_A153almacenfecultact ;
      private bool[] BC000I2_n153almacenfecultact ;
      private int[] BC000I2_A13empleadosid ;
      private bool[] BC000I2_n13empleadosid ;
      private int[] BC000I10_A17etiquetasproductoid ;
      private int[] BC000I10_A18etiquetascambsid ;
      private int[] BC000I10_A19almacenid ;
      private int[] BC000I11_A19almacenid ;
      private int[] BC000I11_A20articulosproductoid ;
      private int[] BC000I11_A21articuloscambsid ;
      private int[] BC000I12_A19almacenid ;
      private String[] BC000I12_A143almacendsc ;
      private bool[] BC000I12_n143almacendsc ;
      private String[] BC000I12_A144almacendireccion ;
      private bool[] BC000I12_n144almacendireccion ;
      private String[] BC000I12_A145almacencolonia ;
      private bool[] BC000I12_n145almacencolonia ;
      private String[] BC000I12_A146almacenmunicipio ;
      private bool[] BC000I12_n146almacenmunicipio ;
      private String[] BC000I12_A147alamcenestado ;
      private bool[] BC000I12_n147alamcenestado ;
      private String[] BC000I12_A148alamcencodigopostal ;
      private bool[] BC000I12_n148alamcencodigopostal ;
      private long[] BC000I12_A149almacentelefono ;
      private bool[] BC000I12_n149almacentelefono ;
      private String[] BC000I12_A150alamcenobservaciones ;
      private bool[] BC000I12_n150alamcenobservaciones ;
      private String[] BC000I12_A151alamcenusuario ;
      private bool[] BC000I12_n151alamcenusuario ;
      private DateTime[] BC000I12_A152almacenfecreg ;
      private bool[] BC000I12_n152almacenfecreg ;
      private DateTime[] BC000I12_A153almacenfecultact ;
      private bool[] BC000I12_n153almacenfecultact ;
      private int[] BC000I12_A13empleadosid ;
      private bool[] BC000I12_n13empleadosid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class almacen_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000I5 ;
          prmBC000I5 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I4 ;
          prmBC000I4 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I6 ;
          prmBC000I6 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I3 ;
          prmBC000I3 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I2 ;
          prmBC000I2 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I7 ;
          prmBC000I7 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacendireccion",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacencolonia",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"almacenmunicipio",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenestado",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcencodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"almacentelefono",NpgsqlDbType.Real,10,0} ,
          new Object[] {"alamcenobservaciones",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"almacenfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"almacenfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I8 ;
          prmBC000I8 = new Object[] {
          new Object[] {"almacendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacendireccion",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacencolonia",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"almacenmunicipio",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenestado",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcencodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"almacentelefono",NpgsqlDbType.Real,10,0} ,
          new Object[] {"alamcenobservaciones",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"almacenfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"almacenfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I9 ;
          prmBC000I9 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I10 ;
          prmBC000I10 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I11 ;
          prmBC000I11 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmBC000I12 ;
          prmBC000I12 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000I2", "SELECT almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadosid FROM public.almacen WHERE almacenid = :almacenid  FOR UPDATE OF almacen",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I2,1,0,true,false )
             ,new CursorDef("BC000I3", "SELECT almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadosid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I3,1,0,true,false )
             ,new CursorDef("BC000I4", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I4,1,0,true,false )
             ,new CursorDef("BC000I5", "SELECT TM1.almacenid, TM1.almacendsc, TM1.almacendireccion, TM1.almacencolonia, TM1.almacenmunicipio, TM1.alamcenestado, TM1.alamcencodigopostal, TM1.almacentelefono, TM1.alamcenobservaciones, TM1.alamcenusuario, TM1.almacenfecreg, TM1.almacenfecultact, TM1.empleadosid FROM public.almacen TM1 WHERE TM1.almacenid = :almacenid ORDER BY TM1.almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I5,100,0,true,false )
             ,new CursorDef("BC000I6", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I6,1,0,true,false )
             ,new CursorDef("BC000I7", "SAVEPOINT gxupdate;INSERT INTO public.almacen(almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadosid) VALUES(:almacenid, :almacendsc, :almacendireccion, :almacencolonia, :almacenmunicipio, :alamcenestado, :alamcencodigopostal, :almacentelefono, :alamcenobservaciones, :alamcenusuario, :almacenfecreg, :almacenfecultact, :empleadosid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000I7)
             ,new CursorDef("BC000I8", "SAVEPOINT gxupdate;UPDATE public.almacen SET almacendsc=:almacendsc, almacendireccion=:almacendireccion, almacencolonia=:almacencolonia, almacenmunicipio=:almacenmunicipio, alamcenestado=:alamcenestado, alamcencodigopostal=:alamcencodigopostal, almacentelefono=:almacentelefono, alamcenobservaciones=:alamcenobservaciones, alamcenusuario=:alamcenusuario, almacenfecreg=:almacenfecreg, almacenfecultact=:almacenfecultact, empleadosid=:empleadosid  WHERE almacenid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000I8)
             ,new CursorDef("BC000I9", "SAVEPOINT gxupdate;DELETE FROM public.almacen  WHERE almacenid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmBC000I9)
             ,new CursorDef("BC000I10", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE articuloid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I10,1,0,true,true )
             ,new CursorDef("BC000I11", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE articulosid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I11,1,0,true,true )
             ,new CursorDef("BC000I12", "SELECT TM1.almacenid, TM1.almacendsc, TM1.almacendireccion, TM1.almacencolonia, TM1.almacenmunicipio, TM1.alamcenestado, TM1.alamcencodigopostal, TM1.almacentelefono, TM1.alamcenobservaciones, TM1.alamcenusuario, TM1.almacenfecreg, TM1.almacenfecultact, TM1.empleadosid FROM public.almacen TM1 WHERE TM1.almacenid = :almacenid ORDER BY TM1.almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I12,100,0,true,false )
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((long[]) buf[13])[0] = rslt.getLong(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 5 :
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
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
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
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (long)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(12, (DateTime)parms[22]);
                }
                if ( (bool)parms[23] )
                {
                   stmt.setNull( 13 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(13, (int)parms[24]);
                }
                return;
             case 6 :
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
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
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(10, (DateTime)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(12, (int)parms[23]);
                }
                stmt.SetParameter(13, (int)parms[24]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
