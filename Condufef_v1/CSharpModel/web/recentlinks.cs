/*
               File: RecentLinks
        Description: Recent Links web component
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:48:52.64
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class recentlinks : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public recentlinks( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
      }

      public recentlinks( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_FormCaption ,
                           String aP1_FormPgmName )
      {
         this.AV6FormCaption = aP0_FormCaption;
         this.AV7FormPgmName = aP1_FormPgmName;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV6FormCaption = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
                  AV7FormPgmName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV6FormCaption,(String)AV7FormPgmName});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Links") == 0 )
               {
                  nRC_GXsfl_7 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_7_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_7_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrLinks_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Links") == 0 )
               {
                  AV6FormCaption = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrLinks_refresh( AV6FormCaption, sPrefix) ;
                  GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
                  return  ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA022( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS022( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Recent Links web component") ;
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
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxcfg.js", "?20221233485266");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body") ;
            bodyStyle = "white-space: nowrap;";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("recentlinks.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6FormCaption)) + "," + UrlEncode(StringUtil.RTrim(AV7FormPgmName))+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            }
         }
         else
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_7", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_7), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6FormCaption", StringUtil.RTrim( wcpOAV6FormCaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7FormPgmName", wcpOAV7FormPgmName);
         GxWebStd.gx_hidden_field( context, sPrefix+"vFORMCAPTION", StringUtil.RTrim( AV6FormCaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"vFORMPGMNAME", AV7FormPgmName);
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void RenderHtmlCloseForm022( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("recentlinks.js", "?20221233485267");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            include_jscripts( ) ;
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "RecentLinks" ;
      }

      public override String GetPgmdesc( )
      {
         return "Recent Links web component" ;
      }

      protected void WB020( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "recentlinks.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_022( true) ;
         }
         else
         {
            wb_table1_2_022( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_022e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table2_14_022( true) ;
         }
         else
         {
            wb_table2_14_022( false) ;
         }
         return  ;
      }

      protected void wb_table2_14_022e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START022( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
               Form.Meta.addItem("description", "Recent Links web component", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP020( ) ;
            }
         }
      }

      protected void WS022( )
      {
         START022( ) ;
         EVT022( ) ;
      }

      protected void EVT022( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP020( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP020( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "LINKS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP020( ) ;
                              }
                              nGXsfl_7_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_7_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_7_idx), 4, 0)), 4, "0");
                              SubsflControlProps_72( ) ;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E11022 */
                                          E11022 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LINKS.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E12022 */
                                          E12022 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP020( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE022( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm022( ) ;
            }
         }
      }

      protected void PA022( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrLinks_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_72( ) ;
         while ( nGXsfl_7_idx <= nRC_GXsfl_7 )
         {
            sendrow_72( ) ;
            nGXsfl_7_idx = (short)(((subLinks_Islastpage==1)&&(nGXsfl_7_idx+1>subLinks_Recordsperpage( )) ? 1 : nGXsfl_7_idx+1));
            sGXsfl_7_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_7_idx), 4, 0)), 4, "0");
            SubsflControlProps_72( ) ;
         }
         context.GX_webresponse.AddString(LinksContainer.ToJavascriptSource());
         /* End function gxnrLinks_newrow */
      }

      protected void gxgrLinks_refresh( String AV6FormCaption ,
                                        String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         LINKS_nCurrentRecord = 0;
         RF022( ) ;
         /* End function gxgrLinks_refresh */
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
         RF022( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF022( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            LinksContainer.ClearRows();
         }
         wbStart = 7;
         nGXsfl_7_idx = 1;
         sGXsfl_7_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_7_idx), 4, 0)), 4, "0");
         SubsflControlProps_72( ) ;
         nGXsfl_7_Refreshing = 1;
         LinksContainer.AddObjectProperty("GridName", "Links");
         LinksContainer.AddObjectProperty("CmpContext", sPrefix);
         LinksContainer.AddObjectProperty("InMasterPage", "false");
         LinksContainer.AddObjectProperty("Class", StringUtil.RTrim( "RecentLinksTable"));
         LinksContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         LinksContainer.AddObjectProperty("Rules", StringUtil.RTrim( "none"));
         LinksContainer.AddObjectProperty("Class", "RecentLinksTable");
         LinksContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         LinksContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         LinksContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Backcolorstyle), 1, 0, ".", "")));
         LinksContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Borderwidth), 4, 0, ".", "")));
         LinksContainer.PageSize = subLinks_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_72( ) ;
            /* Execute user event: E12022 */
            E12022 ();
            wbEnd = 7;
            WB020( ) ;
         }
         nGXsfl_7_Refreshing = 0;
      }

      protected int subLinks_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subLinks_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subLinks_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subLinks_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP020( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E11022 */
         E11022 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_7 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_7"), ",", "."));
            wcpOAV6FormCaption = cgiGet( sPrefix+"wcpOAV6FormCaption");
            wcpOAV7FormPgmName = cgiGet( sPrefix+"wcpOAV7FormPgmName");
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
         /* Execute user event: E11022 */
         E11022 ();
         if (returnInSub) return;
      }

      protected void E11022( )
      {
         /* Start Routine */
         lblPipe_Caption = "|";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblPipe_Internalname, "Caption", lblPipe_Caption);
      }

      private void E12022( )
      {
         /* Links_Load Routine */
         AV11RecentLinksItems.FromXml(AV8Session.Get("RecentLinks"), "");
         AV9i = 1;
         while ( AV9i <= AV11RecentLinksItems.Count )
         {
            AV12RecentLinksItem = ((SdtLinkList_LinkItem)AV11RecentLinksItems.Item(AV9i));
            if ( StringUtil.StrCmp(StringUtil.Trim( AV12RecentLinksItem.gxTpr_Caption), StringUtil.Trim( AV6FormCaption)) == 0 )
            {
               AV11RecentLinksItems.RemoveItem(AV9i);
            }
            else
            {
               AV9i = (int)(AV9i+1);
            }
         }
         while ( AV11RecentLinksItems.Count > 8 - 1 )
         {
            AV11RecentLinksItems.RemoveItem(1);
         }
         AV12RecentLinksItem = new SdtLinkList_LinkItem(context);
         AV12RecentLinksItem.gxTpr_Caption = StringUtil.Trim( AV6FormCaption);
         AV12RecentLinksItem.gxTpr_Url = AV10Request.ScriptName+"?"+AV10Request.QueryString;
         AV11RecentLinksItems.Add(AV12RecentLinksItem, 0);
         AV8Session.Set("RecentLinks", AV11RecentLinksItems.ToXml(false, true, "LinkList", "Condufef_v1"));
         AV9i = 1;
         while ( AV9i <= AV11RecentLinksItems.Count )
         {
            AV12RecentLinksItem = ((SdtLinkList_LinkItem)AV11RecentLinksItems.Item(AV9i));
            AV13PlaceCaption = AV12RecentLinksItem.gxTpr_Caption;
            if ( StringUtil.Len( AV13PlaceCaption) > 20 )
            {
               AV13PlaceCaption = StringUtil.Format( "%1...", StringUtil.Substring( AV13PlaceCaption, 1, 18), "", "", "", "", "", "", "", "");
            }
            lblPlace_Caption = AV13PlaceCaption;
            if ( AV9i < AV11RecentLinksItems.Count )
            {
               lblPlace_Link = formatLink(AV12RecentLinksItem.gxTpr_Url) ;
            }
            else
            {
               lblPlace_Link = "";
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 7;
            }
            sendrow_72( ) ;
            if ( isFullAjaxMode( ) && ( nGXsfl_7_Refreshing == 0 ) )
            {
               context.DoAjaxLoad(7, LinksRow);
            }
            AV9i = (int)(AV9i+1);
         }
      }

      protected void wb_table2_14_022( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblBottomline_Internalname, tblBottomline_Internalname, "", "TableHorizontalLine", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_14_022e( true) ;
         }
         else
         {
            wb_table2_14_022e( false) ;
         }
      }

      protected void wb_table1_2_022( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "RecentLinksTable", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:1%")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRecenttext_Internalname, "Recents: ", "", "", lblRecenttext_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "RecentLink", 0, "", 1, 1, 0, "HLP_RecentLinks.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            LinksContainer.SetIsFreestyle(true);
            LinksContainer.SetWrapped(nGXWrapped);
            if ( LinksContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"LinksContainer"+"DivS\" data-gxgridid=\"7\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subLinks_Internalname, subLinks_Internalname, "", "RecentLinksTable", 0, "", "", 1, 2, sStyleString, "none", 0);
               LinksContainer.AddObjectProperty("GridName", "Links");
            }
            else
            {
               LinksContainer.AddObjectProperty("GridName", "Links");
               LinksContainer.AddObjectProperty("Class", StringUtil.RTrim( "RecentLinksTable"));
               LinksContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("Rules", StringUtil.RTrim( "none"));
               LinksContainer.AddObjectProperty("Class", "RecentLinksTable");
               LinksContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Backcolorstyle), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Borderwidth), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("CmpContext", sPrefix);
               LinksContainer.AddObjectProperty("InMasterPage", "false");
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksColumn.AddObjectProperty("Value", lblPlace_Caption);
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksColumn.AddObjectProperty("Value", lblPipe_Caption);
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowselection), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Selectioncolor), 9, 0, ".", "")));
               LinksContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowhovering), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Hoveringcolor), 9, 0, ".", "")));
               LinksContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowcollapsing), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 7 )
         {
            wbEnd = 0;
            nRC_GXsfl_7 = (short)(nGXsfl_7_idx-1);
            if ( LinksContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"LinksContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Links", LinksContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"LinksContainerData", LinksContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"LinksContainerData"+"V", LinksContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"LinksContainerData"+"V"+"\" value='"+LinksContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='td100'>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_022e( true) ;
         }
         else
         {
            wb_table1_2_022e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6FormCaption = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
         AV7FormPgmName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
      }

      public override String getresponse( String sGXDynURL )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA022( ) ;
         WS022( ) ;
         WE022( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV6FormCaption = (String)((String)getParm(obj,0));
         sCtrlAV7FormPgmName = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA022( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "recentlinks");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA022( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV6FormCaption = (String)getParm(obj,2);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
            AV7FormPgmName = (String)getParm(obj,3);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
         }
         wcpOAV6FormCaption = cgiGet( sPrefix+"wcpOAV6FormCaption");
         wcpOAV7FormPgmName = cgiGet( sPrefix+"wcpOAV7FormPgmName");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV6FormCaption, wcpOAV6FormCaption) != 0 ) || ( StringUtil.StrCmp(AV7FormPgmName, wcpOAV7FormPgmName) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV6FormCaption = AV6FormCaption;
         wcpOAV7FormPgmName = AV7FormPgmName;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV6FormCaption = cgiGet( sPrefix+"AV6FormCaption_CTRL");
         if ( StringUtil.Len( sCtrlAV6FormCaption) > 0 )
         {
            AV6FormCaption = cgiGet( sCtrlAV6FormCaption);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
         }
         else
         {
            AV6FormCaption = cgiGet( sPrefix+"AV6FormCaption_PARM");
         }
         sCtrlAV7FormPgmName = cgiGet( sPrefix+"AV7FormPgmName_CTRL");
         if ( StringUtil.Len( sCtrlAV7FormPgmName) > 0 )
         {
            AV7FormPgmName = cgiGet( sCtrlAV7FormPgmName);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
         }
         else
         {
            AV7FormPgmName = cgiGet( sPrefix+"AV7FormPgmName_PARM");
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA022( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS022( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS022( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6FormCaption_PARM", StringUtil.RTrim( AV6FormCaption));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6FormCaption)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6FormCaption_CTRL", StringUtil.RTrim( sCtrlAV6FormCaption));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7FormPgmName_PARM", AV7FormPgmName);
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7FormPgmName)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7FormPgmName_CTRL", StringUtil.RTrim( sCtrlAV7FormPgmName));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE022( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?3485073");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221233485276");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("recentlinks.js", "?20221233485277");
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_72( )
      {
         lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_7_idx;
         lblPipe_Internalname = sPrefix+"PIPE_"+sGXsfl_7_idx;
      }

      protected void SubsflControlProps_fel_72( )
      {
         lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_7_fel_idx;
         lblPipe_Internalname = sPrefix+"PIPE_"+sGXsfl_7_fel_idx;
      }

      protected void sendrow_72( )
      {
         SubsflControlProps_72( ) ;
         WB020( ) ;
         LinksRow = GXWebRow.GetNew(context,LinksContainer);
         if ( subLinks_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subLinks_Backstyle = 0;
            if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
            {
               subLinks_Linesclass = subLinks_Class+"Odd";
            }
         }
         else if ( subLinks_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subLinks_Backstyle = 0;
            subLinks_Backcolor = subLinks_Allbackcolor;
            if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
            {
               subLinks_Linesclass = subLinks_Class+"Uniform";
            }
         }
         else if ( subLinks_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subLinks_Backstyle = 1;
            if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
            {
               subLinks_Linesclass = subLinks_Class+"Odd";
            }
            subLinks_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subLinks_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subLinks_Backstyle = 1;
            if ( ((int)(((nGXsfl_7_idx-1)/ (decimal)(0)) % (2))) == 0 )
            {
               subLinks_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
               {
                  subLinks_Linesclass = subLinks_Class+"Odd";
               }
            }
            else
            {
               subLinks_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
               {
                  subLinks_Linesclass = subLinks_Class+"Even";
               }
            }
         }
         /* Start of Columns property logic. */
         LinksRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)subLinks_Linesclass,(String)""});
         LinksRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",""+" style=\""+CSSHelper.Prettify( "width:37px")+"\""});
         /* Text block */
         LinksRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblPlace_Internalname,(String)lblPlace_Caption,(String)lblPlace_Link,(String)"",(String)lblPlace_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"RecentLinkItem",(short)0,(String)"",(short)1,(short)1,(short)0});
         if ( LinksContainer.GetWrapped() == 1 )
         {
            LinksContainer.CloseTag("cell");
         }
         LinksRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",""+" style=\""+CSSHelper.Prettify( "width:4px")+"\""});
         /* Text block */
         LinksRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblPipe_Internalname,(String)lblPipe_Caption,(String)"",(String)"",(String)lblPipe_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"RecentLinkItem",(short)0,(String)"",(short)1,(short)1,(short)0});
         if ( LinksContainer.GetWrapped() == 1 )
         {
            LinksContainer.CloseTag("cell");
         }
         if ( LinksContainer.GetWrapped() == 1 )
         {
            LinksContainer.CloseTag("row");
         }
         /* End of Columns property logic. */
         LinksContainer.AddRow(LinksRow);
         nGXsfl_7_idx = (short)(((subLinks_Islastpage==1)&&(nGXsfl_7_idx+1>subLinks_Recordsperpage( )) ? 1 : nGXsfl_7_idx+1));
         sGXsfl_7_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_7_idx), 4, 0)), 4, "0");
         SubsflControlProps_72( ) ;
         /* End function sendrow_72 */
      }

      protected void init_default_properties( )
      {
         lblRecenttext_Internalname = sPrefix+"RECENTTEXT";
         lblPlace_Internalname = sPrefix+"PLACE";
         lblPipe_Internalname = sPrefix+"PIPE";
         tblTable_Internalname = sPrefix+"TABLE";
         tblBottomline_Internalname = sPrefix+"BOTTOMLINE";
         Form.Internalname = sPrefix+"FORM";
         subLinks_Internalname = sPrefix+"LINKS";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         lblPlace_Jsonclick = "";
         lblPlace_Link = "";
         subLinks_Class = "RecentLinksTable";
         subLinks_Allowcollapsing = 0;
         lblPipe_Caption = "";
         lblPlace_Caption = "Place";
         lblPipe_Caption = "";
         subLinks_Borderwidth = 0;
         subLinks_Backcolorstyle = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'LINKS_nFirstRecordOnPage',nv:0},{av:'LINKS_nEOF',nv:0},{av:'AV6FormCaption',fld:'vFORMCAPTION',pic:'',nv:''},{av:'sPrefix',nv:''}],oparms:[]}");
         setEventMetadata("LINKS.LOAD","{handler:'E12022',iparms:[{av:'AV6FormCaption',fld:'vFORMCAPTION',pic:'',nv:''}],oparms:[{av:'lblPlace_Caption',ctrl:'PLACE',prop:'Caption'},{av:'lblPlace_Link',ctrl:'PLACE',prop:'Link'}]}");
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
         wcpOAV6FormCaption = "";
         wcpOAV7FormPgmName = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         LinksContainer = new GXWebGrid( context);
         AV11RecentLinksItems = new GxObjectCollection( context, "LinkList.LinkItem", "Condufef_v1", "SdtLinkList_LinkItem", "GeneXus.Programs");
         AV8Session = context.GetSession();
         AV12RecentLinksItem = new SdtLinkList_LinkItem(context);
         AV10Request = new GxHttpRequest( context);
         AV13PlaceCaption = "";
         LinksRow = new GXWebRow();
         sStyleString = "";
         lblRecenttext_Jsonclick = "";
         LinksColumn = new GXWebColumn();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV6FormCaption = "";
         sCtrlAV7FormPgmName = "";
         subLinks_Linesclass = "";
         lblPipe_Jsonclick = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_7 ;
      private short nGXsfl_7_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_7_Refreshing=0 ;
      private short subLinks_Backcolorstyle ;
      private short subLinks_Borderwidth ;
      private short subLinks_Allowselection ;
      private short subLinks_Allowhovering ;
      private short subLinks_Allowcollapsing ;
      private short subLinks_Collapsed ;
      private short subLinks_Backstyle ;
      private short LINKS_nEOF ;
      private int subLinks_Islastpage ;
      private int AV9i ;
      private int subLinks_Selectioncolor ;
      private int subLinks_Hoveringcolor ;
      private int idxLst ;
      private int subLinks_Backcolor ;
      private int subLinks_Allbackcolor ;
      private long LINKS_nCurrentRecord ;
      private long LINKS_nFirstRecordOnPage ;
      private String AV6FormCaption ;
      private String wcpOAV6FormCaption ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_7_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String lblPipe_Caption ;
      private String lblPipe_Internalname ;
      private String lblPlace_Caption ;
      private String lblPlace_Link ;
      private String sStyleString ;
      private String tblBottomline_Internalname ;
      private String tblTable_Internalname ;
      private String lblRecenttext_Internalname ;
      private String lblRecenttext_Jsonclick ;
      private String subLinks_Internalname ;
      private String sCtrlAV6FormCaption ;
      private String sCtrlAV7FormPgmName ;
      private String lblPlace_Internalname ;
      private String sGXsfl_7_fel_idx="0001" ;
      private String subLinks_Class ;
      private String subLinks_Linesclass ;
      private String lblPlace_Jsonclick ;
      private String lblPipe_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV7FormPgmName ;
      private String wcpOAV7FormPgmName ;
      private String AV13PlaceCaption ;
      private IGxSession AV8Session ;
      private GXWebGrid LinksContainer ;
      private GXWebRow LinksRow ;
      private GXWebColumn LinksColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10Request ;
      [ObjectCollection(ItemType=typeof( SdtLinkList_LinkItem ))]
      private IGxCollection AV11RecentLinksItems ;
      private SdtLinkList_LinkItem AV12RecentLinksItem ;
   }

}
