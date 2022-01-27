/*
               File: type_Sdtarea
        Description: area
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:7:39.74
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
   [XmlRoot(ElementName = "area" )]
   [XmlType(TypeName =  "area" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtarea : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtarea( )
      {
         /* Constructor for serialization */
         gxTv_Sdtarea_Areadsc = "";
         gxTv_Sdtarea_Areastatusadsc = "";
         gxTv_Sdtarea_Areausuario = "";
         gxTv_Sdtarea_Areafecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Areafecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Mode = "";
         gxTv_Sdtarea_Areadsc_Z = "";
         gxTv_Sdtarea_Areastatusadsc_Z = "";
         gxTv_Sdtarea_Areausuario_Z = "";
         gxTv_Sdtarea_Areafecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Areafecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtarea( IGxContext context )
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

      public void Load( int AV22areaareaid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV22areaareaid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"areaareaid", typeof(int)}}) ;
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
         metadata.Set("Name", "area");
         metadata.Set("BT", "AREA");
         metadata.Set("PK", "[ \"areaareaid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Areaareaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areadsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areastatusadsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areausuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areafecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areafecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areadsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areastatusadsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areausuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areafecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Areafecultact_N" , attrs);
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
         Sdtarea deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtarea)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtarea obj ;
         obj = this;
         obj.gxTpr_Areaareaid = deserialized.gxTpr_Areaareaid;
         obj.gxTpr_Areadsc = deserialized.gxTpr_Areadsc;
         obj.gxTpr_Areastatusadsc = deserialized.gxTpr_Areastatusadsc;
         obj.gxTpr_Areausuario = deserialized.gxTpr_Areausuario;
         obj.gxTpr_Areafecreg = deserialized.gxTpr_Areafecreg;
         obj.gxTpr_Areafecultact = deserialized.gxTpr_Areafecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Areaareaid_Z = deserialized.gxTpr_Areaareaid_Z;
         obj.gxTpr_Areadsc_Z = deserialized.gxTpr_Areadsc_Z;
         obj.gxTpr_Areastatusadsc_Z = deserialized.gxTpr_Areastatusadsc_Z;
         obj.gxTpr_Areausuario_Z = deserialized.gxTpr_Areausuario_Z;
         obj.gxTpr_Areafecreg_Z = deserialized.gxTpr_Areafecreg_Z;
         obj.gxTpr_Areafecultact_Z = deserialized.gxTpr_Areafecultact_Z;
         obj.gxTpr_Areadsc_N = deserialized.gxTpr_Areadsc_N;
         obj.gxTpr_Areastatusadsc_N = deserialized.gxTpr_Areastatusadsc_N;
         obj.gxTpr_Areausuario_N = deserialized.gxTpr_Areausuario_N;
         obj.gxTpr_Areafecreg_N = deserialized.gxTpr_Areafecreg_N;
         obj.gxTpr_Areafecultact_N = deserialized.gxTpr_Areafecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "areaareaid") )
               {
                  gxTv_Sdtarea_Areaareaid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areadsc") )
               {
                  gxTv_Sdtarea_Areadsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areastatusadsc") )
               {
                  gxTv_Sdtarea_Areastatusadsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areausuario") )
               {
                  gxTv_Sdtarea_Areausuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtarea_Areafecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtarea_Areafecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtarea_Areafecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtarea_Areafecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtarea_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtarea_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areaareaid_Z") )
               {
                  gxTv_Sdtarea_Areaareaid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areadsc_Z") )
               {
                  gxTv_Sdtarea_Areadsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areastatusadsc_Z") )
               {
                  gxTv_Sdtarea_Areastatusadsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areausuario_Z") )
               {
                  gxTv_Sdtarea_Areausuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtarea_Areafecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtarea_Areafecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtarea_Areafecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtarea_Areafecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areadsc_N") )
               {
                  gxTv_Sdtarea_Areadsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areastatusadsc_N") )
               {
                  gxTv_Sdtarea_Areastatusadsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areausuario_N") )
               {
                  gxTv_Sdtarea_Areausuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecreg_N") )
               {
                  gxTv_Sdtarea_Areafecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "areafecultact_N") )
               {
                  gxTv_Sdtarea_Areafecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "area";
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
         oWriter.WriteElement("areaareaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areaareaid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("areadsc", StringUtil.RTrim( gxTv_Sdtarea_Areadsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("areastatusadsc", StringUtil.RTrim( gxTv_Sdtarea_Areastatusadsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("areausuario", StringUtil.RTrim( gxTv_Sdtarea_Areausuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtarea_Areafecreg) )
         {
            oWriter.WriteStartElement("areafecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtarea_Areafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("areafecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtarea_Areafecultact) )
         {
            oWriter.WriteStartElement("areafecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtarea_Areafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("areafecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtarea_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areaareaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areaareaid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areadsc_Z", StringUtil.RTrim( gxTv_Sdtarea_Areadsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areastatusadsc_Z", StringUtil.RTrim( gxTv_Sdtarea_Areastatusadsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areausuario_Z", StringUtil.RTrim( gxTv_Sdtarea_Areausuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtarea_Areafecreg_Z) )
            {
               oWriter.WriteStartElement("areafecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtarea_Areafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("areafecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtarea_Areafecultact_Z) )
            {
               oWriter.WriteStartElement("areafecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtarea_Areafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("areafecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("areadsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areadsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areastatusadsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areastatusadsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areausuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areausuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areafecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areafecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("areafecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtarea_Areafecultact_N), 1, 0)));
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
         AddObjectProperty("areaareaid", gxTv_Sdtarea_Areaareaid, false);
         AddObjectProperty("areadsc", gxTv_Sdtarea_Areadsc, false);
         AddObjectProperty("areastatusadsc", gxTv_Sdtarea_Areastatusadsc, false);
         AddObjectProperty("areausuario", gxTv_Sdtarea_Areausuario, false);
         datetime_STZ = gxTv_Sdtarea_Areafecreg;
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
         AddObjectProperty("areafecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtarea_Areafecultact;
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
         AddObjectProperty("areafecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtarea_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtarea_Initialized, false);
            AddObjectProperty("areaareaid_Z", gxTv_Sdtarea_Areaareaid_Z, false);
            AddObjectProperty("areadsc_Z", gxTv_Sdtarea_Areadsc_Z, false);
            AddObjectProperty("areastatusadsc_Z", gxTv_Sdtarea_Areastatusadsc_Z, false);
            AddObjectProperty("areausuario_Z", gxTv_Sdtarea_Areausuario_Z, false);
            datetime_STZ = gxTv_Sdtarea_Areafecreg_Z;
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
            AddObjectProperty("areafecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtarea_Areafecultact_Z;
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
            AddObjectProperty("areafecultact_Z", sDateCnv, false);
            AddObjectProperty("areadsc_N", gxTv_Sdtarea_Areadsc_N, false);
            AddObjectProperty("areastatusadsc_N", gxTv_Sdtarea_Areastatusadsc_N, false);
            AddObjectProperty("areausuario_N", gxTv_Sdtarea_Areausuario_N, false);
            AddObjectProperty("areafecreg_N", gxTv_Sdtarea_Areafecreg_N, false);
            AddObjectProperty("areafecultact_N", gxTv_Sdtarea_Areafecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "areaareaid" )]
      [  XmlElement( ElementName = "areaareaid"   )]
      public int gxTpr_Areaareaid
      {
         get {
            return gxTv_Sdtarea_Areaareaid ;
         }

         set {
            if ( gxTv_Sdtarea_Areaareaid != value )
            {
               gxTv_Sdtarea_Mode = "INS";
               this.gxTv_Sdtarea_Areaareaid_Z_SetNull( );
               this.gxTv_Sdtarea_Areadsc_Z_SetNull( );
               this.gxTv_Sdtarea_Areastatusadsc_Z_SetNull( );
               this.gxTv_Sdtarea_Areausuario_Z_SetNull( );
               this.gxTv_Sdtarea_Areafecreg_Z_SetNull( );
               this.gxTv_Sdtarea_Areafecultact_Z_SetNull( );
            }
            gxTv_Sdtarea_Areaareaid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "areadsc" )]
      [  XmlElement( ElementName = "areadsc"   )]
      public String gxTpr_Areadsc
      {
         get {
            return gxTv_Sdtarea_Areadsc ;
         }

         set {
            gxTv_Sdtarea_Areadsc_N = 0;
            gxTv_Sdtarea_Areadsc = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areadsc_SetNull( )
      {
         gxTv_Sdtarea_Areadsc_N = 1;
         gxTv_Sdtarea_Areadsc = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areadsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areastatusadsc" )]
      [  XmlElement( ElementName = "areastatusadsc"   )]
      public String gxTpr_Areastatusadsc
      {
         get {
            return gxTv_Sdtarea_Areastatusadsc ;
         }

         set {
            gxTv_Sdtarea_Areastatusadsc_N = 0;
            gxTv_Sdtarea_Areastatusadsc = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areastatusadsc_SetNull( )
      {
         gxTv_Sdtarea_Areastatusadsc_N = 1;
         gxTv_Sdtarea_Areastatusadsc = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areastatusadsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areausuario" )]
      [  XmlElement( ElementName = "areausuario"   )]
      public String gxTpr_Areausuario
      {
         get {
            return gxTv_Sdtarea_Areausuario ;
         }

         set {
            gxTv_Sdtarea_Areausuario_N = 0;
            gxTv_Sdtarea_Areausuario = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areausuario_SetNull( )
      {
         gxTv_Sdtarea_Areausuario_N = 1;
         gxTv_Sdtarea_Areausuario = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areausuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecreg" )]
      [  XmlElement( ElementName = "areafecreg"  , IsNullable=true )]
      public string gxTpr_Areafecreg_Nullable
      {
         get {
            if ( gxTv_Sdtarea_Areafecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtarea_Areafecreg).value ;
         }

         set {
            gxTv_Sdtarea_Areafecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtarea_Areafecreg = DateTime.MinValue;
            else
               gxTv_Sdtarea_Areafecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Areafecreg
      {
         get {
            return gxTv_Sdtarea_Areafecreg ;
         }

         set {
            gxTv_Sdtarea_Areafecreg_N = 0;
            gxTv_Sdtarea_Areafecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecreg_SetNull( )
      {
         gxTv_Sdtarea_Areafecreg_N = 1;
         gxTv_Sdtarea_Areafecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecultact" )]
      [  XmlElement( ElementName = "areafecultact"  , IsNullable=true )]
      public string gxTpr_Areafecultact_Nullable
      {
         get {
            if ( gxTv_Sdtarea_Areafecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtarea_Areafecultact).value ;
         }

         set {
            gxTv_Sdtarea_Areafecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtarea_Areafecultact = DateTime.MinValue;
            else
               gxTv_Sdtarea_Areafecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Areafecultact
      {
         get {
            return gxTv_Sdtarea_Areafecultact ;
         }

         set {
            gxTv_Sdtarea_Areafecultact_N = 0;
            gxTv_Sdtarea_Areafecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecultact_SetNull( )
      {
         gxTv_Sdtarea_Areafecultact_N = 1;
         gxTv_Sdtarea_Areafecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtarea_Mode ;
         }

         set {
            gxTv_Sdtarea_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Mode_SetNull( )
      {
         gxTv_Sdtarea_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtarea_Initialized ;
         }

         set {
            gxTv_Sdtarea_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Initialized_SetNull( )
      {
         gxTv_Sdtarea_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areaareaid_Z" )]
      [  XmlElement( ElementName = "areaareaid_Z"   )]
      public int gxTpr_Areaareaid_Z
      {
         get {
            return gxTv_Sdtarea_Areaareaid_Z ;
         }

         set {
            gxTv_Sdtarea_Areaareaid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtarea_Areaareaid_Z_SetNull( )
      {
         gxTv_Sdtarea_Areaareaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areaareaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areadsc_Z" )]
      [  XmlElement( ElementName = "areadsc_Z"   )]
      public String gxTpr_Areadsc_Z
      {
         get {
            return gxTv_Sdtarea_Areadsc_Z ;
         }

         set {
            gxTv_Sdtarea_Areadsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areadsc_Z_SetNull( )
      {
         gxTv_Sdtarea_Areadsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areadsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areastatusadsc_Z" )]
      [  XmlElement( ElementName = "areastatusadsc_Z"   )]
      public String gxTpr_Areastatusadsc_Z
      {
         get {
            return gxTv_Sdtarea_Areastatusadsc_Z ;
         }

         set {
            gxTv_Sdtarea_Areastatusadsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areastatusadsc_Z_SetNull( )
      {
         gxTv_Sdtarea_Areastatusadsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areastatusadsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areausuario_Z" )]
      [  XmlElement( ElementName = "areausuario_Z"   )]
      public String gxTpr_Areausuario_Z
      {
         get {
            return gxTv_Sdtarea_Areausuario_Z ;
         }

         set {
            gxTv_Sdtarea_Areausuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtarea_Areausuario_Z_SetNull( )
      {
         gxTv_Sdtarea_Areausuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtarea_Areausuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecreg_Z" )]
      [  XmlElement( ElementName = "areafecreg_Z"  , IsNullable=true )]
      public string gxTpr_Areafecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtarea_Areafecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtarea_Areafecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtarea_Areafecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtarea_Areafecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Areafecreg_Z
      {
         get {
            return gxTv_Sdtarea_Areafecreg_Z ;
         }

         set {
            gxTv_Sdtarea_Areafecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecreg_Z_SetNull( )
      {
         gxTv_Sdtarea_Areafecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecultact_Z" )]
      [  XmlElement( ElementName = "areafecultact_Z"  , IsNullable=true )]
      public string gxTpr_Areafecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtarea_Areafecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtarea_Areafecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtarea_Areafecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtarea_Areafecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Areafecultact_Z
      {
         get {
            return gxTv_Sdtarea_Areafecultact_Z ;
         }

         set {
            gxTv_Sdtarea_Areafecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecultact_Z_SetNull( )
      {
         gxTv_Sdtarea_Areafecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areadsc_N" )]
      [  XmlElement( ElementName = "areadsc_N"   )]
      public short gxTpr_Areadsc_N
      {
         get {
            return gxTv_Sdtarea_Areadsc_N ;
         }

         set {
            gxTv_Sdtarea_Areadsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Areadsc_N_SetNull( )
      {
         gxTv_Sdtarea_Areadsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areadsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areastatusadsc_N" )]
      [  XmlElement( ElementName = "areastatusadsc_N"   )]
      public short gxTpr_Areastatusadsc_N
      {
         get {
            return gxTv_Sdtarea_Areastatusadsc_N ;
         }

         set {
            gxTv_Sdtarea_Areastatusadsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Areastatusadsc_N_SetNull( )
      {
         gxTv_Sdtarea_Areastatusadsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areastatusadsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areausuario_N" )]
      [  XmlElement( ElementName = "areausuario_N"   )]
      public short gxTpr_Areausuario_N
      {
         get {
            return gxTv_Sdtarea_Areausuario_N ;
         }

         set {
            gxTv_Sdtarea_Areausuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Areausuario_N_SetNull( )
      {
         gxTv_Sdtarea_Areausuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areausuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecreg_N" )]
      [  XmlElement( ElementName = "areafecreg_N"   )]
      public short gxTpr_Areafecreg_N
      {
         get {
            return gxTv_Sdtarea_Areafecreg_N ;
         }

         set {
            gxTv_Sdtarea_Areafecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecreg_N_SetNull( )
      {
         gxTv_Sdtarea_Areafecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "areafecultact_N" )]
      [  XmlElement( ElementName = "areafecultact_N"   )]
      public short gxTpr_Areafecultact_N
      {
         get {
            return gxTv_Sdtarea_Areafecultact_N ;
         }

         set {
            gxTv_Sdtarea_Areafecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtarea_Areafecultact_N_SetNull( )
      {
         gxTv_Sdtarea_Areafecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtarea_Areafecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtarea_Areadsc = "";
         gxTv_Sdtarea_Areastatusadsc = "";
         gxTv_Sdtarea_Areausuario = "";
         gxTv_Sdtarea_Areafecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Areafecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Mode = "";
         gxTv_Sdtarea_Areadsc_Z = "";
         gxTv_Sdtarea_Areastatusadsc_Z = "";
         gxTv_Sdtarea_Areausuario_Z = "";
         gxTv_Sdtarea_Areafecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtarea_Areafecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "area", "GeneXus.Programs.area_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtarea_Initialized ;
      private short gxTv_Sdtarea_Areadsc_N ;
      private short gxTv_Sdtarea_Areastatusadsc_N ;
      private short gxTv_Sdtarea_Areausuario_N ;
      private short gxTv_Sdtarea_Areafecreg_N ;
      private short gxTv_Sdtarea_Areafecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtarea_Areaareaid ;
      private int gxTv_Sdtarea_Areaareaid_Z ;
      private String gxTv_Sdtarea_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtarea_Areafecreg ;
      private DateTime gxTv_Sdtarea_Areafecultact ;
      private DateTime gxTv_Sdtarea_Areafecreg_Z ;
      private DateTime gxTv_Sdtarea_Areafecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtarea_Areadsc ;
      private String gxTv_Sdtarea_Areastatusadsc ;
      private String gxTv_Sdtarea_Areausuario ;
      private String gxTv_Sdtarea_Areadsc_Z ;
      private String gxTv_Sdtarea_Areastatusadsc_Z ;
      private String gxTv_Sdtarea_Areausuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"area", Namespace = "Condufef_v1")]
   public class Sdtarea_RESTInterface : GxGenericCollectionItem<Sdtarea>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtarea_RESTInterface( ) : base()
      {
      }

      public Sdtarea_RESTInterface( Sdtarea psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "areaareaid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Areaareaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Areaareaid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Areaareaid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "areadsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Areadsc
      {
         get {
            return sdt.gxTpr_Areadsc ;
         }

         set {
            sdt.gxTpr_Areadsc = (String)(value);
         }

      }

      [DataMember( Name = "areastatusadsc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Areastatusadsc
      {
         get {
            return sdt.gxTpr_Areastatusadsc ;
         }

         set {
            sdt.gxTpr_Areastatusadsc = (String)(value);
         }

      }

      [DataMember( Name = "areausuario" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Areausuario
      {
         get {
            return sdt.gxTpr_Areausuario ;
         }

         set {
            sdt.gxTpr_Areausuario = (String)(value);
         }

      }

      [DataMember( Name = "areafecreg" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Areafecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Areafecreg) ;
         }

         set {
            sdt.gxTpr_Areafecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "areafecultact" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Areafecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Areafecultact) ;
         }

         set {
            sdt.gxTpr_Areafecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtarea sdt
      {
         get {
            return (Sdtarea)Sdt ;
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
            sdt = new Sdtarea() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 19 )]
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
