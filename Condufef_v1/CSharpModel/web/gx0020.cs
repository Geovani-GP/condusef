/*
               File: Gx0020
        Description: Selection List parametros
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:40.52
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
   public class gx0020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pparametrosid )
      {
         this.AV13pparametrosid = 0 ;
         executePrivate();
         aP0_pparametrosid=this.AV13pparametrosid;
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
               AV6cparametrosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cparametrosid), 9, 0)));
               AV7cparametrosdsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cparametrosdsc", AV7cparametrosdsc);
               AV8cparametrosvalor = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cparametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cparametrosvalor), 18, 0)));
               AV9cparametroscadena = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cparametroscadena", AV9cparametroscadena);
               AV10cparametrosstatus = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cparametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cparametrosstatus), 18, 0)));
               AV11cparametrosuso = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cparametrosuso", AV11cparametrosuso);
               AV12cparametrosusuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cparametrosusuario", AV12cparametrosusuario);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
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
               AV13pparametrosid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pparametrosid), 9, 0)));
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
         PA1R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20223310194058");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV13pparametrosid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cparametrosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSDSC", AV7cparametrosdsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSVALOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cparametrosvalor), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSCADENA", AV9cparametroscadena);
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSSTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cparametrosstatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSUSO", AV11cparametrosuso);
         GxWebStd.gx_hidden_field( context, "GXH_vCPARAMETROSUSUARIO", AV12cparametrosusuario);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPARAMETROSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pparametrosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSIDFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSDSCFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosdscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSVALORFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosvalorfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSCADENAFILTERCONTAINER_Class", StringUtil.RTrim( divParametroscadenafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSSTATUSFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosstatusfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSUSOFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosusofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PARAMETROSUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divParametrosusuariofiltercontainer_Class));
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
            WE1R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1R2( ) ;
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
         return formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV13pparametrosid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List parametros" ;
      }

      protected void WB1R0( )
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
            GxWebStd.gx_div_start( context, divParametrosidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosidfilter_Internalname, "parametrosid", "", "", lblLblparametrosidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosid_Internalname, "parametrosid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cparametrosid), 9, 0, ",", "")), ((edtavCparametrosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cparametrosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cparametrosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosid_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosid_Visible, edtavCparametrosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametrosdscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosdscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosdscfilter_Internalname, "parametrosdsc", "", "", lblLblparametrosdscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosdsc_Internalname, "parametrosdsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosdsc_Internalname, AV7cparametrosdsc, StringUtil.RTrim( context.localUtil.Format( AV7cparametrosdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosdsc_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosdsc_Visible, edtavCparametrosdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametrosvalorfiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosvalorfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosvalorfilter_Internalname, "parametrosvalor", "", "", lblLblparametrosvalorfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosvalor_Internalname, "parametrosvalor", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosvalor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cparametrosvalor), 18, 0, ",", "")), ((edtavCparametrosvalor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cparametrosvalor), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cparametrosvalor), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosvalor_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosvalor_Visible, edtavCparametrosvalor_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametroscadenafiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametroscadenafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametroscadenafilter_Internalname, "parametroscadena", "", "", lblLblparametroscadenafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametroscadena_Internalname, "parametroscadena", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametroscadena_Internalname, AV9cparametroscadena, StringUtil.RTrim( context.localUtil.Format( AV9cparametroscadena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametroscadena_Jsonclick, 0, "Attribute", "", "", "", edtavCparametroscadena_Visible, edtavCparametroscadena_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametrosstatusfiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosstatusfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosstatusfilter_Internalname, "parametrosstatus", "", "", lblLblparametrosstatusfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosstatus_Internalname, "parametrosstatus", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosstatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cparametrosstatus), 18, 0, ",", "")), ((edtavCparametrosstatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cparametrosstatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cparametrosstatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosstatus_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosstatus_Visible, edtavCparametrosstatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametrosusofiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosusofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosusofilter_Internalname, "parametrosuso", "", "", lblLblparametrosusofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosuso_Internalname, "parametrosuso", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosuso_Internalname, AV11cparametrosuso, StringUtil.RTrim( context.localUtil.Format( AV11cparametrosuso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosuso_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosuso_Visible, edtavCparametrosuso_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divParametrosusuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divParametrosusuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblparametrosusuariofilter_Internalname, "parametrosusuario", "", "", lblLblparametrosusuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171r1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCparametrosusuario_Internalname, "parametrosusuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCparametrosusuario_Internalname, AV12cparametrosusuario, StringUtil.RTrim( context.localUtil.Format( AV12cparametrosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCparametrosusuario_Jsonclick, 0, "Attribute", "", "", "", edtavCparametrosusuario_Visible, edtavCparametrosusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0020.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181r1_client"+"'", TempTags, "", 2, "HLP_Gx0020.htm");
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
               context.SendWebValue( "parametrosid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "parametrosdsc") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A65parametrosdsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtparametrosdsc_Link));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0020.htm");
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

      protected void START1R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List parametros", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1R0( ) ;
      }

      protected void WS1R2( )
      {
         START1R2( ) ;
         EVT1R2( ) ;
      }

      protected void EVT1R2( )
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
                              A8parametrosid = (int)(context.localUtil.CToN( cgiGet( edtparametrosid_Internalname), ",", "."));
                              A65parametrosdsc = cgiGet( edtparametrosdsc_Internalname);
                              n65parametrosdsc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191R2 */
                                    E191R2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E201R2 */
                                    E201R2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cparametrosid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSID"), ",", ".") != Convert.ToDecimal( AV6cparametrosid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametrosdsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSDSC"), AV7cparametrosdsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametrosvalor Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSVALOR"), ",", ".") != Convert.ToDecimal( AV8cparametrosvalor )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametroscadena Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSCADENA"), AV9cparametroscadena) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametrosstatus Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSSTATUS"), ",", ".") != Convert.ToDecimal( AV10cparametrosstatus )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametrosuso Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSUSO"), AV11cparametrosuso) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cparametrosusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSUSUARIO"), AV12cparametrosusuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E211R2 */
                                          E211R2 ();
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

      protected void WE1R2( )
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

      protected void PA1R2( )
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
                                        int AV6cparametrosid ,
                                        String AV7cparametrosdsc ,
                                        long AV8cparametrosvalor ,
                                        String AV9cparametroscadena ,
                                        long AV10cparametrosstatus ,
                                        String AV11cparametrosuso ,
                                        String AV12cparametrosusuario )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1R2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A8parametrosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PARAMETROSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROSDSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A65parametrosdsc, ""))));
         GxWebStd.gx_hidden_field( context, "PARAMETROSDSC", A65parametrosdsc);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1R2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1R2( )
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
                                                 AV7cparametrosdsc ,
                                                 AV8cparametrosvalor ,
                                                 AV9cparametroscadena ,
                                                 AV10cparametrosstatus ,
                                                 AV11cparametrosuso ,
                                                 AV12cparametrosusuario ,
                                                 A65parametrosdsc ,
                                                 A66parametrosvalor ,
                                                 A67parametroscadena ,
                                                 A68parametrosstatus ,
                                                 A69parametrosuso ,
                                                 A70parametrosusuario ,
                                                 AV6cparametrosid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV7cparametrosdsc = StringUtil.Concat( StringUtil.RTrim( AV7cparametrosdsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cparametrosdsc", AV7cparametrosdsc);
            lV9cparametroscadena = StringUtil.Concat( StringUtil.RTrim( AV9cparametroscadena), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cparametroscadena", AV9cparametroscadena);
            lV11cparametrosuso = StringUtil.Concat( StringUtil.RTrim( AV11cparametrosuso), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cparametrosuso", AV11cparametrosuso);
            lV12cparametrosusuario = StringUtil.Concat( StringUtil.RTrim( AV12cparametrosusuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cparametrosusuario", AV12cparametrosusuario);
            /* Using cursor H001R2 */
            pr_default.execute(0, new Object[] {AV6cparametrosid, lV7cparametrosdsc, AV8cparametrosvalor, lV9cparametroscadena, AV10cparametrosstatus, lV11cparametrosuso, lV12cparametrosusuario, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A70parametrosusuario = H001R2_A70parametrosusuario[0];
               n70parametrosusuario = H001R2_n70parametrosusuario[0];
               A69parametrosuso = H001R2_A69parametrosuso[0];
               n69parametrosuso = H001R2_n69parametrosuso[0];
               A68parametrosstatus = H001R2_A68parametrosstatus[0];
               n68parametrosstatus = H001R2_n68parametrosstatus[0];
               A67parametroscadena = H001R2_A67parametroscadena[0];
               n67parametroscadena = H001R2_n67parametroscadena[0];
               A66parametrosvalor = H001R2_A66parametrosvalor[0];
               n66parametrosvalor = H001R2_n66parametrosvalor[0];
               A65parametrosdsc = H001R2_A65parametrosdsc[0];
               n65parametrosdsc = H001R2_n65parametrosdsc[0];
               A8parametrosid = H001R2_A8parametrosid[0];
               /* Execute user event: E201R2 */
               E201R2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1R0( ) ;
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
                                              AV7cparametrosdsc ,
                                              AV8cparametrosvalor ,
                                              AV9cparametroscadena ,
                                              AV10cparametrosstatus ,
                                              AV11cparametrosuso ,
                                              AV12cparametrosusuario ,
                                              A65parametrosdsc ,
                                              A66parametrosvalor ,
                                              A67parametroscadena ,
                                              A68parametrosstatus ,
                                              A69parametrosuso ,
                                              A70parametrosusuario ,
                                              AV6cparametrosid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV7cparametrosdsc = StringUtil.Concat( StringUtil.RTrim( AV7cparametrosdsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cparametrosdsc", AV7cparametrosdsc);
         lV9cparametroscadena = StringUtil.Concat( StringUtil.RTrim( AV9cparametroscadena), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cparametroscadena", AV9cparametroscadena);
         lV11cparametrosuso = StringUtil.Concat( StringUtil.RTrim( AV11cparametrosuso), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cparametrosuso", AV11cparametrosuso);
         lV12cparametrosusuario = StringUtil.Concat( StringUtil.RTrim( AV12cparametrosusuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cparametrosusuario", AV12cparametrosusuario);
         /* Using cursor H001R3 */
         pr_default.execute(1, new Object[] {AV6cparametrosid, lV7cparametrosdsc, AV8cparametrosvalor, lV9cparametroscadena, AV10cparametrosstatus, lV11cparametrosuso, lV12cparametrosusuario});
         GRID1_nRecordCount = H001R3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cparametrosid, AV7cparametrosdsc, AV8cparametrosvalor, AV9cparametroscadena, AV10cparametrosstatus, AV11cparametrosuso, AV12cparametrosusuario) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E191R2 */
         E191R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCparametrosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCparametrosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARAMETROSID");
               GX_FocusControl = edtavCparametrosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cparametrosid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cparametrosid), 9, 0)));
            }
            else
            {
               AV6cparametrosid = (int)(context.localUtil.CToN( cgiGet( edtavCparametrosid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cparametrosid), 9, 0)));
            }
            AV7cparametrosdsc = cgiGet( edtavCparametrosdsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cparametrosdsc", AV7cparametrosdsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCparametrosvalor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCparametrosvalor_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARAMETROSVALOR");
               GX_FocusControl = edtavCparametrosvalor_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cparametrosvalor = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cparametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cparametrosvalor), 18, 0)));
            }
            else
            {
               AV8cparametrosvalor = (long)(context.localUtil.CToN( cgiGet( edtavCparametrosvalor_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cparametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cparametrosvalor), 18, 0)));
            }
            AV9cparametroscadena = cgiGet( edtavCparametroscadena_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cparametroscadena", AV9cparametroscadena);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCparametrosstatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCparametrosstatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPARAMETROSSTATUS");
               GX_FocusControl = edtavCparametrosstatus_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cparametrosstatus = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cparametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cparametrosstatus), 18, 0)));
            }
            else
            {
               AV10cparametrosstatus = (long)(context.localUtil.CToN( cgiGet( edtavCparametrosstatus_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cparametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cparametrosstatus), 18, 0)));
            }
            AV11cparametrosuso = cgiGet( edtavCparametrosuso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cparametrosuso", AV11cparametrosuso);
            AV12cparametrosusuario = cgiGet( edtavCparametrosusuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cparametrosusuario", AV12cparametrosusuario);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSID"), ",", ".") != Convert.ToDecimal( AV6cparametrosid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSDSC"), AV7cparametrosdsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSVALOR"), ",", ".") != Convert.ToDecimal( AV8cparametrosvalor )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSCADENA"), AV9cparametroscadena) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPARAMETROSSTATUS"), ",", ".") != Convert.ToDecimal( AV10cparametrosstatus )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSUSO"), AV11cparametrosuso) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPARAMETROSUSUARIO"), AV12cparametrosusuario) != 0 )
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
         /* Execute user event: E191R2 */
         E191R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191R2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "parametros", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E201R2( )
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
         /* Execute user event: E211R2 */
         E211R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211R2( )
      {
         /* Enter Routine */
         AV13pparametrosid = A8parametrosid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pparametrosid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pparametrosid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pparametrosid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pparametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pparametrosid), 9, 0)));
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
         PA1R2( ) ;
         WS1R2( ) ;
         WE1R2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0185564");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20223310194140");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx0020.js", "?20223310194140");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtparametrosid_Internalname = "PARAMETROSID_"+sGXsfl_84_idx;
         edtparametrosdsc_Internalname = "PARAMETROSDSC_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtparametrosid_Internalname = "PARAMETROSID_"+sGXsfl_84_fel_idx;
         edtparametrosdsc_Internalname = "PARAMETROSDSC_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB1R0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtparametrosid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A8parametrosid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtparametrosid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtparametrosdsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosdsc_Internalname, "Link", edtparametrosdsc_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtparametrosdsc_Internalname,(String)A65parametrosdsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtparametrosdsc_Link,(String)"",(String)"",(String)"",(String)edtparametrosdsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A8parametrosid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROSDSC"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A65parametrosdsc, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblparametrosidfilter_Internalname = "LBLPARAMETROSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosid_Internalname = "vCPARAMETROSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosidfiltercontainer_Internalname = "PARAMETROSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametrosdscfilter_Internalname = "LBLPARAMETROSDSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosdsc_Internalname = "vCPARAMETROSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosdscfiltercontainer_Internalname = "PARAMETROSDSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametrosvalorfilter_Internalname = "LBLPARAMETROSVALORFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosvalor_Internalname = "vCPARAMETROSVALOR";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosvalorfiltercontainer_Internalname = "PARAMETROSVALORFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametroscadenafilter_Internalname = "LBLPARAMETROSCADENAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametroscadena_Internalname = "vCPARAMETROSCADENA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametroscadenafiltercontainer_Internalname = "PARAMETROSCADENAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametrosstatusfilter_Internalname = "LBLPARAMETROSSTATUSFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosstatus_Internalname = "vCPARAMETROSSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosstatusfiltercontainer_Internalname = "PARAMETROSSTATUSFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametrosusofilter_Internalname = "LBLPARAMETROSUSOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosuso_Internalname = "vCPARAMETROSUSO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosusofiltercontainer_Internalname = "PARAMETROSUSOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblparametrosusuariofilter_Internalname = "LBLPARAMETROSUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCparametrosusuario_Internalname = "vCPARAMETROSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divParametrosusuariofiltercontainer_Internalname = "PARAMETROSUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtparametrosid_Internalname = "PARAMETROSID";
         edtparametrosdsc_Internalname = "PARAMETROSDSC";
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
         edtparametrosdsc_Jsonclick = "";
         edtparametrosid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtparametrosdsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCparametrosusuario_Jsonclick = "";
         edtavCparametrosusuario_Enabled = 1;
         edtavCparametrosusuario_Visible = 1;
         edtavCparametrosuso_Jsonclick = "";
         edtavCparametrosuso_Enabled = 1;
         edtavCparametrosuso_Visible = 1;
         edtavCparametrosstatus_Jsonclick = "";
         edtavCparametrosstatus_Enabled = 1;
         edtavCparametrosstatus_Visible = 1;
         edtavCparametroscadena_Jsonclick = "";
         edtavCparametroscadena_Enabled = 1;
         edtavCparametroscadena_Visible = 1;
         edtavCparametrosvalor_Jsonclick = "";
         edtavCparametrosvalor_Enabled = 1;
         edtavCparametrosvalor_Visible = 1;
         edtavCparametrosdsc_Jsonclick = "";
         edtavCparametrosdsc_Enabled = 1;
         edtavCparametrosdsc_Visible = 1;
         edtavCparametrosid_Jsonclick = "";
         edtavCparametrosid_Enabled = 1;
         edtavCparametrosid_Visible = 1;
         divParametrosusuariofiltercontainer_Class = "AdvancedContainerItem";
         divParametrosusofiltercontainer_Class = "AdvancedContainerItem";
         divParametrosstatusfiltercontainer_Class = "AdvancedContainerItem";
         divParametroscadenafiltercontainer_Class = "AdvancedContainerItem";
         divParametrosvalorfiltercontainer_Class = "AdvancedContainerItem";
         divParametrosdscfiltercontainer_Class = "AdvancedContainerItem";
         divParametrosidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List parametros";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cparametrosid',fld:'vCPARAMETROSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cparametrosdsc',fld:'vCPARAMETROSDSC',pic:'',nv:''},{av:'AV8cparametrosvalor',fld:'vCPARAMETROSVALOR',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cparametroscadena',fld:'vCPARAMETROSCADENA',pic:'',nv:''},{av:'AV10cparametrosstatus',fld:'vCPARAMETROSSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cparametrosuso',fld:'vCPARAMETROSUSO',pic:'',nv:''},{av:'AV12cparametrosusuario',fld:'vCPARAMETROSUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181R1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPARAMETROSIDFILTER.CLICK","{handler:'E111R1',iparms:[{av:'divParametrosidfiltercontainer_Class',ctrl:'PARAMETROSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosidfiltercontainer_Class',ctrl:'PARAMETROSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosid_Visible',ctrl:'vCPARAMETROSID',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSDSCFILTER.CLICK","{handler:'E121R1',iparms:[{av:'divParametrosdscfiltercontainer_Class',ctrl:'PARAMETROSDSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosdscfiltercontainer_Class',ctrl:'PARAMETROSDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosdsc_Visible',ctrl:'vCPARAMETROSDSC',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSVALORFILTER.CLICK","{handler:'E131R1',iparms:[{av:'divParametrosvalorfiltercontainer_Class',ctrl:'PARAMETROSVALORFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosvalorfiltercontainer_Class',ctrl:'PARAMETROSVALORFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosvalor_Visible',ctrl:'vCPARAMETROSVALOR',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSCADENAFILTER.CLICK","{handler:'E141R1',iparms:[{av:'divParametroscadenafiltercontainer_Class',ctrl:'PARAMETROSCADENAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametroscadenafiltercontainer_Class',ctrl:'PARAMETROSCADENAFILTERCONTAINER',prop:'Class'},{av:'edtavCparametroscadena_Visible',ctrl:'vCPARAMETROSCADENA',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSSTATUSFILTER.CLICK","{handler:'E151R1',iparms:[{av:'divParametrosstatusfiltercontainer_Class',ctrl:'PARAMETROSSTATUSFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosstatusfiltercontainer_Class',ctrl:'PARAMETROSSTATUSFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosstatus_Visible',ctrl:'vCPARAMETROSSTATUS',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSUSOFILTER.CLICK","{handler:'E161R1',iparms:[{av:'divParametrosusofiltercontainer_Class',ctrl:'PARAMETROSUSOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosusofiltercontainer_Class',ctrl:'PARAMETROSUSOFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosuso_Visible',ctrl:'vCPARAMETROSUSO',prop:'Visible'}]}");
         setEventMetadata("LBLPARAMETROSUSUARIOFILTER.CLICK","{handler:'E171R1',iparms:[{av:'divParametrosusuariofiltercontainer_Class',ctrl:'PARAMETROSUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divParametrosusuariofiltercontainer_Class',ctrl:'PARAMETROSUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCparametrosusuario_Visible',ctrl:'vCPARAMETROSUSUARIO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E211R2',iparms:[{av:'A8parametrosid',fld:'PARAMETROSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pparametrosid',fld:'vPPARAMETROSID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cparametrosid',fld:'vCPARAMETROSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cparametrosdsc',fld:'vCPARAMETROSDSC',pic:'',nv:''},{av:'AV8cparametrosvalor',fld:'vCPARAMETROSVALOR',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cparametroscadena',fld:'vCPARAMETROSCADENA',pic:'',nv:''},{av:'AV10cparametrosstatus',fld:'vCPARAMETROSSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cparametrosuso',fld:'vCPARAMETROSUSO',pic:'',nv:''},{av:'AV12cparametrosusuario',fld:'vCPARAMETROSUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cparametrosid',fld:'vCPARAMETROSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cparametrosdsc',fld:'vCPARAMETROSDSC',pic:'',nv:''},{av:'AV8cparametrosvalor',fld:'vCPARAMETROSVALOR',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cparametroscadena',fld:'vCPARAMETROSCADENA',pic:'',nv:''},{av:'AV10cparametrosstatus',fld:'vCPARAMETROSSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cparametrosuso',fld:'vCPARAMETROSUSO',pic:'',nv:''},{av:'AV12cparametrosusuario',fld:'vCPARAMETROSUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cparametrosid',fld:'vCPARAMETROSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cparametrosdsc',fld:'vCPARAMETROSDSC',pic:'',nv:''},{av:'AV8cparametrosvalor',fld:'vCPARAMETROSVALOR',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cparametroscadena',fld:'vCPARAMETROSCADENA',pic:'',nv:''},{av:'AV10cparametrosstatus',fld:'vCPARAMETROSSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cparametrosuso',fld:'vCPARAMETROSUSO',pic:'',nv:''},{av:'AV12cparametrosusuario',fld:'vCPARAMETROSUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cparametrosid',fld:'vCPARAMETROSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cparametrosdsc',fld:'vCPARAMETROSDSC',pic:'',nv:''},{av:'AV8cparametrosvalor',fld:'vCPARAMETROSVALOR',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cparametroscadena',fld:'vCPARAMETROSCADENA',pic:'',nv:''},{av:'AV10cparametrosstatus',fld:'vCPARAMETROSSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cparametrosuso',fld:'vCPARAMETROSUSO',pic:'',nv:''},{av:'AV12cparametrosusuario',fld:'vCPARAMETROSUSUARIO',pic:'',nv:''}],oparms:[]}");
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
         AV7cparametrosdsc = "";
         AV9cparametroscadena = "";
         AV11cparametrosuso = "";
         AV12cparametrosusuario = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblparametrosidfilter_Jsonclick = "";
         TempTags = "";
         lblLblparametrosdscfilter_Jsonclick = "";
         lblLblparametrosvalorfilter_Jsonclick = "";
         lblLblparametroscadenafilter_Jsonclick = "";
         lblLblparametrosstatusfilter_Jsonclick = "";
         lblLblparametrosusofilter_Jsonclick = "";
         lblLblparametrosusuariofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A65parametrosdsc = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cparametrosdsc = "";
         lV9cparametroscadena = "";
         lV11cparametrosuso = "";
         lV12cparametrosusuario = "";
         A67parametroscadena = "";
         A69parametrosuso = "";
         A70parametrosusuario = "";
         H001R2_A70parametrosusuario = new String[] {""} ;
         H001R2_n70parametrosusuario = new bool[] {false} ;
         H001R2_A69parametrosuso = new String[] {""} ;
         H001R2_n69parametrosuso = new bool[] {false} ;
         H001R2_A68parametrosstatus = new long[1] ;
         H001R2_n68parametrosstatus = new bool[] {false} ;
         H001R2_A67parametroscadena = new String[] {""} ;
         H001R2_n67parametroscadena = new bool[] {false} ;
         H001R2_A66parametrosvalor = new long[1] ;
         H001R2_n66parametrosvalor = new bool[] {false} ;
         H001R2_A65parametrosdsc = new String[] {""} ;
         H001R2_n65parametrosdsc = new bool[] {false} ;
         H001R2_A8parametrosid = new int[1] ;
         H001R3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0020__default(),
            new Object[][] {
                new Object[] {
               H001R2_A70parametrosusuario, H001R2_n70parametrosusuario, H001R2_A69parametrosuso, H001R2_n69parametrosuso, H001R2_A68parametrosstatus, H001R2_n68parametrosstatus, H001R2_A67parametroscadena, H001R2_n67parametroscadena, H001R2_A66parametrosvalor, H001R2_n66parametrosvalor,
               H001R2_A65parametrosdsc, H001R2_n65parametrosdsc, H001R2_A8parametrosid
               }
               , new Object[] {
               H001R3_AGRID1_nRecordCount
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
      private int AV6cparametrosid ;
      private int AV13pparametrosid ;
      private int edtavCparametrosid_Enabled ;
      private int edtavCparametrosid_Visible ;
      private int edtavCparametrosdsc_Visible ;
      private int edtavCparametrosdsc_Enabled ;
      private int edtavCparametrosvalor_Enabled ;
      private int edtavCparametrosvalor_Visible ;
      private int edtavCparametroscadena_Visible ;
      private int edtavCparametroscadena_Enabled ;
      private int edtavCparametrosstatus_Enabled ;
      private int edtavCparametrosstatus_Visible ;
      private int edtavCparametrosuso_Visible ;
      private int edtavCparametrosuso_Enabled ;
      private int edtavCparametrosusuario_Visible ;
      private int edtavCparametrosusuario_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A8parametrosid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV8cparametrosvalor ;
      private long AV10cparametrosstatus ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long A66parametrosvalor ;
      private long A68parametrosstatus ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divParametrosidfiltercontainer_Class ;
      private String divParametrosdscfiltercontainer_Class ;
      private String divParametrosvalorfiltercontainer_Class ;
      private String divParametroscadenafiltercontainer_Class ;
      private String divParametrosstatusfiltercontainer_Class ;
      private String divParametrosusofiltercontainer_Class ;
      private String divParametrosusuariofiltercontainer_Class ;
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
      private String divParametrosidfiltercontainer_Internalname ;
      private String lblLblparametrosidfilter_Internalname ;
      private String lblLblparametrosidfilter_Jsonclick ;
      private String edtavCparametrosid_Internalname ;
      private String TempTags ;
      private String edtavCparametrosid_Jsonclick ;
      private String divParametrosdscfiltercontainer_Internalname ;
      private String lblLblparametrosdscfilter_Internalname ;
      private String lblLblparametrosdscfilter_Jsonclick ;
      private String edtavCparametrosdsc_Internalname ;
      private String edtavCparametrosdsc_Jsonclick ;
      private String divParametrosvalorfiltercontainer_Internalname ;
      private String lblLblparametrosvalorfilter_Internalname ;
      private String lblLblparametrosvalorfilter_Jsonclick ;
      private String edtavCparametrosvalor_Internalname ;
      private String edtavCparametrosvalor_Jsonclick ;
      private String divParametroscadenafiltercontainer_Internalname ;
      private String lblLblparametroscadenafilter_Internalname ;
      private String lblLblparametroscadenafilter_Jsonclick ;
      private String edtavCparametroscadena_Internalname ;
      private String edtavCparametroscadena_Jsonclick ;
      private String divParametrosstatusfiltercontainer_Internalname ;
      private String lblLblparametrosstatusfilter_Internalname ;
      private String lblLblparametrosstatusfilter_Jsonclick ;
      private String edtavCparametrosstatus_Internalname ;
      private String edtavCparametrosstatus_Jsonclick ;
      private String divParametrosusofiltercontainer_Internalname ;
      private String lblLblparametrosusofilter_Internalname ;
      private String lblLblparametrosusofilter_Jsonclick ;
      private String edtavCparametrosuso_Internalname ;
      private String edtavCparametrosuso_Jsonclick ;
      private String divParametrosusuariofiltercontainer_Internalname ;
      private String lblLblparametrosusuariofilter_Internalname ;
      private String lblLblparametrosusuariofilter_Jsonclick ;
      private String edtavCparametrosusuario_Internalname ;
      private String edtavCparametrosusuario_Jsonclick ;
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
      private String edtparametrosdsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtparametrosid_Internalname ;
      private String edtparametrosdsc_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtparametrosid_Jsonclick ;
      private String edtparametrosdsc_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n65parametrosdsc ;
      private bool n70parametrosusuario ;
      private bool n69parametrosuso ;
      private bool n68parametrosstatus ;
      private bool n67parametroscadena ;
      private bool n66parametrosvalor ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cparametrosdsc ;
      private String AV9cparametroscadena ;
      private String AV11cparametrosuso ;
      private String AV12cparametrosusuario ;
      private String A65parametrosdsc ;
      private String AV17Linkselection_GXI ;
      private String lV7cparametrosdsc ;
      private String lV9cparametroscadena ;
      private String lV11cparametrosuso ;
      private String lV12cparametrosusuario ;
      private String A67parametroscadena ;
      private String A69parametrosuso ;
      private String A70parametrosusuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001R2_A70parametrosusuario ;
      private bool[] H001R2_n70parametrosusuario ;
      private String[] H001R2_A69parametrosuso ;
      private bool[] H001R2_n69parametrosuso ;
      private long[] H001R2_A68parametrosstatus ;
      private bool[] H001R2_n68parametrosstatus ;
      private String[] H001R2_A67parametroscadena ;
      private bool[] H001R2_n67parametroscadena ;
      private long[] H001R2_A66parametrosvalor ;
      private bool[] H001R2_n66parametrosvalor ;
      private String[] H001R2_A65parametrosdsc ;
      private bool[] H001R2_n65parametrosdsc ;
      private int[] H001R2_A8parametrosid ;
      private long[] H001R3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pparametrosid ;
      private GXWebForm Form ;
   }

   public class gx0020__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001R2( IGxContext context ,
                                             String AV7cparametrosdsc ,
                                             long AV8cparametrosvalor ,
                                             String AV9cparametroscadena ,
                                             long AV10cparametrosstatus ,
                                             String AV11cparametrosuso ,
                                             String AV12cparametrosusuario ,
                                             String A65parametrosdsc ,
                                             long A66parametrosvalor ,
                                             String A67parametroscadena ,
                                             long A68parametrosstatus ,
                                             String A69parametrosuso ,
                                             String A70parametrosusuario ,
                                             int AV6cparametrosid )
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
         sSelectString = " parametrosusuario, parametrosuso, parametrosstatus, parametroscadena, parametrosvalor, parametrosdsc, parametrosid";
         sFromString = " FROM public.parametros";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (parametrosid >= :AV6cparametrosid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cparametrosdsc)) )
         {
            sWhereString = sWhereString + " and (parametrosdsc like :lV7cparametrosdsc)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cparametrosvalor) )
         {
            sWhereString = sWhereString + " and (parametrosvalor >= :AV8cparametrosvalor)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cparametroscadena)) )
         {
            sWhereString = sWhereString + " and (parametroscadena like :lV9cparametroscadena)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cparametrosstatus) )
         {
            sWhereString = sWhereString + " and (parametrosstatus >= :AV10cparametrosstatus)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cparametrosuso)) )
         {
            sWhereString = sWhereString + " and (parametrosuso like :lV11cparametrosuso)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cparametrosusuario)) )
         {
            sWhereString = sWhereString + " and (parametrosusuario like :lV12cparametrosusuario)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY parametrosid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001R3( IGxContext context ,
                                             String AV7cparametrosdsc ,
                                             long AV8cparametrosvalor ,
                                             String AV9cparametroscadena ,
                                             long AV10cparametrosstatus ,
                                             String AV11cparametrosuso ,
                                             String AV12cparametrosusuario ,
                                             String A65parametrosdsc ,
                                             long A66parametrosvalor ,
                                             String A67parametroscadena ,
                                             long A68parametrosstatus ,
                                             String A69parametrosuso ,
                                             String A70parametrosusuario ,
                                             int AV6cparametrosid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.parametros";
         scmdbuf = scmdbuf + " WHERE (parametrosid >= :AV6cparametrosid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cparametrosdsc)) )
         {
            sWhereString = sWhereString + " and (parametrosdsc like :lV7cparametrosdsc)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cparametrosvalor) )
         {
            sWhereString = sWhereString + " and (parametrosvalor >= :AV8cparametrosvalor)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cparametroscadena)) )
         {
            sWhereString = sWhereString + " and (parametroscadena like :lV9cparametroscadena)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cparametrosstatus) )
         {
            sWhereString = sWhereString + " and (parametrosstatus >= :AV10cparametrosstatus)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cparametrosuso)) )
         {
            sWhereString = sWhereString + " and (parametrosuso like :lV11cparametrosuso)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cparametrosusuario)) )
         {
            sWhereString = sWhereString + " and (parametrosusuario like :lV12cparametrosusuario)";
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
                     return conditional_H001R2(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H001R3(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH001R2 ;
          prmH001R2 = new Object[] {
          new Object[] {"AV6cparametrosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cparametrosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV8cparametrosvalor",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV9cparametroscadena",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"AV10cparametrosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV11cparametrosuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cparametrosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH001R3 ;
          prmH001R3 = new Object[] {
          new Object[] {"AV6cparametrosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cparametrosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV8cparametrosvalor",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV9cparametroscadena",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"AV10cparametrosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV11cparametrosuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cparametrosusuario",NpgsqlDbType.Varchar,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R2,11,0,false,false )
             ,new CursorDef("H001R3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R3,1,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
