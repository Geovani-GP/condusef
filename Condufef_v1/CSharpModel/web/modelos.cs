/*
               File: modelos
        Description: modelos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/25/2022 17:34:52.78
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
   public class modelos : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "modelos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtmodelosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public modelos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public modelos( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "modelos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_modelos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MODELOSID"+"'), id:'"+"MODELOSID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_modelos.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosid_Internalname, "productoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmodelosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ",", "")), ((edtmodelosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosid_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_modelos.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosdsc_Internalname, "modelosdsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmodelosdsc_Internalname, A116modelosdsc, StringUtil.RTrim( context.localUtil.Format( A116modelosdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosdsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_modelos.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosusuario_Internalname, "modelosusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmodelosusuario_Internalname, A117modelosusuario, StringUtil.RTrim( context.localUtil.Format( A117modelosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_modelos.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosfecreg_Internalname, "modelosfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtmodelosfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtmodelosfecreg_Internalname, context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A118modelosfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_modelos.htm");
            GxWebStd.gx_bitmap( context, edtmodelosfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtmodelosfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_modelos.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosfecultact_Internalname, "modelosfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtmodelosfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtmodelosfecultact_Internalname, context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A119modelosfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_modelos.htm");
            GxWebStd.gx_bitmap( context, edtmodelosfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtmodelosfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_modelos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_modelos.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtmodelosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtmodelosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MODELOSID");
                  AnyError = 1;
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A15modelosid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               }
               else
               {
                  A15modelosid = (int)(context.localUtil.CToN( cgiGet( edtmodelosid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               }
               A116modelosdsc = cgiGet( edtmodelosdsc_Internalname);
               n116modelosdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116modelosdsc", A116modelosdsc);
               n116modelosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A116modelosdsc)) ? true : false);
               A117modelosusuario = cgiGet( edtmodelosusuario_Internalname);
               n117modelosusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117modelosusuario", A117modelosusuario);
               n117modelosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A117modelosusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtmodelosfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"modelosfecreg"}), 1, "MODELOSFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtmodelosfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A118modelosfecreg = (DateTime)(DateTime.MinValue);
                  n118modelosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118modelosfecreg", context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A118modelosfecreg = context.localUtil.CToT( cgiGet( edtmodelosfecreg_Internalname));
                  n118modelosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118modelosfecreg", context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n118modelosfecreg = ((DateTime.MinValue==A118modelosfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtmodelosfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"modelosfecultact"}), 1, "MODELOSFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtmodelosfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A119modelosfecultact = (DateTime)(DateTime.MinValue);
                  n119modelosfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119modelosfecultact", context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A119modelosfecultact = context.localUtil.CToT( cgiGet( edtmodelosfecultact_Internalname));
                  n119modelosfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119modelosfecultact", context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n119modelosfecultact = ((DateTime.MinValue==A119modelosfecultact) ? true : false);
               /* Read saved values. */
               Z15modelosid = (int)(context.localUtil.CToN( cgiGet( "Z15modelosid"), ",", "."));
               Z116modelosdsc = cgiGet( "Z116modelosdsc");
               n116modelosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A116modelosdsc)) ? true : false);
               Z117modelosusuario = cgiGet( "Z117modelosusuario");
               n117modelosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A117modelosusuario)) ? true : false);
               Z118modelosfecreg = context.localUtil.CToT( cgiGet( "Z118modelosfecreg"), 0);
               n118modelosfecreg = ((DateTime.MinValue==A118modelosfecreg) ? true : false);
               Z119modelosfecultact = context.localUtil.CToT( cgiGet( "Z119modelosfecultact"), 0);
               n119modelosfecultact = ((DateTime.MinValue==A119modelosfecultact) ? true : false);
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
                  A15modelosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
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
               InitAll0J19( ) ;
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
         DisableAttributes0J19( ) ;
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

      protected void ResetCaption0J0( )
      {
      }

      protected void ZM0J19( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z116modelosdsc = T000J3_A116modelosdsc[0];
               Z117modelosusuario = T000J3_A117modelosusuario[0];
               Z118modelosfecreg = T000J3_A118modelosfecreg[0];
               Z119modelosfecultact = T000J3_A119modelosfecultact[0];
            }
            else
            {
               Z116modelosdsc = A116modelosdsc;
               Z117modelosusuario = A117modelosusuario;
               Z118modelosfecreg = A118modelosfecreg;
               Z119modelosfecultact = A119modelosfecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z15modelosid = A15modelosid;
            Z116modelosdsc = A116modelosdsc;
            Z117modelosusuario = A117modelosusuario;
            Z118modelosfecreg = A118modelosfecreg;
            Z119modelosfecultact = A119modelosfecultact;
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

      protected void Load0J19( )
      {
         /* Using cursor T000J4 */
         pr_default.execute(2, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound19 = 1;
            A116modelosdsc = T000J4_A116modelosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116modelosdsc", A116modelosdsc);
            n116modelosdsc = T000J4_n116modelosdsc[0];
            A117modelosusuario = T000J4_A117modelosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117modelosusuario", A117modelosusuario);
            n117modelosusuario = T000J4_n117modelosusuario[0];
            A118modelosfecreg = T000J4_A118modelosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118modelosfecreg", context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
            n118modelosfecreg = T000J4_n118modelosfecreg[0];
            A119modelosfecultact = T000J4_A119modelosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119modelosfecultact", context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
            n119modelosfecultact = T000J4_n119modelosfecultact[0];
            ZM0J19( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0J19( ) ;
      }

      protected void OnLoadActions0J19( )
      {
      }

      protected void CheckExtendedTable0J19( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0J19( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0J19( )
      {
         /* Using cursor T000J5 */
         pr_default.execute(3, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound19 = 1;
         }
         else
         {
            RcdFound19 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000J3 */
         pr_default.execute(1, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0J19( 1) ;
            RcdFound19 = 1;
            A15modelosid = T000J3_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            A116modelosdsc = T000J3_A116modelosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116modelosdsc", A116modelosdsc);
            n116modelosdsc = T000J3_n116modelosdsc[0];
            A117modelosusuario = T000J3_A117modelosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117modelosusuario", A117modelosusuario);
            n117modelosusuario = T000J3_n117modelosusuario[0];
            A118modelosfecreg = T000J3_A118modelosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118modelosfecreg", context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
            n118modelosfecreg = T000J3_n118modelosfecreg[0];
            A119modelosfecultact = T000J3_A119modelosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119modelosfecultact", context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
            n119modelosfecultact = T000J3_n119modelosfecultact[0];
            Z15modelosid = A15modelosid;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0J19( ) ;
            if ( AnyError == 1 )
            {
               RcdFound19 = 0;
               InitializeNonKey0J19( ) ;
            }
            Gx_mode = sMode19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound19 = 0;
            InitializeNonKey0J19( ) ;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0J19( ) ;
         if ( RcdFound19 == 0 )
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
         RcdFound19 = 0;
         /* Using cursor T000J6 */
         pr_default.execute(4, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000J6_A15modelosid[0] < A15modelosid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000J6_A15modelosid[0] > A15modelosid ) ) )
            {
               A15modelosid = T000J6_A15modelosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               RcdFound19 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound19 = 0;
         /* Using cursor T000J7 */
         pr_default.execute(5, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000J7_A15modelosid[0] > A15modelosid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000J7_A15modelosid[0] < A15modelosid ) ) )
            {
               A15modelosid = T000J7_A15modelosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               RcdFound19 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0J19( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0J19( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound19 == 1 )
            {
               if ( A15modelosid != Z15modelosid )
               {
                  A15modelosid = Z15modelosid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "MODELOSID");
                  AnyError = 1;
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0J19( ) ;
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A15modelosid != Z15modelosid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0J19( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "MODELOSID");
                     AnyError = 1;
                     GX_FocusControl = edtmodelosid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtmodelosid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0J19( ) ;
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
         if ( A15modelosid != Z15modelosid )
         {
            A15modelosid = Z15modelosid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtmodelosid_Internalname;
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
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtmodelosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0J19( ) ;
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmodelosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0J19( ) ;
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
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmodelosdsc_Internalname;
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
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmodelosdsc_Internalname;
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
         ScanStart0J19( ) ;
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound19 != 0 )
            {
               ScanNext0J19( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmodelosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0J19( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0J19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000J2 */
            pr_default.execute(0, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MODELOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z116modelosdsc, T000J2_A116modelosdsc[0]) != 0 ) || ( StringUtil.StrCmp(Z117modelosusuario, T000J2_A117modelosusuario[0]) != 0 ) || ( Z118modelosfecreg != T000J2_A118modelosfecreg[0] ) || ( Z119modelosfecultact != T000J2_A119modelosfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z116modelosdsc, T000J2_A116modelosdsc[0]) != 0 )
               {
                  GXUtil.WriteLog("modelos:[seudo value changed for attri]"+"modelosdsc");
                  GXUtil.WriteLogRaw("Old: ",Z116modelosdsc);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A116modelosdsc[0]);
               }
               if ( StringUtil.StrCmp(Z117modelosusuario, T000J2_A117modelosusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("modelos:[seudo value changed for attri]"+"modelosusuario");
                  GXUtil.WriteLogRaw("Old: ",Z117modelosusuario);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A117modelosusuario[0]);
               }
               if ( Z118modelosfecreg != T000J2_A118modelosfecreg[0] )
               {
                  GXUtil.WriteLog("modelos:[seudo value changed for attri]"+"modelosfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z118modelosfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A118modelosfecreg[0]);
               }
               if ( Z119modelosfecultact != T000J2_A119modelosfecultact[0] )
               {
                  GXUtil.WriteLog("modelos:[seudo value changed for attri]"+"modelosfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z119modelosfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A119modelosfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MODELOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0J19( )
      {
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J19( 0) ;
            CheckOptimisticConcurrency0J19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J8 */
                     pr_default.execute(6, new Object[] {A15modelosid, n116modelosdsc, A116modelosdsc, n117modelosusuario, A117modelosusuario, n118modelosfecreg, A118modelosfecreg, n119modelosfecultact, A119modelosfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
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
                           ResetCaption0J0( ) ;
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
               Load0J19( ) ;
            }
            EndLevel0J19( ) ;
         }
         CloseExtendedTableCursors0J19( ) ;
      }

      protected void Update0J19( )
      {
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J9 */
                     pr_default.execute(7, new Object[] {n116modelosdsc, A116modelosdsc, n117modelosusuario, A117modelosusuario, n118modelosfecreg, A118modelosfecreg, n119modelosfecultact, A119modelosfecultact, A15modelosid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MODELOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0J19( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0J0( ) ;
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
            EndLevel0J19( ) ;
         }
         CloseExtendedTableCursors0J19( ) ;
      }

      protected void DeferredUpdate0J19( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0J19( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J19( ) ;
            AfterConfirm0J19( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J19( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000J10 */
                  pr_default.execute(8, new Object[] {A15modelosid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("MODELOS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound19 == 0 )
                        {
                           InitAll0J19( ) ;
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
                        ResetCaption0J0( ) ;
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
         sMode19 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0J19( ) ;
         Gx_mode = sMode19;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0J19( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000J11 */
            pr_default.execute(9, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000J12 */
            pr_default.execute(10, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000J13 */
            pr_default.execute(11, new Object[] {A15modelosid});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"producto"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0J19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0J19( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "modelos");
            if ( AnyError == 0 )
            {
               ConfirmValues0J0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "modelos");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0J19( )
      {
         /* Using cursor T000J14 */
         pr_default.execute(12);
         RcdFound19 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound19 = 1;
            A15modelosid = T000J14_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0J19( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound19 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound19 = 1;
            A15modelosid = T000J14_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
         }
      }

      protected void ScanEnd0J19( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0J19( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J19( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J19( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J19( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J19( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J19( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J19( )
      {
         edtmodelosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosid_Enabled), 5, 0)));
         edtmodelosdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosdsc_Enabled), 5, 0)));
         edtmodelosusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosusuario_Enabled), 5, 0)));
         edtmodelosfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosfecreg_Enabled), 5, 0)));
         edtmodelosfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0J0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202212517345383");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("modelos.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z15modelosid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15modelosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z116modelosdsc", Z116modelosdsc);
         GxWebStd.gx_hidden_field( context, "Z117modelosusuario", Z117modelosusuario);
         GxWebStd.gx_hidden_field( context, "Z118modelosfecreg", context.localUtil.TToC( Z118modelosfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z119modelosfecultact", context.localUtil.TToC( Z119modelosfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("modelos.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "modelos" ;
      }

      public override String GetPgmdesc( )
      {
         return "modelos" ;
      }

      protected void InitializeNonKey0J19( )
      {
         A116modelosdsc = "";
         n116modelosdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116modelosdsc", A116modelosdsc);
         n116modelosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A116modelosdsc)) ? true : false);
         A117modelosusuario = "";
         n117modelosusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117modelosusuario", A117modelosusuario);
         n117modelosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A117modelosusuario)) ? true : false);
         A118modelosfecreg = (DateTime)(DateTime.MinValue);
         n118modelosfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118modelosfecreg", context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
         n118modelosfecreg = ((DateTime.MinValue==A118modelosfecreg) ? true : false);
         A119modelosfecultact = (DateTime)(DateTime.MinValue);
         n119modelosfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119modelosfecultact", context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
         n119modelosfecultact = ((DateTime.MinValue==A119modelosfecultact) ? true : false);
         Z116modelosdsc = "";
         Z117modelosusuario = "";
         Z118modelosfecreg = (DateTime)(DateTime.MinValue);
         Z119modelosfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0J19( )
      {
         A15modelosid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
         InitializeNonKey0J19( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202212517345390");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("modelos.js", "?202212517345390");
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
         edtmodelosid_Internalname = "MODELOSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmodelosdsc_Internalname = "MODELOSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmodelosusuario_Internalname = "MODELOSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmodelosfecreg_Internalname = "MODELOSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmodelosfecultact_Internalname = "MODELOSFECULTACT";
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
         Form.Caption = "modelos";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtmodelosfecultact_Jsonclick = "";
         edtmodelosfecultact_Enabled = 1;
         edtmodelosfecreg_Jsonclick = "";
         edtmodelosfecreg_Enabled = 1;
         edtmodelosusuario_Jsonclick = "";
         edtmodelosusuario_Enabled = 1;
         edtmodelosdsc_Jsonclick = "";
         edtmodelosdsc_Enabled = 1;
         edtmodelosid_Jsonclick = "";
         edtmodelosid_Enabled = 1;
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
         GX_FocusControl = edtmodelosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Modelosid( int GX_Parm1 ,
                                   String GX_Parm2 ,
                                   String GX_Parm3 ,
                                   DateTime GX_Parm4 ,
                                   DateTime GX_Parm5 )
      {
         A15modelosid = GX_Parm1;
         A116modelosdsc = GX_Parm2;
         n116modelosdsc = false;
         A117modelosusuario = GX_Parm3;
         n117modelosusuario = false;
         A118modelosfecreg = GX_Parm4;
         n118modelosfecreg = false;
         A119modelosfecultact = GX_Parm5;
         n119modelosfecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A116modelosdsc);
         isValidOutput.Add(A117modelosusuario);
         isValidOutput.Add(context.localUtil.TToC( A118modelosfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A119modelosfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15modelosid), 9, 0, ",", "")));
         isValidOutput.Add(Z116modelosdsc);
         isValidOutput.Add(Z117modelosusuario);
         isValidOutput.Add(context.localUtil.TToC( Z118modelosfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z119modelosfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         Z116modelosdsc = "";
         Z117modelosusuario = "";
         Z118modelosfecreg = (DateTime)(DateTime.MinValue);
         Z119modelosfecultact = (DateTime)(DateTime.MinValue);
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
         A116modelosdsc = "";
         A117modelosusuario = "";
         A118modelosfecreg = (DateTime)(DateTime.MinValue);
         A119modelosfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000J4_A15modelosid = new int[1] ;
         T000J4_A116modelosdsc = new String[] {""} ;
         T000J4_n116modelosdsc = new bool[] {false} ;
         T000J4_A117modelosusuario = new String[] {""} ;
         T000J4_n117modelosusuario = new bool[] {false} ;
         T000J4_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000J4_n118modelosfecreg = new bool[] {false} ;
         T000J4_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000J4_n119modelosfecultact = new bool[] {false} ;
         T000J5_A15modelosid = new int[1] ;
         T000J3_A15modelosid = new int[1] ;
         T000J3_A116modelosdsc = new String[] {""} ;
         T000J3_n116modelosdsc = new bool[] {false} ;
         T000J3_A117modelosusuario = new String[] {""} ;
         T000J3_n117modelosusuario = new bool[] {false} ;
         T000J3_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000J3_n118modelosfecreg = new bool[] {false} ;
         T000J3_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000J3_n119modelosfecultact = new bool[] {false} ;
         sMode19 = "";
         T000J6_A15modelosid = new int[1] ;
         T000J7_A15modelosid = new int[1] ;
         T000J2_A15modelosid = new int[1] ;
         T000J2_A116modelosdsc = new String[] {""} ;
         T000J2_n116modelosdsc = new bool[] {false} ;
         T000J2_A117modelosusuario = new String[] {""} ;
         T000J2_n117modelosusuario = new bool[] {false} ;
         T000J2_A118modelosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000J2_n118modelosfecreg = new bool[] {false} ;
         T000J2_A119modelosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000J2_n119modelosfecultact = new bool[] {false} ;
         T000J11_A19almacenid = new long[1] ;
         T000J11_A20articulosproductoid = new int[1] ;
         T000J11_A21articuloscambsid = new int[1] ;
         T000J12_A17etiquetasproductoid = new int[1] ;
         T000J12_A18etiquetascambsid = new int[1] ;
         T000J12_A19almacenid = new long[1] ;
         T000J13_A15modelosid = new int[1] ;
         T000J13_A16productocambsid = new String[] {""} ;
         T000J14_A15modelosid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.modelos__default(),
            new Object[][] {
                new Object[] {
               T000J2_A15modelosid, T000J2_A116modelosdsc, T000J2_n116modelosdsc, T000J2_A117modelosusuario, T000J2_n117modelosusuario, T000J2_A118modelosfecreg, T000J2_n118modelosfecreg, T000J2_A119modelosfecultact, T000J2_n119modelosfecultact
               }
               , new Object[] {
               T000J3_A15modelosid, T000J3_A116modelosdsc, T000J3_n116modelosdsc, T000J3_A117modelosusuario, T000J3_n117modelosusuario, T000J3_A118modelosfecreg, T000J3_n118modelosfecreg, T000J3_A119modelosfecultact, T000J3_n119modelosfecultact
               }
               , new Object[] {
               T000J4_A15modelosid, T000J4_A116modelosdsc, T000J4_n116modelosdsc, T000J4_A117modelosusuario, T000J4_n117modelosusuario, T000J4_A118modelosfecreg, T000J4_n118modelosfecreg, T000J4_A119modelosfecultact, T000J4_n119modelosfecultact
               }
               , new Object[] {
               T000J5_A15modelosid
               }
               , new Object[] {
               T000J6_A15modelosid
               }
               , new Object[] {
               T000J7_A15modelosid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000J11_A19almacenid, T000J11_A20articulosproductoid, T000J11_A21articuloscambsid
               }
               , new Object[] {
               T000J12_A17etiquetasproductoid, T000J12_A18etiquetascambsid, T000J12_A19almacenid
               }
               , new Object[] {
               T000J13_A15modelosid, T000J13_A16productocambsid
               }
               , new Object[] {
               T000J14_A15modelosid
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
      private short RcdFound19 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z15modelosid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A15modelosid ;
      private int edtmodelosid_Enabled ;
      private int edtmodelosdsc_Enabled ;
      private int edtmodelosusuario_Enabled ;
      private int edtmodelosfecreg_Enabled ;
      private int edtmodelosfecultact_Enabled ;
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
      private String edtmodelosid_Internalname ;
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
      private String edtmodelosid_Jsonclick ;
      private String edtmodelosdsc_Internalname ;
      private String edtmodelosdsc_Jsonclick ;
      private String edtmodelosusuario_Internalname ;
      private String edtmodelosusuario_Jsonclick ;
      private String edtmodelosfecreg_Internalname ;
      private String edtmodelosfecreg_Jsonclick ;
      private String edtmodelosfecultact_Internalname ;
      private String edtmodelosfecultact_Jsonclick ;
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
      private String sMode19 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z118modelosfecreg ;
      private DateTime Z119modelosfecultact ;
      private DateTime A118modelosfecreg ;
      private DateTime A119modelosfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n116modelosdsc ;
      private bool n117modelosusuario ;
      private bool n118modelosfecreg ;
      private bool n119modelosfecultact ;
      private String Z116modelosdsc ;
      private String Z117modelosusuario ;
      private String A116modelosdsc ;
      private String A117modelosusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000J4_A15modelosid ;
      private String[] T000J4_A116modelosdsc ;
      private bool[] T000J4_n116modelosdsc ;
      private String[] T000J4_A117modelosusuario ;
      private bool[] T000J4_n117modelosusuario ;
      private DateTime[] T000J4_A118modelosfecreg ;
      private bool[] T000J4_n118modelosfecreg ;
      private DateTime[] T000J4_A119modelosfecultact ;
      private bool[] T000J4_n119modelosfecultact ;
      private int[] T000J5_A15modelosid ;
      private int[] T000J3_A15modelosid ;
      private String[] T000J3_A116modelosdsc ;
      private bool[] T000J3_n116modelosdsc ;
      private String[] T000J3_A117modelosusuario ;
      private bool[] T000J3_n117modelosusuario ;
      private DateTime[] T000J3_A118modelosfecreg ;
      private bool[] T000J3_n118modelosfecreg ;
      private DateTime[] T000J3_A119modelosfecultact ;
      private bool[] T000J3_n119modelosfecultact ;
      private int[] T000J6_A15modelosid ;
      private int[] T000J7_A15modelosid ;
      private int[] T000J2_A15modelosid ;
      private String[] T000J2_A116modelosdsc ;
      private bool[] T000J2_n116modelosdsc ;
      private String[] T000J2_A117modelosusuario ;
      private bool[] T000J2_n117modelosusuario ;
      private DateTime[] T000J2_A118modelosfecreg ;
      private bool[] T000J2_n118modelosfecreg ;
      private DateTime[] T000J2_A119modelosfecultact ;
      private bool[] T000J2_n119modelosfecultact ;
      private long[] T000J11_A19almacenid ;
      private int[] T000J11_A20articulosproductoid ;
      private int[] T000J11_A21articuloscambsid ;
      private int[] T000J12_A17etiquetasproductoid ;
      private int[] T000J12_A18etiquetascambsid ;
      private long[] T000J12_A19almacenid ;
      private int[] T000J13_A15modelosid ;
      private String[] T000J13_A16productocambsid ;
      private int[] T000J14_A15modelosid ;
      private GXWebForm Form ;
   }

   public class modelos__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000J4 ;
          prmT000J4 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J5 ;
          prmT000J5 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J3 ;
          prmT000J3 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J6 ;
          prmT000J6 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J7 ;
          prmT000J7 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J2 ;
          prmT000J2 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J8 ;
          prmT000J8 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"modelosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modelosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"modelosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000J9 ;
          prmT000J9 = new Object[] {
          new Object[] {"modelosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"modelosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"modelosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J10 ;
          prmT000J10 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J11 ;
          prmT000J11 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J12 ;
          prmT000J12 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J13 ;
          prmT000J13 = new Object[] {
          new Object[] {"modelosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000J14 ;
          prmT000J14 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000J2", "SELECT modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact FROM public.modelos WHERE modelosid = :modelosid  FOR UPDATE OF modelos NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000J2,1,0,true,false )
             ,new CursorDef("T000J3", "SELECT modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact FROM public.modelos WHERE modelosid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J3,1,0,true,false )
             ,new CursorDef("T000J4", "SELECT TM1.modelosid AS modelosid, TM1.modelosdsc, TM1.modelosusuario, TM1.modelosfecreg, TM1.modelosfecultact FROM public.modelos TM1 WHERE TM1.modelosid = :modelosid ORDER BY TM1.modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J4,100,0,true,false )
             ,new CursorDef("T000J5", "SELECT modelosid FROM public.modelos WHERE modelosid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J5,1,0,true,false )
             ,new CursorDef("T000J6", "SELECT modelosid FROM public.modelos WHERE ( modelosid > :modelosid) ORDER BY modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J6,1,0,true,true )
             ,new CursorDef("T000J7", "SELECT modelosid FROM public.modelos WHERE ( modelosid < :modelosid) ORDER BY modelosid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J7,1,0,true,true )
             ,new CursorDef("T000J8", "SAVEPOINT gxupdate;INSERT INTO public.modelos(modelosid, modelosdsc, modelosusuario, modelosfecreg, modelosfecultact) VALUES(:modelosid, :modelosdsc, :modelosusuario, :modelosfecreg, :modelosfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000J8)
             ,new CursorDef("T000J9", "SAVEPOINT gxupdate;UPDATE public.modelos SET modelosdsc=:modelosdsc, modelosusuario=:modelosusuario, modelosfecreg=:modelosfecreg, modelosfecultact=:modelosfecultact  WHERE modelosid = :modelosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000J9)
             ,new CursorDef("T000J10", "SAVEPOINT gxupdate;DELETE FROM public.modelos  WHERE modelosid = :modelosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000J10)
             ,new CursorDef("T000J11", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE productoid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J11,1,0,true,true )
             ,new CursorDef("T000J12", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE productoid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J12,1,0,true,true )
             ,new CursorDef("T000J13", "SELECT productoid AS modelosid, cambsid AS productocambsid FROM public.producto WHERE productoid = :modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J13,1,0,true,true )
             ,new CursorDef("T000J14", "SELECT modelosid FROM public.modelos ORDER BY modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J14,100,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
