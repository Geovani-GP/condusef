/*
               File: empleadosConversion
        Description: Conversion for table empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 11:29:39.28
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
   public class empleadosconversion : GXProcedure
   {
      public empleadosconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public empleadosconversion( IGxContext context )
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
         empleadosconversion objempleadosconversion;
         objempleadosconversion = new empleadosconversion();
         objempleadosconversion.context.SetSubmitInitialConfig(context);
         objempleadosconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objempleadosconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((empleadosconversion)stateInfo).executePrivate();
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
         /* Using cursor EMPLEADOSC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A105empleadosfecultact = EMPLEADOSC2_A105empleadosfecultact[0];
            n105empleadosfecultact = EMPLEADOSC2_n105empleadosfecultact[0];
            A107empleadosext = EMPLEADOSC2_A107empleadosext[0];
            n107empleadosext = EMPLEADOSC2_n107empleadosext[0];
            A106empleadoscorreo = EMPLEADOSC2_A106empleadoscorreo[0];
            n106empleadoscorreo = EMPLEADOSC2_n106empleadoscorreo[0];
            A104empleadosfecreg = EMPLEADOSC2_A104empleadosfecreg[0];
            n104empleadosfecreg = EMPLEADOSC2_n104empleadosfecreg[0];
            A103empleadosusuario = EMPLEADOSC2_A103empleadosusuario[0];
            n103empleadosusuario = EMPLEADOSC2_n103empleadosusuario[0];
            A102empleadosstatus = EMPLEADOSC2_A102empleadosstatus[0];
            n102empleadosstatus = EMPLEADOSC2_n102empleadosstatus[0];
            A101empleadosapmaterno = EMPLEADOSC2_A101empleadosapmaterno[0];
            n101empleadosapmaterno = EMPLEADOSC2_n101empleadosapmaterno[0];
            A100empleadosappaterno = EMPLEADOSC2_A100empleadosappaterno[0];
            n100empleadosappaterno = EMPLEADOSC2_n100empleadosappaterno[0];
            A99empleadosnomemple = EMPLEADOSC2_A99empleadosnomemple[0];
            n99empleadosnomemple = EMPLEADOSC2_n99empleadosnomemple[0];
            A13empleadosid = EMPLEADOSC2_A13empleadosid[0];
            A40000GXC1 = EMPLEADOSC2_A40000GXC1[0];
            /*
               INSERT RECORD ON TABLE GXA0006

            */
            AV2empleadosid = A13empleadosid;
            if ( EMPLEADOSC2_n99empleadosnomemple[0] )
            {
               AV3empleadosnomemple = "";
               nV3empleadosnomemple = false;
               nV3empleadosnomemple = true;
            }
            else
            {
               AV3empleadosnomemple = A99empleadosnomemple;
               nV3empleadosnomemple = false;
            }
            if ( EMPLEADOSC2_n100empleadosappaterno[0] )
            {
               AV4empleadosappaterno = "";
               nV4empleadosappaterno = false;
               nV4empleadosappaterno = true;
            }
            else
            {
               AV4empleadosappaterno = A100empleadosappaterno;
               nV4empleadosappaterno = false;
            }
            if ( EMPLEADOSC2_n101empleadosapmaterno[0] )
            {
               AV5empleadosapmaterno = "";
               nV5empleadosapmaterno = false;
               nV5empleadosapmaterno = true;
            }
            else
            {
               AV5empleadosapmaterno = A101empleadosapmaterno;
               nV5empleadosapmaterno = false;
            }
            if ( EMPLEADOSC2_n102empleadosstatus[0] )
            {
               AV6empleadosstatus = "";
               nV6empleadosstatus = false;
               nV6empleadosstatus = true;
            }
            else
            {
               AV6empleadosstatus = A102empleadosstatus;
               nV6empleadosstatus = false;
            }
            if ( EMPLEADOSC2_n103empleadosusuario[0] )
            {
               AV7empleadosusuario = "";
               nV7empleadosusuario = false;
               nV7empleadosusuario = true;
            }
            else
            {
               AV7empleadosusuario = A103empleadosusuario;
               nV7empleadosusuario = false;
            }
            if ( EMPLEADOSC2_n104empleadosfecreg[0] )
            {
               AV8empleadosfecreg = DateTime.MinValue;
               nV8empleadosfecreg = false;
               nV8empleadosfecreg = true;
            }
            else
            {
               AV8empleadosfecreg = DateTimeUtil.ResetTime(A104empleadosfecreg);
               nV8empleadosfecreg = false;
            }
            if ( EMPLEADOSC2_n106empleadoscorreo[0] )
            {
               AV9empleadoscorreo = "";
               nV9empleadoscorreo = false;
               nV9empleadoscorreo = true;
            }
            else
            {
               AV9empleadoscorreo = A106empleadoscorreo;
               nV9empleadoscorreo = false;
            }
            if ( EMPLEADOSC2_n107empleadosext[0] )
            {
               AV10empleadosext = "";
               nV10empleadosext = false;
               nV10empleadosext = true;
            }
            else
            {
               AV10empleadosext = A40000GXC1;
               nV10empleadosext = false;
            }
            AV11areaid = 0;
            nV11areaid = false;
            nV11areaid = true;
            if ( EMPLEADOSC2_n105empleadosfecultact[0] )
            {
               AV12empleadosfecultact = context.localUtil.YMDToD( 1, 1, 1);
            }
            else
            {
               AV12empleadosfecultact = DateTimeUtil.ResetTime(A105empleadosfecultact);
            }
            /* Using cursor EMPLEADOSC3 */
            pr_default.execute(1, new Object[] {AV2empleadosid, nV3empleadosnomemple, AV3empleadosnomemple, nV4empleadosappaterno, AV4empleadosappaterno, nV5empleadosapmaterno, AV5empleadosapmaterno, nV6empleadosstatus, AV6empleadosstatus, nV7empleadosusuario, AV7empleadosusuario, nV8empleadosfecreg, AV8empleadosfecreg, nV9empleadoscorreo, AV9empleadoscorreo, nV10empleadosext, AV10empleadosext, nV11areaid, AV11areaid, AV12empleadosfecultact});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0006") ;
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
         EMPLEADOSC2_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         EMPLEADOSC2_n105empleadosfecultact = new bool[] {false} ;
         EMPLEADOSC2_A107empleadosext = new int[1] ;
         EMPLEADOSC2_n107empleadosext = new bool[] {false} ;
         EMPLEADOSC2_A106empleadoscorreo = new String[] {""} ;
         EMPLEADOSC2_n106empleadoscorreo = new bool[] {false} ;
         EMPLEADOSC2_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         EMPLEADOSC2_n104empleadosfecreg = new bool[] {false} ;
         EMPLEADOSC2_A103empleadosusuario = new String[] {""} ;
         EMPLEADOSC2_n103empleadosusuario = new bool[] {false} ;
         EMPLEADOSC2_A102empleadosstatus = new String[] {""} ;
         EMPLEADOSC2_n102empleadosstatus = new bool[] {false} ;
         EMPLEADOSC2_A101empleadosapmaterno = new String[] {""} ;
         EMPLEADOSC2_n101empleadosapmaterno = new bool[] {false} ;
         EMPLEADOSC2_A100empleadosappaterno = new String[] {""} ;
         EMPLEADOSC2_n100empleadosappaterno = new bool[] {false} ;
         EMPLEADOSC2_A99empleadosnomemple = new String[] {""} ;
         EMPLEADOSC2_n99empleadosnomemple = new bool[] {false} ;
         EMPLEADOSC2_A13empleadosid = new int[1] ;
         EMPLEADOSC2_A40000GXC1 = new String[] {""} ;
         A105empleadosfecultact = (DateTime)(DateTime.MinValue);
         A106empleadoscorreo = "";
         A104empleadosfecreg = (DateTime)(DateTime.MinValue);
         A103empleadosusuario = "";
         A102empleadosstatus = "";
         A101empleadosapmaterno = "";
         A100empleadosappaterno = "";
         A99empleadosnomemple = "";
         A40000GXC1 = "";
         AV3empleadosnomemple = "";
         AV4empleadosappaterno = "";
         AV5empleadosapmaterno = "";
         AV6empleadosstatus = "";
         AV7empleadosusuario = "";
         AV8empleadosfecreg = DateTime.MinValue;
         AV9empleadoscorreo = "";
         AV10empleadosext = "";
         AV12empleadosfecultact = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleadosconversion__default(),
            new Object[][] {
                new Object[] {
               EMPLEADOSC2_A105empleadosfecultact, EMPLEADOSC2_n105empleadosfecultact, EMPLEADOSC2_A107empleadosext, EMPLEADOSC2_n107empleadosext, EMPLEADOSC2_A106empleadoscorreo, EMPLEADOSC2_n106empleadoscorreo, EMPLEADOSC2_A104empleadosfecreg, EMPLEADOSC2_n104empleadosfecreg, EMPLEADOSC2_A103empleadosusuario, EMPLEADOSC2_n103empleadosusuario,
               EMPLEADOSC2_A102empleadosstatus, EMPLEADOSC2_n102empleadosstatus, EMPLEADOSC2_A101empleadosapmaterno, EMPLEADOSC2_n101empleadosapmaterno, EMPLEADOSC2_A100empleadosappaterno, EMPLEADOSC2_n100empleadosappaterno, EMPLEADOSC2_A99empleadosnomemple, EMPLEADOSC2_n99empleadosnomemple, EMPLEADOSC2_A13empleadosid, EMPLEADOSC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A107empleadosext ;
      private int A13empleadosid ;
      private int GIGXA0006 ;
      private int AV2empleadosid ;
      private int AV11areaid ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A105empleadosfecultact ;
      private DateTime A104empleadosfecreg ;
      private DateTime AV8empleadosfecreg ;
      private DateTime AV12empleadosfecultact ;
      private bool n105empleadosfecultact ;
      private bool n107empleadosext ;
      private bool n106empleadoscorreo ;
      private bool n104empleadosfecreg ;
      private bool n103empleadosusuario ;
      private bool n102empleadosstatus ;
      private bool n101empleadosapmaterno ;
      private bool n100empleadosappaterno ;
      private bool n99empleadosnomemple ;
      private bool nV3empleadosnomemple ;
      private bool nV4empleadosappaterno ;
      private bool nV5empleadosapmaterno ;
      private bool nV6empleadosstatus ;
      private bool nV7empleadosusuario ;
      private bool nV8empleadosfecreg ;
      private bool nV9empleadoscorreo ;
      private bool nV10empleadosext ;
      private bool nV11areaid ;
      private String A106empleadoscorreo ;
      private String A103empleadosusuario ;
      private String A102empleadosstatus ;
      private String A101empleadosapmaterno ;
      private String A100empleadosappaterno ;
      private String A99empleadosnomemple ;
      private String A40000GXC1 ;
      private String AV3empleadosnomemple ;
      private String AV4empleadosappaterno ;
      private String AV5empleadosapmaterno ;
      private String AV6empleadosstatus ;
      private String AV7empleadosusuario ;
      private String AV9empleadoscorreo ;
      private String AV10empleadosext ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] EMPLEADOSC2_A105empleadosfecultact ;
      private bool[] EMPLEADOSC2_n105empleadosfecultact ;
      private int[] EMPLEADOSC2_A107empleadosext ;
      private bool[] EMPLEADOSC2_n107empleadosext ;
      private String[] EMPLEADOSC2_A106empleadoscorreo ;
      private bool[] EMPLEADOSC2_n106empleadoscorreo ;
      private DateTime[] EMPLEADOSC2_A104empleadosfecreg ;
      private bool[] EMPLEADOSC2_n104empleadosfecreg ;
      private String[] EMPLEADOSC2_A103empleadosusuario ;
      private bool[] EMPLEADOSC2_n103empleadosusuario ;
      private String[] EMPLEADOSC2_A102empleadosstatus ;
      private bool[] EMPLEADOSC2_n102empleadosstatus ;
      private String[] EMPLEADOSC2_A101empleadosapmaterno ;
      private bool[] EMPLEADOSC2_n101empleadosapmaterno ;
      private String[] EMPLEADOSC2_A100empleadosappaterno ;
      private bool[] EMPLEADOSC2_n100empleadosappaterno ;
      private String[] EMPLEADOSC2_A99empleadosnomemple ;
      private bool[] EMPLEADOSC2_n99empleadosnomemple ;
      private int[] EMPLEADOSC2_A13empleadosid ;
      private String[] EMPLEADOSC2_A40000GXC1 ;
   }

   public class empleadosconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmEMPLEADOSC2 ;
          prmEMPLEADOSC2 = new Object[] {
          } ;
          Object[] prmEMPLEADOSC3 ;
          prmEMPLEADOSC3 = new Object[] {
          new Object[] {"AV2empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3empleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"AV4empleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"AV5empleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"AV6empleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"AV7empleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV8empleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV9empleadoscorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV10empleadosext",NpgsqlDbType.Varchar,4,0} ,
          new Object[] {"AV11areaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV12empleadosfecultact",NpgsqlDbType.Date,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("EMPLEADOSC2", "SELECT empleadosfecultact, empleadosext, empleadoscorreo, empleadosfecreg, empleadosusuario, empleadosstatus, empleadosapmaterno, empleadosappaterno, empleadosnomemple, empleadosid, SUBSTR(TO_CHAR(COALESCE( empleadosext, 0),'999999999'), 2) AS GXC1 FROM public.empleados ORDER BY empleadosid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmEMPLEADOSC2,100,0,true,false )
             ,new CursorDef("EMPLEADOSC3", "INSERT INTO GXA0006(empleadosid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadosfecreg, empleadoscorreo, empleadosext, areaid, empleadosfecultact) VALUES(:AV2empleadosid, :AV3empleadosnomemple, :AV4empleadosappaterno, :AV5empleadosapmaterno, :AV6empleadosstatus, :AV7empleadosusuario, :AV8empleadosfecreg, :AV9empleadoscorreo, :AV10empleadosext, :AV11areaid, :AV12empleadosfecultact)", GxErrorMask.GX_NOMASK,prmEMPLEADOSC3)
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((int[]) buf[18])[0] = rslt.getInt(10) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
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
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[14]);
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
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[18]);
                }
                stmt.SetParameter(11, (DateTime)parms[19]);
                return;
       }
    }

 }

}
