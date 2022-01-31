/*
               File: type_Sdttipodocumento
        Description: tipodocumento
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:2.6
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
   [XmlRoot(ElementName = "tipodocumento" )]
   [XmlType(TypeName =  "tipodocumento" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdttipodocumento : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdttipodocumento( )
      {
         /* Constructor for serialization */
         gxTv_Sdttipodocumento_Tipodocumentodsc = "";
         gxTv_Sdttipodocumento_Tipodocumentousuario = "";
         gxTv_Sdttipodocumento_Tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Mode = "";
         gxTv_Sdttipodocumento_Tipodocumentodsc_Z = "";
         gxTv_Sdttipodocumento_Tipodocumentousuario_Z = "";
         gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdttipodocumento( IGxContext context )
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

      public void Load( int AV26tipodocumentoid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV26tipodocumentoid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"tipodocumentoid", typeof(int)}}) ;
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
         metadata.Set("Name", "tipodocumento");
         metadata.Set("BT", "TIPODOCUMENTO");
         metadata.Set("PK", "[ \"tipodocumentoid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentoid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentodsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentousuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentofecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentofecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentodsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentousuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentofecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipodocumentofecultact_N" , attrs);
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
         Sdttipodocumento deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdttipodocumento)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdttipodocumento obj ;
         obj = this;
         obj.gxTpr_Tipodocumentoid = deserialized.gxTpr_Tipodocumentoid;
         obj.gxTpr_Tipodocumentodsc = deserialized.gxTpr_Tipodocumentodsc;
         obj.gxTpr_Tipodocumentousuario = deserialized.gxTpr_Tipodocumentousuario;
         obj.gxTpr_Tipodocumentofecreg = deserialized.gxTpr_Tipodocumentofecreg;
         obj.gxTpr_Tipodocumentofecultact = deserialized.gxTpr_Tipodocumentofecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Tipodocumentoid_Z = deserialized.gxTpr_Tipodocumentoid_Z;
         obj.gxTpr_Tipodocumentodsc_Z = deserialized.gxTpr_Tipodocumentodsc_Z;
         obj.gxTpr_Tipodocumentousuario_Z = deserialized.gxTpr_Tipodocumentousuario_Z;
         obj.gxTpr_Tipodocumentofecreg_Z = deserialized.gxTpr_Tipodocumentofecreg_Z;
         obj.gxTpr_Tipodocumentofecultact_Z = deserialized.gxTpr_Tipodocumentofecultact_Z;
         obj.gxTpr_Tipodocumentodsc_N = deserialized.gxTpr_Tipodocumentodsc_N;
         obj.gxTpr_Tipodocumentousuario_N = deserialized.gxTpr_Tipodocumentousuario_N;
         obj.gxTpr_Tipodocumentofecreg_N = deserialized.gxTpr_Tipodocumentofecreg_N;
         obj.gxTpr_Tipodocumentofecultact_N = deserialized.gxTpr_Tipodocumentofecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentoid") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentoid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentodsc") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentodsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentousuario") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentousuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdttipodocumento_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdttipodocumento_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentoid_Z") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentoid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentodsc_Z") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentodsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentousuario_Z") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentousuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentodsc_N") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentodsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentousuario_N") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentousuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecreg_N") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentofecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipodocumentofecultact_N") )
               {
                  gxTv_Sdttipodocumento_Tipodocumentofecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "tipodocumento";
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
         oWriter.WriteElement("tipodocumentoid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentoid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("tipodocumentodsc", StringUtil.RTrim( gxTv_Sdttipodocumento_Tipodocumentodsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("tipodocumentousuario", StringUtil.RTrim( gxTv_Sdttipodocumento_Tipodocumentousuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdttipodocumento_Tipodocumentofecreg) )
         {
            oWriter.WriteStartElement("tipodocumentofecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdttipodocumento_Tipodocumentofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("tipodocumentofecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdttipodocumento_Tipodocumentofecultact) )
         {
            oWriter.WriteStartElement("tipodocumentofecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdttipodocumento_Tipodocumentofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("tipodocumentofecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdttipodocumento_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentoid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentoid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentodsc_Z", StringUtil.RTrim( gxTv_Sdttipodocumento_Tipodocumentodsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentousuario_Z", StringUtil.RTrim( gxTv_Sdttipodocumento_Tipodocumentousuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdttipodocumento_Tipodocumentofecreg_Z) )
            {
               oWriter.WriteStartElement("tipodocumentofecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("tipodocumentofecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdttipodocumento_Tipodocumentofecultact_Z) )
            {
               oWriter.WriteStartElement("tipodocumentofecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("tipodocumentofecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("tipodocumentodsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentodsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentousuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentousuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentofecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentofecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipodocumentofecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipodocumento_Tipodocumentofecultact_N), 1, 0)));
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
         AddObjectProperty("tipodocumentoid", gxTv_Sdttipodocumento_Tipodocumentoid, false);
         AddObjectProperty("tipodocumentodsc", gxTv_Sdttipodocumento_Tipodocumentodsc, false);
         AddObjectProperty("tipodocumentousuario", gxTv_Sdttipodocumento_Tipodocumentousuario, false);
         datetime_STZ = gxTv_Sdttipodocumento_Tipodocumentofecreg;
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
         AddObjectProperty("tipodocumentofecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdttipodocumento_Tipodocumentofecultact;
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
         AddObjectProperty("tipodocumentofecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdttipodocumento_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdttipodocumento_Initialized, false);
            AddObjectProperty("tipodocumentoid_Z", gxTv_Sdttipodocumento_Tipodocumentoid_Z, false);
            AddObjectProperty("tipodocumentodsc_Z", gxTv_Sdttipodocumento_Tipodocumentodsc_Z, false);
            AddObjectProperty("tipodocumentousuario_Z", gxTv_Sdttipodocumento_Tipodocumentousuario_Z, false);
            datetime_STZ = gxTv_Sdttipodocumento_Tipodocumentofecreg_Z;
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
            AddObjectProperty("tipodocumentofecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdttipodocumento_Tipodocumentofecultact_Z;
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
            AddObjectProperty("tipodocumentofecultact_Z", sDateCnv, false);
            AddObjectProperty("tipodocumentodsc_N", gxTv_Sdttipodocumento_Tipodocumentodsc_N, false);
            AddObjectProperty("tipodocumentousuario_N", gxTv_Sdttipodocumento_Tipodocumentousuario_N, false);
            AddObjectProperty("tipodocumentofecreg_N", gxTv_Sdttipodocumento_Tipodocumentofecreg_N, false);
            AddObjectProperty("tipodocumentofecultact_N", gxTv_Sdttipodocumento_Tipodocumentofecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "tipodocumentoid" )]
      [  XmlElement( ElementName = "tipodocumentoid"   )]
      public int gxTpr_Tipodocumentoid
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentoid ;
         }

         set {
            if ( gxTv_Sdttipodocumento_Tipodocumentoid != value )
            {
               gxTv_Sdttipodocumento_Mode = "INS";
               this.gxTv_Sdttipodocumento_Tipodocumentoid_Z_SetNull( );
               this.gxTv_Sdttipodocumento_Tipodocumentodsc_Z_SetNull( );
               this.gxTv_Sdttipodocumento_Tipodocumentousuario_Z_SetNull( );
               this.gxTv_Sdttipodocumento_Tipodocumentofecreg_Z_SetNull( );
               this.gxTv_Sdttipodocumento_Tipodocumentofecultact_Z_SetNull( );
            }
            gxTv_Sdttipodocumento_Tipodocumentoid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "tipodocumentodsc" )]
      [  XmlElement( ElementName = "tipodocumentodsc"   )]
      public String gxTpr_Tipodocumentodsc
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentodsc ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentodsc_N = 0;
            gxTv_Sdttipodocumento_Tipodocumentodsc = (String)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentodsc_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentodsc_N = 1;
         gxTv_Sdttipodocumento_Tipodocumentodsc = "";
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentodsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentousuario" )]
      [  XmlElement( ElementName = "tipodocumentousuario"   )]
      public String gxTpr_Tipodocumentousuario
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentousuario ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentousuario_N = 0;
            gxTv_Sdttipodocumento_Tipodocumentousuario = (String)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentousuario_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentousuario_N = 1;
         gxTv_Sdttipodocumento_Tipodocumentousuario = "";
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentousuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecreg" )]
      [  XmlElement( ElementName = "tipodocumentofecreg"  , IsNullable=true )]
      public string gxTpr_Tipodocumentofecreg_Nullable
      {
         get {
            if ( gxTv_Sdttipodocumento_Tipodocumentofecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdttipodocumento_Tipodocumentofecreg).value ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdttipodocumento_Tipodocumentofecreg = DateTime.MinValue;
            else
               gxTv_Sdttipodocumento_Tipodocumentofecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipodocumentofecreg
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecreg ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecreg_N = 0;
            gxTv_Sdttipodocumento_Tipodocumentofecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecreg_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecreg_N = 1;
         gxTv_Sdttipodocumento_Tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecultact" )]
      [  XmlElement( ElementName = "tipodocumentofecultact"  , IsNullable=true )]
      public string gxTpr_Tipodocumentofecultact_Nullable
      {
         get {
            if ( gxTv_Sdttipodocumento_Tipodocumentofecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdttipodocumento_Tipodocumentofecultact).value ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdttipodocumento_Tipodocumentofecultact = DateTime.MinValue;
            else
               gxTv_Sdttipodocumento_Tipodocumentofecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipodocumentofecultact
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecultact ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecultact_N = 0;
            gxTv_Sdttipodocumento_Tipodocumentofecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecultact_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecultact_N = 1;
         gxTv_Sdttipodocumento_Tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdttipodocumento_Mode ;
         }

         set {
            gxTv_Sdttipodocumento_Mode = (String)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Mode_SetNull( )
      {
         gxTv_Sdttipodocumento_Mode = "";
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdttipodocumento_Initialized ;
         }

         set {
            gxTv_Sdttipodocumento_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Initialized_SetNull( )
      {
         gxTv_Sdttipodocumento_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentoid_Z" )]
      [  XmlElement( ElementName = "tipodocumentoid_Z"   )]
      public int gxTpr_Tipodocumentoid_Z
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentoid_Z ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentoid_Z = (int)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentoid_Z_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentoid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentodsc_Z" )]
      [  XmlElement( ElementName = "tipodocumentodsc_Z"   )]
      public String gxTpr_Tipodocumentodsc_Z
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentodsc_Z ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentodsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentodsc_Z_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentodsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentodsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentousuario_Z" )]
      [  XmlElement( ElementName = "tipodocumentousuario_Z"   )]
      public String gxTpr_Tipodocumentousuario_Z
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentousuario_Z ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentousuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentousuario_Z_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentousuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentousuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecreg_Z" )]
      [  XmlElement( ElementName = "tipodocumentofecreg_Z"  , IsNullable=true )]
      public string gxTpr_Tipodocumentofecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdttipodocumento_Tipodocumentofecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdttipodocumento_Tipodocumentofecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipodocumentofecreg_Z
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecreg_Z ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecreg_Z_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecultact_Z" )]
      [  XmlElement( ElementName = "tipodocumentofecultact_Z"  , IsNullable=true )]
      public string gxTpr_Tipodocumentofecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdttipodocumento_Tipodocumentofecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdttipodocumento_Tipodocumentofecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipodocumentofecultact_Z
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecultact_Z ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecultact_Z_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentodsc_N" )]
      [  XmlElement( ElementName = "tipodocumentodsc_N"   )]
      public short gxTpr_Tipodocumentodsc_N
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentodsc_N ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentodsc_N = (short)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentodsc_N_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentodsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentodsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentousuario_N" )]
      [  XmlElement( ElementName = "tipodocumentousuario_N"   )]
      public short gxTpr_Tipodocumentousuario_N
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentousuario_N ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentousuario_N = (short)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentousuario_N_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentousuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentousuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecreg_N" )]
      [  XmlElement( ElementName = "tipodocumentofecreg_N"   )]
      public short gxTpr_Tipodocumentofecreg_N
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecreg_N ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecreg_N_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipodocumentofecultact_N" )]
      [  XmlElement( ElementName = "tipodocumentofecultact_N"   )]
      public short gxTpr_Tipodocumentofecultact_N
      {
         get {
            return gxTv_Sdttipodocumento_Tipodocumentofecultact_N ;
         }

         set {
            gxTv_Sdttipodocumento_Tipodocumentofecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdttipodocumento_Tipodocumentofecultact_N_SetNull( )
      {
         gxTv_Sdttipodocumento_Tipodocumentofecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipodocumento_Tipodocumentofecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdttipodocumento_Tipodocumentodsc = "";
         gxTv_Sdttipodocumento_Tipodocumentousuario = "";
         gxTv_Sdttipodocumento_Tipodocumentofecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Tipodocumentofecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Mode = "";
         gxTv_Sdttipodocumento_Tipodocumentodsc_Z = "";
         gxTv_Sdttipodocumento_Tipodocumentousuario_Z = "";
         gxTv_Sdttipodocumento_Tipodocumentofecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdttipodocumento_Tipodocumentofecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "tipodocumento", "GeneXus.Programs.tipodocumento_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdttipodocumento_Initialized ;
      private short gxTv_Sdttipodocumento_Tipodocumentodsc_N ;
      private short gxTv_Sdttipodocumento_Tipodocumentousuario_N ;
      private short gxTv_Sdttipodocumento_Tipodocumentofecreg_N ;
      private short gxTv_Sdttipodocumento_Tipodocumentofecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdttipodocumento_Tipodocumentoid ;
      private int gxTv_Sdttipodocumento_Tipodocumentoid_Z ;
      private String gxTv_Sdttipodocumento_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdttipodocumento_Tipodocumentofecreg ;
      private DateTime gxTv_Sdttipodocumento_Tipodocumentofecultact ;
      private DateTime gxTv_Sdttipodocumento_Tipodocumentofecreg_Z ;
      private DateTime gxTv_Sdttipodocumento_Tipodocumentofecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdttipodocumento_Tipodocumentodsc ;
      private String gxTv_Sdttipodocumento_Tipodocumentousuario ;
      private String gxTv_Sdttipodocumento_Tipodocumentodsc_Z ;
      private String gxTv_Sdttipodocumento_Tipodocumentousuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"tipodocumento", Namespace = "Condufef_v1")]
   public class Sdttipodocumento_RESTInterface : GxGenericCollectionItem<Sdttipodocumento>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdttipodocumento_RESTInterface( ) : base()
      {
      }

      public Sdttipodocumento_RESTInterface( Sdttipodocumento psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "tipodocumentoid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Tipodocumentoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Tipodocumentoid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Tipodocumentoid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "tipodocumentodsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Tipodocumentodsc
      {
         get {
            return sdt.gxTpr_Tipodocumentodsc ;
         }

         set {
            sdt.gxTpr_Tipodocumentodsc = (String)(value);
         }

      }

      [DataMember( Name = "tipodocumentousuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Tipodocumentousuario
      {
         get {
            return sdt.gxTpr_Tipodocumentousuario ;
         }

         set {
            sdt.gxTpr_Tipodocumentousuario = (String)(value);
         }

      }

      [DataMember( Name = "tipodocumentofecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Tipodocumentofecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Tipodocumentofecreg) ;
         }

         set {
            sdt.gxTpr_Tipodocumentofecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "tipodocumentofecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Tipodocumentofecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Tipodocumentofecultact) ;
         }

         set {
            sdt.gxTpr_Tipodocumentofecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdttipodocumento sdt
      {
         get {
            return (Sdttipodocumento)Sdt ;
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
            sdt = new Sdttipodocumento() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 16 )]
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
