/*
               File: Gx00M0
        Description: Selection List producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:1:19.3
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
   public class gx00m0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00m0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00m0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pproductoid ,
                           out int aP1_pcambsid )
      {
         this.AV13pproductoid = 0 ;
         this.AV14pcambsid = 0 ;
         executePrivate();
         aP0_pproductoid=this.AV13pproductoid;
         aP1_pcambsid=this.AV14pcambsid;
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
               AV6cproductoid = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 4, 0)));
               AV7ccambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ccambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ccambsid), 9, 0)));
               AV8cmodeloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cmodeloid), 18, 0)));
               AV9cmarcaid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmarcaid), 18, 0)));
               AV10ccategoriaid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ccategoriaid), 18, 0)));
               AV11cproductodsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproductodsc", AV11cproductodsc);
               AV12cproductousuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
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
               AV13pproductoid = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pcambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pcambsid), 9, 0)));
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
         PA2P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2P2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202212901199");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00m0.aspx") + "?" + UrlEncode("" +AV13pproductoid) + "," + UrlEncode("" +AV14pcambsid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproductoid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ccambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cmodeloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cmarcaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCATEGORIAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ccategoriaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTODSC", AV11cproductodsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOUSUARIO", AV12cproductousuario);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pproductoid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pcambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOIDFILTERCONTAINER_Class", StringUtil.RTrim( divProductoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divCambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MODELOIDFILTERCONTAINER_Class", StringUtil.RTrim( divModeloidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MARCAIDFILTERCONTAINER_Class", StringUtil.RTrim( divMarcaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CATEGORIAIDFILTERCONTAINER_Class", StringUtil.RTrim( divCategoriaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSCFILTERCONTAINER_Class", StringUtil.RTrim( divProductodscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divProductousuariofiltercontainer_Class));
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
            WE2P2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2P2( ) ;
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
         return formatLink("gx00m0.aspx") + "?" + UrlEncode("" +AV13pproductoid) + "," + UrlEncode("" +AV14pcambsid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00M0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List producto" ;
      }

      protected void WB2P0( )
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
            GxWebStd.gx_label_ctrl( context, lblLblproductoidfilter_Internalname, "productoid", "", "", lblLblproductoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e112p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cproductoid), 4, 0, ",", "")), ((edtavCproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cproductoid), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cproductoid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductoid_Jsonclick, 0, "Attribute", "", "", "", edtavCproductoid_Visible, edtavCproductoid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_div_start( context, divCambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcambsidfilter_Internalname, "cambsid", "", "", lblLblcambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e122p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ccambsid), 9, 0, ",", "")), ((edtavCcambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7ccambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7ccambsid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCcambsid_Visible, edtavCcambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_div_start( context, divModeloidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divModeloidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmodeloidfilter_Internalname, "modeloid", "", "", lblLblmodeloidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e132p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmodeloid_Internalname, "modeloid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmodeloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cmodeloid), 18, 0, ",", "")), ((edtavCmodeloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cmodeloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cmodeloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmodeloid_Jsonclick, 0, "Attribute", "", "", "", edtavCmodeloid_Visible, edtavCmodeloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_div_start( context, divMarcaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divMarcaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmarcaidfilter_Internalname, "marcaid", "", "", lblLblmarcaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e142p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmarcaid_Internalname, "marcaid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmarcaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cmarcaid), 18, 0, ",", "")), ((edtavCmarcaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cmarcaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9cmarcaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmarcaid_Jsonclick, 0, "Attribute", "", "", "", edtavCmarcaid_Visible, edtavCmarcaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_div_start( context, divCategoriaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCategoriaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcategoriaidfilter_Internalname, "categoriaid", "", "", lblLblcategoriaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e152p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcategoriaid_Internalname, "categoriaid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcategoriaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ccategoriaid), 18, 0, ",", "")), ((edtavCcategoriaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10ccategoriaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10ccategoriaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcategoriaid_Jsonclick, 0, "Attribute", "", "", "", edtavCcategoriaid_Visible, edtavCcategoriaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblproductodscfilter_Internalname, "productodsc", "", "", lblLblproductodscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e162p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductodsc_Internalname, AV11cproductodsc, StringUtil.RTrim( context.localUtil.Format( AV11cproductodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductodsc_Jsonclick, 0, "Attribute", "", "", "", edtavCproductodsc_Visible, edtavCproductodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblproductousuariofilter_Internalname, "productousuario", "", "", lblLblproductousuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e172p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00M0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductousuario_Internalname, AV12cproductousuario, StringUtil.RTrim( context.localUtil.Format( AV12cproductousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductousuario_Jsonclick, 0, "Attribute", "", "", "", edtavCproductousuario_Visible, edtavCproductousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00M0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e182p1_client"+"'", TempTags, "", 2, "HLP_Gx00M0.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "modeloid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "marcaid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "categoriaid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productousuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productofecreg") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tipobienid") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A88modeloid), 18, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtmodeloid_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A89marcaid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A90categoriaid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A91productousuario);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00M0.htm");
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

      protected void START2P2( )
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
         STRUP2P0( ) ;
      }

      protected void WS2P2( )
      {
         START2P2( ) ;
         EVT2P2( ) ;
      }

      protected void EVT2P2( )
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
                              A175productoid = (short)(context.localUtil.CToN( cgiGet( edtproductoid_Internalname), ",", "."));
                              A25cambsid = (int)(context.localUtil.CToN( cgiGet( edtcambsid_Internalname), ",", "."));
                              A88modeloid = (long)(context.localUtil.CToN( cgiGet( edtmodeloid_Internalname), ",", "."));
                              n88modeloid = false;
                              A89marcaid = (long)(context.localUtil.CToN( cgiGet( edtmarcaid_Internalname), ",", "."));
                              n89marcaid = false;
                              A90categoriaid = (long)(context.localUtil.CToN( cgiGet( edtcategoriaid_Internalname), ",", "."));
                              n90categoriaid = false;
                              A91productousuario = cgiGet( edtproductousuario_Internalname);
                              n91productousuario = false;
                              A92productofecreg = context.localUtil.CToT( cgiGet( edtproductofecreg_Internalname), 0);
                              n92productofecreg = false;
                              A23tipobienid = (int)(context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E192P2 */
                                    E192P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E202P2 */
                                    E202P2 ();
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
                                       /* Set Refresh If Ccambsid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCAMBSID"), ",", ".") != Convert.ToDecimal( AV7ccambsid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmodeloid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOID"), ",", ".") != Convert.ToDecimal( AV8cmodeloid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmarcaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMARCAID"), ",", ".") != Convert.ToDecimal( AV9cmarcaid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccategoriaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCATEGORIAID"), ",", ".") != Convert.ToDecimal( AV10ccategoriaid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductodsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV11cproductodsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductousuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOUSUARIO"), AV12cproductousuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E212P2 */
                                          E212P2 ();
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

      protected void WE2P2( )
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

      protected void PA2P2( )
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
                                        short AV6cproductoid ,
                                        int AV7ccambsid ,
                                        long AV8cmodeloid ,
                                        long AV9cmarcaid ,
                                        long AV10ccategoriaid ,
                                        String AV11cproductodsc ,
                                        String AV12cproductousuario )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF2P2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A175productoid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "PRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "CAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_MODELOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A88modeloid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "MODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A88modeloid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_MARCAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A89marcaid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "MARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A89marcaid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CATEGORIAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A90categoriaid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "CATEGORIAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A90categoriaid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A91productousuario, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTOUSUARIO", A91productousuario);
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOFECREG", GetSecureSignedToken( "", context.localUtil.Format( A92productofecreg, "99/99/9999 99:99:99")));
         GxWebStd.gx_hidden_field( context, "PRODUCTOFECREG", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "TIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2P2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2P2( )
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
                                                 AV8cmodeloid ,
                                                 AV9cmarcaid ,
                                                 AV10ccategoriaid ,
                                                 AV11cproductodsc ,
                                                 AV12cproductousuario ,
                                                 A88modeloid ,
                                                 A89marcaid ,
                                                 A90categoriaid ,
                                                 A87productodsc ,
                                                 A91productousuario ,
                                                 AV6cproductoid ,
                                                 AV7ccambsid },
                                                 new int[] {
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT
                                                 }
            });
            lV11cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV11cproductodsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproductodsc", AV11cproductodsc);
            lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
            /* Using cursor H002P2 */
            pr_default.execute(0, new Object[] {AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, lV11cproductodsc, lV12cproductousuario, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A87productodsc = H002P2_A87productodsc[0];
               n87productodsc = H002P2_n87productodsc[0];
               A23tipobienid = H002P2_A23tipobienid[0];
               A92productofecreg = H002P2_A92productofecreg[0];
               n92productofecreg = H002P2_n92productofecreg[0];
               A91productousuario = H002P2_A91productousuario[0];
               n91productousuario = H002P2_n91productousuario[0];
               A90categoriaid = H002P2_A90categoriaid[0];
               n90categoriaid = H002P2_n90categoriaid[0];
               A89marcaid = H002P2_A89marcaid[0];
               n89marcaid = H002P2_n89marcaid[0];
               A88modeloid = H002P2_A88modeloid[0];
               n88modeloid = H002P2_n88modeloid[0];
               A25cambsid = H002P2_A25cambsid[0];
               A175productoid = H002P2_A175productoid[0];
               /* Execute user event: E202P2 */
               E202P2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB2P0( ) ;
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
                                              AV8cmodeloid ,
                                              AV9cmarcaid ,
                                              AV10ccategoriaid ,
                                              AV11cproductodsc ,
                                              AV12cproductousuario ,
                                              A88modeloid ,
                                              A89marcaid ,
                                              A90categoriaid ,
                                              A87productodsc ,
                                              A91productousuario ,
                                              AV6cproductoid ,
                                              AV7ccambsid },
                                              new int[] {
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT
                                              }
         });
         lV11cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV11cproductodsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproductodsc", AV11cproductodsc);
         lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
         /* Using cursor H002P3 */
         pr_default.execute(1, new Object[] {AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, lV11cproductodsc, lV12cproductousuario});
         GRID1_nRecordCount = H002P3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cproductoid, AV7ccambsid, AV8cmodeloid, AV9cmarcaid, AV10ccategoriaid, AV11cproductodsc, AV12cproductousuario) ;
         }
         return (int)(0) ;
      }

      protected void STRUP2P0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E192P2 */
         E192P2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPRODUCTOID");
               GX_FocusControl = edtavCproductoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cproductoid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 4, 0)));
            }
            else
            {
               AV6cproductoid = (short)(context.localUtil.CToN( cgiGet( edtavCproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cproductoid), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcambsid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCAMBSID");
               GX_FocusControl = edtavCcambsid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7ccambsid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ccambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ccambsid), 9, 0)));
            }
            else
            {
               AV7ccambsid = (int)(context.localUtil.CToN( cgiGet( edtavCcambsid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ccambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ccambsid), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMODELOID");
               GX_FocusControl = edtavCmodeloid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cmodeloid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cmodeloid), 18, 0)));
            }
            else
            {
               AV8cmodeloid = (long)(context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cmodeloid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMARCAID");
               GX_FocusControl = edtavCmarcaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cmarcaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmarcaid), 18, 0)));
            }
            else
            {
               AV9cmarcaid = (long)(context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmarcaid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCATEGORIAID");
               GX_FocusControl = edtavCcategoriaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10ccategoriaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ccategoriaid), 18, 0)));
            }
            else
            {
               AV10ccategoriaid = (long)(context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ccategoriaid), 18, 0)));
            }
            AV11cproductodsc = cgiGet( edtavCproductodsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cproductodsc", AV11cproductodsc);
            AV12cproductousuario = cgiGet( edtavCproductousuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCAMBSID"), ",", ".") != Convert.ToDecimal( AV7ccambsid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOID"), ",", ".") != Convert.ToDecimal( AV8cmodeloid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMARCAID"), ",", ".") != Convert.ToDecimal( AV9cmarcaid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCATEGORIAID"), ",", ".") != Convert.ToDecimal( AV10ccategoriaid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV11cproductodsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOUSUARIO"), AV12cproductousuario) != 0 )
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
         /* Execute user event: E192P2 */
         E192P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E192P2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci?n %1", "producto", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV15ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E202P2( )
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
         /* Execute user event: E212P2 */
         E212P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E212P2( )
      {
         /* Enter Routine */
         AV13pproductoid = A175productoid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 4, 0)));
         AV14pcambsid = A25cambsid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pcambsid), 9, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pproductoid,(int)AV14pcambsid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pproductoid = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pproductoid), 4, 0)));
         AV14pcambsid = Convert.ToInt32(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pcambsid), 9, 0)));
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
         PA2P2( ) ;
         WS2P2( ) ;
         WE2P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022129012020");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00m0.js", "?2022129012020");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_84_idx;
         edtcambsid_Internalname = "CAMBSID_"+sGXsfl_84_idx;
         edtmodeloid_Internalname = "MODELOID_"+sGXsfl_84_idx;
         edtmarcaid_Internalname = "MARCAID_"+sGXsfl_84_idx;
         edtcategoriaid_Internalname = "CATEGORIAID_"+sGXsfl_84_idx;
         edtproductousuario_Internalname = "PRODUCTOUSUARIO_"+sGXsfl_84_idx;
         edtproductofecreg_Internalname = "PRODUCTOFECREG_"+sGXsfl_84_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_84_fel_idx;
         edtcambsid_Internalname = "CAMBSID_"+sGXsfl_84_fel_idx;
         edtmodeloid_Internalname = "MODELOID_"+sGXsfl_84_fel_idx;
         edtmarcaid_Internalname = "MARCAID_"+sGXsfl_84_fel_idx;
         edtcategoriaid_Internalname = "CATEGORIAID_"+sGXsfl_84_fel_idx;
         edtproductousuario_Internalname = "PRODUCTOUSUARIO_"+sGXsfl_84_fel_idx;
         edtproductofecreg_Internalname = "PRODUCTOFECREG_"+sGXsfl_84_fel_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB2P0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A175productoid), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcambsid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtmodeloid_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodeloid_Internalname, "Link", edtmodeloid_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtmodeloid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A88modeloid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A88modeloid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtmodeloid_Link,(String)"",(String)"",(String)"",(String)edtmodeloid_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtmarcaid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A89marcaid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A89marcaid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtmarcaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategoriaid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A90categoriaid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A90categoriaid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategoriaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductousuario_Internalname,(String)A91productousuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductousuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductofecreg_Internalname,context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A92productofecreg, "99/99/9999 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductofecreg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A175productoid), "ZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_CAMBSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_MODELOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A88modeloid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_MARCAID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A89marcaid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_CATEGORIAID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A90categoriaid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOUSUARIO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A91productousuario, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOFECREG"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( A92productofecreg, "99/99/9999 99:99:99")));
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
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
         lblLblcambsidfilter_Internalname = "LBLCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCcambsid_Internalname = "vCCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divCambsidfiltercontainer_Internalname = "CAMBSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblmodeloidfilter_Internalname = "LBLMODELOIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCmodeloid_Internalname = "vCMODELOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divModeloidfiltercontainer_Internalname = "MODELOIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblmarcaidfilter_Internalname = "LBLMARCAIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCmarcaid_Internalname = "vCMARCAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divMarcaidfiltercontainer_Internalname = "MARCAIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblcategoriaidfilter_Internalname = "LBLCATEGORIAIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCcategoriaid_Internalname = "vCCATEGORIAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divCategoriaidfiltercontainer_Internalname = "CATEGORIAIDFILTERCONTAINER";
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
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtproductoid_Internalname = "PRODUCTOID";
         edtcambsid_Internalname = "CAMBSID";
         edtmodeloid_Internalname = "MODELOID";
         edtmarcaid_Internalname = "MARCAID";
         edtcategoriaid_Internalname = "CATEGORIAID";
         edtproductousuario_Internalname = "PRODUCTOUSUARIO";
         edtproductofecreg_Internalname = "PRODUCTOFECREG";
         edttipobienid_Internalname = "TIPOBIENID";
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
         edttipobienid_Jsonclick = "";
         edtproductofecreg_Jsonclick = "";
         edtproductousuario_Jsonclick = "";
         edtcategoriaid_Jsonclick = "";
         edtmarcaid_Jsonclick = "";
         edtmodeloid_Jsonclick = "";
         edtcambsid_Jsonclick = "";
         edtproductoid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtmodeloid_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCproductousuario_Jsonclick = "";
         edtavCproductousuario_Enabled = 1;
         edtavCproductousuario_Visible = 1;
         edtavCproductodsc_Jsonclick = "";
         edtavCproductodsc_Enabled = 1;
         edtavCproductodsc_Visible = 1;
         edtavCcategoriaid_Jsonclick = "";
         edtavCcategoriaid_Enabled = 1;
         edtavCcategoriaid_Visible = 1;
         edtavCmarcaid_Jsonclick = "";
         edtavCmarcaid_Enabled = 1;
         edtavCmarcaid_Visible = 1;
         edtavCmodeloid_Jsonclick = "";
         edtavCmodeloid_Enabled = 1;
         edtavCmodeloid_Visible = 1;
         edtavCcambsid_Jsonclick = "";
         edtavCcambsid_Enabled = 1;
         edtavCcambsid_Visible = 1;
         edtavCproductoid_Jsonclick = "";
         edtavCproductoid_Enabled = 1;
         edtavCproductoid_Visible = 1;
         divProductousuariofiltercontainer_Class = "AdvancedContainerItem";
         divProductodscfiltercontainer_Class = "AdvancedContainerItem";
         divCategoriaidfiltercontainer_Class = "AdvancedContainerItem";
         divMarcaidfiltercontainer_Class = "AdvancedContainerItem";
         divModeloidfiltercontainer_Class = "AdvancedContainerItem";
         divCambsidfiltercontainer_Class = "AdvancedContainerItem";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV7ccambsid',fld:'vCCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E182P1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPRODUCTOIDFILTER.CLICK","{handler:'E112P1',iparms:[{av:'divProductoidfiltercontainer_Class',ctrl:'PRODUCTOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductoidfiltercontainer_Class',ctrl:'PRODUCTOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCproductoid_Visible',ctrl:'vCPRODUCTOID',prop:'Visible'}]}");
         setEventMetadata("LBLCAMBSIDFILTER.CLICK","{handler:'E122P1',iparms:[{av:'divCambsidfiltercontainer_Class',ctrl:'CAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divCambsidfiltercontainer_Class',ctrl:'CAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCcambsid_Visible',ctrl:'vCCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLMODELOIDFILTER.CLICK","{handler:'E132P1',iparms:[{av:'divModeloidfiltercontainer_Class',ctrl:'MODELOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divModeloidfiltercontainer_Class',ctrl:'MODELOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmodeloid_Visible',ctrl:'vCMODELOID',prop:'Visible'}]}");
         setEventMetadata("LBLMARCAIDFILTER.CLICK","{handler:'E142P1',iparms:[{av:'divMarcaidfiltercontainer_Class',ctrl:'MARCAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divMarcaidfiltercontainer_Class',ctrl:'MARCAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmarcaid_Visible',ctrl:'vCMARCAID',prop:'Visible'}]}");
         setEventMetadata("LBLCATEGORIAIDFILTER.CLICK","{handler:'E152P1',iparms:[{av:'divCategoriaidfiltercontainer_Class',ctrl:'CATEGORIAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divCategoriaidfiltercontainer_Class',ctrl:'CATEGORIAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCcategoriaid_Visible',ctrl:'vCCATEGORIAID',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTODSCFILTER.CLICK","{handler:'E162P1',iparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'},{av:'edtavCproductodsc_Visible',ctrl:'vCPRODUCTODSC',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTOUSUARIOFILTER.CLICK","{handler:'E172P1',iparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCproductousuario_Visible',ctrl:'vCPRODUCTOUSUARIO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E212P2',iparms:[{av:'A175productoid',fld:'PRODUCTOID',pic:'ZZZ9',hsh:true,nv:0},{av:'A25cambsid',fld:'CAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13pproductoid',fld:'vPPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV14pcambsid',fld:'vPCAMBSID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV7ccambsid',fld:'vCCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV7ccambsid',fld:'vCCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV7ccambsid',fld:'vCCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cproductoid',fld:'vCPRODUCTOID',pic:'ZZZ9',nv:0},{av:'AV7ccambsid',fld:'vCCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
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
         AV11cproductodsc = "";
         AV12cproductousuario = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblproductoidfilter_Jsonclick = "";
         TempTags = "";
         lblLblcambsidfilter_Jsonclick = "";
         lblLblmodeloidfilter_Jsonclick = "";
         lblLblmarcaidfilter_Jsonclick = "";
         lblLblcategoriaidfilter_Jsonclick = "";
         lblLblproductodscfilter_Jsonclick = "";
         lblLblproductousuariofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A91productousuario = "";
         A92productofecreg = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV11cproductodsc = "";
         lV12cproductousuario = "";
         A87productodsc = "";
         H002P2_A87productodsc = new String[] {""} ;
         H002P2_n87productodsc = new bool[] {false} ;
         H002P2_A23tipobienid = new int[1] ;
         H002P2_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         H002P2_n92productofecreg = new bool[] {false} ;
         H002P2_A91productousuario = new String[] {""} ;
         H002P2_n91productousuario = new bool[] {false} ;
         H002P2_A90categoriaid = new long[1] ;
         H002P2_n90categoriaid = new bool[] {false} ;
         H002P2_A89marcaid = new long[1] ;
         H002P2_n89marcaid = new bool[] {false} ;
         H002P2_A88modeloid = new long[1] ;
         H002P2_n88modeloid = new bool[] {false} ;
         H002P2_A25cambsid = new int[1] ;
         H002P2_A175productoid = new short[1] ;
         H002P3_AGRID1_nRecordCount = new long[1] ;
         AV15ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00m0__default(),
            new Object[][] {
                new Object[] {
               H002P2_A87productodsc, H002P2_n87productodsc, H002P2_A23tipobienid, H002P2_A92productofecreg, H002P2_n92productofecreg, H002P2_A91productousuario, H002P2_n91productousuario, H002P2_A90categoriaid, H002P2_n90categoriaid, H002P2_A89marcaid,
               H002P2_n89marcaid, H002P2_A88modeloid, H002P2_n88modeloid, H002P2_A25cambsid, H002P2_A175productoid
               }
               , new Object[] {
               H002P3_AGRID1_nRecordCount
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
      private short AV6cproductoid ;
      private short AV13pproductoid ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A175productoid ;
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
      private int AV7ccambsid ;
      private int AV14pcambsid ;
      private int edtavCproductoid_Enabled ;
      private int edtavCproductoid_Visible ;
      private int edtavCcambsid_Enabled ;
      private int edtavCcambsid_Visible ;
      private int edtavCmodeloid_Enabled ;
      private int edtavCmodeloid_Visible ;
      private int edtavCmarcaid_Enabled ;
      private int edtavCmarcaid_Visible ;
      private int edtavCcategoriaid_Enabled ;
      private int edtavCcategoriaid_Visible ;
      private int edtavCproductodsc_Visible ;
      private int edtavCproductodsc_Enabled ;
      private int edtavCproductousuario_Visible ;
      private int edtavCproductousuario_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A25cambsid ;
      private int A23tipobienid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV8cmodeloid ;
      private long AV9cmarcaid ;
      private long AV10ccategoriaid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A88modeloid ;
      private long A89marcaid ;
      private long A90categoriaid ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divProductoidfiltercontainer_Class ;
      private String divCambsidfiltercontainer_Class ;
      private String divModeloidfiltercontainer_Class ;
      private String divMarcaidfiltercontainer_Class ;
      private String divCategoriaidfiltercontainer_Class ;
      private String divProductodscfiltercontainer_Class ;
      private String divProductousuariofiltercontainer_Class ;
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
      private String divCambsidfiltercontainer_Internalname ;
      private String lblLblcambsidfilter_Internalname ;
      private String lblLblcambsidfilter_Jsonclick ;
      private String edtavCcambsid_Internalname ;
      private String edtavCcambsid_Jsonclick ;
      private String divModeloidfiltercontainer_Internalname ;
      private String lblLblmodeloidfilter_Internalname ;
      private String lblLblmodeloidfilter_Jsonclick ;
      private String edtavCmodeloid_Internalname ;
      private String edtavCmodeloid_Jsonclick ;
      private String divMarcaidfiltercontainer_Internalname ;
      private String lblLblmarcaidfilter_Internalname ;
      private String lblLblmarcaidfilter_Jsonclick ;
      private String edtavCmarcaid_Internalname ;
      private String edtavCmarcaid_Jsonclick ;
      private String divCategoriaidfiltercontainer_Internalname ;
      private String lblLblcategoriaidfilter_Internalname ;
      private String lblLblcategoriaidfilter_Jsonclick ;
      private String edtavCcategoriaid_Internalname ;
      private String edtavCcategoriaid_Jsonclick ;
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
      private String edtmodeloid_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtproductoid_Internalname ;
      private String edtcambsid_Internalname ;
      private String edtmodeloid_Internalname ;
      private String edtmarcaid_Internalname ;
      private String edtcategoriaid_Internalname ;
      private String edtproductousuario_Internalname ;
      private String edtproductofecreg_Internalname ;
      private String edttipobienid_Internalname ;
      private String scmdbuf ;
      private String AV15ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtproductoid_Jsonclick ;
      private String edtcambsid_Jsonclick ;
      private String edtmodeloid_Jsonclick ;
      private String edtmarcaid_Jsonclick ;
      private String edtcategoriaid_Jsonclick ;
      private String edtproductousuario_Jsonclick ;
      private String edtproductofecreg_Jsonclick ;
      private String edttipobienid_Jsonclick ;
      private String div_Internalname ;
      private DateTime A92productofecreg ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n88modeloid ;
      private bool n89marcaid ;
      private bool n90categoriaid ;
      private bool n91productousuario ;
      private bool n92productofecreg ;
      private bool n87productodsc ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV11cproductodsc ;
      private String AV12cproductousuario ;
      private String A91productousuario ;
      private String AV18Linkselection_GXI ;
      private String lV11cproductodsc ;
      private String lV12cproductousuario ;
      private String A87productodsc ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002P2_A87productodsc ;
      private bool[] H002P2_n87productodsc ;
      private int[] H002P2_A23tipobienid ;
      private DateTime[] H002P2_A92productofecreg ;
      private bool[] H002P2_n92productofecreg ;
      private String[] H002P2_A91productousuario ;
      private bool[] H002P2_n91productousuario ;
      private long[] H002P2_A90categoriaid ;
      private bool[] H002P2_n90categoriaid ;
      private long[] H002P2_A89marcaid ;
      private bool[] H002P2_n89marcaid ;
      private long[] H002P2_A88modeloid ;
      private bool[] H002P2_n88modeloid ;
      private int[] H002P2_A25cambsid ;
      private short[] H002P2_A175productoid ;
      private long[] H002P3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pproductoid ;
      private int aP1_pcambsid ;
      private GXWebForm Form ;
   }

   public class gx00m0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002P2( IGxContext context ,
                                             long AV8cmodeloid ,
                                             long AV9cmarcaid ,
                                             long AV10ccategoriaid ,
                                             String AV11cproductodsc ,
                                             String AV12cproductousuario ,
                                             long A88modeloid ,
                                             long A89marcaid ,
                                             long A90categoriaid ,
                                             String A87productodsc ,
                                             String A91productousuario ,
                                             short AV6cproductoid ,
                                             int AV7ccambsid )
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
         sSelectString = " productodsc, tipobienid, productofecreg, productousuario, categoriaid, marcaid, modeloid, cambsid, productoid";
         sFromString = " FROM producto";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (productoid >= :AV6cproductoid and cambsid >= :AV7ccambsid)";
         if ( ! (0==AV8cmodeloid) )
         {
            sWhereString = sWhereString + " and (modeloid >= :AV8cmodeloid)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cmarcaid) )
         {
            sWhereString = sWhereString + " and (marcaid >= :AV9cmarcaid)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10ccategoriaid) )
         {
            sWhereString = sWhereString + " and (categoriaid >= :AV10ccategoriaid)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV11cproductodsc)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproductousuario)) )
         {
            sWhereString = sWhereString + " and (productousuario like :lV12cproductousuario)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY productoid, cambsid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H002P3( IGxContext context ,
                                             long AV8cmodeloid ,
                                             long AV9cmarcaid ,
                                             long AV10ccategoriaid ,
                                             String AV11cproductodsc ,
                                             String AV12cproductousuario ,
                                             long A88modeloid ,
                                             long A89marcaid ,
                                             long A90categoriaid ,
                                             String A87productodsc ,
                                             String A91productousuario ,
                                             short AV6cproductoid ,
                                             int AV7ccambsid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM producto";
         scmdbuf = scmdbuf + " WHERE (productoid >= :AV6cproductoid and cambsid >= :AV7ccambsid)";
         if ( ! (0==AV8cmodeloid) )
         {
            sWhereString = sWhereString + " and (modeloid >= :AV8cmodeloid)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cmarcaid) )
         {
            sWhereString = sWhereString + " and (marcaid >= :AV9cmarcaid)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10ccategoriaid) )
         {
            sWhereString = sWhereString + " and (categoriaid >= :AV10ccategoriaid)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV11cproductodsc)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cproductousuario)) )
         {
            sWhereString = sWhereString + " and (productousuario like :lV12cproductousuario)";
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
                     return conditional_H002P2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] );
               case 1 :
                     return conditional_H002P3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] );
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
          Object[] prmH002P2 ;
          prmH002P2 = new Object[] {
          new Object[] {"AV6cproductoid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV7ccambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8cmodeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV9cmarcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10ccategoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV11cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH002P3 ;
          prmH002P3 = new Object[] {
          new Object[] {"AV6cproductoid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"AV7ccambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"AV8cmodeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV9cmarcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10ccategoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV11cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002P2,11,0,false,false )
             ,new CursorDef("H002P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002P3,1,0,false,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
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
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
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
