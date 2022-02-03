/*
               File: type_Sdtestatusarticulo
        Description: estatusarticulo
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:20.69
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
   [XmlRoot(ElementName = "estatusarticulo" )]
   [XmlType(TypeName =  "estatusarticulo" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtestatusarticulo : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtestatusarticulo( )
      {
         /* Constructor for serialization */
         gxTv_Sdtestatusarticulo_Estatusarticulodsc = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousuario = "";
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Mode = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtestatusarticulo( IGxContext context )
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

      public void Load( long AV12estatusarticuloid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV12estatusarticuloid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"estatusarticuloid", typeof(long)}}) ;
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
         metadata.Set("Name", "estatusarticulo");
         metadata.Set("BT", "ESTATUSARTICULO");
         metadata.Set("PK", "[ \"estatusarticuloid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Estatusarticuloid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulodsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulodescuso_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticuloaplicamov_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulousotabla_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulousuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulofecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulofecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulodsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulodescuso_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticuloaplicamov_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulousotabla_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulousuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulofecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estatusarticulofecultact_N" , attrs);
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
         Sdtestatusarticulo deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtestatusarticulo)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtestatusarticulo obj ;
         obj = this;
         obj.gxTpr_Estatusarticuloid = deserialized.gxTpr_Estatusarticuloid;
         obj.gxTpr_Estatusarticulodsc = deserialized.gxTpr_Estatusarticulodsc;
         obj.gxTpr_Estatusarticulodescuso = deserialized.gxTpr_Estatusarticulodescuso;
         obj.gxTpr_Estatusarticuloaplicamov = deserialized.gxTpr_Estatusarticuloaplicamov;
         obj.gxTpr_Estatusarticulousotabla = deserialized.gxTpr_Estatusarticulousotabla;
         obj.gxTpr_Estatusarticulousuario = deserialized.gxTpr_Estatusarticulousuario;
         obj.gxTpr_Estatusarticulofecreg = deserialized.gxTpr_Estatusarticulofecreg;
         obj.gxTpr_Estatusarticulofecultact = deserialized.gxTpr_Estatusarticulofecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Estatusarticuloid_Z = deserialized.gxTpr_Estatusarticuloid_Z;
         obj.gxTpr_Estatusarticulodsc_Z = deserialized.gxTpr_Estatusarticulodsc_Z;
         obj.gxTpr_Estatusarticulodescuso_Z = deserialized.gxTpr_Estatusarticulodescuso_Z;
         obj.gxTpr_Estatusarticuloaplicamov_Z = deserialized.gxTpr_Estatusarticuloaplicamov_Z;
         obj.gxTpr_Estatusarticulousotabla_Z = deserialized.gxTpr_Estatusarticulousotabla_Z;
         obj.gxTpr_Estatusarticulousuario_Z = deserialized.gxTpr_Estatusarticulousuario_Z;
         obj.gxTpr_Estatusarticulofecreg_Z = deserialized.gxTpr_Estatusarticulofecreg_Z;
         obj.gxTpr_Estatusarticulofecultact_Z = deserialized.gxTpr_Estatusarticulofecultact_Z;
         obj.gxTpr_Estatusarticulodsc_N = deserialized.gxTpr_Estatusarticulodsc_N;
         obj.gxTpr_Estatusarticulodescuso_N = deserialized.gxTpr_Estatusarticulodescuso_N;
         obj.gxTpr_Estatusarticuloaplicamov_N = deserialized.gxTpr_Estatusarticuloaplicamov_N;
         obj.gxTpr_Estatusarticulousotabla_N = deserialized.gxTpr_Estatusarticulousotabla_N;
         obj.gxTpr_Estatusarticulousuario_N = deserialized.gxTpr_Estatusarticulousuario_N;
         obj.gxTpr_Estatusarticulofecreg_N = deserialized.gxTpr_Estatusarticulofecreg_N;
         obj.gxTpr_Estatusarticulofecultact_N = deserialized.gxTpr_Estatusarticulofecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticuloid") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticuloid = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodsc") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodescuso") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodescuso = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticuloaplicamov") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousotabla") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousotabla = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousuario") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtestatusarticulo_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtestatusarticulo_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticuloid_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticuloid_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodsc_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodescuso_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticuloaplicamov_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousotabla_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousuario_Z") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodsc_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulodescuso_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticuloaplicamov_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousotabla_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulousuario_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulousuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecreg_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estatusarticulofecultact_N") )
               {
                  gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "estatusarticulo";
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
         oWriter.WriteElement("estatusarticuloid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloid), 18, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estatusarticulodsc", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulodsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estatusarticulodescuso", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulodescuso));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estatusarticuloaplicamov", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estatusarticulousotabla", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulousotabla));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estatusarticulousuario", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulousuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtestatusarticulo_Estatusarticulofecreg) )
         {
            oWriter.WriteStartElement("estatusarticulofecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtestatusarticulo_Estatusarticulofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("estatusarticulofecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtestatusarticulo_Estatusarticulofecultact) )
         {
            oWriter.WriteStartElement("estatusarticulofecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtestatusarticulo_Estatusarticulofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("estatusarticulofecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticuloid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloid_Z), 18, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulodsc_Z", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulodescuso_Z", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticuloaplicamov_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulousotabla_Z", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulousuario_Z", StringUtil.RTrim( gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z) )
            {
               oWriter.WriteStartElement("estatusarticulofecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("estatusarticulofecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z) )
            {
               oWriter.WriteStartElement("estatusarticulofecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("estatusarticulofecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("estatusarticulodsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulodsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulodescuso_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticuloaplicamov_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulousotabla_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulousuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulousuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulofecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estatusarticulofecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N), 1, 0)));
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
         AddObjectProperty("estatusarticuloid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloid), 18, 0)), false);
         AddObjectProperty("estatusarticulodsc", gxTv_Sdtestatusarticulo_Estatusarticulodsc, false);
         AddObjectProperty("estatusarticulodescuso", gxTv_Sdtestatusarticulo_Estatusarticulodescuso, false);
         AddObjectProperty("estatusarticuloaplicamov", gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov, false);
         AddObjectProperty("estatusarticulousotabla", gxTv_Sdtestatusarticulo_Estatusarticulousotabla, false);
         AddObjectProperty("estatusarticulousuario", gxTv_Sdtestatusarticulo_Estatusarticulousuario, false);
         datetime_STZ = gxTv_Sdtestatusarticulo_Estatusarticulofecreg;
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
         AddObjectProperty("estatusarticulofecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtestatusarticulo_Estatusarticulofecultact;
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
         AddObjectProperty("estatusarticulofecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtestatusarticulo_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtestatusarticulo_Initialized, false);
            AddObjectProperty("estatusarticuloid_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtestatusarticulo_Estatusarticuloid_Z), 18, 0)), false);
            AddObjectProperty("estatusarticulodsc_Z", gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z, false);
            AddObjectProperty("estatusarticulodescuso_Z", gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z, false);
            AddObjectProperty("estatusarticuloaplicamov_Z", gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z, false);
            AddObjectProperty("estatusarticulousotabla_Z", gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z, false);
            AddObjectProperty("estatusarticulousuario_Z", gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z, false);
            datetime_STZ = gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z;
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
            AddObjectProperty("estatusarticulofecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z;
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
            AddObjectProperty("estatusarticulofecultact_Z", sDateCnv, false);
            AddObjectProperty("estatusarticulodsc_N", gxTv_Sdtestatusarticulo_Estatusarticulodsc_N, false);
            AddObjectProperty("estatusarticulodescuso_N", gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N, false);
            AddObjectProperty("estatusarticuloaplicamov_N", gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N, false);
            AddObjectProperty("estatusarticulousotabla_N", gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N, false);
            AddObjectProperty("estatusarticulousuario_N", gxTv_Sdtestatusarticulo_Estatusarticulousuario_N, false);
            AddObjectProperty("estatusarticulofecreg_N", gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N, false);
            AddObjectProperty("estatusarticulofecultact_N", gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "estatusarticuloid" )]
      [  XmlElement( ElementName = "estatusarticuloid"   )]
      public long gxTpr_Estatusarticuloid
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticuloid ;
         }

         set {
            if ( gxTv_Sdtestatusarticulo_Estatusarticuloid != value )
            {
               gxTv_Sdtestatusarticulo_Mode = "INS";
               this.gxTv_Sdtestatusarticulo_Estatusarticuloid_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z_SetNull( );
               this.gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z_SetNull( );
            }
            gxTv_Sdtestatusarticulo_Estatusarticuloid = (long)(value);
         }

      }

      [  SoapElement( ElementName = "estatusarticulodsc" )]
      [  XmlElement( ElementName = "estatusarticulodsc"   )]
      public String gxTpr_Estatusarticulodsc
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodsc ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodsc_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulodsc = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodsc_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodsc_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulodsc = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulodescuso" )]
      [  XmlElement( ElementName = "estatusarticulodescuso"   )]
      public String gxTpr_Estatusarticulodescuso
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodescuso ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulodescuso = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodescuso_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodescuso_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticuloaplicamov" )]
      [  XmlElement( ElementName = "estatusarticuloaplicamov"   )]
      public int gxTpr_Estatusarticuloaplicamov
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov = (int)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousotabla" )]
      [  XmlElement( ElementName = "estatusarticulousotabla"   )]
      public String gxTpr_Estatusarticulousotabla
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousotabla ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulousotabla = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousotabla_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousotabla_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousuario" )]
      [  XmlElement( ElementName = "estatusarticulousuario"   )]
      public String gxTpr_Estatusarticulousuario
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousuario ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousuario_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulousuario = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousuario_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousuario_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulousuario = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecreg" )]
      [  XmlElement( ElementName = "estatusarticulofecreg"  , IsNullable=true )]
      public string gxTpr_Estatusarticulofecreg_Nullable
      {
         get {
            if ( gxTv_Sdtestatusarticulo_Estatusarticulofecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtestatusarticulo_Estatusarticulofecreg).value ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtestatusarticulo_Estatusarticulofecreg = DateTime.MinValue;
            else
               gxTv_Sdtestatusarticulo_Estatusarticulofecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Estatusarticulofecreg
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecreg ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulofecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecreg_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecultact" )]
      [  XmlElement( ElementName = "estatusarticulofecultact"  , IsNullable=true )]
      public string gxTpr_Estatusarticulofecultact_Nullable
      {
         get {
            if ( gxTv_Sdtestatusarticulo_Estatusarticulofecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtestatusarticulo_Estatusarticulofecultact).value ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtestatusarticulo_Estatusarticulofecultact = DateTime.MinValue;
            else
               gxTv_Sdtestatusarticulo_Estatusarticulofecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Estatusarticulofecultact
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecultact ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = 0;
            gxTv_Sdtestatusarticulo_Estatusarticulofecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecultact_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = 1;
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtestatusarticulo_Mode ;
         }

         set {
            gxTv_Sdtestatusarticulo_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Mode_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtestatusarticulo_Initialized ;
         }

         set {
            gxTv_Sdtestatusarticulo_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Initialized_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticuloid_Z" )]
      [  XmlElement( ElementName = "estatusarticuloid_Z"   )]
      public long gxTpr_Estatusarticuloid_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticuloid_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticuloid_Z = (long)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticuloid_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticuloid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticuloid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulodsc_Z" )]
      [  XmlElement( ElementName = "estatusarticulodsc_Z"   )]
      public String gxTpr_Estatusarticulodsc_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulodescuso_Z" )]
      [  XmlElement( ElementName = "estatusarticulodescuso_Z"   )]
      public String gxTpr_Estatusarticulodescuso_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticuloaplicamov_Z" )]
      [  XmlElement( ElementName = "estatusarticuloaplicamov_Z"   )]
      public int gxTpr_Estatusarticuloaplicamov_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z = (int)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousotabla_Z" )]
      [  XmlElement( ElementName = "estatusarticulousotabla_Z"   )]
      public String gxTpr_Estatusarticulousotabla_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousuario_Z" )]
      [  XmlElement( ElementName = "estatusarticulousuario_Z"   )]
      public String gxTpr_Estatusarticulousuario_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecreg_Z" )]
      [  XmlElement( ElementName = "estatusarticulofecreg_Z"  , IsNullable=true )]
      public string gxTpr_Estatusarticulofecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Estatusarticulofecreg_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecultact_Z" )]
      [  XmlElement( ElementName = "estatusarticulofecultact_Z"  , IsNullable=true )]
      public string gxTpr_Estatusarticulofecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Estatusarticulofecultact_Z
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulodsc_N" )]
      [  XmlElement( ElementName = "estatusarticulodsc_N"   )]
      public short gxTpr_Estatusarticulodsc_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodsc_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodsc_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulodescuso_N" )]
      [  XmlElement( ElementName = "estatusarticulodescuso_N"   )]
      public short gxTpr_Estatusarticulodescuso_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticuloaplicamov_N" )]
      [  XmlElement( ElementName = "estatusarticuloaplicamov_N"   )]
      public short gxTpr_Estatusarticuloaplicamov_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousotabla_N" )]
      [  XmlElement( ElementName = "estatusarticulousotabla_N"   )]
      public short gxTpr_Estatusarticulousotabla_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulousuario_N" )]
      [  XmlElement( ElementName = "estatusarticulousuario_N"   )]
      public short gxTpr_Estatusarticulousuario_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulousuario_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulousuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulousuario_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulousuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulousuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecreg_N" )]
      [  XmlElement( ElementName = "estatusarticulofecreg_N"   )]
      public short gxTpr_Estatusarticulofecreg_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estatusarticulofecultact_N" )]
      [  XmlElement( ElementName = "estatusarticulofecultact_N"   )]
      public short gxTpr_Estatusarticulofecultact_N
      {
         get {
            return gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N ;
         }

         set {
            gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N_SetNull( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtestatusarticulo_Estatusarticulodsc = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousuario = "";
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Mode = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z = "";
         gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "estatusarticulo", "GeneXus.Programs.estatusarticulo_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtestatusarticulo_Initialized ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulodsc_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulodescuso_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulousotabla_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulousuario_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulofecreg_N ;
      private short gxTv_Sdtestatusarticulo_Estatusarticulofecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov ;
      private int gxTv_Sdtestatusarticulo_Estatusarticuloaplicamov_Z ;
      private long gxTv_Sdtestatusarticulo_Estatusarticuloid ;
      private long gxTv_Sdtestatusarticulo_Estatusarticuloid_Z ;
      private String gxTv_Sdtestatusarticulo_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtestatusarticulo_Estatusarticulofecreg ;
      private DateTime gxTv_Sdtestatusarticulo_Estatusarticulofecultact ;
      private DateTime gxTv_Sdtestatusarticulo_Estatusarticulofecreg_Z ;
      private DateTime gxTv_Sdtestatusarticulo_Estatusarticulofecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulodsc ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulodescuso ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulousotabla ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulousuario ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulodsc_Z ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulodescuso_Z ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulousotabla_Z ;
      private String gxTv_Sdtestatusarticulo_Estatusarticulousuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"estatusarticulo", Namespace = "Condufef_v1")]
   public class Sdtestatusarticulo_RESTInterface : GxGenericCollectionItem<Sdtestatusarticulo>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtestatusarticulo_RESTInterface( ) : base()
      {
      }

      public Sdtestatusarticulo_RESTInterface( Sdtestatusarticulo psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "estatusarticuloid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticuloid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Estatusarticuloid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Estatusarticuloid = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "estatusarticulodsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulodsc
      {
         get {
            return sdt.gxTpr_Estatusarticulodsc ;
         }

         set {
            sdt.gxTpr_Estatusarticulodsc = (String)(value);
         }

      }

      [DataMember( Name = "estatusarticulodescuso" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulodescuso
      {
         get {
            return sdt.gxTpr_Estatusarticulodescuso ;
         }

         set {
            sdt.gxTpr_Estatusarticulodescuso = (String)(value);
         }

      }

      [DataMember( Name = "estatusarticuloaplicamov" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticuloaplicamov
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Estatusarticuloaplicamov), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Estatusarticuloaplicamov = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "estatusarticulousotabla" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulousotabla
      {
         get {
            return sdt.gxTpr_Estatusarticulousotabla ;
         }

         set {
            sdt.gxTpr_Estatusarticulousotabla = (String)(value);
         }

      }

      [DataMember( Name = "estatusarticulousuario" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulousuario
      {
         get {
            return sdt.gxTpr_Estatusarticulousuario ;
         }

         set {
            sdt.gxTpr_Estatusarticulousuario = (String)(value);
         }

      }

      [DataMember( Name = "estatusarticulofecreg" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulofecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Estatusarticulofecreg) ;
         }

         set {
            sdt.gxTpr_Estatusarticulofecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "estatusarticulofecultact" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Estatusarticulofecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Estatusarticulofecultact) ;
         }

         set {
            sdt.gxTpr_Estatusarticulofecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtestatusarticulo sdt
      {
         get {
            return (Sdtestatusarticulo)Sdt ;
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
            sdt = new Sdtestatusarticulo() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 25 )]
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
