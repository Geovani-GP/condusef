/*
               File: parametros
        Description: parametros
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:41.53
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
   public class parametros : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "parametros", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtparametrosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public parametros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public parametros( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "parametros", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_parametros.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PARAMETROSID"+"'), id:'"+"PARAMETROSID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosid_Internalname, "parametrosid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8parametrosid), 9, 0, ",", "")), ((edtparametrosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8parametrosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A8parametrosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosid_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosdsc_Internalname, "parametrosdsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosdsc_Internalname, A65parametrosdsc, StringUtil.RTrim( context.localUtil.Format( A65parametrosdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosdsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosvalor_Internalname, "parametrosvalor", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosvalor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A66parametrosvalor), 18, 0, ",", "")), ((edtparametrosvalor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A66parametrosvalor), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A66parametrosvalor), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosvalor_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosvalor_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametroscadena_Internalname, "parametroscadena", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametroscadena_Internalname, A67parametroscadena, StringUtil.RTrim( context.localUtil.Format( A67parametroscadena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametroscadena_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametroscadena_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosstatus_Internalname, "parametrosstatus", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosstatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A68parametrosstatus), 18, 0, ",", "")), ((edtparametrosstatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A68parametrosstatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A68parametrosstatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosstatus_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosstatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosuso_Internalname, "parametrosuso", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosuso_Internalname, A69parametrosuso, StringUtil.RTrim( context.localUtil.Format( A69parametrosuso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosuso_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosuso_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosusuario_Internalname, "parametrosusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtparametrosusuario_Internalname, A70parametrosusuario, StringUtil.RTrim( context.localUtil.Format( A70parametrosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosfecgre_Internalname, "parametrosfecgre", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtparametrosfecgre_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtparametrosfecgre_Internalname, context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A71parametrosfecgre, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosfecgre_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosfecgre_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_parametros.htm");
            GxWebStd.gx_bitmap( context, edtparametrosfecgre_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtparametrosfecgre_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_parametros.htm");
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
            GxWebStd.gx_label_element( context, edtparametrosfecact_Internalname, "parametrosfecact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtparametrosfecact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtparametrosfecact_Internalname, context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A72parametrosfecact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtparametrosfecact_Jsonclick, 0, "Attribute", "", "", "", 1, edtparametrosfecact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_parametros.htm");
            GxWebStd.gx_bitmap( context, edtparametrosfecact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtparametrosfecact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_parametros.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_parametros.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtparametrosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtparametrosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARAMETROSID");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8parametrosid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
               }
               else
               {
                  A8parametrosid = (int)(context.localUtil.CToN( cgiGet( edtparametrosid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
               }
               A65parametrosdsc = cgiGet( edtparametrosdsc_Internalname);
               n65parametrosdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65parametrosdsc", A65parametrosdsc);
               n65parametrosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A65parametrosdsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtparametrosvalor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtparametrosvalor_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARAMETROSVALOR");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosvalor_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A66parametrosvalor = 0;
                  n66parametrosvalor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66parametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(A66parametrosvalor), 18, 0)));
               }
               else
               {
                  A66parametrosvalor = (long)(context.localUtil.CToN( cgiGet( edtparametrosvalor_Internalname), ",", "."));
                  n66parametrosvalor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66parametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(A66parametrosvalor), 18, 0)));
               }
               n66parametrosvalor = ((0==A66parametrosvalor) ? true : false);
               A67parametroscadena = cgiGet( edtparametroscadena_Internalname);
               n67parametroscadena = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67parametroscadena", A67parametroscadena);
               n67parametroscadena = (String.IsNullOrEmpty(StringUtil.RTrim( A67parametroscadena)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtparametrosstatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtparametrosstatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARAMETROSSTATUS");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosstatus_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A68parametrosstatus = 0;
                  n68parametrosstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68parametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A68parametrosstatus), 18, 0)));
               }
               else
               {
                  A68parametrosstatus = (long)(context.localUtil.CToN( cgiGet( edtparametrosstatus_Internalname), ",", "."));
                  n68parametrosstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68parametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A68parametrosstatus), 18, 0)));
               }
               n68parametrosstatus = ((0==A68parametrosstatus) ? true : false);
               A69parametrosuso = cgiGet( edtparametrosuso_Internalname);
               n69parametrosuso = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69parametrosuso", A69parametrosuso);
               n69parametrosuso = (String.IsNullOrEmpty(StringUtil.RTrim( A69parametrosuso)) ? true : false);
               A70parametrosusuario = cgiGet( edtparametrosusuario_Internalname);
               n70parametrosusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70parametrosusuario", A70parametrosusuario);
               n70parametrosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A70parametrosusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtparametrosfecgre_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"parametrosfecgre"}), 1, "PARAMETROSFECGRE");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosfecgre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A71parametrosfecgre = (DateTime)(DateTime.MinValue);
                  n71parametrosfecgre = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71parametrosfecgre", context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A71parametrosfecgre = context.localUtil.CToT( cgiGet( edtparametrosfecgre_Internalname));
                  n71parametrosfecgre = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71parametrosfecgre", context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
               }
               n71parametrosfecgre = ((DateTime.MinValue==A71parametrosfecgre) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtparametrosfecact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"parametrosfecact"}), 1, "PARAMETROSFECACT");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosfecact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A72parametrosfecact = (DateTime)(DateTime.MinValue);
                  n72parametrosfecact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72parametrosfecact", context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A72parametrosfecact = context.localUtil.CToT( cgiGet( edtparametrosfecact_Internalname));
                  n72parametrosfecact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72parametrosfecact", context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
               }
               n72parametrosfecact = ((DateTime.MinValue==A72parametrosfecact) ? true : false);
               /* Read saved values. */
               Z8parametrosid = (int)(context.localUtil.CToN( cgiGet( "Z8parametrosid"), ",", "."));
               Z65parametrosdsc = cgiGet( "Z65parametrosdsc");
               n65parametrosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A65parametrosdsc)) ? true : false);
               Z66parametrosvalor = (long)(context.localUtil.CToN( cgiGet( "Z66parametrosvalor"), ",", "."));
               n66parametrosvalor = ((0==A66parametrosvalor) ? true : false);
               Z67parametroscadena = cgiGet( "Z67parametroscadena");
               n67parametroscadena = (String.IsNullOrEmpty(StringUtil.RTrim( A67parametroscadena)) ? true : false);
               Z68parametrosstatus = (long)(context.localUtil.CToN( cgiGet( "Z68parametrosstatus"), ",", "."));
               n68parametrosstatus = ((0==A68parametrosstatus) ? true : false);
               Z69parametrosuso = cgiGet( "Z69parametrosuso");
               n69parametrosuso = (String.IsNullOrEmpty(StringUtil.RTrim( A69parametrosuso)) ? true : false);
               Z70parametrosusuario = cgiGet( "Z70parametrosusuario");
               n70parametrosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A70parametrosusuario)) ? true : false);
               Z71parametrosfecgre = context.localUtil.CToT( cgiGet( "Z71parametrosfecgre"), 0);
               n71parametrosfecgre = ((DateTime.MinValue==A71parametrosfecgre) ? true : false);
               Z72parametrosfecact = context.localUtil.CToT( cgiGet( "Z72parametrosfecact"), 0);
               n72parametrosfecact = ((DateTime.MinValue==A72parametrosfecact) ? true : false);
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
                  A8parametrosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
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
               InitAll022( ) ;
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
         DisableAttributes022( ) ;
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

      protected void ResetCaption020( )
      {
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z65parametrosdsc = T00023_A65parametrosdsc[0];
               Z66parametrosvalor = T00023_A66parametrosvalor[0];
               Z67parametroscadena = T00023_A67parametroscadena[0];
               Z68parametrosstatus = T00023_A68parametrosstatus[0];
               Z69parametrosuso = T00023_A69parametrosuso[0];
               Z70parametrosusuario = T00023_A70parametrosusuario[0];
               Z71parametrosfecgre = T00023_A71parametrosfecgre[0];
               Z72parametrosfecact = T00023_A72parametrosfecact[0];
            }
            else
            {
               Z65parametrosdsc = A65parametrosdsc;
               Z66parametrosvalor = A66parametrosvalor;
               Z67parametroscadena = A67parametroscadena;
               Z68parametrosstatus = A68parametrosstatus;
               Z69parametrosuso = A69parametrosuso;
               Z70parametrosusuario = A70parametrosusuario;
               Z71parametrosfecgre = A71parametrosfecgre;
               Z72parametrosfecact = A72parametrosfecact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z8parametrosid = A8parametrosid;
            Z65parametrosdsc = A65parametrosdsc;
            Z66parametrosvalor = A66parametrosvalor;
            Z67parametroscadena = A67parametroscadena;
            Z68parametrosstatus = A68parametrosstatus;
            Z69parametrosuso = A69parametrosuso;
            Z70parametrosusuario = A70parametrosusuario;
            Z71parametrosfecgre = A71parametrosfecgre;
            Z72parametrosfecact = A72parametrosfecact;
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

      protected void Load022( )
      {
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A8parametrosid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound2 = 1;
            A65parametrosdsc = T00024_A65parametrosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65parametrosdsc", A65parametrosdsc);
            n65parametrosdsc = T00024_n65parametrosdsc[0];
            A66parametrosvalor = T00024_A66parametrosvalor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66parametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(A66parametrosvalor), 18, 0)));
            n66parametrosvalor = T00024_n66parametrosvalor[0];
            A67parametroscadena = T00024_A67parametroscadena[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67parametroscadena", A67parametroscadena);
            n67parametroscadena = T00024_n67parametroscadena[0];
            A68parametrosstatus = T00024_A68parametrosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68parametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A68parametrosstatus), 18, 0)));
            n68parametrosstatus = T00024_n68parametrosstatus[0];
            A69parametrosuso = T00024_A69parametrosuso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69parametrosuso", A69parametrosuso);
            n69parametrosuso = T00024_n69parametrosuso[0];
            A70parametrosusuario = T00024_A70parametrosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70parametrosusuario", A70parametrosusuario);
            n70parametrosusuario = T00024_n70parametrosusuario[0];
            A71parametrosfecgre = T00024_A71parametrosfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71parametrosfecgre", context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
            n71parametrosfecgre = T00024_n71parametrosfecgre[0];
            A72parametrosfecact = T00024_A72parametrosfecact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72parametrosfecact", context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
            n72parametrosfecact = T00024_n72parametrosfecact[0];
            ZM022( -1) ;
         }
         pr_default.close(2);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors022( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A8parametrosid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A8parametrosid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 1) ;
            RcdFound2 = 1;
            A8parametrosid = T00023_A8parametrosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
            A65parametrosdsc = T00023_A65parametrosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65parametrosdsc", A65parametrosdsc);
            n65parametrosdsc = T00023_n65parametrosdsc[0];
            A66parametrosvalor = T00023_A66parametrosvalor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66parametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(A66parametrosvalor), 18, 0)));
            n66parametrosvalor = T00023_n66parametrosvalor[0];
            A67parametroscadena = T00023_A67parametroscadena[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67parametroscadena", A67parametroscadena);
            n67parametroscadena = T00023_n67parametroscadena[0];
            A68parametrosstatus = T00023_A68parametrosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68parametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A68parametrosstatus), 18, 0)));
            n68parametrosstatus = T00023_n68parametrosstatus[0];
            A69parametrosuso = T00023_A69parametrosuso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69parametrosuso", A69parametrosuso);
            n69parametrosuso = T00023_n69parametrosuso[0];
            A70parametrosusuario = T00023_A70parametrosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70parametrosusuario", A70parametrosusuario);
            n70parametrosusuario = T00023_n70parametrosusuario[0];
            A71parametrosfecgre = T00023_A71parametrosfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71parametrosfecgre", context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
            n71parametrosfecgre = T00023_n71parametrosfecgre[0];
            A72parametrosfecact = T00023_A72parametrosfecact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72parametrosfecact", context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
            n72parametrosfecact = T00023_n72parametrosfecact[0];
            Z8parametrosid = A8parametrosid;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
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
         RcdFound2 = 0;
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A8parametrosid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00026_A8parametrosid[0] < A8parametrosid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00026_A8parametrosid[0] > A8parametrosid ) ) )
            {
               A8parametrosid = T00026_A8parametrosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A8parametrosid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00027_A8parametrosid[0] > A8parametrosid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00027_A8parametrosid[0] < A8parametrosid ) ) )
            {
               A8parametrosid = T00027_A8parametrosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtparametrosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert022( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A8parametrosid != Z8parametrosid )
               {
                  A8parametrosid = Z8parametrosid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PARAMETROSID");
                  AnyError = 1;
                  GX_FocusControl = edtparametrosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtparametrosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update022( ) ;
                  GX_FocusControl = edtparametrosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A8parametrosid != Z8parametrosid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtparametrosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PARAMETROSID");
                     AnyError = 1;
                     GX_FocusControl = edtparametrosid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtparametrosid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert022( ) ;
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
         if ( A8parametrosid != Z8parametrosid )
         {
            A8parametrosid = Z8parametrosid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PARAMETROSID");
            AnyError = 1;
            GX_FocusControl = edtparametrosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtparametrosid_Internalname;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PARAMETROSID");
            AnyError = 1;
            GX_FocusControl = edtparametrosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtparametrosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtparametrosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtparametrosdsc_Internalname;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtparametrosdsc_Internalname;
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
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound2 != 0 )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtparametrosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A8parametrosid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PARAMETROS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z65parametrosdsc, T00022_A65parametrosdsc[0]) != 0 ) || ( Z66parametrosvalor != T00022_A66parametrosvalor[0] ) || ( StringUtil.StrCmp(Z67parametroscadena, T00022_A67parametroscadena[0]) != 0 ) || ( Z68parametrosstatus != T00022_A68parametrosstatus[0] ) || ( StringUtil.StrCmp(Z69parametrosuso, T00022_A69parametrosuso[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z70parametrosusuario, T00022_A70parametrosusuario[0]) != 0 ) || ( Z71parametrosfecgre != T00022_A71parametrosfecgre[0] ) || ( Z72parametrosfecact != T00022_A72parametrosfecact[0] ) )
            {
               if ( StringUtil.StrCmp(Z65parametrosdsc, T00022_A65parametrosdsc[0]) != 0 )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosdsc");
                  GXUtil.WriteLogRaw("Old: ",Z65parametrosdsc);
                  GXUtil.WriteLogRaw("Current: ",T00022_A65parametrosdsc[0]);
               }
               if ( Z66parametrosvalor != T00022_A66parametrosvalor[0] )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosvalor");
                  GXUtil.WriteLogRaw("Old: ",Z66parametrosvalor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A66parametrosvalor[0]);
               }
               if ( StringUtil.StrCmp(Z67parametroscadena, T00022_A67parametroscadena[0]) != 0 )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametroscadena");
                  GXUtil.WriteLogRaw("Old: ",Z67parametroscadena);
                  GXUtil.WriteLogRaw("Current: ",T00022_A67parametroscadena[0]);
               }
               if ( Z68parametrosstatus != T00022_A68parametrosstatus[0] )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosstatus");
                  GXUtil.WriteLogRaw("Old: ",Z68parametrosstatus);
                  GXUtil.WriteLogRaw("Current: ",T00022_A68parametrosstatus[0]);
               }
               if ( StringUtil.StrCmp(Z69parametrosuso, T00022_A69parametrosuso[0]) != 0 )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosuso");
                  GXUtil.WriteLogRaw("Old: ",Z69parametrosuso);
                  GXUtil.WriteLogRaw("Current: ",T00022_A69parametrosuso[0]);
               }
               if ( StringUtil.StrCmp(Z70parametrosusuario, T00022_A70parametrosusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosusuario");
                  GXUtil.WriteLogRaw("Old: ",Z70parametrosusuario);
                  GXUtil.WriteLogRaw("Current: ",T00022_A70parametrosusuario[0]);
               }
               if ( Z71parametrosfecgre != T00022_A71parametrosfecgre[0] )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosfecgre");
                  GXUtil.WriteLogRaw("Old: ",Z71parametrosfecgre);
                  GXUtil.WriteLogRaw("Current: ",T00022_A71parametrosfecgre[0]);
               }
               if ( Z72parametrosfecact != T00022_A72parametrosfecact[0] )
               {
                  GXUtil.WriteLog("parametros:[seudo value changed for attri]"+"parametrosfecact");
                  GXUtil.WriteLogRaw("Old: ",Z72parametrosfecact);
                  GXUtil.WriteLogRaw("Current: ",T00022_A72parametrosfecact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PARAMETROS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00028 */
                     pr_default.execute(6, new Object[] {A8parametrosid, n65parametrosdsc, A65parametrosdsc, n66parametrosvalor, A66parametrosvalor, n67parametroscadena, A67parametroscadena, n68parametrosstatus, A68parametrosstatus, n69parametrosuso, A69parametrosuso, n70parametrosusuario, A70parametrosusuario, n71parametrosfecgre, A71parametrosfecgre, n72parametrosfecact, A72parametrosfecact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("PARAMETROS") ;
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
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00029 */
                     pr_default.execute(7, new Object[] {n65parametrosdsc, A65parametrosdsc, n66parametrosvalor, A66parametrosvalor, n67parametroscadena, A67parametroscadena, n68parametrosstatus, A68parametrosstatus, n69parametrosuso, A69parametrosuso, n70parametrosusuario, A70parametrosusuario, n71parametrosfecgre, A71parametrosfecgre, n72parametrosfecact, A72parametrosfecact, A8parametrosid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("PARAMETROS") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PARAMETROS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption020( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000210 */
                  pr_default.execute(8, new Object[] {A8parametrosid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("PARAMETROS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound2 == 0 )
                        {
                           InitAll022( ) ;
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
                        ResetCaption020( ) ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "parametros");
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "parametros");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart022( )
      {
         /* Using cursor T000211 */
         pr_default.execute(9);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound2 = 1;
            A8parametrosid = T000211_A8parametrosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound2 = 1;
            A8parametrosid = T000211_A8parametrosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtparametrosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosid_Enabled), 5, 0)));
         edtparametrosdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosdsc_Enabled), 5, 0)));
         edtparametrosvalor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosvalor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosvalor_Enabled), 5, 0)));
         edtparametroscadena_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametroscadena_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametroscadena_Enabled), 5, 0)));
         edtparametrosstatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosstatus_Enabled), 5, 0)));
         edtparametrosuso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosuso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosuso_Enabled), 5, 0)));
         edtparametrosusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosusuario_Enabled), 5, 0)));
         edtparametrosfecgre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosfecgre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosfecgre_Enabled), 5, 0)));
         edtparametrosfecact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtparametrosfecact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtparametrosfecact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.AddJavascriptSource("gxcfg.js", "?2022215584227");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("parametros.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z8parametrosid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8parametrosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z65parametrosdsc", Z65parametrosdsc);
         GxWebStd.gx_hidden_field( context, "Z66parametrosvalor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z66parametrosvalor), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z67parametroscadena", Z67parametroscadena);
         GxWebStd.gx_hidden_field( context, "Z68parametrosstatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z68parametrosstatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z69parametrosuso", Z69parametrosuso);
         GxWebStd.gx_hidden_field( context, "Z70parametrosusuario", Z70parametrosusuario);
         GxWebStd.gx_hidden_field( context, "Z71parametrosfecgre", context.localUtil.TToC( Z71parametrosfecgre, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z72parametrosfecact", context.localUtil.TToC( Z72parametrosfecact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("parametros.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "parametros" ;
      }

      public override String GetPgmdesc( )
      {
         return "parametros" ;
      }

      protected void InitializeNonKey022( )
      {
         A65parametrosdsc = "";
         n65parametrosdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65parametrosdsc", A65parametrosdsc);
         n65parametrosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A65parametrosdsc)) ? true : false);
         A66parametrosvalor = 0;
         n66parametrosvalor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66parametrosvalor", StringUtil.LTrim( StringUtil.Str( (decimal)(A66parametrosvalor), 18, 0)));
         n66parametrosvalor = ((0==A66parametrosvalor) ? true : false);
         A67parametroscadena = "";
         n67parametroscadena = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67parametroscadena", A67parametroscadena);
         n67parametroscadena = (String.IsNullOrEmpty(StringUtil.RTrim( A67parametroscadena)) ? true : false);
         A68parametrosstatus = 0;
         n68parametrosstatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68parametrosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A68parametrosstatus), 18, 0)));
         n68parametrosstatus = ((0==A68parametrosstatus) ? true : false);
         A69parametrosuso = "";
         n69parametrosuso = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69parametrosuso", A69parametrosuso);
         n69parametrosuso = (String.IsNullOrEmpty(StringUtil.RTrim( A69parametrosuso)) ? true : false);
         A70parametrosusuario = "";
         n70parametrosusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70parametrosusuario", A70parametrosusuario);
         n70parametrosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A70parametrosusuario)) ? true : false);
         A71parametrosfecgre = (DateTime)(DateTime.MinValue);
         n71parametrosfecgre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71parametrosfecgre", context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
         n71parametrosfecgre = ((DateTime.MinValue==A71parametrosfecgre) ? true : false);
         A72parametrosfecact = (DateTime)(DateTime.MinValue);
         n72parametrosfecact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72parametrosfecact", context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
         n72parametrosfecact = ((DateTime.MinValue==A72parametrosfecact) ? true : false);
         Z65parametrosdsc = "";
         Z66parametrosvalor = 0;
         Z67parametroscadena = "";
         Z68parametrosstatus = 0;
         Z69parametrosuso = "";
         Z70parametrosusuario = "";
         Z71parametrosfecgre = (DateTime)(DateTime.MinValue);
         Z72parametrosfecact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll022( )
      {
         A8parametrosid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8parametrosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A8parametrosid), 9, 0)));
         InitializeNonKey022( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215584231");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("parametros.js", "?2022215584232");
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
         edtparametrosid_Internalname = "PARAMETROSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosdsc_Internalname = "PARAMETROSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosvalor_Internalname = "PARAMETROSVALOR";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametroscadena_Internalname = "PARAMETROSCADENA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosstatus_Internalname = "PARAMETROSSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosuso_Internalname = "PARAMETROSUSO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosusuario_Internalname = "PARAMETROSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosfecgre_Internalname = "PARAMETROSFECGRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtparametrosfecact_Internalname = "PARAMETROSFECACT";
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
         Form.Caption = "parametros";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtparametrosfecact_Jsonclick = "";
         edtparametrosfecact_Enabled = 1;
         edtparametrosfecgre_Jsonclick = "";
         edtparametrosfecgre_Enabled = 1;
         edtparametrosusuario_Jsonclick = "";
         edtparametrosusuario_Enabled = 1;
         edtparametrosuso_Jsonclick = "";
         edtparametrosuso_Enabled = 1;
         edtparametrosstatus_Jsonclick = "";
         edtparametrosstatus_Enabled = 1;
         edtparametroscadena_Jsonclick = "";
         edtparametroscadena_Enabled = 1;
         edtparametrosvalor_Jsonclick = "";
         edtparametrosvalor_Enabled = 1;
         edtparametrosdsc_Jsonclick = "";
         edtparametrosdsc_Enabled = 1;
         edtparametrosid_Jsonclick = "";
         edtparametrosid_Enabled = 1;
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
         GX_FocusControl = edtparametrosdsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Parametrosid( int GX_Parm1 ,
                                      String GX_Parm2 ,
                                      long GX_Parm3 ,
                                      String GX_Parm4 ,
                                      long GX_Parm5 ,
                                      String GX_Parm6 ,
                                      String GX_Parm7 ,
                                      DateTime GX_Parm8 ,
                                      DateTime GX_Parm9 )
      {
         A8parametrosid = GX_Parm1;
         A65parametrosdsc = GX_Parm2;
         n65parametrosdsc = false;
         A66parametrosvalor = GX_Parm3;
         n66parametrosvalor = false;
         A67parametroscadena = GX_Parm4;
         n67parametroscadena = false;
         A68parametrosstatus = GX_Parm5;
         n68parametrosstatus = false;
         A69parametrosuso = GX_Parm6;
         n69parametrosuso = false;
         A70parametrosusuario = GX_Parm7;
         n70parametrosusuario = false;
         A71parametrosfecgre = GX_Parm8;
         n71parametrosfecgre = false;
         A72parametrosfecact = GX_Parm9;
         n72parametrosfecact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A65parametrosdsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A66parametrosvalor), 18, 0, ".", "")));
         isValidOutput.Add(A67parametroscadena);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A68parametrosstatus), 18, 0, ".", "")));
         isValidOutput.Add(A69parametrosuso);
         isValidOutput.Add(A70parametrosusuario);
         isValidOutput.Add(context.localUtil.TToC( A71parametrosfecgre, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A72parametrosfecact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8parametrosid), 9, 0, ",", "")));
         isValidOutput.Add(Z65parametrosdsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z66parametrosvalor), 18, 0, ",", "")));
         isValidOutput.Add(Z67parametroscadena);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z68parametrosstatus), 18, 0, ",", "")));
         isValidOutput.Add(Z69parametrosuso);
         isValidOutput.Add(Z70parametrosusuario);
         isValidOutput.Add(context.localUtil.TToC( Z71parametrosfecgre, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z72parametrosfecact, 10, 8, 0, 0, "/", ":", " "));
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
         Z65parametrosdsc = "";
         Z67parametroscadena = "";
         Z69parametrosuso = "";
         Z70parametrosusuario = "";
         Z71parametrosfecgre = (DateTime)(DateTime.MinValue);
         Z72parametrosfecact = (DateTime)(DateTime.MinValue);
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
         A65parametrosdsc = "";
         A67parametroscadena = "";
         A69parametrosuso = "";
         A70parametrosusuario = "";
         A71parametrosfecgre = (DateTime)(DateTime.MinValue);
         A72parametrosfecact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00024_A8parametrosid = new int[1] ;
         T00024_A65parametrosdsc = new String[] {""} ;
         T00024_n65parametrosdsc = new bool[] {false} ;
         T00024_A66parametrosvalor = new long[1] ;
         T00024_n66parametrosvalor = new bool[] {false} ;
         T00024_A67parametroscadena = new String[] {""} ;
         T00024_n67parametroscadena = new bool[] {false} ;
         T00024_A68parametrosstatus = new long[1] ;
         T00024_n68parametrosstatus = new bool[] {false} ;
         T00024_A69parametrosuso = new String[] {""} ;
         T00024_n69parametrosuso = new bool[] {false} ;
         T00024_A70parametrosusuario = new String[] {""} ;
         T00024_n70parametrosusuario = new bool[] {false} ;
         T00024_A71parametrosfecgre = new DateTime[] {DateTime.MinValue} ;
         T00024_n71parametrosfecgre = new bool[] {false} ;
         T00024_A72parametrosfecact = new DateTime[] {DateTime.MinValue} ;
         T00024_n72parametrosfecact = new bool[] {false} ;
         T00025_A8parametrosid = new int[1] ;
         T00023_A8parametrosid = new int[1] ;
         T00023_A65parametrosdsc = new String[] {""} ;
         T00023_n65parametrosdsc = new bool[] {false} ;
         T00023_A66parametrosvalor = new long[1] ;
         T00023_n66parametrosvalor = new bool[] {false} ;
         T00023_A67parametroscadena = new String[] {""} ;
         T00023_n67parametroscadena = new bool[] {false} ;
         T00023_A68parametrosstatus = new long[1] ;
         T00023_n68parametrosstatus = new bool[] {false} ;
         T00023_A69parametrosuso = new String[] {""} ;
         T00023_n69parametrosuso = new bool[] {false} ;
         T00023_A70parametrosusuario = new String[] {""} ;
         T00023_n70parametrosusuario = new bool[] {false} ;
         T00023_A71parametrosfecgre = new DateTime[] {DateTime.MinValue} ;
         T00023_n71parametrosfecgre = new bool[] {false} ;
         T00023_A72parametrosfecact = new DateTime[] {DateTime.MinValue} ;
         T00023_n72parametrosfecact = new bool[] {false} ;
         sMode2 = "";
         T00026_A8parametrosid = new int[1] ;
         T00027_A8parametrosid = new int[1] ;
         T00022_A8parametrosid = new int[1] ;
         T00022_A65parametrosdsc = new String[] {""} ;
         T00022_n65parametrosdsc = new bool[] {false} ;
         T00022_A66parametrosvalor = new long[1] ;
         T00022_n66parametrosvalor = new bool[] {false} ;
         T00022_A67parametroscadena = new String[] {""} ;
         T00022_n67parametroscadena = new bool[] {false} ;
         T00022_A68parametrosstatus = new long[1] ;
         T00022_n68parametrosstatus = new bool[] {false} ;
         T00022_A69parametrosuso = new String[] {""} ;
         T00022_n69parametrosuso = new bool[] {false} ;
         T00022_A70parametrosusuario = new String[] {""} ;
         T00022_n70parametrosusuario = new bool[] {false} ;
         T00022_A71parametrosfecgre = new DateTime[] {DateTime.MinValue} ;
         T00022_n71parametrosfecgre = new bool[] {false} ;
         T00022_A72parametrosfecact = new DateTime[] {DateTime.MinValue} ;
         T00022_n72parametrosfecact = new bool[] {false} ;
         T000211_A8parametrosid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.parametros__default(),
            new Object[][] {
                new Object[] {
               T00022_A8parametrosid, T00022_A65parametrosdsc, T00022_n65parametrosdsc, T00022_A66parametrosvalor, T00022_n66parametrosvalor, T00022_A67parametroscadena, T00022_n67parametroscadena, T00022_A68parametrosstatus, T00022_n68parametrosstatus, T00022_A69parametrosuso,
               T00022_n69parametrosuso, T00022_A70parametrosusuario, T00022_n70parametrosusuario, T00022_A71parametrosfecgre, T00022_n71parametrosfecgre, T00022_A72parametrosfecact, T00022_n72parametrosfecact
               }
               , new Object[] {
               T00023_A8parametrosid, T00023_A65parametrosdsc, T00023_n65parametrosdsc, T00023_A66parametrosvalor, T00023_n66parametrosvalor, T00023_A67parametroscadena, T00023_n67parametroscadena, T00023_A68parametrosstatus, T00023_n68parametrosstatus, T00023_A69parametrosuso,
               T00023_n69parametrosuso, T00023_A70parametrosusuario, T00023_n70parametrosusuario, T00023_A71parametrosfecgre, T00023_n71parametrosfecgre, T00023_A72parametrosfecact, T00023_n72parametrosfecact
               }
               , new Object[] {
               T00024_A8parametrosid, T00024_A65parametrosdsc, T00024_n65parametrosdsc, T00024_A66parametrosvalor, T00024_n66parametrosvalor, T00024_A67parametroscadena, T00024_n67parametroscadena, T00024_A68parametrosstatus, T00024_n68parametrosstatus, T00024_A69parametrosuso,
               T00024_n69parametrosuso, T00024_A70parametrosusuario, T00024_n70parametrosusuario, T00024_A71parametrosfecgre, T00024_n71parametrosfecgre, T00024_A72parametrosfecact, T00024_n72parametrosfecact
               }
               , new Object[] {
               T00025_A8parametrosid
               }
               , new Object[] {
               T00026_A8parametrosid
               }
               , new Object[] {
               T00027_A8parametrosid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000211_A8parametrosid
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
      private short RcdFound2 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z8parametrosid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A8parametrosid ;
      private int edtparametrosid_Enabled ;
      private int edtparametrosdsc_Enabled ;
      private int edtparametrosvalor_Enabled ;
      private int edtparametroscadena_Enabled ;
      private int edtparametrosstatus_Enabled ;
      private int edtparametrosuso_Enabled ;
      private int edtparametrosusuario_Enabled ;
      private int edtparametrosfecgre_Enabled ;
      private int edtparametrosfecact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z66parametrosvalor ;
      private long Z68parametrosstatus ;
      private long A66parametrosvalor ;
      private long A68parametrosstatus ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtparametrosid_Internalname ;
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
      private String edtparametrosid_Jsonclick ;
      private String edtparametrosdsc_Internalname ;
      private String edtparametrosdsc_Jsonclick ;
      private String edtparametrosvalor_Internalname ;
      private String edtparametrosvalor_Jsonclick ;
      private String edtparametroscadena_Internalname ;
      private String edtparametroscadena_Jsonclick ;
      private String edtparametrosstatus_Internalname ;
      private String edtparametrosstatus_Jsonclick ;
      private String edtparametrosuso_Internalname ;
      private String edtparametrosuso_Jsonclick ;
      private String edtparametrosusuario_Internalname ;
      private String edtparametrosusuario_Jsonclick ;
      private String edtparametrosfecgre_Internalname ;
      private String edtparametrosfecgre_Jsonclick ;
      private String edtparametrosfecact_Internalname ;
      private String edtparametrosfecact_Jsonclick ;
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
      private String sMode2 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z71parametrosfecgre ;
      private DateTime Z72parametrosfecact ;
      private DateTime A71parametrosfecgre ;
      private DateTime A72parametrosfecact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n65parametrosdsc ;
      private bool n66parametrosvalor ;
      private bool n67parametroscadena ;
      private bool n68parametrosstatus ;
      private bool n69parametrosuso ;
      private bool n70parametrosusuario ;
      private bool n71parametrosfecgre ;
      private bool n72parametrosfecact ;
      private bool Gx_longc ;
      private String Z65parametrosdsc ;
      private String Z67parametroscadena ;
      private String Z69parametrosuso ;
      private String Z70parametrosusuario ;
      private String A65parametrosdsc ;
      private String A67parametroscadena ;
      private String A69parametrosuso ;
      private String A70parametrosusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00024_A8parametrosid ;
      private String[] T00024_A65parametrosdsc ;
      private bool[] T00024_n65parametrosdsc ;
      private long[] T00024_A66parametrosvalor ;
      private bool[] T00024_n66parametrosvalor ;
      private String[] T00024_A67parametroscadena ;
      private bool[] T00024_n67parametroscadena ;
      private long[] T00024_A68parametrosstatus ;
      private bool[] T00024_n68parametrosstatus ;
      private String[] T00024_A69parametrosuso ;
      private bool[] T00024_n69parametrosuso ;
      private String[] T00024_A70parametrosusuario ;
      private bool[] T00024_n70parametrosusuario ;
      private DateTime[] T00024_A71parametrosfecgre ;
      private bool[] T00024_n71parametrosfecgre ;
      private DateTime[] T00024_A72parametrosfecact ;
      private bool[] T00024_n72parametrosfecact ;
      private int[] T00025_A8parametrosid ;
      private int[] T00023_A8parametrosid ;
      private String[] T00023_A65parametrosdsc ;
      private bool[] T00023_n65parametrosdsc ;
      private long[] T00023_A66parametrosvalor ;
      private bool[] T00023_n66parametrosvalor ;
      private String[] T00023_A67parametroscadena ;
      private bool[] T00023_n67parametroscadena ;
      private long[] T00023_A68parametrosstatus ;
      private bool[] T00023_n68parametrosstatus ;
      private String[] T00023_A69parametrosuso ;
      private bool[] T00023_n69parametrosuso ;
      private String[] T00023_A70parametrosusuario ;
      private bool[] T00023_n70parametrosusuario ;
      private DateTime[] T00023_A71parametrosfecgre ;
      private bool[] T00023_n71parametrosfecgre ;
      private DateTime[] T00023_A72parametrosfecact ;
      private bool[] T00023_n72parametrosfecact ;
      private int[] T00026_A8parametrosid ;
      private int[] T00027_A8parametrosid ;
      private int[] T00022_A8parametrosid ;
      private String[] T00022_A65parametrosdsc ;
      private bool[] T00022_n65parametrosdsc ;
      private long[] T00022_A66parametrosvalor ;
      private bool[] T00022_n66parametrosvalor ;
      private String[] T00022_A67parametroscadena ;
      private bool[] T00022_n67parametroscadena ;
      private long[] T00022_A68parametrosstatus ;
      private bool[] T00022_n68parametrosstatus ;
      private String[] T00022_A69parametrosuso ;
      private bool[] T00022_n69parametrosuso ;
      private String[] T00022_A70parametrosusuario ;
      private bool[] T00022_n70parametrosusuario ;
      private DateTime[] T00022_A71parametrosfecgre ;
      private bool[] T00022_n71parametrosfecgre ;
      private DateTime[] T00022_A72parametrosfecact ;
      private bool[] T00022_n72parametrosfecact ;
      private int[] T000211_A8parametrosid ;
      private GXWebForm Form ;
   }

   public class parametros__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"parametrosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"parametrosvalor",NpgsqlDbType.Real,18,0} ,
          new Object[] {"parametroscadena",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"parametrosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"parametrosuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"parametrosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"parametrosfecgre",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"parametrosfecact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"parametrosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"parametrosvalor",NpgsqlDbType.Real,18,0} ,
          new Object[] {"parametroscadena",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"parametrosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"parametrosuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"parametrosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"parametrosfecgre",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"parametrosfecact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"parametrosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT parametrosid, parametrosdsc, parametrosvalor, parametroscadena, parametrosstatus, parametrosuso, parametrosusuario, parametrosfecgre, parametrosfecact FROM public.parametros WHERE parametrosid = :parametrosid  FOR UPDATE OF parametros NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT parametrosid, parametrosdsc, parametrosvalor, parametroscadena, parametrosstatus, parametrosuso, parametrosusuario, parametrosfecgre, parametrosfecact FROM public.parametros WHERE parametrosid = :parametrosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT TM1.parametrosid, TM1.parametrosdsc, TM1.parametrosvalor, TM1.parametroscadena, TM1.parametrosstatus, TM1.parametrosuso, TM1.parametrosusuario, TM1.parametrosfecgre, TM1.parametrosfecact FROM public.parametros TM1 WHERE TM1.parametrosid = :parametrosid ORDER BY TM1.parametrosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,100,0,true,false )
             ,new CursorDef("T00025", "SELECT parametrosid FROM public.parametros WHERE parametrosid = :parametrosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,false )
             ,new CursorDef("T00026", "SELECT parametrosid FROM public.parametros WHERE ( parametrosid > :parametrosid) ORDER BY parametrosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,true )
             ,new CursorDef("T00027", "SELECT parametrosid FROM public.parametros WHERE ( parametrosid < :parametrosid) ORDER BY parametrosid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,true )
             ,new CursorDef("T00028", "SAVEPOINT gxupdate;INSERT INTO public.parametros(parametrosid, parametrosdsc, parametrosvalor, parametroscadena, parametrosstatus, parametrosuso, parametrosusuario, parametrosfecgre, parametrosfecact) VALUES(:parametrosid, :parametrosdsc, :parametrosvalor, :parametroscadena, :parametrosstatus, :parametrosuso, :parametrosusuario, :parametrosfecgre, :parametrosfecact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00028)
             ,new CursorDef("T00029", "SAVEPOINT gxupdate;UPDATE public.parametros SET parametrosdsc=:parametrosdsc, parametrosvalor=:parametrosvalor, parametroscadena=:parametroscadena, parametrosstatus=:parametrosstatus, parametrosuso=:parametrosuso, parametrosusuario=:parametrosusuario, parametrosfecgre=:parametrosfecgre, parametrosfecact=:parametrosfecact  WHERE parametrosid = :parametrosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00029)
             ,new CursorDef("T000210", "SAVEPOINT gxupdate;DELETE FROM public.parametros  WHERE parametrosid = :parametrosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000210)
             ,new CursorDef("T000211", "SELECT parametrosid FROM public.parametros ORDER BY parametrosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,100,0,true,false )
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
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
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
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (long)parms[4]);
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
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[16]);
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (long)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[15]);
                }
                stmt.SetParameter(9, (int)parms[16]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
