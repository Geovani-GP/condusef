/*
               File: type_Sdtentidadfederativa
        Description: entidadfederativa
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:42:14.75
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
   [XmlRoot(ElementName = "entidadfederativa" )]
   [XmlType(TypeName =  "entidadfederativa" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtentidadfederativa : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtentidadfederativa( )
      {
         /* Constructor for serialization */
         gxTv_Sdtentidadfederativa_Entidadfederativadsc = "";
         gxTv_Sdtentidadfederativa_Entidadfederativausuario = "";
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Mode = "";
         gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z = "";
         gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z = "";
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtentidadfederativa( IGxContext context )
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

      public void Load( int AV7entidafederativaid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV7entidafederativaid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"entidafederativaid", typeof(int)}}) ;
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
         metadata.Set("Name", "entidadfederativa");
         metadata.Set("BT", "ENTIDADFEDERATIVA");
         metadata.Set("PK", "[ \"entidafederativaid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Entidafederativaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativadsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativausuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativafecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativafecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidafederativaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativadsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativausuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativafecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Entidadfederativafecultact_N" , attrs);
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
         Sdtentidadfederativa deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtentidadfederativa)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtentidadfederativa obj ;
         obj = this;
         obj.gxTpr_Entidafederativaid = deserialized.gxTpr_Entidafederativaid;
         obj.gxTpr_Entidadfederativadsc = deserialized.gxTpr_Entidadfederativadsc;
         obj.gxTpr_Entidadfederativausuario = deserialized.gxTpr_Entidadfederativausuario;
         obj.gxTpr_Entidadfederativafecreg = deserialized.gxTpr_Entidadfederativafecreg;
         obj.gxTpr_Entidadfederativafecultact = deserialized.gxTpr_Entidadfederativafecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Entidafederativaid_Z = deserialized.gxTpr_Entidafederativaid_Z;
         obj.gxTpr_Entidadfederativadsc_Z = deserialized.gxTpr_Entidadfederativadsc_Z;
         obj.gxTpr_Entidadfederativausuario_Z = deserialized.gxTpr_Entidadfederativausuario_Z;
         obj.gxTpr_Entidadfederativafecreg_Z = deserialized.gxTpr_Entidadfederativafecreg_Z;
         obj.gxTpr_Entidadfederativafecultact_Z = deserialized.gxTpr_Entidadfederativafecultact_Z;
         obj.gxTpr_Entidafederativaid_N = deserialized.gxTpr_Entidafederativaid_N;
         obj.gxTpr_Entidadfederativadsc_N = deserialized.gxTpr_Entidadfederativadsc_N;
         obj.gxTpr_Entidadfederativausuario_N = deserialized.gxTpr_Entidadfederativausuario_N;
         obj.gxTpr_Entidadfederativafecreg_N = deserialized.gxTpr_Entidadfederativafecreg_N;
         obj.gxTpr_Entidadfederativafecultact_N = deserialized.gxTpr_Entidadfederativafecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidafederativaid") )
               {
                  gxTv_Sdtentidadfederativa_Entidafederativaid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativadsc") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativadsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativausuario") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativausuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtentidadfederativa_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtentidadfederativa_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidafederativaid_Z") )
               {
                  gxTv_Sdtentidadfederativa_Entidafederativaid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativadsc_Z") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativausuario_Z") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidafederativaid_N") )
               {
                  gxTv_Sdtentidadfederativa_Entidafederativaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativadsc_N") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativadsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativausuario_N") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativausuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecreg_N") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "entidadfederativafecultact_N") )
               {
                  gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "entidadfederativa";
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
         oWriter.WriteElement("entidafederativaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidafederativaid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("entidadfederativadsc", StringUtil.RTrim( gxTv_Sdtentidadfederativa_Entidadfederativadsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("entidadfederativausuario", StringUtil.RTrim( gxTv_Sdtentidadfederativa_Entidadfederativausuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtentidadfederativa_Entidadfederativafecreg) )
         {
            oWriter.WriteStartElement("entidadfederativafecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtentidadfederativa_Entidadfederativafecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("entidadfederativafecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtentidadfederativa_Entidadfederativafecultact) )
         {
            oWriter.WriteStartElement("entidadfederativafecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtentidadfederativa_Entidadfederativafecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("entidadfederativafecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtentidadfederativa_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidafederativaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidafederativaid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativadsc_Z", StringUtil.RTrim( gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativausuario_Z", StringUtil.RTrim( gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z) )
            {
               oWriter.WriteStartElement("entidadfederativafecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("entidadfederativafecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z) )
            {
               oWriter.WriteStartElement("entidadfederativafecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("entidadfederativafecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("entidafederativaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidafederativaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativadsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidadfederativadsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativausuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidadfederativausuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativafecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("entidadfederativafecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N), 1, 0)));
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
         AddObjectProperty("entidafederativaid", gxTv_Sdtentidadfederativa_Entidafederativaid, false);
         AddObjectProperty("entidadfederativadsc", gxTv_Sdtentidadfederativa_Entidadfederativadsc, false);
         AddObjectProperty("entidadfederativausuario", gxTv_Sdtentidadfederativa_Entidadfederativausuario, false);
         datetime_STZ = gxTv_Sdtentidadfederativa_Entidadfederativafecreg;
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
         AddObjectProperty("entidadfederativafecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtentidadfederativa_Entidadfederativafecultact;
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
         AddObjectProperty("entidadfederativafecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtentidadfederativa_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtentidadfederativa_Initialized, false);
            AddObjectProperty("entidafederativaid_Z", gxTv_Sdtentidadfederativa_Entidafederativaid_Z, false);
            AddObjectProperty("entidadfederativadsc_Z", gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z, false);
            AddObjectProperty("entidadfederativausuario_Z", gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z, false);
            datetime_STZ = gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z;
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
            AddObjectProperty("entidadfederativafecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z;
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
            AddObjectProperty("entidadfederativafecultact_Z", sDateCnv, false);
            AddObjectProperty("entidafederativaid_N", gxTv_Sdtentidadfederativa_Entidafederativaid_N, false);
            AddObjectProperty("entidadfederativadsc_N", gxTv_Sdtentidadfederativa_Entidadfederativadsc_N, false);
            AddObjectProperty("entidadfederativausuario_N", gxTv_Sdtentidadfederativa_Entidadfederativausuario_N, false);
            AddObjectProperty("entidadfederativafecreg_N", gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N, false);
            AddObjectProperty("entidadfederativafecultact_N", gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "entidafederativaid" )]
      [  XmlElement( ElementName = "entidafederativaid"   )]
      public int gxTpr_Entidafederativaid
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidafederativaid ;
         }

         set {
            if ( gxTv_Sdtentidadfederativa_Entidafederativaid != value )
            {
               gxTv_Sdtentidadfederativa_Mode = "INS";
               this.gxTv_Sdtentidadfederativa_Entidafederativaid_Z_SetNull( );
               this.gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z_SetNull( );
               this.gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z_SetNull( );
               this.gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z_SetNull( );
               this.gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z_SetNull( );
            }
            gxTv_Sdtentidadfederativa_Entidafederativaid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "entidadfederativadsc" )]
      [  XmlElement( ElementName = "entidadfederativadsc"   )]
      public String gxTpr_Entidadfederativadsc
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativadsc ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativadsc_N = 0;
            gxTv_Sdtentidadfederativa_Entidadfederativadsc = (String)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativadsc_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativadsc_N = 1;
         gxTv_Sdtentidadfederativa_Entidadfederativadsc = "";
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativadsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativausuario" )]
      [  XmlElement( ElementName = "entidadfederativausuario"   )]
      public String gxTpr_Entidadfederativausuario
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativausuario ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativausuario_N = 0;
            gxTv_Sdtentidadfederativa_Entidadfederativausuario = (String)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativausuario_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativausuario_N = 1;
         gxTv_Sdtentidadfederativa_Entidadfederativausuario = "";
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativausuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecreg" )]
      [  XmlElement( ElementName = "entidadfederativafecreg"  , IsNullable=true )]
      public string gxTpr_Entidadfederativafecreg_Nullable
      {
         get {
            if ( gxTv_Sdtentidadfederativa_Entidadfederativafecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtentidadfederativa_Entidadfederativafecreg).value ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtentidadfederativa_Entidadfederativafecreg = DateTime.MinValue;
            else
               gxTv_Sdtentidadfederativa_Entidadfederativafecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Entidadfederativafecreg
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecreg ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = 0;
            gxTv_Sdtentidadfederativa_Entidadfederativafecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecreg_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = 1;
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecultact" )]
      [  XmlElement( ElementName = "entidadfederativafecultact"  , IsNullable=true )]
      public string gxTpr_Entidadfederativafecultact_Nullable
      {
         get {
            if ( gxTv_Sdtentidadfederativa_Entidadfederativafecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtentidadfederativa_Entidadfederativafecultact).value ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtentidadfederativa_Entidadfederativafecultact = DateTime.MinValue;
            else
               gxTv_Sdtentidadfederativa_Entidadfederativafecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Entidadfederativafecultact
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecultact ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = 0;
            gxTv_Sdtentidadfederativa_Entidadfederativafecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecultact_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = 1;
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtentidadfederativa_Mode ;
         }

         set {
            gxTv_Sdtentidadfederativa_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Mode_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtentidadfederativa_Initialized ;
         }

         set {
            gxTv_Sdtentidadfederativa_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Initialized_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidafederativaid_Z" )]
      [  XmlElement( ElementName = "entidafederativaid_Z"   )]
      public int gxTpr_Entidafederativaid_Z
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidafederativaid_Z ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidafederativaid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidafederativaid_Z_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidafederativaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidafederativaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativadsc_Z" )]
      [  XmlElement( ElementName = "entidadfederativadsc_Z"   )]
      public String gxTpr_Entidadfederativadsc_Z
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativausuario_Z" )]
      [  XmlElement( ElementName = "entidadfederativausuario_Z"   )]
      public String gxTpr_Entidadfederativausuario_Z
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecreg_Z" )]
      [  XmlElement( ElementName = "entidadfederativafecreg_Z"  , IsNullable=true )]
      public string gxTpr_Entidadfederativafecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Entidadfederativafecreg_Z
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecultact_Z" )]
      [  XmlElement( ElementName = "entidadfederativafecultact_Z"  , IsNullable=true )]
      public string gxTpr_Entidadfederativafecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Entidadfederativafecultact_Z
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidafederativaid_N" )]
      [  XmlElement( ElementName = "entidafederativaid_N"   )]
      public short gxTpr_Entidafederativaid_N
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidafederativaid_N ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidafederativaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidafederativaid_N_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidafederativaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidafederativaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativadsc_N" )]
      [  XmlElement( ElementName = "entidadfederativadsc_N"   )]
      public short gxTpr_Entidadfederativadsc_N
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativadsc_N ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativadsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativadsc_N_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativadsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativadsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativausuario_N" )]
      [  XmlElement( ElementName = "entidadfederativausuario_N"   )]
      public short gxTpr_Entidadfederativausuario_N
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativausuario_N ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativausuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativausuario_N_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativausuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativausuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecreg_N" )]
      [  XmlElement( ElementName = "entidadfederativafecreg_N"   )]
      public short gxTpr_Entidadfederativafecreg_N
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "entidadfederativafecultact_N" )]
      [  XmlElement( ElementName = "entidadfederativafecultact_N"   )]
      public short gxTpr_Entidadfederativafecultact_N
      {
         get {
            return gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N ;
         }

         set {
            gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N_SetNull( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtentidadfederativa_Entidadfederativadsc = "";
         gxTv_Sdtentidadfederativa_Entidadfederativausuario = "";
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Mode = "";
         gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z = "";
         gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z = "";
         gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "entidadfederativa", "GeneXus.Programs.entidadfederativa_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtentidadfederativa_Initialized ;
      private short gxTv_Sdtentidadfederativa_Entidafederativaid_N ;
      private short gxTv_Sdtentidadfederativa_Entidadfederativadsc_N ;
      private short gxTv_Sdtentidadfederativa_Entidadfederativausuario_N ;
      private short gxTv_Sdtentidadfederativa_Entidadfederativafecreg_N ;
      private short gxTv_Sdtentidadfederativa_Entidadfederativafecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtentidadfederativa_Entidafederativaid ;
      private int gxTv_Sdtentidadfederativa_Entidafederativaid_Z ;
      private String gxTv_Sdtentidadfederativa_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtentidadfederativa_Entidadfederativafecreg ;
      private DateTime gxTv_Sdtentidadfederativa_Entidadfederativafecultact ;
      private DateTime gxTv_Sdtentidadfederativa_Entidadfederativafecreg_Z ;
      private DateTime gxTv_Sdtentidadfederativa_Entidadfederativafecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtentidadfederativa_Entidadfederativadsc ;
      private String gxTv_Sdtentidadfederativa_Entidadfederativausuario ;
      private String gxTv_Sdtentidadfederativa_Entidadfederativadsc_Z ;
      private String gxTv_Sdtentidadfederativa_Entidadfederativausuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"entidadfederativa", Namespace = "Condufef_v1")]
   public class Sdtentidadfederativa_RESTInterface : GxGenericCollectionItem<Sdtentidadfederativa>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtentidadfederativa_RESTInterface( ) : base()
      {
      }

      public Sdtentidadfederativa_RESTInterface( Sdtentidadfederativa psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "entidafederativaid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Entidafederativaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Entidafederativaid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Entidafederativaid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "entidadfederativadsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Entidadfederativadsc
      {
         get {
            return sdt.gxTpr_Entidadfederativadsc ;
         }

         set {
            sdt.gxTpr_Entidadfederativadsc = (String)(value);
         }

      }

      [DataMember( Name = "entidadfederativausuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Entidadfederativausuario
      {
         get {
            return sdt.gxTpr_Entidadfederativausuario ;
         }

         set {
            sdt.gxTpr_Entidadfederativausuario = (String)(value);
         }

      }

      [DataMember( Name = "entidadfederativafecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Entidadfederativafecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Entidadfederativafecreg) ;
         }

         set {
            sdt.gxTpr_Entidadfederativafecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "entidadfederativafecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Entidadfederativafecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Entidadfederativafecultact) ;
         }

         set {
            sdt.gxTpr_Entidadfederativafecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtentidadfederativa sdt
      {
         get {
            return (Sdtentidadfederativa)Sdt ;
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
            sdt = new Sdtentidadfederativa() ;
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
