/*
               File: Gx00B0
        Description: Selection List articulos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:18.31
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
   public class gx00b0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00b0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00b0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_palmacenid ,
                           out int aP1_particulosproductoid ,
                           out int aP2_particuloscambsid )
      {
         this.AV13palmacenid = 0 ;
         this.AV14particulosproductoid = 0 ;
         this.AV15particuloscambsid = 0 ;
         executePrivate();
         aP0_palmacenid=this.AV13palmacenid;
         aP1_particulosproductoid=this.AV14particulosproductoid;
         aP2_particuloscambsid=this.AV15particuloscambsid;
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
               AV6calmacenid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 9, 0)));
               AV7carticulosproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosproductoid), 9, 0)));
               AV8carticuloscambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8carticuloscambsid), 9, 0)));
               AV9calamcenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9calamcenid), 18, 0)));
               AV10carticulosnoetiqueta = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosnoetiqueta), 18, 0)));
               AV11ctipobienid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ctipobienid), 9, 0)));
               AV12centidafederativaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12centidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12centidafederativaid), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
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
               AV13palmacenid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14particulosproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosproductoid), 9, 0)));
                  AV15particuloscambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15particuloscambsid), 9, 0)));
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
         PA212( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START212( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20222213431838");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13palmacenid) + "," + UrlEncode("" +AV14particulosproductoid) + "," + UrlEncode("" +AV15particuloscambsid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6calmacenid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7carticulosproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8carticuloscambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCALAMCENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9calamcenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCARTICULOSNOETIQUETA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10carticulosnoetiqueta), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ctipobienid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCENTIDAFEDERATIVAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12centidafederativaid), 9, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13palmacenid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPARTICULOSPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14particulosproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPARTICULOSCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15particuloscambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ALMACENIDFILTERCONTAINER_Class", StringUtil.RTrim( divAlmacenidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSPRODUCTOIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosproductoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSCAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divArticuloscambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ALAMCENIDFILTERCONTAINER_Class", StringUtil.RTrim( divAlamcenidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ARTICULOSNOETIQUETAFILTERCONTAINER_Class", StringUtil.RTrim( divArticulosnoetiquetafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENIDFILTERCONTAINER_Class", StringUtil.RTrim( divTipobienidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ENTIDAFEDERATIVAIDFILTERCONTAINER_Class", StringUtil.RTrim( divEntidafederativaidfiltercontainer_Class));
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
            WE212( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT212( ) ;
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
         return formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13palmacenid) + "," + UrlEncode("" +AV14particulosproductoid) + "," + UrlEncode("" +AV15particuloscambsid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00B0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List articulos" ;
      }

      protected void WB210( )
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
            GxWebStd.gx_label_ctrl( context, lblLblalmacenidfilter_Internalname, "almacenid", "", "", lblLblalmacenidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalmacenid_Internalname, "almacenid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6calmacenid), 9, 0, ",", "")), ((edtavCalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6calmacenid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6calmacenid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalmacenid_Jsonclick, 0, "Attribute", "", "", "", edtavCalmacenid_Visible, edtavCalmacenid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosproductoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosproductoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosproductoidfilter_Internalname, "articulosproductoid", "", "", lblLblarticulosproductoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7carticulosproductoid), 9, 0, ",", "")), ((edtavCarticulosproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7carticulosproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7carticulosproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosproductoid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosproductoid_Visible, edtavCarticulosproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divArticuloscambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticuloscambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticuloscambsidfilter_Internalname, "articuloscambsid", "", "", lblLblarticuloscambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticuloscambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticuloscambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8carticuloscambsid), 9, 0, ",", "")), ((edtavCarticuloscambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8carticuloscambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8carticuloscambsid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticuloscambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCarticuloscambsid_Visible, edtavCarticuloscambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divAlamcenidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAlamcenidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblalamcenidfilter_Internalname, "alamcenid", "", "", lblLblalamcenidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCalamcenid_Internalname, "alamcenid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCalamcenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9calamcenid), 18, 0, ",", "")), ((edtavCalamcenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9calamcenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9calamcenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCalamcenid_Jsonclick, 0, "Attribute", "", "", "", edtavCalamcenid_Visible, edtavCalamcenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divArticulosnoetiquetafiltercontainer_Internalname, 1, 0, "px", 0, "px", divArticulosnoetiquetafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblarticulosnoetiquetafilter_Internalname, "articulosnoetiqueta", "", "", lblLblarticulosnoetiquetafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCarticulosnoetiqueta_Internalname, "articulosnoetiqueta", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCarticulosnoetiqueta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10carticulosnoetiqueta), 18, 0, ",", "")), ((edtavCarticulosnoetiqueta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10carticulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10carticulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCarticulosnoetiqueta_Jsonclick, 0, "Attribute", "", "", "", edtavCarticulosnoetiqueta_Visible, edtavCarticulosnoetiqueta_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divTipobienidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobienidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobienidfilter_Internalname, "tipobienid", "", "", lblLbltipobienidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipobienid_Internalname, "tipobienid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipobienid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ctipobienid), 9, 0, ",", "")), ((edtavCtipobienid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11ctipobienid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11ctipobienid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobienid_Jsonclick, 0, "Attribute", "", "", "", edtavCtipobienid_Visible, edtavCtipobienid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divEntidafederativaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEntidafederativaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblentidafederativaidfilter_Internalname, "entidafederativaid", "", "", lblLblentidafederativaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCentidafederativaid_Internalname, "entidafederativaid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCentidafederativaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12centidafederativaid), 9, 0, ",", "")), ((edtavCentidafederativaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12centidafederativaid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12centidafederativaid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCentidafederativaid_Jsonclick, 0, "Attribute", "", "", "", edtavCentidafederativaid_Visible, edtavCentidafederativaid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00B0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18211_client"+"'", TempTags, "", 2, "HLP_Gx00B0.htm");
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
               context.SendWebValue( "almacenid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productoid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "alamcenid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "articulosnoetiqueta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tipobienid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "entidafederativaid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "proveedoresid") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A154alamcenid), 18, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtalamcenid_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A155articulosnoetiqueta), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00B0.htm");
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

      protected void START212( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List articulos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP210( ) ;
      }

      protected void WS212( )
      {
         START212( ) ;
         EVT212( ) ;
      }

      protected void EVT212( )
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
                              A19almacenid = (int)(context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", "."));
                              A20articulosproductoid = (int)(context.localUtil.CToN( cgiGet( edtarticulosproductoid_Internalname), ",", "."));
                              A21articuloscambsid = (int)(context.localUtil.CToN( cgiGet( edtarticuloscambsid_Internalname), ",", "."));
                              A154alamcenid = (long)(context.localUtil.CToN( cgiGet( edtalamcenid_Internalname), ",", "."));
                              n154alamcenid = false;
                              A155articulosnoetiqueta = (long)(context.localUtil.CToN( cgiGet( edtarticulosnoetiqueta_Internalname), ",", "."));
                              n155articulosnoetiqueta = false;
                              A23tipobienid = (int)(context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", "."));
                              n23tipobienid = false;
                              A7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", "."));
                              n7entidafederativaid = false;
                              A2proveedoresid = (int)(context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", "."));
                              n2proveedoresid = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19212 */
                                    E19212 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20212 */
                                    E20212 ();
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
                                       /* Set Refresh If Carticulosproductoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV7carticulosproductoid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticuloscambsid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSCAMBSID"), ",", ".") != Convert.ToDecimal( AV8carticuloscambsid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Calamcenid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALAMCENID"), ",", ".") != Convert.ToDecimal( AV9calamcenid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Carticulosnoetiqueta Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSNOETIQUETA"), ",", ".") != Convert.ToDecimal( AV10carticulosnoetiqueta )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipobienid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOBIENID"), ",", ".") != Convert.ToDecimal( AV11ctipobienid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Centidafederativaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCENTIDAFEDERATIVAID"), ",", ".") != Convert.ToDecimal( AV12centidafederativaid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21212 */
                                          E21212 ();
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

      protected void WE212( )
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

      protected void PA212( )
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
                                        int AV6calmacenid ,
                                        int AV7carticulosproductoid ,
                                        int AV8carticuloscambsid ,
                                        long AV9calamcenid ,
                                        long AV10carticulosnoetiqueta ,
                                        int AV11ctipobienid ,
                                        int AV12centidafederativaid )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF212( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ALMACENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSPRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A20articulosproductoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSCAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A21articuloscambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ALAMCENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A154alamcenid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ALAMCENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A154alamcenid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSNOETIQUETA", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A155articulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ARTICULOSNOETIQUETA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A155articulosnoetiqueta), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "TIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ENTIDAFEDERATIVAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ENTIDAFEDERATIVAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF212( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF212( )
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
                                                 AV9calamcenid ,
                                                 AV10carticulosnoetiqueta ,
                                                 AV11ctipobienid ,
                                                 AV12centidafederativaid ,
                                                 A154alamcenid ,
                                                 A155articulosnoetiqueta ,
                                                 A23tipobienid ,
                                                 A7entidafederativaid ,
                                                 AV6calmacenid ,
                                                 AV7carticulosproductoid ,
                                                 AV8carticuloscambsid },
                                                 new int[] {
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.INT, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN,
                                                 TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT, TypeConstants.INT
                                                 }
            });
            /* Using cursor H00212 */
            pr_default.execute(0, new Object[] {AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A2proveedoresid = H00212_A2proveedoresid[0];
               n2proveedoresid = H00212_n2proveedoresid[0];
               A7entidafederativaid = H00212_A7entidafederativaid[0];
               n7entidafederativaid = H00212_n7entidafederativaid[0];
               A23tipobienid = H00212_A23tipobienid[0];
               n23tipobienid = H00212_n23tipobienid[0];
               A155articulosnoetiqueta = H00212_A155articulosnoetiqueta[0];
               n155articulosnoetiqueta = H00212_n155articulosnoetiqueta[0];
               A154alamcenid = H00212_A154alamcenid[0];
               n154alamcenid = H00212_n154alamcenid[0];
               A21articuloscambsid = H00212_A21articuloscambsid[0];
               A20articulosproductoid = H00212_A20articulosproductoid[0];
               A19almacenid = H00212_A19almacenid[0];
               /* Execute user event: E20212 */
               E20212 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB210( ) ;
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
                                              AV9calamcenid ,
                                              AV10carticulosnoetiqueta ,
                                              AV11ctipobienid ,
                                              AV12centidafederativaid ,
                                              A154alamcenid ,
                                              A155articulosnoetiqueta ,
                                              A23tipobienid ,
                                              A7entidafederativaid ,
                                              AV6calmacenid ,
                                              AV7carticulosproductoid ,
                                              AV8carticuloscambsid },
                                              new int[] {
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.INT, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN,
                                              TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         /* Using cursor H00213 */
         pr_default.execute(1, new Object[] {AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid});
         GRID1_nRecordCount = H00213_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6calmacenid, AV7carticulosproductoid, AV8carticuloscambsid, AV9calamcenid, AV10carticulosnoetiqueta, AV11ctipobienid, AV12centidafederativaid) ;
         }
         return (int)(0) ;
      }

      protected void STRUP210( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19212 */
         E19212 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCALMACENID");
               GX_FocusControl = edtavCalmacenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6calmacenid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 9, 0)));
            }
            else
            {
               AV6calmacenid = (int)(context.localUtil.CToN( cgiGet( edtavCalmacenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6calmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6calmacenid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSPRODUCTOID");
               GX_FocusControl = edtavCarticulosproductoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7carticulosproductoid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosproductoid), 9, 0)));
            }
            else
            {
               AV7carticulosproductoid = (int)(context.localUtil.CToN( cgiGet( edtavCarticulosproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7carticulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7carticulosproductoid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticuloscambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticuloscambsid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSCAMBSID");
               GX_FocusControl = edtavCarticuloscambsid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8carticuloscambsid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8carticuloscambsid), 9, 0)));
            }
            else
            {
               AV8carticuloscambsid = (int)(context.localUtil.CToN( cgiGet( edtavCarticuloscambsid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8carticuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8carticuloscambsid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCalamcenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCalamcenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCALAMCENID");
               GX_FocusControl = edtavCalamcenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9calamcenid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9calamcenid), 18, 0)));
            }
            else
            {
               AV9calamcenid = (long)(context.localUtil.CToN( cgiGet( edtavCalamcenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9calamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9calamcenid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCarticulosnoetiqueta_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCarticulosnoetiqueta_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARTICULOSNOETIQUETA");
               GX_FocusControl = edtavCarticulosnoetiqueta_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10carticulosnoetiqueta = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosnoetiqueta), 18, 0)));
            }
            else
            {
               AV10carticulosnoetiqueta = (long)(context.localUtil.CToN( cgiGet( edtavCarticulosnoetiqueta_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10carticulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10carticulosnoetiqueta), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPOBIENID");
               GX_FocusControl = edtavCtipobienid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11ctipobienid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ctipobienid), 9, 0)));
            }
            else
            {
               AV11ctipobienid = (int)(context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ctipobienid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCentidafederativaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCentidafederativaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCENTIDAFEDERATIVAID");
               GX_FocusControl = edtavCentidafederativaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12centidafederativaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12centidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12centidafederativaid), 9, 0)));
            }
            else
            {
               AV12centidafederativaid = (int)(context.localUtil.CToN( cgiGet( edtavCentidafederativaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12centidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12centidafederativaid), 9, 0)));
            }
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV7carticulosproductoid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSCAMBSID"), ",", ".") != Convert.ToDecimal( AV8carticuloscambsid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCALAMCENID"), ",", ".") != Convert.ToDecimal( AV9calamcenid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCARTICULOSNOETIQUETA"), ",", ".") != Convert.ToDecimal( AV10carticulosnoetiqueta )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOBIENID"), ",", ".") != Convert.ToDecimal( AV11ctipobienid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCENTIDAFEDERATIVAID"), ",", ".") != Convert.ToDecimal( AV12centidafederativaid )) )
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
         /* Execute user event: E19212 */
         E19212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19212( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "articulos", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV16ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20212( )
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
         /* Execute user event: E21212 */
         E21212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21212( )
      {
         /* Enter Routine */
         AV13palmacenid = A19almacenid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 9, 0)));
         AV14particulosproductoid = A20articulosproductoid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosproductoid), 9, 0)));
         AV15particuloscambsid = A21articuloscambsid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15particuloscambsid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13palmacenid,(int)AV14particulosproductoid,(int)AV15particuloscambsid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13palmacenid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13palmacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13palmacenid), 9, 0)));
         AV14particulosproductoid = Convert.ToInt32(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14particulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14particulosproductoid), 9, 0)));
         AV15particuloscambsid = Convert.ToInt32(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15particuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15particuloscambsid), 9, 0)));
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
         PA212( ) ;
         WS212( ) ;
         WE212( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1342847");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222213431944");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00b0.js", "?20222213431944");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_idx;
         edtarticulosproductoid_Internalname = "ARTICULOSPRODUCTOID_"+sGXsfl_84_idx;
         edtarticuloscambsid_Internalname = "ARTICULOSCAMBSID_"+sGXsfl_84_idx;
         edtalamcenid_Internalname = "ALAMCENID_"+sGXsfl_84_idx;
         edtarticulosnoetiqueta_Internalname = "ARTICULOSNOETIQUETA_"+sGXsfl_84_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_84_idx;
         edtentidafederativaid_Internalname = "ENTIDAFEDERATIVAID_"+sGXsfl_84_idx;
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtalmacenid_Internalname = "ALMACENID_"+sGXsfl_84_fel_idx;
         edtarticulosproductoid_Internalname = "ARTICULOSPRODUCTOID_"+sGXsfl_84_fel_idx;
         edtarticuloscambsid_Internalname = "ARTICULOSCAMBSID_"+sGXsfl_84_fel_idx;
         edtalamcenid_Internalname = "ALAMCENID_"+sGXsfl_84_fel_idx;
         edtarticulosnoetiqueta_Internalname = "ARTICULOSNOETIQUETA_"+sGXsfl_84_fel_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_84_fel_idx;
         edtentidafederativaid_Internalname = "ENTIDAFEDERATIVAID_"+sGXsfl_84_fel_idx;
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB210( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalmacenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtalmacenid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A20articulosproductoid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticuloscambsid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A21articuloscambsid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticuloscambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtalamcenid_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcenid_Internalname, "Link", edtalamcenid_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtalamcenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A154alamcenid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A154alamcenid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtalamcenid_Link,(String)"",(String)"",(String)"",(String)edtalamcenid_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtarticulosnoetiqueta_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A155articulosnoetiqueta), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A155articulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtarticulosnoetiqueta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtentidafederativaid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtentidafederativaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_ALMACENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSPRODUCTOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A20articulosproductoid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSCAMBSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A21articuloscambsid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ALAMCENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A154alamcenid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ARTICULOSNOETIQUETA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A155articulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ENTIDAFEDERATIVAID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
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
         lblLblarticulosproductoidfilter_Internalname = "LBLARTICULOSPRODUCTOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosproductoid_Internalname = "vCARTICULOSPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosproductoidfiltercontainer_Internalname = "ARTICULOSPRODUCTOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticuloscambsidfilter_Internalname = "LBLARTICULOSCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticuloscambsid_Internalname = "vCARTICULOSCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticuloscambsidfiltercontainer_Internalname = "ARTICULOSCAMBSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblalamcenidfilter_Internalname = "LBLALAMCENIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCalamcenid_Internalname = "vCALAMCENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAlamcenidfiltercontainer_Internalname = "ALAMCENIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblarticulosnoetiquetafilter_Internalname = "LBLARTICULOSNOETIQUETAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCarticulosnoetiqueta_Internalname = "vCARTICULOSNOETIQUETA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divArticulosnoetiquetafiltercontainer_Internalname = "ARTICULOSNOETIQUETAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltipobienidfilter_Internalname = "LBLTIPOBIENIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtipobienid_Internalname = "vCTIPOBIENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTipobienidfiltercontainer_Internalname = "TIPOBIENIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblentidafederativaidfilter_Internalname = "LBLENTIDAFEDERATIVAIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCentidafederativaid_Internalname = "vCENTIDAFEDERATIVAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divEntidafederativaidfiltercontainer_Internalname = "ENTIDAFEDERATIVAIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtalmacenid_Internalname = "ALMACENID";
         edtarticulosproductoid_Internalname = "ARTICULOSPRODUCTOID";
         edtarticuloscambsid_Internalname = "ARTICULOSCAMBSID";
         edtalamcenid_Internalname = "ALAMCENID";
         edtarticulosnoetiqueta_Internalname = "ARTICULOSNOETIQUETA";
         edttipobienid_Internalname = "TIPOBIENID";
         edtentidafederativaid_Internalname = "ENTIDAFEDERATIVAID";
         edtproveedoresid_Internalname = "PROVEEDORESID";
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
         edtproveedoresid_Jsonclick = "";
         edtentidafederativaid_Jsonclick = "";
         edttipobienid_Jsonclick = "";
         edtarticulosnoetiqueta_Jsonclick = "";
         edtalamcenid_Jsonclick = "";
         edtarticuloscambsid_Jsonclick = "";
         edtarticulosproductoid_Jsonclick = "";
         edtalmacenid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtalamcenid_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCentidafederativaid_Jsonclick = "";
         edtavCentidafederativaid_Enabled = 1;
         edtavCentidafederativaid_Visible = 1;
         edtavCtipobienid_Jsonclick = "";
         edtavCtipobienid_Enabled = 1;
         edtavCtipobienid_Visible = 1;
         edtavCarticulosnoetiqueta_Jsonclick = "";
         edtavCarticulosnoetiqueta_Enabled = 1;
         edtavCarticulosnoetiqueta_Visible = 1;
         edtavCalamcenid_Jsonclick = "";
         edtavCalamcenid_Enabled = 1;
         edtavCalamcenid_Visible = 1;
         edtavCarticuloscambsid_Jsonclick = "";
         edtavCarticuloscambsid_Enabled = 1;
         edtavCarticuloscambsid_Visible = 1;
         edtavCarticulosproductoid_Jsonclick = "";
         edtavCarticulosproductoid_Enabled = 1;
         edtavCarticulosproductoid_Visible = 1;
         edtavCalmacenid_Jsonclick = "";
         edtavCalmacenid_Enabled = 1;
         edtavCalmacenid_Visible = 1;
         divEntidafederativaidfiltercontainer_Class = "AdvancedContainerItem";
         divTipobienidfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosnoetiquetafiltercontainer_Class = "AdvancedContainerItem";
         divAlamcenidfiltercontainer_Class = "AdvancedContainerItem";
         divArticuloscambsidfiltercontainer_Class = "AdvancedContainerItem";
         divArticulosproductoidfiltercontainer_Class = "AdvancedContainerItem";
         divAlmacenidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List articulos";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosproductoid',fld:'vCARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticuloscambsid',fld:'vCARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV9calamcenid',fld:'vCALAMCENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosnoetiqueta',fld:'vCARTICULOSNOETIQUETA',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV12centidafederativaid',fld:'vCENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18211',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLALMACENIDFILTER.CLICK","{handler:'E11211',iparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlmacenidfiltercontainer_Class',ctrl:'ALMACENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCalmacenid_Visible',ctrl:'vCALMACENID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSPRODUCTOIDFILTER.CLICK","{handler:'E12211',iparms:[{av:'divArticulosproductoidfiltercontainer_Class',ctrl:'ARTICULOSPRODUCTOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosproductoidfiltercontainer_Class',ctrl:'ARTICULOSPRODUCTOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosproductoid_Visible',ctrl:'vCARTICULOSPRODUCTOID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSCAMBSIDFILTER.CLICK","{handler:'E13211',iparms:[{av:'divArticuloscambsidfiltercontainer_Class',ctrl:'ARTICULOSCAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticuloscambsidfiltercontainer_Class',ctrl:'ARTICULOSCAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCarticuloscambsid_Visible',ctrl:'vCARTICULOSCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLALAMCENIDFILTER.CLICK","{handler:'E14211',iparms:[{av:'divAlamcenidfiltercontainer_Class',ctrl:'ALAMCENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divAlamcenidfiltercontainer_Class',ctrl:'ALAMCENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCalamcenid_Visible',ctrl:'vCALAMCENID',prop:'Visible'}]}");
         setEventMetadata("LBLARTICULOSNOETIQUETAFILTER.CLICK","{handler:'E15211',iparms:[{av:'divArticulosnoetiquetafiltercontainer_Class',ctrl:'ARTICULOSNOETIQUETAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divArticulosnoetiquetafiltercontainer_Class',ctrl:'ARTICULOSNOETIQUETAFILTERCONTAINER',prop:'Class'},{av:'edtavCarticulosnoetiqueta_Visible',ctrl:'vCARTICULOSNOETIQUETA',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOBIENIDFILTER.CLICK","{handler:'E16211',iparms:[{av:'divTipobienidfiltercontainer_Class',ctrl:'TIPOBIENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobienidfiltercontainer_Class',ctrl:'TIPOBIENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCtipobienid_Visible',ctrl:'vCTIPOBIENID',prop:'Visible'}]}");
         setEventMetadata("LBLENTIDAFEDERATIVAIDFILTER.CLICK","{handler:'E17211',iparms:[{av:'divEntidafederativaidfiltercontainer_Class',ctrl:'ENTIDAFEDERATIVAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEntidafederativaidfiltercontainer_Class',ctrl:'ENTIDAFEDERATIVAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCentidafederativaid_Visible',ctrl:'vCENTIDAFEDERATIVAID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21212',iparms:[{av:'A19almacenid',fld:'ALMACENID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A20articulosproductoid',fld:'ARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A21articuloscambsid',fld:'ARTICULOSCAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13palmacenid',fld:'vPALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV14particulosproductoid',fld:'vPARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV15particuloscambsid',fld:'vPARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosproductoid',fld:'vCARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticuloscambsid',fld:'vCARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV9calamcenid',fld:'vCALAMCENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosnoetiqueta',fld:'vCARTICULOSNOETIQUETA',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV12centidafederativaid',fld:'vCENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosproductoid',fld:'vCARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticuloscambsid',fld:'vCARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV9calamcenid',fld:'vCALAMCENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosnoetiqueta',fld:'vCARTICULOSNOETIQUETA',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV12centidafederativaid',fld:'vCENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosproductoid',fld:'vCARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticuloscambsid',fld:'vCARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV9calamcenid',fld:'vCALAMCENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosnoetiqueta',fld:'vCARTICULOSNOETIQUETA',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV12centidafederativaid',fld:'vCENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6calmacenid',fld:'vCALMACENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7carticulosproductoid',fld:'vCARTICULOSPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8carticuloscambsid',fld:'vCARTICULOSCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV9calamcenid',fld:'vCALAMCENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10carticulosnoetiqueta',fld:'vCARTICULOSNOETIQUETA',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV12centidafederativaid',fld:'vCENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',nv:0}],oparms:[]}");
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
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblalmacenidfilter_Jsonclick = "";
         TempTags = "";
         lblLblarticulosproductoidfilter_Jsonclick = "";
         lblLblarticuloscambsidfilter_Jsonclick = "";
         lblLblalamcenidfilter_Jsonclick = "";
         lblLblarticulosnoetiquetafilter_Jsonclick = "";
         lblLbltipobienidfilter_Jsonclick = "";
         lblLblentidafederativaidfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV19Linkselection_GXI = "";
         scmdbuf = "";
         H00212_A2proveedoresid = new int[1] ;
         H00212_n2proveedoresid = new bool[] {false} ;
         H00212_A7entidafederativaid = new int[1] ;
         H00212_n7entidafederativaid = new bool[] {false} ;
         H00212_A23tipobienid = new int[1] ;
         H00212_n23tipobienid = new bool[] {false} ;
         H00212_A155articulosnoetiqueta = new long[1] ;
         H00212_n155articulosnoetiqueta = new bool[] {false} ;
         H00212_A154alamcenid = new long[1] ;
         H00212_n154alamcenid = new bool[] {false} ;
         H00212_A21articuloscambsid = new int[1] ;
         H00212_A20articulosproductoid = new int[1] ;
         H00212_A19almacenid = new int[1] ;
         H00213_AGRID1_nRecordCount = new long[1] ;
         AV16ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00b0__default(),
            new Object[][] {
                new Object[] {
               H00212_A2proveedoresid, H00212_n2proveedoresid, H00212_A7entidafederativaid, H00212_n7entidafederativaid, H00212_A23tipobienid, H00212_n23tipobienid, H00212_A155articulosnoetiqueta, H00212_n155articulosnoetiqueta, H00212_A154alamcenid, H00212_n154alamcenid,
               H00212_A21articuloscambsid, H00212_A20articulosproductoid, H00212_A19almacenid
               }
               , new Object[] {
               H00213_AGRID1_nRecordCount
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
      private int AV6calmacenid ;
      private int AV7carticulosproductoid ;
      private int AV8carticuloscambsid ;
      private int AV11ctipobienid ;
      private int AV12centidafederativaid ;
      private int AV13palmacenid ;
      private int AV14particulosproductoid ;
      private int AV15particuloscambsid ;
      private int edtavCalmacenid_Enabled ;
      private int edtavCalmacenid_Visible ;
      private int edtavCarticulosproductoid_Enabled ;
      private int edtavCarticulosproductoid_Visible ;
      private int edtavCarticuloscambsid_Enabled ;
      private int edtavCarticuloscambsid_Visible ;
      private int edtavCalamcenid_Enabled ;
      private int edtavCalamcenid_Visible ;
      private int edtavCarticulosnoetiqueta_Enabled ;
      private int edtavCarticulosnoetiqueta_Visible ;
      private int edtavCtipobienid_Enabled ;
      private int edtavCtipobienid_Visible ;
      private int edtavCentidafederativaid_Enabled ;
      private int edtavCentidafederativaid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A19almacenid ;
      private int A20articulosproductoid ;
      private int A21articuloscambsid ;
      private int A23tipobienid ;
      private int A7entidafederativaid ;
      private int A2proveedoresid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV9calamcenid ;
      private long AV10carticulosnoetiqueta ;
      private long GRID1_nFirstRecordOnPage ;
      private long A154alamcenid ;
      private long A155articulosnoetiqueta ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divAlmacenidfiltercontainer_Class ;
      private String divArticulosproductoidfiltercontainer_Class ;
      private String divArticuloscambsidfiltercontainer_Class ;
      private String divAlamcenidfiltercontainer_Class ;
      private String divArticulosnoetiquetafiltercontainer_Class ;
      private String divTipobienidfiltercontainer_Class ;
      private String divEntidafederativaidfiltercontainer_Class ;
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
      private String divArticulosproductoidfiltercontainer_Internalname ;
      private String lblLblarticulosproductoidfilter_Internalname ;
      private String lblLblarticulosproductoidfilter_Jsonclick ;
      private String edtavCarticulosproductoid_Internalname ;
      private String edtavCarticulosproductoid_Jsonclick ;
      private String divArticuloscambsidfiltercontainer_Internalname ;
      private String lblLblarticuloscambsidfilter_Internalname ;
      private String lblLblarticuloscambsidfilter_Jsonclick ;
      private String edtavCarticuloscambsid_Internalname ;
      private String edtavCarticuloscambsid_Jsonclick ;
      private String divAlamcenidfiltercontainer_Internalname ;
      private String lblLblalamcenidfilter_Internalname ;
      private String lblLblalamcenidfilter_Jsonclick ;
      private String edtavCalamcenid_Internalname ;
      private String edtavCalamcenid_Jsonclick ;
      private String divArticulosnoetiquetafiltercontainer_Internalname ;
      private String lblLblarticulosnoetiquetafilter_Internalname ;
      private String lblLblarticulosnoetiquetafilter_Jsonclick ;
      private String edtavCarticulosnoetiqueta_Internalname ;
      private String edtavCarticulosnoetiqueta_Jsonclick ;
      private String divTipobienidfiltercontainer_Internalname ;
      private String lblLbltipobienidfilter_Internalname ;
      private String lblLbltipobienidfilter_Jsonclick ;
      private String edtavCtipobienid_Internalname ;
      private String edtavCtipobienid_Jsonclick ;
      private String divEntidafederativaidfiltercontainer_Internalname ;
      private String lblLblentidafederativaidfilter_Internalname ;
      private String lblLblentidafederativaidfilter_Jsonclick ;
      private String edtavCentidafederativaid_Internalname ;
      private String edtavCentidafederativaid_Jsonclick ;
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
      private String edtalamcenid_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtalmacenid_Internalname ;
      private String edtarticulosproductoid_Internalname ;
      private String edtarticuloscambsid_Internalname ;
      private String edtalamcenid_Internalname ;
      private String edtarticulosnoetiqueta_Internalname ;
      private String edttipobienid_Internalname ;
      private String edtentidafederativaid_Internalname ;
      private String edtproveedoresid_Internalname ;
      private String scmdbuf ;
      private String AV16ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtalmacenid_Jsonclick ;
      private String edtarticulosproductoid_Jsonclick ;
      private String edtarticuloscambsid_Jsonclick ;
      private String edtalamcenid_Jsonclick ;
      private String edtarticulosnoetiqueta_Jsonclick ;
      private String edttipobienid_Jsonclick ;
      private String edtentidafederativaid_Jsonclick ;
      private String edtproveedoresid_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n154alamcenid ;
      private bool n155articulosnoetiqueta ;
      private bool n23tipobienid ;
      private bool n7entidafederativaid ;
      private bool n2proveedoresid ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV19Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00212_A2proveedoresid ;
      private bool[] H00212_n2proveedoresid ;
      private int[] H00212_A7entidafederativaid ;
      private bool[] H00212_n7entidafederativaid ;
      private int[] H00212_A23tipobienid ;
      private bool[] H00212_n23tipobienid ;
      private long[] H00212_A155articulosnoetiqueta ;
      private bool[] H00212_n155articulosnoetiqueta ;
      private long[] H00212_A154alamcenid ;
      private bool[] H00212_n154alamcenid ;
      private int[] H00212_A21articuloscambsid ;
      private int[] H00212_A20articulosproductoid ;
      private int[] H00212_A19almacenid ;
      private long[] H00213_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_palmacenid ;
      private int aP1_particulosproductoid ;
      private int aP2_particuloscambsid ;
      private GXWebForm Form ;
   }

   public class gx00b0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00212( IGxContext context ,
                                             long AV9calamcenid ,
                                             long AV10carticulosnoetiqueta ,
                                             int AV11ctipobienid ,
                                             int AV12centidafederativaid ,
                                             long A154alamcenid ,
                                             long A155articulosnoetiqueta ,
                                             int A23tipobienid ,
                                             int A7entidafederativaid ,
                                             int AV6calmacenid ,
                                             int AV7carticulosproductoid ,
                                             int AV8carticuloscambsid )
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
         sSelectString = " proveedorid, entidadid, tipodocid, articulosnoetiqueta, alamcenid, cambsid, productoid, articulosid";
         sFromString = " FROM public.articulos";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (articulosid >= :AV6calmacenid and productoid >= :AV7carticulosproductoid and cambsid >= :AV8carticuloscambsid)";
         if ( ! (0==AV9calamcenid) )
         {
            sWhereString = sWhereString + " and (alamcenid >= :AV9calamcenid)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10carticulosnoetiqueta) )
         {
            sWhereString = sWhereString + " and (articulosnoetiqueta >= :AV10carticulosnoetiqueta)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11ctipobienid) )
         {
            sWhereString = sWhereString + " and (tipodocid >= :AV11ctipobienid)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV12centidafederativaid) )
         {
            sWhereString = sWhereString + " and (entidadid >= :AV12centidafederativaid)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY articulosid, productoid, cambsid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00213( IGxContext context ,
                                             long AV9calamcenid ,
                                             long AV10carticulosnoetiqueta ,
                                             int AV11ctipobienid ,
                                             int AV12centidafederativaid ,
                                             long A154alamcenid ,
                                             long A155articulosnoetiqueta ,
                                             int A23tipobienid ,
                                             int A7entidafederativaid ,
                                             int AV6calmacenid ,
                                             int AV7carticulosproductoid ,
                                             int AV8carticuloscambsid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.articulos";
         scmdbuf = scmdbuf + " WHERE (articulosid >= :AV6calmacenid and productoid >= :AV7carticulosproductoid and cambsid >= :AV8carticuloscambsid)";
         if ( ! (0==AV9calamcenid) )
         {
            sWhereString = sWhereString + " and (alamcenid >= :AV9calamcenid)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10carticulosnoetiqueta) )
         {
            sWhereString = sWhereString + " and (articulosnoetiqueta >= :AV10carticulosnoetiqueta)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11ctipobienid) )
         {
            sWhereString = sWhereString + " and (tipodocid >= :AV11ctipobienid)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV12centidafederativaid) )
         {
            sWhereString = sWhereString + " and (entidadid >= :AV12centidafederativaid)";
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
                     return conditional_H00212(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (int)dynConstraints[2] , (int)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (int)dynConstraints[6] , (int)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (int)dynConstraints[10] );
               case 1 :
                     return conditional_H00213(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (int)dynConstraints[2] , (int)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (int)dynConstraints[6] , (int)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (int)dynConstraints[10] );
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
          Object[] prmH00212 ;
          prmH00212 = new Object[] {
          new Object[] {"AV6calmacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7carticulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8carticuloscambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV9calamcenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10carticulosnoetiqueta",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11ctipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV12centidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00213 ;
          prmH00213 = new Object[] {
          new Object[] {"AV6calmacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV7carticulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8carticuloscambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV9calamcenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10carticulosnoetiqueta",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11ctipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV12centidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00212", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00212,11,0,false,false )
             ,new CursorDef("H00213", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00213,1,0,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
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
                   stmt.SetParameter(sIdx, (int)parms[12]);
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
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
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
                   stmt.SetParameter(sIdx, (int)parms[9]);
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
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
       }
    }

 }

}
