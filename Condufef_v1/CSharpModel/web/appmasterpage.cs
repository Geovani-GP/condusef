/*
               File: AppMasterPage
        Description: Application Master Page
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:4.40
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
   public class appmasterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public appmasterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public appmasterpage( IGxContext context )
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
         initialize_properties( ) ;
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
            PA012( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavTitulo_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavTitulo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTitulo_Enabled), 5, 0)));
               edtavUsuario_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsuario_Enabled), 5, 0)));
               edtavFecha_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFecha_Enabled), 5, 0)));
               WS012( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE012( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlHeaders();
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlOpenForm();
         }
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "gxhash_vTITULO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV11Titulo, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUARIO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV8usuario, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_vFECHA_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV10fecha, ""))));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void RenderHtmlCloseForm012( )
      {
         SendCloseFormHiddens( ) ;
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            WebComp_Webcomp1.componentjscripts();
         }
         context.AddJavascriptSource("appmasterpage.js", "?20221302338441");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "AppMasterPage" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application Master Page " ;
      }

      protected void WB010( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               /* Content placeholder */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gx-content-placeholder");
               context.WriteHtmlText( ">") ;
               if ( ! isFullAjaxMode( ) )
               {
                  getDataAreaObject().RenderHtmlContent();
               }
               context.WriteHtmlText( "</div>") ;
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
               wbLoad = true;
               return  ;
            }
            wb_table1_2_012( true) ;
         }
         else
         {
            wb_table1_2_012( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true;
      }

      protected void START012( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP010( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      protected void WS012( )
      {
         START012( ) ;
         EVT012( ) ;
      }

      protected void EVT012( )
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
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E11012 */
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E12012 */
                           E12012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
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
                  else if ( StringUtil.StrCmp(sEvtType, "M") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-2));
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-6));
                     nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                     if ( nCmpId == 30 )
                     {
                        WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "sidebar", new Object[] {context} );
                        WebComp_Webcomp1.ComponentInit();
                        WebComp_Webcomp1.Name = "sidebar";
                        WebComp_Webcomp1_Component = "sidebar";
                        WebComp_Webcomp1.componentprocess("MPW0030", "", sEvt);
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE012( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm012( ) ;
            }
         }
      }

      protected void PA012( )
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
               GX_FocusControl = edtavTitulo_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "GX_FocusControl", GX_FocusControl);
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
         RF012( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavTitulo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavTitulo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTitulo_Enabled), 5, 0)));
         edtavUsuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsuario_Enabled), 5, 0)));
         edtavFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFecha_Enabled), 5, 0)));
      }

      protected void RF012( )
      {
         initialize_formulas( ) ;
         if ( ShowMPWhenPopUp( ) || ! context.isPopUpObject( ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
            {
               if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "") == 0 )
               {
                  WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "sidebar", new Object[] {context} );
                  WebComp_Webcomp1.ComponentInit();
                  WebComp_Webcomp1.Name = "sidebar";
                  WebComp_Webcomp1_Component = "sidebar";
               }
               if ( ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "sidebar") == 0 ) )
               {
                  WebComp_Webcomp1.setjustcreated();
                  WebComp_Webcomp1.componentprepare(new Object[] {(String)"MPW0030",(String)""});
                  WebComp_Webcomp1.componentbind(new Object[] {});
               }
               if ( isFullAjaxMode( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0030"+"");
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
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E12012 */
            E12012 ();
            WB010( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void STRUP010( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavTitulo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavTitulo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTitulo_Enabled), 5, 0)));
         edtavUsuario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsuario_Enabled), 5, 0)));
         edtavFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, edtavFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFecha_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E11012 */
         E11012 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV11Titulo = cgiGet( edtavTitulo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV11Titulo", AV11Titulo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vTITULO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV11Titulo, ""))));
            AV8usuario = cgiGet( edtavUsuario_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV8usuario", AV8usuario);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vUSUARIO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV8usuario, ""))));
            AV10fecha = cgiGet( edtavFecha_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV10fecha", AV10fecha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vFECHA_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV10fecha, ""))));
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

      protected void GXStart( )
      {
         /* Execute user event: E11012 */
         E11012 ();
         if (returnInSub) return;
      }

      protected void E11012( )
      {
         /* Start Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV7WebSession.Get("usuario"))) )
         {
            context.wjLoc = formatLink("login.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV8usuario = AV7WebSession.Get("usuario");
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV8usuario", AV8usuario);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vUSUARIO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV8usuario, ""))));
            AV10fecha = AV7WebSession.Get("fecha");
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV10fecha", AV10fecha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vFECHA_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV10fecha, ""))));
            AV11Titulo = "SISTEMA DE INVENTARIOS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV11Titulo", AV11Titulo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "gxhash_vTITULO_MPAGE", GetSecureSignedToken( "gxmpage_", StringUtil.RTrim( context.localUtil.Format( AV11Titulo, ""))));
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Webcomp1_Component), StringUtil.Lower( "sidebar")) != 0 )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "sidebar", new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "sidebar";
               WebComp_Webcomp1_Component = "sidebar";
            }
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.setjustcreated();
               WebComp_Webcomp1.componentprepare(new Object[] {(String)"MPW0030",(String)""});
               WebComp_Webcomp1.componentbind(new Object[] {});
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E12012( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table960", 0, "center", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_012( true) ;
         }
         else
         {
            wb_table2_5_012( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            wb_table3_27_012( true) ;
         }
         else
         {
            wb_table3_27_012( false) ;
         }
         return  ;
      }

      protected void wb_table3_27_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_012e( true) ;
         }
         else
         {
            wb_table1_2_012e( false) ;
         }
      }

      protected void wb_table3_27_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(80), 10, 0)) + "%" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:273px")+"\">") ;
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0030"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
               {
                  if ( ! context.isAjaxRequest( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0030"+"");
                  }
                  WebComp_Webcomp1.componentdraw();
                  if ( ! context.isAjaxRequest( ) )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            /* Content placeholder */
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-content-placeholder");
            context.WriteHtmlText( ">") ;
            if ( ! isFullAjaxMode( ) )
            {
               getDataAreaObject().RenderHtmlContent();
            }
            context.WriteHtmlText( "</div>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_012e( true) ;
         }
         else
         {
            wb_table3_27_012e( false) ;
         }
      }

      protected void wb_table2_5_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0x808080)) + ";";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(90), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "TableTop", 0, "center", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\" background=\"\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:90px;width:150px")+"\" class='GridTabMainTable'>") ;
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "4501a883-ab40-469d-8b9a-8ccc7365672d", "", context.GetTheme( )), "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 100, "%", 100, "%", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:1px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;height:90px;width:512px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',true,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTitulo_Internalname, AV11Titulo, StringUtil.RTrim( context.localUtil.Format( AV11Titulo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,11);\"", "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "", "", "", edtavTitulo_Jsonclick, 0, "Attribute", "font-family:'Verdana'; font-size:17.0pt; font-weight:bold; font-style:normal; color:#FFFFFF;", "", "", 1, edtavTitulo_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center;vertical-align:bottom;height:90px")+"\">") ;
            wb_table4_13_012( true) ;
         }
         else
         {
            wb_table4_13_012( false) ;
         }
         return  ;
      }

      protected void wb_table4_13_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_012e( true) ;
         }
         else
         {
            wb_table2_5_012e( false) ;
         }
      }

      protected void wb_table4_13_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(86), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(352), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:40px;width:1px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Usuario: ", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "color:#FFFFFF;", "TextBlock", 0, "", 1, 1, 0, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',true,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, AV8usuario, StringUtil.RTrim( context.localUtil.Format( AV8usuario, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,18);\"", "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "", "", "", edtavUsuario_Jsonclick, 0, "Attribute", "color:#FFFFFF;", "", "", 1, edtavUsuario_Enabled, 0, "text", "", 25, "chr", 1, "row", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Fecha: ", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "color:#FFFFFF;", "TextBlock", 0, "", 1, 1, 0, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',true,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFecha_Internalname, StringUtil.RTrim( AV10fecha), StringUtil.RTrim( context.localUtil.Format( AV10fecha, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,23);\"", "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "", "", "", edtavFecha_Jsonclick, 0, "Attribute", "color:#FFFFFF;", "", "", 1, edtavFecha_Enabled, 0, "text", "", 184, "px", 36, "px", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_13_012e( true) ;
         }
         else
         {
            wb_table4_13_012e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA012( ) ;
         WS012( ) ;
         WE012( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2337534");
         if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "") == 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "sidebar", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "sidebar";
            WebComp_Webcomp1_Component = "sidebar";
         }
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.componentthemes();
            }
         }
         idxLst = 1;
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?20221302338454");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("appmasterpage.js", "?20221302338454");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgImage1_Internalname = "IMAGE1_MPAGE";
         edtavTitulo_Internalname = "vTITULO_MPAGE";
         lblTextblock2_Internalname = "TEXTBLOCK2_MPAGE";
         edtavUsuario_Internalname = "vUSUARIO_MPAGE";
         lblTextblock1_Internalname = "TEXTBLOCK1_MPAGE";
         edtavFecha_Internalname = "vFECHA_MPAGE";
         tblTable4_Internalname = "TABLE4_MPAGE";
         tblTable2_Internalname = "TABLE2_MPAGE";
         tblTable3_Internalname = "TABLE3_MPAGE";
         tblTable1_Internalname = "TABLE1_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavFecha_Jsonclick = "";
         edtavFecha_Enabled = 1;
         edtavUsuario_Jsonclick = "";
         edtavUsuario_Enabled = 1;
         edtavTitulo_Jsonclick = "";
         edtavTitulo_Enabled = 1;
         Contholder1.setDataArea(getDataAreaObject());
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
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[],oparms:[]}");
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
         Contholder1 = new GXDataAreaControl();
         AV11Titulo = "";
         AV8usuario = "";
         AV10fecha = "";
         GXKey = "";
         sPrefix = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Webcomp1_Component = "";
         GX_FocusControl = "";
         AV7WebSession = context.GetSession();
         sStyleString = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         WebComp_Webcomp1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavTitulo_Enabled = 0;
         edtavUsuario_Enabled = 0;
         edtavFecha_Enabled = 0;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int edtavTitulo_Enabled ;
      private int edtavUsuario_Enabled ;
      private int edtavFecha_Enabled ;
      private int idxLst ;
      private String edtavTitulo_Internalname ;
      private String edtavUsuario_Internalname ;
      private String edtavFecha_Internalname ;
      private String AV10fecha ;
      private String GXKey ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String WebComp_Webcomp1_Component ;
      private String GX_FocusControl ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String tblTable3_Internalname ;
      private String tblTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String TempTags ;
      private String edtavTitulo_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavUsuario_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavFecha_Jsonclick ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool toggleJsOutput ;
      private bool returnInSub ;
      private String AV11Titulo ;
      private String AV8usuario ;
      private IGxSession AV7WebSession ;
      private GXWebComponent WebComp_Webcomp1 ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contholder1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
