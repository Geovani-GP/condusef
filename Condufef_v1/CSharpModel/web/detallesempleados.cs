/*
               File: DetallesEmpleados
        Description: Detalles Empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:37.97
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
   public class detallesempleados : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public detallesempleados( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public detallesempleados( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Empleadosgrid") == 0 )
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
               gxnrEmpleadosgrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Empleadosgrid") == 0 )
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
               gxgrEmpleadosgrid_refresh( AV5buscar, AV7updateImage, AV6deleteImage) ;
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
         PA352( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START352( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20223310193799");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" novalidate action=\""+formatLink("detallesempleados.aspx") +"\">") ;
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
            WE352( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT352( ) ;
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
         return formatLink("detallesempleados.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DetallesEmpleados" ;
      }

      public override String GetPgmdesc( )
      {
         return "Detalles Empleados" ;
      }

      protected void WB350( )
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
            wb_table1_2_352( true) ;
         }
         else
         {
            wb_table1_2_352( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_352e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p>") ;
            /*  Grid Control  */
            EmpleadosgridContainer.SetWrapped(nGXWrapped);
            if ( EmpleadosgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"EmpleadosgridContainer"+"DivS\" data-gxgridid=\"11\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subEmpleadosgrid_Internalname, subEmpleadosgrid_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subEmpleadosgrid_Backcolorstyle == 0 )
               {
                  subEmpleadosgrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subEmpleadosgrid_Class) > 0 )
                  {
                     subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Title";
                  }
               }
               else
               {
                  subEmpleadosgrid_Titlebackstyle = 1;
                  if ( subEmpleadosgrid_Backcolorstyle == 1 )
                  {
                     subEmpleadosgrid_Titlebackcolor = subEmpleadosgrid_Allbackcolor;
                     if ( StringUtil.Len( subEmpleadosgrid_Class) > 0 )
                     {
                        subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subEmpleadosgrid_Class) > 0 )
                     {
                        subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Area") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Apellido Paterno") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Apellido materno") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Status") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Correo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ext") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subEmpleadosgrid_Linesclass+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               EmpleadosgridContainer.AddObjectProperty("GridName", "Empleadosgrid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  EmpleadosgridContainer = new GXWebGrid( context);
               }
               else
               {
                  EmpleadosgridContainer.Clear();
               }
               EmpleadosgridContainer.SetWrapped(nGXWrapped);
               EmpleadosgridContainer.AddObjectProperty("GridName", "Empleadosgrid");
               EmpleadosgridContainer.AddObjectProperty("Class", "Grid");
               EmpleadosgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Backcolorstyle), 1, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("CmpContext", "");
               EmpleadosgridContainer.AddObjectProperty("InMasterPage", "false");
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A98empleadosareaid);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A99empleadosnomemple);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A100empleadosappaterno);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A101empleadosapmaterno);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A102empleadosstatus);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A106empleadoscorreo);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", A107empleadosext);
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", context.convertURL( AV7updateImage));
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               EmpleadosgridColumn.AddObjectProperty("Value", context.convertURL( AV6deleteImage));
               EmpleadosgridContainer.AddColumnProperties(EmpleadosgridColumn);
               EmpleadosgridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Allowselection), 1, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Selectioncolor), 9, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Allowhovering), 1, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Hoveringcolor), 9, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Allowcollapsing), 1, 0, ".", "")));
               EmpleadosgridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 11 )
         {
            wbEnd = 0;
            nRC_GXsfl_11 = (short)(nGXsfl_11_idx-1);
            if ( EmpleadosgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"EmpleadosgridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Empleadosgrid", EmpleadosgridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EmpleadosgridContainerData", EmpleadosgridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "EmpleadosgridContainerData"+"V", EmpleadosgridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"EmpleadosgridContainerData"+"V"+"\" value='"+EmpleadosgridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true;
      }

      protected void START352( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_15-115824", 0) ;
            Form.Meta.addItem("description", "Detalles Empleados", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP350( ) ;
      }

      protected void WS352( )
      {
         START352( ) ;
         EVT352( ) ;
      }

      protected void EVT352( )
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
                                    /* Execute user event: E11352 */
                                    E11352 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "EMPLEADOSGRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VUPDATEIMAGE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "VDELETEIMAGE.CLICK") == 0 ) )
                           {
                              nGXsfl_11_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
                              SubsflControlProps_112( ) ;
                              A13empleadosid = (int)(context.localUtil.CToN( cgiGet( edtempleadosid_Internalname), ",", "."));
                              A98empleadosareaid = cgiGet( edtempleadosareaid_Internalname);
                              n98empleadosareaid = false;
                              A99empleadosnomemple = cgiGet( edtempleadosnomemple_Internalname);
                              n99empleadosnomemple = false;
                              A100empleadosappaterno = cgiGet( edtempleadosappaterno_Internalname);
                              n100empleadosappaterno = false;
                              A101empleadosapmaterno = cgiGet( edtempleadosapmaterno_Internalname);
                              n101empleadosapmaterno = false;
                              A102empleadosstatus = cgiGet( edtempleadosstatus_Internalname);
                              n102empleadosstatus = false;
                              A106empleadoscorreo = cgiGet( edtempleadoscorreo_Internalname);
                              n106empleadoscorreo = false;
                              A107empleadosext = cgiGet( edtempleadosext_Internalname);
                              n107empleadosext = false;
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
                                    /* Execute user event: E12352 */
                                    E12352 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13352 */
                                    E13352 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETEIMAGE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14352 */
                                    E14352 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "EMPLEADOSGRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15352 */
                                    E15352 ();
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

      protected void WE352( )
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

      protected void PA352( )
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

      protected void gxnrEmpleadosgrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_112( ) ;
         while ( nGXsfl_11_idx <= nRC_GXsfl_11 )
         {
            sendrow_112( ) ;
            nGXsfl_11_idx = (short)(((subEmpleadosgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subEmpleadosgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
            sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
            SubsflControlProps_112( ) ;
         }
         context.GX_webresponse.AddString(EmpleadosgridContainer.ToJavascriptSource());
         /* End function gxnrEmpleadosgrid_newrow */
      }

      protected void gxgrEmpleadosgrid_refresh( String AV5buscar ,
                                                String AV7updateImage ,
                                                String AV6deleteImage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         EMPLEADOSGRID_nCurrentRecord = 0;
         RF352( ) ;
         /* End function gxgrEmpleadosgrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAREAID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A98empleadosareaid, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAREAID", A98empleadosareaid);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSNOMEMPLE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A99empleadosnomemple, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSNOMEMPLE", A99empleadosnomemple);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPPATERNO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A100empleadosappaterno, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPPATERNO", A100empleadosappaterno);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPMATERNO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A101empleadosapmaterno, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSAPMATERNO", A101empleadosapmaterno);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSSTATUS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A102empleadosstatus, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSSTATUS", A102empleadosstatus);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSCORREO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A106empleadoscorreo, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSCORREO", A106empleadoscorreo);
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSEXT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A107empleadosext, ""))));
         GxWebStd.gx_hidden_field( context, "EMPLEADOSEXT", A107empleadosext);
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF352( ) ;
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF352( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            EmpleadosgridContainer.ClearRows();
         }
         wbStart = 11;
         nGXsfl_11_idx = 1;
         sGXsfl_11_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_11_idx), 4, 0)), 4, "0");
         SubsflControlProps_112( ) ;
         nGXsfl_11_Refreshing = 1;
         EmpleadosgridContainer.AddObjectProperty("GridName", "Empleadosgrid");
         EmpleadosgridContainer.AddObjectProperty("CmpContext", "");
         EmpleadosgridContainer.AddObjectProperty("InMasterPage", "false");
         EmpleadosgridContainer.AddObjectProperty("Class", "Grid");
         EmpleadosgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         EmpleadosgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         EmpleadosgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subEmpleadosgrid_Backcolorstyle), 1, 0, ".", "")));
         EmpleadosgridContainer.PageSize = subEmpleadosgrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_112( ) ;
            lV5buscar = StringUtil.PadR( StringUtil.RTrim( AV5buscar), 20, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5buscar", AV5buscar);
            /* Using cursor H00352 */
            pr_default.execute(0, new Object[] {lV5buscar});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A107empleadosext = H00352_A107empleadosext[0];
               n107empleadosext = H00352_n107empleadosext[0];
               A106empleadoscorreo = H00352_A106empleadoscorreo[0];
               n106empleadoscorreo = H00352_n106empleadoscorreo[0];
               A102empleadosstatus = H00352_A102empleadosstatus[0];
               n102empleadosstatus = H00352_n102empleadosstatus[0];
               A101empleadosapmaterno = H00352_A101empleadosapmaterno[0];
               n101empleadosapmaterno = H00352_n101empleadosapmaterno[0];
               A100empleadosappaterno = H00352_A100empleadosappaterno[0];
               n100empleadosappaterno = H00352_n100empleadosappaterno[0];
               A99empleadosnomemple = H00352_A99empleadosnomemple[0];
               n99empleadosnomemple = H00352_n99empleadosnomemple[0];
               A98empleadosareaid = H00352_A98empleadosareaid[0];
               n98empleadosareaid = H00352_n98empleadosareaid[0];
               A13empleadosid = H00352_A13empleadosid[0];
               /* Execute user event: E15352 */
               E15352 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 11;
            WB350( ) ;
         }
         nGXsfl_11_Refreshing = 0;
      }

      protected int subEmpleadosgrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subEmpleadosgrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subEmpleadosgrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subEmpleadosgrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP350( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E12352 */
         E12352 ();
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
         /* Execute user event: E12352 */
         E12352 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12352( )
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

      protected void E13352( )
      {
         /* Updateimage_Click Routine */
         context.wjLoc = formatLink("empleados.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A13empleadosid);
         context.wjLocDisableFrm = 1;
      }

      protected void E14352( )
      {
         /* Deleteimage_Click Routine */
         context.wjLoc = formatLink("empleados.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A13empleadosid);
         context.wjLocDisableFrm = 1;
      }

      public void GXEnter( )
      {
         /* Execute user event: E11352 */
         E11352 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11352( )
      {
         /* Enter Routine */
         context.wjLoc = formatLink("catalog_de_empleados.aspx") ;
         context.wjLocDisableFrm = 1;
      }

      private void E15352( )
      {
         /* Empleadosgrid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 11;
         }
         sendrow_112( ) ;
         if ( isFullAjaxMode( ) && ( nGXsfl_11_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(11, EmpleadosgridRow);
         }
      }

      protected void wb_table1_2_352( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(50), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(1006), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:391px")+"\">") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'" + sGXsfl_11_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBuscar_Internalname, StringUtil.RTrim( AV5buscar), StringUtil.RTrim( context.localUtil.Format( AV5buscar, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(this,5);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBuscar_Jsonclick, 0, "Attribute", "", "", "", 1, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DetallesEmpleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:579px")+"\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Detalles Empleados", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "font-family:'Microsoft Sans Serif'; font-size:24.0pt; font-weight:bold; font-style:normal; color:#000000; background-color:#FFFFFF;", "TextBlock", 0, "", 1, 1, 0, "HLP_DetallesEmpleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:827px")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "background-color:#00FF00;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(11), 2, 0)+","+"null"+");", "Agregar", bttButton1_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DetallesEmpleados.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_352e( true) ;
         }
         else
         {
            wb_table1_2_352e( false) ;
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
         PA352( ) ;
         WS352( ) ;
         WE352( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20223310193814");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+context.GetBuildNumber( 115824));
         context.AddJavascriptSource("detallesempleados.js", "?20223310193814");
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_112( )
      {
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_11_idx;
         edtempleadosareaid_Internalname = "EMPLEADOSAREAID_"+sGXsfl_11_idx;
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE_"+sGXsfl_11_idx;
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO_"+sGXsfl_11_idx;
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO_"+sGXsfl_11_idx;
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS_"+sGXsfl_11_idx;
         edtempleadoscorreo_Internalname = "EMPLEADOSCORREO_"+sGXsfl_11_idx;
         edtempleadosext_Internalname = "EMPLEADOSEXT_"+sGXsfl_11_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_idx;
      }

      protected void SubsflControlProps_fel_112( )
      {
         edtempleadosid_Internalname = "EMPLEADOSID_"+sGXsfl_11_fel_idx;
         edtempleadosareaid_Internalname = "EMPLEADOSAREAID_"+sGXsfl_11_fel_idx;
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE_"+sGXsfl_11_fel_idx;
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO_"+sGXsfl_11_fel_idx;
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO_"+sGXsfl_11_fel_idx;
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS_"+sGXsfl_11_fel_idx;
         edtempleadoscorreo_Internalname = "EMPLEADOSCORREO_"+sGXsfl_11_fel_idx;
         edtempleadosext_Internalname = "EMPLEADOSEXT_"+sGXsfl_11_fel_idx;
         edtavUpdateimage_Internalname = "vUPDATEIMAGE_"+sGXsfl_11_fel_idx;
         edtavDeleteimage_Internalname = "vDELETEIMAGE_"+sGXsfl_11_fel_idx;
      }

      protected void sendrow_112( )
      {
         SubsflControlProps_112( ) ;
         WB350( ) ;
         EmpleadosgridRow = GXWebRow.GetNew(context,EmpleadosgridContainer);
         if ( subEmpleadosgrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subEmpleadosgrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subEmpleadosgrid_Class, "") != 0 )
            {
               subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Odd";
            }
         }
         else if ( subEmpleadosgrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subEmpleadosgrid_Backstyle = 0;
            subEmpleadosgrid_Backcolor = subEmpleadosgrid_Allbackcolor;
            if ( StringUtil.StrCmp(subEmpleadosgrid_Class, "") != 0 )
            {
               subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Uniform";
            }
         }
         else if ( subEmpleadosgrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subEmpleadosgrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subEmpleadosgrid_Class, "") != 0 )
            {
               subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Odd";
            }
            subEmpleadosgrid_Backcolor = (int)(0x0);
         }
         else if ( subEmpleadosgrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subEmpleadosgrid_Backstyle = 1;
            if ( ((int)((nGXsfl_11_idx) % (2))) == 0 )
            {
               subEmpleadosgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEmpleadosgrid_Class, "") != 0 )
               {
                  subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Even";
               }
            }
            else
            {
               subEmpleadosgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subEmpleadosgrid_Class, "") != 0 )
               {
                  subEmpleadosgrid_Linesclass = subEmpleadosgrid_Class+"Odd";
               }
            }
         }
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subEmpleadosgrid_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_11_idx+"\">") ;
         }
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13empleadosid), 9, 0, ",", "")),context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"left",(bool)false});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosareaid_Internalname,(String)A98empleadosareaid,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosareaid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosnomemple_Internalname,(String)A99empleadosnomemple,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosnomemple_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosappaterno_Internalname,(String)A100empleadosappaterno,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosappaterno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosapmaterno_Internalname,(String)A101empleadosapmaterno,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosapmaterno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosstatus_Internalname,(String)A102empleadosstatus,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosstatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadoscorreo_Internalname,(String)A106empleadoscorreo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadoscorreo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         EmpleadosgridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempleadosext_Internalname,(String)A107empleadosext,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempleadosext_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)11,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavUpdateimage_Enabled!=0)&&(edtavUpdateimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 20,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV7updateImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV10Updateimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)));
         EmpleadosgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV7updateImage)) ? AV10Updateimage_GXI : context.PathToRelativeUrl( AV7updateImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdateimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUPDATEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV7updateImage_IsBlob,(bool)false});
         /* Subfile cell */
         if ( EmpleadosgridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteimage_Enabled!=0)&&(edtavDeleteimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 21,'',false,'',11)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV6deleteImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV11Deleteimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)));
         EmpleadosgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteimage_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV6deleteImage)) ? AV11Deleteimage_GXI : context.PathToRelativeUrl( AV6deleteImage)),(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeleteimage_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVDELETEIMAGE.CLICK."+sGXsfl_11_idx+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6deleteImage_IsBlob,(bool)false});
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, context.localUtil.Format( (decimal)(A13empleadosid), "ZZZZZZZZ9")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAREAID"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A98empleadosareaid, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSNOMEMPLE"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A99empleadosnomemple, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPPATERNO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A100empleadosappaterno, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSAPMATERNO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A101empleadosapmaterno, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSSTATUS"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A102empleadosstatus, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSCORREO"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A106empleadoscorreo, ""))));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPLEADOSEXT"+"_"+sGXsfl_11_idx, GetSecureSignedToken( sGXsfl_11_idx, StringUtil.RTrim( context.localUtil.Format( A107empleadosext, ""))));
         EmpleadosgridContainer.AddRow(EmpleadosgridRow);
         nGXsfl_11_idx = (short)(((subEmpleadosgrid_Islastpage==1)&&(nGXsfl_11_idx+1>subEmpleadosgrid_Recordsperpage( )) ? 1 : nGXsfl_11_idx+1));
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
         edtempleadosid_Internalname = "EMPLEADOSID";
         edtempleadosareaid_Internalname = "EMPLEADOSAREAID";
         edtempleadosnomemple_Internalname = "EMPLEADOSNOMEMPLE";
         edtempleadosappaterno_Internalname = "EMPLEADOSAPPATERNO";
         edtempleadosapmaterno_Internalname = "EMPLEADOSAPMATERNO";
         edtempleadosstatus_Internalname = "EMPLEADOSSTATUS";
         edtempleadoscorreo_Internalname = "EMPLEADOSCORREO";
         edtempleadosext_Internalname = "EMPLEADOSEXT";
         edtavUpdateimage_Internalname = "vUPDATEIMAGE";
         edtavDeleteimage_Internalname = "vDELETEIMAGE";
         Form.Internalname = "FORM";
         subEmpleadosgrid_Internalname = "EMPLEADOSGRID";
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
         edtempleadosext_Jsonclick = "";
         edtempleadoscorreo_Jsonclick = "";
         edtempleadosstatus_Jsonclick = "";
         edtempleadosapmaterno_Jsonclick = "";
         edtempleadosappaterno_Jsonclick = "";
         edtempleadosnomemple_Jsonclick = "";
         edtempleadosareaid_Jsonclick = "";
         edtempleadosid_Jsonclick = "";
         edtavBuscar_Jsonclick = "";
         subEmpleadosgrid_Allowcollapsing = 0;
         subEmpleadosgrid_Allowselection = 0;
         subEmpleadosgrid_Class = "Grid";
         subEmpleadosgrid_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Detalles Empleados";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'EMPLEADOSGRID_nFirstRecordOnPage',nv:0},{av:'EMPLEADOSGRID_nEOF',nv:0},{av:'AV5buscar',fld:'vBUSCAR',pic:'',nv:''},{av:'AV7updateImage',fld:'vUPDATEIMAGE',pic:'',nv:''},{av:'AV6deleteImage',fld:'vDELETEIMAGE',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("VUPDATEIMAGE.CLICK","{handler:'E13352',iparms:[{av:'A13empleadosid',fld:'EMPLEADOSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VDELETEIMAGE.CLICK","{handler:'E14352',iparms:[{av:'A13empleadosid',fld:'EMPLEADOSID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E11352',iparms:[],oparms:[]}");
         setEventMetadata("EMPLEADOSGRID.LOAD","{handler:'E15352',iparms:[],oparms:[]}");
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
         EmpleadosgridContainer = new GXWebGrid( context);
         sStyleString = "";
         subEmpleadosgrid_Linesclass = "";
         EmpleadosgridColumn = new GXWebColumn();
         A98empleadosareaid = "";
         A99empleadosnomemple = "";
         A100empleadosappaterno = "";
         A101empleadosapmaterno = "";
         A102empleadosstatus = "";
         A106empleadoscorreo = "";
         A107empleadosext = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV5buscar = "";
         H00352_A107empleadosext = new String[] {""} ;
         H00352_n107empleadosext = new bool[] {false} ;
         H00352_A106empleadoscorreo = new String[] {""} ;
         H00352_n106empleadoscorreo = new bool[] {false} ;
         H00352_A102empleadosstatus = new String[] {""} ;
         H00352_n102empleadosstatus = new bool[] {false} ;
         H00352_A101empleadosapmaterno = new String[] {""} ;
         H00352_n101empleadosapmaterno = new bool[] {false} ;
         H00352_A100empleadosappaterno = new String[] {""} ;
         H00352_n100empleadosappaterno = new bool[] {false} ;
         H00352_A99empleadosnomemple = new String[] {""} ;
         H00352_n99empleadosnomemple = new bool[] {false} ;
         H00352_A98empleadosareaid = new String[] {""} ;
         H00352_n98empleadosareaid = new bool[] {false} ;
         H00352_A13empleadosid = new int[1] ;
         EmpleadosgridRow = new GXWebRow();
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detallesempleados__default(),
            new Object[][] {
                new Object[] {
               H00352_A107empleadosext, H00352_n107empleadosext, H00352_A106empleadoscorreo, H00352_n106empleadoscorreo, H00352_A102empleadosstatus, H00352_n102empleadosstatus, H00352_A101empleadosapmaterno, H00352_n101empleadosapmaterno, H00352_A100empleadosappaterno, H00352_n100empleadosappaterno,
               H00352_A99empleadosnomemple, H00352_n99empleadosnomemple, H00352_A98empleadosareaid, H00352_n98empleadosareaid, H00352_A13empleadosid
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
      private short subEmpleadosgrid_Backcolorstyle ;
      private short subEmpleadosgrid_Titlebackstyle ;
      private short subEmpleadosgrid_Allowselection ;
      private short subEmpleadosgrid_Allowhovering ;
      private short subEmpleadosgrid_Allowcollapsing ;
      private short subEmpleadosgrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_11_Refreshing=0 ;
      private short nGXWrapped ;
      private short subEmpleadosgrid_Backstyle ;
      private short EMPLEADOSGRID_nEOF ;
      private int subEmpleadosgrid_Titlebackcolor ;
      private int subEmpleadosgrid_Allbackcolor ;
      private int A13empleadosid ;
      private int subEmpleadosgrid_Selectioncolor ;
      private int subEmpleadosgrid_Hoveringcolor ;
      private int subEmpleadosgrid_Islastpage ;
      private int idxLst ;
      private int subEmpleadosgrid_Backcolor ;
      private int edtavUpdateimage_Enabled ;
      private int edtavUpdateimage_Visible ;
      private int edtavDeleteimage_Enabled ;
      private int edtavDeleteimage_Visible ;
      private long EMPLEADOSGRID_nCurrentRecord ;
      private long EMPLEADOSGRID_nFirstRecordOnPage ;
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
      private String subEmpleadosgrid_Internalname ;
      private String subEmpleadosgrid_Class ;
      private String subEmpleadosgrid_Linesclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtempleadosid_Internalname ;
      private String edtempleadosareaid_Internalname ;
      private String edtempleadosnomemple_Internalname ;
      private String edtempleadosappaterno_Internalname ;
      private String edtempleadosapmaterno_Internalname ;
      private String edtempleadosstatus_Internalname ;
      private String edtempleadoscorreo_Internalname ;
      private String edtempleadosext_Internalname ;
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
      private String edtempleadosid_Jsonclick ;
      private String edtempleadosareaid_Jsonclick ;
      private String edtempleadosnomemple_Jsonclick ;
      private String edtempleadosappaterno_Jsonclick ;
      private String edtempleadosapmaterno_Jsonclick ;
      private String edtempleadosstatus_Jsonclick ;
      private String edtempleadoscorreo_Jsonclick ;
      private String edtempleadosext_Jsonclick ;
      private String edtavUpdateimage_Jsonclick ;
      private String edtavDeleteimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n98empleadosareaid ;
      private bool n99empleadosnomemple ;
      private bool n100empleadosappaterno ;
      private bool n101empleadosapmaterno ;
      private bool n102empleadosstatus ;
      private bool n106empleadoscorreo ;
      private bool n107empleadosext ;
      private bool returnInSub ;
      private bool AV7updateImage_IsBlob ;
      private bool AV6deleteImage_IsBlob ;
      private String AV10Updateimage_GXI ;
      private String AV11Deleteimage_GXI ;
      private String A98empleadosareaid ;
      private String A99empleadosnomemple ;
      private String A100empleadosappaterno ;
      private String A101empleadosapmaterno ;
      private String A102empleadosstatus ;
      private String A106empleadoscorreo ;
      private String A107empleadosext ;
      private String AV7updateImage ;
      private String AV6deleteImage ;
      private GXWebGrid EmpleadosgridContainer ;
      private GXWebRow EmpleadosgridRow ;
      private GXWebColumn EmpleadosgridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00352_A107empleadosext ;
      private bool[] H00352_n107empleadosext ;
      private String[] H00352_A106empleadoscorreo ;
      private bool[] H00352_n106empleadoscorreo ;
      private String[] H00352_A102empleadosstatus ;
      private bool[] H00352_n102empleadosstatus ;
      private String[] H00352_A101empleadosapmaterno ;
      private bool[] H00352_n101empleadosapmaterno ;
      private String[] H00352_A100empleadosappaterno ;
      private bool[] H00352_n100empleadosappaterno ;
      private String[] H00352_A99empleadosnomemple ;
      private bool[] H00352_n99empleadosnomemple ;
      private String[] H00352_A98empleadosareaid ;
      private bool[] H00352_n98empleadosareaid ;
      private int[] H00352_A13empleadosid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class detallesempleados__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00352 ;
          prmH00352 = new Object[] {
          new Object[] {"lV5buscar",NpgsqlDbType.Text,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00352", "SELECT empleadosext, empleadoscorreo, empleadosstatus, empleadosapmaterno, empleadosappaterno, empleadosnomemple, empleadosareaid, empleadosid FROM public.empleados WHERE empleadosnomemple like :lV5buscar ORDER BY empleadosid ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00352,11,0,true,false )
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
                ((int[]) buf[14])[0] = rslt.getInt(8) ;
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
