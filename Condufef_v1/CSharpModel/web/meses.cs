/*
               File: meses
        Description: meses
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:37:19.90
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
   public class meses : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "meses", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtmesesid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public meses( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public meses( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "meses", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_meses.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MESESID"+"'), id:'"+"MESESID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_meses.htm");
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
            GxWebStd.gx_label_element( context, edtmesesid_Internalname, "mesesid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmesesid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11mesesid), 9, 0, ",", "")), ((edtmesesid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11mesesid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11mesesid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmesesid_Jsonclick, 0, "Attribute", "", "", "", 1, edtmesesid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_meses.htm");
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
            GxWebStd.gx_label_element( context, edtmesesanio_Internalname, "mesesanio", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmesesanio_Internalname, A61mesesanio, StringUtil.RTrim( context.localUtil.Format( A61mesesanio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmesesanio_Jsonclick, 0, "Attribute", "", "", "", 1, edtmesesanio_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_meses.htm");
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
            GxWebStd.gx_label_element( context, edtmesesusuario_Internalname, "mesesusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmesesusuario_Internalname, A62mesesusuario, StringUtil.RTrim( context.localUtil.Format( A62mesesusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmesesusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtmesesusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_meses.htm");
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
            GxWebStd.gx_label_element( context, edtmesesfecgre_Internalname, "mesesfecgre", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtmesesfecgre_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtmesesfecgre_Internalname, context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A63mesesfecgre, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmesesfecgre_Jsonclick, 0, "Attribute", "", "", "", 1, edtmesesfecgre_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_meses.htm");
            GxWebStd.gx_bitmap( context, edtmesesfecgre_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtmesesfecgre_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_meses.htm");
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
            GxWebStd.gx_label_element( context, edtmesesfeact_Internalname, "mesesfeact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtmesesfeact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtmesesfeact_Internalname, context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A64mesesfeact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmesesfeact_Jsonclick, 0, "Attribute", "", "", "", 1, edtmesesfeact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_meses.htm");
            GxWebStd.gx_bitmap( context, edtmesesfeact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtmesesfeact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_meses.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_meses.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtmesesid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtmesesid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MESESID");
                  AnyError = 1;
                  GX_FocusControl = edtmesesid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11mesesid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
               }
               else
               {
                  A11mesesid = (int)(context.localUtil.CToN( cgiGet( edtmesesid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
               }
               A61mesesanio = cgiGet( edtmesesanio_Internalname);
               n61mesesanio = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61mesesanio", A61mesesanio);
               n61mesesanio = (String.IsNullOrEmpty(StringUtil.RTrim( A61mesesanio)) ? true : false);
               A62mesesusuario = cgiGet( edtmesesusuario_Internalname);
               n62mesesusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62mesesusuario", A62mesesusuario);
               n62mesesusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A62mesesusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtmesesfecgre_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"mesesfecgre"}), 1, "MESESFECGRE");
                  AnyError = 1;
                  GX_FocusControl = edtmesesfecgre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A63mesesfecgre = (DateTime)(DateTime.MinValue);
                  n63mesesfecgre = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63mesesfecgre", context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A63mesesfecgre = context.localUtil.CToT( cgiGet( edtmesesfecgre_Internalname));
                  n63mesesfecgre = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63mesesfecgre", context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
               }
               n63mesesfecgre = ((DateTime.MinValue==A63mesesfecgre) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtmesesfeact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"mesesfeact"}), 1, "MESESFEACT");
                  AnyError = 1;
                  GX_FocusControl = edtmesesfeact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A64mesesfeact = (DateTime)(DateTime.MinValue);
                  n64mesesfeact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64mesesfeact", context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A64mesesfeact = context.localUtil.CToT( cgiGet( edtmesesfeact_Internalname));
                  n64mesesfeact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64mesesfeact", context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
               }
               n64mesesfeact = ((DateTime.MinValue==A64mesesfeact) ? true : false);
               /* Read saved values. */
               Z11mesesid = (int)(context.localUtil.CToN( cgiGet( "Z11mesesid"), ",", "."));
               Z61mesesanio = cgiGet( "Z61mesesanio");
               n61mesesanio = (String.IsNullOrEmpty(StringUtil.RTrim( A61mesesanio)) ? true : false);
               Z62mesesusuario = cgiGet( "Z62mesesusuario");
               n62mesesusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A62mesesusuario)) ? true : false);
               Z63mesesfecgre = context.localUtil.CToT( cgiGet( "Z63mesesfecgre"), 0);
               n63mesesfecgre = ((DateTime.MinValue==A63mesesfecgre) ? true : false);
               Z64mesesfeact = context.localUtil.CToT( cgiGet( "Z64mesesfeact"), 0);
               n64mesesfeact = ((DateTime.MinValue==A64mesesfeact) ? true : false);
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
                  A11mesesid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
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
               InitAll033( ) ;
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
         DisableAttributes033( ) ;
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

      protected void ResetCaption030( )
      {
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z61mesesanio = T00033_A61mesesanio[0];
               Z62mesesusuario = T00033_A62mesesusuario[0];
               Z63mesesfecgre = T00033_A63mesesfecgre[0];
               Z64mesesfeact = T00033_A64mesesfeact[0];
            }
            else
            {
               Z61mesesanio = A61mesesanio;
               Z62mesesusuario = A62mesesusuario;
               Z63mesesfecgre = A63mesesfecgre;
               Z64mesesfeact = A64mesesfeact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z11mesesid = A11mesesid;
            Z61mesesanio = A61mesesanio;
            Z62mesesusuario = A62mesesusuario;
            Z63mesesfecgre = A63mesesfecgre;
            Z64mesesfeact = A64mesesfeact;
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

      protected void Load033( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A11mesesid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A61mesesanio = T00034_A61mesesanio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61mesesanio", A61mesesanio);
            n61mesesanio = T00034_n61mesesanio[0];
            A62mesesusuario = T00034_A62mesesusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62mesesusuario", A62mesesusuario);
            n62mesesusuario = T00034_n62mesesusuario[0];
            A63mesesfecgre = T00034_A63mesesfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63mesesfecgre", context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
            n63mesesfecgre = T00034_n63mesesfecgre[0];
            A64mesesfeact = T00034_A64mesesfeact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64mesesfeact", context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
            n64mesesfeact = T00034_n64mesesfeact[0];
            ZM033( -1) ;
         }
         pr_default.close(2);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A11mesesid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A11mesesid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 1) ;
            RcdFound3 = 1;
            A11mesesid = T00033_A11mesesid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
            A61mesesanio = T00033_A61mesesanio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61mesesanio", A61mesesanio);
            n61mesesanio = T00033_n61mesesanio[0];
            A62mesesusuario = T00033_A62mesesusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62mesesusuario", A62mesesusuario);
            n62mesesusuario = T00033_n62mesesusuario[0];
            A63mesesfecgre = T00033_A63mesesfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63mesesfecgre", context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
            n63mesesfecgre = T00033_n63mesesfecgre[0];
            A64mesesfeact = T00033_A64mesesfeact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64mesesfeact", context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
            n64mesesfeact = T00033_n64mesesfeact[0];
            Z11mesesid = A11mesesid;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
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
         RcdFound3 = 0;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A11mesesid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00036_A11mesesid[0] < A11mesesid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00036_A11mesesid[0] > A11mesesid ) ) )
            {
               A11mesesid = T00036_A11mesesid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A11mesesid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11mesesid[0] > A11mesesid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11mesesid[0] < A11mesesid ) ) )
            {
               A11mesesid = T00037_A11mesesid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtmesesid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A11mesesid != Z11mesesid )
               {
                  A11mesesid = Z11mesesid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "MESESID");
                  AnyError = 1;
                  GX_FocusControl = edtmesesid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtmesesid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtmesesid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A11mesesid != Z11mesesid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtmesesid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "MESESID");
                     AnyError = 1;
                     GX_FocusControl = edtmesesid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtmesesid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
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
         if ( A11mesesid != Z11mesesid )
         {
            A11mesesid = Z11mesesid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "MESESID");
            AnyError = 1;
            GX_FocusControl = edtmesesid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtmesesid_Internalname;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "MESESID");
            AnyError = 1;
            GX_FocusControl = edtmesesid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtmesesanio_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmesesanio_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmesesanio_Internalname;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmesesanio_Internalname;
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
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound3 != 0 )
            {
               ScanNext033( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtmesesanio_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A11mesesid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MESES"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z61mesesanio, T00032_A61mesesanio[0]) != 0 ) || ( StringUtil.StrCmp(Z62mesesusuario, T00032_A62mesesusuario[0]) != 0 ) || ( Z63mesesfecgre != T00032_A63mesesfecgre[0] ) || ( Z64mesesfeact != T00032_A64mesesfeact[0] ) )
            {
               if ( StringUtil.StrCmp(Z61mesesanio, T00032_A61mesesanio[0]) != 0 )
               {
                  GXUtil.WriteLog("meses:[seudo value changed for attri]"+"mesesanio");
                  GXUtil.WriteLogRaw("Old: ",Z61mesesanio);
                  GXUtil.WriteLogRaw("Current: ",T00032_A61mesesanio[0]);
               }
               if ( StringUtil.StrCmp(Z62mesesusuario, T00032_A62mesesusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("meses:[seudo value changed for attri]"+"mesesusuario");
                  GXUtil.WriteLogRaw("Old: ",Z62mesesusuario);
                  GXUtil.WriteLogRaw("Current: ",T00032_A62mesesusuario[0]);
               }
               if ( Z63mesesfecgre != T00032_A63mesesfecgre[0] )
               {
                  GXUtil.WriteLog("meses:[seudo value changed for attri]"+"mesesfecgre");
                  GXUtil.WriteLogRaw("Old: ",Z63mesesfecgre);
                  GXUtil.WriteLogRaw("Current: ",T00032_A63mesesfecgre[0]);
               }
               if ( Z64mesesfeact != T00032_A64mesesfeact[0] )
               {
                  GXUtil.WriteLog("meses:[seudo value changed for attri]"+"mesesfeact");
                  GXUtil.WriteLogRaw("Old: ",Z64mesesfeact);
                  GXUtil.WriteLogRaw("Current: ",T00032_A64mesesfeact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MESES"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00038 */
                     pr_default.execute(6, new Object[] {A11mesesid, n61mesesanio, A61mesesanio, n62mesesusuario, A62mesesusuario, n63mesesfecgre, A63mesesfecgre, n64mesesfeact, A64mesesfeact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("MESES") ;
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
                           ResetCaption030( ) ;
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
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00039 */
                     pr_default.execute(7, new Object[] {n61mesesanio, A61mesesanio, n62mesesusuario, A62mesesusuario, n63mesesfecgre, A63mesesfecgre, n64mesesfeact, A64mesesfeact, A11mesesid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("MESES") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MESES"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption030( ) ;
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
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000310 */
                  pr_default.execute(8, new Object[] {A11mesesid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("MESES") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound3 == 0 )
                        {
                           InitAll033( ) ;
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
                        ResetCaption030( ) ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel033( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "meses");
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "meses");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Using cursor T000311 */
         pr_default.execute(9);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A11mesesid = T000311_A11mesesid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A11mesesid = T000311_A11mesesid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtmesesid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmesesid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmesesid_Enabled), 5, 0)));
         edtmesesanio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmesesanio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmesesanio_Enabled), 5, 0)));
         edtmesesusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmesesusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmesesusuario_Enabled), 5, 0)));
         edtmesesfecgre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmesesfecgre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmesesfecgre_Enabled), 5, 0)));
         edtmesesfeact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmesesfeact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmesesfeact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
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
         context.AddJavascriptSource("gxcfg.js", "?202213023372083");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("meses.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z11mesesid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11mesesid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z61mesesanio", Z61mesesanio);
         GxWebStd.gx_hidden_field( context, "Z62mesesusuario", Z62mesesusuario);
         GxWebStd.gx_hidden_field( context, "Z63mesesfecgre", context.localUtil.TToC( Z63mesesfecgre, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z64mesesfeact", context.localUtil.TToC( Z64mesesfeact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("meses.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "meses" ;
      }

      public override String GetPgmdesc( )
      {
         return "meses" ;
      }

      protected void InitializeNonKey033( )
      {
         A61mesesanio = "";
         n61mesesanio = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61mesesanio", A61mesesanio);
         n61mesesanio = (String.IsNullOrEmpty(StringUtil.RTrim( A61mesesanio)) ? true : false);
         A62mesesusuario = "";
         n62mesesusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62mesesusuario", A62mesesusuario);
         n62mesesusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A62mesesusuario)) ? true : false);
         A63mesesfecgre = (DateTime)(DateTime.MinValue);
         n63mesesfecgre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63mesesfecgre", context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
         n63mesesfecgre = ((DateTime.MinValue==A63mesesfecgre) ? true : false);
         A64mesesfeact = (DateTime)(DateTime.MinValue);
         n64mesesfeact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64mesesfeact", context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
         n64mesesfeact = ((DateTime.MinValue==A64mesesfeact) ? true : false);
         Z61mesesanio = "";
         Z62mesesusuario = "";
         Z63mesesfecgre = (DateTime)(DateTime.MinValue);
         Z64mesesfeact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll033( )
      {
         A11mesesid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11mesesid", StringUtil.LTrim( StringUtil.Str( (decimal)(A11mesesid), 9, 0)));
         InitializeNonKey033( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202213023372090");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("meses.js", "?202213023372090");
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
         edtmesesid_Internalname = "MESESID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmesesanio_Internalname = "MESESANIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmesesusuario_Internalname = "MESESUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmesesfecgre_Internalname = "MESESFECGRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmesesfeact_Internalname = "MESESFEACT";
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
         Form.Caption = "meses";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtmesesfeact_Jsonclick = "";
         edtmesesfeact_Enabled = 1;
         edtmesesfecgre_Jsonclick = "";
         edtmesesfecgre_Enabled = 1;
         edtmesesusuario_Jsonclick = "";
         edtmesesusuario_Enabled = 1;
         edtmesesanio_Jsonclick = "";
         edtmesesanio_Enabled = 1;
         edtmesesid_Jsonclick = "";
         edtmesesid_Enabled = 1;
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
         GX_FocusControl = edtmesesanio_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Mesesid( int GX_Parm1 ,
                                 String GX_Parm2 ,
                                 String GX_Parm3 ,
                                 DateTime GX_Parm4 ,
                                 DateTime GX_Parm5 )
      {
         A11mesesid = GX_Parm1;
         A61mesesanio = GX_Parm2;
         n61mesesanio = false;
         A62mesesusuario = GX_Parm3;
         n62mesesusuario = false;
         A63mesesfecgre = GX_Parm4;
         n63mesesfecgre = false;
         A64mesesfeact = GX_Parm5;
         n64mesesfeact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A61mesesanio);
         isValidOutput.Add(A62mesesusuario);
         isValidOutput.Add(context.localUtil.TToC( A63mesesfecgre, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A64mesesfeact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11mesesid), 9, 0, ",", "")));
         isValidOutput.Add(Z61mesesanio);
         isValidOutput.Add(Z62mesesusuario);
         isValidOutput.Add(context.localUtil.TToC( Z63mesesfecgre, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z64mesesfeact, 10, 8, 0, 0, "/", ":", " "));
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
         Z61mesesanio = "";
         Z62mesesusuario = "";
         Z63mesesfecgre = (DateTime)(DateTime.MinValue);
         Z64mesesfeact = (DateTime)(DateTime.MinValue);
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
         A61mesesanio = "";
         A62mesesusuario = "";
         A63mesesfecgre = (DateTime)(DateTime.MinValue);
         A64mesesfeact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00034_A11mesesid = new int[1] ;
         T00034_A61mesesanio = new String[] {""} ;
         T00034_n61mesesanio = new bool[] {false} ;
         T00034_A62mesesusuario = new String[] {""} ;
         T00034_n62mesesusuario = new bool[] {false} ;
         T00034_A63mesesfecgre = new DateTime[] {DateTime.MinValue} ;
         T00034_n63mesesfecgre = new bool[] {false} ;
         T00034_A64mesesfeact = new DateTime[] {DateTime.MinValue} ;
         T00034_n64mesesfeact = new bool[] {false} ;
         T00035_A11mesesid = new int[1] ;
         T00033_A11mesesid = new int[1] ;
         T00033_A61mesesanio = new String[] {""} ;
         T00033_n61mesesanio = new bool[] {false} ;
         T00033_A62mesesusuario = new String[] {""} ;
         T00033_n62mesesusuario = new bool[] {false} ;
         T00033_A63mesesfecgre = new DateTime[] {DateTime.MinValue} ;
         T00033_n63mesesfecgre = new bool[] {false} ;
         T00033_A64mesesfeact = new DateTime[] {DateTime.MinValue} ;
         T00033_n64mesesfeact = new bool[] {false} ;
         sMode3 = "";
         T00036_A11mesesid = new int[1] ;
         T00037_A11mesesid = new int[1] ;
         T00032_A11mesesid = new int[1] ;
         T00032_A61mesesanio = new String[] {""} ;
         T00032_n61mesesanio = new bool[] {false} ;
         T00032_A62mesesusuario = new String[] {""} ;
         T00032_n62mesesusuario = new bool[] {false} ;
         T00032_A63mesesfecgre = new DateTime[] {DateTime.MinValue} ;
         T00032_n63mesesfecgre = new bool[] {false} ;
         T00032_A64mesesfeact = new DateTime[] {DateTime.MinValue} ;
         T00032_n64mesesfeact = new bool[] {false} ;
         T000311_A11mesesid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.meses__default(),
            new Object[][] {
                new Object[] {
               T00032_A11mesesid, T00032_A61mesesanio, T00032_n61mesesanio, T00032_A62mesesusuario, T00032_n62mesesusuario, T00032_A63mesesfecgre, T00032_n63mesesfecgre, T00032_A64mesesfeact, T00032_n64mesesfeact
               }
               , new Object[] {
               T00033_A11mesesid, T00033_A61mesesanio, T00033_n61mesesanio, T00033_A62mesesusuario, T00033_n62mesesusuario, T00033_A63mesesfecgre, T00033_n63mesesfecgre, T00033_A64mesesfeact, T00033_n64mesesfeact
               }
               , new Object[] {
               T00034_A11mesesid, T00034_A61mesesanio, T00034_n61mesesanio, T00034_A62mesesusuario, T00034_n62mesesusuario, T00034_A63mesesfecgre, T00034_n63mesesfecgre, T00034_A64mesesfeact, T00034_n64mesesfeact
               }
               , new Object[] {
               T00035_A11mesesid
               }
               , new Object[] {
               T00036_A11mesesid
               }
               , new Object[] {
               T00037_A11mesesid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000311_A11mesesid
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
      private short RcdFound3 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z11mesesid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A11mesesid ;
      private int edtmesesid_Enabled ;
      private int edtmesesanio_Enabled ;
      private int edtmesesusuario_Enabled ;
      private int edtmesesfecgre_Enabled ;
      private int edtmesesfeact_Enabled ;
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
      private String edtmesesid_Internalname ;
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
      private String edtmesesid_Jsonclick ;
      private String edtmesesanio_Internalname ;
      private String edtmesesanio_Jsonclick ;
      private String edtmesesusuario_Internalname ;
      private String edtmesesusuario_Jsonclick ;
      private String edtmesesfecgre_Internalname ;
      private String edtmesesfecgre_Jsonclick ;
      private String edtmesesfeact_Internalname ;
      private String edtmesesfeact_Jsonclick ;
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
      private String sMode3 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z63mesesfecgre ;
      private DateTime Z64mesesfeact ;
      private DateTime A63mesesfecgre ;
      private DateTime A64mesesfeact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n61mesesanio ;
      private bool n62mesesusuario ;
      private bool n63mesesfecgre ;
      private bool n64mesesfeact ;
      private String Z61mesesanio ;
      private String Z62mesesusuario ;
      private String A61mesesanio ;
      private String A62mesesusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00034_A11mesesid ;
      private String[] T00034_A61mesesanio ;
      private bool[] T00034_n61mesesanio ;
      private String[] T00034_A62mesesusuario ;
      private bool[] T00034_n62mesesusuario ;
      private DateTime[] T00034_A63mesesfecgre ;
      private bool[] T00034_n63mesesfecgre ;
      private DateTime[] T00034_A64mesesfeact ;
      private bool[] T00034_n64mesesfeact ;
      private int[] T00035_A11mesesid ;
      private int[] T00033_A11mesesid ;
      private String[] T00033_A61mesesanio ;
      private bool[] T00033_n61mesesanio ;
      private String[] T00033_A62mesesusuario ;
      private bool[] T00033_n62mesesusuario ;
      private DateTime[] T00033_A63mesesfecgre ;
      private bool[] T00033_n63mesesfecgre ;
      private DateTime[] T00033_A64mesesfeact ;
      private bool[] T00033_n64mesesfeact ;
      private int[] T00036_A11mesesid ;
      private int[] T00037_A11mesesid ;
      private int[] T00032_A11mesesid ;
      private String[] T00032_A61mesesanio ;
      private bool[] T00032_n61mesesanio ;
      private String[] T00032_A62mesesusuario ;
      private bool[] T00032_n62mesesusuario ;
      private DateTime[] T00032_A63mesesfecgre ;
      private bool[] T00032_n63mesesfecgre ;
      private DateTime[] T00032_A64mesesfeact ;
      private bool[] T00032_n64mesesfeact ;
      private int[] T000311_A11mesesid ;
      private GXWebForm Form ;
   }

   public class meses__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"mesesanio",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"mesesusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"mesesfecgre",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"mesesfeact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"mesesanio",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"mesesusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"mesesfecgre",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"mesesfeact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"mesesid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT mesesid, mesesanio, mesesusuario, mesesfecgre, mesesfeact FROM public.meses WHERE mesesid = :mesesid  FOR UPDATE OF meses NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT mesesid, mesesanio, mesesusuario, mesesfecgre, mesesfeact FROM public.meses WHERE mesesid = :mesesid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT TM1.mesesid, TM1.mesesanio, TM1.mesesusuario, TM1.mesesfecgre, TM1.mesesfeact FROM public.meses TM1 WHERE TM1.mesesid = :mesesid ORDER BY TM1.mesesid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100,0,true,false )
             ,new CursorDef("T00035", "SELECT mesesid FROM public.meses WHERE mesesid = :mesesid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new CursorDef("T00036", "SELECT mesesid FROM public.meses WHERE ( mesesid > :mesesid) ORDER BY mesesid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,true )
             ,new CursorDef("T00037", "SELECT mesesid FROM public.meses WHERE ( mesesid < :mesesid) ORDER BY mesesid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,true )
             ,new CursorDef("T00038", "SAVEPOINT gxupdate;INSERT INTO public.meses(mesesid, mesesanio, mesesusuario, mesesfecgre, mesesfeact) VALUES(:mesesid, :mesesanio, :mesesusuario, :mesesfecgre, :mesesfeact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00038)
             ,new CursorDef("T00039", "SAVEPOINT gxupdate;UPDATE public.meses SET mesesanio=:mesesanio, mesesusuario=:mesesusuario, mesesfecgre=:mesesfecgre, mesesfeact=:mesesfeact  WHERE mesesid = :mesesid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00039)
             ,new CursorDef("T000310", "SAVEPOINT gxupdate;DELETE FROM public.meses  WHERE mesesid = :mesesid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000310)
             ,new CursorDef("T000311", "SELECT mesesid FROM public.meses ORDER BY mesesid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,100,0,true,false )
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
