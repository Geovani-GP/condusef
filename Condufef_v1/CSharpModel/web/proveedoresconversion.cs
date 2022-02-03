/*
               File: proveedoresConversion
        Description: Conversion for table proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/31/2022 21:44:49.32
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
   public class proveedoresconversion : GXProcedure
   {
      public proveedoresconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public proveedoresconversion( IGxContext context )
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
         proveedoresconversion objproveedoresconversion;
         objproveedoresconversion = new proveedoresconversion();
         objproveedoresconversion.context.SetSubmitInitialConfig(context);
         objproveedoresconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objproveedoresconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((proveedoresconversion)stateInfo).executePrivate();
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
         /* Using cursor PROVEEDORE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A138proveedoresfecultact = PROVEEDORE2_A138proveedoresfecultact[0];
            n138proveedoresfecultact = PROVEEDORE2_n138proveedoresfecultact[0];
            A137proveedoresfecreg = PROVEEDORE2_A137proveedoresfecreg[0];
            n137proveedoresfecreg = PROVEEDORE2_n137proveedoresfecreg[0];
            A136proveedoresusuario = PROVEEDORE2_A136proveedoresusuario[0];
            n136proveedoresusuario = PROVEEDORE2_n136proveedoresusuario[0];
            A135proveedoresrfc = PROVEEDORE2_A135proveedoresrfc[0];
            n135proveedoresrfc = PROVEEDORE2_n135proveedoresrfc[0];
            A134proveedoresfax = PROVEEDORE2_A134proveedoresfax[0];
            n134proveedoresfax = PROVEEDORE2_n134proveedoresfax[0];
            A133proveedorestelefono2 = PROVEEDORE2_A133proveedorestelefono2[0];
            n133proveedorestelefono2 = PROVEEDORE2_n133proveedorestelefono2[0];
            A132proveedorestelefono1 = PROVEEDORE2_A132proveedorestelefono1[0];
            n132proveedorestelefono1 = PROVEEDORE2_n132proveedorestelefono1[0];
            A131proveedorestado = PROVEEDORE2_A131proveedorestado[0];
            n131proveedorestado = PROVEEDORE2_n131proveedorestado[0];
            A130proveedoresmunicipio = PROVEEDORE2_A130proveedoresmunicipio[0];
            n130proveedoresmunicipio = PROVEEDORE2_n130proveedoresmunicipio[0];
            A129proveedorescodigopostal = PROVEEDORE2_A129proveedorescodigopostal[0];
            n129proveedorescodigopostal = PROVEEDORE2_n129proveedorescodigopostal[0];
            A128proveedorescolonia = PROVEEDORE2_A128proveedorescolonia[0];
            n128proveedorescolonia = PROVEEDORE2_n128proveedorescolonia[0];
            A127proveedoresdireccion = PROVEEDORE2_A127proveedoresdireccion[0];
            n127proveedoresdireccion = PROVEEDORE2_n127proveedoresdireccion[0];
            A126proveedoresnombre = PROVEEDORE2_A126proveedoresnombre[0];
            n126proveedoresnombre = PROVEEDORE2_n126proveedoresnombre[0];
            A2proveedoresid = PROVEEDORE2_A2proveedoresid[0];
            A40000GXC1 = PROVEEDORE2_A40000GXC1[0];
            A40001GXC2 = PROVEEDORE2_A40001GXC2[0];
            /*
               INSERT RECORD ON TABLE GXA0010

            */
            AV2proveedoresid = A2proveedoresid;
            if ( PROVEEDORE2_n126proveedoresnombre[0] )
            {
               AV3proveedoresnombre = "";
               nV3proveedoresnombre = false;
               nV3proveedoresnombre = true;
            }
            else
            {
               AV3proveedoresnombre = A126proveedoresnombre;
               nV3proveedoresnombre = false;
            }
            if ( PROVEEDORE2_n127proveedoresdireccion[0] )
            {
               AV4proveedoresdireccion = "";
               nV4proveedoresdireccion = false;
               nV4proveedoresdireccion = true;
            }
            else
            {
               AV4proveedoresdireccion = A127proveedoresdireccion;
               nV4proveedoresdireccion = false;
            }
            if ( PROVEEDORE2_n128proveedorescolonia[0] )
            {
               AV5proveedorescolonia = "";
               nV5proveedorescolonia = false;
               nV5proveedorescolonia = true;
            }
            else
            {
               AV5proveedorescolonia = A128proveedorescolonia;
               nV5proveedorescolonia = false;
            }
            if ( PROVEEDORE2_n129proveedorescodigopostal[0] )
            {
               AV6proveedorescodigopostal = "";
               nV6proveedorescodigopostal = false;
               nV6proveedorescodigopostal = true;
            }
            else
            {
               AV6proveedorescodigopostal = A129proveedorescodigopostal;
               nV6proveedorescodigopostal = false;
            }
            if ( PROVEEDORE2_n130proveedoresmunicipio[0] )
            {
               AV7proveedoresmunicipio = "";
               nV7proveedoresmunicipio = false;
               nV7proveedoresmunicipio = true;
            }
            else
            {
               AV7proveedoresmunicipio = A130proveedoresmunicipio;
               nV7proveedoresmunicipio = false;
            }
            if ( PROVEEDORE2_n131proveedorestado[0] )
            {
               AV8proveedorestado = "";
               nV8proveedorestado = false;
               nV8proveedorestado = true;
            }
            else
            {
               AV8proveedorestado = A131proveedorestado;
               nV8proveedorestado = false;
            }
            if ( PROVEEDORE2_n132proveedorestelefono1[0] )
            {
               AV9proveedorestelefono1 = 0;
               nV9proveedorestelefono1 = false;
               nV9proveedorestelefono1 = true;
            }
            else
            {
               AV9proveedorestelefono1 = A40000GXC1;
               nV9proveedorestelefono1 = false;
            }
            if ( PROVEEDORE2_n133proveedorestelefono2[0] )
            {
               AV10proveedorestelefono2 = 0;
               nV10proveedorestelefono2 = false;
               nV10proveedorestelefono2 = true;
            }
            else
            {
               AV10proveedorestelefono2 = A40001GXC2;
               nV10proveedorestelefono2 = false;
            }
            if ( PROVEEDORE2_n134proveedoresfax[0] )
            {
               AV11proveedoresfax = "";
               nV11proveedoresfax = false;
               nV11proveedoresfax = true;
            }
            else
            {
               AV11proveedoresfax = A134proveedoresfax;
               nV11proveedoresfax = false;
            }
            if ( PROVEEDORE2_n135proveedoresrfc[0] )
            {
               AV12proveedoresrfc = "";
               nV12proveedoresrfc = false;
               nV12proveedoresrfc = true;
            }
            else
            {
               AV12proveedoresrfc = A135proveedoresrfc;
               nV12proveedoresrfc = false;
            }
            if ( PROVEEDORE2_n136proveedoresusuario[0] )
            {
               AV13proveedoresusuario = "";
               nV13proveedoresusuario = false;
               nV13proveedoresusuario = true;
            }
            else
            {
               AV13proveedoresusuario = A136proveedoresusuario;
               nV13proveedoresusuario = false;
            }
            if ( PROVEEDORE2_n137proveedoresfecreg[0] )
            {
               AV14proveedoresfecreg = DateTime.MinValue;
               nV14proveedoresfecreg = false;
               nV14proveedoresfecreg = true;
            }
            else
            {
               AV14proveedoresfecreg = DateTimeUtil.ResetTime(A137proveedoresfecreg);
               nV14proveedoresfecreg = false;
            }
            if ( PROVEEDORE2_n138proveedoresfecultact[0] )
            {
               AV15proveedoresfecultact = DateTime.MinValue;
               nV15proveedoresfecultact = false;
               nV15proveedoresfecultact = true;
            }
            else
            {
               AV15proveedoresfecultact = DateTimeUtil.ResetTime(A138proveedoresfecultact);
               nV15proveedoresfecultact = false;
            }
            /* Using cursor PROVEEDORE3 */
            pr_default.execute(1, new Object[] {AV2proveedoresid, nV3proveedoresnombre, AV3proveedoresnombre, nV4proveedoresdireccion, AV4proveedoresdireccion, nV5proveedorescolonia, AV5proveedorescolonia, nV6proveedorescodigopostal, AV6proveedorescodigopostal, nV7proveedoresmunicipio, AV7proveedoresmunicipio, nV8proveedorestado, AV8proveedorestado, nV9proveedorestelefono1, AV9proveedorestelefono1, nV10proveedorestelefono2, AV10proveedorestelefono2, nV11proveedoresfax, AV11proveedoresfax, nV12proveedoresrfc, AV12proveedoresrfc, nV13proveedoresusuario, AV13proveedoresusuario, nV14proveedoresfecreg, AV14proveedoresfecreg, nV15proveedoresfecultact, AV15proveedoresfecultact});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0010") ;
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
         PROVEEDORE2_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         PROVEEDORE2_n138proveedoresfecultact = new bool[] {false} ;
         PROVEEDORE2_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         PROVEEDORE2_n137proveedoresfecreg = new bool[] {false} ;
         PROVEEDORE2_A136proveedoresusuario = new String[] {""} ;
         PROVEEDORE2_n136proveedoresusuario = new bool[] {false} ;
         PROVEEDORE2_A135proveedoresrfc = new String[] {""} ;
         PROVEEDORE2_n135proveedoresrfc = new bool[] {false} ;
         PROVEEDORE2_A134proveedoresfax = new String[] {""} ;
         PROVEEDORE2_n134proveedoresfax = new bool[] {false} ;
         PROVEEDORE2_A133proveedorestelefono2 = new String[] {""} ;
         PROVEEDORE2_n133proveedorestelefono2 = new bool[] {false} ;
         PROVEEDORE2_A132proveedorestelefono1 = new String[] {""} ;
         PROVEEDORE2_n132proveedorestelefono1 = new bool[] {false} ;
         PROVEEDORE2_A131proveedorestado = new String[] {""} ;
         PROVEEDORE2_n131proveedorestado = new bool[] {false} ;
         PROVEEDORE2_A130proveedoresmunicipio = new String[] {""} ;
         PROVEEDORE2_n130proveedoresmunicipio = new bool[] {false} ;
         PROVEEDORE2_A129proveedorescodigopostal = new String[] {""} ;
         PROVEEDORE2_n129proveedorescodigopostal = new bool[] {false} ;
         PROVEEDORE2_A128proveedorescolonia = new String[] {""} ;
         PROVEEDORE2_n128proveedorescolonia = new bool[] {false} ;
         PROVEEDORE2_A127proveedoresdireccion = new String[] {""} ;
         PROVEEDORE2_n127proveedoresdireccion = new bool[] {false} ;
         PROVEEDORE2_A126proveedoresnombre = new String[] {""} ;
         PROVEEDORE2_n126proveedoresnombre = new bool[] {false} ;
         PROVEEDORE2_A2proveedoresid = new int[1] ;
         PROVEEDORE2_A40000GXC1 = new long[1] ;
         PROVEEDORE2_A40001GXC2 = new long[1] ;
         A138proveedoresfecultact = (DateTime)(DateTime.MinValue);
         A137proveedoresfecreg = (DateTime)(DateTime.MinValue);
         A136proveedoresusuario = "";
         A135proveedoresrfc = "";
         A134proveedoresfax = "";
         A133proveedorestelefono2 = "";
         A132proveedorestelefono1 = "";
         A131proveedorestado = "";
         A130proveedoresmunicipio = "";
         A129proveedorescodigopostal = "";
         A128proveedorescolonia = "";
         A127proveedoresdireccion = "";
         A126proveedoresnombre = "";
         AV3proveedoresnombre = "";
         AV4proveedoresdireccion = "";
         AV5proveedorescolonia = "";
         AV6proveedorescodigopostal = "";
         AV7proveedoresmunicipio = "";
         AV8proveedorestado = "";
         AV11proveedoresfax = "";
         AV12proveedoresrfc = "";
         AV13proveedoresusuario = "";
         AV14proveedoresfecreg = DateTime.MinValue;
         AV15proveedoresfecultact = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proveedoresconversion__default(),
            new Object[][] {
                new Object[] {
               PROVEEDORE2_A138proveedoresfecultact, PROVEEDORE2_n138proveedoresfecultact, PROVEEDORE2_A137proveedoresfecreg, PROVEEDORE2_n137proveedoresfecreg, PROVEEDORE2_A136proveedoresusuario, PROVEEDORE2_n136proveedoresusuario, PROVEEDORE2_A135proveedoresrfc, PROVEEDORE2_n135proveedoresrfc, PROVEEDORE2_A134proveedoresfax, PROVEEDORE2_n134proveedoresfax,
               PROVEEDORE2_A133proveedorestelefono2, PROVEEDORE2_n133proveedorestelefono2, PROVEEDORE2_A132proveedorestelefono1, PROVEEDORE2_n132proveedorestelefono1, PROVEEDORE2_A131proveedorestado, PROVEEDORE2_n131proveedorestado, PROVEEDORE2_A130proveedoresmunicipio, PROVEEDORE2_n130proveedoresmunicipio, PROVEEDORE2_A129proveedorescodigopostal, PROVEEDORE2_n129proveedorescodigopostal,
               PROVEEDORE2_A128proveedorescolonia, PROVEEDORE2_n128proveedorescolonia, PROVEEDORE2_A127proveedoresdireccion, PROVEEDORE2_n127proveedoresdireccion, PROVEEDORE2_A126proveedoresnombre, PROVEEDORE2_n126proveedoresnombre, PROVEEDORE2_A2proveedoresid, PROVEEDORE2_A40000GXC1, PROVEEDORE2_A40001GXC2
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A2proveedoresid ;
      private int GIGXA0010 ;
      private int AV2proveedoresid ;
      private long A40000GXC1 ;
      private long A40001GXC2 ;
      private long AV9proveedorestelefono1 ;
      private long AV10proveedorestelefono2 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A138proveedoresfecultact ;
      private DateTime A137proveedoresfecreg ;
      private DateTime AV14proveedoresfecreg ;
      private DateTime AV15proveedoresfecultact ;
      private bool n138proveedoresfecultact ;
      private bool n137proveedoresfecreg ;
      private bool n136proveedoresusuario ;
      private bool n135proveedoresrfc ;
      private bool n134proveedoresfax ;
      private bool n133proveedorestelefono2 ;
      private bool n132proveedorestelefono1 ;
      private bool n131proveedorestado ;
      private bool n130proveedoresmunicipio ;
      private bool n129proveedorescodigopostal ;
      private bool n128proveedorescolonia ;
      private bool n127proveedoresdireccion ;
      private bool n126proveedoresnombre ;
      private bool nV3proveedoresnombre ;
      private bool nV4proveedoresdireccion ;
      private bool nV5proveedorescolonia ;
      private bool nV6proveedorescodigopostal ;
      private bool nV7proveedoresmunicipio ;
      private bool nV8proveedorestado ;
      private bool nV9proveedorestelefono1 ;
      private bool nV10proveedorestelefono2 ;
      private bool nV11proveedoresfax ;
      private bool nV12proveedoresrfc ;
      private bool nV13proveedoresusuario ;
      private bool nV14proveedoresfecreg ;
      private bool nV15proveedoresfecultact ;
      private String A136proveedoresusuario ;
      private String A135proveedoresrfc ;
      private String A134proveedoresfax ;
      private String A133proveedorestelefono2 ;
      private String A132proveedorestelefono1 ;
      private String A131proveedorestado ;
      private String A130proveedoresmunicipio ;
      private String A129proveedorescodigopostal ;
      private String A128proveedorescolonia ;
      private String A127proveedoresdireccion ;
      private String A126proveedoresnombre ;
      private String AV3proveedoresnombre ;
      private String AV4proveedoresdireccion ;
      private String AV5proveedorescolonia ;
      private String AV6proveedorescodigopostal ;
      private String AV7proveedoresmunicipio ;
      private String AV8proveedorestado ;
      private String AV11proveedoresfax ;
      private String AV12proveedoresrfc ;
      private String AV13proveedoresusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] PROVEEDORE2_A138proveedoresfecultact ;
      private bool[] PROVEEDORE2_n138proveedoresfecultact ;
      private DateTime[] PROVEEDORE2_A137proveedoresfecreg ;
      private bool[] PROVEEDORE2_n137proveedoresfecreg ;
      private String[] PROVEEDORE2_A136proveedoresusuario ;
      private bool[] PROVEEDORE2_n136proveedoresusuario ;
      private String[] PROVEEDORE2_A135proveedoresrfc ;
      private bool[] PROVEEDORE2_n135proveedoresrfc ;
      private String[] PROVEEDORE2_A134proveedoresfax ;
      private bool[] PROVEEDORE2_n134proveedoresfax ;
      private String[] PROVEEDORE2_A133proveedorestelefono2 ;
      private bool[] PROVEEDORE2_n133proveedorestelefono2 ;
      private String[] PROVEEDORE2_A132proveedorestelefono1 ;
      private bool[] PROVEEDORE2_n132proveedorestelefono1 ;
      private String[] PROVEEDORE2_A131proveedorestado ;
      private bool[] PROVEEDORE2_n131proveedorestado ;
      private String[] PROVEEDORE2_A130proveedoresmunicipio ;
      private bool[] PROVEEDORE2_n130proveedoresmunicipio ;
      private String[] PROVEEDORE2_A129proveedorescodigopostal ;
      private bool[] PROVEEDORE2_n129proveedorescodigopostal ;
      private String[] PROVEEDORE2_A128proveedorescolonia ;
      private bool[] PROVEEDORE2_n128proveedorescolonia ;
      private String[] PROVEEDORE2_A127proveedoresdireccion ;
      private bool[] PROVEEDORE2_n127proveedoresdireccion ;
      private String[] PROVEEDORE2_A126proveedoresnombre ;
      private bool[] PROVEEDORE2_n126proveedoresnombre ;
      private int[] PROVEEDORE2_A2proveedoresid ;
      private long[] PROVEEDORE2_A40000GXC1 ;
      private long[] PROVEEDORE2_A40001GXC2 ;
   }

   public class proveedoresconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPROVEEDORE2 ;
          prmPROVEEDORE2 = new Object[] {
          } ;
          Object[] prmPROVEEDORE3 ;
          prmPROVEEDORE3 = new Object[] {
          new Object[] {"AV2proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3proveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"AV4proveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV5proveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"AV6proveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"AV7proveedoresmunicipio",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"AV8proveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"AV9proveedorestelefono1",NpgsqlDbType.Real,10,0} ,
          new Object[] {"AV10proveedorestelefono2",NpgsqlDbType.Real,10,0} ,
          new Object[] {"AV11proveedoresfax",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV12proveedoresrfc",NpgsqlDbType.Varchar,13,0} ,
          new Object[] {"AV13proveedoresusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV14proveedoresfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV15proveedoresfecultact",NpgsqlDbType.Date,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PROVEEDORE2", "SELECT proveedoresfecultact, proveedoresfecreg, proveedoresusuario, proveedoresrfc, proveedoresfax, proveedorestelefono2, proveedorestelefono1, proveedorestado, proveedoresmunicipio, proveedorescodigopostal, proveedorescolonia, proveedoresdireccion, proveedoresnombre, proveedoresid, CASE  WHEN LENGTH(TRIM(TRANSLATE(COALESCE( proveedorestelefono1, ''), ' ', ' +-.0123456789'))) > 0 OR COALESCE( proveedorestelefono1, '')= ' ' THEN 0 ELSE TO_NUMBER(0 || COALESCE( proveedorestelefono1, ''),'FM9999999999999999999999999999.99999999999999') END AS GXC1, CASE  WHEN LENGTH(TRIM(TRANSLATE(COALESCE( proveedorestelefono2, ''), ' ', ' +-.0123456789'))) > 0 OR COALESCE( proveedorestelefono2, '')= ' ' THEN 0 ELSE TO_NUMBER(0 || COALESCE( proveedorestelefono2, ''),'FM9999999999999999999999999999.99999999999999') END AS GXC2 FROM public.proveedores ORDER BY proveedoresid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPROVEEDORE2,100,0,true,false )
             ,new CursorDef("PROVEEDORE3", "INSERT INTO GXA0010(proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact) VALUES(:AV2proveedoresid, :AV3proveedoresnombre, :AV4proveedoresdireccion, :AV5proveedorescolonia, :AV6proveedorescodigopostal, :AV7proveedoresmunicipio, :AV8proveedorestado, :AV9proveedorestelefono1, :AV10proveedorestelefono2, :AV11proveedoresfax, :AV12proveedoresrfc, :AV13proveedoresusuario, :AV14proveedoresfecreg, :AV15proveedoresfecultact)", GxErrorMask.GX_NOMASK,prmPROVEEDORE3)
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
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((int[]) buf[26])[0] = rslt.getInt(14) ;
                ((long[]) buf[27])[0] = rslt.getLong(15) ;
                ((long[]) buf[28])[0] = rslt.getLong(16) ;
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
                   stmt.setNull( 12 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[22]);
                }
                if ( (bool)parms[23] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[24]);
                }
                if ( (bool)parms[25] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(14, (DateTime)parms[26]);
                }
                return;
       }
    }

 }

}
