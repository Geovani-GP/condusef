/*
               File: DetalleArticulo
        Description: Detalle Articulo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:3.65
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
   public class detallearticulo : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallearticulo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallearticulo( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Estatusarticulosgrid") == 0 )
            {
               nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_12_idx = GetNextPar( );
               AV7updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
               AV6deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrEstatusarticulosgrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Estatusarticulosgrid") == 0 )
            {
               AV5buscar = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
               AV7updateImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
               AV6deleteImage = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrEstatusarticulosgrid_refresh( AV5buscar, AV7updateImage, AV6deleteImage) ;
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
         PA2W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2W2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022221343367");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallearticulo.aspx") +"\">") ;
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
            WE2W2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2W2( ) ;
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
         return formatLink("detallearticulo.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetalleArticulo" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalle Articulo" ;
      }

      protected void WB2W0( )
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
            wb_table1_2_2W2( true) ;
         }
         else
         {
            wb_table1_2_2W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            EstatusarticulosgridContainer.SetWrapped(nGXWrapped);
            if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"EstatusarticulosgridContainer"+"DivS\" data-gxgridid=\"12\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subEstatusarticulosgrid_Internalname, subEstatusarticulosgrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subEstatusarticulosgrid_Backcolorstyle == 0 )
               {
                  subEstatusarticulosgrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subEstatusarticulosgrid_Class) > 0 )
                  {
                     subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Title";
                  }
               }
               else
               {
                  subEstatusarticulosgrid_Titlebackstyle = 1;
                  if ( subEstatusarticulosgrid_Backcolorstyle == 1 )
                  {
                     subEstatusarticulosgrid_Titlebackcolor = subEstatusarticulosgrid_Allbackcolor;
                     if ( StringUtil.Len( subEstatusarticulosgrid_Class) > 0 )
                     {
                        subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subEstatusarticulosgrid_Class) > 0 )
                     {
                        subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEstatusarticulosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estatusarticuloid") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEstatusarticulosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estatusarticulodsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEstatusarticulosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estatusarticulodescuso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEstatusarticulosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "update Image") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEstatusarticulosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "delete Image") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               EstatusarticulosgridContainer.AddObjectProperty("GridName", "Estatusarticulosgrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  EstatusarticulosgridContainer = new GXWebGrid( context);
               }
               else
               {
                  EstatusarticulosgridContainer.Clear();
               }
               EstatusarticulosgridContainer.SetWrapped(nGXWrapped);
               EstatusarticulosgridContainer.AddObjectProperty("GridName", "Estatusarticulosgrid");
               EstatusarticulosgridContainer.AddObjectProperty("Class", "Grid");
               EstatusarticulosgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Backcolorstyle), 1, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("CmpContext", "");
               EstatusarticulosgridContainer.AddObjectProperty("InMasterPage", "false");
               EstatusarticulosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EstatusarticulosgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ".", "")));
               EstatusarticulosgridContainer.AddColumnProperties(EstatusarticulosgridColumn);
               EstatusarticulosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EstatusarticulosgridColumn.AddObjectProperty("Value", A54estatusarticulodsc);
               EstatusarticulosgridContainer.AddColumnProperties(EstatusarticulosgridColumn);
               EstatusarticulosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EstatusarticulosgridColumn.AddObjectProperty("Value", A55estatusarticulodescuso);
               EstatusarticulosgridContainer.AddColumnProperties(EstatusarticulosgridColumn);
               EstatusarticulosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EstatusarticulosgridColumn.AddObjectProperty("Value", context.convertURL( AV7updateImage));
               EstatusarticulosgridContainer.AddColumnProperties(EstatusarticulosgridColumn);
               EstatusarticulosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EstatusarticulosgridColumn.AddObjectProperty("Value", context.convertURL( AV6deleteImage));
               EstatusarticulosgridContainer.AddColumnProperties(EstatusarticulosgridColumn);
               EstatusarticulosgridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Allowselection), 1, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Selectioncolor), 9, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Allowhovering), 1, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Hoveringcolor), 9, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Allowcollapsing), 1, 0, ".", "")));
               EstatusarticulosgridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
            if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"EstatusarticulosgridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Estatusarticulosgrid", EstatusarticulosgridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EstatusarticulosgridContainerData", EstatusarticulosgridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EstatusarticulosgridContainerData"+"V", EstatusarticulosgridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"EstatusarticulosgridContainerData"+"V"+"\" value='"+EstatusarticulosgridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true;
      }

      protected void START2W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalle Articulo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2W0( ) ;
      }

      protected void WS2W2( )
      {
         START2W2( ) ;
         EVT2W2( ) ;
      }

      protected void EVT2W2( )
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
                                    /* Execute user event: E112W2 */
                                    E112W2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 25), "ESTATUSARTICULOSGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              A12estatusarticuloid = (long)(context.localUtil.CToN( cgiGet( edtestatusarticuloid_Internalname), ",", "."));
                              A54estatusarticulodsc = cgiGet( edtestatusarticulodsc_Internalname);
                              n54estatusarticulodsc = false;
                              A55estatusarticulodescuso = cgiGet( edtestatusarticulodescuso_Internalname);
                              n55estatusarticulodescuso = false;
                              AV7updateImage = cgiGet( edtavUpdateimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
                              AV6deleteImage = cgiGet( edtavDeleteimage_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122W2 */
                                    E122W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E132W2 */
                                    E132W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E142W2 */
                                    E142W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ESTATUSARTICULOSGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E152W2 */
                                    E152W2 ();
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

      protected void WE2W2( )
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

      protected void PA2W2( )
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

      protected void gxnrEstatusarticulosgrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subEstatusarticulosgrid_Islastpage==1)&&(nGXsfl_12_idx+1>subEstatusarticulosgrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(EstatusarticulosgridContainer.ToJavascriptSource());
         /* End function gxnrEstatusarticulosgrid_newrow */
      }

      protected void gxgrEstatusarticulosgrid_refresh( String AV5buscar ,
                                                       String AV7updateImage ,
                                                       String AV6deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         ESTATUSARTICULOSGRID_nCurrentRecord = 0;
         RF2W2( ) ;
         /* End function gxgrEstatusarticulosgrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A54estatusarticulodsc, ""))));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULODSC", A54estatusarticulodsc);
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODESCUSO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A55estatusarticulodescuso, ""))));
         GxWebStd.gx_hidden_field( context, "ESTATUSARTICULODESCUSO", A55estatusarticulodescuso);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2W2( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2W2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            EstatusarticulosgridContainer.ClearRows();
         }
         wbStart = 12;
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         nGXsfl_12_Refreshing = 1;
         EstatusarticulosgridContainer.AddObjectProperty("GridName", "Estatusarticulosgrid");
         EstatusarticulosgridContainer.AddObjectProperty("CmpContext", "");
         EstatusarticulosgridContainer.AddObjectProperty("InMasterPage", "false");
         EstatusarticulosgridContainer.AddObjectProperty("Class", "Grid");
         EstatusarticulosgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         EstatusarticulosgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         EstatusarticulosgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEstatusarticulosgrid_Backcolorstyle), 1, 0, ".", "")));
         EstatusarticulosgridContainer.PageSize = subEstatusarticulosgrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_122( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H002W2 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A55estatusarticulodescuso = H002W2_A55estatusarticulodescuso[0];
               n55estatusarticulodescuso = H002W2_n55estatusarticulodescuso[0];
               A54estatusarticulodsc = H002W2_A54estatusarticulodsc[0];
               n54estatusarticulodsc = H002W2_n54estatusarticulodsc[0];
               A12estatusarticuloid = H002W2_A12estatusarticuloid[0];
               /* Execute user event: E152W2 */
               E152W2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 12;
            WB2W0( ) ;
         }
         nGXsfl_12_Refreshing = 0;
      }

      protected int subEstatusarticulosgrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subEstatusarticulosgrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subEstatusarticulosgrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subEstatusarticulosgrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP2W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E122W2 */
         E122W2 ();
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
         /* Execute user event: E122W2 */
         E122W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E122W2( )
      {
         /* Start Routine */
         AV7updateImage = context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
         AV10Updateimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "c7599f2c-228e-49d1-912e-ed139fdd44e8", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.convertURL( context.PathToRelativeUrl( AV7updateImage))));
         AV6deleteImage = context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
         AV11Deleteimage_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "6f6e945e-4f5d-4c68-9a64-083178c1b788", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.convertURL( context.PathToRelativeUrl( AV6deleteImage))));
      }

      protected void E132W2( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("estatusarticulo.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A12estatusarticuloid);
         context.wjLocDisableFrm = 1;
      }

      protected void E142W2( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("estatusarticulo.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A12estatusarticuloid);
         context.wjLocDisableFrm = 1;
      }

      public void GXEnter( )
      {
         /* Execute user event: E112W2 */
         E112W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112W2( )
      {
         /* Enter Routine */
         context.wjLoc = formatLink("catalog_de_articulo.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      private void E152W2( )
      {
         /* Estatusarticulosgrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_12_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(12, EstatusarticulosgridRow);
         }
      }

      protected void wb_table1_2_2W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(57), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(1003), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:214px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetalleArticulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:598px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalle Articulos", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#000000;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetalleArticulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:760px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#00FF00; border-color:#00FF00;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 2, 0)+","+"null"+");", "Agregar", bttButton1_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetalleArticulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2W2e( true) ;
         }
         else
         {
            wb_table1_2_2W2e( false) ;
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
         PA2W2( ) ;
         WS2W2( ) ;
         WE2W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022221343379");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallearticulo.js", "?2022221343379");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID_"+sGXsfl_12_idx;
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC_"+sGXsfl_12_idx;
         edtestatusarticulodescuso_Internalname = "ESTATUSARTICULODESCUSO_"+sGXsfl_12_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_12_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID_"+sGXsfl_12_fel_idx;
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC_"+sGXsfl_12_fel_idx;
         edtestatusarticulodescuso_Internalname = "ESTATUSARTICULODESCUSO_"+sGXsfl_12_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_12_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB2W0( ) ;
         EstatusarticulosgridRow = GXWebRow.GetNew(context,EstatusarticulosgridContainer);
         if ( subEstatusarticulosgrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subEstatusarticulosgrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subEstatusarticulosgrid_Class, "") != 0 )
            {
               subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Odd";
            }
         }
         else if ( subEstatusarticulosgrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subEstatusarticulosgrid_Backstyle = 0;
            subEstatusarticulosgrid_Backcolor = subEstatusarticulosgrid_Allbackcolor;
            if ( StringUtil.StrCmp(subEstatusarticulosgrid_Class, "") != 0 )
            {
               subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Uniform";
            }
         }
         else if ( subEstatusarticulosgrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subEstatusarticulosgrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subEstatusarticulosgrid_Class, "") != 0 )
            {
               subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Odd";
            }
            subEstatusarticulosgrid_Backcolor = (int)(0x0);
         }
         else if ( subEstatusarticulosgrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subEstatusarticulosgrid_Backstyle = 1;
            if ( ((int)((nGXsfl_12_idx) % (2))) == 0 )
            {
               subEstatusarticulosgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEstatusarticulosgrid_Class, "") != 0 )
               {
                  subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Even";
               }
            }
            else
            {
               subEstatusarticulosgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEstatusarticulosgrid_Class, "") != 0 )
               {
                  subEstatusarticulosgrid_Linesclass = subEstatusarticulosgrid_Class+"Odd";
               }
            }
         }
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subEstatusarticulosgrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
         }
         /* Subfile cell */
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EstatusarticulosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtestatusarticuloid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A12estatusarticuloid), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtestatusarticuloid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EstatusarticulosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtestatusarticulodsc_Internalname,(String)A54estatusarticulodsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtestatusarticulodsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EstatusarticulosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtestatusarticulodescuso_Internalname,(String)A55estatusarticulodescuso,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtestatusarticulodescuso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 16,'',false,'',12)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)));
         EstatusarticulosgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV7updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( EstatusarticulosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 17,'',false,'',12)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)));
         EstatusarticulosgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV6deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULOID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A12estatusarticuloid), "ZZZZZZZZZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODSC"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A54estatusarticulodsc, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_ESTATUSARTICULODESCUSO"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A55estatusarticulodescuso, ""))));
         EstatusarticulosgridContainer.AddRow(EstatusarticulosgridRow);
         nGXsfl_12_idx = (short)(((subEstatusarticulosgrid_Islastpage==1)&&(nGXsfl_12_idx+1>subEstatusarticulosgrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
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
         edtestatusarticuloid_Internalname = "ESTATUSARTICULOID";
         edtestatusarticulodsc_Internalname = "ESTATUSARTICULODSC";
         edtestatusarticulodescuso_Internalname = "ESTATUSARTICULODESCUSO";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subEstatusarticulosgrid_Internalname = "ESTATUSARTICULOSGRID";
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
         edtestatusarticulodescuso_Jsonclick = "";
         edtestatusarticulodsc_Jsonclick = "";
         edtestatusarticuloid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subEstatusarticulosgrid_Allowcollapsing = 0;
         subEstatusarticulosgrid_Allowselection = 0;
         subEstatusarticulosgrid_Class = "Grid";
         subEstatusarticulosgrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalle Articulo";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'ESTATUSARTICULOSGRID_nFirstRecordOnPage',nv:0},{av:'ESTATUSARTICULOSGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV7updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV6deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E132W2',iparms:[{av:'A12estatusarticuloid',fld:'ESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E142W2',iparms:[{av:'A12estatusarticuloid',fld:'ESTATUSARTICULOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E112W2',iparms:[],oparms:[]}");
         setEventMetadata("ESTATUSARTICULOSGRID.LOAD","{handler:'E152W2',iparms:[],oparms:[]}");
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
         AV7updateImage = "";
         AV10Updateimage_GXI = "";
         AV6deleteImage = "";
         AV11Deleteimage_GXI = "";
         AV5buscar = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         EstatusarticulosgridContainer = new GXWebGrid( context);
         sStyleString = "";
         subEstatusarticulosgrid_Linesclass = "";
         EstatusarticulosgridColumn = new GXWebColumn();
         A54estatusarticulodsc = "";
         A55estatusarticulodescuso = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H002W2_A55estatusarticulodescuso = new String[] {""} ;
         H002W2_n55estatusarticulodescuso = new bool[] {false} ;
         H002W2_A54estatusarticulodsc = new String[] {""} ;
         H002W2_n54estatusarticulodsc = new bool[] {false} ;
         H002W2_A12estatusarticuloid = new long[1] ;
         EstatusarticulosgridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallearticulo__default(),
            new Object[][] {
                new Object[] {
               H002W2_A55estatusarticulodescuso, H002W2_n55estatusarticulodescuso, H002W2_A54estatusarticulodsc, H002W2_n54estatusarticulodsc, H002W2_A12estatusarticuloid
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
      private short subEstatusarticulosgrid_Backcolorstyle ;
      private short subEstatusarticulosgrid_Titlebackstyle ;
      private short subEstatusarticulosgrid_Allowselection ;
      private short subEstatusarticulosgrid_Allowhovering ;
      private short subEstatusarticulosgrid_Allowcollapsing ;
      private short subEstatusarticulosgrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_12_Refreshing=0 ;
      private short nGXWrapped ;
      private short subEstatusarticulosgrid_Backstyle ;
      private short ESTATUSARTICULOSGRID_nEOF ;
      private int subEstatusarticulosgrid_Titlebackcolor ;
      private int subEstatusarticulosgrid_Allbackcolor ;
      private int subEstatusarticulosgrid_Selectioncolor ;
      private int subEstatusarticulosgrid_Hoveringcolor ;
      private int subEstatusarticulosgrid_Islastpage ;
      private int idxLst ;
      private int subEstatusarticulosgrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long A12estatusarticuloid ;
      private long ESTATUSARTICULOSGRID_nCurrentRecord ;
      private long ESTATUSARTICULOSGRID_nFirstRecordOnPage ;
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
      private String subEstatusarticulosgrid_Internalname ;
      private String subEstatusarticulosgrid_Class ;
      private String subEstatusarticulosgrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtestatusarticuloid_Internalname ;
      private String edtestatusarticulodsc_Internalname ;
      private String edtestatusarticulodescuso_Internalname ;
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
      private String edtestatusarticuloid_Jsonclick ;
      private String edtestatusarticulodsc_Jsonclick ;
      private String edtestatusarticulodescuso_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n54estatusarticulodsc ;
      private bool n55estatusarticulodescuso ;
      private bool returnInSub ;
      private bool AV7updateImage_IsBlob ;
      private bool AV6deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A54estatusarticulodsc ;
      private String A55estatusarticulodescuso ;
      private String AV7updateImage ;
      private String AV6deleteImage ;
      private GXWebGrid EstatusarticulosgridContainer ;
      private GXWebRow EstatusarticulosgridRow ;
      private GXWebColumn EstatusarticulosgridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002W2_A55estatusarticulodescuso ;
      private bool[] H002W2_n55estatusarticulodescuso ;
      private String[] H002W2_A54estatusarticulodsc ;
      private bool[] H002W2_n54estatusarticulodsc ;
      private long[] H002W2_A12estatusarticuloid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallearticulo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002W2 ;
          prmH002W2 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002W2", "SELECT estatusarticulodescuso, estatusarticulodsc, estatusarticuloid FROM public.estatusarticulo WHERE estatusarticulodsc like :lV5buscar ORDER BY estatusarticuloid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002W2,11,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
