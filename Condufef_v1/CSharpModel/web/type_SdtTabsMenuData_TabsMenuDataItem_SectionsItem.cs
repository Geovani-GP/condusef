/*
               File: type_SdtTabsMenuData_TabsMenuDataItem_SectionsItem
        Description: TabsMenuData
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:38.16
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
   [XmlRoot(ElementName = "TabsMenuData.TabsMenuDataItem.SectionsItem" )]
   [XmlType(TypeName =  "TabsMenuData.TabsMenuDataItem.SectionsItem" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class SdtTabsMenuData_TabsMenuDataItem_SectionsItem : GxUserType
   {
      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem( )
      {
         /* Constructor for serialization */
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = "";
      }

      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem( IGxContext context )
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
         SdtTabsMenuData_TabsMenuDataItem_SectionsItem deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtTabsMenuData_TabsMenuDataItem_SectionsItem)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtTabsMenuData_TabsMenuDataItem_SectionsItem obj ;
         obj = this;
         obj.gxTpr_Sectionid = deserialized.gxTpr_Sectionid;
         obj.gxTpr_Sectiontitle = deserialized.gxTpr_Sectiontitle;
         obj.gxTpr_Sectiondescription = deserialized.gxTpr_Sectiondescription;
         obj.gxTpr_Sectionurl = deserialized.gxTpr_Sectionurl;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "SectionId") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SectionTitle") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SectionDescription") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SectionURL") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = oReader.Value;
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
            sName = "TabsMenuData.TabsMenuDataItem.SectionsItem";
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
         oWriter.WriteElement("SectionId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("SectionTitle", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("SectionDescription", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("SectionURL", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
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
         AddObjectProperty("SectionId", gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid, false);
         AddObjectProperty("SectionTitle", gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle, false);
         AddObjectProperty("SectionDescription", gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription, false);
         AddObjectProperty("SectionURL", gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl, false);
         return  ;
      }

      [  SoapElement( ElementName = "SectionId" )]
      [  XmlElement( ElementName = "SectionId"   )]
      public short gxTpr_Sectionid
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid = (short)(value);
         }

      }

      [  SoapElement( ElementName = "SectionTitle" )]
      [  XmlElement( ElementName = "SectionTitle"   )]
      public String gxTpr_Sectiontitle
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = (String)(value);
         }

      }

      [  SoapElement( ElementName = "SectionDescription" )]
      [  XmlElement( ElementName = "SectionDescription"   )]
      public String gxTpr_Sectiondescription
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = (String)(value);
         }

      }

      [  SoapElement( ElementName = "SectionURL" )]
      [  XmlElement( ElementName = "SectionURL"   )]
      public String gxTpr_Sectionurl
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = "";
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription ;
      protected String sTagName ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl ;
   }

   [DataContract(Name = @"TabsMenuData.TabsMenuDataItem.SectionsItem", Namespace = "Condufef_v1")]
   public class SdtTabsMenuData_TabsMenuDataItem_SectionsItem_RESTInterface : GxGenericCollectionItem<SdtTabsMenuData_TabsMenuDataItem_SectionsItem>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem_RESTInterface( ) : base()
      {
      }

      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem_RESTInterface( SdtTabsMenuData_TabsMenuDataItem_SectionsItem psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SectionId" , Order = 0 )]
      public Nullable<short> gxTpr_Sectionid
      {
         get {
            return sdt.gxTpr_Sectionid ;
         }

         set {
            sdt.gxTpr_Sectionid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SectionTitle" , Order = 1 )]
      public String gxTpr_Sectiontitle
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Sectiontitle) ;
         }

         set {
            sdt.gxTpr_Sectiontitle = (String)(value);
         }

      }

      [DataMember( Name = "SectionDescription" , Order = 2 )]
      public String gxTpr_Sectiondescription
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Sectiondescription) ;
         }

         set {
            sdt.gxTpr_Sectiondescription = (String)(value);
         }

      }

      [DataMember( Name = "SectionURL" , Order = 3 )]
      public String gxTpr_Sectionurl
      {
         get {
            return sdt.gxTpr_Sectionurl ;
         }

         set {
            sdt.gxTpr_Sectionurl = (String)(value);
         }

      }

      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem sdt
      {
         get {
            return (SdtTabsMenuData_TabsMenuDataItem_SectionsItem)Sdt ;
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
            sdt = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem() ;
         }
      }

   }

}
