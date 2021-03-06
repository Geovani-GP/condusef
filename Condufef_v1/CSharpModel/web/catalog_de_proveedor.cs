/*
               File: Catalog_De_Proveedor
        Description: Catalog_De_Proveedor
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:34.69
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
   public class catalog_de_proveedor : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public catalog_de_proveedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public catalog_de_proveedor( IGxContext context )
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
         dynavEstadoid = new GXCombobox();
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
         PA2Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2Q2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20223310193471");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("catalog_de_proveedor.aspx") +"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPROVEEDORES", AV11proveedores);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPROVEEDORES", AV11proveedores);
         }
         GxWebStd.gx_hidden_field( context, "vPROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10proveedoresid), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GXC1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40000GXC1), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Catalog_De_Proveedor";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("catalog_de_proveedor:[SendSecurityCheck value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9"));
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
            WE2Q2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2Q2( ) ;
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
         return formatLink("catalog_de_proveedor.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Catalog_De_Proveedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Catalog_De_Proveedor" ;
      }

      protected void WB2Q0( )
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
            wb_table1_4_2Q2( true) ;
         }
         else
         {
            wb_table1_4_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_4_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Catalog_De_Proveedor", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2Q0( ) ;
      }

      protected void WS2Q2( )
      {
         START2Q2( ) ;
         EVT2Q2( ) ;
      }

      protected void EVT2Q2( )
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
                              /* Execute user event: E112Q2 */
                              E112Q2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GUARDAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E122Q2 */
                              E122Q2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E132Q2 */
                              E132Q2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONSULTAR '") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E142Q2 */
                              E142Q2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E152Q2 */
                              E152Q2 ();
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

      protected void WE2Q2( )
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

      protected void PA2Q2( )
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
            dynavEstadoid.Name = "vESTADOID";
            dynavEstadoid.WebTags = "";
            dynavEstadoid.removeAllItems();
            /* Using cursor H002Q2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               dynavEstadoid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H002Q2_A177estadoid[0]), 4, 0)), H002Q2_A178estado[0], 0);
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( dynavEstadoid.ItemCount > 0 )
            {
               AV24estadoid = (short)(NumberUtil.Val( dynavEstadoid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24estadoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0)));
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

      protected void GXDLVvESTADOID2Q1( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvESTADOID_data2Q1( ) ;
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

      protected void GXVvESTADOID_html2Q1( )
      {
         short gxdynajaxvalue ;
         GXDLVvESTADOID_data2Q1( ) ;
         gxdynajaxindex = 1;
         dynavEstadoid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavEstadoid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavEstadoid.ItemCount > 0 )
         {
            AV24estadoid = (short)(NumberUtil.Val( dynavEstadoid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24estadoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0)));
         }
      }

      protected void GXDLVvESTADOID_data2Q1( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H002Q3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002Q3_A177estadoid[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002Q3_A178estado[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavEstadoid.ItemCount > 0 )
         {
            AV24estadoid = (short)(NumberUtil.Val( dynavEstadoid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24estadoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0)));
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2Q2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
      }

      protected void RF2Q2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E152Q2 */
            E152Q2 ();
            WB2Q0( ) ;
         }
      }

      protected void STRUP2Q0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
         /* Using cursor H002Q5 */
         pr_default.execute(2);
         if ( (pr_default.getStatus(2) != 101) )
         {
            A40000GXC1 = H002Q5_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(2);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E112Q2 */
         E112Q2 ();
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
               AV12NextValue = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")));
            }
            else
            {
               AV12NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")));
            }
            AV9proveedoresnombre = cgiGet( edtavProveedoresnombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9proveedoresnombre", AV9proveedoresnombre);
            AV13proveedoresrfc = cgiGet( edtavProveedoresrfc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13proveedoresrfc", AV13proveedoresrfc);
            AV14proveedoresdireccion = cgiGet( edtavProveedoresdireccion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14proveedoresdireccion", AV14proveedoresdireccion);
            AV15proveedorescolonia = cgiGet( edtavProveedorescolonia_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15proveedorescolonia", AV15proveedorescolonia);
            AV20proveedorescodigopostal = cgiGet( edtavProveedorescodigopostal_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20proveedorescodigopostal", AV20proveedorescodigopostal);
            AV16proveedoresmunicipio = cgiGet( edtavProveedoresmunicipio_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16proveedoresmunicipio", AV16proveedoresmunicipio);
            dynavEstadoid.CurrentValue = cgiGet( dynavEstadoid_Internalname);
            AV24estadoid = (short)(NumberUtil.Val( cgiGet( dynavEstadoid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24estadoid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0)));
            AV17proveedoresfax = cgiGet( edtavProveedoresfax_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17proveedoresfax", AV17proveedoresfax);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavProveedorestelefono1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavProveedorestelefono1_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPROVEEDORESTELEFONO1");
               GX_FocusControl = edtavProveedorestelefono1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18proveedorestelefono1 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18proveedorestelefono1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18proveedorestelefono1), 10, 0)));
            }
            else
            {
               AV18proveedorestelefono1 = (long)(context.localUtil.CToN( cgiGet( edtavProveedorestelefono1_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18proveedorestelefono1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18proveedorestelefono1), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavProveedorestelefono2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavProveedorestelefono2_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPROVEEDORESTELEFONO2");
               GX_FocusControl = edtavProveedorestelefono2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19proveedorestelefono2 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19proveedorestelefono2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19proveedorestelefono2), 10, 0)));
            }
            else
            {
               AV19proveedorestelefono2 = (long)(context.localUtil.CToN( cgiGet( edtavProveedorestelefono2_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19proveedorestelefono2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19proveedorestelefono2), 10, 0)));
            }
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "Catalog_De_Proveedor";
            AV12NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12NextValue), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("catalog_de_proveedor:[SecurityCheckFailed value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9"));
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
         /* Execute user event: E112Q2 */
         E112Q2 ();
         if (returnInSub) return;
      }

      protected void E112Q2( )
      {
         /* Start Routine */
         /* Using cursor H002Q7 */
         pr_default.execute(3);
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40000GXC1 = H002Q7_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(3);
         AV12NextValue = (short)(A40000GXC1+1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12NextValue), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")));
      }

      protected void E122Q2( )
      {
         /* 'Guardar ' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV9proveedoresnombre)) || (0==AV24estadoid) || String.IsNullOrEmpty(StringUtil.RTrim( AV13proveedoresrfc)) || String.IsNullOrEmpty(StringUtil.RTrim( AV14proveedoresdireccion)) || String.IsNullOrEmpty(StringUtil.RTrim( AV15proveedorescolonia)) || String.IsNullOrEmpty(StringUtil.RTrim( AV20proveedorescodigopostal)) || String.IsNullOrEmpty(StringUtil.RTrim( AV16proveedoresmunicipio)) || String.IsNullOrEmpty(StringUtil.RTrim( AV17proveedoresfax)) || (0==AV18proveedorestelefono1) || (0==AV19proveedorestelefono2) )
         {
            GX_msglist.addItem("Los campos estan vacios");
         }
         else
         {
            AV11proveedores.gxTpr_Proveedoresid = AV12NextValue;
            AV11proveedores.gxTpr_Proveedoresnombre = AV9proveedoresnombre;
            AV11proveedores.gxTpr_Proveedoresrfc = AV13proveedoresrfc;
            AV11proveedores.gxTpr_Proveedoresdireccion = AV14proveedoresdireccion;
            AV11proveedores.gxTpr_Proveedorescolonia = AV15proveedorescolonia;
            AV11proveedores.gxTpr_Proveedorescodigopostal = AV20proveedorescodigopostal;
            AV11proveedores.gxTpr_Proveedoresmunicipio = AV16proveedoresmunicipio;
            AV11proveedores.gxTpr_Proveedorestado = StringUtil.Str( (decimal)(AV10proveedoresid), 9, 0);
            AV11proveedores.gxTpr_Proveedoresfax = AV17proveedoresfax;
            AV11proveedores.gxTpr_Proveedorestelefono1 = AV18proveedorestelefono1;
            AV11proveedores.gxTpr_Proveedorestelefono2 = AV19proveedorestelefono2;
            AV11proveedores.gxTpr_Proveedoresfecreg = Gx_date;
            AV11proveedores.gxTpr_Proveedoresusuario = AV8WebSession.Get("usuario");
            AV11proveedores.Save();
            if ( AV11proveedores.Success() )
            {
               context.CommitDataStores( "Catalog_De_Proveedor");
               context.wjLoc = formatLink("catalog_de_proveedor.aspx") ;
               context.wjLocDisableFrm = 1;
            }
            else
            {
               context.RollbackDataStores( "Catalog_De_Proveedor");
            }
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11proveedores", AV11proveedores);
      }

      protected void E132Q2( )
      {
         /* 'Cancelar' Routine */
         context.wjLoc = formatLink("menuprincipal.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void E142Q2( )
      {
         /* 'Consultar ' Routine */
         context.wjLoc = formatLink("detallesproveedores.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void nextLoad( )
      {
      }

      protected void E152Q2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_4_2Q2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock_Internalname, "CAT?LOGO DE PROVEEDOR", "", "", lblTextblock_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:15.0pt; font-weight:bold; font-style:normal; color:#000000;", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_10_2Q2( true) ;
         }
         else
         {
            wb_table2_10_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_48_2Q2( true) ;
         }
         else
         {
            wb_table3_48_2Q2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_4_2Q2e( true) ;
         }
         else
         {
            wb_table1_4_2Q2e( false) ;
         }
      }

      protected void wb_table3_48_2Q2( bool wbgen )
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
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Estado:", "", "", lblTextblock8_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:569px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavEstadoid, dynavEstadoid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0)), 1, dynavEstadoid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, 1, 0, 0, 250, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", "", true, "HLP_Catalog_De_Proveedor.htm");
            dynavEstadoid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24estadoid), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavEstadoid_Internalname, "Values", (String)(dynavEstadoid.ToJavascriptSource()));
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
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Fax:", "", "", lblTextblock9_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedoresfax_Internalname, AV17proveedoresfax, StringUtil.RTrim( context.localUtil.Format( AV17proveedoresfax, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedoresfax_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Tel?fono1:", "", "", lblTextblock10_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedorestelefono1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18proveedorestelefono1), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18proveedorestelefono1), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedorestelefono1_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "CONSULTAR", bttButton1_Jsonclick, 5, "CONSULTAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CONSULTAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:24px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Tel?fono:", "", "", lblTextblock11_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedorestelefono2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19proveedorestelefono2), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19proveedorestelefono2), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedorestelefono2_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "GUARDAR", bttButton2_Jsonclick, 5, "GUARDAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GUARDAR \\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#FF0000;";
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "CANCELAR", bttButton3_Jsonclick, 5, "CANCELAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CANCELAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2Q2e( true) ;
         }
         else
         {
            wb_table3_48_2Q2e( false) ;
         }
      }

      protected void wb_table2_10_2Q2( bool wbgen )
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
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:136px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Proveedor:", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:333px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNextvalue_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12NextValue), 4, 0, ",", "")), ((edtavNextvalue_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")) : context.localUtil.Format( (decimal)(AV12NextValue), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,15);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNextvalue_Jsonclick, 0, "Attribute", "", "", "", 1, edtavNextvalue_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Nombre:", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedoresnombre_Internalname, AV9proveedoresnombre, StringUtil.RTrim( context.localUtil.Format( AV9proveedoresnombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedoresnombre_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "RFC:", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedoresrfc_Internalname, AV13proveedoresrfc, StringUtil.RTrim( context.localUtil.Format( AV13proveedoresrfc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedoresrfc_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Direcci?n:", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedoresdireccion_Internalname, AV14proveedoresdireccion, StringUtil.RTrim( context.localUtil.Format( AV14proveedoresdireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedoresdireccion_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Colonia:", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedorescolonia_Internalname, AV15proveedorescolonia, StringUtil.RTrim( context.localUtil.Format( AV15proveedorescolonia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedorescolonia_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 25, "chr", 1, "row", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "C?digo Postal:", "", "", lblTextblock6_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedorescodigopostal_Internalname, AV20proveedorescodigopostal, StringUtil.RTrim( context.localUtil.Format( AV20proveedorescodigopostal, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedorescodigopostal_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Municipio:", "", "", lblTextblock7_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProveedoresmunicipio_Internalname, AV16proveedoresmunicipio, StringUtil.RTrim( context.localUtil.Format( AV16proveedoresmunicipio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProveedoresmunicipio_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 25, "chr", 1, "row", 25, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Proveedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_2Q2e( true) ;
         }
         else
         {
            wb_table2_10_2Q2e( false) ;
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
         PA2Q2( ) ;
         WS2Q2( ) ;
         WE2Q2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?0185564");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20223310193497");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("catalog_de_proveedor.js", "?20223310193497");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock_Internalname = "TEXTBLOCK";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtavNextvalue_Internalname = "vNEXTVALUE";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         edtavProveedoresnombre_Internalname = "vPROVEEDORESNOMBRE";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtavProveedoresrfc_Internalname = "vPROVEEDORESRFC";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         edtavProveedoresdireccion_Internalname = "vPROVEEDORESDIRECCION";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         edtavProveedorescolonia_Internalname = "vPROVEEDORESCOLONIA";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         edtavProveedorescodigopostal_Internalname = "vPROVEEDORESCODIGOPOSTAL";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtavProveedoresmunicipio_Internalname = "vPROVEEDORESMUNICIPIO";
         tblTable2_Internalname = "TABLE2";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         dynavEstadoid_Internalname = "vESTADOID";
         lblTextblock9_Internalname = "TEXTBLOCK9";
         edtavProveedoresfax_Internalname = "vPROVEEDORESFAX";
         lblTextblock10_Internalname = "TEXTBLOCK10";
         edtavProveedorestelefono1_Internalname = "vPROVEEDORESTELEFONO1";
         bttButton1_Internalname = "BUTTON1";
         lblTextblock11_Internalname = "TEXTBLOCK11";
         edtavProveedorestelefono2_Internalname = "vPROVEEDORESTELEFONO2";
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
         edtavProveedoresmunicipio_Jsonclick = "";
         edtavProveedorescodigopostal_Jsonclick = "";
         edtavProveedorescolonia_Jsonclick = "";
         edtavProveedoresdireccion_Jsonclick = "";
         edtavProveedoresrfc_Jsonclick = "";
         edtavProveedoresnombre_Jsonclick = "";
         edtavNextvalue_Jsonclick = "";
         edtavNextvalue_Enabled = 1;
         edtavProveedorestelefono2_Jsonclick = "";
         edtavProveedorestelefono1_Jsonclick = "";
         edtavProveedoresfax_Jsonclick = "";
         dynavEstadoid_Jsonclick = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Catalog_De_Proveedor";
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
         setEventMetadata("'GUARDAR '","{handler:'E122Q2',iparms:[{av:'AV9proveedoresnombre',fld:'vPROVEEDORESNOMBRE',pic:'',nv:''},{av:'AV24estadoid',fld:'vESTADOID',pic:'ZZZ9',nv:0},{av:'AV13proveedoresrfc',fld:'vPROVEEDORESRFC',pic:'',nv:''},{av:'AV14proveedoresdireccion',fld:'vPROVEEDORESDIRECCION',pic:'',nv:''},{av:'AV15proveedorescolonia',fld:'vPROVEEDORESCOLONIA',pic:'',nv:''},{av:'AV20proveedorescodigopostal',fld:'vPROVEEDORESCODIGOPOSTAL',pic:'',nv:''},{av:'AV16proveedoresmunicipio',fld:'vPROVEEDORESMUNICIPIO',pic:'',nv:''},{av:'AV17proveedoresfax',fld:'vPROVEEDORESFAX',pic:'',nv:''},{av:'AV18proveedorestelefono1',fld:'vPROVEEDORESTELEFONO1',pic:'ZZZZZZZZZ9',nv:0},{av:'AV19proveedorestelefono2',fld:'vPROVEEDORESTELEFONO2',pic:'ZZZZZZZZZ9',nv:0},{av:'AV12NextValue',fld:'vNEXTVALUE',pic:'ZZZ9',hsh:true,nv:0},{av:'AV11proveedores',fld:'vPROVEEDORES',pic:'',nv:null},{av:'AV10proveedoresid',fld:'vPROVEEDORESID',pic:'ZZZZZZZZ9',nv:0},{av:'Gx_date',fld:'vTODAY',pic:'',nv:''}],oparms:[{av:'AV11proveedores',fld:'vPROVEEDORES',pic:'',nv:null}]}");
         setEventMetadata("'CANCELAR'","{handler:'E132Q2',iparms:[],oparms:[]}");
         setEventMetadata("'CONSULTAR '","{handler:'E142Q2',iparms:[],oparms:[]}");
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
         AV11proveedores = new Sdtproveedores(context);
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
         H002Q2_A177estadoid = new short[1] ;
         H002Q2_A178estado = new String[] {""} ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         H002Q3_A177estadoid = new short[1] ;
         H002Q3_A178estado = new String[] {""} ;
         H002Q5_A40000GXC1 = new int[1] ;
         AV9proveedoresnombre = "";
         AV13proveedoresrfc = "";
         AV14proveedoresdireccion = "";
         AV15proveedorescolonia = "";
         AV20proveedorescodigopostal = "";
         AV16proveedoresmunicipio = "";
         AV17proveedoresfax = "";
         hsh = "";
         H002Q7_A40000GXC1 = new int[1] ;
         AV8WebSession = context.GetSession();
         sStyleString = "";
         lblTextblock_Jsonclick = "";
         lblTextblock8_Jsonclick = "";
         TempTags = "";
         lblTextblock9_Jsonclick = "";
         lblTextblock10_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         lblTextblock11_Jsonclick = "";
         bttButton2_Jsonclick = "";
         bttButton3_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         lblTextblock5_Jsonclick = "";
         lblTextblock6_Jsonclick = "";
         lblTextblock7_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.catalog_de_proveedor__default(),
            new Object[][] {
                new Object[] {
               H002Q2_A177estadoid, H002Q2_A178estado
               }
               , new Object[] {
               H002Q3_A177estadoid, H002Q3_A178estado
               }
               , new Object[] {
               H002Q5_A40000GXC1
               }
               , new Object[] {
               H002Q7_A40000GXC1
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
      private short AV12NextValue ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV24estadoid ;
      private short nGXWrapped ;
      private int AV10proveedoresid ;
      private int A40000GXC1 ;
      private int gxdynajaxindex ;
      private int edtavNextvalue_Enabled ;
      private int idxLst ;
      private long AV18proveedorestelefono1 ;
      private long AV19proveedorestelefono2 ;
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
      private String scmdbuf ;
      private String edtavNextvalue_Internalname ;
      private String gxwrpcisep ;
      private String edtavProveedoresnombre_Internalname ;
      private String edtavProveedoresrfc_Internalname ;
      private String edtavProveedoresdireccion_Internalname ;
      private String edtavProveedorescolonia_Internalname ;
      private String edtavProveedorescodigopostal_Internalname ;
      private String edtavProveedoresmunicipio_Internalname ;
      private String dynavEstadoid_Internalname ;
      private String edtavProveedoresfax_Internalname ;
      private String edtavProveedorestelefono1_Internalname ;
      private String edtavProveedorestelefono2_Internalname ;
      private String hsh ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblTextblock_Internalname ;
      private String lblTextblock_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String TempTags ;
      private String dynavEstadoid_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavProveedoresfax_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavProveedorestelefono1_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavProveedorestelefono2_Jsonclick ;
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
      private String edtavProveedoresnombre_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavProveedoresrfc_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavProveedoresdireccion_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavProveedorescolonia_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavProveedorescodigopostal_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavProveedoresmunicipio_Jsonclick ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV9proveedoresnombre ;
      private String AV13proveedoresrfc ;
      private String AV14proveedoresdireccion ;
      private String AV15proveedorescolonia ;
      private String AV20proveedorescodigopostal ;
      private String AV16proveedoresmunicipio ;
      private String AV17proveedoresfax ;
      private IGxSession AV8WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavEstadoid ;
      private IDataStoreProvider pr_default ;
      private short[] H002Q2_A177estadoid ;
      private String[] H002Q2_A178estado ;
      private short[] H002Q3_A177estadoid ;
      private String[] H002Q3_A178estado ;
      private int[] H002Q5_A40000GXC1 ;
      private int[] H002Q7_A40000GXC1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private Sdtproveedores AV11proveedores ;
   }

   public class catalog_de_proveedor__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002Q2 ;
          prmH002Q2 = new Object[] {
          } ;
          Object[] prmH002Q3 ;
          prmH002Q3 = new Object[] {
          } ;
          Object[] prmH002Q5 ;
          prmH002Q5 = new Object[] {
          } ;
          Object[] prmH002Q7 ;
          prmH002Q7 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002Q2", "SELECT estadoid, estado FROM estados ORDER BY estado ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q2,0,0,true,false )
             ,new CursorDef("H002Q3", "SELECT estadoid, estado FROM estados ORDER BY estado ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q3,0,0,true,false )
             ,new CursorDef("H002Q5", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(proveedoresid) AS GXC1 FROM public.proveedores ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q5,1,0,true,false )
             ,new CursorDef("H002Q7", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(proveedoresid) AS GXC1 FROM public.proveedores ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Q7,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
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
