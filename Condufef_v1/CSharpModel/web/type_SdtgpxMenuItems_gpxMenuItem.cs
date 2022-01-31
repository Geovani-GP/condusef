/*
               File: type_SdtgpxMenuItems_gpxMenuItem
        Description: gpxMenuItems
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:55.68
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
   [XmlRoot(ElementName = "gpxMenuItems.gpxMenuItem" )]
   [XmlType(TypeName =  "gpxMenuItems.gpxMenuItem" , Namespace = "Condufef_v1" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtgpxMenuItems_gpxMenuItem ))]
   [Serializable]
   public class SdtgpxMenuItems_gpxMenuItem : GxUserType
   {
      public SdtgpxMenuItems_gpxMenuItem( )
      {
         /* Constructor for serialization */
         gxTv_SdtgpxMenuItems_gpxMenuItem_Code = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Title = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Url = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Image = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Description = "";
      }

      public SdtgpxMenuItems_gpxMenuItem( IGxContext context )
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
         SdtgpxMenuItems_gpxMenuItem deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtgpxMenuItems_gpxMenuItem)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtgpxMenuItems_gpxMenuItem obj ;
         obj = this;
         obj.gxTpr_Code = deserialized.gxTpr_Code;
         obj.gxTpr_Title = deserialized.gxTpr_Title;
         obj.gxTpr_Url = deserialized.gxTpr_Url;
         obj.gxTpr_Linktarget = deserialized.gxTpr_Linktarget;
         obj.gxTpr_Image = deserialized.gxTpr_Image;
         obj.gxTpr_Description = deserialized.gxTpr_Description;
         obj.gxTpr_Index = deserialized.gxTpr_Index;
         obj.gxTpr_Subitems = deserialized.gxTpr_Subitems;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Code") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Code = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Title") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Title = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "URL") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Url = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "LinkTarget") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Image") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Image = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Description") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Description = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Index") )
               {
                  gxTv_SdtgpxMenuItems_gpxMenuItem_Index = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SubItems") )
               {
                  if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems == null )
                  {
                     gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs");
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems.readxml(oReader, "SubItems");
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
            sName = "gpxMenuItems.gpxMenuItem";
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
         oWriter.WriteElement("Code", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Code));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("Title", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Title));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("URL", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Url));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("LinkTarget", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("Image", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Image));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtgpxMenuItems_gpxMenuItem_Description));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("Index", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtgpxMenuItems_gpxMenuItem_Index), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "Condufef_v1";
            }
            else
            {
               sNameSpace1 = "Condufef_v1";
            }
            gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems.writexml(oWriter, "SubItems", sNameSpace1);
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
         AddObjectProperty("Code", gxTv_SdtgpxMenuItems_gpxMenuItem_Code, false);
         AddObjectProperty("Title", gxTv_SdtgpxMenuItems_gpxMenuItem_Title, false);
         AddObjectProperty("URL", gxTv_SdtgpxMenuItems_gpxMenuItem_Url, false);
         AddObjectProperty("LinkTarget", gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget, false);
         AddObjectProperty("Image", gxTv_SdtgpxMenuItems_gpxMenuItem_Image, false);
         AddObjectProperty("Description", gxTv_SdtgpxMenuItems_gpxMenuItem_Description, false);
         AddObjectProperty("Index", gxTv_SdtgpxMenuItems_gpxMenuItem_Index, false);
         if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems != null )
         {
            AddObjectProperty("SubItems", gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "Code" )]
      [  XmlElement( ElementName = "Code"   )]
      public String gxTpr_Code
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Code ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Code = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Title" )]
      [  XmlElement( ElementName = "Title"   )]
      public String gxTpr_Title
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Title ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Title = (String)(value);
         }

      }

      [  SoapElement( ElementName = "URL" )]
      [  XmlElement( ElementName = "URL"   )]
      public String gxTpr_Url
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Url ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Url = (String)(value);
         }

      }

      [  SoapElement( ElementName = "LinkTarget" )]
      [  XmlElement( ElementName = "LinkTarget"   )]
      public String gxTpr_Linktarget
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Image" )]
      [  XmlElement( ElementName = "Image"   )]
      public String gxTpr_Image
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Image ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Image = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Description" )]
      [  XmlElement( ElementName = "Description"   )]
      public String gxTpr_Description
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Description ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Description = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Index" )]
      [  XmlElement( ElementName = "Index"   )]
      public short gxTpr_Index
      {
         get {
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Index ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Index = (short)(value);
         }

      }

      public class gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems_SdtgpxMenuItems_gpxMenuItem_80compatibility:SdtgpxMenuItems_gpxMenuItem {}
      [  SoapElement( ElementName = "SubItems" )]
      [  XmlArray( ElementName = "SubItems"  )]
      [  XmlArrayItemAttribute( Type= typeof( SdtgpxMenuItems_gpxMenuItem ), ElementName= "gpxMenuItems.gpxMenuItem"  , IsNullable=false)]
      public GxObjectCollection gxTpr_Subitems_GxObjectCollection
      {
         get {
            if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems == null )
            {
               gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems ;
         }

         set {
            if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems == null )
            {
               gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs");
            }
            gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Subitems
      {
         get {
            if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems == null )
            {
               gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = new GxObjectCollection( context, "gpxMenuItems.gpxMenuItem", "Condufef_v1", "SdtgpxMenuItems_gpxMenuItem", "GeneXus.Programs");
            }
            return gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems ;
         }

         set {
            gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = value;
         }

      }

      public void gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems_SetNull( )
      {
         gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems = null;
         return  ;
      }

      public bool gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems_IsNull( )
      {
         if ( gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtgpxMenuItems_gpxMenuItem_Code = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Title = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Url = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Image = "";
         gxTv_SdtgpxMenuItems_gpxMenuItem_Description = "";
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtgpxMenuItems_gpxMenuItem_Index ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Code ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Title ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Url ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Linktarget ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Image ;
      protected String gxTv_SdtgpxMenuItems_gpxMenuItem_Description ;
      protected String sTagName ;
      [ObjectCollection(ItemType=typeof( SdtgpxMenuItems_gpxMenuItem ))]
      protected IGxCollection gxTv_SdtgpxMenuItems_gpxMenuItem_Subitems=null ;
   }

   [DataContract(Name = @"gpxMenuItems.gpxMenuItem", Namespace = "Condufef_v1")]
   public class SdtgpxMenuItems_gpxMenuItem_RESTInterface : GxGenericCollectionItem<SdtgpxMenuItems_gpxMenuItem>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtgpxMenuItems_gpxMenuItem_RESTInterface( ) : base()
      {
      }

      public SdtgpxMenuItems_gpxMenuItem_RESTInterface( SdtgpxMenuItems_gpxMenuItem psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Code" , Order = 0 )]
      public String gxTpr_Code
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Code) ;
         }

         set {
            sdt.gxTpr_Code = (String)(value);
         }

      }

      [DataMember( Name = "Title" , Order = 1 )]
      public String gxTpr_Title
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Title) ;
         }

         set {
            sdt.gxTpr_Title = (String)(value);
         }

      }

      [DataMember( Name = "URL" , Order = 2 )]
      public String gxTpr_Url
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Url) ;
         }

         set {
            sdt.gxTpr_Url = (String)(value);
         }

      }

      [DataMember( Name = "LinkTarget" , Order = 3 )]
      public String gxTpr_Linktarget
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Linktarget) ;
         }

         set {
            sdt.gxTpr_Linktarget = (String)(value);
         }

      }

      [DataMember( Name = "Image" , Order = 4 )]
      public String gxTpr_Image
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Image) ;
         }

         set {
            sdt.gxTpr_Image = (String)(value);
         }

      }

      [DataMember( Name = "Description" , Order = 5 )]
      public String gxTpr_Description
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Description) ;
         }

         set {
            sdt.gxTpr_Description = (String)(value);
         }

      }

      [DataMember( Name = "Index" , Order = 6 )]
      public Nullable<short> gxTpr_Index
      {
         get {
            return sdt.gxTpr_Index ;
         }

         set {
            sdt.gxTpr_Index = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SubItems" , Order = 7 )]
      public GxGenericCollection<SdtgpxMenuItems_gpxMenuItem_RESTInterface> gxTpr_Subitems
      {
         get {
            return new GxGenericCollection<SdtgpxMenuItems_gpxMenuItem_RESTInterface>(sdt.gxTpr_Subitems) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Subitems);
         }

      }

      public SdtgpxMenuItems_gpxMenuItem sdt
      {
         get {
            return (SdtgpxMenuItems_gpxMenuItem)Sdt ;
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
            sdt = new SdtgpxMenuItems_gpxMenuItem() ;
         }
      }

   }

}
