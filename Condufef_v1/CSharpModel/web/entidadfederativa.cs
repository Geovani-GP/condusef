/*
               File: entidadfederativa
        Description: entidadfederativa
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:43.29
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
   public class entidadfederativa : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7entidafederativaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7entidafederativaid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vENTIDAFEDERATIVAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7entidafederativaid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "entidadfederativa", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtentidadfederativadsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public entidadfederativa( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public entidadfederativa( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_entidafederativaid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7entidafederativaid = aP1_entidafederativaid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "entidadfederativa", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_label_element( context, edtentidafederativaid_Internalname, "entidafederativaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtentidafederativaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ",", "")), ((edtentidafederativaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidafederativaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidafederativaid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_label_element( context, edtentidadfederativadsc_Internalname, "entidadfederativadsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtentidadfederativadsc_Internalname, A108entidadfederativadsc, StringUtil.RTrim( context.localUtil.Format( A108entidadfederativadsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidadfederativadsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidadfederativadsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_label_element( context, edtentidadfederativausuario_Internalname, "entidadfederativausuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtentidadfederativausuario_Internalname, A109entidadfederativausuario, StringUtil.RTrim( context.localUtil.Format( A109entidadfederativausuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidadfederativausuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidadfederativausuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_label_element( context, edtentidadfederativafecreg_Internalname, "entidadfederativafecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtentidadfederativafecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtentidadfederativafecreg_Internalname, context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A110entidadfederativafecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidadfederativafecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidadfederativafecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_entidadfederativa.htm");
            GxWebStd.gx_bitmap( context, edtentidadfederativafecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtentidadfederativafecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_label_element( context, edtentidadfederativafecultact_Internalname, "entidadfederativafecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtentidadfederativafecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtentidadfederativafecultact_Internalname, context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A111entidadfederativafecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidadfederativafecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidadfederativafecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_entidadfederativa.htm");
            GxWebStd.gx_bitmap( context, edtentidadfederativafecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtentidadfederativafecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_entidadfederativa.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_entidadfederativa.htm");
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
               A7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", "."));
               n7entidafederativaid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               A108entidadfederativadsc = cgiGet( edtentidadfederativadsc_Internalname);
               n108entidadfederativadsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108entidadfederativadsc", A108entidadfederativadsc);
               n108entidadfederativadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A108entidadfederativadsc)) ? true : false);
               A109entidadfederativausuario = cgiGet( edtentidadfederativausuario_Internalname);
               n109entidadfederativausuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109entidadfederativausuario", A109entidadfederativausuario);
               n109entidadfederativausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A109entidadfederativausuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtentidadfederativafecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"entidadfederativafecreg"}), 1, "ENTIDADFEDERATIVAFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtentidadfederativafecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
                  n110entidadfederativafecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110entidadfederativafecreg", context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A110entidadfederativafecreg = context.localUtil.CToT( cgiGet( edtentidadfederativafecreg_Internalname));
                  n110entidadfederativafecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110entidadfederativafecreg", context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n110entidadfederativafecreg = ((DateTime.MinValue==A110entidadfederativafecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtentidadfederativafecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"entidadfederativafecultact"}), 1, "ENTIDADFEDERATIVAFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtentidadfederativafecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
                  n111entidadfederativafecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111entidadfederativafecultact", context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A111entidadfederativafecultact = context.localUtil.CToT( cgiGet( edtentidadfederativafecultact_Internalname));
                  n111entidadfederativafecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111entidadfederativafecultact", context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n111entidadfederativafecultact = ((DateTime.MinValue==A111entidadfederativafecultact) ? true : false);
               /* Read saved values. */
               Z7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( "Z7entidafederativaid"), ",", "."));
               Z108entidadfederativadsc = cgiGet( "Z108entidadfederativadsc");
               n108entidadfederativadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A108entidadfederativadsc)) ? true : false);
               Z109entidadfederativausuario = cgiGet( "Z109entidadfederativausuario");
               n109entidadfederativausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A109entidadfederativausuario)) ? true : false);
               Z110entidadfederativafecreg = context.localUtil.CToT( cgiGet( "Z110entidadfederativafecreg"), 0);
               n110entidadfederativafecreg = ((DateTime.MinValue==A110entidadfederativafecreg) ? true : false);
               Z111entidadfederativafecultact = context.localUtil.CToT( cgiGet( "Z111entidadfederativafecultact"), 0);
               n111entidadfederativafecultact = ((DateTime.MinValue==A111entidadfederativafecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( "vENTIDAFEDERATIVAID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "entidadfederativa";
               A7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", "."));
               n7entidafederativaid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A7entidafederativaid != Z7entidafederativaid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("entidadfederativa:[SecurityCheckFailed value for]"+"entidafederativaid:"+context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("entidadfederativa:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A7entidafederativaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  n7entidafederativaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
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
                     sMode4 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode4;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound4 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ENTIDAFEDERATIVAID");
                        AnyError = 1;
                        GX_FocusControl = edtentidafederativaid_Internalname;
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
               InitAll044( ) ;
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
            DisableAttributes044( ) ;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls044( ) ;
            }
            else
            {
               CheckExtendedTable044( ) ;
               CloseExtendedTableCursors044( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption040( )
      {
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z108entidadfederativadsc = T00043_A108entidadfederativadsc[0];
               Z109entidadfederativausuario = T00043_A109entidadfederativausuario[0];
               Z110entidadfederativafecreg = T00043_A110entidadfederativafecreg[0];
               Z111entidadfederativafecultact = T00043_A111entidadfederativafecultact[0];
            }
            else
            {
               Z108entidadfederativadsc = A108entidadfederativadsc;
               Z109entidadfederativausuario = A109entidadfederativausuario;
               Z110entidadfederativafecreg = A110entidadfederativafecreg;
               Z111entidadfederativafecultact = A111entidadfederativafecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z7entidafederativaid = A7entidafederativaid;
            Z108entidadfederativadsc = A108entidadfederativadsc;
            Z109entidadfederativausuario = A109entidadfederativausuario;
            Z110entidadfederativafecreg = A110entidadfederativafecreg;
            Z111entidadfederativafecultact = A111entidadfederativafecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtentidafederativaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidafederativaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidafederativaid_Enabled), 5, 0)));
         edtentidafederativaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidafederativaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidafederativaid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7entidafederativaid) )
         {
            A7entidafederativaid = AV7entidafederativaid;
            n7entidafederativaid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
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

      protected void Load044( )
      {
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound4 = 1;
            A108entidadfederativadsc = T00044_A108entidadfederativadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108entidadfederativadsc", A108entidadfederativadsc);
            n108entidadfederativadsc = T00044_n108entidadfederativadsc[0];
            A109entidadfederativausuario = T00044_A109entidadfederativausuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109entidadfederativausuario", A109entidadfederativausuario);
            n109entidadfederativausuario = T00044_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = T00044_A110entidadfederativafecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110entidadfederativafecreg", context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "));
            n110entidadfederativafecreg = T00044_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = T00044_A111entidadfederativafecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111entidadfederativafecultact", context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "));
            n111entidadfederativafecultact = T00044_n111entidadfederativafecultact[0];
            ZM044( -3) ;
         }
         pr_default.close(2);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
      }

      protected void CheckExtendedTable044( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors044( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey044( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM044( 3) ;
            RcdFound4 = 1;
            A7entidafederativaid = T00043_A7entidafederativaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            n7entidafederativaid = T00043_n7entidafederativaid[0];
            A108entidadfederativadsc = T00043_A108entidadfederativadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108entidadfederativadsc", A108entidadfederativadsc);
            n108entidadfederativadsc = T00043_n108entidadfederativadsc[0];
            A109entidadfederativausuario = T00043_A109entidadfederativausuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109entidadfederativausuario", A109entidadfederativausuario);
            n109entidadfederativausuario = T00043_n109entidadfederativausuario[0];
            A110entidadfederativafecreg = T00043_A110entidadfederativafecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110entidadfederativafecreg", context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "));
            n110entidadfederativafecreg = T00043_n110entidadfederativafecreg[0];
            A111entidadfederativafecultact = T00043_A111entidadfederativafecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111entidadfederativafecultact", context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "));
            n111entidadfederativafecultact = T00043_n111entidadfederativafecultact[0];
            Z7entidafederativaid = A7entidafederativaid;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load044( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey044( ) ;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0;
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00046_A7entidafederativaid[0] < A7entidafederativaid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00046_A7entidafederativaid[0] > A7entidafederativaid ) ) )
            {
               A7entidafederativaid = T00046_A7entidafederativaid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               n7entidafederativaid = T00046_n7entidafederativaid[0];
               RcdFound4 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00047_A7entidafederativaid[0] > A7entidafederativaid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00047_A7entidafederativaid[0] < A7entidafederativaid ) ) )
            {
               A7entidafederativaid = T00047_A7entidafederativaid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               n7entidafederativaid = T00047_n7entidafederativaid[0];
               RcdFound4 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey044( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtentidadfederativadsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert044( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A7entidafederativaid != Z7entidafederativaid )
               {
                  A7entidafederativaid = Z7entidafederativaid;
                  n7entidafederativaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ENTIDAFEDERATIVAID");
                  AnyError = 1;
                  GX_FocusControl = edtentidafederativaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtentidadfederativadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update044( ) ;
                  GX_FocusControl = edtentidadfederativadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A7entidafederativaid != Z7entidafederativaid )
               {
                  /* Insert record */
                  GX_FocusControl = edtentidadfederativadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert044( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ENTIDAFEDERATIVAID");
                     AnyError = 1;
                     GX_FocusControl = edtentidafederativaid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtentidadfederativadsc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert044( ) ;
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
         if ( A7entidafederativaid != Z7entidafederativaid )
         {
            A7entidafederativaid = Z7entidafederativaid;
            n7entidafederativaid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ENTIDAFEDERATIVAID");
            AnyError = 1;
            GX_FocusControl = edtentidafederativaid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtentidadfederativadsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {n7entidafederativaid, A7entidafederativaid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z108entidadfederativadsc, T00042_A108entidadfederativadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z109entidadfederativausuario, T00042_A109entidadfederativausuario[0]) != 0 ) || ( Z110entidadfederativafecreg != T00042_A110entidadfederativafecreg[0] ) || ( Z111entidadfederativafecultact != T00042_A111entidadfederativafecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z108entidadfederativadsc, T00042_A108entidadfederativadsc[0]) != 0 )
               {
                  GXUtil.WriteLog("entidadfederativa:[seudo value changed for attri]"+"entidadfederativadsc");
                  GXUtil.WriteLogRaw("Old: ",Z108entidadfederativadsc);
                  GXUtil.WriteLogRaw("Current: ",T00042_A108entidadfederativadsc[0]);
               }
               if ( StringUtil.StrCmp(Z109entidadfederativausuario, T00042_A109entidadfederativausuario[0]) != 0 )
               {
                  GXUtil.WriteLog("entidadfederativa:[seudo value changed for attri]"+"entidadfederativausuario");
                  GXUtil.WriteLogRaw("Old: ",Z109entidadfederativausuario);
                  GXUtil.WriteLogRaw("Current: ",T00042_A109entidadfederativausuario[0]);
               }
               if ( Z110entidadfederativafecreg != T00042_A110entidadfederativafecreg[0] )
               {
                  GXUtil.WriteLog("entidadfederativa:[seudo value changed for attri]"+"entidadfederativafecreg");
                  GXUtil.WriteLogRaw("Old: ",Z110entidadfederativafecreg);
                  GXUtil.WriteLogRaw("Current: ",T00042_A110entidadfederativafecreg[0]);
               }
               if ( Z111entidadfederativafecultact != T00042_A111entidadfederativafecultact[0] )
               {
                  GXUtil.WriteLog("entidadfederativa:[seudo value changed for attri]"+"entidadfederativafecultact");
                  GXUtil.WriteLogRaw("Old: ",Z111entidadfederativafecultact);
                  GXUtil.WriteLogRaw("Current: ",T00042_A111entidadfederativafecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00048 */
                     pr_default.execute(6, new Object[] {n7entidafederativaid, A7entidafederativaid, n108entidadfederativadsc, A108entidadfederativadsc, n109entidadfederativausuario, A109entidadfederativausuario, n110entidadfederativafecreg, A110entidadfederativafecreg, n111entidadfederativafecultact, A111entidadfederativafecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
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
                           ResetCaption040( ) ;
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
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00049 */
                     pr_default.execute(7, new Object[] {n108entidadfederativadsc, A108entidadfederativadsc, n109entidadfederativausuario, A109entidadfederativausuario, n110entidadfederativafecreg, A110entidadfederativafecreg, n111entidadfederativafecultact, A111entidadfederativafecultact, n7entidafederativaid, A7entidafederativaid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ENTIDADFEDERATIVA"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate044( ) ;
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
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000410 */
                  pr_default.execute(8, new Object[] {n7entidafederativaid, A7entidafederativaid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("ENTIDADFEDERATIVA") ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel044( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000411 */
            pr_default.execute(9, new Object[] {n7entidafederativaid, A7entidafederativaid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "entidadfederativa");
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "entidadfederativa");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart044( )
      {
         /* Scan By routine */
         /* Using cursor T000412 */
         pr_default.execute(10);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound4 = 1;
            A7entidafederativaid = T000412_A7entidafederativaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            n7entidafederativaid = T000412_n7entidafederativaid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext044( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound4 = 1;
            A7entidafederativaid = T000412_A7entidafederativaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            n7entidafederativaid = T000412_n7entidafederativaid[0];
         }
      }

      protected void ScanEnd044( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
         edtentidafederativaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidafederativaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidafederativaid_Enabled), 5, 0)));
         edtentidadfederativadsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidadfederativadsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidadfederativadsc_Enabled), 5, 0)));
         edtentidadfederativausuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidadfederativausuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidadfederativausuario_Enabled), 5, 0)));
         edtentidadfederativafecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidadfederativafecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidadfederativafecreg_Enabled), 5, 0)));
         edtentidadfederativafecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidadfederativafecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidadfederativafecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues040( )
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
         context.AddJavascriptSource("gxcfg.js", "?2022215584383");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("entidadfederativa.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7entidafederativaid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z7entidafederativaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7entidafederativaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z108entidadfederativadsc", Z108entidadfederativadsc);
         GxWebStd.gx_hidden_field( context, "Z109entidadfederativausuario", Z109entidadfederativausuario);
         GxWebStd.gx_hidden_field( context, "Z110entidadfederativafecreg", context.localUtil.TToC( Z110entidadfederativafecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z111entidadfederativafecultact", context.localUtil.TToC( Z111entidadfederativafecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vENTIDAFEDERATIVAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7entidafederativaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vENTIDAFEDERATIVAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7entidafederativaid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "entidadfederativa";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("entidadfederativa:[SendSecurityCheck value for]"+"entidafederativaid:"+context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("entidadfederativa:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("entidadfederativa.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7entidafederativaid) ;
      }

      public override String GetPgmname( )
      {
         return "entidadfederativa" ;
      }

      public override String GetPgmdesc( )
      {
         return "entidadfederativa" ;
      }

      protected void InitializeNonKey044( )
      {
         A108entidadfederativadsc = "";
         n108entidadfederativadsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108entidadfederativadsc", A108entidadfederativadsc);
         n108entidadfederativadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A108entidadfederativadsc)) ? true : false);
         A109entidadfederativausuario = "";
         n109entidadfederativausuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109entidadfederativausuario", A109entidadfederativausuario);
         n109entidadfederativausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A109entidadfederativausuario)) ? true : false);
         A110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         n110entidadfederativafecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110entidadfederativafecreg", context.localUtil.TToC( A110entidadfederativafecreg, 10, 8, 0, 3, "/", ":", " "));
         n110entidadfederativafecreg = ((DateTime.MinValue==A110entidadfederativafecreg) ? true : false);
         A111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         n111entidadfederativafecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111entidadfederativafecultact", context.localUtil.TToC( A111entidadfederativafecultact, 10, 8, 0, 3, "/", ":", " "));
         n111entidadfederativafecultact = ((DateTime.MinValue==A111entidadfederativafecultact) ? true : false);
         Z108entidadfederativadsc = "";
         Z109entidadfederativausuario = "";
         Z110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         Z111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll044( )
      {
         A7entidafederativaid = 0;
         n7entidafederativaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
         InitializeNonKey044( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?583790");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215584387");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("entidadfederativa.js", "?2022215584387");
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
         edtentidafederativaid_Internalname = "ENTIDAFEDERATIVAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtentidadfederativadsc_Internalname = "ENTIDADFEDERATIVADSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtentidadfederativausuario_Internalname = "ENTIDADFEDERATIVAUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtentidadfederativafecreg_Internalname = "ENTIDADFEDERATIVAFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtentidadfederativafecultact_Internalname = "ENTIDADFEDERATIVAFECULTACT";
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
         Form.Caption = "entidadfederativa";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtentidadfederativafecultact_Jsonclick = "";
         edtentidadfederativafecultact_Enabled = 1;
         edtentidadfederativafecreg_Jsonclick = "";
         edtentidadfederativafecreg_Enabled = 1;
         edtentidadfederativausuario_Jsonclick = "";
         edtentidadfederativausuario_Enabled = 1;
         edtentidadfederativadsc_Jsonclick = "";
         edtentidadfederativadsc_Enabled = 1;
         edtentidafederativaid_Jsonclick = "";
         edtentidafederativaid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7entidafederativaid',fld:'vENTIDAFEDERATIVAID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z108entidadfederativadsc = "";
         Z109entidadfederativausuario = "";
         Z110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         Z111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
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
         A108entidadfederativadsc = "";
         A109entidadfederativausuario = "";
         A110entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         A111entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode4 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00044_A7entidafederativaid = new int[1] ;
         T00044_n7entidafederativaid = new bool[] {false} ;
         T00044_A108entidadfederativadsc = new String[] {""} ;
         T00044_n108entidadfederativadsc = new bool[] {false} ;
         T00044_A109entidadfederativausuario = new String[] {""} ;
         T00044_n109entidadfederativausuario = new bool[] {false} ;
         T00044_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         T00044_n110entidadfederativafecreg = new bool[] {false} ;
         T00044_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         T00044_n111entidadfederativafecultact = new bool[] {false} ;
         T00045_A7entidafederativaid = new int[1] ;
         T00045_n7entidafederativaid = new bool[] {false} ;
         T00043_A7entidafederativaid = new int[1] ;
         T00043_n7entidafederativaid = new bool[] {false} ;
         T00043_A108entidadfederativadsc = new String[] {""} ;
         T00043_n108entidadfederativadsc = new bool[] {false} ;
         T00043_A109entidadfederativausuario = new String[] {""} ;
         T00043_n109entidadfederativausuario = new bool[] {false} ;
         T00043_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         T00043_n110entidadfederativafecreg = new bool[] {false} ;
         T00043_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         T00043_n111entidadfederativafecultact = new bool[] {false} ;
         T00046_A7entidafederativaid = new int[1] ;
         T00046_n7entidafederativaid = new bool[] {false} ;
         T00047_A7entidafederativaid = new int[1] ;
         T00047_n7entidafederativaid = new bool[] {false} ;
         T00042_A7entidafederativaid = new int[1] ;
         T00042_n7entidafederativaid = new bool[] {false} ;
         T00042_A108entidadfederativadsc = new String[] {""} ;
         T00042_n108entidadfederativadsc = new bool[] {false} ;
         T00042_A109entidadfederativausuario = new String[] {""} ;
         T00042_n109entidadfederativausuario = new bool[] {false} ;
         T00042_A110entidadfederativafecreg = new DateTime[] {DateTime.MinValue} ;
         T00042_n110entidadfederativafecreg = new bool[] {false} ;
         T00042_A111entidadfederativafecultact = new DateTime[] {DateTime.MinValue} ;
         T00042_n111entidadfederativafecultact = new bool[] {false} ;
         T000411_A19almacenid = new int[1] ;
         T000411_A20articulosproductoid = new int[1] ;
         T000411_A21articuloscambsid = new int[1] ;
         T000412_A7entidafederativaid = new int[1] ;
         T000412_n7entidafederativaid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.entidadfederativa__default(),
            new Object[][] {
                new Object[] {
               T00042_A7entidafederativaid, T00042_A108entidadfederativadsc, T00042_n108entidadfederativadsc, T00042_A109entidadfederativausuario, T00042_n109entidadfederativausuario, T00042_A110entidadfederativafecreg, T00042_n110entidadfederativafecreg, T00042_A111entidadfederativafecultact, T00042_n111entidadfederativafecultact
               }
               , new Object[] {
               T00043_A7entidafederativaid, T00043_A108entidadfederativadsc, T00043_n108entidadfederativadsc, T00043_A109entidadfederativausuario, T00043_n109entidadfederativausuario, T00043_A110entidadfederativafecreg, T00043_n110entidadfederativafecreg, T00043_A111entidadfederativafecultact, T00043_n111entidadfederativafecultact
               }
               , new Object[] {
               T00044_A7entidafederativaid, T00044_A108entidadfederativadsc, T00044_n108entidadfederativadsc, T00044_A109entidadfederativausuario, T00044_n109entidadfederativausuario, T00044_A110entidadfederativafecreg, T00044_n110entidadfederativafecreg, T00044_A111entidadfederativafecultact, T00044_n111entidadfederativafecultact
               }
               , new Object[] {
               T00045_A7entidafederativaid
               }
               , new Object[] {
               T00046_A7entidafederativaid
               }
               , new Object[] {
               T00047_A7entidafederativaid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000411_A19almacenid, T000411_A20articulosproductoid, T000411_A21articuloscambsid
               }
               , new Object[] {
               T000412_A7entidafederativaid
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
      private short RcdFound4 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7entidafederativaid ;
      private int Z7entidafederativaid ;
      private int AV7entidafederativaid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A7entidafederativaid ;
      private int edtentidafederativaid_Enabled ;
      private int edtentidadfederativadsc_Enabled ;
      private int edtentidadfederativausuario_Enabled ;
      private int edtentidadfederativafecreg_Enabled ;
      private int edtentidadfederativafecultact_Enabled ;
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
      private String edtentidadfederativadsc_Internalname ;
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
      private String edtentidafederativaid_Internalname ;
      private String edtentidafederativaid_Jsonclick ;
      private String edtentidadfederativadsc_Jsonclick ;
      private String edtentidadfederativausuario_Internalname ;
      private String edtentidadfederativausuario_Jsonclick ;
      private String edtentidadfederativafecreg_Internalname ;
      private String edtentidadfederativafecreg_Jsonclick ;
      private String edtentidadfederativafecultact_Internalname ;
      private String edtentidadfederativafecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode4 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z110entidadfederativafecreg ;
      private DateTime Z111entidadfederativafecultact ;
      private DateTime A110entidadfederativafecreg ;
      private DateTime A111entidadfederativafecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n7entidafederativaid ;
      private bool n108entidadfederativadsc ;
      private bool n109entidadfederativausuario ;
      private bool n110entidadfederativafecreg ;
      private bool n111entidadfederativafecultact ;
      private String Z108entidadfederativadsc ;
      private String Z109entidadfederativausuario ;
      private String A108entidadfederativadsc ;
      private String A109entidadfederativausuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00044_A7entidafederativaid ;
      private bool[] T00044_n7entidafederativaid ;
      private String[] T00044_A108entidadfederativadsc ;
      private bool[] T00044_n108entidadfederativadsc ;
      private String[] T00044_A109entidadfederativausuario ;
      private bool[] T00044_n109entidadfederativausuario ;
      private DateTime[] T00044_A110entidadfederativafecreg ;
      private bool[] T00044_n110entidadfederativafecreg ;
      private DateTime[] T00044_A111entidadfederativafecultact ;
      private bool[] T00044_n111entidadfederativafecultact ;
      private int[] T00045_A7entidafederativaid ;
      private bool[] T00045_n7entidafederativaid ;
      private int[] T00043_A7entidafederativaid ;
      private bool[] T00043_n7entidafederativaid ;
      private String[] T00043_A108entidadfederativadsc ;
      private bool[] T00043_n108entidadfederativadsc ;
      private String[] T00043_A109entidadfederativausuario ;
      private bool[] T00043_n109entidadfederativausuario ;
      private DateTime[] T00043_A110entidadfederativafecreg ;
      private bool[] T00043_n110entidadfederativafecreg ;
      private DateTime[] T00043_A111entidadfederativafecultact ;
      private bool[] T00043_n111entidadfederativafecultact ;
      private int[] T00046_A7entidafederativaid ;
      private bool[] T00046_n7entidafederativaid ;
      private int[] T00047_A7entidafederativaid ;
      private bool[] T00047_n7entidafederativaid ;
      private int[] T00042_A7entidafederativaid ;
      private bool[] T00042_n7entidafederativaid ;
      private String[] T00042_A108entidadfederativadsc ;
      private bool[] T00042_n108entidadfederativadsc ;
      private String[] T00042_A109entidadfederativausuario ;
      private bool[] T00042_n109entidadfederativausuario ;
      private DateTime[] T00042_A110entidadfederativafecreg ;
      private bool[] T00042_n110entidadfederativafecreg ;
      private DateTime[] T00042_A111entidadfederativafecultact ;
      private bool[] T00042_n111entidadfederativafecultact ;
      private int[] T000411_A19almacenid ;
      private int[] T000411_A20articulosproductoid ;
      private int[] T000411_A21articuloscambsid ;
      private int[] T000412_A7entidafederativaid ;
      private bool[] T000412_n7entidafederativaid ;
      private GXWebForm Form ;
   }

   public class entidadfederativa__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"entidadfederativadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"entidadfederativausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"entidadfederativafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidadfederativafecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"entidadfederativadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"entidadfederativausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"entidadfederativafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidadfederativafecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid  FOR UPDATE OF entidadfederativa NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT TM1.entidafederativaid, TM1.entidadfederativadsc, TM1.entidadfederativausuario, TM1.entidadfederativafecreg, TM1.entidadfederativafecultact FROM public.entidadfederativa TM1 WHERE TM1.entidafederativaid = :entidafederativaid ORDER BY TM1.entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,100,0,true,false )
             ,new CursorDef("T00045", "SELECT entidafederativaid FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT entidafederativaid FROM public.entidadfederativa WHERE ( entidafederativaid > :entidafederativaid) ORDER BY entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,true )
             ,new CursorDef("T00047", "SELECT entidafederativaid FROM public.entidadfederativa WHERE ( entidafederativaid < :entidafederativaid) ORDER BY entidafederativaid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,true )
             ,new CursorDef("T00048", "SAVEPOINT gxupdate;INSERT INTO public.entidadfederativa(entidafederativaid, entidadfederativadsc, entidadfederativausuario, entidadfederativafecreg, entidadfederativafecultact) VALUES(:entidafederativaid, :entidadfederativadsc, :entidadfederativausuario, :entidadfederativafecreg, :entidadfederativafecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00048)
             ,new CursorDef("T00049", "SAVEPOINT gxupdate;UPDATE public.entidadfederativa SET entidadfederativadsc=:entidadfederativadsc, entidadfederativausuario=:entidadfederativausuario, entidadfederativafecreg=:entidadfederativafecreg, entidadfederativafecultact=:entidadfederativafecultact  WHERE entidafederativaid = :entidafederativaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00049)
             ,new CursorDef("T000410", "SAVEPOINT gxupdate;DELETE FROM public.entidadfederativa  WHERE entidafederativaid = :entidafederativaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000410)
             ,new CursorDef("T000411", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE entidadid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1,0,true,true )
             ,new CursorDef("T000412", "SELECT entidafederativaid FROM public.entidadfederativa ORDER BY entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,100,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 10 :
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
       }
    }

 }

}
