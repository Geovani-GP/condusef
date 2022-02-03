/*
               File: Gx00D0
        Description: Selection List articulosmov
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:26.76
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
   public class gx00d0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00d0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00d0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_particulosmovid ,
                           out int aP1_particulosmovproductoid ,
                           out String aP2_particulosmovcambsid ,
                           out long aP3_particulosmovarticuloid )
      {
         this.AV13particulosmovid = 0 ;
         this.AV14particulosmovproductoid = 0 ;
         this.AV15particulosmovcambsid = "" ;
         this.AV16particulosmovarticuloid = 0 ;
         executePrivate();
         aP0_particulosmovid=this.AV13particulosmovid;
         aP1_particulosmovproductoid=this.AV14particulosmovproductoid;
         aP2_particulosmovcambsid=this.AV15particulosmovcambsid;
         aP3_particulosmovarticuloid=this.AV16particulosmovarticuloid;
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
               AV6carticulosmovid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6carticulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6carticulosmovid), 9, 0)));
               AV7carticulosmovproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosmovproductoid), 9, 0)));
               AV8carticulosmovcambsid = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticulosmovcambsid", AV8carticulosmovcambsid);
               AV9carticulosmovarticuloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9carticulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9carticulosmovarticuloid), 18, 0)));
               AV10carticulosmovdepositario = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosmovdepositario), 18, 0)));
               AV11carticulosmovfechamov = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11carticulosmovfechamov", context.localUtil.TToC( AV11carticulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
               AV12carticulosmovstatus = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12carticulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12carticulosmovstatus), 18, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
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
               AV13particulosmovid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13particulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13particulosmovid), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14particulosmovproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosmovproductoid), 9, 0)));
                  AV15particulosmovcambsid = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particulosmovcambsid", AV15particulosmovcambsid);
                  AV16particulosmovarticuloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16particulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16particulosmovarticuloid), 18, 0)));
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
         PA262( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START262( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20222213432683");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00d0.aspx") + "?" + UrlEncode("" +AV13particulosmovid) + "," + UrlEncode("" +AV14particulosmovproductoid) + "," + UrlEncode(StringUtil.RTrim(AV15particulosmovcambsid)) + "," + UrlEncode("" +AV16particulosmovarticuloid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6carticulosmovid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7carticulosmovproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVCAMBSID", AV8carticulosmovcambsid);
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9carticulosmovarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVDEPOSITARIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10carticulosmovdepositario), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVFECHAMOV", context.localUtil.TToC( AV11carticulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSMOVSTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12carticulosmovstatus), 18, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPARTICULOSMOVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13particulosmovid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPARTICULOSMOVPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14particulosmovproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPARTICULOSMOVCAMBSID", AV15particulosmovcambsid);
         GxWebStd.gx_hidden_field( context, "vPARTICULOSMOVARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16particulosmovarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVPRODUCTOIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovproductoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVCAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovcambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVARTICULOIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovarticuloidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVDEPOSITARIOFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovdepositariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVFECHAMOVFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovfechamovfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVSTATUSFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosmovstatusfiltercontainer_Class));
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
            WE262( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT262( ) ;
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
         return formatLink("gx00d0.aspx") + "?" + UrlEncode("" +AV13particulosmovid) + "," + UrlEncode("" +AV14particulosmovproductoid) + "," + UrlEncode(StringUtil.RTrim(AV15particulosmovcambsid)) + "," + UrlEncode("" +AV16particulosmovarticuloid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00D0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List articulosmov" ;
      }

      protected void WB260( )
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
            GxWebStd.gx_div_start( context, divArticulosmovidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovidfilter_Internalname, "articulosmovid", "", "", lblLblarticulosmovidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovid_Internalname, "articulosmovid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6carticulosmovid), 9, 0, ",", "")), ((edtavCarticulosmovid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6carticulosmovid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6carticulosmovid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovid_Visible, edtavCarticulosmovid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovproductoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovproductoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovproductoidfilter_Internalname, "articulosmovproductoid", "", "", lblLblarticulosmovproductoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7carticulosmovproductoid), 9, 0, ",", "")), ((edtavCarticulosmovproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7carticulosmovproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7carticulosmovproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovproductoid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovproductoid_Visible, edtavCarticulosmovproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovcambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovcambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovcambsidfilter_Internalname, "articulosmovcambsid", "", "", lblLblarticulosmovcambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovcambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovcambsid_Internalname, AV8carticulosmovcambsid, StringUtil.RTrim( context.localUtil.Format( AV8carticulosmovcambsid, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovcambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovcambsid_Visible, edtavCarticulosmovcambsid_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovarticuloidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovarticuloidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovarticuloidfilter_Internalname, "articulosmovarticuloid", "", "", lblLblarticulosmovarticuloidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovarticuloid_Internalname, "articulosmovarticuloid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovarticuloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9carticulosmovarticuloid), 18, 0, ",", "")), ((edtavCarticulosmovarticuloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9carticulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9carticulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovarticuloid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovarticuloid_Visible, edtavCarticulosmovarticuloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovdepositariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovdepositariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovdepositariofilter_Internalname, "articulosmovdepositario", "", "", lblLblarticulosmovdepositariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovdepositario_Internalname, "articulosmovdepositario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovdepositario_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10carticulosmovdepositario), 18, 0, ",", "")), ((edtavCarticulosmovdepositario_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10carticulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10carticulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovdepositario_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovdepositario_Visible, edtavCarticulosmovdepositario_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovfechamovfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovfechamovfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovfechamovfilter_Internalname, "articulosmovfechamov", "", "", lblLblarticulosmovfechamovfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16261_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovfechamov_Internalname, "articulosmovfechamov", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCarticulosmovfechamov_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovfechamov_Internalname, context.localUtil.TToC( AV11carticulosmovfechamov, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV11carticulosmovfechamov, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovfechamov_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCarticulosmovfechamov_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosmovstatusfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosmovstatusfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosmovstatusfilter_Internalname, "articulosmovstatus", "", "", lblLblarticulosmovstatusfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17261_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00D0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosmovstatus_Internalname, "articulosmovstatus", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosmovstatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12carticulosmovstatus), 18, 0, ",", "")), ((edtavCarticulosmovstatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12carticulosmovstatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12carticulosmovstatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosmovstatus_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosmovstatus_Visible, edtavCarticulosmovstatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00D0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18261_client"+"'", TempTags, "", 2, "HLP_Gx00D0.htm");
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
               context.SendWebValue( "articulosmovid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productoid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "articulosmovarticuloid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "articulosmovdepositario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "articulosmovfechamov") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A5articulosmovcambsid);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39articulosmovdepositario), 18, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtarticulosmovdepositario_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00D0.htm");
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

      protected void START262( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List articulosmov", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP260( ) ;
      }

      protected void WS262( )
      {
         START262( ) ;
         EVT262( ) ;
      }

      protected void EVT262( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV20Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A3articulosmovid = (int)(context.localUtil.CToN( cgiGet( edtarticulosmovid_Internalname), ",", "."));
                              A4articulosmovproductoid = (int)(context.localUtil.CToN( cgiGet( edtarticulosmovproductoid_Internalname), ",", "."));
                              A5articulosmovcambsid = cgiGet( edtarticulosmovcambsid_Internalname);
                              A6articulosmovarticuloid = (long)(context.localUtil.CToN( cgiGet( edtarticulosmovarticuloid_Internalname), ",", "."));
                              A39articulosmovdepositario = (long)(context.localUtil.CToN( cgiGet( edtarticulosmovdepositario_Internalname), ",", "."));
                              n39articulosmovdepositario = false;
                              A40articulosmovfechamov = context.localUtil.CToT( cgiGet( edtarticulosmovfechamov_Internalname), 0);
                              n40articulosmovfechamov = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19262 */
                                    E19262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20262 */
                                    E20262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Carticulosmovid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVID"), ",", ".") != Convert.ToDecimal( AV6carticulosmovid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovproductoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV7carticulosmovproductoid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovcambsid Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOSMOVCAMBSID"), AV8carticulosmovcambsid) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovarticuloid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVARTICULOID"), ",", ".") != Convert.ToDecimal( AV9carticulosmovarticuloid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovdepositario Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVDEPOSITARIO"), ",", ".") != Convert.ToDecimal( AV10carticulosmovdepositario )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovfechamov Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCARTICULOSMOVFECHAMOV"), 0) != AV11carticulosmovfechamov )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosmovstatus Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVSTATUS"), ",", ".") != Convert.ToDecimal( AV12carticulosmovstatus )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21262 */
                                          E21262 ();
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

      protected void WE262( )
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

      protected void PA262( )
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
                                        int AV6carticulosmovid ,
                                        int AV7carticulosmovproductoid ,
                                        String AV8carticulosmovcambsid ,
                                        long AV9carticulosmovarticuloid ,
                                        long AV10carticulosmovdepositario ,
                                        DateTime AV11carticulosmovfechamov ,
                                        long AV12carticulosmovstatus )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF262( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A3articulosmovid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVPRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A4articulosmovproductoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVCAMBSID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A5articulosmovcambsid, ""))));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVCAMBSID", A5articulosmovcambsid);
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVARTICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A6articulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVDEPOSITARIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A39articulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVDEPOSITARIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39articulosmovdepositario), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVFECHAMOV", GetSecureSignedToken( "", context.localUtil.Format( A40articulosmovfechamov, "99/99/9999 99:99:99")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSMOVFECHAMOV", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF262( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF262( )
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
                                                 AV10carticulosmovdepositario ,
                                                 AV11carticulosmovfechamov ,
                                                 AV12carticulosmovstatus ,
                                                 A39articulosmovdepositario ,
                                                 A40articulosmovfechamov ,
                                                 A41articulosmovstatus ,
                                                 A5articulosmovcambsid ,
                                                 AV8carticulosmovcambsid ,
                                                 A6articulosmovarticuloid ,
                                                 AV9carticulosmovarticuloid ,
                                                 AV6carticulosmovid ,
                                                 AV7carticulosmovproductoid },
                                                 new int[] {
                                                 TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.INT
                                                 }
            });
            lV8carticulosmovcambsid = StringUtil.Concat( StringUtil.RTrim( AV8carticulosmovcambsid), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticulosmovcambsid", AV8carticulosmovcambsid);
            /* Using cursor H00262 */
            pr_default.execute(0, new Object[] {AV6carticulosmovid, AV7carticulosmovproductoid, lV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A41articulosmovstatus = H00262_A41articulosmovstatus[0];
               n41articulosmovstatus = H00262_n41articulosmovstatus[0];
               A40articulosmovfechamov = H00262_A40articulosmovfechamov[0];
               n40articulosmovfechamov = H00262_n40articulosmovfechamov[0];
               A39articulosmovdepositario = H00262_A39articulosmovdepositario[0];
               n39articulosmovdepositario = H00262_n39articulosmovdepositario[0];
               A6articulosmovarticuloid = H00262_A6articulosmovarticuloid[0];
               A5articulosmovcambsid = H00262_A5articulosmovcambsid[0];
               A4articulosmovproductoid = H00262_A4articulosmovproductoid[0];
               A3articulosmovid = H00262_A3articulosmovid[0];
               /* Execute user event: E20262 */
               E20262 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB260( ) ;
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
                                              AV10carticulosmovdepositario ,
                                              AV11carticulosmovfechamov ,
                                              AV12carticulosmovstatus ,
                                              A39articulosmovdepositario ,
                                              A40articulosmovfechamov ,
                                              A41articulosmovstatus ,
                                              A5articulosmovcambsid ,
                                              AV8carticulosmovcambsid ,
                                              A6articulosmovarticuloid ,
                                              AV9carticulosmovarticuloid ,
                                              AV6carticulosmovid ,
                                              AV7carticulosmovproductoid },
                                              new int[] {
                                              TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         lV8carticulosmovcambsid = StringUtil.Concat( StringUtil.RTrim( AV8carticulosmovcambsid), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticulosmovcambsid", AV8carticulosmovcambsid);
         /* Using cursor H00263 */
         pr_default.execute(1, new Object[] {AV6carticulosmovid, AV7carticulosmovproductoid, lV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus});
         GRID1_nRecordCount = H00263_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6carticulosmovid, AV7carticulosmovproductoid, AV8carticulosmovcambsid, AV9carticulosmovarticuloid, AV10carticulosmovdepositario, AV11carticulosmovfechamov, AV12carticulosmovstatus) ;
         }
         return (int)(0) ;
      }

      protected void STRUP260( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19262 */
         E19262 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSMOVID");
               GX_FocusControl = edtavCarticulosmovid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6carticulosmovid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6carticulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6carticulosmovid), 9, 0)));
            }
            else
            {
               AV6carticulosmovid = (int)(context.localUtil.CToN( cgiGet( edtavCarticulosmovid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6carticulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6carticulosmovid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSMOVPRODUCTOID");
               GX_FocusControl = edtavCarticulosmovproductoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7carticulosmovproductoid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosmovproductoid), 9, 0)));
            }
            else
            {
               AV7carticulosmovproductoid = (int)(context.localUtil.CToN( cgiGet( edtavCarticulosmovproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosmovproductoid), 9, 0)));
            }
            AV8carticulosmovcambsid = cgiGet( edtavCarticulosmovcambsid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticulosmovcambsid", AV8carticulosmovcambsid);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovarticuloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovarticuloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSMOVARTICULOID");
               GX_FocusControl = edtavCarticulosmovarticuloid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9carticulosmovarticuloid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9carticulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9carticulosmovarticuloid), 18, 0)));
            }
            else
            {
               AV9carticulosmovarticuloid = (long)(context.localUtil.CToN( cgiGet( edtavCarticulosmovarticuloid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9carticulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9carticulosmovarticuloid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovdepositario_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovdepositario_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSMOVDEPOSITARIO");
               GX_FocusControl = edtavCarticulosmovdepositario_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10carticulosmovdepositario = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosmovdepositario), 18, 0)));
            }
            else
            {
               AV10carticulosmovdepositario = (long)(context.localUtil.CToN( cgiGet( edtavCarticulosmovdepositario_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosmovdepositario), 18, 0)));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCarticulosmovfechamov_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosmovfechamov"}), 1, "vCARTICULOSMOVFECHAMOV");
               GX_FocusControl = edtavCarticulosmovfechamov_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11carticulosmovfechamov = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11carticulosmovfechamov", context.localUtil.TToC( AV11carticulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11carticulosmovfechamov = context.localUtil.CToT( cgiGet( edtavCarticulosmovfechamov_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11carticulosmovfechamov", context.localUtil.TToC( AV11carticulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovstatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosmovstatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSMOVSTATUS");
               GX_FocusControl = edtavCarticulosmovstatus_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12carticulosmovstatus = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12carticulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12carticulosmovstatus), 18, 0)));
            }
            else
            {
               AV12carticulosmovstatus = (long)(context.localUtil.CToN( cgiGet( edtavCarticulosmovstatus_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12carticulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12carticulosmovstatus), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVID"), ",", ".") != Convert.ToDecimal( AV6carticulosmovid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV7carticulosmovproductoid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCARTICULOSMOVCAMBSID"), AV8carticulosmovcambsid) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVARTICULOID"), ",", ".") != Convert.ToDecimal( AV9carticulosmovarticuloid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVDEPOSITARIO"), ",", ".") != Convert.ToDecimal( AV10carticulosmovdepositario )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCARTICULOSMOVFECHAMOV"), 0) != AV11carticulosmovfechamov )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSMOVSTATUS"), ",", ".") != Convert.ToDecimal( AV12carticulosmovstatus )) )
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
         /* Execute user event: E19262 */
         E19262 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19262( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "articulosmov", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV17ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20262( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV20Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E21262 */
         E21262 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21262( )
      {
         /* Enter Routine */
         AV13particulosmovid = A3articulosmovid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13particulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13particulosmovid), 9, 0)));
         AV14particulosmovproductoid = A4articulosmovproductoid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosmovproductoid), 9, 0)));
         AV15particulosmovcambsid = A5articulosmovcambsid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particulosmovcambsid", AV15particulosmovcambsid);
         AV16particulosmovarticuloid = A6articulosmovarticuloid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16particulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16particulosmovarticuloid), 18, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13particulosmovid,(int)AV14particulosmovproductoid,(String)AV15particulosmovcambsid,(long)AV16particulosmovarticuloid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13particulosmovid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13particulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13particulosmovid), 9, 0)));
         AV14particulosmovproductoid = Convert.ToInt32(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosmovproductoid), 9, 0)));
         AV15particulosmovcambsid = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particulosmovcambsid", AV15particulosmovcambsid);
         AV16particulosmovarticuloid = Convert.ToInt64(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16particulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16particulosmovarticuloid), 18, 0)));
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
         PA262( ) ;
         WS262( ) ;
         WE262( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?13205289");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1342847");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022221343280");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00d0.js", "?2022221343280");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtarticulosmovid_Internalname = "ARTICULOSMOVID_"+sGXsfl_84_idx;
         edtarticulosmovproductoid_Internalname = "ARTICULOSMOVPRODUCTOID_"+sGXsfl_84_idx;
         edtarticulosmovcambsid_Internalname = "ARTICULOSMOVCAMBSID_"+sGXsfl_84_idx;
         edtarticulosmovarticuloid_Internalname = "ARTICULOSMOVARTICULOID_"+sGXsfl_84_idx;
         edtarticulosmovdepositario_Internalname = "ARTICULOSMOVDEPOSITARIO_"+sGXsfl_84_idx;
         edtarticulosmovfechamov_Internalname = "ARTICULOSMOVFECHAMOV_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtarticulosmovid_Internalname = "ARTICULOSMOVID_"+sGXsfl_84_fel_idx;
         edtarticulosmovproductoid_Internalname = "ARTICULOSMOVPRODUCTOID_"+sGXsfl_84_fel_idx;
         edtarticulosmovcambsid_Internalname = "ARTICULOSMOVCAMBSID_"+sGXsfl_84_fel_idx;
         edtarticulosmovarticuloid_Internalname = "ARTICULOSMOVARTICULOID_"+sGXsfl_84_fel_idx;
         edtarticulosmovdepositario_Internalname = "ARTICULOSMOVDEPOSITARIO_"+sGXsfl_84_fel_idx;
         edtarticulosmovfechamov_Internalname = "ARTICULOSMOVFECHAMOV_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB260( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( A5articulosmovcambsid)+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV20Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV20Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A3articulosmovid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosmovid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A4articulosmovproductoid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosmovproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovcambsid_Internalname,(String)A5articulosmovcambsid,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosmovcambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovarticuloid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A6articulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosmovarticuloid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtarticulosmovdepositario_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( A5articulosmovcambsid)+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovdepositario_Internalname, "Link", edtarticulosmovdepositario_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovdepositario_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A39articulosmovdepositario), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A39articulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtarticulosmovdepositario_Link,(String)"",(String)"",(String)"",(String)edtarticulosmovdepositario_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosmovfechamov_Internalname,context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A40articulosmovfechamov, "99/99/9999 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosmovfechamov_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A3articulosmovid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVPRODUCTOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A4articulosmovproductoid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVCAMBSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A5articulosmovcambsid, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVARTICULOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A6articulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVDEPOSITARIO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A39articulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSMOVFECHAMOV"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( A40articulosmovfechamov, "99/99/9999 99:99:99")));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblarticulosmovidfilter_Internalname = "LBLARTICULOSMOVIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovid_Internalname = "vCARTICULOSMOVID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovidfiltercontainer_Internalname = "ARTICULOSMOVIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovproductoidfilter_Internalname = "LBLARTICULOSMOVPRODUCTOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovproductoid_Internalname = "vCARTICULOSMOVPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovproductoidfiltercontainer_Internalname = "ARTICULOSMOVPRODUCTOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovcambsidfilter_Internalname = "LBLARTICULOSMOVCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovcambsid_Internalname = "vCARTICULOSMOVCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovcambsidfiltercontainer_Internalname = "ARTICULOSMOVCAMBSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovarticuloidfilter_Internalname = "LBLARTICULOSMOVARTICULOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovarticuloid_Internalname = "vCARTICULOSMOVARTICULOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovarticuloidfiltercontainer_Internalname = "ARTICULOSMOVARTICULOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovdepositariofilter_Internalname = "LBLARTICULOSMOVDEPOSITARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovdepositario_Internalname = "vCARTICULOSMOVDEPOSITARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovdepositariofiltercontainer_Internalname = "ARTICULOSMOVDEPOSITARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovfechamovfilter_Internalname = "LBLARTICULOSMOVFECHAMOVFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovfechamov_Internalname = "vCARTICULOSMOVFECHAMOV";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovfechamovfiltercontainer_Internalname = "ARTICULOSMOVFECHAMOVFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosmovstatusfilter_Internalname = "LBLARTICULOSMOVSTATUSFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosmovstatus_Internalname = "vCARTICULOSMOVSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosmovstatusfiltercontainer_Internalname = "ARTICULOSMOVSTATUSFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtarticulosmovid_Internalname = "ARTICULOSMOVID";
         edtarticulosmovproductoid_Internalname = "ARTICULOSMOVPRODUCTOID";
         edtarticulosmovcambsid_Internalname = "ARTICULOSMOVCAMBSID";
         edtarticulosmovarticuloid_Internalname = "ARTICULOSMOVARTICULOID";
         edtarticulosmovdepositario_Internalname = "ARTICULOSMOVDEPOSITARIO";
         edtarticulosmovfechamov_Internalname = "ARTICULOSMOVFECHAMOV";
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
         edtarticulosmovfechamov_Jsonclick = "";
         edtarticulosmovdepositario_Jsonclick = "";
         edtarticulosmovarticuloid_Jsonclick = "";
         edtarticulosmovcambsid_Jsonclick = "";
         edtarticulosmovproductoid_Jsonclick = "";
         edtarticulosmovid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtarticulosmovdepositario_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCarticulosmovstatus_Jsonclick = "";
         edtavCarticulosmovstatus_Enabled = 1;
         edtavCarticulosmovstatus_Visible = 1;
         edtavCarticulosmovfechamov_Jsonclick = "";
         edtavCarticulosmovfechamov_Enabled = 1;
         edtavCarticulosmovdepositario_Jsonclick = "";
         edtavCarticulosmovdepositario_Enabled = 1;
         edtavCarticulosmovdepositario_Visible = 1;
         edtavCarticulosmovarticuloid_Jsonclick = "";
         edtavCarticulosmovarticuloid_Enabled = 1;
         edtavCarticulosmovarticuloid_Visible = 1;
         edtavCarticulosmovcambsid_Jsonclick = "";
         edtavCarticulosmovcambsid_Enabled = 1;
         edtavCarticulosmovcambsid_Visible = 1;
         edtavCarticulosmovproductoid_Jsonclick = "";
         edtavCarticulosmovproductoid_Enabled = 1;
         edtavCarticulosmovproductoid_Visible = 1;
         edtavCarticulosmovid_Jsonclick = "";
         edtavCarticulosmovid_Enabled = 1;
         edtavCarticulosmovid_Visible = 1;
         divArticulosmovstatusfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovfechamovfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovdepositariofiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovarticuloidfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovcambsidfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovproductoidfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosmovidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List articulosmov";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6carticulosmovid',fld:'vCARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosmovproductoid',fld:'vCARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticulosmovcambsid',fld:'vCARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV9carticulosmovarticuloid',fld:'vCARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosmovdepositario',fld:'vCARTICULOSMOVDEPOSITARIO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11carticulosmovfechamov',fld:'vCARTICULOSMOVFECHAMOV',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12carticulosmovstatus',fld:'vCARTICULOSMOVSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18261',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLARTICULOSMOVIDFILTER.CLICK","{handler:'E11261',iparms:[{av:'divArticulosmovidfiltercontainer_Class',ctrl:'ARTICULOSMOVIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovidfiltercontainer_Class',ctrl:'ARTICULOSMOVIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovid_Visible',ctrl:'vCARTICULOSMOVID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSMOVPRODUCTOIDFILTER.CLICK","{handler:'E12261',iparms:[{av:'divArticulosmovproductoidfiltercontainer_Class',ctrl:'ARTICULOSMOVPRODUCTOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovproductoidfiltercontainer_Class',ctrl:'ARTICULOSMOVPRODUCTOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovproductoid_Visible',ctrl:'vCARTICULOSMOVPRODUCTOID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSMOVCAMBSIDFILTER.CLICK","{handler:'E13261',iparms:[{av:'divArticulosmovcambsidfiltercontainer_Class',ctrl:'ARTICULOSMOVCAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovcambsidfiltercontainer_Class',ctrl:'ARTICULOSMOVCAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovcambsid_Visible',ctrl:'vCARTICULOSMOVCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSMOVARTICULOIDFILTER.CLICK","{handler:'E14261',iparms:[{av:'divArticulosmovarticuloidfiltercontainer_Class',ctrl:'ARTICULOSMOVARTICULOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovarticuloidfiltercontainer_Class',ctrl:'ARTICULOSMOVARTICULOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovarticuloid_Visible',ctrl:'vCARTICULOSMOVARTICULOID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSMOVDEPOSITARIOFILTER.CLICK","{handler:'E15261',iparms:[{av:'divArticulosmovdepositariofiltercontainer_Class',ctrl:'ARTICULOSMOVDEPOSITARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovdepositariofiltercontainer_Class',ctrl:'ARTICULOSMOVDEPOSITARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovdepositario_Visible',ctrl:'vCARTICULOSMOVDEPOSITARIO',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSMOVFECHAMOVFILTER.CLICK","{handler:'E16261',iparms:[{av:'divArticulosmovfechamovfiltercontainer_Class',ctrl:'ARTICULOSMOVFECHAMOVFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovfechamovfiltercontainer_Class',ctrl:'ARTICULOSMOVFECHAMOVFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLARTICULOSMOVSTATUSFILTER.CLICK","{handler:'E17261',iparms:[{av:'divArticulosmovstatusfiltercontainer_Class',ctrl:'ARTICULOSMOVSTATUSFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosmovstatusfiltercontainer_Class',ctrl:'ARTICULOSMOVSTATUSFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosmovstatus_Visible',ctrl:'vCARTICULOSMOVSTATUS',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21262',iparms:[{av:'A3articulosmovid',fld:'ARTICULOSMOVID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A4articulosmovproductoid',fld:'ARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A5articulosmovcambsid',fld:'ARTICULOSMOVCAMBSID',pic:'',hsh:true,nv:''},{av:'A6articulosmovarticuloid',fld:'ARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13particulosmovid',fld:'vPARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV14particulosmovproductoid',fld:'vPARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV15particulosmovcambsid',fld:'vPARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV16particulosmovarticuloid',fld:'vPARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6carticulosmovid',fld:'vCARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosmovproductoid',fld:'vCARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticulosmovcambsid',fld:'vCARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV9carticulosmovarticuloid',fld:'vCARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosmovdepositario',fld:'vCARTICULOSMOVDEPOSITARIO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11carticulosmovfechamov',fld:'vCARTICULOSMOVFECHAMOV',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12carticulosmovstatus',fld:'vCARTICULOSMOVSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6carticulosmovid',fld:'vCARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosmovproductoid',fld:'vCARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticulosmovcambsid',fld:'vCARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV9carticulosmovarticuloid',fld:'vCARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosmovdepositario',fld:'vCARTICULOSMOVDEPOSITARIO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11carticulosmovfechamov',fld:'vCARTICULOSMOVFECHAMOV',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12carticulosmovstatus',fld:'vCARTICULOSMOVSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6carticulosmovid',fld:'vCARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosmovproductoid',fld:'vCARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticulosmovcambsid',fld:'vCARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV9carticulosmovarticuloid',fld:'vCARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosmovdepositario',fld:'vCARTICULOSMOVDEPOSITARIO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11carticulosmovfechamov',fld:'vCARTICULOSMOVFECHAMOV',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12carticulosmovstatus',fld:'vCARTICULOSMOVSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6carticulosmovid',fld:'vCARTICULOSMOVID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosmovproductoid',fld:'vCARTICULOSMOVPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticulosmovcambsid',fld:'vCARTICULOSMOVCAMBSID',pic:'',nv:''},{av:'AV9carticulosmovarticuloid',fld:'vCARTICULOSMOVARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosmovdepositario',fld:'vCARTICULOSMOVDEPOSITARIO',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11carticulosmovfechamov',fld:'vCARTICULOSMOVFECHAMOV',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12carticulosmovstatus',fld:'vCARTICULOSMOVSTATUS',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
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
         AV8carticulosmovcambsid = "";
         AV11carticulosmovfechamov = (DateTime)(DateTime.MinValue);
         GXKey = "";
         AV15particulosmovcambsid = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblarticulosmovidfilter_Jsonclick = "";
         TempTags = "";
         lblLblarticulosmovproductoidfilter_Jsonclick = "";
         lblLblarticulosmovcambsidfilter_Jsonclick = "";
         lblLblarticulosmovarticuloidfilter_Jsonclick = "";
         lblLblarticulosmovdepositariofilter_Jsonclick = "";
         lblLblarticulosmovfechamovfilter_Jsonclick = "";
         lblLblarticulosmovstatusfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A5articulosmovcambsid = "";
         A40articulosmovfechamov = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV20Linkselection_GXI = "";
         scmdbuf = "";
         lV8carticulosmovcambsid = "";
         H00262_A41articulosmovstatus = new long[1] ;
         H00262_n41articulosmovstatus = new bool[] {false} ;
         H00262_A40articulosmovfechamov = new DateTime[] {DateTime.MinValue} ;
         H00262_n40articulosmovfechamov = new bool[] {false} ;
         H00262_A39articulosmovdepositario = new long[1] ;
         H00262_n39articulosmovdepositario = new bool[] {false} ;
         H00262_A6articulosmovarticuloid = new long[1] ;
         H00262_A5articulosmovcambsid = new String[] {""} ;
         H00262_A4articulosmovproductoid = new int[1] ;
         H00262_A3articulosmovid = new int[1] ;
         H00263_AGRID1_nRecordCount = new long[1] ;
         AV17ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00d0__default(),
            new Object[][] {
                new Object[] {
               H00262_A41articulosmovstatus, H00262_n41articulosmovstatus, H00262_A40articulosmovfechamov, H00262_n40articulosmovfechamov, H00262_A39articulosmovdepositario, H00262_n39articulosmovdepositario, H00262_A6articulosmovarticuloid, H00262_A5articulosmovcambsid, H00262_A4articulosmovproductoid, H00262_A3articulosmovid
               }
               , new Object[] {
               H00263_AGRID1_nRecordCount
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
      private int AV6carticulosmovid ;
      private int AV7carticulosmovproductoid ;
      private int AV13particulosmovid ;
      private int AV14particulosmovproductoid ;
      private int edtavCarticulosmovid_Enabled ;
      private int edtavCarticulosmovid_Visible ;
      private int edtavCarticulosmovproductoid_Enabled ;
      private int edtavCarticulosmovproductoid_Visible ;
      private int edtavCarticulosmovcambsid_Visible ;
      private int edtavCarticulosmovcambsid_Enabled ;
      private int edtavCarticulosmovarticuloid_Enabled ;
      private int edtavCarticulosmovarticuloid_Visible ;
      private int edtavCarticulosmovdepositario_Enabled ;
      private int edtavCarticulosmovdepositario_Visible ;
      private int edtavCarticulosmovfechamov_Enabled ;
      private int edtavCarticulosmovstatus_Enabled ;
      private int edtavCarticulosmovstatus_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A3articulosmovid ;
      private int A4articulosmovproductoid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV9carticulosmovarticuloid ;
      private long AV10carticulosmovdepositario ;
      private long AV12carticulosmovstatus ;
      private long AV16particulosmovarticuloid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A6articulosmovarticuloid ;
      private long A39articulosmovdepositario ;
      private long GRID1_nCurrentRecord ;
      private long A41articulosmovstatus ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divArticulosmovidfiltercontainer_Class ;
      private String divArticulosmovproductoidfiltercontainer_Class ;
      private String divArticulosmovcambsidfiltercontainer_Class ;
      private String divArticulosmovarticuloidfiltercontainer_Class ;
      private String divArticulosmovdepositariofiltercontainer_Class ;
      private String divArticulosmovfechamovfiltercontainer_Class ;
      private String divArticulosmovstatusfiltercontainer_Class ;
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
      private String divArticulosmovidfiltercontainer_Internalname ;
      private String lblLblarticulosmovidfilter_Internalname ;
      private String lblLblarticulosmovidfilter_Jsonclick ;
      private String edtavCarticulosmovid_Internalname ;
      private String TempTags ;
      private String edtavCarticulosmovid_Jsonclick ;
      private String divArticulosmovproductoidfiltercontainer_Internalname ;
      private String lblLblarticulosmovproductoidfilter_Internalname ;
      private String lblLblarticulosmovproductoidfilter_Jsonclick ;
      private String edtavCarticulosmovproductoid_Internalname ;
      private String edtavCarticulosmovproductoid_Jsonclick ;
      private String divArticulosmovcambsidfiltercontainer_Internalname ;
      private String lblLblarticulosmovcambsidfilter_Internalname ;
      private String lblLblarticulosmovcambsidfilter_Jsonclick ;
      private String edtavCarticulosmovcambsid_Internalname ;
      private String edtavCarticulosmovcambsid_Jsonclick ;
      private String divArticulosmovarticuloidfiltercontainer_Internalname ;
      private String lblLblarticulosmovarticuloidfilter_Internalname ;
      private String lblLblarticulosmovarticuloidfilter_Jsonclick ;
      private String edtavCarticulosmovarticuloid_Internalname ;
      private String edtavCarticulosmovarticuloid_Jsonclick ;
      private String divArticulosmovdepositariofiltercontainer_Internalname ;
      private String lblLblarticulosmovdepositariofilter_Internalname ;
      private String lblLblarticulosmovdepositariofilter_Jsonclick ;
      private String edtavCarticulosmovdepositario_Internalname ;
      private String edtavCarticulosmovdepositario_Jsonclick ;
      private String divArticulosmovfechamovfiltercontainer_Internalname ;
      private String lblLblarticulosmovfechamovfilter_Internalname ;
      private String lblLblarticulosmovfechamovfilter_Jsonclick ;
      private String edtavCarticulosmovfechamov_Internalname ;
      private String edtavCarticulosmovfechamov_Jsonclick ;
      private String divArticulosmovstatusfiltercontainer_Internalname ;
      private String lblLblarticulosmovstatusfilter_Internalname ;
      private String lblLblarticulosmovstatusfilter_Jsonclick ;
      private String edtavCarticulosmovstatus_Internalname ;
      private String edtavCarticulosmovstatus_Jsonclick ;
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
      private String edtarticulosmovdepositario_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtarticulosmovid_Internalname ;
      private String edtarticulosmovproductoid_Internalname ;
      private String edtarticulosmovcambsid_Internalname ;
      private String edtarticulosmovarticuloid_Internalname ;
      private String edtarticulosmovdepositario_Internalname ;
      private String edtarticulosmovfechamov_Internalname ;
      private String scmdbuf ;
      private String AV17ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtarticulosmovid_Jsonclick ;
      private String edtarticulosmovproductoid_Jsonclick ;
      private String edtarticulosmovcambsid_Jsonclick ;
      private String edtarticulosmovarticuloid_Jsonclick ;
      private String edtarticulosmovdepositario_Jsonclick ;
      private String edtarticulosmovfechamov_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV11carticulosmovfechamov ;
      private DateTime A40articulosmovfechamov ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n39articulosmovdepositario ;
      private bool n40articulosmovfechamov ;
      private bool n41articulosmovstatus ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8carticulosmovcambsid ;
      private String AV15particulosmovcambsid ;
      private String A5articulosmovcambsid ;
      private String AV20Linkselection_GXI ;
      private String lV8carticulosmovcambsid ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00262_A41articulosmovstatus ;
      private bool[] H00262_n41articulosmovstatus ;
      private DateTime[] H00262_A40articulosmovfechamov ;
      private bool[] H00262_n40articulosmovfechamov ;
      private long[] H00262_A39articulosmovdepositario ;
      private bool[] H00262_n39articulosmovdepositario ;
      private long[] H00262_A6articulosmovarticuloid ;
      private String[] H00262_A5articulosmovcambsid ;
      private int[] H00262_A4articulosmovproductoid ;
      private int[] H00262_A3articulosmovid ;
      private long[] H00263_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_particulosmovid ;
      private int aP1_particulosmovproductoid ;
      private String aP2_particulosmovcambsid ;
      private long aP3_particulosmovarticuloid ;
      private GXWebForm Form ;
   }

   public class gx00d0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00262( IGxContext context ,
                                             long AV10carticulosmovdepositario ,
                                             DateTime AV11carticulosmovfechamov ,
                                             long AV12carticulosmovstatus ,
                                             long A39articulosmovdepositario ,
                                             DateTime A40articulosmovfechamov ,
                                             long A41articulosmovstatus ,
                                             String A5articulosmovcambsid ,
                                             String AV8carticulosmovcambsid ,
                                             long A6articulosmovarticuloid ,
                                             long AV9carticulosmovarticuloid ,
                                             int AV6carticulosmovid ,
                                             int AV7carticulosmovproductoid )
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
         sSelectString = " articulosmovstatus, articulosmovfechamov, articulosmovdepositario, articulosmovarticuloid, cambsid, productoid, articulosmovid";
         sFromString = " FROM public.artículosmov";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (articulosmovid >= :AV6carticulosmovid and productoid >= :AV7carticulosmovproductoid)";
         sWhereString = sWhereString + " and (cambsid like :lV8carticulosmovcambsid)";
         sWhereString = sWhereString + " and (articulosmovarticuloid >= :AV9carticulosmovarticuloid)";
         if ( ! (0==AV10carticulosmovdepositario) )
         {
            sWhereString = sWhereString + " and (articulosmovdepositario >= :AV10carticulosmovdepositario)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11carticulosmovfechamov) )
         {
            sWhereString = sWhereString + " and (articulosmovfechamov >= :AV11carticulosmovfechamov)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV12carticulosmovstatus) )
         {
            sWhereString = sWhereString + " and (articulosmovstatus >= :AV12carticulosmovstatus)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY articulosmovid, productoid, cambsid, articulosmovarticuloid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00263( IGxContext context ,
                                             long AV10carticulosmovdepositario ,
                                             DateTime AV11carticulosmovfechamov ,
                                             long AV12carticulosmovstatus ,
                                             long A39articulosmovdepositario ,
                                             DateTime A40articulosmovfechamov ,
                                             long A41articulosmovstatus ,
                                             String A5articulosmovcambsid ,
                                             String AV8carticulosmovcambsid ,
                                             long A6articulosmovarticuloid ,
                                             long AV9carticulosmovarticuloid ,
                                             int AV6carticulosmovid ,
                                             int AV7carticulosmovproductoid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.artículosmov";
         scmdbuf = scmdbuf + " WHERE (articulosmovid >= :AV6carticulosmovid and productoid >= :AV7carticulosmovproductoid)";
         scmdbuf = scmdbuf + " and (cambsid like :lV8carticulosmovcambsid)";
         scmdbuf = scmdbuf + " and (articulosmovarticuloid >= :AV9carticulosmovarticuloid)";
         if ( ! (0==AV10carticulosmovdepositario) )
         {
            sWhereString = sWhereString + " and (articulosmovdepositario >= :AV10carticulosmovdepositario)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11carticulosmovfechamov) )
         {
            sWhereString = sWhereString + " and (articulosmovfechamov >= :AV11carticulosmovfechamov)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV12carticulosmovstatus) )
         {
            sWhereString = sWhereString + " and (articulosmovstatus >= :AV12carticulosmovstatus)";
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
                     return conditional_H00262(context, (long)dynConstraints[0] , (DateTime)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (DateTime)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (int)dynConstraints[10] , (int)dynConstraints[11] );
               case 1 :
                     return conditional_H00263(context, (long)dynConstraints[0] , (DateTime)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (DateTime)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (int)dynConstraints[10] , (int)dynConstraints[11] );
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
          Object[] prmH00262 ;
          prmH00262 = new Object[] {
          new Object[] {"AV6carticulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7carticulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8carticulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"AV9carticulosmovarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10carticulosmovdepositario",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11carticulosmovfechamov",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12carticulosmovstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00263 ;
          prmH00263 = new Object[] {
          new Object[] {"AV6carticulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7carticulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8carticulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"AV9carticulosmovarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10carticulosmovdepositario",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11carticulosmovfechamov",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12carticulosmovstatus",NpgsqlDbType.Real,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00262", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00262,11,0,false,false )
             ,new CursorDef("H00263", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00263,1,0,false,false )
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
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[8])[0] = rslt.getInt(6) ;
                ((int[]) buf[9])[0] = rslt.getInt(7) ;
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
                   stmt.SetParameter(sIdx, (String)parms[12]);
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
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
