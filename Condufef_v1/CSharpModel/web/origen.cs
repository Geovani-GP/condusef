/*
               File: origen
        Description: origen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/27/2022 16:5:41.98
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
   public class origen : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7origenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7origenid), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORIGENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7origenid), "ZZZZZZZZZZZZZZZZZ9")));
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
            Form.Meta.addItem("description", "origen", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtorigendscorta_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public origen( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public origen( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_origenid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7origenid = aP1_origenid;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "origen", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_origen.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            GxWebStd.gx_div_end( context, "left", "top");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigenid_Internalname, "origenid", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtorigenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10origenid), 18, 0, ",", "")), ((edtorigenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigenid_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigenid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigendscorta_Internalname, "origendscorta", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtorigendscorta_Internalname, A120origendscorta, StringUtil.RTrim( context.localUtil.Format( A120origendscorta, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigendscorta_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigendscorta_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigendsclarga_Internalname, "origendsclarga", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtorigendsclarga_Internalname, A121origendsclarga, StringUtil.RTrim( context.localUtil.Format( A121origendsclarga, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigendsclarga_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigendsclarga_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigenusuario_Internalname, "origenusuario", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtorigenusuario_Internalname, A122origenusuario, StringUtil.RTrim( context.localUtil.Format( A122origenusuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigenusuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigenusuario_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigentotal_Internalname, "origentotal", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtorigentotal_Internalname, A123origentotal, StringUtil.RTrim( context.localUtil.Format( A123origentotal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigentotal_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigentotal_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigenfecreg_Internalname, "origenfecreg", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtorigenfecreg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtorigenfecreg_Internalname, context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A124origenfecreg, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigenfecreg_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigenfecreg_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_origen.htm");
            GxWebStd.gx_bitmap( context, edtorigenfecreg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtorigenfecreg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_origen.htm");
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
            GxWebStd.gx_label_element( context, edtorigenfecultact_Internalname, "origenfecultact", "col-sm-3 AttributeLabel", 1, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtorigenfecultact_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtorigenfecultact_Internalname, context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A125origenfecultact, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtorigenfecultact_Jsonclick, 0, "Attribute", "", "", "", 1, edtorigenfecultact_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_origen.htm");
            GxWebStd.gx_bitmap( context, edtorigenfecultact_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtorigenfecultact_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_origen.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_origen.htm");
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
               A10origenid = (long)(context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", "."));
               n10origenid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               A120origendscorta = cgiGet( edtorigendscorta_Internalname);
               n120origendscorta = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A120origendscorta", A120origendscorta);
               n120origendscorta = (String.IsNullOrEmpty(StringUtil.RTrim( A120origendscorta)) ? true : false);
               A121origendsclarga = cgiGet( edtorigendsclarga_Internalname);
               n121origendsclarga = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121origendsclarga", A121origendsclarga);
               n121origendsclarga = (String.IsNullOrEmpty(StringUtil.RTrim( A121origendsclarga)) ? true : false);
               A122origenusuario = cgiGet( edtorigenusuario_Internalname);
               n122origenusuario = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122origenusuario", A122origenusuario);
               n122origenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A122origenusuario)) ? true : false);
               A123origentotal = cgiGet( edtorigentotal_Internalname);
               n123origentotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123origentotal", A123origentotal);
               n123origentotal = (String.IsNullOrEmpty(StringUtil.RTrim( A123origentotal)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtorigenfecreg_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"origenfecreg"}), 1, "ORIGENFECREG");
                  AnyError = 1;
                  GX_FocusControl = edtorigenfecreg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A124origenfecreg = (DateTime)(DateTime.MinValue);
                  n124origenfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124origenfecreg", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A124origenfecreg = context.localUtil.CToT( cgiGet( edtorigenfecreg_Internalname));
                  n124origenfecreg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124origenfecreg", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
               }
               n124origenfecreg = ((DateTime.MinValue==A124origenfecreg) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtorigenfecultact_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"origenfecultact"}), 1, "ORIGENFECULTACT");
                  AnyError = 1;
                  GX_FocusControl = edtorigenfecultact_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A125origenfecultact = (DateTime)(DateTime.MinValue);
                  n125origenfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125origenfecultact", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A125origenfecultact = context.localUtil.CToT( cgiGet( edtorigenfecultact_Internalname));
                  n125origenfecultact = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125origenfecultact", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
               }
               n125origenfecultact = ((DateTime.MinValue==A125origenfecultact) ? true : false);
               /* Read saved values. */
               Z10origenid = (long)(context.localUtil.CToN( cgiGet( "Z10origenid"), ",", "."));
               Z120origendscorta = cgiGet( "Z120origendscorta");
               n120origendscorta = (String.IsNullOrEmpty(StringUtil.RTrim( A120origendscorta)) ? true : false);
               Z121origendsclarga = cgiGet( "Z121origendsclarga");
               n121origendsclarga = (String.IsNullOrEmpty(StringUtil.RTrim( A121origendsclarga)) ? true : false);
               Z122origenusuario = cgiGet( "Z122origenusuario");
               n122origenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A122origenusuario)) ? true : false);
               Z123origentotal = cgiGet( "Z123origentotal");
               n123origentotal = (String.IsNullOrEmpty(StringUtil.RTrim( A123origentotal)) ? true : false);
               Z124origenfecreg = context.localUtil.CToT( cgiGet( "Z124origenfecreg"), 0);
               n124origenfecreg = ((DateTime.MinValue==A124origenfecreg) ? true : false);
               Z125origenfecultact = context.localUtil.CToT( cgiGet( "Z125origenfecultact"), 0);
               n125origenfecultact = ((DateTime.MinValue==A125origenfecultact) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7origenid = (long)(context.localUtil.CToN( cgiGet( "vORIGENID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "origen";
               A10origenid = (long)(context.localUtil.CToN( cgiGet( edtorigenid_Internalname), ",", "."));
               n10origenid = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A10origenid != Z10origenid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("origen:[SecurityCheckFailed value for]"+"origenid:"+context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9"));
                  GXUtil.WriteLog("origen:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A10origenid = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n10origenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
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
                     sMode16 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                     Gx_mode = sMode16;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound16 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0G0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ORIGENID");
                        AnyError = 1;
                        GX_FocusControl = edtorigenid_Internalname;
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
               InitAll0G16( ) ;
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
            DisableAttributes0G16( ) ;
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G16( ) ;
            }
            else
            {
               CheckExtendedTable0G16( ) ;
               CloseExtendedTableCursors0G16( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0G0( )
      {
      }

      protected void ZM0G16( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z120origendscorta = T000G3_A120origendscorta[0];
               Z121origendsclarga = T000G3_A121origendsclarga[0];
               Z122origenusuario = T000G3_A122origenusuario[0];
               Z123origentotal = T000G3_A123origentotal[0];
               Z124origenfecreg = T000G3_A124origenfecreg[0];
               Z125origenfecultact = T000G3_A125origenfecultact[0];
            }
            else
            {
               Z120origendscorta = A120origendscorta;
               Z121origendsclarga = A121origendsclarga;
               Z122origenusuario = A122origenusuario;
               Z123origentotal = A123origentotal;
               Z124origenfecreg = A124origenfecreg;
               Z125origenfecultact = A125origenfecultact;
            }
         }
         if ( GX_JID == -3 )
         {
            Z10origenid = A10origenid;
            Z120origendscorta = A120origendscorta;
            Z121origendsclarga = A121origendsclarga;
            Z122origenusuario = A122origenusuario;
            Z123origentotal = A123origentotal;
            Z124origenfecreg = A124origenfecreg;
            Z125origenfecultact = A125origenfecultact;
         }
      }

      protected void standaloneNotModal( )
      {
         edtorigenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenid_Enabled), 5, 0)));
         edtorigenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenid_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! (0==AV7origenid) )
         {
            A10origenid = AV7origenid;
            n10origenid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
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

      protected void Load0G16( )
      {
         /* Using cursor T000G4 */
         pr_default.execute(2, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound16 = 1;
            A120origendscorta = T000G4_A120origendscorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A120origendscorta", A120origendscorta);
            n120origendscorta = T000G4_n120origendscorta[0];
            A121origendsclarga = T000G4_A121origendsclarga[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121origendsclarga", A121origendsclarga);
            n121origendsclarga = T000G4_n121origendsclarga[0];
            A122origenusuario = T000G4_A122origenusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122origenusuario", A122origenusuario);
            n122origenusuario = T000G4_n122origenusuario[0];
            A123origentotal = T000G4_A123origentotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123origentotal", A123origentotal);
            n123origentotal = T000G4_n123origentotal[0];
            A124origenfecreg = T000G4_A124origenfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124origenfecreg", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
            n124origenfecreg = T000G4_n124origenfecreg[0];
            A125origenfecultact = T000G4_A125origenfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125origenfecultact", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
            n125origenfecultact = T000G4_n125origenfecultact[0];
            ZM0G16( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0G16( ) ;
      }

      protected void OnLoadActions0G16( )
      {
      }

      protected void CheckExtendedTable0G16( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0G16( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0G16( )
      {
         /* Using cursor T000G5 */
         pr_default.execute(3, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound16 = 1;
         }
         else
         {
            RcdFound16 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000G3 */
         pr_default.execute(1, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G16( 3) ;
            RcdFound16 = 1;
            A10origenid = T000G3_A10origenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            n10origenid = T000G3_n10origenid[0];
            A120origendscorta = T000G3_A120origendscorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A120origendscorta", A120origendscorta);
            n120origendscorta = T000G3_n120origendscorta[0];
            A121origendsclarga = T000G3_A121origendsclarga[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121origendsclarga", A121origendsclarga);
            n121origendsclarga = T000G3_n121origendsclarga[0];
            A122origenusuario = T000G3_A122origenusuario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122origenusuario", A122origenusuario);
            n122origenusuario = T000G3_n122origenusuario[0];
            A123origentotal = T000G3_A123origentotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123origentotal", A123origentotal);
            n123origentotal = T000G3_n123origentotal[0];
            A124origenfecreg = T000G3_A124origenfecreg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124origenfecreg", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
            n124origenfecreg = T000G3_n124origenfecreg[0];
            A125origenfecultact = T000G3_A125origenfecultact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125origenfecultact", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
            n125origenfecultact = T000G3_n125origenfecultact[0];
            Z10origenid = A10origenid;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            Load0G16( ) ;
            if ( AnyError == 1 )
            {
               RcdFound16 = 0;
               InitializeNonKey0G16( ) ;
            }
            Gx_mode = sMode16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         else
         {
            RcdFound16 = 0;
            InitializeNonKey0G16( ) ;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
            standaloneModal( ) ;
            Gx_mode = sMode16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G16( ) ;
         if ( RcdFound16 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound16 = 0;
         /* Using cursor T000G6 */
         pr_default.execute(4, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000G6_A10origenid[0] < A10origenid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000G6_A10origenid[0] > A10origenid ) ) )
            {
               A10origenid = T000G6_A10origenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               n10origenid = T000G6_n10origenid[0];
               RcdFound16 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound16 = 0;
         /* Using cursor T000G7 */
         pr_default.execute(5, new Object[] {n10origenid, A10origenid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000G7_A10origenid[0] > A10origenid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000G7_A10origenid[0] < A10origenid ) ) )
            {
               A10origenid = T000G7_A10origenid[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
               n10origenid = T000G7_n10origenid[0];
               RcdFound16 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0G16( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtorigendscorta_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0G16( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound16 == 1 )
            {
               if ( A10origenid != Z10origenid )
               {
                  A10origenid = Z10origenid;
                  n10origenid = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ORIGENID");
                  AnyError = 1;
                  GX_FocusControl = edtorigenid_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtorigendscorta_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0G16( ) ;
                  GX_FocusControl = edtorigendscorta_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A10origenid != Z10origenid )
               {
                  /* Insert record */
                  GX_FocusControl = edtorigendscorta_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0G16( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ORIGENID");
                     AnyError = 1;
                     GX_FocusControl = edtorigenid_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtorigendscorta_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0G16( ) ;
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
         if ( A10origenid != Z10origenid )
         {
            A10origenid = Z10origenid;
            n10origenid = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ORIGENID");
            AnyError = 1;
            GX_FocusControl = edtorigenid_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtorigendscorta_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000G2 */
            pr_default.execute(0, new Object[] {n10origenid, A10origenid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ORIGEN"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z120origendscorta, T000G2_A120origendscorta[0]) != 0 ) || ( StringUtil.StrCmp(Z121origendsclarga, T000G2_A121origendsclarga[0]) != 0 ) || ( StringUtil.StrCmp(Z122origenusuario, T000G2_A122origenusuario[0]) != 0 ) || ( StringUtil.StrCmp(Z123origentotal, T000G2_A123origentotal[0]) != 0 ) || ( Z124origenfecreg != T000G2_A124origenfecreg[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z125origenfecultact != T000G2_A125origenfecultact[0] ) )
            {
               if ( StringUtil.StrCmp(Z120origendscorta, T000G2_A120origendscorta[0]) != 0 )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origendscorta");
                  GXUtil.WriteLogRaw("Old: ",Z120origendscorta);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A120origendscorta[0]);
               }
               if ( StringUtil.StrCmp(Z121origendsclarga, T000G2_A121origendsclarga[0]) != 0 )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origendsclarga");
                  GXUtil.WriteLogRaw("Old: ",Z121origendsclarga);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A121origendsclarga[0]);
               }
               if ( StringUtil.StrCmp(Z122origenusuario, T000G2_A122origenusuario[0]) != 0 )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origenusuario");
                  GXUtil.WriteLogRaw("Old: ",Z122origenusuario);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A122origenusuario[0]);
               }
               if ( StringUtil.StrCmp(Z123origentotal, T000G2_A123origentotal[0]) != 0 )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origentotal");
                  GXUtil.WriteLogRaw("Old: ",Z123origentotal);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A123origentotal[0]);
               }
               if ( Z124origenfecreg != T000G2_A124origenfecreg[0] )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origenfecreg");
                  GXUtil.WriteLogRaw("Old: ",Z124origenfecreg);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A124origenfecreg[0]);
               }
               if ( Z125origenfecultact != T000G2_A125origenfecultact[0] )
               {
                  GXUtil.WriteLog("origen:[seudo value changed for attri]"+"origenfecultact");
                  GXUtil.WriteLogRaw("Old: ",Z125origenfecultact);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A125origenfecultact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ORIGEN"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G16( 0) ;
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G8 */
                     pr_default.execute(6, new Object[] {n10origenid, A10origenid, n120origendscorta, A120origendscorta, n121origendsclarga, A121origendsclarga, n122origenusuario, A122origenusuario, n123origentotal, A123origentotal, n124origenfecreg, A124origenfecreg, n125origenfecultact, A125origenfecultact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
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
                           ResetCaption0G0( ) ;
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
               Load0G16( ) ;
            }
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void Update0G16( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G9 */
                     pr_default.execute(7, new Object[] {n120origendscorta, A120origendscorta, n121origendsclarga, A121origendsclarga, n122origenusuario, A122origenusuario, n123origentotal, A123origentotal, n124origenfecreg, A124origenfecreg, n125origenfecultact, A125origenfecultact, n10origenid, A10origenid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ORIGEN"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0G16( ) ;
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
            EndLevel0G16( ) ;
         }
         CloseExtendedTableCursors0G16( ) ;
      }

      protected void DeferredUpdate0G16( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0G16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G16( ) ;
            AfterConfirm0G16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G16( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000G10 */
                  pr_default.execute(8, new Object[] {n10origenid, A10origenid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("ORIGEN") ;
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
         sMode16 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         EndLevel0G16( ) ;
         Gx_mode = sMode16;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
      }

      protected void OnDeleteControls0G16( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000G11 */
            pr_default.execute(9, new Object[] {n10origenid, A10origenid});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"articulos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0G16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G16( ) ;
         }
         if ( AnyError == 0 )
         {
            context.CommitDataStores( "origen");
            if ( AnyError == 0 )
            {
               ConfirmValues0G0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            context.RollbackDataStores( "origen");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0G16( )
      {
         /* Scan By routine */
         /* Using cursor T000G12 */
         pr_default.execute(10);
         RcdFound16 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound16 = 1;
            A10origenid = T000G12_A10origenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            n10origenid = T000G12_n10origenid[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0G16( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound16 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound16 = 1;
            A10origenid = T000G12_A10origenid[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
            n10origenid = T000G12_n10origenid[0];
         }
      }

      protected void ScanEnd0G16( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0G16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0G16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0G16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G16( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0G16( )
      {
         edtorigenid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenid_Enabled), 5, 0)));
         edtorigendscorta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigendscorta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigendscorta_Enabled), 5, 0)));
         edtorigendsclarga_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigendsclarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigendsclarga_Enabled), 5, 0)));
         edtorigenusuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenusuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenusuario_Enabled), 5, 0)));
         edtorigentotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigentotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigentotal_Enabled), 5, 0)));
         edtorigenfecreg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenfecreg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenfecreg_Enabled), 5, 0)));
         edtorigenfecultact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtorigenfecultact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtorigenfecultact_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0G0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20221271654240");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" novalidate action=\""+formatLink("origen.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7origenid)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z10origenid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10origenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z120origendscorta", Z120origendscorta);
         GxWebStd.gx_hidden_field( context, "Z121origendsclarga", Z121origendsclarga);
         GxWebStd.gx_hidden_field( context, "Z122origenusuario", Z122origenusuario);
         GxWebStd.gx_hidden_field( context, "Z123origentotal", Z123origentotal);
         GxWebStd.gx_hidden_field( context, "Z124origenfecreg", context.localUtil.TToC( Z124origenfecreg, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z125origenfecultact", context.localUtil.TToC( Z125origenfecultact, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vORIGENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7origenid), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"))));
         GxWebStd.gx_hidden_field( context, "gxhash_vORIGENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7origenid), "ZZZZZZZZZZZZZZZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "origen";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("origen:[SendSecurityCheck value for]"+"origenid:"+context.localUtil.Format( (decimal)(A10origenid), "ZZZZZZZZZZZZZZZZZ9"));
         GXUtil.WriteLog("origen:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         return formatLink("origen.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7origenid) ;
      }

      public override String GetPgmname( )
      {
         return "origen" ;
      }

      public override String GetPgmdesc( )
      {
         return "origen" ;
      }

      protected void InitializeNonKey0G16( )
      {
         A120origendscorta = "";
         n120origendscorta = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A120origendscorta", A120origendscorta);
         n120origendscorta = (String.IsNullOrEmpty(StringUtil.RTrim( A120origendscorta)) ? true : false);
         A121origendsclarga = "";
         n121origendsclarga = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121origendsclarga", A121origendsclarga);
         n121origendsclarga = (String.IsNullOrEmpty(StringUtil.RTrim( A121origendsclarga)) ? true : false);
         A122origenusuario = "";
         n122origenusuario = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122origenusuario", A122origenusuario);
         n122origenusuario = (String.IsNullOrEmpty(StringUtil.RTrim( A122origenusuario)) ? true : false);
         A123origentotal = "";
         n123origentotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123origentotal", A123origentotal);
         n123origentotal = (String.IsNullOrEmpty(StringUtil.RTrim( A123origentotal)) ? true : false);
         A124origenfecreg = (DateTime)(DateTime.MinValue);
         n124origenfecreg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124origenfecreg", context.localUtil.TToC( A124origenfecreg, 10, 8, 0, 3, "/", ":", " "));
         n124origenfecreg = ((DateTime.MinValue==A124origenfecreg) ? true : false);
         A125origenfecultact = (DateTime)(DateTime.MinValue);
         n125origenfecultact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125origenfecultact", context.localUtil.TToC( A125origenfecultact, 10, 8, 0, 3, "/", ":", " "));
         n125origenfecultact = ((DateTime.MinValue==A125origenfecultact) ? true : false);
         Z120origendscorta = "";
         Z121origendsclarga = "";
         Z122origenusuario = "";
         Z123origentotal = "";
         Z124origenfecreg = (DateTime)(DateTime.MinValue);
         Z125origenfecultact = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0G16( )
      {
         A10origenid = 0;
         n10origenid = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(A10origenid), 18, 0)));
         InitializeNonKey0G16( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?13551382");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?13551359");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221271654243");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("origen.js", "?20221271654243");
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
         edtorigenid_Internalname = "ORIGENID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigendscorta_Internalname = "ORIGENDSCORTA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigendsclarga_Internalname = "ORIGENDSCLARGA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigenusuario_Internalname = "ORIGENUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigentotal_Internalname = "ORIGENTOTAL";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigenfecreg_Internalname = "ORIGENFECREG";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtorigenfecultact_Internalname = "ORIGENFECULTACT";
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
         Form.Caption = "origen";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtorigenfecultact_Jsonclick = "";
         edtorigenfecultact_Enabled = 1;
         edtorigenfecreg_Jsonclick = "";
         edtorigenfecreg_Enabled = 1;
         edtorigentotal_Jsonclick = "";
         edtorigentotal_Enabled = 1;
         edtorigenusuario_Jsonclick = "";
         edtorigenusuario_Enabled = 1;
         edtorigendsclarga_Jsonclick = "";
         edtorigendsclarga_Enabled = 1;
         edtorigendscorta_Jsonclick = "";
         edtorigendscorta_Enabled = 1;
         edtorigenid_Jsonclick = "";
         edtorigenid_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7origenid',fld:'vORIGENID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Z120origendscorta = "";
         Z121origendsclarga = "";
         Z122origenusuario = "";
         Z123origentotal = "";
         Z124origenfecreg = (DateTime)(DateTime.MinValue);
         Z125origenfecultact = (DateTime)(DateTime.MinValue);
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
         A120origendscorta = "";
         A121origendsclarga = "";
         A122origenusuario = "";
         A123origentotal = "";
         A124origenfecreg = (DateTime)(DateTime.MinValue);
         A125origenfecultact = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode16 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000G4_A10origenid = new long[1] ;
         T000G4_n10origenid = new bool[] {false} ;
         T000G4_A120origendscorta = new String[] {""} ;
         T000G4_n120origendscorta = new bool[] {false} ;
         T000G4_A121origendsclarga = new String[] {""} ;
         T000G4_n121origendsclarga = new bool[] {false} ;
         T000G4_A122origenusuario = new String[] {""} ;
         T000G4_n122origenusuario = new bool[] {false} ;
         T000G4_A123origentotal = new String[] {""} ;
         T000G4_n123origentotal = new bool[] {false} ;
         T000G4_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000G4_n124origenfecreg = new bool[] {false} ;
         T000G4_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000G4_n125origenfecultact = new bool[] {false} ;
         T000G5_A10origenid = new long[1] ;
         T000G5_n10origenid = new bool[] {false} ;
         T000G3_A10origenid = new long[1] ;
         T000G3_n10origenid = new bool[] {false} ;
         T000G3_A120origendscorta = new String[] {""} ;
         T000G3_n120origendscorta = new bool[] {false} ;
         T000G3_A121origendsclarga = new String[] {""} ;
         T000G3_n121origendsclarga = new bool[] {false} ;
         T000G3_A122origenusuario = new String[] {""} ;
         T000G3_n122origenusuario = new bool[] {false} ;
         T000G3_A123origentotal = new String[] {""} ;
         T000G3_n123origentotal = new bool[] {false} ;
         T000G3_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000G3_n124origenfecreg = new bool[] {false} ;
         T000G3_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000G3_n125origenfecultact = new bool[] {false} ;
         T000G6_A10origenid = new long[1] ;
         T000G6_n10origenid = new bool[] {false} ;
         T000G7_A10origenid = new long[1] ;
         T000G7_n10origenid = new bool[] {false} ;
         T000G2_A10origenid = new long[1] ;
         T000G2_n10origenid = new bool[] {false} ;
         T000G2_A120origendscorta = new String[] {""} ;
         T000G2_n120origendscorta = new bool[] {false} ;
         T000G2_A121origendsclarga = new String[] {""} ;
         T000G2_n121origendsclarga = new bool[] {false} ;
         T000G2_A122origenusuario = new String[] {""} ;
         T000G2_n122origenusuario = new bool[] {false} ;
         T000G2_A123origentotal = new String[] {""} ;
         T000G2_n123origentotal = new bool[] {false} ;
         T000G2_A124origenfecreg = new DateTime[] {DateTime.MinValue} ;
         T000G2_n124origenfecreg = new bool[] {false} ;
         T000G2_A125origenfecultact = new DateTime[] {DateTime.MinValue} ;
         T000G2_n125origenfecultact = new bool[] {false} ;
         T000G11_A19almacenid = new long[1] ;
         T000G11_A20articulosproductoid = new int[1] ;
         T000G11_A21articuloscambsid = new int[1] ;
         T000G12_A10origenid = new long[1] ;
         T000G12_n10origenid = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.origen__default(),
            new Object[][] {
                new Object[] {
               T000G2_A10origenid, T000G2_A120origendscorta, T000G2_n120origendscorta, T000G2_A121origendsclarga, T000G2_n121origendsclarga, T000G2_A122origenusuario, T000G2_n122origenusuario, T000G2_A123origentotal, T000G2_n123origentotal, T000G2_A124origenfecreg,
               T000G2_n124origenfecreg, T000G2_A125origenfecultact, T000G2_n125origenfecultact
               }
               , new Object[] {
               T000G3_A10origenid, T000G3_A120origendscorta, T000G3_n120origendscorta, T000G3_A121origendsclarga, T000G3_n121origendsclarga, T000G3_A122origenusuario, T000G3_n122origenusuario, T000G3_A123origentotal, T000G3_n123origentotal, T000G3_A124origenfecreg,
               T000G3_n124origenfecreg, T000G3_A125origenfecultact, T000G3_n125origenfecultact
               }
               , new Object[] {
               T000G4_A10origenid, T000G4_A120origendscorta, T000G4_n120origendscorta, T000G4_A121origendsclarga, T000G4_n121origendsclarga, T000G4_A122origenusuario, T000G4_n122origenusuario, T000G4_A123origentotal, T000G4_n123origentotal, T000G4_A124origenfecreg,
               T000G4_n124origenfecreg, T000G4_A125origenfecultact, T000G4_n125origenfecultact
               }
               , new Object[] {
               T000G5_A10origenid
               }
               , new Object[] {
               T000G6_A10origenid
               }
               , new Object[] {
               T000G7_A10origenid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000G11_A19almacenid, T000G11_A20articulosproductoid, T000G11_A21articuloscambsid
               }
               , new Object[] {
               T000G12_A10origenid
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
      private short RcdFound16 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtorigenid_Enabled ;
      private int edtorigendscorta_Enabled ;
      private int edtorigendsclarga_Enabled ;
      private int edtorigenusuario_Enabled ;
      private int edtorigentotal_Enabled ;
      private int edtorigenfecreg_Enabled ;
      private int edtorigenfecultact_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long wcpOAV7origenid ;
      private long Z10origenid ;
      private long AV7origenid ;
      private long A10origenid ;
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
      private String edtorigendscorta_Internalname ;
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
      private String edtorigenid_Internalname ;
      private String edtorigenid_Jsonclick ;
      private String edtorigendscorta_Jsonclick ;
      private String edtorigendsclarga_Internalname ;
      private String edtorigendsclarga_Jsonclick ;
      private String edtorigenusuario_Internalname ;
      private String edtorigenusuario_Jsonclick ;
      private String edtorigentotal_Internalname ;
      private String edtorigentotal_Jsonclick ;
      private String edtorigenfecreg_Internalname ;
      private String edtorigenfecreg_Jsonclick ;
      private String edtorigenfecultact_Internalname ;
      private String edtorigenfecultact_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode16 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String div_Internalname ;
      private DateTime Z124origenfecreg ;
      private DateTime Z125origenfecultact ;
      private DateTime A124origenfecreg ;
      private DateTime A125origenfecultact ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n10origenid ;
      private bool n120origendscorta ;
      private bool n121origendsclarga ;
      private bool n122origenusuario ;
      private bool n123origentotal ;
      private bool n124origenfecreg ;
      private bool n125origenfecultact ;
      private bool Gx_longc ;
      private String Z120origendscorta ;
      private String Z121origendsclarga ;
      private String Z122origenusuario ;
      private String Z123origentotal ;
      private String A120origendscorta ;
      private String A121origendsclarga ;
      private String A122origenusuario ;
      private String A123origentotal ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000G4_A10origenid ;
      private bool[] T000G4_n10origenid ;
      private String[] T000G4_A120origendscorta ;
      private bool[] T000G4_n120origendscorta ;
      private String[] T000G4_A121origendsclarga ;
      private bool[] T000G4_n121origendsclarga ;
      private String[] T000G4_A122origenusuario ;
      private bool[] T000G4_n122origenusuario ;
      private String[] T000G4_A123origentotal ;
      private bool[] T000G4_n123origentotal ;
      private DateTime[] T000G4_A124origenfecreg ;
      private bool[] T000G4_n124origenfecreg ;
      private DateTime[] T000G4_A125origenfecultact ;
      private bool[] T000G4_n125origenfecultact ;
      private long[] T000G5_A10origenid ;
      private bool[] T000G5_n10origenid ;
      private long[] T000G3_A10origenid ;
      private bool[] T000G3_n10origenid ;
      private String[] T000G3_A120origendscorta ;
      private bool[] T000G3_n120origendscorta ;
      private String[] T000G3_A121origendsclarga ;
      private bool[] T000G3_n121origendsclarga ;
      private String[] T000G3_A122origenusuario ;
      private bool[] T000G3_n122origenusuario ;
      private String[] T000G3_A123origentotal ;
      private bool[] T000G3_n123origentotal ;
      private DateTime[] T000G3_A124origenfecreg ;
      private bool[] T000G3_n124origenfecreg ;
      private DateTime[] T000G3_A125origenfecultact ;
      private bool[] T000G3_n125origenfecultact ;
      private long[] T000G6_A10origenid ;
      private bool[] T000G6_n10origenid ;
      private long[] T000G7_A10origenid ;
      private bool[] T000G7_n10origenid ;
      private long[] T000G2_A10origenid ;
      private bool[] T000G2_n10origenid ;
      private String[] T000G2_A120origendscorta ;
      private bool[] T000G2_n120origendscorta ;
      private String[] T000G2_A121origendsclarga ;
      private bool[] T000G2_n121origendsclarga ;
      private String[] T000G2_A122origenusuario ;
      private bool[] T000G2_n122origenusuario ;
      private String[] T000G2_A123origentotal ;
      private bool[] T000G2_n123origentotal ;
      private DateTime[] T000G2_A124origenfecreg ;
      private bool[] T000G2_n124origenfecreg ;
      private DateTime[] T000G2_A125origenfecultact ;
      private bool[] T000G2_n125origenfecultact ;
      private long[] T000G11_A19almacenid ;
      private int[] T000G11_A20articulosproductoid ;
      private int[] T000G11_A21articuloscambsid ;
      private long[] T000G12_A10origenid ;
      private bool[] T000G12_n10origenid ;
      private GXWebForm Form ;
   }

   public class origen__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000G4 ;
          prmT000G4 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G5 ;
          prmT000G5 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G3 ;
          prmT000G3 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G6 ;
          prmT000G6 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G7 ;
          prmT000G7 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G2 ;
          prmT000G2 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G8 ;
          prmT000G8 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0} ,
          new Object[] {"origendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"origenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"origentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenfecultact",NpgsqlDbType.Timestamp,10,8}
          } ;
          Object[] prmT000G9 ;
          prmT000G9 = new Object[] {
          new Object[] {"origendscorta",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origendsclarga",NpgsqlDbType.Varchar,100,0} ,
          new Object[] {"origenusuario",NpgsqlDbType.Varchar,15,0} ,
          new Object[] {"origentotal",NpgsqlDbType.Varchar,50,0} ,
          new Object[] {"origenfecreg",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenfecultact",NpgsqlDbType.Timestamp,10,8} ,
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G10 ;
          prmT000G10 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G11 ;
          prmT000G11 = new Object[] {
          new Object[] {"origenid",NpgsqlDbType.Real,18,0}
          } ;
          Object[] prmT000G12 ;
          prmT000G12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000G2", "SELECT origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact FROM public.origen WHERE origenid = :origenid  FOR UPDATE OF origen NOWAIT",true, GxErrorMask.GX_NOMASK, false, this,prmT000G2,1,0,true,false )
             ,new CursorDef("T000G3", "SELECT origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G3,1,0,true,false )
             ,new CursorDef("T000G4", "SELECT TM1.origenid, TM1.origendscorta, TM1.origendsclarga, TM1.origenusuario, TM1.origentotal, TM1.origenfecreg, TM1.origenfecultact FROM public.origen TM1 WHERE TM1.origenid = :origenid ORDER BY TM1.origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G4,100,0,true,false )
             ,new CursorDef("T000G5", "SELECT origenid FROM public.origen WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G5,1,0,true,false )
             ,new CursorDef("T000G6", "SELECT origenid FROM public.origen WHERE ( origenid > :origenid) ORDER BY origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G6,1,0,true,true )
             ,new CursorDef("T000G7", "SELECT origenid FROM public.origen WHERE ( origenid < :origenid) ORDER BY origenid DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G7,1,0,true,true )
             ,new CursorDef("T000G8", "SAVEPOINT gxupdate;INSERT INTO public.origen(origenid, origendscorta, origendsclarga, origenusuario, origentotal, origenfecreg, origenfecultact) VALUES(:origenid, :origendscorta, :origendsclarga, :origenusuario, :origentotal, :origenfecreg, :origenfecultact);RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT,prmT000G8)
             ,new CursorDef("T000G9", "SAVEPOINT gxupdate;UPDATE public.origen SET origendscorta=:origendscorta, origendsclarga=:origendsclarga, origenusuario=:origenusuario, origentotal=:origentotal, origenfecreg=:origenfecreg, origenfecultact=:origenfecultact  WHERE origenid = :origenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000G9)
             ,new CursorDef("T000G10", "SAVEPOINT gxupdate;DELETE FROM public.origen  WHERE origenid = :origenid;RELEASE SAVEPOINT gxupdate", GxErrorMask.GX_ROLLBACKSAVEPOINT | GxErrorMask.GX_NOMASK,prmT000G10)
             ,new CursorDef("T000G11", "SELECT articulosid, productoid, cambsid FROM public.articulos WHERE origenid = :origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G11,1,0,true,true )
             ,new CursorDef("T000G12", "SELECT origenid FROM public.origen ORDER BY origenid ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G12,100,0,true,false )
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
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 10 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
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
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[9]);
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
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (long)parms[13]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
       }
    }

 }

}
