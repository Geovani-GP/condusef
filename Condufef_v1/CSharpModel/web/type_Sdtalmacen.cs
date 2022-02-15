/*
               File: type_Sdtalmacen
        Description: almacen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:10.46
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
   [XmlRoot(ElementName = "almacen" )]
   [XmlType(TypeName =  "almacen" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtalmacen : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtalmacen( )
      {
         /* Constructor for serialization */
         gxTv_Sdtalmacen_Almacendsc = "";
         gxTv_Sdtalmacen_Almacendireccion = "";
         gxTv_Sdtalmacen_Almacencolonia = "";
         gxTv_Sdtalmacen_Almacenmunicipio = "";
         gxTv_Sdtalmacen_Alamcenestado = "";
         gxTv_Sdtalmacen_Alamcencodigopostal = "";
         gxTv_Sdtalmacen_Alamcenobservaciones = "";
         gxTv_Sdtalmacen_Alamcenusuario = "";
         gxTv_Sdtalmacen_Almacenfecreg = DateTime.MinValue;
         gxTv_Sdtalmacen_Almacenfecultact = DateTime.MinValue;
         gxTv_Sdtalmacen_Mode = "";
         gxTv_Sdtalmacen_Almacendsc_Z = "";
         gxTv_Sdtalmacen_Almacendireccion_Z = "";
         gxTv_Sdtalmacen_Almacencolonia_Z = "";
         gxTv_Sdtalmacen_Almacenmunicipio_Z = "";
         gxTv_Sdtalmacen_Alamcenestado_Z = "";
         gxTv_Sdtalmacen_Alamcencodigopostal_Z = "";
         gxTv_Sdtalmacen_Alamcenobservaciones_Z = "";
         gxTv_Sdtalmacen_Alamcenusuario_Z = "";
         gxTv_Sdtalmacen_Almacenfecreg_Z = DateTime.MinValue;
         gxTv_Sdtalmacen_Almacenfecultact_Z = DateTime.MinValue;
      }

      public Sdtalmacen( IGxContext context )
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

      public void Load( int AV19almacenid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV19almacenid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"almacenid", typeof(int)}}) ;
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
         metadata.Set("Name", "almacen");
         metadata.Set("BT", "ALMACEN");
         metadata.Set("PK", "[ \"almacenid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Almacenid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacendsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacendireccion_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacencolonia_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenmunicipio_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenestado_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcencodigopostal_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacentelefono_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenobservaciones_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacendsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacendireccion_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacencolonia_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenmunicipio_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenestado_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcencodigopostal_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacentelefono_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenobservaciones_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Alamcenusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Almacenfecultact_N" , attrs);
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
         Sdtalmacen deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtalmacen)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtalmacen obj ;
         obj = this;
         obj.gxTpr_Almacenid = deserialized.gxTpr_Almacenid;
         obj.gxTpr_Empleadosid = deserialized.gxTpr_Empleadosid;
         obj.gxTpr_Almacendsc = deserialized.gxTpr_Almacendsc;
         obj.gxTpr_Almacendireccion = deserialized.gxTpr_Almacendireccion;
         obj.gxTpr_Almacencolonia = deserialized.gxTpr_Almacencolonia;
         obj.gxTpr_Almacenmunicipio = deserialized.gxTpr_Almacenmunicipio;
         obj.gxTpr_Alamcenestado = deserialized.gxTpr_Alamcenestado;
         obj.gxTpr_Alamcencodigopostal = deserialized.gxTpr_Alamcencodigopostal;
         obj.gxTpr_Almacentelefono = deserialized.gxTpr_Almacentelefono;
         obj.gxTpr_Alamcenobservaciones = deserialized.gxTpr_Alamcenobservaciones;
         obj.gxTpr_Alamcenusuario = deserialized.gxTpr_Alamcenusuario;
         obj.gxTpr_Almacenfecreg = deserialized.gxTpr_Almacenfecreg;
         obj.gxTpr_Almacenfecultact = deserialized.gxTpr_Almacenfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Almacenid_Z = deserialized.gxTpr_Almacenid_Z;
         obj.gxTpr_Empleadosid_Z = deserialized.gxTpr_Empleadosid_Z;
         obj.gxTpr_Almacendsc_Z = deserialized.gxTpr_Almacendsc_Z;
         obj.gxTpr_Almacendireccion_Z = deserialized.gxTpr_Almacendireccion_Z;
         obj.gxTpr_Almacencolonia_Z = deserialized.gxTpr_Almacencolonia_Z;
         obj.gxTpr_Almacenmunicipio_Z = deserialized.gxTpr_Almacenmunicipio_Z;
         obj.gxTpr_Alamcenestado_Z = deserialized.gxTpr_Alamcenestado_Z;
         obj.gxTpr_Alamcencodigopostal_Z = deserialized.gxTpr_Alamcencodigopostal_Z;
         obj.gxTpr_Almacentelefono_Z = deserialized.gxTpr_Almacentelefono_Z;
         obj.gxTpr_Alamcenobservaciones_Z = deserialized.gxTpr_Alamcenobservaciones_Z;
         obj.gxTpr_Alamcenusuario_Z = deserialized.gxTpr_Alamcenusuario_Z;
         obj.gxTpr_Almacenfecreg_Z = deserialized.gxTpr_Almacenfecreg_Z;
         obj.gxTpr_Almacenfecultact_Z = deserialized.gxTpr_Almacenfecultact_Z;
         obj.gxTpr_Empleadosid_N = deserialized.gxTpr_Empleadosid_N;
         obj.gxTpr_Almacendsc_N = deserialized.gxTpr_Almacendsc_N;
         obj.gxTpr_Almacendireccion_N = deserialized.gxTpr_Almacendireccion_N;
         obj.gxTpr_Almacencolonia_N = deserialized.gxTpr_Almacencolonia_N;
         obj.gxTpr_Almacenmunicipio_N = deserialized.gxTpr_Almacenmunicipio_N;
         obj.gxTpr_Alamcenestado_N = deserialized.gxTpr_Alamcenestado_N;
         obj.gxTpr_Alamcencodigopostal_N = deserialized.gxTpr_Alamcencodigopostal_N;
         obj.gxTpr_Almacentelefono_N = deserialized.gxTpr_Almacentelefono_N;
         obj.gxTpr_Alamcenobservaciones_N = deserialized.gxTpr_Alamcenobservaciones_N;
         obj.gxTpr_Alamcenusuario_N = deserialized.gxTpr_Alamcenusuario_N;
         obj.gxTpr_Almacenfecreg_N = deserialized.gxTpr_Almacenfecreg_N;
         obj.gxTpr_Almacenfecultact_N = deserialized.gxTpr_Almacenfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenid") )
               {
                  gxTv_Sdtalmacen_Almacenid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid") )
               {
                  gxTv_Sdtalmacen_Empleadosid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendsc") )
               {
                  gxTv_Sdtalmacen_Almacendsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendireccion") )
               {
                  gxTv_Sdtalmacen_Almacendireccion = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacencolonia") )
               {
                  gxTv_Sdtalmacen_Almacencolonia = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenmunicipio") )
               {
                  gxTv_Sdtalmacen_Almacenmunicipio = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenestado") )
               {
                  gxTv_Sdtalmacen_Alamcenestado = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcencodigopostal") )
               {
                  gxTv_Sdtalmacen_Alamcencodigopostal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacentelefono") )
               {
                  gxTv_Sdtalmacen_Almacentelefono = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenobservaciones") )
               {
                  gxTv_Sdtalmacen_Alamcenobservaciones = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenusuario") )
               {
                  gxTv_Sdtalmacen_Alamcenusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtalmacen_Almacenfecreg = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtalmacen_Almacenfecreg = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtalmacen_Almacenfecultact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtalmacen_Almacenfecultact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtalmacen_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtalmacen_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenid_Z") )
               {
                  gxTv_Sdtalmacen_Almacenid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid_Z") )
               {
                  gxTv_Sdtalmacen_Empleadosid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendsc_Z") )
               {
                  gxTv_Sdtalmacen_Almacendsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendireccion_Z") )
               {
                  gxTv_Sdtalmacen_Almacendireccion_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacencolonia_Z") )
               {
                  gxTv_Sdtalmacen_Almacencolonia_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenmunicipio_Z") )
               {
                  gxTv_Sdtalmacen_Almacenmunicipio_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenestado_Z") )
               {
                  gxTv_Sdtalmacen_Alamcenestado_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcencodigopostal_Z") )
               {
                  gxTv_Sdtalmacen_Alamcencodigopostal_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacentelefono_Z") )
               {
                  gxTv_Sdtalmacen_Almacentelefono_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenobservaciones_Z") )
               {
                  gxTv_Sdtalmacen_Alamcenobservaciones_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenusuario_Z") )
               {
                  gxTv_Sdtalmacen_Alamcenusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtalmacen_Almacenfecreg_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtalmacen_Almacenfecreg_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtalmacen_Almacenfecultact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtalmacen_Almacenfecultact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid_N") )
               {
                  gxTv_Sdtalmacen_Empleadosid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendsc_N") )
               {
                  gxTv_Sdtalmacen_Almacendsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacendireccion_N") )
               {
                  gxTv_Sdtalmacen_Almacendireccion_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacencolonia_N") )
               {
                  gxTv_Sdtalmacen_Almacencolonia_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenmunicipio_N") )
               {
                  gxTv_Sdtalmacen_Almacenmunicipio_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenestado_N") )
               {
                  gxTv_Sdtalmacen_Alamcenestado_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcencodigopostal_N") )
               {
                  gxTv_Sdtalmacen_Alamcencodigopostal_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacentelefono_N") )
               {
                  gxTv_Sdtalmacen_Almacentelefono_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenobservaciones_N") )
               {
                  gxTv_Sdtalmacen_Alamcenobservaciones_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "alamcenusuario_N") )
               {
                  gxTv_Sdtalmacen_Alamcenusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecreg_N") )
               {
                  gxTv_Sdtalmacen_Almacenfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "almacenfecultact_N") )
               {
                  gxTv_Sdtalmacen_Almacenfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "almacen";
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
         oWriter.WriteElement("almacenid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacenid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Empleadosid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("almacendsc", StringUtil.RTrim( gxTv_Sdtalmacen_Almacendsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("almacendireccion", StringUtil.RTrim( gxTv_Sdtalmacen_Almacendireccion));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("almacencolonia", StringUtil.RTrim( gxTv_Sdtalmacen_Almacencolonia));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("almacenmunicipio", StringUtil.RTrim( gxTv_Sdtalmacen_Almacenmunicipio));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("alamcenestado", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenestado));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("alamcencodigopostal", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcencodigopostal));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("almacentelefono", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacentelefono), 10, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("alamcenobservaciones", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenobservaciones));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("alamcenusuario", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtalmacen_Almacenfecreg) )
         {
            oWriter.WriteStartElement("almacenfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("almacenfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtalmacen_Almacenfecultact) )
         {
            oWriter.WriteStartElement("almacenfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("almacenfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtalmacen_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacenid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacenid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Empleadosid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacendsc_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Almacendsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacendireccion_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Almacendireccion_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacencolonia_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Almacencolonia_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacenmunicipio_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Almacenmunicipio_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenestado_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenestado_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcencodigopostal_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcencodigopostal_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacentelefono_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacentelefono_Z), 10, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenobservaciones_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenobservaciones_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenusuario_Z", StringUtil.RTrim( gxTv_Sdtalmacen_Alamcenusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtalmacen_Almacenfecreg_Z) )
            {
               oWriter.WriteStartElement("almacenfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("almacenfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtalmacen_Almacenfecultact_Z) )
            {
               oWriter.WriteStartElement("almacenfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("almacenfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("empleadosid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Empleadosid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacendsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacendsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacendireccion_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacendireccion_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacencolonia_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacencolonia_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacenmunicipio_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacenmunicipio_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenestado_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Alamcenestado_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcencodigopostal_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Alamcencodigopostal_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacentelefono_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacentelefono_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenobservaciones_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Alamcenobservaciones_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("alamcenusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Alamcenusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacenfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacenfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("almacenfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtalmacen_Almacenfecultact_N), 1, 0)));
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
         AddObjectProperty("almacenid", gxTv_Sdtalmacen_Almacenid, false);
         AddObjectProperty("empleadosid", gxTv_Sdtalmacen_Empleadosid, false);
         AddObjectProperty("almacendsc", gxTv_Sdtalmacen_Almacendsc, false);
         AddObjectProperty("almacendireccion", gxTv_Sdtalmacen_Almacendireccion, false);
         AddObjectProperty("almacencolonia", gxTv_Sdtalmacen_Almacencolonia, false);
         AddObjectProperty("almacenmunicipio", gxTv_Sdtalmacen_Almacenmunicipio, false);
         AddObjectProperty("alamcenestado", gxTv_Sdtalmacen_Alamcenestado, false);
         AddObjectProperty("alamcencodigopostal", gxTv_Sdtalmacen_Alamcencodigopostal, false);
         AddObjectProperty("almacentelefono", gxTv_Sdtalmacen_Almacentelefono, false);
         AddObjectProperty("alamcenobservaciones", gxTv_Sdtalmacen_Alamcenobservaciones, false);
         AddObjectProperty("alamcenusuario", gxTv_Sdtalmacen_Alamcenusuario, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("almacenfecreg", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("almacenfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtalmacen_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtalmacen_Initialized, false);
            AddObjectProperty("almacenid_Z", gxTv_Sdtalmacen_Almacenid_Z, false);
            AddObjectProperty("empleadosid_Z", gxTv_Sdtalmacen_Empleadosid_Z, false);
            AddObjectProperty("almacendsc_Z", gxTv_Sdtalmacen_Almacendsc_Z, false);
            AddObjectProperty("almacendireccion_Z", gxTv_Sdtalmacen_Almacendireccion_Z, false);
            AddObjectProperty("almacencolonia_Z", gxTv_Sdtalmacen_Almacencolonia_Z, false);
            AddObjectProperty("almacenmunicipio_Z", gxTv_Sdtalmacen_Almacenmunicipio_Z, false);
            AddObjectProperty("alamcenestado_Z", gxTv_Sdtalmacen_Alamcenestado_Z, false);
            AddObjectProperty("alamcencodigopostal_Z", gxTv_Sdtalmacen_Alamcencodigopostal_Z, false);
            AddObjectProperty("almacentelefono_Z", gxTv_Sdtalmacen_Almacentelefono_Z, false);
            AddObjectProperty("alamcenobservaciones_Z", gxTv_Sdtalmacen_Alamcenobservaciones_Z, false);
            AddObjectProperty("alamcenusuario_Z", gxTv_Sdtalmacen_Alamcenusuario_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("almacenfecreg_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtalmacen_Almacenfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("almacenfecultact_Z", sDateCnv, false);
            AddObjectProperty("empleadosid_N", gxTv_Sdtalmacen_Empleadosid_N, false);
            AddObjectProperty("almacendsc_N", gxTv_Sdtalmacen_Almacendsc_N, false);
            AddObjectProperty("almacendireccion_N", gxTv_Sdtalmacen_Almacendireccion_N, false);
            AddObjectProperty("almacencolonia_N", gxTv_Sdtalmacen_Almacencolonia_N, false);
            AddObjectProperty("almacenmunicipio_N", gxTv_Sdtalmacen_Almacenmunicipio_N, false);
            AddObjectProperty("alamcenestado_N", gxTv_Sdtalmacen_Alamcenestado_N, false);
            AddObjectProperty("alamcencodigopostal_N", gxTv_Sdtalmacen_Alamcencodigopostal_N, false);
            AddObjectProperty("almacentelefono_N", gxTv_Sdtalmacen_Almacentelefono_N, false);
            AddObjectProperty("alamcenobservaciones_N", gxTv_Sdtalmacen_Alamcenobservaciones_N, false);
            AddObjectProperty("alamcenusuario_N", gxTv_Sdtalmacen_Alamcenusuario_N, false);
            AddObjectProperty("almacenfecreg_N", gxTv_Sdtalmacen_Almacenfecreg_N, false);
            AddObjectProperty("almacenfecultact_N", gxTv_Sdtalmacen_Almacenfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "almacenid" )]
      [  XmlElement( ElementName = "almacenid"   )]
      public int gxTpr_Almacenid
      {
         get {
            return gxTv_Sdtalmacen_Almacenid ;
         }

         set {
            if ( gxTv_Sdtalmacen_Almacenid != value )
            {
               gxTv_Sdtalmacen_Mode = "INS";
               this.gxTv_Sdtalmacen_Almacenid_Z_SetNull( );
               this.gxTv_Sdtalmacen_Empleadosid_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacendsc_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacendireccion_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacencolonia_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacenmunicipio_Z_SetNull( );
               this.gxTv_Sdtalmacen_Alamcenestado_Z_SetNull( );
               this.gxTv_Sdtalmacen_Alamcencodigopostal_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacentelefono_Z_SetNull( );
               this.gxTv_Sdtalmacen_Alamcenobservaciones_Z_SetNull( );
               this.gxTv_Sdtalmacen_Alamcenusuario_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacenfecreg_Z_SetNull( );
               this.gxTv_Sdtalmacen_Almacenfecultact_Z_SetNull( );
            }
            gxTv_Sdtalmacen_Almacenid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "empleadosid" )]
      [  XmlElement( ElementName = "empleadosid"   )]
      public int gxTpr_Empleadosid
      {
         get {
            return gxTv_Sdtalmacen_Empleadosid ;
         }

         set {
            gxTv_Sdtalmacen_Empleadosid_N = 0;
            gxTv_Sdtalmacen_Empleadosid = (int)(value);
         }

      }

      public void gxTv_Sdtalmacen_Empleadosid_SetNull( )
      {
         gxTv_Sdtalmacen_Empleadosid_N = 1;
         gxTv_Sdtalmacen_Empleadosid = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Empleadosid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendsc" )]
      [  XmlElement( ElementName = "almacendsc"   )]
      public String gxTpr_Almacendsc
      {
         get {
            return gxTv_Sdtalmacen_Almacendsc ;
         }

         set {
            gxTv_Sdtalmacen_Almacendsc_N = 0;
            gxTv_Sdtalmacen_Almacendsc = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendsc_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendsc_N = 1;
         gxTv_Sdtalmacen_Almacendsc = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendireccion" )]
      [  XmlElement( ElementName = "almacendireccion"   )]
      public String gxTpr_Almacendireccion
      {
         get {
            return gxTv_Sdtalmacen_Almacendireccion ;
         }

         set {
            gxTv_Sdtalmacen_Almacendireccion_N = 0;
            gxTv_Sdtalmacen_Almacendireccion = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendireccion_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendireccion_N = 1;
         gxTv_Sdtalmacen_Almacendireccion = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendireccion_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacencolonia" )]
      [  XmlElement( ElementName = "almacencolonia"   )]
      public String gxTpr_Almacencolonia
      {
         get {
            return gxTv_Sdtalmacen_Almacencolonia ;
         }

         set {
            gxTv_Sdtalmacen_Almacencolonia_N = 0;
            gxTv_Sdtalmacen_Almacencolonia = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacencolonia_SetNull( )
      {
         gxTv_Sdtalmacen_Almacencolonia_N = 1;
         gxTv_Sdtalmacen_Almacencolonia = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacencolonia_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenmunicipio" )]
      [  XmlElement( ElementName = "almacenmunicipio"   )]
      public String gxTpr_Almacenmunicipio
      {
         get {
            return gxTv_Sdtalmacen_Almacenmunicipio ;
         }

         set {
            gxTv_Sdtalmacen_Almacenmunicipio_N = 0;
            gxTv_Sdtalmacen_Almacenmunicipio = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenmunicipio_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenmunicipio_N = 1;
         gxTv_Sdtalmacen_Almacenmunicipio = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenmunicipio_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenestado" )]
      [  XmlElement( ElementName = "alamcenestado"   )]
      public String gxTpr_Alamcenestado
      {
         get {
            return gxTv_Sdtalmacen_Alamcenestado ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenestado_N = 0;
            gxTv_Sdtalmacen_Alamcenestado = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenestado_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenestado_N = 1;
         gxTv_Sdtalmacen_Alamcenestado = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenestado_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcencodigopostal" )]
      [  XmlElement( ElementName = "alamcencodigopostal"   )]
      public String gxTpr_Alamcencodigopostal
      {
         get {
            return gxTv_Sdtalmacen_Alamcencodigopostal ;
         }

         set {
            gxTv_Sdtalmacen_Alamcencodigopostal_N = 0;
            gxTv_Sdtalmacen_Alamcencodigopostal = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcencodigopostal_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcencodigopostal_N = 1;
         gxTv_Sdtalmacen_Alamcencodigopostal = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcencodigopostal_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacentelefono" )]
      [  XmlElement( ElementName = "almacentelefono"   )]
      public long gxTpr_Almacentelefono
      {
         get {
            return gxTv_Sdtalmacen_Almacentelefono ;
         }

         set {
            gxTv_Sdtalmacen_Almacentelefono_N = 0;
            gxTv_Sdtalmacen_Almacentelefono = (long)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacentelefono_SetNull( )
      {
         gxTv_Sdtalmacen_Almacentelefono_N = 1;
         gxTv_Sdtalmacen_Almacentelefono = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacentelefono_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenobservaciones" )]
      [  XmlElement( ElementName = "alamcenobservaciones"   )]
      public String gxTpr_Alamcenobservaciones
      {
         get {
            return gxTv_Sdtalmacen_Alamcenobservaciones ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenobservaciones_N = 0;
            gxTv_Sdtalmacen_Alamcenobservaciones = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenobservaciones_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenobservaciones_N = 1;
         gxTv_Sdtalmacen_Alamcenobservaciones = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenobservaciones_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenusuario" )]
      [  XmlElement( ElementName = "alamcenusuario"   )]
      public String gxTpr_Alamcenusuario
      {
         get {
            return gxTv_Sdtalmacen_Alamcenusuario ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenusuario_N = 0;
            gxTv_Sdtalmacen_Alamcenusuario = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenusuario_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenusuario_N = 1;
         gxTv_Sdtalmacen_Alamcenusuario = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecreg" )]
      [  XmlElement( ElementName = "almacenfecreg"  , IsNullable=true )]
      public string gxTpr_Almacenfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtalmacen_Almacenfecreg == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtalmacen_Almacenfecreg).value ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecreg_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtalmacen_Almacenfecreg = DateTime.MinValue;
            else
               gxTv_Sdtalmacen_Almacenfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Almacenfecreg
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecreg ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecreg_N = 0;
            gxTv_Sdtalmacen_Almacenfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecreg_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecreg_N = 1;
         gxTv_Sdtalmacen_Almacenfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecultact" )]
      [  XmlElement( ElementName = "almacenfecultact"  , IsNullable=true )]
      public string gxTpr_Almacenfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtalmacen_Almacenfecultact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtalmacen_Almacenfecultact).value ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecultact_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtalmacen_Almacenfecultact = DateTime.MinValue;
            else
               gxTv_Sdtalmacen_Almacenfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Almacenfecultact
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecultact ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecultact_N = 0;
            gxTv_Sdtalmacen_Almacenfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecultact_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecultact_N = 1;
         gxTv_Sdtalmacen_Almacenfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtalmacen_Mode ;
         }

         set {
            gxTv_Sdtalmacen_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Mode_SetNull( )
      {
         gxTv_Sdtalmacen_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtalmacen_Initialized ;
         }

         set {
            gxTv_Sdtalmacen_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Initialized_SetNull( )
      {
         gxTv_Sdtalmacen_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenid_Z" )]
      [  XmlElement( ElementName = "almacenid_Z"   )]
      public int gxTpr_Almacenid_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacenid_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacenid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenid_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosid_Z" )]
      [  XmlElement( ElementName = "empleadosid_Z"   )]
      public int gxTpr_Empleadosid_Z
      {
         get {
            return gxTv_Sdtalmacen_Empleadosid_Z ;
         }

         set {
            gxTv_Sdtalmacen_Empleadosid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtalmacen_Empleadosid_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Empleadosid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Empleadosid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendsc_Z" )]
      [  XmlElement( ElementName = "almacendsc_Z"   )]
      public String gxTpr_Almacendsc_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacendsc_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacendsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendsc_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendireccion_Z" )]
      [  XmlElement( ElementName = "almacendireccion_Z"   )]
      public String gxTpr_Almacendireccion_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacendireccion_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacendireccion_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendireccion_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendireccion_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacencolonia_Z" )]
      [  XmlElement( ElementName = "almacencolonia_Z"   )]
      public String gxTpr_Almacencolonia_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacencolonia_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacencolonia_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacencolonia_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacencolonia_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacencolonia_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenmunicipio_Z" )]
      [  XmlElement( ElementName = "almacenmunicipio_Z"   )]
      public String gxTpr_Almacenmunicipio_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacenmunicipio_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacenmunicipio_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenmunicipio_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenmunicipio_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenmunicipio_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenestado_Z" )]
      [  XmlElement( ElementName = "alamcenestado_Z"   )]
      public String gxTpr_Alamcenestado_Z
      {
         get {
            return gxTv_Sdtalmacen_Alamcenestado_Z ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenestado_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenestado_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenestado_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenestado_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcencodigopostal_Z" )]
      [  XmlElement( ElementName = "alamcencodigopostal_Z"   )]
      public String gxTpr_Alamcencodigopostal_Z
      {
         get {
            return gxTv_Sdtalmacen_Alamcencodigopostal_Z ;
         }

         set {
            gxTv_Sdtalmacen_Alamcencodigopostal_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcencodigopostal_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcencodigopostal_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcencodigopostal_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacentelefono_Z" )]
      [  XmlElement( ElementName = "almacentelefono_Z"   )]
      public long gxTpr_Almacentelefono_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacentelefono_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacentelefono_Z = (long)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacentelefono_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacentelefono_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacentelefono_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenobservaciones_Z" )]
      [  XmlElement( ElementName = "alamcenobservaciones_Z"   )]
      public String gxTpr_Alamcenobservaciones_Z
      {
         get {
            return gxTv_Sdtalmacen_Alamcenobservaciones_Z ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenobservaciones_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenobservaciones_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenobservaciones_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenobservaciones_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenusuario_Z" )]
      [  XmlElement( ElementName = "alamcenusuario_Z"   )]
      public String gxTpr_Alamcenusuario_Z
      {
         get {
            return gxTv_Sdtalmacen_Alamcenusuario_Z ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenusuario_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecreg_Z" )]
      [  XmlElement( ElementName = "almacenfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Almacenfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtalmacen_Almacenfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtalmacen_Almacenfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtalmacen_Almacenfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtalmacen_Almacenfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Almacenfecreg_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecreg_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecreg_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecultact_Z" )]
      [  XmlElement( ElementName = "almacenfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Almacenfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtalmacen_Almacenfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtalmacen_Almacenfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtalmacen_Almacenfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtalmacen_Almacenfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Almacenfecultact_Z
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecultact_Z ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecultact_Z_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosid_N" )]
      [  XmlElement( ElementName = "empleadosid_N"   )]
      public short gxTpr_Empleadosid_N
      {
         get {
            return gxTv_Sdtalmacen_Empleadosid_N ;
         }

         set {
            gxTv_Sdtalmacen_Empleadosid_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Empleadosid_N_SetNull( )
      {
         gxTv_Sdtalmacen_Empleadosid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Empleadosid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendsc_N" )]
      [  XmlElement( ElementName = "almacendsc_N"   )]
      public short gxTpr_Almacendsc_N
      {
         get {
            return gxTv_Sdtalmacen_Almacendsc_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacendsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendsc_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacendireccion_N" )]
      [  XmlElement( ElementName = "almacendireccion_N"   )]
      public short gxTpr_Almacendireccion_N
      {
         get {
            return gxTv_Sdtalmacen_Almacendireccion_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacendireccion_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacendireccion_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacendireccion_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacendireccion_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacencolonia_N" )]
      [  XmlElement( ElementName = "almacencolonia_N"   )]
      public short gxTpr_Almacencolonia_N
      {
         get {
            return gxTv_Sdtalmacen_Almacencolonia_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacencolonia_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacencolonia_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacencolonia_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacencolonia_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenmunicipio_N" )]
      [  XmlElement( ElementName = "almacenmunicipio_N"   )]
      public short gxTpr_Almacenmunicipio_N
      {
         get {
            return gxTv_Sdtalmacen_Almacenmunicipio_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacenmunicipio_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenmunicipio_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenmunicipio_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenmunicipio_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenestado_N" )]
      [  XmlElement( ElementName = "alamcenestado_N"   )]
      public short gxTpr_Alamcenestado_N
      {
         get {
            return gxTv_Sdtalmacen_Alamcenestado_N ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenestado_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenestado_N_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenestado_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenestado_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcencodigopostal_N" )]
      [  XmlElement( ElementName = "alamcencodigopostal_N"   )]
      public short gxTpr_Alamcencodigopostal_N
      {
         get {
            return gxTv_Sdtalmacen_Alamcencodigopostal_N ;
         }

         set {
            gxTv_Sdtalmacen_Alamcencodigopostal_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcencodigopostal_N_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcencodigopostal_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcencodigopostal_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacentelefono_N" )]
      [  XmlElement( ElementName = "almacentelefono_N"   )]
      public short gxTpr_Almacentelefono_N
      {
         get {
            return gxTv_Sdtalmacen_Almacentelefono_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacentelefono_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacentelefono_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacentelefono_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacentelefono_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenobservaciones_N" )]
      [  XmlElement( ElementName = "alamcenobservaciones_N"   )]
      public short gxTpr_Alamcenobservaciones_N
      {
         get {
            return gxTv_Sdtalmacen_Alamcenobservaciones_N ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenobservaciones_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenobservaciones_N_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenobservaciones_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenobservaciones_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "alamcenusuario_N" )]
      [  XmlElement( ElementName = "alamcenusuario_N"   )]
      public short gxTpr_Alamcenusuario_N
      {
         get {
            return gxTv_Sdtalmacen_Alamcenusuario_N ;
         }

         set {
            gxTv_Sdtalmacen_Alamcenusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Alamcenusuario_N_SetNull( )
      {
         gxTv_Sdtalmacen_Alamcenusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Alamcenusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecreg_N" )]
      [  XmlElement( ElementName = "almacenfecreg_N"   )]
      public short gxTpr_Almacenfecreg_N
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecreg_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecreg_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "almacenfecultact_N" )]
      [  XmlElement( ElementName = "almacenfecultact_N"   )]
      public short gxTpr_Almacenfecultact_N
      {
         get {
            return gxTv_Sdtalmacen_Almacenfecultact_N ;
         }

         set {
            gxTv_Sdtalmacen_Almacenfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtalmacen_Almacenfecultact_N_SetNull( )
      {
         gxTv_Sdtalmacen_Almacenfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtalmacen_Almacenfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtalmacen_Almacendsc = "";
         gxTv_Sdtalmacen_Almacendireccion = "";
         gxTv_Sdtalmacen_Almacencolonia = "";
         gxTv_Sdtalmacen_Almacenmunicipio = "";
         gxTv_Sdtalmacen_Alamcenestado = "";
         gxTv_Sdtalmacen_Alamcencodigopostal = "";
         gxTv_Sdtalmacen_Alamcenobservaciones = "";
         gxTv_Sdtalmacen_Alamcenusuario = "";
         gxTv_Sdtalmacen_Almacenfecreg = DateTime.MinValue;
         gxTv_Sdtalmacen_Almacenfecultact = DateTime.MinValue;
         gxTv_Sdtalmacen_Mode = "";
         gxTv_Sdtalmacen_Almacendsc_Z = "";
         gxTv_Sdtalmacen_Almacendireccion_Z = "";
         gxTv_Sdtalmacen_Almacencolonia_Z = "";
         gxTv_Sdtalmacen_Almacenmunicipio_Z = "";
         gxTv_Sdtalmacen_Alamcenestado_Z = "";
         gxTv_Sdtalmacen_Alamcencodigopostal_Z = "";
         gxTv_Sdtalmacen_Alamcenobservaciones_Z = "";
         gxTv_Sdtalmacen_Alamcenusuario_Z = "";
         gxTv_Sdtalmacen_Almacenfecreg_Z = DateTime.MinValue;
         gxTv_Sdtalmacen_Almacenfecultact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "almacen", "GeneXus.Programs.almacen_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtalmacen_Initialized ;
      private short gxTv_Sdtalmacen_Empleadosid_N ;
      private short gxTv_Sdtalmacen_Almacendsc_N ;
      private short gxTv_Sdtalmacen_Almacendireccion_N ;
      private short gxTv_Sdtalmacen_Almacencolonia_N ;
      private short gxTv_Sdtalmacen_Almacenmunicipio_N ;
      private short gxTv_Sdtalmacen_Alamcenestado_N ;
      private short gxTv_Sdtalmacen_Alamcencodigopostal_N ;
      private short gxTv_Sdtalmacen_Almacentelefono_N ;
      private short gxTv_Sdtalmacen_Alamcenobservaciones_N ;
      private short gxTv_Sdtalmacen_Alamcenusuario_N ;
      private short gxTv_Sdtalmacen_Almacenfecreg_N ;
      private short gxTv_Sdtalmacen_Almacenfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtalmacen_Almacenid ;
      private int gxTv_Sdtalmacen_Empleadosid ;
      private int gxTv_Sdtalmacen_Almacenid_Z ;
      private int gxTv_Sdtalmacen_Empleadosid_Z ;
      private long gxTv_Sdtalmacen_Almacentelefono ;
      private long gxTv_Sdtalmacen_Almacentelefono_Z ;
      private String gxTv_Sdtalmacen_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtalmacen_Almacenfecreg ;
      private DateTime gxTv_Sdtalmacen_Almacenfecultact ;
      private DateTime gxTv_Sdtalmacen_Almacenfecreg_Z ;
      private DateTime gxTv_Sdtalmacen_Almacenfecultact_Z ;
      private String gxTv_Sdtalmacen_Almacendsc ;
      private String gxTv_Sdtalmacen_Almacendireccion ;
      private String gxTv_Sdtalmacen_Almacencolonia ;
      private String gxTv_Sdtalmacen_Almacenmunicipio ;
      private String gxTv_Sdtalmacen_Alamcenestado ;
      private String gxTv_Sdtalmacen_Alamcencodigopostal ;
      private String gxTv_Sdtalmacen_Alamcenobservaciones ;
      private String gxTv_Sdtalmacen_Alamcenusuario ;
      private String gxTv_Sdtalmacen_Almacendsc_Z ;
      private String gxTv_Sdtalmacen_Almacendireccion_Z ;
      private String gxTv_Sdtalmacen_Almacencolonia_Z ;
      private String gxTv_Sdtalmacen_Almacenmunicipio_Z ;
      private String gxTv_Sdtalmacen_Alamcenestado_Z ;
      private String gxTv_Sdtalmacen_Alamcencodigopostal_Z ;
      private String gxTv_Sdtalmacen_Alamcenobservaciones_Z ;
      private String gxTv_Sdtalmacen_Alamcenusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"almacen", Namespace = "Condufef_v1")]
   public class Sdtalmacen_RESTInterface : GxGenericCollectionItem<Sdtalmacen>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtalmacen_RESTInterface( ) : base()
      {
      }

      public Sdtalmacen_RESTInterface( Sdtalmacen psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "almacenid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Almacenid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Almacenid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Almacenid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "empleadosid" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Empleadosid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Empleadosid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Empleadosid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "almacendsc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Almacendsc
      {
         get {
            return sdt.gxTpr_Almacendsc ;
         }

         set {
            sdt.gxTpr_Almacendsc = (String)(value);
         }

      }

      [DataMember( Name = "almacendireccion" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Almacendireccion
      {
         get {
            return sdt.gxTpr_Almacendireccion ;
         }

         set {
            sdt.gxTpr_Almacendireccion = (String)(value);
         }

      }

      [DataMember( Name = "almacencolonia" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Almacencolonia
      {
         get {
            return sdt.gxTpr_Almacencolonia ;
         }

         set {
            sdt.gxTpr_Almacencolonia = (String)(value);
         }

      }

      [DataMember( Name = "almacenmunicipio" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Almacenmunicipio
      {
         get {
            return sdt.gxTpr_Almacenmunicipio ;
         }

         set {
            sdt.gxTpr_Almacenmunicipio = (String)(value);
         }

      }

      [DataMember( Name = "alamcenestado" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Alamcenestado
      {
         get {
            return sdt.gxTpr_Alamcenestado ;
         }

         set {
            sdt.gxTpr_Alamcenestado = (String)(value);
         }

      }

      [DataMember( Name = "alamcencodigopostal" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Alamcencodigopostal
      {
         get {
            return sdt.gxTpr_Alamcencodigopostal ;
         }

         set {
            sdt.gxTpr_Alamcencodigopostal = (String)(value);
         }

      }

      [DataMember( Name = "almacentelefono" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Almacentelefono
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Almacentelefono), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Almacentelefono = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "alamcenobservaciones" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Alamcenobservaciones
      {
         get {
            return sdt.gxTpr_Alamcenobservaciones ;
         }

         set {
            sdt.gxTpr_Alamcenobservaciones = (String)(value);
         }

      }

      [DataMember( Name = "alamcenusuario" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Alamcenusuario
      {
         get {
            return sdt.gxTpr_Alamcenusuario ;
         }

         set {
            sdt.gxTpr_Alamcenusuario = (String)(value);
         }

      }

      [DataMember( Name = "almacenfecreg" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Almacenfecreg
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Almacenfecreg) ;
         }

         set {
            sdt.gxTpr_Almacenfecreg = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "almacenfecultact" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Almacenfecultact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Almacenfecultact) ;
         }

         set {
            sdt.gxTpr_Almacenfecultact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      public Sdtalmacen sdt
      {
         get {
            return (Sdtalmacen)Sdt ;
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
            sdt = new Sdtalmacen() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 40 )]
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
