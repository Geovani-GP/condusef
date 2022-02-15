/*
               File: etiquetas
        Description: etiquetas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:0.39
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
   public class etiquetas : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A17etiquetasproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A17etiquetasproductoid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A18etiquetascambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A18etiquetascambsid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A19almacenid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A19almacenid) ;
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
            Form.Meta.addItem("description", "etiquetas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtetiquetasproductoid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public etiquetas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public etiquetas( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "etiquetas", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_etiquetas.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ETIQUETASPRODUCTOID"+"'), id:'"+"ETIQUETASPRODUCTOID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ETIQUETASCAMBSID"+"'), id:'"+"ETIQUETASCAMBSID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ALMACENID"+"'), id:'"+"ALMACENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetasproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17etiquetasproductoid), 9, 0, ",", "")), ((edtetiquetasproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A17etiquetasproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A17etiquetasproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasproductoid_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_17_Link, "", "", context.GetTheme( ), imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetascambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetascambsid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18etiquetascambsid), 9, 0, ",", "")), ((edtetiquetascambsid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A18etiquetascambsid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A18etiquetascambsid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetascambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetascambsid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_18_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_18_Link, "", "", context.GetTheme( ), imgprompt_18_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenid_Internalname, "almacenid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 9, 0, ",", "")), ((edtalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasnumero_Internalname, "etiquetasnumero", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetasnumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32etiquetasnumero), 18, 0, ",", "")), ((edtetiquetasnumero_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32etiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A32etiquetasnumero), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasnumero_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasnumero_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetastatus_Internalname, "etiquetastatus", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetastatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33etiquetastatus), 18, 0, ",", "")), ((edtetiquetastatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A33etiquetastatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A33etiquetastatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetastatus_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetastatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetafecharealizada_Internalname, "etiquetafecharealizada", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtetiquetafecharealizada_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtetiquetafecharealizada_Internalname, context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A34etiquetafecharealizada, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetafecharealizada_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetafecharealizada_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            GxWebStd.gx_bitmap( context, edtetiquetafecharealizada_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtetiquetafecharealizada_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasreimpresion_Internalname, "etiquetasreimpresión", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetasreimpresion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35etiquetasreimpresion), 18, 0, ",", "")), ((edtetiquetasreimpresion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A35etiquetasreimpresion), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A35etiquetasreimpresion), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasreimpresion_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasreimpresion_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasusuario_Internalname, "etiquetasusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtetiquetasusuario_Internalname, A36etiquetasusuario, StringUtil.RTrim( context.localUtil.Format( A36etiquetasusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasfecreg_Internalname, "etiquetasfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtetiquetasfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtetiquetasfecreg_Internalname, context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A37etiquetasfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            GxWebStd.gx_bitmap( context, edtetiquetasfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtetiquetasfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            GxWebStd.gx_label_element( context, edtetiquetasfecultact_Internalname, "etiquetasfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtetiquetasfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtetiquetasfecultact_Internalname, context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A38etiquetasfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtetiquetasfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtetiquetasfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_etiquetas.htm");
            GxWebStd.gx_bitmap( context, edtetiquetasfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtetiquetasfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_etiquetas.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_etiquetas.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtetiquetasproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtetiquetasproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ETIQUETASPRODUCTOID");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A17etiquetasproductoid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
               }
               else
               {
                  A17etiquetasproductoid = (int)(context.localUtil.CToN( cgiGet( edtetiquetasproductoid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtetiquetascambsid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtetiquetascambsid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ETIQUETASCAMBSID");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetascambsid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A18etiquetascambsid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
               }
               else
               {
                  A18etiquetascambsid = (int)(context.localUtil.CToN( cgiGet( edtetiquetascambsid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ALMACENID");
                  AnyError = 1;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19almacenid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
               }
               else
               {
                  A19almacenid = (int)(context.localUtil.CToN( cgiGet( edtalmacenid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtetiquetasnumero_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtetiquetasnumero_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ETIQUETASNUMERO");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasnumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A32etiquetasnumero = 0;
                  n32etiquetasnumero = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32etiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A32etiquetasnumero), 18, 0)));
               }
               else
               {
                  A32etiquetasnumero = (long)(context.localUtil.CToN( cgiGet( edtetiquetasnumero_Internalname), ",", "."));
                  n32etiquetasnumero = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32etiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A32etiquetasnumero), 18, 0)));
               }
               n32etiquetasnumero = ((0==A32etiquetasnumero) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtetiquetastatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtetiquetastatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ETIQUETASTATUS");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetastatus_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A33etiquetastatus = 0;
                  n33etiquetastatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33etiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A33etiquetastatus), 18, 0)));
               }
               else
               {
                  A33etiquetastatus = (long)(context.localUtil.CToN( cgiGet( edtetiquetastatus_Internalname), ",", "."));
                  n33etiquetastatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33etiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A33etiquetastatus), 18, 0)));
               }
               n33etiquetastatus = ((0==A33etiquetastatus) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtetiquetafecharealizada_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"etiquetafecharealizada"}), 1, "ETIQUETAFECHAREALIZADA");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetafecharealizada_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
                  n34etiquetafecharealizada = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34etiquetafecharealizada", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A34etiquetafecharealizada = context.localUtil.CToT( cgiGet( edtetiquetafecharealizada_Internalname));
                  n34etiquetafecharealizada = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34etiquetafecharealizada", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
               }
               n34etiquetafecharealizada = ((DateTime.MinValue==A34etiquetafecharealizada) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtetiquetasreimpresion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtetiquetasreimpresion_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ETIQUETASREIMPRESION");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasreimpresion_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A35etiquetasreimpresion = 0;
                  n35etiquetasreimpresion = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35etiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(A35etiquetasreimpresion), 18, 0)));
               }
               else
               {
                  A35etiquetasreimpresion = (long)(context.localUtil.CToN( cgiGet( edtetiquetasreimpresion_Internalname), ",", "."));
                  n35etiquetasreimpresion = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35etiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(A35etiquetasreimpresion), 18, 0)));
               }
               n35etiquetasreimpresion = ((0==A35etiquetasreimpresion) ? true : false);
               A36etiquetasusuario = cgiGet( edtetiquetasusuario_Internalname);
               n36etiquetasusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36etiquetasusuario", A36etiquetasusuario);
               n36etiquetasusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A36etiquetasusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtetiquetasfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"etiquetasfecreg"}), 1, "ETIQUETASFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A37etiquetasfecreg = (DateTime)(DateTime.MinValue);
                  n37etiquetasfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37etiquetasfecreg", context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A37etiquetasfecreg = context.localUtil.CToT( cgiGet( edtetiquetasfecreg_Internalname));
                  n37etiquetasfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37etiquetasfecreg", context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n37etiquetasfecreg = ((DateTime.MinValue==A37etiquetasfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtetiquetasfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"etiquetasfecultact"}), 1, "ETIQUETASFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A38etiquetasfecultact = (DateTime)(DateTime.MinValue);
                  n38etiquetasfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38etiquetasfecultact", context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A38etiquetasfecultact = context.localUtil.CToT( cgiGet( edtetiquetasfecultact_Internalname));
                  n38etiquetasfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38etiquetasfecultact", context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n38etiquetasfecultact = ((DateTime.MinValue==A38etiquetasfecultact) ? true : false);
               /* Read saved values. */
               Z17etiquetasproductoid = (int)(context.localUtil.CToN( cgiGet( "Z17etiquetasproductoid"), ",", "."));
               Z18etiquetascambsid = (int)(context.localUtil.CToN( cgiGet( "Z18etiquetascambsid"), ",", "."));
               Z19almacenid = (int)(context.localUtil.CToN( cgiGet( "Z19almacenid"), ",", "."));
               Z32etiquetasnumero = (long)(context.localUtil.CToN( cgiGet( "Z32etiquetasnumero"), ",", "."));
               n32etiquetasnumero = ((0==A32etiquetasnumero) ? true : false);
               Z33etiquetastatus = (long)(context.localUtil.CToN( cgiGet( "Z33etiquetastatus"), ",", "."));
               n33etiquetastatus = ((0==A33etiquetastatus) ? true : false);
               Z34etiquetafecharealizada = context.localUtil.CToT( cgiGet( "Z34etiquetafecharealizada"), 0);
               n34etiquetafecharealizada = ((DateTime.MinValue==A34etiquetafecharealizada) ? true : false);
               Z35etiquetasreimpresion = (long)(context.localUtil.CToN( cgiGet( "Z35etiquetasreimpresion"), ",", "."));
               n35etiquetasreimpresion = ((0==A35etiquetasreimpresion) ? true : false);
               Z36etiquetasusuario = cgiGet( "Z36etiquetasusuario");
               n36etiquetasusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A36etiquetasusuario)) ? true : false);
               Z37etiquetasfecreg = context.localUtil.CToT( cgiGet( "Z37etiquetasfecreg"), 0);
               n37etiquetasfecreg = ((DateTime.MinValue==A37etiquetasfecreg) ? true : false);
               Z38etiquetasfecultact = context.localUtil.CToT( cgiGet( "Z38etiquetasfecultact"), 0);
               n38etiquetasfecultact = ((DateTime.MinValue==A38etiquetasfecultact) ? true : false);
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
                  A17etiquetasproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
                  A18etiquetascambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
                  A19almacenid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
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
               InitAll0C12( ) ;
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
         DisableAttributes0C12( ) ;
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

      protected void ResetCaption0C0( )
      {
      }

      protected void ZM0C12( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z32etiquetasnumero = T000C3_A32etiquetasnumero[0];
               Z33etiquetastatus = T000C3_A33etiquetastatus[0];
               Z34etiquetafecharealizada = T000C3_A34etiquetafecharealizada[0];
               Z35etiquetasreimpresion = T000C3_A35etiquetasreimpresion[0];
               Z36etiquetasusuario = T000C3_A36etiquetasusuario[0];
               Z37etiquetasfecreg = T000C3_A37etiquetasfecreg[0];
               Z38etiquetasfecultact = T000C3_A38etiquetasfecultact[0];
            }
            else
            {
               Z32etiquetasnumero = A32etiquetasnumero;
               Z33etiquetastatus = A33etiquetastatus;
               Z34etiquetafecharealizada = A34etiquetafecharealizada;
               Z35etiquetasreimpresion = A35etiquetasreimpresion;
               Z36etiquetasusuario = A36etiquetasusuario;
               Z37etiquetasfecreg = A37etiquetasfecreg;
               Z38etiquetasfecultact = A38etiquetasfecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z32etiquetasnumero = A32etiquetasnumero;
            Z33etiquetastatus = A33etiquetastatus;
            Z34etiquetafecharealizada = A34etiquetafecharealizada;
            Z35etiquetasreimpresion = A35etiquetasreimpresion;
            Z36etiquetasusuario = A36etiquetasusuario;
            Z37etiquetasfecreg = A37etiquetasfecreg;
            Z38etiquetasfecultact = A38etiquetasfecultact;
            Z19almacenid = A19almacenid;
            Z17etiquetasproductoid = A17etiquetasproductoid;
            Z18etiquetascambsid = A18etiquetascambsid;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ETIQUETASPRODUCTOID"+"'), id:'"+"ETIQUETASPRODUCTOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_18_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ETIQUETASCAMBSID"+"'), id:'"+"ETIQUETASCAMBSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ALMACENID"+"'), id:'"+"ALMACENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
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

      protected void Load0C12( )
      {
         /* Using cursor T000C7 */
         pr_default.execute(5, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound12 = 1;
            A32etiquetasnumero = T000C7_A32etiquetasnumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32etiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A32etiquetasnumero), 18, 0)));
            n32etiquetasnumero = T000C7_n32etiquetasnumero[0];
            A33etiquetastatus = T000C7_A33etiquetastatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33etiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A33etiquetastatus), 18, 0)));
            n33etiquetastatus = T000C7_n33etiquetastatus[0];
            A34etiquetafecharealizada = T000C7_A34etiquetafecharealizada[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34etiquetafecharealizada", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
            n34etiquetafecharealizada = T000C7_n34etiquetafecharealizada[0];
            A35etiquetasreimpresion = T000C7_A35etiquetasreimpresion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35etiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(A35etiquetasreimpresion), 18, 0)));
            n35etiquetasreimpresion = T000C7_n35etiquetasreimpresion[0];
            A36etiquetasusuario = T000C7_A36etiquetasusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36etiquetasusuario", A36etiquetasusuario);
            n36etiquetasusuario = T000C7_n36etiquetasusuario[0];
            A37etiquetasfecreg = T000C7_A37etiquetasfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37etiquetasfecreg", context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
            n37etiquetasfecreg = T000C7_n37etiquetasfecreg[0];
            A38etiquetasfecultact = T000C7_A38etiquetasfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38etiquetasfecultact", context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
            n38etiquetasfecultact = T000C7_n38etiquetasfecultact[0];
            ZM0C12( -1) ;
         }
         pr_default.close(5);
         OnLoadActions0C12( ) ;
      }

      protected void OnLoadActions0C12( )
      {
      }

      protected void CheckExtendedTable0C12( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000C5 */
         pr_default.execute(3, new Object[] {A17etiquetasproductoid});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetasproducto'.", "ForeignKeyNotFound", 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
         /* Using cursor T000C6 */
         pr_default.execute(4, new Object[] {A18etiquetascambsid});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetascambs'.", "ForeignKeyNotFound", 1, "ETIQUETASCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtetiquetascambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         /* Using cursor T000C4 */
         pr_default.execute(2, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0C12( )
      {
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( int A17etiquetasproductoid )
      {
         /* Using cursor T000C8 */
         pr_default.execute(6, new Object[] {A17etiquetasproductoid});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetasproducto'.", "ForeignKeyNotFound", 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void gxLoad_4( int A18etiquetascambsid )
      {
         /* Using cursor T000C9 */
         pr_default.execute(7, new Object[] {A18etiquetascambsid});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetascambs'.", "ForeignKeyNotFound", 1, "ETIQUETASCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtetiquetascambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_2( int A19almacenid )
      {
         /* Using cursor T000C10 */
         pr_default.execute(8, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(8) == 101) )
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
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey0C12( )
      {
         /* Using cursor T000C11 */
         pr_default.execute(9, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000C3 */
         pr_default.execute(1, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C12( 1) ;
            RcdFound12 = 1;
            A32etiquetasnumero = T000C3_A32etiquetasnumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32etiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A32etiquetasnumero), 18, 0)));
            n32etiquetasnumero = T000C3_n32etiquetasnumero[0];
            A33etiquetastatus = T000C3_A33etiquetastatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33etiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A33etiquetastatus), 18, 0)));
            n33etiquetastatus = T000C3_n33etiquetastatus[0];
            A34etiquetafecharealizada = T000C3_A34etiquetafecharealizada[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34etiquetafecharealizada", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
            n34etiquetafecharealizada = T000C3_n34etiquetafecharealizada[0];
            A35etiquetasreimpresion = T000C3_A35etiquetasreimpresion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35etiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(A35etiquetasreimpresion), 18, 0)));
            n35etiquetasreimpresion = T000C3_n35etiquetasreimpresion[0];
            A36etiquetasusuario = T000C3_A36etiquetasusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36etiquetasusuario", A36etiquetasusuario);
            n36etiquetasusuario = T000C3_n36etiquetasusuario[0];
            A37etiquetasfecreg = T000C3_A37etiquetasfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37etiquetasfecreg", context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
            n37etiquetasfecreg = T000C3_n37etiquetasfecreg[0];
            A38etiquetasfecultact = T000C3_A38etiquetasfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38etiquetasfecultact", context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
            n38etiquetasfecultact = T000C3_n38etiquetasfecultact[0];
            A19almacenid = T000C3_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
            A17etiquetasproductoid = T000C3_A17etiquetasproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
            A18etiquetascambsid = T000C3_A18etiquetascambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
            Z17etiquetasproductoid = A17etiquetasproductoid;
            Z18etiquetascambsid = A18etiquetascambsid;
            Z19almacenid = A19almacenid;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0C12( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0C12( ) ;
            }
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0C12( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C12( ) ;
         if ( RcdFound12 == 0 )
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
         RcdFound12 = 0;
         /* Using cursor T000C12 */
         pr_default.execute(10, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000C12_A17etiquetasproductoid[0] < A17etiquetasproductoid ) || ( T000C12_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C12_A18etiquetascambsid[0] < A18etiquetascambsid ) || ( T000C12_A18etiquetascambsid[0] == A18etiquetascambsid ) && ( T000C12_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C12_A19almacenid[0] < A19almacenid ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000C12_A17etiquetasproductoid[0] > A17etiquetasproductoid ) || ( T000C12_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C12_A18etiquetascambsid[0] > A18etiquetascambsid ) || ( T000C12_A18etiquetascambsid[0] == A18etiquetascambsid ) && ( T000C12_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C12_A19almacenid[0] > A19almacenid ) ) )
            {
               A17etiquetasproductoid = T000C12_A17etiquetasproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
               A18etiquetascambsid = T000C12_A18etiquetascambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
               A19almacenid = T000C12_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0;
         /* Using cursor T000C13 */
         pr_default.execute(11, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000C13_A17etiquetasproductoid[0] > A17etiquetasproductoid ) || ( T000C13_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C13_A18etiquetascambsid[0] > A18etiquetascambsid ) || ( T000C13_A18etiquetascambsid[0] == A18etiquetascambsid ) && ( T000C13_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C13_A19almacenid[0] > A19almacenid ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000C13_A17etiquetasproductoid[0] < A17etiquetasproductoid ) || ( T000C13_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C13_A18etiquetascambsid[0] < A18etiquetascambsid ) || ( T000C13_A18etiquetascambsid[0] == A18etiquetascambsid ) && ( T000C13_A17etiquetasproductoid[0] == A17etiquetasproductoid ) && ( T000C13_A19almacenid[0] < A19almacenid ) ) )
            {
               A17etiquetasproductoid = T000C13_A17etiquetasproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
               A18etiquetascambsid = T000C13_A18etiquetascambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
               A19almacenid = T000C13_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0C12( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0C12( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( ( A17etiquetasproductoid != Z17etiquetasproductoid ) || ( A18etiquetascambsid != Z18etiquetascambsid ) || ( A19almacenid != Z19almacenid ) )
               {
                  A17etiquetasproductoid = Z17etiquetasproductoid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
                  A18etiquetascambsid = Z18etiquetascambsid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
                  A19almacenid = Z19almacenid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ETIQUETASPRODUCTOID");
                  AnyError = 1;
                  GX_FocusControl = edtetiquetasproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtetiquetasproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0C12( ) ;
                  GX_FocusControl = edtetiquetasproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A17etiquetasproductoid != Z17etiquetasproductoid ) || ( A18etiquetascambsid != Z18etiquetascambsid ) || ( A19almacenid != Z19almacenid ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtetiquetasproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0C12( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ETIQUETASPRODUCTOID");
                     AnyError = 1;
                     GX_FocusControl = edtetiquetasproductoid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtetiquetasproductoid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0C12( ) ;
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
         if ( ( A17etiquetasproductoid != Z17etiquetasproductoid ) || ( A18etiquetascambsid != Z18etiquetascambsid ) || ( A19almacenid != Z19almacenid ) )
         {
            A17etiquetasproductoid = Z17etiquetasproductoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
            A18etiquetascambsid = Z18etiquetascambsid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
            A19almacenid = Z19almacenid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtetiquetasnumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0C12( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtetiquetasnumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0C12( ) ;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtetiquetasnumero_Internalname;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtetiquetasnumero_Internalname;
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
         ScanStart0C12( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound12 != 0 )
            {
               ScanNext0C12( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtetiquetasnumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0C12( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0C12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C2 */
            pr_default.execute(0, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ETIQUETAS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z32etiquetasnumero != T000C2_A32etiquetasnumero[0] ) || ( Z33etiquetastatus != T000C2_A33etiquetastatus[0] ) || ( Z34etiquetafecharealizada != T000C2_A34etiquetafecharealizada[0] ) || ( Z35etiquetasreimpresion != T000C2_A35etiquetasreimpresion[0] ) || ( StringUtil.StrCmp(Z36etiquetasusuario, T000C2_A36etiquetasusuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z37etiquetasfecreg != T000C2_A37etiquetasfecreg[0] ) || ( Z38etiquetasfecultact != T000C2_A38etiquetasfecultact[0] ) )
            {
               if ( Z32etiquetasnumero != T000C2_A32etiquetasnumero[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetasnumero");
                  GXUtil.WriteLogRaw("Old: ",Z32etiquetasnumero);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A32etiquetasnumero[0]);
               }
               if ( Z33etiquetastatus != T000C2_A33etiquetastatus[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetastatus");
                  GXUtil.WriteLogRaw("Old: ",Z33etiquetastatus);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A33etiquetastatus[0]);
               }
               if ( Z34etiquetafecharealizada != T000C2_A34etiquetafecharealizada[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetafecharealizada");
                  GXUtil.WriteLogRaw("Old: ",Z34etiquetafecharealizada);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A34etiquetafecharealizada[0]);
               }
               if ( Z35etiquetasreimpresion != T000C2_A35etiquetasreimpresion[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetasreimpresion");
                  GXUtil.WriteLogRaw("Old: ",Z35etiquetasreimpresion);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A35etiquetasreimpresion[0]);
               }
               if ( StringUtil.StrCmp(Z36etiquetasusuario, T000C2_A36etiquetasusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetasusuario");
                  GXUtil.WriteLogRaw("Old: ",Z36etiquetasusuario);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A36etiquetasusuario[0]);
               }
               if ( Z37etiquetasfecreg != T000C2_A37etiquetasfecreg[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetasfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z37etiquetasfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A37etiquetasfecreg[0]);
               }
               if ( Z38etiquetasfecultact != T000C2_A38etiquetasfecultact[0] )
               {
                  GXUtil.WriteLog("etiquetas:[seudo value changed for attri]"+"etiquetasfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z38etiquetasfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A38etiquetasfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ETIQUETAS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C12( )
      {
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C12( 0) ;
            CheckOptimisticConcurrency0C12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C14 */
                     pr_default.execute(12, new Object[] {n32etiquetasnumero, A32etiquetasnumero, n33etiquetastatus, A33etiquetastatus, n34etiquetafecharealizada, A34etiquetafecharealizada, n35etiquetasreimpresion, A35etiquetasreimpresion, n36etiquetasusuario, A36etiquetasusuario, n37etiquetasfecreg, A37etiquetasfecreg, n38etiquetasfecultact, A38etiquetasfecultact, A19almacenid, A17etiquetasproductoid, A18etiquetascambsid});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("ETIQUETAS") ;
                     if ( (pr_default.getStatus(12) == 1) )
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
                           ResetCaption0C0( ) ;
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
               Load0C12( ) ;
            }
            EndLevel0C12( ) ;
         }
         CloseExtendedTableCursors0C12( ) ;
      }

      protected void Update0C12( )
      {
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C15 */
                     pr_default.execute(13, new Object[] {n32etiquetasnumero, A32etiquetasnumero, n33etiquetastatus, A33etiquetastatus, n34etiquetafecharealizada, A34etiquetafecharealizada, n35etiquetasreimpresion, A35etiquetasreimpresion, n36etiquetasusuario, A36etiquetasusuario, n37etiquetasfecreg, A37etiquetasfecreg, n38etiquetasfecultact, A38etiquetasfecultact, A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("ETIQUETAS") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ETIQUETAS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C12( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0C0( ) ;
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
            EndLevel0C12( ) ;
         }
         CloseExtendedTableCursors0C12( ) ;
      }

      protected void DeferredUpdate0C12( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C12( ) ;
            AfterConfirm0C12( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C12( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000C16 */
                  pr_default.execute(14, new Object[] {A17etiquetasproductoid, A18etiquetascambsid, A19almacenid});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("ETIQUETAS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound12 == 0 )
                        {
                           InitAll0C12( ) ;
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
                        ResetCaption0C0( ) ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0C12( ) ;
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0C12( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0C12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "etiquetas");
            if ( AnyError == 0 )
            {
               ConfirmValues0C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "etiquetas");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0C12( )
      {
         /* Using cursor T000C17 */
         pr_default.execute(15);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A17etiquetasproductoid = T000C17_A17etiquetasproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
            A18etiquetascambsid = T000C17_A18etiquetascambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
            A19almacenid = T000C17_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C12( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A17etiquetasproductoid = T000C17_A17etiquetasproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
            A18etiquetascambsid = T000C17_A18etiquetascambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
            A19almacenid = T000C17_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
         }
      }

      protected void ScanEnd0C12( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0C12( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C12( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C12( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C12( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C12( )
      {
         edtetiquetasproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasproductoid_Enabled), 5, 0)));
         edtetiquetascambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetascambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetascambsid_Enabled), 5, 0)));
         edtalmacenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenid_Enabled), 5, 0)));
         edtetiquetasnumero_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasnumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasnumero_Enabled), 5, 0)));
         edtetiquetastatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetastatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetastatus_Enabled), 5, 0)));
         edtetiquetafecharealizada_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetafecharealizada_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetafecharealizada_Enabled), 5, 0)));
         edtetiquetasreimpresion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasreimpresion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasreimpresion_Enabled), 5, 0)));
         edtetiquetasusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasusuario_Enabled), 5, 0)));
         edtetiquetasfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasfecreg_Enabled), 5, 0)));
         edtetiquetasfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtetiquetasfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtetiquetasfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0C0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202221559139");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("etiquetas.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z17etiquetasproductoid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17etiquetasproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z18etiquetascambsid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18etiquetascambsid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z19almacenid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19almacenid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z32etiquetasnumero", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32etiquetasnumero), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z33etiquetastatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33etiquetastatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z34etiquetafecharealizada", context.localUtil.TToC( Z34etiquetafecharealizada, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z35etiquetasreimpresion", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35etiquetasreimpresion), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z36etiquetasusuario", Z36etiquetasusuario);
         GxWebStd.gx_hidden_field( context, "Z37etiquetasfecreg", context.localUtil.TToC( Z37etiquetasfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z38etiquetasfecultact", context.localUtil.TToC( Z38etiquetasfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("etiquetas.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "etiquetas" ;
      }

      public override String GetPgmdesc( )
      {
         return "etiquetas" ;
      }

      protected void InitializeNonKey0C12( )
      {
         A32etiquetasnumero = 0;
         n32etiquetasnumero = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32etiquetasnumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A32etiquetasnumero), 18, 0)));
         n32etiquetasnumero = ((0==A32etiquetasnumero) ? true : false);
         A33etiquetastatus = 0;
         n33etiquetastatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33etiquetastatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A33etiquetastatus), 18, 0)));
         n33etiquetastatus = ((0==A33etiquetastatus) ? true : false);
         A34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         n34etiquetafecharealizada = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34etiquetafecharealizada", context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
         n34etiquetafecharealizada = ((DateTime.MinValue==A34etiquetafecharealizada) ? true : false);
         A35etiquetasreimpresion = 0;
         n35etiquetasreimpresion = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35etiquetasreimpresion", StringUtil.LTrim( StringUtil.Str( (decimal)(A35etiquetasreimpresion), 18, 0)));
         n35etiquetasreimpresion = ((0==A35etiquetasreimpresion) ? true : false);
         A36etiquetasusuario = "";
         n36etiquetasusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36etiquetasusuario", A36etiquetasusuario);
         n36etiquetasusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A36etiquetasusuario)) ? true : false);
         A37etiquetasfecreg = (DateTime)(DateTime.MinValue);
         n37etiquetasfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37etiquetasfecreg", context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
         n37etiquetasfecreg = ((DateTime.MinValue==A37etiquetasfecreg) ? true : false);
         A38etiquetasfecultact = (DateTime)(DateTime.MinValue);
         n38etiquetasfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38etiquetasfecultact", context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
         n38etiquetasfecultact = ((DateTime.MinValue==A38etiquetasfecultact) ? true : false);
         Z32etiquetasnumero = 0;
         Z33etiquetastatus = 0;
         Z34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         Z35etiquetasreimpresion = 0;
         Z36etiquetasusuario = "";
         Z37etiquetasfecreg = (DateTime)(DateTime.MinValue);
         Z38etiquetasfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0C12( )
      {
         A17etiquetasproductoid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17etiquetasproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A17etiquetasproductoid), 9, 0)));
         A18etiquetascambsid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18etiquetascambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(A18etiquetascambsid), 9, 0)));
         A19almacenid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 9, 0)));
         InitializeNonKey0C12( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202221559145");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("etiquetas.js", "?202221559145");
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
         edtetiquetasproductoid_Internalname = "ETIQUETASPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetascambsid_Internalname = "ETIQUETASCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacenid_Internalname = "ALMACENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetasnumero_Internalname = "ETIQUETASNUMERO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetastatus_Internalname = "ETIQUETASTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetafecharealizada_Internalname = "ETIQUETAFECHAREALIZADA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetasreimpresion_Internalname = "ETIQUETASREIMPRESION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetasusuario_Internalname = "ETIQUETASUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetasfecreg_Internalname = "ETIQUETASFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtetiquetasfecultact_Internalname = "ETIQUETASFECULTACT";
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
         imgprompt_17_Internalname = "PROMPT_17";
         imgprompt_18_Internalname = "PROMPT_18";
         imgprompt_19_Internalname = "PROMPT_19";
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
         Form.Caption = "etiquetas";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtetiquetasfecultact_Jsonclick = "";
         edtetiquetasfecultact_Enabled = 1;
         edtetiquetasfecreg_Jsonclick = "";
         edtetiquetasfecreg_Enabled = 1;
         edtetiquetasusuario_Jsonclick = "";
         edtetiquetasusuario_Enabled = 1;
         edtetiquetasreimpresion_Jsonclick = "";
         edtetiquetasreimpresion_Enabled = 1;
         edtetiquetafecharealizada_Jsonclick = "";
         edtetiquetafecharealizada_Enabled = 1;
         edtetiquetastatus_Jsonclick = "";
         edtetiquetastatus_Enabled = 1;
         edtetiquetasnumero_Jsonclick = "";
         edtetiquetasnumero_Enabled = 1;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtalmacenid_Jsonclick = "";
         edtalmacenid_Enabled = 1;
         imgprompt_18_Visible = 1;
         imgprompt_18_Link = "";
         edtetiquetascambsid_Jsonclick = "";
         edtetiquetascambsid_Enabled = 1;
         imgprompt_17_Visible = 1;
         imgprompt_17_Link = "";
         edtetiquetasproductoid_Jsonclick = "";
         edtetiquetasproductoid_Enabled = 1;
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
         /* Using cursor T000C18 */
         pr_default.execute(16, new Object[] {A17etiquetasproductoid});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetasproducto'.", "ForeignKeyNotFound", 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(16);
         /* Using cursor T000C19 */
         pr_default.execute(17, new Object[] {A18etiquetascambsid});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetascambs'.", "ForeignKeyNotFound", 1, "ETIQUETASCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtetiquetascambsid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(17);
         /* Using cursor T000C20 */
         pr_default.execute(18, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(18);
         GX_FocusControl = edtetiquetasnumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Etiquetasproductoid( int GX_Parm1 )
      {
         A17etiquetasproductoid = GX_Parm1;
         /* Using cursor T000C18 */
         pr_default.execute(16, new Object[] {A17etiquetasproductoid});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetasproducto'.", "ForeignKeyNotFound", 1, "ETIQUETASPRODUCTOID");
            AnyError = 1;
            GX_FocusControl = edtetiquetasproductoid_Internalname;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Etiquetascambsid( int GX_Parm1 )
      {
         A18etiquetascambsid = GX_Parm1;
         /* Using cursor T000C19 */
         pr_default.execute(17, new Object[] {A18etiquetascambsid});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'etiquetascambs'.", "ForeignKeyNotFound", 1, "ETIQUETASCAMBSID");
            AnyError = 1;
            GX_FocusControl = edtetiquetascambsid_Internalname;
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Almacenid( int GX_Parm1 ,
                                   int GX_Parm2 ,
                                   int GX_Parm3 ,
                                   long GX_Parm4 ,
                                   long GX_Parm5 ,
                                   DateTime GX_Parm6 ,
                                   long GX_Parm7 ,
                                   String GX_Parm8 ,
                                   DateTime GX_Parm9 ,
                                   DateTime GX_Parm10 )
      {
         A17etiquetasproductoid = GX_Parm1;
         A18etiquetascambsid = GX_Parm2;
         A19almacenid = GX_Parm3;
         A32etiquetasnumero = GX_Parm4;
         n32etiquetasnumero = false;
         A33etiquetastatus = GX_Parm5;
         n33etiquetastatus = false;
         A34etiquetafecharealizada = GX_Parm6;
         n34etiquetafecharealizada = false;
         A35etiquetasreimpresion = GX_Parm7;
         n35etiquetasreimpresion = false;
         A36etiquetasusuario = GX_Parm8;
         n36etiquetasusuario = false;
         A37etiquetasfecreg = GX_Parm9;
         n37etiquetasfecreg = false;
         A38etiquetasfecultact = GX_Parm10;
         n38etiquetasfecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         /* Using cursor T000C20 */
         pr_default.execute(18, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'almacen'.", "ForeignKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
         }
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A32etiquetasnumero), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A33etiquetastatus), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.TToC( A34etiquetafecharealizada, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A35etiquetasreimpresion), 18, 0, ".", "")));
         isValidOutput.Add(A36etiquetasusuario);
         isValidOutput.Add(context.localUtil.TToC( A37etiquetasfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A38etiquetasfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17etiquetasproductoid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18etiquetascambsid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19almacenid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32etiquetasnumero), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33etiquetastatus), 18, 0, ",", "")));
         isValidOutput.Add(context.localUtil.TToC( Z34etiquetafecharealizada, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35etiquetasreimpresion), 18, 0, ",", "")));
         isValidOutput.Add(Z36etiquetasusuario);
         isValidOutput.Add(context.localUtil.TToC( Z37etiquetasfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z38etiquetasfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         pr_default.close(18);
         pr_default.close(16);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         Z36etiquetasusuario = "";
         Z37etiquetasfecreg = (DateTime)(DateTime.MinValue);
         Z38etiquetasfecultact = (DateTime)(DateTime.MinValue);
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
         A34etiquetafecharealizada = (DateTime)(DateTime.MinValue);
         A36etiquetasusuario = "";
         A37etiquetasfecreg = (DateTime)(DateTime.MinValue);
         A38etiquetasfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000C7_A32etiquetasnumero = new long[1] ;
         T000C7_n32etiquetasnumero = new bool[] {false} ;
         T000C7_A33etiquetastatus = new long[1] ;
         T000C7_n33etiquetastatus = new bool[] {false} ;
         T000C7_A34etiquetafecharealizada = new DateTime[] {DateTime.MinValue} ;
         T000C7_n34etiquetafecharealizada = new bool[] {false} ;
         T000C7_A35etiquetasreimpresion = new long[1] ;
         T000C7_n35etiquetasreimpresion = new bool[] {false} ;
         T000C7_A36etiquetasusuario = new String[] {""} ;
         T000C7_n36etiquetasusuario = new bool[] {false} ;
         T000C7_A37etiquetasfecreg = new DateTime[] {DateTime.MinValue} ;
         T000C7_n37etiquetasfecreg = new bool[] {false} ;
         T000C7_A38etiquetasfecultact = new DateTime[] {DateTime.MinValue} ;
         T000C7_n38etiquetasfecultact = new bool[] {false} ;
         T000C7_A19almacenid = new int[1] ;
         T000C7_A17etiquetasproductoid = new int[1] ;
         T000C7_A18etiquetascambsid = new int[1] ;
         T000C5_A17etiquetasproductoid = new int[1] ;
         T000C6_A18etiquetascambsid = new int[1] ;
         T000C4_A19almacenid = new int[1] ;
         T000C8_A17etiquetasproductoid = new int[1] ;
         T000C9_A18etiquetascambsid = new int[1] ;
         T000C10_A19almacenid = new int[1] ;
         T000C11_A17etiquetasproductoid = new int[1] ;
         T000C11_A18etiquetascambsid = new int[1] ;
         T000C11_A19almacenid = new int[1] ;
         T000C3_A32etiquetasnumero = new long[1] ;
         T000C3_n32etiquetasnumero = new bool[] {false} ;
         T000C3_A33etiquetastatus = new long[1] ;
         T000C3_n33etiquetastatus = new bool[] {false} ;
         T000C3_A34etiquetafecharealizada = new DateTime[] {DateTime.MinValue} ;
         T000C3_n34etiquetafecharealizada = new bool[] {false} ;
         T000C3_A35etiquetasreimpresion = new long[1] ;
         T000C3_n35etiquetasreimpresion = new bool[] {false} ;
         T000C3_A36etiquetasusuario = new String[] {""} ;
         T000C3_n36etiquetasusuario = new bool[] {false} ;
         T000C3_A37etiquetasfecreg = new DateTime[] {DateTime.MinValue} ;
         T000C3_n37etiquetasfecreg = new bool[] {false} ;
         T000C3_A38etiquetasfecultact = new DateTime[] {DateTime.MinValue} ;
         T000C3_n38etiquetasfecultact = new bool[] {false} ;
         T000C3_A19almacenid = new int[1] ;
         T000C3_A17etiquetasproductoid = new int[1] ;
         T000C3_A18etiquetascambsid = new int[1] ;
         sMode12 = "";
         T000C12_A17etiquetasproductoid = new int[1] ;
         T000C12_A18etiquetascambsid = new int[1] ;
         T000C12_A19almacenid = new int[1] ;
         T000C13_A17etiquetasproductoid = new int[1] ;
         T000C13_A18etiquetascambsid = new int[1] ;
         T000C13_A19almacenid = new int[1] ;
         T000C2_A32etiquetasnumero = new long[1] ;
         T000C2_n32etiquetasnumero = new bool[] {false} ;
         T000C2_A33etiquetastatus = new long[1] ;
         T000C2_n33etiquetastatus = new bool[] {false} ;
         T000C2_A34etiquetafecharealizada = new DateTime[] {DateTime.MinValue} ;
         T000C2_n34etiquetafecharealizada = new bool[] {false} ;
         T000C2_A35etiquetasreimpresion = new long[1] ;
         T000C2_n35etiquetasreimpresion = new bool[] {false} ;
         T000C2_A36etiquetasusuario = new String[] {""} ;
         T000C2_n36etiquetasusuario = new bool[] {false} ;
         T000C2_A37etiquetasfecreg = new DateTime[] {DateTime.MinValue} ;
         T000C2_n37etiquetasfecreg = new bool[] {false} ;
         T000C2_A38etiquetasfecultact = new DateTime[] {DateTime.MinValue} ;
         T000C2_n38etiquetasfecultact = new bool[] {false} ;
         T000C2_A19almacenid = new int[1] ;
         T000C2_A17etiquetasproductoid = new int[1] ;
         T000C2_A18etiquetascambsid = new int[1] ;
         T000C17_A17etiquetasproductoid = new int[1] ;
         T000C17_A18etiquetascambsid = new int[1] ;
         T000C17_A19almacenid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000C18_A17etiquetasproductoid = new int[1] ;
         T000C19_A18etiquetascambsid = new int[1] ;
         T000C20_A19almacenid = new int[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.etiquetas__default(),
            new Object[][] {
                new Object[] {
               T000C2_A32etiquetasnumero, T000C2_n32etiquetasnumero, T000C2_A33etiquetastatus, T000C2_n33etiquetastatus, T000C2_A34etiquetafecharealizada, T000C2_n34etiquetafecharealizada, T000C2_A35etiquetasreimpresion, T000C2_n35etiquetasreimpresion, T000C2_A36etiquetasusuario, T000C2_n36etiquetasusuario,
               T000C2_A37etiquetasfecreg, T000C2_n37etiquetasfecreg, T000C2_A38etiquetasfecultact, T000C2_n38etiquetasfecultact, T000C2_A19almacenid, T000C2_A17etiquetasproductoid, T000C2_A18etiquetascambsid
               }
               , new Object[] {
               T000C3_A32etiquetasnumero, T000C3_n32etiquetasnumero, T000C3_A33etiquetastatus, T000C3_n33etiquetastatus, T000C3_A34etiquetafecharealizada, T000C3_n34etiquetafecharealizada, T000C3_A35etiquetasreimpresion, T000C3_n35etiquetasreimpresion, T000C3_A36etiquetasusuario, T000C3_n36etiquetasusuario,
               T000C3_A37etiquetasfecreg, T000C3_n37etiquetasfecreg, T000C3_A38etiquetasfecultact, T000C3_n38etiquetasfecultact, T000C3_A19almacenid, T000C3_A17etiquetasproductoid, T000C3_A18etiquetascambsid
               }
               , new Object[] {
               T000C4_A19almacenid
               }
               , new Object[] {
               T000C5_A17etiquetasproductoid
               }
               , new Object[] {
               T000C6_A18etiquetascambsid
               }
               , new Object[] {
               T000C7_A32etiquetasnumero, T000C7_n32etiquetasnumero, T000C7_A33etiquetastatus, T000C7_n33etiquetastatus, T000C7_A34etiquetafecharealizada, T000C7_n34etiquetafecharealizada, T000C7_A35etiquetasreimpresion, T000C7_n35etiquetasreimpresion, T000C7_A36etiquetasusuario, T000C7_n36etiquetasusuario,
               T000C7_A37etiquetasfecreg, T000C7_n37etiquetasfecreg, T000C7_A38etiquetasfecultact, T000C7_n38etiquetasfecultact, T000C7_A19almacenid, T000C7_A17etiquetasproductoid, T000C7_A18etiquetascambsid
               }
               , new Object[] {
               T000C8_A17etiquetasproductoid
               }
               , new Object[] {
               T000C9_A18etiquetascambsid
               }
               , new Object[] {
               T000C10_A19almacenid
               }
               , new Object[] {
               T000C11_A17etiquetasproductoid, T000C11_A18etiquetascambsid, T000C11_A19almacenid
               }
               , new Object[] {
               T000C12_A17etiquetasproductoid, T000C12_A18etiquetascambsid, T000C12_A19almacenid
               }
               , new Object[] {
               T000C13_A17etiquetasproductoid, T000C13_A18etiquetascambsid, T000C13_A19almacenid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C17_A17etiquetasproductoid, T000C17_A18etiquetascambsid, T000C17_A19almacenid
               }
               , new Object[] {
               T000C18_A17etiquetasproductoid
               }
               , new Object[] {
               T000C19_A18etiquetascambsid
               }
               , new Object[] {
               T000C20_A19almacenid
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
      private short RcdFound12 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z17etiquetasproductoid ;
      private int Z18etiquetascambsid ;
      private int Z19almacenid ;
      private int A17etiquetasproductoid ;
      private int A18etiquetascambsid ;
      private int A19almacenid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtetiquetasproductoid_Enabled ;
      private int imgprompt_17_Visible ;
      private int edtetiquetascambsid_Enabled ;
      private int imgprompt_18_Visible ;
      private int edtalmacenid_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtetiquetasnumero_Enabled ;
      private int edtetiquetastatus_Enabled ;
      private int edtetiquetafecharealizada_Enabled ;
      private int edtetiquetasreimpresion_Enabled ;
      private int edtetiquetasusuario_Enabled ;
      private int edtetiquetasfecreg_Enabled ;
      private int edtetiquetasfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z32etiquetasnumero ;
      private long Z33etiquetastatus ;
      private long Z35etiquetasreimpresion ;
      private long A32etiquetasnumero ;
      private long A33etiquetastatus ;
      private long A35etiquetasreimpresion ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtetiquetasproductoid_Internalname ;
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
      private String edtetiquetasproductoid_Jsonclick ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String edtetiquetascambsid_Internalname ;
      private String edtetiquetascambsid_Jsonclick ;
      private String imgprompt_18_Internalname ;
      private String imgprompt_18_Link ;
      private String edtalmacenid_Internalname ;
      private String edtalmacenid_Jsonclick ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtetiquetasnumero_Internalname ;
      private String edtetiquetasnumero_Jsonclick ;
      private String edtetiquetastatus_Internalname ;
      private String edtetiquetastatus_Jsonclick ;
      private String edtetiquetafecharealizada_Internalname ;
      private String edtetiquetafecharealizada_Jsonclick ;
      private String edtetiquetasreimpresion_Internalname ;
      private String edtetiquetasreimpresion_Jsonclick ;
      private String edtetiquetasusuario_Internalname ;
      private String edtetiquetasusuario_Jsonclick ;
      private String edtetiquetasfecreg_Internalname ;
      private String edtetiquetasfecreg_Jsonclick ;
      private String edtetiquetasfecultact_Internalname ;
      private String edtetiquetasfecultact_Jsonclick ;
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
      private String sMode12 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z34etiquetafecharealizada ;
      private DateTime Z37etiquetasfecreg ;
      private DateTime Z38etiquetasfecultact ;
      private DateTime A34etiquetafecharealizada ;
      private DateTime A37etiquetasfecreg ;
      private DateTime A38etiquetasfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n32etiquetasnumero ;
      private bool n33etiquetastatus ;
      private bool n34etiquetafecharealizada ;
      private bool n35etiquetasreimpresion ;
      private bool n36etiquetasusuario ;
      private bool n37etiquetasfecreg ;
      private bool n38etiquetasfecultact ;
      private bool Gx_longc ;
      private String Z36etiquetasusuario ;
      private String A36etiquetasusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000C7_A32etiquetasnumero ;
      private bool[] T000C7_n32etiquetasnumero ;
      private long[] T000C7_A33etiquetastatus ;
      private bool[] T000C7_n33etiquetastatus ;
      private DateTime[] T000C7_A34etiquetafecharealizada ;
      private bool[] T000C7_n34etiquetafecharealizada ;
      private long[] T000C7_A35etiquetasreimpresion ;
      private bool[] T000C7_n35etiquetasreimpresion ;
      private String[] T000C7_A36etiquetasusuario ;
      private bool[] T000C7_n36etiquetasusuario ;
      private DateTime[] T000C7_A37etiquetasfecreg ;
      private bool[] T000C7_n37etiquetasfecreg ;
      private DateTime[] T000C7_A38etiquetasfecultact ;
      private bool[] T000C7_n38etiquetasfecultact ;
      private int[] T000C7_A19almacenid ;
      private int[] T000C7_A17etiquetasproductoid ;
      private int[] T000C7_A18etiquetascambsid ;
      private int[] T000C5_A17etiquetasproductoid ;
      private int[] T000C6_A18etiquetascambsid ;
      private int[] T000C4_A19almacenid ;
      private int[] T000C8_A17etiquetasproductoid ;
      private int[] T000C9_A18etiquetascambsid ;
      private int[] T000C10_A19almacenid ;
      private int[] T000C11_A17etiquetasproductoid ;
      private int[] T000C11_A18etiquetascambsid ;
      private int[] T000C11_A19almacenid ;
      private long[] T000C3_A32etiquetasnumero ;
      private bool[] T000C3_n32etiquetasnumero ;
      private long[] T000C3_A33etiquetastatus ;
      private bool[] T000C3_n33etiquetastatus ;
      private DateTime[] T000C3_A34etiquetafecharealizada ;
      private bool[] T000C3_n34etiquetafecharealizada ;
      private long[] T000C3_A35etiquetasreimpresion ;
      private bool[] T000C3_n35etiquetasreimpresion ;
      private String[] T000C3_A36etiquetasusuario ;
      private bool[] T000C3_n36etiquetasusuario ;
      private DateTime[] T000C3_A37etiquetasfecreg ;
      private bool[] T000C3_n37etiquetasfecreg ;
      private DateTime[] T000C3_A38etiquetasfecultact ;
      private bool[] T000C3_n38etiquetasfecultact ;
      private int[] T000C3_A19almacenid ;
      private int[] T000C3_A17etiquetasproductoid ;
      private int[] T000C3_A18etiquetascambsid ;
      private int[] T000C12_A17etiquetasproductoid ;
      private int[] T000C12_A18etiquetascambsid ;
      private int[] T000C12_A19almacenid ;
      private int[] T000C13_A17etiquetasproductoid ;
      private int[] T000C13_A18etiquetascambsid ;
      private int[] T000C13_A19almacenid ;
      private long[] T000C2_A32etiquetasnumero ;
      private bool[] T000C2_n32etiquetasnumero ;
      private long[] T000C2_A33etiquetastatus ;
      private bool[] T000C2_n33etiquetastatus ;
      private DateTime[] T000C2_A34etiquetafecharealizada ;
      private bool[] T000C2_n34etiquetafecharealizada ;
      private long[] T000C2_A35etiquetasreimpresion ;
      private bool[] T000C2_n35etiquetasreimpresion ;
      private String[] T000C2_A36etiquetasusuario ;
      private bool[] T000C2_n36etiquetasusuario ;
      private DateTime[] T000C2_A37etiquetasfecreg ;
      private bool[] T000C2_n37etiquetasfecreg ;
      private DateTime[] T000C2_A38etiquetasfecultact ;
      private bool[] T000C2_n38etiquetasfecultact ;
      private int[] T000C2_A19almacenid ;
      private int[] T000C2_A17etiquetasproductoid ;
      private int[] T000C2_A18etiquetascambsid ;
      private int[] T000C17_A17etiquetasproductoid ;
      private int[] T000C17_A18etiquetascambsid ;
      private int[] T000C17_A19almacenid ;
      private int[] T000C18_A17etiquetasproductoid ;
      private int[] T000C19_A18etiquetascambsid ;
      private int[] T000C20_A19almacenid ;
      private GXWebForm Form ;
   }

   public class etiquetas__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000C7 ;
          prmT000C7 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C5 ;
          prmT000C5 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C6 ;
          prmT000C6 = new Object[] {
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C4 ;
          prmT000C4 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C8 ;
          prmT000C8 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C9 ;
          prmT000C9 = new Object[] {
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C10 ;
          prmT000C10 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C11 ;
          prmT000C11 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C3 ;
          prmT000C3 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C12 ;
          prmT000C12 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C13 ;
          prmT000C13 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C2 ;
          prmT000C2 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C14 ;
          prmT000C14 = new Object[] {
          new Object[] {"etiquetasnumero",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetastatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetafecharealizada",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"etiquetasreimpresion",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"etiquetasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"etiquetasfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C15 ;
          prmT000C15 = new Object[] {
          new Object[] {"etiquetasnumero",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetastatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetafecharealizada",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"etiquetasreimpresion",NpgsqlDbType.Real,18,0} ,
          new Object[] {"etiquetasusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"etiquetasfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"etiquetasfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C16 ;
          prmT000C16 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C17 ;
          prmT000C17 = new Object[] {
          } ;
          Object[] prmT000C18 ;
          prmT000C18 = new Object[] {
          new Object[] {"etiquetasproductoid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C19 ;
          prmT000C19 = new Object[] {
          new Object[] {"etiquetascambsid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000C20 ;
          prmT000C20 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000C2", "SELECT etiquetasnumero, etiquetastatus, etiquetafecharealizada, etiquetasreimpresión, etiquetasusuario, etiquetasfecreg, etiquetasfecultact, articuloid, productoid AS etiquetasproductoid, cambsid AS etiquetascambsid FROM public.etiquetas WHERE productoid = :etiquetasproductoid AND cambsid = :etiquetascambsid AND articuloid = :almacenid  FOR UPDATE OF etiquetas NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000C2,1,0,true,false )
             ,new CursorDef("T000C3", "SELECT etiquetasnumero, etiquetastatus, etiquetafecharealizada, etiquetasreimpresión, etiquetasusuario, etiquetasfecreg, etiquetasfecultact, articuloid, productoid AS etiquetasproductoid, cambsid AS etiquetascambsid FROM public.etiquetas WHERE productoid = :etiquetasproductoid AND cambsid = :etiquetascambsid AND articuloid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C3,1,0,true,false )
             ,new CursorDef("T000C4", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C4,1,0,true,false )
             ,new CursorDef("T000C5", "SELECT modelosid AS etiquetasproductoid FROM public.modelos WHERE modelosid = :etiquetasproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C5,1,0,true,false )
             ,new CursorDef("T000C6", "SELECT cambsid AS etiquetascambsid FROM public.cambs WHERE cambsid = :etiquetascambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C6,1,0,true,false )
             ,new CursorDef("T000C7", "SELECT TM1.etiquetasnumero, TM1.etiquetastatus, TM1.etiquetafecharealizada, TM1.etiquetasreimpresión, TM1.etiquetasusuario, TM1.etiquetasfecreg, TM1.etiquetasfecultact, TM1.articuloid, TM1.productoid AS etiquetasproductoid, TM1.cambsid AS etiquetascambsid FROM public.etiquetas TM1 WHERE TM1.productoid = :etiquetasproductoid and TM1.cambsid = :etiquetascambsid and TM1.articuloid = :almacenid ORDER BY TM1.productoid, TM1.cambsid, TM1.articuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C7,100,0,true,false )
             ,new CursorDef("T000C8", "SELECT modelosid AS etiquetasproductoid FROM public.modelos WHERE modelosid = :etiquetasproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C8,1,0,true,false )
             ,new CursorDef("T000C9", "SELECT cambsid AS etiquetascambsid FROM public.cambs WHERE cambsid = :etiquetascambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C9,1,0,true,false )
             ,new CursorDef("T000C10", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C10,1,0,true,false )
             ,new CursorDef("T000C11", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE productoid = :etiquetasproductoid AND cambsid = :etiquetascambsid AND articuloid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C11,1,0,true,false )
             ,new CursorDef("T000C12", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE ( productoid > :etiquetasproductoid or productoid = :etiquetasproductoid and cambsid > :etiquetascambsid or cambsid = :etiquetascambsid and productoid = :etiquetasproductoid and articuloid > :almacenid) ORDER BY productoid, cambsid, articuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C12,1,0,true,true )
             ,new CursorDef("T000C13", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE ( productoid < :etiquetasproductoid or productoid = :etiquetasproductoid and cambsid < :etiquetascambsid or cambsid = :etiquetascambsid and productoid = :etiquetasproductoid and articuloid < :almacenid) ORDER BY productoid DESC, cambsid DESC, articuloid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C13,1,0,true,true )
             ,new CursorDef("T000C14", "SAVEPOINT gxupdate;INSERT INTO public.etiquetas(etiquetasnumero, etiquetastatus, etiquetafecharealizada, etiquetasreimpresión, etiquetasusuario, etiquetasfecreg, etiquetasfecultact, articuloid, productoid, cambsid) VALUES(:etiquetasnumero, :etiquetastatus, :etiquetafecharealizada, :etiquetasreimpresion, :etiquetasusuario, :etiquetasfecreg, :etiquetasfecultact, :almacenid, :etiquetasproductoid, :etiquetascambsid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000C14)
             ,new CursorDef("T000C15", "SAVEPOINT gxupdate;UPDATE public.etiquetas SET etiquetasnumero=:etiquetasnumero, etiquetastatus=:etiquetastatus, etiquetafecharealizada=:etiquetafecharealizada, etiquetasreimpresión=:etiquetasreimpresion, etiquetasusuario=:etiquetasusuario, etiquetasfecreg=:etiquetasfecreg, etiquetasfecultact=:etiquetasfecultact  WHERE productoid = :etiquetasproductoid AND cambsid = :etiquetascambsid AND articuloid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000C15)
             ,new CursorDef("T000C16", "SAVEPOINT gxupdate;DELETE FROM public.etiquetas  WHERE productoid = :etiquetasproductoid AND cambsid = :etiquetascambsid AND articuloid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000C16)
             ,new CursorDef("T000C17", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas ORDER BY productoid, cambsid, articuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C17,100,0,true,false )
             ,new CursorDef("T000C18", "SELECT modelosid AS etiquetasproductoid FROM public.modelos WHERE modelosid = :etiquetasproductoid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C18,1,0,true,false )
             ,new CursorDef("T000C19", "SELECT cambsid AS etiquetascambsid FROM public.cambs WHERE cambsid = :etiquetascambsid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C19,1,0,true,false )
             ,new CursorDef("T000C20", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C20,1,0,true,false )
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
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 18 :
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 12 :
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
                stmt.SetParameter(9, (int)parms[15]);
                stmt.SetParameter(10, (int)parms[16]);
                return;
             case 13 :
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
                stmt.SetParameter(9, (int)parms[15]);
                stmt.SetParameter(10, (int)parms[16]);
                return;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
