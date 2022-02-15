/*
               File: Catalog_De_Empleados
        Description: Catalog_De_Empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:23.26
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
   public class catalog_de_empleados : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public catalog_de_empleados( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public catalog_de_empleados( IGxContext context )
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
         dynavAreaareaid = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vAREAAREAID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvAREAAREAID2T2( ) ;
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
         PA2T2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2T2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215592328");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("catalog_de_empleados.aspx") +"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vEMPLEADOS", AV24empleados);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vEMPLEADOS", AV24empleados);
         }
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GXC1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40000GXC1), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Catalog_De_Empleados";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("catalog_de_empleados:[SendSecurityCheck value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9"));
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
            WE2T2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2T2( ) ;
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
         return formatLink("catalog_de_empleados.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Catalog_De_Empleados" ;
      }

      public override String GetPgmdesc( )
      {
         return "Catalog_De_Empleados" ;
      }

      protected void WB2T0( )
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
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "<p>") ;
            wb_table1_4_2T2( true) ;
         }
         else
         {
            wb_table1_4_2T2( false) ;
         }
         return  ;
      }

      protected void wb_table1_4_2T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Catalog_De_Empleados", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2T0( ) ;
      }

      protected void WS2T2( )
      {
         START2T2( ) ;
         EVT2T2( ) ;
      }

      protected void EVT2T2( )
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
                              /* Execute user event: E112T2 */
                              E112T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GUARDAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E122T2 */
                              E122T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONSULTAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E132T2 */
                              E132T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E142T2 */
                              E142T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E152T2 */
                              E152T2 ();
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

      protected void WE2T2( )
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

      protected void PA2T2( )
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
            dynavAreaareaid.Name = "vAREAAREAID";
            dynavAreaareaid.WebTags = "";
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

      protected void GXDLVvAREAAREAID2T2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvAREAAREAID_data2T2( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",d:\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXVvAREAAREAID_html2T2( )
      {
         int gxdynajaxvalue ;
         GXDLVvAREAAREAID_data2T2( ) ;
         gxdynajaxindex = 1;
         dynavAreaareaid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavAreaareaid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavAreaareaid.ItemCount > 0 )
         {
            AV28areaareaid = (int)(NumberUtil.Val( dynavAreaareaid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0)));
         }
      }

      protected void GXDLVvAREAAREAID_data2T2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona");
         /* Using cursor H002T2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002T2_A22areaareaid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002T2_A27areadsc[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavAreaareaid.ItemCount > 0 )
         {
            AV28areaareaid = (int)(NumberUtil.Val( dynavAreaareaid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0)));
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2T2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
      }

      protected void RF2T2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E152T2 */
            E152T2 ();
            WB2T0( ) ;
         }
      }

      protected void STRUP2T0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
         GXVvAREAAREAID_html2T2( ) ;
         /* Using cursor H002T4 */
         pr_default.execute(1);
         if ( (pr_default.getStatus(1) != 101) )
         {
            A40000GXC1 = H002T4_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(1);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E112T2 */
         E112T2 ();
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
               AV11NextValue = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")));
            }
            else
            {
               AV11NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")));
            }
            dynavAreaareaid.CurrentValue = cgiGet( dynavAreaareaid_Internalname);
            AV28areaareaid = (int)(NumberUtil.Val( cgiGet( dynavAreaareaid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28areaareaid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0)));
            AV13empleadosnomemple = cgiGet( edtavEmpleadosnomemple_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empleadosnomemple", AV13empleadosnomemple);
            AV14empleadosappaterno = cgiGet( edtavEmpleadosappaterno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empleadosappaterno", AV14empleadosappaterno);
            AV15empleadosapmaterno = cgiGet( edtavEmpleadosapmaterno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15empleadosapmaterno", AV15empleadosapmaterno);
            AV16empleadosstatus = cgiGet( edtavEmpleadosstatus_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16empleadosstatus", AV16empleadosstatus);
            AV18empleadoscorreo = cgiGet( edtavEmpleadoscorreo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18empleadoscorreo", AV18empleadoscorreo);
            AV19empleadosext = cgiGet( edtavEmpleadosext_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19empleadosext", AV19empleadosext);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "Catalog_De_Empleados";
            AV11NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11NextValue), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("catalog_de_empleados:[SecurityCheckFailed value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9"));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
            GXVvAREAAREAID_html2T2( ) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E112T2 */
         E112T2 ();
         if (returnInSub) return;
      }

      protected void E112T2( )
      {
         /* Start Routine */
         /* Using cursor H002T6 */
         pr_default.execute(2);
         if ( (pr_default.getStatus(2) != 101) )
         {
            A40000GXC1 = H002T6_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(2);
         AV11NextValue = (short)(A40000GXC1+1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11NextValue), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")));
      }

      protected void E122T2( )
      {
         /* 'Guardar ' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13empleadosnomemple)) || String.IsNullOrEmpty(StringUtil.RTrim( AV14empleadosappaterno)) || (0==AV28areaareaid) || String.IsNullOrEmpty(StringUtil.RTrim( AV15empleadosapmaterno)) || String.IsNullOrEmpty(StringUtil.RTrim( AV16empleadosstatus)) || String.IsNullOrEmpty(StringUtil.RTrim( AV18empleadoscorreo)) || String.IsNullOrEmpty(StringUtil.RTrim( AV19empleadosext)) )
         {
            GX_msglist.addItem("Los campos estan vacios");
         }
         else
         {
            AV24empleados.gxTpr_Empleadosid = AV11NextValue;
            AV24empleados.gxTpr_Empleadosareaid = StringUtil.Str( (decimal)(AV28areaareaid), 9, 0);
            AV24empleados.gxTpr_Empleadosnomemple = AV13empleadosnomemple;
            AV24empleados.gxTpr_Empleadosappaterno = AV14empleadosappaterno;
            AV24empleados.gxTpr_Empleadosapmaterno = AV15empleadosapmaterno;
            AV24empleados.gxTpr_Empleadosstatus = AV16empleadosstatus;
            AV24empleados.gxTpr_Empleadoscorreo = AV18empleadoscorreo;
            AV24empleados.gxTpr_Empleadosext = AV19empleadosext;
            AV24empleados.gxTpr_Empleadosfecreg = Gx_date;
            AV24empleados.gxTpr_Empleadosusuario = AV8WebSession.Get("usuario");
            AV24empleados.Save();
            if ( AV24empleados.Success() )
            {
               context.CommitDataStores( "Catalog_De_Empleados");
               context.wjLoc = formatLink("catalog_de_empleados.aspx") ;
               context.wjLocDisableFrm = 1;
            }
            else
            {
               context.RollbackDataStores( "Catalog_De_Empleados");
            }
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24empleados", AV24empleados);
      }

      protected void E132T2( )
      {
         /* 'Consultar ' Routine */
         context.wjLoc = formatLink("detallesempleados.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void E142T2( )
      {
         /* 'Cancelar' Routine */
         context.wjLoc = formatLink("menuprincipal.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void nextLoad( )
      {
      }

      protected void E152T2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_4_2T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(114), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(682), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock_Internalname, "CATALOGO DE EMPLEADOS", "", "", lblTextblock_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:15.0pt; font-weight:bold; font-style:normal; color:#000000;", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_10_2T2( true) ;
         }
         else
         {
            wb_table2_10_2T2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_2T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_33_2T2( true) ;
         }
         else
         {
            wb_table3_33_2T2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_2T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_4_2T2e( true) ;
         }
         else
         {
            wb_table1_4_2T2e( false) ;
         }
      }

      protected void wb_table3_33_2T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(90), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(678), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:337px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "ApellidoMaterno:", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:468px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadosapmaterno_Internalname, AV15empleadosapmaterno, StringUtil.RTrim( context.localUtil.Format( AV15empleadosapmaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadosapmaterno_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:131px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Estatus:", "", "", lblTextblock6_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadosstatus_Internalname, AV16empleadosstatus, StringUtil.RTrim( context.localUtil.Format( AV16empleadosstatus, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadosstatus_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Correo:", "", "", lblTextblock7_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadoscorreo_Internalname, AV18empleadoscorreo, StringUtil.RTrim( context.localUtil.Format( AV18empleadoscorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadoscorreo_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:24px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Exit:", "", "", lblTextblock8_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadosext_Internalname, AV19empleadosext, StringUtil.RTrim( context.localUtil.Format( AV19empleadosext, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadosext_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:24px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "CONSULTAR", bttButton1_Jsonclick, 5, "CONSULTAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CONSULTAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "GUARDAR", bttButton2_Jsonclick, 5, "GUARDAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GUARDAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#FF0000;";
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "CANCELAR", bttButton3_Jsonclick, 5, "CANCELAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CANCELAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_2T2e( true) ;
         }
         else
         {
            wb_table3_33_2T2e( false) ;
         }
      }

      protected void wb_table2_10_2T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(68), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(677), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:22px;width:136px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Empleado:", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:333px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNextvalue_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11NextValue), 4, 0, ",", "")), ((edtavNextvalue_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")) : context.localUtil.Format( (decimal)(AV11NextValue), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,15);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNextvalue_Jsonclick, 0, "Attribute", "", "", "", 1, edtavNextvalue_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:20px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Area:", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavAreaareaid, dynavAreaareaid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0)), 1, dynavAreaareaid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavAreaareaid.Enabled, 0, 0, 155, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,20);\"", "", true, "HLP_Catalog_De_Empleados.htm");
            dynavAreaareaid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV28areaareaid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavAreaareaid_Internalname, "Values", (String)(dynavAreaareaid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Nombre:", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadosnomemple_Internalname, AV13empleadosnomemple, StringUtil.RTrim( context.localUtil.Format( AV13empleadosnomemple, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadosnomemple_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "ApellidoPaterno:", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpleadosappaterno_Internalname, AV14empleadosappaterno, StringUtil.RTrim( context.localUtil.Format( AV14empleadosappaterno, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpleadosappaterno_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Empleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_2T2e( true) ;
         }
         else
         {
            wb_table2_10_2T2e( false) ;
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
         PA2T2( ) ;
         WS2T2( ) ;
         WE2T2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?583790");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215592351");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("catalog_de_empleados.js", "?2022215592351");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock_Internalname = "TEXTBLOCK";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtavNextvalue_Internalname = "vNEXTVALUE";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         dynavAreaareaid_Internalname = "vAREAAREAID";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtavEmpleadosnomemple_Internalname = "vEMPLEADOSNOMEMPLE";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         edtavEmpleadosappaterno_Internalname = "vEMPLEADOSAPPATERNO";
         tblTable2_Internalname = "TABLE2";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         edtavEmpleadosapmaterno_Internalname = "vEMPLEADOSAPMATERNO";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         edtavEmpleadosstatus_Internalname = "vEMPLEADOSSTATUS";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtavEmpleadoscorreo_Internalname = "vEMPLEADOSCORREO";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         edtavEmpleadosext_Internalname = "vEMPLEADOSEXT";
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
         edtavEmpleadosappaterno_Jsonclick = "";
         edtavEmpleadosnomemple_Jsonclick = "";
         dynavAreaareaid_Jsonclick = "";
         dynavAreaareaid.Enabled = 1;
         edtavNextvalue_Jsonclick = "";
         edtavNextvalue_Enabled = 1;
         edtavEmpleadosext_Jsonclick = "";
         edtavEmpleadoscorreo_Jsonclick = "";
         edtavEmpleadosstatus_Jsonclick = "";
         edtavEmpleadosapmaterno_Jsonclick = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Catalog_De_Empleados";
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
         setEventMetadata("'GUARDAR '","{handler:'E122T2',iparms:[{av:'AV13empleadosnomemple',fld:'vEMPLEADOSNOMEMPLE',pic:'',nv:''},{av:'AV14empleadosappaterno',fld:'vEMPLEADOSAPPATERNO',pic:'',nv:''},{av:'AV28areaareaid',fld:'vAREAAREAID',pic:'ZZZZZZZZ9',nv:0},{av:'AV15empleadosapmaterno',fld:'vEMPLEADOSAPMATERNO',pic:'',nv:''},{av:'AV16empleadosstatus',fld:'vEMPLEADOSSTATUS',pic:'',nv:''},{av:'AV18empleadoscorreo',fld:'vEMPLEADOSCORREO',pic:'',nv:''},{av:'AV19empleadosext',fld:'vEMPLEADOSEXT',pic:'',nv:''},{av:'AV11NextValue',fld:'vNEXTVALUE',pic:'ZZZ9',hsh:true,nv:0},{av:'AV24empleados',fld:'vEMPLEADOS',pic:'',nv:null},{av:'Gx_date',fld:'vTODAY',pic:'',nv:''}],oparms:[{av:'AV24empleados',fld:'vEMPLEADOS',pic:'',nv:null}]}");
         setEventMetadata("'CONSULTAR '","{handler:'E132T2',iparms:[],oparms:[]}");
         setEventMetadata("'CANCELAR'","{handler:'E142T2',iparms:[],oparms:[]}");
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
         AV24empleados = new Sdtempleados(context);
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
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H002T2_A22areaareaid = new int[1] ;
         H002T2_A27areadsc = new String[] {""} ;
         H002T2_n27areadsc = new bool[] {false} ;
         H002T4_A40000GXC1 = new int[1] ;
         AV13empleadosnomemple = "";
         AV14empleadosappaterno = "";
         AV15empleadosapmaterno = "";
         AV16empleadosstatus = "";
         AV18empleadoscorreo = "";
         AV19empleadosext = "";
         hsh = "";
         H002T6_A40000GXC1 = new int[1] ;
         AV8WebSession = context.GetSession();
         sStyleString = "";
         lblTextblock_Jsonclick = "";
         lblTextblock5_Jsonclick = "";
         TempTags = "";
         lblTextblock6_Jsonclick = "";
         lblTextblock7_Jsonclick = "";
         lblTextblock8_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         bttButton3_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.catalog_de_empleados__default(),
            new Object[][] {
                new Object[] {
               H002T2_A22areaareaid, H002T2_A27areadsc, H002T2_n27areadsc
               }
               , new Object[] {
               H002T4_A40000GXC1
               }
               , new Object[] {
               H002T6_A40000GXC1
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
      private short AV11NextValue ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A40000GXC1 ;
      private int gxdynajaxindex ;
      private int AV28areaareaid ;
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
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavAreaareaid_Internalname ;
      private String edtavEmpleadosnomemple_Internalname ;
      private String edtavEmpleadosappaterno_Internalname ;
      private String edtavEmpleadosapmaterno_Internalname ;
      private String edtavEmpleadosstatus_Internalname ;
      private String edtavEmpleadoscorreo_Internalname ;
      private String edtavEmpleadosext_Internalname ;
      private String hsh ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblTextblock_Internalname ;
      private String lblTextblock_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String TempTags ;
      private String edtavEmpleadosapmaterno_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavEmpleadosstatus_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavEmpleadoscorreo_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavEmpleadosext_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavNextvalue_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String dynavAreaareaid_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavEmpleadosnomemple_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavEmpleadosappaterno_Jsonclick ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV13empleadosnomemple ;
      private String AV14empleadosappaterno ;
      private String AV15empleadosapmaterno ;
      private String AV16empleadosstatus ;
      private String AV18empleadoscorreo ;
      private String AV19empleadosext ;
      private IGxSession AV8WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavAreaareaid ;
      private IDataStoreProvider pr_default ;
      private int[] H002T2_A22areaareaid ;
      private String[] H002T2_A27areadsc ;
      private bool[] H002T2_n27areadsc ;
      private int[] H002T4_A40000GXC1 ;
      private int[] H002T6_A40000GXC1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private Sdtempleados AV24empleados ;
   }

   public class catalog_de_empleados__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002T2 ;
          prmH002T2 = new Object[] {
          } ;
          Object[] prmH002T4 ;
          prmH002T4 = new Object[] {
          } ;
          Object[] prmH002T6 ;
          prmH002T6 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002T2", "SELECT areaid, areadsc FROM public.area ORDER BY areadsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002T2,0,0,true,false )
             ,new CursorDef("H002T4", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(empleadosid) AS GXC1 FROM public.empleados ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002T4,1,0,true,false )
             ,new CursorDef("H002T6", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(empleadosid) AS GXC1 FROM public.empleados ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002T6,1,0,true,false )
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
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 2 :
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
