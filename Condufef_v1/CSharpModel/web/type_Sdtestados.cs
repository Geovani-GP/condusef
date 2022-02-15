/*
               File: type_Sdtestados
        Description: estados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:17.24
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
   [XmlRoot(ElementName = "estados" )]
   [XmlType(TypeName =  "estados" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtestados : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtestados( )
      {
         /* Constructor for serialization */
         gxTv_Sdtestados_Estado = "";
         gxTv_Sdtestados_Mode = "";
         gxTv_Sdtestados_Estado_Z = "";
      }

      public Sdtestados( IGxContext context )
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

      public void Load( short AV177estadoid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV177estadoid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"estadoid", typeof(short)}}) ;
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
         metadata.Set("Name", "estados");
         metadata.Set("BT", "estados");
         metadata.Set("PK", "[ \"estadoid\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Estadoid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Estado_Z" , attrs);
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
         Sdtestados deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtestados)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtestados obj ;
         obj = this;
         obj.gxTpr_Estadoid = deserialized.gxTpr_Estadoid;
         obj.gxTpr_Estado = deserialized.gxTpr_Estado;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Estadoid_Z = deserialized.gxTpr_Estadoid_Z;
         obj.gxTpr_Estado_Z = deserialized.gxTpr_Estado_Z;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "estadoid") )
               {
                  gxTv_Sdtestados_Estadoid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estado") )
               {
                  gxTv_Sdtestados_Estado = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtestados_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtestados_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estadoid_Z") )
               {
                  gxTv_Sdtestados_Estadoid_Z = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "estado_Z") )
               {
                  gxTv_Sdtestados_Estado_Z = oReader.Value;
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
            sName = "estados";
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
         oWriter.WriteElement("estadoid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestados_Estadoid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("estado", StringUtil.RTrim( gxTv_Sdtestados_Estado));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtestados_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestados_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estadoid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtestados_Estadoid_Z), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("estado_Z", StringUtil.RTrim( gxTv_Sdtestados_Estado_Z));
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
         AddObjectProperty("estadoid", gxTv_Sdtestados_Estadoid, false);
         AddObjectProperty("estado", gxTv_Sdtestados_Estado, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtestados_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtestados_Initialized, false);
            AddObjectProperty("estadoid_Z", gxTv_Sdtestados_Estadoid_Z, false);
            AddObjectProperty("estado_Z", gxTv_Sdtestados_Estado_Z, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "estadoid" )]
      [  XmlElement( ElementName = "estadoid"   )]
      public short gxTpr_Estadoid
      {
         get {
            return gxTv_Sdtestados_Estadoid ;
         }

         set {
            if ( gxTv_Sdtestados_Estadoid != value )
            {
               gxTv_Sdtestados_Mode = "INS";
               this.gxTv_Sdtestados_Estadoid_Z_SetNull( );
               this.gxTv_Sdtestados_Estado_Z_SetNull( );
            }
            gxTv_Sdtestados_Estadoid = (short)(value);
         }

      }

      [  SoapElement( ElementName = "estado" )]
      [  XmlElement( ElementName = "estado"   )]
      public String gxTpr_Estado
      {
         get {
            return gxTv_Sdtestados_Estado ;
         }

         set {
            gxTv_Sdtestados_Estado = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtestados_Mode ;
         }

         set {
            gxTv_Sdtestados_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtestados_Mode_SetNull( )
      {
         gxTv_Sdtestados_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtestados_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtestados_Initialized ;
         }

         set {
            gxTv_Sdtestados_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtestados_Initialized_SetNull( )
      {
         gxTv_Sdtestados_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtestados_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estadoid_Z" )]
      [  XmlElement( ElementName = "estadoid_Z"   )]
      public short gxTpr_Estadoid_Z
      {
         get {
            return gxTv_Sdtestados_Estadoid_Z ;
         }

         set {
            gxTv_Sdtestados_Estadoid_Z = (short)(value);
         }

      }

      public void gxTv_Sdtestados_Estadoid_Z_SetNull( )
      {
         gxTv_Sdtestados_Estadoid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtestados_Estadoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "estado_Z" )]
      [  XmlElement( ElementName = "estado_Z"   )]
      public String gxTpr_Estado_Z
      {
         get {
            return gxTv_Sdtestados_Estado_Z ;
         }

         set {
            gxTv_Sdtestados_Estado_Z = (String)(value);
         }

      }

      public void gxTv_Sdtestados_Estado_Z_SetNull( )
      {
         gxTv_Sdtestados_Estado_Z = "";
         return  ;
      }

      public bool gxTv_Sdtestados_Estado_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtestados_Estado = "";
         gxTv_Sdtestados_Mode = "";
         gxTv_Sdtestados_Estado_Z = "";
         sTagName = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "estados", "GeneXus.Programs.estados_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtestados_Estadoid ;
      private short gxTv_Sdtestados_Initialized ;
      private short gxTv_Sdtestados_Estadoid_Z ;
      private short readOk ;
      private short nOutParmCount ;
      private String gxTv_Sdtestados_Mode ;
      private String sTagName ;
      private String gxTv_Sdtestados_Estado ;
      private String gxTv_Sdtestados_Estado_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"estados", Namespace = "Condufef_v1")]
   public class Sdtestados_RESTInterface : GxGenericCollectionItem<Sdtestados>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtestados_RESTInterface( ) : base()
      {
      }

      public Sdtestados_RESTInterface( Sdtestados psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "estadoid" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Estadoid
      {
         get {
            return sdt.gxTpr_Estadoid ;
         }

         set {
            sdt.gxTpr_Estadoid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "estado" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Estado
      {
         get {
            return sdt.gxTpr_Estado ;
         }

         set {
            sdt.gxTpr_Estado = (String)(value);
         }

      }

      public Sdtestados sdt
      {
         get {
            return (Sdtestados)Sdt ;
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
            sdt = new Sdtestados() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
