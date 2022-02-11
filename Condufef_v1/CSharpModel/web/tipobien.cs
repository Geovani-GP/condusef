/*
               File: tipobien
        Description: tipobien
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/10/2022 19:54:26.23
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
   public class tipobien : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "tipobien", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edttipobienid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tipobien( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public tipobien( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "tipobien", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_tipobien.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOBIENID"+"'), id:'"+"TIPOBIENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_tipobien.htm");
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
            GxWebStd.gx_label_element( context, edttipobienid_Internalname, "tipobienid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipobienid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")), ((edttipobienid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobienid_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobienid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipobien.htm");
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
            GxWebStd.gx_label_element( context, edttipobiendsc_Internalname, "tipobiendsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipobiendsc_Internalname, A139tipobiendsc, StringUtil.RTrim( context.localUtil.Format( A139tipobiendsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobiendsc_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobiendsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_tipobien.htm");
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
            GxWebStd.gx_label_element( context, edttipobienusuario_Internalname, "tipobienusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipobienusuario_Internalname, A140tipobienusuario, StringUtil.RTrim( context.localUtil.Format( A140tipobienusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobienusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobienusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_tipobien.htm");
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
            GxWebStd.gx_label_element( context, edttipobienfecreg_Internalname, "tipobienfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edttipobienfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edttipobienfecreg_Internalname, context.localUtil.Format(A141tipobienfecreg, "99/99/9999"), context.localUtil.Format( A141tipobienfecreg, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobienfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobienfecreg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipobien.htm");
            GxWebStd.gx_bitmap( context, edttipobienfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edttipobienfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_tipobien.htm");
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
            GxWebStd.gx_label_element( context, edttipobienfecultact_Internalname, "tipobienfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edttipobienfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edttipobienfecultact_Internalname, context.localUtil.Format(A142tipobienfecultact, "99/99/9999"), context.localUtil.Format( A142tipobienfecultact, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobienfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobienfecultact_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_tipobien.htm");
            GxWebStd.gx_bitmap( context, edttipobienfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edttipobienfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_tipobien.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_tipobien.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOBIENID");
                  AnyError = 1;
                  GX_FocusControl = edttipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A23tipobienid = 0;
                  n23tipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
               }
               else
               {
                  A23tipobienid = (int)(context.localUtil.CToN( cgiGet( edttipobienid_Internalname), ",", "."));
                  n23tipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
               }
               A139tipobiendsc = cgiGet( edttipobiendsc_Internalname);
               n139tipobiendsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139tipobiendsc", A139tipobiendsc);
               n139tipobiendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A139tipobiendsc)) ? true : false);
               A140tipobienusuario = cgiGet( edttipobienusuario_Internalname);
               n140tipobienusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A140tipobienusuario", A140tipobienusuario);
               n140tipobienusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A140tipobienusuario)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edttipobienfecreg_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"tipobienfecreg"}), 1, "TIPOBIENFECREG");
                  AnyError = 1;
                  GX_FocusControl = edttipobienfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A141tipobienfecreg = DateTime.MinValue;
                  n141tipobienfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141tipobienfecreg", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
               }
               else
               {
                  A141tipobienfecreg = context.localUtil.CToD( cgiGet( edttipobienfecreg_Internalname), 2);
                  n141tipobienfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141tipobienfecreg", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
               }
               n141tipobienfecreg = ((DateTime.MinValue==A141tipobienfecreg) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edttipobienfecultact_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"tipobienfecultact"}), 1, "TIPOBIENFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edttipobienfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A142tipobienfecultact = DateTime.MinValue;
                  n142tipobienfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A142tipobienfecultact", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
               }
               else
               {
                  A142tipobienfecultact = context.localUtil.CToD( cgiGet( edttipobienfecultact_Internalname), 2);
                  n142tipobienfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A142tipobienfecultact", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
               }
               n142tipobienfecultact = ((DateTime.MinValue==A142tipobienfecultact) ? true : false);
               /* Read saved values. */
               Z23tipobienid = (int)(context.localUtil.CToN( cgiGet( "Z23tipobienid"), ",", "."));
               Z139tipobiendsc = cgiGet( "Z139tipobiendsc");
               n139tipobiendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A139tipobiendsc)) ? true : false);
               Z140tipobienusuario = cgiGet( "Z140tipobienusuario");
               n140tipobienusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A140tipobienusuario)) ? true : false);
               Z141tipobienfecreg = context.localUtil.CToD( cgiGet( "Z141tipobienfecreg"), 0);
               n141tipobienfecreg = ((DateTime.MinValue==A141tipobienfecreg) ? true : false);
               Z142tipobienfecultact = context.localUtil.CToD( cgiGet( "Z142tipobienfecultact"), 0);
               n142tipobienfecultact = ((DateTime.MinValue==A142tipobienfecultact) ? true : false);
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
                  A23tipobienid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  n23tipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
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
               InitAll011( ) ;
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
         DisableAttributes011( ) ;
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

      protected void ResetCaption010( )
      {
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z139tipobiendsc = T00013_A139tipobiendsc[0];
               Z140tipobienusuario = T00013_A140tipobienusuario[0];
               Z141tipobienfecreg = T00013_A141tipobienfecreg[0];
               Z142tipobienfecultact = T00013_A142tipobienfecultact[0];
            }
            else
            {
               Z139tipobiendsc = A139tipobiendsc;
               Z140tipobienusuario = A140tipobienusuario;
               Z141tipobienfecreg = A141tipobienfecreg;
               Z142tipobienfecultact = A142tipobienfecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z23tipobienid = A23tipobienid;
            Z139tipobiendsc = A139tipobiendsc;
            Z140tipobienusuario = A140tipobienusuario;
            Z141tipobienfecreg = A141tipobienfecreg;
            Z142tipobienfecultact = A142tipobienfecultact;
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

      protected void Load011( )
      {
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound1 = 1;
            A139tipobiendsc = T00014_A139tipobiendsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139tipobiendsc", A139tipobiendsc);
            n139tipobiendsc = T00014_n139tipobiendsc[0];
            A140tipobienusuario = T00014_A140tipobienusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A140tipobienusuario", A140tipobienusuario);
            n140tipobienusuario = T00014_n140tipobienusuario[0];
            A141tipobienfecreg = T00014_A141tipobienfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141tipobienfecreg", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
            n141tipobienfecreg = T00014_n141tipobienfecreg[0];
            A142tipobienfecultact = T00014_A142tipobienfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A142tipobienfecultact", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
            n142tipobienfecultact = T00014_n142tipobienfecultact[0];
            ZM011( -1) ;
         }
         pr_default.close(2);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 1) ;
            RcdFound1 = 1;
            A23tipobienid = T00013_A23tipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            n23tipobienid = T00013_n23tipobienid[0];
            A139tipobiendsc = T00013_A139tipobiendsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139tipobiendsc", A139tipobiendsc);
            n139tipobiendsc = T00013_n139tipobiendsc[0];
            A140tipobienusuario = T00013_A140tipobienusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A140tipobienusuario", A140tipobienusuario);
            n140tipobienusuario = T00013_n140tipobienusuario[0];
            A141tipobienfecreg = T00013_A141tipobienfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141tipobienfecreg", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
            n141tipobienfecreg = T00013_n141tipobienfecreg[0];
            A142tipobienfecultact = T00013_A142tipobienfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A142tipobienfecultact", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
            n142tipobienfecultact = T00013_n142tipobienfecultact[0];
            Z23tipobienid = A23tipobienid;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         RcdFound1 = 0;
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00016_A23tipobienid[0] < A23tipobienid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00016_A23tipobienid[0] > A23tipobienid ) ) )
            {
               A23tipobienid = T00016_A23tipobienid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
               n23tipobienid = T00016_n23tipobienid[0];
               RcdFound1 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00017_A23tipobienid[0] > A23tipobienid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00017_A23tipobienid[0] < A23tipobienid ) ) )
            {
               A23tipobienid = T00017_A23tipobienid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
               n23tipobienid = T00017_n23tipobienid[0];
               RcdFound1 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edttipobienid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A23tipobienid != Z23tipobienid )
               {
                  A23tipobienid = Z23tipobienid;
                  n23tipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "TIPOBIENID");
                  AnyError = 1;
                  GX_FocusControl = edttipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edttipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edttipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A23tipobienid != Z23tipobienid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edttipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "TIPOBIENID");
                     AnyError = 1;
                     GX_FocusControl = edttipobienid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edttipobienid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
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
         if ( A23tipobienid != Z23tipobienid )
         {
            A23tipobienid = Z23tipobienid;
            n23tipobienid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "TIPOBIENID");
            AnyError = 1;
            GX_FocusControl = edttipobienid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edttipobienid_Internalname;
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
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "TIPOBIENID");
            AnyError = 1;
            GX_FocusControl = edttipobienid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edttipobiendsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipobiendsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
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
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipobiendsc_Internalname;
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
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipobiendsc_Internalname;
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
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound1 != 0 )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edttipobiendsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {n23tipobienid, A23tipobienid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPOBIEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z139tipobiendsc, T00012_A139tipobiendsc[0]) != 0 ) || ( StringUtil.StrCmp(Z140tipobienusuario, T00012_A140tipobienusuario[0]) != 0 ) || ( Z141tipobienfecreg != T00012_A141tipobienfecreg[0] ) || ( Z142tipobienfecultact != T00012_A142tipobienfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z139tipobiendsc, T00012_A139tipobiendsc[0]) != 0 )
               {
                  GXUtil.WriteLog("tipobien:[seudo value changed for attri]"+"tipobiendsc");
                  GXUtil.WriteLogRaw("Old: ",Z139tipobiendsc);
                  GXUtil.WriteLogRaw("Current: ",T00012_A139tipobiendsc[0]);
               }
               if ( StringUtil.StrCmp(Z140tipobienusuario, T00012_A140tipobienusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("tipobien:[seudo value changed for attri]"+"tipobienusuario");
                  GXUtil.WriteLogRaw("Old: ",Z140tipobienusuario);
                  GXUtil.WriteLogRaw("Current: ",T00012_A140tipobienusuario[0]);
               }
               if ( Z141tipobienfecreg != T00012_A141tipobienfecreg[0] )
               {
                  GXUtil.WriteLog("tipobien:[seudo value changed for attri]"+"tipobienfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z141tipobienfecreg);
                  GXUtil.WriteLogRaw("Current: ",T00012_A141tipobienfecreg[0]);
               }
               if ( Z142tipobienfecultact != T00012_A142tipobienfecultact[0] )
               {
                  GXUtil.WriteLog("tipobien:[seudo value changed for attri]"+"tipobienfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z142tipobienfecultact);
                  GXUtil.WriteLogRaw("Current: ",T00012_A142tipobienfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TIPOBIEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00018 */
                     pr_default.execute(6, new Object[] {n23tipobienid, A23tipobienid, n139tipobiendsc, A139tipobiendsc, n140tipobienusuario, A140tipobienusuario, n141tipobienfecreg, A141tipobienfecreg, n142tipobienfecultact, A142tipobienfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
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
                           ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00019 */
                     pr_default.execute(7, new Object[] {n139tipobiendsc, A139tipobiendsc, n140tipobienusuario, A140tipobienusuario, n141tipobienfecreg, A141tipobienfecreg, n142tipobienfecultact, A142tipobienfecultact, n23tipobienid, A23tipobienid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TIPOBIEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption010( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000110 */
                  pr_default.execute(8, new Object[] {n23tipobienid, A23tipobienid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("TIPOBIEN") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound1 == 0 )
                        {
                           InitAll011( ) ;
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
                        ResetCaption010( ) ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000111 */
            pr_default.execute(9, new Object[] {n23tipobienid, A23tipobienid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "tipobien");
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "tipobien");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Using cursor T000112 */
         pr_default.execute(10);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A23tipobienid = T000112_A23tipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            n23tipobienid = T000112_n23tipobienid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A23tipobienid = T000112_A23tipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            n23tipobienid = T000112_n23tipobienid[0];
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edttipobienid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobienid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobienid_Enabled), 5, 0)));
         edttipobiendsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobiendsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobiendsc_Enabled), 5, 0)));
         edttipobienusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobienusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobienusuario_Enabled), 5, 0)));
         edttipobienfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobienfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobienfecreg_Enabled), 5, 0)));
         edttipobienfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobienfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobienfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
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
         context.AddJavascriptSource("gxcfg.js", "?202221019542666");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("tipobien.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z23tipobienid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23tipobienid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z139tipobiendsc", Z139tipobiendsc);
         GxWebStd.gx_hidden_field( context, "Z140tipobienusuario", Z140tipobienusuario);
         GxWebStd.gx_hidden_field( context, "Z141tipobienfecreg", context.localUtil.DToC( Z141tipobienfecreg, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z142tipobienfecultact", context.localUtil.DToC( Z142tipobienfecultact, 0, "/"));
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
         return formatLink("tipobien.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "tipobien" ;
      }

      public override String GetPgmdesc( )
      {
         return "tipobien" ;
      }

      protected void InitializeNonKey011( )
      {
         A139tipobiendsc = "";
         n139tipobiendsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139tipobiendsc", A139tipobiendsc);
         n139tipobiendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A139tipobiendsc)) ? true : false);
         A140tipobienusuario = "";
         n140tipobienusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A140tipobienusuario", A140tipobienusuario);
         n140tipobienusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A140tipobienusuario)) ? true : false);
         A141tipobienfecreg = DateTime.MinValue;
         n141tipobienfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141tipobienfecreg", context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
         n141tipobienfecreg = ((DateTime.MinValue==A141tipobienfecreg) ? true : false);
         A142tipobienfecultact = DateTime.MinValue;
         n142tipobienfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A142tipobienfecultact", context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
         n142tipobienfecultact = ((DateTime.MinValue==A142tipobienfecultact) ? true : false);
         Z139tipobiendsc = "";
         Z140tipobienusuario = "";
         Z141tipobienfecreg = DateTime.MinValue;
         Z142tipobienfecultact = DateTime.MinValue;
      }

      protected void InitAll011( )
      {
         A23tipobienid = 0;
         n23tipobienid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?19483837");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202221019542669");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("tipobien.js", "?202221019542669");
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
         edttipobienid_Internalname = "TIPOBIENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipobiendsc_Internalname = "TIPOBIENDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipobienusuario_Internalname = "TIPOBIENUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipobienfecreg_Internalname = "TIPOBIENFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipobienfecultact_Internalname = "TIPOBIENFECULTACT";
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
         Form.Caption = "tipobien";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edttipobienfecultact_Jsonclick = "";
         edttipobienfecultact_Enabled = 1;
         edttipobienfecreg_Jsonclick = "";
         edttipobienfecreg_Enabled = 1;
         edttipobienusuario_Jsonclick = "";
         edttipobienusuario_Enabled = 1;
         edttipobiendsc_Jsonclick = "";
         edttipobiendsc_Enabled = 1;
         edttipobienid_Jsonclick = "";
         edttipobienid_Enabled = 1;
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
         GX_FocusControl = edttipobiendsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Tipobienid( int GX_Parm1 ,
                                    String GX_Parm2 ,
                                    String GX_Parm3 ,
                                    DateTime GX_Parm4 ,
                                    DateTime GX_Parm5 )
      {
         A23tipobienid = GX_Parm1;
         n23tipobienid = false;
         A139tipobiendsc = GX_Parm2;
         n139tipobiendsc = false;
         A140tipobienusuario = GX_Parm3;
         n140tipobienusuario = false;
         A141tipobienfecreg = GX_Parm4;
         n141tipobienfecreg = false;
         A142tipobienfecultact = GX_Parm5;
         n142tipobienfecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A139tipobiendsc);
         isValidOutput.Add(A140tipobienusuario);
         isValidOutput.Add(context.localUtil.Format(A141tipobienfecreg, "99/99/9999"));
         isValidOutput.Add(context.localUtil.Format(A142tipobienfecultact, "99/99/9999"));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23tipobienid), 9, 0, ",", "")));
         isValidOutput.Add(Z139tipobiendsc);
         isValidOutput.Add(Z140tipobienusuario);
         isValidOutput.Add(context.localUtil.DToC( Z141tipobienfecreg, 0, "/"));
         isValidOutput.Add(context.localUtil.DToC( Z142tipobienfecultact, 0, "/"));
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
         Z139tipobiendsc = "";
         Z140tipobienusuario = "";
         Z141tipobienfecreg = DateTime.MinValue;
         Z142tipobienfecultact = DateTime.MinValue;
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
         A139tipobiendsc = "";
         A140tipobienusuario = "";
         A141tipobienfecreg = DateTime.MinValue;
         A142tipobienfecultact = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00014_A23tipobienid = new int[1] ;
         T00014_n23tipobienid = new bool[] {false} ;
         T00014_A139tipobiendsc = new String[] {""} ;
         T00014_n139tipobiendsc = new bool[] {false} ;
         T00014_A140tipobienusuario = new String[] {""} ;
         T00014_n140tipobienusuario = new bool[] {false} ;
         T00014_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         T00014_n141tipobienfecreg = new bool[] {false} ;
         T00014_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         T00014_n142tipobienfecultact = new bool[] {false} ;
         T00015_A23tipobienid = new int[1] ;
         T00015_n23tipobienid = new bool[] {false} ;
         T00013_A23tipobienid = new int[1] ;
         T00013_n23tipobienid = new bool[] {false} ;
         T00013_A139tipobiendsc = new String[] {""} ;
         T00013_n139tipobiendsc = new bool[] {false} ;
         T00013_A140tipobienusuario = new String[] {""} ;
         T00013_n140tipobienusuario = new bool[] {false} ;
         T00013_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         T00013_n141tipobienfecreg = new bool[] {false} ;
         T00013_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         T00013_n142tipobienfecultact = new bool[] {false} ;
         sMode1 = "";
         T00016_A23tipobienid = new int[1] ;
         T00016_n23tipobienid = new bool[] {false} ;
         T00017_A23tipobienid = new int[1] ;
         T00017_n23tipobienid = new bool[] {false} ;
         T00012_A23tipobienid = new int[1] ;
         T00012_n23tipobienid = new bool[] {false} ;
         T00012_A139tipobiendsc = new String[] {""} ;
         T00012_n139tipobiendsc = new bool[] {false} ;
         T00012_A140tipobienusuario = new String[] {""} ;
         T00012_n140tipobienusuario = new bool[] {false} ;
         T00012_A141tipobienfecreg = new DateTime[] {DateTime.MinValue} ;
         T00012_n141tipobienfecreg = new bool[] {false} ;
         T00012_A142tipobienfecultact = new DateTime[] {DateTime.MinValue} ;
         T00012_n142tipobienfecultact = new bool[] {false} ;
         T000111_A19almacenid = new int[1] ;
         T000111_A20articulosproductoid = new int[1] ;
         T000111_A21articuloscambsid = new int[1] ;
         T000112_A23tipobienid = new int[1] ;
         T000112_n23tipobienid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipobien__default(),
            new Object[][] {
                new Object[] {
               T00012_A23tipobienid, T00012_A139tipobiendsc, T00012_n139tipobiendsc, T00012_A140tipobienusuario, T00012_n140tipobienusuario, T00012_A141tipobienfecreg, T00012_n141tipobienfecreg, T00012_A142tipobienfecultact, T00012_n142tipobienfecultact
               }
               , new Object[] {
               T00013_A23tipobienid, T00013_A139tipobiendsc, T00013_n139tipobiendsc, T00013_A140tipobienusuario, T00013_n140tipobienusuario, T00013_A141tipobienfecreg, T00013_n141tipobienfecreg, T00013_A142tipobienfecultact, T00013_n142tipobienfecultact
               }
               , new Object[] {
               T00014_A23tipobienid, T00014_A139tipobiendsc, T00014_n139tipobiendsc, T00014_A140tipobienusuario, T00014_n140tipobienusuario, T00014_A141tipobienfecreg, T00014_n141tipobienfecreg, T00014_A142tipobienfecultact, T00014_n142tipobienfecultact
               }
               , new Object[] {
               T00015_A23tipobienid
               }
               , new Object[] {
               T00016_A23tipobienid
               }
               , new Object[] {
               T00017_A23tipobienid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000111_A19almacenid, T000111_A20articulosproductoid, T000111_A21articuloscambsid
               }
               , new Object[] {
               T000112_A23tipobienid
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
      private short RcdFound1 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z23tipobienid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A23tipobienid ;
      private int edttipobienid_Enabled ;
      private int edttipobiendsc_Enabled ;
      private int edttipobienusuario_Enabled ;
      private int edttipobienfecreg_Enabled ;
      private int edttipobienfecultact_Enabled ;
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
      private String edttipobienid_Internalname ;
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
      private String edttipobienid_Jsonclick ;
      private String edttipobiendsc_Internalname ;
      private String edttipobiendsc_Jsonclick ;
      private String edttipobienusuario_Internalname ;
      private String edttipobienusuario_Jsonclick ;
      private String edttipobienfecreg_Internalname ;
      private String edttipobienfecreg_Jsonclick ;
      private String edttipobienfecultact_Internalname ;
      private String edttipobienfecultact_Jsonclick ;
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
      private String sMode1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z141tipobienfecreg ;
      private DateTime Z142tipobienfecultact ;
      private DateTime A141tipobienfecreg ;
      private DateTime A142tipobienfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n23tipobienid ;
      private bool n139tipobiendsc ;
      private bool n140tipobienusuario ;
      private bool n141tipobienfecreg ;
      private bool n142tipobienfecultact ;
      private String Z139tipobiendsc ;
      private String Z140tipobienusuario ;
      private String A139tipobiendsc ;
      private String A140tipobienusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00014_A23tipobienid ;
      private bool[] T00014_n23tipobienid ;
      private String[] T00014_A139tipobiendsc ;
      private bool[] T00014_n139tipobiendsc ;
      private String[] T00014_A140tipobienusuario ;
      private bool[] T00014_n140tipobienusuario ;
      private DateTime[] T00014_A141tipobienfecreg ;
      private bool[] T00014_n141tipobienfecreg ;
      private DateTime[] T00014_A142tipobienfecultact ;
      private bool[] T00014_n142tipobienfecultact ;
      private int[] T00015_A23tipobienid ;
      private bool[] T00015_n23tipobienid ;
      private int[] T00013_A23tipobienid ;
      private bool[] T00013_n23tipobienid ;
      private String[] T00013_A139tipobiendsc ;
      private bool[] T00013_n139tipobiendsc ;
      private String[] T00013_A140tipobienusuario ;
      private bool[] T00013_n140tipobienusuario ;
      private DateTime[] T00013_A141tipobienfecreg ;
      private bool[] T00013_n141tipobienfecreg ;
      private DateTime[] T00013_A142tipobienfecultact ;
      private bool[] T00013_n142tipobienfecultact ;
      private int[] T00016_A23tipobienid ;
      private bool[] T00016_n23tipobienid ;
      private int[] T00017_A23tipobienid ;
      private bool[] T00017_n23tipobienid ;
      private int[] T00012_A23tipobienid ;
      private bool[] T00012_n23tipobienid ;
      private String[] T00012_A139tipobiendsc ;
      private bool[] T00012_n139tipobiendsc ;
      private String[] T00012_A140tipobienusuario ;
      private bool[] T00012_n140tipobienusuario ;
      private DateTime[] T00012_A141tipobienfecreg ;
      private bool[] T00012_n141tipobienfecreg ;
      private DateTime[] T00012_A142tipobienfecultact ;
      private bool[] T00012_n142tipobienfecultact ;
      private int[] T000111_A19almacenid ;
      private int[] T000111_A20articulosproductoid ;
      private int[] T000111_A21articuloscambsid ;
      private int[] T000112_A23tipobienid ;
      private bool[] T000112_n23tipobienid ;
      private GXWebForm Form ;
   }

   public class tipobien__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"tipobiendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienfecultact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"tipobiendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"tipobienusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"tipobienfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact FROM public.tipobien WHERE tipobienid = :tipobienid  FOR UPDATE OF tipobien NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT TM1.tipobienid, TM1.tipobiendsc, TM1.tipobienusuario, TM1.tipobienfecreg, TM1.tipobienfecultact FROM public.tipobien TM1 WHERE TM1.tipobienid = :tipobienid ORDER BY TM1.tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,100,0,true,false )
             ,new CursorDef("T00015", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT tipobienid FROM public.tipobien WHERE ( tipobienid > :tipobienid) ORDER BY tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,true )
             ,new CursorDef("T00017", "SELECT tipobienid FROM public.tipobien WHERE ( tipobienid < :tipobienid) ORDER BY tipobienid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,true )
             ,new CursorDef("T00018", "SAVEPOINT gxupdate;INSERT INTO public.tipobien(tipobienid, tipobiendsc, tipobienusuario, tipobienfecreg, tipobienfecultact) VALUES(:tipobienid, :tipobiendsc, :tipobienusuario, :tipobienfecreg, :tipobienfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00018)
             ,new CursorDef("T00019", "SAVEPOINT gxupdate;UPDATE public.tipobien SET tipobiendsc=:tipobiendsc, tipobienusuario=:tipobienusuario, tipobienfecreg=:tipobienfecreg, tipobienfecultact=:tipobienfecultact  WHERE tipobienid = :tipobienid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00019)
             ,new CursorDef("T000110", "SAVEPOINT gxupdate;DELETE FROM public.tipobien  WHERE tipobienid = :tipobienid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000110)
             ,new CursorDef("T000111", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE tipodocid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,true )
             ,new CursorDef("T000112", "SELECT tipobienid FROM public.tipobien ORDER BY tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,100,0,true,false )
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
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
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
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[9]);
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
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
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
