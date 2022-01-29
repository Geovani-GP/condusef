/*
               File: Gx0010
        Description: Selection List tipobien
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 1:0:44.3
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
   public class gx0010 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out int aP0_ptipobienid )
      {
         this.AV11ptipobienid = 0 ;
         executePrivate();
         aP0_ptipobienid=this.AV11ptipobienid;
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
               nRC_GXsfl_64 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_64_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_64_idx = GetNextPar( );
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
               AV6ctipobienid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ctipobienid), 9, 0)));
               AV8ctipobienusuario = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ctipobienusuario", AV8ctipobienusuario);
               AV9ctipobienfecreg = context.localUtil.ParseDateParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ctipobienfecreg", context.localUtil.Format(AV9ctipobienfecreg, "99/99/9999"));
               AV10ctipobienfecultact = context.localUtil.ParseDateParm( GetNextPar( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ctipobienfecultact", context.localUtil.Format(AV10ctipobienfecultact, "99/99/9999"));
               AV7ctipobiendsc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ctipobiendsc", AV7ctipobiendsc);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
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
               AV11ptipobienid = (int)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ptipobienid), 9, 0)));
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
         PA1Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Q2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202212910447");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV11ptipobienid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ctipobienid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENUSUARIO", AV8ctipobienusuario);
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENFECREG", context.localUtil.Format(AV9ctipobienfecreg, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENFECULTACT", context.localUtil.Format(AV10ctipobienfecultact, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOBIENDSC", AV7ctipobiendsc);
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ptipobienid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENIDFILTERCONTAINER_Class", StringUtil.RTrim( divTipobienidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENUSUARIOFILTERCONTAINER_Class", StringUtil.RTrim( divTipobienusuariofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENFECREGFILTERCONTAINER_Class", StringUtil.RTrim( divTipobienfecregfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENFECULTACTFILTERCONTAINER_Class", StringUtil.RTrim( divTipobienfecultactfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOBIENDSCFILTERCONTAINER_Class", StringUtil.RTrim( divTipobiendscfiltercontainer_Class));
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
            WE1Q2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Q2( ) ;
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
         return formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV11ptipobienid) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0010" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List tipobien" ;
      }

      protected void WB1Q0( )
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
            GxWebStd.gx_div_start( context, divTipobienidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobienidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobienidfilter_Internalname, "tipobienid", "", "", lblLbltipobienidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111q1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipobienid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ctipobienid), 9, 0, ",", "")), ((edtavCtipobienid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6ctipobienid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6ctipobienid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobienid_Jsonclick, 0, "Attribute", "", "", "", edtavCtipobienid_Visible, edtavCtipobienid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divTipobienusuariofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobienusuariofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobienusuariofilter_Internalname, "tipobienusuario", "", "", lblLbltipobienusuariofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121q1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipobienusuario_Internalname, "tipobienusuario", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipobienusuario_Internalname, AV8ctipobienusuario, StringUtil.RTrim( context.localUtil.Format( AV8ctipobienusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobienusuario_Jsonclick, 0, "Attribute", "", "", "", edtavCtipobienusuario_Visible, edtavCtipobienusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divTipobienfecregfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobienfecregfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobienfecregfilter_Internalname, "tipobienfecreg", "", "", lblLbltipobienfecregfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131q1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipobienfecreg_Internalname, "tipobienfecreg", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCtipobienfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCtipobienfecreg_Internalname, context.localUtil.Format(AV9ctipobienfecreg, "99/99/9999"), context.localUtil.Format( AV9ctipobienfecreg, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobienfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCtipobienfecreg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divTipobienfecultactfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobienfecultactfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobienfecultactfilter_Internalname, "tipobienfecultact", "", "", lblLbltipobienfecultactfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141q1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipobienfecultact_Internalname, "tipobienfecultact", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCtipobienfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCtipobienfecultact_Internalname, context.localUtil.Format(AV10ctipobienfecultact, "99/99/9999"), context.localUtil.Format( AV10ctipobienfecultact, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobienfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCtipobienfecultact_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divTipobiendscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipobiendscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipobiendscfilter_Internalname, "tipobiendsc", "", "", lblLbltipobiendscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151q1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipobiendsc_Internalname, "tipobiendsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipobiendsc_Internalname, AV7ctipobiendsc, StringUtil.RTrim( context.localUtil.Format( AV7ctipobiendsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipobiendsc_Jsonclick, 0, "Attribute", "", "", "", edtavCtipobiendsc_Visible, edtavCtipobiendsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0010.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e161q1_client"+"'", TempTags, "", 2, "HLP_Gx0010.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"64\">") ;
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
               context.SendWebValue( "tipobienid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tipobienusuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tipobienfecreg") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tipobienfecultact") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A140tipobienusuario);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            nRC_GXsfl_64 = (short)(nGXsfl_64_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0010.htm");
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

      protected void START1Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Selection List tipobien", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1Q0( ) ;
      }

      protected void WS1Q2( )
      {
         START1Q2( ) ;
         EVT1Q2( ) ;
      }

      protected void EVT1Q2( )
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
                              nGXsfl_64_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
                              SubsflControlProps_642( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A23tipobienid = (int)(context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", "."));
                              A140tipobienusuario = cgiGet( edttipobienusuario_Internalname);
                              n140tipobienusuario = false;
                              A141tipobienfecreg = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edttipobienfecreg_Internalname), 0));
                              n141tipobienfecreg = false;
                              A142tipobienfecultact = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edttipobienfecultact_Internalname), 0));
                              n142tipobienfecultact = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171Q2 */
                                    E171Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181Q2 */
                                    E181Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Ctipobienid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOBIENID"), ",", ".") != Convert.ToDecimal( AV6ctipobienid )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipobienusuario Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOBIENUSUARIO"), AV8ctipobienusuario) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipobienfecreg Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCTIPOBIENFECREG"), 0) != AV9ctipobienfecreg )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipobienfecultact Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCTIPOBIENFECULTACT"), 0) != AV10ctipobienfecultact )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipobiendsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOBIENDSC"), AV7ctipobiendsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E191Q2 */
                                          E191Q2 ();
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

      protected void WE1Q2( )
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

      protected void PA1Q2( )
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
         SubsflControlProps_642( ) ;
         while ( nGXsfl_64_idx <= nRC_GXsfl_64 )
         {
            sendrow_642( ) ;
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        int AV6ctipobienid ,
                                        String AV8ctipobienusuario ,
                                        DateTime AV9ctipobienfecreg ,
                                        DateTime AV10ctipobienfecultact ,
                                        String AV7ctipobiendsc )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1Q2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "TIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENUSUARIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A140tipobienusuario, ""))));
         GxWebStd.gx_hidden_field( context, "TIPOBIENUSUARIO", A140tipobienusuario);
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENFECREG", GetSecureSignedToken( "", A141tipobienfecreg));
         GxWebStd.gx_hidden_field( context, "TIPOBIENFECREG", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENFECULTACT", GetSecureSignedToken( "", A142tipobienfecultact));
         GxWebStd.gx_hidden_field( context, "TIPOBIENFECULTACT", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1Q2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1Q2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 64;
         nGXsfl_64_idx = 1;
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
         SubsflControlProps_642( ) ;
         nGXsfl_64_Refreshing = 1;
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
            SubsflControlProps_642( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV8ctipobienusuario ,
                                                 AV9ctipobienfecreg ,
                                                 AV10ctipobienfecultact ,
                                                 AV7ctipobiendsc ,
                                                 A140tipobienusuario ,
                                                 A141tipobienfecreg ,
                                                 A142tipobienfecultact ,
                                                 A139tipobiendsc ,
                                                 AV6ctipobienid },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV8ctipobienusuario = StringUtil.Concat( StringUtil.RTrim( AV8ctipobienusuario), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ctipobienusuario", AV8ctipobienusuario);
            lV7ctipobiendsc = StringUtil.Concat( StringUtil.RTrim( AV7ctipobiendsc), "%", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ctipobiendsc", AV7ctipobiendsc);
            /* Using cursor H001Q2 */
            pr_default.execute(0, new Object[] {AV6ctipobienid, lV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, lV7ctipobiendsc, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_64_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A139tipobiendsc = H001Q2_A139tipobiendsc[0];
               n139tipobiendsc = H001Q2_n139tipobiendsc[0];
               A142tipobienfecultact = H001Q2_A142tipobienfecultact[0];
               n142tipobienfecultact = H001Q2_n142tipobienfecultact[0];
               A141tipobienfecreg = H001Q2_A141tipobienfecreg[0];
               n141tipobienfecreg = H001Q2_n141tipobienfecreg[0];
               A140tipobienusuario = H001Q2_A140tipobienusuario[0];
               n140tipobienusuario = H001Q2_n140tipobienusuario[0];
               A23tipobienid = H001Q2_A23tipobienid[0];
               /* Execute user event: E181Q2 */
               E181Q2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB1Q0( ) ;
         }
         nGXsfl_64_Refreshing = 0;
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
                                              AV8ctipobienusuario ,
                                              AV9ctipobienfecreg ,
                                              AV10ctipobienfecultact ,
                                              AV7ctipobiendsc ,
                                              A140tipobienusuario ,
                                              A141tipobienfecreg ,
                                              A142tipobienfecultact ,
                                              A139tipobiendsc ,
                                              AV6ctipobienid },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV8ctipobienusuario = StringUtil.Concat( StringUtil.RTrim( AV8ctipobienusuario), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ctipobienusuario", AV8ctipobienusuario);
         lV7ctipobiendsc = StringUtil.Concat( StringUtil.RTrim( AV7ctipobiendsc), "%", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ctipobiendsc", AV7ctipobiendsc);
         /* Using cursor H001Q3 */
         pr_default.execute(1, new Object[] {AV6ctipobienid, lV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, lV7ctipobiendsc});
         GRID1_nRecordCount = H001Q3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6ctipobienid, AV8ctipobienusuario, AV9ctipobienfecreg, AV10ctipobienfecultact, AV7ctipobiendsc) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E171Q2 */
         E171Q2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPOBIENID");
               GX_FocusControl = edtavCtipobienid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6ctipobienid = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ctipobienid), 9, 0)));
            }
            else
            {
               AV6ctipobienid = (int)(context.localUtil.CToN( cgiGet( edtavCtipobienid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ctipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ctipobienid), 9, 0)));
            }
            AV8ctipobienusuario = cgiGet( edtavCtipobienusuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ctipobienusuario", AV8ctipobienusuario);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCtipobienfecreg_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"tipobienfecreg"}), 1, "vCTIPOBIENFECREG");
               GX_FocusControl = edtavCtipobienfecreg_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9ctipobienfecreg = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ctipobienfecreg", context.localUtil.Format(AV9ctipobienfecreg, "99/99/9999"));
            }
            else
            {
               AV9ctipobienfecreg = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavCtipobienfecreg_Internalname), 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ctipobienfecreg", context.localUtil.Format(AV9ctipobienfecreg, "99/99/9999"));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCtipobienfecultact_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"tipobienfecultact"}), 1, "vCTIPOBIENFECULTACT");
               GX_FocusControl = edtavCtipobienfecultact_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10ctipobienfecultact = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ctipobienfecultact", context.localUtil.Format(AV10ctipobienfecultact, "99/99/9999"));
            }
            else
            {
               AV10ctipobienfecultact = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavCtipobienfecultact_Internalname), 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ctipobienfecultact", context.localUtil.Format(AV10ctipobienfecultact, "99/99/9999"));
            }
            AV7ctipobiendsc = cgiGet( edtavCtipobiendsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ctipobiendsc", AV7ctipobiendsc);
            /* Read saved values. */
            nRC_GXsfl_64 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOBIENID"), ",", ".") != Convert.ToDecimal( AV6ctipobienid )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOBIENUSUARIO"), AV8ctipobienusuario) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCTIPOBIENFECREG"), 0) != AV9ctipobienfecreg )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCTIPOBIENFECULTACT"), 0) != AV10ctipobienfecultact )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOBIENDSC"), AV7ctipobiendsc) != 0 )
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
         /* Execute user event: E171Q2 */
         E171Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E171Q2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "tipobien", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV12ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E181Q2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV15Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_642( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_64_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(64, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E191Q2 */
         E191Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191Q2( )
      {
         /* Enter Routine */
         AV11ptipobienid = A23tipobienid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ptipobienid), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV11ptipobienid});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11ptipobienid = Convert.ToInt32(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ptipobienid), 9, 0)));
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
         PA1Q2( ) ;
         WS1Q2( ) ;
         WE1Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022129104484");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gx0010.js", "?2022129104484");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_64_idx;
         edttipobienusuario_Internalname = "TIPOBIENUSUARIO_"+sGXsfl_64_idx;
         edttipobienfecreg_Internalname = "TIPOBIENFECREG_"+sGXsfl_64_idx;
         edttipobienfecultact_Internalname = "TIPOBIENFECULTACT_"+sGXsfl_64_idx;
      }

      protected void SubsflControlProps_fel_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_fel_idx;
         edttipobienid_Internalname = "TIPOBIENID_"+sGXsfl_64_fel_idx;
         edttipobienusuario_Internalname = "TIPOBIENUSUARIO_"+sGXsfl_64_fel_idx;
         edttipobienfecreg_Internalname = "TIPOBIENFECREG_"+sGXsfl_64_fel_idx;
         edttipobienfecultact_Internalname = "TIPOBIENFECULTACT_"+sGXsfl_64_fel_idx;
      }

      protected void sendrow_642( )
      {
         SubsflControlProps_642( ) ;
         WB1Q0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_64_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_64_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_64_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV15Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienusuario_Internalname,(String)A140tipobienusuario,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienusuario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienfecreg_Internalname,context.localUtil.Format(A141tipobienfecreg, "99/99/9999"),context.localUtil.Format( A141tipobienfecreg, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienfecreg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipobienfecultact_Internalname,context.localUtil.Format(A142tipobienfecultact, "99/99/9999"),context.localUtil.Format( A142tipobienfecultact, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipobienfecultact_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENID"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")));
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENUSUARIO"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, StringUtil.RTrim( context.localUtil.Format( A140tipobienusuario, ""))));
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENFECREG"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, A141tipobienfecreg));
            GxWebStd.gx_hidden_field( context, "gxhash_TIPOBIENFECULTACT"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, A142tipobienfecultact));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
         }
         /* End function sendrow_642 */
      }

      protected void init_default_properties( )
      {
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
         lblLbltipobienusuariofilter_Internalname = "LBLTIPOBIENUSUARIOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtipobienusuario_Internalname = "vCTIPOBIENUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTipobienusuariofiltercontainer_Internalname = "TIPOBIENUSUARIOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltipobienfecregfilter_Internalname = "LBLTIPOBIENFECREGFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtipobienfecreg_Internalname = "vCTIPOBIENFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTipobienfecregfiltercontainer_Internalname = "TIPOBIENFECREGFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltipobienfecultactfilter_Internalname = "LBLTIPOBIENFECULTACTFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtipobienfecultact_Internalname = "vCTIPOBIENFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTipobienfecultactfiltercontainer_Internalname = "TIPOBIENFECULTACTFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltipobiendscfilter_Internalname = "LBLTIPOBIENDSCFILTER";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtipobiendsc_Internalname = "vCTIPOBIENDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTipobiendscfiltercontainer_Internalname = "TIPOBIENDSCFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edttipobienid_Internalname = "TIPOBIENID";
         edttipobienusuario_Internalname = "TIPOBIENUSUARIO";
         edttipobienfecreg_Internalname = "TIPOBIENFECREG";
         edttipobienfecultact_Internalname = "TIPOBIENFECULTACT";
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
         edttipobienfecultact_Jsonclick = "";
         edttipobienfecreg_Jsonclick = "";
         edttipobienusuario_Jsonclick = "";
         edttipobienid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCtipobiendsc_Jsonclick = "";
         edtavCtipobiendsc_Enabled = 1;
         edtavCtipobiendsc_Visible = 1;
         edtavCtipobienfecultact_Jsonclick = "";
         edtavCtipobienfecultact_Enabled = 1;
         edtavCtipobienfecreg_Jsonclick = "";
         edtavCtipobienfecreg_Enabled = 1;
         edtavCtipobienusuario_Jsonclick = "";
         edtavCtipobienusuario_Enabled = 1;
         edtavCtipobienusuario_Visible = 1;
         edtavCtipobienid_Jsonclick = "";
         edtavCtipobienid_Enabled = 1;
         edtavCtipobienid_Visible = 1;
         divTipobiendscfiltercontainer_Class = "AdvancedContainerItem";
         divTipobienfecultactfiltercontainer_Class = "AdvancedContainerItem";
         divTipobienfecregfiltercontainer_Class = "AdvancedContainerItem";
         divTipobienusuariofiltercontainer_Class = "AdvancedContainerItem";
         divTipobienidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List tipobien";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8ctipobienusuario',fld:'vCTIPOBIENUSUARIO',pic:'',nv:''},{av:'AV9ctipobienfecreg',fld:'vCTIPOBIENFECREG',pic:'',nv:''},{av:'AV10ctipobienfecultact',fld:'vCTIPOBIENFECULTACT',pic:'',nv:''},{av:'AV7ctipobiendsc',fld:'vCTIPOBIENDSC',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E161Q1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLTIPOBIENIDFILTER.CLICK","{handler:'E111Q1',iparms:[{av:'divTipobienidfiltercontainer_Class',ctrl:'TIPOBIENIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobienidfiltercontainer_Class',ctrl:'TIPOBIENIDFILTERCONTAINER',prop:'Class'},{av:'edtavCtipobienid_Visible',ctrl:'vCTIPOBIENID',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOBIENUSUARIOFILTER.CLICK","{handler:'E121Q1',iparms:[{av:'divTipobienusuariofiltercontainer_Class',ctrl:'TIPOBIENUSUARIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobienusuariofiltercontainer_Class',ctrl:'TIPOBIENUSUARIOFILTERCONTAINER',prop:'Class'},{av:'edtavCtipobienusuario_Visible',ctrl:'vCTIPOBIENUSUARIO',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOBIENFECREGFILTER.CLICK","{handler:'E131Q1',iparms:[{av:'divTipobienfecregfiltercontainer_Class',ctrl:'TIPOBIENFECREGFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobienfecregfiltercontainer_Class',ctrl:'TIPOBIENFECREGFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLTIPOBIENFECULTACTFILTER.CLICK","{handler:'E141Q1',iparms:[{av:'divTipobienfecultactfiltercontainer_Class',ctrl:'TIPOBIENFECULTACTFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobienfecultactfiltercontainer_Class',ctrl:'TIPOBIENFECULTACTFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLTIPOBIENDSCFILTER.CLICK","{handler:'E151Q1',iparms:[{av:'divTipobiendscfiltercontainer_Class',ctrl:'TIPOBIENDSCFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTipobiendscfiltercontainer_Class',ctrl:'TIPOBIENDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCtipobiendsc_Visible',ctrl:'vCTIPOBIENDSC',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E191Q2',iparms:[{av:'A23tipobienid',fld:'TIPOBIENID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV11ptipobienid',fld:'vPTIPOBIENID',pic:'ZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8ctipobienusuario',fld:'vCTIPOBIENUSUARIO',pic:'',nv:''},{av:'AV9ctipobienfecreg',fld:'vCTIPOBIENFECREG',pic:'',nv:''},{av:'AV10ctipobienfecultact',fld:'vCTIPOBIENFECULTACT',pic:'',nv:''},{av:'AV7ctipobiendsc',fld:'vCTIPOBIENDSC',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8ctipobienusuario',fld:'vCTIPOBIENUSUARIO',pic:'',nv:''},{av:'AV9ctipobienfecreg',fld:'vCTIPOBIENFECREG',pic:'',nv:''},{av:'AV10ctipobienfecultact',fld:'vCTIPOBIENFECULTACT',pic:'',nv:''},{av:'AV7ctipobiendsc',fld:'vCTIPOBIENDSC',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8ctipobienusuario',fld:'vCTIPOBIENUSUARIO',pic:'',nv:''},{av:'AV9ctipobienfecreg',fld:'vCTIPOBIENFECREG',pic:'',nv:''},{av:'AV10ctipobienfecultact',fld:'vCTIPOBIENFECULTACT',pic:'',nv:''},{av:'AV7ctipobiendsc',fld:'vCTIPOBIENDSC',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6ctipobienid',fld:'vCTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV8ctipobienusuario',fld:'vCTIPOBIENUSUARIO',pic:'',nv:''},{av:'AV9ctipobienfecreg',fld:'vCTIPOBIENFECREG',pic:'',nv:''},{av:'AV10ctipobienfecultact',fld:'vCTIPOBIENFECULTACT',pic:'',nv:''},{av:'AV7ctipobiendsc',fld:'vCTIPOBIENDSC',pic:'',nv:''}],oparms:[]}");
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
         AV8ctipobienusuario = "";
         AV9ctipobienfecreg = DateTime.MinValue;
         AV10ctipobienfecultact = DateTime.MinValue;
         AV7ctipobiendsc = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbltipobienidfilter_Jsonclick = "";
         TempTags = "";
         lblLbltipobienusuariofilter_Jsonclick = "";
         lblLbltipobienfecregfilter_Jsonclick = "";
         lblLbltipobienfecultactfilter_Jsonclick = "";
         lblLbltipobiendscfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A140tipobienusuario = "";
         A141tipobienfecreg = DateTime.MinValue;
         A142tipobienfecultact = DateTime.MinValue;
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         scmdbuf = "";
         lV8ctipobienusuario = "";
         lV7ctipobiendsc = "";
         A139tipobiendsc = "";
         H001Q2_A139tipobiendsc = new String[] {""} ;
         H001Q2_n139tipobiendsc = new bool[] {false} ;
         H001Q2_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         H001Q2_n142tipobienfecultact = new bool[] {false} ;
         H001Q2_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         H001Q2_n141tipobienfecreg = new bool[] {false} ;
         H001Q2_A140tipobienusuario = new String[] {""} ;
         H001Q2_n140tipobienusuario = new bool[] {false} ;
         H001Q2_A23tipobienid = new int[1] ;
         H001Q3_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0010__default(),
            new Object[][] {
                new Object[] {
               H001Q2_A139tipobiendsc, H001Q2_n139tipobiendsc, H001Q2_A142tipobienfecultact, H001Q2_n142tipobienfecultact, H001Q2_A141tipobienfecreg, H001Q2_n141tipobienfecreg, H001Q2_A140tipobienusuario, H001Q2_n140tipobienusuario, H001Q2_A23tipobienid
               }
               , new Object[] {
               H001Q3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_64 ;
      private short nGXsfl_64_idx=1 ;
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
      private short nGXsfl_64_Refreshing=0 ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV6ctipobienid ;
      private int AV11ptipobienid ;
      private int edtavCtipobienid_Enabled ;
      private int edtavCtipobienid_Visible ;
      private int edtavCtipobienusuario_Visible ;
      private int edtavCtipobienusuario_Enabled ;
      private int edtavCtipobienfecreg_Enabled ;
      private int edtavCtipobienfecultact_Enabled ;
      private int edtavCtipobiendsc_Visible ;
      private int edtavCtipobiendsc_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A23tipobienid ;
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
      private String divTipobienidfiltercontainer_Class ;
      private String divTipobienusuariofiltercontainer_Class ;
      private String divTipobienfecregfiltercontainer_Class ;
      private String divTipobienfecultactfiltercontainer_Class ;
      private String divTipobiendscfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_64_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divTipobienidfiltercontainer_Internalname ;
      private String lblLbltipobienidfilter_Internalname ;
      private String lblLbltipobienidfilter_Jsonclick ;
      private String edtavCtipobienid_Internalname ;
      private String TempTags ;
      private String edtavCtipobienid_Jsonclick ;
      private String divTipobienusuariofiltercontainer_Internalname ;
      private String lblLbltipobienusuariofilter_Internalname ;
      private String lblLbltipobienusuariofilter_Jsonclick ;
      private String edtavCtipobienusuario_Internalname ;
      private String edtavCtipobienusuario_Jsonclick ;
      private String divTipobienfecregfiltercontainer_Internalname ;
      private String lblLbltipobienfecregfilter_Internalname ;
      private String lblLbltipobienfecregfilter_Jsonclick ;
      private String edtavCtipobienfecreg_Internalname ;
      private String edtavCtipobienfecreg_Jsonclick ;
      private String divTipobienfecultactfiltercontainer_Internalname ;
      private String lblLbltipobienfecultactfilter_Internalname ;
      private String lblLbltipobienfecultactfilter_Jsonclick ;
      private String edtavCtipobienfecultact_Internalname ;
      private String edtavCtipobienfecultact_Jsonclick ;
      private String divTipobiendscfiltercontainer_Internalname ;
      private String lblLbltipobiendscfilter_Internalname ;
      private String lblLbltipobiendscfilter_Jsonclick ;
      private String edtavCtipobiendsc_Internalname ;
      private String edtavCtipobiendsc_Jsonclick ;
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
      private String edttipobienid_Internalname ;
      private String edttipobienusuario_Internalname ;
      private String edttipobienfecreg_Internalname ;
      private String edttipobienfecultact_Internalname ;
      private String scmdbuf ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_64_fel_idx="0001" ;
      private String ROClassString ;
      private String edttipobienid_Jsonclick ;
      private String edttipobienusuario_Jsonclick ;
      private String edttipobienfecreg_Jsonclick ;
      private String edttipobienfecultact_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV9ctipobienfecreg ;
      private DateTime AV10ctipobienfecultact ;
      private DateTime A141tipobienfecreg ;
      private DateTime A142tipobienfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n140tipobienusuario ;
      private bool n141tipobienfecreg ;
      private bool n142tipobienfecultact ;
      private bool n139tipobiendsc ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8ctipobienusuario ;
      private String AV7ctipobiendsc ;
      private String A140tipobienusuario ;
      private String AV15Linkselection_GXI ;
      private String lV8ctipobienusuario ;
      private String lV7ctipobiendsc ;
      private String A139tipobiendsc ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001Q2_A139tipobiendsc ;
      private bool[] H001Q2_n139tipobiendsc ;
      private DateTime[] H001Q2_A142tipobienfecultact ;
      private bool[] H001Q2_n142tipobienfecultact ;
      private DateTime[] H001Q2_A141tipobienfecreg ;
      private bool[] H001Q2_n141tipobienfecreg ;
      private String[] H001Q2_A140tipobienusuario ;
      private bool[] H001Q2_n140tipobienusuario ;
      private int[] H001Q2_A23tipobienid ;
      private long[] H001Q3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_ptipobienid ;
      private GXWebForm Form ;
   }

   public class gx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001Q2( IGxContext context ,
                                             String AV8ctipobienusuario ,
                                             DateTime AV9ctipobienfecreg ,
                                             DateTime AV10ctipobienfecultact ,
                                             String AV7ctipobiendsc ,
                                             String A140tipobienusuario ,
                                             DateTime A141tipobienfecreg ,
                                             DateTime A142tipobienfecultact ,
                                             String A139tipobiendsc ,
                                             int AV6ctipobienid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [8] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " tipobiendsc, tipobienfecultact, tipobienfecreg, tipobienusuario, tipobienid";
         sFromString = " FROM public.tipobien";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (tipobienid >= :AV6ctipobienid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ctipobienusuario)) )
         {
            sWhereString = sWhereString + " and (tipobienusuario like :lV8ctipobienusuario)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV9ctipobienfecreg) )
         {
            sWhereString = sWhereString + " and (tipobienfecreg >= :AV9ctipobienfecreg)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV10ctipobienfecultact) )
         {
            sWhereString = sWhereString + " and (tipobienfecultact >= :AV10ctipobienfecultact)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ctipobiendsc)) )
         {
            sWhereString = sWhereString + " and (tipobiendsc like :lV7ctipobiendsc)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY tipobienid";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + ":GXPagingFrom2" + " LIMIT CASE WHEN " + ":GXPagingTo2" + " > 0 THEN " + ":GXPagingTo2" + " ELSE 1e9 END";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001Q3( IGxContext context ,
                                             String AV8ctipobienusuario ,
                                             DateTime AV9ctipobienfecreg ,
                                             DateTime AV10ctipobienfecultact ,
                                             String AV7ctipobiendsc ,
                                             String A140tipobienusuario ,
                                             DateTime A141tipobienfecreg ,
                                             DateTime A142tipobienfecultact ,
                                             String A139tipobiendsc ,
                                             int AV6ctipobienid )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM public.tipobien";
         scmdbuf = scmdbuf + " WHERE (tipobienid >= :AV6ctipobienid)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ctipobienusuario)) )
         {
            sWhereString = sWhereString + " and (tipobienusuario like :lV8ctipobienusuario)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV9ctipobienfecreg) )
         {
            sWhereString = sWhereString + " and (tipobienfecreg >= :AV9ctipobienfecreg)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV10ctipobienfecultact) )
         {
            sWhereString = sWhereString + " and (tipobienfecultact >= :AV10ctipobienfecultact)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ctipobiendsc)) )
         {
            sWhereString = sWhereString + " and (tipobiendsc like :lV7ctipobiendsc)";
         }
         else
         {
            GXv_int3[4] = 1;
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
                     return conditional_H001Q2(context, (String)dynConstraints[0] , (DateTime)dynConstraints[1] , (DateTime)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (String)dynConstraints[7] , (int)dynConstraints[8] );
               case 1 :
                     return conditional_H001Q3(context, (String)dynConstraints[0] , (DateTime)dynConstraints[1] , (DateTime)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (String)dynConstraints[7] , (int)dynConstraints[8] );
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
          Object[] prmH001Q2 ;
          prmH001Q2 = new Object[] {
          new Object[] {"AV6ctipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8ctipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV9ctipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV10ctipobienfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"lV7ctipobiendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"GXPagingFrom2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"GXPagingTo2",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmH001Q3 ;
          prmH001Q3 = new Object[] {
          new Object[] {"AV6ctipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"lV8ctipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"AV9ctipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"AV10ctipobienfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"lV7ctipobiendsc",NpgsqlDbType.Varchar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Q2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q2,11,0,false,false )
             ,new CursorDef("H001Q3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q3,1,0,false,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                return;
       }
    }

 }

}
