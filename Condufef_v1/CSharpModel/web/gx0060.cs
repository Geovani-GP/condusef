/*
               File: Gx0060
        Description: Selection List empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:33.98
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
   public class gx0060 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0060( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0060( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pempleadosid )
      {
         this.AV13pempleadosid = 0 ;
         executePrivate();
         aP0_pempleadosid=this.AV13pempleadosid;
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
               AV6cempleadosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadosid), 9, 0)));
               AV8cempleadosnomemple = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadosnomemple", AV8cempleadosnomemple);
               AV9cempleadosappaterno = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadosappaterno", AV9cempleadosappaterno);
               AV10cempleadosapmaterno = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadosapmaterno", AV10cempleadosapmaterno);
               AV11cempleadosstatus = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadosstatus", AV11cempleadosstatus);
               AV12cempleadosusuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadosusuario", AV12cempleadosusuario);
               AV15cempleadosfecreg = context.localUtil.ParseDateParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cempleadosfecreg", context.localUtil.Format(AV15cempleadosfecreg, "99/99/9999"));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
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
               AV13pempleadosid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadosid), 9, 0)));
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
         PA1V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1V2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202221559343");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV13pempleadosid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempleadosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSNOMEMPLE", AV8cempleadosnomemple);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSAPPATERNO", AV9cempleadosappaterno);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSAPMATERNO", AV10cempleadosapmaterno);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSSTATUS", AV11cempleadosstatus);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSUSUARIO", AV12cempleadosusuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSFECREG", context.localUtil.Format(AV15cempleadosfecreg, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pempleadosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSIDFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSNOMEMPLEFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosnomemplefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPPATERNOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosappaternofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPMATERNOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosapmaternofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSSTATUSFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosstatusfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosusuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosfecregfiltercontainer_Class));
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
            WE1V2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1V2( ) ;
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
         return formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV13pempleadosid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0060" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List empleados" ;
      }

      protected void WB1V0( )
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
            GxWebStd.gx_div_start( context, divEmpleadosidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosidfilter_Internalname, "empleadosid", "", "", lblLblempleadosidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosid_Internalname, "empleadosid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempleadosid), 9, 0, ",", "")), ((edtavCempleadosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cempleadosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cempleadosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosid_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosid_Visible, edtavCempleadosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosnomemplefiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosnomemplefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosnomemplefilter_Internalname, "empleadosnomemple", "", "", lblLblempleadosnomemplefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosnomemple_Internalname, "empleadosnomemple", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosnomemple_Internalname, AV8cempleadosnomemple, StringUtil.RTrim( context.localUtil.Format( AV8cempleadosnomemple, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosnomemple_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosnomemple_Visible, edtavCempleadosnomemple_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosappaternofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosappaternofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosappaternofilter_Internalname, "empleadosappaterno", "", "", lblLblempleadosappaternofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosappaterno_Internalname, "empleadosappaterno", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosappaterno_Internalname, AV9cempleadosappaterno, StringUtil.RTrim( context.localUtil.Format( AV9cempleadosappaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosappaterno_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosappaterno_Visible, edtavCempleadosappaterno_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosapmaternofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosapmaternofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosapmaternofilter_Internalname, "empleadosapmaterno", "", "", lblLblempleadosapmaternofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosapmaterno_Internalname, "empleadosapmaterno", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosapmaterno_Internalname, AV10cempleadosapmaterno, StringUtil.RTrim( context.localUtil.Format( AV10cempleadosapmaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosapmaterno_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosapmaterno_Visible, edtavCempleadosapmaterno_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosstatusfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosstatusfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosstatusfilter_Internalname, "empleadosstatus", "", "", lblLblempleadosstatusfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosstatus_Internalname, "empleadosstatus", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosstatus_Internalname, AV11cempleadosstatus, StringUtil.RTrim( context.localUtil.Format( AV11cempleadosstatus, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosstatus_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosstatus_Visible, edtavCempleadosstatus_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosusuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosusuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosusuariofilter_Internalname, "empleadosusuario", "", "", lblLblempleadosusuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosusuario_Internalname, "empleadosusuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosusuario_Internalname, AV12cempleadosusuario, StringUtil.RTrim( context.localUtil.Format( AV12cempleadosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosusuario_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosusuario_Visible, edtavCempleadosusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosfecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosfecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosfecregfilter_Internalname, "empleadosfecreg", "", "", lblLblempleadosfecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171v1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempleadosfecreg_Internalname, "empleadosfecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCempleadosfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCempleadosfecreg_Internalname, context.localUtil.Format(AV15cempleadosfecreg, "99/99/9999"), context.localUtil.Format( AV15cempleadosfecreg, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCempleadosfecreg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181v1_client"+"'", TempTags, "", 2, "HLP_Gx0060.htm");
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
               context.SendWebValue( "empleadosid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadosnomemple") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadosappaterno") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadosapmaterno") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadosstatus") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A99empleadosnomemple);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A100empleadosappaterno);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A101empleadosapmaterno);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A102empleadosstatus);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0060.htm");
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

      protected void START1V2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List empleados", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1V0( ) ;
      }

      protected void WS1V2( )
      {
         START1V2( ) ;
         EVT1V2( ) ;
      }

      protected void EVT1V2( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
                              A99empleadosnomemple = cgiGet( edtempleadosnomemple_Internalname);
                              n99empleadosnomemple = false;
                              A100empleadosappaterno = cgiGet( edtempleadosappaterno_Internalname);
                              n100empleadosappaterno = false;
                              A101empleadosapmaterno = cgiGet( edtempleadosapmaterno_Internalname);
                              n101empleadosapmaterno = false;
                              A102empleadosstatus = cgiGet( edtempleadosstatus_Internalname);
                              n102empleadosstatus = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191V2 */
                                    E191V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E201V2 */
                                    E201V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cempleadosid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSID"), ",", ".") != Convert.ToDecimal( AV6cempleadosid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosnomemple Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSNOMEMPLE"), AV8cempleadosnomemple) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosappaterno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSAPPATERNO"), AV9cempleadosappaterno) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosapmaterno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSAPMATERNO"), AV10cempleadosapmaterno) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosstatus Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSSTATUS"), AV11cempleadosstatus) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSUSUARIO"), AV12cempleadosusuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosfecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCEMPLEADOSFECREG"), 0) != AV15cempleadosfecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E211V2 */
                                          E211V2 ();
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

      protected void WE1V2( )
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

      protected void PA1V2( )
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
                                        int AV6cempleadosid ,
                                        String AV8cempleadosnomemple ,
                                        String AV9cempleadosappaterno ,
                                        String AV10cempleadosapmaterno ,
                                        String AV11cempleadosstatus ,
                                        String AV12cempleadosusuario ,
                                        DateTime AV15cempleadosfecreg )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1V2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSNOMEMPLE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A99empleadosnomemple, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSNOMEMPLE", A99empleadosnomemple);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPPATERNO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A100empleadosappaterno, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPPATERNO", A100empleadosappaterno);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPMATERNO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A101empleadosapmaterno, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPMATERNO", A101empleadosapmaterno);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSSTATUS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A102empleadosstatus, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSSTATUS", A102empleadosstatus);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1V2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1V2( )
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
                                                 AV8cempleadosnomemple ,
                                                 AV9cempleadosappaterno ,
                                                 AV10cempleadosapmaterno ,
                                                 AV11cempleadosstatus ,
                                                 AV12cempleadosusuario ,
                                                 AV15cempleadosfecreg ,
                                                 A99empleadosnomemple ,
                                                 A100empleadosappaterno ,
                                                 A101empleadosapmaterno ,
                                                 A102empleadosstatus ,
                                                 A103empleadosusuario ,
                                                 A104empleadosfecreg ,
                                                 AV6cempleadosid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV8cempleadosnomemple = StringUtil.Concat( StringUtil.RTrim( AV8cempleadosnomemple), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadosnomemple", AV8cempleadosnomemple);
            lV9cempleadosappaterno = StringUtil.Concat( StringUtil.RTrim( AV9cempleadosappaterno), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadosappaterno", AV9cempleadosappaterno);
            lV10cempleadosapmaterno = StringUtil.Concat( StringUtil.RTrim( AV10cempleadosapmaterno), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadosapmaterno", AV10cempleadosapmaterno);
            lV11cempleadosstatus = StringUtil.Concat( StringUtil.RTrim( AV11cempleadosstatus), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadosstatus", AV11cempleadosstatus);
            lV12cempleadosusuario = StringUtil.Concat( StringUtil.RTrim( AV12cempleadosusuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadosusuario", AV12cempleadosusuario);
            /* Using cursor H001V2 */
            pr_default.execute(0, new Object[] {AV6cempleadosid, lV8cempleadosnomemple, lV9cempleadosappaterno, lV10cempleadosapmaterno, lV11cempleadosstatus, lV12cempleadosusuario, AV15cempleadosfecreg, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A104empleadosfecreg = H001V2_A104empleadosfecreg[0];
               n104empleadosfecreg = H001V2_n104empleadosfecreg[0];
               A103empleadosusuario = H001V2_A103empleadosusuario[0];
               n103empleadosusuario = H001V2_n103empleadosusuario[0];
               A102empleadosstatus = H001V2_A102empleadosstatus[0];
               n102empleadosstatus = H001V2_n102empleadosstatus[0];
               A101empleadosapmaterno = H001V2_A101empleadosapmaterno[0];
               n101empleadosapmaterno = H001V2_n101empleadosapmaterno[0];
               A100empleadosappaterno = H001V2_A100empleadosappaterno[0];
               n100empleadosappaterno = H001V2_n100empleadosappaterno[0];
               A99empleadosnomemple = H001V2_A99empleadosnomemple[0];
               n99empleadosnomemple = H001V2_n99empleadosnomemple[0];
               A13empleadosid = H001V2_A13empleadosid[0];
               /* Execute user event: E201V2 */
               E201V2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1V0( ) ;
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
                                              AV8cempleadosnomemple ,
                                              AV9cempleadosappaterno ,
                                              AV10cempleadosapmaterno ,
                                              AV11cempleadosstatus ,
                                              AV12cempleadosusuario ,
                                              AV15cempleadosfecreg ,
                                              A99empleadosnomemple ,
                                              A100empleadosappaterno ,
                                              A101empleadosapmaterno ,
                                              A102empleadosstatus ,
                                              A103empleadosusuario ,
                                              A104empleadosfecreg ,
                                              AV6cempleadosid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV8cempleadosnomemple = StringUtil.Concat( StringUtil.RTrim( AV8cempleadosnomemple), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadosnomemple", AV8cempleadosnomemple);
         lV9cempleadosappaterno = StringUtil.Concat( StringUtil.RTrim( AV9cempleadosappaterno), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadosappaterno", AV9cempleadosappaterno);
         lV10cempleadosapmaterno = StringUtil.Concat( StringUtil.RTrim( AV10cempleadosapmaterno), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadosapmaterno", AV10cempleadosapmaterno);
         lV11cempleadosstatus = StringUtil.Concat( StringUtil.RTrim( AV11cempleadosstatus), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadosstatus", AV11cempleadosstatus);
         lV12cempleadosusuario = StringUtil.Concat( StringUtil.RTrim( AV12cempleadosusuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadosusuario", AV12cempleadosusuario);
         /* Using cursor H001V3 */
         pr_default.execute(1, new Object[] {AV6cempleadosid, lV8cempleadosnomemple, lV9cempleadosappaterno, lV10cempleadosapmaterno, lV11cempleadosstatus, lV12cempleadosusuario, AV15cempleadosfecreg});
         GRID1_nRecordCount = H001V3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempleadosid, AV8cempleadosnomemple, AV9cempleadosappaterno, AV10cempleadosapmaterno, AV11cempleadosstatus, AV12cempleadosusuario, AV15cempleadosfecreg) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1V0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E191V2 */
         E191V2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPLEADOSID");
               GX_FocusControl = edtavCempleadosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cempleadosid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadosid), 9, 0)));
            }
            else
            {
               AV6cempleadosid = (int)(context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempleadosid), 9, 0)));
            }
            AV8cempleadosnomemple = cgiGet( edtavCempleadosnomemple_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cempleadosnomemple", AV8cempleadosnomemple);
            AV9cempleadosappaterno = cgiGet( edtavCempleadosappaterno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cempleadosappaterno", AV9cempleadosappaterno);
            AV10cempleadosapmaterno = cgiGet( edtavCempleadosapmaterno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cempleadosapmaterno", AV10cempleadosapmaterno);
            AV11cempleadosstatus = cgiGet( edtavCempleadosstatus_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cempleadosstatus", AV11cempleadosstatus);
            AV12cempleadosusuario = cgiGet( edtavCempleadosusuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cempleadosusuario", AV12cempleadosusuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCempleadosfecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadosfecreg"}), 1, "vCEMPLEADOSFECREG");
               GX_FocusControl = edtavCempleadosfecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15cempleadosfecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cempleadosfecreg", context.localUtil.Format(AV15cempleadosfecreg, "99/99/9999"));
            }
            else
            {
               AV15cempleadosfecreg = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavCempleadosfecreg_Internalname), 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cempleadosfecreg", context.localUtil.Format(AV15cempleadosfecreg, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSID"), ",", ".") != Convert.ToDecimal( AV6cempleadosid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSNOMEMPLE"), AV8cempleadosnomemple) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSAPPATERNO"), AV9cempleadosappaterno) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSAPMATERNO"), AV10cempleadosapmaterno) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSSTATUS"), AV11cempleadosstatus) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEMPLEADOSUSUARIO"), AV12cempleadosusuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCEMPLEADOSFECREG"), 0) != AV15cempleadosfecreg )
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
         /* Execute user event: E191V2 */
         E191V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191V2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "empleados", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E201V2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV18Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E211V2 */
         E211V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211V2( )
      {
         /* Enter Routine */
         AV13pempleadosid = A13empleadosid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadosid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pempleadosid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pempleadosid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempleadosid), 9, 0)));
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
         PA1V2( ) ;
         WS1V2( ) ;
         WE1V2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215593514");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx0060.js", "?2022215593514");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_84_idx;
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE_"+sGXsfl_84_idx;
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO_"+sGXsfl_84_idx;
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO_"+sGXsfl_84_idx;
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_84_fel_idx;
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE_"+sGXsfl_84_fel_idx;
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO_"+sGXsfl_84_fel_idx;
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO_"+sGXsfl_84_fel_idx;
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB1V0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosnomemple_Internalname,(String)A99empleadosnomemple,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosnomemple_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosappaterno_Internalname,(String)A100empleadosappaterno,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosappaterno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosapmaterno_Internalname,(String)A101empleadosapmaterno,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosapmaterno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosstatus_Internalname,(String)A102empleadosstatus,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosstatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSNOMEMPLE"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A99empleadosnomemple, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPPATERNO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A100empleadosappaterno, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPMATERNO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A101empleadosapmaterno, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSSTATUS"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A102empleadosstatus, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblempleadosidfilter_Internalname = "LBLEMPLEADOSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosid_Internalname = "vCEMPLEADOSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosidfiltercontainer_Internalname = "EMPLEADOSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosnomemplefilter_Internalname = "LBLEMPLEADOSNOMEMPLEFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosnomemple_Internalname = "vCEMPLEADOSNOMEMPLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosnomemplefiltercontainer_Internalname = "EMPLEADOSNOMEMPLEFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosappaternofilter_Internalname = "LBLEMPLEADOSAPPATERNOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosappaterno_Internalname = "vCEMPLEADOSAPPATERNO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosappaternofiltercontainer_Internalname = "EMPLEADOSAPPATERNOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosapmaternofilter_Internalname = "LBLEMPLEADOSAPMATERNOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosapmaterno_Internalname = "vCEMPLEADOSAPMATERNO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosapmaternofiltercontainer_Internalname = "EMPLEADOSAPMATERNOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosstatusfilter_Internalname = "LBLEMPLEADOSSTATUSFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosstatus_Internalname = "vCEMPLEADOSSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosstatusfiltercontainer_Internalname = "EMPLEADOSSTATUSFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosusuariofilter_Internalname = "LBLEMPLEADOSUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosusuario_Internalname = "vCEMPLEADOSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosusuariofiltercontainer_Internalname = "EMPLEADOSUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblempleadosfecregfilter_Internalname = "LBLEMPLEADOSFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCempleadosfecreg_Internalname = "vCEMPLEADOSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEmpleadosfecregfiltercontainer_Internalname = "EMPLEADOSFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtempleadosid_Internalname = "EMPLEADOSID";
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE";
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO";
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO";
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS";
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
         edtempleadosstatus_Jsonclick = "";
         edtempleadosapmaterno_Jsonclick = "";
         edtempleadosappaterno_Jsonclick = "";
         edtempleadosnomemple_Jsonclick = "";
         edtempleadosid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCempleadosfecreg_Jsonclick = "";
         edtavCempleadosfecreg_Enabled = 1;
         edtavCempleadosusuario_Jsonclick = "";
         edtavCempleadosusuario_Enabled = 1;
         edtavCempleadosusuario_Visible = 1;
         edtavCempleadosstatus_Jsonclick = "";
         edtavCempleadosstatus_Enabled = 1;
         edtavCempleadosstatus_Visible = 1;
         edtavCempleadosapmaterno_Jsonclick = "";
         edtavCempleadosapmaterno_Enabled = 1;
         edtavCempleadosapmaterno_Visible = 1;
         edtavCempleadosappaterno_Jsonclick = "";
         edtavCempleadosappaterno_Enabled = 1;
         edtavCempleadosappaterno_Visible = 1;
         edtavCempleadosnomemple_Jsonclick = "";
         edtavCempleadosnomemple_Enabled = 1;
         edtavCempleadosnomemple_Visible = 1;
         edtavCempleadosid_Jsonclick = "";
         edtavCempleadosid_Enabled = 1;
         edtavCempleadosid_Visible = 1;
         divEmpleadosfecregfiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosusuariofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosstatusfiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosapmaternofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosappaternofiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosnomemplefiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List empleados";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cempleadosnomemple',fld:'vCEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV9cempleadosappaterno',fld:'vCEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV10cempleadosapmaterno',fld:'vCEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV11cempleadosstatus',fld:'vCEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV12cempleadosusuario',fld:'vCEMPLEADOSUSUARIO',pic:'',nv:''},{av:'AV15cempleadosfecreg',fld:'vCEMPLEADOSFECREG',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181V1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEMPLEADOSIDFILTER.CLICK","{handler:'E111V1',iparms:[{av:'divEmpleadosidfiltercontainer_Class',ctrl:'EMPLEADOSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosidfiltercontainer_Class',ctrl:'EMPLEADOSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosid_Visible',ctrl:'vCEMPLEADOSID',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSNOMEMPLEFILTER.CLICK","{handler:'E121V1',iparms:[{av:'divEmpleadosnomemplefiltercontainer_Class',ctrl:'EMPLEADOSNOMEMPLEFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosnomemplefiltercontainer_Class',ctrl:'EMPLEADOSNOMEMPLEFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosnomemple_Visible',ctrl:'vCEMPLEADOSNOMEMPLE',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSAPPATERNOFILTER.CLICK","{handler:'E131V1',iparms:[{av:'divEmpleadosappaternofiltercontainer_Class',ctrl:'EMPLEADOSAPPATERNOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosappaternofiltercontainer_Class',ctrl:'EMPLEADOSAPPATERNOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosappaterno_Visible',ctrl:'vCEMPLEADOSAPPATERNO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSAPMATERNOFILTER.CLICK","{handler:'E141V1',iparms:[{av:'divEmpleadosapmaternofiltercontainer_Class',ctrl:'EMPLEADOSAPMATERNOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosapmaternofiltercontainer_Class',ctrl:'EMPLEADOSAPMATERNOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosapmaterno_Visible',ctrl:'vCEMPLEADOSAPMATERNO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSSTATUSFILTER.CLICK","{handler:'E151V1',iparms:[{av:'divEmpleadosstatusfiltercontainer_Class',ctrl:'EMPLEADOSSTATUSFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosstatusfiltercontainer_Class',ctrl:'EMPLEADOSSTATUSFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosstatus_Visible',ctrl:'vCEMPLEADOSSTATUS',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSUSUARIOFILTER.CLICK","{handler:'E161V1',iparms:[{av:'divEmpleadosusuariofiltercontainer_Class',ctrl:'EMPLEADOSUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosusuariofiltercontainer_Class',ctrl:'EMPLEADOSUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosusuario_Visible',ctrl:'vCEMPLEADOSUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSFECREGFILTER.CLICK","{handler:'E171V1',iparms:[{av:'divEmpleadosfecregfiltercontainer_Class',ctrl:'EMPLEADOSFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosfecregfiltercontainer_Class',ctrl:'EMPLEADOSFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E211V2',iparms:[{av:'A13empleadosid',fld:'EMPLEADOSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pempleadosid',fld:'vPEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cempleadosnomemple',fld:'vCEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV9cempleadosappaterno',fld:'vCEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV10cempleadosapmaterno',fld:'vCEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV11cempleadosstatus',fld:'vCEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV12cempleadosusuario',fld:'vCEMPLEADOSUSUARIO',pic:'',nv:''},{av:'AV15cempleadosfecreg',fld:'vCEMPLEADOSFECREG',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cempleadosnomemple',fld:'vCEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV9cempleadosappaterno',fld:'vCEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV10cempleadosapmaterno',fld:'vCEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV11cempleadosstatus',fld:'vCEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV12cempleadosusuario',fld:'vCEMPLEADOSUSUARIO',pic:'',nv:''},{av:'AV15cempleadosfecreg',fld:'vCEMPLEADOSFECREG',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cempleadosnomemple',fld:'vCEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV9cempleadosappaterno',fld:'vCEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV10cempleadosapmaterno',fld:'vCEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV11cempleadosstatus',fld:'vCEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV12cempleadosusuario',fld:'vCEMPLEADOSUSUARIO',pic:'',nv:''},{av:'AV15cempleadosfecreg',fld:'vCEMPLEADOSFECREG',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cempleadosnomemple',fld:'vCEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV9cempleadosappaterno',fld:'vCEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV10cempleadosapmaterno',fld:'vCEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV11cempleadosstatus',fld:'vCEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV12cempleadosusuario',fld:'vCEMPLEADOSUSUARIO',pic:'',nv:''},{av:'AV15cempleadosfecreg',fld:'vCEMPLEADOSFECREG',pic:'',nv:''}],oparms:[]}");
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
         AV8cempleadosnomemple = "";
         AV9cempleadosappaterno = "";
         AV10cempleadosapmaterno = "";
         AV11cempleadosstatus = "";
         AV12cempleadosusuario = "";
         AV15cempleadosfecreg = DateTime.MinValue;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblempleadosidfilter_Jsonclick = "";
         TempTags = "";
         lblLblempleadosnomemplefilter_Jsonclick = "";
         lblLblempleadosappaternofilter_Jsonclick = "";
         lblLblempleadosapmaternofilter_Jsonclick = "";
         lblLblempleadosstatusfilter_Jsonclick = "";
         lblLblempleadosusuariofilter_Jsonclick = "";
         lblLblempleadosfecregfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A99empleadosnomemple = "";
         A100empleadosappaterno = "";
         A101empleadosapmaterno = "";
         A102empleadosstatus = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV8cempleadosnomemple = "";
         lV9cempleadosappaterno = "";
         lV10cempleadosapmaterno = "";
         lV11cempleadosstatus = "";
         lV12cempleadosusuario = "";
         A103empleadosusuario = "";
         A104empleadosfecreg = DateTime.MinValue;
         H001V2_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         H001V2_n104empleadosfecreg = new bool[] {false} ;
         H001V2_A103empleadosusuario = new String[] {""} ;
         H001V2_n103empleadosusuario = new bool[] {false} ;
         H001V2_A102empleadosstatus = new String[] {""} ;
         H001V2_n102empleadosstatus = new bool[] {false} ;
         H001V2_A101empleadosapmaterno = new String[] {""} ;
         H001V2_n101empleadosapmaterno = new bool[] {false} ;
         H001V2_A100empleadosappaterno = new String[] {""} ;
         H001V2_n100empleadosappaterno = new bool[] {false} ;
         H001V2_A99empleadosnomemple = new String[] {""} ;
         H001V2_n99empleadosnomemple = new bool[] {false} ;
         H001V2_A13empleadosid = new int[1] ;
         H001V3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0060__default(),
            new Object[][] {
                new Object[] {
               H001V2_A104empleadosfecreg, H001V2_n104empleadosfecreg, H001V2_A103empleadosusuario, H001V2_n103empleadosusuario, H001V2_A102empleadosstatus, H001V2_n102empleadosstatus, H001V2_A101empleadosapmaterno, H001V2_n101empleadosapmaterno, H001V2_A100empleadosappaterno, H001V2_n100empleadosappaterno,
               H001V2_A99empleadosnomemple, H001V2_n99empleadosnomemple, H001V2_A13empleadosid
               }
               , new Object[] {
               H001V3_AGRID1_nRecordCount
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
      private int AV6cempleadosid ;
      private int AV13pempleadosid ;
      private int edtavCempleadosid_Enabled ;
      private int edtavCempleadosid_Visible ;
      private int edtavCempleadosnomemple_Visible ;
      private int edtavCempleadosnomemple_Enabled ;
      private int edtavCempleadosappaterno_Visible ;
      private int edtavCempleadosappaterno_Enabled ;
      private int edtavCempleadosapmaterno_Visible ;
      private int edtavCempleadosapmaterno_Enabled ;
      private int edtavCempleadosstatus_Visible ;
      private int edtavCempleadosstatus_Enabled ;
      private int edtavCempleadosusuario_Visible ;
      private int edtavCempleadosusuario_Enabled ;
      private int edtavCempleadosfecreg_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A13empleadosid ;
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
      private String divEmpleadosidfiltercontainer_Class ;
      private String divEmpleadosnomemplefiltercontainer_Class ;
      private String divEmpleadosappaternofiltercontainer_Class ;
      private String divEmpleadosapmaternofiltercontainer_Class ;
      private String divEmpleadosstatusfiltercontainer_Class ;
      private String divEmpleadosusuariofiltercontainer_Class ;
      private String divEmpleadosfecregfiltercontainer_Class ;
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
      private String divEmpleadosidfiltercontainer_Internalname ;
      private String lblLblempleadosidfilter_Internalname ;
      private String lblLblempleadosidfilter_Jsonclick ;
      private String edtavCempleadosid_Internalname ;
      private String TempTags ;
      private String edtavCempleadosid_Jsonclick ;
      private String divEmpleadosnomemplefiltercontainer_Internalname ;
      private String lblLblempleadosnomemplefilter_Internalname ;
      private String lblLblempleadosnomemplefilter_Jsonclick ;
      private String edtavCempleadosnomemple_Internalname ;
      private String edtavCempleadosnomemple_Jsonclick ;
      private String divEmpleadosappaternofiltercontainer_Internalname ;
      private String lblLblempleadosappaternofilter_Internalname ;
      private String lblLblempleadosappaternofilter_Jsonclick ;
      private String edtavCempleadosappaterno_Internalname ;
      private String edtavCempleadosappaterno_Jsonclick ;
      private String divEmpleadosapmaternofiltercontainer_Internalname ;
      private String lblLblempleadosapmaternofilter_Internalname ;
      private String lblLblempleadosapmaternofilter_Jsonclick ;
      private String edtavCempleadosapmaterno_Internalname ;
      private String edtavCempleadosapmaterno_Jsonclick ;
      private String divEmpleadosstatusfiltercontainer_Internalname ;
      private String lblLblempleadosstatusfilter_Internalname ;
      private String lblLblempleadosstatusfilter_Jsonclick ;
      private String edtavCempleadosstatus_Internalname ;
      private String edtavCempleadosstatus_Jsonclick ;
      private String divEmpleadosusuariofiltercontainer_Internalname ;
      private String lblLblempleadosusuariofilter_Internalname ;
      private String lblLblempleadosusuariofilter_Jsonclick ;
      private String edtavCempleadosusuario_Internalname ;
      private String edtavCempleadosusuario_Jsonclick ;
      private String divEmpleadosfecregfiltercontainer_Internalname ;
      private String lblLblempleadosfecregfilter_Internalname ;
      private String lblLblempleadosfecregfilter_Jsonclick ;
      private String edtavCempleadosfecreg_Internalname ;
      private String edtavCempleadosfecreg_Jsonclick ;
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
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtempleadosid_Internalname ;
      private String edtempleadosnomemple_Internalname ;
      private String edtempleadosappaterno_Internalname ;
      private String edtempleadosapmaterno_Internalname ;
      private String edtempleadosstatus_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtempleadosid_Jsonclick ;
      private String edtempleadosnomemple_Jsonclick ;
      private String edtempleadosappaterno_Jsonclick ;
      private String edtempleadosapmaterno_Jsonclick ;
      private String edtempleadosstatus_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV15cempleadosfecreg ;
      private DateTime A104empleadosfecreg ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n99empleadosnomemple ;
      private bool n100empleadosappaterno ;
      private bool n101empleadosapmaterno ;
      private bool n102empleadosstatus ;
      private bool n104empleadosfecreg ;
      private bool n103empleadosusuario ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cempleadosnomemple ;
      private String AV9cempleadosappaterno ;
      private String AV10cempleadosapmaterno ;
      private String AV11cempleadosstatus ;
      private String AV12cempleadosusuario ;
      private String A99empleadosnomemple ;
      private String A100empleadosappaterno ;
      private String A101empleadosapmaterno ;
      private String A102empleadosstatus ;
      private String AV18Linkselection_GXI ;
      private String lV8cempleadosnomemple ;
      private String lV9cempleadosappaterno ;
      private String lV10cempleadosapmaterno ;
      private String lV11cempleadosstatus ;
      private String lV12cempleadosusuario ;
      private String A103empleadosusuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H001V2_A104empleadosfecreg ;
      private bool[] H001V2_n104empleadosfecreg ;
      private String[] H001V2_A103empleadosusuario ;
      private bool[] H001V2_n103empleadosusuario ;
      private String[] H001V2_A102empleadosstatus ;
      private bool[] H001V2_n102empleadosstatus ;
      private String[] H001V2_A101empleadosapmaterno ;
      private bool[] H001V2_n101empleadosapmaterno ;
      private String[] H001V2_A100empleadosappaterno ;
      private bool[] H001V2_n100empleadosappaterno ;
      private String[] H001V2_A99empleadosnomemple ;
      private bool[] H001V2_n99empleadosnomemple ;
      private int[] H001V2_A13empleadosid ;
      private long[] H001V3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pempleadosid ;
      private GXWebForm Form ;
   }

   public class gx0060__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001V2( IGxContext context ,
                                             String AV8cempleadosnomemple ,
                                             String AV9cempleadosappaterno ,
                                             String AV10cempleadosapmaterno ,
                                             String AV11cempleadosstatus ,
                                             String AV12cempleadosusuario ,
                                             DateTime AV15cempleadosfecreg ,
                                             String A99empleadosnomemple ,
                                             String A100empleadosappaterno ,
                                             String A101empleadosapmaterno ,
                                             String A102empleadosstatus ,
                                             String A103empleadosusuario ,
                                             DateTime A104empleadosfecreg ,
                                             int AV6cempleadosid )
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
         sSelectString = " empleadosfecreg, empleadosusuario, empleadosstatus, empleadosapmaterno, empleadosappaterno, empleadosnomemple, empleadosid";
         sFromString = " FROM public.empleados";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (empleadosid >= :AV6cempleadosid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cempleadosnomemple)) )
         {
            sWhereString = sWhereString + " and (empleadosnomemple like :lV8cempleadosnomemple)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cempleadosappaterno)) )
         {
            sWhereString = sWhereString + " and (empleadosappaterno like :lV9cempleadosappaterno)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cempleadosapmaterno)) )
         {
            sWhereString = sWhereString + " and (empleadosapmaterno like :lV10cempleadosapmaterno)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cempleadosstatus)) )
         {
            sWhereString = sWhereString + " and (empleadosstatus like :lV11cempleadosstatus)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cempleadosusuario)) )
         {
            sWhereString = sWhereString + " and (empleadosusuario like :lV12cempleadosusuario)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV15cempleadosfecreg) )
         {
            sWhereString = sWhereString + " and (empleadosfecreg >= :AV15cempleadosfecreg)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY empleadosid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001V3( IGxContext context ,
                                             String AV8cempleadosnomemple ,
                                             String AV9cempleadosappaterno ,
                                             String AV10cempleadosapmaterno ,
                                             String AV11cempleadosstatus ,
                                             String AV12cempleadosusuario ,
                                             DateTime AV15cempleadosfecreg ,
                                             String A99empleadosnomemple ,
                                             String A100empleadosappaterno ,
                                             String A101empleadosapmaterno ,
                                             String A102empleadosstatus ,
                                             String A103empleadosusuario ,
                                             DateTime A104empleadosfecreg ,
                                             int AV6cempleadosid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.empleados";
         scmdbuf = scmdbuf + " WHERE (empleadosid >= :AV6cempleadosid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cempleadosnomemple)) )
         {
            sWhereString = sWhereString + " and (empleadosnomemple like :lV8cempleadosnomemple)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cempleadosappaterno)) )
         {
            sWhereString = sWhereString + " and (empleadosappaterno like :lV9cempleadosappaterno)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cempleadosapmaterno)) )
         {
            sWhereString = sWhereString + " and (empleadosapmaterno like :lV10cempleadosapmaterno)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cempleadosstatus)) )
         {
            sWhereString = sWhereString + " and (empleadosstatus like :lV11cempleadosstatus)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cempleadosusuario)) )
         {
            sWhereString = sWhereString + " and (empleadosusuario like :lV12cempleadosusuario)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV15cempleadosfecreg) )
         {
            sWhereString = sWhereString + " and (empleadosfecreg >= :AV15cempleadosfecreg)";
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
                     return conditional_H001V2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H001V3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH001V2 ;
          prmH001V2 = new Object[] {
          new Object[] {"AV6cempleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8cempleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV9cempleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV10cempleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV11cempleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"lV12cempleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV15cempleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH001V3 ;
          prmH001V3 = new Object[] {
          new Object[] {"AV6cempleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8cempleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV9cempleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV10cempleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"lV11cempleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"lV12cempleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV15cempleadosfecreg",NpgsqlDbType.Date,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001V2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001V2,11,0,false,false )
             ,new CursorDef("H001V3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001V3,1,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[13]);
                }
                return;
       }
    }

 }

}
