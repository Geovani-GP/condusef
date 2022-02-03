/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 12:59:36.39
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

      public void Createempleadospiso( )
      {
         String cmdBuffer = "" ;
         /* Indices for table empleadospiso */
         try
         {
            cmdBuffer=" CREATE TABLE empleadospiso (empleadospisoextid  integer NOT NULL , empleadospisoextpiso  VARCHAR(10) NOT NULL , empleadospisoextext  VARCHAR(10) NOT NULL , empleadospisoextcorreo  VARCHAR(50) NOT NULL , empleadopisoextprofesion  bigint NOT NULL , empleadospisoextusuario  VARCHAR(15) NOT NULL , empleadospisoextfecgre  date NOT NULL , empleadospisoextfeact  date NOT NULL , PRIMARY KEY(empleadospisoextid))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP TABLE empleadospiso CASCADE "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE empleadospiso (empleadospisoextid  integer NOT NULL , empleadospisoextpiso  VARCHAR(10) NOT NULL , empleadospisoextext  VARCHAR(10) NOT NULL , empleadospisoextcorreo  VARCHAR(50) NOT NULL , empleadopisoextprofesion  bigint NOT NULL , empleadospisoextusuario  VARCHAR(15) NOT NULL , empleadospisoextfecgre  date NOT NULL , empleadospisoextfeact  date NOT NULL , PRIMARY KEY(empleadospisoextid))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
      }

      private bool PreviousCheck( )
      {
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         sSchemaVar = GXUtil.UserId( "Server", context, "DEFAULT");
         if ( tableexist("empleadospiso",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"empleadospiso"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool tableexist( String sTableName ,
                               String sMySchemaName )
      {
         bool result ;
         result = false;
         /* Using cursor P00012 */
         pr_default.execute(0, new Object[] {sTableName, sMySchemaName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            tablename = P00012_Atablename[0];
            ntablename = P00012_ntablename[0];
            schemaname = P00012_Aschemaname[0];
            nschemaname = P00012_nschemaname[0];
            result = true;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "Createempleadospiso" , new Object[]{ });
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
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"empleadospiso", ""}) );
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
         sSchemaVar = "";
         sTableName = "";
         sMySchemaName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         scmdbuf = "";
         P00012_Atablename = new String[] {""} ;
         P00012_ntablename = new bool[] {false} ;
         P00012_Aschemaname = new String[] {""} ;
         P00012_nschemaname = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_Atablename, P00012_Aschemaname
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected String sSchemaVar ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected String scmdbuf ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected String tablename ;
      protected String schemaname ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected String[] P00012_Atablename ;
      protected bool[] P00012_ntablename ;
      protected String[] P00012_Aschemaname ;
      protected bool[] P00012_nschemaname ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"sTableName",NpgsqlDbType.Text,255,0} ,
          new Object[] {"sMySchemaName",NpgsqlDbType.Text,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT TABLENAME, TABLEOWNER FROM PG_TABLES WHERE (UPPER(TABLENAME) = ( UPPER(:sTableName))) AND (UPPER(TABLEOWNER) = ( UPPER(:sMySchemaName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
