/*
               File: Gx00I0
        Description: Selection List almacen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 12/30/2021 22:9:34.93
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
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
   public class gx00i0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00i0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00i0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_palmacenid )
      {
         this.AV13palmacenid = 0 ;
         executePrivate();
         aP0_palmacenid=this.AV13palmacenid;
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
               AV6calmacenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 18, 0)));
               AV7cempleadosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cempleadosid), 9, 0)));
               AV8calmacendsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacendsc", AV8calmacendsc);
               AV9calmacendireccion = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calmacendireccion", AV9calmacendireccion);
               AV10calmacencolonia = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10calmacencolonia", AV10calmacencolonia);
               AV11calmacenmunicipio = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11calmacenmunicipio", AV11calmacenmunicipio);
               AV12calamcenestado = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12calamcenestado", AV12calamcenestado);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
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
               AV13palmacenid = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 18, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA0L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0L2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202112302293499");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00i0.aspx") + "?" + UrlEncode("" +AV13palmacenid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6calmacenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cempleadosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENDSC", AV8calmacendsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENDIRECCION", AV9calmacendireccion);
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENCOLONIA", AV10calmacencolonia);
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENMUNICIPIO", AV11calmacenmunicipio);
         GxWebStd.gx_hidden_field( context, "GXH_vCALAMCENESTADO", AV12calamcenestado);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13palmacenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENIDFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacenidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSIDFILTERCONTAINER_Class", StringUtil.RTrim( divEmpleadosidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENDSCFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacendscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENDIRECCIONFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacendireccionfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENCOLONIAFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacencoloniafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENMUNICIPIOFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacenmunicipiofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALAMCENESTADOFILTERCONTAINER_Class", StringUtil.RTrim( divAlamcenestadofiltercontainer_Class));
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
            WE0L2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0L2( ) ;
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
         return formatLink("gx00i0.aspx") + "?" + UrlEncode("" +AV13palmacenid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00I0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List almacen" ;
      }

      protected void WB0L0( )
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
            GxWebStd.gx_div_start( context, divAlmacenidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacenidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacenidfilter_Internalname, "almacenid", "", "", lblLblalmacenidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6calmacenid), 18, 0, ",", "")), ((edtavCalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6calmacenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6calmacenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacenid_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacenid_Visible, edtavCalmacenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divEmpleadosidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpleadosidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempleadosidfilter_Internalname, "empleadosid", "", "", lblLblempleadosidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempleadosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cempleadosid), 9, 0, ",", "")), ((edtavCempleadosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cempleadosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cempleadosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempleadosid_Jsonclick, 0, "Attribute", "", "", "", edtavCempleadosid_Visible, edtavCempleadosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divAlmacendscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacendscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacendscfilter_Internalname, "almacendsc", "", "", lblLblalmacendscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacendsc_Internalname, "almacendsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacendsc_Internalname, AV8calmacendsc, StringUtil.RTrim( context.localUtil.Format( AV8calmacendsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacendsc_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacendsc_Visible, edtavCalmacendsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divAlmacendireccionfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacendireccionfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacendireccionfilter_Internalname, "almacendireccion", "", "", lblLblalmacendireccionfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacendireccion_Internalname, "almacendireccion", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacendireccion_Internalname, AV9calmacendireccion, StringUtil.RTrim( context.localUtil.Format( AV9calmacendireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacendireccion_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacendireccion_Visible, edtavCalmacendireccion_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divAlmacencoloniafiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacencoloniafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacencoloniafilter_Internalname, "almacencolonia", "", "", lblLblalmacencoloniafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacencolonia_Internalname, "almacencolonia", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacencolonia_Internalname, AV10calmacencolonia, StringUtil.RTrim( context.localUtil.Format( AV10calmacencolonia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacencolonia_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacencolonia_Visible, edtavCalmacencolonia_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divAlmacenmunicipiofiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlmacenmunicipiofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalmacenmunicipiofilter_Internalname, "almacenmunicipio", "", "", lblLblalmacenmunicipiofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacenmunicipio_Internalname, "almacenmunicipio", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacenmunicipio_Internalname, AV11calmacenmunicipio, StringUtil.RTrim( context.localUtil.Format( AV11calmacenmunicipio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacenmunicipio_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacenmunicipio_Visible, edtavCalmacenmunicipio_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_div_start( context, divAlamcenestadofiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlamcenestadofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalamcenestadofilter_Internalname, "alamcenestado", "", "", lblLblalamcenestadofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e170l1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00I0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalamcenestado_Internalname, "alamcenestado", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalamcenestado_Internalname, AV12calamcenestado, StringUtil.RTrim( context.localUtil.Format( AV12calamcenestado, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalamcenestado_Jsonclick, 0, "Attribute", "", "", "", edtavCalamcenestado_Visible, edtavCalamcenestado_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00I0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e180l1_client"+"'", TempTags, "", 2, "HLP_Gx00I0.htm");
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
               context.SendWebValue( "articuloid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "empleadosid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "almacencolonia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "alamcencodigopostal") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "almacentelefono") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A145almacencolonia);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A148alamcencodigopostal);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A149almacentelefono);
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00I0.htm");
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

      protected void START0L2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List almacen", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0L0( ) ;
      }

      protected void WS0L2( )
      {
         START0L2( ) ;
         EVT0L2( ) ;
      }

      protected void EVT0L2( )
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
                              A19almacenid = (long)(context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", "."));
                              A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
                              n13empleadosid = false;
                              A145almacencolonia = cgiGet( edtalmacencolonia_Internalname);
                              n145almacencolonia = false;
                              A148alamcencodigopostal = cgiGet( edtalamcencodigopostal_Internalname);
                              n148alamcencodigopostal = false;
                              A149almacentelefono = cgiGet( edtalmacentelefono_Internalname);
                              n149almacentelefono = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E190L2 */
                                    E190L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E200L2 */
                                    E200L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Calmacenid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALMACENID"), ",", ".") != Convert.ToDecimal( AV6calmacenid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cempleadosid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSID"), ",", ".") != Convert.ToDecimal( AV7cempleadosid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calmacendsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENDSC"), AV8calmacendsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calmacendireccion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENDIRECCION"), AV9calmacendireccion) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calmacencolonia Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENCOLONIA"), AV10calmacencolonia) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calmacenmunicipio Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENMUNICIPIO"), AV11calmacenmunicipio) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calamcenestado Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCALAMCENESTADO"), AV12calamcenestado) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E210L2 */
                                          E210L2 ();
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

      protected void WE0L2( )
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

      protected void PA0L2( )
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
                                        long AV6calmacenid ,
                                        int AV7cempleadosid ,
                                        String AV8calmacendsc ,
                                        String AV9calmacendireccion ,
                                        String AV10calmacencolonia ,
                                        String AV11calmacenmunicipio ,
                                        String AV12calamcenestado )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF0L2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ALMACENCOLONIA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A145almacencolonia, ""))));
         GxWebStd.gx_hidden_field( context, "ALMACENCOLONIA", A145almacencolonia);
         GxWebStd.gx_hidden_field( context, "gxhash_ALAMCENCODIGOPOSTAL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A148alamcencodigopostal, ""))));
         GxWebStd.gx_hidden_field( context, "ALAMCENCODIGOPOSTAL", A148alamcencodigopostal);
         GxWebStd.gx_hidden_field( context, "gxhash_ALMACENTELEFONO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A149almacentelefono, ""))));
         GxWebStd.gx_hidden_field( context, "ALMACENTELEFONO", A149almacentelefono);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0L2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0L2( )
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
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = (int)(((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1));
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cempleadosid ,
                                                 AV8calmacendsc ,
                                                 AV9calmacendireccion ,
                                                 AV10calmacencolonia ,
                                                 AV11calmacenmunicipio ,
                                                 AV12calamcenestado ,
                                                 A13empleadosid ,
                                                 A143almacendsc ,
                                                 A144almacendireccion ,
                                                 A145almacencolonia ,
                                                 A146almacenmunicipio ,
                                                 A147alamcenestado ,
                                                 AV6calmacenid },
                                                 new int[] {
                                                 TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            });
            lV8calmacendsc = StringUtil.Concat( StringUtil.RTrim( AV8calmacendsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacendsc", AV8calmacendsc);
            lV9calmacendireccion = StringUtil.Concat( StringUtil.RTrim( AV9calmacendireccion), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calmacendireccion", AV9calmacendireccion);
            lV10calmacencolonia = StringUtil.Concat( StringUtil.RTrim( AV10calmacencolonia), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10calmacencolonia", AV10calmacencolonia);
            lV11calmacenmunicipio = StringUtil.Concat( StringUtil.RTrim( AV11calmacenmunicipio), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11calmacenmunicipio", AV11calmacenmunicipio);
            lV12calamcenestado = StringUtil.Concat( StringUtil.RTrim( AV12calamcenestado), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12calamcenestado", AV12calamcenestado);
            /* Using cursor H000L2 */
            pr_default.execute(0, new Object[] {AV6calmacenid, AV7cempleadosid, lV8calmacendsc, lV9calmacendireccion, lV10calmacencolonia, lV11calmacenmunicipio, lV12calamcenestado, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A147alamcenestado = H000L2_A147alamcenestado[0];
               n147alamcenestado = H000L2_n147alamcenestado[0];
               A146almacenmunicipio = H000L2_A146almacenmunicipio[0];
               n146almacenmunicipio = H000L2_n146almacenmunicipio[0];
               A144almacendireccion = H000L2_A144almacendireccion[0];
               n144almacendireccion = H000L2_n144almacendireccion[0];
               A143almacendsc = H000L2_A143almacendsc[0];
               n143almacendsc = H000L2_n143almacendsc[0];
               A149almacentelefono = H000L2_A149almacentelefono[0];
               n149almacentelefono = H000L2_n149almacentelefono[0];
               A148alamcencodigopostal = H000L2_A148alamcencodigopostal[0];
               n148alamcencodigopostal = H000L2_n148alamcencodigopostal[0];
               A145almacencolonia = H000L2_A145almacencolonia[0];
               n145almacencolonia = H000L2_n145almacencolonia[0];
               A13empleadosid = H000L2_A13empleadosid[0];
               n13empleadosid = H000L2_n13empleadosid[0];
               A19almacenid = H000L2_A19almacenid[0];
               /* Execute user event: E200L2 */
               E200L2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB0L0( ) ;
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
                                              AV7cempleadosid ,
                                              AV8calmacendsc ,
                                              AV9calmacendireccion ,
                                              AV10calmacencolonia ,
                                              AV11calmacenmunicipio ,
                                              AV12calamcenestado ,
                                              A13empleadosid ,
                                              A143almacendsc ,
                                              A144almacendireccion ,
                                              A145almacencolonia ,
                                              A146almacenmunicipio ,
                                              A147alamcenestado ,
                                              AV6calmacenid },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         });
         lV8calmacendsc = StringUtil.Concat( StringUtil.RTrim( AV8calmacendsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacendsc", AV8calmacendsc);
         lV9calmacendireccion = StringUtil.Concat( StringUtil.RTrim( AV9calmacendireccion), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calmacendireccion", AV9calmacendireccion);
         lV10calmacencolonia = StringUtil.Concat( StringUtil.RTrim( AV10calmacencolonia), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10calmacencolonia", AV10calmacencolonia);
         lV11calmacenmunicipio = StringUtil.Concat( StringUtil.RTrim( AV11calmacenmunicipio), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11calmacenmunicipio", AV11calmacenmunicipio);
         lV12calamcenestado = StringUtil.Concat( StringUtil.RTrim( AV12calamcenestado), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12calamcenestado", AV12calamcenestado);
         /* Using cursor H000L3 */
         pr_default.execute(1, new Object[] {AV6calmacenid, AV7cempleadosid, lV8calmacendsc, lV9calmacendireccion, lV10calmacencolonia, lV11calmacenmunicipio, lV12calamcenestado});
         GRID1_nRecordCount = H000L3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7cempleadosid, AV8calmacendsc, AV9calmacendireccion, AV10calmacencolonia, AV11calmacenmunicipio, AV12calamcenestado) ;
         }
         return (int)(0) ;
      }

      protected void STRUP0L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E190L2 */
         E190L2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCALMACENID");
               GX_FocusControl = edtavCalmacenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6calmacenid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 18, 0)));
            }
            else
            {
               AV6calmacenid = (long)(context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPLEADOSID");
               GX_FocusControl = edtavCempleadosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cempleadosid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cempleadosid), 9, 0)));
            }
            else
            {
               AV7cempleadosid = (int)(context.localUtil.CToN( cgiGet( edtavCempleadosid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cempleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cempleadosid), 9, 0)));
            }
            AV8calmacendsc = cgiGet( edtavCalmacendsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8calmacendsc", AV8calmacendsc);
            AV9calmacendireccion = cgiGet( edtavCalmacendireccion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calmacendireccion", AV9calmacendireccion);
            AV10calmacencolonia = cgiGet( edtavCalmacencolonia_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10calmacencolonia", AV10calmacencolonia);
            AV11calmacenmunicipio = cgiGet( edtavCalmacenmunicipio_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11calmacenmunicipio", AV11calmacenmunicipio);
            AV12calamcenestado = cgiGet( edtavCalamcenestado_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12calamcenestado", AV12calamcenestado);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALMACENID"), ",", ".") != Convert.ToDecimal( AV6calmacenid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPLEADOSID"), ",", ".") != Convert.ToDecimal( AV7cempleadosid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENDSC"), AV8calmacendsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENDIRECCION"), AV9calmacendireccion) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENCOLONIA"), AV10calmacencolonia) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCALMACENMUNICIPIO"), AV11calmacenmunicipio) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCALAMCENESTADO"), AV12calamcenestado) != 0 )
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
         /* Execute user event: E190L2 */
         E190L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E190L2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "almacen", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E200L2( )
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
         /* Execute user event: E210L2 */
         E210L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E210L2( )
      {
         /* Enter Routine */
         AV13palmacenid = A19almacenid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV13palmacenid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13palmacenid = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 18, 0)));
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
         PA0L2( ) ;
         WS0L2( ) ;
         WE0L2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2284430");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20211230229361");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00i0.js", "?20211230229361");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_idx;
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_84_idx;
         edtalmacencolonia_Internalname = "ALMACENCOLONIA_"+sGXsfl_84_idx;
         edtalamcencodigopostal_Internalname = "ALAMCENCODIGOPOSTAL_"+sGXsfl_84_idx;
         edtalmacentelefono_Internalname = "ALMACENTELEFONO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_fel_idx;
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_84_fel_idx;
         edtalmacencolonia_Internalname = "ALMACENCOLONIA_"+sGXsfl_84_fel_idx;
         edtalamcencodigopostal_Internalname = "ALAMCENCODIGOPOSTAL_"+sGXsfl_84_fel_idx;
         edtalmacentelefono_Internalname = "ALMACENTELEFONO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB0L0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalmacenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalmacenid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalmacencolonia_Internalname,(String)A145almacencolonia,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalmacencolonia_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalamcencodigopostal_Internalname,(String)A148alamcencodigopostal,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalamcencodigopostal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalmacentelefono_Internalname,(String)A149almacentelefono,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalmacentelefono_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ALMACENCOLONIA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A145almacencolonia, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_ALAMCENCODIGOPOSTAL"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A148alamcencodigopostal, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_ALMACENTELEFONO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A149almacentelefono, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
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
         lblLblalmacendscfilter_Internalname = "LBLALMACENDSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalmacendsc_Internalname = "vCALMACENDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlmacendscfiltercontainer_Internalname = "ALMACENDSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalmacendireccionfilter_Internalname = "LBLALMACENDIRECCIONFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalmacendireccion_Internalname = "vCALMACENDIRECCION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlmacendireccionfiltercontainer_Internalname = "ALMACENDIRECCIONFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalmacencoloniafilter_Internalname = "LBLALMACENCOLONIAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalmacencolonia_Internalname = "vCALMACENCOLONIA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlmacencoloniafiltercontainer_Internalname = "ALMACENCOLONIAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalmacenmunicipiofilter_Internalname = "LBLALMACENMUNICIPIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalmacenmunicipio_Internalname = "vCALMACENMUNICIPIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlmacenmunicipiofiltercontainer_Internalname = "ALMACENMUNICIPIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalamcenestadofilter_Internalname = "LBLALAMCENESTADOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalamcenestado_Internalname = "vCALAMCENESTADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlamcenestadofiltercontainer_Internalname = "ALAMCENESTADOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtalmacenid_Internalname = "ALMACENID";
         edtempleadosid_Internalname = "EMPLEADOSID";
         edtalmacencolonia_Internalname = "ALMACENCOLONIA";
         edtalamcencodigopostal_Internalname = "ALAMCENCODIGOPOSTAL";
         edtalmacentelefono_Internalname = "ALMACENTELEFONO";
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
         edtalmacentelefono_Jsonclick = "";
         edtalamcencodigopostal_Jsonclick = "";
         edtalmacencolonia_Jsonclick = "";
         edtempleadosid_Jsonclick = "";
         edtalmacenid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCalamcenestado_Jsonclick = "";
         edtavCalamcenestado_Enabled = 1;
         edtavCalamcenestado_Visible = 1;
         edtavCalmacenmunicipio_Jsonclick = "";
         edtavCalmacenmunicipio_Enabled = 1;
         edtavCalmacenmunicipio_Visible = 1;
         edtavCalmacencolonia_Jsonclick = "";
         edtavCalmacencolonia_Enabled = 1;
         edtavCalmacencolonia_Visible = 1;
         edtavCalmacendireccion_Jsonclick = "";
         edtavCalmacendireccion_Enabled = 1;
         edtavCalmacendireccion_Visible = 1;
         edtavCalmacendsc_Jsonclick = "";
         edtavCalmacendsc_Enabled = 1;
         edtavCalmacendsc_Visible = 1;
         edtavCempleadosid_Jsonclick = "";
         edtavCempleadosid_Enabled = 1;
         edtavCempleadosid_Visible = 1;
         edtavCalmacenid_Jsonclick = "";
         edtavCalmacenid_Enabled = 1;
         edtavCalmacenid_Visible = 1;
         divAlamcenestadofiltercontainer_Class = "AdvancedContainerItem";
         divAlmacenmunicipiofiltercontainer_Class = "AdvancedContainerItem";
         divAlmacencoloniafiltercontainer_Class = "AdvancedContainerItem";
         divAlmacendireccionfiltercontainer_Class = "AdvancedContainerItem";
         divAlmacendscfiltercontainer_Class = "AdvancedContainerItem";
         divEmpleadosidfiltercontainer_Class = "AdvancedContainerItem";
         divAlmacenidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List almacen";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacendsc',fld:'vCALMACENDSC',pic:'',nv:''},{av:'AV9calmacendireccion',fld:'vCALMACENDIRECCION',pic:'',nv:''},{av:'AV10calmacencolonia',fld:'vCALMACENCOLONIA',pic:'',nv:''},{av:'AV11calmacenmunicipio',fld:'vCALMACENMUNICIPIO',pic:'',nv:''},{av:'AV12calamcenestado',fld:'vCALAMCENESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E180L1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLALMACENIDFILTER.CLICK","{handler:'E110L1',iparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacenid_Visible',ctrl:'vCALMACENID',prop:'Visible'}]}");
         setEventMetadata("LBLEMPLEADOSIDFILTER.CLICK","{handler:'E120L1',iparms:[{av:'divEmpleadosidfiltercontainer_Class',ctrl:'EMPLEADOSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEmpleadosidfiltercontainer_Class',ctrl:'EMPLEADOSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCempleadosid_Visible',ctrl:'vCEMPLEADOSID',prop:'Visible'}]}");
         setEventMetadata("LBLALMACENDSCFILTER.CLICK","{handler:'E130L1',iparms:[{av:'divAlmacendscfiltercontainer_Class',ctrl:'ALMACENDSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacendscfiltercontainer_Class',ctrl:'ALMACENDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacendsc_Visible',ctrl:'vCALMACENDSC',prop:'Visible'}]}");
         setEventMetadata("LBLALMACENDIRECCIONFILTER.CLICK","{handler:'E140L1',iparms:[{av:'divAlmacendireccionfiltercontainer_Class',ctrl:'ALMACENDIRECCIONFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacendireccionfiltercontainer_Class',ctrl:'ALMACENDIRECCIONFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacendireccion_Visible',ctrl:'vCALMACENDIRECCION',prop:'Visible'}]}");
         setEventMetadata("LBLALMACENCOLONIAFILTER.CLICK","{handler:'E150L1',iparms:[{av:'divAlmacencoloniafiltercontainer_Class',ctrl:'ALMACENCOLONIAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacencoloniafiltercontainer_Class',ctrl:'ALMACENCOLONIAFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacencolonia_Visible',ctrl:'vCALMACENCOLONIA',prop:'Visible'}]}");
         setEventMetadata("LBLALMACENMUNICIPIOFILTER.CLICK","{handler:'E160L1',iparms:[{av:'divAlmacenmunicipiofiltercontainer_Class',ctrl:'ALMACENMUNICIPIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacenmunicipiofiltercontainer_Class',ctrl:'ALMACENMUNICIPIOFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacenmunicipio_Visible',ctrl:'vCALMACENMUNICIPIO',prop:'Visible'}]}");
         setEventMetadata("LBLALAMCENESTADOFILTER.CLICK","{handler:'E170L1',iparms:[{av:'divAlamcenestadofiltercontainer_Class',ctrl:'ALAMCENESTADOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlamcenestadofiltercontainer_Class',ctrl:'ALAMCENESTADOFILTERCONTAINER',prop:'Class'},{av:'edtavCalamcenestado_Visible',ctrl:'vCALAMCENESTADO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E210L2',iparms:[{av:'A19almacenid',fld:'ALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13palmacenid',fld:'vPALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacendsc',fld:'vCALMACENDSC',pic:'',nv:''},{av:'AV9calmacendireccion',fld:'vCALMACENDIRECCION',pic:'',nv:''},{av:'AV10calmacencolonia',fld:'vCALMACENCOLONIA',pic:'',nv:''},{av:'AV11calmacenmunicipio',fld:'vCALMACENMUNICIPIO',pic:'',nv:''},{av:'AV12calamcenestado',fld:'vCALAMCENESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacendsc',fld:'vCALMACENDSC',pic:'',nv:''},{av:'AV9calmacendireccion',fld:'vCALMACENDIRECCION',pic:'',nv:''},{av:'AV10calmacencolonia',fld:'vCALMACENCOLONIA',pic:'',nv:''},{av:'AV11calmacenmunicipio',fld:'vCALMACENMUNICIPIO',pic:'',nv:''},{av:'AV12calamcenestado',fld:'vCALAMCENESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacendsc',fld:'vCALMACENDSC',pic:'',nv:''},{av:'AV9calmacendireccion',fld:'vCALMACENDIRECCION',pic:'',nv:''},{av:'AV10calmacencolonia',fld:'vCALMACENCOLONIA',pic:'',nv:''},{av:'AV11calmacenmunicipio',fld:'vCALMACENMUNICIPIO',pic:'',nv:''},{av:'AV12calamcenestado',fld:'vCALAMCENESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cempleadosid',fld:'vCEMPLEADOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8calmacendsc',fld:'vCALMACENDSC',pic:'',nv:''},{av:'AV9calmacendireccion',fld:'vCALMACENDIRECCION',pic:'',nv:''},{av:'AV10calmacencolonia',fld:'vCALMACENCOLONIA',pic:'',nv:''},{av:'AV11calmacenmunicipio',fld:'vCALMACENMUNICIPIO',pic:'',nv:''},{av:'AV12calamcenestado',fld:'vCALAMCENESTADO',pic:'',nv:''}],oparms:[]}");
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
         AV8calmacendsc = "";
         AV9calmacendireccion = "";
         AV10calmacencolonia = "";
         AV11calmacenmunicipio = "";
         AV12calamcenestado = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblalmacenidfilter_Jsonclick = "";
         TempTags = "";
         lblLblempleadosidfilter_Jsonclick = "";
         lblLblalmacendscfilter_Jsonclick = "";
         lblLblalmacendireccionfilter_Jsonclick = "";
         lblLblalmacencoloniafilter_Jsonclick = "";
         lblLblalmacenmunicipiofilter_Jsonclick = "";
         lblLblalamcenestadofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A145almacencolonia = "";
         A148alamcencodigopostal = "";
         A149almacentelefono = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV8calmacendsc = "";
         lV9calmacendireccion = "";
         lV10calmacencolonia = "";
         lV11calmacenmunicipio = "";
         lV12calamcenestado = "";
         A143almacendsc = "";
         A144almacendireccion = "";
         A146almacenmunicipio = "";
         A147alamcenestado = "";
         H000L2_A147alamcenestado = new String[] {""} ;
         H000L2_n147alamcenestado = new bool[] {false} ;
         H000L2_A146almacenmunicipio = new String[] {""} ;
         H000L2_n146almacenmunicipio = new bool[] {false} ;
         H000L2_A144almacendireccion = new String[] {""} ;
         H000L2_n144almacendireccion = new bool[] {false} ;
         H000L2_A143almacendsc = new String[] {""} ;
         H000L2_n143almacendsc = new bool[] {false} ;
         H000L2_A149almacentelefono = new String[] {""} ;
         H000L2_n149almacentelefono = new bool[] {false} ;
         H000L2_A148alamcencodigopostal = new String[] {""} ;
         H000L2_n148alamcencodigopostal = new bool[] {false} ;
         H000L2_A145almacencolonia = new String[] {""} ;
         H000L2_n145almacencolonia = new bool[] {false} ;
         H000L2_A13empleadosid = new int[1] ;
         H000L2_n13empleadosid = new bool[] {false} ;
         H000L2_A19almacenid = new long[1] ;
         H000L3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00i0__default(),
            new Object[][] {
                new Object[] {
               H000L2_A147alamcenestado, H000L2_n147alamcenestado, H000L2_A146almacenmunicipio, H000L2_n146almacenmunicipio, H000L2_A144almacendireccion, H000L2_n144almacendireccion, H000L2_A143almacendsc, H000L2_n143almacendsc, H000L2_A149almacentelefono, H000L2_n149almacentelefono,
               H000L2_A148alamcencodigopostal, H000L2_n148alamcencodigopostal, H000L2_A145almacencolonia, H000L2_n145almacencolonia, H000L2_A13empleadosid, H000L2_n13empleadosid, H000L2_A19almacenid
               }
               , new Object[] {
               H000L3_AGRID1_nRecordCount
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
      private int AV7cempleadosid ;
      private int edtavCalmacenid_Enabled ;
      private int edtavCalmacenid_Visible ;
      private int edtavCempleadosid_Enabled ;
      private int edtavCempleadosid_Visible ;
      private int edtavCalmacendsc_Visible ;
      private int edtavCalmacendsc_Enabled ;
      private int edtavCalmacendireccion_Visible ;
      private int edtavCalmacendireccion_Enabled ;
      private int edtavCalmacencolonia_Visible ;
      private int edtavCalmacencolonia_Enabled ;
      private int edtavCalmacenmunicipio_Visible ;
      private int edtavCalmacenmunicipio_Enabled ;
      private int edtavCalamcenestado_Visible ;
      private int edtavCalamcenestado_Enabled ;
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
      private long AV6calmacenid ;
      private long AV13palmacenid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A19almacenid ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divAlmacenidfiltercontainer_Class ;
      private String divEmpleadosidfiltercontainer_Class ;
      private String divAlmacendscfiltercontainer_Class ;
      private String divAlmacendireccionfiltercontainer_Class ;
      private String divAlmacencoloniafiltercontainer_Class ;
      private String divAlmacenmunicipiofiltercontainer_Class ;
      private String divAlamcenestadofiltercontainer_Class ;
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
      private String divAlmacenidfiltercontainer_Internalname ;
      private String lblLblalmacenidfilter_Internalname ;
      private String lblLblalmacenidfilter_Jsonclick ;
      private String edtavCalmacenid_Internalname ;
      private String TempTags ;
      private String edtavCalmacenid_Jsonclick ;
      private String divEmpleadosidfiltercontainer_Internalname ;
      private String lblLblempleadosidfilter_Internalname ;
      private String lblLblempleadosidfilter_Jsonclick ;
      private String edtavCempleadosid_Internalname ;
      private String edtavCempleadosid_Jsonclick ;
      private String divAlmacendscfiltercontainer_Internalname ;
      private String lblLblalmacendscfilter_Internalname ;
      private String lblLblalmacendscfilter_Jsonclick ;
      private String edtavCalmacendsc_Internalname ;
      private String edtavCalmacendsc_Jsonclick ;
      private String divAlmacendireccionfiltercontainer_Internalname ;
      private String lblLblalmacendireccionfilter_Internalname ;
      private String lblLblalmacendireccionfilter_Jsonclick ;
      private String edtavCalmacendireccion_Internalname ;
      private String edtavCalmacendireccion_Jsonclick ;
      private String divAlmacencoloniafiltercontainer_Internalname ;
      private String lblLblalmacencoloniafilter_Internalname ;
      private String lblLblalmacencoloniafilter_Jsonclick ;
      private String edtavCalmacencolonia_Internalname ;
      private String edtavCalmacencolonia_Jsonclick ;
      private String divAlmacenmunicipiofiltercontainer_Internalname ;
      private String lblLblalmacenmunicipiofilter_Internalname ;
      private String lblLblalmacenmunicipiofilter_Jsonclick ;
      private String edtavCalmacenmunicipio_Internalname ;
      private String edtavCalmacenmunicipio_Jsonclick ;
      private String divAlamcenestadofiltercontainer_Internalname ;
      private String lblLblalamcenestadofilter_Internalname ;
      private String lblLblalamcenestadofilter_Jsonclick ;
      private String edtavCalamcenestado_Internalname ;
      private String edtavCalamcenestado_Jsonclick ;
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
      private String edtalmacenid_Internalname ;
      private String edtempleadosid_Internalname ;
      private String edtalmacencolonia_Internalname ;
      private String edtalamcencodigopostal_Internalname ;
      private String edtalmacentelefono_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtalmacenid_Jsonclick ;
      private String edtempleadosid_Jsonclick ;
      private String edtalmacencolonia_Jsonclick ;
      private String edtalamcencodigopostal_Jsonclick ;
      private String edtalmacentelefono_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n13empleadosid ;
      private bool n145almacencolonia ;
      private bool n148alamcencodigopostal ;
      private bool n149almacentelefono ;
      private bool n147alamcenestado ;
      private bool n146almacenmunicipio ;
      private bool n144almacendireccion ;
      private bool n143almacendsc ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8calmacendsc ;
      private String AV9calmacendireccion ;
      private String AV10calmacencolonia ;
      private String AV11calmacenmunicipio ;
      private String AV12calamcenestado ;
      private String A145almacencolonia ;
      private String A148alamcencodigopostal ;
      private String A149almacentelefono ;
      private String AV17Linkselection_GXI ;
      private String lV8calmacendsc ;
      private String lV9calmacendireccion ;
      private String lV10calmacencolonia ;
      private String lV11calmacenmunicipio ;
      private String lV12calamcenestado ;
      private String A143almacendsc ;
      private String A144almacendireccion ;
      private String A146almacenmunicipio ;
      private String A147alamcenestado ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000L2_A147alamcenestado ;
      private bool[] H000L2_n147alamcenestado ;
      private String[] H000L2_A146almacenmunicipio ;
      private bool[] H000L2_n146almacenmunicipio ;
      private String[] H000L2_A144almacendireccion ;
      private bool[] H000L2_n144almacendireccion ;
      private String[] H000L2_A143almacendsc ;
      private bool[] H000L2_n143almacendsc ;
      private String[] H000L2_A149almacentelefono ;
      private bool[] H000L2_n149almacentelefono ;
      private String[] H000L2_A148alamcencodigopostal ;
      private bool[] H000L2_n148alamcencodigopostal ;
      private String[] H000L2_A145almacencolonia ;
      private bool[] H000L2_n145almacencolonia ;
      private int[] H000L2_A13empleadosid ;
      private bool[] H000L2_n13empleadosid ;
      private long[] H000L2_A19almacenid ;
      private long[] H000L3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_palmacenid ;
      private GXWebForm Form ;
   }

   public class gx00i0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000L2( IGxContext context ,
                                             int AV7cempleadosid ,
                                             String AV8calmacendsc ,
                                             String AV9calmacendireccion ,
                                             String AV10calmacencolonia ,
                                             String AV11calmacenmunicipio ,
                                             String AV12calamcenestado ,
                                             int A13empleadosid ,
                                             String A143almacendsc ,
                                             String A144almacendireccion ,
                                             String A145almacencolonia ,
                                             String A146almacenmunicipio ,
                                             String A147alamcenestado ,
                                             long AV6calmacenid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [12] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [alamcenestado], [almacenmunicipio], [almacendireccion], [almacendsc], [almacentelefono], [alamcencodigopostal], [almacencolonia], [empleadosid], [almacenid]";
         sFromString = " FROM [almacen] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([almacenid] >= @AV6calmacenid)";
         if ( ! (0==AV7cempleadosid) )
         {
            sWhereString = sWhereString + " and ([empleadosid] >= @AV7cempleadosid)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8calmacendsc)) )
         {
            sWhereString = sWhereString + " and ([almacendsc] like @lV8calmacendsc)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9calmacendireccion)) )
         {
            sWhereString = sWhereString + " and ([almacendireccion] like @lV9calmacendireccion)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10calmacencolonia)) )
         {
            sWhereString = sWhereString + " and ([almacencolonia] like @lV10calmacencolonia)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11calmacenmunicipio)) )
         {
            sWhereString = sWhereString + " and ([almacenmunicipio] like @lV11calmacenmunicipio)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12calamcenestado)) )
         {
            sWhereString = sWhereString + " and ([alamcenestado] like @lV12calamcenestado)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [almacenid]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + "" + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000L3( IGxContext context ,
                                             int AV7cempleadosid ,
                                             String AV8calmacendsc ,
                                             String AV9calmacendireccion ,
                                             String AV10calmacencolonia ,
                                             String AV11calmacenmunicipio ,
                                             String AV12calamcenestado ,
                                             int A13empleadosid ,
                                             String A143almacendsc ,
                                             String A144almacendireccion ,
                                             String A145almacencolonia ,
                                             String A146almacenmunicipio ,
                                             String A147alamcenestado ,
                                             long AV6calmacenid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [almacen] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([almacenid] >= @AV6calmacenid)";
         if ( ! (0==AV7cempleadosid) )
         {
            sWhereString = sWhereString + " and ([empleadosid] >= @AV7cempleadosid)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8calmacendsc)) )
         {
            sWhereString = sWhereString + " and ([almacendsc] like @lV8calmacendsc)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9calmacendireccion)) )
         {
            sWhereString = sWhereString + " and ([almacendireccion] like @lV9calmacendireccion)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10calmacencolonia)) )
         {
            sWhereString = sWhereString + " and ([almacencolonia] like @lV10calmacencolonia)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11calmacenmunicipio)) )
         {
            sWhereString = sWhereString + " and ([almacenmunicipio] like @lV11calmacenmunicipio)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12calamcenestado)) )
         {
            sWhereString = sWhereString + " and ([alamcenestado] like @lV12calamcenestado)";
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
                     return conditional_H000L2(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (int)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] );
               case 1 :
                     return conditional_H000L3(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (int)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] );
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
          Object[] prmH000L2 ;
          prmH000L2 = new Object[] {
          new Object[] {"@AV6calmacenid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cempleadosid",SqlDbType.Int,9,0} ,
          new Object[] {"@lV8calmacendsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV9calmacendireccion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV10calmacencolonia",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV11calmacenmunicipio",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV12calamcenestado",SqlDbType.VarChar,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000L3 ;
          prmH000L3 = new Object[] {
          new Object[] {"@AV6calmacenid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cempleadosid",SqlDbType.Int,9,0} ,
          new Object[] {"@lV8calmacendsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV9calmacendireccion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@lV10calmacencolonia",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV11calmacenmunicipio",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV12calamcenestado",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000L2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000L2,11,0,false,false )
             ,new CursorDef("H000L3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000L3,1,0,false,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
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
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}