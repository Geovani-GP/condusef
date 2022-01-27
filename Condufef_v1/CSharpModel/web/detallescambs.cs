/*
               File: DetallesCambs
        Description: Detalles Cambs
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:7:47.85
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
   public class detallescambs : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallescambs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallescambs( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Cambsgrid") == 0 )
            {
               nRC_GXsfl_11 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_11_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_11_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrCambsgrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Cambsgrid") == 0 )
            {
               A25cambsid = (int)(NumberUtil.Val( GetNextPar( ), "."));
               A83cambsdsc = GetNextPar( );
               n83cambsdsc = false;
               AV6buscar = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6buscar", AV6buscar);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrCambsgrid_refresh( A25cambsid, A83cambsdsc, AV6buscar) ;
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
         PA2E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2E2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221262074787");
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallescambs.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         }
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_11", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_11), 4, 0, ",", "")));
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
            WE2E2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2E2( ) ;
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
         return formatLink("detallescambs.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesCambs" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Cambs" ;
      }

      protected void WB2E0( )
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
            wb_table1_2_2E2( true) ;
         }
         else
         {
            wb_table1_2_2E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2E2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            CambsgridContainer.SetWrapped(nGXWrapped);
            if ( CambsgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"CambsgridContainer"+"DivS\" data-gxgridid=\"11\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subCambsgrid_Internalname, subCambsgrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subCambsgrid_Backcolorstyle == 0 )
               {
                  subCambsgrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subCambsgrid_Class) > 0 )
                  {
                     subCambsgrid_Linesclass = subCambsgrid_Class+"Title";
                  }
               }
               else
               {
                  subCambsgrid_Titlebackstyle = 1;
                  if ( subCambsgrid_Backcolorstyle == 1 )
                  {
                     subCambsgrid_Titlebackcolor = subCambsgrid_Allbackcolor;
                     if ( StringUtil.Len( subCambsgrid_Class) > 0 )
                     {
                        subCambsgrid_Linesclass = subCambsgrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subCambsgrid_Class) > 0 )
                     {
                        subCambsgrid_Linesclass = subCambsgrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subCambsgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subCambsgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "cambsdsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               CambsgridContainer.AddObjectProperty("GridName", "Cambsgrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  CambsgridContainer = new GXWebGrid( context);
               }
               else
               {
                  CambsgridContainer.Clear();
               }
               CambsgridContainer.SetWrapped(nGXWrapped);
               CambsgridContainer.AddObjectProperty("GridName", "Cambsgrid");
               CambsgridContainer.AddObjectProperty("Class", "Grid");
               CambsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Backcolorstyle), 1, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("CmpContext", "");
               CambsgridContainer.AddObjectProperty("InMasterPage", "false");
               CambsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               CambsgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ".", "")));
               CambsgridContainer.AddColumnProperties(CambsgridColumn);
               CambsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               CambsgridColumn.AddObjectProperty("Value", A83cambsdsc);
               CambsgridContainer.AddColumnProperties(CambsgridColumn);
               CambsgridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Allowselection), 1, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Selectioncolor), 9, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Allowhovering), 1, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Hoveringcolor), 9, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Allowcollapsing), 1, 0, ".", "")));
               CambsgridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 11 )
         {
            wbEnd = 0;
            nRC_GXsfl_11 = (short)(nGXsfl_11_idx-1);
            if ( CambsgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"CambsgridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Cambsgrid", CambsgridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "CambsgridContainerData", CambsgridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "CambsgridContainerData"+"V", CambsgridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"CambsgridContainerData"+"V"+"\" value='"+CambsgridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Cambs", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2E0( ) ;
      }

      protected void WS2E2( )
      {
         START2E2( ) ;
         EVT2E2( ) ;
      }

      protected void EVT2E2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'SEARCH'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
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
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "CAMBSGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "CAMBSGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                              SubsflControlProps_112( ) ;
                              A25cambsid = (int)(context.localUtil.CToN( cgiGet( edtcambsid_Internalname), ",", "."));
                              A83cambsdsc = cgiGet( edtcambsdsc_Internalname);
                              n83cambsdsc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "CAMBSGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112E2 */
                                    E112E2 ();
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                                 sEvtType = StringUtil.Right( sEvt, 4);
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                 if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "CAMBSGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                                 {
                                    nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                    sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                                    SubsflControlProps_112( ) ;
                                    A25cambsid = (int)(context.localUtil.CToN( cgiGet( edtcambsid_Internalname), ",", "."));
                                    A83cambsdsc = cgiGet( edtcambsdsc_Internalname);
                                    n83cambsdsc = false;
                                    sEvtType = StringUtil.Right( sEvt, 1);
                                    if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                    {
                                       sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                       if ( StringUtil.StrCmp(sEvt, "CAMBSGRID.LOAD") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                          /* Execute user event: E112E2 */
                                          E112E2 ();
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
                                       }
                                       else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                       }
                                       else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                       }
                                    }
                                    else
                                    {
                                    }
                                 }
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

      protected void WE2E2( )
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

      protected void PA2E2( )
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
               GX_FocusControl = edtavBuscar_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrCambsgrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_112( ) ;
         while ( nGXsfl_11_idx <= nRC_GXsfl_11 )
         {
            sendrow_112( ) ;
            nGXsfl_11_idx = (short)(((subCambsgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subCambsgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
            sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
            SubsflControlProps_112( ) ;
         }
         context.GX_webresponse.AddString(CambsgridContainer.ToJavascriptSource());
         /* End function gxnrCambsgrid_newrow */
      }

      protected void gxgrCambsgrid_refresh( int A25cambsid ,
                                            String A83cambsdsc ,
                                            String AV6buscar )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         CAMBSGRID_nCurrentRecord = 0;
         RF2E2( ) ;
         /* End function gxgrCambsgrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "CAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSDSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A83cambsdsc, ""))));
         GxWebStd.gx_hidden_field( context, "CAMBSDSC", A83cambsdsc);
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "CAMBSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSDSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A83cambsdsc, ""))));
         GxWebStd.gx_hidden_field( context, "CAMBSDSC", A83cambsdsc);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2E2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2E2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            CambsgridContainer.ClearRows();
         }
         wbStart = 11;
         nGXsfl_11_idx = 1;
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         nGXsfl_11_Refreshing = 1;
         CambsgridContainer.AddObjectProperty("GridName", "Cambsgrid");
         CambsgridContainer.AddObjectProperty("CmpContext", "");
         CambsgridContainer.AddObjectProperty("InMasterPage", "false");
         CambsgridContainer.AddObjectProperty("Class", "Grid");
         CambsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         CambsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         CambsgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subCambsgrid_Backcolorstyle), 1, 0, ".", "")));
         CambsgridContainer.PageSize = subCambsgrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_112( ) ;
            /* Using cursor H002E2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK2E2 = false;
               A83cambsdsc = H002E2_A83cambsdsc[0];
               n83cambsdsc = H002E2_n83cambsdsc[0];
               A25cambsid = H002E2_A25cambsid[0];
               /* Execute user event: E112E2 */
               E112E2 ();
               if ( ! BRK2E2 )
               {
                  BRK2E2 = true;
                  pr_default.readNext(0);
               }
            }
            wbEnd = 11;
            WB2E0( ) ;
         }
         nGXsfl_11_Refreshing = 0;
      }

      protected int subCambsgrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subCambsgrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subCambsgrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subCambsgrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP2E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_11 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_11"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E112E2( )
      {
         /* Cambsgrid_Load Routine */
         while ( (pr_default.getStatus(0) != 101) && ( H002E2_A25cambsid[0] == A25cambsid ) )
         {
            BRK2E2 = false;
            A83cambsdsc = H002E2_A83cambsdsc[0];
            n83cambsdsc = H002E2_n83cambsdsc[0];
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV6buscar)) || ( ( StringUtil.StrCmp(A83cambsdsc, AV6buscar) == 0 ) ) )
            {
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 11;
               }
               sendrow_112( ) ;
               if ( isFullAjaxMode( ) && ( nGXsfl_11_Refreshing == 0 ) )
               {
                  context.DoAjaxLoad(11, CambsgridRow);
               }
            }
            BRK2E2 = true;
            pr_default.readNext(0);
         }
      }

      protected void wb_table1_2_2E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(63), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(874), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:190px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_11_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV6buscar), StringUtil.RTrim( context.localUtil.Format( AV6buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_DetallesCambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:411px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(11), 2, 0)+","+"null"+");", "Search", bttButton1_Jsonclick, 5, "Search", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'SEARCH\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesCambs.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:657px")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2E2e( true) ;
         }
         else
         {
            wb_table1_2_2E2e( false) ;
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
         PA2E2( ) ;
         WS2E2( ) ;
         WE2E2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?2071072");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022126207484");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
            context.AddJavascriptSource("detallescambs.js", "?2022126207484");
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_112( )
      {
         edtcambsid_Internalname = "CAMBSID_"+sGXsfl_11_idx;
         edtcambsdsc_Internalname = "CAMBSDSC_"+sGXsfl_11_idx;
      }

      protected void SubsflControlProps_fel_112( )
      {
         edtcambsid_Internalname = "CAMBSID_"+sGXsfl_11_fel_idx;
         edtcambsdsc_Internalname = "CAMBSDSC_"+sGXsfl_11_fel_idx;
      }

      protected void sendrow_112( )
      {
         SubsflControlProps_112( ) ;
         WB2E0( ) ;
         CambsgridRow = GXWebRow.GetNew(context,CambsgridContainer);
         if ( subCambsgrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subCambsgrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subCambsgrid_Class, "") != 0 )
            {
               subCambsgrid_Linesclass = subCambsgrid_Class+"Odd";
            }
         }
         else if ( subCambsgrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subCambsgrid_Backstyle = 0;
            subCambsgrid_Backcolor = subCambsgrid_Allbackcolor;
            if ( StringUtil.StrCmp(subCambsgrid_Class, "") != 0 )
            {
               subCambsgrid_Linesclass = subCambsgrid_Class+"Uniform";
            }
         }
         else if ( subCambsgrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subCambsgrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subCambsgrid_Class, "") != 0 )
            {
               subCambsgrid_Linesclass = subCambsgrid_Class+"Odd";
            }
            subCambsgrid_Backcolor = (int)(0x0);
         }
         else if ( subCambsgrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subCambsgrid_Backstyle = 1;
            if ( ((int)((nGXsfl_11_idx) % (2))) == 0 )
            {
               subCambsgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subCambsgrid_Class, "") != 0 )
               {
                  subCambsgrid_Linesclass = subCambsgrid_Class+"Even";
               }
            }
            else
            {
               subCambsgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subCambsgrid_Class, "") != 0 )
               {
                  subCambsgrid_Linesclass = subCambsgrid_Class+"Odd";
               }
            }
         }
         if ( CambsgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subCambsgrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_11_idx+"\">") ;
         }
         /* Subfile cell */
         if ( CambsgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         CambsgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcambsid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25cambsid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcambsid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"left",(bool)false});
         /* Subfile cell */
         if ( CambsgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         CambsgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcambsdsc_Internalname,(String)A83cambsdsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcambsdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A25cambsid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_CAMBSDSC"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A83cambsdsc, ""))));
         CambsgridContainer.AddRow(CambsgridRow);
         nGXsfl_11_idx = (short)(((subCambsgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subCambsgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         /* End function sendrow_112 */
      }

      protected void init_default_properties( )
      {
         edtavBuscar_Internalname = "vBUSCAR";
         bttButton1_Internalname = "BUTTON1";
         tblTable1_Internalname = "TABLE1";
         edtcambsid_Internalname = "CAMBSID";
         edtcambsdsc_Internalname = "CAMBSDSC";
         Form.Internalname = "FORM";
         subCambsgrid_Internalname = "CAMBSGRID";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtcambsdsc_Jsonclick = "";
         edtcambsid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subCambsgrid_Allowcollapsing = 0;
         subCambsgrid_Allowselection = 0;
         subCambsgrid_Class = "Grid";
         subCambsgrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Cambs";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'CAMBSGRID_nFirstRecordOnPage',nv:0},{av:'CAMBSGRID_nEOF',nv:0},{av:'A25cambsid',fld:'CAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A83cambsdsc',fld:'CAMBSDSC',pic:'',hsh:true,nv:''},{av:'AV6buscar',fld:'vBUSCAR',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("CAMBSGRID.LOAD","{handler:'E112E2',iparms:[{av:'A25cambsid',fld:'CAMBSID',pic:'ZZZZZZZZ9',hsh:true,nv:0},{av:'A83cambsdsc',fld:'CAMBSDSC',pic:'',hsh:true,nv:''},{av:'AV6buscar',fld:'vBUSCAR',pic:'',nv:''}],oparms:[]}");
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
         pr_default.close(0);
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A83cambsdsc = "";
         AV6buscar = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         CambsgridContainer = new GXWebGrid( context);
         sStyleString = "";
         subCambsgrid_Linesclass = "";
         CambsgridColumn = new GXWebColumn();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H002E2_A83cambsdsc = new String[] {""} ;
         H002E2_n83cambsdsc = new bool[] {false} ;
         H002E2_A25cambsid = new int[1] ;
         CambsgridRow = new GXWebRow();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallescambs__default(),
            new Object[][] {
                new Object[] {
               H002E2_A83cambsdsc, H002E2_n83cambsdsc, H002E2_A25cambsid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRC_GXsfl_11 ;
      private short nGXsfl_11_idx=1 ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subCambsgrid_Backcolorstyle ;
      private short subCambsgrid_Titlebackstyle ;
      private short subCambsgrid_Allowselection ;
      private short subCambsgrid_Allowhovering ;
      private short subCambsgrid_Allowcollapsing ;
      private short subCambsgrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_11_Refreshing=0 ;
      private short subCambsgrid_Backstyle ;
      private short CAMBSGRID_nEOF ;
      private int A25cambsid ;
      private int subCambsgrid_Titlebackcolor ;
      private int subCambsgrid_Allbackcolor ;
      private int subCambsgrid_Selectioncolor ;
      private int subCambsgrid_Hoveringcolor ;
      private int subCambsgrid_Islastpage ;
      private int idxLst ;
      private int subCambsgrid_Backcolor ;
      private long CAMBSGRID_nCurrentRecord ;
      private long CAMBSGRID_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_11_idx="0001" ;
      private String AV6buscar ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sStyleString ;
      private String subCambsgrid_Internalname ;
      private String subCambsgrid_Class ;
      private String subCambsgrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtcambsid_Internalname ;
      private String edtcambsdsc_Internalname ;
      private String edtavBuscar_Internalname ;
      private String scmdbuf ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String edtavBuscar_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String sGXsfl_11_fel_idx="0001" ;
      private String ROClassString ;
      private String edtcambsid_Jsonclick ;
      private String edtcambsdsc_Jsonclick ;
      private bool entryPointCalled ;
      private bool n83cambsdsc ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool BRK2E2 ;
      private String A83cambsdsc ;
      private GXWebGrid CambsgridContainer ;
      private GXWebRow CambsgridRow ;
      private GXWebColumn CambsgridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002E2_A83cambsdsc ;
      private bool[] H002E2_n83cambsdsc ;
      private int[] H002E2_A25cambsid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallescambs__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002E2 ;
          prmH002E2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002E2", "SELECT cambsdsc, cambsid FROM public.cambs ORDER BY cambsid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E2,11,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
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
