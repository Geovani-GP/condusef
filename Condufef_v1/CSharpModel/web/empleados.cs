/*
               File: empleados
        Description: empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:45.96
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
   public class empleados : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7empleadosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empleadosid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPLEADOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empleadosid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "empleados", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtempleadosareaid_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public empleados( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public empleados( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_empleadosid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7empleadosid = aP1_empleadosid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "empleados", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_empleados.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosid_Internalname, "empleadosid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempleadosid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")), ((edtempleadosid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosid_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosareaid_Internalname, "areaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosareaid_Internalname, A98empleadosareaid, StringUtil.RTrim( context.localUtil.Format( A98empleadosareaid, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosareaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosareaid_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosnomemple_Internalname, "empleadosnomemple", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosnomemple_Internalname, A99empleadosnomemple, StringUtil.RTrim( context.localUtil.Format( A99empleadosnomemple, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosnomemple_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosnomemple_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosappaterno_Internalname, "empleadosappaterno", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosappaterno_Internalname, A100empleadosappaterno, StringUtil.RTrim( context.localUtil.Format( A100empleadosappaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosappaterno_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosappaterno_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosapmaterno_Internalname, "empleadosapmaterno", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosapmaterno_Internalname, A101empleadosapmaterno, StringUtil.RTrim( context.localUtil.Format( A101empleadosapmaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosapmaterno_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosapmaterno_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosstatus_Internalname, "empleadosstatus", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosstatus_Internalname, A102empleadosstatus, StringUtil.RTrim( context.localUtil.Format( A102empleadosstatus, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosstatus_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosstatus_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosusuario_Internalname, "empleadosusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosusuario_Internalname, A103empleadosusuario, StringUtil.RTrim( context.localUtil.Format( A103empleadosusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadoscorreo_Internalname, "empleadoscorreo", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadoscorreo_Internalname, A106empleadoscorreo, StringUtil.RTrim( context.localUtil.Format( A106empleadoscorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadoscorreo_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadoscorreo_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosext_Internalname, "empleadosext", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadosext_Internalname, A107empleadosext, StringUtil.RTrim( context.localUtil.Format( A107empleadosext, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosext_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosext_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosfecreg_Internalname, "empleadosfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtempleadosfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtempleadosfecreg_Internalname, context.localUtil.Format(A104empleadosfecreg, "99/99/9999"), context.localUtil.Format( A104empleadosfecreg, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosfecreg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleados.htm");
            GxWebStd.gx_bitmap( context, edtempleadosfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtempleadosfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_empleados.htm");
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
            GxWebStd.gx_label_element( context, edtempleadosfecultact_Internalname, "empleadosfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtempleadosfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtempleadosfecultact_Internalname, context.localUtil.Format(A105empleadosfecultact, "99/99/9999"), context.localUtil.Format( A105empleadosfecultact, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadosfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadosfecultact_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleados.htm");
            GxWebStd.gx_bitmap( context, edtempleadosfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtempleadosfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_empleados.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleados.htm");
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
               A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
               n13empleadosid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               A98empleadosareaid = cgiGet( edtempleadosareaid_Internalname);
               n98empleadosareaid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98empleadosareaid", A98empleadosareaid);
               n98empleadosareaid = (String.IsNullOrEmpty(StringUtil.RTrim( A98empleadosareaid)) ? true : false);
               A99empleadosnomemple = cgiGet( edtempleadosnomemple_Internalname);
               n99empleadosnomemple = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A99empleadosnomemple", A99empleadosnomemple);
               n99empleadosnomemple = (String.IsNullOrEmpty(StringUtil.RTrim( A99empleadosnomemple)) ? true : false);
               A100empleadosappaterno = cgiGet( edtempleadosappaterno_Internalname);
               n100empleadosappaterno = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A100empleadosappaterno", A100empleadosappaterno);
               n100empleadosappaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A100empleadosappaterno)) ? true : false);
               A101empleadosapmaterno = cgiGet( edtempleadosapmaterno_Internalname);
               n101empleadosapmaterno = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101empleadosapmaterno", A101empleadosapmaterno);
               n101empleadosapmaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A101empleadosapmaterno)) ? true : false);
               A102empleadosstatus = cgiGet( edtempleadosstatus_Internalname);
               n102empleadosstatus = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102empleadosstatus", A102empleadosstatus);
               n102empleadosstatus = (String.IsNullOrEmpty(StringUtil.RTrim( A102empleadosstatus)) ? true : false);
               A103empleadosusuario = cgiGet( edtempleadosusuario_Internalname);
               n103empleadosusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103empleadosusuario", A103empleadosusuario);
               n103empleadosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A103empleadosusuario)) ? true : false);
               A106empleadoscorreo = cgiGet( edtempleadoscorreo_Internalname);
               n106empleadoscorreo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106empleadoscorreo", A106empleadoscorreo);
               n106empleadoscorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A106empleadoscorreo)) ? true : false);
               A107empleadosext = cgiGet( edtempleadosext_Internalname);
               n107empleadosext = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107empleadosext", A107empleadosext);
               n107empleadosext = (String.IsNullOrEmpty(StringUtil.RTrim( A107empleadosext)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtempleadosfecreg_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadosfecreg"}), 1, "EMPLEADOSFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtempleadosfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A104empleadosfecreg = DateTime.MinValue;
                  n104empleadosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104empleadosfecreg", context.localUtil.Format(A104empleadosfecreg, "99/99/9999"));
               }
               else
               {
                  A104empleadosfecreg = context.localUtil.CToD( cgiGet( edtempleadosfecreg_Internalname), 2);
                  n104empleadosfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104empleadosfecreg", context.localUtil.Format(A104empleadosfecreg, "99/99/9999"));
               }
               n104empleadosfecreg = ((DateTime.MinValue==A104empleadosfecreg) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtempleadosfecultact_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadosfecultact"}), 1, "EMPLEADOSFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtempleadosfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A105empleadosfecultact = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105empleadosfecultact", context.localUtil.Format(A105empleadosfecultact, "99/99/9999"));
               }
               else
               {
                  A105empleadosfecultact = context.localUtil.CToD( cgiGet( edtempleadosfecultact_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105empleadosfecultact", context.localUtil.Format(A105empleadosfecultact, "99/99/9999"));
               }
               /* Read saved values. */
               Z13empleadosid = (int)(context.localUtil.CToN( cgiGet( "Z13empleadosid"), ",", "."));
               Z98empleadosareaid = cgiGet( "Z98empleadosareaid");
               n98empleadosareaid = (String.IsNullOrEmpty(StringUtil.RTrim( A98empleadosareaid)) ? true : false);
               Z99empleadosnomemple = cgiGet( "Z99empleadosnomemple");
               n99empleadosnomemple = (String.IsNullOrEmpty(StringUtil.RTrim( A99empleadosnomemple)) ? true : false);
               Z100empleadosappaterno = cgiGet( "Z100empleadosappaterno");
               n100empleadosappaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A100empleadosappaterno)) ? true : false);
               Z101empleadosapmaterno = cgiGet( "Z101empleadosapmaterno");
               n101empleadosapmaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A101empleadosapmaterno)) ? true : false);
               Z102empleadosstatus = cgiGet( "Z102empleadosstatus");
               n102empleadosstatus = (String.IsNullOrEmpty(StringUtil.RTrim( A102empleadosstatus)) ? true : false);
               Z103empleadosusuario = cgiGet( "Z103empleadosusuario");
               n103empleadosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A103empleadosusuario)) ? true : false);
               Z106empleadoscorreo = cgiGet( "Z106empleadoscorreo");
               n106empleadoscorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A106empleadoscorreo)) ? true : false);
               Z107empleadosext = cgiGet( "Z107empleadosext");
               n107empleadosext = (String.IsNullOrEmpty(StringUtil.RTrim( A107empleadosext)) ? true : false);
               Z104empleadosfecreg = context.localUtil.CToD( cgiGet( "Z104empleadosfecreg"), 0);
               n104empleadosfecreg = ((DateTime.MinValue==A104empleadosfecreg) ? true : false);
               Z105empleadosfecultact = context.localUtil.CToD( cgiGet( "Z105empleadosfecultact"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7empleadosid = (int)(context.localUtil.CToN( cgiGet( "vEMPLEADOSID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "empleados";
               A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
               n13empleadosid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A13empleadosid != Z13empleadosid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("empleados:[SecurityCheckFailed value for]"+"empleadosid:"+context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("empleados:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A13empleadosid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  n13empleadosid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
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
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode6;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EMPLEADOSID");
                        AnyError = 1;
                        GX_FocusControl = edtempleadosid_Internalname;
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
               InitAll066( ) ;
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
            DisableAttributes066( ) ;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls066( ) ;
            }
            else
            {
               CheckExtendedTable066( ) ;
               CloseExtendedTableCursors066( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption060( )
      {
      }

      protected void ZM066( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z98empleadosareaid = T00063_A98empleadosareaid[0];
               Z99empleadosnomemple = T00063_A99empleadosnomemple[0];
               Z100empleadosappaterno = T00063_A100empleadosappaterno[0];
               Z101empleadosapmaterno = T00063_A101empleadosapmaterno[0];
               Z102empleadosstatus = T00063_A102empleadosstatus[0];
               Z103empleadosusuario = T00063_A103empleadosusuario[0];
               Z106empleadoscorreo = T00063_A106empleadoscorreo[0];
               Z107empleadosext = T00063_A107empleadosext[0];
               Z104empleadosfecreg = T00063_A104empleadosfecreg[0];
               Z105empleadosfecultact = T00063_A105empleadosfecultact[0];
            }
            else
            {
               Z98empleadosareaid = A98empleadosareaid;
               Z99empleadosnomemple = A99empleadosnomemple;
               Z100empleadosappaterno = A100empleadosappaterno;
               Z101empleadosapmaterno = A101empleadosapmaterno;
               Z102empleadosstatus = A102empleadosstatus;
               Z103empleadosusuario = A103empleadosusuario;
               Z106empleadoscorreo = A106empleadoscorreo;
               Z107empleadosext = A107empleadosext;
               Z104empleadosfecreg = A104empleadosfecreg;
               Z105empleadosfecultact = A105empleadosfecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z13empleadosid = A13empleadosid;
            Z98empleadosareaid = A98empleadosareaid;
            Z99empleadosnomemple = A99empleadosnomemple;
            Z100empleadosappaterno = A100empleadosappaterno;
            Z101empleadosapmaterno = A101empleadosapmaterno;
            Z102empleadosstatus = A102empleadosstatus;
            Z103empleadosusuario = A103empleadosusuario;
            Z106empleadoscorreo = A106empleadoscorreo;
            Z107empleadosext = A107empleadosext;
            Z104empleadosfecreg = A104empleadosfecreg;
            Z105empleadosfecultact = A105empleadosfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtempleadosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosid_Enabled), 5, 0)));
         edtempleadosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7empleadosid) )
         {
            A13empleadosid = AV7empleadosid;
            n13empleadosid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
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

      protected void Load066( )
      {
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1;
            A98empleadosareaid = T00064_A98empleadosareaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98empleadosareaid", A98empleadosareaid);
            n98empleadosareaid = T00064_n98empleadosareaid[0];
            A99empleadosnomemple = T00064_A99empleadosnomemple[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A99empleadosnomemple", A99empleadosnomemple);
            n99empleadosnomemple = T00064_n99empleadosnomemple[0];
            A100empleadosappaterno = T00064_A100empleadosappaterno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A100empleadosappaterno", A100empleadosappaterno);
            n100empleadosappaterno = T00064_n100empleadosappaterno[0];
            A101empleadosapmaterno = T00064_A101empleadosapmaterno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101empleadosapmaterno", A101empleadosapmaterno);
            n101empleadosapmaterno = T00064_n101empleadosapmaterno[0];
            A102empleadosstatus = T00064_A102empleadosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102empleadosstatus", A102empleadosstatus);
            n102empleadosstatus = T00064_n102empleadosstatus[0];
            A103empleadosusuario = T00064_A103empleadosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103empleadosusuario", A103empleadosusuario);
            n103empleadosusuario = T00064_n103empleadosusuario[0];
            A106empleadoscorreo = T00064_A106empleadoscorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106empleadoscorreo", A106empleadoscorreo);
            n106empleadoscorreo = T00064_n106empleadoscorreo[0];
            A107empleadosext = T00064_A107empleadosext[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107empleadosext", A107empleadosext);
            n107empleadosext = T00064_n107empleadosext[0];
            A104empleadosfecreg = T00064_A104empleadosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104empleadosfecreg", context.localUtil.Format(A104empleadosfecreg, "99/99/9999"));
            n104empleadosfecreg = T00064_n104empleadosfecreg[0];
            A105empleadosfecultact = T00064_A105empleadosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105empleadosfecultact", context.localUtil.Format(A105empleadosfecultact, "99/99/9999"));
            ZM066( -3) ;
         }
         pr_default.close(2);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
      }

      protected void CheckExtendedTable066( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors066( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey066( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM066( 3) ;
            RcdFound6 = 1;
            A13empleadosid = T00063_A13empleadosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            n13empleadosid = T00063_n13empleadosid[0];
            A98empleadosareaid = T00063_A98empleadosareaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98empleadosareaid", A98empleadosareaid);
            n98empleadosareaid = T00063_n98empleadosareaid[0];
            A99empleadosnomemple = T00063_A99empleadosnomemple[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A99empleadosnomemple", A99empleadosnomemple);
            n99empleadosnomemple = T00063_n99empleadosnomemple[0];
            A100empleadosappaterno = T00063_A100empleadosappaterno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A100empleadosappaterno", A100empleadosappaterno);
            n100empleadosappaterno = T00063_n100empleadosappaterno[0];
            A101empleadosapmaterno = T00063_A101empleadosapmaterno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101empleadosapmaterno", A101empleadosapmaterno);
            n101empleadosapmaterno = T00063_n101empleadosapmaterno[0];
            A102empleadosstatus = T00063_A102empleadosstatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102empleadosstatus", A102empleadosstatus);
            n102empleadosstatus = T00063_n102empleadosstatus[0];
            A103empleadosusuario = T00063_A103empleadosusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103empleadosusuario", A103empleadosusuario);
            n103empleadosusuario = T00063_n103empleadosusuario[0];
            A106empleadoscorreo = T00063_A106empleadoscorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106empleadoscorreo", A106empleadoscorreo);
            n106empleadoscorreo = T00063_n106empleadoscorreo[0];
            A107empleadosext = T00063_A107empleadosext[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107empleadosext", A107empleadosext);
            n107empleadosext = T00063_n107empleadosext[0];
            A104empleadosfecreg = T00063_A104empleadosfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104empleadosfecreg", context.localUtil.Format(A104empleadosfecreg, "99/99/9999"));
            n104empleadosfecreg = T00063_n104empleadosfecreg[0];
            A105empleadosfecultact = T00063_A105empleadosfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105empleadosfecultact", context.localUtil.Format(A105empleadosfecultact, "99/99/9999"));
            Z13empleadosid = A13empleadosid;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load066( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey066( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00066_A13empleadosid[0] < A13empleadosid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00066_A13empleadosid[0] > A13empleadosid ) ) )
            {
               A13empleadosid = T00066_A13empleadosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               n13empleadosid = T00066_n13empleadosid[0];
               RcdFound6 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {n13empleadosid, A13empleadosid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00067_A13empleadosid[0] > A13empleadosid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00067_A13empleadosid[0] < A13empleadosid ) ) )
            {
               A13empleadosid = T00067_A13empleadosid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
               n13empleadosid = T00067_n13empleadosid[0];
               RcdFound6 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey066( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtempleadosareaid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert066( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A13empleadosid != Z13empleadosid )
               {
                  A13empleadosid = Z13empleadosid;
                  n13empleadosid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPLEADOSID");
                  AnyError = 1;
                  GX_FocusControl = edtempleadosid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtempleadosareaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update066( ) ;
                  GX_FocusControl = edtempleadosareaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A13empleadosid != Z13empleadosid )
               {
                  /* Insert record */
                  GX_FocusControl = edtempleadosareaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert066( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPLEADOSID");
                     AnyError = 1;
                     GX_FocusControl = edtempleadosid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtempleadosareaid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert066( ) ;
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
         if ( A13empleadosid != Z13empleadosid )
         {
            A13empleadosid = Z13empleadosid;
            n13empleadosid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPLEADOSID");
            AnyError = 1;
            GX_FocusControl = edtempleadosid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtempleadosareaid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {n13empleadosid, A13empleadosid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPLEADOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z98empleadosareaid, T00062_A98empleadosareaid[0]) != 0 ) || ( StringUtil.StrCmp(Z99empleadosnomemple, T00062_A99empleadosnomemple[0]) != 0 ) || ( StringUtil.StrCmp(Z100empleadosappaterno, T00062_A100empleadosappaterno[0]) != 0 ) || ( StringUtil.StrCmp(Z101empleadosapmaterno, T00062_A101empleadosapmaterno[0]) != 0 ) || ( StringUtil.StrCmp(Z102empleadosstatus, T00062_A102empleadosstatus[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z103empleadosusuario, T00062_A103empleadosusuario[0]) != 0 ) || ( StringUtil.StrCmp(Z106empleadoscorreo, T00062_A106empleadoscorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z107empleadosext, T00062_A107empleadosext[0]) != 0 ) || ( Z104empleadosfecreg != T00062_A104empleadosfecreg[0] ) || ( Z105empleadosfecultact != T00062_A105empleadosfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z98empleadosareaid, T00062_A98empleadosareaid[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosareaid");
                  GXUtil.WriteLogRaw("Old: ",Z98empleadosareaid);
                  GXUtil.WriteLogRaw("Current: ",T00062_A98empleadosareaid[0]);
               }
               if ( StringUtil.StrCmp(Z99empleadosnomemple, T00062_A99empleadosnomemple[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosnomemple");
                  GXUtil.WriteLogRaw("Old: ",Z99empleadosnomemple);
                  GXUtil.WriteLogRaw("Current: ",T00062_A99empleadosnomemple[0]);
               }
               if ( StringUtil.StrCmp(Z100empleadosappaterno, T00062_A100empleadosappaterno[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosappaterno");
                  GXUtil.WriteLogRaw("Old: ",Z100empleadosappaterno);
                  GXUtil.WriteLogRaw("Current: ",T00062_A100empleadosappaterno[0]);
               }
               if ( StringUtil.StrCmp(Z101empleadosapmaterno, T00062_A101empleadosapmaterno[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosapmaterno");
                  GXUtil.WriteLogRaw("Old: ",Z101empleadosapmaterno);
                  GXUtil.WriteLogRaw("Current: ",T00062_A101empleadosapmaterno[0]);
               }
               if ( StringUtil.StrCmp(Z102empleadosstatus, T00062_A102empleadosstatus[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosstatus");
                  GXUtil.WriteLogRaw("Old: ",Z102empleadosstatus);
                  GXUtil.WriteLogRaw("Current: ",T00062_A102empleadosstatus[0]);
               }
               if ( StringUtil.StrCmp(Z103empleadosusuario, T00062_A103empleadosusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosusuario");
                  GXUtil.WriteLogRaw("Old: ",Z103empleadosusuario);
                  GXUtil.WriteLogRaw("Current: ",T00062_A103empleadosusuario[0]);
               }
               if ( StringUtil.StrCmp(Z106empleadoscorreo, T00062_A106empleadoscorreo[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadoscorreo");
                  GXUtil.WriteLogRaw("Old: ",Z106empleadoscorreo);
                  GXUtil.WriteLogRaw("Current: ",T00062_A106empleadoscorreo[0]);
               }
               if ( StringUtil.StrCmp(Z107empleadosext, T00062_A107empleadosext[0]) != 0 )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosext");
                  GXUtil.WriteLogRaw("Old: ",Z107empleadosext);
                  GXUtil.WriteLogRaw("Current: ",T00062_A107empleadosext[0]);
               }
               if ( Z104empleadosfecreg != T00062_A104empleadosfecreg[0] )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z104empleadosfecreg);
                  GXUtil.WriteLogRaw("Current: ",T00062_A104empleadosfecreg[0]);
               }
               if ( Z105empleadosfecultact != T00062_A105empleadosfecultact[0] )
               {
                  GXUtil.WriteLog("empleados:[seudo value changed for attri]"+"empleadosfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z105empleadosfecultact);
                  GXUtil.WriteLogRaw("Current: ",T00062_A105empleadosfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EMPLEADOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM066( 0) ;
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00068 */
                     pr_default.execute(6, new Object[] {n13empleadosid, A13empleadosid, n98empleadosareaid, A98empleadosareaid, n99empleadosnomemple, A99empleadosnomemple, n100empleadosappaterno, A100empleadosappaterno, n101empleadosapmaterno, A101empleadosapmaterno, n102empleadosstatus, A102empleadosstatus, n103empleadosusuario, A103empleadosusuario, n106empleadoscorreo, A106empleadoscorreo, n107empleadosext, A107empleadosext, n104empleadosfecreg, A104empleadosfecreg, A105empleadosfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
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
                           ResetCaption060( ) ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00069 */
                     pr_default.execute(7, new Object[] {n98empleadosareaid, A98empleadosareaid, n99empleadosnomemple, A99empleadosnomemple, n100empleadosappaterno, A100empleadosappaterno, n101empleadosapmaterno, A101empleadosapmaterno, n102empleadosstatus, A102empleadosstatus, n103empleadosusuario, A103empleadosusuario, n106empleadoscorreo, A106empleadoscorreo, n107empleadosext, A107empleadosext, n104empleadosfecreg, A104empleadosfecreg, A105empleadosfecultact, n13empleadosid, A13empleadosid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPLEADOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate066( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls066( ) ;
            AfterConfirm066( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete066( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000610 */
                  pr_default.execute(8, new Object[] {n13empleadosid, A13empleadosid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("EMPLEADOS") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel066( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000611 */
            pr_default.execute(9, new Object[] {n13empleadosid, A13empleadosid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"almacen"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete066( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "empleados");
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "empleados");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart066( )
      {
         /* Scan By routine */
         /* Using cursor T000612 */
         pr_default.execute(10);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound6 = 1;
            A13empleadosid = T000612_A13empleadosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            n13empleadosid = T000612_n13empleadosid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext066( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound6 = 1;
            A13empleadosid = T000612_A13empleadosid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
            n13empleadosid = T000612_n13empleadosid[0];
         }
      }

      protected void ScanEnd066( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes066( )
      {
         edtempleadosid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosid_Enabled), 5, 0)));
         edtempleadosareaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosareaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosareaid_Enabled), 5, 0)));
         edtempleadosnomemple_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosnomemple_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosnomemple_Enabled), 5, 0)));
         edtempleadosappaterno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosappaterno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosappaterno_Enabled), 5, 0)));
         edtempleadosapmaterno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosapmaterno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosapmaterno_Enabled), 5, 0)));
         edtempleadosstatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosstatus_Enabled), 5, 0)));
         edtempleadosusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosusuario_Enabled), 5, 0)));
         edtempleadoscorreo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadoscorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadoscorreo_Enabled), 5, 0)));
         edtempleadosext_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosext_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosext_Enabled), 5, 0)));
         edtempleadosfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosfecreg_Enabled), 5, 0)));
         edtempleadosfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadosfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadosfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?2022215584679");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("empleados.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7empleadosid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z13empleadosid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13empleadosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z98empleadosareaid", Z98empleadosareaid);
         GxWebStd.gx_hidden_field( context, "Z99empleadosnomemple", Z99empleadosnomemple);
         GxWebStd.gx_hidden_field( context, "Z100empleadosappaterno", Z100empleadosappaterno);
         GxWebStd.gx_hidden_field( context, "Z101empleadosapmaterno", Z101empleadosapmaterno);
         GxWebStd.gx_hidden_field( context, "Z102empleadosstatus", Z102empleadosstatus);
         GxWebStd.gx_hidden_field( context, "Z103empleadosusuario", Z103empleadosusuario);
         GxWebStd.gx_hidden_field( context, "Z106empleadoscorreo", Z106empleadoscorreo);
         GxWebStd.gx_hidden_field( context, "Z107empleadosext", Z107empleadosext);
         GxWebStd.gx_hidden_field( context, "Z104empleadosfecreg", context.localUtil.DToC( Z104empleadosfecreg, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z105empleadosfecultact", context.localUtil.DToC( Z105empleadosfecultact, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vEMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empleadosid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPLEADOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empleadosid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "empleados";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("empleados:[SendSecurityCheck value for]"+"empleadosid:"+context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("empleados:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("empleados.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7empleadosid) ;
      }

      public override String GetPgmname( )
      {
         return "empleados" ;
      }

      public override String GetPgmdesc( )
      {
         return "empleados" ;
      }

      protected void InitializeNonKey066( )
      {
         A98empleadosareaid = "";
         n98empleadosareaid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A98empleadosareaid", A98empleadosareaid);
         n98empleadosareaid = (String.IsNullOrEmpty(StringUtil.RTrim( A98empleadosareaid)) ? true : false);
         A99empleadosnomemple = "";
         n99empleadosnomemple = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A99empleadosnomemple", A99empleadosnomemple);
         n99empleadosnomemple = (String.IsNullOrEmpty(StringUtil.RTrim( A99empleadosnomemple)) ? true : false);
         A100empleadosappaterno = "";
         n100empleadosappaterno = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A100empleadosappaterno", A100empleadosappaterno);
         n100empleadosappaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A100empleadosappaterno)) ? true : false);
         A101empleadosapmaterno = "";
         n101empleadosapmaterno = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101empleadosapmaterno", A101empleadosapmaterno);
         n101empleadosapmaterno = (String.IsNullOrEmpty(StringUtil.RTrim( A101empleadosapmaterno)) ? true : false);
         A102empleadosstatus = "";
         n102empleadosstatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102empleadosstatus", A102empleadosstatus);
         n102empleadosstatus = (String.IsNullOrEmpty(StringUtil.RTrim( A102empleadosstatus)) ? true : false);
         A103empleadosusuario = "";
         n103empleadosusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103empleadosusuario", A103empleadosusuario);
         n103empleadosusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A103empleadosusuario)) ? true : false);
         A106empleadoscorreo = "";
         n106empleadoscorreo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106empleadoscorreo", A106empleadoscorreo);
         n106empleadoscorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A106empleadoscorreo)) ? true : false);
         A107empleadosext = "";
         n107empleadosext = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107empleadosext", A107empleadosext);
         n107empleadosext = (String.IsNullOrEmpty(StringUtil.RTrim( A107empleadosext)) ? true : false);
         A104empleadosfecreg = DateTime.MinValue;
         n104empleadosfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104empleadosfecreg", context.localUtil.Format(A104empleadosfecreg, "99/99/9999"));
         n104empleadosfecreg = ((DateTime.MinValue==A104empleadosfecreg) ? true : false);
         A105empleadosfecultact = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105empleadosfecultact", context.localUtil.Format(A105empleadosfecultact, "99/99/9999"));
         Z98empleadosareaid = "";
         Z99empleadosnomemple = "";
         Z100empleadosappaterno = "";
         Z101empleadosapmaterno = "";
         Z102empleadosstatus = "";
         Z103empleadosusuario = "";
         Z106empleadoscorreo = "";
         Z107empleadosext = "";
         Z104empleadosfecreg = DateTime.MinValue;
         Z105empleadosfecultact = DateTime.MinValue;
      }

      protected void InitAll066( )
      {
         A13empleadosid = 0;
         n13empleadosid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13empleadosid", StringUtil.LTrim( StringUtil.Str( (decimal)(A13empleadosid), 9, 0)));
         InitializeNonKey066( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215584687");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("empleados.js", "?2022215584687");
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
         edtempleadosid_Internalname = "EMPLEADOSID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosareaid_Internalname = "EMPLEADOSAREAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosusuario_Internalname = "EMPLEADOSUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadoscorreo_Internalname = "EMPLEADOSCORREO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosext_Internalname = "EMPLEADOSEXT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosfecreg_Internalname = "EMPLEADOSFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadosfecultact_Internalname = "EMPLEADOSFECULTACT";
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
         Form.Caption = "empleados";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtempleadosfecultact_Jsonclick = "";
         edtempleadosfecultact_Enabled = 1;
         edtempleadosfecreg_Jsonclick = "";
         edtempleadosfecreg_Enabled = 1;
         edtempleadosext_Jsonclick = "";
         edtempleadosext_Enabled = 1;
         edtempleadoscorreo_Jsonclick = "";
         edtempleadoscorreo_Enabled = 1;
         edtempleadosusuario_Jsonclick = "";
         edtempleadosusuario_Enabled = 1;
         edtempleadosstatus_Jsonclick = "";
         edtempleadosstatus_Enabled = 1;
         edtempleadosapmaterno_Jsonclick = "";
         edtempleadosapmaterno_Enabled = 1;
         edtempleadosappaterno_Jsonclick = "";
         edtempleadosappaterno_Enabled = 1;
         edtempleadosnomemple_Jsonclick = "";
         edtempleadosnomemple_Enabled = 1;
         edtempleadosareaid_Jsonclick = "";
         edtempleadosareaid_Enabled = 1;
         edtempleadosid_Jsonclick = "";
         edtempleadosid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7empleadosid',fld:'vEMPLEADOSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z98empleadosareaid = "";
         Z99empleadosnomemple = "";
         Z100empleadosappaterno = "";
         Z101empleadosapmaterno = "";
         Z102empleadosstatus = "";
         Z103empleadosusuario = "";
         Z106empleadoscorreo = "";
         Z107empleadosext = "";
         Z104empleadosfecreg = DateTime.MinValue;
         Z105empleadosfecultact = DateTime.MinValue;
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
         A98empleadosareaid = "";
         A99empleadosnomemple = "";
         A100empleadosappaterno = "";
         A101empleadosapmaterno = "";
         A102empleadosstatus = "";
         A103empleadosusuario = "";
         A106empleadoscorreo = "";
         A107empleadosext = "";
         A104empleadosfecreg = DateTime.MinValue;
         A105empleadosfecultact = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00064_A13empleadosid = new int[1] ;
         T00064_n13empleadosid = new bool[] {false} ;
         T00064_A98empleadosareaid = new String[] {""} ;
         T00064_n98empleadosareaid = new bool[] {false} ;
         T00064_A99empleadosnomemple = new String[] {""} ;
         T00064_n99empleadosnomemple = new bool[] {false} ;
         T00064_A100empleadosappaterno = new String[] {""} ;
         T00064_n100empleadosappaterno = new bool[] {false} ;
         T00064_A101empleadosapmaterno = new String[] {""} ;
         T00064_n101empleadosapmaterno = new bool[] {false} ;
         T00064_A102empleadosstatus = new String[] {""} ;
         T00064_n102empleadosstatus = new bool[] {false} ;
         T00064_A103empleadosusuario = new String[] {""} ;
         T00064_n103empleadosusuario = new bool[] {false} ;
         T00064_A106empleadoscorreo = new String[] {""} ;
         T00064_n106empleadoscorreo = new bool[] {false} ;
         T00064_A107empleadosext = new String[] {""} ;
         T00064_n107empleadosext = new bool[] {false} ;
         T00064_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         T00064_n104empleadosfecreg = new bool[] {false} ;
         T00064_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         T00065_A13empleadosid = new int[1] ;
         T00065_n13empleadosid = new bool[] {false} ;
         T00063_A13empleadosid = new int[1] ;
         T00063_n13empleadosid = new bool[] {false} ;
         T00063_A98empleadosareaid = new String[] {""} ;
         T00063_n98empleadosareaid = new bool[] {false} ;
         T00063_A99empleadosnomemple = new String[] {""} ;
         T00063_n99empleadosnomemple = new bool[] {false} ;
         T00063_A100empleadosappaterno = new String[] {""} ;
         T00063_n100empleadosappaterno = new bool[] {false} ;
         T00063_A101empleadosapmaterno = new String[] {""} ;
         T00063_n101empleadosapmaterno = new bool[] {false} ;
         T00063_A102empleadosstatus = new String[] {""} ;
         T00063_n102empleadosstatus = new bool[] {false} ;
         T00063_A103empleadosusuario = new String[] {""} ;
         T00063_n103empleadosusuario = new bool[] {false} ;
         T00063_A106empleadoscorreo = new String[] {""} ;
         T00063_n106empleadoscorreo = new bool[] {false} ;
         T00063_A107empleadosext = new String[] {""} ;
         T00063_n107empleadosext = new bool[] {false} ;
         T00063_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         T00063_n104empleadosfecreg = new bool[] {false} ;
         T00063_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         T00066_A13empleadosid = new int[1] ;
         T00066_n13empleadosid = new bool[] {false} ;
         T00067_A13empleadosid = new int[1] ;
         T00067_n13empleadosid = new bool[] {false} ;
         T00062_A13empleadosid = new int[1] ;
         T00062_n13empleadosid = new bool[] {false} ;
         T00062_A98empleadosareaid = new String[] {""} ;
         T00062_n98empleadosareaid = new bool[] {false} ;
         T00062_A99empleadosnomemple = new String[] {""} ;
         T00062_n99empleadosnomemple = new bool[] {false} ;
         T00062_A100empleadosappaterno = new String[] {""} ;
         T00062_n100empleadosappaterno = new bool[] {false} ;
         T00062_A101empleadosapmaterno = new String[] {""} ;
         T00062_n101empleadosapmaterno = new bool[] {false} ;
         T00062_A102empleadosstatus = new String[] {""} ;
         T00062_n102empleadosstatus = new bool[] {false} ;
         T00062_A103empleadosusuario = new String[] {""} ;
         T00062_n103empleadosusuario = new bool[] {false} ;
         T00062_A106empleadoscorreo = new String[] {""} ;
         T00062_n106empleadoscorreo = new bool[] {false} ;
         T00062_A107empleadosext = new String[] {""} ;
         T00062_n107empleadosext = new bool[] {false} ;
         T00062_A104empleadosfecreg = new DateTime[] {DateTime.MinValue} ;
         T00062_n104empleadosfecreg = new bool[] {false} ;
         T00062_A105empleadosfecultact = new DateTime[] {DateTime.MinValue} ;
         T000611_A19almacenid = new int[1] ;
         T000612_A13empleadosid = new int[1] ;
         T000612_n13empleadosid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleados__default(),
            new Object[][] {
                new Object[] {
               T00062_A13empleadosid, T00062_A98empleadosareaid, T00062_n98empleadosareaid, T00062_A99empleadosnomemple, T00062_n99empleadosnomemple, T00062_A100empleadosappaterno, T00062_n100empleadosappaterno, T00062_A101empleadosapmaterno, T00062_n101empleadosapmaterno, T00062_A102empleadosstatus,
               T00062_n102empleadosstatus, T00062_A103empleadosusuario, T00062_n103empleadosusuario, T00062_A106empleadoscorreo, T00062_n106empleadoscorreo, T00062_A107empleadosext, T00062_n107empleadosext, T00062_A104empleadosfecreg, T00062_n104empleadosfecreg, T00062_A105empleadosfecultact
               }
               , new Object[] {
               T00063_A13empleadosid, T00063_A98empleadosareaid, T00063_n98empleadosareaid, T00063_A99empleadosnomemple, T00063_n99empleadosnomemple, T00063_A100empleadosappaterno, T00063_n100empleadosappaterno, T00063_A101empleadosapmaterno, T00063_n101empleadosapmaterno, T00063_A102empleadosstatus,
               T00063_n102empleadosstatus, T00063_A103empleadosusuario, T00063_n103empleadosusuario, T00063_A106empleadoscorreo, T00063_n106empleadoscorreo, T00063_A107empleadosext, T00063_n107empleadosext, T00063_A104empleadosfecreg, T00063_n104empleadosfecreg, T00063_A105empleadosfecultact
               }
               , new Object[] {
               T00064_A13empleadosid, T00064_A98empleadosareaid, T00064_n98empleadosareaid, T00064_A99empleadosnomemple, T00064_n99empleadosnomemple, T00064_A100empleadosappaterno, T00064_n100empleadosappaterno, T00064_A101empleadosapmaterno, T00064_n101empleadosapmaterno, T00064_A102empleadosstatus,
               T00064_n102empleadosstatus, T00064_A103empleadosusuario, T00064_n103empleadosusuario, T00064_A106empleadoscorreo, T00064_n106empleadoscorreo, T00064_A107empleadosext, T00064_n107empleadosext, T00064_A104empleadosfecreg, T00064_n104empleadosfecreg, T00064_A105empleadosfecultact
               }
               , new Object[] {
               T00065_A13empleadosid
               }
               , new Object[] {
               T00066_A13empleadosid
               }
               , new Object[] {
               T00067_A13empleadosid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000611_A19almacenid
               }
               , new Object[] {
               T000612_A13empleadosid
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
      private short RcdFound6 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7empleadosid ;
      private int Z13empleadosid ;
      private int AV7empleadosid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A13empleadosid ;
      private int edtempleadosid_Enabled ;
      private int edtempleadosareaid_Enabled ;
      private int edtempleadosnomemple_Enabled ;
      private int edtempleadosappaterno_Enabled ;
      private int edtempleadosapmaterno_Enabled ;
      private int edtempleadosstatus_Enabled ;
      private int edtempleadosusuario_Enabled ;
      private int edtempleadoscorreo_Enabled ;
      private int edtempleadosext_Enabled ;
      private int edtempleadosfecreg_Enabled ;
      private int edtempleadosfecultact_Enabled ;
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
      private String edtempleadosareaid_Internalname ;
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
      private String edtempleadosid_Internalname ;
      private String edtempleadosid_Jsonclick ;
      private String edtempleadosareaid_Jsonclick ;
      private String edtempleadosnomemple_Internalname ;
      private String edtempleadosnomemple_Jsonclick ;
      private String edtempleadosappaterno_Internalname ;
      private String edtempleadosappaterno_Jsonclick ;
      private String edtempleadosapmaterno_Internalname ;
      private String edtempleadosapmaterno_Jsonclick ;
      private String edtempleadosstatus_Internalname ;
      private String edtempleadosstatus_Jsonclick ;
      private String edtempleadosusuario_Internalname ;
      private String edtempleadosusuario_Jsonclick ;
      private String edtempleadoscorreo_Internalname ;
      private String edtempleadoscorreo_Jsonclick ;
      private String edtempleadosext_Internalname ;
      private String edtempleadosext_Jsonclick ;
      private String edtempleadosfecreg_Internalname ;
      private String edtempleadosfecreg_Jsonclick ;
      private String edtempleadosfecultact_Internalname ;
      private String edtempleadosfecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z104empleadosfecreg ;
      private DateTime Z105empleadosfecultact ;
      private DateTime A104empleadosfecreg ;
      private DateTime A105empleadosfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n13empleadosid ;
      private bool n98empleadosareaid ;
      private bool n99empleadosnomemple ;
      private bool n100empleadosappaterno ;
      private bool n101empleadosapmaterno ;
      private bool n102empleadosstatus ;
      private bool n103empleadosusuario ;
      private bool n106empleadoscorreo ;
      private bool n107empleadosext ;
      private bool n104empleadosfecreg ;
      private bool Gx_longc ;
      private String Z98empleadosareaid ;
      private String Z99empleadosnomemple ;
      private String Z100empleadosappaterno ;
      private String Z101empleadosapmaterno ;
      private String Z102empleadosstatus ;
      private String Z103empleadosusuario ;
      private String Z106empleadoscorreo ;
      private String Z107empleadosext ;
      private String A98empleadosareaid ;
      private String A99empleadosnomemple ;
      private String A100empleadosappaterno ;
      private String A101empleadosapmaterno ;
      private String A102empleadosstatus ;
      private String A103empleadosusuario ;
      private String A106empleadoscorreo ;
      private String A107empleadosext ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00064_A13empleadosid ;
      private bool[] T00064_n13empleadosid ;
      private String[] T00064_A98empleadosareaid ;
      private bool[] T00064_n98empleadosareaid ;
      private String[] T00064_A99empleadosnomemple ;
      private bool[] T00064_n99empleadosnomemple ;
      private String[] T00064_A100empleadosappaterno ;
      private bool[] T00064_n100empleadosappaterno ;
      private String[] T00064_A101empleadosapmaterno ;
      private bool[] T00064_n101empleadosapmaterno ;
      private String[] T00064_A102empleadosstatus ;
      private bool[] T00064_n102empleadosstatus ;
      private String[] T00064_A103empleadosusuario ;
      private bool[] T00064_n103empleadosusuario ;
      private String[] T00064_A106empleadoscorreo ;
      private bool[] T00064_n106empleadoscorreo ;
      private String[] T00064_A107empleadosext ;
      private bool[] T00064_n107empleadosext ;
      private DateTime[] T00064_A104empleadosfecreg ;
      private bool[] T00064_n104empleadosfecreg ;
      private DateTime[] T00064_A105empleadosfecultact ;
      private int[] T00065_A13empleadosid ;
      private bool[] T00065_n13empleadosid ;
      private int[] T00063_A13empleadosid ;
      private bool[] T00063_n13empleadosid ;
      private String[] T00063_A98empleadosareaid ;
      private bool[] T00063_n98empleadosareaid ;
      private String[] T00063_A99empleadosnomemple ;
      private bool[] T00063_n99empleadosnomemple ;
      private String[] T00063_A100empleadosappaterno ;
      private bool[] T00063_n100empleadosappaterno ;
      private String[] T00063_A101empleadosapmaterno ;
      private bool[] T00063_n101empleadosapmaterno ;
      private String[] T00063_A102empleadosstatus ;
      private bool[] T00063_n102empleadosstatus ;
      private String[] T00063_A103empleadosusuario ;
      private bool[] T00063_n103empleadosusuario ;
      private String[] T00063_A106empleadoscorreo ;
      private bool[] T00063_n106empleadoscorreo ;
      private String[] T00063_A107empleadosext ;
      private bool[] T00063_n107empleadosext ;
      private DateTime[] T00063_A104empleadosfecreg ;
      private bool[] T00063_n104empleadosfecreg ;
      private DateTime[] T00063_A105empleadosfecultact ;
      private int[] T00066_A13empleadosid ;
      private bool[] T00066_n13empleadosid ;
      private int[] T00067_A13empleadosid ;
      private bool[] T00067_n13empleadosid ;
      private int[] T00062_A13empleadosid ;
      private bool[] T00062_n13empleadosid ;
      private String[] T00062_A98empleadosareaid ;
      private bool[] T00062_n98empleadosareaid ;
      private String[] T00062_A99empleadosnomemple ;
      private bool[] T00062_n99empleadosnomemple ;
      private String[] T00062_A100empleadosappaterno ;
      private bool[] T00062_n100empleadosappaterno ;
      private String[] T00062_A101empleadosapmaterno ;
      private bool[] T00062_n101empleadosapmaterno ;
      private String[] T00062_A102empleadosstatus ;
      private bool[] T00062_n102empleadosstatus ;
      private String[] T00062_A103empleadosusuario ;
      private bool[] T00062_n103empleadosusuario ;
      private String[] T00062_A106empleadoscorreo ;
      private bool[] T00062_n106empleadoscorreo ;
      private String[] T00062_A107empleadosext ;
      private bool[] T00062_n107empleadosext ;
      private DateTime[] T00062_A104empleadosfecreg ;
      private bool[] T00062_n104empleadosfecreg ;
      private DateTime[] T00062_A105empleadosfecultact ;
      private int[] T000611_A19almacenid ;
      private int[] T000612_A13empleadosid ;
      private bool[] T000612_n13empleadosid ;
      private GXWebForm Form ;
   }

   public class empleados__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"empleadosareaid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"empleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"empleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadoscorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadosext",NpgsqlDbType.Varchar,4,0} ,
          new Object[] {"empleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosfecultact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"empleadosareaid",NpgsqlDbType.Varchar,3,0} ,
          new Object[] {"empleadosnomemple",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosappaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosapmaterno",NpgsqlDbType.Varchar,30,0} ,
          new Object[] {"empleadosstatus",NpgsqlDbType.Varchar,1,0} ,
          new Object[] {"empleadosusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadoscorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadosext",NpgsqlDbType.Varchar,4,0} ,
          new Object[] {"empleadosfecreg",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosfecultact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"empleadosid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT empleadosid, empleadosareaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact FROM public.empleados WHERE empleadosid = :empleadosid  FOR UPDATE OF empleados NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT empleadosid, empleadosareaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT TM1.empleadosid, TM1.empleadosareaid, TM1.empleadosnomemple, TM1.empleadosappaterno, TM1.empleadosapmaterno, TM1.empleadosstatus, TM1.empleadosusuario, TM1.empleadoscorreo, TM1.empleadosext, TM1.empleadosfecreg, TM1.empleadosfecultact FROM public.empleados TM1 WHERE TM1.empleadosid = :empleadosid ORDER BY TM1.empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,100,0,true,false )
             ,new CursorDef("T00065", "SELECT empleadosid FROM public.empleados WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,false )
             ,new CursorDef("T00066", "SELECT empleadosid FROM public.empleados WHERE ( empleadosid > :empleadosid) ORDER BY empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,true )
             ,new CursorDef("T00067", "SELECT empleadosid FROM public.empleados WHERE ( empleadosid < :empleadosid) ORDER BY empleadosid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,true )
             ,new CursorDef("T00068", "SAVEPOINT gxupdate;INSERT INTO public.empleados(empleadosid, empleadosareaid, empleadosnomemple, empleadosappaterno, empleadosapmaterno, empleadosstatus, empleadosusuario, empleadoscorreo, empleadosext, empleadosfecreg, empleadosfecultact) VALUES(:empleadosid, :empleadosareaid, :empleadosnomemple, :empleadosappaterno, :empleadosapmaterno, :empleadosstatus, :empleadosusuario, :empleadoscorreo, :empleadosext, :empleadosfecreg, :empleadosfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT00068)
             ,new CursorDef("T00069", "SAVEPOINT gxupdate;UPDATE public.empleados SET empleadosareaid=:empleadosareaid, empleadosnomemple=:empleadosnomemple, empleadosappaterno=:empleadosappaterno, empleadosapmaterno=:empleadosapmaterno, empleadosstatus=:empleadosstatus, empleadosusuario=:empleadosusuario, empleadoscorreo=:empleadoscorreo, empleadosext=:empleadosext, empleadosfecreg=:empleadosfecreg, empleadosfecultact=:empleadosfecultact  WHERE empleadosid = :empleadosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT00069)
             ,new CursorDef("T000610", "SAVEPOINT gxupdate;DELETE FROM public.empleados  WHERE empleadosid = :empleadosid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000610)
             ,new CursorDef("T000611", "SELECT almacenid FROM public.almacen WHERE empleadosid = :empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,true )
             ,new CursorDef("T000612", "SELECT empleadosid FROM public.empleados ORDER BY empleadosid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000612,100,0,true,false )
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
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
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
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
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
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
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
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(10, (DateTime)parms[19]);
                }
                stmt.SetParameter(11, (DateTime)parms[20]);
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
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[17]);
                }
                stmt.SetParameter(10, (DateTime)parms[18]);
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[20]);
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
