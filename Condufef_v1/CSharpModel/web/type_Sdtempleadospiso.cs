/*
               File: type_Sdtempleadospiso
        Description: empleadospiso
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/5/2022 15:59:36.32
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
   [XmlRoot(ElementName = "empleadospiso" )]
   [XmlType(TypeName =  "empleadospiso" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtempleadospiso : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtempleadospiso( )
      {
         /* Constructor for serialization */
         gxTv_Sdtempleadospiso_Empleadospisoextpiso = "";
         gxTv_Sdtempleadospiso_Empleadospisoextext = "";
         gxTv_Sdtempleadospiso_Empleadospisoextcorreo = "";
         gxTv_Sdtempleadospiso_Empleadospisoextusuario = "";
         gxTv_Sdtempleadospiso_Empleadospisoextfecgre = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Empleadospisoextfeact = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Mode = "";
         gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextext_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = DateTime.MinValue;
      }

      public Sdtempleadospiso( IGxContext context )
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

      public void Load( int AV46empleadospisoextid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV46empleadospisoextid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"empleadospisoextid", typeof(int)}}) ;
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
         metadata.Set("Name", "empleadospiso");
         metadata.Set("BT", "empleadospiso");
         metadata.Set("PK", "[ \"empleadospisoextid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextpiso_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextext_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextcorreo_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadopisoextprofesion_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextfecgre_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadospisoextfeact_Z_Nullable" , attrs);
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
         Sdtempleadospiso deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtempleadospiso)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtempleadospiso obj ;
         obj = this;
         obj.gxTpr_Empleadospisoextid = deserialized.gxTpr_Empleadospisoextid;
         obj.gxTpr_Empleadospisoextpiso = deserialized.gxTpr_Empleadospisoextpiso;
         obj.gxTpr_Empleadospisoextext = deserialized.gxTpr_Empleadospisoextext;
         obj.gxTpr_Empleadospisoextcorreo = deserialized.gxTpr_Empleadospisoextcorreo;
         obj.gxTpr_Empleadopisoextprofesion = deserialized.gxTpr_Empleadopisoextprofesion;
         obj.gxTpr_Empleadospisoextusuario = deserialized.gxTpr_Empleadospisoextusuario;
         obj.gxTpr_Empleadospisoextfecgre = deserialized.gxTpr_Empleadospisoextfecgre;
         obj.gxTpr_Empleadospisoextfeact = deserialized.gxTpr_Empleadospisoextfeact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Empleadospisoextid_Z = deserialized.gxTpr_Empleadospisoextid_Z;
         obj.gxTpr_Empleadospisoextpiso_Z = deserialized.gxTpr_Empleadospisoextpiso_Z;
         obj.gxTpr_Empleadospisoextext_Z = deserialized.gxTpr_Empleadospisoextext_Z;
         obj.gxTpr_Empleadospisoextcorreo_Z = deserialized.gxTpr_Empleadospisoextcorreo_Z;
         obj.gxTpr_Empleadopisoextprofesion_Z = deserialized.gxTpr_Empleadopisoextprofesion_Z;
         obj.gxTpr_Empleadospisoextusuario_Z = deserialized.gxTpr_Empleadospisoextusuario_Z;
         obj.gxTpr_Empleadospisoextfecgre_Z = deserialized.gxTpr_Empleadospisoextfecgre_Z;
         obj.gxTpr_Empleadospisoextfeact_Z = deserialized.gxTpr_Empleadospisoextfeact_Z;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextid") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextpiso") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextpiso = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextext") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextext = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextcorreo") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextcorreo = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadopisoextprofesion") )
               {
                  gxTv_Sdtempleadospiso_Empleadopisoextprofesion = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextusuario") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextfecgre") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfecgre = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfecgre = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextfeact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfeact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfeact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtempleadospiso_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtempleadospiso_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextid_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextpiso_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextext_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextext_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextcorreo_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadopisoextprofesion_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z = (long)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextusuario_Z") )
               {
                  gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextfecgre_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadospisoextfeact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
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
            sName = "empleadospiso";
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
         oWriter.WriteElement("empleadospisoextid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleadospiso_Empleadospisoextid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadospisoextpiso", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextpiso));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadospisoextext", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextext));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadospisoextcorreo", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextcorreo));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadopisoextprofesion", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleadospiso_Empleadopisoextprofesion), 11, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadospisoextusuario", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtempleadospiso_Empleadospisoextfecgre) )
         {
            oWriter.WriteStartElement("empleadospisoextfecgre");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("empleadospisoextfecgre", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtempleadospiso_Empleadospisoextfeact) )
         {
            oWriter.WriteStartElement("empleadospisoextfeact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("empleadospisoextfeact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtempleadospiso_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleadospiso_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadospisoextid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleadospiso_Empleadospisoextid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadospisoextpiso_Z", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadospisoextext_Z", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextext_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadospisoextcorreo_Z", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadopisoextprofesion_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z), 11, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadospisoextusuario_Z", StringUtil.RTrim( gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z) )
            {
               oWriter.WriteStartElement("empleadospisoextfecgre_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("empleadospisoextfecgre_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z) )
            {
               oWriter.WriteStartElement("empleadospisoextfeact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("empleadospisoextfeact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
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
         AddObjectProperty("empleadospisoextid", gxTv_Sdtempleadospiso_Empleadospisoextid, false);
         AddObjectProperty("empleadospisoextpiso", gxTv_Sdtempleadospiso_Empleadospisoextpiso, false);
         AddObjectProperty("empleadospisoextext", gxTv_Sdtempleadospiso_Empleadospisoextext, false);
         AddObjectProperty("empleadospisoextcorreo", gxTv_Sdtempleadospiso_Empleadospisoextcorreo, false);
         AddObjectProperty("empleadopisoextprofesion", gxTv_Sdtempleadospiso_Empleadopisoextprofesion, false);
         AddObjectProperty("empleadospisoextusuario", gxTv_Sdtempleadospiso_Empleadospisoextusuario, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfecgre)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("empleadospisoextfecgre", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfeact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("empleadospisoextfeact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtempleadospiso_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtempleadospiso_Initialized, false);
            AddObjectProperty("empleadospisoextid_Z", gxTv_Sdtempleadospiso_Empleadospisoextid_Z, false);
            AddObjectProperty("empleadospisoextpiso_Z", gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z, false);
            AddObjectProperty("empleadospisoextext_Z", gxTv_Sdtempleadospiso_Empleadospisoextext_Z, false);
            AddObjectProperty("empleadospisoextcorreo_Z", gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z, false);
            AddObjectProperty("empleadopisoextprofesion_Z", gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z, false);
            AddObjectProperty("empleadospisoextusuario_Z", gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("empleadospisoextfecgre_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("empleadospisoextfeact_Z", sDateCnv, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "empleadospisoextid" )]
      [  XmlElement( ElementName = "empleadospisoextid"   )]
      public int gxTpr_Empleadospisoextid
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextid ;
         }

         set {
            if ( gxTv_Sdtempleadospiso_Empleadospisoextid != value )
            {
               gxTv_Sdtempleadospiso_Mode = "INS";
               this.gxTv_Sdtempleadospiso_Empleadospisoextid_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextext_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z_SetNull( );
               this.gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z_SetNull( );
            }
            gxTv_Sdtempleadospiso_Empleadospisoextid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextpiso" )]
      [  XmlElement( ElementName = "empleadospisoextpiso"   )]
      public String gxTpr_Empleadospisoextpiso
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextpiso ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextpiso = (String)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextext" )]
      [  XmlElement( ElementName = "empleadospisoextext"   )]
      public String gxTpr_Empleadospisoextext
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextext ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextext = (String)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextcorreo" )]
      [  XmlElement( ElementName = "empleadospisoextcorreo"   )]
      public String gxTpr_Empleadospisoextcorreo
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextcorreo ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextcorreo = (String)(value);
         }

      }

      [  SoapElement( ElementName = "empleadopisoextprofesion" )]
      [  XmlElement( ElementName = "empleadopisoextprofesion"   )]
      public long gxTpr_Empleadopisoextprofesion
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadopisoextprofesion ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadopisoextprofesion = (long)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextusuario" )]
      [  XmlElement( ElementName = "empleadospisoextusuario"   )]
      public String gxTpr_Empleadospisoextusuario
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextusuario ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextusuario = (String)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextfecgre" )]
      [  XmlElement( ElementName = "empleadospisoextfecgre"  , IsNullable=true )]
      public string gxTpr_Empleadospisoextfecgre_Nullable
      {
         get {
            if ( gxTv_Sdtempleadospiso_Empleadospisoextfecgre == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleadospiso_Empleadospisoextfecgre).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleadospiso_Empleadospisoextfecgre = DateTime.MinValue;
            else
               gxTv_Sdtempleadospiso_Empleadospisoextfecgre = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadospisoextfecgre
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextfecgre ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextfecgre = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "empleadospisoextfeact" )]
      [  XmlElement( ElementName = "empleadospisoextfeact"  , IsNullable=true )]
      public string gxTpr_Empleadospisoextfeact_Nullable
      {
         get {
            if ( gxTv_Sdtempleadospiso_Empleadospisoextfeact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleadospiso_Empleadospisoextfeact).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleadospiso_Empleadospisoextfeact = DateTime.MinValue;
            else
               gxTv_Sdtempleadospiso_Empleadospisoextfeact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadospisoextfeact
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextfeact ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextfeact = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtempleadospiso_Mode ;
         }

         set {
            gxTv_Sdtempleadospiso_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Mode_SetNull( )
      {
         gxTv_Sdtempleadospiso_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtempleadospiso_Initialized ;
         }

         set {
            gxTv_Sdtempleadospiso_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Initialized_SetNull( )
      {
         gxTv_Sdtempleadospiso_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextid_Z" )]
      [  XmlElement( ElementName = "empleadospisoextid_Z"   )]
      public int gxTpr_Empleadospisoextid_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextid_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextid_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextpiso_Z" )]
      [  XmlElement( ElementName = "empleadospisoextpiso_Z"   )]
      public String gxTpr_Empleadospisoextpiso_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextext_Z" )]
      [  XmlElement( ElementName = "empleadospisoextext_Z"   )]
      public String gxTpr_Empleadospisoextext_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextext_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextext_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextext_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextext_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextext_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextcorreo_Z" )]
      [  XmlElement( ElementName = "empleadospisoextcorreo_Z"   )]
      public String gxTpr_Empleadospisoextcorreo_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadopisoextprofesion_Z" )]
      [  XmlElement( ElementName = "empleadopisoextprofesion_Z"   )]
      public long gxTpr_Empleadopisoextprofesion_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z = (long)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextusuario_Z" )]
      [  XmlElement( ElementName = "empleadospisoextusuario_Z"   )]
      public String gxTpr_Empleadospisoextusuario_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextfecgre_Z" )]
      [  XmlElement( ElementName = "empleadospisoextfecgre_Z"  , IsNullable=true )]
      public string gxTpr_Empleadospisoextfecgre_Z_Nullable
      {
         get {
            if ( gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = DateTime.MinValue;
            else
               gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadospisoextfecgre_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadospisoextfeact_Z" )]
      [  XmlElement( ElementName = "empleadospisoextfeact_Z"  , IsNullable=true )]
      public string gxTpr_Empleadospisoextfeact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = DateTime.MinValue;
            else
               gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadospisoextfeact_Z
      {
         get {
            return gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z ;
         }

         set {
            gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z_SetNull( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtempleadospiso_Empleadospisoextpiso = "";
         gxTv_Sdtempleadospiso_Empleadospisoextext = "";
         gxTv_Sdtempleadospiso_Empleadospisoextcorreo = "";
         gxTv_Sdtempleadospiso_Empleadospisoextusuario = "";
         gxTv_Sdtempleadospiso_Empleadospisoextfecgre = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Empleadospisoextfeact = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Mode = "";
         gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextext_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z = "";
         gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z = DateTime.MinValue;
         gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "empleadospiso", "GeneXus.Programs.empleadospiso_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtempleadospiso_Initialized ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtempleadospiso_Empleadospisoextid ;
      private int gxTv_Sdtempleadospiso_Empleadospisoextid_Z ;
      private long gxTv_Sdtempleadospiso_Empleadopisoextprofesion ;
      private long gxTv_Sdtempleadospiso_Empleadopisoextprofesion_Z ;
      private String gxTv_Sdtempleadospiso_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtempleadospiso_Empleadospisoextfecgre ;
      private DateTime gxTv_Sdtempleadospiso_Empleadospisoextfeact ;
      private DateTime gxTv_Sdtempleadospiso_Empleadospisoextfecgre_Z ;
      private DateTime gxTv_Sdtempleadospiso_Empleadospisoextfeact_Z ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextpiso ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextext ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextcorreo ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextusuario ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextpiso_Z ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextext_Z ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextcorreo_Z ;
      private String gxTv_Sdtempleadospiso_Empleadospisoextusuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"empleadospiso", Namespace = "Condufef_v1")]
   public class Sdtempleadospiso_RESTInterface : GxGenericCollectionItem<Sdtempleadospiso>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtempleadospiso_RESTInterface( ) : base()
      {
      }

      public Sdtempleadospiso_RESTInterface( Sdtempleadospiso psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "empleadospisoextid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Empleadospisoextid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Empleadospisoextid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "empleadospisoextpiso" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextpiso
      {
         get {
            return sdt.gxTpr_Empleadospisoextpiso ;
         }

         set {
            sdt.gxTpr_Empleadospisoextpiso = (String)(value);
         }

      }

      [DataMember( Name = "empleadospisoextext" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextext
      {
         get {
            return sdt.gxTpr_Empleadospisoextext ;
         }

         set {
            sdt.gxTpr_Empleadospisoextext = (String)(value);
         }

      }

      [DataMember( Name = "empleadospisoextcorreo" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextcorreo
      {
         get {
            return sdt.gxTpr_Empleadospisoextcorreo ;
         }

         set {
            sdt.gxTpr_Empleadospisoextcorreo = (String)(value);
         }

      }

      [DataMember( Name = "empleadopisoextprofesion" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Empleadopisoextprofesion
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Empleadopisoextprofesion), 11, 0)) ;
         }

         set {
            sdt.gxTpr_Empleadopisoextprofesion = (long)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "empleadospisoextusuario" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextusuario
      {
         get {
            return sdt.gxTpr_Empleadospisoextusuario ;
         }

         set {
            sdt.gxTpr_Empleadospisoextusuario = (String)(value);
         }

      }

      [DataMember( Name = "empleadospisoextfecgre" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextfecgre
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Empleadospisoextfecgre) ;
         }

         set {
            sdt.gxTpr_Empleadospisoextfecgre = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "empleadospisoextfeact" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Empleadospisoextfeact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Empleadospisoextfeact) ;
         }

         set {
            sdt.gxTpr_Empleadospisoextfeact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      public Sdtempleadospiso sdt
      {
         get {
            return (Sdtempleadospiso)Sdt ;
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
            sdt = new Sdtempleadospiso() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 18 )]
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
