/*
               File: DetallesProveedores
        Description: Detalles Proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:25.17
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
   public class detallesproveedores : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallesproveedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallesproveedores( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Proveedoresgrid") == 0 )
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
               gxnrProveedoresgrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Proveedoresgrid") == 0 )
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
               gxgrProveedoresgrid_refresh( AV5buscar, AV7updateImage, AV6deleteImage) ;
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
         PA342( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START342( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022215592519");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallesproveedores.aspx") +"\">") ;
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
            WE342( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT342( ) ;
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
         return formatLink("detallesproveedores.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesProveedores" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Proveedores" ;
      }

      protected void WB340( )
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
            wb_table1_2_342( true) ;
         }
         else
         {
            wb_table1_2_342( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_342e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            ProveedoresgridContainer.SetWrapped(nGXWrapped);
            if ( ProveedoresgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"ProveedoresgridContainer"+"DivS\" data-gxgridid=\"11\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subProveedoresgrid_Internalname, subProveedoresgrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subProveedoresgrid_Backcolorstyle == 0 )
               {
                  subProveedoresgrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subProveedoresgrid_Class) > 0 )
                  {
                     subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Title";
                  }
               }
               else
               {
                  subProveedoresgrid_Titlebackstyle = 1;
                  if ( subProveedoresgrid_Backcolorstyle == 1 )
                  {
                     subProveedoresgrid_Titlebackcolor = subProveedoresgrid_Allbackcolor;
                     if ( StringUtil.Len( subProveedoresgrid_Class) > 0 )
                     {
                        subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subProveedoresgrid_Class) > 0 )
                     {
                        subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "rfc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Direccion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Colonia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo Postal") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Municipio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fax") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tel 1") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tel 2") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subProveedoresgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               ProveedoresgridContainer.AddObjectProperty("GridName", "Proveedoresgrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  ProveedoresgridContainer = new GXWebGrid( context);
               }
               else
               {
                  ProveedoresgridContainer.Clear();
               }
               ProveedoresgridContainer.SetWrapped(nGXWrapped);
               ProveedoresgridContainer.AddObjectProperty("GridName", "Proveedoresgrid");
               ProveedoresgridContainer.AddObjectProperty("Class", "Grid");
               ProveedoresgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Backcolorstyle), 1, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("CmpContext", "");
               ProveedoresgridContainer.AddObjectProperty("InMasterPage", "false");
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A126proveedoresnombre);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A135proveedoresrfc);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A127proveedoresdireccion);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A128proveedorescolonia);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A129proveedorescodigopostal);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A130proveedoresmunicipio);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A131proveedorestado);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", A134proveedoresfax);
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A132proveedorestelefono1), 10, 0, ".", "")));
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A133proveedorestelefono2), 10, 0, ".", "")));
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", context.convertURL( AV7updateImage));
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               ProveedoresgridColumn.AddObjectProperty("Value", context.convertURL( AV6deleteImage));
               ProveedoresgridContainer.AddColumnProperties(ProveedoresgridColumn);
               ProveedoresgridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Allowselection), 1, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Selectioncolor), 9, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Allowhovering), 1, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Hoveringcolor), 9, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Allowcollapsing), 1, 0, ".", "")));
               ProveedoresgridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 11 )
         {
            wbEnd = 0;
            nRC_GXsfl_11 = (short)(nGXsfl_11_idx-1);
            if ( ProveedoresgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"ProveedoresgridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Proveedoresgrid", ProveedoresgridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "ProveedoresgridContainerData", ProveedoresgridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "ProveedoresgridContainerData"+"V", ProveedoresgridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"ProveedoresgridContainerData"+"V"+"\" value='"+ProveedoresgridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true;
      }

      protected void START342( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Proveedores", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP340( ) ;
      }

      protected void WS342( )
      {
         START342( ) ;
         EVT342( ) ;
      }

      protected void EVT342( )
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
                                    /* Execute user event: E11342 */
                                    E11342 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "PROVEEDORESGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                              SubsflControlProps_112( ) ;
                              A2proveedoresid = (int)(context.localUtil.CToN( cgiGet( edtproveedoresid_Internalname), ",", "."));
                              A126proveedoresnombre = cgiGet( edtproveedoresnombre_Internalname);
                              n126proveedoresnombre = false;
                              A135proveedoresrfc = cgiGet( edtproveedoresrfc_Internalname);
                              n135proveedoresrfc = false;
                              A127proveedoresdireccion = cgiGet( edtproveedoresdireccion_Internalname);
                              n127proveedoresdireccion = false;
                              A128proveedorescolonia = cgiGet( edtproveedorescolonia_Internalname);
                              n128proveedorescolonia = false;
                              A129proveedorescodigopostal = cgiGet( edtproveedorescodigopostal_Internalname);
                              n129proveedorescodigopostal = false;
                              A130proveedoresmunicipio = cgiGet( edtproveedoresmunicipio_Internalname);
                              n130proveedoresmunicipio = false;
                              A131proveedorestado = cgiGet( edtproveedorestado_Internalname);
                              n131proveedorestado = false;
                              A134proveedoresfax = cgiGet( edtproveedoresfax_Internalname);
                              n134proveedoresfax = false;
                              A132proveedorestelefono1 = (long)(context.localUtil.CToN( cgiGet( edtproveedorestelefono1_Internalname), ",", "."));
                              n132proveedorestelefono1 = false;
                              A133proveedorestelefono2 = (long)(context.localUtil.CToN( cgiGet( edtproveedorestelefono2_Internalname), ",", "."));
                              n133proveedorestelefono2 = false;
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
                                    /* Execute user event: E12342 */
                                    E12342 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13342 */
                                    E13342 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14342 */
                                    E14342 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "PROVEEDORESGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15342 */
                                    E15342 ();
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

      protected void WE342( )
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

      protected void PA342( )
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

      protected void gxnrProveedoresgrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_112( ) ;
         while ( nGXsfl_11_idx <= nRC_GXsfl_11 )
         {
            sendrow_112( ) ;
            nGXsfl_11_idx = (short)(((subProveedoresgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subProveedoresgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
            sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
            SubsflControlProps_112( ) ;
         }
         context.GX_webresponse.AddString(ProveedoresgridContainer.ToJavascriptSource());
         /* End function gxnrProveedoresgrid_newrow */
      }

      protected void gxgrProveedoresgrid_refresh( String AV5buscar ,
                                                  String AV7updateImage ,
                                                  String AV6deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         PROVEEDORESGRID_nCurrentRecord = 0;
         RF342( ) ;
         /* End function gxgrProveedoresgrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESNOMBRE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESNOMBRE", A126proveedoresnombre);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESRFC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A135proveedoresrfc, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESRFC", A135proveedoresrfc);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESDIRECCION", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A127proveedoresdireccion, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESDIRECCION", A127proveedoresdireccion);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCOLONIA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESCOLONIA", A128proveedorescolonia);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCODIGOPOSTAL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A129proveedorescodigopostal, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESCODIGOPOSTAL", A129proveedorescodigopostal);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESMUNICIPIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A130proveedoresmunicipio, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESMUNICIPIO", A130proveedoresmunicipio);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTADO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A131proveedorestado, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESTADO", A131proveedorestado);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESFAX", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A134proveedoresfax, ""))));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESFAX", A134proveedoresfax);
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTELEFONO1", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A132proveedorestelefono1), "ZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESTELEFONO1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A132proveedorestelefono1), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTELEFONO2", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A133proveedorestelefono2), "ZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "PROVEEDORESTELEFONO2", StringUtil.LTrim( StringUtil.NToC( (decimal)(A133proveedorestelefono2), 10, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF342( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF342( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            ProveedoresgridContainer.ClearRows();
         }
         wbStart = 11;
         nGXsfl_11_idx = 1;
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         nGXsfl_11_Refreshing = 1;
         ProveedoresgridContainer.AddObjectProperty("GridName", "Proveedoresgrid");
         ProveedoresgridContainer.AddObjectProperty("CmpContext", "");
         ProveedoresgridContainer.AddObjectProperty("InMasterPage", "false");
         ProveedoresgridContainer.AddObjectProperty("Class", "Grid");
         ProveedoresgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         ProveedoresgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         ProveedoresgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subProveedoresgrid_Backcolorstyle), 1, 0, ".", "")));
         ProveedoresgridContainer.PageSize = subProveedoresgrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_112( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H00342 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A133proveedorestelefono2 = H00342_A133proveedorestelefono2[0];
               n133proveedorestelefono2 = H00342_n133proveedorestelefono2[0];
               A132proveedorestelefono1 = H00342_A132proveedorestelefono1[0];
               n132proveedorestelefono1 = H00342_n132proveedorestelefono1[0];
               A134proveedoresfax = H00342_A134proveedoresfax[0];
               n134proveedoresfax = H00342_n134proveedoresfax[0];
               A131proveedorestado = H00342_A131proveedorestado[0];
               n131proveedorestado = H00342_n131proveedorestado[0];
               A130proveedoresmunicipio = H00342_A130proveedoresmunicipio[0];
               n130proveedoresmunicipio = H00342_n130proveedoresmunicipio[0];
               A129proveedorescodigopostal = H00342_A129proveedorescodigopostal[0];
               n129proveedorescodigopostal = H00342_n129proveedorescodigopostal[0];
               A128proveedorescolonia = H00342_A128proveedorescolonia[0];
               n128proveedorescolonia = H00342_n128proveedorescolonia[0];
               A127proveedoresdireccion = H00342_A127proveedoresdireccion[0];
               n127proveedoresdireccion = H00342_n127proveedoresdireccion[0];
               A135proveedoresrfc = H00342_A135proveedoresrfc[0];
               n135proveedoresrfc = H00342_n135proveedoresrfc[0];
               A126proveedoresnombre = H00342_A126proveedoresnombre[0];
               n126proveedoresnombre = H00342_n126proveedoresnombre[0];
               A2proveedoresid = H00342_A2proveedoresid[0];
               /* Execute user event: E15342 */
               E15342 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 11;
            WB340( ) ;
         }
         nGXsfl_11_Refreshing = 0;
      }

      protected int subProveedoresgrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subProveedoresgrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subProveedoresgrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subProveedoresgrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP340( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E12342 */
         E12342 ();
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
         /* Execute user event: E12342 */
         E12342 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12342( )
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

      protected void E13342( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("proveedores.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A2proveedoresid);
         context.wjLocDisableFrm = 1;
      }

      protected void E14342( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("proveedores.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A2proveedoresid);
         context.wjLocDisableFrm = 1;
      }

      public void GXEnter( )
      {
         /* Execute user event: E11342 */
         E11342 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11342( )
      {
         /* Enter Routine */
         context.wjLoc = formatLink("catalog_de_proveedor.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      private void E15342( )
      {
         /* Proveedoresgrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 11;
         }
         sendrow_112( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_11_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(11, ProveedoresgridRow);
         }
      }

      protected void wb_table1_2_342( bool wbgen )
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
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetallesProveedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:794px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalles Proveedores", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#000000;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetallesProveedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:796px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#80FF80;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(11), 2, 0)+","+"null"+");", "Agregar", bttButton1_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesProveedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_342e( true) ;
         }
         else
         {
            wb_table1_2_342e( false) ;
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
         PA342( ) ;
         WS342( ) ;
         WE342( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022215592539");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallesproveedores.js", "?2022215592539");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_112( )
      {
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_11_idx;
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE_"+sGXsfl_11_idx;
         edtproveedoresrfc_Internalname = "PROVEEDORESRFC_"+sGXsfl_11_idx;
         edtproveedoresdireccion_Internalname = "PROVEEDORESDIRECCION_"+sGXsfl_11_idx;
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA_"+sGXsfl_11_idx;
         edtproveedorescodigopostal_Internalname = "PROVEEDORESCODIGOPOSTAL_"+sGXsfl_11_idx;
         edtproveedoresmunicipio_Internalname = "PROVEEDORESMUNICIPIO_"+sGXsfl_11_idx;
         edtproveedorestado_Internalname = "PROVEEDORESTADO_"+sGXsfl_11_idx;
         edtproveedoresfax_Internalname = "PROVEEDORESFAX_"+sGXsfl_11_idx;
         edtproveedorestelefono1_Internalname = "PROVEEDORESTELEFONO1_"+sGXsfl_11_idx;
         edtproveedorestelefono2_Internalname = "PROVEEDORESTELEFONO2_"+sGXsfl_11_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_idx;
      }

      protected void SubsflControlProps_fel_112( )
      {
         edtproveedoresid_Internalname = "PROVEEDORESID_"+sGXsfl_11_fel_idx;
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE_"+sGXsfl_11_fel_idx;
         edtproveedoresrfc_Internalname = "PROVEEDORESRFC_"+sGXsfl_11_fel_idx;
         edtproveedoresdireccion_Internalname = "PROVEEDORESDIRECCION_"+sGXsfl_11_fel_idx;
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA_"+sGXsfl_11_fel_idx;
         edtproveedorescodigopostal_Internalname = "PROVEEDORESCODIGOPOSTAL_"+sGXsfl_11_fel_idx;
         edtproveedoresmunicipio_Internalname = "PROVEEDORESMUNICIPIO_"+sGXsfl_11_fel_idx;
         edtproveedorestado_Internalname = "PROVEEDORESTADO_"+sGXsfl_11_fel_idx;
         edtproveedoresfax_Internalname = "PROVEEDORESFAX_"+sGXsfl_11_fel_idx;
         edtproveedorestelefono1_Internalname = "PROVEEDORESTELEFONO1_"+sGXsfl_11_fel_idx;
         edtproveedorestelefono2_Internalname = "PROVEEDORESTELEFONO2_"+sGXsfl_11_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_fel_idx;
      }

      protected void sendrow_112( )
      {
         SubsflControlProps_112( ) ;
         WB340( ) ;
         ProveedoresgridRow = GXWebRow.GetNew(context,ProveedoresgridContainer);
         if ( subProveedoresgrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subProveedoresgrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subProveedoresgrid_Class, "") != 0 )
            {
               subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Odd";
            }
         }
         else if ( subProveedoresgrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subProveedoresgrid_Backstyle = 0;
            subProveedoresgrid_Backcolor = subProveedoresgrid_Allbackcolor;
            if ( StringUtil.StrCmp(subProveedoresgrid_Class, "") != 0 )
            {
               subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Uniform";
            }
         }
         else if ( subProveedoresgrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subProveedoresgrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subProveedoresgrid_Class, "") != 0 )
            {
               subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Odd";
            }
            subProveedoresgrid_Backcolor = (int)(0x0);
         }
         else if ( subProveedoresgrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subProveedoresgrid_Backstyle = 1;
            if ( ((int)((nGXsfl_11_idx) % (2))) == 0 )
            {
               subProveedoresgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subProveedoresgrid_Class, "") != 0 )
               {
                  subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Even";
               }
            }
            else
            {
               subProveedoresgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subProveedoresgrid_Class, "") != 0 )
               {
                  subProveedoresgrid_Linesclass = subProveedoresgrid_Class+"Odd";
               }
            }
         }
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subProveedoresgrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_11_idx+"\">") ;
         }
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2proveedoresid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"left",(bool)false});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresnombre_Internalname,(String)A126proveedoresnombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresnombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresrfc_Internalname,(String)A135proveedoresrfc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresrfc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresdireccion_Internalname,(String)A127proveedoresdireccion,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresdireccion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorescolonia_Internalname,(String)A128proveedorescolonia,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorescolonia_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)25,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorescodigopostal_Internalname,(String)A129proveedorescodigopostal,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorescodigopostal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresmunicipio_Internalname,(String)A130proveedoresmunicipio,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresmunicipio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)25,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorestado_Internalname,(String)A131proveedorestado,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorestado_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedoresfax_Internalname,(String)A134proveedoresfax,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedoresfax_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorestelefono1_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A132proveedorestelefono1), 10, 0, ",", "")),context.localUtil.Format( (decimal)(A132proveedorestelefono1), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorestelefono1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         ProveedoresgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtproveedorestelefono2_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A133proveedorestelefono2), 10, 0, ",", "")),context.localUtil.Format( (decimal)(A133proveedorestelefono2), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtproveedorestelefono2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 23,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)));
         ProveedoresgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV7updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( ProveedoresgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 24,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)));
         ProveedoresgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV6deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A2proveedoresid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESNOMBRE"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A126proveedoresnombre, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESRFC"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A135proveedoresrfc, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESDIRECCION"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A127proveedoresdireccion, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCOLONIA"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A128proveedorescolonia, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESCODIGOPOSTAL"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A129proveedorescodigopostal, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESMUNICIPIO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A130proveedoresmunicipio, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTADO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A131proveedorestado, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESFAX"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A134proveedoresfax, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTELEFONO1"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A132proveedorestelefono1), "ZZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_PROVEEDORESTELEFONO2"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A133proveedorestelefono2), "ZZZZZZZZZ9")));
         ProveedoresgridContainer.AddRow(ProveedoresgridRow);
         nGXsfl_11_idx = (short)(((subProveedoresgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subProveedoresgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
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
         edtproveedoresid_Internalname = "PROVEEDORESID";
         edtproveedoresnombre_Internalname = "PROVEEDORESNOMBRE";
         edtproveedoresrfc_Internalname = "PROVEEDORESRFC";
         edtproveedoresdireccion_Internalname = "PROVEEDORESDIRECCION";
         edtproveedorescolonia_Internalname = "PROVEEDORESCOLONIA";
         edtproveedorescodigopostal_Internalname = "PROVEEDORESCODIGOPOSTAL";
         edtproveedoresmunicipio_Internalname = "PROVEEDORESMUNICIPIO";
         edtproveedorestado_Internalname = "PROVEEDORESTADO";
         edtproveedoresfax_Internalname = "PROVEEDORESFAX";
         edtproveedorestelefono1_Internalname = "PROVEEDORESTELEFONO1";
         edtproveedorestelefono2_Internalname = "PROVEEDORESTELEFONO2";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subProveedoresgrid_Internalname = "PROVEEDORESGRID";
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
         edtproveedorestelefono2_Jsonclick = "";
         edtproveedorestelefono1_Jsonclick = "";
         edtproveedoresfax_Jsonclick = "";
         edtproveedorestado_Jsonclick = "";
         edtproveedoresmunicipio_Jsonclick = "";
         edtproveedorescodigopostal_Jsonclick = "";
         edtproveedorescolonia_Jsonclick = "";
         edtproveedoresdireccion_Jsonclick = "";
         edtproveedoresrfc_Jsonclick = "";
         edtproveedoresnombre_Jsonclick = "";
         edtproveedoresid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subProveedoresgrid_Allowcollapsing = 0;
         subProveedoresgrid_Allowselection = 0;
         subProveedoresgrid_Class = "Grid";
         subProveedoresgrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Proveedores";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'PROVEEDORESGRID_nFirstRecordOnPage',nv:0},{av:'PROVEEDORESGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV7updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV6deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E13342',iparms:[{av:'A2proveedoresid',fld:'PROVEEDORESID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E14342',iparms:[{av:'A2proveedoresid',fld:'PROVEEDORESID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E11342',iparms:[],oparms:[]}");
         setEventMetadata("PROVEEDORESGRID.LOAD","{handler:'E15342',iparms:[],oparms:[]}");
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
         ProveedoresgridContainer = new GXWebGrid( context);
         sStyleString = "";
         subProveedoresgrid_Linesclass = "";
         ProveedoresgridColumn = new GXWebColumn();
         A126proveedoresnombre = "";
         A135proveedoresrfc = "";
         A127proveedoresdireccion = "";
         A128proveedorescolonia = "";
         A129proveedorescodigopostal = "";
         A130proveedoresmunicipio = "";
         A131proveedorestado = "";
         A134proveedoresfax = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H00342_A133proveedorestelefono2 = new long[1] ;
         H00342_n133proveedorestelefono2 = new bool[] {false} ;
         H00342_A132proveedorestelefono1 = new long[1] ;
         H00342_n132proveedorestelefono1 = new bool[] {false} ;
         H00342_A134proveedoresfax = new String[] {""} ;
         H00342_n134proveedoresfax = new bool[] {false} ;
         H00342_A131proveedorestado = new String[] {""} ;
         H00342_n131proveedorestado = new bool[] {false} ;
         H00342_A130proveedoresmunicipio = new String[] {""} ;
         H00342_n130proveedoresmunicipio = new bool[] {false} ;
         H00342_A129proveedorescodigopostal = new String[] {""} ;
         H00342_n129proveedorescodigopostal = new bool[] {false} ;
         H00342_A128proveedorescolonia = new String[] {""} ;
         H00342_n128proveedorescolonia = new bool[] {false} ;
         H00342_A127proveedoresdireccion = new String[] {""} ;
         H00342_n127proveedoresdireccion = new bool[] {false} ;
         H00342_A135proveedoresrfc = new String[] {""} ;
         H00342_n135proveedoresrfc = new bool[] {false} ;
         H00342_A126proveedoresnombre = new String[] {""} ;
         H00342_n126proveedoresnombre = new bool[] {false} ;
         H00342_A2proveedoresid = new int[1] ;
         ProveedoresgridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallesproveedores__default(),
            new Object[][] {
                new Object[] {
               H00342_A133proveedorestelefono2, H00342_n133proveedorestelefono2, H00342_A132proveedorestelefono1, H00342_n132proveedorestelefono1, H00342_A134proveedoresfax, H00342_n134proveedoresfax, H00342_A131proveedorestado, H00342_n131proveedorestado, H00342_A130proveedoresmunicipio, H00342_n130proveedoresmunicipio,
               H00342_A129proveedorescodigopostal, H00342_n129proveedorescodigopostal, H00342_A128proveedorescolonia, H00342_n128proveedorescolonia, H00342_A127proveedoresdireccion, H00342_n127proveedoresdireccion, H00342_A135proveedoresrfc, H00342_n135proveedoresrfc, H00342_A126proveedoresnombre, H00342_n126proveedoresnombre,
               H00342_A2proveedoresid
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
      private short subProveedoresgrid_Backcolorstyle ;
      private short subProveedoresgrid_Titlebackstyle ;
      private short subProveedoresgrid_Allowselection ;
      private short subProveedoresgrid_Allowhovering ;
      private short subProveedoresgrid_Allowcollapsing ;
      private short subProveedoresgrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_11_Refreshing=0 ;
      private short nGXWrapped ;
      private short subProveedoresgrid_Backstyle ;
      private short PROVEEDORESGRID_nEOF ;
      private int subProveedoresgrid_Titlebackcolor ;
      private int subProveedoresgrid_Allbackcolor ;
      private int A2proveedoresid ;
      private int subProveedoresgrid_Selectioncolor ;
      private int subProveedoresgrid_Hoveringcolor ;
      private int subProveedoresgrid_Islastpage ;
      private int idxLst ;
      private int subProveedoresgrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long A132proveedorestelefono1 ;
      private long A133proveedorestelefono2 ;
      private long PROVEEDORESGRID_nCurrentRecord ;
      private long PROVEEDORESGRID_nFirstRecordOnPage ;
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
      private String subProveedoresgrid_Internalname ;
      private String subProveedoresgrid_Class ;
      private String subProveedoresgrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtproveedoresid_Internalname ;
      private String edtproveedoresnombre_Internalname ;
      private String edtproveedoresrfc_Internalname ;
      private String edtproveedoresdireccion_Internalname ;
      private String edtproveedorescolonia_Internalname ;
      private String edtproveedorescodigopostal_Internalname ;
      private String edtproveedoresmunicipio_Internalname ;
      private String edtproveedorestado_Internalname ;
      private String edtproveedoresfax_Internalname ;
      private String edtproveedorestelefono1_Internalname ;
      private String edtproveedorestelefono2_Internalname ;
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
      private String edtproveedoresid_Jsonclick ;
      private String edtproveedoresnombre_Jsonclick ;
      private String edtproveedoresrfc_Jsonclick ;
      private String edtproveedoresdireccion_Jsonclick ;
      private String edtproveedorescolonia_Jsonclick ;
      private String edtproveedorescodigopostal_Jsonclick ;
      private String edtproveedoresmunicipio_Jsonclick ;
      private String edtproveedorestado_Jsonclick ;
      private String edtproveedoresfax_Jsonclick ;
      private String edtproveedorestelefono1_Jsonclick ;
      private String edtproveedorestelefono2_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n126proveedoresnombre ;
      private bool n135proveedoresrfc ;
      private bool n127proveedoresdireccion ;
      private bool n128proveedorescolonia ;
      private bool n129proveedorescodigopostal ;
      private bool n130proveedoresmunicipio ;
      private bool n131proveedorestado ;
      private bool n134proveedoresfax ;
      private bool n132proveedorestelefono1 ;
      private bool n133proveedorestelefono2 ;
      private bool returnInSub ;
      private bool AV7updateImage_IsBlob ;
      private bool AV6deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A126proveedoresnombre ;
      private String A135proveedoresrfc ;
      private String A127proveedoresdireccion ;
      private String A128proveedorescolonia ;
      private String A129proveedorescodigopostal ;
      private String A130proveedoresmunicipio ;
      private String A131proveedorestado ;
      private String A134proveedoresfax ;
      private String AV7updateImage ;
      private String AV6deleteImage ;
      private GXWebGrid ProveedoresgridContainer ;
      private GXWebRow ProveedoresgridRow ;
      private GXWebColumn ProveedoresgridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00342_A133proveedorestelefono2 ;
      private bool[] H00342_n133proveedorestelefono2 ;
      private long[] H00342_A132proveedorestelefono1 ;
      private bool[] H00342_n132proveedorestelefono1 ;
      private String[] H00342_A134proveedoresfax ;
      private bool[] H00342_n134proveedoresfax ;
      private String[] H00342_A131proveedorestado ;
      private bool[] H00342_n131proveedorestado ;
      private String[] H00342_A130proveedoresmunicipio ;
      private bool[] H00342_n130proveedoresmunicipio ;
      private String[] H00342_A129proveedorescodigopostal ;
      private bool[] H00342_n129proveedorescodigopostal ;
      private String[] H00342_A128proveedorescolonia ;
      private bool[] H00342_n128proveedorescolonia ;
      private String[] H00342_A127proveedoresdireccion ;
      private bool[] H00342_n127proveedoresdireccion ;
      private String[] H00342_A135proveedoresrfc ;
      private bool[] H00342_n135proveedoresrfc ;
      private String[] H00342_A126proveedoresnombre ;
      private bool[] H00342_n126proveedoresnombre ;
      private int[] H00342_A2proveedoresid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallesproveedores__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00342 ;
          prmH00342 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00342", "SELECT proveedorestelefono2, proveedorestelefono1, proveedoresfax, proveedorestado, proveedoresmunicipio, proveedorescodigopostal, proveedorescolonia, proveedoresdireccion, proveedoresrfc, proveedoresnombre, proveedoresid FROM public.proveedores WHERE proveedoresnombre like :lV5buscar ORDER BY proveedoresid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00342,11,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((int[]) buf[20])[0] = rslt.getInt(11) ;
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
