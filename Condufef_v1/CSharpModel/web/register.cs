/*
               File: Register
        Description: Register
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 6:11:40.6
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
   public class register : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public register( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public register( IGxContext context )
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
         PA3C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3C2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215611408");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("register.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vNEXTVALUE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13NextValue), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vUSUARIOS", AV11usuarios);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vUSUARIOS", AV11usuarios);
         }
         GxWebStd.gx_hidden_field( context, "GXC1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40000GXC1), 9, 0, ",", "")));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE3C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3C2( ) ;
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
         return formatLink("register.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Register" ;
      }

      public override String GetPgmdesc( )
      {
         return "Register" ;
      }

      protected void WB3C0( )
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
            wb_table1_2_3C2( true) ;
         }
         else
         {
            wb_table1_2_3C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
            context.WriteHtmlText( "<p></p>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"HUGAOMESSAGES1Container"+"\"></div>") ;
         }
         wbLoad = true;
      }

      protected void START3C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Register", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3C0( ) ;
      }

      protected void WS3C2( )
      {
         START3C2( ) ;
         EVT3C2( ) ;
      }

      protected void EVT3C2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'LOGINW'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E113C2 */
                              E113C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E123C2 */
                              E123C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGISTRARSE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E133C2 */
                              E133C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E143C2 */
                              E143C2 ();
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

      protected void WE3C2( )
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

      protected void PA3C2( )
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
         RF3C2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF3C2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E143C2 */
            E143C2 ();
            WB3C0( ) ;
         }
      }

      protected void STRUP3C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Using cursor H003C3 */
         pr_default.execute(0);
         if ( (pr_default.getStatus(0) != 101) )
         {
            A40000GXC1 = H003C3_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(0);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E123C2 */
         E123C2 ();
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
            AV10contrasena2 = cgiGet( edtavContrasena2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10contrasena2", AV10contrasena2);
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

      protected void E113C2( )
      {
         /* 'LoginW' Routine */
         context.wjLoc = formatLink("login.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void GXStart( )
      {
         /* Execute user event: E123C2 */
         E123C2 ();
         if (returnInSub) return;
      }

      protected void E123C2( )
      {
         /* Start Routine */
         /* Using cursor H003C5 */
         pr_default.execute(1);
         if ( (pr_default.getStatus(1) != 101) )
         {
            A40000GXC1 = H003C5_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(1);
         AV13NextValue = (short)(A40000GXC1+1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13NextValue), 4, 0)));
      }

      protected void E133C2( )
      {
         /* 'Registrarse' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV5usuario)) || String.IsNullOrEmpty(StringUtil.RTrim( AV6contrasena)) || String.IsNullOrEmpty(StringUtil.RTrim( AV10contrasena2)) )
         {
            GX_msglist.addItem("Los campos estan vacios");
         }
         else
         {
            if ( StringUtil.StrCmp(AV6contrasena, AV10contrasena2) == 0 )
            {
               /* Using cursor H003C6 */
               pr_default.execute(2);
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A173usuario = H003C6_A173usuario[0];
                  n173usuario = H003C6_n173usuario[0];
                  if ( StringUtil.StrCmp(A173usuario, AV5usuario) == 0 )
                  {
                     GX_msglist.addItem("El usuario ya existe");
                  }
                  else
                  {
                     AV11usuarios.gxTpr_Idusuario = AV13NextValue;
                     AV11usuarios.gxTpr_Usuario = AV5usuario;
                     AV11usuarios.gxTpr_Contrasena = AV6contrasena;
                     AV11usuarios.Save();
                     if ( AV11usuarios.Success() )
                     {
                        context.CommitDataStores( "Register");
                        GX_msglist.addItem("Usuario Registrado");
                        context.wjLoc = formatLink("login.aspx") ;
                        context.wjLocDisableFrm = 1;
                        GX_msglist.addItem("Usuario Registrado");
                     }
                     else
                     {
                        GX_msglist.addItem("error");
                        context.RollbackDataStores( "Register");
                     }
                  }
                  pr_default.readNext(2);
               }
               pr_default.close(2);
            }
            else
            {
               GX_msglist.addItem("Las contraseñas deben ser iguales");
            }
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11usuarios", AV11usuarios);
      }

      protected void nextLoad( )
      {
      }

      protected void E143C2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_3C2( bool wbgen )
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:35px")+"\">") ;
            context.WriteHtmlText( "Usuario") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"left\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-left;text-align:-moz-left;text-align:-webkit-left;height:100%;width:100%")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, AV5usuario, StringUtil.RTrim( context.localUtil.Format( AV5usuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,9);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsuario_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 100, "%", 35, "px", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Register.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavContrasena_Internalname, AV6contrasena, StringUtil.RTrim( context.localUtil.Format( AV6contrasena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavContrasena_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 100, "%", 35, "px", 10, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Register.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:0px")+"\">") ;
            context.WriteHtmlText( "<p>") ;
            context.WriteHtmlText( "Repetir ") ;
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "<p>") ;
            context.WriteHtmlText( "Contraseña ") ;
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavContrasena2_Internalname, AV10contrasena2, StringUtil.RTrim( context.localUtil.Format( AV10contrasena2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavContrasena2_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 100, "%", 35, "px", 50, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Register.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008080;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Registrarse", bttButton1_Jsonclick, 5, "Registrarse", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'REGISTRARSE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Register.htm");
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
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:26px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#2F4F4F;";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Regresar", bttButton2_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'LOGINW\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Register.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3C2e( true) ;
         }
         else
         {
            wb_table1_2_3C2e( false) ;
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
         PA3C2( ) ;
         WS3C2( ) ;
         WE3C2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?583790");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20222156114018");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("register.js", "?20222156114018");
         context.AddJavascriptSource("HugaoMessages/js/jquery.growl.min.js", "");
         context.AddJavascriptSource("HugaoMessages/HugaoMessagesRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavUsuario_Internalname = "vUSUARIO";
         edtavContrasena_Internalname = "vCONTRASENA";
         edtavContrasena2_Internalname = "vCONTRASENA2";
         bttButton1_Internalname = "BUTTON1";
         bttButton2_Internalname = "BUTTON2";
         tblTable2_Internalname = "TABLE2";
         Hugaomessages1_Internalname = "HUGAOMESSAGES1";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavContrasena2_Jsonclick = "";
         edtavContrasena_Jsonclick = "";
         edtavUsuario_Jsonclick = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Register";
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
         setEventMetadata("'LOGINW'","{handler:'E113C2',iparms:[],oparms:[]}");
         setEventMetadata("'REGISTRARSE'","{handler:'E133C2',iparms:[{av:'AV5usuario',fld:'vUSUARIO',pic:'',nv:''},{av:'AV6contrasena',fld:'vCONTRASENA',pic:'',nv:''},{av:'AV10contrasena2',fld:'vCONTRASENA2',pic:'',nv:''},{av:'A173usuario',fld:'USUARIO',pic:'',nv:''},{av:'AV13NextValue',fld:'vNEXTVALUE',pic:'ZZZ9',nv:0},{av:'AV11usuarios',fld:'vUSUARIOS',pic:'',nv:null}],oparms:[{av:'AV11usuarios',fld:'vUSUARIOS',pic:'',nv:null}]}");
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
         AV11usuarios = new Sdtusuarios(context);
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003C3_A40000GXC1 = new int[1] ;
         AV5usuario = "";
         AV6contrasena = "";
         AV10contrasena2 = "";
         H003C5_A40000GXC1 = new int[1] ;
         H003C6_A9idusuario = new int[1] ;
         H003C6_A173usuario = new String[] {""} ;
         H003C6_n173usuario = new bool[] {false} ;
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.register__default(),
            new Object[][] {
                new Object[] {
               H003C3_A40000GXC1
               }
               , new Object[] {
               H003C5_A40000GXC1
               }
               , new Object[] {
               H003C6_A9idusuario, H003C6_A173usuario, H003C6_n173usuario
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short AV13NextValue ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A40000GXC1 ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsuario_Internalname ;
      private String scmdbuf ;
      private String edtavContrasena_Internalname ;
      private String edtavContrasena2_Internalname ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String TempTags ;
      private String edtavUsuario_Jsonclick ;
      private String edtavContrasena_Jsonclick ;
      private String edtavContrasena2_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String Hugaomessages1_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool n173usuario ;
      private String A173usuario ;
      private String AV5usuario ;
      private String AV6contrasena ;
      private String AV10contrasena2 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H003C3_A40000GXC1 ;
      private int[] H003C5_A40000GXC1 ;
      private int[] H003C6_A9idusuario ;
      private String[] H003C6_A173usuario ;
      private bool[] H003C6_n173usuario ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private Sdtusuarios AV11usuarios ;
   }

   public class register__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003C3 ;
          prmH003C3 = new Object[] {
          } ;
          Object[] prmH003C5 ;
          prmH003C5 = new Object[] {
          } ;
          Object[] prmH003C6 ;
          prmH003C6 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H003C3", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(idusuario) AS GXC1 FROM public.usuarios ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003C3,1,0,true,false )
             ,new CursorDef("H003C5", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(idusuario) AS GXC1 FROM public.usuarios ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003C5,1,0,true,false )
             ,new CursorDef("H003C6", "SELECT idusuario, usuario FROM public.usuarios ORDER BY idusuario ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003C6,100,0,true,false )
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
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
