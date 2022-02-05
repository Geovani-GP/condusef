/*
               File: articulosmov
        Description: articulosmov
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/5/2022 0:54:37.67
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
   public class articulosmov : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "articulosmov", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtarticulosmovid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public articulosmov( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public articulosmov( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "articulosmov", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_articulosmov.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ARTICULOSMOVID"+"'), id:'"+"ARTICULOSMOVID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOSMOVPRODUCTOID"+"'), id:'"+"ARTICULOSMOVPRODUCTOID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOSMOVCAMBSID"+"'), id:'"+"ARTICULOSMOVCAMBSID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOSMOVARTICULOID"+"'), id:'"+"ARTICULOSMOVARTICULOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovid_Internalname, "articulosmovid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3articulosmovid), 9, 0, ",", "")), ((edtarticulosmovid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3articulosmovid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A3articulosmovid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovproductoid_Internalname, "productoid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovproductoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4articulosmovproductoid), 9, 0, ",", "")), ((edtarticulosmovproductoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4articulosmovproductoid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A4articulosmovproductoid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovproductoid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovproductoid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovcambsid_Internalname, "cambsid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovcambsid_Internalname, A5articulosmovcambsid, StringUtil.RTrim( context.localUtil.Format( A5articulosmovcambsid, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovcambsid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovcambsid_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovarticuloid_Internalname, "articulosmovarticuloid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovarticuloid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6articulosmovarticuloid), 18, 0, ",", "")), ((edtarticulosmovarticuloid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6articulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A6articulosmovarticuloid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovarticuloid_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovarticuloid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovdepositario_Internalname, "articulosmovdepositario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovdepositario_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39articulosmovdepositario), 18, 0, ",", "")), ((edtarticulosmovdepositario_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A39articulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A39articulosmovdepositario), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovdepositario_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovdepositario_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovfechamov_Internalname, "articulosmovfechamov", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosmovfechamov_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosmovfechamov_Internalname, context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A40articulosmovfechamov, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovfechamov_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovfechamov_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
            GxWebStd.gx_bitmap( context, edtarticulosmovfechamov_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosmovfechamov_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovstatus_Internalname, "articulosmovstatus", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovstatus_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41articulosmovstatus), 18, 0, ",", "")), ((edtarticulosmovstatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A41articulosmovstatus), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A41articulosmovstatus), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovstatus_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovstatus_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovagregomovsist_Internalname, "articulosmovagregomovsist", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovagregomovsist_Internalname, A42articulosmovagregomovsist, StringUtil.RTrim( context.localUtil.Format( A42articulosmovagregomovsist, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovagregomovsist_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovagregomovsist_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovususuario_Internalname, "articulosmovususuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtarticulosmovususuario_Internalname, A43articulosmovususuario, StringUtil.RTrim( context.localUtil.Format( A43articulosmovususuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovususuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovususuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovfecreg_Internalname, "articulosmovfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosmovfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosmovfecreg_Internalname, context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A44articulosmovfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
            GxWebStd.gx_bitmap( context, edtarticulosmovfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosmovfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulosmov.htm");
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
            GxWebStd.gx_label_element( context, edtarticulosmovfecultact_Internalname, "articulosmovfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtarticulosmovfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtarticulosmovfecultact_Internalname, context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A45articulosmovfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtarticulosmovfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtarticulosmovfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_articulosmov.htm");
            GxWebStd.gx_bitmap( context, edtarticulosmovfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtarticulosmovfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_articulosmov.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_articulosmov.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosmovid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosmovid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSMOVID");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A3articulosmovid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
               }
               else
               {
                  A3articulosmovid = (int)(context.localUtil.CToN( cgiGet( edtarticulosmovid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosmovproductoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosmovproductoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSMOVPRODUCTOID");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovproductoid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A4articulosmovproductoid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
               }
               else
               {
                  A4articulosmovproductoid = (int)(context.localUtil.CToN( cgiGet( edtarticulosmovproductoid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
               }
               A5articulosmovcambsid = cgiGet( edtarticulosmovcambsid_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosmovarticuloid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosmovarticuloid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSMOVARTICULOID");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovarticuloid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6articulosmovarticuloid = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
               }
               else
               {
                  A6articulosmovarticuloid = (long)(context.localUtil.CToN( cgiGet( edtarticulosmovarticuloid_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosmovdepositario_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosmovdepositario_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSMOVDEPOSITARIO");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovdepositario_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A39articulosmovdepositario = 0;
                  n39articulosmovdepositario = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39articulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(A39articulosmovdepositario), 18, 0)));
               }
               else
               {
                  A39articulosmovdepositario = (long)(context.localUtil.CToN( cgiGet( edtarticulosmovdepositario_Internalname), ",", "."));
                  n39articulosmovdepositario = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39articulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(A39articulosmovdepositario), 18, 0)));
               }
               n39articulosmovdepositario = ((0==A39articulosmovdepositario) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosmovfechamov_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosmovfechamov"}), 1, "ARTICULOSMOVFECHAMOV");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovfechamov_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A40articulosmovfechamov = (DateTime)(DateTime.MinValue);
                  n40articulosmovfechamov = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40articulosmovfechamov", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A40articulosmovfechamov = context.localUtil.CToT( cgiGet( edtarticulosmovfechamov_Internalname));
                  n40articulosmovfechamov = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40articulosmovfechamov", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
               }
               n40articulosmovfechamov = ((DateTime.MinValue==A40articulosmovfechamov) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtarticulosmovstatus_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtarticulosmovstatus_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOSMOVSTATUS");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovstatus_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A41articulosmovstatus = 0;
                  n41articulosmovstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41articulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A41articulosmovstatus), 18, 0)));
               }
               else
               {
                  A41articulosmovstatus = (long)(context.localUtil.CToN( cgiGet( edtarticulosmovstatus_Internalname), ",", "."));
                  n41articulosmovstatus = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41articulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A41articulosmovstatus), 18, 0)));
               }
               n41articulosmovstatus = ((0==A41articulosmovstatus) ? true : false);
               A42articulosmovagregomovsist = cgiGet( edtarticulosmovagregomovsist_Internalname);
               n42articulosmovagregomovsist = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42articulosmovagregomovsist", A42articulosmovagregomovsist);
               n42articulosmovagregomovsist = (String.IsNullOrEmpty(StringUtil.RTrim( A42articulosmovagregomovsist)) ? true : false);
               A43articulosmovususuario = cgiGet( edtarticulosmovususuario_Internalname);
               n43articulosmovususuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43articulosmovususuario", A43articulosmovususuario);
               n43articulosmovususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A43articulosmovususuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosmovfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosmovfecreg"}), 1, "ARTICULOSMOVFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A44articulosmovfecreg = (DateTime)(DateTime.MinValue);
                  n44articulosmovfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44articulosmovfecreg", context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A44articulosmovfecreg = context.localUtil.CToT( cgiGet( edtarticulosmovfecreg_Internalname));
                  n44articulosmovfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44articulosmovfecreg", context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n44articulosmovfecreg = ((DateTime.MinValue==A44articulosmovfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtarticulosmovfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"articulosmovfecultact"}), 1, "ARTICULOSMOVFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A45articulosmovfecultact = (DateTime)(DateTime.MinValue);
                  n45articulosmovfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45articulosmovfecultact", context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A45articulosmovfecultact = context.localUtil.CToT( cgiGet( edtarticulosmovfecultact_Internalname));
                  n45articulosmovfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45articulosmovfecultact", context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n45articulosmovfecultact = ((DateTime.MinValue==A45articulosmovfecultact) ? true : false);
               /* Read saved values. */
               Z3articulosmovid = (int)(context.localUtil.CToN( cgiGet( "Z3articulosmovid"), ",", "."));
               Z4articulosmovproductoid = (int)(context.localUtil.CToN( cgiGet( "Z4articulosmovproductoid"), ",", "."));
               Z5articulosmovcambsid = cgiGet( "Z5articulosmovcambsid");
               Z6articulosmovarticuloid = (long)(context.localUtil.CToN( cgiGet( "Z6articulosmovarticuloid"), ",", "."));
               Z39articulosmovdepositario = (long)(context.localUtil.CToN( cgiGet( "Z39articulosmovdepositario"), ",", "."));
               n39articulosmovdepositario = ((0==A39articulosmovdepositario) ? true : false);
               Z40articulosmovfechamov = context.localUtil.CToT( cgiGet( "Z40articulosmovfechamov"), 0);
               n40articulosmovfechamov = ((DateTime.MinValue==A40articulosmovfechamov) ? true : false);
               Z41articulosmovstatus = (long)(context.localUtil.CToN( cgiGet( "Z41articulosmovstatus"), ",", "."));
               n41articulosmovstatus = ((0==A41articulosmovstatus) ? true : false);
               Z42articulosmovagregomovsist = cgiGet( "Z42articulosmovagregomovsist");
               n42articulosmovagregomovsist = (String.IsNullOrEmpty(StringUtil.RTrim( A42articulosmovagregomovsist)) ? true : false);
               Z43articulosmovususuario = cgiGet( "Z43articulosmovususuario");
               n43articulosmovususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A43articulosmovususuario)) ? true : false);
               Z44articulosmovfecreg = context.localUtil.CToT( cgiGet( "Z44articulosmovfecreg"), 0);
               n44articulosmovfecreg = ((DateTime.MinValue==A44articulosmovfecreg) ? true : false);
               Z45articulosmovfecultact = context.localUtil.CToT( cgiGet( "Z45articulosmovfecultact"), 0);
               n45articulosmovfecultact = ((DateTime.MinValue==A45articulosmovfecultact) ? true : false);
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
                  A3articulosmovid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
                  A4articulosmovproductoid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
                  A5articulosmovcambsid = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
                  A6articulosmovarticuloid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
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
               InitAll0D13( ) ;
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
         DisableAttributes0D13( ) ;
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

      protected void ResetCaption0D0( )
      {
      }

      protected void ZM0D13( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z39articulosmovdepositario = T000D3_A39articulosmovdepositario[0];
               Z40articulosmovfechamov = T000D3_A40articulosmovfechamov[0];
               Z41articulosmovstatus = T000D3_A41articulosmovstatus[0];
               Z42articulosmovagregomovsist = T000D3_A42articulosmovagregomovsist[0];
               Z43articulosmovususuario = T000D3_A43articulosmovususuario[0];
               Z44articulosmovfecreg = T000D3_A44articulosmovfecreg[0];
               Z45articulosmovfecultact = T000D3_A45articulosmovfecultact[0];
            }
            else
            {
               Z39articulosmovdepositario = A39articulosmovdepositario;
               Z40articulosmovfechamov = A40articulosmovfechamov;
               Z41articulosmovstatus = A41articulosmovstatus;
               Z42articulosmovagregomovsist = A42articulosmovagregomovsist;
               Z43articulosmovususuario = A43articulosmovususuario;
               Z44articulosmovfecreg = A44articulosmovfecreg;
               Z45articulosmovfecultact = A45articulosmovfecultact;
            }
         }
         if ( GX_JID == -1 )
         {
            Z3articulosmovid = A3articulosmovid;
            Z4articulosmovproductoid = A4articulosmovproductoid;
            Z5articulosmovcambsid = A5articulosmovcambsid;
            Z6articulosmovarticuloid = A6articulosmovarticuloid;
            Z39articulosmovdepositario = A39articulosmovdepositario;
            Z40articulosmovfechamov = A40articulosmovfechamov;
            Z41articulosmovstatus = A41articulosmovstatus;
            Z42articulosmovagregomovsist = A42articulosmovagregomovsist;
            Z43articulosmovususuario = A43articulosmovususuario;
            Z44articulosmovfecreg = A44articulosmovfecreg;
            Z45articulosmovfecultact = A45articulosmovfecultact;
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

      protected void Load0D13( )
      {
         /* Using cursor T000D4 */
         pr_default.execute(2, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound13 = 1;
            A39articulosmovdepositario = T000D4_A39articulosmovdepositario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39articulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(A39articulosmovdepositario), 18, 0)));
            n39articulosmovdepositario = T000D4_n39articulosmovdepositario[0];
            A40articulosmovfechamov = T000D4_A40articulosmovfechamov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40articulosmovfechamov", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
            n40articulosmovfechamov = T000D4_n40articulosmovfechamov[0];
            A41articulosmovstatus = T000D4_A41articulosmovstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41articulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A41articulosmovstatus), 18, 0)));
            n41articulosmovstatus = T000D4_n41articulosmovstatus[0];
            A42articulosmovagregomovsist = T000D4_A42articulosmovagregomovsist[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42articulosmovagregomovsist", A42articulosmovagregomovsist);
            n42articulosmovagregomovsist = T000D4_n42articulosmovagregomovsist[0];
            A43articulosmovususuario = T000D4_A43articulosmovususuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43articulosmovususuario", A43articulosmovususuario);
            n43articulosmovususuario = T000D4_n43articulosmovususuario[0];
            A44articulosmovfecreg = T000D4_A44articulosmovfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44articulosmovfecreg", context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
            n44articulosmovfecreg = T000D4_n44articulosmovfecreg[0];
            A45articulosmovfecultact = T000D4_A45articulosmovfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45articulosmovfecultact", context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
            n45articulosmovfecultact = T000D4_n45articulosmovfecultact[0];
            ZM0D13( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0D13( ) ;
      }

      protected void OnLoadActions0D13( )
      {
      }

      protected void CheckExtendedTable0D13( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0D13( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0D13( )
      {
         /* Using cursor T000D5 */
         pr_default.execute(3, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000D3 */
         pr_default.execute(1, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0D13( 1) ;
            RcdFound13 = 1;
            A3articulosmovid = T000D3_A3articulosmovid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
            A4articulosmovproductoid = T000D3_A4articulosmovproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
            A5articulosmovcambsid = T000D3_A5articulosmovcambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
            A6articulosmovarticuloid = T000D3_A6articulosmovarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
            A39articulosmovdepositario = T000D3_A39articulosmovdepositario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39articulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(A39articulosmovdepositario), 18, 0)));
            n39articulosmovdepositario = T000D3_n39articulosmovdepositario[0];
            A40articulosmovfechamov = T000D3_A40articulosmovfechamov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40articulosmovfechamov", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
            n40articulosmovfechamov = T000D3_n40articulosmovfechamov[0];
            A41articulosmovstatus = T000D3_A41articulosmovstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41articulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A41articulosmovstatus), 18, 0)));
            n41articulosmovstatus = T000D3_n41articulosmovstatus[0];
            A42articulosmovagregomovsist = T000D3_A42articulosmovagregomovsist[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42articulosmovagregomovsist", A42articulosmovagregomovsist);
            n42articulosmovagregomovsist = T000D3_n42articulosmovagregomovsist[0];
            A43articulosmovususuario = T000D3_A43articulosmovususuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43articulosmovususuario", A43articulosmovususuario);
            n43articulosmovususuario = T000D3_n43articulosmovususuario[0];
            A44articulosmovfecreg = T000D3_A44articulosmovfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44articulosmovfecreg", context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
            n44articulosmovfecreg = T000D3_n44articulosmovfecreg[0];
            A45articulosmovfecultact = T000D3_A45articulosmovfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45articulosmovfecultact", context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
            n45articulosmovfecultact = T000D3_n45articulosmovfecultact[0];
            Z3articulosmovid = A3articulosmovid;
            Z4articulosmovproductoid = A4articulosmovproductoid;
            Z5articulosmovcambsid = A5articulosmovcambsid;
            Z6articulosmovarticuloid = A6articulosmovarticuloid;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0D13( ) ;
            if ( AnyError == 1 )
            {
               RcdFound13 = 0;
               InitializeNonKey0D13( ) ;
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0D13( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0D13( ) ;
         if ( RcdFound13 == 0 )
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
         RcdFound13 = 0;
         /* Using cursor T000D6 */
         pr_default.execute(4, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A3articulosmovid[0] < A3articulosmovid ) || ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( T000D6_A4articulosmovproductoid[0] < A4articulosmovproductoid ) || ( T000D6_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( StringUtil.StrCmp(T000D6_A5articulosmovcambsid[0], A5articulosmovcambsid) < 0 ) || ( StringUtil.StrCmp(T000D6_A5articulosmovcambsid[0], A5articulosmovcambsid) == 0 ) && ( T000D6_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( T000D6_A6articulosmovarticuloid[0] < A6articulosmovarticuloid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A3articulosmovid[0] > A3articulosmovid ) || ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( T000D6_A4articulosmovproductoid[0] > A4articulosmovproductoid ) || ( T000D6_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( StringUtil.StrCmp(T000D6_A5articulosmovcambsid[0], A5articulosmovcambsid) > 0 ) || ( StringUtil.StrCmp(T000D6_A5articulosmovcambsid[0], A5articulosmovcambsid) == 0 ) && ( T000D6_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D6_A3articulosmovid[0] == A3articulosmovid ) && ( T000D6_A6articulosmovarticuloid[0] > A6articulosmovarticuloid ) ) )
            {
               A3articulosmovid = T000D6_A3articulosmovid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
               A4articulosmovproductoid = T000D6_A4articulosmovproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
               A5articulosmovcambsid = T000D6_A5articulosmovcambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
               A6articulosmovarticuloid = T000D6_A6articulosmovarticuloid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
               RcdFound13 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound13 = 0;
         /* Using cursor T000D7 */
         pr_default.execute(5, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A3articulosmovid[0] > A3articulosmovid ) || ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( T000D7_A4articulosmovproductoid[0] > A4articulosmovproductoid ) || ( T000D7_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( StringUtil.StrCmp(T000D7_A5articulosmovcambsid[0], A5articulosmovcambsid) > 0 ) || ( StringUtil.StrCmp(T000D7_A5articulosmovcambsid[0], A5articulosmovcambsid) == 0 ) && ( T000D7_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( T000D7_A6articulosmovarticuloid[0] > A6articulosmovarticuloid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A3articulosmovid[0] < A3articulosmovid ) || ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( T000D7_A4articulosmovproductoid[0] < A4articulosmovproductoid ) || ( T000D7_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( StringUtil.StrCmp(T000D7_A5articulosmovcambsid[0], A5articulosmovcambsid) < 0 ) || ( StringUtil.StrCmp(T000D7_A5articulosmovcambsid[0], A5articulosmovcambsid) == 0 ) && ( T000D7_A4articulosmovproductoid[0] == A4articulosmovproductoid ) && ( T000D7_A3articulosmovid[0] == A3articulosmovid ) && ( T000D7_A6articulosmovarticuloid[0] < A6articulosmovarticuloid ) ) )
            {
               A3articulosmovid = T000D7_A3articulosmovid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
               A4articulosmovproductoid = T000D7_A4articulosmovproductoid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
               A5articulosmovcambsid = T000D7_A5articulosmovcambsid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
               A6articulosmovarticuloid = T000D7_A6articulosmovarticuloid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
               RcdFound13 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0D13( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtarticulosmovid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0D13( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound13 == 1 )
            {
               if ( ( A3articulosmovid != Z3articulosmovid ) || ( A4articulosmovproductoid != Z4articulosmovproductoid ) || ( StringUtil.StrCmp(A5articulosmovcambsid, Z5articulosmovcambsid) != 0 ) || ( A6articulosmovarticuloid != Z6articulosmovarticuloid ) )
               {
                  A3articulosmovid = Z3articulosmovid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
                  A4articulosmovproductoid = Z4articulosmovproductoid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
                  A5articulosmovcambsid = Z5articulosmovcambsid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
                  A6articulosmovarticuloid = Z6articulosmovarticuloid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ARTICULOSMOVID");
                  AnyError = 1;
                  GX_FocusControl = edtarticulosmovid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtarticulosmovid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0D13( ) ;
                  GX_FocusControl = edtarticulosmovid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A3articulosmovid != Z3articulosmovid ) || ( A4articulosmovproductoid != Z4articulosmovproductoid ) || ( StringUtil.StrCmp(A5articulosmovcambsid, Z5articulosmovcambsid) != 0 ) || ( A6articulosmovarticuloid != Z6articulosmovarticuloid ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtarticulosmovid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0D13( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ARTICULOSMOVID");
                     AnyError = 1;
                     GX_FocusControl = edtarticulosmovid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtarticulosmovid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0D13( ) ;
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
         if ( ( A3articulosmovid != Z3articulosmovid ) || ( A4articulosmovproductoid != Z4articulosmovproductoid ) || ( StringUtil.StrCmp(A5articulosmovcambsid, Z5articulosmovcambsid) != 0 ) || ( A6articulosmovarticuloid != Z6articulosmovarticuloid ) )
         {
            A3articulosmovid = Z3articulosmovid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
            A4articulosmovproductoid = Z4articulosmovproductoid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
            A5articulosmovcambsid = Z5articulosmovcambsid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
            A6articulosmovarticuloid = Z6articulosmovarticuloid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ARTICULOSMOVID");
            AnyError = 1;
            GX_FocusControl = edtarticulosmovid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtarticulosmovid_Internalname;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ARTICULOSMOVID");
            AnyError = 1;
            GX_FocusControl = edtarticulosmovid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0D13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0D13( ) ;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
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
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
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
         ScanStart0D13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound13 != 0 )
            {
               ScanNext0D13( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0D13( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0D13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000D2 */
            pr_default.execute(0, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ARTíCULOSMOV"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z39articulosmovdepositario != T000D2_A39articulosmovdepositario[0] ) || ( Z40articulosmovfechamov != T000D2_A40articulosmovfechamov[0] ) || ( Z41articulosmovstatus != T000D2_A41articulosmovstatus[0] ) || ( StringUtil.StrCmp(Z42articulosmovagregomovsist, T000D2_A42articulosmovagregomovsist[0]) != 0 ) || ( StringUtil.StrCmp(Z43articulosmovususuario, T000D2_A43articulosmovususuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z44articulosmovfecreg != T000D2_A44articulosmovfecreg[0] ) || ( Z45articulosmovfecultact != T000D2_A45articulosmovfecultact[0] ) )
            {
               if ( Z39articulosmovdepositario != T000D2_A39articulosmovdepositario[0] )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovdepositario");
                  GXUtil.WriteLogRaw("Old: ",Z39articulosmovdepositario);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A39articulosmovdepositario[0]);
               }
               if ( Z40articulosmovfechamov != T000D2_A40articulosmovfechamov[0] )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovfechamov");
                  GXUtil.WriteLogRaw("Old: ",Z40articulosmovfechamov);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A40articulosmovfechamov[0]);
               }
               if ( Z41articulosmovstatus != T000D2_A41articulosmovstatus[0] )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovstatus");
                  GXUtil.WriteLogRaw("Old: ",Z41articulosmovstatus);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A41articulosmovstatus[0]);
               }
               if ( StringUtil.StrCmp(Z42articulosmovagregomovsist, T000D2_A42articulosmovagregomovsist[0]) != 0 )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovagregomovsist");
                  GXUtil.WriteLogRaw("Old: ",Z42articulosmovagregomovsist);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A42articulosmovagregomovsist[0]);
               }
               if ( StringUtil.StrCmp(Z43articulosmovususuario, T000D2_A43articulosmovususuario[0]) != 0 )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovususuario");
                  GXUtil.WriteLogRaw("Old: ",Z43articulosmovususuario);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A43articulosmovususuario[0]);
               }
               if ( Z44articulosmovfecreg != T000D2_A44articulosmovfecreg[0] )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z44articulosmovfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A44articulosmovfecreg[0]);
               }
               if ( Z45articulosmovfecultact != T000D2_A45articulosmovfecultact[0] )
               {
                  GXUtil.WriteLog("articulosmov:[seudo value changed for attri]"+"articulosmovfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z45articulosmovfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A45articulosmovfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ARTíCULOSMOV"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0D13( )
      {
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0D13( 0) ;
            CheckOptimisticConcurrency0D13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0D13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D8 */
                     pr_default.execute(6, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid, n39articulosmovdepositario, A39articulosmovdepositario, n40articulosmovfechamov, A40articulosmovfechamov, n41articulosmovstatus, A41articulosmovstatus, n42articulosmovagregomovsist, A42articulosmovagregomovsist, n43articulosmovususuario, A43articulosmovususuario, n44articulosmovfecreg, A44articulosmovfecreg, n45articulosmovfecultact, A45articulosmovfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ARTíCULOSMOV") ;
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
                           ResetCaption0D0( ) ;
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
               Load0D13( ) ;
            }
            EndLevel0D13( ) ;
         }
         CloseExtendedTableCursors0D13( ) ;
      }

      protected void Update0D13( )
      {
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0D13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D9 */
                     pr_default.execute(7, new Object[] {n39articulosmovdepositario, A39articulosmovdepositario, n40articulosmovfechamov, A40articulosmovfechamov, n41articulosmovstatus, A41articulosmovstatus, n42articulosmovagregomovsist, A42articulosmovagregomovsist, n43articulosmovususuario, A43articulosmovususuario, n44articulosmovfecreg, A44articulosmovfecreg, n45articulosmovfecultact, A45articulosmovfecultact, A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("ARTíCULOSMOV") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ARTíCULOSMOV"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0D13( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0D0( ) ;
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
            EndLevel0D13( ) ;
         }
         CloseExtendedTableCursors0D13( ) ;
      }

      protected void DeferredUpdate0D13( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0D13( ) ;
            AfterConfirm0D13( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0D13( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000D10 */
                  pr_default.execute(8, new Object[] {A3articulosmovid, A4articulosmovproductoid, A5articulosmovcambsid, A6articulosmovarticuloid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("ARTíCULOSMOV") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound13 == 0 )
                        {
                           InitAll0D13( ) ;
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
                        ResetCaption0D0( ) ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0D13( ) ;
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0D13( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0D13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "articulosmov");
            if ( AnyError == 0 )
            {
               ConfirmValues0D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "articulosmov");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0D13( )
      {
         /* Using cursor T000D11 */
         pr_default.execute(9);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound13 = 1;
            A3articulosmovid = T000D11_A3articulosmovid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
            A4articulosmovproductoid = T000D11_A4articulosmovproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
            A5articulosmovcambsid = T000D11_A5articulosmovcambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
            A6articulosmovarticuloid = T000D11_A6articulosmovarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0D13( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound13 = 1;
            A3articulosmovid = T000D11_A3articulosmovid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
            A4articulosmovproductoid = T000D11_A4articulosmovproductoid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
            A5articulosmovcambsid = T000D11_A5articulosmovcambsid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
            A6articulosmovarticuloid = T000D11_A6articulosmovarticuloid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
         }
      }

      protected void ScanEnd0D13( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0D13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0D13( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0D13( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0D13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0D13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0D13( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0D13( )
      {
         edtarticulosmovid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovid_Enabled), 5, 0)));
         edtarticulosmovproductoid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovproductoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovproductoid_Enabled), 5, 0)));
         edtarticulosmovcambsid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovcambsid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovcambsid_Enabled), 5, 0)));
         edtarticulosmovarticuloid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovarticuloid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovarticuloid_Enabled), 5, 0)));
         edtarticulosmovdepositario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovdepositario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovdepositario_Enabled), 5, 0)));
         edtarticulosmovfechamov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovfechamov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovfechamov_Enabled), 5, 0)));
         edtarticulosmovstatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovstatus_Enabled), 5, 0)));
         edtarticulosmovagregomovsist_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovagregomovsist_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovagregomovsist_Enabled), 5, 0)));
         edtarticulosmovususuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovususuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovususuario_Enabled), 5, 0)));
         edtarticulosmovfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovfecreg_Enabled), 5, 0)));
         edtarticulosmovfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtarticulosmovfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtarticulosmovfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0D0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2022250543857");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("articulosmov.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z3articulosmovid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3articulosmovid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z4articulosmovproductoid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4articulosmovproductoid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z5articulosmovcambsid", Z5articulosmovcambsid);
         GxWebStd.gx_hidden_field( context, "Z6articulosmovarticuloid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6articulosmovarticuloid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z39articulosmovdepositario", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39articulosmovdepositario), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z40articulosmovfechamov", context.localUtil.TToC( Z40articulosmovfechamov, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z41articulosmovstatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41articulosmovstatus), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42articulosmovagregomovsist", Z42articulosmovagregomovsist);
         GxWebStd.gx_hidden_field( context, "Z43articulosmovususuario", Z43articulosmovususuario);
         GxWebStd.gx_hidden_field( context, "Z44articulosmovfecreg", context.localUtil.TToC( Z44articulosmovfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z45articulosmovfecultact", context.localUtil.TToC( Z45articulosmovfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("articulosmov.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "articulosmov" ;
      }

      public override String GetPgmdesc( )
      {
         return "articulosmov" ;
      }

      protected void InitializeNonKey0D13( )
      {
         A39articulosmovdepositario = 0;
         n39articulosmovdepositario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39articulosmovdepositario", StringUtil.LTrim( StringUtil.Str( (decimal)(A39articulosmovdepositario), 18, 0)));
         n39articulosmovdepositario = ((0==A39articulosmovdepositario) ? true : false);
         A40articulosmovfechamov = (DateTime)(DateTime.MinValue);
         n40articulosmovfechamov = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40articulosmovfechamov", context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
         n40articulosmovfechamov = ((DateTime.MinValue==A40articulosmovfechamov) ? true : false);
         A41articulosmovstatus = 0;
         n41articulosmovstatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41articulosmovstatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A41articulosmovstatus), 18, 0)));
         n41articulosmovstatus = ((0==A41articulosmovstatus) ? true : false);
         A42articulosmovagregomovsist = "";
         n42articulosmovagregomovsist = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42articulosmovagregomovsist", A42articulosmovagregomovsist);
         n42articulosmovagregomovsist = (String.IsNullOrEmpty(StringUtil.RTrim( A42articulosmovagregomovsist)) ? true : false);
         A43articulosmovususuario = "";
         n43articulosmovususuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43articulosmovususuario", A43articulosmovususuario);
         n43articulosmovususuario = (String.IsNullOrEmpty(StringUtil.RTrim( A43articulosmovususuario)) ? true : false);
         A44articulosmovfecreg = (DateTime)(DateTime.MinValue);
         n44articulosmovfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44articulosmovfecreg", context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
         n44articulosmovfecreg = ((DateTime.MinValue==A44articulosmovfecreg) ? true : false);
         A45articulosmovfecultact = (DateTime)(DateTime.MinValue);
         n45articulosmovfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45articulosmovfecultact", context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
         n45articulosmovfecultact = ((DateTime.MinValue==A45articulosmovfecultact) ? true : false);
         Z39articulosmovdepositario = 0;
         Z40articulosmovfechamov = (DateTime)(DateTime.MinValue);
         Z41articulosmovstatus = 0;
         Z42articulosmovagregomovsist = "";
         Z43articulosmovususuario = "";
         Z44articulosmovfecreg = (DateTime)(DateTime.MinValue);
         Z45articulosmovfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0D13( )
      {
         A3articulosmovid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3articulosmovid", StringUtil.LTrim( StringUtil.Str( (decimal)(A3articulosmovid), 9, 0)));
         A4articulosmovproductoid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4articulosmovproductoid", StringUtil.LTrim( StringUtil.Str( (decimal)(A4articulosmovproductoid), 9, 0)));
         A5articulosmovcambsid = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5articulosmovcambsid", A5articulosmovcambsid);
         A6articulosmovarticuloid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6articulosmovarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(A6articulosmovarticuloid), 18, 0)));
         InitializeNonKey0D13( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0542765");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022250543862");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("articulosmov.js", "?2022250543862");
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
         edtarticulosmovid_Internalname = "ARTICULOSMOVID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovproductoid_Internalname = "ARTICULOSMOVPRODUCTOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovcambsid_Internalname = "ARTICULOSMOVCAMBSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovarticuloid_Internalname = "ARTICULOSMOVARTICULOID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovdepositario_Internalname = "ARTICULOSMOVDEPOSITARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovfechamov_Internalname = "ARTICULOSMOVFECHAMOV";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovstatus_Internalname = "ARTICULOSMOVSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovagregomovsist_Internalname = "ARTICULOSMOVAGREGOMOVSIST";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovususuario_Internalname = "ARTICULOSMOVUSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovfecreg_Internalname = "ARTICULOSMOVFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtarticulosmovfecultact_Internalname = "ARTICULOSMOVFECULTACT";
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
         Form.Caption = "articulosmov";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtarticulosmovfecultact_Jsonclick = "";
         edtarticulosmovfecultact_Enabled = 1;
         edtarticulosmovfecreg_Jsonclick = "";
         edtarticulosmovfecreg_Enabled = 1;
         edtarticulosmovususuario_Jsonclick = "";
         edtarticulosmovususuario_Enabled = 1;
         edtarticulosmovagregomovsist_Jsonclick = "";
         edtarticulosmovagregomovsist_Enabled = 1;
         edtarticulosmovstatus_Jsonclick = "";
         edtarticulosmovstatus_Enabled = 1;
         edtarticulosmovfechamov_Jsonclick = "";
         edtarticulosmovfechamov_Enabled = 1;
         edtarticulosmovdepositario_Jsonclick = "";
         edtarticulosmovdepositario_Enabled = 1;
         edtarticulosmovarticuloid_Jsonclick = "";
         edtarticulosmovarticuloid_Enabled = 1;
         edtarticulosmovcambsid_Jsonclick = "";
         edtarticulosmovcambsid_Enabled = 1;
         edtarticulosmovproductoid_Jsonclick = "";
         edtarticulosmovproductoid_Enabled = 1;
         edtarticulosmovid_Jsonclick = "";
         edtarticulosmovid_Enabled = 1;
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
         GX_FocusControl = edtarticulosmovdepositario_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Articulosmovarticuloid( int GX_Parm1 ,
                                                int GX_Parm2 ,
                                                String GX_Parm3 ,
                                                long GX_Parm4 ,
                                                long GX_Parm5 ,
                                                DateTime GX_Parm6 ,
                                                long GX_Parm7 ,
                                                String GX_Parm8 ,
                                                String GX_Parm9 ,
                                                DateTime GX_Parm10 ,
                                                DateTime GX_Parm11 )
      {
         A3articulosmovid = GX_Parm1;
         A4articulosmovproductoid = GX_Parm2;
         A5articulosmovcambsid = GX_Parm3;
         A6articulosmovarticuloid = GX_Parm4;
         A39articulosmovdepositario = GX_Parm5;
         n39articulosmovdepositario = false;
         A40articulosmovfechamov = GX_Parm6;
         n40articulosmovfechamov = false;
         A41articulosmovstatus = GX_Parm7;
         n41articulosmovstatus = false;
         A42articulosmovagregomovsist = GX_Parm8;
         n42articulosmovagregomovsist = false;
         A43articulosmovususuario = GX_Parm9;
         n43articulosmovususuario = false;
         A44articulosmovfecreg = GX_Parm10;
         n44articulosmovfecreg = false;
         A45articulosmovfecultact = GX_Parm11;
         n45articulosmovfecultact = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A39articulosmovdepositario), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.TToC( A40articulosmovfechamov, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A41articulosmovstatus), 18, 0, ".", "")));
         isValidOutput.Add(A42articulosmovagregomovsist);
         isValidOutput.Add(A43articulosmovususuario);
         isValidOutput.Add(context.localUtil.TToC( A44articulosmovfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A45articulosmovfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3articulosmovid), 9, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4articulosmovproductoid), 9, 0, ",", "")));
         isValidOutput.Add(Z5articulosmovcambsid);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6articulosmovarticuloid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39articulosmovdepositario), 18, 0, ",", "")));
         isValidOutput.Add(context.localUtil.TToC( Z40articulosmovfechamov, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41articulosmovstatus), 18, 0, ",", "")));
         isValidOutput.Add(Z42articulosmovagregomovsist);
         isValidOutput.Add(Z43articulosmovususuario);
         isValidOutput.Add(context.localUtil.TToC( Z44articulosmovfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z45articulosmovfecultact, 10, 8, 0, 0, "/", ":", " "));
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
         Z5articulosmovcambsid = "";
         Z40articulosmovfechamov = (DateTime)(DateTime.MinValue);
         Z42articulosmovagregomovsist = "";
         Z43articulosmovususuario = "";
         Z44articulosmovfecreg = (DateTime)(DateTime.MinValue);
         Z45articulosmovfecultact = (DateTime)(DateTime.MinValue);
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
         A5articulosmovcambsid = "";
         A40articulosmovfechamov = (DateTime)(DateTime.MinValue);
         A42articulosmovagregomovsist = "";
         A43articulosmovususuario = "";
         A44articulosmovfecreg = (DateTime)(DateTime.MinValue);
         A45articulosmovfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000D4_A3articulosmovid = new int[1] ;
         T000D4_A4articulosmovproductoid = new int[1] ;
         T000D4_A5articulosmovcambsid = new String[] {""} ;
         T000D4_A6articulosmovarticuloid = new long[1] ;
         T000D4_A39articulosmovdepositario = new long[1] ;
         T000D4_n39articulosmovdepositario = new bool[] {false} ;
         T000D4_A40articulosmovfechamov = new DateTime[] {DateTime.MinValue} ;
         T000D4_n40articulosmovfechamov = new bool[] {false} ;
         T000D4_A41articulosmovstatus = new long[1] ;
         T000D4_n41articulosmovstatus = new bool[] {false} ;
         T000D4_A42articulosmovagregomovsist = new String[] {""} ;
         T000D4_n42articulosmovagregomovsist = new bool[] {false} ;
         T000D4_A43articulosmovususuario = new String[] {""} ;
         T000D4_n43articulosmovususuario = new bool[] {false} ;
         T000D4_A44articulosmovfecreg = new DateTime[] {DateTime.MinValue} ;
         T000D4_n44articulosmovfecreg = new bool[] {false} ;
         T000D4_A45articulosmovfecultact = new DateTime[] {DateTime.MinValue} ;
         T000D4_n45articulosmovfecultact = new bool[] {false} ;
         T000D5_A3articulosmovid = new int[1] ;
         T000D5_A4articulosmovproductoid = new int[1] ;
         T000D5_A5articulosmovcambsid = new String[] {""} ;
         T000D5_A6articulosmovarticuloid = new long[1] ;
         T000D3_A3articulosmovid = new int[1] ;
         T000D3_A4articulosmovproductoid = new int[1] ;
         T000D3_A5articulosmovcambsid = new String[] {""} ;
         T000D3_A6articulosmovarticuloid = new long[1] ;
         T000D3_A39articulosmovdepositario = new long[1] ;
         T000D3_n39articulosmovdepositario = new bool[] {false} ;
         T000D3_A40articulosmovfechamov = new DateTime[] {DateTime.MinValue} ;
         T000D3_n40articulosmovfechamov = new bool[] {false} ;
         T000D3_A41articulosmovstatus = new long[1] ;
         T000D3_n41articulosmovstatus = new bool[] {false} ;
         T000D3_A42articulosmovagregomovsist = new String[] {""} ;
         T000D3_n42articulosmovagregomovsist = new bool[] {false} ;
         T000D3_A43articulosmovususuario = new String[] {""} ;
         T000D3_n43articulosmovususuario = new bool[] {false} ;
         T000D3_A44articulosmovfecreg = new DateTime[] {DateTime.MinValue} ;
         T000D3_n44articulosmovfecreg = new bool[] {false} ;
         T000D3_A45articulosmovfecultact = new DateTime[] {DateTime.MinValue} ;
         T000D3_n45articulosmovfecultact = new bool[] {false} ;
         sMode13 = "";
         T000D6_A3articulosmovid = new int[1] ;
         T000D6_A4articulosmovproductoid = new int[1] ;
         T000D6_A5articulosmovcambsid = new String[] {""} ;
         T000D6_A6articulosmovarticuloid = new long[1] ;
         T000D7_A3articulosmovid = new int[1] ;
         T000D7_A4articulosmovproductoid = new int[1] ;
         T000D7_A5articulosmovcambsid = new String[] {""} ;
         T000D7_A6articulosmovarticuloid = new long[1] ;
         T000D2_A3articulosmovid = new int[1] ;
         T000D2_A4articulosmovproductoid = new int[1] ;
         T000D2_A5articulosmovcambsid = new String[] {""} ;
         T000D2_A6articulosmovarticuloid = new long[1] ;
         T000D2_A39articulosmovdepositario = new long[1] ;
         T000D2_n39articulosmovdepositario = new bool[] {false} ;
         T000D2_A40articulosmovfechamov = new DateTime[] {DateTime.MinValue} ;
         T000D2_n40articulosmovfechamov = new bool[] {false} ;
         T000D2_A41articulosmovstatus = new long[1] ;
         T000D2_n41articulosmovstatus = new bool[] {false} ;
         T000D2_A42articulosmovagregomovsist = new String[] {""} ;
         T000D2_n42articulosmovagregomovsist = new bool[] {false} ;
         T000D2_A43articulosmovususuario = new String[] {""} ;
         T000D2_n43articulosmovususuario = new bool[] {false} ;
         T000D2_A44articulosmovfecreg = new DateTime[] {DateTime.MinValue} ;
         T000D2_n44articulosmovfecreg = new bool[] {false} ;
         T000D2_A45articulosmovfecultact = new DateTime[] {DateTime.MinValue} ;
         T000D2_n45articulosmovfecultact = new bool[] {false} ;
         T000D11_A3articulosmovid = new int[1] ;
         T000D11_A4articulosmovproductoid = new int[1] ;
         T000D11_A5articulosmovcambsid = new String[] {""} ;
         T000D11_A6articulosmovarticuloid = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.articulosmov__default(),
            new Object[][] {
                new Object[] {
               T000D2_A3articulosmovid, T000D2_A4articulosmovproductoid, T000D2_A5articulosmovcambsid, T000D2_A6articulosmovarticuloid, T000D2_A39articulosmovdepositario, T000D2_n39articulosmovdepositario, T000D2_A40articulosmovfechamov, T000D2_n40articulosmovfechamov, T000D2_A41articulosmovstatus, T000D2_n41articulosmovstatus,
               T000D2_A42articulosmovagregomovsist, T000D2_n42articulosmovagregomovsist, T000D2_A43articulosmovususuario, T000D2_n43articulosmovususuario, T000D2_A44articulosmovfecreg, T000D2_n44articulosmovfecreg, T000D2_A45articulosmovfecultact, T000D2_n45articulosmovfecultact
               }
               , new Object[] {
               T000D3_A3articulosmovid, T000D3_A4articulosmovproductoid, T000D3_A5articulosmovcambsid, T000D3_A6articulosmovarticuloid, T000D3_A39articulosmovdepositario, T000D3_n39articulosmovdepositario, T000D3_A40articulosmovfechamov, T000D3_n40articulosmovfechamov, T000D3_A41articulosmovstatus, T000D3_n41articulosmovstatus,
               T000D3_A42articulosmovagregomovsist, T000D3_n42articulosmovagregomovsist, T000D3_A43articulosmovususuario, T000D3_n43articulosmovususuario, T000D3_A44articulosmovfecreg, T000D3_n44articulosmovfecreg, T000D3_A45articulosmovfecultact, T000D3_n45articulosmovfecultact
               }
               , new Object[] {
               T000D4_A3articulosmovid, T000D4_A4articulosmovproductoid, T000D4_A5articulosmovcambsid, T000D4_A6articulosmovarticuloid, T000D4_A39articulosmovdepositario, T000D4_n39articulosmovdepositario, T000D4_A40articulosmovfechamov, T000D4_n40articulosmovfechamov, T000D4_A41articulosmovstatus, T000D4_n41articulosmovstatus,
               T000D4_A42articulosmovagregomovsist, T000D4_n42articulosmovagregomovsist, T000D4_A43articulosmovususuario, T000D4_n43articulosmovususuario, T000D4_A44articulosmovfecreg, T000D4_n44articulosmovfecreg, T000D4_A45articulosmovfecultact, T000D4_n45articulosmovfecultact
               }
               , new Object[] {
               T000D5_A3articulosmovid, T000D5_A4articulosmovproductoid, T000D5_A5articulosmovcambsid, T000D5_A6articulosmovarticuloid
               }
               , new Object[] {
               T000D6_A3articulosmovid, T000D6_A4articulosmovproductoid, T000D6_A5articulosmovcambsid, T000D6_A6articulosmovarticuloid
               }
               , new Object[] {
               T000D7_A3articulosmovid, T000D7_A4articulosmovproductoid, T000D7_A5articulosmovcambsid, T000D7_A6articulosmovarticuloid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000D11_A3articulosmovid, T000D11_A4articulosmovproductoid, T000D11_A5articulosmovcambsid, T000D11_A6articulosmovarticuloid
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
      private short RcdFound13 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z3articulosmovid ;
      private int Z4articulosmovproductoid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A3articulosmovid ;
      private int edtarticulosmovid_Enabled ;
      private int A4articulosmovproductoid ;
      private int edtarticulosmovproductoid_Enabled ;
      private int edtarticulosmovcambsid_Enabled ;
      private int edtarticulosmovarticuloid_Enabled ;
      private int edtarticulosmovdepositario_Enabled ;
      private int edtarticulosmovfechamov_Enabled ;
      private int edtarticulosmovstatus_Enabled ;
      private int edtarticulosmovagregomovsist_Enabled ;
      private int edtarticulosmovususuario_Enabled ;
      private int edtarticulosmovfecreg_Enabled ;
      private int edtarticulosmovfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z6articulosmovarticuloid ;
      private long Z39articulosmovdepositario ;
      private long Z41articulosmovstatus ;
      private long A6articulosmovarticuloid ;
      private long A39articulosmovdepositario ;
      private long A41articulosmovstatus ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtarticulosmovid_Internalname ;
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
      private String edtarticulosmovid_Jsonclick ;
      private String edtarticulosmovproductoid_Internalname ;
      private String edtarticulosmovproductoid_Jsonclick ;
      private String edtarticulosmovcambsid_Internalname ;
      private String edtarticulosmovcambsid_Jsonclick ;
      private String edtarticulosmovarticuloid_Internalname ;
      private String edtarticulosmovarticuloid_Jsonclick ;
      private String edtarticulosmovdepositario_Internalname ;
      private String edtarticulosmovdepositario_Jsonclick ;
      private String edtarticulosmovfechamov_Internalname ;
      private String edtarticulosmovfechamov_Jsonclick ;
      private String edtarticulosmovstatus_Internalname ;
      private String edtarticulosmovstatus_Jsonclick ;
      private String edtarticulosmovagregomovsist_Internalname ;
      private String edtarticulosmovagregomovsist_Jsonclick ;
      private String edtarticulosmovususuario_Internalname ;
      private String edtarticulosmovususuario_Jsonclick ;
      private String edtarticulosmovfecreg_Internalname ;
      private String edtarticulosmovfecreg_Jsonclick ;
      private String edtarticulosmovfecultact_Internalname ;
      private String edtarticulosmovfecultact_Jsonclick ;
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
      private String sMode13 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z40articulosmovfechamov ;
      private DateTime Z44articulosmovfecreg ;
      private DateTime Z45articulosmovfecultact ;
      private DateTime A40articulosmovfechamov ;
      private DateTime A44articulosmovfecreg ;
      private DateTime A45articulosmovfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n39articulosmovdepositario ;
      private bool n40articulosmovfechamov ;
      private bool n41articulosmovstatus ;
      private bool n42articulosmovagregomovsist ;
      private bool n43articulosmovususuario ;
      private bool n44articulosmovfecreg ;
      private bool n45articulosmovfecultact ;
      private bool Gx_longc ;
      private String Z5articulosmovcambsid ;
      private String Z42articulosmovagregomovsist ;
      private String Z43articulosmovususuario ;
      private String A5articulosmovcambsid ;
      private String A42articulosmovagregomovsist ;
      private String A43articulosmovususuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000D4_A3articulosmovid ;
      private int[] T000D4_A4articulosmovproductoid ;
      private String[] T000D4_A5articulosmovcambsid ;
      private long[] T000D4_A6articulosmovarticuloid ;
      private long[] T000D4_A39articulosmovdepositario ;
      private bool[] T000D4_n39articulosmovdepositario ;
      private DateTime[] T000D4_A40articulosmovfechamov ;
      private bool[] T000D4_n40articulosmovfechamov ;
      private long[] T000D4_A41articulosmovstatus ;
      private bool[] T000D4_n41articulosmovstatus ;
      private String[] T000D4_A42articulosmovagregomovsist ;
      private bool[] T000D4_n42articulosmovagregomovsist ;
      private String[] T000D4_A43articulosmovususuario ;
      private bool[] T000D4_n43articulosmovususuario ;
      private DateTime[] T000D4_A44articulosmovfecreg ;
      private bool[] T000D4_n44articulosmovfecreg ;
      private DateTime[] T000D4_A45articulosmovfecultact ;
      private bool[] T000D4_n45articulosmovfecultact ;
      private int[] T000D5_A3articulosmovid ;
      private int[] T000D5_A4articulosmovproductoid ;
      private String[] T000D5_A5articulosmovcambsid ;
      private long[] T000D5_A6articulosmovarticuloid ;
      private int[] T000D3_A3articulosmovid ;
      private int[] T000D3_A4articulosmovproductoid ;
      private String[] T000D3_A5articulosmovcambsid ;
      private long[] T000D3_A6articulosmovarticuloid ;
      private long[] T000D3_A39articulosmovdepositario ;
      private bool[] T000D3_n39articulosmovdepositario ;
      private DateTime[] T000D3_A40articulosmovfechamov ;
      private bool[] T000D3_n40articulosmovfechamov ;
      private long[] T000D3_A41articulosmovstatus ;
      private bool[] T000D3_n41articulosmovstatus ;
      private String[] T000D3_A42articulosmovagregomovsist ;
      private bool[] T000D3_n42articulosmovagregomovsist ;
      private String[] T000D3_A43articulosmovususuario ;
      private bool[] T000D3_n43articulosmovususuario ;
      private DateTime[] T000D3_A44articulosmovfecreg ;
      private bool[] T000D3_n44articulosmovfecreg ;
      private DateTime[] T000D3_A45articulosmovfecultact ;
      private bool[] T000D3_n45articulosmovfecultact ;
      private int[] T000D6_A3articulosmovid ;
      private int[] T000D6_A4articulosmovproductoid ;
      private String[] T000D6_A5articulosmovcambsid ;
      private long[] T000D6_A6articulosmovarticuloid ;
      private int[] T000D7_A3articulosmovid ;
      private int[] T000D7_A4articulosmovproductoid ;
      private String[] T000D7_A5articulosmovcambsid ;
      private long[] T000D7_A6articulosmovarticuloid ;
      private int[] T000D2_A3articulosmovid ;
      private int[] T000D2_A4articulosmovproductoid ;
      private String[] T000D2_A5articulosmovcambsid ;
      private long[] T000D2_A6articulosmovarticuloid ;
      private long[] T000D2_A39articulosmovdepositario ;
      private bool[] T000D2_n39articulosmovdepositario ;
      private DateTime[] T000D2_A40articulosmovfechamov ;
      private bool[] T000D2_n40articulosmovfechamov ;
      private long[] T000D2_A41articulosmovstatus ;
      private bool[] T000D2_n41articulosmovstatus ;
      private String[] T000D2_A42articulosmovagregomovsist ;
      private bool[] T000D2_n42articulosmovagregomovsist ;
      private String[] T000D2_A43articulosmovususuario ;
      private bool[] T000D2_n43articulosmovususuario ;
      private DateTime[] T000D2_A44articulosmovfecreg ;
      private bool[] T000D2_n44articulosmovfecreg ;
      private DateTime[] T000D2_A45articulosmovfecultact ;
      private bool[] T000D2_n45articulosmovfecultact ;
      private int[] T000D11_A3articulosmovid ;
      private int[] T000D11_A4articulosmovproductoid ;
      private String[] T000D11_A5articulosmovcambsid ;
      private long[] T000D11_A6articulosmovarticuloid ;
      private GXWebForm Form ;
   }

   public class articulosmov__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000D4 ;
          prmT000D4 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D5 ;
          prmT000D5 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D3 ;
          prmT000D3 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D6 ;
          prmT000D6 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D7 ;
          prmT000D7 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D2 ;
          prmT000D2 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D8 ;
          prmT000D8 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosmovdepositario",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosmovfechamov",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosmovstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosmovagregomovsist",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"articulosmovususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"articulosmovfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosmovfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000D9 ;
          prmT000D9 = new Object[] {
          new Object[] {"articulosmovdepositario",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosmovfechamov",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosmovstatus",NpgsqlDbType.Real,18,0} ,
          new Object[] {"articulosmovagregomovsist",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"articulosmovususuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"articulosmovfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosmovfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D10 ;
          prmT000D10 = new Object[] {
          new Object[] {"articulosmovid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovproductoid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"articulosmovcambsid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"articulosmovarticuloid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000D11 ;
          prmT000D11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000D2", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid, articulosmovdepositario, articulosmovfechamov, articulosmovstatus, articulosmovagregomovsist, articulosmovususuario, articulosmovfecreg, articulosmovfecultact FROM public.artículosmov WHERE articulosmovid = :articulosmovid AND productoid = :articulosmovproductoid AND cambsid = :articulosmovcambsid AND articulosmovarticuloid = :articulosmovarticuloid  FOR UPDATE OF artículosmov NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000D2,1,0,true,false )
             ,new CursorDef("T000D3", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid, articulosmovdepositario, articulosmovfechamov, articulosmovstatus, articulosmovagregomovsist, articulosmovususuario, articulosmovfecreg, articulosmovfecultact FROM public.artículosmov WHERE articulosmovid = :articulosmovid AND productoid = :articulosmovproductoid AND cambsid = :articulosmovcambsid AND articulosmovarticuloid = :articulosmovarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D3,1,0,true,false )
             ,new CursorDef("T000D4", "SELECT TM1.articulosmovid, TM1.productoid, TM1.cambsid, TM1.articulosmovarticuloid, TM1.articulosmovdepositario, TM1.articulosmovfechamov, TM1.articulosmovstatus, TM1.articulosmovagregomovsist, TM1.articulosmovususuario, TM1.articulosmovfecreg, TM1.articulosmovfecultact FROM public.artículosmov TM1 WHERE TM1.articulosmovid = :articulosmovid and TM1.productoid = :articulosmovproductoid and TM1.cambsid = ( :articulosmovcambsid) and TM1.articulosmovarticuloid = :articulosmovarticuloid ORDER BY TM1.articulosmovid, TM1.productoid, TM1.cambsid, TM1.articulosmovarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D4,100,0,true,false )
             ,new CursorDef("T000D5", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid FROM public.artículosmov WHERE articulosmovid = :articulosmovid AND productoid = :articulosmovproductoid AND cambsid = :articulosmovcambsid AND articulosmovarticuloid = :articulosmovarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D5,1,0,true,false )
             ,new CursorDef("T000D6", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid FROM public.artículosmov WHERE ( articulosmovid > :articulosmovid or articulosmovid = :articulosmovid and productoid > :articulosmovproductoid or productoid = :articulosmovproductoid and articulosmovid = :articulosmovid and cambsid > ( :articulosmovcambsid) or cambsid = ( :articulosmovcambsid) and productoid = :articulosmovproductoid and articulosmovid = :articulosmovid and articulosmovarticuloid > :articulosmovarticuloid) ORDER BY articulosmovid, productoid, cambsid, articulosmovarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D6,1,0,true,true )
             ,new CursorDef("T000D7", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid FROM public.artículosmov WHERE ( articulosmovid < :articulosmovid or articulosmovid = :articulosmovid and productoid < :articulosmovproductoid or productoid = :articulosmovproductoid and articulosmovid = :articulosmovid and cambsid < ( :articulosmovcambsid) or cambsid = ( :articulosmovcambsid) and productoid = :articulosmovproductoid and articulosmovid = :articulosmovid and articulosmovarticuloid < :articulosmovarticuloid) ORDER BY articulosmovid DESC, productoid DESC, cambsid DESC, articulosmovarticuloid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D7,1,0,true,true )
             ,new CursorDef("T000D8", "SAVEPOINT gxupdate;INSERT INTO public.artículosmov(articulosmovid, productoid, cambsid, articulosmovarticuloid, articulosmovdepositario, articulosmovfechamov, articulosmovstatus, articulosmovagregomovsist, articulosmovususuario, articulosmovfecreg, articulosmovfecultact) VALUES(:articulosmovid, :articulosmovproductoid, :articulosmovcambsid, :articulosmovarticuloid, :articulosmovdepositario, :articulosmovfechamov, :articulosmovstatus, :articulosmovagregomovsist, :articulosmovususuario, :articulosmovfecreg, :articulosmovfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000D8)
             ,new CursorDef("T000D9", "SAVEPOINT gxupdate;UPDATE public.artículosmov SET articulosmovdepositario=:articulosmovdepositario, articulosmovfechamov=:articulosmovfechamov, articulosmovstatus=:articulosmovstatus, articulosmovagregomovsist=:articulosmovagregomovsist, articulosmovususuario=:articulosmovususuario, articulosmovfecreg=:articulosmovfecreg, articulosmovfecultact=:articulosmovfecultact  WHERE articulosmovid = :articulosmovid AND productoid = :articulosmovproductoid AND cambsid = :articulosmovcambsid AND articulosmovarticuloid = :articulosmovarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000D9)
             ,new CursorDef("T000D10", "SAVEPOINT gxupdate;DELETE FROM public.artículosmov  WHERE articulosmovid = :articulosmovid AND productoid = :articulosmovproductoid AND cambsid = :articulosmovcambsid AND articulosmovarticuloid = :articulosmovarticuloid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000D10)
             ,new CursorDef("T000D11", "SELECT articulosmovid, productoid, cambsid, articulosmovarticuloid FROM public.artículosmov ORDER BY articulosmovid, productoid, cambsid, articulosmovarticuloid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D11,100,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((long[]) buf[8])[0] = rslt.getLong(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((String[]) buf[10])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((long[]) buf[8])[0] = rslt.getLong(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((String[]) buf[10])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((long[]) buf[8])[0] = rslt.getLong(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((String[]) buf[10])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(11, (DateTime)parms[17]);
                }
                return;
             case 7 :
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(2, (DateTime)parms[3]);
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
                stmt.SetParameter(8, (int)parms[14]);
                stmt.SetParameter(9, (int)parms[15]);
                stmt.SetParameter(10, (String)parms[16]);
                stmt.SetParameter(11, (long)parms[17]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                return;
       }
    }

 }

}
