/*
               File: type_Sdtorigen
        Description: origen
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/27/2022 16:5:42.76
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
   [XmlRoot(ElementName = "origen" )]
   [XmlType(TypeName =  "origen" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtorigen : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtorigen( )
      {
         /* Constructor for serialization */
         gxTv_Sdtorigen_Origendscorta = "";
         gxTv_Sdtorigen_Origendsclarga = "";
         gxTv_Sdtorigen_Origenusuario = "";
         gxTv_Sdtorigen_Origentotal = "";
         gxTv_Sdtorigen_Origenfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Origenfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Mode = "";
         gxTv_Sdtorigen_Origendscorta_Z = "";
         gxTv_Sdtorigen_Origendsclarga_Z = "";
         gxTv_Sdtorigen_Origenusuario_Z = "";
         gxTv_Sdtorigen_Origentotal_Z = "";
         gxTv_Sdtorigen_Origenfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Origenfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtorigen( IGxContext context )
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

      public void Load( long AV10origenid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV10origenid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"origenid", typeof(long)}}) ;
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
         metadata.Set("Name", "origen");
         metadata.Set("BT", "ORIGEN");
         metadata.Set("PK", "[ \"origenid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Origenid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origendscorta_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origendsclarga_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origentotal_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origendscorta_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origendsclarga_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origentotal_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Origenfecultact_N" , attrs);
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
         Sdtorigen deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtorigen)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtorigen obj ;
         obj = this;
         obj.gxTpr_Origenid = deserialized.gxTpr_Origenid;
         obj.gxTpr_Origendscorta = deserialized.gxTpr_Origendscorta;
         obj.gxTpr_Origendsclarga = deserialized.gxTpr_Origendsclarga;
         obj.gxTpr_Origenusuario = deserialized.gxTpr_Origenusuario;
         obj.gxTpr_Origentotal = deserialized.gxTpr_Origentotal;
         obj.gxTpr_Origenfecreg = deserialized.gxTpr_Origenfecreg;
         obj.gxTpr_Origenfecultact = deserialized.gxTpr_Origenfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Origenid_Z = deserialized.gxTpr_Origenid_Z;
         obj.gxTpr_Origendscorta_Z = deserialized.gxTpr_Origendscorta_Z;
         obj.gxTpr_Origendsclarga_Z = deserialized.gxTpr_Origendsclarga_Z;
         obj.gxTpr_Origenusuario_Z = deserialized.gxTpr_Origenusuario_Z;
         obj.gxTpr_Origentotal_Z = deserialized.gxTpr_Origentotal_Z;
         obj.gxTpr_Origenfecreg_Z = deserialized.gxTpr_Origenfecreg_Z;
         obj.gxTpr_Origenfecultact_Z = deserialized.gxTpr_Origenfecultact_Z;
         obj.gxTpr_Origenid_N = deserialized.gxTpr_Origenid_N;
         obj.gxTpr_Origendscorta_N = deserialized.gxTpr_Origendscorta_N;
         obj.gxTpr_Origendsclarga_N = deserialized.gxTpr_Origendsclarga_N;
         obj.gxTpr_Origenusuario_N = deserialized.gxTpr_Origenusuario_N;
         obj.gxTpr_Origentotal_N = deserialized.gxTpr_Origentotal_N;
         obj.gxTpr_Origenfecreg_N = deserialized.gxTpr_Origenfecreg_N;
         obj.gxTpr_Origenfecultact_N = deserialized.gxTpr_Origenfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenid") )
               {
                  gxTv_Sdtorigen_Origenid = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendscorta") )
               {
                  gxTv_Sdtorigen_Origendscorta = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendsclarga") )
               {
                  gxTv_Sdtorigen_Origendsclarga = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenusuario") )
               {
                  gxTv_Sdtorigen_Origenusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origentotal") )
               {
                  gxTv_Sdtorigen_Origentotal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtorigen_Origenfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtorigen_Origenfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtorigen_Origenfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtorigen_Origenfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtorigen_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtorigen_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenid_Z") )
               {
                  gxTv_Sdtorigen_Origenid_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendscorta_Z") )
               {
                  gxTv_Sdtorigen_Origendscorta_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendsclarga_Z") )
               {
                  gxTv_Sdtorigen_Origendsclarga_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenusuario_Z") )
               {
                  gxTv_Sdtorigen_Origenusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origentotal_Z") )
               {
                  gxTv_Sdtorigen_Origentotal_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtorigen_Origenfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtorigen_Origenfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtorigen_Origenfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtorigen_Origenfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenid_N") )
               {
                  gxTv_Sdtorigen_Origenid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendscorta_N") )
               {
                  gxTv_Sdtorigen_Origendscorta_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origendsclarga_N") )
               {
                  gxTv_Sdtorigen_Origendsclarga_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenusuario_N") )
               {
                  gxTv_Sdtorigen_Origenusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origentotal_N") )
               {
                  gxTv_Sdtorigen_Origentotal_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecreg_N") )
               {
                  gxTv_Sdtorigen_Origenfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "origenfecultact_N") )
               {
                  gxTv_Sdtorigen_Origenfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "origen";
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
         oWriter.WriteElement("origenid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenid), 18, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("origendscorta", StringUtil.RTrim( gxTv_Sdtorigen_Origendscorta));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("origendsclarga", StringUtil.RTrim( gxTv_Sdtorigen_Origendsclarga));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("origenusuario", StringUtil.RTrim( gxTv_Sdtorigen_Origenusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("origentotal", StringUtil.RTrim( gxTv_Sdtorigen_Origentotal));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtorigen_Origenfecreg) )
         {
            oWriter.WriteStartElement("origenfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtorigen_Origenfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("origenfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtorigen_Origenfecultact) )
         {
            oWriter.WriteStartElement("origenfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtorigen_Origenfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("origenfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtorigen_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origenid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenid_Z), 18, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origendscorta_Z", StringUtil.RTrim( gxTv_Sdtorigen_Origendscorta_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origendsclarga_Z", StringUtil.RTrim( gxTv_Sdtorigen_Origendsclarga_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origenusuario_Z", StringUtil.RTrim( gxTv_Sdtorigen_Origenusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origentotal_Z", StringUtil.RTrim( gxTv_Sdtorigen_Origentotal_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtorigen_Origenfecreg_Z) )
            {
               oWriter.WriteStartElement("origenfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtorigen_Origenfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("origenfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtorigen_Origenfecultact_Z) )
            {
               oWriter.WriteStartElement("origenfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtorigen_Origenfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("origenfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("origenid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origendscorta_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origendscorta_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origendsclarga_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origendsclarga_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origenusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origentotal_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origentotal_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origenfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("origenfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenfecultact_N), 1, 0)));
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
         AddObjectProperty("origenid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenid), 18, 0)), false);
         AddObjectProperty("origendscorta", gxTv_Sdtorigen_Origendscorta, false);
         AddObjectProperty("origendsclarga", gxTv_Sdtorigen_Origendsclarga, false);
         AddObjectProperty("origenusuario", gxTv_Sdtorigen_Origenusuario, false);
         AddObjectProperty("origentotal", gxTv_Sdtorigen_Origentotal, false);
         datetime_STZ = gxTv_Sdtorigen_Origenfecreg;
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
         AddObjectProperty("origenfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtorigen_Origenfecultact;
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
         AddObjectProperty("origenfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtorigen_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtorigen_Initialized, false);
            AddObjectProperty("origenid_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtorigen_Origenid_Z), 18, 0)), false);
            AddObjectProperty("origendscorta_Z", gxTv_Sdtorigen_Origendscorta_Z, false);
            AddObjectProperty("origendsclarga_Z", gxTv_Sdtorigen_Origendsclarga_Z, false);
            AddObjectProperty("origenusuario_Z", gxTv_Sdtorigen_Origenusuario_Z, false);
            AddObjectProperty("origentotal_Z", gxTv_Sdtorigen_Origentotal_Z, false);
            datetime_STZ = gxTv_Sdtorigen_Origenfecreg_Z;
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
            AddObjectProperty("origenfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtorigen_Origenfecultact_Z;
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
            AddObjectProperty("origenfecultact_Z", sDateCnv, false);
            AddObjectProperty("origenid_N", gxTv_Sdtorigen_Origenid_N, false);
            AddObjectProperty("origendscorta_N", gxTv_Sdtorigen_Origendscorta_N, false);
            AddObjectProperty("origendsclarga_N", gxTv_Sdtorigen_Origendsclarga_N, false);
            AddObjectProperty("origenusuario_N", gxTv_Sdtorigen_Origenusuario_N, false);
            AddObjectProperty("origentotal_N", gxTv_Sdtorigen_Origentotal_N, false);
            AddObjectProperty("origenfecreg_N", gxTv_Sdtorigen_Origenfecreg_N, false);
            AddObjectProperty("origenfecultact_N", gxTv_Sdtorigen_Origenfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "origenid" )]
      [  XmlElement( ElementName = "origenid"   )]
      public long gxTpr_Origenid
      {
         get {
            return gxTv_Sdtorigen_Origenid ;
         }

         set {
            if ( gxTv_Sdtorigen_Origenid != value )
            {
               gxTv_Sdtorigen_Mode = "INS";
               this.gxTv_Sdtorigen_Origenid_Z_SetNull( );
               this.gxTv_Sdtorigen_Origendscorta_Z_SetNull( );
               this.gxTv_Sdtorigen_Origendsclarga_Z_SetNull( );
               this.gxTv_Sdtorigen_Origenusuario_Z_SetNull( );
               this.gxTv_Sdtorigen_Origentotal_Z_SetNull( );
               this.gxTv_Sdtorigen_Origenfecreg_Z_SetNull( );
               this.gxTv_Sdtorigen_Origenfecultact_Z_SetNull( );
            }
            gxTv_Sdtorigen_Origenid = (long)(value);
         }

      }

      [  SoapElement( ElementName = "origendscorta" )]
      [  XmlElement( ElementName = "origendscorta"   )]
      public String gxTpr_Origendscorta
      {
         get {
            return gxTv_Sdtorigen_Origendscorta ;
         }

         set {
            gxTv_Sdtorigen_Origendscorta_N = 0;
            gxTv_Sdtorigen_Origendscorta = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendscorta_SetNull( )
      {
         gxTv_Sdtorigen_Origendscorta_N = 1;
         gxTv_Sdtorigen_Origendscorta = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendscorta_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origendsclarga" )]
      [  XmlElement( ElementName = "origendsclarga"   )]
      public String gxTpr_Origendsclarga
      {
         get {
            return gxTv_Sdtorigen_Origendsclarga ;
         }

         set {
            gxTv_Sdtorigen_Origendsclarga_N = 0;
            gxTv_Sdtorigen_Origendsclarga = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendsclarga_SetNull( )
      {
         gxTv_Sdtorigen_Origendsclarga_N = 1;
         gxTv_Sdtorigen_Origendsclarga = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendsclarga_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenusuario" )]
      [  XmlElement( ElementName = "origenusuario"   )]
      public String gxTpr_Origenusuario
      {
         get {
            return gxTv_Sdtorigen_Origenusuario ;
         }

         set {
            gxTv_Sdtorigen_Origenusuario_N = 0;
            gxTv_Sdtorigen_Origenusuario = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenusuario_SetNull( )
      {
         gxTv_Sdtorigen_Origenusuario_N = 1;
         gxTv_Sdtorigen_Origenusuario = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origentotal" )]
      [  XmlElement( ElementName = "origentotal"   )]
      public String gxTpr_Origentotal
      {
         get {
            return gxTv_Sdtorigen_Origentotal ;
         }

         set {
            gxTv_Sdtorigen_Origentotal_N = 0;
            gxTv_Sdtorigen_Origentotal = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origentotal_SetNull( )
      {
         gxTv_Sdtorigen_Origentotal_N = 1;
         gxTv_Sdtorigen_Origentotal = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origentotal_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecreg" )]
      [  XmlElement( ElementName = "origenfecreg"  , IsNullable=true )]
      public string gxTpr_Origenfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtorigen_Origenfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtorigen_Origenfecreg).value ;
         }

         set {
            gxTv_Sdtorigen_Origenfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtorigen_Origenfecreg = DateTime.MinValue;
            else
               gxTv_Sdtorigen_Origenfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Origenfecreg
      {
         get {
            return gxTv_Sdtorigen_Origenfecreg ;
         }

         set {
            gxTv_Sdtorigen_Origenfecreg_N = 0;
            gxTv_Sdtorigen_Origenfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecreg_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecreg_N = 1;
         gxTv_Sdtorigen_Origenfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecultact" )]
      [  XmlElement( ElementName = "origenfecultact"  , IsNullable=true )]
      public string gxTpr_Origenfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtorigen_Origenfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtorigen_Origenfecultact).value ;
         }

         set {
            gxTv_Sdtorigen_Origenfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtorigen_Origenfecultact = DateTime.MinValue;
            else
               gxTv_Sdtorigen_Origenfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Origenfecultact
      {
         get {
            return gxTv_Sdtorigen_Origenfecultact ;
         }

         set {
            gxTv_Sdtorigen_Origenfecultact_N = 0;
            gxTv_Sdtorigen_Origenfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecultact_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecultact_N = 1;
         gxTv_Sdtorigen_Origenfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtorigen_Mode ;
         }

         set {
            gxTv_Sdtorigen_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Mode_SetNull( )
      {
         gxTv_Sdtorigen_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtorigen_Initialized ;
         }

         set {
            gxTv_Sdtorigen_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Initialized_SetNull( )
      {
         gxTv_Sdtorigen_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenid_Z" )]
      [  XmlElement( ElementName = "origenid_Z"   )]
      public long gxTpr_Origenid_Z
      {
         get {
            return gxTv_Sdtorigen_Origenid_Z ;
         }

         set {
            gxTv_Sdtorigen_Origenid_Z = (long)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenid_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origenid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origendscorta_Z" )]
      [  XmlElement( ElementName = "origendscorta_Z"   )]
      public String gxTpr_Origendscorta_Z
      {
         get {
            return gxTv_Sdtorigen_Origendscorta_Z ;
         }

         set {
            gxTv_Sdtorigen_Origendscorta_Z = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendscorta_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origendscorta_Z = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendscorta_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origendsclarga_Z" )]
      [  XmlElement( ElementName = "origendsclarga_Z"   )]
      public String gxTpr_Origendsclarga_Z
      {
         get {
            return gxTv_Sdtorigen_Origendsclarga_Z ;
         }

         set {
            gxTv_Sdtorigen_Origendsclarga_Z = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendsclarga_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origendsclarga_Z = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendsclarga_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenusuario_Z" )]
      [  XmlElement( ElementName = "origenusuario_Z"   )]
      public String gxTpr_Origenusuario_Z
      {
         get {
            return gxTv_Sdtorigen_Origenusuario_Z ;
         }

         set {
            gxTv_Sdtorigen_Origenusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenusuario_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origenusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origentotal_Z" )]
      [  XmlElement( ElementName = "origentotal_Z"   )]
      public String gxTpr_Origentotal_Z
      {
         get {
            return gxTv_Sdtorigen_Origentotal_Z ;
         }

         set {
            gxTv_Sdtorigen_Origentotal_Z = (String)(value);
         }

      }

      public void gxTv_Sdtorigen_Origentotal_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origentotal_Z = "";
         return  ;
      }

      public bool gxTv_Sdtorigen_Origentotal_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecreg_Z" )]
      [  XmlElement( ElementName = "origenfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Origenfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtorigen_Origenfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtorigen_Origenfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtorigen_Origenfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtorigen_Origenfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Origenfecreg_Z
      {
         get {
            return gxTv_Sdtorigen_Origenfecreg_Z ;
         }

         set {
            gxTv_Sdtorigen_Origenfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecreg_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecultact_Z" )]
      [  XmlElement( ElementName = "origenfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Origenfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtorigen_Origenfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtorigen_Origenfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtorigen_Origenfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtorigen_Origenfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Origenfecultact_Z
      {
         get {
            return gxTv_Sdtorigen_Origenfecultact_Z ;
         }

         set {
            gxTv_Sdtorigen_Origenfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecultact_Z_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenid_N" )]
      [  XmlElement( ElementName = "origenid_N"   )]
      public short gxTpr_Origenid_N
      {
         get {
            return gxTv_Sdtorigen_Origenid_N ;
         }

         set {
            gxTv_Sdtorigen_Origenid_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenid_N_SetNull( )
      {
         gxTv_Sdtorigen_Origenid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origendscorta_N" )]
      [  XmlElement( ElementName = "origendscorta_N"   )]
      public short gxTpr_Origendscorta_N
      {
         get {
            return gxTv_Sdtorigen_Origendscorta_N ;
         }

         set {
            gxTv_Sdtorigen_Origendscorta_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendscorta_N_SetNull( )
      {
         gxTv_Sdtorigen_Origendscorta_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendscorta_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origendsclarga_N" )]
      [  XmlElement( ElementName = "origendsclarga_N"   )]
      public short gxTpr_Origendsclarga_N
      {
         get {
            return gxTv_Sdtorigen_Origendsclarga_N ;
         }

         set {
            gxTv_Sdtorigen_Origendsclarga_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origendsclarga_N_SetNull( )
      {
         gxTv_Sdtorigen_Origendsclarga_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origendsclarga_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenusuario_N" )]
      [  XmlElement( ElementName = "origenusuario_N"   )]
      public short gxTpr_Origenusuario_N
      {
         get {
            return gxTv_Sdtorigen_Origenusuario_N ;
         }

         set {
            gxTv_Sdtorigen_Origenusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenusuario_N_SetNull( )
      {
         gxTv_Sdtorigen_Origenusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origentotal_N" )]
      [  XmlElement( ElementName = "origentotal_N"   )]
      public short gxTpr_Origentotal_N
      {
         get {
            return gxTv_Sdtorigen_Origentotal_N ;
         }

         set {
            gxTv_Sdtorigen_Origentotal_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origentotal_N_SetNull( )
      {
         gxTv_Sdtorigen_Origentotal_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origentotal_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecreg_N" )]
      [  XmlElement( ElementName = "origenfecreg_N"   )]
      public short gxTpr_Origenfecreg_N
      {
         get {
            return gxTv_Sdtorigen_Origenfecreg_N ;
         }

         set {
            gxTv_Sdtorigen_Origenfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecreg_N_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "origenfecultact_N" )]
      [  XmlElement( ElementName = "origenfecultact_N"   )]
      public short gxTpr_Origenfecultact_N
      {
         get {
            return gxTv_Sdtorigen_Origenfecultact_N ;
         }

         set {
            gxTv_Sdtorigen_Origenfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtorigen_Origenfecultact_N_SetNull( )
      {
         gxTv_Sdtorigen_Origenfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtorigen_Origenfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtorigen_Origendscorta = "";
         gxTv_Sdtorigen_Origendsclarga = "";
         gxTv_Sdtorigen_Origenusuario = "";
         gxTv_Sdtorigen_Origentotal = "";
         gxTv_Sdtorigen_Origenfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Origenfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Mode = "";
         gxTv_Sdtorigen_Origendscorta_Z = "";
         gxTv_Sdtorigen_Origendsclarga_Z = "";
         gxTv_Sdtorigen_Origenusuario_Z = "";
         gxTv_Sdtorigen_Origentotal_Z = "";
         gxTv_Sdtorigen_Origenfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtorigen_Origenfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "origen", "GeneXus.Programs.origen_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtorigen_Initialized ;
      private short gxTv_Sdtorigen_Origenid_N ;
      private short gxTv_Sdtorigen_Origendscorta_N ;
      private short gxTv_Sdtorigen_Origendsclarga_N ;
      private short gxTv_Sdtorigen_Origenusuario_N ;
      private short gxTv_Sdtorigen_Origentotal_N ;
      private short gxTv_Sdtorigen_Origenfecreg_N ;
      private short gxTv_Sdtorigen_Origenfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private long gxTv_Sdtorigen_Origenid ;
      private long gxTv_Sdtorigen_Origenid_Z ;
      private String gxTv_Sdtorigen_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtorigen_Origenfecreg ;
      private DateTime gxTv_Sdtorigen_Origenfecultact ;
      private DateTime gxTv_Sdtorigen_Origenfecreg_Z ;
      private DateTime gxTv_Sdtorigen_Origenfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtorigen_Origendscorta ;
      private String gxTv_Sdtorigen_Origendsclarga ;
      private String gxTv_Sdtorigen_Origenusuario ;
      private String gxTv_Sdtorigen_Origentotal ;
      private String gxTv_Sdtorigen_Origendscorta_Z ;
      private String gxTv_Sdtorigen_Origendsclarga_Z ;
      private String gxTv_Sdtorigen_Origenusuario_Z ;
      private String gxTv_Sdtorigen_Origentotal_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"origen", Namespace = "Condufef_v1")]
   public class Sdtorigen_RESTInterface : GxGenericCollectionItem<Sdtorigen>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtorigen_RESTInterface( ) : base()
      {
      }

      public Sdtorigen_RESTInterface( Sdtorigen psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "origenid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Origenid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Origenid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Origenid = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "origendscorta" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Origendscorta
      {
         get {
            return sdt.gxTpr_Origendscorta ;
         }

         set {
            sdt.gxTpr_Origendscorta = (String)(value);
         }

      }

      [DataMember( Name = "origendsclarga" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Origendsclarga
      {
         get {
            return sdt.gxTpr_Origendsclarga ;
         }

         set {
            sdt.gxTpr_Origendsclarga = (String)(value);
         }

      }

      [DataMember( Name = "origenusuario" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Origenusuario
      {
         get {
            return sdt.gxTpr_Origenusuario ;
         }

         set {
            sdt.gxTpr_Origenusuario = (String)(value);
         }

      }

      [DataMember( Name = "origentotal" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Origentotal
      {
         get {
            return sdt.gxTpr_Origentotal ;
         }

         set {
            sdt.gxTpr_Origentotal = (String)(value);
         }

      }

      [DataMember( Name = "origenfecreg" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Origenfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Origenfecreg) ;
         }

         set {
            sdt.gxTpr_Origenfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "origenfecultact" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Origenfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Origenfecultact) ;
         }

         set {
            sdt.gxTpr_Origenfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtorigen sdt
      {
         get {
            return (Sdtorigen)Sdt ;
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
            sdt = new Sdtorigen() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 23 )]
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
