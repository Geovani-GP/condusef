/*
               File: type_Sdtproveedores
        Description: proveedores
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:28.88
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
using System.Web.Services.Protocols;
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
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "proveedores" )]
   [XmlType(TypeName =  "proveedores" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtproveedores : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproveedores( )
      {
         /* Constructor for serialization */
         gxTv_Sdtproveedores_Proveedoresnombre = "";
         gxTv_Sdtproveedores_Proveedoresdireccion = "";
         gxTv_Sdtproveedores_Proveedorescolonia = "";
         gxTv_Sdtproveedores_Proveedorescodigopostal = "";
         gxTv_Sdtproveedores_Proveedoresmunicipio = "";
         gxTv_Sdtproveedores_Proveedorestado = "";
         gxTv_Sdtproveedores_Proveedoresfax = "";
         gxTv_Sdtproveedores_Proveedoresrfc = "";
         gxTv_Sdtproveedores_Proveedoresusuario = "";
         gxTv_Sdtproveedores_Proveedoresfecreg = DateTime.MinValue;
         gxTv_Sdtproveedores_Proveedoresfecultact = DateTime.MinValue;
         gxTv_Sdtproveedores_Mode = "";
         gxTv_Sdtproveedores_Proveedoresnombre_Z = "";
         gxTv_Sdtproveedores_Proveedoresdireccion_Z = "";
         gxTv_Sdtproveedores_Proveedorescolonia_Z = "";
         gxTv_Sdtproveedores_Proveedorescodigopostal_Z = "";
         gxTv_Sdtproveedores_Proveedoresmunicipio_Z = "";
         gxTv_Sdtproveedores_Proveedorestado_Z = "";
         gxTv_Sdtproveedores_Proveedoresfax_Z = "";
         gxTv_Sdtproveedores_Proveedoresrfc_Z = "";
         gxTv_Sdtproveedores_Proveedoresusuario_Z = "";
         gxTv_Sdtproveedores_Proveedoresfecreg_Z = DateTime.MinValue;
         gxTv_Sdtproveedores_Proveedoresfecultact_Z = DateTime.MinValue;
      }

      public Sdtproveedores( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( int AV2proveedoresid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV2proveedoresid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"proveedoresid", typeof(int)}}) ;
      }

      public override IGxCollection GetMessages( )
      {
         short item = 1 ;
         IGxCollection msgs = new GxObjectCollection( context, "Messages.Message", "Genexus", "SdtMessages_Message", "GeneXus.Programs") ;
         SdtMessages_Message m1 ;
         IGxSilentTrn trn = getTransaction() ;
         msglist msgList = trn.GetMessages() ;
         while ( item <= msgList.ItemCount )
         {
            m1 = new SdtMessages_Message(context);
            m1.gxTpr_Id = msgList.getItemValue(item);
            m1.gxTpr_Description = msgList.getItemText(item);
            m1.gxTpr_Type = msgList.getItemType(item);
            msgs.Add(m1, 0);
            item = (short)(item+1);
         }
         return msgs ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "proveedores");
         metadata.Set("BT", "PROVEEDORES");
         metadata.Set("PK", "[ \"proveedoresid\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         if ( ! includeState )
         {
            XmlAttributeOverrides ov = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlIgnore = true;
            ov.Add(this.GetType(),  "gxTpr_Mode" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Initialized" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresnombre_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresdireccion_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorescolonia_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorescodigopostal_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresmunicipio_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestado_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestelefono1_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestelefono2_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfax_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresrfc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresnombre_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresdireccion_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorescolonia_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorescodigopostal_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresmunicipio_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestado_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestelefono1_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedorestelefono2_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfax_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresrfc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Proveedoresfecultact_N" , attrs);
            xmls = new XmlSerializer(this.GetType(), ov, new Type[0], null, sNameSpace);
         }
         else
         {
            xmls = new XmlSerializer(this.GetType(), sNameSpace);
         }
         System.IO.MemoryStream stream = new System.IO.MemoryStream();
         System.Xml.XmlWriter xmlw = System.Xml.XmlWriter.Create(stream, new System.Xml.XmlWriterSettings() { OmitXmlDeclaration = !includeHeader});
         XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
         xmlns.Add(String.Empty, sNameSpace);
         xmls.Serialize( xmlw, this, xmlns);
         stream.Seek(0L, System.IO.SeekOrigin.Begin);
         System.IO.StreamReader sr = new System.IO.StreamReader(stream);
         s = sr.ReadToEnd();
         stream.Close();
         return s ;
      }

      public override void FromXml( String s ,
                                    String name )
      {
         Sdtproveedores deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtproveedores)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtproveedores obj ;
         obj = this;
         obj.gxTpr_Proveedoresid = deserialized.gxTpr_Proveedoresid;
         obj.gxTpr_Proveedoresnombre = deserialized.gxTpr_Proveedoresnombre;
         obj.gxTpr_Proveedoresdireccion = deserialized.gxTpr_Proveedoresdireccion;
         obj.gxTpr_Proveedorescolonia = deserialized.gxTpr_Proveedorescolonia;
         obj.gxTpr_Proveedorescodigopostal = deserialized.gxTpr_Proveedorescodigopostal;
         obj.gxTpr_Proveedoresmunicipio = deserialized.gxTpr_Proveedoresmunicipio;
         obj.gxTpr_Proveedorestado = deserialized.gxTpr_Proveedorestado;
         obj.gxTpr_Proveedorestelefono1 = deserialized.gxTpr_Proveedorestelefono1;
         obj.gxTpr_Proveedorestelefono2 = deserialized.gxTpr_Proveedorestelefono2;
         obj.gxTpr_Proveedoresfax = deserialized.gxTpr_Proveedoresfax;
         obj.gxTpr_Proveedoresrfc = deserialized.gxTpr_Proveedoresrfc;
         obj.gxTpr_Proveedoresusuario = deserialized.gxTpr_Proveedoresusuario;
         obj.gxTpr_Proveedoresfecreg = deserialized.gxTpr_Proveedoresfecreg;
         obj.gxTpr_Proveedoresfecultact = deserialized.gxTpr_Proveedoresfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Proveedoresid_Z = deserialized.gxTpr_Proveedoresid_Z;
         obj.gxTpr_Proveedoresnombre_Z = deserialized.gxTpr_Proveedoresnombre_Z;
         obj.gxTpr_Proveedoresdireccion_Z = deserialized.gxTpr_Proveedoresdireccion_Z;
         obj.gxTpr_Proveedorescolonia_Z = deserialized.gxTpr_Proveedorescolonia_Z;
         obj.gxTpr_Proveedorescodigopostal_Z = deserialized.gxTpr_Proveedorescodigopostal_Z;
         obj.gxTpr_Proveedoresmunicipio_Z = deserialized.gxTpr_Proveedoresmunicipio_Z;
         obj.gxTpr_Proveedorestado_Z = deserialized.gxTpr_Proveedorestado_Z;
         obj.gxTpr_Proveedorestelefono1_Z = deserialized.gxTpr_Proveedorestelefono1_Z;
         obj.gxTpr_Proveedorestelefono2_Z = deserialized.gxTpr_Proveedorestelefono2_Z;
         obj.gxTpr_Proveedoresfax_Z = deserialized.gxTpr_Proveedoresfax_Z;
         obj.gxTpr_Proveedoresrfc_Z = deserialized.gxTpr_Proveedoresrfc_Z;
         obj.gxTpr_Proveedoresusuario_Z = deserialized.gxTpr_Proveedoresusuario_Z;
         obj.gxTpr_Proveedoresfecreg_Z = deserialized.gxTpr_Proveedoresfecreg_Z;
         obj.gxTpr_Proveedoresfecultact_Z = deserialized.gxTpr_Proveedoresfecultact_Z;
         obj.gxTpr_Proveedoresid_N = deserialized.gxTpr_Proveedoresid_N;
         obj.gxTpr_Proveedoresnombre_N = deserialized.gxTpr_Proveedoresnombre_N;
         obj.gxTpr_Proveedoresdireccion_N = deserialized.gxTpr_Proveedoresdireccion_N;
         obj.gxTpr_Proveedorescolonia_N = deserialized.gxTpr_Proveedorescolonia_N;
         obj.gxTpr_Proveedorescodigopostal_N = deserialized.gxTpr_Proveedorescodigopostal_N;
         obj.gxTpr_Proveedoresmunicipio_N = deserialized.gxTpr_Proveedoresmunicipio_N;
         obj.gxTpr_Proveedorestado_N = deserialized.gxTpr_Proveedorestado_N;
         obj.gxTpr_Proveedorestelefono1_N = deserialized.gxTpr_Proveedorestelefono1_N;
         obj.gxTpr_Proveedorestelefono2_N = deserialized.gxTpr_Proveedorestelefono2_N;
         obj.gxTpr_Proveedoresfax_N = deserialized.gxTpr_Proveedoresfax_N;
         obj.gxTpr_Proveedoresrfc_N = deserialized.gxTpr_Proveedoresrfc_N;
         obj.gxTpr_Proveedoresusuario_N = deserialized.gxTpr_Proveedoresusuario_N;
         obj.gxTpr_Proveedoresfecreg_N = deserialized.gxTpr_Proveedoresfecreg_N;
         obj.gxTpr_Proveedoresfecultact_N = deserialized.gxTpr_Proveedoresfecultact_N;
         return  ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read();
            nOutParmCount = 0;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0;
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresid") )
               {
                  gxTv_Sdtproveedores_Proveedoresid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresnombre") )
               {
                  gxTv_Sdtproveedores_Proveedoresnombre = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresdireccion") )
               {
                  gxTv_Sdtproveedores_Proveedoresdireccion = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescolonia") )
               {
                  gxTv_Sdtproveedores_Proveedorescolonia = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescodigopostal") )
               {
                  gxTv_Sdtproveedores_Proveedorescodigopostal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresmunicipio") )
               {
                  gxTv_Sdtproveedores_Proveedoresmunicipio = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestado") )
               {
                  gxTv_Sdtproveedores_Proveedorestado = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono1") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono1 = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono2") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono2 = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfax") )
               {
                  gxTv_Sdtproveedores_Proveedoresfax = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresrfc") )
               {
                  gxTv_Sdtproveedores_Proveedoresrfc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresusuario") )
               {
                  gxTv_Sdtproveedores_Proveedoresusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproveedores_Proveedoresfecreg = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproveedores_Proveedoresfecreg = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproveedores_Proveedoresfecultact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproveedores_Proveedoresfecultact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtproveedores_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtproveedores_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresid_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresnombre_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresnombre_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresdireccion_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresdireccion_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescolonia_Z") )
               {
                  gxTv_Sdtproveedores_Proveedorescolonia_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescodigopostal_Z") )
               {
                  gxTv_Sdtproveedores_Proveedorescodigopostal_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresmunicipio_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresmunicipio_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestado_Z") )
               {
                  gxTv_Sdtproveedores_Proveedorestado_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono1_Z") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono1_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono2_Z") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono2_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfax_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresfax_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresrfc_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresrfc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresusuario_Z") )
               {
                  gxTv_Sdtproveedores_Proveedoresusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproveedores_Proveedoresfecreg_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproveedores_Proveedoresfecreg_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproveedores_Proveedoresfecultact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproveedores_Proveedoresfecultact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresid_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresnombre_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresnombre_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresdireccion_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresdireccion_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescolonia_N") )
               {
                  gxTv_Sdtproveedores_Proveedorescolonia_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorescodigopostal_N") )
               {
                  gxTv_Sdtproveedores_Proveedorescodigopostal_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresmunicipio_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresmunicipio_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestado_N") )
               {
                  gxTv_Sdtproveedores_Proveedorestado_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono1_N") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono1_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedorestelefono2_N") )
               {
                  gxTv_Sdtproveedores_Proveedorestelefono2_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfax_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresfax_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresrfc_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresrfc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresusuario_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecreg_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "proveedoresfecultact_N") )
               {
                  gxTv_Sdtproveedores_Proveedoresfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               nOutParmCount = (short)(nOutParmCount+1);
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( );
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Message: " + oReader.ReadRawXML();
                  GXSoapError = (short)(nOutParmCount*-1);
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         writexml(oWriter, sName, sNameSpace, true);
         return  ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace ,
                                     bool sIncludeState )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "proveedores";
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "Condufef_v1";
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10));
         }
         oWriter.WriteElement("proveedoresid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresnombre", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresnombre));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresdireccion", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresdireccion));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedorescolonia", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorescolonia));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedorescodigopostal", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorescodigopostal));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresmunicipio", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresmunicipio));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedorestado", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorestado));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedorestelefono1", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono1), 10, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedorestelefono2", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono2), 10, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresfax", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresfax));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresrfc", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresrfc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("proveedoresusuario", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtproveedores_Proveedoresfecreg) )
         {
            oWriter.WriteStartElement("proveedoresfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("proveedoresfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtproveedores_Proveedoresfecultact) )
         {
            oWriter.WriteStartElement("proveedoresfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("proveedoresfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtproveedores_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresnombre_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresnombre_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresdireccion_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresdireccion_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorescolonia_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorescolonia_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorescodigopostal_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorescodigopostal_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresmunicipio_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresmunicipio_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestado_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedorestado_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestelefono1_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono1_Z), 10, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestelefono2_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono2_Z), 10, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresfax_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresfax_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresrfc_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresrfc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresusuario_Z", StringUtil.RTrim( gxTv_Sdtproveedores_Proveedoresusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtproveedores_Proveedoresfecreg_Z) )
            {
               oWriter.WriteStartElement("proveedoresfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("proveedoresfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtproveedores_Proveedoresfecultact_Z) )
            {
               oWriter.WriteStartElement("proveedoresfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("proveedoresfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("proveedoresid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresnombre_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresnombre_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresdireccion_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresdireccion_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorescolonia_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorescolonia_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorescodigopostal_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorescodigopostal_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresmunicipio_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresmunicipio_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestado_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestado_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestelefono1_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono1_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedorestelefono2_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedorestelefono2_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresfax_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresfax_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresrfc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresrfc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("proveedoresfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproveedores_Proveedoresfecultact_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("proveedoresid", gxTv_Sdtproveedores_Proveedoresid, false);
         AddObjectProperty("proveedoresnombre", gxTv_Sdtproveedores_Proveedoresnombre, false);
         AddObjectProperty("proveedoresdireccion", gxTv_Sdtproveedores_Proveedoresdireccion, false);
         AddObjectProperty("proveedorescolonia", gxTv_Sdtproveedores_Proveedorescolonia, false);
         AddObjectProperty("proveedorescodigopostal", gxTv_Sdtproveedores_Proveedorescodigopostal, false);
         AddObjectProperty("proveedoresmunicipio", gxTv_Sdtproveedores_Proveedoresmunicipio, false);
         AddObjectProperty("proveedorestado", gxTv_Sdtproveedores_Proveedorestado, false);
         AddObjectProperty("proveedorestelefono1", gxTv_Sdtproveedores_Proveedorestelefono1, false);
         AddObjectProperty("proveedorestelefono2", gxTv_Sdtproveedores_Proveedorestelefono2, false);
         AddObjectProperty("proveedoresfax", gxTv_Sdtproveedores_Proveedoresfax, false);
         AddObjectProperty("proveedoresrfc", gxTv_Sdtproveedores_Proveedoresrfc, false);
         AddObjectProperty("proveedoresusuario", gxTv_Sdtproveedores_Proveedoresusuario, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("proveedoresfecreg", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("proveedoresfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtproveedores_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtproveedores_Initialized, false);
            AddObjectProperty("proveedoresid_Z", gxTv_Sdtproveedores_Proveedoresid_Z, false);
            AddObjectProperty("proveedoresnombre_Z", gxTv_Sdtproveedores_Proveedoresnombre_Z, false);
            AddObjectProperty("proveedoresdireccion_Z", gxTv_Sdtproveedores_Proveedoresdireccion_Z, false);
            AddObjectProperty("proveedorescolonia_Z", gxTv_Sdtproveedores_Proveedorescolonia_Z, false);
            AddObjectProperty("proveedorescodigopostal_Z", gxTv_Sdtproveedores_Proveedorescodigopostal_Z, false);
            AddObjectProperty("proveedoresmunicipio_Z", gxTv_Sdtproveedores_Proveedoresmunicipio_Z, false);
            AddObjectProperty("proveedorestado_Z", gxTv_Sdtproveedores_Proveedorestado_Z, false);
            AddObjectProperty("proveedorestelefono1_Z", gxTv_Sdtproveedores_Proveedorestelefono1_Z, false);
            AddObjectProperty("proveedorestelefono2_Z", gxTv_Sdtproveedores_Proveedorestelefono2_Z, false);
            AddObjectProperty("proveedoresfax_Z", gxTv_Sdtproveedores_Proveedoresfax_Z, false);
            AddObjectProperty("proveedoresrfc_Z", gxTv_Sdtproveedores_Proveedoresrfc_Z, false);
            AddObjectProperty("proveedoresusuario_Z", gxTv_Sdtproveedores_Proveedoresusuario_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("proveedoresfecreg_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproveedores_Proveedoresfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("proveedoresfecultact_Z", sDateCnv, false);
            AddObjectProperty("proveedoresid_N", gxTv_Sdtproveedores_Proveedoresid_N, false);
            AddObjectProperty("proveedoresnombre_N", gxTv_Sdtproveedores_Proveedoresnombre_N, false);
            AddObjectProperty("proveedoresdireccion_N", gxTv_Sdtproveedores_Proveedoresdireccion_N, false);
            AddObjectProperty("proveedorescolonia_N", gxTv_Sdtproveedores_Proveedorescolonia_N, false);
            AddObjectProperty("proveedorescodigopostal_N", gxTv_Sdtproveedores_Proveedorescodigopostal_N, false);
            AddObjectProperty("proveedoresmunicipio_N", gxTv_Sdtproveedores_Proveedoresmunicipio_N, false);
            AddObjectProperty("proveedorestado_N", gxTv_Sdtproveedores_Proveedorestado_N, false);
            AddObjectProperty("proveedorestelefono1_N", gxTv_Sdtproveedores_Proveedorestelefono1_N, false);
            AddObjectProperty("proveedorestelefono2_N", gxTv_Sdtproveedores_Proveedorestelefono2_N, false);
            AddObjectProperty("proveedoresfax_N", gxTv_Sdtproveedores_Proveedoresfax_N, false);
            AddObjectProperty("proveedoresrfc_N", gxTv_Sdtproveedores_Proveedoresrfc_N, false);
            AddObjectProperty("proveedoresusuario_N", gxTv_Sdtproveedores_Proveedoresusuario_N, false);
            AddObjectProperty("proveedoresfecreg_N", gxTv_Sdtproveedores_Proveedoresfecreg_N, false);
            AddObjectProperty("proveedoresfecultact_N", gxTv_Sdtproveedores_Proveedoresfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "proveedoresid" )]
      [  XmlElement( ElementName = "proveedoresid"   )]
      public int gxTpr_Proveedoresid
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresid ;
         }

         set {
            if ( gxTv_Sdtproveedores_Proveedoresid != value )
            {
               gxTv_Sdtproveedores_Mode = "INS";
               this.gxTv_Sdtproveedores_Proveedoresid_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresnombre_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresdireccion_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedorescolonia_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedorescodigopostal_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresmunicipio_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedorestado_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedorestelefono1_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedorestelefono2_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresfax_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresrfc_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresusuario_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresfecreg_Z_SetNull( );
               this.gxTv_Sdtproveedores_Proveedoresfecultact_Z_SetNull( );
            }
            gxTv_Sdtproveedores_Proveedoresid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "proveedoresnombre" )]
      [  XmlElement( ElementName = "proveedoresnombre"   )]
      public String gxTpr_Proveedoresnombre
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresnombre ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresnombre_N = 0;
            gxTv_Sdtproveedores_Proveedoresnombre = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresnombre_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresnombre_N = 1;
         gxTv_Sdtproveedores_Proveedoresnombre = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresnombre_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresdireccion" )]
      [  XmlElement( ElementName = "proveedoresdireccion"   )]
      public String gxTpr_Proveedoresdireccion
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresdireccion ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresdireccion_N = 0;
            gxTv_Sdtproveedores_Proveedoresdireccion = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresdireccion_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresdireccion_N = 1;
         gxTv_Sdtproveedores_Proveedoresdireccion = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresdireccion_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescolonia" )]
      [  XmlElement( ElementName = "proveedorescolonia"   )]
      public String gxTpr_Proveedorescolonia
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescolonia ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescolonia_N = 0;
            gxTv_Sdtproveedores_Proveedorescolonia = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescolonia_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescolonia_N = 1;
         gxTv_Sdtproveedores_Proveedorescolonia = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescolonia_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescodigopostal" )]
      [  XmlElement( ElementName = "proveedorescodigopostal"   )]
      public String gxTpr_Proveedorescodigopostal
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescodigopostal ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescodigopostal_N = 0;
            gxTv_Sdtproveedores_Proveedorescodigopostal = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescodigopostal_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescodigopostal_N = 1;
         gxTv_Sdtproveedores_Proveedorescodigopostal = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescodigopostal_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresmunicipio" )]
      [  XmlElement( ElementName = "proveedoresmunicipio"   )]
      public String gxTpr_Proveedoresmunicipio
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresmunicipio ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresmunicipio_N = 0;
            gxTv_Sdtproveedores_Proveedoresmunicipio = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresmunicipio_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresmunicipio_N = 1;
         gxTv_Sdtproveedores_Proveedoresmunicipio = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresmunicipio_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestado" )]
      [  XmlElement( ElementName = "proveedorestado"   )]
      public String gxTpr_Proveedorestado
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestado ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestado_N = 0;
            gxTv_Sdtproveedores_Proveedorestado = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestado_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestado_N = 1;
         gxTv_Sdtproveedores_Proveedorestado = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestado_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono1" )]
      [  XmlElement( ElementName = "proveedorestelefono1"   )]
      public long gxTpr_Proveedorestelefono1
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono1 ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono1_N = 0;
            gxTv_Sdtproveedores_Proveedorestelefono1 = (long)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono1_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono1_N = 1;
         gxTv_Sdtproveedores_Proveedorestelefono1 = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono1_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono2" )]
      [  XmlElement( ElementName = "proveedorestelefono2"   )]
      public long gxTpr_Proveedorestelefono2
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono2 ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono2_N = 0;
            gxTv_Sdtproveedores_Proveedorestelefono2 = (long)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono2_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono2_N = 1;
         gxTv_Sdtproveedores_Proveedorestelefono2 = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono2_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfax" )]
      [  XmlElement( ElementName = "proveedoresfax"   )]
      public String gxTpr_Proveedoresfax
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfax ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfax_N = 0;
            gxTv_Sdtproveedores_Proveedoresfax = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfax_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfax_N = 1;
         gxTv_Sdtproveedores_Proveedoresfax = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfax_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresrfc" )]
      [  XmlElement( ElementName = "proveedoresrfc"   )]
      public String gxTpr_Proveedoresrfc
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresrfc ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresrfc_N = 0;
            gxTv_Sdtproveedores_Proveedoresrfc = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresrfc_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresrfc_N = 1;
         gxTv_Sdtproveedores_Proveedoresrfc = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresrfc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresusuario" )]
      [  XmlElement( ElementName = "proveedoresusuario"   )]
      public String gxTpr_Proveedoresusuario
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresusuario ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresusuario_N = 0;
            gxTv_Sdtproveedores_Proveedoresusuario = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresusuario_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresusuario_N = 1;
         gxTv_Sdtproveedores_Proveedoresusuario = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecreg" )]
      [  XmlElement( ElementName = "proveedoresfecreg"  , IsNullable=true )]
      public string gxTpr_Proveedoresfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtproveedores_Proveedoresfecreg == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproveedores_Proveedoresfecreg).value ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecreg_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproveedores_Proveedoresfecreg = DateTime.MinValue;
            else
               gxTv_Sdtproveedores_Proveedoresfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Proveedoresfecreg
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecreg ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecreg_N = 0;
            gxTv_Sdtproveedores_Proveedoresfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecreg_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecreg_N = 1;
         gxTv_Sdtproveedores_Proveedoresfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecultact" )]
      [  XmlElement( ElementName = "proveedoresfecultact"  , IsNullable=true )]
      public string gxTpr_Proveedoresfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtproveedores_Proveedoresfecultact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproveedores_Proveedoresfecultact).value ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecultact_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproveedores_Proveedoresfecultact = DateTime.MinValue;
            else
               gxTv_Sdtproveedores_Proveedoresfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Proveedoresfecultact
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecultact ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecultact_N = 0;
            gxTv_Sdtproveedores_Proveedoresfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecultact_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecultact_N = 1;
         gxTv_Sdtproveedores_Proveedoresfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtproveedores_Mode ;
         }

         set {
            gxTv_Sdtproveedores_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Mode_SetNull( )
      {
         gxTv_Sdtproveedores_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtproveedores_Initialized ;
         }

         set {
            gxTv_Sdtproveedores_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Initialized_SetNull( )
      {
         gxTv_Sdtproveedores_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresid_Z" )]
      [  XmlElement( ElementName = "proveedoresid_Z"   )]
      public int gxTpr_Proveedoresid_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresid_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresid_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresnombre_Z" )]
      [  XmlElement( ElementName = "proveedoresnombre_Z"   )]
      public String gxTpr_Proveedoresnombre_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresnombre_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresnombre_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresnombre_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresnombre_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresdireccion_Z" )]
      [  XmlElement( ElementName = "proveedoresdireccion_Z"   )]
      public String gxTpr_Proveedoresdireccion_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresdireccion_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresdireccion_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresdireccion_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresdireccion_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresdireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescolonia_Z" )]
      [  XmlElement( ElementName = "proveedorescolonia_Z"   )]
      public String gxTpr_Proveedorescolonia_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescolonia_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescolonia_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescolonia_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescolonia_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescolonia_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescodigopostal_Z" )]
      [  XmlElement( ElementName = "proveedorescodigopostal_Z"   )]
      public String gxTpr_Proveedorescodigopostal_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescodigopostal_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescodigopostal_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescodigopostal_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescodigopostal_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescodigopostal_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresmunicipio_Z" )]
      [  XmlElement( ElementName = "proveedoresmunicipio_Z"   )]
      public String gxTpr_Proveedoresmunicipio_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresmunicipio_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresmunicipio_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresmunicipio_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresmunicipio_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresmunicipio_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestado_Z" )]
      [  XmlElement( ElementName = "proveedorestado_Z"   )]
      public String gxTpr_Proveedorestado_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestado_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestado_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestado_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestado_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestado_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono1_Z" )]
      [  XmlElement( ElementName = "proveedorestelefono1_Z"   )]
      public long gxTpr_Proveedorestelefono1_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono1_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono1_Z = (long)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono1_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono1_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono1_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono2_Z" )]
      [  XmlElement( ElementName = "proveedorestelefono2_Z"   )]
      public long gxTpr_Proveedorestelefono2_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono2_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono2_Z = (long)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono2_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono2_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono2_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfax_Z" )]
      [  XmlElement( ElementName = "proveedoresfax_Z"   )]
      public String gxTpr_Proveedoresfax_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfax_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfax_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfax_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfax_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfax_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresrfc_Z" )]
      [  XmlElement( ElementName = "proveedoresrfc_Z"   )]
      public String gxTpr_Proveedoresrfc_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresrfc_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresrfc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresrfc_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresrfc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresrfc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresusuario_Z" )]
      [  XmlElement( ElementName = "proveedoresusuario_Z"   )]
      public String gxTpr_Proveedoresusuario_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresusuario_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresusuario_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecreg_Z" )]
      [  XmlElement( ElementName = "proveedoresfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Proveedoresfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproveedores_Proveedoresfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproveedores_Proveedoresfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproveedores_Proveedoresfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtproveedores_Proveedoresfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Proveedoresfecreg_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecreg_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecreg_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecultact_Z" )]
      [  XmlElement( ElementName = "proveedoresfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Proveedoresfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproveedores_Proveedoresfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproveedores_Proveedoresfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproveedores_Proveedoresfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtproveedores_Proveedoresfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Proveedoresfecultact_Z
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecultact_Z ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecultact_Z_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresid_N" )]
      [  XmlElement( ElementName = "proveedoresid_N"   )]
      public short gxTpr_Proveedoresid_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresid_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresid_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresnombre_N" )]
      [  XmlElement( ElementName = "proveedoresnombre_N"   )]
      public short gxTpr_Proveedoresnombre_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresnombre_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresnombre_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresnombre_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresnombre_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresnombre_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresdireccion_N" )]
      [  XmlElement( ElementName = "proveedoresdireccion_N"   )]
      public short gxTpr_Proveedoresdireccion_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresdireccion_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresdireccion_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresdireccion_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresdireccion_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresdireccion_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescolonia_N" )]
      [  XmlElement( ElementName = "proveedorescolonia_N"   )]
      public short gxTpr_Proveedorescolonia_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescolonia_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescolonia_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescolonia_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescolonia_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescolonia_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorescodigopostal_N" )]
      [  XmlElement( ElementName = "proveedorescodigopostal_N"   )]
      public short gxTpr_Proveedorescodigopostal_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedorescodigopostal_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorescodigopostal_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorescodigopostal_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorescodigopostal_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorescodigopostal_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresmunicipio_N" )]
      [  XmlElement( ElementName = "proveedoresmunicipio_N"   )]
      public short gxTpr_Proveedoresmunicipio_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresmunicipio_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresmunicipio_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresmunicipio_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresmunicipio_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresmunicipio_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestado_N" )]
      [  XmlElement( ElementName = "proveedorestado_N"   )]
      public short gxTpr_Proveedorestado_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestado_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestado_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestado_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestado_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestado_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono1_N" )]
      [  XmlElement( ElementName = "proveedorestelefono1_N"   )]
      public short gxTpr_Proveedorestelefono1_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono1_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono1_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono1_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono1_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono1_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedorestelefono2_N" )]
      [  XmlElement( ElementName = "proveedorestelefono2_N"   )]
      public short gxTpr_Proveedorestelefono2_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedorestelefono2_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedorestelefono2_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedorestelefono2_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedorestelefono2_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedorestelefono2_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfax_N" )]
      [  XmlElement( ElementName = "proveedoresfax_N"   )]
      public short gxTpr_Proveedoresfax_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfax_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfax_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfax_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfax_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfax_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresrfc_N" )]
      [  XmlElement( ElementName = "proveedoresrfc_N"   )]
      public short gxTpr_Proveedoresrfc_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresrfc_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresrfc_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresrfc_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresrfc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresrfc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresusuario_N" )]
      [  XmlElement( ElementName = "proveedoresusuario_N"   )]
      public short gxTpr_Proveedoresusuario_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresusuario_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresusuario_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecreg_N" )]
      [  XmlElement( ElementName = "proveedoresfecreg_N"   )]
      public short gxTpr_Proveedoresfecreg_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecreg_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecreg_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "proveedoresfecultact_N" )]
      [  XmlElement( ElementName = "proveedoresfecultact_N"   )]
      public short gxTpr_Proveedoresfecultact_N
      {
         get {
            return gxTv_Sdtproveedores_Proveedoresfecultact_N ;
         }

         set {
            gxTv_Sdtproveedores_Proveedoresfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtproveedores_Proveedoresfecultact_N_SetNull( )
      {
         gxTv_Sdtproveedores_Proveedoresfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproveedores_Proveedoresfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtproveedores_Proveedoresnombre = "";
         gxTv_Sdtproveedores_Proveedoresdireccion = "";
         gxTv_Sdtproveedores_Proveedorescolonia = "";
         gxTv_Sdtproveedores_Proveedorescodigopostal = "";
         gxTv_Sdtproveedores_Proveedoresmunicipio = "";
         gxTv_Sdtproveedores_Proveedorestado = "";
         gxTv_Sdtproveedores_Proveedoresfax = "";
         gxTv_Sdtproveedores_Proveedoresrfc = "";
         gxTv_Sdtproveedores_Proveedoresusuario = "";
         gxTv_Sdtproveedores_Proveedoresfecreg = DateTime.MinValue;
         gxTv_Sdtproveedores_Proveedoresfecultact = DateTime.MinValue;
         gxTv_Sdtproveedores_Mode = "";
         gxTv_Sdtproveedores_Proveedoresnombre_Z = "";
         gxTv_Sdtproveedores_Proveedoresdireccion_Z = "";
         gxTv_Sdtproveedores_Proveedorescolonia_Z = "";
         gxTv_Sdtproveedores_Proveedorescodigopostal_Z = "";
         gxTv_Sdtproveedores_Proveedoresmunicipio_Z = "";
         gxTv_Sdtproveedores_Proveedorestado_Z = "";
         gxTv_Sdtproveedores_Proveedoresfax_Z = "";
         gxTv_Sdtproveedores_Proveedoresrfc_Z = "";
         gxTv_Sdtproveedores_Proveedoresusuario_Z = "";
         gxTv_Sdtproveedores_Proveedoresfecreg_Z = DateTime.MinValue;
         gxTv_Sdtproveedores_Proveedoresfecultact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "proveedores", "GeneXus.Programs.proveedores_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtproveedores_Initialized ;
      private short gxTv_Sdtproveedores_Proveedoresid_N ;
      private short gxTv_Sdtproveedores_Proveedoresnombre_N ;
      private short gxTv_Sdtproveedores_Proveedoresdireccion_N ;
      private short gxTv_Sdtproveedores_Proveedorescolonia_N ;
      private short gxTv_Sdtproveedores_Proveedorescodigopostal_N ;
      private short gxTv_Sdtproveedores_Proveedoresmunicipio_N ;
      private short gxTv_Sdtproveedores_Proveedorestado_N ;
      private short gxTv_Sdtproveedores_Proveedorestelefono1_N ;
      private short gxTv_Sdtproveedores_Proveedorestelefono2_N ;
      private short gxTv_Sdtproveedores_Proveedoresfax_N ;
      private short gxTv_Sdtproveedores_Proveedoresrfc_N ;
      private short gxTv_Sdtproveedores_Proveedoresusuario_N ;
      private short gxTv_Sdtproveedores_Proveedoresfecreg_N ;
      private short gxTv_Sdtproveedores_Proveedoresfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtproveedores_Proveedoresid ;
      private int gxTv_Sdtproveedores_Proveedoresid_Z ;
      private long gxTv_Sdtproveedores_Proveedorestelefono1 ;
      private long gxTv_Sdtproveedores_Proveedorestelefono2 ;
      private long gxTv_Sdtproveedores_Proveedorestelefono1_Z ;
      private long gxTv_Sdtproveedores_Proveedorestelefono2_Z ;
      private String gxTv_Sdtproveedores_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtproveedores_Proveedoresfecreg ;
      private DateTime gxTv_Sdtproveedores_Proveedoresfecultact ;
      private DateTime gxTv_Sdtproveedores_Proveedoresfecreg_Z ;
      private DateTime gxTv_Sdtproveedores_Proveedoresfecultact_Z ;
      private String gxTv_Sdtproveedores_Proveedoresnombre ;
      private String gxTv_Sdtproveedores_Proveedoresdireccion ;
      private String gxTv_Sdtproveedores_Proveedorescolonia ;
      private String gxTv_Sdtproveedores_Proveedorescodigopostal ;
      private String gxTv_Sdtproveedores_Proveedoresmunicipio ;
      private String gxTv_Sdtproveedores_Proveedorestado ;
      private String gxTv_Sdtproveedores_Proveedoresfax ;
      private String gxTv_Sdtproveedores_Proveedoresrfc ;
      private String gxTv_Sdtproveedores_Proveedoresusuario ;
      private String gxTv_Sdtproveedores_Proveedoresnombre_Z ;
      private String gxTv_Sdtproveedores_Proveedoresdireccion_Z ;
      private String gxTv_Sdtproveedores_Proveedorescolonia_Z ;
      private String gxTv_Sdtproveedores_Proveedorescodigopostal_Z ;
      private String gxTv_Sdtproveedores_Proveedoresmunicipio_Z ;
      private String gxTv_Sdtproveedores_Proveedorestado_Z ;
      private String gxTv_Sdtproveedores_Proveedoresfax_Z ;
      private String gxTv_Sdtproveedores_Proveedoresrfc_Z ;
      private String gxTv_Sdtproveedores_Proveedoresusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"proveedores", Namespace = "Condufef_v1")]
   public class Sdtproveedores_RESTInterface : GxGenericCollectionItem<Sdtproveedores>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproveedores_RESTInterface( ) : base()
      {
      }

      public Sdtproveedores_RESTInterface( Sdtproveedores psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "proveedoresid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Proveedoresid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Proveedoresid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "proveedoresnombre" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresnombre
      {
         get {
            return sdt.gxTpr_Proveedoresnombre ;
         }

         set {
            sdt.gxTpr_Proveedoresnombre = (String)(value);
         }

      }

      [DataMember( Name = "proveedoresdireccion" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresdireccion
      {
         get {
            return sdt.gxTpr_Proveedoresdireccion ;
         }

         set {
            sdt.gxTpr_Proveedoresdireccion = (String)(value);
         }

      }

      [DataMember( Name = "proveedorescolonia" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Proveedorescolonia
      {
         get {
            return sdt.gxTpr_Proveedorescolonia ;
         }

         set {
            sdt.gxTpr_Proveedorescolonia = (String)(value);
         }

      }

      [DataMember( Name = "proveedorescodigopostal" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Proveedorescodigopostal
      {
         get {
            return sdt.gxTpr_Proveedorescodigopostal ;
         }

         set {
            sdt.gxTpr_Proveedorescodigopostal = (String)(value);
         }

      }

      [DataMember( Name = "proveedoresmunicipio" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresmunicipio
      {
         get {
            return sdt.gxTpr_Proveedoresmunicipio ;
         }

         set {
            sdt.gxTpr_Proveedoresmunicipio = (String)(value);
         }

      }

      [DataMember( Name = "proveedorestado" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Proveedorestado
      {
         get {
            return sdt.gxTpr_Proveedorestado ;
         }

         set {
            sdt.gxTpr_Proveedorestado = (String)(value);
         }

      }

      [DataMember( Name = "proveedorestelefono1" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Proveedorestelefono1
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Proveedorestelefono1), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Proveedorestelefono1 = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "proveedorestelefono2" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Proveedorestelefono2
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Proveedorestelefono2), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Proveedorestelefono2 = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "proveedoresfax" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresfax
      {
         get {
            return sdt.gxTpr_Proveedoresfax ;
         }

         set {
            sdt.gxTpr_Proveedoresfax = (String)(value);
         }

      }

      [DataMember( Name = "proveedoresrfc" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresrfc
      {
         get {
            return sdt.gxTpr_Proveedoresrfc ;
         }

         set {
            sdt.gxTpr_Proveedoresrfc = (String)(value);
         }

      }

      [DataMember( Name = "proveedoresusuario" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresusuario
      {
         get {
            return sdt.gxTpr_Proveedoresusuario ;
         }

         set {
            sdt.gxTpr_Proveedoresusuario = (String)(value);
         }

      }

      [DataMember( Name = "proveedoresfecreg" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresfecreg
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Proveedoresfecreg) ;
         }

         set {
            sdt.gxTpr_Proveedoresfecreg = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "proveedoresfecultact" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Proveedoresfecultact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Proveedoresfecultact) ;
         }

         set {
            sdt.gxTpr_Proveedoresfecultact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      public Sdtproveedores sdt
      {
         get {
            return (Sdtproveedores)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new Sdtproveedores() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 44 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
