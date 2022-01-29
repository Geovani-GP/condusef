/*
               File: type_Sdtcategorias
        Description: categorias
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/29/2022 0:0:15.67
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
   [XmlRoot(ElementName = "categorias" )]
   [XmlType(TypeName =  "categorias" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtcategorias : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtcategorias( )
      {
         /* Constructor for serialization */
         gxTv_Sdtcategorias_Categoriasdsc = "";
         gxTv_Sdtcategorias_Categoriasusuario = "";
         gxTv_Sdtcategorias_Categoriasfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Categoriasfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Mode = "";
         gxTv_Sdtcategorias_Categoriasdsc_Z = "";
         gxTv_Sdtcategorias_Categoriasusuario_Z = "";
         gxTv_Sdtcategorias_Categoriasfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Categoriasfecultact_Z = (DateTime)(DateTime.MinValue);
      }

      public Sdtcategorias( IGxContext context )
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

      public void Load( int AV14categoriasid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV14categoriasid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"categoriasid", typeof(int)}}) ;
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
         metadata.Set("Name", "categorias");
         metadata.Set("BT", "CATEGORIAS");
         metadata.Set("PK", "[ \"categoriasid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Categoriasid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasdsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasdsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasfecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Categoriasfecultact_N" , attrs);
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
         Sdtcategorias deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtcategorias)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtcategorias obj ;
         obj = this;
         obj.gxTpr_Categoriasid = deserialized.gxTpr_Categoriasid;
         obj.gxTpr_Categoriasdsc = deserialized.gxTpr_Categoriasdsc;
         obj.gxTpr_Categoriasusuario = deserialized.gxTpr_Categoriasusuario;
         obj.gxTpr_Categoriasfecreg = deserialized.gxTpr_Categoriasfecreg;
         obj.gxTpr_Categoriasfecultact = deserialized.gxTpr_Categoriasfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Categoriasid_Z = deserialized.gxTpr_Categoriasid_Z;
         obj.gxTpr_Categoriasdsc_Z = deserialized.gxTpr_Categoriasdsc_Z;
         obj.gxTpr_Categoriasusuario_Z = deserialized.gxTpr_Categoriasusuario_Z;
         obj.gxTpr_Categoriasfecreg_Z = deserialized.gxTpr_Categoriasfecreg_Z;
         obj.gxTpr_Categoriasfecultact_Z = deserialized.gxTpr_Categoriasfecultact_Z;
         obj.gxTpr_Categoriasdsc_N = deserialized.gxTpr_Categoriasdsc_N;
         obj.gxTpr_Categoriasusuario_N = deserialized.gxTpr_Categoriasusuario_N;
         obj.gxTpr_Categoriasfecreg_N = deserialized.gxTpr_Categoriasfecreg_N;
         obj.gxTpr_Categoriasfecultact_N = deserialized.gxTpr_Categoriasfecultact_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasid") )
               {
                  gxTv_Sdtcategorias_Categoriasid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasdsc") )
               {
                  gxTv_Sdtcategorias_Categoriasdsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasusuario") )
               {
                  gxTv_Sdtcategorias_Categoriasusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcategorias_Categoriasfecreg = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcategorias_Categoriasfecreg = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcategorias_Categoriasfecultact = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcategorias_Categoriasfecultact = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtcategorias_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtcategorias_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasid_Z") )
               {
                  gxTv_Sdtcategorias_Categoriasid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasdsc_Z") )
               {
                  gxTv_Sdtcategorias_Categoriasdsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasusuario_Z") )
               {
                  gxTv_Sdtcategorias_Categoriasusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcategorias_Categoriasfecreg_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcategorias_Categoriasfecreg_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtcategorias_Categoriasfecultact_Z = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_Sdtcategorias_Categoriasfecultact_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasdsc_N") )
               {
                  gxTv_Sdtcategorias_Categoriasdsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasusuario_N") )
               {
                  gxTv_Sdtcategorias_Categoriasusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecreg_N") )
               {
                  gxTv_Sdtcategorias_Categoriasfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "categoriasfecultact_N") )
               {
                  gxTv_Sdtcategorias_Categoriasfecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "categorias";
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
         oWriter.WriteElement("categoriasid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("categoriasdsc", StringUtil.RTrim( gxTv_Sdtcategorias_Categoriasdsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("categoriasusuario", StringUtil.RTrim( gxTv_Sdtcategorias_Categoriasusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtcategorias_Categoriasfecreg) )
         {
            oWriter.WriteStartElement("categoriasfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcategorias_Categoriasfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("categoriasfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtcategorias_Categoriasfecultact) )
         {
            oWriter.WriteStartElement("categoriasfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcategorias_Categoriasfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("categoriasfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtcategorias_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasdsc_Z", StringUtil.RTrim( gxTv_Sdtcategorias_Categoriasdsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasusuario_Z", StringUtil.RTrim( gxTv_Sdtcategorias_Categoriasusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtcategorias_Categoriasfecreg_Z) )
            {
               oWriter.WriteStartElement("categoriasfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcategorias_Categoriasfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("categoriasfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtcategorias_Categoriasfecultact_Z) )
            {
               oWriter.WriteStartElement("categoriasfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "T";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + ":";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_Sdtcategorias_Categoriasfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("categoriasfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("categoriasdsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasdsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("categoriasfecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtcategorias_Categoriasfecultact_N), 1, 0)));
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
         AddObjectProperty("categoriasid", gxTv_Sdtcategorias_Categoriasid, false);
         AddObjectProperty("categoriasdsc", gxTv_Sdtcategorias_Categoriasdsc, false);
         AddObjectProperty("categoriasusuario", gxTv_Sdtcategorias_Categoriasusuario, false);
         datetime_STZ = gxTv_Sdtcategorias_Categoriasfecreg;
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
         AddObjectProperty("categoriasfecreg", sDateCnv, false);
         datetime_STZ = gxTv_Sdtcategorias_Categoriasfecultact;
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
         AddObjectProperty("categoriasfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtcategorias_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtcategorias_Initialized, false);
            AddObjectProperty("categoriasid_Z", gxTv_Sdtcategorias_Categoriasid_Z, false);
            AddObjectProperty("categoriasdsc_Z", gxTv_Sdtcategorias_Categoriasdsc_Z, false);
            AddObjectProperty("categoriasusuario_Z", gxTv_Sdtcategorias_Categoriasusuario_Z, false);
            datetime_STZ = gxTv_Sdtcategorias_Categoriasfecreg_Z;
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
            AddObjectProperty("categoriasfecreg_Z", sDateCnv, false);
            datetime_STZ = gxTv_Sdtcategorias_Categoriasfecultact_Z;
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
            AddObjectProperty("categoriasfecultact_Z", sDateCnv, false);
            AddObjectProperty("categoriasdsc_N", gxTv_Sdtcategorias_Categoriasdsc_N, false);
            AddObjectProperty("categoriasusuario_N", gxTv_Sdtcategorias_Categoriasusuario_N, false);
            AddObjectProperty("categoriasfecreg_N", gxTv_Sdtcategorias_Categoriasfecreg_N, false);
            AddObjectProperty("categoriasfecultact_N", gxTv_Sdtcategorias_Categoriasfecultact_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "categoriasid" )]
      [  XmlElement( ElementName = "categoriasid"   )]
      public int gxTpr_Categoriasid
      {
         get {
            return gxTv_Sdtcategorias_Categoriasid ;
         }

         set {
            if ( gxTv_Sdtcategorias_Categoriasid != value )
            {
               gxTv_Sdtcategorias_Mode = "INS";
               this.gxTv_Sdtcategorias_Categoriasid_Z_SetNull( );
               this.gxTv_Sdtcategorias_Categoriasdsc_Z_SetNull( );
               this.gxTv_Sdtcategorias_Categoriasusuario_Z_SetNull( );
               this.gxTv_Sdtcategorias_Categoriasfecreg_Z_SetNull( );
               this.gxTv_Sdtcategorias_Categoriasfecultact_Z_SetNull( );
            }
            gxTv_Sdtcategorias_Categoriasid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "categoriasdsc" )]
      [  XmlElement( ElementName = "categoriasdsc"   )]
      public String gxTpr_Categoriasdsc
      {
         get {
            return gxTv_Sdtcategorias_Categoriasdsc ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasdsc_N = 0;
            gxTv_Sdtcategorias_Categoriasdsc = (String)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasdsc_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasdsc_N = 1;
         gxTv_Sdtcategorias_Categoriasdsc = "";
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasusuario" )]
      [  XmlElement( ElementName = "categoriasusuario"   )]
      public String gxTpr_Categoriasusuario
      {
         get {
            return gxTv_Sdtcategorias_Categoriasusuario ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasusuario_N = 0;
            gxTv_Sdtcategorias_Categoriasusuario = (String)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasusuario_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasusuario_N = 1;
         gxTv_Sdtcategorias_Categoriasusuario = "";
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecreg" )]
      [  XmlElement( ElementName = "categoriasfecreg"  , IsNullable=true )]
      public string gxTpr_Categoriasfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtcategorias_Categoriasfecreg == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcategorias_Categoriasfecreg).value ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecreg_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcategorias_Categoriasfecreg = DateTime.MinValue;
            else
               gxTv_Sdtcategorias_Categoriasfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Categoriasfecreg
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecreg ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecreg_N = 0;
            gxTv_Sdtcategorias_Categoriasfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecreg_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecreg_N = 1;
         gxTv_Sdtcategorias_Categoriasfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecultact" )]
      [  XmlElement( ElementName = "categoriasfecultact"  , IsNullable=true )]
      public string gxTpr_Categoriasfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtcategorias_Categoriasfecultact == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcategorias_Categoriasfecultact).value ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecultact_N = 0;
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcategorias_Categoriasfecultact = DateTime.MinValue;
            else
               gxTv_Sdtcategorias_Categoriasfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Categoriasfecultact
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecultact ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecultact_N = 0;
            gxTv_Sdtcategorias_Categoriasfecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecultact_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecultact_N = 1;
         gxTv_Sdtcategorias_Categoriasfecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtcategorias_Mode ;
         }

         set {
            gxTv_Sdtcategorias_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtcategorias_Mode_SetNull( )
      {
         gxTv_Sdtcategorias_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtcategorias_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtcategorias_Initialized ;
         }

         set {
            gxTv_Sdtcategorias_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtcategorias_Initialized_SetNull( )
      {
         gxTv_Sdtcategorias_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasid_Z" )]
      [  XmlElement( ElementName = "categoriasid_Z"   )]
      public int gxTpr_Categoriasid_Z
      {
         get {
            return gxTv_Sdtcategorias_Categoriasid_Z ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasid_Z_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasdsc_Z" )]
      [  XmlElement( ElementName = "categoriasdsc_Z"   )]
      public String gxTpr_Categoriasdsc_Z
      {
         get {
            return gxTv_Sdtcategorias_Categoriasdsc_Z ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasdsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasdsc_Z_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasdsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasusuario_Z" )]
      [  XmlElement( ElementName = "categoriasusuario_Z"   )]
      public String gxTpr_Categoriasusuario_Z
      {
         get {
            return gxTv_Sdtcategorias_Categoriasusuario_Z ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasusuario_Z_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecreg_Z" )]
      [  XmlElement( ElementName = "categoriasfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Categoriasfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtcategorias_Categoriasfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcategorias_Categoriasfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcategorias_Categoriasfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtcategorias_Categoriasfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Categoriasfecreg_Z
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecreg_Z ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecreg_Z_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecultact_Z" )]
      [  XmlElement( ElementName = "categoriasfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Categoriasfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtcategorias_Categoriasfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtcategorias_Categoriasfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_Sdtcategorias_Categoriasfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtcategorias_Categoriasfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Categoriasfecultact_Z
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecultact_Z ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecultact_Z_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasdsc_N" )]
      [  XmlElement( ElementName = "categoriasdsc_N"   )]
      public short gxTpr_Categoriasdsc_N
      {
         get {
            return gxTv_Sdtcategorias_Categoriasdsc_N ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasdsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasdsc_N_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasdsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasusuario_N" )]
      [  XmlElement( ElementName = "categoriasusuario_N"   )]
      public short gxTpr_Categoriasusuario_N
      {
         get {
            return gxTv_Sdtcategorias_Categoriasusuario_N ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasusuario_N_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecreg_N" )]
      [  XmlElement( ElementName = "categoriasfecreg_N"   )]
      public short gxTpr_Categoriasfecreg_N
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecreg_N ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecreg_N_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "categoriasfecultact_N" )]
      [  XmlElement( ElementName = "categoriasfecultact_N"   )]
      public short gxTpr_Categoriasfecultact_N
      {
         get {
            return gxTv_Sdtcategorias_Categoriasfecultact_N ;
         }

         set {
            gxTv_Sdtcategorias_Categoriasfecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtcategorias_Categoriasfecultact_N_SetNull( )
      {
         gxTv_Sdtcategorias_Categoriasfecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtcategorias_Categoriasfecultact_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtcategorias_Categoriasdsc = "";
         gxTv_Sdtcategorias_Categoriasusuario = "";
         gxTv_Sdtcategorias_Categoriasfecreg = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Categoriasfecultact = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Mode = "";
         gxTv_Sdtcategorias_Categoriasdsc_Z = "";
         gxTv_Sdtcategorias_Categoriasusuario_Z = "";
         gxTv_Sdtcategorias_Categoriasfecreg_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtcategorias_Categoriasfecultact_Z = (DateTime)(DateTime.MinValue);
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "categorias", "GeneXus.Programs.categorias_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtcategorias_Initialized ;
      private short gxTv_Sdtcategorias_Categoriasdsc_N ;
      private short gxTv_Sdtcategorias_Categoriasusuario_N ;
      private short gxTv_Sdtcategorias_Categoriasfecreg_N ;
      private short gxTv_Sdtcategorias_Categoriasfecultact_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtcategorias_Categoriasid ;
      private int gxTv_Sdtcategorias_Categoriasid_Z ;
      private String gxTv_Sdtcategorias_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtcategorias_Categoriasfecreg ;
      private DateTime gxTv_Sdtcategorias_Categoriasfecultact ;
      private DateTime gxTv_Sdtcategorias_Categoriasfecreg_Z ;
      private DateTime gxTv_Sdtcategorias_Categoriasfecultact_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_Sdtcategorias_Categoriasdsc ;
      private String gxTv_Sdtcategorias_Categoriasusuario ;
      private String gxTv_Sdtcategorias_Categoriasdsc_Z ;
      private String gxTv_Sdtcategorias_Categoriasusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"categorias", Namespace = "Condufef_v1")]
   public class Sdtcategorias_RESTInterface : GxGenericCollectionItem<Sdtcategorias>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtcategorias_RESTInterface( ) : base()
      {
      }

      public Sdtcategorias_RESTInterface( Sdtcategorias psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "categoriasid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Categoriasid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Categoriasid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Categoriasid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "categoriasdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Categoriasdsc
      {
         get {
            return sdt.gxTpr_Categoriasdsc ;
         }

         set {
            sdt.gxTpr_Categoriasdsc = (String)(value);
         }

      }

      [DataMember( Name = "categoriasusuario" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Categoriasusuario
      {
         get {
            return sdt.gxTpr_Categoriasusuario ;
         }

         set {
            sdt.gxTpr_Categoriasusuario = (String)(value);
         }

      }

      [DataMember( Name = "categoriasfecreg" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Categoriasfecreg
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Categoriasfecreg) ;
         }

         set {
            sdt.gxTpr_Categoriasfecreg = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "categoriasfecultact" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Categoriasfecultact
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Categoriasfecultact) ;
         }

         set {
            sdt.gxTpr_Categoriasfecultact = DateTimeUtil.CToT2( (String)(value));
         }

      }

      public Sdtcategorias sdt
      {
         get {
            return (Sdtcategorias)Sdt ;
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
            sdt = new Sdtcategorias() ;
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
