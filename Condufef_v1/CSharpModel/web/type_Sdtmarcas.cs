/*
               File: type_Sdtmarcas
        Description: marcas
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:49:1.9
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
   [XmlRoot(ElementName = "marcas" )]
   [XmlType(TypeName =  "marcas" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtmarcas : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtmarcas( )
      {
         /* Constructor for serialization */
         gxTv_Sdtmarcas_Marcasdsc = "";
         gxTv_Sdtmarcas_Marcasusuario = "";
         gxTv_Sdtmarcas_Marcasfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Marcasfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Mode = "";
         gxTv_Sdtmarcas_Marcasdsc_Z = "";
         gxTv_Sdtmarcas_Marcasusuario_Z = "";
         gxTv_Sdtmarcas_Marcasfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Marcasfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtmarcas( IGxContext context )
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

      public void Load( int AV24marcasid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV24marcasid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"marcasid", typeof(int)}}) ;
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
         metadata.Set("Name", "marcas");
         metadata.Set("BT", "MARCAS");
         metadata.Set("PK", "[ \"marcasid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Marcasid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasdsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasdsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Marcasfecultact_N" , attrs);
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
         Sdtmarcas deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtmarcas)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtmarcas obj ;
         obj = this;
         obj.gxTpr_Marcasid = deserialized.gxTpr_Marcasid;
         obj.gxTpr_Marcasdsc = deserialized.gxTpr_Marcasdsc;
         obj.gxTpr_Marcasusuario = deserialized.gxTpr_Marcasusuario;
         obj.gxTpr_Marcasfecreg = deserialized.gxTpr_Marcasfecreg;
         obj.gxTpr_Marcasfecultact = deserialized.gxTpr_Marcasfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Marcasid_Z = deserialized.gxTpr_Marcasid_Z;
         obj.gxTpr_Marcasdsc_Z = deserialized.gxTpr_Marcasdsc_Z;
         obj.gxTpr_Marcasusuario_Z = deserialized.gxTpr_Marcasusuario_Z;
         obj.gxTpr_Marcasfecreg_Z = deserialized.gxTpr_Marcasfecreg_Z;
         obj.gxTpr_Marcasfecultact_Z = deserialized.gxTpr_Marcasfecultact_Z;
         obj.gxTpr_Marcasdsc_N = deserialized.gxTpr_Marcasdsc_N;
         obj.gxTpr_Marcasusuario_N = deserialized.gxTpr_Marcasusuario_N;
         obj.gxTpr_Marcasfecreg_N = deserialized.gxTpr_Marcasfecreg_N;
         obj.gxTpr_Marcasfecultact_N = deserialized.gxTpr_Marcasfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasid") )
               {
                  gxTv_Sdtmarcas_Marcasid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasdsc") )
               {
                  gxTv_Sdtmarcas_Marcasdsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasusuario") )
               {
                  gxTv_Sdtmarcas_Marcasusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmarcas_Marcasfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmarcas_Marcasfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmarcas_Marcasfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmarcas_Marcasfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtmarcas_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtmarcas_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasid_Z") )
               {
                  gxTv_Sdtmarcas_Marcasid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasdsc_Z") )
               {
                  gxTv_Sdtmarcas_Marcasdsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasusuario_Z") )
               {
                  gxTv_Sdtmarcas_Marcasusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmarcas_Marcasfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmarcas_Marcasfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtmarcas_Marcasfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtmarcas_Marcasfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasdsc_N") )
               {
                  gxTv_Sdtmarcas_Marcasdsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasusuario_N") )
               {
                  gxTv_Sdtmarcas_Marcasusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecreg_N") )
               {
                  gxTv_Sdtmarcas_Marcasfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "marcasfecultact_N") )
               {
                  gxTv_Sdtmarcas_Marcasfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "marcas";
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
         oWriter.WriteElement("marcasid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("marcasdsc", StringUtil.RTrim( gxTv_Sdtmarcas_Marcasdsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("marcasusuario", StringUtil.RTrim( gxTv_Sdtmarcas_Marcasusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtmarcas_Marcasfecreg) )
         {
            oWriter.WriteStartElement("marcasfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmarcas_Marcasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("marcasfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtmarcas_Marcasfecultact) )
         {
            oWriter.WriteStartElement("marcasfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmarcas_Marcasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("marcasfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtmarcas_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasdsc_Z", StringUtil.RTrim( gxTv_Sdtmarcas_Marcasdsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasusuario_Z", StringUtil.RTrim( gxTv_Sdtmarcas_Marcasusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtmarcas_Marcasfecreg_Z) )
            {
               oWriter.WriteStartElement("marcasfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmarcas_Marcasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("marcasfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtmarcas_Marcasfecultact_Z) )
            {
               oWriter.WriteStartElement("marcasfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtmarcas_Marcasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("marcasfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("marcasdsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasdsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("marcasfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtmarcas_Marcasfecultact_N), 1, 0)));
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
         AddObjectProperty("marcasid", gxTv_Sdtmarcas_Marcasid, false);
         AddObjectProperty("marcasdsc", gxTv_Sdtmarcas_Marcasdsc, false);
         AddObjectProperty("marcasusuario", gxTv_Sdtmarcas_Marcasusuario, false);
         datetime_STZ = gxTv_Sdtmarcas_Marcasfecreg;
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
         AddObjectProperty("marcasfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtmarcas_Marcasfecultact;
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
         AddObjectProperty("marcasfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtmarcas_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtmarcas_Initialized, false);
            AddObjectProperty("marcasid_Z", gxTv_Sdtmarcas_Marcasid_Z, false);
            AddObjectProperty("marcasdsc_Z", gxTv_Sdtmarcas_Marcasdsc_Z, false);
            AddObjectProperty("marcasusuario_Z", gxTv_Sdtmarcas_Marcasusuario_Z, false);
            datetime_STZ = gxTv_Sdtmarcas_Marcasfecreg_Z;
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
            AddObjectProperty("marcasfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtmarcas_Marcasfecultact_Z;
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
            AddObjectProperty("marcasfecultact_Z", sDateCnv, false);
            AddObjectProperty("marcasdsc_N", gxTv_Sdtmarcas_Marcasdsc_N, false);
            AddObjectProperty("marcasusuario_N", gxTv_Sdtmarcas_Marcasusuario_N, false);
            AddObjectProperty("marcasfecreg_N", gxTv_Sdtmarcas_Marcasfecreg_N, false);
            AddObjectProperty("marcasfecultact_N", gxTv_Sdtmarcas_Marcasfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "marcasid" )]
      [  XmlElement( ElementName = "marcasid"   )]
      public int gxTpr_Marcasid
      {
         get {
            return gxTv_Sdtmarcas_Marcasid ;
         }

         set {
            if ( gxTv_Sdtmarcas_Marcasid != value )
            {
               gxTv_Sdtmarcas_Mode = "INS";
               this.gxTv_Sdtmarcas_Marcasid_Z_SetNull( );
               this.gxTv_Sdtmarcas_Marcasdsc_Z_SetNull( );
               this.gxTv_Sdtmarcas_Marcasusuario_Z_SetNull( );
               this.gxTv_Sdtmarcas_Marcasfecreg_Z_SetNull( );
               this.gxTv_Sdtmarcas_Marcasfecultact_Z_SetNull( );
            }
            gxTv_Sdtmarcas_Marcasid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "marcasdsc" )]
      [  XmlElement( ElementName = "marcasdsc"   )]
      public String gxTpr_Marcasdsc
      {
         get {
            return gxTv_Sdtmarcas_Marcasdsc ;
         }

         set {
            gxTv_Sdtmarcas_Marcasdsc_N = 0;
            gxTv_Sdtmarcas_Marcasdsc = (String)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasdsc_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasdsc_N = 1;
         gxTv_Sdtmarcas_Marcasdsc = "";
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasusuario" )]
      [  XmlElement( ElementName = "marcasusuario"   )]
      public String gxTpr_Marcasusuario
      {
         get {
            return gxTv_Sdtmarcas_Marcasusuario ;
         }

         set {
            gxTv_Sdtmarcas_Marcasusuario_N = 0;
            gxTv_Sdtmarcas_Marcasusuario = (String)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasusuario_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasusuario_N = 1;
         gxTv_Sdtmarcas_Marcasusuario = "";
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecreg" )]
      [  XmlElement( ElementName = "marcasfecreg"  , IsNullable=true )]
      public string gxTpr_Marcasfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtmarcas_Marcasfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmarcas_Marcasfecreg).value ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmarcas_Marcasfecreg = DateTime.MinValue;
            else
               gxTv_Sdtmarcas_Marcasfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Marcasfecreg
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecreg ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecreg_N = 0;
            gxTv_Sdtmarcas_Marcasfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecreg_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecreg_N = 1;
         gxTv_Sdtmarcas_Marcasfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecultact" )]
      [  XmlElement( ElementName = "marcasfecultact"  , IsNullable=true )]
      public string gxTpr_Marcasfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtmarcas_Marcasfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmarcas_Marcasfecultact).value ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmarcas_Marcasfecultact = DateTime.MinValue;
            else
               gxTv_Sdtmarcas_Marcasfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Marcasfecultact
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecultact ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecultact_N = 0;
            gxTv_Sdtmarcas_Marcasfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecultact_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecultact_N = 1;
         gxTv_Sdtmarcas_Marcasfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtmarcas_Mode ;
         }

         set {
            gxTv_Sdtmarcas_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtmarcas_Mode_SetNull( )
      {
         gxTv_Sdtmarcas_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtmarcas_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtmarcas_Initialized ;
         }

         set {
            gxTv_Sdtmarcas_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtmarcas_Initialized_SetNull( )
      {
         gxTv_Sdtmarcas_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasid_Z" )]
      [  XmlElement( ElementName = "marcasid_Z"   )]
      public int gxTpr_Marcasid_Z
      {
         get {
            return gxTv_Sdtmarcas_Marcasid_Z ;
         }

         set {
            gxTv_Sdtmarcas_Marcasid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasid_Z_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasdsc_Z" )]
      [  XmlElement( ElementName = "marcasdsc_Z"   )]
      public String gxTpr_Marcasdsc_Z
      {
         get {
            return gxTv_Sdtmarcas_Marcasdsc_Z ;
         }

         set {
            gxTv_Sdtmarcas_Marcasdsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasdsc_Z_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasdsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasusuario_Z" )]
      [  XmlElement( ElementName = "marcasusuario_Z"   )]
      public String gxTpr_Marcasusuario_Z
      {
         get {
            return gxTv_Sdtmarcas_Marcasusuario_Z ;
         }

         set {
            gxTv_Sdtmarcas_Marcasusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasusuario_Z_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecreg_Z" )]
      [  XmlElement( ElementName = "marcasfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Marcasfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtmarcas_Marcasfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmarcas_Marcasfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmarcas_Marcasfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtmarcas_Marcasfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Marcasfecreg_Z
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecreg_Z ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecreg_Z_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecultact_Z" )]
      [  XmlElement( ElementName = "marcasfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Marcasfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtmarcas_Marcasfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtmarcas_Marcasfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtmarcas_Marcasfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtmarcas_Marcasfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Marcasfecultact_Z
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecultact_Z ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecultact_Z_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasdsc_N" )]
      [  XmlElement( ElementName = "marcasdsc_N"   )]
      public short gxTpr_Marcasdsc_N
      {
         get {
            return gxTv_Sdtmarcas_Marcasdsc_N ;
         }

         set {
            gxTv_Sdtmarcas_Marcasdsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasdsc_N_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasdsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasusuario_N" )]
      [  XmlElement( ElementName = "marcasusuario_N"   )]
      public short gxTpr_Marcasusuario_N
      {
         get {
            return gxTv_Sdtmarcas_Marcasusuario_N ;
         }

         set {
            gxTv_Sdtmarcas_Marcasusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasusuario_N_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecreg_N" )]
      [  XmlElement( ElementName = "marcasfecreg_N"   )]
      public short gxTpr_Marcasfecreg_N
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecreg_N ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecreg_N_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "marcasfecultact_N" )]
      [  XmlElement( ElementName = "marcasfecultact_N"   )]
      public short gxTpr_Marcasfecultact_N
      {
         get {
            return gxTv_Sdtmarcas_Marcasfecultact_N ;
         }

         set {
            gxTv_Sdtmarcas_Marcasfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtmarcas_Marcasfecultact_N_SetNull( )
      {
         gxTv_Sdtmarcas_Marcasfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtmarcas_Marcasfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtmarcas_Marcasdsc = "";
         gxTv_Sdtmarcas_Marcasusuario = "";
         gxTv_Sdtmarcas_Marcasfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Marcasfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Mode = "";
         gxTv_Sdtmarcas_Marcasdsc_Z = "";
         gxTv_Sdtmarcas_Marcasusuario_Z = "";
         gxTv_Sdtmarcas_Marcasfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtmarcas_Marcasfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "marcas", "GeneXus.Programs.marcas_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtmarcas_Initialized ;
      private short gxTv_Sdtmarcas_Marcasdsc_N ;
      private short gxTv_Sdtmarcas_Marcasusuario_N ;
      private short gxTv_Sdtmarcas_Marcasfecreg_N ;
      private short gxTv_Sdtmarcas_Marcasfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtmarcas_Marcasid ;
      private int gxTv_Sdtmarcas_Marcasid_Z ;
      private String gxTv_Sdtmarcas_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtmarcas_Marcasfecreg ;
      private DateTime gxTv_Sdtmarcas_Marcasfecultact ;
      private DateTime gxTv_Sdtmarcas_Marcasfecreg_Z ;
      private DateTime gxTv_Sdtmarcas_Marcasfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtmarcas_Marcasdsc ;
      private String gxTv_Sdtmarcas_Marcasusuario ;
      private String gxTv_Sdtmarcas_Marcasdsc_Z ;
      private String gxTv_Sdtmarcas_Marcasusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"marcas", Namespace = "Condufef_v1")]
   public class Sdtmarcas_RESTInterface : GxGenericCollectionItem<Sdtmarcas>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtmarcas_RESTInterface( ) : base()
      {
      }

      public Sdtmarcas_RESTInterface( Sdtmarcas psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "marcasid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Marcasid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Marcasid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Marcasid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "marcasdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Marcasdsc
      {
         get {
            return sdt.gxTpr_Marcasdsc ;
         }

         set {
            sdt.gxTpr_Marcasdsc = (String)(value);
         }

      }

      [DataMember( Name = "marcasusuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Marcasusuario
      {
         get {
            return sdt.gxTpr_Marcasusuario ;
         }

         set {
            sdt.gxTpr_Marcasusuario = (String)(value);
         }

      }

      [DataMember( Name = "marcasfecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Marcasfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Marcasfecreg) ;
         }

         set {
            sdt.gxTpr_Marcasfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "marcasfecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Marcasfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Marcasfecultact) ;
         }

         set {
            sdt.gxTpr_Marcasfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtmarcas sdt
      {
         get {
            return (Sdtmarcas)Sdt ;
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
            sdt = new Sdtmarcas() ;
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
