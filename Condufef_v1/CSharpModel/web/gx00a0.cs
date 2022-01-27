/*
               File: Gx00A0
        Description: Selection List proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:8:3.62
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
   public class gx00a0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00a0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00a0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pproveedoresid )
      {
         this.AV13pproveedoresid = 0 ;
         executePrivate();
         aP0_pproveedoresid=this.AV13pproveedoresid;
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
               AV6cproveedoresid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproveedoresid), 9, 0)));
               AV7cproveedoresnombre = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproveedoresnombre", AV7cproveedoresnombre);
               AV8cproveedoresdireccion = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproveedoresdireccion", AV8cproveedoresdireccion);
               AV9cproveedorescolonia = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cproveedorescolonia", AV9cproveedorescolonia);
               AV10cproveedorescodigopostal = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cproveedorescodigopostal", AV10cproveedorescodigopostal);
               AV11cproveedoresmunicipio = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproveedoresmunicipio", AV11cproveedoresmunicipio);
               AV12cproveedorestado = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproveedorestado", AV12cproveedorestado);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
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
               AV13pproveedoresid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproveedoresid), 9, 0)));
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
         PA202( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START202( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022126208368");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00a0.aspx") + "?" + UrlEncode("" +AV13pproveedoresid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproveedoresid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESNOMBRE", AV7cproveedoresnombre);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESDIRECCION", AV8cproveedoresdireccion);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESCOLONIA", AV9cproveedorescolonia);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESCODIGOPOSTAL", AV10cproveedorescodigopostal);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESMUNICIPIO", AV11cproveedoresmunicipio);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROVEEDORESTADO", AV12cproveedorestado);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pproveedoresid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESIDFILTERCONTAINER_Class", StringUtil.RTrim( divProveedoresidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESNOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divProveedoresnombrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESDIRECCIONFILTERCONTAINER_Class", StringUtil.RTrim( divProveedoresdireccionfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESCOLONIAFILTERCONTAINER_Class", StringUtil.RTrim( divProveedorescoloniafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESCODIGOPOSTALFILTERCONTAINER_Class", StringUtil.RTrim( divProveedorescodigopostalfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESMUNICIPIOFILTERCONTAINER_Class", StringUtil.RTrim( divProveedoresmunicipiofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESTADOFILTERCONTAINER_Class", StringUtil.RTrim( divProveedorestadofiltercontainer_Class));
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
            WE202( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT202( ) ;
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
         return formatLink("gx00a0.aspx") + "?" + UrlEncode("" +AV13pproveedoresid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00A0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List proveedores" ;
      }

      protected void WB200( )
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
            GxWebStd.gx_div_start( context, divProveedoresidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedoresidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedoresidfilter_Internalname, "proveedoresid", "", "", lblLblproveedoresidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedoresid_Internalname, "proveedoresid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedoresid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproveedoresid), 9, 0, ",", "")), ((edtavCproveedoresid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cproveedoresid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cproveedoresid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedoresid_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedoresid_Visible, edtavCproveedoresid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedoresnombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedoresnombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedoresnombrefilter_Internalname, "proveedoresnombre", "", "", lblLblproveedoresnombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedoresnombre_Internalname, "proveedoresnombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedoresnombre_Internalname, AV7cproveedoresnombre, StringUtil.RTrim( context.localUtil.Format( AV7cproveedoresnombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedoresnombre_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedoresnombre_Visible, edtavCproveedoresnombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedoresdireccionfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedoresdireccionfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedoresdireccionfilter_Internalname, "proveedoresdireccion", "", "", lblLblproveedoresdireccionfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedoresdireccion_Internalname, "proveedoresdireccion", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedoresdireccion_Internalname, AV8cproveedoresdireccion, StringUtil.RTrim( context.localUtil.Format( AV8cproveedoresdireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedoresdireccion_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedoresdireccion_Visible, edtavCproveedoresdireccion_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedorescoloniafiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedorescoloniafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedorescoloniafilter_Internalname, "proveedorescolonia", "", "", lblLblproveedorescoloniafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedorescolonia_Internalname, "proveedorescolonia", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedorescolonia_Internalname, AV9cproveedorescolonia, StringUtil.RTrim( context.localUtil.Format( AV9cproveedorescolonia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedorescolonia_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedorescolonia_Visible, edtavCproveedorescolonia_Enabled, 0, "text", "", 25, "chr", 1, "row", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedorescodigopostalfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedorescodigopostalfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedorescodigopostalfilter_Internalname, "proveedorescodigopostal", "", "", lblLblproveedorescodigopostalfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedorescodigopostal_Internalname, "proveedorescodigopostal", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedorescodigopostal_Internalname, AV10cproveedorescodigopostal, StringUtil.RTrim( context.localUtil.Format( AV10cproveedorescodigopostal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedorescodigopostal_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedorescodigopostal_Visible, edtavCproveedorescodigopostal_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedoresmunicipiofiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedoresmunicipiofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedoresmunicipiofilter_Internalname, "proveedoresmunicipio", "", "", lblLblproveedoresmunicipiofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedoresmunicipio_Internalname, "proveedoresmunicipio", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedoresmunicipio_Internalname, AV11cproveedoresmunicipio, StringUtil.RTrim( context.localUtil.Format( AV11cproveedoresmunicipio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedoresmunicipio_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedoresmunicipio_Visible, edtavCproveedoresmunicipio_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_div_start( context, divProveedorestadofiltercontainer_Internalname, 1, 0, "px", 0, "px", divProveedorestadofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproveedorestadofilter_Internalname, "proveedorestado", "", "", lblLblproveedorestadofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00A0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproveedorestado_Internalname, "proveedorestado", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproveedorestado_Internalname, AV12cproveedorestado, StringUtil.RTrim( context.localUtil.Format( AV12cproveedorestado, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproveedorestado_Jsonclick, 0, "Attribute", "", "", "", edtavCproveedorestado_Visible, edtavCproveedorestado_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00A0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18201_client"+"'", TempTags, "", 2, "HLP_Gx00A0.htm");
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
               context.SendWebValue( "proveedoresid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "proveedoresnombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "proveedorescolonia") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A126proveedoresnombre);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtproveedoresnombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A128proveedorescolonia);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00A0.htm");
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

      protected void START202( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List proveedores", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP200( ) ;
      }

      protected void WS202( )
      {
         START202( ) ;
         EVT202( ) ;
      }

      protected void EVT202( )
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
                              A2proveedoresid = (int)(context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", "."));
                              A126proveedoresnombre = cgiGet( edtproveedoresnombre_Internalname);
                              n126proveedoresnombre = false;
                              A128proveedorescolonia = cgiGet( edtproveedorescolonia_Internalname);
                              n128proveedorescolonia = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19202 */
                                    E19202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20202 */
                                    E20202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cproveedoresid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPROVEEDORESID"), ",", ".") != Convert.ToDecimal( AV6cproveedoresid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedoresnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESNOMBRE"), AV7cproveedoresnombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedoresdireccion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESDIRECCION"), AV8cproveedoresdireccion) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedorescolonia Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESCOLONIA"), AV9cproveedorescolonia) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedorescodigopostal Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESCODIGOPOSTAL"), AV10cproveedorescodigopostal) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedoresmunicipio Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESMUNICIPIO"), AV11cproveedoresmunicipio) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproveedorestado Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESTADO"), AV12cproveedorestado) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21202 */
                                          E21202 ();
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

      protected void WE202( )
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

      protected void PA202( )
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
                                        int AV6cproveedoresid ,
                                        String AV7cproveedoresnombre ,
                                        String AV8cproveedoresdireccion ,
                                        String AV9cproveedorescolonia ,
                                        String AV10cproveedorescodigopostal ,
                                        String AV11cproveedoresmunicipio ,
                                        String AV12cproveedorestado )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF202( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESNOMBRE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESNOMBRE", A126proveedoresnombre);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCOLONIA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESCOLONIA", A128proveedorescolonia);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF202( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF202( )
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
                                                 AV7cproveedoresnombre ,
                                                 AV8cproveedoresdireccion ,
                                                 AV9cproveedorescolonia ,
                                                 AV10cproveedorescodigopostal ,
                                                 AV11cproveedoresmunicipio ,
                                                 AV12cproveedorestado ,
                                                 A126proveedoresnombre ,
                                                 A127proveedoresdireccion ,
                                                 A128proveedorescolonia ,
                                                 A129proveedorescodigopostal ,
                                                 A130proveedoresmunicipio ,
                                                 A131proveedorestado ,
                                                 AV6cproveedoresid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV7cproveedoresnombre = StringUtil.Concat( StringUtil.RTrim( AV7cproveedoresnombre), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproveedoresnombre", AV7cproveedoresnombre);
            lV8cproveedoresdireccion = StringUtil.Concat( StringUtil.RTrim( AV8cproveedoresdireccion), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproveedoresdireccion", AV8cproveedoresdireccion);
            lV9cproveedorescolonia = StringUtil.Concat( StringUtil.RTrim( AV9cproveedorescolonia), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cproveedorescolonia", AV9cproveedorescolonia);
            lV10cproveedorescodigopostal = StringUtil.Concat( StringUtil.RTrim( AV10cproveedorescodigopostal), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cproveedorescodigopostal", AV10cproveedorescodigopostal);
            lV11cproveedoresmunicipio = StringUtil.Concat( StringUtil.RTrim( AV11cproveedoresmunicipio), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproveedoresmunicipio", AV11cproveedoresmunicipio);
            lV12cproveedorestado = StringUtil.Concat( StringUtil.RTrim( AV12cproveedorestado), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproveedorestado", AV12cproveedorestado);
            /* Using cursor H00202 */
            pr_default.execute(0, new Object[] {AV6cproveedoresid, lV7cproveedoresnombre, lV8cproveedoresdireccion, lV9cproveedorescolonia, lV10cproveedorescodigopostal, lV11cproveedoresmunicipio, lV12cproveedorestado, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A131proveedorestado = H00202_A131proveedorestado[0];
               n131proveedorestado = H00202_n131proveedorestado[0];
               A130proveedoresmunicipio = H00202_A130proveedoresmunicipio[0];
               n130proveedoresmunicipio = H00202_n130proveedoresmunicipio[0];
               A129proveedorescodigopostal = H00202_A129proveedorescodigopostal[0];
               n129proveedorescodigopostal = H00202_n129proveedorescodigopostal[0];
               A127proveedoresdireccion = H00202_A127proveedoresdireccion[0];
               n127proveedoresdireccion = H00202_n127proveedoresdireccion[0];
               A128proveedorescolonia = H00202_A128proveedorescolonia[0];
               n128proveedorescolonia = H00202_n128proveedorescolonia[0];
               A126proveedoresnombre = H00202_A126proveedoresnombre[0];
               n126proveedoresnombre = H00202_n126proveedoresnombre[0];
               A2proveedoresid = H00202_A2proveedoresid[0];
               /* Execute user event: E20202 */
               E20202 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB200( ) ;
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
                                              AV7cproveedoresnombre ,
                                              AV8cproveedoresdireccion ,
                                              AV9cproveedorescolonia ,
                                              AV10cproveedorescodigopostal ,
                                              AV11cproveedoresmunicipio ,
                                              AV12cproveedorestado ,
                                              A126proveedoresnombre ,
                                              A127proveedoresdireccion ,
                                              A128proveedorescolonia ,
                                              A129proveedorescodigopostal ,
                                              A130proveedoresmunicipio ,
                                              A131proveedorestado ,
                                              AV6cproveedoresid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV7cproveedoresnombre = StringUtil.Concat( StringUtil.RTrim( AV7cproveedoresnombre), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproveedoresnombre", AV7cproveedoresnombre);
         lV8cproveedoresdireccion = StringUtil.Concat( StringUtil.RTrim( AV8cproveedoresdireccion), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproveedoresdireccion", AV8cproveedoresdireccion);
         lV9cproveedorescolonia = StringUtil.Concat( StringUtil.RTrim( AV9cproveedorescolonia), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cproveedorescolonia", AV9cproveedorescolonia);
         lV10cproveedorescodigopostal = StringUtil.Concat( StringUtil.RTrim( AV10cproveedorescodigopostal), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cproveedorescodigopostal", AV10cproveedorescodigopostal);
         lV11cproveedoresmunicipio = StringUtil.Concat( StringUtil.RTrim( AV11cproveedoresmunicipio), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproveedoresmunicipio", AV11cproveedoresmunicipio);
         lV12cproveedorestado = StringUtil.Concat( StringUtil.RTrim( AV12cproveedorestado), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproveedorestado", AV12cproveedorestado);
         /* Using cursor H00203 */
         pr_default.execute(1, new Object[] {AV6cproveedoresid, lV7cproveedoresnombre, lV8cproveedoresdireccion, lV9cproveedorescolonia, lV10cproveedorescodigopostal, lV11cproveedoresmunicipio, lV12cproveedorestado});
         GRID1_nRecordCount = H00203_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproveedoresid, AV7cproveedoresnombre, AV8cproveedoresdireccion, AV9cproveedorescolonia, AV10cproveedorescodigopostal, AV11cproveedoresmunicipio, AV12cproveedorestado) ;
         }
         return (int)(0) ;
      }

      protected void STRUP200( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19202 */
         E19202 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCproveedoresid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCproveedoresid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPROVEEDORESID");
               GX_FocusControl = edtavCproveedoresid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cproveedoresid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproveedoresid), 9, 0)));
            }
            else
            {
               AV6cproveedoresid = (int)(context.localUtil.CToN( cgiGet( edtavCproveedoresid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproveedoresid), 9, 0)));
            }
            AV7cproveedoresnombre = cgiGet( edtavCproveedoresnombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproveedoresnombre", AV7cproveedoresnombre);
            AV8cproveedoresdireccion = cgiGet( edtavCproveedoresdireccion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproveedoresdireccion", AV8cproveedoresdireccion);
            AV9cproveedorescolonia = cgiGet( edtavCproveedorescolonia_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cproveedorescolonia", AV9cproveedorescolonia);
            AV10cproveedorescodigopostal = cgiGet( edtavCproveedorescodigopostal_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cproveedorescodigopostal", AV10cproveedorescodigopostal);
            AV11cproveedoresmunicipio = cgiGet( edtavCproveedoresmunicipio_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproveedoresmunicipio", AV11cproveedoresmunicipio);
            AV12cproveedorestado = cgiGet( edtavCproveedorestado_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproveedorestado", AV12cproveedorestado);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPROVEEDORESID"), ",", ".") != Convert.ToDecimal( AV6cproveedoresid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESNOMBRE"), AV7cproveedoresnombre) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESDIRECCION"), AV8cproveedoresdireccion) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESCOLONIA"), AV9cproveedorescolonia) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESCODIGOPOSTAL"), AV10cproveedorescodigopostal) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESMUNICIPIO"), AV11cproveedoresmunicipio) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPROVEEDORESTADO"), AV12cproveedorestado) != 0 )
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
         /* Execute user event: E19202 */
         E19202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19202( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "proveedores", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20202( )
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
         /* Execute user event: E21202 */
         E21202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21202( )
      {
         /* Enter Routine */
         AV13pproveedoresid = A2proveedoresid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproveedoresid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pproveedoresid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pproveedoresid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproveedoresid), 9, 0)));
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
         PA202( ) ;
         WS202( ) ;
         WE202( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2071072");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022126208467");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00a0.js", "?2022126208467");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_84_idx;
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE_"+sGXsfl_84_idx;
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_84_fel_idx;
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE_"+sGXsfl_84_fel_idx;
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB200( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtproveedoresnombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresnombre_Internalname, "Link", edtproveedoresnombre_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresnombre_Internalname,(String)A126proveedoresnombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtproveedoresnombre_Link,(String)"",(String)"",(String)"",(String)edtproveedoresnombre_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorescolonia_Internalname,(String)A128proveedorescolonia,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorescolonia_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)25,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESNOMBRE"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCOLONIA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblproveedoresidfilter_Internalname = "LBLPROVEEDORESIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedoresid_Internalname = "vCPROVEEDORESID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedoresidfiltercontainer_Internalname = "PROVEEDORESIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedoresnombrefilter_Internalname = "LBLPROVEEDORESNOMBREFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedoresnombre_Internalname = "vCPROVEEDORESNOMBRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedoresnombrefiltercontainer_Internalname = "PROVEEDORESNOMBREFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedoresdireccionfilter_Internalname = "LBLPROVEEDORESDIRECCIONFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedoresdireccion_Internalname = "vCPROVEEDORESDIRECCION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedoresdireccionfiltercontainer_Internalname = "PROVEEDORESDIRECCIONFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedorescoloniafilter_Internalname = "LBLPROVEEDORESCOLONIAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedorescolonia_Internalname = "vCPROVEEDORESCOLONIA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedorescoloniafiltercontainer_Internalname = "PROVEEDORESCOLONIAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedorescodigopostalfilter_Internalname = "LBLPROVEEDORESCODIGOPOSTALFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedorescodigopostal_Internalname = "vCPROVEEDORESCODIGOPOSTAL";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedorescodigopostalfiltercontainer_Internalname = "PROVEEDORESCODIGOPOSTALFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedoresmunicipiofilter_Internalname = "LBLPROVEEDORESMUNICIPIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedoresmunicipio_Internalname = "vCPROVEEDORESMUNICIPIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedoresmunicipiofiltercontainer_Internalname = "PROVEEDORESMUNICIPIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproveedorestadofilter_Internalname = "LBLPROVEEDORESTADOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproveedorestado_Internalname = "vCPROVEEDORESTADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProveedorestadofiltercontainer_Internalname = "PROVEEDORESTADOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtproveedoresid_Internalname = "PROVEEDORESID";
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE";
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA";
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
         edtproveedorescolonia_Jsonclick = "";
         edtproveedoresnombre_Jsonclick = "";
         edtproveedoresid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtproveedoresnombre_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCproveedorestado_Jsonclick = "";
         edtavCproveedorestado_Enabled = 1;
         edtavCproveedorestado_Visible = 1;
         edtavCproveedoresmunicipio_Jsonclick = "";
         edtavCproveedoresmunicipio_Enabled = 1;
         edtavCproveedoresmunicipio_Visible = 1;
         edtavCproveedorescodigopostal_Jsonclick = "";
         edtavCproveedorescodigopostal_Enabled = 1;
         edtavCproveedorescodigopostal_Visible = 1;
         edtavCproveedorescolonia_Jsonclick = "";
         edtavCproveedorescolonia_Enabled = 1;
         edtavCproveedorescolonia_Visible = 1;
         edtavCproveedoresdireccion_Jsonclick = "";
         edtavCproveedoresdireccion_Enabled = 1;
         edtavCproveedoresdireccion_Visible = 1;
         edtavCproveedoresnombre_Jsonclick = "";
         edtavCproveedoresnombre_Enabled = 1;
         edtavCproveedoresnombre_Visible = 1;
         edtavCproveedoresid_Jsonclick = "";
         edtavCproveedoresid_Enabled = 1;
         edtavCproveedoresid_Visible = 1;
         divProveedorestadofiltercontainer_Class = "AdvancedContainerItem";
         divProveedoresmunicipiofiltercontainer_Class = "AdvancedContainerItem";
         divProveedorescodigopostalfiltercontainer_Class = "AdvancedContainerItem";
         divProveedorescoloniafiltercontainer_Class = "AdvancedContainerItem";
         divProveedoresdireccionfiltercontainer_Class = "AdvancedContainerItem";
         divProveedoresnombrefiltercontainer_Class = "AdvancedContainerItem";
         divProveedoresidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List proveedores";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproveedoresid',fld:'vCPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproveedoresnombre',fld:'vCPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV8cproveedoresdireccion',fld:'vCPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV9cproveedorescolonia',fld:'vCPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV10cproveedorescodigopostal',fld:'vCPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV11cproveedoresmunicipio',fld:'vCPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV12cproveedorestado',fld:'vCPROVEEDORESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18201',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPROVEEDORESIDFILTER.CLICK","{handler:'E11201',iparms:[{av:'divProveedoresidfiltercontainer_Class',ctrl:'PROVEEDORESIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedoresidfiltercontainer_Class',ctrl:'PROVEEDORESIDFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedoresid_Visible',ctrl:'vCPROVEEDORESID',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESNOMBREFILTER.CLICK","{handler:'E12201',iparms:[{av:'divProveedoresnombrefiltercontainer_Class',ctrl:'PROVEEDORESNOMBREFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedoresnombrefiltercontainer_Class',ctrl:'PROVEEDORESNOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedoresnombre_Visible',ctrl:'vCPROVEEDORESNOMBRE',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESDIRECCIONFILTER.CLICK","{handler:'E13201',iparms:[{av:'divProveedoresdireccionfiltercontainer_Class',ctrl:'PROVEEDORESDIRECCIONFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedoresdireccionfiltercontainer_Class',ctrl:'PROVEEDORESDIRECCIONFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedoresdireccion_Visible',ctrl:'vCPROVEEDORESDIRECCION',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESCOLONIAFILTER.CLICK","{handler:'E14201',iparms:[{av:'divProveedorescoloniafiltercontainer_Class',ctrl:'PROVEEDORESCOLONIAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedorescoloniafiltercontainer_Class',ctrl:'PROVEEDORESCOLONIAFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedorescolonia_Visible',ctrl:'vCPROVEEDORESCOLONIA',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESCODIGOPOSTALFILTER.CLICK","{handler:'E15201',iparms:[{av:'divProveedorescodigopostalfiltercontainer_Class',ctrl:'PROVEEDORESCODIGOPOSTALFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedorescodigopostalfiltercontainer_Class',ctrl:'PROVEEDORESCODIGOPOSTALFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedorescodigopostal_Visible',ctrl:'vCPROVEEDORESCODIGOPOSTAL',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESMUNICIPIOFILTER.CLICK","{handler:'E16201',iparms:[{av:'divProveedoresmunicipiofiltercontainer_Class',ctrl:'PROVEEDORESMUNICIPIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedoresmunicipiofiltercontainer_Class',ctrl:'PROVEEDORESMUNICIPIOFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedoresmunicipio_Visible',ctrl:'vCPROVEEDORESMUNICIPIO',prop:'Visible'}]}");
         setEventMetadata("LBLPROVEEDORESTADOFILTER.CLICK","{handler:'E17201',iparms:[{av:'divProveedorestadofiltercontainer_Class',ctrl:'PROVEEDORESTADOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProveedorestadofiltercontainer_Class',ctrl:'PROVEEDORESTADOFILTERCONTAINER',prop:'Class'},{av:'edtavCproveedorestado_Visible',ctrl:'vCPROVEEDORESTADO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21202',iparms:[{av:'A2proveedoresid',fld:'PROVEEDORESID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pproveedoresid',fld:'vPPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproveedoresid',fld:'vCPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproveedoresnombre',fld:'vCPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV8cproveedoresdireccion',fld:'vCPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV9cproveedorescolonia',fld:'vCPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV10cproveedorescodigopostal',fld:'vCPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV11cproveedoresmunicipio',fld:'vCPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV12cproveedorestado',fld:'vCPROVEEDORESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproveedoresid',fld:'vCPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproveedoresnombre',fld:'vCPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV8cproveedoresdireccion',fld:'vCPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV9cproveedorescolonia',fld:'vCPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV10cproveedorescodigopostal',fld:'vCPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV11cproveedoresmunicipio',fld:'vCPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV12cproveedorestado',fld:'vCPROVEEDORESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproveedoresid',fld:'vCPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproveedoresnombre',fld:'vCPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV8cproveedoresdireccion',fld:'vCPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV9cproveedorescolonia',fld:'vCPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV10cproveedorescodigopostal',fld:'vCPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV11cproveedoresmunicipio',fld:'vCPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV12cproveedorestado',fld:'vCPROVEEDORESTADO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproveedoresid',fld:'vCPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproveedoresnombre',fld:'vCPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV8cproveedoresdireccion',fld:'vCPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV9cproveedorescolonia',fld:'vCPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV10cproveedorescodigopostal',fld:'vCPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV11cproveedoresmunicipio',fld:'vCPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV12cproveedorestado',fld:'vCPROVEEDORESTADO',pic:'',nv:''}],oparms:[]}");
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
         AV7cproveedoresnombre = "";
         AV8cproveedoresdireccion = "";
         AV9cproveedorescolonia = "";
         AV10cproveedorescodigopostal = "";
         AV11cproveedoresmunicipio = "";
         AV12cproveedorestado = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblproveedoresidfilter_Jsonclick = "";
         TempTags = "";
         lblLblproveedoresnombrefilter_Jsonclick = "";
         lblLblproveedoresdireccionfilter_Jsonclick = "";
         lblLblproveedorescoloniafilter_Jsonclick = "";
         lblLblproveedorescodigopostalfilter_Jsonclick = "";
         lblLblproveedoresmunicipiofilter_Jsonclick = "";
         lblLblproveedorestadofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A126proveedoresnombre = "";
         A128proveedorescolonia = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cproveedoresnombre = "";
         lV8cproveedoresdireccion = "";
         lV9cproveedorescolonia = "";
         lV10cproveedorescodigopostal = "";
         lV11cproveedoresmunicipio = "";
         lV12cproveedorestado = "";
         A127proveedoresdireccion = "";
         A129proveedorescodigopostal = "";
         A130proveedoresmunicipio = "";
         A131proveedorestado = "";
         H00202_A131proveedorestado = new String[] {""} ;
         H00202_n131proveedorestado = new bool[] {false} ;
         H00202_A130proveedoresmunicipio = new String[] {""} ;
         H00202_n130proveedoresmunicipio = new bool[] {false} ;
         H00202_A129proveedorescodigopostal = new String[] {""} ;
         H00202_n129proveedorescodigopostal = new bool[] {false} ;
         H00202_A127proveedoresdireccion = new String[] {""} ;
         H00202_n127proveedoresdireccion = new bool[] {false} ;
         H00202_A128proveedorescolonia = new String[] {""} ;
         H00202_n128proveedorescolonia = new bool[] {false} ;
         H00202_A126proveedoresnombre = new String[] {""} ;
         H00202_n126proveedoresnombre = new bool[] {false} ;
         H00202_A2proveedoresid = new int[1] ;
         H00203_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00a0__default(),
            new Object[][] {
                new Object[] {
               H00202_A131proveedorestado, H00202_n131proveedorestado, H00202_A130proveedoresmunicipio, H00202_n130proveedoresmunicipio, H00202_A129proveedorescodigopostal, H00202_n129proveedorescodigopostal, H00202_A127proveedoresdireccion, H00202_n127proveedoresdireccion, H00202_A128proveedorescolonia, H00202_n128proveedorescolonia,
               H00202_A126proveedoresnombre, H00202_n126proveedoresnombre, H00202_A2proveedoresid
               }
               , new Object[] {
               H00203_AGRID1_nRecordCount
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
      private int AV6cproveedoresid ;
      private int AV13pproveedoresid ;
      private int edtavCproveedoresid_Enabled ;
      private int edtavCproveedoresid_Visible ;
      private int edtavCproveedoresnombre_Visible ;
      private int edtavCproveedoresnombre_Enabled ;
      private int edtavCproveedoresdireccion_Visible ;
      private int edtavCproveedoresdireccion_Enabled ;
      private int edtavCproveedorescolonia_Visible ;
      private int edtavCproveedorescolonia_Enabled ;
      private int edtavCproveedorescodigopostal_Visible ;
      private int edtavCproveedorescodigopostal_Enabled ;
      private int edtavCproveedoresmunicipio_Visible ;
      private int edtavCproveedoresmunicipio_Enabled ;
      private int edtavCproveedorestado_Visible ;
      private int edtavCproveedorestado_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A2proveedoresid ;
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
      private String divProveedoresidfiltercontainer_Class ;
      private String divProveedoresnombrefiltercontainer_Class ;
      private String divProveedoresdireccionfiltercontainer_Class ;
      private String divProveedorescoloniafiltercontainer_Class ;
      private String divProveedorescodigopostalfiltercontainer_Class ;
      private String divProveedoresmunicipiofiltercontainer_Class ;
      private String divProveedorestadofiltercontainer_Class ;
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
      private String divProveedoresidfiltercontainer_Internalname ;
      private String lblLblproveedoresidfilter_Internalname ;
      private String lblLblproveedoresidfilter_Jsonclick ;
      private String edtavCproveedoresid_Internalname ;
      private String TempTags ;
      private String edtavCproveedoresid_Jsonclick ;
      private String divProveedoresnombrefiltercontainer_Internalname ;
      private String lblLblproveedoresnombrefilter_Internalname ;
      private String lblLblproveedoresnombrefilter_Jsonclick ;
      private String edtavCproveedoresnombre_Internalname ;
      private String edtavCproveedoresnombre_Jsonclick ;
      private String divProveedoresdireccionfiltercontainer_Internalname ;
      private String lblLblproveedoresdireccionfilter_Internalname ;
      private String lblLblproveedoresdireccionfilter_Jsonclick ;
      private String edtavCproveedoresdireccion_Internalname ;
      private String edtavCproveedoresdireccion_Jsonclick ;
      private String divProveedorescoloniafiltercontainer_Internalname ;
      private String lblLblproveedorescoloniafilter_Internalname ;
      private String lblLblproveedorescoloniafilter_Jsonclick ;
      private String edtavCproveedorescolonia_Internalname ;
      private String edtavCproveedorescolonia_Jsonclick ;
      private String divProveedorescodigopostalfiltercontainer_Internalname ;
      private String lblLblproveedorescodigopostalfilter_Internalname ;
      private String lblLblproveedorescodigopostalfilter_Jsonclick ;
      private String edtavCproveedorescodigopostal_Internalname ;
      private String edtavCproveedorescodigopostal_Jsonclick ;
      private String divProveedoresmunicipiofiltercontainer_Internalname ;
      private String lblLblproveedoresmunicipiofilter_Internalname ;
      private String lblLblproveedoresmunicipiofilter_Jsonclick ;
      private String edtavCproveedoresmunicipio_Internalname ;
      private String edtavCproveedoresmunicipio_Jsonclick ;
      private String divProveedorestadofiltercontainer_Internalname ;
      private String lblLblproveedorestadofilter_Internalname ;
      private String lblLblproveedorestadofilter_Jsonclick ;
      private String edtavCproveedorestado_Internalname ;
      private String edtavCproveedorestado_Jsonclick ;
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
      private String edtproveedoresnombre_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtproveedoresid_Internalname ;
      private String edtproveedoresnombre_Internalname ;
      private String edtproveedorescolonia_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtproveedoresid_Jsonclick ;
      private String edtproveedoresnombre_Jsonclick ;
      private String edtproveedorescolonia_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n126proveedoresnombre ;
      private bool n128proveedorescolonia ;
      private bool n131proveedorestado ;
      private bool n130proveedoresmunicipio ;
      private bool n129proveedorescodigopostal ;
      private bool n127proveedoresdireccion ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cproveedoresnombre ;
      private String AV8cproveedoresdireccion ;
      private String AV9cproveedorescolonia ;
      private String AV10cproveedorescodigopostal ;
      private String AV11cproveedoresmunicipio ;
      private String AV12cproveedorestado ;
      private String A126proveedoresnombre ;
      private String A128proveedorescolonia ;
      private String AV17Linkselection_GXI ;
      private String lV7cproveedoresnombre ;
      private String lV8cproveedoresdireccion ;
      private String lV9cproveedorescolonia ;
      private String lV10cproveedorescodigopostal ;
      private String lV11cproveedoresmunicipio ;
      private String lV12cproveedorestado ;
      private String A127proveedoresdireccion ;
      private String A129proveedorescodigopostal ;
      private String A130proveedoresmunicipio ;
      private String A131proveedorestado ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00202_A131proveedorestado ;
      private bool[] H00202_n131proveedorestado ;
      private String[] H00202_A130proveedoresmunicipio ;
      private bool[] H00202_n130proveedoresmunicipio ;
      private String[] H00202_A129proveedorescodigopostal ;
      private bool[] H00202_n129proveedorescodigopostal ;
      private String[] H00202_A127proveedoresdireccion ;
      private bool[] H00202_n127proveedoresdireccion ;
      private String[] H00202_A128proveedorescolonia ;
      private bool[] H00202_n128proveedorescolonia ;
      private String[] H00202_A126proveedoresnombre ;
      private bool[] H00202_n126proveedoresnombre ;
      private int[] H00202_A2proveedoresid ;
      private long[] H00203_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pproveedoresid ;
      private GXWebForm Form ;
   }

   public class gx00a0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00202( IGxContext context ,
                                             String AV7cproveedoresnombre ,
                                             String AV8cproveedoresdireccion ,
                                             String AV9cproveedorescolonia ,
                                             String AV10cproveedorescodigopostal ,
                                             String AV11cproveedoresmunicipio ,
                                             String AV12cproveedorestado ,
                                             String A126proveedoresnombre ,
                                             String A127proveedoresdireccion ,
                                             String A128proveedorescolonia ,
                                             String A129proveedorescodigopostal ,
                                             String A130proveedoresmunicipio ,
                                             String A131proveedorestado ,
                                             int AV6cproveedoresid )
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
         sSelectString = " proveedorestado, proveedoresmunicipio, proveedorescodigopostal, proveedoresdireccion, proveedorescolonia, proveedoresnombre, proveedoresid";
         sFromString = " FROM public.proveedores";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (proveedoresid >= :AV6cproveedoresid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cproveedoresnombre)) )
         {
            sWhereString = sWhereString + " and (proveedoresnombre like :lV7cproveedoresnombre)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproveedoresdireccion)) )
         {
            sWhereString = sWhereString + " and (proveedoresdireccion like :lV8cproveedoresdireccion)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cproveedorescolonia)) )
         {
            sWhereString = sWhereString + " and (proveedorescolonia like :lV9cproveedorescolonia)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cproveedorescodigopostal)) )
         {
            sWhereString = sWhereString + " and (proveedorescodigopostal like :lV10cproveedorescodigopostal)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cproveedoresmunicipio)) )
         {
            sWhereString = sWhereString + " and (proveedoresmunicipio like :lV11cproveedoresmunicipio)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproveedorestado)) )
         {
            sWhereString = sWhereString + " and (proveedorestado like :lV12cproveedorestado)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY proveedoresid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00203( IGxContext context ,
                                             String AV7cproveedoresnombre ,
                                             String AV8cproveedoresdireccion ,
                                             String AV9cproveedorescolonia ,
                                             String AV10cproveedorescodigopostal ,
                                             String AV11cproveedoresmunicipio ,
                                             String AV12cproveedorestado ,
                                             String A126proveedoresnombre ,
                                             String A127proveedoresdireccion ,
                                             String A128proveedorescolonia ,
                                             String A129proveedorescodigopostal ,
                                             String A130proveedoresmunicipio ,
                                             String A131proveedorestado ,
                                             int AV6cproveedoresid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.proveedores";
         scmdbuf = scmdbuf + " WHERE (proveedoresid >= :AV6cproveedoresid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cproveedoresnombre)) )
         {
            sWhereString = sWhereString + " and (proveedoresnombre like :lV7cproveedoresnombre)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproveedoresdireccion)) )
         {
            sWhereString = sWhereString + " and (proveedoresdireccion like :lV8cproveedoresdireccion)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cproveedorescolonia)) )
         {
            sWhereString = sWhereString + " and (proveedorescolonia like :lV9cproveedorescolonia)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cproveedorescodigopostal)) )
         {
            sWhereString = sWhereString + " and (proveedorescodigopostal like :lV10cproveedorescodigopostal)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cproveedoresmunicipio)) )
         {
            sWhereString = sWhereString + " and (proveedoresmunicipio like :lV11cproveedoresmunicipio)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproveedorestado)) )
         {
            sWhereString = sWhereString + " and (proveedorestado like :lV12cproveedorestado)";
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
                     return conditional_H00202(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H00203(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH00202 ;
          prmH00202 = new Object[] {
          new Object[] {"AV6cproveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cproveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"lV8cproveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV9cproveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"lV10cproveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"lV11cproveedoresmunicipio",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"lV12cproveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00203 ;
          prmH00203 = new Object[] {
          new Object[] {"AV6cproveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cproveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"lV8cproveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV9cproveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"lV10cproveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"lV11cproveedoresmunicipio",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"lV12cproveedorestado",NpgsqlDbType.Varchar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00202", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00202,11,0,false,false )
             ,new CursorDef("H00203", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00203,1,0,false,false )
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
