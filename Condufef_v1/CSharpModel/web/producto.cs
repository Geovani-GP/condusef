/*
               File: producto
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:51.30
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
   public class producto : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7productoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7productoid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7productoid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtpcambsid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public producto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public producto( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_productoid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7productoid = aP1_productoid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "producto", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_producto.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ",", "")), ((edtproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductoid_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtpcambsid_Internalname, "pcambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtpcambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A179pcambsid), 4, 0, ",", "")), ((edtpcambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A179pcambsid), "ZZZ9")) : context.localUtil.Format( (decimal)(A179pcambsid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtpcambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtpcambsid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductodsc_Internalname, "productodsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproductodsc_Internalname, A87productodsc, StringUtil.RTrim( context.localUtil.Format( A87productodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductodsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtpmodeloid_Internalname, "pmodeloid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtpmodeloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A180pmodeloid), 4, 0, ",", "")), ((edtpmodeloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A180pmodeloid), "ZZZ9")) : context.localUtil.Format( (decimal)(A180pmodeloid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtpmodeloid_Jsonclick, 0, "Attribute", "", "", "", 1, edtpmodeloid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtpmarcaid_Internalname, "pmarcaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtpmarcaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A181pmarcaid), 4, 0, ",", "")), ((edtpmarcaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A181pmarcaid), "ZZZ9")) : context.localUtil.Format( (decimal)(A181pmarcaid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtpmarcaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtpmarcaid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtpcategoriaid_Internalname, "pcategoriaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtpcategoriaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A182pcategoriaid), 4, 0, ",", "")), ((edtpcategoriaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A182pcategoriaid), "ZZZ9")) : context.localUtil.Format( (decimal)(A182pcategoriaid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtpcategoriaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtpcategoriaid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductousuario_Internalname, "productousuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproductousuario_Internalname, A91productousuario, StringUtil.RTrim( context.localUtil.Format( A91productousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductousuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductofecreg_Internalname, "productofecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtproductofecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtproductofecreg_Internalname, context.localUtil.Format(A92productofecreg, "99/99/9999"), context.localUtil.Format( A92productofecreg, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductofecreg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
            GxWebStd.gx_bitmap( context, edtproductofecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtproductofecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductofecultact_Internalname, "productofecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtproductofecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtproductofecultact_Internalname, context.localUtil.Format(A93productofecultact, "99/99/9999"), context.localUtil.Format( A93productofecultact, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductofecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductofecultact_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
            GxWebStd.gx_bitmap( context, edtproductofecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtproductofecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtptipobienid_Internalname, "ptipobienid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtptipobienid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A183ptipobienid), 4, 0, ",", "")), ((edtptipobienid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A183ptipobienid), "ZZZ9")) : context.localUtil.Format( (decimal)(A183ptipobienid), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtptipobienid_Jsonclick, 0, "Attribute", "", "", "", 1, edtptipobienid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            GxWebStd.gx_div_end( context, "left", "top");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
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
               A175productoid = (int)(context.localUtil.CToN( cgiGet( edtproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtpcambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtpcambsid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PCAMBSID");
                  AnyError = 1;
                  GX_FocusControl = edtpcambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A179pcambsid = 0;
                  n179pcambsid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A179pcambsid), 4, 0)));
               }
               else
               {
                  A179pcambsid = (short)(context.localUtil.CToN( cgiGet( edtpcambsid_Internalname), ",", "."));
                  n179pcambsid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A179pcambsid), 4, 0)));
               }
               n179pcambsid = ((0==A179pcambsid) ? true : false);
               A87productodsc = cgiGet( edtproductodsc_Internalname);
               n87productodsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
               n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtpmodeloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtpmodeloid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PMODELOID");
                  AnyError = 1;
                  GX_FocusControl = edtpmodeloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A180pmodeloid = 0;
                  n180pmodeloid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180pmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A180pmodeloid), 4, 0)));
               }
               else
               {
                  A180pmodeloid = (short)(context.localUtil.CToN( cgiGet( edtpmodeloid_Internalname), ",", "."));
                  n180pmodeloid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180pmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A180pmodeloid), 4, 0)));
               }
               n180pmodeloid = ((0==A180pmodeloid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtpmarcaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtpmarcaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PMARCAID");
                  AnyError = 1;
                  GX_FocusControl = edtpmarcaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A181pmarcaid = 0;
                  n181pmarcaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181pmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A181pmarcaid), 4, 0)));
               }
               else
               {
                  A181pmarcaid = (short)(context.localUtil.CToN( cgiGet( edtpmarcaid_Internalname), ",", "."));
                  n181pmarcaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181pmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A181pmarcaid), 4, 0)));
               }
               n181pmarcaid = ((0==A181pmarcaid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtpcategoriaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtpcategoriaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PCATEGORIAID");
                  AnyError = 1;
                  GX_FocusControl = edtpcategoriaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A182pcategoriaid = 0;
                  n182pcategoriaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182pcategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A182pcategoriaid), 4, 0)));
               }
               else
               {
                  A182pcategoriaid = (short)(context.localUtil.CToN( cgiGet( edtpcategoriaid_Internalname), ",", "."));
                  n182pcategoriaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182pcategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A182pcategoriaid), 4, 0)));
               }
               n182pcategoriaid = ((0==A182pcategoriaid) ? true : false);
               A91productousuario = cgiGet( edtproductousuario_Internalname);
               n91productousuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
               n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtproductofecreg_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"productofecreg"}), 1, "PRODUCTOFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtproductofecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A92productofecreg = DateTime.MinValue;
                  n92productofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.Format(A92productofecreg, "99/99/9999"));
               }
               else
               {
                  A92productofecreg = context.localUtil.CToD( cgiGet( edtproductofecreg_Internalname), 2);
                  n92productofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.Format(A92productofecreg, "99/99/9999"));
               }
               n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtproductofecultact_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"productofecultact"}), 1, "PRODUCTOFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtproductofecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A93productofecultact = DateTime.MinValue;
                  n93productofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.Format(A93productofecultact, "99/99/9999"));
               }
               else
               {
                  A93productofecultact = context.localUtil.CToD( cgiGet( edtproductofecultact_Internalname), 2);
                  n93productofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.Format(A93productofecultact, "99/99/9999"));
               }
               n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtptipobienid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtptipobienid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PTIPOBIENID");
                  AnyError = 1;
                  GX_FocusControl = edtptipobienid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A183ptipobienid = 0;
                  n183ptipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A183ptipobienid), 4, 0)));
               }
               else
               {
                  A183ptipobienid = (short)(context.localUtil.CToN( cgiGet( edtptipobienid_Internalname), ",", "."));
                  n183ptipobienid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A183ptipobienid), 4, 0)));
               }
               n183ptipobienid = ((0==A183ptipobienid) ? true : false);
               /* Read saved values. */
               Z175productoid = (int)(context.localUtil.CToN( cgiGet( "Z175productoid"), ",", "."));
               Z179pcambsid = (short)(context.localUtil.CToN( cgiGet( "Z179pcambsid"), ",", "."));
               n179pcambsid = ((0==A179pcambsid) ? true : false);
               Z87productodsc = cgiGet( "Z87productodsc");
               n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
               Z180pmodeloid = (short)(context.localUtil.CToN( cgiGet( "Z180pmodeloid"), ",", "."));
               n180pmodeloid = ((0==A180pmodeloid) ? true : false);
               Z181pmarcaid = (short)(context.localUtil.CToN( cgiGet( "Z181pmarcaid"), ",", "."));
               n181pmarcaid = ((0==A181pmarcaid) ? true : false);
               Z182pcategoriaid = (short)(context.localUtil.CToN( cgiGet( "Z182pcategoriaid"), ",", "."));
               n182pcategoriaid = ((0==A182pcategoriaid) ? true : false);
               Z91productousuario = cgiGet( "Z91productousuario");
               n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
               Z92productofecreg = context.localUtil.CToD( cgiGet( "Z92productofecreg"), 0);
               n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
               Z93productofecultact = context.localUtil.CToD( cgiGet( "Z93productofecultact"), 0);
               n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
               Z183ptipobienid = (short)(context.localUtil.CToN( cgiGet( "Z183ptipobienid"), ",", "."));
               n183ptipobienid = ((0==A183ptipobienid) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7productoid = (int)(context.localUtil.CToN( cgiGet( "vPRODUCTOID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "producto";
               A175productoid = (int)(context.localUtil.CToN( cgiGet( edtproductoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A175productoid != Z175productoid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("producto:[SecurityCheckFailed value for]"+"productoid:"+context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("producto:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A175productoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
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
                     sMode23 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode23;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound23 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_090( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PRODUCTOID");
                        AnyError = 1;
                        GX_FocusControl = edtproductoid_Internalname;
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
               InitAll0923( ) ;
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
            DisableAttributes0923( ) ;
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

      protected void CONFIRM_090( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0923( ) ;
            }
            else
            {
               CheckExtendedTable0923( ) ;
               CloseExtendedTableCursors0923( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption090( )
      {
      }

      protected void ZM0923( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z179pcambsid = T00093_A179pcambsid[0];
               Z87productodsc = T00093_A87productodsc[0];
               Z180pmodeloid = T00093_A180pmodeloid[0];
               Z181pmarcaid = T00093_A181pmarcaid[0];
               Z182pcategoriaid = T00093_A182pcategoriaid[0];
               Z91productousuario = T00093_A91productousuario[0];
               Z92productofecreg = T00093_A92productofecreg[0];
               Z93productofecultact = T00093_A93productofecultact[0];
               Z183ptipobienid = T00093_A183ptipobienid[0];
            }
            else
            {
               Z179pcambsid = A179pcambsid;
               Z87productodsc = A87productodsc;
               Z180pmodeloid = A180pmodeloid;
               Z181pmarcaid = A181pmarcaid;
               Z182pcategoriaid = A182pcategoriaid;
               Z91productousuario = A91productousuario;
               Z92productofecreg = A92productofecreg;
               Z93productofecultact = A93productofecultact;
               Z183ptipobienid = A183ptipobienid;
            }
         }
         if ( GX_JID == -3 )
         {
            Z175productoid = A175productoid;
            Z179pcambsid = A179pcambsid;
            Z87productodsc = A87productodsc;
            Z180pmodeloid = A180pmodeloid;
            Z181pmarcaid = A181pmarcaid;
            Z182pcategoriaid = A182pcategoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z183ptipobienid = A183ptipobienid;
         }
      }

      protected void standaloneNotModal( )
      {
         edtproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductoid_Enabled), 5, 0)));
         edtproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductoid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7productoid) )
         {
            A175productoid = AV7productoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
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

      protected void Load0923( )
      {
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A175productoid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound23 = 1;
            A179pcambsid = T00094_A179pcambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A179pcambsid), 4, 0)));
            n179pcambsid = T00094_n179pcambsid[0];
            A87productodsc = T00094_A87productodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
            n87productodsc = T00094_n87productodsc[0];
            A180pmodeloid = T00094_A180pmodeloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180pmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A180pmodeloid), 4, 0)));
            n180pmodeloid = T00094_n180pmodeloid[0];
            A181pmarcaid = T00094_A181pmarcaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181pmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A181pmarcaid), 4, 0)));
            n181pmarcaid = T00094_n181pmarcaid[0];
            A182pcategoriaid = T00094_A182pcategoriaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182pcategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A182pcategoriaid), 4, 0)));
            n182pcategoriaid = T00094_n182pcategoriaid[0];
            A91productousuario = T00094_A91productousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
            n91productousuario = T00094_n91productousuario[0];
            A92productofecreg = T00094_A92productofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.Format(A92productofecreg, "99/99/9999"));
            n92productofecreg = T00094_n92productofecreg[0];
            A93productofecultact = T00094_A93productofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.Format(A93productofecultact, "99/99/9999"));
            n93productofecultact = T00094_n93productofecultact[0];
            A183ptipobienid = T00094_A183ptipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A183ptipobienid), 4, 0)));
            n183ptipobienid = T00094_n183ptipobienid[0];
            ZM0923( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0923( ) ;
      }

      protected void OnLoadActions0923( )
      {
      }

      protected void CheckExtendedTable0923( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0923( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0923( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A175productoid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A175productoid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0923( 3) ;
            RcdFound23 = 1;
            A175productoid = T00093_A175productoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
            A179pcambsid = T00093_A179pcambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A179pcambsid), 4, 0)));
            n179pcambsid = T00093_n179pcambsid[0];
            A87productodsc = T00093_A87productodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
            n87productodsc = T00093_n87productodsc[0];
            A180pmodeloid = T00093_A180pmodeloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180pmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A180pmodeloid), 4, 0)));
            n180pmodeloid = T00093_n180pmodeloid[0];
            A181pmarcaid = T00093_A181pmarcaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181pmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A181pmarcaid), 4, 0)));
            n181pmarcaid = T00093_n181pmarcaid[0];
            A182pcategoriaid = T00093_A182pcategoriaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182pcategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A182pcategoriaid), 4, 0)));
            n182pcategoriaid = T00093_n182pcategoriaid[0];
            A91productousuario = T00093_A91productousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
            n91productousuario = T00093_n91productousuario[0];
            A92productofecreg = T00093_A92productofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.Format(A92productofecreg, "99/99/9999"));
            n92productofecreg = T00093_n92productofecreg[0];
            A93productofecultact = T00093_A93productofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.Format(A93productofecultact, "99/99/9999"));
            n93productofecultact = T00093_n93productofecultact[0];
            A183ptipobienid = T00093_A183ptipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A183ptipobienid), 4, 0)));
            n183ptipobienid = T00093_n183ptipobienid[0];
            Z175productoid = A175productoid;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0923( ) ;
            if ( AnyError == 1 )
            {
               RcdFound23 = 0;
               InitializeNonKey0923( ) ;
            }
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound23 = 0;
            InitializeNonKey0923( ) ;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0923( ) ;
         if ( RcdFound23 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound23 = 0;
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A175productoid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00096_A175productoid[0] < A175productoid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00096_A175productoid[0] > A175productoid ) ) )
            {
               A175productoid = T00096_A175productoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
               RcdFound23 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound23 = 0;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A175productoid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00097_A175productoid[0] > A175productoid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00097_A175productoid[0] < A175productoid ) ) )
            {
               A175productoid = T00097_A175productoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
               RcdFound23 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0923( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtpcambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0923( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound23 == 1 )
            {
               if ( A175productoid != Z175productoid )
               {
                  A175productoid = Z175productoid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PRODUCTOID");
                  AnyError = 1;
                  GX_FocusControl = edtproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtpcambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0923( ) ;
                  GX_FocusControl = edtpcambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A175productoid != Z175productoid )
               {
                  /* Insert record */
                  GX_FocusControl = edtpcambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0923( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PRODUCTOID");
                     AnyError = 1;
                     GX_FocusControl = edtproductoid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtpcambsid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0923( ) ;
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
         if ( A175productoid != Z175productoid )
         {
            A175productoid = Z175productoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtpcambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0923( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A175productoid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PRODUCTO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z179pcambsid != T00092_A179pcambsid[0] ) || ( StringUtil.StrCmp(Z87productodsc, T00092_A87productodsc[0]) != 0 ) || ( Z180pmodeloid != T00092_A180pmodeloid[0] ) || ( Z181pmarcaid != T00092_A181pmarcaid[0] ) || ( Z182pcategoriaid != T00092_A182pcategoriaid[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z91productousuario, T00092_A91productousuario[0]) != 0 ) || ( Z92productofecreg != T00092_A92productofecreg[0] ) || ( Z93productofecultact != T00092_A93productofecultact[0] ) || ( Z183ptipobienid != T00092_A183ptipobienid[0] ) )
            {
               if ( Z179pcambsid != T00092_A179pcambsid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"pcambsid");
                  GXUtil.WriteLogRaw("Old: ",Z179pcambsid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A179pcambsid[0]);
               }
               if ( StringUtil.StrCmp(Z87productodsc, T00092_A87productodsc[0]) != 0 )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"productodsc");
                  GXUtil.WriteLogRaw("Old: ",Z87productodsc);
                  GXUtil.WriteLogRaw("Current: ",T00092_A87productodsc[0]);
               }
               if ( Z180pmodeloid != T00092_A180pmodeloid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"pmodeloid");
                  GXUtil.WriteLogRaw("Old: ",Z180pmodeloid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A180pmodeloid[0]);
               }
               if ( Z181pmarcaid != T00092_A181pmarcaid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"pmarcaid");
                  GXUtil.WriteLogRaw("Old: ",Z181pmarcaid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A181pmarcaid[0]);
               }
               if ( Z182pcategoriaid != T00092_A182pcategoriaid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"pcategoriaid");
                  GXUtil.WriteLogRaw("Old: ",Z182pcategoriaid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A182pcategoriaid[0]);
               }
               if ( StringUtil.StrCmp(Z91productousuario, T00092_A91productousuario[0]) != 0 )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"productousuario");
                  GXUtil.WriteLogRaw("Old: ",Z91productousuario);
                  GXUtil.WriteLogRaw("Current: ",T00092_A91productousuario[0]);
               }
               if ( Z92productofecreg != T00092_A92productofecreg[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"productofecreg");
                  GXUtil.WriteLogRaw("Old: ",Z92productofecreg);
                  GXUtil.WriteLogRaw("Current: ",T00092_A92productofecreg[0]);
               }
               if ( Z93productofecultact != T00092_A93productofecultact[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"productofecultact");
                  GXUtil.WriteLogRaw("Old: ",Z93productofecultact);
                  GXUtil.WriteLogRaw("Current: ",T00092_A93productofecultact[0]);
               }
               if ( Z183ptipobienid != T00092_A183ptipobienid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"ptipobienid");
                  GXUtil.WriteLogRaw("Old: ",Z183ptipobienid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A183ptipobienid[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PRODUCTO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0923( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0923( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0923( 0) ;
            CheckOptimisticConcurrency0923( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0923( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0923( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00098 */
                     pr_default.execute(6, new Object[] {A175productoid, n179pcambsid, A179pcambsid, n87productodsc, A87productodsc, n180pmodeloid, A180pmodeloid, n181pmarcaid, A181pmarcaid, n182pcategoriaid, A182pcategoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n183ptipobienid, A183ptipobienid});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
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
                           ResetCaption090( ) ;
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
               Load0923( ) ;
            }
            EndLevel0923( ) ;
         }
         CloseExtendedTableCursors0923( ) ;
      }

      protected void Update0923( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0923( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0923( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0923( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0923( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00099 */
                     pr_default.execute(7, new Object[] {n179pcambsid, A179pcambsid, n87productodsc, A87productodsc, n180pmodeloid, A180pmodeloid, n181pmarcaid, A181pmarcaid, n182pcategoriaid, A182pcategoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, n183ptipobienid, A183ptipobienid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PRODUCTO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0923( ) ;
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
            EndLevel0923( ) ;
         }
         CloseExtendedTableCursors0923( ) ;
      }

      protected void DeferredUpdate0923( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0923( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0923( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0923( ) ;
            AfterConfirm0923( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0923( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000910 */
                  pr_default.execute(8);
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("PRODUCTO") ;
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
         sMode23 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0923( ) ;
         Gx_mode = sMode23;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0923( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0923( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0923( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "producto");
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "producto");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0923( )
      {
         /* Scan By routine */
         /* Using cursor T000911 */
         pr_default.execute(9);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = T000911_A175productoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0923( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound23 = 1;
            A175productoid = T000911_A175productoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
         }
      }

      protected void ScanEnd0923( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0923( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0923( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0923( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0923( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0923( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0923( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0923( )
      {
         edtproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductoid_Enabled), 5, 0)));
         edtpcambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtpcambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtpcambsid_Enabled), 5, 0)));
         edtproductodsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductodsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductodsc_Enabled), 5, 0)));
         edtpmodeloid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtpmodeloid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtpmodeloid_Enabled), 5, 0)));
         edtpmarcaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtpmarcaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtpmarcaid_Enabled), 5, 0)));
         edtpcategoriaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtpcategoriaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtpcategoriaid_Enabled), 5, 0)));
         edtproductousuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductousuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductousuario_Enabled), 5, 0)));
         edtproductofecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductofecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductofecreg_Enabled), 5, 0)));
         edtproductofecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductofecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductofecultact_Enabled), 5, 0)));
         edtptipobienid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtptipobienid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtptipobienid_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
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
         context.AddJavascriptSource("gxcfg.js", "?202221558527");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("producto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7productoid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z175productoid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z175productoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z179pcambsid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z179pcambsid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z87productodsc", Z87productodsc);
         GxWebStd.gx_hidden_field( context, "Z180pmodeloid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z180pmodeloid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z181pmarcaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z181pmarcaid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z182pcategoriaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z182pcategoriaid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z91productousuario", Z91productousuario);
         GxWebStd.gx_hidden_field( context, "Z92productofecreg", context.localUtil.DToC( Z92productofecreg, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z93productofecultact", context.localUtil.DToC( Z93productofecultact, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z183ptipobienid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z183ptipobienid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vPRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7productoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7productoid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "producto";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("producto:[SendSecurityCheck value for]"+"productoid:"+context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("producto:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("producto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7productoid) ;
      }

      public override String GetPgmname( )
      {
         return "producto" ;
      }

      public override String GetPgmdesc( )
      {
         return "producto" ;
      }

      protected void InitializeNonKey0923( )
      {
         A179pcambsid = 0;
         n179pcambsid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179pcambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A179pcambsid), 4, 0)));
         n179pcambsid = ((0==A179pcambsid) ? true : false);
         A87productodsc = "";
         n87productodsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
         n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
         A180pmodeloid = 0;
         n180pmodeloid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180pmodeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A180pmodeloid), 4, 0)));
         n180pmodeloid = ((0==A180pmodeloid) ? true : false);
         A181pmarcaid = 0;
         n181pmarcaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181pmarcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A181pmarcaid), 4, 0)));
         n181pmarcaid = ((0==A181pmarcaid) ? true : false);
         A182pcategoriaid = 0;
         n182pcategoriaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182pcategoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A182pcategoriaid), 4, 0)));
         n182pcategoriaid = ((0==A182pcategoriaid) ? true : false);
         A91productousuario = "";
         n91productousuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
         n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
         A92productofecreg = DateTime.MinValue;
         n92productofecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.Format(A92productofecreg, "99/99/9999"));
         n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
         A93productofecultact = DateTime.MinValue;
         n93productofecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.Format(A93productofecultact, "99/99/9999"));
         n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
         A183ptipobienid = 0;
         n183ptipobienid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ptipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A183ptipobienid), 4, 0)));
         n183ptipobienid = ((0==A183ptipobienid) ? true : false);
         Z179pcambsid = 0;
         Z87productodsc = "";
         Z180pmodeloid = 0;
         Z181pmarcaid = 0;
         Z182pcategoriaid = 0;
         Z91productousuario = "";
         Z92productofecreg = DateTime.MinValue;
         Z93productofecultact = DateTime.MinValue;
         Z183ptipobienid = 0;
      }

      protected void InitAll0923( )
      {
         A175productoid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175productoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A175productoid), 9, 0)));
         InitializeNonKey0923( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215585213");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("producto.js", "?2022215585213");
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
         edtproductoid_Internalname = "PRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtpcambsid_Internalname = "PCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproductodsc_Internalname = "PRODUCTODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtpmodeloid_Internalname = "PMODELOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtpmarcaid_Internalname = "PMARCAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtpcategoriaid_Internalname = "PCATEGORIAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproductousuario_Internalname = "PRODUCTOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproductofecreg_Internalname = "PRODUCTOFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproductofecultact_Internalname = "PRODUCTOFECULTACT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtptipobienid_Internalname = "PTIPOBIENID";
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
         Form.Caption = "producto";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtptipobienid_Jsonclick = "";
         edtptipobienid_Enabled = 1;
         edtproductofecultact_Jsonclick = "";
         edtproductofecultact_Enabled = 1;
         edtproductofecreg_Jsonclick = "";
         edtproductofecreg_Enabled = 1;
         edtproductousuario_Jsonclick = "";
         edtproductousuario_Enabled = 1;
         edtpcategoriaid_Jsonclick = "";
         edtpcategoriaid_Enabled = 1;
         edtpmarcaid_Jsonclick = "";
         edtpmarcaid_Enabled = 1;
         edtpmodeloid_Jsonclick = "";
         edtpmodeloid_Enabled = 1;
         edtproductodsc_Jsonclick = "";
         edtproductodsc_Enabled = 1;
         edtpcambsid_Jsonclick = "";
         edtpcambsid_Enabled = 1;
         edtproductoid_Jsonclick = "";
         edtproductoid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7productoid',fld:'vPRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z87productodsc = "";
         Z91productousuario = "";
         Z92productofecreg = DateTime.MinValue;
         Z93productofecultact = DateTime.MinValue;
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
         A87productodsc = "";
         A91productousuario = "";
         A92productofecreg = DateTime.MinValue;
         A93productofecultact = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode23 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00094_A175productoid = new int[1] ;
         T00094_A179pcambsid = new short[1] ;
         T00094_n179pcambsid = new bool[] {false} ;
         T00094_A87productodsc = new String[] {""} ;
         T00094_n87productodsc = new bool[] {false} ;
         T00094_A180pmodeloid = new short[1] ;
         T00094_n180pmodeloid = new bool[] {false} ;
         T00094_A181pmarcaid = new short[1] ;
         T00094_n181pmarcaid = new bool[] {false} ;
         T00094_A182pcategoriaid = new short[1] ;
         T00094_n182pcategoriaid = new bool[] {false} ;
         T00094_A91productousuario = new String[] {""} ;
         T00094_n91productousuario = new bool[] {false} ;
         T00094_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00094_n92productofecreg = new bool[] {false} ;
         T00094_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00094_n93productofecultact = new bool[] {false} ;
         T00094_A183ptipobienid = new short[1] ;
         T00094_n183ptipobienid = new bool[] {false} ;
         T00095_A175productoid = new int[1] ;
         T00093_A175productoid = new int[1] ;
         T00093_A179pcambsid = new short[1] ;
         T00093_n179pcambsid = new bool[] {false} ;
         T00093_A87productodsc = new String[] {""} ;
         T00093_n87productodsc = new bool[] {false} ;
         T00093_A180pmodeloid = new short[1] ;
         T00093_n180pmodeloid = new bool[] {false} ;
         T00093_A181pmarcaid = new short[1] ;
         T00093_n181pmarcaid = new bool[] {false} ;
         T00093_A182pcategoriaid = new short[1] ;
         T00093_n182pcategoriaid = new bool[] {false} ;
         T00093_A91productousuario = new String[] {""} ;
         T00093_n91productousuario = new bool[] {false} ;
         T00093_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00093_n92productofecreg = new bool[] {false} ;
         T00093_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00093_n93productofecultact = new bool[] {false} ;
         T00093_A183ptipobienid = new short[1] ;
         T00093_n183ptipobienid = new bool[] {false} ;
         T00096_A175productoid = new int[1] ;
         T00097_A175productoid = new int[1] ;
         T00092_A175productoid = new int[1] ;
         T00092_A179pcambsid = new short[1] ;
         T00092_n179pcambsid = new bool[] {false} ;
         T00092_A87productodsc = new String[] {""} ;
         T00092_n87productodsc = new bool[] {false} ;
         T00092_A180pmodeloid = new short[1] ;
         T00092_n180pmodeloid = new bool[] {false} ;
         T00092_A181pmarcaid = new short[1] ;
         T00092_n181pmarcaid = new bool[] {false} ;
         T00092_A182pcategoriaid = new short[1] ;
         T00092_n182pcategoriaid = new bool[] {false} ;
         T00092_A91productousuario = new String[] {""} ;
         T00092_n91productousuario = new bool[] {false} ;
         T00092_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00092_n92productofecreg = new bool[] {false} ;
         T00092_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00092_n93productofecultact = new bool[] {false} ;
         T00092_A183ptipobienid = new short[1] ;
         T00092_n183ptipobienid = new bool[] {false} ;
         T000911_A175productoid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producto__default(),
            new Object[][] {
                new Object[] {
               T00092_A175productoid, T00092_A179pcambsid, T00092_n179pcambsid, T00092_A87productodsc, T00092_n87productodsc, T00092_A180pmodeloid, T00092_n180pmodeloid, T00092_A181pmarcaid, T00092_n181pmarcaid, T00092_A182pcategoriaid,
               T00092_n182pcategoriaid, T00092_A91productousuario, T00092_n91productousuario, T00092_A92productofecreg, T00092_n92productofecreg, T00092_A93productofecultact, T00092_n93productofecultact, T00092_A183ptipobienid, T00092_n183ptipobienid
               }
               , new Object[] {
               T00093_A175productoid, T00093_A179pcambsid, T00093_n179pcambsid, T00093_A87productodsc, T00093_n87productodsc, T00093_A180pmodeloid, T00093_n180pmodeloid, T00093_A181pmarcaid, T00093_n181pmarcaid, T00093_A182pcategoriaid,
               T00093_n182pcategoriaid, T00093_A91productousuario, T00093_n91productousuario, T00093_A92productofecreg, T00093_n92productofecreg, T00093_A93productofecultact, T00093_n93productofecultact, T00093_A183ptipobienid, T00093_n183ptipobienid
               }
               , new Object[] {
               T00094_A175productoid, T00094_A179pcambsid, T00094_n179pcambsid, T00094_A87productodsc, T00094_n87productodsc, T00094_A180pmodeloid, T00094_n180pmodeloid, T00094_A181pmarcaid, T00094_n181pmarcaid, T00094_A182pcategoriaid,
               T00094_n182pcategoriaid, T00094_A91productousuario, T00094_n91productousuario, T00094_A92productofecreg, T00094_n92productofecreg, T00094_A93productofecultact, T00094_n93productofecultact, T00094_A183ptipobienid, T00094_n183ptipobienid
               }
               , new Object[] {
               T00095_A175productoid
               }
               , new Object[] {
               T00096_A175productoid
               }
               , new Object[] {
               T00097_A175productoid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000911_A175productoid
               }
            }
         );
      }

      private short Z179pcambsid ;
      private short Z180pmodeloid ;
      private short Z181pmarcaid ;
      private short Z182pcategoriaid ;
      private short Z183ptipobienid ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A179pcambsid ;
      private short A180pmodeloid ;
      private short A181pmarcaid ;
      private short A182pcategoriaid ;
      private short A183ptipobienid ;
      private short RcdFound23 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7productoid ;
      private int Z175productoid ;
      private int AV7productoid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A175productoid ;
      private int edtproductoid_Enabled ;
      private int edtpcambsid_Enabled ;
      private int edtproductodsc_Enabled ;
      private int edtpmodeloid_Enabled ;
      private int edtpmarcaid_Enabled ;
      private int edtpcategoriaid_Enabled ;
      private int edtproductousuario_Enabled ;
      private int edtproductofecreg_Enabled ;
      private int edtproductofecultact_Enabled ;
      private int edtptipobienid_Enabled ;
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
      private String edtpcambsid_Internalname ;
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
      private String edtproductoid_Internalname ;
      private String edtproductoid_Jsonclick ;
      private String edtpcambsid_Jsonclick ;
      private String edtproductodsc_Internalname ;
      private String edtproductodsc_Jsonclick ;
      private String edtpmodeloid_Internalname ;
      private String edtpmodeloid_Jsonclick ;
      private String edtpmarcaid_Internalname ;
      private String edtpmarcaid_Jsonclick ;
      private String edtpcategoriaid_Internalname ;
      private String edtpcategoriaid_Jsonclick ;
      private String edtproductousuario_Internalname ;
      private String edtproductousuario_Jsonclick ;
      private String edtproductofecreg_Internalname ;
      private String edtproductofecreg_Jsonclick ;
      private String edtproductofecultact_Internalname ;
      private String edtproductofecultact_Jsonclick ;
      private String edtptipobienid_Internalname ;
      private String edtptipobienid_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode23 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z92productofecreg ;
      private DateTime Z93productofecultact ;
      private DateTime A92productofecreg ;
      private DateTime A93productofecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n179pcambsid ;
      private bool n87productodsc ;
      private bool n180pmodeloid ;
      private bool n181pmarcaid ;
      private bool n182pcategoriaid ;
      private bool n91productousuario ;
      private bool n92productofecreg ;
      private bool n93productofecultact ;
      private bool n183ptipobienid ;
      private bool Gx_longc ;
      private String Z87productodsc ;
      private String Z91productousuario ;
      private String A87productodsc ;
      private String A91productousuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00094_A175productoid ;
      private short[] T00094_A179pcambsid ;
      private bool[] T00094_n179pcambsid ;
      private String[] T00094_A87productodsc ;
      private bool[] T00094_n87productodsc ;
      private short[] T00094_A180pmodeloid ;
      private bool[] T00094_n180pmodeloid ;
      private short[] T00094_A181pmarcaid ;
      private bool[] T00094_n181pmarcaid ;
      private short[] T00094_A182pcategoriaid ;
      private bool[] T00094_n182pcategoriaid ;
      private String[] T00094_A91productousuario ;
      private bool[] T00094_n91productousuario ;
      private DateTime[] T00094_A92productofecreg ;
      private bool[] T00094_n92productofecreg ;
      private DateTime[] T00094_A93productofecultact ;
      private bool[] T00094_n93productofecultact ;
      private short[] T00094_A183ptipobienid ;
      private bool[] T00094_n183ptipobienid ;
      private int[] T00095_A175productoid ;
      private int[] T00093_A175productoid ;
      private short[] T00093_A179pcambsid ;
      private bool[] T00093_n179pcambsid ;
      private String[] T00093_A87productodsc ;
      private bool[] T00093_n87productodsc ;
      private short[] T00093_A180pmodeloid ;
      private bool[] T00093_n180pmodeloid ;
      private short[] T00093_A181pmarcaid ;
      private bool[] T00093_n181pmarcaid ;
      private short[] T00093_A182pcategoriaid ;
      private bool[] T00093_n182pcategoriaid ;
      private String[] T00093_A91productousuario ;
      private bool[] T00093_n91productousuario ;
      private DateTime[] T00093_A92productofecreg ;
      private bool[] T00093_n92productofecreg ;
      private DateTime[] T00093_A93productofecultact ;
      private bool[] T00093_n93productofecultact ;
      private short[] T00093_A183ptipobienid ;
      private bool[] T00093_n183ptipobienid ;
      private int[] T00096_A175productoid ;
      private int[] T00097_A175productoid ;
      private int[] T00092_A175productoid ;
      private short[] T00092_A179pcambsid ;
      private bool[] T00092_n179pcambsid ;
      private String[] T00092_A87productodsc ;
      private bool[] T00092_n87productodsc ;
      private short[] T00092_A180pmodeloid ;
      private bool[] T00092_n180pmodeloid ;
      private short[] T00092_A181pmarcaid ;
      private bool[] T00092_n181pmarcaid ;
      private short[] T00092_A182pcategoriaid ;
      private bool[] T00092_n182pcategoriaid ;
      private String[] T00092_A91productousuario ;
      private bool[] T00092_n91productousuario ;
      private DateTime[] T00092_A92productofecreg ;
      private bool[] T00092_n92productofecreg ;
      private DateTime[] T00092_A93productofecultact ;
      private bool[] T00092_n93productofecultact ;
      private short[] T00092_A183ptipobienid ;
      private bool[] T00092_n183ptipobienid ;
      private int[] T000911_A175productoid ;
      private GXWebForm Form ;
   }

   public class producto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"productoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"pcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"pmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pmarcaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pcategoriaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"productofecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"ptipobienid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"pcambsid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"pmodeloid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pmarcaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"pcategoriaid",NpgsqlDbType.Smallint,4,0} ,
          new Object[] {"productousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"productofecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"productofecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"ptipobienid",NpgsqlDbType.Smallint,4,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid FROM public.producto WHERE productoid = :productoid  FOR UPDATE OF producto NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid FROM public.producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT TM1.productoid, TM1.pcambsid, TM1.productodsc, TM1.pmodeloid, TM1.pmarcaid, TM1.pcategoriaid, TM1.productousuario, TM1.productofecreg, TM1.productofecultact, TM1.ptipobienid FROM public.producto TM1 WHERE TM1.productoid = :productoid ORDER BY TM1.productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,100,0,true,false )
             ,new CursorDef("T00095", "SELECT productoid FROM public.producto WHERE productoid = :productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT productoid FROM public.producto WHERE ( productoid > :productoid) ORDER BY productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,true )
             ,new CursorDef("T00097", "SELECT productoid FROM public.producto WHERE ( productoid < :productoid) ORDER BY productoid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,true )
             ,new CursorDef("T00098", "SAVEPOINT gxupdate;INSERT INTO public.producto(productoid, pcambsid, productodsc, pmodeloid, pmarcaid, pcategoriaid, productousuario, productofecreg, productofecultact, ptipobienid) VALUES(:productoid, :pcambsid, :productodsc, :pmodeloid, :pmarcaid, :pcategoriaid, :productousuario, :productofecreg, :productofecultact, :ptipobienid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00098)
             ,new CursorDef("T00099", "SAVEPOINT gxupdate;UPDATE public.producto SET pcambsid=:pcambsid, productodsc=:productodsc, pmodeloid=:pmodeloid, pmarcaid=:pmarcaid, pcategoriaid=:pcategoriaid, productousuario=:productousuario, productofecreg=:productofecreg, productofecultact=:productofecultact, ptipobienid=:ptipobienid ;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00099)
             ,new CursorDef("T000910", "SAVEPOINT gxupdate;DELETE FROM public.producto ;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000910)
             ,new CursorDef("T000911", "SELECT productoid FROM public.producto ORDER BY productoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,100,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
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
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
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
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
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
                   stmt.SetParameter(8, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[18]);
                }
                return;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
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
                   stmt.SetParameter(7, (DateTime)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[17]);
                }
                return;
       }
    }

 }

}
