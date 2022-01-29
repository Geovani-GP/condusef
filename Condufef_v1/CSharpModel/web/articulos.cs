/*
               File: articulos
        Description: articulos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:56:23.92
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
   public class articulos : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A19almacenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A19almacenid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A20articulosproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A20articulosproductoid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A21articuloscambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_9( A21articuloscambsid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A23tipobienid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n23tipobienid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A23tipobienid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A7entidafederativaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n7entidafederativaid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A7entidafederativaid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A10origenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n10origenid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A10origenid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A2proveedoresid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n2proveedoresid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_7( A2proveedoresid) ;
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
            Form.Meta.addItem("description", "articulos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtalmacenid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public articulos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public articulos( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "articulos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_articulos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ALMACENID"+"'), id:'"+"ALMACENID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOSPRODUCTOID"+"'), id:'"+"ARTICULOSPRODUCTOID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOSCAMBSID"+"'), id:'"+"ARTICULOSCAMBSID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenid_Internalname, "almacenid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")), ((edtalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20articulosproductoid), 9, 0, ",", "")), ((edtarticulosproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20articulosproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A20articulosproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosproductoid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_20_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_20_Link, "", "", context.GetTheme( ), imgprompt_20_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticuloscambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticuloscambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A21articuloscambsid), 9, 0, ",", "")), ((edtarticuloscambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A21articuloscambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A21articuloscambsid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticuloscambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticuloscambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_21_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_21_Link, "", "", context.GetTheme( ), imgprompt_21_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtalamcenid_Internalname, "alamcenid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalamcenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A154alamcenid), 18, 0, ",", "")), ((edtalamcenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A154alamcenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A154alamcenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalamcenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtalamcenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosnoetiqueta_Internalname, "articulosnoetiqueta", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosnoetiqueta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A155articulosnoetiqueta), 18, 0, ",", "")), ((edtarticulosnoetiqueta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A155articulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A155articulosnoetiqueta), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosnoetiqueta_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosnoetiqueta_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edttipobienid_Internalname, "tipobienid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipobienid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ",", "")), ((edttipobienid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A23tipobienid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipobienid_Jsonclick, 0, "Attribute", "", "", "", 1, edttipobienid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_23_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_23_Link, "", "", context.GetTheme( ), imgprompt_23_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtentidafederativaid_Internalname, "entidafederativaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtentidafederativaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ",", "")), ((edtentidafederativaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7entidafederativaid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtentidafederativaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtentidafederativaid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_7_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_7_Link, "", "", context.GetTheme( ), imgprompt_7_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtorigenid_Internalname, "origenid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtorigenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ",", "")), ((edtorigenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_10_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_10_Link, "", "", context.GetTheme( ), imgprompt_10_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosdsc_Internalname, "articulosdsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosdsc_Internalname, A156articulosdsc, StringUtil.RTrim( context.localUtil.Format( A156articulosdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosdsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtproveedoresid_Internalname, "proveedoresid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtproveedoresid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")), ((edtproveedoresid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtproveedoresid_Jsonclick, 0, "Attribute", "", "", "", 1, edtproveedoresid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulospreciocompra_Internalname, "articulospreciocompra", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulospreciocompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A157articulospreciocompra, 17, 6, ",", "")), ((edtarticulospreciocompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A157articulospreciocompra, "ZZZZZZZZZ9.999999")) : context.localUtil.Format( A157articulospreciocompra, "ZZZZZZZZZ9.999999")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, '.',',','6');"+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulospreciocompra_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulospreciocompra_Enabled, 0, "text", "", 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulospreccomprareexp_Internalname, "articulospreccomprareexp", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulospreccomprareexp_Internalname, StringUtil.LTrim( StringUtil.NToC( A158articulospreccomprareexp, 17, 6, ",", "")), ((edtarticulospreccomprareexp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A158articulospreccomprareexp, "ZZZZZZZZZ9.999999")) : context.localUtil.Format( A158articulospreccomprareexp, "ZZZZZZZZZ9.999999")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, '.',',','6');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulospreccomprareexp_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulospreccomprareexp_Enabled, 0, "text", "", 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticuloscantdepreacum_Internalname, "articuloscantdepreacum", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticuloscantdepreacum_Internalname, StringUtil.LTrim( StringUtil.NToC( A159articuloscantdepreacum, 17, 6, ",", "")), ((edtarticuloscantdepreacum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A159articuloscantdepreacum, "ZZZZZZZZZ9.999999")) : context.localUtil.Format( A159articuloscantdepreacum, "ZZZZZZZZZ9.999999")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, '.',',','6');"+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticuloscantdepreacum_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticuloscantdepreacum_Enabled, 0, "text", "", 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosnumserie_Internalname, "articulosnumserie", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosnumserie_Internalname, A160articulosnumserie, StringUtil.RTrim( context.localUtil.Format( A160articulosnumserie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosnumserie_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosnumserie_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosrefdocumento_Internalname, "articulosrefdocumento", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosrefdocumento_Internalname, A161articulosrefdocumento, StringUtil.RTrim( context.localUtil.Format( A161articulosrefdocumento, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosrefdocumento_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosrefdocumento_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosfechacoteja_Internalname, "articulosfechacoteja", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosfechacoteja_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosfechacoteja_Internalname, context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A162articulosfechacoteja, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosfechacoteja_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosfechacoteja_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            GxWebStd.gx_bitmap( context, edtarticulosfechacoteja_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosfechacoteja_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosfechaentraalmacen_Internalname, "articulosfechaentraalmacen", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosfechaentraalmacen_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosfechaentraalmacen_Internalname, context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A163articulosfechaentraalmacen, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosfechaentraalmacen_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosfechaentraalmacen_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            GxWebStd.gx_bitmap( context, edtarticulosfechaentraalmacen_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosfechaentraalmacen_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosfechabajaalma_Internalname, "articulosfechabajaalma", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosfechabajaalma_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosfechabajaalma_Internalname, context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A164articulosfechabajaalma, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosfechabajaalma_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosfechabajaalma_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            GxWebStd.gx_bitmap( context, edtarticulosfechabajaalma_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosfechabajaalma_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosstatus_Internalname, "articulosstatus", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosstatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A165articulosstatus), 18, 0, ",", "")), ((edtarticulosstatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A165articulosstatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A165articulosstatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosstatus_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosstatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticuloscontejado_Internalname, "articuloscontejado", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticuloscontejado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A166articuloscontejado), 18, 0, ",", "")), ((edtarticuloscontejado_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A166articuloscontejado), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A166articuloscontejado), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticuloscontejado_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticuloscontejado_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosusuario_Internalname, "articulosusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosusuario_Internalname, A167articulosusuario, StringUtil.RTrim( context.localUtil.Format( A167articulosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosusuario_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosidtrasfer_Internalname, "articulosidtrasfer", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosidtrasfer_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A168articulosidtrasfer), 9, 0, ",", "")), ((edtarticulosidtrasfer_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A168articulosidtrasfer), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A168articulosidtrasfer), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosidtrasfer_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosidtrasfer_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosestatusariticulo_Internalname, "articulosestatusariticulo", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosestatusariticulo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A169articulosestatusariticulo), 18, 0, ",", "")), ((edtarticulosestatusariticulo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A169articulosestatusariticulo), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A169articulosestatusariticulo), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,110);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosestatusariticulo_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosestatusariticulo_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulostipobien_Internalname, "articulostipobien", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulostipobien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A170articulostipobien), 18, 0, ",", "")), ((edtarticulostipobien_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A170articulostipobien), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A170articulostipobien), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulostipobien_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulostipobien_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosfecreg_Internalname, "articulosfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosfecreg_Internalname, context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A171articulosfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            GxWebStd.gx_bitmap( context, edtarticulosfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosfecultact_Internalname, "articulosfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosfecultact_Internalname, context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A172articulosfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulos.htm");
            GxWebStd.gx_bitmap( context, edtarticulosfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulos.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulos.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ALMACENID");
                  AnyError = 1;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19almacenid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               }
               else
               {
                  A19almacenid = (long)(context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSPRODUCTOID");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A20articulosproductoid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
               }
               else
               {
                  A20articulosproductoid = (int)(context.localUtil.CToN( cgiGet( edtarticulosproductoid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticuloscambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticuloscambsid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSCAMBSID");
                  AnyError = 1;
                  GX_FocusControl = edtarticuloscambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A21articuloscambsid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
               }
               else
               {
                  A21articuloscambsid = (int)(context.localUtil.CToN( cgiGet( edtarticuloscambsid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtalamcenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtalamcenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ALAMCENID");
                  AnyError = 1;
                  GX_FocusControl = edtalamcenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A154alamcenid = 0;
                  n154alamcenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154alamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A154alamcenid), 18, 0)));
               }
               else
               {
                  A154alamcenid = (long)(context.localUtil.CToN( cgiGet( edtalamcenid_Internalname), ",", "."));
                  n154alamcenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154alamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A154alamcenid), 18, 0)));
               }
               n154alamcenid = ((0==A154alamcenid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosnoetiqueta_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosnoetiqueta_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSNOETIQUETA");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosnoetiqueta_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A155articulosnoetiqueta = 0;
                  n155articulosnoetiqueta = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155articulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(A155articulosnoetiqueta), 18, 0)));
               }
               else
               {
                  A155articulosnoetiqueta = (long)(context.localUtil.CToN( cgiGet( edtarticulosnoetiqueta_Internalname), ",", "."));
                  n155articulosnoetiqueta = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155articulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(A155articulosnoetiqueta), 18, 0)));
               }
               n155articulosnoetiqueta = ((0==A155articulosnoetiqueta) ? true : false);
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
               n23tipobienid = ((0==A23tipobienid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ENTIDAFEDERATIVAID");
                  AnyError = 1;
                  GX_FocusControl = edtentidafederativaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A7entidafederativaid = 0;
                  n7entidafederativaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               }
               else
               {
                  A7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( edtentidafederativaid_Internalname), ",", "."));
                  n7entidafederativaid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
               }
               n7entidafederativaid = ((0==A7entidafederativaid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORIGENID");
                  AnyError = 1;
                  GX_FocusControl = edtorigenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A10origenid = 0;
                  n10origenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               }
               else
               {
                  A10origenid = (long)(context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", "."));
                  n10origenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               }
               n10origenid = ((0==A10origenid) ? true : false);
               A156articulosdsc = cgiGet( edtarticulosdsc_Internalname);
               n156articulosdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156articulosdsc", A156articulosdsc);
               n156articulosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A156articulosdsc)) ? true : false);
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
               n2proveedoresid = ((0==A2proveedoresid) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulospreciocompra_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulospreciocompra_Internalname), ",", ".") > 9999999999.999999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSPRECIOCOMPRA");
                  AnyError = 1;
                  GX_FocusControl = edtarticulospreciocompra_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A157articulospreciocompra = 0;
                  n157articulospreciocompra = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157articulospreciocompra", StringUtil.LTrim( StringUtil.Str( A157articulospreciocompra, 17, 6)));
               }
               else
               {
                  A157articulospreciocompra = context.localUtil.CToN( cgiGet( edtarticulospreciocompra_Internalname), ",", ".");
                  n157articulospreciocompra = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157articulospreciocompra", StringUtil.LTrim( StringUtil.Str( A157articulospreciocompra, 17, 6)));
               }
               n157articulospreciocompra = ((Convert.ToDecimal(0)==A157articulospreciocompra) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulospreccomprareexp_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulospreccomprareexp_Internalname), ",", ".") > 9999999999.999999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSPRECCOMPRAREEXP");
                  AnyError = 1;
                  GX_FocusControl = edtarticulospreccomprareexp_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A158articulospreccomprareexp = 0;
                  n158articulospreccomprareexp = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158articulospreccomprareexp", StringUtil.LTrim( StringUtil.Str( A158articulospreccomprareexp, 17, 6)));
               }
               else
               {
                  A158articulospreccomprareexp = context.localUtil.CToN( cgiGet( edtarticulospreccomprareexp_Internalname), ",", ".");
                  n158articulospreccomprareexp = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158articulospreccomprareexp", StringUtil.LTrim( StringUtil.Str( A158articulospreccomprareexp, 17, 6)));
               }
               n158articulospreccomprareexp = ((Convert.ToDecimal(0)==A158articulospreccomprareexp) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticuloscantdepreacum_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticuloscantdepreacum_Internalname), ",", ".") > 9999999999.999999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSCANTDEPREACUM");
                  AnyError = 1;
                  GX_FocusControl = edtarticuloscantdepreacum_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A159articuloscantdepreacum = 0;
                  n159articuloscantdepreacum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159articuloscantdepreacum", StringUtil.LTrim( StringUtil.Str( A159articuloscantdepreacum, 17, 6)));
               }
               else
               {
                  A159articuloscantdepreacum = context.localUtil.CToN( cgiGet( edtarticuloscantdepreacum_Internalname), ",", ".");
                  n159articuloscantdepreacum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159articuloscantdepreacum", StringUtil.LTrim( StringUtil.Str( A159articuloscantdepreacum, 17, 6)));
               }
               n159articuloscantdepreacum = ((Convert.ToDecimal(0)==A159articuloscantdepreacum) ? true : false);
               A160articulosnumserie = cgiGet( edtarticulosnumserie_Internalname);
               n160articulosnumserie = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160articulosnumserie", A160articulosnumserie);
               n160articulosnumserie = (String.IsNullOrEmpty(StringUtil.RTrim( A160articulosnumserie)) ? true : false);
               A161articulosrefdocumento = cgiGet( edtarticulosrefdocumento_Internalname);
               n161articulosrefdocumento = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161articulosrefdocumento", A161articulosrefdocumento);
               n161articulosrefdocumento = (String.IsNullOrEmpty(StringUtil.RTrim( A161articulosrefdocumento)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosfechacoteja_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosfechacoteja"}), 1, "ARTICULOSFECHACOTEJA");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosfechacoteja_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A162articulosfechacoteja = (DateTime)(DateTime.MinValue);
                  n162articulosfechacoteja = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162articulosfechacoteja", context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A162articulosfechacoteja = context.localUtil.CToT( cgiGet( edtarticulosfechacoteja_Internalname));
                  n162articulosfechacoteja = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162articulosfechacoteja", context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
               }
               n162articulosfechacoteja = ((DateTime.MinValue==A162articulosfechacoteja) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosfechaentraalmacen_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosfechaentraalmacen"}), 1, "ARTICULOSFECHAENTRAALMACEN");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosfechaentraalmacen_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
                  n163articulosfechaentraalmacen = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163articulosfechaentraalmacen", context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A163articulosfechaentraalmacen = context.localUtil.CToT( cgiGet( edtarticulosfechaentraalmacen_Internalname));
                  n163articulosfechaentraalmacen = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163articulosfechaentraalmacen", context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
               }
               n163articulosfechaentraalmacen = ((DateTime.MinValue==A163articulosfechaentraalmacen) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosfechabajaalma_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosfechabajaalma"}), 1, "ARTICULOSFECHABAJAALMA");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosfechabajaalma_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
                  n164articulosfechabajaalma = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164articulosfechabajaalma", context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A164articulosfechabajaalma = context.localUtil.CToT( cgiGet( edtarticulosfechabajaalma_Internalname));
                  n164articulosfechabajaalma = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164articulosfechabajaalma", context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
               }
               n164articulosfechabajaalma = ((DateTime.MinValue==A164articulosfechabajaalma) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosstatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosstatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSSTATUS");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosstatus_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A165articulosstatus = 0;
                  n165articulosstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165articulosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A165articulosstatus), 18, 0)));
               }
               else
               {
                  A165articulosstatus = (long)(context.localUtil.CToN( cgiGet( edtarticulosstatus_Internalname), ",", "."));
                  n165articulosstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165articulosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A165articulosstatus), 18, 0)));
               }
               n165articulosstatus = ((0==A165articulosstatus) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticuloscontejado_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticuloscontejado_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSCONTEJADO");
                  AnyError = 1;
                  GX_FocusControl = edtarticuloscontejado_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A166articuloscontejado = 0;
                  n166articuloscontejado = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166articuloscontejado", StringUtil.LTrim( StringUtil.Str( (decimal)(A166articuloscontejado), 18, 0)));
               }
               else
               {
                  A166articuloscontejado = (long)(context.localUtil.CToN( cgiGet( edtarticuloscontejado_Internalname), ",", "."));
                  n166articuloscontejado = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166articuloscontejado", StringUtil.LTrim( StringUtil.Str( (decimal)(A166articuloscontejado), 18, 0)));
               }
               n166articuloscontejado = ((0==A166articuloscontejado) ? true : false);
               A167articulosusuario = cgiGet( edtarticulosusuario_Internalname);
               n167articulosusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167articulosusuario", A167articulosusuario);
               n167articulosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A167articulosusuario)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosidtrasfer_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosidtrasfer_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSIDTRASFER");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosidtrasfer_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A168articulosidtrasfer = 0;
                  n168articulosidtrasfer = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168articulosidtrasfer", StringUtil.LTrim( StringUtil.Str( (decimal)(A168articulosidtrasfer), 9, 0)));
               }
               else
               {
                  A168articulosidtrasfer = (int)(context.localUtil.CToN( cgiGet( edtarticulosidtrasfer_Internalname), ",", "."));
                  n168articulosidtrasfer = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168articulosidtrasfer", StringUtil.LTrim( StringUtil.Str( (decimal)(A168articulosidtrasfer), 9, 0)));
               }
               n168articulosidtrasfer = ((0==A168articulosidtrasfer) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosestatusariticulo_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosestatusariticulo_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSESTATUSARITICULO");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosestatusariticulo_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A169articulosestatusariticulo = 0;
                  n169articulosestatusariticulo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169articulosestatusariticulo", StringUtil.LTrim( StringUtil.Str( (decimal)(A169articulosestatusariticulo), 18, 0)));
               }
               else
               {
                  A169articulosestatusariticulo = (long)(context.localUtil.CToN( cgiGet( edtarticulosestatusariticulo_Internalname), ",", "."));
                  n169articulosestatusariticulo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169articulosestatusariticulo", StringUtil.LTrim( StringUtil.Str( (decimal)(A169articulosestatusariticulo), 18, 0)));
               }
               n169articulosestatusariticulo = ((0==A169articulosestatusariticulo) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulostipobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulostipobien_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSTIPOBIEN");
                  AnyError = 1;
                  GX_FocusControl = edtarticulostipobien_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A170articulostipobien = 0;
                  n170articulostipobien = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170articulostipobien", StringUtil.LTrim( StringUtil.Str( (decimal)(A170articulostipobien), 18, 0)));
               }
               else
               {
                  A170articulostipobien = (long)(context.localUtil.CToN( cgiGet( edtarticulostipobien_Internalname), ",", "."));
                  n170articulostipobien = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170articulostipobien", StringUtil.LTrim( StringUtil.Str( (decimal)(A170articulostipobien), 18, 0)));
               }
               n170articulostipobien = ((0==A170articulostipobien) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosfecreg"}), 1, "ARTICULOSFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A171articulosfecreg = (DateTime)(DateTime.MinValue);
                  n171articulosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171articulosfecreg", context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A171articulosfecreg = context.localUtil.CToT( cgiGet( edtarticulosfecreg_Internalname));
                  n171articulosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171articulosfecreg", context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n171articulosfecreg = ((DateTime.MinValue==A171articulosfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosfecultact"}), 1, "ARTICULOSFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A172articulosfecultact = (DateTime)(DateTime.MinValue);
                  n172articulosfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172articulosfecultact", context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A172articulosfecultact = context.localUtil.CToT( cgiGet( edtarticulosfecultact_Internalname));
                  n172articulosfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172articulosfecultact", context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n172articulosfecultact = ((DateTime.MinValue==A172articulosfecultact) ? true : false);
               /* Read saved values. */
               Z19almacenid = (long)(context.localUtil.CToN( cgiGet( "Z19almacenid"), ",", "."));
               Z20articulosproductoid = (int)(context.localUtil.CToN( cgiGet( "Z20articulosproductoid"), ",", "."));
               Z21articuloscambsid = (int)(context.localUtil.CToN( cgiGet( "Z21articuloscambsid"), ",", "."));
               Z154alamcenid = (long)(context.localUtil.CToN( cgiGet( "Z154alamcenid"), ",", "."));
               n154alamcenid = ((0==A154alamcenid) ? true : false);
               Z155articulosnoetiqueta = (long)(context.localUtil.CToN( cgiGet( "Z155articulosnoetiqueta"), ",", "."));
               n155articulosnoetiqueta = ((0==A155articulosnoetiqueta) ? true : false);
               Z156articulosdsc = cgiGet( "Z156articulosdsc");
               n156articulosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A156articulosdsc)) ? true : false);
               Z157articulospreciocompra = context.localUtil.CToN( cgiGet( "Z157articulospreciocompra"), ",", ".");
               n157articulospreciocompra = ((Convert.ToDecimal(0)==A157articulospreciocompra) ? true : false);
               Z158articulospreccomprareexp = context.localUtil.CToN( cgiGet( "Z158articulospreccomprareexp"), ",", ".");
               n158articulospreccomprareexp = ((Convert.ToDecimal(0)==A158articulospreccomprareexp) ? true : false);
               Z159articuloscantdepreacum = context.localUtil.CToN( cgiGet( "Z159articuloscantdepreacum"), ",", ".");
               n159articuloscantdepreacum = ((Convert.ToDecimal(0)==A159articuloscantdepreacum) ? true : false);
               Z160articulosnumserie = cgiGet( "Z160articulosnumserie");
               n160articulosnumserie = (String.IsNullOrEmpty(StringUtil.RTrim( A160articulosnumserie)) ? true : false);
               Z161articulosrefdocumento = cgiGet( "Z161articulosrefdocumento");
               n161articulosrefdocumento = (String.IsNullOrEmpty(StringUtil.RTrim( A161articulosrefdocumento)) ? true : false);
               Z162articulosfechacoteja = context.localUtil.CToT( cgiGet( "Z162articulosfechacoteja"), 0);
               n162articulosfechacoteja = ((DateTime.MinValue==A162articulosfechacoteja) ? true : false);
               Z163articulosfechaentraalmacen = context.localUtil.CToT( cgiGet( "Z163articulosfechaentraalmacen"), 0);
               n163articulosfechaentraalmacen = ((DateTime.MinValue==A163articulosfechaentraalmacen) ? true : false);
               Z164articulosfechabajaalma = context.localUtil.CToT( cgiGet( "Z164articulosfechabajaalma"), 0);
               n164articulosfechabajaalma = ((DateTime.MinValue==A164articulosfechabajaalma) ? true : false);
               Z165articulosstatus = (long)(context.localUtil.CToN( cgiGet( "Z165articulosstatus"), ",", "."));
               n165articulosstatus = ((0==A165articulosstatus) ? true : false);
               Z166articuloscontejado = (long)(context.localUtil.CToN( cgiGet( "Z166articuloscontejado"), ",", "."));
               n166articuloscontejado = ((0==A166articuloscontejado) ? true : false);
               Z167articulosusuario = cgiGet( "Z167articulosusuario");
               n167articulosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A167articulosusuario)) ? true : false);
               Z168articulosidtrasfer = (int)(context.localUtil.CToN( cgiGet( "Z168articulosidtrasfer"), ",", "."));
               n168articulosidtrasfer = ((0==A168articulosidtrasfer) ? true : false);
               Z169articulosestatusariticulo = (long)(context.localUtil.CToN( cgiGet( "Z169articulosestatusariticulo"), ",", "."));
               n169articulosestatusariticulo = ((0==A169articulosestatusariticulo) ? true : false);
               Z170articulostipobien = (long)(context.localUtil.CToN( cgiGet( "Z170articulostipobien"), ",", "."));
               n170articulostipobien = ((0==A170articulostipobien) ? true : false);
               Z171articulosfecreg = context.localUtil.CToT( cgiGet( "Z171articulosfecreg"), 0);
               n171articulosfecreg = ((DateTime.MinValue==A171articulosfecreg) ? true : false);
               Z172articulosfecultact = context.localUtil.CToT( cgiGet( "Z172articulosfecultact"), 0);
               n172articulosfecultact = ((DateTime.MinValue==A172articulosfecultact) ? true : false);
               Z23tipobienid = (int)(context.localUtil.CToN( cgiGet( "Z23tipobienid"), ",", "."));
               n23tipobienid = ((0==A23tipobienid) ? true : false);
               Z7entidafederativaid = (int)(context.localUtil.CToN( cgiGet( "Z7entidafederativaid"), ",", "."));
               n7entidafederativaid = ((0==A7entidafederativaid) ? true : false);
               Z10origenid = (long)(context.localUtil.CToN( cgiGet( "Z10origenid"), ",", "."));
               n10origenid = ((0==A10origenid) ? true : false);
               Z2proveedoresid = (int)(context.localUtil.CToN( cgiGet( "Z2proveedoresid"), ",", "."));
               n2proveedoresid = ((0==A2proveedoresid) ? true : false);
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
                  A19almacenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
                  A20articulosproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
                  A21articuloscambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
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
               InitAll0B11( ) ;
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
         DisableAttributes0B11( ) ;
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

      protected void ResetCaption0B0( )
      {
      }

      protected void ZM0B11( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z154alamcenid = T000B3_A154alamcenid[0];
               Z155articulosnoetiqueta = T000B3_A155articulosnoetiqueta[0];
               Z156articulosdsc = T000B3_A156articulosdsc[0];
               Z157articulospreciocompra = T000B3_A157articulospreciocompra[0];
               Z158articulospreccomprareexp = T000B3_A158articulospreccomprareexp[0];
               Z159articuloscantdepreacum = T000B3_A159articuloscantdepreacum[0];
               Z160articulosnumserie = T000B3_A160articulosnumserie[0];
               Z161articulosrefdocumento = T000B3_A161articulosrefdocumento[0];
               Z162articulosfechacoteja = T000B3_A162articulosfechacoteja[0];
               Z163articulosfechaentraalmacen = T000B3_A163articulosfechaentraalmacen[0];
               Z164articulosfechabajaalma = T000B3_A164articulosfechabajaalma[0];
               Z165articulosstatus = T000B3_A165articulosstatus[0];
               Z166articuloscontejado = T000B3_A166articuloscontejado[0];
               Z167articulosusuario = T000B3_A167articulosusuario[0];
               Z168articulosidtrasfer = T000B3_A168articulosidtrasfer[0];
               Z169articulosestatusariticulo = T000B3_A169articulosestatusariticulo[0];
               Z170articulostipobien = T000B3_A170articulostipobien[0];
               Z171articulosfecreg = T000B3_A171articulosfecreg[0];
               Z172articulosfecultact = T000B3_A172articulosfecultact[0];
               Z23tipobienid = T000B3_A23tipobienid[0];
               Z7entidafederativaid = T000B3_A7entidafederativaid[0];
               Z10origenid = T000B3_A10origenid[0];
               Z2proveedoresid = T000B3_A2proveedoresid[0];
            }
            else
            {
               Z154alamcenid = A154alamcenid;
               Z155articulosnoetiqueta = A155articulosnoetiqueta;
               Z156articulosdsc = A156articulosdsc;
               Z157articulospreciocompra = A157articulospreciocompra;
               Z158articulospreccomprareexp = A158articulospreccomprareexp;
               Z159articuloscantdepreacum = A159articuloscantdepreacum;
               Z160articulosnumserie = A160articulosnumserie;
               Z161articulosrefdocumento = A161articulosrefdocumento;
               Z162articulosfechacoteja = A162articulosfechacoteja;
               Z163articulosfechaentraalmacen = A163articulosfechaentraalmacen;
               Z164articulosfechabajaalma = A164articulosfechabajaalma;
               Z165articulosstatus = A165articulosstatus;
               Z166articuloscontejado = A166articuloscontejado;
               Z167articulosusuario = A167articulosusuario;
               Z168articulosidtrasfer = A168articulosidtrasfer;
               Z169articulosestatusariticulo = A169articulosestatusariticulo;
               Z170articulostipobien = A170articulostipobien;
               Z171articulosfecreg = A171articulosfecreg;
               Z172articulosfecultact = A172articulosfecultact;
               Z23tipobienid = A23tipobienid;
               Z7entidafederativaid = A7entidafederativaid;
               Z10origenid = A10origenid;
               Z2proveedoresid = A2proveedoresid;
            }
         }
         if ( GX_JID == -1 )
         {
            Z154alamcenid = A154alamcenid;
            Z155articulosnoetiqueta = A155articulosnoetiqueta;
            Z156articulosdsc = A156articulosdsc;
            Z157articulospreciocompra = A157articulospreciocompra;
            Z158articulospreccomprareexp = A158articulospreccomprareexp;
            Z159articuloscantdepreacum = A159articuloscantdepreacum;
            Z160articulosnumserie = A160articulosnumserie;
            Z161articulosrefdocumento = A161articulosrefdocumento;
            Z162articulosfechacoteja = A162articulosfechacoteja;
            Z163articulosfechaentraalmacen = A163articulosfechaentraalmacen;
            Z164articulosfechabajaalma = A164articulosfechabajaalma;
            Z165articulosstatus = A165articulosstatus;
            Z166articuloscontejado = A166articuloscontejado;
            Z167articulosusuario = A167articulosusuario;
            Z168articulosidtrasfer = A168articulosidtrasfer;
            Z169articulosestatusariticulo = A169articulosestatusariticulo;
            Z170articulostipobien = A170articulostipobien;
            Z171articulosfecreg = A171articulosfecreg;
            Z172articulosfecultact = A172articulosfecultact;
            Z19almacenid = A19almacenid;
            Z23tipobienid = A23tipobienid;
            Z7entidafederativaid = A7entidafederativaid;
            Z10origenid = A10origenid;
            Z2proveedoresid = A2proveedoresid;
            Z20articulosproductoid = A20articulosproductoid;
            Z21articuloscambsid = A21articuloscambsid;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ALMACENID"+"'), id:'"+"ALMACENID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_20_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ARTICULOSPRODUCTOID"+"'), id:'"+"ARTICULOSPRODUCTOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_21_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ARTICULOSCAMBSID"+"'), id:'"+"ARTICULOSCAMBSID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_23_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOBIENID"+"'), id:'"+"TIPOBIENID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_7_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ENTIDAFEDERATIVAID"+"'), id:'"+"ENTIDAFEDERATIVAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ORIGENID"+"'), id:'"+"ORIGENID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PROVEEDORESID"+"'), id:'"+"PROVEEDORESID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load0B11( )
      {
         /* Using cursor T000B11 */
         pr_default.execute(9, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound11 = 1;
            A154alamcenid = T000B11_A154alamcenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154alamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A154alamcenid), 18, 0)));
            n154alamcenid = T000B11_n154alamcenid[0];
            A155articulosnoetiqueta = T000B11_A155articulosnoetiqueta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155articulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(A155articulosnoetiqueta), 18, 0)));
            n155articulosnoetiqueta = T000B11_n155articulosnoetiqueta[0];
            A156articulosdsc = T000B11_A156articulosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156articulosdsc", A156articulosdsc);
            n156articulosdsc = T000B11_n156articulosdsc[0];
            A157articulospreciocompra = T000B11_A157articulospreciocompra[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157articulospreciocompra", StringUtil.LTrim( StringUtil.Str( A157articulospreciocompra, 17, 6)));
            n157articulospreciocompra = T000B11_n157articulospreciocompra[0];
            A158articulospreccomprareexp = T000B11_A158articulospreccomprareexp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158articulospreccomprareexp", StringUtil.LTrim( StringUtil.Str( A158articulospreccomprareexp, 17, 6)));
            n158articulospreccomprareexp = T000B11_n158articulospreccomprareexp[0];
            A159articuloscantdepreacum = T000B11_A159articuloscantdepreacum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159articuloscantdepreacum", StringUtil.LTrim( StringUtil.Str( A159articuloscantdepreacum, 17, 6)));
            n159articuloscantdepreacum = T000B11_n159articuloscantdepreacum[0];
            A160articulosnumserie = T000B11_A160articulosnumserie[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160articulosnumserie", A160articulosnumserie);
            n160articulosnumserie = T000B11_n160articulosnumserie[0];
            A161articulosrefdocumento = T000B11_A161articulosrefdocumento[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161articulosrefdocumento", A161articulosrefdocumento);
            n161articulosrefdocumento = T000B11_n161articulosrefdocumento[0];
            A162articulosfechacoteja = T000B11_A162articulosfechacoteja[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162articulosfechacoteja", context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
            n162articulosfechacoteja = T000B11_n162articulosfechacoteja[0];
            A163articulosfechaentraalmacen = T000B11_A163articulosfechaentraalmacen[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163articulosfechaentraalmacen", context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
            n163articulosfechaentraalmacen = T000B11_n163articulosfechaentraalmacen[0];
            A164articulosfechabajaalma = T000B11_A164articulosfechabajaalma[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164articulosfechabajaalma", context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
            n164articulosfechabajaalma = T000B11_n164articulosfechabajaalma[0];
            A165articulosstatus = T000B11_A165articulosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165articulosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A165articulosstatus), 18, 0)));
            n165articulosstatus = T000B11_n165articulosstatus[0];
            A166articuloscontejado = T000B11_A166articuloscontejado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166articuloscontejado", StringUtil.LTrim( StringUtil.Str( (decimal)(A166articuloscontejado), 18, 0)));
            n166articuloscontejado = T000B11_n166articuloscontejado[0];
            A167articulosusuario = T000B11_A167articulosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167articulosusuario", A167articulosusuario);
            n167articulosusuario = T000B11_n167articulosusuario[0];
            A168articulosidtrasfer = T000B11_A168articulosidtrasfer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168articulosidtrasfer", StringUtil.LTrim( StringUtil.Str( (decimal)(A168articulosidtrasfer), 9, 0)));
            n168articulosidtrasfer = T000B11_n168articulosidtrasfer[0];
            A169articulosestatusariticulo = T000B11_A169articulosestatusariticulo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169articulosestatusariticulo", StringUtil.LTrim( StringUtil.Str( (decimal)(A169articulosestatusariticulo), 18, 0)));
            n169articulosestatusariticulo = T000B11_n169articulosestatusariticulo[0];
            A170articulostipobien = T000B11_A170articulostipobien[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170articulostipobien", StringUtil.LTrim( StringUtil.Str( (decimal)(A170articulostipobien), 18, 0)));
            n170articulostipobien = T000B11_n170articulostipobien[0];
            A171articulosfecreg = T000B11_A171articulosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171articulosfecreg", context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
            n171articulosfecreg = T000B11_n171articulosfecreg[0];
            A172articulosfecultact = T000B11_A172articulosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172articulosfecultact", context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
            n172articulosfecultact = T000B11_n172articulosfecultact[0];
            A23tipobienid = T000B11_A23tipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            n23tipobienid = T000B11_n23tipobienid[0];
            A7entidafederativaid = T000B11_A7entidafederativaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            n7entidafederativaid = T000B11_n7entidafederativaid[0];
            A10origenid = T000B11_A10origenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            n10origenid = T000B11_n10origenid[0];
            A2proveedoresid = T000B11_A2proveedoresid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            n2proveedoresid = T000B11_n2proveedoresid[0];
            ZM0B11( -1) ;
         }
         pr_default.close(9);
         OnLoadActions0B11( ) ;
      }

      protected void OnLoadActions0B11( )
      {
      }

      protected void CheckExtendedTable0B11( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T000B9 */
         pr_default.execute(7, new Object[] {A20articulosproductoid});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'articulosproducto'.", "ForeignKeyNotFound", 1, "ARTICULOSPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtarticulosproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(7);
         /* Using cursor T000B10 */
         pr_default.execute(8, new Object[] {A21articuloscambsid});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'articuloscambs'.", "ForeignKeyNotFound", 1, "ARTICULOSCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtarticuloscambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(8);
         /* Using cursor T000B12 */
         pr_default.execute(10, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(10) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"almacenid"}), 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(10);
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A23tipobienid) ) )
            {
               GX_msglist.addItem("No existe 'tipobien'.", "ForeignKeyNotFound", 1, "TIPOBIENID");
               AnyError = 1;
               GX_FocusControl = edttipobienid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(3);
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A7entidafederativaid) ) )
            {
               GX_msglist.addItem("No existe 'entidadfederativa'.", "ForeignKeyNotFound", 1, "ENTIDAFEDERATIVAID");
               AnyError = 1;
               GX_FocusControl = edtentidafederativaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(4);
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A10origenid) ) )
            {
               GX_msglist.addItem("No existe 'origen'.", "ForeignKeyNotFound", 1, "ORIGENID");
               AnyError = 1;
               GX_FocusControl = edtorigenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(5);
         /* Using cursor T000B8 */
         pr_default.execute(6, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A2proveedoresid) ) )
            {
               GX_msglist.addItem("No existe 'proveedores'.", "ForeignKeyNotFound", 1, "PROVEEDORESID");
               AnyError = 1;
               GX_FocusControl = edtproveedoresid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors0B11( )
      {
         pr_default.close(2);
         pr_default.close(7);
         pr_default.close(8);
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( long A19almacenid )
      {
         /* Using cursor T000B13 */
         pr_default.execute(11, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(11);
      }

      protected void gxLoad_8( int A20articulosproductoid )
      {
         /* Using cursor T000B14 */
         pr_default.execute(12, new Object[] {A20articulosproductoid});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'articulosproducto'.", "ForeignKeyNotFound", 1, "ARTICULOSPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtarticulosproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void gxLoad_9( int A21articuloscambsid )
      {
         /* Using cursor T000B15 */
         pr_default.execute(13, new Object[] {A21articuloscambsid});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'articuloscambs'.", "ForeignKeyNotFound", 1, "ARTICULOSCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtarticuloscambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(13);
      }

      protected void gxLoad_4( int A23tipobienid )
      {
         /* Using cursor T000B16 */
         pr_default.execute(14, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A23tipobienid) ) )
            {
               GX_msglist.addItem("No existe 'tipobien'.", "ForeignKeyNotFound", 1, "TIPOBIENID");
               AnyError = 1;
               GX_FocusControl = edttipobienid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(14);
      }

      protected void gxLoad_5( int A7entidafederativaid )
      {
         /* Using cursor T000B17 */
         pr_default.execute(15, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(15) == 101) )
         {
            if ( ! ( (0==A7entidafederativaid) ) )
            {
               GX_msglist.addItem("No existe 'entidadfederativa'.", "ForeignKeyNotFound", 1, "ENTIDAFEDERATIVAID");
               AnyError = 1;
               GX_FocusControl = edtentidafederativaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(15);
      }

      protected void gxLoad_6( long A10origenid )
      {
         /* Using cursor T000B18 */
         pr_default.execute(16, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(16) == 101) )
         {
            if ( ! ( (0==A10origenid) ) )
            {
               GX_msglist.addItem("No existe 'origen'.", "ForeignKeyNotFound", 1, "ORIGENID");
               AnyError = 1;
               GX_FocusControl = edtorigenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(16) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(16);
      }

      protected void gxLoad_7( int A2proveedoresid )
      {
         /* Using cursor T000B19 */
         pr_default.execute(17, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(17) == 101) )
         {
            if ( ! ( (0==A2proveedoresid) ) )
            {
               GX_msglist.addItem("No existe 'proveedores'.", "ForeignKeyNotFound", 1, "PROVEEDORESID");
               AnyError = 1;
               GX_FocusControl = edtproveedoresid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(17);
      }

      protected void GetKey0B11( )
      {
         /* Using cursor T000B20 */
         pr_default.execute(18, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B11( 1) ;
            RcdFound11 = 1;
            A154alamcenid = T000B3_A154alamcenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154alamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A154alamcenid), 18, 0)));
            n154alamcenid = T000B3_n154alamcenid[0];
            A155articulosnoetiqueta = T000B3_A155articulosnoetiqueta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155articulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(A155articulosnoetiqueta), 18, 0)));
            n155articulosnoetiqueta = T000B3_n155articulosnoetiqueta[0];
            A156articulosdsc = T000B3_A156articulosdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156articulosdsc", A156articulosdsc);
            n156articulosdsc = T000B3_n156articulosdsc[0];
            A157articulospreciocompra = T000B3_A157articulospreciocompra[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157articulospreciocompra", StringUtil.LTrim( StringUtil.Str( A157articulospreciocompra, 17, 6)));
            n157articulospreciocompra = T000B3_n157articulospreciocompra[0];
            A158articulospreccomprareexp = T000B3_A158articulospreccomprareexp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158articulospreccomprareexp", StringUtil.LTrim( StringUtil.Str( A158articulospreccomprareexp, 17, 6)));
            n158articulospreccomprareexp = T000B3_n158articulospreccomprareexp[0];
            A159articuloscantdepreacum = T000B3_A159articuloscantdepreacum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159articuloscantdepreacum", StringUtil.LTrim( StringUtil.Str( A159articuloscantdepreacum, 17, 6)));
            n159articuloscantdepreacum = T000B3_n159articuloscantdepreacum[0];
            A160articulosnumserie = T000B3_A160articulosnumserie[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160articulosnumserie", A160articulosnumserie);
            n160articulosnumserie = T000B3_n160articulosnumserie[0];
            A161articulosrefdocumento = T000B3_A161articulosrefdocumento[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161articulosrefdocumento", A161articulosrefdocumento);
            n161articulosrefdocumento = T000B3_n161articulosrefdocumento[0];
            A162articulosfechacoteja = T000B3_A162articulosfechacoteja[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162articulosfechacoteja", context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
            n162articulosfechacoteja = T000B3_n162articulosfechacoteja[0];
            A163articulosfechaentraalmacen = T000B3_A163articulosfechaentraalmacen[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163articulosfechaentraalmacen", context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
            n163articulosfechaentraalmacen = T000B3_n163articulosfechaentraalmacen[0];
            A164articulosfechabajaalma = T000B3_A164articulosfechabajaalma[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164articulosfechabajaalma", context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
            n164articulosfechabajaalma = T000B3_n164articulosfechabajaalma[0];
            A165articulosstatus = T000B3_A165articulosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165articulosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A165articulosstatus), 18, 0)));
            n165articulosstatus = T000B3_n165articulosstatus[0];
            A166articuloscontejado = T000B3_A166articuloscontejado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166articuloscontejado", StringUtil.LTrim( StringUtil.Str( (decimal)(A166articuloscontejado), 18, 0)));
            n166articuloscontejado = T000B3_n166articuloscontejado[0];
            A167articulosusuario = T000B3_A167articulosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167articulosusuario", A167articulosusuario);
            n167articulosusuario = T000B3_n167articulosusuario[0];
            A168articulosidtrasfer = T000B3_A168articulosidtrasfer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168articulosidtrasfer", StringUtil.LTrim( StringUtil.Str( (decimal)(A168articulosidtrasfer), 9, 0)));
            n168articulosidtrasfer = T000B3_n168articulosidtrasfer[0];
            A169articulosestatusariticulo = T000B3_A169articulosestatusariticulo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169articulosestatusariticulo", StringUtil.LTrim( StringUtil.Str( (decimal)(A169articulosestatusariticulo), 18, 0)));
            n169articulosestatusariticulo = T000B3_n169articulosestatusariticulo[0];
            A170articulostipobien = T000B3_A170articulostipobien[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170articulostipobien", StringUtil.LTrim( StringUtil.Str( (decimal)(A170articulostipobien), 18, 0)));
            n170articulostipobien = T000B3_n170articulostipobien[0];
            A171articulosfecreg = T000B3_A171articulosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171articulosfecreg", context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
            n171articulosfecreg = T000B3_n171articulosfecreg[0];
            A172articulosfecultact = T000B3_A172articulosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172articulosfecultact", context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
            n172articulosfecultact = T000B3_n172articulosfecultact[0];
            A19almacenid = T000B3_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            A23tipobienid = T000B3_A23tipobienid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
            n23tipobienid = T000B3_n23tipobienid[0];
            A7entidafederativaid = T000B3_A7entidafederativaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
            n7entidafederativaid = T000B3_n7entidafederativaid[0];
            A10origenid = T000B3_A10origenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            n10origenid = T000B3_n10origenid[0];
            A2proveedoresid = T000B3_A2proveedoresid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
            n2proveedoresid = T000B3_n2proveedoresid[0];
            A20articulosproductoid = T000B3_A20articulosproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
            A21articuloscambsid = T000B3_A21articuloscambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
            Z19almacenid = A19almacenid;
            Z20articulosproductoid = A20articulosproductoid;
            Z21articuloscambsid = A21articuloscambsid;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0B11( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0B11( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0B11( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B11( ) ;
         if ( RcdFound11 == 0 )
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
         RcdFound11 = 0;
         /* Using cursor T000B21 */
         pr_default.execute(19, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(19) != 101) )
         {
            while ( (pr_default.getStatus(19) != 101) && ( ( T000B21_A19almacenid[0] < A19almacenid ) || ( T000B21_A19almacenid[0] == A19almacenid ) && ( T000B21_A20articulosproductoid[0] < A20articulosproductoid ) || ( T000B21_A20articulosproductoid[0] == A20articulosproductoid ) && ( T000B21_A19almacenid[0] == A19almacenid ) && ( T000B21_A21articuloscambsid[0] < A21articuloscambsid ) ) )
            {
               pr_default.readNext(19);
            }
            if ( (pr_default.getStatus(19) != 101) && ( ( T000B21_A19almacenid[0] > A19almacenid ) || ( T000B21_A19almacenid[0] == A19almacenid ) && ( T000B21_A20articulosproductoid[0] > A20articulosproductoid ) || ( T000B21_A20articulosproductoid[0] == A20articulosproductoid ) && ( T000B21_A19almacenid[0] == A19almacenid ) && ( T000B21_A21articuloscambsid[0] > A21articuloscambsid ) ) )
            {
               A19almacenid = T000B21_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               A20articulosproductoid = T000B21_A20articulosproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
               A21articuloscambsid = T000B21_A21articuloscambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(19);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T000B22 */
         pr_default.execute(20, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(20) != 101) )
         {
            while ( (pr_default.getStatus(20) != 101) && ( ( T000B22_A19almacenid[0] > A19almacenid ) || ( T000B22_A19almacenid[0] == A19almacenid ) && ( T000B22_A20articulosproductoid[0] > A20articulosproductoid ) || ( T000B22_A20articulosproductoid[0] == A20articulosproductoid ) && ( T000B22_A19almacenid[0] == A19almacenid ) && ( T000B22_A21articuloscambsid[0] > A21articuloscambsid ) ) )
            {
               pr_default.readNext(20);
            }
            if ( (pr_default.getStatus(20) != 101) && ( ( T000B22_A19almacenid[0] < A19almacenid ) || ( T000B22_A19almacenid[0] == A19almacenid ) && ( T000B22_A20articulosproductoid[0] < A20articulosproductoid ) || ( T000B22_A20articulosproductoid[0] == A20articulosproductoid ) && ( T000B22_A19almacenid[0] == A19almacenid ) && ( T000B22_A21articuloscambsid[0] < A21articuloscambsid ) ) )
            {
               A19almacenid = T000B22_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               A20articulosproductoid = T000B22_A20articulosproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
               A21articuloscambsid = T000B22_A21articuloscambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(20);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0B11( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0B11( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( ( A19almacenid != Z19almacenid ) || ( A20articulosproductoid != Z20articulosproductoid ) || ( A21articuloscambsid != Z21articuloscambsid ) )
               {
                  A19almacenid = Z19almacenid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
                  A20articulosproductoid = Z20articulosproductoid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
                  A21articuloscambsid = Z21articuloscambsid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ALMACENID");
                  AnyError = 1;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0B11( ) ;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A19almacenid != Z19almacenid ) || ( A20articulosproductoid != Z20articulosproductoid ) || ( A21articuloscambsid != Z21articuloscambsid ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0B11( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ALMACENID");
                     AnyError = 1;
                     GX_FocusControl = edtalmacenid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtalmacenid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0B11( ) ;
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
         if ( ( A19almacenid != Z19almacenid ) || ( A20articulosproductoid != Z20articulosproductoid ) || ( A21articuloscambsid != Z21articuloscambsid ) )
         {
            A19almacenid = Z19almacenid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            A20articulosproductoid = Z20articulosproductoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
            A21articuloscambsid = Z21articuloscambsid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtalmacenid_Internalname;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtalamcenid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0B11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtalamcenid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B11( ) ;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtalamcenid_Internalname;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtalamcenid_Internalname;
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
         ScanStart0B11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound11 != 0 )
            {
               ScanNext0B11( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtalamcenid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0B11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B2 */
            pr_default.execute(0, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ARTICULOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z154alamcenid != T000B2_A154alamcenid[0] ) || ( Z155articulosnoetiqueta != T000B2_A155articulosnoetiqueta[0] ) || ( StringUtil.StrCmp(Z156articulosdsc, T000B2_A156articulosdsc[0]) != 0 ) || ( Z157articulospreciocompra != T000B2_A157articulospreciocompra[0] ) || ( Z158articulospreccomprareexp != T000B2_A158articulospreccomprareexp[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z159articuloscantdepreacum != T000B2_A159articuloscantdepreacum[0] ) || ( StringUtil.StrCmp(Z160articulosnumserie, T000B2_A160articulosnumserie[0]) != 0 ) || ( StringUtil.StrCmp(Z161articulosrefdocumento, T000B2_A161articulosrefdocumento[0]) != 0 ) || ( Z162articulosfechacoteja != T000B2_A162articulosfechacoteja[0] ) || ( Z163articulosfechaentraalmacen != T000B2_A163articulosfechaentraalmacen[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z164articulosfechabajaalma != T000B2_A164articulosfechabajaalma[0] ) || ( Z165articulosstatus != T000B2_A165articulosstatus[0] ) || ( Z166articuloscontejado != T000B2_A166articuloscontejado[0] ) || ( StringUtil.StrCmp(Z167articulosusuario, T000B2_A167articulosusuario[0]) != 0 ) || ( Z168articulosidtrasfer != T000B2_A168articulosidtrasfer[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z169articulosestatusariticulo != T000B2_A169articulosestatusariticulo[0] ) || ( Z170articulostipobien != T000B2_A170articulostipobien[0] ) || ( Z171articulosfecreg != T000B2_A171articulosfecreg[0] ) || ( Z172articulosfecultact != T000B2_A172articulosfecultact[0] ) || ( Z23tipobienid != T000B2_A23tipobienid[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z7entidafederativaid != T000B2_A7entidafederativaid[0] ) || ( Z10origenid != T000B2_A10origenid[0] ) || ( Z2proveedoresid != T000B2_A2proveedoresid[0] ) )
            {
               if ( Z154alamcenid != T000B2_A154alamcenid[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"alamcenid");
                  GXUtil.WriteLogRaw("Old: ",Z154alamcenid);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A154alamcenid[0]);
               }
               if ( Z155articulosnoetiqueta != T000B2_A155articulosnoetiqueta[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosnoetiqueta");
                  GXUtil.WriteLogRaw("Old: ",Z155articulosnoetiqueta);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A155articulosnoetiqueta[0]);
               }
               if ( StringUtil.StrCmp(Z156articulosdsc, T000B2_A156articulosdsc[0]) != 0 )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosdsc");
                  GXUtil.WriteLogRaw("Old: ",Z156articulosdsc);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A156articulosdsc[0]);
               }
               if ( Z157articulospreciocompra != T000B2_A157articulospreciocompra[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulospreciocompra");
                  GXUtil.WriteLogRaw("Old: ",Z157articulospreciocompra);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A157articulospreciocompra[0]);
               }
               if ( Z158articulospreccomprareexp != T000B2_A158articulospreccomprareexp[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulospreccomprareexp");
                  GXUtil.WriteLogRaw("Old: ",Z158articulospreccomprareexp);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A158articulospreccomprareexp[0]);
               }
               if ( Z159articuloscantdepreacum != T000B2_A159articuloscantdepreacum[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articuloscantdepreacum");
                  GXUtil.WriteLogRaw("Old: ",Z159articuloscantdepreacum);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A159articuloscantdepreacum[0]);
               }
               if ( StringUtil.StrCmp(Z160articulosnumserie, T000B2_A160articulosnumserie[0]) != 0 )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosnumserie");
                  GXUtil.WriteLogRaw("Old: ",Z160articulosnumserie);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A160articulosnumserie[0]);
               }
               if ( StringUtil.StrCmp(Z161articulosrefdocumento, T000B2_A161articulosrefdocumento[0]) != 0 )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosrefdocumento");
                  GXUtil.WriteLogRaw("Old: ",Z161articulosrefdocumento);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A161articulosrefdocumento[0]);
               }
               if ( Z162articulosfechacoteja != T000B2_A162articulosfechacoteja[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosfechacoteja");
                  GXUtil.WriteLogRaw("Old: ",Z162articulosfechacoteja);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A162articulosfechacoteja[0]);
               }
               if ( Z163articulosfechaentraalmacen != T000B2_A163articulosfechaentraalmacen[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosfechaentraalmacen");
                  GXUtil.WriteLogRaw("Old: ",Z163articulosfechaentraalmacen);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A163articulosfechaentraalmacen[0]);
               }
               if ( Z164articulosfechabajaalma != T000B2_A164articulosfechabajaalma[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosfechabajaalma");
                  GXUtil.WriteLogRaw("Old: ",Z164articulosfechabajaalma);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A164articulosfechabajaalma[0]);
               }
               if ( Z165articulosstatus != T000B2_A165articulosstatus[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosstatus");
                  GXUtil.WriteLogRaw("Old: ",Z165articulosstatus);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A165articulosstatus[0]);
               }
               if ( Z166articuloscontejado != T000B2_A166articuloscontejado[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articuloscontejado");
                  GXUtil.WriteLogRaw("Old: ",Z166articuloscontejado);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A166articuloscontejado[0]);
               }
               if ( StringUtil.StrCmp(Z167articulosusuario, T000B2_A167articulosusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosusuario");
                  GXUtil.WriteLogRaw("Old: ",Z167articulosusuario);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A167articulosusuario[0]);
               }
               if ( Z168articulosidtrasfer != T000B2_A168articulosidtrasfer[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosidtrasfer");
                  GXUtil.WriteLogRaw("Old: ",Z168articulosidtrasfer);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A168articulosidtrasfer[0]);
               }
               if ( Z169articulosestatusariticulo != T000B2_A169articulosestatusariticulo[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosestatusariticulo");
                  GXUtil.WriteLogRaw("Old: ",Z169articulosestatusariticulo);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A169articulosestatusariticulo[0]);
               }
               if ( Z170articulostipobien != T000B2_A170articulostipobien[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulostipobien");
                  GXUtil.WriteLogRaw("Old: ",Z170articulostipobien);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A170articulostipobien[0]);
               }
               if ( Z171articulosfecreg != T000B2_A171articulosfecreg[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z171articulosfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A171articulosfecreg[0]);
               }
               if ( Z172articulosfecultact != T000B2_A172articulosfecultact[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"articulosfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z172articulosfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A172articulosfecultact[0]);
               }
               if ( Z23tipobienid != T000B2_A23tipobienid[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"tipobienid");
                  GXUtil.WriteLogRaw("Old: ",Z23tipobienid);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A23tipobienid[0]);
               }
               if ( Z7entidafederativaid != T000B2_A7entidafederativaid[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"entidafederativaid");
                  GXUtil.WriteLogRaw("Old: ",Z7entidafederativaid);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A7entidafederativaid[0]);
               }
               if ( Z10origenid != T000B2_A10origenid[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"origenid");
                  GXUtil.WriteLogRaw("Old: ",Z10origenid);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A10origenid[0]);
               }
               if ( Z2proveedoresid != T000B2_A2proveedoresid[0] )
               {
                  GXUtil.WriteLog("articulos:[seudo value changed for attri]"+"proveedoresid");
                  GXUtil.WriteLogRaw("Old: ",Z2proveedoresid);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A2proveedoresid[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ARTICULOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B11( 0) ;
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B23 */
                     pr_default.execute(21, new Object[] {n154alamcenid, A154alamcenid, n155articulosnoetiqueta, A155articulosnoetiqueta, n156articulosdsc, A156articulosdsc, n157articulospreciocompra, A157articulospreciocompra, n158articulospreccomprareexp, A158articulospreccomprareexp, n159articuloscantdepreacum, A159articuloscantdepreacum, n160articulosnumserie, A160articulosnumserie, n161articulosrefdocumento, A161articulosrefdocumento, n162articulosfechacoteja, A162articulosfechacoteja, n163articulosfechaentraalmacen, A163articulosfechaentraalmacen, n164articulosfechabajaalma, A164articulosfechabajaalma, n165articulosstatus, A165articulosstatus, n166articuloscontejado, A166articuloscontejado, n167articulosusuario, A167articulosusuario, n168articulosidtrasfer, A168articulosidtrasfer, n169articulosestatusariticulo, A169articulosestatusariticulo, n170articulostipobien, A170articulostipobien, n171articulosfecreg, A171articulosfecreg, n172articulosfecultact, A172articulosfecultact, A19almacenid, n23tipobienid, A23tipobienid, n7entidafederativaid, A7entidafederativaid, n10origenid, A10origenid, n2proveedoresid, A2proveedoresid, A20articulosproductoid, A21articuloscambsid});
                     pr_default.close(21);
                     dsDefault.SmartCacheProvider.SetUpdated("ARTICULOS") ;
                     if ( (pr_default.getStatus(21) == 1) )
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
                           ResetCaption0B0( ) ;
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
               Load0B11( ) ;
            }
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void Update0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B24 */
                     pr_default.execute(22, new Object[] {n154alamcenid, A154alamcenid, n155articulosnoetiqueta, A155articulosnoetiqueta, n156articulosdsc, A156articulosdsc, n157articulospreciocompra, A157articulospreciocompra, n158articulospreccomprareexp, A158articulospreccomprareexp, n159articuloscantdepreacum, A159articuloscantdepreacum, n160articulosnumserie, A160articulosnumserie, n161articulosrefdocumento, A161articulosrefdocumento, n162articulosfechacoteja, A162articulosfechacoteja, n163articulosfechaentraalmacen, A163articulosfechaentraalmacen, n164articulosfechabajaalma, A164articulosfechabajaalma, n165articulosstatus, A165articulosstatus, n166articuloscontejado, A166articuloscontejado, n167articulosusuario, A167articulosusuario, n168articulosidtrasfer, A168articulosidtrasfer, n169articulosestatusariticulo, A169articulosestatusariticulo, n170articulostipobien, A170articulostipobien, n171articulosfecreg, A171articulosfecreg, n172articulosfecultact, A172articulosfecultact, n23tipobienid, A23tipobienid, n7entidafederativaid, A7entidafederativaid, n10origenid, A10origenid, n2proveedoresid, A2proveedoresid, A19almacenid, A20articulosproductoid, A21articuloscambsid});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("ARTICULOS") ;
                     if ( (pr_default.getStatus(22) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ARTICULOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B11( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0B0( ) ;
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
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void DeferredUpdate0B11( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B11( ) ;
            AfterConfirm0B11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B25 */
                  pr_default.execute(23, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
                  pr_default.close(23);
                  dsDefault.SmartCacheProvider.SetUpdated("ARTICULOS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound11 == 0 )
                        {
                           InitAll0B11( ) ;
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
                        ResetCaption0B0( ) ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0B11( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0B11( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "articulos");
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "articulos");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0B11( )
      {
         /* Using cursor T000B26 */
         pr_default.execute(24);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound11 = 1;
            A19almacenid = T000B26_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            A20articulosproductoid = T000B26_A20articulosproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
            A21articuloscambsid = T000B26_A21articuloscambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B11( )
      {
         /* Scan next routine */
         pr_default.readNext(24);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound11 = 1;
            A19almacenid = T000B26_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            A20articulosproductoid = T000B26_A20articulosproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
            A21articuloscambsid = T000B26_A21articuloscambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
         }
      }

      protected void ScanEnd0B11( )
      {
         pr_default.close(24);
      }

      protected void AfterConfirm0B11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B11( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B11( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B11( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B11( )
      {
         edtalmacenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenid_Enabled), 5, 0)));
         edtarticulosproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosproductoid_Enabled), 5, 0)));
         edtarticuloscambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticuloscambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticuloscambsid_Enabled), 5, 0)));
         edtalamcenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalamcenid_Enabled), 5, 0)));
         edtarticulosnoetiqueta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosnoetiqueta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosnoetiqueta_Enabled), 5, 0)));
         edttipobienid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipobienid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipobienid_Enabled), 5, 0)));
         edtentidafederativaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtentidafederativaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtentidafederativaid_Enabled), 5, 0)));
         edtorigenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenid_Enabled), 5, 0)));
         edtarticulosdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosdsc_Enabled), 5, 0)));
         edtproveedoresid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtproveedoresid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtproveedoresid_Enabled), 5, 0)));
         edtarticulospreciocompra_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulospreciocompra_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulospreciocompra_Enabled), 5, 0)));
         edtarticulospreccomprareexp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulospreccomprareexp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulospreccomprareexp_Enabled), 5, 0)));
         edtarticuloscantdepreacum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticuloscantdepreacum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticuloscantdepreacum_Enabled), 5, 0)));
         edtarticulosnumserie_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosnumserie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosnumserie_Enabled), 5, 0)));
         edtarticulosrefdocumento_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosrefdocumento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosrefdocumento_Enabled), 5, 0)));
         edtarticulosfechacoteja_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosfechacoteja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosfechacoteja_Enabled), 5, 0)));
         edtarticulosfechaentraalmacen_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosfechaentraalmacen_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosfechaentraalmacen_Enabled), 5, 0)));
         edtarticulosfechabajaalma_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosfechabajaalma_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosfechabajaalma_Enabled), 5, 0)));
         edtarticulosstatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosstatus_Enabled), 5, 0)));
         edtarticuloscontejado_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticuloscontejado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticuloscontejado_Enabled), 5, 0)));
         edtarticulosusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosusuario_Enabled), 5, 0)));
         edtarticulosidtrasfer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosidtrasfer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosidtrasfer_Enabled), 5, 0)));
         edtarticulosestatusariticulo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosestatusariticulo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosestatusariticulo_Enabled), 5, 0)));
         edtarticulostipobien_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulostipobien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulostipobien_Enabled), 5, 0)));
         edtarticulosfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosfecreg_Enabled), 5, 0)));
         edtarticulosfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20221290562633");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("articulos.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z19almacenid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19almacenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z20articulosproductoid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20articulosproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z21articuloscambsid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21articuloscambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z154alamcenid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z154alamcenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z155articulosnoetiqueta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z155articulosnoetiqueta), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z156articulosdsc", Z156articulosdsc);
         GxWebStd.gx_hidden_field( context, "Z157articulospreciocompra", StringUtil.LTrim( StringUtil.NToC( Z157articulospreciocompra, 17, 6, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z158articulospreccomprareexp", StringUtil.LTrim( StringUtil.NToC( Z158articulospreccomprareexp, 17, 6, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z159articuloscantdepreacum", StringUtil.LTrim( StringUtil.NToC( Z159articuloscantdepreacum, 17, 6, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z160articulosnumserie", Z160articulosnumserie);
         GxWebStd.gx_hidden_field( context, "Z161articulosrefdocumento", Z161articulosrefdocumento);
         GxWebStd.gx_hidden_field( context, "Z162articulosfechacoteja", context.localUtil.TToC( Z162articulosfechacoteja, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z163articulosfechaentraalmacen", context.localUtil.TToC( Z163articulosfechaentraalmacen, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z164articulosfechabajaalma", context.localUtil.TToC( Z164articulosfechabajaalma, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z165articulosstatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z165articulosstatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z166articuloscontejado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z166articuloscontejado), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z167articulosusuario", Z167articulosusuario);
         GxWebStd.gx_hidden_field( context, "Z168articulosidtrasfer", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z168articulosidtrasfer), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z169articulosestatusariticulo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z169articulosestatusariticulo), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z170articulostipobien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z170articulostipobien), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z171articulosfecreg", context.localUtil.TToC( Z171articulosfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z172articulosfecultact", context.localUtil.TToC( Z172articulosfecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z23tipobienid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23tipobienid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z7entidafederativaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7entidafederativaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z10origenid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10origenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2proveedoresid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2proveedoresid), 9, 0, ",", "")));
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
         return formatLink("articulos.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "articulos" ;
      }

      public override String GetPgmdesc( )
      {
         return "articulos" ;
      }

      protected void InitializeNonKey0B11( )
      {
         A154alamcenid = 0;
         n154alamcenid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154alamcenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A154alamcenid), 18, 0)));
         n154alamcenid = ((0==A154alamcenid) ? true : false);
         A155articulosnoetiqueta = 0;
         n155articulosnoetiqueta = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155articulosnoetiqueta", StringUtil.LTrim( StringUtil.Str( (decimal)(A155articulosnoetiqueta), 18, 0)));
         n155articulosnoetiqueta = ((0==A155articulosnoetiqueta) ? true : false);
         A23tipobienid = 0;
         n23tipobienid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(A23tipobienid), 9, 0)));
         n23tipobienid = ((0==A23tipobienid) ? true : false);
         A7entidafederativaid = 0;
         n7entidafederativaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7entidafederativaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A7entidafederativaid), 9, 0)));
         n7entidafederativaid = ((0==A7entidafederativaid) ? true : false);
         A10origenid = 0;
         n10origenid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
         n10origenid = ((0==A10origenid) ? true : false);
         A156articulosdsc = "";
         n156articulosdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156articulosdsc", A156articulosdsc);
         n156articulosdsc = (String.IsNullOrEmpty(StringUtil.RTrim( A156articulosdsc)) ? true : false);
         A2proveedoresid = 0;
         n2proveedoresid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2proveedoresid", StringUtil.LTrim( StringUtil.Str( (decimal)(A2proveedoresid), 9, 0)));
         n2proveedoresid = ((0==A2proveedoresid) ? true : false);
         A157articulospreciocompra = 0;
         n157articulospreciocompra = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157articulospreciocompra", StringUtil.LTrim( StringUtil.Str( A157articulospreciocompra, 17, 6)));
         n157articulospreciocompra = ((Convert.ToDecimal(0)==A157articulospreciocompra) ? true : false);
         A158articulospreccomprareexp = 0;
         n158articulospreccomprareexp = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158articulospreccomprareexp", StringUtil.LTrim( StringUtil.Str( A158articulospreccomprareexp, 17, 6)));
         n158articulospreccomprareexp = ((Convert.ToDecimal(0)==A158articulospreccomprareexp) ? true : false);
         A159articuloscantdepreacum = 0;
         n159articuloscantdepreacum = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159articuloscantdepreacum", StringUtil.LTrim( StringUtil.Str( A159articuloscantdepreacum, 17, 6)));
         n159articuloscantdepreacum = ((Convert.ToDecimal(0)==A159articuloscantdepreacum) ? true : false);
         A160articulosnumserie = "";
         n160articulosnumserie = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160articulosnumserie", A160articulosnumserie);
         n160articulosnumserie = (String.IsNullOrEmpty(StringUtil.RTrim( A160articulosnumserie)) ? true : false);
         A161articulosrefdocumento = "";
         n161articulosrefdocumento = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161articulosrefdocumento", A161articulosrefdocumento);
         n161articulosrefdocumento = (String.IsNullOrEmpty(StringUtil.RTrim( A161articulosrefdocumento)) ? true : false);
         A162articulosfechacoteja = (DateTime)(DateTime.MinValue);
         n162articulosfechacoteja = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162articulosfechacoteja", context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
         n162articulosfechacoteja = ((DateTime.MinValue==A162articulosfechacoteja) ? true : false);
         A163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         n163articulosfechaentraalmacen = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163articulosfechaentraalmacen", context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
         n163articulosfechaentraalmacen = ((DateTime.MinValue==A163articulosfechaentraalmacen) ? true : false);
         A164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         n164articulosfechabajaalma = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164articulosfechabajaalma", context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
         n164articulosfechabajaalma = ((DateTime.MinValue==A164articulosfechabajaalma) ? true : false);
         A165articulosstatus = 0;
         n165articulosstatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165articulosstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A165articulosstatus), 18, 0)));
         n165articulosstatus = ((0==A165articulosstatus) ? true : false);
         A166articuloscontejado = 0;
         n166articuloscontejado = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166articuloscontejado", StringUtil.LTrim( StringUtil.Str( (decimal)(A166articuloscontejado), 18, 0)));
         n166articuloscontejado = ((0==A166articuloscontejado) ? true : false);
         A167articulosusuario = "";
         n167articulosusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167articulosusuario", A167articulosusuario);
         n167articulosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A167articulosusuario)) ? true : false);
         A168articulosidtrasfer = 0;
         n168articulosidtrasfer = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168articulosidtrasfer", StringUtil.LTrim( StringUtil.Str( (decimal)(A168articulosidtrasfer), 9, 0)));
         n168articulosidtrasfer = ((0==A168articulosidtrasfer) ? true : false);
         A169articulosestatusariticulo = 0;
         n169articulosestatusariticulo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169articulosestatusariticulo", StringUtil.LTrim( StringUtil.Str( (decimal)(A169articulosestatusariticulo), 18, 0)));
         n169articulosestatusariticulo = ((0==A169articulosestatusariticulo) ? true : false);
         A170articulostipobien = 0;
         n170articulostipobien = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170articulostipobien", StringUtil.LTrim( StringUtil.Str( (decimal)(A170articulostipobien), 18, 0)));
         n170articulostipobien = ((0==A170articulostipobien) ? true : false);
         A171articulosfecreg = (DateTime)(DateTime.MinValue);
         n171articulosfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171articulosfecreg", context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
         n171articulosfecreg = ((DateTime.MinValue==A171articulosfecreg) ? true : false);
         A172articulosfecultact = (DateTime)(DateTime.MinValue);
         n172articulosfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172articulosfecultact", context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
         n172articulosfecultact = ((DateTime.MinValue==A172articulosfecultact) ? true : false);
         Z154alamcenid = 0;
         Z155articulosnoetiqueta = 0;
         Z156articulosdsc = "";
         Z157articulospreciocompra = 0;
         Z158articulospreccomprareexp = 0;
         Z159articuloscantdepreacum = 0;
         Z160articulosnumserie = "";
         Z161articulosrefdocumento = "";
         Z162articulosfechacoteja = (DateTime)(DateTime.MinValue);
         Z163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         Z164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         Z165articulosstatus = 0;
         Z166articuloscontejado = 0;
         Z167articulosusuario = "";
         Z168articulosidtrasfer = 0;
         Z169articulosestatusariticulo = 0;
         Z170articulostipobien = 0;
         Z171articulosfecreg = (DateTime)(DateTime.MinValue);
         Z172articulosfecultact = (DateTime)(DateTime.MinValue);
         Z23tipobienid = 0;
         Z7entidafederativaid = 0;
         Z10origenid = 0;
         Z2proveedoresid = 0;
      }

      protected void InitAll0B11( )
      {
         A19almacenid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
         A20articulosproductoid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20articulosproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A20articulosproductoid), 9, 0)));
         A21articuloscambsid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21articuloscambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A21articuloscambsid), 9, 0)));
         InitializeNonKey0B11( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0080");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221290562647");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("articulos.js", "?20221290562647");
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
         edtalmacenid_Internalname = "ALMACENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosproductoid_Internalname = "ARTICULOSPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticuloscambsid_Internalname = "ARTICULOSCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalamcenid_Internalname = "ALAMCENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosnoetiqueta_Internalname = "ARTICULOSNOETIQUETA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edttipobienid_Internalname = "TIPOBIENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtentidafederativaid_Internalname = "ENTIDAFEDERATIVAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigenid_Internalname = "ORIGENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosdsc_Internalname = "ARTICULOSDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtproveedoresid_Internalname = "PROVEEDORESID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulospreciocompra_Internalname = "ARTICULOSPRECIOCOMPRA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulospreccomprareexp_Internalname = "ARTICULOSPRECCOMPRAREEXP";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticuloscantdepreacum_Internalname = "ARTICULOSCANTDEPREACUM";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosnumserie_Internalname = "ARTICULOSNUMSERIE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosrefdocumento_Internalname = "ARTICULOSREFDOCUMENTO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosfechacoteja_Internalname = "ARTICULOSFECHACOTEJA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosfechaentraalmacen_Internalname = "ARTICULOSFECHAENTRAALMACEN";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosfechabajaalma_Internalname = "ARTICULOSFECHABAJAALMA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosstatus_Internalname = "ARTICULOSSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticuloscontejado_Internalname = "ARTICULOSCONTEJADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosusuario_Internalname = "ARTICULOSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosidtrasfer_Internalname = "ARTICULOSIDTRASFER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosestatusariticulo_Internalname = "ARTICULOSESTATUSARITICULO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulostipobien_Internalname = "ARTICULOSTIPOBIEN";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosfecreg_Internalname = "ARTICULOSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosfecultact_Internalname = "ARTICULOSFECULTACT";
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
         imgprompt_19_Internalname = "PROMPT_19";
         imgprompt_20_Internalname = "PROMPT_20";
         imgprompt_21_Internalname = "PROMPT_21";
         imgprompt_23_Internalname = "PROMPT_23";
         imgprompt_7_Internalname = "PROMPT_7";
         imgprompt_10_Internalname = "PROMPT_10";
         imgprompt_2_Internalname = "PROMPT_2";
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
         Form.Caption = "articulos";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtarticulosfecultact_Jsonclick = "";
         edtarticulosfecultact_Enabled = 1;
         edtarticulosfecreg_Jsonclick = "";
         edtarticulosfecreg_Enabled = 1;
         edtarticulostipobien_Jsonclick = "";
         edtarticulostipobien_Enabled = 1;
         edtarticulosestatusariticulo_Jsonclick = "";
         edtarticulosestatusariticulo_Enabled = 1;
         edtarticulosidtrasfer_Jsonclick = "";
         edtarticulosidtrasfer_Enabled = 1;
         edtarticulosusuario_Jsonclick = "";
         edtarticulosusuario_Enabled = 1;
         edtarticuloscontejado_Jsonclick = "";
         edtarticuloscontejado_Enabled = 1;
         edtarticulosstatus_Jsonclick = "";
         edtarticulosstatus_Enabled = 1;
         edtarticulosfechabajaalma_Jsonclick = "";
         edtarticulosfechabajaalma_Enabled = 1;
         edtarticulosfechaentraalmacen_Jsonclick = "";
         edtarticulosfechaentraalmacen_Enabled = 1;
         edtarticulosfechacoteja_Jsonclick = "";
         edtarticulosfechacoteja_Enabled = 1;
         edtarticulosrefdocumento_Jsonclick = "";
         edtarticulosrefdocumento_Enabled = 1;
         edtarticulosnumserie_Jsonclick = "";
         edtarticulosnumserie_Enabled = 1;
         edtarticuloscantdepreacum_Jsonclick = "";
         edtarticuloscantdepreacum_Enabled = 1;
         edtarticulospreccomprareexp_Jsonclick = "";
         edtarticulospreccomprareexp_Enabled = 1;
         edtarticulospreciocompra_Jsonclick = "";
         edtarticulospreciocompra_Enabled = 1;
         imgprompt_2_Visible = 1;
         imgprompt_2_Link = "";
         edtproveedoresid_Jsonclick = "";
         edtproveedoresid_Enabled = 1;
         edtarticulosdsc_Jsonclick = "";
         edtarticulosdsc_Enabled = 1;
         imgprompt_10_Visible = 1;
         imgprompt_10_Link = "";
         edtorigenid_Jsonclick = "";
         edtorigenid_Enabled = 1;
         imgprompt_7_Visible = 1;
         imgprompt_7_Link = "";
         edtentidafederativaid_Jsonclick = "";
         edtentidafederativaid_Enabled = 1;
         imgprompt_23_Visible = 1;
         imgprompt_23_Link = "";
         edttipobienid_Jsonclick = "";
         edttipobienid_Enabled = 1;
         edtarticulosnoetiqueta_Jsonclick = "";
         edtarticulosnoetiqueta_Enabled = 1;
         edtalamcenid_Jsonclick = "";
         edtalamcenid_Enabled = 1;
         imgprompt_21_Visible = 1;
         imgprompt_21_Link = "";
         edtarticuloscambsid_Jsonclick = "";
         edtarticuloscambsid_Enabled = 1;
         imgprompt_20_Visible = 1;
         imgprompt_20_Link = "";
         edtarticulosproductoid_Jsonclick = "";
         edtarticulosproductoid_Enabled = 1;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtalmacenid_Jsonclick = "";
         edtalmacenid_Enabled = 1;
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
         /* Using cursor T000B27 */
         pr_default.execute(25, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(25);
         /* Using cursor T000B28 */
         pr_default.execute(26, new Object[] {A20articulosproductoid});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No existe 'articulosproducto'.", "ForeignKeyNotFound", 1, "ARTICULOSPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtarticulosproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(26);
         /* Using cursor T000B29 */
         pr_default.execute(27, new Object[] {A21articuloscambsid});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'articuloscambs'.", "ForeignKeyNotFound", 1, "ARTICULOSCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtarticuloscambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(27);
         GX_FocusControl = edtalamcenid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Almacenid( long GX_Parm1 )
      {
         A19almacenid = GX_Parm1;
         /* Using cursor T000B27 */
         pr_default.execute(25, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
         }
         pr_default.close(25);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Articulosproductoid( int GX_Parm1 )
      {
         A20articulosproductoid = GX_Parm1;
         /* Using cursor T000B28 */
         pr_default.execute(26, new Object[] {A20articulosproductoid});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No existe 'articulosproducto'.", "ForeignKeyNotFound", 1, "ARTICULOSPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtarticulosproductoid_Internalname;
         }
         pr_default.close(26);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Articuloscambsid( long GX_Parm1 ,
                                          int GX_Parm2 ,
                                          int GX_Parm3 ,
                                          long GX_Parm4 ,
                                          long GX_Parm5 ,
                                          String GX_Parm6 ,
                                          decimal GX_Parm7 ,
                                          decimal GX_Parm8 ,
                                          decimal GX_Parm9 ,
                                          String GX_Parm10 ,
                                          String GX_Parm11 ,
                                          DateTime GX_Parm12 ,
                                          DateTime GX_Parm13 ,
                                          DateTime GX_Parm14 ,
                                          long GX_Parm15 ,
                                          long GX_Parm16 ,
                                          String GX_Parm17 ,
                                          int GX_Parm18 ,
                                          long GX_Parm19 ,
                                          long GX_Parm20 ,
                                          DateTime GX_Parm21 ,
                                          DateTime GX_Parm22 ,
                                          int GX_Parm23 ,
                                          int GX_Parm24 ,
                                          long GX_Parm25 ,
                                          int GX_Parm26 )
      {
         A19almacenid = GX_Parm1;
         A20articulosproductoid = GX_Parm2;
         A21articuloscambsid = GX_Parm3;
         A154alamcenid = GX_Parm4;
         n154alamcenid = false;
         A155articulosnoetiqueta = GX_Parm5;
         n155articulosnoetiqueta = false;
         A156articulosdsc = GX_Parm6;
         n156articulosdsc = false;
         A157articulospreciocompra = GX_Parm7;
         n157articulospreciocompra = false;
         A158articulospreccomprareexp = GX_Parm8;
         n158articulospreccomprareexp = false;
         A159articuloscantdepreacum = GX_Parm9;
         n159articuloscantdepreacum = false;
         A160articulosnumserie = GX_Parm10;
         n160articulosnumserie = false;
         A161articulosrefdocumento = GX_Parm11;
         n161articulosrefdocumento = false;
         A162articulosfechacoteja = GX_Parm12;
         n162articulosfechacoteja = false;
         A163articulosfechaentraalmacen = GX_Parm13;
         n163articulosfechaentraalmacen = false;
         A164articulosfechabajaalma = GX_Parm14;
         n164articulosfechabajaalma = false;
         A165articulosstatus = GX_Parm15;
         n165articulosstatus = false;
         A166articuloscontejado = GX_Parm16;
         n166articuloscontejado = false;
         A167articulosusuario = GX_Parm17;
         n167articulosusuario = false;
         A168articulosidtrasfer = GX_Parm18;
         n168articulosidtrasfer = false;
         A169articulosestatusariticulo = GX_Parm19;
         n169articulosestatusariticulo = false;
         A170articulostipobien = GX_Parm20;
         n170articulostipobien = false;
         A171articulosfecreg = GX_Parm21;
         n171articulosfecreg = false;
         A172articulosfecultact = GX_Parm22;
         n172articulosfecultact = false;
         A23tipobienid = GX_Parm23;
         n23tipobienid = false;
         A7entidafederativaid = GX_Parm24;
         n7entidafederativaid = false;
         A10origenid = GX_Parm25;
         n10origenid = false;
         A2proveedoresid = GX_Parm26;
         n2proveedoresid = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         /* Using cursor T000B29 */
         pr_default.execute(27, new Object[] {A21articuloscambsid});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'articuloscambs'.", "ForeignKeyNotFound", 1, "ARTICULOSCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtarticuloscambsid_Internalname;
         }
         pr_default.close(27);
         /* Using cursor T000B30 */
         pr_default.execute(28, new Object[] {A19almacenid, A20articulosproductoid, A21articuloscambsid});
         if ( (pr_default.getStatus(28) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"almacenid"}), 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
         }
         pr_default.close(28);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A154alamcenid), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A155articulosnoetiqueta), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A23tipobienid), 9, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A7entidafederativaid), 9, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ".", "")));
         isValidOutput.Add(A156articulosdsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A157articulospreciocompra, 17, 6, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A158articulospreccomprareexp, 17, 6, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A159articuloscantdepreacum, 17, 6, ".", "")));
         isValidOutput.Add(A160articulosnumserie);
         isValidOutput.Add(A161articulosrefdocumento);
         isValidOutput.Add(context.localUtil.TToC( A162articulosfechacoteja, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A163articulosfechaentraalmacen, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A164articulosfechabajaalma, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A165articulosstatus), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A166articuloscontejado), 18, 0, ".", "")));
         isValidOutput.Add(A167articulosusuario);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A168articulosidtrasfer), 9, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A169articulosestatusariticulo), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A170articulostipobien), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.TToC( A171articulosfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A172articulosfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19almacenid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20articulosproductoid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21articuloscambsid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z154alamcenid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z155articulosnoetiqueta), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23tipobienid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7entidafederativaid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10origenid), 18, 0, ",", "")));
         isValidOutput.Add(Z156articulosdsc);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2proveedoresid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z157articulospreciocompra, 17, 6, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z158articulospreccomprareexp, 17, 6, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z159articuloscantdepreacum, 17, 6, ",", "")));
         isValidOutput.Add(Z160articulosnumserie);
         isValidOutput.Add(Z161articulosrefdocumento);
         isValidOutput.Add(context.localUtil.TToC( Z162articulosfechacoteja, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z163articulosfechaentraalmacen, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z164articulosfechabajaalma, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z165articulosstatus), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z166articuloscontejado), 18, 0, ",", "")));
         isValidOutput.Add(Z167articulosusuario);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z168articulosidtrasfer), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z169articulosestatusariticulo), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z170articulostipobien), 18, 0, ",", "")));
         isValidOutput.Add(context.localUtil.TToC( Z171articulosfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z172articulosfecultact, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Tipobienid( int GX_Parm1 )
      {
         A23tipobienid = GX_Parm1;
         n23tipobienid = false;
         /* Using cursor T000B31 */
         pr_default.execute(29, new Object[] {n23tipobienid, A23tipobienid});
         if ( (pr_default.getStatus(29) == 101) )
         {
            if ( ! ( (0==A23tipobienid) ) )
            {
               GX_msglist.addItem("No existe 'tipobien'.", "ForeignKeyNotFound", 1, "TIPOBIENID");
               AnyError = 1;
               GX_FocusControl = edttipobienid_Internalname;
            }
         }
         pr_default.close(29);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Entidafederativaid( int GX_Parm1 )
      {
         A7entidafederativaid = GX_Parm1;
         n7entidafederativaid = false;
         /* Using cursor T000B32 */
         pr_default.execute(30, new Object[] {n7entidafederativaid, A7entidafederativaid});
         if ( (pr_default.getStatus(30) == 101) )
         {
            if ( ! ( (0==A7entidafederativaid) ) )
            {
               GX_msglist.addItem("No existe 'entidadfederativa'.", "ForeignKeyNotFound", 1, "ENTIDAFEDERATIVAID");
               AnyError = 1;
               GX_FocusControl = edtentidafederativaid_Internalname;
            }
         }
         pr_default.close(30);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Origenid( long GX_Parm1 )
      {
         A10origenid = GX_Parm1;
         n10origenid = false;
         /* Using cursor T000B33 */
         pr_default.execute(31, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(31) == 101) )
         {
            if ( ! ( (0==A10origenid) ) )
            {
               GX_msglist.addItem("No existe 'origen'.", "ForeignKeyNotFound", 1, "ORIGENID");
               AnyError = 1;
               GX_FocusControl = edtorigenid_Internalname;
            }
         }
         pr_default.close(31);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Proveedoresid( int GX_Parm1 )
      {
         A2proveedoresid = GX_Parm1;
         n2proveedoresid = false;
         /* Using cursor T000B34 */
         pr_default.execute(32, new Object[] {n2proveedoresid, A2proveedoresid});
         if ( (pr_default.getStatus(32) == 101) )
         {
            if ( ! ( (0==A2proveedoresid) ) )
            {
               GX_msglist.addItem("No existe 'proveedores'.", "ForeignKeyNotFound", 1, "PROVEEDORESID");
               AnyError = 1;
               GX_FocusControl = edtproveedoresid_Internalname;
            }
         }
         pr_default.close(32);
         dynload_actions( ) ;
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
         pr_default.close(25);
         pr_default.close(29);
         pr_default.close(30);
         pr_default.close(31);
         pr_default.close(32);
         pr_default.close(26);
         pr_default.close(27);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z156articulosdsc = "";
         Z160articulosnumserie = "";
         Z161articulosrefdocumento = "";
         Z162articulosfechacoteja = (DateTime)(DateTime.MinValue);
         Z163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         Z164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         Z167articulosusuario = "";
         Z171articulosfecreg = (DateTime)(DateTime.MinValue);
         Z172articulosfecultact = (DateTime)(DateTime.MinValue);
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
         A156articulosdsc = "";
         A160articulosnumserie = "";
         A161articulosrefdocumento = "";
         A162articulosfechacoteja = (DateTime)(DateTime.MinValue);
         A163articulosfechaentraalmacen = (DateTime)(DateTime.MinValue);
         A164articulosfechabajaalma = (DateTime)(DateTime.MinValue);
         A167articulosusuario = "";
         A171articulosfecreg = (DateTime)(DateTime.MinValue);
         A172articulosfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000B11_A154alamcenid = new long[1] ;
         T000B11_n154alamcenid = new bool[] {false} ;
         T000B11_A155articulosnoetiqueta = new long[1] ;
         T000B11_n155articulosnoetiqueta = new bool[] {false} ;
         T000B11_A156articulosdsc = new String[] {""} ;
         T000B11_n156articulosdsc = new bool[] {false} ;
         T000B11_A157articulospreciocompra = new decimal[1] ;
         T000B11_n157articulospreciocompra = new bool[] {false} ;
         T000B11_A158articulospreccomprareexp = new decimal[1] ;
         T000B11_n158articulospreccomprareexp = new bool[] {false} ;
         T000B11_A159articuloscantdepreacum = new decimal[1] ;
         T000B11_n159articuloscantdepreacum = new bool[] {false} ;
         T000B11_A160articulosnumserie = new String[] {""} ;
         T000B11_n160articulosnumserie = new bool[] {false} ;
         T000B11_A161articulosrefdocumento = new String[] {""} ;
         T000B11_n161articulosrefdocumento = new bool[] {false} ;
         T000B11_A162articulosfechacoteja = new DateTime[] {DateTime.MinValue} ;
         T000B11_n162articulosfechacoteja = new bool[] {false} ;
         T000B11_A163articulosfechaentraalmacen = new DateTime[] {DateTime.MinValue} ;
         T000B11_n163articulosfechaentraalmacen = new bool[] {false} ;
         T000B11_A164articulosfechabajaalma = new DateTime[] {DateTime.MinValue} ;
         T000B11_n164articulosfechabajaalma = new bool[] {false} ;
         T000B11_A165articulosstatus = new long[1] ;
         T000B11_n165articulosstatus = new bool[] {false} ;
         T000B11_A166articuloscontejado = new long[1] ;
         T000B11_n166articuloscontejado = new bool[] {false} ;
         T000B11_A167articulosusuario = new String[] {""} ;
         T000B11_n167articulosusuario = new bool[] {false} ;
         T000B11_A168articulosidtrasfer = new int[1] ;
         T000B11_n168articulosidtrasfer = new bool[] {false} ;
         T000B11_A169articulosestatusariticulo = new long[1] ;
         T000B11_n169articulosestatusariticulo = new bool[] {false} ;
         T000B11_A170articulostipobien = new long[1] ;
         T000B11_n170articulostipobien = new bool[] {false} ;
         T000B11_A171articulosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000B11_n171articulosfecreg = new bool[] {false} ;
         T000B11_A172articulosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000B11_n172articulosfecultact = new bool[] {false} ;
         T000B11_A19almacenid = new long[1] ;
         T000B11_A23tipobienid = new int[1] ;
         T000B11_n23tipobienid = new bool[] {false} ;
         T000B11_A7entidafederativaid = new int[1] ;
         T000B11_n7entidafederativaid = new bool[] {false} ;
         T000B11_A10origenid = new long[1] ;
         T000B11_n10origenid = new bool[] {false} ;
         T000B11_A2proveedoresid = new int[1] ;
         T000B11_n2proveedoresid = new bool[] {false} ;
         T000B11_A20articulosproductoid = new int[1] ;
         T000B11_A21articuloscambsid = new int[1] ;
         T000B4_A19almacenid = new long[1] ;
         T000B9_A20articulosproductoid = new int[1] ;
         T000B10_A21articuloscambsid = new int[1] ;
         T000B12_A19almacenid = new long[1] ;
         T000B5_A23tipobienid = new int[1] ;
         T000B5_n23tipobienid = new bool[] {false} ;
         T000B6_A7entidafederativaid = new int[1] ;
         T000B6_n7entidafederativaid = new bool[] {false} ;
         T000B7_A10origenid = new long[1] ;
         T000B7_n10origenid = new bool[] {false} ;
         T000B8_A2proveedoresid = new int[1] ;
         T000B8_n2proveedoresid = new bool[] {false} ;
         T000B13_A19almacenid = new long[1] ;
         T000B14_A20articulosproductoid = new int[1] ;
         T000B15_A21articuloscambsid = new int[1] ;
         T000B16_A23tipobienid = new int[1] ;
         T000B16_n23tipobienid = new bool[] {false} ;
         T000B17_A7entidafederativaid = new int[1] ;
         T000B17_n7entidafederativaid = new bool[] {false} ;
         T000B18_A10origenid = new long[1] ;
         T000B18_n10origenid = new bool[] {false} ;
         T000B19_A2proveedoresid = new int[1] ;
         T000B19_n2proveedoresid = new bool[] {false} ;
         T000B20_A19almacenid = new long[1] ;
         T000B20_A20articulosproductoid = new int[1] ;
         T000B20_A21articuloscambsid = new int[1] ;
         T000B3_A154alamcenid = new long[1] ;
         T000B3_n154alamcenid = new bool[] {false} ;
         T000B3_A155articulosnoetiqueta = new long[1] ;
         T000B3_n155articulosnoetiqueta = new bool[] {false} ;
         T000B3_A156articulosdsc = new String[] {""} ;
         T000B3_n156articulosdsc = new bool[] {false} ;
         T000B3_A157articulospreciocompra = new decimal[1] ;
         T000B3_n157articulospreciocompra = new bool[] {false} ;
         T000B3_A158articulospreccomprareexp = new decimal[1] ;
         T000B3_n158articulospreccomprareexp = new bool[] {false} ;
         T000B3_A159articuloscantdepreacum = new decimal[1] ;
         T000B3_n159articuloscantdepreacum = new bool[] {false} ;
         T000B3_A160articulosnumserie = new String[] {""} ;
         T000B3_n160articulosnumserie = new bool[] {false} ;
         T000B3_A161articulosrefdocumento = new String[] {""} ;
         T000B3_n161articulosrefdocumento = new bool[] {false} ;
         T000B3_A162articulosfechacoteja = new DateTime[] {DateTime.MinValue} ;
         T000B3_n162articulosfechacoteja = new bool[] {false} ;
         T000B3_A163articulosfechaentraalmacen = new DateTime[] {DateTime.MinValue} ;
         T000B3_n163articulosfechaentraalmacen = new bool[] {false} ;
         T000B3_A164articulosfechabajaalma = new DateTime[] {DateTime.MinValue} ;
         T000B3_n164articulosfechabajaalma = new bool[] {false} ;
         T000B3_A165articulosstatus = new long[1] ;
         T000B3_n165articulosstatus = new bool[] {false} ;
         T000B3_A166articuloscontejado = new long[1] ;
         T000B3_n166articuloscontejado = new bool[] {false} ;
         T000B3_A167articulosusuario = new String[] {""} ;
         T000B3_n167articulosusuario = new bool[] {false} ;
         T000B3_A168articulosidtrasfer = new int[1] ;
         T000B3_n168articulosidtrasfer = new bool[] {false} ;
         T000B3_A169articulosestatusariticulo = new long[1] ;
         T000B3_n169articulosestatusariticulo = new bool[] {false} ;
         T000B3_A170articulostipobien = new long[1] ;
         T000B3_n170articulostipobien = new bool[] {false} ;
         T000B3_A171articulosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000B3_n171articulosfecreg = new bool[] {false} ;
         T000B3_A172articulosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000B3_n172articulosfecultact = new bool[] {false} ;
         T000B3_A19almacenid = new long[1] ;
         T000B3_A23tipobienid = new int[1] ;
         T000B3_n23tipobienid = new bool[] {false} ;
         T000B3_A7entidafederativaid = new int[1] ;
         T000B3_n7entidafederativaid = new bool[] {false} ;
         T000B3_A10origenid = new long[1] ;
         T000B3_n10origenid = new bool[] {false} ;
         T000B3_A2proveedoresid = new int[1] ;
         T000B3_n2proveedoresid = new bool[] {false} ;
         T000B3_A20articulosproductoid = new int[1] ;
         T000B3_A21articuloscambsid = new int[1] ;
         sMode11 = "";
         T000B21_A19almacenid = new long[1] ;
         T000B21_A20articulosproductoid = new int[1] ;
         T000B21_A21articuloscambsid = new int[1] ;
         T000B22_A19almacenid = new long[1] ;
         T000B22_A20articulosproductoid = new int[1] ;
         T000B22_A21articuloscambsid = new int[1] ;
         T000B2_A154alamcenid = new long[1] ;
         T000B2_n154alamcenid = new bool[] {false} ;
         T000B2_A155articulosnoetiqueta = new long[1] ;
         T000B2_n155articulosnoetiqueta = new bool[] {false} ;
         T000B2_A156articulosdsc = new String[] {""} ;
         T000B2_n156articulosdsc = new bool[] {false} ;
         T000B2_A157articulospreciocompra = new decimal[1] ;
         T000B2_n157articulospreciocompra = new bool[] {false} ;
         T000B2_A158articulospreccomprareexp = new decimal[1] ;
         T000B2_n158articulospreccomprareexp = new bool[] {false} ;
         T000B2_A159articuloscantdepreacum = new decimal[1] ;
         T000B2_n159articuloscantdepreacum = new bool[] {false} ;
         T000B2_A160articulosnumserie = new String[] {""} ;
         T000B2_n160articulosnumserie = new bool[] {false} ;
         T000B2_A161articulosrefdocumento = new String[] {""} ;
         T000B2_n161articulosrefdocumento = new bool[] {false} ;
         T000B2_A162articulosfechacoteja = new DateTime[] {DateTime.MinValue} ;
         T000B2_n162articulosfechacoteja = new bool[] {false} ;
         T000B2_A163articulosfechaentraalmacen = new DateTime[] {DateTime.MinValue} ;
         T000B2_n163articulosfechaentraalmacen = new bool[] {false} ;
         T000B2_A164articulosfechabajaalma = new DateTime[] {DateTime.MinValue} ;
         T000B2_n164articulosfechabajaalma = new bool[] {false} ;
         T000B2_A165articulosstatus = new long[1] ;
         T000B2_n165articulosstatus = new bool[] {false} ;
         T000B2_A166articuloscontejado = new long[1] ;
         T000B2_n166articuloscontejado = new bool[] {false} ;
         T000B2_A167articulosusuario = new String[] {""} ;
         T000B2_n167articulosusuario = new bool[] {false} ;
         T000B2_A168articulosidtrasfer = new int[1] ;
         T000B2_n168articulosidtrasfer = new bool[] {false} ;
         T000B2_A169articulosestatusariticulo = new long[1] ;
         T000B2_n169articulosestatusariticulo = new bool[] {false} ;
         T000B2_A170articulostipobien = new long[1] ;
         T000B2_n170articulostipobien = new bool[] {false} ;
         T000B2_A171articulosfecreg = new DateTime[] {DateTime.MinValue} ;
         T000B2_n171articulosfecreg = new bool[] {false} ;
         T000B2_A172articulosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000B2_n172articulosfecultact = new bool[] {false} ;
         T000B2_A19almacenid = new long[1] ;
         T000B2_A23tipobienid = new int[1] ;
         T000B2_n23tipobienid = new bool[] {false} ;
         T000B2_A7entidafederativaid = new int[1] ;
         T000B2_n7entidafederativaid = new bool[] {false} ;
         T000B2_A10origenid = new long[1] ;
         T000B2_n10origenid = new bool[] {false} ;
         T000B2_A2proveedoresid = new int[1] ;
         T000B2_n2proveedoresid = new bool[] {false} ;
         T000B2_A20articulosproductoid = new int[1] ;
         T000B2_A21articuloscambsid = new int[1] ;
         T000B26_A19almacenid = new long[1] ;
         T000B26_A20articulosproductoid = new int[1] ;
         T000B26_A21articuloscambsid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000B27_A19almacenid = new long[1] ;
         T000B28_A20articulosproductoid = new int[1] ;
         T000B29_A21articuloscambsid = new int[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000B30_A19almacenid = new long[1] ;
         T000B31_A23tipobienid = new int[1] ;
         T000B31_n23tipobienid = new bool[] {false} ;
         T000B32_A7entidafederativaid = new int[1] ;
         T000B32_n7entidafederativaid = new bool[] {false} ;
         T000B33_A10origenid = new long[1] ;
         T000B33_n10origenid = new bool[] {false} ;
         T000B34_A2proveedoresid = new int[1] ;
         T000B34_n2proveedoresid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.articulos__default(),
            new Object[][] {
                new Object[] {
               T000B2_A154alamcenid, T000B2_n154alamcenid, T000B2_A155articulosnoetiqueta, T000B2_n155articulosnoetiqueta, T000B2_A156articulosdsc, T000B2_n156articulosdsc, T000B2_A157articulospreciocompra, T000B2_n157articulospreciocompra, T000B2_A158articulospreccomprareexp, T000B2_n158articulospreccomprareexp,
               T000B2_A159articuloscantdepreacum, T000B2_n159articuloscantdepreacum, T000B2_A160articulosnumserie, T000B2_n160articulosnumserie, T000B2_A161articulosrefdocumento, T000B2_n161articulosrefdocumento, T000B2_A162articulosfechacoteja, T000B2_n162articulosfechacoteja, T000B2_A163articulosfechaentraalmacen, T000B2_n163articulosfechaentraalmacen,
               T000B2_A164articulosfechabajaalma, T000B2_n164articulosfechabajaalma, T000B2_A165articulosstatus, T000B2_n165articulosstatus, T000B2_A166articuloscontejado, T000B2_n166articuloscontejado, T000B2_A167articulosusuario, T000B2_n167articulosusuario, T000B2_A168articulosidtrasfer, T000B2_n168articulosidtrasfer,
               T000B2_A169articulosestatusariticulo, T000B2_n169articulosestatusariticulo, T000B2_A170articulostipobien, T000B2_n170articulostipobien, T000B2_A171articulosfecreg, T000B2_n171articulosfecreg, T000B2_A172articulosfecultact, T000B2_n172articulosfecultact, T000B2_A19almacenid, T000B2_A23tipobienid,
               T000B2_n23tipobienid, T000B2_A7entidafederativaid, T000B2_n7entidafederativaid, T000B2_A10origenid, T000B2_n10origenid, T000B2_A2proveedoresid, T000B2_n2proveedoresid, T000B2_A20articulosproductoid, T000B2_A21articuloscambsid
               }
               , new Object[] {
               T000B3_A154alamcenid, T000B3_n154alamcenid, T000B3_A155articulosnoetiqueta, T000B3_n155articulosnoetiqueta, T000B3_A156articulosdsc, T000B3_n156articulosdsc, T000B3_A157articulospreciocompra, T000B3_n157articulospreciocompra, T000B3_A158articulospreccomprareexp, T000B3_n158articulospreccomprareexp,
               T000B3_A159articuloscantdepreacum, T000B3_n159articuloscantdepreacum, T000B3_A160articulosnumserie, T000B3_n160articulosnumserie, T000B3_A161articulosrefdocumento, T000B3_n161articulosrefdocumento, T000B3_A162articulosfechacoteja, T000B3_n162articulosfechacoteja, T000B3_A163articulosfechaentraalmacen, T000B3_n163articulosfechaentraalmacen,
               T000B3_A164articulosfechabajaalma, T000B3_n164articulosfechabajaalma, T000B3_A165articulosstatus, T000B3_n165articulosstatus, T000B3_A166articuloscontejado, T000B3_n166articuloscontejado, T000B3_A167articulosusuario, T000B3_n167articulosusuario, T000B3_A168articulosidtrasfer, T000B3_n168articulosidtrasfer,
               T000B3_A169articulosestatusariticulo, T000B3_n169articulosestatusariticulo, T000B3_A170articulostipobien, T000B3_n170articulostipobien, T000B3_A171articulosfecreg, T000B3_n171articulosfecreg, T000B3_A172articulosfecultact, T000B3_n172articulosfecultact, T000B3_A19almacenid, T000B3_A23tipobienid,
               T000B3_n23tipobienid, T000B3_A7entidafederativaid, T000B3_n7entidafederativaid, T000B3_A10origenid, T000B3_n10origenid, T000B3_A2proveedoresid, T000B3_n2proveedoresid, T000B3_A20articulosproductoid, T000B3_A21articuloscambsid
               }
               , new Object[] {
               T000B4_A19almacenid
               }
               , new Object[] {
               T000B5_A23tipobienid
               }
               , new Object[] {
               T000B6_A7entidafederativaid
               }
               , new Object[] {
               T000B7_A10origenid
               }
               , new Object[] {
               T000B8_A2proveedoresid
               }
               , new Object[] {
               T000B9_A20articulosproductoid
               }
               , new Object[] {
               T000B10_A21articuloscambsid
               }
               , new Object[] {
               T000B11_A154alamcenid, T000B11_n154alamcenid, T000B11_A155articulosnoetiqueta, T000B11_n155articulosnoetiqueta, T000B11_A156articulosdsc, T000B11_n156articulosdsc, T000B11_A157articulospreciocompra, T000B11_n157articulospreciocompra, T000B11_A158articulospreccomprareexp, T000B11_n158articulospreccomprareexp,
               T000B11_A159articuloscantdepreacum, T000B11_n159articuloscantdepreacum, T000B11_A160articulosnumserie, T000B11_n160articulosnumserie, T000B11_A161articulosrefdocumento, T000B11_n161articulosrefdocumento, T000B11_A162articulosfechacoteja, T000B11_n162articulosfechacoteja, T000B11_A163articulosfechaentraalmacen, T000B11_n163articulosfechaentraalmacen,
               T000B11_A164articulosfechabajaalma, T000B11_n164articulosfechabajaalma, T000B11_A165articulosstatus, T000B11_n165articulosstatus, T000B11_A166articuloscontejado, T000B11_n166articuloscontejado, T000B11_A167articulosusuario, T000B11_n167articulosusuario, T000B11_A168articulosidtrasfer, T000B11_n168articulosidtrasfer,
               T000B11_A169articulosestatusariticulo, T000B11_n169articulosestatusariticulo, T000B11_A170articulostipobien, T000B11_n170articulostipobien, T000B11_A171articulosfecreg, T000B11_n171articulosfecreg, T000B11_A172articulosfecultact, T000B11_n172articulosfecultact, T000B11_A19almacenid, T000B11_A23tipobienid,
               T000B11_n23tipobienid, T000B11_A7entidafederativaid, T000B11_n7entidafederativaid, T000B11_A10origenid, T000B11_n10origenid, T000B11_A2proveedoresid, T000B11_n2proveedoresid, T000B11_A20articulosproductoid, T000B11_A21articuloscambsid
               }
               , new Object[] {
               T000B12_A19almacenid
               }
               , new Object[] {
               T000B13_A19almacenid
               }
               , new Object[] {
               T000B14_A20articulosproductoid
               }
               , new Object[] {
               T000B15_A21articuloscambsid
               }
               , new Object[] {
               T000B16_A23tipobienid
               }
               , new Object[] {
               T000B17_A7entidafederativaid
               }
               , new Object[] {
               T000B18_A10origenid
               }
               , new Object[] {
               T000B19_A2proveedoresid
               }
               , new Object[] {
               T000B20_A19almacenid, T000B20_A20articulosproductoid, T000B20_A21articuloscambsid
               }
               , new Object[] {
               T000B21_A19almacenid, T000B21_A20articulosproductoid, T000B21_A21articuloscambsid
               }
               , new Object[] {
               T000B22_A19almacenid, T000B22_A20articulosproductoid, T000B22_A21articuloscambsid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B26_A19almacenid, T000B26_A20articulosproductoid, T000B26_A21articuloscambsid
               }
               , new Object[] {
               T000B27_A19almacenid
               }
               , new Object[] {
               T000B28_A20articulosproductoid
               }
               , new Object[] {
               T000B29_A21articuloscambsid
               }
               , new Object[] {
               T000B30_A19almacenid
               }
               , new Object[] {
               T000B31_A23tipobienid
               }
               , new Object[] {
               T000B32_A7entidafederativaid
               }
               , new Object[] {
               T000B33_A10origenid
               }
               , new Object[] {
               T000B34_A2proveedoresid
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
      private short RcdFound11 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z20articulosproductoid ;
      private int Z21articuloscambsid ;
      private int Z168articulosidtrasfer ;
      private int Z23tipobienid ;
      private int Z7entidafederativaid ;
      private int Z2proveedoresid ;
      private int A20articulosproductoid ;
      private int A21articuloscambsid ;
      private int A23tipobienid ;
      private int A7entidafederativaid ;
      private int A2proveedoresid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtalmacenid_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtarticulosproductoid_Enabled ;
      private int imgprompt_20_Visible ;
      private int edtarticuloscambsid_Enabled ;
      private int imgprompt_21_Visible ;
      private int edtalamcenid_Enabled ;
      private int edtarticulosnoetiqueta_Enabled ;
      private int edttipobienid_Enabled ;
      private int imgprompt_23_Visible ;
      private int edtentidafederativaid_Enabled ;
      private int imgprompt_7_Visible ;
      private int edtorigenid_Enabled ;
      private int imgprompt_10_Visible ;
      private int edtarticulosdsc_Enabled ;
      private int edtproveedoresid_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtarticulospreciocompra_Enabled ;
      private int edtarticulospreccomprareexp_Enabled ;
      private int edtarticuloscantdepreacum_Enabled ;
      private int edtarticulosnumserie_Enabled ;
      private int edtarticulosrefdocumento_Enabled ;
      private int edtarticulosfechacoteja_Enabled ;
      private int edtarticulosfechaentraalmacen_Enabled ;
      private int edtarticulosfechabajaalma_Enabled ;
      private int edtarticulosstatus_Enabled ;
      private int edtarticuloscontejado_Enabled ;
      private int edtarticulosusuario_Enabled ;
      private int A168articulosidtrasfer ;
      private int edtarticulosidtrasfer_Enabled ;
      private int edtarticulosestatusariticulo_Enabled ;
      private int edtarticulostipobien_Enabled ;
      private int edtarticulosfecreg_Enabled ;
      private int edtarticulosfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z19almacenid ;
      private long Z154alamcenid ;
      private long Z155articulosnoetiqueta ;
      private long Z165articulosstatus ;
      private long Z166articuloscontejado ;
      private long Z169articulosestatusariticulo ;
      private long Z170articulostipobien ;
      private long Z10origenid ;
      private long A19almacenid ;
      private long A10origenid ;
      private long A154alamcenid ;
      private long A155articulosnoetiqueta ;
      private long A165articulosstatus ;
      private long A166articuloscontejado ;
      private long A169articulosestatusariticulo ;
      private long A170articulostipobien ;
      private decimal Z157articulospreciocompra ;
      private decimal Z158articulospreccomprareexp ;
      private decimal Z159articuloscantdepreacum ;
      private decimal A157articulospreciocompra ;
      private decimal A158articulospreccomprareexp ;
      private decimal A159articuloscantdepreacum ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtalmacenid_Internalname ;
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
      private String edtalmacenid_Jsonclick ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtarticulosproductoid_Internalname ;
      private String edtarticulosproductoid_Jsonclick ;
      private String imgprompt_20_Internalname ;
      private String imgprompt_20_Link ;
      private String edtarticuloscambsid_Internalname ;
      private String edtarticuloscambsid_Jsonclick ;
      private String imgprompt_21_Internalname ;
      private String imgprompt_21_Link ;
      private String edtalamcenid_Internalname ;
      private String edtalamcenid_Jsonclick ;
      private String edtarticulosnoetiqueta_Internalname ;
      private String edtarticulosnoetiqueta_Jsonclick ;
      private String edttipobienid_Internalname ;
      private String edttipobienid_Jsonclick ;
      private String imgprompt_23_Internalname ;
      private String imgprompt_23_Link ;
      private String edtentidafederativaid_Internalname ;
      private String edtentidafederativaid_Jsonclick ;
      private String imgprompt_7_Internalname ;
      private String imgprompt_7_Link ;
      private String edtorigenid_Internalname ;
      private String edtorigenid_Jsonclick ;
      private String imgprompt_10_Internalname ;
      private String imgprompt_10_Link ;
      private String edtarticulosdsc_Internalname ;
      private String edtarticulosdsc_Jsonclick ;
      private String edtproveedoresid_Internalname ;
      private String edtproveedoresid_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtarticulospreciocompra_Internalname ;
      private String edtarticulospreciocompra_Jsonclick ;
      private String edtarticulospreccomprareexp_Internalname ;
      private String edtarticulospreccomprareexp_Jsonclick ;
      private String edtarticuloscantdepreacum_Internalname ;
      private String edtarticuloscantdepreacum_Jsonclick ;
      private String edtarticulosnumserie_Internalname ;
      private String edtarticulosnumserie_Jsonclick ;
      private String edtarticulosrefdocumento_Internalname ;
      private String edtarticulosrefdocumento_Jsonclick ;
      private String edtarticulosfechacoteja_Internalname ;
      private String edtarticulosfechacoteja_Jsonclick ;
      private String edtarticulosfechaentraalmacen_Internalname ;
      private String edtarticulosfechaentraalmacen_Jsonclick ;
      private String edtarticulosfechabajaalma_Internalname ;
      private String edtarticulosfechabajaalma_Jsonclick ;
      private String edtarticulosstatus_Internalname ;
      private String edtarticulosstatus_Jsonclick ;
      private String edtarticuloscontejado_Internalname ;
      private String edtarticuloscontejado_Jsonclick ;
      private String edtarticulosusuario_Internalname ;
      private String edtarticulosusuario_Jsonclick ;
      private String edtarticulosidtrasfer_Internalname ;
      private String edtarticulosidtrasfer_Jsonclick ;
      private String edtarticulosestatusariticulo_Internalname ;
      private String edtarticulosestatusariticulo_Jsonclick ;
      private String edtarticulostipobien_Internalname ;
      private String edtarticulostipobien_Jsonclick ;
      private String edtarticulosfecreg_Internalname ;
      private String edtarticulosfecreg_Jsonclick ;
      private String edtarticulosfecultact_Internalname ;
      private String edtarticulosfecultact_Jsonclick ;
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
      private String sMode11 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z162articulosfechacoteja ;
      private DateTime Z163articulosfechaentraalmacen ;
      private DateTime Z164articulosfechabajaalma ;
      private DateTime Z171articulosfecreg ;
      private DateTime Z172articulosfecultact ;
      private DateTime A162articulosfechacoteja ;
      private DateTime A163articulosfechaentraalmacen ;
      private DateTime A164articulosfechabajaalma ;
      private DateTime A171articulosfecreg ;
      private DateTime A172articulosfecultact ;
      private bool entryPointCalled ;
      private bool n23tipobienid ;
      private bool n7entidafederativaid ;
      private bool n10origenid ;
      private bool n2proveedoresid ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n154alamcenid ;
      private bool n155articulosnoetiqueta ;
      private bool n156articulosdsc ;
      private bool n157articulospreciocompra ;
      private bool n158articulospreccomprareexp ;
      private bool n159articuloscantdepreacum ;
      private bool n160articulosnumserie ;
      private bool n161articulosrefdocumento ;
      private bool n162articulosfechacoteja ;
      private bool n163articulosfechaentraalmacen ;
      private bool n164articulosfechabajaalma ;
      private bool n165articulosstatus ;
      private bool n166articuloscontejado ;
      private bool n167articulosusuario ;
      private bool n168articulosidtrasfer ;
      private bool n169articulosestatusariticulo ;
      private bool n170articulostipobien ;
      private bool n171articulosfecreg ;
      private bool n172articulosfecultact ;
      private bool Gx_longc ;
      private String Z156articulosdsc ;
      private String Z160articulosnumserie ;
      private String Z161articulosrefdocumento ;
      private String Z167articulosusuario ;
      private String A156articulosdsc ;
      private String A160articulosnumserie ;
      private String A161articulosrefdocumento ;
      private String A167articulosusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000B11_A154alamcenid ;
      private bool[] T000B11_n154alamcenid ;
      private long[] T000B11_A155articulosnoetiqueta ;
      private bool[] T000B11_n155articulosnoetiqueta ;
      private String[] T000B11_A156articulosdsc ;
      private bool[] T000B11_n156articulosdsc ;
      private decimal[] T000B11_A157articulospreciocompra ;
      private bool[] T000B11_n157articulospreciocompra ;
      private decimal[] T000B11_A158articulospreccomprareexp ;
      private bool[] T000B11_n158articulospreccomprareexp ;
      private decimal[] T000B11_A159articuloscantdepreacum ;
      private bool[] T000B11_n159articuloscantdepreacum ;
      private String[] T000B11_A160articulosnumserie ;
      private bool[] T000B11_n160articulosnumserie ;
      private String[] T000B11_A161articulosrefdocumento ;
      private bool[] T000B11_n161articulosrefdocumento ;
      private DateTime[] T000B11_A162articulosfechacoteja ;
      private bool[] T000B11_n162articulosfechacoteja ;
      private DateTime[] T000B11_A163articulosfechaentraalmacen ;
      private bool[] T000B11_n163articulosfechaentraalmacen ;
      private DateTime[] T000B11_A164articulosfechabajaalma ;
      private bool[] T000B11_n164articulosfechabajaalma ;
      private long[] T000B11_A165articulosstatus ;
      private bool[] T000B11_n165articulosstatus ;
      private long[] T000B11_A166articuloscontejado ;
      private bool[] T000B11_n166articuloscontejado ;
      private String[] T000B11_A167articulosusuario ;
      private bool[] T000B11_n167articulosusuario ;
      private int[] T000B11_A168articulosidtrasfer ;
      private bool[] T000B11_n168articulosidtrasfer ;
      private long[] T000B11_A169articulosestatusariticulo ;
      private bool[] T000B11_n169articulosestatusariticulo ;
      private long[] T000B11_A170articulostipobien ;
      private bool[] T000B11_n170articulostipobien ;
      private DateTime[] T000B11_A171articulosfecreg ;
      private bool[] T000B11_n171articulosfecreg ;
      private DateTime[] T000B11_A172articulosfecultact ;
      private bool[] T000B11_n172articulosfecultact ;
      private long[] T000B11_A19almacenid ;
      private int[] T000B11_A23tipobienid ;
      private bool[] T000B11_n23tipobienid ;
      private int[] T000B11_A7entidafederativaid ;
      private bool[] T000B11_n7entidafederativaid ;
      private long[] T000B11_A10origenid ;
      private bool[] T000B11_n10origenid ;
      private int[] T000B11_A2proveedoresid ;
      private bool[] T000B11_n2proveedoresid ;
      private int[] T000B11_A20articulosproductoid ;
      private int[] T000B11_A21articuloscambsid ;
      private long[] T000B4_A19almacenid ;
      private int[] T000B9_A20articulosproductoid ;
      private int[] T000B10_A21articuloscambsid ;
      private long[] T000B12_A19almacenid ;
      private int[] T000B5_A23tipobienid ;
      private bool[] T000B5_n23tipobienid ;
      private int[] T000B6_A7entidafederativaid ;
      private bool[] T000B6_n7entidafederativaid ;
      private long[] T000B7_A10origenid ;
      private bool[] T000B7_n10origenid ;
      private int[] T000B8_A2proveedoresid ;
      private bool[] T000B8_n2proveedoresid ;
      private long[] T000B13_A19almacenid ;
      private int[] T000B14_A20articulosproductoid ;
      private int[] T000B15_A21articuloscambsid ;
      private int[] T000B16_A23tipobienid ;
      private bool[] T000B16_n23tipobienid ;
      private int[] T000B17_A7entidafederativaid ;
      private bool[] T000B17_n7entidafederativaid ;
      private long[] T000B18_A10origenid ;
      private bool[] T000B18_n10origenid ;
      private int[] T000B19_A2proveedoresid ;
      private bool[] T000B19_n2proveedoresid ;
      private long[] T000B20_A19almacenid ;
      private int[] T000B20_A20articulosproductoid ;
      private int[] T000B20_A21articuloscambsid ;
      private long[] T000B3_A154alamcenid ;
      private bool[] T000B3_n154alamcenid ;
      private long[] T000B3_A155articulosnoetiqueta ;
      private bool[] T000B3_n155articulosnoetiqueta ;
      private String[] T000B3_A156articulosdsc ;
      private bool[] T000B3_n156articulosdsc ;
      private decimal[] T000B3_A157articulospreciocompra ;
      private bool[] T000B3_n157articulospreciocompra ;
      private decimal[] T000B3_A158articulospreccomprareexp ;
      private bool[] T000B3_n158articulospreccomprareexp ;
      private decimal[] T000B3_A159articuloscantdepreacum ;
      private bool[] T000B3_n159articuloscantdepreacum ;
      private String[] T000B3_A160articulosnumserie ;
      private bool[] T000B3_n160articulosnumserie ;
      private String[] T000B3_A161articulosrefdocumento ;
      private bool[] T000B3_n161articulosrefdocumento ;
      private DateTime[] T000B3_A162articulosfechacoteja ;
      private bool[] T000B3_n162articulosfechacoteja ;
      private DateTime[] T000B3_A163articulosfechaentraalmacen ;
      private bool[] T000B3_n163articulosfechaentraalmacen ;
      private DateTime[] T000B3_A164articulosfechabajaalma ;
      private bool[] T000B3_n164articulosfechabajaalma ;
      private long[] T000B3_A165articulosstatus ;
      private bool[] T000B3_n165articulosstatus ;
      private long[] T000B3_A166articuloscontejado ;
      private bool[] T000B3_n166articuloscontejado ;
      private String[] T000B3_A167articulosusuario ;
      private bool[] T000B3_n167articulosusuario ;
      private int[] T000B3_A168articulosidtrasfer ;
      private bool[] T000B3_n168articulosidtrasfer ;
      private long[] T000B3_A169articulosestatusariticulo ;
      private bool[] T000B3_n169articulosestatusariticulo ;
      private long[] T000B3_A170articulostipobien ;
      private bool[] T000B3_n170articulostipobien ;
      private DateTime[] T000B3_A171articulosfecreg ;
      private bool[] T000B3_n171articulosfecreg ;
      private DateTime[] T000B3_A172articulosfecultact ;
      private bool[] T000B3_n172articulosfecultact ;
      private long[] T000B3_A19almacenid ;
      private int[] T000B3_A23tipobienid ;
      private bool[] T000B3_n23tipobienid ;
      private int[] T000B3_A7entidafederativaid ;
      private bool[] T000B3_n7entidafederativaid ;
      private long[] T000B3_A10origenid ;
      private bool[] T000B3_n10origenid ;
      private int[] T000B3_A2proveedoresid ;
      private bool[] T000B3_n2proveedoresid ;
      private int[] T000B3_A20articulosproductoid ;
      private int[] T000B3_A21articuloscambsid ;
      private long[] T000B21_A19almacenid ;
      private int[] T000B21_A20articulosproductoid ;
      private int[] T000B21_A21articuloscambsid ;
      private long[] T000B22_A19almacenid ;
      private int[] T000B22_A20articulosproductoid ;
      private int[] T000B22_A21articuloscambsid ;
      private long[] T000B2_A154alamcenid ;
      private bool[] T000B2_n154alamcenid ;
      private long[] T000B2_A155articulosnoetiqueta ;
      private bool[] T000B2_n155articulosnoetiqueta ;
      private String[] T000B2_A156articulosdsc ;
      private bool[] T000B2_n156articulosdsc ;
      private decimal[] T000B2_A157articulospreciocompra ;
      private bool[] T000B2_n157articulospreciocompra ;
      private decimal[] T000B2_A158articulospreccomprareexp ;
      private bool[] T000B2_n158articulospreccomprareexp ;
      private decimal[] T000B2_A159articuloscantdepreacum ;
      private bool[] T000B2_n159articuloscantdepreacum ;
      private String[] T000B2_A160articulosnumserie ;
      private bool[] T000B2_n160articulosnumserie ;
      private String[] T000B2_A161articulosrefdocumento ;
      private bool[] T000B2_n161articulosrefdocumento ;
      private DateTime[] T000B2_A162articulosfechacoteja ;
      private bool[] T000B2_n162articulosfechacoteja ;
      private DateTime[] T000B2_A163articulosfechaentraalmacen ;
      private bool[] T000B2_n163articulosfechaentraalmacen ;
      private DateTime[] T000B2_A164articulosfechabajaalma ;
      private bool[] T000B2_n164articulosfechabajaalma ;
      private long[] T000B2_A165articulosstatus ;
      private bool[] T000B2_n165articulosstatus ;
      private long[] T000B2_A166articuloscontejado ;
      private bool[] T000B2_n166articuloscontejado ;
      private String[] T000B2_A167articulosusuario ;
      private bool[] T000B2_n167articulosusuario ;
      private int[] T000B2_A168articulosidtrasfer ;
      private bool[] T000B2_n168articulosidtrasfer ;
      private long[] T000B2_A169articulosestatusariticulo ;
      private bool[] T000B2_n169articulosestatusariticulo ;
      private long[] T000B2_A170articulostipobien ;
      private bool[] T000B2_n170articulostipobien ;
      private DateTime[] T000B2_A171articulosfecreg ;
      private bool[] T000B2_n171articulosfecreg ;
      private DateTime[] T000B2_A172articulosfecultact ;
      private bool[] T000B2_n172articulosfecultact ;
      private long[] T000B2_A19almacenid ;
      private int[] T000B2_A23tipobienid ;
      private bool[] T000B2_n23tipobienid ;
      private int[] T000B2_A7entidafederativaid ;
      private bool[] T000B2_n7entidafederativaid ;
      private long[] T000B2_A10origenid ;
      private bool[] T000B2_n10origenid ;
      private int[] T000B2_A2proveedoresid ;
      private bool[] T000B2_n2proveedoresid ;
      private int[] T000B2_A20articulosproductoid ;
      private int[] T000B2_A21articuloscambsid ;
      private long[] T000B26_A19almacenid ;
      private int[] T000B26_A20articulosproductoid ;
      private int[] T000B26_A21articuloscambsid ;
      private long[] T000B27_A19almacenid ;
      private int[] T000B28_A20articulosproductoid ;
      private int[] T000B29_A21articuloscambsid ;
      private long[] T000B30_A19almacenid ;
      private int[] T000B31_A23tipobienid ;
      private bool[] T000B31_n23tipobienid ;
      private int[] T000B32_A7entidafederativaid ;
      private bool[] T000B32_n7entidafederativaid ;
      private long[] T000B33_A10origenid ;
      private bool[] T000B33_n10origenid ;
      private int[] T000B34_A2proveedoresid ;
      private bool[] T000B34_n2proveedoresid ;
      private GXWebForm Form ;
   }

   public class articulos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000B11 ;
          prmT000B11 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B4 ;
          prmT000B4 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B9 ;
          prmT000B9 = new Object[] {
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B10 ;
          prmT000B10 = new Object[] {
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B12 ;
          prmT000B12 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B5 ;
          prmT000B5 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B6 ;
          prmT000B6 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B7 ;
          prmT000B7 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B8 ;
          prmT000B8 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B13 ;
          prmT000B13 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B14 ;
          prmT000B14 = new Object[] {
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B15 ;
          prmT000B15 = new Object[] {
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B16 ;
          prmT000B16 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B17 ;
          prmT000B17 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B18 ;
          prmT000B18 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B19 ;
          prmT000B19 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B20 ;
          prmT000B20 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B3 ;
          prmT000B3 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B21 ;
          prmT000B21 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B22 ;
          prmT000B22 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B2 ;
          prmT000B2 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B23 ;
          prmT000B23 = new Object[] {
          new Object[] {"alamcenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosnoetiqueta",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"articulospreciocompra",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articulospreccomprareexp",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articuloscantdepreacum",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articulosnumserie",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosrefdocumento",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosfechacoteja",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfechaentraalmacen",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfechabajaalma",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articuloscontejado",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosusuario",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosidtrasfer",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosestatusariticulo",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulostipobien",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"origenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B24 ;
          prmT000B24 = new Object[] {
          new Object[] {"alamcenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosnoetiqueta",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosdsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"articulospreciocompra",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articulospreccomprareexp",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articuloscantdepreacum",NpgsqlDbType.Numeric,17,6} ,
          new Object[] {"articulosnumserie",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosrefdocumento",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosfechacoteja",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfechaentraalmacen",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfechabajaalma",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articuloscontejado",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosusuario",NpgsqlDbType.Varchar,20,0} ,
          new Object[] {"articulosidtrasfer",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosestatusariticulo",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulostipobien",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"origenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B25 ;
          prmT000B25 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B26 ;
          prmT000B26 = new Object[] {
          } ;
          Object[] prmT000B27 ;
          prmT000B27 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B28 ;
          prmT000B28 = new Object[] {
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B29 ;
          prmT000B29 = new Object[] {
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B30 ;
          prmT000B30 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articuloscambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B31 ;
          prmT000B31 = new Object[] {
          new Object[] {"tipobienid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B32 ;
          prmT000B32 = new Object[] {
          new Object[] {"entidafederativaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000B33 ;
          prmT000B33 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000B34 ;
          prmT000B34 = new Object[] {
          new Object[] {"proveedoresid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000B2", "SELECT alamcenid, articulosnoetiqueta, articulosdsc, articulospreciocompra, articulospreccomprareexp, articuloscantdepreacum, articulosnumserie, articulosrefdocumento, articulosfechacoteja, articulosfechaentraalmacen, articulosfechabajaalma, articulosstatus, articuloscontejado, articulosusuario, articulosidtrasfer, articulosestatusariticulo, articulostipobien, articulosfecreg, articulosfecultact, articulosid, tipodocid, entidadid, origenid, proveedorid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE articulosid = :almacenid AND productoid = :articulosproductoid AND cambsid = :articuloscambsid  FOR UPDATE OF articulos NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
             ,new CursorDef("T000B3", "SELECT alamcenid, articulosnoetiqueta, articulosdsc, articulospreciocompra, articulospreccomprareexp, articuloscantdepreacum, articulosnumserie, articulosrefdocumento, articulosfechacoteja, articulosfechaentraalmacen, articulosfechabajaalma, articulosstatus, articuloscontejado, articulosusuario, articulosidtrasfer, articulosestatusariticulo, articulostipobien, articulosfecreg, articulosfecultact, articulosid, tipodocid, entidadid, origenid, proveedorid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE articulosid = :almacenid AND productoid = :articulosproductoid AND cambsid = :articuloscambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
             ,new CursorDef("T000B4", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,1,0,true,false )
             ,new CursorDef("T000B5", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
             ,new CursorDef("T000B6", "SELECT entidafederativaid FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,false )
             ,new CursorDef("T000B7", "SELECT origenid FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,false )
             ,new CursorDef("T000B8", "SELECT proveedoresid FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,false )
             ,new CursorDef("T000B9", "SELECT modelosid AS articulosproductoid FROM public.modelos WHERE modelosid = :articulosproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B9,1,0,true,false )
             ,new CursorDef("T000B10", "SELECT cambsid AS articuloscambsid FROM public.cambs WHERE cambsid = :articuloscambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B10,1,0,true,false )
             ,new CursorDef("T000B11", "SELECT TM1.alamcenid, TM1.articulosnoetiqueta, TM1.articulosdsc, TM1.articulospreciocompra, TM1.articulospreccomprareexp, TM1.articuloscantdepreacum, TM1.articulosnumserie, TM1.articulosrefdocumento, TM1.articulosfechacoteja, TM1.articulosfechaentraalmacen, TM1.articulosfechabajaalma, TM1.articulosstatus, TM1.articuloscontejado, TM1.articulosusuario, TM1.articulosidtrasfer, TM1.articulosestatusariticulo, TM1.articulostipobien, TM1.articulosfecreg, TM1.articulosfecultact, TM1.articulosid, TM1.tipodocid, TM1.entidadid, TM1.origenid, TM1.proveedorid, TM1.productoid AS articulosproductoid, TM1.cambsid AS articuloscambsid FROM public.articulos TM1 WHERE TM1.articulosid = :almacenid and TM1.productoid = :articulosproductoid and TM1.cambsid = :articuloscambsid ORDER BY TM1.articulosid, TM1.productoid, TM1.cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B11,100,0,true,false )
             ,new CursorDef("T000B12", "SELECT articulosid FROM public.articulos WHERE (articulosid = :almacenid) AND (Not ( articulosid = :almacenid and productoid = :articulosproductoid and cambsid = :articuloscambsid)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B12,1,0,true,false )
             ,new CursorDef("T000B13", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B13,1,0,true,false )
             ,new CursorDef("T000B14", "SELECT modelosid AS articulosproductoid FROM public.modelos WHERE modelosid = :articulosproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B14,1,0,true,false )
             ,new CursorDef("T000B15", "SELECT cambsid AS articuloscambsid FROM public.cambs WHERE cambsid = :articuloscambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B15,1,0,true,false )
             ,new CursorDef("T000B16", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B16,1,0,true,false )
             ,new CursorDef("T000B17", "SELECT entidafederativaid FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B17,1,0,true,false )
             ,new CursorDef("T000B18", "SELECT origenid FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B18,1,0,true,false )
             ,new CursorDef("T000B19", "SELECT proveedoresid FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B19,1,0,true,false )
             ,new CursorDef("T000B20", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE articulosid = :almacenid AND productoid = :articulosproductoid AND cambsid = :articuloscambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B20,1,0,true,false )
             ,new CursorDef("T000B21", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE ( articulosid > :almacenid or articulosid = :almacenid and productoid > :articulosproductoid or productoid = :articulosproductoid and articulosid = :almacenid and cambsid > :articuloscambsid) ORDER BY articulosid, productoid, cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B21,1,0,true,true )
             ,new CursorDef("T000B22", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE ( articulosid < :almacenid or articulosid = :almacenid and productoid < :articulosproductoid or productoid = :articulosproductoid and articulosid = :almacenid and cambsid < :articuloscambsid) ORDER BY articulosid DESC, productoid DESC, cambsid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B22,1,0,true,true )
             ,new CursorDef("T000B23", "SAVEPOINT gxupdate;INSERT INTO public.articulos(alamcenid, articulosnoetiqueta, articulosdsc, articulospreciocompra, articulospreccomprareexp, articuloscantdepreacum, articulosnumserie, articulosrefdocumento, articulosfechacoteja, articulosfechaentraalmacen, articulosfechabajaalma, articulosstatus, articuloscontejado, articulosusuario, articulosidtrasfer, articulosestatusariticulo, articulostipobien, articulosfecreg, articulosfecultact, articulosid, tipodocid, entidadid, origenid, proveedorid, productoid, cambsid) VALUES(:alamcenid, :articulosnoetiqueta, :articulosdsc, :articulospreciocompra, :articulospreccomprareexp, :articuloscantdepreacum, :articulosnumserie, :articulosrefdocumento, :articulosfechacoteja, :articulosfechaentraalmacen, :articulosfechabajaalma, :articulosstatus, :articuloscontejado, :articulosusuario, :articulosidtrasfer, :articulosestatusariticulo, :articulostipobien, :articulosfecreg, :articulosfecultact, :almacenid, :tipobienid, :entidafederativaid, :origenid, :proveedoresid, :articulosproductoid, :articuloscambsid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000B23)
             ,new CursorDef("T000B24", "SAVEPOINT gxupdate;UPDATE public.articulos SET alamcenid=:alamcenid, articulosnoetiqueta=:articulosnoetiqueta, articulosdsc=:articulosdsc, articulospreciocompra=:articulospreciocompra, articulospreccomprareexp=:articulospreccomprareexp, articuloscantdepreacum=:articuloscantdepreacum, articulosnumserie=:articulosnumserie, articulosrefdocumento=:articulosrefdocumento, articulosfechacoteja=:articulosfechacoteja, articulosfechaentraalmacen=:articulosfechaentraalmacen, articulosfechabajaalma=:articulosfechabajaalma, articulosstatus=:articulosstatus, articuloscontejado=:articuloscontejado, articulosusuario=:articulosusuario, articulosidtrasfer=:articulosidtrasfer, articulosestatusariticulo=:articulosestatusariticulo, articulostipobien=:articulostipobien, articulosfecreg=:articulosfecreg, articulosfecultact=:articulosfecultact, tipodocid=:tipobienid, entidadid=:entidafederativaid, origenid=:origenid, proveedorid=:proveedoresid  WHERE articulosid = :almacenid AND productoid = :articulosproductoid AND cambsid = :articuloscambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000B24)
             ,new CursorDef("T000B25", "SAVEPOINT gxupdate;DELETE FROM public.articulos  WHERE articulosid = :almacenid AND productoid = :articulosproductoid AND cambsid = :articuloscambsid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000B25)
             ,new CursorDef("T000B26", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos ORDER BY articulosid, productoid, cambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B26,100,0,true,false )
             ,new CursorDef("T000B27", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B27,1,0,true,false )
             ,new CursorDef("T000B28", "SELECT modelosid AS articulosproductoid FROM public.modelos WHERE modelosid = :articulosproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B28,1,0,true,false )
             ,new CursorDef("T000B29", "SELECT cambsid AS articuloscambsid FROM public.cambs WHERE cambsid = :articuloscambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B29,1,0,true,false )
             ,new CursorDef("T000B30", "SELECT articulosid FROM public.articulos WHERE (articulosid = :almacenid) AND (Not ( articulosid = :almacenid and productoid = :articulosproductoid and cambsid = :articuloscambsid)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B30,1,0,true,false )
             ,new CursorDef("T000B31", "SELECT tipobienid FROM public.tipobien WHERE tipobienid = :tipobienid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B31,1,0,true,false )
             ,new CursorDef("T000B32", "SELECT entidafederativaid FROM public.entidadfederativa WHERE entidafederativaid = :entidafederativaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B32,1,0,true,false )
             ,new CursorDef("T000B33", "SELECT origenid FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B33,1,0,true,false )
             ,new CursorDef("T000B34", "SELECT proveedoresid FROM public.proveedores WHERE proveedoresid = :proveedoresid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B34,1,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[20])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((long[]) buf[24])[0] = rslt.getLong(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((String[]) buf[26])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((int[]) buf[28])[0] = rslt.getInt(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[34])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((DateTime[]) buf[36])[0] = rslt.getGXDateTime(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((long[]) buf[38])[0] = rslt.getLong(20) ;
                ((int[]) buf[39])[0] = rslt.getInt(21) ;
                ((bool[]) buf[40])[0] = rslt.wasNull(21);
                ((int[]) buf[41])[0] = rslt.getInt(22) ;
                ((bool[]) buf[42])[0] = rslt.wasNull(22);
                ((long[]) buf[43])[0] = rslt.getLong(23) ;
                ((bool[]) buf[44])[0] = rslt.wasNull(23);
                ((int[]) buf[45])[0] = rslt.getInt(24) ;
                ((bool[]) buf[46])[0] = rslt.wasNull(24);
                ((int[]) buf[47])[0] = rslt.getInt(25) ;
                ((int[]) buf[48])[0] = rslt.getInt(26) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[20])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((long[]) buf[24])[0] = rslt.getLong(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((String[]) buf[26])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((int[]) buf[28])[0] = rslt.getInt(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[34])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((DateTime[]) buf[36])[0] = rslt.getGXDateTime(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((long[]) buf[38])[0] = rslt.getLong(20) ;
                ((int[]) buf[39])[0] = rslt.getInt(21) ;
                ((bool[]) buf[40])[0] = rslt.wasNull(21);
                ((int[]) buf[41])[0] = rslt.getInt(22) ;
                ((bool[]) buf[42])[0] = rslt.wasNull(22);
                ((long[]) buf[43])[0] = rslt.getLong(23) ;
                ((bool[]) buf[44])[0] = rslt.wasNull(23);
                ((int[]) buf[45])[0] = rslt.getInt(24) ;
                ((bool[]) buf[46])[0] = rslt.wasNull(24);
                ((int[]) buf[47])[0] = rslt.getInt(25) ;
                ((int[]) buf[48])[0] = rslt.getInt(26) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 9 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[20])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((long[]) buf[24])[0] = rslt.getLong(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((String[]) buf[26])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((int[]) buf[28])[0] = rslt.getInt(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[34])[0] = rslt.getGXDateTime(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((DateTime[]) buf[36])[0] = rslt.getGXDateTime(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((long[]) buf[38])[0] = rslt.getLong(20) ;
                ((int[]) buf[39])[0] = rslt.getInt(21) ;
                ((bool[]) buf[40])[0] = rslt.wasNull(21);
                ((int[]) buf[41])[0] = rslt.getInt(22) ;
                ((bool[]) buf[42])[0] = rslt.wasNull(22);
                ((long[]) buf[43])[0] = rslt.getLong(23) ;
                ((bool[]) buf[44])[0] = rslt.wasNull(23);
                ((int[]) buf[45])[0] = rslt.getInt(24) ;
                ((bool[]) buf[46])[0] = rslt.wasNull(24);
                ((int[]) buf[47])[0] = rslt.getInt(25) ;
                ((int[]) buf[48])[0] = rslt.getInt(26) ;
                return;
             case 10 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 11 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 16 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 18 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 19 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 20 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 24 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 25 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 26 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 27 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 28 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 29 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 31 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 32 :
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
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
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
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 15 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 18 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 20 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 21 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                   stmt.SetParameter(4, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[11]);
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
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(11, (DateTime)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(12, (long)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(13, (long)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 15 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(15, (int)parms[29]);
                }
                if ( (bool)parms[30] )
                {
                   stmt.setNull( 16 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(16, (long)parms[31]);
                }
                if ( (bool)parms[32] )
                {
                   stmt.setNull( 17 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(17, (long)parms[33]);
                }
                if ( (bool)parms[34] )
                {
                   stmt.setNull( 18 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(18, (DateTime)parms[35]);
                }
                if ( (bool)parms[36] )
                {
                   stmt.setNull( 19 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(19, (DateTime)parms[37]);
                }
                stmt.SetParameter(20, (long)parms[38]);
                if ( (bool)parms[39] )
                {
                   stmt.setNull( 21 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(21, (int)parms[40]);
                }
                if ( (bool)parms[41] )
                {
                   stmt.setNull( 22 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(22, (int)parms[42]);
                }
                if ( (bool)parms[43] )
                {
                   stmt.setNull( 23 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(23, (long)parms[44]);
                }
                if ( (bool)parms[45] )
                {
                   stmt.setNull( 24 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(24, (int)parms[46]);
                }
                stmt.SetParameter(25, (int)parms[47]);
                stmt.SetParameter(26, (int)parms[48]);
                return;
             case 22 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                   stmt.SetParameter(4, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[11]);
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
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(11, (DateTime)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(12, (long)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(13, (long)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 15 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(15, (int)parms[29]);
                }
                if ( (bool)parms[30] )
                {
                   stmt.setNull( 16 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(16, (long)parms[31]);
                }
                if ( (bool)parms[32] )
                {
                   stmt.setNull( 17 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(17, (long)parms[33]);
                }
                if ( (bool)parms[34] )
                {
                   stmt.setNull( 18 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(18, (DateTime)parms[35]);
                }
                if ( (bool)parms[36] )
                {
                   stmt.setNull( 19 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(19, (DateTime)parms[37]);
                }
                if ( (bool)parms[38] )
                {
                   stmt.setNull( 20 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(20, (int)parms[39]);
                }
                if ( (bool)parms[40] )
                {
                   stmt.setNull( 21 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(21, (int)parms[41]);
                }
                if ( (bool)parms[42] )
                {
                   stmt.setNull( 22 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(22, (long)parms[43]);
                }
                if ( (bool)parms[44] )
                {
                   stmt.setNull( 23 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(23, (int)parms[45]);
                }
                stmt.SetParameter(24, (long)parms[46]);
                stmt.SetParameter(25, (int)parms[47]);
                stmt.SetParameter(26, (int)parms[48]);
                return;
             case 23 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 25 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 28 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 29 :
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
       setparameters30( cursor, stmt, parms) ;
    }

    public void setparameters30( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 30 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                return;
             case 31 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 32 :
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
