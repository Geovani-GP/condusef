/*
               File: type_Sdtmodelos
        Description: modelos
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:0.46
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
   [XmlRoot(ElementName = "modelos" )]
   [XmlType(TypeName =  "modelos" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtmodelos : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtmodelos( )
      {
         /* Constructor for serialization */
         gxTv_Sdtmodelos_Modelosdsc = "";
         gxTv_Sdtmodelos_Modelosusuario = "";
         gxTv_Sdtmodelos_Modelosfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Modelosfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Mode = "";
         gxTv_Sdtmodelos_Modelosdsc_Z = "";
         gxTv_Sdtmodelos_Modelosusuario_Z = "";
         gxTv_Sdtmodelos_Modelosfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Modelosfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtmodelos( IGxContext context )
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

      public void Load( int AV15modelosid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV15modelosid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"modelosid", typeof(int)}}) ;
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
         metadata.Set("Name", "modelos");
         metadata.Set("BT", "MODELOS");
         metadata.Set("PK", "[ \"modelosid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Modelosid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosdsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosdsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Modelosfecultact_N" , attrs);
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
         Sdtmodelos deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtmodelos)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtmodelos obj ;
         obj = this;
         obj.gxTpr_Modelosid = deserialized.gxTpr_Modelosid;
         obj.gxTpr_Modelosdsc = deserialized.gxTpr_Modelosdsc;
         obj.gxTpr_Modelosusuario = deserialized.gxTpr_Modelosusuario;
         obj.gxTpr_Modelosfecreg = deserialized.gxTpr_Modelosfecreg;
         obj.gxTpr_Modelosfecultact = deserialized.gxTpr_Modelosfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Modelosid_Z = deserialized.gxTpr_Modelosid_Z;
         obj.gxTpr_Modelosdsc_Z = deserialized.gxTpr_Modelosdsc_Z;
         obj.gxTpr_Modelosusuario_Z = deserialized.gxTpr_Modelosusuario_Z;
         obj.gxTpr_Modelosfecreg_Z = deserialized.gxTpr_Modelosfecreg_Z;
         obj.gxTpr_Modelosfecultact_Z = deserialized.gxTpr_Modelosfecultact_Z;
         obj.gxTpr_Modelosdsc_N = deserialized.gxTpr_Modelosdsc_N;
         obj.gxTpr_Modelosusuario_N = deserialized.gxTpr_Modelosusuario_N;
         obj.gxTpr_Modelosfecreg_N = deserialized.gxTpr_Modelosfecreg_N;
         obj.gxTpr_Modelosfecultact_N = deserialized.gxTpr_Modelosfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosid") )
               {
                  gxTv_Sdtmodelos_Modelosid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosdsc") )
               {
                  gxTv_Sdtmodelos_Modelosdsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosusuario") )
               {
                  gxTv_Sdtmodelos_Modelosusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmodelos_Modelosfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmodelos_Modelosfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmodelos_Modelosfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmodelos_Modelosfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtmodelos_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtmodelos_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosid_Z") )
               {
                  gxTv_Sdtmodelos_Modelosid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosdsc_Z") )
               {
                  gxTv_Sdtmodelos_Modelosdsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosusuario_Z") )
               {
                  gxTv_Sdtmodelos_Modelosusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmodelos_Modelosfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmodelos_Modelosfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmodelos_Modelosfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmodelos_Modelosfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosdsc_N") )
               {
                  gxTv_Sdtmodelos_Modelosdsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosusuario_N") )
               {
                  gxTv_Sdtmodelos_Modelosusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecreg_N") )
               {
                  gxTv_Sdtmodelos_Modelosfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "modelosfecultact_N") )
               {
                  gxTv_Sdtmodelos_Modelosfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "modelos";
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
         oWriter.WriteElement("modelosid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("modelosdsc", StringUtil.RTrim( gxTv_Sdtmodelos_Modelosdsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("modelosusuario", StringUtil.RTrim( gxTv_Sdtmodelos_Modelosusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtmodelos_Modelosfecreg) )
         {
            oWriter.WriteStartElement("modelosfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmodelos_Modelosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("modelosfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtmodelos_Modelosfecultact) )
         {
            oWriter.WriteStartElement("modelosfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmodelos_Modelosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("modelosfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtmodelos_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosdsc_Z", StringUtil.RTrim( gxTv_Sdtmodelos_Modelosdsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosusuario_Z", StringUtil.RTrim( gxTv_Sdtmodelos_Modelosusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtmodelos_Modelosfecreg_Z) )
            {
               oWriter.WriteStartElement("modelosfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmodelos_Modelosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("modelosfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtmodelos_Modelosfecultact_Z) )
            {
               oWriter.WriteStartElement("modelosfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmodelos_Modelosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("modelosfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("modelosdsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosdsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("modelosfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmodelos_Modelosfecultact_N), 1, 0)));
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
         AddObjectProperty("modelosid", gxTv_Sdtmodelos_Modelosid, false);
         AddObjectProperty("modelosdsc", gxTv_Sdtmodelos_Modelosdsc, false);
         AddObjectProperty("modelosusuario", gxTv_Sdtmodelos_Modelosusuario, false);
         datetime_STZ = gxTv_Sdtmodelos_Modelosfecreg;
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
         AddObjectProperty("modelosfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtmodelos_Modelosfecultact;
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
         AddObjectProperty("modelosfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtmodelos_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtmodelos_Initialized, false);
            AddObjectProperty("modelosid_Z", gxTv_Sdtmodelos_Modelosid_Z, false);
            AddObjectProperty("modelosdsc_Z", gxTv_Sdtmodelos_Modelosdsc_Z, false);
            AddObjectProperty("modelosusuario_Z", gxTv_Sdtmodelos_Modelosusuario_Z, false);
            datetime_STZ = gxTv_Sdtmodelos_Modelosfecreg_Z;
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
            AddObjectProperty("modelosfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtmodelos_Modelosfecultact_Z;
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
            AddObjectProperty("modelosfecultact_Z", sDateCnv, false);
            AddObjectProperty("modelosdsc_N", gxTv_Sdtmodelos_Modelosdsc_N, false);
            AddObjectProperty("modelosusuario_N", gxTv_Sdtmodelos_Modelosusuario_N, false);
            AddObjectProperty("modelosfecreg_N", gxTv_Sdtmodelos_Modelosfecreg_N, false);
            AddObjectProperty("modelosfecultact_N", gxTv_Sdtmodelos_Modelosfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "modelosid" )]
      [  XmlElement( ElementName = "modelosid"   )]
      public int gxTpr_Modelosid
      {
         get {
            return gxTv_Sdtmodelos_Modelosid ;
         }

         set {
            if ( gxTv_Sdtmodelos_Modelosid != value )
            {
               gxTv_Sdtmodelos_Mode = "INS";
               this.gxTv_Sdtmodelos_Modelosid_Z_SetNull( );
               this.gxTv_Sdtmodelos_Modelosdsc_Z_SetNull( );
               this.gxTv_Sdtmodelos_Modelosusuario_Z_SetNull( );
               this.gxTv_Sdtmodelos_Modelosfecreg_Z_SetNull( );
               this.gxTv_Sdtmodelos_Modelosfecultact_Z_SetNull( );
            }
            gxTv_Sdtmodelos_Modelosid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "modelosdsc" )]
      [  XmlElement( ElementName = "modelosdsc"   )]
      public String gxTpr_Modelosdsc
      {
         get {
            return gxTv_Sdtmodelos_Modelosdsc ;
         }

         set {
            gxTv_Sdtmodelos_Modelosdsc_N = 0;
            gxTv_Sdtmodelos_Modelosdsc = (String)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosdsc_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosdsc_N = 1;
         gxTv_Sdtmodelos_Modelosdsc = "";
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosusuario" )]
      [  XmlElement( ElementName = "modelosusuario"   )]
      public String gxTpr_Modelosusuario
      {
         get {
            return gxTv_Sdtmodelos_Modelosusuario ;
         }

         set {
            gxTv_Sdtmodelos_Modelosusuario_N = 0;
            gxTv_Sdtmodelos_Modelosusuario = (String)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosusuario_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosusuario_N = 1;
         gxTv_Sdtmodelos_Modelosusuario = "";
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecreg" )]
      [  XmlElement( ElementName = "modelosfecreg"  , IsNullable=true )]
      public string gxTpr_Modelosfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtmodelos_Modelosfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmodelos_Modelosfecreg).value ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmodelos_Modelosfecreg = DateTime.MinValue;
            else
               gxTv_Sdtmodelos_Modelosfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Modelosfecreg
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecreg ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecreg_N = 0;
            gxTv_Sdtmodelos_Modelosfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecreg_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecreg_N = 1;
         gxTv_Sdtmodelos_Modelosfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecultact" )]
      [  XmlElement( ElementName = "modelosfecultact"  , IsNullable=true )]
      public string gxTpr_Modelosfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtmodelos_Modelosfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmodelos_Modelosfecultact).value ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmodelos_Modelosfecultact = DateTime.MinValue;
            else
               gxTv_Sdtmodelos_Modelosfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Modelosfecultact
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecultact ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecultact_N = 0;
            gxTv_Sdtmodelos_Modelosfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecultact_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecultact_N = 1;
         gxTv_Sdtmodelos_Modelosfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtmodelos_Mode ;
         }

         set {
            gxTv_Sdtmodelos_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtmodelos_Mode_SetNull( )
      {
         gxTv_Sdtmodelos_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtmodelos_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtmodelos_Initialized ;
         }

         set {
            gxTv_Sdtmodelos_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtmodelos_Initialized_SetNull( )
      {
         gxTv_Sdtmodelos_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosid_Z" )]
      [  XmlElement( ElementName = "modelosid_Z"   )]
      public int gxTpr_Modelosid_Z
      {
         get {
            return gxTv_Sdtmodelos_Modelosid_Z ;
         }

         set {
            gxTv_Sdtmodelos_Modelosid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosid_Z_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosdsc_Z" )]
      [  XmlElement( ElementName = "modelosdsc_Z"   )]
      public String gxTpr_Modelosdsc_Z
      {
         get {
            return gxTv_Sdtmodelos_Modelosdsc_Z ;
         }

         set {
            gxTv_Sdtmodelos_Modelosdsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosdsc_Z_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosdsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosusuario_Z" )]
      [  XmlElement( ElementName = "modelosusuario_Z"   )]
      public String gxTpr_Modelosusuario_Z
      {
         get {
            return gxTv_Sdtmodelos_Modelosusuario_Z ;
         }

         set {
            gxTv_Sdtmodelos_Modelosusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosusuario_Z_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecreg_Z" )]
      [  XmlElement( ElementName = "modelosfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Modelosfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtmodelos_Modelosfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmodelos_Modelosfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmodelos_Modelosfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtmodelos_Modelosfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Modelosfecreg_Z
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecreg_Z ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecreg_Z_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecultact_Z" )]
      [  XmlElement( ElementName = "modelosfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Modelosfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtmodelos_Modelosfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmodelos_Modelosfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmodelos_Modelosfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtmodelos_Modelosfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Modelosfecultact_Z
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecultact_Z ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecultact_Z_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosdsc_N" )]
      [  XmlElement( ElementName = "modelosdsc_N"   )]
      public short gxTpr_Modelosdsc_N
      {
         get {
            return gxTv_Sdtmodelos_Modelosdsc_N ;
         }

         set {
            gxTv_Sdtmodelos_Modelosdsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosdsc_N_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosdsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosusuario_N" )]
      [  XmlElement( ElementName = "modelosusuario_N"   )]
      public short gxTpr_Modelosusuario_N
      {
         get {
            return gxTv_Sdtmodelos_Modelosusuario_N ;
         }

         set {
            gxTv_Sdtmodelos_Modelosusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosusuario_N_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecreg_N" )]
      [  XmlElement( ElementName = "modelosfecreg_N"   )]
      public short gxTpr_Modelosfecreg_N
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecreg_N ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecreg_N_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "modelosfecultact_N" )]
      [  XmlElement( ElementName = "modelosfecultact_N"   )]
      public short gxTpr_Modelosfecultact_N
      {
         get {
            return gxTv_Sdtmodelos_Modelosfecultact_N ;
         }

         set {
            gxTv_Sdtmodelos_Modelosfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtmodelos_Modelosfecultact_N_SetNull( )
      {
         gxTv_Sdtmodelos_Modelosfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmodelos_Modelosfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtmodelos_Modelosdsc = "";
         gxTv_Sdtmodelos_Modelosusuario = "";
         gxTv_Sdtmodelos_Modelosfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Modelosfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Mode = "";
         gxTv_Sdtmodelos_Modelosdsc_Z = "";
         gxTv_Sdtmodelos_Modelosusuario_Z = "";
         gxTv_Sdtmodelos_Modelosfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmodelos_Modelosfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "modelos", "GeneXus.Programs.modelos_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtmodelos_Initialized ;
      private short gxTv_Sdtmodelos_Modelosdsc_N ;
      private short gxTv_Sdtmodelos_Modelosusuario_N ;
      private short gxTv_Sdtmodelos_Modelosfecreg_N ;
      private short gxTv_Sdtmodelos_Modelosfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtmodelos_Modelosid ;
      private int gxTv_Sdtmodelos_Modelosid_Z ;
      private String gxTv_Sdtmodelos_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtmodelos_Modelosfecreg ;
      private DateTime gxTv_Sdtmodelos_Modelosfecultact ;
      private DateTime gxTv_Sdtmodelos_Modelosfecreg_Z ;
      private DateTime gxTv_Sdtmodelos_Modelosfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtmodelos_Modelosdsc ;
      private String gxTv_Sdtmodelos_Modelosusuario ;
      private String gxTv_Sdtmodelos_Modelosdsc_Z ;
      private String gxTv_Sdtmodelos_Modelosusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"modelos", Namespace = "Condufef_v1")]
   public class Sdtmodelos_RESTInterface : GxGenericCollectionItem<Sdtmodelos>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtmodelos_RESTInterface( ) : base()
      {
      }

      public Sdtmodelos_RESTInterface( Sdtmodelos psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "modelosid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Modelosid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Modelosid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Modelosid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "modelosdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Modelosdsc
      {
         get {
            return sdt.gxTpr_Modelosdsc ;
         }

         set {
            sdt.gxTpr_Modelosdsc = (String)(value);
         }

      }

      [DataMember( Name = "modelosusuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Modelosusuario
      {
         get {
            return sdt.gxTpr_Modelosusuario ;
         }

         set {
            sdt.gxTpr_Modelosusuario = (String)(value);
         }

      }

      [DataMember( Name = "modelosfecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Modelosfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Modelosfecreg) ;
         }

         set {
            sdt.gxTpr_Modelosfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "modelosfecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Modelosfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Modelosfecultact) ;
         }

         set {
            sdt.gxTpr_Modelosfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtmodelos sdt
      {
         get {
            return (Sdtmodelos)Sdt ;
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
            sdt = new Sdtmodelos() ;
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
