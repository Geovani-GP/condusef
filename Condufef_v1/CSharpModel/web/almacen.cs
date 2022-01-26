/*
               File: almacen
        Description: almacen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/25/2022 17:34:49.91
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
   public class almacen : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A13empleadosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n13empleadosid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A13empleadosid) ;
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
            Form.Meta.addItem("description", "almacen", 0) ;
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

      public almacen( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public almacen( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "almacen", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_almacen.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ALMACENID"+"'), id:'"+"ALMACENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenid_Internalname, "articuloid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19almacenid), 18, 0, ",", "")), ((edtalmacenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A19almacenid), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosid_Internalname, "empleadosid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")), ((edtempleadosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosid_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_almacen.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgprompt_13_Internalname, context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )), imgprompt_13_Link, "", "", context.GetTheme( ), imgprompt_13_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacendsc_Internalname, "almacendsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacendsc_Internalname, A143almacendsc, StringUtil.RTrim( context.localUtil.Format( A143almacendsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacendsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacendsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacendireccion_Internalname, "almacendireccion", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacendireccion_Internalname, A144almacendireccion, StringUtil.RTrim( context.localUtil.Format( A144almacendireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacendireccion_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacendireccion_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacencolonia_Internalname, "almacencolonia", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacencolonia_Internalname, A145almacencolonia, StringUtil.RTrim( context.localUtil.Format( A145almacencolonia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacencolonia_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacencolonia_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenmunicipio_Internalname, "almacenmunicipio", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacenmunicipio_Internalname, A146almacenmunicipio, StringUtil.RTrim( context.localUtil.Format( A146almacenmunicipio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenmunicipio_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenmunicipio_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalamcenestado_Internalname, "alamcenestado", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalamcenestado_Internalname, A147alamcenestado, StringUtil.RTrim( context.localUtil.Format( A147alamcenestado, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalamcenestado_Jsonclick, 0, "Attribute", "", "", "", 1, edtalamcenestado_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalamcencodigopostal_Internalname, "alamcencodigopostal", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalamcencodigopostal_Internalname, A148alamcencodigopostal, StringUtil.RTrim( context.localUtil.Format( A148alamcencodigopostal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalamcencodigopostal_Jsonclick, 0, "Attribute", "", "", "", 1, edtalamcencodigopostal_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacentelefono_Internalname, "almacentelefono", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalmacentelefono_Internalname, A149almacentelefono, StringUtil.RTrim( context.localUtil.Format( A149almacentelefono, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacentelefono_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacentelefono_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalamcenobservaciones_Internalname, "alamcenobservaciones", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalamcenobservaciones_Internalname, A150alamcenobservaciones, StringUtil.RTrim( context.localUtil.Format( A150alamcenobservaciones, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalamcenobservaciones_Jsonclick, 0, "Attribute", "", "", "", 1, edtalamcenobservaciones_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalamcenusuario_Internalname, "alamcenusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtalamcenusuario_Internalname, A151alamcenusuario, StringUtil.RTrim( context.localUtil.Format( A151alamcenusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalamcenusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtalamcenusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenfecreg_Internalname, "almacenfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtalmacenfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtalmacenfecreg_Internalname, context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A152almacenfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_almacen.htm");
            GxWebStd.gx_bitmap( context, edtalmacenfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtalmacenfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_almacen.htm");
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
            GxWebStd.gx_label_element( context, edtalmacenfecultact_Internalname, "almacenfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtalmacenfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtalmacenfecultact_Internalname, context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A153almacenfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtalmacenfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtalmacenfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_almacen.htm");
            GxWebStd.gx_bitmap( context, edtalmacenfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtalmacenfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_almacen.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_almacen.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EMPLEADOSID");
                  AnyError = 1;
                  GX_FocusControl = edtempleadosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A13empleadosid = 0;
                  n13empleadosid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               }
               else
               {
                  A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
                  n13empleadosid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               }
               n13empleadosid = ((0==A13empleadosid) ? true : false);
               A143almacendsc = cgiGet( edtalmacendsc_Internalname);
               n143almacendsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143almacendsc", A143almacendsc);
               n143almacendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A143almacendsc)) ? true : false);
               A144almacendireccion = cgiGet( edtalmacendireccion_Internalname);
               n144almacendireccion = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144almacendireccion", A144almacendireccion);
               n144almacendireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A144almacendireccion)) ? true : false);
               A145almacencolonia = cgiGet( edtalmacencolonia_Internalname);
               n145almacencolonia = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145almacencolonia", A145almacencolonia);
               n145almacencolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A145almacencolonia)) ? true : false);
               A146almacenmunicipio = cgiGet( edtalmacenmunicipio_Internalname);
               n146almacenmunicipio = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146almacenmunicipio", A146almacenmunicipio);
               n146almacenmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A146almacenmunicipio)) ? true : false);
               A147alamcenestado = cgiGet( edtalamcenestado_Internalname);
               n147alamcenestado = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147alamcenestado", A147alamcenestado);
               n147alamcenestado = (String.IsNullOrEmpty(StringUtil.RTrim( A147alamcenestado)) ? true : false);
               A148alamcencodigopostal = cgiGet( edtalamcencodigopostal_Internalname);
               n148alamcencodigopostal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A148alamcencodigopostal", A148alamcencodigopostal);
               n148alamcencodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A148alamcencodigopostal)) ? true : false);
               A149almacentelefono = cgiGet( edtalmacentelefono_Internalname);
               n149almacentelefono = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A149almacentelefono", A149almacentelefono);
               n149almacentelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A149almacentelefono)) ? true : false);
               A150alamcenobservaciones = cgiGet( edtalamcenobservaciones_Internalname);
               n150alamcenobservaciones = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150alamcenobservaciones", A150alamcenobservaciones);
               n150alamcenobservaciones = (String.IsNullOrEmpty(StringUtil.RTrim( A150alamcenobservaciones)) ? true : false);
               A151alamcenusuario = cgiGet( edtalamcenusuario_Internalname);
               n151alamcenusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151alamcenusuario", A151alamcenusuario);
               n151alamcenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A151alamcenusuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtalmacenfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"almacenfecreg"}), 1, "ALMACENFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtalmacenfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A152almacenfecreg = (DateTime)(DateTime.MinValue);
                  n152almacenfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152almacenfecreg", context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A152almacenfecreg = context.localUtil.CToT( cgiGet( edtalmacenfecreg_Internalname));
                  n152almacenfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152almacenfecreg", context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n152almacenfecreg = ((DateTime.MinValue==A152almacenfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtalmacenfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"almacenfecultact"}), 1, "ALMACENFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtalmacenfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A153almacenfecultact = (DateTime)(DateTime.MinValue);
                  n153almacenfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153almacenfecultact", context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A153almacenfecultact = context.localUtil.CToT( cgiGet( edtalmacenfecultact_Internalname));
                  n153almacenfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153almacenfecultact", context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n153almacenfecultact = ((DateTime.MinValue==A153almacenfecultact) ? true : false);
               /* Read saved values. */
               Z19almacenid = (long)(context.localUtil.CToN( cgiGet( "Z19almacenid"), ",", "."));
               Z143almacendsc = cgiGet( "Z143almacendsc");
               n143almacendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A143almacendsc)) ? true : false);
               Z144almacendireccion = cgiGet( "Z144almacendireccion");
               n144almacendireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A144almacendireccion)) ? true : false);
               Z145almacencolonia = cgiGet( "Z145almacencolonia");
               n145almacencolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A145almacencolonia)) ? true : false);
               Z146almacenmunicipio = cgiGet( "Z146almacenmunicipio");
               n146almacenmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A146almacenmunicipio)) ? true : false);
               Z147alamcenestado = cgiGet( "Z147alamcenestado");
               n147alamcenestado = (String.IsNullOrEmpty(StringUtil.RTrim( A147alamcenestado)) ? true : false);
               Z148alamcencodigopostal = cgiGet( "Z148alamcencodigopostal");
               n148alamcencodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A148alamcencodigopostal)) ? true : false);
               Z149almacentelefono = cgiGet( "Z149almacentelefono");
               n149almacentelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A149almacentelefono)) ? true : false);
               Z150alamcenobservaciones = cgiGet( "Z150alamcenobservaciones");
               n150alamcenobservaciones = (String.IsNullOrEmpty(StringUtil.RTrim( A150alamcenobservaciones)) ? true : false);
               Z151alamcenusuario = cgiGet( "Z151alamcenusuario");
               n151alamcenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A151alamcenusuario)) ? true : false);
               Z152almacenfecreg = context.localUtil.CToT( cgiGet( "Z152almacenfecreg"), 0);
               n152almacenfecreg = ((DateTime.MinValue==A152almacenfecreg) ? true : false);
               Z153almacenfecultact = context.localUtil.CToT( cgiGet( "Z153almacenfecultact"), 0);
               n153almacenfecultact = ((DateTime.MinValue==A153almacenfecultact) ? true : false);
               Z13empleadosid = (int)(context.localUtil.CToN( cgiGet( "Z13empleadosid"), ",", "."));
               n13empleadosid = ((0==A13empleadosid) ? true : false);
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
               InitAll0I18( ) ;
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
         DisableAttributes0I18( ) ;
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

      protected void ResetCaption0I0( )
      {
      }

      protected void ZM0I18( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z143almacendsc = T000I3_A143almacendsc[0];
               Z144almacendireccion = T000I3_A144almacendireccion[0];
               Z145almacencolonia = T000I3_A145almacencolonia[0];
               Z146almacenmunicipio = T000I3_A146almacenmunicipio[0];
               Z147alamcenestado = T000I3_A147alamcenestado[0];
               Z148alamcencodigopostal = T000I3_A148alamcencodigopostal[0];
               Z149almacentelefono = T000I3_A149almacentelefono[0];
               Z150alamcenobservaciones = T000I3_A150alamcenobservaciones[0];
               Z151alamcenusuario = T000I3_A151alamcenusuario[0];
               Z152almacenfecreg = T000I3_A152almacenfecreg[0];
               Z153almacenfecultact = T000I3_A153almacenfecultact[0];
               Z13empleadosid = T000I3_A13empleadosid[0];
            }
            else
            {
               Z143almacendsc = A143almacendsc;
               Z144almacendireccion = A144almacendireccion;
               Z145almacencolonia = A145almacencolonia;
               Z146almacenmunicipio = A146almacenmunicipio;
               Z147alamcenestado = A147alamcenestado;
               Z148alamcencodigopostal = A148alamcencodigopostal;
               Z149almacentelefono = A149almacentelefono;
               Z150alamcenobservaciones = A150alamcenobservaciones;
               Z151alamcenusuario = A151alamcenusuario;
               Z152almacenfecreg = A152almacenfecreg;
               Z153almacenfecultact = A153almacenfecultact;
               Z13empleadosid = A13empleadosid;
            }
         }
         if ( GX_JID == -1 )
         {
            Z19almacenid = A19almacenid;
            Z143almacendsc = A143almacendsc;
            Z144almacendireccion = A144almacendireccion;
            Z145almacencolonia = A145almacencolonia;
            Z146almacenmunicipio = A146almacenmunicipio;
            Z147alamcenestado = A147alamcenestado;
            Z148alamcencodigopostal = A148alamcencodigopostal;
            Z149almacentelefono = A149almacentelefono;
            Z150alamcenobservaciones = A150alamcenobservaciones;
            Z151alamcenusuario = A151alamcenusuario;
            Z152almacenfecreg = A152almacenfecreg;
            Z153almacenfecultact = A153almacenfecultact;
            Z13empleadosid = A13empleadosid;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_13_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPLEADOSID"+"'), id:'"+"EMPLEADOSID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load0I18( )
      {
         /* Using cursor T000I5 */
         pr_default.execute(3, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound18 = 1;
            A143almacendsc = T000I5_A143almacendsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143almacendsc", A143almacendsc);
            n143almacendsc = T000I5_n143almacendsc[0];
            A144almacendireccion = T000I5_A144almacendireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144almacendireccion", A144almacendireccion);
            n144almacendireccion = T000I5_n144almacendireccion[0];
            A145almacencolonia = T000I5_A145almacencolonia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145almacencolonia", A145almacencolonia);
            n145almacencolonia = T000I5_n145almacencolonia[0];
            A146almacenmunicipio = T000I5_A146almacenmunicipio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146almacenmunicipio", A146almacenmunicipio);
            n146almacenmunicipio = T000I5_n146almacenmunicipio[0];
            A147alamcenestado = T000I5_A147alamcenestado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147alamcenestado", A147alamcenestado);
            n147alamcenestado = T000I5_n147alamcenestado[0];
            A148alamcencodigopostal = T000I5_A148alamcencodigopostal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A148alamcencodigopostal", A148alamcencodigopostal);
            n148alamcencodigopostal = T000I5_n148alamcencodigopostal[0];
            A149almacentelefono = T000I5_A149almacentelefono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A149almacentelefono", A149almacentelefono);
            n149almacentelefono = T000I5_n149almacentelefono[0];
            A150alamcenobservaciones = T000I5_A150alamcenobservaciones[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150alamcenobservaciones", A150alamcenobservaciones);
            n150alamcenobservaciones = T000I5_n150alamcenobservaciones[0];
            A151alamcenusuario = T000I5_A151alamcenusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151alamcenusuario", A151alamcenusuario);
            n151alamcenusuario = T000I5_n151alamcenusuario[0];
            A152almacenfecreg = T000I5_A152almacenfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152almacenfecreg", context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
            n152almacenfecreg = T000I5_n152almacenfecreg[0];
            A153almacenfecultact = T000I5_A153almacenfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153almacenfecultact", context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
            n153almacenfecultact = T000I5_n153almacenfecultact[0];
            A13empleadosid = T000I5_A13empleadosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            n13empleadosid = T000I5_n13empleadosid[0];
            ZM0I18( -1) ;
         }
         pr_default.close(3);
         OnLoadActions0I18( ) ;
      }

      protected void OnLoadActions0I18( )
      {
      }

      protected void CheckExtendedTable0I18( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000I4 */
         pr_default.execute(2, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A13empleadosid) ) )
            {
               GX_msglist.addItem("No existe 'empleados'.", "ForeignKeyNotFound", 1, "EMPLEADOSID");
               AnyError = 1;
               GX_FocusControl = edtempleadosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0I18( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( int A13empleadosid )
      {
         /* Using cursor T000I6 */
         pr_default.execute(4, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A13empleadosid) ) )
            {
               GX_msglist.addItem("No existe 'empleados'.", "ForeignKeyNotFound", 1, "EMPLEADOSID");
               AnyError = 1;
               GX_FocusControl = edtempleadosid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0I18( )
      {
         /* Using cursor T000I7 */
         pr_default.execute(5, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound18 = 1;
         }
         else
         {
            RcdFound18 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000I3 */
         pr_default.execute(1, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0I18( 1) ;
            RcdFound18 = 1;
            A19almacenid = T000I3_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
            A143almacendsc = T000I3_A143almacendsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143almacendsc", A143almacendsc);
            n143almacendsc = T000I3_n143almacendsc[0];
            A144almacendireccion = T000I3_A144almacendireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144almacendireccion", A144almacendireccion);
            n144almacendireccion = T000I3_n144almacendireccion[0];
            A145almacencolonia = T000I3_A145almacencolonia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145almacencolonia", A145almacencolonia);
            n145almacencolonia = T000I3_n145almacencolonia[0];
            A146almacenmunicipio = T000I3_A146almacenmunicipio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146almacenmunicipio", A146almacenmunicipio);
            n146almacenmunicipio = T000I3_n146almacenmunicipio[0];
            A147alamcenestado = T000I3_A147alamcenestado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147alamcenestado", A147alamcenestado);
            n147alamcenestado = T000I3_n147alamcenestado[0];
            A148alamcencodigopostal = T000I3_A148alamcencodigopostal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A148alamcencodigopostal", A148alamcencodigopostal);
            n148alamcencodigopostal = T000I3_n148alamcencodigopostal[0];
            A149almacentelefono = T000I3_A149almacentelefono[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A149almacentelefono", A149almacentelefono);
            n149almacentelefono = T000I3_n149almacentelefono[0];
            A150alamcenobservaciones = T000I3_A150alamcenobservaciones[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150alamcenobservaciones", A150alamcenobservaciones);
            n150alamcenobservaciones = T000I3_n150alamcenobservaciones[0];
            A151alamcenusuario = T000I3_A151alamcenusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151alamcenusuario", A151alamcenusuario);
            n151alamcenusuario = T000I3_n151alamcenusuario[0];
            A152almacenfecreg = T000I3_A152almacenfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152almacenfecreg", context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
            n152almacenfecreg = T000I3_n152almacenfecreg[0];
            A153almacenfecultact = T000I3_A153almacenfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153almacenfecultact", context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
            n153almacenfecultact = T000I3_n153almacenfecultact[0];
            A13empleadosid = T000I3_A13empleadosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            n13empleadosid = T000I3_n13empleadosid[0];
            Z19almacenid = A19almacenid;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0I18( ) ;
            if ( AnyError == 1 )
            {
               RcdFound18 = 0;
               InitializeNonKey0I18( ) ;
            }
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound18 = 0;
            InitializeNonKey0I18( ) ;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I18( ) ;
         if ( RcdFound18 == 0 )
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
         RcdFound18 = 0;
         /* Using cursor T000I8 */
         pr_default.execute(6, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000I8_A19almacenid[0] < A19almacenid ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000I8_A19almacenid[0] > A19almacenid ) ) )
            {
               A19almacenid = T000I8_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               RcdFound18 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound18 = 0;
         /* Using cursor T000I9 */
         pr_default.execute(7, new Object[] {A19almacenid});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000I9_A19almacenid[0] > A19almacenid ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000I9_A19almacenid[0] < A19almacenid ) ) )
            {
               A19almacenid = T000I9_A19almacenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
               RcdFound18 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0I18( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0I18( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound18 == 1 )
            {
               if ( A19almacenid != Z19almacenid )
               {
                  A19almacenid = Z19almacenid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
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
                  Update0I18( ) ;
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A19almacenid != Z19almacenid )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtalmacenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0I18( ) ;
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
                     Insert0I18( ) ;
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
         if ( A19almacenid != Z19almacenid )
         {
            A19almacenid = Z19almacenid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
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
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ALMACENID");
            AnyError = 1;
            GX_FocusControl = edtalmacenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtempleadosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0I18( ) ;
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtempleadosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0I18( ) ;
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
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtempleadosid_Internalname;
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
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtempleadosid_Internalname;
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
         ScanStart0I18( ) ;
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound18 != 0 )
            {
               ScanNext0I18( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtempleadosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0I18( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0I18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000I2 */
            pr_default.execute(0, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ALMACEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z143almacendsc, T000I2_A143almacendsc[0]) != 0 ) || ( StringUtil.StrCmp(Z144almacendireccion, T000I2_A144almacendireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z145almacencolonia, T000I2_A145almacencolonia[0]) != 0 ) || ( StringUtil.StrCmp(Z146almacenmunicipio, T000I2_A146almacenmunicipio[0]) != 0 ) || ( StringUtil.StrCmp(Z147alamcenestado, T000I2_A147alamcenestado[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z148alamcencodigopostal, T000I2_A148alamcencodigopostal[0]) != 0 ) || ( StringUtil.StrCmp(Z149almacentelefono, T000I2_A149almacentelefono[0]) != 0 ) || ( StringUtil.StrCmp(Z150alamcenobservaciones, T000I2_A150alamcenobservaciones[0]) != 0 ) || ( StringUtil.StrCmp(Z151alamcenusuario, T000I2_A151alamcenusuario[0]) != 0 ) || ( Z152almacenfecreg != T000I2_A152almacenfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z153almacenfecultact != T000I2_A153almacenfecultact[0] ) || ( Z13empleadosid != T000I2_A13empleadosid[0] ) )
            {
               if ( StringUtil.StrCmp(Z143almacendsc, T000I2_A143almacendsc[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacendsc");
                  GXUtil.WriteLogRaw("Old: ",Z143almacendsc);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A143almacendsc[0]);
               }
               if ( StringUtil.StrCmp(Z144almacendireccion, T000I2_A144almacendireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacendireccion");
                  GXUtil.WriteLogRaw("Old: ",Z144almacendireccion);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A144almacendireccion[0]);
               }
               if ( StringUtil.StrCmp(Z145almacencolonia, T000I2_A145almacencolonia[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacencolonia");
                  GXUtil.WriteLogRaw("Old: ",Z145almacencolonia);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A145almacencolonia[0]);
               }
               if ( StringUtil.StrCmp(Z146almacenmunicipio, T000I2_A146almacenmunicipio[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacenmunicipio");
                  GXUtil.WriteLogRaw("Old: ",Z146almacenmunicipio);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A146almacenmunicipio[0]);
               }
               if ( StringUtil.StrCmp(Z147alamcenestado, T000I2_A147alamcenestado[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"alamcenestado");
                  GXUtil.WriteLogRaw("Old: ",Z147alamcenestado);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A147alamcenestado[0]);
               }
               if ( StringUtil.StrCmp(Z148alamcencodigopostal, T000I2_A148alamcencodigopostal[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"alamcencodigopostal");
                  GXUtil.WriteLogRaw("Old: ",Z148alamcencodigopostal);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A148alamcencodigopostal[0]);
               }
               if ( StringUtil.StrCmp(Z149almacentelefono, T000I2_A149almacentelefono[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacentelefono");
                  GXUtil.WriteLogRaw("Old: ",Z149almacentelefono);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A149almacentelefono[0]);
               }
               if ( StringUtil.StrCmp(Z150alamcenobservaciones, T000I2_A150alamcenobservaciones[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"alamcenobservaciones");
                  GXUtil.WriteLogRaw("Old: ",Z150alamcenobservaciones);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A150alamcenobservaciones[0]);
               }
               if ( StringUtil.StrCmp(Z151alamcenusuario, T000I2_A151alamcenusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"alamcenusuario");
                  GXUtil.WriteLogRaw("Old: ",Z151alamcenusuario);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A151alamcenusuario[0]);
               }
               if ( Z152almacenfecreg != T000I2_A152almacenfecreg[0] )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacenfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z152almacenfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A152almacenfecreg[0]);
               }
               if ( Z153almacenfecultact != T000I2_A153almacenfecultact[0] )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"almacenfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z153almacenfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A153almacenfecultact[0]);
               }
               if ( Z13empleadosid != T000I2_A13empleadosid[0] )
               {
                  GXUtil.WriteLog("almacen:[seudo value changed for attri]"+"empleadosid");
                  GXUtil.WriteLogRaw("Old: ",Z13empleadosid);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A13empleadosid[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ALMACEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0I18( )
      {
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I18( 0) ;
            CheckOptimisticConcurrency0I18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I10 */
                     pr_default.execute(8, new Object[] {A19almacenid, n143almacendsc, A143almacendsc, n144almacendireccion, A144almacendireccion, n145almacencolonia, A145almacencolonia, n146almacenmunicipio, A146almacenmunicipio, n147alamcenestado, A147alamcenestado, n148alamcencodigopostal, A148alamcencodigopostal, n149almacentelefono, A149almacentelefono, n150alamcenobservaciones, A150alamcenobservaciones, n151alamcenusuario, A151alamcenusuario, n152almacenfecreg, A152almacenfecreg, n153almacenfecultact, A153almacenfecultact, n13empleadosid, A13empleadosid});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
                     if ( (pr_default.getStatus(8) == 1) )
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
                           ResetCaption0I0( ) ;
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
               Load0I18( ) ;
            }
            EndLevel0I18( ) ;
         }
         CloseExtendedTableCursors0I18( ) ;
      }

      protected void Update0I18( )
      {
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I11 */
                     pr_default.execute(9, new Object[] {n143almacendsc, A143almacendsc, n144almacendireccion, A144almacendireccion, n145almacencolonia, A145almacencolonia, n146almacenmunicipio, A146almacenmunicipio, n147alamcenestado, A147alamcenestado, n148alamcencodigopostal, A148alamcencodigopostal, n149almacentelefono, A149almacentelefono, n150alamcenobservaciones, A150alamcenobservaciones, n151alamcenusuario, A151alamcenusuario, n152almacenfecreg, A152almacenfecreg, n153almacenfecultact, A153almacenfecultact, n13empleadosid, A13empleadosid, A19almacenid});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ALMACEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0I18( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption0I0( ) ;
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
            EndLevel0I18( ) ;
         }
         CloseExtendedTableCursors0I18( ) ;
      }

      protected void DeferredUpdate0I18( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0I18( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I18( ) ;
            AfterConfirm0I18( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I18( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000I12 */
                  pr_default.execute(10, new Object[] {A19almacenid});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("ALMACEN") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound18 == 0 )
                        {
                           InitAll0I18( ) ;
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
                        ResetCaption0I0( ) ;
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
         sMode18 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0I18( ) ;
         Gx_mode = sMode18;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0I18( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000I13 */
            pr_default.execute(11, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"etiquetas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000I14 */
            pr_default.execute(12, new Object[] {A19almacenid});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0I18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I18( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "almacen");
            if ( AnyError == 0 )
            {
               ConfirmValues0I0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "almacen");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0I18( )
      {
         /* Using cursor T000I15 */
         pr_default.execute(13);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound18 = 1;
            A19almacenid = T000I15_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0I18( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound18 = 1;
            A19almacenid = T000I15_A19almacenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
         }
      }

      protected void ScanEnd0I18( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0I18( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I18( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0I18( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0I18( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I18( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I18( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0I18( )
      {
         edtalmacenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenid_Enabled), 5, 0)));
         edtempleadosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosid_Enabled), 5, 0)));
         edtalmacendsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacendsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacendsc_Enabled), 5, 0)));
         edtalmacendireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacendireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacendireccion_Enabled), 5, 0)));
         edtalmacencolonia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacencolonia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacencolonia_Enabled), 5, 0)));
         edtalmacenmunicipio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenmunicipio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenmunicipio_Enabled), 5, 0)));
         edtalamcenestado_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcenestado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalamcenestado_Enabled), 5, 0)));
         edtalamcencodigopostal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcencodigopostal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalamcencodigopostal_Enabled), 5, 0)));
         edtalmacentelefono_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacentelefono_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacentelefono_Enabled), 5, 0)));
         edtalamcenobservaciones_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcenobservaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalamcenobservaciones_Enabled), 5, 0)));
         edtalamcenusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalamcenusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalamcenusuario_Enabled), 5, 0)));
         edtalmacenfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenfecreg_Enabled), 5, 0)));
         edtalmacenfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtalmacenfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtalmacenfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0I0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202212517345181");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("almacen.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z143almacendsc", Z143almacendsc);
         GxWebStd.gx_hidden_field( context, "Z144almacendireccion", Z144almacendireccion);
         GxWebStd.gx_hidden_field( context, "Z145almacencolonia", Z145almacencolonia);
         GxWebStd.gx_hidden_field( context, "Z146almacenmunicipio", Z146almacenmunicipio);
         GxWebStd.gx_hidden_field( context, "Z147alamcenestado", Z147alamcenestado);
         GxWebStd.gx_hidden_field( context, "Z148alamcencodigopostal", Z148alamcencodigopostal);
         GxWebStd.gx_hidden_field( context, "Z149almacentelefono", Z149almacentelefono);
         GxWebStd.gx_hidden_field( context, "Z150alamcenobservaciones", Z150alamcenobservaciones);
         GxWebStd.gx_hidden_field( context, "Z151alamcenusuario", Z151alamcenusuario);
         GxWebStd.gx_hidden_field( context, "Z152almacenfecreg", context.localUtil.TToC( Z152almacenfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z153almacenfecultact", context.localUtil.TToC( Z153almacenfecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z13empleadosid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13empleadosid), 9, 0, ",", "")));
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
         return formatLink("almacen.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "almacen" ;
      }

      public override String GetPgmdesc( )
      {
         return "almacen" ;
      }

      protected void InitializeNonKey0I18( )
      {
         A13empleadosid = 0;
         n13empleadosid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
         n13empleadosid = ((0==A13empleadosid) ? true : false);
         A143almacendsc = "";
         n143almacendsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143almacendsc", A143almacendsc);
         n143almacendsc = (String.IsNullOrEmpty(StringUtil.RTrim( A143almacendsc)) ? true : false);
         A144almacendireccion = "";
         n144almacendireccion = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144almacendireccion", A144almacendireccion);
         n144almacendireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A144almacendireccion)) ? true : false);
         A145almacencolonia = "";
         n145almacencolonia = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145almacencolonia", A145almacencolonia);
         n145almacencolonia = (String.IsNullOrEmpty(StringUtil.RTrim( A145almacencolonia)) ? true : false);
         A146almacenmunicipio = "";
         n146almacenmunicipio = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146almacenmunicipio", A146almacenmunicipio);
         n146almacenmunicipio = (String.IsNullOrEmpty(StringUtil.RTrim( A146almacenmunicipio)) ? true : false);
         A147alamcenestado = "";
         n147alamcenestado = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147alamcenestado", A147alamcenestado);
         n147alamcenestado = (String.IsNullOrEmpty(StringUtil.RTrim( A147alamcenestado)) ? true : false);
         A148alamcencodigopostal = "";
         n148alamcencodigopostal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A148alamcencodigopostal", A148alamcencodigopostal);
         n148alamcencodigopostal = (String.IsNullOrEmpty(StringUtil.RTrim( A148alamcencodigopostal)) ? true : false);
         A149almacentelefono = "";
         n149almacentelefono = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A149almacentelefono", A149almacentelefono);
         n149almacentelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A149almacentelefono)) ? true : false);
         A150alamcenobservaciones = "";
         n150alamcenobservaciones = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150alamcenobservaciones", A150alamcenobservaciones);
         n150alamcenobservaciones = (String.IsNullOrEmpty(StringUtil.RTrim( A150alamcenobservaciones)) ? true : false);
         A151alamcenusuario = "";
         n151alamcenusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151alamcenusuario", A151alamcenusuario);
         n151alamcenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A151alamcenusuario)) ? true : false);
         A152almacenfecreg = (DateTime)(DateTime.MinValue);
         n152almacenfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152almacenfecreg", context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
         n152almacenfecreg = ((DateTime.MinValue==A152almacenfecreg) ? true : false);
         A153almacenfecultact = (DateTime)(DateTime.MinValue);
         n153almacenfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153almacenfecultact", context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
         n153almacenfecultact = ((DateTime.MinValue==A153almacenfecultact) ? true : false);
         Z143almacendsc = "";
         Z144almacendireccion = "";
         Z145almacencolonia = "";
         Z146almacenmunicipio = "";
         Z147alamcenestado = "";
         Z148alamcencodigopostal = "";
         Z149almacentelefono = "";
         Z150alamcenobservaciones = "";
         Z151alamcenusuario = "";
         Z152almacenfecreg = (DateTime)(DateTime.MinValue);
         Z153almacenfecultact = (DateTime)(DateTime.MinValue);
         Z13empleadosid = 0;
      }

      protected void InitAll0I18( )
      {
         A19almacenid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19almacenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A19almacenid), 18, 0)));
         InitializeNonKey0I18( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1734189");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202212517345197");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("almacen.js", "?202212517345198");
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
         edtempleadosid_Internalname = "EMPLEADOSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacendsc_Internalname = "ALMACENDSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacendireccion_Internalname = "ALMACENDIRECCION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacencolonia_Internalname = "ALMACENCOLONIA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacenmunicipio_Internalname = "ALMACENMUNICIPIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalamcenestado_Internalname = "ALAMCENESTADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalamcencodigopostal_Internalname = "ALAMCENCODIGOPOSTAL";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacentelefono_Internalname = "ALMACENTELEFONO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalamcenobservaciones_Internalname = "ALAMCENOBSERVACIONES";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalamcenusuario_Internalname = "ALAMCENUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacenfecreg_Internalname = "ALMACENFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtalmacenfecultact_Internalname = "ALMACENFECULTACT";
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
         imgprompt_13_Internalname = "PROMPT_13";
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
         Form.Caption = "almacen";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtalmacenfecultact_Jsonclick = "";
         edtalmacenfecultact_Enabled = 1;
         edtalmacenfecreg_Jsonclick = "";
         edtalmacenfecreg_Enabled = 1;
         edtalamcenusuario_Jsonclick = "";
         edtalamcenusuario_Enabled = 1;
         edtalamcenobservaciones_Jsonclick = "";
         edtalamcenobservaciones_Enabled = 1;
         edtalmacentelefono_Jsonclick = "";
         edtalmacentelefono_Enabled = 1;
         edtalamcencodigopostal_Jsonclick = "";
         edtalamcencodigopostal_Enabled = 1;
         edtalamcenestado_Jsonclick = "";
         edtalamcenestado_Enabled = 1;
         edtalmacenmunicipio_Jsonclick = "";
         edtalmacenmunicipio_Enabled = 1;
         edtalmacencolonia_Jsonclick = "";
         edtalmacencolonia_Enabled = 1;
         edtalmacendireccion_Jsonclick = "";
         edtalmacendireccion_Enabled = 1;
         edtalmacendsc_Jsonclick = "";
         edtalmacendsc_Enabled = 1;
         imgprompt_13_Visible = 1;
         imgprompt_13_Link = "";
         edtempleadosid_Jsonclick = "";
         edtempleadosid_Enabled = 1;
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
         GX_FocusControl = edtempleadosid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Almacenid( long GX_Parm1 ,
                                   String GX_Parm2 ,
                                   String GX_Parm3 ,
                                   String GX_Parm4 ,
                                   String GX_Parm5 ,
                                   String GX_Parm6 ,
                                   String GX_Parm7 ,
                                   String GX_Parm8 ,
                                   String GX_Parm9 ,
                                   String GX_Parm10 ,
                                   DateTime GX_Parm11 ,
                                   DateTime GX_Parm12 ,
                                   int GX_Parm13 )
      {
         A19almacenid = GX_Parm1;
         A143almacendsc = GX_Parm2;
         n143almacendsc = false;
         A144almacendireccion = GX_Parm3;
         n144almacendireccion = false;
         A145almacencolonia = GX_Parm4;
         n145almacencolonia = false;
         A146almacenmunicipio = GX_Parm5;
         n146almacenmunicipio = false;
         A147alamcenestado = GX_Parm6;
         n147alamcenestado = false;
         A148alamcencodigopostal = GX_Parm7;
         n148alamcencodigopostal = false;
         A149almacentelefono = GX_Parm8;
         n149almacentelefono = false;
         A150alamcenobservaciones = GX_Parm9;
         n150alamcenobservaciones = false;
         A151alamcenusuario = GX_Parm10;
         n151alamcenusuario = false;
         A152almacenfecreg = GX_Parm11;
         n152almacenfecreg = false;
         A153almacenfecultact = GX_Parm12;
         n153almacenfecultact = false;
         A13empleadosid = GX_Parm13;
         n13empleadosid = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
         isValidOutput.Add(A143almacendsc);
         isValidOutput.Add(A144almacendireccion);
         isValidOutput.Add(A145almacencolonia);
         isValidOutput.Add(A146almacenmunicipio);
         isValidOutput.Add(A147alamcenestado);
         isValidOutput.Add(A148alamcencodigopostal);
         isValidOutput.Add(A149almacentelefono);
         isValidOutput.Add(A150alamcenobservaciones);
         isValidOutput.Add(A151alamcenusuario);
         isValidOutput.Add(context.localUtil.TToC( A152almacenfecreg, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( A153almacenfecultact, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19almacenid), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13empleadosid), 9, 0, ",", "")));
         isValidOutput.Add(Z143almacendsc);
         isValidOutput.Add(Z144almacendireccion);
         isValidOutput.Add(Z145almacencolonia);
         isValidOutput.Add(Z146almacenmunicipio);
         isValidOutput.Add(Z147alamcenestado);
         isValidOutput.Add(Z148alamcencodigopostal);
         isValidOutput.Add(Z149almacentelefono);
         isValidOutput.Add(Z150alamcenobservaciones);
         isValidOutput.Add(Z151alamcenusuario);
         isValidOutput.Add(context.localUtil.TToC( Z152almacenfecreg, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(context.localUtil.TToC( Z153almacenfecultact, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Empleadosid( int GX_Parm1 )
      {
         A13empleadosid = GX_Parm1;
         n13empleadosid = false;
         /* Using cursor T000I16 */
         pr_default.execute(14, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A13empleadosid) ) )
            {
               GX_msglist.addItem("No existe 'empleados'.", "ForeignKeyNotFound", 1, "EMPLEADOSID");
               AnyError = 1;
               GX_FocusControl = edtempleadosid_Internalname;
            }
         }
         pr_default.close(14);
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
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z143almacendsc = "";
         Z144almacendireccion = "";
         Z145almacencolonia = "";
         Z146almacenmunicipio = "";
         Z147alamcenestado = "";
         Z148alamcencodigopostal = "";
         Z149almacentelefono = "";
         Z150alamcenobservaciones = "";
         Z151alamcenusuario = "";
         Z152almacenfecreg = (DateTime)(DateTime.MinValue);
         Z153almacenfecultact = (DateTime)(DateTime.MinValue);
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
         A143almacendsc = "";
         A144almacendireccion = "";
         A145almacencolonia = "";
         A146almacenmunicipio = "";
         A147alamcenestado = "";
         A148alamcencodigopostal = "";
         A149almacentelefono = "";
         A150alamcenobservaciones = "";
         A151alamcenusuario = "";
         A152almacenfecreg = (DateTime)(DateTime.MinValue);
         A153almacenfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000I5_A19almacenid = new long[1] ;
         T000I5_A143almacendsc = new String[] {""} ;
         T000I5_n143almacendsc = new bool[] {false} ;
         T000I5_A144almacendireccion = new String[] {""} ;
         T000I5_n144almacendireccion = new bool[] {false} ;
         T000I5_A145almacencolonia = new String[] {""} ;
         T000I5_n145almacencolonia = new bool[] {false} ;
         T000I5_A146almacenmunicipio = new String[] {""} ;
         T000I5_n146almacenmunicipio = new bool[] {false} ;
         T000I5_A147alamcenestado = new String[] {""} ;
         T000I5_n147alamcenestado = new bool[] {false} ;
         T000I5_A148alamcencodigopostal = new String[] {""} ;
         T000I5_n148alamcencodigopostal = new bool[] {false} ;
         T000I5_A149almacentelefono = new String[] {""} ;
         T000I5_n149almacentelefono = new bool[] {false} ;
         T000I5_A150alamcenobservaciones = new String[] {""} ;
         T000I5_n150alamcenobservaciones = new bool[] {false} ;
         T000I5_A151alamcenusuario = new String[] {""} ;
         T000I5_n151alamcenusuario = new bool[] {false} ;
         T000I5_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000I5_n152almacenfecreg = new bool[] {false} ;
         T000I5_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000I5_n153almacenfecultact = new bool[] {false} ;
         T000I5_A13empleadosid = new int[1] ;
         T000I5_n13empleadosid = new bool[] {false} ;
         T000I4_A13empleadosid = new int[1] ;
         T000I4_n13empleadosid = new bool[] {false} ;
         T000I6_A13empleadosid = new int[1] ;
         T000I6_n13empleadosid = new bool[] {false} ;
         T000I7_A19almacenid = new long[1] ;
         T000I3_A19almacenid = new long[1] ;
         T000I3_A143almacendsc = new String[] {""} ;
         T000I3_n143almacendsc = new bool[] {false} ;
         T000I3_A144almacendireccion = new String[] {""} ;
         T000I3_n144almacendireccion = new bool[] {false} ;
         T000I3_A145almacencolonia = new String[] {""} ;
         T000I3_n145almacencolonia = new bool[] {false} ;
         T000I3_A146almacenmunicipio = new String[] {""} ;
         T000I3_n146almacenmunicipio = new bool[] {false} ;
         T000I3_A147alamcenestado = new String[] {""} ;
         T000I3_n147alamcenestado = new bool[] {false} ;
         T000I3_A148alamcencodigopostal = new String[] {""} ;
         T000I3_n148alamcencodigopostal = new bool[] {false} ;
         T000I3_A149almacentelefono = new String[] {""} ;
         T000I3_n149almacentelefono = new bool[] {false} ;
         T000I3_A150alamcenobservaciones = new String[] {""} ;
         T000I3_n150alamcenobservaciones = new bool[] {false} ;
         T000I3_A151alamcenusuario = new String[] {""} ;
         T000I3_n151alamcenusuario = new bool[] {false} ;
         T000I3_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000I3_n152almacenfecreg = new bool[] {false} ;
         T000I3_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000I3_n153almacenfecultact = new bool[] {false} ;
         T000I3_A13empleadosid = new int[1] ;
         T000I3_n13empleadosid = new bool[] {false} ;
         sMode18 = "";
         T000I8_A19almacenid = new long[1] ;
         T000I9_A19almacenid = new long[1] ;
         T000I2_A19almacenid = new long[1] ;
         T000I2_A143almacendsc = new String[] {""} ;
         T000I2_n143almacendsc = new bool[] {false} ;
         T000I2_A144almacendireccion = new String[] {""} ;
         T000I2_n144almacendireccion = new bool[] {false} ;
         T000I2_A145almacencolonia = new String[] {""} ;
         T000I2_n145almacencolonia = new bool[] {false} ;
         T000I2_A146almacenmunicipio = new String[] {""} ;
         T000I2_n146almacenmunicipio = new bool[] {false} ;
         T000I2_A147alamcenestado = new String[] {""} ;
         T000I2_n147alamcenestado = new bool[] {false} ;
         T000I2_A148alamcencodigopostal = new String[] {""} ;
         T000I2_n148alamcencodigopostal = new bool[] {false} ;
         T000I2_A149almacentelefono = new String[] {""} ;
         T000I2_n149almacentelefono = new bool[] {false} ;
         T000I2_A150alamcenobservaciones = new String[] {""} ;
         T000I2_n150alamcenobservaciones = new bool[] {false} ;
         T000I2_A151alamcenusuario = new String[] {""} ;
         T000I2_n151alamcenusuario = new bool[] {false} ;
         T000I2_A152almacenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000I2_n152almacenfecreg = new bool[] {false} ;
         T000I2_A153almacenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000I2_n153almacenfecultact = new bool[] {false} ;
         T000I2_A13empleadosid = new int[1] ;
         T000I2_n13empleadosid = new bool[] {false} ;
         T000I13_A17etiquetasproductoid = new int[1] ;
         T000I13_A18etiquetascambsid = new int[1] ;
         T000I13_A19almacenid = new long[1] ;
         T000I14_A19almacenid = new long[1] ;
         T000I14_A20articulosproductoid = new int[1] ;
         T000I14_A21articuloscambsid = new int[1] ;
         T000I15_A19almacenid = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000I16_A13empleadosid = new int[1] ;
         T000I16_n13empleadosid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.almacen__default(),
            new Object[][] {
                new Object[] {
               T000I2_A19almacenid, T000I2_A143almacendsc, T000I2_n143almacendsc, T000I2_A144almacendireccion, T000I2_n144almacendireccion, T000I2_A145almacencolonia, T000I2_n145almacencolonia, T000I2_A146almacenmunicipio, T000I2_n146almacenmunicipio, T000I2_A147alamcenestado,
               T000I2_n147alamcenestado, T000I2_A148alamcencodigopostal, T000I2_n148alamcencodigopostal, T000I2_A149almacentelefono, T000I2_n149almacentelefono, T000I2_A150alamcenobservaciones, T000I2_n150alamcenobservaciones, T000I2_A151alamcenusuario, T000I2_n151alamcenusuario, T000I2_A152almacenfecreg,
               T000I2_n152almacenfecreg, T000I2_A153almacenfecultact, T000I2_n153almacenfecultact, T000I2_A13empleadosid, T000I2_n13empleadosid
               }
               , new Object[] {
               T000I3_A19almacenid, T000I3_A143almacendsc, T000I3_n143almacendsc, T000I3_A144almacendireccion, T000I3_n144almacendireccion, T000I3_A145almacencolonia, T000I3_n145almacencolonia, T000I3_A146almacenmunicipio, T000I3_n146almacenmunicipio, T000I3_A147alamcenestado,
               T000I3_n147alamcenestado, T000I3_A148alamcencodigopostal, T000I3_n148alamcencodigopostal, T000I3_A149almacentelefono, T000I3_n149almacentelefono, T000I3_A150alamcenobservaciones, T000I3_n150alamcenobservaciones, T000I3_A151alamcenusuario, T000I3_n151alamcenusuario, T000I3_A152almacenfecreg,
               T000I3_n152almacenfecreg, T000I3_A153almacenfecultact, T000I3_n153almacenfecultact, T000I3_A13empleadosid, T000I3_n13empleadosid
               }
               , new Object[] {
               T000I4_A13empleadosid
               }
               , new Object[] {
               T000I5_A19almacenid, T000I5_A143almacendsc, T000I5_n143almacendsc, T000I5_A144almacendireccion, T000I5_n144almacendireccion, T000I5_A145almacencolonia, T000I5_n145almacencolonia, T000I5_A146almacenmunicipio, T000I5_n146almacenmunicipio, T000I5_A147alamcenestado,
               T000I5_n147alamcenestado, T000I5_A148alamcencodigopostal, T000I5_n148alamcencodigopostal, T000I5_A149almacentelefono, T000I5_n149almacentelefono, T000I5_A150alamcenobservaciones, T000I5_n150alamcenobservaciones, T000I5_A151alamcenusuario, T000I5_n151alamcenusuario, T000I5_A152almacenfecreg,
               T000I5_n152almacenfecreg, T000I5_A153almacenfecultact, T000I5_n153almacenfecultact, T000I5_A13empleadosid, T000I5_n13empleadosid
               }
               , new Object[] {
               T000I6_A13empleadosid
               }
               , new Object[] {
               T000I7_A19almacenid
               }
               , new Object[] {
               T000I8_A19almacenid
               }
               , new Object[] {
               T000I9_A19almacenid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000I13_A17etiquetasproductoid, T000I13_A18etiquetascambsid, T000I13_A19almacenid
               }
               , new Object[] {
               T000I14_A19almacenid, T000I14_A20articulosproductoid, T000I14_A21articuloscambsid
               }
               , new Object[] {
               T000I15_A19almacenid
               }
               , new Object[] {
               T000I16_A13empleadosid
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
      private short RcdFound18 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z13empleadosid ;
      private int A13empleadosid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtalmacenid_Enabled ;
      private int edtempleadosid_Enabled ;
      private int imgprompt_13_Visible ;
      private int edtalmacendsc_Enabled ;
      private int edtalmacendireccion_Enabled ;
      private int edtalmacencolonia_Enabled ;
      private int edtalmacenmunicipio_Enabled ;
      private int edtalamcenestado_Enabled ;
      private int edtalamcencodigopostal_Enabled ;
      private int edtalmacentelefono_Enabled ;
      private int edtalamcenobservaciones_Enabled ;
      private int edtalamcenusuario_Enabled ;
      private int edtalmacenfecreg_Enabled ;
      private int edtalmacenfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z19almacenid ;
      private long A19almacenid ;
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
      private String edtempleadosid_Internalname ;
      private String edtempleadosid_Jsonclick ;
      private String imgprompt_13_Internalname ;
      private String imgprompt_13_Link ;
      private String edtalmacendsc_Internalname ;
      private String edtalmacendsc_Jsonclick ;
      private String edtalmacendireccion_Internalname ;
      private String edtalmacendireccion_Jsonclick ;
      private String edtalmacencolonia_Internalname ;
      private String edtalmacencolonia_Jsonclick ;
      private String edtalmacenmunicipio_Internalname ;
      private String edtalmacenmunicipio_Jsonclick ;
      private String edtalamcenestado_Internalname ;
      private String edtalamcenestado_Jsonclick ;
      private String edtalamcencodigopostal_Internalname ;
      private String edtalamcencodigopostal_Jsonclick ;
      private String edtalmacentelefono_Internalname ;
      private String edtalmacentelefono_Jsonclick ;
      private String edtalamcenobservaciones_Internalname ;
      private String edtalamcenobservaciones_Jsonclick ;
      private String edtalamcenusuario_Internalname ;
      private String edtalamcenusuario_Jsonclick ;
      private String edtalmacenfecreg_Internalname ;
      private String edtalmacenfecreg_Jsonclick ;
      private String edtalmacenfecultact_Internalname ;
      private String edtalmacenfecultact_Jsonclick ;
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
      private String sMode18 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z152almacenfecreg ;
      private DateTime Z153almacenfecultact ;
      private DateTime A152almacenfecreg ;
      private DateTime A153almacenfecultact ;
      private bool entryPointCalled ;
      private bool n13empleadosid ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n143almacendsc ;
      private bool n144almacendireccion ;
      private bool n145almacencolonia ;
      private bool n146almacenmunicipio ;
      private bool n147alamcenestado ;
      private bool n148alamcencodigopostal ;
      private bool n149almacentelefono ;
      private bool n150alamcenobservaciones ;
      private bool n151alamcenusuario ;
      private bool n152almacenfecreg ;
      private bool n153almacenfecultact ;
      private bool Gx_longc ;
      private String Z143almacendsc ;
      private String Z144almacendireccion ;
      private String Z145almacencolonia ;
      private String Z146almacenmunicipio ;
      private String Z147alamcenestado ;
      private String Z148alamcencodigopostal ;
      private String Z149almacentelefono ;
      private String Z150alamcenobservaciones ;
      private String Z151alamcenusuario ;
      private String A143almacendsc ;
      private String A144almacendireccion ;
      private String A145almacencolonia ;
      private String A146almacenmunicipio ;
      private String A147alamcenestado ;
      private String A148alamcencodigopostal ;
      private String A149almacentelefono ;
      private String A150alamcenobservaciones ;
      private String A151alamcenusuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000I5_A19almacenid ;
      private String[] T000I5_A143almacendsc ;
      private bool[] T000I5_n143almacendsc ;
      private String[] T000I5_A144almacendireccion ;
      private bool[] T000I5_n144almacendireccion ;
      private String[] T000I5_A145almacencolonia ;
      private bool[] T000I5_n145almacencolonia ;
      private String[] T000I5_A146almacenmunicipio ;
      private bool[] T000I5_n146almacenmunicipio ;
      private String[] T000I5_A147alamcenestado ;
      private bool[] T000I5_n147alamcenestado ;
      private String[] T000I5_A148alamcencodigopostal ;
      private bool[] T000I5_n148alamcencodigopostal ;
      private String[] T000I5_A149almacentelefono ;
      private bool[] T000I5_n149almacentelefono ;
      private String[] T000I5_A150alamcenobservaciones ;
      private bool[] T000I5_n150alamcenobservaciones ;
      private String[] T000I5_A151alamcenusuario ;
      private bool[] T000I5_n151alamcenusuario ;
      private DateTime[] T000I5_A152almacenfecreg ;
      private bool[] T000I5_n152almacenfecreg ;
      private DateTime[] T000I5_A153almacenfecultact ;
      private bool[] T000I5_n153almacenfecultact ;
      private int[] T000I5_A13empleadosid ;
      private bool[] T000I5_n13empleadosid ;
      private int[] T000I4_A13empleadosid ;
      private bool[] T000I4_n13empleadosid ;
      private int[] T000I6_A13empleadosid ;
      private bool[] T000I6_n13empleadosid ;
      private long[] T000I7_A19almacenid ;
      private long[] T000I3_A19almacenid ;
      private String[] T000I3_A143almacendsc ;
      private bool[] T000I3_n143almacendsc ;
      private String[] T000I3_A144almacendireccion ;
      private bool[] T000I3_n144almacendireccion ;
      private String[] T000I3_A145almacencolonia ;
      private bool[] T000I3_n145almacencolonia ;
      private String[] T000I3_A146almacenmunicipio ;
      private bool[] T000I3_n146almacenmunicipio ;
      private String[] T000I3_A147alamcenestado ;
      private bool[] T000I3_n147alamcenestado ;
      private String[] T000I3_A148alamcencodigopostal ;
      private bool[] T000I3_n148alamcencodigopostal ;
      private String[] T000I3_A149almacentelefono ;
      private bool[] T000I3_n149almacentelefono ;
      private String[] T000I3_A150alamcenobservaciones ;
      private bool[] T000I3_n150alamcenobservaciones ;
      private String[] T000I3_A151alamcenusuario ;
      private bool[] T000I3_n151alamcenusuario ;
      private DateTime[] T000I3_A152almacenfecreg ;
      private bool[] T000I3_n152almacenfecreg ;
      private DateTime[] T000I3_A153almacenfecultact ;
      private bool[] T000I3_n153almacenfecultact ;
      private int[] T000I3_A13empleadosid ;
      private bool[] T000I3_n13empleadosid ;
      private long[] T000I8_A19almacenid ;
      private long[] T000I9_A19almacenid ;
      private long[] T000I2_A19almacenid ;
      private String[] T000I2_A143almacendsc ;
      private bool[] T000I2_n143almacendsc ;
      private String[] T000I2_A144almacendireccion ;
      private bool[] T000I2_n144almacendireccion ;
      private String[] T000I2_A145almacencolonia ;
      private bool[] T000I2_n145almacencolonia ;
      private String[] T000I2_A146almacenmunicipio ;
      private bool[] T000I2_n146almacenmunicipio ;
      private String[] T000I2_A147alamcenestado ;
      private bool[] T000I2_n147alamcenestado ;
      private String[] T000I2_A148alamcencodigopostal ;
      private bool[] T000I2_n148alamcencodigopostal ;
      private String[] T000I2_A149almacentelefono ;
      private bool[] T000I2_n149almacentelefono ;
      private String[] T000I2_A150alamcenobservaciones ;
      private bool[] T000I2_n150alamcenobservaciones ;
      private String[] T000I2_A151alamcenusuario ;
      private bool[] T000I2_n151alamcenusuario ;
      private DateTime[] T000I2_A152almacenfecreg ;
      private bool[] T000I2_n152almacenfecreg ;
      private DateTime[] T000I2_A153almacenfecultact ;
      private bool[] T000I2_n153almacenfecultact ;
      private int[] T000I2_A13empleadosid ;
      private bool[] T000I2_n13empleadosid ;
      private int[] T000I13_A17etiquetasproductoid ;
      private int[] T000I13_A18etiquetascambsid ;
      private long[] T000I13_A19almacenid ;
      private long[] T000I14_A19almacenid ;
      private int[] T000I14_A20articulosproductoid ;
      private int[] T000I14_A21articuloscambsid ;
      private long[] T000I15_A19almacenid ;
      private int[] T000I16_A13empleadosid ;
      private bool[] T000I16_n13empleadosid ;
      private GXWebForm Form ;
   }

   public class almacen__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
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
          Object[] prmT000I5 ;
          prmT000I5 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I4 ;
          prmT000I4 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000I6 ;
          prmT000I6 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000I7 ;
          prmT000I7 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I3 ;
          prmT000I3 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I8 ;
          prmT000I8 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I9 ;
          prmT000I9 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I2 ;
          prmT000I2 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I10 ;
          prmT000I10 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"almacendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacendireccion",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacencolonia",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"almacenmunicipio",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenestado",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcencodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"almacentelefono",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"alamcenobservaciones",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"almacenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"almacenfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000I11 ;
          prmT000I11 = new Object[] {
          new Object[] {"almacendsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacendireccion",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"almacencolonia",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"almacenmunicipio",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenestado",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcencodigopostal",NpgsqlDbType.Varchar,5,0} ,
          new Object[] {"almacentelefono",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"alamcenobservaciones",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"alamcenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"almacenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"almacenfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I12 ;
          prmT000I12 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I13 ;
          prmT000I13 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I14 ;
          prmT000I14 = new Object[] {
          new Object[] {"almacenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000I15 ;
          prmT000I15 = new Object[] {
          } ;
          Object[] prmT000I16 ;
          prmT000I16 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000I2", "SELECT almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadoid FROM public.almacen WHERE almacenid = :almacenid  FOR UPDATE OF almacen NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000I2,1,0,true,false )
             ,new CursorDef("T000I3", "SELECT almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadoid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I3,1,0,true,false )
             ,new CursorDef("T000I4", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I4,1,0,true,false )
             ,new CursorDef("T000I5", "SELECT TM1.almacenid, TM1.almacendsc, TM1.almacendireccion, TM1.almacencolonia, TM1.almacenmunicipio, TM1.alamcenestado, TM1.alamcencodigopostal, TM1.almacentelefono, TM1.alamcenobservaciones, TM1.alamcenusuario, TM1.almacenfecreg, TM1.almacenfecultact, TM1.empleadoid FROM public.almacen TM1 WHERE TM1.almacenid = :almacenid ORDER BY TM1.almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I5,100,0,true,false )
             ,new CursorDef("T000I6", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I6,1,0,true,false )
             ,new CursorDef("T000I7", "SELECT almacenid FROM public.almacen WHERE almacenid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I7,1,0,true,false )
             ,new CursorDef("T000I8", "SELECT almacenid FROM public.almacen WHERE ( almacenid > :almacenid) ORDER BY almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I8,1,0,true,true )
             ,new CursorDef("T000I9", "SELECT almacenid FROM public.almacen WHERE ( almacenid < :almacenid) ORDER BY almacenid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I9,1,0,true,true )
             ,new CursorDef("T000I10", "SAVEPOINT gxupdate;INSERT INTO public.almacen(almacenid, almacendsc, almacendireccion, almacencolonia, almacenmunicipio, alamcenestado, alamcencodigopostal, almacentelefono, alamcenobservaciones, alamcenusuario, almacenfecreg, almacenfecultact, empleadoid) VALUES(:almacenid, :almacendsc, :almacendireccion, :almacencolonia, :almacenmunicipio, :alamcenestado, :alamcencodigopostal, :almacentelefono, :alamcenobservaciones, :alamcenusuario, :almacenfecreg, :almacenfecultact, :empleadosid);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000I10)
             ,new CursorDef("T000I11", "SAVEPOINT gxupdate;UPDATE public.almacen SET almacendsc=:almacendsc, almacendireccion=:almacendireccion, almacencolonia=:almacencolonia, almacenmunicipio=:almacenmunicipio, alamcenestado=:alamcenestado, alamcencodigopostal=:alamcencodigopostal, almacentelefono=:almacentelefono, alamcenobservaciones=:alamcenobservaciones, alamcenusuario=:alamcenusuario, almacenfecreg=:almacenfecreg, almacenfecultact=:almacenfecultact, empleadoid=:empleadosid  WHERE almacenid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000I11)
             ,new CursorDef("T000I12", "SAVEPOINT gxupdate;DELETE FROM public.almacen  WHERE almacenid = :almacenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000I12)
             ,new CursorDef("T000I13", "SELECT productoid AS etiquetasproductoid, cambsid AS etiquetascambsid, articuloid FROM public.etiquetas WHERE articuloid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I13,1,0,true,true )
             ,new CursorDef("T000I14", "SELECT articulosid, productoid AS articulosproductoid, cambsid AS articuloscambsid FROM public.articulos WHERE articulosid = :almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I14,1,0,true,true )
             ,new CursorDef("T000I15", "SELECT almacenid FROM public.almacen ORDER BY almacenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I15,100,0,true,false )
             ,new CursorDef("T000I16", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I16,1,0,true,false )
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
                ((DateTime[]) buf[19])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                ((DateTime[]) buf[19])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                ((DateTime[]) buf[19])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((int[]) buf[23])[0] = rslt.getInt(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 12 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 13 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
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
                stmt.SetParameter(1, (long)parms[0]);
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 8 :
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
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
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(11, (DateTime)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(12, (DateTime)parms[22]);
                }
                if ( (bool)parms[23] )
                {
                   stmt.setNull( 13 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(13, (int)parms[24]);
                }
                return;
             case 9 :
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
                   stmt.setNull( 12 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(12, (int)parms[23]);
                }
                stmt.SetParameter(13, (long)parms[24]);
                return;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (long)parms[0]);
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
       }
    }

 }

}
