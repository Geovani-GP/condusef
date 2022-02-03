/*
               File: etiquetasConversion
        Description: Conversion for table etiquetas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/1/2022 0:22:20.26
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class etiquetasconversion : GXProcedure
   {
      public etiquetasconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public etiquetasconversion( IGxContext context )
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

      public void executeSubmit( )
      {
         etiquetasconversion objetiquetasconversion;
         objetiquetasconversion = new etiquetasconversion();
         objetiquetasconversion.context.SetSubmitInitialConfig(context);
         objetiquetasconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objetiquetasconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((etiquetasconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor ETIQUETASC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A38etiquetasfecultact = ETIQUETASC2_A38etiquetasfecultact[0];
            n38etiquetasfecultact = ETIQUETASC2_n38etiquetasfecultact[0];
            A37etiquetasfecreg = ETIQUETASC2_A37etiquetasfecreg[0];
            n37etiquetasfecreg = ETIQUETASC2_n37etiquetasfecreg[0];
            A36etiquetasusuario = ETIQUETASC2_A36etiquetasusuario[0];
            n36etiquetasusuario = ETIQUETASC2_n36etiquetasusuario[0];
            A35etiquetasreimpresion = ETIQUETASC2_A35etiquetasreimpresion[0];
            n35etiquetasreimpresion = ETIQUETASC2_n35etiquetasreimpresion[0];
            A34etiquetafecharealizada = ETIQUETASC2_A34etiquetafecharealizada[0];
            n34etiquetafecharealizada = ETIQUETASC2_n34etiquetafecharealizada[0];
            A33etiquetastatus = ETIQUETASC2_A33etiquetastatus[0];
            n33etiquetastatus = ETIQUETASC2_n33etiquetastatus[0];
            A32etiquetasnumero = ETIQUETASC2_A32etiquetasnumero[0];
            n32etiquetasnumero = ETIQUETASC2_n32etiquetasnumero[0];
            A19almacenid = ETIQUETASC2_A19almacenid[0];
            A18etiquetascambsid = ETIQUETASC2_A18etiquetascambsid[0];
            A17etiquetasproductoid = ETIQUETASC2_A17etiquetasproductoid[0];
            /*
               INSERT RECORD ON TABLE GXA0012

            */
            AV2etiquetasproductoid = A17etiquetasproductoid;
            AV3etiquetascambsid = A18etiquetascambsid;
            AV4almacenid = (int)(A19almacenid);
            if ( ETIQUETASC2_n32etiquetasnumero[0] )
            {
               AV5etiquetasnumero = 0;
               nV5etiquetasnumero = false;
               nV5etiquetasnumero = true;
            }
            else
            {
               AV5etiquetasnumero = A32etiquetasnumero;
               nV5etiquetasnumero = false;
            }
            if ( ETIQUETASC2_n33etiquetastatus[0] )
            {
               AV6etiquetastatus = 0;
               nV6etiquetastatus = false;
               nV6etiquetastatus = true;
            }
            else
            {
               AV6etiquetastatus = A33etiquetastatus;
               nV6etiquetastatus = false;
            }
            if ( ETIQUETASC2_n34etiquetafecharealizada[0] )
            {
               AV7etiquetafecharealizada = (DateTime)(DateTime.MinValue);
               nV7etiquetafecharealizada = false;
               nV7etiquetafecharealizada = true;
            }
            else
            {
               AV7etiquetafecharealizada = A34etiquetafecharealizada;
               nV7etiquetafecharealizada = false;
            }
            if ( ETIQUETASC2_n35etiquetasreimpresion[0] )
            {
               AV8etiquetasreimpresion = 0;
               nV8etiquetasreimpresion = false;
               nV8etiquetasreimpresion = true;
            }
            else
            {
               AV8etiquetasreimpresion = A35etiquetasreimpresion;
               nV8etiquetasreimpresion = false;
            }
            if ( ETIQUETASC2_n36etiquetasusuario[0] )
            {
               AV9etiquetasusuario = "";
               nV9etiquetasusuario = false;
               nV9etiquetasusuario = true;
            }
            else
            {
               AV9etiquetasusuario = A36etiquetasusuario;
               nV9etiquetasusuario = false;
            }
            if ( ETIQUETASC2_n37etiquetasfecreg[0] )
            {
               AV10etiquetasfecreg = (DateTime)(DateTime.MinValue);
               nV10etiquetasfecreg = false;
               nV10etiquetasfecreg = true;
            }
            else
            {
               AV10etiquetasfecreg = A37etiquetasfecreg;
               nV10etiquetasfecreg = false;
            }
            if ( ETIQUETASC2_n38etiquetasfecultact[0] )
            {
               AV11etiquetasfecultact = (DateTime)(DateTime.MinValue);
               nV11etiquetasfecultact = false;
               nV11etiquetasfecultact = true;
            }
            else
            {
               AV11etiquetasfecultact = A38etiquetasfecultact;
               nV11etiquetasfecultact = false;
            }
            /* Using cursor ETIQUETASC3 */
            pr_default.execute(1, new Object[] {AV2etiquetasproductoid, AV3etiquetascambsid, AV4almacenid, nV5etiquetasnumero, AV5etiquetasnumero, nV6etiquetastatus, AV6etiquetastatus, nV7etiquetafecharealizada, AV7etiquetafecharealizada, nV8etiquetasreimpresion, AV8etiquetasreimpresion, nV9etiquetasusuario, AV9etiquetasusuario, nV10etiquetasfecreg, AV10etiquetasfecreg, nV11etiquetasfecultact, AV11etiquetasfecultact});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0012") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         ETIQUETASC2_A38etiquetasfecultact = new DateTime[] {DateTime.MinValue} ;
         ETIQUETASC2_n38etiquetasfecultact = new bool[] {false} ;
         ETIQUETASC2_A37etiquetasfecreg = new DateTime[] {DateTime.MinValue} ;
         ETIQUETASC2_n37etiquetasfecreg = new bool[] {false} ;
         ETIQUETASC2_A36etiquetasusuario = new String[] {""} ;
         ETIQUETASC2_n36etiquetasusuario = new bool[] {false} ;
         ETIQUETASC2_A35etiquetasreimpresion = new long[1] ;
         ETIQUETASC2_n35etiquetasreimpresion = new bool[] {false} ;
         ETIQUETASC2_A34etiquetafecharealizada = new DateTime[] {DateTime.MinValue} ;
         ETIQUETASC2_n34etiquetafecharealizada = new bool[] {false} ;
         ETIQUETASC2_A33etiquetastatus = new long[1] ;
         ETIQUETASC2_n33etiquetastatus = new bool[] {false} ;
         ETIQUETASC2_A32etiquetasnumero = new long[1] ;
         ETIQUETASC2_n32etiquetasnumero = new bool[] {false} ;
         ETIQUETASC2_A19almacenid = new long[1] ;
         ETIQUETASC2_A18etiquetascambsid = new int[1] ;
         ETIQUETASC2_A17etiquetasproductoid = new int[1] ;
         A38etiquetasfecultact = (DateTime)(DateTime.MinValue);
         A37etiquetasfecreg = (DateTime)(DateTime.MinValue);
         A36etiquetasusuario = "";
         A34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         AV7etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         AV9etiquetasusuario = "";
         AV10etiquetasfecreg = (DateTime)(DateTime.MinValue);
         AV11etiquetasfecultact = (DateTime)(DateTime.MinValue);
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.etiquetasconversion__default(),
            new Object[][] {
                new Object[] {
               ETIQUETASC2_A38etiquetasfecultact, ETIQUETASC2_n38etiquetasfecultact, ETIQUETASC2_A37etiquetasfecreg, ETIQUETASC2_n37etiquetasfecreg, ETIQUETASC2_A36etiquetasusuario, ETIQUETASC2_n36etiquetasusuario, ETIQUETASC2_A35etiquetasreimpresion, ETIQUETASC2_n35etiquetasreimpresion, ETIQUETASC2_A34etiquetafecharealizada, ETIQUETASC2_n34etiquetafecharealizada,
               ETIQUETASC2_A33etiquetastatus, ETIQUETASC2_n33etiquetastatus, ETIQUETASC2_A32etiquetasnumero, ETIQUETASC2_n32etiquetasnumero, ETIQUETASC2_A19almacenid, ETIQUETASC2_A18etiquetascambsid, ETIQUETASC2_A17etiquetasproductoid
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A18etiquetascambsid ;
      private int A17etiquetasproductoid ;
      private int GIGXA0012 ;
      private int AV2etiquetasproductoid ;
      private int AV3etiquetascambsid ;
      private int AV4almacenid ;
      private long A35etiquetasreimpresion ;
      private long A33etiquetastatus ;
      private long A32etiquetasnumero ;
      private long A19almacenid ;
      private long AV5etiquetasnumero ;
      private long AV6etiquetastatus ;
      private long AV8etiquetasreimpresion ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A38etiquetasfecultact ;
      private DateTime A37etiquetasfecreg ;
      private DateTime A34etiquetafecharealizada ;
      private DateTime AV7etiquetafecharealizada ;
      private DateTime AV10etiquetasfecreg ;
      private DateTime AV11etiquetasfecultact ;
      private bool n38etiquetasfecultact ;
      private bool n37etiquetasfecreg ;
      private bool n36etiquetasusuario ;
      private bool n35etiquetasreimpresion ;
      private bool n34etiquetafecharealizada ;
      private bool n33etiquetastatus ;
      private bool n32etiquetasnumero ;
      private bool nV5etiquetasnumero ;
      private bool nV6etiquetastatus ;
      private bool nV7etiquetafecharealizada ;
      private bool nV8etiquetasreimpresion ;
      private bool nV9etiquetasusuario ;
      private bool nV10etiquetasfecreg ;
      private bool nV11etiquetasfecultact ;
      private String A36etiquetasusuario ;
      private String AV9etiquetasusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] ETIQUETASC2_A38etiquetasfecultact ;
      private bool[] ETIQUETASC2_n38etiquetasfecultact ;
      private DateTime[] ETIQUETASC2_A37etiquetasfecreg ;
      private bool[] ETIQUETASC2_n37etiquetasfecreg ;
      private String[] ETIQUETASC2_A36etiquetasusuario ;
      private bool[] ETIQUETASC2_n36etiquetasusuario ;
      private long[] ETIQUETASC2_A35etiquetasreimpresion ;
      private bool[] ETIQUETASC2_n35etiquetasreimpresion ;
      private DateTime[] ETIQUETASC2_A34etiquetafecharealizada ;
      private bool[] ETIQUETASC2_n34etiquetafecharealizada ;
      private long[] ETIQUETASC2_A33etiquetastatus ;
      private bool[] ETIQUETASC2_n33etiquetastatus ;
      private long[] ETIQUETASC2_A32etiquetasnumero ;
      private bool[] ETIQUETASC2_n32etiquetasnumero ;
      private long[] ETIQUETASC2_A19almacenid ;
      private int[] ETIQUETASC2_A18etiquetascambsid ;
      private int[] ETIQUETASC2_A17etiquetasproductoid ;
   }

   public class etiquetasconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmETIQUETASC2 ;
          prmETIQUETASC2 = new Object[] {
          } ;
          Object[] prmETIQUETASC3 ;
          prmETIQUETASC3 = new Object[] {
          new Object[] {"AV2etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV4almacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV5etiquetasnumero",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV6etiquetastatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV7etiquetafecharealizada",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV8etiquetasreimpresion",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV9etiquetasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV10etiquetasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV11etiquetasfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("ETIQUETASC2", "SELECT etiquetasfecultact, etiquetasfecreg, etiquetasusuario, etiquetasreimpresión, etiquetafecharealizada, etiquetastatus, etiquetasnumero, articuloid, cambsid, productoid FROM public.etiquetas ORDER BY productoid, cambsid, articuloid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmETIQUETASC2,100,0,true,false )
             ,new CursorDef("ETIQUETASC3", "INSERT INTO GXA0012(etiquetasproductoid, etiquetascambsid, almacenid, etiquetasnumero, etiquetastatus, etiquetafecharealizada, etiquetasreimpresion, etiquetasusuario, etiquetasfecreg, etiquetasfecultact) VALUES(:AV2etiquetasproductoid, :AV3etiquetascambsid, :AV4almacenid, :AV5etiquetasnumero, :AV6etiquetastatus, :AV7etiquetafecharealizada, :AV8etiquetasreimpresion, :AV9etiquetasusuario, :AV10etiquetasfecreg, :AV11etiquetasfecultact)", GxErrorMask.GX_NOMASK,prmETIQUETASC3)
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[16]);
                }
                return;
       }
    }

 }

}
