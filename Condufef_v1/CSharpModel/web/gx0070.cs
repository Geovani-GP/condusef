/*
               File: Gx0070
        Description: Selection List estatusarticulo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:0:58.79
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
   public class gx0070 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0070( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0070( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pestatusarticuloid )
      {
         this.AV13pestatusarticuloid = 0 ;
         executePrivate();
         aP0_pestatusarticuloid=this.AV13pestatusarticuloid;
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
               AV6cestatusarticuloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cestatusarticuloid), 18, 0)));
               AV7cestatusarticulodsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cestatusarticulodsc", AV7cestatusarticulodsc);
               AV8cestatusarticulodescuso = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cestatusarticulodescuso", AV8cestatusarticulodescuso);
               AV9cestatusarticuloaplicamov = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cestatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cestatusarticuloaplicamov), 9, 0)));
               AV10cestatusarticulousotabla = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cestatusarticulousotabla", AV10cestatusarticulousotabla);
               AV11cestatusarticulousuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cestatusarticulousuario", AV11cestatusarticulousuario);
               AV12cestatusarticulofecreg = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cestatusarticulofecreg", context.localUtil.TToC( AV12cestatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
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
               AV13pestatusarticuloid = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pestatusarticuloid), 18, 0)));
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
         PA1W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1W2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022129005884");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV13pestatusarticuloid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cestatusarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULODSC", AV7cestatusarticulodsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULODESCUSO", AV8cestatusarticulodescuso);
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULOAPLICAMOV", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cestatusarticuloaplicamov), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULOUSOTABLA", AV10cestatusarticulousotabla);
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULOUSUARIO", AV11cestatusarticulousuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCESTATUSARTICULOFECREG", context.localUtil.TToC( AV12cestatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPESTATUSARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pestatusarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOIDFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticuloidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULODSCFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticulodscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULODESCUSOFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticulodescusofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOAPLICAMOVFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticuloaplicamovfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOUSOTABLAFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticulousotablafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticulousuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divEstatusarticulofecregfiltercontainer_Class));
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
            WE1W2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1W2( ) ;
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
         return formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV13pestatusarticuloid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0070" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List estatusarticulo" ;
      }

      protected void WB1W0( )
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
            GxWebStd.gx_div_start( context, divEstatusarticuloidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticuloidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticuloidfilter_Internalname, "estatusarticuloid", "", "", lblLblestatusarticuloidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticuloid_Internalname, "estatusarticuloid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticuloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cestatusarticuloid), 18, 0, ",", "")), ((edtavCestatusarticuloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cestatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cestatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticuloid_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticuloid_Visible, edtavCestatusarticuloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticulodscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticulodscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticulodscfilter_Internalname, "estatusarticulodsc", "", "", lblLblestatusarticulodscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticulodsc_Internalname, "estatusarticulodsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticulodsc_Internalname, AV7cestatusarticulodsc, StringUtil.RTrim( context.localUtil.Format( AV7cestatusarticulodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticulodsc_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticulodsc_Visible, edtavCestatusarticulodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticulodescusofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticulodescusofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticulodescusofilter_Internalname, "estatusarticulodescuso", "", "", lblLblestatusarticulodescusofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticulodescuso_Internalname, "estatusarticulodescuso", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticulodescuso_Internalname, AV8cestatusarticulodescuso, StringUtil.RTrim( context.localUtil.Format( AV8cestatusarticulodescuso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticulodescuso_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticulodescuso_Visible, edtavCestatusarticulodescuso_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticuloaplicamovfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticuloaplicamovfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticuloaplicamovfilter_Internalname, "estatusarticuloaplicamov", "", "", lblLblestatusarticuloaplicamovfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticuloaplicamov_Internalname, "estatusarticuloaplicamov", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticuloaplicamov_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cestatusarticuloaplicamov), 9, 0, ",", "")), ((edtavCestatusarticuloaplicamov_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cestatusarticuloaplicamov), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9cestatusarticuloaplicamov), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticuloaplicamov_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticuloaplicamov_Visible, edtavCestatusarticuloaplicamov_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticulousotablafiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticulousotablafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticulousotablafilter_Internalname, "estatusarticulousotabla", "", "", lblLblestatusarticulousotablafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticulousotabla_Internalname, "estatusarticulousotabla", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticulousotabla_Internalname, AV10cestatusarticulousotabla, StringUtil.RTrim( context.localUtil.Format( AV10cestatusarticulousotabla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticulousotabla_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticulousotabla_Visible, edtavCestatusarticulousotabla_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticulousuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticulousuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticulousuariofilter_Internalname, "estatusarticulousuario", "", "", lblLblestatusarticulousuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticulousuario_Internalname, "estatusarticulousuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticulousuario_Internalname, AV11cestatusarticulousuario, StringUtil.RTrim( context.localUtil.Format( AV11cestatusarticulousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticulousuario_Jsonclick, 0, "Attribute", "", "", "", edtavCestatusarticulousuario_Visible, edtavCestatusarticulousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divEstatusarticulofecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEstatusarticulofecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblestatusarticulofecregfilter_Internalname, "estatusarticulofecreg", "", "", lblLblestatusarticulofecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171w1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCestatusarticulofecreg_Internalname, "estatusarticulofecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCestatusarticulofecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCestatusarticulofecreg_Internalname, context.localUtil.TToC( AV12cestatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV12cestatusarticulofecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCestatusarticulofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCestatusarticulofecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181w1_client"+"'", TempTags, "", 2, "HLP_Gx0070.htm");
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
               context.SendWebValue( "estatusarticuloid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estatusarticulodsc") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A54estatusarticulodsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtestatusarticulodsc_Link));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0070.htm");
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

      protected void START1W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List estatusarticulo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1W0( ) ;
      }

      protected void WS1W2( )
      {
         START1W2( ) ;
         EVT1W2( ) ;
      }

      protected void EVT1W2( )
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
                              A12estatusarticuloid = (long)(context.localUtil.CToN( cgiGet( edtestatusarticuloid_Internalname), ",", "."));
                              A54estatusarticulodsc = cgiGet( edtestatusarticulodsc_Internalname);
                              n54estatusarticulodsc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191W2 */
                                    E191W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E201W2 */
                                    E201W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cestatusarticuloid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESTATUSARTICULOID"), ",", ".") != Convert.ToDecimal( AV6cestatusarticuloid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticulodsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULODSC"), AV7cestatusarticulodsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticulodescuso Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULODESCUSO"), AV8cestatusarticulodescuso) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticuloaplicamov Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESTATUSARTICULOAPLICAMOV"), ",", ".") != Convert.ToDecimal( AV9cestatusarticuloaplicamov )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticulousotabla Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULOUSOTABLA"), AV10cestatusarticulousotabla) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticulousuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULOUSUARIO"), AV11cestatusarticulousuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cestatusarticulofecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCESTATUSARTICULOFECREG"), 0) != AV12cestatusarticulofecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E211W2 */
                                          E211W2 ();
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

      protected void WE1W2( )
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

      protected void PA1W2( )
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
                                        long AV6cestatusarticuloid ,
                                        String AV7cestatusarticulodsc ,
                                        String AV8cestatusarticulodescuso ,
                                        int AV9cestatusarticuloaplicamov ,
                                        String AV10cestatusarticulousotabla ,
                                        String AV11cestatusarticulousuario ,
                                        DateTime AV12cestatusarticulofecreg )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1W2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A54estatusarticulodsc, ""))));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULODSC", A54estatusarticulodsc);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1W2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1W2( )
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
                                                 AV7cestatusarticulodsc ,
                                                 AV8cestatusarticulodescuso ,
                                                 AV9cestatusarticuloaplicamov ,
                                                 AV10cestatusarticulousotabla ,
                                                 AV11cestatusarticulousuario ,
                                                 AV12cestatusarticulofecreg ,
                                                 A54estatusarticulodsc ,
                                                 A55estatusarticulodescuso ,
                                                 A56estatusarticuloaplicamov ,
                                                 A57estatusarticulousotabla ,
                                                 A58estatusarticulousuario ,
                                                 A59estatusarticulofecreg ,
                                                 AV6cestatusarticuloid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            });
            lV7cestatusarticulodsc = StringUtil.Concat( StringUtil.RTrim( AV7cestatusarticulodsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cestatusarticulodsc", AV7cestatusarticulodsc);
            lV8cestatusarticulodescuso = StringUtil.Concat( StringUtil.RTrim( AV8cestatusarticulodescuso), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cestatusarticulodescuso", AV8cestatusarticulodescuso);
            lV10cestatusarticulousotabla = StringUtil.Concat( StringUtil.RTrim( AV10cestatusarticulousotabla), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cestatusarticulousotabla", AV10cestatusarticulousotabla);
            lV11cestatusarticulousuario = StringUtil.Concat( StringUtil.RTrim( AV11cestatusarticulousuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cestatusarticulousuario", AV11cestatusarticulousuario);
            /* Using cursor H001W2 */
            pr_default.execute(0, new Object[] {AV6cestatusarticuloid, lV7cestatusarticulodsc, lV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, lV10cestatusarticulousotabla, lV11cestatusarticulousuario, AV12cestatusarticulofecreg, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A59estatusarticulofecreg = H001W2_A59estatusarticulofecreg[0];
               n59estatusarticulofecreg = H001W2_n59estatusarticulofecreg[0];
               A58estatusarticulousuario = H001W2_A58estatusarticulousuario[0];
               n58estatusarticulousuario = H001W2_n58estatusarticulousuario[0];
               A57estatusarticulousotabla = H001W2_A57estatusarticulousotabla[0];
               n57estatusarticulousotabla = H001W2_n57estatusarticulousotabla[0];
               A56estatusarticuloaplicamov = H001W2_A56estatusarticuloaplicamov[0];
               n56estatusarticuloaplicamov = H001W2_n56estatusarticuloaplicamov[0];
               A55estatusarticulodescuso = H001W2_A55estatusarticulodescuso[0];
               n55estatusarticulodescuso = H001W2_n55estatusarticulodescuso[0];
               A54estatusarticulodsc = H001W2_A54estatusarticulodsc[0];
               n54estatusarticulodsc = H001W2_n54estatusarticulodsc[0];
               A12estatusarticuloid = H001W2_A12estatusarticuloid[0];
               /* Execute user event: E201W2 */
               E201W2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1W0( ) ;
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
                                              AV7cestatusarticulodsc ,
                                              AV8cestatusarticulodescuso ,
                                              AV9cestatusarticuloaplicamov ,
                                              AV10cestatusarticulousotabla ,
                                              AV11cestatusarticulousuario ,
                                              AV12cestatusarticulofecreg ,
                                              A54estatusarticulodsc ,
                                              A55estatusarticulodescuso ,
                                              A56estatusarticuloaplicamov ,
                                              A57estatusarticulousotabla ,
                                              A58estatusarticulousuario ,
                                              A59estatusarticulofecreg ,
                                              AV6cestatusarticuloid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         });
         lV7cestatusarticulodsc = StringUtil.Concat( StringUtil.RTrim( AV7cestatusarticulodsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cestatusarticulodsc", AV7cestatusarticulodsc);
         lV8cestatusarticulodescuso = StringUtil.Concat( StringUtil.RTrim( AV8cestatusarticulodescuso), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cestatusarticulodescuso", AV8cestatusarticulodescuso);
         lV10cestatusarticulousotabla = StringUtil.Concat( StringUtil.RTrim( AV10cestatusarticulousotabla), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cestatusarticulousotabla", AV10cestatusarticulousotabla);
         lV11cestatusarticulousuario = StringUtil.Concat( StringUtil.RTrim( AV11cestatusarticulousuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cestatusarticulousuario", AV11cestatusarticulousuario);
         /* Using cursor H001W3 */
         pr_default.execute(1, new Object[] {AV6cestatusarticuloid, lV7cestatusarticulodsc, lV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, lV10cestatusarticulousotabla, lV11cestatusarticulousuario, AV12cestatusarticulofecreg});
         GRID1_nRecordCount = H001W3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cestatusarticuloid, AV7cestatusarticulodsc, AV8cestatusarticulodescuso, AV9cestatusarticuloaplicamov, AV10cestatusarticulousotabla, AV11cestatusarticulousuario, AV12cestatusarticulofecreg) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E191W2 */
         E191W2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCestatusarticuloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCestatusarticuloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESTATUSARTICULOID");
               GX_FocusControl = edtavCestatusarticuloid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cestatusarticuloid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cestatusarticuloid), 18, 0)));
            }
            else
            {
               AV6cestatusarticuloid = (long)(context.localUtil.CToN( cgiGet( edtavCestatusarticuloid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cestatusarticuloid), 18, 0)));
            }
            AV7cestatusarticulodsc = cgiGet( edtavCestatusarticulodsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cestatusarticulodsc", AV7cestatusarticulodsc);
            AV8cestatusarticulodescuso = cgiGet( edtavCestatusarticulodescuso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cestatusarticulodescuso", AV8cestatusarticulodescuso);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCestatusarticuloaplicamov_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCestatusarticuloaplicamov_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESTATUSARTICULOAPLICAMOV");
               GX_FocusControl = edtavCestatusarticuloaplicamov_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cestatusarticuloaplicamov = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cestatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cestatusarticuloaplicamov), 9, 0)));
            }
            else
            {
               AV9cestatusarticuloaplicamov = (int)(context.localUtil.CToN( cgiGet( edtavCestatusarticuloaplicamov_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cestatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cestatusarticuloaplicamov), 9, 0)));
            }
            AV10cestatusarticulousotabla = cgiGet( edtavCestatusarticulousotabla_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cestatusarticulousotabla", AV10cestatusarticulousotabla);
            AV11cestatusarticulousuario = cgiGet( edtavCestatusarticulousuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cestatusarticulousuario", AV11cestatusarticulousuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCestatusarticulofecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"estatusarticulofecreg"}), 1, "vCESTATUSARTICULOFECREG");
               GX_FocusControl = edtavCestatusarticulofecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cestatusarticulofecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cestatusarticulofecreg", context.localUtil.TToC( AV12cestatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12cestatusarticulofecreg = context.localUtil.CToT( cgiGet( edtavCestatusarticulofecreg_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cestatusarticulofecreg", context.localUtil.TToC( AV12cestatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESTATUSARTICULOID"), ",", ".") != Convert.ToDecimal( AV6cestatusarticuloid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULODSC"), AV7cestatusarticulodsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULODESCUSO"), AV8cestatusarticulodescuso) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESTATUSARTICULOAPLICAMOV"), ",", ".") != Convert.ToDecimal( AV9cestatusarticuloaplicamov )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULOUSOTABLA"), AV10cestatusarticulousotabla) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCESTATUSARTICULOUSUARIO"), AV11cestatusarticulousuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCESTATUSARTICULOFECREG"), 0) != AV12cestatusarticulofecreg )
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
         /* Execute user event: E191W2 */
         E191W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191W2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "estatusarticulo", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E201W2( )
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
         /* Execute user event: E211W2 */
         E211W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211W2( )
      {
         /* Enter Routine */
         AV13pestatusarticuloid = A12estatusarticuloid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pestatusarticuloid), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV13pestatusarticuloid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pestatusarticuloid = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pestatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pestatusarticuloid), 18, 0)));
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
         PA1W2( ) ;
         WS1W2( ) ;
         WE1W2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0080");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022129005989");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx0070.js", "?2022129005989");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID_"+sGXsfl_84_idx;
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID_"+sGXsfl_84_fel_idx;
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB1W0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtestatusarticuloid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtestatusarticuloid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtestatusarticulodsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulodsc_Internalname, "Link", edtestatusarticulodsc_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtestatusarticulodsc_Internalname,(String)A54estatusarticulodsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtestatusarticulodsc_Link,(String)"",(String)"",(String)"",(String)edtestatusarticulodsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODSC"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A54estatusarticulodsc, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblestatusarticuloidfilter_Internalname = "LBLESTATUSARTICULOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticuloid_Internalname = "vCESTATUSARTICULOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticuloidfiltercontainer_Internalname = "ESTATUSARTICULOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticulodscfilter_Internalname = "LBLESTATUSARTICULODSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticulodsc_Internalname = "vCESTATUSARTICULODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticulodscfiltercontainer_Internalname = "ESTATUSARTICULODSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticulodescusofilter_Internalname = "LBLESTATUSARTICULODESCUSOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticulodescuso_Internalname = "vCESTATUSARTICULODESCUSO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticulodescusofiltercontainer_Internalname = "ESTATUSARTICULODESCUSOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticuloaplicamovfilter_Internalname = "LBLESTATUSARTICULOAPLICAMOVFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticuloaplicamov_Internalname = "vCESTATUSARTICULOAPLICAMOV";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticuloaplicamovfiltercontainer_Internalname = "ESTATUSARTICULOAPLICAMOVFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticulousotablafilter_Internalname = "LBLESTATUSARTICULOUSOTABLAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticulousotabla_Internalname = "vCESTATUSARTICULOUSOTABLA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticulousotablafiltercontainer_Internalname = "ESTATUSARTICULOUSOTABLAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticulousuariofilter_Internalname = "LBLESTATUSARTICULOUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticulousuario_Internalname = "vCESTATUSARTICULOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticulousuariofiltercontainer_Internalname = "ESTATUSARTICULOUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblestatusarticulofecregfilter_Internalname = "LBLESTATUSARTICULOFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCestatusarticulofecreg_Internalname = "vCESTATUSARTICULOFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEstatusarticulofecregfiltercontainer_Internalname = "ESTATUSARTICULOFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID";
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC";
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
         edtestatusarticulodsc_Jsonclick = "";
         edtestatusarticuloid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtestatusarticulodsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCestatusarticulofecreg_Jsonclick = "";
         edtavCestatusarticulofecreg_Enabled = 1;
         edtavCestatusarticulousuario_Jsonclick = "";
         edtavCestatusarticulousuario_Enabled = 1;
         edtavCestatusarticulousuario_Visible = 1;
         edtavCestatusarticulousotabla_Jsonclick = "";
         edtavCestatusarticulousotabla_Enabled = 1;
         edtavCestatusarticulousotabla_Visible = 1;
         edtavCestatusarticuloaplicamov_Jsonclick = "";
         edtavCestatusarticuloaplicamov_Enabled = 1;
         edtavCestatusarticuloaplicamov_Visible = 1;
         edtavCestatusarticulodescuso_Jsonclick = "";
         edtavCestatusarticulodescuso_Enabled = 1;
         edtavCestatusarticulodescuso_Visible = 1;
         edtavCestatusarticulodsc_Jsonclick = "";
         edtavCestatusarticulodsc_Enabled = 1;
         edtavCestatusarticulodsc_Visible = 1;
         edtavCestatusarticuloid_Jsonclick = "";
         edtavCestatusarticuloid_Enabled = 1;
         edtavCestatusarticuloid_Visible = 1;
         divEstatusarticulofecregfiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticulousuariofiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticulousotablafiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticuloaplicamovfiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticulodescusofiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticulodscfiltercontainer_Class = "AdvancedContainerItem";
         divEstatusarticuloidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List estatusarticulo";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cestatusarticuloid',fld:'vCESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cestatusarticulodsc',fld:'vCESTATUSARTICULODSC',pic:'',nv:''},{av:'AV8cestatusarticulodescuso',fld:'vCESTATUSARTICULODESCUSO',pic:'',nv:''},{av:'AV9cestatusarticuloaplicamov',fld:'vCESTATUSARTICULOAPLICAMOV',pic:'ZZZZZZZZ9',nv:0},{av:'AV10cestatusarticulousotabla',fld:'vCESTATUSARTICULOUSOTABLA',pic:'',nv:''},{av:'AV11cestatusarticulousuario',fld:'vCESTATUSARTICULOUSUARIO',pic:'',nv:''},{av:'AV12cestatusarticulofecreg',fld:'vCESTATUSARTICULOFECREG',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181W1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLESTATUSARTICULOIDFILTER.CLICK","{handler:'E111W1',iparms:[{av:'divEstatusarticuloidfiltercontainer_Class',ctrl:'ESTATUSARTICULOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticuloidfiltercontainer_Class',ctrl:'ESTATUSARTICULOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticuloid_Visible',ctrl:'vCESTATUSARTICULOID',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULODSCFILTER.CLICK","{handler:'E121W1',iparms:[{av:'divEstatusarticulodscfiltercontainer_Class',ctrl:'ESTATUSARTICULODSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticulodscfiltercontainer_Class',ctrl:'ESTATUSARTICULODSCFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticulodsc_Visible',ctrl:'vCESTATUSARTICULODSC',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULODESCUSOFILTER.CLICK","{handler:'E131W1',iparms:[{av:'divEstatusarticulodescusofiltercontainer_Class',ctrl:'ESTATUSARTICULODESCUSOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticulodescusofiltercontainer_Class',ctrl:'ESTATUSARTICULODESCUSOFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticulodescuso_Visible',ctrl:'vCESTATUSARTICULODESCUSO',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULOAPLICAMOVFILTER.CLICK","{handler:'E141W1',iparms:[{av:'divEstatusarticuloaplicamovfiltercontainer_Class',ctrl:'ESTATUSARTICULOAPLICAMOVFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticuloaplicamovfiltercontainer_Class',ctrl:'ESTATUSARTICULOAPLICAMOVFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticuloaplicamov_Visible',ctrl:'vCESTATUSARTICULOAPLICAMOV',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULOUSOTABLAFILTER.CLICK","{handler:'E151W1',iparms:[{av:'divEstatusarticulousotablafiltercontainer_Class',ctrl:'ESTATUSARTICULOUSOTABLAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticulousotablafiltercontainer_Class',ctrl:'ESTATUSARTICULOUSOTABLAFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticulousotabla_Visible',ctrl:'vCESTATUSARTICULOUSOTABLA',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULOUSUARIOFILTER.CLICK","{handler:'E161W1',iparms:[{av:'divEstatusarticulousuariofiltercontainer_Class',ctrl:'ESTATUSARTICULOUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticulousuariofiltercontainer_Class',ctrl:'ESTATUSARTICULOUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCestatusarticulousuario_Visible',ctrl:'vCESTATUSARTICULOUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLESTATUSARTICULOFECREGFILTER.CLICK","{handler:'E171W1',iparms:[{av:'divEstatusarticulofecregfiltercontainer_Class',ctrl:'ESTATUSARTICULOFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEstatusarticulofecregfiltercontainer_Class',ctrl:'ESTATUSARTICULOFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E211W2',iparms:[{av:'A12estatusarticuloid',fld:'ESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pestatusarticuloid',fld:'vPESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cestatusarticuloid',fld:'vCESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cestatusarticulodsc',fld:'vCESTATUSARTICULODSC',pic:'',nv:''},{av:'AV8cestatusarticulodescuso',fld:'vCESTATUSARTICULODESCUSO',pic:'',nv:''},{av:'AV9cestatusarticuloaplicamov',fld:'vCESTATUSARTICULOAPLICAMOV',pic:'ZZZZZZZZ9',nv:0},{av:'AV10cestatusarticulousotabla',fld:'vCESTATUSARTICULOUSOTABLA',pic:'',nv:''},{av:'AV11cestatusarticulousuario',fld:'vCESTATUSARTICULOUSUARIO',pic:'',nv:''},{av:'AV12cestatusarticulofecreg',fld:'vCESTATUSARTICULOFECREG',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cestatusarticuloid',fld:'vCESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cestatusarticulodsc',fld:'vCESTATUSARTICULODSC',pic:'',nv:''},{av:'AV8cestatusarticulodescuso',fld:'vCESTATUSARTICULODESCUSO',pic:'',nv:''},{av:'AV9cestatusarticuloaplicamov',fld:'vCESTATUSARTICULOAPLICAMOV',pic:'ZZZZZZZZ9',nv:0},{av:'AV10cestatusarticulousotabla',fld:'vCESTATUSARTICULOUSOTABLA',pic:'',nv:''},{av:'AV11cestatusarticulousuario',fld:'vCESTATUSARTICULOUSUARIO',pic:'',nv:''},{av:'AV12cestatusarticulofecreg',fld:'vCESTATUSARTICULOFECREG',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cestatusarticuloid',fld:'vCESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cestatusarticulodsc',fld:'vCESTATUSARTICULODSC',pic:'',nv:''},{av:'AV8cestatusarticulodescuso',fld:'vCESTATUSARTICULODESCUSO',pic:'',nv:''},{av:'AV9cestatusarticuloaplicamov',fld:'vCESTATUSARTICULOAPLICAMOV',pic:'ZZZZZZZZ9',nv:0},{av:'AV10cestatusarticulousotabla',fld:'vCESTATUSARTICULOUSOTABLA',pic:'',nv:''},{av:'AV11cestatusarticulousuario',fld:'vCESTATUSARTICULOUSUARIO',pic:'',nv:''},{av:'AV12cestatusarticulofecreg',fld:'vCESTATUSARTICULOFECREG',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cestatusarticuloid',fld:'vCESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cestatusarticulodsc',fld:'vCESTATUSARTICULODSC',pic:'',nv:''},{av:'AV8cestatusarticulodescuso',fld:'vCESTATUSARTICULODESCUSO',pic:'',nv:''},{av:'AV9cestatusarticuloaplicamov',fld:'vCESTATUSARTICULOAPLICAMOV',pic:'ZZZZZZZZ9',nv:0},{av:'AV10cestatusarticulousotabla',fld:'vCESTATUSARTICULOUSOTABLA',pic:'',nv:''},{av:'AV11cestatusarticulousuario',fld:'vCESTATUSARTICULOUSUARIO',pic:'',nv:''},{av:'AV12cestatusarticulofecreg',fld:'vCESTATUSARTICULOFECREG',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
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
         AV7cestatusarticulodsc = "";
         AV8cestatusarticulodescuso = "";
         AV10cestatusarticulousotabla = "";
         AV11cestatusarticulousuario = "";
         AV12cestatusarticulofecreg = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblestatusarticuloidfilter_Jsonclick = "";
         TempTags = "";
         lblLblestatusarticulodscfilter_Jsonclick = "";
         lblLblestatusarticulodescusofilter_Jsonclick = "";
         lblLblestatusarticuloaplicamovfilter_Jsonclick = "";
         lblLblestatusarticulousotablafilter_Jsonclick = "";
         lblLblestatusarticulousuariofilter_Jsonclick = "";
         lblLblestatusarticulofecregfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A54estatusarticulodsc = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cestatusarticulodsc = "";
         lV8cestatusarticulodescuso = "";
         lV10cestatusarticulousotabla = "";
         lV11cestatusarticulousuario = "";
         A55estatusarticulodescuso = "";
         A57estatusarticulousotabla = "";
         A58estatusarticulousuario = "";
         A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         H001W2_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         H001W2_n59estatusarticulofecreg = new bool[] {false} ;
         H001W2_A58estatusarticulousuario = new String[] {""} ;
         H001W2_n58estatusarticulousuario = new bool[] {false} ;
         H001W2_A57estatusarticulousotabla = new String[] {""} ;
         H001W2_n57estatusarticulousotabla = new bool[] {false} ;
         H001W2_A56estatusarticuloaplicamov = new int[1] ;
         H001W2_n56estatusarticuloaplicamov = new bool[] {false} ;
         H001W2_A55estatusarticulodescuso = new String[] {""} ;
         H001W2_n55estatusarticulodescuso = new bool[] {false} ;
         H001W2_A54estatusarticulodsc = new String[] {""} ;
         H001W2_n54estatusarticulodsc = new bool[] {false} ;
         H001W2_A12estatusarticuloid = new long[1] ;
         H001W3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0070__default(),
            new Object[][] {
                new Object[] {
               H001W2_A59estatusarticulofecreg, H001W2_n59estatusarticulofecreg, H001W2_A58estatusarticulousuario, H001W2_n58estatusarticulousuario, H001W2_A57estatusarticulousotabla, H001W2_n57estatusarticulousotabla, H001W2_A56estatusarticuloaplicamov, H001W2_n56estatusarticuloaplicamov, H001W2_A55estatusarticulodescuso, H001W2_n55estatusarticulodescuso,
               H001W2_A54estatusarticulodsc, H001W2_n54estatusarticulodsc, H001W2_A12estatusarticuloid
               }
               , new Object[] {
               H001W3_AGRID1_nRecordCount
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
      private int AV9cestatusarticuloaplicamov ;
      private int edtavCestatusarticuloid_Enabled ;
      private int edtavCestatusarticuloid_Visible ;
      private int edtavCestatusarticulodsc_Visible ;
      private int edtavCestatusarticulodsc_Enabled ;
      private int edtavCestatusarticulodescuso_Visible ;
      private int edtavCestatusarticulodescuso_Enabled ;
      private int edtavCestatusarticuloaplicamov_Enabled ;
      private int edtavCestatusarticuloaplicamov_Visible ;
      private int edtavCestatusarticulousotabla_Visible ;
      private int edtavCestatusarticulousotabla_Enabled ;
      private int edtavCestatusarticulousuario_Visible ;
      private int edtavCestatusarticulousuario_Enabled ;
      private int edtavCestatusarticulofecreg_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int A56estatusarticuloaplicamov ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV6cestatusarticuloid ;
      private long AV13pestatusarticuloid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A12estatusarticuloid ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEstatusarticuloidfiltercontainer_Class ;
      private String divEstatusarticulodscfiltercontainer_Class ;
      private String divEstatusarticulodescusofiltercontainer_Class ;
      private String divEstatusarticuloaplicamovfiltercontainer_Class ;
      private String divEstatusarticulousotablafiltercontainer_Class ;
      private String divEstatusarticulousuariofiltercontainer_Class ;
      private String divEstatusarticulofecregfiltercontainer_Class ;
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
      private String divEstatusarticuloidfiltercontainer_Internalname ;
      private String lblLblestatusarticuloidfilter_Internalname ;
      private String lblLblestatusarticuloidfilter_Jsonclick ;
      private String edtavCestatusarticuloid_Internalname ;
      private String TempTags ;
      private String edtavCestatusarticuloid_Jsonclick ;
      private String divEstatusarticulodscfiltercontainer_Internalname ;
      private String lblLblestatusarticulodscfilter_Internalname ;
      private String lblLblestatusarticulodscfilter_Jsonclick ;
      private String edtavCestatusarticulodsc_Internalname ;
      private String edtavCestatusarticulodsc_Jsonclick ;
      private String divEstatusarticulodescusofiltercontainer_Internalname ;
      private String lblLblestatusarticulodescusofilter_Internalname ;
      private String lblLblestatusarticulodescusofilter_Jsonclick ;
      private String edtavCestatusarticulodescuso_Internalname ;
      private String edtavCestatusarticulodescuso_Jsonclick ;
      private String divEstatusarticuloaplicamovfiltercontainer_Internalname ;
      private String lblLblestatusarticuloaplicamovfilter_Internalname ;
      private String lblLblestatusarticuloaplicamovfilter_Jsonclick ;
      private String edtavCestatusarticuloaplicamov_Internalname ;
      private String edtavCestatusarticuloaplicamov_Jsonclick ;
      private String divEstatusarticulousotablafiltercontainer_Internalname ;
      private String lblLblestatusarticulousotablafilter_Internalname ;
      private String lblLblestatusarticulousotablafilter_Jsonclick ;
      private String edtavCestatusarticulousotabla_Internalname ;
      private String edtavCestatusarticulousotabla_Jsonclick ;
      private String divEstatusarticulousuariofiltercontainer_Internalname ;
      private String lblLblestatusarticulousuariofilter_Internalname ;
      private String lblLblestatusarticulousuariofilter_Jsonclick ;
      private String edtavCestatusarticulousuario_Internalname ;
      private String edtavCestatusarticulousuario_Jsonclick ;
      private String divEstatusarticulofecregfiltercontainer_Internalname ;
      private String lblLblestatusarticulofecregfilter_Internalname ;
      private String lblLblestatusarticulofecregfilter_Jsonclick ;
      private String edtavCestatusarticulofecreg_Internalname ;
      private String edtavCestatusarticulofecreg_Jsonclick ;
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
      private String edtestatusarticulodsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtestatusarticuloid_Internalname ;
      private String edtestatusarticulodsc_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtestatusarticuloid_Jsonclick ;
      private String edtestatusarticulodsc_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV12cestatusarticulofecreg ;
      private DateTime A59estatusarticulofecreg ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n54estatusarticulodsc ;
      private bool n59estatusarticulofecreg ;
      private bool n58estatusarticulousuario ;
      private bool n57estatusarticulousotabla ;
      private bool n56estatusarticuloaplicamov ;
      private bool n55estatusarticulodescuso ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cestatusarticulodsc ;
      private String AV8cestatusarticulodescuso ;
      private String AV10cestatusarticulousotabla ;
      private String AV11cestatusarticulousuario ;
      private String A54estatusarticulodsc ;
      private String AV17Linkselection_GXI ;
      private String lV7cestatusarticulodsc ;
      private String lV8cestatusarticulodescuso ;
      private String lV10cestatusarticulousotabla ;
      private String lV11cestatusarticulousuario ;
      private String A55estatusarticulodescuso ;
      private String A57estatusarticulousotabla ;
      private String A58estatusarticulousuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H001W2_A59estatusarticulofecreg ;
      private bool[] H001W2_n59estatusarticulofecreg ;
      private String[] H001W2_A58estatusarticulousuario ;
      private bool[] H001W2_n58estatusarticulousuario ;
      private String[] H001W2_A57estatusarticulousotabla ;
      private bool[] H001W2_n57estatusarticulousotabla ;
      private int[] H001W2_A56estatusarticuloaplicamov ;
      private bool[] H001W2_n56estatusarticuloaplicamov ;
      private String[] H001W2_A55estatusarticulodescuso ;
      private bool[] H001W2_n55estatusarticulodescuso ;
      private String[] H001W2_A54estatusarticulodsc ;
      private bool[] H001W2_n54estatusarticulodsc ;
      private long[] H001W2_A12estatusarticuloid ;
      private long[] H001W3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pestatusarticuloid ;
      private GXWebForm Form ;
   }

   public class gx0070__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001W2( IGxContext context ,
                                             String AV7cestatusarticulodsc ,
                                             String AV8cestatusarticulodescuso ,
                                             int AV9cestatusarticuloaplicamov ,
                                             String AV10cestatusarticulousotabla ,
                                             String AV11cestatusarticulousuario ,
                                             DateTime AV12cestatusarticulofecreg ,
                                             String A54estatusarticulodsc ,
                                             String A55estatusarticulodescuso ,
                                             int A56estatusarticuloaplicamov ,
                                             String A57estatusarticulousotabla ,
                                             String A58estatusarticulousuario ,
                                             DateTime A59estatusarticulofecreg ,
                                             long AV6cestatusarticuloid )
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
         sSelectString = " estatusarticulofecreg, estatusarticulousuario, estatusarticulousotabla, estatusarticuloaplicamov, estatusarticulodescuso, estatusarticulodsc, estatusarticuloid";
         sFromString = " FROM public.estatusarticulo";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (estatusarticuloid >= :AV6cestatusarticuloid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cestatusarticulodsc)) )
         {
            sWhereString = sWhereString + " and (estatusarticulodsc like :lV7cestatusarticulodsc)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cestatusarticulodescuso)) )
         {
            sWhereString = sWhereString + " and (estatusarticulodescuso like :lV8cestatusarticulodescuso)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cestatusarticuloaplicamov) )
         {
            sWhereString = sWhereString + " and (estatusarticuloaplicamov >= :AV9cestatusarticuloaplicamov)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cestatusarticulousotabla)) )
         {
            sWhereString = sWhereString + " and (estatusarticulousotabla like :lV10cestatusarticulousotabla)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cestatusarticulousuario)) )
         {
            sWhereString = sWhereString + " and (estatusarticulousuario like :lV11cestatusarticulousuario)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cestatusarticulofecreg) )
         {
            sWhereString = sWhereString + " and (estatusarticulofecreg >= :AV12cestatusarticulofecreg)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY estatusarticuloid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001W3( IGxContext context ,
                                             String AV7cestatusarticulodsc ,
                                             String AV8cestatusarticulodescuso ,
                                             int AV9cestatusarticuloaplicamov ,
                                             String AV10cestatusarticulousotabla ,
                                             String AV11cestatusarticulousuario ,
                                             DateTime AV12cestatusarticulofecreg ,
                                             String A54estatusarticulodsc ,
                                             String A55estatusarticulodescuso ,
                                             int A56estatusarticuloaplicamov ,
                                             String A57estatusarticulousotabla ,
                                             String A58estatusarticulousuario ,
                                             DateTime A59estatusarticulofecreg ,
                                             long AV6cestatusarticuloid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.estatusarticulo";
         scmdbuf = scmdbuf + " WHERE (estatusarticuloid >= :AV6cestatusarticuloid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cestatusarticulodsc)) )
         {
            sWhereString = sWhereString + " and (estatusarticulodsc like :lV7cestatusarticulodsc)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cestatusarticulodescuso)) )
         {
            sWhereString = sWhereString + " and (estatusarticulodescuso like :lV8cestatusarticulodescuso)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cestatusarticuloaplicamov) )
         {
            sWhereString = sWhereString + " and (estatusarticuloaplicamov >= :AV9cestatusarticuloaplicamov)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cestatusarticulousotabla)) )
         {
            sWhereString = sWhereString + " and (estatusarticulousotabla like :lV10cestatusarticulousotabla)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cestatusarticulousuario)) )
         {
            sWhereString = sWhereString + " and (estatusarticulousuario like :lV11cestatusarticulousuario)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cestatusarticulofecreg) )
         {
            sWhereString = sWhereString + " and (estatusarticulofecreg >= :AV12cestatusarticulofecreg)";
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
                     return conditional_H001W2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (int)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (long)dynConstraints[12] );
               case 1 :
                     return conditional_H001W3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (int)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (long)dynConstraints[12] );
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
          Object[] prmH001W2 ;
          prmH001W2 = new Object[] {
          new Object[] {"AV6cestatusarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV7cestatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV8cestatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV9cestatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV10cestatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV11cestatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV12cestatusarticulofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH001W3 ;
          prmH001W3 = new Object[] {
          new Object[] {"AV6cestatusarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV7cestatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV8cestatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV9cestatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV10cestatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV11cestatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV12cestatusarticulofecreg",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W2,11,0,false,false )
             ,new CursorDef("H001W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W3,1,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
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
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
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
                   stmt.SetParameter(sIdx, (int)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
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
