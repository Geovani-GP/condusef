/*
               File: Gx0090
        Description: Selection List producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:49:32.15
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
   public class gx0090 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0090( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0090( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pmodelosid ,
                           out String aP1_pproductocambsid )
      {
         this.AV13pmodelosid = 0 ;
         this.AV14pproductocambsid = "" ;
         executePrivate();
         aP0_pmodelosid=this.AV13pmodelosid;
         aP1_pproductocambsid=this.AV14pproductocambsid;
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
               AV6cmodelosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cmodelosid), 9, 0)));
               AV7cproductocambsid = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproductocambsid", AV7cproductocambsid);
               AV8cproductodsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
               AV9cmodeloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmodeloid), 18, 0)));
               AV10cmarcaid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cmarcaid), 18, 0)));
               AV11ccategoriaid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ccategoriaid), 18, 0)));
               AV12cproductousuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
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
               AV13pmodelosid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pmodelosid), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pproductocambsid = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pproductocambsid", AV14pproductocambsid);
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
         PA0F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0F2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221233493220");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV13pmodelosid) + "," + UrlEncode(StringUtil.RTrim(AV14pproductocambsid))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCMODELOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cmodelosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOCAMBSID", AV7cproductocambsid);
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTODSC", AV8cproductodsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cmodeloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cmarcaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCATEGORIAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ccategoriaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTOUSUARIO", AV12cproductousuario);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPMODELOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pmodelosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPPRODUCTOCAMBSID", AV14pproductocambsid);
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "MODELOSIDFILTERCONTAINER_Class", StringUtil.RTrim( divModelosidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTOCAMBSIDFILTERCONTAINER_Class", StringUtil.RTrim( divProductocambsidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSCFILTERCONTAINER_Class", StringUtil.RTrim( divProductodscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MODELOIDFILTERCONTAINER_Class", StringUtil.RTrim( divModeloidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MARCAIDFILTERCONTAINER_Class", StringUtil.RTrim( divMarcaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CATEGORIAIDFILTERCONTAINER_Class", StringUtil.RTrim( divCategoriaidfiltercontainer_Class));
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
            WE0F2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0F2( ) ;
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
         return formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV13pmodelosid) + "," + UrlEncode(StringUtil.RTrim(AV14pproductocambsid)) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0090" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List producto" ;
      }

      protected void WB0F0( )
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
            GxWebStd.gx_div_start( context, divModelosidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divModelosidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmodelosidfilter_Internalname, "modelosid", "", "", lblLblmodelosidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmodelosid_Internalname, "productoid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmodelosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cmodelosid), 9, 0, ",", "")), ((edtavCmodelosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cmodelosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cmodelosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmodelosid_Jsonclick, 0, "Attribute", "", "", "", edtavCmodelosid_Visible, edtavCmodelosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divProductocambsidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProductocambsidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblproductocambsidfilter_Internalname, "productocambsid", "", "", lblLblproductocambsidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCproductocambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductocambsid_Internalname, AV7cproductocambsid, StringUtil.RTrim( context.localUtil.Format( AV7cproductocambsid, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductocambsid_Jsonclick, 0, "Attribute", "", "", "", edtavCproductocambsid_Visible, edtavCproductocambsid_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0090.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblproductodscfilter_Internalname, "productodsc", "", "", lblLblproductodscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCproductodsc_Internalname, AV8cproductodsc, StringUtil.RTrim( context.localUtil.Format( AV8cproductodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductodsc_Jsonclick, 0, "Attribute", "", "", "", edtavCproductodsc_Visible, edtavCproductodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0090.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblmodeloidfilter_Internalname, "modeloid", "", "", lblLblmodeloidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmodeloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cmodeloid), 18, 0, ",", "")), ((edtavCmodeloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cmodeloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9cmodeloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmodeloid_Jsonclick, 0, "Attribute", "", "", "", edtavCmodeloid_Visible, edtavCmodeloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblmarcaidfilter_Internalname, "marcaid", "", "", lblLblmarcaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmarcaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cmarcaid), 18, 0, ",", "")), ((edtavCmarcaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cmarcaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cmarcaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmarcaid_Jsonclick, 0, "Attribute", "", "", "", edtavCmarcaid_Visible, edtavCmarcaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblcategoriaidfilter_Internalname, "categoriaid", "", "", lblLblcategoriaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcategoriaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ccategoriaid), 18, 0, ",", "")), ((edtavCcategoriaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11ccategoriaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11ccategoriaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcategoriaid_Jsonclick, 0, "Attribute", "", "", "", edtavCcategoriaid_Visible, edtavCcategoriaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblproductousuariofilter_Internalname, "productousuario", "", "", lblLblproductousuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e170f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCproductousuario_Internalname, AV12cproductousuario, StringUtil.RTrim( context.localUtil.Format( AV12cproductousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCproductousuario_Jsonclick, 0, "Attribute", "", "", "", edtavCproductousuario_Visible, edtavCproductousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0090.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e180f1_client"+"'", TempTags, "", 2, "HLP_Gx0090.htm");
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
               context.SendWebValue( "modelosid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "productodsc") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A16productocambsid);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A87productodsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtproductodsc_Link));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0090.htm");
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

      protected void START0F2( )
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
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                              A15modelosid = (int)(context.localUtil.CToN( cgiGet( edtmodelosid_Internalname), ",", "."));
                              A16productocambsid = cgiGet( edtproductocambsid_Internalname);
                              A87productodsc = cgiGet( edtproductodsc_Internalname);
                              n87productodsc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E190F2 */
                                    E190F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E200F2 */
                                    E200F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cmodelosid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOSID"), ",", ".") != Convert.ToDecimal( AV6cmodelosid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductocambsid Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOCAMBSID"), AV7cproductocambsid) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cproductodsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV8cproductodsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmodeloid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOID"), ",", ".") != Convert.ToDecimal( AV9cmodeloid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmarcaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMARCAID"), ",", ".") != Convert.ToDecimal( AV10cmarcaid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccategoriaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCATEGORIAID"), ",", ".") != Convert.ToDecimal( AV11ccategoriaid )) )
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
                                          /* Execute user event: E210F2 */
                                          E210F2 ();
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

      protected void WE0F2( )
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

      protected void PA0F2( )
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
                                        int AV6cmodelosid ,
                                        String AV7cproductocambsid ,
                                        String AV8cproductodsc ,
                                        long AV9cmodeloid ,
                                        long AV10cmarcaid ,
                                        long AV11ccategoriaid ,
                                        String AV12cproductousuario )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF0F2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_MODELOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "MODELOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOCAMBSID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A16productocambsid, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTOCAMBSID", A16productocambsid);
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSC", A87productodsc);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0F2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0F2( )
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
                                                 AV9cmodeloid ,
                                                 AV10cmarcaid ,
                                                 AV11ccategoriaid ,
                                                 AV12cproductousuario ,
                                                 A87productodsc ,
                                                 A88modeloid ,
                                                 A89marcaid ,
                                                 A90categoriaid ,
                                                 A91productousuario ,
                                                 A16productocambsid ,
                                                 AV7cproductocambsid ,
                                                 AV6cmodelosid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                                 TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT
                                                 }
            });
            lV7cproductocambsid = StringUtil.Concat( StringUtil.RTrim( AV7cproductocambsid), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproductocambsid", AV7cproductocambsid);
            lV8cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV8cproductodsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
            lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {AV6cmodelosid, lV7cproductocambsid, lV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, lV12cproductousuario, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A91productousuario = H000F2_A91productousuario[0];
               n91productousuario = H000F2_n91productousuario[0];
               A90categoriaid = H000F2_A90categoriaid[0];
               n90categoriaid = H000F2_n90categoriaid[0];
               A89marcaid = H000F2_A89marcaid[0];
               n89marcaid = H000F2_n89marcaid[0];
               A88modeloid = H000F2_A88modeloid[0];
               n88modeloid = H000F2_n88modeloid[0];
               A87productodsc = H000F2_A87productodsc[0];
               n87productodsc = H000F2_n87productodsc[0];
               A16productocambsid = H000F2_A16productocambsid[0];
               A15modelosid = H000F2_A15modelosid[0];
               /* Execute user event: E200F2 */
               E200F2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB0F0( ) ;
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
                                              AV9cmodeloid ,
                                              AV10cmarcaid ,
                                              AV11ccategoriaid ,
                                              AV12cproductousuario ,
                                              A87productodsc ,
                                              A88modeloid ,
                                              A89marcaid ,
                                              A90categoriaid ,
                                              A91productousuario ,
                                              A16productocambsid ,
                                              AV7cproductocambsid ,
                                              AV6cmodelosid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT
                                              }
         });
         lV7cproductocambsid = StringUtil.Concat( StringUtil.RTrim( AV7cproductocambsid), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproductocambsid", AV7cproductocambsid);
         lV8cproductodsc = StringUtil.Concat( StringUtil.RTrim( AV8cproductodsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
         lV12cproductousuario = StringUtil.Concat( StringUtil.RTrim( AV12cproductousuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cproductousuario", AV12cproductousuario);
         /* Using cursor H000F3 */
         pr_default.execute(1, new Object[] {AV6cmodelosid, lV7cproductocambsid, lV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, lV12cproductousuario});
         GRID1_nRecordCount = H000F3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cmodelosid, AV7cproductocambsid, AV8cproductodsc, AV9cmodeloid, AV10cmarcaid, AV11ccategoriaid, AV12cproductousuario) ;
         }
         return (int)(0) ;
      }

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E190F2 */
         E190F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmodelosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmodelosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMODELOSID");
               GX_FocusControl = edtavCmodelosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cmodelosid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cmodelosid), 9, 0)));
            }
            else
            {
               AV6cmodelosid = (int)(context.localUtil.CToN( cgiGet( edtavCmodelosid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cmodelosid), 9, 0)));
            }
            AV7cproductocambsid = cgiGet( edtavCproductocambsid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cproductocambsid", AV7cproductocambsid);
            AV8cproductodsc = cgiGet( edtavCproductodsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cproductodsc", AV8cproductodsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMODELOID");
               GX_FocusControl = edtavCmodeloid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cmodeloid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmodeloid), 18, 0)));
            }
            else
            {
               AV9cmodeloid = (long)(context.localUtil.CToN( cgiGet( edtavCmodeloid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cmodeloid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMARCAID");
               GX_FocusControl = edtavCmarcaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cmarcaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cmarcaid), 18, 0)));
            }
            else
            {
               AV10cmarcaid = (long)(context.localUtil.CToN( cgiGet( edtavCmarcaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cmarcaid), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCATEGORIAID");
               GX_FocusControl = edtavCcategoriaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11ccategoriaid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ccategoriaid), 18, 0)));
            }
            else
            {
               AV11ccategoriaid = (long)(context.localUtil.CToN( cgiGet( edtavCcategoriaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ccategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ccategoriaid), 18, 0)));
            }
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOSID"), ",", ".") != Convert.ToDecimal( AV6cmodelosid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTOCAMBSID"), AV7cproductocambsid) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPRODUCTODSC"), AV8cproductodsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELOID"), ",", ".") != Convert.ToDecimal( AV9cmodeloid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMARCAID"), ",", ".") != Convert.ToDecimal( AV10cmarcaid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCATEGORIAID"), ",", ".") != Convert.ToDecimal( AV11ccategoriaid )) )
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
         /* Execute user event: E190F2 */
         E190F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E190F2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "producto", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV15ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E200F2( )
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
         /* Execute user event: E210F2 */
         E210F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E210F2( )
      {
         /* Enter Routine */
         AV13pmodelosid = A15modelosid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pmodelosid), 9, 0)));
         AV14pproductocambsid = A16productocambsid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pproductocambsid", AV14pproductocambsid);
         context.setWebReturnParms(new Object[] {(int)AV13pmodelosid,(String)AV14pproductocambsid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pmodelosid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pmodelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pmodelosid), 9, 0)));
         AV14pproductocambsid = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pproductocambsid", AV14pproductocambsid);
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
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?3485073");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221233493312");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx0090.js", "?20221233493312");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtmodelosid_Internalname = "MODELOSID_"+sGXsfl_84_idx;
         edtproductocambsid_Internalname = "PRODUCTOCAMBSID_"+sGXsfl_84_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtmodelosid_Internalname = "MODELOSID_"+sGXsfl_84_fel_idx;
         edtproductocambsid_Internalname = "PRODUCTOCAMBSID_"+sGXsfl_84_fel_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB0F0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( A16productocambsid)+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtmodelosid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtmodelosid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductocambsid_Internalname,(String)A16productocambsid,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductocambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtproductodsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( A16productocambsid)+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductodsc_Internalname, "Link", edtproductodsc_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductodsc_Internalname,(String)A87productodsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtproductodsc_Link,(String)"",(String)"",(String)"",(String)edtproductodsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            GxWebStd.gx_hidden_field( context, "gxhash_MODELOSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOCAMBSID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A16productocambsid, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblmodelosidfilter_Internalname = "LBLMODELOSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCmodelosid_Internalname = "vCMODELOSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divModelosidfiltercontainer_Internalname = "MODELOSIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblproductocambsidfilter_Internalname = "LBLPRODUCTOCAMBSIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCproductocambsid_Internalname = "vCPRODUCTOCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divProductocambsidfiltercontainer_Internalname = "PRODUCTOCAMBSIDFILTERCONTAINER";
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
         edtmodelosid_Internalname = "MODELOSID";
         edtproductocambsid_Internalname = "PRODUCTOCAMBSID";
         edtproductodsc_Internalname = "PRODUCTODSC";
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
         edtproductodsc_Jsonclick = "";
         edtproductocambsid_Jsonclick = "";
         edtmodelosid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtproductodsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCproductousuario_Jsonclick = "";
         edtavCproductousuario_Enabled = 1;
         edtavCproductousuario_Visible = 1;
         edtavCcategoriaid_Jsonclick = "";
         edtavCcategoriaid_Enabled = 1;
         edtavCcategoriaid_Visible = 1;
         edtavCmarcaid_Jsonclick = "";
         edtavCmarcaid_Enabled = 1;
         edtavCmarcaid_Visible = 1;
         edtavCmodeloid_Jsonclick = "";
         edtavCmodeloid_Enabled = 1;
         edtavCmodeloid_Visible = 1;
         edtavCproductodsc_Jsonclick = "";
         edtavCproductodsc_Enabled = 1;
         edtavCproductodsc_Visible = 1;
         edtavCproductocambsid_Jsonclick = "";
         edtavCproductocambsid_Enabled = 1;
         edtavCproductocambsid_Visible = 1;
         edtavCmodelosid_Jsonclick = "";
         edtavCmodelosid_Enabled = 1;
         edtavCmodelosid_Visible = 1;
         divProductousuariofiltercontainer_Class = "AdvancedContainerItem";
         divCategoriaidfiltercontainer_Class = "AdvancedContainerItem";
         divMarcaidfiltercontainer_Class = "AdvancedContainerItem";
         divModeloidfiltercontainer_Class = "AdvancedContainerItem";
         divProductodscfiltercontainer_Class = "AdvancedContainerItem";
         divProductocambsidfiltercontainer_Class = "AdvancedContainerItem";
         divModelosidfiltercontainer_Class = "AdvancedContainerItem";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cmodelosid',fld:'vCMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproductocambsid',fld:'vCPRODUCTOCAMBSID',pic:'',nv:''},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV9cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E180F1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLMODELOSIDFILTER.CLICK","{handler:'E110F1',iparms:[{av:'divModelosidfiltercontainer_Class',ctrl:'MODELOSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divModelosidfiltercontainer_Class',ctrl:'MODELOSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmodelosid_Visible',ctrl:'vCMODELOSID',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTOCAMBSIDFILTER.CLICK","{handler:'E120F1',iparms:[{av:'divProductocambsidfiltercontainer_Class',ctrl:'PRODUCTOCAMBSIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductocambsidfiltercontainer_Class',ctrl:'PRODUCTOCAMBSIDFILTERCONTAINER',prop:'Class'},{av:'edtavCproductocambsid_Visible',ctrl:'vCPRODUCTOCAMBSID',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTODSCFILTER.CLICK","{handler:'E130F1',iparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductodscfiltercontainer_Class',ctrl:'PRODUCTODSCFILTERCONTAINER',prop:'Class'},{av:'edtavCproductodsc_Visible',ctrl:'vCPRODUCTODSC',prop:'Visible'}]}");
         setEventMetadata("LBLMODELOIDFILTER.CLICK","{handler:'E140F1',iparms:[{av:'divModeloidfiltercontainer_Class',ctrl:'MODELOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divModeloidfiltercontainer_Class',ctrl:'MODELOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmodeloid_Visible',ctrl:'vCMODELOID',prop:'Visible'}]}");
         setEventMetadata("LBLMARCAIDFILTER.CLICK","{handler:'E150F1',iparms:[{av:'divMarcaidfiltercontainer_Class',ctrl:'MARCAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divMarcaidfiltercontainer_Class',ctrl:'MARCAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCmarcaid_Visible',ctrl:'vCMARCAID',prop:'Visible'}]}");
         setEventMetadata("LBLCATEGORIAIDFILTER.CLICK","{handler:'E160F1',iparms:[{av:'divCategoriaidfiltercontainer_Class',ctrl:'CATEGORIAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divCategoriaidfiltercontainer_Class',ctrl:'CATEGORIAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCcategoriaid_Visible',ctrl:'vCCATEGORIAID',prop:'Visible'}]}");
         setEventMetadata("LBLPRODUCTOUSUARIOFILTER.CLICK","{handler:'E170F1',iparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divProductousuariofiltercontainer_Class',ctrl:'PRODUCTOUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCproductousuario_Visible',ctrl:'vCPRODUCTOUSUARIO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E210F2',iparms:[{av:'A15modelosid',fld:'MODELOSID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A16productocambsid',fld:'PRODUCTOCAMBSID',pic:'',hsh:true,nv:''}],oparms:[{av:'AV13pmodelosid',fld:'vPMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV14pproductocambsid',fld:'vPPRODUCTOCAMBSID',pic:'',nv:''}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cmodelosid',fld:'vCMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproductocambsid',fld:'vCPRODUCTOCAMBSID',pic:'',nv:''},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV9cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cmodelosid',fld:'vCMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproductocambsid',fld:'vCPRODUCTOCAMBSID',pic:'',nv:''},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV9cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cmodelosid',fld:'vCMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproductocambsid',fld:'vCPRODUCTOCAMBSID',pic:'',nv:''},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV9cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cmodelosid',fld:'vCMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV7cproductocambsid',fld:'vCPRODUCTOCAMBSID',pic:'',nv:''},{av:'AV8cproductodsc',fld:'vCPRODUCTODSC',pic:'',nv:''},{av:'AV9cmodeloid',fld:'vCMODELOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10cmarcaid',fld:'vCMARCAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11ccategoriaid',fld:'vCCATEGORIAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV12cproductousuario',fld:'vCPRODUCTOUSUARIO',pic:'',nv:''}],oparms:[]}");
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
         AV7cproductocambsid = "";
         AV8cproductodsc = "";
         AV12cproductousuario = "";
         GXKey = "";
         AV14pproductocambsid = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblmodelosidfilter_Jsonclick = "";
         TempTags = "";
         lblLblproductocambsidfilter_Jsonclick = "";
         lblLblproductodscfilter_Jsonclick = "";
         lblLblmodeloidfilter_Jsonclick = "";
         lblLblmarcaidfilter_Jsonclick = "";
         lblLblcategoriaidfilter_Jsonclick = "";
         lblLblproductousuariofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A16productocambsid = "";
         A87productodsc = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV7cproductocambsid = "";
         lV8cproductodsc = "";
         lV12cproductousuario = "";
         A91productousuario = "";
         H000F2_A91productousuario = new String[] {""} ;
         H000F2_n91productousuario = new bool[] {false} ;
         H000F2_A90categoriaid = new long[1] ;
         H000F2_n90categoriaid = new bool[] {false} ;
         H000F2_A89marcaid = new long[1] ;
         H000F2_n89marcaid = new bool[] {false} ;
         H000F2_A88modeloid = new long[1] ;
         H000F2_n88modeloid = new bool[] {false} ;
         H000F2_A87productodsc = new String[] {""} ;
         H000F2_n87productodsc = new bool[] {false} ;
         H000F2_A16productocambsid = new String[] {""} ;
         H000F2_A15modelosid = new int[1] ;
         H000F3_AGRID1_nRecordCount = new long[1] ;
         AV15ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0090__default(),
            new Object[][] {
                new Object[] {
               H000F2_A91productousuario, H000F2_n91productousuario, H000F2_A90categoriaid, H000F2_n90categoriaid, H000F2_A89marcaid, H000F2_n89marcaid, H000F2_A88modeloid, H000F2_n88modeloid, H000F2_A87productodsc, H000F2_n87productodsc,
               H000F2_A16productocambsid, H000F2_A15modelosid
               }
               , new Object[] {
               H000F3_AGRID1_nRecordCount
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
      private int AV6cmodelosid ;
      private int AV13pmodelosid ;
      private int edtavCmodelosid_Enabled ;
      private int edtavCmodelosid_Visible ;
      private int edtavCproductocambsid_Visible ;
      private int edtavCproductocambsid_Enabled ;
      private int edtavCproductodsc_Visible ;
      private int edtavCproductodsc_Enabled ;
      private int edtavCmodeloid_Enabled ;
      private int edtavCmodeloid_Visible ;
      private int edtavCmarcaid_Enabled ;
      private int edtavCmarcaid_Visible ;
      private int edtavCcategoriaid_Enabled ;
      private int edtavCcategoriaid_Visible ;
      private int edtavCproductousuario_Visible ;
      private int edtavCproductousuario_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A15modelosid ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV9cmodeloid ;
      private long AV10cmarcaid ;
      private long AV11ccategoriaid ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long A88modeloid ;
      private long A89marcaid ;
      private long A90categoriaid ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divModelosidfiltercontainer_Class ;
      private String divProductocambsidfiltercontainer_Class ;
      private String divProductodscfiltercontainer_Class ;
      private String divModeloidfiltercontainer_Class ;
      private String divMarcaidfiltercontainer_Class ;
      private String divCategoriaidfiltercontainer_Class ;
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
      private String divModelosidfiltercontainer_Internalname ;
      private String lblLblmodelosidfilter_Internalname ;
      private String lblLblmodelosidfilter_Jsonclick ;
      private String edtavCmodelosid_Internalname ;
      private String TempTags ;
      private String edtavCmodelosid_Jsonclick ;
      private String divProductocambsidfiltercontainer_Internalname ;
      private String lblLblproductocambsidfilter_Internalname ;
      private String lblLblproductocambsidfilter_Jsonclick ;
      private String edtavCproductocambsid_Internalname ;
      private String edtavCproductocambsid_Jsonclick ;
      private String divProductodscfiltercontainer_Internalname ;
      private String lblLblproductodscfilter_Internalname ;
      private String lblLblproductodscfilter_Jsonclick ;
      private String edtavCproductodsc_Internalname ;
      private String edtavCproductodsc_Jsonclick ;
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
      private String edtproductodsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtmodelosid_Internalname ;
      private String edtproductocambsid_Internalname ;
      private String edtproductodsc_Internalname ;
      private String scmdbuf ;
      private String AV15ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtmodelosid_Jsonclick ;
      private String edtproductocambsid_Jsonclick ;
      private String edtproductodsc_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n87productodsc ;
      private bool n91productousuario ;
      private bool n90categoriaid ;
      private bool n89marcaid ;
      private bool n88modeloid ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cproductocambsid ;
      private String AV8cproductodsc ;
      private String AV12cproductousuario ;
      private String AV14pproductocambsid ;
      private String A16productocambsid ;
      private String A87productodsc ;
      private String AV18Linkselection_GXI ;
      private String lV7cproductocambsid ;
      private String lV8cproductodsc ;
      private String lV12cproductousuario ;
      private String A91productousuario ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000F2_A91productousuario ;
      private bool[] H000F2_n91productousuario ;
      private long[] H000F2_A90categoriaid ;
      private bool[] H000F2_n90categoriaid ;
      private long[] H000F2_A89marcaid ;
      private bool[] H000F2_n89marcaid ;
      private long[] H000F2_A88modeloid ;
      private bool[] H000F2_n88modeloid ;
      private String[] H000F2_A87productodsc ;
      private bool[] H000F2_n87productodsc ;
      private String[] H000F2_A16productocambsid ;
      private int[] H000F2_A15modelosid ;
      private long[] H000F3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pmodelosid ;
      private String aP1_pproductocambsid ;
      private GXWebForm Form ;
   }

   public class gx0090__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000F2( IGxContext context ,
                                             String AV8cproductodsc ,
                                             long AV9cmodeloid ,
                                             long AV10cmarcaid ,
                                             long AV11ccategoriaid ,
                                             String AV12cproductousuario ,
                                             String A87productodsc ,
                                             long A88modeloid ,
                                             long A89marcaid ,
                                             long A90categoriaid ,
                                             String A91productousuario ,
                                             String A16productocambsid ,
                                             String AV7cproductocambsid ,
                                             int AV6cmodelosid )
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
         sSelectString = " productousuario, categoriaid, marcaid, modeloid, productodsc, cambsid, productoid";
         sFromString = " FROM public.producto";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (productoid >= :AV6cmodelosid)";
         sWhereString = sWhereString + " and (cambsid like :lV7cproductocambsid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV8cproductodsc)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cmodeloid) )
         {
            sWhereString = sWhereString + " and (modeloid >= :AV9cmodeloid)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cmarcaid) )
         {
            sWhereString = sWhereString + " and (marcaid >= :AV10cmarcaid)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11ccategoriaid) )
         {
            sWhereString = sWhereString + " and (categoriaid >= :AV11ccategoriaid)";
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

      protected Object[] conditional_H000F3( IGxContext context ,
                                             String AV8cproductodsc ,
                                             long AV9cmodeloid ,
                                             long AV10cmarcaid ,
                                             long AV11ccategoriaid ,
                                             String AV12cproductousuario ,
                                             String A87productodsc ,
                                             long A88modeloid ,
                                             long A89marcaid ,
                                             long A90categoriaid ,
                                             String A91productousuario ,
                                             String A16productocambsid ,
                                             String AV7cproductocambsid ,
                                             int AV6cmodelosid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.producto";
         scmdbuf = scmdbuf + " WHERE (productoid >= :AV6cmodelosid)";
         scmdbuf = scmdbuf + " and (cambsid like :lV7cproductocambsid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cproductodsc)) )
         {
            sWhereString = sWhereString + " and (productodsc like :lV8cproductodsc)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cmodeloid) )
         {
            sWhereString = sWhereString + " and (modeloid >= :AV9cmodeloid)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cmarcaid) )
         {
            sWhereString = sWhereString + " and (marcaid >= :AV10cmarcaid)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11ccategoriaid) )
         {
            sWhereString = sWhereString + " and (categoriaid >= :AV11ccategoriaid)";
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
                     return conditional_H000F2(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
               case 1 :
                     return conditional_H000F3(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] );
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
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"AV6cmodelosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cproductocambsid",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV8cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV9cmodeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10cmarcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11ccategoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH000F3 ;
          prmH000F3 = new Object[] {
          new Object[] {"AV6cmodelosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV7cproductocambsid",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"lV8cproductodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"AV9cmodeloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV10cmarcaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"AV11ccategoriaid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV12cproductousuario",NpgsqlDbType.Varchar,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,11,0,false,false )
             ,new CursorDef("H000F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F3,1,0,false,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
