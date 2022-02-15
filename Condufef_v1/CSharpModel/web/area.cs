/*
               File: area
        Description: area
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:7.4
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
   public class area : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7areaareaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7areaareaid), 9, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAREAAREAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7areaareaid), "ZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "area", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtareadsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public area( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public area( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           int aP1_areaareaid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7areaareaid = aP1_areaareaid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "area", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_area.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareaareaid_Internalname, "areaid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtareaareaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22areaareaid), 9, 0, ",", "")), ((edtareaareaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareaareaid_Jsonclick, 0, "Attribute", "", "", "", 1, edtareaareaid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareadsc_Internalname, "areadsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtareadsc_Internalname, A27areadsc, StringUtil.RTrim( context.localUtil.Format( A27areadsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareadsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtareadsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareastatusadsc_Internalname, "areastatusadsc", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtareastatusadsc_Internalname, A28areastatusadsc, StringUtil.RTrim( context.localUtil.Format( A28areastatusadsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareastatusadsc_Jsonclick, 0, "Attribute", "", "", "", 1, edtareastatusadsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareausuario_Internalname, "areausuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtareausuario_Internalname, A29areausuario, StringUtil.RTrim( context.localUtil.Format( A29areausuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareausuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtareausuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareafecreg_Internalname, "areafecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtareafecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtareafecreg_Internalname, context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A30areafecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareafecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtareafecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_area.htm");
            GxWebStd.gx_bitmap( context, edtareafecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtareafecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_area.htm");
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
            GxWebStd.gx_label_element( context, edtareafecultact_Internalname, "areafecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtareafecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtareafecultact_Internalname, context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A31areafecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtareafecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtareafecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_area.htm");
            GxWebStd.gx_bitmap( context, edtareafecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtareafecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_area.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_area.htm");
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
               A22areaareaid = (int)(context.localUtil.CToN( cgiGet( edtareaareaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
               A27areadsc = cgiGet( edtareadsc_Internalname);
               n27areadsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27areadsc", A27areadsc);
               n27areadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A27areadsc)) ? true : false);
               A28areastatusadsc = cgiGet( edtareastatusadsc_Internalname);
               n28areastatusadsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28areastatusadsc", A28areastatusadsc);
               n28areastatusadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A28areastatusadsc)) ? true : false);
               A29areausuario = cgiGet( edtareausuario_Internalname);
               n29areausuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29areausuario", A29areausuario);
               n29areausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A29areausuario)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtareafecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"areafecreg"}), 1, "AREAFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtareafecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A30areafecreg = (DateTime)(DateTime.MinValue);
                  n30areafecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30areafecreg", context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A30areafecreg = context.localUtil.CToT( cgiGet( edtareafecreg_Internalname));
                  n30areafecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30areafecreg", context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n30areafecreg = ((DateTime.MinValue==A30areafecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtareafecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"areafecultact"}), 1, "AREAFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtareafecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A31areafecultact = (DateTime)(DateTime.MinValue);
                  n31areafecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31areafecultact", context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A31areafecultact = context.localUtil.CToT( cgiGet( edtareafecultact_Internalname));
                  n31areafecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31areafecultact", context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n31areafecultact = ((DateTime.MinValue==A31areafecultact) ? true : false);
               /* Read saved values. */
               Z22areaareaid = (int)(context.localUtil.CToN( cgiGet( "Z22areaareaid"), ",", "."));
               Z27areadsc = cgiGet( "Z27areadsc");
               n27areadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A27areadsc)) ? true : false);
               Z28areastatusadsc = cgiGet( "Z28areastatusadsc");
               n28areastatusadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A28areastatusadsc)) ? true : false);
               Z29areausuario = cgiGet( "Z29areausuario");
               n29areausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A29areausuario)) ? true : false);
               Z30areafecreg = context.localUtil.CToT( cgiGet( "Z30areafecreg"), 0);
               n30areafecreg = ((DateTime.MinValue==A30areafecreg) ? true : false);
               Z31areafecultact = context.localUtil.CToT( cgiGet( "Z31areafecultact"), 0);
               n31areafecultact = ((DateTime.MinValue==A31areafecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7areaareaid = (int)(context.localUtil.CToN( cgiGet( "vAREAAREAID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "area";
               A22areaareaid = (int)(context.localUtil.CToN( cgiGet( edtareaareaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A22areaareaid != Z22areaareaid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("area:[SecurityCheckFailed value for]"+"areaareaid:"+context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9"));
                  GXUtil.WriteLog("area:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A22areaareaid = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
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
                     sMode17 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode17;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound17 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0H0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "AREAAREAID");
                        AnyError = 1;
                        GX_FocusControl = edtareaareaid_Internalname;
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
               InitAll0H17( ) ;
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
            DisableAttributes0H17( ) ;
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H17( ) ;
            }
            else
            {
               CheckExtendedTable0H17( ) ;
               CloseExtendedTableCursors0H17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0H0( )
      {
      }

      protected void ZM0H17( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z27areadsc = T000H3_A27areadsc[0];
               Z28areastatusadsc = T000H3_A28areastatusadsc[0];
               Z29areausuario = T000H3_A29areausuario[0];
               Z30areafecreg = T000H3_A30areafecreg[0];
               Z31areafecultact = T000H3_A31areafecultact[0];
            }
            else
            {
               Z27areadsc = A27areadsc;
               Z28areastatusadsc = A28areastatusadsc;
               Z29areausuario = A29areausuario;
               Z30areafecreg = A30areafecreg;
               Z31areafecultact = A31areafecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z22areaareaid = A22areaareaid;
            Z27areadsc = A27areadsc;
            Z28areastatusadsc = A28areastatusadsc;
            Z29areausuario = A29areausuario;
            Z30areafecreg = A30areafecreg;
            Z31areafecultact = A31areafecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtareaareaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareaareaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareaareaid_Enabled), 5, 0)));
         edtareaareaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareaareaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareaareaid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7areaareaid) )
         {
            A22areaareaid = AV7areaareaid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
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

      protected void Load0H17( )
      {
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound17 = 1;
            A27areadsc = T000H4_A27areadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27areadsc", A27areadsc);
            n27areadsc = T000H4_n27areadsc[0];
            A28areastatusadsc = T000H4_A28areastatusadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28areastatusadsc", A28areastatusadsc);
            n28areastatusadsc = T000H4_n28areastatusadsc[0];
            A29areausuario = T000H4_A29areausuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29areausuario", A29areausuario);
            n29areausuario = T000H4_n29areausuario[0];
            A30areafecreg = T000H4_A30areafecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30areafecreg", context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "));
            n30areafecreg = T000H4_n30areafecreg[0];
            A31areafecultact = T000H4_A31areafecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31areafecultact", context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "));
            n31areafecultact = T000H4_n31areafecultact[0];
            ZM0H17( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0H17( ) ;
      }

      protected void OnLoadActions0H17( )
      {
      }

      protected void CheckExtendedTable0H17( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0H17( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0H17( )
      {
         /* Using cursor T000H5 */
         pr_default.execute(3, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000H3 */
         pr_default.execute(1, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H17( 3) ;
            RcdFound17 = 1;
            A22areaareaid = T000H3_A22areaareaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
            A27areadsc = T000H3_A27areadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27areadsc", A27areadsc);
            n27areadsc = T000H3_n27areadsc[0];
            A28areastatusadsc = T000H3_A28areastatusadsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28areastatusadsc", A28areastatusadsc);
            n28areastatusadsc = T000H3_n28areastatusadsc[0];
            A29areausuario = T000H3_A29areausuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29areausuario", A29areausuario);
            n29areausuario = T000H3_n29areausuario[0];
            A30areafecreg = T000H3_A30areafecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30areafecreg", context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "));
            n30areafecreg = T000H3_n30areafecreg[0];
            A31areafecultact = T000H3_A31areafecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31areafecultact", context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "));
            n31areafecultact = T000H3_n31areafecultact[0];
            Z22areaareaid = A22areaareaid;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0H17( ) ;
            if ( AnyError == 1 )
            {
               RcdFound17 = 0;
               InitializeNonKey0H17( ) ;
            }
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0H17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H17( ) ;
         if ( RcdFound17 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound17 = 0;
         /* Using cursor T000H6 */
         pr_default.execute(4, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000H6_A22areaareaid[0] < A22areaareaid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000H6_A22areaareaid[0] > A22areaareaid ) ) )
            {
               A22areaareaid = T000H6_A22areaareaid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound17 = 0;
         /* Using cursor T000H7 */
         pr_default.execute(5, new Object[] {A22areaareaid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000H7_A22areaareaid[0] > A22areaareaid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000H7_A22areaareaid[0] < A22areaareaid ) ) )
            {
               A22areaareaid = T000H7_A22areaareaid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0H17( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtareadsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0H17( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound17 == 1 )
            {
               if ( A22areaareaid != Z22areaareaid )
               {
                  A22areaareaid = Z22areaareaid;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "AREAAREAID");
                  AnyError = 1;
                  GX_FocusControl = edtareaareaid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtareadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0H17( ) ;
                  GX_FocusControl = edtareadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A22areaareaid != Z22areaareaid )
               {
                  /* Insert record */
                  GX_FocusControl = edtareadsc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0H17( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "AREAAREAID");
                     AnyError = 1;
                     GX_FocusControl = edtareaareaid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtareadsc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0H17( ) ;
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
         if ( A22areaareaid != Z22areaareaid )
         {
            A22areaareaid = Z22areaareaid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "AREAAREAID");
            AnyError = 1;
            GX_FocusControl = edtareaareaid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtareadsc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H2 */
            pr_default.execute(0, new Object[] {A22areaareaid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AREA"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z27areadsc, T000H2_A27areadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z28areastatusadsc, T000H2_A28areastatusadsc[0]) != 0 ) || ( StringUtil.StrCmp(Z29areausuario, T000H2_A29areausuario[0]) != 0 ) || ( Z30areafecreg != T000H2_A30areafecreg[0] ) || ( Z31areafecultact != T000H2_A31areafecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z27areadsc, T000H2_A27areadsc[0]) != 0 )
               {
                  GXUtil.WriteLog("area:[seudo value changed for attri]"+"areadsc");
                  GXUtil.WriteLogRaw("Old: ",Z27areadsc);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A27areadsc[0]);
               }
               if ( StringUtil.StrCmp(Z28areastatusadsc, T000H2_A28areastatusadsc[0]) != 0 )
               {
                  GXUtil.WriteLog("area:[seudo value changed for attri]"+"areastatusadsc");
                  GXUtil.WriteLogRaw("Old: ",Z28areastatusadsc);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A28areastatusadsc[0]);
               }
               if ( StringUtil.StrCmp(Z29areausuario, T000H2_A29areausuario[0]) != 0 )
               {
                  GXUtil.WriteLog("area:[seudo value changed for attri]"+"areausuario");
                  GXUtil.WriteLogRaw("Old: ",Z29areausuario);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A29areausuario[0]);
               }
               if ( Z30areafecreg != T000H2_A30areafecreg[0] )
               {
                  GXUtil.WriteLog("area:[seudo value changed for attri]"+"areafecreg");
                  GXUtil.WriteLogRaw("Old: ",Z30areafecreg);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A30areafecreg[0]);
               }
               if ( Z31areafecultact != T000H2_A31areafecultact[0] )
               {
                  GXUtil.WriteLog("area:[seudo value changed for attri]"+"areafecultact");
                  GXUtil.WriteLogRaw("Old: ",Z31areafecultact);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A31areafecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AREA"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H17( 0) ;
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H8 */
                     pr_default.execute(6, new Object[] {A22areaareaid, n27areadsc, A27areadsc, n28areastatusadsc, A28areastatusadsc, n29areausuario, A29areausuario, n30areafecreg, A30areafecreg, n31areafecultact, A31areafecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
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
                           ResetCaption0H0( ) ;
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
               Load0H17( ) ;
            }
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void Update0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H9 */
                     pr_default.execute(7, new Object[] {n27areadsc, A27areadsc, n28areastatusadsc, A28areastatusadsc, n29areausuario, A29areausuario, n30areafecreg, A30areafecreg, n31areafecultact, A31areafecultact, A22areaareaid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AREA"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H17( ) ;
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
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void DeferredUpdate0H17( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H17( ) ;
            AfterConfirm0H17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000H10 */
                  pr_default.execute(8, new Object[] {A22areaareaid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("AREA") ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0H17( ) ;
         Gx_mode = sMode17;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0H17( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "area");
            if ( AnyError == 0 )
            {
               ConfirmValues0H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "area");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0H17( )
      {
         /* Scan By routine */
         /* Using cursor T000H11 */
         pr_default.execute(9);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound17 = 1;
            A22areaareaid = T000H11_A22areaareaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H17( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound17 = 1;
            A22areaareaid = T000H11_A22areaareaid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
         }
      }

      protected void ScanEnd0H17( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0H17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H17( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H17( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H17( )
      {
         edtareaareaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareaareaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareaareaid_Enabled), 5, 0)));
         edtareadsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareadsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareadsc_Enabled), 5, 0)));
         edtareastatusadsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareastatusadsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareastatusadsc_Enabled), 5, 0)));
         edtareausuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareausuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareausuario_Enabled), 5, 0)));
         edtareafecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareafecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareafecreg_Enabled), 5, 0)));
         edtareafecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtareafecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtareafecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0H0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202221559758");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("area.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7areaareaid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z22areaareaid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22areaareaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z27areadsc", Z27areadsc);
         GxWebStd.gx_hidden_field( context, "Z28areastatusadsc", Z28areastatusadsc);
         GxWebStd.gx_hidden_field( context, "Z29areausuario", Z29areausuario);
         GxWebStd.gx_hidden_field( context, "Z30areafecreg", context.localUtil.TToC( Z30areafecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z31areafecultact", context.localUtil.TToC( Z31areafecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vAREAAREAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7areaareaid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vAREAAREAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7areaareaid), "ZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "area";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("area:[SendSecurityCheck value for]"+"areaareaid:"+context.localUtil.Format( (decimal)(A22areaareaid), "ZZZZZZZZ9"));
         GXUtil.WriteLog("area:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("area.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7areaareaid) ;
      }

      public override String GetPgmname( )
      {
         return "area" ;
      }

      public override String GetPgmdesc( )
      {
         return "area" ;
      }

      protected void InitializeNonKey0H17( )
      {
         A27areadsc = "";
         n27areadsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27areadsc", A27areadsc);
         n27areadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A27areadsc)) ? true : false);
         A28areastatusadsc = "";
         n28areastatusadsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28areastatusadsc", A28areastatusadsc);
         n28areastatusadsc = (String.IsNullOrEmpty(StringUtil.RTrim( A28areastatusadsc)) ? true : false);
         A29areausuario = "";
         n29areausuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29areausuario", A29areausuario);
         n29areausuario = (String.IsNullOrEmpty(StringUtil.RTrim( A29areausuario)) ? true : false);
         A30areafecreg = (DateTime)(DateTime.MinValue);
         n30areafecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30areafecreg", context.localUtil.TToC( A30areafecreg, 10, 8, 0, 3, "/", ":", " "));
         n30areafecreg = ((DateTime.MinValue==A30areafecreg) ? true : false);
         A31areafecultact = (DateTime)(DateTime.MinValue);
         n31areafecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31areafecultact", context.localUtil.TToC( A31areafecultact, 10, 8, 0, 3, "/", ":", " "));
         n31areafecultact = ((DateTime.MinValue==A31areafecultact) ? true : false);
         Z27areadsc = "";
         Z28areastatusadsc = "";
         Z29areausuario = "";
         Z30areafecreg = (DateTime)(DateTime.MinValue);
         Z31areafecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0H17( )
      {
         A22areaareaid = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(A22areaareaid), 9, 0)));
         InitializeNonKey0H17( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202221559763");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("area.js", "?202221559763");
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
         edtareaareaid_Internalname = "AREAAREAID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtareadsc_Internalname = "AREADSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtareastatusadsc_Internalname = "AREASTATUSADSC";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtareausuario_Internalname = "AREAUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtareafecreg_Internalname = "AREAFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtareafecultact_Internalname = "AREAFECULTACT";
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
         Form.Caption = "area";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtareafecultact_Jsonclick = "";
         edtareafecultact_Enabled = 1;
         edtareafecreg_Jsonclick = "";
         edtareafecreg_Enabled = 1;
         edtareausuario_Jsonclick = "";
         edtareausuario_Enabled = 1;
         edtareastatusadsc_Jsonclick = "";
         edtareastatusadsc_Enabled = 1;
         edtareadsc_Jsonclick = "";
         edtareadsc_Enabled = 1;
         edtareaareaid_Jsonclick = "";
         edtareaareaid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7areaareaid',fld:'vAREAAREAID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z27areadsc = "";
         Z28areastatusadsc = "";
         Z29areausuario = "";
         Z30areafecreg = (DateTime)(DateTime.MinValue);
         Z31areafecultact = (DateTime)(DateTime.MinValue);
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
         A27areadsc = "";
         A28areastatusadsc = "";
         A29areausuario = "";
         A30areafecreg = (DateTime)(DateTime.MinValue);
         A31areafecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode17 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000H4_A22areaareaid = new int[1] ;
         T000H4_A27areadsc = new String[] {""} ;
         T000H4_n27areadsc = new bool[] {false} ;
         T000H4_A28areastatusadsc = new String[] {""} ;
         T000H4_n28areastatusadsc = new bool[] {false} ;
         T000H4_A29areausuario = new String[] {""} ;
         T000H4_n29areausuario = new bool[] {false} ;
         T000H4_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         T000H4_n30areafecreg = new bool[] {false} ;
         T000H4_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         T000H4_n31areafecultact = new bool[] {false} ;
         T000H5_A22areaareaid = new int[1] ;
         T000H3_A22areaareaid = new int[1] ;
         T000H3_A27areadsc = new String[] {""} ;
         T000H3_n27areadsc = new bool[] {false} ;
         T000H3_A28areastatusadsc = new String[] {""} ;
         T000H3_n28areastatusadsc = new bool[] {false} ;
         T000H3_A29areausuario = new String[] {""} ;
         T000H3_n29areausuario = new bool[] {false} ;
         T000H3_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         T000H3_n30areafecreg = new bool[] {false} ;
         T000H3_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         T000H3_n31areafecultact = new bool[] {false} ;
         T000H6_A22areaareaid = new int[1] ;
         T000H7_A22areaareaid = new int[1] ;
         T000H2_A22areaareaid = new int[1] ;
         T000H2_A27areadsc = new String[] {""} ;
         T000H2_n27areadsc = new bool[] {false} ;
         T000H2_A28areastatusadsc = new String[] {""} ;
         T000H2_n28areastatusadsc = new bool[] {false} ;
         T000H2_A29areausuario = new String[] {""} ;
         T000H2_n29areausuario = new bool[] {false} ;
         T000H2_A30areafecreg = new DateTime[] {DateTime.MinValue} ;
         T000H2_n30areafecreg = new bool[] {false} ;
         T000H2_A31areafecultact = new DateTime[] {DateTime.MinValue} ;
         T000H2_n31areafecultact = new bool[] {false} ;
         T000H11_A22areaareaid = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.area__default(),
            new Object[][] {
                new Object[] {
               T000H2_A22areaareaid, T000H2_A27areadsc, T000H2_n27areadsc, T000H2_A28areastatusadsc, T000H2_n28areastatusadsc, T000H2_A29areausuario, T000H2_n29areausuario, T000H2_A30areafecreg, T000H2_n30areafecreg, T000H2_A31areafecultact,
               T000H2_n31areafecultact
               }
               , new Object[] {
               T000H3_A22areaareaid, T000H3_A27areadsc, T000H3_n27areadsc, T000H3_A28areastatusadsc, T000H3_n28areastatusadsc, T000H3_A29areausuario, T000H3_n29areausuario, T000H3_A30areafecreg, T000H3_n30areafecreg, T000H3_A31areafecultact,
               T000H3_n31areafecultact
               }
               , new Object[] {
               T000H4_A22areaareaid, T000H4_A27areadsc, T000H4_n27areadsc, T000H4_A28areastatusadsc, T000H4_n28areastatusadsc, T000H4_A29areausuario, T000H4_n29areausuario, T000H4_A30areafecreg, T000H4_n30areafecreg, T000H4_A31areafecultact,
               T000H4_n31areafecultact
               }
               , new Object[] {
               T000H5_A22areaareaid
               }
               , new Object[] {
               T000H6_A22areaareaid
               }
               , new Object[] {
               T000H7_A22areaareaid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H11_A22areaareaid
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
      private short RcdFound17 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7areaareaid ;
      private int Z22areaareaid ;
      private int AV7areaareaid ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A22areaareaid ;
      private int edtareaareaid_Enabled ;
      private int edtareadsc_Enabled ;
      private int edtareastatusadsc_Enabled ;
      private int edtareausuario_Enabled ;
      private int edtareafecreg_Enabled ;
      private int edtareafecultact_Enabled ;
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
      private String edtareadsc_Internalname ;
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
      private String edtareaareaid_Internalname ;
      private String edtareaareaid_Jsonclick ;
      private String edtareadsc_Jsonclick ;
      private String edtareastatusadsc_Internalname ;
      private String edtareastatusadsc_Jsonclick ;
      private String edtareausuario_Internalname ;
      private String edtareausuario_Jsonclick ;
      private String edtareafecreg_Internalname ;
      private String edtareafecreg_Jsonclick ;
      private String edtareafecultact_Internalname ;
      private String edtareafecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode17 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z30areafecreg ;
      private DateTime Z31areafecultact ;
      private DateTime A30areafecreg ;
      private DateTime A31areafecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n27areadsc ;
      private bool n28areastatusadsc ;
      private bool n29areausuario ;
      private bool n30areafecreg ;
      private bool n31areafecultact ;
      private String Z27areadsc ;
      private String Z28areastatusadsc ;
      private String Z29areausuario ;
      private String A27areadsc ;
      private String A28areastatusadsc ;
      private String A29areausuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000H4_A22areaareaid ;
      private String[] T000H4_A27areadsc ;
      private bool[] T000H4_n27areadsc ;
      private String[] T000H4_A28areastatusadsc ;
      private bool[] T000H4_n28areastatusadsc ;
      private String[] T000H4_A29areausuario ;
      private bool[] T000H4_n29areausuario ;
      private DateTime[] T000H4_A30areafecreg ;
      private bool[] T000H4_n30areafecreg ;
      private DateTime[] T000H4_A31areafecultact ;
      private bool[] T000H4_n31areafecultact ;
      private int[] T000H5_A22areaareaid ;
      private int[] T000H3_A22areaareaid ;
      private String[] T000H3_A27areadsc ;
      private bool[] T000H3_n27areadsc ;
      private String[] T000H3_A28areastatusadsc ;
      private bool[] T000H3_n28areastatusadsc ;
      private String[] T000H3_A29areausuario ;
      private bool[] T000H3_n29areausuario ;
      private DateTime[] T000H3_A30areafecreg ;
      private bool[] T000H3_n30areafecreg ;
      private DateTime[] T000H3_A31areafecultact ;
      private bool[] T000H3_n31areafecultact ;
      private int[] T000H6_A22areaareaid ;
      private int[] T000H7_A22areaareaid ;
      private int[] T000H2_A22areaareaid ;
      private String[] T000H2_A27areadsc ;
      private bool[] T000H2_n27areadsc ;
      private String[] T000H2_A28areastatusadsc ;
      private bool[] T000H2_n28areastatusadsc ;
      private String[] T000H2_A29areausuario ;
      private bool[] T000H2_n29areausuario ;
      private DateTime[] T000H2_A30areafecreg ;
      private bool[] T000H2_n30areafecreg ;
      private DateTime[] T000H2_A31areafecultact ;
      private bool[] T000H2_n31areafecultact ;
      private int[] T000H11_A22areaareaid ;
      private GXWebForm Form ;
   }

   public class area__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000H4 ;
          prmT000H4 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H5 ;
          prmT000H5 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H3 ;
          prmT000H3 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H6 ;
          prmT000H6 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H7 ;
          prmT000H7 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H2 ;
          prmT000H2 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H8 ;
          prmT000H8 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0} ,
          new Object[] {"areadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"areafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areafecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000H9 ;
          prmT000H9 = new Object[] {
          new Object[] {"areadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areastatusadsc",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"areausuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"areafecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areafecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H10 ;
          prmT000H10 = new Object[] {
          new Object[] {"areaareaid",NpgsqlDbType.Integer,9,0}
          } ;
          Object[] prmT000H11 ;
          prmT000H11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000H2", "SELECT areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact FROM public.area WHERE areaid = :areaareaid  FOR UPDATE OF area NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000H2,1,0,true,false )
             ,new CursorDef("T000H3", "SELECT areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact FROM public.area WHERE areaid = :areaareaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H3,1,0,true,false )
             ,new CursorDef("T000H4", "SELECT TM1.areaid, TM1.areadsc, TM1.areastatusadsc, TM1.areausuario, TM1.areafecreg, TM1.areafecultact FROM public.area TM1 WHERE TM1.areaid = :areaareaid ORDER BY TM1.areaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H4,100,0,true,false )
             ,new CursorDef("T000H5", "SELECT areaid FROM public.area WHERE areaid = :areaareaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H5,1,0,true,false )
             ,new CursorDef("T000H6", "SELECT areaid FROM public.area WHERE ( areaid > :areaareaid) ORDER BY areaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H6,1,0,true,true )
             ,new CursorDef("T000H7", "SELECT areaid FROM public.area WHERE ( areaid < :areaareaid) ORDER BY areaid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H7,1,0,true,true )
             ,new CursorDef("T000H8", "SAVEPOINT gxupdate;INSERT INTO public.area(areaid, areadsc, areastatusadsc, areausuario, areafecreg, areafecultact) VALUES(:areaareaid, :areadsc, :areastatusadsc, :areausuario, :areafecreg, :areafecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000H8)
             ,new CursorDef("T000H9", "SAVEPOINT gxupdate;UPDATE public.area SET areadsc=:areadsc, areastatusadsc=:areastatusadsc, areausuario=:areausuario, areafecreg=:areafecreg, areafecultact=:areafecultact  WHERE areaid = :areaareaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000H9)
             ,new CursorDef("T000H10", "SAVEPOINT gxupdate;DELETE FROM public.area  WHERE areaid = :areaareaid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000H10)
             ,new CursorDef("T000H11", "SELECT areaid FROM public.area ORDER BY areaid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H11,100,0,true,false )
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
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[10]);
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
                }
                stmt.SetParameter(6, (int)parms[10]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
