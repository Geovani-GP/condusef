/*
               File: type_SdtTabsMenuData_TabsMenuDataItem
        Description: TabsMenuData
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/28/2022 1:41:45.8
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
   [XmlRoot(ElementName = "TabsMenuData.TabsMenuDataItem" )]
   [XmlType(TypeName =  "TabsMenuData.TabsMenuDataItem" , Namespace = "Condufef_v1" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtTabsMenuData_TabsMenuDataItem_SectionsItem ))]
   [Serializable]
   public class SdtTabsMenuData_TabsMenuDataItem : GxUserType
   {
      public SdtTabsMenuData_TabsMenuDataItem( )
      {
         /* Constructor for serialization */
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = "";
      }

      public SdtTabsMenuData_TabsMenuDataItem( IGxContext context )
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
         SdtTabsMenuData_TabsMenuDataItem deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtTabsMenuData_TabsMenuDataItem)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtTabsMenuData_TabsMenuDataItem obj ;
         obj = this;
         obj.gxTpr_Menuid = deserialized.gxTpr_Menuid;
         obj.gxTpr_Menutitle = deserialized.gxTpr_Menutitle;
         obj.gxTpr_Menudescription = deserialized.gxTpr_Menudescription;
         obj.gxTpr_Menuurl = deserialized.gxTpr_Menuurl;
         obj.gxTpr_Sections = deserialized.gxTpr_Sections;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "MenuId") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MenuTitle") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MenuDescription") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MenuURL") )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Sections") )
               {
                  if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
                  {
                     gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections.readxmlcollection(oReader, "Sections", "SectionsItem");
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
            sName = "TabsMenuData.TabsMenuDataItem";
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
         oWriter.WriteElement("MenuId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("MenuTitle", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("MenuDescription", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("MenuURL", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections != null )
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
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections.writexmlcollection(oWriter, "Sections", sNameSpace1, "SectionsItem", sNameSpace1);
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
         AddObjectProperty("MenuId", gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid, false);
         AddObjectProperty("MenuTitle", gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle, false);
         AddObjectProperty("MenuDescription", gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription, false);
         AddObjectProperty("MenuURL", gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl, false);
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections != null )
         {
            AddObjectProperty("Sections", gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "MenuId" )]
      [  XmlElement( ElementName = "MenuId"   )]
      public short gxTpr_Menuid
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid = (short)(value);
         }

      }

      [  SoapElement( ElementName = "MenuTitle" )]
      [  XmlElement( ElementName = "MenuTitle"   )]
      public String gxTpr_Menutitle
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = (String)(value);
         }

      }

      [  SoapElement( ElementName = "MenuDescription" )]
      [  XmlElement( ElementName = "MenuDescription"   )]
      public String gxTpr_Menudescription
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = (String)(value);
         }

      }

      [  SoapElement( ElementName = "MenuURL" )]
      [  XmlElement( ElementName = "MenuURL"   )]
      public String gxTpr_Menuurl
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = (String)(value);
         }

      }

      public class gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_80compatibility:SdtTabsMenuData_TabsMenuDataItem_SectionsItem {}
      [  SoapElement( ElementName = "Sections" )]
      [  XmlArray( ElementName = "Sections"  )]
      [  XmlArrayItemAttribute( Type= typeof( SdtTabsMenuData_TabsMenuDataItem_SectionsItem ), ElementName= "SectionsItem"  , IsNullable=false)]
      [  XmlArrayItemAttribute( Type= typeof( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_80compatibility ), ElementName= "TabsMenuData.TabsMenuDataItem.SectionsItem"  , IsNullable=false)]
      public GxObjectCollection gxTpr_Sections_GxObjectCollection
      {
         get {
            if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
            {
               gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections ;
         }

         set {
            if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
            {
               gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
            }
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Sections
      {
         get {
            if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
            {
               gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
            }
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = value;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = null;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_IsNull( )
      {
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = "";
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = "";
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription ;
      protected String sTagName ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem_SectionsItem ))]
      protected IGxCollection gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections=null ;
   }

   [DataContract(Name = @"TabsMenuData.TabsMenuDataItem", Namespace = "Condufef_v1")]
   public class SdtTabsMenuData_TabsMenuDataItem_RESTInterface : GxGenericCollectionItem<SdtTabsMenuData_TabsMenuDataItem>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtTabsMenuData_TabsMenuDataItem_RESTInterface( ) : base()
      {
      }

      public SdtTabsMenuData_TabsMenuDataItem_RESTInterface( SdtTabsMenuData_TabsMenuDataItem psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "MenuId" , Order = 0 )]
      public Nullable<short> gxTpr_Menuid
      {
         get {
            return sdt.gxTpr_Menuid ;
         }

         set {
            sdt.gxTpr_Menuid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "MenuTitle" , Order = 1 )]
      public String gxTpr_Menutitle
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Menutitle) ;
         }

         set {
            sdt.gxTpr_Menutitle = (String)(value);
         }

      }

      [DataMember( Name = "MenuDescription" , Order = 2 )]
      public String gxTpr_Menudescription
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Menudescription) ;
         }

         set {
            sdt.gxTpr_Menudescription = (String)(value);
         }

      }

      [DataMember( Name = "MenuURL" , Order = 3 )]
      public String gxTpr_Menuurl
      {
         get {
            return sdt.gxTpr_Menuurl ;
         }

         set {
            sdt.gxTpr_Menuurl = (String)(value);
         }

      }

      [DataMember( Name = "Sections" , Order = 4 )]
      public GxGenericCollection<SdtTabsMenuData_TabsMenuDataItem_SectionsItem_RESTInterface> gxTpr_Sections
      {
         get {
            return new GxGenericCollection<SdtTabsMenuData_TabsMenuDataItem_SectionsItem_RESTInterface>(sdt.gxTpr_Sections) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Sections);
         }

      }

      public SdtTabsMenuData_TabsMenuDataItem sdt
      {
         get {
            return (SdtTabsMenuData_TabsMenuDataItem)Sdt ;
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
            sdt = new SdtTabsMenuData_TabsMenuDataItem() ;
         }
      }

   }

}
