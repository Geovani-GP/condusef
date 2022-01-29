/*
               File: productoConversion
        Description: Conversion for table producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:44:58.4
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
   public class productoconversion : GXProcedure
   {
      public productoconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public productoconversion( IGxContext context )
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
         productoconversion objproductoconversion;
         objproductoconversion = new productoconversion();
         objproductoconversion.context.SetSubmitInitialConfig(context);
         objproductoconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objproductoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((productoconversion)stateInfo).executePrivate();
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
         /* Using cursor PRODUCTOCO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A23tipobienid = PRODUCTOCO2_A23tipobienid[0];
            A93productofecultact = PRODUCTOCO2_A93productofecultact[0];
            n93productofecultact = PRODUCTOCO2_n93productofecultact[0];
            A92productofecreg = PRODUCTOCO2_A92productofecreg[0];
            n92productofecreg = PRODUCTOCO2_n92productofecreg[0];
            A91productousuario = PRODUCTOCO2_A91productousuario[0];
            n91productousuario = PRODUCTOCO2_n91productousuario[0];
            A90categoriaid = PRODUCTOCO2_A90categoriaid[0];
            n90categoriaid = PRODUCTOCO2_n90categoriaid[0];
            A89marcaid = PRODUCTOCO2_A89marcaid[0];
            n89marcaid = PRODUCTOCO2_n89marcaid[0];
            A88modeloid = PRODUCTOCO2_A88modeloid[0];
            n88modeloid = PRODUCTOCO2_n88modeloid[0];
            A87productodsc = PRODUCTOCO2_A87productodsc[0];
            n87productodsc = PRODUCTOCO2_n87productodsc[0];
            A25cambsid = PRODUCTOCO2_A25cambsid[0];
            A175productoid = PRODUCTOCO2_A175productoid[0];
            modelosid = PRODUCTOCO2_A15modelosid[0];
            productocambsid = PRODUCTOCO2_A16productocambsid[0];
            /*
               INSERT RECORD ON TABLE GXA0023

            */
            AV2productoid = A175productoid;
            AV3cambsid = A25cambsid;
            if ( PRODUCTOCO2_n87productodsc[0] )
            {
               AV4productodsc = "";
               nV4productodsc = false;
               nV4productodsc = true;
            }
            else
            {
               AV4productodsc = A87productodsc;
               nV4productodsc = false;
            }
            if ( PRODUCTOCO2_n88modeloid[0] )
            {
               AV5modeloid = 0;
            }
            else
            {
               AV5modeloid = A88modeloid;
            }
            if ( PRODUCTOCO2_n89marcaid[0] )
            {
               AV6marcaid = 0;
               nV6marcaid = false;
               nV6marcaid = true;
            }
            else
            {
               AV6marcaid = A89marcaid;
               nV6marcaid = false;
            }
            if ( PRODUCTOCO2_n90categoriaid[0] )
            {
               AV7categoriaid = 0;
               nV7categoriaid = false;
               nV7categoriaid = true;
            }
            else
            {
               AV7categoriaid = A90categoriaid;
               nV7categoriaid = false;
            }
            if ( PRODUCTOCO2_n91productousuario[0] )
            {
               AV8productousuario = "";
               nV8productousuario = false;
               nV8productousuario = true;
            }
            else
            {
               AV8productousuario = A91productousuario;
               nV8productousuario = false;
            }
            if ( PRODUCTOCO2_n92productofecreg[0] )
            {
               AV9productofecreg = (DateTime)(DateTime.MinValue);
               nV9productofecreg = false;
               nV9productofecreg = true;
            }
            else
            {
               AV9productofecreg = A92productofecreg;
               nV9productofecreg = false;
            }
            if ( PRODUCTOCO2_n93productofecultact[0] )
            {
               AV10productofecultact = (DateTime)(DateTime.MinValue);
               nV10productofecultact = false;
               nV10productofecultact = true;
            }
            else
            {
               AV10productofecultact = A93productofecultact;
               nV10productofecultact = false;
            }
            AV11tipobienid = A23tipobienid;
            /* Using cursor PRODUCTOCO3 */
            pr_default.execute(1, new Object[] {AV2productoid});
            if ( (pr_default.getStatus(1) != 101) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
               /* Using cursor PRODUCTOCO4 */
               pr_default.execute(2, new Object[] {AV2productoid, AV3cambsid, nV4productodsc, AV4productodsc, AV5modeloid, nV6marcaid, AV6marcaid, nV7categoriaid, AV7categoriaid, nV8productousuario, AV8productousuario, nV9productofecreg, AV9productofecreg, nV10productofecultact, AV10productofecultact, AV11tipobienid});
               pr_default.close(2);
               dsDefault.SmartCacheProvider.SetUpdated("GXA0023") ;
            }
            /* End Insert */
            pr_default.close(1);
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
         PRODUCTOCO2_A23tipobienid = new int[1] ;
         PRODUCTOCO2_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         PRODUCTOCO2_n93productofecultact = new bool[] {false} ;
         PRODUCTOCO2_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         PRODUCTOCO2_n92productofecreg = new bool[] {false} ;
         PRODUCTOCO2_A91productousuario = new String[] {""} ;
         PRODUCTOCO2_n91productousuario = new bool[] {false} ;
         PRODUCTOCO2_A90categoriaid = new long[1] ;
         PRODUCTOCO2_n90categoriaid = new bool[] {false} ;
         PRODUCTOCO2_A89marcaid = new long[1] ;
         PRODUCTOCO2_n89marcaid = new bool[] {false} ;
         PRODUCTOCO2_A88modeloid = new long[1] ;
         PRODUCTOCO2_n88modeloid = new bool[] {false} ;
         PRODUCTOCO2_A87productodsc = new String[] {""} ;
         PRODUCTOCO2_n87productodsc = new bool[] {false} ;
         PRODUCTOCO2_A25cambsid = new int[1] ;
         PRODUCTOCO2_A175productoid = new short[1] ;
         PRODUCTOCO2_A15modelosid = new int[1] ;
         PRODUCTOCO2_A16productocambsid = new String[] {""} ;
         A93productofecultact = (DateTime)(DateTime.MinValue);
         A92productofecreg = (DateTime)(DateTime.MinValue);
         A91productousuario = "";
         A87productodsc = "";
         productocambsid = "";
         AV4productodsc = "";
         AV8productousuario = "";
         AV9productofecreg = (DateTime)(DateTime.MinValue);
         AV10productofecultact = (DateTime)(DateTime.MinValue);
         PRODUCTOCO3_AV2productoid = new short[1] ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.productoconversion__default(),
            new Object[][] {
                new Object[] {
               PRODUCTOCO2_A23tipobienid, PRODUCTOCO2_A93productofecultact, PRODUCTOCO2_n93productofecultact, PRODUCTOCO2_A92productofecreg, PRODUCTOCO2_n92productofecreg, PRODUCTOCO2_A91productousuario, PRODUCTOCO2_n91productousuario, PRODUCTOCO2_A90categoriaid, PRODUCTOCO2_n90categoriaid, PRODUCTOCO2_A89marcaid,
               PRODUCTOCO2_n89marcaid, PRODUCTOCO2_A88modeloid, PRODUCTOCO2_n88modeloid, PRODUCTOCO2_A87productodsc, PRODUCTOCO2_n87productodsc, PRODUCTOCO2_A25cambsid, PRODUCTOCO2_A175productoid, PRODUCTOCO2_A15modelosid, PRODUCTOCO2_A16productocambsid
               }
               , new Object[] {
               PRODUCTOCO3_AV2productoid
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A175productoid ;
      private short AV2productoid ;
      private int A23tipobienid ;
      private int A25cambsid ;
      private int modelosid ;
      private int GIGXA0023 ;
      private int AV3cambsid ;
      private int AV11tipobienid ;
      private long A90categoriaid ;
      private long A89marcaid ;
      private long A88modeloid ;
      private long AV5modeloid ;
      private long AV6marcaid ;
      private long AV7categoriaid ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A93productofecultact ;
      private DateTime A92productofecreg ;
      private DateTime AV9productofecreg ;
      private DateTime AV10productofecultact ;
      private bool n93productofecultact ;
      private bool n92productofecreg ;
      private bool n91productousuario ;
      private bool n90categoriaid ;
      private bool n89marcaid ;
      private bool n88modeloid ;
      private bool n87productodsc ;
      private bool nV4productodsc ;
      private bool nV6marcaid ;
      private bool nV7categoriaid ;
      private bool nV8productousuario ;
      private bool nV9productofecreg ;
      private bool nV10productofecultact ;
      private String A91productousuario ;
      private String A87productodsc ;
      private String productocambsid ;
      private String AV4productodsc ;
      private String AV8productousuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] PRODUCTOCO2_A23tipobienid ;
      private DateTime[] PRODUCTOCO2_A93productofecultact ;
      private bool[] PRODUCTOCO2_n93productofecultact ;
      private DateTime[] PRODUCTOCO2_A92productofecreg ;
      private bool[] PRODUCTOCO2_n92productofecreg ;
      private String[] PRODUCTOCO2_A91productousuario ;
      private bool[] PRODUCTOCO2_n91productousuario ;
      private long[] PRODUCTOCO2_A90categoriaid ;
      private bool[] PRODUCTOCO2_n90categoriaid ;
      private long[] PRODUCTOCO2_A89marcaid ;
      private bool[] PRODUCTOCO2_n89marcaid ;
      private long[] PRODUCTOCO2_A88modeloid ;
      private bool[] PRODUCTOCO2_n88modeloid ;
      private String[] PRODUCTOCO2_A87productodsc ;
      private bool[] PRODUCTOCO2_n87productodsc ;
      private int[] PRODUCTOCO2_A25cambsid ;
      private short[] PRODUCTOCO2_A175productoid ;
      private int[] PRODUCTOCO2_A15modelosid ;
      private String[] PRODUCTOCO2_A16productocambsid ;
      private short[] PRODUCTOCO3_AV2productoid ;
   }

   public class productoconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmPRODUCTOCO2 ;
          prmPRODUCTOCO2 = new Object[] {
          } ;
          Object[] prmPRODUCTOCO3 ;
          prmPRODUCTOCO3 = new Object[] {
          new Object[] {"AV2productoid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmPRODUCTOCO4 ;
          prmPRODUCTOCO4 = new Object[] {
          new Object[] {"AV2productoid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV3cambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV4productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV5modeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV6marcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV7categoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV8productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV9productofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV10productofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV11tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODUCTOCO2", "SELECT tipobienid, productofecultact, productofecreg, productousuario, categoriaid, marcaid, modeloid, productodsc, cambsid, productoid, modelosid, productocambsid FROM public.producto ORDER BY modelosid, productocambsid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODUCTOCO2,100,0,true,false )
             ,new CursorDef("PRODUCTOCO3", "SELECT productoid FROM GXA0023 WHERE productoid = :AV2productoid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODUCTOCO3,1,0,true,false )
             ,new CursorDef("PRODUCTOCO4", "INSERT INTO GXA0023(productoid, cambsid, productodsc, modeloid, marcaid, categoriaid, productousuario, productofecreg, productofecultact, tipobienid) VALUES(:AV2productoid, :AV3cambsid, :AV4productodsc, :AV5modeloid, :AV6marcaid, :AV7categoriaid, :AV8productousuario, :AV9productofecreg, :AV10productofecultact, :AV11tipobienid)", GxErrorMask.GX_NOMASK,prmPRODUCTOCO4)
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((int[]) buf[17])[0] = rslt.getInt(11) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(12) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                stmt.SetParameter(4, (long)parms[4]);
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
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (long)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[14]);
                }
                stmt.SetParameter(10, (int)parms[15]);
                return;
       }
    }

 }

}
