/*
               File: type_Sdtproducto
        Description: producto
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:19:8.23
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
   [XmlRoot(ElementName = "producto" )]
   [XmlType(TypeName =  "producto" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtproducto : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproducto( )
      {
         /* Constructor for serialization */
         gxTv_Sdtproducto_Productodsc = "";
         gxTv_Sdtproducto_Productousuario = "";
         gxTv_Sdtproducto_Productofecreg = DateTime.MinValue;
         gxTv_Sdtproducto_Productofecultact = DateTime.MinValue;
         gxTv_Sdtproducto_Mode = "";
         gxTv_Sdtproducto_Productodsc_Z = "";
         gxTv_Sdtproducto_Productousuario_Z = "";
         gxTv_Sdtproducto_Productofecreg_Z = DateTime.MinValue;
         gxTv_Sdtproducto_Productofecultact_Z = DateTime.MinValue;
      }

      public Sdtproducto( IGxContext context )
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

      public void Load( int AV175productoid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV175productoid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"productoid", typeof(int)}}) ;
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
         metadata.Set("Name", "producto");
         metadata.Set("BT", "PRODUCTO");
         metadata.Set("PK", "[ \"productoid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Productoid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pcambsid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productodsc_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pmodeloid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pmarcaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pcategoriaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productousuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Ptipobienid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pcambsid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productodsc_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pmodeloid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pmarcaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Pcategoriaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productousuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecreg_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Productofecultact_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Ptipobienid_N" , attrs);
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
         Sdtproducto deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtproducto)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtproducto obj ;
         obj = this;
         obj.gxTpr_Productoid = deserialized.gxTpr_Productoid;
         obj.gxTpr_Pcambsid = deserialized.gxTpr_Pcambsid;
         obj.gxTpr_Productodsc = deserialized.gxTpr_Productodsc;
         obj.gxTpr_Pmodeloid = deserialized.gxTpr_Pmodeloid;
         obj.gxTpr_Pmarcaid = deserialized.gxTpr_Pmarcaid;
         obj.gxTpr_Pcategoriaid = deserialized.gxTpr_Pcategoriaid;
         obj.gxTpr_Productousuario = deserialized.gxTpr_Productousuario;
         obj.gxTpr_Productofecreg = deserialized.gxTpr_Productofecreg;
         obj.gxTpr_Productofecultact = deserialized.gxTpr_Productofecultact;
         obj.gxTpr_Ptipobienid = deserialized.gxTpr_Ptipobienid;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Productoid_Z = deserialized.gxTpr_Productoid_Z;
         obj.gxTpr_Pcambsid_Z = deserialized.gxTpr_Pcambsid_Z;
         obj.gxTpr_Productodsc_Z = deserialized.gxTpr_Productodsc_Z;
         obj.gxTpr_Pmodeloid_Z = deserialized.gxTpr_Pmodeloid_Z;
         obj.gxTpr_Pmarcaid_Z = deserialized.gxTpr_Pmarcaid_Z;
         obj.gxTpr_Pcategoriaid_Z = deserialized.gxTpr_Pcategoriaid_Z;
         obj.gxTpr_Productousuario_Z = deserialized.gxTpr_Productousuario_Z;
         obj.gxTpr_Productofecreg_Z = deserialized.gxTpr_Productofecreg_Z;
         obj.gxTpr_Productofecultact_Z = deserialized.gxTpr_Productofecultact_Z;
         obj.gxTpr_Ptipobienid_Z = deserialized.gxTpr_Ptipobienid_Z;
         obj.gxTpr_Pcambsid_N = deserialized.gxTpr_Pcambsid_N;
         obj.gxTpr_Productodsc_N = deserialized.gxTpr_Productodsc_N;
         obj.gxTpr_Pmodeloid_N = deserialized.gxTpr_Pmodeloid_N;
         obj.gxTpr_Pmarcaid_N = deserialized.gxTpr_Pmarcaid_N;
         obj.gxTpr_Pcategoriaid_N = deserialized.gxTpr_Pcategoriaid_N;
         obj.gxTpr_Productousuario_N = deserialized.gxTpr_Productousuario_N;
         obj.gxTpr_Productofecreg_N = deserialized.gxTpr_Productofecreg_N;
         obj.gxTpr_Productofecultact_N = deserialized.gxTpr_Productofecultact_N;
         obj.gxTpr_Ptipobienid_N = deserialized.gxTpr_Ptipobienid_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "productoid") )
               {
                  gxTv_Sdtproducto_Productoid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcambsid") )
               {
                  gxTv_Sdtproducto_Pcambsid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc") )
               {
                  gxTv_Sdtproducto_Productodsc = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmodeloid") )
               {
                  gxTv_Sdtproducto_Pmodeloid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmarcaid") )
               {
                  gxTv_Sdtproducto_Pmarcaid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcategoriaid") )
               {
                  gxTv_Sdtproducto_Pcategoriaid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario") )
               {
                  gxTv_Sdtproducto_Productousuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecreg = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecreg = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecultact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecultact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ptipobienid") )
               {
                  gxTv_Sdtproducto_Ptipobienid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtproducto_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtproducto_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productoid_Z") )
               {
                  gxTv_Sdtproducto_Productoid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcambsid_Z") )
               {
                  gxTv_Sdtproducto_Pcambsid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc_Z") )
               {
                  gxTv_Sdtproducto_Productodsc_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmodeloid_Z") )
               {
                  gxTv_Sdtproducto_Pmodeloid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmarcaid_Z") )
               {
                  gxTv_Sdtproducto_Pmarcaid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcategoriaid_Z") )
               {
                  gxTv_Sdtproducto_Pcategoriaid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario_Z") )
               {
                  gxTv_Sdtproducto_Productousuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecreg_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecreg_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtproducto_Productofecultact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtproducto_Productofecultact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ptipobienid_Z") )
               {
                  gxTv_Sdtproducto_Ptipobienid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcambsid_N") )
               {
                  gxTv_Sdtproducto_Pcambsid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productodsc_N") )
               {
                  gxTv_Sdtproducto_Productodsc_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmodeloid_N") )
               {
                  gxTv_Sdtproducto_Pmodeloid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pmarcaid_N") )
               {
                  gxTv_Sdtproducto_Pmarcaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pcategoriaid_N") )
               {
                  gxTv_Sdtproducto_Pcategoriaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productousuario_N") )
               {
                  gxTv_Sdtproducto_Productousuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecreg_N") )
               {
                  gxTv_Sdtproducto_Productofecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "productofecultact_N") )
               {
                  gxTv_Sdtproducto_Productofecultact_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ptipobienid_N") )
               {
                  gxTv_Sdtproducto_Ptipobienid_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "producto";
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
         oWriter.WriteElement("productoid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productoid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("pcambsid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcambsid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("productodsc", StringUtil.RTrim( gxTv_Sdtproducto_Productodsc));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("pmodeloid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmodeloid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("pmarcaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmarcaid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("pcategoriaid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcategoriaid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("productousuario", StringUtil.RTrim( gxTv_Sdtproducto_Productousuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecreg) )
         {
            oWriter.WriteStartElement("productofecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("productofecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecultact) )
         {
            oWriter.WriteStartElement("productofecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("productofecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         oWriter.WriteElement("ptipobienid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Ptipobienid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtproducto_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productoid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productoid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pcambsid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcambsid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productodsc_Z", StringUtil.RTrim( gxTv_Sdtproducto_Productodsc_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pmodeloid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmodeloid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pmarcaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmarcaid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pcategoriaid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcategoriaid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productousuario_Z", StringUtil.RTrim( gxTv_Sdtproducto_Productousuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecreg_Z) )
            {
               oWriter.WriteStartElement("productofecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("productofecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtproducto_Productofecultact_Z) )
            {
               oWriter.WriteStartElement("productofecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("productofecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("ptipobienid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Ptipobienid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pcambsid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcambsid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productodsc_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productodsc_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pmodeloid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmodeloid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pmarcaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pmarcaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("pcategoriaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Pcategoriaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productousuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productousuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productofecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productofecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("productofecultact_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Productofecultact_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("ptipobienid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtproducto_Ptipobienid_N), 1, 0)));
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
         AddObjectProperty("productoid", gxTv_Sdtproducto_Productoid, false);
         AddObjectProperty("pcambsid", gxTv_Sdtproducto_Pcambsid, false);
         AddObjectProperty("productodsc", gxTv_Sdtproducto_Productodsc, false);
         AddObjectProperty("pmodeloid", gxTv_Sdtproducto_Pmodeloid, false);
         AddObjectProperty("pmarcaid", gxTv_Sdtproducto_Pmarcaid, false);
         AddObjectProperty("pcategoriaid", gxTv_Sdtproducto_Pcategoriaid, false);
         AddObjectProperty("productousuario", gxTv_Sdtproducto_Productousuario, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("productofecreg", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("productofecultact", sDateCnv, false);
         AddObjectProperty("ptipobienid", gxTv_Sdtproducto_Ptipobienid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtproducto_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtproducto_Initialized, false);
            AddObjectProperty("productoid_Z", gxTv_Sdtproducto_Productoid_Z, false);
            AddObjectProperty("pcambsid_Z", gxTv_Sdtproducto_Pcambsid_Z, false);
            AddObjectProperty("productodsc_Z", gxTv_Sdtproducto_Productodsc_Z, false);
            AddObjectProperty("pmodeloid_Z", gxTv_Sdtproducto_Pmodeloid_Z, false);
            AddObjectProperty("pmarcaid_Z", gxTv_Sdtproducto_Pmarcaid_Z, false);
            AddObjectProperty("pcategoriaid_Z", gxTv_Sdtproducto_Pcategoriaid_Z, false);
            AddObjectProperty("productousuario_Z", gxTv_Sdtproducto_Productousuario_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("productofecreg_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtproducto_Productofecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("productofecultact_Z", sDateCnv, false);
            AddObjectProperty("ptipobienid_Z", gxTv_Sdtproducto_Ptipobienid_Z, false);
            AddObjectProperty("pcambsid_N", gxTv_Sdtproducto_Pcambsid_N, false);
            AddObjectProperty("productodsc_N", gxTv_Sdtproducto_Productodsc_N, false);
            AddObjectProperty("pmodeloid_N", gxTv_Sdtproducto_Pmodeloid_N, false);
            AddObjectProperty("pmarcaid_N", gxTv_Sdtproducto_Pmarcaid_N, false);
            AddObjectProperty("pcategoriaid_N", gxTv_Sdtproducto_Pcategoriaid_N, false);
            AddObjectProperty("productousuario_N", gxTv_Sdtproducto_Productousuario_N, false);
            AddObjectProperty("productofecreg_N", gxTv_Sdtproducto_Productofecreg_N, false);
            AddObjectProperty("productofecultact_N", gxTv_Sdtproducto_Productofecultact_N, false);
            AddObjectProperty("ptipobienid_N", gxTv_Sdtproducto_Ptipobienid_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "productoid" )]
      [  XmlElement( ElementName = "productoid"   )]
      public int gxTpr_Productoid
      {
         get {
            return gxTv_Sdtproducto_Productoid ;
         }

         set {
            if ( gxTv_Sdtproducto_Productoid != value )
            {
               gxTv_Sdtproducto_Mode = "INS";
               this.gxTv_Sdtproducto_Productoid_Z_SetNull( );
               this.gxTv_Sdtproducto_Pcambsid_Z_SetNull( );
               this.gxTv_Sdtproducto_Productodsc_Z_SetNull( );
               this.gxTv_Sdtproducto_Pmodeloid_Z_SetNull( );
               this.gxTv_Sdtproducto_Pmarcaid_Z_SetNull( );
               this.gxTv_Sdtproducto_Pcategoriaid_Z_SetNull( );
               this.gxTv_Sdtproducto_Productousuario_Z_SetNull( );
               this.gxTv_Sdtproducto_Productofecreg_Z_SetNull( );
               this.gxTv_Sdtproducto_Productofecultact_Z_SetNull( );
               this.gxTv_Sdtproducto_Ptipobienid_Z_SetNull( );
            }
            gxTv_Sdtproducto_Productoid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "pcambsid" )]
      [  XmlElement( ElementName = "pcambsid"   )]
      public short gxTpr_Pcambsid
      {
         get {
            return gxTv_Sdtproducto_Pcambsid ;
         }

         set {
            gxTv_Sdtproducto_Pcambsid_N = 0;
            gxTv_Sdtproducto_Pcambsid = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcambsid_SetNull( )
      {
         gxTv_Sdtproducto_Pcambsid_N = 1;
         gxTv_Sdtproducto_Pcambsid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcambsid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc" )]
      [  XmlElement( ElementName = "productodsc"   )]
      public String gxTpr_Productodsc
      {
         get {
            return gxTv_Sdtproducto_Productodsc ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_N = 0;
            gxTv_Sdtproducto_Productodsc = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_N = 1;
         gxTv_Sdtproducto_Productodsc = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmodeloid" )]
      [  XmlElement( ElementName = "pmodeloid"   )]
      public short gxTpr_Pmodeloid
      {
         get {
            return gxTv_Sdtproducto_Pmodeloid ;
         }

         set {
            gxTv_Sdtproducto_Pmodeloid_N = 0;
            gxTv_Sdtproducto_Pmodeloid = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmodeloid_SetNull( )
      {
         gxTv_Sdtproducto_Pmodeloid_N = 1;
         gxTv_Sdtproducto_Pmodeloid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmodeloid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmarcaid" )]
      [  XmlElement( ElementName = "pmarcaid"   )]
      public short gxTpr_Pmarcaid
      {
         get {
            return gxTv_Sdtproducto_Pmarcaid ;
         }

         set {
            gxTv_Sdtproducto_Pmarcaid_N = 0;
            gxTv_Sdtproducto_Pmarcaid = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmarcaid_SetNull( )
      {
         gxTv_Sdtproducto_Pmarcaid_N = 1;
         gxTv_Sdtproducto_Pmarcaid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmarcaid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pcategoriaid" )]
      [  XmlElement( ElementName = "pcategoriaid"   )]
      public short gxTpr_Pcategoriaid
      {
         get {
            return gxTv_Sdtproducto_Pcategoriaid ;
         }

         set {
            gxTv_Sdtproducto_Pcategoriaid_N = 0;
            gxTv_Sdtproducto_Pcategoriaid = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcategoriaid_SetNull( )
      {
         gxTv_Sdtproducto_Pcategoriaid_N = 1;
         gxTv_Sdtproducto_Pcategoriaid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcategoriaid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario" )]
      [  XmlElement( ElementName = "productousuario"   )]
      public String gxTpr_Productousuario
      {
         get {
            return gxTv_Sdtproducto_Productousuario ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_N = 0;
            gxTv_Sdtproducto_Productousuario = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_N = 1;
         gxTv_Sdtproducto_Productousuario = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg" )]
      [  XmlElement( ElementName = "productofecreg"  , IsNullable=true )]
      public string gxTpr_Productofecreg_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecreg == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproducto_Productofecreg).value ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproducto_Productofecreg = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecreg
      {
         get {
            return gxTv_Sdtproducto_Productofecreg ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = 0;
            gxTv_Sdtproducto_Productofecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_N = 1;
         gxTv_Sdtproducto_Productofecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact" )]
      [  XmlElement( ElementName = "productofecultact"  , IsNullable=true )]
      public string gxTpr_Productofecultact_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecultact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproducto_Productofecultact).value ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproducto_Productofecultact = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecultact
      {
         get {
            return gxTv_Sdtproducto_Productofecultact ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = 0;
            gxTv_Sdtproducto_Productofecultact = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_N = 1;
         gxTv_Sdtproducto_Productofecultact = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ptipobienid" )]
      [  XmlElement( ElementName = "ptipobienid"   )]
      public short gxTpr_Ptipobienid
      {
         get {
            return gxTv_Sdtproducto_Ptipobienid ;
         }

         set {
            gxTv_Sdtproducto_Ptipobienid_N = 0;
            gxTv_Sdtproducto_Ptipobienid = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Ptipobienid_SetNull( )
      {
         gxTv_Sdtproducto_Ptipobienid_N = 1;
         gxTv_Sdtproducto_Ptipobienid = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Ptipobienid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtproducto_Mode ;
         }

         set {
            gxTv_Sdtproducto_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Mode_SetNull( )
      {
         gxTv_Sdtproducto_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtproducto_Initialized ;
         }

         set {
            gxTv_Sdtproducto_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Initialized_SetNull( )
      {
         gxTv_Sdtproducto_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productoid_Z" )]
      [  XmlElement( ElementName = "productoid_Z"   )]
      public int gxTpr_Productoid_Z
      {
         get {
            return gxTv_Sdtproducto_Productoid_Z ;
         }

         set {
            gxTv_Sdtproducto_Productoid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtproducto_Productoid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productoid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pcambsid_Z" )]
      [  XmlElement( ElementName = "pcambsid_Z"   )]
      public short gxTpr_Pcambsid_Z
      {
         get {
            return gxTv_Sdtproducto_Pcambsid_Z ;
         }

         set {
            gxTv_Sdtproducto_Pcambsid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcambsid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Pcambsid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcambsid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc_Z" )]
      [  XmlElement( ElementName = "productodsc_Z"   )]
      public String gxTpr_Productodsc_Z
      {
         get {
            return gxTv_Sdtproducto_Productodsc_Z ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmodeloid_Z" )]
      [  XmlElement( ElementName = "pmodeloid_Z"   )]
      public short gxTpr_Pmodeloid_Z
      {
         get {
            return gxTv_Sdtproducto_Pmodeloid_Z ;
         }

         set {
            gxTv_Sdtproducto_Pmodeloid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmodeloid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Pmodeloid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmodeloid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmarcaid_Z" )]
      [  XmlElement( ElementName = "pmarcaid_Z"   )]
      public short gxTpr_Pmarcaid_Z
      {
         get {
            return gxTv_Sdtproducto_Pmarcaid_Z ;
         }

         set {
            gxTv_Sdtproducto_Pmarcaid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmarcaid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Pmarcaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmarcaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pcategoriaid_Z" )]
      [  XmlElement( ElementName = "pcategoriaid_Z"   )]
      public short gxTpr_Pcategoriaid_Z
      {
         get {
            return gxTv_Sdtproducto_Pcategoriaid_Z ;
         }

         set {
            gxTv_Sdtproducto_Pcategoriaid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcategoriaid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Pcategoriaid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcategoriaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario_Z" )]
      [  XmlElement( ElementName = "productousuario_Z"   )]
      public String gxTpr_Productousuario_Z
      {
         get {
            return gxTv_Sdtproducto_Productousuario_Z ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg_Z" )]
      [  XmlElement( ElementName = "productofecreg_Z"  , IsNullable=true )]
      public string gxTpr_Productofecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecreg_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproducto_Productofecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproducto_Productofecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecreg_Z
      {
         get {
            return gxTv_Sdtproducto_Productofecreg_Z ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact_Z" )]
      [  XmlElement( ElementName = "productofecultact_Z"  , IsNullable=true )]
      public string gxTpr_Productofecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtproducto_Productofecultact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtproducto_Productofecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtproducto_Productofecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtproducto_Productofecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Productofecultact_Z
      {
         get {
            return gxTv_Sdtproducto_Productofecultact_Z ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_Z_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ptipobienid_Z" )]
      [  XmlElement( ElementName = "ptipobienid_Z"   )]
      public short gxTpr_Ptipobienid_Z
      {
         get {
            return gxTv_Sdtproducto_Ptipobienid_Z ;
         }

         set {
            gxTv_Sdtproducto_Ptipobienid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Ptipobienid_Z_SetNull( )
      {
         gxTv_Sdtproducto_Ptipobienid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Ptipobienid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pcambsid_N" )]
      [  XmlElement( ElementName = "pcambsid_N"   )]
      public short gxTpr_Pcambsid_N
      {
         get {
            return gxTv_Sdtproducto_Pcambsid_N ;
         }

         set {
            gxTv_Sdtproducto_Pcambsid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcambsid_N_SetNull( )
      {
         gxTv_Sdtproducto_Pcambsid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcambsid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productodsc_N" )]
      [  XmlElement( ElementName = "productodsc_N"   )]
      public short gxTpr_Productodsc_N
      {
         get {
            return gxTv_Sdtproducto_Productodsc_N ;
         }

         set {
            gxTv_Sdtproducto_Productodsc_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productodsc_N_SetNull( )
      {
         gxTv_Sdtproducto_Productodsc_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productodsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmodeloid_N" )]
      [  XmlElement( ElementName = "pmodeloid_N"   )]
      public short gxTpr_Pmodeloid_N
      {
         get {
            return gxTv_Sdtproducto_Pmodeloid_N ;
         }

         set {
            gxTv_Sdtproducto_Pmodeloid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmodeloid_N_SetNull( )
      {
         gxTv_Sdtproducto_Pmodeloid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmodeloid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pmarcaid_N" )]
      [  XmlElement( ElementName = "pmarcaid_N"   )]
      public short gxTpr_Pmarcaid_N
      {
         get {
            return gxTv_Sdtproducto_Pmarcaid_N ;
         }

         set {
            gxTv_Sdtproducto_Pmarcaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pmarcaid_N_SetNull( )
      {
         gxTv_Sdtproducto_Pmarcaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pmarcaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "pcategoriaid_N" )]
      [  XmlElement( ElementName = "pcategoriaid_N"   )]
      public short gxTpr_Pcategoriaid_N
      {
         get {
            return gxTv_Sdtproducto_Pcategoriaid_N ;
         }

         set {
            gxTv_Sdtproducto_Pcategoriaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Pcategoriaid_N_SetNull( )
      {
         gxTv_Sdtproducto_Pcategoriaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Pcategoriaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productousuario_N" )]
      [  XmlElement( ElementName = "productousuario_N"   )]
      public short gxTpr_Productousuario_N
      {
         get {
            return gxTv_Sdtproducto_Productousuario_N ;
         }

         set {
            gxTv_Sdtproducto_Productousuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productousuario_N_SetNull( )
      {
         gxTv_Sdtproducto_Productousuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productousuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecreg_N" )]
      [  XmlElement( ElementName = "productofecreg_N"   )]
      public short gxTpr_Productofecreg_N
      {
         get {
            return gxTv_Sdtproducto_Productofecreg_N ;
         }

         set {
            gxTv_Sdtproducto_Productofecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecreg_N_SetNull( )
      {
         gxTv_Sdtproducto_Productofecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecreg_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "productofecultact_N" )]
      [  XmlElement( ElementName = "productofecultact_N"   )]
      public short gxTpr_Productofecultact_N
      {
         get {
            return gxTv_Sdtproducto_Productofecultact_N ;
         }

         set {
            gxTv_Sdtproducto_Productofecultact_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Productofecultact_N_SetNull( )
      {
         gxTv_Sdtproducto_Productofecultact_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Productofecultact_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ptipobienid_N" )]
      [  XmlElement( ElementName = "ptipobienid_N"   )]
      public short gxTpr_Ptipobienid_N
      {
         get {
            return gxTv_Sdtproducto_Ptipobienid_N ;
         }

         set {
            gxTv_Sdtproducto_Ptipobienid_N = (short)(value);
         }

      }

      public void gxTv_Sdtproducto_Ptipobienid_N_SetNull( )
      {
         gxTv_Sdtproducto_Ptipobienid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtproducto_Ptipobienid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtproducto_Productodsc = "";
         gxTv_Sdtproducto_Productousuario = "";
         gxTv_Sdtproducto_Productofecreg = DateTime.MinValue;
         gxTv_Sdtproducto_Productofecultact = DateTime.MinValue;
         gxTv_Sdtproducto_Mode = "";
         gxTv_Sdtproducto_Productodsc_Z = "";
         gxTv_Sdtproducto_Productousuario_Z = "";
         gxTv_Sdtproducto_Productofecreg_Z = DateTime.MinValue;
         gxTv_Sdtproducto_Productofecultact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "producto", "GeneXus.Programs.producto_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtproducto_Pcambsid ;
      private short gxTv_Sdtproducto_Pmodeloid ;
      private short gxTv_Sdtproducto_Pmarcaid ;
      private short gxTv_Sdtproducto_Pcategoriaid ;
      private short gxTv_Sdtproducto_Ptipobienid ;
      private short gxTv_Sdtproducto_Initialized ;
      private short gxTv_Sdtproducto_Pcambsid_Z ;
      private short gxTv_Sdtproducto_Pmodeloid_Z ;
      private short gxTv_Sdtproducto_Pmarcaid_Z ;
      private short gxTv_Sdtproducto_Pcategoriaid_Z ;
      private short gxTv_Sdtproducto_Ptipobienid_Z ;
      private short gxTv_Sdtproducto_Pcambsid_N ;
      private short gxTv_Sdtproducto_Productodsc_N ;
      private short gxTv_Sdtproducto_Pmodeloid_N ;
      private short gxTv_Sdtproducto_Pmarcaid_N ;
      private short gxTv_Sdtproducto_Pcategoriaid_N ;
      private short gxTv_Sdtproducto_Productousuario_N ;
      private short gxTv_Sdtproducto_Productofecreg_N ;
      private short gxTv_Sdtproducto_Productofecultact_N ;
      private short gxTv_Sdtproducto_Ptipobienid_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtproducto_Productoid ;
      private int gxTv_Sdtproducto_Productoid_Z ;
      private String gxTv_Sdtproducto_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtproducto_Productofecreg ;
      private DateTime gxTv_Sdtproducto_Productofecultact ;
      private DateTime gxTv_Sdtproducto_Productofecreg_Z ;
      private DateTime gxTv_Sdtproducto_Productofecultact_Z ;
      private String gxTv_Sdtproducto_Productodsc ;
      private String gxTv_Sdtproducto_Productousuario ;
      private String gxTv_Sdtproducto_Productodsc_Z ;
      private String gxTv_Sdtproducto_Productousuario_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"producto", Namespace = "Condufef_v1")]
   public class Sdtproducto_RESTInterface : GxGenericCollectionItem<Sdtproducto>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtproducto_RESTInterface( ) : base()
      {
      }

      public Sdtproducto_RESTInterface( Sdtproducto psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "productoid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Productoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Productoid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Productoid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "pcambsid" , Order = 1 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Pcambsid
      {
         get {
            return sdt.gxTpr_Pcambsid ;
         }

         set {
            sdt.gxTpr_Pcambsid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "productodsc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Productodsc
      {
         get {
            return sdt.gxTpr_Productodsc ;
         }

         set {
            sdt.gxTpr_Productodsc = (String)(value);
         }

      }

      [DataMember( Name = "pmodeloid" , Order = 3 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Pmodeloid
      {
         get {
            return sdt.gxTpr_Pmodeloid ;
         }

         set {
            sdt.gxTpr_Pmodeloid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "pmarcaid" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Pmarcaid
      {
         get {
            return sdt.gxTpr_Pmarcaid ;
         }

         set {
            sdt.gxTpr_Pmarcaid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "pcategoriaid" , Order = 5 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Pcategoriaid
      {
         get {
            return sdt.gxTpr_Pcategoriaid ;
         }

         set {
            sdt.gxTpr_Pcategoriaid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "productousuario" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Productousuario
      {
         get {
            return sdt.gxTpr_Productousuario ;
         }

         set {
            sdt.gxTpr_Productousuario = (String)(value);
         }

      }

      [DataMember( Name = "productofecreg" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Productofecreg
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Productofecreg) ;
         }

         set {
            sdt.gxTpr_Productofecreg = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "productofecultact" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Productofecultact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Productofecultact) ;
         }

         set {
            sdt.gxTpr_Productofecultact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "ptipobienid" , Order = 9 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Ptipobienid
      {
         get {
            return sdt.gxTpr_Ptipobienid ;
         }

         set {
            sdt.gxTpr_Ptipobienid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public Sdtproducto sdt
      {
         get {
            return (Sdtproducto)Sdt ;
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
            sdt = new Sdtproducto() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 31 )]
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
