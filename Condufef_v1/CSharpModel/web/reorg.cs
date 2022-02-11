/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/10/2022 19:54:11.14
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using NpgsqlTypes;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public reorg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void Reorganizeproducto( )
      {
         String cmdBuffer = "" ;
         /* Indices for table producto */
         cmdBuffer=" ALTER TABLE producto ADD ptipobienid  smallint , ADD pcategoriaid  smallint , ADD pmarcaid  smallint , ADD pmodeloid  smallint , ADD pcambsid  smallint  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" DROP INDEX IPRODUCTO1 "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" DROP INDEX IPRODUCTO2 "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE producto DROP CONSTRAINT IPRODUCTO1 "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE producto DROP CONSTRAINT IPRODUCTO2 "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE producto DROP tipobienid, DROP categoriaid, DROP marcaid, DROP modeloid, DROP cambsid "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            productoCount = P00012_AproductoCount[0];
            pr_default.close(0);
            PrintRecordCount ( "producto" ,  productoCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         sSchemaVar = GXUtil.UserId( "Server", context, "DEFAULT");
         if ( ColumnExist("producto",sSchemaVar,"ptipobienid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"ptipobienid", "producto"}) ) ;
            return false ;
         }
         if ( ColumnExist("producto",sSchemaVar,"pcategoriaid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"pcategoriaid", "producto"}) ) ;
            return false ;
         }
         if ( ColumnExist("producto",sSchemaVar,"pmarcaid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"pmarcaid", "producto"}) ) ;
            return false ;
         }
         if ( ColumnExist("producto",sSchemaVar,"pmodeloid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"pmodeloid", "producto"}) ) ;
            return false ;
         }
         if ( ColumnExist("producto",sSchemaVar,"pcambsid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"pcambsid", "producto"}) ) ;
            return false ;
         }
         if ( ! ColumnExist("producto",sSchemaVar,"tipobienid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_not_exist", new   object[]  {"tipobienid", "producto"}) ) ;
            return false ;
         }
         if ( ! ColumnExist("producto",sSchemaVar,"categoriaid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_not_exist", new   object[]  {"categoriaid", "producto"}) ) ;
            return false ;
         }
         if ( ! ColumnExist("producto",sSchemaVar,"marcaid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_not_exist", new   object[]  {"marcaid", "producto"}) ) ;
            return false ;
         }
         if ( ! ColumnExist("producto",sSchemaVar,"modeloid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_not_exist", new   object[]  {"modeloid", "producto"}) ) ;
            return false ;
         }
         if ( ! ColumnExist("producto",sSchemaVar,"cambsid") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_not_exist", new   object[]  {"cambsid", "producto"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool ColumnExist( String sTableName ,
                                String sMySchemaName ,
                                String sMyColumnName )
      {
         bool result ;
         result = false;
         /* Using cursor P00023 */
         pr_default.execute(1, new Object[] {sTableName, sMySchemaName, sMyColumnName});
         while ( (pr_default.getStatus(1) != 101) )
         {
            tablename = P00023_Atablename[0];
            ntablename = P00023_ntablename[0];
            schemaname = P00023_Aschemaname[0];
            nschemaname = P00023_nschemaname[0];
            columnname = P00023_Acolumnname[0];
            ncolumnname = P00023_ncolumnname[0];
            attrelid = P00023_Aattrelid[0];
            nattrelid = P00023_nattrelid[0];
            oid = P00023_Aoid[0];
            noid = P00023_noid[0];
            relname = P00023_Arelname[0];
            nrelname = P00023_nrelname[0];
            result = true;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "Reorganizeproducto" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"producto", ""}) );
      }

      private void SetPrecedenceris( )
      {
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00012_AproductoCount = new int[1] ;
         sSchemaVar = "";
         sTableName = "";
         sMySchemaName = "";
         sMyColumnName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         columnname = "";
         ncolumnname = false;
         attrelid = "";
         nattrelid = false;
         oid = "";
         noid = false;
         relname = "";
         nrelname = false;
         P00023_Atablename = new String[] {""} ;
         P00023_ntablename = new bool[] {false} ;
         P00023_Aschemaname = new String[] {""} ;
         P00023_nschemaname = new bool[] {false} ;
         P00023_Acolumnname = new String[] {""} ;
         P00023_ncolumnname = new bool[] {false} ;
         P00023_Aattrelid = new String[] {""} ;
         P00023_nattrelid = new bool[] {false} ;
         P00023_Aoid = new String[] {""} ;
         P00023_noid = new bool[] {false} ;
         P00023_Arelname = new String[] {""} ;
         P00023_nrelname = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AproductoCount
               }
               , new Object[] {
               P00023_Atablename, P00023_Aschemaname, P00023_Acolumnname, P00023_Aattrelid, P00023_Aoid, P00023_Arelname
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int productoCount ;
      protected String scmdbuf ;
      protected String sSchemaVar ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected String sMyColumnName ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool ncolumnname ;
      protected bool nattrelid ;
      protected bool noid ;
      protected bool nrelname ;
      protected String tablename ;
      protected String schemaname ;
      protected String columnname ;
      protected String attrelid ;
      protected String oid ;
      protected String relname ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_AproductoCount ;
      protected String[] P00023_Atablename ;
      protected bool[] P00023_ntablename ;
      protected String[] P00023_Aschemaname ;
      protected bool[] P00023_nschemaname ;
      protected String[] P00023_Acolumnname ;
      protected bool[] P00023_ncolumnname ;
      protected String[] P00023_Aattrelid ;
      protected bool[] P00023_nattrelid ;
      protected String[] P00023_Aoid ;
      protected bool[] P00023_noid ;
      protected String[] P00023_Arelname ;
      protected bool[] P00023_nrelname ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          new Object[] {"sTableName",NpgsqlDbType.Text,255,0} ,
          new Object[] {"sMySchemaName",NpgsqlDbType.Text,255,0} ,
          new Object[] {"sMyColumnName",NpgsqlDbType.Text,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM producto ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00023", "SELECT T.TABLENAME, T.TABLEOWNER, T1.ATTNAME, T1.ATTRELID, T2.OID, T2.RELNAME FROM PG_TABLES T, PG_ATTRIBUTE T1, PG_CLASS T2 WHERE (UPPER(T.TABLENAME) = ( UPPER(:sTableName))) AND (UPPER(T.TABLEOWNER) = ( UPPER(:sMySchemaName))) AND (UPPER(T1.ATTNAME) = ( UPPER(:sMyColumnName))) AND (T2.OID = ( T1.ATTRELID)) AND (T2.RELNAME = ( T.TABLENAME)) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100,0,true,false )
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
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
