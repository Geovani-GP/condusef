/*
               File: PDF_proveedores
        Description: PDF_proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:39:27.94
       Program type: Main program
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
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class apdf_proveedores : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Flat");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public apdf_proveedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public apdf_proveedores( IGxContext context )
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
         apdf_proveedores objapdf_proveedores;
         objapdf_proveedores = new apdf_proveedores();
         objapdf_proveedores.context.SetSubmitInitialConfig(context);
         objapdf_proveedores.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapdf_proveedores);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apdf_proveedores)stateInfo).executePrivate();
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
         M_top = 0;
         M_bot = 6;
         P_lines = (int)(66-M_bot);
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15;
         PrtOffset = 0;
         gxXPage = 100;
         gxYPage = 100;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 1, 15840, 12240, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6));
            Gx_line = (int)(P_lines+1);
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV8FECHA = DateTimeUtil.Today( context);
            H0K0( false, 153) ;
            getPrinter().GxDrawBitMap(context.GetImagePath( "50a9fefa-952a-4474-8e37-0c75e294c1c6", "", context.GetTheme( )), 0, Gx_line+0, 130, Gx_line+69) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("CLAVE ", 0, Gx_line+100, 40, Gx_line+119, 0, 0, 0, 0) ;
            getPrinter().GxDrawText(context.localUtil.Format( AV8FECHA, "99/99/99"), 650, Gx_line+50, 724, Gx_line+72, 2, 0, 0, 0) ;
            getPrinter().GxDrawText("R.F.C.", 242, Gx_line+100, 274, Gx_line+114, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("COLONIA", 367, Gx_line+100, 417, Gx_line+114, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("MUNICIPIO", 500, Gx_line+100, 559, Gx_line+114, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("ESTADO", 608, Gx_line+100, 655, Gx_line+114, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("TELEFONO", 708, Gx_line+100, 768, Gx_line+114, 0+256, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("NOMBRE", 92, Gx_line+100, 149, Gx_line+116, 0+256, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("COMISION NACIONAL PARA LA PROTECCIÓN Y DEFENSA DE LOS USUARIOS DE SERVICIOS FINANCIEROS", 142, Gx_line+17, 1392, Gx_line+37, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("REPORTE DE PRROVEEDORES", 325, Gx_line+50, 525, Gx_line+68, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+153);
            /* Using cursor P000K2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A132proveedorestelefono1 = P000K2_A132proveedorestelefono1[0];
               n132proveedorestelefono1 = P000K2_n132proveedorestelefono1[0];
               A131proveedorestado = P000K2_A131proveedorestado[0];
               n131proveedorestado = P000K2_n131proveedorestado[0];
               A130proveedoresmunicipio = P000K2_A130proveedoresmunicipio[0];
               n130proveedoresmunicipio = P000K2_n130proveedoresmunicipio[0];
               A2proveedoresid = P000K2_A2proveedoresid[0];
               A135proveedoresrfc = P000K2_A135proveedoresrfc[0];
               n135proveedoresrfc = P000K2_n135proveedoresrfc[0];
               A126proveedoresnombre = P000K2_A126proveedoresnombre[0];
               n126proveedoresnombre = P000K2_n126proveedoresnombre[0];
               A128proveedorescolonia = P000K2_A128proveedorescolonia[0];
               n128proveedorescolonia = P000K2_n128proveedorescolonia[0];
               H0K0( false, 36) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, "")), 375, Gx_line+0, 475, Gx_line+15, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A135proveedoresrfc, "")), 233, Gx_line+0, 383, Gx_line+15, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A130proveedoresmunicipio, "")), 517, Gx_line+0, 648, Gx_line+15, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A131proveedorestado, "")), 642, Gx_line+0, 747, Gx_line+15, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A132proveedorestelefono1), "ZZZZZZZZZ9")), 717, Gx_line+0, 781, Gx_line+15, 2+256, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, "")), 92, Gx_line+0, 242, Gx_line+17, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")), 0, Gx_line+0, 150, Gx_line+17, 0, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+36);
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      protected void H0K0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0;
               Gx_line = 0;
               Gx_page = (int)(Gx_page+1);
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight));
               /* Print headers */
               getPrinter().GxStartPage() ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0;
               Gx_line = (int)(Gx_line+1);
            }
            ToSkip = (int)(ToSkip-1);
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
         add_metrics1( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if (IsMain)	waitPrinterEnd();
         base.cleanup();
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
         GXKey = "";
         gxfirstwebparm = "";
         AV8FECHA = DateTime.MinValue;
         scmdbuf = "";
         P000K2_A132proveedorestelefono1 = new long[1] ;
         P000K2_n132proveedorestelefono1 = new bool[] {false} ;
         P000K2_A131proveedorestado = new String[] {""} ;
         P000K2_n131proveedorestado = new bool[] {false} ;
         P000K2_A130proveedoresmunicipio = new String[] {""} ;
         P000K2_n130proveedoresmunicipio = new bool[] {false} ;
         P000K2_A2proveedoresid = new int[1] ;
         P000K2_A135proveedoresrfc = new String[] {""} ;
         P000K2_n135proveedoresrfc = new bool[] {false} ;
         P000K2_A126proveedoresnombre = new String[] {""} ;
         P000K2_n126proveedoresnombre = new bool[] {false} ;
         P000K2_A128proveedorescolonia = new String[] {""} ;
         P000K2_n128proveedorescolonia = new bool[] {false} ;
         A131proveedorestado = "";
         A130proveedoresmunicipio = "";
         A135proveedoresrfc = "";
         A126proveedoresnombre = "";
         A128proveedorescolonia = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apdf_proveedores__default(),
            new Object[][] {
                new Object[] {
               P000K2_A132proveedorestelefono1, P000K2_n132proveedorestelefono1, P000K2_A131proveedorestado, P000K2_n131proveedorestado, P000K2_A130proveedoresmunicipio, P000K2_n130proveedoresmunicipio, P000K2_A2proveedoresid, P000K2_A135proveedoresrfc, P000K2_n135proveedoresrfc, P000K2_A126proveedoresnombre,
               P000K2_n126proveedoresnombre, P000K2_A128proveedorescolonia, P000K2_n128proveedorescolonia
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0;
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short GxWebError ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private int A2proveedoresid ;
      private long A132proveedorestelefono1 ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private DateTime AV8FECHA ;
      private bool entryPointCalled ;
      private bool n132proveedorestelefono1 ;
      private bool n131proveedorestado ;
      private bool n130proveedoresmunicipio ;
      private bool n135proveedoresrfc ;
      private bool n126proveedoresnombre ;
      private bool n128proveedorescolonia ;
      private String A131proveedorestado ;
      private String A130proveedoresmunicipio ;
      private String A135proveedoresrfc ;
      private String A126proveedoresnombre ;
      private String A128proveedorescolonia ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000K2_A132proveedorestelefono1 ;
      private bool[] P000K2_n132proveedorestelefono1 ;
      private String[] P000K2_A131proveedorestado ;
      private bool[] P000K2_n131proveedorestado ;
      private String[] P000K2_A130proveedoresmunicipio ;
      private bool[] P000K2_n130proveedoresmunicipio ;
      private int[] P000K2_A2proveedoresid ;
      private String[] P000K2_A135proveedoresrfc ;
      private bool[] P000K2_n135proveedoresrfc ;
      private String[] P000K2_A126proveedoresnombre ;
      private bool[] P000K2_n126proveedoresnombre ;
      private String[] P000K2_A128proveedorescolonia ;
      private bool[] P000K2_n128proveedorescolonia ;
   }

   public class apdf_proveedores__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000K2 ;
          prmP000K2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000K2", "SELECT proveedorestelefono1, proveedorestado, proveedoresmunicipio, proveedoresid, proveedoresrfc, proveedoresnombre, proveedorescolonia FROM public.proveedores ORDER BY proveedoresid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K2,100,0,false,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
