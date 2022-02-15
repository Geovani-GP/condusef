/*
               File: Gx00O0
        Description: Selection List empleadospiso
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:55.53
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
   public class gx00o0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00o0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00o0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pempleadospisoextid )
      {
         this.AV13pempleadospisoextid = 0 ;
         executePrivate();
         aP0_pempleadospisoextid=this.AV13pempleadospisoextid;
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
               AV6cempleadospisoextid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadospisoextid), 9, 0)));
               AV7cempleadospisoextpiso = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadospisoextpiso", AV7cempleadospisoextpiso);
               AV8cempleadospisoextext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadospisoextext", AV8cempleadospisoextext);
               AV9cempleadospisoextcorreo = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadospisoextcorreo", AV9cempleadospisoextcorreo);
               AV10cempleadopisoextprofesion = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cempleadopisoextprofesion), 11, 0)));
               AV11cempleadospisoextusuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadospisoextusuario", AV11cempleadospisoextusuario);
               AV12cempleadospisoextfecgre = context.localUtil.ParseDateParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadospisoextfecgre", context.localUtil.Format(AV12cempleadospisoextfecgre, "99/99/9999"));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
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
               AV13pempleadospisoextid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadospisoextid), 9, 0)));
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
         PA332( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START332( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215595558");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00o0.aspx") + "?" + UrlEncode("" +AV13pempleadospisoextid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempleadospisoextid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTPISO", AV7cempleadospisoextpiso);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTEXT", AV8cempleadospisoextext);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTCORREO", AV9cempleadospisoextcorreo);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOPISOEXTPROFESION", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cempleadopisoextprofesion), 11, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTUSUARIO", AV11cempleadospisoextusuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSPISOEXTFECGRE", context.localUtil.Format(AV12cempleadospisoextfecgre, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPLEADOSPISOEXTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pempleadospisoextid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTIDFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTPISOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextpisofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTEXTFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextextfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTCORREOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextcorreofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOPISOEXTPROFESIONFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadopisoextprofesionfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextusuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTFECGREFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadospisoextfecgrefiltercontainer_Class));
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
            WE332( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT332( ) ;
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
         return formatLink("gx00o0.aspx") + "?" + UrlEncode("" +AV13pempleadospisoextid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00O0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List empleadospiso" ;
      }

      protected void WB330( )
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextidfilter_Internalname, "empleadospisoextid", "", "", lblLblempleadospisoextidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextid_Internalname, "empleadospisoextid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempleadospisoextid), 9, 0, ",", "")), ((edtavCempleadospisoextid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cempleadospisoextid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cempleadospisoextid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextid_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadospisoextid_Visible, edtavCempleadospisoextid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextpisofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextpisofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextpisofilter_Internalname, "empleadospisoextpiso", "", "", lblLblempleadospisoextpisofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextpiso_Internalname, "empleadospisoextpiso", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextpiso_Internalname, AV7cempleadospisoextpiso, StringUtil.RTrim( context.localUtil.Format( AV7cempleadospisoextpiso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextpiso_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadospisoextpiso_Visible, edtavCempleadospisoextpiso_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextextfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextextfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextextfilter_Internalname, "empleadospisoextext", "", "", lblLblempleadospisoextextfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextext_Internalname, "empleadospisoextext", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextext_Internalname, AV8cempleadospisoextext, StringUtil.RTrim( context.localUtil.Format( AV8cempleadospisoextext, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextext_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadospisoextext_Visible, edtavCempleadospisoextext_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextcorreofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextcorreofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextcorreofilter_Internalname, "empleadospisoextcorreo", "", "", lblLblempleadospisoextcorreofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextcorreo_Internalname, "empleadospisoextcorreo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextcorreo_Internalname, AV9cempleadospisoextcorreo, StringUtil.RTrim( context.localUtil.Format( AV9cempleadospisoextcorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextcorreo_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadospisoextcorreo_Visible, edtavCempleadospisoextcorreo_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadopisoextprofesionfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadopisoextprofesionfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadopisoextprofesionfilter_Internalname, "empleadopisoextprofesion", "", "", lblLblempleadopisoextprofesionfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadopisoextprofesion_Internalname, "empleadopisoextprofesion", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadopisoextprofesion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cempleadopisoextprofesion), 11, 0, ",", "")), ((edtavCempleadopisoextprofesion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cempleadopisoextprofesion), "ZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cempleadopisoextprofesion), "ZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadopisoextprofesion_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadopisoextprofesion_Visible, edtavCempleadopisoextprofesion_Enabled, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextusuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextusuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextusuariofilter_Internalname, "empleadospisoextusuario", "", "", lblLblempleadospisoextusuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16331_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextusuario_Internalname, "empleadospisoextusuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextusuario_Internalname, AV11cempleadospisoextusuario, StringUtil.RTrim( context.localUtil.Format( AV11cempleadospisoextusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextusuario_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadospisoextusuario_Visible, edtavCempleadospisoextusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadospisoextfecgrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadospisoextfecgrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadospisoextfecgrefilter_Internalname, "empleadospisoextfecgre", "", "", lblLblempleadospisoextfecgrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17331_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00O0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadospisoextfecgre_Internalname, "empleadospisoextfecgre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCempleadospisoextfecgre_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCempleadospisoextfecgre_Internalname, context.localUtil.Format(AV12cempleadospisoextfecgre, "99/99/9999"), context.localUtil.Format( AV12cempleadospisoextfecgre, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadospisoextfecgre_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCempleadospisoextfecgre_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00O0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18331_client"+"'", TempTags, "", 2, "HLP_Gx00O0.htm");
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
               context.SendWebValue( "empleadospisoextid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadospisoextpiso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadospisoextext") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadospisoextcorreo") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A47empleadospisoextpiso);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtempleadospisoextpiso_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A48empleadospisoextext);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A49empleadospisoextcorreo);
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00O0.htm");
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

      protected void START332( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List empleadospiso", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP330( ) ;
      }

      protected void WS332( )
      {
         START332( ) ;
         EVT332( ) ;
      }

      protected void EVT332( )
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
                              A46empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( edtempleadospisoextid_Internalname), ",", "."));
                              A47empleadospisoextpiso = cgiGet( edtempleadospisoextpiso_Internalname);
                              A48empleadospisoextext = cgiGet( edtempleadospisoextext_Internalname);
                              A49empleadospisoextcorreo = cgiGet( edtempleadospisoextcorreo_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19332 */
                                    E19332 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20332 */
                                    E20332 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cempleadospisoextid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSPISOEXTID"), ",", ".") != Convert.ToDecimal( AV6cempleadospisoextid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadospisoextpiso Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTPISO"), AV7cempleadospisoextpiso) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadospisoextext Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTEXT"), AV8cempleadospisoextext) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadospisoextcorreo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTCORREO"), AV9cempleadospisoextcorreo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadopisoextprofesion Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOPISOEXTPROFESION"), ",", ".") != Convert.ToDecimal( AV10cempleadopisoextprofesion )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadospisoextusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTUSUARIO"), AV11cempleadospisoextusuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadospisoextfecgre Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCEMPLEADOSPISOEXTFECGRE"), 0) != AV12cempleadospisoextfecgre )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21332 */
                                          E21332 ();
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

      protected void WE332( )
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

      protected void PA332( )
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
                                        int AV6cempleadospisoextid ,
                                        String AV7cempleadospisoextpiso ,
                                        String AV8cempleadospisoextext ,
                                        String AV9cempleadospisoextcorreo ,
                                        long AV10cempleadopisoextprofesion ,
                                        String AV11cempleadospisoextusuario ,
                                        DateTime AV12cempleadospisoextfecgre )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF332( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTPISO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A47empleadospisoextpiso, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTPISO", A47empleadospisoextpiso);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTEXT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A48empleadospisoextext, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTEXT", A48empleadospisoextext);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTCORREO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A49empleadospisoextcorreo, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSPISOEXTCORREO", A49empleadospisoextcorreo);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF332( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF332( )
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
                                                 AV7cempleadospisoextpiso ,
                                                 AV8cempleadospisoextext ,
                                                 AV9cempleadospisoextcorreo ,
                                                 AV10cempleadopisoextprofesion ,
                                                 AV11cempleadospisoextusuario ,
                                                 AV12cempleadospisoextfecgre ,
                                                 A47empleadospisoextpiso ,
                                                 A48empleadospisoextext ,
                                                 A49empleadospisoextcorreo ,
                                                 A50empleadopisoextprofesion ,
                                                 A51empleadospisoextusuario ,
                                                 A52empleadospisoextfecgre ,
                                                 AV6cempleadospisoextid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG,
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.INT
                                                 }
            });
            lV7cempleadospisoextpiso = StringUtil.Concat( StringUtil.RTrim( AV7cempleadospisoextpiso), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadospisoextpiso", AV7cempleadospisoextpiso);
            lV8cempleadospisoextext = StringUtil.Concat( StringUtil.RTrim( AV8cempleadospisoextext), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadospisoextext", AV8cempleadospisoextext);
            lV9cempleadospisoextcorreo = StringUtil.Concat( StringUtil.RTrim( AV9cempleadospisoextcorreo), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadospisoextcorreo", AV9cempleadospisoextcorreo);
            lV11cempleadospisoextusuario = StringUtil.Concat( StringUtil.RTrim( AV11cempleadospisoextusuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadospisoextusuario", AV11cempleadospisoextusuario);
            /* Using cursor H00332 */
            pr_default.execute(0, new Object[] {AV6cempleadospisoextid, lV7cempleadospisoextpiso, lV8cempleadospisoextext, lV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, lV11cempleadospisoextusuario, AV12cempleadospisoextfecgre, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A52empleadospisoextfecgre = H00332_A52empleadospisoextfecgre[0];
               A51empleadospisoextusuario = H00332_A51empleadospisoextusuario[0];
               A50empleadopisoextprofesion = H00332_A50empleadopisoextprofesion[0];
               A49empleadospisoextcorreo = H00332_A49empleadospisoextcorreo[0];
               A48empleadospisoextext = H00332_A48empleadospisoextext[0];
               A47empleadospisoextpiso = H00332_A47empleadospisoextpiso[0];
               A46empleadospisoextid = H00332_A46empleadospisoextid[0];
               /* Execute user event: E20332 */
               E20332 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB330( ) ;
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
                                              AV7cempleadospisoextpiso ,
                                              AV8cempleadospisoextext ,
                                              AV9cempleadospisoextcorreo ,
                                              AV10cempleadopisoextprofesion ,
                                              AV11cempleadospisoextusuario ,
                                              AV12cempleadospisoextfecgre ,
                                              A47empleadospisoextpiso ,
                                              A48empleadospisoextext ,
                                              A49empleadospisoextcorreo ,
                                              A50empleadopisoextprofesion ,
                                              A51empleadospisoextusuario ,
                                              A52empleadospisoextfecgre ,
                                              AV6cempleadospisoextid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.INT
                                              }
         });
         lV7cempleadospisoextpiso = StringUtil.Concat( StringUtil.RTrim( AV7cempleadospisoextpiso), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadospisoextpiso", AV7cempleadospisoextpiso);
         lV8cempleadospisoextext = StringUtil.Concat( StringUtil.RTrim( AV8cempleadospisoextext), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadospisoextext", AV8cempleadospisoextext);
         lV9cempleadospisoextcorreo = StringUtil.Concat( StringUtil.RTrim( AV9cempleadospisoextcorreo), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadospisoextcorreo", AV9cempleadospisoextcorreo);
         lV11cempleadospisoextusuario = StringUtil.Concat( StringUtil.RTrim( AV11cempleadospisoextusuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadospisoextusuario", AV11cempleadospisoextusuario);
         /* Using cursor H00333 */
         pr_default.execute(1, new Object[] {AV6cempleadospisoextid, lV7cempleadospisoextpiso, lV8cempleadospisoextext, lV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, lV11cempleadospisoextusuario, AV12cempleadospisoextfecgre});
         GRID1_nRecordCount = H00333_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadospisoextid, AV7cempleadospisoextpiso, AV8cempleadospisoextext, AV9cempleadospisoextcorreo, AV10cempleadopisoextprofesion, AV11cempleadospisoextusuario, AV12cempleadospisoextfecgre) ;
         }
         return (int)(0) ;
      }

      protected void STRUP330( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19332 */
         E19332 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempleadospisoextid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempleadospisoextid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPLEADOSPISOEXTID");
               GX_FocusControl = edtavCempleadospisoextid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cempleadospisoextid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadospisoextid), 9, 0)));
            }
            else
            {
               AV6cempleadospisoextid = (int)(context.localUtil.CToN( cgiGet( edtavCempleadospisoextid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadospisoextid), 9, 0)));
            }
            AV7cempleadospisoextpiso = cgiGet( edtavCempleadospisoextpiso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadospisoextpiso", AV7cempleadospisoextpiso);
            AV8cempleadospisoextext = cgiGet( edtavCempleadospisoextext_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadospisoextext", AV8cempleadospisoextext);
            AV9cempleadospisoextcorreo = cgiGet( edtavCempleadospisoextcorreo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadospisoextcorreo", AV9cempleadospisoextcorreo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempleadopisoextprofesion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempleadopisoextprofesion_Internalname), ",", ".") > Convert.ToDecimal( 99999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPLEADOPISOEXTPROFESION");
               GX_FocusControl = edtavCempleadopisoextprofesion_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cempleadopisoextprofesion = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cempleadopisoextprofesion), 11, 0)));
            }
            else
            {
               AV10cempleadopisoextprofesion = (long)(context.localUtil.CToN( cgiGet( edtavCempleadopisoextprofesion_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cempleadopisoextprofesion), 11, 0)));
            }
            AV11cempleadospisoextusuario = cgiGet( edtavCempleadospisoextusuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadospisoextusuario", AV11cempleadospisoextusuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCempleadospisoextfecgre_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadospisoextfecgre"}), 1, "vCEMPLEADOSPISOEXTFECGRE");
               GX_FocusControl = edtavCempleadospisoextfecgre_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cempleadospisoextfecgre = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadospisoextfecgre", context.localUtil.Format(AV12cempleadospisoextfecgre, "99/99/9999"));
            }
            else
            {
               AV12cempleadospisoextfecgre = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavCempleadospisoextfecgre_Internalname), 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadospisoextfecgre", context.localUtil.Format(AV12cempleadospisoextfecgre, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSPISOEXTID"), ",", ".") != Convert.ToDecimal( AV6cempleadospisoextid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTPISO"), AV7cempleadospisoextpiso) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTEXT"), AV8cempleadospisoextext) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTCORREO"), AV9cempleadospisoextcorreo) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOPISOEXTPROFESION"), ",", ".") != Convert.ToDecimal( AV10cempleadopisoextprofesion )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSPISOEXTUSUARIO"), AV11cempleadospisoextusuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCEMPLEADOSPISOEXTFECGRE"), 0) != AV12cempleadospisoextfecgre )
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
         /* Execute user event: E19332 */
         E19332 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19332( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "empleadospiso", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20332( )
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
         /* Execute user event: E21332 */
         E21332 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21332( )
      {
         /* Enter Routine */
         AV13pempleadospisoextid = A46empleadospisoextid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadospisoextid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pempleadospisoextid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pempleadospisoextid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadospisoextid), 9, 0)));
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
         PA332( ) ;
         WS332( ) ;
         WE332( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?583790");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215595650");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00o0.js", "?2022215595650");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID_"+sGXsfl_84_idx;
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO_"+sGXsfl_84_idx;
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT_"+sGXsfl_84_idx;
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID_"+sGXsfl_84_fel_idx;
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO_"+sGXsfl_84_fel_idx;
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT_"+sGXsfl_84_fel_idx;
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB330( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtempleadospisoextpiso_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextpiso_Internalname, "Link", edtempleadospisoextpiso_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextpiso_Internalname,(String)A47empleadospisoextpiso,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtempleadospisoextpiso_Link,(String)"",(String)"",(String)"",(String)edtempleadospisoextpiso_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextext_Internalname,(String)A48empleadospisoextext,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextext_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadospisoextcorreo_Internalname,(String)A49empleadospisoextcorreo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadospisoextcorreo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTPISO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A47empleadospisoextpiso, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTEXT"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A48empleadospisoextext, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSPISOEXTCORREO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A49empleadospisoextcorreo, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblempleadospisoextidfilter_Internalname = "LBLEMPLEADOSPISOEXTIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextid_Internalname = "vCEMPLEADOSPISOEXTID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextidfiltercontainer_Internalname = "EMPLEADOSPISOEXTIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadospisoextpisofilter_Internalname = "LBLEMPLEADOSPISOEXTPISOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextpiso_Internalname = "vCEMPLEADOSPISOEXTPISO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextpisofiltercontainer_Internalname = "EMPLEADOSPISOEXTPISOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadospisoextextfilter_Internalname = "LBLEMPLEADOSPISOEXTEXTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextext_Internalname = "vCEMPLEADOSPISOEXTEXT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextextfiltercontainer_Internalname = "EMPLEADOSPISOEXTEXTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadospisoextcorreofilter_Internalname = "LBLEMPLEADOSPISOEXTCORREOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextcorreo_Internalname = "vCEMPLEADOSPISOEXTCORREO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextcorreofiltercontainer_Internalname = "EMPLEADOSPISOEXTCORREOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadopisoextprofesionfilter_Internalname = "LBLEMPLEADOPISOEXTPROFESIONFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadopisoextprofesion_Internalname = "vCEMPLEADOPISOEXTPROFESION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadopisoextprofesionfiltercontainer_Internalname = "EMPLEADOPISOEXTPROFESIONFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadospisoextusuariofilter_Internalname = "LBLEMPLEADOSPISOEXTUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextusuario_Internalname = "vCEMPLEADOSPISOEXTUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextusuariofiltercontainer_Internalname = "EMPLEADOSPISOEXTUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadospisoextfecgrefilter_Internalname = "LBLEMPLEADOSPISOEXTFECGREFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadospisoextfecgre_Internalname = "vCEMPLEADOSPISOEXTFECGRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadospisoextfecgrefiltercontainer_Internalname = "EMPLEADOSPISOEXTFECGREFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID";
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO";
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT";
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO";
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
         edtempleadospisoextcorreo_Jsonclick = "";
         edtempleadospisoextext_Jsonclick = "";
         edtempleadospisoextpiso_Jsonclick = "";
         edtempleadospisoextid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtempleadospisoextpiso_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCempleadospisoextfecgre_Jsonclick = "";
         edtavCempleadospisoextfecgre_Enabled = 1;
         edtavCempleadospisoextusuario_Jsonclick = "";
         edtavCempleadospisoextusuario_Enabled = 1;
         edtavCempleadospisoextusuario_Visible = 1;
         edtavCempleadopisoextprofesion_Jsonclick = "";
         edtavCempleadopisoextprofesion_Enabled = 1;
         edtavCempleadopisoextprofesion_Visible = 1;
         edtavCempleadospisoextcorreo_Jsonclick = "";
         edtavCempleadospisoextcorreo_Enabled = 1;
         edtavCempleadospisoextcorreo_Visible = 1;
         edtavCempleadospisoextext_Jsonclick = "";
         edtavCempleadospisoextext_Enabled = 1;
         edtavCempleadospisoextext_Visible = 1;
         edtavCempleadospisoextpiso_Jsonclick = "";
         edtavCempleadospisoextpiso_Enabled = 1;
         edtavCempleadospisoextpiso_Visible = 1;
         edtavCempleadospisoextid_Jsonclick = "";
         edtavCempleadospisoextid_Enabled = 1;
         edtavCempleadospisoextid_Visible = 1;
         divEmpleadospisoextfecgrefiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadospisoextusuariofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadopisoextprofesionfiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadospisoextcorreofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadospisoextextfiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadospisoextpisofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadospisoextidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List empleadospiso";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadospisoextid',fld:'vCEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cempleadospisoextpiso',fld:'vCEMPLEADOSPISOEXTPISO',pic:'',nv:''},{av:'AV8cempleadospisoextext',fld:'vCEMPLEADOSPISOEXTEXT',pic:'',nv:''},{av:'AV9cempleadospisoextcorreo',fld:'vCEMPLEADOSPISOEXTCORREO',pic:'',nv:''},{av:'AV10cempleadopisoextprofesion',fld:'vCEMPLEADOPISOEXTPROFESION',pic:'ZZZZZZZZZZ9',nv:0},{av:'AV11cempleadospisoextusuario',fld:'vCEMPLEADOSPISOEXTUSUARIO',pic:'',nv:''},{av:'AV12cempleadospisoextfecgre',fld:'vCEMPLEADOSPISOEXTFECGRE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18331',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTIDFILTER.CLICK","{handler:'E11331',iparms:[{av:'divEmpleadospisoextidfiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextidfiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTIDFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadospisoextid_Visible',ctrl:'vCEMPLEADOSPISOEXTID',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTPISOFILTER.CLICK","{handler:'E12331',iparms:[{av:'divEmpleadospisoextpisofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTPISOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextpisofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTPISOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadospisoextpiso_Visible',ctrl:'vCEMPLEADOSPISOEXTPISO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTEXTFILTER.CLICK","{handler:'E13331',iparms:[{av:'divEmpleadospisoextextfiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTEXTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextextfiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTEXTFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadospisoextext_Visible',ctrl:'vCEMPLEADOSPISOEXTEXT',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTCORREOFILTER.CLICK","{handler:'E14331',iparms:[{av:'divEmpleadospisoextcorreofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTCORREOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextcorreofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTCORREOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadospisoextcorreo_Visible',ctrl:'vCEMPLEADOSPISOEXTCORREO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOPISOEXTPROFESIONFILTER.CLICK","{handler:'E15331',iparms:[{av:'divEmpleadopisoextprofesionfiltercontainer_Class',ctrl:'EMPLEADOPISOEXTPROFESIONFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadopisoextprofesionfiltercontainer_Class',ctrl:'EMPLEADOPISOEXTPROFESIONFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadopisoextprofesion_Visible',ctrl:'vCEMPLEADOPISOEXTPROFESION',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTUSUARIOFILTER.CLICK","{handler:'E16331',iparms:[{av:'divEmpleadospisoextusuariofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextusuariofiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadospisoextusuario_Visible',ctrl:'vCEMPLEADOSPISOEXTUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSPISOEXTFECGREFILTER.CLICK","{handler:'E17331',iparms:[{av:'divEmpleadospisoextfecgrefiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTFECGREFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadospisoextfecgrefiltercontainer_Class',ctrl:'EMPLEADOSPISOEXTFECGREFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E21332',iparms:[{av:'A46empleadospisoextid',fld:'EMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pempleadospisoextid',fld:'vPEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadospisoextid',fld:'vCEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cempleadospisoextpiso',fld:'vCEMPLEADOSPISOEXTPISO',pic:'',nv:''},{av:'AV8cempleadospisoextext',fld:'vCEMPLEADOSPISOEXTEXT',pic:'',nv:''},{av:'AV9cempleadospisoextcorreo',fld:'vCEMPLEADOSPISOEXTCORREO',pic:'',nv:''},{av:'AV10cempleadopisoextprofesion',fld:'vCEMPLEADOPISOEXTPROFESION',pic:'ZZZZZZZZZZ9',nv:0},{av:'AV11cempleadospisoextusuario',fld:'vCEMPLEADOSPISOEXTUSUARIO',pic:'',nv:''},{av:'AV12cempleadospisoextfecgre',fld:'vCEMPLEADOSPISOEXTFECGRE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadospisoextid',fld:'vCEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cempleadospisoextpiso',fld:'vCEMPLEADOSPISOEXTPISO',pic:'',nv:''},{av:'AV8cempleadospisoextext',fld:'vCEMPLEADOSPISOEXTEXT',pic:'',nv:''},{av:'AV9cempleadospisoextcorreo',fld:'vCEMPLEADOSPISOEXTCORREO',pic:'',nv:''},{av:'AV10cempleadopisoextprofesion',fld:'vCEMPLEADOPISOEXTPROFESION',pic:'ZZZZZZZZZZ9',nv:0},{av:'AV11cempleadospisoextusuario',fld:'vCEMPLEADOSPISOEXTUSUARIO',pic:'',nv:''},{av:'AV12cempleadospisoextfecgre',fld:'vCEMPLEADOSPISOEXTFECGRE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadospisoextid',fld:'vCEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cempleadospisoextpiso',fld:'vCEMPLEADOSPISOEXTPISO',pic:'',nv:''},{av:'AV8cempleadospisoextext',fld:'vCEMPLEADOSPISOEXTEXT',pic:'',nv:''},{av:'AV9cempleadospisoextcorreo',fld:'vCEMPLEADOSPISOEXTCORREO',pic:'',nv:''},{av:'AV10cempleadopisoextprofesion',fld:'vCEMPLEADOPISOEXTPROFESION',pic:'ZZZZZZZZZZ9',nv:0},{av:'AV11cempleadospisoextusuario',fld:'vCEMPLEADOSPISOEXTUSUARIO',pic:'',nv:''},{av:'AV12cempleadospisoextfecgre',fld:'vCEMPLEADOSPISOEXTFECGRE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadospisoextid',fld:'vCEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cempleadospisoextpiso',fld:'vCEMPLEADOSPISOEXTPISO',pic:'',nv:''},{av:'AV8cempleadospisoextext',fld:'vCEMPLEADOSPISOEXTEXT',pic:'',nv:''},{av:'AV9cempleadospisoextcorreo',fld:'vCEMPLEADOSPISOEXTCORREO',pic:'',nv:''},{av:'AV10cempleadopisoextprofesion',fld:'vCEMPLEADOPISOEXTPROFESION',pic:'ZZZZZZZZZZ9',nv:0},{av:'AV11cempleadospisoextusuario',fld:'vCEMPLEADOSPISOEXTUSUARIO',pic:'',nv:''},{av:'AV12cempleadospisoextfecgre',fld:'vCEMPLEADOSPISOEXTFECGRE',pic:'',nv:''}],oparms:[]}");
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
         AV7cempleadospisoextpiso = "";
         AV8cempleadospisoextext = "";
         AV9cempleadospisoextcorreo = "";
         AV11cempleadospisoextusuario = "";
         AV12cempleadospisoextfecgre = DateTime.MinValue;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblempleadospisoextidfilter_Jsonclick = "";
         TempTags = "";
         lblLblempleadospisoextpisofilter_Jsonclick = "";
         lblLblempleadospisoextextfilter_Jsonclick = "";
         lblLblempleadospisoextcorreofilter_Jsonclick = "";
         lblLblempleadopisoextprofesionfilter_Jsonclick = "";
         lblLblempleadospisoextusuariofilter_Jsonclick = "";
         lblLblempleadospisoextfecgrefilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A47empleadospisoextpiso = "";
         A48empleadospisoextext = "";
         A49empleadospisoextcorreo = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cempleadospisoextpiso = "";
         lV8cempleadospisoextext = "";
         lV9cempleadospisoextcorreo = "";
         lV11cempleadospisoextusuario = "";
         A51empleadospisoextusuario = "";
         A52empleadospisoextfecgre = DateTime.MinValue;
         H00332_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         H00332_A51empleadospisoextusuario = new String[] {""} ;
         H00332_A50empleadopisoextprofesion = new long[1] ;
         H00332_A49empleadospisoextcorreo = new String[] {""} ;
         H00332_A48empleadospisoextext = new String[] {""} ;
         H00332_A47empleadospisoextpiso = new String[] {""} ;
         H00332_A46empleadospisoextid = new int[1] ;
         H00333_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00o0__default(),
            new Object[][] {
                new Object[] {
               H00332_A52empleadospisoextfecgre, H00332_A51empleadospisoextusuario, H00332_A50empleadopisoextprofesion, H00332_A49empleadospisoextcorreo, H00332_A48empleadospisoextext, H00332_A47empleadospisoextpiso, H00332_A46empleadospisoextid
               }
               , new Object[] {
               H00333_AGRID1_nRecordCount
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
      private int AV6cempleadospisoextid ;
      private int AV13pempleadospisoextid ;
      private int edtavCempleadospisoextid_Enabled ;
      private int edtavCempleadospisoextid_Visible ;
      private int edtavCempleadospisoextpiso_Visible ;
      private int edtavCempleadospisoextpiso_Enabled ;
      private int edtavCempleadospisoextext_Visible ;
      private int edtavCempleadospisoextext_Enabled ;
      private int edtavCempleadospisoextcorreo_Visible ;
      private int edtavCempleadospisoextcorreo_Enabled ;
      private int edtavCempleadopisoextprofesion_Enabled ;
      private int edtavCempleadopisoextprofesion_Visible ;
      private int edtavCempleadospisoextusuario_Visible ;
      private int edtavCempleadospisoextusuario_Enabled ;
      private int edtavCempleadospisoextfecgre_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A46empleadospisoextid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV10cempleadopisoextprofesion ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long A50empleadopisoextprofesion ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEmpleadospisoextidfiltercontainer_Class ;
      private String divEmpleadospisoextpisofiltercontainer_Class ;
      private String divEmpleadospisoextextfiltercontainer_Class ;
      private String divEmpleadospisoextcorreofiltercontainer_Class ;
      private String divEmpleadopisoextprofesionfiltercontainer_Class ;
      private String divEmpleadospisoextusuariofiltercontainer_Class ;
      private String divEmpleadospisoextfecgrefiltercontainer_Class ;
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
      private String divEmpleadospisoextidfiltercontainer_Internalname ;
      private String lblLblempleadospisoextidfilter_Internalname ;
      private String lblLblempleadospisoextidfilter_Jsonclick ;
      private String edtavCempleadospisoextid_Internalname ;
      private String TempTags ;
      private String edtavCempleadospisoextid_Jsonclick ;
      private String divEmpleadospisoextpisofiltercontainer_Internalname ;
      private String lblLblempleadospisoextpisofilter_Internalname ;
      private String lblLblempleadospisoextpisofilter_Jsonclick ;
      private String edtavCempleadospisoextpiso_Internalname ;
      private String edtavCempleadospisoextpiso_Jsonclick ;
      private String divEmpleadospisoextextfiltercontainer_Internalname ;
      private String lblLblempleadospisoextextfilter_Internalname ;
      private String lblLblempleadospisoextextfilter_Jsonclick ;
      private String edtavCempleadospisoextext_Internalname ;
      private String edtavCempleadospisoextext_Jsonclick ;
      private String divEmpleadospisoextcorreofiltercontainer_Internalname ;
      private String lblLblempleadospisoextcorreofilter_Internalname ;
      private String lblLblempleadospisoextcorreofilter_Jsonclick ;
      private String edtavCempleadospisoextcorreo_Internalname ;
      private String edtavCempleadospisoextcorreo_Jsonclick ;
      private String divEmpleadopisoextprofesionfiltercontainer_Internalname ;
      private String lblLblempleadopisoextprofesionfilter_Internalname ;
      private String lblLblempleadopisoextprofesionfilter_Jsonclick ;
      private String edtavCempleadopisoextprofesion_Internalname ;
      private String edtavCempleadopisoextprofesion_Jsonclick ;
      private String divEmpleadospisoextusuariofiltercontainer_Internalname ;
      private String lblLblempleadospisoextusuariofilter_Internalname ;
      private String lblLblempleadospisoextusuariofilter_Jsonclick ;
      private String edtavCempleadospisoextusuario_Internalname ;
      private String edtavCempleadospisoextusuario_Jsonclick ;
      private String divEmpleadospisoextfecgrefiltercontainer_Internalname ;
      private String lblLblempleadospisoextfecgrefilter_Internalname ;
      private String lblLblempleadospisoextfecgrefilter_Jsonclick ;
      private String edtavCempleadospisoextfecgre_Internalname ;
      private String edtavCempleadospisoextfecgre_Jsonclick ;
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
      private String edtempleadospisoextpiso_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtempleadospisoextid_Internalname ;
      private String edtempleadospisoextpiso_Internalname ;
      private String edtempleadospisoextext_Internalname ;
      private String edtempleadospisoextcorreo_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtempleadospisoextid_Jsonclick ;
      private String edtempleadospisoextpiso_Jsonclick ;
      private String edtempleadospisoextext_Jsonclick ;
      private String edtempleadospisoextcorreo_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV12cempleadospisoextfecgre ;
      private DateTime A52empleadospisoextfecgre ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cempleadospisoextpiso ;
      private String AV8cempleadospisoextext ;
      private String AV9cempleadospisoextcorreo ;
      private String AV11cempleadospisoextusuario ;
      private String A47empleadospisoextpiso ;
      private String A48empleadospisoextext ;
      private String A49empleadospisoextcorreo ;
      private String AV17Linkselection_GXI ;
      private String lV7cempleadospisoextpiso ;
      private String lV8cempleadospisoextext ;
      private String lV9cempleadospisoextcorreo ;
      private String lV11cempleadospisoextusuario ;
      private String A51empleadospisoextusuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H00332_A52empleadospisoextfecgre ;
      private String[] H00332_A51empleadospisoextusuario ;
      private long[] H00332_A50empleadopisoextprofesion ;
      private String[] H00332_A49empleadospisoextcorreo ;
      private String[] H00332_A48empleadospisoextext ;
      private String[] H00332_A47empleadospisoextpiso ;
      private int[] H00332_A46empleadospisoextid ;
      private long[] H00333_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pempleadospisoextid ;
      private GXWebForm Form ;
   }

   public class gx00o0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00332( IGxContext context ,
                                             String AV7cempleadospisoextpiso ,
                                             String AV8cempleadospisoextext ,
                                             String AV9cempleadospisoextcorreo ,
                                             long AV10cempleadopisoextprofesion ,
                                             String AV11cempleadospisoextusuario ,
                                             DateTime AV12cempleadospisoextfecgre ,
                                             String A47empleadospisoextpiso ,
                                             String A48empleadospisoextext ,
                                             String A49empleadospisoextcorreo ,
                                             long A50empleadopisoextprofesion ,
                                             String A51empleadospisoextusuario ,
                                             DateTime A52empleadospisoextfecgre ,
                                             int AV6cempleadospisoextid )
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
         sSelectString = " empleadospisoextfecgre, empleadospisoextusuario, empleadopisoextprofesion, empleadospisoextcorreo, empleadospisoextext, empleadospisoextpiso, empleadospisoextid";
         sFromString = " FROM empleadospiso";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (empleadospisoextid >= :AV6cempleadospisoextid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cempleadospisoextpiso)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextpiso like :lV7cempleadospisoextpiso)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cempleadospisoextext)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextext like :lV8cempleadospisoextext)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cempleadospisoextcorreo)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextcorreo like :lV9cempleadospisoextcorreo)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cempleadopisoextprofesion) )
         {
            sWhereString = sWhereString + " and (empleadopisoextprofesion >= :AV10cempleadopisoextprofesion)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cempleadospisoextusuario)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextusuario like :lV11cempleadospisoextusuario)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cempleadospisoextfecgre) )
         {
            sWhereString = sWhereString + " and (empleadospisoextfecgre >= :AV12cempleadospisoextfecgre)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY empleadospisoextid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00333( IGxContext context ,
                                             String AV7cempleadospisoextpiso ,
                                             String AV8cempleadospisoextext ,
                                             String AV9cempleadospisoextcorreo ,
                                             long AV10cempleadopisoextprofesion ,
                                             String AV11cempleadospisoextusuario ,
                                             DateTime AV12cempleadospisoextfecgre ,
                                             String A47empleadospisoextpiso ,
                                             String A48empleadospisoextext ,
                                             String A49empleadospisoextcorreo ,
                                             long A50empleadopisoextprofesion ,
                                             String A51empleadospisoextusuario ,
                                             DateTime A52empleadospisoextfecgre ,
                                             int AV6cempleadospisoextid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM empleadospiso";
         scmdbuf = scmdbuf + " WHERE (empleadospisoextid >= :AV6cempleadospisoextid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cempleadospisoextpiso)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextpiso like :lV7cempleadospisoextpiso)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cempleadospisoextext)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextext like :lV8cempleadospisoextext)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cempleadospisoextcorreo)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextcorreo like :lV9cempleadospisoextcorreo)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cempleadopisoextprofesion) )
         {
            sWhereString = sWhereString + " and (empleadopisoextprofesion >= :AV10cempleadopisoextprofesion)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cempleadospisoextusuario)) )
         {
            sWhereString = sWhereString + " and (empleadospisoextusuario like :lV11cempleadospisoextusuario)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cempleadospisoextfecgre) )
         {
            sWhereString = sWhereString + " and (empleadospisoextfecgre >= :AV12cempleadospisoextfecgre)";
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
                     return conditional_H00332(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H00333(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH00332 ;
          prmH00332 = new Object[] {
          new Object[] {"AV6cempleadospisoextid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cempleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV8cempleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV9cempleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV10cempleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"lV11cempleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV12cempleadospisoextfecgre",NpgsqlDbType.Date,8,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00333 ;
          prmH00333 = new Object[] {
          new Object[] {"AV6cempleadospisoextid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cempleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV8cempleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV9cempleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV10cempleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"lV11cempleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV12cempleadospisoextfecgre",NpgsqlDbType.Date,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00332", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00332,11,0,false,false )
             ,new CursorDef("H00333", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00333,1,0,false,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[13]);
                }
                return;
       }
    }

 }

}
