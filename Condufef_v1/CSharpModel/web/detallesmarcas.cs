/*
               File: DetallesMarcas
        Description: Detalles Marcas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:20.76
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
   public class detallesmarcas : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallesmarcas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallesmarcas( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Marcagrid") == 0 )
            {
               nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_12_idx = GetNextPar( );
               AV6updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6updateImage))));
               AV7deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrMarcagrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Marcagrid") == 0 )
            {
               AV5buscar = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
               AV6updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6updateImage))));
               AV7deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrMarcagrid_refresh( AV5buscar, AV6updateImage, AV7deleteImage) ;
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
         PA2K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215592078");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallesmarcas.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vBUSCAR", StringUtil.RTrim( AV5buscar));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ",", "")));
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
            WE2K2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2K2( ) ;
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
         return formatLink("detallesmarcas.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesMarcas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Marcas" ;
      }

      protected void WB2K0( )
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
            wb_table1_2_2K2( true) ;
         }
         else
         {
            wb_table1_2_2K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2K2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            MarcagridContainer.SetWrapped(nGXWrapped);
            if ( MarcagridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"MarcagridContainer"+"DivS\" data-gxgridid=\"12\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subMarcagrid_Internalname, subMarcagrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subMarcagrid_Backcolorstyle == 0 )
               {
                  subMarcagrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subMarcagrid_Class) > 0 )
                  {
                     subMarcagrid_Linesclass = subMarcagrid_Class+"Title";
                  }
               }
               else
               {
                  subMarcagrid_Titlebackstyle = 1;
                  if ( subMarcagrid_Backcolorstyle == 1 )
                  {
                     subMarcagrid_Titlebackcolor = subMarcagrid_Allbackcolor;
                     if ( StringUtil.Len( subMarcagrid_Class) > 0 )
                     {
                        subMarcagrid_Linesclass = subMarcagrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subMarcagrid_Class) > 0 )
                     {
                        subMarcagrid_Linesclass = subMarcagrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subMarcagrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "marcasid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subMarcagrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "marcasdsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subMarcagrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "update Image") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subMarcagrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "delete Image") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               MarcagridContainer.AddObjectProperty("GridName", "Marcagrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  MarcagridContainer = new GXWebGrid( context);
               }
               else
               {
                  MarcagridContainer.Clear();
               }
               MarcagridContainer.SetWrapped(nGXWrapped);
               MarcagridContainer.AddObjectProperty("GridName", "Marcagrid");
               MarcagridContainer.AddObjectProperty("Class", "Grid");
               MarcagridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Backcolorstyle), 1, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("CmpContext", "");
               MarcagridContainer.AddObjectProperty("InMasterPage", "false");
               MarcagridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               MarcagridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24marcasid), 9, 0, ".", "")));
               MarcagridContainer.AddColumnProperties(MarcagridColumn);
               MarcagridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               MarcagridColumn.AddObjectProperty("Value", A112marcasdsc);
               MarcagridContainer.AddColumnProperties(MarcagridColumn);
               MarcagridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               MarcagridColumn.AddObjectProperty("Value", context.convertURL( AV6updateImage));
               MarcagridContainer.AddColumnProperties(MarcagridColumn);
               MarcagridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               MarcagridColumn.AddObjectProperty("Value", context.convertURL( AV7deleteImage));
               MarcagridContainer.AddColumnProperties(MarcagridColumn);
               MarcagridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Allowselection), 1, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Selectioncolor), 9, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Allowhovering), 1, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Hoveringcolor), 9, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Allowcollapsing), 1, 0, ".", "")));
               MarcagridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
            if ( MarcagridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"MarcagridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Marcagrid", MarcagridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "MarcagridContainerData", MarcagridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "MarcagridContainerData"+"V", MarcagridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"MarcagridContainerData"+"V"+"\" value='"+MarcagridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Marcas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2K0( ) ;
      }

      protected void WS2K2( )
      {
         START2K2( ) ;
         EVT2K2( ) ;
      }

      protected void EVT2K2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 /* Set Refresh If Buscar Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vBUSCAR"), AV5buscar) != 0 )
                                 {
                                    Rfr0gs = true;
                                 }
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E112K2 */
                                    E112K2 ();
                                 }
                                 dynload_actions( ) ;
                              }
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "MARCAGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              A24marcasid = (int)(context.localUtil.CToN( cgiGet( edtmarcasid_Internalname), ",", "."));
                              A112marcasdsc = cgiGet( edtmarcasdsc_Internalname);
                              n112marcasdsc = false;
                              AV6updateImage = cgiGet( edtavUpdateimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6updateImage))));
                              AV7deleteImage = cgiGet( edtavDeleteimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7deleteImage))));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122K2 */
                                    E122K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E132K2 */
                                    E132K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E142K2 */
                                    E142K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "MARCAGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E152K2 */
                                    E152K2 ();
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE2K2( )
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

      protected void PA2K2( )
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

      protected void gxnrMarcagrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subMarcagrid_Islastpage==1)&&(nGXsfl_12_idx+1>subMarcagrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(MarcagridContainer.ToJavascriptSource());
         /* End function gxnrMarcagrid_newrow */
      }

      protected void gxgrMarcagrid_refresh( String AV5buscar ,
                                            String AV6updateImage ,
                                            String AV7deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         MARCAGRID_nCurrentRecord = 0;
         RF2K2( ) ;
         /* End function gxgrMarcagrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_MARCASID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A24marcasid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "MARCASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24marcasid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_MARCASDSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A112marcasdsc, ""))));
         GxWebStd.gx_hidden_field( context, "MARCASDSC", A112marcasdsc);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2K2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2K2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            MarcagridContainer.ClearRows();
         }
         wbStart = 12;
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         nGXsfl_12_Refreshing = 1;
         MarcagridContainer.AddObjectProperty("GridName", "Marcagrid");
         MarcagridContainer.AddObjectProperty("CmpContext", "");
         MarcagridContainer.AddObjectProperty("InMasterPage", "false");
         MarcagridContainer.AddObjectProperty("Class", "Grid");
         MarcagridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         MarcagridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         MarcagridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subMarcagrid_Backcolorstyle), 1, 0, ".", "")));
         MarcagridContainer.PageSize = subMarcagrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_122( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H002K2 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A112marcasdsc = H002K2_A112marcasdsc[0];
               n112marcasdsc = H002K2_n112marcasdsc[0];
               A24marcasid = H002K2_A24marcasid[0];
               /* Execute user event: E152K2 */
               E152K2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 12;
            WB2K0( ) ;
         }
         nGXsfl_12_Refreshing = 0;
      }

      protected int subMarcagrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subMarcagrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subMarcagrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subMarcagrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP2K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E122K2 */
         E122K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5buscar = cgiGet( edtavBuscar_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ",", "."));
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
         /* Execute user event: E122K2 */
         E122K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E122K2( )
      {
         /* Start Routine */
         AV6updateImage = context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6updateImage))));
         AV10Updateimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6updateImage))));
         AV7deleteImage = context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7deleteImage))));
         AV11Deleteimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7deleteImage))));
      }

      protected void E132K2( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("marcas.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A24marcasid);
         context.wjLocDisableFrm = 1;
      }

      protected void E142K2( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("marcas.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A24marcasid);
         context.wjLocDisableFrm = 1;
      }

      public void GXEnter( )
      {
         /* Execute user event: E112K2 */
         E112K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112K2( )
      {
         /* Enter Routine */
         context.wjLoc = formatLink("catalog_de_marcas.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      private void E152K2( )
      {
         /* Marcagrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_12_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(12, MarcagridRow);
         }
      }

      protected void wb_table1_2_2K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(77), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(1014), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:154px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetallesMarcas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:474px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalles Marcas", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#646464;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetallesMarcas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:804px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#00FF00;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 2, 0)+","+"null"+");", "agregar", bttButton1_Jsonclick, 5, "agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesMarcas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2K2e( true) ;
         }
         else
         {
            wb_table1_2_2K2e( false) ;
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
         PA2K2( ) ;
         WS2K2( ) ;
         WE2K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215592090");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallesmarcas.js", "?2022215592090");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtmarcasid_Internalname = "MARCASID_"+sGXsfl_12_idx;
         edtmarcasdsc_Internalname = "MARCASDSC_"+sGXsfl_12_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_12_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtmarcasid_Internalname = "MARCASID_"+sGXsfl_12_fel_idx;
         edtmarcasdsc_Internalname = "MARCASDSC_"+sGXsfl_12_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_12_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB2K0( ) ;
         MarcagridRow = GXWebRow.GetNew(context,MarcagridContainer);
         if ( subMarcagrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subMarcagrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subMarcagrid_Class, "") != 0 )
            {
               subMarcagrid_Linesclass = subMarcagrid_Class+"Odd";
            }
         }
         else if ( subMarcagrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subMarcagrid_Backstyle = 0;
            subMarcagrid_Backcolor = subMarcagrid_Allbackcolor;
            if ( StringUtil.StrCmp(subMarcagrid_Class, "") != 0 )
            {
               subMarcagrid_Linesclass = subMarcagrid_Class+"Uniform";
            }
         }
         else if ( subMarcagrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subMarcagrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subMarcagrid_Class, "") != 0 )
            {
               subMarcagrid_Linesclass = subMarcagrid_Class+"Odd";
            }
            subMarcagrid_Backcolor = (int)(0x0);
         }
         else if ( subMarcagrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subMarcagrid_Backstyle = 1;
            if ( ((int)((nGXsfl_12_idx) % (2))) == 0 )
            {
               subMarcagrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subMarcagrid_Class, "") != 0 )
               {
                  subMarcagrid_Linesclass = subMarcagrid_Class+"Even";
               }
            }
            else
            {
               subMarcagrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subMarcagrid_Class, "") != 0 )
               {
                  subMarcagrid_Linesclass = subMarcagrid_Class+"Odd";
               }
            }
         }
         if ( MarcagridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subMarcagrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
         }
         /* Subfile cell */
         if ( MarcagridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         MarcagridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtmarcasid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24marcasid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A24marcasid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtmarcasid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( MarcagridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         MarcagridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtmarcasdsc_Internalname,(String)A112marcasdsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtmarcasdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( MarcagridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 15,'',false,'',12)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)));
         MarcagridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV6updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( MarcagridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 16,'',false,'',12)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)));
         MarcagridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV7deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_MARCASID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A24marcasid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_MARCASDSC"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A112marcasdsc, ""))));
         MarcagridContainer.AddRow(MarcagridRow);
         nGXsfl_12_idx = (short)(((subMarcagrid_Islastpage==1)&&(nGXsfl_12_idx+1>subMarcagrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         edtavBuscar_Internalname = "vBUSCAR";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         bttButton1_Internalname = "BUTTON1";
         tblTable1_Internalname = "TABLE1";
         edtmarcasid_Internalname = "MARCASID";
         edtmarcasdsc_Internalname = "MARCASDSC";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subMarcagrid_Internalname = "MARCAGRID";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavDeleteimage_Jsonclick = "";
         edtavDeleteimage_Visible = -1;
         edtavDeleteimage_Enabled = 1;
         edtavUpdateimage_Jsonclick = "";
         edtavUpdateimage_Visible = -1;
         edtavUpdateimage_Enabled = 1;
         edtmarcasdsc_Jsonclick = "";
         edtmarcasid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subMarcagrid_Allowcollapsing = 0;
         subMarcagrid_Allowselection = 0;
         subMarcagrid_Class = "Grid";
         subMarcagrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Marcas";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'MARCAGRID_nFirstRecordOnPage',nv:0},{av:'MARCAGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV6updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV7deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E132K2',iparms:[{av:'A24marcasid',fld:'MARCASID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E142K2',iparms:[{av:'A24marcasid',fld:'MARCASID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E112K2',iparms:[],oparms:[]}");
         setEventMetadata("MARCAGRID.LOAD","{handler:'E152K2',iparms:[],oparms:[]}");
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
         AV6updateImage = "";
         AV10Updateimage_GXI = "";
         AV7deleteImage = "";
         AV11Deleteimage_GXI = "";
         AV5buscar = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         MarcagridContainer = new GXWebGrid( context);
         sStyleString = "";
         subMarcagrid_Linesclass = "";
         MarcagridColumn = new GXWebColumn();
         A112marcasdsc = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H002K2_A112marcasdsc = new String[] {""} ;
         H002K2_n112marcasdsc = new bool[] {false} ;
         H002K2_A24marcasid = new int[1] ;
         MarcagridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallesmarcas__default(),
            new Object[][] {
                new Object[] {
               H002K2_A112marcasdsc, H002K2_n112marcasdsc, H002K2_A24marcasid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subMarcagrid_Backcolorstyle ;
      private short subMarcagrid_Titlebackstyle ;
      private short subMarcagrid_Allowselection ;
      private short subMarcagrid_Allowhovering ;
      private short subMarcagrid_Allowcollapsing ;
      private short subMarcagrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_12_Refreshing=0 ;
      private short nGXWrapped ;
      private short subMarcagrid_Backstyle ;
      private short MARCAGRID_nEOF ;
      private int subMarcagrid_Titlebackcolor ;
      private int subMarcagrid_Allbackcolor ;
      private int A24marcasid ;
      private int subMarcagrid_Selectioncolor ;
      private int subMarcagrid_Hoveringcolor ;
      private int subMarcagrid_Islastpage ;
      private int idxLst ;
      private int subMarcagrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long MARCAGRID_nCurrentRecord ;
      private long MARCAGRID_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String edtavUpdateimage_Internalname ;
      private String edtavDeleteimage_Internalname ;
      private String AV5buscar ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sStyleString ;
      private String subMarcagrid_Internalname ;
      private String subMarcagrid_Class ;
      private String subMarcagrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtmarcasid_Internalname ;
      private String edtmarcasdsc_Internalname ;
      private String edtavBuscar_Internalname ;
      private String scmdbuf ;
      private String lV5buscar ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String edtavBuscar_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String ROClassString ;
      private String edtmarcasid_Jsonclick ;
      private String edtmarcasdsc_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n112marcasdsc ;
      private bool returnInSub ;
      private bool AV6updateImage_IsBlob ;
      private bool AV7deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A112marcasdsc ;
      private String AV6updateImage ;
      private String AV7deleteImage ;
      private GXWebGrid MarcagridContainer ;
      private GXWebRow MarcagridRow ;
      private GXWebColumn MarcagridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002K2_A112marcasdsc ;
      private bool[] H002K2_n112marcasdsc ;
      private int[] H002K2_A24marcasid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallesmarcas__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002K2 ;
          prmH002K2 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002K2", "SELECT marcasdsc, marcasid FROM public.marcas WHERE marcasdsc like :lV5buscar ORDER BY marcasid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002K2,11,0,true,false )
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
