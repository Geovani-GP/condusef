/*
               File: articulosConversion
        Description: Conversion for table articulos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/1/2022 0:22:20.13
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
   public class articulosconversion : GXProcedure
   {
      public articulosconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public articulosconversion( IGxContext context )
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
         articulosconversion objarticulosconversion;
         objarticulosconversion = new articulosconversion();
         objarticulosconversion.context.SetSubmitInitialConfig(context);
         objarticulosconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objarticulosconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((articulosconversion)stateInfo).executePrivate();
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
         /* Using cursor ARTICULOSC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A172articulosfecultact = ARTICULOSC2_A172articulosfecultact[0];
            n172articulosfecultact = ARTICULOSC2_n172articulosfecultact[0];
            A171articulosfecreg = ARTICULOSC2_A171articulosfecreg[0];
            n171articulosfecreg = ARTICULOSC2_n171articulosfecreg[0];
            A170articulostipobien = ARTICULOSC2_A170articulostipobien[0];
            n170articulostipobien = ARTICULOSC2_n170articulostipobien[0];
            A169articulosestatusariticulo = ARTICULOSC2_A169articulosestatusariticulo[0];
            n169articulosestatusariticulo = ARTICULOSC2_n169articulosestatusariticulo[0];
            A168articulosidtrasfer = ARTICULOSC2_A168articulosidtrasfer[0];
            n168articulosidtrasfer = ARTICULOSC2_n168articulosidtrasfer[0];
            A167articulosusuario = ARTICULOSC2_A167articulosusuario[0];
            n167articulosusuario = ARTICULOSC2_n167articulosusuario[0];
            A166articuloscontejado = ARTICULOSC2_A166articuloscontejado[0];
            n166articuloscontejado = ARTICULOSC2_n166articuloscontejado[0];
            A165articulosstatus = ARTICULOSC2_A165articulosstatus[0];
            n165articulosstatus = ARTICULOSC2_n165articulosstatus[0];
            A164articulosfechabajaalma = ARTICULOSC2_A164articulosfechabajaalma[0];
            n164articulosfechabajaalma = ARTICULOSC2_n164articulosfechabajaalma[0];
            A163articulosfechaentraalmacen = ARTICULOSC2_A163articulosfechaentraalmacen[0];
            n163articulosfechaentraalmacen = ARTICULOSC2_n163articulosfechaentraalmacen[0];
            A162articulosfechacoteja = ARTICULOSC2_A162articulosfechacoteja[0];
            n162articulosfechacoteja = ARTICULOSC2_n162articulosfechacoteja[0];
            A161articulosrefdocumento = ARTICULOSC2_A161articulosrefdocumento[0];
            n161articulosrefdocumento = ARTICULOSC2_n161articulosrefdocumento[0];
            A160articulosnumserie = ARTICULOSC2_A160articulosnumserie[0];
            n160articulosnumserie = ARTICULOSC2_n160articulosnumserie[0];
            A159articuloscantdepreacum = ARTICULOSC2_A159articuloscantdepreacum[0];
            n159articuloscantdepreacum = ARTICULOSC2_n159articuloscantdepreacum[0];
            A158articulospreccomprareexp = ARTICULOSC2_A158articulospreccomprareexp[0];
            n158articulospreccomprareexp = ARTICULOSC2_n158articulospreccomprareexp[0];
            A157articulospreciocompra = ARTICULOSC2_A157articulospreciocompra[0];
            n157articulospreciocompra = ARTICULOSC2_n157articulospreciocompra[0];
            A2proveedoresid = ARTICULOSC2_A2proveedoresid[0];
            n2proveedoresid = ARTICULOSC2_n2proveedoresid[0];
            A156articulosdsc = ARTICULOSC2_A156articulosdsc[0];
            n156articulosdsc = ARTICULOSC2_n156articulosdsc[0];
            A10origenid = ARTICULOSC2_A10origenid[0];
            n10origenid = ARTICULOSC2_n10origenid[0];
            A7entidafederativaid = ARTICULOSC2_A7entidafederativaid[0];
            n7entidafederativaid = ARTICULOSC2_n7entidafederativaid[0];
            A23tipobienid = ARTICULOSC2_A23tipobienid[0];
            n23tipobienid = ARTICULOSC2_n23tipobienid[0];
            A155articulosnoetiqueta = ARTICULOSC2_A155articulosnoetiqueta[0];
            n155articulosnoetiqueta = ARTICULOSC2_n155articulosnoetiqueta[0];
            A154alamcenid = ARTICULOSC2_A154alamcenid[0];
            n154alamcenid = ARTICULOSC2_n154alamcenid[0];
            A21articuloscambsid = ARTICULOSC2_A21articuloscambsid[0];
            A20articulosproductoid = ARTICULOSC2_A20articulosproductoid[0];
            A19almacenid = ARTICULOSC2_A19almacenid[0];
            /*
               INSERT RECORD ON TABLE GXA0011

            */
            AV2almacenid = (int)(A19almacenid);
            AV3articulosproductoid = A20articulosproductoid;
            AV4articuloscambsid = A21articuloscambsid;
            if ( ARTICULOSC2_n154alamcenid[0] )
            {
               AV5alamcenid = 0;
               nV5alamcenid = false;
               nV5alamcenid = true;
            }
            else
            {
               AV5alamcenid = A154alamcenid;
               nV5alamcenid = false;
            }
            if ( ARTICULOSC2_n155articulosnoetiqueta[0] )
            {
               AV6articulosnoetiqueta = 0;
               nV6articulosnoetiqueta = false;
               nV6articulosnoetiqueta = true;
            }
            else
            {
               AV6articulosnoetiqueta = A155articulosnoetiqueta;
               nV6articulosnoetiqueta = false;
            }
            if ( ARTICULOSC2_n23tipobienid[0] )
            {
               AV7tipobienid = 0;
               nV7tipobienid = false;
               nV7tipobienid = true;
            }
            else
            {
               AV7tipobienid = A23tipobienid;
               nV7tipobienid = false;
            }
            if ( ARTICULOSC2_n7entidafederativaid[0] )
            {
               AV8entidafederativaid = 0;
               nV8entidafederativaid = false;
               nV8entidafederativaid = true;
            }
            else
            {
               AV8entidafederativaid = A7entidafederativaid;
               nV8entidafederativaid = false;
            }
            if ( ARTICULOSC2_n10origenid[0] )
            {
               AV9origenid = 0;
               nV9origenid = false;
               nV9origenid = true;
            }
            else
            {
               AV9origenid = A10origenid;
               nV9origenid = false;
            }
            if ( ARTICULOSC2_n156articulosdsc[0] )
            {
               AV10articulosdsc = "";
               nV10articulosdsc = false;
               nV10articulosdsc = true;
            }
            else
            {
               AV10articulosdsc = A156articulosdsc;
               nV10articulosdsc = false;
            }
            if ( ARTICULOSC2_n2proveedoresid[0] )
            {
               AV11proveedoresid = 0;
               nV11proveedoresid = false;
               nV11proveedoresid = true;
            }
            else
            {
               AV11proveedoresid = A2proveedoresid;
               nV11proveedoresid = false;
            }
            if ( ARTICULOSC2_n157articulospreciocompra[0] )
            {
               AV12articulospreciocompra = 0;
               nV12articulospreciocompra = false;
               nV12articulospreciocompra = true;
            }
            else
            {
               AV12articulospreciocompra = A157articulospreciocompra;
               nV12articulospreciocompra = false;
            }
            if ( ARTICULOSC2_n158articulospreccomprareexp[0] )
            {
               AV13articulospreccomprareexp = 0;
               nV13articulospreccomprareexp = false;
               nV13articulospreccomprareexp = true;
            }
            else
            {
               AV13articulospreccomprareexp = A158articulospreccomprareexp;
               nV13articulospreccomprareexp = false;
            }
            if ( ARTICULOSC2_n159articuloscantdepreacum[0] )
            {
               AV14articuloscantdepreacum = 0;
               nV14articuloscantdepreacum = false;
               nV14articuloscantdepreacum = true;
            }
            else
            {
               AV14articuloscantdepreacum = A159articuloscantdepreacum;
               nV14articuloscantdepreacum = false;
            }
            if ( ARTICULOSC2_n160articulosnumserie[0] )
            {
               AV15articulosnumserie = "";
               nV15articulosnumserie = false;
               nV15articulosnumserie = true;
            }
            else
            {
               AV15articulosnumserie = A160articulosnumserie;
               nV15articulosnumserie = false;
            }
            if ( ARTICULOSC2_n161articulosrefdocumento[0] )
            {
               AV16articulosrefdocumento = "";
               nV16articulosrefdocumento = false;
               nV16articulosrefdocumento = true;
            }
            else
            {
               AV16articulosrefdocumento = A161articulosrefdocumento;
               nV16articulosrefdocumento = false;
            }
            if ( ARTICULOSC2_n162articulosfechacoteja[0] )
            {
               AV17articulosfechacoteja = (DateTime)(DateTime.MinValue);
               nV17articulosfechacoteja = false;
               nV17articulosfechacoteja = true;
            }
            else
            {
               AV17articulosfechacoteja = A162articulosfechacoteja;
               nV17articulosfechacoteja = false;
            }
            if ( ARTICULOSC2_n163articulosfechaentraalmacen[0] )
            {
               AV18articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
               nV18articulosfechaentraalmacen = false;
               nV18articulosfechaentraalmacen = true;
            }
            else
            {
               AV18articulosfechaentraalmacen = A163articulosfechaentraalmacen;
               nV18articulosfechaentraalmacen = false;
            }
            if ( ARTICULOSC2_n164articulosfechabajaalma[0] )
            {
               AV19articulosfechabajaalma = (DateTime)(DateTime.MinValue);
               nV19articulosfechabajaalma = false;
               nV19articulosfechabajaalma = true;
            }
            else
            {
               AV19articulosfechabajaalma = A164articulosfechabajaalma;
               nV19articulosfechabajaalma = false;
            }
            if ( ARTICULOSC2_n165articulosstatus[0] )
            {
               AV20articulosstatus = 0;
               nV20articulosstatus = false;
               nV20articulosstatus = true;
            }
            else
            {
               AV20articulosstatus = A165articulosstatus;
               nV20articulosstatus = false;
            }
            if ( ARTICULOSC2_n166articuloscontejado[0] )
            {
               AV21articuloscontejado = 0;
               nV21articuloscontejado = false;
               nV21articuloscontejado = true;
            }
            else
            {
               AV21articuloscontejado = A166articuloscontejado;
               nV21articuloscontejado = false;
            }
            if ( ARTICULOSC2_n167articulosusuario[0] )
            {
               AV22articulosusuario = "";
               nV22articulosusuario = false;
               nV22articulosusuario = true;
            }
            else
            {
               AV22articulosusuario = A167articulosusuario;
               nV22articulosusuario = false;
            }
            if ( ARTICULOSC2_n168articulosidtrasfer[0] )
            {
               AV23articulosidtrasfer = 0;
               nV23articulosidtrasfer = false;
               nV23articulosidtrasfer = true;
            }
            else
            {
               AV23articulosidtrasfer = A168articulosidtrasfer;
               nV23articulosidtrasfer = false;
            }
            if ( ARTICULOSC2_n169articulosestatusariticulo[0] )
            {
               AV24articulosestatusariticulo = 0;
               nV24articulosestatusariticulo = false;
               nV24articulosestatusariticulo = true;
            }
            else
            {
               AV24articulosestatusariticulo = A169articulosestatusariticulo;
               nV24articulosestatusariticulo = false;
            }
            if ( ARTICULOSC2_n170articulostipobien[0] )
            {
               AV25articulostipobien = 0;
               nV25articulostipobien = false;
               nV25articulostipobien = true;
            }
            else
            {
               AV25articulostipobien = A170articulostipobien;
               nV25articulostipobien = false;
            }
            if ( ARTICULOSC2_n171articulosfecreg[0] )
            {
               AV26articulosfecreg = (DateTime)(DateTime.MinValue);
               nV26articulosfecreg = false;
               nV26articulosfecreg = true;
            }
            else
            {
               AV26articulosfecreg = A171articulosfecreg;
               nV26articulosfecreg = false;
            }
            if ( ARTICULOSC2_n172articulosfecultact[0] )
            {
               AV27articulosfecultact = (DateTime)(DateTime.MinValue);
               nV27articulosfecultact = false;
               nV27articulosfecultact = true;
            }
            else
            {
               AV27articulosfecultact = A172articulosfecultact;
               nV27articulosfecultact = false;
            }
            /* Using cursor ARTICULOSC3 */
            pr_default.execute(1, new Object[] {AV2almacenid, AV3articulosproductoid, AV4articuloscambsid, nV5alamcenid, AV5alamcenid, nV6articulosnoetiqueta, AV6articulosnoetiqueta, nV7tipobienid, AV7tipobienid, nV8entidafederativaid, AV8entidafederativaid, nV9origenid, AV9origenid, nV10articulosdsc, AV10articulosdsc, nV11proveedoresid, AV11proveedoresid, nV12articulospreciocompra, AV12articulospreciocompra, nV13articulospreccomprareexp, AV13articulospreccomprareexp, nV14articuloscantdepreacum, AV14articuloscantdepreacum, nV15articulosnumserie, AV15articulosnumserie, nV16articulosrefdocumento, AV16articulosrefdocumento, nV17articulosfechacoteja, AV17articulosfechacoteja, nV18articulosfechaentraalmacen, AV18articulosfechaentraalmacen, nV19articulosfechabajaalma, AV19articulosfechabajaalma, nV20articulosstatus, AV20articulosstatus, nV21articuloscontejado, AV21articuloscontejado, nV22articulosusuario, AV22articulosusuario, nV23articulosidtrasfer, AV23articulosidtrasfer, nV24articulosestatusariticulo, AV24articulosestatusariticulo, nV25articulostipobien, AV25articulostipobien, nV26articulosfecreg, AV26articulosfecreg, nV27articulosfecultact, AV27articulosfecultact});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0011") ;
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
         ARTICULOSC2_A172articulosfecultact = new DateTime[] {DateTime.MinValue} ;
         ARTICULOSC2_n172articulosfecultact = new bool[] {false} ;
         ARTICULOSC2_A171articulosfecreg = new DateTime[] {DateTime.MinValue} ;
         ARTICULOSC2_n171articulosfecreg = new bool[] {false} ;
         ARTICULOSC2_A170articulostipobien = new long[1] ;
         ARTICULOSC2_n170articulostipobien = new bool[] {false} ;
         ARTICULOSC2_A169articulosestatusariticulo = new long[1] ;
         ARTICULOSC2_n169articulosestatusariticulo = new bool[] {false} ;
         ARTICULOSC2_A168articulosidtrasfer = new int[1] ;
         ARTICULOSC2_n168articulosidtrasfer = new bool[] {false} ;
         ARTICULOSC2_A167articulosusuario = new String[] {""} ;
         ARTICULOSC2_n167articulosusuario = new bool[] {false} ;
         ARTICULOSC2_A166articuloscontejado = new long[1] ;
         ARTICULOSC2_n166articuloscontejado = new bool[] {false} ;
         ARTICULOSC2_A165articulosstatus = new long[1] ;
         ARTICULOSC2_n165articulosstatus = new bool[] {false} ;
         ARTICULOSC2_A164articulosfechabajaalma = new DateTime[] {DateTime.MinValue} ;
         ARTICULOSC2_n164articulosfechabajaalma = new bool[] {false} ;
         ARTICULOSC2_A163articulosfechaentraalmacen = new DateTime[] {DateTime.MinValue} ;
         ARTICULOSC2_n163articulosfechaentraalmacen = new bool[] {false} ;
         ARTICULOSC2_A162articulosfechacoteja = new DateTime[] {DateTime.MinValue} ;
         ARTICULOSC2_n162articulosfechacoteja = new bool[] {false} ;
         ARTICULOSC2_A161articulosrefdocumento = new String[] {""} ;
         ARTICULOSC2_n161articulosrefdocumento = new bool[] {false} ;
         ARTICULOSC2_A160articulosnumserie = new String[] {""} ;
         ARTICULOSC2_n160articulosnumserie = new bool[] {false} ;
         ARTICULOSC2_A159articuloscantdepreacum = new decimal[1] ;
         ARTICULOSC2_n159articuloscantdepreacum = new bool[] {false} ;
         ARTICULOSC2_A158articulospreccomprareexp = new decimal[1] ;
         ARTICULOSC2_n158articulospreccomprareexp = new bool[] {false} ;
         ARTICULOSC2_A157articulospreciocompra = new decimal[1] ;
         ARTICULOSC2_n157articulospreciocompra = new bool[] {false} ;
         ARTICULOSC2_A2proveedoresid = new int[1] ;
         ARTICULOSC2_n2proveedoresid = new bool[] {false} ;
         ARTICULOSC2_A156articulosdsc = new String[] {""} ;
         ARTICULOSC2_n156articulosdsc = new bool[] {false} ;
         ARTICULOSC2_A10origenid = new long[1] ;
         ARTICULOSC2_n10origenid = new bool[] {false} ;
         ARTICULOSC2_A7entidafederativaid = new int[1] ;
         ARTICULOSC2_n7entidafederativaid = new bool[] {false} ;
         ARTICULOSC2_A23tipobienid = new int[1] ;
         ARTICULOSC2_n23tipobienid = new bool[] {false} ;
         ARTICULOSC2_A155articulosnoetiqueta = new long[1] ;
         ARTICULOSC2_n155articulosnoetiqueta = new bool[] {false} ;
         ARTICULOSC2_A154alamcenid = new long[1] ;
         ARTICULOSC2_n154alamcenid = new bool[] {false} ;
         ARTICULOSC2_A21articuloscambsid = new int[1] ;
         ARTICULOSC2_A20articulosproductoid = new int[1] ;
         ARTICULOSC2_A19almacenid = new long[1] ;
         A172articulosfecultact = (DateTime)(DateTime.MinValue);
         A171articulosfecreg = (DateTime)(DateTime.MinValue);
         A167articulosusuario = "";
         A164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         A163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         A162articulosfechacoteja = (DateTime)(DateTime.MinValue);
         A161articulosrefdocumento = "";
         A160articulosnumserie = "";
         A156articulosdsc = "";
         AV10articulosdsc = "";
         AV15articulosnumserie = "";
         AV16articulosrefdocumento = "";
         AV17articulosfechacoteja = (DateTime)(DateTime.MinValue);
         AV18articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         AV19articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         AV22articulosusuario = "";
         AV26articulosfecreg = (DateTime)(DateTime.MinValue);
         AV27articulosfecultact = (DateTime)(DateTime.MinValue);
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.articulosconversion__default(),
            new Object[][] {
                new Object[] {
               ARTICULOSC2_A172articulosfecultact, ARTICULOSC2_n172articulosfecultact, ARTICULOSC2_A171articulosfecreg, ARTICULOSC2_n171articulosfecreg, ARTICULOSC2_A170articulostipobien, ARTICULOSC2_n170articulostipobien, ARTICULOSC2_A169articulosestatusariticulo, ARTICULOSC2_n169articulosestatusariticulo, ARTICULOSC2_A168articulosidtrasfer, ARTICULOSC2_n168articulosidtrasfer,
               ARTICULOSC2_A167articulosusuario, ARTICULOSC2_n167articulosusuario, ARTICULOSC2_A166articuloscontejado, ARTICULOSC2_n166articuloscontejado, ARTICULOSC2_A165articulosstatus, ARTICULOSC2_n165articulosstatus, ARTICULOSC2_A164articulosfechabajaalma, ARTICULOSC2_n164articulosfechabajaalma, ARTICULOSC2_A163articulosfechaentraalmacen, ARTICULOSC2_n163articulosfechaentraalmacen,
               ARTICULOSC2_A162articulosfechacoteja, ARTICULOSC2_n162articulosfechacoteja, ARTICULOSC2_A161articulosrefdocumento, ARTICULOSC2_n161articulosrefdocumento, ARTICULOSC2_A160articulosnumserie, ARTICULOSC2_n160articulosnumserie, ARTICULOSC2_A159articuloscantdepreacum, ARTICULOSC2_n159articuloscantdepreacum, ARTICULOSC2_A158articulospreccomprareexp, ARTICULOSC2_n158articulospreccomprareexp,
               ARTICULOSC2_A157articulospreciocompra, ARTICULOSC2_n157articulospreciocompra, ARTICULOSC2_A2proveedoresid, ARTICULOSC2_n2proveedoresid, ARTICULOSC2_A156articulosdsc, ARTICULOSC2_n156articulosdsc, ARTICULOSC2_A10origenid, ARTICULOSC2_n10origenid, ARTICULOSC2_A7entidafederativaid, ARTICULOSC2_n7entidafederativaid,
               ARTICULOSC2_A23tipobienid, ARTICULOSC2_n23tipobienid, ARTICULOSC2_A155articulosnoetiqueta, ARTICULOSC2_n155articulosnoetiqueta, ARTICULOSC2_A154alamcenid, ARTICULOSC2_n154alamcenid, ARTICULOSC2_A21articuloscambsid, ARTICULOSC2_A20articulosproductoid, ARTICULOSC2_A19almacenid
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int A168articulosidtrasfer ;
      private int A2proveedoresid ;
      private int A7entidafederativaid ;
      private int A23tipobienid ;
      private int A21articuloscambsid ;
      private int A20articulosproductoid ;
      private int GIGXA0011 ;
      private int AV2almacenid ;
      private int AV3articulosproductoid ;
      private int AV4articuloscambsid ;
      private int AV7tipobienid ;
      private int AV8entidafederativaid ;
      private int AV11proveedoresid ;
      private int AV23articulosidtrasfer ;
      private long A170articulostipobien ;
      private long A169articulosestatusariticulo ;
      private long A166articuloscontejado ;
      private long A165articulosstatus ;
      private long A10origenid ;
      private long A155articulosnoetiqueta ;
      private long A154alamcenid ;
      private long A19almacenid ;
      private long AV5alamcenid ;
      private long AV6articulosnoetiqueta ;
      private long AV9origenid ;
      private long AV20articulosstatus ;
      private long AV21articuloscontejado ;
      private long AV24articulosestatusariticulo ;
      private long AV25articulostipobien ;
      private decimal A159articuloscantdepreacum ;
      private decimal A158articulospreccomprareexp ;
      private decimal A157articulospreciocompra ;
      private decimal AV12articulospreciocompra ;
      private decimal AV13articulospreccomprareexp ;
      private decimal AV14articuloscantdepreacum ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A172articulosfecultact ;
      private DateTime A171articulosfecreg ;
      private DateTime A164articulosfechabajaalma ;
      private DateTime A163articulosfechaentraalmacen ;
      private DateTime A162articulosfechacoteja ;
      private DateTime AV17articulosfechacoteja ;
      private DateTime AV18articulosfechaentraalmacen ;
      private DateTime AV19articulosfechabajaalma ;
      private DateTime AV26articulosfecreg ;
      private DateTime AV27articulosfecultact ;
      private bool n172articulosfecultact ;
      private bool n171articulosfecreg ;
      private bool n170articulostipobien ;
      private bool n169articulosestatusariticulo ;
      private bool n168articulosidtrasfer ;
      private bool n167articulosusuario ;
      private bool n166articuloscontejado ;
      private bool n165articulosstatus ;
      private bool n164articulosfechabajaalma ;
      private bool n163articulosfechaentraalmacen ;
      private bool n162articulosfechacoteja ;
      private bool n161articulosrefdocumento ;
      private bool n160articulosnumserie ;
      private bool n159articuloscantdepreacum ;
      private bool n158articulospreccomprareexp ;
      private bool n157articulospreciocompra ;
      private bool n2proveedoresid ;
      private bool n156articulosdsc ;
      private bool n10origenid ;
      private bool n7entidafederativaid ;
      private bool n23tipobienid ;
      private bool n155articulosnoetiqueta ;
      private bool n154alamcenid ;
      private bool nV5alamcenid ;
      private bool nV6articulosnoetiqueta ;
      private bool nV7tipobienid ;
      private bool nV8entidafederativaid ;
      private bool nV9origenid ;
      private bool nV10articulosdsc ;
      private bool nV11proveedoresid ;
      private bool nV12articulospreciocompra ;
      private bool nV13articulospreccomprareexp ;
      private bool nV14articuloscantdepreacum ;
      private bool nV15articulosnumserie ;
      private bool nV16articulosrefdocumento ;
      private bool nV17articulosfechacoteja ;
      private bool nV18articulosfechaentraalmacen ;
      private bool nV19articulosfechabajaalma ;
      private bool nV20articulosstatus ;
      private bool nV21articuloscontejado ;
      private bool nV22articulosusuario ;
      private bool nV23articulosidtrasfer ;
      private bool nV24articulosestatusariticulo ;
      private bool nV25articulostipobien ;
      private bool nV26articulosfecreg ;
      private bool nV27articulosfecultact ;
      private String A167articulosusuario ;
      private String A161articulosrefdocumento ;
      private String A160articulosnumserie ;
      private String A156articulosdsc ;
      private String AV10articulosdsc ;
      private String AV15articulosnumserie ;
      private String AV16articulosrefdocumento ;
      private String AV22articulosusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] ARTICULOSC2_A172articulosfecultact ;
      private bool[] ARTICULOSC2_n172articulosfecultact ;
      private DateTime[] ARTICULOSC2_A171articulosfecreg ;
      private bool[] ARTICULOSC2_n171articulosfecreg ;
      private long[] ARTICULOSC2_A170articulostipobien ;
      private bool[] ARTICULOSC2_n170articulostipobien ;
      private long[] ARTICULOSC2_A169articulosestatusariticulo ;
      private bool[] ARTICULOSC2_n169articulosestatusariticulo ;
      private int[] ARTICULOSC2_A168articulosidtrasfer ;
      private bool[] ARTICULOSC2_n168articulosidtrasfer ;
      private String[] ARTICULOSC2_A167articulosusuario ;
      private bool[] ARTICULOSC2_n167articulosusuario ;
      private long[] ARTICULOSC2_A166articuloscontejado ;
      private bool[] ARTICULOSC2_n166articuloscontejado ;
      private long[] ARTICULOSC2_A165articulosstatus ;
      private bool[] ARTICULOSC2_n165articulosstatus ;
      private DateTime[] ARTICULOSC2_A164articulosfechabajaalma ;
      private bool[] ARTICULOSC2_n164articulosfechabajaalma ;
      private DateTime[] ARTICULOSC2_A163articulosfechaentraalmacen ;
      private bool[] ARTICULOSC2_n163articulosfechaentraalmacen ;
      private DateTime[] ARTICULOSC2_A162articulosfechacoteja ;
      private bool[] ARTICULOSC2_n162articulosfechacoteja ;
      private String[] ARTICULOSC2_A161articulosrefdocumento ;
      private bool[] ARTICULOSC2_n161articulosrefdocumento ;
      private String[] ARTICULOSC2_A160articulosnumserie ;
      private bool[] ARTICULOSC2_n160articulosnumserie ;
      private decimal[] ARTICULOSC2_A159articuloscantdepreacum ;
      private bool[] ARTICULOSC2_n159articuloscantdepreacum ;
      private decimal[] ARTICULOSC2_A158articulospreccomprareexp ;
      private bool[] ARTICULOSC2_n158articulospreccomprareexp ;
      private decimal[] ARTICULOSC2_A157articulospreciocompra ;
      private bool[] ARTICULOSC2_n157articulospreciocompra ;
      private int[] ARTICULOSC2_A2proveedoresid ;
      private bool[] ARTICULOSC2_n2proveedoresid ;
      private String[] ARTICULOSC2_A156articulosdsc ;
      private bool[] ARTICULOSC2_n156articulosdsc ;
      private long[] ARTICULOSC2_A10origenid ;
      private bool[] ARTICULOSC2_n10origenid ;
      private int[] ARTICULOSC2_A7entidafederativaid ;
      private bool[] ARTICULOSC2_n7entidafederativaid ;
      private int[] ARTICULOSC2_A23tipobienid ;
      private bool[] ARTICULOSC2_n23tipobienid ;
      private long[] ARTICULOSC2_A155articulosnoetiqueta ;
      private bool[] ARTICULOSC2_n155articulosnoetiqueta ;
      private long[] ARTICULOSC2_A154alamcenid ;
      private bool[] ARTICULOSC2_n154alamcenid ;
      private int[] ARTICULOSC2_A21articuloscambsid ;
      private int[] ARTICULOSC2_A20articulosproductoid ;
      private long[] ARTICULOSC2_A19almacenid ;
   }

   public class articulosconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmARTICULOSC2 ;
          prmARTICULOSC2 = new Object[] {
          } ;
          Object[] prmARTICULOSC3 ;
          prmARTICULOSC3 = new Object[] {
          new Object[] {"AV2almacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV3articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV4articuloscambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV5alamcenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV6articulosnoetiqueta",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV7tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8entidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV9origenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10articulosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV11proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV12articulospreciocompra",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"AV13articulospreccomprareexp",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"AV14articuloscantdepreacum",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"AV15articulosnumserie",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"AV16articulosrefdocumento",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"AV17articulosfechacoteja",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV18articulosfechaentraalmacen",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV19articulosfechabajaalma",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV20articulosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV21articuloscontejado",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV22articulosusuario",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"AV23articulosidtrasfer",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV24articulosestatusariticulo",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV25articulostipobien",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV26articulosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV27articulosfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("ARTICULOSC2", "SELECT articulosfecultact, articulosfecreg, articulostipobien, articulosestatusariticulo, articulosidtrasfer, articulosusuario, articuloscontejado, articulosstatus, articulosfechabajaalma, articulosfechaentraalmacen, articulosfechacoteja, articulosrefdocumento, articulosnumserie, articuloscantdepreacum, articulospreccomprareexp, articulospreciocompra, proveedorid, articulosdsc, origenid, entidadid, tipodocid, articulosnoetiqueta, alamcenid, cambsid, productoid, articulosid FROM public.articulos ORDER BY articulosid, productoid, cambsid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmARTICULOSC2,100,0,true,false )
             ,new CursorDef("ARTICULOSC3", "INSERT INTO GXA0011(almacenid, articulosproductoid, articuloscambsid, alamcenid, articulosnoetiqueta, tipobienid, entidafederativaid, origenid, articulosdsc, proveedoresid, articulospreciocompra, articulospreccomprareexp, articuloscantdepreacum, articulosnumserie, articulosrefdocumento, articulosfechacoteja, articulosfechaentraalmacen, articulosfechabajaalma, articulosstatus, articuloscontejado, articulosusuario, articulosidtrasfer, articulosestatusariticulo, articulostipobien, articulosfecreg, articulosfecultact) VALUES(:AV2almacenid, :AV3articulosproductoid, :AV4articuloscambsid, :AV5alamcenid, :AV6articulosnoetiqueta, :AV7tipobienid, :AV8entidafederativaid, :AV9origenid, :AV10articulosdsc, :AV11proveedoresid, :AV12articulospreciocompra, :AV13articulospreccomprareexp, :AV14articuloscantdepreacum, :AV15articulosnumserie, :AV16articulosrefdocumento, :AV17articulosfechacoteja, :AV18articulosfechaentraalmacen, :AV19articulosfechabajaalma, :AV20articulosstatus, :AV21articuloscontejado, :AV22articulosusuario, :AV23articulosidtrasfer, :AV24articulosestatusariticulo, :AV25articulostipobien, :AV26articulosfecreg, :AV27articulosfecultact)", GxErrorMask.GX_NOMASK,prmARTICULOSC3)
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
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[20])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((decimal[]) buf[26])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((decimal[]) buf[28])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((decimal[]) buf[30])[0] = rslt.getDecimal(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((int[]) buf[32])[0] = rslt.getInt(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((String[]) buf[34])[0] = rslt.getVarchar(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((long[]) buf[36])[0] = rslt.getLong(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((int[]) buf[38])[0] = rslt.getInt(20) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(20);
                ((int[]) buf[40])[0] = rslt.getInt(21) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(21);
                ((long[]) buf[42])[0] = rslt.getLong(22) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(22);
                ((long[]) buf[44])[0] = rslt.getLong(23) ;
                ((bool[]) buf[45])[0] = rslt.wasNull(23);
                ((int[]) buf[46])[0] = rslt.getInt(24) ;
                ((int[]) buf[47])[0] = rslt.getInt(25) ;
                ((long[]) buf[48])[0] = rslt.getLong(26) ;
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
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (long)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 12 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(12, (decimal)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 13 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(13, (decimal)parms[22]);
                }
                if ( (bool)parms[23] )
                {
                   stmt.setNull( 14 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[24]);
                }
                if ( (bool)parms[25] )
                {
                   stmt.setNull( 15 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[26]);
                }
                if ( (bool)parms[27] )
                {
                   stmt.setNull( 16 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(16, (DateTime)parms[28]);
                }
                if ( (bool)parms[29] )
                {
                   stmt.setNull( 17 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(17, (DateTime)parms[30]);
                }
                if ( (bool)parms[31] )
                {
                   stmt.setNull( 18 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(18, (DateTime)parms[32]);
                }
                if ( (bool)parms[33] )
                {
                   stmt.setNull( 19 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(19, (long)parms[34]);
                }
                if ( (bool)parms[35] )
                {
                   stmt.setNull( 20 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(20, (long)parms[36]);
                }
                if ( (bool)parms[37] )
                {
                   stmt.setNull( 21 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(21, (String)parms[38]);
                }
                if ( (bool)parms[39] )
                {
                   stmt.setNull( 22 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(22, (int)parms[40]);
                }
                if ( (bool)parms[41] )
                {
                   stmt.setNull( 23 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(23, (long)parms[42]);
                }
                if ( (bool)parms[43] )
                {
                   stmt.setNull( 24 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(24, (long)parms[44]);
                }
                if ( (bool)parms[45] )
                {
                   stmt.setNull( 25 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(25, (DateTime)parms[46]);
                }
                if ( (bool)parms[47] )
                {
                   stmt.setNull( 26 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(26, (DateTime)parms[48]);
                }
                return;
       }
    }

 }

}
