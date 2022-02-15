/*
               File: type_Sdtusuarios
        Description: usuarios
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:9:5.13
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
   [XmlRoot(ElementName = "usuarios" )]
   [XmlType(TypeName =  "usuarios" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtusuarios : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtusuarios( )
      {
         /* Constructor for serialization */
         gxTv_Sdtusuarios_Usuario = "";
         gxTv_Sdtusuarios_Contrasena = "";
         gxTv_Sdtusuarios_Mode = "";
         gxTv_Sdtusuarios_Usuario_Z = "";
         gxTv_Sdtusuarios_Contrasena_Z = "";
      }

      public Sdtusuarios( IGxContext context )
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

      public void Load( int AV9idusuario )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV9idusuario});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"idusuario", typeof(int)}}) ;
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
         metadata.Set("Name", "usuarios");
         metadata.Set("BT", "USUARIOS");
         metadata.Set("PK", "[ \"idusuario\" ]");
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
            ov.Add(this.GetType(),  "gxTpr_Idusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Usuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Contrasena_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Usuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Contrasena_N" , attrs);
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
         Sdtusuarios deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtusuarios)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtusuarios obj ;
         obj = this;
         obj.gxTpr_Idusuario = deserialized.gxTpr_Idusuario;
         obj.gxTpr_Usuario = deserialized.gxTpr_Usuario;
         obj.gxTpr_Contrasena = deserialized.gxTpr_Contrasena;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Idusuario_Z = deserialized.gxTpr_Idusuario_Z;
         obj.gxTpr_Usuario_Z = deserialized.gxTpr_Usuario_Z;
         obj.gxTpr_Contrasena_Z = deserialized.gxTpr_Contrasena_Z;
         obj.gxTpr_Usuario_N = deserialized.gxTpr_Usuario_N;
         obj.gxTpr_Contrasena_N = deserialized.gxTpr_Contrasena_N;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "idusuario") )
               {
                  gxTv_Sdtusuarios_Idusuario = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "usuario") )
               {
                  gxTv_Sdtusuarios_Usuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "contrasena") )
               {
                  gxTv_Sdtusuarios_Contrasena = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtusuarios_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtusuarios_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "idusuario_Z") )
               {
                  gxTv_Sdtusuarios_Idusuario_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "usuario_Z") )
               {
                  gxTv_Sdtusuarios_Usuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "contrasena_Z") )
               {
                  gxTv_Sdtusuarios_Contrasena_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "usuario_N") )
               {
                  gxTv_Sdtusuarios_Usuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "contrasena_N") )
               {
                  gxTv_Sdtusuarios_Contrasena_N = (short)(NumberUtil.Val( oReader.Value, "."));
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
            sName = "usuarios";
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
         oWriter.WriteElement("idusuario", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtusuarios_Idusuario), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("usuario", StringUtil.RTrim( gxTv_Sdtusuarios_Usuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("contrasena", StringUtil.RTrim( gxTv_Sdtusuarios_Contrasena));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtusuarios_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtusuarios_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("idusuario_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtusuarios_Idusuario_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("usuario_Z", StringUtil.RTrim( gxTv_Sdtusuarios_Usuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("contrasena_Z", StringUtil.RTrim( gxTv_Sdtusuarios_Contrasena_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("usuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtusuarios_Usuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("contrasena_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtusuarios_Contrasena_N), 1, 0)));
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
         AddObjectProperty("idusuario", gxTv_Sdtusuarios_Idusuario, false);
         AddObjectProperty("usuario", gxTv_Sdtusuarios_Usuario, false);
         AddObjectProperty("contrasena", gxTv_Sdtusuarios_Contrasena, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtusuarios_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtusuarios_Initialized, false);
            AddObjectProperty("idusuario_Z", gxTv_Sdtusuarios_Idusuario_Z, false);
            AddObjectProperty("usuario_Z", gxTv_Sdtusuarios_Usuario_Z, false);
            AddObjectProperty("contrasena_Z", gxTv_Sdtusuarios_Contrasena_Z, false);
            AddObjectProperty("usuario_N", gxTv_Sdtusuarios_Usuario_N, false);
            AddObjectProperty("contrasena_N", gxTv_Sdtusuarios_Contrasena_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "idusuario" )]
      [  XmlElement( ElementName = "idusuario"   )]
      public int gxTpr_Idusuario
      {
         get {
            return gxTv_Sdtusuarios_Idusuario ;
         }

         set {
            if ( gxTv_Sdtusuarios_Idusuario != value )
            {
               gxTv_Sdtusuarios_Mode = "INS";
               this.gxTv_Sdtusuarios_Idusuario_Z_SetNull( );
               this.gxTv_Sdtusuarios_Usuario_Z_SetNull( );
               this.gxTv_Sdtusuarios_Contrasena_Z_SetNull( );
            }
            gxTv_Sdtusuarios_Idusuario = (int)(value);
         }

      }

      [  SoapElement( ElementName = "usuario" )]
      [  XmlElement( ElementName = "usuario"   )]
      public String gxTpr_Usuario
      {
         get {
            return gxTv_Sdtusuarios_Usuario ;
         }

         set {
            gxTv_Sdtusuarios_Usuario_N = 0;
            gxTv_Sdtusuarios_Usuario = (String)(value);
         }

      }

      public void gxTv_Sdtusuarios_Usuario_SetNull( )
      {
         gxTv_Sdtusuarios_Usuario_N = 1;
         gxTv_Sdtusuarios_Usuario = "";
         return  ;
      }

      public bool gxTv_Sdtusuarios_Usuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "contrasena" )]
      [  XmlElement( ElementName = "contrasena"   )]
      public String gxTpr_Contrasena
      {
         get {
            return gxTv_Sdtusuarios_Contrasena ;
         }

         set {
            gxTv_Sdtusuarios_Contrasena_N = 0;
            gxTv_Sdtusuarios_Contrasena = (String)(value);
         }

      }

      public void gxTv_Sdtusuarios_Contrasena_SetNull( )
      {
         gxTv_Sdtusuarios_Contrasena_N = 1;
         gxTv_Sdtusuarios_Contrasena = "";
         return  ;
      }

      public bool gxTv_Sdtusuarios_Contrasena_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtusuarios_Mode ;
         }

         set {
            gxTv_Sdtusuarios_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtusuarios_Mode_SetNull( )
      {
         gxTv_Sdtusuarios_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtusuarios_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtusuarios_Initialized ;
         }

         set {
            gxTv_Sdtusuarios_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtusuarios_Initialized_SetNull( )
      {
         gxTv_Sdtusuarios_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtusuarios_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "idusuario_Z" )]
      [  XmlElement( ElementName = "idusuario_Z"   )]
      public int gxTpr_Idusuario_Z
      {
         get {
            return gxTv_Sdtusuarios_Idusuario_Z ;
         }

         set {
            gxTv_Sdtusuarios_Idusuario_Z = (int)(value);
         }

      }

      public void gxTv_Sdtusuarios_Idusuario_Z_SetNull( )
      {
         gxTv_Sdtusuarios_Idusuario_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtusuarios_Idusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "usuario_Z" )]
      [  XmlElement( ElementName = "usuario_Z"   )]
      public String gxTpr_Usuario_Z
      {
         get {
            return gxTv_Sdtusuarios_Usuario_Z ;
         }

         set {
            gxTv_Sdtusuarios_Usuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtusuarios_Usuario_Z_SetNull( )
      {
         gxTv_Sdtusuarios_Usuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtusuarios_Usuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "contrasena_Z" )]
      [  XmlElement( ElementName = "contrasena_Z"   )]
      public String gxTpr_Contrasena_Z
      {
         get {
            return gxTv_Sdtusuarios_Contrasena_Z ;
         }

         set {
            gxTv_Sdtusuarios_Contrasena_Z = (String)(value);
         }

      }

      public void gxTv_Sdtusuarios_Contrasena_Z_SetNull( )
      {
         gxTv_Sdtusuarios_Contrasena_Z = "";
         return  ;
      }

      public bool gxTv_Sdtusuarios_Contrasena_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "usuario_N" )]
      [  XmlElement( ElementName = "usuario_N"   )]
      public short gxTpr_Usuario_N
      {
         get {
            return gxTv_Sdtusuarios_Usuario_N ;
         }

         set {
            gxTv_Sdtusuarios_Usuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtusuarios_Usuario_N_SetNull( )
      {
         gxTv_Sdtusuarios_Usuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtusuarios_Usuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "contrasena_N" )]
      [  XmlElement( ElementName = "contrasena_N"   )]
      public short gxTpr_Contrasena_N
      {
         get {
            return gxTv_Sdtusuarios_Contrasena_N ;
         }

         set {
            gxTv_Sdtusuarios_Contrasena_N = (short)(value);
         }

      }

      public void gxTv_Sdtusuarios_Contrasena_N_SetNull( )
      {
         gxTv_Sdtusuarios_Contrasena_N = 0;
         return  ;
      }

      public bool gxTv_Sdtusuarios_Contrasena_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtusuarios_Usuario = "";
         gxTv_Sdtusuarios_Contrasena = "";
         gxTv_Sdtusuarios_Mode = "";
         gxTv_Sdtusuarios_Usuario_Z = "";
         gxTv_Sdtusuarios_Contrasena_Z = "";
         sTagName = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "usuarios", "GeneXus.Programs.usuarios_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtusuarios_Initialized ;
      private short gxTv_Sdtusuarios_Usuario_N ;
      private short gxTv_Sdtusuarios_Contrasena_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtusuarios_Idusuario ;
      private int gxTv_Sdtusuarios_Idusuario_Z ;
      private String gxTv_Sdtusuarios_Mode ;
      private String sTagName ;
      private String gxTv_Sdtusuarios_Usuario ;
      private String gxTv_Sdtusuarios_Contrasena ;
      private String gxTv_Sdtusuarios_Usuario_Z ;
      private String gxTv_Sdtusuarios_Contrasena_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"usuarios", Namespace = "Condufef_v1")]
   public class Sdtusuarios_RESTInterface : GxGenericCollectionItem<Sdtusuarios>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtusuarios_RESTInterface( ) : base()
      {
      }

      public Sdtusuarios_RESTInterface( Sdtusuarios psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "idusuario" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Idusuario
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Idusuario), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Idusuario = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "usuario" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Usuario
      {
         get {
            return sdt.gxTpr_Usuario ;
         }

         set {
            sdt.gxTpr_Usuario = (String)(value);
         }

      }

      [DataMember( Name = "contrasena" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Contrasena
      {
         get {
            return sdt.gxTpr_Contrasena ;
         }

         set {
            sdt.gxTpr_Contrasena = (String)(value);
         }

      }

      public Sdtusuarios sdt
      {
         get {
            return (Sdtusuarios)Sdt ;
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
            sdt = new Sdtusuarios() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 10 )]
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
