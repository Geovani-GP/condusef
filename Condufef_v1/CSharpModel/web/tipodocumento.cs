/*
               File: tipodocumento
        Description: tipodocumento
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/25/2022 17:34:55.68
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
   public class tipodocumento : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "tipodocumento", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edttipodocumentoid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tipodocumento( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public tipodocumento( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "tipodocumento", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPODOCUMENTOID"+"'), id:'"+"TIPODOCUMENTOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_label_element( context, edttipodocumentoid_Internalname, "tipodocumentoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipodocumentoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A26tipodocumentoid), 9, 0, ",", "")), ((edttipodocumentoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A26tipodocumentoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A26tipodocumentoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipodocumentoid_Jsonclick, 0, "Attribute", "", "", "", 1, edttipodocumentoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_label_element( context, edttipodocumentodsc_Internalname, "tipodocumentodsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipodocumentodsc_Internalname, A79tipodocumentodsc, StringUtil.RTrim( context.localUtil.Format( A79tipodocumentodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipodocumentodsc_Jsonclick, 0, "Attribute", "", "", "", 1, edttipodocumentodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_label_element( context, edttipodocumentousuario_Internalname, "tipodocumentousuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipodocumentousuario_Internalname, A80tipodocumentousuario, StringUtil.RTrim( context.localUtil.Format( A80tipodocumentousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipodocumentousuario_Jsonclick, 0, "Attribute", "", "", "", 1, edttipodocumentousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_label_element( context, edttipodocumentofecreg_Internalname, "tipodocumentofecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edttipodocumentofecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edttipodocumentofecreg_Internalname, context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A81tipodocumentofecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipodocumentofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edttipodocumentofecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipodocumento.htm");
            GxWebStd.gx_bitmap( context, edttipodocumentofecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edttipodocumentofecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_label_element( context, edttipodocumentofecultact_Internalname, "tipodocumentofecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edttipodocumentofecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edttipodocumentofecultact_Internalname, context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A82tipodocumentofecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipodocumentofecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edttipodocumentofecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipodocumento.htm");
            GxWebStd.gx_bitmap( context, edttipodocumentofecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edttipodocumentofecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_tipodocumento.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipodocumento.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edttipodocumentoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edttipodocumentoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPODOCUMENTOID");
                  AnyError = 1;
                  GX_FocusControl = edttipodocumentoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A26tipodocumentoid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
               }
               else
               {
                  A26tipodocumentoid = (int)(context.localUtil.CToN( cgiGet( edttipodocumentoid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
               }
               A79tipodocumentodsc = cgiGet( edttipodocumentodsc_Internalname);
               n79tipodocumentodsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79tipodocumentodsc", A79tipodocumentodsc);
               n79tipodocumentodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A79tipodocumentodsc)) ? true : false);
               A80tipodocumentousuario = cgiGet( edttipodocumentousuario_Internalname);
               n80tipodocumentousuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80tipodocumentousuario", A80tipodocumentousuario);
               n80tipodocumentousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A80tipodocumentousuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edttipodocumentofecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"tipodocumentofecreg"}), 1, "TIPODOCUMENTOFECREG");
                  AnyError = 1;
                  GX_FocusControl = edttipodocumentofecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
                  n81tipodocumentofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81tipodocumentofecreg", context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A81tipodocumentofecreg = context.localUtil.CToT( cgiGet( edttipodocumentofecreg_Internalname));
                  n81tipodocumentofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81tipodocumentofecreg", context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n81tipodocumentofecreg = ((DateTime.MinValue==A81tipodocumentofecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edttipodocumentofecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"tipodocumentofecultact"}), 1, "TIPODOCUMENTOFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edttipodocumentofecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
                  n82tipodocumentofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82tipodocumentofecultact", context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A82tipodocumentofecultact = context.localUtil.CToT( cgiGet( edttipodocumentofecultact_Internalname));
                  n82tipodocumentofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82tipodocumentofecultact", context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n82tipodocumentofecultact = ((DateTime.MinValue==A82tipodocumentofecultact) ? true : false);
               /* Read saved values. */
               Z26tipodocumentoid = (int)(context.localUtil.CToN( cgiGet( "Z26tipodocumentoid"), ",", "."));
               Z79tipodocumentodsc = cgiGet( "Z79tipodocumentodsc");
               n79tipodocumentodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A79tipodocumentodsc)) ? true : false);
               Z80tipodocumentousuario = cgiGet( "Z80tipodocumentousuario");
               n80tipodocumentousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A80tipodocumentousuario)) ? true : false);
               Z81tipodocumentofecreg = context.localUtil.CToT( cgiGet( "Z81tipodocumentofecreg"), 0);
               n81tipodocumentofecreg = ((DateTime.MinValue==A81tipodocumentofecreg) ? true : false);
               Z82tipodocumentofecultact = context.localUtil.CToT( cgiGet( "Z82tipodocumentofecultact"), 0);
               n82tipodocumentofecultact = ((DateTime.MinValue==A82tipodocumentofecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A26tipodocumentoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
               InitAll0K20( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes0K20( ) ;
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

      protected void ResetCaption0K0( )
      {
      }

      protected void ZM0K20( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z79tipodocumentodsc = T000K3_A79tipodocumentodsc[0];
               Z80tipodocumentousuario = T000K3_A80tipodocumentousuario[0];
               Z81tipodocumentofecreg = T000K3_A81tipodocumentofecreg[0];
               Z82tipodocumentofecultact = T000K3_A82tipodocumentofecultact[0];
            }
            else
            {
               Z79tipodocumentodsc = A79tipodocumentodsc;
               Z80tipodocumentousuario = A80tipodocumentousuario;
               Z81tipodocumentofecreg = A81tipodocumentofecreg;
               Z82tipodocumentofecultact = A82tipodocumentofecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z26tipodocumentoid = A26tipodocumentoid;
            Z79tipodocumentodsc = A79tipodocumentodsc;
            Z80tipodocumentousuario = A80tipodocumentousuario;
            Z81tipodocumentofecreg = A81tipodocumentofecreg;
            Z82tipodocumentofecultact = A82tipodocumentofecultact;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
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

      protected void Load0K20( )
      {
         /* Using cursor T000K4 */
         pr_default.execute(2, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound20 = 1;
            A79tipodocumentodsc = T000K4_A79tipodocumentodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79tipodocumentodsc", A79tipodocumentodsc);
            n79tipodocumentodsc = T000K4_n79tipodocumentodsc[0];
            A80tipodocumentousuario = T000K4_A80tipodocumentousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80tipodocumentousuario", A80tipodocumentousuario);
            n80tipodocumentousuario = T000K4_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = T000K4_A81tipodocumentofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81tipodocumentofecreg", context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
            n81tipodocumentofecreg = T000K4_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = T000K4_A82tipodocumentofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82tipodocumentofecultact", context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
            n82tipodocumentofecultact = T000K4_n82tipodocumentofecultact[0];
            ZM0K20( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0K20( ) ;
      }

      protected void OnLoadActions0K20( )
      {
      }

      protected void CheckExtendedTable0K20( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0K20( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0K20( )
      {
         /* Using cursor T000K5 */
         pr_default.execute(3, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound20 = 1;
         }
         else
         {
            RcdFound20 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000K3 */
         pr_default.execute(1, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0K20( 1) ;
            RcdFound20 = 1;
            A26tipodocumentoid = T000K3_A26tipodocumentoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
            A79tipodocumentodsc = T000K3_A79tipodocumentodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79tipodocumentodsc", A79tipodocumentodsc);
            n79tipodocumentodsc = T000K3_n79tipodocumentodsc[0];
            A80tipodocumentousuario = T000K3_A80tipodocumentousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80tipodocumentousuario", A80tipodocumentousuario);
            n80tipodocumentousuario = T000K3_n80tipodocumentousuario[0];
            A81tipodocumentofecreg = T000K3_A81tipodocumentofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81tipodocumentofecreg", context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
            n81tipodocumentofecreg = T000K3_n81tipodocumentofecreg[0];
            A82tipodocumentofecultact = T000K3_A82tipodocumentofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82tipodocumentofecultact", context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
            n82tipodocumentofecultact = T000K3_n82tipodocumentofecultact[0];
            Z26tipodocumentoid = A26tipodocumentoid;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0K20( ) ;
            if ( AnyError == 1 )
            {
               RcdFound20 = 0;
               InitializeNonKey0K20( ) ;
            }
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound20 = 0;
            InitializeNonKey0K20( ) ;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0K20( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound20 = 0;
         /* Using cursor T000K6 */
         pr_default.execute(4, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000K6_A26tipodocumentoid[0] < A26tipodocumentoid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000K6_A26tipodocumentoid[0] > A26tipodocumentoid ) ) )
            {
               A26tipodocumentoid = T000K6_A26tipodocumentoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound20 = 0;
         /* Using cursor T000K7 */
         pr_default.execute(5, new Object[] {A26tipodocumentoid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000K7_A26tipodocumentoid[0] > A26tipodocumentoid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000K7_A26tipodocumentoid[0] < A26tipodocumentoid ) ) )
            {
               A26tipodocumentoid = T000K7_A26tipodocumentoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0K20( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edttipodocumentoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0K20( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound20 == 1 )
            {
               if ( A26tipodocumentoid != Z26tipodocumentoid )
               {
                  A26tipodocumentoid = Z26tipodocumentoid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "TIPODOCUMENTOID");
                  AnyError = 1;
                  GX_FocusControl = edttipodocumentoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edttipodocumentoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0K20( ) ;
                  GX_FocusControl = edttipodocumentoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A26tipodocumentoid != Z26tipodocumentoid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edttipodocumentoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0K20( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "TIPODOCUMENTOID");
                     AnyError = 1;
                     GX_FocusControl = edttipodocumentoid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edttipodocumentoid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0K20( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A26tipodocumentoid != Z26tipodocumentoid )
         {
            A26tipodocumentoid = Z26tipodocumentoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "TIPODOCUMENTOID");
            AnyError = 1;
            GX_FocusControl = edttipodocumentoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edttipodocumentoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "TIPODOCUMENTOID");
            AnyError = 1;
            GX_FocusControl = edttipodocumentoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0K20( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0K20( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0K20( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound20 != 0 )
            {
               ScanNext0K20( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0K20( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0K20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000K2 */
            pr_default.execute(0, new Object[] {A26tipodocumentoid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPODOCUMENTO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z79tipodocumentodsc, T000K2_A79tipodocumentodsc[0]) != 0 ) || ( StringUtil.StrCmp(Z80tipodocumentousuario, T000K2_A80tipodocumentousuario[0]) != 0 ) || ( Z81tipodocumentofecreg != T000K2_A81tipodocumentofecreg[0] ) || ( Z82tipodocumentofecultact != T000K2_A82tipodocumentofecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z79tipodocumentodsc, T000K2_A79tipodocumentodsc[0]) != 0 )
               {
                  GXUtil.WriteLog("tipodocumento:[seudo value changed for attri]"+"tipodocumentodsc");
                  GXUtil.WriteLogRaw("Old: ",Z79tipodocumentodsc);
                  GXUtil.WriteLogRaw("Current: ",T000K2_A79tipodocumentodsc[0]);
               }
               if ( StringUtil.StrCmp(Z80tipodocumentousuario, T000K2_A80tipodocumentousuario[0]) != 0 )
               {
                  GXUtil.WriteLog("tipodocumento:[seudo value changed for attri]"+"tipodocumentousuario");
                  GXUtil.WriteLogRaw("Old: ",Z80tipodocumentousuario);
                  GXUtil.WriteLogRaw("Current: ",T000K2_A80tipodocumentousuario[0]);
               }
               if ( Z81tipodocumentofecreg != T000K2_A81tipodocumentofecreg[0] )
               {
                  GXUtil.WriteLog("tipodocumento:[seudo value changed for attri]"+"tipodocumentofecreg");
                  GXUtil.WriteLogRaw("Old: ",Z81tipodocumentofecreg);
                  GXUtil.WriteLogRaw("Current: ",T000K2_A81tipodocumentofecreg[0]);
               }
               if ( Z82tipodocumentofecultact != T000K2_A82tipodocumentofecultact[0] )
               {
                  GXUtil.WriteLog("tipodocumento:[seudo value changed for attri]"+"tipodocumentofecultact");
                  GXUtil.WriteLogRaw("Old: ",Z82tipodocumentofecultact);
                  GXUtil.WriteLogRaw("Current: ",T000K2_A82tipodocumentofecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TIPODOCUMENTO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0K20( )
      {
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0K20( 0) ;
            CheckOptimisticConcurrency0K20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0K20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K8 */
                     pr_default.execute(6, new Object[] {A26tipodocumentoid, n79tipodocumentodsc, A79tipodocumentodsc, n80tipodocumentousuario, A80tipodocumentousuario, n81tipodocumentofecreg, A81tipodocumentofecreg, n82tipodocumentofecultact, A82tipodocumentofecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
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
                           ResetCaption0K0( ) ;
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
               Load0K20( ) ;
            }
            EndLevel0K20( ) ;
         }
         CloseExtendedTableCursors0K20( ) ;
      }

      protected void Update0K20( )
      {
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0K20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K9 */
                     pr_default.execute(7, new Object[] {n79tipodocumentodsc, A79tipodocumentodsc, n80tipodocumentousuario, A80tipodocumentousuario, n81tipodocumentofecreg, A81tipodocumentofecreg, n82tipodocumentofecultact, A82tipodocumentofecultact, A26tipodocumentoid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPODOCUMENTO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0K20( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0K0( ) ;
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
            EndLevel0K20( ) ;
         }
         CloseExtendedTableCursors0K20( ) ;
      }

      protected void DeferredUpdate0K20( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0K20( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0K20( ) ;
            AfterConfirm0K20( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0K20( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000K10 */
                  pr_default.execute(8, new Object[] {A26tipodocumentoid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("TIPODOCUMENTO") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound20 == 0 )
                        {
                           InitAll0K20( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "", true);
                        ResetCaption0K0( ) ;
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
         sMode20 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0K20( ) ;
         Gx_mode = sMode20;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0K20( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0K20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0K20( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "tipodocumento");
            if ( AnyError == 0 )
            {
               ConfirmValues0K0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "tipodocumento");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0K20( )
      {
         /* Using cursor T000K11 */
         pr_default.execute(9);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound20 = 1;
            A26tipodocumentoid = T000K11_A26tipodocumentoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0K20( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound20 = 1;
            A26tipodocumentoid = T000K11_A26tipodocumentoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
         }
      }

      protected void ScanEnd0K20( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0K20( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0K20( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0K20( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0K20( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0K20( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0K20( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0K20( )
      {
         edttipodocumentoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipodocumentoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipodocumentoid_Enabled), 5, 0)));
         edttipodocumentodsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipodocumentodsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipodocumentodsc_Enabled), 5, 0)));
         edttipodocumentousuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipodocumentousuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipodocumentousuario_Enabled), 5, 0)));
         edttipodocumentofecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipodocumentofecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipodocumentofecreg_Enabled), 5, 0)));
         edttipodocumentofecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipodocumentofecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipodocumentofecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0K0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202212517345663");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("tipodocumento.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z26tipodocumentoid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26tipodocumentoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z79tipodocumentodsc", Z79tipodocumentodsc);
         GxWebStd.gx_hidden_field( context, "Z80tipodocumentousuario", Z80tipodocumentousuario);
         GxWebStd.gx_hidden_field( context, "Z81tipodocumentofecreg", context.localUtil.TToC( Z81tipodocumentofecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z82tipodocumentofecultact", context.localUtil.TToC( Z82tipodocumentofecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
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
         return formatLink("tipodocumento.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "tipodocumento" ;
      }

      public override String GetPgmdesc( )
      {
         return "tipodocumento" ;
      }

      protected void InitializeNonKey0K20( )
      {
         A79tipodocumentodsc = "";
         n79tipodocumentodsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79tipodocumentodsc", A79tipodocumentodsc);
         n79tipodocumentodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A79tipodocumentodsc)) ? true : false);
         A80tipodocumentousuario = "";
         n80tipodocumentousuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A80tipodocumentousuario", A80tipodocumentousuario);
         n80tipodocumentousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A80tipodocumentousuario)) ? true : false);
         A81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         n81tipodocumentofecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A81tipodocumentofecreg", context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
         n81tipodocumentofecreg = ((DateTime.MinValue==A81tipodocumentofecreg) ? true : false);
         A82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         n82tipodocumentofecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82tipodocumentofecultact", context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
         n82tipodocumentofecultact = ((DateTime.MinValue==A82tipodocumentofecultact) ? true : false);
         Z79tipodocumentodsc = "";
         Z80tipodocumentousuario = "";
         Z81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         Z82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0K20( )
      {
         A26tipodocumentoid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26tipodocumentoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A26tipodocumentoid), 9, 0)));
         InitializeNonKey0K20( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1734189");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202212517345672");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("tipodocumento.js", "?202212517345672");
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
         edttipodocumentoid_Internalname = "TIPODOCUMENTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipodocumentodsc_Internalname = "TIPODOCUMENTODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipodocumentousuario_Internalname = "TIPODOCUMENTOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipodocumentofecreg_Internalname = "TIPODOCUMENTOFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipodocumentofecultact_Internalname = "TIPODOCUMENTOFECULTACT";
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
         Form.Caption = "tipodocumento";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edttipodocumentofecultact_Jsonclick = "";
         edttipodocumentofecultact_Enabled = 1;
         edttipodocumentofecreg_Jsonclick = "";
         edttipodocumentofecreg_Enabled = 1;
         edttipodocumentousuario_Jsonclick = "";
         edttipodocumentousuario_Enabled = 1;
         edttipodocumentodsc_Jsonclick = "";
         edttipodocumentodsc_Enabled = 1;
         edttipodocumentoid_Jsonclick = "";
         edttipodocumentoid_Enabled = 1;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edttipodocumentodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Tipodocumentoid( int GX_Parm1 ,
                                         String GX_Parm2 ,
                                         String GX_Parm3 ,
                                         DateTime GX_Parm4 ,
                                         DateTime GX_Parm5 )
      {
         A26tipodocumentoid = GX_Parm1;
         A79tipodocumentodsc = GX_Parm2;
         n79tipodocumentodsc = false;
         A80tipodocumentousuario = GX_Parm3;
         n80tipodocumentousuario = false;
         A81tipodocumentofecreg = GX_Parm4;
         n81tipodocumentofecreg = false;
         A82tipodocumentofecultact = GX_Parm5;
         n82tipodocumentofecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A79tipodocumentodsc);
         isValidOutput.Add(A80tipodocumentousuario);
         isValidOutput.Add(context.localUtil.TToC( A81tipodocumentofecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A82tipodocumentofecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26tipodocumentoid), 9, 0, ",", "")));
         isValidOutput.Add(Z79tipodocumentodsc);
         isValidOutput.Add(Z80tipodocumentousuario);
         isValidOutput.Add(context.localUtil.TToC( Z81tipodocumentofecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z82tipodocumentofecultact, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}],oparms:[]}");
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
         Z79tipodocumentodsc = "";
         Z80tipodocumentousuario = "";
         Z81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         Z82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
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
         A79tipodocumentodsc = "";
         A80tipodocumentousuario = "";
         A81tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         A82tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000K4_A26tipodocumentoid = new int[1] ;
         T000K4_A79tipodocumentodsc = new String[] {""} ;
         T000K4_n79tipodocumentodsc = new bool[] {false} ;
         T000K4_A80tipodocumentousuario = new String[] {""} ;
         T000K4_n80tipodocumentousuario = new bool[] {false} ;
         T000K4_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         T000K4_n81tipodocumentofecreg = new bool[] {false} ;
         T000K4_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         T000K4_n82tipodocumentofecultact = new bool[] {false} ;
         T000K5_A26tipodocumentoid = new int[1] ;
         T000K3_A26tipodocumentoid = new int[1] ;
         T000K3_A79tipodocumentodsc = new String[] {""} ;
         T000K3_n79tipodocumentodsc = new bool[] {false} ;
         T000K3_A80tipodocumentousuario = new String[] {""} ;
         T000K3_n80tipodocumentousuario = new bool[] {false} ;
         T000K3_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         T000K3_n81tipodocumentofecreg = new bool[] {false} ;
         T000K3_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         T000K3_n82tipodocumentofecultact = new bool[] {false} ;
         sMode20 = "";
         T000K6_A26tipodocumentoid = new int[1] ;
         T000K7_A26tipodocumentoid = new int[1] ;
         T000K2_A26tipodocumentoid = new int[1] ;
         T000K2_A79tipodocumentodsc = new String[] {""} ;
         T000K2_n79tipodocumentodsc = new bool[] {false} ;
         T000K2_A80tipodocumentousuario = new String[] {""} ;
         T000K2_n80tipodocumentousuario = new bool[] {false} ;
         T000K2_A81tipodocumentofecreg = new DateTime[] {DateTime.MinValue} ;
         T000K2_n81tipodocumentofecreg = new bool[] {false} ;
         T000K2_A82tipodocumentofecultact = new DateTime[] {DateTime.MinValue} ;
         T000K2_n82tipodocumentofecultact = new bool[] {false} ;
         T000K11_A26tipodocumentoid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipodocumento__default(),
            new Object[][] {
                new Object[] {
               T000K2_A26tipodocumentoid, T000K2_A79tipodocumentodsc, T000K2_n79tipodocumentodsc, T000K2_A80tipodocumentousuario, T000K2_n80tipodocumentousuario, T000K2_A81tipodocumentofecreg, T000K2_n81tipodocumentofecreg, T000K2_A82tipodocumentofecultact, T000K2_n82tipodocumentofecultact
               }
               , new Object[] {
               T000K3_A26tipodocumentoid, T000K3_A79tipodocumentodsc, T000K3_n79tipodocumentodsc, T000K3_A80tipodocumentousuario, T000K3_n80tipodocumentousuario, T000K3_A81tipodocumentofecreg, T000K3_n81tipodocumentofecreg, T000K3_A82tipodocumentofecultact, T000K3_n82tipodocumentofecultact
               }
               , new Object[] {
               T000K4_A26tipodocumentoid, T000K4_A79tipodocumentodsc, T000K4_n79tipodocumentodsc, T000K4_A80tipodocumentousuario, T000K4_n80tipodocumentousuario, T000K4_A81tipodocumentofecreg, T000K4_n81tipodocumentofecreg, T000K4_A82tipodocumentofecultact, T000K4_n82tipodocumentofecultact
               }
               , new Object[] {
               T000K5_A26tipodocumentoid
               }
               , new Object[] {
               T000K6_A26tipodocumentoid
               }
               , new Object[] {
               T000K7_A26tipodocumentoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000K11_A26tipodocumentoid
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
      private short GX_JID ;
      private short RcdFound20 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z26tipodocumentoid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A26tipodocumentoid ;
      private int edttipodocumentoid_Enabled ;
      private int edttipodocumentodsc_Enabled ;
      private int edttipodocumentousuario_Enabled ;
      private int edttipodocumentofecreg_Enabled ;
      private int edttipodocumentofecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edttipodocumentoid_Internalname ;
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
      private String edttipodocumentoid_Jsonclick ;
      private String edttipodocumentodsc_Internalname ;
      private String edttipodocumentodsc_Jsonclick ;
      private String edttipodocumentousuario_Internalname ;
      private String edttipodocumentousuario_Jsonclick ;
      private String edttipodocumentofecreg_Internalname ;
      private String edttipodocumentofecreg_Jsonclick ;
      private String edttipodocumentofecultact_Internalname ;
      private String edttipodocumentofecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode20 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z81tipodocumentofecreg ;
      private DateTime Z82tipodocumentofecultact ;
      private DateTime A81tipodocumentofecreg ;
      private DateTime A82tipodocumentofecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n79tipodocumentodsc ;
      private bool n80tipodocumentousuario ;
      private bool n81tipodocumentofecreg ;
      private bool n82tipodocumentofecultact ;
      private String Z79tipodocumentodsc ;
      private String Z80tipodocumentousuario ;
      private String A79tipodocumentodsc ;
      private String A80tipodocumentousuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000K4_A26tipodocumentoid ;
      private String[] T000K4_A79tipodocumentodsc ;
      private bool[] T000K4_n79tipodocumentodsc ;
      private String[] T000K4_A80tipodocumentousuario ;
      private bool[] T000K4_n80tipodocumentousuario ;
      private DateTime[] T000K4_A81tipodocumentofecreg ;
      private bool[] T000K4_n81tipodocumentofecreg ;
      private DateTime[] T000K4_A82tipodocumentofecultact ;
      private bool[] T000K4_n82tipodocumentofecultact ;
      private int[] T000K5_A26tipodocumentoid ;
      private int[] T000K3_A26tipodocumentoid ;
      private String[] T000K3_A79tipodocumentodsc ;
      private bool[] T000K3_n79tipodocumentodsc ;
      private String[] T000K3_A80tipodocumentousuario ;
      private bool[] T000K3_n80tipodocumentousuario ;
      private DateTime[] T000K3_A81tipodocumentofecreg ;
      private bool[] T000K3_n81tipodocumentofecreg ;
      private DateTime[] T000K3_A82tipodocumentofecultact ;
      private bool[] T000K3_n82tipodocumentofecultact ;
      private int[] T000K6_A26tipodocumentoid ;
      private int[] T000K7_A26tipodocumentoid ;
      private int[] T000K2_A26tipodocumentoid ;
      private String[] T000K2_A79tipodocumentodsc ;
      private bool[] T000K2_n79tipodocumentodsc ;
      private String[] T000K2_A80tipodocumentousuario ;
      private bool[] T000K2_n80tipodocumentousuario ;
      private DateTime[] T000K2_A81tipodocumentofecreg ;
      private bool[] T000K2_n81tipodocumentofecreg ;
      private DateTime[] T000K2_A82tipodocumentofecultact ;
      private bool[] T000K2_n82tipodocumentofecultact ;
      private int[] T000K11_A26tipodocumentoid ;
      private GXWebForm Form ;
   }

   public class tipodocumento__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000K4 ;
          prmT000K4 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K5 ;
          prmT000K5 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K3 ;
          prmT000K3 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K6 ;
          prmT000K6 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K7 ;
          prmT000K7 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K2 ;
          prmT000K2 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K8 ;
          prmT000K8 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipodocumentodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipodocumentousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipodocumentofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentofecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000K9 ;
          prmT000K9 = new Object[] {
          new Object[] {"tipodocumentodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipodocumentousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipodocumentofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K10 ;
          prmT000K10 = new Object[] {
          new Object[] {"tipodocumentoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000K11 ;
          prmT000K11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000K2", "SELECT tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid  FOR UPDATE OF tipodocumento NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000K2,1,0,true,false )
             ,new CursorDef("T000K3", "SELECT tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K3,1,0,true,false )
             ,new CursorDef("T000K4", "SELECT TM1.tipodocumentoid, TM1.tipodocumentodsc, TM1.tipodocumentousuario, TM1.tipodocumentofecreg, TM1.tipodocumentofecultact FROM public.tipodocumento TM1 WHERE TM1.tipodocumentoid = :tipodocumentoid ORDER BY TM1.tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K4,100,0,true,false )
             ,new CursorDef("T000K5", "SELECT tipodocumentoid FROM public.tipodocumento WHERE tipodocumentoid = :tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K5,1,0,true,false )
             ,new CursorDef("T000K6", "SELECT tipodocumentoid FROM public.tipodocumento WHERE ( tipodocumentoid > :tipodocumentoid) ORDER BY tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K6,1,0,true,true )
             ,new CursorDef("T000K7", "SELECT tipodocumentoid FROM public.tipodocumento WHERE ( tipodocumentoid < :tipodocumentoid) ORDER BY tipodocumentoid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K7,1,0,true,true )
             ,new CursorDef("T000K8", "SAVEPOINT gxupdate;INSERT INTO public.tipodocumento(tipodocumentoid, tipodocumentodsc, tipodocumentousuario, tipodocumentofecreg, tipodocumentofecultact) VALUES(:tipodocumentoid, :tipodocumentodsc, :tipodocumentousuario, :tipodocumentofecreg, :tipodocumentofecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000K8)
             ,new CursorDef("T000K9", "SAVEPOINT gxupdate;UPDATE public.tipodocumento SET tipodocumentodsc=:tipodocumentodsc, tipodocumentousuario=:tipodocumentousuario, tipodocumentofecreg=:tipodocumentofecreg, tipodocumentofecultact=:tipodocumentofecultact  WHERE tipodocumentoid = :tipodocumentoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000K9)
             ,new CursorDef("T000K10", "SAVEPOINT gxupdate;DELETE FROM public.tipodocumento  WHERE tipodocumentoid = :tipodocumentoid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000K10)
             ,new CursorDef("T000K11", "SELECT tipodocumentoid FROM public.tipodocumento ORDER BY tipodocumentoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K11,100,0,true,false )
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[8]);
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
                stmt.SetParameter(5, (int)parms[8]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
