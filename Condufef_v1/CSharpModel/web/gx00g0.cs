/*
               File: Gx00G0
        Description: Selection List origen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:43.90
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
   public class gx00g0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00g0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00g0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_porigenid )
      {
         this.AV13porigenid = 0 ;
         executePrivate();
         aP0_porigenid=this.AV13porigenid;
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
               AV6corigenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6corigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6corigenid), 18, 0)));
               AV7corigendscorta = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7corigendscorta", AV7corigendscorta);
               AV8corigendsclarga = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8corigendsclarga", AV8corigendsclarga);
               AV9corigenusuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9corigenusuario", AV9corigenusuario);
               AV10corigentotal = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10corigentotal", AV10corigentotal);
               AV11corigenfecreg = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11corigenfecreg", context.localUtil.TToC( AV11corigenfecreg, 10, 8, 0, 3, "/", ":", " "));
               AV12corigenfecultact = context.localUtil.ParseDTimeParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12corigenfecultact", context.localUtil.TToC( AV12corigenfecultact, 10, 8, 0, 3, "/", ":", " "));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
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
               AV13porigenid = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13porigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13porigenid), 18, 0)));
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
         PA232( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START232( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215594396");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00g0.aspx") + "?" + UrlEncode("" +AV13porigenid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6corigenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENDSCORTA", AV7corigendscorta);
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENDSCLARGA", AV8corigendsclarga);
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENUSUARIO", AV9corigenusuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENTOTAL", AV10corigentotal);
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENFECREG", context.localUtil.TToC( AV11corigenfecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCORIGENFECULTACT", context.localUtil.TToC( AV12corigenfecultact, 10, 8, 0, 3, "/", ":", " "));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPORIGENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13porigenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENIDFILTERCONTAINER_Class", StringUtil.RTrim( divOrigenidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENDSCORTAFILTERCONTAINER_Class", StringUtil.RTrim( divOrigendscortafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENDSCLARGAFILTERCONTAINER_Class", StringUtil.RTrim( divOrigendsclargafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divOrigenusuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENTOTALFILTERCONTAINER_Class", StringUtil.RTrim( divOrigentotalfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divOrigenfecregfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORIGENFECULTACTFILTERCONTAINER_Class", StringUtil.RTrim( divOrigenfecultactfiltercontainer_Class));
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
            WE232( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT232( ) ;
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
         return formatLink("gx00g0.aspx") + "?" + UrlEncode("" +AV13porigenid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00G0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List origen" ;
      }

      protected void WB230( )
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
            GxWebStd.gx_div_start( context, divOrigenidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigenidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigenidfilter_Internalname, "origenid", "", "", lblLblorigenidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigenid_Internalname, "origenid", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCorigenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6corigenid), 18, 0, ",", "")), ((edtavCorigenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6corigenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6corigenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigenid_Jsonclick, 0, "Attribute", "", "", "", edtavCorigenid_Visible, edtavCorigenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigendscortafiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigendscortafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigendscortafilter_Internalname, "origendscorta", "", "", lblLblorigendscortafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigendscorta_Internalname, "origendscorta", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCorigendscorta_Internalname, AV7corigendscorta, StringUtil.RTrim( context.localUtil.Format( AV7corigendscorta, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigendscorta_Jsonclick, 0, "Attribute", "", "", "", edtavCorigendscorta_Visible, edtavCorigendscorta_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigendsclargafiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigendsclargafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigendsclargafilter_Internalname, "origendsclarga", "", "", lblLblorigendsclargafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigendsclarga_Internalname, "origendsclarga", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCorigendsclarga_Internalname, AV8corigendsclarga, StringUtil.RTrim( context.localUtil.Format( AV8corigendsclarga, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigendsclarga_Jsonclick, 0, "Attribute", "", "", "", edtavCorigendsclarga_Visible, edtavCorigendsclarga_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigenusuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigenusuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigenusuariofilter_Internalname, "origenusuario", "", "", lblLblorigenusuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigenusuario_Internalname, "origenusuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCorigenusuario_Internalname, AV9corigenusuario, StringUtil.RTrim( context.localUtil.Format( AV9corigenusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigenusuario_Jsonclick, 0, "Attribute", "", "", "", edtavCorigenusuario_Visible, edtavCorigenusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigentotalfiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigentotalfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigentotalfilter_Internalname, "origentotal", "", "", lblLblorigentotalfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigentotal_Internalname, "origentotal", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCorigentotal_Internalname, AV10corigentotal, StringUtil.RTrim( context.localUtil.Format( AV10corigentotal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigentotal_Jsonclick, 0, "Attribute", "", "", "", edtavCorigentotal_Visible, edtavCorigentotal_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigenfecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigenfecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigenfecregfilter_Internalname, "origenfecreg", "", "", lblLblorigenfecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16231_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigenfecreg_Internalname, "origenfecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCorigenfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCorigenfecreg_Internalname, context.localUtil.TToC( AV11corigenfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV11corigenfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigenfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCorigenfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_div_start( context, divOrigenfecultactfiltercontainer_Internalname, 1, 0, "px", 0, "px", divOrigenfecultactfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorigenfecultactfilter_Internalname, "origenfecultact", "", "", lblLblorigenfecultactfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17231_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00G0.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCorigenfecultact_Internalname, "origenfecultact", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCorigenfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCorigenfecultact_Internalname, context.localUtil.TToC( AV12corigenfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV12corigenfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCorigenfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCorigenfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00G0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18231_client"+"'", TempTags, "", 2, "HLP_Gx00G0.htm");
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
               context.SendWebValue( "origenid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "origendscorta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "origenusuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "origenfecreg") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "origenfecultact") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A120origendscorta);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtorigendscorta_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A122origenusuario);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00G0.htm");
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

      protected void START232( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List origen", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP230( ) ;
      }

      protected void WS232( )
      {
         START232( ) ;
         EVT232( ) ;
      }

      protected void EVT232( )
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
                              A10origenid = (long)(context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", "."));
                              A120origendscorta = cgiGet( edtorigendscorta_Internalname);
                              n120origendscorta = false;
                              A122origenusuario = cgiGet( edtorigenusuario_Internalname);
                              n122origenusuario = false;
                              A124origenfecreg = context.localUtil.CToT( cgiGet( edtorigenfecreg_Internalname), 0);
                              n124origenfecreg = false;
                              A125origenfecultact = context.localUtil.CToT( cgiGet( edtorigenfecultact_Internalname), 0);
                              n125origenfecultact = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19232 */
                                    E19232 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E20232 */
                                    E20232 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Corigenid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCORIGENID"), ",", ".") != Convert.ToDecimal( AV6corigenid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigendscorta Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENDSCORTA"), AV7corigendscorta) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigendsclarga Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENDSCLARGA"), AV8corigendsclarga) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigenusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENUSUARIO"), AV9corigenusuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigentotal Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENTOTAL"), AV10corigentotal) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigenfecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCORIGENFECREG"), 0) != AV11corigenfecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Corigenfecultact Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCORIGENFECULTACT"), 0) != AV12corigenfecultact )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E21232 */
                                          E21232 ();
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

      protected void WE232( )
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

      protected void PA232( )
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
                                        long AV6corigenid ,
                                        String AV7corigendscorta ,
                                        String AV8corigendsclarga ,
                                        String AV9corigenusuario ,
                                        String AV10corigentotal ,
                                        DateTime AV11corigenfecreg ,
                                        DateTime AV12corigenfecultact )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF232( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ORIGENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ORIGENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORIGENDSCORTA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A120origendscorta, ""))));
         GxWebStd.gx_hidden_field( context, "ORIGENDSCORTA", A120origendscorta);
         GxWebStd.gx_hidden_field( context, "gxhash_ORIGENUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A122origenusuario, ""))));
         GxWebStd.gx_hidden_field( context, "ORIGENUSUARIO", A122origenusuario);
         GxWebStd.gx_hidden_field( context, "gxhash_ORIGENFECREG", GetSecureSignedToken( "", context.localUtil.Format( A124origenfecreg, "99/99/9999 99:99:99")));
         GxWebStd.gx_hidden_field( context, "ORIGENFECREG", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "gxhash_ORIGENFECULTACT", GetSecureSignedToken( "", context.localUtil.Format( A125origenfecultact, "99/99/9999 99:99:99")));
         GxWebStd.gx_hidden_field( context, "ORIGENFECULTACT", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF232( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF232( )
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
                                                 AV7corigendscorta ,
                                                 AV8corigendsclarga ,
                                                 AV9corigenusuario ,
                                                 AV10corigentotal ,
                                                 AV11corigenfecreg ,
                                                 AV12corigenfecultact ,
                                                 A120origendscorta ,
                                                 A121origendsclarga ,
                                                 A122origenusuario ,
                                                 A123origentotal ,
                                                 A124origenfecreg ,
                                                 A125origenfecultact ,
                                                 AV6corigenid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            });
            lV7corigendscorta = StringUtil.Concat( StringUtil.RTrim( AV7corigendscorta), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7corigendscorta", AV7corigendscorta);
            lV8corigendsclarga = StringUtil.Concat( StringUtil.RTrim( AV8corigendsclarga), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8corigendsclarga", AV8corigendsclarga);
            lV9corigenusuario = StringUtil.Concat( StringUtil.RTrim( AV9corigenusuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9corigenusuario", AV9corigenusuario);
            lV10corigentotal = StringUtil.Concat( StringUtil.RTrim( AV10corigentotal), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10corigentotal", AV10corigentotal);
            /* Using cursor H00232 */
            pr_default.execute(0, new Object[] {AV6corigenid, lV7corigendscorta, lV8corigendsclarga, lV9corigenusuario, lV10corigentotal, AV11corigenfecreg, AV12corigenfecultact, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A123origentotal = H00232_A123origentotal[0];
               n123origentotal = H00232_n123origentotal[0];
               A121origendsclarga = H00232_A121origendsclarga[0];
               n121origendsclarga = H00232_n121origendsclarga[0];
               A125origenfecultact = H00232_A125origenfecultact[0];
               n125origenfecultact = H00232_n125origenfecultact[0];
               A124origenfecreg = H00232_A124origenfecreg[0];
               n124origenfecreg = H00232_n124origenfecreg[0];
               A122origenusuario = H00232_A122origenusuario[0];
               n122origenusuario = H00232_n122origenusuario[0];
               A120origendscorta = H00232_A120origendscorta[0];
               n120origendscorta = H00232_n120origendscorta[0];
               A10origenid = H00232_A10origenid[0];
               /* Execute user event: E20232 */
               E20232 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB230( ) ;
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
                                              AV7corigendscorta ,
                                              AV8corigendsclarga ,
                                              AV9corigenusuario ,
                                              AV10corigentotal ,
                                              AV11corigenfecreg ,
                                              AV12corigenfecultact ,
                                              A120origendscorta ,
                                              A121origendsclarga ,
                                              A122origenusuario ,
                                              A123origentotal ,
                                              A124origenfecreg ,
                                              A125origenfecultact ,
                                              AV6corigenid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         });
         lV7corigendscorta = StringUtil.Concat( StringUtil.RTrim( AV7corigendscorta), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7corigendscorta", AV7corigendscorta);
         lV8corigendsclarga = StringUtil.Concat( StringUtil.RTrim( AV8corigendsclarga), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8corigendsclarga", AV8corigendsclarga);
         lV9corigenusuario = StringUtil.Concat( StringUtil.RTrim( AV9corigenusuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9corigenusuario", AV9corigenusuario);
         lV10corigentotal = StringUtil.Concat( StringUtil.RTrim( AV10corigentotal), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10corigentotal", AV10corigentotal);
         /* Using cursor H00233 */
         pr_default.execute(1, new Object[] {AV6corigenid, lV7corigendscorta, lV8corigendsclarga, lV9corigenusuario, lV10corigentotal, AV11corigenfecreg, AV12corigenfecultact});
         GRID1_nRecordCount = H00233_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6corigenid, AV7corigendscorta, AV8corigendsclarga, AV9corigenusuario, AV10corigentotal, AV11corigenfecreg, AV12corigenfecultact) ;
         }
         return (int)(0) ;
      }

      protected void STRUP230( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E19232 */
         E19232 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCorigenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCorigenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCORIGENID");
               GX_FocusControl = edtavCorigenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6corigenid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6corigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6corigenid), 18, 0)));
            }
            else
            {
               AV6corigenid = (long)(context.localUtil.CToN( cgiGet( edtavCorigenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6corigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6corigenid), 18, 0)));
            }
            AV7corigendscorta = cgiGet( edtavCorigendscorta_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7corigendscorta", AV7corigendscorta);
            AV8corigendsclarga = cgiGet( edtavCorigendsclarga_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8corigendsclarga", AV8corigendsclarga);
            AV9corigenusuario = cgiGet( edtavCorigenusuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9corigenusuario", AV9corigenusuario);
            AV10corigentotal = cgiGet( edtavCorigentotal_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10corigentotal", AV10corigentotal);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCorigenfecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"origenfecreg"}), 1, "vCORIGENFECREG");
               GX_FocusControl = edtavCorigenfecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11corigenfecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11corigenfecreg", context.localUtil.TToC( AV11corigenfecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV11corigenfecreg = context.localUtil.CToT( cgiGet( edtavCorigenfecreg_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11corigenfecreg", context.localUtil.TToC( AV11corigenfecreg, 10, 8, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCorigenfecultact_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"origenfecultact"}), 1, "vCORIGENFECULTACT");
               GX_FocusControl = edtavCorigenfecultact_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12corigenfecultact = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12corigenfecultact", context.localUtil.TToC( AV12corigenfecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12corigenfecultact = context.localUtil.CToT( cgiGet( edtavCorigenfecultact_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12corigenfecultact", context.localUtil.TToC( AV12corigenfecultact, 10, 8, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCORIGENID"), ",", ".") != Convert.ToDecimal( AV6corigenid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENDSCORTA"), AV7corigendscorta) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENDSCLARGA"), AV8corigendsclarga) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENUSUARIO"), AV9corigenusuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCORIGENTOTAL"), AV10corigentotal) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCORIGENFECREG"), 0) != AV11corigenfecreg )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCORIGENFECULTACT"), 0) != AV12corigenfecultact )
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
         /* Execute user event: E19232 */
         E19232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19232( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "origen", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20232( )
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
         /* Execute user event: E21232 */
         E21232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21232( )
      {
         /* Enter Routine */
         AV13porigenid = A10origenid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13porigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13porigenid), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV13porigenid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13porigenid = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13porigenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13porigenid), 18, 0)));
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
         PA232( ) ;
         WS232( ) ;
         WE232( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215594498");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx00g0.js", "?2022215594498");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtorigenid_Internalname = "ORIGENID_"+sGXsfl_84_idx;
         edtorigendscorta_Internalname = "ORIGENDSCORTA_"+sGXsfl_84_idx;
         edtorigenusuario_Internalname = "ORIGENUSUARIO_"+sGXsfl_84_idx;
         edtorigenfecreg_Internalname = "ORIGENFECREG_"+sGXsfl_84_idx;
         edtorigenfecultact_Internalname = "ORIGENFECULTACT_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtorigenid_Internalname = "ORIGENID_"+sGXsfl_84_fel_idx;
         edtorigendscorta_Internalname = "ORIGENDSCORTA_"+sGXsfl_84_fel_idx;
         edtorigenusuario_Internalname = "ORIGENUSUARIO_"+sGXsfl_84_fel_idx;
         edtorigenfecreg_Internalname = "ORIGENFECREG_"+sGXsfl_84_fel_idx;
         edtorigenfecultact_Internalname = "ORIGENFECULTACT_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB230( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtorigenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtorigenid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtorigendscorta_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigendscorta_Internalname, "Link", edtorigendscorta_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtorigendscorta_Internalname,(String)A120origendscorta,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtorigendscorta_Link,(String)"",(String)"",(String)"",(String)edtorigendscorta_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtorigenusuario_Internalname,(String)A122origenusuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtorigenusuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtorigenfecreg_Internalname,context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A124origenfecreg, "99/99/9999 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtorigenfecreg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtorigenfecultact_Internalname,context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A125origenfecultact, "99/99/9999 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtorigenfecultact_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_ORIGENID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_ORIGENDSCORTA"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A120origendscorta, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_ORIGENUSUARIO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A122origenusuario, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_ORIGENFECREG"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( A124origenfecreg, "99/99/9999 99:99:99")));
            GxWebStd.gx_hidden_field( context, "gxhash_ORIGENFECULTACT"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( A125origenfecultact, "99/99/9999 99:99:99")));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblorigenidfilter_Internalname = "LBLORIGENIDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigenid_Internalname = "vCORIGENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigenidfiltercontainer_Internalname = "ORIGENIDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigendscortafilter_Internalname = "LBLORIGENDSCORTAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigendscorta_Internalname = "vCORIGENDSCORTA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigendscortafiltercontainer_Internalname = "ORIGENDSCORTAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigendsclargafilter_Internalname = "LBLORIGENDSCLARGAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigendsclarga_Internalname = "vCORIGENDSCLARGA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigendsclargafiltercontainer_Internalname = "ORIGENDSCLARGAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigenusuariofilter_Internalname = "LBLORIGENUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigenusuario_Internalname = "vCORIGENUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigenusuariofiltercontainer_Internalname = "ORIGENUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigentotalfilter_Internalname = "LBLORIGENTOTALFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigentotal_Internalname = "vCORIGENTOTAL";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigentotalfiltercontainer_Internalname = "ORIGENTOTALFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigenfecregfilter_Internalname = "LBLORIGENFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigenfecreg_Internalname = "vCORIGENFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigenfecregfiltercontainer_Internalname = "ORIGENFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLblorigenfecultactfilter_Internalname = "LBLORIGENFECULTACTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCorigenfecultact_Internalname = "vCORIGENFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divOrigenfecultactfiltercontainer_Internalname = "ORIGENFECULTACTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtorigenid_Internalname = "ORIGENID";
         edtorigendscorta_Internalname = "ORIGENDSCORTA";
         edtorigenusuario_Internalname = "ORIGENUSUARIO";
         edtorigenfecreg_Internalname = "ORIGENFECREG";
         edtorigenfecultact_Internalname = "ORIGENFECULTACT";
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
         edtorigenfecultact_Jsonclick = "";
         edtorigenfecreg_Jsonclick = "";
         edtorigenusuario_Jsonclick = "";
         edtorigendscorta_Jsonclick = "";
         edtorigenid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtorigendscorta_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCorigenfecultact_Jsonclick = "";
         edtavCorigenfecultact_Enabled = 1;
         edtavCorigenfecreg_Jsonclick = "";
         edtavCorigenfecreg_Enabled = 1;
         edtavCorigentotal_Jsonclick = "";
         edtavCorigentotal_Enabled = 1;
         edtavCorigentotal_Visible = 1;
         edtavCorigenusuario_Jsonclick = "";
         edtavCorigenusuario_Enabled = 1;
         edtavCorigenusuario_Visible = 1;
         edtavCorigendsclarga_Jsonclick = "";
         edtavCorigendsclarga_Enabled = 1;
         edtavCorigendsclarga_Visible = 1;
         edtavCorigendscorta_Jsonclick = "";
         edtavCorigendscorta_Enabled = 1;
         edtavCorigendscorta_Visible = 1;
         edtavCorigenid_Jsonclick = "";
         edtavCorigenid_Enabled = 1;
         edtavCorigenid_Visible = 1;
         divOrigenfecultactfiltercontainer_Class = "AdvancedContainerItem";
         divOrigenfecregfiltercontainer_Class = "AdvancedContainerItem";
         divOrigentotalfiltercontainer_Class = "AdvancedContainerItem";
         divOrigenusuariofiltercontainer_Class = "AdvancedContainerItem";
         divOrigendsclargafiltercontainer_Class = "AdvancedContainerItem";
         divOrigendscortafiltercontainer_Class = "AdvancedContainerItem";
         divOrigenidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List origen";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6corigenid',fld:'vCORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7corigendscorta',fld:'vCORIGENDSCORTA',pic:'',nv:''},{av:'AV8corigendsclarga',fld:'vCORIGENDSCLARGA',pic:'',nv:''},{av:'AV9corigenusuario',fld:'vCORIGENUSUARIO',pic:'',nv:''},{av:'AV10corigentotal',fld:'vCORIGENTOTAL',pic:'',nv:''},{av:'AV11corigenfecreg',fld:'vCORIGENFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12corigenfecultact',fld:'vCORIGENFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18231',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLORIGENIDFILTER.CLICK","{handler:'E11231',iparms:[{av:'divOrigenidfiltercontainer_Class',ctrl:'ORIGENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigenidfiltercontainer_Class',ctrl:'ORIGENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCorigenid_Visible',ctrl:'vCORIGENID',prop:'Visible'}]}");
         setEventMetadata("LBLORIGENDSCORTAFILTER.CLICK","{handler:'E12231',iparms:[{av:'divOrigendscortafiltercontainer_Class',ctrl:'ORIGENDSCORTAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigendscortafiltercontainer_Class',ctrl:'ORIGENDSCORTAFILTERCONTAINER',prop:'Class'},{av:'edtavCorigendscorta_Visible',ctrl:'vCORIGENDSCORTA',prop:'Visible'}]}");
         setEventMetadata("LBLORIGENDSCLARGAFILTER.CLICK","{handler:'E13231',iparms:[{av:'divOrigendsclargafiltercontainer_Class',ctrl:'ORIGENDSCLARGAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigendsclargafiltercontainer_Class',ctrl:'ORIGENDSCLARGAFILTERCONTAINER',prop:'Class'},{av:'edtavCorigendsclarga_Visible',ctrl:'vCORIGENDSCLARGA',prop:'Visible'}]}");
         setEventMetadata("LBLORIGENUSUARIOFILTER.CLICK","{handler:'E14231',iparms:[{av:'divOrigenusuariofiltercontainer_Class',ctrl:'ORIGENUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigenusuariofiltercontainer_Class',ctrl:'ORIGENUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCorigenusuario_Visible',ctrl:'vCORIGENUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLORIGENTOTALFILTER.CLICK","{handler:'E15231',iparms:[{av:'divOrigentotalfiltercontainer_Class',ctrl:'ORIGENTOTALFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigentotalfiltercontainer_Class',ctrl:'ORIGENTOTALFILTERCONTAINER',prop:'Class'},{av:'edtavCorigentotal_Visible',ctrl:'vCORIGENTOTAL',prop:'Visible'}]}");
         setEventMetadata("LBLORIGENFECREGFILTER.CLICK","{handler:'E16231',iparms:[{av:'divOrigenfecregfiltercontainer_Class',ctrl:'ORIGENFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigenfecregfiltercontainer_Class',ctrl:'ORIGENFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLORIGENFECULTACTFILTER.CLICK","{handler:'E17231',iparms:[{av:'divOrigenfecultactfiltercontainer_Class',ctrl:'ORIGENFECULTACTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divOrigenfecultactfiltercontainer_Class',ctrl:'ORIGENFECULTACTFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E21232',iparms:[{av:'A10origenid',fld:'ORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV13porigenid',fld:'vPORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6corigenid',fld:'vCORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7corigendscorta',fld:'vCORIGENDSCORTA',pic:'',nv:''},{av:'AV8corigendsclarga',fld:'vCORIGENDSCLARGA',pic:'',nv:''},{av:'AV9corigenusuario',fld:'vCORIGENUSUARIO',pic:'',nv:''},{av:'AV10corigentotal',fld:'vCORIGENTOTAL',pic:'',nv:''},{av:'AV11corigenfecreg',fld:'vCORIGENFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12corigenfecultact',fld:'vCORIGENFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6corigenid',fld:'vCORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7corigendscorta',fld:'vCORIGENDSCORTA',pic:'',nv:''},{av:'AV8corigendsclarga',fld:'vCORIGENDSCLARGA',pic:'',nv:''},{av:'AV9corigenusuario',fld:'vCORIGENUSUARIO',pic:'',nv:''},{av:'AV10corigentotal',fld:'vCORIGENTOTAL',pic:'',nv:''},{av:'AV11corigenfecreg',fld:'vCORIGENFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12corigenfecultact',fld:'vCORIGENFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6corigenid',fld:'vCORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7corigendscorta',fld:'vCORIGENDSCORTA',pic:'',nv:''},{av:'AV8corigendsclarga',fld:'vCORIGENDSCLARGA',pic:'',nv:''},{av:'AV9corigenusuario',fld:'vCORIGENUSUARIO',pic:'',nv:''},{av:'AV10corigentotal',fld:'vCORIGENTOTAL',pic:'',nv:''},{av:'AV11corigenfecreg',fld:'vCORIGENFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12corigenfecultact',fld:'vCORIGENFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6corigenid',fld:'vCORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7corigendscorta',fld:'vCORIGENDSCORTA',pic:'',nv:''},{av:'AV8corigendsclarga',fld:'vCORIGENDSCLARGA',pic:'',nv:''},{av:'AV9corigenusuario',fld:'vCORIGENUSUARIO',pic:'',nv:''},{av:'AV10corigentotal',fld:'vCORIGENTOTAL',pic:'',nv:''},{av:'AV11corigenfecreg',fld:'vCORIGENFECREG',pic:'99/99/9999 99:99:99',nv:''},{av:'AV12corigenfecultact',fld:'vCORIGENFECULTACT',pic:'99/99/9999 99:99:99',nv:''}],oparms:[]}");
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
         AV7corigendscorta = "";
         AV8corigendsclarga = "";
         AV9corigenusuario = "";
         AV10corigentotal = "";
         AV11corigenfecreg = (DateTime)(DateTime.MinValue);
         AV12corigenfecultact = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblorigenidfilter_Jsonclick = "";
         TempTags = "";
         lblLblorigendscortafilter_Jsonclick = "";
         lblLblorigendsclargafilter_Jsonclick = "";
         lblLblorigenusuariofilter_Jsonclick = "";
         lblLblorigentotalfilter_Jsonclick = "";
         lblLblorigenfecregfilter_Jsonclick = "";
         lblLblorigenfecultactfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A120origendscorta = "";
         A122origenusuario = "";
         A124origenfecreg = (DateTime)(DateTime.MinValue);
         A125origenfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7corigendscorta = "";
         lV8corigendsclarga = "";
         lV9corigenusuario = "";
         lV10corigentotal = "";
         A121origendsclarga = "";
         A123origentotal = "";
         H00232_A123origentotal = new String[] {""} ;
         H00232_n123origentotal = new bool[] {false} ;
         H00232_A121origendsclarga = new String[] {""} ;
         H00232_n121origendsclarga = new bool[] {false} ;
         H00232_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         H00232_n125origenfecultact = new bool[] {false} ;
         H00232_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         H00232_n124origenfecreg = new bool[] {false} ;
         H00232_A122origenusuario = new String[] {""} ;
         H00232_n122origenusuario = new bool[] {false} ;
         H00232_A120origendscorta = new String[] {""} ;
         H00232_n120origendscorta = new bool[] {false} ;
         H00232_A10origenid = new long[1] ;
         H00233_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00g0__default(),
            new Object[][] {
                new Object[] {
               H00232_A123origentotal, H00232_n123origentotal, H00232_A121origendsclarga, H00232_n121origendsclarga, H00232_A125origenfecultact, H00232_n125origenfecultact, H00232_A124origenfecreg, H00232_n124origenfecreg, H00232_A122origenusuario, H00232_n122origenusuario,
               H00232_A120origendscorta, H00232_n120origendscorta, H00232_A10origenid
               }
               , new Object[] {
               H00233_AGRID1_nRecordCount
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
      private int edtavCorigenid_Enabled ;
      private int edtavCorigenid_Visible ;
      private int edtavCorigendscorta_Visible ;
      private int edtavCorigendscorta_Enabled ;
      private int edtavCorigendsclarga_Visible ;
      private int edtavCorigendsclarga_Enabled ;
      private int edtavCorigenusuario_Visible ;
      private int edtavCorigenusuario_Enabled ;
      private int edtavCorigentotal_Visible ;
      private int edtavCorigentotal_Enabled ;
      private int edtavCorigenfecreg_Enabled ;
      private int edtavCorigenfecultact_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV6corigenid ;
      private long AV13porigenid ;
      private long GRID1_nFirstRecordOnPage ;
      private long A10origenid ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divOrigenidfiltercontainer_Class ;
      private String divOrigendscortafiltercontainer_Class ;
      private String divOrigendsclargafiltercontainer_Class ;
      private String divOrigenusuariofiltercontainer_Class ;
      private String divOrigentotalfiltercontainer_Class ;
      private String divOrigenfecregfiltercontainer_Class ;
      private String divOrigenfecultactfiltercontainer_Class ;
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
      private String divOrigenidfiltercontainer_Internalname ;
      private String lblLblorigenidfilter_Internalname ;
      private String lblLblorigenidfilter_Jsonclick ;
      private String edtavCorigenid_Internalname ;
      private String TempTags ;
      private String edtavCorigenid_Jsonclick ;
      private String divOrigendscortafiltercontainer_Internalname ;
      private String lblLblorigendscortafilter_Internalname ;
      private String lblLblorigendscortafilter_Jsonclick ;
      private String edtavCorigendscorta_Internalname ;
      private String edtavCorigendscorta_Jsonclick ;
      private String divOrigendsclargafiltercontainer_Internalname ;
      private String lblLblorigendsclargafilter_Internalname ;
      private String lblLblorigendsclargafilter_Jsonclick ;
      private String edtavCorigendsclarga_Internalname ;
      private String edtavCorigendsclarga_Jsonclick ;
      private String divOrigenusuariofiltercontainer_Internalname ;
      private String lblLblorigenusuariofilter_Internalname ;
      private String lblLblorigenusuariofilter_Jsonclick ;
      private String edtavCorigenusuario_Internalname ;
      private String edtavCorigenusuario_Jsonclick ;
      private String divOrigentotalfiltercontainer_Internalname ;
      private String lblLblorigentotalfilter_Internalname ;
      private String lblLblorigentotalfilter_Jsonclick ;
      private String edtavCorigentotal_Internalname ;
      private String edtavCorigentotal_Jsonclick ;
      private String divOrigenfecregfiltercontainer_Internalname ;
      private String lblLblorigenfecregfilter_Internalname ;
      private String lblLblorigenfecregfilter_Jsonclick ;
      private String edtavCorigenfecreg_Internalname ;
      private String edtavCorigenfecreg_Jsonclick ;
      private String divOrigenfecultactfiltercontainer_Internalname ;
      private String lblLblorigenfecultactfilter_Internalname ;
      private String lblLblorigenfecultactfilter_Jsonclick ;
      private String edtavCorigenfecultact_Internalname ;
      private String edtavCorigenfecultact_Jsonclick ;
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
      private String edtorigendscorta_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtorigenid_Internalname ;
      private String edtorigendscorta_Internalname ;
      private String edtorigenusuario_Internalname ;
      private String edtorigenfecreg_Internalname ;
      private String edtorigenfecultact_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String ROClassString ;
      private String edtorigenid_Jsonclick ;
      private String edtorigendscorta_Jsonclick ;
      private String edtorigenusuario_Jsonclick ;
      private String edtorigenfecreg_Jsonclick ;
      private String edtorigenfecultact_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV11corigenfecreg ;
      private DateTime AV12corigenfecultact ;
      private DateTime A124origenfecreg ;
      private DateTime A125origenfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n120origendscorta ;
      private bool n122origenusuario ;
      private bool n124origenfecreg ;
      private bool n125origenfecultact ;
      private bool n123origentotal ;
      private bool n121origendsclarga ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7corigendscorta ;
      private String AV8corigendsclarga ;
      private String AV9corigenusuario ;
      private String AV10corigentotal ;
      private String A120origendscorta ;
      private String A122origenusuario ;
      private String AV17Linkselection_GXI ;
      private String lV7corigendscorta ;
      private String lV8corigendsclarga ;
      private String lV9corigenusuario ;
      private String lV10corigentotal ;
      private String A121origendsclarga ;
      private String A123origentotal ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00232_A123origentotal ;
      private bool[] H00232_n123origentotal ;
      private String[] H00232_A121origendsclarga ;
      private bool[] H00232_n121origendsclarga ;
      private DateTime[] H00232_A125origenfecultact ;
      private bool[] H00232_n125origenfecultact ;
      private DateTime[] H00232_A124origenfecreg ;
      private bool[] H00232_n124origenfecreg ;
      private String[] H00232_A122origenusuario ;
      private bool[] H00232_n122origenusuario ;
      private String[] H00232_A120origendscorta ;
      private bool[] H00232_n120origendscorta ;
      private long[] H00232_A10origenid ;
      private long[] H00233_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_porigenid ;
      private GXWebForm Form ;
   }

   public class gx00g0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00232( IGxContext context ,
                                             String AV7corigendscorta ,
                                             String AV8corigendsclarga ,
                                             String AV9corigenusuario ,
                                             String AV10corigentotal ,
                                             DateTime AV11corigenfecreg ,
                                             DateTime AV12corigenfecultact ,
                                             String A120origendscorta ,
                                             String A121origendsclarga ,
                                             String A122origenusuario ,
                                             String A123origentotal ,
                                             DateTime A124origenfecreg ,
                                             DateTime A125origenfecultact ,
                                             long AV6corigenid )
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
         sSelectString = " origentotal, origendsclarga, origenfecultact, origenfecreg, origenusuario, origendscorta, origenid";
         sFromString = " FROM public.origen";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (origenid >= :AV6corigenid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7corigendscorta)) )
         {
            sWhereString = sWhereString + " and (origendscorta like :lV7corigendscorta)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8corigendsclarga)) )
         {
            sWhereString = sWhereString + " and (origendsclarga like :lV8corigendsclarga)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9corigenusuario)) )
         {
            sWhereString = sWhereString + " and (origenusuario like :lV9corigenusuario)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10corigentotal)) )
         {
            sWhereString = sWhereString + " and (origentotal like :lV10corigentotal)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11corigenfecreg) )
         {
            sWhereString = sWhereString + " and (origenfecreg >= :AV11corigenfecreg)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12corigenfecultact) )
         {
            sWhereString = sWhereString + " and (origenfecultact >= :AV12corigenfecultact)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY origenid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00233( IGxContext context ,
                                             String AV7corigendscorta ,
                                             String AV8corigendsclarga ,
                                             String AV9corigenusuario ,
                                             String AV10corigentotal ,
                                             DateTime AV11corigenfecreg ,
                                             DateTime AV12corigenfecultact ,
                                             String A120origendscorta ,
                                             String A121origendsclarga ,
                                             String A122origenusuario ,
                                             String A123origentotal ,
                                             DateTime A124origenfecreg ,
                                             DateTime A125origenfecultact ,
                                             long AV6corigenid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.origen";
         scmdbuf = scmdbuf + " WHERE (origenid >= :AV6corigenid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7corigendscorta)) )
         {
            sWhereString = sWhereString + " and (origendscorta like :lV7corigendscorta)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8corigendsclarga)) )
         {
            sWhereString = sWhereString + " and (origendsclarga like :lV8corigendsclarga)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9corigenusuario)) )
         {
            sWhereString = sWhereString + " and (origenusuario like :lV9corigenusuario)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10corigentotal)) )
         {
            sWhereString = sWhereString + " and (origentotal like :lV10corigentotal)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV11corigenfecreg) )
         {
            sWhereString = sWhereString + " and (origenfecreg >= :AV11corigenfecreg)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12corigenfecultact) )
         {
            sWhereString = sWhereString + " and (origenfecultact >= :AV12corigenfecultact)";
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
                     return conditional_H00232(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (long)dynConstraints[12] );
               case 1 :
                     return conditional_H00233(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (long)dynConstraints[12] );
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
          Object[] prmH00232 ;
          prmH00232 = new Object[] {
          new Object[] {"AV6corigenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV7corigendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV8corigendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV9corigenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"lV10corigentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV11corigenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12corigenfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH00233 ;
          prmH00233 = new Object[] {
          new Object[] {"AV6corigenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"lV7corigendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"lV8corigendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"lV9corigenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"lV10corigentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"AV11corigenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"AV12corigenfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00232", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00232,11,0,false,false )
             ,new CursorDef("H00233", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00233,1,0,false,false )
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
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(4) ;
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
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
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
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[12]);
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
