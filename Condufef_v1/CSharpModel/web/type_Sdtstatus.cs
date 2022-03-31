/*
               File: type_Sdtstatus
        Description: status
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:28.2
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
   [XmlRoot(ElementName = "status" )]
   [XmlType(TypeName =  "status" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtstatus : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtstatus( )
      {
         /* Constructor for serialization */
         gxTv_Sdtstatus_Statusdsc = "";
         gxTv_Sdtstatus_Statususotabla = "";
         gxTv_Sdtstatus_Statusdesc = "";
         gxTv_Sdtstatus_Statususuario = "";
         gxTv_Sdtstatus_Statusfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Statusfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Mode = "";
         gxTv_Sdtstatus_Statusdsc_Z = "";
         gxTv_Sdtstatus_Statususotabla_Z = "";
         gxTv_Sdtstatus_Statusdesc_Z = "";
         gxTv_Sdtstatus_Statususuario_Z = "";
         gxTv_Sdtstatus_Statusfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Statusfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtstatus( IGxContext context )
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

      public void Load( int AV1statusid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV1statusid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"statusid", typeof(int)}}) ;
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
         metadata.Set("Name", "status");
         metadata.Set("BT", "STATUS");
         metadata.Set("PK", "[ \"statusid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Statusid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusdsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statususotabla_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusdesc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statususuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusdsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statususotabla_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusdesc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statususuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Statusfecultact_N" , attrs);
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
         Sdtstatus deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtstatus)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtstatus obj ;
         obj = this;
         obj.gxTpr_Statusid = deserialized.gxTpr_Statusid;
         obj.gxTpr_Statusdsc = deserialized.gxTpr_Statusdsc;
         obj.gxTpr_Statususotabla = deserialized.gxTpr_Statususotabla;
         obj.gxTpr_Statusdesc = deserialized.gxTpr_Statusdesc;
         obj.gxTpr_Statususuario = deserialized.gxTpr_Statususuario;
         obj.gxTpr_Statusfecreg = deserialized.gxTpr_Statusfecreg;
         obj.gxTpr_Statusfecultact = deserialized.gxTpr_Statusfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Statusid_Z = deserialized.gxTpr_Statusid_Z;
         obj.gxTpr_Statusdsc_Z = deserialized.gxTpr_Statusdsc_Z;
         obj.gxTpr_Statususotabla_Z = deserialized.gxTpr_Statususotabla_Z;
         obj.gxTpr_Statusdesc_Z = deserialized.gxTpr_Statusdesc_Z;
         obj.gxTpr_Statususuario_Z = deserialized.gxTpr_Statususuario_Z;
         obj.gxTpr_Statusfecreg_Z = deserialized.gxTpr_Statusfecreg_Z;
         obj.gxTpr_Statusfecultact_Z = deserialized.gxTpr_Statusfecultact_Z;
         obj.gxTpr_Statusdsc_N = deserialized.gxTpr_Statusdsc_N;
         obj.gxTpr_Statususotabla_N = deserialized.gxTpr_Statususotabla_N;
         obj.gxTpr_Statusdesc_N = deserialized.gxTpr_Statusdesc_N;
         obj.gxTpr_Statususuario_N = deserialized.gxTpr_Statususuario_N;
         obj.gxTpr_Statusfecreg_N = deserialized.gxTpr_Statusfecreg_N;
         obj.gxTpr_Statusfecultact_N = deserialized.gxTpr_Statusfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusid") )
               {
                  gxTv_Sdtstatus_Statusid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdsc") )
               {
                  gxTv_Sdtstatus_Statusdsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususotabla") )
               {
                  gxTv_Sdtstatus_Statususotabla = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdesc") )
               {
                  gxTv_Sdtstatus_Statusdesc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususuario") )
               {
                  gxTv_Sdtstatus_Statususuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtstatus_Statusfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtstatus_Statusfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtstatus_Statusfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtstatus_Statusfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtstatus_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtstatus_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusid_Z") )
               {
                  gxTv_Sdtstatus_Statusid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdsc_Z") )
               {
                  gxTv_Sdtstatus_Statusdsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususotabla_Z") )
               {
                  gxTv_Sdtstatus_Statususotabla_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdesc_Z") )
               {
                  gxTv_Sdtstatus_Statusdesc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususuario_Z") )
               {
                  gxTv_Sdtstatus_Statususuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtstatus_Statusfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtstatus_Statusfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtstatus_Statusfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtstatus_Statusfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdsc_N") )
               {
                  gxTv_Sdtstatus_Statusdsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususotabla_N") )
               {
                  gxTv_Sdtstatus_Statususotabla_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusdesc_N") )
               {
                  gxTv_Sdtstatus_Statusdesc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statususuario_N") )
               {
                  gxTv_Sdtstatus_Statususuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecreg_N") )
               {
                  gxTv_Sdtstatus_Statusfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "statusfecultact_N") )
               {
                  gxTv_Sdtstatus_Statusfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "status";
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
         oWriter.WriteElement("statusid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("statusdsc", StringUtil.RTrim( gxTv_Sdtstatus_Statusdsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("statususotabla", StringUtil.RTrim( gxTv_Sdtstatus_Statususotabla));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("statusdesc", StringUtil.RTrim( gxTv_Sdtstatus_Statusdesc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("statususuario", StringUtil.RTrim( gxTv_Sdtstatus_Statususuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtstatus_Statusfecreg) )
         {
            oWriter.WriteStartElement("statusfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtstatus_Statusfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("statusfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtstatus_Statusfecultact) )
         {
            oWriter.WriteStartElement("statusfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtstatus_Statusfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("statusfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtstatus_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusdsc_Z", StringUtil.RTrim( gxTv_Sdtstatus_Statusdsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statususotabla_Z", StringUtil.RTrim( gxTv_Sdtstatus_Statususotabla_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusdesc_Z", StringUtil.RTrim( gxTv_Sdtstatus_Statusdesc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statususuario_Z", StringUtil.RTrim( gxTv_Sdtstatus_Statususuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtstatus_Statusfecreg_Z) )
            {
               oWriter.WriteStartElement("statusfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtstatus_Statusfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("statusfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtstatus_Statusfecultact_Z) )
            {
               oWriter.WriteStartElement("statusfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtstatus_Statusfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("statusfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("statusdsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusdsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statususotabla_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statususotabla_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusdesc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusdesc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statususuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statususuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("statusfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtstatus_Statusfecultact_N), 1, 0)));
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
         AddObjectProperty("statusid", gxTv_Sdtstatus_Statusid, false);
         AddObjectProperty("statusdsc", gxTv_Sdtstatus_Statusdsc, false);
         AddObjectProperty("statususotabla", gxTv_Sdtstatus_Statususotabla, false);
         AddObjectProperty("statusdesc", gxTv_Sdtstatus_Statusdesc, false);
         AddObjectProperty("statususuario", gxTv_Sdtstatus_Statususuario, false);
         datetime_STZ = gxTv_Sdtstatus_Statusfecreg;
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
         AddObjectProperty("statusfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtstatus_Statusfecultact;
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
         AddObjectProperty("statusfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtstatus_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtstatus_Initialized, false);
            AddObjectProperty("statusid_Z", gxTv_Sdtstatus_Statusid_Z, false);
            AddObjectProperty("statusdsc_Z", gxTv_Sdtstatus_Statusdsc_Z, false);
            AddObjectProperty("statususotabla_Z", gxTv_Sdtstatus_Statususotabla_Z, false);
            AddObjectProperty("statusdesc_Z", gxTv_Sdtstatus_Statusdesc_Z, false);
            AddObjectProperty("statususuario_Z", gxTv_Sdtstatus_Statususuario_Z, false);
            datetime_STZ = gxTv_Sdtstatus_Statusfecreg_Z;
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
            AddObjectProperty("statusfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtstatus_Statusfecultact_Z;
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
            AddObjectProperty("statusfecultact_Z", sDateCnv, false);
            AddObjectProperty("statusdsc_N", gxTv_Sdtstatus_Statusdsc_N, false);
            AddObjectProperty("statususotabla_N", gxTv_Sdtstatus_Statususotabla_N, false);
            AddObjectProperty("statusdesc_N", gxTv_Sdtstatus_Statusdesc_N, false);
            AddObjectProperty("statususuario_N", gxTv_Sdtstatus_Statususuario_N, false);
            AddObjectProperty("statusfecreg_N", gxTv_Sdtstatus_Statusfecreg_N, false);
            AddObjectProperty("statusfecultact_N", gxTv_Sdtstatus_Statusfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "statusid" )]
      [  XmlElement( ElementName = "statusid"   )]
      public int gxTpr_Statusid
      {
         get {
            return gxTv_Sdtstatus_Statusid ;
         }

         set {
            if ( gxTv_Sdtstatus_Statusid != value )
            {
               gxTv_Sdtstatus_Mode = "INS";
               this.gxTv_Sdtstatus_Statusid_Z_SetNull( );
               this.gxTv_Sdtstatus_Statusdsc_Z_SetNull( );
               this.gxTv_Sdtstatus_Statususotabla_Z_SetNull( );
               this.gxTv_Sdtstatus_Statusdesc_Z_SetNull( );
               this.gxTv_Sdtstatus_Statususuario_Z_SetNull( );
               this.gxTv_Sdtstatus_Statusfecreg_Z_SetNull( );
               this.gxTv_Sdtstatus_Statusfecultact_Z_SetNull( );
            }
            gxTv_Sdtstatus_Statusid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "statusdsc" )]
      [  XmlElement( ElementName = "statusdsc"   )]
      public String gxTpr_Statusdsc
      {
         get {
            return gxTv_Sdtstatus_Statusdsc ;
         }

         set {
            gxTv_Sdtstatus_Statusdsc_N = 0;
            gxTv_Sdtstatus_Statusdsc = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdsc_SetNull( )
      {
         gxTv_Sdtstatus_Statusdsc_N = 1;
         gxTv_Sdtstatus_Statusdsc = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususotabla" )]
      [  XmlElement( ElementName = "statususotabla"   )]
      public String gxTpr_Statususotabla
      {
         get {
            return gxTv_Sdtstatus_Statususotabla ;
         }

         set {
            gxTv_Sdtstatus_Statususotabla_N = 0;
            gxTv_Sdtstatus_Statususotabla = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususotabla_SetNull( )
      {
         gxTv_Sdtstatus_Statususotabla_N = 1;
         gxTv_Sdtstatus_Statususotabla = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususotabla_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusdesc" )]
      [  XmlElement( ElementName = "statusdesc"   )]
      public String gxTpr_Statusdesc
      {
         get {
            return gxTv_Sdtstatus_Statusdesc ;
         }

         set {
            gxTv_Sdtstatus_Statusdesc_N = 0;
            gxTv_Sdtstatus_Statusdesc = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdesc_SetNull( )
      {
         gxTv_Sdtstatus_Statusdesc_N = 1;
         gxTv_Sdtstatus_Statusdesc = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdesc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususuario" )]
      [  XmlElement( ElementName = "statususuario"   )]
      public String gxTpr_Statususuario
      {
         get {
            return gxTv_Sdtstatus_Statususuario ;
         }

         set {
            gxTv_Sdtstatus_Statususuario_N = 0;
            gxTv_Sdtstatus_Statususuario = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususuario_SetNull( )
      {
         gxTv_Sdtstatus_Statususuario_N = 1;
         gxTv_Sdtstatus_Statususuario = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecreg" )]
      [  XmlElement( ElementName = "statusfecreg"  , IsNullable=true )]
      public string gxTpr_Statusfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtstatus_Statusfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtstatus_Statusfecreg).value ;
         }

         set {
            gxTv_Sdtstatus_Statusfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtstatus_Statusfecreg = DateTime.MinValue;
            else
               gxTv_Sdtstatus_Statusfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Statusfecreg
      {
         get {
            return gxTv_Sdtstatus_Statusfecreg ;
         }

         set {
            gxTv_Sdtstatus_Statusfecreg_N = 0;
            gxTv_Sdtstatus_Statusfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecreg_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecreg_N = 1;
         gxTv_Sdtstatus_Statusfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecultact" )]
      [  XmlElement( ElementName = "statusfecultact"  , IsNullable=true )]
      public string gxTpr_Statusfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtstatus_Statusfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtstatus_Statusfecultact).value ;
         }

         set {
            gxTv_Sdtstatus_Statusfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtstatus_Statusfecultact = DateTime.MinValue;
            else
               gxTv_Sdtstatus_Statusfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Statusfecultact
      {
         get {
            return gxTv_Sdtstatus_Statusfecultact ;
         }

         set {
            gxTv_Sdtstatus_Statusfecultact_N = 0;
            gxTv_Sdtstatus_Statusfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecultact_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecultact_N = 1;
         gxTv_Sdtstatus_Statusfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtstatus_Mode ;
         }

         set {
            gxTv_Sdtstatus_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Mode_SetNull( )
      {
         gxTv_Sdtstatus_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtstatus_Initialized ;
         }

         set {
            gxTv_Sdtstatus_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Initialized_SetNull( )
      {
         gxTv_Sdtstatus_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusid_Z" )]
      [  XmlElement( ElementName = "statusid_Z"   )]
      public int gxTpr_Statusid_Z
      {
         get {
            return gxTv_Sdtstatus_Statusid_Z ;
         }

         set {
            gxTv_Sdtstatus_Statusid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusid_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statusid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusdsc_Z" )]
      [  XmlElement( ElementName = "statusdsc_Z"   )]
      public String gxTpr_Statusdsc_Z
      {
         get {
            return gxTv_Sdtstatus_Statusdsc_Z ;
         }

         set {
            gxTv_Sdtstatus_Statusdsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdsc_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statusdsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususotabla_Z" )]
      [  XmlElement( ElementName = "statususotabla_Z"   )]
      public String gxTpr_Statususotabla_Z
      {
         get {
            return gxTv_Sdtstatus_Statususotabla_Z ;
         }

         set {
            gxTv_Sdtstatus_Statususotabla_Z = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususotabla_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statususotabla_Z = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususotabla_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusdesc_Z" )]
      [  XmlElement( ElementName = "statusdesc_Z"   )]
      public String gxTpr_Statusdesc_Z
      {
         get {
            return gxTv_Sdtstatus_Statusdesc_Z ;
         }

         set {
            gxTv_Sdtstatus_Statusdesc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdesc_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statusdesc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdesc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususuario_Z" )]
      [  XmlElement( ElementName = "statususuario_Z"   )]
      public String gxTpr_Statususuario_Z
      {
         get {
            return gxTv_Sdtstatus_Statususuario_Z ;
         }

         set {
            gxTv_Sdtstatus_Statususuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususuario_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statususuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecreg_Z" )]
      [  XmlElement( ElementName = "statusfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Statusfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtstatus_Statusfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtstatus_Statusfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtstatus_Statusfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtstatus_Statusfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Statusfecreg_Z
      {
         get {
            return gxTv_Sdtstatus_Statusfecreg_Z ;
         }

         set {
            gxTv_Sdtstatus_Statusfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecreg_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecultact_Z" )]
      [  XmlElement( ElementName = "statusfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Statusfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtstatus_Statusfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtstatus_Statusfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtstatus_Statusfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtstatus_Statusfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Statusfecultact_Z
      {
         get {
            return gxTv_Sdtstatus_Statusfecultact_Z ;
         }

         set {
            gxTv_Sdtstatus_Statusfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecultact_Z_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusdsc_N" )]
      [  XmlElement( ElementName = "statusdsc_N"   )]
      public short gxTpr_Statusdsc_N
      {
         get {
            return gxTv_Sdtstatus_Statusdsc_N ;
         }

         set {
            gxTv_Sdtstatus_Statusdsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdsc_N_SetNull( )
      {
         gxTv_Sdtstatus_Statusdsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususotabla_N" )]
      [  XmlElement( ElementName = "statususotabla_N"   )]
      public short gxTpr_Statususotabla_N
      {
         get {
            return gxTv_Sdtstatus_Statususotabla_N ;
         }

         set {
            gxTv_Sdtstatus_Statususotabla_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususotabla_N_SetNull( )
      {
         gxTv_Sdtstatus_Statususotabla_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususotabla_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusdesc_N" )]
      [  XmlElement( ElementName = "statusdesc_N"   )]
      public short gxTpr_Statusdesc_N
      {
         get {
            return gxTv_Sdtstatus_Statusdesc_N ;
         }

         set {
            gxTv_Sdtstatus_Statusdesc_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusdesc_N_SetNull( )
      {
         gxTv_Sdtstatus_Statusdesc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusdesc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statususuario_N" )]
      [  XmlElement( ElementName = "statususuario_N"   )]
      public short gxTpr_Statususuario_N
      {
         get {
            return gxTv_Sdtstatus_Statususuario_N ;
         }

         set {
            gxTv_Sdtstatus_Statususuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statususuario_N_SetNull( )
      {
         gxTv_Sdtstatus_Statususuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statususuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecreg_N" )]
      [  XmlElement( ElementName = "statusfecreg_N"   )]
      public short gxTpr_Statusfecreg_N
      {
         get {
            return gxTv_Sdtstatus_Statusfecreg_N ;
         }

         set {
            gxTv_Sdtstatus_Statusfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecreg_N_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "statusfecultact_N" )]
      [  XmlElement( ElementName = "statusfecultact_N"   )]
      public short gxTpr_Statusfecultact_N
      {
         get {
            return gxTv_Sdtstatus_Statusfecultact_N ;
         }

         set {
            gxTv_Sdtstatus_Statusfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtstatus_Statusfecultact_N_SetNull( )
      {
         gxTv_Sdtstatus_Statusfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtstatus_Statusfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtstatus_Statusdsc = "";
         gxTv_Sdtstatus_Statususotabla = "";
         gxTv_Sdtstatus_Statusdesc = "";
         gxTv_Sdtstatus_Statususuario = "";
         gxTv_Sdtstatus_Statusfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Statusfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Mode = "";
         gxTv_Sdtstatus_Statusdsc_Z = "";
         gxTv_Sdtstatus_Statususotabla_Z = "";
         gxTv_Sdtstatus_Statusdesc_Z = "";
         gxTv_Sdtstatus_Statususuario_Z = "";
         gxTv_Sdtstatus_Statusfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtstatus_Statusfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "status", "GeneXus.Programs.status_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtstatus_Initialized ;
      private short gxTv_Sdtstatus_Statusdsc_N ;
      private short gxTv_Sdtstatus_Statususotabla_N ;
      private short gxTv_Sdtstatus_Statusdesc_N ;
      private short gxTv_Sdtstatus_Statususuario_N ;
      private short gxTv_Sdtstatus_Statusfecreg_N ;
      private short gxTv_Sdtstatus_Statusfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtstatus_Statusid ;
      private int gxTv_Sdtstatus_Statusid_Z ;
      private String gxTv_Sdtstatus_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtstatus_Statusfecreg ;
      private DateTime gxTv_Sdtstatus_Statusfecultact ;
      private DateTime gxTv_Sdtstatus_Statusfecreg_Z ;
      private DateTime gxTv_Sdtstatus_Statusfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtstatus_Statusdsc ;
      private String gxTv_Sdtstatus_Statususotabla ;
      private String gxTv_Sdtstatus_Statusdesc ;
      private String gxTv_Sdtstatus_Statususuario ;
      private String gxTv_Sdtstatus_Statusdsc_Z ;
      private String gxTv_Sdtstatus_Statususotabla_Z ;
      private String gxTv_Sdtstatus_Statusdesc_Z ;
      private String gxTv_Sdtstatus_Statususuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"status", Namespace = "Condufef_v1")]
   public class Sdtstatus_RESTInterface : GxGenericCollectionItem<Sdtstatus>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtstatus_RESTInterface( ) : base()
      {
      }

      public Sdtstatus_RESTInterface( Sdtstatus psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "statusid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Statusid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Statusid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Statusid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "statusdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Statusdsc
      {
         get {
            return sdt.gxTpr_Statusdsc ;
         }

         set {
            sdt.gxTpr_Statusdsc = (String)(value);
         }

      }

      [DataMember( Name = "statususotabla" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Statususotabla
      {
         get {
            return sdt.gxTpr_Statususotabla ;
         }

         set {
            sdt.gxTpr_Statususotabla = (String)(value);
         }

      }

      [DataMember( Name = "statusdesc" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Statusdesc
      {
         get {
            return sdt.gxTpr_Statusdesc ;
         }

         set {
            sdt.gxTpr_Statusdesc = (String)(value);
         }

      }

      [DataMember( Name = "statususuario" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Statususuario
      {
         get {
            return sdt.gxTpr_Statususuario ;
         }

         set {
            sdt.gxTpr_Statususuario = (String)(value);
         }

      }

      [DataMember( Name = "statusfecreg" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Statusfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Statusfecreg) ;
         }

         set {
            sdt.gxTpr_Statusfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "statusfecultact" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Statusfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Statusfecultact) ;
         }

         set {
            sdt.gxTpr_Statusfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtstatus sdt
      {
         get {
            return (Sdtstatus)Sdt ;
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
            sdt = new Sdtstatus() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 22 )]
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
