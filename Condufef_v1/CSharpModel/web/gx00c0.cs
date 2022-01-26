/*
               File: Gx00C0
        Description: Selection List etiquetas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/25/2022 17:35:35.58
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
   public class gx00c0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00c0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00c0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_petiquetasproductoid ,
                           out int aP1_petiquetascambsid ,
                           out long aP2_palmacenid )
      {
         this.AV13petiquetasproductoid = 0 ;
         this.AV14petiquetascambsid = 0 ;
         this.AV15palmacenid = 0 ;
         executePrivate();
         aP0_petiquetasproductoid=this.AV13petiquetasproductoid;
         aP1_petiquetascambsid=this.AV14petiquetascambsid;
         aP2_palmacenid=this.AV15palmacenid;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_84 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cetiquetasproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cetiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cetiquetasproductoid), 9, 0)));
               AV7cetiquetascambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cetiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cetiquetascambsid), 9, 0)));
               AV8calmacenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8calmacenid), 18, 0)));
               AV9cetiquetasnumero = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cetiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cetiquetasnumero), 18, 0)));
               AV10cetiquetastatus = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cetiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cetiquetastatus), 18, 0)));
               AV11cetiquetafecharealizada = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cetiquetafecharealizada", context.localUtil.TToC( AV11cetiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
               AV12cetiquetasreimpresion = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cetiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cetiquetasreimpresion), 18, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV13petiquetasproductoid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13petiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13petiquetasproductoid), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14petiquetascambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14petiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14petiquetascambsid), 9, 0)));
                  AV15palmacenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15palmacenid), 18, 0)));
               }
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
            MasterPageObj.setDataArea(this,true);
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
         PA252( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START252( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202212517353565");
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
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00c0.aspx") + "?" + UrlEncode("" +AV13petiquetasproductoid) + "," + UrlEncode("" +AV14petiquetascambsid) + "," + UrlEncode("" +AV15palmacenid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETASPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cetiquetasproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETASCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cetiquetascambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8calmacenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETASNUMERO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cetiquetasnumero), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETASTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cetiquetastatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETAFECHAREALIZADA", context.localUtil.TToC( AV11cetiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCETIQUETASREIMPRESION", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cetiquetasreimpresion), 18, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPETIQUETASPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13petiquetasproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPETIQUETASCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14petiquetascambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15palmacenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETASPRODUCTOIDFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetasproductoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETASCAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetascambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENIDFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacenidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETASNUMEROFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetasnumerofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETASTATUSFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetastatusfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETAFECHAREALIZADAFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetafecharealizadafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ETIQUETASREIMPRESIONFILTERCONTAINER_Class", StringUtil.RTrim( divEtiquetasreimpresionfiltercontainer_Class));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
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
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE252( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT252( ) ;
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
         return formatLink("gx00c0.aspx") + "?" + UrlEncode("" +AV13petiquetasproductoid) + "," + UrlEncode("" +AV14petiquetascambsid) + "," + UrlEncode("" +AV15palmacenid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00C0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List etiquetas" ;
      }

      protected void WB250( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetasproductoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetasproductoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetasproductoidfilter_Internalname, "etiquetasproductoid", "", "", lblLbletiquetasproductoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetasproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCetiquetasproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cetiquetasproductoid), 9, 0, ",", "")), ((edtavCetiquetasproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cetiquetasproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cetiquetasproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetasproductoid_Jsonclick, 0, "Attribute", "", "", "", edtavCetiquetasproductoid_Visible, edtavCetiquetasproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetascambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetascambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetascambsidfilter_Internalname, "etiquetascambsid", "", "", lblLbletiquetascambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetascambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCetiquetascambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cetiquetascambsid), 9, 0, ",", "")), ((edtavCetiquetascambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cetiquetascambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cetiquetascambsid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetascambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCetiquetascambsid_Visible, edtavCetiquetascambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAlmacenidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacenidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacenidfilter_Internalname, "almacenid", "", "", lblLblalmacenidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacenid_Internalname, "articuloid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8calmacenid), 18, 0, ",", "")), ((edtavCalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8calmacenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8calmacenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacenid_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacenid_Visible, edtavCalmacenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetasnumerofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetasnumerofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetasnumerofilter_Internalname, "etiquetasnumero", "", "", lblLbletiquetasnumerofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetasnumero_Internalname, "etiquetasnumero", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCetiquetasnumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cetiquetasnumero), 18, 0, ",", "")), ((edtavCetiquetasnumero_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cetiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9cetiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetasnumero_Jsonclick, 0, "Attribute", "", "", "", edtavCetiquetasnumero_Visible, edtavCetiquetasnumero_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetastatusfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetastatusfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetastatusfilter_Internalname, "etiquetastatus", "", "", lblLbletiquetastatusfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetastatus_Internalname, "etiquetastatus", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCetiquetastatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cetiquetastatus), 18, 0, ",", "")), ((edtavCetiquetastatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cetiquetastatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cetiquetastatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetastatus_Jsonclick, 0, "Attribute", "", "", "", edtavCetiquetastatus_Visible, edtavCetiquetastatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetafecharealizadafiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetafecharealizadafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetafecharealizadafilter_Internalname, "etiquetafecharealizada", "", "", lblLbletiquetafecharealizadafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16251_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetafecharealizada_Internalname, "etiquetafecharealizada", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCetiquetafecharealizada_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCetiquetafecharealizada_Internalname, context.localUtil.TToC( AV11cetiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV11cetiquetafecharealizada, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetafecharealizada_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCetiquetafecharealizada_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEtiquetasreimpresionfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEtiquetasreimpresionfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbletiquetasreimpresionfilter_Internalname, "etiquetasreimpresion", "", "", lblLbletiquetasreimpresionfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17251_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCetiquetasreimpresion_Internalname, "etiquetasreimpresión", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCetiquetasreimpresion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cetiquetasreimpresion), 18, 0, ",", "")), ((edtavCetiquetasreimpresion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cetiquetasreimpresion), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12cetiquetasreimpresion), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCetiquetasreimpresion_Jsonclick, 0, "Attribute", "", "", "", edtavCetiquetasreimpresion_Visible, edtavCetiquetasreimpresion_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18251_client"+"'", TempTags, "", 2, "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"84\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productoid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "almacenid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "etiquetasnumero") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "etiquetastatus") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "etiquetafecharealizada") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32etiquetasnumero), 18, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtetiquetasnumero_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33etiquetastatus), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (short)(nGXsfl_84_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00C0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
         }
         wbLoad = true;
      }

      protected void START252( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List etiquetas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP250( ) ;
      }

      protected void WS252( )
      {
         START252( ) ;
         EVT252( ) ;
      }

      protected void EVT252( )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_84_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
                              SubsflControlProps_842( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV19Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A17etiquetasproductoid = (int)(context.localUtil.CToN( cgiGet( edtetiquetasproductoid_Internalname), ",", "."));
                              A18etiquetascambsid = (int)(context.localUtil.CToN( cgiGet( edtetiquetascambsid_Internalname), ",", "."));
                              A19almacenid = (long)(context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", "."));
                              A32etiquetasnumero = (long)(context.localUtil.CToN( cgiGet( edtetiquetasnumero_Internalname), ",", "."));
                              n32etiquetasnumero = false;
                              A33etiquetastatus = (long)(context.localUtil.CToN( cgiGet( edtetiquetastatus_Internalname), ",", "."));
                              n33etiquetastatus = false;
                              A34etiquetafecharealizada = context.localUtil.CToT( cgiGet( edtetiquetafecharealizada_Internalname), 0);
                              n34etiquetafecharealizada = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19252 */
                                    E19252 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20252 */
                                    E20252 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cetiquetasproductoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV6cetiquetasproductoid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cetiquetascambsid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASCAMBSID"), ",", ".") != Convert.ToDecimal( AV7cetiquetascambsid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calmacenid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALMACENID"), ",", ".") != Convert.ToDecimal( AV8calmacenid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cetiquetasnumero Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASNUMERO"), ",", ".") != Convert.ToDecimal( AV9cetiquetasnumero )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cetiquetastatus Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASTATUS"), ",", ".") != Convert.ToDecimal( AV10cetiquetastatus )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cetiquetafecharealizada Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCETIQUETAFECHAREALIZADA"), 0) != AV11cetiquetafecharealizada )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cetiquetasreimpresion Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASREIMPRESION"), ",", ".") != Convert.ToDecimal( AV12cetiquetasreimpresion )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21252 */
                                          E21252 ();
                                       }
                                       dynload_actions( ) ;
                                    }
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

      protected void WE252( )
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

      protected void PA252( )
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_842( ) ;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        int AV6cetiquetasproductoid ,
                                        int AV7cetiquetascambsid ,
                                        long AV8calmacenid ,
                                        long AV9cetiquetasnumero ,
                                        long AV10cetiquetastatus ,
                                        DateTime AV11cetiquetafecharealizada ,
                                        long AV12cetiquetasreimpresion )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF252( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASPRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A17etiquetasproductoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ETIQUETASPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASCAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A18etiquetascambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ETIQUETASCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASNUMERO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32etiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ETIQUETASNUMERO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32etiquetasnumero), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASTATUS", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A33etiquetastatus), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ETIQUETASTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33etiquetastatus), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETAFECHAREALIZADA", GetSecureSignedToken( "", context.localUtil.Format( A34etiquetafecharealizada, "99/99/9999 99:99:99")));
         GxWebStd.gx_hidden_field( context, "ETIQUETAFECHAREALIZADA", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF252( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF252( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         SubsflControlProps_842( ) ;
         nGXsfl_84_Refreshing = 1;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_842( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV9cetiquetasnumero ,
                                                 AV10cetiquetastatus ,
                                                 AV11cetiquetafecharealizada ,
                                                 AV12cetiquetasreimpresion ,
                                                 A32etiquetasnumero ,
                                                 A33etiquetastatus ,
                                                 A34etiquetafecharealizada ,
                                                 A35etiquetasreimpresion ,
                                                 AV6cetiquetasproductoid ,
                                                 AV7cetiquetascambsid ,
                                                 AV8calmacenid },
                                                 new int[] {
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                                 TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT, TypeConstants.LONG
                                                 }
            });
            /* Using cursor H00252 */
            pr_default.execute(0, new Object[] {AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A35etiquetasreimpresion = H00252_A35etiquetasreimpresion[0];
               n35etiquetasreimpresion = H00252_n35etiquetasreimpresion[0];
               A34etiquetafecharealizada = H00252_A34etiquetafecharealizada[0];
               n34etiquetafecharealizada = H00252_n34etiquetafecharealizada[0];
               A33etiquetastatus = H00252_A33etiquetastatus[0];
               n33etiquetastatus = H00252_n33etiquetastatus[0];
               A32etiquetasnumero = H00252_A32etiquetasnumero[0];
               n32etiquetasnumero = H00252_n32etiquetasnumero[0];
               A19almacenid = H00252_A19almacenid[0];
               A18etiquetascambsid = H00252_A18etiquetascambsid[0];
               A17etiquetasproductoid = H00252_A17etiquetasproductoid[0];
               /* Execute user event: E20252 */
               E20252 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB250( ) ;
         }
         nGXsfl_84_Refreshing = 0;
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV9cetiquetasnumero ,
                                              AV10cetiquetastatus ,
                                              AV11cetiquetafecharealizada ,
                                              AV12cetiquetasreimpresion ,
                                              A32etiquetasnumero ,
                                              A33etiquetastatus ,
                                              A34etiquetafecharealizada ,
                                              A35etiquetasreimpresion ,
                                              AV6cetiquetasproductoid ,
                                              AV7cetiquetascambsid ,
                                              AV8calmacenid },
                                              new int[] {
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT, TypeConstants.LONG
                                              }
         });
         /* Using cursor H00253 */
         pr_default.execute(1, new Object[] {AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion});
         GRID1_nRecordCount = H00253_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
         }
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
         }
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cetiquetasproductoid, AV7cetiquetascambsid, AV8calmacenid, AV9cetiquetasnumero, AV10cetiquetastatus, AV11cetiquetafecharealizada, AV12cetiquetasreimpresion) ;
         }
         return (int)(0) ;
      }

      protected void STRUP250( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19252 */
         E19252 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCETIQUETASPRODUCTOID");
               GX_FocusControl = edtavCetiquetasproductoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cetiquetasproductoid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cetiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cetiquetasproductoid), 9, 0)));
            }
            else
            {
               AV6cetiquetasproductoid = (int)(context.localUtil.CToN( cgiGet( edtavCetiquetasproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cetiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cetiquetasproductoid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCetiquetascambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCetiquetascambsid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCETIQUETASCAMBSID");
               GX_FocusControl = edtavCetiquetascambsid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cetiquetascambsid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cetiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cetiquetascambsid), 9, 0)));
            }
            else
            {
               AV7cetiquetascambsid = (int)(context.localUtil.CToN( cgiGet( edtavCetiquetascambsid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cetiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cetiquetascambsid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCALMACENID");
               GX_FocusControl = edtavCalmacenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8calmacenid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8calmacenid), 18, 0)));
            }
            else
            {
               AV8calmacenid = (long)(context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8calmacenid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasnumero_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasnumero_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCETIQUETASNUMERO");
               GX_FocusControl = edtavCetiquetasnumero_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cetiquetasnumero = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cetiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cetiquetasnumero), 18, 0)));
            }
            else
            {
               AV9cetiquetasnumero = (long)(context.localUtil.CToN( cgiGet( edtavCetiquetasnumero_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cetiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cetiquetasnumero), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCetiquetastatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCetiquetastatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCETIQUETASTATUS");
               GX_FocusControl = edtavCetiquetastatus_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cetiquetastatus = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cetiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cetiquetastatus), 18, 0)));
            }
            else
            {
               AV10cetiquetastatus = (long)(context.localUtil.CToN( cgiGet( edtavCetiquetastatus_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cetiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cetiquetastatus), 18, 0)));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCetiquetafecharealizada_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"etiquetafecharealizada"}), 1, "vCETIQUETAFECHAREALIZADA");
               GX_FocusControl = edtavCetiquetafecharealizada_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cetiquetafecharealizada = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cetiquetafecharealizada", context.localUtil.TToC( AV11cetiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11cetiquetafecharealizada = context.localUtil.CToT( cgiGet( edtavCetiquetafecharealizada_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cetiquetafecharealizada", context.localUtil.TToC( AV11cetiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasreimpresion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCetiquetasreimpresion_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCETIQUETASREIMPRESION");
               GX_FocusControl = edtavCetiquetasreimpresion_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cetiquetasreimpresion = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cetiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cetiquetasreimpresion), 18, 0)));
            }
            else
            {
               AV12cetiquetasreimpresion = (long)(context.localUtil.CToN( cgiGet( edtavCetiquetasreimpresion_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cetiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cetiquetasreimpresion), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV6cetiquetasproductoid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASCAMBSID"), ",", ".") != Convert.ToDecimal( AV7cetiquetascambsid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALMACENID"), ",", ".") != Convert.ToDecimal( AV8calmacenid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASNUMERO"), ",", ".") != Convert.ToDecimal( AV9cetiquetasnumero )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASTATUS"), ",", ".") != Convert.ToDecimal( AV10cetiquetastatus )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCETIQUETAFECHAREALIZADA"), 0) != AV11cetiquetafecharealizada )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCETIQUETASREIMPRESION"), ",", ".") != Convert.ToDecimal( AV12cetiquetasreimpresion )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E19252 */
         E19252 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19252( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "etiquetas", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV16ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20252( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV19Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E21252 */
         E21252 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21252( )
      {
         /* Enter Routine */
         AV13petiquetasproductoid = A17etiquetasproductoid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13petiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13petiquetasproductoid), 9, 0)));
         AV14petiquetascambsid = A18etiquetascambsid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14petiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14petiquetascambsid), 9, 0)));
         AV15palmacenid = A19almacenid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15palmacenid), 18, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13petiquetasproductoid,(int)AV14petiquetascambsid,(long)AV15palmacenid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13petiquetasproductoid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13petiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13petiquetasproductoid), 9, 0)));
         AV14petiquetascambsid = Convert.ToInt32(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14petiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14petiquetascambsid), 9, 0)));
         AV15palmacenid = Convert.ToInt64(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15palmacenid), 18, 0)));
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
         PA252( ) ;
         WS252( ) ;
         WE252( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1734189");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202212517353673");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00c0.js", "?202212517353673");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtetiquetasproductoid_Internalname = "ETIQUETASPRODUCTOID_"+sGXsfl_84_idx;
         edtetiquetascambsid_Internalname = "ETIQUETASCAMBSID_"+sGXsfl_84_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_idx;
         edtetiquetasnumero_Internalname = "ETIQUETASNUMERO_"+sGXsfl_84_idx;
         edtetiquetastatus_Internalname = "ETIQUETASTATUS_"+sGXsfl_84_idx;
         edtetiquetafecharealizada_Internalname = "ETIQUETAFECHAREALIZADA_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtetiquetasproductoid_Internalname = "ETIQUETASPRODUCTOID_"+sGXsfl_84_fel_idx;
         edtetiquetascambsid_Internalname = "ETIQUETASCAMBSID_"+sGXsfl_84_fel_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_fel_idx;
         edtetiquetasnumero_Internalname = "ETIQUETASNUMERO_"+sGXsfl_84_fel_idx;
         edtetiquetastatus_Internalname = "ETIQUETASTATUS_"+sGXsfl_84_fel_idx;
         edtetiquetafecharealizada_Internalname = "ETIQUETAFECHAREALIZADA_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB250( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV19Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV19Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtetiquetasproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A17etiquetasproductoid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtetiquetasproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtetiquetascambsid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A18etiquetascambsid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtetiquetascambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalmacenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalmacenid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtetiquetasnumero_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasnumero_Internalname, "Link", edtetiquetasnumero_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtetiquetasnumero_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32etiquetasnumero), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A32etiquetasnumero), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtetiquetasnumero_Link,(String)"",(String)"",(String)"",(String)edtetiquetasnumero_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtetiquetastatus_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33etiquetastatus), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A33etiquetastatus), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtetiquetastatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtetiquetafecharealizada_Internalname,context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A34etiquetafecharealizada, "99/99/9999 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtetiquetafecharealizada_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASPRODUCTOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A17etiquetasproductoid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASCAMBSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A18etiquetascambsid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASNUMERO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A32etiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETASTATUS"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A33etiquetastatus), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ETIQUETAFECHAREALIZADA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( A34etiquetafecharealizada, "99/99/9999 99:99:99")));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLbletiquetasproductoidfilter_Internalname = "LBLETIQUETASPRODUCTOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetasproductoid_Internalname = "vCETIQUETASPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetasproductoidfiltercontainer_Internalname = "ETIQUETASPRODUCTOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbletiquetascambsidfilter_Internalname = "LBLETIQUETASCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetascambsid_Internalname = "vCETIQUETASCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetascambsidfiltercontainer_Internalname = "ETIQUETASCAMBSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalmacenidfilter_Internalname = "LBLALMACENIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalmacenid_Internalname = "vCALMACENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlmacenidfiltercontainer_Internalname = "ALMACENIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbletiquetasnumerofilter_Internalname = "LBLETIQUETASNUMEROFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetasnumero_Internalname = "vCETIQUETASNUMERO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetasnumerofiltercontainer_Internalname = "ETIQUETASNUMEROFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbletiquetastatusfilter_Internalname = "LBLETIQUETASTATUSFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetastatus_Internalname = "vCETIQUETASTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetastatusfiltercontainer_Internalname = "ETIQUETASTATUSFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbletiquetafecharealizadafilter_Internalname = "LBLETIQUETAFECHAREALIZADAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetafecharealizada_Internalname = "vCETIQUETAFECHAREALIZADA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetafecharealizadafiltercontainer_Internalname = "ETIQUETAFECHAREALIZADAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbletiquetasreimpresionfilter_Internalname = "LBLETIQUETASREIMPRESIONFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCetiquetasreimpresion_Internalname = "vCETIQUETASREIMPRESION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEtiquetasreimpresionfiltercontainer_Internalname = "ETIQUETASREIMPRESIONFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtetiquetasproductoid_Internalname = "ETIQUETASPRODUCTOID";
         edtetiquetascambsid_Internalname = "ETIQUETASCAMBSID";
         edtalmacenid_Internalname = "ALMACENID";
         edtetiquetasnumero_Internalname = "ETIQUETASNUMERO";
         edtetiquetastatus_Internalname = "ETIQUETASTATUS";
         edtetiquetafecharealizada_Internalname = "ETIQUETAFECHAREALIZADA";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         div_Internalname = "";
         div_Internalname = "";
         divGridtable_Internalname = "GRIDTABLE";
         div_Internalname = "";
         div_Internalname = "";
         divMain_Internalname = "MAIN";
         div_Internalname = "";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtetiquetafecharealizada_Jsonclick = "";
         edtetiquetastatus_Jsonclick = "";
         edtetiquetasnumero_Jsonclick = "";
         edtalmacenid_Jsonclick = "";
         edtetiquetascambsid_Jsonclick = "";
         edtetiquetasproductoid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtetiquetasnumero_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCetiquetasreimpresion_Jsonclick = "";
         edtavCetiquetasreimpresion_Enabled = 1;
         edtavCetiquetasreimpresion_Visible = 1;
         edtavCetiquetafecharealizada_Jsonclick = "";
         edtavCetiquetafecharealizada_Enabled = 1;
         edtavCetiquetastatus_Jsonclick = "";
         edtavCetiquetastatus_Enabled = 1;
         edtavCetiquetastatus_Visible = 1;
         edtavCetiquetasnumero_Jsonclick = "";
         edtavCetiquetasnumero_Enabled = 1;
         edtavCetiquetasnumero_Visible = 1;
         edtavCalmacenid_Jsonclick = "";
         edtavCalmacenid_Enabled = 1;
         edtavCalmacenid_Visible = 1;
         edtavCetiquetascambsid_Jsonclick = "";
         edtavCetiquetascambsid_Enabled = 1;
         edtavCetiquetascambsid_Visible = 1;
         edtavCetiquetasproductoid_Jsonclick = "";
         edtavCetiquetasproductoid_Enabled = 1;
         edtavCetiquetasproductoid_Visible = 1;
         divEtiquetasreimpresionfiltercontainer_Class = "AdvancedContainerItem";
         divEtiquetafecharealizadafiltercontainer_Class = "AdvancedContainerItem";
         divEtiquetastatusfiltercontainer_Class = "AdvancedContainerItem";
         divEtiquetasnumerofiltercontainer_Class = "AdvancedContainerItem";
         divAlmacenidfiltercontainer_Class = "AdvancedContainerItem";
         divEtiquetascambsidfiltercontainer_Class = "AdvancedContainerItem";
         divEtiquetasproductoidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List etiquetas";
         subGrid1_Rows = 10;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cetiquetasproductoid',fld:'vCETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cetiquetascambsid',fld:'vCETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cetiquetasnumero',fld:'vCETIQUETASNUMERO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cetiquetastatus',fld:'vCETIQUETASTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cetiquetafecharealizada',fld:'vCETIQUETAFECHAREALIZADA',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cetiquetasreimpresion',fld:'vCETIQUETASREIMPRESION',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18251',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLETIQUETASPRODUCTOIDFILTER.CLICK","{handler:'E11251',iparms:[{av:'divEtiquetasproductoidfiltercontainer_Class',ctrl:'ETIQUETASPRODUCTOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetasproductoidfiltercontainer_Class',ctrl:'ETIQUETASPRODUCTOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCetiquetasproductoid_Visible',ctrl:'vCETIQUETASPRODUCTOID',prop:'Visible'}]}");
         setEventMetadata("LBLETIQUETASCAMBSIDFILTER.CLICK","{handler:'E12251',iparms:[{av:'divEtiquetascambsidfiltercontainer_Class',ctrl:'ETIQUETASCAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetascambsidfiltercontainer_Class',ctrl:'ETIQUETASCAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCetiquetascambsid_Visible',ctrl:'vCETIQUETASCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLALMACENIDFILTER.CLICK","{handler:'E13251',iparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacenid_Visible',ctrl:'vCALMACENID',prop:'Visible'}]}");
         setEventMetadata("LBLETIQUETASNUMEROFILTER.CLICK","{handler:'E14251',iparms:[{av:'divEtiquetasnumerofiltercontainer_Class',ctrl:'ETIQUETASNUMEROFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetasnumerofiltercontainer_Class',ctrl:'ETIQUETASNUMEROFILTERCONTAINER',prop:'Class'},{av:'edtavCetiquetasnumero_Visible',ctrl:'vCETIQUETASNUMERO',prop:'Visible'}]}");
         setEventMetadata("LBLETIQUETASTATUSFILTER.CLICK","{handler:'E15251',iparms:[{av:'divEtiquetastatusfiltercontainer_Class',ctrl:'ETIQUETASTATUSFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetastatusfiltercontainer_Class',ctrl:'ETIQUETASTATUSFILTERCONTAINER',prop:'Class'},{av:'edtavCetiquetastatus_Visible',ctrl:'vCETIQUETASTATUS',prop:'Visible'}]}");
         setEventMetadata("LBLETIQUETAFECHAREALIZADAFILTER.CLICK","{handler:'E16251',iparms:[{av:'divEtiquetafecharealizadafiltercontainer_Class',ctrl:'ETIQUETAFECHAREALIZADAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetafecharealizadafiltercontainer_Class',ctrl:'ETIQUETAFECHAREALIZADAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLETIQUETASREIMPRESIONFILTER.CLICK","{handler:'E17251',iparms:[{av:'divEtiquetasreimpresionfiltercontainer_Class',ctrl:'ETIQUETASREIMPRESIONFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEtiquetasreimpresionfiltercontainer_Class',ctrl:'ETIQUETASREIMPRESIONFILTERCONTAINER',prop:'Class'},{av:'edtavCetiquetasreimpresion_Visible',ctrl:'vCETIQUETASREIMPRESION',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21252',iparms:[{av:'A17etiquetasproductoid',fld:'ETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A18etiquetascambsid',fld:'ETIQUETASCAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A19almacenid',fld:'ALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13petiquetasproductoid',fld:'vPETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV14petiquetascambsid',fld:'vPETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV15palmacenid',fld:'vPALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cetiquetasproductoid',fld:'vCETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cetiquetascambsid',fld:'vCETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cetiquetasnumero',fld:'vCETIQUETASNUMERO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cetiquetastatus',fld:'vCETIQUETASTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cetiquetafecharealizada',fld:'vCETIQUETAFECHAREALIZADA',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cetiquetasreimpresion',fld:'vCETIQUETASREIMPRESION',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cetiquetasproductoid',fld:'vCETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cetiquetascambsid',fld:'vCETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cetiquetasnumero',fld:'vCETIQUETASNUMERO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cetiquetastatus',fld:'vCETIQUETASTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cetiquetafecharealizada',fld:'vCETIQUETAFECHAREALIZADA',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cetiquetasreimpresion',fld:'vCETIQUETASREIMPRESION',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cetiquetasproductoid',fld:'vCETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cetiquetascambsid',fld:'vCETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cetiquetasnumero',fld:'vCETIQUETASNUMERO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cetiquetastatus',fld:'vCETIQUETASTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cetiquetafecharealizada',fld:'vCETIQUETAFECHAREALIZADA',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cetiquetasreimpresion',fld:'vCETIQUETASREIMPRESION',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cetiquetasproductoid',fld:'vCETIQUETASPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cetiquetascambsid',fld:'vCETIQUETASCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cetiquetasnumero',fld:'vCETIQUETASNUMERO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cetiquetastatus',fld:'vCETIQUETASTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cetiquetafecharealizada',fld:'vCETIQUETAFECHAREALIZADA',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cetiquetasreimpresion',fld:'vCETIQUETASREIMPRESION',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
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
         AV11cetiquetafecharealizada = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbletiquetasproductoidfilter_Jsonclick = "";
         TempTags = "";
         lblLbletiquetascambsidfilter_Jsonclick = "";
         lblLblalmacenidfilter_Jsonclick = "";
         lblLbletiquetasnumerofilter_Jsonclick = "";
         lblLbletiquetastatusfilter_Jsonclick = "";
         lblLbletiquetafecharealizadafilter_Jsonclick = "";
         lblLbletiquetasreimpresionfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV19Linkselection_GXI = "";
         scmdbuf = "";
         H00252_A35etiquetasreimpresion = new long[1] ;
         H00252_n35etiquetasreimpresion = new bool[] {false} ;
         H00252_A34etiquetafecharealizada = new DateTime[] {DateTime.MinValue} ;
         H00252_n34etiquetafecharealizada = new bool[] {false} ;
         H00252_A33etiquetastatus = new long[1] ;
         H00252_n33etiquetastatus = new bool[] {false} ;
         H00252_A32etiquetasnumero = new long[1] ;
         H00252_n32etiquetasnumero = new bool[] {false} ;
         H00252_A19almacenid = new long[1] ;
         H00252_A18etiquetascambsid = new int[1] ;
         H00252_A17etiquetasproductoid = new int[1] ;
         H00253_AGRID1_nRecordCount = new long[1] ;
         AV16ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00c0__default(),
            new Object[][] {
                new Object[] {
               H00252_A35etiquetasreimpresion, H00252_n35etiquetasreimpresion, H00252_A34etiquetafecharealizada, H00252_n34etiquetafecharealizada, H00252_A33etiquetastatus, H00252_n33etiquetastatus, H00252_A32etiquetasnumero, H00252_n32etiquetasnumero, H00252_A19almacenid, H00252_A18etiquetascambsid,
               H00252_A17etiquetasproductoid
               }
               , new Object[] {
               H00253_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_84 ;
      private short nGXsfl_84_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_84_Refreshing=0 ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV6cetiquetasproductoid ;
      private int AV7cetiquetascambsid ;
      private int AV13petiquetasproductoid ;
      private int AV14petiquetascambsid ;
      private int edtavCetiquetasproductoid_Enabled ;
      private int edtavCetiquetasproductoid_Visible ;
      private int edtavCetiquetascambsid_Enabled ;
      private int edtavCetiquetascambsid_Visible ;
      private int edtavCalmacenid_Enabled ;
      private int edtavCalmacenid_Visible ;
      private int edtavCetiquetasnumero_Enabled ;
      private int edtavCetiquetasnumero_Visible ;
      private int edtavCetiquetastatus_Enabled ;
      private int edtavCetiquetastatus_Visible ;
      private int edtavCetiquetafecharealizada_Enabled ;
      private int edtavCetiquetasreimpresion_Enabled ;
      private int edtavCetiquetasreimpresion_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A17etiquetasproductoid ;
      private int A18etiquetascambsid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV8calmacenid ;
      private long AV9cetiquetasnumero ;
      private long AV10cetiquetastatus ;
      private long AV12cetiquetasreimpresion ;
      private long AV15palmacenid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A19almacenid ;
      private long A32etiquetasnumero ;
      private long A33etiquetastatus ;
      private long GRID1_nCurrentRecord ;
      private long A35etiquetasreimpresion ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEtiquetasproductoidfiltercontainer_Class ;
      private String divEtiquetascambsidfiltercontainer_Class ;
      private String divAlmacenidfiltercontainer_Class ;
      private String divEtiquetasnumerofiltercontainer_Class ;
      private String divEtiquetastatusfiltercontainer_Class ;
      private String divEtiquetafecharealizadafiltercontainer_Class ;
      private String divEtiquetasreimpresionfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divEtiquetasproductoidfiltercontainer_Internalname ;
      private String lblLbletiquetasproductoidfilter_Internalname ;
      private String lblLbletiquetasproductoidfilter_Jsonclick ;
      private String edtavCetiquetasproductoid_Internalname ;
      private String TempTags ;
      private String edtavCetiquetasproductoid_Jsonclick ;
      private String divEtiquetascambsidfiltercontainer_Internalname ;
      private String lblLbletiquetascambsidfilter_Internalname ;
      private String lblLbletiquetascambsidfilter_Jsonclick ;
      private String edtavCetiquetascambsid_Internalname ;
      private String edtavCetiquetascambsid_Jsonclick ;
      private String divAlmacenidfiltercontainer_Internalname ;
      private String lblLblalmacenidfilter_Internalname ;
      private String lblLblalmacenidfilter_Jsonclick ;
      private String edtavCalmacenid_Internalname ;
      private String edtavCalmacenid_Jsonclick ;
      private String divEtiquetasnumerofiltercontainer_Internalname ;
      private String lblLbletiquetasnumerofilter_Internalname ;
      private String lblLbletiquetasnumerofilter_Jsonclick ;
      private String edtavCetiquetasnumero_Internalname ;
      private String edtavCetiquetasnumero_Jsonclick ;
      private String divEtiquetastatusfiltercontainer_Internalname ;
      private String lblLbletiquetastatusfilter_Internalname ;
      private String lblLbletiquetastatusfilter_Jsonclick ;
      private String edtavCetiquetastatus_Internalname ;
      private String edtavCetiquetastatus_Jsonclick ;
      private String divEtiquetafecharealizadafiltercontainer_Internalname ;
      private String lblLbletiquetafecharealizadafilter_Internalname ;
      private String lblLbletiquetafecharealizadafilter_Jsonclick ;
      private String edtavCetiquetafecharealizada_Internalname ;
      private String edtavCetiquetafecharealizada_Jsonclick ;
      private String divEtiquetasreimpresionfiltercontainer_Internalname ;
      private String lblLbletiquetasreimpresionfilter_Internalname ;
      private String lblLbletiquetasreimpresionfilter_Jsonclick ;
      private String edtavCetiquetasreimpresion_Internalname ;
      private String edtavCetiquetasreimpresion_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtetiquetasnumero_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtetiquetasproductoid_Internalname ;
      private String edtetiquetascambsid_Internalname ;
      private String edtalmacenid_Internalname ;
      private String edtetiquetasnumero_Internalname ;
      private String edtetiquetastatus_Internalname ;
      private String edtetiquetafecharealizada_Internalname ;
      private String scmdbuf ;
      private String AV16ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtetiquetasproductoid_Jsonclick ;
      private String edtetiquetascambsid_Jsonclick ;
      private String edtalmacenid_Jsonclick ;
      private String edtetiquetasnumero_Jsonclick ;
      private String edtetiquetastatus_Jsonclick ;
      private String edtetiquetafecharealizada_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV11cetiquetafecharealizada ;
      private DateTime A34etiquetafecharealizada ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n32etiquetasnumero ;
      private bool n33etiquetastatus ;
      private bool n34etiquetafecharealizada ;
      private bool n35etiquetasreimpresion ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV19Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00252_A35etiquetasreimpresion ;
      private bool[] H00252_n35etiquetasreimpresion ;
      private DateTime[] H00252_A34etiquetafecharealizada ;
      private bool[] H00252_n34etiquetafecharealizada ;
      private long[] H00252_A33etiquetastatus ;
      private bool[] H00252_n33etiquetastatus ;
      private long[] H00252_A32etiquetasnumero ;
      private bool[] H00252_n32etiquetasnumero ;
      private long[] H00252_A19almacenid ;
      private int[] H00252_A18etiquetascambsid ;
      private int[] H00252_A17etiquetasproductoid ;
      private long[] H00253_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_petiquetasproductoid ;
      private int aP1_petiquetascambsid ;
      private long aP2_palmacenid ;
      private GXWebForm Form ;
   }

   public class gx00c0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00252( IGxContext context ,
                                             long AV9cetiquetasnumero ,
                                             long AV10cetiquetastatus ,
                                             DateTime AV11cetiquetafecharealizada ,
                                             long AV12cetiquetasreimpresion ,
                                             long A32etiquetasnumero ,
                                             long A33etiquetastatus ,
                                             DateTime A34etiquetafecharealizada ,
                                             long A35etiquetasreimpresion ,
                                             int AV6cetiquetasproductoid ,
                                             int AV7cetiquetascambsid ,
                                             long AV8calmacenid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " etiquetasreimpresión, etiquetafecharealizada, etiquetastatus, etiquetasnumero, articuloid, cambsid, productoid";
         sFromString = " FROM public.etiquetas";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (productoid >= :AV6cetiquetasproductoid and cambsid >= :AV7cetiquetascambsid and articuloid >= :AV8calmacenid)";
         if ( ! (0==AV9cetiquetasnumero) )
         {
            sWhereString = sWhereString + " and (etiquetasnumero >= :AV9cetiquetasnumero)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cetiquetastatus) )
         {
            sWhereString = sWhereString + " and (etiquetastatus >= :AV10cetiquetastatus)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11cetiquetafecharealizada) )
         {
            sWhereString = sWhereString + " and (etiquetafecharealizada >= :AV11cetiquetafecharealizada)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV12cetiquetasreimpresion) )
         {
            sWhereString = sWhereString + " and (etiquetasreimpresión >= :AV12cetiquetasreimpresion)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY productoid, cambsid, articuloid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00253( IGxContext context ,
                                             long AV9cetiquetasnumero ,
                                             long AV10cetiquetastatus ,
                                             DateTime AV11cetiquetafecharealizada ,
                                             long AV12cetiquetasreimpresion ,
                                             long A32etiquetasnumero ,
                                             long A33etiquetastatus ,
                                             DateTime A34etiquetafecharealizada ,
                                             long A35etiquetasreimpresion ,
                                             int AV6cetiquetasproductoid ,
                                             int AV7cetiquetascambsid ,
                                             long AV8calmacenid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.etiquetas";
         scmdbuf = scmdbuf + " WHERE (productoid >= :AV6cetiquetasproductoid and cambsid >= :AV7cetiquetascambsid and articuloid >= :AV8calmacenid)";
         if ( ! (0==AV9cetiquetasnumero) )
         {
            sWhereString = sWhereString + " and (etiquetasnumero >= :AV9cetiquetasnumero)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cetiquetastatus) )
         {
            sWhereString = sWhereString + " and (etiquetastatus >= :AV10cetiquetastatus)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11cetiquetafecharealizada) )
         {
            sWhereString = sWhereString + " and (etiquetafecharealizada >= :AV11cetiquetafecharealizada)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV12cetiquetasreimpresion) )
         {
            sWhereString = sWhereString + " and (etiquetasreimpresión >= :AV12cetiquetasreimpresion)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00252(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (long)dynConstraints[10] );
               case 1 :
                     return conditional_H00253(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (long)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00252 ;
          prmH00252 = new Object[] {
          new Object[] {"AV6cetiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7cetiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8calmacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV9cetiquetasnumero",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10cetiquetastatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11cetiquetafecharealizada",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12cetiquetasreimpresion",NpgsqlDbType.Real,18,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00253 ;
          prmH00253 = new Object[] {
          new Object[] {"AV6cetiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7cetiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8calmacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV9cetiquetasnumero",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10cetiquetastatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11cetiquetafecharealizada",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12cetiquetasreimpresion",NpgsqlDbType.Real,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00252", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00252,11,0,false,false )
             ,new CursorDef("H00253", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00253,1,0,false,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                return;
       }
    }

 }

}
