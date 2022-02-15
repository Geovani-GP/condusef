/*
               File: Gx00N0
        Description: Selection List producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/10/2022 22:32:6.62
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
   public class gx00n0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00n0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00n0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pproductoid )
      {
         this.AV13pproductoid = 0 ;
         executePrivate();
         aP0_pproductoid=this.AV13pproductoid;
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
               AV6cproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 9, 0)));
               AV8cproductodsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
               AV12cproductousuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
               AV15cproductofecreg = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cproductofecreg", context.localUtil.TToC( AV15cproductofecreg, 10, 8, 0, 3, "/", ":", " "));
               AV16cproductofecultact = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cproductofecultact", context.localUtil.TToC( AV16cproductofecultact, 10, 8, 0, 3, "/", ":", " "));
               AV17cpcambsid = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17cpcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17cpcambsid), 4, 0)));
               AV18cpmodeloid = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18cpmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18cpmodeloid), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
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
               AV13pproductoid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 9, 0)));
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
         PA302( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START302( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20222102232667");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00n0.aspx") + "?" + UrlEncode("" +AV13pproductoid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTODSC", AV8cproductodsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOUSUARIO", AV12cproductousuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOFECREG", context.localUtil.TToC( AV15cproductofecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOFECULTACT", context.localUtil.TToC( AV16cproductofecultact, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCPCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17cpcambsid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18cpmodeloid), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOIDFILTERCONTAINER_Class", StringUtil.RTrim( divProductoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSCFILTERCONTAINER_Class", StringUtil.RTrim( divProductodscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divProductousuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divProductofecregfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOFECULTACTFILTERCONTAINER_Class", StringUtil.RTrim( divProductofecultactfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PCAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divPcambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PMODELOIDFILTERCONTAINER_Class", StringUtil.RTrim( divPmodeloidfiltercontainer_Class));
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
            WE302( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT302( ) ;
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
         return formatLink("gx00n0.aspx") + "?" + UrlEncode("" +AV13pproductoid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00N0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List producto" ;
      }

      protected void WB300( )
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
            GxWebStd.gx_div_start( context, divProductoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductoidfilter_Internalname, "productoid", "", "", lblLblproductoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11301_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproductoid), 9, 0, ",", "")), ((edtavCproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductoid_Jsonclick, 0, "Attribute", "", "", "", edtavCproductoid_Visible, edtavCproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divProductodscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductodscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductodscfilter_Internalname, "productodsc", "", "", lblLblproductodscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12301_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductodsc_Internalname, "productodsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductodsc_Internalname, AV8cproductodsc, StringUtil.RTrim( context.localUtil.Format( AV8cproductodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductodsc_Jsonclick, 0, "Attribute", "", "", "", edtavCproductodsc_Visible, edtavCproductodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divProductousuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductousuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductousuariofilter_Internalname, "productousuario", "", "", lblLblproductousuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13301_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductousuario_Internalname, "productousuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductousuario_Internalname, AV12cproductousuario, StringUtil.RTrim( context.localUtil.Format( AV12cproductousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductousuario_Jsonclick, 0, "Attribute", "", "", "", edtavCproductousuario_Visible, edtavCproductousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divProductofecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductofecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductofecregfilter_Internalname, "productofecreg", "", "", lblLblproductofecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14301_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductofecreg_Internalname, "productofecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCproductofecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCproductofecreg_Internalname, context.localUtil.TToC( AV15cproductofecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV15cproductofecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCproductofecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divProductofecultactfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductofecultactfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductofecultactfilter_Internalname, "productofecultact", "", "", lblLblproductofecultactfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15301_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductofecultact_Internalname, "productofecultact", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCproductofecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCproductofecultact_Internalname, context.localUtil.TToC( AV16cproductofecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV16cproductofecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductofecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCproductofecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divPcambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divPcambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpcambsidfilter_Internalname, "pcambsid", "", "", lblLblpcambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16301_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCpcambsid_Internalname, "pcambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpcambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17cpcambsid), 4, 0, ",", "")), ((edtavCpcambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17cpcambsid), "ZZZ9")) : context.localUtil.Format( (decimal)(AV17cpcambsid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpcambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCpcambsid_Visible, edtavCpcambsid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_div_start( context, divPmodeloidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divPmodeloidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpmodeloidfilter_Internalname, "pmodeloid", "", "", lblLblpmodeloidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17301_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00N0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCpmodeloid_Internalname, "pmodeloid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpmodeloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18cpmodeloid), 4, 0, ",", "")), ((edtavCpmodeloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18cpmodeloid), "ZZZ9")) : context.localUtil.Format( (decimal)(AV18cpmodeloid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpmodeloid_Jsonclick, 0, "Attribute", "", "", "", edtavCpmodeloid_Visible, edtavCpmodeloid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00N0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18301_client"+"'", TempTags, "", 2, "HLP_Gx00N0.htm");
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
               context.SendWebValue( "productoid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productodsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productousuario") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A87productodsc);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A91productousuario);
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00N0.htm");
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

      protected void START302( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP300( ) ;
      }

      protected void WS302( )
      {
         START302( ) ;
         EVT302( ) ;
      }

      protected void EVT302( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV21Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A175productoid = (int)(context.localUtil.CToN( cgiGet( edtproductoid_Internalname), ",", "."));
                              A87productodsc = cgiGet( edtproductodsc_Internalname);
                              n87productodsc = false;
                              A91productousuario = cgiGet( edtproductousuario_Internalname);
                              n91productousuario = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19302 */
                                    E19302 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20302 */
                                    E20302 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cproductoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV6cproductoid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductodsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV8cproductodsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductousuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOUSUARIO"), AV12cproductousuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductofecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCPRODUCTOFECREG"), 0) != AV15cproductofecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductofecultact Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCPRODUCTOFECULTACT"), 0) != AV16cproductofecultact )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpcambsid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPCAMBSID"), ",", ".") != Convert.ToDecimal( AV17cpcambsid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpmodeloid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPMODELOID"), ",", ".") != Convert.ToDecimal( AV18cpmodeloid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21302 */
                                          E21302 ();
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

      protected void WE302( )
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

      protected void PA302( )
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
                                        int AV6cproductoid ,
                                        String AV8cproductodsc ,
                                        String AV12cproductousuario ,
                                        DateTime AV15cproductofecreg ,
                                        DateTime AV16cproductofecultact ,
                                        short AV17cpcambsid ,
                                        short AV18cpmodeloid )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF302( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSC", A87productodsc);
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A91productousuario, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTOUSUARIO", A91productousuario);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF302( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF302( )
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
                                                 AV8cproductodsc ,
                                                 AV12cproductousuario ,
                                                 AV15cproductofecreg ,
                                                 AV16cproductofecultact ,
                                                 AV17cpcambsid ,
                                                 AV18cpmodeloid ,
                                                 A87productodsc ,
                                                 A91productousuario ,
                                                 A92productofecreg ,
                                                 A93productofecultact ,
                                                 A179pcambsid ,
                                                 A180pmodeloid ,
                                                 AV6cproductoid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV8cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV8cproductodsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
            lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
            /* Using cursor H00302 */
            pr_default.execute(0, new Object[] {AV6cproductoid, lV8cproductodsc, lV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A180pmodeloid = H00302_A180pmodeloid[0];
               n180pmodeloid = H00302_n180pmodeloid[0];
               A179pcambsid = H00302_A179pcambsid[0];
               n179pcambsid = H00302_n179pcambsid[0];
               A93productofecultact = H00302_A93productofecultact[0];
               n93productofecultact = H00302_n93productofecultact[0];
               A92productofecreg = H00302_A92productofecreg[0];
               n92productofecreg = H00302_n92productofecreg[0];
               A91productousuario = H00302_A91productousuario[0];
               n91productousuario = H00302_n91productousuario[0];
               A87productodsc = H00302_A87productodsc[0];
               n87productodsc = H00302_n87productodsc[0];
               A175productoid = H00302_A175productoid[0];
               /* Execute user event: E20302 */
               E20302 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB300( ) ;
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
                                              AV8cproductodsc ,
                                              AV12cproductousuario ,
                                              AV15cproductofecreg ,
                                              AV16cproductofecultact ,
                                              AV17cpcambsid ,
                                              AV18cpmodeloid ,
                                              A87productodsc ,
                                              A91productousuario ,
                                              A92productofecreg ,
                                              A93productofecultact ,
                                              A179pcambsid ,
                                              A180pmodeloid ,
                                              AV6cproductoid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV8cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV8cproductodsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
         lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
         /* Using cursor H00303 */
         pr_default.execute(1, new Object[] {AV6cproductoid, lV8cproductodsc, lV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid});
         GRID1_nRecordCount = H00303_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV8cproductodsc, AV12cproductousuario, AV15cproductofecreg, AV16cproductofecultact, AV17cpcambsid, AV18cpmodeloid) ;
         }
         return (int)(0) ;
      }

      protected void STRUP300( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19302 */
         E19302 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPRODUCTOID");
               GX_FocusControl = edtavCproductoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cproductoid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 9, 0)));
            }
            else
            {
               AV6cproductoid = (int)(context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 9, 0)));
            }
            AV8cproductodsc = cgiGet( edtavCproductodsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
            AV12cproductousuario = cgiGet( edtavCproductousuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCproductofecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"productofecreg"}), 1, "vCPRODUCTOFECREG");
               GX_FocusControl = edtavCproductofecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15cproductofecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cproductofecreg", context.localUtil.TToC( AV15cproductofecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV15cproductofecreg = context.localUtil.CToT( cgiGet( edtavCproductofecreg_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cproductofecreg", context.localUtil.TToC( AV15cproductofecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCproductofecultact_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"productofecultact"}), 1, "vCPRODUCTOFECULTACT");
               GX_FocusControl = edtavCproductofecultact_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16cproductofecultact = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cproductofecultact", context.localUtil.TToC( AV16cproductofecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV16cproductofecultact = context.localUtil.CToT( cgiGet( edtavCproductofecultact_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cproductofecultact", context.localUtil.TToC( AV16cproductofecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpcambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpcambsid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPCAMBSID");
               GX_FocusControl = edtavCpcambsid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17cpcambsid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17cpcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17cpcambsid), 4, 0)));
            }
            else
            {
               AV17cpcambsid = (short)(context.localUtil.CToN( cgiGet( edtavCpcambsid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17cpcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17cpcambsid), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpmodeloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpmodeloid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPMODELOID");
               GX_FocusControl = edtavCpmodeloid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18cpmodeloid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18cpmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18cpmodeloid), 4, 0)));
            }
            else
            {
               AV18cpmodeloid = (short)(context.localUtil.CToN( cgiGet( edtavCpmodeloid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18cpmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18cpmodeloid), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRODUCTOID"), ",", ".") != Convert.ToDecimal( AV6cproductoid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV8cproductodsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOUSUARIO"), AV12cproductousuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCPRODUCTOFECREG"), 0) != AV15cproductofecreg )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCPRODUCTOFECULTACT"), 0) != AV16cproductofecultact )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPCAMBSID"), ",", ".") != Convert.ToDecimal( AV17cpcambsid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPMODELOID"), ",", ".") != Convert.ToDecimal( AV18cpmodeloid )) )
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
         /* Execute user event: E19302 */
         E19302 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19302( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "producto", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20302( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV21Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E21302 */
         E21302 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21302( )
      {
         /* Enter Routine */
         AV13pproductoid = A175productoid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pproductoid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pproductoid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 9, 0)));
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
         PA302( ) ;
         WS302( ) ;
         WE302( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?22305230");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222102232761");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00n0.js", "?20222102232761");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_84_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_84_idx;
         edtproductousuario_Internalname = "PRODUCTOUSUARIO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_84_fel_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_84_fel_idx;
         edtproductousuario_Internalname = "PRODUCTOUSUARIO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB300( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV21Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV21Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductodsc_Internalname,(String)A87productodsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductodsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductousuario_Internalname,(String)A91productousuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductousuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOUSUARIO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A91productousuario, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblproductoidfilter_Internalname = "LBLPRODUCTOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductoid_Internalname = "vCPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductoidfiltercontainer_Internalname = "PRODUCTOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproductodscfilter_Internalname = "LBLPRODUCTODSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductodsc_Internalname = "vCPRODUCTODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductodscfiltercontainer_Internalname = "PRODUCTODSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproductousuariofilter_Internalname = "LBLPRODUCTOUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductousuario_Internalname = "vCPRODUCTOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductousuariofiltercontainer_Internalname = "PRODUCTOUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproductofecregfilter_Internalname = "LBLPRODUCTOFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductofecreg_Internalname = "vCPRODUCTOFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductofecregfiltercontainer_Internalname = "PRODUCTOFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproductofecultactfilter_Internalname = "LBLPRODUCTOFECULTACTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductofecultact_Internalname = "vCPRODUCTOFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductofecultactfiltercontainer_Internalname = "PRODUCTOFECULTACTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpcambsidfilter_Internalname = "LBLPCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpcambsid_Internalname = "vCPCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPcambsidfiltercontainer_Internalname = "PCAMBSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpmodeloidfilter_Internalname = "LBLPMODELOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpmodeloid_Internalname = "vCPMODELOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPmodeloidfiltercontainer_Internalname = "PMODELOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtproductoid_Internalname = "PRODUCTOID";
         edtproductodsc_Internalname = "PRODUCTODSC";
         edtproductousuario_Internalname = "PRODUCTOUSUARIO";
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
         edtproductousuario_Jsonclick = "";
         edtproductodsc_Jsonclick = "";
         edtproductoid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCpmodeloid_Jsonclick = "";
         edtavCpmodeloid_Enabled = 1;
         edtavCpmodeloid_Visible = 1;
         edtavCpcambsid_Jsonclick = "";
         edtavCpcambsid_Enabled = 1;
         edtavCpcambsid_Visible = 1;
         edtavCproductofecultact_Jsonclick = "";
         edtavCproductofecultact_Enabled = 1;
         edtavCproductofecreg_Jsonclick = "";
         edtavCproductofecreg_Enabled = 1;
         edtavCproductousuario_Jsonclick = "";
         edtavCproductousuario_Enabled = 1;
         edtavCproductousuario_Visible = 1;
         edtavCproductodsc_Jsonclick = "";
         edtavCproductodsc_Enabled = 1;
         edtavCproductodsc_Visible = 1;
         edtavCproductoid_Jsonclick = "";
         edtavCproductoid_Enabled = 1;
         edtavCproductoid_Visible = 1;
         divPmodeloidfiltercontainer_Class = "AdvancedContainerItem";
         divPcambsidfiltercontainer_Class = "AdvancedContainerItem";
         divProductofecultactfiltercontainer_Class = "AdvancedContainerItem";
         divProductofecregfiltercontainer_Class = "AdvancedContainerItem";
         divProductousuariofiltercontainer_Class = "AdvancedContainerItem";
         divProductodscfiltercontainer_Class = "AdvancedContainerItem";
         divProductoidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List producto";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''},{av:'AV15cproductofecreg',fld:'vCPRODUCTOFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV16cproductofecultact',fld:'vCPRODUCTOFECULTACT',pic:'99/99/9999 99:99:99',nv:''},{av:'AV17cpcambsid',fld:'vCPCAMBSID',pic:'ZZZ9',nv:0},{av:'AV18cpmodeloid',fld:'vCPMODELOID',pic:'ZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18301',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPRODUCTOIDFILTER.CLICK","{handler:'E11301',iparms:[{av:'divProductoidfiltercontainer_Class',ctrl:'PRODUCTOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductoidfiltercontainer_Class',ctrl:'PRODUCTOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCproductoid_Visible',ctrl:'vCPRODUCTOID',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTODSCFILTER.CLICK","{handler:'E12301',iparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'},{av:'edtavCproductodsc_Visible',ctrl:'vCPRODUCTODSC',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTOUSUARIOFILTER.CLICK","{handler:'E13301',iparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCproductousuario_Visible',ctrl:'vCPRODUCTOUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTOFECREGFILTER.CLICK","{handler:'E14301',iparms:[{av:'divProductofecregfiltercontainer_Class',ctrl:'PRODUCTOFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductofecregfiltercontainer_Class',ctrl:'PRODUCTOFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLPRODUCTOFECULTACTFILTER.CLICK","{handler:'E15301',iparms:[{av:'divProductofecultactfiltercontainer_Class',ctrl:'PRODUCTOFECULTACTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductofecultactfiltercontainer_Class',ctrl:'PRODUCTOFECULTACTFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLPCAMBSIDFILTER.CLICK","{handler:'E16301',iparms:[{av:'divPcambsidfiltercontainer_Class',ctrl:'PCAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPcambsidfiltercontainer_Class',ctrl:'PCAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCpcambsid_Visible',ctrl:'vCPCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLPMODELOIDFILTER.CLICK","{handler:'E17301',iparms:[{av:'divPmodeloidfiltercontainer_Class',ctrl:'PMODELOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPmodeloidfiltercontainer_Class',ctrl:'PMODELOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCpmodeloid_Visible',ctrl:'vCPMODELOID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21302',iparms:[{av:'A175productoid',fld:'PRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pproductoid',fld:'vPPRODUCTOID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''},{av:'AV15cproductofecreg',fld:'vCPRODUCTOFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV16cproductofecultact',fld:'vCPRODUCTOFECULTACT',pic:'99/99/9999 99:99:99',nv:''},{av:'AV17cpcambsid',fld:'vCPCAMBSID',pic:'ZZZ9',nv:0},{av:'AV18cpmodeloid',fld:'vCPMODELOID',pic:'ZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''},{av:'AV15cproductofecreg',fld:'vCPRODUCTOFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV16cproductofecultact',fld:'vCPRODUCTOFECULTACT',pic:'99/99/9999 99:99:99',nv:''},{av:'AV17cpcambsid',fld:'vCPCAMBSID',pic:'ZZZ9',nv:0},{av:'AV18cpmodeloid',fld:'vCPMODELOID',pic:'ZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''},{av:'AV15cproductofecreg',fld:'vCPRODUCTOFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV16cproductofecultact',fld:'vCPRODUCTOFECULTACT',pic:'99/99/9999 99:99:99',nv:''},{av:'AV17cpcambsid',fld:'vCPCAMBSID',pic:'ZZZ9',nv:0},{av:'AV18cpmodeloid',fld:'vCPMODELOID',pic:'ZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''},{av:'AV15cproductofecreg',fld:'vCPRODUCTOFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV16cproductofecultact',fld:'vCPRODUCTOFECULTACT',pic:'99/99/9999 99:99:99',nv:''},{av:'AV17cpcambsid',fld:'vCPCAMBSID',pic:'ZZZ9',nv:0},{av:'AV18cpmodeloid',fld:'vCPMODELOID',pic:'ZZZ9',nv:0}],oparms:[]}");
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
         AV8cproductodsc = "";
         AV12cproductousuario = "";
         AV15cproductofecreg = (DateTime)(DateTime.MinValue);
         AV16cproductofecultact = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblproductoidfilter_Jsonclick = "";
         TempTags = "";
         lblLblproductodscfilter_Jsonclick = "";
         lblLblproductousuariofilter_Jsonclick = "";
         lblLblproductofecregfilter_Jsonclick = "";
         lblLblproductofecultactfilter_Jsonclick = "";
         lblLblpcambsidfilter_Jsonclick = "";
         lblLblpmodeloidfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A87productodsc = "";
         A91productousuario = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV21Linkselection_GXI = "";
         scmdbuf = "";
         lV8cproductodsc = "";
         lV12cproductousuario = "";
         A92productofecreg = (DateTime)(DateTime.MinValue);
         A93productofecultact = (DateTime)(DateTime.MinValue);
         H00302_A180pmodeloid = new short[1] ;
         H00302_n180pmodeloid = new bool[] {false} ;
         H00302_A179pcambsid = new short[1] ;
         H00302_n179pcambsid = new bool[] {false} ;
         H00302_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         H00302_n93productofecultact = new bool[] {false} ;
         H00302_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         H00302_n92productofecreg = new bool[] {false} ;
         H00302_A91productousuario = new String[] {""} ;
         H00302_n91productousuario = new bool[] {false} ;
         H00302_A87productodsc = new String[] {""} ;
         H00302_n87productodsc = new bool[] {false} ;
         H00302_A175productoid = new int[1] ;
         H00303_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00n0__default(),
            new Object[][] {
                new Object[] {
               H00302_A180pmodeloid, H00302_n180pmodeloid, H00302_A179pcambsid, H00302_n179pcambsid, H00302_A93productofecultact, H00302_n93productofecultact, H00302_A92productofecreg, H00302_n92productofecreg, H00302_A91productousuario, H00302_n91productousuario,
               H00302_A87productodsc, H00302_n87productodsc, H00302_A175productoid
               }
               , new Object[] {
               H00303_AGRID1_nRecordCount
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
      private short AV17cpcambsid ;
      private short AV18cpmodeloid ;
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
      private short A179pcambsid ;
      private short A180pmodeloid ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV6cproductoid ;
      private int AV13pproductoid ;
      private int edtavCproductoid_Enabled ;
      private int edtavCproductoid_Visible ;
      private int edtavCproductodsc_Visible ;
      private int edtavCproductodsc_Enabled ;
      private int edtavCproductousuario_Visible ;
      private int edtavCproductousuario_Enabled ;
      private int edtavCproductofecreg_Enabled ;
      private int edtavCproductofecultact_Enabled ;
      private int edtavCpcambsid_Enabled ;
      private int edtavCpcambsid_Visible ;
      private int edtavCpmodeloid_Enabled ;
      private int edtavCpmodeloid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A175productoid ;
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
      private String divProductoidfiltercontainer_Class ;
      private String divProductodscfiltercontainer_Class ;
      private String divProductousuariofiltercontainer_Class ;
      private String divProductofecregfiltercontainer_Class ;
      private String divProductofecultactfiltercontainer_Class ;
      private String divPcambsidfiltercontainer_Class ;
      private String divPmodeloidfiltercontainer_Class ;
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
      private String divProductoidfiltercontainer_Internalname ;
      private String lblLblproductoidfilter_Internalname ;
      private String lblLblproductoidfilter_Jsonclick ;
      private String edtavCproductoid_Internalname ;
      private String TempTags ;
      private String edtavCproductoid_Jsonclick ;
      private String divProductodscfiltercontainer_Internalname ;
      private String lblLblproductodscfilter_Internalname ;
      private String lblLblproductodscfilter_Jsonclick ;
      private String edtavCproductodsc_Internalname ;
      private String edtavCproductodsc_Jsonclick ;
      private String divProductousuariofiltercontainer_Internalname ;
      private String lblLblproductousuariofilter_Internalname ;
      private String lblLblproductousuariofilter_Jsonclick ;
      private String edtavCproductousuario_Internalname ;
      private String edtavCproductousuario_Jsonclick ;
      private String divProductofecregfiltercontainer_Internalname ;
      private String lblLblproductofecregfilter_Internalname ;
      private String lblLblproductofecregfilter_Jsonclick ;
      private String edtavCproductofecreg_Internalname ;
      private String edtavCproductofecreg_Jsonclick ;
      private String divProductofecultactfiltercontainer_Internalname ;
      private String lblLblproductofecultactfilter_Internalname ;
      private String lblLblproductofecultactfilter_Jsonclick ;
      private String edtavCproductofecultact_Internalname ;
      private String edtavCproductofecultact_Jsonclick ;
      private String divPcambsidfiltercontainer_Internalname ;
      private String lblLblpcambsidfilter_Internalname ;
      private String lblLblpcambsidfilter_Jsonclick ;
      private String edtavCpcambsid_Internalname ;
      private String edtavCpcambsid_Jsonclick ;
      private String divPmodeloidfiltercontainer_Internalname ;
      private String lblLblpmodeloidfilter_Internalname ;
      private String lblLblpmodeloidfilter_Jsonclick ;
      private String edtavCpmodeloid_Internalname ;
      private String edtavCpmodeloid_Jsonclick ;
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
      private String edtproductoid_Internalname ;
      private String edtproductodsc_Internalname ;
      private String edtproductousuario_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtproductoid_Jsonclick ;
      private String edtproductodsc_Jsonclick ;
      private String edtproductousuario_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV15cproductofecreg ;
      private DateTime AV16cproductofecultact ;
      private DateTime A92productofecreg ;
      private DateTime A93productofecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n87productodsc ;
      private bool n91productousuario ;
      private bool n180pmodeloid ;
      private bool n179pcambsid ;
      private bool n93productofecultact ;
      private bool n92productofecreg ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cproductodsc ;
      private String AV12cproductousuario ;
      private String A87productodsc ;
      private String A91productousuario ;
      private String AV21Linkselection_GXI ;
      private String lV8cproductodsc ;
      private String lV12cproductousuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00302_A180pmodeloid ;
      private bool[] H00302_n180pmodeloid ;
      private short[] H00302_A179pcambsid ;
      private bool[] H00302_n179pcambsid ;
      private DateTime[] H00302_A93productofecultact ;
      private bool[] H00302_n93productofecultact ;
      private DateTime[] H00302_A92productofecreg ;
      private bool[] H00302_n92productofecreg ;
      private String[] H00302_A91productousuario ;
      private bool[] H00302_n91productousuario ;
      private String[] H00302_A87productodsc ;
      private bool[] H00302_n87productodsc ;
      private int[] H00302_A175productoid ;
      private long[] H00303_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pproductoid ;
      private GXWebForm Form ;
   }

   public class gx00n0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00302( IGxContext context ,
                                             String AV8cproductodsc ,
                                             String AV12cproductousuario ,
                                             DateTime AV15cproductofecreg ,
                                             DateTime AV16cproductofecultact ,
                                             short AV17cpcambsid ,
                                             short AV18cpmodeloid ,
                                             String A87productodsc ,
                                             String A91productousuario ,
                                             DateTime A92productofecreg ,
                                             DateTime A93productofecultact ,
                                             short A179pcambsid ,
                                             short A180pmodeloid ,
                                             int AV6cproductoid )
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
         sSelectString = " pmodeloid, pcambsid, productofecultact, productofecreg, productousuario, productodsc, productoid";
         sFromString = " FROM public.producto";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (productoid >= :AV6cproductoid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV8cproductodsc)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproductousuario)) )
         {
            sWhereString = sWhereString + " and (productousuario like :lV12cproductousuario)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV15cproductofecreg) )
         {
            sWhereString = sWhereString + " and (productofecreg >= :AV15cproductofecreg)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV16cproductofecultact) )
         {
            sWhereString = sWhereString + " and (productofecultact >= :AV16cproductofecultact)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV17cpcambsid) )
         {
            sWhereString = sWhereString + " and (pcambsid >= :AV17cpcambsid)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV18cpmodeloid) )
         {
            sWhereString = sWhereString + " and (pmodeloid >= :AV18cpmodeloid)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY productoid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00303( IGxContext context ,
                                             String AV8cproductodsc ,
                                             String AV12cproductousuario ,
                                             DateTime AV15cproductofecreg ,
                                             DateTime AV16cproductofecultact ,
                                             short AV17cpcambsid ,
                                             short AV18cpmodeloid ,
                                             String A87productodsc ,
                                             String A91productousuario ,
                                             DateTime A92productofecreg ,
                                             DateTime A93productofecultact ,
                                             short A179pcambsid ,
                                             short A180pmodeloid ,
                                             int AV6cproductoid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.producto";
         scmdbuf = scmdbuf + " WHERE (productoid >= :AV6cproductoid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV8cproductodsc)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproductousuario)) )
         {
            sWhereString = sWhereString + " and (productousuario like :lV12cproductousuario)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV15cproductofecreg) )
         {
            sWhereString = sWhereString + " and (productofecreg >= :AV15cproductofecreg)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV16cproductofecultact) )
         {
            sWhereString = sWhereString + " and (productofecultact >= :AV16cproductofecultact)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV17cpcambsid) )
         {
            sWhereString = sWhereString + " and (pcambsid >= :AV17cpcambsid)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV18cpmodeloid) )
         {
            sWhereString = sWhereString + " and (pmodeloid >= :AV18cpmodeloid)";
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
                     return conditional_H00302(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H00303(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH00302 ;
          prmH00302 = new Object[] {
          new Object[] {"AV6cproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV15cproductofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV16cproductofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV17cpcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV18cpmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00303 ;
          prmH00303 = new Object[] {
          new Object[] {"AV6cproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV15cproductofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV16cproductofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV17cpcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV18cpmodeloid",NpgsqlDbType.Smallint,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00302", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00302,11,0,false,false )
             ,new CursorDef("H00303", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00303,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(4) ;
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
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
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
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                return;
       }
    }

 }

}
