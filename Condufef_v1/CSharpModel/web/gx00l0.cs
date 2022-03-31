/*
               File: Gx00L0
        Description: Selection List status
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:20:2.15
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
   public class gx00l0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00l0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00l0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pstatusid )
      {
         this.AV13pstatusid = 0 ;
         executePrivate();
         aP0_pstatusid=this.AV13pstatusid;
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
               AV6cstatusid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cstatusid), 9, 0)));
               AV7cstatusdsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cstatusdsc", AV7cstatusdsc);
               AV8cstatususotabla = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cstatususotabla", AV8cstatususotabla);
               AV9cstatusdesc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cstatusdesc", AV9cstatusdesc);
               AV10cstatususuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cstatususuario", AV10cstatususuario);
               AV11cstatusfecreg = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cstatusfecreg", context.localUtil.TToC( AV11cstatusfecreg, 10, 8, 0, 3, "/", ":", " "));
               AV12cstatusfecultact = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cstatusfecultact", context.localUtil.TToC( AV12cstatusfecultact, 10, 8, 0, 3, "/", ":", " "));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
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
               AV13pstatusid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pstatusid), 9, 0)));
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
         PA2A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2A2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022331020219");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00l0.aspx") + "?" + UrlEncode("" +AV13pstatusid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cstatusid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSDSC", AV7cstatusdsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSUSOTABLA", AV8cstatususotabla);
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSDESC", AV9cstatusdesc);
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSUSUARIO", AV10cstatususuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSFECREG", context.localUtil.TToC( AV11cstatusfecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCSTATUSFECULTACT", context.localUtil.TToC( AV12cstatusfecultact, 10, 8, 0, 3, "/", ":", " "));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPSTATUSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pstatusid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "STATUSIDFILTERCONTAINER_Class", StringUtil.RTrim( divStatusidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSDSCFILTERCONTAINER_Class", StringUtil.RTrim( divStatusdscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSUSOTABLAFILTERCONTAINER_Class", StringUtil.RTrim( divStatususotablafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSDESCFILTERCONTAINER_Class", StringUtil.RTrim( divStatusdescfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divStatususuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divStatusfecregfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STATUSFECULTACTFILTERCONTAINER_Class", StringUtil.RTrim( divStatusfecultactfiltercontainer_Class));
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
            WE2A2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2A2( ) ;
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
         return formatLink("gx00l0.aspx") + "?" + UrlEncode("" +AV13pstatusid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00L0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List status" ;
      }

      protected void WB2A0( )
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
            GxWebStd.gx_div_start( context, divStatusidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatusidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatusidfilter_Internalname, "statusid", "", "", lblLblstatusidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e112a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatusid_Internalname, "statusid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstatusid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cstatusid), 9, 0, ",", "")), ((edtavCstatusid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cstatusid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cstatusid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatusid_Jsonclick, 0, "Attribute", "", "", "", edtavCstatusid_Visible, edtavCstatusid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatusdscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatusdscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatusdscfilter_Internalname, "statusdsc", "", "", lblLblstatusdscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e122a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatusdsc_Internalname, "statusdsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstatusdsc_Internalname, AV7cstatusdsc, StringUtil.RTrim( context.localUtil.Format( AV7cstatusdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatusdsc_Jsonclick, 0, "Attribute", "", "", "", edtavCstatusdsc_Visible, edtavCstatusdsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatususotablafiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatususotablafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatususotablafilter_Internalname, "statususotabla", "", "", lblLblstatususotablafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e132a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatususotabla_Internalname, "statususotabla", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstatususotabla_Internalname, AV8cstatususotabla, StringUtil.RTrim( context.localUtil.Format( AV8cstatususotabla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatususotabla_Jsonclick, 0, "Attribute", "", "", "", edtavCstatususotabla_Visible, edtavCstatususotabla_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatusdescfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatusdescfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatusdescfilter_Internalname, "statusdesc", "", "", lblLblstatusdescfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e142a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatusdesc_Internalname, "statusdesc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstatusdesc_Internalname, AV9cstatusdesc, StringUtil.RTrim( context.localUtil.Format( AV9cstatusdesc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatusdesc_Jsonclick, 0, "Attribute", "", "", "", edtavCstatusdesc_Visible, edtavCstatusdesc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatususuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatususuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatususuariofilter_Internalname, "statususuario", "", "", lblLblstatususuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e152a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatususuario_Internalname, "statususuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstatususuario_Internalname, AV10cstatususuario, StringUtil.RTrim( context.localUtil.Format( AV10cstatususuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatususuario_Jsonclick, 0, "Attribute", "", "", "", edtavCstatususuario_Visible, edtavCstatususuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatusfecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatusfecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatusfecregfilter_Internalname, "statusfecreg", "", "", lblLblstatusfecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e162a1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatusfecreg_Internalname, "statusfecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCstatusfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCstatusfecreg_Internalname, context.localUtil.TToC( AV11cstatusfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV11cstatusfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatusfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCstatusfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00L0.htm");
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
            GxWebStd.gx_div_start( context, divStatusfecultactfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStatusfecultactfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstatusfecultactfilter_Internalname, "statusfecultact", "", "", lblLblstatusfecultactfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e172a1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00L0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstatusfecultact_Internalname, "statusfecultact", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCstatusfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCstatusfecultact_Internalname, context.localUtil.TToC( AV12cstatusfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV12cstatusfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstatusfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCstatusfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00L0.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e182a1_client"+"'", TempTags, "", 2, "HLP_Gx00L0.htm");
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
               context.SendWebValue( "statusid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "statusdsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "statususotabla") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "statususuario") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A73statusdsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtstatusdsc_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A74statususotabla);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A76statususuario);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00L0.htm");
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

      protected void START2A2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List status", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2A0( ) ;
      }

      protected void WS2A2( )
      {
         START2A2( ) ;
         EVT2A2( ) ;
      }

      protected void EVT2A2( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A1statusid = (int)(context.localUtil.CToN( cgiGet( edtstatusid_Internalname), ",", "."));
                              A73statusdsc = cgiGet( edtstatusdsc_Internalname);
                              n73statusdsc = false;
                              A74statususotabla = cgiGet( edtstatususotabla_Internalname);
                              n74statususotabla = false;
                              A76statususuario = cgiGet( edtstatususuario_Internalname);
                              n76statususuario = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E192A2 */
                                    E192A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E202A2 */
                                    E202A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cstatusid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTATUSID"), ",", ".") != Convert.ToDecimal( AV6cstatusid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatusdsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSDSC"), AV7cstatusdsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatususotabla Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSUSOTABLA"), AV8cstatususotabla) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatusdesc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSDESC"), AV9cstatusdesc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatususuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSUSUARIO"), AV10cstatususuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatusfecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCSTATUSFECREG"), 0) != AV11cstatusfecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstatusfecultact Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCSTATUSFECULTACT"), 0) != AV12cstatusfecultact )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E212A2 */
                                          E212A2 ();
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

      protected void WE2A2( )
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

      protected void PA2A2( )
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
                                        int AV6cstatusid ,
                                        String AV7cstatusdsc ,
                                        String AV8cstatususotabla ,
                                        String AV9cstatusdesc ,
                                        String AV10cstatususuario ,
                                        DateTime AV11cstatusfecreg ,
                                        DateTime AV12cstatusfecultact )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF2A2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_STATUSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "STATUSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_STATUSDSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A73statusdsc, ""))));
         GxWebStd.gx_hidden_field( context, "STATUSDSC", A73statusdsc);
         GxWebStd.gx_hidden_field( context, "gxhash_STATUSUSOTABLA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A74statususotabla, ""))));
         GxWebStd.gx_hidden_field( context, "STATUSUSOTABLA", A74statususotabla);
         GxWebStd.gx_hidden_field( context, "gxhash_STATUSUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A76statususuario, ""))));
         GxWebStd.gx_hidden_field( context, "STATUSUSUARIO", A76statususuario);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2A2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2A2( )
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
                                                 AV7cstatusdsc ,
                                                 AV8cstatususotabla ,
                                                 AV9cstatusdesc ,
                                                 AV10cstatususuario ,
                                                 AV11cstatusfecreg ,
                                                 AV12cstatusfecultact ,
                                                 A73statusdsc ,
                                                 A74statususotabla ,
                                                 A75statusdesc ,
                                                 A76statususuario ,
                                                 A77statusfecreg ,
                                                 A78statusfecultact ,
                                                 AV6cstatusid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV7cstatusdsc = StringUtil.Concat( StringUtil.RTrim( AV7cstatusdsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cstatusdsc", AV7cstatusdsc);
            lV8cstatususotabla = StringUtil.Concat( StringUtil.RTrim( AV8cstatususotabla), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cstatususotabla", AV8cstatususotabla);
            lV9cstatusdesc = StringUtil.Concat( StringUtil.RTrim( AV9cstatusdesc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cstatusdesc", AV9cstatusdesc);
            lV10cstatususuario = StringUtil.Concat( StringUtil.RTrim( AV10cstatususuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cstatususuario", AV10cstatususuario);
            /* Using cursor H002A2 */
            pr_default.execute(0, new Object[] {AV6cstatusid, lV7cstatusdsc, lV8cstatususotabla, lV9cstatusdesc, lV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A78statusfecultact = H002A2_A78statusfecultact[0];
               n78statusfecultact = H002A2_n78statusfecultact[0];
               A77statusfecreg = H002A2_A77statusfecreg[0];
               n77statusfecreg = H002A2_n77statusfecreg[0];
               A75statusdesc = H002A2_A75statusdesc[0];
               n75statusdesc = H002A2_n75statusdesc[0];
               A76statususuario = H002A2_A76statususuario[0];
               n76statususuario = H002A2_n76statususuario[0];
               A74statususotabla = H002A2_A74statususotabla[0];
               n74statususotabla = H002A2_n74statususotabla[0];
               A73statusdsc = H002A2_A73statusdsc[0];
               n73statusdsc = H002A2_n73statusdsc[0];
               A1statusid = H002A2_A1statusid[0];
               /* Execute user event: E202A2 */
               E202A2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB2A0( ) ;
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
                                              AV7cstatusdsc ,
                                              AV8cstatususotabla ,
                                              AV9cstatusdesc ,
                                              AV10cstatususuario ,
                                              AV11cstatusfecreg ,
                                              AV12cstatusfecultact ,
                                              A73statusdsc ,
                                              A74statususotabla ,
                                              A75statusdesc ,
                                              A76statususuario ,
                                              A77statusfecreg ,
                                              A78statusfecultact ,
                                              AV6cstatusid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV7cstatusdsc = StringUtil.Concat( StringUtil.RTrim( AV7cstatusdsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cstatusdsc", AV7cstatusdsc);
         lV8cstatususotabla = StringUtil.Concat( StringUtil.RTrim( AV8cstatususotabla), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cstatususotabla", AV8cstatususotabla);
         lV9cstatusdesc = StringUtil.Concat( StringUtil.RTrim( AV9cstatusdesc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cstatusdesc", AV9cstatusdesc);
         lV10cstatususuario = StringUtil.Concat( StringUtil.RTrim( AV10cstatususuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cstatususuario", AV10cstatususuario);
         /* Using cursor H002A3 */
         pr_default.execute(1, new Object[] {AV6cstatusid, lV7cstatusdsc, lV8cstatususotabla, lV9cstatusdesc, lV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact});
         GRID1_nRecordCount = H002A3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cstatusid, AV7cstatusdsc, AV8cstatususotabla, AV9cstatusdesc, AV10cstatususuario, AV11cstatusfecreg, AV12cstatusfecultact) ;
         }
         return (int)(0) ;
      }

      protected void STRUP2A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E192A2 */
         E192A2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCstatusid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCstatusid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSTATUSID");
               GX_FocusControl = edtavCstatusid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cstatusid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cstatusid), 9, 0)));
            }
            else
            {
               AV6cstatusid = (int)(context.localUtil.CToN( cgiGet( edtavCstatusid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cstatusid), 9, 0)));
            }
            AV7cstatusdsc = cgiGet( edtavCstatusdsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cstatusdsc", AV7cstatusdsc);
            AV8cstatususotabla = cgiGet( edtavCstatususotabla_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cstatususotabla", AV8cstatususotabla);
            AV9cstatusdesc = cgiGet( edtavCstatusdesc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cstatusdesc", AV9cstatusdesc);
            AV10cstatususuario = cgiGet( edtavCstatususuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cstatususuario", AV10cstatususuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCstatusfecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"statusfecreg"}), 1, "vCSTATUSFECREG");
               GX_FocusControl = edtavCstatusfecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cstatusfecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cstatusfecreg", context.localUtil.TToC( AV11cstatusfecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11cstatusfecreg = context.localUtil.CToT( cgiGet( edtavCstatusfecreg_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cstatusfecreg", context.localUtil.TToC( AV11cstatusfecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCstatusfecultact_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"statusfecultact"}), 1, "vCSTATUSFECULTACT");
               GX_FocusControl = edtavCstatusfecultact_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cstatusfecultact = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cstatusfecultact", context.localUtil.TToC( AV12cstatusfecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12cstatusfecultact = context.localUtil.CToT( cgiGet( edtavCstatusfecultact_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cstatusfecultact", context.localUtil.TToC( AV12cstatusfecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTATUSID"), ",", ".") != Convert.ToDecimal( AV6cstatusid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSDSC"), AV7cstatusdsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSUSOTABLA"), AV8cstatususotabla) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSDESC"), AV9cstatusdesc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSTATUSUSUARIO"), AV10cstatususuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCSTATUSFECREG"), 0) != AV11cstatusfecreg )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCSTATUSFECULTACT"), 0) != AV12cstatusfecultact )
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
         /* Execute user event: E192A2 */
         E192A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E192A2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "status", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E202A2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E212A2 */
         E212A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E212A2( )
      {
         /* Enter Routine */
         AV13pstatusid = A1statusid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pstatusid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pstatusid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pstatusid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pstatusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pstatusid), 9, 0)));
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
         PA2A2( ) ;
         WS2A2( ) ;
         WE2A2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0185564");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022331020310");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00l0.js", "?2022331020311");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtstatusid_Internalname = "STATUSID_"+sGXsfl_84_idx;
         edtstatusdsc_Internalname = "STATUSDSC_"+sGXsfl_84_idx;
         edtstatususotabla_Internalname = "STATUSUSOTABLA_"+sGXsfl_84_idx;
         edtstatususuario_Internalname = "STATUSUSUARIO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtstatusid_Internalname = "STATUSID_"+sGXsfl_84_fel_idx;
         edtstatusdsc_Internalname = "STATUSDSC_"+sGXsfl_84_fel_idx;
         edtstatususotabla_Internalname = "STATUSUSOTABLA_"+sGXsfl_84_fel_idx;
         edtstatususuario_Internalname = "STATUSUSUARIO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB2A0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstatusid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstatusid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtstatusdsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusdsc_Internalname, "Link", edtstatusdsc_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstatusdsc_Internalname,(String)A73statusdsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtstatusdsc_Link,(String)"",(String)"",(String)"",(String)edtstatusdsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstatususotabla_Internalname,(String)A74statususotabla,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstatususotabla_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstatususuario_Internalname,(String)A76statususuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstatususuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_STATUSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_STATUSDSC"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A73statusdsc, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_STATUSUSOTABLA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A74statususotabla, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_STATUSUSUARIO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A76statususuario, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblstatusidfilter_Internalname = "LBLSTATUSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatusid_Internalname = "vCSTATUSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatusidfiltercontainer_Internalname = "STATUSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatusdscfilter_Internalname = "LBLSTATUSDSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatusdsc_Internalname = "vCSTATUSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatusdscfiltercontainer_Internalname = "STATUSDSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatususotablafilter_Internalname = "LBLSTATUSUSOTABLAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatususotabla_Internalname = "vCSTATUSUSOTABLA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatususotablafiltercontainer_Internalname = "STATUSUSOTABLAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatusdescfilter_Internalname = "LBLSTATUSDESCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatusdesc_Internalname = "vCSTATUSDESC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatusdescfiltercontainer_Internalname = "STATUSDESCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatususuariofilter_Internalname = "LBLSTATUSUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatususuario_Internalname = "vCSTATUSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatususuariofiltercontainer_Internalname = "STATUSUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatusfecregfilter_Internalname = "LBLSTATUSFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatusfecreg_Internalname = "vCSTATUSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatusfecregfiltercontainer_Internalname = "STATUSFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblstatusfecultactfilter_Internalname = "LBLSTATUSFECULTACTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCstatusfecultact_Internalname = "vCSTATUSFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divStatusfecultactfiltercontainer_Internalname = "STATUSFECULTACTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtstatusid_Internalname = "STATUSID";
         edtstatusdsc_Internalname = "STATUSDSC";
         edtstatususotabla_Internalname = "STATUSUSOTABLA";
         edtstatususuario_Internalname = "STATUSUSUARIO";
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
         edtstatususuario_Jsonclick = "";
         edtstatususotabla_Jsonclick = "";
         edtstatusdsc_Jsonclick = "";
         edtstatusid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtstatusdsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCstatusfecultact_Jsonclick = "";
         edtavCstatusfecultact_Enabled = 1;
         edtavCstatusfecreg_Jsonclick = "";
         edtavCstatusfecreg_Enabled = 1;
         edtavCstatususuario_Jsonclick = "";
         edtavCstatususuario_Enabled = 1;
         edtavCstatususuario_Visible = 1;
         edtavCstatusdesc_Jsonclick = "";
         edtavCstatusdesc_Enabled = 1;
         edtavCstatusdesc_Visible = 1;
         edtavCstatususotabla_Jsonclick = "";
         edtavCstatususotabla_Enabled = 1;
         edtavCstatususotabla_Visible = 1;
         edtavCstatusdsc_Jsonclick = "";
         edtavCstatusdsc_Enabled = 1;
         edtavCstatusdsc_Visible = 1;
         edtavCstatusid_Jsonclick = "";
         edtavCstatusid_Enabled = 1;
         edtavCstatusid_Visible = 1;
         divStatusfecultactfiltercontainer_Class = "AdvancedContainerItem";
         divStatusfecregfiltercontainer_Class = "AdvancedContainerItem";
         divStatususuariofiltercontainer_Class = "AdvancedContainerItem";
         divStatusdescfiltercontainer_Class = "AdvancedContainerItem";
         divStatususotablafiltercontainer_Class = "AdvancedContainerItem";
         divStatusdscfiltercontainer_Class = "AdvancedContainerItem";
         divStatusidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List status";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cstatusid',fld:'vCSTATUSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cstatusdsc',fld:'vCSTATUSDSC',pic:'',nv:''},{av:'AV8cstatususotabla',fld:'vCSTATUSUSOTABLA',pic:'',nv:''},{av:'AV9cstatusdesc',fld:'vCSTATUSDESC',pic:'',nv:''},{av:'AV10cstatususuario',fld:'vCSTATUSUSUARIO',pic:'',nv:''},{av:'AV11cstatusfecreg',fld:'vCSTATUSFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cstatusfecultact',fld:'vCSTATUSFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E182A1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLSTATUSIDFILTER.CLICK","{handler:'E112A1',iparms:[{av:'divStatusidfiltercontainer_Class',ctrl:'STATUSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatusidfiltercontainer_Class',ctrl:'STATUSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCstatusid_Visible',ctrl:'vCSTATUSID',prop:'Visible'}]}");
         setEventMetadata("LBLSTATUSDSCFILTER.CLICK","{handler:'E122A1',iparms:[{av:'divStatusdscfiltercontainer_Class',ctrl:'STATUSDSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatusdscfiltercontainer_Class',ctrl:'STATUSDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCstatusdsc_Visible',ctrl:'vCSTATUSDSC',prop:'Visible'}]}");
         setEventMetadata("LBLSTATUSUSOTABLAFILTER.CLICK","{handler:'E132A1',iparms:[{av:'divStatususotablafiltercontainer_Class',ctrl:'STATUSUSOTABLAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatususotablafiltercontainer_Class',ctrl:'STATUSUSOTABLAFILTERCONTAINER',prop:'Class'},{av:'edtavCstatususotabla_Visible',ctrl:'vCSTATUSUSOTABLA',prop:'Visible'}]}");
         setEventMetadata("LBLSTATUSDESCFILTER.CLICK","{handler:'E142A1',iparms:[{av:'divStatusdescfiltercontainer_Class',ctrl:'STATUSDESCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatusdescfiltercontainer_Class',ctrl:'STATUSDESCFILTERCONTAINER',prop:'Class'},{av:'edtavCstatusdesc_Visible',ctrl:'vCSTATUSDESC',prop:'Visible'}]}");
         setEventMetadata("LBLSTATUSUSUARIOFILTER.CLICK","{handler:'E152A1',iparms:[{av:'divStatususuariofiltercontainer_Class',ctrl:'STATUSUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatususuariofiltercontainer_Class',ctrl:'STATUSUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCstatususuario_Visible',ctrl:'vCSTATUSUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLSTATUSFECREGFILTER.CLICK","{handler:'E162A1',iparms:[{av:'divStatusfecregfiltercontainer_Class',ctrl:'STATUSFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatusfecregfiltercontainer_Class',ctrl:'STATUSFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLSTATUSFECULTACTFILTER.CLICK","{handler:'E172A1',iparms:[{av:'divStatusfecultactfiltercontainer_Class',ctrl:'STATUSFECULTACTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divStatusfecultactfiltercontainer_Class',ctrl:'STATUSFECULTACTFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E212A2',iparms:[{av:'A1statusid',fld:'STATUSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pstatusid',fld:'vPSTATUSID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cstatusid',fld:'vCSTATUSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cstatusdsc',fld:'vCSTATUSDSC',pic:'',nv:''},{av:'AV8cstatususotabla',fld:'vCSTATUSUSOTABLA',pic:'',nv:''},{av:'AV9cstatusdesc',fld:'vCSTATUSDESC',pic:'',nv:''},{av:'AV10cstatususuario',fld:'vCSTATUSUSUARIO',pic:'',nv:''},{av:'AV11cstatusfecreg',fld:'vCSTATUSFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cstatusfecultact',fld:'vCSTATUSFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cstatusid',fld:'vCSTATUSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cstatusdsc',fld:'vCSTATUSDSC',pic:'',nv:''},{av:'AV8cstatususotabla',fld:'vCSTATUSUSOTABLA',pic:'',nv:''},{av:'AV9cstatusdesc',fld:'vCSTATUSDESC',pic:'',nv:''},{av:'AV10cstatususuario',fld:'vCSTATUSUSUARIO',pic:'',nv:''},{av:'AV11cstatusfecreg',fld:'vCSTATUSFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cstatusfecultact',fld:'vCSTATUSFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cstatusid',fld:'vCSTATUSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cstatusdsc',fld:'vCSTATUSDSC',pic:'',nv:''},{av:'AV8cstatususotabla',fld:'vCSTATUSUSOTABLA',pic:'',nv:''},{av:'AV9cstatusdesc',fld:'vCSTATUSDESC',pic:'',nv:''},{av:'AV10cstatususuario',fld:'vCSTATUSUSUARIO',pic:'',nv:''},{av:'AV11cstatusfecreg',fld:'vCSTATUSFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cstatusfecultact',fld:'vCSTATUSFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cstatusid',fld:'vCSTATUSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cstatusdsc',fld:'vCSTATUSDSC',pic:'',nv:''},{av:'AV8cstatususotabla',fld:'vCSTATUSUSOTABLA',pic:'',nv:''},{av:'AV9cstatusdesc',fld:'vCSTATUSDESC',pic:'',nv:''},{av:'AV10cstatususuario',fld:'vCSTATUSUSUARIO',pic:'',nv:''},{av:'AV11cstatusfecreg',fld:'vCSTATUSFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12cstatusfecultact',fld:'vCSTATUSFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
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
         AV7cstatusdsc = "";
         AV8cstatususotabla = "";
         AV9cstatusdesc = "";
         AV10cstatususuario = "";
         AV11cstatusfecreg = (DateTime)(DateTime.MinValue);
         AV12cstatusfecultact = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblstatusidfilter_Jsonclick = "";
         TempTags = "";
         lblLblstatusdscfilter_Jsonclick = "";
         lblLblstatususotablafilter_Jsonclick = "";
         lblLblstatusdescfilter_Jsonclick = "";
         lblLblstatususuariofilter_Jsonclick = "";
         lblLblstatusfecregfilter_Jsonclick = "";
         lblLblstatusfecultactfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A73statusdsc = "";
         A74statususotabla = "";
         A76statususuario = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cstatusdsc = "";
         lV8cstatususotabla = "";
         lV9cstatusdesc = "";
         lV10cstatususuario = "";
         A75statusdesc = "";
         A77statusfecreg = (DateTime)(DateTime.MinValue);
         A78statusfecultact = (DateTime)(DateTime.MinValue);
         H002A2_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         H002A2_n78statusfecultact = new bool[] {false} ;
         H002A2_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         H002A2_n77statusfecreg = new bool[] {false} ;
         H002A2_A75statusdesc = new String[] {""} ;
         H002A2_n75statusdesc = new bool[] {false} ;
         H002A2_A76statususuario = new String[] {""} ;
         H002A2_n76statususuario = new bool[] {false} ;
         H002A2_A74statususotabla = new String[] {""} ;
         H002A2_n74statususotabla = new bool[] {false} ;
         H002A2_A73statusdsc = new String[] {""} ;
         H002A2_n73statusdsc = new bool[] {false} ;
         H002A2_A1statusid = new int[1] ;
         H002A3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00l0__default(),
            new Object[][] {
                new Object[] {
               H002A2_A78statusfecultact, H002A2_n78statusfecultact, H002A2_A77statusfecreg, H002A2_n77statusfecreg, H002A2_A75statusdesc, H002A2_n75statusdesc, H002A2_A76statususuario, H002A2_n76statususuario, H002A2_A74statususotabla, H002A2_n74statususotabla,
               H002A2_A73statusdsc, H002A2_n73statusdsc, H002A2_A1statusid
               }
               , new Object[] {
               H002A3_AGRID1_nRecordCount
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
      private int AV6cstatusid ;
      private int AV13pstatusid ;
      private int edtavCstatusid_Enabled ;
      private int edtavCstatusid_Visible ;
      private int edtavCstatusdsc_Visible ;
      private int edtavCstatusdsc_Enabled ;
      private int edtavCstatususotabla_Visible ;
      private int edtavCstatususotabla_Enabled ;
      private int edtavCstatusdesc_Visible ;
      private int edtavCstatusdesc_Enabled ;
      private int edtavCstatususuario_Visible ;
      private int edtavCstatususuario_Enabled ;
      private int edtavCstatusfecreg_Enabled ;
      private int edtavCstatusfecultact_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A1statusid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divStatusidfiltercontainer_Class ;
      private String divStatusdscfiltercontainer_Class ;
      private String divStatususotablafiltercontainer_Class ;
      private String divStatusdescfiltercontainer_Class ;
      private String divStatususuariofiltercontainer_Class ;
      private String divStatusfecregfiltercontainer_Class ;
      private String divStatusfecultactfiltercontainer_Class ;
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
      private String divStatusidfiltercontainer_Internalname ;
      private String lblLblstatusidfilter_Internalname ;
      private String lblLblstatusidfilter_Jsonclick ;
      private String edtavCstatusid_Internalname ;
      private String TempTags ;
      private String edtavCstatusid_Jsonclick ;
      private String divStatusdscfiltercontainer_Internalname ;
      private String lblLblstatusdscfilter_Internalname ;
      private String lblLblstatusdscfilter_Jsonclick ;
      private String edtavCstatusdsc_Internalname ;
      private String edtavCstatusdsc_Jsonclick ;
      private String divStatususotablafiltercontainer_Internalname ;
      private String lblLblstatususotablafilter_Internalname ;
      private String lblLblstatususotablafilter_Jsonclick ;
      private String edtavCstatususotabla_Internalname ;
      private String edtavCstatususotabla_Jsonclick ;
      private String divStatusdescfiltercontainer_Internalname ;
      private String lblLblstatusdescfilter_Internalname ;
      private String lblLblstatusdescfilter_Jsonclick ;
      private String edtavCstatusdesc_Internalname ;
      private String edtavCstatusdesc_Jsonclick ;
      private String divStatususuariofiltercontainer_Internalname ;
      private String lblLblstatususuariofilter_Internalname ;
      private String lblLblstatususuariofilter_Jsonclick ;
      private String edtavCstatususuario_Internalname ;
      private String edtavCstatususuario_Jsonclick ;
      private String divStatusfecregfiltercontainer_Internalname ;
      private String lblLblstatusfecregfilter_Internalname ;
      private String lblLblstatusfecregfilter_Jsonclick ;
      private String edtavCstatusfecreg_Internalname ;
      private String edtavCstatusfecreg_Jsonclick ;
      private String divStatusfecultactfiltercontainer_Internalname ;
      private String lblLblstatusfecultactfilter_Internalname ;
      private String lblLblstatusfecultactfilter_Jsonclick ;
      private String edtavCstatusfecultact_Internalname ;
      private String edtavCstatusfecultact_Jsonclick ;
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
      private String edtstatusdsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtstatusid_Internalname ;
      private String edtstatusdsc_Internalname ;
      private String edtstatususotabla_Internalname ;
      private String edtstatususuario_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtstatusid_Jsonclick ;
      private String edtstatusdsc_Jsonclick ;
      private String edtstatususotabla_Jsonclick ;
      private String edtstatususuario_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV11cstatusfecreg ;
      private DateTime AV12cstatusfecultact ;
      private DateTime A77statusfecreg ;
      private DateTime A78statusfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n73statusdsc ;
      private bool n74statususotabla ;
      private bool n76statususuario ;
      private bool n78statusfecultact ;
      private bool n77statusfecreg ;
      private bool n75statusdesc ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cstatusdsc ;
      private String AV8cstatususotabla ;
      private String AV9cstatusdesc ;
      private String AV10cstatususuario ;
      private String A73statusdsc ;
      private String A74statususotabla ;
      private String A76statususuario ;
      private String AV17Linkselection_GXI ;
      private String lV7cstatusdsc ;
      private String lV8cstatususotabla ;
      private String lV9cstatusdesc ;
      private String lV10cstatususuario ;
      private String A75statusdesc ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H002A2_A78statusfecultact ;
      private bool[] H002A2_n78statusfecultact ;
      private DateTime[] H002A2_A77statusfecreg ;
      private bool[] H002A2_n77statusfecreg ;
      private String[] H002A2_A75statusdesc ;
      private bool[] H002A2_n75statusdesc ;
      private String[] H002A2_A76statususuario ;
      private bool[] H002A2_n76statususuario ;
      private String[] H002A2_A74statususotabla ;
      private bool[] H002A2_n74statususotabla ;
      private String[] H002A2_A73statusdsc ;
      private bool[] H002A2_n73statusdsc ;
      private int[] H002A2_A1statusid ;
      private long[] H002A3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pstatusid ;
      private GXWebForm Form ;
   }

   public class gx00l0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002A2( IGxContext context ,
                                             String AV7cstatusdsc ,
                                             String AV8cstatususotabla ,
                                             String AV9cstatusdesc ,
                                             String AV10cstatususuario ,
                                             DateTime AV11cstatusfecreg ,
                                             DateTime AV12cstatusfecultact ,
                                             String A73statusdsc ,
                                             String A74statususotabla ,
                                             String A75statusdesc ,
                                             String A76statususuario ,
                                             DateTime A77statusfecreg ,
                                             DateTime A78statusfecultact ,
                                             int AV6cstatusid )
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
         sSelectString = " statusfecultact, statusfecreg, statusdesc, statususuario, statususotabla, statusdsc, statusid";
         sFromString = " FROM public.status";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (statusid >= :AV6cstatusid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cstatusdsc)) )
         {
            sWhereString = sWhereString + " and (statusdsc like :lV7cstatusdsc)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cstatususotabla)) )
         {
            sWhereString = sWhereString + " and (statususotabla like :lV8cstatususotabla)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cstatusdesc)) )
         {
            sWhereString = sWhereString + " and (statusdesc like :lV9cstatusdesc)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cstatususuario)) )
         {
            sWhereString = sWhereString + " and (statususuario like :lV10cstatususuario)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11cstatusfecreg) )
         {
            sWhereString = sWhereString + " and (statusfecreg >= :AV11cstatusfecreg)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cstatusfecultact) )
         {
            sWhereString = sWhereString + " and (statusfecultact >= :AV12cstatusfecultact)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY statusid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H002A3( IGxContext context ,
                                             String AV7cstatusdsc ,
                                             String AV8cstatususotabla ,
                                             String AV9cstatusdesc ,
                                             String AV10cstatususuario ,
                                             DateTime AV11cstatusfecreg ,
                                             DateTime AV12cstatusfecultact ,
                                             String A73statusdsc ,
                                             String A74statususotabla ,
                                             String A75statusdesc ,
                                             String A76statususuario ,
                                             DateTime A77statusfecreg ,
                                             DateTime A78statusfecultact ,
                                             int AV6cstatusid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.status";
         scmdbuf = scmdbuf + " WHERE (statusid >= :AV6cstatusid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cstatusdsc)) )
         {
            sWhereString = sWhereString + " and (statusdsc like :lV7cstatusdsc)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cstatususotabla)) )
         {
            sWhereString = sWhereString + " and (statususotabla like :lV8cstatususotabla)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cstatusdesc)) )
         {
            sWhereString = sWhereString + " and (statusdesc like :lV9cstatusdesc)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cstatususuario)) )
         {
            sWhereString = sWhereString + " and (statususuario like :lV10cstatususuario)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11cstatusfecreg) )
         {
            sWhereString = sWhereString + " and (statusfecreg >= :AV11cstatusfecreg)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cstatusfecultact) )
         {
            sWhereString = sWhereString + " and (statusfecultact >= :AV12cstatusfecultact)";
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
                     return conditional_H002A2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H002A3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH002A2 ;
          prmH002A2 = new Object[] {
          new Object[] {"AV6cstatusid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cstatusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV8cstatususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV9cstatusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV10cstatususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV11cstatusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12cstatusfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH002A3 ;
          prmH002A3 = new Object[] {
          new Object[] {"AV6cstatusid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cstatusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV8cstatususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV9cstatusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV10cstatususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV11cstatusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12cstatusfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002A2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002A2,11,0,false,false )
             ,new CursorDef("H002A3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002A3,1,0,false,false )
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
                ((int[]) buf[12])[0] = rslt.getInt(7) ;
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
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[16]);
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
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[13]);
                }
                return;
       }
    }

 }

}
