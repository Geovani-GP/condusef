/*
               File: type_SdtMessages_Message
        Description: Messages
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:20:6.11
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
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
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
   [XmlRoot(ElementName = "Messages.Message" )]
   [XmlType(TypeName =  "Messages.Message" , Namespace = "Genexus" )]
   [Serializable]
   public class SdtMessages_Message : GxUserType
   {
      public SdtMessages_Message( )
      {
         /* Constructor for serialization */
         gxTv_SdtMessages_Message_Id = "";
         gxTv_SdtMessages_Message_Description = "";
      }

      public SdtMessages_Message( IGxContext context )
      {
         this.context = context;
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

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         xmls = new XmlSerializer(this.GetType(), sNameSpace);
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
         SdtMessages_Message deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Genexus" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtMessages_Message)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtMessages_Message obj ;
         obj = this;
         obj.gxTpr_Id = deserialized.gxTpr_Id;
         obj.gxTpr_Type = deserialized.gxTpr_Type;
         obj.gxTpr_Description = deserialized.gxTpr_Description;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Id") )
               {
                  gxTv_SdtMessages_Message_Id = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Type") )
               {
                  gxTv_SdtMessages_Message_Type = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Description") )
               {
                  gxTv_SdtMessages_Message_Description = oReader.Value;
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
            sName = "Messages.Message";
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
         oWriter.WriteElement("Id", StringUtil.RTrim( gxTv_SdtMessages_Message_Id));
         if ( StringUtil.StrCmp(sNameSpace, "Genexus") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Genexus");
         }
         oWriter.WriteElement("Type", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtMessages_Message_Type), 2, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Genexus") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Genexus");
         }
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtMessages_Message_Description));
         if ( StringUtil.StrCmp(sNameSpace, "Genexus") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Genexus");
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
         AddObjectProperty("Id", gxTv_SdtMessages_Message_Id, false);
         AddObjectProperty("Type", gxTv_SdtMessages_Message_Type, false);
         AddObjectProperty("Description", gxTv_SdtMessages_Message_Description, false);
         return  ;
      }

      [  SoapElement( ElementName = "Id" )]
      [  XmlElement( ElementName = "Id"   )]
      public String gxTpr_Id
      {
         get {
            return gxTv_SdtMessages_Message_Id ;
         }

         set {
            gxTv_SdtMessages_Message_Id = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Type" )]
      [  XmlElement( ElementName = "Type"   )]
      public short gxTpr_Type
      {
         get {
            return gxTv_SdtMessages_Message_Type ;
         }

         set {
            gxTv_SdtMessages_Message_Type = (short)(value);
         }

      }

      [  SoapElement( ElementName = "Description" )]
      [  XmlElement( ElementName = "Description"   )]
      public String gxTpr_Description
      {
         get {
            return gxTv_SdtMessages_Message_Description ;
         }

         set {
            gxTv_SdtMessages_Message_Description = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtMessages_Message_Id = "";
         gxTv_SdtMessages_Message_Description = "";
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtMessages_Message_Type ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtMessages_Message_Id ;
      protected String gxTv_SdtMessages_Message_Description ;
   }

   [DataContract(Name = @"Messages.Message", Namespace = "Genexus")]
   public class SdtMessages_Message_RESTInterface : GxGenericCollectionItem<SdtMessages_Message>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtMessages_Message_RESTInterface( ) : base()
      {
      }

      public SdtMessages_Message_RESTInterface( SdtMessages_Message psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Id" , Order = 0 )]
      public String gxTpr_Id
      {
         get {
            return sdt.gxTpr_Id ;
         }

         set {
            sdt.gxTpr_Id = (String)(value);
         }

      }

      [DataMember( Name = "Type" , Order = 1 )]
      public Nullable<short> gxTpr_Type
      {
         get {
            return sdt.gxTpr_Type ;
         }

         set {
            sdt.gxTpr_Type = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Description" , Order = 2 )]
      public String gxTpr_Description
      {
         get {
            return sdt.gxTpr_Description ;
         }

         set {
            sdt.gxTpr_Description = (String)(value);
         }

      }

      public SdtMessages_Message sdt
      {
         get {
            return (SdtMessages_Message)Sdt ;
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
            sdt = new SdtMessages_Message() ;
         }
      }

   }

}
