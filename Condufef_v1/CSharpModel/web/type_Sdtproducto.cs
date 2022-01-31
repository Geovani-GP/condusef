/*
               File: type_Sdtproducto
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:37:36.6
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
   [XmlRoot(ElementName = "producto" )]
   [XmlType(TypeName =  "producto" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtproducto : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproducto( )
      {
         /* Constructor for serialization */
         gxTv_Sdtproducto_Productodsc = "";
         gxTv_Sdtproducto_Productousuario = "";
         gxTv_Sdtproducto_Productofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Productofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Mode = "";
         gxTv_Sdtproducto_Productodsc_Z = "";
         gxTv_Sdtproducto_Productousuario_Z = "";
         gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtproducto( IGxContext context )
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

      public void Load( int AV175productoid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV175productoid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"productoid", typeof(int)}}) ;
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
         metadata.Set("Name", "producto");
         metadata.Set("BT", "producto");
         metadata.Set("PK", "[ \"productoid\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"cambsid\" ],\"FKMap\":[  ] },{ \"FK\":[ \"tipobienid\" ],\"FKMap\":[  ] } ]");
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
            ov.Add(this.GetType(),  "gxTpr_Productoid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productodsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modeloid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productousuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productodsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modeloid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productousuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecultact_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienid_N" , attrs);
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
         Sdtproducto deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtproducto)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtproducto obj ;
         obj = this;
         obj.gxTpr_Productoid = deserialized.gxTpr_Productoid;
         obj.gxTpr_Cambsid = deserialized.gxTpr_Cambsid;
         obj.gxTpr_Productodsc = deserialized.gxTpr_Productodsc;
         obj.gxTpr_Modeloid = deserialized.gxTpr_Modeloid;
         obj.gxTpr_Marcaid = deserialized.gxTpr_Marcaid;
         obj.gxTpr_Categoriaid = deserialized.gxTpr_Categoriaid;
         obj.gxTpr_Productousuario = deserialized.gxTpr_Productousuario;
         obj.gxTpr_Productofecreg = deserialized.gxTpr_Productofecreg;
         obj.gxTpr_Productofecultact = deserialized.gxTpr_Productofecultact;
         obj.gxTpr_Tipobienid = deserialized.gxTpr_Tipobienid;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Productoid_Z = deserialized.gxTpr_Productoid_Z;
         obj.gxTpr_Cambsid_Z = deserialized.gxTpr_Cambsid_Z;
         obj.gxTpr_Productodsc_Z = deserialized.gxTpr_Productodsc_Z;
         obj.gxTpr_Modeloid_Z = deserialized.gxTpr_Modeloid_Z;
         obj.gxTpr_Marcaid_Z = deserialized.gxTpr_Marcaid_Z;
         obj.gxTpr_Categoriaid_Z = deserialized.gxTpr_Categoriaid_Z;
         obj.gxTpr_Productousuario_Z = deserialized.gxTpr_Productousuario_Z;
         obj.gxTpr_Productofecreg_Z = deserialized.gxTpr_Productofecreg_Z;
         obj.gxTpr_Productofecultact_Z = deserialized.gxTpr_Productofecultact_Z;
         obj.gxTpr_Tipobienid_Z = deserialized.gxTpr_Tipobienid_Z;
         obj.gxTpr_Cambsid_N = deserialized.gxTpr_Cambsid_N;
         obj.gxTpr_Productodsc_N = deserialized.gxTpr_Productodsc_N;
         obj.gxTpr_Modeloid_N = deserialized.gxTpr_Modeloid_N;
         obj.gxTpr_Marcaid_N = deserialized.gxTpr_Marcaid_N;
         obj.gxTpr_Categoriaid_N = deserialized.gxTpr_Categoriaid_N;
         obj.gxTpr_Productousuario_N = deserialized.gxTpr_Productousuario_N;
         obj.gxTpr_Productofecreg_N = deserialized.gxTpr_Productofecreg_N;
         obj.gxTpr_Productofecultact_N = deserialized.gxTpr_Productofecultact_N;
         obj.gxTpr_Tipobienid_N = deserialized.gxTpr_Tipobienid_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "productoid") )
               {
                  gxTv_Sdtproducto_Productoid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsid") )
               {
                  gxTv_Sdtproducto_Cambsid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc") )
               {
                  gxTv_Sdtproducto_Productodsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modeloid") )
               {
                  gxTv_Sdtproducto_Modeloid = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcaid") )
               {
                  gxTv_Sdtproducto_Marcaid = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriaid") )
               {
                  gxTv_Sdtproducto_Categoriaid = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario") )
               {
                  gxTv_Sdtproducto_Productousuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid") )
               {
                  gxTv_Sdtproducto_Tipobienid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtproducto_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtproducto_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productoid_Z") )
               {
                  gxTv_Sdtproducto_Productoid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsid_Z") )
               {
                  gxTv_Sdtproducto_Cambsid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc_Z") )
               {
                  gxTv_Sdtproducto_Productodsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modeloid_Z") )
               {
                  gxTv_Sdtproducto_Modeloid_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcaid_Z") )
               {
                  gxTv_Sdtproducto_Marcaid_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriaid_Z") )
               {
                  gxTv_Sdtproducto_Categoriaid_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario_Z") )
               {
                  gxTv_Sdtproducto_Productousuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid_Z") )
               {
                  gxTv_Sdtproducto_Tipobienid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsid_N") )
               {
                  gxTv_Sdtproducto_Cambsid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc_N") )
               {
                  gxTv_Sdtproducto_Productodsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modeloid_N") )
               {
                  gxTv_Sdtproducto_Modeloid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcaid_N") )
               {
                  gxTv_Sdtproducto_Marcaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriaid_N") )
               {
                  gxTv_Sdtproducto_Categoriaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario_N") )
               {
                  gxTv_Sdtproducto_Productousuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg_N") )
               {
                  gxTv_Sdtproducto_Productofecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact_N") )
               {
                  gxTv_Sdtproducto_Productofecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid_N") )
               {
                  gxTv_Sdtproducto_Tipobienid_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "producto";
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
         oWriter.WriteElement("productoid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productoid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("cambsid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Cambsid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("productodsc", StringUtil.RTrim( gxTv_Sdtproducto_Productodsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("modeloid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Modeloid), 18, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("marcaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Marcaid), 18, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("categoriaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Categoriaid), 18, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("productousuario", StringUtil.RTrim( gxTv_Sdtproducto_Productousuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecreg) )
         {
            oWriter.WriteStartElement("productofecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("productofecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecultact) )
         {
            oWriter.WriteStartElement("productofecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("productofecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         oWriter.WriteElement("tipobienid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Tipobienid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtproducto_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productoid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productoid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Cambsid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productodsc_Z", StringUtil.RTrim( gxTv_Sdtproducto_Productodsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modeloid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Modeloid_Z), 18, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Marcaid_Z), 18, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Categoriaid_Z), 18, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productousuario_Z", StringUtil.RTrim( gxTv_Sdtproducto_Productousuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecreg_Z) )
            {
               oWriter.WriteStartElement("productofecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("productofecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecultact_Z) )
            {
               oWriter.WriteStartElement("productofecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("productofecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("tipobienid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Tipobienid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Cambsid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productodsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productodsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modeloid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Modeloid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Marcaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Categoriaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productousuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productousuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productofecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productofecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productofecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productofecultact_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Tipobienid_N), 1, 0)));
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
         AddObjectProperty("productoid", gxTv_Sdtproducto_Productoid, false);
         AddObjectProperty("cambsid", gxTv_Sdtproducto_Cambsid, false);
         AddObjectProperty("productodsc", gxTv_Sdtproducto_Productodsc, false);
         AddObjectProperty("modeloid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Modeloid), 18, 0)), false);
         AddObjectProperty("marcaid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Marcaid), 18, 0)), false);
         AddObjectProperty("categoriaid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Categoriaid), 18, 0)), false);
         AddObjectProperty("productousuario", gxTv_Sdtproducto_Productousuario, false);
         datetime_STZ = gxTv_Sdtproducto_Productofecreg;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("productofecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtproducto_Productofecultact;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("productofecultact", sDateCnv, false);
         AddObjectProperty("tipobienid", gxTv_Sdtproducto_Tipobienid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtproducto_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtproducto_Initialized, false);
            AddObjectProperty("productoid_Z", gxTv_Sdtproducto_Productoid_Z, false);
            AddObjectProperty("cambsid_Z", gxTv_Sdtproducto_Cambsid_Z, false);
            AddObjectProperty("productodsc_Z", gxTv_Sdtproducto_Productodsc_Z, false);
            AddObjectProperty("modeloid_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Modeloid_Z), 18, 0)), false);
            AddObjectProperty("marcaid_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Marcaid_Z), 18, 0)), false);
            AddObjectProperty("categoriaid_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Categoriaid_Z), 18, 0)), false);
            AddObjectProperty("productousuario_Z", gxTv_Sdtproducto_Productousuario_Z, false);
            datetime_STZ = gxTv_Sdtproducto_Productofecreg_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("productofecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtproducto_Productofecultact_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("productofecultact_Z", sDateCnv, false);
            AddObjectProperty("tipobienid_Z", gxTv_Sdtproducto_Tipobienid_Z, false);
            AddObjectProperty("cambsid_N", gxTv_Sdtproducto_Cambsid_N, false);
            AddObjectProperty("productodsc_N", gxTv_Sdtproducto_Productodsc_N, false);
            AddObjectProperty("modeloid_N", gxTv_Sdtproducto_Modeloid_N, false);
            AddObjectProperty("marcaid_N", gxTv_Sdtproducto_Marcaid_N, false);
            AddObjectProperty("categoriaid_N", gxTv_Sdtproducto_Categoriaid_N, false);
            AddObjectProperty("productousuario_N", gxTv_Sdtproducto_Productousuario_N, false);
            AddObjectProperty("productofecreg_N", gxTv_Sdtproducto_Productofecreg_N, false);
            AddObjectProperty("productofecultact_N", gxTv_Sdtproducto_Productofecultact_N, false);
            AddObjectProperty("tipobienid_N", gxTv_Sdtproducto_Tipobienid_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "productoid" )]
      [  XmlElement( ElementName = "productoid"   )]
      public int gxTpr_Productoid
      {
         get {
            return gxTv_Sdtproducto_Productoid ;
         }

         set {
            if ( gxTv_Sdtproducto_Productoid != value )
            {
               gxTv_Sdtproducto_Mode = "INS";
               this.gxTv_Sdtproducto_Productoid_Z_SetNull( );
               this.gxTv_Sdtproducto_Cambsid_Z_SetNull( );
               this.gxTv_Sdtproducto_Productodsc_Z_SetNull( );
               this.gxTv_Sdtproducto_Modeloid_Z_SetNull( );
               this.gxTv_Sdtproducto_Marcaid_Z_SetNull( );
               this.gxTv_Sdtproducto_Categoriaid_Z_SetNull( );
               this.gxTv_Sdtproducto_Productousuario_Z_SetNull( );
               this.gxTv_Sdtproducto_Productofecreg_Z_SetNull( );
               this.gxTv_Sdtproducto_Productofecultact_Z_SetNull( );
               this.gxTv_Sdtproducto_Tipobienid_Z_SetNull( );
            }
            gxTv_Sdtproducto_Productoid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "cambsid" )]
      [  XmlElement( ElementName = "cambsid"   )]
      public int gxTpr_Cambsid
      {
         get {
            return gxTv_Sdtproducto_Cambsid ;
         }

         set {
            gxTv_Sdtproducto_Cambsid_N = 0;
            gxTv_Sdtproducto_Cambsid = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Cambsid_SetNull( )
      {
         gxTv_Sdtproducto_Cambsid_N = 1;
         gxTv_Sdtproducto_Cambsid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Cambsid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc" )]
      [  XmlElement( ElementName = "productodsc"   )]
      public String gxTpr_Productodsc
      {
         get {
            return gxTv_Sdtproducto_Productodsc ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_N = 0;
            gxTv_Sdtproducto_Productodsc = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_N = 1;
         gxTv_Sdtproducto_Productodsc = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modeloid" )]
      [  XmlElement( ElementName = "modeloid"   )]
      public long gxTpr_Modeloid
      {
         get {
            return gxTv_Sdtproducto_Modeloid ;
         }

         set {
            gxTv_Sdtproducto_Modeloid_N = 0;
            gxTv_Sdtproducto_Modeloid = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Modeloid_SetNull( )
      {
         gxTv_Sdtproducto_Modeloid_N = 1;
         gxTv_Sdtproducto_Modeloid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Modeloid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcaid" )]
      [  XmlElement( ElementName = "marcaid"   )]
      public long gxTpr_Marcaid
      {
         get {
            return gxTv_Sdtproducto_Marcaid ;
         }

         set {
            gxTv_Sdtproducto_Marcaid_N = 0;
            gxTv_Sdtproducto_Marcaid = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Marcaid_SetNull( )
      {
         gxTv_Sdtproducto_Marcaid_N = 1;
         gxTv_Sdtproducto_Marcaid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Marcaid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriaid" )]
      [  XmlElement( ElementName = "categoriaid"   )]
      public long gxTpr_Categoriaid
      {
         get {
            return gxTv_Sdtproducto_Categoriaid ;
         }

         set {
            gxTv_Sdtproducto_Categoriaid_N = 0;
            gxTv_Sdtproducto_Categoriaid = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Categoriaid_SetNull( )
      {
         gxTv_Sdtproducto_Categoriaid_N = 1;
         gxTv_Sdtproducto_Categoriaid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Categoriaid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario" )]
      [  XmlElement( ElementName = "productousuario"   )]
      public String gxTpr_Productousuario
      {
         get {
            return gxTv_Sdtproducto_Productousuario ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_N = 0;
            gxTv_Sdtproducto_Productousuario = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_N = 1;
         gxTv_Sdtproducto_Productousuario = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg" )]
      [  XmlElement( ElementName = "productofecreg"  , IsNullable=true )]
      public string gxTpr_Productofecreg_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtproducto_Productofecreg).value ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtproducto_Productofecreg = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecreg
      {
         get {
            return gxTv_Sdtproducto_Productofecreg ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = 0;
            gxTv_Sdtproducto_Productofecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_N = 1;
         gxTv_Sdtproducto_Productofecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact" )]
      [  XmlElement( ElementName = "productofecultact"  , IsNullable=true )]
      public string gxTpr_Productofecultact_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtproducto_Productofecultact).value ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtproducto_Productofecultact = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecultact
      {
         get {
            return gxTv_Sdtproducto_Productofecultact ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = 0;
            gxTv_Sdtproducto_Productofecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_N = 1;
         gxTv_Sdtproducto_Productofecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienid" )]
      [  XmlElement( ElementName = "tipobienid"   )]
      public int gxTpr_Tipobienid
      {
         get {
            return gxTv_Sdtproducto_Tipobienid ;
         }

         set {
            gxTv_Sdtproducto_Tipobienid_N = 0;
            gxTv_Sdtproducto_Tipobienid = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Tipobienid_SetNull( )
      {
         gxTv_Sdtproducto_Tipobienid_N = 1;
         gxTv_Sdtproducto_Tipobienid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Tipobienid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtproducto_Mode ;
         }

         set {
            gxTv_Sdtproducto_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Mode_SetNull( )
      {
         gxTv_Sdtproducto_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtproducto_Initialized ;
         }

         set {
            gxTv_Sdtproducto_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Initialized_SetNull( )
      {
         gxTv_Sdtproducto_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productoid_Z" )]
      [  XmlElement( ElementName = "productoid_Z"   )]
      public int gxTpr_Productoid_Z
      {
         get {
            return gxTv_Sdtproducto_Productoid_Z ;
         }

         set {
            gxTv_Sdtproducto_Productoid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Productoid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productoid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsid_Z" )]
      [  XmlElement( ElementName = "cambsid_Z"   )]
      public int gxTpr_Cambsid_Z
      {
         get {
            return gxTv_Sdtproducto_Cambsid_Z ;
         }

         set {
            gxTv_Sdtproducto_Cambsid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Cambsid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Cambsid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Cambsid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc_Z" )]
      [  XmlElement( ElementName = "productodsc_Z"   )]
      public String gxTpr_Productodsc_Z
      {
         get {
            return gxTv_Sdtproducto_Productodsc_Z ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modeloid_Z" )]
      [  XmlElement( ElementName = "modeloid_Z"   )]
      public long gxTpr_Modeloid_Z
      {
         get {
            return gxTv_Sdtproducto_Modeloid_Z ;
         }

         set {
            gxTv_Sdtproducto_Modeloid_Z = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Modeloid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Modeloid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Modeloid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcaid_Z" )]
      [  XmlElement( ElementName = "marcaid_Z"   )]
      public long gxTpr_Marcaid_Z
      {
         get {
            return gxTv_Sdtproducto_Marcaid_Z ;
         }

         set {
            gxTv_Sdtproducto_Marcaid_Z = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Marcaid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Marcaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Marcaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriaid_Z" )]
      [  XmlElement( ElementName = "categoriaid_Z"   )]
      public long gxTpr_Categoriaid_Z
      {
         get {
            return gxTv_Sdtproducto_Categoriaid_Z ;
         }

         set {
            gxTv_Sdtproducto_Categoriaid_Z = (long)(value);
         }

      }

      public void gxTv_Sdtproducto_Categoriaid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Categoriaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Categoriaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario_Z" )]
      [  XmlElement( ElementName = "productousuario_Z"   )]
      public String gxTpr_Productousuario_Z
      {
         get {
            return gxTv_Sdtproducto_Productousuario_Z ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg_Z" )]
      [  XmlElement( ElementName = "productofecreg_Z"  , IsNullable=true )]
      public string gxTpr_Productofecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtproducto_Productofecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtproducto_Productofecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecreg_Z
      {
         get {
            return gxTv_Sdtproducto_Productofecreg_Z ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact_Z" )]
      [  XmlElement( ElementName = "productofecultact_Z"  , IsNullable=true )]
      public string gxTpr_Productofecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtproducto_Productofecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtproducto_Productofecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecultact_Z
      {
         get {
            return gxTv_Sdtproducto_Productofecultact_Z ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienid_Z" )]
      [  XmlElement( ElementName = "tipobienid_Z"   )]
      public int gxTpr_Tipobienid_Z
      {
         get {
            return gxTv_Sdtproducto_Tipobienid_Z ;
         }

         set {
            gxTv_Sdtproducto_Tipobienid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Tipobienid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Tipobienid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Tipobienid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsid_N" )]
      [  XmlElement( ElementName = "cambsid_N"   )]
      public short gxTpr_Cambsid_N
      {
         get {
            return gxTv_Sdtproducto_Cambsid_N ;
         }

         set {
            gxTv_Sdtproducto_Cambsid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Cambsid_N_SetNull( )
      {
         gxTv_Sdtproducto_Cambsid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Cambsid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc_N" )]
      [  XmlElement( ElementName = "productodsc_N"   )]
      public short gxTpr_Productodsc_N
      {
         get {
            return gxTv_Sdtproducto_Productodsc_N ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_N_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modeloid_N" )]
      [  XmlElement( ElementName = "modeloid_N"   )]
      public short gxTpr_Modeloid_N
      {
         get {
            return gxTv_Sdtproducto_Modeloid_N ;
         }

         set {
            gxTv_Sdtproducto_Modeloid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Modeloid_N_SetNull( )
      {
         gxTv_Sdtproducto_Modeloid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Modeloid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcaid_N" )]
      [  XmlElement( ElementName = "marcaid_N"   )]
      public short gxTpr_Marcaid_N
      {
         get {
            return gxTv_Sdtproducto_Marcaid_N ;
         }

         set {
            gxTv_Sdtproducto_Marcaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Marcaid_N_SetNull( )
      {
         gxTv_Sdtproducto_Marcaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Marcaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriaid_N" )]
      [  XmlElement( ElementName = "categoriaid_N"   )]
      public short gxTpr_Categoriaid_N
      {
         get {
            return gxTv_Sdtproducto_Categoriaid_N ;
         }

         set {
            gxTv_Sdtproducto_Categoriaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Categoriaid_N_SetNull( )
      {
         gxTv_Sdtproducto_Categoriaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Categoriaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario_N" )]
      [  XmlElement( ElementName = "productousuario_N"   )]
      public short gxTpr_Productousuario_N
      {
         get {
            return gxTv_Sdtproducto_Productousuario_N ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_N_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg_N" )]
      [  XmlElement( ElementName = "productofecreg_N"   )]
      public short gxTpr_Productofecreg_N
      {
         get {
            return gxTv_Sdtproducto_Productofecreg_N ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_N_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact_N" )]
      [  XmlElement( ElementName = "productofecultact_N"   )]
      public short gxTpr_Productofecultact_N
      {
         get {
            return gxTv_Sdtproducto_Productofecultact_N ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_N_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienid_N" )]
      [  XmlElement( ElementName = "tipobienid_N"   )]
      public short gxTpr_Tipobienid_N
      {
         get {
            return gxTv_Sdtproducto_Tipobienid_N ;
         }

         set {
            gxTv_Sdtproducto_Tipobienid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Tipobienid_N_SetNull( )
      {
         gxTv_Sdtproducto_Tipobienid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Tipobienid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtproducto_Productodsc = "";
         gxTv_Sdtproducto_Productousuario = "";
         gxTv_Sdtproducto_Productofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Productofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Mode = "";
         gxTv_Sdtproducto_Productodsc_Z = "";
         gxTv_Sdtproducto_Productousuario_Z = "";
         gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "producto", "GeneXus.Programs.producto_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtproducto_Initialized ;
      private short gxTv_Sdtproducto_Cambsid_N ;
      private short gxTv_Sdtproducto_Productodsc_N ;
      private short gxTv_Sdtproducto_Modeloid_N ;
      private short gxTv_Sdtproducto_Marcaid_N ;
      private short gxTv_Sdtproducto_Categoriaid_N ;
      private short gxTv_Sdtproducto_Productousuario_N ;
      private short gxTv_Sdtproducto_Productofecreg_N ;
      private short gxTv_Sdtproducto_Productofecultact_N ;
      private short gxTv_Sdtproducto_Tipobienid_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtproducto_Productoid ;
      private int gxTv_Sdtproducto_Cambsid ;
      private int gxTv_Sdtproducto_Tipobienid ;
      private int gxTv_Sdtproducto_Productoid_Z ;
      private int gxTv_Sdtproducto_Cambsid_Z ;
      private int gxTv_Sdtproducto_Tipobienid_Z ;
      private long gxTv_Sdtproducto_Modeloid ;
      private long gxTv_Sdtproducto_Marcaid ;
      private long gxTv_Sdtproducto_Categoriaid ;
      private long gxTv_Sdtproducto_Modeloid_Z ;
      private long gxTv_Sdtproducto_Marcaid_Z ;
      private long gxTv_Sdtproducto_Categoriaid_Z ;
      private String gxTv_Sdtproducto_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtproducto_Productofecreg ;
      private DateTime gxTv_Sdtproducto_Productofecultact ;
      private DateTime gxTv_Sdtproducto_Productofecreg_Z ;
      private DateTime gxTv_Sdtproducto_Productofecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtproducto_Productodsc ;
      private String gxTv_Sdtproducto_Productousuario ;
      private String gxTv_Sdtproducto_Productodsc_Z ;
      private String gxTv_Sdtproducto_Productousuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"producto", Namespace = "Condufef_v1")]
   public class Sdtproducto_RESTInterface : GxGenericCollectionItem<Sdtproducto>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproducto_RESTInterface( ) : base()
      {
      }

      public Sdtproducto_RESTInterface( Sdtproducto psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "productoid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Productoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Productoid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Productoid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "cambsid" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Cambsid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Cambsid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Cambsid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "productodsc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Productodsc
      {
         get {
            return sdt.gxTpr_Productodsc ;
         }

         set {
            sdt.gxTpr_Productodsc = (String)(value);
         }

      }

      [DataMember( Name = "modeloid" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Modeloid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Modeloid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Modeloid = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "marcaid" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Marcaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Marcaid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Marcaid = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "categoriaid" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Categoriaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Categoriaid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Categoriaid = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "productousuario" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Productousuario
      {
         get {
            return sdt.gxTpr_Productousuario ;
         }

         set {
            sdt.gxTpr_Productousuario = (String)(value);
         }

      }

      [DataMember( Name = "productofecreg" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Productofecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Productofecreg) ;
         }

         set {
            sdt.gxTpr_Productofecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "productofecultact" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Productofecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Productofecultact) ;
         }

         set {
            sdt.gxTpr_Productofecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "tipobienid" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Tipobienid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Tipobienid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Tipobienid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      public Sdtproducto sdt
      {
         get {
            return (Sdtproducto)Sdt ;
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
            sdt = new Sdtproducto() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 31 )]
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
