/*
               File: DetallesProducto
        Description: Detalles Producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:26.69
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
   public class detallesproducto : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallesproducto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallesproducto( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Productogrid") == 0 )
            {
               nRC_GXsfl_11 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_11_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_11_idx = GetNextPar( );
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
               gxnrProductogrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Productogrid") == 0 )
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
               gxgrProductogrid_refresh( AV5buscar, AV7updateImage, AV6deleteImage) ;
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
         PA392( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START392( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215592672");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallesproducto.aspx") +"\">") ;
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
            WE392( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT392( ) ;
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
         return formatLink("detallesproducto.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesProducto" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Producto" ;
      }

      protected void WB390( )
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
            wb_table1_2_392( true) ;
         }
         else
         {
            wb_table1_2_392( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_392e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            ProductogridContainer.SetWrapped(nGXWrapped);
            if ( ProductogridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"ProductogridContainer"+"DivS\" data-gxgridid=\"11\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subProductogrid_Internalname, subProductogrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subProductogrid_Backcolorstyle == 0 )
               {
                  subProductogrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subProductogrid_Class) > 0 )
                  {
                     subProductogrid_Linesclass = subProductogrid_Class+"Title";
                  }
               }
               else
               {
                  subProductogrid_Titlebackstyle = 1;
                  if ( subProductogrid_Backcolorstyle == 1 )
                  {
                     subProductogrid_Titlebackcolor = subProductogrid_Allbackcolor;
                     if ( StringUtil.Len( subProductogrid_Class) > 0 )
                     {
                        subProductogrid_Linesclass = subProductogrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subProductogrid_Class) > 0 )
                     {
                        subProductogrid_Linesclass = subProductogrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Marca") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Modelo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProductogrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               ProductogridContainer.AddObjectProperty("GridName", "Productogrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  ProductogridContainer = new GXWebGrid( context);
               }
               else
               {
                  ProductogridContainer.Clear();
               }
               ProductogridContainer.SetWrapped(nGXWrapped);
               ProductogridContainer.AddObjectProperty("GridName", "Productogrid");
               ProductogridContainer.AddObjectProperty("Class", "Grid");
               ProductogridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Backcolorstyle), 1, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("CmpContext", "");
               ProductogridContainer.AddObjectProperty("InMasterPage", "false");
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ".", "")));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A183ptipobienid), 4, 0, ".", "")));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", A87productodsc);
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A181pmarcaid), 4, 0, ".", "")));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A180pmodeloid), 4, 0, ".", "")));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", context.convertURL( AV7updateImage));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProductogridColumn.AddObjectProperty("Value", context.convertURL( AV6deleteImage));
               ProductogridContainer.AddColumnProperties(ProductogridColumn);
               ProductogridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Allowselection), 1, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Selectioncolor), 9, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Allowhovering), 1, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Hoveringcolor), 9, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Allowcollapsing), 1, 0, ".", "")));
               ProductogridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 11 )
         {
            wbEnd = 0;
            nRC_GXsfl_11 = (short)(nGXsfl_11_idx-1);
            if ( ProductogridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"ProductogridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Productogrid", ProductogridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "ProductogridContainerData", ProductogridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "ProductogridContainerData"+"V", ProductogridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"ProductogridContainerData"+"V"+"\" value='"+ProductogridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true;
      }

      protected void START392( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP390( ) ;
      }

      protected void WS392( )
      {
         START392( ) ;
         EVT392( ) ;
      }

      protected void EVT392( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'AGREGAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E11392 */
                              E11392 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "PRODUCTOGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                              SubsflControlProps_112( ) ;
                              A175productoid = (int)(context.localUtil.CToN( cgiGet( edtproductoid_Internalname), ",", "."));
                              A183ptipobienid = (short)(context.localUtil.CToN( cgiGet( edtptipobienid_Internalname), ",", "."));
                              n183ptipobienid = false;
                              A87productodsc = cgiGet( edtproductodsc_Internalname);
                              n87productodsc = false;
                              A181pmarcaid = (short)(context.localUtil.CToN( cgiGet( edtpmarcaid_Internalname), ",", "."));
                              n181pmarcaid = false;
                              A180pmodeloid = (short)(context.localUtil.CToN( cgiGet( edtpmodeloid_Internalname), ",", "."));
                              n180pmodeloid = false;
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
                                    /* Execute user event: E12392 */
                                    E12392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13392 */
                                    E13392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14392 */
                                    E14392 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "PRODUCTOGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15392 */
                                    E15392 ();
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE392( )
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

      protected void PA392( )
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

      protected void gxnrProductogrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_112( ) ;
         while ( nGXsfl_11_idx <= nRC_GXsfl_11 )
         {
            sendrow_112( ) ;
            nGXsfl_11_idx = (short)(((subProductogrid_Islastpage==1)&&(nGXsfl_11_idx+1>subProductogrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
            sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
            SubsflControlProps_112( ) ;
         }
         context.GX_webresponse.AddString(ProductogridContainer.ToJavascriptSource());
         /* End function gxnrProductogrid_newrow */
      }

      protected void gxgrProductogrid_refresh( String AV5buscar ,
                                               String AV7updateImage ,
                                               String AV6deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         PRODUCTOGRID_nCurrentRecord = 0;
         RF392( ) ;
         /* End function gxgrProductogrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PRODUCTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PTIPOBIENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A183ptipobienid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "PTIPOBIENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A183ptipobienid), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
         GxWebStd.gx_hidden_field( context, "PRODUCTODSC", A87productodsc);
         GxWebStd.gx_hidden_field( context, "gxhash_PMARCAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A181pmarcaid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "PMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A181pmarcaid), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PMODELOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A180pmodeloid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "PMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A180pmodeloid), 4, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF392( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF392( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            ProductogridContainer.ClearRows();
         }
         wbStart = 11;
         nGXsfl_11_idx = 1;
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         nGXsfl_11_Refreshing = 1;
         ProductogridContainer.AddObjectProperty("GridName", "Productogrid");
         ProductogridContainer.AddObjectProperty("CmpContext", "");
         ProductogridContainer.AddObjectProperty("InMasterPage", "false");
         ProductogridContainer.AddObjectProperty("Class", "Grid");
         ProductogridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         ProductogridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         ProductogridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProductogrid_Backcolorstyle), 1, 0, ".", "")));
         ProductogridContainer.PageSize = subProductogrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_112( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H00392 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A180pmodeloid = H00392_A180pmodeloid[0];
               n180pmodeloid = H00392_n180pmodeloid[0];
               A181pmarcaid = H00392_A181pmarcaid[0];
               n181pmarcaid = H00392_n181pmarcaid[0];
               A87productodsc = H00392_A87productodsc[0];
               n87productodsc = H00392_n87productodsc[0];
               A183ptipobienid = H00392_A183ptipobienid[0];
               n183ptipobienid = H00392_n183ptipobienid[0];
               A175productoid = H00392_A175productoid[0];
               /* Execute user event: E15392 */
               E15392 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 11;
            WB390( ) ;
         }
         nGXsfl_11_Refreshing = 0;
      }

      protected int subProductogrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subProductogrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subProductogrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subProductogrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP390( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E12392 */
         E12392 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5buscar = cgiGet( edtavBuscar_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
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

      protected void GXStart( )
      {
         /* Execute user event: E12392 */
         E12392 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12392( )
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

      protected void E13392( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("producto.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A175productoid);
         context.wjLocDisableFrm = 1;
      }

      protected void E14392( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("producto.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A175productoid);
         context.wjLocDisableFrm = 1;
      }

      private void E15392( )
      {
         /* Productogrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 11;
         }
         sendrow_112( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_11_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(11, ProductogridRow);
         }
      }

      protected void E11392( )
      {
         /* 'Agregar' Routine */
         context.wjLoc = formatLink("catalog_de_productos.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      protected void wb_table1_2_392( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(56), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(1000), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:175px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_11_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetallesProducto.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:794px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalles Productos", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#000000;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetallesProducto.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:796px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#80FF80;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(11), 2, 0)+","+"null"+");", "Agregar", bttButton1_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'AGREGAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesProducto.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_392e( true) ;
         }
         else
         {
            wb_table1_2_392e( false) ;
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
         PA392( ) ;
         WS392( ) ;
         WE392( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215592686");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallesproducto.js", "?2022215592686");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_112( )
      {
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_11_idx;
         edtptipobienid_Internalname = "PTIPOBIENID_"+sGXsfl_11_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_11_idx;
         edtpmarcaid_Internalname = "PMARCAID_"+sGXsfl_11_idx;
         edtpmodeloid_Internalname = "PMODELOID_"+sGXsfl_11_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_idx;
      }

      protected void SubsflControlProps_fel_112( )
      {
         edtproductoid_Internalname = "PRODUCTOID_"+sGXsfl_11_fel_idx;
         edtptipobienid_Internalname = "PTIPOBIENID_"+sGXsfl_11_fel_idx;
         edtproductodsc_Internalname = "PRODUCTODSC_"+sGXsfl_11_fel_idx;
         edtpmarcaid_Internalname = "PMARCAID_"+sGXsfl_11_fel_idx;
         edtpmodeloid_Internalname = "PMODELOID_"+sGXsfl_11_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_fel_idx;
      }

      protected void sendrow_112( )
      {
         SubsflControlProps_112( ) ;
         WB390( ) ;
         ProductogridRow = GXWebRow.GetNew(context,ProductogridContainer);
         if ( subProductogrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subProductogrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subProductogrid_Class, "") != 0 )
            {
               subProductogrid_Linesclass = subProductogrid_Class+"Odd";
            }
         }
         else if ( subProductogrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subProductogrid_Backstyle = 0;
            subProductogrid_Backcolor = subProductogrid_Allbackcolor;
            if ( StringUtil.StrCmp(subProductogrid_Class, "") != 0 )
            {
               subProductogrid_Linesclass = subProductogrid_Class+"Uniform";
            }
         }
         else if ( subProductogrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subProductogrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subProductogrid_Class, "") != 0 )
            {
               subProductogrid_Linesclass = subProductogrid_Class+"Odd";
            }
            subProductogrid_Backcolor = (int)(0x0);
         }
         else if ( subProductogrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subProductogrid_Backstyle = 1;
            if ( ((int)((nGXsfl_11_idx) % (2))) == 0 )
            {
               subProductogrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subProductogrid_Class, "") != 0 )
               {
                  subProductogrid_Linesclass = subProductogrid_Class+"Even";
               }
            }
            else
            {
               subProductogrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subProductogrid_Class, "") != 0 )
               {
                  subProductogrid_Linesclass = subProductogrid_Class+"Odd";
               }
            }
         }
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subProductogrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_11_idx+"\">") ;
         }
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProductogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductoid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A175productoid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductoid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"left",(bool)false});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProductogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtptipobienid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A183ptipobienid), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A183ptipobienid), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtptipobienid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProductogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproductodsc_Internalname,(String)A87productodsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproductodsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProductogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtpmarcaid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A181pmarcaid), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A181pmarcaid), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtpmarcaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProductogridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtpmodeloid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A180pmodeloid), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A180pmodeloid), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtpmodeloid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 17,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)));
         ProductogridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV7updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( ProductogridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 18,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)));
         ProductogridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV6deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTOID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A175productoid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_PTIPOBIENID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A183ptipobienid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUCTODSC"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A87productodsc, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PMARCAID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A181pmarcaid), "ZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_PMODELOID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A180pmodeloid), "ZZZ9")));
         ProductogridContainer.AddRow(ProductogridRow);
         nGXsfl_11_idx = (short)(((subProductogrid_Islastpage==1)&&(nGXsfl_11_idx+1>subProductogrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         /* End function sendrow_112 */
      }

      protected void init_default_properties( )
      {
         edtavBuscar_Internalname = "vBUSCAR";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         bttButton1_Internalname = "BUTTON1";
         tblTable1_Internalname = "TABLE1";
         edtproductoid_Internalname = "PRODUCTOID";
         edtptipobienid_Internalname = "PTIPOBIENID";
         edtproductodsc_Internalname = "PRODUCTODSC";
         edtpmarcaid_Internalname = "PMARCAID";
         edtpmodeloid_Internalname = "PMODELOID";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subProductogrid_Internalname = "PRODUCTOGRID";
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
         edtpmodeloid_Jsonclick = "";
         edtpmarcaid_Jsonclick = "";
         edtproductodsc_Jsonclick = "";
         edtptipobienid_Jsonclick = "";
         edtproductoid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subProductogrid_Allowcollapsing = 0;
         subProductogrid_Allowselection = 0;
         subProductogrid_Class = "Grid";
         subProductogrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Producto";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'PRODUCTOGRID_nFirstRecordOnPage',nv:0},{av:'PRODUCTOGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV7updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV6deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E13392',iparms:[{av:'A175productoid',fld:'PRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E14392',iparms:[{av:'A175productoid',fld:'PRODUCTOID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("PRODUCTOGRID.LOAD","{handler:'E15392',iparms:[],oparms:[]}");
         setEventMetadata("'AGREGAR'","{handler:'E11392',iparms:[],oparms:[]}");
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
         ProductogridContainer = new GXWebGrid( context);
         sStyleString = "";
         subProductogrid_Linesclass = "";
         ProductogridColumn = new GXWebColumn();
         A87productodsc = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H00392_A180pmodeloid = new short[1] ;
         H00392_n180pmodeloid = new bool[] {false} ;
         H00392_A181pmarcaid = new short[1] ;
         H00392_n181pmarcaid = new bool[] {false} ;
         H00392_A87productodsc = new String[] {""} ;
         H00392_n87productodsc = new bool[] {false} ;
         H00392_A183ptipobienid = new short[1] ;
         H00392_n183ptipobienid = new bool[] {false} ;
         H00392_A175productoid = new int[1] ;
         ProductogridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallesproducto__default(),
            new Object[][] {
                new Object[] {
               H00392_A180pmodeloid, H00392_n180pmodeloid, H00392_A181pmarcaid, H00392_n181pmarcaid, H00392_A87productodsc, H00392_n87productodsc, H00392_A183ptipobienid, H00392_n183ptipobienid, H00392_A175productoid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_11 ;
      private short nGXsfl_11_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subProductogrid_Backcolorstyle ;
      private short subProductogrid_Titlebackstyle ;
      private short A183ptipobienid ;
      private short A181pmarcaid ;
      private short A180pmodeloid ;
      private short subProductogrid_Allowselection ;
      private short subProductogrid_Allowhovering ;
      private short subProductogrid_Allowcollapsing ;
      private short subProductogrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_11_Refreshing=0 ;
      private short nGXWrapped ;
      private short subProductogrid_Backstyle ;
      private short PRODUCTOGRID_nEOF ;
      private int subProductogrid_Titlebackcolor ;
      private int subProductogrid_Allbackcolor ;
      private int A175productoid ;
      private int subProductogrid_Selectioncolor ;
      private int subProductogrid_Hoveringcolor ;
      private int subProductogrid_Islastpage ;
      private int idxLst ;
      private int subProductogrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long PRODUCTOGRID_nCurrentRecord ;
      private long PRODUCTOGRID_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_11_idx="0001" ;
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
      private String subProductogrid_Internalname ;
      private String subProductogrid_Class ;
      private String subProductogrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtproductoid_Internalname ;
      private String edtptipobienid_Internalname ;
      private String edtproductodsc_Internalname ;
      private String edtpmarcaid_Internalname ;
      private String edtpmodeloid_Internalname ;
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
      private String sGXsfl_11_fel_idx="0001" ;
      private String ROClassString ;
      private String edtproductoid_Jsonclick ;
      private String edtptipobienid_Jsonclick ;
      private String edtproductodsc_Jsonclick ;
      private String edtpmarcaid_Jsonclick ;
      private String edtpmodeloid_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n183ptipobienid ;
      private bool n87productodsc ;
      private bool n181pmarcaid ;
      private bool n180pmodeloid ;
      private bool returnInSub ;
      private bool AV7updateImage_IsBlob ;
      private bool AV6deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A87productodsc ;
      private String AV7updateImage ;
      private String AV6deleteImage ;
      private GXWebGrid ProductogridContainer ;
      private GXWebRow ProductogridRow ;
      private GXWebColumn ProductogridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00392_A180pmodeloid ;
      private bool[] H00392_n180pmodeloid ;
      private short[] H00392_A181pmarcaid ;
      private bool[] H00392_n181pmarcaid ;
      private String[] H00392_A87productodsc ;
      private bool[] H00392_n87productodsc ;
      private short[] H00392_A183ptipobienid ;
      private bool[] H00392_n183ptipobienid ;
      private int[] H00392_A175productoid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallesproducto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00392 ;
          prmH00392 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00392", "SELECT pmodeloid, pmarcaid, productodsc, ptipobienid, productoid FROM public.producto WHERE productodsc like :lV5buscar ORDER BY  ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00392,11,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
