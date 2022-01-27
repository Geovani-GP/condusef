/*
               File: proveedores
        Description: proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:7:24.36
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
   public class proveedores : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "proveedores", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtproveedoresid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public proveedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public proveedores( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "proveedores", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_proveedores.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PROVEEDORESID"+"'), id:'"+"PROVEEDORESID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresid_Internalname, "proveedoresid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")), ((edtproveedoresid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresid_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresnombre_Internalname, "proveedoresnombre", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresnombre_Internalname, A126proveedoresnombre, StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresnombre_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresnombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresdireccion_Internalname, "proveedoresdireccion", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresdireccion_Internalname, A127proveedoresdireccion, StringUtil.RTrim( context.localUtil.Format( A127proveedoresdireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresdireccion_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresdireccion_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedorescolonia_Internalname, "proveedorescolonia", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedorescolonia_Internalname, A128proveedorescolonia, StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedorescolonia_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedorescolonia_Enabled, 0, "text", "", 25, "chr", 1, "row", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedorescodigopostal_Internalname, "proveedorescodigopostal", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedorescodigopostal_Internalname, A129proveedorescodigopostal, StringUtil.RTrim( context.localUtil.Format( A129proveedorescodigopostal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedorescodigopostal_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedorescodigopostal_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresmunicipio_Internalname, "proveedoresmunicipio", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresmunicipio_Internalname, A130proveedoresmunicipio, StringUtil.RTrim( context.localUtil.Format( A130proveedoresmunicipio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresmunicipio_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresmunicipio_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedorestado_Internalname, "proveedorestado", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedorestado_Internalname, A131proveedorestado, StringUtil.RTrim( context.localUtil.Format( A131proveedorestado, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedorestado_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedorestado_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedorestelefono1_Internalname, "proveedorestelefono1", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedorestelefono1_Internalname, A132proveedorestelefono1, StringUtil.RTrim( context.localUtil.Format( A132proveedorestelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedorestelefono1_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedorestelefono1_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedorestelefono2_Internalname, "proveedorestelefono2", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedorestelefono2_Internalname, A133proveedorestelefono2, StringUtil.RTrim( context.localUtil.Format( A133proveedorestelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedorestelefono2_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedorestelefono2_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresfax_Internalname, "proveedoresfax", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresfax_Internalname, A134proveedoresfax, StringUtil.RTrim( context.localUtil.Format( A134proveedoresfax, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresfax_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresfax_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresrfc_Internalname, "proveedoresrfc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresrfc_Internalname, A135proveedoresrfc, StringUtil.RTrim( context.localUtil.Format( A135proveedoresrfc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresrfc_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresrfc_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresusuario_Internalname, "proveedoresusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresusuario_Internalname, A136proveedoresusuario, StringUtil.RTrim( context.localUtil.Format( A136proveedoresusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresfecreg_Internalname, "proveedoresfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtproveedoresfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtproveedoresfecreg_Internalname, context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A137proveedoresfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_proveedores.htm");
            GxWebStd.gx_bitmap( context, edtproveedoresfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtproveedoresfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_proveedores.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresfecultact_Internalname, "proveedoresfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtproveedoresfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtproveedoresfecultact_Internalname, context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A138proveedoresfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_proveedores.htm");
            GxWebStd.gx_bitmap( context, edtproveedoresfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtproveedoresfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_proveedores.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_proveedores.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROVEEDORESID");
                  AnyError = 1;
                  GX_FocusControl = edtproveedoresid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A2proveedoresid = 0;
                  n2proveedoresid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
               }
               else
               {
                  A2proveedoresid = (int)(context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", "."));
                  n2proveedoresid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
               }
               A126proveedoresnombre = cgiGet( edtproveedoresnombre_Internalname);
               n126proveedoresnombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126proveedoresnombre", A126proveedoresnombre);
               n126proveedoresnombre = (String.IsNullOrEmpty(StringUtil.RTrim( A126proveedoresnombre)) ? true : false);
               A127proveedoresdireccion = cgiGet( edtproveedoresdireccion_Internalname);
               n127proveedoresdireccion = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127proveedoresdireccion", A127proveedoresdireccion);
               n127proveedoresdireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A127proveedoresdireccion)) ? true : false);
               A128proveedorescolonia = cgiGet( edtproveedorescolonia_Internalname);
               n128proveedorescolonia = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128proveedorescolonia", A128proveedorescolonia);
               n128proveedorescolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A128proveedorescolonia)) ? true : false);
               A129proveedorescodigopostal = cgiGet( edtproveedorescodigopostal_Internalname);
               n129proveedorescodigopostal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129proveedorescodigopostal", A129proveedorescodigopostal);
               n129proveedorescodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A129proveedorescodigopostal)) ? true : false);
               A130proveedoresmunicipio = cgiGet( edtproveedoresmunicipio_Internalname);
               n130proveedoresmunicipio = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130proveedoresmunicipio", A130proveedoresmunicipio);
               n130proveedoresmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A130proveedoresmunicipio)) ? true : false);
               A131proveedorestado = cgiGet( edtproveedorestado_Internalname);
               n131proveedorestado = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131proveedorestado", A131proveedorestado);
               n131proveedorestado = (String.IsNullOrEmpty(StringUtil.RTrim( A131proveedorestado)) ? true : false);
               A132proveedorestelefono1 = cgiGet( edtproveedorestelefono1_Internalname);
               n132proveedorestelefono1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132proveedorestelefono1", A132proveedorestelefono1);
               n132proveedorestelefono1 = (String.IsNullOrEmpty(StringUtil.RTrim( A132proveedorestelefono1)) ? true : false);
               A133proveedorestelefono2 = cgiGet( edtproveedorestelefono2_Internalname);
               n133proveedorestelefono2 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133proveedorestelefono2", A133proveedorestelefono2);
               n133proveedorestelefono2 = (String.IsNullOrEmpty(StringUtil.RTrim( A133proveedorestelefono2)) ? true : false);
               A134proveedoresfax = cgiGet( edtproveedoresfax_Internalname);
               n134proveedoresfax = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134proveedoresfax", A134proveedoresfax);
               n134proveedoresfax = (String.IsNullOrEmpty(StringUtil.RTrim( A134proveedoresfax)) ? true : false);
               A135proveedoresrfc = cgiGet( edtproveedoresrfc_Internalname);
               n135proveedoresrfc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135proveedoresrfc", A135proveedoresrfc);
               n135proveedoresrfc = (String.IsNullOrEmpty(StringUtil.RTrim( A135proveedoresrfc)) ? true : false);
               A136proveedoresusuario = cgiGet( edtproveedoresusuario_Internalname);
               n136proveedoresusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A136proveedoresusuario", A136proveedoresusuario);
               n136proveedoresusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A136proveedoresusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtproveedoresfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"proveedoresfecreg"}), 1, "PROVEEDORESFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtproveedoresfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A137proveedoresfecreg = (DateTime)(DateTime.MinValue);
                  n137proveedoresfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137proveedoresfecreg", context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A137proveedoresfecreg = context.localUtil.CToT( cgiGet( edtproveedoresfecreg_Internalname));
                  n137proveedoresfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137proveedoresfecreg", context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n137proveedoresfecreg = ((DateTime.MinValue==A137proveedoresfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtproveedoresfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"proveedoresfecultact"}), 1, "PROVEEDORESFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtproveedoresfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A138proveedoresfecultact = (DateTime)(DateTime.MinValue);
                  n138proveedoresfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138proveedoresfecultact", context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A138proveedoresfecultact = context.localUtil.CToT( cgiGet( edtproveedoresfecultact_Internalname));
                  n138proveedoresfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138proveedoresfecultact", context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n138proveedoresfecultact = ((DateTime.MinValue==A138proveedoresfecultact) ? true : false);
               /* Read saved values. */
               Z2proveedoresid = (int)(context.localUtil.CToN( cgiGet( "Z2proveedoresid"), ",", "."));
               Z126proveedoresnombre = cgiGet( "Z126proveedoresnombre");
               n126proveedoresnombre = (String.IsNullOrEmpty(StringUtil.RTrim( A126proveedoresnombre)) ? true : false);
               Z127proveedoresdireccion = cgiGet( "Z127proveedoresdireccion");
               n127proveedoresdireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A127proveedoresdireccion)) ? true : false);
               Z128proveedorescolonia = cgiGet( "Z128proveedorescolonia");
               n128proveedorescolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A128proveedorescolonia)) ? true : false);
               Z129proveedorescodigopostal = cgiGet( "Z129proveedorescodigopostal");
               n129proveedorescodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A129proveedorescodigopostal)) ? true : false);
               Z130proveedoresmunicipio = cgiGet( "Z130proveedoresmunicipio");
               n130proveedoresmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A130proveedoresmunicipio)) ? true : false);
               Z131proveedorestado = cgiGet( "Z131proveedorestado");
               n131proveedorestado = (String.IsNullOrEmpty(StringUtil.RTrim( A131proveedorestado)) ? true : false);
               Z132proveedorestelefono1 = cgiGet( "Z132proveedorestelefono1");
               n132proveedorestelefono1 = (String.IsNullOrEmpty(StringUtil.RTrim( A132proveedorestelefono1)) ? true : false);
               Z133proveedorestelefono2 = cgiGet( "Z133proveedorestelefono2");
               n133proveedorestelefono2 = (String.IsNullOrEmpty(StringUtil.RTrim( A133proveedorestelefono2)) ? true : false);
               Z134proveedoresfax = cgiGet( "Z134proveedoresfax");
               n134proveedoresfax = (String.IsNullOrEmpty(StringUtil.RTrim( A134proveedoresfax)) ? true : false);
               Z135proveedoresrfc = cgiGet( "Z135proveedoresrfc");
               n135proveedoresrfc = (String.IsNullOrEmpty(StringUtil.RTrim( A135proveedoresrfc)) ? true : false);
               Z136proveedoresusuario = cgiGet( "Z136proveedoresusuario");
               n136proveedoresusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A136proveedoresusuario)) ? true : false);
               Z137proveedoresfecreg = context.localUtil.CToT( cgiGet( "Z137proveedoresfecreg"), 0);
               n137proveedoresfecreg = ((DateTime.MinValue==A137proveedoresfecreg) ? true : false);
               Z138proveedoresfecultact = context.localUtil.CToT( cgiGet( "Z138proveedoresfecultact"), 0);
               n138proveedoresfecultact = ((DateTime.MinValue==A138proveedoresfecultact) ? true : false);
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
                  A2proveedoresid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  n2proveedoresid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
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
               InitAll0A10( ) ;
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
         DisableAttributes0A10( ) ;
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

      protected void ResetCaption0A0( )
      {
      }

      protected void ZM0A10( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z126proveedoresnombre = T000A3_A126proveedoresnombre[0];
               Z127proveedoresdireccion = T000A3_A127proveedoresdireccion[0];
               Z128proveedorescolonia = T000A3_A128proveedorescolonia[0];
               Z129proveedorescodigopostal = T000A3_A129proveedorescodigopostal[0];
               Z130proveedoresmunicipio = T000A3_A130proveedoresmunicipio[0];
               Z131proveedorestado = T000A3_A131proveedorestado[0];
               Z132proveedorestelefono1 = T000A3_A132proveedorestelefono1[0];
               Z133proveedorestelefono2 = T000A3_A133proveedorestelefono2[0];
               Z134proveedoresfax = T000A3_A134proveedoresfax[0];
               Z135proveedoresrfc = T000A3_A135proveedoresrfc[0];
               Z136proveedoresusuario = T000A3_A136proveedoresusuario[0];
               Z137proveedoresfecreg = T000A3_A137proveedoresfecreg[0];
               Z138proveedoresfecultact = T000A3_A138proveedoresfecultact[0];
            }
            else
            {
               Z126proveedoresnombre = A126proveedoresnombre;
               Z127proveedoresdireccion = A127proveedoresdireccion;
               Z128proveedorescolonia = A128proveedorescolonia;
               Z129proveedorescodigopostal = A129proveedorescodigopostal;
               Z130proveedoresmunicipio = A130proveedoresmunicipio;
               Z131proveedorestado = A131proveedorestado;
               Z132proveedorestelefono1 = A132proveedorestelefono1;
               Z133proveedorestelefono2 = A133proveedorestelefono2;
               Z134proveedoresfax = A134proveedoresfax;
               Z135proveedoresrfc = A135proveedoresrfc;
               Z136proveedoresusuario = A136proveedoresusuario;
               Z137proveedoresfecreg = A137proveedoresfecreg;
               Z138proveedoresfecultact = A138proveedoresfecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z2proveedoresid = A2proveedoresid;
            Z126proveedoresnombre = A126proveedoresnombre;
            Z127proveedoresdireccion = A127proveedoresdireccion;
            Z128proveedorescolonia = A128proveedorescolonia;
            Z129proveedorescodigopostal = A129proveedorescodigopostal;
            Z130proveedoresmunicipio = A130proveedoresmunicipio;
            Z131proveedorestado = A131proveedorestado;
            Z132proveedorestelefono1 = A132proveedorestelefono1;
            Z133proveedorestelefono2 = A133proveedorestelefono2;
            Z134proveedoresfax = A134proveedoresfax;
            Z135proveedoresrfc = A135proveedoresrfc;
            Z136proveedoresusuario = A136proveedoresusuario;
            Z137proveedoresfecreg = A137proveedoresfecreg;
            Z138proveedoresfecultact = A138proveedoresfecultact;
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

      protected void Load0A10( )
      {
         /* Using cursor T000A4 */
         pr_default.execute(2, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1;
            A126proveedoresnombre = T000A4_A126proveedoresnombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126proveedoresnombre", A126proveedoresnombre);
            n126proveedoresnombre = T000A4_n126proveedoresnombre[0];
            A127proveedoresdireccion = T000A4_A127proveedoresdireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127proveedoresdireccion", A127proveedoresdireccion);
            n127proveedoresdireccion = T000A4_n127proveedoresdireccion[0];
            A128proveedorescolonia = T000A4_A128proveedorescolonia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128proveedorescolonia", A128proveedorescolonia);
            n128proveedorescolonia = T000A4_n128proveedorescolonia[0];
            A129proveedorescodigopostal = T000A4_A129proveedorescodigopostal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129proveedorescodigopostal", A129proveedorescodigopostal);
            n129proveedorescodigopostal = T000A4_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = T000A4_A130proveedoresmunicipio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130proveedoresmunicipio", A130proveedoresmunicipio);
            n130proveedoresmunicipio = T000A4_n130proveedoresmunicipio[0];
            A131proveedorestado = T000A4_A131proveedorestado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131proveedorestado", A131proveedorestado);
            n131proveedorestado = T000A4_n131proveedorestado[0];
            A132proveedorestelefono1 = T000A4_A132proveedorestelefono1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132proveedorestelefono1", A132proveedorestelefono1);
            n132proveedorestelefono1 = T000A4_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = T000A4_A133proveedorestelefono2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133proveedorestelefono2", A133proveedorestelefono2);
            n133proveedorestelefono2 = T000A4_n133proveedorestelefono2[0];
            A134proveedoresfax = T000A4_A134proveedoresfax[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134proveedoresfax", A134proveedoresfax);
            n134proveedoresfax = T000A4_n134proveedoresfax[0];
            A135proveedoresrfc = T000A4_A135proveedoresrfc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135proveedoresrfc", A135proveedoresrfc);
            n135proveedoresrfc = T000A4_n135proveedoresrfc[0];
            A136proveedoresusuario = T000A4_A136proveedoresusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A136proveedoresusuario", A136proveedoresusuario);
            n136proveedoresusuario = T000A4_n136proveedoresusuario[0];
            A137proveedoresfecreg = T000A4_A137proveedoresfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137proveedoresfecreg", context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
            n137proveedoresfecreg = T000A4_n137proveedoresfecreg[0];
            A138proveedoresfecultact = T000A4_A138proveedoresfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138proveedoresfecultact", context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
            n138proveedoresfecultact = T000A4_n138proveedoresfecultact[0];
            ZM0A10( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0A10( ) ;
      }

      protected void OnLoadActions0A10( )
      {
      }

      protected void CheckExtendedTable0A10( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0A10( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0A10( )
      {
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A10( 1) ;
            RcdFound10 = 1;
            A2proveedoresid = T000A3_A2proveedoresid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            n2proveedoresid = T000A3_n2proveedoresid[0];
            A126proveedoresnombre = T000A3_A126proveedoresnombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126proveedoresnombre", A126proveedoresnombre);
            n126proveedoresnombre = T000A3_n126proveedoresnombre[0];
            A127proveedoresdireccion = T000A3_A127proveedoresdireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127proveedoresdireccion", A127proveedoresdireccion);
            n127proveedoresdireccion = T000A3_n127proveedoresdireccion[0];
            A128proveedorescolonia = T000A3_A128proveedorescolonia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128proveedorescolonia", A128proveedorescolonia);
            n128proveedorescolonia = T000A3_n128proveedorescolonia[0];
            A129proveedorescodigopostal = T000A3_A129proveedorescodigopostal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129proveedorescodigopostal", A129proveedorescodigopostal);
            n129proveedorescodigopostal = T000A3_n129proveedorescodigopostal[0];
            A130proveedoresmunicipio = T000A3_A130proveedoresmunicipio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130proveedoresmunicipio", A130proveedoresmunicipio);
            n130proveedoresmunicipio = T000A3_n130proveedoresmunicipio[0];
            A131proveedorestado = T000A3_A131proveedorestado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131proveedorestado", A131proveedorestado);
            n131proveedorestado = T000A3_n131proveedorestado[0];
            A132proveedorestelefono1 = T000A3_A132proveedorestelefono1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132proveedorestelefono1", A132proveedorestelefono1);
            n132proveedorestelefono1 = T000A3_n132proveedorestelefono1[0];
            A133proveedorestelefono2 = T000A3_A133proveedorestelefono2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133proveedorestelefono2", A133proveedorestelefono2);
            n133proveedorestelefono2 = T000A3_n133proveedorestelefono2[0];
            A134proveedoresfax = T000A3_A134proveedoresfax[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134proveedoresfax", A134proveedoresfax);
            n134proveedoresfax = T000A3_n134proveedoresfax[0];
            A135proveedoresrfc = T000A3_A135proveedoresrfc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135proveedoresrfc", A135proveedoresrfc);
            n135proveedoresrfc = T000A3_n135proveedoresrfc[0];
            A136proveedoresusuario = T000A3_A136proveedoresusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A136proveedoresusuario", A136proveedoresusuario);
            n136proveedoresusuario = T000A3_n136proveedoresusuario[0];
            A137proveedoresfecreg = T000A3_A137proveedoresfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137proveedoresfecreg", context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
            n137proveedoresfecreg = T000A3_n137proveedoresfecreg[0];
            A138proveedoresfecultact = T000A3_A138proveedoresfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138proveedoresfecultact", context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
            n138proveedoresfecultact = T000A3_n138proveedoresfecultact[0];
            Z2proveedoresid = A2proveedoresid;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A10( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0A10( ) ;
            }
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0A10( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A10( ) ;
         if ( RcdFound10 == 0 )
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
         RcdFound10 = 0;
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000A6_A2proveedoresid[0] < A2proveedoresid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000A6_A2proveedoresid[0] > A2proveedoresid ) ) )
            {
               A2proveedoresid = T000A6_A2proveedoresid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
               n2proveedoresid = T000A6_n2proveedoresid[0];
               RcdFound10 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0;
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000A7_A2proveedoresid[0] > A2proveedoresid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000A7_A2proveedoresid[0] < A2proveedoresid ) ) )
            {
               A2proveedoresid = T000A7_A2proveedoresid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
               n2proveedoresid = T000A7_n2proveedoresid[0];
               RcdFound10 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0A10( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtproveedoresid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0A10( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A2proveedoresid != Z2proveedoresid )
               {
                  A2proveedoresid = Z2proveedoresid;
                  n2proveedoresid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PROVEEDORESID");
                  AnyError = 1;
                  GX_FocusControl = edtproveedoresid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtproveedoresid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0A10( ) ;
                  GX_FocusControl = edtproveedoresid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A2proveedoresid != Z2proveedoresid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtproveedoresid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A10( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PROVEEDORESID");
                     AnyError = 1;
                     GX_FocusControl = edtproveedoresid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtproveedoresid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0A10( ) ;
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
         if ( A2proveedoresid != Z2proveedoresid )
         {
            A2proveedoresid = Z2proveedoresid;
            n2proveedoresid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PROVEEDORESID");
            AnyError = 1;
            GX_FocusControl = edtproveedoresid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtproveedoresid_Internalname;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PROVEEDORESID");
            AnyError = 1;
            GX_FocusControl = edtproveedoresid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtproveedoresnombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproveedoresnombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproveedoresnombre_Internalname;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproveedoresnombre_Internalname;
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
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0A10( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproveedoresnombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {n2proveedoresid, A2proveedoresid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PROVEEDORES"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z126proveedoresnombre, T000A2_A126proveedoresnombre[0]) != 0 ) || ( StringUtil.StrCmp(Z127proveedoresdireccion, T000A2_A127proveedoresdireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z128proveedorescolonia, T000A2_A128proveedorescolonia[0]) != 0 ) || ( StringUtil.StrCmp(Z129proveedorescodigopostal, T000A2_A129proveedorescodigopostal[0]) != 0 ) || ( StringUtil.StrCmp(Z130proveedoresmunicipio, T000A2_A130proveedoresmunicipio[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z131proveedorestado, T000A2_A131proveedorestado[0]) != 0 ) || ( StringUtil.StrCmp(Z132proveedorestelefono1, T000A2_A132proveedorestelefono1[0]) != 0 ) || ( StringUtil.StrCmp(Z133proveedorestelefono2, T000A2_A133proveedorestelefono2[0]) != 0 ) || ( StringUtil.StrCmp(Z134proveedoresfax, T000A2_A134proveedoresfax[0]) != 0 ) || ( StringUtil.StrCmp(Z135proveedoresrfc, T000A2_A135proveedoresrfc[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z136proveedoresusuario, T000A2_A136proveedoresusuario[0]) != 0 ) || ( Z137proveedoresfecreg != T000A2_A137proveedoresfecreg[0] ) || ( Z138proveedoresfecultact != T000A2_A138proveedoresfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z126proveedoresnombre, T000A2_A126proveedoresnombre[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresnombre");
                  GXUtil.WriteLogRaw("Old: ",Z126proveedoresnombre);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A126proveedoresnombre[0]);
               }
               if ( StringUtil.StrCmp(Z127proveedoresdireccion, T000A2_A127proveedoresdireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresdireccion");
                  GXUtil.WriteLogRaw("Old: ",Z127proveedoresdireccion);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A127proveedoresdireccion[0]);
               }
               if ( StringUtil.StrCmp(Z128proveedorescolonia, T000A2_A128proveedorescolonia[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedorescolonia");
                  GXUtil.WriteLogRaw("Old: ",Z128proveedorescolonia);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A128proveedorescolonia[0]);
               }
               if ( StringUtil.StrCmp(Z129proveedorescodigopostal, T000A2_A129proveedorescodigopostal[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedorescodigopostal");
                  GXUtil.WriteLogRaw("Old: ",Z129proveedorescodigopostal);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A129proveedorescodigopostal[0]);
               }
               if ( StringUtil.StrCmp(Z130proveedoresmunicipio, T000A2_A130proveedoresmunicipio[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresmunicipio");
                  GXUtil.WriteLogRaw("Old: ",Z130proveedoresmunicipio);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A130proveedoresmunicipio[0]);
               }
               if ( StringUtil.StrCmp(Z131proveedorestado, T000A2_A131proveedorestado[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedorestado");
                  GXUtil.WriteLogRaw("Old: ",Z131proveedorestado);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A131proveedorestado[0]);
               }
               if ( StringUtil.StrCmp(Z132proveedorestelefono1, T000A2_A132proveedorestelefono1[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedorestelefono1");
                  GXUtil.WriteLogRaw("Old: ",Z132proveedorestelefono1);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A132proveedorestelefono1[0]);
               }
               if ( StringUtil.StrCmp(Z133proveedorestelefono2, T000A2_A133proveedorestelefono2[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedorestelefono2");
                  GXUtil.WriteLogRaw("Old: ",Z133proveedorestelefono2);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A133proveedorestelefono2[0]);
               }
               if ( StringUtil.StrCmp(Z134proveedoresfax, T000A2_A134proveedoresfax[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresfax");
                  GXUtil.WriteLogRaw("Old: ",Z134proveedoresfax);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A134proveedoresfax[0]);
               }
               if ( StringUtil.StrCmp(Z135proveedoresrfc, T000A2_A135proveedoresrfc[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresrfc");
                  GXUtil.WriteLogRaw("Old: ",Z135proveedoresrfc);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A135proveedoresrfc[0]);
               }
               if ( StringUtil.StrCmp(Z136proveedoresusuario, T000A2_A136proveedoresusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresusuario");
                  GXUtil.WriteLogRaw("Old: ",Z136proveedoresusuario);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A136proveedoresusuario[0]);
               }
               if ( Z137proveedoresfecreg != T000A2_A137proveedoresfecreg[0] )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z137proveedoresfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A137proveedoresfecreg[0]);
               }
               if ( Z138proveedoresfecultact != T000A2_A138proveedoresfecultact[0] )
               {
                  GXUtil.WriteLog("proveedores:[seudo value changed for attri]"+"proveedoresfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z138proveedoresfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A138proveedoresfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PROVEEDORES"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A10( 0) ;
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A8 */
                     pr_default.execute(6, new Object[] {n2proveedoresid, A2proveedoresid, n126proveedoresnombre, A126proveedoresnombre, n127proveedoresdireccion, A127proveedoresdireccion, n128proveedorescolonia, A128proveedorescolonia, n129proveedorescodigopostal, A129proveedorescodigopostal, n130proveedoresmunicipio, A130proveedoresmunicipio, n131proveedorestado, A131proveedorestado, n132proveedorestelefono1, A132proveedorestelefono1, n133proveedorestelefono2, A133proveedorestelefono2, n134proveedoresfax, A134proveedoresfax, n135proveedoresrfc, A135proveedoresrfc, n136proveedoresusuario, A136proveedoresusuario, n137proveedoresfecreg, A137proveedoresfecreg, n138proveedoresfecultact, A138proveedoresfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
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
                           ResetCaption0A0( ) ;
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
               Load0A10( ) ;
            }
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void Update0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A9 */
                     pr_default.execute(7, new Object[] {n126proveedoresnombre, A126proveedoresnombre, n127proveedoresdireccion, A127proveedoresdireccion, n128proveedorescolonia, A128proveedorescolonia, n129proveedorescodigopostal, A129proveedorescodigopostal, n130proveedoresmunicipio, A130proveedoresmunicipio, n131proveedorestado, A131proveedorestado, n132proveedorestelefono1, A132proveedorestelefono1, n133proveedorestelefono2, A133proveedorestelefono2, n134proveedoresfax, A134proveedoresfax, n135proveedoresrfc, A135proveedoresrfc, n136proveedoresusuario, A136proveedoresusuario, n137proveedoresfecreg, A137proveedoresfecreg, n138proveedoresfecultact, A138proveedoresfecultact, n2proveedoresid, A2proveedoresid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PROVEEDORES"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A10( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0A0( ) ;
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
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void DeferredUpdate0A10( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A10( ) ;
            AfterConfirm0A10( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A10( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A10 */
                  pr_default.execute(8, new Object[] {n2proveedoresid, A2proveedoresid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("PROVEEDORES") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0A10( ) ;
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
                        ResetCaption0A0( ) ;
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
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A10( ) ;
         Gx_mode = sMode10;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A10( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000A11 */
            pr_default.execute(9, new Object[] {n2proveedoresid, A2proveedoresid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "proveedores");
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "proveedores");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0A10( )
      {
         /* Using cursor T000A12 */
         pr_default.execute(10);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound10 = 1;
            A2proveedoresid = T000A12_A2proveedoresid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            n2proveedoresid = T000A12_n2proveedoresid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A10( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound10 = 1;
            A2proveedoresid = T000A12_A2proveedoresid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            n2proveedoresid = T000A12_n2proveedoresid[0];
         }
      }

      protected void ScanEnd0A10( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0A10( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A10( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A10( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A10( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A10( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A10( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A10( )
      {
         edtproveedoresid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresid_Enabled), 5, 0)));
         edtproveedoresnombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresnombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresnombre_Enabled), 5, 0)));
         edtproveedoresdireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresdireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresdireccion_Enabled), 5, 0)));
         edtproveedorescolonia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedorescolonia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedorescolonia_Enabled), 5, 0)));
         edtproveedorescodigopostal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedorescodigopostal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedorescodigopostal_Enabled), 5, 0)));
         edtproveedoresmunicipio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresmunicipio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresmunicipio_Enabled), 5, 0)));
         edtproveedorestado_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedorestado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedorestado_Enabled), 5, 0)));
         edtproveedorestelefono1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedorestelefono1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedorestelefono1_Enabled), 5, 0)));
         edtproveedorestelefono2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedorestelefono2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedorestelefono2_Enabled), 5, 0)));
         edtproveedoresfax_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresfax_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresfax_Enabled), 5, 0)));
         edtproveedoresrfc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresrfc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresrfc_Enabled), 5, 0)));
         edtproveedoresusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresusuario_Enabled), 5, 0)));
         edtproveedoresfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresfecreg_Enabled), 5, 0)));
         edtproveedoresfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0A0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20221262072532");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("proveedores.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z2proveedoresid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2proveedoresid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z126proveedoresnombre", Z126proveedoresnombre);
         GxWebStd.gx_hidden_field( context, "Z127proveedoresdireccion", Z127proveedoresdireccion);
         GxWebStd.gx_hidden_field( context, "Z128proveedorescolonia", Z128proveedorescolonia);
         GxWebStd.gx_hidden_field( context, "Z129proveedorescodigopostal", Z129proveedorescodigopostal);
         GxWebStd.gx_hidden_field( context, "Z130proveedoresmunicipio", Z130proveedoresmunicipio);
         GxWebStd.gx_hidden_field( context, "Z131proveedorestado", Z131proveedorestado);
         GxWebStd.gx_hidden_field( context, "Z132proveedorestelefono1", Z132proveedorestelefono1);
         GxWebStd.gx_hidden_field( context, "Z133proveedorestelefono2", Z133proveedorestelefono2);
         GxWebStd.gx_hidden_field( context, "Z134proveedoresfax", Z134proveedoresfax);
         GxWebStd.gx_hidden_field( context, "Z135proveedoresrfc", Z135proveedoresrfc);
         GxWebStd.gx_hidden_field( context, "Z136proveedoresusuario", Z136proveedoresusuario);
         GxWebStd.gx_hidden_field( context, "Z137proveedoresfecreg", context.localUtil.TToC( Z137proveedoresfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z138proveedoresfecultact", context.localUtil.TToC( Z138proveedoresfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("proveedores.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "proveedores" ;
      }

      public override String GetPgmdesc( )
      {
         return "proveedores" ;
      }

      protected void InitializeNonKey0A10( )
      {
         A126proveedoresnombre = "";
         n126proveedoresnombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126proveedoresnombre", A126proveedoresnombre);
         n126proveedoresnombre = (String.IsNullOrEmpty(StringUtil.RTrim( A126proveedoresnombre)) ? true : false);
         A127proveedoresdireccion = "";
         n127proveedoresdireccion = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127proveedoresdireccion", A127proveedoresdireccion);
         n127proveedoresdireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A127proveedoresdireccion)) ? true : false);
         A128proveedorescolonia = "";
         n128proveedorescolonia = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128proveedorescolonia", A128proveedorescolonia);
         n128proveedorescolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A128proveedorescolonia)) ? true : false);
         A129proveedorescodigopostal = "";
         n129proveedorescodigopostal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129proveedorescodigopostal", A129proveedorescodigopostal);
         n129proveedorescodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A129proveedorescodigopostal)) ? true : false);
         A130proveedoresmunicipio = "";
         n130proveedoresmunicipio = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130proveedoresmunicipio", A130proveedoresmunicipio);
         n130proveedoresmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A130proveedoresmunicipio)) ? true : false);
         A131proveedorestado = "";
         n131proveedorestado = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131proveedorestado", A131proveedorestado);
         n131proveedorestado = (String.IsNullOrEmpty(StringUtil.RTrim( A131proveedorestado)) ? true : false);
         A132proveedorestelefono1 = "";
         n132proveedorestelefono1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132proveedorestelefono1", A132proveedorestelefono1);
         n132proveedorestelefono1 = (String.IsNullOrEmpty(StringUtil.RTrim( A132proveedorestelefono1)) ? true : false);
         A133proveedorestelefono2 = "";
         n133proveedorestelefono2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133proveedorestelefono2", A133proveedorestelefono2);
         n133proveedorestelefono2 = (String.IsNullOrEmpty(StringUtil.RTrim( A133proveedorestelefono2)) ? true : false);
         A134proveedoresfax = "";
         n134proveedoresfax = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134proveedoresfax", A134proveedoresfax);
         n134proveedoresfax = (String.IsNullOrEmpty(StringUtil.RTrim( A134proveedoresfax)) ? true : false);
         A135proveedoresrfc = "";
         n135proveedoresrfc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135proveedoresrfc", A135proveedoresrfc);
         n135proveedoresrfc = (String.IsNullOrEmpty(StringUtil.RTrim( A135proveedoresrfc)) ? true : false);
         A136proveedoresusuario = "";
         n136proveedoresusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A136proveedoresusuario", A136proveedoresusuario);
         n136proveedoresusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A136proveedoresusuario)) ? true : false);
         A137proveedoresfecreg = (DateTime)(DateTime.MinValue);
         n137proveedoresfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137proveedoresfecreg", context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
         n137proveedoresfecreg = ((DateTime.MinValue==A137proveedoresfecreg) ? true : false);
         A138proveedoresfecultact = (DateTime)(DateTime.MinValue);
         n138proveedoresfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138proveedoresfecultact", context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
         n138proveedoresfecultact = ((DateTime.MinValue==A138proveedoresfecultact) ? true : false);
         Z126proveedoresnombre = "";
         Z127proveedoresdireccion = "";
         Z128proveedorescolonia = "";
         Z129proveedorescodigopostal = "";
         Z130proveedoresmunicipio = "";
         Z131proveedorestado = "";
         Z132proveedorestelefono1 = "";
         Z133proveedorestelefono2 = "";
         Z134proveedoresfax = "";
         Z135proveedoresrfc = "";
         Z136proveedoresusuario = "";
         Z137proveedoresfecreg = (DateTime)(DateTime.MinValue);
         Z138proveedoresfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0A10( )
      {
         A2proveedoresid = 0;
         n2proveedoresid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
         InitializeNonKey0A10( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?13205289");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2071072");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221262072539");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("proveedores.js", "?20221262072540");
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
         edtproveedoresid_Internalname = "PROVEEDORESID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresdireccion_Internalname = "PROVEEDORESDIRECCION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedorescodigopostal_Internalname = "PROVEEDORESCODIGOPOSTAL";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresmunicipio_Internalname = "PROVEEDORESMUNICIPIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedorestado_Internalname = "PROVEEDORESTADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedorestelefono1_Internalname = "PROVEEDORESTELEFONO1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedorestelefono2_Internalname = "PROVEEDORESTELEFONO2";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresfax_Internalname = "PROVEEDORESFAX";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresrfc_Internalname = "PROVEEDORESRFC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresusuario_Internalname = "PROVEEDORESUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresfecreg_Internalname = "PROVEEDORESFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresfecultact_Internalname = "PROVEEDORESFECULTACT";
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
         Form.Caption = "proveedores";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtproveedoresfecultact_Jsonclick = "";
         edtproveedoresfecultact_Enabled = 1;
         edtproveedoresfecreg_Jsonclick = "";
         edtproveedoresfecreg_Enabled = 1;
         edtproveedoresusuario_Jsonclick = "";
         edtproveedoresusuario_Enabled = 1;
         edtproveedoresrfc_Jsonclick = "";
         edtproveedoresrfc_Enabled = 1;
         edtproveedoresfax_Jsonclick = "";
         edtproveedoresfax_Enabled = 1;
         edtproveedorestelefono2_Jsonclick = "";
         edtproveedorestelefono2_Enabled = 1;
         edtproveedorestelefono1_Jsonclick = "";
         edtproveedorestelefono1_Enabled = 1;
         edtproveedorestado_Jsonclick = "";
         edtproveedorestado_Enabled = 1;
         edtproveedoresmunicipio_Jsonclick = "";
         edtproveedoresmunicipio_Enabled = 1;
         edtproveedorescodigopostal_Jsonclick = "";
         edtproveedorescodigopostal_Enabled = 1;
         edtproveedorescolonia_Jsonclick = "";
         edtproveedorescolonia_Enabled = 1;
         edtproveedoresdireccion_Jsonclick = "";
         edtproveedoresdireccion_Enabled = 1;
         edtproveedoresnombre_Jsonclick = "";
         edtproveedoresnombre_Enabled = 1;
         edtproveedoresid_Jsonclick = "";
         edtproveedoresid_Enabled = 1;
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
         GX_FocusControl = edtproveedoresnombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Proveedoresid( int GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       String GX_Parm5 ,
                                       String GX_Parm6 ,
                                       String GX_Parm7 ,
                                       String GX_Parm8 ,
                                       String GX_Parm9 ,
                                       String GX_Parm10 ,
                                       String GX_Parm11 ,
                                       String GX_Parm12 ,
                                       DateTime GX_Parm13 ,
                                       DateTime GX_Parm14 )
      {
         A2proveedoresid = GX_Parm1;
         n2proveedoresid = false;
         A126proveedoresnombre = GX_Parm2;
         n126proveedoresnombre = false;
         A127proveedoresdireccion = GX_Parm3;
         n127proveedoresdireccion = false;
         A128proveedorescolonia = GX_Parm4;
         n128proveedorescolonia = false;
         A129proveedorescodigopostal = GX_Parm5;
         n129proveedorescodigopostal = false;
         A130proveedoresmunicipio = GX_Parm6;
         n130proveedoresmunicipio = false;
         A131proveedorestado = GX_Parm7;
         n131proveedorestado = false;
         A132proveedorestelefono1 = GX_Parm8;
         n132proveedorestelefono1 = false;
         A133proveedorestelefono2 = GX_Parm9;
         n133proveedorestelefono2 = false;
         A134proveedoresfax = GX_Parm10;
         n134proveedoresfax = false;
         A135proveedoresrfc = GX_Parm11;
         n135proveedoresrfc = false;
         A136proveedoresusuario = GX_Parm12;
         n136proveedoresusuario = false;
         A137proveedoresfecreg = GX_Parm13;
         n137proveedoresfecreg = false;
         A138proveedoresfecultact = GX_Parm14;
         n138proveedoresfecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A126proveedoresnombre);
         isValidOutput.Add(A127proveedoresdireccion);
         isValidOutput.Add(A128proveedorescolonia);
         isValidOutput.Add(A129proveedorescodigopostal);
         isValidOutput.Add(A130proveedoresmunicipio);
         isValidOutput.Add(A131proveedorestado);
         isValidOutput.Add(A132proveedorestelefono1);
         isValidOutput.Add(A133proveedorestelefono2);
         isValidOutput.Add(A134proveedoresfax);
         isValidOutput.Add(A135proveedoresrfc);
         isValidOutput.Add(A136proveedoresusuario);
         isValidOutput.Add(context.localUtil.TToC( A137proveedoresfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A138proveedoresfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2proveedoresid), 9, 0, ",", "")));
         isValidOutput.Add(Z126proveedoresnombre);
         isValidOutput.Add(Z127proveedoresdireccion);
         isValidOutput.Add(Z128proveedorescolonia);
         isValidOutput.Add(Z129proveedorescodigopostal);
         isValidOutput.Add(Z130proveedoresmunicipio);
         isValidOutput.Add(Z131proveedorestado);
         isValidOutput.Add(Z132proveedorestelefono1);
         isValidOutput.Add(Z133proveedorestelefono2);
         isValidOutput.Add(Z134proveedoresfax);
         isValidOutput.Add(Z135proveedoresrfc);
         isValidOutput.Add(Z136proveedoresusuario);
         isValidOutput.Add(context.localUtil.TToC( Z137proveedoresfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z138proveedoresfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         Z126proveedoresnombre = "";
         Z127proveedoresdireccion = "";
         Z128proveedorescolonia = "";
         Z129proveedorescodigopostal = "";
         Z130proveedoresmunicipio = "";
         Z131proveedorestado = "";
         Z132proveedorestelefono1 = "";
         Z133proveedorestelefono2 = "";
         Z134proveedoresfax = "";
         Z135proveedoresrfc = "";
         Z136proveedoresusuario = "";
         Z137proveedoresfecreg = (DateTime)(DateTime.MinValue);
         Z138proveedoresfecultact = (DateTime)(DateTime.MinValue);
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
         A126proveedoresnombre = "";
         A127proveedoresdireccion = "";
         A128proveedorescolonia = "";
         A129proveedorescodigopostal = "";
         A130proveedoresmunicipio = "";
         A131proveedorestado = "";
         A132proveedorestelefono1 = "";
         A133proveedorestelefono2 = "";
         A134proveedoresfax = "";
         A135proveedoresrfc = "";
         A136proveedoresusuario = "";
         A137proveedoresfecreg = (DateTime)(DateTime.MinValue);
         A138proveedoresfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000A4_A2proveedoresid = new int[1] ;
         T000A4_n2proveedoresid = new bool[] {false} ;
         T000A4_A126proveedoresnombre = new String[] {""} ;
         T000A4_n126proveedoresnombre = new bool[] {false} ;
         T000A4_A127proveedoresdireccion = new String[] {""} ;
         T000A4_n127proveedoresdireccion = new bool[] {false} ;
         T000A4_A128proveedorescolonia = new String[] {""} ;
         T000A4_n128proveedorescolonia = new bool[] {false} ;
         T000A4_A129proveedorescodigopostal = new String[] {""} ;
         T000A4_n129proveedorescodigopostal = new bool[] {false} ;
         T000A4_A130proveedoresmunicipio = new String[] {""} ;
         T000A4_n130proveedoresmunicipio = new bool[] {false} ;
         T000A4_A131proveedorestado = new String[] {""} ;
         T000A4_n131proveedorestado = new bool[] {false} ;
         T000A4_A132proveedorestelefono1 = new String[] {""} ;
         T000A4_n132proveedorestelefono1 = new bool[] {false} ;
         T000A4_A133proveedorestelefono2 = new String[] {""} ;
         T000A4_n133proveedorestelefono2 = new bool[] {false} ;
         T000A4_A134proveedoresfax = new String[] {""} ;
         T000A4_n134proveedoresfax = new bool[] {false} ;
         T000A4_A135proveedoresrfc = new String[] {""} ;
         T000A4_n135proveedoresrfc = new bool[] {false} ;
         T000A4_A136proveedoresusuario = new String[] {""} ;
         T000A4_n136proveedoresusuario = new bool[] {false} ;
         T000A4_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         T000A4_n137proveedoresfecreg = new bool[] {false} ;
         T000A4_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         T000A4_n138proveedoresfecultact = new bool[] {false} ;
         T000A5_A2proveedoresid = new int[1] ;
         T000A5_n2proveedoresid = new bool[] {false} ;
         T000A3_A2proveedoresid = new int[1] ;
         T000A3_n2proveedoresid = new bool[] {false} ;
         T000A3_A126proveedoresnombre = new String[] {""} ;
         T000A3_n126proveedoresnombre = new bool[] {false} ;
         T000A3_A127proveedoresdireccion = new String[] {""} ;
         T000A3_n127proveedoresdireccion = new bool[] {false} ;
         T000A3_A128proveedorescolonia = new String[] {""} ;
         T000A3_n128proveedorescolonia = new bool[] {false} ;
         T000A3_A129proveedorescodigopostal = new String[] {""} ;
         T000A3_n129proveedorescodigopostal = new bool[] {false} ;
         T000A3_A130proveedoresmunicipio = new String[] {""} ;
         T000A3_n130proveedoresmunicipio = new bool[] {false} ;
         T000A3_A131proveedorestado = new String[] {""} ;
         T000A3_n131proveedorestado = new bool[] {false} ;
         T000A3_A132proveedorestelefono1 = new String[] {""} ;
         T000A3_n132proveedorestelefono1 = new bool[] {false} ;
         T000A3_A133proveedorestelefono2 = new String[] {""} ;
         T000A3_n133proveedorestelefono2 = new bool[] {false} ;
         T000A3_A134proveedoresfax = new String[] {""} ;
         T000A3_n134proveedoresfax = new bool[] {false} ;
         T000A3_A135proveedoresrfc = new String[] {""} ;
         T000A3_n135proveedoresrfc = new bool[] {false} ;
         T000A3_A136proveedoresusuario = new String[] {""} ;
         T000A3_n136proveedoresusuario = new bool[] {false} ;
         T000A3_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         T000A3_n137proveedoresfecreg = new bool[] {false} ;
         T000A3_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         T000A3_n138proveedoresfecultact = new bool[] {false} ;
         sMode10 = "";
         T000A6_A2proveedoresid = new int[1] ;
         T000A6_n2proveedoresid = new bool[] {false} ;
         T000A7_A2proveedoresid = new int[1] ;
         T000A7_n2proveedoresid = new bool[] {false} ;
         T000A2_A2proveedoresid = new int[1] ;
         T000A2_n2proveedoresid = new bool[] {false} ;
         T000A2_A126proveedoresnombre = new String[] {""} ;
         T000A2_n126proveedoresnombre = new bool[] {false} ;
         T000A2_A127proveedoresdireccion = new String[] {""} ;
         T000A2_n127proveedoresdireccion = new bool[] {false} ;
         T000A2_A128proveedorescolonia = new String[] {""} ;
         T000A2_n128proveedorescolonia = new bool[] {false} ;
         T000A2_A129proveedorescodigopostal = new String[] {""} ;
         T000A2_n129proveedorescodigopostal = new bool[] {false} ;
         T000A2_A130proveedoresmunicipio = new String[] {""} ;
         T000A2_n130proveedoresmunicipio = new bool[] {false} ;
         T000A2_A131proveedorestado = new String[] {""} ;
         T000A2_n131proveedorestado = new bool[] {false} ;
         T000A2_A132proveedorestelefono1 = new String[] {""} ;
         T000A2_n132proveedorestelefono1 = new bool[] {false} ;
         T000A2_A133proveedorestelefono2 = new String[] {""} ;
         T000A2_n133proveedorestelefono2 = new bool[] {false} ;
         T000A2_A134proveedoresfax = new String[] {""} ;
         T000A2_n134proveedoresfax = new bool[] {false} ;
         T000A2_A135proveedoresrfc = new String[] {""} ;
         T000A2_n135proveedoresrfc = new bool[] {false} ;
         T000A2_A136proveedoresusuario = new String[] {""} ;
         T000A2_n136proveedoresusuario = new bool[] {false} ;
         T000A2_A137proveedoresfecreg = new DateTime[] {DateTime.MinValue} ;
         T000A2_n137proveedoresfecreg = new bool[] {false} ;
         T000A2_A138proveedoresfecultact = new DateTime[] {DateTime.MinValue} ;
         T000A2_n138proveedoresfecultact = new bool[] {false} ;
         T000A11_A19almacenid = new long[1] ;
         T000A11_A20articulosproductoid = new int[1] ;
         T000A11_A21articuloscambsid = new int[1] ;
         T000A12_A2proveedoresid = new int[1] ;
         T000A12_n2proveedoresid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proveedores__default(),
            new Object[][] {
                new Object[] {
               T000A2_A2proveedoresid, T000A2_A126proveedoresnombre, T000A2_n126proveedoresnombre, T000A2_A127proveedoresdireccion, T000A2_n127proveedoresdireccion, T000A2_A128proveedorescolonia, T000A2_n128proveedorescolonia, T000A2_A129proveedorescodigopostal, T000A2_n129proveedorescodigopostal, T000A2_A130proveedoresmunicipio,
               T000A2_n130proveedoresmunicipio, T000A2_A131proveedorestado, T000A2_n131proveedorestado, T000A2_A132proveedorestelefono1, T000A2_n132proveedorestelefono1, T000A2_A133proveedorestelefono2, T000A2_n133proveedorestelefono2, T000A2_A134proveedoresfax, T000A2_n134proveedoresfax, T000A2_A135proveedoresrfc,
               T000A2_n135proveedoresrfc, T000A2_A136proveedoresusuario, T000A2_n136proveedoresusuario, T000A2_A137proveedoresfecreg, T000A2_n137proveedoresfecreg, T000A2_A138proveedoresfecultact, T000A2_n138proveedoresfecultact
               }
               , new Object[] {
               T000A3_A2proveedoresid, T000A3_A126proveedoresnombre, T000A3_n126proveedoresnombre, T000A3_A127proveedoresdireccion, T000A3_n127proveedoresdireccion, T000A3_A128proveedorescolonia, T000A3_n128proveedorescolonia, T000A3_A129proveedorescodigopostal, T000A3_n129proveedorescodigopostal, T000A3_A130proveedoresmunicipio,
               T000A3_n130proveedoresmunicipio, T000A3_A131proveedorestado, T000A3_n131proveedorestado, T000A3_A132proveedorestelefono1, T000A3_n132proveedorestelefono1, T000A3_A133proveedorestelefono2, T000A3_n133proveedorestelefono2, T000A3_A134proveedoresfax, T000A3_n134proveedoresfax, T000A3_A135proveedoresrfc,
               T000A3_n135proveedoresrfc, T000A3_A136proveedoresusuario, T000A3_n136proveedoresusuario, T000A3_A137proveedoresfecreg, T000A3_n137proveedoresfecreg, T000A3_A138proveedoresfecultact, T000A3_n138proveedoresfecultact
               }
               , new Object[] {
               T000A4_A2proveedoresid, T000A4_A126proveedoresnombre, T000A4_n126proveedoresnombre, T000A4_A127proveedoresdireccion, T000A4_n127proveedoresdireccion, T000A4_A128proveedorescolonia, T000A4_n128proveedorescolonia, T000A4_A129proveedorescodigopostal, T000A4_n129proveedorescodigopostal, T000A4_A130proveedoresmunicipio,
               T000A4_n130proveedoresmunicipio, T000A4_A131proveedorestado, T000A4_n131proveedorestado, T000A4_A132proveedorestelefono1, T000A4_n132proveedorestelefono1, T000A4_A133proveedorestelefono2, T000A4_n133proveedorestelefono2, T000A4_A134proveedoresfax, T000A4_n134proveedoresfax, T000A4_A135proveedoresrfc,
               T000A4_n135proveedoresrfc, T000A4_A136proveedoresusuario, T000A4_n136proveedoresusuario, T000A4_A137proveedoresfecreg, T000A4_n137proveedoresfecreg, T000A4_A138proveedoresfecultact, T000A4_n138proveedoresfecultact
               }
               , new Object[] {
               T000A5_A2proveedoresid
               }
               , new Object[] {
               T000A6_A2proveedoresid
               }
               , new Object[] {
               T000A7_A2proveedoresid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A11_A19almacenid, T000A11_A20articulosproductoid, T000A11_A21articuloscambsid
               }
               , new Object[] {
               T000A12_A2proveedoresid
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
      private short RcdFound10 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z2proveedoresid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A2proveedoresid ;
      private int edtproveedoresid_Enabled ;
      private int edtproveedoresnombre_Enabled ;
      private int edtproveedoresdireccion_Enabled ;
      private int edtproveedorescolonia_Enabled ;
      private int edtproveedorescodigopostal_Enabled ;
      private int edtproveedoresmunicipio_Enabled ;
      private int edtproveedorestado_Enabled ;
      private int edtproveedorestelefono1_Enabled ;
      private int edtproveedorestelefono2_Enabled ;
      private int edtproveedoresfax_Enabled ;
      private int edtproveedoresrfc_Enabled ;
      private int edtproveedoresusuario_Enabled ;
      private int edtproveedoresfecreg_Enabled ;
      private int edtproveedoresfecultact_Enabled ;
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
      private String edtproveedoresid_Internalname ;
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
      private String edtproveedoresid_Jsonclick ;
      private String edtproveedoresnombre_Internalname ;
      private String edtproveedoresnombre_Jsonclick ;
      private String edtproveedoresdireccion_Internalname ;
      private String edtproveedoresdireccion_Jsonclick ;
      private String edtproveedorescolonia_Internalname ;
      private String edtproveedorescolonia_Jsonclick ;
      private String edtproveedorescodigopostal_Internalname ;
      private String edtproveedorescodigopostal_Jsonclick ;
      private String edtproveedoresmunicipio_Internalname ;
      private String edtproveedoresmunicipio_Jsonclick ;
      private String edtproveedorestado_Internalname ;
      private String edtproveedorestado_Jsonclick ;
      private String edtproveedorestelefono1_Internalname ;
      private String edtproveedorestelefono1_Jsonclick ;
      private String edtproveedorestelefono2_Internalname ;
      private String edtproveedorestelefono2_Jsonclick ;
      private String edtproveedoresfax_Internalname ;
      private String edtproveedoresfax_Jsonclick ;
      private String edtproveedoresrfc_Internalname ;
      private String edtproveedoresrfc_Jsonclick ;
      private String edtproveedoresusuario_Internalname ;
      private String edtproveedoresusuario_Jsonclick ;
      private String edtproveedoresfecreg_Internalname ;
      private String edtproveedoresfecreg_Jsonclick ;
      private String edtproveedoresfecultact_Internalname ;
      private String edtproveedoresfecultact_Jsonclick ;
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
      private String sMode10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z137proveedoresfecreg ;
      private DateTime Z138proveedoresfecultact ;
      private DateTime A137proveedoresfecreg ;
      private DateTime A138proveedoresfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n2proveedoresid ;
      private bool n126proveedoresnombre ;
      private bool n127proveedoresdireccion ;
      private bool n128proveedorescolonia ;
      private bool n129proveedorescodigopostal ;
      private bool n130proveedoresmunicipio ;
      private bool n131proveedorestado ;
      private bool n132proveedorestelefono1 ;
      private bool n133proveedorestelefono2 ;
      private bool n134proveedoresfax ;
      private bool n135proveedoresrfc ;
      private bool n136proveedoresusuario ;
      private bool n137proveedoresfecreg ;
      private bool n138proveedoresfecultact ;
      private bool Gx_longc ;
      private String Z126proveedoresnombre ;
      private String Z127proveedoresdireccion ;
      private String Z128proveedorescolonia ;
      private String Z129proveedorescodigopostal ;
      private String Z130proveedoresmunicipio ;
      private String Z131proveedorestado ;
      private String Z132proveedorestelefono1 ;
      private String Z133proveedorestelefono2 ;
      private String Z134proveedoresfax ;
      private String Z135proveedoresrfc ;
      private String Z136proveedoresusuario ;
      private String A126proveedoresnombre ;
      private String A127proveedoresdireccion ;
      private String A128proveedorescolonia ;
      private String A129proveedorescodigopostal ;
      private String A130proveedoresmunicipio ;
      private String A131proveedorestado ;
      private String A132proveedorestelefono1 ;
      private String A133proveedorestelefono2 ;
      private String A134proveedoresfax ;
      private String A135proveedoresrfc ;
      private String A136proveedoresusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000A4_A2proveedoresid ;
      private bool[] T000A4_n2proveedoresid ;
      private String[] T000A4_A126proveedoresnombre ;
      private bool[] T000A4_n126proveedoresnombre ;
      private String[] T000A4_A127proveedoresdireccion ;
      private bool[] T000A4_n127proveedoresdireccion ;
      private String[] T000A4_A128proveedorescolonia ;
      private bool[] T000A4_n128proveedorescolonia ;
      private String[] T000A4_A129proveedorescodigopostal ;
      private bool[] T000A4_n129proveedorescodigopostal ;
      private String[] T000A4_A130proveedoresmunicipio ;
      private bool[] T000A4_n130proveedoresmunicipio ;
      private String[] T000A4_A131proveedorestado ;
      private bool[] T000A4_n131proveedorestado ;
      private String[] T000A4_A132proveedorestelefono1 ;
      private bool[] T000A4_n132proveedorestelefono1 ;
      private String[] T000A4_A133proveedorestelefono2 ;
      private bool[] T000A4_n133proveedorestelefono2 ;
      private String[] T000A4_A134proveedoresfax ;
      private bool[] T000A4_n134proveedoresfax ;
      private String[] T000A4_A135proveedoresrfc ;
      private bool[] T000A4_n135proveedoresrfc ;
      private String[] T000A4_A136proveedoresusuario ;
      private bool[] T000A4_n136proveedoresusuario ;
      private DateTime[] T000A4_A137proveedoresfecreg ;
      private bool[] T000A4_n137proveedoresfecreg ;
      private DateTime[] T000A4_A138proveedoresfecultact ;
      private bool[] T000A4_n138proveedoresfecultact ;
      private int[] T000A5_A2proveedoresid ;
      private bool[] T000A5_n2proveedoresid ;
      private int[] T000A3_A2proveedoresid ;
      private bool[] T000A3_n2proveedoresid ;
      private String[] T000A3_A126proveedoresnombre ;
      private bool[] T000A3_n126proveedoresnombre ;
      private String[] T000A3_A127proveedoresdireccion ;
      private bool[] T000A3_n127proveedoresdireccion ;
      private String[] T000A3_A128proveedorescolonia ;
      private bool[] T000A3_n128proveedorescolonia ;
      private String[] T000A3_A129proveedorescodigopostal ;
      private bool[] T000A3_n129proveedorescodigopostal ;
      private String[] T000A3_A130proveedoresmunicipio ;
      private bool[] T000A3_n130proveedoresmunicipio ;
      private String[] T000A3_A131proveedorestado ;
      private bool[] T000A3_n131proveedorestado ;
      private String[] T000A3_A132proveedorestelefono1 ;
      private bool[] T000A3_n132proveedorestelefono1 ;
      private String[] T000A3_A133proveedorestelefono2 ;
      private bool[] T000A3_n133proveedorestelefono2 ;
      private String[] T000A3_A134proveedoresfax ;
      private bool[] T000A3_n134proveedoresfax ;
      private String[] T000A3_A135proveedoresrfc ;
      private bool[] T000A3_n135proveedoresrfc ;
      private String[] T000A3_A136proveedoresusuario ;
      private bool[] T000A3_n136proveedoresusuario ;
      private DateTime[] T000A3_A137proveedoresfecreg ;
      private bool[] T000A3_n137proveedoresfecreg ;
      private DateTime[] T000A3_A138proveedoresfecultact ;
      private bool[] T000A3_n138proveedoresfecultact ;
      private int[] T000A6_A2proveedoresid ;
      private bool[] T000A6_n2proveedoresid ;
      private int[] T000A7_A2proveedoresid ;
      private bool[] T000A7_n2proveedoresid ;
      private int[] T000A2_A2proveedoresid ;
      private bool[] T000A2_n2proveedoresid ;
      private String[] T000A2_A126proveedoresnombre ;
      private bool[] T000A2_n126proveedoresnombre ;
      private String[] T000A2_A127proveedoresdireccion ;
      private bool[] T000A2_n127proveedoresdireccion ;
      private String[] T000A2_A128proveedorescolonia ;
      private bool[] T000A2_n128proveedorescolonia ;
      private String[] T000A2_A129proveedorescodigopostal ;
      private bool[] T000A2_n129proveedorescodigopostal ;
      private String[] T000A2_A130proveedoresmunicipio ;
      private bool[] T000A2_n130proveedoresmunicipio ;
      private String[] T000A2_A131proveedorestado ;
      private bool[] T000A2_n131proveedorestado ;
      private String[] T000A2_A132proveedorestelefono1 ;
      private bool[] T000A2_n132proveedorestelefono1 ;
      private String[] T000A2_A133proveedorestelefono2 ;
      private bool[] T000A2_n133proveedorestelefono2 ;
      private String[] T000A2_A134proveedoresfax ;
      private bool[] T000A2_n134proveedoresfax ;
      private String[] T000A2_A135proveedoresrfc ;
      private bool[] T000A2_n135proveedoresrfc ;
      private String[] T000A2_A136proveedoresusuario ;
      private bool[] T000A2_n136proveedoresusuario ;
      private DateTime[] T000A2_A137proveedoresfecreg ;
      private bool[] T000A2_n137proveedoresfecreg ;
      private DateTime[] T000A2_A138proveedoresfecultact ;
      private bool[] T000A2_n138proveedoresfecultact ;
      private long[] T000A11_A19almacenid ;
      private int[] T000A11_A20articulosproductoid ;
      private int[] T000A11_A21articuloscambsid ;
      private int[] T000A12_A2proveedoresid ;
      private bool[] T000A12_n2proveedoresid ;
      private GXWebForm Form ;
   }

   public class proveedores__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000A4 ;
          prmT000A4 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A5 ;
          prmT000A5 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A3 ;
          prmT000A3 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A6 ;
          prmT000A6 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A7 ;
          prmT000A7 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A2 ;
          prmT000A2 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A8 ;
          prmT000A8 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"proveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"proveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"proveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"proveedoresmunicipio",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestelefono1",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"proveedorestelefono2",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"proveedoresfax",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresrfc",NpgsqlDbType.Varchar,13,0} ,
          new Object[] {"proveedoresusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"proveedoresfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000A9 ;
          prmT000A9 = new Object[] {
          new Object[] {"proveedoresnombre",NpgsqlDbType.Varchar,80,0} ,
          new Object[] {"proveedoresdireccion",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"proveedorescolonia",NpgsqlDbType.Varchar,25,0} ,
          new Object[] {"proveedorescodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"proveedoresmunicipio",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestado",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"proveedorestelefono1",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"proveedorestelefono2",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"proveedoresfax",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresrfc",NpgsqlDbType.Varchar,13,0} ,
          new Object[] {"proveedoresusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"proveedoresfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"proveedoresfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A10 ;
          prmT000A10 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A11 ;
          prmT000A11 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000A12 ;
          prmT000A12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000A2", "SELECT proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact FROM public.proveedores WHERE proveedoresid = :proveedoresid  FOR UPDATE OF proveedores NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
             ,new CursorDef("T000A3", "SELECT proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
             ,new CursorDef("T000A4", "SELECT TM1.proveedoresid, TM1.proveedoresnombre, TM1.proveedoresdireccion, TM1.proveedorescolonia, TM1.proveedorescodigopostal, TM1.proveedoresmunicipio, TM1.proveedorestado, TM1.proveedorestelefono1, TM1.proveedorestelefono2, TM1.proveedoresfax, TM1.proveedoresrfc, TM1.proveedoresusuario, TM1.proveedoresfecreg, TM1.proveedoresfecultact FROM public.proveedores TM1 WHERE TM1.proveedoresid = :proveedoresid ORDER BY TM1.proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,100,0,true,false )
             ,new CursorDef("T000A5", "SELECT proveedoresid FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,1,0,true,false )
             ,new CursorDef("T000A6", "SELECT proveedoresid FROM public.proveedores WHERE ( proveedoresid > :proveedoresid) ORDER BY proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,1,0,true,true )
             ,new CursorDef("T000A7", "SELECT proveedoresid FROM public.proveedores WHERE ( proveedoresid < :proveedoresid) ORDER BY proveedoresid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,1,0,true,true )
             ,new CursorDef("T000A8", "SAVEPOINT gxupdate;INSERT INTO public.proveedores(proveedoresid, proveedoresnombre, proveedoresdireccion, proveedorescolonia, proveedorescodigopostal, proveedoresmunicipio, proveedorestado, proveedorestelefono1, proveedorestelefono2, proveedoresfax, proveedoresrfc, proveedoresusuario, proveedoresfecreg, proveedoresfecultact) VALUES(:proveedoresid, :proveedoresnombre, :proveedoresdireccion, :proveedorescolonia, :proveedorescodigopostal, :proveedoresmunicipio, :proveedorestado, :proveedorestelefono1, :proveedorestelefono2, :proveedoresfax, :proveedoresrfc, :proveedoresusuario, :proveedoresfecreg, :proveedoresfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000A8)
             ,new CursorDef("T000A9", "SAVEPOINT gxupdate;UPDATE public.proveedores SET proveedoresnombre=:proveedoresnombre, proveedoresdireccion=:proveedoresdireccion, proveedorescolonia=:proveedorescolonia, proveedorescodigopostal=:proveedorescodigopostal, proveedoresmunicipio=:proveedoresmunicipio, proveedorestado=:proveedorestado, proveedorestelefono1=:proveedorestelefono1, proveedorestelefono2=:proveedorestelefono2, proveedoresfax=:proveedoresfax, proveedoresrfc=:proveedoresrfc, proveedoresusuario=:proveedoresusuario, proveedoresfecreg=:proveedoresfecreg, proveedoresfecultact=:proveedoresfecultact  WHERE proveedoresid = :proveedoresid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000A9)
             ,new CursorDef("T000A10", "SAVEPOINT gxupdate;DELETE FROM public.proveedores  WHERE proveedoresid = :proveedoresid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000A10)
             ,new CursorDef("T000A11", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE proveedorid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A11,1,0,true,true )
             ,new CursorDef("T000A12", "SELECT proveedoresid FROM public.proveedores ORDER BY proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A12,100,0,true,false )
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
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
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(14, (DateTime)parms[27]);
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
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(12, (DateTime)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(14, (int)parms[27]);
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
