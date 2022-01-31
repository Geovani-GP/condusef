/*
               File: cambs
        Description: cambs
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:37:50.38
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
   public class cambs : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV8cambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cambsid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8cambsid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "cambs", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtcambsdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public cambs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public cambs( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_cambsid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV8cambsid = aP1_cambsid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "cambs", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_cambs.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_cambs.htm");
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
            GxWebStd.gx_label_element( context, edtcambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtcambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ",", "")), ((edtcambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtcambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_cambs.htm");
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
            GxWebStd.gx_label_element( context, edtcambsdsc_Internalname, "cambsdsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcambsdsc_Internalname, A83cambsdsc, StringUtil.RTrim( context.localUtil.Format( A83cambsdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcambsdsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtcambsdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_cambs.htm");
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
            GxWebStd.gx_label_element( context, edtcambsusuario_Internalname, "cambsusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcambsusuario_Internalname, A84cambsusuario, StringUtil.RTrim( context.localUtil.Format( A84cambsusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcambsusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtcambsusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_cambs.htm");
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
            GxWebStd.gx_label_element( context, edtcambsfecreg_Internalname, "cambsfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtcambsfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtcambsfecreg_Internalname, context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A85cambsfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcambsfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtcambsfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_cambs.htm");
            GxWebStd.gx_bitmap( context, edtcambsfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtcambsfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_cambs.htm");
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
            GxWebStd.gx_label_element( context, edtcambsfecultact_Internalname, "cambsfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtcambsfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtcambsfecultact_Internalname, context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A86cambsfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcambsfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtcambsfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_cambs.htm");
            GxWebStd.gx_bitmap( context, edtcambsfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtcambsfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_cambs.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_cambs.htm");
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
               A25cambsid = (int)(context.localUtil.CToN( cgiGet( edtcambsid_Internalname), ",", "."));
               n25cambsid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
               A83cambsdsc = cgiGet( edtcambsdsc_Internalname);
               n83cambsdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83cambsdsc", A83cambsdsc);
               n83cambsdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A83cambsdsc)) ? true : false);
               A84cambsusuario = cgiGet( edtcambsusuario_Internalname);
               n84cambsusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84cambsusuario", A84cambsusuario);
               n84cambsusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A84cambsusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtcambsfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"cambsfecreg"}), 1, "CAMBSFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtcambsfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A85cambsfecreg = (DateTime)(DateTime.MinValue);
                  n85cambsfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85cambsfecreg", context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A85cambsfecreg = context.localUtil.CToT( cgiGet( edtcambsfecreg_Internalname));
                  n85cambsfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85cambsfecreg", context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n85cambsfecreg = ((DateTime.MinValue==A85cambsfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtcambsfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"cambsfecultact"}), 1, "CAMBSFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtcambsfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A86cambsfecultact = (DateTime)(DateTime.MinValue);
                  n86cambsfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86cambsfecultact", context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A86cambsfecultact = context.localUtil.CToT( cgiGet( edtcambsfecultact_Internalname));
                  n86cambsfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86cambsfecultact", context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n86cambsfecultact = ((DateTime.MinValue==A86cambsfecultact) ? true : false);
               /* Read saved values. */
               Z25cambsid = (int)(context.localUtil.CToN( cgiGet( "Z25cambsid"), ",", "."));
               Z83cambsdsc = cgiGet( "Z83cambsdsc");
               n83cambsdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A83cambsdsc)) ? true : false);
               Z84cambsusuario = cgiGet( "Z84cambsusuario");
               n84cambsusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A84cambsusuario)) ? true : false);
               Z85cambsfecreg = context.localUtil.CToT( cgiGet( "Z85cambsfecreg"), 0);
               n85cambsfecreg = ((DateTime.MinValue==A85cambsfecreg) ? true : false);
               Z86cambsfecultact = context.localUtil.CToT( cgiGet( "Z86cambsfecultact"), 0);
               n86cambsfecultact = ((DateTime.MinValue==A86cambsfecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV8cambsid = (int)(context.localUtil.CToN( cgiGet( "vCAMBSID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "cambs";
               A25cambsid = (int)(context.localUtil.CToN( cgiGet( edtcambsid_Internalname), ",", "."));
               n25cambsid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A25cambsid != Z25cambsid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("cambs:[SecurityCheckFailed value for]"+"cambsid:"+context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("cambs:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A25cambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  n25cambsid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
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
                     sMode14 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode14;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound14 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0E0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CAMBSID");
                        AnyError = 1;
                        GX_FocusControl = edtcambsid_Internalname;
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
               InitAll0E14( ) ;
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
            DisableAttributes0E14( ) ;
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

      protected void CONFIRM_0E0( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0E14( ) ;
            }
            else
            {
               CheckExtendedTable0E14( ) ;
               CloseExtendedTableCursors0E14( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0E0( )
      {
      }

      protected void ZM0E14( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z83cambsdsc = T000E3_A83cambsdsc[0];
               Z84cambsusuario = T000E3_A84cambsusuario[0];
               Z85cambsfecreg = T000E3_A85cambsfecreg[0];
               Z86cambsfecultact = T000E3_A86cambsfecultact[0];
            }
            else
            {
               Z83cambsdsc = A83cambsdsc;
               Z84cambsusuario = A84cambsusuario;
               Z85cambsfecreg = A85cambsfecreg;
               Z86cambsfecultact = A86cambsfecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z25cambsid = A25cambsid;
            Z83cambsdsc = A83cambsdsc;
            Z84cambsusuario = A84cambsusuario;
            Z85cambsfecreg = A85cambsfecreg;
            Z86cambsfecultact = A86cambsfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtcambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsid_Enabled), 5, 0)));
         edtcambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV8cambsid) )
         {
            A25cambsid = AV8cambsid;
            n25cambsid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
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

      protected void Load0E14( )
      {
         /* Using cursor T000E4 */
         pr_default.execute(2, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound14 = 1;
            A83cambsdsc = T000E4_A83cambsdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83cambsdsc", A83cambsdsc);
            n83cambsdsc = T000E4_n83cambsdsc[0];
            A84cambsusuario = T000E4_A84cambsusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84cambsusuario", A84cambsusuario);
            n84cambsusuario = T000E4_n84cambsusuario[0];
            A85cambsfecreg = T000E4_A85cambsfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85cambsfecreg", context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "));
            n85cambsfecreg = T000E4_n85cambsfecreg[0];
            A86cambsfecultact = T000E4_A86cambsfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86cambsfecultact", context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "));
            n86cambsfecultact = T000E4_n86cambsfecultact[0];
            ZM0E14( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0E14( ) ;
      }

      protected void OnLoadActions0E14( )
      {
      }

      protected void CheckExtendedTable0E14( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0E14( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0E14( )
      {
         /* Using cursor T000E5 */
         pr_default.execute(3, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound14 = 1;
         }
         else
         {
            RcdFound14 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000E3 */
         pr_default.execute(1, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0E14( 3) ;
            RcdFound14 = 1;
            A25cambsid = T000E3_A25cambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
            n25cambsid = T000E3_n25cambsid[0];
            A83cambsdsc = T000E3_A83cambsdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83cambsdsc", A83cambsdsc);
            n83cambsdsc = T000E3_n83cambsdsc[0];
            A84cambsusuario = T000E3_A84cambsusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84cambsusuario", A84cambsusuario);
            n84cambsusuario = T000E3_n84cambsusuario[0];
            A85cambsfecreg = T000E3_A85cambsfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85cambsfecreg", context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "));
            n85cambsfecreg = T000E3_n85cambsfecreg[0];
            A86cambsfecultact = T000E3_A86cambsfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86cambsfecultact", context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "));
            n86cambsfecultact = T000E3_n86cambsfecultact[0];
            Z25cambsid = A25cambsid;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0E14( ) ;
            if ( AnyError == 1 )
            {
               RcdFound14 = 0;
               InitializeNonKey0E14( ) ;
            }
            Gx_mode = sMode14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound14 = 0;
            InitializeNonKey0E14( ) ;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0E14( ) ;
         if ( RcdFound14 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound14 = 0;
         /* Using cursor T000E6 */
         pr_default.execute(4, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000E6_A25cambsid[0] < A25cambsid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000E6_A25cambsid[0] > A25cambsid ) ) )
            {
               A25cambsid = T000E6_A25cambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
               n25cambsid = T000E6_n25cambsid[0];
               RcdFound14 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound14 = 0;
         /* Using cursor T000E7 */
         pr_default.execute(5, new Object[] {n25cambsid, A25cambsid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000E7_A25cambsid[0] > A25cambsid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000E7_A25cambsid[0] < A25cambsid ) ) )
            {
               A25cambsid = T000E7_A25cambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
               n25cambsid = T000E7_n25cambsid[0];
               RcdFound14 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0E14( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtcambsdsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0E14( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound14 == 1 )
            {
               if ( A25cambsid != Z25cambsid )
               {
                  A25cambsid = Z25cambsid;
                  n25cambsid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CAMBSID");
                  AnyError = 1;
                  GX_FocusControl = edtcambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtcambsdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0E14( ) ;
                  GX_FocusControl = edtcambsdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A25cambsid != Z25cambsid )
               {
                  /* Insert record */
                  GX_FocusControl = edtcambsdsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0E14( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CAMBSID");
                     AnyError = 1;
                     GX_FocusControl = edtcambsid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtcambsdsc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0E14( ) ;
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
         if ( A25cambsid != Z25cambsid )
         {
            A25cambsid = Z25cambsid;
            n25cambsid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CAMBSID");
            AnyError = 1;
            GX_FocusControl = edtcambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtcambsdsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0E14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000E2 */
            pr_default.execute(0, new Object[] {n25cambsid, A25cambsid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CAMBS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z83cambsdsc, T000E2_A83cambsdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z84cambsusuario, T000E2_A84cambsusuario[0]) != 0 ) || ( Z85cambsfecreg != T000E2_A85cambsfecreg[0] ) || ( Z86cambsfecultact != T000E2_A86cambsfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z83cambsdsc, T000E2_A83cambsdsc[0]) != 0 )
               {
                  GXUtil.WriteLog("cambs:[seudo value changed for attri]"+"cambsdsc");
                  GXUtil.WriteLogRaw("Old: ",Z83cambsdsc);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A83cambsdsc[0]);
               }
               if ( StringUtil.StrCmp(Z84cambsusuario, T000E2_A84cambsusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("cambs:[seudo value changed for attri]"+"cambsusuario");
                  GXUtil.WriteLogRaw("Old: ",Z84cambsusuario);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A84cambsusuario[0]);
               }
               if ( Z85cambsfecreg != T000E2_A85cambsfecreg[0] )
               {
                  GXUtil.WriteLog("cambs:[seudo value changed for attri]"+"cambsfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z85cambsfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A85cambsfecreg[0]);
               }
               if ( Z86cambsfecultact != T000E2_A86cambsfecultact[0] )
               {
                  GXUtil.WriteLog("cambs:[seudo value changed for attri]"+"cambsfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z86cambsfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A86cambsfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CAMBS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E14( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E14( 0) ;
            CheckOptimisticConcurrency0E14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E8 */
                     pr_default.execute(6, new Object[] {n25cambsid, A25cambsid, n83cambsdsc, A83cambsdsc, n84cambsusuario, A84cambsusuario, n85cambsfecreg, A85cambsfecreg, n86cambsfecultact, A86cambsfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
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
                           ResetCaption0E0( ) ;
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
               Load0E14( ) ;
            }
            EndLevel0E14( ) ;
         }
         CloseExtendedTableCursors0E14( ) ;
      }

      protected void Update0E14( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E9 */
                     pr_default.execute(7, new Object[] {n83cambsdsc, A83cambsdsc, n84cambsusuario, A84cambsusuario, n85cambsfecreg, A85cambsfecreg, n86cambsfecultact, A86cambsfecultact, n25cambsid, A25cambsid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CAMBS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E14( ) ;
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
            EndLevel0E14( ) ;
         }
         CloseExtendedTableCursors0E14( ) ;
      }

      protected void DeferredUpdate0E14( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0E14( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E14( ) ;
            AfterConfirm0E14( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E14( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000E10 */
                  pr_default.execute(8, new Object[] {n25cambsid, A25cambsid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("CAMBS") ;
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
         sMode14 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0E14( ) ;
         Gx_mode = sMode14;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0E14( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000E11 */
            pr_default.execute(9, new Object[] {n25cambsid, A25cambsid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"producto"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000E12 */
            pr_default.execute(10, new Object[] {n25cambsid, A25cambsid});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000E13 */
            pr_default.execute(11, new Object[] {n25cambsid, A25cambsid});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0E14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0E14( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "cambs");
            if ( AnyError == 0 )
            {
               ConfirmValues0E0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "cambs");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0E14( )
      {
         /* Scan By routine */
         /* Using cursor T000E14 */
         pr_default.execute(12);
         RcdFound14 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound14 = 1;
            A25cambsid = T000E14_A25cambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
            n25cambsid = T000E14_n25cambsid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0E14( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound14 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound14 = 1;
            A25cambsid = T000E14_A25cambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
            n25cambsid = T000E14_n25cambsid[0];
         }
      }

      protected void ScanEnd0E14( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0E14( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E14( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0E14( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0E14( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E14( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E14( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E14( )
      {
         edtcambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsid_Enabled), 5, 0)));
         edtcambsdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsdsc_Enabled), 5, 0)));
         edtcambsusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsusuario_Enabled), 5, 0)));
         edtcambsfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsfecreg_Enabled), 5, 0)));
         edtcambsfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcambsfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcambsfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0E0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202213023375121");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("cambs.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV8cambsid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z25cambsid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25cambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z83cambsdsc", Z83cambsdsc);
         GxWebStd.gx_hidden_field( context, "Z84cambsusuario", Z84cambsusuario);
         GxWebStd.gx_hidden_field( context, "Z85cambsfecreg", context.localUtil.TToC( Z85cambsfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z86cambsfecultact", context.localUtil.TToC( Z86cambsfecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vCAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vCAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8cambsid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "cambs";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("cambs:[SendSecurityCheck value for]"+"cambsid:"+context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("cambs:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("cambs.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV8cambsid) ;
      }

      public override String GetPgmname( )
      {
         return "cambs" ;
      }

      public override String GetPgmdesc( )
      {
         return "cambs" ;
      }

      protected void InitializeNonKey0E14( )
      {
         A83cambsdsc = "";
         n83cambsdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83cambsdsc", A83cambsdsc);
         n83cambsdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A83cambsdsc)) ? true : false);
         A84cambsusuario = "";
         n84cambsusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84cambsusuario", A84cambsusuario);
         n84cambsusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A84cambsusuario)) ? true : false);
         A85cambsfecreg = (DateTime)(DateTime.MinValue);
         n85cambsfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85cambsfecreg", context.localUtil.TToC( A85cambsfecreg, 10, 8, 0, 3, "/", ":", " "));
         n85cambsfecreg = ((DateTime.MinValue==A85cambsfecreg) ? true : false);
         A86cambsfecultact = (DateTime)(DateTime.MinValue);
         n86cambsfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86cambsfecultact", context.localUtil.TToC( A86cambsfecultact, 10, 8, 0, 3, "/", ":", " "));
         n86cambsfecultact = ((DateTime.MinValue==A86cambsfecultact) ? true : false);
         Z83cambsdsc = "";
         Z84cambsusuario = "";
         Z85cambsfecreg = (DateTime)(DateTime.MinValue);
         Z86cambsfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0E14( )
      {
         A25cambsid = 0;
         n25cambsid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A25cambsid), 9, 0)));
         InitializeNonKey0E14( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202213023375128");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("cambs.js", "?202213023375128");
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
         edtcambsid_Internalname = "CAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtcambsdsc_Internalname = "CAMBSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtcambsusuario_Internalname = "CAMBSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtcambsfecreg_Internalname = "CAMBSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtcambsfecultact_Internalname = "CAMBSFECULTACT";
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
         Form.Caption = "cambs";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtcambsfecultact_Jsonclick = "";
         edtcambsfecultact_Enabled = 1;
         edtcambsfecreg_Jsonclick = "";
         edtcambsfecreg_Enabled = 1;
         edtcambsusuario_Jsonclick = "";
         edtcambsusuario_Enabled = 1;
         edtcambsdsc_Jsonclick = "";
         edtcambsdsc_Enabled = 1;
         edtcambsid_Jsonclick = "";
         edtcambsid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV8cambsid',fld:'vCAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z83cambsdsc = "";
         Z84cambsusuario = "";
         Z85cambsfecreg = (DateTime)(DateTime.MinValue);
         Z86cambsfecultact = (DateTime)(DateTime.MinValue);
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
         A83cambsdsc = "";
         A84cambsusuario = "";
         A85cambsfecreg = (DateTime)(DateTime.MinValue);
         A86cambsfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode14 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000E4_A25cambsid = new int[1] ;
         T000E4_n25cambsid = new bool[] {false} ;
         T000E4_A83cambsdsc = new String[] {""} ;
         T000E4_n83cambsdsc = new bool[] {false} ;
         T000E4_A84cambsusuario = new String[] {""} ;
         T000E4_n84cambsusuario = new bool[] {false} ;
         T000E4_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         T000E4_n85cambsfecreg = new bool[] {false} ;
         T000E4_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         T000E4_n86cambsfecultact = new bool[] {false} ;
         T000E5_A25cambsid = new int[1] ;
         T000E5_n25cambsid = new bool[] {false} ;
         T000E3_A25cambsid = new int[1] ;
         T000E3_n25cambsid = new bool[] {false} ;
         T000E3_A83cambsdsc = new String[] {""} ;
         T000E3_n83cambsdsc = new bool[] {false} ;
         T000E3_A84cambsusuario = new String[] {""} ;
         T000E3_n84cambsusuario = new bool[] {false} ;
         T000E3_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         T000E3_n85cambsfecreg = new bool[] {false} ;
         T000E3_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         T000E3_n86cambsfecultact = new bool[] {false} ;
         T000E6_A25cambsid = new int[1] ;
         T000E6_n25cambsid = new bool[] {false} ;
         T000E7_A25cambsid = new int[1] ;
         T000E7_n25cambsid = new bool[] {false} ;
         T000E2_A25cambsid = new int[1] ;
         T000E2_n25cambsid = new bool[] {false} ;
         T000E2_A83cambsdsc = new String[] {""} ;
         T000E2_n83cambsdsc = new bool[] {false} ;
         T000E2_A84cambsusuario = new String[] {""} ;
         T000E2_n84cambsusuario = new bool[] {false} ;
         T000E2_A85cambsfecreg = new DateTime[] {DateTime.MinValue} ;
         T000E2_n85cambsfecreg = new bool[] {false} ;
         T000E2_A86cambsfecultact = new DateTime[] {DateTime.MinValue} ;
         T000E2_n86cambsfecultact = new bool[] {false} ;
         T000E11_A175productoid = new int[1] ;
         T000E12_A19almacenid = new long[1] ;
         T000E12_A20articulosproductoid = new int[1] ;
         T000E12_A21articuloscambsid = new int[1] ;
         T000E13_A17etiquetasproductoid = new int[1] ;
         T000E13_A18etiquetascambsid = new int[1] ;
         T000E13_A19almacenid = new long[1] ;
         T000E14_A25cambsid = new int[1] ;
         T000E14_n25cambsid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cambs__default(),
            new Object[][] {
                new Object[] {
               T000E2_A25cambsid, T000E2_A83cambsdsc, T000E2_n83cambsdsc, T000E2_A84cambsusuario, T000E2_n84cambsusuario, T000E2_A85cambsfecreg, T000E2_n85cambsfecreg, T000E2_A86cambsfecultact, T000E2_n86cambsfecultact
               }
               , new Object[] {
               T000E3_A25cambsid, T000E3_A83cambsdsc, T000E3_n83cambsdsc, T000E3_A84cambsusuario, T000E3_n84cambsusuario, T000E3_A85cambsfecreg, T000E3_n85cambsfecreg, T000E3_A86cambsfecultact, T000E3_n86cambsfecultact
               }
               , new Object[] {
               T000E4_A25cambsid, T000E4_A83cambsdsc, T000E4_n83cambsdsc, T000E4_A84cambsusuario, T000E4_n84cambsusuario, T000E4_A85cambsfecreg, T000E4_n85cambsfecreg, T000E4_A86cambsfecultact, T000E4_n86cambsfecultact
               }
               , new Object[] {
               T000E5_A25cambsid
               }
               , new Object[] {
               T000E6_A25cambsid
               }
               , new Object[] {
               T000E7_A25cambsid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000E11_A175productoid
               }
               , new Object[] {
               T000E12_A19almacenid, T000E12_A20articulosproductoid, T000E12_A21articuloscambsid
               }
               , new Object[] {
               T000E13_A17etiquetasproductoid, T000E13_A18etiquetascambsid, T000E13_A19almacenid
               }
               , new Object[] {
               T000E14_A25cambsid
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
      private short RcdFound14 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV8cambsid ;
      private int Z25cambsid ;
      private int AV8cambsid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A25cambsid ;
      private int edtcambsid_Enabled ;
      private int edtcambsdsc_Enabled ;
      private int edtcambsusuario_Enabled ;
      private int edtcambsfecreg_Enabled ;
      private int edtcambsfecultact_Enabled ;
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
      private String edtcambsdsc_Internalname ;
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
      private String edtcambsid_Internalname ;
      private String edtcambsid_Jsonclick ;
      private String edtcambsdsc_Jsonclick ;
      private String edtcambsusuario_Internalname ;
      private String edtcambsusuario_Jsonclick ;
      private String edtcambsfecreg_Internalname ;
      private String edtcambsfecreg_Jsonclick ;
      private String edtcambsfecultact_Internalname ;
      private String edtcambsfecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode14 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z85cambsfecreg ;
      private DateTime Z86cambsfecultact ;
      private DateTime A85cambsfecreg ;
      private DateTime A86cambsfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n25cambsid ;
      private bool n83cambsdsc ;
      private bool n84cambsusuario ;
      private bool n85cambsfecreg ;
      private bool n86cambsfecultact ;
      private String Z83cambsdsc ;
      private String Z84cambsusuario ;
      private String A83cambsdsc ;
      private String A84cambsusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000E4_A25cambsid ;
      private bool[] T000E4_n25cambsid ;
      private String[] T000E4_A83cambsdsc ;
      private bool[] T000E4_n83cambsdsc ;
      private String[] T000E4_A84cambsusuario ;
      private bool[] T000E4_n84cambsusuario ;
      private DateTime[] T000E4_A85cambsfecreg ;
      private bool[] T000E4_n85cambsfecreg ;
      private DateTime[] T000E4_A86cambsfecultact ;
      private bool[] T000E4_n86cambsfecultact ;
      private int[] T000E5_A25cambsid ;
      private bool[] T000E5_n25cambsid ;
      private int[] T000E3_A25cambsid ;
      private bool[] T000E3_n25cambsid ;
      private String[] T000E3_A83cambsdsc ;
      private bool[] T000E3_n83cambsdsc ;
      private String[] T000E3_A84cambsusuario ;
      private bool[] T000E3_n84cambsusuario ;
      private DateTime[] T000E3_A85cambsfecreg ;
      private bool[] T000E3_n85cambsfecreg ;
      private DateTime[] T000E3_A86cambsfecultact ;
      private bool[] T000E3_n86cambsfecultact ;
      private int[] T000E6_A25cambsid ;
      private bool[] T000E6_n25cambsid ;
      private int[] T000E7_A25cambsid ;
      private bool[] T000E7_n25cambsid ;
      private int[] T000E2_A25cambsid ;
      private bool[] T000E2_n25cambsid ;
      private String[] T000E2_A83cambsdsc ;
      private bool[] T000E2_n83cambsdsc ;
      private String[] T000E2_A84cambsusuario ;
      private bool[] T000E2_n84cambsusuario ;
      private DateTime[] T000E2_A85cambsfecreg ;
      private bool[] T000E2_n85cambsfecreg ;
      private DateTime[] T000E2_A86cambsfecultact ;
      private bool[] T000E2_n86cambsfecultact ;
      private int[] T000E11_A175productoid ;
      private long[] T000E12_A19almacenid ;
      private int[] T000E12_A20articulosproductoid ;
      private int[] T000E12_A21articuloscambsid ;
      private int[] T000E13_A17etiquetasproductoid ;
      private int[] T000E13_A18etiquetascambsid ;
      private long[] T000E13_A19almacenid ;
      private int[] T000E14_A25cambsid ;
      private bool[] T000E14_n25cambsid ;
      private GXWebForm Form ;
   }

   public class cambs__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000E4 ;
          prmT000E4 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E5 ;
          prmT000E5 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E3 ;
          prmT000E3 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E6 ;
          prmT000E6 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E7 ;
          prmT000E7 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E2 ;
          prmT000E2 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E8 ;
          prmT000E8 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"cambsdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"cambsusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"cambsfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000E9 ;
          prmT000E9 = new Object[] {
          new Object[] {"cambsdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"cambsusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"cambsfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E10 ;
          prmT000E10 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E11 ;
          prmT000E11 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E12 ;
          prmT000E12 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E13 ;
          prmT000E13 = new Object[] {
          new Object[] {"cambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000E14 ;
          prmT000E14 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000E2", "SELECT cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact FROM public.cambs WHERE cambsid = :cambsid  FOR UPDATE OF cambs NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000E2,1,0,true,false )
             ,new CursorDef("T000E3", "SELECT cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact FROM public.cambs WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E3,1,0,true,false )
             ,new CursorDef("T000E4", "SELECT TM1.cambsid, TM1.cambsdsc, TM1.cambsusuario, TM1.cambsfecreg, TM1.cambsfecultact FROM public.cambs TM1 WHERE TM1.cambsid = :cambsid ORDER BY TM1.cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E4,100,0,true,false )
             ,new CursorDef("T000E5", "SELECT cambsid FROM public.cambs WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E5,1,0,true,false )
             ,new CursorDef("T000E6", "SELECT cambsid FROM public.cambs WHERE ( cambsid > :cambsid) ORDER BY cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E6,1,0,true,true )
             ,new CursorDef("T000E7", "SELECT cambsid FROM public.cambs WHERE ( cambsid < :cambsid) ORDER BY cambsid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E7,1,0,true,true )
             ,new CursorDef("T000E8", "SAVEPOINT gxupdate;INSERT INTO public.cambs(cambsid, cambsdsc, cambsusuario, cambsfecreg, cambsfecultact) VALUES(:cambsid, :cambsdsc, :cambsusuario, :cambsfecreg, :cambsfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000E8)
             ,new CursorDef("T000E9", "SAVEPOINT gxupdate;UPDATE public.cambs SET cambsdsc=:cambsdsc, cambsusuario=:cambsusuario, cambsfecreg=:cambsfecreg, cambsfecultact=:cambsfecultact  WHERE cambsid = :cambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000E9)
             ,new CursorDef("T000E10", "SAVEPOINT gxupdate;DELETE FROM public.cambs  WHERE cambsid = :cambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000E10)
             ,new CursorDef("T000E11", "SELECT productoid FROM producto WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E11,1,0,true,true )
             ,new CursorDef("T000E12", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E12,1,0,true,true )
             ,new CursorDef("T000E13", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE cambsid = :cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E13,1,0,true,true )
             ,new CursorDef("T000E14", "SELECT cambsid FROM public.cambs ORDER BY cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E14,100,0,true,false )
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
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
             case 10 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 12 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[9]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
       }
    }

 }

}
