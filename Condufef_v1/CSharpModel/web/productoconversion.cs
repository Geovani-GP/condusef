/*
               File: productoConversion
        Description: Conversion for table producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/10/2022 23:5:22.77
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
            A183ptipobienid = PRODUCTOCO2_A183ptipobienid[0];
            n183ptipobienid = PRODUCTOCO2_n183ptipobienid[0];
            A182pcategoriaid = PRODUCTOCO2_A182pcategoriaid[0];
            n182pcategoriaid = PRODUCTOCO2_n182pcategoriaid[0];
            A181pmarcaid = PRODUCTOCO2_A181pmarcaid[0];
            n181pmarcaid = PRODUCTOCO2_n181pmarcaid[0];
            A180pmodeloid = PRODUCTOCO2_A180pmodeloid[0];
            n180pmodeloid = PRODUCTOCO2_n180pmodeloid[0];
            A179pcambsid = PRODUCTOCO2_A179pcambsid[0];
            n179pcambsid = PRODUCTOCO2_n179pcambsid[0];
            A93productofecultact = PRODUCTOCO2_A93productofecultact[0];
            n93productofecultact = PRODUCTOCO2_n93productofecultact[0];
            A92productofecreg = PRODUCTOCO2_A92productofecreg[0];
            n92productofecreg = PRODUCTOCO2_n92productofecreg[0];
            A91productousuario = PRODUCTOCO2_A91productousuario[0];
            n91productousuario = PRODUCTOCO2_n91productousuario[0];
            A87productodsc = PRODUCTOCO2_A87productodsc[0];
            n87productodsc = PRODUCTOCO2_n87productodsc[0];
            A175productoid = PRODUCTOCO2_A175productoid[0];
            modelosid = PRODUCTOCO2_A15modelosid[0];
            productocambsid = PRODUCTOCO2_A16productocambsid[0];
            /*
               INSERT RECORD ON TABLE GXA0023

            */
            AV2productoid = A175productoid;
            if ( PRODUCTOCO2_n87productodsc[0] )
            {
               AV3productodsc = "";
               nV3productodsc = false;
               nV3productodsc = true;
            }
            else
            {
               AV3productodsc = A87productodsc;
               nV3productodsc = false;
            }
            if ( PRODUCTOCO2_n91productousuario[0] )
            {
               AV4productousuario = "";
               nV4productousuario = false;
               nV4productousuario = true;
            }
            else
            {
               AV4productousuario = A91productousuario;
               nV4productousuario = false;
            }
            if ( PRODUCTOCO2_n92productofecreg[0] )
            {
               AV5productofecreg = DateTime.MinValue;
               nV5productofecreg = false;
               nV5productofecreg = true;
            }
            else
            {
               AV5productofecreg = DateTimeUtil.ResetTime(A92productofecreg);
               nV5productofecreg = false;
            }
            if ( PRODUCTOCO2_n93productofecultact[0] )
            {
               AV6productofecultact = DateTime.MinValue;
               nV6productofecultact = false;
               nV6productofecultact = true;
            }
            else
            {
               AV6productofecultact = DateTimeUtil.ResetTime(A93productofecultact);
               nV6productofecultact = false;
            }
            if ( PRODUCTOCO2_n179pcambsid[0] )
            {
               AV7pcambsid = 0;
               nV7pcambsid = false;
               nV7pcambsid = true;
            }
            else
            {
               AV7pcambsid = A179pcambsid;
               nV7pcambsid = false;
            }
            if ( PRODUCTOCO2_n180pmodeloid[0] )
            {
               AV8pmodeloid = 0;
               nV8pmodeloid = false;
               nV8pmodeloid = true;
            }
            else
            {
               AV8pmodeloid = A180pmodeloid;
               nV8pmodeloid = false;
            }
            if ( PRODUCTOCO2_n181pmarcaid[0] )
            {
               AV9pmarcaid = 0;
               nV9pmarcaid = false;
               nV9pmarcaid = true;
            }
            else
            {
               AV9pmarcaid = A181pmarcaid;
               nV9pmarcaid = false;
            }
            if ( PRODUCTOCO2_n182pcategoriaid[0] )
            {
               AV10pcategoriaid = 0;
               nV10pcategoriaid = false;
               nV10pcategoriaid = true;
            }
            else
            {
               AV10pcategoriaid = A182pcategoriaid;
               nV10pcategoriaid = false;
            }
            if ( PRODUCTOCO2_n183ptipobienid[0] )
            {
               AV11ptipobienid = 0;
               nV11ptipobienid = false;
               nV11ptipobienid = true;
            }
            else
            {
               AV11ptipobienid = A183ptipobienid;
               nV11ptipobienid = false;
            }
            /* Using cursor PRODUCTOCO3 */
            pr_default.execute(1, new Object[] {AV2productoid, nV3productodsc, AV3productodsc, nV4productousuario, AV4productousuario, nV5productofecreg, AV5productofecreg, nV6productofecultact, AV6productofecultact, nV7pcambsid, AV7pcambsid, nV8pmodeloid, AV8pmodeloid, nV9pmarcaid, AV9pmarcaid, nV10pcategoriaid, AV10pcategoriaid, nV11ptipobienid, AV11ptipobienid});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0023") ;
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
         PRODUCTOCO2_A183ptipobienid = new short[1] ;
         PRODUCTOCO2_n183ptipobienid = new bool[] {false} ;
         PRODUCTOCO2_A182pcategoriaid = new short[1] ;
         PRODUCTOCO2_n182pcategoriaid = new bool[] {false} ;
         PRODUCTOCO2_A181pmarcaid = new short[1] ;
         PRODUCTOCO2_n181pmarcaid = new bool[] {false} ;
         PRODUCTOCO2_A180pmodeloid = new short[1] ;
         PRODUCTOCO2_n180pmodeloid = new bool[] {false} ;
         PRODUCTOCO2_A179pcambsid = new short[1] ;
         PRODUCTOCO2_n179pcambsid = new bool[] {false} ;
         PRODUCTOCO2_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         PRODUCTOCO2_n93productofecultact = new bool[] {false} ;
         PRODUCTOCO2_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         PRODUCTOCO2_n92productofecreg = new bool[] {false} ;
         PRODUCTOCO2_A91productousuario = new String[] {""} ;
         PRODUCTOCO2_n91productousuario = new bool[] {false} ;
         PRODUCTOCO2_A87productodsc = new String[] {""} ;
         PRODUCTOCO2_n87productodsc = new bool[] {false} ;
         PRODUCTOCO2_A175productoid = new int[1] ;
         PRODUCTOCO2_A15modelosid = new int[1] ;
         PRODUCTOCO2_A16productocambsid = new String[] {""} ;
         A93productofecultact = (DateTime)(DateTime.MinValue);
         A92productofecreg = (DateTime)(DateTime.MinValue);
         A91productousuario = "";
         A87productodsc = "";
         productocambsid = "";
         AV3productodsc = "";
         AV4productousuario = "";
         AV5productofecreg = DateTime.MinValue;
         AV6productofecultact = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.productoconversion__default(),
            new Object[][] {
                new Object[] {
               PRODUCTOCO2_A183ptipobienid, PRODUCTOCO2_n183ptipobienid, PRODUCTOCO2_A182pcategoriaid, PRODUCTOCO2_n182pcategoriaid, PRODUCTOCO2_A181pmarcaid, PRODUCTOCO2_n181pmarcaid, PRODUCTOCO2_A180pmodeloid, PRODUCTOCO2_n180pmodeloid, PRODUCTOCO2_A179pcambsid, PRODUCTOCO2_n179pcambsid,
               PRODUCTOCO2_A93productofecultact, PRODUCTOCO2_n93productofecultact, PRODUCTOCO2_A92productofecreg, PRODUCTOCO2_n92productofecreg, PRODUCTOCO2_A91productousuario, PRODUCTOCO2_n91productousuario, PRODUCTOCO2_A87productodsc, PRODUCTOCO2_n87productodsc, PRODUCTOCO2_A175productoid, PRODUCTOCO2_A15modelosid,
               PRODUCTOCO2_A16productocambsid
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A183ptipobienid ;
      private short A182pcategoriaid ;
      private short A181pmarcaid ;
      private short A180pmodeloid ;
      private short A179pcambsid ;
      private short AV7pcambsid ;
      private short AV8pmodeloid ;
      private short AV9pmarcaid ;
      private short AV10pcategoriaid ;
      private short AV11ptipobienid ;
      private int A175productoid ;
      private int modelosid ;
      private int GIGXA0023 ;
      private int AV2productoid ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A93productofecultact ;
      private DateTime A92productofecreg ;
      private DateTime AV5productofecreg ;
      private DateTime AV6productofecultact ;
      private bool n183ptipobienid ;
      private bool n182pcategoriaid ;
      private bool n181pmarcaid ;
      private bool n180pmodeloid ;
      private bool n179pcambsid ;
      private bool n93productofecultact ;
      private bool n92productofecreg ;
      private bool n91productousuario ;
      private bool n87productodsc ;
      private bool nV3productodsc ;
      private bool nV4productousuario ;
      private bool nV5productofecreg ;
      private bool nV6productofecultact ;
      private bool nV7pcambsid ;
      private bool nV8pmodeloid ;
      private bool nV9pmarcaid ;
      private bool nV10pcategoriaid ;
      private bool nV11ptipobienid ;
      private String A91productousuario ;
      private String A87productodsc ;
      private String productocambsid ;
      private String AV3productodsc ;
      private String AV4productousuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] PRODUCTOCO2_A183ptipobienid ;
      private bool[] PRODUCTOCO2_n183ptipobienid ;
      private short[] PRODUCTOCO2_A182pcategoriaid ;
      private bool[] PRODUCTOCO2_n182pcategoriaid ;
      private short[] PRODUCTOCO2_A181pmarcaid ;
      private bool[] PRODUCTOCO2_n181pmarcaid ;
      private short[] PRODUCTOCO2_A180pmodeloid ;
      private bool[] PRODUCTOCO2_n180pmodeloid ;
      private short[] PRODUCTOCO2_A179pcambsid ;
      private bool[] PRODUCTOCO2_n179pcambsid ;
      private DateTime[] PRODUCTOCO2_A93productofecultact ;
      private bool[] PRODUCTOCO2_n93productofecultact ;
      private DateTime[] PRODUCTOCO2_A92productofecreg ;
      private bool[] PRODUCTOCO2_n92productofecreg ;
      private String[] PRODUCTOCO2_A91productousuario ;
      private bool[] PRODUCTOCO2_n91productousuario ;
      private String[] PRODUCTOCO2_A87productodsc ;
      private bool[] PRODUCTOCO2_n87productodsc ;
      private int[] PRODUCTOCO2_A175productoid ;
      private int[] PRODUCTOCO2_A15modelosid ;
      private String[] PRODUCTOCO2_A16productocambsid ;
   }

   public class productoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPRODUCTOCO2 ;
          prmPRODUCTOCO2 = new Object[] {
          } ;
          Object[] prmPRODUCTOCO3 ;
          prmPRODUCTOCO3 = new Object[] {
          new Object[] {"AV2productoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV4productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV5productofecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV6productofecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV7pcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV8pmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV9pmarcaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV10pcategoriaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV11ptipobienid",NpgsqlDbType.Smallint,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODUCTOCO2", "SELECT ptipobienid, pcategoriaid, pmarcaid, pmodeloid, pcambsid, productofecultact, productofecreg, productousuario, productodsc, productoid, modelosid, productocambsid FROM public.producto ORDER BY modelosid, productocambsid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODUCTOCO2,100,0,true,false )
             ,new CursorDef("PRODUCTOCO3", "INSERT INTO GXA0023(productoid, productodsc, productousuario, productofecreg, productofecultact, pcambsid, pmodeloid, pmarcaid, pcategoriaid, ptipobienid) VALUES(:AV2productoid, :AV3productodsc, :AV4productousuario, :AV5productofecreg, :AV6productofecultact, :AV7pcambsid, :AV8pmodeloid, :AV9pmarcaid, :AV10pcategoriaid, :AV11ptipobienid)", GxErrorMask.GX_NOMASK,prmPRODUCTOCO3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((int[]) buf[18])[0] = rslt.getInt(10) ;
                ((int[]) buf[19])[0] = rslt.getInt(11) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(12) ;
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[8]);
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
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[16]);
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
       }
    }

 }

}
