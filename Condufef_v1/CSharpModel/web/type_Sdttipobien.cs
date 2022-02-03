/*
               File: type_Sdttipobien
        Description: tipobien
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:11.53
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
   [XmlRoot(ElementName = "tipobien" )]
   [XmlType(TypeName =  "tipobien" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdttipobien : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdttipobien( )
      {
         /* Constructor for serialization */
         gxTv_Sdttipobien_Tipobiendsc = "";
         gxTv_Sdttipobien_Tipobienusuario = "";
         gxTv_Sdttipobien_Tipobienfecreg = DateTime.MinValue;
         gxTv_Sdttipobien_Tipobienfecultact = DateTime.MinValue;
         gxTv_Sdttipobien_Mode = "";
         gxTv_Sdttipobien_Tipobiendsc_Z = "";
         gxTv_Sdttipobien_Tipobienusuario_Z = "";
         gxTv_Sdttipobien_Tipobienfecreg_Z = DateTime.MinValue;
         gxTv_Sdttipobien_Tipobienfecultact_Z = DateTime.MinValue;
      }

      public Sdttipobien( IGxContext context )
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

      public void Load( int AV23tipobienid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV23tipobienid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"tipobienid", typeof(int)}}) ;
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
         metadata.Set("Name", "tipobien");
         metadata.Set("BT", "TIPOBIEN");
         metadata.Set("PK", "[ \"tipobienid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Tipobienid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobiendsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobiendsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Tipobienfecultact_N" , attrs);
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
         Sdttipobien deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdttipobien)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdttipobien obj ;
         obj = this;
         obj.gxTpr_Tipobienid = deserialized.gxTpr_Tipobienid;
         obj.gxTpr_Tipobiendsc = deserialized.gxTpr_Tipobiendsc;
         obj.gxTpr_Tipobienusuario = deserialized.gxTpr_Tipobienusuario;
         obj.gxTpr_Tipobienfecreg = deserialized.gxTpr_Tipobienfecreg;
         obj.gxTpr_Tipobienfecultact = deserialized.gxTpr_Tipobienfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Tipobienid_Z = deserialized.gxTpr_Tipobienid_Z;
         obj.gxTpr_Tipobiendsc_Z = deserialized.gxTpr_Tipobiendsc_Z;
         obj.gxTpr_Tipobienusuario_Z = deserialized.gxTpr_Tipobienusuario_Z;
         obj.gxTpr_Tipobienfecreg_Z = deserialized.gxTpr_Tipobienfecreg_Z;
         obj.gxTpr_Tipobienfecultact_Z = deserialized.gxTpr_Tipobienfecultact_Z;
         obj.gxTpr_Tipobienid_N = deserialized.gxTpr_Tipobienid_N;
         obj.gxTpr_Tipobiendsc_N = deserialized.gxTpr_Tipobiendsc_N;
         obj.gxTpr_Tipobienusuario_N = deserialized.gxTpr_Tipobienusuario_N;
         obj.gxTpr_Tipobienfecreg_N = deserialized.gxTpr_Tipobienfecreg_N;
         obj.gxTpr_Tipobienfecultact_N = deserialized.gxTpr_Tipobienfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid") )
               {
                  gxTv_Sdttipobien_Tipobienid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobiendsc") )
               {
                  gxTv_Sdttipobien_Tipobiendsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienusuario") )
               {
                  gxTv_Sdttipobien_Tipobienusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipobien_Tipobienfecreg = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdttipobien_Tipobienfecreg = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipobien_Tipobienfecultact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdttipobien_Tipobienfecultact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdttipobien_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdttipobien_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid_Z") )
               {
                  gxTv_Sdttipobien_Tipobienid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobiendsc_Z") )
               {
                  gxTv_Sdttipobien_Tipobiendsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienusuario_Z") )
               {
                  gxTv_Sdttipobien_Tipobienusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipobien_Tipobienfecreg_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdttipobien_Tipobienfecreg_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdttipobien_Tipobienfecultact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdttipobien_Tipobienfecultact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienid_N") )
               {
                  gxTv_Sdttipobien_Tipobienid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobiendsc_N") )
               {
                  gxTv_Sdttipobien_Tipobiendsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienusuario_N") )
               {
                  gxTv_Sdttipobien_Tipobienusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecreg_N") )
               {
                  gxTv_Sdttipobien_Tipobienfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "tipobienfecultact_N") )
               {
                  gxTv_Sdttipobien_Tipobienfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "tipobien";
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
         oWriter.WriteElement("tipobienid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("tipobiendsc", StringUtil.RTrim( gxTv_Sdttipobien_Tipobiendsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("tipobienusuario", StringUtil.RTrim( gxTv_Sdttipobien_Tipobienusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdttipobien_Tipobienfecreg) )
         {
            oWriter.WriteStartElement("tipobienfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("tipobienfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdttipobien_Tipobienfecultact) )
         {
            oWriter.WriteStartElement("tipobienfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("tipobienfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdttipobien_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobiendsc_Z", StringUtil.RTrim( gxTv_Sdttipobien_Tipobiendsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienusuario_Z", StringUtil.RTrim( gxTv_Sdttipobien_Tipobienusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdttipobien_Tipobienfecreg_Z) )
            {
               oWriter.WriteStartElement("tipobienfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("tipobienfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdttipobien_Tipobienfecultact_Z) )
            {
               oWriter.WriteStartElement("tipobienfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("tipobienfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("tipobienid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobiendsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobiendsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("tipobienfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdttipobien_Tipobienfecultact_N), 1, 0)));
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
         AddObjectProperty("tipobienid", gxTv_Sdttipobien_Tipobienid, false);
         AddObjectProperty("tipobiendsc", gxTv_Sdttipobien_Tipobiendsc, false);
         AddObjectProperty("tipobienusuario", gxTv_Sdttipobien_Tipobienusuario, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("tipobienfecreg", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("tipobienfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdttipobien_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdttipobien_Initialized, false);
            AddObjectProperty("tipobienid_Z", gxTv_Sdttipobien_Tipobienid_Z, false);
            AddObjectProperty("tipobiendsc_Z", gxTv_Sdttipobien_Tipobiendsc_Z, false);
            AddObjectProperty("tipobienusuario_Z", gxTv_Sdttipobien_Tipobienusuario_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("tipobienfecreg_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdttipobien_Tipobienfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("tipobienfecultact_Z", sDateCnv, false);
            AddObjectProperty("tipobienid_N", gxTv_Sdttipobien_Tipobienid_N, false);
            AddObjectProperty("tipobiendsc_N", gxTv_Sdttipobien_Tipobiendsc_N, false);
            AddObjectProperty("tipobienusuario_N", gxTv_Sdttipobien_Tipobienusuario_N, false);
            AddObjectProperty("tipobienfecreg_N", gxTv_Sdttipobien_Tipobienfecreg_N, false);
            AddObjectProperty("tipobienfecultact_N", gxTv_Sdttipobien_Tipobienfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "tipobienid" )]
      [  XmlElement( ElementName = "tipobienid"   )]
      public int gxTpr_Tipobienid
      {
         get {
            return gxTv_Sdttipobien_Tipobienid ;
         }

         set {
            if ( gxTv_Sdttipobien_Tipobienid != value )
            {
               gxTv_Sdttipobien_Mode = "INS";
               this.gxTv_Sdttipobien_Tipobienid_Z_SetNull( );
               this.gxTv_Sdttipobien_Tipobiendsc_Z_SetNull( );
               this.gxTv_Sdttipobien_Tipobienusuario_Z_SetNull( );
               this.gxTv_Sdttipobien_Tipobienfecreg_Z_SetNull( );
               this.gxTv_Sdttipobien_Tipobienfecultact_Z_SetNull( );
            }
            gxTv_Sdttipobien_Tipobienid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "tipobiendsc" )]
      [  XmlElement( ElementName = "tipobiendsc"   )]
      public String gxTpr_Tipobiendsc
      {
         get {
            return gxTv_Sdttipobien_Tipobiendsc ;
         }

         set {
            gxTv_Sdttipobien_Tipobiendsc_N = 0;
            gxTv_Sdttipobien_Tipobiendsc = (String)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobiendsc_SetNull( )
      {
         gxTv_Sdttipobien_Tipobiendsc_N = 1;
         gxTv_Sdttipobien_Tipobiendsc = "";
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobiendsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienusuario" )]
      [  XmlElement( ElementName = "tipobienusuario"   )]
      public String gxTpr_Tipobienusuario
      {
         get {
            return gxTv_Sdttipobien_Tipobienusuario ;
         }

         set {
            gxTv_Sdttipobien_Tipobienusuario_N = 0;
            gxTv_Sdttipobien_Tipobienusuario = (String)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienusuario_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienusuario_N = 1;
         gxTv_Sdttipobien_Tipobienusuario = "";
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecreg" )]
      [  XmlElement( ElementName = "tipobienfecreg"  , IsNullable=true )]
      public string gxTpr_Tipobienfecreg_Nullable
      {
         get {
            if ( gxTv_Sdttipobien_Tipobienfecreg == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdttipobien_Tipobienfecreg).value ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecreg_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdttipobien_Tipobienfecreg = DateTime.MinValue;
            else
               gxTv_Sdttipobien_Tipobienfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipobienfecreg
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecreg ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecreg_N = 0;
            gxTv_Sdttipobien_Tipobienfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecreg_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecreg_N = 1;
         gxTv_Sdttipobien_Tipobienfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecultact" )]
      [  XmlElement( ElementName = "tipobienfecultact"  , IsNullable=true )]
      public string gxTpr_Tipobienfecultact_Nullable
      {
         get {
            if ( gxTv_Sdttipobien_Tipobienfecultact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdttipobien_Tipobienfecultact).value ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecultact_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdttipobien_Tipobienfecultact = DateTime.MinValue;
            else
               gxTv_Sdttipobien_Tipobienfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipobienfecultact
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecultact ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecultact_N = 0;
            gxTv_Sdttipobien_Tipobienfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecultact_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecultact_N = 1;
         gxTv_Sdttipobien_Tipobienfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdttipobien_Mode ;
         }

         set {
            gxTv_Sdttipobien_Mode = (String)(value);
         }

      }

      public void gxTv_Sdttipobien_Mode_SetNull( )
      {
         gxTv_Sdttipobien_Mode = "";
         return  ;
      }

      public bool gxTv_Sdttipobien_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdttipobien_Initialized ;
         }

         set {
            gxTv_Sdttipobien_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Initialized_SetNull( )
      {
         gxTv_Sdttipobien_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienid_Z" )]
      [  XmlElement( ElementName = "tipobienid_Z"   )]
      public int gxTpr_Tipobienid_Z
      {
         get {
            return gxTv_Sdttipobien_Tipobienid_Z ;
         }

         set {
            gxTv_Sdttipobien_Tipobienid_Z = (int)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienid_Z_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobiendsc_Z" )]
      [  XmlElement( ElementName = "tipobiendsc_Z"   )]
      public String gxTpr_Tipobiendsc_Z
      {
         get {
            return gxTv_Sdttipobien_Tipobiendsc_Z ;
         }

         set {
            gxTv_Sdttipobien_Tipobiendsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobiendsc_Z_SetNull( )
      {
         gxTv_Sdttipobien_Tipobiendsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobiendsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienusuario_Z" )]
      [  XmlElement( ElementName = "tipobienusuario_Z"   )]
      public String gxTpr_Tipobienusuario_Z
      {
         get {
            return gxTv_Sdttipobien_Tipobienusuario_Z ;
         }

         set {
            gxTv_Sdttipobien_Tipobienusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienusuario_Z_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecreg_Z" )]
      [  XmlElement( ElementName = "tipobienfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Tipobienfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdttipobien_Tipobienfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdttipobien_Tipobienfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdttipobien_Tipobienfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdttipobien_Tipobienfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipobienfecreg_Z
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecreg_Z ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecreg_Z_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecultact_Z" )]
      [  XmlElement( ElementName = "tipobienfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Tipobienfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdttipobien_Tipobienfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdttipobien_Tipobienfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdttipobien_Tipobienfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdttipobien_Tipobienfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Tipobienfecultact_Z
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecultact_Z ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecultact_Z_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienid_N" )]
      [  XmlElement( ElementName = "tipobienid_N"   )]
      public short gxTpr_Tipobienid_N
      {
         get {
            return gxTv_Sdttipobien_Tipobienid_N ;
         }

         set {
            gxTv_Sdttipobien_Tipobienid_N = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienid_N_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienid_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobiendsc_N" )]
      [  XmlElement( ElementName = "tipobiendsc_N"   )]
      public short gxTpr_Tipobiendsc_N
      {
         get {
            return gxTv_Sdttipobien_Tipobiendsc_N ;
         }

         set {
            gxTv_Sdttipobien_Tipobiendsc_N = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobiendsc_N_SetNull( )
      {
         gxTv_Sdttipobien_Tipobiendsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobiendsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienusuario_N" )]
      [  XmlElement( ElementName = "tipobienusuario_N"   )]
      public short gxTpr_Tipobienusuario_N
      {
         get {
            return gxTv_Sdttipobien_Tipobienusuario_N ;
         }

         set {
            gxTv_Sdttipobien_Tipobienusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienusuario_N_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecreg_N" )]
      [  XmlElement( ElementName = "tipobienfecreg_N"   )]
      public short gxTpr_Tipobienfecreg_N
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecreg_N ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecreg_N_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "tipobienfecultact_N" )]
      [  XmlElement( ElementName = "tipobienfecultact_N"   )]
      public short gxTpr_Tipobienfecultact_N
      {
         get {
            return gxTv_Sdttipobien_Tipobienfecultact_N ;
         }

         set {
            gxTv_Sdttipobien_Tipobienfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdttipobien_Tipobienfecultact_N_SetNull( )
      {
         gxTv_Sdttipobien_Tipobienfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdttipobien_Tipobienfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdttipobien_Tipobiendsc = "";
         gxTv_Sdttipobien_Tipobienusuario = "";
         gxTv_Sdttipobien_Tipobienfecreg = DateTime.MinValue;
         gxTv_Sdttipobien_Tipobienfecultact = DateTime.MinValue;
         gxTv_Sdttipobien_Mode = "";
         gxTv_Sdttipobien_Tipobiendsc_Z = "";
         gxTv_Sdttipobien_Tipobienusuario_Z = "";
         gxTv_Sdttipobien_Tipobienfecreg_Z = DateTime.MinValue;
         gxTv_Sdttipobien_Tipobienfecultact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "tipobien", "GeneXus.Programs.tipobien_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdttipobien_Initialized ;
      private short gxTv_Sdttipobien_Tipobienid_N ;
      private short gxTv_Sdttipobien_Tipobiendsc_N ;
      private short gxTv_Sdttipobien_Tipobienusuario_N ;
      private short gxTv_Sdttipobien_Tipobienfecreg_N ;
      private short gxTv_Sdttipobien_Tipobienfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdttipobien_Tipobienid ;
      private int gxTv_Sdttipobien_Tipobienid_Z ;
      private String gxTv_Sdttipobien_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdttipobien_Tipobienfecreg ;
      private DateTime gxTv_Sdttipobien_Tipobienfecultact ;
      private DateTime gxTv_Sdttipobien_Tipobienfecreg_Z ;
      private DateTime gxTv_Sdttipobien_Tipobienfecultact_Z ;
      private String gxTv_Sdttipobien_Tipobiendsc ;
      private String gxTv_Sdttipobien_Tipobienusuario ;
      private String gxTv_Sdttipobien_Tipobiendsc_Z ;
      private String gxTv_Sdttipobien_Tipobienusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"tipobien", Namespace = "Condufef_v1")]
   public class Sdttipobien_RESTInterface : GxGenericCollectionItem<Sdttipobien>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdttipobien_RESTInterface( ) : base()
      {
      }

      public Sdttipobien_RESTInterface( Sdttipobien psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "tipobienid" , Order = 0 )]
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

      [DataMember( Name = "tipobiendsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Tipobiendsc
      {
         get {
            return sdt.gxTpr_Tipobiendsc ;
         }

         set {
            sdt.gxTpr_Tipobiendsc = (String)(value);
         }

      }

      [DataMember( Name = "tipobienusuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Tipobienusuario
      {
         get {
            return sdt.gxTpr_Tipobienusuario ;
         }

         set {
            sdt.gxTpr_Tipobienusuario = (String)(value);
         }

      }

      [DataMember( Name = "tipobienfecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Tipobienfecreg
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Tipobienfecreg) ;
         }

         set {
            sdt.gxTpr_Tipobienfecreg = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "tipobienfecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Tipobienfecultact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Tipobienfecultact) ;
         }

         set {
            sdt.gxTpr_Tipobienfecultact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      public Sdttipobien sdt
      {
         get {
            return (Sdttipobien)Sdt ;
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
            sdt = new Sdttipobien() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 17 )]
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
