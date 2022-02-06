/*
               File: empleadospiso
        Description: empleadospiso
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/5/2022 15:59:34.97
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
   public class empleadospiso : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7empleadospisoextid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empleadospisoextid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPLEADOSPISOEXTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empleadospisoextid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "empleadospiso", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtempleadospisoextpiso_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public empleadospiso( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public empleadospiso( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_empleadospisoextid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7empleadospisoextid = aP1_empleadospisoextid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "empleadospiso", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextid_Internalname, "empleadospisoextid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A46empleadospisoextid), 9, 0, ",", "")), ((edtempleadospisoextid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextid_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextpiso_Internalname, "empleadospisoextpiso", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextpiso_Internalname, A47empleadospisoextpiso, StringUtil.RTrim( context.localUtil.Format( A47empleadospisoextpiso, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextpiso_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextpiso_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextext_Internalname, "empleadospisoextext", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextext_Internalname, A48empleadospisoextext, StringUtil.RTrim( context.localUtil.Format( A48empleadospisoextext, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextext_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextext_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextcorreo_Internalname, "empleadospisoextcorreo", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextcorreo_Internalname, A49empleadospisoextcorreo, StringUtil.RTrim( context.localUtil.Format( A49empleadospisoextcorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextcorreo_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextcorreo_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadopisoextprofesion_Internalname, "empleadopisoextprofesion", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadopisoextprofesion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A50empleadopisoextprofesion), 11, 0, ",", "")), ((edtempleadopisoextprofesion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A50empleadopisoextprofesion), "ZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A50empleadopisoextprofesion), "ZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadopisoextprofesion_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadopisoextprofesion_Enabled, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextusuario_Internalname, "empleadospisoextusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextusuario_Internalname, A51empleadospisoextusuario, StringUtil.RTrim( context.localUtil.Format( A51empleadospisoextusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextfecgre_Internalname, "empleadospisoextfecgre", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtempleadospisoextfecgre_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextfecgre_Internalname, context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"), context.localUtil.Format( A52empleadospisoextfecgre, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextfecgre_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextfecgre_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleadospiso.htm");
            GxWebStd.gx_bitmap( context, edtempleadospisoextfecgre_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtempleadospisoextfecgre_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_label_element( context, edtempleadospisoextfeact_Internalname, "empleadospisoextfeact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtempleadospisoextfeact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtempleadospisoextfeact_Internalname, context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"), context.localUtil.Format( A53empleadospisoextfeact, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempleadospisoextfeact_Jsonclick, 0, "Attribute", "", "", "", 1, edtempleadospisoextfeact_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_empleadospiso.htm");
            GxWebStd.gx_bitmap( context, edtempleadospisoextfeact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtempleadospisoextfeact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_empleadospiso.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_empleadospiso.htm");
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
               A46empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( edtempleadospisoextid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
               A47empleadospisoextpiso = cgiGet( edtempleadospisoextpiso_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47empleadospisoextpiso", A47empleadospisoextpiso);
               A48empleadospisoextext = cgiGet( edtempleadospisoextext_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48empleadospisoextext", A48empleadospisoextext);
               A49empleadospisoextcorreo = cgiGet( edtempleadospisoextcorreo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49empleadospisoextcorreo", A49empleadospisoextcorreo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtempleadopisoextprofesion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtempleadopisoextprofesion_Internalname), ",", ".") > Convert.ToDecimal( 99999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EMPLEADOPISOEXTPROFESION");
                  AnyError = 1;
                  GX_FocusControl = edtempleadopisoextprofesion_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A50empleadopisoextprofesion = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(A50empleadopisoextprofesion), 11, 0)));
               }
               else
               {
                  A50empleadopisoextprofesion = (long)(context.localUtil.CToN( cgiGet( edtempleadopisoextprofesion_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(A50empleadopisoextprofesion), 11, 0)));
               }
               A51empleadospisoextusuario = cgiGet( edtempleadospisoextusuario_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51empleadospisoextusuario", A51empleadospisoextusuario);
               if ( context.localUtil.VCDate( cgiGet( edtempleadospisoextfecgre_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadospisoextfecgre"}), 1, "EMPLEADOSPISOEXTFECGRE");
                  AnyError = 1;
                  GX_FocusControl = edtempleadospisoextfecgre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A52empleadospisoextfecgre = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52empleadospisoextfecgre", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
               }
               else
               {
                  A52empleadospisoextfecgre = context.localUtil.CToD( cgiGet( edtempleadospisoextfecgre_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52empleadospisoextfecgre", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtempleadospisoextfeact_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"empleadospisoextfeact"}), 1, "EMPLEADOSPISOEXTFEACT");
                  AnyError = 1;
                  GX_FocusControl = edtempleadospisoextfeact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A53empleadospisoextfeact = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53empleadospisoextfeact", context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"));
               }
               else
               {
                  A53empleadospisoextfeact = context.localUtil.CToD( cgiGet( edtempleadospisoextfeact_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53empleadospisoextfeact", context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"));
               }
               /* Read saved values. */
               Z46empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( "Z46empleadospisoextid"), ",", "."));
               Z47empleadospisoextpiso = cgiGet( "Z47empleadospisoextpiso");
               Z48empleadospisoextext = cgiGet( "Z48empleadospisoextext");
               Z49empleadospisoextcorreo = cgiGet( "Z49empleadospisoextcorreo");
               Z50empleadopisoextprofesion = (long)(context.localUtil.CToN( cgiGet( "Z50empleadopisoextprofesion"), ",", "."));
               Z51empleadospisoextusuario = cgiGet( "Z51empleadospisoextusuario");
               Z52empleadospisoextfecgre = context.localUtil.CToD( cgiGet( "Z52empleadospisoextfecgre"), 0);
               Z53empleadospisoextfeact = context.localUtil.CToD( cgiGet( "Z53empleadospisoextfeact"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( "vEMPLEADOSPISOEXTID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "empleadospiso";
               A46empleadospisoextid = (int)(context.localUtil.CToN( cgiGet( edtempleadospisoextid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A46empleadospisoextid != Z46empleadospisoextid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("empleadospiso:[SecurityCheckFailed value for]"+"empleadospisoextid:"+context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("empleadospiso:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A46empleadospisoextid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
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
                     sMode24 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode24;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound24 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0O0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EMPLEADOSPISOEXTID");
                        AnyError = 1;
                        GX_FocusControl = edtempleadospisoextid_Internalname;
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
               InitAll0O24( ) ;
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
            DisableAttributes0O24( ) ;
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

      protected void CONFIRM_0O0( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0O24( ) ;
            }
            else
            {
               CheckExtendedTable0O24( ) ;
               CloseExtendedTableCursors0O24( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0O0( )
      {
      }

      protected void ZM0O24( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z47empleadospisoextpiso = T000O3_A47empleadospisoextpiso[0];
               Z48empleadospisoextext = T000O3_A48empleadospisoextext[0];
               Z49empleadospisoextcorreo = T000O3_A49empleadospisoextcorreo[0];
               Z50empleadopisoextprofesion = T000O3_A50empleadopisoextprofesion[0];
               Z51empleadospisoextusuario = T000O3_A51empleadospisoextusuario[0];
               Z52empleadospisoextfecgre = T000O3_A52empleadospisoextfecgre[0];
               Z53empleadospisoextfeact = T000O3_A53empleadospisoextfeact[0];
            }
            else
            {
               Z47empleadospisoextpiso = A47empleadospisoextpiso;
               Z48empleadospisoextext = A48empleadospisoextext;
               Z49empleadospisoextcorreo = A49empleadospisoextcorreo;
               Z50empleadopisoextprofesion = A50empleadopisoextprofesion;
               Z51empleadospisoextusuario = A51empleadospisoextusuario;
               Z52empleadospisoextfecgre = A52empleadospisoextfecgre;
               Z53empleadospisoextfeact = A53empleadospisoextfeact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z46empleadospisoextid = A46empleadospisoextid;
            Z47empleadospisoextpiso = A47empleadospisoextpiso;
            Z48empleadospisoextext = A48empleadospisoextext;
            Z49empleadospisoextcorreo = A49empleadospisoextcorreo;
            Z50empleadopisoextprofesion = A50empleadopisoextprofesion;
            Z51empleadospisoextusuario = A51empleadospisoextusuario;
            Z52empleadospisoextfecgre = A52empleadospisoextfecgre;
            Z53empleadospisoextfeact = A53empleadospisoextfeact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtempleadospisoextid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextid_Enabled), 5, 0)));
         edtempleadospisoextid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7empleadospisoextid) )
         {
            A46empleadospisoextid = AV7empleadospisoextid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
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

      protected void Load0O24( )
      {
         /* Using cursor T000O4 */
         pr_default.execute(2, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound24 = 1;
            A47empleadospisoextpiso = T000O4_A47empleadospisoextpiso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47empleadospisoextpiso", A47empleadospisoextpiso);
            A48empleadospisoextext = T000O4_A48empleadospisoextext[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48empleadospisoextext", A48empleadospisoextext);
            A49empleadospisoextcorreo = T000O4_A49empleadospisoextcorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49empleadospisoextcorreo", A49empleadospisoextcorreo);
            A50empleadopisoextprofesion = T000O4_A50empleadopisoextprofesion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(A50empleadopisoextprofesion), 11, 0)));
            A51empleadospisoextusuario = T000O4_A51empleadospisoextusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51empleadospisoextusuario", A51empleadospisoextusuario);
            A52empleadospisoextfecgre = T000O4_A52empleadospisoextfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52empleadospisoextfecgre", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
            A53empleadospisoextfeact = T000O4_A53empleadospisoextfeact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53empleadospisoextfeact", context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"));
            ZM0O24( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0O24( ) ;
      }

      protected void OnLoadActions0O24( )
      {
      }

      protected void CheckExtendedTable0O24( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0O24( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0O24( )
      {
         /* Using cursor T000O5 */
         pr_default.execute(3, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound24 = 1;
         }
         else
         {
            RcdFound24 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000O3 */
         pr_default.execute(1, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O24( 3) ;
            RcdFound24 = 1;
            A46empleadospisoextid = T000O3_A46empleadospisoextid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
            A47empleadospisoextpiso = T000O3_A47empleadospisoextpiso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47empleadospisoextpiso", A47empleadospisoextpiso);
            A48empleadospisoextext = T000O3_A48empleadospisoextext[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48empleadospisoextext", A48empleadospisoextext);
            A49empleadospisoextcorreo = T000O3_A49empleadospisoextcorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49empleadospisoextcorreo", A49empleadospisoextcorreo);
            A50empleadopisoextprofesion = T000O3_A50empleadopisoextprofesion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(A50empleadopisoextprofesion), 11, 0)));
            A51empleadospisoextusuario = T000O3_A51empleadospisoextusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51empleadospisoextusuario", A51empleadospisoextusuario);
            A52empleadospisoextfecgre = T000O3_A52empleadospisoextfecgre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52empleadospisoextfecgre", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
            A53empleadospisoextfeact = T000O3_A53empleadospisoextfeact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53empleadospisoextfeact", context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"));
            Z46empleadospisoextid = A46empleadospisoextid;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0O24( ) ;
            if ( AnyError == 1 )
            {
               RcdFound24 = 0;
               InitializeNonKey0O24( ) ;
            }
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound24 = 0;
            InitializeNonKey0O24( ) ;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O24( ) ;
         if ( RcdFound24 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound24 = 0;
         /* Using cursor T000O6 */
         pr_default.execute(4, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000O6_A46empleadospisoextid[0] < A46empleadospisoextid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000O6_A46empleadospisoextid[0] > A46empleadospisoextid ) ) )
            {
               A46empleadospisoextid = T000O6_A46empleadospisoextid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
               RcdFound24 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound24 = 0;
         /* Using cursor T000O7 */
         pr_default.execute(5, new Object[] {A46empleadospisoextid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000O7_A46empleadospisoextid[0] > A46empleadospisoextid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000O7_A46empleadospisoextid[0] < A46empleadospisoextid ) ) )
            {
               A46empleadospisoextid = T000O7_A46empleadospisoextid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
               RcdFound24 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0O24( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtempleadospisoextpiso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0O24( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound24 == 1 )
            {
               if ( A46empleadospisoextid != Z46empleadospisoextid )
               {
                  A46empleadospisoextid = Z46empleadospisoextid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPLEADOSPISOEXTID");
                  AnyError = 1;
                  GX_FocusControl = edtempleadospisoextid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtempleadospisoextpiso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0O24( ) ;
                  GX_FocusControl = edtempleadospisoextpiso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A46empleadospisoextid != Z46empleadospisoextid )
               {
                  /* Insert record */
                  GX_FocusControl = edtempleadospisoextpiso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0O24( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPLEADOSPISOEXTID");
                     AnyError = 1;
                     GX_FocusControl = edtempleadospisoextid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtempleadospisoextpiso_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0O24( ) ;
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
         if ( A46empleadospisoextid != Z46empleadospisoextid )
         {
            A46empleadospisoextid = Z46empleadospisoextid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPLEADOSPISOEXTID");
            AnyError = 1;
            GX_FocusControl = edtempleadospisoextid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtempleadospisoextpiso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O2 */
            pr_default.execute(0, new Object[] {A46empleadospisoextid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"empleadospiso"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z47empleadospisoextpiso, T000O2_A47empleadospisoextpiso[0]) != 0 ) || ( StringUtil.StrCmp(Z48empleadospisoextext, T000O2_A48empleadospisoextext[0]) != 0 ) || ( StringUtil.StrCmp(Z49empleadospisoextcorreo, T000O2_A49empleadospisoextcorreo[0]) != 0 ) || ( Z50empleadopisoextprofesion != T000O2_A50empleadopisoextprofesion[0] ) || ( StringUtil.StrCmp(Z51empleadospisoextusuario, T000O2_A51empleadospisoextusuario[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z52empleadospisoextfecgre != T000O2_A52empleadospisoextfecgre[0] ) || ( Z53empleadospisoextfeact != T000O2_A53empleadospisoextfeact[0] ) )
            {
               if ( StringUtil.StrCmp(Z47empleadospisoextpiso, T000O2_A47empleadospisoextpiso[0]) != 0 )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextpiso");
                  GXUtil.WriteLogRaw("Old: ",Z47empleadospisoextpiso);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A47empleadospisoextpiso[0]);
               }
               if ( StringUtil.StrCmp(Z48empleadospisoextext, T000O2_A48empleadospisoextext[0]) != 0 )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextext");
                  GXUtil.WriteLogRaw("Old: ",Z48empleadospisoextext);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A48empleadospisoextext[0]);
               }
               if ( StringUtil.StrCmp(Z49empleadospisoextcorreo, T000O2_A49empleadospisoextcorreo[0]) != 0 )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextcorreo");
                  GXUtil.WriteLogRaw("Old: ",Z49empleadospisoextcorreo);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A49empleadospisoextcorreo[0]);
               }
               if ( Z50empleadopisoextprofesion != T000O2_A50empleadopisoextprofesion[0] )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadopisoextprofesion");
                  GXUtil.WriteLogRaw("Old: ",Z50empleadopisoextprofesion);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A50empleadopisoextprofesion[0]);
               }
               if ( StringUtil.StrCmp(Z51empleadospisoextusuario, T000O2_A51empleadospisoextusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextusuario");
                  GXUtil.WriteLogRaw("Old: ",Z51empleadospisoextusuario);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A51empleadospisoextusuario[0]);
               }
               if ( Z52empleadospisoextfecgre != T000O2_A52empleadospisoextfecgre[0] )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextfecgre");
                  GXUtil.WriteLogRaw("Old: ",Z52empleadospisoextfecgre);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A52empleadospisoextfecgre[0]);
               }
               if ( Z53empleadospisoextfeact != T000O2_A53empleadospisoextfeact[0] )
               {
                  GXUtil.WriteLog("empleadospiso:[seudo value changed for attri]"+"empleadospisoextfeact");
                  GXUtil.WriteLogRaw("Old: ",Z53empleadospisoextfeact);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A53empleadospisoextfeact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"empleadospiso"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O24( 0) ;
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O8 */
                     pr_default.execute(6, new Object[] {A46empleadospisoextid, A47empleadospisoextpiso, A48empleadospisoextext, A49empleadospisoextcorreo, A50empleadopisoextprofesion, A51empleadospisoextusuario, A52empleadospisoextfecgre, A53empleadospisoextfeact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
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
                           ResetCaption0O0( ) ;
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
               Load0O24( ) ;
            }
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void Update0O24( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O9 */
                     pr_default.execute(7, new Object[] {A47empleadospisoextpiso, A48empleadospisoextext, A49empleadospisoextcorreo, A50empleadopisoextprofesion, A51empleadospisoextusuario, A52empleadospisoextfecgre, A53empleadospisoextfeact, A46empleadospisoextid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"empleadospiso"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O24( ) ;
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
            EndLevel0O24( ) ;
         }
         CloseExtendedTableCursors0O24( ) ;
      }

      protected void DeferredUpdate0O24( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0O24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O24( ) ;
            AfterConfirm0O24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000O10 */
                  pr_default.execute(8, new Object[] {A46empleadospisoextid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("empleadospiso") ;
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
         sMode24 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0O24( ) ;
         Gx_mode = sMode24;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0O24( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0O24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O24( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "empleadospiso");
            if ( AnyError == 0 )
            {
               ConfirmValues0O0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "empleadospiso");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0O24( )
      {
         /* Scan By routine */
         /* Using cursor T000O11 */
         pr_default.execute(9);
         RcdFound24 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound24 = 1;
            A46empleadospisoextid = T000O11_A46empleadospisoextid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O24( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound24 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound24 = 1;
            A46empleadospisoextid = T000O11_A46empleadospisoextid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
         }
      }

      protected void ScanEnd0O24( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0O24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O24( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O24( )
      {
         edtempleadospisoextid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextid_Enabled), 5, 0)));
         edtempleadospisoextpiso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextpiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextpiso_Enabled), 5, 0)));
         edtempleadospisoextext_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextext_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextext_Enabled), 5, 0)));
         edtempleadospisoextcorreo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextcorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextcorreo_Enabled), 5, 0)));
         edtempleadopisoextprofesion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadopisoextprofesion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadopisoextprofesion_Enabled), 5, 0)));
         edtempleadospisoextusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextusuario_Enabled), 5, 0)));
         edtempleadospisoextfecgre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextfecgre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextfecgre_Enabled), 5, 0)));
         edtempleadospisoextfeact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempleadospisoextfeact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempleadospisoextfeact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0O0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20222515593568");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("empleadospiso.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7empleadospisoextid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z46empleadospisoextid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z46empleadospisoextid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z47empleadospisoextpiso", Z47empleadospisoextpiso);
         GxWebStd.gx_hidden_field( context, "Z48empleadospisoextext", Z48empleadospisoextext);
         GxWebStd.gx_hidden_field( context, "Z49empleadospisoextcorreo", Z49empleadospisoextcorreo);
         GxWebStd.gx_hidden_field( context, "Z50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z50empleadopisoextprofesion), 11, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z51empleadospisoextusuario", Z51empleadospisoextusuario);
         GxWebStd.gx_hidden_field( context, "Z52empleadospisoextfecgre", context.localUtil.DToC( Z52empleadospisoextfecgre, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z53empleadospisoextfeact", context.localUtil.DToC( Z53empleadospisoextfeact, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vEMPLEADOSPISOEXTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empleadospisoextid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPLEADOSPISOEXTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empleadospisoextid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "empleadospiso";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("empleadospiso:[SendSecurityCheck value for]"+"empleadospisoextid:"+context.localUtil.Format( (decimal)(A46empleadospisoextid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("empleadospiso:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("empleadospiso.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7empleadospisoextid) ;
      }

      public override String GetPgmname( )
      {
         return "empleadospiso" ;
      }

      public override String GetPgmdesc( )
      {
         return "empleadospiso" ;
      }

      protected void InitializeNonKey0O24( )
      {
         A47empleadospisoextpiso = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47empleadospisoextpiso", A47empleadospisoextpiso);
         A48empleadospisoextext = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48empleadospisoextext", A48empleadospisoextext);
         A49empleadospisoextcorreo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49empleadospisoextcorreo", A49empleadospisoextcorreo);
         A50empleadopisoextprofesion = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50empleadopisoextprofesion", StringUtil.LTrim( StringUtil.Str( (decimal)(A50empleadopisoextprofesion), 11, 0)));
         A51empleadospisoextusuario = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51empleadospisoextusuario", A51empleadospisoextusuario);
         A52empleadospisoextfecgre = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52empleadospisoextfecgre", context.localUtil.Format(A52empleadospisoextfecgre, "99/99/9999"));
         A53empleadospisoextfeact = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53empleadospisoextfeact", context.localUtil.Format(A53empleadospisoextfeact, "99/99/9999"));
         Z47empleadospisoextpiso = "";
         Z48empleadospisoextext = "";
         Z49empleadospisoextcorreo = "";
         Z50empleadopisoextprofesion = 0;
         Z51empleadospisoextusuario = "";
         Z52empleadospisoextfecgre = DateTime.MinValue;
         Z53empleadospisoextfeact = DateTime.MinValue;
      }

      protected void InitAll0O24( )
      {
         A46empleadospisoextid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46empleadospisoextid", StringUtil.LTrim( StringUtil.Str( (decimal)(A46empleadospisoextid), 9, 0)));
         InitializeNonKey0O24( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?11323129");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?15381859");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222515593573");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("empleadospiso.js", "?20222515593573");
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
         edtempleadospisoextid_Internalname = "EMPLEADOSPISOEXTID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextpiso_Internalname = "EMPLEADOSPISOEXTPISO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextext_Internalname = "EMPLEADOSPISOEXTEXT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextcorreo_Internalname = "EMPLEADOSPISOEXTCORREO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadopisoextprofesion_Internalname = "EMPLEADOPISOEXTPROFESION";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextusuario_Internalname = "EMPLEADOSPISOEXTUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextfecgre_Internalname = "EMPLEADOSPISOEXTFECGRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtempleadospisoextfeact_Internalname = "EMPLEADOSPISOEXTFEACT";
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
         Form.Caption = "empleadospiso";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtempleadospisoextfeact_Jsonclick = "";
         edtempleadospisoextfeact_Enabled = 1;
         edtempleadospisoextfecgre_Jsonclick = "";
         edtempleadospisoextfecgre_Enabled = 1;
         edtempleadospisoextusuario_Jsonclick = "";
         edtempleadospisoextusuario_Enabled = 1;
         edtempleadopisoextprofesion_Jsonclick = "";
         edtempleadopisoextprofesion_Enabled = 1;
         edtempleadospisoextcorreo_Jsonclick = "";
         edtempleadospisoextcorreo_Enabled = 1;
         edtempleadospisoextext_Jsonclick = "";
         edtempleadospisoextext_Enabled = 1;
         edtempleadospisoextpiso_Jsonclick = "";
         edtempleadospisoextpiso_Enabled = 1;
         edtempleadospisoextid_Jsonclick = "";
         edtempleadospisoextid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7empleadospisoextid',fld:'vEMPLEADOSPISOEXTID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z47empleadospisoextpiso = "";
         Z48empleadospisoextext = "";
         Z49empleadospisoextcorreo = "";
         Z51empleadospisoextusuario = "";
         Z52empleadospisoextfecgre = DateTime.MinValue;
         Z53empleadospisoextfeact = DateTime.MinValue;
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
         A47empleadospisoextpiso = "";
         A48empleadospisoextext = "";
         A49empleadospisoextcorreo = "";
         A51empleadospisoextusuario = "";
         A52empleadospisoextfecgre = DateTime.MinValue;
         A53empleadospisoextfeact = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode24 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000O4_A46empleadospisoextid = new int[1] ;
         T000O4_A47empleadospisoextpiso = new String[] {""} ;
         T000O4_A48empleadospisoextext = new String[] {""} ;
         T000O4_A49empleadospisoextcorreo = new String[] {""} ;
         T000O4_A50empleadopisoextprofesion = new long[1] ;
         T000O4_A51empleadospisoextusuario = new String[] {""} ;
         T000O4_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         T000O4_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         T000O5_A46empleadospisoextid = new int[1] ;
         T000O3_A46empleadospisoextid = new int[1] ;
         T000O3_A47empleadospisoextpiso = new String[] {""} ;
         T000O3_A48empleadospisoextext = new String[] {""} ;
         T000O3_A49empleadospisoextcorreo = new String[] {""} ;
         T000O3_A50empleadopisoextprofesion = new long[1] ;
         T000O3_A51empleadospisoextusuario = new String[] {""} ;
         T000O3_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         T000O3_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         T000O6_A46empleadospisoextid = new int[1] ;
         T000O7_A46empleadospisoextid = new int[1] ;
         T000O2_A46empleadospisoextid = new int[1] ;
         T000O2_A47empleadospisoextpiso = new String[] {""} ;
         T000O2_A48empleadospisoextext = new String[] {""} ;
         T000O2_A49empleadospisoextcorreo = new String[] {""} ;
         T000O2_A50empleadopisoextprofesion = new long[1] ;
         T000O2_A51empleadospisoextusuario = new String[] {""} ;
         T000O2_A52empleadospisoextfecgre = new DateTime[] {DateTime.MinValue} ;
         T000O2_A53empleadospisoextfeact = new DateTime[] {DateTime.MinValue} ;
         T000O11_A46empleadospisoextid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleadospiso__default(),
            new Object[][] {
                new Object[] {
               T000O2_A46empleadospisoextid, T000O2_A47empleadospisoextpiso, T000O2_A48empleadospisoextext, T000O2_A49empleadospisoextcorreo, T000O2_A50empleadopisoextprofesion, T000O2_A51empleadospisoextusuario, T000O2_A52empleadospisoextfecgre, T000O2_A53empleadospisoextfeact
               }
               , new Object[] {
               T000O3_A46empleadospisoextid, T000O3_A47empleadospisoextpiso, T000O3_A48empleadospisoextext, T000O3_A49empleadospisoextcorreo, T000O3_A50empleadopisoextprofesion, T000O3_A51empleadospisoextusuario, T000O3_A52empleadospisoextfecgre, T000O3_A53empleadospisoextfeact
               }
               , new Object[] {
               T000O4_A46empleadospisoextid, T000O4_A47empleadospisoextpiso, T000O4_A48empleadospisoextext, T000O4_A49empleadospisoextcorreo, T000O4_A50empleadopisoextprofesion, T000O4_A51empleadospisoextusuario, T000O4_A52empleadospisoextfecgre, T000O4_A53empleadospisoextfeact
               }
               , new Object[] {
               T000O5_A46empleadospisoextid
               }
               , new Object[] {
               T000O6_A46empleadospisoextid
               }
               , new Object[] {
               T000O7_A46empleadospisoextid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O11_A46empleadospisoextid
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
      private short RcdFound24 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7empleadospisoextid ;
      private int Z46empleadospisoextid ;
      private int AV7empleadospisoextid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A46empleadospisoextid ;
      private int edtempleadospisoextid_Enabled ;
      private int edtempleadospisoextpiso_Enabled ;
      private int edtempleadospisoextext_Enabled ;
      private int edtempleadospisoextcorreo_Enabled ;
      private int edtempleadopisoextprofesion_Enabled ;
      private int edtempleadospisoextusuario_Enabled ;
      private int edtempleadospisoextfecgre_Enabled ;
      private int edtempleadospisoextfeact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z50empleadopisoextprofesion ;
      private long A50empleadopisoextprofesion ;
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
      private String edtempleadospisoextpiso_Internalname ;
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
      private String edtempleadospisoextid_Internalname ;
      private String edtempleadospisoextid_Jsonclick ;
      private String edtempleadospisoextpiso_Jsonclick ;
      private String edtempleadospisoextext_Internalname ;
      private String edtempleadospisoextext_Jsonclick ;
      private String edtempleadospisoextcorreo_Internalname ;
      private String edtempleadospisoextcorreo_Jsonclick ;
      private String edtempleadopisoextprofesion_Internalname ;
      private String edtempleadopisoextprofesion_Jsonclick ;
      private String edtempleadospisoextusuario_Internalname ;
      private String edtempleadospisoextusuario_Jsonclick ;
      private String edtempleadospisoextfecgre_Internalname ;
      private String edtempleadospisoextfecgre_Jsonclick ;
      private String edtempleadospisoextfeact_Internalname ;
      private String edtempleadospisoextfeact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode24 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z52empleadospisoextfecgre ;
      private DateTime Z53empleadospisoextfeact ;
      private DateTime A52empleadospisoextfecgre ;
      private DateTime A53empleadospisoextfeact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String Z47empleadospisoextpiso ;
      private String Z48empleadospisoextext ;
      private String Z49empleadospisoextcorreo ;
      private String Z51empleadospisoextusuario ;
      private String A47empleadospisoextpiso ;
      private String A48empleadospisoextext ;
      private String A49empleadospisoextcorreo ;
      private String A51empleadospisoextusuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000O4_A46empleadospisoextid ;
      private String[] T000O4_A47empleadospisoextpiso ;
      private String[] T000O4_A48empleadospisoextext ;
      private String[] T000O4_A49empleadospisoextcorreo ;
      private long[] T000O4_A50empleadopisoextprofesion ;
      private String[] T000O4_A51empleadospisoextusuario ;
      private DateTime[] T000O4_A52empleadospisoextfecgre ;
      private DateTime[] T000O4_A53empleadospisoextfeact ;
      private int[] T000O5_A46empleadospisoextid ;
      private int[] T000O3_A46empleadospisoextid ;
      private String[] T000O3_A47empleadospisoextpiso ;
      private String[] T000O3_A48empleadospisoextext ;
      private String[] T000O3_A49empleadospisoextcorreo ;
      private long[] T000O3_A50empleadopisoextprofesion ;
      private String[] T000O3_A51empleadospisoextusuario ;
      private DateTime[] T000O3_A52empleadospisoextfecgre ;
      private DateTime[] T000O3_A53empleadospisoextfeact ;
      private int[] T000O6_A46empleadospisoextid ;
      private int[] T000O7_A46empleadospisoextid ;
      private int[] T000O2_A46empleadospisoextid ;
      private String[] T000O2_A47empleadospisoextpiso ;
      private String[] T000O2_A48empleadospisoextext ;
      private String[] T000O2_A49empleadospisoextcorreo ;
      private long[] T000O2_A50empleadopisoextprofesion ;
      private String[] T000O2_A51empleadospisoextusuario ;
      private DateTime[] T000O2_A52empleadospisoextfecgre ;
      private DateTime[] T000O2_A53empleadospisoextfeact ;
      private int[] T000O11_A46empleadospisoextid ;
      private GXWebForm Form ;
   }

   public class empleadospiso__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000O4 ;
          prmT000O4 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O5 ;
          prmT000O5 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O3 ;
          prmT000O3 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O6 ;
          prmT000O6 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O7 ;
          prmT000O7 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O2 ;
          prmT000O2 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O8 ;
          prmT000O8 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"empleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"empleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadospisoextfecgre",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextfeact",NpgsqlDbType.Date,8,0}
          } ;
          Object[] prmT000O9 ;
          prmT000O9 = new Object[] {
          new Object[] {"empleadospisoextpiso",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextext",NpgsqlDbType.Varchar,10,0} ,
          new Object[] {"empleadospisoextcorreo",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"empleadopisoextprofesion",NpgsqlDbType.Real,11,0} ,
          new Object[] {"empleadospisoextusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"empleadospisoextfecgre",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextfeact",NpgsqlDbType.Date,8,0} ,
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O10 ;
          prmT000O10 = new Object[] {
          new Object[] {"empleadospisoextid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000O11 ;
          prmT000O11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000O2", "SELECT empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid  FOR UPDATE OF empleadospiso NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000O2,1,0,true,false )
             ,new CursorDef("T000O3", "SELECT empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O3,1,0,true,false )
             ,new CursorDef("T000O4", "SELECT TM1.empleadospisoextid, TM1.empleadospisoextpiso, TM1.empleadospisoextext, TM1.empleadospisoextcorreo, TM1.empleadopisoextprofesion, TM1.empleadospisoextusuario, TM1.empleadospisoextfecgre, TM1.empleadospisoextfeact FROM empleadospiso TM1 WHERE TM1.empleadospisoextid = :empleadospisoextid ORDER BY TM1.empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O4,100,0,true,false )
             ,new CursorDef("T000O5", "SELECT empleadospisoextid FROM empleadospiso WHERE empleadospisoextid = :empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O5,1,0,true,false )
             ,new CursorDef("T000O6", "SELECT empleadospisoextid FROM empleadospiso WHERE ( empleadospisoextid > :empleadospisoextid) ORDER BY empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O6,1,0,true,true )
             ,new CursorDef("T000O7", "SELECT empleadospisoextid FROM empleadospiso WHERE ( empleadospisoextid < :empleadospisoextid) ORDER BY empleadospisoextid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O7,1,0,true,true )
             ,new CursorDef("T000O8", "SAVEPOINT gxupdate;INSERT INTO empleadospiso(empleadospisoextid, empleadospisoextpiso, empleadospisoextext, empleadospisoextcorreo, empleadopisoextprofesion, empleadospisoextusuario, empleadospisoextfecgre, empleadospisoextfeact) VALUES(:empleadospisoextid, :empleadospisoextpiso, :empleadospisoextext, :empleadospisoextcorreo, :empleadopisoextprofesion, :empleadospisoextusuario, :empleadospisoextfecgre, :empleadospisoextfeact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000O8)
             ,new CursorDef("T000O9", "SAVEPOINT gxupdate;UPDATE empleadospiso SET empleadospisoextpiso=:empleadospisoextpiso, empleadospisoextext=:empleadospisoextext, empleadospisoextcorreo=:empleadospisoextcorreo, empleadopisoextprofesion=:empleadopisoextprofesion, empleadospisoextusuario=:empleadospisoextusuario, empleadospisoextfecgre=:empleadospisoextfecgre, empleadospisoextfeact=:empleadospisoextfeact  WHERE empleadospisoextid = :empleadospisoextid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000O9)
             ,new CursorDef("T000O10", "SAVEPOINT gxupdate;DELETE FROM empleadospiso  WHERE empleadospisoextid = :empleadospisoextid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000O10)
             ,new CursorDef("T000O11", "SELECT empleadospisoextid FROM empleadospiso ORDER BY empleadospisoextid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O11,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (long)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (int)parms[7]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
