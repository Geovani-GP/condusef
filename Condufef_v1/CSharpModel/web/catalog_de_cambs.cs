/*
               File: Catalog_De_Cambs
        Description: Catalog_De_Cambs
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/27/2022 21:49:3.83
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
   public class catalog_de_cambs : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public catalog_de_cambs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public catalog_de_cambs( IGxContext context )
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

      protected void INITWEB( )
      {
         context.SetDefaultTheme("Flat");
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA0U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0U2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxcfg.js", "?20221272149385");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("catalog_de_cambs.aspx") +"\">") ;
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCAMBS", AV9cambs);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCAMBS", AV9cambs);
         }
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GXC1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40000GXC1), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Catalog_De_Cambs";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("catalog_de_cambs:[SendSecurityCheck value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9"));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0U2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("catalog_de_cambs.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Catalog_De_Cambs" ;
      }

      public override String GetPgmdesc( )
      {
         return "Catalog_De_Cambs" ;
      }

      protected void WB0U0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_0U2( true) ;
         }
         else
         {
            wb_table1_3_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START0U2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Catalog_De_Cambs", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0U0( ) ;
      }

      protected void WS0U2( )
      {
         START0U2( ) ;
         EVT0U2( ) ;
      }

      protected void EVT0U2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E110U2 */
                              E110U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GUARDAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E120U2 */
                              E120U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONSULTAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E130U2 */
                              E130U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E140U2 */
                              E140U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E150U2 */
                              E150U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
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
      }

      protected void WE0U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0U2( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavNextvalue_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0U2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
      }

      protected void RF0U2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E150U2 */
            E150U2 ();
            WB0U0( ) ;
         }
      }

      protected void STRUP0U0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
         /* Using cursor H000U3 */
         pr_default.execute(0);
         if ( (pr_default.getStatus(0) != 101) )
         {
            A40000GXC1 = H000U3_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(0);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E110U2 */
         E110U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNEXTVALUE");
               GX_FocusControl = edtavNextvalue_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6NextValue = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")));
            }
            else
            {
               AV6NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")));
            }
            AV8cambsdsc = cgiGet( edtavCambsdsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cambsdsc", AV8cambsdsc);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "Catalog_De_Cambs";
            AV6NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6NextValue), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("catalog_de_cambs:[SecurityCheckFailed value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9"));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E110U2 */
         E110U2 ();
         if (returnInSub) return;
      }

      protected void E110U2( )
      {
         /* Start Routine */
         /* Using cursor H000U5 */
         pr_default.execute(1);
         if ( (pr_default.getStatus(1) != 101) )
         {
            A40000GXC1 = H000U5_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(1);
         AV6NextValue = (short)(A40000GXC1+1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6NextValue), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")));
      }

      protected void E120U2( )
      {
         /* 'Guardar ' Routine */
         AV9cambs.gxTpr_Cambsid = AV6NextValue;
         AV9cambs.gxTpr_Cambsdsc = AV8cambsdsc;
         GXt_dtime1 = DateTimeUtil.ResetTime( Gx_date ) ;
         AV9cambs.gxTpr_Cambsfecreg = GXt_dtime1;
         AV9cambs.gxTpr_Cambsusuario = AV12WebSession.Get("usuario");
         AV9cambs.Save();
         if ( AV9cambs.Success() )
         {
            context.CommitDataStores( "Catalog_De_Cambs");
            context.wjLoc = formatLink("catalog_de_cambs.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else
         {
            context.RollbackDataStores( "Catalog_De_Cambs");
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9cambs", AV9cambs);
      }

      protected void E130U2( )
      {
         /* 'Consultar ' Routine */
         context.wjLoc = formatLink("detallescambs.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void E140U2( )
      {
         /* 'Cancelar' Routine */
         context.wjLoc = formatLink("menuprincipal.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void nextLoad( )
      {
      }

      protected void E150U2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(46), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_0U2( true) ;
         }
         else
         {
            wb_table2_8_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_17_0U2( true) ;
         }
         else
         {
            wb_table3_17_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table3_17_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_0U2e( true) ;
         }
         else
         {
            wb_table1_3_0U2e( false) ;
         }
      }

      protected void wb_table3_17_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(24), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(502), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008080;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Consultar", bttButton1_Jsonclick, 5, "Consultar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CONSULTAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Cambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008080;";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Guardar", bttButton2_Jsonclick, 5, "Guardar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GUARDAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Cambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#DC143C;";
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "Cancelar", bttButton3_Jsonclick, 5, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CANCELAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Cambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_17_0U2e( true) ;
         }
         else
         {
            wb_table3_17_0U2e( false) ;
         }
      }

      protected void wb_table2_8_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(46), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(503), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "Cambs") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNextvalue_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6NextValue), 4, 0, ",", "")), ((edtavNextvalue_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6NextValue), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,12);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNextvalue_Jsonclick, 0, "AttributeAcceptDrag", "", "", "", 1, edtavNextvalue_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Cambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "Descripción") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCambsdsc_Internalname, AV8cambsdsc, StringUtil.RTrim( context.localUtil.Format( AV8cambsdsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCambsdsc_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Cambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0U2e( true) ;
         }
         else
         {
            wb_table2_8_0U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("Flat");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0U2( ) ;
         WS0U2( ) ;
         WE0U2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1734189");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221272149397");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("catalog_de_cambs.js", "?20221272149397");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavNextvalue_Internalname = "vNEXTVALUE";
         edtavCambsdsc_Internalname = "vCAMBSDSC";
         tblTable2_Internalname = "TABLE2";
         bttButton1_Internalname = "BUTTON1";
         bttButton2_Internalname = "BUTTON2";
         bttButton3_Internalname = "BUTTON3";
         tblTable3_Internalname = "TABLE3";
         tblTable1_Internalname = "TABLE1";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavCambsdsc_Jsonclick = "";
         edtavNextvalue_Jsonclick = "";
         edtavNextvalue_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Catalog_De_Cambs";
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
         setEventMetadata("'GUARDAR '","{handler:'E120U2',iparms:[{av:'AV6NextValue',fld:'vNEXTVALUE',pic:'ZZZ9',hsh:true,nv:0},{av:'AV9cambs',fld:'vCAMBS',pic:'',nv:null},{av:'AV8cambsdsc',fld:'vCAMBSDSC',pic:'',nv:''},{av:'Gx_date',fld:'vTODAY',pic:'',nv:''}],oparms:[{av:'AV9cambs',fld:'vCAMBS',pic:'',nv:null}]}");
         setEventMetadata("'CONSULTAR '","{handler:'E130U2',iparms:[],oparms:[]}");
         setEventMetadata("'CANCELAR'","{handler:'E140U2',iparms:[],oparms:[]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV9cambs = new Sdtcambs(context);
         Gx_date = DateTime.MinValue;
         GXKey = "";
         forbiddenHiddens = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000U3_A40000GXC1 = new int[1] ;
         AV8cambsdsc = "";
         hsh = "";
         H000U5_A40000GXC1 = new int[1] ;
         GXt_dtime1 = (DateTime)(DateTime.MinValue);
         AV12WebSession = context.GetSession();
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         bttButton3_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.catalog_de_cambs__default(),
            new Object[][] {
                new Object[] {
               H000U3_A40000GXC1
               }
               , new Object[] {
               H000U5_A40000GXC1
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short AV6NextValue ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A40000GXC1 ;
      private int edtavNextvalue_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavNextvalue_Internalname ;
      private String scmdbuf ;
      private String edtavCambsdsc_Internalname ;
      private String hsh ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String tblTable3_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable2_Internalname ;
      private String edtavNextvalue_Jsonclick ;
      private String edtavCambsdsc_Jsonclick ;
      private DateTime GXt_dtime1 ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8cambsdsc ;
      private IGxSession AV12WebSession ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H000U3_A40000GXC1 ;
      private int[] H000U5_A40000GXC1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private Sdtcambs AV9cambs ;
   }

   public class catalog_de_cambs__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000U3 ;
          prmH000U3 = new Object[] {
          } ;
          Object[] prmH000U5 ;
          prmH000U5 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H000U3", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(cambsid) AS GXC1 FROM public.cambs ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U3,1,0,true,false )
             ,new CursorDef("H000U5", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(cambsid) AS GXC1 FROM public.cambs ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U5,1,0,true,false )
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
                return;
             case 1 :
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
       }
    }

 }

}
