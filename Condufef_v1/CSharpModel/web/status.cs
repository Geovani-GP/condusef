/*
               File: status
        Description: status
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:2.45
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
   public class status : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7statusid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7statusid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSTATUSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7statusid), "ZZZZZZZZ9")));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "status", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtstatusdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public status( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public status( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_statusid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7statusid = aP1_statusid;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "status", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatusid_Internalname, "statusid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtstatusid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1statusid), 9, 0, ",", "")), ((edtstatusid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatusid_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatusid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatusdsc_Internalname, "statusdsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtstatusdsc_Internalname, A73statusdsc, StringUtil.RTrim( context.localUtil.Format( A73statusdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatusdsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatusdsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatususotabla_Internalname, "statususotabla", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtstatususotabla_Internalname, A74statususotabla, StringUtil.RTrim( context.localUtil.Format( A74statususotabla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatususotabla_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatususotabla_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatusdesc_Internalname, "statusdesc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtstatusdesc_Internalname, A75statusdesc, StringUtil.RTrim( context.localUtil.Format( A75statusdesc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatusdesc_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatusdesc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatususuario_Internalname, "statususuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtstatususuario_Internalname, A76statususuario, StringUtil.RTrim( context.localUtil.Format( A76statususuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatususuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatususuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatusfecreg_Internalname, "statusfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtstatusfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtstatusfecreg_Internalname, context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A77statusfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatusfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatusfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_status.htm");
            GxWebStd.gx_bitmap( context, edtstatusfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtstatusfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_status.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstatusfecultact_Internalname, "statusfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtstatusfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtstatusfecultact_Internalname, context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A78statusfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstatusfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtstatusfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_status.htm");
            GxWebStd.gx_bitmap( context, edtstatusfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtstatusfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_status.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_status.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A1statusid = (int)(context.localUtil.CToN( cgiGet( edtstatusid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
               A73statusdsc = cgiGet( edtstatusdsc_Internalname);
               n73statusdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73statusdsc", A73statusdsc);
               n73statusdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A73statusdsc)) ? true : false);
               A74statususotabla = cgiGet( edtstatususotabla_Internalname);
               n74statususotabla = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74statususotabla", A74statususotabla);
               n74statususotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A74statususotabla)) ? true : false);
               A75statusdesc = cgiGet( edtstatusdesc_Internalname);
               n75statusdesc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75statusdesc", A75statusdesc);
               n75statusdesc = (String.IsNullOrEmpty(StringUtil.RTrim( A75statusdesc)) ? true : false);
               A76statususuario = cgiGet( edtstatususuario_Internalname);
               n76statususuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76statususuario", A76statususuario);
               n76statususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A76statususuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtstatusfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"statusfecreg"}), 1, "STATUSFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtstatusfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A77statusfecreg = (DateTime)(DateTime.MinValue);
                  n77statusfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77statusfecreg", context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A77statusfecreg = context.localUtil.CToT( cgiGet( edtstatusfecreg_Internalname));
                  n77statusfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77statusfecreg", context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n77statusfecreg = ((DateTime.MinValue==A77statusfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtstatusfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"statusfecultact"}), 1, "STATUSFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtstatusfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A78statusfecultact = (DateTime)(DateTime.MinValue);
                  n78statusfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78statusfecultact", context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A78statusfecultact = context.localUtil.CToT( cgiGet( edtstatusfecultact_Internalname));
                  n78statusfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78statusfecultact", context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n78statusfecultact = ((DateTime.MinValue==A78statusfecultact) ? true : false);
               /* Read saved values. */
               Z1statusid = (int)(context.localUtil.CToN( cgiGet( "Z1statusid"), ",", "."));
               Z73statusdsc = cgiGet( "Z73statusdsc");
               n73statusdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A73statusdsc)) ? true : false);
               Z74statususotabla = cgiGet( "Z74statususotabla");
               n74statususotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A74statususotabla)) ? true : false);
               Z75statusdesc = cgiGet( "Z75statusdesc");
               n75statusdesc = (String.IsNullOrEmpty(StringUtil.RTrim( A75statusdesc)) ? true : false);
               Z76statususuario = cgiGet( "Z76statususuario");
               n76statususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A76statususuario)) ? true : false);
               Z77statusfecreg = context.localUtil.CToT( cgiGet( "Z77statusfecreg"), 0);
               n77statusfecreg = ((DateTime.MinValue==A77statusfecreg) ? true : false);
               Z78statusfecultact = context.localUtil.CToT( cgiGet( "Z78statusfecultact"), 0);
               n78statusfecultact = ((DateTime.MinValue==A78statusfecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7statusid = (int)(context.localUtil.CToN( cgiGet( "vSTATUSID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "status";
               A1statusid = (int)(context.localUtil.CToN( cgiGet( edtstatusid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1statusid != Z1statusid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("status:[SecurityCheckFailed value for]"+"statusid:"+context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("status:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  A1statusid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode21 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode21;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound21 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0L0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "STATUSID");
                        AnyError = 1;
                        GX_FocusControl = edtstatusid_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0L21( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)));
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)));
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)));
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)));
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            DisableAttributes0L21( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0L0( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0L21( ) ;
            }
            else
            {
               CheckExtendedTable0L21( ) ;
               CloseExtendedTableCursors0L21( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0L0( )
      {
      }

      protected void ZM0L21( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z73statusdsc = T000L3_A73statusdsc[0];
               Z74statususotabla = T000L3_A74statususotabla[0];
               Z75statusdesc = T000L3_A75statusdesc[0];
               Z76statususuario = T000L3_A76statususuario[0];
               Z77statusfecreg = T000L3_A77statusfecreg[0];
               Z78statusfecultact = T000L3_A78statusfecultact[0];
            }
            else
            {
               Z73statusdsc = A73statusdsc;
               Z74statususotabla = A74statususotabla;
               Z75statusdesc = A75statusdesc;
               Z76statususuario = A76statususuario;
               Z77statusfecreg = A77statusfecreg;
               Z78statusfecultact = A78statusfecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z1statusid = A1statusid;
            Z73statusdsc = A73statusdsc;
            Z74statususotabla = A74statususotabla;
            Z75statusdesc = A75statusdesc;
            Z76statususuario = A76statususuario;
            Z77statusfecreg = A77statusfecreg;
            Z78statusfecultact = A78statusfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtstatusid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusid_Enabled), 5, 0)));
         edtstatusid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7statusid) )
         {
            A1statusid = AV7statusid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
      }

      protected void Load0L21( )
      {
         /* Using cursor T000L4 */
         pr_default.execute(2, new Object[] {A1statusid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound21 = 1;
            A73statusdsc = T000L4_A73statusdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73statusdsc", A73statusdsc);
            n73statusdsc = T000L4_n73statusdsc[0];
            A74statususotabla = T000L4_A74statususotabla[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74statususotabla", A74statususotabla);
            n74statususotabla = T000L4_n74statususotabla[0];
            A75statusdesc = T000L4_A75statusdesc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75statusdesc", A75statusdesc);
            n75statusdesc = T000L4_n75statusdesc[0];
            A76statususuario = T000L4_A76statususuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76statususuario", A76statususuario);
            n76statususuario = T000L4_n76statususuario[0];
            A77statusfecreg = T000L4_A77statusfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77statusfecreg", context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "));
            n77statusfecreg = T000L4_n77statusfecreg[0];
            A78statusfecultact = T000L4_A78statusfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78statusfecultact", context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "));
            n78statusfecultact = T000L4_n78statusfecultact[0];
            ZM0L21( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0L21( ) ;
      }

      protected void OnLoadActions0L21( )
      {
      }

      protected void CheckExtendedTable0L21( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0L21( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0L21( )
      {
         /* Using cursor T000L5 */
         pr_default.execute(3, new Object[] {A1statusid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound21 = 1;
         }
         else
         {
            RcdFound21 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000L3 */
         pr_default.execute(1, new Object[] {A1statusid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0L21( 3) ;
            RcdFound21 = 1;
            A1statusid = T000L3_A1statusid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
            A73statusdsc = T000L3_A73statusdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73statusdsc", A73statusdsc);
            n73statusdsc = T000L3_n73statusdsc[0];
            A74statususotabla = T000L3_A74statususotabla[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74statususotabla", A74statususotabla);
            n74statususotabla = T000L3_n74statususotabla[0];
            A75statusdesc = T000L3_A75statusdesc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75statusdesc", A75statusdesc);
            n75statusdesc = T000L3_n75statusdesc[0];
            A76statususuario = T000L3_A76statususuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76statususuario", A76statususuario);
            n76statususuario = T000L3_n76statususuario[0];
            A77statusfecreg = T000L3_A77statusfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77statusfecreg", context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "));
            n77statusfecreg = T000L3_n77statusfecreg[0];
            A78statusfecultact = T000L3_A78statusfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78statusfecultact", context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "));
            n78statusfecultact = T000L3_n78statusfecultact[0];
            Z1statusid = A1statusid;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0L21( ) ;
            if ( AnyError == 1 )
            {
               RcdFound21 = 0;
               InitializeNonKey0L21( ) ;
            }
            Gx_mode = sMode21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound21 = 0;
            InitializeNonKey0L21( ) ;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0L21( ) ;
         if ( RcdFound21 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound21 = 0;
         /* Using cursor T000L6 */
         pr_default.execute(4, new Object[] {A1statusid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000L6_A1statusid[0] < A1statusid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000L6_A1statusid[0] > A1statusid ) ) )
            {
               A1statusid = T000L6_A1statusid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
               RcdFound21 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound21 = 0;
         /* Using cursor T000L7 */
         pr_default.execute(5, new Object[] {A1statusid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000L7_A1statusid[0] > A1statusid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000L7_A1statusid[0] < A1statusid ) ) )
            {
               A1statusid = T000L7_A1statusid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
               RcdFound21 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0L21( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtstatusdsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0L21( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound21 == 1 )
            {
               if ( A1statusid != Z1statusid )
               {
                  A1statusid = Z1statusid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "STATUSID");
                  AnyError = 1;
                  GX_FocusControl = edtstatusid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtstatusdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0L21( ) ;
                  GX_FocusControl = edtstatusdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1statusid != Z1statusid )
               {
                  /* Insert record */
                  GX_FocusControl = edtstatusdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0L21( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "STATUSID");
                     AnyError = 1;
                     GX_FocusControl = edtstatusid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtstatusdsc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0L21( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A1statusid != Z1statusid )
         {
            A1statusid = Z1statusid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "STATUSID");
            AnyError = 1;
            GX_FocusControl = edtstatusid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtstatusdsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0L21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L2 */
            pr_default.execute(0, new Object[] {A1statusid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"STATUS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z73statusdsc, T000L2_A73statusdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z74statususotabla, T000L2_A74statususotabla[0]) != 0 ) || ( StringUtil.StrCmp(Z75statusdesc, T000L2_A75statusdesc[0]) != 0 ) || ( StringUtil.StrCmp(Z76statususuario, T000L2_A76statususuario[0]) != 0 ) || ( Z77statusfecreg != T000L2_A77statusfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z78statusfecultact != T000L2_A78statusfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z73statusdsc, T000L2_A73statusdsc[0]) != 0 )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statusdsc");
                  GXUtil.WriteLogRaw("Old: ",Z73statusdsc);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A73statusdsc[0]);
               }
               if ( StringUtil.StrCmp(Z74statususotabla, T000L2_A74statususotabla[0]) != 0 )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statususotabla");
                  GXUtil.WriteLogRaw("Old: ",Z74statususotabla);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A74statususotabla[0]);
               }
               if ( StringUtil.StrCmp(Z75statusdesc, T000L2_A75statusdesc[0]) != 0 )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statusdesc");
                  GXUtil.WriteLogRaw("Old: ",Z75statusdesc);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A75statusdesc[0]);
               }
               if ( StringUtil.StrCmp(Z76statususuario, T000L2_A76statususuario[0]) != 0 )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statususuario");
                  GXUtil.WriteLogRaw("Old: ",Z76statususuario);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A76statususuario[0]);
               }
               if ( Z77statusfecreg != T000L2_A77statusfecreg[0] )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statusfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z77statusfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A77statusfecreg[0]);
               }
               if ( Z78statusfecultact != T000L2_A78statusfecultact[0] )
               {
                  GXUtil.WriteLog("status:[seudo value changed for attri]"+"statusfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z78statusfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A78statusfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"STATUS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0L21( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L21( 0) ;
            CheckOptimisticConcurrency0L21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L8 */
                     pr_default.execute(6, new Object[] {A1statusid, n73statusdsc, A73statusdsc, n74statususotabla, A74statususotabla, n75statusdesc, A75statusdesc, n76statususuario, A76statususuario, n77statusfecreg, A77statusfecreg, n78statusfecultact, A78statusfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "", true);
                           ResetCaption0L0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0L21( ) ;
            }
            EndLevel0L21( ) ;
         }
         CloseExtendedTableCursors0L21( ) ;
      }

      protected void Update0L21( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L9 */
                     pr_default.execute(7, new Object[] {n73statusdsc, A73statusdsc, n74statususotabla, A74statususotabla, n75statusdesc, A75statusdesc, n76statususuario, A76statususuario, n77statusfecreg, A77statusfecreg, n78statusfecultact, A78statusfecultact, A1statusid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"STATUS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0L21( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0L21( ) ;
         }
         CloseExtendedTableCursors0L21( ) ;
      }

      protected void DeferredUpdate0L21( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0L21( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L21( ) ;
            AfterConfirm0L21( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L21( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000L10 */
                  pr_default.execute(8, new Object[] {A1statusid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("STATUS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode21 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0L21( ) ;
         Gx_mode = sMode21;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0L21( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0L21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0L21( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "status");
            if ( AnyError == 0 )
            {
               ConfirmValues0L0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "status");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0L21( )
      {
         /* Scan By routine */
         /* Using cursor T000L11 */
         pr_default.execute(9);
         RcdFound21 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound21 = 1;
            A1statusid = T000L11_A1statusid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L21( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound21 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound21 = 1;
            A1statusid = T000L11_A1statusid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
         }
      }

      protected void ScanEnd0L21( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0L21( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L21( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L21( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L21( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L21( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L21( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L21( )
      {
         edtstatusid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusid_Enabled), 5, 0)));
         edtstatusdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusdsc_Enabled), 5, 0)));
         edtstatususotabla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatususotabla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatususotabla_Enabled), 5, 0)));
         edtstatusdesc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusdesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusdesc_Enabled), 5, 0)));
         edtstatususuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatususuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatususuario_Enabled), 5, 0)));
         edtstatusfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusfecreg_Enabled), 5, 0)));
         edtstatusfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstatusfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstatusfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0L0( )
      {
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
         MasterPageObj.master_styles();
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxcfg.js", "?20221302338321");
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
         bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("status.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7statusid)+"\">") ;
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
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z1statusid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1statusid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z73statusdsc", Z73statusdsc);
         GxWebStd.gx_hidden_field( context, "Z74statususotabla", Z74statususotabla);
         GxWebStd.gx_hidden_field( context, "Z75statusdesc", Z75statusdesc);
         GxWebStd.gx_hidden_field( context, "Z76statususuario", Z76statususuario);
         GxWebStd.gx_hidden_field( context, "Z77statusfecreg", context.localUtil.TToC( Z77statusfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z78statusfecultact", context.localUtil.TToC( Z78statusfecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSTATUSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7statusid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vSTATUSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7statusid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "status";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("status:[SendSecurityCheck value for]"+"statusid:"+context.localUtil.Format( (decimal)(A1statusid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("status:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("status.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7statusid) ;
      }

      public override String GetPgmname( )
      {
         return "status" ;
      }

      public override String GetPgmdesc( )
      {
         return "status" ;
      }

      protected void InitializeNonKey0L21( )
      {
         A73statusdsc = "";
         n73statusdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73statusdsc", A73statusdsc);
         n73statusdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A73statusdsc)) ? true : false);
         A74statususotabla = "";
         n74statususotabla = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74statususotabla", A74statususotabla);
         n74statususotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A74statususotabla)) ? true : false);
         A75statusdesc = "";
         n75statusdesc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A75statusdesc", A75statusdesc);
         n75statusdesc = (String.IsNullOrEmpty(StringUtil.RTrim( A75statusdesc)) ? true : false);
         A76statususuario = "";
         n76statususuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A76statususuario", A76statususuario);
         n76statususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A76statususuario)) ? true : false);
         A77statusfecreg = (DateTime)(DateTime.MinValue);
         n77statusfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77statusfecreg", context.localUtil.TToC( A77statusfecreg, 10, 8, 0, 3, "/", ":", " "));
         n77statusfecreg = ((DateTime.MinValue==A77statusfecreg) ? true : false);
         A78statusfecultact = (DateTime)(DateTime.MinValue);
         n78statusfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78statusfecultact", context.localUtil.TToC( A78statusfecultact, 10, 8, 0, 3, "/", ":", " "));
         n78statusfecultact = ((DateTime.MinValue==A78statusfecultact) ? true : false);
         Z73statusdsc = "";
         Z74statususotabla = "";
         Z75statusdesc = "";
         Z76statususuario = "";
         Z77statusfecreg = (DateTime)(DateTime.MinValue);
         Z78statusfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0L21( )
      {
         A1statusid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1statusid", StringUtil.LTrim( StringUtil.Str( (decimal)(A1statusid), 9, 0)));
         InitializeNonKey0L21( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2337534");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221302338328");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("status.js", "?20221302338328");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         div_Internalname = "";
         bttBtn_select_Internalname = "BTN_SELECT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatusid_Internalname = "STATUSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatusdsc_Internalname = "STATUSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatususotabla_Internalname = "STATUSUSOTABLA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatusdesc_Internalname = "STATUSDESC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatususuario_Internalname = "STATUSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatusfecreg_Internalname = "STATUSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtstatusfecultact_Internalname = "STATUSFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTablemain_Internalname = "TABLEMAIN";
         div_Internalname = "";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "status";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtstatusfecultact_Jsonclick = "";
         edtstatusfecultact_Enabled = 1;
         edtstatusfecreg_Jsonclick = "";
         edtstatusfecreg_Enabled = 1;
         edtstatususuario_Jsonclick = "";
         edtstatususuario_Enabled = 1;
         edtstatusdesc_Jsonclick = "";
         edtstatusdesc_Enabled = 1;
         edtstatususotabla_Jsonclick = "";
         edtstatususotabla_Enabled = 1;
         edtstatusdsc_Jsonclick = "";
         edtstatusdsc_Enabled = 1;
         edtstatusid_Jsonclick = "";
         edtstatusid_Enabled = 0;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7statusid',fld:'vSTATUSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z73statusdsc = "";
         Z74statususotabla = "";
         Z75statusdesc = "";
         Z76statususuario = "";
         Z77statusfecreg = (DateTime)(DateTime.MinValue);
         Z78statusfecultact = (DateTime)(DateTime.MinValue);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A73statusdsc = "";
         A74statususotabla = "";
         A75statusdesc = "";
         A76statususuario = "";
         A77statusfecreg = (DateTime)(DateTime.MinValue);
         A78statusfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode21 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000L4_A1statusid = new int[1] ;
         T000L4_A73statusdsc = new String[] {""} ;
         T000L4_n73statusdsc = new bool[] {false} ;
         T000L4_A74statususotabla = new String[] {""} ;
         T000L4_n74statususotabla = new bool[] {false} ;
         T000L4_A75statusdesc = new String[] {""} ;
         T000L4_n75statusdesc = new bool[] {false} ;
         T000L4_A76statususuario = new String[] {""} ;
         T000L4_n76statususuario = new bool[] {false} ;
         T000L4_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         T000L4_n77statusfecreg = new bool[] {false} ;
         T000L4_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         T000L4_n78statusfecultact = new bool[] {false} ;
         T000L5_A1statusid = new int[1] ;
         T000L3_A1statusid = new int[1] ;
         T000L3_A73statusdsc = new String[] {""} ;
         T000L3_n73statusdsc = new bool[] {false} ;
         T000L3_A74statususotabla = new String[] {""} ;
         T000L3_n74statususotabla = new bool[] {false} ;
         T000L3_A75statusdesc = new String[] {""} ;
         T000L3_n75statusdesc = new bool[] {false} ;
         T000L3_A76statususuario = new String[] {""} ;
         T000L3_n76statususuario = new bool[] {false} ;
         T000L3_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         T000L3_n77statusfecreg = new bool[] {false} ;
         T000L3_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         T000L3_n78statusfecultact = new bool[] {false} ;
         T000L6_A1statusid = new int[1] ;
         T000L7_A1statusid = new int[1] ;
         T000L2_A1statusid = new int[1] ;
         T000L2_A73statusdsc = new String[] {""} ;
         T000L2_n73statusdsc = new bool[] {false} ;
         T000L2_A74statususotabla = new String[] {""} ;
         T000L2_n74statususotabla = new bool[] {false} ;
         T000L2_A75statusdesc = new String[] {""} ;
         T000L2_n75statusdesc = new bool[] {false} ;
         T000L2_A76statususuario = new String[] {""} ;
         T000L2_n76statususuario = new bool[] {false} ;
         T000L2_A77statusfecreg = new DateTime[] {DateTime.MinValue} ;
         T000L2_n77statusfecreg = new bool[] {false} ;
         T000L2_A78statusfecultact = new DateTime[] {DateTime.MinValue} ;
         T000L2_n78statusfecultact = new bool[] {false} ;
         T000L11_A1statusid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.status__default(),
            new Object[][] {
                new Object[] {
               T000L2_A1statusid, T000L2_A73statusdsc, T000L2_n73statusdsc, T000L2_A74statususotabla, T000L2_n74statususotabla, T000L2_A75statusdesc, T000L2_n75statusdesc, T000L2_A76statususuario, T000L2_n76statususuario, T000L2_A77statusfecreg,
               T000L2_n77statusfecreg, T000L2_A78statusfecultact, T000L2_n78statusfecultact
               }
               , new Object[] {
               T000L3_A1statusid, T000L3_A73statusdsc, T000L3_n73statusdsc, T000L3_A74statususotabla, T000L3_n74statususotabla, T000L3_A75statusdesc, T000L3_n75statusdesc, T000L3_A76statususuario, T000L3_n76statususuario, T000L3_A77statusfecreg,
               T000L3_n77statusfecreg, T000L3_A78statusfecultact, T000L3_n78statusfecultact
               }
               , new Object[] {
               T000L4_A1statusid, T000L4_A73statusdsc, T000L4_n73statusdsc, T000L4_A74statususotabla, T000L4_n74statususotabla, T000L4_A75statusdesc, T000L4_n75statusdesc, T000L4_A76statususuario, T000L4_n76statususuario, T000L4_A77statusfecreg,
               T000L4_n77statusfecreg, T000L4_A78statusfecultact, T000L4_n78statusfecultact
               }
               , new Object[] {
               T000L5_A1statusid
               }
               , new Object[] {
               T000L6_A1statusid
               }
               , new Object[] {
               T000L7_A1statusid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L11_A1statusid
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound21 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7statusid ;
      private int Z1statusid ;
      private int AV7statusid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A1statusid ;
      private int edtstatusid_Enabled ;
      private int edtstatusdsc_Enabled ;
      private int edtstatususotabla_Enabled ;
      private int edtstatusdesc_Enabled ;
      private int edtstatususuario_Enabled ;
      private int edtstatusfecreg_Enabled ;
      private int edtstatusfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtstatusdsc_Internalname ;
      private String divTablemain_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtstatusid_Internalname ;
      private String edtstatusid_Jsonclick ;
      private String edtstatusdsc_Jsonclick ;
      private String edtstatususotabla_Internalname ;
      private String edtstatususotabla_Jsonclick ;
      private String edtstatusdesc_Internalname ;
      private String edtstatusdesc_Jsonclick ;
      private String edtstatususuario_Internalname ;
      private String edtstatususuario_Jsonclick ;
      private String edtstatusfecreg_Internalname ;
      private String edtstatusfecreg_Jsonclick ;
      private String edtstatusfecultact_Internalname ;
      private String edtstatusfecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode21 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z77statusfecreg ;
      private DateTime Z78statusfecultact ;
      private DateTime A77statusfecreg ;
      private DateTime A78statusfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n73statusdsc ;
      private bool n74statususotabla ;
      private bool n75statusdesc ;
      private bool n76statususuario ;
      private bool n77statusfecreg ;
      private bool n78statusfecultact ;
      private bool Gx_longc ;
      private String Z73statusdsc ;
      private String Z74statususotabla ;
      private String Z75statusdesc ;
      private String Z76statususuario ;
      private String A73statusdsc ;
      private String A74statususotabla ;
      private String A75statusdesc ;
      private String A76statususuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000L4_A1statusid ;
      private String[] T000L4_A73statusdsc ;
      private bool[] T000L4_n73statusdsc ;
      private String[] T000L4_A74statususotabla ;
      private bool[] T000L4_n74statususotabla ;
      private String[] T000L4_A75statusdesc ;
      private bool[] T000L4_n75statusdesc ;
      private String[] T000L4_A76statususuario ;
      private bool[] T000L4_n76statususuario ;
      private DateTime[] T000L4_A77statusfecreg ;
      private bool[] T000L4_n77statusfecreg ;
      private DateTime[] T000L4_A78statusfecultact ;
      private bool[] T000L4_n78statusfecultact ;
      private int[] T000L5_A1statusid ;
      private int[] T000L3_A1statusid ;
      private String[] T000L3_A73statusdsc ;
      private bool[] T000L3_n73statusdsc ;
      private String[] T000L3_A74statususotabla ;
      private bool[] T000L3_n74statususotabla ;
      private String[] T000L3_A75statusdesc ;
      private bool[] T000L3_n75statusdesc ;
      private String[] T000L3_A76statususuario ;
      private bool[] T000L3_n76statususuario ;
      private DateTime[] T000L3_A77statusfecreg ;
      private bool[] T000L3_n77statusfecreg ;
      private DateTime[] T000L3_A78statusfecultact ;
      private bool[] T000L3_n78statusfecultact ;
      private int[] T000L6_A1statusid ;
      private int[] T000L7_A1statusid ;
      private int[] T000L2_A1statusid ;
      private String[] T000L2_A73statusdsc ;
      private bool[] T000L2_n73statusdsc ;
      private String[] T000L2_A74statususotabla ;
      private bool[] T000L2_n74statususotabla ;
      private String[] T000L2_A75statusdesc ;
      private bool[] T000L2_n75statusdesc ;
      private String[] T000L2_A76statususuario ;
      private bool[] T000L2_n76statususuario ;
      private DateTime[] T000L2_A77statusfecreg ;
      private bool[] T000L2_n77statusfecreg ;
      private DateTime[] T000L2_A78statusfecultact ;
      private bool[] T000L2_n78statusfecultact ;
      private int[] T000L11_A1statusid ;
      private GXWebForm Form ;
   }

   public class status__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000L4 ;
          prmT000L4 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L5 ;
          prmT000L5 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L3 ;
          prmT000L3 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L6 ;
          prmT000L6 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L7 ;
          prmT000L7 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L2 ;
          prmT000L2 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L8 ;
          prmT000L8 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"statusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"statusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000L9 ;
          prmT000L9 = new Object[] {
          new Object[] {"statusdsc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statusdesc",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"statususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"statusfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L10 ;
          prmT000L10 = new Object[] {
          new Object[] {"statusid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000L11 ;
          prmT000L11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000L2", "SELECT statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact FROM public.status WHERE statusid = :statusid  FOR UPDATE OF status NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000L2,1,0,true,false )
             ,new CursorDef("T000L3", "SELECT statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact FROM public.status WHERE statusid = :statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L3,1,0,true,false )
             ,new CursorDef("T000L4", "SELECT TM1.statusid, TM1.statusdsc, TM1.statususotabla, TM1.statusdesc, TM1.statususuario, TM1.statusfecreg, TM1.statusfecultact FROM public.status TM1 WHERE TM1.statusid = :statusid ORDER BY TM1.statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L4,100,0,true,false )
             ,new CursorDef("T000L5", "SELECT statusid FROM public.status WHERE statusid = :statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L5,1,0,true,false )
             ,new CursorDef("T000L6", "SELECT statusid FROM public.status WHERE ( statusid > :statusid) ORDER BY statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L6,1,0,true,true )
             ,new CursorDef("T000L7", "SELECT statusid FROM public.status WHERE ( statusid < :statusid) ORDER BY statusid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L7,1,0,true,true )
             ,new CursorDef("T000L8", "SAVEPOINT gxupdate;INSERT INTO public.status(statusid, statusdsc, statususotabla, statusdesc, statususuario, statusfecreg, statusfecultact) VALUES(:statusid, :statusdsc, :statususotabla, :statusdesc, :statususuario, :statusfecreg, :statusfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000L8)
             ,new CursorDef("T000L9", "SAVEPOINT gxupdate;UPDATE public.status SET statusdsc=:statusdsc, statususotabla=:statususotabla, statusdesc=:statusdesc, statususuario=:statususuario, statusfecreg=:statusfecreg, statusfecultact=:statusfecultact  WHERE statusid = :statusid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000L9)
             ,new CursorDef("T000L10", "SAVEPOINT gxupdate;DELETE FROM public.status  WHERE statusid = :statusid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000L10)
             ,new CursorDef("T000L11", "SELECT statusid FROM public.status ORDER BY statusid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L11,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[12]);
                }
                return;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[11]);
                }
                stmt.SetParameter(7, (int)parms[12]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
