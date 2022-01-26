/*
               File: type_Sdtcambs
        Description: cambs
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/25/2022 17:34:43.65
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
   [XmlRoot(ElementName = "cambs" )]
   [XmlType(TypeName =  "cambs" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtcambs : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtcambs( )
      {
         /* Constructor for serialization */
         gxTv_Sdtcambs_Cambsdsc = "";
         gxTv_Sdtcambs_Cambsusuario = "";
         gxTv_Sdtcambs_Cambsfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Cambsfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Mode = "";
         gxTv_Sdtcambs_Cambsdsc_Z = "";
         gxTv_Sdtcambs_Cambsusuario_Z = "";
         gxTv_Sdtcambs_Cambsfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Cambsfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtcambs( IGxContext context )
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

      public void Load( int AV25cambsid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV25cambsid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"cambsid", typeof(int)}}) ;
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
         metadata.Set("Name", "cambs");
         metadata.Set("BT", "CAMBS");
         metadata.Set("PK", "[ \"cambsid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Cambsid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsdsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsdsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Cambsfecultact_N" , attrs);
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
         Sdtcambs deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtcambs)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtcambs obj ;
         obj = this;
         obj.gxTpr_Cambsid = deserialized.gxTpr_Cambsid;
         obj.gxTpr_Cambsdsc = deserialized.gxTpr_Cambsdsc;
         obj.gxTpr_Cambsusuario = deserialized.gxTpr_Cambsusuario;
         obj.gxTpr_Cambsfecreg = deserialized.gxTpr_Cambsfecreg;
         obj.gxTpr_Cambsfecultact = deserialized.gxTpr_Cambsfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Cambsid_Z = deserialized.gxTpr_Cambsid_Z;
         obj.gxTpr_Cambsdsc_Z = deserialized.gxTpr_Cambsdsc_Z;
         obj.gxTpr_Cambsusuario_Z = deserialized.gxTpr_Cambsusuario_Z;
         obj.gxTpr_Cambsfecreg_Z = deserialized.gxTpr_Cambsfecreg_Z;
         obj.gxTpr_Cambsfecultact_Z = deserialized.gxTpr_Cambsfecultact_Z;
         obj.gxTpr_Cambsdsc_N = deserialized.gxTpr_Cambsdsc_N;
         obj.gxTpr_Cambsusuario_N = deserialized.gxTpr_Cambsusuario_N;
         obj.gxTpr_Cambsfecreg_N = deserialized.gxTpr_Cambsfecreg_N;
         obj.gxTpr_Cambsfecultact_N = deserialized.gxTpr_Cambsfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsid") )
               {
                  gxTv_Sdtcambs_Cambsid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsdsc") )
               {
                  gxTv_Sdtcambs_Cambsdsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsusuario") )
               {
                  gxTv_Sdtcambs_Cambsusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcambs_Cambsfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcambs_Cambsfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcambs_Cambsfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcambs_Cambsfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtcambs_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtcambs_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsid_Z") )
               {
                  gxTv_Sdtcambs_Cambsid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsdsc_Z") )
               {
                  gxTv_Sdtcambs_Cambsdsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsusuario_Z") )
               {
                  gxTv_Sdtcambs_Cambsusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcambs_Cambsfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcambs_Cambsfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcambs_Cambsfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcambs_Cambsfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsdsc_N") )
               {
                  gxTv_Sdtcambs_Cambsdsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsusuario_N") )
               {
                  gxTv_Sdtcambs_Cambsusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecreg_N") )
               {
                  gxTv_Sdtcambs_Cambsfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "cambsfecultact_N") )
               {
                  gxTv_Sdtcambs_Cambsfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "cambs";
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
         oWriter.WriteElement("cambsid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("cambsdsc", StringUtil.RTrim( gxTv_Sdtcambs_Cambsdsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("cambsusuario", StringUtil.RTrim( gxTv_Sdtcambs_Cambsusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtcambs_Cambsfecreg) )
         {
            oWriter.WriteStartElement("cambsfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcambs_Cambsfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("cambsfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtcambs_Cambsfecultact) )
         {
            oWriter.WriteStartElement("cambsfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcambs_Cambsfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("cambsfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtcambs_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsdsc_Z", StringUtil.RTrim( gxTv_Sdtcambs_Cambsdsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsusuario_Z", StringUtil.RTrim( gxTv_Sdtcambs_Cambsusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtcambs_Cambsfecreg_Z) )
            {
               oWriter.WriteStartElement("cambsfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcambs_Cambsfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("cambsfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtcambs_Cambsfecultact_Z) )
            {
               oWriter.WriteStartElement("cambsfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcambs_Cambsfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("cambsfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("cambsdsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsdsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("cambsfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcambs_Cambsfecultact_N), 1, 0)));
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
         AddObjectProperty("cambsid", gxTv_Sdtcambs_Cambsid, false);
         AddObjectProperty("cambsdsc", gxTv_Sdtcambs_Cambsdsc, false);
         AddObjectProperty("cambsusuario", gxTv_Sdtcambs_Cambsusuario, false);
         datetime_STZ = gxTv_Sdtcambs_Cambsfecreg;
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
         AddObjectProperty("cambsfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtcambs_Cambsfecultact;
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
         AddObjectProperty("cambsfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtcambs_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtcambs_Initialized, false);
            AddObjectProperty("cambsid_Z", gxTv_Sdtcambs_Cambsid_Z, false);
            AddObjectProperty("cambsdsc_Z", gxTv_Sdtcambs_Cambsdsc_Z, false);
            AddObjectProperty("cambsusuario_Z", gxTv_Sdtcambs_Cambsusuario_Z, false);
            datetime_STZ = gxTv_Sdtcambs_Cambsfecreg_Z;
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
            AddObjectProperty("cambsfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtcambs_Cambsfecultact_Z;
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
            AddObjectProperty("cambsfecultact_Z", sDateCnv, false);
            AddObjectProperty("cambsdsc_N", gxTv_Sdtcambs_Cambsdsc_N, false);
            AddObjectProperty("cambsusuario_N", gxTv_Sdtcambs_Cambsusuario_N, false);
            AddObjectProperty("cambsfecreg_N", gxTv_Sdtcambs_Cambsfecreg_N, false);
            AddObjectProperty("cambsfecultact_N", gxTv_Sdtcambs_Cambsfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "cambsid" )]
      [  XmlElement( ElementName = "cambsid"   )]
      public int gxTpr_Cambsid
      {
         get {
            return gxTv_Sdtcambs_Cambsid ;
         }

         set {
            if ( gxTv_Sdtcambs_Cambsid != value )
            {
               gxTv_Sdtcambs_Mode = "INS";
               this.gxTv_Sdtcambs_Cambsid_Z_SetNull( );
               this.gxTv_Sdtcambs_Cambsdsc_Z_SetNull( );
               this.gxTv_Sdtcambs_Cambsusuario_Z_SetNull( );
               this.gxTv_Sdtcambs_Cambsfecreg_Z_SetNull( );
               this.gxTv_Sdtcambs_Cambsfecultact_Z_SetNull( );
            }
            gxTv_Sdtcambs_Cambsid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "cambsdsc" )]
      [  XmlElement( ElementName = "cambsdsc"   )]
      public String gxTpr_Cambsdsc
      {
         get {
            return gxTv_Sdtcambs_Cambsdsc ;
         }

         set {
            gxTv_Sdtcambs_Cambsdsc_N = 0;
            gxTv_Sdtcambs_Cambsdsc = (String)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsdsc_SetNull( )
      {
         gxTv_Sdtcambs_Cambsdsc_N = 1;
         gxTv_Sdtcambs_Cambsdsc = "";
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsusuario" )]
      [  XmlElement( ElementName = "cambsusuario"   )]
      public String gxTpr_Cambsusuario
      {
         get {
            return gxTv_Sdtcambs_Cambsusuario ;
         }

         set {
            gxTv_Sdtcambs_Cambsusuario_N = 0;
            gxTv_Sdtcambs_Cambsusuario = (String)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsusuario_SetNull( )
      {
         gxTv_Sdtcambs_Cambsusuario_N = 1;
         gxTv_Sdtcambs_Cambsusuario = "";
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecreg" )]
      [  XmlElement( ElementName = "cambsfecreg"  , IsNullable=true )]
      public string gxTpr_Cambsfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtcambs_Cambsfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcambs_Cambsfecreg).value ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcambs_Cambsfecreg = DateTime.MinValue;
            else
               gxTv_Sdtcambs_Cambsfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Cambsfecreg
      {
         get {
            return gxTv_Sdtcambs_Cambsfecreg ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecreg_N = 0;
            gxTv_Sdtcambs_Cambsfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecreg_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecreg_N = 1;
         gxTv_Sdtcambs_Cambsfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecultact" )]
      [  XmlElement( ElementName = "cambsfecultact"  , IsNullable=true )]
      public string gxTpr_Cambsfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtcambs_Cambsfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcambs_Cambsfecultact).value ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcambs_Cambsfecultact = DateTime.MinValue;
            else
               gxTv_Sdtcambs_Cambsfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Cambsfecultact
      {
         get {
            return gxTv_Sdtcambs_Cambsfecultact ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecultact_N = 0;
            gxTv_Sdtcambs_Cambsfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecultact_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecultact_N = 1;
         gxTv_Sdtcambs_Cambsfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtcambs_Mode ;
         }

         set {
            gxTv_Sdtcambs_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtcambs_Mode_SetNull( )
      {
         gxTv_Sdtcambs_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtcambs_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtcambs_Initialized ;
         }

         set {
            gxTv_Sdtcambs_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtcambs_Initialized_SetNull( )
      {
         gxTv_Sdtcambs_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsid_Z" )]
      [  XmlElement( ElementName = "cambsid_Z"   )]
      public int gxTpr_Cambsid_Z
      {
         get {
            return gxTv_Sdtcambs_Cambsid_Z ;
         }

         set {
            gxTv_Sdtcambs_Cambsid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsid_Z_SetNull( )
      {
         gxTv_Sdtcambs_Cambsid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsdsc_Z" )]
      [  XmlElement( ElementName = "cambsdsc_Z"   )]
      public String gxTpr_Cambsdsc_Z
      {
         get {
            return gxTv_Sdtcambs_Cambsdsc_Z ;
         }

         set {
            gxTv_Sdtcambs_Cambsdsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsdsc_Z_SetNull( )
      {
         gxTv_Sdtcambs_Cambsdsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsusuario_Z" )]
      [  XmlElement( ElementName = "cambsusuario_Z"   )]
      public String gxTpr_Cambsusuario_Z
      {
         get {
            return gxTv_Sdtcambs_Cambsusuario_Z ;
         }

         set {
            gxTv_Sdtcambs_Cambsusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsusuario_Z_SetNull( )
      {
         gxTv_Sdtcambs_Cambsusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecreg_Z" )]
      [  XmlElement( ElementName = "cambsfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Cambsfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtcambs_Cambsfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcambs_Cambsfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcambs_Cambsfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtcambs_Cambsfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Cambsfecreg_Z
      {
         get {
            return gxTv_Sdtcambs_Cambsfecreg_Z ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecreg_Z_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecultact_Z" )]
      [  XmlElement( ElementName = "cambsfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Cambsfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtcambs_Cambsfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcambs_Cambsfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcambs_Cambsfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtcambs_Cambsfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Cambsfecultact_Z
      {
         get {
            return gxTv_Sdtcambs_Cambsfecultact_Z ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecultact_Z_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsdsc_N" )]
      [  XmlElement( ElementName = "cambsdsc_N"   )]
      public short gxTpr_Cambsdsc_N
      {
         get {
            return gxTv_Sdtcambs_Cambsdsc_N ;
         }

         set {
            gxTv_Sdtcambs_Cambsdsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsdsc_N_SetNull( )
      {
         gxTv_Sdtcambs_Cambsdsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsusuario_N" )]
      [  XmlElement( ElementName = "cambsusuario_N"   )]
      public short gxTpr_Cambsusuario_N
      {
         get {
            return gxTv_Sdtcambs_Cambsusuario_N ;
         }

         set {
            gxTv_Sdtcambs_Cambsusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsusuario_N_SetNull( )
      {
         gxTv_Sdtcambs_Cambsusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecreg_N" )]
      [  XmlElement( ElementName = "cambsfecreg_N"   )]
      public short gxTpr_Cambsfecreg_N
      {
         get {
            return gxTv_Sdtcambs_Cambsfecreg_N ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecreg_N_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "cambsfecultact_N" )]
      [  XmlElement( ElementName = "cambsfecultact_N"   )]
      public short gxTpr_Cambsfecultact_N
      {
         get {
            return gxTv_Sdtcambs_Cambsfecultact_N ;
         }

         set {
            gxTv_Sdtcambs_Cambsfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtcambs_Cambsfecultact_N_SetNull( )
      {
         gxTv_Sdtcambs_Cambsfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcambs_Cambsfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtcambs_Cambsdsc = "";
         gxTv_Sdtcambs_Cambsusuario = "";
         gxTv_Sdtcambs_Cambsfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Cambsfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Mode = "";
         gxTv_Sdtcambs_Cambsdsc_Z = "";
         gxTv_Sdtcambs_Cambsusuario_Z = "";
         gxTv_Sdtcambs_Cambsfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcambs_Cambsfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "cambs", "GeneXus.Programs.cambs_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtcambs_Initialized ;
      private short gxTv_Sdtcambs_Cambsdsc_N ;
      private short gxTv_Sdtcambs_Cambsusuario_N ;
      private short gxTv_Sdtcambs_Cambsfecreg_N ;
      private short gxTv_Sdtcambs_Cambsfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtcambs_Cambsid ;
      private int gxTv_Sdtcambs_Cambsid_Z ;
      private String gxTv_Sdtcambs_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtcambs_Cambsfecreg ;
      private DateTime gxTv_Sdtcambs_Cambsfecultact ;
      private DateTime gxTv_Sdtcambs_Cambsfecreg_Z ;
      private DateTime gxTv_Sdtcambs_Cambsfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtcambs_Cambsdsc ;
      private String gxTv_Sdtcambs_Cambsusuario ;
      private String gxTv_Sdtcambs_Cambsdsc_Z ;
      private String gxTv_Sdtcambs_Cambsusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"cambs", Namespace = "Condufef_v1")]
   public class Sdtcambs_RESTInterface : GxGenericCollectionItem<Sdtcambs>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtcambs_RESTInterface( ) : base()
      {
      }

      public Sdtcambs_RESTInterface( Sdtcambs psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "cambsid" , Order = 0 )]
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

      [DataMember( Name = "cambsdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Cambsdsc
      {
         get {
            return sdt.gxTpr_Cambsdsc ;
         }

         set {
            sdt.gxTpr_Cambsdsc = (String)(value);
         }

      }

      [DataMember( Name = "cambsusuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Cambsusuario
      {
         get {
            return sdt.gxTpr_Cambsusuario ;
         }

         set {
            sdt.gxTpr_Cambsusuario = (String)(value);
         }

      }

      [DataMember( Name = "cambsfecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Cambsfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Cambsfecreg) ;
         }

         set {
            sdt.gxTpr_Cambsfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "cambsfecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Cambsfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Cambsfecultact) ;
         }

         set {
            sdt.gxTpr_Cambsfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtcambs sdt
      {
         get {
            return (Sdtcambs)Sdt ;
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
            sdt = new Sdtcambs() ;
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
