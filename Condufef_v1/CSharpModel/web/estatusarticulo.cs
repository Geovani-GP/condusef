/*
               File: estatusarticulo
        Description: estatusarticulo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:48:58.83
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
   public class estatusarticulo : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "estatusarticulo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtestatusarticuloid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public estatusarticulo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public estatusarticulo( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "estatusarticulo", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESTATUSARTICULOID"+"'), id:'"+"ESTATUSARTICULOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticuloid_Internalname, "estatusarticuloid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticuloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ",", "")), ((edtestatusarticuloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticuloid_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticuloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulodsc_Internalname, "estatusarticulodsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticulodsc_Internalname, A54estatusarticulodsc, StringUtil.RTrim( context.localUtil.Format( A54estatusarticulodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulodsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulodsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulodescuso_Internalname, "estatusarticulodescuso", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticulodescuso_Internalname, A55estatusarticulodescuso, StringUtil.RTrim( context.localUtil.Format( A55estatusarticulodescuso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulodescuso_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulodescuso_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticuloaplicamov_Internalname, "estatusarticuloaplicamov", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticuloaplicamov_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A56estatusarticuloaplicamov), 9, 0, ",", "")), ((edtestatusarticuloaplicamov_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A56estatusarticuloaplicamov), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A56estatusarticuloaplicamov), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticuloaplicamov_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticuloaplicamov_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulousotabla_Internalname, "estatusarticulousotabla", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticulousotabla_Internalname, A57estatusarticulousotabla, StringUtil.RTrim( context.localUtil.Format( A57estatusarticulousotabla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulousotabla_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulousotabla_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulousuario_Internalname, "estatusarticulousuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtestatusarticulousuario_Internalname, A58estatusarticulousuario, StringUtil.RTrim( context.localUtil.Format( A58estatusarticulousuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulousuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulousuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulofecreg_Internalname, "estatusarticulofecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtestatusarticulofecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtestatusarticulofecreg_Internalname, context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A59estatusarticulofecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulofecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulofecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_estatusarticulo.htm");
            GxWebStd.gx_bitmap( context, edtestatusarticulofecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtestatusarticulofecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_estatusarticulo.htm");
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
            GxWebStd.gx_label_element( context, edtestatusarticulofecultact_Internalname, "estatusarticulofecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtestatusarticulofecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtestatusarticulofecultact_Internalname, context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A60estatusarticulofecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtestatusarticulofecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtestatusarticulofecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_estatusarticulo.htm");
            GxWebStd.gx_bitmap( context, edtestatusarticulofecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtestatusarticulofecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_estatusarticulo.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_estatusarticulo.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtestatusarticuloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtestatusarticuloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTATUSARTICULOID");
                  AnyError = 1;
                  GX_FocusControl = edtestatusarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A12estatusarticuloid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
               }
               else
               {
                  A12estatusarticuloid = (long)(context.localUtil.CToN( cgiGet( edtestatusarticuloid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
               }
               A54estatusarticulodsc = cgiGet( edtestatusarticulodsc_Internalname);
               n54estatusarticulodsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54estatusarticulodsc", A54estatusarticulodsc);
               n54estatusarticulodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A54estatusarticulodsc)) ? true : false);
               A55estatusarticulodescuso = cgiGet( edtestatusarticulodescuso_Internalname);
               n55estatusarticulodescuso = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55estatusarticulodescuso", A55estatusarticulodescuso);
               n55estatusarticulodescuso = (String.IsNullOrEmpty(StringUtil.RTrim( A55estatusarticulodescuso)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtestatusarticuloaplicamov_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtestatusarticuloaplicamov_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTATUSARTICULOAPLICAMOV");
                  AnyError = 1;
                  GX_FocusControl = edtestatusarticuloaplicamov_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A56estatusarticuloaplicamov = 0;
                  n56estatusarticuloaplicamov = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(A56estatusarticuloaplicamov), 9, 0)));
               }
               else
               {
                  A56estatusarticuloaplicamov = (int)(context.localUtil.CToN( cgiGet( edtestatusarticuloaplicamov_Internalname), ",", "."));
                  n56estatusarticuloaplicamov = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(A56estatusarticuloaplicamov), 9, 0)));
               }
               n56estatusarticuloaplicamov = ((0==A56estatusarticuloaplicamov) ? true : false);
               A57estatusarticulousotabla = cgiGet( edtestatusarticulousotabla_Internalname);
               n57estatusarticulousotabla = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57estatusarticulousotabla", A57estatusarticulousotabla);
               n57estatusarticulousotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A57estatusarticulousotabla)) ? true : false);
               A58estatusarticulousuario = cgiGet( edtestatusarticulousuario_Internalname);
               n58estatusarticulousuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58estatusarticulousuario", A58estatusarticulousuario);
               n58estatusarticulousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A58estatusarticulousuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtestatusarticulofecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"estatusarticulofecreg"}), 1, "ESTATUSARTICULOFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtestatusarticulofecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
                  n59estatusarticulofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59estatusarticulofecreg", context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A59estatusarticulofecreg = context.localUtil.CToT( cgiGet( edtestatusarticulofecreg_Internalname));
                  n59estatusarticulofecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59estatusarticulofecreg", context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n59estatusarticulofecreg = ((DateTime.MinValue==A59estatusarticulofecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtestatusarticulofecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"estatusarticulofecultact"}), 1, "ESTATUSARTICULOFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtestatusarticulofecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
                  n60estatusarticulofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60estatusarticulofecultact", context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A60estatusarticulofecultact = context.localUtil.CToT( cgiGet( edtestatusarticulofecultact_Internalname));
                  n60estatusarticulofecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60estatusarticulofecultact", context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n60estatusarticulofecultact = ((DateTime.MinValue==A60estatusarticulofecultact) ? true : false);
               /* Read saved values. */
               Z12estatusarticuloid = (long)(context.localUtil.CToN( cgiGet( "Z12estatusarticuloid"), ",", "."));
               Z54estatusarticulodsc = cgiGet( "Z54estatusarticulodsc");
               n54estatusarticulodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A54estatusarticulodsc)) ? true : false);
               Z55estatusarticulodescuso = cgiGet( "Z55estatusarticulodescuso");
               n55estatusarticulodescuso = (String.IsNullOrEmpty(StringUtil.RTrim( A55estatusarticulodescuso)) ? true : false);
               Z56estatusarticuloaplicamov = (int)(context.localUtil.CToN( cgiGet( "Z56estatusarticuloaplicamov"), ",", "."));
               n56estatusarticuloaplicamov = ((0==A56estatusarticuloaplicamov) ? true : false);
               Z57estatusarticulousotabla = cgiGet( "Z57estatusarticulousotabla");
               n57estatusarticulousotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A57estatusarticulousotabla)) ? true : false);
               Z58estatusarticulousuario = cgiGet( "Z58estatusarticulousuario");
               n58estatusarticulousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A58estatusarticulousuario)) ? true : false);
               Z59estatusarticulofecreg = context.localUtil.CToT( cgiGet( "Z59estatusarticulofecreg"), 0);
               n59estatusarticulofecreg = ((DateTime.MinValue==A59estatusarticulofecreg) ? true : false);
               Z60estatusarticulofecultact = context.localUtil.CToT( cgiGet( "Z60estatusarticulofecultact"), 0);
               n60estatusarticulofecultact = ((DateTime.MinValue==A60estatusarticulofecultact) ? true : false);
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
                  A12estatusarticuloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
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
               InitAll077( ) ;
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
         DisableAttributes077( ) ;
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

      protected void ResetCaption070( )
      {
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z54estatusarticulodsc = T00073_A54estatusarticulodsc[0];
               Z55estatusarticulodescuso = T00073_A55estatusarticulodescuso[0];
               Z56estatusarticuloaplicamov = T00073_A56estatusarticuloaplicamov[0];
               Z57estatusarticulousotabla = T00073_A57estatusarticulousotabla[0];
               Z58estatusarticulousuario = T00073_A58estatusarticulousuario[0];
               Z59estatusarticulofecreg = T00073_A59estatusarticulofecreg[0];
               Z60estatusarticulofecultact = T00073_A60estatusarticulofecultact[0];
            }
            else
            {
               Z54estatusarticulodsc = A54estatusarticulodsc;
               Z55estatusarticulodescuso = A55estatusarticulodescuso;
               Z56estatusarticuloaplicamov = A56estatusarticuloaplicamov;
               Z57estatusarticulousotabla = A57estatusarticulousotabla;
               Z58estatusarticulousuario = A58estatusarticulousuario;
               Z59estatusarticulofecreg = A59estatusarticulofecreg;
               Z60estatusarticulofecultact = A60estatusarticulofecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z12estatusarticuloid = A12estatusarticuloid;
            Z54estatusarticulodsc = A54estatusarticulodsc;
            Z55estatusarticulodescuso = A55estatusarticulodescuso;
            Z56estatusarticuloaplicamov = A56estatusarticuloaplicamov;
            Z57estatusarticulousotabla = A57estatusarticulousotabla;
            Z58estatusarticulousuario = A58estatusarticulousuario;
            Z59estatusarticulofecreg = A59estatusarticulofecreg;
            Z60estatusarticulofecultact = A60estatusarticulofecultact;
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

      protected void Load077( )
      {
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound7 = 1;
            A54estatusarticulodsc = T00074_A54estatusarticulodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54estatusarticulodsc", A54estatusarticulodsc);
            n54estatusarticulodsc = T00074_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = T00074_A55estatusarticulodescuso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55estatusarticulodescuso", A55estatusarticulodescuso);
            n55estatusarticulodescuso = T00074_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = T00074_A56estatusarticuloaplicamov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(A56estatusarticuloaplicamov), 9, 0)));
            n56estatusarticuloaplicamov = T00074_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = T00074_A57estatusarticulousotabla[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57estatusarticulousotabla", A57estatusarticulousotabla);
            n57estatusarticulousotabla = T00074_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = T00074_A58estatusarticulousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58estatusarticulousuario", A58estatusarticulousuario);
            n58estatusarticulousuario = T00074_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = T00074_A59estatusarticulofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59estatusarticulofecreg", context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
            n59estatusarticulofecreg = T00074_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = T00074_A60estatusarticulofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60estatusarticulofecultact", context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
            n60estatusarticulofecultact = T00074_n60estatusarticulofecultact[0];
            ZM077( -1) ;
         }
         pr_default.close(2);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
      }

      protected void CheckExtendedTable077( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors077( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey077( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM077( 1) ;
            RcdFound7 = 1;
            A12estatusarticuloid = T00073_A12estatusarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
            A54estatusarticulodsc = T00073_A54estatusarticulodsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54estatusarticulodsc", A54estatusarticulodsc);
            n54estatusarticulodsc = T00073_n54estatusarticulodsc[0];
            A55estatusarticulodescuso = T00073_A55estatusarticulodescuso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55estatusarticulodescuso", A55estatusarticulodescuso);
            n55estatusarticulodescuso = T00073_n55estatusarticulodescuso[0];
            A56estatusarticuloaplicamov = T00073_A56estatusarticuloaplicamov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(A56estatusarticuloaplicamov), 9, 0)));
            n56estatusarticuloaplicamov = T00073_n56estatusarticuloaplicamov[0];
            A57estatusarticulousotabla = T00073_A57estatusarticulousotabla[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57estatusarticulousotabla", A57estatusarticulousotabla);
            n57estatusarticulousotabla = T00073_n57estatusarticulousotabla[0];
            A58estatusarticulousuario = T00073_A58estatusarticulousuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58estatusarticulousuario", A58estatusarticulousuario);
            n58estatusarticulousuario = T00073_n58estatusarticulousuario[0];
            A59estatusarticulofecreg = T00073_A59estatusarticulofecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59estatusarticulofecreg", context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
            n59estatusarticulofecreg = T00073_n59estatusarticulofecreg[0];
            A60estatusarticulofecultact = T00073_A60estatusarticulofecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60estatusarticulofecultact", context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
            n60estatusarticulofecultact = T00073_n60estatusarticulofecultact[0];
            Z12estatusarticuloid = A12estatusarticuloid;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
         if ( RcdFound7 == 0 )
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
         RcdFound7 = 0;
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00076_A12estatusarticuloid[0] < A12estatusarticuloid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00076_A12estatusarticuloid[0] > A12estatusarticuloid ) ) )
            {
               A12estatusarticuloid = T00076_A12estatusarticuloid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A12estatusarticuloid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00077_A12estatusarticuloid[0] > A12estatusarticuloid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00077_A12estatusarticuloid[0] < A12estatusarticuloid ) ) )
            {
               A12estatusarticuloid = T00077_A12estatusarticuloid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey077( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtestatusarticuloid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert077( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A12estatusarticuloid != Z12estatusarticuloid )
               {
                  A12estatusarticuloid = Z12estatusarticuloid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ESTATUSARTICULOID");
                  AnyError = 1;
                  GX_FocusControl = edtestatusarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtestatusarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update077( ) ;
                  GX_FocusControl = edtestatusarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A12estatusarticuloid != Z12estatusarticuloid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtestatusarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert077( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ESTATUSARTICULOID");
                     AnyError = 1;
                     GX_FocusControl = edtestatusarticuloid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtestatusarticuloid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert077( ) ;
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
         if ( A12estatusarticuloid != Z12estatusarticuloid )
         {
            A12estatusarticuloid = Z12estatusarticuloid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ESTATUSARTICULOID");
            AnyError = 1;
            GX_FocusControl = edtestatusarticuloid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtestatusarticuloid_Internalname;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ESTATUSARTICULOID");
            AnyError = 1;
            GX_FocusControl = edtestatusarticuloid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtestatusarticulodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtestatusarticulodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd077( ) ;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtestatusarticulodsc_Internalname;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtestatusarticulodsc_Internalname;
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
         ScanStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound7 != 0 )
            {
               ScanNext077( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtestatusarticulodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd077( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A12estatusarticuloid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ESTATUSARTICULO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z54estatusarticulodsc, T00072_A54estatusarticulodsc[0]) != 0 ) || ( StringUtil.StrCmp(Z55estatusarticulodescuso, T00072_A55estatusarticulodescuso[0]) != 0 ) || ( Z56estatusarticuloaplicamov != T00072_A56estatusarticuloaplicamov[0] ) || ( StringUtil.StrCmp(Z57estatusarticulousotabla, T00072_A57estatusarticulousotabla[0]) != 0 ) || ( StringUtil.StrCmp(Z58estatusarticulousuario, T00072_A58estatusarticulousuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z59estatusarticulofecreg != T00072_A59estatusarticulofecreg[0] ) || ( Z60estatusarticulofecultact != T00072_A60estatusarticulofecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z54estatusarticulodsc, T00072_A54estatusarticulodsc[0]) != 0 )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulodsc");
                  GXUtil.WriteLogRaw("Old: ",Z54estatusarticulodsc);
                  GXUtil.WriteLogRaw("Current: ",T00072_A54estatusarticulodsc[0]);
               }
               if ( StringUtil.StrCmp(Z55estatusarticulodescuso, T00072_A55estatusarticulodescuso[0]) != 0 )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulodescuso");
                  GXUtil.WriteLogRaw("Old: ",Z55estatusarticulodescuso);
                  GXUtil.WriteLogRaw("Current: ",T00072_A55estatusarticulodescuso[0]);
               }
               if ( Z56estatusarticuloaplicamov != T00072_A56estatusarticuloaplicamov[0] )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticuloaplicamov");
                  GXUtil.WriteLogRaw("Old: ",Z56estatusarticuloaplicamov);
                  GXUtil.WriteLogRaw("Current: ",T00072_A56estatusarticuloaplicamov[0]);
               }
               if ( StringUtil.StrCmp(Z57estatusarticulousotabla, T00072_A57estatusarticulousotabla[0]) != 0 )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulousotabla");
                  GXUtil.WriteLogRaw("Old: ",Z57estatusarticulousotabla);
                  GXUtil.WriteLogRaw("Current: ",T00072_A57estatusarticulousotabla[0]);
               }
               if ( StringUtil.StrCmp(Z58estatusarticulousuario, T00072_A58estatusarticulousuario[0]) != 0 )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulousuario");
                  GXUtil.WriteLogRaw("Old: ",Z58estatusarticulousuario);
                  GXUtil.WriteLogRaw("Current: ",T00072_A58estatusarticulousuario[0]);
               }
               if ( Z59estatusarticulofecreg != T00072_A59estatusarticulofecreg[0] )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulofecreg");
                  GXUtil.WriteLogRaw("Old: ",Z59estatusarticulofecreg);
                  GXUtil.WriteLogRaw("Current: ",T00072_A59estatusarticulofecreg[0]);
               }
               if ( Z60estatusarticulofecultact != T00072_A60estatusarticulofecultact[0] )
               {
                  GXUtil.WriteLog("estatusarticulo:[seudo value changed for attri]"+"estatusarticulofecultact");
                  GXUtil.WriteLogRaw("Old: ",Z60estatusarticulofecultact);
                  GXUtil.WriteLogRaw("Current: ",T00072_A60estatusarticulofecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ESTATUSARTICULO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM077( 0) ;
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00078 */
                     pr_default.execute(6, new Object[] {A12estatusarticuloid, n54estatusarticulodsc, A54estatusarticulodsc, n55estatusarticulodescuso, A55estatusarticulodescuso, n56estatusarticuloaplicamov, A56estatusarticuloaplicamov, n57estatusarticulousotabla, A57estatusarticulousotabla, n58estatusarticulousuario, A58estatusarticulousuario, n59estatusarticulofecreg, A59estatusarticulofecreg, n60estatusarticulofecultact, A60estatusarticulofecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
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
                           ResetCaption070( ) ;
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
               Load077( ) ;
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void Update077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00079 */
                     pr_default.execute(7, new Object[] {n54estatusarticulodsc, A54estatusarticulodsc, n55estatusarticulodescuso, A55estatusarticulodescuso, n56estatusarticuloaplicamov, A56estatusarticuloaplicamov, n57estatusarticulousotabla, A57estatusarticulousotabla, n58estatusarticulousuario, A58estatusarticulousuario, n59estatusarticulofecreg, A59estatusarticulofecreg, n60estatusarticulofecultact, A60estatusarticulofecultact, A12estatusarticuloid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ESTATUSARTICULO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate077( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption070( ) ;
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
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls077( ) ;
            AfterConfirm077( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete077( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000710 */
                  pr_default.execute(8, new Object[] {A12estatusarticuloid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("ESTATUSARTICULO") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound7 == 0 )
                        {
                           InitAll077( ) ;
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
                        ResetCaption070( ) ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel077( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete077( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "estatusarticulo");
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "estatusarticulo");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart077( )
      {
         /* Using cursor T000711 */
         pr_default.execute(9);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound7 = 1;
            A12estatusarticuloid = T000711_A12estatusarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext077( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound7 = 1;
            A12estatusarticuloid = T000711_A12estatusarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
         }
      }

      protected void ScanEnd077( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm077( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert077( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate077( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete077( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete077( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate077( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes077( )
      {
         edtestatusarticuloid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticuloid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticuloid_Enabled), 5, 0)));
         edtestatusarticulodsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulodsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulodsc_Enabled), 5, 0)));
         edtestatusarticulodescuso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulodescuso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulodescuso_Enabled), 5, 0)));
         edtestatusarticuloaplicamov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticuloaplicamov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticuloaplicamov_Enabled), 5, 0)));
         edtestatusarticulousotabla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulousotabla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulousotabla_Enabled), 5, 0)));
         edtestatusarticulousuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulousuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulousuario_Enabled), 5, 0)));
         edtestatusarticulofecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulofecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulofecreg_Enabled), 5, 0)));
         edtestatusarticulofecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtestatusarticulofecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtestatusarticulofecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
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
         context.AddJavascriptSource("gxcfg.js", "?20221233485972");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("estatusarticulo.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z12estatusarticuloid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12estatusarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z54estatusarticulodsc", Z54estatusarticulodsc);
         GxWebStd.gx_hidden_field( context, "Z55estatusarticulodescuso", Z55estatusarticulodescuso);
         GxWebStd.gx_hidden_field( context, "Z56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z56estatusarticuloaplicamov), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z57estatusarticulousotabla", Z57estatusarticulousotabla);
         GxWebStd.gx_hidden_field( context, "Z58estatusarticulousuario", Z58estatusarticulousuario);
         GxWebStd.gx_hidden_field( context, "Z59estatusarticulofecreg", context.localUtil.TToC( Z59estatusarticulofecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z60estatusarticulofecultact", context.localUtil.TToC( Z60estatusarticulofecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("estatusarticulo.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "estatusarticulo" ;
      }

      public override String GetPgmdesc( )
      {
         return "estatusarticulo" ;
      }

      protected void InitializeNonKey077( )
      {
         A54estatusarticulodsc = "";
         n54estatusarticulodsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54estatusarticulodsc", A54estatusarticulodsc);
         n54estatusarticulodsc = (String.IsNullOrEmpty(StringUtil.RTrim( A54estatusarticulodsc)) ? true : false);
         A55estatusarticulodescuso = "";
         n55estatusarticulodescuso = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55estatusarticulodescuso", A55estatusarticulodescuso);
         n55estatusarticulodescuso = (String.IsNullOrEmpty(StringUtil.RTrim( A55estatusarticulodescuso)) ? true : false);
         A56estatusarticuloaplicamov = 0;
         n56estatusarticuloaplicamov = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56estatusarticuloaplicamov", StringUtil.LTrim( StringUtil.Str( (decimal)(A56estatusarticuloaplicamov), 9, 0)));
         n56estatusarticuloaplicamov = ((0==A56estatusarticuloaplicamov) ? true : false);
         A57estatusarticulousotabla = "";
         n57estatusarticulousotabla = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57estatusarticulousotabla", A57estatusarticulousotabla);
         n57estatusarticulousotabla = (String.IsNullOrEmpty(StringUtil.RTrim( A57estatusarticulousotabla)) ? true : false);
         A58estatusarticulousuario = "";
         n58estatusarticulousuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58estatusarticulousuario", A58estatusarticulousuario);
         n58estatusarticulousuario = (String.IsNullOrEmpty(StringUtil.RTrim( A58estatusarticulousuario)) ? true : false);
         A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         n59estatusarticulofecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59estatusarticulofecreg", context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
         n59estatusarticulofecreg = ((DateTime.MinValue==A59estatusarticulofecreg) ? true : false);
         A60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         n60estatusarticulofecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60estatusarticulofecultact", context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
         n60estatusarticulofecultact = ((DateTime.MinValue==A60estatusarticulofecultact) ? true : false);
         Z54estatusarticulodsc = "";
         Z55estatusarticulodescuso = "";
         Z56estatusarticuloaplicamov = 0;
         Z57estatusarticulousotabla = "";
         Z58estatusarticulousuario = "";
         Z59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         Z60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll077( )
      {
         A12estatusarticuloid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A12estatusarticuloid), 18, 0)));
         InitializeNonKey077( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?13205289");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?3485073");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221233485980");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("estatusarticulo.js", "?20221233485980");
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
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulodescuso_Internalname = "ESTATUSARTICULODESCUSO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticuloaplicamov_Internalname = "ESTATUSARTICULOAPLICAMOV";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulousotabla_Internalname = "ESTATUSARTICULOUSOTABLA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulousuario_Internalname = "ESTATUSARTICULOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulofecreg_Internalname = "ESTATUSARTICULOFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtestatusarticulofecultact_Internalname = "ESTATUSARTICULOFECULTACT";
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
         Form.Caption = "estatusarticulo";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtestatusarticulofecultact_Jsonclick = "";
         edtestatusarticulofecultact_Enabled = 1;
         edtestatusarticulofecreg_Jsonclick = "";
         edtestatusarticulofecreg_Enabled = 1;
         edtestatusarticulousuario_Jsonclick = "";
         edtestatusarticulousuario_Enabled = 1;
         edtestatusarticulousotabla_Jsonclick = "";
         edtestatusarticulousotabla_Enabled = 1;
         edtestatusarticuloaplicamov_Jsonclick = "";
         edtestatusarticuloaplicamov_Enabled = 1;
         edtestatusarticulodescuso_Jsonclick = "";
         edtestatusarticulodescuso_Enabled = 1;
         edtestatusarticulodsc_Jsonclick = "";
         edtestatusarticulodsc_Enabled = 1;
         edtestatusarticuloid_Jsonclick = "";
         edtestatusarticuloid_Enabled = 1;
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
         GX_FocusControl = edtestatusarticulodsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Estatusarticuloid( long GX_Parm1 ,
                                           String GX_Parm2 ,
                                           String GX_Parm3 ,
                                           int GX_Parm4 ,
                                           String GX_Parm5 ,
                                           String GX_Parm6 ,
                                           DateTime GX_Parm7 ,
                                           DateTime GX_Parm8 )
      {
         A12estatusarticuloid = GX_Parm1;
         A54estatusarticulodsc = GX_Parm2;
         n54estatusarticulodsc = false;
         A55estatusarticulodescuso = GX_Parm3;
         n55estatusarticulodescuso = false;
         A56estatusarticuloaplicamov = GX_Parm4;
         n56estatusarticuloaplicamov = false;
         A57estatusarticulousotabla = GX_Parm5;
         n57estatusarticulousotabla = false;
         A58estatusarticulousuario = GX_Parm6;
         n58estatusarticulousuario = false;
         A59estatusarticulofecreg = GX_Parm7;
         n59estatusarticulofecreg = false;
         A60estatusarticulofecultact = GX_Parm8;
         n60estatusarticulofecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A54estatusarticulodsc);
         isValidOutput.Add(A55estatusarticulodescuso);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A56estatusarticuloaplicamov), 9, 0, ".", "")));
         isValidOutput.Add(A57estatusarticulousotabla);
         isValidOutput.Add(A58estatusarticulousuario);
         isValidOutput.Add(context.localUtil.TToC( A59estatusarticulofecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A60estatusarticulofecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12estatusarticuloid), 18, 0, ",", "")));
         isValidOutput.Add(Z54estatusarticulodsc);
         isValidOutput.Add(Z55estatusarticulodescuso);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z56estatusarticuloaplicamov), 9, 0, ",", "")));
         isValidOutput.Add(Z57estatusarticulousotabla);
         isValidOutput.Add(Z58estatusarticulousuario);
         isValidOutput.Add(context.localUtil.TToC( Z59estatusarticulofecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z60estatusarticulofecultact, 10, 8, 0, 0, "/", ":", " "));
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
         Z54estatusarticulodsc = "";
         Z55estatusarticulodescuso = "";
         Z57estatusarticulousotabla = "";
         Z58estatusarticulousuario = "";
         Z59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         Z60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
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
         A54estatusarticulodsc = "";
         A55estatusarticulodescuso = "";
         A57estatusarticulousotabla = "";
         A58estatusarticulousuario = "";
         A59estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         A60estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00074_A12estatusarticuloid = new long[1] ;
         T00074_A54estatusarticulodsc = new String[] {""} ;
         T00074_n54estatusarticulodsc = new bool[] {false} ;
         T00074_A55estatusarticulodescuso = new String[] {""} ;
         T00074_n55estatusarticulodescuso = new bool[] {false} ;
         T00074_A56estatusarticuloaplicamov = new int[1] ;
         T00074_n56estatusarticuloaplicamov = new bool[] {false} ;
         T00074_A57estatusarticulousotabla = new String[] {""} ;
         T00074_n57estatusarticulousotabla = new bool[] {false} ;
         T00074_A58estatusarticulousuario = new String[] {""} ;
         T00074_n58estatusarticulousuario = new bool[] {false} ;
         T00074_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         T00074_n59estatusarticulofecreg = new bool[] {false} ;
         T00074_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         T00074_n60estatusarticulofecultact = new bool[] {false} ;
         T00075_A12estatusarticuloid = new long[1] ;
         T00073_A12estatusarticuloid = new long[1] ;
         T00073_A54estatusarticulodsc = new String[] {""} ;
         T00073_n54estatusarticulodsc = new bool[] {false} ;
         T00073_A55estatusarticulodescuso = new String[] {""} ;
         T00073_n55estatusarticulodescuso = new bool[] {false} ;
         T00073_A56estatusarticuloaplicamov = new int[1] ;
         T00073_n56estatusarticuloaplicamov = new bool[] {false} ;
         T00073_A57estatusarticulousotabla = new String[] {""} ;
         T00073_n57estatusarticulousotabla = new bool[] {false} ;
         T00073_A58estatusarticulousuario = new String[] {""} ;
         T00073_n58estatusarticulousuario = new bool[] {false} ;
         T00073_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         T00073_n59estatusarticulofecreg = new bool[] {false} ;
         T00073_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         T00073_n60estatusarticulofecultact = new bool[] {false} ;
         sMode7 = "";
         T00076_A12estatusarticuloid = new long[1] ;
         T00077_A12estatusarticuloid = new long[1] ;
         T00072_A12estatusarticuloid = new long[1] ;
         T00072_A54estatusarticulodsc = new String[] {""} ;
         T00072_n54estatusarticulodsc = new bool[] {false} ;
         T00072_A55estatusarticulodescuso = new String[] {""} ;
         T00072_n55estatusarticulodescuso = new bool[] {false} ;
         T00072_A56estatusarticuloaplicamov = new int[1] ;
         T00072_n56estatusarticuloaplicamov = new bool[] {false} ;
         T00072_A57estatusarticulousotabla = new String[] {""} ;
         T00072_n57estatusarticulousotabla = new bool[] {false} ;
         T00072_A58estatusarticulousuario = new String[] {""} ;
         T00072_n58estatusarticulousuario = new bool[] {false} ;
         T00072_A59estatusarticulofecreg = new DateTime[] {DateTime.MinValue} ;
         T00072_n59estatusarticulofecreg = new bool[] {false} ;
         T00072_A60estatusarticulofecultact = new DateTime[] {DateTime.MinValue} ;
         T00072_n60estatusarticulofecultact = new bool[] {false} ;
         T000711_A12estatusarticuloid = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estatusarticulo__default(),
            new Object[][] {
                new Object[] {
               T00072_A12estatusarticuloid, T00072_A54estatusarticulodsc, T00072_n54estatusarticulodsc, T00072_A55estatusarticulodescuso, T00072_n55estatusarticulodescuso, T00072_A56estatusarticuloaplicamov, T00072_n56estatusarticuloaplicamov, T00072_A57estatusarticulousotabla, T00072_n57estatusarticulousotabla, T00072_A58estatusarticulousuario,
               T00072_n58estatusarticulousuario, T00072_A59estatusarticulofecreg, T00072_n59estatusarticulofecreg, T00072_A60estatusarticulofecultact, T00072_n60estatusarticulofecultact
               }
               , new Object[] {
               T00073_A12estatusarticuloid, T00073_A54estatusarticulodsc, T00073_n54estatusarticulodsc, T00073_A55estatusarticulodescuso, T00073_n55estatusarticulodescuso, T00073_A56estatusarticuloaplicamov, T00073_n56estatusarticuloaplicamov, T00073_A57estatusarticulousotabla, T00073_n57estatusarticulousotabla, T00073_A58estatusarticulousuario,
               T00073_n58estatusarticulousuario, T00073_A59estatusarticulofecreg, T00073_n59estatusarticulofecreg, T00073_A60estatusarticulofecultact, T00073_n60estatusarticulofecultact
               }
               , new Object[] {
               T00074_A12estatusarticuloid, T00074_A54estatusarticulodsc, T00074_n54estatusarticulodsc, T00074_A55estatusarticulodescuso, T00074_n55estatusarticulodescuso, T00074_A56estatusarticuloaplicamov, T00074_n56estatusarticuloaplicamov, T00074_A57estatusarticulousotabla, T00074_n57estatusarticulousotabla, T00074_A58estatusarticulousuario,
               T00074_n58estatusarticulousuario, T00074_A59estatusarticulofecreg, T00074_n59estatusarticulofecreg, T00074_A60estatusarticulofecultact, T00074_n60estatusarticulofecultact
               }
               , new Object[] {
               T00075_A12estatusarticuloid
               }
               , new Object[] {
               T00076_A12estatusarticuloid
               }
               , new Object[] {
               T00077_A12estatusarticuloid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000711_A12estatusarticuloid
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
      private short RcdFound7 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z56estatusarticuloaplicamov ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtestatusarticuloid_Enabled ;
      private int edtestatusarticulodsc_Enabled ;
      private int edtestatusarticulodescuso_Enabled ;
      private int A56estatusarticuloaplicamov ;
      private int edtestatusarticuloaplicamov_Enabled ;
      private int edtestatusarticulousotabla_Enabled ;
      private int edtestatusarticulousuario_Enabled ;
      private int edtestatusarticulofecreg_Enabled ;
      private int edtestatusarticulofecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z12estatusarticuloid ;
      private long A12estatusarticuloid ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtestatusarticuloid_Internalname ;
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
      private String edtestatusarticuloid_Jsonclick ;
      private String edtestatusarticulodsc_Internalname ;
      private String edtestatusarticulodsc_Jsonclick ;
      private String edtestatusarticulodescuso_Internalname ;
      private String edtestatusarticulodescuso_Jsonclick ;
      private String edtestatusarticuloaplicamov_Internalname ;
      private String edtestatusarticuloaplicamov_Jsonclick ;
      private String edtestatusarticulousotabla_Internalname ;
      private String edtestatusarticulousotabla_Jsonclick ;
      private String edtestatusarticulousuario_Internalname ;
      private String edtestatusarticulousuario_Jsonclick ;
      private String edtestatusarticulofecreg_Internalname ;
      private String edtestatusarticulofecreg_Jsonclick ;
      private String edtestatusarticulofecultact_Internalname ;
      private String edtestatusarticulofecultact_Jsonclick ;
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
      private String sMode7 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z59estatusarticulofecreg ;
      private DateTime Z60estatusarticulofecultact ;
      private DateTime A59estatusarticulofecreg ;
      private DateTime A60estatusarticulofecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n54estatusarticulodsc ;
      private bool n55estatusarticulodescuso ;
      private bool n56estatusarticuloaplicamov ;
      private bool n57estatusarticulousotabla ;
      private bool n58estatusarticulousuario ;
      private bool n59estatusarticulofecreg ;
      private bool n60estatusarticulofecultact ;
      private bool Gx_longc ;
      private String Z54estatusarticulodsc ;
      private String Z55estatusarticulodescuso ;
      private String Z57estatusarticulousotabla ;
      private String Z58estatusarticulousuario ;
      private String A54estatusarticulodsc ;
      private String A55estatusarticulodescuso ;
      private String A57estatusarticulousotabla ;
      private String A58estatusarticulousuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T00074_A12estatusarticuloid ;
      private String[] T00074_A54estatusarticulodsc ;
      private bool[] T00074_n54estatusarticulodsc ;
      private String[] T00074_A55estatusarticulodescuso ;
      private bool[] T00074_n55estatusarticulodescuso ;
      private int[] T00074_A56estatusarticuloaplicamov ;
      private bool[] T00074_n56estatusarticuloaplicamov ;
      private String[] T00074_A57estatusarticulousotabla ;
      private bool[] T00074_n57estatusarticulousotabla ;
      private String[] T00074_A58estatusarticulousuario ;
      private bool[] T00074_n58estatusarticulousuario ;
      private DateTime[] T00074_A59estatusarticulofecreg ;
      private bool[] T00074_n59estatusarticulofecreg ;
      private DateTime[] T00074_A60estatusarticulofecultact ;
      private bool[] T00074_n60estatusarticulofecultact ;
      private long[] T00075_A12estatusarticuloid ;
      private long[] T00073_A12estatusarticuloid ;
      private String[] T00073_A54estatusarticulodsc ;
      private bool[] T00073_n54estatusarticulodsc ;
      private String[] T00073_A55estatusarticulodescuso ;
      private bool[] T00073_n55estatusarticulodescuso ;
      private int[] T00073_A56estatusarticuloaplicamov ;
      private bool[] T00073_n56estatusarticuloaplicamov ;
      private String[] T00073_A57estatusarticulousotabla ;
      private bool[] T00073_n57estatusarticulousotabla ;
      private String[] T00073_A58estatusarticulousuario ;
      private bool[] T00073_n58estatusarticulousuario ;
      private DateTime[] T00073_A59estatusarticulofecreg ;
      private bool[] T00073_n59estatusarticulofecreg ;
      private DateTime[] T00073_A60estatusarticulofecultact ;
      private bool[] T00073_n60estatusarticulofecultact ;
      private long[] T00076_A12estatusarticuloid ;
      private long[] T00077_A12estatusarticuloid ;
      private long[] T00072_A12estatusarticuloid ;
      private String[] T00072_A54estatusarticulodsc ;
      private bool[] T00072_n54estatusarticulodsc ;
      private String[] T00072_A55estatusarticulodescuso ;
      private bool[] T00072_n55estatusarticulodescuso ;
      private int[] T00072_A56estatusarticuloaplicamov ;
      private bool[] T00072_n56estatusarticuloaplicamov ;
      private String[] T00072_A57estatusarticulousotabla ;
      private bool[] T00072_n57estatusarticulousotabla ;
      private String[] T00072_A58estatusarticulousuario ;
      private bool[] T00072_n58estatusarticulousuario ;
      private DateTime[] T00072_A59estatusarticulofecreg ;
      private bool[] T00072_n59estatusarticulofecreg ;
      private DateTime[] T00072_A60estatusarticulofecultact ;
      private bool[] T00072_n60estatusarticulofecultact ;
      private long[] T000711_A12estatusarticuloid ;
      private GXWebForm Form ;
   }

   public class estatusarticulo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"estatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"estatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"estatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"estatusarticulofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticulofecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"estatusarticulodsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticulodescuso",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"estatusarticuloaplicamov",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"estatusarticulousotabla",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"estatusarticulousuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"estatusarticulofecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticulofecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"estatusarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid  FOR UPDATE OF estatusarticulo NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT TM1.estatusarticuloid, TM1.estatusarticulodsc, TM1.estatusarticulodescuso, TM1.estatusarticuloaplicamov, TM1.estatusarticulousotabla, TM1.estatusarticulousuario, TM1.estatusarticulofecreg, TM1.estatusarticulofecultact FROM public.estatusarticulo TM1 WHERE TM1.estatusarticuloid = :estatusarticuloid ORDER BY TM1.estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100,0,true,false )
             ,new CursorDef("T00075", "SELECT estatusarticuloid FROM public.estatusarticulo WHERE estatusarticuloid = :estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,false )
             ,new CursorDef("T00076", "SELECT estatusarticuloid FROM public.estatusarticulo WHERE ( estatusarticuloid > :estatusarticuloid) ORDER BY estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,true )
             ,new CursorDef("T00077", "SELECT estatusarticuloid FROM public.estatusarticulo WHERE ( estatusarticuloid < :estatusarticuloid) ORDER BY estatusarticuloid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,true )
             ,new CursorDef("T00078", "SAVEPOINT gxupdate;INSERT INTO public.estatusarticulo(estatusarticuloid, estatusarticulodsc, estatusarticulodescuso, estatusarticuloaplicamov, estatusarticulousotabla, estatusarticulousuario, estatusarticulofecreg, estatusarticulofecultact) VALUES(:estatusarticuloid, :estatusarticulodsc, :estatusarticulodescuso, :estatusarticuloaplicamov, :estatusarticulousotabla, :estatusarticulousuario, :estatusarticulofecreg, :estatusarticulofecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00078)
             ,new CursorDef("T00079", "SAVEPOINT gxupdate;UPDATE public.estatusarticulo SET estatusarticulodsc=:estatusarticulodsc, estatusarticulodescuso=:estatusarticulodescuso, estatusarticuloaplicamov=:estatusarticuloaplicamov, estatusarticulousotabla=:estatusarticulousotabla, estatusarticulousuario=:estatusarticulousuario, estatusarticulofecreg=:estatusarticulofecreg, estatusarticulofecultact=:estatusarticulofecultact  WHERE estatusarticuloid = :estatusarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00079)
             ,new CursorDef("T000710", "SAVEPOINT gxupdate;DELETE FROM public.estatusarticulo  WHERE estatusarticuloid = :estatusarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000710)
             ,new CursorDef("T000711", "SELECT estatusarticuloid FROM public.estatusarticulo ORDER BY estatusarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 9 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
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
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
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
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
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
                stmt.SetParameter(8, (long)parms[14]);
                return;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
