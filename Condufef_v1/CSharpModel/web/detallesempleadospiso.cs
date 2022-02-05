/*
               File: DetallesEmpleadosPiso
        Description: Detalles Empleados Piso
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/4/2022 19:59:33.86
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class detallesempleadospiso : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallesempleadospiso( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallesempleadospiso( IGxContext context )
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
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         context.SetDefaultTheme("Flat");
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Empeladospisogrid") == 0 )
            {
               nRC_GXsfl_11 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_11_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_11_idx = GetNextPar( );
               AV7updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
               AV6deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrEmpeladospisogrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Empeladospisogrid") == 0 )
            {
               AV5buscar = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
               AV7updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
               AV6deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrEmpeladospisogrid_refresh( AV5buscar, AV7updateImage, AV6deleteImage) ;
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA362( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START362( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxcfg.js", "?20222419593388");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 115824));
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallesempleadospiso.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vBUSCAR", StringUtil.RTrim( AV5buscar));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_11", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_11), 4, 0, ",", "")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE362( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT362( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("detallesempleadospiso.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesEmpleadosPiso" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Empleados Piso" ;
      }

      protected void WB360( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            wb_table1_2_362( true) ;
         }
         else
         {
            wb_table1_2_362( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_362e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            EmpeladospisogridContainer.SetWrapped(nGXWrapped);
            if ( EmpeladospisogridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"EmpeladospisogridContainer"+"DivS\" data-gxgridid=\"11\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subEmpeladospisogrid_Internalname, subEmpeladospisogrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subEmpeladospisogrid_Backcolorstyle == 0 )
               {
                  subEmpeladospisogrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subEmpeladospisogrid_Class) > 0 )
                  {
                     subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Title";
                  }
               }
               else
               {
                  subEmpeladospisogrid_Titlebackstyle = 1;
                  if ( subEmpeladospisogrid_Backcolorstyle == 1 )
                  {
                     subEmpeladospisogrid_Titlebackcolor = subEmpeladospisogrid_Allbackcolor;
                     if ( StringUtil.Len( subEmpeladospisogrid_Class) > 0 )
                     {
                        subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subEmpeladospisogrid_Class) > 0 )
                     {
                        subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ext Piso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Correo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ext") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fec gre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpeladospisogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               EmpeladospisogridContainer.AddObjectProperty("GridName", "Empeladospisogrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  EmpeladospisogridContainer = new GXWebGrid( context);
               }
               else
               {
                  EmpeladospisogridContainer.Clear();
               }
               EmpeladospisogridContainer.SetWrapped(nGXWrapped);
               EmpeladospisogridContainer.AddObjectProperty("GridName", "Empeladospisogrid");
               EmpeladospisogridContainer.AddObjectProperty("Class", "Grid");
               EmpeladospisogridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Backcolorstyle), 1, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("CmpContext", "");
               EmpeladospisogridContainer.AddObjectProperty("InMasterPage", "false");
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ".", "")));
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", A47empleadospisoextpiso);
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", A49empleadospisoextcorreo);
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", A48empleadospisoextext);
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", A51empleadospisoextusuario);
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", context.convertURL( AV7updateImage));
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpeladospisogridColumn.AddObjectProperty("Value", context.convertURL( AV6deleteImage));
               EmpeladospisogridContainer.AddColumnProperties(EmpeladospisogridColumn);
               EmpeladospisogridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Allowselection), 1, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Selectioncolor), 9, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Allowhovering), 1, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Hoveringcolor), 9, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Allowcollapsing), 1, 0, ".", "")));
               EmpeladospisogridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 11 )
         {
            wbEnd = 0;
            nRC_GXsfl_11 = (short)(nGXsfl_11_idx-1);
            if ( EmpeladospisogridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"EmpeladospisogridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Empeladospisogrid", EmpeladospisogridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EmpeladospisogridContainerData", EmpeladospisogridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EmpeladospisogridContainerData"+"V", EmpeladospisogridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"EmpeladospisogridContainerData"+"V"+"\" value='"+EmpeladospisogridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true;
      }

      protected void START362( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Empleados Piso", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP360( ) ;
      }

      protected void WS362( )
      {
         START362( ) ;
         EVT362( ) ;
      }

      protected void EVT362( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 /* Set Refresh If Buscar Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vBUSCAR"), AV5buscar) != 0 )
                                 {
                                    Rfr0gs = true;
                                 }
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E11362 */
                                    E11362 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 22), "EMPELADOSPISOGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                              SubsflControlProps_112( ) ;
                              A46empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( edtempleadospisoextid_Internalname), ",", "."));
                              A47empleadospisoextpiso = cgiGet( edtempleadospisoextpiso_Internalname);
                              A49empleadospisoextcorreo = cgiGet( edtempleadospisoextcorreo_Internalname);
                              A48empleadospisoextext = cgiGet( edtempleadospisoextext_Internalname);
                              A51empleadospisoextusuario = cgiGet( edtempleadospisoextusuario_Internalname);
                              A52empleadospisoextfecgre = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtempleadospisoextfecgre_Internalname), 0));
                              AV7updateImage = cgiGet( edtavUpdateimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
                              AV6deleteImage = cgiGet( edtavDeleteimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12362 */
                                    E12362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13362 */
                                    E13362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14362 */
                                    E14362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "EMPELADOSPISOGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15362 */
                                    E15362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE362( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA362( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavBuscar_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrEmpeladospisogrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_112( ) ;
         while ( nGXsfl_11_idx <= nRC_GXsfl_11 )
         {
            sendrow_112( ) ;
            nGXsfl_11_idx = (short)(((subEmpeladospisogrid_Islastpage==1)&&(nGXsfl_11_idx+1>subEmpeladospisogrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
            sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
            SubsflControlProps_112( ) ;
         }
         context.GX_webresponse.AddString(EmpeladospisogridContainer.ToJavascriptSource());
         /* End function gxnrEmpeladospisogrid_newrow */
      }

      protected void gxgrEmpeladospisogrid_refresh( String AV5buscar ,
                                                    String AV7updateImage ,
                                                    String AV6deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         EMPELADOSPISOGRID_nCurrentRecord = 0;
         RF362( ) ;
         /* End function gxgrEmpeladospisogrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTPISO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A47empleadospisoextpiso, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTPISO", A47empleadospisoextpiso);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTCORREO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A49empleadospisoextcorreo, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTCORREO", A49empleadospisoextcorreo);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTEXT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A48empleadospisoextext, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTEXT", A48empleadospisoextext);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A51empleadospisoextusuario, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTUSUARIO", A51empleadospisoextusuario);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTFECGRE", GetSecureSignedToken( "", A52empleadospisoextfecgre));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTFECGRE", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF362( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF362( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            EmpeladospisogridContainer.ClearRows();
         }
         wbStart = 11;
         nGXsfl_11_idx = 1;
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         nGXsfl_11_Refreshing = 1;
         EmpeladospisogridContainer.AddObjectProperty("GridName", "Empeladospisogrid");
         EmpeladospisogridContainer.AddObjectProperty("CmpContext", "");
         EmpeladospisogridContainer.AddObjectProperty("InMasterPage", "false");
         EmpeladospisogridContainer.AddObjectProperty("Class", "Grid");
         EmpeladospisogridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         EmpeladospisogridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         EmpeladospisogridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpeladospisogrid_Backcolorstyle), 1, 0, ".", "")));
         EmpeladospisogridContainer.PageSize = subEmpeladospisogrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_112( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H00362 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A52empleadospisoextfecgre = H00362_A52empleadospisoextfecgre[0];
               A51empleadospisoextusuario = H00362_A51empleadospisoextusuario[0];
               A48empleadospisoextext = H00362_A48empleadospisoextext[0];
               A49empleadospisoextcorreo = H00362_A49empleadospisoextcorreo[0];
               A47empleadospisoextpiso = H00362_A47empleadospisoextpiso[0];
               A46empleadospisoextid = H00362_A46empleadospisoextid[0];
               /* Execute user event: E15362 */
               E15362 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 11;
            WB360( ) ;
         }
         nGXsfl_11_Refreshing = 0;
      }

      protected int subEmpeladospisogrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subEmpeladospisogrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subEmpeladospisogrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subEmpeladospisogrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP360( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E12362 */
         E12362 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5buscar = cgiGet( edtavBuscar_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Read saved values. */
            nRC_GXsfl_11 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_11"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E12362 */
         E12362 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12362( )
      {
         /* Start Routine */
         AV7updateImage = context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
         AV10Updateimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
         AV6deleteImage = context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
         AV11Deleteimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
      }

      protected void E13362( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("empleadospiso.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A46empleadospisoextid);
         context.wjLocDisableFrm = 1;
      }

      protected void E14362( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("empleadospiso.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A46empleadospisoextid);
         context.wjLocDisableFrm = 1;
      }

      public void GXEnter( )
      {
         /* Execute user event: E11362 */
         E11362 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11362( )
      {
         /* Enter Routine */
         context.wjLoc = formatLink("catalog_de_empleados_piso.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      private void E15362( )
      {
         /* Empeladospisogrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 11;
         }
         sendrow_112( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_11_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(11, EmpeladospisogridRow);
         }
      }

      protected void wb_table1_2_362( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(53), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(1002), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:183px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_11_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetallesEmpleadosPiso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:781px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalles Empleados Piso", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#646464; background-color:#FFFFFF;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetallesEmpleadosPiso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:790px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#00FF00;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(11), 2, 0)+","+"null"+");", "Agregar", bttButton1_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesEmpleadosPiso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_362e( true) ;
         }
         else
         {
            wb_table1_2_362e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("Flat");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA362( ) ;
         WS362( ) ;
         WE362( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?13551382");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?13551359");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222419593399");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallesempleadospiso.js", "?2022241959340");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_112( )
      {
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID_"+sGXsfl_11_idx;
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO_"+sGXsfl_11_idx;
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO_"+sGXsfl_11_idx;
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT_"+sGXsfl_11_idx;
         edtempleadospisoextusuario_Internalname = "EMPLEADOSPISOEXTUSUARIO_"+sGXsfl_11_idx;
         edtempleadospisoextfecgre_Internalname = "EMPLEADOSPISOEXTFECGRE_"+sGXsfl_11_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_idx;
      }

      protected void SubsflControlProps_fel_112( )
      {
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID_"+sGXsfl_11_fel_idx;
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO_"+sGXsfl_11_fel_idx;
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO_"+sGXsfl_11_fel_idx;
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT_"+sGXsfl_11_fel_idx;
         edtempleadospisoextusuario_Internalname = "EMPLEADOSPISOEXTUSUARIO_"+sGXsfl_11_fel_idx;
         edtempleadospisoextfecgre_Internalname = "EMPLEADOSPISOEXTFECGRE_"+sGXsfl_11_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_fel_idx;
      }

      protected void sendrow_112( )
      {
         SubsflControlProps_112( ) ;
         WB360( ) ;
         EmpeladospisogridRow = GXWebRow.GetNew(context,EmpeladospisogridContainer);
         if ( subEmpeladospisogrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subEmpeladospisogrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subEmpeladospisogrid_Class, "") != 0 )
            {
               subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Odd";
            }
         }
         else if ( subEmpeladospisogrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subEmpeladospisogrid_Backstyle = 0;
            subEmpeladospisogrid_Backcolor = subEmpeladospisogrid_Allbackcolor;
            if ( StringUtil.StrCmp(subEmpeladospisogrid_Class, "") != 0 )
            {
               subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Uniform";
            }
         }
         else if ( subEmpeladospisogrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subEmpeladospisogrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subEmpeladospisogrid_Class, "") != 0 )
            {
               subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Odd";
            }
            subEmpeladospisogrid_Backcolor = (int)(0x0);
         }
         else if ( subEmpeladospisogrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subEmpeladospisogrid_Backstyle = 1;
            if ( ((int)((nGXsfl_11_idx) % (2))) == 0 )
            {
               subEmpeladospisogrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEmpeladospisogrid_Class, "") != 0 )
               {
                  subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Even";
               }
            }
            else
            {
               subEmpeladospisogrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEmpeladospisogrid_Class, "") != 0 )
               {
                  subEmpeladospisogrid_Linesclass = subEmpeladospisogrid_Class+"Odd";
               }
            }
         }
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subEmpeladospisogrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_11_idx+"\">") ;
         }
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextpiso_Internalname,(String)A47empleadospisoextpiso,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextpiso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextcorreo_Internalname,(String)A49empleadospisoextcorreo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextcorreo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextext_Internalname,(String)A48empleadospisoextext,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextext_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextusuario_Internalname,(String)A51empleadospisoextusuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextusuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpeladospisogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextfecgre_Internalname,context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"),context.localUtil.Format( A52empleadospisoextfecgre, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextfecgre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 18,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)));
         EmpeladospisogridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV7updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( EmpeladospisogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 19,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)));
         EmpeladospisogridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV6deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTPISO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A47empleadospisoextpiso, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTCORREO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A49empleadospisoextcorreo, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTEXT"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A48empleadospisoextext, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTUSUARIO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A51empleadospisoextusuario, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTFECGRE"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, A52empleadospisoextfecgre));
         EmpeladospisogridContainer.AddRow(EmpeladospisogridRow);
         nGXsfl_11_idx = (short)(((subEmpeladospisogrid_Islastpage==1)&&(nGXsfl_11_idx+1>subEmpeladospisogrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         /* End function sendrow_112 */
      }

      protected void init_default_properties( )
      {
         edtavBuscar_Internalname = "vBUSCAR";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         bttButton1_Internalname = "BUTTON1";
         tblTable1_Internalname = "TABLE1";
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID";
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO";
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO";
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT";
         edtempleadospisoextusuario_Internalname = "EMPLEADOSPISOEXTUSUARIO";
         edtempleadospisoextfecgre_Internalname = "EMPLEADOSPISOEXTFECGRE";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subEmpeladospisogrid_Internalname = "EMPELADOSPISOGRID";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavDeleteimage_Jsonclick = "";
         edtavDeleteimage_Visible = -1;
         edtavDeleteimage_Enabled = 1;
         edtavUpdateimage_Jsonclick = "";
         edtavUpdateimage_Visible = -1;
         edtavUpdateimage_Enabled = 1;
         edtempleadospisoextfecgre_Jsonclick = "";
         edtempleadospisoextusuario_Jsonclick = "";
         edtempleadospisoextext_Jsonclick = "";
         edtempleadospisoextcorreo_Jsonclick = "";
         edtempleadospisoextpiso_Jsonclick = "";
         edtempleadospisoextid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subEmpeladospisogrid_Allowcollapsing = 0;
         subEmpeladospisogrid_Allowselection = 0;
         subEmpeladospisogrid_Class = "Grid";
         subEmpeladospisogrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Empleados Piso";
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'EMPELADOSPISOGRID_nFirstRecordOnPage',nv:0},{av:'EMPELADOSPISOGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV7updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV6deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E13362',iparms:[{av:'A46empleadospisoextid',fld:'EMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E14362',iparms:[{av:'A46empleadospisoextid',fld:'EMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E11362',iparms:[],oparms:[]}");
         setEventMetadata("EMPELADOSPISOGRID.LOAD","{handler:'E15362',iparms:[],oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV7updateImage = "";
         AV10Updateimage_GXI = "";
         AV6deleteImage = "";
         AV11Deleteimage_GXI = "";
         AV5buscar = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         EmpeladospisogridContainer = new GXWebGrid( context);
         sStyleString = "";
         subEmpeladospisogrid_Linesclass = "";
         EmpeladospisogridColumn = new GXWebColumn();
         A47empleadospisoextpiso = "";
         A49empleadospisoextcorreo = "";
         A48empleadospisoextext = "";
         A51empleadospisoextusuario = "";
         A52empleadospisoextfecgre = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H00362_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         H00362_A51empleadospisoextusuario = new String[] {""} ;
         H00362_A48empleadospisoextext = new String[] {""} ;
         H00362_A49empleadospisoextcorreo = new String[] {""} ;
         H00362_A47empleadospisoextpiso = new String[] {""} ;
         H00362_A46empleadospisoextid = new int[1] ;
         EmpeladospisogridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallesempleadospiso__default(),
            new Object[][] {
                new Object[] {
               H00362_A52empleadospisoextfecgre, H00362_A51empleadospisoextusuario, H00362_A48empleadospisoextext, H00362_A49empleadospisoextcorreo, H00362_A47empleadospisoextpiso, H00362_A46empleadospisoextid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_11 ;
      private short nGXsfl_11_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subEmpeladospisogrid_Backcolorstyle ;
      private short subEmpeladospisogrid_Titlebackstyle ;
      private short subEmpeladospisogrid_Allowselection ;
      private short subEmpeladospisogrid_Allowhovering ;
      private short subEmpeladospisogrid_Allowcollapsing ;
      private short subEmpeladospisogrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_11_Refreshing=0 ;
      private short nGXWrapped ;
      private short subEmpeladospisogrid_Backstyle ;
      private short EMPELADOSPISOGRID_nEOF ;
      private int subEmpeladospisogrid_Titlebackcolor ;
      private int subEmpeladospisogrid_Allbackcolor ;
      private int A46empleadospisoextid ;
      private int subEmpeladospisogrid_Selectioncolor ;
      private int subEmpeladospisogrid_Hoveringcolor ;
      private int subEmpeladospisogrid_Islastpage ;
      private int idxLst ;
      private int subEmpeladospisogrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long EMPELADOSPISOGRID_nCurrentRecord ;
      private long EMPELADOSPISOGRID_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_11_idx="0001" ;
      private String edtavUpdateimage_Internalname ;
      private String edtavDeleteimage_Internalname ;
      private String AV5buscar ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sStyleString ;
      private String subEmpeladospisogrid_Internalname ;
      private String subEmpeladospisogrid_Class ;
      private String subEmpeladospisogrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtempleadospisoextid_Internalname ;
      private String edtempleadospisoextpiso_Internalname ;
      private String edtempleadospisoextcorreo_Internalname ;
      private String edtempleadospisoextext_Internalname ;
      private String edtempleadospisoextusuario_Internalname ;
      private String edtempleadospisoextfecgre_Internalname ;
      private String edtavBuscar_Internalname ;
      private String scmdbuf ;
      private String lV5buscar ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String edtavBuscar_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String sGXsfl_11_fel_idx="0001" ;
      private String ROClassString ;
      private String edtempleadospisoextid_Jsonclick ;
      private String edtempleadospisoextpiso_Jsonclick ;
      private String edtempleadospisoextcorreo_Jsonclick ;
      private String edtempleadospisoextext_Jsonclick ;
      private String edtempleadospisoextusuario_Jsonclick ;
      private String edtempleadospisoextfecgre_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private DateTime A52empleadospisoextfecgre ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV7updateImage_IsBlob ;
      private bool AV6deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A47empleadospisoextpiso ;
      private String A49empleadospisoextcorreo ;
      private String A48empleadospisoextext ;
      private String A51empleadospisoextusuario ;
      private String AV7updateImage ;
      private String AV6deleteImage ;
      private GXWebGrid EmpeladospisogridContainer ;
      private GXWebRow EmpeladospisogridRow ;
      private GXWebColumn EmpeladospisogridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H00362_A52empleadospisoextfecgre ;
      private String[] H00362_A51empleadospisoextusuario ;
      private String[] H00362_A48empleadospisoextext ;
      private String[] H00362_A49empleadospisoextcorreo ;
      private String[] H00362_A47empleadospisoextpiso ;
      private int[] H00362_A46empleadospisoextid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallesempleadospiso__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00362 ;
          prmH00362 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00362", "SELECT empleadospisoextfecgre, empleadospisoextusuario, empleadospisoextext, empleadospisoextcorreo, empleadospisoextpiso, empleadospisoextid FROM empleadospiso WHERE empleadospisoextpiso like :lV5buscar ORDER BY empleadospisoextid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00362,11,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                return;
       }
    }

 }

}
