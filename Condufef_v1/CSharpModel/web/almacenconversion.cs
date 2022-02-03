/*
               File: almacenConversion
        Description: Conversion for table almacen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/1/2022 0:22:20.5
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
   public class almacenconversion : GXProcedure
   {
      public almacenconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public almacenconversion( IGxContext context )
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
         almacenconversion objalmacenconversion;
         objalmacenconversion = new almacenconversion();
         objalmacenconversion.context.SetSubmitInitialConfig(context);
         objalmacenconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objalmacenconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((almacenconversion)stateInfo).executePrivate();
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
         /* Using cursor ALMACENCON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A153almacenfecultact = ALMACENCON2_A153almacenfecultact[0];
            n153almacenfecultact = ALMACENCON2_n153almacenfecultact[0];
            A152almacenfecreg = ALMACENCON2_A152almacenfecreg[0];
            n152almacenfecreg = ALMACENCON2_n152almacenfecreg[0];
            A151alamcenusuario = ALMACENCON2_A151alamcenusuario[0];
            n151alamcenusuario = ALMACENCON2_n151alamcenusuario[0];
            A150alamcenobservaciones = ALMACENCON2_A150alamcenobservaciones[0];
            n150alamcenobservaciones = ALMACENCON2_n150alamcenobservaciones[0];
            A149almacentelefono = ALMACENCON2_A149almacentelefono[0];
            n149almacentelefono = ALMACENCON2_n149almacentelefono[0];
            A148alamcencodigopostal = ALMACENCON2_A148alamcencodigopostal[0];
            n148alamcencodigopostal = ALMACENCON2_n148alamcencodigopostal[0];
            A147alamcenestado = ALMACENCON2_A147alamcenestado[0];
            n147alamcenestado = ALMACENCON2_n147alamcenestado[0];
            A146almacenmunicipio = ALMACENCON2_A146almacenmunicipio[0];
            n146almacenmunicipio = ALMACENCON2_n146almacenmunicipio[0];
            A145almacencolonia = ALMACENCON2_A145almacencolonia[0];
            n145almacencolonia = ALMACENCON2_n145almacencolonia[0];
            A144almacendireccion = ALMACENCON2_A144almacendireccion[0];
            n144almacendireccion = ALMACENCON2_n144almacendireccion[0];
            A143almacendsc = ALMACENCON2_A143almacendsc[0];
            n143almacendsc = ALMACENCON2_n143almacendsc[0];
            A13empleadosid = ALMACENCON2_A13empleadosid[0];
            n13empleadosid = ALMACENCON2_n13empleadosid[0];
            A19almacenid = ALMACENCON2_A19almacenid[0];
            A40000GXC1 = ALMACENCON2_A40000GXC1[0];
            /*
               INSERT RECORD ON TABLE GXA0018

            */
            AV2almacenid = (int)(A19almacenid);
            if ( ALMACENCON2_n13empleadosid[0] )
            {
               AV3empleadosid = 0;
               nV3empleadosid = false;
               nV3empleadosid = true;
            }
            else
            {
               AV3empleadosid = A13empleadosid;
               nV3empleadosid = false;
            }
            if ( ALMACENCON2_n143almacendsc[0] )
            {
               AV4almacendsc = "";
               nV4almacendsc = false;
               nV4almacendsc = true;
            }
            else
            {
               AV4almacendsc = A143almacendsc;
               nV4almacendsc = false;
            }
            if ( ALMACENCON2_n144almacendireccion[0] )
            {
               AV5almacendireccion = "";
               nV5almacendireccion = false;
               nV5almacendireccion = true;
            }
            else
            {
               AV5almacendireccion = A144almacendireccion;
               nV5almacendireccion = false;
            }
            if ( ALMACENCON2_n145almacencolonia[0] )
            {
               AV6almacencolonia = "";
               nV6almacencolonia = false;
               nV6almacencolonia = true;
            }
            else
            {
               AV6almacencolonia = A145almacencolonia;
               nV6almacencolonia = false;
            }
            if ( ALMACENCON2_n146almacenmunicipio[0] )
            {
               AV7almacenmunicipio = "";
               nV7almacenmunicipio = false;
               nV7almacenmunicipio = true;
            }
            else
            {
               AV7almacenmunicipio = A146almacenmunicipio;
               nV7almacenmunicipio = false;
            }
            if ( ALMACENCON2_n147alamcenestado[0] )
            {
               AV8alamcenestado = "";
               nV8alamcenestado = false;
               nV8alamcenestado = true;
            }
            else
            {
               AV8alamcenestado = A147alamcenestado;
               nV8alamcenestado = false;
            }
            if ( ALMACENCON2_n148alamcencodigopostal[0] )
            {
               AV9alamcencodigopostal = "";
               nV9alamcencodigopostal = false;
               nV9alamcencodigopostal = true;
            }
            else
            {
               AV9alamcencodigopostal = A148alamcencodigopostal;
               nV9alamcencodigopostal = false;
            }
            if ( ALMACENCON2_n149almacentelefono[0] )
            {
               AV10almacentelefono = 0;
               nV10almacentelefono = false;
               nV10almacentelefono = true;
            }
            else
            {
               AV10almacentelefono = A40000GXC1;
               nV10almacentelefono = false;
            }
            if ( ALMACENCON2_n150alamcenobservaciones[0] )
            {
               AV11alamcenobservaciones = "";
               nV11alamcenobservaciones = false;
               nV11alamcenobservaciones = true;
            }
            else
            {
               AV11alamcenobservaciones = A150alamcenobservaciones;
               nV11alamcenobservaciones = false;
            }
            if ( ALMACENCON2_n151alamcenusuario[0] )
            {
               AV12alamcenusuario = "";
               nV12alamcenusuario = false;
               nV12alamcenusuario = true;
            }
            else
            {
               AV12alamcenusuario = A151alamcenusuario;
               nV12alamcenusuario = false;
            }
            if ( ALMACENCON2_n152almacenfecreg[0] )
            {
               AV13almacenfecreg = DateTime.MinValue;
               nV13almacenfecreg = false;
               nV13almacenfecreg = true;
            }
            else
            {
               AV13almacenfecreg = A152almacenfecreg;
               nV13almacenfecreg = false;
            }
            if ( ALMACENCON2_n153almacenfecultact[0] )
            {
               AV14almacenfecultact = DateTime.MinValue;
               nV14almacenfecultact = false;
               nV14almacenfecultact = true;
            }
            else
            {
               AV14almacenfecultact = A153almacenfecultact;
               nV14almacenfecultact = false;
            }
            /* Using cursor ALMACENCON3 */
            pr_default.execute(1, new Object[] {AV2almacenid, nV3empleadosid, AV3empleadosid, nV4almacendsc, AV4almacendsc, nV5almacendireccion, AV5almacendireccion, nV6almacencolonia, AV6almacencolonia, nV7almacenmunicipio, AV7almacenmunicipio, nV8alamcenestado, AV8alamcenestado, nV9alamcencodigopostal, AV9alamcencodigopostal, nV10almacentelefono, AV10almacentelefono, nV11alamcenobservaciones, AV11alamcenobservaciones, nV12alamcenusuario, AV12alamcenusuario, nV13almacenfecreg, AV13almacenfecreg, nV14almacenfecultact, AV14almacenfecultact});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0018") ;
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
         ALMACENCON2_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         ALMACENCON2_n153almacenfecultact = new bool[] {false} ;
         ALMACENCON2_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         ALMACENCON2_n152almacenfecreg = new bool[] {false} ;
         ALMACENCON2_A151alamcenusuario = new String[] {""} ;
         ALMACENCON2_n151alamcenusuario = new bool[] {false} ;
         ALMACENCON2_A150alamcenobservaciones = new String[] {""} ;
         ALMACENCON2_n150alamcenobservaciones = new bool[] {false} ;
         ALMACENCON2_A149almacentelefono = new String[] {""} ;
         ALMACENCON2_n149almacentelefono = new bool[] {false} ;
         ALMACENCON2_A148alamcencodigopostal = new String[] {""} ;
         ALMACENCON2_n148alamcencodigopostal = new bool[] {false} ;
         ALMACENCON2_A147alamcenestado = new String[] {""} ;
         ALMACENCON2_n147alamcenestado = new bool[] {false} ;
         ALMACENCON2_A146almacenmunicipio = new String[] {""} ;
         ALMACENCON2_n146almacenmunicipio = new bool[] {false} ;
         ALMACENCON2_A145almacencolonia = new String[] {""} ;
         ALMACENCON2_n145almacencolonia = new bool[] {false} ;
         ALMACENCON2_A144almacendireccion = new String[] {""} ;
         ALMACENCON2_n144almacendireccion = new bool[] {false} ;
         ALMACENCON2_A143almacendsc = new String[] {""} ;
         ALMACENCON2_n143almacendsc = new bool[] {false} ;
         ALMACENCON2_A13empleadosid = new int[1] ;
         ALMACENCON2_n13empleadosid = new bool[] {false} ;
         ALMACENCON2_A19almacenid = new long[1] ;
         ALMACENCON2_A40000GXC1 = new long[1] ;
         A153almacenfecultact = DateTime.MinValue;
         A152almacenfecreg = DateTime.MinValue;
         A151alamcenusuario = "";
         A150alamcenobservaciones = "";
         A149almacentelefono = "";
         A148alamcencodigopostal = "";
         A147alamcenestado = "";
         A146almacenmunicipio = "";
         A145almacencolonia = "";
         A144almacendireccion = "";
         A143almacendsc = "";
         AV4almacendsc = "";
         AV5almacendireccion = "";
         AV6almacencolonia = "";
         AV7almacenmunicipio = "";
         AV8alamcenestado = "";
         AV9alamcencodigopostal = "";
         AV11alamcenobservaciones = "";
         AV12alamcenusuario = "";
         AV13almacenfecreg = DateTime.MinValue;
         AV14almacenfecultact = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.almacenconversion__default(),
            new Object[][] {
                new Object[] {
               ALMACENCON2_A153almacenfecultact, ALMACENCON2_n153almacenfecultact, ALMACENCON2_A152almacenfecreg, ALMACENCON2_n152almacenfecreg, ALMACENCON2_A151alamcenusuario, ALMACENCON2_n151alamcenusuario, ALMACENCON2_A150alamcenobservaciones, ALMACENCON2_n150alamcenobservaciones, ALMACENCON2_A149almacentelefono, ALMACENCON2_n149almacentelefono,
               ALMACENCON2_A148alamcencodigopostal, ALMACENCON2_n148alamcencodigopostal, ALMACENCON2_A147alamcenestado, ALMACENCON2_n147alamcenestado, ALMACENCON2_A146almacenmunicipio, ALMACENCON2_n146almacenmunicipio, ALMACENCON2_A145almacencolonia, ALMACENCON2_n145almacencolonia, ALMACENCON2_A144almacendireccion, ALMACENCON2_n144almacendireccion,
               ALMACENCON2_A143almacendsc, ALMACENCON2_n143almacendsc, ALMACENCON2_A13empleadosid, ALMACENCON2_n13empleadosid, ALMACENCON2_A19almacenid, ALMACENCON2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A13empleadosid ;
      private int GIGXA0018 ;
      private int AV2almacenid ;
      private int AV3empleadosid ;
      private long A19almacenid ;
      private long A40000GXC1 ;
      private long AV10almacentelefono ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A153almacenfecultact ;
      private DateTime A152almacenfecreg ;
      private DateTime AV13almacenfecreg ;
      private DateTime AV14almacenfecultact ;
      private bool n153almacenfecultact ;
      private bool n152almacenfecreg ;
      private bool n151alamcenusuario ;
      private bool n150alamcenobservaciones ;
      private bool n149almacentelefono ;
      private bool n148alamcencodigopostal ;
      private bool n147alamcenestado ;
      private bool n146almacenmunicipio ;
      private bool n145almacencolonia ;
      private bool n144almacendireccion ;
      private bool n143almacendsc ;
      private bool n13empleadosid ;
      private bool nV3empleadosid ;
      private bool nV4almacendsc ;
      private bool nV5almacendireccion ;
      private bool nV6almacencolonia ;
      private bool nV7almacenmunicipio ;
      private bool nV8alamcenestado ;
      private bool nV9alamcencodigopostal ;
      private bool nV10almacentelefono ;
      private bool nV11alamcenobservaciones ;
      private bool nV12alamcenusuario ;
      private bool nV13almacenfecreg ;
      private bool nV14almacenfecultact ;
      private String A151alamcenusuario ;
      private String A150alamcenobservaciones ;
      private String A149almacentelefono ;
      private String A148alamcencodigopostal ;
      private String A147alamcenestado ;
      private String A146almacenmunicipio ;
      private String A145almacencolonia ;
      private String A144almacendireccion ;
      private String A143almacendsc ;
      private String AV4almacendsc ;
      private String AV5almacendireccion ;
      private String AV6almacencolonia ;
      private String AV7almacenmunicipio ;
      private String AV8alamcenestado ;
      private String AV9alamcencodigopostal ;
      private String AV11alamcenobservaciones ;
      private String AV12alamcenusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] ALMACENCON2_A153almacenfecultact ;
      private bool[] ALMACENCON2_n153almacenfecultact ;
      private DateTime[] ALMACENCON2_A152almacenfecreg ;
      private bool[] ALMACENCON2_n152almacenfecreg ;
      private String[] ALMACENCON2_A151alamcenusuario ;
      private bool[] ALMACENCON2_n151alamcenusuario ;
      private String[] ALMACENCON2_A150alamcenobservaciones ;
      private bool[] ALMACENCON2_n150alamcenobservaciones ;
      private String[] ALMACENCON2_A149almacentelefono ;
      private bool[] ALMACENCON2_n149almacentelefono ;
      private String[] ALMACENCON2_A148alamcencodigopostal ;
      private bool[] ALMACENCON2_n148alamcencodigopostal ;
      private String[] ALMACENCON2_A147alamcenestado ;
      private bool[] ALMACENCON2_n147alamcenestado ;
      private String[] ALMACENCON2_A146almacenmunicipio ;
      private bool[] ALMACENCON2_n146almacenmunicipio ;
      private String[] ALMACENCON2_A145almacencolonia ;
      private bool[] ALMACENCON2_n145almacencolonia ;
      private String[] ALMACENCON2_A144almacendireccion ;
      private bool[] ALMACENCON2_n144almacendireccion ;
      private String[] ALMACENCON2_A143almacendsc ;
      private bool[] ALMACENCON2_n143almacendsc ;
      private int[] ALMACENCON2_A13empleadosid ;
      private bool[] ALMACENCON2_n13empleadosid ;
      private long[] ALMACENCON2_A19almacenid ;
      private long[] ALMACENCON2_A40000GXC1 ;
   }

   public class almacenconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmALMACENCON2 ;
          prmALMACENCON2 = new Object[] {
          } ;
          Object[] prmALMACENCON3 ;
          prmALMACENCON3 = new Object[] {
          new Object[] {"AV2almacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV4almacendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV5almacendireccion",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV6almacencolonia",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV7almacenmunicipio",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV8alamcenestado",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV9alamcencodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"AV10almacentelefono",NpgsqlDbType.Real,10,0} ,
          new Object[] {"AV11alamcenobservaciones",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV12alamcenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV13almacenfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV14almacenfecultact",NpgsqlDbType.Date,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("ALMACENCON2", "SELECT almacenfecultact, almacenfecreg, alamcenusuario, alamcenobservaciones, almacentelefono, alamcencodigopostal, alamcenestado, almacenmunicipio, almacencolonia, almacendireccion, almacendsc, empleadoid, almacenid, CASE  WHEN LENGTH(TRIM(TRANSLATE(COALESCE( almacentelefono, ''), ' ', ' +-.0123456789'))) > 0 OR COALESCE( almacentelefono, '')= ' ' THEN 0 ELSE TO_NUMBER(0 || COALESCE( almacentelefono, ''),'FM9999999999999999999999999999.99999999999999') END AS GXC1 FROM public.almacen ORDER BY almacenid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmALMACENCON2,100,0,true,false )
             ,new CursorDef("ALMACENCON3", "INSERT INTO GXA0018(almacenid, empleadosid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact) VALUES(:AV2almacenid, :AV3empleadosid, :AV4almacendsc, :AV5almacendireccion, :AV6almacencolonia, :AV7almacenmunicipio, :AV8alamcenestado, :AV9alamcencodigopostal, :AV10almacentelefono, :AV11alamcenobservaciones, :AV12alamcenusuario, :AV13almacenfecreg, :AV14almacenfecultact)", GxErrorMask.GX_NOMASK,prmALMACENCON3)
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
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
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((int[]) buf[22])[0] = rslt.getInt(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((long[]) buf[24])[0] = rslt.getLong(13) ;
                ((long[]) buf[25])[0] = rslt.getLong(14) ;
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
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[2]);
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
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (long)parms[16]);
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
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[20]);
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
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[24]);
                }
                return;
       }
    }

 }

}
