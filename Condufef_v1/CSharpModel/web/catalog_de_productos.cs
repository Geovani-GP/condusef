/*
               File: Catalog_De_Productos
        Description: Catalog_De_Productos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:1.32
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
   public class catalog_de_productos : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public catalog_de_productos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public catalog_de_productos( IGxContext context )
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
         dynavCambsid = new GXCombobox();
         dynavMarcasid = new GXCombobox();
         dynavModelosid = new GXCombobox();
         dynavCategoriasid = new GXCombobox();
         dynavTipobienid = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCAMBSID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvCAMBSID2O2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vMARCASID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvMARCASID2O2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vMODELOSID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvMODELOSID2O2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCATEGORIASID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvCATEGORIASID2O2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vTIPOBIENID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvTIPOBIENID2O2( ) ;
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
         PA2O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022221343135");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("catalog_de_productos.aspx") +"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUCTO", AV7producto);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUCTO", AV7producto);
         }
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GXC1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40000GXC1), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Catalog_De_Productos";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("catalog_de_productos:[SendSecurityCheck value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9"));
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
            WE2O2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2O2( ) ;
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
         return formatLink("catalog_de_productos.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Catalog_De_Productos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Catalog_De_Productos" ;
      }

      protected void WB2O0( )
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
            context.WriteHtmlText( "<p>") ;
            wb_table1_4_2O2( true) ;
         }
         else
         {
            wb_table1_4_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table1_4_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Catalog_De_Productos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2O0( ) ;
      }

      protected void WS2O2( )
      {
         START2O2( ) ;
         EVT2O2( ) ;
      }

      protected void EVT2O2( )
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
                              /* Execute user event: E112O2 */
                              E112O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GUARDAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E122O2 */
                              E122O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E132O2 */
                              E132O2 ();
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

      protected void WE2O2( )
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

      protected void PA2O2( )
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
            dynavCambsid.Name = "vCAMBSID";
            dynavCambsid.WebTags = "";
            dynavMarcasid.Name = "vMARCASID";
            dynavMarcasid.WebTags = "";
            dynavModelosid.Name = "vMODELOSID";
            dynavModelosid.WebTags = "";
            dynavCategoriasid.Name = "vCATEGORIASID";
            dynavCategoriasid.WebTags = "";
            dynavTipobienid.Name = "vTIPOBIENID";
            dynavTipobienid.WebTags = "";
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

      protected void GXDLVvCAMBSID2O2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvCAMBSID_data2O2( ) ;
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

      protected void GXVvCAMBSID_html2O2( )
      {
         int gxdynajaxvalue ;
         GXDLVvCAMBSID_data2O2( ) ;
         gxdynajaxindex = 1;
         dynavCambsid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavCambsid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavCambsid.ItemCount > 0 )
         {
            AV14cambsid = (int)(NumberUtil.Val( dynavCambsid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0)));
         }
      }

      protected void GXDLVvCAMBSID_data2O2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona");
         /* Using cursor H002O2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002O2_A25cambsid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002O2_A83cambsdsc[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvMARCASID2O2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvMARCASID_data2O2( ) ;
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

      protected void GXVvMARCASID_html2O2( )
      {
         int gxdynajaxvalue ;
         GXDLVvMARCASID_data2O2( ) ;
         gxdynajaxindex = 1;
         dynavMarcasid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavMarcasid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavMarcasid.ItemCount > 0 )
         {
            AV15marcasid = (int)(NumberUtil.Val( dynavMarcasid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15marcasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0)));
         }
      }

      protected void GXDLVvMARCASID_data2O2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona..");
         /* Using cursor H002O3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002O3_A24marcasid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002O3_A112marcasdsc[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvMODELOSID2O2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvMODELOSID_data2O2( ) ;
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

      protected void GXVvMODELOSID_html2O2( )
      {
         int gxdynajaxvalue ;
         GXDLVvMODELOSID_data2O2( ) ;
         gxdynajaxindex = 1;
         dynavModelosid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavModelosid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavModelosid.ItemCount > 0 )
         {
            AV16modelosid = (int)(NumberUtil.Val( dynavModelosid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0)));
         }
      }

      protected void GXDLVvMODELOSID_data2O2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona");
         /* Using cursor H002O4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002O4_A15modelosid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002O4_A116modelosdsc[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVvCATEGORIASID2O2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvCATEGORIASID_data2O2( ) ;
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

      protected void GXVvCATEGORIASID_html2O2( )
      {
         int gxdynajaxvalue ;
         GXDLVvCATEGORIASID_data2O2( ) ;
         gxdynajaxindex = 1;
         dynavCategoriasid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavCategoriasid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavCategoriasid.ItemCount > 0 )
         {
            AV18categoriasid = (int)(NumberUtil.Val( dynavCategoriasid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18categoriasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0)));
         }
      }

      protected void GXDLVvCATEGORIASID_data2O2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona");
         /* Using cursor H002O5 */
         pr_default.execute(3);
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002O5_A14categoriasid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002O5_A94categoriasdsc[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVvTIPOBIENID2O2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvTIPOBIENID_data2O2( ) ;
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

      protected void GXVvTIPOBIENID_html2O2( )
      {
         int gxdynajaxvalue ;
         GXDLVvTIPOBIENID_data2O2( ) ;
         gxdynajaxindex = 1;
         dynavTipobienid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavTipobienid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
         if ( dynavTipobienid.ItemCount > 0 )
         {
            AV17tipobienid = (int)(NumberUtil.Val( dynavTipobienid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0)));
         }
      }

      protected void GXDLVvTIPOBIENID_data2O2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecciona");
         /* Using cursor H002O6 */
         pr_default.execute(4);
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002O6_A23tipobienid[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(H002O6_A139tipobiendsc[0]);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavCambsid.ItemCount > 0 )
         {
            AV14cambsid = (int)(NumberUtil.Val( dynavCambsid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0)));
         }
         if ( dynavMarcasid.ItemCount > 0 )
         {
            AV15marcasid = (int)(NumberUtil.Val( dynavMarcasid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15marcasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0)));
         }
         if ( dynavModelosid.ItemCount > 0 )
         {
            AV16modelosid = (int)(NumberUtil.Val( dynavModelosid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0)));
         }
         if ( dynavCategoriasid.ItemCount > 0 )
         {
            AV18categoriasid = (int)(NumberUtil.Val( dynavCategoriasid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18categoriasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0)));
         }
         if ( dynavTipobienid.ItemCount > 0 )
         {
            AV17tipobienid = (int)(NumberUtil.Val( dynavTipobienid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0)));
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2O2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
      }

      protected void RF2O2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E132O2 */
            E132O2 ();
            WB2O0( ) ;
         }
      }

      protected void STRUP2O0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         edtavNextvalue_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNextvalue_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNextvalue_Enabled), 5, 0)));
         GXVvCAMBSID_html2O2( ) ;
         GXVvMARCASID_html2O2( ) ;
         GXVvMODELOSID_html2O2( ) ;
         GXVvCATEGORIASID_html2O2( ) ;
         GXVvTIPOBIENID_html2O2( ) ;
         /* Using cursor H002O8 */
         pr_default.execute(5);
         if ( (pr_default.getStatus(5) != 101) )
         {
            A40000GXC1 = H002O8_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(5);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E112O2 */
         E112O2 ();
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
               AV20NextValue = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")));
            }
            else
            {
               AV20NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20NextValue), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")));
            }
            dynavCambsid.CurrentValue = cgiGet( dynavCambsid_Internalname);
            AV14cambsid = (int)(NumberUtil.Val( cgiGet( dynavCambsid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cambsid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0)));
            AV6productodsc = cgiGet( edtavProductodsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6productodsc", AV6productodsc);
            dynavMarcasid.CurrentValue = cgiGet( dynavMarcasid_Internalname);
            AV15marcasid = (int)(NumberUtil.Val( cgiGet( dynavMarcasid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15marcasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0)));
            dynavModelosid.CurrentValue = cgiGet( dynavModelosid_Internalname);
            AV16modelosid = (int)(NumberUtil.Val( cgiGet( dynavModelosid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16modelosid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0)));
            dynavCategoriasid.CurrentValue = cgiGet( dynavCategoriasid_Internalname);
            AV18categoriasid = (int)(NumberUtil.Val( cgiGet( dynavCategoriasid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18categoriasid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0)));
            dynavTipobienid.CurrentValue = cgiGet( dynavTipobienid_Internalname);
            AV17tipobienid = (int)(NumberUtil.Val( cgiGet( dynavTipobienid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17tipobienid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0)));
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "Catalog_De_Productos";
            AV20NextValue = (short)(context.localUtil.CToN( cgiGet( edtavNextvalue_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20NextValue), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("catalog_de_productos:[SecurityCheckFailed value for]"+"NextValue:"+context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9"));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
            GXVvCAMBSID_html2O2( ) ;
            GXVvMARCASID_html2O2( ) ;
            GXVvMODELOSID_html2O2( ) ;
            GXVvCATEGORIASID_html2O2( ) ;
            GXVvTIPOBIENID_html2O2( ) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E112O2 */
         E112O2 ();
         if (returnInSub) return;
      }

      protected void E112O2( )
      {
         /* Start Routine */
         /* Using cursor H002O10 */
         pr_default.execute(6);
         if ( (pr_default.getStatus(6) != 101) )
         {
            A40000GXC1 = H002O10_A40000GXC1[0];
         }
         else
         {
            A40000GXC1 = 0;
         }
         pr_default.close(6);
         AV20NextValue = (short)(A40000GXC1+1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NextValue", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20NextValue), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNEXTVALUE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")));
      }

      protected void E122O2( )
      {
         /* 'Guardar' Routine */
         if ( (0==AV14cambsid) || (0==AV15marcasid) || (0==AV16modelosid) || (0==AV18categoriasid) || (0==AV17tipobienid) || String.IsNullOrEmpty(StringUtil.RTrim( AV6productodsc)) )
         {
            GX_msglist.addItem("Debe seleccionar un elemento e ingresar una descripcion");
         }
         else
         {
            AV7producto.gxTpr_Productoid = AV20NextValue;
            AV7producto.gxTpr_Cambsid = AV14cambsid;
            AV7producto.gxTpr_Productodsc = AV6productodsc;
            AV7producto.gxTpr_Marcaid = AV15marcasid;
            AV7producto.gxTpr_Modeloid = AV16modelosid;
            AV7producto.gxTpr_Categoriaid = AV18categoriasid;
            AV7producto.gxTpr_Tipobienid = AV17tipobienid;
            AV7producto.gxTpr_Productousuario = AV8WebSession.Get("usuario");
            GXt_dtime1 = DateTimeUtil.ResetTime( Gx_date ) ;
            AV7producto.gxTpr_Productofecreg = GXt_dtime1;
            AV7producto.Save();
            if ( AV7producto.Success() )
            {
               context.CommitDataStores( "Catalog_De_Productos");
               context.wjLoc = formatLink("catalog_de_productos.aspx") ;
               context.wjLocDisableFrm = 1;
            }
            else
            {
               context.RollbackDataStores( "Catalog_De_Productos");
            }
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7producto", AV7producto);
      }

      protected void nextLoad( )
      {
      }

      protected void E132O2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_4_2O2( bool wbgen )
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
            context.WriteHtmlText( "<td>") ;
            wb_table2_7_2O2( true) ;
         }
         else
         {
            wb_table2_7_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table2_7_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_25_2O2( true) ;
         }
         else
         {
            wb_table3_25_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table3_25_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_4_2O2e( true) ;
         }
         else
         {
            wb_table1_4_2O2e( false) ;
         }
      }

      protected void wb_table3_25_2O2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "MARCA:", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:569px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavMarcasid, dynavMarcasid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0)), 1, dynavMarcasid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, 1, 0, 0, 197, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "", true, "HLP_Catalog_De_Productos.htm");
            dynavMarcasid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV15marcasid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavMarcasid_Internalname, "Values", (String)(dynavMarcasid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:131px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "PARTIDA PRESUPUESTAL", "", "", lblTextblock8_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "MODELO:", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavModelosid, dynavModelosid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0)), 1, dynavModelosid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, 1, 0, 0, 197, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "", true, "HLP_Catalog_De_Productos.htm");
            dynavModelosid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV16modelosid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavModelosid_Internalname, "Values", (String)(dynavModelosid.ToJavascriptSource()));
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
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "CATEGORÍAS:", "", "", lblTextblock6_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavCategoriasid, dynavCategoriasid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0)), 1, dynavCategoriasid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, 1, 0, 0, 197, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,47);\"", "", true, "HLP_Catalog_De_Productos.htm");
            dynavCategoriasid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18categoriasid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavCategoriasid_Internalname, "Values", (String)(dynavCategoriasid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "CONSULTAR", bttButton1_Jsonclick, 5, "CONSULTAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:24px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "TIPO BIEN:", "", "", lblTextblock7_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavTipobienid, dynavTipobienid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0)), 1, dynavTipobienid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, 1, 0, 0, 197, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "", true, "HLP_Catalog_De_Productos.htm");
            dynavTipobienid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17tipobienid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavTipobienid_Internalname, "Values", (String)(dynavTipobienid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#008000;";
            GxWebStd.gx_button_ctrl( context, bttGuardar_Internalname, "", "GUARDAR", bttGuardar_Jsonclick, 5, "GUARDAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GUARDAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "color:#FFFFFF; background-color:#FF0000;";
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "CANCELAR", bttButton3_Jsonclick, 5, "CANCELAR", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_25_2O2e( true) ;
         }
         else
         {
            wb_table3_25_2O2e( false) ;
         }
      }

      protected void wb_table2_7_2O2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "PRODUCTO:", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:333px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNextvalue_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20NextValue), 4, 0, ",", "")), ((edtavNextvalue_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")) : context.localUtil.Format( (decimal)(AV20NextValue), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,12);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNextvalue_Jsonclick, 0, "Attribute", "", "", "", 1, edtavNextvalue_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "CLAVE CAMBS:", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavCambsid, dynavCambsid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0)), 1, dynavCambsid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavCambsid.Enabled, 0, 0, 197, "px", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,17);\"", "", true, "HLP_Catalog_De_Productos.htm");
            dynavCambsid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14cambsid), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavCambsid_Internalname, "Values", (String)(dynavCambsid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "DESCRIPCION:", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProductodsc_Internalname, AV6productodsc, StringUtil.RTrim( context.localUtil.Format( AV6productodsc, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProductodsc_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Catalog_De_Productos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_7_2O2e( true) ;
         }
         else
         {
            wb_table2_7_2O2e( false) ;
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
         PA2O2( ) ;
         WS2O2( ) ;
         WE2O2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?1342847");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022221343175");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("catalog_de_productos.js", "?2022221343176");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtavNextvalue_Internalname = "vNEXTVALUE";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         dynavCambsid_Internalname = "vCAMBSID";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtavProductodsc_Internalname = "vPRODUCTODSC";
         tblTable2_Internalname = "TABLE2";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         dynavMarcasid_Internalname = "vMARCASID";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         dynavModelosid_Internalname = "vMODELOSID";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         dynavCategoriasid_Internalname = "vCATEGORIASID";
         bttButton1_Internalname = "BUTTON1";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         dynavTipobienid_Internalname = "vTIPOBIENID";
         bttGuardar_Internalname = "GUARDAR";
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
         edtavProductodsc_Jsonclick = "";
         dynavCambsid_Jsonclick = "";
         dynavCambsid.Enabled = 1;
         edtavNextvalue_Jsonclick = "";
         edtavNextvalue_Enabled = 1;
         dynavTipobienid_Jsonclick = "";
         dynavCategoriasid_Jsonclick = "";
         dynavModelosid_Jsonclick = "";
         dynavMarcasid_Jsonclick = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Catalog_De_Productos";
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
         setEventMetadata("'GUARDAR'","{handler:'E122O2',iparms:[{av:'AV14cambsid',fld:'vCAMBSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV15marcasid',fld:'vMARCASID',pic:'ZZZZZZZZ9',nv:0},{av:'AV16modelosid',fld:'vMODELOSID',pic:'ZZZZZZZZ9',nv:0},{av:'AV18categoriasid',fld:'vCATEGORIASID',pic:'ZZZZZZZZ9',nv:0},{av:'AV17tipobienid',fld:'vTIPOBIENID',pic:'ZZZZZZZZ9',nv:0},{av:'AV6productodsc',fld:'vPRODUCTODSC',pic:'',nv:''},{av:'AV20NextValue',fld:'vNEXTVALUE',pic:'ZZZ9',hsh:true,nv:0},{av:'AV7producto',fld:'vPRODUCTO',pic:'',nv:null},{av:'Gx_date',fld:'vTODAY',pic:'',nv:''}],oparms:[{av:'AV7producto',fld:'vPRODUCTO',pic:'',nv:null}]}");
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
         AV7producto = new Sdtproducto(context);
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
         H002O2_A25cambsid = new int[1] ;
         H002O2_A83cambsdsc = new String[] {""} ;
         H002O2_n83cambsdsc = new bool[] {false} ;
         H002O3_A24marcasid = new int[1] ;
         H002O3_A112marcasdsc = new String[] {""} ;
         H002O3_n112marcasdsc = new bool[] {false} ;
         H002O4_A15modelosid = new int[1] ;
         H002O4_A116modelosdsc = new String[] {""} ;
         H002O4_n116modelosdsc = new bool[] {false} ;
         H002O5_A14categoriasid = new int[1] ;
         H002O5_A94categoriasdsc = new String[] {""} ;
         H002O5_n94categoriasdsc = new bool[] {false} ;
         H002O6_A23tipobienid = new int[1] ;
         H002O6_A139tipobiendsc = new String[] {""} ;
         H002O6_n139tipobiendsc = new bool[] {false} ;
         H002O8_A40000GXC1 = new int[1] ;
         AV6productodsc = "";
         hsh = "";
         H002O10_A40000GXC1 = new int[1] ;
         AV8WebSession = context.GetSession();
         GXt_dtime1 = (DateTime)(DateTime.MinValue);
         sStyleString = "";
         lblTextblock4_Jsonclick = "";
         TempTags = "";
         lblTextblock8_Jsonclick = "";
         lblTextblock5_Jsonclick = "";
         lblTextblock6_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         lblTextblock7_Jsonclick = "";
         bttGuardar_Jsonclick = "";
         bttButton3_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.catalog_de_productos__default(),
            new Object[][] {
                new Object[] {
               H002O2_A25cambsid, H002O2_A83cambsdsc, H002O2_n83cambsdsc
               }
               , new Object[] {
               H002O3_A24marcasid, H002O3_A112marcasdsc, H002O3_n112marcasdsc
               }
               , new Object[] {
               H002O4_A15modelosid, H002O4_A116modelosdsc, H002O4_n116modelosdsc
               }
               , new Object[] {
               H002O5_A14categoriasid, H002O5_A94categoriasdsc, H002O5_n94categoriasdsc
               }
               , new Object[] {
               H002O6_A23tipobienid, H002O6_A139tipobiendsc, H002O6_n139tipobiendsc
               }
               , new Object[] {
               H002O8_A40000GXC1
               }
               , new Object[] {
               H002O10_A40000GXC1
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
      private short AV20NextValue ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A40000GXC1 ;
      private int gxdynajaxindex ;
      private int AV14cambsid ;
      private int AV15marcasid ;
      private int AV16modelosid ;
      private int AV18categoriasid ;
      private int AV17tipobienid ;
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
      private String dynavCambsid_Internalname ;
      private String edtavProductodsc_Internalname ;
      private String dynavMarcasid_Internalname ;
      private String dynavModelosid_Internalname ;
      private String dynavCategoriasid_Internalname ;
      private String dynavTipobienid_Internalname ;
      private String hsh ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String TempTags ;
      private String dynavMarcasid_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String dynavModelosid_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String dynavCategoriasid_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String dynavTipobienid_Jsonclick ;
      private String bttGuardar_Internalname ;
      private String bttGuardar_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavNextvalue_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String dynavCambsid_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavProductodsc_Jsonclick ;
      private DateTime GXt_dtime1 ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6productodsc ;
      private IGxSession AV8WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavCambsid ;
      private GXCombobox dynavMarcasid ;
      private GXCombobox dynavModelosid ;
      private GXCombobox dynavCategoriasid ;
      private GXCombobox dynavTipobienid ;
      private IDataStoreProvider pr_default ;
      private int[] H002O2_A25cambsid ;
      private String[] H002O2_A83cambsdsc ;
      private bool[] H002O2_n83cambsdsc ;
      private int[] H002O3_A24marcasid ;
      private String[] H002O3_A112marcasdsc ;
      private bool[] H002O3_n112marcasdsc ;
      private int[] H002O4_A15modelosid ;
      private String[] H002O4_A116modelosdsc ;
      private bool[] H002O4_n116modelosdsc ;
      private int[] H002O5_A14categoriasid ;
      private String[] H002O5_A94categoriasdsc ;
      private bool[] H002O5_n94categoriasdsc ;
      private int[] H002O6_A23tipobienid ;
      private String[] H002O6_A139tipobiendsc ;
      private bool[] H002O6_n139tipobiendsc ;
      private int[] H002O8_A40000GXC1 ;
      private int[] H002O10_A40000GXC1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private Sdtproducto AV7producto ;
   }

   public class catalog_de_productos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002O2 ;
          prmH002O2 = new Object[] {
          } ;
          Object[] prmH002O3 ;
          prmH002O3 = new Object[] {
          } ;
          Object[] prmH002O4 ;
          prmH002O4 = new Object[] {
          } ;
          Object[] prmH002O5 ;
          prmH002O5 = new Object[] {
          } ;
          Object[] prmH002O6 ;
          prmH002O6 = new Object[] {
          } ;
          Object[] prmH002O8 ;
          prmH002O8 = new Object[] {
          } ;
          Object[] prmH002O10 ;
          prmH002O10 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002O2", "SELECT cambsid, cambsdsc FROM public.cambs ORDER BY cambsdsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O2,0,0,true,false )
             ,new CursorDef("H002O3", "SELECT marcasid, marcasdsc FROM public.marcas ORDER BY marcasdsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O3,0,0,true,false )
             ,new CursorDef("H002O4", "SELECT modelosid, modelosdsc FROM public.modelos ORDER BY modelosdsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O4,0,0,true,false )
             ,new CursorDef("H002O5", "SELECT categoriasid, categoriasdsc FROM public.categorias ORDER BY categoriasdsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O5,0,0,true,false )
             ,new CursorDef("H002O6", "SELECT tipobienid, tipobiendsc FROM public.tipobien ORDER BY tipobiendsc ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O6,0,0,true,false )
             ,new CursorDef("H002O8", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(productoid) AS GXC1 FROM producto ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O8,1,0,true,false )
             ,new CursorDef("H002O10", "SELECT COALESCE( T1.GXC1, 0) AS GXC1 FROM (SELECT MAX(productoid) AS GXC1 FROM producto ) T1 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O10,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 6 :
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
