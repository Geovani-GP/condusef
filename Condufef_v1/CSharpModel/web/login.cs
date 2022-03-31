/*
               File: Login
        Description: Login
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:30.65
       Program type: Main program
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
   public class login : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public login( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public login( IGxContext context )
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("masterlogin", "GeneXus.Programs.masterlogin", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA0S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20223310193066");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("HugaoMessages/js/jquery.growl.min.js", "");
         context.AddJavascriptSource("HugaoMessages/HugaoMessagesRender.js", "");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("login.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "USUARIO", A173usuario);
         GxWebStd.gx_hidden_field( context, "CONTRASENA", A174contrasena);
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
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
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            WebComp_Webcomp1.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0S2( ) ;
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
         return formatLink("login.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Login" ;
      }

      public override String GetPgmdesc( )
      {
         return "Login" ;
      }

      protected void WB0S0( )
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
            context.WriteHtmlText( "&nbsp;") ;
            wb_table1_3_0S2( true) ;
         }
         else
         {
            wb_table1_3_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0034"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
               {
                  if ( ! context.isAjaxRequest( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
                  }
                  WebComp_Webcomp1.componentdraw();
                  if ( ! context.isAjaxRequest( ) )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
         }
         wbLoad = true;
      }

      protected void START0S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Login", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0S0( ) ;
      }

      protected void WS0S2( )
      {
         START0S2( ) ;
         EVT0S2( ) ;
      }

      protected void EVT0S2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'INICIAR SESIÓN '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E110S2 */
                              E110S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E120S2 */
                                    E120S2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E130S2 */
                              E130S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REGISTRARW.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E140S2 */
                              E140S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E150S2 */
                              E150S2 ();
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 34 )
                        {
                           WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "alerts", new Object[] {context} );
                           WebComp_Webcomp1.ComponentInit();
                           WebComp_Webcomp1.Name = "Alerts";
                           WebComp_Webcomp1_Component = "Alerts";
                           WebComp_Webcomp1.componentprocess("W0034", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0S2( )
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

      protected void PA0S2( )
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
               GX_FocusControl = edtavUsuario_Internalname;
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
         RF0S2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0S2( )
      {
         initialize_formulas( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "") == 0 )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "alerts", new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "Alerts";
               WebComp_Webcomp1_Component = "Alerts";
            }
            if ( ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "Alerts") == 0 ) )
            {
               WebComp_Webcomp1.setjustcreated();
               WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0034",(String)""});
               WebComp_Webcomp1.componentbind(new Object[] {});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
               WebComp_Webcomp1.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
               {
                  WebComp_Webcomp1.componentstart();
               }
            }
         }
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E150S2 */
            E150S2 ();
            WB0S0( ) ;
         }
      }

      protected void STRUP0S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E130S2 */
         E130S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5usuario = cgiGet( edtavUsuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5usuario", AV5usuario);
            AV6contrasena = cgiGet( edtavContrasena_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6contrasena", AV6contrasena);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E110S2( )
      {
         /* 'INICIAR SESIÓN ' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV5usuario)) || String.IsNullOrEmpty(StringUtil.RTrim( AV6contrasena)) )
         {
            GX_msglist.addItem("Los campos estan vacios");
         }
         else
         {
            AV15GXLvl10 = 0;
            /* Using cursor H000S2 */
            pr_default.execute(0, new Object[] {AV5usuario});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A173usuario = H000S2_A173usuario[0];
               n173usuario = H000S2_n173usuario[0];
               A174contrasena = H000S2_A174contrasena[0];
               n174contrasena = H000S2_n174contrasena[0];
               AV15GXLvl10 = 1;
               if ( StringUtil.StrCmp(A174contrasena, AV6contrasena) == 0 )
               {
                  AV8WebSession.Set("usuario", AV5usuario);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5usuario", AV5usuario);
                  AV8WebSession.Set("fecha", context.localUtil.DToC( (DateTime)(DateTimeUtil.Today( context)), 0, "-"));
                  context.wjLoc = formatLink("menuprincipal.aspx") ;
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  GX_msglist.addItem("usuario/contraseña invalida");
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV15GXLvl10 == 0 )
            {
               GX_msglist.addItem("usuario/contraseña invalida");
            }
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E120S2 */
         E120S2 ();
         if (returnInSub) return;
      }

      protected void E120S2( )
      {
         /* Enter Routine */
         AV16GXLvl37 = 0;
         /* Using cursor H000S3 */
         pr_default.execute(1, new Object[] {AV5usuario});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A173usuario = H000S3_A173usuario[0];
            n173usuario = H000S3_n173usuario[0];
            A174contrasena = H000S3_A174contrasena[0];
            n174contrasena = H000S3_n174contrasena[0];
            AV16GXLvl37 = 1;
            if ( StringUtil.StrCmp(A174contrasena, AV6contrasena) == 0 )
            {
               AV8WebSession.Set("usuario", AV5usuario);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5usuario", AV5usuario);
               AV8WebSession.Set("fecha", context.localUtil.DToC( (DateTime)(DateTimeUtil.Today( context)), 0, "-"));
               context.wjLoc = formatLink("menuprincipal.aspx") ;
               context.wjLocDisableFrm = 1;
            }
            else
            {
               GX_msglist.addItem("usuario/contraseña invalida");
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV16GXLvl37 == 0 )
         {
            GX_msglist.addItem("usuario/contraseña invalida");
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E130S2 */
         E130S2 ();
         if (returnInSub) return;
      }

      protected void E130S2( )
      {
         /* Start Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Webcomp1_Component), StringUtil.Lower( "Alerts")) != 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "alerts", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "Alerts";
            WebComp_Webcomp1_Component = "Alerts";
         }
         if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.setjustcreated();
            WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0034",(String)""});
            WebComp_Webcomp1.componentbind(new Object[] {});
         }
      }

      protected void E140S2( )
      {
         /* Registrarw_Click Routine */
         context.wjLoc = formatLink("register.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void nextLoad( )
      {
      }

      protected void E150S2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            wb_table2_6_0S2( true) ;
         }
         else
         {
            wb_table2_6_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table2_6_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"HUGAOMESSAGES1Container"+"\"></div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_0S2e( true) ;
         }
         else
         {
            wb_table1_3_0S2e( false) ;
         }
      }

      protected void wb_table2_6_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(206), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(250), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:16px;width:68px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "5f30ca97-9603-4cf3-8c47-b1a261245deb", "", context.GetTheme( )), "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_Login.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:35px")+"\">") ;
            context.WriteHtmlText( "Usuario") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"left\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-left;text-align:-moz-left;text-align:-webkit-left;height:100%;width:100%")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, AV5usuario, StringUtil.RTrim( context.localUtil.Format( AV5usuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,14);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsuario_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 100, "%", 35, "px", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Login.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:5px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:35px")+"\">") ;
            context.WriteHtmlText( "Contraseña") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"left\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-left;text-align:-moz-left;text-align:-webkit-left")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavContrasena_Internalname, AV6contrasena, StringUtil.RTrim( context.localUtil.Format( AV6contrasena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,21);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavContrasena_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 100, "%", 35, "px", 10, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Login.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:57px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008080;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "INICIAR SESIÓN ", bttButton1_Jsonclick, 5, "INICIAR SESIÓN ", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'INICIAR SESIÓN \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Login.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            context.WriteHtmlText( "ó") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRegistrarw_Internalname, "Registrate aquí..", "", "", lblRegistrarw_Jsonclick, "'"+""+"'"+",false,"+"'"+"EREGISTRARW.CLICK."+"'", "font-family:'Microsoft Sans Serif'; font-size:13.0pt; font-weight:bold; font-style:normal; color:#646464;", "TextBlock", 5, "", 1, 1, 0, "HLP_Login.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_6_0S2e( true) ;
         }
         else
         {
            wb_table2_6_0S2e( false) ;
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
         PA0S2( ) ;
         WS0S2( ) ;
         WE0S2( ) ;
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
         AddStyleSheetFile("HugaoMessages/css/jquery.growl.min.css", "?12514575");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0185564");
         if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "") == 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "alerts", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "Alerts";
            WebComp_Webcomp1_Component = "Alerts";
         }
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.componentthemes();
            }
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20223310193077");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("login.js", "?20223310193077");
         context.AddJavascriptSource("HugaoMessages/js/jquery.growl.min.js", "");
         context.AddJavascriptSource("HugaoMessages/HugaoMessagesRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgImage1_Internalname = "IMAGE1";
         edtavUsuario_Internalname = "vUSUARIO";
         edtavContrasena_Internalname = "vCONTRASENA";
         bttButton1_Internalname = "BUTTON1";
         lblRegistrarw_Internalname = "REGISTRARW";
         tblTable2_Internalname = "TABLE2";
         Hugaomessages1_Internalname = "HUGAOMESSAGES1";
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
         edtavContrasena_Jsonclick = "";
         edtavUsuario_Jsonclick = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Login";
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
         setEventMetadata("'INICIAR SESIÓN '","{handler:'E110S2',iparms:[{av:'AV5usuario',fld:'vUSUARIO',pic:'',nv:''},{av:'AV6contrasena',fld:'vCONTRASENA',pic:'',nv:''},{av:'A173usuario',fld:'USUARIO',pic:'',nv:''},{av:'A174contrasena',fld:'CONTRASENA',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E120S2',iparms:[{av:'A173usuario',fld:'USUARIO',pic:'',nv:''},{av:'AV5usuario',fld:'vUSUARIO',pic:'',nv:''},{av:'A174contrasena',fld:'CONTRASENA',pic:'',nv:''},{av:'AV6contrasena',fld:'vCONTRASENA',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("REGISTRARW.CLICK","{handler:'E140S2',iparms:[],oparms:[]}");
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
         A173usuario = "";
         A174contrasena = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         WebComp_Webcomp1_Component = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV5usuario = "";
         AV6contrasena = "";
         scmdbuf = "";
         H000S2_A9idusuario = new int[1] ;
         H000S2_A173usuario = new String[] {""} ;
         H000S2_n173usuario = new bool[] {false} ;
         H000S2_A174contrasena = new String[] {""} ;
         H000S2_n174contrasena = new bool[] {false} ;
         AV8WebSession = context.GetSession();
         H000S3_A9idusuario = new int[1] ;
         H000S3_A173usuario = new String[] {""} ;
         H000S3_n173usuario = new bool[] {false} ;
         H000S3_A174contrasena = new String[] {""} ;
         H000S3_n174contrasena = new bool[] {false} ;
         sStyleString = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttButton1_Jsonclick = "";
         lblRegistrarw_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.login__default(),
            new Object[][] {
                new Object[] {
               H000S2_A9idusuario, H000S2_A173usuario, H000S2_n173usuario, H000S2_A174contrasena, H000S2_n174contrasena
               }
               , new Object[] {
               H000S3_A9idusuario, H000S3_A173usuario, H000S3_n173usuario, H000S3_A174contrasena, H000S3_n174contrasena
               }
            }
         );
         WebComp_Webcomp1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRcdExists_4 ;
      private short nIsMod_4 ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV15GXLvl10 ;
      private short AV16GXLvl37 ;
      private short nGXWrapped ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String WebComp_Webcomp1_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsuario_Internalname ;
      private String edtavContrasena_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String TempTags ;
      private String edtavUsuario_Jsonclick ;
      private String edtavContrasena_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblRegistrarw_Internalname ;
      private String lblRegistrarw_Jsonclick ;
      private String Hugaomessages1_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n173usuario ;
      private bool n174contrasena ;
      private bool returnInSub ;
      private String A173usuario ;
      private String A174contrasena ;
      private String AV5usuario ;
      private String AV6contrasena ;
      private GXWebComponent WebComp_Webcomp1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H000S2_A9idusuario ;
      private String[] H000S2_A173usuario ;
      private bool[] H000S2_n173usuario ;
      private String[] H000S2_A174contrasena ;
      private bool[] H000S2_n174contrasena ;
      private int[] H000S3_A9idusuario ;
      private String[] H000S3_A173usuario ;
      private bool[] H000S3_n173usuario ;
      private String[] H000S3_A174contrasena ;
      private bool[] H000S3_n174contrasena ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IGxSession AV8WebSession ;
      private GXWebForm Form ;
   }

   public class login__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000S2 ;
          prmH000S2 = new Object[] {
          new Object[] {"AV5usuario",NpgsqlDbType.Varchar,25,0}
          } ;
          Object[] prmH000S3 ;
          prmH000S3 = new Object[] {
          new Object[] {"AV5usuario",NpgsqlDbType.Varchar,25,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000S2", "SELECT idusuario, usuario, contrasena FROM public.usuarios WHERE usuario = ( :AV5usuario) ORDER BY idusuario ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S2,100,0,true,false )
             ,new CursorDef("H000S3", "SELECT idusuario, usuario, contrasena FROM public.usuarios WHERE usuario = ( :AV5usuario) ORDER BY idusuario ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S3,100,0,true,false )
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
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
