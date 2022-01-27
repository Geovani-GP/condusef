/*
               File: type_SdtSchedulerEvents
        Description: SchedulerEvents
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:8:21.75
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
   [XmlRoot(ElementName = "data" )]
   [XmlType(TypeName =  "data" , Namespace = "" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtSchedulerEvents_event ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtSchedulerEvents_Day ))]
   [Serializable]
   public class SdtSchedulerEvents : GxUserType
   {
      public SdtSchedulerEvents( )
      {
         /* Constructor for serialization */
      }

      public SdtSchedulerEvents( IGxContext context )
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
         SdtSchedulerEvents deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType());
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSchedulerEvents)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSchedulerEvents obj ;
         obj = this;
         obj.gxTpr_Items = deserialized.gxTpr_Items;
         obj.gxTpr_Specialdays = deserialized.gxTpr_Specialdays;
         return  ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name;
         if ( oReader.IsSimple == 0 )
         {
            if ( gxTv_SdtSchedulerEvents_Items != null )
            {
               gxTv_SdtSchedulerEvents_Items.ClearCollection();
            }
            if ( gxTv_SdtSchedulerEvents_Specialdays != null )
            {
               gxTv_SdtSchedulerEvents_Specialdays.ClearCollection();
            }
            GXSoapError = oReader.Read();
            nOutParmCount = 0;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0;
               if ( StringUtil.StrCmp(oReader.LocalName, "event") == 0 )
               {
                  if ( gxTv_SdtSchedulerEvents_Items == null )
                  {
                     gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
                  }
                  GXSoapError = gxTv_SdtSchedulerEvents_Items.readxmlcollection(oReader, "", "event");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Day") == 0 )
               {
                  if ( gxTv_SdtSchedulerEvents_Specialdays == null )
                  {
                     gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
                  }
                  GXSoapError = gxTv_SdtSchedulerEvents_Specialdays.readxmlcollection(oReader, "", "Day");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
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
            sName = "data";
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "";
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
         if ( gxTv_SdtSchedulerEvents_Items != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "";
            }
            else
            {
               sNameSpace1 = "";
            }
            gxTv_SdtSchedulerEvents_Items.writexmlcollection(oWriter, "", sNameSpace1, "event", sNameSpace1);
         }
         if ( gxTv_SdtSchedulerEvents_Specialdays != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "";
            }
            else
            {
               sNameSpace1 = "";
            }
            gxTv_SdtSchedulerEvents_Specialdays.writexmlcollection(oWriter, "", sNameSpace1, "Day", sNameSpace1);
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
         if ( gxTv_SdtSchedulerEvents_Items != null )
         {
            AddObjectProperty("Items", gxTv_SdtSchedulerEvents_Items, false);
         }
         if ( gxTv_SdtSchedulerEvents_Specialdays != null )
         {
            AddObjectProperty("SpecialDays", gxTv_SdtSchedulerEvents_Specialdays, false);
         }
         return  ;
      }

      public class gxTv_SdtSchedulerEvents_Items_SdtSchedulerEvents_event_80compatibility:SdtSchedulerEvents_event {}
      [  SoapElement( ElementName = "event" )]
      [  XmlElement( ElementName = "event" , Namespace = "" , Type= typeof( SdtSchedulerEvents_event ))]
      public GxObjectCollection gxTpr_Items_GxObjectCollection
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Items == null )
            {
               gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtSchedulerEvents_Items ;
         }

         set {
            if ( gxTv_SdtSchedulerEvents_Items == null )
            {
               gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
            }
            gxTv_SdtSchedulerEvents_Items = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Items
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Items == null )
            {
               gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
            }
            return gxTv_SdtSchedulerEvents_Items ;
         }

         set {
            gxTv_SdtSchedulerEvents_Items = value;
         }

      }

      public void gxTv_SdtSchedulerEvents_Items_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Items = null;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Items_IsNull( )
      {
         if ( gxTv_SdtSchedulerEvents_Items == null )
         {
            return true ;
         }
         return false ;
      }

      public class gxTv_SdtSchedulerEvents_Specialdays_SdtSchedulerEvents_Day_80compatibility:SdtSchedulerEvents_Day {}
      [  SoapElement( ElementName = "Day" )]
      [  XmlElement( ElementName = "Day" , Namespace = "" , Type= typeof( SdtSchedulerEvents_Day ))]
      public GxObjectCollection gxTpr_Specialdays_GxObjectCollection
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Specialdays == null )
            {
               gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtSchedulerEvents_Specialdays ;
         }

         set {
            if ( gxTv_SdtSchedulerEvents_Specialdays == null )
            {
               gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
            }
            gxTv_SdtSchedulerEvents_Specialdays = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Specialdays
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Specialdays == null )
            {
               gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
            }
            return gxTv_SdtSchedulerEvents_Specialdays ;
         }

         set {
            gxTv_SdtSchedulerEvents_Specialdays = value;
         }

      }

      public void gxTv_SdtSchedulerEvents_Specialdays_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Specialdays = null;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Specialdays_IsNull( )
      {
         if ( gxTv_SdtSchedulerEvents_Specialdays == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      [ObjectCollection(ItemType=typeof( SdtSchedulerEvents_event ))]
      protected IGxCollection gxTv_SdtSchedulerEvents_Items=null ;
      [ObjectCollection(ItemType=typeof( SdtSchedulerEvents_Day ))]
      protected IGxCollection gxTv_SdtSchedulerEvents_Specialdays=null ;
   }

   [DataContract(Name = @"SchedulerEvents", Namespace = "")]
   public class SdtSchedulerEvents_RESTInterface : GxGenericCollectionItem<SdtSchedulerEvents>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSchedulerEvents_RESTInterface( ) : base()
      {
      }

      public SdtSchedulerEvents_RESTInterface( SdtSchedulerEvents psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Items" , Order = 0 )]
      public GxGenericCollection<SdtSchedulerEvents_event_RESTInterface> gxTpr_Items
      {
         get {
            return new GxGenericCollection<SdtSchedulerEvents_event_RESTInterface>(sdt.gxTpr_Items) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Items);
         }

      }

      [DataMember( Name = "SpecialDays" , Order = 1 )]
      public GxGenericCollection<SdtSchedulerEvents_Day_RESTInterface> gxTpr_Specialdays
      {
         get {
            return new GxGenericCollection<SdtSchedulerEvents_Day_RESTInterface>(sdt.gxTpr_Specialdays) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Specialdays);
         }

      }

      public SdtSchedulerEvents sdt
      {
         get {
            return (SdtSchedulerEvents)Sdt ;
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
            sdt = new SdtSchedulerEvents() ;
         }
      }

   }

}
