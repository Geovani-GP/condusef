/*
               File: tipobienConversion
        Description: Conversion for table tipobien
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 1:0:45.34
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
   public class tipobienconversion : GXProcedure
   {
      public tipobienconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public tipobienconversion( IGxContext context )
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
         tipobienconversion objtipobienconversion;
         objtipobienconversion = new tipobienconversion();
         objtipobienconversion.context.SetSubmitInitialConfig(context);
         objtipobienconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objtipobienconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipobienconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOBIENCO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A139tipobiendsc = TIPOBIENCO2_A139tipobiendsc[0];
            n139tipobiendsc = TIPOBIENCO2_n139tipobiendsc[0];
            A142tipobienfecultact = TIPOBIENCO2_A142tipobienfecultact[0];
            n142tipobienfecultact = TIPOBIENCO2_n142tipobienfecultact[0];
            A141tipobienfecreg = TIPOBIENCO2_A141tipobienfecreg[0];
            n141tipobienfecreg = TIPOBIENCO2_n141tipobienfecreg[0];
            A140tipobienusuario = TIPOBIENCO2_A140tipobienusuario[0];
            n140tipobienusuario = TIPOBIENCO2_n140tipobienusuario[0];
            A23tipobienid = TIPOBIENCO2_A23tipobienid[0];
            /*
               INSERT RECORD ON TABLE GXA0001

            */
            AV2tipobienid = A23tipobienid;
            if ( TIPOBIENCO2_n140tipobienusuario[0] )
            {
               AV3tipobienusuario = "";
               nV3tipobienusuario = false;
               nV3tipobienusuario = true;
            }
            else
            {
               AV3tipobienusuario = A140tipobienusuario;
               nV3tipobienusuario = false;
            }
            if ( TIPOBIENCO2_n141tipobienfecreg[0] )
            {
               AV4tipobienfecreg = DateTime.MinValue;
               nV4tipobienfecreg = false;
               nV4tipobienfecreg = true;
            }
            else
            {
               AV4tipobienfecreg = DateTimeUtil.ResetTime(A141tipobienfecreg);
               nV4tipobienfecreg = false;
            }
            if ( TIPOBIENCO2_n142tipobienfecultact[0] )
            {
               AV5tipobienfecultact = DateTime.MinValue;
               nV5tipobienfecultact = false;
               nV5tipobienfecultact = true;
            }
            else
            {
               AV5tipobienfecultact = DateTimeUtil.ResetTime(A142tipobienfecultact);
               nV5tipobienfecultact = false;
            }
            if ( TIPOBIENCO2_n139tipobiendsc[0] )
            {
               AV6tipobiendsc = "";
               nV6tipobiendsc = false;
               nV6tipobiendsc = true;
            }
            else
            {
               AV6tipobiendsc = A139tipobiendsc;
               nV6tipobiendsc = false;
            }
            /* Using cursor TIPOBIENCO3 */
            pr_default.execute(1, new Object[] {AV2tipobienid, nV3tipobienusuario, AV3tipobienusuario, nV4tipobienfecreg, AV4tipobienfecreg, nV5tipobienfecultact, AV5tipobienfecultact, nV6tipobiendsc, AV6tipobiendsc});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0001") ;
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
         TIPOBIENCO2_A139tipobiendsc = new String[] {""} ;
         TIPOBIENCO2_n139tipobiendsc = new bool[] {false} ;
         TIPOBIENCO2_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         TIPOBIENCO2_n142tipobienfecultact = new bool[] {false} ;
         TIPOBIENCO2_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         TIPOBIENCO2_n141tipobienfecreg = new bool[] {false} ;
         TIPOBIENCO2_A140tipobienusuario = new String[] {""} ;
         TIPOBIENCO2_n140tipobienusuario = new bool[] {false} ;
         TIPOBIENCO2_A23tipobienid = new int[1] ;
         A139tipobiendsc = "";
         A142tipobienfecultact = (DateTime)(DateTime.MinValue);
         A141tipobienfecreg = (DateTime)(DateTime.MinValue);
         A140tipobienusuario = "";
         AV3tipobienusuario = "";
         AV4tipobienfecreg = DateTime.MinValue;
         AV5tipobienfecultact = DateTime.MinValue;
         AV6tipobiendsc = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipobienconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOBIENCO2_A139tipobiendsc, TIPOBIENCO2_n139tipobiendsc, TIPOBIENCO2_A142tipobienfecultact, TIPOBIENCO2_n142tipobienfecultact, TIPOBIENCO2_A141tipobienfecreg, TIPOBIENCO2_n141tipobienfecreg, TIPOBIENCO2_A140tipobienusuario, TIPOBIENCO2_n140tipobienusuario, TIPOBIENCO2_A23tipobienid
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A23tipobienid ;
      private int GIGXA0001 ;
      private int AV2tipobienid ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A142tipobienfecultact ;
      private DateTime A141tipobienfecreg ;
      private DateTime AV4tipobienfecreg ;
      private DateTime AV5tipobienfecultact ;
      private bool n139tipobiendsc ;
      private bool n142tipobienfecultact ;
      private bool n141tipobienfecreg ;
      private bool n140tipobienusuario ;
      private bool nV3tipobienusuario ;
      private bool nV4tipobienfecreg ;
      private bool nV5tipobienfecultact ;
      private bool nV6tipobiendsc ;
      private String A139tipobiendsc ;
      private String A140tipobienusuario ;
      private String AV3tipobienusuario ;
      private String AV6tipobiendsc ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] TIPOBIENCO2_A139tipobiendsc ;
      private bool[] TIPOBIENCO2_n139tipobiendsc ;
      private DateTime[] TIPOBIENCO2_A142tipobienfecultact ;
      private bool[] TIPOBIENCO2_n142tipobienfecultact ;
      private DateTime[] TIPOBIENCO2_A141tipobienfecreg ;
      private bool[] TIPOBIENCO2_n141tipobienfecreg ;
      private String[] TIPOBIENCO2_A140tipobienusuario ;
      private bool[] TIPOBIENCO2_n140tipobienusuario ;
      private int[] TIPOBIENCO2_A23tipobienid ;
   }

   public class tipobienconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOBIENCO2 ;
          prmTIPOBIENCO2 = new Object[] {
          } ;
          Object[] prmTIPOBIENCO3 ;
          prmTIPOBIENCO3 = new Object[] {
          new Object[] {"AV2tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3tipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV4tipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV5tipobienfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV6tipobiendsc",NpgsqlDbType.Varchar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOBIENCO2", "SELECT tipobiendsc, tipobienfecultact, tipobienfecreg, tipobienusuario, tipobienid FROM public.tipobien ORDER BY tipobienid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOBIENCO2,100,0,true,false )
             ,new CursorDef("TIPOBIENCO3", "INSERT INTO GXA0001(tipobienid, tipobienusuario, tipobienfecreg, tipobienfecultact, tipobiendsc) VALUES(:AV2tipobienid, :AV3tipobienusuario, :AV4tipobienfecreg, :AV5tipobienfecultact, :AV6tipobiendsc)", GxErrorMask.GX_NOMASK,prmTIPOBIENCO3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[4]);
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                return;
       }
    }

 }

}
