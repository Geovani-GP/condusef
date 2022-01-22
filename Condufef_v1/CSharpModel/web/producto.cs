/*
               File: producto
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 12/30/2021 22:8:53.13
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A15modelosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A15modelosid) ;
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
            Form.Meta.addItem("description", "producto", 0) ;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MODELOSID"+"'), id:'"+"MODELOSID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRODUCTOCAMBSID"+"'), id:'"+"PRODUCTOCAMBSID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtmodelosid_Internalname, "modelosid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmodelosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15modelosid), 9, 0, ",", "")), ((edtmodelosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A15modelosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodelosid_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodelosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_15_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_15_Link, "", "", context.GetTheme( ), imgprompt_15_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtproductocambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproductocambsid_Internalname, A16productocambsid, StringUtil.RTrim( context.localUtil.Format( A16productocambsid, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductocambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductocambsid_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtmodeloid_Internalname, "modeloid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmodeloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A88modeloid), 18, 0, ",", "")), ((edtmodeloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A88modeloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A88modeloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmodeloid_Jsonclick, 0, "Attribute", "", "", "", 1, edtmodeloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtmarcaid_Internalname, "marcaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtmarcaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A89marcaid), 18, 0, ",", "")), ((edtmarcaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A89marcaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A89marcaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtmarcaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtmarcaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_label_element( context, edtcategoriaid_Internalname, "categoriaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcategoriaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A90categoriaid), 18, 0, ",", "")), ((edtcategoriaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A90categoriaid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A90categoriaid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcategoriaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtcategoriaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_single_line_edit( context, edtproductofecreg_Internalname, context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A92productofecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductofecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
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
            GxWebStd.gx_single_line_edit( context, edtproductofecultact_Internalname, context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A93productofecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproductofecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtproductofecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_producto.htm");
            GxWebStd.gx_bitmap( context, edtproductofecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtproductofecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_producto.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_producto.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
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
               A16productocambsid = cgiGet( edtproductocambsid_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
               A87productodsc = cgiGet( edtproductodsc_Internalname);
               n87productodsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
               n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtmodeloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtmodeloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MODELOID");
                  AnyError = 1;
                  GX_FocusControl = edtmodeloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A88modeloid = 0;
                  n88modeloid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A88modeloid), 18, 0)));
               }
               else
               {
                  A88modeloid = (long)(context.localUtil.CToN( cgiGet( edtmodeloid_Internalname), ",", "."));
                  n88modeloid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A88modeloid), 18, 0)));
               }
               n88modeloid = ((0==A88modeloid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtmarcaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtmarcaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MARCAID");
                  AnyError = 1;
                  GX_FocusControl = edtmarcaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A89marcaid = 0;
                  n89marcaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A89marcaid), 18, 0)));
               }
               else
               {
                  A89marcaid = (long)(context.localUtil.CToN( cgiGet( edtmarcaid_Internalname), ",", "."));
                  n89marcaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A89marcaid), 18, 0)));
               }
               n89marcaid = ((0==A89marcaid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtcategoriaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcategoriaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CATEGORIAID");
                  AnyError = 1;
                  GX_FocusControl = edtcategoriaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A90categoriaid = 0;
                  n90categoriaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A90categoriaid), 18, 0)));
               }
               else
               {
                  A90categoriaid = (long)(context.localUtil.CToN( cgiGet( edtcategoriaid_Internalname), ",", "."));
                  n90categoriaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A90categoriaid), 18, 0)));
               }
               n90categoriaid = ((0==A90categoriaid) ? true : false);
               A91productousuario = cgiGet( edtproductousuario_Internalname);
               n91productousuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
               n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtproductofecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"productofecreg"}), 1, "PRODUCTOFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtproductofecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A92productofecreg = (DateTime)(DateTime.MinValue);
                  n92productofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A92productofecreg = context.localUtil.CToT( cgiGet( edtproductofecreg_Internalname));
                  n92productofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtproductofecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"productofecultact"}), 1, "PRODUCTOFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtproductofecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A93productofecultact = (DateTime)(DateTime.MinValue);
                  n93productofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A93productofecultact = context.localUtil.CToT( cgiGet( edtproductofecultact_Internalname));
                  n93productofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
               /* Read saved values. */
               Z15modelosid = (int)(context.localUtil.CToN( cgiGet( "Z15modelosid"), ",", "."));
               Z16productocambsid = cgiGet( "Z16productocambsid");
               Z87productodsc = cgiGet( "Z87productodsc");
               n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
               Z88modeloid = (long)(context.localUtil.CToN( cgiGet( "Z88modeloid"), ",", "."));
               n88modeloid = ((0==A88modeloid) ? true : false);
               Z89marcaid = (long)(context.localUtil.CToN( cgiGet( "Z89marcaid"), ",", "."));
               n89marcaid = ((0==A89marcaid) ? true : false);
               Z90categoriaid = (long)(context.localUtil.CToN( cgiGet( "Z90categoriaid"), ",", "."));
               n90categoriaid = ((0==A90categoriaid) ? true : false);
               Z91productousuario = cgiGet( "Z91productousuario");
               n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
               Z92productofecreg = context.localUtil.CToT( cgiGet( "Z92productofecreg"), 0);
               n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
               Z93productofecultact = context.localUtil.CToT( cgiGet( "Z93productofecultact"), 0);
               n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
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
                  A16productocambsid = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
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
               InitAll099( ) ;
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
         DisableAttributes099( ) ;
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

      protected void ResetCaption090( )
      {
      }

      protected void ZM099( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z87productodsc = T00093_A87productodsc[0];
               Z88modeloid = T00093_A88modeloid[0];
               Z89marcaid = T00093_A89marcaid[0];
               Z90categoriaid = T00093_A90categoriaid[0];
               Z91productousuario = T00093_A91productousuario[0];
               Z92productofecreg = T00093_A92productofecreg[0];
               Z93productofecultact = T00093_A93productofecultact[0];
            }
            else
            {
               Z87productodsc = A87productodsc;
               Z88modeloid = A88modeloid;
               Z89marcaid = A89marcaid;
               Z90categoriaid = A90categoriaid;
               Z91productousuario = A91productousuario;
               Z92productofecreg = A92productofecreg;
               Z93productofecultact = A93productofecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z16productocambsid = A16productocambsid;
            Z87productodsc = A87productodsc;
            Z88modeloid = A88modeloid;
            Z89marcaid = A89marcaid;
            Z90categoriaid = A90categoriaid;
            Z91productousuario = A91productousuario;
            Z92productofecreg = A92productofecreg;
            Z93productofecultact = A93productofecultact;
            Z15modelosid = A15modelosid;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_15_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MODELOSID"+"'), id:'"+"MODELOSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
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

      protected void Load099( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound9 = 1;
            A87productodsc = T00095_A87productodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
            n87productodsc = T00095_n87productodsc[0];
            A88modeloid = T00095_A88modeloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A88modeloid), 18, 0)));
            n88modeloid = T00095_n88modeloid[0];
            A89marcaid = T00095_A89marcaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A89marcaid), 18, 0)));
            n89marcaid = T00095_n89marcaid[0];
            A90categoriaid = T00095_A90categoriaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A90categoriaid), 18, 0)));
            n90categoriaid = T00095_n90categoriaid[0];
            A91productousuario = T00095_A91productousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
            n91productousuario = T00095_n91productousuario[0];
            A92productofecreg = T00095_A92productofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
            n92productofecreg = T00095_n92productofecreg[0];
            A93productofecultact = T00095_A93productofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
            n93productofecultact = T00095_n93productofecultact[0];
            ZM099( -3) ;
         }
         pr_default.close(3);
         OnLoadActions099( ) ;
      }

      protected void OnLoadActions099( )
      {
      }

      protected void CheckExtendedTable099( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'modelos'.", "ForeignKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"modelosid"}), 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A92productofecreg) || ( A92productofecreg >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo productofecreg fuera de rango", "OutOfRange", 1, "PRODUCTOFECREG");
            AnyError = 1;
            GX_FocusControl = edtproductofecreg_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A93productofecultact) || ( A93productofecultact >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo productofecultact fuera de rango", "OutOfRange", 1, "PRODUCTOFECULTACT");
            AnyError = 1;
            GX_FocusControl = edtproductofecultact_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors099( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( int A15modelosid )
      {
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'modelos'.", "ForeignKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void GetKey099( )
      {
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM099( 3) ;
            RcdFound9 = 1;
            A16productocambsid = T00093_A16productocambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
            A87productodsc = T00093_A87productodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
            n87productodsc = T00093_n87productodsc[0];
            A88modeloid = T00093_A88modeloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A88modeloid), 18, 0)));
            n88modeloid = T00093_n88modeloid[0];
            A89marcaid = T00093_A89marcaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A89marcaid), 18, 0)));
            n89marcaid = T00093_n89marcaid[0];
            A90categoriaid = T00093_A90categoriaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A90categoriaid), 18, 0)));
            n90categoriaid = T00093_n90categoriaid[0];
            A91productousuario = T00093_A91productousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
            n91productousuario = T00093_n91productousuario[0];
            A92productofecreg = T00093_A92productofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
            n92productofecreg = T00093_n92productofecreg[0];
            A93productofecultact = T00093_A93productofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
            n93productofecultact = T00093_n93productofecultact[0];
            A15modelosid = T00093_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            Z15modelosid = A15modelosid;
            Z16productocambsid = A16productocambsid;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load099( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey099( ) ;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey099( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey099( ) ;
         if ( RcdFound9 == 0 )
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
         RcdFound9 = 0;
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00099_A15modelosid[0] < A15modelosid ) || ( T00099_A15modelosid[0] == A15modelosid ) && ( StringUtil.StrCmp(T00099_A16productocambsid[0], A16productocambsid) < 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00099_A15modelosid[0] > A15modelosid ) || ( T00099_A15modelosid[0] == A15modelosid ) && ( StringUtil.StrCmp(T00099_A16productocambsid[0], A16productocambsid) > 0 ) ) )
            {
               A15modelosid = T00099_A15modelosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               A16productocambsid = T00099_A16productocambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
               RcdFound9 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T000910 */
         pr_default.execute(8, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000910_A15modelosid[0] > A15modelosid ) || ( T000910_A15modelosid[0] == A15modelosid ) && ( StringUtil.StrCmp(T000910_A16productocambsid[0], A16productocambsid) > 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000910_A15modelosid[0] < A15modelosid ) || ( T000910_A15modelosid[0] == A15modelosid ) && ( StringUtil.StrCmp(T000910_A16productocambsid[0], A16productocambsid) < 0 ) ) )
            {
               A15modelosid = T000910_A15modelosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
               A16productocambsid = T000910_A16productocambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
               RcdFound9 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey099( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert099( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( ( A15modelosid != Z15modelosid ) || ( StringUtil.StrCmp(A16productocambsid, Z16productocambsid) != 0 ) )
               {
                  A15modelosid = Z15modelosid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
                  A16productocambsid = Z16productocambsid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
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
                  Update099( ) ;
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A15modelosid != Z15modelosid ) || ( StringUtil.StrCmp(A16productocambsid, Z16productocambsid) != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtmodelosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert099( ) ;
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
                     Insert099( ) ;
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
         if ( ( A15modelosid != Z15modelosid ) || ( StringUtil.StrCmp(A16productocambsid, Z16productocambsid) != 0 ) )
         {
            A15modelosid = Z15modelosid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            A16productocambsid = Z16productocambsid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtproductodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart099( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproductodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd099( ) ;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproductodsc_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproductodsc_Internalname;
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
         ScanStart099( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound9 != 0 )
            {
               ScanNext099( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtproductodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd099( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A15modelosid, A16productocambsid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"producto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z87productodsc, T00092_A87productodsc[0]) != 0 ) || ( Z88modeloid != T00092_A88modeloid[0] ) || ( Z89marcaid != T00092_A89marcaid[0] ) || ( Z90categoriaid != T00092_A90categoriaid[0] ) || ( StringUtil.StrCmp(Z91productousuario, T00092_A91productousuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z92productofecreg != T00092_A92productofecreg[0] ) || ( Z93productofecultact != T00092_A93productofecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z87productodsc, T00092_A87productodsc[0]) != 0 )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"productodsc");
                  GXUtil.WriteLogRaw("Old: ",Z87productodsc);
                  GXUtil.WriteLogRaw("Current: ",T00092_A87productodsc[0]);
               }
               if ( Z88modeloid != T00092_A88modeloid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"modeloid");
                  GXUtil.WriteLogRaw("Old: ",Z88modeloid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A88modeloid[0]);
               }
               if ( Z89marcaid != T00092_A89marcaid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"marcaid");
                  GXUtil.WriteLogRaw("Old: ",Z89marcaid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A89marcaid[0]);
               }
               if ( Z90categoriaid != T00092_A90categoriaid[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"categoriaid");
                  GXUtil.WriteLogRaw("Old: ",Z90categoriaid);
                  GXUtil.WriteLogRaw("Current: ",T00092_A90categoriaid[0]);
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
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"producto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM099( 0) ;
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000911 */
                     pr_default.execute(9, new Object[] {A16productocambsid, n87productodsc, A87productodsc, n88modeloid, A88modeloid, n89marcaid, A89marcaid, n90categoriaid, A90categoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, A15modelosid});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("producto") ;
                     if ( (pr_default.getStatus(9) == 1) )
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
               Load099( ) ;
            }
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void Update099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000912 */
                     pr_default.execute(10, new Object[] {n87productodsc, A87productodsc, n88modeloid, A88modeloid, n89marcaid, A89marcaid, n90categoriaid, A90categoriaid, n91productousuario, A91productousuario, n92productofecreg, A92productofecreg, n93productofecultact, A93productofecultact, A15modelosid, A16productocambsid});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("producto") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"producto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate099( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption090( ) ;
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
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void DeferredUpdate099( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls099( ) ;
            AfterConfirm099( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete099( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000913 */
                  pr_default.execute(11, new Object[] {A15modelosid, A16productocambsid});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("producto") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound9 == 0 )
                        {
                           InitAll099( ) ;
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
                        ResetCaption090( ) ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel099( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls099( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete099( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
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
            pr_default.close(1);
            context.RollbackDataStores( "producto");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart099( )
      {
         /* Using cursor T000914 */
         pr_default.execute(12);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound9 = 1;
            A15modelosid = T000914_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            A16productocambsid = T000914_A16productocambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext099( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound9 = 1;
            A15modelosid = T000914_A15modelosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
            A16productocambsid = T000914_A16productocambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
         }
      }

      protected void ScanEnd099( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm099( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert099( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate099( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete099( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete099( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate099( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes099( )
      {
         edtmodelosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodelosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodelosid_Enabled), 5, 0)));
         edtproductocambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductocambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductocambsid_Enabled), 5, 0)));
         edtproductodsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductodsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductodsc_Enabled), 5, 0)));
         edtmodeloid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmodeloid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmodeloid_Enabled), 5, 0)));
         edtmarcaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtmarcaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtmarcaid_Enabled), 5, 0)));
         edtcategoriaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategoriaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategoriaid_Enabled), 5, 0)));
         edtproductousuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductousuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductousuario_Enabled), 5, 0)));
         edtproductofecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductofecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductofecreg_Enabled), 5, 0)));
         edtproductofecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproductofecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproductofecultact_Enabled), 5, 0)));
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
         context.AddJavascriptSource("gxcfg.js", "?20211230228545");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("producto.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z16productocambsid", Z16productocambsid);
         GxWebStd.gx_hidden_field( context, "Z87productodsc", Z87productodsc);
         GxWebStd.gx_hidden_field( context, "Z88modeloid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z88modeloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z89marcaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z89marcaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z90categoriaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z90categoriaid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z91productousuario", Z91productousuario);
         GxWebStd.gx_hidden_field( context, "Z92productofecreg", context.localUtil.TToC( Z92productofecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z93productofecultact", context.localUtil.TToC( Z93productofecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("producto.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "producto" ;
      }

      public override String GetPgmdesc( )
      {
         return "producto" ;
      }

      protected void InitializeNonKey099( )
      {
         A87productodsc = "";
         n87productodsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87productodsc", A87productodsc);
         n87productodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A87productodsc)) ? true : false);
         A88modeloid = 0;
         n88modeloid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A88modeloid), 18, 0)));
         n88modeloid = ((0==A88modeloid) ? true : false);
         A89marcaid = 0;
         n89marcaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A89marcaid), 18, 0)));
         n89marcaid = ((0==A89marcaid) ? true : false);
         A90categoriaid = 0;
         n90categoriaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A90categoriaid), 18, 0)));
         n90categoriaid = ((0==A90categoriaid) ? true : false);
         A91productousuario = "";
         n91productousuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91productousuario", A91productousuario);
         n91productousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A91productousuario)) ? true : false);
         A92productofecreg = (DateTime)(DateTime.MinValue);
         n92productofecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92productofecreg", context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
         n92productofecreg = ((DateTime.MinValue==A92productofecreg) ? true : false);
         A93productofecultact = (DateTime)(DateTime.MinValue);
         n93productofecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93productofecultact", context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
         n93productofecultact = ((DateTime.MinValue==A93productofecultact) ? true : false);
         Z87productodsc = "";
         Z88modeloid = 0;
         Z89marcaid = 0;
         Z90categoriaid = 0;
         Z91productousuario = "";
         Z92productofecreg = (DateTime)(DateTime.MinValue);
         Z93productofecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll099( )
      {
         A15modelosid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A15modelosid), 9, 0)));
         A16productocambsid = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16productocambsid", A16productocambsid);
         InitializeNonKey099( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2284430");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202112302285412");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("producto.js", "?202112302285412");
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
         edtproductocambsid_Internalname = "PRODUCTOCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproductodsc_Internalname = "PRODUCTODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmodeloid_Internalname = "MODELOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtmarcaid_Internalname = "MARCAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtcategoriaid_Internalname = "CATEGORIAID";
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
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTablemain_Internalname = "TABLEMAIN";
         div_Internalname = "";
         Form.Internalname = "FORM";
         imgprompt_15_Internalname = "PROMPT_15";
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
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtproductofecultact_Jsonclick = "";
         edtproductofecultact_Enabled = 1;
         edtproductofecreg_Jsonclick = "";
         edtproductofecreg_Enabled = 1;
         edtproductousuario_Jsonclick = "";
         edtproductousuario_Enabled = 1;
         edtcategoriaid_Jsonclick = "";
         edtcategoriaid_Enabled = 1;
         edtmarcaid_Jsonclick = "";
         edtmarcaid_Enabled = 1;
         edtmodeloid_Jsonclick = "";
         edtmodeloid_Enabled = 1;
         edtproductodsc_Jsonclick = "";
         edtproductodsc_Enabled = 1;
         edtproductocambsid_Jsonclick = "";
         edtproductocambsid_Enabled = 1;
         imgprompt_15_Visible = 1;
         imgprompt_15_Link = "";
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
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'modelos'.", "ForeignKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(13);
         GX_FocusControl = edtproductodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Modelosid( int GX_Parm1 )
      {
         A15modelosid = GX_Parm1;
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {A15modelosid});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'modelos'.", "ForeignKeyNotFound", 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Productocambsid( int GX_Parm1 ,
                                         String GX_Parm2 ,
                                         String GX_Parm3 ,
                                         long GX_Parm4 ,
                                         long GX_Parm5 ,
                                         long GX_Parm6 ,
                                         String GX_Parm7 ,
                                         DateTime GX_Parm8 ,
                                         DateTime GX_Parm9 )
      {
         A15modelosid = GX_Parm1;
         A16productocambsid = GX_Parm2;
         A87productodsc = GX_Parm3;
         n87productodsc = false;
         A88modeloid = GX_Parm4;
         n88modeloid = false;
         A89marcaid = GX_Parm5;
         n89marcaid = false;
         A90categoriaid = GX_Parm6;
         n90categoriaid = false;
         A91productousuario = GX_Parm7;
         n91productousuario = false;
         A92productofecreg = GX_Parm8;
         n92productofecreg = false;
         A93productofecultact = GX_Parm9;
         n93productofecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         /* Using cursor T000916 */
         pr_default.execute(14, new Object[] {A15modelosid, A16productocambsid});
         if ( (pr_default.getStatus(14) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"modelosid"}), 1, "MODELOSID");
            AnyError = 1;
            GX_FocusControl = edtmodelosid_Internalname;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A87productodsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A88modeloid), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A89marcaid), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A90categoriaid), 18, 0, ".", "")));
         isValidOutput.Add(A91productousuario);
         isValidOutput.Add(context.localUtil.TToC( A92productofecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A93productofecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15modelosid), 9, 0, ",", "")));
         isValidOutput.Add(Z16productocambsid);
         isValidOutput.Add(Z87productodsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z88modeloid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z89marcaid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z90categoriaid), 18, 0, ",", "")));
         isValidOutput.Add(Z91productousuario);
         isValidOutput.Add(context.localUtil.TToC( Z92productofecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z93productofecultact, 10, 8, 0, 0, "/", ":", " "));
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
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z16productocambsid = "";
         Z87productodsc = "";
         Z91productousuario = "";
         Z92productofecreg = (DateTime)(DateTime.MinValue);
         Z93productofecultact = (DateTime)(DateTime.MinValue);
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
         A16productocambsid = "";
         A87productodsc = "";
         A91productousuario = "";
         A92productofecreg = (DateTime)(DateTime.MinValue);
         A93productofecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00095_A16productocambsid = new String[] {""} ;
         T00095_A87productodsc = new String[] {""} ;
         T00095_n87productodsc = new bool[] {false} ;
         T00095_A88modeloid = new long[1] ;
         T00095_n88modeloid = new bool[] {false} ;
         T00095_A89marcaid = new long[1] ;
         T00095_n89marcaid = new bool[] {false} ;
         T00095_A90categoriaid = new long[1] ;
         T00095_n90categoriaid = new bool[] {false} ;
         T00095_A91productousuario = new String[] {""} ;
         T00095_n91productousuario = new bool[] {false} ;
         T00095_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00095_n92productofecreg = new bool[] {false} ;
         T00095_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00095_n93productofecultact = new bool[] {false} ;
         T00095_A15modelosid = new int[1] ;
         T00094_A15modelosid = new int[1] ;
         T00096_A15modelosid = new int[1] ;
         T00097_A15modelosid = new int[1] ;
         T00098_A15modelosid = new int[1] ;
         T00098_A16productocambsid = new String[] {""} ;
         T00093_A16productocambsid = new String[] {""} ;
         T00093_A87productodsc = new String[] {""} ;
         T00093_n87productodsc = new bool[] {false} ;
         T00093_A88modeloid = new long[1] ;
         T00093_n88modeloid = new bool[] {false} ;
         T00093_A89marcaid = new long[1] ;
         T00093_n89marcaid = new bool[] {false} ;
         T00093_A90categoriaid = new long[1] ;
         T00093_n90categoriaid = new bool[] {false} ;
         T00093_A91productousuario = new String[] {""} ;
         T00093_n91productousuario = new bool[] {false} ;
         T00093_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00093_n92productofecreg = new bool[] {false} ;
         T00093_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00093_n93productofecultact = new bool[] {false} ;
         T00093_A15modelosid = new int[1] ;
         sMode9 = "";
         T00099_A15modelosid = new int[1] ;
         T00099_A16productocambsid = new String[] {""} ;
         T000910_A15modelosid = new int[1] ;
         T000910_A16productocambsid = new String[] {""} ;
         T00092_A16productocambsid = new String[] {""} ;
         T00092_A87productodsc = new String[] {""} ;
         T00092_n87productodsc = new bool[] {false} ;
         T00092_A88modeloid = new long[1] ;
         T00092_n88modeloid = new bool[] {false} ;
         T00092_A89marcaid = new long[1] ;
         T00092_n89marcaid = new bool[] {false} ;
         T00092_A90categoriaid = new long[1] ;
         T00092_n90categoriaid = new bool[] {false} ;
         T00092_A91productousuario = new String[] {""} ;
         T00092_n91productousuario = new bool[] {false} ;
         T00092_A92productofecreg = new DateTime[] {DateTime.MinValue} ;
         T00092_n92productofecreg = new bool[] {false} ;
         T00092_A93productofecultact = new DateTime[] {DateTime.MinValue} ;
         T00092_n93productofecultact = new bool[] {false} ;
         T00092_A15modelosid = new int[1] ;
         T000914_A15modelosid = new int[1] ;
         T000914_A16productocambsid = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000915_A15modelosid = new int[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000916_A15modelosid = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producto__default(),
            new Object[][] {
                new Object[] {
               T00092_A16productocambsid, T00092_A87productodsc, T00092_n87productodsc, T00092_A88modeloid, T00092_n88modeloid, T00092_A89marcaid, T00092_n89marcaid, T00092_A90categoriaid, T00092_n90categoriaid, T00092_A91productousuario,
               T00092_n91productousuario, T00092_A92productofecreg, T00092_n92productofecreg, T00092_A93productofecultact, T00092_n93productofecultact, T00092_A15modelosid
               }
               , new Object[] {
               T00093_A16productocambsid, T00093_A87productodsc, T00093_n87productodsc, T00093_A88modeloid, T00093_n88modeloid, T00093_A89marcaid, T00093_n89marcaid, T00093_A90categoriaid, T00093_n90categoriaid, T00093_A91productousuario,
               T00093_n91productousuario, T00093_A92productofecreg, T00093_n92productofecreg, T00093_A93productofecultact, T00093_n93productofecultact, T00093_A15modelosid
               }
               , new Object[] {
               T00094_A15modelosid
               }
               , new Object[] {
               T00095_A16productocambsid, T00095_A87productodsc, T00095_n87productodsc, T00095_A88modeloid, T00095_n88modeloid, T00095_A89marcaid, T00095_n89marcaid, T00095_A90categoriaid, T00095_n90categoriaid, T00095_A91productousuario,
               T00095_n91productousuario, T00095_A92productofecreg, T00095_n92productofecreg, T00095_A93productofecultact, T00095_n93productofecultact, T00095_A15modelosid
               }
               , new Object[] {
               T00096_A15modelosid
               }
               , new Object[] {
               T00097_A15modelosid
               }
               , new Object[] {
               T00098_A15modelosid, T00098_A16productocambsid
               }
               , new Object[] {
               T00099_A15modelosid, T00099_A16productocambsid
               }
               , new Object[] {
               T000910_A15modelosid, T000910_A16productocambsid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000914_A15modelosid, T000914_A16productocambsid
               }
               , new Object[] {
               T000915_A15modelosid
               }
               , new Object[] {
               T000916_A15modelosid
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
      private short RcdFound9 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z15modelosid ;
      private int A15modelosid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtmodelosid_Enabled ;
      private int imgprompt_15_Visible ;
      private int edtproductocambsid_Enabled ;
      private int edtproductodsc_Enabled ;
      private int edtmodeloid_Enabled ;
      private int edtmarcaid_Enabled ;
      private int edtcategoriaid_Enabled ;
      private int edtproductousuario_Enabled ;
      private int edtproductofecreg_Enabled ;
      private int edtproductofecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z88modeloid ;
      private long Z89marcaid ;
      private long Z90categoriaid ;
      private long A88modeloid ;
      private long A89marcaid ;
      private long A90categoriaid ;
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
      private String imgprompt_15_Internalname ;
      private String imgprompt_15_Link ;
      private String edtproductocambsid_Internalname ;
      private String edtproductocambsid_Jsonclick ;
      private String edtproductodsc_Internalname ;
      private String edtproductodsc_Jsonclick ;
      private String edtmodeloid_Internalname ;
      private String edtmodeloid_Jsonclick ;
      private String edtmarcaid_Internalname ;
      private String edtmarcaid_Jsonclick ;
      private String edtcategoriaid_Internalname ;
      private String edtcategoriaid_Jsonclick ;
      private String edtproductousuario_Internalname ;
      private String edtproductousuario_Jsonclick ;
      private String edtproductofecreg_Internalname ;
      private String edtproductofecreg_Jsonclick ;
      private String edtproductofecultact_Internalname ;
      private String edtproductofecultact_Jsonclick ;
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
      private String sMode9 ;
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
      private bool n87productodsc ;
      private bool n88modeloid ;
      private bool n89marcaid ;
      private bool n90categoriaid ;
      private bool n91productousuario ;
      private bool n92productofecreg ;
      private bool n93productofecultact ;
      private bool Gx_longc ;
      private String Z16productocambsid ;
      private String Z87productodsc ;
      private String Z91productousuario ;
      private String A16productocambsid ;
      private String A87productodsc ;
      private String A91productousuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00095_A16productocambsid ;
      private String[] T00095_A87productodsc ;
      private bool[] T00095_n87productodsc ;
      private long[] T00095_A88modeloid ;
      private bool[] T00095_n88modeloid ;
      private long[] T00095_A89marcaid ;
      private bool[] T00095_n89marcaid ;
      private long[] T00095_A90categoriaid ;
      private bool[] T00095_n90categoriaid ;
      private String[] T00095_A91productousuario ;
      private bool[] T00095_n91productousuario ;
      private DateTime[] T00095_A92productofecreg ;
      private bool[] T00095_n92productofecreg ;
      private DateTime[] T00095_A93productofecultact ;
      private bool[] T00095_n93productofecultact ;
      private int[] T00095_A15modelosid ;
      private int[] T00094_A15modelosid ;
      private int[] T00096_A15modelosid ;
      private int[] T00097_A15modelosid ;
      private int[] T00098_A15modelosid ;
      private String[] T00098_A16productocambsid ;
      private String[] T00093_A16productocambsid ;
      private String[] T00093_A87productodsc ;
      private bool[] T00093_n87productodsc ;
      private long[] T00093_A88modeloid ;
      private bool[] T00093_n88modeloid ;
      private long[] T00093_A89marcaid ;
      private bool[] T00093_n89marcaid ;
      private long[] T00093_A90categoriaid ;
      private bool[] T00093_n90categoriaid ;
      private String[] T00093_A91productousuario ;
      private bool[] T00093_n91productousuario ;
      private DateTime[] T00093_A92productofecreg ;
      private bool[] T00093_n92productofecreg ;
      private DateTime[] T00093_A93productofecultact ;
      private bool[] T00093_n93productofecultact ;
      private int[] T00093_A15modelosid ;
      private int[] T00099_A15modelosid ;
      private String[] T00099_A16productocambsid ;
      private int[] T000910_A15modelosid ;
      private String[] T000910_A16productocambsid ;
      private String[] T00092_A16productocambsid ;
      private String[] T00092_A87productodsc ;
      private bool[] T00092_n87productodsc ;
      private long[] T00092_A88modeloid ;
      private bool[] T00092_n88modeloid ;
      private long[] T00092_A89marcaid ;
      private bool[] T00092_n89marcaid ;
      private long[] T00092_A90categoriaid ;
      private bool[] T00092_n90categoriaid ;
      private String[] T00092_A91productousuario ;
      private bool[] T00092_n91productousuario ;
      private DateTime[] T00092_A92productofecreg ;
      private bool[] T00092_n92productofecreg ;
      private DateTime[] T00092_A93productofecultact ;
      private bool[] T00092_n93productofecultact ;
      private int[] T00092_A15modelosid ;
      private int[] T000914_A15modelosid ;
      private String[] T000914_A16productocambsid ;
      private int[] T000915_A15modelosid ;
      private int[] T000916_A15modelosid ;
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
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0} ,
          new Object[] {"@productodsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@modeloid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@marcaid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@categoriaid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@productousuario",SqlDbType.VarChar,15,0} ,
          new Object[] {"@productofecreg",SqlDbType.DateTime,10,8} ,
          new Object[] {"@productofecultact",SqlDbType.DateTime,10,8} ,
          new Object[] {"@modelosid",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@productodsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@modeloid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@marcaid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@categoriaid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@productousuario",SqlDbType.VarChar,15,0} ,
          new Object[] {"@productofecreg",SqlDbType.DateTime,10,8} ,
          new Object[] {"@productofecultact",SqlDbType.DateTime,10,8} ,
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000914 ;
          prmT000914 = new Object[] {
          } ;
          Object[] prmT000915 ;
          prmT000915 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000916 ;
          prmT000916 = new Object[] {
          new Object[] {"@modelosid",SqlDbType.Int,9,0} ,
          new Object[] {"@productocambsid",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [productocambsid], [productodsc], [modeloid], [marcaid], [categoriaid], [productousuario], [productofecreg], [productofecultact], [modelosid] FROM [producto] WITH (UPDLOCK) WHERE [modelosid] = @modelosid AND [productocambsid] = @productocambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [productocambsid], [productodsc], [modeloid], [marcaid], [categoriaid], [productousuario], [productofecreg], [productofecultact], [modelosid] FROM [producto] WITH (NOLOCK) WHERE [modelosid] = @modelosid AND [productocambsid] = @productocambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT [modelosid] FROM [modelos] WITH (NOLOCK) WHERE [modelosid] = @modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
             ,new CursorDef("T00095", "SELECT TM1.[productocambsid], TM1.[productodsc], TM1.[modeloid], TM1.[marcaid], TM1.[categoriaid], TM1.[productousuario], TM1.[productofecreg], TM1.[productofecultact], TM1.[modelosid] FROM [producto] TM1 WITH (NOLOCK) WHERE TM1.[modelosid] = @modelosid and TM1.[productocambsid] = @productocambsid ORDER BY TM1.[modelosid], TM1.[productocambsid]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,100,0,true,false )
             ,new CursorDef("T00096", "SELECT [modelosid] FROM [producto] WITH (NOLOCK) WHERE ([modelosid] = @modelosid) AND (Not ( [modelosid] = @modelosid and [productocambsid] = @productocambsid)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,false )
             ,new CursorDef("T00097", "SELECT [modelosid] FROM [modelos] WITH (NOLOCK) WHERE [modelosid] = @modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,false )
             ,new CursorDef("T00098", "SELECT [modelosid], [productocambsid] FROM [producto] WITH (NOLOCK) WHERE [modelosid] = @modelosid AND [productocambsid] = @productocambsid  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
             ,new CursorDef("T00099", "SELECT TOP 1 [modelosid], [productocambsid] FROM [producto] WITH (NOLOCK) WHERE ( [modelosid] > @modelosid or [modelosid] = @modelosid and [productocambsid] > @productocambsid) ORDER BY [modelosid], [productocambsid]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,true )
             ,new CursorDef("T000910", "SELECT TOP 1 [modelosid], [productocambsid] FROM [producto] WITH (NOLOCK) WHERE ( [modelosid] < @modelosid or [modelosid] = @modelosid and [productocambsid] < @productocambsid) ORDER BY [modelosid] DESC, [productocambsid] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,true )
             ,new CursorDef("T000911", "INSERT INTO [producto]([productocambsid], [productodsc], [modeloid], [marcaid], [categoriaid], [productousuario], [productofecreg], [productofecultact], [modelosid]) VALUES(@productocambsid, @productodsc, @modeloid, @marcaid, @categoriaid, @productousuario, @productofecreg, @productofecultact, @modelosid)", GxErrorMask.GX_NOMASK,prmT000911)
             ,new CursorDef("T000912", "UPDATE [producto] SET [productodsc]=@productodsc, [modeloid]=@modeloid, [marcaid]=@marcaid, [categoriaid]=@categoriaid, [productousuario]=@productousuario, [productofecreg]=@productofecreg, [productofecultact]=@productofecultact  WHERE [modelosid] = @modelosid AND [productocambsid] = @productocambsid", GxErrorMask.GX_NOMASK,prmT000912)
             ,new CursorDef("T000913", "DELETE FROM [producto]  WHERE [modelosid] = @modelosid AND [productocambsid] = @productocambsid", GxErrorMask.GX_NOMASK,prmT000913)
             ,new CursorDef("T000914", "SELECT [modelosid], [productocambsid] FROM [producto] WITH (NOLOCK) ORDER BY [modelosid], [productocambsid]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000914,100,0,true,false )
             ,new CursorDef("T000915", "SELECT [modelosid] FROM [modelos] WITH (NOLOCK) WHERE [modelosid] = @modelosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000915,1,0,true,false )
             ,new CursorDef("T000916", "SELECT [modelosid] FROM [producto] WITH (NOLOCK) WHERE ([modelosid] = @modelosid) AND (Not ( [modelosid] = @modelosid and [productocambsid] = @productocambsid)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000916,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 14 :
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
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
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[6]);
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
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[14]);
                }
                stmt.SetParameter(9, (int)parms[15]);
                return;
             case 10 :
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
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (long)parms[5]);
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
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[13]);
                }
                stmt.SetParameter(8, (int)parms[14]);
                stmt.SetParameter(9, (String)parms[15]);
                return;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}