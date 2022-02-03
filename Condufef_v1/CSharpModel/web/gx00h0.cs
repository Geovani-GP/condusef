/*
               File: Gx00H0
        Description: Selection List area
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:29.54
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
   public class gx00h0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00h0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00h0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pareaareaid )
      {
         this.AV12pareaareaid = 0 ;
         executePrivate();
         aP0_pareaareaid=this.AV12pareaareaid;
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
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
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
               AV6careaareaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6careaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6careaareaid), 9, 0)));
               AV7careadsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7careadsc", AV7careadsc);
               AV8careastatusadsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8careastatusadsc", AV8careastatusadsc);
               AV9careausuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9careausuario", AV9careausuario);
               AV10careafecreg = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10careafecreg", context.localUtil.TToC( AV10careafecreg, 10, 8, 0, 3, "/", ":", " "));
               AV11careafecultact = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11careafecultact", context.localUtil.TToC( AV11careafecultact, 10, 8, 0, 3, "/", ":", " "));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
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
               AV12pareaareaid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pareaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pareaareaid), 9, 0)));
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
         PA282( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START282( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20222213432958");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00h0.aspx") + "?" + UrlEncode("" +AV12pareaareaid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCAREAAREAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6careaareaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAREADSC", AV7careadsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCAREASTATUSADSC", AV8careastatusadsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCAREAUSUARIO", AV9careausuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCAREAFECREG", context.localUtil.TToC( AV10careafecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCAREAFECULTACT", context.localUtil.TToC( AV11careafecultact, 10, 8, 0, 3, "/", ":", " "));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAREAAREAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pareaareaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "AREAAREAIDFILTERCONTAINER_Class", StringUtil.RTrim( divAreaareaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AREADSCFILTERCONTAINER_Class", StringUtil.RTrim( divAreadscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AREASTATUSADSCFILTERCONTAINER_Class", StringUtil.RTrim( divAreastatusadscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AREAUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divAreausuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AREAFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divAreafecregfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AREAFECULTACTFILTERCONTAINER_Class", StringUtil.RTrim( divAreafecultactfiltercontainer_Class));
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
            WE282( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT282( ) ;
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
         return formatLink("gx00h0.aspx") + "?" + UrlEncode("" +AV12pareaareaid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00H0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List area" ;
      }

      protected void WB280( )
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
            GxWebStd.gx_div_start( context, divAreaareaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreaareaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareaareaidfilter_Internalname, "areaareaid", "", "", lblLblareaareaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11281_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareaareaid_Internalname, "areaid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCareaareaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6careaareaid), 9, 0, ",", "")), ((edtavCareaareaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6careaareaid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6careaareaid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareaareaid_Jsonclick, 0, "Attribute", "", "", "", edtavCareaareaid_Visible, edtavCareaareaid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00H0.htm");
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
            GxWebStd.gx_div_start( context, divAreadscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreadscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareadscfilter_Internalname, "areadsc", "", "", lblLblareadscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12281_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareadsc_Internalname, "areadsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCareadsc_Internalname, AV7careadsc, StringUtil.RTrim( context.localUtil.Format( AV7careadsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareadsc_Jsonclick, 0, "Attribute", "", "", "", edtavCareadsc_Visible, edtavCareadsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00H0.htm");
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
            GxWebStd.gx_div_start( context, divAreastatusadscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreastatusadscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareastatusadscfilter_Internalname, "areastatusadsc", "", "", lblLblareastatusadscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13281_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareastatusadsc_Internalname, "areastatusadsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCareastatusadsc_Internalname, AV8careastatusadsc, StringUtil.RTrim( context.localUtil.Format( AV8careastatusadsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareastatusadsc_Jsonclick, 0, "Attribute", "", "", "", edtavCareastatusadsc_Visible, edtavCareastatusadsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00H0.htm");
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
            GxWebStd.gx_div_start( context, divAreausuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreausuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareausuariofilter_Internalname, "areausuario", "", "", lblLblareausuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14281_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareausuario_Internalname, "areausuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCareausuario_Internalname, AV9careausuario, StringUtil.RTrim( context.localUtil.Format( AV9careausuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareausuario_Jsonclick, 0, "Attribute", "", "", "", edtavCareausuario_Visible, edtavCareausuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00H0.htm");
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
            GxWebStd.gx_div_start( context, divAreafecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreafecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareafecregfilter_Internalname, "areafecreg", "", "", lblLblareafecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15281_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareafecreg_Internalname, "areafecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCareafecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCareafecreg_Internalname, context.localUtil.TToC( AV10careafecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV10careafecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareafecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCareafecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00H0.htm");
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
            GxWebStd.gx_div_start( context, divAreafecultactfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAreafecultactfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblareafecultactfilter_Internalname, "areafecultact", "", "", lblLblareafecultactfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16281_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00H0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCareafecultact_Internalname, "areafecultact", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCareafecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCareafecultact_Internalname, context.localUtil.TToC( AV11careafecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV11careafecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCareafecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCareafecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00H0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e17281_client"+"'", TempTags, "", 2, "HLP_Gx00H0.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
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
               context.SendWebValue( "areaid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "areadsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "areausuario") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A27areadsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtareadsc_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A29areausuario);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00H0.htm");
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

      protected void START282( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List area", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP280( ) ;
      }

      protected void WS282( )
      {
         START282( ) ;
         EVT282( ) ;
      }

      protected void EVT282( )
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
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A22areaareaid = (int)(context.localUtil.CToN( cgiGet( edtareaareaid_Internalname), ",", "."));
                              A27areadsc = cgiGet( edtareadsc_Internalname);
                              n27areadsc = false;
                              A29areausuario = cgiGet( edtareausuario_Internalname);
                              n29areausuario = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E18282 */
                                    E18282 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19282 */
                                    E19282 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Careaareaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAREAAREAID"), ",", ".") != Convert.ToDecimal( AV6careaareaid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Careadsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREADSC"), AV7careadsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Careastatusadsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREASTATUSADSC"), AV8careastatusadsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Careausuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREAUSUARIO"), AV9careausuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Careafecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCAREAFECREG"), 0) != AV10careafecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Careafecultact Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCAREAFECULTACT"), 0) != AV11careafecultact )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E20282 */
                                          E20282 ();
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

      protected void WE282( )
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

      protected void PA282( )
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
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        int AV6careaareaid ,
                                        String AV7careadsc ,
                                        String AV8careastatusadsc ,
                                        String AV9careausuario ,
                                        DateTime AV10careafecreg ,
                                        DateTime AV11careafecultact )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF282( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AREAAREAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "AREAAREAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_AREADSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A27areadsc, ""))));
         GxWebStd.gx_hidden_field( context, "AREADSC", A27areadsc);
         GxWebStd.gx_hidden_field( context, "gxhash_AREAUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A29areausuario, ""))));
         GxWebStd.gx_hidden_field( context, "AREAUSUARIO", A29areausuario);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF282( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF282( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_742( ) ;
         nGXsfl_74_Refreshing = 1;
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
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7careadsc ,
                                                 AV8careastatusadsc ,
                                                 AV9careausuario ,
                                                 AV10careafecreg ,
                                                 AV11careafecultact ,
                                                 A27areadsc ,
                                                 A28areastatusadsc ,
                                                 A29areausuario ,
                                                 A30areafecreg ,
                                                 A31areafecultact ,
                                                 AV6careaareaid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV7careadsc = StringUtil.Concat( StringUtil.RTrim( AV7careadsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7careadsc", AV7careadsc);
            lV8careastatusadsc = StringUtil.Concat( StringUtil.RTrim( AV8careastatusadsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8careastatusadsc", AV8careastatusadsc);
            lV9careausuario = StringUtil.Concat( StringUtil.RTrim( AV9careausuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9careausuario", AV9careausuario);
            /* Using cursor H00282 */
            pr_default.execute(0, new Object[] {AV6careaareaid, lV7careadsc, lV8careastatusadsc, lV9careausuario, AV10careafecreg, AV11careafecultact, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A31areafecultact = H00282_A31areafecultact[0];
               n31areafecultact = H00282_n31areafecultact[0];
               A30areafecreg = H00282_A30areafecreg[0];
               n30areafecreg = H00282_n30areafecreg[0];
               A28areastatusadsc = H00282_A28areastatusadsc[0];
               n28areastatusadsc = H00282_n28areastatusadsc[0];
               A29areausuario = H00282_A29areausuario[0];
               n29areausuario = H00282_n29areausuario[0];
               A27areadsc = H00282_A27areadsc[0];
               n27areadsc = H00282_n27areadsc[0];
               A22areaareaid = H00282_A22areaareaid[0];
               /* Execute user event: E19282 */
               E19282 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB280( ) ;
         }
         nGXsfl_74_Refreshing = 0;
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
                                              AV7careadsc ,
                                              AV8careastatusadsc ,
                                              AV9careausuario ,
                                              AV10careafecreg ,
                                              AV11careafecultact ,
                                              A27areadsc ,
                                              A28areastatusadsc ,
                                              A29areausuario ,
                                              A30areafecreg ,
                                              A31areafecultact ,
                                              AV6careaareaid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV7careadsc = StringUtil.Concat( StringUtil.RTrim( AV7careadsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7careadsc", AV7careadsc);
         lV8careastatusadsc = StringUtil.Concat( StringUtil.RTrim( AV8careastatusadsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8careastatusadsc", AV8careastatusadsc);
         lV9careausuario = StringUtil.Concat( StringUtil.RTrim( AV9careausuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9careausuario", AV9careausuario);
         /* Using cursor H00283 */
         pr_default.execute(1, new Object[] {AV6careaareaid, lV7careadsc, lV8careastatusadsc, lV9careausuario, AV10careafecreg, AV11careafecultact});
         GRID1_nRecordCount = H00283_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6careaareaid, AV7careadsc, AV8careastatusadsc, AV9careausuario, AV10careafecreg, AV11careafecultact) ;
         }
         return (int)(0) ;
      }

      protected void STRUP280( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E18282 */
         E18282 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCareaareaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCareaareaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAREAAREAID");
               GX_FocusControl = edtavCareaareaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6careaareaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6careaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6careaareaid), 9, 0)));
            }
            else
            {
               AV6careaareaid = (int)(context.localUtil.CToN( cgiGet( edtavCareaareaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6careaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6careaareaid), 9, 0)));
            }
            AV7careadsc = cgiGet( edtavCareadsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7careadsc", AV7careadsc);
            AV8careastatusadsc = cgiGet( edtavCareastatusadsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8careastatusadsc", AV8careastatusadsc);
            AV9careausuario = cgiGet( edtavCareausuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9careausuario", AV9careausuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCareafecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"areafecreg"}), 1, "vCAREAFECREG");
               GX_FocusControl = edtavCareafecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10careafecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10careafecreg", context.localUtil.TToC( AV10careafecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV10careafecreg = context.localUtil.CToT( cgiGet( edtavCareafecreg_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10careafecreg", context.localUtil.TToC( AV10careafecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCareafecultact_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"areafecultact"}), 1, "vCAREAFECULTACT");
               GX_FocusControl = edtavCareafecultact_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11careafecultact = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11careafecultact", context.localUtil.TToC( AV11careafecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11careafecultact = context.localUtil.CToT( cgiGet( edtavCareafecultact_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11careafecultact", context.localUtil.TToC( AV11careafecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAREAAREAID"), ",", ".") != Convert.ToDecimal( AV6careaareaid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREADSC"), AV7careadsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREASTATUSADSC"), AV8careastatusadsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAREAUSUARIO"), AV9careausuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCAREAFECREG"), 0) != AV10careafecreg )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCAREAFECULTACT"), 0) != AV11careafecultact )
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
         /* Execute user event: E18282 */
         E18282 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18282( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "area", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E19282( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_74_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E20282 */
         E20282 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20282( )
      {
         /* Enter Routine */
         AV12pareaareaid = A22areaareaid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pareaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pareaareaid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV12pareaareaid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pareaareaid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pareaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pareaareaid), 9, 0)));
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
         PA282( ) ;
         WS282( ) ;
         WE282( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222213433042");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00h0.js", "?20222213433042");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtareaareaid_Internalname = "AREAAREAID_"+sGXsfl_74_idx;
         edtareadsc_Internalname = "AREADSC_"+sGXsfl_74_idx;
         edtareausuario_Internalname = "AREAUSUARIO_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtareaareaid_Internalname = "AREAAREAID_"+sGXsfl_74_fel_idx;
         edtareadsc_Internalname = "AREADSC_"+sGXsfl_74_fel_idx;
         edtareausuario_Internalname = "AREAUSUARIO_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB280( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtareaareaid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtareaareaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtareadsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareadsc_Internalname, "Link", edtareadsc_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtareadsc_Internalname,(String)A27areadsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtareadsc_Link,(String)"",(String)"",(String)"",(String)edtareadsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtareausuario_Internalname,(String)A29areausuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtareausuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_AREAAREAID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_AREADSC"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, StringUtil.RTrim( context.localUtil.Format( A27areadsc, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_AREAUSUARIO"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, StringUtil.RTrim( context.localUtil.Format( A29areausuario, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblareaareaidfilter_Internalname = "LBLAREAAREAIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareaareaid_Internalname = "vCAREAAREAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreaareaidfiltercontainer_Internalname = "AREAAREAIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblareadscfilter_Internalname = "LBLAREADSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareadsc_Internalname = "vCAREADSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreadscfiltercontainer_Internalname = "AREADSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblareastatusadscfilter_Internalname = "LBLAREASTATUSADSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareastatusadsc_Internalname = "vCAREASTATUSADSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreastatusadscfiltercontainer_Internalname = "AREASTATUSADSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblareausuariofilter_Internalname = "LBLAREAUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareausuario_Internalname = "vCAREAUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreausuariofiltercontainer_Internalname = "AREAUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblareafecregfilter_Internalname = "LBLAREAFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareafecreg_Internalname = "vCAREAFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreafecregfiltercontainer_Internalname = "AREAFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblareafecultactfilter_Internalname = "LBLAREAFECULTACTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCareafecultact_Internalname = "vCAREAFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAreafecultactfiltercontainer_Internalname = "AREAFECULTACTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtareaareaid_Internalname = "AREAAREAID";
         edtareadsc_Internalname = "AREADSC";
         edtareausuario_Internalname = "AREAUSUARIO";
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
         edtareausuario_Jsonclick = "";
         edtareadsc_Jsonclick = "";
         edtareaareaid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtareadsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCareafecultact_Jsonclick = "";
         edtavCareafecultact_Enabled = 1;
         edtavCareafecreg_Jsonclick = "";
         edtavCareafecreg_Enabled = 1;
         edtavCareausuario_Jsonclick = "";
         edtavCareausuario_Enabled = 1;
         edtavCareausuario_Visible = 1;
         edtavCareastatusadsc_Jsonclick = "";
         edtavCareastatusadsc_Enabled = 1;
         edtavCareastatusadsc_Visible = 1;
         edtavCareadsc_Jsonclick = "";
         edtavCareadsc_Enabled = 1;
         edtavCareadsc_Visible = 1;
         edtavCareaareaid_Jsonclick = "";
         edtavCareaareaid_Enabled = 1;
         edtavCareaareaid_Visible = 1;
         divAreafecultactfiltercontainer_Class = "AdvancedContainerItem";
         divAreafecregfiltercontainer_Class = "AdvancedContainerItem";
         divAreausuariofiltercontainer_Class = "AdvancedContainerItem";
         divAreastatusadscfiltercontainer_Class = "AdvancedContainerItem";
         divAreadscfiltercontainer_Class = "AdvancedContainerItem";
         divAreaareaidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List area";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6careaareaid',fld:'vCAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7careadsc',fld:'vCAREADSC',pic:'',nv:''},{av:'AV8careastatusadsc',fld:'vCAREASTATUSADSC',pic:'',nv:''},{av:'AV9careausuario',fld:'vCAREAUSUARIO',pic:'',nv:''},{av:'AV10careafecreg',fld:'vCAREAFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV11careafecultact',fld:'vCAREAFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E17281',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLAREAAREAIDFILTER.CLICK","{handler:'E11281',iparms:[{av:'divAreaareaidfiltercontainer_Class',ctrl:'AREAAREAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreaareaidfiltercontainer_Class',ctrl:'AREAAREAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCareaareaid_Visible',ctrl:'vCAREAAREAID',prop:'Visible'}]}");
         setEventMetadata("LBLAREADSCFILTER.CLICK","{handler:'E12281',iparms:[{av:'divAreadscfiltercontainer_Class',ctrl:'AREADSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreadscfiltercontainer_Class',ctrl:'AREADSCFILTERCONTAINER',prop:'Class'},{av:'edtavCareadsc_Visible',ctrl:'vCAREADSC',prop:'Visible'}]}");
         setEventMetadata("LBLAREASTATUSADSCFILTER.CLICK","{handler:'E13281',iparms:[{av:'divAreastatusadscfiltercontainer_Class',ctrl:'AREASTATUSADSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreastatusadscfiltercontainer_Class',ctrl:'AREASTATUSADSCFILTERCONTAINER',prop:'Class'},{av:'edtavCareastatusadsc_Visible',ctrl:'vCAREASTATUSADSC',prop:'Visible'}]}");
         setEventMetadata("LBLAREAUSUARIOFILTER.CLICK","{handler:'E14281',iparms:[{av:'divAreausuariofiltercontainer_Class',ctrl:'AREAUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreausuariofiltercontainer_Class',ctrl:'AREAUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCareausuario_Visible',ctrl:'vCAREAUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLAREAFECREGFILTER.CLICK","{handler:'E15281',iparms:[{av:'divAreafecregfiltercontainer_Class',ctrl:'AREAFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreafecregfiltercontainer_Class',ctrl:'AREAFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLAREAFECULTACTFILTER.CLICK","{handler:'E16281',iparms:[{av:'divAreafecultactfiltercontainer_Class',ctrl:'AREAFECULTACTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAreafecultactfiltercontainer_Class',ctrl:'AREAFECULTACTFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E20282',iparms:[{av:'A22areaareaid',fld:'AREAAREAID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV12pareaareaid',fld:'vPAREAAREAID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6careaareaid',fld:'vCAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7careadsc',fld:'vCAREADSC',pic:'',nv:''},{av:'AV8careastatusadsc',fld:'vCAREASTATUSADSC',pic:'',nv:''},{av:'AV9careausuario',fld:'vCAREAUSUARIO',pic:'',nv:''},{av:'AV10careafecreg',fld:'vCAREAFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV11careafecultact',fld:'vCAREAFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6careaareaid',fld:'vCAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7careadsc',fld:'vCAREADSC',pic:'',nv:''},{av:'AV8careastatusadsc',fld:'vCAREASTATUSADSC',pic:'',nv:''},{av:'AV9careausuario',fld:'vCAREAUSUARIO',pic:'',nv:''},{av:'AV10careafecreg',fld:'vCAREAFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV11careafecultact',fld:'vCAREAFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6careaareaid',fld:'vCAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7careadsc',fld:'vCAREADSC',pic:'',nv:''},{av:'AV8careastatusadsc',fld:'vCAREASTATUSADSC',pic:'',nv:''},{av:'AV9careausuario',fld:'vCAREAUSUARIO',pic:'',nv:''},{av:'AV10careafecreg',fld:'vCAREAFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV11careafecultact',fld:'vCAREAFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6careaareaid',fld:'vCAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7careadsc',fld:'vCAREADSC',pic:'',nv:''},{av:'AV8careastatusadsc',fld:'vCAREASTATUSADSC',pic:'',nv:''},{av:'AV9careausuario',fld:'vCAREAUSUARIO',pic:'',nv:''},{av:'AV10careafecreg',fld:'vCAREAFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV11careafecultact',fld:'vCAREAFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
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
         AV7careadsc = "";
         AV8careastatusadsc = "";
         AV9careausuario = "";
         AV10careafecreg = (DateTime)(DateTime.MinValue);
         AV11careafecultact = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblareaareaidfilter_Jsonclick = "";
         TempTags = "";
         lblLblareadscfilter_Jsonclick = "";
         lblLblareastatusadscfilter_Jsonclick = "";
         lblLblareausuariofilter_Jsonclick = "";
         lblLblareafecregfilter_Jsonclick = "";
         lblLblareafecultactfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A27areadsc = "";
         A29areausuario = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         scmdbuf = "";
         lV7careadsc = "";
         lV8careastatusadsc = "";
         lV9careausuario = "";
         A28areastatusadsc = "";
         A30areafecreg = (DateTime)(DateTime.MinValue);
         A31areafecultact = (DateTime)(DateTime.MinValue);
         H00282_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         H00282_n31areafecultact = new bool[] {false} ;
         H00282_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         H00282_n30areafecreg = new bool[] {false} ;
         H00282_A28areastatusadsc = new String[] {""} ;
         H00282_n28areastatusadsc = new bool[] {false} ;
         H00282_A29areausuario = new String[] {""} ;
         H00282_n29areausuario = new bool[] {false} ;
         H00282_A27areadsc = new String[] {""} ;
         H00282_n27areadsc = new bool[] {false} ;
         H00282_A22areaareaid = new int[1] ;
         H00283_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00h0__default(),
            new Object[][] {
                new Object[] {
               H00282_A31areafecultact, H00282_n31areafecultact, H00282_A30areafecreg, H00282_n30areafecreg, H00282_A28areastatusadsc, H00282_n28areastatusadsc, H00282_A29areausuario, H00282_n29areausuario, H00282_A27areadsc, H00282_n27areadsc,
               H00282_A22areaareaid
               }
               , new Object[] {
               H00283_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
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
      private short nGXsfl_74_Refreshing=0 ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV6careaareaid ;
      private int AV12pareaareaid ;
      private int edtavCareaareaid_Enabled ;
      private int edtavCareaareaid_Visible ;
      private int edtavCareadsc_Visible ;
      private int edtavCareadsc_Enabled ;
      private int edtavCareastatusadsc_Visible ;
      private int edtavCareastatusadsc_Enabled ;
      private int edtavCareausuario_Visible ;
      private int edtavCareausuario_Enabled ;
      private int edtavCareafecreg_Enabled ;
      private int edtavCareafecultact_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A22areaareaid ;
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
      private String divAreaareaidfiltercontainer_Class ;
      private String divAreadscfiltercontainer_Class ;
      private String divAreastatusadscfiltercontainer_Class ;
      private String divAreausuariofiltercontainer_Class ;
      private String divAreafecregfiltercontainer_Class ;
      private String divAreafecultactfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divAreaareaidfiltercontainer_Internalname ;
      private String lblLblareaareaidfilter_Internalname ;
      private String lblLblareaareaidfilter_Jsonclick ;
      private String edtavCareaareaid_Internalname ;
      private String TempTags ;
      private String edtavCareaareaid_Jsonclick ;
      private String divAreadscfiltercontainer_Internalname ;
      private String lblLblareadscfilter_Internalname ;
      private String lblLblareadscfilter_Jsonclick ;
      private String edtavCareadsc_Internalname ;
      private String edtavCareadsc_Jsonclick ;
      private String divAreastatusadscfiltercontainer_Internalname ;
      private String lblLblareastatusadscfilter_Internalname ;
      private String lblLblareastatusadscfilter_Jsonclick ;
      private String edtavCareastatusadsc_Internalname ;
      private String edtavCareastatusadsc_Jsonclick ;
      private String divAreausuariofiltercontainer_Internalname ;
      private String lblLblareausuariofilter_Internalname ;
      private String lblLblareausuariofilter_Jsonclick ;
      private String edtavCareausuario_Internalname ;
      private String edtavCareausuario_Jsonclick ;
      private String divAreafecregfiltercontainer_Internalname ;
      private String lblLblareafecregfilter_Internalname ;
      private String lblLblareafecregfilter_Jsonclick ;
      private String edtavCareafecreg_Internalname ;
      private String edtavCareafecreg_Jsonclick ;
      private String divAreafecultactfiltercontainer_Internalname ;
      private String lblLblareafecultactfilter_Internalname ;
      private String lblLblareafecultactfilter_Jsonclick ;
      private String edtavCareafecultact_Internalname ;
      private String edtavCareafecultact_Jsonclick ;
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
      private String edtareadsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtareaareaid_Internalname ;
      private String edtareadsc_Internalname ;
      private String edtareausuario_Internalname ;
      private String scmdbuf ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String ROClassString ;
      private String edtareaareaid_Jsonclick ;
      private String edtareadsc_Jsonclick ;
      private String edtareausuario_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV10careafecreg ;
      private DateTime AV11careafecultact ;
      private DateTime A30areafecreg ;
      private DateTime A31areafecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n27areadsc ;
      private bool n29areausuario ;
      private bool n31areafecultact ;
      private bool n30areafecreg ;
      private bool n28areastatusadsc ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7careadsc ;
      private String AV8careastatusadsc ;
      private String AV9careausuario ;
      private String A27areadsc ;
      private String A29areausuario ;
      private String AV16Linkselection_GXI ;
      private String lV7careadsc ;
      private String lV8careastatusadsc ;
      private String lV9careausuario ;
      private String A28areastatusadsc ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H00282_A31areafecultact ;
      private bool[] H00282_n31areafecultact ;
      private DateTime[] H00282_A30areafecreg ;
      private bool[] H00282_n30areafecreg ;
      private String[] H00282_A28areastatusadsc ;
      private bool[] H00282_n28areastatusadsc ;
      private String[] H00282_A29areausuario ;
      private bool[] H00282_n29areausuario ;
      private String[] H00282_A27areadsc ;
      private bool[] H00282_n27areadsc ;
      private int[] H00282_A22areaareaid ;
      private long[] H00283_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pareaareaid ;
      private GXWebForm Form ;
   }

   public class gx00h0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00282( IGxContext context ,
                                             String AV7careadsc ,
                                             String AV8careastatusadsc ,
                                             String AV9careausuario ,
                                             DateTime AV10careafecreg ,
                                             DateTime AV11careafecultact ,
                                             String A27areadsc ,
                                             String A28areastatusadsc ,
                                             String A29areausuario ,
                                             DateTime A30areafecreg ,
                                             DateTime A31areafecultact ,
                                             int AV6careaareaid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " areafecultact, areafecreg, areastatusadsc, areausuario, areadsc, areaid";
         sFromString = " FROM public.area";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (areaid >= :AV6careaareaid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7careadsc)) )
         {
            sWhereString = sWhereString + " and (areadsc like :lV7careadsc)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8careastatusadsc)) )
         {
            sWhereString = sWhereString + " and (areastatusadsc like :lV8careastatusadsc)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9careausuario)) )
         {
            sWhereString = sWhereString + " and (areausuario like :lV9careausuario)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV10careafecreg) )
         {
            sWhereString = sWhereString + " and (areafecreg >= :AV10careafecreg)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11careafecultact) )
         {
            sWhereString = sWhereString + " and (areafecultact >= :AV11careafecultact)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY areaid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00283( IGxContext context ,
                                             String AV7careadsc ,
                                             String AV8careastatusadsc ,
                                             String AV9careausuario ,
                                             DateTime AV10careafecreg ,
                                             DateTime AV11careafecultact ,
                                             String A27areadsc ,
                                             String A28areastatusadsc ,
                                             String A29areausuario ,
                                             DateTime A30areafecreg ,
                                             DateTime A31areafecultact ,
                                             int AV6careaareaid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.area";
         scmdbuf = scmdbuf + " WHERE (areaid >= :AV6careaareaid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7careadsc)) )
         {
            sWhereString = sWhereString + " and (areadsc like :lV7careadsc)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8careastatusadsc)) )
         {
            sWhereString = sWhereString + " and (areastatusadsc like :lV8careastatusadsc)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9careausuario)) )
         {
            sWhereString = sWhereString + " and (areausuario like :lV9careausuario)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV10careafecreg) )
         {
            sWhereString = sWhereString + " and (areafecreg >= :AV10careafecreg)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11careafecultact) )
         {
            sWhereString = sWhereString + " and (areafecultact >= :AV11careafecultact)";
         }
         else
         {
            GXv_int3[5] = 1;
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
                     return conditional_H00282(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (int)dynConstraints[10] );
               case 1 :
                     return conditional_H00283(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (int)dynConstraints[10] );
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
          Object[] prmH00282 ;
          prmH00282 = new Object[] {
          new Object[] {"AV6careaareaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7careadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV8careastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV9careausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV10careafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV11careafecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00283 ;
          prmH00283 = new Object[] {
          new Object[] {"AV6careaareaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7careadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV8careastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV9careausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV10careafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV11careafecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00282", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00282,11,0,false,false )
             ,new CursorDef("H00283", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00283,1,0,false,false )
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
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
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
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[11]);
                }
                return;
       }
    }

 }

}
